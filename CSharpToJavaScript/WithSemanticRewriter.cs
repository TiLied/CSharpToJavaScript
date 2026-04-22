using CSharpToJavaScript.Utils;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace CSharpToJavaScript;

internal class WithSemanticRewriter : CSharpSyntaxRewriter
{
	private readonly NETAPI _NETAPI = new();

	private readonly SemanticModel _Model;
	private readonly CSTOJSOptions _Options;

	private readonly Dictionary<string, List<string>> _ExportedClasses = new();
	
	private ITypeSymbol? _CurrentClassSymbol = null;

	private bool _NoneWithTrailingDotRemoved = false;

	public Dictionary<SyntaxNode, SyntaxNode> ReplaceNodes = new();

	public Dictionary<string, List<string>> ImportClasses = new();
	
	public WithSemanticRewriter(SemanticModel semanticModel, CSTOJSOptions options, Dictionary<string, List<string>> _exportedClasses)
	{
		_Model = semanticModel;
		_Options = options;
		_ExportedClasses = _exportedClasses;
	}

#if DEBUG
	public override SyntaxNode? Visit(SyntaxNode? node)
	{
		if (node != null)
			Log.InfoLine($"kind: {node.Kind()} \n\t{node.ToString()}");

		return base.Visit(node);
	}
#endif
	public override SyntaxNode? VisitUsingDirective(UsingDirectiveSyntax node)
	{
		return node;
	}
	public override SyntaxNode? VisitExternAliasDirective(ExternAliasDirectiveSyntax node)
	{
		return node;
	}
	public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
	{
		_CurrentClassSymbol = _Model.GetDeclaredSymbol(node);
				
		return base.VisitClassDeclaration(node);
	}
	public override SyntaxNode? VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
	{
		base.VisitMemberAccessExpression(node);

		if (_NoneWithTrailingDotRemoved)
		{
			SyntaxNode _node = node.Name;
			if (ReplaceNodes.ContainsKey(_node))
				_node = ReplaceNodes[_node];

			ReplaceNodes.Add(node, _node);
			_NoneWithTrailingDotRemoved = false;
		}

		if (node.Expression is IdentifierNameSyntax syntax)
		{
			if (TryReplaceIdentifierWithThis(syntax))
				return node;
		}
		return node;
	}
	public override SyntaxNode? VisitElementAccessExpression(ElementAccessExpressionSyntax node)
	{
		base.VisitElementAccessExpression(node);

		if (node.Expression is IdentifierNameSyntax syntax)
		{
			if (TryReplaceIdentifierWithThis(syntax))
				return node;
		}

		return node;
	}
	public override SyntaxNode? VisitInterpolation(InterpolationSyntax node)
	{
		if (node.Expression is IdentifierNameSyntax syntax)
		{
			if (TryReplaceIdentifierWithThis(syntax))
				return node;
		}
		return base.VisitInterpolation(node);
	}
	public override SyntaxNode? VisitArgument(ArgumentSyntax node)
	{
		if (node.Expression is IdentifierNameSyntax syntax)
		{
			if (TryReplaceIdentifierWithThis(syntax))
				return node;
		}
		return base.VisitArgument(node);
	}
	public override SyntaxNode? VisitInvocationExpression(InvocationExpressionSyntax node)
	{
		base.VisitInvocationExpression(node);

		if (node.Expression is IdentifierNameSyntax ||
			node.Expression is GenericNameSyntax)
		{
			ISymbol? symbol = TryGetISymbol(node.Expression);

			if (symbol != null)
			{
				if (TryReplaceIdentifierWithThis((SimpleNameSyntax)node.Expression))
					return node;

				ImmutableArray<AttributeData> _attributeData = symbol.GetAttributes();
				for (int i = 0; i < _attributeData.Length; i++)
				{
					if (_attributeData[i].AttributeClass != null)
					{
						if (_attributeData[i].AttributeClass!.Name == nameof(BinaryAttribute))
						{
							IdentifierNameSyntax _identifier = SyntaxFactory.IdentifierName(_attributeData[i].ConstructorArguments[0].Value.ToString())
							.WithAdditionalAnnotations(BinaryAttribute.Annotation)
							.WithLeadingTrivia(node.Expression.GetLeadingTrivia())
							.WithTrailingTrivia(node.Expression.GetTrailingTrivia());

							if (ReplaceNodes.ContainsKey(node.Expression))
								ReplaceNodes[node.Expression] = _identifier;
							else
								ReplaceNodes.Add(node.Expression, _identifier);

							return node;
						}
						if (_attributeData[i].AttributeClass!.Name == nameof(UnaryAttribute))
						{
							IdentifierNameSyntax _identifier = SyntaxFactory.IdentifierName(_attributeData[i].ConstructorArguments[0].Value.ToString())
							.WithAdditionalAnnotations(UnaryAttribute.Annotation)
							.WithLeadingTrivia(node.Expression.GetLeadingTrivia())
							.WithTrailingTrivia(node.Expression.GetTrailingTrivia());

							if (ReplaceNodes.ContainsKey(node.Expression))
								ReplaceNodes[node.Expression] = _identifier;
							else
								ReplaceNodes.Add(node.Expression, _identifier);

							return node;
						}
						if (_attributeData[i].AttributeClass!.Name == nameof(GenericUnaryAttribute))
						{
							TypeSyntax _arg = ((GenericNameSyntax)node.Expression).TypeArgumentList.Arguments[0];

							//Check if the generic is contained in ReplaceNodes.
							//If yes, then use the replaced node.
							//The same applies to GenericBinaryAttribute.
							if (ReplaceNodes.ContainsKey(_arg))
								_arg = (TypeSyntax)ReplaceNodes[_arg];

							//Replace GenericName with IdentifierName from an attribute.
							IdentifierNameSyntax _identifier = SyntaxFactory.IdentifierName(SyntaxFactory.Identifier(_attributeData[i].ConstructorArguments[0].Value.ToString()))
							.WithAdditionalAnnotations(UnaryAttribute.Annotation)
							.WithLeadingTrivia(node.Expression.GetLeadingTrivia())
							.WithTrailingTrivia(node.Expression.GetTrailingTrivia());

							if (ReplaceNodes.ContainsKey(node.Expression))
								ReplaceNodes[node.Expression] = _identifier;
							else
								ReplaceNodes.Add(node.Expression, _identifier);

							ReplaceNodes.Add(node.ArgumentList, node.ArgumentList
							.AddArguments(SyntaxFactory.Argument(SyntaxFactory.IdentifierName(_arg.ToString()))));

							return node;
						}
						if (_attributeData[i].AttributeClass!.Name == nameof(GenericBinaryAttribute))
						{
							TypeSyntax _arg = ((GenericNameSyntax)node.Expression).TypeArgumentList.Arguments[0];

							if (ReplaceNodes.ContainsKey(_arg))
								_arg = (TypeSyntax)ReplaceNodes[_arg];

							IdentifierNameSyntax _identifier = SyntaxFactory.IdentifierName(_attributeData[i].ConstructorArguments[0].Value.ToString())
							.WithAdditionalAnnotations(BinaryAttribute.Annotation)
							.WithLeadingTrivia(node.Expression.GetLeadingTrivia())
							.WithTrailingTrivia(node.Expression.GetTrailingTrivia());

							if (ReplaceNodes.ContainsKey(node.Expression))
								ReplaceNodes[node.Expression] = _identifier;
							else
								ReplaceNodes.Add(node.Expression, _identifier);

							ReplaceNodes.Add(node.ArgumentList, node.ArgumentList
							.AddArguments(SyntaxFactory.Argument(SyntaxFactory.IdentifierName(_arg.ToString())))
							.NormalizeWhitespace());

							return node;
						}
					}
				}
			}
		}

		if (node.Expression is MemberAccessExpressionSyntax member)
		{
			ISymbol? symbol = TryGetISymbol(member);

			if (symbol != null)
			{
				ImmutableArray<AttributeData> _attributeData = symbol.GetAttributes();
				for (int i = 0; i < _attributeData.Length; i++)
				{
					if (_attributeData[i].AttributeClass != null)
					{
						if (_attributeData[i].AttributeClass!.Name == nameof(GenericAsArgumentAttribute))
						{
							TypeSyntax _arg = ((GenericNameSyntax)member.Name).TypeArgumentList.Arguments[0];

							if (ReplaceNodes.ContainsKey(_arg))
								_arg = (TypeSyntax)ReplaceNodes[_arg];

							ReplaceNodes.Add(node.ArgumentList, node.ArgumentList
							.AddArguments(SyntaxFactory.Argument(SyntaxFactory.IdentifierName(_arg.ToString())))
							.NormalizeWhitespace());

							return node;
						}
					}
				}
			}
		}
		
		return node;
	}
	public override SyntaxNode? VisitBinaryExpression(BinaryExpressionSyntax node)
	{
		if (node.Left is IdentifierNameSyntax syntax)
		{
			TryReplaceIdentifierWithThis(syntax);
		}
		if (node.Right is IdentifierNameSyntax syntax1)
		{
			TryReplaceIdentifierWithThis(syntax1);
		}
		return base.VisitBinaryExpression(node);
	}
	public override SyntaxNode? VisitAssignmentExpression(AssignmentExpressionSyntax node)
	{
		if (node.Left is IdentifierNameSyntax syntax)
		{
			TryReplaceIdentifierWithThis(syntax);
		}
		if (node.Right is IdentifierNameSyntax syntax1)
		{
			TryReplaceIdentifierWithThis(syntax1);
		}
		return base.VisitAssignmentExpression(node);
	}
	public override SyntaxNode? VisitReturnStatement(ReturnStatementSyntax node)
	{
		if (node.Expression is IdentifierNameSyntax syntax)
		{
			TryReplaceIdentifierWithThis(syntax);
		}
		return base.VisitReturnStatement(node);
	}
	public override SyntaxNode? VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
	{
		if (node.Operand is IdentifierNameSyntax syntax)
		{
			TryReplaceIdentifierWithThis(syntax);
		}
		return base.VisitPrefixUnaryExpression(node);
	}
	public override SyntaxNode? VisitIfStatement(IfStatementSyntax node)
	{
		if (node.Condition is IdentifierNameSyntax syntax)
		{
			TryReplaceIdentifierWithThis(syntax);
		}
		return base.VisitIfStatement(node);
	}
	public override SyntaxNode? VisitCastExpression(CastExpressionSyntax node)
	{
		if (node.Expression is IdentifierNameSyntax syntax)
		{
			TryReplaceIdentifierWithThis(syntax);
		}
		return base.VisitCastExpression(node);
	}
	public override SyntaxNode? VisitObjectCreationExpression(ObjectCreationExpressionSyntax node)
	{
		base.VisitObjectCreationExpression(node);

		ISymbol? symbol = TryGetISymbol(node.Type);

		if (symbol != null)
		{
			ImmutableArray<AttributeData> _attributeData = symbol.GetAttributes();
			for (int i = 0; i < _attributeData.Length; i++)
			{
				if (_attributeData[i].AttributeClass != null)
				{
					if (_attributeData[i].AttributeClass!.Name == nameof(ToObjectAttribute))
					{
						ReplaceNodes.Add(node.Type, node.Type.WithAdditionalAnnotations(ToObjectAttribute.Annotation));
						break;
					}
				}
			}
		}

		return node;
	}
	public override SyntaxNode? VisitImplicitObjectCreationExpression(ImplicitObjectCreationExpressionSyntax node)
	{
		base.VisitImplicitObjectCreationExpression(node);

		ISymbol? symbol = TryGetISymbol(node);

		if (symbol != null)
		{
			ArgumentListSyntax _args = node.ArgumentList;
			InitializerExpressionSyntax? _initializer = node.Initializer;

			if (ReplaceNodes.ContainsKey(_args))
				_args = (ArgumentListSyntax)ReplaceNodes[_args];
			if (_initializer != null && ReplaceNodes.ContainsKey(_initializer))
				_initializer = (InitializerExpressionSyntax)ReplaceNodes[_initializer];


			SimpleNameSyntax _type = SyntaxFactory.IdentifierName(symbol.ContainingType.Name).WithLeadingTrivia(SyntaxFactory.Whitespace(" "));
			//Check if type needs to be replaced
			VisitSimpleName(_type, symbol);
			//if yes, use replaced node!			
			if (ReplaceNodes.ContainsKey(_type))
				_type = (SimpleNameSyntax)ReplaceNodes[_type];

			ReplaceNodes.Add(node, SyntaxFactory.ObjectCreationExpression(node.NewKeyword,
			_type,
			_args,
			_initializer));
		}

		return node;
	}

