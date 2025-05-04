//TODO! Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;
using System.Collections.Generic;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-object-objects
[To(ToAttribute.Default)]
public partial class Object : ObjectPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static ObjectPrototype Prototype { get; } = new();

	public Object(dynamic? value = null) { }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic Assign(dynamic target, params dynamic[] sources) 
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic Create(dynamic O, dynamic Properties)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic DefineProperties(dynamic O, dynamic Properties)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic DefineProperty(dynamic O, dynamic P, dynamic Attributes)
	{
		throw new System.NotImplementedException();
	}

	//Todo? key/val array??? 2dimension????
	[To(ToAttribute.FirstCharToLowerCase)]
	public static KeyValuePair<string, dynamic> Entries(dynamic O)
	{
		throw new System.NotImplementedException();
	}

	//Todo? <T> and return <T>???
	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic Freeze(dynamic O)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic FromEntries(dynamic iterable)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic GetOwnPropertyDescriptor(dynamic O, dynamic P)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic GetOwnPropertyDescriptors(dynamic O)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static string[] GetOwnPropertyNames(dynamic O)
	{
		throw new System.NotImplementedException();
	}

	//string[]? todo
	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic[] GetOwnPropertySymbols(dynamic O)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic GetPrototypeOf(dynamic O)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool HasOwn(dynamic O, dynamic P)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool Is(dynamic value1,dynamic value2)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool IsExtensible(dynamic O)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool IsFrozen(dynamic O)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool IsSealed(dynamic O)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static string[] Keys(dynamic O)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic PreventExtensions(dynamic O)
	{
		throw new System.NotImplementedException();
	}

	//TODO <T>????
	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic Seal(dynamic O)
	{
		throw new System.NotImplementedException();
	}

	//TODO <T>????
	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic SetPrototypeOf(dynamic O, dynamic proto)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static string[] Values(dynamic O)
	{
		throw new System.NotImplementedException();
	}
}

[To(ToAttribute.FirstCharToLowerCase)]
public class ObjectPrototype
{
	public ObjectPrototype() { }

	public bool HasOwnProperty(dynamic V) 
	{
		throw new System.NotImplementedException();
	}

	public bool IsPrototypeOf(dynamic V)
	{
		throw new System.NotImplementedException();
	}

	public bool PropertyIsEnumerable(dynamic V)
	{
		throw new System.NotImplementedException();
	}

	public string ToLocaleString(dynamic? reserved1 = null, dynamic? reserved2 = null)
	{
		throw new System.NotImplementedException();
	}

	public override string ToString()
	{
		throw new System.NotImplementedException();
	}

	public dynamic ValueOf()
	{
		throw new System.NotImplementedException();
	}

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

