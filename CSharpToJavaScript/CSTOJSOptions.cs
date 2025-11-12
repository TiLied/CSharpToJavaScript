using CSharpToJavaScript.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpToJavaScript
{
	/// <summary>
	/// Options for <see cref="CSTOJS" />.
	/// </summary>
	public class CSTOJSOptions
	{
		/// <summary>
		/// Debug. When set to true prints additional info to console, cs lines to js file.
		/// </summary>
		/// <value>
		/// Default: <c>false</c>
		/// </value>
		public bool Debug { get; set; } = false;
		/// <summary>
		/// Useful for the tests.
		/// </summary>
		/// <value>
		/// Default: <c>false</c>
		/// </value>
		public bool DisableCompilationErrors { get; set; } = false;
		
		/// <summary>
		/// Self-explanatory, Use <c>var</c> over <c>let</c>.
		/// </summary>
		/// <value>
		/// Default: <c>false</c>
		/// </value>
		public bool UseVarOverLet { get; set; } = false;

		/// <summary>
		/// Keep Brace <c>{</c> on the same line. 
		/// </summary>
		/// <remarks>
		/// <blockquote class="NOTE"><h5>NOTE</h5><para>Note: It is better write from the start in c#, then using this option.</para></blockquote>
		/// </remarks>
		/// <value>
		/// Default: <c>false</c>
		/// </value>
		public bool KeepBraceOnTheSameLine { get; set; } = false;

		/// <summary>
		/// Self-explanatory, Normalize Whitespace.
		/// </summary>
		/// <remarks>
		/// <blockquote class="NOTE"><h5>NOTE</h5><para>Note: If using with <see cref="CSTOJSOptions.KeepBraceOnTheSameLine" />. Normalization running before <see cref="CSTOJSOptions.KeepBraceOnTheSameLine" />.</para></blockquote>
		/// </remarks>
		/// <value>
		/// Default: <c>false</c>
		/// </value>
		public bool NormalizeWhitespace { get; set; } = false;

		/// <summary>
		/// Replace '<c>==</c>' with '<c>===</c>' and '<c>!=</c>' with '<c>!==</c>'.
		/// </summary>
		/// <value>
		/// Default: <c>false</c>
		/// </value>
		public bool UseStrictEquality { get; set; } = false;

		/// <summary>
		/// Translate current <see cref="FileData" />. If false, walker will not be called.
		/// </summary>
		/// <value>
		/// Default: <c>true</c>
		/// </value>
		public bool TranslateFile { get; set; } = true;

		/// <summary>
		/// Array of custom names to convert.
		/// </summary>
		/// <remarks>Example: <c>new(){["Console"] = "console"}</c>. Will convert "Console" to "console".</remarks>
		/// <value>
		/// Default: <c>new()</c>
		/// </value>
		public Dictionary<string, string> CustomCSNamesToJS { get; set; } = new();

		/// <summary>
		/// Array of types to convert.
		/// </summary>
		/// <remarks>Example: Similar to <see cref="CSTOJSOptions.CustomCSNamesToJS" />, but convers the type. You need to use <see cref="ToAttribute" />.</remarks>
		/// <value>
		/// Default: <c>new()</c>
		/// </value>
		public Type[] CustomCSTypesToJS { get; set; } = [];

		/// <summary>
		/// Add a <see cref="StringBuilder" /> to the front of a javascript file.
		/// </summary>
		/// <value>
		/// Default: <c>new()</c>
		/// </value>
		public StringBuilder AddSBAtTheTop { get; set; } = new();

		/// <summary>
		/// Add a <see cref="StringBuilder" /> to the end of a javascript file.
		/// </summary>
		/// <value>
		/// Default: <c>new()</c>
		/// </value>
		public StringBuilder AddSBAtTheBottom { get; set; } = new();

		/// <summary>
		/// Creates new default options. See <see cref="CSTOJSOptions" />.
		/// </summary>
		public CSTOJSOptions()
		{

		}
	}
}
