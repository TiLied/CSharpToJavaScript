using CSharpToJavaScript.APIs.JS.Ecma;

namespace CSharpToJavaScript.Utils;

public class Unsupported
{
	public dynamic Value { get; set; }

	public static implicit operator Unsupported(string value) { return new Unsupported { Value = value }; }
	public static implicit operator Unsupported(double value) { return new Unsupported { Value = value }; }
	public static implicit operator Unsupported(float value) { return new Unsupported { Value = value }; }
	public static implicit operator Unsupported(int value) { return new Unsupported { Value = value }; }
	public static implicit operator Unsupported(Object value) { return new Unsupported { Value = value }; }

	public static implicit operator string(Unsupported value) { return new Unsupported { Value = value }; }
	public static implicit operator double(Unsupported value) { return new Unsupported { Value = value }; }
	public static implicit operator float(Unsupported value) { return new Unsupported { Value = value }; }
	public static implicit operator int(Unsupported value) { return new Unsupported { Value = value }; }
	public static implicit operator Object(Unsupported value) { return new Unsupported { Value = value }; }
}

