using Microsoft.CodeAnalysis;

namespace CSharpToJavaScript.Utils;

internal class PredefinedAnnotations
{
	//
	//Kinds
	public const string Global_Kind = "Global";
	public const string GlobalBuiltIn_Kind = "GlobalBuiltIn";

	//
	//Datas/Annotations
	public const string CheckStringForComposite_Data  = "CheckStringForComposite";
	public static SyntaxAnnotation CheckStringForComposite { get; } = new(Global_Kind, CheckStringForComposite_Data);

	public const string StaticConstructor_Data = "StaticConstructor";
	public static SyntaxAnnotation StaticConstructor { get; } = new(Global_Kind, StaticConstructor_Data);

	public const string IgnoreAttribute_Data = "IgnoreAttribute";
	public static SyntaxAnnotation IgnoreAttribute { get; } = new(Global_Kind, IgnoreAttribute_Data);
	public const string BinaryAttribute_Data = "BinaryAttribute";
	public static SyntaxAnnotation BinaryAttribute { get; } = new(Global_Kind, BinaryAttribute_Data);
	public const string UnaryAttribute_Data = "UnaryAttribute";
	public static SyntaxAnnotation UnaryAttribute { get; } = new(Global_Kind, UnaryAttribute_Data);
	public const string ToObjectAttribute_Data = "ToObjectAttribute";
	public static SyntaxAnnotation ToObjectAttribute { get; } = new(Global_Kind, ToObjectAttribute_Data);
	
	public const string EqualsEqualsEquals_Data = "===";
	public static SyntaxAnnotation EqualsEqualsEquals { get; } = new(Global_Kind, EqualsEqualsEquals_Data);
	public const string ExclamationEqualsEquals_Data = "!==";
	public static SyntaxAnnotation ExclamationEqualsEquals { get; } = new(Global_Kind, ExclamationEqualsEquals_Data);
}