using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS.Ecma;

public partial class GlobalObject
{
	[Binary("===")]
	public static bool EqualsStrict(dynamic left, dynamic right)
	{
		return left == right;
	}
	[Binary("!==")]
	public static bool InequalsStrict(dynamic left, dynamic right)
	{
		return left != right;
	}
	[Unary("delete ")]
	public static bool Delete(dynamic arg)
	{
		return true;
	}
	[Unary("void ")]
	public static Undefined Void(dynamic arg)
	{
		return new Undefined();
	}
	[Unary("typeof ")]
	public static string TypeOf(dynamic arg)
	{
		return string.Empty;
	}
	[Binary("instanceof")]
	public static bool InstanceOf(dynamic left, dynamic right)
	{
		return true;
	}
}
