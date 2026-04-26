using CSharpToJavaScript.Utils;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Globalization;

namespace CSharpToJavaScript;

internal class WithoutSemanticRewriter : CSharpSyntaxRewriter
{
	private readonly CSTOJSOptions _Options;
	public static SyntaxAnnotation StaticConstructor { get; set; } = new("StaticConstructor");
	
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

				SyntaxToken? _static = TryGetModifier(SyntaxKind.StaticKeyword, _prop.Modifiers);
								
				if (_prop.AccessorList != null)
				{
					//TODO! do MakePropertiesEnumerable
					//in seperate rewriter before WithoutSemanticRewriter
					int _constructorIndex = -1;
					string _enumProp = $"Object.defineProperty(this, '{_prop.Identifier}', {{ enumerable: true, ";
					
					if (_Options.MakePropertiesEnumerable)
					{
						for (int j = 0; j < node.Members.Count; j++)
						{
							if (node.Members[j] is ConstructorDeclarationSyntax)
							{
								_constructorIndex = j;
								break;
							}
						}
					}
					
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
								
						if (_static != null)
							_field = _field.WithoutLeadingTrivia().WithModifiers(SyntaxFactory.TokenList((SyntaxToken)_static));

						node = node.ReplaceNode(node.Members[i], _field);

						if (_getSetStr.Contains("get;"))
						{
							if (_Options.MakePropertiesEnumerable)
							{
									_enumProp += $"get: function() {{ return this.{_fieldIdentifier}; }}";
							}
							else
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

								if (_static != null)
									_getM = _getM.WithoutLeadingTrivia().WithModifiers(SyntaxFactory.TokenList((SyntaxToken)_static));

								node = node.WithMembers(node.Members.Insert(_indexToInsert++, _getM));
							}
						}
						if (_getSetStr.Contains("get;") && _getSetStr.Contains("set;"))
						{
							if (_Options.MakePropertiesEnumerable)
							{
									_enumProp += $", set: function (value) {{ this.{_fieldIdentifier} = value; }} }}";
							}
							else
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
							
								if (_static != null)
									_setM = _setM.WithoutLeadingTrivia().WithModifiers(SyntaxFactory.TokenList((SyntaxToken)_static));

								node = node.WithMembers(node.Members.Insert(_indexToInsert++, _setM));
							}
						}

						if (_constructorIndex == -1)
						{
							Log.WarningLine($"Constructor is 'null' for: {node.Identifier}. MakePropertiesEnumerable is ignored!");

						}
						else
						{
							_enumProp += ")";

							ConstructorDeclarationSyntax _constr = (ConstructorDeclarationSyntax)node.Members[_constructorIndex];

							node = node.ReplaceNode(_constr.Body,
								_constr.Body.WithStatements(_constr.Body.Statements.Insert(0,
										SyntaxFactory.ExpressionStatement(
											SyntaxFactory.IdentifierName(_enumProp))
											.WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed))).WithLeadingTrivia(_constr.Body.GetLeadingTrivia()).WithTrailingTrivia(_constr.Body.GetTrailingTrivia()));
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

								if (_static != null)
									_getM = _getM.WithModifiers(SyntaxFactory.TokenList((SyntaxToken)_static));

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
								
								if (_static != null)
									_setM = _setM.WithModifiers(SyntaxFactory.TokenList((SyntaxToken)_static));

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

		SyntaxToken? staticModifier = TryGetModifier(SyntaxKind.StaticKeyword, node.Modifiers);
		
		if (staticModifier == null)
			node = node.ReplaceToken(node.Identifier, SyntaxFactory.Identifier("constructor").WithLeadingTrivia(node.Identifier.LeadingTrivia));
		else
			node = node.ReplaceToken(node.Identifier, SyntaxFactory.Identifier("static").WithLeadingTrivia(node.Identifier.LeadingTrivia).WithAdditionalAnnotations(StaticConstructor));

		if (node.Modifiers.Count >= 1)
		{
			node = node.ReplaceToken(node.Identifier, node.Identifier.WithLeadingTrivia(node.Modifiers[0].LeadingTrivia));
			node = node.ReplaceTokens(node.Modifiers, (o, r) => SyntaxFactory.Token(SyntaxKind.None));
		}

		if (node.Initializer != null)
		{
			ArgumentListSyntax _args = node.Initializer.ArgumentList.WithoutTrailingTrivia();
			node = node.RemoveNode(node.Initializer, SyntaxRemoveOptions.KeepTrailingTrivia);

			ExpressionStatementSyntax _super = SyntaxFactory.ExpressionStatement(
				SyntaxFactory.InvocationExpression(SyntaxFactory.IdentifierName("super"), _args));

			if (node.Body.Statements.Count > 0)
				_super = _super.WithLeadingTrivia(node.Body.Statements[0].GetLeadingTrivia()).WithTrailingTrivia(node.Body.Statements[0].GetTrailingTrivia());
		
			node = node.ReplaceNode(node.Body, node.Body.WithStatements(node.Body.Statements.Insert(0, _super)));
		}
		
		return node;
	}
	public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax node)
	{
		node = (FieldDeclarationSyntax)base.VisitFieldDeclaration(node)!;

		if (node.Modifiers.Count >= 1)
		{
			SyntaxToken? _static = TryGetModifier(SyntaxKind.StaticKeyword, node.Modifiers);
			
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
			SyntaxToken? _static = TryGetModifier(SyntaxKind.StaticKeyword ,node.Modifiers);
			SyntaxToken? _async = TryGetModifier(SyntaxKind.AsyncKeyword, node.Modifiers);

			if (_static == null && _async == null)
			{
				node = node.ReplaceToken(node.Identifier, node.Identifier.WithLeadingTrivia(node.Modifiers[0].LeadingTrivia));
				node = node.ReplaceTokens(node.Modifiers, (o, r) => SyntaxFactory.Token(SyntaxKind.None));
			}
			else if(_async == null)
			{
				//Clear modifiers first.
				node = node.ReplaceTokens(node.Modifiers, (o, r) => SyntaxFactory.Token(SyntaxKind.None));
				//Add static modifier.
				node = node.WithModifiers(SyntaxFactory.TokenList((SyntaxToken)_static));
			}
			else if (_static == null)
			{
				//Clear modifiers first.
				node = node.ReplaceTokens(node.Modifiers, (o, r) => SyntaxFactory.Token(SyntaxKind.None));
				//Add async modifier.
				node = node.WithModifiers(SyntaxFactory.TokenList((SyntaxToken)_async));
			}
			else
			{
				//Clear modifiers first.
				node = node.ReplaceTokens(node.Modifiers, (o, r) => SyntaxFactory.Token(SyntaxKind.None));
				//clear leading trivia for async
				_async = _async.Value.WithoutTrivia().WithTrailingTrivia(_async.Value.TrailingTrivia);
				//Add static and async modifier.
				node = node.WithModifiers(SyntaxFactory.TokenList((SyntaxToken)_static, (SyntaxToken)_async));
			}
		}

		return node;
	}
	public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)
	{
		node = (PropertyDeclarationSyntax)base.VisitPropertyDeclaration(node)!;

		if (node.Modifiers.Count >= 1)
		{
			SyntaxToken? _static = TryGetModifier(SyntaxKind.StaticKeyword, node.Modifiers);
			
			if (_static == null)
			{
				node = node.ReplaceNode(node.Type, node.Type.WithLeadingTrivia(node.Modifiers[0].LeadingTrivia).WithTrailingTrivia(node.Modifiers[0].TrailingTrivia));
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

		node = node.ReplaceNode(node.Type, SyntaxFactory.IdentifierName("").WithLeadingTrivia(node.Type.GetLeadingTrivia()));

		return node;
	}
	public override SyntaxNode? VisitLocalFunctionStatement(LocalFunctionStatementSyntax node)
	{
		node = (LocalFunctionStatementSyntax)base.VisitLocalFunctionStatement(node)!;

		node = node.ReplaceNode(node.ReturnType, SyntaxFactory.IdentifierName("function").WithLeadingTrivia(node.ReturnType.GetLeadingTrivia()).WithTrailingTrivia(node.ReturnType.GetTrailingTrivia()));

		return node;
	}
	public override SyntaxNode? VisitObjectCreationExpression(ObjectCreationExpressionSyntax node)
	{
		node = (ObjectCreationExpressionSyntax)base.VisitObjectCreationExpression(node)!;

		if (node.Type.HasAnnotation(ToObjectAttribute.Annotation))
		{
			SyntaxTriviaList trivias = node.ArgumentList.GetTrailingTrivia();
			trivias = trivias.AddRange(node.Initializer.GetLeadingTrivia());

			return node.Initializer.WithLeadingTrivia(trivias);
		}
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
		node = (ParameterSyntax)base.VisitParameter(node)!;

		return SyntaxFactory.Parameter(attributeLists: node.AttributeLists, modifiers: node.Modifiers, type: null, identifier: node.Identifier, @default: node.Default);
	}
	public override SyntaxNode? VisitArrayCreationExpression(ArrayCreationExpressionSyntax node)
	{
		node = (ArrayCreationExpressionSyntax)base.VisitArrayCreationExpression(node)!;

		InitializerExpressionSyntax? initializer = node.Initializer;
		ArgumentListSyntax arguments = SyntaxFactory.ArgumentList(); 
		
		if (initializer != null)
		{
			List<ArgumentSyntax> _list = new();
			for (int i = 0; i < initializer.Expressions.Count; i++)
			{
				_list.Add(SyntaxFactory.Argument(initializer.Expressions[i]));
			}
			arguments = arguments.WithArguments(SyntaxFactory.SeparatedList<ArgumentSyntax>(_list));
		}
		ObjectCreationExpressionSyntax obj = SyntaxFactory.ObjectCreationExpression(node.NewKeyword, SyntaxFactory.IdentifierName("Array"), argumentList: arguments, initializer: null);
		
		return obj;
	}
	public override SyntaxNode? VisitCatchDeclaration(CatchDeclarationSyntax node)
	{
		node = (CatchDeclarationSyntax)base.VisitCatchDeclaration(node)!;
		node = node.ReplaceNode(node.Type, SyntaxFactory.IdentifierName(""));
		return node;
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
	public override SyntaxNode? VisitLiteralExpression(LiteralExpressionSyntax node)
	{
		node = (LiteralExpressionSyntax)base.VisitLiteralExpression(node)!;
		if (node.IsKind(SyntaxKind.NumericLiteralExpression))
		{
			string _value = node.Token.Text;

			_value = _value.Replace("_", "");

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

			if (node.Token.Text != _value)
			{
				//see source code for literal
				//return Literal(SymbolDisplay.FormatLiteral(value, quote: true), value);
				node = node.ReplaceToken(node.Token, SyntaxFactory.Literal(SymbolDisplay.FormatLiteral(_value, quote: false), _value).WithLeadingTrivia(node.GetLeadingTrivia()).WithTrailingTrivia(node.GetTrailingTrivia()));
			}
		}
		return node;
	}
	public override SyntaxNode? VisitGenericName(GenericNameSyntax node)
	{
		return SyntaxFactory.IdentifierName(node.Identifier);
	}
	public override SyntaxNode? VisitEnumDeclaration(EnumDeclarationSyntax node)
	{
		node = (EnumDeclarationSyntax)base.VisitEnumDeclaration(node)!;

		List<ExpressionSyntax> enumMembers = new();

		for (int i = 0; i < node.Members.Count; i++)
		{
			enumMembers.Add(SyntaxFactory.AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
							SyntaxFactory.IdentifierName(node.Members[i].Identifier).WithLeadingTrivia(node.Members[i].Identifier.LeadingTrivia).WithTrailingTrivia(node.Members[i].Identifier.TrailingTrivia),
							node.Members[i].EqualsValue == null ? SyntaxFactory.LiteralExpression(SyntaxKind.NullLiteralExpression, SyntaxFactory.Literal(i)) : node.Members[i].EqualsValue.Value).NormalizeWhitespace());
		}

		GlobalStatementSyntax local = SyntaxFactory.GlobalStatement(SyntaxFactory.LocalDeclarationStatement(
			SyntaxFactory.VariableDeclaration(
				SyntaxFactory.IdentifierName("const").WithLeadingTrivia(node.EnumKeyword.LeadingTrivia).WithTrailingTrivia(node.EnumKeyword.TrailingTrivia),
				SyntaxFactory.SingletonSeparatedList<VariableDeclaratorSyntax>(
					SyntaxFactory.VariableDeclarator(node.Identifier,
					argumentList: null,
					initializer: SyntaxFactory.EqualsValueClause(SyntaxFactory.Token(SyntaxKind.EqualsToken).WithLeadingTrivia(SyntaxFactory.Whitespace(" ")).WithTrailingTrivia(SyntaxFactory.Whitespace(" ")),
						SyntaxFactory.InitializerExpression(SyntaxKind.ArrayInitializerExpression, SyntaxFactory.SeparatedList<ExpressionSyntax>(enumMembers)))))))).WithTrailingTrivia(node.CloseBraceToken.TrailingTrivia);

		return local;
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
	public override SyntaxNode? VisitExternAliasDirective(ExternAliasDirectiveSyntax node)
	{
		return null;
	}
	public override SyntaxNode? VisitDelegateDeclaration(DelegateDeclarationSyntax node)
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
	public override SyntaxNode? VisitEventDeclaration(EventDeclarationSyntax node)
	{
		return null;
	}
	public override SyntaxNode? VisitUsingStatement(UsingStatementSyntax node)
	{
		return null;
	}
	public override SyntaxNode? VisitUnsafeStatement(UnsafeStatementSyntax node)
	{
		return null;
	}
	public override SyntaxNode? VisitOperatorDeclaration(OperatorDeclarationSyntax node)
	{
		return null;
	}
	public override SyntaxNode? VisitConversionOperatorDeclaration(ConversionOperatorDeclarationSyntax node)
	{
		return null;
	}
	public override SyntaxNode? VisitIndexerDeclaration(IndexerDeclarationSyntax node)
	{
		return null;
	}
	public override SyntaxNode? VisitLockStatement(LockStatementSyntax node)
	{
		return null;
	}
	public override SyntaxNode? VisitFixedStatement(FixedStatementSyntax node)
	{
		return null;
	}
	public override SyntaxNode? VisitCheckedStatement(CheckedStatementSyntax node)
	{
		return null;
	}

	private static SyntaxToken? TryGetModifier(SyntaxKind keyword, SyntaxTokenList modifiers)
	{
		SyntaxToken? mod = null;
		for (int i = 0; i < modifiers.Count; i++)
		{
			if (modifiers[i].IsKind(keyword))
			{
				mod = SyntaxFactory.Token(keyword).WithLeadingTrivia(modifiers[0].LeadingTrivia).WithTrailingTrivia(modifiers[0].TrailingTrivia);
				break;
			}
		}
		return mod;
	}
}

internal class KeepBraceOnTheSameLineRewriter : CSharpSyntaxRewriter
{
	private SyntaxToken? _ReplacedPreviousToken = null;
	public override SyntaxToken VisitToken(SyntaxToken token)
	{
		if (token.IsKind(SyntaxKind.OpenBraceToken))
		{
			if (_ReplacedPreviousToken != null)
			{
				_ReplacedPreviousToken = null;
				token = token.WithLeadingTrivia(SyntaxFactory.Space);
				return token;
			}
		}

		SyntaxToken _nextToken = token.GetNextToken();
		
		if (_nextToken.IsKind(SyntaxKind.OpenBraceToken))
		{
			if (token.HasTrailingTrivia)
			{
				SyntaxTriviaList trivias = token.TrailingTrivia;

				for (int i = 0; i < trivias.Count; i++)
				{
					if (trivias[i].IsKind(SyntaxKind.EndOfLineTrivia))
					{
						token = token.WithoutTrivia().WithLeadingTrivia(token.LeadingTrivia);
						_ReplacedPreviousToken = token;
						return token;
					}
				}
			}
		}
		return base.VisitToken(token);
	}

}