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

	private ITypeSymbol? _CurrentClassSymbol = null;

	public Dictionary<SyntaxNode, SyntaxNode> ReplaceNodes = new();

	public WithSemanticRewriter(SemanticModel semanticModel, CSTOJSOptions options)
	{
		_Model = semanticModel;
		_Options = options;
	}

#if DEBUG
	public override SyntaxNode? Visit(SyntaxNode? node)
	{
		if (node != null)
			Log.InfoLine($"kind: {node.Kind()} \n\t{node.ToString()}");

		return base.Visit(node);
	}
#endif

	public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
	{
		_CurrentClassSymbol = _Model.GetDeclaredSymbol(node);

		node = (ClassDeclarationSyntax)base.VisitClassDeclaration(node)!;

		return node;
	}

	public override SyntaxNode? VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
	{
		node = (MemberAccessExpressionSyntax)base.VisitMemberAccessExpression(node)!;

		MemberAccessExpressionSyntax? _expr = (MemberAccessExpressionSyntax)node;

		if (_expr.Expression is IdentifierNameSyntax)
		{
			ISymbol? symbol = _Model.GetSymbolInfo(node).Symbol;

			if (symbol != null)
			{
				if (TryReplaceIdentifierWithThis(symbol, (IdentifierNameSyntax)_expr.Expression))
					goto Name;
			}
		}

		if (node.Expression is IdentifierNameSyntax ||
			node.Expression is GenericNameSyntax)
			VisitSimpleName((SimpleNameSyntax)node.Expression);
	Name:
		if (node.Name is IdentifierNameSyntax ||
			node.Name is GenericNameSyntax)
			VisitSimpleName(node.Name);

		return node;
	}
	public override SyntaxNode? VisitElementAccessExpression(ElementAccessExpressionSyntax node)
	{
		node = (ElementAccessExpressionSyntax)base.VisitElementAccessExpression(node)!;

		if (node.Expression is IdentifierNameSyntax)
		{
			ISymbol? symbol = _Model.GetSymbolInfo(node.Expression).Symbol;

			if (symbol != null)
			{
				if (TryReplaceIdentifierWithThis(symbol, (IdentifierNameSyntax)node.Expression))
					return node;
			}
		}

		return node;
	}
	public override SyntaxNode? VisitInterpolation(InterpolationSyntax node)
	{
		if (node.Expression is IdentifierNameSyntax)
		{
			ISymbol? symbol = _Model.GetSymbolInfo(node.Expression).Symbol;

			if (symbol != null)
			{
				if (TryReplaceIdentifierWithThis(symbol, (IdentifierNameSyntax)node.Expression))
					return node;
			}
		}
		node = (InterpolationSyntax)base.VisitInterpolation(node)!;

		return node;
	}
	public override SyntaxNode? VisitArgument(ArgumentSyntax node)
	{
		if (node.Expression is IdentifierNameSyntax)
		{
			ISymbol? symbol = _Model.GetSymbolInfo(node.Expression).Symbol;

			if (symbol != null)
			{
				if (TryReplaceIdentifierWithThis(symbol, (IdentifierNameSyntax)node.Expression))
					return node;
			}
		}
		node = (ArgumentSyntax)base.VisitArgument(node)!;

		return node;
	}
	public override SyntaxNode? VisitTypeArgumentList(TypeArgumentListSyntax node)
	{
		if (node.Arguments[0] is IdentifierNameSyntax)
			VisitSimpleName((SimpleNameSyntax)node.Arguments[0]);

		node = (TypeArgumentListSyntax)base.VisitTypeArgumentList(node)!;

		return node;
	}
	public override SyntaxNode? VisitInvocationExpression(InvocationExpressionSyntax node)
	{
		node = (InvocationExpressionSyntax)base.VisitInvocationExpression(node)!;

		if (node.Expression is IdentifierNameSyntax ||
			node.Expression is GenericNameSyntax)
		{
			ISymbol? symbol = _Model.GetSymbolInfo(node.Expression).Symbol;

			if (symbol != null)
			{
				if (TryReplaceIdentifierWithThis(symbol, (SimpleNameSyntax)node.Expression))
					return node;

				ImmutableArray<AttributeData> _attributeData = symbol.GetAttributes();
				for (int i = 0; i < _attributeData.Length; i++)
				{
					if (_attributeData[i].AttributeClass != null)
					{
						if (_attributeData[i].AttributeClass!.Name == nameof(BinaryAttribute))
						{
							ReplaceNodes.Add(node.Expression, SyntaxFactory.IdentifierName(_attributeData[i].ConstructorArguments[0].Value.ToString())
							.WithAdditionalAnnotations(BinaryAttribute.Annotation)
							.WithLeadingTrivia(node.Expression.GetLeadingTrivia())
							.WithTrailingTrivia(node.Expression.GetTrailingTrivia()));

							return node;
						}
						if (_attributeData[i].AttributeClass!.Name == nameof(UnaryAttribute))
						{
							ReplaceNodes.Add(node.Expression, SyntaxFactory.IdentifierName(_attributeData[i].ConstructorArguments[0].Value.ToString())
							.WithAdditionalAnnotations(UnaryAttribute.Annotation)
							.WithLeadingTrivia(node.Expression.GetLeadingTrivia())
							.WithTrailingTrivia(node.Expression.GetTrailingTrivia()));

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
							ReplaceNodes.Add(node.Expression, SyntaxFactory.IdentifierName(SyntaxFactory.Identifier(_attributeData[i].ConstructorArguments[0].Value.ToString()))
							.WithAdditionalAnnotations(UnaryAttribute.Annotation)
							.WithLeadingTrivia(node.Expression.GetLeadingTrivia())
							.WithTrailingTrivia(node.Expression.GetTrailingTrivia()));

							ReplaceNodes.Add(node.ArgumentList, node.ArgumentList
							.AddArguments(SyntaxFactory.Argument(SyntaxFactory.IdentifierName(_arg.ToString()))));

							return node;
						}
						if (_attributeData[i].AttributeClass!.Name == nameof(GenericBinaryAttribute))
						{
							TypeSyntax _arg = ((GenericNameSyntax)node.Expression).TypeArgumentList.Arguments[0];

							if (ReplaceNodes.ContainsKey(_arg))
								_arg = (TypeSyntax)ReplaceNodes[_arg];

							ReplaceNodes.Add(node.Expression, SyntaxFactory.IdentifierName(_attributeData[i].ConstructorArguments[0].Value.ToString())
							.WithAdditionalAnnotations(BinaryAttribute.Annotation)
							.WithLeadingTrivia(node.Expression.GetLeadingTrivia())
							.WithTrailingTrivia(node.Expression.GetTrailingTrivia()));

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
		if (node.Left is IdentifierNameSyntax)
		{
			ISymbol? symbol = _Model.GetSymbolInfo(node.Left).Symbol;

			if (symbol != null)
			{
				TryReplaceIdentifierWithThis(symbol, (IdentifierNameSyntax)node.Left);
			}
		}
		if (node.Right is IdentifierNameSyntax)
		{
			ISymbol? symbol = _Model.GetSymbolInfo(node.Right).Symbol;

			if (symbol != null)
			{
				TryReplaceIdentifierWithThis(symbol, (IdentifierNameSyntax)node.Right);
			}
		}
		node = (BinaryExpressionSyntax)base.VisitBinaryExpression(node)!;

		return node;
	}
	public override SyntaxNode? VisitAssignmentExpression(AssignmentExpressionSyntax node)
	{
		if (node.Left is IdentifierNameSyntax)
		{
			ISymbol? symbol = _Model.GetSymbolInfo(node.Left).Symbol;

			if (symbol != null)
			{
				TryReplaceIdentifierWithThis(symbol, (IdentifierNameSyntax)node.Left);
			}
		}
		if (node.Right is IdentifierNameSyntax)
		{
			ISymbol? symbol = _Model.GetSymbolInfo(node.Right).Symbol;

			if (symbol != null)
			{
				TryReplaceIdentifierWithThis(symbol, (IdentifierNameSyntax)node.Right);
			}
		}
		node = (AssignmentExpressionSyntax)base.VisitAssignmentExpression(node)!;

		return node;
	}
	public override SyntaxNode? VisitReturnStatement(ReturnStatementSyntax node)
	{
		if (node.Expression is IdentifierNameSyntax)
		{
			ISymbol? symbol = _Model.GetSymbolInfo(node.Expression).Symbol;

			if (symbol != null)
			{
				TryReplaceIdentifierWithThis(symbol, (IdentifierNameSyntax)node.Expression);
			}
		}
		node = (ReturnStatementSyntax)base.VisitReturnStatement(node)!;

		return node;
	}
	public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)
	{
		node = (PropertyDeclarationSyntax)base.VisitPropertyDeclaration(node)!;

		if (node.Type is IdentifierNameSyntax ||
			node.Type is GenericNameSyntax)
			VisitSimpleName((SimpleNameSyntax)node.Type);

		return node;
	}


	private bool TryReplaceIdentifierWithThis(ISymbol symbol, SimpleNameSyntax identifier)
	{
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
	private void VisitSimpleName(SimpleNameSyntax identifier)
	{
		ISymbol? symbol = _Model.GetSymbolInfo(identifier).Symbol;

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

						//TODO!
						//how?
						//if (_toAttr.To == ToAttribute.NoneWithLeadingDotRemoved)
						//	JSSB.Remove(JSSB.Length - 1, 1);

						//if (_toAttr.To == ToAttribute.NoneWithTrailingDotRemoved)
						//	_IgnoreTailingDot = true;

						ReplaceNodes.Add(identifier, SyntaxFactory.IdentifierName(_toAttr.Convert(identifier.Identifier.Text)).WithLeadingTrivia(identifier.Identifier.LeadingTrivia).WithTrailingTrivia(identifier.Identifier.TrailingTrivia));
						//return node;
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

		symbol = _Model.GetSymbolInfo(identifier).Symbol;

		if (_Options.CustomCSNamesToJS.TryGetValue(identifier.Identifier.Text, out string? _value))
		{
			ReplaceNodes.Add(identifier, SyntaxFactory.IdentifierName(_value));
			return;
		}

		if (BuiltInTypesGenerics(identifier, symbol, out string str))
		{
			if (str == string.Empty)
			{
				Log.ErrorLine("str == string.Empty!");
				return;
			}

			ReplaceNodes.Add(identifier, SyntaxFactory.IdentifierName(str).WithLeadingTrivia(identifier.Identifier.LeadingTrivia).WithTrailingTrivia(identifier.Identifier.TrailingTrivia));
			return;
		}
	}
	private bool BuiltInTypesGenerics(SimpleNameSyntax node, ISymbol? symbol, out string str)
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
				Log.WarningLine($"node: \"{node}\", typeSymbol: \"{typeSymbol}\", symbol: \"{symbol}\", Is not supported! USE \"CustomCSNamesToJS\"");
				return false;
			}
			else
			{
				str = jsStr;
				return true;
			}
		}
	}
}
