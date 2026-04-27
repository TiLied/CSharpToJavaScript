# CSharpToJavaScript
[Nuget package](https://www.nuget.org/packages/CSharpToJavaScript/)  | [CLI](https://github.com/TiLied/CSTOJS_CLI) | [Website](https://tilied.github.io/CSTOJS_Pages/) | [Try it online!](https://tilied.github.io/CSTOJS_Pages/BWA/)

This library is the "core" where all the "magic" happens for translating/converting C# into JS, using Roslyn.

It is recommended to use the [CLI](https://github.com/TiLied/CSTOJS_CLI)/dotnet tool unless you want to write the front-end by yourself. Look for the implementation in the [CLI](https://github.com/TiLied/CSTOJS_CLI), [BWA app](https://github.com/TiLied/CSTOJS_BWA) or the simple "Hello world" example below.

The [CLI](https://github.com/TiLied/CSTOJS_CLI)/dotnet tool is a simple cli front-end that behaves more or less like the dotnet cli, tsc cli, meson.

## Status
test262-parser([master](https://github.com/tc39/test262-parser-tests)): Only JS part (code is not public, yet. ES5 implemented) Total tests: 5363 | Passed: 2824 (52 %) | Failed: 2539

test262([es5 branch](https://github.com/tc39/test262/tree/es5-tests)): Total tests: 11725 | Passed: 1272 (10 %)** | Failed: 10453

**Note: Tests run with "UseVarOverLet" option, using [Jint](https://github.com/sebastienros/jint) as an engine.

## Hello world
- Install the [NuGet package](https://www.nuget.org/packages/CSharpToJavaScript/) or download a [specific version](https://github.com/TiLied/CSharpToJavaScript/releases).
- Skip this if using a Nuget package. Follow [the instructions on how to add a project reference](https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-7-0#add-a-project-reference).
- In the Main method, add:
```csharp
FileData file = new()
{
	SourceStr = @"Console.WriteLine(""Hello world."");"
};
file = CSTOJS.Translate(file);

Console.WriteLine(file.TranslatedStr);
```
- Run a program
- Console output should be:
```javascript
console.log("Hello world.");
```
- For options, look at the [code](https://github.com/TiLied/CSharpToJavaScript/blob/master/CSharpToJavaScript/CSTOJSOptions.cs) or on the [website](https://tilied.github.io/CSTOJS_Pages/api/CSharpToJavaScript.CSTOJSOptions.html).
- To specify options (per file):
```csharp
FileData file = new()
{
	OptionsForFile = new(){ Debug = true },
	...
};
...
```

## Related Repository 
- Dotnet tool/CLI for this library: https://github.com/TiLied/CSTOJS_CLI
- Tests: https://github.com/TiLied/CSTOJS_Tests
- Library for generating various things: https://github.com/TiLied/CSTOJS_GenLib
- Website/documentation: https://github.com/TiLied/CSTOJS_Pages
- Blazor WebAssembly app: https://github.com/TiLied/CSTOJS_BWA
