//TODO! Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;
using System;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//Todo? interfaces?
//https://262.ecma-international.org/14.0/#sec-common-iteration-interfaces
[To(ToAttribute.Default)]
public partial class Iterator : ObjectPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public IteratorResult Next() 
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public IteratorResult Return(dynamic value)
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public IteratorResult Throw(dynamic exception)
	{
		throw new System.NotImplementedException();
	}
}

[To(ToAttribute.Default)]
public partial class AsyncIterator : ObjectPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public IteratorResult Next()
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public IteratorResult Return(dynamic value)
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public IteratorResult Throw(dynamic exception)
	{
		throw new System.NotImplementedException();
	}
}

[To(ToAttribute.None)]
public class IteratorResult 
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Done { get; set; } = true;
	[To(ToAttribute.FirstCharToLowerCase)]
	public dynamic? Value { get; set; } = null;
}
