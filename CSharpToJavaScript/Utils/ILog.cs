using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace CSharpToJavaScript.Utils
{
	internal interface ILog
	{
		private static CSTOJSOptions _Options = new();
		public static ILog GetILog(CSTOJS cstojs, CSTOJSOptions options)
		{
			_Options = options;
			return cstojs;
		}
		public void WriteLine(string message)
		{
			if (_Options.DisableConsoleOutput == true)
				return;

			Console.Write($"{DateTime.Now.ToLongTimeString()}: ");
			Console.Write($"{message}");

			Console.WriteLine();
		}

		public virtual void SuccessLine(string message)
		{
			if (_Options.DisableConsoleOutput == true)
				return;

			Console.Write($"{DateTime.Now.ToLongTimeString()}: ");

			if (_Options.DisableConsoleColors == false)
				Console.ForegroundColor = ConsoleColor.Green;

			Console.Write($"\t{message}");

			if (_Options.DisableConsoleColors == false)
				Console.ResetColor();

			Console.WriteLine();
		}

		public void WarningLine(string message, [CallerFilePath] string? file = null, [CallerMemberName] string? member = null, [CallerLineNumber] int line = 0)
		{
			if (_Options.DisableConsoleOutput == true)
				return;

			Console.Write($"{DateTime.Now.ToLongTimeString()}: ");

			if (_Options.DisableConsoleColors == false)
				Console.ForegroundColor = ConsoleColor.Cyan;

			Console.Write($"({line}){Path.GetFileName(file?.Replace("\\", "/"))}.{member}:");
			Console.WriteLine();
			Console.Write("\tMessage: ");

			if (_Options.DisableConsoleColors == false)
				Console.ForegroundColor = ConsoleColor.Yellow;
			
			Console.Write($"{message}");
			
			if (_Options.DisableConsoleColors == false)
				Console.ResetColor();

			Console.WriteLine();
		}

		public void ErrorLine(string message, [CallerFilePath] string? file = null, [CallerMemberName] string? member = null, [CallerLineNumber] int line = 0)
		{
			if (_Options.DisableConsoleOutput == true)
				return;

			Console.Write($"{DateTime.Now.ToLongTimeString()}: ");

			if (_Options.DisableConsoleColors == false)
				Console.ForegroundColor = ConsoleColor.Cyan;

			Console.Write($"({line}){Path.GetFileName(file?.Replace("\\", "/"))}.{member}:");
			Console.WriteLine();
			Console.Write("\tMessage: ");

			if (_Options.DisableConsoleColors == false)
				Console.ForegroundColor = ConsoleColor.Red;

			Console.Write($"{message}");

			if (_Options.DisableConsoleColors == false)
				Console.ResetColor();

			Console.WriteLine();
		}
	}
}
