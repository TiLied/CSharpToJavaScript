# CSharpToJavaScript
[Nuget package](https://www.nuget.org/packages/CSharpToJavaScript/)  | [CLI](https://github.com/TiLied/CSTOJS_CLI) | [Website](https://tilied.github.io/CSTOJS_Pages/) | [Try it online!](https://tilied.github.io/CSTOJS_Pages/BWA/)

This library is a "core" where all the "magic" happens for translating/converting cs into js, using Roslyn. You should use the [CLI](https://github.com/TiLied/CSTOJS_CLI)/dotnet tool, it behaves more or less like dotnet cli, tsc cli, meson. Look for the implementation in [CLI](https://github.com/TiLied/CSTOJS_CLI), [BWA app](https://github.com/TiLied/CSTOJS_BWA) or simple "Hello world" below.

## Status
test262-parser([master](https://github.com/tc39/test262-parser-tests)): Only JS part (code is not public, yet. ES3 implemented) Total tests: 5363 | Passed: 2786 (51 %) | Failed: 2577

test262([es5 branch](https://github.com/tc39/test262/tree/es5-tests)): Total tests: 11725 | Passed: 4997 (42 %)** | Failed: 6728

**Note: Tests run with "UseVarOverLet" and "DisableCompilationErrors" options, using [Jint](https://github.com/sebastienros/jint) as an engine. The goal is to generate valid C# code and get rid of "DisableCompilationErrors" option.

## Hello world
- Install [nuget package](https://www.nuget.org/packages/CSharpToJavaScript/) or download a [specific version](https://github.com/TiLied/CSharpToJavaScript/releases).
- Skip this if using a Nuget package. Follow [the instructions on how to add a project reference](https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-7-0#add-a-project-reference).
- In the Main method, add:
```csharp
FileData file = new()
{
	SourceStr = @"Console.WriteLine(""Hello world."");"
};
FileData[] files = CSTOJS.Translate([ file ]);

Console.WriteLine(files[0].TranslatedStr);
```
- Run a program
- Console output should be:
```javascript
console.log("Hello world.");
```
- For options look at the [code](https://github.com/TiLied/CSharpToJavaScript/blob/master/CSharpToJavaScript/CSTOJSOptions.cs) or on a [website](https://tilied.github.io/CSTOJS_Pages/api/CSharpToJavaScript.CSTOJSOptions.html).
- To specify options (options applying per file):
```csharp
FileData file = new()
{
	OptionsForFile = new(){ Debug = true },
	...
};
...
```

## Related Repository 
- Dotnet tool/CLI for a library: https://github.com/TiLied/CSTOJS_CLI
- Tests: https://github.com/TiLied/CSTOJS_Tests
- Library for generating various stuff: https://github.com/TiLied/CSTOJS_GenLib
- Website/documentation: https://github.com/TiLied/CSTOJS_Pages
- Blazor WebAssembly app: https://github.com/TiLied/CSTOJS_BWA
