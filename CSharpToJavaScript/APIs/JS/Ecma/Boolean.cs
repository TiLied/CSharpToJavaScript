using CSharpToJavaScript.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToJavaScript.APIs.JS;
//https://262.ecma-international.org/14.0/#sec-boolean-objects
[To(ToAttribute.Default)]
public partial class Boolean : BooleanPrototype
{
	public dynamic Value { get; set; }

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

	public string ToString()
	{
		throw new System.NotImplementedException();
	}

	public bool ValueOf()
	{
		throw new System.NotImplementedException();
	}
}