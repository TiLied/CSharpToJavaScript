using CSharpToJavaScript.APIs.JS;
using CSharpToJavaScript.Utils;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;


namespace CSharpToJavaScript;

//Useful links:
//https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/get-started/syntax-analysis
//https://roslynquoter.azurewebsites.net/
//

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

	private int _EnumMembers = 0;


	//Debug
	private int _Line = 0;
	private int _Characters = 0;


	public Walker(CSTOJSOptions options, SemanticModel model) : base(SyntaxWalkerDepth.Trivia)
	{
		_Options = options;
		_Model = model;
	}

	public override void VisitTrivia(SyntaxTrivia trivia)
	{
		SyntaxKind syntaxKind = trivia.Kind();

		switch (syntaxKind)
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
					if (_Options.Debug)
					{
						_Line++;
						_Characters = trivia.FullSpan.Start;
					}
					string _full = trivia.ToFullString();
					JSSB.Append(_full);
					return;
				}
			/* Todo? how? convert to jsdoc?
		case SyntaxKind.SingleLineDocumentationCommentTrivia:
		case SyntaxKind.MultiLineDocumentationCommentTrivia: 
			{
				JSSB.Append("/**");
				string _full = trivia.ToFullString();
				JSSB.Append(_full);
				JSSB.AppendLine("");
				return;
			}*/
			default:
				Log.ErrorLine($"ERROR Trivia : {syntaxKind}", _Options);
				break;
		}

		base.VisitTrivia(trivia);
	}

	public override void VisitToken(SyntaxToken token)
	{
		SyntaxKind syntaxKind = token.Kind();
		
		switch (syntaxKind)
		{
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
			case SyntaxKind.IdentifierToken:
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
				{
					VisitLeadingTrivia(token);

					JSSB.Append(token.Text);

					VisitTrailingTrivia(token);
					return;
				}
			case SyntaxKind.ExclamationEqualsToken:
				{
					VisitLeadingTrivia(token);

					if (_Options.UseStrictEquality)
						JSSB.Append("!==");
					else
						JSSB.Append(token.Text);

					VisitTrailingTrivia(token);
					return;
				}
			case SyntaxKind.EqualsEqualsToken:
				{
					VisitLeadingTrivia(token);

					if(_Options.UseStrictEquality)
						JSSB.Append("===");
					else
						JSSB.Append(token.Text);

					VisitTrailingTrivia(token);
					return;
				}
			case SyntaxKind.EndOfFileToken:
				{
					VisitLeadingTrivia(token);

					JSSB.Append(token.Text);

					VisitTrailingTrivia(token);

					if (_Options.Debug)
					{
						ImmutableArray<Diagnostic> diagnostics = _Model.GetDiagnostics();
						foreach (Diagnostic item in diagnostics)
						{
							Log.WarningLine(item.ToString(), _Options);
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
				Log.ErrorLine($"ERROR Token : {syntaxKind}", _Options);
				break;
		}

		base.VisitToken(token);
	}

	public override void Visit(SyntaxNode? node)
	{
		if (node == null)
		{
			Log.ErrorLine($"Visit node is null", _Options);
			return;
		}
		else
		{

			SyntaxKind syntaxKind = node.Kind();

			switch (syntaxKind)
			{
				case SyntaxKind.UsingDirective:
					return;
				case SyntaxKind.FileScopedNamespaceDeclaration:
					{
						_NameSpaceStr = (node as FileScopedNamespaceDeclarationSyntax).Name.ToString();
						foreach (MemberDeclarationSyntax member in (node as FileScopedNamespaceDeclarationSyntax).Members)
						{
							Visit(member);
						}
						if (_Options.Debug)
						{
							JSSB.Append("/*");
							JSSB.Append(node.ToFullString().Replace("*/", ""));
							JSSB.Append("*/");
						}
						return;
					}
				case SyntaxKind.NamespaceDeclaration:
					{
						_NameSpaceStr = (node as NamespaceDeclarationSyntax).Name.ToString();
						foreach (MemberDeclarationSyntax member in (node as NamespaceDeclarationSyntax).Members)
						{
							Visit(member);
						}
						if (_Options.Debug)
						{
							JSSB.Append("/*");
							JSSB.Append(node.ToFullString().Replace("*/", ""));
							JSSB.Append("*/");
						}
						return;
					}
				default:
					//CSTOJS.Log($"{syntaxKind}");
					break;
			}

			base.Visit(node);
		}
	}

	public override void VisitClassDeclaration(ClassDeclarationSyntax node)
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
						break;
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
						VisitClassDeclaration(asNode as ClassDeclarationSyntax);
						break;
					case SyntaxKind.BaseList:
					case SyntaxKind.FieldDeclaration:
					case SyntaxKind.ConstructorDeclaration:
					case SyntaxKind.MethodDeclaration:
					case SyntaxKind.PropertyDeclaration:
						Visit(asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
						break;
				}
			}
			else
			{
				SyntaxToken asToken = nodesAndTokens[i].AsToken();
				SyntaxKind kind = asToken.Kind();

				switch (kind)
				{
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
						Log.ErrorLine($"asToken : {kind}", _Options);
						break;
				}
			}
		}
	}

	public override void VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
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
						break;
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
					case SyntaxKind.Block:
						Visit(asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
										Visit(asNode);
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
						Log.ErrorLine($"asToken : {kind}", _Options);

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
					case SyntaxKind.EqualsValueClause:
						{
							Visit(asNode);
							break;
						}
					case SyntaxKind.ArrayType:
					case SyntaxKind.NullableType:
					case SyntaxKind.GenericName:
					case SyntaxKind.IdentifierName:
					case SyntaxKind.PredefinedType:
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
						break;
				}
			}
			else
			{
				SyntaxToken asToken = nodesAndTokens[i].AsToken();
				SyntaxKind kind = asToken.Kind();

				switch (kind)
				{
					case SyntaxKind.RefKeyword:
						VisitLeadingTrivia(asToken);
						break;
					case SyntaxKind.IdentifierToken: 
						{
							VisitToken(asToken);
							break;
						}
					default:
						Log.ErrorLine($"asToken : {kind}", _Options);
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
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
					case SyntaxKind.ExpressionStatement: 
						VisitExpressionStatement(asNode as ExpressionStatementSyntax);
						break;
					case SyntaxKind.ForEachStatement: 
						VisitForEachStatement(asNode as ForEachStatementSyntax);
						break;
					case SyntaxKind.LocalDeclarationStatement:
						VisitLocalDeclarationStatement(asNode as LocalDeclarationStatementSyntax);
						break;
					case SyntaxKind.IfStatement:
					case SyntaxKind.TryStatement:
					case SyntaxKind.ThrowStatement:
					case SyntaxKind.DoStatement:
					case SyntaxKind.ReturnStatement:
					case SyntaxKind.ForStatement:
					case SyntaxKind.BreakStatement:
					case SyntaxKind.SwitchStatement:
					case SyntaxKind.ContinueStatement:
					case SyntaxKind.WhileStatement:
						Visit(asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
								Visit((_SNBaseConstructorInitializerNode as ConstructorInitializerSyntax).ArgumentList);
								//Todo!
								//JSSB.Append(";");
								_SNBaseConstructorInitializerNode = null;
							}
							break;
						}
					default:
						Log.ErrorLine($"asToken : {kind}", _Options);
						break;
				}
			}
			
			if (_Options.Debug)
			{
				JSSB.Append("/*");
				JSSB.Append(nodesAndTokens[i].ToFullString().Replace("*/", ""));
				JSSB.Append("*/");
			}
		}
	}

	public override void VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
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
					case SyntaxKind.VariableDeclaration: 
						VisitVariableDeclaration(asNode as VariableDeclarationSyntax);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
						break;
				}
			}
		}
	}

	public override void VisitExpressionStatement(ExpressionStatementSyntax node)
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
					case SyntaxKind.AndAssignmentExpression:
					case SyntaxKind.OrAssignmentExpression:
					case SyntaxKind.ExclusiveOrAssignmentExpression:
					case SyntaxKind.LeftShiftAssignmentExpression:
					case SyntaxKind.RightShiftAssignmentExpression:
					case SyntaxKind.ConditionalAccessExpression:
					case SyntaxKind.PostDecrementExpression:
					case SyntaxKind.InvocationExpression:
					case SyntaxKind.SimpleAssignmentExpression:
					case SyntaxKind.PostIncrementExpression:
					case SyntaxKind.PreDecrementExpression:
					case SyntaxKind.PreIncrementExpression:
					case SyntaxKind.AddAssignmentExpression:
					case SyntaxKind.SubtractAssignmentExpression:
					case SyntaxKind.MultiplyAssignmentExpression:
					case SyntaxKind.DivideAssignmentExpression:
					case SyntaxKind.AwaitExpression:
					case SyntaxKind.ModuloAssignmentExpression:
						Visit(asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
					case SyntaxKind.CharacterLiteralExpression:
					case SyntaxKind.ConditionalExpression:
					case SyntaxKind.UnaryMinusExpression:
					case SyntaxKind.DivideExpression:
					case SyntaxKind.SimpleMemberAccessExpression:
					case SyntaxKind.ElementAccessExpression:
					case SyntaxKind.PostIncrementExpression:
					case SyntaxKind.SimpleLambdaExpression:
					case SyntaxKind.SubtractExpression:
					case SyntaxKind.EqualsExpression:
					case SyntaxKind.AsExpression:
					case SyntaxKind.MultiplyExpression:
					case SyntaxKind.InvocationExpression:
					case SyntaxKind.AddExpression:
					case SyntaxKind.ParenthesizedExpression:
					case SyntaxKind.ThisExpression:
					case SyntaxKind.ParenthesizedLambdaExpression:
					case SyntaxKind.NumericLiteralExpression:
					case SyntaxKind.FalseLiteralExpression:
					case SyntaxKind.TrueLiteralExpression:
					case SyntaxKind.StringLiteralExpression:
					case SyntaxKind.InterpolatedStringExpression:
					case SyntaxKind.AddAssignmentExpression:
					case SyntaxKind.SubtractAssignmentExpression:
					case SyntaxKind.MultiplyAssignmentExpression:
					case SyntaxKind.DivideAssignmentExpression:
					case SyntaxKind.ModuloAssignmentExpression:
						Visit(asNode);
						break;
					case SyntaxKind.ObjectCreationExpression:
						VisitObjectCreationExpression(asNode as ObjectCreationExpressionSyntax);
						break;
					case SyntaxKind.ImplicitObjectCreationExpression:
						VisitImplicitObjectCreationExpression(asNode as ImplicitObjectCreationExpressionSyntax);
						break;
					case SyntaxKind.AnonymousObjectCreationExpression:
						VisitAnonymousObjectCreationExpression(asNode as AnonymousObjectCreationExpressionSyntax);
						break;
					case SyntaxKind.IdentifierName:
						VisitIdentifierName(asNode as IdentifierNameSyntax);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
					case SyntaxKind.ElementAccessExpression:
					case SyntaxKind.SimpleMemberAccessExpression:
					case SyntaxKind.MemberBindingExpression:
						Visit(asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
						Visit(asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						VisitToken(asToken);
						break;
					case SyntaxKind.NewKeyword:
						break;
					default:
						Log.ErrorLine($"asToken : {kind}", _Options);
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
					case SyntaxKind.EnumMemberDeclaration:
						VisitEnumMemberDeclaration(asNode as EnumMemberDeclarationSyntax);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
							VisitLiteralExpression(((asNode as EqualsValueClauseSyntax).Value as LiteralExpressionSyntax));
							break;
						}
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
						VisitIdentifierName(asNode as IdentifierNameSyntax);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						JSSB.Append(':');
						break;
					default:
						Log.ErrorLine($"asToken : {kind}", _Options);
						break;
				}
			}
		}
	}

	public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
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
						break;
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
					case SyntaxKind.IdentifierName:
						VisitIdentifierName((IdentifierNameSyntax)asNode);
						break;
					case SyntaxKind.ParameterList:
					case SyntaxKind.Block:
						Visit(asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
						break;
				}
			}
			else
			{
				SyntaxToken asToken = nodesAndTokens[i].AsToken();
				SyntaxKind kind = asToken.Kind();

				switch (kind)
				{
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
						Log.ErrorLine($"asToken : {kind}", _Options);
						break;
				}
			}
		}
	}

	public override void VisitFieldDeclaration(FieldDeclarationSyntax node)
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
						break;
					case SyntaxKind.VariableDeclaration:
						Visit(asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
						break;
				}
			}
		}
	}

	public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
	{
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
						break;
					case SyntaxKind.AccessorList:
						VisitAccessorList(asNode as AccessorListSyntax);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
						break;
				}
			}
			else
			{
				SyntaxToken asToken = nodesAndTokens[i].AsToken();
				SyntaxKind kind = asToken.Kind();

				switch (kind)
				{
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
							
							dynamic d3 = null;
							if (d2.Count() >= 2) 
							{
								//Delete this? TODO
								d2 = from e in a.First().DescendantNodesAndTokens()
									 where e.IsKind(SyntaxKind.IdentifierName)
									 select e;
								d3 = d2.First().ChildNodesAndTokens().First().AsToken();
							}else
								d3 = d2.First().AsToken();

							if ((asNode as AccessorDeclarationSyntax).Body != null)
							{
								SyntaxTriviaList _syntaxTrivias = asNode.Parent.Parent.GetLeadingTrivia();

								/* Todo! Why there is already "/t/t" in JSSB????
								for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
								{
									VisitTrivia(_syntaxTrivias[_i]);
								}
								*/

								JSSB.Append($"get {d3.Text}()");

								_syntaxTrivias = asNode.GetTrailingTrivia();
								for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
								{
									VisitTrivia(_syntaxTrivias[_i]);
								}

								VisitBlock((asNode as AccessorDeclarationSyntax).Body);
							}
							else 
							{
								//JSSB.Append($"\n");

								SyntaxTriviaList _syntaxTrivias = asNode.Parent.Parent.GetLeadingTrivia();

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

								_syntaxTrivias = asNode.GetTrailingTrivia();
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

							if ((asNode as AccessorDeclarationSyntax).Body != null)
							{
								SyntaxTriviaList _syntaxTrivias = asNode.Parent.Parent.GetLeadingTrivia();

								for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
								{
									VisitTrivia(_syntaxTrivias[_i]);
								}

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

								Visit((asNode as AccessorDeclarationSyntax).Body);
							}
							else
							{
								JSSB.AppendLine();
								SyntaxTriviaList _syntaxTrivias = asNode.Parent.Parent.GetLeadingTrivia();

								for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
								{
									VisitTrivia(_syntaxTrivias[_i]);
								}

								if (_PropertyStatic == true)
								{
									JSSB.Append($"static ");
									JSSB.Append($"set {d3.Text}(value) {{ this._{d3.Text}_ = value; }}");
									_PropertyStatic = false;
								}else
									JSSB.Append($"set {d3.Text}(value) {{ this.#_{d3.Text}_ = value; }}");

								_syntaxTrivias = asNode.Parent.GetTrailingTrivia();
								for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
								{
									VisitTrivia(_syntaxTrivias[_i]);
								}
							}

							break;
						}
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
						Visit(asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
						VisitVariableDeclarator(asNode as VariableDeclaratorSyntax);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
					case SyntaxKind.VariableDeclarator:
						Visit(asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
						Visit(asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
					case SyntaxKind.ExpressionStatement:
						VisitExpressionStatement(asNode as ExpressionStatementSyntax);
						break;
					case SyntaxKind.Block:
						VisitBlock(asNode as BlockSyntax);
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
								Log.ErrorLine($"_ins is null", _Options);
							}

							break;
						}
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
							VisitArrayType(asNode as ArrayTypeSyntax);
							_IgnoreArrayType = false;
							break;
						}
					case SyntaxKind.ArrayInitializerExpression:
						VisitInitializerExpression(asNode as InitializerExpressionSyntax);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
					case SyntaxKind.PredefinedType:
					case SyntaxKind.IdentifierName: 
						JSSB.Append("Array");
						break;
					case SyntaxKind.ArrayRankSpecifier:
						VisitArrayRankSpecifier(asNode as ArrayRankSpecifierSyntax);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
					case SyntaxKind.NumericLiteralExpression:
					case SyntaxKind.DivideExpression:
						Visit(asNode);
						break;
					//Todo?
					case SyntaxKind.OmittedArraySizeExpression:
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
					case SyntaxKind.ArrayInitializerExpression:
					case SyntaxKind.StringLiteralExpression:
					case SyntaxKind.NumericLiteralExpression:
						Visit(asNode);
						break;
					case SyntaxKind.ObjectCreationExpression:
						VisitObjectCreationExpression(asNode as ObjectCreationExpressionSyntax);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);

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
					case SyntaxKind.StringLiteralExpression:
						Visit(asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
								_value.EndsWith('F') ||
								_value.EndsWith('D') ||
								_value.EndsWith('M'))
								_value = _value.Remove(_value.Length - 1);

							if (_value.Length > 10)
							{
								double _d = 0;

								if (_value.Contains("E"))
									_d = double.Parse(_value.Replace('.', ','), System.Globalization.NumberStyles.Float);
								else
									_d = Convert.ToDouble(_value.Replace('.', ','));

								if (_value.StartsWith('-'))
								{
									//TODO? BigInt?
									if (_d <= -9007199254740991)
									{
										Log.WarningLine($"Number: {_d} is smaller then Number.MIN_SAFE_INTEGER(-9007199254740991) clamping!", _Options);
										_value = "Number.MIN_SAFE_INTEGER";
									}
								}
								else
								{
									if (_d >= 9007199254740991)
									{
										Log.WarningLine($"Number: {_d} is larger then Number.MAX_SAFE_INTEGER(9007199254740991) clamping!", _Options);
										_value = "Number.MAX_SAFE_INTEGER";
									}
								}
							}

							JSSB.Append(_value);

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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
						Visit(asNode);
						break;
					case SyntaxKind.Interpolation:
						{
							JSSB.Append('$');
							Visit(asNode);
							break;
						}
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
					case SyntaxKind.UnsignedRightShiftAssignmentExpression:
					case SyntaxKind.RightShiftAssignmentExpression:
					case SyntaxKind.SubtractAssignmentExpression:
					case SyntaxKind.LeftShiftAssignmentExpression:
					case SyntaxKind.AddAssignmentExpression:
					case SyntaxKind.OrAssignmentExpression:
					case SyntaxKind.ExclusiveOrAssignmentExpression:
					case SyntaxKind.CoalesceAssignmentExpression:
					case SyntaxKind.DivideAssignmentExpression:
					case SyntaxKind.MultiplyAssignmentExpression:
					case SyntaxKind.AndAssignmentExpression:
					case SyntaxKind.ModuloAssignmentExpression:
					case SyntaxKind.SimpleMemberAccessExpression:
					case SyntaxKind.ConditionalExpression:
					case SyntaxKind.BitwiseAndExpression:
					case SyntaxKind.SubtractExpression:
					case SyntaxKind.MultiplyExpression:
					case SyntaxKind.CoalesceExpression:
					case SyntaxKind.LogicalOrExpression:
					case SyntaxKind.AddExpression:
					case SyntaxKind.DivideExpression:
					case SyntaxKind.ModuloExpression:
					case SyntaxKind.EqualsExpression:
					case SyntaxKind.GreaterThanExpression:
					case SyntaxKind.LessThanExpression:
					case SyntaxKind.GreaterThanOrEqualExpression:
					case SyntaxKind.LessThanOrEqualExpression:
					case SyntaxKind.NotEqualsExpression:
					case SyntaxKind.SimpleAssignmentExpression:
						Visit(asNode);
						break;
					case SyntaxKind.IdentifierName:
						VisitIdentifierName((IdentifierNameSyntax)asNode);
						break;
					case SyntaxKind.AsExpression:
						{
							//Todo double/multiply asExpression?? How?
							_SNOriginalAsExpression = (asNode as BinaryExpressionSyntax).Left;

							Visit(_SNOriginalAsExpression.WithoutTrailingTrivia());

							_SNOriginalAsExpression = null;
							break;
						}
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
					case SyntaxKind.NullableType:
					case SyntaxKind.PredefinedType:
						break;
					case SyntaxKind.IdentifierName:
					case SyntaxKind.InvocationExpression:
					case SyntaxKind.SimpleMemberAccessExpression:
						Visit(asNode);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
						Visit(asNode); 
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
									Log.WarningLine($"_aes is null", _Options);
									break;
								}

								symbolInfo = _Model.GetSymbolInfo(_aes.Left);

								ClassDeclarationSyntax? classD = node.Ancestors().First(n => n.IsKind(SyntaxKind.ClassDeclaration)) as ClassDeclarationSyntax;

								if (classD == null)
								{
									Log.ErrorLine($"classD is null", _Options);
									break;
								}

								IEnumerable<ClassDeclarationSyntax> classesD = from n in classD.Parent.DescendantNodes()
																			   where n.IsKind(SyntaxKind.ClassDeclaration)
																			   select n as ClassDeclarationSyntax;

								List<MemberDeclarationSyntax> mem = new();
								foreach (ClassDeclarationSyntax item in classesD)
								{
									mem.AddRange(item.Members.ToList());
								}

								foreach (MemberDeclarationSyntax item in mem)
								{
									SyntaxToken? _sT = null;
									if (item is MethodDeclarationSyntax m)
									{
										_sT = m.Identifier;
									}

									if (item is PropertyDeclarationSyntax p)
									{
										_sT = p.Identifier;
										syntaxNode = p.Type;
									}

									if (item is FieldDeclarationSyntax f)
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
										symbolInfo = _Model.GetSymbolInfo(syntaxNode);
										break;
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
								if (iSymbol.ContainingNamespace.ToString().Contains(nameof(CSharpToJavaScript)))
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
										if (_attr.AttributeClass.Name == nameof(ToAttribute))
										{
											ToAttribute _attrLocal = new(_attr.ConstructorArguments[0].Value as string);

											JSSB.Append($" {_attrLocal.Convert(_text)}");
											break;
										}
									}
									break;
								}

								if (iSymbol.ContainingNamespace.ToString().Contains(_NameSpaceStr))
								{
									if (syntaxNode.IsKind(SyntaxKind.GenericName)) 
									{
										JSSB.Append($" {(syntaxNode as GenericNameSyntax).Identifier.ToString()}");
									}else
										JSSB.Append($" {syntaxNode.ToString()}");
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
									if (BuiltInTypesGenerics(syntaxNode.WithoutLeadingTrivia(), iSymbol) == false)
									{
										Log.WarningLine($"TODO : {syntaxNode} ||| USE 'CustomCSNamesToJS' TO CONVERT.", _Options);
									}
								}

							}
							break;
						}
					default:
						Log.ErrorLine($"asToken : {kind}", _Options);
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
							Log.WarningLine($"'ObjectInitializerExpression' Ignored! Please use constructor for '{nodesAndTokens[1].ToString()}'", _Options);
							//Todo? How? JS does not have object initializer...
							break;
						}
					case SyntaxKind.ArgumentList:
						Visit(asNode);
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
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
					case SyntaxKind.PredefinedType:
					case SyntaxKind.IdentifierName:
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
						Log.ErrorLine($"asToken : {kind}", _Options);
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
						VisitTypeArgumentList(asNode as TypeArgumentListSyntax);
						break;
					default:
						Log.ErrorLine($"asNode : {kind}", _Options);
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
							if (IdentifierToken(node) == false) 
							{
								base.VisitGenericName(node);
							}
							break;
						}
					default:
						Log.ErrorLine($"asToken : {kind}", _Options);
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
						Log.ErrorLine($"asNode : {kind}", _Options);
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
							if (IdentifierToken(node) == false)
							{
								base.VisitIdentifierName(node);
							}
							break;
						}
					default:
						Log.ErrorLine($"asToken : {kind}", _Options);
						break;
				}
			}
		}
	}

	public override void VisitAssignmentExpression(AssignmentExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitAssignmentExpression(node);
	}

	public override void VisitAttribute(AttributeSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitAttribute(node);
	}
	public override void VisitArrowExpressionClause(ArrowExpressionClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitArrowExpressionClause(node);
	}
	public override void VisitArgumentList(ArgumentListSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitArgumentList(node);
	}
	public override void VisitAccessorDeclaration(AccessorDeclarationSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitAccessorDeclaration(node);
	}
	public override void VisitAliasQualifiedName(AliasQualifiedNameSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitAliasQualifiedName(node);
	}
	public override void VisitAllowsConstraintClause(AllowsConstraintClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitAllowsConstraintClause(node);
	}
	public override void VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitAnonymousMethodExpression(node);
	}
	public override void VisitAnonymousObjectMemberDeclarator(AnonymousObjectMemberDeclaratorSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitAnonymousObjectMemberDeclarator(node);
	}
	public override void VisitAttributeArgument(AttributeArgumentSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitAttributeArgument(node);
	}
	public override void VisitAttributeArgumentList(AttributeArgumentListSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitAttributeArgumentList(node);
	}
	public override void VisitAttributeList(AttributeListSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitAttributeList(node);
	}
	public override void VisitAttributeTargetSpecifier(AttributeTargetSpecifierSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitAttributeTargetSpecifier(node);
	}
	public override void VisitAwaitExpression(AwaitExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitAwaitExpression(node);
	}
	public override void VisitBadDirectiveTrivia(BadDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitBadDirectiveTrivia(node);
	}
	public override void VisitBinaryExpression(BinaryExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitBinaryExpression(node);
	}
	public override void VisitBinaryPattern(BinaryPatternSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitBinaryPattern(node);
	}
	public override void VisitBracketedArgumentList(BracketedArgumentListSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitBracketedArgumentList(node);
	}
	public override void VisitBracketedParameterList(BracketedParameterListSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitBracketedParameterList(node);
	}
	public override void VisitBreakStatement(BreakStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitBreakStatement(node);
	}
	public override void VisitCasePatternSwitchLabel(CasePatternSwitchLabelSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitCasePatternSwitchLabel(node);
	}
	public override void VisitCaseSwitchLabel(CaseSwitchLabelSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitCaseSwitchLabel(node);
	}
	public override void VisitCatchClause(CatchClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitCatchClause(node);
	}
	public override void VisitCatchFilterClause(CatchFilterClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitCatchFilterClause(node);
	}
	public override void VisitCheckedExpression(CheckedExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitCheckedExpression(node);
	}
	public override void VisitCheckedStatement(CheckedStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitCheckedStatement(node);
	}
	public override void VisitClassOrStructConstraint(ClassOrStructConstraintSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitClassOrStructConstraint(node);
	}
	public override void VisitCollectionExpression(CollectionExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitCollectionExpression(node);
	}
	public override void VisitCompilationUnit(CompilationUnitSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitCompilationUnit(node);
	}
	public override void VisitConditionalAccessExpression(ConditionalAccessExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitConditionalAccessExpression(node);
	}
	public override void VisitConditionalExpression(ConditionalExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitConditionalExpression(node);
	}
	public override void VisitConstantPattern(ConstantPatternSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitConstantPattern(node);
	}
	public override void VisitConstructorConstraint(ConstructorConstraintSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitConstructorConstraint(node);
	}
	public override void VisitConstructorInitializer(ConstructorInitializerSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitConstructorInitializer(node);
	}
	public override void VisitContinueStatement(ContinueStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitContinueStatement(node);
	}
	public override void VisitConversionOperatorDeclaration(ConversionOperatorDeclarationSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitConversionOperatorDeclaration(node);
	}
	public override void VisitConversionOperatorMemberCref(ConversionOperatorMemberCrefSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitConversionOperatorMemberCref(node);
	}
	public override void VisitCrefBracketedParameterList(CrefBracketedParameterListSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitCrefBracketedParameterList(node);
	}
	public override void VisitCrefParameter(CrefParameterSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitCrefParameter(node);
	}
	public override void VisitCrefParameterList(CrefParameterListSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitCrefParameterList(node);
	}

	public override void VisitDeclarationExpression(DeclarationExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitDeclarationExpression(node);
	}
	public override void VisitDeclarationPattern(DeclarationPatternSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitDeclarationPattern(node);
	}
	public override void VisitDefaultConstraint(DefaultConstraintSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitDefaultConstraint(node);
	}
	public override void VisitDefaultExpression(DefaultExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitDefaultExpression(node);
	}
	public override void VisitDefaultSwitchLabel(DefaultSwitchLabelSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitDefaultSwitchLabel(node);
	}
	public override void VisitDefineDirectiveTrivia(DefineDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitDefineDirectiveTrivia(node);
	}

	public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitDelegateDeclaration(node);
	}
	public override void VisitDestructorDeclaration(DestructorDeclarationSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitDestructorDeclaration(node);
	}
	public override void VisitDiscardDesignation(DiscardDesignationSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitDiscardDesignation(node);
	}
	public override void VisitDiscardPattern(DiscardPatternSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitDiscardPattern(node);
	}
	public override void VisitDocumentationCommentTrivia(DocumentationCommentTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitDocumentationCommentTrivia(node);
	}
	public override void VisitDoStatement(DoStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitDoStatement(node);
	}
	public override void VisitElementAccessExpression(ElementAccessExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitElementAccessExpression(node);
	}
	public override void VisitElementBindingExpression(ElementBindingExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitElementBindingExpression(node);
	}
	public override void VisitElifDirectiveTrivia(ElifDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitElifDirectiveTrivia(node);
	}
	public override void VisitElseClause(ElseClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitElseClause(node);
	}
	public override void VisitElseDirectiveTrivia(ElseDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitElseDirectiveTrivia(node);
	}
	public override void VisitEmptyStatement(EmptyStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitEmptyStatement(node);
	}
	public override void VisitEndIfDirectiveTrivia(EndIfDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitEndIfDirectiveTrivia(node);
	}
	public override void VisitEndRegionDirectiveTrivia(EndRegionDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitEndRegionDirectiveTrivia(node);
	}
	public override void VisitEqualsValueClause(EqualsValueClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitEqualsValueClause(node);
	}
	public override void VisitErrorDirectiveTrivia(ErrorDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitErrorDirectiveTrivia(node);
	}
	public override void VisitEventDeclaration(EventDeclarationSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitEventDeclaration(node);
	}
	public override void VisitEventFieldDeclaration(EventFieldDeclarationSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitEventFieldDeclaration(node);
	}

	public override void VisitExplicitInterfaceSpecifier(ExplicitInterfaceSpecifierSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitExplicitInterfaceSpecifier(node);
	}
	public override void VisitExpressionColon(ExpressionColonSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitExpressionColon(node);
	}
	public override void VisitExpressionElement(ExpressionElementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitExpressionElement(node);
	}
	public override void VisitExternAliasDirective(ExternAliasDirectiveSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitExternAliasDirective(node);
	}
	public override void VisitFieldExpression(FieldExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitFieldExpression(node);
	}
	public override void VisitFileScopedNamespaceDeclaration(FileScopedNamespaceDeclarationSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitFileScopedNamespaceDeclaration(node);
	}
	public override void VisitFinallyClause(FinallyClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitFinallyClause(node);
	}
	public override void VisitFixedStatement(FixedStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitFixedStatement(node);
	}
	public override void VisitForEachVariableStatement(ForEachVariableStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitForEachVariableStatement(node);
	}
	public override void VisitForStatement(ForStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitForStatement(node);
	}
	public override void VisitFromClause(FromClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitFromClause(node);
	}
	public override void VisitFunctionPointerCallingConvention(FunctionPointerCallingConventionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitFunctionPointerCallingConvention(node);
	}
	public override void VisitFunctionPointerParameter(FunctionPointerParameterSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitFunctionPointerParameter(node);
	}
	public override void VisitFunctionPointerParameterList(FunctionPointerParameterListSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitFunctionPointerParameterList(node);
	}
	public override void VisitFunctionPointerType(FunctionPointerTypeSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitFunctionPointerType(node);
	}
	public override void VisitFunctionPointerUnmanagedCallingConvention(FunctionPointerUnmanagedCallingConventionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitFunctionPointerUnmanagedCallingConvention(node);
	}
	public override void VisitFunctionPointerUnmanagedCallingConventionList(FunctionPointerUnmanagedCallingConventionListSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitFunctionPointerUnmanagedCallingConventionList(node);
	}
	public override void VisitGlobalStatement(GlobalStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitGlobalStatement(node);
	}
	public override void VisitGotoStatement(GotoStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitGotoStatement(node);
	}
	public override void VisitGroupClause(GroupClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitGroupClause(node);
	}
	public override void VisitIfDirectiveTrivia(IfDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitIfDirectiveTrivia(node);
	}
	public override void VisitIfStatement(IfStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitIfStatement(node);
	}
	public override void VisitImplicitArrayCreationExpression(ImplicitArrayCreationExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitImplicitArrayCreationExpression(node);
	}
	public override void VisitImplicitElementAccess(ImplicitElementAccessSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitImplicitElementAccess(node);
	}
	public override void VisitImplicitStackAllocArrayCreationExpression(ImplicitStackAllocArrayCreationExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitImplicitStackAllocArrayCreationExpression(node);
	}
	public override void VisitIncompleteMember(IncompleteMemberSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitIncompleteMember(node);
	}
	public override void VisitIndexerDeclaration(IndexerDeclarationSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitIndexerDeclaration(node);
	}
	public override void VisitIndexerMemberCref(IndexerMemberCrefSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitIndexerMemberCref(node);
	}
	public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitInterfaceDeclaration(node);
	}
	public override void VisitInterpolatedStringText(InterpolatedStringTextSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitInterpolatedStringText(node);
	}
	public override void VisitInterpolation(InterpolationSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitInterpolation(node);
	}
	public override void VisitInterpolationAlignmentClause(InterpolationAlignmentClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitInterpolationAlignmentClause(node);
	}
	public override void VisitInterpolationFormatClause(InterpolationFormatClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitInterpolationFormatClause(node);
	}
	public override void VisitInvocationExpression(InvocationExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitInvocationExpression(node);
	}
	public override void VisitIsPatternExpression(IsPatternExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitIsPatternExpression(node);
	}
	public override void VisitJoinClause(JoinClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitJoinClause(node);
	}
	public override void VisitJoinIntoClause(JoinIntoClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitJoinIntoClause(node);
	}
	public override void VisitLabeledStatement(LabeledStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitLabeledStatement(node);
	}
	public override void VisitLeadingTrivia(SyntaxToken token)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({token.FullSpan}|l:{_Line}|{token.FullSpan.Start - _Characters}-{token.FullSpan.End - _Characters})", _Options);

		base.VisitLeadingTrivia(token);
	}
	public override void VisitLetClause(LetClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitLetClause(node);
	}
	public override void VisitLineDirectivePosition(LineDirectivePositionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitLineDirectivePosition(node);
	}
	public override void VisitLineDirectiveTrivia(LineDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitLineDirectiveTrivia(node);
	}
	public override void VisitLineSpanDirectiveTrivia(LineSpanDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitLineSpanDirectiveTrivia(node);
	}
	public override void VisitListPattern(ListPatternSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitListPattern(node);
	}
	public override void VisitLoadDirectiveTrivia(LoadDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitLoadDirectiveTrivia(node);
	}
	public override void VisitLocalFunctionStatement(LocalFunctionStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitLocalFunctionStatement(node);
	}
	public override void VisitLockStatement(LockStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitLockStatement(node);
	}
	public override void VisitMakeRefExpression(MakeRefExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitMakeRefExpression(node);
	}
	public override void VisitMemberBindingExpression(MemberBindingExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitMemberBindingExpression(node);
	}
	public override void VisitNameColon(NameColonSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitNameColon(node);
	}
	public override void VisitNameMemberCref(NameMemberCrefSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitNameMemberCref(node);
	}
	public override void VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitNamespaceDeclaration(node);
	}
	public override void VisitNullableDirectiveTrivia(NullableDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitNullableDirectiveTrivia(node);
	}
	public override void VisitNullableType(NullableTypeSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitNullableType(node);
	}
	public override void VisitOmittedArraySizeExpression(OmittedArraySizeExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitOmittedArraySizeExpression(node);
	}
	public override void VisitOmittedTypeArgument(OmittedTypeArgumentSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitOmittedTypeArgument(node);
	}
	public override void VisitOperatorDeclaration(OperatorDeclarationSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitOperatorDeclaration(node);
	}

	public override void VisitOperatorMemberCref(OperatorMemberCrefSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitOperatorMemberCref(node);
	}
	public override void VisitOrderByClause(OrderByClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitOrderByClause(node);
	}
	public override void VisitOrdering(OrderingSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitOrdering(node);
	}
	public override void VisitParameterList(ParameterListSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitParameterList(node);
	}
	public override void VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitParenthesizedLambdaExpression(node);
	}
	public override void VisitParenthesizedPattern(ParenthesizedPatternSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitParenthesizedPattern(node);
	}
	public override void VisitParenthesizedVariableDesignation(ParenthesizedVariableDesignationSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitParenthesizedVariableDesignation(node);
	}
	public override void VisitPointerType(PointerTypeSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitPointerType(node);
	}
	public override void VisitPositionalPatternClause(PositionalPatternClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitPositionalPatternClause(node);
	}
	public override void VisitPostfixUnaryExpression(PostfixUnaryExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitPostfixUnaryExpression(node);
	}
	public override void VisitPragmaChecksumDirectiveTrivia(PragmaChecksumDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitPragmaChecksumDirectiveTrivia(node);
	}
	public override void VisitPragmaWarningDirectiveTrivia(PragmaWarningDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitPragmaWarningDirectiveTrivia(node);
	}
	public override void VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitPrefixUnaryExpression(node);
	}
	public override void VisitPrimaryConstructorBaseType(PrimaryConstructorBaseTypeSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitPrimaryConstructorBaseType(node);
	}
	public override void VisitPropertyPatternClause(PropertyPatternClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitPropertyPatternClause(node);
	}
	public override void VisitQualifiedCref(QualifiedCrefSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitQualifiedCref(node);
	}
	public override void VisitQualifiedName(QualifiedNameSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitQualifiedName(node);
	}
	public override void VisitQueryBody(QueryBodySyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitQueryBody(node);
	}
	public override void VisitQueryContinuation(QueryContinuationSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitQueryContinuation(node);
	}
	public override void VisitQueryExpression(QueryExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitQueryExpression(node);
	}
	public override void VisitRangeExpression(RangeExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitRangeExpression(node);
	}
	public override void VisitRecordDeclaration(RecordDeclarationSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitRecordDeclaration(node);
	}
	public override void VisitRecursivePattern(RecursivePatternSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitRecursivePattern(node);
	}
	public override void VisitReferenceDirectiveTrivia(ReferenceDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitReferenceDirectiveTrivia(node);
	}
	public override void VisitRefExpression(RefExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitRefExpression(node);
	}
	public override void VisitRefStructConstraint(RefStructConstraintSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitRefStructConstraint(node);
	}
	public override void VisitRefType(RefTypeSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitRefType(node);
	}
	public override void VisitRefTypeExpression(RefTypeExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitRefTypeExpression(node);
	}
	public override void VisitRefValueExpression(RefValueExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitRefValueExpression(node);
	}
	public override void VisitRegionDirectiveTrivia(RegionDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitRegionDirectiveTrivia(node);
	}
	public override void VisitRelationalPattern(RelationalPatternSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitRelationalPattern(node);
	}
	public override void VisitReturnStatement(ReturnStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitReturnStatement(node);
	}
	public override void VisitScopedType(ScopedTypeSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitScopedType(node);
	}
	public override void VisitSelectClause(SelectClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitSelectClause(node);
	}
	public override void VisitShebangDirectiveTrivia(ShebangDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitShebangDirectiveTrivia(node);
	}
	public override void VisitSimpleBaseType(SimpleBaseTypeSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitSimpleBaseType(node);
	}
	public override void VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitSimpleLambdaExpression(node);
	}
	public override void VisitSingleVariableDesignation(SingleVariableDesignationSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitSingleVariableDesignation(node);
	}
	public override void VisitSizeOfExpression(SizeOfExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitSizeOfExpression(node);
	}
	public override void VisitSkippedTokensTrivia(SkippedTokensTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitSkippedTokensTrivia(node);
	}
	public override void VisitSlicePattern(SlicePatternSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitSlicePattern(node);
	}
	public override void VisitSpreadElement(SpreadElementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitSpreadElement(node);
	}
	public override void VisitStackAllocArrayCreationExpression(StackAllocArrayCreationExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitStackAllocArrayCreationExpression(node);
	}
	public override void VisitStructDeclaration(StructDeclarationSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitStructDeclaration(node);
	}
	public override void VisitSubpattern(SubpatternSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitSubpattern(node);
	}
	public override void VisitSwitchExpression(SwitchExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitSwitchExpression(node);
	}
	public override void VisitSwitchExpressionArm(SwitchExpressionArmSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitSwitchExpressionArm(node);
	}
	public override void VisitSwitchSection(SwitchSectionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitSwitchSection(node);
	}
	public override void VisitSwitchStatement(SwitchStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitSwitchStatement(node);
	}
	public override void VisitThrowExpression(ThrowExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitThrowExpression(node);
	}
	public override void VisitThrowStatement(ThrowStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitThrowStatement(node);
	}
	public override void VisitTrailingTrivia(SyntaxToken token)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({token.FullSpan}|l:{_Line}|{token.FullSpan.Start - _Characters}-{token.FullSpan.End - _Characters})", _Options);

		base.VisitTrailingTrivia(token);
	}
	public override void VisitTryStatement(TryStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitTryStatement(node);
	}
	public override void VisitTupleElement(TupleElementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitTupleElement(node);
	}
	public override void VisitTupleExpression(TupleExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitTupleExpression(node);
	}
	public override void VisitTupleType(TupleTypeSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitTupleType(node);
	}
	public override void VisitTypeConstraint(TypeConstraintSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitTypeConstraint(node);
	}
	public override void VisitTypeCref(TypeCrefSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitTypeCref(node);
	}
	public override void VisitTypeOfExpression(TypeOfExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitTypeOfExpression(node);
	}
	public override void VisitTypeParameter(TypeParameterSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitTypeParameter(node);
	}
	public override void VisitTypeParameterConstraintClause(TypeParameterConstraintClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitTypeParameterConstraintClause(node);
	}
	public override void VisitTypeParameterList(TypeParameterListSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitTypeParameterList(node);
	}
	public override void VisitTypePattern(TypePatternSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitTypePattern(node);
	}
	public override void VisitUnaryPattern(UnaryPatternSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitUnaryPattern(node);
	}
	public override void VisitUndefDirectiveTrivia(UndefDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitUndefDirectiveTrivia(node);
	}
	public override void VisitUnsafeStatement(UnsafeStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitUnsafeStatement(node);
	}
	public override void VisitUsingDirective(UsingDirectiveSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitUsingDirective(node);
	}
	public override void VisitUsingStatement(UsingStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitUsingStatement(node);
	}
	public override void VisitVarPattern(VarPatternSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitVarPattern(node);
	}
	public override void VisitWarningDirectiveTrivia(WarningDirectiveTriviaSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitWarningDirectiveTrivia(node);
	}
	public override void VisitWhenClause(WhenClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitWhenClause(node);
	}
	public override void VisitWhereClause(WhereClauseSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitWhereClause(node);
	}
	public override void VisitWhileStatement(WhileStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitWhileStatement(node);
	}
	public override void VisitWithExpression(WithExpressionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitWithExpression(node);
	}
	public override void VisitXmlCDataSection(XmlCDataSectionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitXmlCDataSection(node);
	}
	public override void VisitXmlComment(XmlCommentSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitXmlComment(node);
	}
	public override void VisitXmlCrefAttribute(XmlCrefAttributeSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitXmlCrefAttribute(node);
	}
	public override void VisitXmlElement(XmlElementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitXmlElement(node);
	}
	public override void VisitXmlElementEndTag(XmlElementEndTagSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitXmlElementEndTag(node);
	}
	public override void VisitXmlElementStartTag(XmlElementStartTagSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitXmlElementStartTag(node);
	}
	public override void VisitXmlEmptyElement(XmlEmptyElementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitXmlEmptyElement(node);
	}

	public override void VisitXmlName(XmlNameSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitXmlName(node);
	}
	public override void VisitXmlNameAttribute(XmlNameAttributeSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitXmlNameAttribute(node);
	}
	public override void VisitXmlPrefix(XmlPrefixSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitXmlPrefix(node);
	}
	public override void VisitXmlProcessingInstruction(XmlProcessingInstructionSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitXmlProcessingInstruction(node);
	}
	public override void VisitXmlText(XmlTextSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitXmlText(node);
	}
	public override void VisitXmlTextAttribute(XmlTextAttributeSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

		base.VisitXmlTextAttribute(node);
	}
	public override void VisitYieldStatement(YieldStatementSyntax node)
	{
		if (_Options.Debug)
			Log.WarningLine($"Not implemented or unlikely to be implemented. Calling base! ({node.FullSpan}|l:{_Line}|{node.FullSpan.Start - _Characters}-{node.FullSpan.End - _Characters})", _Options);

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
						symbolInfo = _Model.GetSymbolInfo(_item.Parent as IdentifierNameSyntax);
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
				ImmutableArray<Diagnostic> diags = _Model.GetDeclarationDiagnostics();
				foreach (Diagnostic item in diags)
				{
					Log.WarningLine(item.ToString(), _Options);
				}
				Log.WarningLine(e.ToString(), _Options);
				//throw;
			}
		}

		ISymbol? iSymbol = null;

		if (symbolInfo?.CandidateSymbols.Length >= 1)
			iSymbol = symbolInfo?.CandidateSymbols[0];
		else
			iSymbol = symbolInfo?.Symbol;

		if (iSymbol != null && iSymbol.Kind != SymbolKind.ErrorType && iSymbol.Kind != SymbolKind.DynamicType)
		{
			if (iSymbol.ContainingNamespace.ToString().Contains(nameof(CSharpToJavaScript)))
			{
				//
				//
				//Checking attribute data of a types, see Utils/Attributes.

				//Attributes of this node(type)
				ImmutableArray<AttributeData> _attributeDatas = iSymbol.GetAttributes();

				List<object> _attributes = new();

				foreach (AttributeData attributeData in _attributeDatas)
				{
					if (attributeData.AttributeClass.Name == nameof(EnumValueAttribute))
					{
						_attributes.Add(new EnumValueAttribute(attributeData.ConstructorArguments[0].Value as string));
					}

					if (attributeData.AttributeClass.Name == nameof(ValueAttribute))
					{
						_attributes.Add(new ValueAttribute(attributeData.ConstructorArguments[0].Value as string));
					}

					if (attributeData.AttributeClass.Name == nameof(ToAttribute))
					{
						_attributes.Add(new ToAttribute(attributeData.ConstructorArguments[0].Value as string));
					}
				}

				bool _cad = _CheckAttributeData(_attributes.ToArray());
				if (_cad)
				{
					return true;
				}
				else
				{
					//Attributes of a parent node(type)
					_attributes.Clear();
					_attributeDatas = iSymbol.ContainingType.GetAttributes();
					
					foreach (AttributeData attributeData in _attributeDatas)
					{
						if (attributeData.AttributeClass.Name == nameof(EnumValueAttribute))
						{
							_attributes.Add(new EnumValueAttribute(attributeData.ConstructorArguments[0].Value as string));
						}

						if (attributeData.AttributeClass.Name == nameof(ValueAttribute))
						{
							_attributes.Add(new ValueAttribute(attributeData.ConstructorArguments[0].Value as string));
						}

						if (attributeData.AttributeClass.Name == nameof(ToAttribute))
						{
							_attributes.Add(new ToAttribute(attributeData.ConstructorArguments[0].Value as string));
						}
					}
					
					return _CheckAttributeData(_attributes.ToArray());
				}

				/*
				foreach (AttributeData _attr in _attributeDatas)
				{
					if (_attr.AttributeClass.Name == nameof(EnumValueAttribute)) 
					{
						EnumValueAttribute _attrLocal = new(_attr.ConstructorArguments[0].Value as string);

						VisitLeadingTrivia(identifier);
						JSSB.Append($"\"{_attrLocal.Value}\"");
						VisitTrailingTrivia(identifier);
						return true;
					}

					if (_attr.AttributeClass.Name == nameof(ValueAttribute))
					{
						ValueAttribute _attrLocal = new(_attr.ConstructorArguments[0].Value as string);

						VisitLeadingTrivia(identifier);
						JSSB.Append($"{_attrLocal.Value}");
						VisitTrailingTrivia(identifier);
						return true;
					}

					if (_attr.AttributeClass.Name == nameof(ToAttribute))
					{
						ToAttribute _attrLocal = new(_attr.ConstructorArguments[0].Value as string);

						if (_attrLocal.To == ToAttribute.None)
							_IgnoreTailingDot = true;

						VisitLeadingTrivia(identifier);
						JSSB.Append($"{_attrLocal.Convert(text)}");
						VisitTrailingTrivia(identifier);
						return true;
						
					}
				}

				//Attributes of a parent node(type)
				_attributeDatas = iSymbol.ContainingType.GetAttributes();
				foreach (AttributeData _attr in _attributeDatas)
				{
					if (_attr.AttributeClass.Name == nameof(ValueAttribute))
					{
						ValueAttribute _attrLocal = new(_attr.ConstructorArguments[0].Value as string);

						VisitLeadingTrivia(identifier);
						JSSB.Append($"{_attrLocal.Value}");
						VisitTrailingTrivia(identifier);
						return true;
					}

					if (_attr.AttributeClass?.Name == nameof(ToAttribute))
					{
						ToAttribute _attrLocal = new(_attr.ConstructorArguments[0].Value as string);

						VisitLeadingTrivia(identifier);
						JSSB.Append($"{_attrLocal.Convert(text)}");
						VisitTrailingTrivia(identifier);
						return true;
					}
				}*/
			}

			if (iSymbol.ContainingNamespace.ToString().Contains(_NameSpaceStr))
			{
				if (iSymbol.Kind == SymbolKind.Parameter ||
					iSymbol.Kind == SymbolKind.Local)
				{
					return false;
				}

				ClassDeclarationSyntax _class = (ClassDeclarationSyntax)node.Ancestors().FirstOrDefault(n => n.IsKind(SyntaxKind.ClassDeclaration));

				//This is for struct.
				//maybe later convert struct to class?
				//
				if (_class == default(ClassDeclarationSyntax)) 
				{
					return false;
				}

				SyntaxList<MemberDeclarationSyntax> _members = _class.Members;

				foreach (MemberDeclarationSyntax item in _members)
				{
					SyntaxToken _sT = default;
					if (item is MethodDeclarationSyntax m)
					{
						_sT = m.Identifier;
					}

					if (item is PropertyDeclarationSyntax p)
					{
						_sT = p.Identifier;
					}

					if (item is FieldDeclarationSyntax f)
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
						if (node.Parent.Parent != null &&
							!node.Parent.DescendantNodes().Any((e)=>e.IsKind(SyntaxKind.ThisExpression))) 
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

		foreach (Type type in _Options.CustomCSTypesToJS)
		{
			if (type.Name == text)
			{
				return _CheckAttributeData(type.GetCustomAttributes(true));
			}

			MemberInfo[] _Members = type.GetMembers();

			bool b = _CheckMembersInNestedClasses(_Members);

			if (b == true)
				return true;
		}
		
		
		
		bool _CheckMembersInNestedClasses(MemberInfo[] _members)
		{
			foreach (MemberInfo _memberInfo in _members)
			{
				Type? _type = _memberInfo as Type;
				
				if (_type != null && _type.IsClass)
				{
					return _CheckMembersInNestedClasses(_type.GetMembers());
				}

				if (_memberInfo.Name == text)
				{
					object[] _attrs = _memberInfo.GetCustomAttributes(true);

					return _CheckAttributeData(_memberInfo.GetCustomAttributes(true));
				}
			}

			return false;
		}

		bool _CheckAttributeData(object[] attrs)
		{
			foreach (object _attr in attrs)
			{
				if (_attr is EnumValueAttribute enumValueAttribute)
				{
					VisitLeadingTrivia(identifier);
					JSSB.Append($"\"{enumValueAttribute.Value}\"");
					VisitTrailingTrivia(identifier);
					return true;
				}
				if (_attr is ValueAttribute valueAttribute)
				{
					VisitLeadingTrivia(identifier);
					JSSB.Append($"{valueAttribute.Value}");
					VisitTrailingTrivia(identifier);
					return true;
				}
				if (_attr is ToAttribute toAttribute)
				{
					if (toAttribute.To == ToAttribute.None)
						_IgnoreTailingDot = true;

					VisitLeadingTrivia(identifier);
					JSSB.Append($"{toAttribute.Convert(text)}");
					VisitTrailingTrivia(identifier);
					return true;
				}
			}

			return false;
		}
		
		
		
		if (CustomCSNamesToJS(node) == false)
		{
			if (BuiltInTypesGenerics(node, iSymbol) == false)
			{
				if (_Options.Debug)
				{
					Log.WarningLine("WARNING! Diagnostics starts ---", _Options);
					ImmutableArray<Diagnostic> diag = _Model.GetDiagnostics();
					foreach (Diagnostic item in diag)
					{
						Log.WarningLine(item.ToString(), _Options);
					}
					Log.WarningLine("WARNING! Diagnostics ends ---", _Options);
				}
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
		foreach (Tuple<string, string> _item in _Options.CustomCSNamesToJS)
		{
			if (node is IdentifierNameSyntax _identifierName)
			{
				if (_identifierName.Identifier.Text == _item.Item1)
				{
					VisitLeadingTrivia(_identifierName.Identifier);
					JSSB.Append(_item.Item2);
					return true;
				}
			}
			else if (node is GenericNameSyntax _genericName)
			{
				if (_genericName.Identifier.Text == _item.Item1)
				{
					VisitLeadingTrivia(_genericName.Identifier);
					JSSB.Append(_item.Item2);
					return true;
				}
			}
		}
		return false;
	}

	private bool BuiltInTypesGenerics(SyntaxNode nodeL, ISymbol? symbol) 
	{
		IdentifierNameSyntax? node = nodeL as IdentifierNameSyntax;

		if (symbol == null) 
		{
			Log.WarningLine($"WARNING! node: \"{node}\", symbol is null. USE \"CustomCSNamesToJS\"!", _Options);
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
				Log.WarningLine($"WARNING! node: \"{node}\", typeSymbol is \"{typeSymbol.Kind}\". USE \"CustomCSNamesToJS\"!", _Options);
				return false;
			}
		}

		string typeName = typeSymbol.Name;
		ToAttribute toAttribute = new(ToAttribute.Default);

		string? jsStr = _NETAPI.ReturnJSString(typeName);
		if (jsStr == null)
		{
			Log.WarningLine($"WARNING! typeSymbol: \"{typeSymbol}\" Is not supported! USE \"CustomCSNamesToJS\"", _Options);
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
				Log.WarningLine($"WARNING! node: \"{node}\", typeSymbol: \"{typeSymbol}\", symbol: \"{symbol}\", Is not supported! USE \"CustomCSNamesToJS\"", _Options);
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
