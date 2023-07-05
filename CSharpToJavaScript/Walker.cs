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

	internal class Walker : CSharpSyntaxWalker
	{
		public StringBuilder JSSB { get; set; } = new();

		private CSTOJSOptions _Options = new();

		private SyntaxNode? _SNOriginal = null;
		private SyntaxNode? _BaseConstructorInitializerNode = null;

		private string _NameSpaceStr = string.Empty;
		private bool _UsedThis = false;

		public Walker() : base(SyntaxWalkerDepth.Trivia)
		{

		}
		public Walker(CSTOJSOptions options) : base(SyntaxWalkerDepth.Trivia)
		{
			_Options = options;
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
					SM.Log($"{syntaxKind}");
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
				case SyntaxKind.EndOfFileToken:
					{
						VisitLeadingTrivia(token);

						JSSB.Append(token.Text);

						VisitTrailingTrivia(token);
						return;
					}
				default:
					SM.Log($"{syntaxKind}");
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
						case SyntaxKind.BaseList:
						case SyntaxKind.FieldDeclaration:
						case SyntaxKind.ConstructorDeclaration:
						case SyntaxKind.MethodDeclaration:
						case SyntaxKind.PropertyDeclaration:
							Visit(asNode);
							break;
						default:
							SM.Log($"asNode : {kind}");
							break;
					}
				}
				else
				{
					SyntaxToken asToken = nodesAndTokens[i].AsToken();
					SyntaxKind kind = asToken.Kind();

					switch (kind)
					{
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
							SM.Log($"asToken : {kind}");
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
							break;
						case SyntaxKind.ParameterList:
						case SyntaxKind.Block:
							Visit(asNode);
							break;
						default:
							SM.Log($"asNode : {kind}");
							break;
					}
				}
				else
				{
					SyntaxToken asToken = nodesAndTokens[i].AsToken();
					SyntaxKind kind = asToken.Kind();

					switch (kind)
					{
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
							SM.Log($"asToken : {kind}");

							break;
					}
				}
			}
			_BaseConstructorInitializerNode = null;
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
						case SyntaxKind.GenericName:
						case SyntaxKind.IdentifierName:
						case SyntaxKind.PredefinedType:
							break;
						default:
							SM.Log($"asNode : {kind}");
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
							SM.Log($"asToken : {kind}");
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
						case SyntaxKind.LocalDeclarationStatement: 
							{
								Visit(asNode);
								break;
							}
						case SyntaxKind.ExpressionStatement: 
							{
								VisitExpressionStatement(asNode as ExpressionStatementSyntax);
								break;
							}
						case SyntaxKind.ReturnStatement:
						case SyntaxKind.IfStatement:
						case SyntaxKind.ForStatement:
						case SyntaxKind.BreakStatement:
						case SyntaxKind.SwitchStatement:
						case SyntaxKind.ContinueStatement:
							Visit(asNode);
							break;
						default:
							SM.Log($"asNode : {kind}");
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
								}
								break;
							}
						default:
							SM.Log($"asToken : {kind}");
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
							{
								_UsedThis = false;
								Visit(asNode);
								_UsedThis = false;
								break;
							}
						default:
							SM.Log($"asNode : {kind}");
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
							SM.Log($"asToken : {kind}");
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
						case SyntaxKind.ElementAccessExpression:
						case SyntaxKind.FalseLiteralExpression:
						case SyntaxKind.TrueLiteralExpression:
						case SyntaxKind.StringLiteralExpression:
							{
								Visit(asNode);
								break;
							}
						case SyntaxKind.IdentifierName:
						case SyntaxKind.SimpleMemberAccessExpression:
							{
								_UsedThis = false;
								Visit(asNode);
								_UsedThis = false;
								break;
							}
						default:
							SM.Log($"asNode : {kind}");
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
							SM.Log($"asToken : {kind}");

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
							SM.Log($"asNode : {kind}");
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
						case SyntaxKind.AsyncKeyword:
						case SyntaxKind.IdentifierToken:
							{
								VisitToken(asToken);
								break;
							}
						default:
							SM.Log($"asToken : {kind}");

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
							SM.Log($"asNode : {kind}");
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
							SM.Log($"asToken : {kind}");
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

						if (asNode.ToString() == "{ get; set; }") 
						{
							var key = from n in nodesAndTokens
									  where n.IsNode
									  where n.AsNode().Kind() == SyntaxKind.PredefinedType
									  select n;

							FieldDeclarationSyntax field = null;

							if (key.Count() == 0)
							{
								key = from n in nodesAndTokens
									  where n.IsNode
									  where n.AsNode().Kind() == SyntaxKind.IdentifierName
									  select n;

								field = SyntaxFactory.FieldDeclaration(
							   SyntaxFactory.VariableDeclaration(SyntaxFactory.IdentifierName(key.First().ToString()))
							.WithVariables(
								   SyntaxFactory.SingletonSeparatedList(
									   SyntaxFactory.VariableDeclarator(
										   SyntaxFactory.Identifier("_" + nodesAndTokens[i - 1].AsToken().ToString() + "_")))))
						   .WithModifiers(
							   SyntaxFactory.TokenList(new[]
							   {
									SyntaxFactory.Token(SyntaxKind.PrivateKeyword)
							   }))
						   .WithLeadingTrivia(SyntaxFactory.ParseLeadingTrivia("\t\t"));
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
										   SyntaxFactory.Identifier("_" + nodesAndTokens[i - 1].AsToken().ToString() + "_")))))
						   .WithModifiers(
							   SyntaxFactory.TokenList(new[]
							   {
									SyntaxFactory.Token(SyntaxKind.PrivateKeyword)
							   }))
						   .WithLeadingTrivia(SyntaxFactory.ParseLeadingTrivia("\t\t"));
							}

							VisitFieldDeclaration(field);
							break;
						}
					}
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
							break;
						case SyntaxKind.AccessorList:
							Visit(asNode);
							break;
						default:
							SM.Log($"asNode : {kind}");
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
						default:
							SM.Log($"asToken : {kind}");
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
								var c = asNode.Ancestors();

								var a = from b in c
										where b.Kind() == SyntaxKind.PropertyDeclaration
										select b;
								var d2 = from e in a.First().ChildNodesAndTokens()
										 where e.Kind() == SyntaxKind.IdentifierToken
										 select e;
								
								dynamic d3 = null;
								if (d2.Count() >= 2) 
								{
									//Delete this? TODO
									d2 = from e in a.First().DescendantNodesAndTokens()
										 where e.Kind() == SyntaxKind.IdentifierName
										 select e;
									d3 = d2.First().ChildNodesAndTokens().First().AsToken();
								}else
									d3 = d2.First().AsToken();

								if ((asNode as AccessorDeclarationSyntax).Body != null)
								{
									SyntaxTriviaList _syntaxTrivias = asNode.Parent.Parent.GetLeadingTrivia();

									for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
									{
										VisitTrivia(_syntaxTrivias[_i]);
									}

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
									JSSB.Append($"\n");

									SyntaxTriviaList _syntaxTrivias = asNode.Parent.Parent.GetLeadingTrivia();

									for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
									{
										VisitTrivia(_syntaxTrivias[_i]);
									}

									JSSB.Append($"get {d3.Text}() {{ return this._{d3.Text}_; }}");

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

								var c = asNode.Ancestors();

								var a = from b in c
										where b.Kind() == SyntaxKind.PropertyDeclaration
										select b;
								var d2 = from e in a.First().ChildNodesAndTokens()
										 where e.Kind() == SyntaxKind.IdentifierToken
										 select e;

								var d3 = d2.First().AsToken();

								if ((asNode as AccessorDeclarationSyntax).Body != null)
								{
									SyntaxTriviaList _syntaxTrivias = asNode.Parent.Parent.GetLeadingTrivia();

									for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
									{
										VisitTrivia(_syntaxTrivias[_i]);
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
									JSSB.Append($"\n");
									SyntaxTriviaList _syntaxTrivias = asNode.Parent.Parent.GetLeadingTrivia();

									for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
									{
										VisitTrivia(_syntaxTrivias[_i]);
									}

									JSSB.Append($"set {d3.Text}(value) {{ this._{d3.Text}_ = value; }}");

									_syntaxTrivias = asNode.Parent.GetTrailingTrivia();
									for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
									{
										VisitTrivia(_syntaxTrivias[_i]);
									}
								}

								break;
							}
						default:
							SM.Log($"asNode : {kind}");
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
							SM.Log($"asToken : {kind}");
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
							SM.Log($"asNode : {kind}");
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
							SM.Log($"asToken : {kind}");

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
							{
								if (node.Parent.Kind() == SyntaxKind.LocalDeclarationStatement ||
									node.Parent.Kind() == SyntaxKind.ForStatement)
								{
									SyntaxTriviaList _syntaxTrivias = asNode.GetLeadingTrivia();

									for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
									{
										VisitTrivia(_syntaxTrivias[_i]);
									}

									if(_Options.UseVarOverLet)
										JSSB.Append("var");
									else
										JSSB.Append("let");

									_syntaxTrivias = asNode.GetTrailingTrivia();
									for (int _i = 0; _i < _syntaxTrivias.Count; _i++)
									{
										VisitTrivia(_syntaxTrivias[_i]);
									}
								}
								break;
							}
						case SyntaxKind.IdentifierName: 
							{
								if (node.Parent.Kind() == SyntaxKind.LocalDeclarationStatement ||
									node.Parent.Kind() == SyntaxKind.ForStatement)
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
								break;
							}
						case SyntaxKind.GenericName: 
							{
								if (node.Parent.Kind() == SyntaxKind.LocalDeclarationStatement ||
									node.Parent.Kind() == SyntaxKind.ForStatement)
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
								break;
							}
						case SyntaxKind.VariableDeclarator:
							Visit(asNode);
							break;
						default:
							SM.Log($"asNode : {kind}");
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
							SM.Log($"asToken : {kind}");
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
							SM.Log($"asNode : {kind}");
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
							SM.Log($"asToken : {kind}");
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
							SM.Log($"asNode : {kind}");
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
							SM.Log($"asToken : {kind}");
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
							SM.Log($"asNode : {kind}");
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
						case SyntaxKind.TrueKeyword:
						case SyntaxKind.FalseKeyword:
						case SyntaxKind.StringLiteralToken:
						case SyntaxKind.NullKeyword:
							VisitToken(asToken);
							break;
						default:
							SM.Log($"asToken : {kind}");
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
						case SyntaxKind.AddExpression:
							Visit(asNode);
							break;
						case SyntaxKind.AsExpression:
							_SNOriginal = (asNode as BinaryExpressionSyntax).Left;
							
							Visit(_SNOriginal.WithoutTrailingTrivia());
							
							_SNOriginal = null;
							break;
						default:
							SM.Log($"asNode : {kind}");
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
							SM.Log($"asToken : {kind}");
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
							SM.Log($"asNode : {kind}");
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
							SM.Log($"asToken : {kind}");
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
							SM.Log($"asNode : {kind}");
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


								VariableDeclarationSyntax _vds = node.Ancestors().FirstOrDefault(e => e.Kind() == SyntaxKind.VariableDeclaration) as VariableDeclarationSyntax;

								SymbolInfo? symbolInfo = null;
								ISymbol? iSymbol = null;
								SyntaxNode? syntaxNode = null;

								if (_vds == null)
								{
									AssignmentExpressionSyntax _aes = node.Ancestors().FirstOrDefault(e => e.Kind() == SyntaxKind.SimpleAssignmentExpression) as AssignmentExpressionSyntax;
									symbolInfo = CSTOJS.Model.GetSymbolInfo(_aes.Left);

									ClassDeclarationSyntax classD = (ClassDeclarationSyntax)node.Ancestors().First(n => n.Kind() == SyntaxKind.ClassDeclaration);
									SyntaxList<MemberDeclarationSyntax> mem = classD.Members;

									foreach (MemberDeclarationSyntax item in mem)
									{
										SyntaxToken _sT = default;
										if (item is MethodDeclarationSyntax m)
										{
											var d3 = from e in m.ChildTokens()
													 where e.Kind() == SyntaxKind.IdentifierToken
													 select e;
											_sT = d3.First();
										}

										if (item is PropertyDeclarationSyntax p)
										{
											var d3 = from e in p.DescendantTokens()
													 where e.Kind() == SyntaxKind.IdentifierToken
													 select e;
											_sT = d3.Last();
										}

										if (item is FieldDeclarationSyntax f)
										{
											var d3 = from e in f.DescendantTokens()
													 where e.Kind() == SyntaxKind.IdentifierToken
													 select e;
											_sT = d3.Last();
										}

										if (_sT.ToString() == _aes.Left.ToString())
										{
											var s = item.DescendantNodes().First(e => e.Kind() == SyntaxKind.VariableDeclaration) as VariableDeclarationSyntax;
											syntaxNode = s.Type;
										}
									}
								}
								else
								{
									symbolInfo = CSTOJS.Model.GetSymbolInfo(_vds.Type);
									syntaxNode = _vds.Type;
								}


								if (symbolInfo?.CandidateSymbols.Length >= 1)
									iSymbol = symbolInfo?.CandidateSymbols[0];
								else
									iSymbol = symbolInfo?.Symbol;

								if (iSymbol != null && iSymbol.Kind != SymbolKind.ErrorType)
								{
									if (iSymbol.ContainingNamespace.ToString().Contains(nameof(APIs.JS)))
									{
										if (CustomCSNamesToJS(syntaxNode) == false)
										{
											JSSB.Append($" Object");
											SM.Log($"TODO : {syntaxNode} ||| USE 'CustomCSNamesToJS' TO CONVERT.");
										}
										JSSB.Append($"(1)");
										return;
									}

									if (iSymbol.ContainingNamespace.ToString().Contains(_NameSpaceStr))
									{
										JSSB.Append($" {syntaxNode.ToString()}");
									}

									if (CustomCSNamesToJS(syntaxNode) == false)
									{
										SM.Log($"TODO : {syntaxNode} ||| USE 'CustomCSNamesToJS' TO CONVERT.");
									}

								}
								break;
							}
						default:
							SM.Log($"asToken : {kind}");
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
							SM.Log($"asNode : {kind}");
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
							SM.Log($"asToken : {kind}");
							break;
					}
				}
			}
		}


		public override void VisitIdentifierName(IdentifierNameSyntax node)
		{
			SymbolInfo? symbolInfo = null;
			if (_SNOriginal != null)
			{
				IEnumerable<SyntaxNodeOrToken> _identifierNameSyntax = _SNOriginal.DescendantNodesAndTokens().Where(e => e.IsToken == true);
				foreach (SyntaxNodeOrToken _item in _identifierNameSyntax)
				{
					SyntaxToken _syntaxToken = _item.AsToken();

					if (_syntaxToken.Kind() == SyntaxKind.IdentifierToken) 
					{
						if (_syntaxToken.Text == node.Identifier.Text) 
						{
							symbolInfo = CSTOJS.Model.GetSymbolInfo(_item.Parent as IdentifierNameSyntax);
							break;
						}
					}
				}
			}
			else
			{
				try
				{
					symbolInfo = CSTOJS.Model.GetSymbolInfo(node);
					if(symbolInfo == null) 
					{
						//
					}
				}
				catch (Exception e)
				{
					symbolInfo = null;
					var a = CSTOJS.Model.GetDeclarationDiagnostics();
					foreach (Diagnostic item in a)
					{
						SM.Log(item.ToString());
					}
					var b = CSTOJS.Model.GetDeclaredSymbol(node);
					SM.Log(e.ToString());
					//throw;
				}
			}

			ISymbol? iSymbol = null;
			
			if (symbolInfo?.CandidateSymbols.Length >= 1)
				iSymbol = symbolInfo?.CandidateSymbols[0];
			else
				iSymbol = symbolInfo?.Symbol;
			
			if (iSymbol != null && iSymbol.Kind != SymbolKind.ErrorType)
			{
				if (iSymbol.ContainingNamespace.ToString().Contains(nameof(APIs.JS)))
				{
					ImmutableArray<AttributeData> _attributeDatas = iSymbol.GetAttributes();
					foreach (AttributeData _attr in _attributeDatas)
					{
						if (_attr.AttributeClass.Name == nameof(ToAttribute))
						{
							ToAttribute _attrLocal = new(_attr.ConstructorArguments[0].Value as string);
							
							VisitLeadingTrivia(node.Identifier);
							JSSB.Append($"{_attrLocal.Convert(node.Identifier.Text)}");
							VisitTrailingTrivia(node.Identifier);
							return;
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
							
							VisitLeadingTrivia(node.Identifier);
							JSSB.Append($"{_attrLocal.Convert(node.Identifier.Text)}");
							VisitTrailingTrivia(node.Identifier);
							return;
							}
						}
					//}
				}

				if (iSymbol.ContainingNamespace.ToString().Contains(_NameSpaceStr)) 
				{
					if (iSymbol.Kind == SymbolKind.Parameter ||
						iSymbol.Kind == SymbolKind.Local)
					{
						base.VisitIdentifierName(node);
						return;
					}

					IEnumerable<SyntaxNode?> _all =from e in node.Parent.ChildNodes()
												   where e.Kind() == SyntaxKind.IdentifierName
												   select e;

					SymbolInfo _symbolInfo = CSTOJS.Model.GetSymbolInfo(_all.First());
					ISymbol? _iSymbol = null;

					if (_symbolInfo.CandidateSymbols.Length >= 1)
						_iSymbol = _symbolInfo.CandidateSymbols[0];
					else
						_iSymbol = _symbolInfo.Symbol;

					if (_iSymbol != null && _iSymbol.Kind == SymbolKind.Local)
					{
						base.VisitIdentifierName(node);
						return;
					}

					ClassDeclarationSyntax _class = (ClassDeclarationSyntax)node.Ancestors().First(n => n.Kind() == SyntaxKind.ClassDeclaration);
					var a = _class.Members;
					foreach (MemberDeclarationSyntax item in a)
					{
						SyntaxToken _sT = default;
						if (item is MethodDeclarationSyntax m)
						{
							var d3 = from e in m.ChildTokens()
										where e.Kind() == SyntaxKind.IdentifierToken
										select e;
							_sT = d3.First();
						}

						if (item is PropertyDeclarationSyntax p)
						{
							var d3 = from e in p.DescendantTokens()
										where e.Kind() == SyntaxKind.IdentifierToken
										select e;
							_sT = d3.Last();
						}

						if (item is FieldDeclarationSyntax f)
						{
							IEnumerable<SyntaxNode> vds = (from el in f.DescendantNodes()
														   where el.Kind() == SyntaxKind.VariableDeclarator
														   select el);

							var d3 = from e in vds.First().DescendantNodesAndTokens()
										where e.Kind() == SyntaxKind.IdentifierToken
										select e;
							
							_sT = (SyntaxToken)d3.First();
						}

						if (_sT.ToString() == node.ToString())
						{
							if (_UsedThis == false)
							{
								_UsedThis = true;
								VisitLeadingTrivia(node.Identifier);
								JSSB.Append($"this.");
								VisitToken(node.Identifier.WithoutTrivia());
								VisitTrailingTrivia(node.Identifier);

								//if (node.Parent.Parent is InvocationExpressionSyntax ||
									//node.Parent.Parent is ArgumentSyntax)
									//_UsedThis = false;

								return;
							}
						}
					}
					
					base.VisitIdentifierName(node);
					return;
				}

			}

			foreach (Type type in _Options.CustomCSTypesToJS)
			{
				if (type.Name == node.Identifier.Text) 
				{
					object[] _attrs = type.GetCustomAttributes(true);
					foreach (object _attr in _attrs)
					{
						ToAttribute _authAttr = _attr as ToAttribute;
						if (_authAttr != null)
						{
							VisitLeadingTrivia(node.Identifier);
							JSSB.Append($"{_authAttr.Convert(node.Identifier.Text)}");
							return;
						}
					}

					return;
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
									if (_memberInfo2.Name == node.Identifier.Text)
									{
										object[] _attrs2 = _memberInfo2.GetCustomAttributes(true);
										foreach (object _attr2 in _attrs2)
										{
											ToAttribute _authAttr2 = _attr2 as ToAttribute;
											if (_authAttr2 != null)
											{
												JSSB.Append($"{_authAttr2.Convert(node.Identifier.Text)}");
												return;
											}
										}

										return;
									}
								}
							}
							if (_memberInfo1.Name == node.Identifier.Text)
							{
								object[] _attrs1 = _memberInfo1.GetCustomAttributes(true);
								foreach (object _attr1 in _attrs1)
								{
									ToAttribute _authAttr1 = _attr1 as ToAttribute;
									if (_authAttr1 != null)
									{
										JSSB.Append($"{_authAttr1.Convert(node.Identifier.Text)}");
										return;
									}
								}

								return;
							}
						}
					}
					if (_memberInfo.Name == node.Identifier.Text)
					{
						object[] _attrs = _memberInfo.GetCustomAttributes(true);
						foreach (object _attr in _attrs)
						{
							ToAttribute _authAttr = _attr as ToAttribute;
							if (_authAttr != null)
							{
								JSSB.Append($"{_authAttr.Convert(node.Identifier.Text)}");
								return;
							}
						}

						return;
					}
				}
			}

			if (CustomCSNamesToJS(node) == false)
			{

				//TODO! HERE BUILDIN C# TYPES/GENERICS


				ImmutableArray<Diagnostic> diag = CSTOJS.Model.GetDiagnostics();
				foreach (Diagnostic item in diag)
				{
					SM.Log(item.ToString());
				}

				SM.Log($"ERROR! !-{node}-! By reaching this means, a name did not convert to JS. CHECK FOR UPPERCASE CHARACTERS IN NAMES IN THE JS FILE!");

				base.VisitIdentifierName(node);
			}
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
	}
}
