# FAQ
Q. Why did you write this library?

A. The whole purpose is to learn and understand better c# and js at the same time.

Q. How to use methods that in Interfaces? Like [Append](xref:CSharpToJavaScript.APIs.JS.ParentNode.Append(CSharpToJavaScript.APIs.JS.Union4[])) etc.

A. Currently only supported is through [as operator](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator). Example:
```csharp
(GlobalThis.Window.Document.Head as ParentNode).Append(...);
```
Q. Is this library used in any "real" projects?

A. You can check one of [my script(AnkiWeb Quiz)](https://github.com/TiLied/Ankiweb_Quiz), if its count as project.