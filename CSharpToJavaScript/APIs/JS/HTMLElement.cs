using CSharpToJavaScript.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToJavaScript.APIs.JS
{
	public partial class HTMLElement
	{
		[To(ToAttribute.FirstCharToLowerCase)]
		public CSSStyleDeclaration Style { get; }
	}

	public partial interface CSSStyleDeclaration
	{
		[To(ToAttribute.FirstCharToLowerCase)]
		public string Display { get; set; }
	}
}
