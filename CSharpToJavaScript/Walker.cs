using CSharpToJavaScript.Utils;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Text;


namespace CSharpToJavaScript;

//Useful links:
//https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/get-started/syntax-analysis
//https://roslynquoter.azurewebsites.net/
//https://sourceroslyn.io/
//https://sharplab.io/
//
//Annotations are interesting, but because everything is immutable...
//I don't think it is faster than the current approach.
//https://joshvarty.com/2015/09/18/learn-roslyn-now-part-13-keeping-track-of-syntax-nodes-with-syntax-annotations/
//
//NOTE for me: Read about DocumentEditor!
//https://joshvarty.wordpress.com/2015/08/18/learn-roslyn-now-part-12-the-documenteditor/
//Should I do it in two phases??? First one, change c# code. The second one translate as-is to js...
//Also see roslyn source!
//https://github.com/dotnet/roslyn
//"this" is IDE0009
//https://learn.microsoft.com/ru-ru/dotnet/fundamentals/code-analysis/style-rules/ide0003-ide0009
//https://github.com/dotnet/roslyn/blob/main/src/VisualStudio/Core/Def/CodeCleanup/CommonCodeCleanUpFixerDiagnosticIds.cs#L20
//https://github.com/dotnet/roslyn/blob/main/src/Analyzers/Core/Analyzers/QualifyMemberAccess/AbstractQualifyMemberAccessDiagnosticAnalyzer.cs
//Read and think about it!
//
//also f#??? vb??? test)

internal class Walker : CSharpSyntaxWalker
{
	public StringBuilder JSSB { get; set; } = new();

	private readonly NETAPI _NETAPI = new();

	private readonly CSTOJSOptions _Options;
	private readonly SemanticModel _Model;

	private SyntaxNode? _SNOriginalAsExpression = null;
	private SyntaxNode? _SNBaseConstructorInitializerNode = null;
	private SyntaxNode? _SNPropertyType = null;

	private string _NameSpaceStr = string.Empty;
	private string _CurrentClassStr = string.Empty;

	private bool _PropertyStatic = false;
	private bool _ConstKeyword = false;
	private bool _IgnoreArrayType = false;
	private bool _IgnoreAsParenthesis = false;
	private bool _IgnoreTailingDot = false;
	private bool _GlobalStatement = false;

	private int _EnumMembers = 0;

	private string[] _AttributeDatasForInvocation = new string[2];
	public Walker(CSTOJSOptions options, SemanticModel model) : base(SyntaxWalkerDepth.Trivia)
	{
		_Options = options;
		_Model = model;
	}

