using CSharpToJavaScript.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToJavaScript.APIs.JS
{
	[To(ToAttribute.Default)]
	public partial class Math
	{
		[To(ToAttribute.FirstCharToLowerCase)]
		public static double Random() 
		{
			throw new System.NotImplementedException();
		}
		[To(ToAttribute.FirstCharToLowerCase)]
		public static int Floor(double num)
		{
			throw new System.NotImplementedException();
		}
	}
}
