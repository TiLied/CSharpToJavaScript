namespace CSharpToJavaScript;

//Currently needs to be in Utils!!
//See GenDocsLib/GenDocs.cs/GenerateDocs
//TODO!!!

//TODO!
//I don't like it.
//I need something where I can replace the whole expression and not only the identifier...

internal class NETAPI
{
	private readonly TypeName[] _TypeNames = new TypeName[15];

	public NETAPI()
	{
		//
		//
		//
		_TypeNames[0] = new();
		_TypeNames[0].Name = nameof(System.Text.Json.JsonSerializer);
		_TypeNames[0].JSName = "JSON";

		_TypeNames[0].SymbolNames.Add(nameof(System.Text.Json.JsonSerializer.Deserialize), "parse");
		_TypeNames[0].SymbolNames.Add(nameof(System.Text.Json.JsonSerializer.Serialize), "stringify");

		//
		//
		//
		_TypeNames[1] = new();
		_TypeNames[1].Name = nameof(System.Console);
		_TypeNames[1].JSName = "console";

		_TypeNames[1].SymbolNames.Add(nameof(System.Console.WriteLine), "log");
		_TypeNames[1].SymbolNames.Add(nameof(System.Console.Write), "log");

		//
		//
		//
		_TypeNames[2] = new();
		_TypeNames[2].Name = nameof(System.Collections.Generic.List<object>);
		_TypeNames[2].JSName = "Array";

		_TypeNames[2].SymbolNames.Add(".ctor", "Array");
		_TypeNames[2].SymbolNames.Add(nameof(System.Collections.Generic.List<object>.Sort), "sort");
		_TypeNames[2].SymbolNames.Add(nameof(System.Collections.Generic.List<object>.FindLast), "findLast");
		_TypeNames[2].SymbolNames.Add(nameof(System.Collections.Generic.List<object>.Count), "length");
		_TypeNames[2].SymbolNames.Add(nameof(System.Collections.Generic.List<object>.Add), "push");
		_TypeNames[2].SymbolNames.Add(nameof(System.Collections.Generic.List<object>.Contains), "includes");

		//
		//
		//
		_TypeNames[3] = new();
		_TypeNames[3].Name = nameof(System.Collections.Generic.Dictionary<object, object>);
		_TypeNames[3].JSName = "Map";

		_TypeNames[3].SymbolNames.Add(nameof(System.Collections.Generic.Dictionary<object, object>.Keys), "keys()");
		_TypeNames[3].SymbolNames.Add(nameof(System.Collections.Generic.Dictionary<object, object>.Values), "values()");
		_TypeNames[3].SymbolNames.Add(nameof(System.Collections.Generic.Dictionary<object, object>.ContainsKey), "has");

		//
		//
		//
		_TypeNames[4] = new();
		_TypeNames[4].Name = nameof(System.String);
		_TypeNames[4].JSName = "String";

		_TypeNames[4].SymbolNames.Add(nameof(string.Contains), "includes");
		_TypeNames[4].SymbolNames.Add(nameof(string.Length), "length");
		_TypeNames[4].SymbolNames.Add(nameof(string.Trim), "trim");
		_TypeNames[4].SymbolNames.Add(nameof(string.TrimEnd), "trimEnd");
		_TypeNames[4].SymbolNames.Add(nameof(string.TrimStart), "trimStart");
		_TypeNames[4].SymbolNames.Add(nameof(string.Substring), "substring");
		_TypeNames[4].SymbolNames.Add(nameof(string.StartsWith), "startsWith");
		_TypeNames[4].SymbolNames.Add(nameof(string.Replace), "replace");
		_TypeNames[4].SymbolNames.Add(nameof(string.ToUpper), "toUpperCase");
		_TypeNames[4].SymbolNames.Add(nameof(string.ToLower), "toLowerCase");
		_TypeNames[4].SymbolNames.Add(nameof(string.EndsWith), "endsWith");
		_TypeNames[4].SymbolNames.Add(nameof(string.Empty), "raw``");
		
		//
		//
		//
		_TypeNames[5] = new();
		_TypeNames[5].Name = nameof(System.Threading.Tasks.Task<dynamic>);
		_TypeNames[5].JSName = "Promise";

		_TypeNames[5].SymbolNames.Add(nameof(System.Threading.Tasks.Task.ContinueWith), "then");

		//
		//
		//
		_TypeNames[6] = new();
		_TypeNames[6].Name = nameof(System.Array);
		_TypeNames[6].JSName = "Array";

		_TypeNames[6].SymbolNames.Add(nameof(System.Array.Length), "length");

		//
		//
		//
		_TypeNames[7] = new();
		_TypeNames[7].Name = nameof(System.Math);
		_TypeNames[7].JSName = "Math";

		_TypeNames[7].SymbolNames.Add(nameof(System.Math.Sqrt), "sqrt");
		_TypeNames[7].SymbolNames.Add(nameof(System.Math.Floor), "floor");
		_TypeNames[7].SymbolNames.Add(nameof(System.Math.Exp), "exp");
		_TypeNames[7].SymbolNames.Add(nameof(System.Math.Abs), "abs");
		_TypeNames[7].SymbolNames.Add(nameof(System.Math.Max), "max");
		
		//
		//
		//
		_TypeNames[8] = new();
		_TypeNames[8].Name = nameof(System.Object);
		_TypeNames[8].JSName = "Object";
		
		//
		//
		//
		_TypeNames[9] = new();
		_TypeNames[9].Name = nameof(System.SByte);
		_TypeNames[9].JSName = "Number";
		
		_TypeNames[9].SymbolNames.Add(nameof(System.SByte.MinValue), "parseInt(\"-128\")");
		_TypeNames[9].SymbolNames.Add(nameof(System.SByte.MaxValue), "parseInt(\"127\")");
		
		//
		//
		//
		_TypeNames[10] = new();
		_TypeNames[10].Name = nameof(System.Byte);
		_TypeNames[10].JSName = "Number";
		
		_TypeNames[10].SymbolNames.Add(nameof(System.Byte.MinValue), "parseInt(\"0\")");
		_TypeNames[10].SymbolNames.Add(nameof(System.Byte.MaxValue), "parseInt(\"255\")");
		
		//
		//
		//
		_TypeNames[11] = new();
		_TypeNames[11].Name = nameof(System.Int16);
		_TypeNames[11].JSName = "Number";
		
		_TypeNames[11].SymbolNames.Add(nameof(System.Int16.MinValue), "parseInt(\"-32768\")");
		_TypeNames[11].SymbolNames.Add(nameof(System.Int16.MaxValue), "parseInt(\"32767\")");
		
		//
		//
		//
		_TypeNames[12] = new();
		_TypeNames[12].Name = nameof(System.UInt16);
		_TypeNames[12].JSName = "Number";
		
		_TypeNames[12].SymbolNames.Add(nameof(System.UInt16.MinValue), "parseInt(\"0\")");
		_TypeNames[12].SymbolNames.Add(nameof(System.UInt16.MaxValue), "parseInt(\"65535\")");
		
		//
		//
		//
		_TypeNames[13] = new();
		_TypeNames[13].Name = nameof(System.Int32);
		_TypeNames[13].JSName = "Number";
		
		_TypeNames[13].SymbolNames.Add(nameof(System.Int32.MinValue), "parseInt(\"-2147483648\")");
		_TypeNames[13].SymbolNames.Add(nameof(System.Int32.MaxValue), "parseInt(\"2147483647\")");
		
		//
		//
		//
		_TypeNames[14] = new();
		_TypeNames[14].Name = nameof(System.UInt32);
		_TypeNames[14].JSName = "Number";
		
		_TypeNames[14].SymbolNames.Add(nameof(System.UInt32.MinValue), "parseInt(\"0\")");
		_TypeNames[14].SymbolNames.Add(nameof(System.UInt32.MaxValue), "parseInt(\"4294967295\")");
	}

	public string? ReturnJSString(string typeName, string? symbolName = null) 
	{
		TypeName? type = null;

		for (int i = 0; i < _TypeNames.Length; i++)
		{
			if (_TypeNames[i].Name == typeName)
			{
				type = _TypeNames[i];
				break;
			}
		}

		if (type != null)
		{
			if (symbolName == null)
			{
				return type.JSName;
			}
			else
			{
				if (type.SymbolNames.ContainsKey(symbolName))
					return type.SymbolNames[symbolName];
				else
					return null;
			}
		}

		return null;
	}
}

internal class TypeName 
{
	public string Name { get; set; } = string.Empty;
	public string JSName { get; set; } = string.Empty;

	public System.Collections.Generic.Dictionary<string, string> SymbolNames = new();

	public TypeName() { }
}
