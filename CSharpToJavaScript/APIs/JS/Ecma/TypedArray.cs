//TODO! Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpToJavaScript.APIs.JS.Ecma;
//https://262.ecma-international.org/14.0/#sec-typedarray-objects
[To(ToAttribute.Default)]
public partial class TypedArray<T> : TypedArrayPrototype<T>
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static TypedArrayPrototype<T> Prototype { get; } = new();

	[To(ToAttribute.FirstCharToLowerCase)]
	public static T From(dynamic source, Action<dynamic>? mapfn = null, dynamic? thisArg = null) 
	{
		throw new System.NotImplementedException();
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public static T Of(params dynamic[] items)
	{
		throw new System.NotImplementedException();
	}
}
[To(ToAttribute.FirstCharToLowerCase)]
public partial class TypedArrayPrototype<T> : FunctionPrototype
{

	//returns ArrayBuffer
	//TODO!
	public dynamic? Buffer { get; set; } = null;
	public int ByteLength { get; set; } = 0;
	public int ByteOffset { get; set; } = 0;
	public int Length { get; set; } = 0;
	public TypedArrayPrototype() { }

	public dynamic? At(int index)
	{
		throw new System.NotImplementedException();
	}
	public T CopyWithin(int target, int start, int end = 0)
	{
		throw new System.NotImplementedException();
	}
	public List<dynamic> Entries()
	{
		throw new System.NotImplementedException();
	}
	public bool Every(Action callbackfn, dynamic? thisArg = null)
	{
		throw new System.NotImplementedException();
	}
	public T Fill(dynamic value, int start = 0, int end = 0)
	{
		throw new System.NotImplementedException();
	}
	public T Filter(Action callbackfn, dynamic? thisArg = null)
	{
		throw new System.NotImplementedException();
	}
	public dynamic? Find(Action predicate, dynamic? thisArg = null)
	{
		throw new System.NotImplementedException();
	}
	public int FindIndex(Action predicate, dynamic? thisArg = null)
	{
		throw new System.NotImplementedException();
	}
	public dynamic? FindLast(Action predicate, dynamic? thisArg = null)
	{
		throw new System.NotImplementedException();
	}
	public int FindLastIndex(Action predicate, dynamic? thisArg = null)
	{
		throw new System.NotImplementedException();
	}
	public GlobalObject.Undefined ForEach(Action callbackfn, dynamic? thisArg = null)
	{
		throw new System.NotImplementedException();
	}
	public bool Includes(dynamic searchElement, int fromIndex = 0)
	{
		throw new System.NotImplementedException();
	}
	public int IndexOf(dynamic searchElement, int fromIndex = 0)
	{
		throw new System.NotImplementedException();
	}
	public string Join(string separator = ",")
	{
		throw new System.NotImplementedException();
	}
	public List<dynamic> Keys()
	{
		throw new System.NotImplementedException();
	}
	public int LastIndexOf(dynamic searchElement, int fromIndex = 0)
	{
		throw new System.NotImplementedException();
	}
	public T Map(Action callbackfn, dynamic? thisArg = null)
	{
		throw new System.NotImplementedException();
	}
	public dynamic Reduce(Action callbackfn, dynamic? initialValue = null)
	{
		throw new System.NotImplementedException();
	}
	public dynamic ReduceRight(Action callbackfn, dynamic? initialValue = null)
	{
		throw new System.NotImplementedException();
	}
	public T Reverse()
	{
		throw new System.NotImplementedException();
	}
	//TODO? make generic?
	public GlobalObject.Undefined Set(dynamic source, int offset = 0)
	{
		throw new System.NotImplementedException();
	}
	public T Slice(int start = 0, int end = 0)
	{
		throw new System.NotImplementedException();
	}
	public bool Some(Action callbackfn, dynamic? thisArg = null)
	{
		throw new System.NotImplementedException();
	}
	public T Sort(Action comparefn)
	{
		throw new System.NotImplementedException();
	}
	public T SubArray(int begin = 0, int end = 0)
	{
		throw new System.NotImplementedException();
	}
	public new string ToLocaleString(dynamic? reserved1 = null, dynamic? reserved2 = null)
	{
		throw new System.NotImplementedException();
	}
	public T ToReversed()
	{
		throw new System.NotImplementedException();
	}
	public T ToSorted(Action comparefn)
	{
		throw new System.NotImplementedException();
	}
	public new string ToString()
	{
		throw new System.NotImplementedException();
	}
	public List<dynamic> Values()
	{
		throw new System.NotImplementedException();
	}
	public T With(int index, dynamic value)
	{
		throw new System.NotImplementedException();
	}
}

[To(ToAttribute.Default)]
public partial class Int8Array : TypedArray<Int8Array>
{
	public static int BYTES_PER_ELEMENT = 1;
	public Int8Array() { }
	public Int8Array(int length) { }
	
	//TODO!
	//public Int8Array(typedArray) { }
	public Int8Array(Object object_) { }

	//TODO ArrayBuffer!
	public Int8Array(dynamic buffer) { }
	public Int8Array(dynamic buffer, int byteOffset) { }
	public Int8Array(dynamic buffer, int byteOffset, int length) { }

}
[To(ToAttribute.Default)]
public partial class Uint8Array : TypedArray<Uint8Array>
{
	public static int BYTES_PER_ELEMENT = 1;
	public Uint8Array() { }
	public Uint8Array(int length) { }

	//TODO!
	//public Uint8Array(typedArray) { }
	public Uint8Array(Object object_) { }

