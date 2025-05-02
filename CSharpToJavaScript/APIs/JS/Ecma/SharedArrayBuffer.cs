//TODO! Disable missing XML comments.
#pragma warning disable CS1591
using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-sharedarraybuffer-objects
[To(ToAttribute.Default)]
public partial class SharedArrayBuffer : SharedArrayBufferPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static SharedArrayBufferPrototype Prototype { get; } = new();
	public SharedArrayBuffer(int length) { }

}
[To(ToAttribute.FirstCharToLowerCase)]
public class SharedArrayBufferPrototype : FunctionPrototype 
{
	public int ByteLength { get; } = 0;
	public SharedArrayBufferPrototype() { }
	public SharedArrayBuffer Slice(int start = 0, int end = 0)
	{
		throw new System.NotImplementedException();
	}
}
