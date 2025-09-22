using System.Reflection;
using System.IO;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Linq;
using CSharpToJavaScript.Utils;


namespace CSharpToJavaScript;

/// <summary>
/// Main type for CSharpToJavaScript.
/// </summary>
public class CSTOJS
{
	private readonly CSTOJSOptions _DefaultOptions = new();

	private Walker? _Walker = null;

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
			Log.InfoLine($"{assembly.GetName().Name} {assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion}", _DefaultOptions);
		}
	}

	public List<FileData> Translate(List<FileData> files, MetadataReference[]? references = null)
	{
		if (references == null)
			references = GetReferences();

		SyntaxTree[] trees = new SyntaxTree[files.Count];
		
		for (int i = 0; i < files.Count; i++)
		{
			trees[i] = CSharpSyntaxTree.ParseText(files[i].SourceStr);
		}
		
		CompilationUnitSyntax root = trees[0].GetCompilationUnitRoot();
		UsingDirectiveSyntax[] oldUsing = root.Usings.ToArray();

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

		trees[0] = trueRoot.SyntaxTree;

		for (int i = 0; i < files.Count; i++)
		{
			if (files[i].TranslateFile == false)
				continue;

			if (files[i].OptionsForFile.NormalizeWhitespace)
				trees[i] = trees[i].GetRoot().NormalizeWhitespace().SyntaxTree;

			if (files[i].OptionsForFile.KeepBraceOnTheSameLine)
			{
				//Mostly deleted whitespaces, still TODO?
				SyntaxToken[] allBraces = trees[i].GetRoot().DescendantTokens().Where((e) => e.IsKind(SyntaxKind.OpenBraceToken)).ToArray();

				List<SyntaxTrivia> allTriviaToDelete = new();

				for (int j = 0; j < allBraces.Length; j++)
				{
					if (allBraces[j].HasLeadingTrivia)
					{
						SyntaxTriviaList _lt = allBraces[j].LeadingTrivia;
						for (int y = 0; y < _lt.Count; y++)
						{
							allTriviaToDelete.Add(_lt[y]);
						}
					}
				}
				//Is this the right way to delete trivia?
				trees[i] = trees[i].GetRoot().ReplaceTrivia(allTriviaToDelete, (o, r) => SyntaxFactory.ElasticMarker).SyntaxTree;

				allBraces = trees[i].GetRoot().DescendantTokens().Where((e) => e.IsKind(SyntaxKind.OpenBraceToken)).ToArray();

				List<SyntaxTrivia> allTriviaToReplace = new();

				for (int j = 0; j < allBraces.Length; j++)
				{
					SyntaxToken _token = allBraces[j].GetPreviousToken();
					if (_token.HasTrailingTrivia)
					{
						SyntaxTrivia _trivia = _token.TrailingTrivia.Where((e) => e.IsKind(SyntaxKind.EndOfLineTrivia)).FirstOrDefault();
						if (!_trivia.IsKind(SyntaxKind.None))
						{
							allTriviaToReplace.Add(_trivia);
						}
					}
				}
				trees[i] = trees[i].GetRoot().ReplaceTrivia(allTriviaToReplace, (o, r) => SyntaxFactory.Space).SyntaxTree;
			}
		}
		
		CSharpCompilation compilation = CSharpCompilation
			.Create("HelloWorld")
			.AddReferences(references)
			.AddSyntaxTrees(trees);

		for (int i = 0; i < files.Count; i++)
		{
			if (files[i].TranslateFile == false)
				continue;

			_Walker = new(files[i].OptionsForFile, compilation.GetSemanticModel(trees[i]));

			_Walker.JSSB.Append(files[i].OptionsForFile.AddSBAtTheTop);

			_Walker.Visit(trees[i].GetRoot());

			_Walker.JSSB.Append(files[i].OptionsForFile.AddSBAtTheBottom);

			files[i].TranslatedStr = _Walker.JSSB.ToString();
		}
	
		return files;
	}
	private MetadataReference[] GetReferences()
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

		Log.InfoLine($"+++", _DefaultOptions);

		Log.InfoLine($"assemblyPath: {assemblyPath}", _DefaultOptions);
		Log.InfoLine($"objectAssemblyPath: {objectAssemblyPath}", _DefaultOptions);
		Log.InfoLine($"binPath: {binPath}", _DefaultOptions);

		foreach (MetadataReference metadata in assemblyMetadata)
		{
			Log.WriteLine(metadata.Display ?? "null display string", _DefaultOptions);
		}
		Log.InfoLine($"---", _DefaultOptions);

		MetadataReference[] references = new MetadataReference[assemblyMetadata.Count];
		int i = 0;
		foreach (MetadataReference metadata in assemblyMetadata)
		{
			references[i] = metadata;
			i++;
		}
		for (int j = 0; j < references.Length; j++)
		{
			Log.WriteLine(references[j].Display ?? "null display string", _DefaultOptions);

		}
		Log.InfoLine($"+++", _DefaultOptions);
		return references;
	}
}

public class FileData
{
	//Delete this?
	public string PathID { get; set; } = string.Empty;
	public CSTOJSOptions OptionsForFile { get; set; } = new();
	public string SourceStr { get; set; } = string.Empty;
	public string TranslatedStr { get; set; } = string.Empty;
	public bool TranslateFile { get; set; } = true;	
}