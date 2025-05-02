//TODO! Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-arraybuffer-objects
[To(ToAttribute.Default)]
public partial class ArrayBuffer : ArrayBufferPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static ArrayBufferPrototype Prototype { get; } = new();
	public ArrayBuffer(int length) { }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool IsView(Object arg)
	{
		throw new System.NotImplementedException();
	}
}

[To(ToAttribute.FirstCharToLowerCase)]
public class ArrayBufferPrototype : FunctionPrototype
{
	public int ByteLength { get; } = 0;
	public ArrayBufferPrototype() { }
	public ArrayBuffer Slice(int start = 0, int end = 0)
	{
		throw new System.NotImplementedException();
	}
}
