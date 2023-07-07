# Example "Hello World!"

Create new c# project.
> [!NOTE]
> Make sure to use full path in "Generate2Async" method! 

Program.cs
```csharp
using System.Reflection;
using CSharpToJavaScript;
namespace TestNuget;

public class Program
{
	public static async Task Main()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		
		CSTOJS cstojs = new(executingAssembly);
		await cstojs.Generate2Async("C:\\GitReps\\TestNuget\\TestNuget\\CSharp\\Test.cs");
		
		Console.ReadKey();
	}
}
```

Add new folder "CSharp" and new file name "Test".

CSharp/Test.cs
```csharp
using static CSharpToJavaScript.APIs.JS.GlobalThis;
namespace TestNuget.CSharp;

public class Test
{
	public Test()
	{
		Console.Log("Hello World!");
	}
}
```

Run. Above code will generate main.js file that contains:

```javascript
class Test
{
	constructor()
 	{
   		console.log("Hello World!");
 	}
}
```