using System;

namespace CSharpToJavaScript.Utils
{
	internal static class Extensions
	{
		//https://stackoverflow.com/a/21755933
		public static string? FirstCharToLowerCase(this string? str)
		{
			if (!string.IsNullOrEmpty(str) && char.IsUpper(str[0]))
				return str.Length == 1 ? char.ToLower(str[0]).ToString() : char.ToLower(str[0]) + str[1..];

			return str;
		}
		public static string? FirstCharToUpperCase(this string? str)
		{
			if (!string.IsNullOrEmpty(str) && char.IsLower(str[0]))
				return str.Length == 1 ? char.ToUpper(str[0]).ToString() : char.ToUpper(str[0]) + str[1..];

			return str;
		}

		public static bool Contains(this string source, string toCheck, StringComparison comp)
		{
			return source?.IndexOf(toCheck, comp) >= 0;
		}
	}
}
