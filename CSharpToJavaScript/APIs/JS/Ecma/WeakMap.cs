//TODO! Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-weakmap-objects
[To(ToAttribute.Default)]
public partial class WeakMap : WeakMapPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static WeakMapPrototype Prototype { get; } = new();
	public WeakMap(Array? iterable = default) { }
}
[To(ToAttribute.FirstCharToLowerCase)]
public class WeakMapPrototype : FunctionPrototype
{
	public WeakMapPrototype() { }
	public bool Delete(dynamic key)
	{
		throw new System.NotImplementedException();
	}
	public dynamic? Get(dynamic key)
	{
		throw new System.NotImplementedException();
	}
	public bool Has(dynamic key)
	{
		throw new System.NotImplementedException();
	}
	public WeakMap Set(dynamic key, dynamic value)
	{
		throw new System.NotImplementedException();
	}
}
