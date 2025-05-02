//TODO! Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-weakset-objects
[To(ToAttribute.Default)]
public partial class WeakSet : WeakSetPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static WeakSetPrototype Prototype { get; } = new();
	public WeakSet(Array? iterable = default) { }
}
[To(ToAttribute.FirstCharToLowerCase)]
public class WeakSetPrototype : FunctionPrototype
{
	public WeakSetPrototype() { }
	public WeakSet Add(dynamic value)
	{
		throw new System.NotImplementedException();
	}
	public bool Delete(dynamic value)
	{
		throw new System.NotImplementedException();
	}
	public bool Has(dynamic value)
	{
		throw new System.NotImplementedException();
	}
}