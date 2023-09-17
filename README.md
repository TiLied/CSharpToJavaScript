# CSharpToJavaScript
Brute forcing conversion(translation) from C# to Javascript.

This is a personal project with purpose to learn and understand better c# and js at the same time. Many stuff is not supported and some won't. Updates will be happening when I'm using this library.(irregular)

[Nuget package](https://www.nuget.org/packages/CSharpToJavaScript/)

### C#
```csharp
using static CSharpToJavaScript.APIs.JS.GlobalObject.GlobalThis;
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
- 1 Create c# project or use existed one.
- 2 Install [nuget package](https://www.nuget.org/packages/CSharpToJavaScript/) or Download a specific version(visit [releases](https://github.com/TiLied/CSharpToJavaScript/releases)) or Download a master(Code-Local-Download ZIP).
- 3 Skip this if using Nuget package. Follow [this](https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-7-0#add-a-project-reference) to add reference to the project.
- 4 In the Main method add:
```csharp
CSTOJS cstojs = new();
await cstojs.GenerateOneAsync("FULL PATH TO CSHARP FILE YOU WHAT TO CONVERT");
```
- 5 Run program and file will be generated in output path(default is "Directory.GetCurrentDirectory()") with name "|FILE NAME|.js"(default)
- 6 See below for simple example "HelloWorld"

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
using static CSharpToJavaScript.APIs.JS.GlobalObject.GlobalThis;
namespace ConsoleAppTest.CSharp;

public class Test
{
	public Test()
	{
		Console.Log("HelloWorld");
	}
}
```
Above code will generate "Test.js" file that contains:
```javascript
class Test
{
	constructor()
 	{
   		console.log("HelloWorld");
 	}
}
```
More examples [here](https://tilied.github.io/CSharpToJavaScript/articles/intro.html). WIP!

## Some Todos
- [x] ~More comments in code, especially in [CSTOJSOptions](https://github.com/TiLied/CSharpToJavaScript/blob/master/CSharpToJavaScript/CSTOJSOptions.cs)~
- [ ] Wiki?????
- [x] ~Better and more examples~ [Here](https://tilied.github.io/CSharpToJavaScript/articles/intro.html). WIP!
- [x] ~Figure out how to do docs for [api](https://github.com/TiLied/CSharpToJavaScript/tree/master/CSharpToJavaScript/APIs/JS)~ [Docs](https://tilied.github.io/CSharpToJavaScript/) WIP!
- [ ] [CLI](https://learn.microsoft.com/en-us/dotnet/standard/commandline/)?
- [ ] [Visual Studio extension](https://learn.microsoft.com/en-us/visualstudio/extensibility/starting-to-develop-visual-studio-extensions?view=vs-2022)?
- [ ] [Visual Studio Code extension](https://code.visualstudio.com/api)??? Can I?

## Related Repository 
https://github.com/TiLied/GenDocsLib

https://github.com/TiLied/GenCSharpLib

## Thanks and usings
[Microsoft CodeAnalysis CSharp](https://www.nuget.org/packages/Microsoft.CodeAnalysis.CSharp/) nuget package

[MDN-content](https://github.com/mdn/content) for js docs


