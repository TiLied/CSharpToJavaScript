//Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS;

//https://262.ecma-international.org/14.0/#sec-bigint-objects
[To(ToAttribute.Default)]
public class BigInt : BigIntPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static BigIntPrototype Prototype { get; } = new();

	public BigInt(double value) { }

	[To(ToAttribute.FirstCharToLowerCase)]
	public BigInt AsIntN(Number bits, BigInt bigint) 
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public BigInt AasUintN(Number bits, BigInt bigint)
	{
		throw new System.NotImplementedException();
	}
}
public class BigIntPrototype : FunctionPrototype
{
	public BigIntPrototype() { }

	public string ToLocaleString(dynamic? reserved1 = null, dynamic? reserved2 = null) 
	{
		throw new System.NotImplementedException();
	}
	public string ToString(Number? radix = null)
	{
		throw new System.NotImplementedException();
	}
	public BigInt ValueOf()
	{
		throw new System.NotImplementedException();
	}
}
