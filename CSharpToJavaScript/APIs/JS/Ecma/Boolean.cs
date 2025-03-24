//Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS.Ecma;
//https://262.ecma-international.org/14.0/#sec-boolean-objects
[To(ToAttribute.Default)]
public partial class Boolean : BooleanPrototype
{
	public dynamic? Value { get; set; }

	public static implicit operator Boolean(bool value) { return new Boolean(value) { Value = value }; }
	public static implicit operator bool(Boolean value) { return new Boolean(value) { Value = value }; }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static BooleanPrototype Prototype { get; } = new();

	public Boolean(dynamic value) { }
}
[To(ToAttribute.FirstCharToLowerCase)]
public partial class BooleanPrototype : FunctionPrototype
{

	public BooleanPrototype() { }

	public new string ToString()
	{
		throw new System.NotImplementedException();
	}

	public new bool ValueOf()
	{
		throw new System.NotImplementedException();
	}
}