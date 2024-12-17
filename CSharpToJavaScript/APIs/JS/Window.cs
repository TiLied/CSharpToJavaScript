using CSharpToJavaScript.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToJavaScript.APIs.JS
{
	public partial class Window
	{
		[To(ToAttribute.FirstCharToLowerCase)]
		public dynamic Eval(string jsStr) 
		{
			throw new System.NotImplementedException();
		}
	}
}
