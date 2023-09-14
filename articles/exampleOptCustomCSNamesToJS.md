# Example of option "CustomCSNamesToJS"

Create new c# project.
> [!NOTE]
> Make sure to use full path in "GenerateOneAsync" method! 

> [!NOTE]
> Note this is just example! The "Console.WriteLine" will be translated by default!

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
				CustomCSNamesToJS = new List<Tuple<string, string>>()
				{
					new Tuple<string, string>("Console","console"),
					new Tuple<string, string>("WriteLine", "log")
				}
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
namespace TestNuget.CSharp;

public class Test
{
	public Test()
	{
		Console.WriteLine("Hello World!");
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