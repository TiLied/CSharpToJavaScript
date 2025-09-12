# CSharpToJavaScript
[Nuget package](https://www.nuget.org/packages/CSharpToJavaScript/)  | [Website](https://tilied.github.io/CSTOJS_Pages/) | [Try it online!](https://tilied.github.io/CSTOJS_Pages/BWA/) | [CLI](https://github.com/TiLied/CSTOJS_CLI) | [VS Code Extension](https://marketplace.visualstudio.com/items?itemName=tilied.cstojs-vscode-ext) | [VS Extension](https://marketplace.visualstudio.com/items?itemName=tilied.cstojs-vs-ext)

C# conversion to JavaScript as is.

*This is a personal project. Updates will be irregular.*

### C# input
```csharp
namespace ConsoleAppTest.CSharp;

public class Test							
{
	public Test()
	{
		Console.WriteLine("Hello World!");
	}
}
```
### Javascript output
```javascript
class Test
{
	constructor()
	{
		console.log("Hello World!");
	}
}
```



## How to use
- 1 Create c# project or use existed one.
- 2 Install [nuget package](https://www.nuget.org/packages/CSharpToJavaScript/) or Download a [specific version](https://github.com/TiLied/CSharpToJavaScript/releases) or Download a master(Code-Local-Download ZIP).
- 3 Skip this if using Nuget package. Follow [how to add a project reference](https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-7-0#add-a-project-reference).
- 4 In the Main method add:
```csharp
CSTOJS cstojs = new();
await cstojs.GenerateOneAsync("Path(full path) to c# file(folder with c# files)");
```
*Other methods "GenerateOne" can be found [on the website](https://tilied.github.io/CSTOJS_Pages/api/CSharpToJavaScript.CSTOJS.html#methods).*
- 5 Run program and file will be generated in output path(default is "Directory.GetCurrentDirectory()") with name "|C# file name|.js"(default)
- 6 See below for an example "Model" and "HelloWorld".

## Example "Model"
Program.cs
```csharp
using CSharpToJavaScript;
namespace ConsoleAppTest;

public class Program
{
	public static async Task Main()
	{
		CSTOJS cstojs = new(new CSTOJSOptions() 
			{ 
				KeepBraceOnTheSameLine = true,
				NormalizeWhitespace = true
			});
		await cstojs.GenerateOneAsync("C:\\GitReps\\ConsoleAppTest\\CSharp\\Person.cs");

		Console.ReadKey();
	}
}
```
*List of [options can be found on the website](https://tilied.github.io/CSTOJS_Pages/api/CSharpToJavaScript.CSTOJSOptions.html) or [in the code directly](https://github.com/TiLied/CSharpToJavaScript/blob/master/CSharpToJavaScript/CSTOJSOptions.cs).*

CSharp/Person.cs
```csharp
using static CSharpToJavaScript.APIs.JS.GlobalObject;
namespace ConsoleAppTest.CSharp;

public partial class Person
{
    private int _Id;
    public string FullName { get; set; }
    public int Age { get; set; }
}
```
Above code will generate "Person.js" file that contains:
```javascript
class Person {
    _Id;
    #_FullName_;
    get FullName() { return this.#_FullName_; } 
    set FullName(value) { this.#_FullName_ = value; }
    #_Age_;
    get Age() { return this.#_Age_; } 
    set Age(value) { this.#_Age_ = value; }
}
```

## Example "HelloWorld"
Program.cs
```csharp
using CSharpToJavaScript;
namespace ConsoleAppTest;

public class Program
{
	public static async Task Main()
	{
		CSTOJS cstojs = new();
		await cstojs.GenerateOneAsync("C:\\GitReps\\ConsoleAppTest\\CSharp\\Test.cs");

		Console.ReadKey();
	}
}
```
CSharp/Test.cs
```csharp
using static CSharpToJavaScript.APIs.JS.GlobalObject;
namespace ConsoleAppTest.CSharp;

public class Test
{
	public Test()
	{
		GlobalThis.Console.Log("HelloWorld!");
	}
}
```
Above code will generate "Test.js" file that contains:
```javascript
class Test
{
	constructor()
 	{
   		globalThis.console.log("HelloWorld!");
 	}
}
```

## Related Repository 
- Library for generating docs: https://github.com/TiLied/GenDocsLib
- Library for generating csharp: https://github.com/TiLied/GenCSharpLib

CLI for library: https://github.com/TiLied/CSTOJS_CLI

VS Code Extension using CLI: https://github.com/TiLied/CSTOJS_VSCode_Ext

VS Extension using CLI: https://github.com/TiLied/CSTOJS_VS_Ext

Website/documentation: https://github.com/TiLied/CSTOJS_Pages
- Blazor WebAssembly: https://github.com/TiLied/CSTOJS_BWA

## Project includes
[Microsoft CodeAnalysis CSharp](https://www.nuget.org/packages/Microsoft.CodeAnalysis.CSharp/) Core nuget package.

[MDN-content](https://github.com/mdn/content) for JS api.


<VersionPrefix>0.0.09</VersionPrefix>