	public override void VisitTrivia(SyntaxTrivia trivia)
	{
		switch (trivia.Kind())
		{
			case SyntaxKind.MultiLineCommentTrivia:
			case SyntaxKind.WhitespaceTrivia:
			case SyntaxKind.SingleLineCommentTrivia:
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

					ImmutableArray<Diagnostic> diagnostics = _Model.GetDiagnostics();
					for (int i = 0; i < diagnostics.Length; i++)
					{
						if (_Options.Debug)
							Log.WarningLine(diagnostics[i].ToString());
						
						//print an error if compilation fails
						if (diagnostics[i].Severity == DiagnosticSeverity.Error)
						{
							if(_Options.DisableCompilationErrors == false)
								Log.ErrorLine(diagnostics[i].ToString());
						}
					}
					return;
				}
			case SyntaxKind.OpenBraceToken: 
				{
					if(!_Options.KeepBraceOnTheSameLine)
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
	public override void VisitClassDeclaration(ClassDeclarationSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}

		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.DestructorDeclaration:
					case SyntaxKind.IndexerDeclaration:
					case SyntaxKind.DelegateDeclaration:
					case SyntaxKind.EventFieldDeclaration:
					case SyntaxKind.TypeParameterConstraintClause:
					case SyntaxKind.EventDeclaration:
					case SyntaxKind.StructDeclaration:
					case SyntaxKind.OperatorDeclaration:
					case SyntaxKind.ConversionOperatorDeclaration:
					case SyntaxKind.AttributeList:
						{
#if DEBUG
								Log.WarningLine($"\"{kind}\" not implemented or unlikely to be implemented. Ignoring! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{asNode.ToFullString()}|");
#endif
							break;
						}
					case SyntaxKind.TypeParameterList:
						{
							SyntaxTriviaList _syntaxTrivias = asNode.GetTrailingTrivia();
							for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
							{
								VisitTrivia(_syntaxTrivias[_i]);
							}
							break;
						}
					case SyntaxKind.ClassDeclaration:
						VisitClassDeclaration((ClassDeclarationSyntax)asNode);
						break;
					case SyntaxKind.BaseList:
						VisitBaseList((BaseListSyntax)asNode);
						break;
					case SyntaxKind.FieldDeclaration:
						VisitFieldDeclaration((FieldDeclarationSyntax)asNode);
						break;
					case SyntaxKind.ConstructorDeclaration:
						VisitConstructorDeclaration((ConstructorDeclarationSyntax)asNode);
						break;
					case SyntaxKind.MethodDeclaration:
						VisitMethodDeclaration((MethodDeclarationSyntax)asNode);
						break;
					case SyntaxKind.PropertyDeclaration:
						VisitPropertyDeclaration((PropertyDeclarationSyntax)asNode);
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
					case SyntaxKind.SealedKeyword:
					case SyntaxKind.UnsafeKeyword:
 					case SyntaxKind.PartialKeyword:
					case SyntaxKind.StaticKeyword:
						break;
					case SyntaxKind.InternalKeyword:
					case SyntaxKind.PublicKeyword:
						VisitLeadingTrivia(asToken);
						break;
					case SyntaxKind.OpenBraceToken:
					case SyntaxKind.CloseBraceToken:
					case SyntaxKind.ClassKeyword:
						VisitToken(asToken);
						break;
					case SyntaxKind.IdentifierToken:
						_CurrentClassStr = asToken.Text;
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}

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
						{
#if DEBUG
							Log.WarningLine($"\"{kind}\" not implemented or unlikely to be implemented. Ignoring! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{asNode.ToFullString()}|");
#endif
							break;
						}
					case SyntaxKind.BaseConstructorInitializer:
						{
							_SNBaseConstructorInitializerNode = asNode;
							SyntaxTriviaList _syntaxTrivias = asNode.GetTrailingTrivia();
							for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
							{
								VisitTrivia(_syntaxTrivias[_i]);
							}
							break;
						}
					case SyntaxKind.ParameterList:
						VisitParameterList((ParameterListSyntax)asNode);
						break;
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
					case SyntaxKind.StaticKeyword: 
						{
							VisitToken(asToken);
							
							JSSB.AppendLine();

							for (int j = 0; j < nodesAndTokens.Count; j++)
							{
								asNode = nodesAndTokens[j].AsNode();
								if (asNode != null) 
								{
									if (asNode.IsKind(SyntaxKind.Block)) 
									{
										VisitBlock((BlockSyntax)asNode);
										break;
									}
								}
							}
							return;
						}
					case SyntaxKind.PublicKeyword:
						VisitLeadingTrivia(asToken);
						break;
					case SyntaxKind.IdentifierToken:
						{
							VisitLeadingTrivia(asToken);
							JSSB.Append("constructor");
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

	public override void VisitParameter(ParameterSyntax node)
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
					case SyntaxKind.ArrayType:
					case SyntaxKind.NullableType:
					case SyntaxKind.GenericName:
					case SyntaxKind.IdentifierName:
					case SyntaxKind.PredefinedType:
						{
#if DEBUG
							Log.WarningLine($"\"{kind}\" not implemented or unlikely to be implemented. Ignoring! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{asNode.ToFullString()}|");
#endif
							break;
						}
					case SyntaxKind.EqualsValueClause:
						{
							VisitEqualsValueClause((EqualsValueClauseSyntax)asNode);
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
					case SyntaxKind.OutKeyword:
					case SyntaxKind.RefKeyword:
						VisitLeadingTrivia(asToken);
						break;
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
	public override void VisitCatchDeclaration(CatchDeclarationSyntax node)
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
						{
#if DEBUG
							Log.WarningLine($"\"{kind}\" not implemented or unlikely to be implemented. Ignoring! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{asNode.ToFullString()}|");
#endif
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
					case SyntaxKind.OpenParenToken:
					case SyntaxKind.CloseParenToken:
					case SyntaxKind.IdentifierToken:
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitBlock(BlockSyntax node)
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
					case SyntaxKind.UsingStatement:
					case SyntaxKind.LockStatement:
					case SyntaxKind.FixedStatement:
					case SyntaxKind.UnsafeStatement:
						{
#if DEBUG
							Log.WarningLine($"\"{kind}\" not implemented or unlikely to be implemented. Ignoring! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{asNode.ToFullString()}|");
#endif
							break;
						}
					case SyntaxKind.ExpressionStatement: 
						VisitExpressionStatement((ExpressionStatementSyntax)asNode);
						break;
					case SyntaxKind.ForEachStatement: 
						VisitForEachStatement((ForEachStatementSyntax)asNode);
						break;
					case SyntaxKind.LocalDeclarationStatement:
						VisitLocalDeclarationStatement((LocalDeclarationStatementSyntax)asNode);
						break;
					case SyntaxKind.IfStatement:
						VisitIfStatement((IfStatementSyntax)asNode);
						break;
					case SyntaxKind.Block:
						VisitBlock((BlockSyntax)asNode);
						break;
					case SyntaxKind.EmptyStatement:
						VisitEmptyStatement((EmptyStatementSyntax)asNode);
						break;
					case SyntaxKind.TryStatement:
						VisitTryStatement((TryStatementSyntax)asNode);
						break;
					case SyntaxKind.ThrowStatement:
						VisitThrowStatement((ThrowStatementSyntax)asNode);
						break;
					case SyntaxKind.DoStatement:
						VisitDoStatement((DoStatementSyntax)asNode);
						break;
					case SyntaxKind.ReturnStatement:
						VisitReturnStatement((ReturnStatementSyntax)asNode);
						break;
					case SyntaxKind.ForStatement:
						VisitForStatement((ForStatementSyntax)asNode);
						break;
					case SyntaxKind.BreakStatement:
						VisitBreakStatement((BreakStatementSyntax)asNode);
						break;
					case SyntaxKind.SwitchStatement:
						VisitSwitchStatement((SwitchStatementSyntax)asNode);
						break;
					case SyntaxKind.ContinueStatement:
						VisitContinueStatement((ContinueStatementSyntax)asNode);
						break;
					case SyntaxKind.WhileStatement:
						VisitWhileStatement((WhileStatementSyntax)asNode);
						break;
					case SyntaxKind.LocalFunctionStatement:
						VisitLocalFunctionStatement((LocalFunctionStatementSyntax)asNode);
						break;
					case SyntaxKind.LabeledStatement:
						VisitLabeledStatement((LabeledStatementSyntax)asNode);
						break;
					case SyntaxKind.ForEachVariableStatement:
						VisitForEachVariableStatement((ForEachVariableStatementSyntax)asNode);
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
					case SyntaxKind.CloseBraceToken: 
						VisitToken(asToken);
						break;
					case SyntaxKind.OpenBraceToken: 
						{
							VisitToken(asToken);
							if (_SNBaseConstructorInitializerNode != null)
							{
								SyntaxTriviaList _syntaxTrivias = asToken.LeadingTrivia;
								for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
								{
									VisitTrivia(_syntaxTrivias[_i]);
								}
								JSSB.Append("\tsuper");
								Visit(((ConstructorInitializerSyntax)_SNBaseConstructorInitializerNode).ArgumentList);
								//Todo!
								//JSSB.Append(";");
								_SNBaseConstructorInitializerNode = null;
							}
							break;
						}
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}

		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.VariableDeclaration: 
						VisitVariableDeclaration((VariableDeclarationSyntax)asNode);
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
					case SyntaxKind.ConstKeyword:
						{
							_ConstKeyword = true;
							VisitToken(asToken);
							break;
						}
					case SyntaxKind.SemicolonToken:
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitExpressionStatement(ExpressionStatementSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}

		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.UnaryPlusExpression:
					case SyntaxKind.UnaryMinusExpression:
					case SyntaxKind.BitwiseNotExpression:
					case SyntaxKind.LogicalNotExpression:
					case SyntaxKind.PreIncrementExpression:
					case SyntaxKind.PreDecrementExpression:
					case SyntaxKind.AddressOfExpression:
					case SyntaxKind.PointerIndirectionExpression:
					case SyntaxKind.IndexExpression:
						VisitPrefixUnaryExpression((PrefixUnaryExpressionSyntax)asNode);
						break;
					case SyntaxKind.AddExpression:
					case SyntaxKind.SubtractExpression:
					case SyntaxKind.MultiplyExpression:
					case SyntaxKind.DivideExpression:
					case SyntaxKind.ModuloExpression:
					case SyntaxKind.LeftShiftExpression:
					case SyntaxKind.RightShiftExpression:
					case SyntaxKind.UnsignedRightShiftExpression:
					case SyntaxKind.LogicalOrExpression:
					case SyntaxKind.LogicalAndExpression:
					case SyntaxKind.BitwiseOrExpression:
					case SyntaxKind.BitwiseAndExpression:
					case SyntaxKind.ExclusiveOrExpression:
					case SyntaxKind.EqualsExpression:
					case SyntaxKind.NotEqualsExpression:
					case SyntaxKind.LessThanExpression:
					case SyntaxKind.LessThanOrEqualExpression:
					case SyntaxKind.GreaterThanExpression:
					case SyntaxKind.GreaterThanOrEqualExpression:
					case SyntaxKind.IsExpression:
					case SyntaxKind.AsExpression:
					case SyntaxKind.CoalesceExpression:
						VisitBinaryExpression((BinaryExpressionSyntax)asNode);
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
					case SyntaxKind.AnonymousObjectCreationExpression:
						VisitAnonymousObjectCreationExpression((AnonymousObjectCreationExpressionSyntax)asNode);
						break;
					case SyntaxKind.ParenthesizedLambdaExpression:
						VisitParenthesizedLambdaExpression((ParenthesizedLambdaExpressionSyntax)asNode);
						break;
					case SyntaxKind.ObjectCreationExpression:
						VisitObjectCreationExpression((ObjectCreationExpressionSyntax)asNode);
						break;
					case SyntaxKind.SimpleMemberAccessExpression:
					case SyntaxKind.PointerMemberAccessExpression:
						VisitMemberAccessExpression((MemberAccessExpressionSyntax)asNode);
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
						VisitAssignmentExpression((AssignmentExpressionSyntax)asNode);
						break;
					case SyntaxKind.ConditionalAccessExpression:
						VisitConditionalAccessExpression((ConditionalAccessExpressionSyntax)asNode);
						break;
					case SyntaxKind.PostIncrementExpression:
					case SyntaxKind.PostDecrementExpression:
					case SyntaxKind.SuppressNullableWarningExpression:
						VisitPostfixUnaryExpression((PostfixUnaryExpressionSyntax)asNode);
						break;
					case SyntaxKind.InvocationExpression:
						VisitInvocationExpression((InvocationExpressionSyntax)asNode);
						break;
					case SyntaxKind.AwaitExpression:
						VisitAwaitExpression((AwaitExpressionSyntax)asNode);
						break;
					case SyntaxKind.ElementAccessExpression:
						VisitElementAccessExpression((ElementAccessExpressionSyntax)asNode);
						break;
					case SyntaxKind.ParenthesizedExpression:
						VisitParenthesizedExpression((ParenthesizedExpressionSyntax)asNode);
						break;
					case SyntaxKind.IdentifierName:
						VisitIdentifierName((IdentifierNameSyntax)asNode);
						break;
					case SyntaxKind.ConditionalExpression:
						VisitConditionalExpression((ConditionalExpressionSyntax)asNode);
						break;
					case SyntaxKind.ThisExpression:
						VisitThisExpression((ThisExpressionSyntax)asNode);
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
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitArgument(ArgumentSyntax node)
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
					case SyntaxKind.NameColon:
						{
#if DEBUG
							Log.WarningLine($"\"{kind}\" not implemented or unlikely to be implemented. Ignoring! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{asNode.ToFullString()}|");
#endif
							break;
						}
					case SyntaxKind.UnaryPlusExpression:
					case SyntaxKind.UnaryMinusExpression:
					case SyntaxKind.BitwiseNotExpression:
					case SyntaxKind.LogicalNotExpression:
					case SyntaxKind.PreIncrementExpression:
					case SyntaxKind.PreDecrementExpression:
					case SyntaxKind.AddressOfExpression:
					case SyntaxKind.PointerIndirectionExpression:
					case SyntaxKind.IndexExpression:
						VisitPrefixUnaryExpression((PrefixUnaryExpressionSyntax)asNode);
						break;
					case SyntaxKind.AddExpression:
					case SyntaxKind.SubtractExpression:
					case SyntaxKind.MultiplyExpression:
					case SyntaxKind.DivideExpression:
					case SyntaxKind.ModuloExpression:
					case SyntaxKind.LeftShiftExpression:
					case SyntaxKind.RightShiftExpression:
					case SyntaxKind.UnsignedRightShiftExpression:
					case SyntaxKind.LogicalOrExpression:
					case SyntaxKind.LogicalAndExpression:
					case SyntaxKind.BitwiseOrExpression:
					case SyntaxKind.BitwiseAndExpression:
					case SyntaxKind.ExclusiveOrExpression:
					case SyntaxKind.EqualsExpression:
					case SyntaxKind.NotEqualsExpression:
					case SyntaxKind.LessThanExpression:
					case SyntaxKind.LessThanOrEqualExpression:
					case SyntaxKind.GreaterThanExpression:
					case SyntaxKind.GreaterThanOrEqualExpression:
					case SyntaxKind.IsExpression:
					case SyntaxKind.AsExpression:
					case SyntaxKind.CoalesceExpression:
						VisitBinaryExpression((BinaryExpressionSyntax)asNode);
						break;
					case SyntaxKind.ObjectCreationExpression:
						VisitObjectCreationExpression((ObjectCreationExpressionSyntax)asNode);
						break;
					case SyntaxKind.ImplicitObjectCreationExpression:
						VisitImplicitObjectCreationExpression((ImplicitObjectCreationExpressionSyntax)asNode);
						break;
					case SyntaxKind.AnonymousObjectCreationExpression:
						VisitAnonymousObjectCreationExpression((AnonymousObjectCreationExpressionSyntax)asNode);
						break;
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
					case SyntaxKind.PostIncrementExpression:
					case SyntaxKind.PostDecrementExpression:
					case SyntaxKind.SuppressNullableWarningExpression:
						VisitPostfixUnaryExpression((PostfixUnaryExpressionSyntax)asNode);
						break;
					case SyntaxKind.ThisExpression:
						VisitThisExpression((ThisExpressionSyntax)asNode);
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
						VisitAssignmentExpression((AssignmentExpressionSyntax)asNode);
						break;
					case SyntaxKind.ElementAccessExpression:
						VisitElementAccessExpression((ElementAccessExpressionSyntax)asNode);
						break;
					case SyntaxKind.SimpleMemberAccessExpression:
					case SyntaxKind.PointerMemberAccessExpression:
						VisitMemberAccessExpression((MemberAccessExpressionSyntax)asNode);
						break;
					case SyntaxKind.TypeOfExpression:
						VisitTypeOfExpression((TypeOfExpressionSyntax)asNode);
						break;
					case SyntaxKind.ConditionalExpression:
						VisitConditionalExpression((ConditionalExpressionSyntax)asNode);
						break;
					case SyntaxKind.SimpleLambdaExpression:
						VisitSimpleLambdaExpression((SimpleLambdaExpressionSyntax)asNode);
						break;
					case SyntaxKind.InvocationExpression:
						VisitInvocationExpression((InvocationExpressionSyntax)asNode);
						break;
					case SyntaxKind.ParenthesizedExpression:
						VisitParenthesizedExpression((ParenthesizedExpressionSyntax)asNode);
						break;
					case SyntaxKind.ParenthesizedLambdaExpression:
						VisitParenthesizedLambdaExpression((ParenthesizedLambdaExpressionSyntax)asNode);
						break;
					case SyntaxKind.InterpolatedStringExpression:
						VisitInterpolatedStringExpression((InterpolatedStringExpressionSyntax)asNode);
						break;
					case SyntaxKind.CastExpression:
						VisitCastExpression((CastExpressionSyntax)asNode);
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
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
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
					case SyntaxKind.ObjectCreationExpression:
						VisitObjectCreationExpression((ObjectCreationExpressionSyntax)asNode);
						break;
					case SyntaxKind.BaseExpression:
						VisitBaseExpression((BaseExpressionSyntax)asNode);
						break;
					case SyntaxKind.GenericName:
						VisitGenericName((GenericNameSyntax)asNode);
						break;
					case SyntaxKind.IdentifierName:
						VisitIdentifierName((IdentifierNameSyntax)asNode);
						break;
					case SyntaxKind.ThisExpression:
						VisitThisExpression((ThisExpressionSyntax)asNode);
						break;
					case SyntaxKind.ParenthesizedExpression:
						VisitParenthesizedExpression((ParenthesizedExpressionSyntax)asNode);
						break;
					case SyntaxKind.PredefinedType:
						{
							//TODO! other types!
							//

							//this is string.Empty
							JSSB.Append("\"\"");
							SyntaxTriviaList _syntaxTrivias = nodesAndTokens[nodesAndTokens.Count - 1].GetTrailingTrivia();
							for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
							{
								VisitTrivia(_syntaxTrivias[_i]);
							}
							return;
						}
					case SyntaxKind.InvocationExpression:
						VisitInvocationExpression((InvocationExpressionSyntax)asNode);
						break;
					case SyntaxKind.ElementAccessExpression:
						VisitElementAccessExpression((ElementAccessExpressionSyntax)asNode);
						break;
					case SyntaxKind.SimpleMemberAccessExpression:
					case SyntaxKind.PointerMemberAccessExpression:
						VisitMemberAccessExpression((MemberAccessExpressionSyntax)asNode);
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
					case SyntaxKind.MemberBindingExpression:
						VisitMemberBindingExpression((MemberBindingExpressionSyntax)asNode);
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
					case SyntaxKind.DotToken:
						{
							if (_IgnoreTailingDot)
								_IgnoreTailingDot = false;
							else
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

	public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
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
						{
#if DEBUG
							Log.WarningLine($"\"{kind}\" not implemented or unlikely to be implemented. Ignoring! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{asNode.ToFullString()}|");
#endif
							break;
						}
					case SyntaxKind.EnumMemberDeclaration:
						VisitEnumMemberDeclaration((EnumMemberDeclarationSyntax)asNode);
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
					case SyntaxKind.PrivateKeyword:
					case SyntaxKind.PublicKeyword:
						VisitLeadingTrivia(asToken);
						break;
					case SyntaxKind.EnumKeyword:
						{
							VisitLeadingTrivia(asToken);
							JSSB.Append("const");
							VisitTrailingTrivia(asToken);
							break;
						}
					case SyntaxKind.IdentifierToken:
						{
							VisitLeadingTrivia(asToken);
							VisitToken(asToken.WithoutTrivia());
							JSSB.Append(" = ");
							VisitTrailingTrivia(asToken);
							break;
						}
					case SyntaxKind.CommaToken:
					case SyntaxKind.OpenBraceToken:
						VisitToken(asToken);
						break;
					case SyntaxKind.CloseBraceToken:
						{
							VisitToken(asToken);
							_EnumMembers = 0;
							break;
						}
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
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
					case SyntaxKind.EqualsValueClause:
						{
							JSSB.Append(": ");
							ExpressionSyntax _value = ((EqualsValueClauseSyntax)asNode).Value;
							if(_value is LiteralExpressionSyntax)
								VisitLiteralExpression((LiteralExpressionSyntax)_value);
							else
								Log.ErrorLine($"asNode : _value is {_value.Kind()}\n|{asNode.ToFullString()}|");
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
					case SyntaxKind.IdentifierToken:
						{
							if (nodesAndTokens.Count == 1)
							{
								VisitLeadingTrivia(asToken);
								VisitToken(asToken.WithoutTrivia());
								JSSB.Append($" : {_EnumMembers++}");
								VisitTrailingTrivia(asToken);
							}
							else
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

	public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}

		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.TypeParameterList:
					case SyntaxKind.TypeParameterConstraintClause:
					case SyntaxKind.AttributeList:
						{
#if DEBUG
							Log.WarningLine($"\"{kind}\" not implemented or unlikely to be implemented. Ignoring! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{asNode.ToFullString()}|");
#endif
							break;
						}
					case SyntaxKind.IdentifierName:
					case SyntaxKind.GenericName:
					case SyntaxKind.PredefinedType:
						{
							SyntaxTriviaList _syntaxTrivias = asNode.GetLeadingTrivia();
							for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
							{
								VisitTrivia(_syntaxTrivias[_i]);
							}
							break;
						}
					//case SyntaxKind.IdentifierName:
					//	VisitIdentifierName((IdentifierNameSyntax)asNode);
					//	break;
					case SyntaxKind.ParameterList:
						VisitParameterList((ParameterListSyntax)asNode);
						break;
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
					case SyntaxKind.AbstractKeyword:
					case SyntaxKind.SealedKeyword:
					case SyntaxKind.NewKeyword:
					case SyntaxKind.OverrideKeyword:
					case SyntaxKind.ProtectedKeyword:
					case SyntaxKind.VirtualKeyword:
					case SyntaxKind.PartialKeyword:
					case SyntaxKind.PrivateKeyword:
					case SyntaxKind.PublicKeyword:
						VisitLeadingTrivia(asToken);
						break;
					case SyntaxKind.StaticKeyword:
					case SyntaxKind.AsyncKeyword:
					case SyntaxKind.IdentifierToken:
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitFieldDeclaration(FieldDeclarationSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}

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
						{
#if DEBUG
							Log.WarningLine($"\"{kind}\" not implemented or unlikely to be implemented. Ignoring! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{asNode.ToFullString()}|");
#endif
							break;
						}
					case SyntaxKind.VariableDeclaration:
						VisitVariableDeclaration((VariableDeclarationSyntax)asNode);
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
					case SyntaxKind.ReadOnlyKeyword:
						break;
					case SyntaxKind.StaticKeyword:
					case SyntaxKind.SemicolonToken:
						VisitToken(asToken);
						break;
					case SyntaxKind.ConstKeyword:
					case SyntaxKind.PublicKeyword:
					case SyntaxKind.PrivateKeyword:
						VisitLeadingTrivia(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}

		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		FieldDeclarationSyntax? field = null;

		bool hasDefault = false;
		
		SyntaxNode? defaultValue = nodesAndTokens.FirstOrDefault(n => n.IsKind(SyntaxKind.EqualsValueClause)).AsNode();
		if (defaultValue != default)
			hasDefault = true;

		if(nodesAndTokens.Any(n => n.IsKind(SyntaxKind.StaticKeyword)))
			_PropertyStatic = true;

		for (int i = nodesAndTokens.Count - 1; i >= 0; i--)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				if (kind == SyntaxKind.AccessorList)
				{
					string _getSetStr = asNode.ToString().Trim().Replace(" ", "");

					if (_getSetStr == "{get;set;}" || _getSetStr == "{get;}")
					{
						IEnumerable<SyntaxNodeOrToken> key = from n in nodesAndTokens
															 where n.IsNode
															 where n.AsNode().IsKind(SyntaxKind.PredefinedType)
															 select n;

						string _indentifier = "_" + nodesAndTokens[i - 1].AsToken().ToString() + "_";

						if (!_PropertyStatic)
							_indentifier = "#" + _indentifier;

						if (!key.Any())
						{
							key = from n in nodesAndTokens
								  where n.IsNode
								  where n.AsNode().IsKind(SyntaxKind.IdentifierName)
								  select n;

							if (!key.Any())
							{
								key = from n in nodesAndTokens
									  where n.IsNode
									  where n.AsNode().IsKind(SyntaxKind.GenericName)
									  select n;
							}

							if (!key.Any())
							{
								key = from n in nodesAndTokens
									  where n.IsNode
									  where n.AsNode().IsKind(SyntaxKind.NullableType)
									  select n;
							}

							_SNPropertyType = key.FirstOrDefault().AsNode();

							//
							//
							//TODO! change this mess!
							if (hasDefault)
							{
								field = SyntaxFactory.FieldDeclaration(
								SyntaxFactory.VariableDeclaration(SyntaxFactory.IdentifierName(key.First().ToString()))
							.WithVariables(
									SyntaxFactory.SingletonSeparatedList(
										SyntaxFactory.VariableDeclarator(
											SyntaxFactory.Identifier(_indentifier))
										.WithInitializer(defaultValue as EqualsValueClauseSyntax))))
							.WithModifiers(
								SyntaxFactory.TokenList(new[]
								{
							SyntaxFactory.Token(SyntaxKind.PrivateKeyword)
								}))
							.WithLeadingTrivia(node.GetLeadingTrivia())
							.WithTrailingTrivia(node.GetTrailingTrivia());
							}
							else
							{
								field = SyntaxFactory.FieldDeclaration(
								SyntaxFactory.VariableDeclaration(SyntaxFactory.IdentifierName(key.First().ToString()))
							.WithVariables(
									SyntaxFactory.SingletonSeparatedList(
										SyntaxFactory.VariableDeclarator(
											SyntaxFactory.Identifier(_indentifier)))))
							.WithModifiers(
								SyntaxFactory.TokenList(new[]
								{
							SyntaxFactory.Token(SyntaxKind.PrivateKeyword)
								}))
							.WithLeadingTrivia(node.GetLeadingTrivia())
							.WithTrailingTrivia(node.GetTrailingTrivia());
							}
						}
						else
						{
							_SNPropertyType = key.First().AsNode();

							key = key.First().ChildNodesAndTokens();

							if (hasDefault)
							{
								field = SyntaxFactory.FieldDeclaration(
								SyntaxFactory.VariableDeclaration(
								SyntaxFactory.PredefinedType(SyntaxFactory.Token(key.First().Kind())))
								.WithVariables(
									SyntaxFactory.SingletonSeparatedList(
										SyntaxFactory.VariableDeclarator(
											SyntaxFactory.Identifier(_indentifier))
									.WithInitializer(defaultValue as EqualsValueClauseSyntax))))
								.WithModifiers(
									SyntaxFactory.TokenList(new[]
									{
										SyntaxFactory.Token(SyntaxKind.PrivateKeyword)
									}))
								.WithLeadingTrivia(node.GetLeadingTrivia())
								.WithTrailingTrivia(node.GetTrailingTrivia());
							}
							else
							{
								field = SyntaxFactory.FieldDeclaration(
								SyntaxFactory.VariableDeclaration(
								SyntaxFactory.PredefinedType(SyntaxFactory.Token(key.First().Kind())))
								.WithVariables(
										SyntaxFactory.SingletonSeparatedList(
											SyntaxFactory.VariableDeclarator(
												SyntaxFactory.Identifier(_indentifier)))))
								.WithModifiers(
									SyntaxFactory.TokenList(new[]
									{
										SyntaxFactory.Token(SyntaxKind.PrivateKeyword)
									}))
								.WithLeadingTrivia(node.GetLeadingTrivia())
								.WithTrailingTrivia(node.GetTrailingTrivia());
							}
						}

						break;
					}
				}
			}

		}

		if (field != null)
		{
			VisitFieldDeclaration(field);
			_SNPropertyType = null;
		}


		//main for loop for property
		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.EqualsValueClause:
					case SyntaxKind.AttributeList:
					case SyntaxKind.PredefinedType:
					case SyntaxKind.IdentifierName:
					case SyntaxKind.NullableType:
					case SyntaxKind.GenericName:
						{
#if DEBUG
							Log.WarningLine($"\"{kind}\" not implemented or unlikely to be implemented. Ignoring! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{asNode.ToFullString()}|");
#endif
							break;
						}
					case SyntaxKind.AccessorList:
						VisitAccessorList((AccessorListSyntax)asNode);
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
					case SyntaxKind.AbstractKeyword:
					case SyntaxKind.RequiredKeyword:
					case SyntaxKind.IdentifierToken:
						break;
					case SyntaxKind.SemicolonToken:
						VisitTrailingTrivia(asToken);
						break;
					case SyntaxKind.PublicKeyword:
					case SyntaxKind.PrivateKeyword:
						VisitLeadingTrivia(asToken);
						break;
					case SyntaxKind.StaticKeyword:
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitAccessorList(AccessorListSyntax node)
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
					case SyntaxKind.GetAccessorDeclaration:
						{
							IEnumerable<SyntaxNode> c = asNode.Ancestors();

							IEnumerable<SyntaxNode> a = from b in c
									where b.IsKind(SyntaxKind.PropertyDeclaration)
									select b;
							IEnumerable<SyntaxNodeOrToken> d2 = from e in a.First().ChildNodesAndTokens()
									 where e.IsKind(SyntaxKind.IdentifierToken)
									 select e;
							
							dynamic? d3 = null;
							if (d2.Count() >= 2) 
							{
								//Delete this? TODO
								d2 = from e in a.First().DescendantNodesAndTokens()
									 where e.IsKind(SyntaxKind.IdentifierName)
									 select e;
								d3 = d2.First().ChildNodesAndTokens().First().AsToken();
							}else
								d3 = d2.First().AsToken();

							BlockSyntax? _body = ((AccessorDeclarationSyntax)asNode).Body;

							if (_body != null)
							{
								//SyntaxTriviaList _syntaxTrivias = asNode.Parent!.Parent!.GetLeadingTrivia();
								/* Todo! Why there is already "/t/t" in JSSB????
								for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
								{
									VisitTrivia(_syntaxTrivias[_i]);
								}
								*/

								JSSB.Append($"get {d3.Text}()");

								SyntaxTriviaList _syntaxTrivias = asNode.GetTrailingTrivia();
								for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
								{
									VisitTrivia(_syntaxTrivias[_i]);
								}

								VisitBlock(_body);
							}
							else 
							{
								//JSSB.Append($"\n");

								//SyntaxTriviaList _syntaxTrivias = asNode.Parent.Parent.GetLeadingTrivia();
								/* Todo! Why there is already "/t/t" in JSSB????
								for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
								{
									VisitTrivia(_syntaxTrivias[_i]);
								}*/

								if (_PropertyStatic == true)
								{
									JSSB.Append($"get {d3.Text}() {{ return this._{d3.Text}_; }}");
								}
								else
									JSSB.Append($"get {d3.Text}() {{ return this.#_{d3.Text}_; }}");

								SyntaxTriviaList _syntaxTrivias = asNode.GetTrailingTrivia();
								for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
								{
									VisitTrivia(_syntaxTrivias[_i]);
								}
							}

							break;
						}
					case SyntaxKind.SetAccessorDeclaration:
						{
							IEnumerable<SyntaxNode> c = asNode.Ancestors();

							IEnumerable<SyntaxNode> a = from b in c
									where b.IsKind(SyntaxKind.PropertyDeclaration)
									select b;
							IEnumerable<SyntaxNodeOrToken> d2 = from e in a.First().ChildNodesAndTokens()
									 where e.IsKind(SyntaxKind.IdentifierToken)
									 select e;

							SyntaxToken d3 = d2.First().AsToken();

							BlockSyntax? _body = ((AccessorDeclarationSyntax)asNode).Body;

							if (_body != null)
							{
								SyntaxTriviaList _syntaxTrivias;

								if (asNode.Parent != null)
								{
									if (asNode.Parent.Parent != null)
									{
										_syntaxTrivias = asNode.Parent.Parent.GetLeadingTrivia();

										for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
										{
											VisitTrivia(_syntaxTrivias[_i]);
										}
									}
									else
										Log.ErrorLine("asNode.Parent.Parent is null");

								}
								else
									Log.ErrorLine("asNode.Parent is null");


								if (_PropertyStatic == true) 
								{
									JSSB.Append($"static ");
									_PropertyStatic = false;
								}
								JSSB.Append($"set {d3.Text}(value)");

								_syntaxTrivias = asNode.GetTrailingTrivia();
								for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
								{
									VisitTrivia(_syntaxTrivias[_i]);
								}

								VisitBlock(_body);
							}
							else
							{
								JSSB.AppendLine();

								SyntaxTriviaList _syntaxTrivias;

								if (asNode.Parent != null)
								{
									if (asNode.Parent.Parent != null)
									{
										_syntaxTrivias = asNode.Parent.Parent.GetLeadingTrivia();

										for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
										{
											VisitTrivia(_syntaxTrivias[_i]);
										}
									}
									else
										Log.ErrorLine("asNode.Parent.Parent is null");

								}
								else
									Log.ErrorLine("asNode.Parent is null");

								if (_PropertyStatic == true)
								{
									JSSB.Append($"static ");
									JSSB.Append($"set {d3.Text}(value) {{ this._{d3.Text}_ = value; }}");
									_PropertyStatic = false;
								}else
									JSSB.Append($"set {d3.Text}(value) {{ this.#_{d3.Text}_ = value; }}");

								if (asNode.Parent != null)
								{
									_syntaxTrivias = asNode.Parent.GetTrailingTrivia();
									for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
									{
										VisitTrivia(_syntaxTrivias[_i]);
									}
								}
								else
									Log.ErrorLine("asNode.Parent is null");
							}

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
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

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

	public override void VisitVariableDeclaration(VariableDeclarationSyntax node)
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
					case SyntaxKind.RefType:
					case SyntaxKind.ArrayType:
					case SyntaxKind.NullableType:
					case SyntaxKind.PredefinedType:
					case SyntaxKind.IdentifierName:
					case SyntaxKind.GenericName:
						{
							if (node.Parent.IsKind(SyntaxKind.LocalDeclarationStatement) ||
								node.Parent.IsKind(SyntaxKind.ForStatement))
							{
								if (_ConstKeyword == true)
									_ConstKeyword = false;
								else
								{
									SyntaxTriviaList _syntaxTrivias = asNode.GetLeadingTrivia();

									for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
									{
										VisitTrivia(_syntaxTrivias[_i]);
									}

									if (_Options.UseVarOverLet)
										JSSB.Append("var");
									else
										JSSB.Append("let");

									_syntaxTrivias = asNode.GetTrailingTrivia();
									for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
									{
										VisitTrivia(_syntaxTrivias[_i]);
									}
								}
							}
							break;
						}
					case SyntaxKind.VariableDeclarator:
						VisitVariableDeclarator((VariableDeclaratorSyntax)asNode);
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
					case SyntaxKind.SemicolonToken:
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitPredefinedType(PredefinedTypeSyntax node)
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
					case SyntaxKind.PredefinedType:
						VisitPredefinedType((PredefinedTypeSyntax)asNode);
						break;
					case SyntaxKind.VariableDeclarator:
						VisitVariableDeclarator((VariableDeclaratorSyntax)asNode);
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
					/*TODO!
					case SyntaxKind.IntKeyword: 
						{
							JSSB.Append("Number");
							break;
						}*/
					//case SyntaxKind.BoolKeyword:
					case SyntaxKind.ObjectKeyword:
						JSSB.Append("Object");
						break;
					case SyntaxKind.SemicolonToken:
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitVariableDeclarator(VariableDeclaratorSyntax node)
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
					case SyntaxKind.EqualsValueClause:
						VisitEqualsValueClause((EqualsValueClauseSyntax)asNode);
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
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitForEachStatement(ForEachStatementSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}

		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.ExpressionStatement:
						VisitExpressionStatement((ExpressionStatementSyntax)asNode);
						break;
					case SyntaxKind.Block:
						VisitBlock((BlockSyntax)asNode);
						break;
					case SyntaxKind.GenericName:
					case SyntaxKind.PredefinedType: 
						{
							SyntaxTriviaList _syntaxTrivias = asNode.GetLeadingTrivia();

							for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
							{
								VisitTrivia(_syntaxTrivias[_i]);
							}

							if (_Options.UseVarOverLet)
								JSSB.Append("var");
							else
								JSSB.Append("let");

							_syntaxTrivias = asNode.GetTrailingTrivia();
							for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
							{
								VisitTrivia(_syntaxTrivias[_i]);
							}
							break;
						}
					case SyntaxKind.IdentifierName:
						{
							IdentifierNameSyntax? _ins = asNode as IdentifierNameSyntax;
							if (_ins != null)
							{
								if (_ins.IsVar)
								{
									SyntaxTriviaList _syntaxTrivias = asNode.GetLeadingTrivia();

									for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
									{
										VisitTrivia(_syntaxTrivias[_i]);
									}

									if (_Options.UseVarOverLet)
										JSSB.Append("var");
									else
										JSSB.Append("let");

									_syntaxTrivias = asNode.GetTrailingTrivia();
									for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
									{
										VisitTrivia(_syntaxTrivias[_i]);
									}
								}
								else
								{
									if (IdentifierToken(asNode) == false)
									{
										VisitIdentifierName(_ins);
									}
								}
							}
							else
							{
								Log.ErrorLine($"_ins is null");
							}

							break;
						}
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


	public override void VisitArrayCreationExpression(ArrayCreationExpressionSyntax node)
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
					case SyntaxKind.ArrayType:
						{
							//Todo?
							//Check if third element is ArrayInitializerExpression
							if (nodesAndTokens.Count >= 3)
								_IgnoreArrayType = true;
							VisitArrayType((ArrayTypeSyntax)asNode);
							_IgnoreArrayType = false;
							break;
						}
					case SyntaxKind.ArrayInitializerExpression:
						VisitInitializerExpression((InitializerExpressionSyntax)asNode);
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
					case SyntaxKind.NewKeyword:
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}
	
	public override void VisitArrayType(ArrayTypeSyntax node)
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
					case SyntaxKind.NullableType:
					case SyntaxKind.PredefinedType:
					case SyntaxKind.IdentifierName: 
						JSSB.Append("Array");
						break;
					case SyntaxKind.ArrayRankSpecifier:
						VisitArrayRankSpecifier((ArrayRankSpecifierSyntax)asNode);
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
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitArrayRankSpecifier(ArrayRankSpecifierSyntax node)
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
					case SyntaxKind.AddExpression:
					case SyntaxKind.SubtractExpression:
					case SyntaxKind.MultiplyExpression:
					case SyntaxKind.DivideExpression:
					case SyntaxKind.ModuloExpression:
					case SyntaxKind.LeftShiftExpression:
					case SyntaxKind.RightShiftExpression:
					case SyntaxKind.UnsignedRightShiftExpression:
					case SyntaxKind.LogicalOrExpression:
					case SyntaxKind.LogicalAndExpression:
					case SyntaxKind.BitwiseOrExpression:
					case SyntaxKind.BitwiseAndExpression:
					case SyntaxKind.ExclusiveOrExpression:
					case SyntaxKind.EqualsExpression:
					case SyntaxKind.NotEqualsExpression:
					case SyntaxKind.LessThanExpression:
					case SyntaxKind.LessThanOrEqualExpression:
					case SyntaxKind.GreaterThanExpression:
					case SyntaxKind.GreaterThanOrEqualExpression:
					case SyntaxKind.IsExpression:
					case SyntaxKind.AsExpression:
					case SyntaxKind.CoalesceExpression:
						VisitBinaryExpression((BinaryExpressionSyntax)asNode);
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
					//Todo?
					case SyntaxKind.OmittedArraySizeExpression:
						{
#if DEBUG
							Log.WarningLine($"\"{kind}\" not implemented or unlikely to be implemented. Ignoring! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{asNode.ToFullString()}|");
#endif
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
					case SyntaxKind.OpenBracketToken:
						{
							if (_IgnoreArrayType == false)
							{
								VisitLeadingTrivia(asToken);
								JSSB.Append('(');
								VisitTrailingTrivia(asToken);
							}
							break;
						}
					case SyntaxKind.CloseBracketToken:
						{
							if (_IgnoreArrayType == false)
							{
								VisitLeadingTrivia(asToken);
								JSSB.Append(')');
								VisitTrailingTrivia(asToken);
							}
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
						{
							VisitLeadingTrivia(asToken);
							JSSB.Append('(');
							VisitTrailingTrivia(asToken);
							break;
						}
					case SyntaxKind.CloseBraceToken:
						{
							VisitLeadingTrivia(asToken);
							JSSB.Append(')');
							VisitTrailingTrivia(asToken);
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

	public override void VisitLiteralExpression(LiteralExpressionSyntax node)
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
					case SyntaxKind.NumericLiteralToken: 
						{
							string _value = asToken.Text;
							
							_value = _value.Replace("_","");
							
							if (_value.EndsWith('f') ||
								_value.EndsWith('d') ||
								_value.EndsWith('m') ||
								_value.EndsWith('u') ||
								_value.EndsWith('l') ||
								_value.EndsWith('F') ||
								_value.EndsWith('D') ||
								_value.EndsWith('M') ||
								_value.EndsWith('U') ||
								_value.EndsWith('L'))
								_value = _value.Remove(_value.Length - 1);
							
							if (_value.Length > 10)
							{
								NumberStyles _styles = NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol;
								double _d = double.Parse(_value.Replace('.', ','), _styles);

								if (_value.StartsWith('-'))
								{
									//TODO? BigInt?
									if (_d <= -9007199254740991)
									{
										Log.WarningLine($"Number: {_d} is smaller then Number.MIN_SAFE_INTEGER(-9007199254740991) clamping!");
										_value = "Number.MIN_SAFE_INTEGER";
									}
								}
								else
								{
									if (_d >= 9007199254740991)
									{
										Log.WarningLine($"Number: {_d} is larger then Number.MAX_SAFE_INTEGER(9007199254740991) clamping!");
										_value = "Number.MAX_SAFE_INTEGER";
									}
								}
							}

							_value = _value.Replace(',', '.');

							VisitLeadingTrivia(asToken);

							JSSB.Append(_value);

							VisitTrailingTrivia(asToken);
							break;
						}
					case SyntaxKind.TrueKeyword:
					case SyntaxKind.FalseKeyword:
					case SyntaxKind.StringLiteralToken:
					case SyntaxKind.CharacterLiteralToken:
					case SyntaxKind.NullKeyword:
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

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

	public override void VisitParenthesizedExpression(ParenthesizedExpressionSyntax node)
	{
		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		if (nodesAndTokens[1].IsKind(SyntaxKind.AsExpression))
			_IgnoreAsParenthesis = true;

		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.AddExpression:
					case SyntaxKind.SubtractExpression:
					case SyntaxKind.MultiplyExpression:
					case SyntaxKind.DivideExpression:
					case SyntaxKind.ModuloExpression:
					case SyntaxKind.LeftShiftExpression:
					case SyntaxKind.RightShiftExpression:
					case SyntaxKind.UnsignedRightShiftExpression:
					case SyntaxKind.LogicalOrExpression:
					case SyntaxKind.LogicalAndExpression:
					case SyntaxKind.BitwiseOrExpression:
					case SyntaxKind.BitwiseAndExpression:
					case SyntaxKind.ExclusiveOrExpression:
					case SyntaxKind.EqualsExpression:
					case SyntaxKind.NotEqualsExpression:
					case SyntaxKind.LessThanExpression:
					case SyntaxKind.LessThanOrEqualExpression:
					case SyntaxKind.GreaterThanExpression:
					case SyntaxKind.GreaterThanOrEqualExpression:
					case SyntaxKind.IsExpression:
					case SyntaxKind.CoalesceExpression:
						VisitBinaryExpression((BinaryExpressionSyntax)asNode);
						break;
					case SyntaxKind.IdentifierName:
						VisitIdentifierName((IdentifierNameSyntax)asNode);
						break;
					case SyntaxKind.AsExpression:
						{
							//Todo double/multiply asExpression?? How?
							_SNOriginalAsExpression = ((BinaryExpressionSyntax)asNode).Left;

							Visit(_SNOriginalAsExpression.WithoutTrailingTrivia());

							_SNOriginalAsExpression = null;
							break;
						}
					case SyntaxKind.UnaryPlusExpression:
					case SyntaxKind.UnaryMinusExpression:
					case SyntaxKind.BitwiseNotExpression:
					case SyntaxKind.LogicalNotExpression:
					case SyntaxKind.PreIncrementExpression:
					case SyntaxKind.PreDecrementExpression:
					case SyntaxKind.AddressOfExpression:
					case SyntaxKind.PointerIndirectionExpression:
					case SyntaxKind.IndexExpression:
						VisitPrefixUnaryExpression((PrefixUnaryExpressionSyntax)asNode);
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
					case SyntaxKind.PostIncrementExpression:
					case SyntaxKind.PostDecrementExpression:
					case SyntaxKind.SuppressNullableWarningExpression:
						VisitPostfixUnaryExpression((PostfixUnaryExpressionSyntax)asNode);
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
						VisitAssignmentExpression((AssignmentExpressionSyntax)asNode);
						break;
					case SyntaxKind.InvocationExpression:
						VisitInvocationExpression((InvocationExpressionSyntax)asNode);
						break;
					case SyntaxKind.ElementAccessExpression:
						VisitElementAccessExpression((ElementAccessExpressionSyntax)asNode);
						break;
					case SyntaxKind.SimpleMemberAccessExpression:
					case SyntaxKind.PointerMemberAccessExpression:
						VisitMemberAccessExpression((MemberAccessExpressionSyntax)asNode);
						break;
					case SyntaxKind.TypeOfExpression:
						VisitTypeOfExpression((TypeOfExpressionSyntax)asNode);
						break;
					case SyntaxKind.ConditionalExpression:
						VisitConditionalExpression((ConditionalExpressionSyntax)asNode);
						break;
					case SyntaxKind.ParenthesizedExpression:
						VisitParenthesizedExpression((ParenthesizedExpressionSyntax)asNode);
						break;
					case SyntaxKind.ParenthesizedLambdaExpression:
						VisitParenthesizedLambdaExpression((ParenthesizedLambdaExpressionSyntax)asNode);
						break;
					case SyntaxKind.ObjectCreationExpression:
						VisitObjectCreationExpression((ObjectCreationExpressionSyntax)asNode);
						break;
					case SyntaxKind.AnonymousObjectCreationExpression:
						VisitAnonymousObjectCreationExpression((AnonymousObjectCreationExpressionSyntax)asNode);
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
					case SyntaxKind.OpenParenToken:
						{
							if (_IgnoreAsParenthesis)
							{
								VisitLeadingTrivia(asToken);
								VisitTrailingTrivia(asToken);
							}
							else 
								VisitToken(asToken);
							break;
						}
					case SyntaxKind.CloseParenToken:
						{
							if (!_IgnoreAsParenthesis)
								VisitToken(asToken);

							break;
						}
					//case SyntaxKind.StringLiteralToken:
						//VisitToken(asToken);
						//break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
		
		_IgnoreAsParenthesis = false;
	}

	public override void VisitCastExpression(CastExpressionSyntax node)
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
					case SyntaxKind.NullableType:
					case SyntaxKind.PredefinedType:
						{
#if DEBUG
							Log.WarningLine($"\"{kind}\" not implemented or unlikely to be implemented. Ignoring! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{asNode.ToFullString()}|");
#endif
							break;
						}
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
					case SyntaxKind.InvocationExpression:
						VisitInvocationExpression((InvocationExpressionSyntax)asNode);
						break;
					case SyntaxKind.SimpleMemberAccessExpression:
					case SyntaxKind.PointerMemberAccessExpression:
						VisitMemberAccessExpression((MemberAccessExpressionSyntax)asNode);
						break;
					case SyntaxKind.ObjectCreationExpression:
						VisitObjectCreationExpression((ObjectCreationExpressionSyntax)asNode);
						break;
					case SyntaxKind.ImplicitObjectCreationExpression:
						VisitImplicitObjectCreationExpression((ImplicitObjectCreationExpressionSyntax)asNode);
						break;
					case SyntaxKind.UnaryPlusExpression:
					case SyntaxKind.UnaryMinusExpression:
					case SyntaxKind.BitwiseNotExpression:
					case SyntaxKind.LogicalNotExpression:
					case SyntaxKind.PreIncrementExpression:
					case SyntaxKind.PreDecrementExpression:
					case SyntaxKind.AddressOfExpression:
					case SyntaxKind.PointerIndirectionExpression:
					case SyntaxKind.IndexExpression:
						VisitPrefixUnaryExpression((PrefixUnaryExpressionSyntax)asNode);
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
					case SyntaxKind.OpenParenToken:
					case SyntaxKind.CloseParenToken:
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitImplicitObjectCreationExpression(ImplicitObjectCreationExpressionSyntax node)
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
					case SyntaxKind.ArgumentList:
						VisitArgumentList((ArgumentListSyntax)asNode); 
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
					case SyntaxKind.NewKeyword:
						{
							VisitToken(asToken);


							VariableDeclarationSyntax? _vds = node.Ancestors().FirstOrDefault(e => e.IsKind(SyntaxKind.VariableDeclaration)) as VariableDeclarationSyntax;

							SymbolInfo? symbolInfo = null;
							ISymbol? iSymbol = null;
							SyntaxNode? syntaxNode = null;

							if (_vds == null)
							{
								AssignmentExpressionSyntax? _aes = node.Ancestors().FirstOrDefault(e => e.IsKind(SyntaxKind.SimpleAssignmentExpression)) as AssignmentExpressionSyntax;

								if (_aes == null) 
								{
									//Todo!
									//Triggered with "Method(new());"
									//See also test "TestPassValueToMethod" with CustomClass
									JSSB.Append(" Object");
									Log.WarningLine($"_aes is null");
									break;
								}

								symbolInfo = _Model.GetSymbolInfo(_aes.Left);

								ClassDeclarationSyntax? classD = node.Ancestors().First(n => n.IsKind(SyntaxKind.ClassDeclaration)) as ClassDeclarationSyntax;

								if (classD == null)
								{
									Log.ErrorLine($"classD is null");
									break;
								}

								IEnumerable<ClassDeclarationSyntax>? classesD = null;
								
								if (classD.Parent != null)
								{
									classesD = from n in classD.Parent.DescendantNodes()
																				   where n.IsKind(SyntaxKind.ClassDeclaration)
																				   select n as ClassDeclarationSyntax;
								}
								else
								{
									Log.ErrorLine($"classD.Parent is null");
								}

								List<MemberDeclarationSyntax> mem = new();

								if (classesD != null)
								{
									foreach (ClassDeclarationSyntax item in classesD)
									{
										mem.AddRange(item.Members.ToList());
									}
								}

								for (int j = 0; j < mem.Count; j++)
								{
									SyntaxToken? _sT = null;
									if (mem[j] is MethodDeclarationSyntax m)
									{
										_sT = m.Identifier;
									}

									if (mem[j] is PropertyDeclarationSyntax p)
									{
										_sT = p.Identifier;
										syntaxNode = p.Type;
									}

									if (mem[j] is FieldDeclarationSyntax f)
									{
										IEnumerable<SyntaxToken> d3 = from e in f.DescendantTokens()
												 where e.IsKind(SyntaxKind.IdentifierToken)
												 select e;
										_sT = d3.Last();
									}

									if (_sT != null && _aes.Left.ToString() == _sT?.Text)
									{
										//Todo?
										//VariableDeclarationSyntax s = item.DescendantNodes().First(e => e.IsKind(SyntaxKind.VariableDeclaration)) as VariableDeclarationSyntax;
										//syntaxNode = s.Type;
										if (syntaxNode != null)
										{
											symbolInfo = _Model.GetSymbolInfo(syntaxNode);
											break;
										}
										else
										{
											Log.ErrorLine("syntaxNode is null");
											break;
										}
									}
								}
							}
							else
							{
								if (_SNPropertyType != null)
									symbolInfo = _Model.GetSymbolInfo(_SNPropertyType);
								else
									symbolInfo = _Model.GetSymbolInfo(_vds.Type);

								syntaxNode = _vds.Type;
							}


							if (symbolInfo?.CandidateSymbols.Length >= 1)
								iSymbol = symbolInfo?.CandidateSymbols[0];
							else
								iSymbol = symbolInfo?.Symbol;

							if (iSymbol != null && iSymbol.Kind != SymbolKind.ErrorType)
							{
								string? _containingNamespace = iSymbol.ContainingNamespace.ToString();
								if (_containingNamespace == null)
								{
									Log.ErrorLine("_containingNamespace is null");
									_containingNamespace = string.Empty;
								}
									
								if (_containingNamespace.Contains(nameof(CSharpToJavaScript)))
								{
									string _text = string.Empty;
									SyntaxToken _identifier = new();
									if (syntaxNode is IdentifierNameSyntax ins)
									{
										_text = ins.Identifier.Text;
										_identifier = ins.Identifier;
									}

									if (syntaxNode is GenericNameSyntax gns)
									{
										_text = gns.Identifier.Text;
										_identifier = gns.Identifier;
									}

									ImmutableArray<AttributeData> _attributeDatas = iSymbol.GetAttributes();
									
									//Check this! TODO!
									if(iSymbol.ContainingType != null)
										_attributeDatas.AddRange(iSymbol.ContainingType.GetAttributes());

									foreach (AttributeData _attr in _attributeDatas)
									{
										if (_attr.AttributeClass != null)
										{
											if (_attr.AttributeClass.Name == nameof(ToAttribute))
											{
												ToAttribute _attrLocal = new(ToAttribute.Default);
												if (_attr.ConstructorArguments[0].Value is string _str)
												{
													_attrLocal = new(_str);
												}
												else
												{
													Log.ErrorLine("_attr.ConstructorArguments[0].Value is not a string");
												}

												JSSB.Append($" {_attrLocal.Convert(_text)}");
												break;
											}
										}
										else
										{
											Log.ErrorLine("_attr.AttributeClass is null");
											break;
										}
									}
									break;
								}

								if (_containingNamespace.Contains(_NameSpaceStr))
								{
									if (syntaxNode.IsKind(SyntaxKind.GenericName))
									{
										JSSB.Append($" {((GenericNameSyntax)syntaxNode).Identifier.ToString()}");
									}
									else
									{
										if (syntaxNode != null)
											JSSB.Append($" {syntaxNode.ToString()}");
										else
											Log.ErrorLine("syntaxNode is null");
									}
									break;
								}

								//TODO?
								//Hitting with "object"!
								//See also Test "TestFieldsDefaultValue" with 'object' 'new()'
								if (syntaxNode.IsKind(SyntaxKind.PredefinedType)) 
								{
									JSSB.Append(" Object");
									break;
								}

								if (CustomCSNamesToJS(syntaxNode) == false)
								{
									JSSB.Append(' ');
									if (syntaxNode != null)
									{
										if (BuiltInTypesGenerics(syntaxNode.WithoutLeadingTrivia(), iSymbol) == false)
										{
											Log.WarningLine($"TODO : {syntaxNode} ||| USE 'CustomCSNamesToJS' TO CONVERT.");
										}
									}
									else
										Log.ErrorLine("syntaxNode is null");
								}

							}
							break;
						}
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitObjectCreationExpression(ObjectCreationExpressionSyntax node)
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
					case SyntaxKind.ObjectInitializerExpression:
						{
							Log.WarningLine($"'ObjectInitializerExpression' Ignored! Please use constructor for '{nodesAndTokens[1].ToString()}'");
							//Todo? How? JS does not have object initializer...
							break;
						}
					case SyntaxKind.ArgumentList:
						VisitArgumentList((ArgumentListSyntax)asNode);
						break;
					case SyntaxKind.PredefinedType:
						VisitPredefinedType((PredefinedTypeSyntax)asNode);
						break;
					case SyntaxKind.IdentifierName:
						VisitIdentifierName((IdentifierNameSyntax)asNode);
						break;
					case SyntaxKind.GenericName:
						VisitGenericName((GenericNameSyntax)asNode);
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
					case SyntaxKind.NewKeyword:
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitThisExpression(ThisExpressionSyntax node)
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
					case SyntaxKind.ThisKeyword:
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitBaseExpression(BaseExpressionSyntax node)
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
					case SyntaxKind.BaseKeyword:
						{
							VisitLeadingTrivia(asToken);
							JSSB.Append($"super");
							break;
						}
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitTypeArgumentList(TypeArgumentListSyntax node)
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
					case SyntaxKind.GenericName:
					case SyntaxKind.PredefinedType:
					case SyntaxKind.IdentifierName:
						{
#if DEBUG
							Log.WarningLine($"\"{kind}\" not implemented or unlikely to be implemented. Ignoring! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{asNode.ToFullString()}|");
#endif
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
					case SyntaxKind.CommaToken:
					case SyntaxKind.GreaterThanToken:
					case SyntaxKind.LessThanToken:
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitGenericName(GenericNameSyntax node)
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
					case SyntaxKind.TypeArgumentList: 
						VisitTypeArgumentList((TypeArgumentListSyntax)asNode);
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
							if (IsRightAttribute(node, asToken))
								break;

							if (IdentifierToken(node) == false) 
							{
								base.VisitGenericName(node);
							}
							break;
						}
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}

	public override void VisitIdentifierName(IdentifierNameSyntax node)
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
							if (IsRightAttribute(node, asToken))
								break;							
							
							if (IdentifierToken(node) == false)
							{
								base.VisitIdentifierName(node);
							}
							break;
						}
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}
	private bool IsRightAttribute<T>(T identifier, SyntaxToken asToken) where T : SimpleNameSyntax
	{
		SymbolInfo? _symbolInfo = null;

		if (_SNOriginalAsExpression != null)
		{
			IEnumerable<SyntaxNodeOrToken> _identifierNameSyntax = _SNOriginalAsExpression.DescendantNodesAndTokens().Where(e => e.IsToken == true);
			foreach (SyntaxNodeOrToken _item in _identifierNameSyntax)
			{
				SyntaxToken _syntaxToken = _item.AsToken();

				if (_syntaxToken.IsKind(SyntaxKind.IdentifierToken))
				{
					if (_syntaxToken.Text == asToken.Text)
					{
						if (_item.Parent != null)
							_symbolInfo = _Model.GetSymbolInfo(_item.Parent);
						else
							Log.ErrorLine("_item.Parent is null");
						break;
					}
				}
			}
			//node = _SNOriginalAsExpression;
		}
		else
		{
			if (_SNPropertyType != null)
				_symbolInfo = _Model.GetSymbolInfo(_SNPropertyType);
			else
				_symbolInfo = _Model.GetSymbolInfo(identifier);
		}

		ISymbol? _symbol = null;

		if (_symbolInfo?.CandidateSymbols.Length >= 1)
			_symbol = _symbolInfo?.CandidateSymbols[0];
		else
			_symbol = _symbolInfo?.Symbol;

		if (_symbol != null)
		{
		CheckParentAttributes:
			AttributeData[] _attributeData = _symbol.GetAttributes().ToArray();
			for (int j = 0; j < _attributeData.Length; j++)
			{
				if (_attributeData[j].AttributeClass != null)
				{
					if (_attributeData[j].AttributeClass!.Name == nameof(BinaryAttribute) ||
						_attributeData[j].AttributeClass!.Name == nameof(UnaryAttribute))
					{
						_AttributeDatasForInvocation[0] = _attributeData[j].AttributeClass!.Name;
						_AttributeDatasForInvocation[1] = _attributeData[j].ConstructorArguments[0].Value.ToString();

						return true;
					}

					if (_attributeData[j].AttributeClass.Name == nameof(EnumValueAttribute))
					{
						SyntaxTriviaList _syntaxTrivias = identifier.GetLeadingTrivia();
						for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
						{
							VisitTrivia(_syntaxTrivias[_i]);
						}

						JSSB.Append($"\"{_attributeData[j].ConstructorArguments[0].Value}\"");

						_syntaxTrivias = identifier.GetTrailingTrivia();
						for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
						{
							VisitTrivia(_syntaxTrivias[_i]);
						}

						return true;
					}

					if (_attributeData[j].AttributeClass.Name == nameof(ValueAttribute))
					{
						SyntaxTriviaList _syntaxTrivias = identifier.GetLeadingTrivia();
						for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
						{
							VisitTrivia(_syntaxTrivias[_i]);
						}

						JSSB.Append($"{_attributeData[j].ConstructorArguments[0].Value}");

						_syntaxTrivias = identifier.GetTrailingTrivia();
						for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
						{
							VisitTrivia(_syntaxTrivias[_i]);
						}

						return true;
					}

					if (_attributeData[j].AttributeClass.Name == nameof(ToAttribute))
					{
						ToAttribute _toAttr = new ToAttribute(_attributeData[j].ConstructorArguments[0].Value.ToString());

						if (_toAttr.To == ToAttribute.None)
							_IgnoreTailingDot = true;

						SyntaxTriviaList _syntaxTrivias = identifier.GetLeadingTrivia();
						for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
						{
							VisitTrivia(_syntaxTrivias[_i]);
						}

						JSSB.Append($"{_toAttr.Convert(identifier.Identifier.Text)}");

						_syntaxTrivias = identifier.GetTrailingTrivia();
						for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
						{
							VisitTrivia(_syntaxTrivias[_i]);
						}

						return true;
					}
				}
			}
			if (_symbol.ContainingType != null)
			{
				_symbol = _symbol.ContainingType;
				goto CheckParentAttributes;
			}
		}

		return false;
	}
	
	public override void VisitAssignmentExpression(AssignmentExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitAssignmentExpression(node);
	}

	public override void VisitAttribute(AttributeSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitAttribute(node);
	}
	public override void VisitArrowExpressionClause(ArrowExpressionClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitArrowExpressionClause(node);
	}
	public override void VisitArgumentList(ArgumentListSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitArgumentList(node);
	}
	public override void VisitAccessorDeclaration(AccessorDeclarationSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitAccessorDeclaration(node);
	}
	public override void VisitAliasQualifiedName(AliasQualifiedNameSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitAliasQualifiedName(node);
	}
	public override void VisitAllowsConstraintClause(AllowsConstraintClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitAllowsConstraintClause(node);
	}
	public override void VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitAnonymousMethodExpression(node);
	}
	public override void VisitAnonymousObjectMemberDeclarator(AnonymousObjectMemberDeclaratorSyntax node)
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
					case SyntaxKind.SimpleAssignmentExpression:
						{
							AssignmentExpressionSyntax _expr = (AssignmentExpressionSyntax)asNode;
							Visit(_expr.Left);

							VisitLeadingTrivia(_expr.OperatorToken);
							JSSB.Append(':');
							VisitTrailingTrivia(_expr.OperatorToken);

							Visit(_expr.Right);
							break;
						}
					case SyntaxKind.NameEquals:
						VisitNameEquals((NameEqualsSyntax)asNode);
						break;
					case SyntaxKind.UnaryPlusExpression:
					case SyntaxKind.UnaryMinusExpression:
					case SyntaxKind.BitwiseNotExpression:
					case SyntaxKind.LogicalNotExpression:
					case SyntaxKind.PreIncrementExpression:
					case SyntaxKind.PreDecrementExpression:
					case SyntaxKind.AddressOfExpression:
					case SyntaxKind.PointerIndirectionExpression:
					case SyntaxKind.IndexExpression:
						VisitPrefixUnaryExpression((PrefixUnaryExpressionSyntax)asNode);
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
					case SyntaxKind.IdentifierName:
						VisitIdentifierName((IdentifierNameSyntax)asNode);
						break;
					case SyntaxKind.AnonymousObjectCreationExpression:
						VisitAnonymousObjectCreationExpression((AnonymousObjectCreationExpressionSyntax)asNode);
						break;
					case SyntaxKind.AddExpression:
					case SyntaxKind.SubtractExpression:
					case SyntaxKind.MultiplyExpression:
					case SyntaxKind.DivideExpression:
					case SyntaxKind.ModuloExpression:
					case SyntaxKind.LeftShiftExpression:
					case SyntaxKind.RightShiftExpression:
					case SyntaxKind.UnsignedRightShiftExpression:
					case SyntaxKind.LogicalOrExpression:
					case SyntaxKind.LogicalAndExpression:
					case SyntaxKind.BitwiseOrExpression:
					case SyntaxKind.BitwiseAndExpression:
					case SyntaxKind.ExclusiveOrExpression:
					case SyntaxKind.EqualsExpression:
					case SyntaxKind.NotEqualsExpression:
					case SyntaxKind.LessThanExpression:
					case SyntaxKind.LessThanOrEqualExpression:
					case SyntaxKind.GreaterThanExpression:
					case SyntaxKind.GreaterThanOrEqualExpression:
					case SyntaxKind.IsExpression:
					case SyntaxKind.AsExpression:
					case SyntaxKind.CoalesceExpression:
						VisitBinaryExpression((BinaryExpressionSyntax)asNode);
						break;
					case SyntaxKind.ObjectCreationExpression:
						VisitObjectCreationExpression((ObjectCreationExpressionSyntax)asNode);
						break;
					case SyntaxKind.InvocationExpression:
						VisitInvocationExpression((InvocationExpressionSyntax)asNode);
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
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}
	public override void VisitAttributeArgument(AttributeArgumentSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitAttributeArgument(node);
	}
	public override void VisitAttributeArgumentList(AttributeArgumentListSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitAttributeArgumentList(node);
	}
	public override void VisitAttributeList(AttributeListSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitAttributeList(node);
	}
	public override void VisitAttributeTargetSpecifier(AttributeTargetSpecifierSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitAttributeTargetSpecifier(node);
	}
	public override void VisitAwaitExpression(AwaitExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitAwaitExpression(node);
	}
	public override void VisitBadDirectiveTrivia(BadDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitBadDirectiveTrivia(node);
	}
	public override void VisitBinaryExpression(BinaryExpressionSyntax node)
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
					case SyntaxKind.ThisExpression:
						VisitThisExpression((ThisExpressionSyntax)asNode);
						break;
					case SyntaxKind.AnonymousObjectCreationExpression:
						VisitAnonymousObjectCreationExpression((AnonymousObjectCreationExpressionSyntax)asNode);
						break;
					case SyntaxKind.TypeOfExpression:
						VisitTypeOfExpression((TypeOfExpressionSyntax)asNode);
						break;
					case SyntaxKind.ObjectCreationExpression:
						VisitObjectCreationExpression((ObjectCreationExpressionSyntax)asNode);
						break;
					case SyntaxKind.CastExpression:
						VisitCastExpression((CastExpressionSyntax)asNode);
						break;
					case SyntaxKind.AwaitExpression:
						VisitAwaitExpression((AwaitExpressionSyntax)asNode);
						break;
					case SyntaxKind.InvocationExpression:
						VisitInvocationExpression((InvocationExpressionSyntax)asNode);
						break;
					case SyntaxKind.ElementAccessExpression:
						VisitElementAccessExpression((ElementAccessExpressionSyntax)asNode);
						break;
					case SyntaxKind.UnaryPlusExpression:
					case SyntaxKind.UnaryMinusExpression:
					case SyntaxKind.BitwiseNotExpression:
					case SyntaxKind.LogicalNotExpression:
					case SyntaxKind.PreIncrementExpression:
					case SyntaxKind.PreDecrementExpression:
					case SyntaxKind.AddressOfExpression:
					case SyntaxKind.PointerIndirectionExpression:
					case SyntaxKind.IndexExpression:
						VisitPrefixUnaryExpression((PrefixUnaryExpressionSyntax)asNode);
						break;
					case SyntaxKind.SimpleMemberAccessExpression:
					case SyntaxKind.PointerMemberAccessExpression:
						VisitMemberAccessExpression((MemberAccessExpressionSyntax)asNode);
						break;
					case SyntaxKind.ParenthesizedExpression:
						VisitParenthesizedExpression((ParenthesizedExpressionSyntax)asNode);
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
					case SyntaxKind.AddExpression:
					case SyntaxKind.SubtractExpression:
					case SyntaxKind.MultiplyExpression:
					case SyntaxKind.DivideExpression:
					case SyntaxKind.ModuloExpression:
					case SyntaxKind.LeftShiftExpression:
					case SyntaxKind.RightShiftExpression:
					case SyntaxKind.UnsignedRightShiftExpression:
					case SyntaxKind.LogicalOrExpression:
					case SyntaxKind.LogicalAndExpression:
					case SyntaxKind.BitwiseOrExpression:
					case SyntaxKind.BitwiseAndExpression:
					case SyntaxKind.ExclusiveOrExpression:
					case SyntaxKind.EqualsExpression:
					case SyntaxKind.NotEqualsExpression:
					case SyntaxKind.LessThanExpression:
					case SyntaxKind.LessThanOrEqualExpression:
					case SyntaxKind.GreaterThanExpression:
					case SyntaxKind.GreaterThanOrEqualExpression:
					case SyntaxKind.IsExpression:
					case SyntaxKind.AsExpression:
					case SyntaxKind.CoalesceExpression:
						VisitBinaryExpression((BinaryExpressionSyntax)asNode);
						break;
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
					case SyntaxKind.IsKeyword:
						{
							VisitLeadingTrivia(asToken);
							JSSB.Append("instanceof");
							VisitTrailingTrivia(asToken);
							break;
						}
					case SyntaxKind.MinusToken:
					case SyntaxKind.SlashToken:
					case SyntaxKind.PercentToken:
					case SyntaxKind.AmpersandAmpersandToken:
					case SyntaxKind.GreaterThanGreaterThanToken:
					case SyntaxKind.BarToken:
					case SyntaxKind.BarBarToken:
					case SyntaxKind.LessThanEqualsToken:
					case SyntaxKind.QuestionQuestionToken:
					case SyntaxKind.GreaterThanGreaterThanGreaterThanToken:
					case SyntaxKind.AsteriskToken:
					case SyntaxKind.PlusToken:
					case SyntaxKind.LessThanLessThanToken:
					case SyntaxKind.GreaterThanToken:
					case SyntaxKind.GreaterThanEqualsToken:
					case SyntaxKind.AmpersandToken:
					case SyntaxKind.CaretToken:
					case SyntaxKind.EqualsEqualsToken:
					case SyntaxKind.ExclamationEqualsToken:
					case SyntaxKind.LessThanToken:
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}
	public override void VisitBinaryPattern(BinaryPatternSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitBinaryPattern(node);
	}
	public override void VisitBracketedArgumentList(BracketedArgumentListSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitBracketedArgumentList(node);
	}
	public override void VisitBracketedParameterList(BracketedParameterListSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitBracketedParameterList(node);
	}
	public override void VisitBreakStatement(BreakStatementSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}

#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitBreakStatement(node);
	}
	public override void VisitCasePatternSwitchLabel(CasePatternSwitchLabelSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitCasePatternSwitchLabel(node);
	}
	public override void VisitCaseSwitchLabel(CaseSwitchLabelSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}

