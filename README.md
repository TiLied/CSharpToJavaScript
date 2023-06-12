# CSharpToJavaScript
Brute forcing conversion(translation) from C# to Javascript.

This is a personal project with purpose to learn and understand better c# and js at the same time. Many stuff is not supported and some won't. Updates will be happening when I'm using this library.(irregular)

| C#     | Javascript |
| ---      | ---       |
| <pre>using static CSharpToJavaScript.APIs.JS.GlobalThis;<br>namespace ConsoleApp1twest.CSharp;<br><br>public class Test<br>{<br> public Test()<br> {<br>   Console.Log("HelloWorld!");<br> }<br>}</pre> | <pre>class Test<br>{<br> constructor()<br> {<br>   console.log("HelloWorld!");<br> }<br>}</pre>|

## How to use
*Nuget package will be available once I figure out how to do docs for api(should be easy) and what to do with esmascript and how to convert to c#.*

- Download a library(Code-Local-Download ZIP)
- Create c# project or use existed one
- Follow [this](https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-7-0#add-a-project-reference) to add reference to project
- In the Main method add:
```csharp
Assembly assembly = Assembly.GetExecutingAssembly();
CSTOJS cstojs = new(assembly);
cstojs.Generate2Async("FULL PATH TO CSHARP FILE YOU WHAT TO CONVERT");
```
- Run program and file will be generated in output path(default is "Directory.GetCurrentDirectory()") with name "main.js"(default)
- See below for simple example "HelloWorld"

## Example "HelloWorld"
Program.cs
```csharp
using System.Reflection;
using CSharpToJavaScript;
namespace ProgramTest;

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
		cstojs.Generate2Async("C:\\GitReps\\Program\\Program\\CSharp\\test.cs");
	}
}
```
test.cs
```csharp
namespace ProgramTest;

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
- [ ] Figure out how to do docs for [api](https://github.com/TiLied/CSharpToJavaScript/tree/master/CSharpToJavaScript/APIs/JS) 

## Related Repository 
https://github.com/TiLied/GenDocsLib

https://github.com/TiLied/GenCSharpLib

## Thanks and usings
[Microsoft CodeAnalysis CSharp](https://www.nuget.org/packages/Microsoft.CodeAnalysis.CSharp/) nuget package

[MDN-content](https://github.com/mdn/content) for js docs


