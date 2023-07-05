using CSharpToJavaScript.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpToJavaScript.APIs.JS.Date;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpToJavaScript.APIs.JS
{
	//https://262.ecma-international.org/14.0/#sec-date-objects
	[To(ToAttribute.Default)]
	public partial class Date : DatePrototype
	{
		[To(ToAttribute.FirstCharToLowerCase)]
		public static DatePrototype Prototype { get; } = new();

		public Date() { }
		public Date(string value) { }
		public Date(params float[] values) { }

		[To(ToAttribute.FirstCharToLowerCase)]
		public static float Now()
		{
			throw new System.NotImplementedException();
		}

		[To(ToAttribute.FirstCharToLowerCase)]
		public static float Parse(string str)
		{
			throw new System.NotImplementedException();
		}

		[To(ToAttribute.Default)]
		public static float UTC(float year, float month = 0,float date = 1, float hours = 0, float minutes = 0, float seconds = 0, float ms = 0)
		{
			throw new System.NotImplementedException();
		}
	}

	[To(ToAttribute.FirstCharToLowerCase)]
	public class DatePrototype
	{
		public float GetDate()
		{
			throw new System.NotImplementedException();
		}

		public float GetDay()
		{
			throw new System.NotImplementedException();
		}

		public float GetFullYear()
		{
			throw new System.NotImplementedException();
		}

		public float GetHours()
		{
			throw new System.NotImplementedException();
		}

		public float GetMilliseconds()
		{
			throw new System.NotImplementedException();
		}

		public float GetMinutes()
		{
			throw new System.NotImplementedException();
		}

		public float GetMonth()
		{
			throw new System.NotImplementedException();
		}

		public float GetSeconds()
		{
			throw new System.NotImplementedException();
		}

		public float GetTime()
		{
			throw new System.NotImplementedException();
		}

		public float GetTimezoneOffset()
		{
			throw new System.NotImplementedException();
		}

		public float GetUTCDate()
		{
			throw new System.NotImplementedException();
		}

		public float GetUTCDay()
		{
			throw new System.NotImplementedException();
		}

		public float GetUTCFullYear()
		{
			throw new System.NotImplementedException();
		}

		public float GetUTCHours()
		{
			throw new System.NotImplementedException();
		}

		public float GetUTCMilliseconds()
		{
			throw new System.NotImplementedException();
		}

		public float GetUTCMinutes()
		{
			throw new System.NotImplementedException();
		}

		public float GetUTCMonth()
		{
			throw new System.NotImplementedException();
		}

		public float GetUTCSeconds()
		{
			throw new System.NotImplementedException();
		}

		public float SetDate(float date)
		{
			throw new System.NotImplementedException();
		}

		public float SetFullYear(float year, float? month = null, float? date = null)
		{
			throw new System.NotImplementedException();
		}

		public float SetHours(float hour, float? min = null, float? sec = null, float? ms = null)
		{
			throw new System.NotImplementedException();
		}

		public float SetMilliseconds(float ms)
		{
			throw new System.NotImplementedException();
		}

		public float SetMinutes(float min, float? sec = null, float? ms = null)
		{
			throw new System.NotImplementedException();
		}

		public float SetMonth(float month, float? date = null)
		{
			throw new System.NotImplementedException();
		}

		public float SetSeconds(float sec, float? ms = null)
		{
			throw new System.NotImplementedException();
		}

		public float SetTime(float time)
		{
			throw new System.NotImplementedException();
		}

		public float SetUTCDate(float date)
		{
			throw new System.NotImplementedException();
		}

		public float SetUTCFullYear(float year, float? month = null, float? date = null)
		{
			throw new System.NotImplementedException();
		}

		public float SetUTCHours(float hour, float? min = null, float? sec = null, float? ms = null)
		{
			throw new System.NotImplementedException();
		}

		public float SetUTCMilliseconds(float ms)
		{
			throw new System.NotImplementedException();
		}

		public float SetUTCMinutes(float min, float? sec = null, float? ms = null)
		{
			throw new System.NotImplementedException();
		}

		public float SetUTCMonth(float month, float? date = null)
		{
			throw new System.NotImplementedException();
		}

		public float SetUTCSeconds(float sec, float? ms = null)
		{
			throw new System.NotImplementedException();
		}

		public string ToDateString()
		{
			throw new System.NotImplementedException();
		}

		public string ToISOString()
		{
			throw new System.NotImplementedException();
		}

		public string ToJSON(dynamic key)
		{
			throw new System.NotImplementedException();
		}

		public string ToLocaleDateString(dynamic? reserved1 = null, dynamic? reserved2 = null)
		{
			throw new System.NotImplementedException();
		}

		public string ToLocaleString(dynamic? reserved1 = null, dynamic? reserved2 = null)
		{
			throw new System.NotImplementedException();
		}

		public string ToLocaleTimeString(dynamic? reserved1 = null, dynamic? reserved2 = null)
		{
			throw new System.NotImplementedException();
		}

		public string ToString()
		{
			throw new System.NotImplementedException();
		}

		public string ToTimeString()
		{
			throw new System.NotImplementedException();
		}

		public string ToUTCString()
		{
			throw new System.NotImplementedException();
		}

		public float ValueOf()
		{
			throw new System.NotImplementedException();
		}
	}
}
