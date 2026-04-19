using CSharpToJavaScript.Utils;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Text;
using System;

namespace CSharpToJavaScript;

internal class StringBuilderWalker : CSharpSyntaxWalker
{
	public StringBuilder JSSB { get; set; } = new(512);

	public StringBuilderWalker() : base(SyntaxWalkerDepth.Trivia)
	{

	}

#if DEBUG
	public override void Visit(SyntaxNode? node)
	{
		if (node != null)
			Log.InfoLine($"kind: {node.Kind()} \n\t{node.ToString()}");

		base.Visit(node);
	}
#endif

	public override void VisitTrivia(SyntaxTrivia trivia)
	{
		switch (trivia.Kind())
		{
			case SyntaxKind.SingleLineCommentTrivia:
				{
					string _full = trivia.ToString();

					//special syntax.
					//for writing js code //...\\
					if (_full.EndsWith(@"\\"))
						JSSB.Append(_full.AsSpan(2, _full.Length - 4));
					else
						JSSB.Append(_full);
					return;
				}
			case SyntaxKind.MultiLineCommentTrivia:
			case SyntaxKind.WhitespaceTrivia:
			case SyntaxKind.EndOfLineTrivia:
			case SyntaxKind.SkippedTokensTrivia:
				{
					string _full = trivia.ToFullString();
					JSSB.Append(_full);
					return;
				}
			// Todo? how? convert to jsdoc?
			case SyntaxKind.SingleLineDocumentationCommentTrivia:
			case SyntaxKind.MultiLineDocumentationCommentTrivia:
				{
					//JSSB.Append("/**");
					string _full = trivia.ToFullString();
					JSSB.Append(_full);
					//JSSB.AppendLine("");
					return;
				}
			default:
				Log.ErrorLine($"Trivia : {trivia.Kind()}");
				break;
		}

		base.VisitTrivia(trivia);
	}

	public override void VisitToken(SyntaxToken token)
	{
		switch (token.Kind())
		{
			//TODO?
			case SyntaxKind.IdentifierToken:
				{
					VisitLeadingTrivia(token);

					JSSB.Append(token.Text.Replace("DollarSign_", "$"));

					VisitTrailingTrivia(token);
					return;
				}
			case SyntaxKind.InKeyword:
			case SyntaxKind.StaticKeyword:
			case SyntaxKind.TrueKeyword:
			case SyntaxKind.FalseKeyword:
			case SyntaxKind.ReturnKeyword:
			case SyntaxKind.ClassKeyword:
			case SyntaxKind.OpenParenToken:
			case SyntaxKind.CloseParenToken:
			case SyntaxKind.SemicolonToken:
			case SyntaxKind.CloseBraceToken:
			case SyntaxKind.DotToken:
			case SyntaxKind.EqualsToken:
			case SyntaxKind.StringLiteralToken:
			case SyntaxKind.ForKeyword:
			case SyntaxKind.IfKeyword:
			case SyntaxKind.GreaterThanEqualsToken:
			case SyntaxKind.PlusPlusToken:
			case SyntaxKind.PlusToken:
			case SyntaxKind.LessThanToken:
			case SyntaxKind.NumericLiteralToken:
			case SyntaxKind.CommaToken:
			case SyntaxKind.NewKeyword:
			case SyntaxKind.ThisKeyword:
			case SyntaxKind.MinusToken:
			case SyntaxKind.MinusMinusToken:
			case SyntaxKind.SlashToken:
			case SyntaxKind.AsteriskToken:
			case SyntaxKind.NullKeyword:
			case SyntaxKind.BreakKeyword:
			case SyntaxKind.CloseBracketToken:
			case SyntaxKind.OpenBracketToken:
			case SyntaxKind.EqualsGreaterThanToken:
			case SyntaxKind.AwaitKeyword:
			case SyntaxKind.AsyncKeyword:
			case SyntaxKind.ElseKeyword:
			case SyntaxKind.SwitchKeyword:
			case SyntaxKind.CaseKeyword:
			case SyntaxKind.ColonToken:
			case SyntaxKind.DefaultKeyword:
			case SyntaxKind.BarBarToken:
			case SyntaxKind.ExclamationToken:
			case SyntaxKind.ContinueKeyword:
			case SyntaxKind.GreaterThanToken:
			case SyntaxKind.AmpersandAmpersandToken:
			case SyntaxKind.PlusEqualsToken:
			case SyntaxKind.MinusEqualsToken:
			case SyntaxKind.AsteriskEqualsToken:
			case SyntaxKind.SlashEqualsToken:
			case SyntaxKind.WhileKeyword:
			case SyntaxKind.InterpolatedStringTextToken:
			case SyntaxKind.QuestionToken:
			case SyntaxKind.LessThanEqualsToken:
			case SyntaxKind.ConstKeyword:
			case SyntaxKind.PercentToken:
			case SyntaxKind.QuestionQuestionToken:
			case SyntaxKind.TildeToken:
			case SyntaxKind.AmpersandToken:
			case SyntaxKind.GreaterThanGreaterThanToken:
			case SyntaxKind.LessThanLessThanToken:
			case SyntaxKind.GreaterThanGreaterThanEqualsToken:
			case SyntaxKind.LessThanLessThanEqualsToken:
			case SyntaxKind.CaretEqualsToken:
			case SyntaxKind.BarEqualsToken:
			case SyntaxKind.AmpersandEqualsToken:
			case SyntaxKind.BarToken:
			case SyntaxKind.DoKeyword:
			case SyntaxKind.ThrowStatement:
			case SyntaxKind.CatchKeyword:
			case SyntaxKind.TryKeyword:
			case SyntaxKind.ThrowKeyword:
			case SyntaxKind.FinallyKeyword:
			case SyntaxKind.CaretToken:
			case SyntaxKind.CharacterLiteralToken:
			case SyntaxKind.GreaterThanGreaterThanGreaterThanToken:
			case SyntaxKind.PercentEqualsToken:
			case SyntaxKind.QuestionQuestionEqualsToken:
			case SyntaxKind.GreaterThanGreaterThanGreaterThanEqualsToken:
			case SyntaxKind.TypeOfKeyword:
			case SyntaxKind.ExclamationEqualsToken:
			case SyntaxKind.EqualsEqualsToken:
			case SyntaxKind.EndOfFileToken:
			case SyntaxKind.OpenBraceToken:
				{
					VisitLeadingTrivia(token);

					JSSB.Append(token.Text);

					VisitTrailingTrivia(token);
					return;
				}
			default:
				Log.ErrorLine($"Token : {token.Kind()}");
				break;
		}

		base.VisitToken(token);
	}