#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitCaseSwitchLabel(node);
	}
	public override void VisitCatchClause(CatchClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitCatchClause(node);
	}
	public override void VisitCatchFilterClause(CatchFilterClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitCatchFilterClause(node);
	}
	public override void VisitCheckedExpression(CheckedExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitCheckedExpression(node);
	}
	public override void VisitCheckedStatement(CheckedStatementSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitCheckedStatement(node);
	}
	public override void VisitClassOrStructConstraint(ClassOrStructConstraintSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitClassOrStructConstraint(node);
	}
	public override void VisitCollectionExpression(CollectionExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitCollectionExpression(node);
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
						{
							_GlobalStatement = true;
							VisitGlobalStatement((GlobalStatementSyntax)asNode);
							_GlobalStatement = false;
							break;
						}
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
						{
							VisitToken(asToken);

							if (_Options.Debug)
							{
								JSSB.Append("/*");
								JSSB.Append(node.ToFullString().Replace("*/", ""));
								JSSB.Append("*/");
							}

							break;
						}
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}
	public override void VisitConditionalAccessExpression(ConditionalAccessExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitConditionalAccessExpression(node);
	}
	public override void VisitConditionalExpression(ConditionalExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitConditionalExpression(node);
	}
	public override void VisitConstantPattern(ConstantPatternSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitConstantPattern(node);
	}
	public override void VisitConstructorConstraint(ConstructorConstraintSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitConstructorConstraint(node);
	}
	public override void VisitConstructorInitializer(ConstructorInitializerSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitConstructorInitializer(node);
	}
	public override void VisitContinueStatement(ContinueStatementSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitContinueStatement(node);
	}
	public override void VisitConversionOperatorDeclaration(ConversionOperatorDeclarationSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitConversionOperatorDeclaration(node);
	}
	public override void VisitConversionOperatorMemberCref(ConversionOperatorMemberCrefSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitConversionOperatorMemberCref(node);
	}
	public override void VisitCrefBracketedParameterList(CrefBracketedParameterListSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitCrefBracketedParameterList(node);
	}
	public override void VisitCrefParameter(CrefParameterSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitCrefParameter(node);
	}
	public override void VisitCrefParameterList(CrefParameterListSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitCrefParameterList(node);
	}

	public override void VisitDeclarationExpression(DeclarationExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitDeclarationExpression(node);
	}
	public override void VisitDeclarationPattern(DeclarationPatternSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitDeclarationPattern(node);
	}
	public override void VisitDefaultConstraint(DefaultConstraintSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitDefaultConstraint(node);
	}
	public override void VisitDefaultExpression(DefaultExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitDefaultExpression(node);
	}
	public override void VisitDefaultSwitchLabel(DefaultSwitchLabelSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}

