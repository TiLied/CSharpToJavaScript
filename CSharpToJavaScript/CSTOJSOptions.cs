using System.Collections.Generic;
using System.Text;

namespace CSharpToJavaScript;

/// <summary>
/// Options for <see cref="CSTOJS" />.
/// </summary>
public class CSTOJSOptions
{
	/// <summary>
	/// Debug. When set to true prints additional info to console, cs lines to js file.
	/// </summary>
	/// <remarks>
	/// <blockquote class="NOTE"><h5>NOTE</h5>
	/// <para>
	/// cstojs_options.xml: &lt;Option Debug=&quot;false&quot; /&gt;
	/// </para>
	/// </blockquote>
	/// </remarks>
	/// <value>
	/// Default: <c>false</c>
	/// </value>
	public bool Debug { get; set; } = false;

	/// <summary>
	/// Getting diagnostics is expensive. 
	/// Enable if you want faster translation.
	/// </summary>
	/// <remarks>
	/// <blockquote class="NOTE"><h5>NOTE</h5>
	/// <para>
	/// cstojs_options.xml: &lt;Option DisableDiagnostics=&quot;false&quot; /&gt;
	/// </para>
	/// </blockquote>
	/// <para><see href = "https://learn.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.semanticmodel.getdiagnostics?view=roslyn-dotnet-4.13.0#remarks"><em>See remarks.</em></see></para>
	/// </remarks>
	/// <value>
	/// Default: <c>false</c>
	/// </value>
	public bool DisableDiagnostics { get; set; } = false;

	/// <summary>
	/// Self-explanatory, Use <c>var</c> over <c>let</c>.
	/// </summary>
	/// <remarks>
	/// <blockquote class="NOTE"><h5>NOTE</h5>
	/// <para>
	/// cstojs_options.xml: &lt;Option UseVarOverLet=&quot;false&quot; /&gt;
	/// </para>
	/// </blockquote>
	/// </remarks>
	/// <value>
	/// Default: <c>false</c>
	/// </value>
	public bool UseVarOverLet { get; set; } = false;

	/// <summary>
	/// Keep Brace <c>{</c> on the same line. 
	/// </summary>
	/// <remarks>
	/// <blockquote class="NOTE"><h5>NOTE</h5><para>Note: It is better write from the start in c#, then using this option.</para></blockquote>
	/// <blockquote class="NOTE"><h5>NOTE</h5>
	/// <para>
	/// cstojs_options.xml: &lt;Option KeepBraceOnTheSameLine=&quot;false&quot; /&gt;
	/// </para>
	/// </blockquote>
	/// </remarks>
	/// <value>
	/// Default: <c>false</c>
	/// </value>
	public bool KeepBraceOnTheSameLine { get; set; } = false;

	/// <summary>
	/// Self-explanatory, Normalize Whitespace.
	/// </summary>
	/// <remarks>
	/// <blockquote class="NOTE"><h5>NOTE</h5><para>Note: If using with <see cref="CSTOJSOptions.KeepBraceOnTheSameLine" />. Normalization running before <see cref="CSTOJSOptions.KeepBraceOnTheSameLine" />.</para></blockquote>
	/// <blockquote class="NOTE"><h5>NOTE</h5>
	/// <para>
	/// cstojs_options.xml: &lt;Option NormalizeWhitespace=&quot;false&quot; /&gt;
	/// </para>
	/// </blockquote>
	/// </remarks>
	/// <value>
	/// Default: <c>false</c>
	/// </value>
	public bool NormalizeWhitespace { get; set; } = false;

	/// <summary>
	/// Translate current <see cref="FileData" />. If false, walker will not be called.
	/// </summary>
	/// <remarks>
	/// <blockquote class="NOTE"><h5>NOTE</h5>
	/// <para>
	/// cstojs_options.xml: &lt;Option TranslateFile=&quot;true&quot; /&gt;
	/// </para>
	/// </blockquote>
	/// </remarks>
	/// <value>
	/// Default: <c>true</c>
	/// </value>
	public bool TranslateFile { get; set; } = true;

