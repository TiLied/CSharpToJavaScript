using CSharpToJavaScript.Utils;
using System.Diagnostics.CodeAnalysis;

namespace CSharpToJavaScript.APIs.JS
{
	//https://262.ecma-international.org/14.0/#sec-regexp-regular-expression-objects
	[To(ToAttribute.Default)]
	public partial class RegExp : RegExpPrototype
	{
		[To(ToAttribute.FirstCharToLowerCase)]
		public static RegExpPrototype Prototype { get; } = new();

		public RegExp([StringSyntax(StringSyntaxAttribute.Regex)] string pattern) { }
		public RegExp([StringSyntax(StringSyntaxAttribute.Regex)] string pattern, string flags) { }
	}

	//TODO! match etc.!!!! How? Extension methods?
	[To(ToAttribute.FirstCharToLowerCase)]
	public class RegExpPrototype : FunctionPrototype
	{
		public bool DotAll { get; }
		public string Flags { get; }
		public bool Global { get; }
		public bool HasIndices { get; }
		public bool IgnoreCase { get; }
		public bool Multiline { get; }
		public string Source { get; }
		public bool Sticky { get; }
		public bool Unicode { get; }

		public RegExpPrototype() { }

		public string[] Exec(string str)
		{
			throw new System.NotImplementedException();
		}

		public bool Test(string S)
		{
			throw new System.NotImplementedException();
		}

		public string ToString()
		{
			throw new System.NotImplementedException();
		}
	}
}
