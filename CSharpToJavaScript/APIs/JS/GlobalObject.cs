using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS.Ecma;

public partial class GlobalObject
{
	[To(ToAttribute.Default)]
	public static bool EqualsStrict(dynamic left, dynamic right)
	{
		return left == right;
	}
	[To(ToAttribute.Default)]
	public static bool InequalsStrict(dynamic left, dynamic right)
	{
		return left != right;
	}
}