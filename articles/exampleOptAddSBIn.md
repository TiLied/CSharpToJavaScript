# Example of options "AddSBInFront" and "AddSBInEnd"

Create new c# project.
> [!NOTE]
> Make sure to use full path in "GenerateOneAsync" method! 

This options will add a string at the top/bottom of file. Useful when you want to initiate a class.

Program.cs
```csharp
using CSharpToJavaScript;

namespace TestNuget;

public class Program
{
	public static async Task Main()
	{
		CSTOJSOptions opt = new()
			{
				AddSBInFront = new("//Comment at the top!"),
				AddSBInEnd = new("//Comment at the bottom!")
			};
		
		CSTOJS cstojs = new(opt);
		await cstojs.GenerateOneAsync("C:\\GitReps\\TestNuget\\TestNuget\\CSharp\\Test.cs");
		
		Console.ReadKey();
	}
}
```

Add new folder "CSharp" and new file name "Test".

CSharp/Test.cs
```csharp
using static CSharpToJavaScript.APIs.JS.GlobalObject.GlobalThis;
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
//Comment at the top!
class Test
{
	constructor()
 	{
   		console.log("Hello World!");
 	}
}
//Comment at the bottom!
```