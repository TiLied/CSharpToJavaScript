using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace CSharpToJavaScript.Utils
{
	internal class SM
	{
		internal static void Log(string message, [CallerFilePath] string? file = null, [CallerMemberName] string? member = null, [CallerLineNumber] int line = 0)
		{
			if (message.StartsWith("---"))
				Console.ForegroundColor = ConsoleColor.Green;

			if (message.StartsWith("ERROR") || message.StartsWith("as"))
				Console.ForegroundColor = ConsoleColor.Red;

			if (message.StartsWith("WARNING"))
				Console.ForegroundColor = ConsoleColor.Yellow;

			Trace.WriteLine($"({line}):{Path.GetFileName(file)} {member}: {message}");
			Console.ResetColor();
		}
	}
}
