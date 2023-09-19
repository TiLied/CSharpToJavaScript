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
using System.Runtime.CompilerServices;
using System;

namespace CSharpToJavaScript
{
	/// <summary>
	/// Main type for CSharpToJavaScript.
	/// </summary>
	public class CSTOJS
	{
		public SemanticModel Model { get; set; } = null;

		public CSTOJSOptions Options { get; set; } = new();

		private Walker _Walker = new();

		/// <summary>
		/// New instance of <see cref="CSTOJS"/> with default options, see <see cref="CSTOJSOptions"/>.
		/// </summary>
		public CSTOJS() 
		{
			if (Options.Debug)
			{
				if (File.Exists(Directory.GetCurrentDirectory() + "/debug.txt"))
					File.Delete(Directory.GetCurrentDirectory() + "/debug.txt");

				Trace.Listeners.Add(new TextWriterTraceListener("debug.txt"));
				Trace.AutoFlush = true;
			}

			Trace.Listeners.Add(new ConsoleTraceListener());

			Assembly assembly = Assembly.GetExecutingAssembly();
			//https://stackoverflow.com/a/73474279
			Log($"{assembly.GetName().Name} {assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion}");
		}

		/// <summary>
		/// New instance of <see cref="CSTOJS"/>
		/// </summary>
		/// <param name="options">Options of <see cref="CSTOJS"/>, see <see cref="CSTOJSOptions"/>.</param>
		public CSTOJS(CSTOJSOptions options)
		{
			Options = options;

			if (Options.Debug)
			{
				if (File.Exists(Directory.GetCurrentDirectory() + "/debug.txt"))
					File.Delete(Directory.GetCurrentDirectory() + "/debug.txt");

				Trace.Listeners.Add(new TextWriterTraceListener("debug.txt"));
				Trace.AutoFlush = true;
			}

			Trace.Listeners.Add(new ConsoleTraceListener());

			Assembly assembly = Assembly.GetExecutingAssembly();
			//https://stackoverflow.com/a/73474279
			Log($"{assembly.GetName().Name} {assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion}");
		}

		/// <summary>
		/// Method for generating js file.
		/// </summary>
		/// <param name="path">Full path to cs file.</param>
		/// <param name="filename">Filename of a js file.</param>
		/// <returns></returns>
		public async Task GenerateOneAsync(string path, string? filename = null) 
		{
			Assembly assembly = Assembly.GetEntryAssembly();

			FileInfo file = new(path);

			SyntaxTree? _tree = null;

			using (var stream = File.OpenRead(path))
			{
				_tree = CSharpSyntaxTree.ParseText(SourceText.From(stream), path: path);
			}

			await GenerateAsync(_tree, assembly);

			if (!Directory.Exists(Options.OutPutPath))
			{
				Directory.CreateDirectory(Options.OutPutPath);
			}

			string pathCombined = string.Empty;

			if (filename != null)
				pathCombined = Path.Combine(Options.OutPutPath, filename);
			else
				pathCombined = Path.Combine(Options.OutPutPath, file.Name.Replace(".cs", ".js"));


			await File.WriteAllTextAsync(pathCombined, _Walker.JSSB.ToString());

			Log($"--- Done!");
			Log($"--- Path: {pathCombined}");
			Log($"--- --- ---");
		}
		/// <summary>
		/// Method for generating from string.
		/// </summary>
		/// <param name="csstring">CSharp string.</param>
		/// <param name="references">Needed if you don't have access to files. Like if Blazor WebAssembly, because Assembly.location is empty.</param>
		/// <returns>JS <see cref="StringBuilder"/></returns>
		/// <exception cref="ArgumentNullException"></exception>
		public async Task<StringBuilder> GenerateOneFromStringAsync(string csstring, List<MetadataReference>? references = null) 
		{
			if (csstring == null)
				throw new ArgumentNullException(nameof(csstring));

			Assembly assembly = Assembly.GetEntryAssembly();

			SyntaxTree? _tree = CSharpSyntaxTree.ParseText(csstring.Normalize());
			
			if(references != null)
				await GenerateAsync(_tree, assembly, references);
			else
				await GenerateAsync(_tree, assembly);

			Log($"--- Done!");
			Log($"--- --- ---");

			return _Walker.JSSB;
		}
		/// <summary>
		/// Method for generating multiply js files.
		/// </summary>
		/// <param name="path">Full path to the folder/directory.</param>
		/// <returns></returns>
		public async Task GenerateManyAsync(string path)
		{
			Assembly assembly = Assembly.GetEntryAssembly();

			DirectoryInfo folder = new(path);

			FileInfo[] Files = folder.GetFiles("*.cs");

			foreach (FileInfo file in Files)
			{
				SyntaxTree? _tree = null;

				using (var stream = File.OpenRead(file.FullName))
				{
					_tree = CSharpSyntaxTree.ParseText(SourceText.From(stream), path: file.FullName);
				}

				await GenerateAsync(_tree, assembly);

				if (!Directory.Exists(Options.OutPutPath))
				{
					Directory.CreateDirectory(Options.OutPutPath);
				}

				string pathCombined = Path.Combine(Options.OutPutPath, file.Name.Replace(".cs", ".js"));

				await File.WriteAllTextAsync(pathCombined, _Walker.JSSB.ToString());

				Log($"--- Done!");
				Log($"--- Path: {pathCombined}");
				Log($"--- --- ---");
			}
		}

		private async Task GenerateAsync(SyntaxTree? tree, Assembly assembly, List<MetadataReference>? refs = null) 
		{
			_Walker = new(this);

			CompilationUnitSyntax root = tree.GetCompilationUnitRoot();


			string assemblyPath = Path.GetDirectoryName(assembly.Location);
			List<MetadataReference> references = new() { };

			string rtPath = Path.GetDirectoryName(typeof(object).Assembly.Location);

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

			SyntaxTree trueST = trueRoot.SyntaxTree;
			CSharpCompilation compilation = CSharpCompilation
				.Create("HelloWorld")
				.AddReferences(references.ToArray())
				.AddSyntaxTrees(trueST);

			Model = compilation.GetSemanticModel(trueST);

			_Walker.JSSB.Append(Options.AddSBInFront);

			_Walker.Visit(trueRoot);

			_Walker.JSSB.Append(Options.AddSBInEnd);
		}

		public void Log(string message, [CallerFilePath] string? file = null, [CallerMemberName] string? member = null, [CallerLineNumber] int line = 0)
		{
			if (Options.DisableConsoleColors == false)
			{
				if (message.StartsWith("---"))
					Console.ForegroundColor = ConsoleColor.Green;

				if (message.StartsWith("ERROR") || message.StartsWith("as"))
					Console.ForegroundColor = ConsoleColor.Red;

				if (message.StartsWith("WARNING"))
					Console.ForegroundColor = ConsoleColor.Yellow;
			}

			Trace.WriteLine($"({line}):{Path.GetFileName(file)} {member}: {message}");

			if (Options.DisableConsoleColors == false)
				Console.ResetColor();
		}
	}
}