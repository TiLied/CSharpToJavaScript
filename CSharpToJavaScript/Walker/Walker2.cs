using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using CSharpToJavaScript.Utils;
using System.Collections.Immutable;

namespace CSharpToJavaScript;

internal class Walker2
{
	public Walker2(FileData file)
	{
		SyntaxTree tree = CSharpSyntaxTree.ParseText(file.SourceStr);
		tree = CSTOJS.AddGlobalUsings(tree);

		MetadataReference[]? references = CSTOJS.GetReferences(file.OptionsForFile);

		CSharpCompilation compilation = CSharpCompilation
		.Create("Walker2")
		.AddReferences(references)
		.AddSyntaxTrees(tree);

		SemanticModel model = compilation.GetSemanticModel(tree);

		ImmutableArray<Diagnostic> diagnostics = model.GetDiagnostics();
		for (int i = 0; i < diagnostics.Length; i++)
		{
			if (file.OptionsForFile.Debug)
				Log.WarningLine(diagnostics[i].ToString());

			//Print an error if compilation fails.
			if (diagnostics[i].Severity == DiagnosticSeverity.Error)
			{
				if (file.OptionsForFile.DisableCompilationErrors == false)
					Log.ErrorLine(diagnostics[i].ToString());
			}
		}

		SyntaxNode root = tree.GetRoot();

		WithSemanticRewriter withSemanticRewriter = new(model, file.OptionsForFile);
		WithoutSemanticRewriter withoutSemanticRewriter = new(file.OptionsForFile);
		StringBuilderWalker stringBuilderWalker = new();

		SyntaxNode newRoot1 = withSemanticRewriter.Visit(root);
		if (root != newRoot1)
			root = newRoot1;
		root = root.ReplaceTokens(withSemanticRewriter.ReplaceTokens.Keys, (o, r) =>
		{
			return withSemanticRewriter.ReplaceTokens[o];
		});


		if (file.OptionsForFile.Debug)
			file.Debug_WithSemanticRewriter = root.ToFullString();

		SyntaxNode newRoot2 = withoutSemanticRewriter.Visit(root);
		if (root != newRoot2)
			root = newRoot2;

		if (file.OptionsForFile.Debug)
			file.Debug_WithoutSemanticRewriter = root.ToFullString();

		stringBuilderWalker.JSSB.Append(file.OptionsForFile.AddSBAtTheTop);
		stringBuilderWalker.Visit(root);
		stringBuilderWalker.JSSB.Append(file.OptionsForFile.AddSBAtTheBottom);

		file.TranslatedStr = stringBuilderWalker.JSSB.ToString();
	}
}