#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitDefaultSwitchLabel(node);
	}
	public override void VisitDefineDirectiveTrivia(DefineDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitDefineDirectiveTrivia(node);
	}

	public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitDelegateDeclaration(node);
	}
	public override void VisitDestructorDeclaration(DestructorDeclarationSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitDestructorDeclaration(node);
	}
	public override void VisitDiscardDesignation(DiscardDesignationSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitDiscardDesignation(node);
	}
	public override void VisitDiscardPattern(DiscardPatternSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitDiscardPattern(node);
	}
	public override void VisitDocumentationCommentTrivia(DocumentationCommentTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitDocumentationCommentTrivia(node);
	}
	public override void VisitDoStatement(DoStatementSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitDoStatement(node);
	}
	public override void VisitElementAccessExpression(ElementAccessExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitElementAccessExpression(node);
	}
	public override void VisitElementBindingExpression(ElementBindingExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitElementBindingExpression(node);
	}
	public override void VisitElifDirectiveTrivia(ElifDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitElifDirectiveTrivia(node);
	}
	public override void VisitElseClause(ElseClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitElseClause(node);
	}
	public override void VisitElseDirectiveTrivia(ElseDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitElseDirectiveTrivia(node);
	}
	public override void VisitEmptyStatement(EmptyStatementSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitEmptyStatement(node);
	}
	public override void VisitEndIfDirectiveTrivia(EndIfDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitEndIfDirectiveTrivia(node);
	}
	public override void VisitEndRegionDirectiveTrivia(EndRegionDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitEndRegionDirectiveTrivia(node);
	}
	public override void VisitEqualsValueClause(EqualsValueClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitEqualsValueClause(node);
	}
	public override void VisitErrorDirectiveTrivia(ErrorDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitErrorDirectiveTrivia(node);
	}
	public override void VisitEventDeclaration(EventDeclarationSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitEventDeclaration(node);
	}
	public override void VisitEventFieldDeclaration(EventFieldDeclarationSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitEventFieldDeclaration(node);
	}

	public override void VisitExplicitInterfaceSpecifier(ExplicitInterfaceSpecifierSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitExplicitInterfaceSpecifier(node);
	}
	public override void VisitExpressionColon(ExpressionColonSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitExpressionColon(node);
	}
	public override void VisitExpressionElement(ExpressionElementSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitExpressionElement(node);
	}
	public override void VisitExternAliasDirective(ExternAliasDirectiveSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitExternAliasDirective(node);
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
						{
#if DEBUG
							Log.WarningLine($"\"{kind}\" not implemented or unlikely to be implemented. Ignoring! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{asNode.ToFullString()}|");
#endif
							break;
						}
					case SyntaxKind.QualifiedName:
					case SyntaxKind.IdentifierName:
						{
							_NameSpaceStr = node.Name.ToString();
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
	public override void VisitFinallyClause(FinallyClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitFinallyClause(node);
	}
	public override void VisitFixedStatement(FixedStatementSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitFixedStatement(node);
	}
	public override void VisitForEachVariableStatement(ForEachVariableStatementSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}

		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.ThisExpression:
						VisitThisExpression((ThisExpressionSyntax)asNode);
						break;
					case SyntaxKind.ExpressionStatement:
						VisitExpressionStatement((ExpressionStatementSyntax)asNode);
						break;
					case SyntaxKind.Block:
						VisitBlock((BlockSyntax)asNode);
						break;
					case SyntaxKind.GenericName:
					case SyntaxKind.PredefinedType:
						{
							SyntaxTriviaList _syntaxTrivias = asNode.GetLeadingTrivia();

							for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
							{
								VisitTrivia(_syntaxTrivias[_i]);
							}

							if (_Options.UseVarOverLet)
								JSSB.Append("var");
							else
								JSSB.Append("let");

							_syntaxTrivias = asNode.GetTrailingTrivia();
							for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
							{
								VisitTrivia(_syntaxTrivias[_i]);
							}
							break;
						}
					case SyntaxKind.IdentifierName:
						{
							IdentifierNameSyntax? _ins = asNode as IdentifierNameSyntax;
							if (_ins != null)
							{
								if (_ins.IsVar)
								{
									SyntaxTriviaList _syntaxTrivias = asNode.GetLeadingTrivia();

									for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
									{
										VisitTrivia(_syntaxTrivias[_i]);
									}

									if (_Options.UseVarOverLet)
										JSSB.Append("var");
									else
										JSSB.Append("let");

									_syntaxTrivias = asNode.GetTrailingTrivia();
									for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
									{
										VisitTrivia(_syntaxTrivias[_i]);
									}
								}
								else
								{
									if (IdentifierToken(asNode) == false)
									{
										VisitIdentifierName(_ins);
									}
								}
							}
							else
							{
								Log.ErrorLine($"_ins is null");
							}

							break;
						}
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
	public override void VisitForStatement(ForStatementSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}

#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitForStatement(node);
	}
	public override void VisitFromClause(FromClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitFromClause(node);
	}
	public override void VisitFunctionPointerCallingConvention(FunctionPointerCallingConventionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitFunctionPointerCallingConvention(node);
	}
	public override void VisitFunctionPointerParameter(FunctionPointerParameterSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitFunctionPointerParameter(node);
	}
	public override void VisitFunctionPointerParameterList(FunctionPointerParameterListSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitFunctionPointerParameterList(node);
	}
	public override void VisitFunctionPointerType(FunctionPointerTypeSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitFunctionPointerType(node);
	}
	public override void VisitFunctionPointerUnmanagedCallingConvention(FunctionPointerUnmanagedCallingConventionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitFunctionPointerUnmanagedCallingConvention(node);
	}
	public override void VisitFunctionPointerUnmanagedCallingConventionList(FunctionPointerUnmanagedCallingConventionListSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitFunctionPointerUnmanagedCallingConventionList(node);
	}
	public override void VisitGlobalStatement(GlobalStatementSyntax node)
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
					case SyntaxKind.LocalFunctionStatement:
						VisitLocalFunctionStatement((LocalFunctionStatementSyntax)asNode);
						break;
					case SyntaxKind.ExpressionStatement:
						VisitExpressionStatement((ExpressionStatementSyntax)asNode);
						break;
					case SyntaxKind.LocalDeclarationStatement:
						VisitLocalDeclarationStatement((LocalDeclarationStatementSyntax)asNode);
						break;
					case SyntaxKind.TryStatement:
						VisitTryStatement((TryStatementSyntax)asNode);
						break;
					case SyntaxKind.IfStatement:
						VisitIfStatement((IfStatementSyntax)asNode);
						break;
					case SyntaxKind.ForStatement:
						VisitForStatement((ForStatementSyntax)asNode);
						break;
					case SyntaxKind.ReturnStatement:
						VisitReturnStatement((ReturnStatementSyntax)asNode);
						break;
					case SyntaxKind.LabeledStatement:
						VisitLabeledStatement((LabeledStatementSyntax)asNode);
						break;
					case SyntaxKind.Block:
						VisitBlock((BlockSyntax)asNode);
						break;
					case SyntaxKind.WhileStatement:
						VisitWhileStatement((WhileStatementSyntax)asNode);
						break;
					case SyntaxKind.DoStatement:
						VisitDoStatement((DoStatementSyntax)asNode);
						break;
					case SyntaxKind.EmptyStatement:
						VisitEmptyStatement((EmptyStatementSyntax)asNode);
						break;
					case SyntaxKind.ThrowStatement:
						VisitThrowStatement((ThrowStatementSyntax)asNode);
						break;
					case SyntaxKind.ContinueStatement:
						VisitContinueStatement((ContinueStatementSyntax)asNode);
						break;
					case SyntaxKind.ForEachStatement:
						VisitForEachStatement((ForEachStatementSyntax)asNode);
						break;
					case SyntaxKind.BreakStatement:
						VisitBreakStatement((BreakStatementSyntax)asNode);
						break;
					case SyntaxKind.ForEachVariableStatement:
						VisitForEachVariableStatement((ForEachVariableStatementSyntax)asNode);
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
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}
	public override void VisitGotoStatement(GotoStatementSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitGotoStatement(node);
	}
	public override void VisitGroupClause(GroupClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitGroupClause(node);
	}
	public override void VisitIfDirectiveTrivia(IfDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitIfDirectiveTrivia(node);
	}
	public override void VisitIfStatement(IfStatementSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}

		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.BreakStatement:
						VisitBreakStatement((BreakStatementSyntax)asNode);
						break;
					case SyntaxKind.ReturnStatement:
						VisitReturnStatement((ReturnStatementSyntax)asNode);
						break;
					case SyntaxKind.IdentifierName:
						VisitIdentifierName((IdentifierNameSyntax)asNode);
						break;
					case SyntaxKind.InvocationExpression:
						VisitInvocationExpression((InvocationExpressionSyntax)asNode);
						break;
					case SyntaxKind.ContinueStatement:
						VisitContinueStatement((ContinueStatementSyntax)asNode);
						break;
					case SyntaxKind.Block:
						VisitBlock((BlockSyntax)asNode);
						break;
					case SyntaxKind.ElseClause:
						VisitElseClause((ElseClauseSyntax)asNode);
						break;
					case SyntaxKind.ExpressionStatement:
						VisitExpressionStatement((ExpressionStatementSyntax)asNode);
						break;
					case SyntaxKind.LogicalNotExpression:
						VisitPrefixUnaryExpression((PrefixUnaryExpressionSyntax)asNode);
						break;
					case SyntaxKind.AddExpression:
					case SyntaxKind.SubtractExpression:
					case SyntaxKind.MultiplyExpression:
					case SyntaxKind.DivideExpression:
					case SyntaxKind.ModuloExpression:
					case SyntaxKind.LeftShiftExpression:
					case SyntaxKind.RightShiftExpression:
					case SyntaxKind.UnsignedRightShiftExpression:
					case SyntaxKind.LogicalOrExpression:
					case SyntaxKind.LogicalAndExpression:
					case SyntaxKind.BitwiseOrExpression:
					case SyntaxKind.BitwiseAndExpression:
					case SyntaxKind.ExclusiveOrExpression:
					case SyntaxKind.EqualsExpression:
					case SyntaxKind.NotEqualsExpression:
					case SyntaxKind.LessThanExpression:
					case SyntaxKind.LessThanOrEqualExpression:
					case SyntaxKind.GreaterThanExpression:
					case SyntaxKind.GreaterThanOrEqualExpression:
					case SyntaxKind.IsExpression:
					case SyntaxKind.AsExpression:
					case SyntaxKind.CoalesceExpression:
						VisitBinaryExpression((BinaryExpressionSyntax)asNode);
						break;
					case SyntaxKind.ElementAccessExpression:
						VisitElementAccessExpression((ElementAccessExpressionSyntax)asNode);
						break;
					case SyntaxKind.ParenthesizedExpression:
						VisitParenthesizedExpression((ParenthesizedExpressionSyntax)asNode);
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
					case SyntaxKind.CloseParenToken:
					case SyntaxKind.OpenParenToken:
					case SyntaxKind.IfKeyword:
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}
	public override void VisitImplicitArrayCreationExpression(ImplicitArrayCreationExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitImplicitArrayCreationExpression(node);
	}
	public override void VisitImplicitElementAccess(ImplicitElementAccessSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitImplicitElementAccess(node);
	}
	public override void VisitImplicitStackAllocArrayCreationExpression(ImplicitStackAllocArrayCreationExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitImplicitStackAllocArrayCreationExpression(node);
	}
	public override void VisitIncompleteMember(IncompleteMemberSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitIncompleteMember(node);
	}
	public override void VisitIndexerDeclaration(IndexerDeclarationSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitIndexerDeclaration(node);
	}
	public override void VisitIndexerMemberCref(IndexerMemberCrefSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitIndexerMemberCref(node);
	}
	public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitInterfaceDeclaration(node);
	}
	public override void VisitInterpolatedStringText(InterpolatedStringTextSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitInterpolatedStringText(node);
	}
	public override void VisitInterpolation(InterpolationSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitInterpolation(node);
	}
	public override void VisitInterpolationAlignmentClause(InterpolationAlignmentClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitInterpolationAlignmentClause(node);
	}
	public override void VisitInterpolationFormatClause(InterpolationFormatClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitInterpolationFormatClause(node);
	}
	public override void VisitInvocationExpression(InvocationExpressionSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}
		
		ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

		for (int i = 0; i < nodesAndTokens.Count; i++)
		{
			SyntaxNode? asNode = nodesAndTokens[i].AsNode();

			if (asNode != null)
			{
				SyntaxKind kind = asNode.Kind();

				switch (kind)
				{
					case SyntaxKind.GenericName:
							VisitGenericName((GenericNameSyntax)asNode);
							break;
					case SyntaxKind.IdentifierName:
							VisitIdentifierName((IdentifierNameSyntax)asNode);
							break;
					case SyntaxKind.ArgumentList:
						{
							ArgumentListSyntax _arguments = (ArgumentListSyntax)asNode;
							if (_AttributeDatasForInvocation[0] != string.Empty)
							{
								if (_AttributeDatasForInvocation[0] == nameof(BinaryAttribute))
								{
									_AttributeDatasForInvocation[0] = string.Empty;
									string _operator = _AttributeDatasForInvocation[1];

									VisitArgument(_arguments.Arguments[0]);

									if (!_arguments.Arguments[0].HasTrailingTrivia)
										JSSB.Append(' ');
									
									JSSB.Append(_operator);
									VisitTrailingTrivia(_arguments.Arguments.GetSeparator(0));
									VisitArgument(_arguments.Arguments[1]);
									
									SyntaxTriviaList _syntaxTrivias = _arguments.GetTrailingTrivia();
									for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
									{
										VisitTrivia(_syntaxTrivias[_i]);
									}
									
									goto BreakArgumentList;
								}

								if (_AttributeDatasForInvocation[0] == nameof(UnaryAttribute))
								{
									_AttributeDatasForInvocation[0] = string.Empty;
									string _operator = _AttributeDatasForInvocation[1];
									
									JSSB.Append(_operator);
									VisitArgument(_arguments.Arguments[0]);
									
									goto BreakArgumentList;
								}
							}

							VisitArgumentList(_arguments);
							
						BreakArgumentList:
							break;
						}
					case SyntaxKind.ElementAccessExpression:
						VisitElementAccessExpression((ElementAccessExpressionSyntax)asNode);
						break;
					case SyntaxKind.SimpleMemberAccessExpression:
					case SyntaxKind.PointerMemberAccessExpression:
						VisitMemberAccessExpression((MemberAccessExpressionSyntax)asNode);
						break;
					case SyntaxKind.TypeOfExpression:
						VisitTypeOfExpression((TypeOfExpressionSyntax)asNode);
						break;
					case SyntaxKind.ParenthesizedExpression:
						VisitParenthesizedExpression((ParenthesizedExpressionSyntax)asNode);
						break;
					case SyntaxKind.ParenthesizedLambdaExpression:
						VisitParenthesizedLambdaExpression((ParenthesizedLambdaExpressionSyntax)asNode);
						break;
					case SyntaxKind.ObjectCreationExpression:
						VisitObjectCreationExpression((ObjectCreationExpressionSyntax)asNode);
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
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}
	public override void VisitIsPatternExpression(IsPatternExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitIsPatternExpression(node);
	}
	public override void VisitJoinClause(JoinClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitJoinClause(node);
	}
	public override void VisitJoinIntoClause(JoinIntoClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitJoinIntoClause(node);
	}
	public override void VisitLabeledStatement(LabeledStatementSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitLabeledStatement(node);
	}
	public override void VisitLetClause(LetClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitLetClause(node);
	}
	public override void VisitLineDirectivePosition(LineDirectivePositionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitLineDirectivePosition(node);
	}
	public override void VisitLineDirectiveTrivia(LineDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitLineDirectiveTrivia(node);
	}
	public override void VisitLineSpanDirectiveTrivia(LineSpanDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitLineSpanDirectiveTrivia(node);
	}
	public override void VisitListPattern(ListPatternSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitListPattern(node);
	}
	public override void VisitLoadDirectiveTrivia(LoadDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitLoadDirectiveTrivia(node);
	}
	public override void VisitLocalFunctionStatement(LocalFunctionStatementSyntax node)
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
					case SyntaxKind.Block:
						VisitBlock((BlockSyntax)asNode);
						break;
					case SyntaxKind.ParameterList:
						VisitParameterList((ParameterListSyntax)asNode);
						break;
					case SyntaxKind.IdentifierName:
					case SyntaxKind.PredefinedType:
						{
							SyntaxTriviaList _syntaxTrivias = asNode.GetLeadingTrivia();
							for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
							{
								VisitTrivia(_syntaxTrivias[_i]);
							}

							JSSB.Append("function");

							_syntaxTrivias = asNode.GetTrailingTrivia();
							for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
							{
								VisitTrivia(_syntaxTrivias[_i]);
							}
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
					case SyntaxKind.IdentifierToken:
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}
	public override void VisitLockStatement(LockStatementSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitLockStatement(node);
	}
	public override void VisitMakeRefExpression(MakeRefExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitMakeRefExpression(node);
	}
	public override void VisitMemberBindingExpression(MemberBindingExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitMemberBindingExpression(node);
	}
	public override void VisitNameColon(NameColonSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitNameColon(node);
	}
	public override void VisitNameMemberCref(NameMemberCrefSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitNameMemberCref(node);
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
						{
#if DEBUG
							Log.WarningLine($"\"{kind}\" not implemented or unlikely to be implemented. Ignoring! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{asNode.ToFullString()}|");
#endif
							break;
						}
					case SyntaxKind.QualifiedName:
					case SyntaxKind.IdentifierName:
					{
						_NameSpaceStr = node.Name.ToString();
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
	public override void VisitNullableDirectiveTrivia(NullableDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitNullableDirectiveTrivia(node);
	}
	public override void VisitNullableType(NullableTypeSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitNullableType(node);
	}
	public override void VisitOmittedArraySizeExpression(OmittedArraySizeExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitOmittedArraySizeExpression(node);
	}
	public override void VisitOmittedTypeArgument(OmittedTypeArgumentSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitOmittedTypeArgument(node);
	}
	public override void VisitOperatorDeclaration(OperatorDeclarationSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitOperatorDeclaration(node);
	}

	public override void VisitOperatorMemberCref(OperatorMemberCrefSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitOperatorMemberCref(node);
	}
	public override void VisitOrderByClause(OrderByClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitOrderByClause(node);
	}
	public override void VisitOrdering(OrderingSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitOrdering(node);
	}
	public override void VisitParameterList(ParameterListSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitParameterList(node);
	}
	public override void VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitParenthesizedLambdaExpression(node);
	}
	public override void VisitParenthesizedPattern(ParenthesizedPatternSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitParenthesizedPattern(node);
	}
	public override void VisitParenthesizedVariableDesignation(ParenthesizedVariableDesignationSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitParenthesizedVariableDesignation(node);
	}
	public override void VisitPointerType(PointerTypeSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitPointerType(node);
	}
	public override void VisitPositionalPatternClause(PositionalPatternClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitPositionalPatternClause(node);
	}
	public override void VisitPostfixUnaryExpression(PostfixUnaryExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitPostfixUnaryExpression(node);
	}
	public override void VisitPragmaChecksumDirectiveTrivia(PragmaChecksumDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitPragmaChecksumDirectiveTrivia(node);
	}
	public override void VisitPragmaWarningDirectiveTrivia(PragmaWarningDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitPragmaWarningDirectiveTrivia(node);
	}
	public override void VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitPrefixUnaryExpression(node);
	}
	public override void VisitPrimaryConstructorBaseType(PrimaryConstructorBaseTypeSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitPrimaryConstructorBaseType(node);
	}
	public override void VisitPropertyPatternClause(PropertyPatternClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitPropertyPatternClause(node);
	}
	public override void VisitQualifiedCref(QualifiedCrefSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitQualifiedCref(node);
	}
	public override void VisitQualifiedName(QualifiedNameSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitQualifiedName(node);
	}
	public override void VisitQueryBody(QueryBodySyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitQueryBody(node);
	}
	public override void VisitQueryContinuation(QueryContinuationSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitQueryContinuation(node);
	}
	public override void VisitQueryExpression(QueryExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitQueryExpression(node);
	}
	public override void VisitRangeExpression(RangeExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitRangeExpression(node);
	}
	public override void VisitRecordDeclaration(RecordDeclarationSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitRecordDeclaration(node);
	}
	public override void VisitRecursivePattern(RecursivePatternSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitRecursivePattern(node);
	}
	public override void VisitReferenceDirectiveTrivia(ReferenceDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitReferenceDirectiveTrivia(node);
	}
	public override void VisitRefExpression(RefExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitRefExpression(node);
	}
	public override void VisitRefStructConstraint(RefStructConstraintSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitRefStructConstraint(node);
	}
	public override void VisitRefType(RefTypeSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitRefType(node);
	}
	public override void VisitRefTypeExpression(RefTypeExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitRefTypeExpression(node);
	}
	public override void VisitRefValueExpression(RefValueExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitRefValueExpression(node);
	}
	public override void VisitRegionDirectiveTrivia(RegionDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitRegionDirectiveTrivia(node);
	}
	public override void VisitRelationalPattern(RelationalPatternSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitRelationalPattern(node);
	}
	public override void VisitReturnStatement(ReturnStatementSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}

#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitReturnStatement(node);
	}
	public override void VisitScopedType(ScopedTypeSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitScopedType(node);
	}
	public override void VisitSelectClause(SelectClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitSelectClause(node);
	}
	public override void VisitShebangDirectiveTrivia(ShebangDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitShebangDirectiveTrivia(node);
	}
	public override void VisitSimpleBaseType(SimpleBaseTypeSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitSimpleBaseType(node);
	}
	public override void VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitSimpleLambdaExpression(node);
	}
	public override void VisitSingleVariableDesignation(SingleVariableDesignationSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitSingleVariableDesignation(node);
	}
	public override void VisitSizeOfExpression(SizeOfExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitSizeOfExpression(node);
	}
	public override void VisitSkippedTokensTrivia(SkippedTokensTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitSkippedTokensTrivia(node);
	}
	public override void VisitSlicePattern(SlicePatternSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitSlicePattern(node);
	}
	public override void VisitSpreadElement(SpreadElementSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitSpreadElement(node);
	}
	public override void VisitStackAllocArrayCreationExpression(StackAllocArrayCreationExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitStackAllocArrayCreationExpression(node);
	}
	public override void VisitStructDeclaration(StructDeclarationSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitStructDeclaration(node);
	}
	public override void VisitSubpattern(SubpatternSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitSubpattern(node);
	}
	public override void VisitSwitchExpression(SwitchExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitSwitchExpression(node);
	}
	public override void VisitSwitchExpressionArm(SwitchExpressionArmSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitSwitchExpressionArm(node);
	}
	public override void VisitSwitchSection(SwitchSectionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitSwitchSection(node);
	}
	public override void VisitSwitchStatement(SwitchStatementSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}

