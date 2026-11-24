
using System.Collections.Generic;
using CSharpToJavaScript.Utils;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpToJavaScript;

internal class ExportClassesWalker : CSharpSyntaxWalker
{
	private readonly SemanticModel _Model;
	private readonly Dictionary<string, List<string>> _ExportClasses;

	public ExportClassesWalker(SemanticModel semanticModel, ref Dictionary<string, List<string>> exportClasses)
	{
		_Model = semanticModel;
		_ExportClasses = exportClasses;
	}
	public override void VisitClassDeclaration(ClassDeclarationSyntax node)
	{
		//Ignore class export if the IgnoreAttribute is used.
		if (node.HasDataAnnotation(PredefinedAnnotations.IgnoreAttribute_Data))
			return;
			
		INamedTypeSymbol? classSymbol = _Model.GetDeclaredSymbol(node);

		if (classSymbol != null)
		{
			if (classSymbol.DeclaredAccessibility == Accessibility.Public)
			{
				if (node.SyntaxTree.FilePath == string.Empty)
					Log.WarningLine("'FileName' is empty. Modules won't be imported! (Only exported)");

				if (_ExportClasses.ContainsKey(node.SyntaxTree.FilePath))
					_ExportClasses[node.SyntaxTree.FilePath].Add(classSymbol.Name);
				else
					_ExportClasses.Add(node.SyntaxTree.FilePath, new() { classSymbol.Name });
			}
		}
	}
}
