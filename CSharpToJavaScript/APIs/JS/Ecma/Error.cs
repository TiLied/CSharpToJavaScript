using CSharpToJavaScript.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpToJavaScript.APIs.JS.Ecma;

//https://262.ecma-international.org/14.0/#sec-error-objects

[To(ToAttribute.Default)]
public class Error : ErrorPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static ErrorPrototype Prototype { get; } = new();

	[To(ToAttribute.Default)]
	public Error(string message, object? options = null) 
	{
		
	}
}

[To(ToAttribute.FirstCharToLowerCase)]
public class ErrorPrototype 
{
	public string Message { get; set; } = string.Empty;
	public string Name { get; set; } = "Error";
	public ErrorPrototype() { }
	public string ToString()
	{
		throw new NotImplementedException();
	}
}

[To(ToAttribute.Default)]
public class EvalError : Error 
{
	[To(ToAttribute.Default)]
	public EvalError(string message) : base(message) { }
}

[To(ToAttribute.Default)]
public class RangeError : Error
{
	[To(ToAttribute.Default)]
	public RangeError(string message) : base(message) { }
}

[To(ToAttribute.Default)]
public class ReferenceError : Error
{
	[To(ToAttribute.Default)]
	public ReferenceError(string message) : base(message) { }
}

[To(ToAttribute.Default)]
public class SyntaxError : Error
{
	[To(ToAttribute.Default)]
	public SyntaxError(string message) : base(message) { }
}

[To(ToAttribute.Default)]
public class TypeError : Error
{
	[To(ToAttribute.Default)]
	public TypeError(string message) : base(message) { }
}

[To(ToAttribute.Default)]
public class URIError : Error
{
	[To(ToAttribute.Default)]
	public URIError(string message) : base(message) { }
}

//TODO?
//https://262.ecma-international.org/14.0/#sec-nativeerror-object-structure

[To(ToAttribute.Default)]
public class AggregateError : AggregateErrorPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static AggregateErrorPrototype Prototype { get; } = new();

	[To(ToAttribute.Default)]
	public AggregateError(object[] errors, string message, object? options = null)
	{

	}
}
public class AggregateErrorPrototype
{
	public string Message { get; set; } = string.Empty;
	public string Name { get; set; } = "AggregateError";
	public AggregateErrorPrototype() { }
}
