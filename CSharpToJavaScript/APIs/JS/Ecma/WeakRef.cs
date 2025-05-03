//TODO! Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-weak-ref-objects
[To(ToAttribute.Default)]
public partial class WeakRef : WeakRefPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static WeakRefPrototype Prototype { get; } = new();
	public WeakRef(dynamic target) { }
}
[To(ToAttribute.FirstCharToLowerCase)]
public class WeakRefPrototype : FunctionPrototype 
{
	public WeakRefPrototype() { }

	public dynamic Deref() 
	{
		throw new System.NotImplementedException();
	}
}