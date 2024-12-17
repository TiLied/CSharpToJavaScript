using CSharpToJavaScript.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToJavaScript.APIs.JS
{
	[To(ToAttribute.Default)]
	public partial class GM
	{
		public GM() { }
		[To(ToAttribute.FirstCharToLowerCase)]
		public static void DeleteValue(string name)
		{

		}

		[To(ToAttribute.FirstCharToLowerCase)]
		public static Task<dynamic> GetValue(string name)
		{
			return new Task<dynamic>(() => { return 0; });
		}

		[To(ToAttribute.FirstCharToLowerCase)]
		public static void SetValue(string name, dynamic value)
		{

		}

		[To(ToAttribute.FirstCharToLowerCase)]
		public static Task<List<dynamic>> ListValues()
		{
			return new Task<List<dynamic>>(() => { return new List<dynamic>(); });
		}

		[To(ToAttribute.FirstCharToLowerCase)]
		public static void OpenInTab(string url, bool open_in_background = false)
		{

		}

		[To(ToAttribute.FirstCharToLowerCase)]
		public static class Info
		{
			[To(ToAttribute.FirstCharToLowerCase)]
			public static class Script
			{
				[To(ToAttribute.FirstCharToLowerCase)]
				public static string Version { get; set; } = string.Empty;
			}
		}
	}
}
