//TODO! Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;
using System;
using System.Drawing;

namespace CSharpToJavaScript.APIs.JS.Ecma;

[To(ToAttribute.Default)]
public partial class Atomics : ObjectPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public dynamic And<T>(T typedArray, int index, dynamic value) where T : TypedArray<T> 
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public dynamic CompareExchange<T>(T typedArray, int index, dynamic expectedValue, dynamic replacementValue) where T : TypedArray<T>
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public dynamic Exchange<T>(T typedArray, int index, dynamic value) where T : TypedArray<T>
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool IsLockFree(int size )
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public dynamic Load<T>(T typedArray,int index) where T : TypedArray<T>
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public dynamic Or<T>(T typedArray, int index, dynamic value) where T : TypedArray<T>
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public dynamic Store<T>(T typedArray, int index, dynamic value) where T : TypedArray<T>
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public dynamic Sub<T>(T typedArray, int index, dynamic value) where T : TypedArray<T>
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Wait<T>(T typedArray, int index, dynamic value, int wait = 0) where T : TypedArray<T>
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public int Notify<T>(T typedArray, int index, int count = 0) where T : TypedArray<T>
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public dynamic Xor<T>(T typedArray, int index, dynamic value) where T : TypedArray<T>
	{
		throw new System.NotImplementedException();
	}
}
