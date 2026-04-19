using System.Reflection;
using System.IO;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Linq;
using CSharpToJavaScript.Utils;
using System.Collections.Immutable;

namespace CSharpToJavaScript;

/// <summary>
/// Main type for CSharpToJavaScript.
/// </summary>
public static class CSTOJS
{
	/// <summary>
	/// This method translates CSharp string into JavaScript with specified options.
	/// </summary>
	/// <param name="file"><see cref="FileData" />. CS string with options.</param>
	/// <param name="references">Optional. Array of references.</param>
	/// <returns></returns>
	public static FileData Translate(FileData file, MetadataReference[]? references = null)
	{
		FileData[] files = Translate([file], references);
		return files[0];
	}
	/// <summary>
	/// This method translates CSharp string into JavaScript with specified options.
	/// </summary>
	/// <param name="files">Array of <see cref="FileData" />. CS strings with options.</param>
	/// <param name="references">Optional. Array of references.</param>
	/// <returns>Array of <see cref="FileData" />. JS strings</returns>
	public static FileData[] Translate(FileData[] files, MetadataReference[]? references = null)
	{
		Assembly assembly = Assembly.GetExecutingAssembly();
		//https://stackoverflow.com/a/73474279
		Log.InfoLine($"{assembly.GetName().Name} {assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion}");

		if (references == null)
			references = GetReferences(files[0].OptionsForFile);

		SyntaxTree[] trees = new SyntaxTree[files.Length];

		for (int i = 0; i < files.Length; i++)
		{
			trees[i] = CSharpSyntaxTree.ParseText(files[i].SourceStr);
		}

		trees[0] = AddGlobalUsings(trees[0]);

		CSharpCompilation compilation = CSharpCompilation
			.Create("HelloWorld")
			.AddReferences(references)
			.AddSyntaxTrees(trees);

		for (int i = 0; i < files.Length; i++)
		{
			if (files[i].OptionsForFile.TranslateFile == false)
				continue;

			SemanticModel _model = compilation.GetSemanticModel(trees[i]);

			ImmutableArray<Diagnostic> diagnostics = _model.GetDiagnostics();
			for (int j = 0; j < diagnostics.Length; j++)
			{
				if (files[i].OptionsForFile.Debug)
					Log.WarningLine(diagnostics[j].ToString());

				//Print an error if compilation fails.
				if (diagnostics[j].Severity == DiagnosticSeverity.Error)
				{
					if (files[i].OptionsForFile.DisableCompilationErrors == false)
						Log.ErrorLine(diagnostics[i].ToString());
				}
			}

			SyntaxNode _root = trees[i].GetRoot();

			WithSemanticRewriter _withSemanticRewriter = new(_model, files[i].OptionsForFile);
			WithoutSemanticRewriter _withoutSemanticRewriter = new(files[i].OptionsForFile);
			
			StringBuilderWalker _stringBuilderWalker = new();

			SyntaxNode newRoot1 = _withSemanticRewriter.Visit(_root);
			if (_root != newRoot1)
				_root = newRoot1;

			_root = _root.ReplaceNodes(_withSemanticRewriter.ReplaceNodes.Keys, (o, r) =>
			{
				return _withSemanticRewriter.ReplaceNodes[o];
			});

			if (files[i].OptionsForFile.Debug)
				files[i].Debug_WithSemanticRewriter = _root.ToFullString();

			SyntaxNode newRoot2 = _withoutSemanticRewriter.Visit(_root);
			if (_root != newRoot2)
				_root = newRoot2;

			if (files[i].OptionsForFile.Debug)
				files[i].Debug_WithoutSemanticRewriter = _root.ToFullString();

			if (files[i].OptionsForFile.NormalizeWhitespace)
				_root = _root.NormalizeWhitespace();

			if (files[i].OptionsForFile.KeepBraceOnTheSameLine)
			{
				KeepBraceOnTheSameLineRewriter _keepBraceOnTheSameLineRewriter = new();
				
				SyntaxNode newRoot3 = _keepBraceOnTheSameLineRewriter.Visit(_root);
				if (_root != newRoot3)
					_root = newRoot3;
			}

			_stringBuilderWalker.JSSB.Append(files[i].OptionsForFile.AddSBAtTheTop);
			_stringBuilderWalker.Visit(_root);
			_stringBuilderWalker.JSSB.Append(files[i].OptionsForFile.AddSBAtTheBottom);

			files[i].TranslatedStr = _stringBuilderWalker.JSSB.ToString();
		}

		return files;
	}

