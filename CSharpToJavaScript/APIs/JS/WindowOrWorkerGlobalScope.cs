using System;
using System.Threading.Tasks;

namespace CSharpToJavaScript.APIs.JS
{
	public partial interface WindowOrWorkerGlobalScope
	{
		public long SetTimeout(Action handler, long timeout, params dynamic[] arguments) { throw new System.NotImplementedException(); }
		
		public long SetInterval(Action handler, long timeout, params dynamic[] arguments) { throw new System.NotImplementedException(); }

		public Task<Response> Fetch(string input) { throw new System.NotImplementedException(); }

	}
}