	/// <summary>
	/// Make properties enumerable, needed if you want to use JSON.stringify.
	/// </summary>
	/// <remarks>
	/// <blockquote class="NOTE"><h5>NOTE</h5>
	/// <para>
	/// cstojs_options.xml: &lt;Option MakePropertiesEnumerable=&quot;false&quot; /&gt;
	/// </para>
	/// </blockquote>
	/// <blockquote class="NOTE"><h5>NOTE</h5>
	/// <para>
	///	Note, class must have constructor!
	/// </para>
	/// </blockquote>
	/// </remarks>
	/// <value>
	/// Default: <c>false</c>
	/// </value>
	public bool MakePropertiesEnumerable { get; set; } = false;

	/// <summary>
	/// Enable module export/import. Three-state value.
	/// </summary>
	/// <remarks>
	/// <blockquote class="NOTE"><h5>NOTE</h5>
	/// <para>
	/// cstojs_options.xml: &lt;Option EnableModules=&quot;1&quot; /&gt;
	/// </para>
	/// </blockquote>
	/// <blockquote class="NOTE"><h5>NOTE</h5>
	/// <para>
	/// Note, for imports a filename needs to be supplied.
	/// </para>
	/// </blockquote>
	/// <blockquote class="IMPORTANT"><h5>IMPORTANT</h5>
	/// <para>
	/// Only public classes are exported/imported.
	/// </para>
	/// </blockquote>
	/// <para>
	/// Possible values: <br />
	/// 0 = Disable modules. No exports or imports. <br />
	/// 1 = Automatic. If 2 or more files are supplied, enable modules. <br />
	/// 2 = Enable modules. <br />
	/// </para>
	/// </remarks>
	/// <value>
	/// Default: <c>1</c>
	/// </value>
	public byte EnableModules { get; set; } = 1;

	/// <summary>
	/// Array of custom names to convert.
	/// </summary>
	/// <remarks>Example: <c>new(){["Console"] = "console"}</c>. Will convert "Console" to "console".
	/// <blockquote class="NOTE"><h5>NOTE</h5>
	/// <para>
	/// cstojs_options.xml: &lt;Option CustomCSNamesToJS=&quot;Console-console,WriteLine-log&quot; /&gt;
	/// </para>
	/// </blockquote>
	/// </remarks>
	/// <value>
	/// Default: <c>new()</c>
	/// </value>
	public Dictionary<string, string> CustomCSNamesToJS { get; set; } = new();

	/// <summary>
	/// Custom directory path to the DLLs.
	/// </summary>
	/// <remarks>
	/// <para>
	/// Searches for any DLL in the specified directory and then imports references into compilation.
	/// </para>
	/// <blockquote class="NOTE"><h5>NOTE</h5>
	/// <para>
	/// cstojs_options.xml: &lt;Option CustomPathToDLLs=&quot;./bin&quot; /&gt;
	/// </para>
	/// </blockquote>
	/// <blockquote class="IMPORTANT"><h5>IMPORTANT</h5>
	/// <para>
	/// The option needs to be specified in the first file or globally if using CSTOJS_CLI.
	/// </para>
	/// </blockquote>
	/// </remarks>
	/// <value>
	/// Default: <c>./bin/</c>
	/// </value>
	public string CustomPathToDLLs { get; set; } = "./bin/";
	
	/// <summary>
	/// Add a <see cref="StringBuilder" /> to the front of a javascript file.
	/// </summary>
	/// <remarks>
	/// <blockquote class="NOTE"><h5>NOTE</h5>
	/// <para>
	/// cstojs_options.xml: &lt;Option AddSBAtTheTop=&quot;//this is comment&quot; /&gt;
	/// </para>
	/// </blockquote>
	/// </remarks>
	/// <value>
	/// Default: <c>new()</c>
	/// </value>
	public StringBuilder AddSBAtTheTop { get; set; } = new();

	/// <summary>
	/// Add a <see cref="StringBuilder" /> to the end of a javascript file.
	/// </summary>
	/// <remarks>
	/// <blockquote class="NOTE"><h5>NOTE</h5>
	/// <para>
	/// cstojs_options.xml: &lt;Option AddSBAtTheBottom=&quot;//this is comment&quot; /&gt;
	/// </para>
	/// </blockquote>
	/// </remarks>
	/// <value>
	/// Default: <c>new()</c>
	/// </value>
	public StringBuilder AddSBAtTheBottom { get; set; } = new();
	
	/// <summary>
	/// Creates new default options. See <see cref="CSTOJSOptions" />.
	/// </summary>
	public CSTOJSOptions()
	{

	}
}

