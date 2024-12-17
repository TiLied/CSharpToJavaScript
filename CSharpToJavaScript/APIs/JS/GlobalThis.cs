using CSharpToJavaScript.Utils;


namespace CSharpToJavaScript.APIs.JS
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static class GlobalThis
	{
		public static Window Window { get; set; } = new();
		public static console Console { get; set; } = new();

	}
}
