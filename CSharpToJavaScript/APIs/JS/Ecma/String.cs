//TODO! Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;
using System.Text.RegularExpressions;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-string-objects
[To(ToAttribute.Default)]
public partial class String : StringPrototype
{
	public dynamic? Value { get; set; }

	public static implicit operator String(string value) { return new String(value) { Value = value }; }
	public static implicit operator string(String value) { return new String(value) { Value = value }; }

	[To(ToAttribute.FirstCharToLowerCase)]
	public StringPrototype Prototype { get; } = new();

	[To(ToAttribute.FirstCharToLowerCase)]
	public int Length { get; } = 0;

	[To(ToAttribute.Default)]
	public String(string value = "") { }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static string FromCharCode(params Number[] codeUnits) 
	{
		throw new System.NotImplementedException();
	}
	[To(ToAttribute.FirstCharToLowerCase)]
	public static string FromCodePoint(params Number[] codePoints)
	{
		throw new System.NotImplementedException();
	}
	//TODO template
	[To(ToAttribute.FirstCharToLowerCase)]
	public static string Raw(dynamic template, params string[] substitutions)
	{
		throw new System.NotImplementedException();
	}

}
	
[To(ToAttribute.FirstCharToLowerCase)]
public partial class StringPrototype : FunctionPrototype
{
	public StringPrototype() { }

	public int At(int index) 
	{
		throw new System.NotImplementedException();
	}
	public string CharAt(int pos)
	{
		throw new System.NotImplementedException();
	}
	public int CharCodeAt(int pos)
	{
		throw new System.NotImplementedException();
	}
	public int CodePointAt(int pos)
	{
		throw new System.NotImplementedException();
	}
	public string Concat(params string[] args )
	{
		throw new System.NotImplementedException();
	}
	public bool EndsWith(string searchString, int endPosition = 0 )
	{
		throw new System.NotImplementedException();
	}
	public bool Includes(string searchString, int position = 0 )
	{
		throw new System.NotImplementedException();
	}
	public bool IndexOf(string searchString, int position = 0 )
	{
		throw new System.NotImplementedException();
	}
	public bool LastIndexOf(string searchString, int position = 0 )
	{
		throw new System.NotImplementedException();
	}
	public int LocaleCompare(string that, dynamic? reserved1 = null, dynamic? reserved2 = null )
	{
		throw new System.NotImplementedException();
	}
	public dynamic[] Match(RegExp regexp)
	{
		throw new System.NotImplementedException();
	}
	public dynamic[] MatchAll(RegExp regexp )
	{
		throw new System.NotImplementedException();
	}
	public string Normalize(string form = "NFC")
	{
		throw new System.NotImplementedException();
	}
	public string PadEnd(int maxLength, string fillString = "" )
	{
		throw new System.NotImplementedException();
	}
	public string PadStart(int maxLength, string fillString = "")
	{
		throw new System.NotImplementedException();
	}
	public string Repeat(int count )
	{
		throw new System.NotImplementedException();
	}
	public string Replace(string searchValue, string replaceValue )
	{
		throw new System.NotImplementedException();
	}
	public string ReplaceAll(string searchValue, string replaceValue )
	{
		throw new System.NotImplementedException();
	}
	public int Search(Regex regexp )
	{
		throw new System.NotImplementedException();
	}
	public string Slice(int start,int end )
	{
		throw new System.NotImplementedException();
	}
	public string[] Split(string separator, int limit = 0)
	{
		throw new System.NotImplementedException();
	}
	public bool StartsWith(string searchString, int position = 0 )
	{
		throw new System.NotImplementedException();
	}
	public string Substring(int start,int end = 0)
	{
		throw new System.NotImplementedException();
	}
	public string ToLocaleLowerCase(dynamic? reserved1 = null, dynamic? reserved2 = null)
	{
		throw new System.NotImplementedException();
	}
	public string ToLocaleUpperCase(dynamic? reserved1 = null, dynamic? reserved2 = null)
	{
		throw new System.NotImplementedException();
	}
	public string ToLowerCase()
	{
		throw new System.NotImplementedException();
	}
	public new string ToString()
	{
		throw new System.NotImplementedException();
	}
	public string ToUpperCase()
	{
		throw new System.NotImplementedException();
	}
	public string Trim()
	{
		throw new System.NotImplementedException();
	}
	public string TrimEnd()
	{
		throw new System.NotImplementedException();
	}
	public string TrimStart()
	{
		throw new System.NotImplementedException();
	}
	public new String ValueOf()
	{
		throw new System.NotImplementedException();
	}
}
