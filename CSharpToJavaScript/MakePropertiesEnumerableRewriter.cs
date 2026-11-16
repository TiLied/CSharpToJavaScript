using CSharpToJavaScript.Utils;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpToJavaScript;

internal class MakePropertiesEnumerableRewriter : CSharpSyntaxRewriter
{
	public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
	{
		for (int i = 0; i < node.Members.Count; i++)
		{
			//properties need to be handled in VisitClassDeclaration
			if (node.Members[i].IsKind(SyntaxKind.PropertyDeclaration))
			{
				PropertyDeclarationSyntax _prop = (PropertyDeclarationSyntax)node.Members[i];

				if (_prop.AccessorList != null)
				{
					int _constructorIndex = -1;
					string _enumProp = $"Object.defineProperty(this, '{_prop.Identifier}', {{ enumerable: true, ";

					for (int j = 0; j < node.Members.Count; j++)
					{
						if (node.Members[j] is ConstructorDeclarationSyntax)
						{
							_constructorIndex = j;
							break;
						}
					}

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
							  SyntaxFactory.Identifier(_fieldIdentifier).WithLeadingTrivia(_prop.Identifier.LeadingTrivia))
								.WithInitializer(_prop.Initializer))))
								.WithTrailingTrivia(_prop.GetTrailingTrivia())
								.WithModifiers(_prop.Modifiers);

						if (_getSetStr.Contains("get;"))
						{
							_enumProp += $"get: function() {{ return this.{_fieldIdentifier}; }}";
						}
						
						if (_getSetStr.Contains("get;") && _getSetStr.Contains("set;"))
						{
							_enumProp += $", set: function (value) {{ this.{_fieldIdentifier} = value; }} }}";
						}

						if (_constructorIndex == -1)
						{
							Log.WarningLine($"Constructor is 'null' for: '{node.Identifier}'. 'MakePropertiesEnumerable' option is ignored!");
						}
						else
						{
							//Replace a property with a field.
							node = node.ReplaceNode(node.Members[i], _field);
							
							ConstructorDeclarationSyntax _constr = (ConstructorDeclarationSyntax)node.Members[_constructorIndex];

							if (_constr.Body == null)
							{
								Log.WarningLine("Block body must exist, it is 'null'! 'MakePropertiesEnumerable' option is ignored!");
								continue;
							}
							
							_enumProp += ")";
							
							node = node.ReplaceNode(_constr.Body,
								_constr.Body.WithStatements(_constr.Body.Statements.Insert(0,
										SyntaxFactory.ExpressionStatement(
											SyntaxFactory.IdentifierName(_enumProp))
											.WithTrailingTrivia(SyntaxFactory.LineFeed))).WithLeadingTrivia(_constr.Body.GetLeadingTrivia()).WithTrailingTrivia(_constr.Body.GetTrailingTrivia()));
						}
						
					}
				}
			}
		}

		return node;
	}
}