//TODO! Disable missing XML comments.
#pragma warning disable CS1591

using CSharpToJavaScript.Utils;
using System;

namespace CSharpToJavaScript.APIs.JS.Ecma;

[To(ToAttribute.Default)]
public partial class DataView : DataViewPrototype
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public static DataViewPrototype Prototype { get; } = new();
	public DataView(ArrayBuffer buffer, int byteOffset = 0, int byteLength = 0) { }
}
[To(ToAttribute.FirstCharToLowerCase)]
public class DataViewPrototype : FunctionPrototype 
{
	public ArrayBuffer Buffer { get; } = new(0);
	public int ByteLength { get; } = 0;
	public int ByteOffset { get; } = 0;

	public DataViewPrototype() { }

	public BigInt GetBigInt64(int byteOffset, bool littleEndian = true)
	{
		throw new System.NotImplementedException();
	}
	public BigInt GetUBigInt64(int byteOffset, bool littleEndian = true)
	{
		throw new System.NotImplementedException();
	}
	public float GetFloat32(int byteOffset, bool littleEndian = true)
	{
		throw new System.NotImplementedException();
	}
	public float GetFloat64(int byteOffset, bool littleEndian = true)
	{
		throw new System.NotImplementedException();
	}
	public int GetInt8(int byteOffset)
	{
		throw new System.NotImplementedException();
	}
	public int GetInt16(int byteOffset, bool littleEndian = true)
	{
		throw new System.NotImplementedException();
	}
	public int GetInt32(int byteOffset, bool littleEndian = true)
	{
		throw new System.NotImplementedException();
	}
	public int GetUint8(int byteOffset)
	{
		throw new System.NotImplementedException();
	}
	public int GetUint16(int byteOffset, bool littleEndian = true)
	{
		throw new System.NotImplementedException();
	}
	public int GetUint32(int byteOffset, bool littleEndian = true)
	{
		throw new System.NotImplementedException();
	}
	public GlobalObject.Undefined SetBigInt64(int byteOffset, dynamic value, bool littleEndian = true)
	{
		throw new System.NotImplementedException();
	}
	public GlobalObject.Undefined SetBigUint64(int byteOffset, dynamic value, bool littleEndian = true)
	{
		throw new System.NotImplementedException();
	}
	public GlobalObject.Undefined SetFloat32(int byteOffset, dynamic value, bool littleEndian = true)
	{
		throw new System.NotImplementedException();
	}
	public GlobalObject.Undefined SetFloat64(int byteOffset, dynamic value, bool littleEndian = true)
	{
		throw new System.NotImplementedException();
	}
	public GlobalObject.Undefined SetInt8(int byteOffset, dynamic value)
	{
		throw new System.NotImplementedException();
	}
	public GlobalObject.Undefined SetInt16(int byteOffset, dynamic value, bool littleEndian = true)
	{
		throw new System.NotImplementedException();
	}
	public GlobalObject.Undefined SetInt32(int byteOffset, dynamic value, bool littleEndian = true)
	{
		throw new System.NotImplementedException();
	}
	public GlobalObject.Undefined SetUint8(int byteOffset, dynamic value)
	{
		throw new System.NotImplementedException();
	}
	public GlobalObject.Undefined SetUint16(int byteOffset, dynamic value, bool littleEndian = true)
	{
		throw new System.NotImplementedException();
	}
	public GlobalObject.Undefined SetUint32(int byteOffset, dynamic value, bool littleEndian = true)
	{
		throw new System.NotImplementedException();
	}

}
