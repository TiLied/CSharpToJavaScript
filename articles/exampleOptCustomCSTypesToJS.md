# Example of option "CustomCSTypesToJS"

Create new c# project.
> [!NOTE]
> Make sure to use full path in "GenerateOneAsync" method! 

For example you want use "insertAdjacentHTML" but there is no such method in [Element](xref:CSharpToJavaScript.APIs.JS.Element), you need to create an extension method with [ToAttribute](xref:CSharpToJavaScript.Utils.ToAttribute).

Program.cs
```csharp
using CSharpToJavaScript;
using CSharpToJavaScript.APIs.JS;
using CSharpToJavaScript.Utils;
using System;
using System.Threading.Tasks;

namespace TestNuget;

public class Program
{
	public static async Task Main()
	{
		CSTOJSOptions opt = new()
			{
				CustomCSTypesToJS = new() { typeof(Extensions) }
			};
			
		CSTOJS cstojs = new(opt);
		
		await cstojs.GenerateOneAsync("C:\\GitReps\\TestNuget\\TestNuget\\CSharp\\Test.cs");
		
		Console.ReadKey();
	}
}

public static class Extensions
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static string InsertAdjacentHTML(this Element obj, string where, string data)
	{
		throw new System.NotImplementedException();
	}
}

```

Add new folder "CSharp" and new file name "Test".

CSharp/Test.cs
```csharp
using CSharpToJavaScript.APIs.JS;
using static CSharpToJavaScript.APIs.JS.GlobalObject;
using System;
namespace TestNuget.CSharp;

public class Test
{
	public Test()
	{
		GlobalThis.Window.Document.Head.InsertAdjacentHTML("beforeend", "html string");
	}
}
```

Run. Above code will generate main.js file that contains:

```javascript
class Test
{
	constructor()
 	{
		globalThis.window.document.head.insertAdjacentHTML("beforeend", "html string");
 	}
}
```