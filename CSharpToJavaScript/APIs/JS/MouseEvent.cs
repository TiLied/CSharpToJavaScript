using CSharpToJavaScript.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToJavaScript.APIs.JS
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public partial class MouseEvent : Event
	{
		[To(ToAttribute.FirstCharToLowerCase)]
		public int Button { get; }
	}
}
