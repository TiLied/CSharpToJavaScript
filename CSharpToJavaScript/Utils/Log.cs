﻿using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace CSharpToJavaScript.Utils
{
	internal static class Log
	{
		private static bool _SupportedOS = true;
		static Log()
		{
			Trace.Listeners.Add(new ConsoleTraceListener());

			//https://learn.microsoft.com/en-us/dotnet/api/system.console.foregroundcolor?view=net-9.0
			if (OperatingSystem.IsAndroid() || OperatingSystem.IsBrowser() || OperatingSystem.IsIOS() || OperatingSystem.IsTvOS())
				_SupportedOS = false;
		}

		public static void WriteLine(string message, CSTOJSOptions options)
		{
			if (options.DisableConsoleOutput == true)
				return;

			Trace.Write($"{DateTime.Now.ToLongTimeString()}: ");
			Trace.WriteLine($"{message}");
		}

		public static void InfoLine(string message, CSTOJSOptions options)
		{
			if (options.DisableConsoleOutput == true)
				return;

			Trace.Write($"{DateTime.Now.ToLongTimeString()}: ");

			if (_SupportedOS && options.DisableConsoleColors == false)
				Console.ForegroundColor = ConsoleColor.Green;

			Trace.WriteLine($"\t{message}");

			if (_SupportedOS && options.DisableConsoleColors == false)
				Console.ResetColor();
		}

		public static void WarningLine(string message, CSTOJSOptions options, [CallerFilePath] string? file = null, [CallerMemberName] string? member = null, [CallerLineNumber] int line = 0)
		{
			if (options.DisableConsoleOutput == true)
				return;

			Trace.Write($"{DateTime.Now.ToLongTimeString()}: ");

			if (_SupportedOS && options.DisableConsoleColors == false)
				Console.ForegroundColor = ConsoleColor.Cyan;

			Trace.WriteLine($"({line}){Path.GetFileName(file?.Replace("\\", "/"))}.{member}:");
			Trace.Write("\tMessage: ");

			if (_SupportedOS && options.DisableConsoleColors == false)
				Console.ForegroundColor = ConsoleColor.Yellow;
			
			Trace.WriteLine($"{message}");
			
			if (_SupportedOS && options.DisableConsoleColors == false)
				Console.ResetColor();
		}

		public static void ErrorLine(string message, CSTOJSOptions options, [CallerFilePath] string? file = null, [CallerMemberName] string? member = null, [CallerLineNumber] int line = 0)
		{
			if (options.DisableConsoleOutput == true)
				return;

			Trace.Write($"{DateTime.Now.ToLongTimeString()}: ");

			if (_SupportedOS && options.DisableConsoleColors == false)
				Console.ForegroundColor = ConsoleColor.Cyan;

			string lineInfo = $"({line}){Path.GetFileName(file?.Replace("\\", "/"))}.{member}:";
			
			Trace.WriteLine(lineInfo);
			Trace.Write("\tMessage: ");

			if (_SupportedOS && options.DisableConsoleColors == false)
				Console.ForegroundColor = ConsoleColor.Red;

			Debug.Assert(false, $"{lineInfo} \tMessage: {message}");

			Trace.WriteLine($"{message}");

			if (_SupportedOS && options.DisableConsoleColors == false)
				Console.ResetColor();
		}
	}
}
