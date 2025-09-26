# CSharpToJavaScript
[Nuget package](https://www.nuget.org/packages/CSharpToJavaScript/)  | [CLI](https://github.com/TiLied/CSTOJS_CLI) | [Website](https://tilied.github.io/CSTOJS_Pages/) | [Try it online!](https://tilied.github.io/CSTOJS_Pages/BWA/)

This library is a "core" where all the "magic" happens for translating/converting cs into js, using Roslyn. You should use the [CLI](https://github.com/TiLied/CSTOJS_CLI)/dotnet tool, it behaves more or less like dotnet cli, tsc cli, meson. Look for the implementation in [CLI](https://github.com/TiLied/CSTOJS_CLI), [BWA app](https://github.com/TiLied/CSTOJS_BWA) or simple "Hello world" below.

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
- Library for generating various stuff: https://github.com/TiLied/CSTOJS_GenLib
- Website/documentation: https://github.com/TiLied/CSTOJS_Pages
- Blazor WebAssembly app: https://github.com/TiLied/CSTOJS_BWA
