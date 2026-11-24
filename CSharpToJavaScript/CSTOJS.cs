using CSharpToJavaScript.Utils;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Reflection;

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
			trees[i] = CSharpSyntaxTree.ParseText(files[i].SourceStr, path: files[i].FileName);
		}

		trees[0] = AddGlobalUsings(trees[0]).WithFilePath(files[0].FileName);
		
		CSharpCompilation compilation = CSharpCompilation
			.Create("HelloWorld")
			.AddReferences(references)
			.AddSyntaxTrees(trees);


		Dictionary<string, List<string>> exportedClasses = new();

		//Enable modules if, more than 2 files.
		if (files.Length >= 2)
		{
			for (int i = 0; i < files.Length; i++)
			{
				if (files[i].OptionsForFile.EnableModules == 1)
					files[i].OptionsForFile.EnableModules = 2;
			}
		}			
		
		for (int i = 0; i < files.Length; i++)
		{
			if (files[i].OptionsForFile.EnableModules >= 2)
			{
				SemanticModel _model = compilation.GetSemanticModel(trees[i]);
				
				ExportClassesWalker _exportClassesWalker = new(_model, ref exportedClasses);
				SyntaxNode _root = trees[i].GetRoot();
				_exportClassesWalker.Visit(_root);
			}
		}

		for (int i = 0; i < files.Length; i++)
		{
			if (files[i].OptionsForFile.DisableTranslation)
				continue;

			SemanticModel _model = compilation.GetSemanticModel(trees[i]);

			if (files[i].OptionsForFile.DisableDiagnostics == false)
			{
				ImmutableArray<Diagnostic> diagnostics = _model.GetDiagnostics();
				for (int j = 0; j < diagnostics.Length; j++)
				{
					if (diagnostics[j].Severity == DiagnosticSeverity.Hidden && files[i].OptionsForFile.Debug == true)
						Log.WriteLine(diagnostics[j].ToString());
					else if (diagnostics[j].Severity == DiagnosticSeverity.Info && files[i].OptionsForFile.Debug == true)
						Log.InfoLine(diagnostics[j].ToString());
					else if (diagnostics[j].Severity == DiagnosticSeverity.Warning)
						Log.WarningLine(diagnostics[j].ToString());
					else if (diagnostics[j].Severity == DiagnosticSeverity.Error)
						Log.ErrorLine(diagnostics[j].ToString());
				}
			}

			SyntaxNode? _root = trees[i].GetRoot();
			
			WithSemanticWalker _withSemanticWalker = new(_model, files[i].OptionsForFile, exportedClasses);
			WithoutSemanticRewriter _withoutSemanticRewriter = new(files[i].OptionsForFile);
			
			StringBuilderWalker _stringBuilderWalker = new();

			_withSemanticWalker.Visit(_root);

			_root = _root.ReplaceNodes(_withSemanticWalker.ReplaceNodes.Keys, (o, r) =>
			{
				return _withSemanticWalker.ReplaceNodes[o];
			});
			
			ProcessBuiltIns _processBuiltIns = new();
			_root = _processBuiltIns.ProcessRoot(_root);

			if (files[i].OptionsForFile.Debug)
			{
				files[i].DebugStrings[0] = _root.ToFullString();
				files[i].DebugStrings[0] += "\n--- --- ---\n";
				files[i].DebugStrings[0] += "_withSemanticWalker.ReplaceNodes:";
				files[i].DebugStrings[0] += "\n--- --- ---\n";
				foreach (KeyValuePair<SyntaxNode, SyntaxNode> _nodes in _withSemanticWalker.ReplaceNodes)
				{
					files[i].DebugStrings[0] += $"\tNode ({_nodes.Key.GetLocation().GetLineSpan()}): \n|";
					files[i].DebugStrings[0] += _nodes.Key.ToFullString();
					files[i].DebugStrings[0] += "|\n";
					files[i].DebugStrings[0] += $"\tReplaced node (data annotations: {_nodes.Value.GetAllDataAnnotation()}): \n|";
					files[i].DebugStrings[0] += _nodes.Value.ToFullString();
					files[i].DebugStrings[0] += "|\n";
				}
			}

			if (files[i].OptionsForFile.MakePropertiesEnumerable)
			{
				MakePropertiesEnumerableRewriter _makePropertiesEnumerableRewriter = new();
				_root = _makePropertiesEnumerableRewriter.Visit(_root);
			}

			if (files[i].OptionsForFile.Debug)
			{
				WithoutSemanticRewriter_Debug _withoutSemanticRewriter_Debug = new(files[i].OptionsForFile);
				_withoutSemanticRewriter = _withoutSemanticRewriter_Debug;
				
				_root = _withoutSemanticRewriter_Debug.Visit(_root);
				
				files[i].DebugStrings[1] = _root.ToFullString();
				
				files[i].DebugStrings[1] += "\n--- --- ---\n";
				files[i].DebugStrings[1] += "_withoutSemanticRewriter_Debug.ReplaceTokens:";
				files[i].DebugStrings[1] += "\n--- --- ---\n";
				foreach (KeyValuePair<SyntaxToken, SyntaxToken> _tokens in _withoutSemanticRewriter_Debug.ReplacedTokens)
				{
					files[i].DebugStrings[1] += $"\tToken ({_tokens.Key.GetLocation().GetLineSpan()}): \n|";
					files[i].DebugStrings[1] += _tokens.Key.ToFullString();
					files[i].DebugStrings[1] += "|\n";
					files[i].DebugStrings[1] += $"\tReplaced token (data annotations: {_tokens.Value.GetAllDataAnnotation()}): \n|";
					files[i].DebugStrings[1] += _tokens.Value.ToFullString();
					files[i].DebugStrings[1] += "|\n";
				}

				files[i].DebugStrings[1] += "\n--- --- ---\n";
				files[i].DebugStrings[1] += "_withoutSemanticRewriter_Debug.ReplacedNodes:";
				files[i].DebugStrings[1] += "\n--- --- ---\n";
				foreach (KeyValuePair<SyntaxNode, SyntaxNode> _nodes in _withoutSemanticRewriter_Debug.ReplacedNodes)
				{
					files[i].DebugStrings[1] += $"\tNode ({_nodes.Key.GetLocation().GetLineSpan()}): \n|";
					files[i].DebugStrings[1] += _nodes.Key.ToFullString();
					files[i].DebugStrings[1] += "|\n";
					files[i].DebugStrings[1] += $"\tReplaced node (data annotations: {_nodes.Value.GetAllDataAnnotation()}): \n|";
					files[i].DebugStrings[1] += _nodes.Value.ToFullString();
					files[i].DebugStrings[1] += "|\n";
				}
				files[i].DebugStrings[1] += "\n--- --- ---\n";
				files[i].DebugStrings[1] += "_withoutSemanticRewriter_Debug.RemovedNodes:";
				files[i].DebugStrings[1] += "\n--- --- ---\n";
				foreach (KeyValuePair<SyntaxNode, SyntaxRemoveOptions> _nodes in _withoutSemanticRewriter_Debug.RemovedNodes)
				{
					files[i].DebugStrings[1] += $"\tNode ({_nodes.Key.GetLocation().GetLineSpan()}) SyntaxRemoveOption: {_nodes.Value.ToString()}: \n|";
					files[i].DebugStrings[1] += _nodes.Key.ToFullString();
					files[i].DebugStrings[1] += "|\n";
				}
			}
			else
				_root = _withoutSemanticRewriter.Visit(_root);

			if (files[i].OptionsForFile.NormalizeWhitespace)
				_root = _root.NormalizeWhitespace();

			if (files[i].OptionsForFile.KeepBraceOnTheSameLine)
			{
				KeepBraceOnTheSameLineRewriter _keepBraceOnTheSameLineRewriter = new();

				_root = _keepBraceOnTheSameLineRewriter.Visit(_root);
			}

			_stringBuilderWalker.JSSB.Append(files[i].OptionsForFile.AddSBAtTheTop);
			
			//Import from an attribute if ImportAttribute is used.
			if(_withSemanticWalker.ImportFromAttribute.Count > 0)
			{
				Dictionary<string, List<string>>.KeyCollection _keys = _withSemanticWalker.ImportFromAttribute.Keys;
				
				foreach (string _path in _keys)
				{
					if (_stringBuilderWalker.JSSB.Length != 0)
					{
						if (_stringBuilderWalker.JSSB[_stringBuilderWalker.JSSB.Length - 1] != '\n')
							_stringBuilderWalker.JSSB.AppendLine();
					}
					
					_stringBuilderWalker.JSSB.Append("import { ");
					for (int j = 0; j < _withSemanticWalker.ImportFromAttribute[_path].Count; j++)
					{
						if (j == _withSemanticWalker.ImportFromAttribute[_path].Count - 1)
							_stringBuilderWalker.JSSB.Append($"{_withSemanticWalker.ImportFromAttribute[_path][j]}");
						else
							_stringBuilderWalker.JSSB.Append($"{_withSemanticWalker.ImportFromAttribute[_path][j]}, ");
					}
					_stringBuilderWalker.JSSB.AppendLine($" }} from '{_path}';");
				}
			}
			
			//Import modules if EnableModules is enabled.
			if (files[i].OptionsForFile.EnableModules >= 2)
			{
				Dictionary<string, List<string>>.KeyCollection _keys = _withSemanticWalker.ImportClasses.Keys;

				foreach (string _filename in _keys)
				{
					if (_stringBuilderWalker.JSSB.Length != 0)
					{
						if (_stringBuilderWalker.JSSB[_stringBuilderWalker.JSSB.Length - 1] != '\n')
							_stringBuilderWalker.JSSB.AppendLine();
					}
					
					_stringBuilderWalker.JSSB.Append("import { ");
					for (int j = 0; j < _withSemanticWalker.ImportClasses[_filename].Count; j++)
					{
						if (j == _withSemanticWalker.ImportClasses[_filename].Count - 1)
							_stringBuilderWalker.JSSB.Append($"{_withSemanticWalker.ImportClasses[_filename][j]}");
						else
							_stringBuilderWalker.JSSB.Append($"{_withSemanticWalker.ImportClasses[_filename][j]}, ");
					}
					_stringBuilderWalker.JSSB.AppendLine($" }} from './{_filename}';");
				}
			}
			
			_stringBuilderWalker.Visit(_root);

			//Export modules
			if (files[i].OptionsForFile.EnableModules >= 2)
			{
				if (exportedClasses.TryGetValue(files[i].FileName, out List<string>? _value))
				{
					if (_stringBuilderWalker.JSSB[_stringBuilderWalker.JSSB.Length - 1] != '\n')
						_stringBuilderWalker.JSSB.AppendLine();
						
					_stringBuilderWalker.JSSB.Append("export { ");
					for (int j = 0; j < _value.Count; j++)
					{
						if (j == _value.Count - 1)
							_stringBuilderWalker.JSSB.Append($"{_value[j]}");
						else
							_stringBuilderWalker.JSSB.Append($"{_value[j]}, ");
					}
					_stringBuilderWalker.JSSB.Append(" };");
				}
			}
			
			_stringBuilderWalker.JSSB.Append(files[i].OptionsForFile.AddSBAtTheBottom);

			files[i].TranslatedStr = _stringBuilderWalker.JSSB.ToString();
		}

		return files;
	}

	private static MetadataReference[] GetReferences(CSTOJSOptions options)
	{
		Dictionary<string, string> assemblyMetadata = new();

		Assembly? assembly = Assembly.GetEntryAssembly();
		AssemblyName[] assemblyNames = assembly?.GetReferencedAssemblies() ?? [];

		string? assemblyPath = Path.GetDirectoryName(assembly?.Location);
		string? objectAssemblyPath = Path.GetDirectoryName(typeof(object).Assembly.Location);
		string? customPath = Directory.Exists(options.CustomPathToDLLs) ? options.CustomPathToDLLs : null;

		if (assemblyNames.Length > 0)
		{
			for (int j = 0; j < assemblyNames.Length; j++)
			{
				string _name = assemblyNames[j].Name + ".dll";
				string _path = string.Empty;
				
				if (assemblyPath != null && File.Exists(Path.Combine(assemblyPath, _name)))
				{
					_path = Path.Combine(assemblyPath, _name);

					if (assemblyMetadata.ContainsKey(_name))
						assemblyMetadata[_name] = _path;
					else
						assemblyMetadata.Add(_name, _path);
				}

				if (objectAssemblyPath != null && File.Exists(Path.Combine(objectAssemblyPath, _name)))
				{
					_path = Path.Combine(objectAssemblyPath, _name);
					
					if (assemblyMetadata.ContainsKey(_name))
						assemblyMetadata[_name] = _path;
					else
						assemblyMetadata.Add(_name, _path);
				}
			}
		}
		
		if (assemblyPath != null)
		{
			if (File.Exists(Path.Combine(assemblyPath, "CSharpToJavaScript.dll")))
			{
				string _path = Path.Combine(assemblyPath, "CSharpToJavaScript.dll");
				
				if (assemblyMetadata.ContainsKey("CSharpToJavaScript.dll"))
					assemblyMetadata["CSharpToJavaScript.dll"] = _path;
				else
					assemblyMetadata.Add("CSharpToJavaScript.dll", _path);
			}
		}
		
		if (objectAssemblyPath != null)
		{
			string _name = string.Empty;
			string _path = string.Empty;

			if (File.Exists(Path.Combine(objectAssemblyPath, "System.Private.CoreLib.dll")))
			{
				_name = "System.Private.CoreLib.dll";
				_path = Path.Combine(objectAssemblyPath, _name);
				
				if (assemblyMetadata.ContainsKey(_name))
					assemblyMetadata[_name] = _path;
				else
					assemblyMetadata.Add(_name, _path);
			}
			if (File.Exists(Path.Combine(objectAssemblyPath, "System.dll")))
			{
				_name = "System.dll";
				_path = Path.Combine(objectAssemblyPath, _name);

				if (assemblyMetadata.ContainsKey(_name))
					assemblyMetadata[_name] = _path;
				else
					assemblyMetadata.Add(_name, _path);
			}

			if (File.Exists(Path.Combine(objectAssemblyPath, "System.Collections.Generics.dll")))
			{
				_name = "System.Collections.Generics.dll";
				_path = Path.Combine(objectAssemblyPath, _name);

				if (assemblyMetadata.ContainsKey(_name))
					assemblyMetadata[_name] = _path;
				else
					assemblyMetadata.Add(_name, _path);
			}

			if (File.Exists(Path.Combine(objectAssemblyPath, "System.IO.dll")))
			{
				_name = "System.IO.dll";
				_path = Path.Combine(objectAssemblyPath, _name);

				if (assemblyMetadata.ContainsKey(_name))
					assemblyMetadata[_name] = _path;
				else
					assemblyMetadata.Add(_name, _path);
			}

			if (File.Exists(Path.Combine(objectAssemblyPath, "System.Linq.dll")))
			{
				_name = "System.Linq.dll";
				_path = Path.Combine(objectAssemblyPath, _name);

				if (assemblyMetadata.ContainsKey(_name))
					assemblyMetadata[_name] = _path;
				else
					assemblyMetadata.Add(_name, _path);
			}

			if (File.Exists(Path.Combine(objectAssemblyPath, "System.Net.Http.dll")))
			{
				_name = "System.Net.Http.dll";
				_path = Path.Combine(objectAssemblyPath, _name);

				if (assemblyMetadata.ContainsKey(_name))
					assemblyMetadata[_name] = _path;
				else
					assemblyMetadata.Add(_name, _path);
			}

			if (File.Exists(Path.Combine(objectAssemblyPath, "System.Threading.dll")))
			{
				_name = "System.Threading.dll";
				_path = Path.Combine(objectAssemblyPath, _name);

				if (assemblyMetadata.ContainsKey(_name))
					assemblyMetadata[_name] = _path;
				else
					assemblyMetadata.Add(_name, _path);
			}

			if (File.Exists(Path.Combine(objectAssemblyPath, "System.Threading.Tasks.dll")))
			{
				_name = "System.Threading.Tasks.dll";
				_path = Path.Combine(objectAssemblyPath, _name);

				if (assemblyMetadata.ContainsKey(_name))
					assemblyMetadata[_name] = _path;
				else
					assemblyMetadata.Add(_name, _path);
			}

			if (File.Exists(Path.Combine(objectAssemblyPath, "System.Console.dll")))
			{
				_name = "System.Console.dll";
				_path = Path.Combine(objectAssemblyPath, _name);

				if (assemblyMetadata.ContainsKey(_name))
					assemblyMetadata[_name] = _path;
				else
					assemblyMetadata.Add(_name, _path);
			}
		}
		
		if (customPath != null)
		{
			string[] _paths = Directory.GetFiles(customPath, "*.dll", SearchOption.AllDirectories);
			
			for (int j = 0; j < _paths.Length; j++)
			{
				string _filename = Path.GetFileName(_paths[j]);
				
				if (assemblyMetadata.ContainsKey(_filename))
					assemblyMetadata[_filename] = _paths[j];
				else
					assemblyMetadata.Add(_filename, _paths[j]);
			}
		}
		
		if (options.Debug)
		{
			Log.InfoLine($"+++");

			Log.InfoLine($"assemblyPath: '{assemblyPath}'");
			Log.InfoLine($"objectAssemblyPath: '{objectAssemblyPath}'");
			Log.InfoLine($"customPath: '{customPath}'");

			foreach (KeyValuePair<string, string> metadata in assemblyMetadata)
			{
				Log.WriteLine($"{metadata.Key}:{metadata.Value}");
			}
			
			Log.InfoLine($"assemblyMetadata count: '{assemblyMetadata.Count}'");
			Log.InfoLine($"---");
		}

		MetadataReference[] references = new MetadataReference[assemblyMetadata.Count];
		int i = 0;
		foreach (KeyValuePair<string, string> metadata in assemblyMetadata)
		{
			references[i] = MetadataReference.CreateFromFile(metadata.Value);
			i++;
		}

		if (options.Debug)
		{
			for (int j = 0; j < references.Length; j++)
			{
				Log.WriteLine($"{references[j].Display}");
			}
			Log.InfoLine($"references length: '{references.Length}'");
			Log.InfoLine($"+++");
		}

		return references;
	}

	private static SyntaxTree AddGlobalUsings(SyntaxTree tree)
	{
		//
		//TODO!
		//Exclude duplicates? How? Or remove non-global usings from files?
		CompilationUnitSyntax root = tree.GetCompilationUnitRoot();

		SyntaxList<UsingDirectiveSyntax> newUsing = SyntaxFactory.List<UsingDirectiveSyntax>
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
			).AddRange(root.Usings);
		
		//https://stackoverflow.com/a/72938702
		root = root.WithUsings(newUsing);

		return root.SyntaxTree;
	}
}

/// <summary>
/// FileData includes a CSharp string, options, and a JavaScript string.
/// </summary>
public class FileData
{
	/// <summary>
	/// Full JS filename. Needed for modules.
	/// </summary>
	public string FileName { get; set; } = string.Empty;
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
	/// Debug strings.
	/// 0: WithSemanticWalker
	/// 1: WithoutSemanticRewriter
	/// </summary>
	public string[] DebugStrings { get; set; } = [string.Empty, string.Empty];
}
