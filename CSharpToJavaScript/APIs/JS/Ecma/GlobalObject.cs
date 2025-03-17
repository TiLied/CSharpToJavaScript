//Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS.Ecma;

[To(ToAttribute.FirstCharToLowerCase)]
//https://262.ecma-international.org/14.0/#sec-global-object
public partial class GlobalObject
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public partial class GlobalThis : GlobalObject
	{
		public static Window Window { get; } = new();
		public static console Console { get; } = new();


		//
		//https://262.ecma-international.org/14.0/#sec-constructor-properties-of-the-global-object
		//https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects
		//
		//As far as I can understand, you can only access Global Object through GlobalThis in Classes.
		//It's only beneficial! We can emulate construction without "new" like GlobalThis.Date()
		//
		//
		//Not included:
		//ArrayBuffer, BigInt64Array, BigUint64Array, DataView, FinalizationRegistry,
		//Float32Array, Float64Array, Int8Array, Int16Array, Int32Array, Map, Promise,
		//Proxy, Set, SharedArrayBuffer, Uint8Array, Uint8ClampedArray, Uint16Array,
		//Uint32Array, WeakMap, WeakRef, WeakSet
			
		[To(ToAttribute.Default)]
		public static AggregateError AggregateError(object[] errors, string? message = null, object? options = null)
		{
			throw new System.NotImplementedException();
		}
			
			
		[To(ToAttribute.Default)]
		public static Array Array(params dynamic[] values)
		{
			throw new System.NotImplementedException();
		}
			
			
		[To(ToAttribute.Default)]
		public static BigInt BigInt(dynamic value)
		{
			throw new System.NotImplementedException();
		}
			

		[To(ToAttribute.Default)]
		public static bool Boolean(dynamic value)
		{
			throw new System.NotImplementedException();
		}

		[To(ToAttribute.Default)]
		public static string Date()
		{
			throw new System.NotImplementedException();
		}

			
		[To(ToAttribute.Default)]
		public static Error Error(string message, object? options = null)
		{
			throw new System.NotImplementedException();
		}

			
		[To(ToAttribute.Default)]
		public static EvalError EvalError(string message, object? options = null)
		{
			throw new System.NotImplementedException();
			
		}

		//https://262.ecma-international.org/14.0/#sec-function-p1-p2-pn-body
		//see NOTE!
		[To(ToAttribute.Default)]
		public static Function Function(dynamic parameterArgs, dynamic? bodyArg = null)
		{
			throw new System.NotImplementedException();
		}

		[To(ToAttribute.Default)]
		public static double Number(dynamic value)
		{
			throw new System.NotImplementedException();

		}

		[To(ToAttribute.Default)]
		public static Object Object(dynamic? value = null)
		{
			throw new System.NotImplementedException();

		}
			
		[To(ToAttribute.Default)]
		public static RangeError RangeError(string message, object? options = null)
		{
			throw new System.NotImplementedException();

		}
			
		[To(ToAttribute.Default)]
		public static ReferenceError ReferenceError(string message, object? options = null)
		{
			throw new System.NotImplementedException();

		}

		[To(ToAttribute.Default)]
		public static string RegExp(string pattern, string? flags = null)
		{
			throw new System.NotImplementedException();

		}
			
		[To(ToAttribute.Default)]
		public static string String(dynamic value)
		{
			throw new System.NotImplementedException();

		}

			
		[To(ToAttribute.Default)]
		public static Symbol Symbol(dynamic? description = null)
		{
			throw new System.NotImplementedException();

		}
			
		[To(ToAttribute.Default)]
		public static SyntaxError SyntaxError(string message, object? options = null)
		{
			throw new System.NotImplementedException();

		}
			
		[To(ToAttribute.Default)]
		public static TypeError TypeError(string message, object? options = null)
		{
			throw new System.NotImplementedException();

		}
			
		[To(ToAttribute.Default)]
		public static URIError URIError(string message, object? options = null)
		{
			throw new System.NotImplementedException();

		}

	}

	[To(ToAttribute.Default)]
	public class Infinity
	{

	}
	[To(ToAttribute.Default)]
	public class NaN
	{

	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public class Undefined
	{

	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static dynamic Eval(string x) 
	{
		throw new System.NotImplementedException();
	}
				
	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool IsFinite(float number)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool IsNaN(float number)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static float ParseFloat(string str)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static int ParseInt(string str, int? radix = null)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static string DecodeURI(string encodedURI)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static string DecodeURIComponent(string encodedURIComponent)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static string EncodeURI(string uri)
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static string EncodeURIComponent(string uriComponent)
	{
		throw new System.NotImplementedException();
	}
}

