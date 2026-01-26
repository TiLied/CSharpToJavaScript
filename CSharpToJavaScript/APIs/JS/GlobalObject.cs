using CSharpToJavaScript.Utils;

namespace CSharpToJavaScript.APIs.JS.Ecma;

public partial class GlobalObject
{
	/// <summary>
	/// Translates this method into the "===" operator.
	/// </summary>
	/// <remarks>
	/// See mdn: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Strict_equality
	/// </remarks>
	/// <param name="left">x</param>
	/// <param name="right">y</param>
	/// <returns></returns>
	[Binary("===")]
	public static bool EqualsStrict(dynamic left, dynamic right)
	{
		return left == right;
	}
	
	/// <summary>
	/// Translates this method into the "!==" operator.
	/// </summary>
	/// <remarks>
	/// See mdn: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Strict_inequality
	/// </remarks>
	/// <param name="left">x</param>
	/// <param name="right">y</param>
	/// <returns></returns>
	[Binary("!==")]
	public static bool InequalsStrict(dynamic left, dynamic right)
	{
		return left != right;
	}
	
	/// <summary>
	/// Translates this method into the "delete" operator.
	/// </summary>
	/// <remarks>
	/// See mdn: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/delete
	/// </remarks>
	/// <param name="arg">object.property</param>
	/// <returns>true for all cases except when the property is an own non-configurable property, in which case false is returned in non-strict mode.</returns>
	[Unary("delete ")]
	public static bool Delete(dynamic arg)
	{
		return true;
	}
	
	/// <summary>
	/// Translates this method into the "void" operator.
	/// </summary>
	/// <remarks>
	/// See mdn: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/void
	/// </remarks>
	/// <param name="arg">expression</param>
	/// <returns>Undefined</returns>
	[Unary("void ")]
	public static Undefined Void(dynamic arg)
	{
		return new Undefined();
	}
	
	/// <summary>
	/// Translates this method into the "typeof" operator.
	/// </summary>
	/// <remarks>
	/// See mdn: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/typeof
	/// </remarks>
	/// <param name="operand">An expression representing the object or primitive whose type is to be returned.</param>
	/// <returns>string</returns>
	[Unary("typeof ")]
	public static string TypeOf(dynamic operand)
	{
		return string.Empty;
	}
	
	/// <summary>
	/// Translates this method into the "instanceof" operator.
	/// </summary>
	/// <remarks>
	/// See mdn: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/instanceof
	/// </remarks>
	/// <param name="obj">The object to test.</param>
	/// <param name="constructor">Constructor to test against.</param>
	/// <returns>bool</returns>
	[Binary("instanceof")]
	public static bool InstanceOf(dynamic obj, dynamic constructor)
	{
		return true;
	}
	
	/// <summary>
	/// Translates this method into the "in" operator.
	/// </summary>
	/// <remarks>
	/// See mdn: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/in
	/// </remarks>
	/// <param name="prop">A string or symbol representing a property name (non-symbols will be coerced to strings). Can also be a private element identifier.</param>
	/// <param name="obj">Object to check if it (or its prototype chain) contains the property with specified name (prop).</param>
	/// <returns>bool</returns>
	[Binary("in")]
	public static bool In(dynamic prop, dynamic obj)
	{
		return true;
	}
	
	/// <summary>
	/// Translates this method into the "," operator. (As a binary)
	/// </summary>
	/// <remarks>
	/// See mdn: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Comma_operator
	/// </remarks>
	/// <param name="expr1">First expression.</param>
	/// <param name="expr2">Second expression.</param>
	/// <returns>dynamic</returns>
	[Binary(",")]
	public static dynamic Comma(dynamic expr1, dynamic expr2)
	{
		return expr2;
	}
}