	//TODO ArrayBuffer!
	public Uint8Array(dynamic buffer) { }
	public Uint8Array(dynamic buffer, int byteOffset) { }
	public Uint8Array(dynamic buffer, int byteOffset, int length) { }
}
[To(ToAttribute.Default)]
public partial class Uint8ClampedArray : TypedArray<Uint8ClampedArray>
{
	public static int BYTES_PER_ELEMENT = 1;
	public Uint8ClampedArray() { }
	public Uint8ClampedArray(int length) { }

	//TODO!
	//public Uint8ClampedArray(typedArray) { }
	public Uint8ClampedArray(Object object_) { }

	//TODO ArrayBuffer!
	public Uint8ClampedArray(dynamic buffer) { }
	public Uint8ClampedArray(dynamic buffer, int byteOffset) { }
	public Uint8ClampedArray(dynamic buffer, int byteOffset, int length) { }
}
[To(ToAttribute.Default)]
public partial class Int16Array : TypedArray<Int16Array>
{
	public static int BYTES_PER_ELEMENT = 2;
	public Int16Array() { }
	public Int16Array(int length) { }

	//TODO!
	//public Int16Array(typedArray) { }
	public Int16Array(Object object_) { }

	//TODO ArrayBuffer!
	public Int16Array(dynamic buffer) { }
	public Int16Array(dynamic buffer, int byteOffset) { }
	public Int16Array(dynamic buffer, int byteOffset, int length) { }
}
[To(ToAttribute.Default)]
public partial class Uint16Array : TypedArray<Uint16Array>
{
	public static int BYTES_PER_ELEMENT = 2;
	public Uint16Array() { }
	public Uint16Array(int length) { }

	//TODO!
	//public Uint16Array(typedArray) { }
	public Uint16Array(Object object_) { }

	//TODO ArrayBuffer!
	public Uint16Array(dynamic buffer) { }
	public Uint16Array(dynamic buffer, int byteOffset) { }
	public Uint16Array(dynamic buffer, int byteOffset, int length) { }
}
[To(ToAttribute.Default)]
public partial class Int32Array : TypedArray<Int32Array>
{
	public static int BYTES_PER_ELEMENT = 4;
	public Int32Array() { }
	public Int32Array(int length) { }

	//TODO!
	//public Int32Array(typedArray) { }
	public Int32Array(Object object_) { }

	//TODO ArrayBuffer!
	public Int32Array(dynamic buffer) { }
	public Int32Array(dynamic buffer, int byteOffset) { }
	public Int32Array(dynamic buffer, int byteOffset, int length) { }
}
[To(ToAttribute.Default)]
public partial class Uint32Array : TypedArray<Uint32Array>
{
	public static int BYTES_PER_ELEMENT = 4;
	public Uint32Array() { }
	public Uint32Array(int length) { }

	//TODO!
	//public Uint32Array(typedArray) { }
	public Uint32Array(Object object_) { }

	//TODO ArrayBuffer!
	public Uint32Array(dynamic buffer) { }
	public Uint32Array(dynamic buffer, int byteOffset) { }
	public Uint32Array(dynamic buffer, int byteOffset, int length) { }
}
[To(ToAttribute.Default)]
public partial class BigInt64Array : TypedArray<BigInt64Array>
{
	public static int BYTES_PER_ELEMENT = 8;
	public BigInt64Array() { }
	public BigInt64Array(int length) { }

	//TODO!
	//public BigInt64Array(typedArray) { }
	public BigInt64Array(Object object_) { }

	//TODO ArrayBuffer!
	public BigInt64Array(dynamic buffer) { }
	public BigInt64Array(dynamic buffer, int byteOffset) { }
	public BigInt64Array(dynamic buffer, int byteOffset, int length) { }
}
[To(ToAttribute.Default)]
public partial class BigUint64Array : TypedArray<BigUint64Array>
{
	public static int BYTES_PER_ELEMENT = 8;
	public BigUint64Array() { }
	public BigUint64Array(int length) { }

	//TODO!
	//public BigUint64Array(typedArray) { }
	public BigUint64Array(Object object_) { }

	//TODO ArrayBuffer!
	public BigUint64Array(dynamic buffer) { }
	public BigUint64Array(dynamic buffer, int byteOffset) { }
	public BigUint64Array(dynamic buffer, int byteOffset, int length) { }
}
[To(ToAttribute.Default)]
public partial class Float32Array : TypedArray<Float32Array>
{
	public static int BYTES_PER_ELEMENT = 4;
	public Float32Array() { }
	public Float32Array(int length) { }

	//TODO!
	//public Float32Array(typedArray) { }
	public Float32Array(Object object_) { }

	//TODO ArrayBuffer!
	public Float32Array(dynamic buffer) { }
	public Float32Array(dynamic buffer, int byteOffset) { }
	public Float32Array(dynamic buffer, int byteOffset, int length) { }
}
[To(ToAttribute.Default)]
public partial class Float64Array : TypedArray<Float64Array>
{
	public static int BYTES_PER_ELEMENT = 8;
	public Float64Array() { }
	public Float64Array(int length) { }

	//TODO!
	//public Float64Array(typedArray) { }
	public Float64Array(Object object_) { }

	//TODO ArrayBuffer!
	public Float64Array(dynamic buffer) { }
	public Float64Array(dynamic buffer, int byteOffset) { }
	public Float64Array(dynamic buffer, int byteOffset, int length) { }
}
