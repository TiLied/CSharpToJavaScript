using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpToJavaScript
{
	/// <summary>
	/// Options for <see cref="CSTOJS" />.
	/// </summary>
	public class CSTOJSOptions
	{
		/// <summary>
		/// Debug. When set to true prints additional info to console, cs lines to js file and creates file Debug.txt 
		/// </summary>
		/// <value>
		/// Default: <c>false</c>
		/// </value>
		public bool Debug { get; set; } = false;


		/// <summary>
		/// Output path for javascript file.
		/// </summary>
		/// <value>
		/// Default: <c>Directory.GetCurrentDirectory()</c>
		/// </value>
		public string OutPutPath { get; set; } = Directory.GetCurrentDirectory();
		/// <summary>
		/// Output javascript file name.
		/// </summary>
		/// <value>
		/// Default: <c>main.js</c>
		/// </value>
		public string OutPutFileName { get; set; } = "main.js";

		/// <summary>
		/// Self-explanatory, Use var over let.
		/// </summary>
		/// <value>
		/// Default: <c>false</c>
		/// </value>
		public bool UseVarOverLet { get; set; } = false;

		/// <summary>
		/// List of custom names to convert.
		/// Example: new("Console","console").
		/// Will convert "Console" to "console".
		/// </summary>
		/// <value>
		/// Default: <c>new()</c>
		/// </value>
		public List<Tuple<string, string>> CustomCSNamesToJS { get; set; } = new();
		/// <summary>
		/// List of types to convert.
		/// Example: Similar to CustomCSNamesToJS, but convers the type. You need to use <c>ToAttribute</c>
		/// </summary>
		/// <value>
		/// Default: <c>new()</c>
		/// </value>
		public List<Type> CustomCSTypesToJS { get; set; } = new();

		/// <summary>
		/// Add a <c>StringBuilder</c> to the front of a javascript file.
		/// </summary>
		/// <value>
		/// Default: <c>new()</c>
		/// </value>
		public StringBuilder AddSBInFront { get; set; } = new();
		/// <summary>
		/// Add a <c>StringBuilder</c> to the end of a javascript file.
		/// </summary>
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
