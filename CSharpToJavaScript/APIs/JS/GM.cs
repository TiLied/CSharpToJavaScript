using CSharpToJavaScript.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpToJavaScript.APIs.JS
{
	/// <summary>
	/// <see href="https://wiki.greasespot.net/Greasemonkey_Manual:API">Greasemonkey API</see>
	/// </summary>
	[To(ToAttribute.Default)]
	public partial class GM
	{
		/// <summary>
		/// 
		/// </summary>
		public GM() { }

		/// <summary>
		/// This method deletes an existing name / value pair from storage.
		/// See GM.setValue for details regarding the storage of these values.
		/// </summary>
		/// <remarks>
		/// <para><seealso href="https://wiki.greasespot.net/GM.deleteValue"> <em> See also on Greasemonkey Wiki</em> </seealso></para>
		/// </remarks>
		/// <param name="name">Property name to delete. See GM.setValue for details on what names are valid.</param>
		[To(ToAttribute.FirstCharToLowerCase)]
		public static void DeleteValue(string name)
		{

		}
		/// <summary>
		/// This method retrieves a value that was set with GM.setValue. See GM.setValue for details on the storage of these values. 
		/// </summary>
		/// <remarks>
		/// <para><seealso href="https://wiki.greasespot.net/GM.getValue"> <em> See also on Greasemonkey Wiki</em> </seealso></para>
		/// </remarks>
		/// <param name="name">String The property name to get. See GM.setValue for details.</param>
		/// <returns></returns>
		[To(ToAttribute.FirstCharToLowerCase)]
		public static Task<dynamic> GetValue(string name)
		{
			return new Task<dynamic>(() => { return 0; });
		}
		/// <summary>
		/// This method allows user script authors to persist simple values across page loads and across origins.
		///	Strings, booleans, and integers are currently the only allowed data types.
		/// </summary>
		/// <remarks>
		/// <para><seealso href="https://wiki.greasespot.net/GM.setValue"> <em> See also on Greasemonkey Wiki</em> </seealso></para>
		/// </remarks>
		/// <param name="name">String The unique (within this script) name for this value. Should be restricted to valid Javascript identifier characters.</param>
		/// <param name="value">String, Integer or Boolean Any valid value of these types. Any other type may cause undefined behavior, including crashes.</param>
		[To(ToAttribute.FirstCharToLowerCase)]
		public static void SetValue(string name, dynamic value)
		{

		}
		/// <summary>
		/// This method retrieves an array of preference names that this script has stored. See GM.setValue for details on the storage of these values. 
		/// </summary>
		/// <remarks>
		/// <para><seealso href="https://wiki.greasespot.net/GM.listValues"> <em> See also on Greasemonkey Wiki</em> </seealso></para>
		/// </remarks>
		/// <returns></returns>
		[To(ToAttribute.FirstCharToLowerCase)]
		public static Task<List<dynamic>> ListValues()
		{
			return new Task<List<dynamic>>(() => { return new List<dynamic>(); });
		}
		/// <summary>
		/// Given a defined @resource, this method returns it as a URL.
		///	Compatibility: Greasemonkey 4.0+ 
		/// </summary>
		/// <remarks>
		/// <para><seealso href="https://wiki.greasespot.net/GM.getResourceUrl"> <em> See also on Greasemonkey Wiki</em> </seealso></para>
		/// </remarks>
		/// <param name="resourceName">String The name provided when the @resource was defined, follow that link for valid naming restrictions.</param>
		/// <returns>A Promise, rejected on failure and resolved with a String URL on success. Treat the result as opaque string. It will work where you need a URL (for a link or style for CSS, for and img tag, or similar). </returns>
		[To(ToAttribute.FirstCharToLowerCase)]
		public static Task<string> GetResourceUrl(string resourceName)
		{
			return new Task<string>(() => { return "string url"; });
		}
		/// <summary>
		/// This method displays a notification to the user, using the underlying browser and operating system's notification mechanism. 
		/// </summary>
		/// <remarks>
		/// <para><seealso href="https://wiki.greasespot.net/GM.notification"> <em> See also on Greasemonkey Wiki</em> </seealso></para>
		/// </remarks>
		/// <param name="text">String The main notification text.</param>
		/// <param name="title">String Optional. The title of the notification. If not provided, the title will be "Greasemonkey".</param>
		/// <param name="image">String Optional. The URL for an image to display in the dialog. If not provided, the Greasemonkey logo will be used.</param>
		/// <param name="onclick">Function Optional. Callback, triggered when the notification window is clicked.</param>
		[To(ToAttribute.FirstCharToLowerCase)]
		public static void Notification(string text, string title = "", string image = "", Action? onclick = null)
		{

		}
		/// <summary>
		/// This method opens the specified URL in a new tab. 
		/// </summary>
		/// <remarks>
		/// <para><seealso href="https://wiki.greasespot.net/GM.openInTab"> <em> See also on Greasemonkey Wiki</em> </seealso></para>
		/// </remarks>
		/// <param name="url">String The URL to navigate the new tab to.</param>
		/// <param name="open_in_background">Boolean Optional: force tab to/to not open in a background tab. Default (unspecified) behavior honors Firefox configuration.</param>
		[To(ToAttribute.FirstCharToLowerCase)]
		public static void OpenInTab(string url, bool open_in_background = false)
		{

		}
		/// <summary>
		/// This method allows user scripts to add an item to the User Script Commands menu.
		/// Compatibility: Greasemonkey 4.11+ 
		/// </summary>
		/// <remarks>
		/// <para><seealso href="https://wiki.greasespot.net/GM.registerMenuCommand"> <em> See also on Greasemonkey Wiki</em> </seealso></para>
		/// </remarks>
		/// <param name="caption">String The caption to display on the menu item.</param>
		/// <param name="commandFunc">Function The function to call when this menu item is selected by the user.</param>
		/// <param name="accessKey">    String A single character that can be used to select command when the menu is open. It should be a letter in the caption.</param>
		[To(ToAttribute.FirstCharToLowerCase)]
		public static void RegisterMenuCommand(string caption, Action commandFunc, string accessKey)
		{

		}
		/// <summary>
		/// Sets the current contents of the operating system's clipboard. 
		/// </summary>
		/// <remarks>
		/// <para><seealso href="https://wiki.greasespot.net/GM.setClipboard"> <em> See also on Greasemonkey Wiki</em> </seealso></para>
		/// </remarks>
		/// <param name="text">String Any text.</param>
		[To(ToAttribute.FirstCharToLowerCase)]
		public static void SetClipboard(string text)
		{

		}

		//TODO!
		/// <summary>
		/// This method performs a similar function to the standard XMLHttpRequest object, but allows these requests to cross the same origin policy boundaries. 
		/// </summary>
		/// <remarks>
		/// <para><seealso href="https://wiki.greasespot.net/GM.xmlHttpRequest"> <em> See also on Greasemonkey Wiki</em> </seealso></para>
		/// </remarks>
		/// <param name="details"></param>
		[To(ToAttribute.FirstCharToLowerCase)]
		public static void XmlHttpRequest(object details)
		{

		}
		/// <summary>
		/// An object that exposes various information about Greasemonkey and the running User Script.
		///	Compatibility: Greasemonkey 0.9.16+ 
		/// </summary>
		/// <remarks>
		/// <para><seealso href="https://wiki.greasespot.net/GM.info"> <em> See also on Greasemonkey Wiki</em> </seealso></para>
		/// </remarks>
		[To(ToAttribute.FirstCharToLowerCase)]
		public static class Info
		{
			/// <summary>
			/// An object containing data about the currently running script. See more detail below.
			/// </summary>
			[To(ToAttribute.FirstCharToLowerCase)]
			public static class Script
			{
				/// <summary>
				/// Possibly empty string.
				/// </summary>
				[To(ToAttribute.FirstCharToLowerCase)]
				public static string Description { get; set; } = string.Empty;
				/// <summary>
				/// Possibly empty array of strings.
				/// </summary>
				[To(ToAttribute.FirstCharToLowerCase)]
				public static string[] Excludes { get; set; } = Array.Empty<string>();
				/// <summary>
				/// Possibly empty array of strings.
				/// </summary>
				[To(ToAttribute.FirstCharToLowerCase)]
				public static string[] Includes { get; set; } = Array.Empty<string>();
				/// <summary>
				/// Possibly empty array of strings.
				/// </summary>
				[To(ToAttribute.FirstCharToLowerCase)]
				public static string[] Matches { get; set; } = Array.Empty<string>();
				/// <summary>
				/// String.
				/// </summary>
				[To(ToAttribute.FirstCharToLowerCase)]
				public static string Name { get; set; } = string.Empty;
				/// <summary>
				/// Possibly empty string.
				/// </summary>
				[Value("namespace")]
				public static string Namespace_ { get; set; } = string.Empty;
				//TODO!
				/// <summary>
				/// An object keyed by resource name. Each value is an object with keys name and mimetype and url with string values.
				/// </summary>
				[To(ToAttribute.FirstCharToLowerCase)]
				public static object? Resources { get; set; } = null;
				/// <summary>
				/// String.
				/// </summary>
				[Value("run-at")]
				public static string RunAt { get; set; } = string.Empty;
				/// <summary>
				/// Possibly empty string.
				/// </summary>
				[To(ToAttribute.FirstCharToLowerCase)]
				public static string Version { get; set; } = string.Empty;
			}

			/// <summary>
			/// A string, the entire literal Metadata Block (without the delimiters) for the currently running script.
			/// </summary>
			[To(ToAttribute.FirstCharToLowerCase)]
			public static string ScriptMetaStr { get; set; } = string.Empty;

			/// <summary>
			/// The name of the user script engine handling this script's execution. The string Greasemonkey.
			/// </summary>
			[To(ToAttribute.FirstCharToLowerCase)]
			public static string ScriptHandler { get; set; } = string.Empty;
			/// <summary>
			/// The version of Greasemonkey, a string e.g. 4.0.
			/// </summary>
			[To(ToAttribute.FirstCharToLowerCase)]
			public static string Version { get; set; } = string.Empty;
		}
	}
}