	private static MetadataReference[] GetReferences(CSTOJSOptions options)
	{
		HashSet<MetadataReference> assemblyMetadata = new();

		Assembly? assembly = Assembly.GetEntryAssembly();
		AssemblyName[] assemblyNames = assembly?.GetReferencedAssemblies() ?? [];

		string? assemblyPath = Path.GetDirectoryName(assembly?.Location);
		string? objectAssemblyPath = Path.GetDirectoryName(typeof(object).Assembly.Location);
		string? binPath = Directory.Exists("./bin/") ? "./bin/" : null;

		if (assemblyNames.Length > 0)
		{
			for (int j = 0; j < assemblyNames.Length; j++)
			{
				if (assemblyPath != null && File.Exists(Path.Combine(assemblyPath, assemblyNames[j].Name + ".dll")))
					assemblyMetadata.Add(MetadataReference.CreateFromFile(Path.Combine(assemblyPath, assemblyNames[j].Name + ".dll")));

				if (objectAssemblyPath != null && File.Exists(Path.Combine(objectAssemblyPath, assemblyNames[j].Name + ".dll")))
					assemblyMetadata.Add(MetadataReference.CreateFromFile(Path.Combine(objectAssemblyPath, assemblyNames[j].Name + ".dll")));
			}
		}
		if (assemblyPath != null)
		{
			if (File.Exists(Path.Combine(assemblyPath, "CSharpToJavaScript.dll")))
				assemblyMetadata.Add(MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "CSharpToJavaScript.dll")));
		}
		if (objectAssemblyPath != null)
		{
			if (File.Exists(Path.Combine(objectAssemblyPath, "System.Private.CoreLib.dll")))
				assemblyMetadata.Add(MetadataReference.CreateFromFile(Path.Combine(objectAssemblyPath, "System.Private.CoreLib.dll")));

			if (File.Exists(Path.Combine(objectAssemblyPath, "System.dll")))
				assemblyMetadata.Add(MetadataReference.CreateFromFile(Path.Combine(objectAssemblyPath, "System.dll")));

			if (File.Exists(Path.Combine(objectAssemblyPath, "System.Collections.Generics.dll")))
				assemblyMetadata.Add(MetadataReference.CreateFromFile(Path.Combine(objectAssemblyPath, "System.Collections.Generics.dll")));

			if (File.Exists(Path.Combine(objectAssemblyPath, "System.IO.dll")))
				assemblyMetadata.Add(MetadataReference.CreateFromFile(Path.Combine(objectAssemblyPath, "System.IO.dll")));

			if (File.Exists(Path.Combine(objectAssemblyPath, "System.Linq.dll")))
				assemblyMetadata.Add(MetadataReference.CreateFromFile(Path.Combine(objectAssemblyPath, "System.Linq.dll")));

			if (File.Exists(Path.Combine(objectAssemblyPath, "System.Net.Http.dll")))
				assemblyMetadata.Add(MetadataReference.CreateFromFile(Path.Combine(objectAssemblyPath, "System.Net.Http.dll")));

			if (File.Exists(Path.Combine(objectAssemblyPath, "System.Threading.dll")))
				assemblyMetadata.Add(MetadataReference.CreateFromFile(Path.Combine(objectAssemblyPath, "System.Threading.dll")));

			if (File.Exists(Path.Combine(objectAssemblyPath, "System.Threading.Tasks.dll")))
				assemblyMetadata.Add(MetadataReference.CreateFromFile(Path.Combine(objectAssemblyPath, "System.Threading.Tasks.dll")));

			if (File.Exists(Path.Combine(objectAssemblyPath, "System.Console.dll")))
				assemblyMetadata.Add(MetadataReference.CreateFromFile(Path.Combine(objectAssemblyPath, "System.Console.dll")));
		}
		if (binPath != null)
		{
			string[] files = Directory.GetFiles(binPath, "*.dll", SearchOption.AllDirectories);
			for (int j = 0; j < files.Length; j++)
			{
				assemblyMetadata.Add(MetadataReference.CreateFromFile(files[j]));
			}
		}
		if (options.Debug)
		{
			Log.InfoLine($"+++");

			Log.InfoLine($"assemblyPath: {assemblyPath}");
			Log.InfoLine($"objectAssemblyPath: {objectAssemblyPath}");
			Log.InfoLine($"binPath: {binPath}");

			foreach (MetadataReference metadata in assemblyMetadata)
			{
				Log.WriteLine(metadata.Display ?? "null display string");
			}
			Log.InfoLine($"---");
		}

		MetadataReference[] references = new MetadataReference[assemblyMetadata.Count];
		int i = 0;
		foreach (MetadataReference metadata in assemblyMetadata)
		{
			references[i] = metadata;
			i++;
		}

		if (options.Debug)
		{
			for (int j = 0; j < references.Length; j++)
			{
				Log.WriteLine(references[j].Display ?? "null display string");

			}
			Log.InfoLine($"+++");
		}

		return references;
	}

	private static SyntaxTree AddGlobalUsings(SyntaxTree tree)
	{
		CompilationUnitSyntax root = tree.GetCompilationUnitRoot();
		UsingDirectiveSyntax[] oldUsing = root.Usings.ToArray();

		//https://stackoverflow.com/a/72938702
		root = root.WithUsings
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

		return root.SyntaxTree;
	}
}

/// <summary>
/// FileData includes a CSharp string, options, and a JavaScript string.
/// </summary>
public class FileData
{
	/// <summary>
	/// Options for a translation.
	/// </summary>
	public CSTOJSOptions OptionsForFile { get; set; } = new();

	/// <summary>
	/// CS input string.
	/// </summary>
	public string SourceStr { get; set; } = string.Empty;

	/// <summary>
	/// JS translated string.
	/// </summary>
	public string TranslatedStr { get; set; } = string.Empty;


	/// <summary>
	/// Debug string.
	/// </summary>
	public string Debug_WithSemanticRewriter { get; set; } = string.Empty;

	/// <summary>
	/// Debug string.
	/// </summary>
	public string Debug_WithoutSemanticRewriter { get; set; } = string.Empty;
}
