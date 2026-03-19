using CSharpToJavaScript.Utils;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpToJavaScript;

internal class WithoutSemanticRewriter : CSharpSyntaxRewriter
{
	private readonly CSTOJSOptions _Options;
	
	public WithoutSemanticRewriter(CSTOJSOptions options) 
	{
		_Options = options;
	}
	
#if DEBUG
	public override SyntaxNode? Visit(SyntaxNode? node)
	{
		if(node != null)
			Log.InfoLine($"kind: {node.Kind()} \n\t{node.ToString()}");
		
		return base.Visit(node);
	}
#endif
	
	public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
	{
		node = (ClassDeclarationSyntax)base.VisitClassDeclaration(node)!;
		
		if(node.Modifiers.Count >= 1)
		{
			node = node.ReplaceToken(node.Keyword, node.Keyword.WithLeadingTrivia(node.Modifiers[0].LeadingTrivia).WithTrailingTrivia(node.Modifiers[0].TrailingTrivia));
			node = node.ReplaceTokens(node.Modifiers,  (o, r) => SyntaxFactory.Token(SyntaxKind.None));
		}
		
		return node;
	}
	
	public override SyntaxNode? VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
	{
		node = (ConstructorDeclarationSyntax)base.VisitConstructorDeclaration(node)!;
		
		//TODO! Static constructor!
		node = node.ReplaceToken(node.Identifier, SyntaxFactory.Identifier("constructor"));
		
		if(node.Modifiers.Count >= 1)
		{
			node = node.ReplaceToken(node.Identifier, node.Identifier.WithLeadingTrivia(node.Modifiers[0].LeadingTrivia).WithTrailingTrivia(node.Modifiers[0].TrailingTrivia));
			node = node.ReplaceTokens(node.Modifiers,  (o, r) => SyntaxFactory.Token(SyntaxKind.None));
		}
		
		return node;
	}
	
	public override  SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax node)
	{
		node = (FieldDeclarationSyntax)base.VisitFieldDeclaration(node)!;
		
		//TODO! Static field!
		if(node.Modifiers.Count >= 1)
		{
			node = node.ReplaceNode(node.Declaration.Type, node.Declaration.Type.WithLeadingTrivia(node.Modifiers[0].LeadingTrivia).WithTrailingTrivia(node.Modifiers[0].TrailingTrivia));
			node = node.ReplaceTokens(node.Modifiers,  (o, r) => SyntaxFactory.Token(SyntaxKind.None));
		}
		return node;
	}
	public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
	{
		node = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node)!;
		
		node = node.ReplaceNode(node.ReturnType, SyntaxFactory.ParseTypeName(""));
		
		//TODO! Static method!
		if(node.Modifiers.Count >= 1)
		{
			node = node.ReplaceToken(node.Identifier, node.Identifier.WithLeadingTrivia(node.Modifiers[0].LeadingTrivia).WithTrailingTrivia(node.Modifiers[0].TrailingTrivia));
			node = node.ReplaceTokens(node.Modifiers,  (o, r) => SyntaxFactory.Token(SyntaxKind.None));
		}
		
		return node;
	}
	
	public override SyntaxNode? VisitVariableDeclaration(VariableDeclarationSyntax node)
	{
		if(_Options.UseVarOverLet)
			node = node.ReplaceNode(node.Type, SyntaxFactory.IdentifierName("var").WithLeadingTrivia(node.Type.GetLeadingTrivia()).WithTrailingTrivia(node.Type.GetTrailingTrivia()));
		else
			node = node.ReplaceNode(node.Type, SyntaxFactory.IdentifierName("let").WithLeadingTrivia(node.Type.GetLeadingTrivia()).WithTrailingTrivia(node.Type.GetTrailingTrivia()));
		
		node = (VariableDeclarationSyntax)base.VisitVariableDeclaration(node)!;
		
		return node;
	}
	
	public override SyntaxNode? VisitParameter(ParameterSyntax node)
	{
		return SyntaxFactory.Parameter(node.Identifier);
	}
	
    public override SyntaxNode? VisitAttributeList(AttributeListSyntax node)
    {
        return null;
    }
	public override SyntaxNode? VisitTypeParameterList(TypeParameterListSyntax node)
	{
		return null;
	}
	
}
