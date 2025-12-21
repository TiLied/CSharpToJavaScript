using CSharpToJavaScript.APIs.JS.Ecma;
using CSharpToJavaScript.Utils;
using System;

namespace CSharpToJavaScript.APIs.JS;

public partial class EventTarget
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public GlobalObject.Undefined AddEventListener(string type, Action? callback, Union26 options) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public GlobalObject.Undefined AddEventListener(string type, Action<MouseEvent>? callback, Union26 options) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public GlobalObject.Undefined AddEventListener(string type, Action<Event>? callback, Union26 options) { throw new System.NotImplementedException(); }
	
	[To(ToAttribute.FirstCharToLowerCase)]
	public GlobalObject.Undefined RemoveEventListener(string type, Action? callback, Union27 options) { throw new System.NotImplementedException(); }

}

