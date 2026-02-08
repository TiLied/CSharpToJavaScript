using CSharpToJavaScript.APIs.JS.Ecma;
using CSharpToJavaScript.Utils;
using System;

namespace CSharpToJavaScript.APIs.JS;

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CustomElementRegistry
{
	[GenericAsArgument]
	public GlobalObject.Undefined Define<C>(string name) { throw new NotImplementedException(); }
}