#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitSwitchStatement(node);
	}
	public override void VisitThrowExpression(ThrowExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitThrowExpression(node);
	}
	public override void VisitThrowStatement(ThrowStatementSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitThrowStatement(node);
	}
	public override void VisitTryStatement(TryStatementSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitTryStatement(node);
	}
	public override void VisitTupleElement(TupleElementSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitTupleElement(node);
	}
	public override void VisitTupleExpression(TupleExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitTupleExpression(node);
	}
	public override void VisitTupleType(TupleTypeSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitTupleType(node);
	}
	public override void VisitTypeConstraint(TypeConstraintSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitTypeConstraint(node);
	}
	public override void VisitTypeCref(TypeCrefSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitTypeCref(node);
	}
	public override void VisitTypeOfExpression(TypeOfExpressionSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}

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
					case SyntaxKind.OpenParenToken:
					case SyntaxKind.CloseParenToken:
					case SyntaxKind.TypeOfKeyword:
						VisitToken(asToken);
						break;
					default:
						Log.ErrorLine($"asToken : {kind}");
						break;
				}
			}
		}
	}
	public override void VisitTypeParameter(TypeParameterSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitTypeParameter(node);
	}
	public override void VisitTypeParameterConstraintClause(TypeParameterConstraintClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitTypeParameterConstraintClause(node);
	}
	public override void VisitTypeParameterList(TypeParameterListSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitTypeParameterList(node);
	}
	public override void VisitTypePattern(TypePatternSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitTypePattern(node);
	}
	public override void VisitUnaryPattern(UnaryPatternSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitUnaryPattern(node);
	}
	public override void VisitUndefDirectiveTrivia(UndefDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitUndefDirectiveTrivia(node);
	}
	public override void VisitUnsafeStatement(UnsafeStatementSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitUnsafeStatement(node);
	}
	public override void VisitUsingDirective(UsingDirectiveSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitUsingDirective(node);
	}
	public override void VisitUsingStatement(UsingStatementSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitUsingStatement(node);
	}
	public override void VisitVarPattern(VarPatternSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitVarPattern(node);
	}
	public override void VisitWarningDirectiveTrivia(WarningDirectiveTriviaSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitWarningDirectiveTrivia(node);
	}
	public override void VisitWhenClause(WhenClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitWhenClause(node);
	}
	public override void VisitWhereClause(WhereClauseSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitWhereClause(node);
	}
	public override void VisitWhileStatement(WhileStatementSyntax node)
	{
		if (_Options.Debug)
		{
			JSSB.Append("/*");
			string[] strings = node.ToFullString().Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);
			JSSB.Append(string.IsNullOrWhiteSpace(strings[0]) ? strings[1] : strings[0]);
			JSSB.AppendLine("*/");
		}

