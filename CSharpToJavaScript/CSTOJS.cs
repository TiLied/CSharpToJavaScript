using System.Reflection;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using CSharpToJavaScript.Utils;
using System.Linq;

namespace CSharpToJavaScript
{
	/// <summary>
	/// Main type for CSharpToJavaScript.
	/// </summary>
	public class CSTOJS
	{
		public static SemanticModel Model { get; set; }

		private CSTOJSOptions _Options = new();

		private Walker _Walker = new();

		/// <summary>
		/// New instance of <see cref="CSTOJS"/> with default options, see <see cref="CSTOJSOptions"/>.
		/// </summary>
		public CSTOJS() 
		{
			if (_Options.Debug)
			{
				if (File.Exists(Directory.GetCurrentDirectory() + "/debug.txt"))
					File.Delete(Directory.GetCurrentDirectory() + "/debug.txt");

				Trace.Listeners.Add(new TextWriterTraceListener("debug.txt"));
				Trace.AutoFlush = true;
			}

			Trace.Listeners.Add(new ConsoleTraceListener());
		}

		/// <summary>
		/// New instance of <see cref="CSTOJS"/>
		/// </summary>
		/// <param name="options">Options of <see cref="CSTOJS"/>, see <see cref="CSTOJSOptions"/>.</param>
		public CSTOJS(CSTOJSOptions options)
		{
			_Options = options;

			if (_Options.Debug)
			{
				if (File.Exists(Directory.GetCurrentDirectory() + "/debug.txt"))
					File.Delete(Directory.GetCurrentDirectory() + "/debug.txt");

				Trace.Listeners.Add(new TextWriterTraceListener("debug.txt"));
				Trace.AutoFlush = true;
			}

			Trace.Listeners.Add(new ConsoleTraceListener());
		}

		/// <summary>
		/// Method for generating js file.
		/// </summary>
		/// <param name="path">Full path to cs file.</param>
		/// <param name="filename">Filename of a js file. Default: <c>main.js</c></param>
		/// <returns></returns>
		public async Task GenerateOneAsync(string path, string filename = "main.js") 
		{
			Assembly assembly = Assembly.GetEntryAssembly();

			await GenerateAsync(path, assembly, filename);
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
				await GenerateAsync(file.FullName, assembly, file.Name.Replace(".cs", ".js"));
			}
		}

		private async Task GenerateAsync(string path, Assembly assembly, string filename = "main.js") 
		{
			_Walker = new(_Options);

			string fileCS = await File.ReadAllTextAsync(path);

			SyntaxTree tree = CSharpSyntaxTree.ParseText(fileCS);
			CompilationUnitSyntax root = tree.GetCompilationUnitRoot();

			string assemblyPath = Path.GetDirectoryName(assembly.Location);
			List<MetadataReference> references = new() { };

			string rtPath = Path.GetDirectoryName(typeof(object).Assembly.Location);

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

			_Walker.JSSB.Append(_Options.AddSBInFront);

			_Walker.Visit(trueRoot);

			_Walker.JSSB.Append(_Options.AddSBInEnd);

			if (!Directory.Exists(_Options.OutPutPath))
			{
				Directory.CreateDirectory(_Options.OutPutPath);
			}

			await File.WriteAllTextAsync(Path.Combine(_Options.OutPutPath, filename), _Walker.JSSB.ToString());

			SM.Log($"--- Done!");
			SM.Log($"--- Path: {_Options.OutPutPath}");
			SM.Log($"--- File: {filename}");
			SM.Log($"--- --- ---");
		}
	}
}