//TODO! Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//Todo! handler!
//https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Proxy/Proxy

//https://262.ecma-international.org/14.0/#sec-proxy-objects
[To(ToAttribute.Default)]
public partial class Proxy : FunctionPrototype
{
	public Proxy(dynamic target, dynamic handler ) 
	{
		
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic Revocable(dynamic target, dynamic handler)
	{
		throw new System.NotImplementedException();
	}
}
