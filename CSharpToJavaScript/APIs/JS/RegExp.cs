using CSharpToJavaScript.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToJavaScript.APIs.JS
{
	[To(ToAttribute.Default)]
	public class RegExp
	{
		public RegExp(string strRegExp) { }
		[To(ToAttribute.FirstCharToLowerCase)]
		public string[] Exec(string str)
		{
			throw new System.NotImplementedException();
		}
	}
}
