//TODO! Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;


namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-async-function-objects
[To(ToAttribute.Default)]
public partial class AsyncFunction : Function
{
	public AsyncFunction(string parameterArgs, string bodyArg) : base(parameterArgs, bodyArg)
	{
	}
}
