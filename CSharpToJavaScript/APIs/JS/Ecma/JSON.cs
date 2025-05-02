//TODO! Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;
using System;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-json-object
[To(ToAttribute.Default)]
public partial class JSON : ObjectPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic? Parse(string text, Action? reviver = null) 
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static string? Stringify(dynamic value, Action? replacer = null, string space = "")
	{
		throw new System.NotImplementedException();
	}
}
