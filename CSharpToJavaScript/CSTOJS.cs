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

namespace CSharpToJavaScript
{
	/// <summary>
	/// Main type for CSharpToJavaScript.
	/// </summary>
	public class CSTOJS : ILog
	{
		private readonly CSTOJSOptions _Options = new();
		private readonly Stopwatch _Stopwatch = new();
		private readonly ILog? _Log = null;

		private Walker? _Walker = null;

		/// <summary>
		/// New instance of <see cref="CSTOJS"/> with default options, see <see cref="CSTOJSOptions"/>.
		/// </summary>
		public CSTOJS() 
		{
			_Log = ILog.GetILog(this, _Options);

			Assembly assembly = Assembly.GetExecutingAssembly();
			//https://stackoverflow.com/a/73474279
			_Log.SuccessLine($"{assembly.GetName().Name} {assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion}");
		}

		/// <summary>
		/// New instance of <see cref="CSTOJS"/>
		/// </summary>
		/// <param name="options">Options of <see cref="CSTOJS"/>, see <see cref="CSTOJSOptions"/>.</param>
		public CSTOJS(CSTOJSOptions options)
		{
			_Options = options;

			_Log = ILog.GetILog(this, _Options);

			if (_Options.DisableConsoleOutput == false)
			{
				Assembly assembly = Assembly.GetExecutingAssembly();
				//https://stackoverflow.com/a/73474279
				_Log.SuccessLine($"{assembly.GetName().Name} {assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion}");
			}
		}

		/// <summary>
		/// Method for generating js file/files.
		/// </summary>
		/// <param name="path">Full path to cs file or to the folder with cs files.</param>
		/// <param name="filename">Optional! Filename of a js file if you generating one file!</param>
		/// <returns>empty Task</returns>
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
				DirectoryInfo folder = new(path);

				files = folder.GetFiles("*.cs").ToList();

				filename = null;
			}

			foreach (FileInfo file in files)
			{
				SyntaxTree? _tree = null;

				using (var stream = File.OpenRead(file.FullName))
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

				_Log.SuccessLine($"--- Done!");
				_Log.SuccessLine($"--- Path: {pathCombined}");
				_Log.SuccessLine($"--- --- ---");
			}
		}

		/// <summary>
		/// Method for generating js StringBuilder/StringBuilders.
		/// </summary>
		/// <param name="path">Full path to cs file or to the folder with cs files.</param>
		/// <returns>List of StringBuilder</returns>
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

				_Log.SuccessLine($"--- Done!");
				_Log.SuccessLine($"--- File name: {file.Name}");
				_Log.SuccessLine($"--- --- ---");
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

			SyntaxTree? _tree = CSharpSyntaxTree.ParseText(csstring);
			
			if(references != null)
				Generate(_tree, assembly, references);
			else
				Generate(_tree, assembly);

			_Log.SuccessLine($"--- Done!");
			_Log.SuccessLine($"--- --- ---");

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

			SyntaxTree? _tree = CSharpSyntaxTree.ParseText(csstring);

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

			_Log.SuccessLine($"--- Done!");
			_Log.SuccessLine($"--- Path: {pathCombined}");
			_Log.SuccessLine($"--- --- ---");
		}


		private void Generate(SyntaxTree? tree, Assembly? assembly, List<MetadataReference>? refs = null) 
		{
			if(_Options.Debug) 
			{
				_Stopwatch.Restart();
				_Log.WriteLine("Start stopwatch");
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
			//Should I make "NormalizeWhitespace" option??? TODO!
			//.NormalizeWhitespace().AddUsings(oldUsing);

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

			//TODO! does not work... sigh
			references = references.Distinct().ToList();

			if (_Options.Debug)
			{
				_Log.SuccessLine($"+++");
				_Log.WriteLine($"Path assembly: {assemblyPath}");
				_Log.WriteLine($"Path rt: {rtPath}");
				_Log.WriteLine($"List of references:");
				foreach (MetadataReference reference in references)
				{
					_Log.WriteLine(reference.Display);
				}
				_Log.SuccessLine($"+++");
			}

			SyntaxTree trueST = trueRoot.SyntaxTree;
			CSharpCompilation compilation = CSharpCompilation
				.Create("HelloWorld")
				.AddReferences(references.ToArray())
				.AddSyntaxTrees(trueST);

			_Walker = new(_Options, compilation.GetSemanticModel(trueST));

			_Walker.JSSB.Append(_Options.AddSBInFront);

			_Walker.Visit(trueRoot);

			_Walker.JSSB.Append(_Options.AddSBInEnd);

			if (_Options.Debug)
			{
				_Stopwatch.Stop();
				_Log.WriteLine($"Stop stopwatch: {_Stopwatch.Elapsed}");
			}
		}

	}
}