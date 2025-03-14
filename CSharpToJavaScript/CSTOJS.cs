﻿using System.Reflection;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.Text;
using System.Text;
using System;
using CSharpToJavaScript.Utils;


namespace CSharpToJavaScript;

/// <summary>
/// Main type for CSharpToJavaScript.
/// </summary>
public class CSTOJS
{
	private readonly CSTOJSOptions _Options = new();
	private readonly Stopwatch _Stopwatch = new();

	private Walker? _Walker = null;
	private FileSystemWatcher? _FSWatcher = null;

	private bool _IsRunning = false;

	/// <summary>
	/// New instance of <see cref="CSTOJS"/> with default options, see <see cref="CSTOJSOptions"/>.
	/// </summary>
	public CSTOJS()
	{
		PrintVersion();
	}

	/// <summary>
	/// New instance of <see cref="CSTOJS"/>
	/// </summary>
	/// <param name="options">Options of <see cref="CSTOJS"/>, see <see cref="CSTOJSOptions"/>.</param>
	public CSTOJS(CSTOJSOptions options)
	{
		_Options = options;

		if (_Options.DisableConsoleOutput == false)
		{
			PrintVersion();
		}
	}

	/// <summary>
	/// Method for generating js file/files.
	/// </summary>
	/// <param name="path">Full path to cs file or to the folder with cs files.</param>
	/// <param name="filename">Optional! Filename of a js file if you generating one file!</param>
	/// <returns>empty Task</returns>
	/// <exception cref="DirectoryNotFoundException"></exception>
	public async Task GenerateOneAsync(string path, string? filename = null)
	{
		Assembly? assembly = Assembly.GetEntryAssembly();
		List<FileInfo> files = new();

		if (File.Exists(path))
		{
			files.Add(new FileInfo(path));
		}
		else
		{
			if (!Directory.Exists(path))
				throw new DirectoryNotFoundException(path);

			DirectoryInfo folder = new(path);

			files = folder.GetFiles("*.cs").ToList();

			filename = null;
		}

		foreach (FileInfo file in files)
		{
			SyntaxTree? _tree = null;

			using (var stream = File.Open(file.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				_tree = CSharpSyntaxTree.ParseText(SourceText.From(stream), path: file.FullName);
			}

			Generate(_tree, assembly);

			if (!Directory.Exists(_Options.OutPutPath))
			{
				Directory.CreateDirectory(_Options.OutPutPath);
			}

			string pathCombined = string.Empty;

			if (filename != null)
				pathCombined = Path.Combine(_Options.OutPutPath, filename);
			else
				pathCombined = Path.Combine(_Options.OutPutPath, file.Name.Replace(".cs", ".js"));

			await File.WriteAllTextAsync(pathCombined, _Walker?.JSSB.ToString());

			Log.SuccessLine($"--- Done!", _Options);
			Log.SuccessLine($"--- Path: {pathCombined}", _Options);
			Log.SuccessLine($"--- --- ---", _Options);
		}
	}

	/// <summary>
	/// Method for generating js StringBuilder/StringBuilders.
	/// </summary>
	/// <param name="path">Full path to cs file or to the folder with cs files.</param>
	/// <returns>List of StringBuilder</returns>
	/// <exception cref="DirectoryNotFoundException"></exception>
	public List<StringBuilder> GenerateOne(string path)
	{
		Assembly? assembly = Assembly.GetEntryAssembly();
		List<FileInfo> files = new();
		List<StringBuilder> jsStringBuilders = new();

		if (File.Exists(path))
		{
			files.Add(new FileInfo(path));
		}
		else
		{
			if (!Directory.Exists(path))
				throw new DirectoryNotFoundException(path);

			DirectoryInfo folder = new(path);

			files = folder.GetFiles("*.cs").ToList();
		}

		foreach (FileInfo file in files)
		{
			SyntaxTree? _tree = null;

			using (var stream = File.OpenRead(file.FullName))
			{
				_tree = CSharpSyntaxTree.ParseText(SourceText.From(stream), path: file.FullName);
			}

			Generate(_tree, assembly);

			jsStringBuilders.Add(_Walker.JSSB);

			Log.SuccessLine($"--- Done!", _Options);
			Log.SuccessLine($"--- File name: {file.Name}", _Options);
			Log.SuccessLine($"--- --- ---", _Options);
		}

		return jsStringBuilders;
	}


	/// <summary>
	/// Method for generating from string.
	/// </summary>
	/// <param name="csstring">CSharp string.</param>
	/// <param name="references">Needed if you don't have access to files. Because Assembly.location is null in Blazor WebAssembly.</param>
	/// <returns>JS <see cref="StringBuilder"/></returns>
	/// <exception cref="ArgumentNullException"></exception>
	public StringBuilder GenerateOneFromString(string csstring, List<MetadataReference>? references = null)
	{
		ArgumentNullException.ThrowIfNull(csstring);

		Assembly? assembly = Assembly.GetEntryAssembly();

		SyntaxTree _tree = CSharpSyntaxTree.ParseText(csstring);

		if (references != null)
			Generate(_tree, assembly, references);
		else
			Generate(_tree, assembly);

		Log.SuccessLine($"--- Done!", _Options);
		Log.SuccessLine($"--- --- ---", _Options);

		return _Walker.JSSB;
	}

	/// <summary>
	/// Method for generating from string. Writes a file.
	/// </summary>
	/// <param name="csstring">CSharp string.</param>
	/// <param name="filename">Filename of a js file.</param>
	/// <param name="references">Needed if you don't have access to files. Because Assembly.location is null in Blazor WebAssembly.</param>
	/// <returns>empty Task</returns>
	/// <exception cref="ArgumentNullException"></exception>
	public async Task GenerateOneFromStringAsync(string csstring, string? filename = "main.js", List<MetadataReference>? references = null)
	{
		ArgumentNullException.ThrowIfNull(csstring);

		Assembly? assembly = Assembly.GetEntryAssembly();

		SyntaxTree _tree = CSharpSyntaxTree.ParseText(csstring);

		if (references != null)
			Generate(_tree, assembly, references);
		else
			Generate(_tree, assembly);


		if (!Directory.Exists(_Options.OutPutPath))
		{
			Directory.CreateDirectory(_Options.OutPutPath);
		}

		string pathCombined = Path.Combine(_Options.OutPutPath, filename);

		await File.WriteAllTextAsync(pathCombined, _Walker.JSSB.ToString());

		Log.SuccessLine($"--- Done!", _Options);
		Log.SuccessLine($"--- Path: {pathCombined}", _Options);
		Log.SuccessLine($"--- --- ---", _Options);
	}

	/// <summary>
	/// Method for generating continuously by watching the cs file. Writes a file.
	/// </summary>
	/// <remarks>
	/// <blockquote class="NOTE"><h5>NOTE</h5><para>Note: You must call <see cref="CSTOJS.StopWatching" /> before completing a program.</para></blockquote>
	/// </remarks>
	/// <param name="path">Full path to cs file.</param>
	/// <returns>void</returns>
	/// <exception cref="DirectoryNotFoundException"></exception>
	/// <exception cref="FileNotFoundException"></exception>
	public void GenerateOneContinuously(string path) 
	{
		if (File.Exists(path))
		{
			FileInfo file = new(path);

			if(file.Directory == null)
				throw new DirectoryNotFoundException(path);

			_FSWatcher = new(file.Directory.FullName);

			_FSWatcher.NotifyFilter = NotifyFilters.LastWrite;

			_FSWatcher.Changed += OnChanged;
			_FSWatcher.Created += OnCreated;
			_FSWatcher.Deleted += OnDeleted;
			_FSWatcher.Renamed += OnRenamed;
			_FSWatcher.Error += OnError;

			_FSWatcher.Filter = file.Name;
			_FSWatcher.IncludeSubdirectories = true;
			_FSWatcher.EnableRaisingEvents = true;

			Log.WriteLine($"Watching to: {path}", _Options);
		}
		else
		{
			throw new FileNotFoundException(path);
		}
	}
	private async void OnChanged(object sender, FileSystemEventArgs e)
	{
		if (e.ChangeType != WatcherChangeTypes.Changed)
			return;

		Log.WriteLine($"Changed: {e.FullPath}", _Options);

		if(!_IsRunning)
			await GenerateOneAsync(e.FullPath);
	}

	private void OnCreated(object sender, FileSystemEventArgs e)
	{
		string value = $"Created: {e.FullPath}";
		Log.WriteLine(value, _Options);
	}

	private void OnDeleted(object sender, FileSystemEventArgs e)
	{
		Log.WriteLine($"Deleted: {e.FullPath}", _Options);
	}

	private void OnRenamed(object sender, RenamedEventArgs e)
	{
		Log.WriteLine($"Renamed:", _Options);
		Log.WriteLine($"    Old: {e.OldFullPath}", _Options);
		Log.WriteLine($"    New: {e.FullPath}", _Options);
	}

	private void OnError(object sender, ErrorEventArgs e)
	{
		throw e.GetException();
	}

	/// <summary>
	/// Method for stopping watching cs file. 
	/// </summary>
	public void StopWatching() 
	{
		if (_FSWatcher != null)
		{
			_FSWatcher.Dispose();
			_FSWatcher = null;
		}
	}

	private void Generate(SyntaxTree tree, Assembly? assembly, List<MetadataReference>? refs = null)
	{
		_IsRunning = true;

		if (_Options.Debug)
		{
			_Stopwatch.Restart();
			Log.WriteLine("Start stopwatch", _Options);
		}

		CompilationUnitSyntax root = tree.GetCompilationUnitRoot();


		string? assemblyPath = Path.GetDirectoryName(assembly?.Location);
		List<MetadataReference> references = new() { };

		string? rtPath = Path.GetDirectoryName(typeof(object).Assembly.Location);

		if (refs == null)
		{
			if (rtPath != null && assemblyPath != null)
			{
				references.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Private.CoreLib.dll")));

				AssemblyName[] a = assembly.GetReferencedAssemblies();
				foreach (AssemblyName item in a)
				{
					if (File.Exists(Path.Combine(assemblyPath, item.Name + ".dll")))
						references.Add(MetadataReference.CreateFromFile(Path.Combine(assemblyPath, item.Name + ".dll")));
					else
					{
						if (File.Exists(Path.Combine(rtPath, item.Name + ".dll")))
							references.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, item.Name + ".dll")));
					}
				}
			}
		}
		else
		{
			references = refs;
		}

		UsingDirectiveSyntax[] oldUsing = root.Usings.ToArray();

		//https://roslynquoter.azurewebsites.net/
		//
		//https://stackoverflow.com/a/72938702
		CompilationUnitSyntax trueRoot = root.WithUsings
		(
			SyntaxFactory.List<UsingDirectiveSyntax>
			(
				new UsingDirectiveSyntax[]
				{
					SyntaxFactory.UsingDirective
					(
						SyntaxFactory.AliasQualifiedName
						(
							SyntaxFactory.IdentifierName
							(
								SyntaxFactory.Token(SyntaxKind.GlobalKeyword)
							),
							SyntaxFactory.IdentifierName("System")
						)
					)
					.WithGlobalKeyword
					(
						SyntaxFactory.Token(SyntaxKind.GlobalKeyword)
					),
					SyntaxFactory.UsingDirective
					(
						SyntaxFactory.QualifiedName
						(
							SyntaxFactory.QualifiedName
							(
								SyntaxFactory.AliasQualifiedName
								(
									SyntaxFactory.IdentifierName
									(
										SyntaxFactory.Token(SyntaxKind.GlobalKeyword)
									),
									SyntaxFactory.IdentifierName("System")
								),
								SyntaxFactory.IdentifierName("Collections")
							),
							SyntaxFactory.IdentifierName("Generic")
						)
					)
					.WithGlobalKeyword
					(
						SyntaxFactory.Token(SyntaxKind.GlobalKeyword)
					),
					SyntaxFactory.UsingDirective
					(
						SyntaxFactory.QualifiedName
						(
							SyntaxFactory.AliasQualifiedName
							(
								SyntaxFactory.IdentifierName
								(
									SyntaxFactory.Token(SyntaxKind.GlobalKeyword)
								),
								SyntaxFactory.IdentifierName("System")
							),
							SyntaxFactory.IdentifierName("IO")
						)
					)
					.WithGlobalKeyword
					(
						SyntaxFactory.Token(SyntaxKind.GlobalKeyword)
					),
					SyntaxFactory.UsingDirective
					(
						SyntaxFactory.QualifiedName
						(
							SyntaxFactory.AliasQualifiedName
							(
								SyntaxFactory.IdentifierName
								(
									SyntaxFactory.Token(SyntaxKind.GlobalKeyword)
								),
								SyntaxFactory.IdentifierName("System")
							),
							SyntaxFactory.IdentifierName("Linq")
						)
					)
					.WithGlobalKeyword
					(
						SyntaxFactory.Token(SyntaxKind.GlobalKeyword)
					),
					SyntaxFactory.UsingDirective
					(
						SyntaxFactory.QualifiedName
						(
							SyntaxFactory.QualifiedName
							(
								SyntaxFactory.AliasQualifiedName
								(
									SyntaxFactory.IdentifierName
									(
										SyntaxFactory.Token(SyntaxKind.GlobalKeyword)
									),
									SyntaxFactory.IdentifierName("System")
								),
								SyntaxFactory.IdentifierName("Net")
							),
							SyntaxFactory.IdentifierName("Http")
						)
					)
					.WithGlobalKeyword
					(
						SyntaxFactory.Token(SyntaxKind.GlobalKeyword)
					),
					SyntaxFactory.UsingDirective
					(
						SyntaxFactory.QualifiedName
						(
							SyntaxFactory.AliasQualifiedName
							(
								SyntaxFactory.IdentifierName
								(
									SyntaxFactory.Token(SyntaxKind.GlobalKeyword)
								),
								SyntaxFactory.IdentifierName("System")
							),
							SyntaxFactory.IdentifierName("Threading")
						)
					)
					.WithGlobalKeyword
					(
						SyntaxFactory.Token(SyntaxKind.GlobalKeyword)
					),
					SyntaxFactory.UsingDirective
					(
						SyntaxFactory.QualifiedName
						(
							SyntaxFactory.QualifiedName
							(
								SyntaxFactory.AliasQualifiedName
								(
									SyntaxFactory.IdentifierName
									(
										SyntaxFactory.Token(SyntaxKind.GlobalKeyword)
									),
									SyntaxFactory.IdentifierName("System")
								),
								SyntaxFactory.IdentifierName("Threading")
							),
							SyntaxFactory.IdentifierName("Tasks")
						)
					)
					.WithGlobalKeyword
					(
						SyntaxFactory.Token(SyntaxKind.GlobalKeyword)
					)
				}
			)
		).AddUsings(oldUsing);

		if (_Options.NormalizeWhitespace)
			trueRoot = trueRoot.NormalizeWhitespace();

		if (_Options.KeepBraceOnTheSameLine)
		{
			//Mostly deleted whitespaces, still TODO?
			SyntaxToken[] allBraces = trueRoot.DescendantTokens().Where((e) => e.IsKind(SyntaxKind.OpenBraceToken)).ToArray();
		
			List<SyntaxTrivia> allTriviaToDelete = new();
			
			for (int i = 0; i < allBraces.Length; i++)
			{
				if (allBraces[i].HasLeadingTrivia)
				{
					SyntaxTriviaList _lt = allBraces[i].LeadingTrivia;
					for (int j = 0; j < _lt.Count; j++)
					{
						allTriviaToDelete.Add(_lt[j]);
					}
				}
			}
			//Is this the right way to delete trivia?
			trueRoot = trueRoot.ReplaceTrivia(allTriviaToDelete, (o, r) => SyntaxFactory.ElasticMarker);

			allBraces = trueRoot.DescendantTokens().Where((e) => e.IsKind(SyntaxKind.OpenBraceToken)).ToArray();

			List<SyntaxTrivia> allTriviaToReplace = new();

			for (int i = 0; i < allBraces.Length; i++)
			{
				SyntaxToken _token = allBraces[i].GetPreviousToken();
				if (_token.HasTrailingTrivia)
				{
					SyntaxTrivia _trivia = _token.TrailingTrivia.Where((e) => e.IsKind(SyntaxKind.EndOfLineTrivia)).FirstOrDefault();
					if (!_trivia.IsKind(SyntaxKind.None))
					{
						allTriviaToReplace.Add(_trivia);
					}
				}
			}
			trueRoot = trueRoot.ReplaceTrivia(allTriviaToReplace, (o, r) => SyntaxFactory.Space);
		}

		if (rtPath != null && rtPath != string.Empty)
		{
			if (File.Exists(Path.Combine(rtPath, "System.dll")))
				references.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.dll")));

			if (File.Exists(Path.Combine(rtPath, "System.Collections.Generics.dll")))
				references.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Collections.Generics.dll")));

			if (File.Exists(Path.Combine(rtPath, "System.IO.dll")))
				references.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.IO.dll")));

			if (File.Exists(Path.Combine(rtPath, "System.Linq.dll")))
				references.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Linq.dll")));

			if (File.Exists(Path.Combine(rtPath, "System.Net.Http.dll")))
				references.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Net.Http.dll")));

			if (File.Exists(Path.Combine(rtPath, "System.Threading.dll")))
				references.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Threading.dll")));

			if (File.Exists(Path.Combine(rtPath, "System.Threading.Tasks.dll")))
				references.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Threading.Tasks.dll")));

			if (File.Exists(Path.Combine(rtPath, "System.Console.dll")))
				references.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Console.dll")));

			foreach (UsingDirectiveSyntax oU in oldUsing)
			{
				if (File.Exists(Path.Combine(rtPath, oU.Name + ".dll")))
					references.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, oU.Name + ".dll")));
			}
		}

		if (assemblyPath != null && assemblyPath != string.Empty)
		{
			if (File.Exists(Path.Combine(assemblyPath, "CSharpToJavaScript.dll")))
				references.Add(MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "CSharpToJavaScript.dll")));
		}


		//https://stackoverflow.com/a/12073675
		List<MetadataReference> trueReferences = new();

		if (refs == null)
		{
			foreach (MetadataReference item in references)
			{
				bool found = false;
				foreach (MetadataReference resultItem in trueReferences)
				{
					if (item.Display == null)
						continue;

					if (resultItem.Display == item.Display)
						found = true;
				}

				if (!found)
				{
					trueReferences.Add(item);
				}
			}
		}
		else
		{
			trueReferences = references;
		}

		if (_Options.Debug)
		{
			Log.SuccessLine($"+++", _Options);
			Log.WriteLine($"Path assembly: {assemblyPath}", _Options);
			Log.WriteLine($"Path rt: {rtPath}", _Options);
			Log.WriteLine($"List of references({references.Count}):", _Options);
			foreach (MetadataReference reference in references)
			{
				Log.WriteLine(reference.Display ?? "null display string", _Options);
			}
			Log.WriteLine($"List of trueReferences({trueReferences.Count}):", _Options);
			foreach (MetadataReference reference in trueReferences)
			{
				Log.WriteLine(reference.Display ?? "null display string", _Options);
			}
			Log.SuccessLine($"+++", _Options);
		}

		SyntaxTree trueST = trueRoot.SyntaxTree;
		CSharpCompilation compilation = CSharpCompilation
			.Create("HelloWorld")
			.AddReferences(trueReferences.ToArray())
			.AddSyntaxTrees(trueST);


		_Walker = new(_Options, compilation.GetSemanticModel(trueST));

		_Walker.JSSB.Append(_Options.AddSBAtTheTop);

		_Walker.Visit(trueRoot);

		_Walker.JSSB.Append(_Options.AddSBAtTheBottom);

		if (_Options.Debug)
		{
			_Stopwatch.Stop();
			Log.WriteLine($"Stop stopwatch: {_Stopwatch.Elapsed}", _Options);
		}

		_IsRunning = false;
	}
	private void PrintVersion()
	{
		Assembly assembly = Assembly.GetExecutingAssembly();
		//https://stackoverflow.com/a/73474279
		Log.SuccessLine($"{assembly.GetName().Name} {assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion}", _Options);
	}
}