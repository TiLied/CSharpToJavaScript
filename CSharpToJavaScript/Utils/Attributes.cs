using System;

namespace CSharpToJavaScript.Utils;

/// <summary>
/// 
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
internal class IgnoreAttribute : Attribute
{
	public IgnoreAttribute() { }
}

/// <summary>
/// Translates class/method to a specified value.
/// </summary>
[AttributeUsage(AttributeTargets.All)]
public class ValueAttribute : Attribute
{
	public string Value { get; init; }
	public ValueAttribute(string value)
	{
		Value = value;
	}
}

/// <summary>
/// Changes class/method based on options.
/// </summary>
/// <remarks>
/// Default: do nothing.<br />
/// ToLower: convert to lowercase.<br />
/// FirstCharToLowerCase: convert the first char to lowercase.<br />
/// None: convert to empty.<br />
/// NoneWithLeadingDotRemoved: convert to empty with the leading dot removed.<br />
/// NoneWithTailingDotRemoved: convert to empty with the trailing dot removed.<br />
/// </remarks>
[AttributeUsage(AttributeTargets.All)]
public class ToAttribute : Attribute
{
	public const string None = "None";
	public const string NoneWithLeadingDotRemoved = "NoneWithLeadingDotRemoved";
	public const string NoneWithTailingDotRemoved = "NoneWithTailingDotRemoved";
	public const string Default = "Default";
	public const string ToLower = "ToLower";
	public const string FirstCharToLowerCase = "FirstCharToLowerCase";

	public string To { get; init; } = string.Empty;
	public ToAttribute(string to)
	{
		To = to;
	}

	public string Convert(string str)
	{
		switch (To)
		{
			case ToLower:
				return str.ToLower();
			case FirstCharToLowerCase:
				return str.FirstCharToLowerCase();
			case NoneWithLeadingDotRemoved:
			case NoneWithTailingDotRemoved:
			case None:
				return "";
			case Default:
			default:
				return str;
		}
	}
}

/// <summary>
/// Translates a method into a binary operator.
/// </summary>
[AttributeUsage(AttributeTargets.All)]
public class BinaryAttribute : Attribute
{
	public string Value { get; init; }
	public BinaryAttribute(string value)
	{
		Value = value;
	}
}

/// <summary>
/// Translates a method into an unary operator.
/// </summary>
[AttributeUsage(AttributeTargets.All)]
public class UnaryAttribute : Attribute
{
	public string Value { get; init; }
	public UnaryAttribute(string value)
	{
		Value = value;
	}
}

/// <summary>
/// Translates a class into a JS object.
/// </summary>
[AttributeUsage(AttributeTargets.All)]
public class ToObjectAttribute : Attribute
{
	
}