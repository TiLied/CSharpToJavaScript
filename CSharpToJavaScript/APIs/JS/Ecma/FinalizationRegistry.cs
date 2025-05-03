//TODO! Disable missing XML comments.
#pragma warning disable CS1591


using CSharpToJavaScript.Utils;
using System;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-finalization-registry-objects
[To(ToAttribute.Default)]
public partial class FinalizationRegistry : FinalizationRegistryPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static FinalizationRegistryPrototype Prototype { get; } = new();
	public FinalizationRegistry(Action cleanupCallback) { }
}
[To(ToAttribute.FirstCharToLowerCase)]
public class FinalizationRegistryPrototype : FunctionPrototype 
{
	public FinalizationRegistryPrototype() { }
	public GlobalObject.Undefined Register(dynamic target, dynamic heldValue, dynamic? unregisterToken = null) 
	{
		throw new System.NotImplementedException();
	}
	public bool Unregister(dynamic unregisterToken)
	{
		throw new System.NotImplementedException();
	}
}