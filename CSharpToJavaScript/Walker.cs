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

namespace CSharpToJavaScript
{
	//Useful links:
	//https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/get-started/syntax-analysis
	//https://roslynquoter.azurewebsites.net/
	//

	internal class Walker : CSharpSyntaxWalker, ILog
	{
		public StringBuilder JSSB { get; set; } = new();


		private readonly ILog _Log;
		private readonly CSTOJSOptions _Options;
		private readonly SemanticModel _Model;


		private SyntaxNode? _SNOriginal = null;
		private SyntaxNode? _BaseConstructorInitializerNode = null;

		private string _NameSpaceStr = string.Empty;
		private string _CurrentClassStr = string.Empty;

		private bool _PropertyStatic = false;
		private bool _ConstKeyword = false;
		private bool _IgnoreArrayType = false;
		private bool _IgnoreAsParenthesis = false;

		private int _EnumMembers = 0;

		public Walker(CSTOJSOptions options, SemanticModel model) : base(SyntaxWalkerDepth.Trivia)
		{
			_Log = this;
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
				case SyntaxKind.EndOfLineTrivia:
					{
						string _full = trivia.ToFullString();
						JSSB.Append(_full);
						return;
					}
				default:
					_Log.ErrorLine($"ERROR Trivia : {syntaxKind}");
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
				case SyntaxKind.EqualsEqualsToken:
				case SyntaxKind.ExclamationEqualsToken:
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
				case SyntaxKind.EndOfFileToken:
					{
						VisitLeadingTrivia(token);

						JSSB.Append(token.Text);

						VisitTrailingTrivia(token);
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
					_Log.ErrorLine($"ERROR Token : {syntaxKind}");
					break;
			}

			base.VisitToken(token);
		}

