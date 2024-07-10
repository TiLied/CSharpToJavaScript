namespace CSharpToJavaScript.Utils
{
	public class Unsupported
	{
		public dynamic Value { get; set; }

		public static implicit operator Unsupported(string value) { return new Unsupported { Value = value }; }
		public static implicit operator Unsupported(double value) { return new Unsupported { Value = value }; }
		public static implicit operator Unsupported(float value) { return new Unsupported { Value = value }; }
		public static implicit operator Unsupported(int value) { return new Unsupported { Value = value }; }
	}
}
