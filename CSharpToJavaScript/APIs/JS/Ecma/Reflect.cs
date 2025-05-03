//TODO! Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;
using System.Collections.Generic;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-reflect-object
[To(ToAttribute.Default)]
public partial class Reflect
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic Apply(dynamic target,dynamic thisArgument,Array argumentsList) 
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic Construct(dynamic target, Array argumentsList, dynamic? newTarget = null)
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool DefineProperty(dynamic target, string propertyKey, dynamic attributes)
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool DeleteProperty(dynamic target, string propertyKey)
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic Get(dynamic target, string propertyKey, dynamic? receiver = null)
	{
		throw new System.NotImplementedException();
	}	
	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic? GetOwnPropertyDescriptor(dynamic target, string propertyKey)
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic? GetPrototypeOf(dynamic target)
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool Has(dynamic target, string propertyKey)
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool IsExtensible(dynamic target)
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static List<dynamic> OwnKeys(dynamic target)
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool PreventExtensions(dynamic target)
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool Set(dynamic target, string propertyKey, dynamic V, dynamic? receiver = null)
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool SetPrototypeOf(dynamic target, dynamic proto)
	{
		throw new System.NotImplementedException();
	}
}
