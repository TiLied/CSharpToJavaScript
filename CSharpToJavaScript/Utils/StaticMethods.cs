using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace CSharpToJavaScript.Utils
{
	internal class SM
	{
		internal static void Log(string message, [CallerFilePath] string? file = null, [CallerMemberName] string? member = null, [CallerLineNumber] int line = 0)
		{
			Trace.WriteLine($"({line}):{Path.GetFileName(file)} {member}: {message}");
		}
	}
}
