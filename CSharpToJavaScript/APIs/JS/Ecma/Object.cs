//TODO! Disable missing XML comments.
#pragma warning disable CS1591
//Disable lowercase warning.
#pragma warning disable IDE1006

using CSharpToJavaScript.Utils;
using System.Collections.Generic;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-object-objects
[To(ToAttribute.Default)]
public partial class Object : ObjectPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static ObjectPrototype Prototype { get; } = new();
	public static ObjectPrototype prototype { get; } = new();
	
	public Object(dynamic? value = null) { }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic Assign(dynamic target, params dynamic[] sources) { throw new System.NotImplementedException(); }
	public static dynamic assign(dynamic target, params dynamic[] sources) { throw new System.NotImplementedException(); }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic Create(dynamic O, dynamic Properties) { throw new System.NotImplementedException(); }
	public static dynamic create(dynamic O, dynamic Properties) { throw new System.NotImplementedException(); }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic DefineProperties(dynamic O, dynamic Properties) { throw new System.NotImplementedException();	}
	public static dynamic defineProperties(dynamic O, dynamic Properties) { throw new System.NotImplementedException(); }
	
	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic DefineProperty(dynamic O, dynamic P, dynamic Attributes) { throw new System.NotImplementedException(); }
	public static dynamic defineProperty(dynamic O, dynamic P, dynamic Attributes) { throw new System.NotImplementedException(); }

	//Todo? key/val array??? 2dimension????
	[To(ToAttribute.FirstCharToLowerCase)]
	public static KeyValuePair<string, dynamic> Entries(dynamic O) { throw new System.NotImplementedException(); }
	public static KeyValuePair<string, dynamic> entries(dynamic O) { throw new System.NotImplementedException(); }

	//Todo? <T> and return <T>???
	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic Freeze(dynamic O) { throw new System.NotImplementedException(); }
	public static dynamic freeze(dynamic O) { throw new System.NotImplementedException(); }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic FromEntries(dynamic iterable) { throw new System.NotImplementedException(); }
	public static dynamic fromEntries(dynamic iterable) { throw new System.NotImplementedException(); }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic GetOwnPropertyDescriptor(dynamic O, dynamic P) { throw new System.NotImplementedException(); }
	public static dynamic getOwnPropertyDescriptor(dynamic O, dynamic P) { throw new System.NotImplementedException(); }
	
	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic GetOwnPropertyDescriptors(dynamic O) { throw new System.NotImplementedException(); }
	public static dynamic getOwnPropertyDescriptors(dynamic O) { throw new System.NotImplementedException(); }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static string[] GetOwnPropertyNames(dynamic O) { throw new System.NotImplementedException(); }
	public static string[] getOwnPropertyNames(dynamic O) { throw new System.NotImplementedException(); }

	//string[]? todo
	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic[] GetOwnPropertySymbols(dynamic O) { throw new System.NotImplementedException(); }
	public static dynamic[] getOwnPropertySymbols(dynamic O) { throw new System.NotImplementedException(); }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic GetPrototypeOf(dynamic O) { throw new System.NotImplementedException(); }
	public static dynamic getPrototypeOf(dynamic O) { throw new System.NotImplementedException(); }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool HasOwn(dynamic O, dynamic P) { throw new System.NotImplementedException(); }
	public static bool hasOwn(dynamic O, dynamic P) { throw new System.NotImplementedException(); }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool Is(dynamic value1, dynamic value2) { throw new System.NotImplementedException(); }
	[Value("is")]
	public static bool is_(dynamic value1, dynamic value2) { throw new System.NotImplementedException(); }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool IsExtensible(dynamic O) { throw new System.NotImplementedException(); }
	public static bool isExtensible(dynamic O) { throw new System.NotImplementedException(); }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool IsFrozen(dynamic O) { throw new System.NotImplementedException(); }
	public static bool isFrozen(dynamic O) { throw new System.NotImplementedException(); }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool IsSealed(dynamic O) { throw new System.NotImplementedException(); }
	public static bool isSealed(dynamic O) { throw new System.NotImplementedException(); }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static string[] Keys(dynamic O) { throw new System.NotImplementedException(); }
	public static string[] keys(dynamic O) { throw new System.NotImplementedException(); }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic PreventExtensions(dynamic O) { throw new System.NotImplementedException(); }
	public static dynamic preventExtensions(dynamic O) { throw new System.NotImplementedException(); }

	//TODO <T>????
	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic Seal(dynamic O) { throw new System.NotImplementedException(); }
	public static dynamic seal(dynamic O) { throw new System.NotImplementedException(); }

	//TODO <T>????
	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic SetPrototypeOf(dynamic O, dynamic proto) { throw new System.NotImplementedException(); }
	public static dynamic setPrototypeOf(dynamic O, dynamic proto) { throw new System.NotImplementedException(); }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static string[] Values(dynamic O) { throw new System.NotImplementedException(); }
	public static string[] values(dynamic O) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public class ObjectPrototype
{
	public ObjectPrototype() { }

	public bool HasOwnProperty(dynamic V) { throw new System.NotImplementedException(); }
	public bool hasOwnProperty(dynamic V) { throw new System.NotImplementedException(); }

	public bool IsPrototypeOf(dynamic V) { throw new System.NotImplementedException(); }
	public bool isPrototypeOf(dynamic V) { throw new System.NotImplementedException(); }

	public bool PropertyIsEnumerable(dynamic V) { throw new System.NotImplementedException(); }
	public bool propertyIsEnumerable(dynamic V) { throw new System.NotImplementedException(); }
	
	public string ToLocaleString(dynamic? reserved1 = null, dynamic? reserved2 = null) { throw new System.NotImplementedException(); }
	public string toLocaleString(dynamic? reserved1 = null, dynamic? reserved2 = null) { throw new System.NotImplementedException(); }

	public override string ToString() { throw new System.NotImplementedException(); }
	public string toString() { throw new System.NotImplementedException(); }

	public dynamic ValueOf() { throw new System.NotImplementedException(); }
	public dynamic valueOf() { throw new System.NotImplementedException(); }

	//For emulation "Bracket notation"
	//https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Property_accessors#bracket_notation
	public Object this[string property]
	{
		get
		{
			throw new System.NotImplementedException();
		}
		set 
		{
			throw new System.NotImplementedException();
		}
	}
}

