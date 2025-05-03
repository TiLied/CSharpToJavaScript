//TODO! Disable missing XML comments.
#pragma warning disable CS1591
using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//Todo?
//https://262.ecma-international.org/14.0/#sec-asyncgeneratorfunction-objects
[To(ToAttribute.Default)]
public partial class AsyncGeneratorFunction : Function
{
	public AsyncGeneratorFunction(string parameterArgs, string bodyArg) : base(parameterArgs, bodyArg)
	{
	}
}