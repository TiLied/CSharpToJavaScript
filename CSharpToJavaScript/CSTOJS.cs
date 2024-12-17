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
		public CSTOJSOptions Options { get; set; } = new();

		private Walker? _Walker = null;

		/// <summary>
		/// New instance of <see cref="CSTOJS"/> with default options, see <see cref="CSTOJSOptions"/>.
		/// </summary>
		public CSTOJS() 
		{
			ConsoleTraceListener consoleTraceListener = new();
			if(Trace.Listeners.Contains(consoleTraceListener) == false)
				Trace.Listeners.Add(consoleTraceListener);

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

			if (Options.DisableConsoleOutput == false)
			{
				ConsoleTraceListener consoleTraceListener = new();
				if (Trace.Listeners.Contains(consoleTraceListener) == false)
					Trace.Listeners.Add(consoleTraceListener);


				Assembly assembly = Assembly.GetExecutingAssembly();
				//https://stackoverflow.com/a/73474279
				Log($"{assembly.GetName().Name} {assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion}");
			}
		}

		/// <summary>
		/// Method for generating js file/files.
		/// </summary>
		/// <param name="path">Full path to cs file or to the folder with cs files.</param>
		/// <param name="filename">Optional! Filename of a js file if you generating one file!</param>
		/// <returns></returns>
		public async Task GenerateOneAsync(string path, string? filename = null) 
		{
			Assembly assembly = Assembly.GetEntryAssembly();
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
			if (csstring == null)
				throw new ArgumentNullException(nameof(csstring));

			Assembly assembly = Assembly.GetEntryAssembly();

			SyntaxTree? _tree = CSharpSyntaxTree.ParseText(csstring);
			
			if(references != null)
				Generate(_tree, assembly, references);
			else
				Generate(_tree, assembly);

			Log($"--- Done!");
			Log($"--- --- ---");

			return _Walker.JSSB;
		}

		private void Generate(SyntaxTree? tree, Assembly assembly, List<MetadataReference>? refs = null) 
		{
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

				foreach (UsingDirectiveSyntax oU in oldUsing)
				{
					if (File.Exists(Path.Combine(rtPath, oU.Name + ".dll")))
						references.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, oU.Name + ".dll")));
				}
			}

			references = references.Distinct().ToList();

			if (Options.Debug)
			{
				Log($"+++");
				Log($"Path assembly: {assemblyPath}");
				Log($"Path rt: {rtPath}");
				Log($"List of references:");
				foreach (MetadataReference reference in references)
				{
					Log(reference.Display);
				}
				Log($"+++");
			}

			SyntaxTree trueST = trueRoot.SyntaxTree;
			CSharpCompilation compilation = CSharpCompilation
				.Create("HelloWorld")
				.AddReferences(references.ToArray())
				.AddSyntaxTrees(trueST);

			_Walker = new(this, compilation.GetSemanticModel(trueST));

			_Walker.JSSB.Append(Options.AddSBInFront);

			_Walker.Visit(trueRoot);

			_Walker.JSSB.Append(Options.AddSBInEnd);
		}

		public void Log(string message, [CallerFilePath] string? file = null, [CallerMemberName] string? member = null, [CallerLineNumber] int line = 0)
		{
			if (Options.DisableConsoleOutput == false)
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


				Trace.WriteLine($"({line}):{Path.GetFileName(file.Replace("\\", "/"))} {member}: {message}");

				if (Options.DisableConsoleColors == false)
					Console.ResetColor();
			}
		}
	}
}