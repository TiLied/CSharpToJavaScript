using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using CSharpToJavaScript.Utils;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpToJavaScript;

internal class ProcessBuiltIns
{
	public OrderedDictionary<string, Func<SyntaxNode, SyntaxNode, SyntaxNode>> BuiltIns = new();
	
	public ProcessBuiltIns()
	{
		//
		//
		//
		BuiltIns.Add(nameof(Console), (root, node) =>
		{
			return ReplaceIdentifier(root, node, "console");
		});

		BuiltIns.Add(nameof(Console) + nameof(Console.WriteLine), (root, node) =>
		{
			ImmutableArray<SyntaxNode> a = node.Ancestors().ToImmutableArray();
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i].IsKind(SyntaxKind.Argument))
				{
					return ReplaceArgument(root, node, "console", "log");
				}
				if (a[i].IsKind(SyntaxKind.InvocationExpression))
				{
					SeparatedSyntaxList<ArgumentSyntax> _oldArgs = ((InvocationExpressionSyntax)a[i]).ArgumentList.Arguments;
					ArgumentSyntax[] _newArgs = new ArgumentSyntax[_oldArgs.Count];
					
					for (int j = 0; j < _oldArgs.Count; j++)
					{
						_newArgs[j] = _oldArgs[j];

						if (_newArgs[j].Expression.IsKind(SyntaxKind.StringLiteralExpression))
							_newArgs[j] = _newArgs[j].WithExpression(_newArgs[j].Expression.WithAdditionalAnnotations(PredefinedAnnotations.CheckStringForComposite));
					}

					InvocationExpressionSyntax _invocation = SyntaxFactory.InvocationExpression(
							SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
							SyntaxFactory.IdentifierName("console"),
							SyntaxFactory.IdentifierName("log")),
							((InvocationExpressionSyntax)a[i]).ArgumentList.WithArguments(SyntaxFactory.SeparatedList(_newArgs, _oldArgs.GetSeparators())))
							.WithLeadingTrivia(a[i].GetLeadingTrivia())
							.WithTrailingTrivia(a[i].GetTrailingTrivia());

					return root.ReplaceNode(a[i], _invocation);
				}
			}
			return root;
		});
		BuiltIns.Add(nameof(Console) + nameof(Console.Write), (root, node) =>
		{
			return BuiltIns[nameof(Console) + nameof(Console.WriteLine)](root, node);
		});

		//
		//
		//
		BuiltIns.Add(nameof(System.Text.Json.JsonSerializer), (root, node) =>
		{
			return ReplaceIdentifier(root, node, "JSON");
		});

		BuiltIns.Add(nameof(System.Text.Json.JsonSerializer) + nameof(System.Text.Json.JsonSerializer.Deserialize), (root, node) =>
		{
			return ReplaceInvocation(root, node, "JSON", "parse");
		}
		);
		BuiltIns.Add(nameof(System.Text.Json.JsonSerializer) + nameof(System.Text.Json.JsonSerializer.Serialize), (root, node) =>
		{
			return ReplaceInvocation(root, node, "JSON", "stringify");
		}
		);

		//
		//
		//
		BuiltIns.Add(nameof(List<>), (root, node) =>
		{
			return ReplaceIdentifier(root, node, "Array");
		});

		BuiltIns.Add(nameof(List<>) + ".ctor", (root, node) =>
		{
			return ReplaceIdentifier(root, node, "Array");
		});
		BuiltIns.Add(nameof(List<>) + nameof(List<>.Sort), (root, node) =>
		{
			return ReplaceIdentifier(root, node, "sort");
		});
		BuiltIns.Add(nameof(List<>) + nameof(List<>.FindLast), (root, node) =>
		{
			return ReplaceIdentifier(root, node, "findLast");
		});
		BuiltIns.Add(nameof(List<>) + nameof(List<>.Count), (root, node) =>
		{
			return ReplaceIdentifier(root, node, "length");
		});
		BuiltIns.Add(nameof(List<>) + nameof(List<>.Add), (root, node) =>
		{
			return ReplaceIdentifier(root, node, "push");
		});
		BuiltIns.Add(nameof(List<>) + nameof(List<>.Contains), (root, node) =>
		{
			return ReplaceIdentifier(root, node, "includes");
		});

		//
		//
		//
		BuiltIns.Add(nameof(Dictionary<,>), (root, node) =>
		{
			return ReplaceIdentifier(root, node, "Map");
		});


		BuiltIns.Add(nameof(Dictionary<,>) + ".ctor", (root, node) =>
		{
			return ReplaceIdentifier(root, node, "Map");
		});
		BuiltIns.Add(nameof(Dictionary<,>) + nameof(Dictionary<,>.Keys), (root, node) =>
		{
			return ReplaceIdentifier(root, node, "keys");
		});
		BuiltIns.Add(nameof(Dictionary<,>) + nameof(Dictionary<,>.Values), (root, node) =>
		{
			return ReplaceIdentifier(root, node, "values");
		});
		BuiltIns.Add(nameof(Dictionary<,>) + nameof(Dictionary<,>.ContainsKey), (root, node) =>
		{
			return ReplaceIdentifier(root, node, "has");
		});
		BuiltIns.Add(nameof(Dictionary<,>) + nameof(Dictionary<,>.Add), (root, node) =>
		{
			return ReplaceIdentifier(root, node, "set");
		});
		
		//
		//
		//
		BuiltIns.Add(nameof(String), (root, node) =>
		{
			return ReplaceIdentifier(root, node, "String");
		});

		BuiltIns.Add(nameof(String) + nameof(string.Contains), (root, node) =>
		{
			return ReplaceIdentifier(root, node, "includes");
		});
		BuiltIns.Add(nameof(String) + nameof(string.Length), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "length");
			});
		BuiltIns.Add(nameof(String) + nameof(string.Trim), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "trim");
			});
		BuiltIns.Add(nameof(String) + nameof(string.TrimEnd), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "trimEnd");
			});
		BuiltIns.Add(nameof(String) + nameof(string.TrimStart), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "trimStart");
			});
		BuiltIns.Add(nameof(String) + nameof(string.Substring), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "substring");
			});
		BuiltIns.Add(nameof(String) + nameof(string.StartsWith), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "startsWith");
			});
		BuiltIns.Add(nameof(String) + nameof(string.Replace), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "replace");
			});
		BuiltIns.Add(nameof(String) + nameof(string.ToUpper), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "toUpperCase");
			});
		BuiltIns.Add(nameof(String) + nameof(string.ToLower), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "toLowerCase");
			});
		BuiltIns.Add(nameof(String) + nameof(string.EndsWith), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "endsWith");
			});
		BuiltIns.Add(nameof(String) + nameof(string.Empty), (root, node) =>
			{
				//TODO!
				return ReplaceIdentifier(root, node, "raw``");
			});

		//
		//
		//
		BuiltIns.Add(nameof(System.Threading.Tasks.Task<>), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "Promise");
			});

		BuiltIns.Add(nameof(System.Threading.Tasks.Task<>) + nameof(System.Threading.Tasks.Task.ContinueWith), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "then");
			});

		//
		//
		//
		BuiltIns.Add(nameof(Array), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "Array");
			});

		BuiltIns.Add(nameof(Array) + nameof(Array.Length), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "length");
			});

		//
		//
		//
		BuiltIns.Add(nameof(Math), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "Math");
			});

		BuiltIns.Add(nameof(Math) + nameof(Math.Sqrt), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "sqrt");
			});
		BuiltIns.Add(nameof(Math) + nameof(Math.Floor), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "floor");
			});
		BuiltIns.Add(nameof(Math) + nameof(Math.Exp), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "exp");
			});
		BuiltIns.Add(nameof(Math) + nameof(Math.Abs), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "abs");
			});
		BuiltIns.Add(nameof(Math) + nameof(Math.Max), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "max");
			});

		//
		//
		//
		BuiltIns.Add(nameof(Object), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "Object");
			});

		//
		//
		//
		BuiltIns.Add(nameof(SByte), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "Number");
			});

		BuiltIns.Add(nameof(SByte) + nameof(SByte.MinValue), (root, node) =>
			{
				//TODO!
				return ReplaceIdentifier(root, node, "parseInt(\"-128\")");
			});
		BuiltIns.Add(nameof(SByte) + nameof(SByte.MaxValue), (root, node) =>
			{
				//TODO!
				return ReplaceIdentifier(root, node, "parseInt(\"127\")");
			});

		//
		//
		//
		BuiltIns.Add(nameof(Byte), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "Number");
			});

		BuiltIns.Add(nameof(Byte) + nameof(Byte.MinValue), (root, node) =>
			{
				//TODO!
				return ReplaceIdentifier(root, node, "parseInt(\"0\")");
			});
		BuiltIns.Add(nameof(Byte) + nameof(Byte.MaxValue), (root, node) =>
			{
				//TODO!
				return ReplaceIdentifier(root, node, "parseInt(\"255\")");
			});

		//
		//
		//
		BuiltIns.Add(nameof(Int16), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "Number");
			});

		BuiltIns.Add(nameof(Int16) + nameof(Int16.MinValue), (root, node) =>
			{
				//TODO!
				return ReplaceIdentifier(root, node, "parseInt(\"-32768\")");
			});
		BuiltIns.Add(nameof(Int16) + nameof(Int16.MaxValue), (root, node) =>
			{
				//TODO!
				return ReplaceIdentifier(root, node, "parseInt(\"32767\")");
			});

		//
		//
		//
		BuiltIns.Add(nameof(UInt16), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "Number");
			});

		BuiltIns.Add(nameof(UInt16) + nameof(UInt16.MinValue), (root, node) =>
			{
				//TODO!
				return ReplaceIdentifier(root, node, "parseInt(\"0\")");
			});
		BuiltIns.Add(nameof(UInt16) + nameof(UInt16.MaxValue), (root, node) =>
			{
				//TODO!
				return ReplaceIdentifier(root, node, "parseInt(\"65535\")");
			});

		//
		//
		//
		BuiltIns.Add(nameof(Int32), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "Number");
			});

		BuiltIns.Add(nameof(Int32) + nameof(Int32.MinValue), (root, node) =>
			{
				//TODO!
				return ReplaceIdentifier(root, node, "parseInt(\"-2147483648\")");
			});
		BuiltIns.Add(nameof(Int32) + nameof(Int32.MaxValue), (root, node) =>
			{
				//TODO!
				return ReplaceIdentifier(root, node, "parseInt(\"2147483647\")");
			});

		//
		//
		//
		BuiltIns.Add(nameof(UInt32), (root, node) =>
			{
				return ReplaceIdentifier(root, node, "Number");
			});

		BuiltIns.Add(nameof(UInt32) + nameof(UInt32.MinValue), (root, node) =>
			{
				//TODO!
				return ReplaceIdentifier(root, node, "parseInt(\"0\")");
			});
		BuiltIns.Add(nameof(UInt32) + nameof(UInt32.MaxValue), (root, node) =>
			{
				//TODO!
				return ReplaceIdentifier(root, node, "parseInt(\"4294967295\")");
			});
	}

	public SyntaxNode ProcessRoot(SyntaxNode root)
	{
		ImmutableArray<SyntaxNode> annotatedNodes = root.GetAnnotatedNodes(PredefinedAnnotations.GlobalBuiltIn_Kind).ToImmutableArray();
		int length = annotatedNodes.Length;
		
		while (length > 0)
		{
			SyntaxNode _annotatedNode = annotatedNodes[0];
		
			string _symbol = _annotatedNode.GetDataAnnotation(PredefinedAnnotations.GlobalBuiltIn_Kind) ?? string.Empty;

			root = BuiltIns[_symbol](root, _annotatedNode);
			annotatedNodes = root.GetAnnotatedNodes(PredefinedAnnotations.GlobalBuiltIn_Kind).ToImmutableArray();

			if (annotatedNodes.Length == length)
				Log.WarningLine("Built-in is not replaced! Avoiding an infinite loop!");

			length--;
		}
		return root;
	}

	private SyntaxNode ReplaceIdentifier(SyntaxNode root, SyntaxNode node, string name)
	{
		return root.ReplaceNode(node,SyntaxFactory.IdentifierName(name)
		.WithLeadingTrivia(node.GetLeadingTrivia())
		.WithTrailingTrivia(node.GetTrailingTrivia())
		.WithAdditionalAnnotations(node.GetAnnotations(PredefinedAnnotations.Global_Kind)));
	}
	private SyntaxNode ReplaceInvocation(SyntaxNode root, SyntaxNode node, string typeName, string methodName)
	{
		ImmutableArray<SyntaxNode> a = node.Ancestors().ToImmutableArray();
		for (int i = 0; i < a.Length; i++)
		{
			//First check if it is argument
			//If yes replace it
			//For example: "nameof(Console.WriteLine)"
			if (a[i].IsKind(SyntaxKind.Argument))
			{
				return ReplaceArgument(root, node, typeName, methodName);
			}
			if (a[i].IsKind(SyntaxKind.InvocationExpression))
			{
				InvocationExpressionSyntax _invocation = SyntaxFactory.InvocationExpression(
						SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
						SyntaxFactory.IdentifierName(typeName),
						SyntaxFactory.IdentifierName(methodName)),
						((InvocationExpressionSyntax)a[i]).ArgumentList)
						.WithLeadingTrivia(a[i].GetLeadingTrivia())
						.WithTrailingTrivia(a[i].GetTrailingTrivia());

				return root.ReplaceNode(a[i], _invocation);
			}
		}
		return root;
	}
	private SyntaxNode ReplaceArgument(SyntaxNode root, SyntaxNode node, string typeName, string methodName)
	{
		ImmutableArray<SyntaxNode> a = node.Ancestors().ToImmutableArray();
		for (int i = 0; i < a.Length; i++)
		{
			if (a[i].IsKind(SyntaxKind.Argument))
			{
				ArgumentSyntax _arg = SyntaxFactory.Argument(
						SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
						SyntaxFactory.IdentifierName(typeName),
						SyntaxFactory.IdentifierName(methodName)))
						.WithLeadingTrivia(a[i].GetLeadingTrivia())
						.WithTrailingTrivia(a[i].GetTrailingTrivia());

				return root.ReplaceNode(a[i], _arg);
			}
		}
		return root;
	}
}