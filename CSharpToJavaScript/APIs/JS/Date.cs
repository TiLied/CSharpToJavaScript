using CSharpToJavaScript.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToJavaScript.APIs.JS
{
	[To(ToAttribute.Default)]
	public class Date
	{
		public Date() { }
		[To(ToAttribute.FirstCharToLowerCase)]
		public string ToISOString()
		{
			throw new System.NotImplementedException();
		}
		[To(ToAttribute.FirstCharToLowerCase)]
		public static string Now()
		{
			throw new System.NotImplementedException();
		}
	}
}
