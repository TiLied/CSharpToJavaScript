﻿using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS
{
	//https://262.ecma-international.org/14.0/#sec-number-objects
	[To(ToAttribute.Default)]
	public partial class Number : NumberPrototype
	{
		public dynamic Value { get; set; }
		public static implicit operator Number(double value) { return new Number { Value = value }; }
		public static implicit operator double(Number value) { return new Number { Value = value }; }

		[To(ToAttribute.FirstCharToLowerCase)]
		public static NumberPrototype Prototype { get; } = new();

		public const double EPSILON = 2.2204460492503130808472633361816 * 10-16;
		public const double MAX_SAFE_INTEGER = 9007199254740992;
		public const double MAX_VALUE = 1.7976931348623157 * 10308;
		public const double MIN_SAFE_INTEGER = -9007199254740991;
		public const double MIN_VALUE = 5 * 10 -324;
		public GlobalObject.NaN NaN = new();
		public const double NEGATIVE_INFINITY = double.NegativeInfinity;
		public const double POSITIVE_INFINITY = double.PositiveInfinity;

		public Number() { }
		public Number(double value) { }

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
	public class NumberPrototype
	{
		public string ToExponential(dynamic fractionDigits) 
		{
			throw new System.NotImplementedException();
		}
		public string ToFixed(dynamic fractionDigits)
		{
			throw new System.NotImplementedException();
		}
		public string ToLocaleString(dynamic? reserved1 = null, dynamic? reserved2 = null)
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
		public float ValueOf()
		{
			throw new System.NotImplementedException();
		}
	}
}
