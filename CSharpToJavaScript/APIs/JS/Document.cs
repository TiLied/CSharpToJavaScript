using CSharpToJavaScript.Utils;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToJavaScript.APIs.JS
{
	public partial class Document
	{
		[To(ToAttribute.FirstCharToLowerCase)]
		public Element CreateElement(string localName, string options = "") 
		{
			throw new System.NotImplementedException();
		}
		[To(ToAttribute.FirstCharToLowerCase)]
		public Text CreateTextNode(string data) 
		{
			throw new System.NotImplementedException();
		}
	}
}
