using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToJavaScript.APIs.JS
{
	public partial interface ParentNode
	{
		///<include file='Utils/Docs/ElementQuerySelector/ElementQuerySelector.generated.xml' path='docs/ElementQuerySelector/*'/>
		public T? QuerySelector<T>(string selectors) where T : Element { throw new System.NotImplementedException(); }
	}
}
