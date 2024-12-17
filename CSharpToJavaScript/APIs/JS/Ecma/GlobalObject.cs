using CSharpToJavaScript.Utils;


namespace CSharpToJavaScript.APIs.JS
{
	[To(ToAttribute.FirstCharToLowerCase)]
	//https://262.ecma-international.org/14.0/#sec-global-object
	public partial class GlobalObject
	{
		[To(ToAttribute.FirstCharToLowerCase)]
		public class GlobalThis : GlobalObject
		{
			public static Window Window { get; } = new();
			public static console Console { get; set; } = new();

			[To(ToAttribute.Default)]
			public static string Date(string x)
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

		//Do I need this? TODO!
		//https://262.ecma-international.org/14.0/#sec-constructor-properties-of-the-global-object
		//https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects
		//
		//DO THIS IN !GlobalThis!
		//As far as I can understand, you can only access Global Object through GlobalThis in Classes.
		//It's only beneficial! We can emulate construction without "new" like GlobalThis.Date()
		//DO THIS IN !GlobalThis!
		//
		//[To(ToAttribute.Default)]
		//public static string Date(string x)
		//{
		//throw new System.NotImplementedException();
		//}

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
