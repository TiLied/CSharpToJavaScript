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

		private readonly Assembly _Assembly;

		private CSTOJSOptions _Options = new();

		private Walker _Walker = new();

		/// <summary>
		/// New instance of <see cref="CSTOJS"/> with default options, see <see cref="CSTOJSOptions"/>.
		/// </summary>
		/// <param name="assembly">Assembly of a project, get by <see cref="Assembly.GetExecutingAssembly" /></param>
		public CSTOJS(Assembly assembly) 
		{
			_Assembly = assembly;

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
		/// 
		/// </summary>
		/// <param name="assembly">Assembly of a project, get by <see cref="Assembly.GetExecutingAssembly" /></param>
		/// <param name="options">Options of <see cref="CSTOJS"/>, see <see cref="CSTOJSOptions"/>.</param>
		public CSTOJS(Assembly assembly, CSTOJSOptions options)
		{
			_Assembly = assembly;
			_Options = options;
			_Walker = new(_Options);

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
		/// <returns></returns>
		public async Task GenerateAsync(string path) 
		{
			string fileCS = await File.ReadAllTextAsync(path);

			SyntaxTree tree = CSharpSyntaxTree.ParseText(fileCS);
			CompilationUnitSyntax root = tree.GetCompilationUnitRoot();

			string assemblyPath = Path.GetDirectoryName(_Assembly.Location);
			List<MetadataReference> references = new() { };

			string rtPath = Path.GetDirectoryName(typeof(object).Assembly.Location);

			references.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Private.CoreLib.dll")));

			AssemblyName[] a = _Assembly.GetReferencedAssemblies();
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

			//Should I make "NormalizeWhitespace" optoion??? TODO!
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

			await File.WriteAllTextAsync(Path.Combine(_Options.OutPutPath, _Options.OutPutFileName), _Walker.JSSB.ToString());
			
			SM.Log($"--- Done!");
			SM.Log($"--- Path: {_Options.OutPutPath}");
			SM.Log($"--- File: {_Options.OutPutFileName}");
		}
	}
}