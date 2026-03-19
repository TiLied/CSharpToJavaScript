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
	
	public Dictionary<SyntaxToken, SyntaxToken> ReplaceTokens = new();
	
	public WithSemanticRewriter(SemanticModel semanticModel, CSTOJSOptions options) 
	{
		_Model = semanticModel;
		_Options = options;
	}
	
#if DEBUG
    public override SyntaxNode? Visit(SyntaxNode? node)
    {
		if(node != null)
			Log.InfoLine($"kind: {node.Kind()} \n\t{node.ToString()}");
	
        return base.Visit(node);
	}
#endif
	
	public override SyntaxNode? VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
	{
		if(node.Expression is IdentifierNameSyntax identifier)
			VisitIdentifier(identifier);
		
		VisitIdentifier((IdentifierNameSyntax)node.Name);
		
		node = (MemberAccessExpressionSyntax)base.VisitMemberAccessExpression(node)!;
		
		return node;
	}
	
	private void VisitIdentifier(IdentifierNameSyntax identifier)
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
						
						ReplaceTokens.Add(identifier.Identifier, SyntaxFactory.Identifier(_v).WithLeadingTrivia(identifier.Identifier.LeadingTrivia).WithTrailingTrivia(identifier.Identifier.TrailingTrivia));
						//return node;
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
						
						ReplaceTokens.Add(identifier.Identifier, SyntaxFactory.Identifier(_toAttr.Convert(identifier.Identifier.Text)).WithLeadingTrivia(identifier.Identifier.LeadingTrivia).WithTrailingTrivia(identifier.Identifier.TrailingTrivia));
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
			ReplaceTokens.Add(identifier.Identifier, SyntaxFactory.Identifier(_value));
			//return node;
			return;
		}
		
		if(BuiltInTypesGenerics(identifier, symbol, out string str))
		{
			if(str == string.Empty)
			{
				Log.ErrorLine("str == string.Empty!");
				//return node;
				return;
			}
			
			ReplaceTokens.Add(identifier.Identifier, SyntaxFactory.Identifier(str).WithLeadingTrivia(identifier.Identifier.LeadingTrivia).WithTrailingTrivia(identifier.Identifier.TrailingTrivia));
			//return node;
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
			if(typeSymbol == null)
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
