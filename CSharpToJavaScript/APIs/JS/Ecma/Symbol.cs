//Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-symbol-objects
[To(ToAttribute.Default)]
public partial class Symbol : SymbolPrototype
{
	//TODO! How?
	//https://262.ecma-international.org/14.0/#sec-symbol.asynciterator
	//https://262.ecma-international.org/14.0/#sec-symbol.hasinstance
	//https://262.ecma-international.org/14.0/#sec-symbol.iterator
	//https://262.ecma-international.org/14.0/#sec-symbol.match
	//https://262.ecma-international.org/14.0/#sec-symbol.matchall
	//https://262.ecma-international.org/14.0/#sec-symbol.replace
	//https://262.ecma-international.org/14.0/#sec-symbol.search
	//https://262.ecma-international.org/14.0/#sec-symbol.species
	//https://262.ecma-international.org/14.0/#sec-symbol.split
	//https://262.ecma-international.org/14.0/#sec-symbol.toprimitive
	//https://262.ecma-international.org/14.0/#sec-symbol.tostringtag
	//https://262.ecma-international.org/14.0/#sec-symbol.unscopables

	[To(ToAttribute.FirstCharToLowerCase)]
	public SymbolPrototype Prototype { get; } = new();

	[To(ToAttribute.Default)]
	public Symbol(string description = "") 
	{

	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static Symbol For(string key) 
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static string KeyFor(Symbol sym)
	{
		throw new System.NotImplementedException();
	}
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class SymbolPrototype : FunctionPrototype
{
	public string Description { get; } = string.Empty;
	public SymbolPrototype() { }
	public string ToString(dynamic? radix = null)
	{
		throw new System.NotImplementedException();
	}
	public new Symbol ValueOf()
	{
		throw new System.NotImplementedException();
	}

}