	public override void VisitCompilationUnit(CompilationUnitSyntax node)
	{
		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.ClassDeclaration:
						VisitClassDeclaration((ClassDeclarationSyntax)asNode);
						break;
					case SyntaxKind.GlobalStatement:
						VisitGlobalStatement((GlobalStatementSyntax)asNode);
						break;
					case SyntaxKind.NamespaceDeclaration:
						VisitNamespaceDeclaration((NamespaceDeclarationSyntax)asNode);
						break;
					case SyntaxKind.FileScopedNamespaceDeclaration:
						VisitFileScopedNamespaceDeclaration((FileScopedNamespaceDeclarationSyntax)asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}\n|{asNode.ToFullString()}|");
						break;
				}
			}
			else
			{
				SyntaxToken asToken = nodesAndTokens[i].AsToken();
				SyntaxKind kind = asToken.Kind();

				switch (kind)
				{
					case SyntaxKind.EndOfFileToken:
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}
	public override void VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
	{
		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.QualifiedName:
					case SyntaxKind.IdentifierName:
						break;
					case SyntaxKind.ClassDeclaration:
						VisitClassDeclaration((ClassDeclarationSyntax)asNode);
						break;
					case SyntaxKind.EnumDeclaration:
						VisitEnumDeclaration((EnumDeclarationSyntax)asNode);
						break;
					case SyntaxKind.NamespaceDeclaration:
						VisitNamespaceDeclaration((NamespaceDeclarationSyntax)asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}\n|{asNode.ToFullString()}|");
						break;
				}
			}
			else
			{
				SyntaxToken asToken = nodesAndTokens[i].AsToken();
				SyntaxKind kind = asToken.Kind();

				switch (kind)
				{
					//Todo? make a scope??? {...}
					//OpenBraceToken and CloseBraceToken
					case SyntaxKind.OpenBraceToken:
					case SyntaxKind.CloseBraceToken:
					case SyntaxKind.NamespaceKeyword:
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}
	public override void VisitFileScopedNamespaceDeclaration(FileScopedNamespaceDeclarationSyntax node)
	{
		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.QualifiedName:
					case SyntaxKind.IdentifierName:
						break;
					case SyntaxKind.ClassDeclaration:
						VisitClassDeclaration((ClassDeclarationSyntax)asNode);
						break;
					case SyntaxKind.EnumDeclaration:
						VisitEnumDeclaration((EnumDeclarationSyntax)asNode);
						break;
					case SyntaxKind.NamespaceDeclaration:
						VisitNamespaceDeclaration((NamespaceDeclarationSyntax)asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}\n|{asNode.ToFullString()}|");
						break;
				}
			}
			else
			{
				SyntaxToken asToken = nodesAndTokens[i].AsToken();
				SyntaxKind kind = asToken.Kind();

				switch (kind)
				{
					case SyntaxKind.SemicolonToken:
					case SyntaxKind.NamespaceKeyword:
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitInvocationExpression(InvocationExpressionSyntax node)
	{
		if (node.Expression.HasAnnotation(BinaryAttribute.Annotation))
		{
			VisitArgument(node.ArgumentList.Arguments[0]);

			if (!node.ArgumentList.Arguments[0].HasTrailingTrivia)
				JSSB.Append(' ');

			JSSB.Append(node.Expression.ToString());

			VisitTrailingTrivia(node.ArgumentList.Arguments.GetSeparator(0));

			VisitArgument(node.ArgumentList.Arguments[1]);
			return;
		}
		if (node.Expression.HasAnnotation(UnaryAttribute.Annotation))
		{
			JSSB.Append(node.Expression.ToString());

			if (!node.Expression.HasTrailingTrivia)
				JSSB.Append(' ');

			VisitArgument(node.ArgumentList.Arguments[0]);
			return;
		}
		base.VisitInvocationExpression(node);
	}
	public override void VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
	{
		if (!node.Identifier.HasAnnotation(WithoutSemanticRewriter.StaticConstructor))
			base.VisitConstructorDeclaration(node);
		else
		{
			ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

			for (int i = 0; i < nodesAndTokens.Count; i++)
			{
				SyntaxNode? asNode = nodesAndTokens[i].AsNode();

				if (asNode != null)
				{
					SyntaxKind kind = asNode.Kind();

					switch (kind)
					{
						case SyntaxKind.ParameterList:
							{
								SyntaxTriviaList _syntaxTrivias = asNode.GetLeadingTrivia();
								for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
								{
									VisitTrivia(_syntaxTrivias[_i]);
								}
								_syntaxTrivias = asNode.GetTrailingTrivia();
								for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
								{
									VisitTrivia(_syntaxTrivias[_i]);
								}
								break;
							}
						case SyntaxKind.Block:
							VisitBlock((BlockSyntax)asNode);
							break;
						default:
							Log.ErrorLine($"asNode : {kind}\n|{asNode.ToFullString()}|");
							break;
					}
				}
				else
				{
					SyntaxToken asToken = nodesAndTokens[i].AsToken();
					SyntaxKind kind = asToken.Kind();

					switch (kind)
					{
						case SyntaxKind.IdentifierToken:
							{
								VisitToken(asToken);
								break;
							}
						default:
							Log.ErrorLine($"asToken : {kind}");

							break;
					}
				}
			}
		}
	}





	//Can't do in "WithoutSemanticRewriter". Throws an error:
	//An exception of type 'System.ArgumentException' occurred in Microsoft.CodeAnalysis.CSharp.dll but was not handled in user code: 'colonToken'
	//Code:
	/*
	public override SyntaxNode? VisitBaseList(BaseListSyntax node)
	{
		node = (BaseListSyntax)base.VisitBaseList(node)!;
		
		node = node.ReplaceToken(node.ColonToken, SyntaxFactory.Token(SyntaxKind.None));
		
		return node;
	} 
	*/
	public override void VisitBaseList(BaseListSyntax node)
	{
		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.SimpleBaseType:
						VisitSimpleBaseType((SimpleBaseTypeSyntax)asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}\n|{asNode.ToFullString()}|");
						break;
				}
			}
			else
			{
				SyntaxToken asToken = nodesAndTokens[i].AsToken();
				SyntaxKind kind = asToken.Kind();

				switch (kind)
				{
					case SyntaxKind.ColonToken:
						{
							VisitLeadingTrivia(asToken);
							JSSB.Append("extends");
							VisitTrailingTrivia(asToken);
							break;
						}
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	//Can't replace a token. Same as VisitBaseList
	//see "tokenInList"
	//https://learn.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnodeextensions.replacetoken?view=roslyn-dotnet-4.13.0#microsoft-codeanalysis-syntaxnodeextensions-replacetoken-1(-0-microsoft-codeanalysis-syntaxtoken-system-collections-generic-ienumerable((microsoft-codeanalysis-syntaxtoken)))
	//"The token to be replaced. This must be a direct element of a SyntaxTokenList (such as a modifier in a list of modifiers), and a descendant of the root node. If the token is not part of a SyntaxTokenList, an InvalidOperationException will be thrown."
	//But it throws a 'System.ArgumentException', not an 'InvalidOperationException':
	//An exception of type 'System.ArgumentException' occurred in Microsoft.CodeAnalysis.CSharp.dll but was not handled in user code: 'stringStartToken'
	//Code:
	/*
	public override SyntaxNode? VisitInterpolatedStringExpression(InterpolatedStringExpressionSyntax node)
	{
		node = (InterpolatedStringExpressionSyntax)base.VisitInterpolatedStringExpression(node)!;
		node = node.ReplaceToken(node.StringStartToken, SyntaxFactory.Token(SyntaxKind.SingleQuoteToken));
		node = node.ReplaceToken(node.StringEndToken, SyntaxFactory.Token(SyntaxKind.SingleQuoteToken));
		return node;
	}
	*/
	public override void VisitInterpolatedStringExpression(InterpolatedStringExpressionSyntax node)
	{
		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.InterpolatedStringText:
						VisitInterpolatedStringText((InterpolatedStringTextSyntax)asNode);
						break;
					case SyntaxKind.Interpolation:
						{
							JSSB.Append('$');
							VisitInterpolation((InterpolationSyntax)asNode);
							break;
						}
					default:
						Log.ErrorLine($"asNode : {kind}\n|{asNode.ToFullString()}|");
						break;
				}
			}
			else
			{
				SyntaxToken asToken = nodesAndTokens[i].AsToken();
				SyntaxKind kind = asToken.Kind();

				switch (kind)
				{
					case SyntaxKind.InterpolatedStringStartToken:
					case SyntaxKind.InterpolatedStringEndToken:
						JSSB.Append('`');
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}
	public override void VisitInitializerExpression(InitializerExpressionSyntax node)
	{
		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.IdentifierName:
						VisitIdentifierName((IdentifierNameSyntax)asNode);
						break;
					case SyntaxKind.ArgListExpression:
					case SyntaxKind.NumericLiteralExpression:
					case SyntaxKind.StringLiteralExpression:
					case SyntaxKind.Utf8StringLiteralExpression:
					case SyntaxKind.CharacterLiteralExpression:
					case SyntaxKind.TrueLiteralExpression:
					case SyntaxKind.FalseLiteralExpression:
					case SyntaxKind.NullLiteralExpression:
					case SyntaxKind.DefaultLiteralExpression:
						VisitLiteralExpression((LiteralExpressionSyntax)asNode);
						break;
					case SyntaxKind.ObjectInitializerExpression:
					case SyntaxKind.CollectionInitializerExpression:
					case SyntaxKind.ArrayInitializerExpression:
					case SyntaxKind.ComplexElementInitializerExpression:
					case SyntaxKind.WithInitializerExpression:
						VisitInitializerExpression((InitializerExpressionSyntax)asNode);
						break;
					case SyntaxKind.ObjectCreationExpression:
						VisitObjectCreationExpression((ObjectCreationExpressionSyntax)asNode);
						break;
					case SyntaxKind.SimpleAssignmentExpression:
					case SyntaxKind.AddAssignmentExpression:
					case SyntaxKind.SubtractAssignmentExpression:
					case SyntaxKind.MultiplyAssignmentExpression:
					case SyntaxKind.DivideAssignmentExpression:
					case SyntaxKind.ModuloAssignmentExpression:
					case SyntaxKind.AndAssignmentExpression:
					case SyntaxKind.ExclusiveOrAssignmentExpression:
					case SyntaxKind.OrAssignmentExpression:
					case SyntaxKind.LeftShiftAssignmentExpression:
					case SyntaxKind.RightShiftAssignmentExpression:
					case SyntaxKind.UnsignedRightShiftAssignmentExpression:
					case SyntaxKind.CoalesceAssignmentExpression:
						{
							AssignmentExpressionSyntax _expr = (AssignmentExpressionSyntax)asNode;
							Visit(_expr.Left);

							VisitLeadingTrivia(_expr.OperatorToken);
							JSSB.Append(':');
							VisitTrailingTrivia(_expr.OperatorToken);

							Visit(_expr.Right);
							break;
						}
					default:
						Log.ErrorLine($"asNode : {kind}\n|{asNode.ToFullString()}|");
						break;
				}
			}
			else
			{
				SyntaxToken asToken = nodesAndTokens[i].AsToken();
				SyntaxKind kind = asToken.Kind();

				switch (kind)
				{
					case SyntaxKind.OpenBraceToken:
					case SyntaxKind.CloseBraceToken:
						{
							VisitToken(asToken);
							break;
						}
					case SyntaxKind.CommaToken:
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");

						break;
				}
			}
		}
	}

	//TODO?
	//Try replace with "SyntaxFactory.InitializerExpression(SyntaxKind.ArrayInitializerExpression, SyntaxFactory.SeparatedList<ExpressionSyntax>(enumMembers)))))))).WithTrailingTrivia(node.CloseBraceToken.TrailingTrivia);"
	public override void VisitAnonymousObjectCreationExpression(AnonymousObjectCreationExpressionSyntax node)
	{
		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.AnonymousObjectMemberDeclarator:
						VisitAnonymousObjectMemberDeclarator((AnonymousObjectMemberDeclaratorSyntax)asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}\n|{asNode.ToFullString()}|");
						break;
				}
			}
			else
			{
				SyntaxToken asToken = nodesAndTokens[i].AsToken();
				SyntaxKind kind = asToken.Kind();

				switch (kind)
				{
					case SyntaxKind.CommaToken:
					case SyntaxKind.OpenBraceToken:
					case SyntaxKind.CloseBraceToken:
						VisitToken(asToken);
						break;
					case SyntaxKind.NewKeyword:
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}
	public override void VisitNameEquals(NameEqualsSyntax node)
	{
		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.IdentifierName:
						VisitIdentifierName((IdentifierNameSyntax)asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}\n|{asNode.ToFullString()}|");
						break;
				}
			}
			else
			{
				SyntaxToken asToken = nodesAndTokens[i].AsToken();
				SyntaxKind kind = asToken.Kind();

				switch (kind)
				{
					case SyntaxKind.EqualsToken:
						{
							VisitLeadingTrivia(asToken);
							JSSB.Append(':');
							VisitTrailingTrivia(asToken);
							break;
						}
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}
	public override void VisitForEachStatement(ForEachStatementSyntax node)
	{
		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.ElementAccessExpression:
						VisitElementAccessExpression((ElementAccessExpressionSyntax)asNode);
						break;
					case SyntaxKind.ThisExpression:
						VisitThisExpression((ThisExpressionSyntax)asNode);
						break;
					case SyntaxKind.ExpressionStatement:
						VisitExpressionStatement((ExpressionStatementSyntax)asNode);
						break;
					case SyntaxKind.Block:
						VisitBlock((BlockSyntax)asNode);
						break;
					case SyntaxKind.PredefinedType:
						break;
					case SyntaxKind.IdentifierName:
						VisitIdentifierName((IdentifierNameSyntax)asNode);
						break;
					case SyntaxKind.SimpleMemberAccessExpression:
					case SyntaxKind.PointerMemberAccessExpression:
						VisitMemberAccessExpression((MemberAccessExpressionSyntax)asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}\n|{asNode.ToFullString()}|");
						break;
				}
			}
			else
			{
				SyntaxToken asToken = nodesAndTokens[i].AsToken();
				SyntaxKind kind = asToken.Kind();

				switch (kind)
				{

					case SyntaxKind.IdentifierToken:
						{
							VisitLeadingTrivia(asToken);
							JSSB.Append($"{asToken.Text}");
							VisitTrailingTrivia(asToken);
							break;
						}
					case SyntaxKind.ForEachKeyword:
						{
							VisitLeadingTrivia(asToken);
							JSSB.Append("for");
							VisitTrailingTrivia(asToken);
							break;
						}
					case SyntaxKind.InKeyword:
						{
							VisitLeadingTrivia(asToken);
							JSSB.Append("of");
							VisitTrailingTrivia(asToken);
							break;
						}
					case SyntaxKind.CloseParenToken:
					case SyntaxKind.OpenParenToken:
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}
}
