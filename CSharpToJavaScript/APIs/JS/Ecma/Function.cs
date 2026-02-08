//TODO! Disable missing XML comments.
#pragma warning disable CS1591
//Disable lowercase warning.
#pragma warning disable IDE1006

using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-function-objects
[To(ToAttribute.Default)]
public partial class Function : FunctionPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public int Length { get; } = 1;
	public int length { get; } = 1;
	
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; } = string.Empty;
	public string name { get; } = string.Empty;

	[To(ToAttribute.FirstCharToLowerCase)]
	public static FunctionPrototype Prototype { get; } = new();
	public static FunctionPrototype prototype { get; } = new();

	//see note! 
	//https://262.ecma-international.org/14.0/#sec-function-p1-p2-pn-body
	[To(ToAttribute.Default)]
	public Function(string parameterArgs, string bodyArg) {	}
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FunctionPrototype : ObjectPrototype
{
	public FunctionPrototype() { }

	public static dynamic Apply(dynamic thisArg, dynamic argArray) { throw new System.NotImplementedException(); }
	public static dynamic apply(dynamic thisArg, dynamic argArray) { throw new System.NotImplementedException(); }

	public static dynamic Bind(dynamic thisArg, params dynamic[] args) { throw new System.NotImplementedException(); }
	public static dynamic bind(dynamic thisArg, params dynamic[] args) { throw new System.NotImplementedException(); }

	public static dynamic Call(dynamic thisArg, params dynamic[] args) { throw new System.NotImplementedException(); }
	public static dynamic call(dynamic thisArg, params dynamic[] args) { throw new System.NotImplementedException(); }

	[Value("toString")]
	public static string ToStringStatic() { throw new System.NotImplementedException(); }
	[Value("toString")]
	public static string toStringStatic() { throw new System.NotImplementedException(); }
}
