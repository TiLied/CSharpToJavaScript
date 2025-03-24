//Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-number-objects
[To(ToAttribute.Default)]
public partial class Number : NumberPrototype
{
	public dynamic? Value { get; set; }

	public static implicit operator Number(double value) { return new Number { Value = value }; }
	public static implicit operator Number(int value) { return new Number { Value = value }; }
		
	public static implicit operator double(Number value) { return new Number { Value = value }; }
	public static implicit operator int(Number value) { return new Number { Value = value }; }

	[To(ToAttribute.FirstCharToLowerCase)]
	public static NumberPrototype Prototype { get; } = new();

	public const double EPSILON = 2.2204460492503130808472633361816E-16;
	public const double MAX_SAFE_INTEGER = 9007199254740991;
	public const double MAX_VALUE = 1.79E+308;
	public const double MIN_SAFE_INTEGER = -9007199254740991;
	public const double MIN_VALUE = 5e-324;
	public GlobalObject.NaN NaN = new();
	public const double NEGATIVE_INFINITY = double.NegativeInfinity;
	public const double POSITIVE_INFINITY = double.PositiveInfinity;

	public Number() { }
	public Number(double value) { }
	public Number(int value) { }

	[To(ToAttribute.FirstCharToLowerCase)]
	public bool IsFinite(double number) 
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public bool IsInteger(double number)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public bool IsNaN(double number)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public bool IsSafeInteger(double number)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public float ParseFloat(string str)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public int ParseInt(string str, dynamic radix)
	{
		throw new System.NotImplementedException();
	}
}
[To(ToAttribute.FirstCharToLowerCase)]
public class NumberPrototype : FunctionPrototype
{
	public string ToExponential(dynamic fractionDigits) 
	{
		throw new System.NotImplementedException();
	}
	public string ToFixed(dynamic fractionDigits)
	{
		throw new System.NotImplementedException();
	}
	public new string ToLocaleString(dynamic? reserved1 = null, dynamic? reserved2 = null)
	{
		throw new System.NotImplementedException();
	}
	public string ToPrecision(dynamic precision)
	{
		throw new System.NotImplementedException();
	}
	public string ToString(dynamic? radix = null)
	{
		throw new System.NotImplementedException();
	}
	public new float ValueOf()
	{
		throw new System.NotImplementedException();
	}
}
