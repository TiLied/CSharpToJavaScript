# FAQ
Q. How to use methods that in Interfaces? Like [Append](xref:CSharpToJavaScript.APIs.JS.ParentNode.Append(CSharpToJavaScript.APIs.JS.Union4[])) etc.

A. Currently only supported is through [as operator](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator). Example:
```csharp
(GlobalThis.Window.Document.Head as ParentNode).Append(...);
```