#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitWhileStatement(node);
	}
	public override void VisitWithExpression(WithExpressionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitWithExpression(node);
	}
	public override void VisitXmlCDataSection(XmlCDataSectionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitXmlCDataSection(node);
	}
	public override void VisitXmlComment(XmlCommentSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitXmlComment(node);
	}
	public override void VisitXmlCrefAttribute(XmlCrefAttributeSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitXmlCrefAttribute(node);
	}
	public override void VisitXmlElement(XmlElementSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitXmlElement(node);
	}
	public override void VisitXmlElementEndTag(XmlElementEndTagSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitXmlElementEndTag(node);
	}
	public override void VisitXmlElementStartTag(XmlElementStartTagSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitXmlElementStartTag(node);
	}
	public override void VisitXmlEmptyElement(XmlEmptyElementSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitXmlEmptyElement(node);
	}

	public override void VisitXmlName(XmlNameSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitXmlName(node);
	}
	public override void VisitXmlNameAttribute(XmlNameAttributeSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitXmlNameAttribute(node);
	}
	public override void VisitXmlPrefix(XmlPrefixSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitXmlPrefix(node);
	}
	public override void VisitXmlProcessingInstruction(XmlProcessingInstructionSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitXmlProcessingInstruction(node);
	}
	public override void VisitXmlText(XmlTextSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitXmlText(node);
	}
	public override void VisitXmlTextAttribute(XmlTextAttributeSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitXmlTextAttribute(node);
	}
	public override void VisitYieldStatement(YieldStatementSyntax node)
	{
#if DEBUG
		Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! (FullSpan: {node.FullSpan}|Location{node.GetLocation().GetLineSpan()})\n|{node.ToFullString()}|");
#endif
		base.VisitYieldStatement(node);
	}



	public bool IdentifierToken(SyntaxNode node) 
	{
		string text = string.Empty;
		SyntaxToken identifier = new();

		if (node is IdentifierNameSyntax ins) 
		{
			text = ins.Identifier.Text;
			identifier = ins.Identifier;
		}

		if (node is GenericNameSyntax gns)
		{
			text = gns.Identifier.Text;
			identifier = gns.Identifier;
		}

		SymbolInfo? symbolInfo = null;
		if (_SNOriginalAsExpression != null)
		{
			IEnumerable<SyntaxNodeOrToken> _identifierNameSyntax = _SNOriginalAsExpression.DescendantNodesAndTokens().Where(e => e.IsToken == true);
			foreach (SyntaxNodeOrToken _item in _identifierNameSyntax)
			{
				SyntaxToken _syntaxToken = _item.AsToken();

				if (_syntaxToken.IsKind(SyntaxKind.IdentifierToken))
				{
					if (_syntaxToken.Text == text)
					{
						if (_item.Parent != null)
							symbolInfo = _Model.GetSymbolInfo(_item.Parent);
						else
							Log.ErrorLine("_item.Parent is null");
						break;
					}
				}
			}
			node = _SNOriginalAsExpression;
		}
		else
		{
			try
			{
				if (_SNPropertyType != null)
					symbolInfo = _Model.GetSymbolInfo(_SNPropertyType);
				else
					symbolInfo = _Model.GetSymbolInfo(node);
			}
			catch (Exception e)
			{
				symbolInfo = null;
				/*
				ImmutableArray<Diagnostic> diags = _Model.GetDeclarationDiagnostics();
				foreach (Diagnostic item in diags)
				{
					Log.WarningLine(item.ToString());
				}
				*/
				Log.WarningLine(e.ToString());
				//throw;
			}
		}

		ISymbol? iSymbol = null;

		if (symbolInfo?.CandidateSymbols.Length >= 1)
			iSymbol = symbolInfo?.CandidateSymbols[0];
		else
			iSymbol = symbolInfo?.Symbol;

		if (iSymbol != null && 
			iSymbol.Kind != SymbolKind.ErrorType && 
			iSymbol.Kind != SymbolKind.DynamicType && 
			iSymbol.Kind != SymbolKind.Namespace)
		{
			string? _containingNamespace = iSymbol.ContainingNamespace.ToString();
			if (_containingNamespace == null)
			{
				Log.ErrorLine("_containingNamespace is null");
				_containingNamespace = string.Empty;
			}

			if (_containingNamespace.Contains(_NameSpaceStr) && !_GlobalStatement)
			{
				if (iSymbol.Kind == SymbolKind.Parameter ||
					iSymbol.Kind == SymbolKind.Local)
				{
					return false;
				}

				ClassDeclarationSyntax? _class = node.Ancestors().FirstOrDefault(n => n.IsKind(SyntaxKind.ClassDeclaration)) as ClassDeclarationSyntax;

				if (_class == null)
				{
					//TODO?
					//Hitting with "TestPropertiesDefaultValue" + "CustomClass()" + "new CustomClass()"
					Log.WarningLine("_class is null");
					return false;
				}
				//This is for struct.
				//maybe later convert struct to class?
				//
				if (_class == default(ClassDeclarationSyntax)) 
				{
					Log.WarningLine("_class is default");
					return false;
				}

				SyntaxList<MemberDeclarationSyntax> _members = _class.Members;

				for (int i = 0; i < _members.Count; i++)
				{
					SyntaxToken _sT = default;
					if (_members[i] is MethodDeclarationSyntax m)
					{
						_sT = m.Identifier;
					}

					if (_members[i] is PropertyDeclarationSyntax p)
					{
						_sT = p.Identifier;
					}

					if (_members[i] is FieldDeclarationSyntax f)
					{
						IEnumerable<SyntaxNode> vds = (from el in f.DescendantNodes()
													   where el.IsKind(SyntaxKind.VariableDeclarator)
													   select el);

						IEnumerable<SyntaxNodeOrToken> d3 = from e in vds.First().DescendantNodesAndTokens()
															where e.IsKind(SyntaxKind.IdentifierToken)
															select e;

						_sT = (SyntaxToken)d3.First();
					}

					if (_sT.ToString() == node.ToString())
					{
						if (node.Parent != null &&
							node.Parent.Parent != null &&
							!node.Parent.DescendantNodes().Any((e) => e.IsKind(SyntaxKind.ThisExpression)))
						{
							if (node.Parent is MemberAccessExpressionSyntax member)
							{
								ISymbol? _iSymbolParent = _Model.GetSymbolInfo(member.Expression).Symbol;
								if (_iSymbolParent != null && _iSymbolParent.Kind == SymbolKind.Local)
									return false;
							}

							if (_class.Identifier.Text == _CurrentClassStr)
							{
								VisitLeadingTrivia(identifier);

								JSSB.Append($"this.");
								VisitToken(identifier.WithoutTrivia());

								VisitTrailingTrivia(identifier);

								return true;
							}
						}
						else
						{
							Log.WarningLine("node.Parent is null or kind is not ThisExpression");
						}
					}
				}

				return false;
			}
		}

		if (iSymbol != null && iSymbol.ContainingType != null && iSymbol.ContainingType.IsAnonymousType == true)
		{
			if (CustomCSNamesToJS(node) == false)
			{
				VisitLeadingTrivia(identifier);
				JSSB.Append(text);
				VisitTrailingTrivia(identifier);
			}
			return true;
		}

		if (CustomCSNamesToJS(node) == false)
		{
			if (BuiltInTypesGenerics(node, iSymbol) == false)
			{
				return false;
			}
		}

		//
		//
		//Adding trivia after a IdentifierToken.
		if (node is IdentifierNameSyntax _identifierName)
		{
			VisitTrailingTrivia(_identifierName.Identifier);
		}
		else if (node is GenericNameSyntax _genericName)
		{
			VisitTrailingTrivia(_genericName.Identifier);
		}

		return true;
	}

	private bool CustomCSNamesToJS(SyntaxNode? node) 
	{
		if (node is IdentifierNameSyntax _identifierName)
		{
			if (_Options.CustomCSNamesToJS.TryGetValue(_identifierName.Identifier.Text, out string? _value))
			{
				VisitLeadingTrivia(_identifierName.Identifier);
				JSSB.Append(_value);
				return true;
			}
		}
		else if (node is GenericNameSyntax _genericName)
		{
			if (_Options.CustomCSNamesToJS.TryGetValue(_genericName.Identifier.Text, out string? _value))
			{
				VisitLeadingTrivia(_genericName.Identifier);
				JSSB.Append(_value);
				return true;
			}
		}

		return false;
	}

	private bool BuiltInTypesGenerics(SyntaxNode nodeL, ISymbol? symbol) 
	{
		IdentifierNameSyntax? node = nodeL as IdentifierNameSyntax;

		if (symbol == null) 
		{
			Log.WarningLine($"node: \"{node}\", symbol is null. USE \"CustomCSNamesToJS\"!");
			return false;
		}
		if (symbol.Name == "dynamic")
		{
			//Hitting with "AllInOneNoPreprocessor-v6.cs"
			Log.WarningLine($"node: \"{node}\", symbol is \"dynamic\".");
			return false;
		}

		if (nodeL is IdentifierNameSyntax _identifierName)
		{
			VisitLeadingTrivia(_identifierName.Identifier);
		}
		else if (nodeL is GenericNameSyntax _genericName)
		{
			VisitLeadingTrivia(_genericName.Identifier);
		}

		ISymbol typeSymbol = symbol;

		if(typeSymbol.Kind != SymbolKind.NamedType)
		{
			typeSymbol = symbol.ContainingSymbol;

			if(typeSymbol.Kind != SymbolKind.NamedType) 
			{
				Log.WarningLine($"node: \"{node}\", typeSymbol is \"{typeSymbol.Kind}\". USE \"CustomCSNamesToJS\"!");
				return false;
			}
		}

		string typeName = typeSymbol.Name;

		string? jsStr = _NETAPI.ReturnJSString(typeName);
		if (jsStr == null)
		{
			Log.WarningLine($"typeSymbol: \"{typeSymbol}\" Is not supported! USE \"CustomCSNamesToJS\"");
			return false;
		}
		else
		{
			if (typeName == symbol.Name)
			{
				JSSB.Append($"{jsStr}");
				return true;
			}
			jsStr = _NETAPI.ReturnJSString(typeName, symbol.Name);
			if (jsStr == null)
			{
				Log.WarningLine($"node: \"{node}\", typeSymbol: \"{typeSymbol}\", symbol: \"{symbol}\", Is not supported! USE \"CustomCSNamesToJS\"");
				return false;
			}
			else
			{
				JSSB.Append($"{jsStr}");
				return true;
			}
		}
	}
}
