//TODO! Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;
using System;
using System.Collections.Generic;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//TODO? Generic variant? or replace with generic???
//That way, I can replace the Dictionary in the generated cs. See GenCSharpLib.
//Or, I cant...
//spec: https://w3c.github.io/clipboard-apis/#dom-clipboarditem-clipboarditem
//mdn js: https://developer.mozilla.org/en-US/docs/Web/API/ClipboardItem/ClipboardItem
//First parameter is an object in js, but in webidl is a record...

//https://262.ecma-international.org/14.0/#sec-map-objects
[To(ToAttribute.Default)]
public partial class Map : MapPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static MapPrototype Prototype { get; } = new();
	public Map(Array? iterable = default) { }

}
[To(ToAttribute.FirstCharToLowerCase)]
public class MapPrototype : FunctionPrototype
{
	public int Size { get; } = 0;
	public MapPrototype() { }

	public GlobalObject.Undefined Clear()
	{
		throw new System.NotImplementedException();
	}
	public bool Delete(dynamic key)
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
	public dynamic? Get(dynamic key)
	{
		throw new System.NotImplementedException();
	}
	public bool Has(dynamic key)
	{
		throw new System.NotImplementedException();
	}
	public List<dynamic> Keys()
	{
		throw new System.NotImplementedException();
	}
	public Map Set(dynamic key, dynamic value)
	{
		throw new System.NotImplementedException();
	}
	public List<dynamic> Values()
	{
		throw new System.NotImplementedException();
	}
}