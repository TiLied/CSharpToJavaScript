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
		if (node != null)
		{
			Log.InfoLine($"kind: {node.Kind()} \n\t{node.ToString()}");
			return base.Visit(node);
		}
		else
			return null;
	}
#endif

	public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
	{
		node = (ClassDeclarationSyntax)base.VisitClassDeclaration(node)!;

		if (node.Modifiers.Count >= 1)
		{
			node = node.ReplaceToken(node.Keyword, node.Keyword.WithLeadingTrivia(node.Modifiers[0].LeadingTrivia).WithTrailingTrivia(node.Modifiers[0].TrailingTrivia));
			node = node.ReplaceTokens(node.Modifiers, (o, r) => SyntaxFactory.Token(SyntaxKind.None));
		}

		return node;
	}

	public override SyntaxNode? VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
	{
		node = (ConstructorDeclarationSyntax)base.VisitConstructorDeclaration(node)!;

		//TODO! Static constructor!
		node = node.ReplaceToken(node.Identifier, SyntaxFactory.Identifier("constructor"));

		if (node.Modifiers.Count >= 1)
		{
			node = node.ReplaceToken(node.Identifier, node.Identifier.WithLeadingTrivia(node.Modifiers[0].LeadingTrivia));
			node = node.ReplaceTokens(node.Modifiers, (o, r) => SyntaxFactory.Token(SyntaxKind.None));
		}

		return node;
	}

	public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax node)
	{
		node = (FieldDeclarationSyntax)base.VisitFieldDeclaration(node)!;

		//TODO! Static field!
		if (node.Modifiers.Count >= 1)
		{
			node = node.ReplaceNode(node.Declaration.Type, node.Declaration.Type.WithLeadingTrivia(node.Modifiers[0].LeadingTrivia).WithTrailingTrivia(node.Modifiers[0].TrailingTrivia));
			node = node.ReplaceTokens(node.Modifiers, (o, r) => SyntaxFactory.Token(SyntaxKind.None));
		}

		node = node.WithDeclaration(node.Declaration.WithType(SyntaxFactory.IdentifierName("")).WithLeadingTrivia(node.Declaration.Type.GetLeadingTrivia()));

		return node;
	}
	public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
	{
		node = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node)!;

		node = node.ReplaceNode(node.ReturnType, SyntaxFactory.ParseTypeName(""));

		//TODO! Static method!
		if (node.Modifiers.Count >= 1)
		{
			node = node.ReplaceToken(node.Identifier, node.Identifier.WithLeadingTrivia(node.Modifiers[0].LeadingTrivia));
			node = node.ReplaceTokens(node.Modifiers, (o, r) => SyntaxFactory.Token(SyntaxKind.None));
		}

		return node;
	}

	public override SyntaxNode? VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
	{
		if (_Options.UseVarOverLet)
			node = node.WithDeclaration(node.Declaration.ReplaceNode(node.Declaration.Type, SyntaxFactory.IdentifierName("var").WithLeadingTrivia(node.Declaration.Type.GetLeadingTrivia()).WithTrailingTrivia(node.Declaration.Type.GetTrailingTrivia())));
		else
			node = node.WithDeclaration(node.Declaration.ReplaceNode(node.Declaration.Type, SyntaxFactory.IdentifierName("let").WithLeadingTrivia(node.Declaration.Type.GetLeadingTrivia()).WithTrailingTrivia(node.Declaration.Type.GetTrailingTrivia())));

		node = (LocalDeclarationStatementSyntax)base.VisitLocalDeclarationStatement(node)!;

		return node;
	}

	public override SyntaxNode? VisitParameter(ParameterSyntax node)
	{
		return SyntaxFactory.Parameter(node.Identifier);
	}
	public override SyntaxNode? VisitCastExpression(CastExpressionSyntax node)
	{
		return node.Expression;
	}
	public override SyntaxNode? VisitParenthesizedExpression(ParenthesizedExpressionSyntax node)
	{
		if (node.Expression.IsKind(SyntaxKind.AsExpression) || node.Expression.IsKind( SyntaxKind.CastExpression))
		{
			node = (ParenthesizedExpressionSyntax)base.VisitParenthesizedExpression(node)!;
			return node.Expression;
		}
		else
		{
			node = (ParenthesizedExpressionSyntax)base.VisitParenthesizedExpression(node)!;
			return node;
		}
	}
	public override SyntaxNode? VisitBinaryExpression(BinaryExpressionSyntax node)
	{
		node = (BinaryExpressionSyntax)base.VisitBinaryExpression(node)!;

		if (node.OperatorToken.IsKind(SyntaxKind.AsKeyword))
			return node.Left.WithoutTrailingTrivia();

		return node;
	}
	public override SyntaxNode? VisitGenericName(GenericNameSyntax node)
	{
		return SyntaxFactory.IdentifierName(node.Identifier);
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
