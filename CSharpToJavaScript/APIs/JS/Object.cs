using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS
{
	[To(ToAttribute.Default)]
	public partial class Object
	{
		public Object() { }

		[To(ToAttribute.FirstCharToLowerCase)]
		public static string[] Keys(dynamic target)
		{
			throw new System.NotImplementedException();
		}
		[To(ToAttribute.FirstCharToLowerCase)]
		public static string[] Values(dynamic target)
		{
			throw new System.NotImplementedException();
		}
	}
}
