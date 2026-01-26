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
	/// Useful for the tests.
	/// </summary>
	/// <remarks>
	/// <blockquote class="NOTE"><h5>NOTE</h5>
	/// <para>
	/// cstojs_options.xml: &lt;Option DisableCompilationErrors=&quot;false&quot; /&gt;
	/// </para>
	/// </blockquote>
	/// </remarks>
	/// <value>
	/// Default: <c>false</c>
	/// </value>
	public bool DisableCompilationErrors { get; set; } = false;

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

