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
    //TODO maybe...
    //https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/get-started/syntax-transformation
    //

    internal class Walker : CSharpSyntaxWalker, ILog
	{
		public StringBuilder JSSB { get; set; } = new();


		private readonly ILog? _Log = null;
		private readonly CSTOJSOptions? _Options = null;
		private readonly SemanticModel? _Model = null;


		private SyntaxNode? _SNOriginal = null;
		private SyntaxNode? _BaseConstructorInitializerNode = null;

		private string _NameSpaceStr = string.Empty;

		private bool _PropertyStatic = false;
		private bool _ConstKeyword = false;

		public Walker(CSTOJSOptions options, SemanticModel? model) : base(SyntaxWalkerDepth.Trivia)
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
				case SyntaxKind.OpenBraceToken:
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
				case SyntaxKind.EndOfFileToken:
					{
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
						case SyntaxKind.InternalKeyword:
							break;
						case SyntaxKind.PublicKeyword:
							VisitLeadingTrivia(asToken);
							break;
						case SyntaxKind.OpenBraceToken:
						case SyntaxKind.CloseBraceToken:
						case SyntaxKind.ClassKeyword:
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
						case SyntaxKind.BaseConstructorInitializer:
							_BaseConstructorInitializerNode = asNode;
							SyntaxTriviaList _syntaxTrivias = asNode.GetTrailingTrivia();
							for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
							{
								VisitTrivia(_syntaxTrivias[_i]);
							}
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
							{
								VisitExpressionStatement(asNode as ExpressionStatementSyntax);
								break;
							}
						case SyntaxKind.ForEachStatement: 
							{
								VisitForEachStatement(asNode as ForEachStatementSyntax);
								break;
							}
						case SyntaxKind.LocalDeclarationStatement:
							{
								VisitLocalDeclarationStatement(asNode as LocalDeclarationStatementSyntax);
								break;
							}
						case SyntaxKind.ReturnStatement:
						case SyntaxKind.IfStatement:
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
							{
								VisitToken(asToken);
								break;
							}
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
							{
								VisitVariableDeclaration(asNode as VariableDeclarationSyntax);
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
						case SyntaxKind.ConstKeyword:
							{
								_ConstKeyword = true;
								VisitToken(asToken);
								break;
							}
						case SyntaxKind.SemicolonToken:
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
							{
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
						case SyntaxKind.SemicolonToken:
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
							{
								VisitAnonymousObjectCreationExpression(asNode as AnonymousObjectCreationExpressionSyntax);
								break;
							}
						case SyntaxKind.SimpleMemberAccessExpression:
						case SyntaxKind.ElementAccessExpression:
							{
								Visit(asNode);
								break;
							}
						case SyntaxKind.IdentifierName:
							{
								VisitIdentifierName(asNode as IdentifierNameSyntax);
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
							{
								JSSB.Append(':');
								break;
							}
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
						case SyntaxKind.SemicolonToken:
							VisitToken(asToken);
							break;
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

							FieldDeclarationSyntax field = null;

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
						case SyntaxKind.PredefinedType:
						case SyntaxKind.IdentifierName:
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

			for (int i = 0; i < nodesAndTokens.Count; i++)
			{
				SyntaxNode? asNode = nodesAndTokens[i].AsNode();

				if (asNode != null)
				{
					SyntaxKind kind = asNode.Kind();

					switch (kind)
					{
						case SyntaxKind.LogicalOrExpression:
						case SyntaxKind.AddExpression:
							Visit(asNode);
							break;
						case SyntaxKind.AsExpression:

							//Todo double/multiply asExpression?? How?
							_SNOriginal = (asNode as BinaryExpressionSyntax).Left;
							
							Visit(_SNOriginal.WithoutTrailingTrivia());
							
							_SNOriginal = null;
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
							VisitLeadingTrivia(asToken);
							VisitTrailingTrivia(asToken);
							break;
						case SyntaxKind.CloseParenToken:
							break;
						//case SyntaxKind.StringLiteralToken:
							//VisitToken(asToken);
							//break;
						default:
							_Log.ErrorLine($"asToken : {kind}");
							break;
					}
				}
			}
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
						case SyntaxKind.PredefinedType:
							break;
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
						case SyntaxKind.ArgumentList:
							Visit(asNode);
							break;
						case SyntaxKind.IdentifierName:
							{
								VisitIdentifierName(asNode as IdentifierNameSyntax);
								break;
							}
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
							VisitLeadingTrivia(asToken);
							JSSB.Append($"super");
							break;
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
							{
								VisitTypeArgumentList(asNode as TypeArgumentListSyntax);
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
					/*
					if (iSymbol.DeclaringSyntaxReferences.Length >= 0) 
					{
						if (_UsedThis == false)
						{
							_UsedThis = true;

							VisitLeadingTrivia(identifier);

							JSSB.Append($"this.");
							VisitToken(identifier.WithoutTrivia());

							VisitTrailingTrivia(identifier);

							return true;
						}
					}
										
					IEnumerable<SyntaxNode?> _all = from e in node.Parent.ChildNodes()
													where e.IsKind(SyntaxKind.IdentifierName)
													select e;

					if (!_all.Any()) 
					{
						_all = from e in node.Parent.ChildNodes()
							   where e.IsKind(SyntaxKind.GenericName)
							   select e;
					}

					SymbolInfo _symbolInfo = _Model.GetSymbolInfo(_all.First());
					ISymbol? _iSymbol = null;

					if (_symbolInfo.CandidateSymbols.Length >= 1)
						_iSymbol = _symbolInfo.CandidateSymbols[0];
					else
						_iSymbol = _symbolInfo.Symbol;

					if (_iSymbol != null && _iSymbol.Kind == SymbolKind.Local)
					{
						//TODO! TEST THIS!
						//DO NOT REMOVE BREAKPOINT TEST THIS!
						//return false;
					}*/

					ClassDeclarationSyntax _class = (ClassDeclarationSyntax)node.Ancestors().First(n => n.Kind() == SyntaxKind.ClassDeclaration);
					var a = _class.Members;
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
								!node.Parent.Parent.IsKind(SyntaxKind.SimpleAssignmentExpression)) 
							{
								DataFlowAnalysis _dfa = _Model.AnalyzeDataFlow(node);

								if (_dfa.Succeeded == false)
									_dfa = _Model.AnalyzeDataFlow(node.Parent);

								if (_dfa.Succeeded == true)
								{
									if (_dfa.WrittenOutside[0].Name == "this" || iSymbol.IsStatic)
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
							case string _str when _str.Contains(nameof(Console.WriteLine)):
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
							case string _str when _str.Contains(nameof(List<dynamic>.Sort)):
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
				default:
					_Log.WarningLine($"WARNING! typeSymbol: \"{typeSymbol}\" Is not supported! USE \"CustomCSNamesToJS\"");
					return false;
			}
		}
	}
}