		public override void Visit(SyntaxNode? node)
		{
			SyntaxKind syntaxKind = node.Kind();

			switch (syntaxKind)
			{
				case SyntaxKind.UsingDirective:
					return;
				case SyntaxKind.FileScopedNamespaceDeclaration:
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
				case SyntaxKind.NamespaceDeclaration:
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
				default:
					//CSTOJS.Log($"{syntaxKind}");
					break;
			}

			base.Visit(node);
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
						case SyntaxKind.BaseList:
						case SyntaxKind.FieldDeclaration:
						case SyntaxKind.ConstructorDeclaration:
						case SyntaxKind.MethodDeclaration:
						case SyntaxKind.PropertyDeclaration:
							Visit(asNode);
							break;
						default:
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
								_BaseConstructorInitializerNode = asNode;
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");

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
						case SyntaxKind.NullableType:
						case SyntaxKind.GenericName:
						case SyntaxKind.IdentifierName:
						case SyntaxKind.PredefinedType:
							break;
						default:
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
								if (_BaseConstructorInitializerNode != null)
								{
									SyntaxTriviaList _syntaxTrivias = asToken.LeadingTrivia;
									for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
									{
										VisitTrivia(_syntaxTrivias[_i]);
									}
									JSSB.Append("\tsuper");
									Visit((_BaseConstructorInitializerNode as ConstructorInitializerSyntax).ArgumentList);
									//Todo!
									//JSSB.Append(";");
									_BaseConstructorInitializerNode = null;
								}
								break;
							}
						default:
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							Visit(asNode);
							break;
						default:
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
						case SyntaxKind.GenericName:
						case SyntaxKind.PredefinedType:
							break;
						case SyntaxKind.ParameterList:
						case SyntaxKind.Block:
							Visit(asNode);
							break;
						default:
							_Log.ErrorLine($"asNode : {kind}");
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
						case SyntaxKind.StaticKeyword:
						case SyntaxKind.AsyncKeyword:
						case SyntaxKind.IdentifierToken:
							VisitToken(asToken);
							break;
						default:
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
							break;
					}
				}
			}
		}

		public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
		{
			ChildSyntaxList nodesAndTokens = node.ChildNodesAndTokens();

			for (int i = 0; i < nodesAndTokens.Count; i++)
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

							FieldDeclarationSyntax? field = null;

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
							else
							{
								key = key.First().ChildNodesAndTokens();
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

							VisitFieldDeclaration(field);
							break;
						}
					}
				}
				else 
				{
					SyntaxToken asToken = nodesAndTokens[i].AsToken();
					SyntaxKind kind = asToken.Kind();

					if (kind == SyntaxKind.StaticKeyword)
						_PropertyStatic = true;
				}

			}

			for (int i = 0; i < nodesAndTokens.Count; i++)
			{
				SyntaxNode? asNode = nodesAndTokens[i].AsNode();

				if (asNode != null)
				{
					SyntaxKind kind = asNode.Kind();

					switch (kind)
					{
						//TODO "EqualsValueClause" default value
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
						case SyntaxKind.SemicolonToken:
							VisitToken(asToken);
							break;
						default:
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
								IdentifierNameSyntax _ins = asNode as IdentifierNameSyntax;
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

								break;
							}
						default:
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
						case SyntaxKind.NumericLiteralExpression:
						case SyntaxKind.DivideExpression:
							Visit(asNode);
							break;
						//Todo?
						case SyntaxKind.OmittedArraySizeExpression:
							break;
						default:
							_Log.ErrorLine($"asNode : {kind}");
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
						default:
							_Log.ErrorLine($"asToken : {kind}");
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
						case SyntaxKind.ObjectCreationExpression:
							VisitObjectCreationExpression(asNode as ObjectCreationExpressionSyntax);
							break;
						default:
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");

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
							_Log.ErrorLine($"asNode : {kind}");
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
								if (asToken.Text.EndsWith('f'))
									JSSB.Append(asToken.Text.Remove(asToken.Text.Length - 1));
								else
									VisitToken(asToken);
								break;
							}
						case SyntaxKind.TrueKeyword:
						case SyntaxKind.FalseKeyword:
						case SyntaxKind.StringLiteralToken:
						case SyntaxKind.NullKeyword:
							VisitToken(asToken);
							break;
						default:
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
						case SyntaxKind.SubtractExpression:
						case SyntaxKind.MultiplyExpression:
						case SyntaxKind.CoalesceExpression:
						case SyntaxKind.LogicalOrExpression:
						case SyntaxKind.AddExpression:
							Visit(asNode);
							break;
						case SyntaxKind.AsExpression:
							{

								//Todo double/multiply asExpression?? How?
								_SNOriginal = (asNode as BinaryExpressionSyntax).Left;

								Visit(_SNOriginal.WithoutTrailingTrivia());

								_SNOriginal = null;
								break;
							}
						default:
							_Log.ErrorLine($"asNode : {kind}");
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
								if (_IgnoreAsParenthesis) 
								{
								
								}
								else
									VisitToken(asToken);
								break;
							}
						//case SyntaxKind.StringLiteralToken:
							//VisitToken(asToken);
							//break;
						default:
							_Log.ErrorLine($"asToken : {kind}");
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
						case SyntaxKind.InvocationExpression:
						case SyntaxKind.SimpleMemberAccessExpression:
							Visit(asNode);
							break;
						default:
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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


								VariableDeclarationSyntax _vds = node.Ancestors().FirstOrDefault(e => e.IsKind(SyntaxKind.VariableDeclaration)) as VariableDeclarationSyntax;

								SymbolInfo? symbolInfo = null;
								ISymbol? iSymbol = null;
								SyntaxNode? syntaxNode = null;

								if (_vds == null)
								{
									AssignmentExpressionSyntax _aes = node.Ancestors().FirstOrDefault(e => e.IsKind(SyntaxKind.SimpleAssignmentExpression)) as AssignmentExpressionSyntax;
									symbolInfo = _Model.GetSymbolInfo(_aes.Left);

									ClassDeclarationSyntax classD = (ClassDeclarationSyntax)node.Ancestors().First(n => n.IsKind(SyntaxKind.ClassDeclaration));

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

									//TODO??? Test??
									if (syntaxNode.IsKind(SyntaxKind.PredefinedType)) 
									{
										break;
									}

									if (CustomCSNamesToJS(syntaxNode) == false)
									{
										JSSB.Append(' ');
										if (BuiltInTypesGenerics(syntaxNode.WithoutLeadingTrivia(), iSymbol) == false)
										{
											_Log.WarningLine($"TODO : {syntaxNode} ||| USE 'CustomCSNamesToJS' TO CONVERT.");
										}
									}

								}
								break;
							}
						default:
							_Log.ErrorLine($"asToken : {kind}");
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
								_Log.WarningLine($"'ObjectInitializerExpression' Ignored! Please use constructor for '{nodesAndTokens[1].ToString()}'");
								//Todo? How? JS does not have object initializer...
								break;
							}
						case SyntaxKind.ArgumentList:
							Visit(asNode);
							break;
						case SyntaxKind.IdentifierName:
							VisitIdentifierName(asNode as IdentifierNameSyntax);
							break;
						case SyntaxKind.GenericName:
							VisitGenericName(asNode as GenericNameSyntax);
							break;
						default:
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
							break;
					}
				}
				else
				{
					SyntaxToken asToken = nodesAndTokens[i].AsToken();
					SyntaxKind kind = asToken.Kind();

					switch (kind)
					{
						case SyntaxKind.GreaterThanToken:
						case SyntaxKind.LessThanToken:
							break;
						default:
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
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
							_Log.ErrorLine($"asNode : {kind}");
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
							_Log.ErrorLine($"asToken : {kind}");
							break;
					}
				}
			}
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
			if (_SNOriginal != null)
			{
				IEnumerable<SyntaxNodeOrToken> _identifierNameSyntax = _SNOriginal.DescendantNodesAndTokens().Where(e => e.IsToken == true);
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
				node = _SNOriginal;
			}
			else
			{
				try
				{
					symbolInfo = _Model.GetSymbolInfo(node);

					if (_Options.Debug)
					{
						var a = _Model.GetDiagnostics();
						foreach (Diagnostic item in a)
						{
							_Log.WarningLine(item.ToString());
						}
					}
				}
				catch (Exception e)
				{
					symbolInfo = null;
					var a = _Model.GetDeclarationDiagnostics();
					foreach (Diagnostic item in a)
					{
						_Log.WarningLine(item.ToString());
					}
					_Log.WarningLine(e.ToString());
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
					ImmutableArray<AttributeData> _attributeDatas = iSymbol.GetAttributes();
					foreach (AttributeData _attr in _attributeDatas)
					{
						if (_attr.AttributeClass.Name == nameof(ValueAttribute)) 
						{
							ValueAttribute _attrLocal = new(_attr.ConstructorArguments[0].Value as string);

							VisitLeadingTrivia(identifier);

							//Todo? Better delete the dot, elsewhere.
							JSSB.Remove(JSSB.Length - 1, 1);
							
							JSSB.Append($"\"{_attrLocal.Value}\"");
							VisitTrailingTrivia(identifier);
							return true;
						}

						if (_attr.AttributeClass.Name == nameof(ToAttribute))
						{
							ToAttribute _attrLocal = new(_attr.ConstructorArguments[0].Value as string);

							VisitLeadingTrivia(identifier);
							JSSB.Append($"{_attrLocal.Convert(text)}");
							VisitTrailingTrivia(identifier);
							return true;
						}
					}
					//if (_attributeDatas.Length == 0) 
					//{
					_attributeDatas = iSymbol.ContainingType.GetAttributes();
					foreach (AttributeData _attr in _attributeDatas)
					{
						if (_attr.AttributeClass.Name == nameof(ToAttribute))
						{
							ToAttribute _attrLocal = new(_attr.ConstructorArguments[0].Value as string);

							VisitLeadingTrivia(identifier);
							JSSB.Append($"{_attrLocal.Convert(text)}");
							VisitTrailingTrivia(identifier);
							return true;
						}
					}
					//}
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

					SyntaxList<MemberDeclarationSyntax> a = _class.Members;

					foreach (MemberDeclarationSyntax item in a)
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
					object[] _attrs = type.GetCustomAttributes(true);
					foreach (object _attr in _attrs)
					{
						ToAttribute _authAttr = _attr as ToAttribute;
						if (_authAttr != null)
						{
							VisitLeadingTrivia(identifier);
							JSSB.Append($"{_authAttr.Convert(text)}");
							return true;
						}
					}

					return true;
				}

				MemberInfo[] _Members = type.GetMembers();
				foreach (MemberInfo _memberInfo in _Members)
				{
					//TODO! A better way for nested classes!
					var c = _memberInfo as Type;

					if (c != null && c.IsClass)
					{
						MemberInfo[] _Members1 = c.GetMembers();
						foreach (MemberInfo _memberInfo1 in _Members1)
						{
							//TODO!  A better way for nested classes!
							var c1 = _memberInfo1 as Type;

							if (c1 != null && c1.IsClass)
							{
								MemberInfo[] _Members2 = c1.GetMembers();
								foreach (MemberInfo _memberInfo2 in _Members2)
								{
									if (_memberInfo2.Name == text)
									{
										object[] _attrs2 = _memberInfo2.GetCustomAttributes(true);
										foreach (object _attr2 in _attrs2)
										{
											ToAttribute _authAttr2 = _attr2 as ToAttribute;
											if (_authAttr2 != null)
											{
												JSSB.Append($"{_authAttr2.Convert(text)}");
												return true;
											}
										}

										return true;
									}
								}
							}
							if (_memberInfo1.Name == text)
							{
								object[] _attrs1 = _memberInfo1.GetCustomAttributes(true);
								foreach (object _attr1 in _attrs1)
								{
									ToAttribute _authAttr1 = _attr1 as ToAttribute;
									if (_authAttr1 != null)
									{
										JSSB.Append($"{_authAttr1.Convert(text)}");
										return true;
									}
								}

								return true;
							}
						}
					}
					if (_memberInfo.Name == text)
					{
						object[] _attrs = _memberInfo.GetCustomAttributes(true);
						foreach (object _attr in _attrs)
						{
							ToAttribute _authAttr = _attr as ToAttribute;
							if (_authAttr != null)
							{
								JSSB.Append($"{_authAttr.Convert(text)}");
								return true;
							}
						}

						return true;
					}
				}
			}

			if (CustomCSNamesToJS(node) == false)
			{
				if (BuiltInTypesGenerics(node, iSymbol) == false)
				{
					if (_Options.Debug)
					{
						_Log.WarningLine("WARNING! Diagnostics starts ---");
						ImmutableArray<Diagnostic> diag = _Model.GetDiagnostics();
						foreach (Diagnostic item in diag)
						{
							_Log.WarningLine(item.ToString());
						}
						_Log.WarningLine("WARNING! Diagnostics ends ---");
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

		private bool CustomCSNamesToJS(SyntaxNode node) 
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

		private bool BuiltInTypesGenerics(SyntaxNode nodeL, ISymbol symbol) 
		{
			IdentifierNameSyntax node = nodeL as IdentifierNameSyntax;

			if (symbol == null) 
			{
				_Log.WarningLine($"WARNING! node: \"{node}\", symbol is null. USE \"CustomCSNamesToJS\"!");
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
					_Log.WarningLine($"WARNING! node: \"{node}\", typeSymbol is \"{typeSymbol.Kind}\". USE \"CustomCSNamesToJS\"!");
					return false;
				}
			}

			string typeName = typeSymbol.Name;
			ToAttribute toAttribute = new(ToAttribute.Default);

			switch (typeName)
			{
				case string str when str.Contains(nameof(System.Text.Json.JsonSerializer)): 
					{
						string _name = symbol.Name;
						switch (_name)
						{
							case string _str when _str == typeName:
								{
									JSSB.Append($"JSON");
									return true;
								}
							case string _str when _str.Contains(nameof(System.Text.Json.JsonSerializer.Deserialize)):
								{
									JSSB.Append($"parse");
									return true;
								}
							case string _str when _str.Contains(nameof(System.Text.Json.JsonSerializer.Serialize)):
								{
									JSSB.Append($"stringify");
									return true;
								}
							default:
								_Log.WarningLine($"WARNING! node: \"{node}\", typeSymbol: \"{typeSymbol}\", symbol: \"{symbol}\", Is not supported! USE \"CustomCSNamesToJS\"");
								return false;
						}
					}
				case string str when str.Contains(nameof(Console)):
					{
						string _name = symbol.Name;
						switch (_name)
						{
							case string _str when _str == typeName:
								{
									toAttribute.To = ToAttribute.FirstCharToLowerCase;
									JSSB.Append($"{toAttribute.Convert(node.Identifier.Text)}");
									return true;
								}
							case string _str when 
							_str.Contains(nameof(Console.WriteLine)) ||
							_str.Contains(nameof(Console.Write)):
								{
									JSSB.Append($"log");
									return true;
								}
							default:
								_Log.WarningLine($"WARNING! node: \"{node}\", typeSymbol: \"{typeSymbol}\", symbol: \"{symbol}\", Is not supported! USE \"CustomCSNamesToJS\"");
								return false;
						}
					}
				case string str when str.Contains(nameof(List<dynamic>)):
					{
						string _name = symbol.Name;
						switch (_name)
						{
							case string _str when _str == typeName:
								{
									JSSB.Append($"Array");
									return true;
								}
							case string _str when 
							_str.Contains(nameof(List<dynamic>.Sort)) || 
							_str.Contains(nameof(List<dynamic>.FindLast)):
								{
									toAttribute.To = ToAttribute.FirstCharToLowerCase;
									JSSB.Append($"{toAttribute.Convert(node.Identifier.Text)}");
									return true;
								}
							case string _str when _str.Contains(nameof(List<dynamic>.Count)):
								{
									JSSB.Append($"length");
									return true;
								}
							case string _str when _str.Contains(nameof(List<dynamic>.Add)):
								{
									JSSB.Append($"push");
									return true;
								}
							case string _str when _str.Contains(nameof(List<dynamic>.Contains)):
								{
									JSSB.Append($"includes");
									return true;
								}
							default:
								_Log.WarningLine($"WARNING! node: \"{node}\", typeSymbol: \"{typeSymbol}\", symbol: \"{symbol}\", Is not supported! USE \"CustomCSNamesToJS\"");
								return false;
						}
					}
				case string str when str.Contains(nameof(String)):
					{
						string _name = symbol.Name;
						switch (_name)
						{
							case string _str when _str.Contains(nameof(string.Contains)):
								{
									JSSB.Append($"includes");
									return true;
								}
							case string _str when
							_str.Contains(nameof(string.Length)) ||
							_str.Contains(nameof(string.Trim)) ||
							_str.Contains(nameof(string.Substring)) ||
							_str.Contains(nameof(string.StartsWith)) ||
							_str.Contains(nameof(string.Replace)):
								{
									toAttribute.To = ToAttribute.FirstCharToLowerCase;
									JSSB.Append($"{toAttribute.Convert(node.Identifier.Text)}");
									return true;
								}
							default:
								_Log.WarningLine($"WARNING! node: \"{node}\", typeSymbol: \"{typeSymbol}\", symbol: \"{symbol}\", Is not supported! USE \"CustomCSNamesToJS\"");
								return false;
						}
					}
				case string str when str.Contains(nameof(System.Threading.Tasks.Task<dynamic>)):
					{
						string _name = symbol.Name;
						switch (_name)
						{
							case string _str when _str.Contains(nameof(System.Threading.Tasks.Task.ContinueWith)):
								{
									JSSB.Append($"then");
									return true;
								}
							default:
								_Log.WarningLine($"WARNING! node: \"{node}\", typeSymbol: \"{typeSymbol}\", symbol: \"{symbol}\", Is not supported! USE \"CustomCSNamesToJS\"");
								return false;
						}
					}
				case string str when str.Contains(nameof(Array)):
					{
						string _name = symbol.Name;
						switch (_name)
						{
							case string _str when _str.Contains(nameof(Array.Length)):
								{
									toAttribute.To = ToAttribute.FirstCharToLowerCase;
									JSSB.Append($"{toAttribute.Convert(node.Identifier.Text)}");
									return true;
								}
							default:
								_Log.WarningLine($"WARNING! node: \"{node}\", typeSymbol: \"{typeSymbol}\", symbol: \"{symbol}\", Is not supported! USE \"CustomCSNamesToJS\"");
								return false;
						}
					}
				case string str when str.Contains(nameof(Math)):
					{
						string _name = symbol.Name;
						switch (_name)
						{
							case string _str when _str == typeName:
								{
									JSSB.Append(nameof(Math));
									return true;
								}
							case string _str when _str.Contains(nameof(Math.Sqrt)):
								{
									toAttribute.To = ToAttribute.FirstCharToLowerCase;
									JSSB.Append($"{toAttribute.Convert(node.Identifier.Text)}");
									return true;
								}
							default:
								_Log.WarningLine($"WARNING! node: \"{node}\", typeSymbol: \"{typeSymbol}\", symbol: \"{symbol}\", Is not supported! USE \"CustomCSNamesToJS\"");
								return false;
						}
					}
				default:
					_Log.WarningLine($"WARNING! typeSymbol: \"{typeSymbol}\" Is not supported! USE \"CustomCSNamesToJS\"");
					return false;
			}
		}
	}
}