	public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
	{
		ISymbol? symbol = TryGetISymbol(node);

		if (_Options.EnableModules >= 2)
		{
			if (symbol != null)
				AddImportModule(symbol);
		}
	
		VisitSimpleName(node, symbol);
		return node;
	}
	public override SyntaxNode? VisitGenericName(GenericNameSyntax node)
	{
		base.VisitGenericName(node);
		VisitSimpleName(node, TryGetISymbol(node));
		return node;
	}
	public override SyntaxNode? VisitPredefinedType(PredefinedTypeSyntax node)
	{
		ISymbol? symbol = TryGetISymbol(node);

		if (symbol != null)
		{
			if (BuiltInTypesGenerics(node, symbol, out string str))
			{
				ReplaceNodes.Add(node, SyntaxFactory.IdentifierName(str).WithLeadingTrivia(node.GetLeadingTrivia()).WithTrailingTrivia(node.GetTrailingTrivia()));
				return node;
			}
		}
		return node;
	}

	private void AddImportModule(ISymbol symbol)
	{
		if (symbol.Kind == SymbolKind.NamedType &&
		symbol.DeclaredAccessibility == Accessibility.Public)
		{
			//Return it if it is not in the source files.
			if (symbol.Locations[0].IsInMetadata)
				return;
			
			if (symbol.Locations[0].SourceTree.FilePath != _CurrentClassSymbol.Locations[0].SourceTree.FilePath)
			{
				//If the symbol location is empty, 
				//return, the import requires a file path/filename.
				//Warning printed in ExportClassesWalker.VisitClassDeclaration
				if (symbol.Locations[0].SourceTree.FilePath == string.Empty)
					return;
					
				if (_ExportedClasses.TryGetValue(symbol.Locations[0].SourceTree.FilePath, out List<string>? _classes))
				{
					if (_classes.Contains(symbol.Name))
					{
						if (ImportClasses.ContainsKey(symbol.Locations[0].SourceTree.FilePath))
						{
							if (!ImportClasses[symbol.Locations[0].SourceTree.FilePath].Contains(symbol.Name))
								ImportClasses[symbol.Locations[0].SourceTree.FilePath].Add(symbol.Name);
						}
						else
							ImportClasses.Add(symbol.Locations[0].SourceTree.FilePath, new() { symbol.Name });
					}
				}
			}
		}

	}
	private bool TryReplaceIdentifierWithThis(SimpleNameSyntax identifier)
	{
		ISymbol? symbol = TryGetISymbol(identifier);

		if (symbol != null && !symbol.IsStatic)
		{
			if (((symbol.Kind == SymbolKind.Method &&
				((IMethodSymbol)symbol).MethodKind == MethodKind.Ordinary)) ||
				symbol.Kind == SymbolKind.Property ||
				symbol.Kind == SymbolKind.Field)
			{
				ITypeSymbol? _base = _CurrentClassSymbol;

				while (_base != null)
				{
					ImmutableArray<ISymbol> _members = _base.GetMembers();

					for (int i = 0; i < _members.Length; i++)
					{
						if (_members[i].Name == identifier.Identifier.Text)
						{
							MemberAccessExpressionSyntax _member = SyntaxFactory.MemberAccessExpression(
								SyntaxKind.SimpleMemberAccessExpression,
								SyntaxFactory.ThisExpression(), identifier.WithoutTrivia())
								.WithLeadingTrivia(identifier.GetLeadingTrivia())
								.WithTrailingTrivia(identifier.GetTrailingTrivia());

							ReplaceNodes.Add(identifier, _member);

							return true;
						}
					}
					_base = _base.BaseType;
				}

			}
		}

		return false;
	}
	private void VisitSimpleName(SimpleNameSyntax identifier, ISymbol? symbol)
	{
		ISymbol? oldSymbol = symbol;

		if (symbol != null)
		{
		CheckParentAttributes:

			ImmutableArray<AttributeData> _attributeData = symbol.GetAttributes();
			for (int i = 0; i < _attributeData.Length; i++)
			{
				if (_attributeData[i].AttributeClass != null)
				{
					if (_attributeData[i].AttributeClass!.Name == nameof(ValueAttribute))
					{
						string _v = _attributeData[i].ConstructorArguments[0].Value.ToString();

						ReplaceNodes.Add(identifier, SyntaxFactory.IdentifierName(_v).WithLeadingTrivia(identifier.Identifier.LeadingTrivia).WithTrailingTrivia(identifier.Identifier.TrailingTrivia));
						return;
					}

					if (_attributeData[i].AttributeClass!.Name == nameof(ToAttribute))
					{
						ToAttribute _toAttr = new(_attributeData[i].ConstructorArguments[0].Value.ToString());

						if (_toAttr.To == ToAttribute.NoneWithLeadingDotRemoved)
						{
							SyntaxNode? _mae = identifier.Parent;
							if (_mae == null)
							{
								Log.ErrorLine($"Parent of {identifier} is null");
								return;
							}
							if (_mae is not MemberAccessExpressionSyntax)
							{
								Log.ErrorLine($"Parent of {identifier} is {_mae.GetType()}. Should be MemberAccessExpressionSyntax");
								return;
							}

							//Check if node is in ReplaceNodes.
							//If yes, then use replaced node.
							SyntaxNode _node = ((MemberAccessExpressionSyntax)_mae).Expression;
							if (ReplaceNodes.ContainsKey(_node))
								_node = ReplaceNodes[_node];

							ReplaceNodes.Add(identifier.Parent, _node);
							return;
						}

						if (_toAttr.To == ToAttribute.NoneWithTrailingDotRemoved)
						{
							SyntaxNode? _mae = identifier.Parent;
							if (_mae == null)
							{
								Log.ErrorLine($"Parent of {identifier} is null");
								return;
							}
							if (_mae is not MemberAccessExpressionSyntax)
							{
								Log.ErrorLine($"Parent of {identifier} is {_mae.GetType()}. Should be MemberAccessExpressionSyntax");
								return;
							}

							//Delay adding to ReplaceNodes until the full MemberAccessExpressionSyntax is processed.
							_NoneWithTrailingDotRemoved = true;
							return;
						}

						ReplaceNodes.Add(identifier, SyntaxFactory.IdentifierName(_toAttr.Convert(identifier.Identifier.Text)).WithLeadingTrivia(identifier.Identifier.LeadingTrivia).WithTrailingTrivia(identifier.Identifier.TrailingTrivia));
						return;
					}
				}
			}
			if (symbol.ContainingType != null)
			{
				symbol = symbol.ContainingType;
				goto CheckParentAttributes;
			}
		}

		symbol = oldSymbol;

		if (_Options.CustomCSNamesToJS.TryGetValue(identifier.Identifier.Text, out string? _value))
		{
			ReplaceNodes.Add(identifier, SyntaxFactory.IdentifierName(_value));
			return;
		}

		if (BuiltInTypesGenerics(identifier, symbol, out string str))
		{
			ReplaceNodes.Add(identifier, SyntaxFactory.IdentifierName(str).WithLeadingTrivia(identifier.Identifier.LeadingTrivia).WithTrailingTrivia(identifier.Identifier.TrailingTrivia));
			return;
		}
	}
	private bool BuiltInTypesGenerics(TypeSyntax node, ISymbol? symbol, out string str)
	{
		str = string.Empty;

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

		ISymbol typeSymbol = symbol;

		if (typeSymbol.Kind != SymbolKind.NamedType)
		{
			typeSymbol = symbol.ContainingSymbol;
			if (typeSymbol == null)
			{
				Log.WarningLine($"node: \"{node}\", typeSymbol is null. USE \"CustomCSNamesToJS\"!");
				return false;
			}

			if (typeSymbol.Kind != SymbolKind.NamedType)
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
				str = jsStr;
				return true;
			}
			jsStr = _NETAPI.ReturnJSString(typeName, symbol.Name);
			if (jsStr == null)
			{
				Log.WarningLine($"node: \"{node}\", typeSymbol: \"{typeSymbol}\", symbol: \"{symbol}\", symbolName: \"{symbol.Name}\", Is not supported! USE \"CustomCSNamesToJS\"");
				return false;
			}
			else
			{
				str = jsStr;
				return true;
			}
		}
	}
	private ISymbol? TryGetISymbol(SyntaxNode node)
	{
		ISymbol? symbol = null;

		SymbolInfo? symbolInfo = _Model.GetSymbolInfo(node);

		if (symbolInfo == null)
			return symbol;

		if (symbolInfo?.CandidateSymbols.Length >= 1)
			symbol = symbolInfo?.CandidateSymbols[0];
		else
			symbol = symbolInfo?.Symbol;

		return symbol;
	}
}

internal class ExportClassesWalker : CSharpSyntaxWalker
{
	private readonly SemanticModel _Model;
	private readonly Dictionary<string, List<string>> _ExportClasses;

	public ExportClassesWalker(SemanticModel semanticModel, ref Dictionary<string, List<string>> exportClasses)
	{
		_Model = semanticModel;
		_ExportClasses = exportClasses;
	}
	public override void VisitClassDeclaration(ClassDeclarationSyntax node)
	{
		INamedTypeSymbol? classSymbol = _Model.GetDeclaredSymbol(node);

		if (classSymbol != null)
		{
			if (classSymbol.DeclaredAccessibility == Accessibility.Public)
			{
				if (node.SyntaxTree.FilePath == string.Empty)
					Log.WarningLine("'FileName' is empty. Modules won't be imported! (Only exported)");

				if (_ExportClasses.ContainsKey(node.SyntaxTree.FilePath))
					_ExportClasses[node.SyntaxTree.FilePath].Add(classSymbol.Name);
				else
					_ExportClasses.Add(node.SyntaxTree.FilePath, new() { classSymbol.Name });
			}
		}
	}
}