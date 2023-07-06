# CSharpToJavaScript
Brute forcing conversion(translation) from C# to Javascript.

This is a personal project with purpose to learn and understand better c# and js at the same time. Many stuff is not supported and some won't. Updates will be happening when I'm using this library.(irregular)

~[Nuget package](https://www.nuget.org/packages/CSharpToJavaScript/)~

### C#
```csharp      
using static CSharpToJavaScript.APIs.JS.GlobalThis;
namespace ConsoleAppTest.CSharp;

public class Test							
{
	public Test()
	{
		Console.Log("HelloWorld!");
	}
}
```
### Javascript
```javascript
class Test
{
	constructor()
	{
		console.log("HelloWorld!");
	}
}
```

## How to use
- 1 Create c# project or use existed one
- 2 ~Install [nuget](https://www.nuget.org/packages/CSharpToJavaScript/)~ *The Nuget package is not working. I don't know why... Not even debug.txt generated)* or Download a specific version, visit [releases](https://github.com/TiLied/CSharpToJavaScript/releases) or Download a master(Code-Local-Download ZIP)
- 3 ~Skip this if using Nuget package.~ Follow [this](https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-7-0#add-a-project-reference) to add reference to project.
- 4 In the Main method add:
```csharp
Assembly assembly = Assembly.GetExecutingAssembly();
CSTOJS cstojs = new(assembly);
cstojs.Generate2Async("FULL PATH TO CSHARP FILE YOU WHAT TO CONVERT");
```
- 5 Run program and file will be generated in output path(default is "Directory.GetCurrentDirectory()") with name "main.js"(default)
- 6 See below for simple example "HelloWorld"

## Example "HelloWorld"
Program.cs
```csharp
using System.Reflection;
using CSharpToJavaScript;
namespace ConsoleAppTest;

public class Program
{
	public static void Main()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		
		CSTOJSOptions opt = new()
		{
			CustomCSNamesToJS = new List<Tuple<string, string>>()
			{
				new Tuple<string, string>("Console","console"),
				new Tuple<string, string>("WriteLine", "log")					
			},
			OutPutFileName = "test.js"
		};

		CSTOJS cstojs = new(executingAssembly, opt);
		cstojs.Generate2Async("C:\\GitReps\\ConsoleAppTest\\CSharp\\test.cs");
	}
}
```
CSharp/test.cs
```csharp
namespace ConsoleAppTest.CSharp;

public class Test
{
	public Test()
	{
		Console.WriteLine("HelloWorld");
	}
}
```
Above code will generate test.js file that contains:
```javascript
class Test
{
	constructor()
 	{
   		console.log("HelloWorld");
 	}
}
```
## Some Todos
- [ ] More comments in code, especially in [CSTOJSOptions](https://github.com/TiLied/CSharpToJavaScript/blob/master/CSharpToJavaScript/CSTOJSOptions.cs)
- [ ] Wiki?
- [ ] Better and more examples
- [x] ~Figure out how to do docs for [api](https://github.com/TiLied/CSharpToJavaScript/tree/master/CSharpToJavaScript/APIs/JS)~ [Docs](https://tilied.github.io/CSharpToJavaScript/) WIP!

## Related Repository 
https://github.com/TiLied/GenDocsLib

https://github.com/TiLied/GenCSharpLib

## Thanks and usings
[Microsoft CodeAnalysis CSharp](https://www.nuget.org/packages/Microsoft.CodeAnalysis.CSharp/) nuget package

[MDN-content](https://github.com/mdn/content) for js docs


