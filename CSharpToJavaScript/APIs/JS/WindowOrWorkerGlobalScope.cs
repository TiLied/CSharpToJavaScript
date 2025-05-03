using CSharpToJavaScript.Utils;
using System;
using System.Threading.Tasks;

namespace CSharpToJavaScript.APIs.JS
{
	public partial interface WindowOrWorkerGlobalScope
	{
		[To(ToAttribute.FirstCharToLowerCase)]
		public long SetTimeout(Action handler, long timeout, params dynamic[] arguments) { throw new System.NotImplementedException(); }

		[To(ToAttribute.FirstCharToLowerCase)]
		public long SetInterval(Action handler, long timeout, params dynamic[] arguments) { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
		public Task<Response> Fetch(string input) { throw new System.NotImplementedException(); }

	}
}
