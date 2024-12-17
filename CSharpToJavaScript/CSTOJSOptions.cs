using CSharpToJavaScript.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpToJavaScript
{
	/// <summary>
	/// Options for <see cref="CSTOJS" />.
	/// </summary>
	public record class CSTOJSOptions
	{
		/// <summary>
		/// Debug. When set to true prints additional info to console, cs lines to js file.
		/// </summary>
		/// <value>
		/// Default: <c>false</c>
		/// </value>
		public bool Debug { get; set; } = false;


        /// <summary>
        /// Self-explanatory, Disable Console Colors.
        /// </summary>
        /// <value>
        /// Default: <c>false</c>
        /// </value>
        public bool DisableConsoleColors { get; set; } = false;

		/// <summary>
		/// Self-explanatory, Disable Console Output.
		/// </summary>
		/// <value>
		/// Default: <c>false</c>
		/// </value>
		public bool DisableConsoleOutput { get; set; } = false;

		/// <summary>
		/// Output path for javascript file/files.
		/// </summary>
		/// <value>
		/// Default: <see cref="Directory.GetCurrentDirectory()" />
		/// </value>
		public string OutPutPath { get; set; } = Directory.GetCurrentDirectory();

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
		/// Replace '<c>==</c>' with '<c>===</c>'.
		/// </summary>
		/// <value>
		/// Default: <c>false</c>
		/// </value>
		public bool UseStrictEquality { get; set; } = false;

		/// <summary>
		/// List of custom names to convert.
		/// </summary>
		/// <remarks>Example: <c>new List&lt;Tuple&lt;string, string&gt;&gt;(){new Tuple&lt;string, string&gt;("Console", "console")}</c>. Will convert "Console" to "console".</remarks>
		/// <value>
		/// Default: <c>new()</c>
		/// </value>
		public List<Tuple<string, string>> CustomCSNamesToJS { get; set; } = new();
		/// <summary>
		/// List of types to convert.
		/// </summary>
		/// <remarks>Example: Similar to <see cref="CSTOJSOptions.CustomCSNamesToJS" />, but convers the type. You need to use <see cref="ToAttribute" />.</remarks>
		/// <value>
		/// Default: <c>new()</c>
		/// </value>
		public List<Type> CustomCSTypesToJS { get; set; } = new();

		/// <summary>
		/// Add a <see cref="StringBuilder" /> to the front of a javascript file.
		/// </summary>
		/// <remarks>Note! When passing a folder path to <see cref="CSTOJS.GenerateOneAsync(string, string?)" /> applies to every file!</remarks>
		/// <value>
		/// Default: <c>new()</c>
		/// </value>
		public StringBuilder AddSBInFront { get; set; } = new();
		/// <summary>
		/// Add a <see cref="StringBuilder" /> to the end of a javascript file.
		/// </summary>
		/// <remarks>Note! When passing a folder path to <see cref="CSTOJS.GenerateOneAsync(string, string?)" /> applies to every file!</remarks>
		/// <value>
		/// Default: <c>new()</c>
		/// </value>
		public StringBuilder AddSBInEnd { get; set; } = new();
		/// <summary>
		/// Creates new default options. See <see cref="CSTOJSOptions" />.
		/// </summary>
		public CSTOJSOptions() 
		{

		}
	}
}
