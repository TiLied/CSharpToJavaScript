//TODO! Disable missing XML comments.
#pragma warning disable CS1591
//Disable lowercase warning.
#pragma warning disable IDE1006

using CSharpToJavaScript.Utils;
using System;
using System.Collections.Generic;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-array-objects
[To(ToAttribute.Default)]
public partial class Array : ArrayPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static ArrayPrototype Prototype { get; } = new();
	public static ArrayPrototype prototype { get; } = new();

	[To(ToAttribute.FirstCharToLowerCase)]
	public int Length { get; } = 0;
	public int length { get; } = 0;

	public Array(params dynamic[] values) { throw new System.NotImplementedException(); }
	
	//Todo! Function for mapfn?
	[To(ToAttribute.FirstCharToLowerCase)]
	public static Array From(dynamic items, Action<dynamic>? mapfn = null, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	public static Array from(dynamic items, Action<dynamic>? mapfn = null, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	
	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool IsArray(dynamic arg) { throw new System.NotImplementedException(); }
	public static bool isArray(dynamic arg) { throw new System.NotImplementedException(); }
	
	[To(ToAttribute.FirstCharToLowerCase)]
	public static Array Of(params dynamic[] items) { throw new System.NotImplementedException(); }
	public static Array of(params dynamic[] items) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ArrayPrototype : FunctionPrototype
{
	public ArrayPrototype() { }
	public dynamic? At(int index) { throw new System.NotImplementedException(); }
	public dynamic? at(int index) { throw new System.NotImplementedException(); }
	
	public Array CopyWithin(dynamic target, int start,int end = 0) { throw new System.NotImplementedException(); }
	public Array copyWithin(dynamic target, int start, int end = 0) { throw new System.NotImplementedException(); }
	
	public List<dynamic> Entries() { throw new System.NotImplementedException(); }
	public List<dynamic> entries() { throw new System.NotImplementedException(); }
	
	public bool Every(Action callbackfn, dynamic? thisArg = null ) { throw new System.NotImplementedException(); }
	public bool every(Action callbackfn, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	
	public Array Fill(dynamic value, int start = 0, int end = 0 ) { throw new System.NotImplementedException(); }
	public Array fill(dynamic value, int start = 0, int end = 0) { throw new System.NotImplementedException(); }
	
	public Array Filter(Action callbackfn, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	public Array filter(Action callbackfn, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	
	public dynamic? Find(Action predicate, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	public dynamic? find(Action predicate, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	
	public int FindIndex(Action predicate, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	public int findIndex(Action predicate, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	
	public dynamic? FindLast(Action predicate, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	public dynamic? findLast(Action predicate, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	
	public int FindLastIndex(Action predicate, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	public int findLastIndex(Action predicate, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	
	public Array Flat(int depth = 1 ) { throw new System.NotImplementedException(); }
	public Array flat(int depth = 1) { throw new System.NotImplementedException(); }
	
	public Array FlatMap(Action mapperFunction, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	public Array flatMap(Action mapperFunction, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	
	public GlobalObject.Undefined ForEach(Action callbackfn, dynamic? thisArg = null) {	throw new System.NotImplementedException(); }
	public GlobalObject.Undefined forEach(Action callbackfn, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	
	public bool Includes(dynamic searchElement, int fromIndex = 0) { throw new System.NotImplementedException(); }
	public bool includes(dynamic searchElement, int fromIndex = 0) { throw new System.NotImplementedException(); }
	
	public int IndexOf(dynamic searchElement, int fromIndex = 0) { throw new System.NotImplementedException(); }
	public int indexOf(dynamic searchElement, int fromIndex = 0) { throw new System.NotImplementedException(); }
	
	public string Join(string separator = ",") { throw new System.NotImplementedException(); }
	public string join(string separator = ",") { throw new System.NotImplementedException(); }
	
	public List<dynamic> Keys() { throw new System.NotImplementedException(); }
	public List<dynamic> keys() { throw new System.NotImplementedException(); }
	
	public int LastIndexOf(dynamic searchElement, int fromIndex = 0) { throw new System.NotImplementedException(); }
	public int lastIndexOf(dynamic searchElement, int fromIndex = 0) { throw new System.NotImplementedException(); }

	public Array Map(Action callbackfn, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	public Array map(Action callbackfn, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	
	public dynamic Pop() { throw new System.NotImplementedException(); }
	public dynamic pop() { throw new System.NotImplementedException(); }
	
	public int Push(params dynamic[] tems ) { throw new System.NotImplementedException(); }
	public int push(params dynamic[] tems) { throw new System.NotImplementedException(); }
	
	public dynamic Reduce(Action callbackfn, dynamic? initialValue = null) { throw new System.NotImplementedException(); }
	public dynamic reduce(Action callbackfn, dynamic? initialValue = null) { throw new System.NotImplementedException(); }
	
	public dynamic ReduceRight(Action callbackfn, dynamic? initialValue = null) { throw new System.NotImplementedException(); }
	public dynamic reduceRight(Action callbackfn, dynamic? initialValue = null) { throw new System.NotImplementedException(); }
	
	public Array Reverse() { throw new System.NotImplementedException(); }
	public Array reverse() { throw new System.NotImplementedException(); }
	
	public dynamic? Shift() { throw new System.NotImplementedException(); }
	public dynamic? shift() { throw new System.NotImplementedException(); }
	
	public Array Slice(int start = 0, int end = 0 ) { throw new System.NotImplementedException(); }
	public Array slice(int start = 0, int end = 0) { throw new System.NotImplementedException(); }
	
	public bool Some(Action callbackfn, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	public bool some(Action callbackfn, dynamic? thisArg = null) { throw new System.NotImplementedException(); }
	
	public Array Sort(Action comparefn ) { throw new System.NotImplementedException(); }
	public Array sort(Action comparefn) { throw new System.NotImplementedException(); }
	
	public Array Splice(int start, int deleteCount, params dynamic[] items ) { throw new System.NotImplementedException(); }
	public Array splice(int start, int deleteCount, params dynamic[] items) { throw new System.NotImplementedException(); }
	/*
	public string ToLocaleString(dynamic? reserved1 = null, dynamic? reserved2 = null)
	{
		throw new System.NotImplementedException();
	}*/
	public Array ToReversed() { throw new System.NotImplementedException(); }
	public Array toReversed() { throw new System.NotImplementedException(); }
	
	public Array ToSorted(Action comparefn ) { throw new System.NotImplementedException(); }
	public Array toSorted(Action comparefn) { throw new System.NotImplementedException(); }
	
	public Array ToSpliced(int start, int skipCount,params dynamic[] items ) { throw new System.NotImplementedException(); }
	public Array toSpliced(int start, int skipCount, params dynamic[] items) { throw new System.NotImplementedException(); }
	
	public new string ToString() { throw new System.NotImplementedException(); }
	public new string toString() { throw new System.NotImplementedException(); }
	
	public int Unshift(params dynamic[] items ) { throw new System.NotImplementedException(); }
	public int unshift(params dynamic[] items) { throw new System.NotImplementedException(); }
	
	public List<dynamic> Values() { throw new System.NotImplementedException(); }
	public List<dynamic> values() { throw new System.NotImplementedException(); }
	
	public Array With(int index, dynamic value ) { throw new System.NotImplementedException(); }
	public Array with(int index, dynamic value) { throw new System.NotImplementedException(); }
}
