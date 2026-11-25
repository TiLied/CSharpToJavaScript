//TODO! Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;
using System;
using System.Collections.Generic;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-json-object
[To(ToAttribute.Default)]
public partial class JSON : ObjectPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic? Parse(string text, Func<dynamic, dynamic, dynamic>? reviver = null)
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static T? Parse<T>(string text, Func<dynamic, dynamic, dynamic>? reviver = null)
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static string? Stringify(dynamic value, Func<dynamic, dynamic, dynamic>? replacer = null, string space = "")
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static string? Stringify<T>(T value, Func<dynamic, dynamic, dynamic>? replacer = null, string space = "")
	{
		throw new System.NotImplementedException();
	}
}
