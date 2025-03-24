using System.Reflection;
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
	private readonly Stopwatch _Stopwatch = new();
	private readonly CSTOJSOptions _DefaultOptions = new();

	private CSTOJSOptions _OptionsForContinuous = new();
	private Walker? _Walker = null;
	private FileSystemWatcher? _FSWatcher = null;

	private bool _IsRunning = false;

	/// <summary>
	/// New instance of <see cref="CSTOJS"/>.
	/// </summary>
	/// <param name="printVersion">Print version to the console.</param>

	public CSTOJS(bool printVersion = true)
	{
		if (printVersion)
		{
			Assembly assembly = Assembly.GetExecutingAssembly();
			//https://stackoverflow.com/a/73474279
			Log.WriteLine($"{assembly.GetName().Name} {assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion}", _DefaultOptions);
		}
	}

	/// <summary>
	/// Method for generating js file/files.
	/// </summary>
	/// <param name="path">Full path to cs file or to the folder with cs files.</param>
	/// <param name="options">Optional! Options of the CSTOJS, see <see cref="CSTOJSOptions"/> for default options.</param>
	/// <returns>empty Task</returns>
	/// <exception cref="DirectoryNotFoundException"></exception>
	public async Task GenerateOneAsync(string path, CSTOJSOptions? options = null)
	{
		if(options == null)
			options = _DefaultOptions;

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

			options.OutputFileName = null;
		}

		foreach (FileInfo file in files)
		{
			SyntaxTree? _tree = null;

			using (var stream = File.Open(file.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				_tree = CSharpSyntaxTree.ParseText(SourceText.From(stream), path: file.FullName);
			}

			Generate(_tree, assembly, options);

			if (!Directory.Exists(options.OutputPath))
			{
				Directory.CreateDirectory(options.OutputPath);
			}

			string pathCombined = string.Empty;

			if (options.OutputFileName != null)
				pathCombined = Path.Combine(options.OutputPath, options.OutputFileName);
			else
				pathCombined = Path.Combine(options.OutputPath, file.Name.Replace(".cs", ".js"));

			await File.WriteAllTextAsync(pathCombined, _Walker?.JSSB.ToString());

			Log.SuccessLine($"--- Done!", options);
			Log.SuccessLine($"--- Path: {pathCombined}", options);
			Log.SuccessLine($"--- --- ---", options);
		}
	}

	/// <summary>
	/// Method for generating js StringBuilder/StringBuilders.
	/// </summary>
	/// <param name="path">Full path to cs file or to the folder with cs files.</param>
	/// <param name="options">Optional! Options of the CSTOJS, see <see cref="CSTOJSOptions"/> for default options.</param>
	/// <returns>List of StringBuilder</returns>
	/// <exception cref="DirectoryNotFoundException"></exception>
	public List<StringBuilder> GenerateOne(string path, CSTOJSOptions? options = null)
	{
		if (options == null)
			options = _DefaultOptions;

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

			Generate(_tree, assembly, options);

			if (_Walker != null)
				jsStringBuilders.Add(_Walker.JSSB);
			else
				Log.ErrorLine("_Walker is null!", options);

			Log.SuccessLine($"--- Done!", options);
			Log.SuccessLine($"--- File name: {file.Name}", options);
			Log.SuccessLine($"--- --- ---", options);
		}

		return jsStringBuilders;
	}


	/// <summary>
	/// Method for generating from string.
	/// </summary>
	/// <param name="csstring">CSharp string.</param>
	/// <param name="options">Optional! Options of the CSTOJS, see <see cref="CSTOJSOptions"/> for default options.</param>
	/// <param name="references">Needed if you don't have access to files. Because Assembly.location is null in Blazor WebAssembly.</param>
	/// <returns>JS <see cref="StringBuilder"/></returns>
	/// <exception cref="ArgumentNullException"></exception>
	public StringBuilder GenerateOneFromString(string csstring, CSTOJSOptions? options = null, List<MetadataReference>? references = null)
	{
		if (options == null)
			options = _DefaultOptions;

		ArgumentNullException.ThrowIfNull(csstring);

		Assembly? assembly = Assembly.GetEntryAssembly();

		SyntaxTree _tree = CSharpSyntaxTree.ParseText(csstring);

		if (references != null)
			Generate(_tree, assembly, options, references);
		else
			Generate(_tree, assembly, options);

		Log.SuccessLine($"--- Done!", options);
		Log.SuccessLine($"--- --- ---", options);

		if (_Walker != null)
			return _Walker.JSSB;
		else
		{
			Log.ErrorLine("_Walker is null!", options);
			return new();
		}
	}

	/// <summary>
	/// Method for generating from string. Writes a file.
	/// </summary>
	/// <param name="csstring">CSharp string.</param>
	/// <param name="options">Optional! Options of the CSTOJS, see <see cref="CSTOJSOptions"/> for default options.</param>
	/// <param name="references">Needed if you don't have access to files. Because Assembly.location is null in Blazor WebAssembly.</param>
	/// <returns>empty Task</returns>
	/// <exception cref="ArgumentNullException"></exception>
	public async Task GenerateOneFromStringAsync(string csstring, CSTOJSOptions? options = null, List<MetadataReference>? references = null)
	{
		if (options == null)
			options = _DefaultOptions;

		ArgumentNullException.ThrowIfNull(csstring);

		Assembly? assembly = Assembly.GetEntryAssembly();

		SyntaxTree _tree = CSharpSyntaxTree.ParseText(csstring);

		if (references != null)
			Generate(_tree, assembly, options, references);
		else
			Generate(_tree, assembly, options);


		if (!Directory.Exists(options.OutputPath))
		{
			Directory.CreateDirectory(options.OutputPath);
		}

		string pathCombined = Path.Combine(options.OutputPath, options.OutputFileName ?? "main.js");

		if (_Walker != null)
			await File.WriteAllTextAsync(pathCombined, _Walker.JSSB.ToString());
		else
			Log.ErrorLine("_Walker is null!", options);

		Log.SuccessLine($"--- Done!", options);
		Log.SuccessLine($"--- Path: {pathCombined}", options);
		Log.SuccessLine($"--- --- ---", options);
	}

	/// <summary>
	/// Method for generating continuously by watching the cs file. Writes a file.
	/// </summary>
	/// <remarks>
	/// <blockquote class="NOTE"><h5>NOTE</h5><para>Note: You must call <see cref="CSTOJS.StopWatching" /> before completing a program.</para></blockquote>
	/// </remarks>
	/// <param name="path">Full path to cs file.</param>
	/// <param name="options">Optional! Options of the CSTOJS, see <see cref="CSTOJSOptions"/> for default options.</param>
	/// <returns>void</returns>
	/// <exception cref="DirectoryNotFoundException"></exception>
	/// <exception cref="FileNotFoundException"></exception>
	public void GenerateOneContinuously(string path, CSTOJSOptions? options = null) 
	{
		if (options != null)
			_OptionsForContinuous = options;

		if (File.Exists(path))
		{
			FileInfo file = new(path);

			if(file.Directory == null)
				throw new DirectoryNotFoundException(path);

			_FSWatcher = new(file.Directory.FullName)
			{
				NotifyFilter = NotifyFilters.LastWrite
			};

			_FSWatcher.Changed += OnChanged;
			_FSWatcher.Created += OnCreated;
			_FSWatcher.Deleted += OnDeleted;
			_FSWatcher.Renamed += OnRenamed;
			_FSWatcher.Error += OnError;

			_FSWatcher.Filter = file.Name;
			_FSWatcher.IncludeSubdirectories = true;
			_FSWatcher.EnableRaisingEvents = true;

			Log.WriteLine($"Watching to: {path}", _OptionsForContinuous);
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

		Log.WriteLine($"Changed: {e.FullPath}", _DefaultOptions);

		if(!_IsRunning)
			await GenerateOneAsync(e.FullPath);
	}

	private void OnCreated(object sender, FileSystemEventArgs e)
	{
		string value = $"Created: {e.FullPath}";
		Log.WriteLine(value, _DefaultOptions);
	}

	private void OnDeleted(object sender, FileSystemEventArgs e)
	{
		Log.WriteLine($"Deleted: {e.FullPath}", _DefaultOptions);
	}

	private void OnRenamed(object sender, RenamedEventArgs e)
	{
		Log.WriteLine($"Renamed:", _DefaultOptions);
		Log.WriteLine($"    Old: {e.OldFullPath}", _DefaultOptions);
		Log.WriteLine($"    New: {e.FullPath}", _DefaultOptions);
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
		_OptionsForContinuous = new();

		if (_FSWatcher != null)
		{
			_FSWatcher.Dispose();
			_FSWatcher = null;
		}
	}

	private void Generate(SyntaxTree tree, Assembly? assembly, CSTOJSOptions options, List<MetadataReference>? refs = null)
	{
		_IsRunning = true;

		if (options.Debug)
		{
			_Stopwatch.Restart();
			Log.WriteLine("Start stopwatch", options);
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

				AssemblyName[] a = assembly?.GetReferencedAssemblies() ?? [];
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

		if (options.NormalizeWhitespace)
			trueRoot = trueRoot.NormalizeWhitespace();

		if (options.KeepBraceOnTheSameLine)
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

		if (options.Debug)
		{
			Log.SuccessLine($"+++", options);
			Log.WriteLine($"Path assembly: {assemblyPath}", options);
			Log.WriteLine($"Path rt: {rtPath}", options);
			Log.WriteLine($"List of references({references.Count}):", options);
			foreach (MetadataReference reference in references)
			{
				Log.WriteLine(reference.Display ?? "null display string", options);
			}
			Log.WriteLine($"List of trueReferences({trueReferences.Count}):", options);
			foreach (MetadataReference reference in trueReferences)
			{
				Log.WriteLine(reference.Display ?? "null display string", options);
			}
			Log.SuccessLine($"+++", options);
		}

		SyntaxTree trueST = trueRoot.SyntaxTree;
		CSharpCompilation compilation = CSharpCompilation
			.Create("HelloWorld")
			.AddReferences(trueReferences.ToArray())
			.AddSyntaxTrees(trueST);


		_Walker = new(options, compilation.GetSemanticModel(trueST));

		_Walker.JSSB.Append(options.AddSBAtTheTop);

		_Walker.Visit(trueRoot);

		_Walker.JSSB.Append(options.AddSBAtTheBottom);

		if (options.Debug)
		{
			_Stopwatch.Stop();
			Log.WriteLine($"Stop stopwatch: {_Stopwatch.Elapsed}", options);
		}

		_IsRunning = false;
	}
}