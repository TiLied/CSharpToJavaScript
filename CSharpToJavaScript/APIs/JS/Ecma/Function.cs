//Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-function-objects
public partial class Function : FunctionPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public int Length { get; } = 1;
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; } = string.Empty;

	[To(ToAttribute.FirstCharToLowerCase)]
	public static FunctionPrototype Prototype { get; } = new();


	//see note! 
	//https://262.ecma-international.org/14.0/#sec-function-p1-p2-pn-body
	[To(ToAttribute.Default)]
	public Function(string parameterArgs, string bodyArg) 
	{
		
	}
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FunctionPrototype : ObjectPrototype
{
	public FunctionPrototype() { }

	public dynamic Apply(dynamic thisArg, dynamic argArray) 
	{
		throw new System.NotImplementedException();
	}

	public dynamic Bind(dynamic thisArg, params dynamic[] args)
	{
		throw new System.NotImplementedException();
	}
	public dynamic Call(dynamic thisArg, params dynamic[] args)
	{
		throw new System.NotImplementedException();
	}
	public new string ToString()
	{
		throw new System.NotImplementedException();
	}
}
