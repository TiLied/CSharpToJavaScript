using System;


namespace CSharpToJavaScript.Utils
{
	[AttributeUsage(AttributeTargets.Class)]
	internal class IgnoreAttribute : Attribute
	{
		public IgnoreAttribute() { }
	}

	[AttributeUsage(AttributeTargets.All)]
	internal class ValueAttribute : Attribute
	{
		public string Value { get; init; }
		public ValueAttribute(string value) 
		{
			Value = value;
		}
	}

	[AttributeUsage(AttributeTargets.All)]
	public class ToAttribute : Attribute
	{
		public const string None = "None";
		public const string Default = "Default";
		public const string ToLower = "ToLower";
		public const string FirstCharToLowerCase = "FirstCharToLowerCase";

		public string To { get; set; } = string.Empty;
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
				case None:
					return "";
				case Default:
				default: 
					return str;
			}
		}
	}
}
