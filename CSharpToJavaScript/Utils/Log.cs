using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace CSharpToJavaScript.Utils;

/// <summary>
/// Logging.
/// </summary>
public static class Log
{
	private static bool _SupportedOS = true;

	/// <summary>
	/// Self-explanatory, Disable Console Colors.
	/// </summary>
	/// <value>
	/// Default: <c>false</c>
	/// </value>
	public static bool DisableConsoleColors { get; set; } = false;

	/// <summary>
	/// Self-explanatory, Disable Console Output.
	/// </summary>
	/// <value>
	/// Default: <c>false</c>
	/// </value>
	public static bool DisableConsoleOutput { get; set; } = false;

	static Log()
	{
		Trace.Listeners.Add(new ConsoleTraceListener());

		//https://learn.microsoft.com/en-us/dotnet/api/system.console.foregroundcolor?view=net-9.0
		if (OperatingSystem.IsAndroid() || OperatingSystem.IsBrowser() || OperatingSystem.IsIOS() || OperatingSystem.IsTvOS())
			_SupportedOS = false;
	}
	
	/// <summary>
	/// Log a simple message.
	/// </summary>
	/// <param name="message">Required. Custom message.</param>
	public static void WriteLine(string message)
	{
		if (DisableConsoleOutput == true)
			return;

		Trace.Write($"{DateTime.UtcNow.ToString("hh:mm:ss.fffffff")}: ");
		Trace.WriteLine($"{message}");
	}
	
	/// <summary>
	/// Log an info message.
	/// </summary>
	/// <param name="message">Required. Custom message.</param>
	public static void InfoLine(string message)
	{
		if (DisableConsoleOutput == true)
			return;

		Trace.Write($"{DateTime.UtcNow.ToString("hh:mm:ss.fffffff")}: ");

		if (_SupportedOS && DisableConsoleColors == false)
			Console.ForegroundColor = ConsoleColor.Green;
		Trace.Write("Info: ");
		if (_SupportedOS && DisableConsoleColors == false)
			Console.ResetColor();

		Trace.WriteLine($"\t{message}");
	}
	
	/// <summary>
	/// Log a warning message.
	/// </summary>
	/// <param name="message">Required. Custom message.</param>
	/// <param name="file">Optional. Ignore</param>
	/// <param name="member">Optional. Ignore</param>
	/// <param name="line">Optional. Ignore</param>
	public static void WarningLine(string message, [CallerFilePath] string? file = null, [CallerMemberName] string? member = null, [CallerLineNumber] int line = 0)
	{
		if (DisableConsoleOutput == true)
			return;

		Trace.Write($"{DateTime.UtcNow.ToString("hh:mm:ss.fffffff")}: ");

		if (_SupportedOS && DisableConsoleColors == false)
			Console.ForegroundColor = ConsoleColor.Cyan;

		Trace.WriteLine($"({line}){Path.GetFileName(file?.Replace("\\", "/"))}.{member}:");

		if (_SupportedOS && DisableConsoleColors == false)
			Console.ForegroundColor = ConsoleColor.Yellow;
		Trace.Write("\tWarning: ");
		if (_SupportedOS && DisableConsoleColors == false)
			Console.ResetColor();

		Trace.WriteLine($"{message}");
	}

	/// <summary>
	/// Log an error message.
	/// </summary>
	/// <param name="message">Required. Custom message.</param>
	/// <param name="file">Optional. Ignore</param>
	/// <param name="member">Optional. Ignore</param>
	/// <param name="line">Optional. Ignore</param>
	public static void ErrorLine(string message, [CallerFilePath] string? file = null, [CallerMemberName] string? member = null, [CallerLineNumber] int line = 0)
	{
		if (DisableConsoleOutput == true)
			return;

		Trace.Write($"{DateTime.UtcNow.ToString("hh:mm:ss.fffffff")}: ");

		if (_SupportedOS && DisableConsoleColors == false)
			Console.ForegroundColor = ConsoleColor.Cyan;

		string lineInfo = $"({line}){Path.GetFileName(file?.Replace("\\", "/"))}.{member}:";

		Trace.WriteLine(lineInfo);

		if (_SupportedOS && DisableConsoleColors == false)
			Console.ForegroundColor = ConsoleColor.Red;
		Trace.Write("\tERROR: ");
		if (_SupportedOS && DisableConsoleColors == false)
			Console.ResetColor();

		Debug.Assert(false, $"{lineInfo} \tMessage: {message}");

		Trace.WriteLine($"{message}");
	}
}

