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
				{
					string _full = trivia.ToFullString();
					JSSB.Append(_full);
					return;
				}
			case SyntaxKind.EndOfLineTrivia:
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
			//TODO???
			case SyntaxKind.SkippedTokensTrivia:
				{
					string _full = trivia.ToFullString();
					JSSB.Append(_full);
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
				{
					VisitLeadingTrivia(token);

					JSSB.Append(token.Text);

					VisitTrailingTrivia(token);
					return;
				}
			case SyntaxKind.EndOfFileToken:
				{
					VisitLeadingTrivia(token);

					JSSB.Append(token.Text);

					VisitTrailingTrivia(token);

					return;
				}
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
					case SyntaxKind.AttributeList:
					case SyntaxKind.ExternAliasDirective:
					case SyntaxKind.UsingDirective:
						{
#if DEBUG
							Log.WarningLine($"\"{kind}\" not implemented or unlikely to be implemented. Ignoring! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{asNode.ToFullString()}|");
#endif
							break;
						}
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
					case SyntaxKind.UsingDirective:
					case SyntaxKind.DelegateDeclaration:
					case SyntaxKind.InterfaceDeclaration:
					case SyntaxKind.StructDeclaration:
					case SyntaxKind.QualifiedName:
					case SyntaxKind.IdentifierName:
						{
#if DEBUG
							Log.WarningLine($"\"{kind}\" not implemented or unlikely to be implemented. Ignoring! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{asNode.ToFullString()}|");
#endif
							break;
						}
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
					case SyntaxKind.DelegateDeclaration:
					case SyntaxKind.InterfaceDeclaration:
					case SyntaxKind.StructDeclaration:
					case SyntaxKind.QualifiedName:
					case SyntaxKind.IdentifierName:
						{
#if DEBUG
							Log.WarningLine($"\"{kind}\" not implemented or unlikely to be implemented. Ignoring! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{asNode.ToFullString()}|");
#endif
							break;
						}
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
}
