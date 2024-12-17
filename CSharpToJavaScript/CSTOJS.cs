using System.Reflection;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using CSharpToJavaScript.Utils;
using System;

namespace CSharpToJavaScript
{
    public class CSTOJS
	{
		public static SemanticModel Model { get; set; }

		private readonly Assembly _Assembly;

		private CSTOJSOptions _Options = new();

		private Walker _Walker = new();

		public CSTOJS(Assembly assembly) 
		{
			_Assembly = assembly;

			if (_Options.Debug)
			{
				if (File.Exists(Directory.GetCurrentDirectory() + "/debug.txt"))
					File.Delete(Directory.GetCurrentDirectory() + "/debug.txt");

				Trace.Listeners.Add(new TextWriterTraceListener("debug.txt"));
				Trace.AutoFlush = true;
			}

			Trace.Listeners.Add(new ConsoleTraceListener());
		}

		public CSTOJS(Assembly assembly, CSTOJSOptions options)
		{
			_Assembly = assembly;
			_Options = options;
			_Walker = new(_Options);

			if (_Options.Debug)
			{
				if (File.Exists(Directory.GetCurrentDirectory() + "/debug.txt"))
					File.Delete(Directory.GetCurrentDirectory() + "/debug.txt");

				Trace.Listeners.Add(new TextWriterTraceListener("debug.txt"));
				Trace.AutoFlush = true;
			}

			Trace.Listeners.Add(new ConsoleTraceListener());
		}

		public async Task Generate2Async(string path) 
		{
			string fileCS = await File.ReadAllTextAsync(path);

			SyntaxTree tree = CSharpSyntaxTree.ParseText(fileCS);
			CompilationUnitSyntax root = tree.GetCompilationUnitRoot();

			string assemblyPath = Path.GetDirectoryName(_Assembly.Location);
			List<MetadataReference> references = new() { };

			string rtPath = Path.GetDirectoryName(typeof(object).Assembly.Location);

			references.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Private.CoreLib.dll")));

			var a = _Assembly.GetReferencedAssemblies();
			foreach (var item in a)
			{
				if (File.Exists(Path.Combine(assemblyPath, item.Name + ".dll")))
					references.Add(MetadataReference.CreateFromFile(Path.Combine(assemblyPath, item.Name + ".dll")));
				else
				{
					if (File.Exists(Path.Combine(rtPath, item.Name + ".dll")))
						references.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, item.Name + ".dll")));
				}
			}

			CSharpCompilation compilation = CSharpCompilation
				.Create("HelloWorld")
				.AddReferences(references.ToArray())
				.AddSyntaxTrees(root.SyntaxTree);

			Model = compilation.GetSemanticModel(root.SyntaxTree);

			_Walker.JSSB.Append(_Options.AddSBInFront);

			_Walker.Visit(root);

			_Walker.JSSB.Append(_Options.AddSBInEnd);

			if (!Directory.Exists(_Options.OutPutPath))
			{
				Directory.CreateDirectory(_Options.OutPutPath);
			}

			await File.WriteAllTextAsync(Path.Combine(_Options.OutPutPath, _Options.OutPutFileName), _Walker.JSSB.ToString());
			SM.Log($"path: {_Options.OutPutPath} file: {_Options.OutPutFileName}");
		}
	}
}