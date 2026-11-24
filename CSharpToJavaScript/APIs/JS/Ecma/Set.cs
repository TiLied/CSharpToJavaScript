//TODO! Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;
using System;
using System.Collections.Generic;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-set-objects
[To(ToAttribute.Default)]
public partial class Set : SetPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static SetPrototype Prototype { get; } = new();
	public Set(Array? iterable = default) { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public class SetPrototype : FunctionPrototype
{
	public int Size { get; } = 0;
	public SetPrototype() { }
	public Set Add(dynamic value)
	{
		throw new System.NotImplementedException();
	}
	public GlobalObject.Undefined Clear()
	{
		throw new System.NotImplementedException();
	}
	public bool Delete(dynamic value)
	{
		throw new System.NotImplementedException();
	}
	public List<dynamic> Entries()
	{
		throw new System.NotImplementedException();
	}
	public GlobalObject.Undefined ForEach(Action callbackfn, dynamic? thisArg = null)
	{
		throw new System.NotImplementedException();
	}
	public bool Has(dynamic value)
	{
		throw new System.NotImplementedException();
	}
	public List<dynamic> Keys()
	{
		throw new System.NotImplementedException();
	}
	public List<dynamic> Values()
	{
		throw new System.NotImplementedException();
	}
}
[To(ToAttribute.Default)]
public partial class Set<T> : SetPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static SetPrototype<T> Prototype { get; } = new();
	public Set(Array? iterable = default) { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public class SetPrototype<T> : FunctionPrototype
{
	public int Size { get; } = 0;
	public SetPrototype() { }
	public Set Add(T value)
	{
		throw new System.NotImplementedException();
	}
	public GlobalObject.Undefined Clear()
	{
		throw new System.NotImplementedException();
	}
	public bool Delete(T value)
	{
		throw new System.NotImplementedException();
	}
	public List<T> Entries()
	{
		throw new System.NotImplementedException();
	}
	public GlobalObject.Undefined ForEach(Action callbackfn, dynamic? thisArg = null)
	{
		throw new System.NotImplementedException();
	}
	public bool Has(T value)
	{
		throw new System.NotImplementedException();
	}
	public List<T> Keys()
	{
		throw new System.NotImplementedException();
	}
	public List<T> Values()
	{
		throw new System.NotImplementedException();
	}
}
