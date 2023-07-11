using CSharpToJavaScript.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToJavaScript.APIs.JS
{
	//https://262.ecma-international.org/14.0/#sec-global-object
	public class GlobalObject
	{
		[To(ToAttribute.FirstCharToLowerCase)]
		public class GlobalThis 
		{
			public static Window Window { get; set; } = new();
			public static console Console { get; set; } = new();
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

		//Do I need this? TODO!
		//https://262.ecma-international.org/14.0/#sec-constructor-properties-of-the-global-object
		//

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
}
