using CSharpToJavaScript.Utils;
using System;
using System.Threading.Tasks;

namespace CSharpToJavaScript.APIs.JS;

public partial interface WindowOrWorkerGlobalScope
{
	[Value("setTimeout")]
	public long SetTimeout(Action handler, long timeout, params dynamic[] arguments) { throw new System.NotImplementedException(); }

	[Value("setInterval")]
	public long SetInterval(Action handler, long timeout, params dynamic[] arguments) { throw new System.NotImplementedException(); }
	[Value("fetch")]
	public Task<Response> Fetch(string input) { throw new System.NotImplementedException(); }

}
