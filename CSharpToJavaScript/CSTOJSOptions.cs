using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpToJavaScript
{
	public class CSTOJSOptions
	{
		public bool Debug { get; set; } = false;


		/// <summary>
		/// Output path for javascript file.
		/// Default: Directory.GetCurrentDirectory()
		/// </summary>
		public string OutPutPath { get; set; } = Directory.GetCurrentDirectory();
		public string OutPutFileName { get; set; } = "main.js";

		public bool UseVarOverLet { get; set; } = false;

		public List<Tuple<string, string>> CustomCSNamesToJS { get; set; } = new();
		public List<Type> CustomCSTypesToJS { get; set; } = new();

		public StringBuilder AddSBInFront { get; set; } = new();
		public StringBuilder AddSBInEnd { get; set; } = new();

		public CSTOJSOptions() 
		{

		}
	}
}
