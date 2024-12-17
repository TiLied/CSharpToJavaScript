using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace CSharpToJavaScript.Utils
{
	internal interface ILog
	{
		private static CSTOJSOptions _Options = new();
		static ILog()
		{
			Trace.Listeners.Add(new ConsoleTraceListener());
		}
		public static ILog GetILog(CSTOJS cstojs, CSTOJSOptions options)
		{
			_Options = options;
			return cstojs;
		}
		public void WriteLine(string message)
		{
			if (_Options.DisableConsoleOutput == true)
				return;

			Trace.Write($"{DateTime.Now.ToLongTimeString()}: ");
			Trace.WriteLine($"{message}");
		}

		public void SuccessLine(string message)
		{
			if (_Options.DisableConsoleOutput == true)
				return;

			Trace.Write($"{DateTime.Now.ToLongTimeString()}: ");

			if (_Options.DisableConsoleColors == false)
				Console.ForegroundColor = ConsoleColor.Green;

			Trace.WriteLine($"\t{message}");

			if (_Options.DisableConsoleColors == false)
				Console.ResetColor();
		}

		public void WarningLine(string message, [CallerFilePath] string? file = null, [CallerMemberName] string? member = null, [CallerLineNumber] int line = 0)
		{
			if (_Options.DisableConsoleOutput == true)
				return;

			Trace.Write($"{DateTime.Now.ToLongTimeString()}: ");

			if (_Options.DisableConsoleColors == false)
				Console.ForegroundColor = ConsoleColor.Cyan;

			Trace.WriteLine($"({line}){Path.GetFileName(file?.Replace("\\", "/"))}.{member}:");
			Trace.Write("\tMessage: ");

			if (_Options.DisableConsoleColors == false)
				Console.ForegroundColor = ConsoleColor.Yellow;
			
			Trace.WriteLine($"{message}");
			
			if (_Options.DisableConsoleColors == false)
				Console.ResetColor();
		}

		public void ErrorLine(string message, [CallerFilePath] string? file = null, [CallerMemberName] string? member = null, [CallerLineNumber] int line = 0)
		{
			if (_Options.DisableConsoleOutput == true)
				return;

			Trace.Write($"{DateTime.Now.ToLongTimeString()}: ");

			if (_Options.DisableConsoleColors == false)
				Console.ForegroundColor = ConsoleColor.Cyan;

			Trace.WriteLine($"({line}){Path.GetFileName(file?.Replace("\\", "/"))}.{member}:");
			Trace.Write("\tMessage: ");

			if (_Options.DisableConsoleColors == false)
				Console.ForegroundColor = ConsoleColor.Red;

			Trace.WriteLine($"{message}");

			if (_Options.DisableConsoleColors == false)
				Console.ResetColor();
		}
	}
}
