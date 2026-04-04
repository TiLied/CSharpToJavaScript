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

		for (int i = 0; i < node.Members.Count; i++)
		{
			//properties need to be handled in VisitClassDeclaration
			if (node.Members[i].IsKind(SyntaxKind.PropertyDeclaration))
			{
				PropertyDeclarationSyntax _prop = (PropertyDeclarationSyntax)node.Members[i];

				if (_prop.AccessorList != null)
				{
					int _indexToInsert = i + 1;
					
					//TODO!
					//somehow without ToString.
					string _getSetStr = _prop.AccessorList.ToString().Trim().Replace(" ", "");
					if (_getSetStr == "{get;set;}" || _getSetStr == "{get;}")
					{
						string _fieldIdentifier = $"#_{_prop.Identifier}_";

						FieldDeclarationSyntax _field = SyntaxFactory.FieldDeclaration(
							SyntaxFactory.VariableDeclaration(SyntaxFactory.IdentifierName(""),
							  SyntaxFactory.SingletonSeparatedList(
							  SyntaxFactory.VariableDeclarator(
							  SyntaxFactory.Identifier(_fieldIdentifier))
								.WithInitializer(_prop.Initializer))))
								.WithLeadingTrivia(_prop.GetLeadingTrivia())
								.WithTrailingTrivia(_prop.GetTrailingTrivia());

						node = node.ReplaceNode(node.Members[i], _field);

						if (_getSetStr.Contains("get;"))
						{
							MethodDeclarationSyntax _getM = SyntaxFactory.MethodDeclaration(
							 SyntaxFactory.IdentifierName("get "), _prop.Identifier.WithoutTrivia())
							.WithBody(
								SyntaxFactory.Block(
									SyntaxFactory.ReturnStatement(
										SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
											 SyntaxFactory.IdentifierName("this"), SyntaxFactory.IdentifierName(_fieldIdentifier))
									).NormalizeWhitespace()))
							.WithLeadingTrivia(_prop.GetLeadingTrivia())
							.WithTrailingTrivia(_prop.GetTrailingTrivia());

							node = node.WithMembers(node.Members.Insert(_indexToInsert++, _getM));
						}
						if (_getSetStr.Contains("get;") && _getSetStr.Contains("set;"))
						{
							MethodDeclarationSyntax _setM = SyntaxFactory.MethodDeclaration(
								SyntaxFactory.IdentifierName("set "), _prop.Identifier.WithoutTrivia())
							.WithParameterList(
								SyntaxFactory.ParameterList(
									SyntaxFactory.SingletonSeparatedList(
									SyntaxFactory.Parameter(SyntaxFactory.Identifier("value")))))
							.WithBody(
								SyntaxFactory.Block(SyntaxFactory.ExpressionStatement(
									SyntaxFactory.AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
										SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
										 SyntaxFactory.IdentifierName("this"), SyntaxFactory.IdentifierName(_fieldIdentifier)),
										SyntaxFactory.IdentifierName("value")).NormalizeWhitespace())))
							.WithLeadingTrivia(_prop.GetLeadingTrivia())
							.WithTrailingTrivia(_prop.GetTrailingTrivia());

							node = node.WithMembers(node.Members.Insert(_indexToInsert++, _setM));
						}
					}
					else
					{
						for (int j = 0; j < _prop.AccessorList.Accessors.Count; j++)
						{
							if (_prop.AccessorList.Accessors[j].Keyword.Text == "get")
							{
								MethodDeclarationSyntax _getM = SyntaxFactory.MethodDeclaration(
								SyntaxFactory.IdentifierName("get ")
									.WithLeadingTrivia(_prop.GetLeadingTrivia()), _prop.Identifier.WithoutTrivia())
								.WithTrailingTrivia(_prop.AccessorList.Accessors[j].Keyword.TrailingTrivia)
								.WithBody(_prop.AccessorList.Accessors[j].Body)
								.WithLeadingTrivia(_prop.GetLeadingTrivia())
								.WithTrailingTrivia(_prop.AccessorList.Accessors[j].GetTrailingTrivia());

								node = node.WithMembers(node.Members.Insert(_indexToInsert++, _getM));
							}
							if (_prop.AccessorList.Accessors[j].Keyword.Text == "set")
							{
								MethodDeclarationSyntax _setM = SyntaxFactory.MethodDeclaration(
								SyntaxFactory.IdentifierName("set ")
									.WithLeadingTrivia(_prop.GetLeadingTrivia()), _prop.Identifier.WithoutTrivia())
								.WithParameterList(
								SyntaxFactory.ParameterList(
									SyntaxFactory.SingletonSeparatedList(
									SyntaxFactory.Parameter(SyntaxFactory.Identifier("value")))))
									.WithTrailingTrivia(_prop.AccessorList.Accessors[j].Keyword.TrailingTrivia)
									.WithBody(_prop.AccessorList.Accessors[j].Body)
									.WithLeadingTrivia(_prop.GetLeadingTrivia())
									.WithTrailingTrivia(_prop.AccessorList.Accessors[j].GetTrailingTrivia());

								node = node.WithMembers(node.Members.Insert(_indexToInsert++, _setM));
							}
						}
						
						node = node.RemoveNode(node.Members[i], SyntaxRemoveOptions.KeepNoTrivia);
					}
				}
			}
		}

		return node;
	}

	public override SyntaxNode? VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
	{
		node = (ConstructorDeclarationSyntax)base.VisitConstructorDeclaration(node)!;

		//TODO! Static constructor!
		node = node.ReplaceToken(node.Identifier, SyntaxFactory.Identifier("constructor").WithLeadingTrivia(node.Identifier.LeadingTrivia));

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

		if (node.Modifiers.Count >= 1)
		{
			SyntaxToken? _static = CreateStaticModifier(node.Modifiers);
			if (_static == null)
			{
				node = node.ReplaceNode(node.Declaration.Type, node.Declaration.Type.WithLeadingTrivia(node.Modifiers[0].LeadingTrivia).WithTrailingTrivia(node.Modifiers[0].TrailingTrivia));
				node = node.ReplaceTokens(node.Modifiers, (o, r) => SyntaxFactory.Token(SyntaxKind.None));
			}
			else
			{
				//Clear modifiers first.
				node = node.ReplaceTokens(node.Modifiers, (o, r) => SyntaxFactory.Token(SyntaxKind.None));
				//Add static modifier.
				node = node.WithModifiers(SyntaxFactory.TokenList((SyntaxToken)_static));
			}
		}

		node = node.WithDeclaration(node.Declaration.WithType(SyntaxFactory.IdentifierName("")).WithLeadingTrivia(node.Declaration.Type.GetLeadingTrivia()));

		return node;
	}
	public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
	{
		node = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node)!;

		node = node.ReplaceToken(node.Identifier, node.Identifier.WithLeadingTrivia(node.ReturnType.GetLeadingTrivia()));
		node = node.ReplaceNode(node.ReturnType, SyntaxFactory.ParseTypeName(""));

		if (node.Modifiers.Count >= 1)
		{
			SyntaxToken? _static = CreateStaticModifier(node.Modifiers);
			if (_static == null)
			{
				node = node.ReplaceToken(node.Identifier, node.Identifier.WithLeadingTrivia(node.Modifiers[0].LeadingTrivia));
				node = node.ReplaceTokens(node.Modifiers, (o, r) => SyntaxFactory.Token(SyntaxKind.None));
			}
			else
			{
				//Clear modifiers first.
				node = node.ReplaceTokens(node.Modifiers, (o, r) => SyntaxFactory.Token(SyntaxKind.None));
				//Add static modifier.
				node = node.WithModifiers(SyntaxFactory.TokenList((SyntaxToken)_static));
			}
		}

		return node;
	}
	public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)
	{
		node = (PropertyDeclarationSyntax)base.VisitPropertyDeclaration(node)!;

		//TODO! Static property!
		if (node.Modifiers.Count >= 1)
		{
			node = node.ReplaceNode(node.Type, node.Type.WithLeadingTrivia(node.Modifiers[0].LeadingTrivia).WithTrailingTrivia(node.Modifiers[0].TrailingTrivia));
			node = node.ReplaceTokens(node.Modifiers, (o, r) => SyntaxFactory.Token(SyntaxKind.None));
		}

		if (node.Initializer != null &&
			node.Initializer is EqualsValueClauseSyntax evc)
		{
			if (evc.Value is ImplicitObjectCreationExpressionSyntax ioce)
			{
				ObjectCreationExpressionSyntax _obj = SyntaxFactory.ObjectCreationExpression(node.Type, ioce.ArgumentList, ioce.Initializer).NormalizeWhitespace();
				node = node.ReplaceNode(ioce, _obj);
			}
		}
		
		node = node.ReplaceNode(node.Type, SyntaxFactory.IdentifierName("").WithLeadingTrivia(node.Type.GetLeadingTrivia()));

		return node;
	}
	public override SyntaxNode? VisitLocalFunctionStatement(LocalFunctionStatementSyntax node)
	{
		node = (LocalFunctionStatementSyntax)base.VisitLocalFunctionStatement(node)!;

		node = node.ReplaceNode(node.ReturnType, SyntaxFactory.IdentifierName("function").WithLeadingTrivia(node.ReturnType.GetLeadingTrivia()).WithTrailingTrivia(node.ReturnType.GetTrailingTrivia()));

		return node;
	}

	public override SyntaxNode? VisitVariableDeclaration(VariableDeclarationSyntax node)
	{
		if (node.Parent is ForStatementSyntax ||
			node.Parent is LocalDeclarationStatementSyntax)
		{
			if (_Options.UseVarOverLet)
				node = node.ReplaceNode(node.Type, SyntaxFactory.IdentifierName("var").WithLeadingTrivia(node.Type.GetLeadingTrivia()).WithTrailingTrivia(node.Type.GetTrailingTrivia()));
			else
				node = node.ReplaceNode(node.Type, SyntaxFactory.IdentifierName("let").WithLeadingTrivia(node.Type.GetLeadingTrivia()).WithTrailingTrivia(node.Type.GetTrailingTrivia()));

		}

		node = (VariableDeclarationSyntax)base.VisitVariableDeclaration(node)!;

		return node;
	}
	public override SyntaxNode? VisitBaseExpression(BaseExpressionSyntax node)
	{
		return SyntaxFactory.IdentifierName("super").WithLeadingTrivia(node.GetLeadingTrivia());
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
		if (node.Expression.IsKind(SyntaxKind.AsExpression) || node.Expression.IsKind(SyntaxKind.CastExpression))
		{
			node = (ParenthesizedExpressionSyntax)base.VisitParenthesizedExpression(node)!;
			return node.Expression.WithLeadingTrivia(node.GetLeadingTrivia());
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
	public override SyntaxNode? VisitUsingDirective(UsingDirectiveSyntax node)
	{
		return null;
	}
	public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
	{
		return null;
	}
	public override SyntaxNode? VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
	{
		return null;
	}

	private static SyntaxToken? CreateStaticModifier(SyntaxTokenList modifiers)
	{
		SyntaxToken? _static = null;
		for (int i = 0; i < modifiers.Count; i++)
		{
			if (modifiers[i].Text == "static")
			{
				_static = SyntaxFactory.Token(SyntaxKind.StaticKeyword).WithLeadingTrivia(modifiers[0].LeadingTrivia).WithTrailingTrivia(modifiers[0].TrailingTrivia);
				break;
			}
		}
		return _static;
	}

}
