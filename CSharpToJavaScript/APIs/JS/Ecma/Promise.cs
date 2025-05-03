//TODO! Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;
using System;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-promise-objects
[To(ToAttribute.Default)]
public partial class Promise : PromisePrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static PromisePrototype Prototype { get; } = new();
	public Promise(Action executor) { }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static Promise All(Array iterable) 
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static Promise AllSettled(Array iterable)
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static Promise Any(Array iterable)
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static Promise Race(Array iterable)
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static Promise Reject(dynamic r)
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static Promise Resolve(dynamic x)
	{
		throw new System.NotImplementedException();
	}
}

[To(ToAttribute.FirstCharToLowerCase)]
public class PromisePrototype : FunctionPrototype
{
	public PromisePrototype() { }

	public Promise Catch(Action onRejected)
	{
		throw new System.NotImplementedException();
	}
	public Promise Finally (Action onFinally)
	{
		throw new System.NotImplementedException();
	}
	public Promise Then(Action onFulfilled, Action? onRejected = null)
	{
		throw new System.NotImplementedException();
	}
}
