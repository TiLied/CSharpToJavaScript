//22.10.2023 19:25:19
using static CSharpToJavaScript.APIs.JS.GlobalObject;
using CSharpToJavaScript.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpToJavaScript.APIs.JS;

using HTMLOrSVGScriptElement = Union5;
using MediaProvider = Union7;
using RenderingContext = Union14;
using HTMLOrSVGImageElement = Union15;
using CanvasImageSource = Union16;
using OffscreenRenderingContext = Union23;
using EventHandler = EventHandlerNonNull;
using OnErrorEventHandler = OnErrorEventHandlerNonNull;
using OnBeforeUnloadEventHandler = OnBeforeUnloadEventHandlerNonNull;
using TimerHandler = Union28;
using ImageBitmapSource = Union29;
using MessageEventSource = Union30;
using ClipboardItemData = Task<string>;
using ClipboardItems = List<ClipboardItem>;
using PasswordCredentialInit = Union32;
using BinaryData = Union34;
using LayoutFragmentRequestOrIntrinsicSizesRequest = Union36;
using BlobPart = Union51;
using HeadersInit = Union56;
using XMLHttpRequestBodyInit = Union57;
using BodyInit = Union58;
using RequestInfo = Union59;
using FileSystemWriteChunkType = Union61;
using ReadableStreamReader = Union62;
using ReadableStreamController = Union63;
using URLPatternInput = Union65;
using ArrayBufferView = Union66;
using BufferSource = Union67;
using AllowSharedBufferSource = Union68;
using FormDataEntryValue = Union72;
using ConstrainPoint2D = Union84;
using RotationMatrixType = Union85;
using ReportList = List<Report>;
using AuthenticationExtensionsAuthenticatorInputs = Dictionary<string, string>;
using COSEAlgorithmIdentifier = long;
using AuthenticatorSelectionList = List<Unsupported /*AAGUID*/>;
using AAGUID = Unsupported /*BufferSource*/;
using AuthenticationExtensionsSupported = List<string>;
using UvmEntry = List<ulong>;
using UvmEntries = List<Unsupported /*UvmEntry*/>;
using ImageBufferSource = Union95;
using GPUBufferUsageFlags = ulong;
using GPUMapModeFlags = ulong;
using GPUTextureUsageFlags = ulong;
using GPUShaderStageFlags = ulong;
using GPUBindingResource = Union97;
using GPUPipelineConstantValue = Number;
using GPUColorWriteFlags = ulong;
using GPUImageCopyExternalImageSource = Union100;
using GPUBufferDynamicOffset = ulong;
using GPUStencilValue = ulong;
using GPUSampleMask = ulong;
using GPUDepthBias = long;
using GPUSize64 = ulong;
using GPUIntegerCoordinate = ulong;
using GPUIndex32 = ulong;
using GPUSize32 = ulong;
using GPUSignedOffset32 = long;
using GPUSize64Out = ulong;
using GPUIntegerCoordinateOut = ulong;
using GPUSize32Out = ulong;
using GPUFlagsConstant = ulong;
using GPUColor = Union102;
using GPUOrigin2D = Union103;
using GPUOrigin3D = Union104;
using GPUExtent3D = Union105;
using MLNamedArrayBufferViews = Dictionary<string, Unsupported /*ArrayBufferView*/>;
using MLGPUResource = Union106;
using MLNamedGPUResources = Dictionary<string, Unsupported /*MLGPUResource*/>;
using MLNamedOperands = Dictionary<string, MLOperand>;
using MLBufferView = Union107;
using RTCRtpTransform = Union109;
using SmallCryptoKeyID = ulong;
using CryptoKeyID = Union110;
using LineAndPositionSetting = Union111;
using XRWebGLRenderingContext = Union112;
using WindowProxy = Window;

[To(ToAttribute.Default)]
public partial class HTMLAllCollection
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Length { get; }
	
	
		[To(ToAttribute.FirstCharToLowerCase)]
	public Union1? Item(string nameOrIndex) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLFormControlsCollection/HTMLFormControlsCollection.generated.xml' path='docs/HTMLFormControlsCollection/*'/>
[To(ToAttribute.Default)]
public partial class HTMLFormControlsCollection : HTMLCollection
{
	
}

///<include file='Utils/Docs/RadioNodeList/RadioNodeList.generated.xml' path='docs/RadioNodeList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class RadioNodeList : NodeList
{
	///<include file='Utils/Docs/RadioNodeListValue/RadioNodeListValue.generated.xml' path='docs/RadioNodeListValue/*'/>
	public string Value { get; set; }
}

///<include file='Utils/Docs/HTMLOptionsCollection/HTMLOptionsCollection.generated.xml' path='docs/HTMLOptionsCollection/*'/>
[To(ToAttribute.Default)]
public partial class HTMLOptionsCollection : HTMLCollection
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Length { get; set; }
	
		[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Add(Union3 element, Union4? before) { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Remove(long index) { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public long SelectedIndex { get; set; }
}

///<include file='Utils/Docs/DOMStringList/DOMStringList.generated.xml' path='docs/DOMStringList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMStringList
{
	///<include file='Utils/Docs/DOMStringListLength/DOMStringListLength.generated.xml' path='docs/DOMStringListLength/*'/>
	public ulong Length { get; }
	
	///<include file='Utils/Docs/DOMStringListContains/DOMStringListContains.generated.xml' path='docs/DOMStringListContains/*'/>
	public bool Contains(string string_) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/DocumentReadyState/DocumentReadyState.generated.xml' path='docs/DocumentReadyState/*'/>
public enum DocumentReadyState
{
	Loading,
	Interactive,
	Complete,
}

///<include file='Utils/Docs/DocumentVisibilityState/DocumentVisibilityState.generated.xml' path='docs/DocumentVisibilityState/*'/>
public enum DocumentVisibilityState
{
	Visible,
	Hidden,
}


///<include file='Utils/Docs/Document/Document.generated.xml' path='docs/Document/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Document
{
	///<include file='Utils/Docs/DocumentLocation/DocumentLocation.generated.xml' path='docs/DocumentLocation/*'/>
	public Location? Location { get; }
	///<include file='Utils/Docs/DocumentDomain/DocumentDomain.generated.xml' path='docs/DocumentDomain/*'/>
	public string Domain { get; set; }
	///<include file='Utils/Docs/DocumentReferrer/DocumentReferrer.generated.xml' path='docs/DocumentReferrer/*'/>
	public string Referrer { get; }
	///<include file='Utils/Docs/DocumentCookie/DocumentCookie.generated.xml' path='docs/DocumentCookie/*'/>
	public string Cookie { get; set; }
	///<include file='Utils/Docs/DocumentLastModified/DocumentLastModified.generated.xml' path='docs/DocumentLastModified/*'/>
	public string LastModified { get; }
	///<include file='Utils/Docs/DocumentReadyState/DocumentReadyState.generated.xml' path='docs/DocumentReadyState/*'/>
	public DocumentReadyState ReadyState { get; }
	
	///<include file='Utils/Docs/DocumentTitle/DocumentTitle.generated.xml' path='docs/DocumentTitle/*'/>
	public string Title { get; set; }
	///<include file='Utils/Docs/DocumentDir/DocumentDir.generated.xml' path='docs/DocumentDir/*'/>
	public string Dir { get; set; }
	///<include file='Utils/Docs/DocumentBody/DocumentBody.generated.xml' path='docs/DocumentBody/*'/>
	public HTMLElement? Body { get; set; }
	///<include file='Utils/Docs/DocumentHead/DocumentHead.generated.xml' path='docs/DocumentHead/*'/>
	public HTMLHeadElement? Head { get; }
	///<include file='Utils/Docs/DocumentImages/DocumentImages.generated.xml' path='docs/DocumentImages/*'/>
	public HTMLCollection Images { get; }
	///<include file='Utils/Docs/DocumentEmbeds/DocumentEmbeds.generated.xml' path='docs/DocumentEmbeds/*'/>
	public HTMLCollection Embeds { get; }
	///<include file='Utils/Docs/DocumentPlugins/DocumentPlugins.generated.xml' path='docs/DocumentPlugins/*'/>
	public HTMLCollection Plugins { get; }
	///<include file='Utils/Docs/DocumentLinks/DocumentLinks.generated.xml' path='docs/DocumentLinks/*'/>
	public HTMLCollection Links { get; }
	///<include file='Utils/Docs/DocumentForms/DocumentForms.generated.xml' path='docs/DocumentForms/*'/>
	public HTMLCollection Forms { get; }
	///<include file='Utils/Docs/DocumentScripts/DocumentScripts.generated.xml' path='docs/DocumentScripts/*'/>
	public HTMLCollection Scripts { get; }
	///<include file='Utils/Docs/DocumentGetElementsByName/DocumentGetElementsByName.generated.xml' path='docs/DocumentGetElementsByName/*'/>
	public NodeList GetElementsByName(string elementName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentCurrentScript/DocumentCurrentScript.generated.xml' path='docs/DocumentCurrentScript/*'/>
	public HTMLOrSVGScriptElement? CurrentScript { get; }
	///<include file='Utils/Docs/DocumentOpen/DocumentOpen.generated.xml' path='docs/DocumentOpen/*'/>
	public Document Open(string unused1, string unused2) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentOpen/DocumentOpen.generated.xml' path='docs/DocumentOpen/*'/>
	public WindowProxy? Open(string url, string name, string features) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentClose/DocumentClose.generated.xml' path='docs/DocumentClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentWrite/DocumentWrite.generated.xml' path='docs/DocumentWrite/*'/>
	public Undefined Write(params string[] text) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentWriteln/DocumentWriteln.generated.xml' path='docs/DocumentWriteln/*'/>
	public Undefined Writeln(params string[] text) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentDefaultView/DocumentDefaultView.generated.xml' path='docs/DocumentDefaultView/*'/>
	public WindowProxy? DefaultView { get; }
	///<include file='Utils/Docs/DocumentHasFocus/DocumentHasFocus.generated.xml' path='docs/DocumentHasFocus/*'/>
	public bool HasFocus() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentDesignMode/DocumentDesignMode.generated.xml' path='docs/DocumentDesignMode/*'/>
	public string DesignMode { get; set; }
	///<include file='Utils/Docs/DocumentExecCommand/DocumentExecCommand.generated.xml' path='docs/DocumentExecCommand/*'/>
	public bool ExecCommand(string commandId, bool showUI, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentQueryCommandEnabled/DocumentQueryCommandEnabled.generated.xml' path='docs/DocumentQueryCommandEnabled/*'/>
	public bool QueryCommandEnabled(string commandId) { throw new System.NotImplementedException(); }
		public bool QueryCommandIndeterm(string commandId) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentQueryCommandState/DocumentQueryCommandState.generated.xml' path='docs/DocumentQueryCommandState/*'/>
	public bool QueryCommandState(string commandId) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentQueryCommandSupported/DocumentQueryCommandSupported.generated.xml' path='docs/DocumentQueryCommandSupported/*'/>
	public bool QueryCommandSupported(string commandId) { throw new System.NotImplementedException(); }
		public string QueryCommandValue(string commandId) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentHidden/DocumentHidden.generated.xml' path='docs/DocumentHidden/*'/>
	public bool Hidden { get; }
	///<include file='Utils/Docs/DocumentVisibilityState/DocumentVisibilityState.generated.xml' path='docs/DocumentVisibilityState/*'/>
	public DocumentVisibilityState VisibilityState { get; }
		public EventHandler Onreadystatechange { get; set; }
		public EventHandler Onvisibilitychange { get; set; }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial interface DocumentOrShadowRoot
{
		public Element? ActiveElement { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/HTMLElement/HTMLElement.generated.xml' path='docs/HTMLElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLElement : Element, GlobalEventHandlers, ElementContentEditable, HTMLOrSVGElement, ElementCSSInlineStyle
{
		public HTMLElement() { }
	///<include file='Utils/Docs/HTMLElementTitle/HTMLElementTitle.generated.xml' path='docs/HTMLElementTitle/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Title { get; set; }
	///<include file='Utils/Docs/HTMLElementLang/HTMLElementLang.generated.xml' path='docs/HTMLElementLang/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Lang { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Translate { get; set; }
	///<include file='Utils/Docs/HTMLElementDir/HTMLElementDir.generated.xml' path='docs/HTMLElementDir/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Dir { get; set; }
	///<include file='Utils/Docs/HTMLElementHidden/HTMLElementHidden.generated.xml' path='docs/HTMLElementHidden/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Union6? Hidden { get; set; }
	///<include file='Utils/Docs/HTMLElementInert/HTMLElementInert.generated.xml' path='docs/HTMLElementInert/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Inert { get; set; }
	///<include file='Utils/Docs/HTMLElementClick/HTMLElementClick.generated.xml' path='docs/HTMLElementClick/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Click() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLElementAccessKey/HTMLElementAccessKey.generated.xml' path='docs/HTMLElementAccessKey/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string AccessKey { get; set; }
	///<include file='Utils/Docs/HTMLElementAccessKeyLabel/HTMLElementAccessKeyLabel.generated.xml' path='docs/HTMLElementAccessKeyLabel/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string AccessKeyLabel { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Draggable { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Spellcheck { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Autocapitalize { get; set; }
	///<include file='Utils/Docs/HTMLElementInnerText/HTMLElementInnerText.generated.xml' path='docs/HTMLElementInnerText/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string InnerText { get; set; }
	///<include file='Utils/Docs/HTMLElementOuterText/HTMLElementOuterText.generated.xml' path='docs/HTMLElementOuterText/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string OuterText { get; set; }
	///<include file='Utils/Docs/HTMLElementAttachInternals/HTMLElementAttachInternals.generated.xml' path='docs/HTMLElementAttachInternals/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ElementInternals AttachInternals() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLElementShowPopover/HTMLElementShowPopover.generated.xml' path='docs/HTMLElementShowPopover/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined ShowPopover() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLElementHidePopover/HTMLElementHidePopover.generated.xml' path='docs/HTMLElementHidePopover/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined HidePopover() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLElementTogglePopover/HTMLElementTogglePopover.generated.xml' path='docs/HTMLElementTogglePopover/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool TogglePopover(bool force) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLElementPopover/HTMLElementPopover.generated.xml' path='docs/HTMLElementPopover/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string? Popover { get; set; }
}




///<include file='Utils/Docs/HTMLUnknownElement/HTMLUnknownElement.generated.xml' path='docs/HTMLUnknownElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLUnknownElement : HTMLElement
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface HTMLOrSVGElement
{
		public string Dataset { get { throw new System.NotImplementedException(); } }
		public string Nonce { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public bool Autofocus { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public long TabIndex { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public Undefined Focus(FocusOptions options) { throw new System.NotImplementedException(); }
		public Undefined Blur() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/DOMStringMap/DOMStringMap.generated.xml' path='docs/DOMStringMap/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMStringMap
{
	
	
	
}

///<include file='Utils/Docs/HTMLHtmlElement/HTMLHtmlElement.generated.xml' path='docs/HTMLHtmlElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLHtmlElement : HTMLElement
{
		public HTMLHtmlElement() { }
}

///<include file='Utils/Docs/HTMLHeadElement/HTMLHeadElement.generated.xml' path='docs/HTMLHeadElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLHeadElement : HTMLElement
{
		public HTMLHeadElement() { }
}

///<include file='Utils/Docs/HTMLTitleElement/HTMLTitleElement.generated.xml' path='docs/HTMLTitleElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTitleElement : HTMLElement
{
		public HTMLTitleElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Text { get; set; }
}

///<include file='Utils/Docs/HTMLBaseElement/HTMLBaseElement.generated.xml' path='docs/HTMLBaseElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLBaseElement : HTMLElement
{
		public HTMLBaseElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Href { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Target { get; set; }
}

///<include file='Utils/Docs/HTMLLinkElement/HTMLLinkElement.generated.xml' path='docs/HTMLLinkElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLLinkElement : HTMLElement, LinkStyle
{
		public HTMLLinkElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Href { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string? CrossOrigin { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementRel/HTMLLinkElementRel.generated.xml' path='docs/HTMLLinkElementRel/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Rel { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementAs/HTMLLinkElementAs.generated.xml' path='docs/HTMLLinkElementAs/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string As { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementRelList/HTMLLinkElementRelList.generated.xml' path='docs/HTMLLinkElementRelList/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList RelList { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Media { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Integrity { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Hreflang { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList Sizes { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string ImageSrcset { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string ImageSizes { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementReferrerPolicy/HTMLLinkElementReferrerPolicy.generated.xml' path='docs/HTMLLinkElementReferrerPolicy/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string ReferrerPolicy { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList Blocking { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementFetchPriority/HTMLLinkElementFetchPriority.generated.xml' path='docs/HTMLLinkElementFetchPriority/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string FetchPriority { get; set; }
}


///<include file='Utils/Docs/HTMLMetaElement/HTMLMetaElement.generated.xml' path='docs/HTMLMetaElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLMetaElement : HTMLElement
{
		public HTMLMetaElement() { }
	///<include file='Utils/Docs/HTMLMetaElementName/HTMLMetaElementName.generated.xml' path='docs/HTMLMetaElementName/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	///<include file='Utils/Docs/HTMLMetaElementHttpEquiv/HTMLMetaElementHttpEquiv.generated.xml' path='docs/HTMLMetaElementHttpEquiv/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string HttpEquiv { get; set; }
	///<include file='Utils/Docs/HTMLMetaElementContent/HTMLMetaElementContent.generated.xml' path='docs/HTMLMetaElementContent/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Content { get; set; }
	///<include file='Utils/Docs/HTMLMetaElementMedia/HTMLMetaElementMedia.generated.xml' path='docs/HTMLMetaElementMedia/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Media { get; set; }
}

///<include file='Utils/Docs/HTMLStyleElement/HTMLStyleElement.generated.xml' path='docs/HTMLStyleElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLStyleElement : HTMLElement, LinkStyle
{
		public HTMLStyleElement() { }
	///<include file='Utils/Docs/HTMLStyleElementDisabled/HTMLStyleElementDisabled.generated.xml' path='docs/HTMLStyleElementDisabled/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	///<include file='Utils/Docs/HTMLStyleElementMedia/HTMLStyleElementMedia.generated.xml' path='docs/HTMLStyleElementMedia/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Media { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList Blocking { get; }
}


///<include file='Utils/Docs/HTMLBodyElement/HTMLBodyElement.generated.xml' path='docs/HTMLBodyElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLBodyElement : HTMLElement, WindowEventHandlers
{
		public HTMLBodyElement() { }
}


///<include file='Utils/Docs/HTMLHeadingElement/HTMLHeadingElement.generated.xml' path='docs/HTMLHeadingElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLHeadingElement : HTMLElement
{
		public HTMLHeadingElement() { }
}

///<include file='Utils/Docs/HTMLParagraphElement/HTMLParagraphElement.generated.xml' path='docs/HTMLParagraphElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLParagraphElement : HTMLElement
{
		public HTMLParagraphElement() { }
}

///<include file='Utils/Docs/HTMLHRElement/HTMLHRElement.generated.xml' path='docs/HTMLHRElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLHRElement : HTMLElement
{
		public HTMLHRElement() { }
}

///<include file='Utils/Docs/HTMLPreElement/HTMLPreElement.generated.xml' path='docs/HTMLPreElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLPreElement : HTMLElement
{
		public HTMLPreElement() { }
}

///<include file='Utils/Docs/HTMLQuoteElement/HTMLQuoteElement.generated.xml' path='docs/HTMLQuoteElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLQuoteElement : HTMLElement
{
		public HTMLQuoteElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Cite { get; set; }
}

///<include file='Utils/Docs/HTMLOListElement/HTMLOListElement.generated.xml' path='docs/HTMLOListElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLOListElement : HTMLElement
{
		public HTMLOListElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Reversed { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public long Start { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
}

///<include file='Utils/Docs/HTMLUListElement/HTMLUListElement.generated.xml' path='docs/HTMLUListElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLUListElement : HTMLElement
{
		public HTMLUListElement() { }
}

///<include file='Utils/Docs/HTMLMenuElement/HTMLMenuElement.generated.xml' path='docs/HTMLMenuElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLMenuElement : HTMLElement
{
		public HTMLMenuElement() { }
}

///<include file='Utils/Docs/HTMLLIElement/HTMLLIElement.generated.xml' path='docs/HTMLLIElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLLIElement : HTMLElement
{
		public HTMLLIElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public long Value { get; set; }
}

///<include file='Utils/Docs/HTMLDListElement/HTMLDListElement.generated.xml' path='docs/HTMLDListElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLDListElement : HTMLElement
{
		public HTMLDListElement() { }
}

///<include file='Utils/Docs/HTMLDivElement/HTMLDivElement.generated.xml' path='docs/HTMLDivElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLDivElement : HTMLElement
{
		public HTMLDivElement() { }
}

///<include file='Utils/Docs/HTMLAnchorElement/HTMLAnchorElement.generated.xml' path='docs/HTMLAnchorElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLAnchorElement : HTMLElement, HTMLHyperlinkElementUtils
{
		public HTMLAnchorElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Target { get; set; }
	///<include file='Utils/Docs/HTMLAnchorElementDownload/HTMLAnchorElementDownload.generated.xml' path='docs/HTMLAnchorElementDownload/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Download { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Ping { get; set; }
	///<include file='Utils/Docs/HTMLAnchorElementRel/HTMLAnchorElementRel.generated.xml' path='docs/HTMLAnchorElementRel/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Rel { get; set; }
	///<include file='Utils/Docs/HTMLAnchorElementRelList/HTMLAnchorElementRelList.generated.xml' path='docs/HTMLAnchorElementRelList/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList RelList { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Hreflang { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Text { get; set; }
	///<include file='Utils/Docs/HTMLAnchorElementReferrerPolicy/HTMLAnchorElementReferrerPolicy.generated.xml' path='docs/HTMLAnchorElementReferrerPolicy/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string ReferrerPolicy { get; set; }
}


///<include file='Utils/Docs/HTMLDataElement/HTMLDataElement.generated.xml' path='docs/HTMLDataElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLDataElement : HTMLElement
{
		public HTMLDataElement() { }
	///<include file='Utils/Docs/HTMLDataElementValue/HTMLDataElementValue.generated.xml' path='docs/HTMLDataElementValue/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
}

///<include file='Utils/Docs/HTMLTimeElement/HTMLTimeElement.generated.xml' path='docs/HTMLTimeElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTimeElement : HTMLElement
{
		public HTMLTimeElement() { }
	///<include file='Utils/Docs/HTMLTimeElementDateTime/HTMLTimeElementDateTime.generated.xml' path='docs/HTMLTimeElementDateTime/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string DateTime { get; set; }
}

///<include file='Utils/Docs/HTMLSpanElement/HTMLSpanElement.generated.xml' path='docs/HTMLSpanElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLSpanElement : HTMLElement
{
		public HTMLSpanElement() { }
}

///<include file='Utils/Docs/HTMLBRElement/HTMLBRElement.generated.xml' path='docs/HTMLBRElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLBRElement : HTMLElement
{
		public HTMLBRElement() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface HTMLHyperlinkElementUtils
{
		public string Href { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string Origin { get { throw new System.NotImplementedException(); } }
		public string Protocol { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string Username { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string Password { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string Host { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string Hostname { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string Port { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string Pathname { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string Search { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string Hash { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/HTMLModElement/HTMLModElement.generated.xml' path='docs/HTMLModElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLModElement : HTMLElement
{
		public HTMLModElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Cite { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string DateTime { get; set; }
}

///<include file='Utils/Docs/HTMLPictureElement/HTMLPictureElement.generated.xml' path='docs/HTMLPictureElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLPictureElement : HTMLElement
{
		public HTMLPictureElement() { }
}

///<include file='Utils/Docs/HTMLSourceElement/HTMLSourceElement.generated.xml' path='docs/HTMLSourceElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLSourceElement : HTMLElement
{
		public HTMLSourceElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Srcset { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Sizes { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Media { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Width { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Height { get; set; }
}

///<include file='Utils/Docs/HTMLImageElement/HTMLImageElement.generated.xml' path='docs/HTMLImageElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLImageElement : HTMLElement
{
		public HTMLImageElement() { }
	///<include file='Utils/Docs/HTMLImageElementAlt/HTMLImageElementAlt.generated.xml' path='docs/HTMLImageElementAlt/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Alt { get; set; }
	///<include file='Utils/Docs/HTMLImageElementSrc/HTMLImageElementSrc.generated.xml' path='docs/HTMLImageElementSrc/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	///<include file='Utils/Docs/HTMLImageElementSrcset/HTMLImageElementSrcset.generated.xml' path='docs/HTMLImageElementSrcset/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Srcset { get; set; }
	///<include file='Utils/Docs/HTMLImageElementSizes/HTMLImageElementSizes.generated.xml' path='docs/HTMLImageElementSizes/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Sizes { get; set; }
	///<include file='Utils/Docs/HTMLImageElementCrossOrigin/HTMLImageElementCrossOrigin.generated.xml' path='docs/HTMLImageElementCrossOrigin/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string? CrossOrigin { get; set; }
	///<include file='Utils/Docs/HTMLImageElementUseMap/HTMLImageElementUseMap.generated.xml' path='docs/HTMLImageElementUseMap/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string UseMap { get; set; }
	///<include file='Utils/Docs/HTMLImageElementIsMap/HTMLImageElementIsMap.generated.xml' path='docs/HTMLImageElementIsMap/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool IsMap { get; set; }
	///<include file='Utils/Docs/HTMLImageElementWidth/HTMLImageElementWidth.generated.xml' path='docs/HTMLImageElementWidth/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Width { get; set; }
	///<include file='Utils/Docs/HTMLImageElementHeight/HTMLImageElementHeight.generated.xml' path='docs/HTMLImageElementHeight/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Height { get; set; }
	///<include file='Utils/Docs/HTMLImageElementNaturalWidth/HTMLImageElementNaturalWidth.generated.xml' path='docs/HTMLImageElementNaturalWidth/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong NaturalWidth { get; }
	///<include file='Utils/Docs/HTMLImageElementNaturalHeight/HTMLImageElementNaturalHeight.generated.xml' path='docs/HTMLImageElementNaturalHeight/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong NaturalHeight { get; }
	///<include file='Utils/Docs/HTMLImageElementComplete/HTMLImageElementComplete.generated.xml' path='docs/HTMLImageElementComplete/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Complete { get; }
	///<include file='Utils/Docs/HTMLImageElementCurrentSrc/HTMLImageElementCurrentSrc.generated.xml' path='docs/HTMLImageElementCurrentSrc/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string CurrentSrc { get; }
	///<include file='Utils/Docs/HTMLImageElementReferrerPolicy/HTMLImageElementReferrerPolicy.generated.xml' path='docs/HTMLImageElementReferrerPolicy/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string ReferrerPolicy { get; set; }
	///<include file='Utils/Docs/HTMLImageElementDecoding/HTMLImageElementDecoding.generated.xml' path='docs/HTMLImageElementDecoding/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Decoding { get; set; }
	///<include file='Utils/Docs/HTMLImageElementLoading/HTMLImageElementLoading.generated.xml' path='docs/HTMLImageElementLoading/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Loading { get; set; }
	///<include file='Utils/Docs/HTMLImageElementFetchPriority/HTMLImageElementFetchPriority.generated.xml' path='docs/HTMLImageElementFetchPriority/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string FetchPriority { get; set; }
	///<include file='Utils/Docs/HTMLImageElementDecode/HTMLImageElementDecode.generated.xml' path='docs/HTMLImageElementDecode/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Task<Undefined> Decode() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLIFrameElement/HTMLIFrameElement.generated.xml' path='docs/HTMLIFrameElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLIFrameElement : HTMLElement
{
		public HTMLIFrameElement() { }
	///<include file='Utils/Docs/HTMLIFrameElementSrc/HTMLIFrameElementSrc.generated.xml' path='docs/HTMLIFrameElementSrc/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementSrcdoc/HTMLIFrameElementSrcdoc.generated.xml' path='docs/HTMLIFrameElementSrcdoc/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Srcdoc { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList Sandbox { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Allow { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool AllowFullscreen { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Width { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Height { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementReferrerPolicy/HTMLIFrameElementReferrerPolicy.generated.xml' path='docs/HTMLIFrameElementReferrerPolicy/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string ReferrerPolicy { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Loading { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementContentDocument/HTMLIFrameElementContentDocument.generated.xml' path='docs/HTMLIFrameElementContentDocument/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Document? ContentDocument { get; }
	///<include file='Utils/Docs/HTMLIFrameElementContentWindow/HTMLIFrameElementContentWindow.generated.xml' path='docs/HTMLIFrameElementContentWindow/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public WindowProxy? ContentWindow { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Document? GetSVGDocument() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLEmbedElement/HTMLEmbedElement.generated.xml' path='docs/HTMLEmbedElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLEmbedElement : HTMLElement
{
		public HTMLEmbedElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Width { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Height { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Document? GetSVGDocument() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLObjectElement/HTMLObjectElement.generated.xml' path='docs/HTMLObjectElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLObjectElement : HTMLElement
{
		public HTMLObjectElement() { }
	///<include file='Utils/Docs/HTMLObjectElementData/HTMLObjectElementData.generated.xml' path='docs/HTMLObjectElementData/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Data { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementType/HTMLObjectElementType.generated.xml' path='docs/HTMLObjectElementType/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementName/HTMLObjectElementName.generated.xml' path='docs/HTMLObjectElementName/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementForm/HTMLObjectElementForm.generated.xml' path='docs/HTMLObjectElementForm/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	///<include file='Utils/Docs/HTMLObjectElementWidth/HTMLObjectElementWidth.generated.xml' path='docs/HTMLObjectElementWidth/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Width { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementHeight/HTMLObjectElementHeight.generated.xml' path='docs/HTMLObjectElementHeight/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Height { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementContentDocument/HTMLObjectElementContentDocument.generated.xml' path='docs/HTMLObjectElementContentDocument/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Document? ContentDocument { get; }
	///<include file='Utils/Docs/HTMLObjectElementContentWindow/HTMLObjectElementContentWindow.generated.xml' path='docs/HTMLObjectElementContentWindow/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public WindowProxy? ContentWindow { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Document? GetSVGDocument() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLObjectElementWillValidate/HTMLObjectElementWillValidate.generated.xml' path='docs/HTMLObjectElementWillValidate/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
	///<include file='Utils/Docs/HTMLObjectElementValidity/HTMLObjectElementValidity.generated.xml' path='docs/HTMLObjectElementValidity/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
	///<include file='Utils/Docs/HTMLObjectElementValidationMessage/HTMLObjectElementValidationMessage.generated.xml' path='docs/HTMLObjectElementValidationMessage/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
	///<include file='Utils/Docs/HTMLObjectElementCheckValidity/HTMLObjectElementCheckValidity.generated.xml' path='docs/HTMLObjectElementCheckValidity/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLObjectElementSetCustomValidity/HTMLObjectElementSetCustomValidity.generated.xml' path='docs/HTMLObjectElementSetCustomValidity/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetCustomValidity(string error) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLVideoElement/HTMLVideoElement.generated.xml' path='docs/HTMLVideoElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLVideoElement : HTMLMediaElement
{
		public HTMLVideoElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Width { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Height { get; set; }
	///<include file='Utils/Docs/HTMLVideoElementVideoWidth/HTMLVideoElementVideoWidth.generated.xml' path='docs/HTMLVideoElementVideoWidth/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong VideoWidth { get; }
	///<include file='Utils/Docs/HTMLVideoElementVideoHeight/HTMLVideoElementVideoHeight.generated.xml' path='docs/HTMLVideoElementVideoHeight/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong VideoHeight { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Poster { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool PlaysInline { get; set; }
}

///<include file='Utils/Docs/HTMLAudioElement/HTMLAudioElement.generated.xml' path='docs/HTMLAudioElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLAudioElement : HTMLMediaElement
{
		public HTMLAudioElement() { }
}

///<include file='Utils/Docs/HTMLTrackElement/HTMLTrackElement.generated.xml' path='docs/HTMLTrackElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTrackElement : HTMLElement
{
		public HTMLTrackElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Kind { get; set; }
	///<include file='Utils/Docs/HTMLTrackElementSrc/HTMLTrackElementSrc.generated.xml' path='docs/HTMLTrackElementSrc/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Srclang { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Label { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Default { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort NONE = 0;
		[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort LOADING = 1;
		[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort LOADED = 2;
		[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort ERROR = 3;
		[To(ToAttribute.FirstCharToLowerCase)]
	public ushort ReadyState { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrack Track { get; }
}

public enum CanPlayTypeResult
{
	Empty,
	Maybe,
	Probably,
}


///<include file='Utils/Docs/HTMLMediaElement/HTMLMediaElement.generated.xml' path='docs/HTMLMediaElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLMediaElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLMediaElementError/HTMLMediaElementError.generated.xml' path='docs/HTMLMediaElementError/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public MediaError? Error { get; }
	///<include file='Utils/Docs/HTMLMediaElementSrc/HTMLMediaElementSrc.generated.xml' path='docs/HTMLMediaElementSrc/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementSrcObject/HTMLMediaElementSrcObject.generated.xml' path='docs/HTMLMediaElementSrcObject/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public MediaProvider? SrcObject { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementCurrentSrc/HTMLMediaElementCurrentSrc.generated.xml' path='docs/HTMLMediaElementCurrentSrc/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string CurrentSrc { get; }
	///<include file='Utils/Docs/HTMLMediaElementCrossOrigin/HTMLMediaElementCrossOrigin.generated.xml' path='docs/HTMLMediaElementCrossOrigin/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string? CrossOrigin { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort NETWORK_EMPTY = 0;
		[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort NETWORK_IDLE = 1;
		[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort NETWORK_LOADING = 2;
		[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort NETWORK_NO_SOURCE = 3;
	///<include file='Utils/Docs/HTMLMediaElementNetworkState/HTMLMediaElementNetworkState.generated.xml' path='docs/HTMLMediaElementNetworkState/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ushort NetworkState { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Preload { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool BufferingThrottled { get; }
	///<include file='Utils/Docs/HTMLMediaElementLoad/HTMLMediaElementLoad.generated.xml' path='docs/HTMLMediaElementLoad/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Load() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLMediaElementCanPlayType/HTMLMediaElementCanPlayType.generated.xml' path='docs/HTMLMediaElementCanPlayType/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public CanPlayTypeResult CanPlayType(string type) { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort HAVE_NOTHING = 0;
		[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort HAVE_METADATA = 1;
		[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort HAVE_CURRENT_DATA = 2;
		[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort HAVE_FUTURE_DATA = 3;
		[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort HAVE_ENOUGH_DATA = 4;
	///<include file='Utils/Docs/HTMLMediaElementReadyState/HTMLMediaElementReadyState.generated.xml' path='docs/HTMLMediaElementReadyState/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ushort ReadyState { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Seeking { get; }
	///<include file='Utils/Docs/HTMLMediaElementCurrentTime/HTMLMediaElementCurrentTime.generated.xml' path='docs/HTMLMediaElementCurrentTime/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Number CurrentTime { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementFastSeek/HTMLMediaElementFastSeek.generated.xml' path='docs/HTMLMediaElementFastSeek/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined FastSeek(Number time) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLMediaElementDuration/HTMLMediaElementDuration.generated.xml' path='docs/HTMLMediaElementDuration/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public double Duration { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public object GetStartDate() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLMediaElementPaused/HTMLMediaElementPaused.generated.xml' path='docs/HTMLMediaElementPaused/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Paused { get; }
	///<include file='Utils/Docs/HTMLMediaElementDefaultPlaybackRate/HTMLMediaElementDefaultPlaybackRate.generated.xml' path='docs/HTMLMediaElementDefaultPlaybackRate/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Number DefaultPlaybackRate { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementPlaybackRate/HTMLMediaElementPlaybackRate.generated.xml' path='docs/HTMLMediaElementPlaybackRate/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Number PlaybackRate { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementPreservesPitch/HTMLMediaElementPreservesPitch.generated.xml' path='docs/HTMLMediaElementPreservesPitch/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool PreservesPitch { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public TimeRanges Played { get; }
	///<include file='Utils/Docs/HTMLMediaElementSeekable/HTMLMediaElementSeekable.generated.xml' path='docs/HTMLMediaElementSeekable/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public TimeRanges Seekable { get; }
	///<include file='Utils/Docs/HTMLMediaElementEnded/HTMLMediaElementEnded.generated.xml' path='docs/HTMLMediaElementEnded/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Ended { get; }
	///<include file='Utils/Docs/HTMLMediaElementAutoplay/HTMLMediaElementAutoplay.generated.xml' path='docs/HTMLMediaElementAutoplay/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Autoplay { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementLoop/HTMLMediaElementLoop.generated.xml' path='docs/HTMLMediaElementLoop/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Loop { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementPlay/HTMLMediaElementPlay.generated.xml' path='docs/HTMLMediaElementPlay/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Task<Undefined> Play() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLMediaElementPause/HTMLMediaElementPause.generated.xml' path='docs/HTMLMediaElementPause/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Pause() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLMediaElementControls/HTMLMediaElementControls.generated.xml' path='docs/HTMLMediaElementControls/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Controls { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementVolume/HTMLMediaElementVolume.generated.xml' path='docs/HTMLMediaElementVolume/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Number Volume { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementMuted/HTMLMediaElementMuted.generated.xml' path='docs/HTMLMediaElementMuted/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Muted { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementDefaultMuted/HTMLMediaElementDefaultMuted.generated.xml' path='docs/HTMLMediaElementDefaultMuted/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool DefaultMuted { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementAudioTracks/HTMLMediaElementAudioTracks.generated.xml' path='docs/HTMLMediaElementAudioTracks/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public AudioTrackList AudioTracks { get; }
	///<include file='Utils/Docs/HTMLMediaElementVideoTracks/HTMLMediaElementVideoTracks.generated.xml' path='docs/HTMLMediaElementVideoTracks/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public VideoTrackList VideoTracks { get; }
	///<include file='Utils/Docs/HTMLMediaElementTextTracks/HTMLMediaElementTextTracks.generated.xml' path='docs/HTMLMediaElementTextTracks/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrackList TextTracks { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrack AddTextTrack(TextTrackKind kind, string label, string language) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/MediaError/MediaError.generated.xml' path='docs/MediaError/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaError
{
		public const ushort MEDIA_ERR_ABORTED = 1;
		public const ushort MEDIA_ERR_NETWORK = 2;
		public const ushort MEDIA_ERR_DECODE = 3;
		public const ushort MEDIA_ERR_SRC_NOT_SUPPORTED = 4;
	///<include file='Utils/Docs/MediaErrorCode/MediaErrorCode.generated.xml' path='docs/MediaErrorCode/*'/>
	public ushort Code { get; }
	///<include file='Utils/Docs/MediaErrorMessage/MediaErrorMessage.generated.xml' path='docs/MediaErrorMessage/*'/>
	public string Message { get; }
}

///<include file='Utils/Docs/AudioTrackList/AudioTrackList.generated.xml' path='docs/AudioTrackList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioTrackList : EventTarget
{
	///<include file='Utils/Docs/AudioTrackListLength/AudioTrackListLength.generated.xml' path='docs/AudioTrackListLength/*'/>
	public ulong Length { get; }
	
	///<include file='Utils/Docs/AudioTrackListGetTrackById/AudioTrackListGetTrackById.generated.xml' path='docs/AudioTrackListGetTrackById/*'/>
	public AudioTrack? GetTrackById(string id) { throw new System.NotImplementedException(); }
		public EventHandler Onchange { get; set; }
		public EventHandler Onaddtrack { get; set; }
		public EventHandler Onremovetrack { get; set; }
}

///<include file='Utils/Docs/AudioTrack/AudioTrack.generated.xml' path='docs/AudioTrack/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioTrack
{
	///<include file='Utils/Docs/AudioTrackId/AudioTrackId.generated.xml' path='docs/AudioTrackId/*'/>
	public string Id { get; }
	///<include file='Utils/Docs/AudioTrackKind/AudioTrackKind.generated.xml' path='docs/AudioTrackKind/*'/>
	public string Kind { get; }
	///<include file='Utils/Docs/AudioTrackLabel/AudioTrackLabel.generated.xml' path='docs/AudioTrackLabel/*'/>
	public string Label { get; }
	///<include file='Utils/Docs/AudioTrackLanguage/AudioTrackLanguage.generated.xml' path='docs/AudioTrackLanguage/*'/>
	public string Language { get; }
	///<include file='Utils/Docs/AudioTrackEnabled/AudioTrackEnabled.generated.xml' path='docs/AudioTrackEnabled/*'/>
	public bool Enabled { get; set; }
}

///<include file='Utils/Docs/VideoTrackList/VideoTrackList.generated.xml' path='docs/VideoTrackList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoTrackList : EventTarget
{
	///<include file='Utils/Docs/VideoTrackListLength/VideoTrackListLength.generated.xml' path='docs/VideoTrackListLength/*'/>
	public ulong Length { get; }
	
	///<include file='Utils/Docs/VideoTrackListGetTrackById/VideoTrackListGetTrackById.generated.xml' path='docs/VideoTrackListGetTrackById/*'/>
	public VideoTrack? GetTrackById(string id) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/VideoTrackListSelectedIndex/VideoTrackListSelectedIndex.generated.xml' path='docs/VideoTrackListSelectedIndex/*'/>
	public long SelectedIndex { get; }
		public EventHandler Onchange { get; set; }
		public EventHandler Onaddtrack { get; set; }
		public EventHandler Onremovetrack { get; set; }
}

///<include file='Utils/Docs/VideoTrack/VideoTrack.generated.xml' path='docs/VideoTrack/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoTrack
{
	///<include file='Utils/Docs/VideoTrackId/VideoTrackId.generated.xml' path='docs/VideoTrackId/*'/>
	public string Id { get; }
	///<include file='Utils/Docs/VideoTrackKind/VideoTrackKind.generated.xml' path='docs/VideoTrackKind/*'/>
	public string Kind { get; }
	///<include file='Utils/Docs/VideoTrackLabel/VideoTrackLabel.generated.xml' path='docs/VideoTrackLabel/*'/>
	public string Label { get; }
	///<include file='Utils/Docs/VideoTrackLanguage/VideoTrackLanguage.generated.xml' path='docs/VideoTrackLanguage/*'/>
	public string Language { get; }
	///<include file='Utils/Docs/VideoTrackSelected/VideoTrackSelected.generated.xml' path='docs/VideoTrackSelected/*'/>
	public bool Selected { get; set; }
}

///<include file='Utils/Docs/TextTrackList/TextTrackList.generated.xml' path='docs/TextTrackList/*'/>
[To(ToAttribute.Default)]
public partial class TextTrackList : EventTarget
{
	///<include file='Utils/Docs/TextTrackListLength/TextTrackListLength.generated.xml' path='docs/TextTrackListLength/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Length { get; }
	
	///<include file='Utils/Docs/TextTrackListGetTrackById/TextTrackListGetTrackById.generated.xml' path='docs/TextTrackListGetTrackById/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrack? GetTrackById(string id) { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onchange { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onaddtrack { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onremovetrack { get; set; }
}

///<include file='Utils/Docs/TextTrackMode/TextTrackMode.generated.xml' path='docs/TextTrackMode/*'/>
public enum TextTrackMode
{
	Disabled,
	Hidden,
	Showing,
}

///<include file='Utils/Docs/TextTrackKind/TextTrackKind.generated.xml' path='docs/TextTrackKind/*'/>
public enum TextTrackKind
{
	Subtitles,
	Captions,
	Descriptions,
	Chapters,
	Metadata,
}

///<include file='Utils/Docs/TextTrack/TextTrack.generated.xml' path='docs/TextTrack/*'/>
[To(ToAttribute.Default)]
public partial class TextTrack : EventTarget
{
	///<include file='Utils/Docs/TextTrackKind/TextTrackKind.generated.xml' path='docs/TextTrackKind/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrackKind Kind { get; }
	///<include file='Utils/Docs/TextTrackLabel/TextTrackLabel.generated.xml' path='docs/TextTrackLabel/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Label { get; }
	///<include file='Utils/Docs/TextTrackLanguage/TextTrackLanguage.generated.xml' path='docs/TextTrackLanguage/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Language { get; }
	///<include file='Utils/Docs/TextTrackId/TextTrackId.generated.xml' path='docs/TextTrackId/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Id { get; }
	///<include file='Utils/Docs/TextTrackInBandMetadataTrackDispatchType/TextTrackInBandMetadataTrackDispatchType.generated.xml' path='docs/TextTrackInBandMetadataTrackDispatchType/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string InBandMetadataTrackDispatchType { get; }
	///<include file='Utils/Docs/TextTrackMode/TextTrackMode.generated.xml' path='docs/TextTrackMode/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrackMode Mode { get; set; }
	///<include file='Utils/Docs/TextTrackCues/TextTrackCues.generated.xml' path='docs/TextTrackCues/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrackCueList? Cues { get; }
	///<include file='Utils/Docs/TextTrackActiveCues/TextTrackActiveCues.generated.xml' path='docs/TextTrackActiveCues/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrackCueList? ActiveCues { get; }
	///<include file='Utils/Docs/TextTrackAddCue/TextTrackAddCue.generated.xml' path='docs/TextTrackAddCue/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined AddCue(TextTrackCue cue) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TextTrackRemoveCue/TextTrackRemoveCue.generated.xml' path='docs/TextTrackRemoveCue/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined RemoveCue(TextTrackCue cue) { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Oncuechange { get; set; }
}

///<include file='Utils/Docs/TextTrackCueList/TextTrackCueList.generated.xml' path='docs/TextTrackCueList/*'/>
[To(ToAttribute.Default)]
public partial class TextTrackCueList
{
	///<include file='Utils/Docs/TextTrackCueListLength/TextTrackCueListLength.generated.xml' path='docs/TextTrackCueListLength/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Length { get; }
	
	///<include file='Utils/Docs/TextTrackCueListGetCueById/TextTrackCueListGetCueById.generated.xml' path='docs/TextTrackCueListGetCueById/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrackCue? GetCueById(string id) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/TextTrackCue/TextTrackCue.generated.xml' path='docs/TextTrackCue/*'/>
[To(ToAttribute.Default)]
public partial class TextTrackCue : EventTarget
{
	///<include file='Utils/Docs/TextTrackCueTrack/TextTrackCueTrack.generated.xml' path='docs/TextTrackCueTrack/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrack? Track { get; }
	///<include file='Utils/Docs/TextTrackCueId/TextTrackCueId.generated.xml' path='docs/TextTrackCueId/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Id { get; set; }
	///<include file='Utils/Docs/TextTrackCueStartTime/TextTrackCueStartTime.generated.xml' path='docs/TextTrackCueStartTime/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Number StartTime { get; set; }
	///<include file='Utils/Docs/TextTrackCueEndTime/TextTrackCueEndTime.generated.xml' path='docs/TextTrackCueEndTime/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public double EndTime { get; set; }
	///<include file='Utils/Docs/TextTrackCuePauseOnExit/TextTrackCuePauseOnExit.generated.xml' path='docs/TextTrackCuePauseOnExit/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool PauseOnExit { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onenter { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onexit { get; set; }
}

///<include file='Utils/Docs/TimeRanges/TimeRanges.generated.xml' path='docs/TimeRanges/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class TimeRanges
{
	///<include file='Utils/Docs/TimeRangesLength/TimeRangesLength.generated.xml' path='docs/TimeRangesLength/*'/>
	public ulong Length { get; }
	///<include file='Utils/Docs/TimeRangesStart/TimeRangesStart.generated.xml' path='docs/TimeRangesStart/*'/>
	public Number Start(ulong index) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TimeRangesEnd/TimeRangesEnd.generated.xml' path='docs/TimeRangesEnd/*'/>
	public Number End(ulong index) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/TrackEvent/TrackEvent.generated.xml' path='docs/TrackEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class TrackEvent : Event
{
	///<include file='Utils/Docs/TrackEventTrackEvent/TrackEventTrackEvent.generated.xml' path='docs/TrackEventTrackEvent/*'/>
	public TrackEvent(string type, TrackEventInit eventInitDict) { }
	///<include file='Utils/Docs/TrackEventTrack/TrackEventTrack.generated.xml' path='docs/TrackEventTrack/*'/>
	public Union8? Track { get; }
	public TrackEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class TrackEventInit : EventInit
{
		public Union9? Track;
}

///<include file='Utils/Docs/HTMLMapElement/HTMLMapElement.generated.xml' path='docs/HTMLMapElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLMapElement : HTMLElement
{
		public HTMLMapElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection Areas { get; }
}

///<include file='Utils/Docs/HTMLAreaElement/HTMLAreaElement.generated.xml' path='docs/HTMLAreaElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLAreaElement : HTMLElement, HTMLHyperlinkElementUtils
{
		public HTMLAreaElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Alt { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Coords { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Shape { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Target { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Download { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Ping { get; set; }
	///<include file='Utils/Docs/HTMLAreaElementRel/HTMLAreaElementRel.generated.xml' path='docs/HTMLAreaElementRel/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Rel { get; set; }
	///<include file='Utils/Docs/HTMLAreaElementRelList/HTMLAreaElementRelList.generated.xml' path='docs/HTMLAreaElementRelList/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList RelList { get; }
	///<include file='Utils/Docs/HTMLAreaElementReferrerPolicy/HTMLAreaElementReferrerPolicy.generated.xml' path='docs/HTMLAreaElementReferrerPolicy/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string ReferrerPolicy { get; set; }
}


///<include file='Utils/Docs/HTMLTableElement/HTMLTableElement.generated.xml' path='docs/HTMLTableElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTableElement : HTMLElement
{
		public HTMLTableElement() { }
	///<include file='Utils/Docs/HTMLTableElementCaption/HTMLTableElementCaption.generated.xml' path='docs/HTMLTableElementCaption/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableCaptionElement? Caption { get; set; }
	///<include file='Utils/Docs/HTMLTableElementCreateCaption/HTMLTableElementCreateCaption.generated.xml' path='docs/HTMLTableElementCreateCaption/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableCaptionElement CreateCaption() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTableElementDeleteCaption/HTMLTableElementDeleteCaption.generated.xml' path='docs/HTMLTableElementDeleteCaption/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined DeleteCaption() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTableElementTHead/HTMLTableElementTHead.generated.xml' path='docs/HTMLTableElementTHead/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableSectionElement? THead { get; set; }
	///<include file='Utils/Docs/HTMLTableElementCreateTHead/HTMLTableElementCreateTHead.generated.xml' path='docs/HTMLTableElementCreateTHead/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableSectionElement CreateTHead() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTableElementDeleteTHead/HTMLTableElementDeleteTHead.generated.xml' path='docs/HTMLTableElementDeleteTHead/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined DeleteTHead() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTableElementTFoot/HTMLTableElementTFoot.generated.xml' path='docs/HTMLTableElementTFoot/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableSectionElement? TFoot { get; set; }
	///<include file='Utils/Docs/HTMLTableElementCreateTFoot/HTMLTableElementCreateTFoot.generated.xml' path='docs/HTMLTableElementCreateTFoot/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableSectionElement CreateTFoot() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTableElementDeleteTFoot/HTMLTableElementDeleteTFoot.generated.xml' path='docs/HTMLTableElementDeleteTFoot/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined DeleteTFoot() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTableElementTBodies/HTMLTableElementTBodies.generated.xml' path='docs/HTMLTableElementTBodies/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection TBodies { get; }
	///<include file='Utils/Docs/HTMLTableElementCreateTBody/HTMLTableElementCreateTBody.generated.xml' path='docs/HTMLTableElementCreateTBody/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableSectionElement CreateTBody() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTableElementRows/HTMLTableElementRows.generated.xml' path='docs/HTMLTableElementRows/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection Rows { get; }
	///<include file='Utils/Docs/HTMLTableElementInsertRow/HTMLTableElementInsertRow.generated.xml' path='docs/HTMLTableElementInsertRow/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableRowElement InsertRow(long index) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTableElementDeleteRow/HTMLTableElementDeleteRow.generated.xml' path='docs/HTMLTableElementDeleteRow/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined DeleteRow(long index) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLTableCaptionElement/HTMLTableCaptionElement.generated.xml' path='docs/HTMLTableCaptionElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTableCaptionElement : HTMLElement
{
		public HTMLTableCaptionElement() { }
}

///<include file='Utils/Docs/HTMLTableColElement/HTMLTableColElement.generated.xml' path='docs/HTMLTableColElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTableColElement : HTMLElement
{
		public HTMLTableColElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Span { get; set; }
}

///<include file='Utils/Docs/HTMLTableSectionElement/HTMLTableSectionElement.generated.xml' path='docs/HTMLTableSectionElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTableSectionElement : HTMLElement
{
		public HTMLTableSectionElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection Rows { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableRowElement InsertRow(long index) { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined DeleteRow(long index) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLTableRowElement/HTMLTableRowElement.generated.xml' path='docs/HTMLTableRowElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTableRowElement : HTMLElement
{
		public HTMLTableRowElement() { }
	///<include file='Utils/Docs/HTMLTableRowElementRowIndex/HTMLTableRowElementRowIndex.generated.xml' path='docs/HTMLTableRowElementRowIndex/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public long RowIndex { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public long SectionRowIndex { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection Cells { get; }
	///<include file='Utils/Docs/HTMLTableRowElementInsertCell/HTMLTableRowElementInsertCell.generated.xml' path='docs/HTMLTableRowElementInsertCell/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableCellElement InsertCell(long index) { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined DeleteCell(long index) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLTableCellElement/HTMLTableCellElement.generated.xml' path='docs/HTMLTableCellElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTableCellElement : HTMLElement
{
		public HTMLTableCellElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong ColSpan { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong RowSpan { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Headers { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public long CellIndex { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Scope { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Abbr { get; set; }
}

///<include file='Utils/Docs/HTMLFormElement/HTMLFormElement.generated.xml' path='docs/HTMLFormElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLFormElement : HTMLElement
{
		public HTMLFormElement() { }
	///<include file='Utils/Docs/HTMLFormElementAcceptCharset/HTMLFormElementAcceptCharset.generated.xml' path='docs/HTMLFormElementAcceptCharset/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string AcceptCharset { get; set; }
	///<include file='Utils/Docs/HTMLFormElementAction/HTMLFormElementAction.generated.xml' path='docs/HTMLFormElementAction/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Action { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Autocomplete { get; set; }
	///<include file='Utils/Docs/HTMLFormElementEnctype/HTMLFormElementEnctype.generated.xml' path='docs/HTMLFormElementEnctype/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Enctype { get; set; }
	///<include file='Utils/Docs/HTMLFormElementEncoding/HTMLFormElementEncoding.generated.xml' path='docs/HTMLFormElementEncoding/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Encoding { get; set; }
	///<include file='Utils/Docs/HTMLFormElementMethod/HTMLFormElementMethod.generated.xml' path='docs/HTMLFormElementMethod/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Method { get; set; }
	///<include file='Utils/Docs/HTMLFormElementName/HTMLFormElementName.generated.xml' path='docs/HTMLFormElementName/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool NoValidate { get; set; }
	///<include file='Utils/Docs/HTMLFormElementTarget/HTMLFormElementTarget.generated.xml' path='docs/HTMLFormElementTarget/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Target { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Rel { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList RelList { get; }
	///<include file='Utils/Docs/HTMLFormElementElements/HTMLFormElementElements.generated.xml' path='docs/HTMLFormElementElements/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormControlsCollection Elements { get; }
	///<include file='Utils/Docs/HTMLFormElementLength/HTMLFormElementLength.generated.xml' path='docs/HTMLFormElementLength/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Length { get; }
	
	
	///<include file='Utils/Docs/HTMLFormElementSubmit/HTMLFormElementSubmit.generated.xml' path='docs/HTMLFormElementSubmit/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Submit() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLFormElementRequestSubmit/HTMLFormElementRequestSubmit.generated.xml' path='docs/HTMLFormElementRequestSubmit/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined RequestSubmit(HTMLElement? submitter) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLFormElementReset/HTMLFormElementReset.generated.xml' path='docs/HTMLFormElementReset/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Reset() { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLFormElementReportValidity/HTMLFormElementReportValidity.generated.xml' path='docs/HTMLFormElementReportValidity/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLLabelElement/HTMLLabelElement.generated.xml' path='docs/HTMLLabelElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLLabelElement : HTMLElement
{
		public HTMLLabelElement() { }
	///<include file='Utils/Docs/HTMLLabelElementForm/HTMLLabelElementForm.generated.xml' path='docs/HTMLLabelElementForm/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	///<include file='Utils/Docs/HTMLLabelElementHtmlFor/HTMLLabelElementHtmlFor.generated.xml' path='docs/HTMLLabelElementHtmlFor/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string HtmlFor { get; set; }
	///<include file='Utils/Docs/HTMLLabelElementControl/HTMLLabelElementControl.generated.xml' path='docs/HTMLLabelElementControl/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLElement? Control { get; }
}

///<include file='Utils/Docs/HTMLInputElement/HTMLInputElement.generated.xml' path='docs/HTMLInputElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLInputElement : HTMLElement, PopoverInvokerElement
{
		public HTMLInputElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Accept { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Alt { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Autocomplete { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool DefaultChecked { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Checked { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string DirName { get; set; }
	///<include file='Utils/Docs/HTMLInputElementDisabled/HTMLInputElementDisabled.generated.xml' path='docs/HTMLInputElementDisabled/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	///<include file='Utils/Docs/HTMLInputElementFiles/HTMLInputElementFiles.generated.xml' path='docs/HTMLInputElementFiles/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public FileList? Files { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string FormAction { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string FormEnctype { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string FormMethod { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool FormNoValidate { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string FormTarget { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Height { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Indeterminate { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLDataListElement? List { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Max { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public long MaxLength { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Min { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public long MinLength { get; set; }
	///<include file='Utils/Docs/HTMLInputElementMultiple/HTMLInputElementMultiple.generated.xml' path='docs/HTMLInputElementMultiple/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Multiple { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Pattern { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Placeholder { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReadOnly { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Required { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Size { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Step { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string DefaultValue { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public object? ValueAsDate { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public double ValueAsNumber { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Width { get; set; }
	///<include file='Utils/Docs/HTMLInputElementStepUp/HTMLInputElementStepUp.generated.xml' path='docs/HTMLInputElementStepUp/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined StepUp(long n) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLInputElementStepDown/HTMLInputElementStepDown.generated.xml' path='docs/HTMLInputElementStepDown/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined StepDown(long n) { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
	///<include file='Utils/Docs/HTMLInputElementCheckValidity/HTMLInputElementCheckValidity.generated.xml' path='docs/HTMLInputElementCheckValidity/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLInputElementReportValidity/HTMLInputElementReportValidity.generated.xml' path='docs/HTMLInputElementReportValidity/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLInputElementSetCustomValidity/HTMLInputElementSetCustomValidity.generated.xml' path='docs/HTMLInputElementSetCustomValidity/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetCustomValidity(string error) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLInputElementLabels/HTMLInputElementLabels.generated.xml' path='docs/HTMLInputElementLabels/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public NodeList? Labels { get; }
	///<include file='Utils/Docs/HTMLInputElementSelect/HTMLInputElementSelect.generated.xml' path='docs/HTMLInputElementSelect/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Select() { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong? SelectionStart { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong? SelectionEnd { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string? SelectionDirection { get; set; }
	///<include file='Utils/Docs/HTMLInputElementSetRangeText/HTMLInputElementSetRangeText.generated.xml' path='docs/HTMLInputElementSetRangeText/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetRangeText(string replacement) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLInputElementSetRangeText/HTMLInputElementSetRangeText.generated.xml' path='docs/HTMLInputElementSetRangeText/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetRangeText(string replacement, ulong start, ulong end, SelectionMode selectionMode) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLInputElementSetSelectionRange/HTMLInputElementSetSelectionRange.generated.xml' path='docs/HTMLInputElementSetSelectionRange/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetSelectionRange(ulong start, ulong end, string direction) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLInputElementShowPicker/HTMLInputElementShowPicker.generated.xml' path='docs/HTMLInputElementShowPicker/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined ShowPicker() { throw new System.NotImplementedException(); }
}


///<include file='Utils/Docs/HTMLButtonElement/HTMLButtonElement.generated.xml' path='docs/HTMLButtonElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLButtonElement : HTMLElement, PopoverInvokerElement
{
		public HTMLButtonElement() { }
	///<include file='Utils/Docs/HTMLButtonElementDisabled/HTMLButtonElementDisabled.generated.xml' path='docs/HTMLButtonElementDisabled/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string FormAction { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string FormEnctype { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string FormMethod { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool FormNoValidate { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string FormTarget { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetCustomValidity(string error) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLButtonElementLabels/HTMLButtonElementLabels.generated.xml' path='docs/HTMLButtonElementLabels/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public NodeList Labels { get; }
}


///<include file='Utils/Docs/HTMLSelectElement/HTMLSelectElement.generated.xml' path='docs/HTMLSelectElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLSelectElement : HTMLElement
{
		public HTMLSelectElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Autocomplete { get; set; }
	///<include file='Utils/Docs/HTMLSelectElementDisabled/HTMLSelectElementDisabled.generated.xml' path='docs/HTMLSelectElementDisabled/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	///<include file='Utils/Docs/HTMLSelectElementForm/HTMLSelectElementForm.generated.xml' path='docs/HTMLSelectElementForm/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Multiple { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Required { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Size { get; set; }
	///<include file='Utils/Docs/HTMLSelectElementType/HTMLSelectElementType.generated.xml' path='docs/HTMLSelectElementType/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; }
	///<include file='Utils/Docs/HTMLSelectElementOptions/HTMLSelectElementOptions.generated.xml' path='docs/HTMLSelectElementOptions/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLOptionsCollection Options { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Length { get; set; }
	
	///<include file='Utils/Docs/HTMLSelectElementNamedItem/HTMLSelectElementNamedItem.generated.xml' path='docs/HTMLSelectElementNamedItem/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLOptionElement? NamedItem(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLSelectElementAdd/HTMLSelectElementAdd.generated.xml' path='docs/HTMLSelectElementAdd/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Add(Union11 element, Union12? before) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLSelectElementRemove/HTMLSelectElementRemove.generated.xml' path='docs/HTMLSelectElementRemove/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Remove() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLSelectElementRemove/HTMLSelectElementRemove.generated.xml' path='docs/HTMLSelectElementRemove/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Remove(long index) { throw new System.NotImplementedException(); }
	
	///<include file='Utils/Docs/HTMLSelectElementSelectedOptions/HTMLSelectElementSelectedOptions.generated.xml' path='docs/HTMLSelectElementSelectedOptions/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection SelectedOptions { get; }
	///<include file='Utils/Docs/HTMLSelectElementSelectedIndex/HTMLSelectElementSelectedIndex.generated.xml' path='docs/HTMLSelectElementSelectedIndex/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public long SelectedIndex { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
	///<include file='Utils/Docs/HTMLSelectElementCheckValidity/HTMLSelectElementCheckValidity.generated.xml' path='docs/HTMLSelectElementCheckValidity/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLSelectElementSetCustomValidity/HTMLSelectElementSetCustomValidity.generated.xml' path='docs/HTMLSelectElementSetCustomValidity/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetCustomValidity(string error) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLSelectElementLabels/HTMLSelectElementLabels.generated.xml' path='docs/HTMLSelectElementLabels/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public NodeList Labels { get; }
}

///<include file='Utils/Docs/HTMLDataListElement/HTMLDataListElement.generated.xml' path='docs/HTMLDataListElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLDataListElement : HTMLElement
{
		public HTMLDataListElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection Options { get; }
}

///<include file='Utils/Docs/HTMLOptGroupElement/HTMLOptGroupElement.generated.xml' path='docs/HTMLOptGroupElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLOptGroupElement : HTMLElement
{
		public HTMLOptGroupElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Label { get; set; }
}

///<include file='Utils/Docs/HTMLOptionElement/HTMLOptionElement.generated.xml' path='docs/HTMLOptionElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLOptionElement : HTMLElement
{
		public HTMLOptionElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Label { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool DefaultSelected { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Selected { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Text { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public long Index { get; }
}

///<include file='Utils/Docs/HTMLTextAreaElement/HTMLTextAreaElement.generated.xml' path='docs/HTMLTextAreaElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTextAreaElement : HTMLElement
{
		public HTMLTextAreaElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Autocomplete { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Cols { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string DirName { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public long MaxLength { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public long MinLength { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Placeholder { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReadOnly { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Required { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Rows { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Wrap { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string DefaultValue { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong TextLength { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetCustomValidity(string error) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTextAreaElementLabels/HTMLTextAreaElementLabels.generated.xml' path='docs/HTMLTextAreaElementLabels/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public NodeList Labels { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Select() { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong SelectionStart { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong SelectionEnd { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string SelectionDirection { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetRangeText(string replacement) { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetRangeText(string replacement, ulong start, ulong end, SelectionMode selectionMode) { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetSelectionRange(ulong start, ulong end, string direction) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLOutputElement/HTMLOutputElement.generated.xml' path='docs/HTMLOutputElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLOutputElement : HTMLElement
{
		public HTMLOutputElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList HtmlFor { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string DefaultValue { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetCustomValidity(string error) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLOutputElementLabels/HTMLOutputElementLabels.generated.xml' path='docs/HTMLOutputElementLabels/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public NodeList Labels { get; }
}

///<include file='Utils/Docs/HTMLProgressElement/HTMLProgressElement.generated.xml' path='docs/HTMLProgressElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLProgressElement : HTMLElement
{
		public HTMLProgressElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Number Value { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Number Max { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Number Position { get; }
	///<include file='Utils/Docs/HTMLProgressElementLabels/HTMLProgressElementLabels.generated.xml' path='docs/HTMLProgressElementLabels/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public NodeList Labels { get; }
}

///<include file='Utils/Docs/HTMLMeterElement/HTMLMeterElement.generated.xml' path='docs/HTMLMeterElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLMeterElement : HTMLElement
{
		public HTMLMeterElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Number Value { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Number Min { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Number Max { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Number Low { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Number High { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Number Optimum { get; set; }
	///<include file='Utils/Docs/HTMLMeterElementLabels/HTMLMeterElementLabels.generated.xml' path='docs/HTMLMeterElementLabels/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public NodeList Labels { get; }
}

///<include file='Utils/Docs/HTMLFieldSetElement/HTMLFieldSetElement.generated.xml' path='docs/HTMLFieldSetElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLFieldSetElement : HTMLElement
{
		public HTMLFieldSetElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection Elements { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetCustomValidity(string error) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLLegendElement/HTMLLegendElement.generated.xml' path='docs/HTMLLegendElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLLegendElement : HTMLElement
{
		public HTMLLegendElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
}

public enum SelectionMode
{
	Select,
	Start,
	End,
	Preserve,
}

///<include file='Utils/Docs/ValidityState/ValidityState.generated.xml' path='docs/ValidityState/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ValidityState
{
	///<include file='Utils/Docs/ValidityStateValueMissing/ValidityStateValueMissing.generated.xml' path='docs/ValidityStateValueMissing/*'/>
	public bool ValueMissing { get; }
	///<include file='Utils/Docs/ValidityStateTypeMismatch/ValidityStateTypeMismatch.generated.xml' path='docs/ValidityStateTypeMismatch/*'/>
	public bool TypeMismatch { get; }
	///<include file='Utils/Docs/ValidityStatePatternMismatch/ValidityStatePatternMismatch.generated.xml' path='docs/ValidityStatePatternMismatch/*'/>
	public bool PatternMismatch { get; }
	///<include file='Utils/Docs/ValidityStateTooLong/ValidityStateTooLong.generated.xml' path='docs/ValidityStateTooLong/*'/>
	public bool TooLong { get; }
	///<include file='Utils/Docs/ValidityStateTooShort/ValidityStateTooShort.generated.xml' path='docs/ValidityStateTooShort/*'/>
	public bool TooShort { get; }
	///<include file='Utils/Docs/ValidityStateRangeUnderflow/ValidityStateRangeUnderflow.generated.xml' path='docs/ValidityStateRangeUnderflow/*'/>
	public bool RangeUnderflow { get; }
	///<include file='Utils/Docs/ValidityStateRangeOverflow/ValidityStateRangeOverflow.generated.xml' path='docs/ValidityStateRangeOverflow/*'/>
	public bool RangeOverflow { get; }
	///<include file='Utils/Docs/ValidityStateStepMismatch/ValidityStateStepMismatch.generated.xml' path='docs/ValidityStateStepMismatch/*'/>
	public bool StepMismatch { get; }
	///<include file='Utils/Docs/ValidityStateBadInput/ValidityStateBadInput.generated.xml' path='docs/ValidityStateBadInput/*'/>
	public bool BadInput { get; }
		public bool CustomError { get; }
		public bool Valid { get; }
}

///<include file='Utils/Docs/SubmitEvent/SubmitEvent.generated.xml' path='docs/SubmitEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SubmitEvent : Event
{
	///<include file='Utils/Docs/SubmitEventSubmitEvent/SubmitEventSubmitEvent.generated.xml' path='docs/SubmitEventSubmitEvent/*'/>
	public SubmitEvent(string type, SubmitEventInit eventInitDict) { }
	///<include file='Utils/Docs/SubmitEventSubmitter/SubmitEventSubmitter.generated.xml' path='docs/SubmitEventSubmitter/*'/>
	public HTMLElement? Submitter { get; }
	public SubmitEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class SubmitEventInit : EventInit
{
		public HTMLElement? Submitter;
}

///<include file='Utils/Docs/FormDataEvent/FormDataEvent.generated.xml' path='docs/FormDataEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FormDataEvent : Event
{
	///<include file='Utils/Docs/FormDataEventFormDataEvent/FormDataEventFormDataEvent.generated.xml' path='docs/FormDataEventFormDataEvent/*'/>
	public FormDataEvent(string type, FormDataEventInit eventInitDict) { }
	///<include file='Utils/Docs/FormDataEventFormData/FormDataEventFormData.generated.xml' path='docs/FormDataEventFormData/*'/>
	public FormData FormData { get; }
	public FormDataEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FormDataEventInit : EventInit
{
		public required FormData FormData;
}

///<include file='Utils/Docs/HTMLDetailsElement/HTMLDetailsElement.generated.xml' path='docs/HTMLDetailsElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLDetailsElement : HTMLElement
{
		public HTMLDetailsElement() { }
	///<include file='Utils/Docs/HTMLDetailsElementOpen/HTMLDetailsElementOpen.generated.xml' path='docs/HTMLDetailsElementOpen/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Open { get; set; }
}

///<include file='Utils/Docs/HTMLDialogElement/HTMLDialogElement.generated.xml' path='docs/HTMLDialogElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLDialogElement : HTMLElement
{
		public HTMLDialogElement() { }
	///<include file='Utils/Docs/HTMLDialogElementOpen/HTMLDialogElementOpen.generated.xml' path='docs/HTMLDialogElementOpen/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Open { get; set; }
	///<include file='Utils/Docs/HTMLDialogElementReturnValue/HTMLDialogElementReturnValue.generated.xml' path='docs/HTMLDialogElementReturnValue/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string ReturnValue { get; set; }
	///<include file='Utils/Docs/HTMLDialogElementShow/HTMLDialogElementShow.generated.xml' path='docs/HTMLDialogElementShow/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Show() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLDialogElementShowModal/HTMLDialogElementShowModal.generated.xml' path='docs/HTMLDialogElementShowModal/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined ShowModal() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLDialogElementClose/HTMLDialogElementClose.generated.xml' path='docs/HTMLDialogElementClose/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Close(string returnValue) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLScriptElement/HTMLScriptElement.generated.xml' path='docs/HTMLScriptElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLScriptElement : HTMLElement
{
		public HTMLScriptElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool NoModule { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Async { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Defer { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string? CrossOrigin { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Text { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Integrity { get; set; }
	///<include file='Utils/Docs/HTMLScriptElementReferrerPolicy/HTMLScriptElementReferrerPolicy.generated.xml' path='docs/HTMLScriptElementReferrerPolicy/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string ReferrerPolicy { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList Blocking { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string FetchPriority { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public static bool Supports(string type) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLTemplateElement/HTMLTemplateElement.generated.xml' path='docs/HTMLTemplateElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTemplateElement : HTMLElement
{
		public HTMLTemplateElement() { }
	///<include file='Utils/Docs/HTMLTemplateElementContent/HTMLTemplateElementContent.generated.xml' path='docs/HTMLTemplateElementContent/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public DocumentFragment Content { get; }
}

///<include file='Utils/Docs/HTMLSlotElement/HTMLSlotElement.generated.xml' path='docs/HTMLSlotElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLSlotElement : HTMLElement
{
		public HTMLSlotElement() { }
	///<include file='Utils/Docs/HTMLSlotElementName/HTMLSlotElementName.generated.xml' path='docs/HTMLSlotElementName/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	///<include file='Utils/Docs/HTMLSlotElementAssignedNodes/HTMLSlotElementAssignedNodes.generated.xml' path='docs/HTMLSlotElementAssignedNodes/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public List<Node> AssignedNodes(AssignedNodesOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLSlotElementAssignedElements/HTMLSlotElementAssignedElements.generated.xml' path='docs/HTMLSlotElementAssignedElements/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public List<Element> AssignedElements(AssignedNodesOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLSlotElementAssign/HTMLSlotElementAssign.generated.xml' path='docs/HTMLSlotElementAssign/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Assign(params Union13[] nodes) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AssignedNodesOptions
{
		public bool Flatten;
}


///<include file='Utils/Docs/HTMLCanvasElement/HTMLCanvasElement.generated.xml' path='docs/HTMLCanvasElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLCanvasElement : HTMLElement
{
		public HTMLCanvasElement() { }
	///<include file='Utils/Docs/HTMLCanvasElementWidth/HTMLCanvasElementWidth.generated.xml' path='docs/HTMLCanvasElementWidth/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Width { get; set; }
	///<include file='Utils/Docs/HTMLCanvasElementHeight/HTMLCanvasElementHeight.generated.xml' path='docs/HTMLCanvasElementHeight/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Height { get; set; }
	///<include file='Utils/Docs/HTMLCanvasElementGetContext/HTMLCanvasElementGetContext.generated.xml' path='docs/HTMLCanvasElementGetContext/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public RenderingContext? GetContext(string contextId, dynamic options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLCanvasElementToDataURL/HTMLCanvasElementToDataURL.generated.xml' path='docs/HTMLCanvasElementToDataURL/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string ToDataURL(string type, dynamic quality) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLCanvasElementToBlob/HTMLCanvasElementToBlob.generated.xml' path='docs/HTMLCanvasElementToBlob/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined ToBlob(BlobCallback callback, string type, dynamic quality) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLCanvasElementTransferControlToOffscreen/HTMLCanvasElementTransferControlToOffscreen.generated.xml' path='docs/HTMLCanvasElementTransferControlToOffscreen/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public OffscreenCanvas TransferControlToOffscreen() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct BlobCallback
{
}



public enum PredefinedColorSpace
{
	Srgb,
	DisplayP3,
}

public enum CanvasFillRule
{
	Nonzero,
	Evenodd,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CanvasRenderingContext2DSettings
{
		public bool Alpha;
		public bool Desynchronized;
		public PredefinedColorSpace ColorSpace;
		public bool WillReadFrequently;
}

public enum ImageSmoothingQuality
{
	Low,
	Medium,
	High,
}

///<include file='Utils/Docs/CanvasRenderingContext2D/CanvasRenderingContext2D.generated.xml' path='docs/CanvasRenderingContext2D/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CanvasRenderingContext2D
{
	///<include file='Utils/Docs/CanvasRenderingContext2DCanvas/CanvasRenderingContext2DCanvas.generated.xml' path='docs/CanvasRenderingContext2DCanvas/*'/>
	public HTMLCanvasElement Canvas { get; }
	///<include file='Utils/Docs/CanvasRenderingContext2DGetContextAttributes/CanvasRenderingContext2DGetContextAttributes.generated.xml' path='docs/CanvasRenderingContext2DGetContextAttributes/*'/>
	public CanvasRenderingContext2DSettings GetContextAttributes() { throw new System.NotImplementedException(); }
}

















[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasState
{
		public Undefined Save() { throw new System.NotImplementedException(); }
		public Undefined Restore() { throw new System.NotImplementedException(); }
		public Undefined Reset() { throw new System.NotImplementedException(); }
		public bool IsContextLost() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasTransform
{
		public Undefined Scale(double x, double y) { throw new System.NotImplementedException(); }
		public Undefined Rotate(double angle) { throw new System.NotImplementedException(); }
		public Undefined Translate(double x, double y) { throw new System.NotImplementedException(); }
		public Undefined Transform(double a, double b, double c, double d, double e, double f) { throw new System.NotImplementedException(); }
		public DOMMatrix GetTransform() { throw new System.NotImplementedException(); }
		public Undefined SetTransform(double a, double b, double c, double d, double e, double f) { throw new System.NotImplementedException(); }
		public Undefined SetTransform(DOMMatrix2DInit transform) { throw new System.NotImplementedException(); }
		public Undefined ResetTransform() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasCompositing
{
		public double GlobalAlpha { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string GlobalCompositeOperation { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasImageSmoothing
{
		public bool ImageSmoothingEnabled { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public ImageSmoothingQuality ImageSmoothingQuality { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasFillStrokeStyles
{
		public Union17 StrokeStyle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public Union18 FillStyle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasGradient CreateLinearGradient(Number x0, Number y0, Number x1, Number y1) { throw new System.NotImplementedException(); }
		public CanvasGradient CreateRadialGradient(Number x0, Number y0, Number r0, Number x1, Number y1, Number r1) { throw new System.NotImplementedException(); }
		public CanvasGradient CreateConicGradient(Number startAngle, Number x, Number y) { throw new System.NotImplementedException(); }
		public CanvasPattern? CreatePattern(CanvasImageSource image, string repetition) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasShadowStyles
{
		public double ShadowOffsetX { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public double ShadowOffsetY { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public double ShadowBlur { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string ShadowColor { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasFilters
{
		public string Filter { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasRect
{
		public Undefined ClearRect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
		public Undefined FillRect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
		public Undefined StrokeRect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasDrawPath
{
		public Undefined BeginPath() { throw new System.NotImplementedException(); }
		public Undefined Fill(CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
		public Undefined Fill(Path2D path, CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
		public Undefined Stroke() { throw new System.NotImplementedException(); }
		public Undefined Stroke(Path2D path) { throw new System.NotImplementedException(); }
		public Undefined Clip(CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
		public Undefined Clip(Path2D path, CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
		public bool IsPointInPath(double x, double y, CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
		public bool IsPointInPath(Path2D path, double x, double y, CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
		public bool IsPointInStroke(double x, double y) { throw new System.NotImplementedException(); }
		public bool IsPointInStroke(Path2D path, double x, double y) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasUserInterface
{
		public Undefined DrawFocusIfNeeded(Element element) { throw new System.NotImplementedException(); }
		public Undefined DrawFocusIfNeeded(Path2D path, Element element) { throw new System.NotImplementedException(); }
		public Undefined ScrollPathIntoView() { throw new System.NotImplementedException(); }
		public Undefined ScrollPathIntoView(Path2D path) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasText
{
		public Undefined FillText(string text, double x, double y, double maxWidth) { throw new System.NotImplementedException(); }
		public Undefined StrokeText(string text, double x, double y, double maxWidth) { throw new System.NotImplementedException(); }
		public TextMetrics MeasureText(string text) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasDrawImage
{
		public Undefined DrawImage(CanvasImageSource image, double dx, double dy) { throw new System.NotImplementedException(); }
		public Undefined DrawImage(CanvasImageSource image, double dx, double dy, double dw, double dh) { throw new System.NotImplementedException(); }
		public Undefined DrawImage(CanvasImageSource image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasImageData
{
		public ImageData CreateImageData(long sw, long sh, ImageDataSettings settings) { throw new System.NotImplementedException(); }
		public ImageData CreateImageData(ImageData imagedata) { throw new System.NotImplementedException(); }
		public ImageData GetImageData(long sx, long sy, long sw, long sh, ImageDataSettings settings) { throw new System.NotImplementedException(); }
		public Undefined PutImageData(ImageData imagedata, long dx, long dy) { throw new System.NotImplementedException(); }
		public Undefined PutImageData(ImageData imagedata, long dx, long dy, long dirtyX, long dirtyY, long dirtyWidth, long dirtyHeight) { throw new System.NotImplementedException(); }
}

public enum CanvasLineCap
{
	Butt,
	Round,
	Square,
}

public enum CanvasLineJoin
{
	Round,
	Bevel,
	Miter,
}

public enum CanvasTextAlign
{
	Start,
	End,
	Left,
	Right,
	Center,
}

public enum CanvasTextBaseline
{
	Top,
	Hanging,
	Middle,
	Alphabetic,
	Ideographic,
	Bottom,
}

public enum CanvasDirection
{
	Ltr,
	Rtl,
	Inherit,
}

public enum CanvasFontKerning
{
	Auto,
	Normal,
	None,
}

public enum CanvasFontStretch
{
	UltraCondensed,
	ExtraCondensed,
	Condensed,
	SemiCondensed,
	Normal,
	SemiExpanded,
	Expanded,
	ExtraExpanded,
	UltraExpanded,
}

public enum CanvasFontVariantCaps
{
	Normal,
	SmallCaps,
	AllSmallCaps,
	PetiteCaps,
	AllPetiteCaps,
	Unicase,
	TitlingCaps,
}

public enum CanvasTextRendering
{
	Auto,
	OptimizeSpeed,
	OptimizeLegibility,
	GeometricPrecision,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasPathDrawingStyles
{
		public double LineWidth { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasLineCap LineCap { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasLineJoin LineJoin { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public double MiterLimit { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public Undefined SetLineDash(List<double> segments) { throw new System.NotImplementedException(); }
		public List<double> GetLineDash() { throw new System.NotImplementedException(); }
		public double LineDashOffset { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasTextDrawingStyles
{
		public string Font { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasTextAlign TextAlign { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasTextBaseline TextBaseline { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasDirection Direction { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string LetterSpacing { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasFontKerning FontKerning { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasFontStretch FontStretch { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasFontVariantCaps FontVariantCaps { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasTextRendering TextRendering { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string WordSpacing { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasPath
{
		public Undefined ClosePath() { throw new System.NotImplementedException(); }
		public Undefined MoveTo(double x, double y) { throw new System.NotImplementedException(); }
		public Undefined LineTo(double x, double y) { throw new System.NotImplementedException(); }
		public Undefined QuadraticCurveTo(double cpx, double cpy, double x, double y) { throw new System.NotImplementedException(); }
		public Undefined BezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y) { throw new System.NotImplementedException(); }
		public Undefined ArcTo(double x1, double y1, double x2, double y2, double radius) { throw new System.NotImplementedException(); }
		public Undefined Rect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
		public Undefined RoundRect(double x, double y, double w, double h, Union19 radii) { throw new System.NotImplementedException(); }
		public Undefined Arc(double x, double y, double radius, double startAngle, double endAngle, bool counterclockwise) { throw new System.NotImplementedException(); }
		public Undefined Ellipse(double x, double y, double radiusX, double radiusY, double rotation, double startAngle, double endAngle, bool counterclockwise) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/CanvasGradient/CanvasGradient.generated.xml' path='docs/CanvasGradient/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CanvasGradient
{
	///<include file='Utils/Docs/CanvasGradientAddColorStop/CanvasGradientAddColorStop.generated.xml' path='docs/CanvasGradientAddColorStop/*'/>
	public Undefined AddColorStop(Number offset, string color) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/CanvasPattern/CanvasPattern.generated.xml' path='docs/CanvasPattern/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CanvasPattern
{
	///<include file='Utils/Docs/CanvasPatternSetTransform/CanvasPatternSetTransform.generated.xml' path='docs/CanvasPatternSetTransform/*'/>
	public Undefined SetTransform(DOMMatrix2DInit transform) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/TextMetrics/TextMetrics.generated.xml' path='docs/TextMetrics/*'/>
[To(ToAttribute.Default)]
public partial class TextMetrics
{
	///<include file='Utils/Docs/TextMetricsWidth/TextMetricsWidth.generated.xml' path='docs/TextMetricsWidth/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Number Width { get; }
	///<include file='Utils/Docs/TextMetricsActualBoundingBoxLeft/TextMetricsActualBoundingBoxLeft.generated.xml' path='docs/TextMetricsActualBoundingBoxLeft/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Number ActualBoundingBoxLeft { get; }
	///<include file='Utils/Docs/TextMetricsActualBoundingBoxRight/TextMetricsActualBoundingBoxRight.generated.xml' path='docs/TextMetricsActualBoundingBoxRight/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Number ActualBoundingBoxRight { get; }
	///<include file='Utils/Docs/TextMetricsFontBoundingBoxAscent/TextMetricsFontBoundingBoxAscent.generated.xml' path='docs/TextMetricsFontBoundingBoxAscent/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Number FontBoundingBoxAscent { get; }
	///<include file='Utils/Docs/TextMetricsFontBoundingBoxDescent/TextMetricsFontBoundingBoxDescent.generated.xml' path='docs/TextMetricsFontBoundingBoxDescent/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Number FontBoundingBoxDescent { get; }
	///<include file='Utils/Docs/TextMetricsActualBoundingBoxAscent/TextMetricsActualBoundingBoxAscent.generated.xml' path='docs/TextMetricsActualBoundingBoxAscent/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Number ActualBoundingBoxAscent { get; }
	///<include file='Utils/Docs/TextMetricsActualBoundingBoxDescent/TextMetricsActualBoundingBoxDescent.generated.xml' path='docs/TextMetricsActualBoundingBoxDescent/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Number ActualBoundingBoxDescent { get; }
	///<include file='Utils/Docs/TextMetricsEmHeightAscent/TextMetricsEmHeightAscent.generated.xml' path='docs/TextMetricsEmHeightAscent/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Number EmHeightAscent { get; }
	///<include file='Utils/Docs/TextMetricsEmHeightDescent/TextMetricsEmHeightDescent.generated.xml' path='docs/TextMetricsEmHeightDescent/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Number EmHeightDescent { get; }
	///<include file='Utils/Docs/TextMetricsHangingBaseline/TextMetricsHangingBaseline.generated.xml' path='docs/TextMetricsHangingBaseline/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Number HangingBaseline { get; }
	///<include file='Utils/Docs/TextMetricsAlphabeticBaseline/TextMetricsAlphabeticBaseline.generated.xml' path='docs/TextMetricsAlphabeticBaseline/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Number AlphabeticBaseline { get; }
	///<include file='Utils/Docs/TextMetricsIdeographicBaseline/TextMetricsIdeographicBaseline.generated.xml' path='docs/TextMetricsIdeographicBaseline/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Number IdeographicBaseline { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageDataSettings
{
		public PredefinedColorSpace ColorSpace;
}

///<include file='Utils/Docs/ImageData/ImageData.generated.xml' path='docs/ImageData/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageData
{
	///<include file='Utils/Docs/ImageDataImageData/ImageDataImageData.generated.xml' path='docs/ImageDataImageData/*'/>
	public ImageData(ulong sw, ulong sh, ImageDataSettings settings) { }
	///<include file='Utils/Docs/ImageDataImageData/ImageDataImageData.generated.xml' path='docs/ImageDataImageData/*'/>
	public ImageData(Unsupported /*Uint8ClampedArray*/ data, ulong sw, ulong sh, ImageDataSettings settings) { }
	///<include file='Utils/Docs/ImageDataWidth/ImageDataWidth.generated.xml' path='docs/ImageDataWidth/*'/>
	public ulong Width { get; }
	///<include file='Utils/Docs/ImageDataHeight/ImageDataHeight.generated.xml' path='docs/ImageDataHeight/*'/>
	public ulong Height { get; }
	///<include file='Utils/Docs/ImageDataData/ImageDataData.generated.xml' path='docs/ImageDataData/*'/>
	public Unsupported /*Uint8ClampedArray*/ Data { get; }
	///<include file='Utils/Docs/ImageDataColorSpace/ImageDataColorSpace.generated.xml' path='docs/ImageDataColorSpace/*'/>
	public PredefinedColorSpace ColorSpace { get; }
	public ImageData() { }
}

///<include file='Utils/Docs/Path2D/Path2D.generated.xml' path='docs/Path2D/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Path2D
{
	///<include file='Utils/Docs/Path2DPath2D/Path2DPath2D.generated.xml' path='docs/Path2DPath2D/*'/>
	public Path2D(Union21 path) { }
	///<include file='Utils/Docs/Path2DAddPath/Path2DAddPath.generated.xml' path='docs/Path2DAddPath/*'/>
	public Undefined AddPath(Path2D path, DOMMatrix2DInit transform) { throw new System.NotImplementedException(); }
	public Path2D() { }
}


///<include file='Utils/Docs/ImageBitmapRenderingContext/ImageBitmapRenderingContext.generated.xml' path='docs/ImageBitmapRenderingContext/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageBitmapRenderingContext
{
		public Union22 Canvas { get; }
	///<include file='Utils/Docs/ImageBitmapRenderingContextTransferFromImageBitmap/ImageBitmapRenderingContextTransferFromImageBitmap.generated.xml' path='docs/ImageBitmapRenderingContextTransferFromImageBitmap/*'/>
	public Undefined TransferFromImageBitmap(ImageBitmap? bitmap) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageBitmapRenderingContextSettings
{
		public bool Alpha;
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageEncodeOptions
{
		public string Type;
		public double Quality;
}

public enum OffscreenRenderingContextId
{
	_2d,
	Bitmaprenderer,
	Webgl,
	Webgl2,
	Webgpu,
}

///<include file='Utils/Docs/OffscreenCanvas/OffscreenCanvas.generated.xml' path='docs/OffscreenCanvas/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class OffscreenCanvas : EventTarget
{
	///<include file='Utils/Docs/OffscreenCanvasOffscreenCanvas/OffscreenCanvasOffscreenCanvas.generated.xml' path='docs/OffscreenCanvasOffscreenCanvas/*'/>
	public OffscreenCanvas(ulong width, ulong height) { }
	///<include file='Utils/Docs/OffscreenCanvasWidth/OffscreenCanvasWidth.generated.xml' path='docs/OffscreenCanvasWidth/*'/>
	public ulong Width { get; set; }
	///<include file='Utils/Docs/OffscreenCanvasHeight/OffscreenCanvasHeight.generated.xml' path='docs/OffscreenCanvasHeight/*'/>
	public ulong Height { get; set; }
	///<include file='Utils/Docs/OffscreenCanvasGetContext/OffscreenCanvasGetContext.generated.xml' path='docs/OffscreenCanvasGetContext/*'/>
	public OffscreenRenderingContext? GetContext(OffscreenRenderingContextId contextId, dynamic options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/OffscreenCanvasTransferToImageBitmap/OffscreenCanvasTransferToImageBitmap.generated.xml' path='docs/OffscreenCanvasTransferToImageBitmap/*'/>
	public ImageBitmap TransferToImageBitmap() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/OffscreenCanvasConvertToBlob/OffscreenCanvasConvertToBlob.generated.xml' path='docs/OffscreenCanvasConvertToBlob/*'/>
	public Task<Blob> ConvertToBlob(ImageEncodeOptions options) { throw new System.NotImplementedException(); }
		public EventHandler Oncontextlost { get; set; }
		public EventHandler Oncontextrestored { get; set; }
	public OffscreenCanvas() { }
}

///<include file='Utils/Docs/OffscreenCanvasRenderingContext2D/OffscreenCanvasRenderingContext2D.generated.xml' path='docs/OffscreenCanvasRenderingContext2D/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class OffscreenCanvasRenderingContext2D
{
	///<include file='Utils/Docs/OffscreenCanvasRenderingContext2DCommit/OffscreenCanvasRenderingContext2DCommit.generated.xml' path='docs/OffscreenCanvasRenderingContext2DCommit/*'/>
	public Undefined Commit() { throw new System.NotImplementedException(); }
		public OffscreenCanvas Canvas { get; }
}
















///<include file='Utils/Docs/CustomElementRegistry/CustomElementRegistry.generated.xml' path='docs/CustomElementRegistry/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CustomElementRegistry
{
	///<include file='Utils/Docs/CustomElementRegistryDefine/CustomElementRegistryDefine.generated.xml' path='docs/CustomElementRegistryDefine/*'/>
	public Undefined Define(string name, CustomElementConstructor constructor, ElementDefinitionOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CustomElementRegistryGet/CustomElementRegistryGet.generated.xml' path='docs/CustomElementRegistryGet/*'/>
	public Union24 Get(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CustomElementRegistryGetName/CustomElementRegistryGetName.generated.xml' path='docs/CustomElementRegistryGetName/*'/>
	public string? GetName(CustomElementConstructor constructor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CustomElementRegistryWhenDefined/CustomElementRegistryWhenDefined.generated.xml' path='docs/CustomElementRegistryWhenDefined/*'/>
	public Task<CustomElementConstructor> WhenDefined(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CustomElementRegistryUpgrade/CustomElementRegistryUpgrade.generated.xml' path='docs/CustomElementRegistryUpgrade/*'/>
	public Undefined Upgrade(Node root) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct CustomElementConstructor
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ElementDefinitionOptions
{
		public string Extends;
}

///<include file='Utils/Docs/ElementInternals/ElementInternals.generated.xml' path='docs/ElementInternals/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ElementInternals
{
	///<include file='Utils/Docs/ElementInternalsShadowRoot/ElementInternalsShadowRoot.generated.xml' path='docs/ElementInternalsShadowRoot/*'/>
	public ShadowRoot? ShadowRoot { get; }
	///<include file='Utils/Docs/ElementInternalsSetFormValue/ElementInternalsSetFormValue.generated.xml' path='docs/ElementInternalsSetFormValue/*'/>
	public Undefined SetFormValue(Union25? value, Union26? state) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementInternalsForm/ElementInternalsForm.generated.xml' path='docs/ElementInternalsForm/*'/>
	public HTMLFormElement? Form { get; }
	///<include file='Utils/Docs/ElementInternalsSetValidity/ElementInternalsSetValidity.generated.xml' path='docs/ElementInternalsSetValidity/*'/>
	public Undefined SetValidity(ValidityStateFlags flags, string message, HTMLElement anchor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementInternalsWillValidate/ElementInternalsWillValidate.generated.xml' path='docs/ElementInternalsWillValidate/*'/>
	public bool WillValidate { get; }
	///<include file='Utils/Docs/ElementInternalsValidity/ElementInternalsValidity.generated.xml' path='docs/ElementInternalsValidity/*'/>
	public ValidityState Validity { get; }
	///<include file='Utils/Docs/ElementInternalsValidationMessage/ElementInternalsValidationMessage.generated.xml' path='docs/ElementInternalsValidationMessage/*'/>
	public string ValidationMessage { get; }
	///<include file='Utils/Docs/ElementInternalsCheckValidity/ElementInternalsCheckValidity.generated.xml' path='docs/ElementInternalsCheckValidity/*'/>
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementInternalsReportValidity/ElementInternalsReportValidity.generated.xml' path='docs/ElementInternalsReportValidity/*'/>
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementInternalsLabels/ElementInternalsLabels.generated.xml' path='docs/ElementInternalsLabels/*'/>
	public NodeList Labels { get; }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class ValidityStateFlags
{
		public bool ValueMissing;
		public bool TypeMismatch;
		public bool PatternMismatch;
		public bool TooLong;
		public bool TooShort;
		public bool RangeUnderflow;
		public bool RangeOverflow;
		public bool StepMismatch;
		public bool BadInput;
		public bool CustomError;
}

///<include file='Utils/Docs/VisibilityStateEntry/VisibilityStateEntry.generated.xml' path='docs/VisibilityStateEntry/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class VisibilityStateEntry
{
		public string Name { get; }
		public string EntryType { get; }
		public Unsupported /*DOMHighResTimeStamp*/ StartTime { get; }
		public ulong Duration { get; }
}

///<include file='Utils/Docs/UserActivation/UserActivation.generated.xml' path='docs/UserActivation/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class UserActivation
{
	///<include file='Utils/Docs/UserActivationHasBeenActive/UserActivationHasBeenActive.generated.xml' path='docs/UserActivationHasBeenActive/*'/>
	public bool HasBeenActive { get; }
	///<include file='Utils/Docs/UserActivationIsActive/UserActivationIsActive.generated.xml' path='docs/UserActivationIsActive/*'/>
	public bool IsActive { get; }
}

///<include file='Utils/Docs/Navigator/Navigator.generated.xml' path='docs/Navigator/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Navigator
{
	///<include file='Utils/Docs/NavigatorUserActivation/NavigatorUserActivation.generated.xml' path='docs/NavigatorUserActivation/*'/>
	public UserActivation UserActivation { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FocusOptions
{
		public bool PreventScroll;
		public bool FocusVisible;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface ElementContentEditable
{
		public string ContentEditable { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string EnterKeyHint { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public bool IsContentEditable { get { throw new System.NotImplementedException(); } }
		public string InputMode { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/DataTransfer/DataTransfer.generated.xml' path='docs/DataTransfer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DataTransfer
{
	///<include file='Utils/Docs/DataTransferDataTransfer/DataTransferDataTransfer.generated.xml' path='docs/DataTransferDataTransfer/*'/>
	public DataTransfer() { }
	///<include file='Utils/Docs/DataTransferDropEffect/DataTransferDropEffect.generated.xml' path='docs/DataTransferDropEffect/*'/>
	public string DropEffect { get; set; }
	///<include file='Utils/Docs/DataTransferEffectAllowed/DataTransferEffectAllowed.generated.xml' path='docs/DataTransferEffectAllowed/*'/>
	public string EffectAllowed { get; set; }
	///<include file='Utils/Docs/DataTransferItems/DataTransferItems.generated.xml' path='docs/DataTransferItems/*'/>
	public DataTransferItemList Items { get; }
	///<include file='Utils/Docs/DataTransferSetDragImage/DataTransferSetDragImage.generated.xml' path='docs/DataTransferSetDragImage/*'/>
	public Undefined SetDragImage(Element image, long x, long y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DataTransferTypes/DataTransferTypes.generated.xml' path='docs/DataTransferTypes/*'/>
	public string[] Types { get; }
	///<include file='Utils/Docs/DataTransferGetData/DataTransferGetData.generated.xml' path='docs/DataTransferGetData/*'/>
	public string GetData(string format) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DataTransferSetData/DataTransferSetData.generated.xml' path='docs/DataTransferSetData/*'/>
	public Undefined SetData(string format, string data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DataTransferClearData/DataTransferClearData.generated.xml' path='docs/DataTransferClearData/*'/>
	public Undefined ClearData(string format) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DataTransferFiles/DataTransferFiles.generated.xml' path='docs/DataTransferFiles/*'/>
	public FileList Files { get; }
}

///<include file='Utils/Docs/DataTransferItemList/DataTransferItemList.generated.xml' path='docs/DataTransferItemList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DataTransferItemList
{
	///<include file='Utils/Docs/DataTransferItemListLength/DataTransferItemListLength.generated.xml' path='docs/DataTransferItemListLength/*'/>
	public ulong Length { get; }
	
	///<include file='Utils/Docs/DataTransferItemListAdd/DataTransferItemListAdd.generated.xml' path='docs/DataTransferItemListAdd/*'/>
	public DataTransferItem? Add(string data, string type) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DataTransferItemListAdd/DataTransferItemListAdd.generated.xml' path='docs/DataTransferItemListAdd/*'/>
	public DataTransferItem? Add(File data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DataTransferItemListRemove/DataTransferItemListRemove.generated.xml' path='docs/DataTransferItemListRemove/*'/>
	public Undefined Remove(ulong index) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DataTransferItemListClear/DataTransferItemListClear.generated.xml' path='docs/DataTransferItemListClear/*'/>
	public Undefined Clear() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/DataTransferItem/DataTransferItem.generated.xml' path='docs/DataTransferItem/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DataTransferItem
{
	///<include file='Utils/Docs/DataTransferItemKind/DataTransferItemKind.generated.xml' path='docs/DataTransferItemKind/*'/>
	public string Kind { get; }
	///<include file='Utils/Docs/DataTransferItemType/DataTransferItemType.generated.xml' path='docs/DataTransferItemType/*'/>
	public string Type { get; }
	///<include file='Utils/Docs/DataTransferItemGetAsString/DataTransferItemGetAsString.generated.xml' path='docs/DataTransferItemGetAsString/*'/>
	public Undefined GetAsString(FunctionStringCallback? callback) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DataTransferItemGetAsFile/DataTransferItemGetAsFile.generated.xml' path='docs/DataTransferItemGetAsFile/*'/>
	public File? GetAsFile() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct FunctionStringCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct FunctionObjectCallback
{
}

///<include file='Utils/Docs/DragEvent/DragEvent.generated.xml' path='docs/DragEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DragEvent : MouseEvent
{
	///<include file='Utils/Docs/DragEventDragEvent/DragEventDragEvent.generated.xml' path='docs/DragEventDragEvent/*'/>
	public DragEvent(string type, DragEventInit eventInitDict) { }
	///<include file='Utils/Docs/DragEventDataTransfer/DragEventDataTransfer.generated.xml' path='docs/DragEventDataTransfer/*'/>
	public DataTransfer? DataTransfer { get; }
	public DragEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class DragEventInit : MouseEventInit
{
		public DataTransfer? DataTransfer;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface PopoverInvokerElement
{
		public Element? PopoverTargetElement { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string PopoverTargetAction { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/ToggleEvent/ToggleEvent.generated.xml' path='docs/ToggleEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ToggleEvent : Event
{
	///<include file='Utils/Docs/ToggleEventToggleEvent/ToggleEventToggleEvent.generated.xml' path='docs/ToggleEventToggleEvent/*'/>
	public ToggleEvent(string type, ToggleEventInit eventInitDict) { }
	///<include file='Utils/Docs/ToggleEventOldState/ToggleEventOldState.generated.xml' path='docs/ToggleEventOldState/*'/>
	public string OldState { get; }
	///<include file='Utils/Docs/ToggleEventNewState/ToggleEventNewState.generated.xml' path='docs/ToggleEventNewState/*'/>
	public string NewState { get; }
	public ToggleEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ToggleEventInit : EventInit
{
		public string OldState;
		public string NewState;
}

///<include file='Utils/Docs/Window/Window.generated.xml' path='docs/Window/*'/>
[To(ToAttribute.Default)]
public partial class Window : EventTarget, GlobalEventHandlers, WindowEventHandlers, WindowOrWorkerGlobalScope, AnimationFrameProvider, WindowSessionStorage, WindowLocalStorage
{
	///<include file='Utils/Docs/WindowWindow/WindowWindow.generated.xml' path='docs/WindowWindow/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public WindowProxy _window { get; }
	///<include file='Utils/Docs/WindowSelf/WindowSelf.generated.xml' path='docs/WindowSelf/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public WindowProxy Self { get; }
	///<include file='Utils/Docs/WindowDocument/WindowDocument.generated.xml' path='docs/WindowDocument/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Document Document { get; }
	///<include file='Utils/Docs/WindowName/WindowName.generated.xml' path='docs/WindowName/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	///<include file='Utils/Docs/WindowLocation/WindowLocation.generated.xml' path='docs/WindowLocation/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Location Location { get; }
	///<include file='Utils/Docs/WindowHistory/WindowHistory.generated.xml' path='docs/WindowHistory/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public History History { get; }
	///<include file='Utils/Docs/WindowNavigation/WindowNavigation.generated.xml' path='docs/WindowNavigation/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Navigation Navigation { get; }
	///<include file='Utils/Docs/WindowCustomElements/WindowCustomElements.generated.xml' path='docs/WindowCustomElements/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public CustomElementRegistry CustomElements { get; }
	///<include file='Utils/Docs/WindowLocationbar/WindowLocationbar.generated.xml' path='docs/WindowLocationbar/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public BarProp Locationbar { get; }
	///<include file='Utils/Docs/WindowMenubar/WindowMenubar.generated.xml' path='docs/WindowMenubar/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public BarProp Menubar { get; }
	///<include file='Utils/Docs/WindowPersonalbar/WindowPersonalbar.generated.xml' path='docs/WindowPersonalbar/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public BarProp Personalbar { get; }
	///<include file='Utils/Docs/WindowScrollbars/WindowScrollbars.generated.xml' path='docs/WindowScrollbars/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public BarProp Scrollbars { get; }
	///<include file='Utils/Docs/WindowStatusbar/WindowStatusbar.generated.xml' path='docs/WindowStatusbar/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public BarProp Statusbar { get; }
	///<include file='Utils/Docs/WindowToolbar/WindowToolbar.generated.xml' path='docs/WindowToolbar/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public BarProp Toolbar { get; }
	///<include file='Utils/Docs/WindowStatus/WindowStatus.generated.xml' path='docs/WindowStatus/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Status { get; set; }
	///<include file='Utils/Docs/WindowClose/WindowClose.generated.xml' path='docs/WindowClose/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Close() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowClosed/WindowClosed.generated.xml' path='docs/WindowClosed/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Closed { get; }
	///<include file='Utils/Docs/WindowStop/WindowStop.generated.xml' path='docs/WindowStop/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Stop() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowFocus/WindowFocus.generated.xml' path='docs/WindowFocus/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Focus() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowBlur/WindowBlur.generated.xml' path='docs/WindowBlur/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Blur() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowFrames/WindowFrames.generated.xml' path='docs/WindowFrames/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public WindowProxy Frames { get; }
	///<include file='Utils/Docs/WindowLength/WindowLength.generated.xml' path='docs/WindowLength/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Length { get; }
	///<include file='Utils/Docs/WindowTop/WindowTop.generated.xml' path='docs/WindowTop/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public WindowProxy? Top { get; }
	///<include file='Utils/Docs/WindowOpener/WindowOpener.generated.xml' path='docs/WindowOpener/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public dynamic Opener { get; set; }
	///<include file='Utils/Docs/WindowParent/WindowParent.generated.xml' path='docs/WindowParent/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public WindowProxy? Parent { get; }
	///<include file='Utils/Docs/WindowFrameElement/WindowFrameElement.generated.xml' path='docs/WindowFrameElement/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Element? FrameElement { get; }
	///<include file='Utils/Docs/WindowOpen/WindowOpen.generated.xml' path='docs/WindowOpen/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public WindowProxy? Open(string url, string target, string features) { throw new System.NotImplementedException(); }
	
	///<include file='Utils/Docs/WindowNavigator/WindowNavigator.generated.xml' path='docs/WindowNavigator/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Navigator Navigator { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Navigator ClientInformation { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool OriginAgentCluster { get; }
	///<include file='Utils/Docs/WindowAlert/WindowAlert.generated.xml' path='docs/WindowAlert/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Alert() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowAlert/WindowAlert.generated.xml' path='docs/WindowAlert/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Alert(string message) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowConfirm/WindowConfirm.generated.xml' path='docs/WindowConfirm/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Confirm(string message) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowPrompt/WindowPrompt.generated.xml' path='docs/WindowPrompt/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string? Prompt(string message, string default_) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowPrint/WindowPrint.generated.xml' path='docs/WindowPrint/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Print() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowPostMessage/WindowPostMessage.generated.xml' path='docs/WindowPostMessage/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined PostMessage(dynamic message, string targetOrigin, List<object> transfer) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowPostMessage/WindowPostMessage.generated.xml' path='docs/WindowPostMessage/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined PostMessage(dynamic message, WindowPostMessageOptions options) { throw new System.NotImplementedException(); }
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial class WindowPostMessageOptions : StructuredSerializeOptions
{
		public string TargetOrigin;
}

///<include file='Utils/Docs/BarProp/BarProp.generated.xml' path='docs/BarProp/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class BarProp
{
	///<include file='Utils/Docs/BarPropVisible/BarPropVisible.generated.xml' path='docs/BarPropVisible/*'/>
	public bool Visible { get; }
}

///<include file='Utils/Docs/Location/Location.generated.xml' path='docs/Location/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Location
{
	///<include file='Utils/Docs/LocationHref/LocationHref.generated.xml' path='docs/LocationHref/*'/>
	public string Href { get; set; }
	///<include file='Utils/Docs/LocationOrigin/LocationOrigin.generated.xml' path='docs/LocationOrigin/*'/>
	public string Origin { get; }
	///<include file='Utils/Docs/LocationProtocol/LocationProtocol.generated.xml' path='docs/LocationProtocol/*'/>
	public string Protocol { get; set; }
	///<include file='Utils/Docs/LocationHost/LocationHost.generated.xml' path='docs/LocationHost/*'/>
	public string Host { get; set; }
	///<include file='Utils/Docs/LocationHostname/LocationHostname.generated.xml' path='docs/LocationHostname/*'/>
	public string Hostname { get; set; }
	///<include file='Utils/Docs/LocationPort/LocationPort.generated.xml' path='docs/LocationPort/*'/>
	public string Port { get; set; }
	///<include file='Utils/Docs/LocationPathname/LocationPathname.generated.xml' path='docs/LocationPathname/*'/>
	public string Pathname { get; set; }
	///<include file='Utils/Docs/LocationSearch/LocationSearch.generated.xml' path='docs/LocationSearch/*'/>
	public string Search { get; set; }
	///<include file='Utils/Docs/LocationHash/LocationHash.generated.xml' path='docs/LocationHash/*'/>
	public string Hash { get; set; }
	///<include file='Utils/Docs/LocationAssign/LocationAssign.generated.xml' path='docs/LocationAssign/*'/>
	public Undefined Assign(string url) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/LocationReplace/LocationReplace.generated.xml' path='docs/LocationReplace/*'/>
	public Undefined Replace(string url) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/LocationReload/LocationReload.generated.xml' path='docs/LocationReload/*'/>
	public Undefined Reload() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/LocationAncestorOrigins/LocationAncestorOrigins.generated.xml' path='docs/LocationAncestorOrigins/*'/>
	public string AncestorOrigins { get; }
}

public enum ScrollRestoration
{
	Auto,
	Manual,
}

///<include file='Utils/Docs/History/History.generated.xml' path='docs/History/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class History
{
	///<include file='Utils/Docs/HistoryLength/HistoryLength.generated.xml' path='docs/HistoryLength/*'/>
	public ulong Length { get; }
	///<include file='Utils/Docs/HistoryScrollRestoration/HistoryScrollRestoration.generated.xml' path='docs/HistoryScrollRestoration/*'/>
	public ScrollRestoration ScrollRestoration { get; set; }
	///<include file='Utils/Docs/HistoryState/HistoryState.generated.xml' path='docs/HistoryState/*'/>
	public dynamic State { get; }
	///<include file='Utils/Docs/HistoryGo/HistoryGo.generated.xml' path='docs/HistoryGo/*'/>
	public Undefined Go(long delta) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HistoryBack/HistoryBack.generated.xml' path='docs/HistoryBack/*'/>
	public Undefined Back() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HistoryForward/HistoryForward.generated.xml' path='docs/HistoryForward/*'/>
	public Undefined Forward() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HistoryPushState/HistoryPushState.generated.xml' path='docs/HistoryPushState/*'/>
	public Undefined PushState(dynamic data, string unused, string? url) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HistoryReplaceState/HistoryReplaceState.generated.xml' path='docs/HistoryReplaceState/*'/>
	public Undefined ReplaceState(dynamic data, string unused, string? url) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Navigation/Navigation.generated.xml' path='docs/Navigation/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Navigation : EventTarget
{
	///<include file='Utils/Docs/NavigationEntries/NavigationEntries.generated.xml' path='docs/NavigationEntries/*'/>
	public List<NavigationHistoryEntry> Entries() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NavigationCurrentEntry/NavigationCurrentEntry.generated.xml' path='docs/NavigationCurrentEntry/*'/>
	public NavigationHistoryEntry? CurrentEntry { get; }
	///<include file='Utils/Docs/NavigationUpdateCurrentEntry/NavigationUpdateCurrentEntry.generated.xml' path='docs/NavigationUpdateCurrentEntry/*'/>
	public Undefined UpdateCurrentEntry(NavigationUpdateCurrentEntryOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NavigationTransition/NavigationTransition.generated.xml' path='docs/NavigationTransition/*'/>
	public NavigationTransition? Transition { get; }
	///<include file='Utils/Docs/NavigationCanGoBack/NavigationCanGoBack.generated.xml' path='docs/NavigationCanGoBack/*'/>
	public bool CanGoBack { get; }
	///<include file='Utils/Docs/NavigationCanGoForward/NavigationCanGoForward.generated.xml' path='docs/NavigationCanGoForward/*'/>
	public bool CanGoForward { get; }
	///<include file='Utils/Docs/NavigationNavigate/NavigationNavigate.generated.xml' path='docs/NavigationNavigate/*'/>
	public NavigationResult Navigate(string url, NavigationNavigateOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NavigationReload/NavigationReload.generated.xml' path='docs/NavigationReload/*'/>
	public NavigationResult Reload(NavigationReloadOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NavigationTraverseTo/NavigationTraverseTo.generated.xml' path='docs/NavigationTraverseTo/*'/>
	public NavigationResult TraverseTo(string key, NavigationOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NavigationBack/NavigationBack.generated.xml' path='docs/NavigationBack/*'/>
	public NavigationResult Back(NavigationOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NavigationForward/NavigationForward.generated.xml' path='docs/NavigationForward/*'/>
	public NavigationResult Forward(NavigationOptions options) { throw new System.NotImplementedException(); }
		public EventHandler Onnavigate { get; set; }
		public EventHandler Onnavigatesuccess { get; set; }
		public EventHandler Onnavigateerror { get; set; }
		public EventHandler Oncurrententrychange { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NavigationUpdateCurrentEntryOptions
{
		public required dynamic State;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NavigationOptions
{
		public dynamic Info;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NavigationNavigateOptions : NavigationOptions
{
		public dynamic State;
		public NavigationHistoryBehavior History;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NavigationReloadOptions : NavigationOptions
{
		public dynamic State;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NavigationResult
{
		public Task<NavigationHistoryEntry> Committed;
		public Task<NavigationHistoryEntry> Finished;
}

public enum NavigationHistoryBehavior
{
	Auto,
	Push,
	Replace,
}

public enum NavigationType
{
	Push,
	Replace,
	Reload,
	Traverse,
}

///<include file='Utils/Docs/NavigationHistoryEntry/NavigationHistoryEntry.generated.xml' path='docs/NavigationHistoryEntry/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class NavigationHistoryEntry : EventTarget
{
	///<include file='Utils/Docs/NavigationHistoryEntryUrl/NavigationHistoryEntryUrl.generated.xml' path='docs/NavigationHistoryEntryUrl/*'/>
	public string? Url { get; }
	///<include file='Utils/Docs/NavigationHistoryEntryKey/NavigationHistoryEntryKey.generated.xml' path='docs/NavigationHistoryEntryKey/*'/>
	public string Key { get; }
	///<include file='Utils/Docs/NavigationHistoryEntryId/NavigationHistoryEntryId.generated.xml' path='docs/NavigationHistoryEntryId/*'/>
	public string Id { get; }
	///<include file='Utils/Docs/NavigationHistoryEntryIndex/NavigationHistoryEntryIndex.generated.xml' path='docs/NavigationHistoryEntryIndex/*'/>
	public long Index { get; }
	///<include file='Utils/Docs/NavigationHistoryEntrySameDocument/NavigationHistoryEntrySameDocument.generated.xml' path='docs/NavigationHistoryEntrySameDocument/*'/>
	public bool SameDocument { get; }
	///<include file='Utils/Docs/NavigationHistoryEntryGetState/NavigationHistoryEntryGetState.generated.xml' path='docs/NavigationHistoryEntryGetState/*'/>
	public dynamic GetState() { throw new System.NotImplementedException(); }
		public EventHandler Ondispose { get; set; }
}

///<include file='Utils/Docs/NavigationTransition/NavigationTransition.generated.xml' path='docs/NavigationTransition/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class NavigationTransition
{
	///<include file='Utils/Docs/NavigationTransitionNavigationType/NavigationTransitionNavigationType.generated.xml' path='docs/NavigationTransitionNavigationType/*'/>
	public NavigationType NavigationType { get; }
	///<include file='Utils/Docs/NavigationTransitionFrom/NavigationTransitionFrom.generated.xml' path='docs/NavigationTransitionFrom/*'/>
	public NavigationHistoryEntry From { get; }
	///<include file='Utils/Docs/NavigationTransitionFinished/NavigationTransitionFinished.generated.xml' path='docs/NavigationTransitionFinished/*'/>
	public Task<Undefined> Finished { get; }
}

///<include file='Utils/Docs/NavigateEvent/NavigateEvent.generated.xml' path='docs/NavigateEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class NavigateEvent : Event
{
	///<include file='Utils/Docs/NavigateEventNavigateEvent/NavigateEventNavigateEvent.generated.xml' path='docs/NavigateEventNavigateEvent/*'/>
	public NavigateEvent(string type, NavigateEventInit eventInitDict) { }
	///<include file='Utils/Docs/NavigateEventNavigationType/NavigateEventNavigationType.generated.xml' path='docs/NavigateEventNavigationType/*'/>
	public NavigationType NavigationType { get; }
	///<include file='Utils/Docs/NavigateEventDestination/NavigateEventDestination.generated.xml' path='docs/NavigateEventDestination/*'/>
	public NavigationDestination Destination { get; }
	///<include file='Utils/Docs/NavigateEventCanIntercept/NavigateEventCanIntercept.generated.xml' path='docs/NavigateEventCanIntercept/*'/>
	public bool CanIntercept { get; }
	///<include file='Utils/Docs/NavigateEventUserInitiated/NavigateEventUserInitiated.generated.xml' path='docs/NavigateEventUserInitiated/*'/>
	public bool UserInitiated { get; }
	///<include file='Utils/Docs/NavigateEventHashChange/NavigateEventHashChange.generated.xml' path='docs/NavigateEventHashChange/*'/>
	public bool HashChange { get; }
	///<include file='Utils/Docs/NavigateEventSignal/NavigateEventSignal.generated.xml' path='docs/NavigateEventSignal/*'/>
	public AbortSignal Signal { get; }
	///<include file='Utils/Docs/NavigateEventFormData/NavigateEventFormData.generated.xml' path='docs/NavigateEventFormData/*'/>
	public FormData? FormData { get; }
	///<include file='Utils/Docs/NavigateEventDownloadRequest/NavigateEventDownloadRequest.generated.xml' path='docs/NavigateEventDownloadRequest/*'/>
	public string? DownloadRequest { get; }
	///<include file='Utils/Docs/NavigateEventInfo/NavigateEventInfo.generated.xml' path='docs/NavigateEventInfo/*'/>
	public dynamic Info { get; }
	///<include file='Utils/Docs/NavigateEventIntercept/NavigateEventIntercept.generated.xml' path='docs/NavigateEventIntercept/*'/>
	public Undefined Intercept(NavigationInterceptOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NavigateEventScroll/NavigateEventScroll.generated.xml' path='docs/NavigateEventScroll/*'/>
	public Undefined Scroll() { throw new System.NotImplementedException(); }
	public NavigateEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NavigateEventInit : EventInit
{
		public NavigationType NavigationType;
		public required NavigationDestination Destination;
		public bool CanIntercept;
		public bool UserInitiated;
		public bool HashChange;
		public required AbortSignal Signal;
		public FormData? FormData;
		public string? DownloadRequest;
		public dynamic Info;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NavigationInterceptOptions
{
		public NavigationInterceptHandler Handler;
		public NavigationFocusReset FocusReset;
		public NavigationScrollBehavior Scroll;
}

public enum NavigationFocusReset
{
	AfterTransition,
	Manual,
}

public enum NavigationScrollBehavior
{
	AfterTransition,
	Manual,
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct NavigationInterceptHandler
{
}

///<include file='Utils/Docs/NavigationDestination/NavigationDestination.generated.xml' path='docs/NavigationDestination/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class NavigationDestination
{
	///<include file='Utils/Docs/NavigationDestinationUrl/NavigationDestinationUrl.generated.xml' path='docs/NavigationDestinationUrl/*'/>
	public string Url { get; }
	///<include file='Utils/Docs/NavigationDestinationKey/NavigationDestinationKey.generated.xml' path='docs/NavigationDestinationKey/*'/>
	public string Key { get; }
	///<include file='Utils/Docs/NavigationDestinationId/NavigationDestinationId.generated.xml' path='docs/NavigationDestinationId/*'/>
	public string Id { get; }
	///<include file='Utils/Docs/NavigationDestinationIndex/NavigationDestinationIndex.generated.xml' path='docs/NavigationDestinationIndex/*'/>
	public long Index { get; }
	///<include file='Utils/Docs/NavigationDestinationSameDocument/NavigationDestinationSameDocument.generated.xml' path='docs/NavigationDestinationSameDocument/*'/>
	public bool SameDocument { get; }
	///<include file='Utils/Docs/NavigationDestinationGetState/NavigationDestinationGetState.generated.xml' path='docs/NavigationDestinationGetState/*'/>
	public dynamic GetState() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/NavigationCurrentEntryChangeEvent/NavigationCurrentEntryChangeEvent.generated.xml' path='docs/NavigationCurrentEntryChangeEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class NavigationCurrentEntryChangeEvent : Event
{
	///<include file='Utils/Docs/NavigationCurrentEntryChangeEventNavigationCurrentEntryChang/NavigationCurrentEntryChangeEventNavigationCurrentEntryChang.generated.xml' path='docs/NavigationCurrentEntryChangeEventNavigationCurrentEntryChang/*'/>
	public NavigationCurrentEntryChangeEvent(string type, NavigationCurrentEntryChangeEventInit eventInitDict) { }
	///<include file='Utils/Docs/NavigationCurrentEntryChangeEventNavigationType/NavigationCurrentEntryChangeEventNavigationType.generated.xml' path='docs/NavigationCurrentEntryChangeEventNavigationType/*'/>
	public NavigationType? NavigationType { get; }
	///<include file='Utils/Docs/NavigationCurrentEntryChangeEventFrom/NavigationCurrentEntryChangeEventFrom.generated.xml' path='docs/NavigationCurrentEntryChangeEventFrom/*'/>
	public NavigationHistoryEntry From { get; }
	public NavigationCurrentEntryChangeEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NavigationCurrentEntryChangeEventInit : EventInit
{
		public NavigationType? NavigationType;
		public required NavigationHistoryEntry From;
}

///<include file='Utils/Docs/PopStateEvent/PopStateEvent.generated.xml' path='docs/PopStateEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PopStateEvent : Event
{
	///<include file='Utils/Docs/PopStateEventPopStateEvent/PopStateEventPopStateEvent.generated.xml' path='docs/PopStateEventPopStateEvent/*'/>
	public PopStateEvent(string type, PopStateEventInit eventInitDict) { }
	///<include file='Utils/Docs/PopStateEventState/PopStateEventState.generated.xml' path='docs/PopStateEventState/*'/>
	public dynamic State { get; }
	public PopStateEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PopStateEventInit : EventInit
{
		public dynamic State;
}

///<include file='Utils/Docs/HashChangeEvent/HashChangeEvent.generated.xml' path='docs/HashChangeEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class HashChangeEvent : Event
{
	///<include file='Utils/Docs/HashChangeEventHashChangeEvent/HashChangeEventHashChangeEvent.generated.xml' path='docs/HashChangeEventHashChangeEvent/*'/>
	public HashChangeEvent(string type, HashChangeEventInit eventInitDict) { }
	///<include file='Utils/Docs/HashChangeEventOldURL/HashChangeEventOldURL.generated.xml' path='docs/HashChangeEventOldURL/*'/>
	public string OldURL { get; }
	///<include file='Utils/Docs/HashChangeEventNewURL/HashChangeEventNewURL.generated.xml' path='docs/HashChangeEventNewURL/*'/>
	public string NewURL { get; }
	public HashChangeEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class HashChangeEventInit : EventInit
{
		public string OldURL;
		public string NewURL;
}

///<include file='Utils/Docs/PageTransitionEvent/PageTransitionEvent.generated.xml' path='docs/PageTransitionEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PageTransitionEvent : Event
{
	///<include file='Utils/Docs/PageTransitionEventPageTransitionEvent/PageTransitionEventPageTransitionEvent.generated.xml' path='docs/PageTransitionEventPageTransitionEvent/*'/>
	public PageTransitionEvent(string type, PageTransitionEventInit eventInitDict) { }
	///<include file='Utils/Docs/PageTransitionEventPersisted/PageTransitionEventPersisted.generated.xml' path='docs/PageTransitionEventPersisted/*'/>
	public bool Persisted { get; }
	public PageTransitionEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PageTransitionEventInit : EventInit
{
		public bool Persisted;
}

///<include file='Utils/Docs/BeforeUnloadEvent/BeforeUnloadEvent.generated.xml' path='docs/BeforeUnloadEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class BeforeUnloadEvent : Event
{
		public string ReturnValue { get; set; }
}

///<include file='Utils/Docs/ErrorEvent/ErrorEvent.generated.xml' path='docs/ErrorEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ErrorEvent : Event
{
		public ErrorEvent(string type, ErrorEventInit eventInitDict) { }
		public string Message { get; }
		public string Filename { get; }
		public ulong Lineno { get; }
		public ulong Colno { get; }
		public dynamic Error { get; }
	public ErrorEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ErrorEventInit : EventInit
{
		public string Message;
		public string Filename;
		public ulong Lineno;
		public ulong Colno;
		public dynamic Error;
}

///<include file='Utils/Docs/PromiseRejectionEvent/PromiseRejectionEvent.generated.xml' path='docs/PromiseRejectionEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PromiseRejectionEvent : Event
{
	///<include file='Utils/Docs/PromiseRejectionEventPromiseRejectionEvent/PromiseRejectionEventPromiseRejectionEvent.generated.xml' path='docs/PromiseRejectionEventPromiseRejectionEvent/*'/>
	public PromiseRejectionEvent(string type, PromiseRejectionEventInit eventInitDict) { }
	///<include file='Utils/Docs/PromiseRejectionEventPromise/PromiseRejectionEventPromise.generated.xml' path='docs/PromiseRejectionEventPromise/*'/>
	public Task<dynamic> Promise { get; }
	///<include file='Utils/Docs/PromiseRejectionEventReason/PromiseRejectionEventReason.generated.xml' path='docs/PromiseRejectionEventReason/*'/>
	public dynamic Reason { get; }
	public PromiseRejectionEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PromiseRejectionEventInit : EventInit
{
		public required Task<dynamic> Promise;
		public dynamic Reason;
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct EventHandlerNonNull
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public struct OnErrorEventHandlerNonNull
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public struct OnBeforeUnloadEventHandlerNonNull
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GlobalEventHandlers
{
		public EventHandler Onabort { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onauxclick { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onbeforeinput { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onbeforematch { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onbeforetoggle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onblur { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oncancel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oncanplay { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oncanplaythrough { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onclick { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onclose { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oncontextlost { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oncontextmenu { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oncontextrestored { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oncopy { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oncuechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oncut { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ondblclick { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ondrag { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ondragend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ondragenter { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ondragleave { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ondragover { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ondragstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ondrop { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ondurationchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onemptied { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onended { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public OnErrorEventHandler Onerror { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onfocus { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onformdata { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oninput { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oninvalid { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onkeydown { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onkeypress { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onkeyup { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onload { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onloadeddata { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onloadedmetadata { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onloadstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmousedown { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmouseenter { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmouseleave { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmousemove { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmouseout { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmouseover { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmouseup { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpaste { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpause { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onplay { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onplaying { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onprogress { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onratechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onreset { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onresize { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onscroll { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onscrollend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onsecuritypolicyviolation { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onseeked { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onseeking { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onselect { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onslotchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onstalled { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onsubmit { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onsuspend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ontimeupdate { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ontoggle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onvolumechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onwaiting { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onwebkitanimationend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onwebkitanimationiteration { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onwebkitanimationstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onwebkittransitionend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onwheel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface WindowEventHandlers
{
		public EventHandler Onafterprint { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onbeforeprint { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public OnBeforeUnloadEventHandler Onbeforeunload { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onhashchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onlanguagechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmessage { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmessageerror { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onoffline { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ononline { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpagehide { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpageshow { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpopstate { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onrejectionhandled { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onstorage { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onunhandledrejection { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onunload { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial interface WindowOrWorkerGlobalScope
{
		public string Origin { get { throw new System.NotImplementedException(); } }
		public bool IsSecureContext { get { throw new System.NotImplementedException(); } }
		public bool CrossOriginIsolated { get { throw new System.NotImplementedException(); } }
		public Undefined ReportError(dynamic e) { throw new System.NotImplementedException(); }
		public string Btoa(string data) { throw new System.NotImplementedException(); }
		public string Atob(string data) { throw new System.NotImplementedException(); }
		public long SetTimeout(TimerHandler handler, long timeout, params dynamic[] arguments) { throw new System.NotImplementedException(); }
		public Undefined ClearTimeout(long id) { throw new System.NotImplementedException(); }
		public long SetInterval(TimerHandler handler, long timeout, params dynamic[] arguments) { throw new System.NotImplementedException(); }
		public Undefined ClearInterval(long id) { throw new System.NotImplementedException(); }
		public Undefined QueueMicrotask(VoidFunction callback) { throw new System.NotImplementedException(); }
		public Task<ImageBitmap> CreateImageBitmap(ImageBitmapSource image, ImageBitmapOptions options) { throw new System.NotImplementedException(); }
		public Task<ImageBitmap> CreateImageBitmap(ImageBitmapSource image, long sx, long sy, long sw, long sh, ImageBitmapOptions options) { throw new System.NotImplementedException(); }
		public dynamic StructuredClone(dynamic value, StructuredSerializeOptions options) { throw new System.NotImplementedException(); }
}



///<include file='Utils/Docs/DOMParser/DOMParser.generated.xml' path='docs/DOMParser/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMParser
{
	///<include file='Utils/Docs/DOMParserDOMParser/DOMParserDOMParser.generated.xml' path='docs/DOMParserDOMParser/*'/>
	public DOMParser() { }
	///<include file='Utils/Docs/DOMParserParseFromString/DOMParserParseFromString.generated.xml' path='docs/DOMParserParseFromString/*'/>
	public Document ParseFromString(string string_, DOMParserSupportedType type) { throw new System.NotImplementedException(); }
}

public enum DOMParserSupportedType
{
	TextHtml,
	TextXml,
	ApplicationXml,
	ApplicationXhtmlXml,
	ImageSvgXml,
}

///<include file='Utils/Docs/Navigator/Navigator.generated.xml' path='docs/Navigator/*'/>
public partial class Navigator
{
}








[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorID
{
		public string AppCodeName { get { throw new System.NotImplementedException(); } }
		public string AppName { get { throw new System.NotImplementedException(); } }
		public string AppVersion { get { throw new System.NotImplementedException(); } }
		public string Platform { get { throw new System.NotImplementedException(); } }
		public string Product { get { throw new System.NotImplementedException(); } }
		public string ProductSub { get { throw new System.NotImplementedException(); } }
		public string UserAgent { get { throw new System.NotImplementedException(); } }
		public string Vendor { get { throw new System.NotImplementedException(); } }
		public string VendorSub { get { throw new System.NotImplementedException(); } }
}

public partial interface NavigatorID
{
		public bool TaintEnabled() { throw new System.NotImplementedException(); }
		public string Oscpu { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NavigatorLanguage/NavigatorLanguage.generated.xml' path='docs/NavigatorLanguage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorLanguage
{
		public string Language { get { throw new System.NotImplementedException(); } }
		public string[] Languages { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NavigatorOnLine/NavigatorOnLine.generated.xml' path='docs/NavigatorOnLine/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorOnLine
{
		public bool OnLine { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorContentUtils
{
		public Undefined RegisterProtocolHandler(string scheme, string url) { throw new System.NotImplementedException(); }
		public Undefined UnregisterProtocolHandler(string scheme, string url) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorCookies
{
		public bool CookieEnabled { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NavigatorPlugins/NavigatorPlugins.generated.xml' path='docs/NavigatorPlugins/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorPlugins
{
		public PluginArray Plugins { get { throw new System.NotImplementedException(); } }
		public MimeTypeArray MimeTypes { get { throw new System.NotImplementedException(); } }
		public bool JavaEnabled() { throw new System.NotImplementedException(); }
		public bool PdfViewerEnabled { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/PluginArray/PluginArray.generated.xml' path='docs/PluginArray/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PluginArray
{
		public Undefined Refresh() { throw new System.NotImplementedException(); }
		public ulong Length { get; }
	
	
}

///<include file='Utils/Docs/MimeTypeArray/MimeTypeArray.generated.xml' path='docs/MimeTypeArray/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MimeTypeArray
{
		public ulong Length { get; }
	
	
}

///<include file='Utils/Docs/Plugin/Plugin.generated.xml' path='docs/Plugin/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Plugin
{
		public string Name { get; }
		public string Description { get; }
		public string Filename { get; }
		public ulong Length { get; }
	
	
}

///<include file='Utils/Docs/MimeType/MimeType.generated.xml' path='docs/MimeType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MimeType
{
		public string Type { get; }
		public string Description { get; }
		public string Suffixes { get; }
		public Plugin EnabledPlugin { get; }
}

///<include file='Utils/Docs/ImageBitmap/ImageBitmap.generated.xml' path='docs/ImageBitmap/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageBitmap
{
	///<include file='Utils/Docs/ImageBitmapWidth/ImageBitmapWidth.generated.xml' path='docs/ImageBitmapWidth/*'/>
	public ulong Width { get; }
	///<include file='Utils/Docs/ImageBitmapHeight/ImageBitmapHeight.generated.xml' path='docs/ImageBitmapHeight/*'/>
	public ulong Height { get; }
	///<include file='Utils/Docs/ImageBitmapClose/ImageBitmapClose.generated.xml' path='docs/ImageBitmapClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
}


public enum ImageOrientation
{
	FromImage,
	FlipY,
}

public enum PremultiplyAlpha
{
	None,
	Premultiply,
	Default,
}

public enum ColorSpaceConversion
{
	None,
	Default,
}

public enum ResizeQuality
{
	Pixelated,
	Low,
	Medium,
	High,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageBitmapOptions
{
		public ImageOrientation ImageOrientation;
		public PremultiplyAlpha PremultiplyAlpha;
		public ColorSpaceConversion ColorSpaceConversion;
		public ulong ResizeWidth;
		public ulong ResizeHeight;
		public ResizeQuality ResizeQuality;
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct FrameRequestCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface AnimationFrameProvider
{
		public ulong RequestAnimationFrame(FrameRequestCallback callback) { throw new System.NotImplementedException(); }
		public Undefined CancelAnimationFrame(ulong handle) { throw new System.NotImplementedException(); }
}



///<include file='Utils/Docs/MessageEvent/MessageEvent.generated.xml' path='docs/MessageEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MessageEvent : Event
{
	///<include file='Utils/Docs/MessageEventMessageEvent/MessageEventMessageEvent.generated.xml' path='docs/MessageEventMessageEvent/*'/>
	public MessageEvent(string type, MessageEventInit eventInitDict) { }
	///<include file='Utils/Docs/MessageEventData/MessageEventData.generated.xml' path='docs/MessageEventData/*'/>
	public dynamic Data { get; }
	///<include file='Utils/Docs/MessageEventOrigin/MessageEventOrigin.generated.xml' path='docs/MessageEventOrigin/*'/>
	public string Origin { get; }
	///<include file='Utils/Docs/MessageEventLastEventId/MessageEventLastEventId.generated.xml' path='docs/MessageEventLastEventId/*'/>
	public string LastEventId { get; }
	///<include file='Utils/Docs/MessageEventSource/MessageEventSource.generated.xml' path='docs/MessageEventSource/*'/>
	public MessageEventSource? Source { get; }
	///<include file='Utils/Docs/MessageEventPorts/MessageEventPorts.generated.xml' path='docs/MessageEventPorts/*'/>
	public MessagePort[] Ports { get; }
		public Undefined InitMessageEvent(string type, bool bubbles, bool cancelable, dynamic data, string origin, string lastEventId, MessageEventSource? source, List<MessagePort> ports) { throw new System.NotImplementedException(); }
	public MessageEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MessageEventInit : EventInit
{
		public dynamic Data;
		public string Origin;
		public string LastEventId;
		public MessageEventSource? Source;
		public List<MessagePort> Ports;
}


///<include file='Utils/Docs/EventSource/EventSource.generated.xml' path='docs/EventSource/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class EventSource : EventTarget
{
	///<include file='Utils/Docs/EventSourceEventSource/EventSourceEventSource.generated.xml' path='docs/EventSourceEventSource/*'/>
	public EventSource(string url, EventSourceInit eventSourceInitDict) { }
	///<include file='Utils/Docs/EventSourceUrl/EventSourceUrl.generated.xml' path='docs/EventSourceUrl/*'/>
	public string Url { get; }
	///<include file='Utils/Docs/EventSourceWithCredentials/EventSourceWithCredentials.generated.xml' path='docs/EventSourceWithCredentials/*'/>
	public bool WithCredentials { get; }
		public const ushort CONNECTING = 0;
		public const ushort OPEN = 1;
		public const ushort CLOSED = 2;
	///<include file='Utils/Docs/EventSourceReadyState/EventSourceReadyState.generated.xml' path='docs/EventSourceReadyState/*'/>
	public ushort ReadyState { get; }
		public EventHandler Onopen { get; set; }
		public EventHandler Onmessage { get; set; }
		public EventHandler Onerror { get; set; }
	///<include file='Utils/Docs/EventSourceClose/EventSourceClose.generated.xml' path='docs/EventSourceClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
	public EventSource() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class EventSourceInit
{
		public bool WithCredentials;
}

///<include file='Utils/Docs/MessageChannel/MessageChannel.generated.xml' path='docs/MessageChannel/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MessageChannel
{
	///<include file='Utils/Docs/MessageChannelMessageChannel/MessageChannelMessageChannel.generated.xml' path='docs/MessageChannelMessageChannel/*'/>
	public MessageChannel() { }
	///<include file='Utils/Docs/MessageChannelPort1/MessageChannelPort1.generated.xml' path='docs/MessageChannelPort1/*'/>
	public MessagePort Port1 { get; }
	///<include file='Utils/Docs/MessageChannelPort2/MessageChannelPort2.generated.xml' path='docs/MessageChannelPort2/*'/>
	public MessagePort Port2 { get; }
}

///<include file='Utils/Docs/MessagePort/MessagePort.generated.xml' path='docs/MessagePort/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MessagePort : EventTarget
{
	///<include file='Utils/Docs/MessagePortPostMessage/MessagePortPostMessage.generated.xml' path='docs/MessagePortPostMessage/*'/>
	public Undefined PostMessage(dynamic message, List<object> transfer) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MessagePortPostMessage/MessagePortPostMessage.generated.xml' path='docs/MessagePortPostMessage/*'/>
	public Undefined PostMessage(dynamic message, StructuredSerializeOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MessagePortStart/MessagePortStart.generated.xml' path='docs/MessagePortStart/*'/>
	public Undefined Start() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MessagePortClose/MessagePortClose.generated.xml' path='docs/MessagePortClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
		public EventHandler Onmessage { get; set; }
		public EventHandler Onmessageerror { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class StructuredSerializeOptions
{
		public List<object> Transfer;
}

///<include file='Utils/Docs/BroadcastChannel/BroadcastChannel.generated.xml' path='docs/BroadcastChannel/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class BroadcastChannel : EventTarget
{
	///<include file='Utils/Docs/BroadcastChannelBroadcastChannel/BroadcastChannelBroadcastChannel.generated.xml' path='docs/BroadcastChannelBroadcastChannel/*'/>
	public BroadcastChannel(string name) { }
	///<include file='Utils/Docs/BroadcastChannelName/BroadcastChannelName.generated.xml' path='docs/BroadcastChannelName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs/BroadcastChannelPostMessage/BroadcastChannelPostMessage.generated.xml' path='docs/BroadcastChannelPostMessage/*'/>
	public Undefined PostMessage(dynamic message) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BroadcastChannelClose/BroadcastChannelClose.generated.xml' path='docs/BroadcastChannelClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
		public EventHandler Onmessage { get; set; }
		public EventHandler Onmessageerror { get; set; }
	public BroadcastChannel() { }
}

///<include file='Utils/Docs/WorkerGlobalScope/WorkerGlobalScope.generated.xml' path='docs/WorkerGlobalScope/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WorkerGlobalScope : EventTarget, WindowOrWorkerGlobalScope, FontFaceSource
{
	///<include file='Utils/Docs/WorkerGlobalScopeSelf/WorkerGlobalScopeSelf.generated.xml' path='docs/WorkerGlobalScopeSelf/*'/>
	public WorkerGlobalScope Self { get; }
	///<include file='Utils/Docs/WorkerGlobalScopeLocation/WorkerGlobalScopeLocation.generated.xml' path='docs/WorkerGlobalScopeLocation/*'/>
	public WorkerLocation Location { get; }
	///<include file='Utils/Docs/WorkerGlobalScopeNavigator/WorkerGlobalScopeNavigator.generated.xml' path='docs/WorkerGlobalScopeNavigator/*'/>
	public WorkerNavigator Navigator { get; }
	///<include file='Utils/Docs/WorkerGlobalScopeImportScripts/WorkerGlobalScopeImportScripts.generated.xml' path='docs/WorkerGlobalScopeImportScripts/*'/>
	public Undefined ImportScripts(params string[] urls) { throw new System.NotImplementedException(); }
		public OnErrorEventHandler Onerror { get; set; }
		public EventHandler Onlanguagechange { get; set; }
		public EventHandler Onoffline { get; set; }
		public EventHandler Ononline { get; set; }
		public EventHandler Onrejectionhandled { get; set; }
		public EventHandler Onunhandledrejection { get; set; }
}

///<include file='Utils/Docs/DedicatedWorkerGlobalScope/DedicatedWorkerGlobalScope.generated.xml' path='docs/DedicatedWorkerGlobalScope/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DedicatedWorkerGlobalScope : WorkerGlobalScope, AnimationFrameProvider
{
	///<include file='Utils/Docs/DedicatedWorkerGlobalScopeName/DedicatedWorkerGlobalScopeName.generated.xml' path='docs/DedicatedWorkerGlobalScopeName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs/DedicatedWorkerGlobalScopePostMessage/DedicatedWorkerGlobalScopePostMessage.generated.xml' path='docs/DedicatedWorkerGlobalScopePostMessage/*'/>
	public Undefined PostMessage(dynamic message, List<object> transfer) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DedicatedWorkerGlobalScopePostMessage/DedicatedWorkerGlobalScopePostMessage.generated.xml' path='docs/DedicatedWorkerGlobalScopePostMessage/*'/>
	public Undefined PostMessage(dynamic message, StructuredSerializeOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DedicatedWorkerGlobalScopeClose/DedicatedWorkerGlobalScopeClose.generated.xml' path='docs/DedicatedWorkerGlobalScopeClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
		public EventHandler Onmessage { get; set; }
		public EventHandler Onmessageerror { get; set; }
}

///<include file='Utils/Docs/SharedWorkerGlobalScope/SharedWorkerGlobalScope.generated.xml' path='docs/SharedWorkerGlobalScope/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SharedWorkerGlobalScope : WorkerGlobalScope
{
	///<include file='Utils/Docs/SharedWorkerGlobalScopeName/SharedWorkerGlobalScopeName.generated.xml' path='docs/SharedWorkerGlobalScopeName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs/SharedWorkerGlobalScopeClose/SharedWorkerGlobalScopeClose.generated.xml' path='docs/SharedWorkerGlobalScopeClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
		public EventHandler Onconnect { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface AbstractWorker
{
		public EventHandler Onerror { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/Worker/Worker.generated.xml' path='docs/Worker/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Worker : EventTarget, AbstractWorker
{
	///<include file='Utils/Docs/WorkerWorker/WorkerWorker.generated.xml' path='docs/WorkerWorker/*'/>
	public Worker(string scriptURL, WorkerOptions options) { }
	///<include file='Utils/Docs/WorkerTerminate/WorkerTerminate.generated.xml' path='docs/WorkerTerminate/*'/>
	public Undefined Terminate() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WorkerPostMessage/WorkerPostMessage.generated.xml' path='docs/WorkerPostMessage/*'/>
	public Undefined PostMessage(dynamic message, List<object> transfer) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WorkerPostMessage/WorkerPostMessage.generated.xml' path='docs/WorkerPostMessage/*'/>
	public Undefined PostMessage(dynamic message, StructuredSerializeOptions options) { throw new System.NotImplementedException(); }
		public EventHandler Onmessage { get; set; }
		public EventHandler Onmessageerror { get; set; }
	public Worker() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WorkerOptions
{
		public WorkerType Type;
		public RequestCredentials Credentials;
		public string Name;
}

public enum WorkerType
{
	Classic,
	Module,
}


///<include file='Utils/Docs/SharedWorker/SharedWorker.generated.xml' path='docs/SharedWorker/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SharedWorker : EventTarget, AbstractWorker
{
	///<include file='Utils/Docs/SharedWorkerSharedWorker/SharedWorkerSharedWorker.generated.xml' path='docs/SharedWorkerSharedWorker/*'/>
	public SharedWorker(string scriptURL, Union31 options) { }
	///<include file='Utils/Docs/SharedWorkerPort/SharedWorkerPort.generated.xml' path='docs/SharedWorkerPort/*'/>
	public MessagePort Port { get; }
	public SharedWorker() { }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorConcurrentHardware
{
		public ulong HardwareConcurrency { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/WorkerNavigator/WorkerNavigator.generated.xml' path='docs/WorkerNavigator/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WorkerNavigator
{
}





///<include file='Utils/Docs/WorkerLocation/WorkerLocation.generated.xml' path='docs/WorkerLocation/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WorkerLocation
{
	///<include file='Utils/Docs/WorkerLocationHref/WorkerLocationHref.generated.xml' path='docs/WorkerLocationHref/*'/>
	public string Href { get; }
	///<include file='Utils/Docs/WorkerLocationOrigin/WorkerLocationOrigin.generated.xml' path='docs/WorkerLocationOrigin/*'/>
	public string Origin { get; }
	///<include file='Utils/Docs/WorkerLocationProtocol/WorkerLocationProtocol.generated.xml' path='docs/WorkerLocationProtocol/*'/>
	public string Protocol { get; }
	///<include file='Utils/Docs/WorkerLocationHost/WorkerLocationHost.generated.xml' path='docs/WorkerLocationHost/*'/>
	public string Host { get; }
	///<include file='Utils/Docs/WorkerLocationHostname/WorkerLocationHostname.generated.xml' path='docs/WorkerLocationHostname/*'/>
	public string Hostname { get; }
	///<include file='Utils/Docs/WorkerLocationPort/WorkerLocationPort.generated.xml' path='docs/WorkerLocationPort/*'/>
	public string Port { get; }
	///<include file='Utils/Docs/WorkerLocationPathname/WorkerLocationPathname.generated.xml' path='docs/WorkerLocationPathname/*'/>
	public string Pathname { get; }
	///<include file='Utils/Docs/WorkerLocationSearch/WorkerLocationSearch.generated.xml' path='docs/WorkerLocationSearch/*'/>
	public string Search { get; }
	///<include file='Utils/Docs/WorkerLocationHash/WorkerLocationHash.generated.xml' path='docs/WorkerLocationHash/*'/>
	public string Hash { get; }
}

///<include file='Utils/Docs/WorkletGlobalScope/WorkletGlobalScope.generated.xml' path='docs/WorkletGlobalScope/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WorkletGlobalScope
{
}

///<include file='Utils/Docs/Worklet/Worklet.generated.xml' path='docs/Worklet/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Worklet
{
	///<include file='Utils/Docs/WorkletAddModule/WorkletAddModule.generated.xml' path='docs/WorkletAddModule/*'/>
	public Task<Undefined> AddModule(string moduleURL, WorkletOptions options) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WorkletOptions
{
		public RequestCredentials Credentials;
}

///<include file='Utils/Docs/Storage/Storage.generated.xml' path='docs/Storage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Storage
{
	///<include file='Utils/Docs/StorageLength/StorageLength.generated.xml' path='docs/StorageLength/*'/>
	public ulong Length { get; }
	///<include file='Utils/Docs/StorageKey/StorageKey.generated.xml' path='docs/StorageKey/*'/>
	public string? Key(ulong index) { throw new System.NotImplementedException(); }
	
	
	
	///<include file='Utils/Docs/StorageClear/StorageClear.generated.xml' path='docs/StorageClear/*'/>
	public Undefined Clear() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/WindowSessionStorage/WindowSessionStorage.generated.xml' path='docs/WindowSessionStorage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface WindowSessionStorage
{
		public Storage SessionStorage { get { throw new System.NotImplementedException(); } }
}


///<include file='Utils/Docs/WindowLocalStorage/WindowLocalStorage.generated.xml' path='docs/WindowLocalStorage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface WindowLocalStorage
{
		public Storage LocalStorage { get { throw new System.NotImplementedException(); } }
}


///<include file='Utils/Docs/StorageEvent/StorageEvent.generated.xml' path='docs/StorageEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class StorageEvent : Event
{
		public StorageEvent(string type, StorageEventInit eventInitDict) { }
		public string? Key { get; }
		public string? OldValue { get; }
		public string? NewValue { get; }
		public string Url { get; }
		public Storage? StorageArea { get; }
	///<include file='Utils/Docs/StorageEventInitStorageEvent/StorageEventInitStorageEvent.generated.xml' path='docs/StorageEventInitStorageEvent/*'/>
	public Undefined InitStorageEvent(string type, bool bubbles, bool cancelable, string? key, string? oldValue, string? newValue, string url, Storage? storageArea) { throw new System.NotImplementedException(); }
	public StorageEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class StorageEventInit : EventInit
{
		public string? Key;
		public string? OldValue;
		public string? NewValue;
		public string Url;
		public Storage? StorageArea;
}

///<include file='Utils/Docs/HTMLMarqueeElement/HTMLMarqueeElement.generated.xml' path='docs/HTMLMarqueeElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLMarqueeElement : HTMLElement
{
		public HTMLMarqueeElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Behavior { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string BgColor { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Direction { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Height { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Hspace { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public long Loop { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong ScrollAmount { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong ScrollDelay { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool TrueSpeed { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Vspace { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Width { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Start() { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Stop() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLFrameSetElement/HTMLFrameSetElement.generated.xml' path='docs/HTMLFrameSetElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLFrameSetElement : HTMLElement, WindowEventHandlers
{
		public HTMLFrameSetElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Cols { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Rows { get; set; }
}


[To(ToAttribute.Default)]
public partial class HTMLFrameElement : HTMLElement
{
		public HTMLFrameElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Scrolling { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string FrameBorder { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string LongDesc { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool NoResize { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Document? ContentDocument { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public WindowProxy? ContentWindow { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string MarginHeight { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string MarginWidth { get; set; }
}

///<include file='Utils/Docs/HTMLAnchorElement/HTMLAnchorElement.generated.xml' path='docs/HTMLAnchorElement/*'/>
public partial class HTMLAnchorElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Coords { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Charset { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Rev { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Shape { get; set; }
}

///<include file='Utils/Docs/HTMLAreaElement/HTMLAreaElement.generated.xml' path='docs/HTMLAreaElement/*'/>
public partial class HTMLAreaElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool NoHref { get; set; }
}

///<include file='Utils/Docs/HTMLBodyElement/HTMLBodyElement.generated.xml' path='docs/HTMLBodyElement/*'/>
public partial class HTMLBodyElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Text { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Link { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string VLink { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string ALink { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string BgColor { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Background { get; set; }
}

///<include file='Utils/Docs/HTMLBRElement/HTMLBRElement.generated.xml' path='docs/HTMLBRElement/*'/>
public partial class HTMLBRElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Clear { get; set; }
}

///<include file='Utils/Docs/HTMLTableCaptionElement/HTMLTableCaptionElement.generated.xml' path='docs/HTMLTableCaptionElement/*'/>
public partial class HTMLTableCaptionElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Align { get; set; }
}

///<include file='Utils/Docs/HTMLTableColElement/HTMLTableColElement.generated.xml' path='docs/HTMLTableColElement/*'/>
public partial class HTMLTableColElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Align { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Ch { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string ChOff { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string VAlign { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Width { get; set; }
}

[To(ToAttribute.Default)]
public partial class HTMLDirectoryElement : HTMLElement
{
		public HTMLDirectoryElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Compact { get; set; }
}

///<include file='Utils/Docs/HTMLDivElement/HTMLDivElement.generated.xml' path='docs/HTMLDivElement/*'/>
public partial class HTMLDivElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Align { get; set; }
}

///<include file='Utils/Docs/HTMLDListElement/HTMLDListElement.generated.xml' path='docs/HTMLDListElement/*'/>
public partial class HTMLDListElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Compact { get; set; }
}

///<include file='Utils/Docs/HTMLEmbedElement/HTMLEmbedElement.generated.xml' path='docs/HTMLEmbedElement/*'/>
public partial class HTMLEmbedElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Align { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
}

///<include file='Utils/Docs/HTMLFontElement/HTMLFontElement.generated.xml' path='docs/HTMLFontElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLFontElement : HTMLElement
{
		public HTMLFontElement() { }
	///<include file='Utils/Docs/HTMLFontElementColor/HTMLFontElementColor.generated.xml' path='docs/HTMLFontElementColor/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Color { get; set; }
	///<include file='Utils/Docs/HTMLFontElementFace/HTMLFontElementFace.generated.xml' path='docs/HTMLFontElementFace/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Face { get; set; }
	///<include file='Utils/Docs/HTMLFontElementSize/HTMLFontElementSize.generated.xml' path='docs/HTMLFontElementSize/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Size { get; set; }
}

///<include file='Utils/Docs/HTMLHeadingElement/HTMLHeadingElement.generated.xml' path='docs/HTMLHeadingElement/*'/>
public partial class HTMLHeadingElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Align { get; set; }
}

///<include file='Utils/Docs/HTMLHRElement/HTMLHRElement.generated.xml' path='docs/HTMLHRElement/*'/>
public partial class HTMLHRElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Align { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Color { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool NoShade { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Size { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Width { get; set; }
}

///<include file='Utils/Docs/HTMLHtmlElement/HTMLHtmlElement.generated.xml' path='docs/HTMLHtmlElement/*'/>
public partial class HTMLHtmlElement
{
	///<include file='Utils/Docs/HTMLHtmlElementVersion/HTMLHtmlElementVersion.generated.xml' path='docs/HTMLHtmlElementVersion/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Version { get; set; }
}

///<include file='Utils/Docs/HTMLIFrameElement/HTMLIFrameElement.generated.xml' path='docs/HTMLIFrameElement/*'/>
public partial class HTMLIFrameElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Align { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Scrolling { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string FrameBorder { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string LongDesc { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string MarginHeight { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string MarginWidth { get; set; }
}

///<include file='Utils/Docs/HTMLImageElement/HTMLImageElement.generated.xml' path='docs/HTMLImageElement/*'/>
public partial class HTMLImageElement
{
	///<include file='Utils/Docs/HTMLImageElementName/HTMLImageElementName.generated.xml' path='docs/HTMLImageElementName/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Lowsrc { get; set; }
	///<include file='Utils/Docs/HTMLImageElementAlign/HTMLImageElementAlign.generated.xml' path='docs/HTMLImageElementAlign/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Align { get; set; }
	///<include file='Utils/Docs/HTMLImageElementHspace/HTMLImageElementHspace.generated.xml' path='docs/HTMLImageElementHspace/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Hspace { get; set; }
	///<include file='Utils/Docs/HTMLImageElementVspace/HTMLImageElementVspace.generated.xml' path='docs/HTMLImageElementVspace/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Vspace { get; set; }
	///<include file='Utils/Docs/HTMLImageElementLongDesc/HTMLImageElementLongDesc.generated.xml' path='docs/HTMLImageElementLongDesc/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string LongDesc { get; set; }
	///<include file='Utils/Docs/HTMLImageElementBorder/HTMLImageElementBorder.generated.xml' path='docs/HTMLImageElementBorder/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Border { get; set; }
}

///<include file='Utils/Docs/HTMLInputElement/HTMLInputElement.generated.xml' path='docs/HTMLInputElement/*'/>
public partial class HTMLInputElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Align { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string UseMap { get; set; }
}

///<include file='Utils/Docs/HTMLLegendElement/HTMLLegendElement.generated.xml' path='docs/HTMLLegendElement/*'/>
public partial class HTMLLegendElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Align { get; set; }
}

///<include file='Utils/Docs/HTMLLIElement/HTMLLIElement.generated.xml' path='docs/HTMLLIElement/*'/>
public partial class HTMLLIElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
}

///<include file='Utils/Docs/HTMLLinkElement/HTMLLinkElement.generated.xml' path='docs/HTMLLinkElement/*'/>
public partial class HTMLLinkElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Charset { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Rev { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Target { get; set; }
}

///<include file='Utils/Docs/HTMLMenuElement/HTMLMenuElement.generated.xml' path='docs/HTMLMenuElement/*'/>
public partial class HTMLMenuElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Compact { get; set; }
}

///<include file='Utils/Docs/HTMLMetaElement/HTMLMetaElement.generated.xml' path='docs/HTMLMetaElement/*'/>
public partial class HTMLMetaElement
{
	///<include file='Utils/Docs/HTMLMetaElementScheme/HTMLMetaElementScheme.generated.xml' path='docs/HTMLMetaElementScheme/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Scheme { get; set; }
}

///<include file='Utils/Docs/HTMLObjectElement/HTMLObjectElement.generated.xml' path='docs/HTMLObjectElement/*'/>
public partial class HTMLObjectElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Align { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Archive { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Code { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Declare { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Hspace { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Standby { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Vspace { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string CodeBase { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string CodeType { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementUseMap/HTMLObjectElementUseMap.generated.xml' path='docs/HTMLObjectElementUseMap/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string UseMap { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Border { get; set; }
}

///<include file='Utils/Docs/HTMLOListElement/HTMLOListElement.generated.xml' path='docs/HTMLOListElement/*'/>
public partial class HTMLOListElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Compact { get; set; }
}

///<include file='Utils/Docs/HTMLParagraphElement/HTMLParagraphElement.generated.xml' path='docs/HTMLParagraphElement/*'/>
public partial class HTMLParagraphElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Align { get; set; }
}

///<include file='Utils/Docs/HTMLParamElement/HTMLParamElement.generated.xml' path='docs/HTMLParamElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLParamElement : HTMLElement
{
		public HTMLParamElement() { }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string ValueType { get; set; }
}

///<include file='Utils/Docs/HTMLPreElement/HTMLPreElement.generated.xml' path='docs/HTMLPreElement/*'/>
public partial class HTMLPreElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public long Width { get; set; }
}

///<include file='Utils/Docs/HTMLStyleElement/HTMLStyleElement.generated.xml' path='docs/HTMLStyleElement/*'/>
public partial class HTMLStyleElement
{
	///<include file='Utils/Docs/HTMLStyleElementType/HTMLStyleElementType.generated.xml' path='docs/HTMLStyleElementType/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
}

///<include file='Utils/Docs/HTMLScriptElement/HTMLScriptElement.generated.xml' path='docs/HTMLScriptElement/*'/>
public partial class HTMLScriptElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Charset { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Event { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string HtmlFor { get; set; }
}

///<include file='Utils/Docs/HTMLTableElement/HTMLTableElement.generated.xml' path='docs/HTMLTableElement/*'/>
public partial class HTMLTableElement
{
	///<include file='Utils/Docs/HTMLTableElementAlign/HTMLTableElementAlign.generated.xml' path='docs/HTMLTableElementAlign/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Align { get; set; }
	///<include file='Utils/Docs/HTMLTableElementBorder/HTMLTableElementBorder.generated.xml' path='docs/HTMLTableElementBorder/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Border { get; set; }
	///<include file='Utils/Docs/HTMLTableElementFrame/HTMLTableElementFrame.generated.xml' path='docs/HTMLTableElementFrame/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Frame { get; set; }
	///<include file='Utils/Docs/HTMLTableElementRules/HTMLTableElementRules.generated.xml' path='docs/HTMLTableElementRules/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Rules { get; set; }
	///<include file='Utils/Docs/HTMLTableElementSummary/HTMLTableElementSummary.generated.xml' path='docs/HTMLTableElementSummary/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Summary { get; set; }
	///<include file='Utils/Docs/HTMLTableElementWidth/HTMLTableElementWidth.generated.xml' path='docs/HTMLTableElementWidth/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Width { get; set; }
	///<include file='Utils/Docs/HTMLTableElementBgColor/HTMLTableElementBgColor.generated.xml' path='docs/HTMLTableElementBgColor/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string BgColor { get; set; }
	///<include file='Utils/Docs/HTMLTableElementCellPadding/HTMLTableElementCellPadding.generated.xml' path='docs/HTMLTableElementCellPadding/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string CellPadding { get; set; }
	///<include file='Utils/Docs/HTMLTableElementCellSpacing/HTMLTableElementCellSpacing.generated.xml' path='docs/HTMLTableElementCellSpacing/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string CellSpacing { get; set; }
}

///<include file='Utils/Docs/HTMLTableSectionElement/HTMLTableSectionElement.generated.xml' path='docs/HTMLTableSectionElement/*'/>
public partial class HTMLTableSectionElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Align { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Ch { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string ChOff { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string VAlign { get; set; }
}

///<include file='Utils/Docs/HTMLTableCellElement/HTMLTableCellElement.generated.xml' path='docs/HTMLTableCellElement/*'/>
public partial class HTMLTableCellElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Align { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Axis { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Height { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Width { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Ch { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string ChOff { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool NoWrap { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string VAlign { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string BgColor { get; set; }
}

///<include file='Utils/Docs/HTMLTableRowElement/HTMLTableRowElement.generated.xml' path='docs/HTMLTableRowElement/*'/>
public partial class HTMLTableRowElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Align { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Ch { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string ChOff { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string VAlign { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string BgColor { get; set; }
}

///<include file='Utils/Docs/HTMLUListElement/HTMLUListElement.generated.xml' path='docs/HTMLUListElement/*'/>
public partial class HTMLUListElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Compact { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
}

///<include file='Utils/Docs/Document/Document.generated.xml' path='docs/Document/*'/>
public partial class Document
{
	///<include file='Utils/Docs/DocumentFgColor/DocumentFgColor.generated.xml' path='docs/DocumentFgColor/*'/>
	public string FgColor { get; set; }
	///<include file='Utils/Docs/DocumentLinkColor/DocumentLinkColor.generated.xml' path='docs/DocumentLinkColor/*'/>
	public string LinkColor { get; set; }
	///<include file='Utils/Docs/DocumentVlinkColor/DocumentVlinkColor.generated.xml' path='docs/DocumentVlinkColor/*'/>
	public string VlinkColor { get; set; }
	///<include file='Utils/Docs/DocumentAlinkColor/DocumentAlinkColor.generated.xml' path='docs/DocumentAlinkColor/*'/>
	public string AlinkColor { get; set; }
	///<include file='Utils/Docs/DocumentBgColor/DocumentBgColor.generated.xml' path='docs/DocumentBgColor/*'/>
	public string BgColor { get; set; }
	///<include file='Utils/Docs/DocumentAnchors/DocumentAnchors.generated.xml' path='docs/DocumentAnchors/*'/>
	public HTMLCollection Anchors { get; }
	///<include file='Utils/Docs/DocumentApplets/DocumentApplets.generated.xml' path='docs/DocumentApplets/*'/>
	public HTMLCollection Applets { get; }
	///<include file='Utils/Docs/DocumentClear/DocumentClear.generated.xml' path='docs/DocumentClear/*'/>
	public Undefined Clear() { throw new System.NotImplementedException(); }
		public Undefined CaptureEvents() { throw new System.NotImplementedException(); }
		public Undefined ReleaseEvents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentAll/DocumentAll.generated.xml' path='docs/DocumentAll/*'/>
	public HTMLAllCollection All { get; }
}

///<include file='Utils/Docs/Window/Window.generated.xml' path='docs/Window/*'/>
public partial class Window
{
	///<include file='Utils/Docs/WindowCaptureEvents/WindowCaptureEvents.generated.xml' path='docs/WindowCaptureEvents/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined CaptureEvents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowReleaseEvents/WindowReleaseEvents.generated.xml' path='docs/WindowReleaseEvents/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined ReleaseEvents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowExternal/WindowExternal.generated.xml' path='docs/WindowExternal/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public External External { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class External
{
		public Undefined AddSearchProvider() { throw new System.NotImplementedException(); }
		public Undefined IsSearchProviderInstalled() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Accelerometer/Accelerometer.generated.xml' path='docs/Accelerometer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Accelerometer : Sensor
{
	///<include file='Utils/Docs/AccelerometerAccelerometer/AccelerometerAccelerometer.generated.xml' path='docs/AccelerometerAccelerometer/*'/>
	public Accelerometer(AccelerometerSensorOptions options) { }
	///<include file='Utils/Docs/AccelerometerX/AccelerometerX.generated.xml' path='docs/AccelerometerX/*'/>
	public Number? X { get; }
	///<include file='Utils/Docs/AccelerometerY/AccelerometerY.generated.xml' path='docs/AccelerometerY/*'/>
	public Number? Y { get; }
	///<include file='Utils/Docs/AccelerometerZ/AccelerometerZ.generated.xml' path='docs/AccelerometerZ/*'/>
	public Number? Z { get; }
	public Accelerometer() { }
}

public enum AccelerometerLocalCoordinateSystem
{
	Device,
	Screen,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AccelerometerSensorOptions : SensorOptions
{
		public AccelerometerLocalCoordinateSystem ReferenceFrame;
}

///<include file='Utils/Docs/LinearAccelerationSensor/LinearAccelerationSensor.generated.xml' path='docs/LinearAccelerationSensor/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class LinearAccelerationSensor : Accelerometer
{
	///<include file='Utils/Docs/LinearAccelerationSensorLinearAccelerationSensor/LinearAccelerationSensorLinearAccelerationSensor.generated.xml' path='docs/LinearAccelerationSensorLinearAccelerationSensor/*'/>
	public LinearAccelerationSensor(AccelerometerSensorOptions options) { }
	public LinearAccelerationSensor() { }
}

///<include file='Utils/Docs/GravitySensor/GravitySensor.generated.xml' path='docs/GravitySensor/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GravitySensor : Accelerometer
{
	///<include file='Utils/Docs/GravitySensorGravitySensor/GravitySensorGravitySensor.generated.xml' path='docs/GravitySensorGravitySensor/*'/>
	public GravitySensor(AccelerometerSensorOptions options) { }
	public GravitySensor() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AccelerometerReadingValues
{
		public required Number? X;
		public required Number? Y;
		public required Number? Z;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class LinearAccelerationReadingValues : AccelerometerReadingValues
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GravityReadingValues : AccelerometerReadingValues
{
}

///<include file='Utils/Docs/AmbientLightSensor/AmbientLightSensor.generated.xml' path='docs/AmbientLightSensor/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AmbientLightSensor : Sensor
{
	///<include file='Utils/Docs/AmbientLightSensorAmbientLightSensor/AmbientLightSensorAmbientLightSensor.generated.xml' path='docs/AmbientLightSensorAmbientLightSensor/*'/>
	public AmbientLightSensor(SensorOptions sensorOptions) { }
	///<include file='Utils/Docs/AmbientLightSensorIlluminance/AmbientLightSensorIlluminance.generated.xml' path='docs/AmbientLightSensorIlluminance/*'/>
	public Number? Illuminance { get; }
	public AmbientLightSensor() { }
}

public enum AutoplayPolicy
{
	Allowed,
	AllowedMuted,
	Disallowed,
}

public enum AutoplayPolicyMediaType
{
	Mediaelement,
	Audiocontext,
}

///<include file='Utils/Docs/Navigator/Navigator.generated.xml' path='docs/Navigator/*'/>
public partial class Navigator
{
	///<include file='Utils/Docs/NavigatorGetAutoplayPolicy/NavigatorGetAutoplayPolicy.generated.xml' path='docs/NavigatorGetAutoplayPolicy/*'/>
	public AutoplayPolicy GetAutoplayPolicy(AutoplayPolicyMediaType type) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NavigatorGetAutoplayPolicy/NavigatorGetAutoplayPolicy.generated.xml' path='docs/NavigatorGetAutoplayPolicy/*'/>
	public AutoplayPolicy GetAutoplayPolicy(HTMLMediaElement element) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NavigatorGetAutoplayPolicy/NavigatorGetAutoplayPolicy.generated.xml' path='docs/NavigatorGetAutoplayPolicy/*'/>
	public AutoplayPolicy GetAutoplayPolicy(AudioContext context) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ClipboardEventInit : EventInit
{
		public DataTransfer? ClipboardData;
}

///<include file='Utils/Docs/ClipboardEvent/ClipboardEvent.generated.xml' path='docs/ClipboardEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ClipboardEvent : Event
{
	///<include file='Utils/Docs/ClipboardEventClipboardEvent/ClipboardEventClipboardEvent.generated.xml' path='docs/ClipboardEventClipboardEvent/*'/>
	public ClipboardEvent(string type, ClipboardEventInit eventInitDict) { }
	///<include file='Utils/Docs/ClipboardEventClipboardData/ClipboardEventClipboardData.generated.xml' path='docs/ClipboardEventClipboardData/*'/>
	public DataTransfer? ClipboardData { get; }
	public ClipboardEvent() { }
}

///<include file='Utils/Docs/Navigator/Navigator.generated.xml' path='docs/Navigator/*'/>
public partial class Navigator
{
	///<include file='Utils/Docs/NavigatorClipboard/NavigatorClipboard.generated.xml' path='docs/NavigatorClipboard/*'/>
	public Clipboard Clipboard { get; }
}


///<include file='Utils/Docs/ClipboardItem/ClipboardItem.generated.xml' path='docs/ClipboardItem/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ClipboardItem
{
	///<include file='Utils/Docs/ClipboardItemClipboardItem/ClipboardItemClipboardItem.generated.xml' path='docs/ClipboardItemClipboardItem/*'/>
	public ClipboardItem(Dictionary<string, ClipboardItemData> items, ClipboardItemOptions options) { }
	///<include file='Utils/Docs/ClipboardItemPresentationStyle/ClipboardItemPresentationStyle.generated.xml' path='docs/ClipboardItemPresentationStyle/*'/>
	public PresentationStyle PresentationStyle { get; }
	///<include file='Utils/Docs/ClipboardItemTypes/ClipboardItemTypes.generated.xml' path='docs/ClipboardItemTypes/*'/>
	public string[] Types { get; }
	///<include file='Utils/Docs/ClipboardItemGetType/ClipboardItemGetType.generated.xml' path='docs/ClipboardItemGetType/*'/>
	public Task<Blob> GetType(string type) { throw new System.NotImplementedException(); }
	public ClipboardItem() { }
}

public enum PresentationStyle
{
	Unspecified,
	Inline,
	Attachment,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ClipboardItemOptions
{
		public PresentationStyle PresentationStyle;
}


///<include file='Utils/Docs/Clipboard/Clipboard.generated.xml' path='docs/Clipboard/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Clipboard : EventTarget
{
	///<include file='Utils/Docs/ClipboardRead/ClipboardRead.generated.xml' path='docs/ClipboardRead/*'/>
	public Task<ClipboardItems> Read() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ClipboardReadText/ClipboardReadText.generated.xml' path='docs/ClipboardReadText/*'/>
	public Task<string> ReadText() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ClipboardWrite/ClipboardWrite.generated.xml' path='docs/ClipboardWrite/*'/>
	public Task<Undefined> Write(ClipboardItems data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ClipboardWriteText/ClipboardWriteText.generated.xml' path='docs/ClipboardWriteText/*'/>
	public Task<Undefined> WriteText(string data) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ClipboardPermissionDescriptor
{
		public bool AllowWithoutGesture;
}

///<include file='Utils/Docs/Navigator/Navigator.generated.xml' path='docs/Navigator/*'/>
public partial class Navigator
{
	///<include file='Utils/Docs/NavigatorContacts/NavigatorContacts.generated.xml' path='docs/NavigatorContacts/*'/>
	public ContactsManager Contacts { get; }
}

public enum ContactProperty
{
	Address,
	Email,
	Icon,
	Name,
	Tel,
}

///<include file='Utils/Docs/ContactAddress/ContactAddress.generated.xml' path='docs/ContactAddress/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ContactAddress
{
		public object ToJSON() { throw new System.NotImplementedException(); }
		public string City { get; }
		public string Country { get; }
		public string DependentLocality { get; }
		public string Organization { get; }
		public string Phone { get; }
		public string PostalCode { get; }
		public string Recipient { get; }
		public string Region { get; }
		public string SortingCode { get; }
		public string[] AddressLine { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ContactInfo
{
		public List<ContactAddress> Address;
		public List<string> Email;
		public List<Blob> Icon;
		public List<string> Name;
		public List<string> Tel;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ContactsSelectOptions
{
		public bool Multiple;
}

///<include file='Utils/Docs/ContactsManager/ContactsManager.generated.xml' path='docs/ContactsManager/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ContactsManager
{
	///<include file='Utils/Docs/ContactsManagerGetProperties/ContactsManagerGetProperties.generated.xml' path='docs/ContactsManagerGetProperties/*'/>
	public Task<List<ContactProperty>> GetProperties() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ContactsManagerSelect/ContactsManagerSelect.generated.xml' path='docs/ContactsManagerSelect/*'/>
	public Task<List<ContactInfo>> Select(List<ContactProperty> properties, ContactsSelectOptions options) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLIFrameElement/HTMLIFrameElement.generated.xml' path='docs/HTMLIFrameElement/*'/>
public partial class HTMLIFrameElement
{
	///<include file='Utils/Docs/HTMLIFrameElementCsp/HTMLIFrameElementCsp.generated.xml' path='docs/HTMLIFrameElementCsp/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Csp { get; set; }
}

///<include file='Utils/Docs/CSPViolationReportBody/CSPViolationReportBody.generated.xml' path='docs/CSPViolationReportBody/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSPViolationReportBody : ReportBody
{
		public object ToJSON() { throw new System.NotImplementedException(); }
		public string DocumentURL { get; }
		public string? Referrer { get; }
		public string? BlockedURL { get; }
		public string EffectiveDirective { get; }
		public string OriginalPolicy { get; }
		public string? SourceFile { get; }
		public string? Sample { get; }
		public SecurityPolicyViolationEventDisposition Disposition { get; }
		public ushort StatusCode { get; }
		public ulong? LineNumber { get; }
		public ulong? ColumnNumber { get; }
}

///<include file='Utils/Docs/SecurityPolicyViolationEventDisposition/SecurityPolicyViolationEventDisposition.generated.xml' path='docs/SecurityPolicyViolationEventDisposition/*'/>
public enum SecurityPolicyViolationEventDisposition
{
	Enforce,
	Report,
}

///<include file='Utils/Docs/SecurityPolicyViolationEvent/SecurityPolicyViolationEvent.generated.xml' path='docs/SecurityPolicyViolationEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SecurityPolicyViolationEvent : Event
{
	///<include file='Utils/Docs/SecurityPolicyViolationEventSecurityPolicyViolationEvent/SecurityPolicyViolationEventSecurityPolicyViolationEvent.generated.xml' path='docs/SecurityPolicyViolationEventSecurityPolicyViolationEvent/*'/>
	public SecurityPolicyViolationEvent(string type, SecurityPolicyViolationEventInit eventInitDict) { }
	///<include file='Utils/Docs/SecurityPolicyViolationEventDocumentURI/SecurityPolicyViolationEventDocumentURI.generated.xml' path='docs/SecurityPolicyViolationEventDocumentURI/*'/>
	public string DocumentURI { get; }
	///<include file='Utils/Docs/SecurityPolicyViolationEventReferrer/SecurityPolicyViolationEventReferrer.generated.xml' path='docs/SecurityPolicyViolationEventReferrer/*'/>
	public string Referrer { get; }
	///<include file='Utils/Docs/SecurityPolicyViolationEventBlockedURI/SecurityPolicyViolationEventBlockedURI.generated.xml' path='docs/SecurityPolicyViolationEventBlockedURI/*'/>
	public string BlockedURI { get; }
	///<include file='Utils/Docs/SecurityPolicyViolationEventEffectiveDirective/SecurityPolicyViolationEventEffectiveDirective.generated.xml' path='docs/SecurityPolicyViolationEventEffectiveDirective/*'/>
	public string EffectiveDirective { get; }
	///<include file='Utils/Docs/SecurityPolicyViolationEventViolatedDirective/SecurityPolicyViolationEventViolatedDirective.generated.xml' path='docs/SecurityPolicyViolationEventViolatedDirective/*'/>
	public string ViolatedDirective { get; }
	///<include file='Utils/Docs/SecurityPolicyViolationEventOriginalPolicy/SecurityPolicyViolationEventOriginalPolicy.generated.xml' path='docs/SecurityPolicyViolationEventOriginalPolicy/*'/>
	public string OriginalPolicy { get; }
	///<include file='Utils/Docs/SecurityPolicyViolationEventSourceFile/SecurityPolicyViolationEventSourceFile.generated.xml' path='docs/SecurityPolicyViolationEventSourceFile/*'/>
	public string SourceFile { get; }
	///<include file='Utils/Docs/SecurityPolicyViolationEventSample/SecurityPolicyViolationEventSample.generated.xml' path='docs/SecurityPolicyViolationEventSample/*'/>
	public string Sample { get; }
	///<include file='Utils/Docs/SecurityPolicyViolationEventDisposition/SecurityPolicyViolationEventDisposition.generated.xml' path='docs/SecurityPolicyViolationEventDisposition/*'/>
	public SecurityPolicyViolationEventDisposition Disposition { get; }
	///<include file='Utils/Docs/SecurityPolicyViolationEventStatusCode/SecurityPolicyViolationEventStatusCode.generated.xml' path='docs/SecurityPolicyViolationEventStatusCode/*'/>
	public ushort StatusCode { get; }
	///<include file='Utils/Docs/SecurityPolicyViolationEventLineNumber/SecurityPolicyViolationEventLineNumber.generated.xml' path='docs/SecurityPolicyViolationEventLineNumber/*'/>
	public ulong LineNumber { get; }
	///<include file='Utils/Docs/SecurityPolicyViolationEventColumnNumber/SecurityPolicyViolationEventColumnNumber.generated.xml' path='docs/SecurityPolicyViolationEventColumnNumber/*'/>
	public ulong ColumnNumber { get; }
	public SecurityPolicyViolationEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class SecurityPolicyViolationEventInit : EventInit
{
		public required string DocumentURI;
		public string Referrer;
		public string BlockedURI;
		public required string ViolatedDirective;
		public required string EffectiveDirective;
		public required string OriginalPolicy;
		public string SourceFile;
		public string Sample;
		public required SecurityPolicyViolationEventDisposition Disposition;
		public required ushort StatusCode;
		public ulong LineNumber;
		public ulong ColumnNumber;
}

///<include file='Utils/Docs/Credential/Credential.generated.xml' path='docs/Credential/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Credential
{
	///<include file='Utils/Docs/CredentialId/CredentialId.generated.xml' path='docs/CredentialId/*'/>
	public string Id { get; }
	///<include file='Utils/Docs/CredentialType/CredentialType.generated.xml' path='docs/CredentialType/*'/>
	public string Type { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CredentialUserData
{
		public string Name { get { throw new System.NotImplementedException(); } }
		public string IconURL { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/Navigator/Navigator.generated.xml' path='docs/Navigator/*'/>
public partial class Navigator
{
	///<include file='Utils/Docs/NavigatorCredentials/NavigatorCredentials.generated.xml' path='docs/NavigatorCredentials/*'/>
	public CredentialsContainer Credentials { get; }
}

///<include file='Utils/Docs/CredentialsContainer/CredentialsContainer.generated.xml' path='docs/CredentialsContainer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CredentialsContainer
{
	///<include file='Utils/Docs/CredentialsContainerGet/CredentialsContainerGet.generated.xml' path='docs/CredentialsContainerGet/*'/>
	public Task<Credential?> Get(CredentialRequestOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CredentialsContainerStore/CredentialsContainerStore.generated.xml' path='docs/CredentialsContainerStore/*'/>
	public Task<Credential> Store(Credential credential) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CredentialsContainerCreate/CredentialsContainerCreate.generated.xml' path='docs/CredentialsContainerCreate/*'/>
	public Task<Credential?> Create(CredentialCreationOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CredentialsContainerPreventSilentAccess/CredentialsContainerPreventSilentAccess.generated.xml' path='docs/CredentialsContainerPreventSilentAccess/*'/>
	public Task<Undefined> PreventSilentAccess() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CredentialData
{
		public required string Id;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CredentialRequestOptions
{
		public CredentialMediationRequirement Mediation;
		public AbortSignal Signal;
}

public enum CredentialMediationRequirement
{
	Silent,
	Optional,
	Required,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CredentialCreationOptions
{
		public AbortSignal Signal;
}

///<include file='Utils/Docs/PasswordCredential/PasswordCredential.generated.xml' path='docs/PasswordCredential/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PasswordCredential : Credential, CredentialUserData
{
	///<include file='Utils/Docs/PasswordCredentialPasswordCredential/PasswordCredentialPasswordCredential.generated.xml' path='docs/PasswordCredentialPasswordCredential/*'/>
	public PasswordCredential(HTMLFormElement form) { }
	///<include file='Utils/Docs/PasswordCredentialPasswordCredential/PasswordCredentialPasswordCredential.generated.xml' path='docs/PasswordCredentialPasswordCredential/*'/>
	public PasswordCredential(PasswordCredentialData data) { }
	///<include file='Utils/Docs/PasswordCredentialPassword/PasswordCredentialPassword.generated.xml' path='docs/PasswordCredentialPassword/*'/>
	public string Password { get; }
	public PasswordCredential() { }
}


public partial class CredentialRequestOptions
{
		public bool Password;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PasswordCredentialData : CredentialData
{
		public string Name;
		public string IconURL;
		public required string Origin;
		public required string Password;
}


public partial class CredentialCreationOptions
{
		public PasswordCredentialInit Password;
}

///<include file='Utils/Docs/FederatedCredential/FederatedCredential.generated.xml' path='docs/FederatedCredential/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FederatedCredential : Credential, CredentialUserData
{
	///<include file='Utils/Docs/FederatedCredentialFederatedCredential/FederatedCredentialFederatedCredential.generated.xml' path='docs/FederatedCredentialFederatedCredential/*'/>
	public FederatedCredential(FederatedCredentialInit data) { }
	///<include file='Utils/Docs/FederatedCredentialProvider/FederatedCredentialProvider.generated.xml' path='docs/FederatedCredentialProvider/*'/>
	public string Provider { get; }
	///<include file='Utils/Docs/FederatedCredentialProtocol/FederatedCredentialProtocol.generated.xml' path='docs/FederatedCredentialProtocol/*'/>
	public string? Protocol { get; }
	public FederatedCredential() { }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class FederatedCredentialRequestOptions
{
		public List<string> Providers;
		public List<string> Protocols;
}

public partial class CredentialRequestOptions
{
		public FederatedCredentialRequestOptions Federated;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FederatedCredentialInit : CredentialData
{
		public string Name;
		public string IconURL;
		public required string Origin;
		public required string Provider;
		public string Protocol;
}

public partial class CredentialCreationOptions
{
		public FederatedCredentialInit Federated;
}

///<include file='Utils/Docs/CSSAnimation/CSSAnimation.generated.xml' path='docs/CSSAnimation/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSAnimation : Animation
{
	///<include file='Utils/Docs/CSSAnimationAnimationName/CSSAnimationAnimationName.generated.xml' path='docs/CSSAnimationAnimationName/*'/>
	public Unsupported /*CSSOMString*/ AnimationName { get; }
}

///<include file='Utils/Docs/CSS/CSS.generated.xml' path='docs/CSS/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSS
{
		public Worklet AnimationWorklet { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class StatelessAnimator
{
		public StatelessAnimator(dynamic options) { }
	public StatelessAnimator() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class StatefulAnimator
{
		public StatefulAnimator(dynamic options, dynamic state) { }
		public dynamic State() { throw new System.NotImplementedException(); }
	public StatefulAnimator() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AnimationWorkletGlobalScope : WorkletGlobalScope
{
		public Undefined RegisterAnimator(string name, AnimatorInstanceConstructor animatorCtor) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct AnimatorInstanceConstructor
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WorkletAnimation : Animation
{
		public WorkletAnimation(string animatorName, Union33? effects, AnimationTimeline? timeline, dynamic options) { }
		public string AnimatorName { get; }
	public WorkletAnimation() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WorkletGroupEffect
{
		public List<AnimationEffect> GetChildren() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/AnimationEffect/AnimationEffect.generated.xml' path='docs/AnimationEffect/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AnimationEffect
{
		public Number LocalTime { get; set; }
}

///<include file='Utils/Docs/CSSContainerRule/CSSContainerRule.generated.xml' path='docs/CSSContainerRule/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSContainerRule
{
}

///<include file='Utils/Docs/CSSRule/CSSRule.generated.xml' path='docs/CSSRule/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSRule
{
		public const ushort COUNTER_STYLE_RULE = 11;
}

///<include file='Utils/Docs/CSSCounterStyleRule/CSSCounterStyleRule.generated.xml' path='docs/CSSCounterStyleRule/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSCounterStyleRule : CSSRule
{
	///<include file='Utils/Docs/CSSCounterStyleRuleName/CSSCounterStyleRuleName.generated.xml' path='docs/CSSCounterStyleRuleName/*'/>
	public Unsupported /*CSSOMString*/ Name { get; set; }
	///<include file='Utils/Docs/CSSCounterStyleRuleSystem/CSSCounterStyleRuleSystem.generated.xml' path='docs/CSSCounterStyleRuleSystem/*'/>
	public Unsupported /*CSSOMString*/ System { get; set; }
	///<include file='Utils/Docs/CSSCounterStyleRuleSymbols/CSSCounterStyleRuleSymbols.generated.xml' path='docs/CSSCounterStyleRuleSymbols/*'/>
	public Unsupported /*CSSOMString*/ Symbols { get; set; }
	///<include file='Utils/Docs/CSSCounterStyleRuleAdditiveSymbols/CSSCounterStyleRuleAdditiveSymbols.generated.xml' path='docs/CSSCounterStyleRuleAdditiveSymbols/*'/>
	public Unsupported /*CSSOMString*/ AdditiveSymbols { get; set; }
	///<include file='Utils/Docs/CSSCounterStyleRuleNegative/CSSCounterStyleRuleNegative.generated.xml' path='docs/CSSCounterStyleRuleNegative/*'/>
	public Unsupported /*CSSOMString*/ Negative { get; set; }
	///<include file='Utils/Docs/CSSCounterStyleRulePrefix/CSSCounterStyleRulePrefix.generated.xml' path='docs/CSSCounterStyleRulePrefix/*'/>
	public Unsupported /*CSSOMString*/ Prefix { get; set; }
	///<include file='Utils/Docs/CSSCounterStyleRuleSuffix/CSSCounterStyleRuleSuffix.generated.xml' path='docs/CSSCounterStyleRuleSuffix/*'/>
	public Unsupported /*CSSOMString*/ Suffix { get; set; }
	///<include file='Utils/Docs/CSSCounterStyleRuleRange/CSSCounterStyleRuleRange.generated.xml' path='docs/CSSCounterStyleRuleRange/*'/>
	public Unsupported /*CSSOMString*/ Range { get; set; }
	///<include file='Utils/Docs/CSSCounterStyleRulePad/CSSCounterStyleRulePad.generated.xml' path='docs/CSSCounterStyleRulePad/*'/>
	public Unsupported /*CSSOMString*/ Pad { get; set; }
	///<include file='Utils/Docs/CSSCounterStyleRuleSpeakAs/CSSCounterStyleRuleSpeakAs.generated.xml' path='docs/CSSCounterStyleRuleSpeakAs/*'/>
	public Unsupported /*CSSOMString*/ SpeakAs { get; set; }
	///<include file='Utils/Docs/CSSCounterStyleRuleFallback/CSSCounterStyleRuleFallback.generated.xml' path='docs/CSSCounterStyleRuleFallback/*'/>
	public Unsupported /*CSSOMString*/ Fallback { get; set; }
}

///<include file='Utils/Docs/HighlightType/HighlightType.generated.xml' path='docs/HighlightType/*'/>
public enum HighlightType
{
	Highlight,
	SpellingError,
	GrammarError,
}

///<include file='Utils/Docs/Highlight/Highlight.generated.xml' path='docs/Highlight/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Highlight
{
	///<include file='Utils/Docs/HighlightHighlight/HighlightHighlight.generated.xml' path='docs/HighlightHighlight/*'/>
	public Highlight(params AbstractRange[] initialRanges) { }
	
	///<include file='Utils/Docs/HighlightPriority/HighlightPriority.generated.xml' path='docs/HighlightPriority/*'/>
	public long Priority { get; set; }
	///<include file='Utils/Docs/HighlightType/HighlightType.generated.xml' path='docs/HighlightType/*'/>
	public HighlightType Type { get; set; }
	public Highlight() { }
}

///<include file='Utils/Docs/CSS/CSS.generated.xml' path='docs/CSS/*'/>
public partial class CSS
{
		public HighlightRegistry Highlights { get; }
}

///<include file='Utils/Docs/HighlightRegistry/HighlightRegistry.generated.xml' path='docs/HighlightRegistry/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class HighlightRegistry
{
	
}

///<include file='Utils/Docs/CSSRule/CSSRule.generated.xml' path='docs/CSSRule/*'/>
public partial class CSSRule
{
		public const ushort VIEWPORT_RULE = 15;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSViewportRule : CSSRule
{
		public CSSStyleDeclaration Style { get; }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class FontFaceDescriptors
{
		public Unsupported /*CSSOMString*/ Style;
		public Unsupported /*CSSOMString*/ Weight;
		public Unsupported /*CSSOMString*/ Stretch;
		public Unsupported /*CSSOMString*/ UnicodeRange;
		public Unsupported /*CSSOMString*/ Variant;
		public Unsupported /*CSSOMString*/ FeatureSettings;
		public Unsupported /*CSSOMString*/ VariationSettings;
		public Unsupported /*CSSOMString*/ Display;
		public Unsupported /*CSSOMString*/ AscentOverride;
		public Unsupported /*CSSOMString*/ DescentOverride;
		public Unsupported /*CSSOMString*/ LineGapOverride;
}

public enum FontFaceLoadStatus
{
	Unloaded,
	Loading,
	Loaded,
	Error,
}

///<include file='Utils/Docs/FontFace/FontFace.generated.xml' path='docs/FontFace/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FontFace
{
	///<include file='Utils/Docs/FontFaceFontFace/FontFaceFontFace.generated.xml' path='docs/FontFaceFontFace/*'/>
	public FontFace(Unsupported /*CSSOMString*/ family, Union35 source, FontFaceDescriptors descriptors) { }
	///<include file='Utils/Docs/FontFaceFamily/FontFaceFamily.generated.xml' path='docs/FontFaceFamily/*'/>
	public Unsupported /*CSSOMString*/ Family { get; set; }
	///<include file='Utils/Docs/FontFaceStyle/FontFaceStyle.generated.xml' path='docs/FontFaceStyle/*'/>
	public Unsupported /*CSSOMString*/ Style { get; set; }
	///<include file='Utils/Docs/FontFaceWeight/FontFaceWeight.generated.xml' path='docs/FontFaceWeight/*'/>
	public Unsupported /*CSSOMString*/ Weight { get; set; }
	///<include file='Utils/Docs/FontFaceStretch/FontFaceStretch.generated.xml' path='docs/FontFaceStretch/*'/>
	public Unsupported /*CSSOMString*/ Stretch { get; set; }
	///<include file='Utils/Docs/FontFaceUnicodeRange/FontFaceUnicodeRange.generated.xml' path='docs/FontFaceUnicodeRange/*'/>
	public Unsupported /*CSSOMString*/ UnicodeRange { get; set; }
	///<include file='Utils/Docs/FontFaceVariant/FontFaceVariant.generated.xml' path='docs/FontFaceVariant/*'/>
	public Unsupported /*CSSOMString*/ Variant { get; set; }
	///<include file='Utils/Docs/FontFaceFeatureSettings/FontFaceFeatureSettings.generated.xml' path='docs/FontFaceFeatureSettings/*'/>
	public Unsupported /*CSSOMString*/ FeatureSettings { get; set; }
	///<include file='Utils/Docs/FontFaceVariationSettings/FontFaceVariationSettings.generated.xml' path='docs/FontFaceVariationSettings/*'/>
	public Unsupported /*CSSOMString*/ VariationSettings { get; set; }
	///<include file='Utils/Docs/FontFaceDisplay/FontFaceDisplay.generated.xml' path='docs/FontFaceDisplay/*'/>
	public Unsupported /*CSSOMString*/ Display { get; set; }
	///<include file='Utils/Docs/FontFaceAscentOverride/FontFaceAscentOverride.generated.xml' path='docs/FontFaceAscentOverride/*'/>
	public Unsupported /*CSSOMString*/ AscentOverride { get; set; }
	///<include file='Utils/Docs/FontFaceDescentOverride/FontFaceDescentOverride.generated.xml' path='docs/FontFaceDescentOverride/*'/>
	public Unsupported /*CSSOMString*/ DescentOverride { get; set; }
	///<include file='Utils/Docs/FontFaceLineGapOverride/FontFaceLineGapOverride.generated.xml' path='docs/FontFaceLineGapOverride/*'/>
	public Unsupported /*CSSOMString*/ LineGapOverride { get; set; }
	///<include file='Utils/Docs/FontFaceStatus/FontFaceStatus.generated.xml' path='docs/FontFaceStatus/*'/>
	public FontFaceLoadStatus Status { get; }
	///<include file='Utils/Docs/FontFaceLoad/FontFaceLoad.generated.xml' path='docs/FontFaceLoad/*'/>
	public Task<FontFace> Load() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FontFaceLoaded/FontFaceLoaded.generated.xml' path='docs/FontFaceLoaded/*'/>
	public Task<FontFace> Loaded { get; }
	public FontFace() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FontFaceFeatures
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FontFaceVariationAxis
{
		public string Name { get; }
		public string AxisTag { get; }
		public Number MinimumValue { get; }
		public Number MaximumValue { get; }
		public Number DefaultValue { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FontFaceVariations
{
	
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FontFacePalette
{
	public string this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
		public ulong Length { get; }
	
		public bool UsableWithLightBackground { get; }
		public bool UsableWithDarkBackground { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FontFacePalettes
{
	public FontFacePalette this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
		public ulong Length { get; }
	
}

///<include file='Utils/Docs/FontFace/FontFace.generated.xml' path='docs/FontFace/*'/>
public partial class FontFace
{
		public FontFaceFeatures Features { get; }
		public FontFaceVariations Variations { get; }
		public FontFacePalettes Palettes { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FontFaceSetLoadEventInit : EventInit
{
		public List<FontFace> Fontfaces;
}

///<include file='Utils/Docs/FontFaceSetLoadEvent/FontFaceSetLoadEvent.generated.xml' path='docs/FontFaceSetLoadEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FontFaceSetLoadEvent : Event
{
	///<include file='Utils/Docs/FontFaceSetLoadEventFontFaceSetLoadEvent/FontFaceSetLoadEventFontFaceSetLoadEvent.generated.xml' path='docs/FontFaceSetLoadEventFontFaceSetLoadEvent/*'/>
	public FontFaceSetLoadEvent(Unsupported /*CSSOMString*/ type, FontFaceSetLoadEventInit eventInitDict) { }
	///<include file='Utils/Docs/FontFaceSetLoadEventFontfaces/FontFaceSetLoadEventFontfaces.generated.xml' path='docs/FontFaceSetLoadEventFontfaces/*'/>
	public FontFace[] Fontfaces { get; }
	public FontFaceSetLoadEvent() { }
}

public enum FontFaceSetLoadStatus
{
	Loading,
	Loaded,
}

///<include file='Utils/Docs/FontFaceSet/FontFaceSet.generated.xml' path='docs/FontFaceSet/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FontFaceSet : EventTarget
{
		public FontFaceSet(List<FontFace> initialFaces) { }
	
	///<include file='Utils/Docs/FontFaceSetAdd/FontFaceSetAdd.generated.xml' path='docs/FontFaceSetAdd/*'/>
	public FontFaceSet Add(FontFace font) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FontFaceSetDelete/FontFaceSetDelete.generated.xml' path='docs/FontFaceSetDelete/*'/>
	public bool Delete(FontFace font) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FontFaceSetClear/FontFaceSetClear.generated.xml' path='docs/FontFaceSetClear/*'/>
	public Undefined Clear() { throw new System.NotImplementedException(); }
		public EventHandler Onloading { get; set; }
		public EventHandler Onloadingdone { get; set; }
		public EventHandler Onloadingerror { get; set; }
	///<include file='Utils/Docs/FontFaceSetLoad/FontFaceSetLoad.generated.xml' path='docs/FontFaceSetLoad/*'/>
	public Task<List<FontFace>> Load(Unsupported /*CSSOMString*/ font, Unsupported /*CSSOMString*/ text) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FontFaceSetCheck/FontFaceSetCheck.generated.xml' path='docs/FontFaceSetCheck/*'/>
	public bool Check(Unsupported /*CSSOMString*/ font, Unsupported /*CSSOMString*/ text) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FontFaceSetReady/FontFaceSetReady.generated.xml' path='docs/FontFaceSetReady/*'/>
	public Task<FontFaceSet> Ready { get; }
	///<include file='Utils/Docs/FontFaceSetStatus/FontFaceSetStatus.generated.xml' path='docs/FontFaceSetStatus/*'/>
	public FontFaceSetLoadStatus Status { get; }
	public FontFaceSet() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface FontFaceSource
{
		public FontFaceSet Fonts { get { throw new System.NotImplementedException(); } }
}



///<include file='Utils/Docs/CSS/CSS.generated.xml' path='docs/CSS/*'/>
public partial class CSS
{
		public dynamic ElementSources { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class LayoutChild
{
		public Unsupported /*StylePropertyMapReadOnly*/ StyleMap { get; }
		public IntrinsicSizesRequest IntrinsicSizes() { throw new System.NotImplementedException(); }
		public LayoutFragmentRequest LayoutNextFragment(LayoutConstraints constraints, ChildBreakToken breakToken) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class LayoutFragment
{
		public Number InlineSize { get; }
		public Number BlockSize { get; }
		public Number InlineOffset { get; set; }
		public Number BlockOffset { get; set; }
		public dynamic Data { get; }
		public ChildBreakToken? BreakToken { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class IntrinsicSizes
{
		public Number MinContentSize { get; }
		public Number MaxContentSize { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class LayoutConstraints
{
		public LayoutConstraints(LayoutConstraintsOptions options) { }
		public Number AvailableInlineSize { get; }
		public Number AvailableBlockSize { get; }
		public Number? FixedInlineSize { get; }
		public Number? FixedBlockSize { get; }
		public Number PercentageInlineSize { get; }
		public Number PercentageBlockSize { get; }
		public Number? BlockFragmentationOffset { get; }
		public BlockFragmentationType BlockFragmentationType { get; }
		public dynamic Data { get; }
	public LayoutConstraints() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class LayoutConstraintsOptions
{
		public Number AvailableInlineSize;
		public Number AvailableBlockSize;
		public Number FixedInlineSize;
		public Number FixedBlockSize;
		public Number PercentageInlineSize;
		public Number PercentageBlockSize;
		public Number BlockFragmentationOffset;
		public BlockFragmentationType BlockFragmentationType;
		public dynamic Data;
}

public enum BlockFragmentationType
{
	None,
	Page,
	Column,
	Region,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ChildBreakToken
{
		public BreakType BreakType { get; }
		public LayoutChild Child { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class BreakToken
{
		public List<ChildBreakToken> ChildBreakTokens { get; }
		public dynamic Data { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class BreakTokenOptions
{
		public List<ChildBreakToken> ChildBreakTokens;
		public dynamic Data;
}

public enum BreakType
{
	None,
	Line,
	Column,
	Page,
	Region,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class LayoutEdgeSizes
{
		public Number InlineStart { get; }
		public Number InlineEnd { get; }
		public Number BlockStart { get; }
		public Number BlockEnd { get; }
		public Number Inline { get; }
		public Number Block { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class LayoutEdges
{
		public LayoutEdgeSizes Border { get; }
		public LayoutEdgeSizes Scrollbar { get; }
		public LayoutEdgeSizes Padding { get; }
		public LayoutEdgeSizes All { get; }
}

///<include file='Utils/Docs/CSS/CSS.generated.xml' path='docs/CSS/*'/>
public partial class CSS
{
		public Worklet LayoutWorklet { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class LayoutWorkletGlobalScope : WorkletGlobalScope
{
		public Undefined RegisterLayout(string name, VoidFunction layoutCtor) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class LayoutOptions
{
		public ChildDisplayType ChildDisplay;
		public LayoutSizingMode Sizing;
}

public enum ChildDisplayType
{
	Block,
	Normal,
}

public enum LayoutSizingMode
{
	BlockLike,
	Manual,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class IntrinsicSizesRequest
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class LayoutFragmentRequest
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class FragmentResultOptions
{
		public Number InlineSize;
		public Number BlockSize;
		public Number AutoBlockSize;
		public List<LayoutFragment> ChildFragments;
		public dynamic Data;
		public BreakTokenOptions BreakToken;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class IntrinsicSizesResultOptions
{
		public Number MaxContentSize;
		public Number MinContentSize;
}

///<include file='Utils/Docs/SVGClipPathElement/SVGClipPathElement.generated.xml' path='docs/SVGClipPathElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGClipPathElement
{
	///<include file='Utils/Docs/SVGClipPathElementClipPathUnits/SVGClipPathElementClipPathUnits.generated.xml' path='docs/SVGClipPathElementClipPathUnits/*'/>
	public Unsupported /*SVGAnimatedEnumeration*/ ClipPathUnits { get; }
	///<include file='Utils/Docs/SVGClipPathElementTransform/SVGClipPathElementTransform.generated.xml' path='docs/SVGClipPathElementTransform/*'/>
	public Unsupported /*SVGAnimatedTransformList*/ Transform { get; }
}

///<include file='Utils/Docs/SVGMaskElement/SVGMaskElement.generated.xml' path='docs/SVGMaskElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGMaskElement
{
	///<include file='Utils/Docs/SVGMaskElementMaskUnits/SVGMaskElementMaskUnits.generated.xml' path='docs/SVGMaskElementMaskUnits/*'/>
	public Unsupported /*SVGAnimatedEnumeration*/ MaskUnits { get; }
	///<include file='Utils/Docs/SVGMaskElementMaskContentUnits/SVGMaskElementMaskContentUnits.generated.xml' path='docs/SVGMaskElementMaskContentUnits/*'/>
	public Unsupported /*SVGAnimatedEnumeration*/ MaskContentUnits { get; }
	///<include file='Utils/Docs/SVGMaskElementX/SVGMaskElementX.generated.xml' path='docs/SVGMaskElementX/*'/>
	public Unsupported /*SVGAnimatedLength*/ X { get; }
	///<include file='Utils/Docs/SVGMaskElementY/SVGMaskElementY.generated.xml' path='docs/SVGMaskElementY/*'/>
	public Unsupported /*SVGAnimatedLength*/ Y { get; }
	///<include file='Utils/Docs/SVGMaskElementWidth/SVGMaskElementWidth.generated.xml' path='docs/SVGMaskElementWidth/*'/>
	public Unsupported /*SVGAnimatedLength*/ Width { get; }
	///<include file='Utils/Docs/SVGMaskElementHeight/SVGMaskElementHeight.generated.xml' path='docs/SVGMaskElementHeight/*'/>
	public Unsupported /*SVGAnimatedLength*/ Height { get; }
}

///<include file='Utils/Docs/CSSStyleRule/CSSStyleRule.generated.xml' path='docs/CSSStyleRule/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSStyleRule
{
		public CSSRuleList CssRules { get; }
		public ulong InsertRule(Unsupported /*CSSOMString*/ rule, ulong index) { throw new System.NotImplementedException(); }
		public Undefined DeleteRule(ulong index) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/MediaList/MediaList.generated.xml' path='docs/MediaList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaList
{
	///<include file='Utils/Docs/MediaListMediaText/MediaListMediaText.generated.xml' path='docs/MediaListMediaText/*'/>
	public Unsupported /*CSSOMString*/ MediaText { get; set; }
	///<include file='Utils/Docs/MediaListLength/MediaListLength.generated.xml' path='docs/MediaListLength/*'/>
	public ulong Length { get; }
	
	///<include file='Utils/Docs/MediaListAppendMedium/MediaListAppendMedium.generated.xml' path='docs/MediaListAppendMedium/*'/>
	public Undefined AppendMedium(Unsupported /*CSSOMString*/ medium) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MediaListDeleteMedium/MediaListDeleteMedium.generated.xml' path='docs/MediaListDeleteMedium/*'/>
	public Undefined DeleteMedium(Unsupported /*CSSOMString*/ medium) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/StyleSheet/StyleSheet.generated.xml' path='docs/StyleSheet/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class StyleSheet
{
	///<include file='Utils/Docs/StyleSheetType/StyleSheetType.generated.xml' path='docs/StyleSheetType/*'/>
	public Unsupported /*CSSOMString*/ Type { get; }
	///<include file='Utils/Docs/StyleSheetHref/StyleSheetHref.generated.xml' path='docs/StyleSheetHref/*'/>
	public string? Href { get; }
	///<include file='Utils/Docs/StyleSheetOwnerNode/StyleSheetOwnerNode.generated.xml' path='docs/StyleSheetOwnerNode/*'/>
	public Union37? OwnerNode { get; }
	///<include file='Utils/Docs/StyleSheetParentStyleSheet/StyleSheetParentStyleSheet.generated.xml' path='docs/StyleSheetParentStyleSheet/*'/>
	public CSSStyleSheet? ParentStyleSheet { get; }
	///<include file='Utils/Docs/StyleSheetTitle/StyleSheetTitle.generated.xml' path='docs/StyleSheetTitle/*'/>
	public string? Title { get; }
	///<include file='Utils/Docs/StyleSheetMedia/StyleSheetMedia.generated.xml' path='docs/StyleSheetMedia/*'/>
	public MediaList Media { get; }
	///<include file='Utils/Docs/StyleSheetDisabled/StyleSheetDisabled.generated.xml' path='docs/StyleSheetDisabled/*'/>
	public bool Disabled { get; set; }
}

///<include file='Utils/Docs/CSSStyleSheet/CSSStyleSheet.generated.xml' path='docs/CSSStyleSheet/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSStyleSheet : StyleSheet
{
	///<include file='Utils/Docs/CSSStyleSheetCSSStyleSheet/CSSStyleSheetCSSStyleSheet.generated.xml' path='docs/CSSStyleSheetCSSStyleSheet/*'/>
	public CSSStyleSheet(CSSStyleSheetInit options) { }
	///<include file='Utils/Docs/CSSStyleSheetOwnerRule/CSSStyleSheetOwnerRule.generated.xml' path='docs/CSSStyleSheetOwnerRule/*'/>
	public CSSRule? OwnerRule { get; }
	///<include file='Utils/Docs/CSSStyleSheetCssRules/CSSStyleSheetCssRules.generated.xml' path='docs/CSSStyleSheetCssRules/*'/>
	public CSSRuleList CssRules { get; }
	///<include file='Utils/Docs/CSSStyleSheetInsertRule/CSSStyleSheetInsertRule.generated.xml' path='docs/CSSStyleSheetInsertRule/*'/>
	public ulong InsertRule(Unsupported /*CSSOMString*/ rule, ulong index) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CSSStyleSheetDeleteRule/CSSStyleSheetDeleteRule.generated.xml' path='docs/CSSStyleSheetDeleteRule/*'/>
	public Undefined DeleteRule(ulong index) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CSSStyleSheetReplace/CSSStyleSheetReplace.generated.xml' path='docs/CSSStyleSheetReplace/*'/>
	public Task<CSSStyleSheet> Replace(string text) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CSSStyleSheetReplaceSync/CSSStyleSheetReplaceSync.generated.xml' path='docs/CSSStyleSheetReplaceSync/*'/>
	public Undefined ReplaceSync(string text) { throw new System.NotImplementedException(); }
	public CSSStyleSheet() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSStyleSheetInit
{
		public string BaseURL;
		public Union38 Media;
		public bool Disabled;
}

///<include file='Utils/Docs/CSSStyleSheet/CSSStyleSheet.generated.xml' path='docs/CSSStyleSheet/*'/>
public partial class CSSStyleSheet
{
	///<include file='Utils/Docs/CSSStyleSheetRules/CSSStyleSheetRules.generated.xml' path='docs/CSSStyleSheetRules/*'/>
	public CSSRuleList Rules { get; }
	///<include file='Utils/Docs/CSSStyleSheetAddRule/CSSStyleSheetAddRule.generated.xml' path='docs/CSSStyleSheetAddRule/*'/>
	public long AddRule(string selector, string style, ulong index) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CSSStyleSheetRemoveRule/CSSStyleSheetRemoveRule.generated.xml' path='docs/CSSStyleSheetRemoveRule/*'/>
	public Undefined RemoveRule(ulong index) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/StyleSheetList/StyleSheetList.generated.xml' path='docs/StyleSheetList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class StyleSheetList
{
	
	///<include file='Utils/Docs/StyleSheetListLength/StyleSheetListLength.generated.xml' path='docs/StyleSheetListLength/*'/>
	public ulong Length { get; }
}

public partial interface DocumentOrShadowRoot
{
		public StyleSheetList StyleSheets { get { throw new System.NotImplementedException(); } }
		public CSSStyleSheet[] AdoptedStyleSheets { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface LinkStyle
{
		public CSSStyleSheet? Sheet { get { throw new System.NotImplementedException(); } }
}


///<include file='Utils/Docs/CSSRuleList/CSSRuleList.generated.xml' path='docs/CSSRuleList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSRuleList
{
	
	///<include file='Utils/Docs/CSSRuleListLength/CSSRuleListLength.generated.xml' path='docs/CSSRuleListLength/*'/>
	public ulong Length { get; }
}

///<include file='Utils/Docs/CSSRule/CSSRule.generated.xml' path='docs/CSSRule/*'/>
public partial class CSSRule
{
	///<include file='Utils/Docs/CSSRuleCssText/CSSRuleCssText.generated.xml' path='docs/CSSRuleCssText/*'/>
	public Unsupported /*CSSOMString*/ CssText { get; set; }
	///<include file='Utils/Docs/CSSRuleParentRule/CSSRuleParentRule.generated.xml' path='docs/CSSRuleParentRule/*'/>
	public CSSRule? ParentRule { get; }
	///<include file='Utils/Docs/CSSRuleParentStyleSheet/CSSRuleParentStyleSheet.generated.xml' path='docs/CSSRuleParentStyleSheet/*'/>
	public CSSStyleSheet? ParentStyleSheet { get; }
	///<include file='Utils/Docs/CSSRuleType/CSSRuleType.generated.xml' path='docs/CSSRuleType/*'/>
	public ushort Type { get; }
		public const ushort STYLE_RULE = 1;
		public const ushort CHARSET_RULE = 2;
		public const ushort IMPORT_RULE = 3;
		public const ushort MEDIA_RULE = 4;
		public const ushort FONT_FACE_RULE = 5;
		public const ushort PAGE_RULE = 6;
		public const ushort MARGIN_RULE = 9;
		public const ushort NAMESPACE_RULE = 10;
}

///<include file='Utils/Docs/CSSStyleRule/CSSStyleRule.generated.xml' path='docs/CSSStyleRule/*'/>
public partial class CSSStyleRule : CSSRule
{
	///<include file='Utils/Docs/CSSStyleRuleSelectorText/CSSStyleRuleSelectorText.generated.xml' path='docs/CSSStyleRuleSelectorText/*'/>
	public Unsupported /*CSSOMString*/ SelectorText { get; set; }
	///<include file='Utils/Docs/CSSStyleRuleStyle/CSSStyleRuleStyle.generated.xml' path='docs/CSSStyleRuleStyle/*'/>
	public CSSStyleDeclaration Style { get; }
}

///<include file='Utils/Docs/CSSImportRule/CSSImportRule.generated.xml' path='docs/CSSImportRule/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSImportRule : CSSRule
{
	///<include file='Utils/Docs/CSSImportRuleHref/CSSImportRuleHref.generated.xml' path='docs/CSSImportRuleHref/*'/>
	public string Href { get; }
	///<include file='Utils/Docs/CSSImportRuleMedia/CSSImportRuleMedia.generated.xml' path='docs/CSSImportRuleMedia/*'/>
	public MediaList Media { get; }
	///<include file='Utils/Docs/CSSImportRuleStyleSheet/CSSImportRuleStyleSheet.generated.xml' path='docs/CSSImportRuleStyleSheet/*'/>
	public CSSStyleSheet StyleSheet { get; }
}

///<include file='Utils/Docs/CSSGroupingRule/CSSGroupingRule.generated.xml' path='docs/CSSGroupingRule/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSGroupingRule : CSSRule
{
	///<include file='Utils/Docs/CSSGroupingRuleCssRules/CSSGroupingRuleCssRules.generated.xml' path='docs/CSSGroupingRuleCssRules/*'/>
	public CSSRuleList CssRules { get; }
	///<include file='Utils/Docs/CSSGroupingRuleInsertRule/CSSGroupingRuleInsertRule.generated.xml' path='docs/CSSGroupingRuleInsertRule/*'/>
	public ulong InsertRule(Unsupported /*CSSOMString*/ rule, ulong index) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CSSGroupingRuleDeleteRule/CSSGroupingRuleDeleteRule.generated.xml' path='docs/CSSGroupingRuleDeleteRule/*'/>
	public Undefined DeleteRule(ulong index) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/CSSPageRule/CSSPageRule.generated.xml' path='docs/CSSPageRule/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSPageRule : CSSGroupingRule
{
	///<include file='Utils/Docs/CSSPageRuleSelectorText/CSSPageRuleSelectorText.generated.xml' path='docs/CSSPageRuleSelectorText/*'/>
	public Unsupported /*CSSOMString*/ SelectorText { get; set; }
	///<include file='Utils/Docs/CSSPageRuleStyle/CSSPageRuleStyle.generated.xml' path='docs/CSSPageRuleStyle/*'/>
	public CSSStyleDeclaration Style { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSMarginRule : CSSRule
{
		public Unsupported /*CSSOMString*/ Name { get; }
		public CSSStyleDeclaration Style { get; }
}

///<include file='Utils/Docs/CSSNamespaceRule/CSSNamespaceRule.generated.xml' path='docs/CSSNamespaceRule/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSNamespaceRule : CSSRule
{
	///<include file='Utils/Docs/CSSNamespaceRuleNamespaceURI/CSSNamespaceRuleNamespaceURI.generated.xml' path='docs/CSSNamespaceRuleNamespaceURI/*'/>
	public Unsupported /*CSSOMString*/ NamespaceURI { get; }
	///<include file='Utils/Docs/CSSNamespaceRulePrefix/CSSNamespaceRulePrefix.generated.xml' path='docs/CSSNamespaceRulePrefix/*'/>
	public Unsupported /*CSSOMString*/ Prefix { get; }
}

///<include file='Utils/Docs/CSSStyleDeclaration/CSSStyleDeclaration.generated.xml' path='docs/CSSStyleDeclaration/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSStyleDeclaration
{
	///<include file='Utils/Docs/CSSStyleDeclarationCssText/CSSStyleDeclarationCssText.generated.xml' path='docs/CSSStyleDeclarationCssText/*'/>
	public Unsupported /*CSSOMString*/ CssText { get; set; }
	///<include file='Utils/Docs/CSSStyleDeclarationLength/CSSStyleDeclarationLength.generated.xml' path='docs/CSSStyleDeclarationLength/*'/>
	public ulong Length { get; }
	
	///<include file='Utils/Docs/CSSStyleDeclarationGetPropertyValue/CSSStyleDeclarationGetPropertyValue.generated.xml' path='docs/CSSStyleDeclarationGetPropertyValue/*'/>
	public Unsupported /*CSSOMString*/ GetPropertyValue(Unsupported /*CSSOMString*/ property) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CSSStyleDeclarationGetPropertyPriority/CSSStyleDeclarationGetPropertyPriority.generated.xml' path='docs/CSSStyleDeclarationGetPropertyPriority/*'/>
	public Unsupported /*CSSOMString*/ GetPropertyPriority(Unsupported /*CSSOMString*/ property) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CSSStyleDeclarationSetProperty/CSSStyleDeclarationSetProperty.generated.xml' path='docs/CSSStyleDeclarationSetProperty/*'/>
	public Undefined SetProperty(Unsupported /*CSSOMString*/ property, Unsupported /*CSSOMString*/ value, Unsupported /*CSSOMString*/ priority) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CSSStyleDeclarationRemoveProperty/CSSStyleDeclarationRemoveProperty.generated.xml' path='docs/CSSStyleDeclarationRemoveProperty/*'/>
	public Unsupported /*CSSOMString*/ RemoveProperty(Unsupported /*CSSOMString*/ property) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CSSStyleDeclarationParentRule/CSSStyleDeclarationParentRule.generated.xml' path='docs/CSSStyleDeclarationParentRule/*'/>
	public CSSRule? ParentRule { get; }
	///<include file='Utils/Docs/CSSStyleDeclarationCssFloat/CSSStyleDeclarationCssFloat.generated.xml' path='docs/CSSStyleDeclarationCssFloat/*'/>
	public Unsupported /*CSSOMString*/ CssFloat { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface ElementCSSInlineStyle
{
		public CSSStyleDeclaration Style { get { throw new System.NotImplementedException(); } }
}




///<include file='Utils/Docs/Window/Window.generated.xml' path='docs/Window/*'/>
public partial class Window
{
	///<include file='Utils/Docs/WindowGetComputedStyle/WindowGetComputedStyle.generated.xml' path='docs/WindowGetComputedStyle/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public CSSStyleDeclaration GetComputedStyle(Element elt, Unsupported /*CSSOMString*/? pseudoElt) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/CSS/CSS.generated.xml' path='docs/CSS/*'/>
public partial class CSS
{
		public Unsupported /*CSSOMString*/ Escape(Unsupported /*CSSOMString*/ ident) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/CSS/CSS.generated.xml' path='docs/CSS/*'/>
public partial class CSS
{
		public Worklet PaintWorklet { get; }
}

///<include file='Utils/Docs/PaintWorkletGlobalScope/PaintWorkletGlobalScope.generated.xml' path='docs/PaintWorkletGlobalScope/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PaintWorkletGlobalScope : WorkletGlobalScope
{
	///<include file='Utils/Docs/PaintWorkletGlobalScopeRegisterPaint/PaintWorkletGlobalScopeRegisterPaint.generated.xml' path='docs/PaintWorkletGlobalScopeRegisterPaint/*'/>
	public Undefined RegisterPaint(string name, VoidFunction paintCtor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/PaintWorkletGlobalScopeDevicePixelRatio/PaintWorkletGlobalScopeDevicePixelRatio.generated.xml' path='docs/PaintWorkletGlobalScopeDevicePixelRatio/*'/>
	public double DevicePixelRatio { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PaintRenderingContext2DSettings
{
		public bool Alpha;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PaintRenderingContext2D
{
}












[To(ToAttribute.FirstCharToLowerCase)]
public partial class PaintSize
{
		public Number Width { get; }
		public Number Height { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PropertyDefinition
{
		public required string Name;
		public string Syntax;
		public required bool Inherits;
		public string InitialValue;
}

///<include file='Utils/Docs/CSS/CSS.generated.xml' path='docs/CSS/*'/>
public partial class CSS
{
		public Undefined RegisterProperty(PropertyDefinition definition) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/CSSPropertyRule/CSSPropertyRule.generated.xml' path='docs/CSSPropertyRule/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSPropertyRule : CSSRule
{
	///<include file='Utils/Docs/CSSPropertyRuleName/CSSPropertyRuleName.generated.xml' path='docs/CSSPropertyRuleName/*'/>
	public Unsupported /*CSSOMString*/ Name { get; }
	///<include file='Utils/Docs/CSSPropertyRuleSyntax/CSSPropertyRuleSyntax.generated.xml' path='docs/CSSPropertyRuleSyntax/*'/>
	public Unsupported /*CSSOMString*/ Syntax { get; }
	///<include file='Utils/Docs/CSSPropertyRuleInherits/CSSPropertyRuleInherits.generated.xml' path='docs/CSSPropertyRuleInherits/*'/>
	public bool Inherits { get; }
	///<include file='Utils/Docs/CSSPropertyRuleInitialValue/CSSPropertyRuleInitialValue.generated.xml' path='docs/CSSPropertyRuleInitialValue/*'/>
	public Unsupported /*CSSOMString*/? InitialValue { get; }
}

///<include file='Utils/Docs/CSSPseudoElement/CSSPseudoElement.generated.xml' path='docs/CSSPseudoElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSPseudoElement : EventTarget
{
	///<include file='Utils/Docs/CSSPseudoElementType/CSSPseudoElementType.generated.xml' path='docs/CSSPseudoElementType/*'/>
	public Unsupported /*CSSOMString*/ Type { get; }
	///<include file='Utils/Docs/CSSPseudoElementElement/CSSPseudoElementElement.generated.xml' path='docs/CSSPseudoElementElement/*'/>
	public Element Element { get; }
		public Union39 Parent { get; }
		public CSSPseudoElement? Pseudo(Unsupported /*CSSOMString*/ type) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Element/Element.generated.xml' path='docs/Element/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Element
{
		public CSSPseudoElement? Pseudo(Unsupported /*CSSOMString*/ type) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Element/Element.generated.xml' path='docs/Element/*'/>
public partial class Element
{
	///<include file='Utils/Docs/ElementPart/ElementPart.generated.xml' path='docs/ElementPart/*'/>
	public DOMTokenList Part { get; }
}

public enum SpatialNavigationDirection
{
	Up,
	Down,
	Left,
	Right,
}

///<include file='Utils/Docs/Window/Window.generated.xml' path='docs/Window/*'/>
public partial class Window
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Navigate(SpatialNavigationDirection dir) { throw new System.NotImplementedException(); }
}

public enum FocusableAreaSearchMode
{
	Visible,
	All,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FocusableAreasOption
{
		public FocusableAreaSearchMode Mode;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class SpatialNavigationSearchOptions
{
		public List<Node>? Candidates;
		public Node? Container;
}

///<include file='Utils/Docs/Element/Element.generated.xml' path='docs/Element/*'/>
public partial class Element
{
		public Node GetSpatialNavigationContainer() { throw new System.NotImplementedException(); }
		public List<Node> FocusableAreas(FocusableAreasOption option) { throw new System.NotImplementedException(); }
		public Node? SpatialNavigationSearch(SpatialNavigationDirection dir, SpatialNavigationSearchOptions options) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NavigationEvent : UIEvent
{
		public NavigationEvent(string type, NavigationEventInit eventInitDict) { }
		public SpatialNavigationDirection Dir { get; }
		public EventTarget? RelatedTarget { get; }
	public NavigationEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NavigationEventInit : UIEventInit
{
		public SpatialNavigationDirection Dir;
		public EventTarget? RelatedTarget;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSStartingStyleRule : CSSGroupingRule
{
}

///<include file='Utils/Docs/CSSTransition/CSSTransition.generated.xml' path='docs/CSSTransition/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CSSTransition : Animation
{
	///<include file='Utils/Docs/CSSTransitionTransitionProperty/CSSTransitionTransitionProperty.generated.xml' path='docs/CSSTransitionTransitionProperty/*'/>
	public Unsupported /*CSSOMString*/ TransitionProperty { get; }
}

///<include file='Utils/Docs/Document/Document.generated.xml' path='docs/Document/*'/>
public partial class Document
{
	///<include file='Utils/Docs/DocumentStartViewTransition/DocumentStartViewTransition.generated.xml' path='docs/DocumentStartViewTransition/*'/>
	public ViewTransition StartViewTransition(UpdateCallback? updateCallback) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct UpdateCallback
{
}

///<include file='Utils/Docs/ViewTransition/ViewTransition.generated.xml' path='docs/ViewTransition/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ViewTransition
{
	///<include file='Utils/Docs/ViewTransitionUpdateCallbackDone/ViewTransitionUpdateCallbackDone.generated.xml' path='docs/ViewTransitionUpdateCallbackDone/*'/>
	public Task<Undefined> UpdateCallbackDone { get; }
	///<include file='Utils/Docs/ViewTransitionReady/ViewTransitionReady.generated.xml' path='docs/ViewTransitionReady/*'/>
	public Task<Undefined> Ready { get; }
	///<include file='Utils/Docs/ViewTransitionFinished/ViewTransitionFinished.generated.xml' path='docs/ViewTransitionFinished/*'/>
	public Task<Undefined> Finished { get; }
	///<include file='Utils/Docs/ViewTransitionSkipTransition/ViewTransitionSkipTransition.generated.xml' path='docs/ViewTransitionSkipTransition/*'/>
	public Undefined SkipTransition() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/NavigatorDeviceMemory/NavigatorDeviceMemory.generated.xml' path='docs/NavigatorDeviceMemory/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorDeviceMemory
{
		public Number DeviceMemory { get { throw new System.NotImplementedException(); } }
}



///<include file='Utils/Docs/Window/Window.generated.xml' path='docs/Window/*'/>
public partial class Window
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Ondeviceorientation { get; set; }
}

///<include file='Utils/Docs/DeviceOrientationEvent/DeviceOrientationEvent.generated.xml' path='docs/DeviceOrientationEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DeviceOrientationEvent : Event
{
	///<include file='Utils/Docs/DeviceOrientationEventDeviceOrientationEvent/DeviceOrientationEventDeviceOrientationEvent.generated.xml' path='docs/DeviceOrientationEventDeviceOrientationEvent/*'/>
	public DeviceOrientationEvent(string type, DeviceOrientationEventInit eventInitDict) { }
	///<include file='Utils/Docs/DeviceOrientationEventAlpha/DeviceOrientationEventAlpha.generated.xml' path='docs/DeviceOrientationEventAlpha/*'/>
	public Number? Alpha { get; }
	///<include file='Utils/Docs/DeviceOrientationEventBeta/DeviceOrientationEventBeta.generated.xml' path='docs/DeviceOrientationEventBeta/*'/>
	public Number? Beta { get; }
	///<include file='Utils/Docs/DeviceOrientationEventGamma/DeviceOrientationEventGamma.generated.xml' path='docs/DeviceOrientationEventGamma/*'/>
	public Number? Gamma { get; }
	///<include file='Utils/Docs/DeviceOrientationEventAbsolute/DeviceOrientationEventAbsolute.generated.xml' path='docs/DeviceOrientationEventAbsolute/*'/>
	public bool Absolute { get; }
		public static Task<Unsupported /*PermissionState*/> RequestPermission() { throw new System.NotImplementedException(); }
	public DeviceOrientationEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class DeviceOrientationEventInit : EventInit
{
		public Number? Alpha;
		public Number? Beta;
		public Number? Gamma;
		public bool Absolute;
}

///<include file='Utils/Docs/Window/Window.generated.xml' path='docs/Window/*'/>
public partial class Window
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Ondeviceorientationabsolute { get; set; }
}

///<include file='Utils/Docs/Window/Window.generated.xml' path='docs/Window/*'/>
public partial class Window
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Ondevicemotion { get; set; }
}

///<include file='Utils/Docs/DeviceMotionEventAcceleration/DeviceMotionEventAcceleration.generated.xml' path='docs/DeviceMotionEventAcceleration/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DeviceMotionEventAcceleration
{
	///<include file='Utils/Docs/DeviceMotionEventAccelerationX/DeviceMotionEventAccelerationX.generated.xml' path='docs/DeviceMotionEventAccelerationX/*'/>
	public Number? X { get; }
	///<include file='Utils/Docs/DeviceMotionEventAccelerationY/DeviceMotionEventAccelerationY.generated.xml' path='docs/DeviceMotionEventAccelerationY/*'/>
	public Number? Y { get; }
	///<include file='Utils/Docs/DeviceMotionEventAccelerationZ/DeviceMotionEventAccelerationZ.generated.xml' path='docs/DeviceMotionEventAccelerationZ/*'/>
	public Number? Z { get; }
}

///<include file='Utils/Docs/DeviceMotionEventRotationRate/DeviceMotionEventRotationRate.generated.xml' path='docs/DeviceMotionEventRotationRate/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DeviceMotionEventRotationRate
{
	///<include file='Utils/Docs/DeviceMotionEventRotationRateAlpha/DeviceMotionEventRotationRateAlpha.generated.xml' path='docs/DeviceMotionEventRotationRateAlpha/*'/>
	public Number? Alpha { get; }
	///<include file='Utils/Docs/DeviceMotionEventRotationRateBeta/DeviceMotionEventRotationRateBeta.generated.xml' path='docs/DeviceMotionEventRotationRateBeta/*'/>
	public Number? Beta { get; }
	///<include file='Utils/Docs/DeviceMotionEventRotationRateGamma/DeviceMotionEventRotationRateGamma.generated.xml' path='docs/DeviceMotionEventRotationRateGamma/*'/>
	public Number? Gamma { get; }
}

///<include file='Utils/Docs/DeviceMotionEvent/DeviceMotionEvent.generated.xml' path='docs/DeviceMotionEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DeviceMotionEvent : Event
{
	///<include file='Utils/Docs/DeviceMotionEventDeviceMotionEvent/DeviceMotionEventDeviceMotionEvent.generated.xml' path='docs/DeviceMotionEventDeviceMotionEvent/*'/>
	public DeviceMotionEvent(string type, DeviceMotionEventInit eventInitDict) { }
	///<include file='Utils/Docs/DeviceMotionEventAcceleration/DeviceMotionEventAcceleration.generated.xml' path='docs/DeviceMotionEventAcceleration/*'/>
	public DeviceMotionEventAcceleration? Acceleration { get; }
	///<include file='Utils/Docs/DeviceMotionEventAccelerationIncludingGravity/DeviceMotionEventAccelerationIncludingGravity.generated.xml' path='docs/DeviceMotionEventAccelerationIncludingGravity/*'/>
	public DeviceMotionEventAcceleration? AccelerationIncludingGravity { get; }
	///<include file='Utils/Docs/DeviceMotionEventRotationRate/DeviceMotionEventRotationRate.generated.xml' path='docs/DeviceMotionEventRotationRate/*'/>
	public DeviceMotionEventRotationRate? RotationRate { get; }
	///<include file='Utils/Docs/DeviceMotionEventInterval/DeviceMotionEventInterval.generated.xml' path='docs/DeviceMotionEventInterval/*'/>
	public Number Interval { get; }
		public static Task<Unsupported /*PermissionState*/> RequestPermission() { throw new System.NotImplementedException(); }
	public DeviceMotionEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class DeviceMotionEventAccelerationInit
{
		public Number? X;
		public Number? Y;
		public Number? Z;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class DeviceMotionEventRotationRateInit
{
		public Number? Alpha;
		public Number? Beta;
		public Number? Gamma;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class DeviceMotionEventInit : EventInit
{
		public DeviceMotionEventAccelerationInit Acceleration;
		public DeviceMotionEventAccelerationInit AccelerationIncludingGravity;
		public DeviceMotionEventRotationRateInit RotationRate;
		public Number Interval;
}

///<include file='Utils/Docs/Event/Event.generated.xml' path='docs/Event/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Event
{
	///<include file='Utils/Docs/EventEvent/EventEvent.generated.xml' path='docs/EventEvent/*'/>
	public Event(string type, EventInit eventInitDict) { }
	///<include file='Utils/Docs/EventType/EventType.generated.xml' path='docs/EventType/*'/>
	public string Type { get; }
	///<include file='Utils/Docs/EventTarget/EventTarget.generated.xml' path='docs/EventTarget/*'/>
	public EventTarget? Target { get; }
	///<include file='Utils/Docs/EventSrcElement/EventSrcElement.generated.xml' path='docs/EventSrcElement/*'/>
	public EventTarget? SrcElement { get; }
	///<include file='Utils/Docs/EventCurrentTarget/EventCurrentTarget.generated.xml' path='docs/EventCurrentTarget/*'/>
	public EventTarget? CurrentTarget { get; }
	///<include file='Utils/Docs/EventComposedPath/EventComposedPath.generated.xml' path='docs/EventComposedPath/*'/>
	public List<EventTarget> ComposedPath() { throw new System.NotImplementedException(); }
		public const ushort NONE = 0;
		public const ushort CAPTURING_PHASE = 1;
		public const ushort AT_TARGET = 2;
		public const ushort BUBBLING_PHASE = 3;
	///<include file='Utils/Docs/EventEventPhase/EventEventPhase.generated.xml' path='docs/EventEventPhase/*'/>
	public ushort EventPhase { get; }
	///<include file='Utils/Docs/EventStopPropagation/EventStopPropagation.generated.xml' path='docs/EventStopPropagation/*'/>
	public Undefined StopPropagation() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/EventCancelBubble/EventCancelBubble.generated.xml' path='docs/EventCancelBubble/*'/>
	public bool CancelBubble { get; set; }
	///<include file='Utils/Docs/EventStopImmediatePropagation/EventStopImmediatePropagation.generated.xml' path='docs/EventStopImmediatePropagation/*'/>
	public Undefined StopImmediatePropagation() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/EventBubbles/EventBubbles.generated.xml' path='docs/EventBubbles/*'/>
	public bool Bubbles { get; }
	///<include file='Utils/Docs/EventCancelable/EventCancelable.generated.xml' path='docs/EventCancelable/*'/>
	public bool Cancelable { get; }
	///<include file='Utils/Docs/EventReturnValue/EventReturnValue.generated.xml' path='docs/EventReturnValue/*'/>
	public bool ReturnValue { get; set; }
	///<include file='Utils/Docs/EventPreventDefault/EventPreventDefault.generated.xml' path='docs/EventPreventDefault/*'/>
	public Undefined PreventDefault() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/EventDefaultPrevented/EventDefaultPrevented.generated.xml' path='docs/EventDefaultPrevented/*'/>
	public bool DefaultPrevented { get; }
	///<include file='Utils/Docs/EventComposed/EventComposed.generated.xml' path='docs/EventComposed/*'/>
	public bool Composed { get; }
	///<include file='Utils/Docs/EventIsTrusted/EventIsTrusted.generated.xml' path='docs/EventIsTrusted/*'/>
	public bool IsTrusted { get; }
	///<include file='Utils/Docs/EventTimeStamp/EventTimeStamp.generated.xml' path='docs/EventTimeStamp/*'/>
	public Unsupported /*DOMHighResTimeStamp*/ TimeStamp { get; }
	///<include file='Utils/Docs/EventInitEvent/EventInitEvent.generated.xml' path='docs/EventInitEvent/*'/>
	public Undefined InitEvent(string type, bool bubbles, bool cancelable) { throw new System.NotImplementedException(); }
	public Event() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class EventInit
{
		public bool Bubbles;
		public bool Cancelable;
		public bool Composed;
}

///<include file='Utils/Docs/Window/Window.generated.xml' path='docs/Window/*'/>
public partial class Window
{
	///<include file='Utils/Docs/WindowEvent/WindowEvent.generated.xml' path='docs/WindowEvent/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Union40 Event { get; }
}

///<include file='Utils/Docs/CustomEvent/CustomEvent.generated.xml' path='docs/CustomEvent/*'/>
[To(ToAttribute.Default)]
public partial class CustomEvent : Event
{
	///<include file='Utils/Docs/CustomEventCustomEvent/CustomEventCustomEvent.generated.xml' path='docs/CustomEventCustomEvent/*'/>
	public CustomEvent(string type, CustomEventInit eventInitDict) { }
	///<include file='Utils/Docs/CustomEventDetail/CustomEventDetail.generated.xml' path='docs/CustomEventDetail/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public dynamic Detail { get; }
	///<include file='Utils/Docs/CustomEventInitCustomEvent/CustomEventInitCustomEvent.generated.xml' path='docs/CustomEventInitCustomEvent/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined InitCustomEvent(string type, bool bubbles, bool cancelable, dynamic detail) { throw new System.NotImplementedException(); }
	public CustomEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CustomEventInit : EventInit
{
		public dynamic Detail;
}

///<include file='Utils/Docs/EventTarget/EventTarget.generated.xml' path='docs/EventTarget/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class EventTarget
{
	///<include file='Utils/Docs/EventTargetEventTarget/EventTargetEventTarget.generated.xml' path='docs/EventTargetEventTarget/*'/>
	public EventTarget() { }
	///<include file='Utils/Docs/EventTargetAddEventListener/EventTargetAddEventListener.generated.xml' path='docs/EventTargetAddEventListener/*'/>
	public Undefined AddEventListener(string type, EventListener? callback, Union41 options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/EventTargetRemoveEventListener/EventTargetRemoveEventListener.generated.xml' path='docs/EventTargetRemoveEventListener/*'/>
	public Undefined RemoveEventListener(string type, EventListener? callback, Union42 options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/EventTargetDispatchEvent/EventTargetDispatchEvent.generated.xml' path='docs/EventTargetDispatchEvent/*'/>
	public bool DispatchEvent(Event event_) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface EventListener
{
		public Undefined HandleEvent(Event event_) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class EventListenerOptions
{
		public bool Capture;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AddEventListenerOptions : EventListenerOptions
{
		public bool Passive;
		public bool Once;
		public AbortSignal Signal;
}

///<include file='Utils/Docs/AbortController/AbortController.generated.xml' path='docs/AbortController/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AbortController
{
	///<include file='Utils/Docs/AbortControllerAbortController/AbortControllerAbortController.generated.xml' path='docs/AbortControllerAbortController/*'/>
	public AbortController() { }
	///<include file='Utils/Docs/AbortControllerSignal/AbortControllerSignal.generated.xml' path='docs/AbortControllerSignal/*'/>
	public AbortSignal Signal { get; }
	///<include file='Utils/Docs/AbortControllerAbort/AbortControllerAbort.generated.xml' path='docs/AbortControllerAbort/*'/>
	public Undefined Abort(dynamic reason) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/AbortSignal/AbortSignal.generated.xml' path='docs/AbortSignal/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AbortSignal : EventTarget
{
		public static AbortSignal Abort(dynamic reason) { throw new System.NotImplementedException(); }
		public static AbortSignal Timeout(ulong milliseconds) { throw new System.NotImplementedException(); }
		public static AbortSignal Any(List<AbortSignal> signals) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AbortSignalAborted/AbortSignalAborted.generated.xml' path='docs/AbortSignalAborted/*'/>
	public bool Aborted { get; }
	///<include file='Utils/Docs/AbortSignalReason/AbortSignalReason.generated.xml' path='docs/AbortSignalReason/*'/>
	public dynamic Reason { get; }
	///<include file='Utils/Docs/AbortSignalThrowIfAborted/AbortSignalThrowIfAborted.generated.xml' path='docs/AbortSignalThrowIfAborted/*'/>
	public Undefined ThrowIfAborted() { throw new System.NotImplementedException(); }
		public EventHandler Onabort { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NonElementParentNode
{
		public Element? GetElementById(string elementId) { throw new System.NotImplementedException(); }
}



public partial interface DocumentOrShadowRoot
{
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial interface ParentNode
{
		public HTMLCollection Children { get { throw new System.NotImplementedException(); } }
		public Element? FirstElementChild { get { throw new System.NotImplementedException(); } }
		public Element? LastElementChild { get { throw new System.NotImplementedException(); } }
		public ulong ChildElementCount { get { throw new System.NotImplementedException(); } }
		public Undefined Prepend(params Union43[] nodes) { throw new System.NotImplementedException(); }
		public Undefined Append(params Union44[] nodes) { throw new System.NotImplementedException(); }
		public Undefined ReplaceChildren(params Union45[] nodes) { throw new System.NotImplementedException(); }
		public Element? QuerySelector(string selectors) { throw new System.NotImplementedException(); }
		public NodeList QuerySelectorAll(string selectors) { throw new System.NotImplementedException(); }
}




[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NonDocumentTypeChildNode
{
		public Element? PreviousElementSibling { get { throw new System.NotImplementedException(); } }
		public Element? NextElementSibling { get { throw new System.NotImplementedException(); } }
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial interface ChildNode
{
		public Undefined Before(params Union46[] nodes) { throw new System.NotImplementedException(); }
		public Undefined After(params Union47[] nodes) { throw new System.NotImplementedException(); }
		public Undefined ReplaceWith(params Union48[] nodes) { throw new System.NotImplementedException(); }
		public Undefined Remove() { throw new System.NotImplementedException(); }
}




[To(ToAttribute.FirstCharToLowerCase)]
public partial interface Slottable
{
		public HTMLSlotElement? AssignedSlot { get { throw new System.NotImplementedException(); } }
}



///<include file='Utils/Docs/NodeList/NodeList.generated.xml' path='docs/NodeList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class NodeList
{
	
	///<include file='Utils/Docs/NodeListLength/NodeListLength.generated.xml' path='docs/NodeListLength/*'/>
	public ulong Length { get; }
	public Node this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
}

///<include file='Utils/Docs/HTMLCollection/HTMLCollection.generated.xml' path='docs/HTMLCollection/*'/>
[To(ToAttribute.Default)]
public partial class HTMLCollection
{
	///<include file='Utils/Docs/HTMLCollectionLength/HTMLCollectionLength.generated.xml' path='docs/HTMLCollectionLength/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Length { get; }
	
	
}

///<include file='Utils/Docs/MutationObserver/MutationObserver.generated.xml' path='docs/MutationObserver/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MutationObserver
{
	///<include file='Utils/Docs/MutationObserverMutationObserver/MutationObserverMutationObserver.generated.xml' path='docs/MutationObserverMutationObserver/*'/>
	public MutationObserver(MutationCallback callback) { }
	///<include file='Utils/Docs/MutationObserverObserve/MutationObserverObserve.generated.xml' path='docs/MutationObserverObserve/*'/>
	public Undefined Observe(Node target, MutationObserverInit options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MutationObserverDisconnect/MutationObserverDisconnect.generated.xml' path='docs/MutationObserverDisconnect/*'/>
	public Undefined Disconnect() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MutationObserverTakeRecords/MutationObserverTakeRecords.generated.xml' path='docs/MutationObserverTakeRecords/*'/>
	public List<MutationRecord> TakeRecords() { throw new System.NotImplementedException(); }
	public MutationObserver() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct MutationCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MutationObserverInit
{
		public bool ChildList;
		public bool Attributes;
		public bool CharacterData;
		public bool Subtree;
		public bool AttributeOldValue;
		public bool CharacterDataOldValue;
		public List<string> AttributeFilter;
}

///<include file='Utils/Docs/MutationRecord/MutationRecord.generated.xml' path='docs/MutationRecord/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MutationRecord
{
	///<include file='Utils/Docs/MutationRecordType/MutationRecordType.generated.xml' path='docs/MutationRecordType/*'/>
	public string Type { get; }
	///<include file='Utils/Docs/MutationRecordTarget/MutationRecordTarget.generated.xml' path='docs/MutationRecordTarget/*'/>
	public Node Target { get; }
	///<include file='Utils/Docs/MutationRecordAddedNodes/MutationRecordAddedNodes.generated.xml' path='docs/MutationRecordAddedNodes/*'/>
	public NodeList AddedNodes { get; }
	///<include file='Utils/Docs/MutationRecordRemovedNodes/MutationRecordRemovedNodes.generated.xml' path='docs/MutationRecordRemovedNodes/*'/>
	public NodeList RemovedNodes { get; }
	///<include file='Utils/Docs/MutationRecordPreviousSibling/MutationRecordPreviousSibling.generated.xml' path='docs/MutationRecordPreviousSibling/*'/>
	public Node? PreviousSibling { get; }
	///<include file='Utils/Docs/MutationRecordNextSibling/MutationRecordNextSibling.generated.xml' path='docs/MutationRecordNextSibling/*'/>
	public Node? NextSibling { get; }
	///<include file='Utils/Docs/MutationRecordAttributeName/MutationRecordAttributeName.generated.xml' path='docs/MutationRecordAttributeName/*'/>
	public string? AttributeName { get; }
	///<include file='Utils/Docs/MutationRecordAttributeNamespace/MutationRecordAttributeNamespace.generated.xml' path='docs/MutationRecordAttributeNamespace/*'/>
	public string? AttributeNamespace { get; }
	///<include file='Utils/Docs/MutationRecordOldValue/MutationRecordOldValue.generated.xml' path='docs/MutationRecordOldValue/*'/>
	public string? OldValue { get; }
}

///<include file='Utils/Docs/Node/Node.generated.xml' path='docs/Node/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Node : EventTarget
{
		public const ushort ELEMENT_NODE = 1;
		public const ushort ATTRIBUTE_NODE = 2;
		public const ushort TEXT_NODE = 3;
		public const ushort CDATA_SECTION_NODE = 4;
		public const ushort ENTITY_REFERENCE_NODE = 5;
		public const ushort ENTITY_NODE = 6;
		public const ushort PROCESSING_INSTRUCTION_NODE = 7;
		public const ushort COMMENT_NODE = 8;
		public const ushort DOCUMENT_NODE = 9;
		public const ushort DOCUMENT_TYPE_NODE = 10;
		public const ushort DOCUMENT_FRAGMENT_NODE = 11;
		public const ushort NOTATION_NODE = 12;
	///<include file='Utils/Docs/NodeNodeType/NodeNodeType.generated.xml' path='docs/NodeNodeType/*'/>
	public ushort NodeType { get; }
	///<include file='Utils/Docs/NodeNodeName/NodeNodeName.generated.xml' path='docs/NodeNodeName/*'/>
	public string NodeName { get; }
	///<include file='Utils/Docs/NodeBaseURI/NodeBaseURI.generated.xml' path='docs/NodeBaseURI/*'/>
	public string BaseURI { get; }
	///<include file='Utils/Docs/NodeIsConnected/NodeIsConnected.generated.xml' path='docs/NodeIsConnected/*'/>
	public bool IsConnected { get; }
	///<include file='Utils/Docs/NodeOwnerDocument/NodeOwnerDocument.generated.xml' path='docs/NodeOwnerDocument/*'/>
	public Document? OwnerDocument { get; }
	///<include file='Utils/Docs/NodeGetRootNode/NodeGetRootNode.generated.xml' path='docs/NodeGetRootNode/*'/>
	public Node GetRootNode(GetRootNodeOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeParentNode/NodeParentNode.generated.xml' path='docs/NodeParentNode/*'/>
	public Node? ParentNode { get; }
	///<include file='Utils/Docs/NodeParentElement/NodeParentElement.generated.xml' path='docs/NodeParentElement/*'/>
	public Element? ParentElement { get; }
	///<include file='Utils/Docs/NodeHasChildNodes/NodeHasChildNodes.generated.xml' path='docs/NodeHasChildNodes/*'/>
	public bool HasChildNodes() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeChildNodes/NodeChildNodes.generated.xml' path='docs/NodeChildNodes/*'/>
	public NodeList ChildNodes { get; }
	///<include file='Utils/Docs/NodeFirstChild/NodeFirstChild.generated.xml' path='docs/NodeFirstChild/*'/>
	public Node? FirstChild { get; }
	///<include file='Utils/Docs/NodeLastChild/NodeLastChild.generated.xml' path='docs/NodeLastChild/*'/>
	public Node? LastChild { get; }
	///<include file='Utils/Docs/NodePreviousSibling/NodePreviousSibling.generated.xml' path='docs/NodePreviousSibling/*'/>
	public Node? PreviousSibling { get; }
	///<include file='Utils/Docs/NodeNextSibling/NodeNextSibling.generated.xml' path='docs/NodeNextSibling/*'/>
	public Node? NextSibling { get; }
	///<include file='Utils/Docs/NodeNodeValue/NodeNodeValue.generated.xml' path='docs/NodeNodeValue/*'/>
	public string? NodeValue { get; set; }
	///<include file='Utils/Docs/NodeTextContent/NodeTextContent.generated.xml' path='docs/NodeTextContent/*'/>
	public string? TextContent { get; set; }
	///<include file='Utils/Docs/NodeNormalize/NodeNormalize.generated.xml' path='docs/NodeNormalize/*'/>
	public Undefined Normalize() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeCloneNode/NodeCloneNode.generated.xml' path='docs/NodeCloneNode/*'/>
	public Node CloneNode(bool deep) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeIsEqualNode/NodeIsEqualNode.generated.xml' path='docs/NodeIsEqualNode/*'/>
	public bool IsEqualNode(Node? otherNode) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeIsSameNode/NodeIsSameNode.generated.xml' path='docs/NodeIsSameNode/*'/>
	public bool IsSameNode(Node? otherNode) { throw new System.NotImplementedException(); }
		public const ushort DOCUMENT_POSITION_DISCONNECTED = 0x01;
		public const ushort DOCUMENT_POSITION_PRECEDING = 0x02;
		public const ushort DOCUMENT_POSITION_FOLLOWING = 0x04;
		public const ushort DOCUMENT_POSITION_CONTAINS = 0x08;
		public const ushort DOCUMENT_POSITION_CONTAINED_BY = 0x10;
		public const ushort DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC = 0x20;
	///<include file='Utils/Docs/NodeCompareDocumentPosition/NodeCompareDocumentPosition.generated.xml' path='docs/NodeCompareDocumentPosition/*'/>
	public ushort CompareDocumentPosition(Node other) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeContains/NodeContains.generated.xml' path='docs/NodeContains/*'/>
	public bool Contains(Node? other) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeLookupPrefix/NodeLookupPrefix.generated.xml' path='docs/NodeLookupPrefix/*'/>
	public string? LookupPrefix(string? namespace_) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeLookupNamespaceURI/NodeLookupNamespaceURI.generated.xml' path='docs/NodeLookupNamespaceURI/*'/>
	public string? LookupNamespaceURI(string? prefix) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeIsDefaultNamespace/NodeIsDefaultNamespace.generated.xml' path='docs/NodeIsDefaultNamespace/*'/>
	public bool IsDefaultNamespace(string? namespace_) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeInsertBefore/NodeInsertBefore.generated.xml' path='docs/NodeInsertBefore/*'/>
	public Node InsertBefore(Node node, Node? child) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeAppendChild/NodeAppendChild.generated.xml' path='docs/NodeAppendChild/*'/>
	public Node AppendChild(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeReplaceChild/NodeReplaceChild.generated.xml' path='docs/NodeReplaceChild/*'/>
	public Node ReplaceChild(Node node, Node child) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeRemoveChild/NodeRemoveChild.generated.xml' path='docs/NodeRemoveChild/*'/>
	public Node RemoveChild(Node child) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GetRootNodeOptions
{
		public bool Composed;
}

///<include file='Utils/Docs/Document/Document.generated.xml' path='docs/Document/*'/>
public partial class Document : Node
{
	///<include file='Utils/Docs/DocumentDocument/DocumentDocument.generated.xml' path='docs/DocumentDocument/*'/>
	public Document() { }
	///<include file='Utils/Docs/DocumentImplementation/DocumentImplementation.generated.xml' path='docs/DocumentImplementation/*'/>
	public DOMImplementation Implementation { get; }
	///<include file='Utils/Docs/DocumentURL/DocumentURL.generated.xml' path='docs/DocumentURL/*'/>
	public string URL { get; }
	///<include file='Utils/Docs/DocumentDocumentURI/DocumentDocumentURI.generated.xml' path='docs/DocumentDocumentURI/*'/>
	public string DocumentURI { get; }
	///<include file='Utils/Docs/DocumentCompatMode/DocumentCompatMode.generated.xml' path='docs/DocumentCompatMode/*'/>
	public string CompatMode { get; }
	///<include file='Utils/Docs/DocumentCharacterSet/DocumentCharacterSet.generated.xml' path='docs/DocumentCharacterSet/*'/>
	public string CharacterSet { get; }
		public string Charset { get; }
		public string InputEncoding { get; }
	///<include file='Utils/Docs/DocumentContentType/DocumentContentType.generated.xml' path='docs/DocumentContentType/*'/>
	public string ContentType { get; }
	///<include file='Utils/Docs/DocumentDoctype/DocumentDoctype.generated.xml' path='docs/DocumentDoctype/*'/>
	public DocumentType? Doctype { get; }
	///<include file='Utils/Docs/DocumentDocumentElement/DocumentDocumentElement.generated.xml' path='docs/DocumentDocumentElement/*'/>
	public Element? DocumentElement { get; }
	///<include file='Utils/Docs/DocumentGetElementsByTagName/DocumentGetElementsByTagName.generated.xml' path='docs/DocumentGetElementsByTagName/*'/>
	public HTMLCollection GetElementsByTagName(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentGetElementsByTagNameNS/DocumentGetElementsByTagNameNS.generated.xml' path='docs/DocumentGetElementsByTagNameNS/*'/>
	public HTMLCollection GetElementsByTagNameNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentGetElementsByClassName/DocumentGetElementsByClassName.generated.xml' path='docs/DocumentGetElementsByClassName/*'/>
	public HTMLCollection GetElementsByClassName(string classNames) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentCreateElement/DocumentCreateElement.generated.xml' path='docs/DocumentCreateElement/*'/>
	public Element CreateElement(string localName, Union49 options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentCreateElementNS/DocumentCreateElementNS.generated.xml' path='docs/DocumentCreateElementNS/*'/>
	public Element CreateElementNS(string? namespace_, string qualifiedName, Union50 options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentCreateDocumentFragment/DocumentCreateDocumentFragment.generated.xml' path='docs/DocumentCreateDocumentFragment/*'/>
	public DocumentFragment CreateDocumentFragment() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentCreateTextNode/DocumentCreateTextNode.generated.xml' path='docs/DocumentCreateTextNode/*'/>
	public Text CreateTextNode(string data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentCreateCDATASection/DocumentCreateCDATASection.generated.xml' path='docs/DocumentCreateCDATASection/*'/>
	public CDATASection CreateCDATASection(string data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentCreateComment/DocumentCreateComment.generated.xml' path='docs/DocumentCreateComment/*'/>
	public Comment CreateComment(string data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentCreateProcessingInstruction/DocumentCreateProcessingInstruction.generated.xml' path='docs/DocumentCreateProcessingInstruction/*'/>
	public ProcessingInstruction CreateProcessingInstruction(string target, string data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentImportNode/DocumentImportNode.generated.xml' path='docs/DocumentImportNode/*'/>
	public Node ImportNode(Node node, bool deep) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentAdoptNode/DocumentAdoptNode.generated.xml' path='docs/DocumentAdoptNode/*'/>
	public Node AdoptNode(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentCreateAttribute/DocumentCreateAttribute.generated.xml' path='docs/DocumentCreateAttribute/*'/>
	public Attr CreateAttribute(string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentCreateAttributeNS/DocumentCreateAttributeNS.generated.xml' path='docs/DocumentCreateAttributeNS/*'/>
	public Attr CreateAttributeNS(string? namespace_, string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentCreateEvent/DocumentCreateEvent.generated.xml' path='docs/DocumentCreateEvent/*'/>
	public Event CreateEvent(string interface_) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentCreateRange/DocumentCreateRange.generated.xml' path='docs/DocumentCreateRange/*'/>
	public Range CreateRange() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentCreateNodeIterator/DocumentCreateNodeIterator.generated.xml' path='docs/DocumentCreateNodeIterator/*'/>
	public NodeIterator CreateNodeIterator(Node root, ulong whatToShow, NodeFilter? filter) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentCreateTreeWalker/DocumentCreateTreeWalker.generated.xml' path='docs/DocumentCreateTreeWalker/*'/>
	public TreeWalker CreateTreeWalker(Node root, ulong whatToShow, NodeFilter? filter) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XMLDocument/XMLDocument.generated.xml' path='docs/XMLDocument/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XMLDocument : Document
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ElementCreationOptions
{
		public string Is;
}

///<include file='Utils/Docs/DOMImplementation/DOMImplementation.generated.xml' path='docs/DOMImplementation/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMImplementation
{
	///<include file='Utils/Docs/DOMImplementationCreateDocumentType/DOMImplementationCreateDocumentType.generated.xml' path='docs/DOMImplementationCreateDocumentType/*'/>
	public DocumentType CreateDocumentType(string qualifiedName, string publicId, string systemId) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMImplementationCreateDocument/DOMImplementationCreateDocument.generated.xml' path='docs/DOMImplementationCreateDocument/*'/>
	public XMLDocument CreateDocument(string? namespace_, string qualifiedName, DocumentType? doctype) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMImplementationCreateHTMLDocument/DOMImplementationCreateHTMLDocument.generated.xml' path='docs/DOMImplementationCreateHTMLDocument/*'/>
	public Document CreateHTMLDocument(string title) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMImplementationHasFeature/DOMImplementationHasFeature.generated.xml' path='docs/DOMImplementationHasFeature/*'/>
	public bool HasFeature() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/DocumentType/DocumentType.generated.xml' path='docs/DocumentType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DocumentType : Node, ChildNode
{
	///<include file='Utils/Docs/DocumentTypeName/DocumentTypeName.generated.xml' path='docs/DocumentTypeName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs/DocumentTypePublicId/DocumentTypePublicId.generated.xml' path='docs/DocumentTypePublicId/*'/>
	public string PublicId { get; }
	///<include file='Utils/Docs/DocumentTypeSystemId/DocumentTypeSystemId.generated.xml' path='docs/DocumentTypeSystemId/*'/>
	public string SystemId { get; }
}

///<include file='Utils/Docs/DocumentFragment/DocumentFragment.generated.xml' path='docs/DocumentFragment/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DocumentFragment : Node, NonElementParentNode, ParentNode
{
	///<include file='Utils/Docs/DocumentFragmentDocumentFragment/DocumentFragmentDocumentFragment.generated.xml' path='docs/DocumentFragmentDocumentFragment/*'/>
	public DocumentFragment() { }
}

///<include file='Utils/Docs/ShadowRoot/ShadowRoot.generated.xml' path='docs/ShadowRoot/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ShadowRoot : DocumentFragment, DocumentOrShadowRoot
{
	///<include file='Utils/Docs/ShadowRootMode/ShadowRootMode.generated.xml' path='docs/ShadowRootMode/*'/>
	public ShadowRootMode Mode { get; }
	///<include file='Utils/Docs/ShadowRootDelegatesFocus/ShadowRootDelegatesFocus.generated.xml' path='docs/ShadowRootDelegatesFocus/*'/>
	public bool DelegatesFocus { get; }
	///<include file='Utils/Docs/ShadowRootSlotAssignment/ShadowRootSlotAssignment.generated.xml' path='docs/ShadowRootSlotAssignment/*'/>
	public SlotAssignmentMode SlotAssignment { get; }
	///<include file='Utils/Docs/ShadowRootHost/ShadowRootHost.generated.xml' path='docs/ShadowRootHost/*'/>
	public Element Host { get; }
		public EventHandler Onslotchange { get; set; }
}

///<include file='Utils/Docs/ShadowRootMode/ShadowRootMode.generated.xml' path='docs/ShadowRootMode/*'/>
public enum ShadowRootMode
{
	Open,
	Closed,
}

public enum SlotAssignmentMode
{
	Manual,
	Named,
}

///<include file='Utils/Docs/Element/Element.generated.xml' path='docs/Element/*'/>
public partial class Element : Node
{
	///<include file='Utils/Docs/ElementNamespaceURI/ElementNamespaceURI.generated.xml' path='docs/ElementNamespaceURI/*'/>
	public string? NamespaceURI { get; }
	///<include file='Utils/Docs/ElementPrefix/ElementPrefix.generated.xml' path='docs/ElementPrefix/*'/>
	public string? Prefix { get; }
	///<include file='Utils/Docs/ElementLocalName/ElementLocalName.generated.xml' path='docs/ElementLocalName/*'/>
	public string LocalName { get; }
	///<include file='Utils/Docs/ElementTagName/ElementTagName.generated.xml' path='docs/ElementTagName/*'/>
	public string TagName { get; }
	///<include file='Utils/Docs/ElementId/ElementId.generated.xml' path='docs/ElementId/*'/>
	public string Id { get; set; }
	///<include file='Utils/Docs/ElementClassName/ElementClassName.generated.xml' path='docs/ElementClassName/*'/>
	public string ClassName { get; set; }
	///<include file='Utils/Docs/ElementClassList/ElementClassList.generated.xml' path='docs/ElementClassList/*'/>
	public DOMTokenList ClassList { get; }
	///<include file='Utils/Docs/ElementSlot/ElementSlot.generated.xml' path='docs/ElementSlot/*'/>
	public string Slot { get; set; }
	///<include file='Utils/Docs/ElementHasAttributes/ElementHasAttributes.generated.xml' path='docs/ElementHasAttributes/*'/>
	public bool HasAttributes() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementAttributes/ElementAttributes.generated.xml' path='docs/ElementAttributes/*'/>
	public NamedNodeMap Attributes { get; }
	///<include file='Utils/Docs/ElementGetAttributeNames/ElementGetAttributeNames.generated.xml' path='docs/ElementGetAttributeNames/*'/>
	public List<string> GetAttributeNames() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementGetAttribute/ElementGetAttribute.generated.xml' path='docs/ElementGetAttribute/*'/>
	public string? GetAttribute(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementGetAttributeNS/ElementGetAttributeNS.generated.xml' path='docs/ElementGetAttributeNS/*'/>
	public string? GetAttributeNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementSetAttribute/ElementSetAttribute.generated.xml' path='docs/ElementSetAttribute/*'/>
	public Undefined SetAttribute(string qualifiedName, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementSetAttributeNS/ElementSetAttributeNS.generated.xml' path='docs/ElementSetAttributeNS/*'/>
	public Undefined SetAttributeNS(string? namespace_, string qualifiedName, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementRemoveAttribute/ElementRemoveAttribute.generated.xml' path='docs/ElementRemoveAttribute/*'/>
	public Undefined RemoveAttribute(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementRemoveAttributeNS/ElementRemoveAttributeNS.generated.xml' path='docs/ElementRemoveAttributeNS/*'/>
	public Undefined RemoveAttributeNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementToggleAttribute/ElementToggleAttribute.generated.xml' path='docs/ElementToggleAttribute/*'/>
	public bool ToggleAttribute(string qualifiedName, bool force) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementHasAttribute/ElementHasAttribute.generated.xml' path='docs/ElementHasAttribute/*'/>
	public bool HasAttribute(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementHasAttributeNS/ElementHasAttributeNS.generated.xml' path='docs/ElementHasAttributeNS/*'/>
	public bool HasAttributeNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementGetAttributeNode/ElementGetAttributeNode.generated.xml' path='docs/ElementGetAttributeNode/*'/>
	public Attr? GetAttributeNode(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementGetAttributeNodeNS/ElementGetAttributeNodeNS.generated.xml' path='docs/ElementGetAttributeNodeNS/*'/>
	public Attr? GetAttributeNodeNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementSetAttributeNode/ElementSetAttributeNode.generated.xml' path='docs/ElementSetAttributeNode/*'/>
	public Attr? SetAttributeNode(Attr attr) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementSetAttributeNodeNS/ElementSetAttributeNodeNS.generated.xml' path='docs/ElementSetAttributeNodeNS/*'/>
	public Attr? SetAttributeNodeNS(Attr attr) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementRemoveAttributeNode/ElementRemoveAttributeNode.generated.xml' path='docs/ElementRemoveAttributeNode/*'/>
	public Attr RemoveAttributeNode(Attr attr) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementAttachShadow/ElementAttachShadow.generated.xml' path='docs/ElementAttachShadow/*'/>
	public ShadowRoot AttachShadow(ShadowRootInit init) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementShadowRoot/ElementShadowRoot.generated.xml' path='docs/ElementShadowRoot/*'/>
	public ShadowRoot? ShadowRoot { get; }
	///<include file='Utils/Docs/ElementClosest/ElementClosest.generated.xml' path='docs/ElementClosest/*'/>
	public Element? Closest(string selectors) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementMatches/ElementMatches.generated.xml' path='docs/ElementMatches/*'/>
	public bool Matches(string selectors) { throw new System.NotImplementedException(); }
		public bool WebkitMatchesSelector(string selectors) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementGetElementsByTagName/ElementGetElementsByTagName.generated.xml' path='docs/ElementGetElementsByTagName/*'/>
	public HTMLCollection GetElementsByTagName(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementGetElementsByTagNameNS/ElementGetElementsByTagNameNS.generated.xml' path='docs/ElementGetElementsByTagNameNS/*'/>
	public HTMLCollection GetElementsByTagNameNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementGetElementsByClassName/ElementGetElementsByClassName.generated.xml' path='docs/ElementGetElementsByClassName/*'/>
	public HTMLCollection GetElementsByClassName(string classNames) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementInsertAdjacentElement/ElementInsertAdjacentElement.generated.xml' path='docs/ElementInsertAdjacentElement/*'/>
	public Element? InsertAdjacentElement(string where, Element element) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementInsertAdjacentText/ElementInsertAdjacentText.generated.xml' path='docs/ElementInsertAdjacentText/*'/>
	public Undefined InsertAdjacentText(string where, string data) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ShadowRootInit
{
		public required ShadowRootMode Mode;
		public bool DelegatesFocus;
		public SlotAssignmentMode SlotAssignment;
}

///<include file='Utils/Docs/NamedNodeMap/NamedNodeMap.generated.xml' path='docs/NamedNodeMap/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class NamedNodeMap
{
	///<include file='Utils/Docs/NamedNodeMapLength/NamedNodeMapLength.generated.xml' path='docs/NamedNodeMapLength/*'/>
	public ulong Length { get; }
	
	
	///<include file='Utils/Docs/NamedNodeMapGetNamedItemNS/NamedNodeMapGetNamedItemNS.generated.xml' path='docs/NamedNodeMapGetNamedItemNS/*'/>
	public Attr? GetNamedItemNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NamedNodeMapSetNamedItem/NamedNodeMapSetNamedItem.generated.xml' path='docs/NamedNodeMapSetNamedItem/*'/>
	public Attr? SetNamedItem(Attr attr) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NamedNodeMapSetNamedItemNS/NamedNodeMapSetNamedItemNS.generated.xml' path='docs/NamedNodeMapSetNamedItemNS/*'/>
	public Attr? SetNamedItemNS(Attr attr) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NamedNodeMapRemoveNamedItem/NamedNodeMapRemoveNamedItem.generated.xml' path='docs/NamedNodeMapRemoveNamedItem/*'/>
	public Attr RemoveNamedItem(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NamedNodeMapRemoveNamedItemNS/NamedNodeMapRemoveNamedItemNS.generated.xml' path='docs/NamedNodeMapRemoveNamedItemNS/*'/>
	public Attr RemoveNamedItemNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Attr/Attr.generated.xml' path='docs/Attr/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Attr : Node
{
	///<include file='Utils/Docs/AttrNamespaceURI/AttrNamespaceURI.generated.xml' path='docs/AttrNamespaceURI/*'/>
	public string? NamespaceURI { get; }
	///<include file='Utils/Docs/AttrPrefix/AttrPrefix.generated.xml' path='docs/AttrPrefix/*'/>
	public string? Prefix { get; }
	///<include file='Utils/Docs/AttrLocalName/AttrLocalName.generated.xml' path='docs/AttrLocalName/*'/>
	public string LocalName { get; }
	///<include file='Utils/Docs/AttrName/AttrName.generated.xml' path='docs/AttrName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs/AttrValue/AttrValue.generated.xml' path='docs/AttrValue/*'/>
	public string Value { get; set; }
	///<include file='Utils/Docs/AttrOwnerElement/AttrOwnerElement.generated.xml' path='docs/AttrOwnerElement/*'/>
	public Element? OwnerElement { get; }
	///<include file='Utils/Docs/AttrSpecified/AttrSpecified.generated.xml' path='docs/AttrSpecified/*'/>
	public bool Specified { get; }
}

///<include file='Utils/Docs/CharacterData/CharacterData.generated.xml' path='docs/CharacterData/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CharacterData : Node, NonDocumentTypeChildNode, ChildNode
{
	///<include file='Utils/Docs/CharacterDataData/CharacterDataData.generated.xml' path='docs/CharacterDataData/*'/>
	public string Data { get; set; }
	///<include file='Utils/Docs/CharacterDataLength/CharacterDataLength.generated.xml' path='docs/CharacterDataLength/*'/>
	public ulong Length { get; }
	///<include file='Utils/Docs/CharacterDataSubstringData/CharacterDataSubstringData.generated.xml' path='docs/CharacterDataSubstringData/*'/>
	public string SubstringData(ulong offset, ulong count) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CharacterDataAppendData/CharacterDataAppendData.generated.xml' path='docs/CharacterDataAppendData/*'/>
	public Undefined AppendData(string data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CharacterDataInsertData/CharacterDataInsertData.generated.xml' path='docs/CharacterDataInsertData/*'/>
	public Undefined InsertData(ulong offset, string data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CharacterDataDeleteData/CharacterDataDeleteData.generated.xml' path='docs/CharacterDataDeleteData/*'/>
	public Undefined DeleteData(ulong offset, ulong count) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CharacterDataReplaceData/CharacterDataReplaceData.generated.xml' path='docs/CharacterDataReplaceData/*'/>
	public Undefined ReplaceData(ulong offset, ulong count, string data) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Text/Text.generated.xml' path='docs/Text/*'/>
[To(ToAttribute.Default)]
public partial class Text : CharacterData, Slottable
{
	///<include file='Utils/Docs/TextText/TextText.generated.xml' path='docs/TextText/*'/>
	public Text(string data) { }
	///<include file='Utils/Docs/TextSplitText/TextSplitText.generated.xml' path='docs/TextSplitText/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Text SplitText(ulong offset) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TextWholeText/TextWholeText.generated.xml' path='docs/TextWholeText/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string WholeText { get; }
	public Text() { }
}

///<include file='Utils/Docs/CDATASection/CDATASection.generated.xml' path='docs/CDATASection/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CDATASection : Text
{
}

///<include file='Utils/Docs/ProcessingInstruction/ProcessingInstruction.generated.xml' path='docs/ProcessingInstruction/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ProcessingInstruction : CharacterData, LinkStyle
{
	///<include file='Utils/Docs/ProcessingInstructionTarget/ProcessingInstructionTarget.generated.xml' path='docs/ProcessingInstructionTarget/*'/>
	public string Target { get; }
}

///<include file='Utils/Docs/Comment/Comment.generated.xml' path='docs/Comment/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Comment : CharacterData
{
	///<include file='Utils/Docs/CommentComment/CommentComment.generated.xml' path='docs/CommentComment/*'/>
	public Comment(string data) { }
	public Comment() { }
}

///<include file='Utils/Docs/AbstractRange/AbstractRange.generated.xml' path='docs/AbstractRange/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AbstractRange
{
	///<include file='Utils/Docs/AbstractRangeStartContainer/AbstractRangeStartContainer.generated.xml' path='docs/AbstractRangeStartContainer/*'/>
	public Node StartContainer { get; }
	///<include file='Utils/Docs/AbstractRangeStartOffset/AbstractRangeStartOffset.generated.xml' path='docs/AbstractRangeStartOffset/*'/>
	public ulong StartOffset { get; }
	///<include file='Utils/Docs/AbstractRangeEndContainer/AbstractRangeEndContainer.generated.xml' path='docs/AbstractRangeEndContainer/*'/>
	public Node EndContainer { get; }
	///<include file='Utils/Docs/AbstractRangeEndOffset/AbstractRangeEndOffset.generated.xml' path='docs/AbstractRangeEndOffset/*'/>
	public ulong EndOffset { get; }
	///<include file='Utils/Docs/AbstractRangeCollapsed/AbstractRangeCollapsed.generated.xml' path='docs/AbstractRangeCollapsed/*'/>
	public bool Collapsed { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class StaticRangeInit
{
		public required Node StartContainer;
		public required ulong StartOffset;
		public required Node EndContainer;
		public required ulong EndOffset;
}

///<include file='Utils/Docs/StaticRange/StaticRange.generated.xml' path='docs/StaticRange/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class StaticRange : AbstractRange
{
	///<include file='Utils/Docs/StaticRangeStaticRange/StaticRangeStaticRange.generated.xml' path='docs/StaticRangeStaticRange/*'/>
	public StaticRange(StaticRangeInit init) { }
	public StaticRange() { }
}

///<include file='Utils/Docs/Range/Range.generated.xml' path='docs/Range/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Range : AbstractRange
{
	///<include file='Utils/Docs/RangeRange/RangeRange.generated.xml' path='docs/RangeRange/*'/>
	public Range() { }
	///<include file='Utils/Docs/RangeCommonAncestorContainer/RangeCommonAncestorContainer.generated.xml' path='docs/RangeCommonAncestorContainer/*'/>
	public Node CommonAncestorContainer { get; }
	///<include file='Utils/Docs/RangeSetStart/RangeSetStart.generated.xml' path='docs/RangeSetStart/*'/>
	public Undefined SetStart(Node node, ulong offset) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeSetEnd/RangeSetEnd.generated.xml' path='docs/RangeSetEnd/*'/>
	public Undefined SetEnd(Node node, ulong offset) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeSetStartBefore/RangeSetStartBefore.generated.xml' path='docs/RangeSetStartBefore/*'/>
	public Undefined SetStartBefore(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeSetStartAfter/RangeSetStartAfter.generated.xml' path='docs/RangeSetStartAfter/*'/>
	public Undefined SetStartAfter(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeSetEndBefore/RangeSetEndBefore.generated.xml' path='docs/RangeSetEndBefore/*'/>
	public Undefined SetEndBefore(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeSetEndAfter/RangeSetEndAfter.generated.xml' path='docs/RangeSetEndAfter/*'/>
	public Undefined SetEndAfter(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeCollapse/RangeCollapse.generated.xml' path='docs/RangeCollapse/*'/>
	public Undefined Collapse(bool toStart) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeSelectNode/RangeSelectNode.generated.xml' path='docs/RangeSelectNode/*'/>
	public Undefined SelectNode(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeSelectNodeContents/RangeSelectNodeContents.generated.xml' path='docs/RangeSelectNodeContents/*'/>
	public Undefined SelectNodeContents(Node node) { throw new System.NotImplementedException(); }
		public const ushort START_TO_START = 0;
		public const ushort START_TO_END = 1;
		public const ushort END_TO_END = 2;
		public const ushort END_TO_START = 3;
	///<include file='Utils/Docs/RangeCompareBoundaryPoints/RangeCompareBoundaryPoints.generated.xml' path='docs/RangeCompareBoundaryPoints/*'/>
	public Number CompareBoundaryPoints(ushort how, Range sourceRange) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeDeleteContents/RangeDeleteContents.generated.xml' path='docs/RangeDeleteContents/*'/>
	public Undefined DeleteContents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeExtractContents/RangeExtractContents.generated.xml' path='docs/RangeExtractContents/*'/>
	public DocumentFragment ExtractContents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeCloneContents/RangeCloneContents.generated.xml' path='docs/RangeCloneContents/*'/>
	public DocumentFragment CloneContents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeInsertNode/RangeInsertNode.generated.xml' path='docs/RangeInsertNode/*'/>
	public Undefined InsertNode(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeSurroundContents/RangeSurroundContents.generated.xml' path='docs/RangeSurroundContents/*'/>
	public Undefined SurroundContents(Node newParent) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeCloneRange/RangeCloneRange.generated.xml' path='docs/RangeCloneRange/*'/>
	public Range CloneRange() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeDetach/RangeDetach.generated.xml' path='docs/RangeDetach/*'/>
	public Undefined Detach() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeIsPointInRange/RangeIsPointInRange.generated.xml' path='docs/RangeIsPointInRange/*'/>
	public bool IsPointInRange(Node node, ulong offset) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeComparePoint/RangeComparePoint.generated.xml' path='docs/RangeComparePoint/*'/>
	public Number ComparePoint(Node node, ulong offset) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeIntersectsNode/RangeIntersectsNode.generated.xml' path='docs/RangeIntersectsNode/*'/>
	public bool IntersectsNode(Node node) { throw new System.NotImplementedException(); }
	
}

///<include file='Utils/Docs/NodeIterator/NodeIterator.generated.xml' path='docs/NodeIterator/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class NodeIterator
{
	///<include file='Utils/Docs/NodeIteratorRoot/NodeIteratorRoot.generated.xml' path='docs/NodeIteratorRoot/*'/>
	public Node Root { get; }
	///<include file='Utils/Docs/NodeIteratorReferenceNode/NodeIteratorReferenceNode.generated.xml' path='docs/NodeIteratorReferenceNode/*'/>
	public Node ReferenceNode { get; }
	///<include file='Utils/Docs/NodeIteratorPointerBeforeReferenceNode/NodeIteratorPointerBeforeReferenceNode.generated.xml' path='docs/NodeIteratorPointerBeforeReferenceNode/*'/>
	public bool PointerBeforeReferenceNode { get; }
	///<include file='Utils/Docs/NodeIteratorWhatToShow/NodeIteratorWhatToShow.generated.xml' path='docs/NodeIteratorWhatToShow/*'/>
	public ulong WhatToShow { get; }
	///<include file='Utils/Docs/NodeIteratorFilter/NodeIteratorFilter.generated.xml' path='docs/NodeIteratorFilter/*'/>
	public NodeFilter? Filter { get; }
	///<include file='Utils/Docs/NodeIteratorNextNode/NodeIteratorNextNode.generated.xml' path='docs/NodeIteratorNextNode/*'/>
	public Node? NextNode() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeIteratorPreviousNode/NodeIteratorPreviousNode.generated.xml' path='docs/NodeIteratorPreviousNode/*'/>
	public Node? PreviousNode() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeIteratorDetach/NodeIteratorDetach.generated.xml' path='docs/NodeIteratorDetach/*'/>
	public Undefined Detach() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/TreeWalker/TreeWalker.generated.xml' path='docs/TreeWalker/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class TreeWalker
{
	///<include file='Utils/Docs/TreeWalkerRoot/TreeWalkerRoot.generated.xml' path='docs/TreeWalkerRoot/*'/>
	public Node Root { get; }
	///<include file='Utils/Docs/TreeWalkerWhatToShow/TreeWalkerWhatToShow.generated.xml' path='docs/TreeWalkerWhatToShow/*'/>
	public ulong WhatToShow { get; }
	///<include file='Utils/Docs/TreeWalkerFilter/TreeWalkerFilter.generated.xml' path='docs/TreeWalkerFilter/*'/>
	public NodeFilter? Filter { get; }
	///<include file='Utils/Docs/TreeWalkerCurrentNode/TreeWalkerCurrentNode.generated.xml' path='docs/TreeWalkerCurrentNode/*'/>
	public Node CurrentNode { get; set; }
	///<include file='Utils/Docs/TreeWalkerParentNode/TreeWalkerParentNode.generated.xml' path='docs/TreeWalkerParentNode/*'/>
	public Node? ParentNode() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TreeWalkerFirstChild/TreeWalkerFirstChild.generated.xml' path='docs/TreeWalkerFirstChild/*'/>
	public Node? FirstChild() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TreeWalkerLastChild/TreeWalkerLastChild.generated.xml' path='docs/TreeWalkerLastChild/*'/>
	public Node? LastChild() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TreeWalkerPreviousSibling/TreeWalkerPreviousSibling.generated.xml' path='docs/TreeWalkerPreviousSibling/*'/>
	public Node? PreviousSibling() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TreeWalkerNextSibling/TreeWalkerNextSibling.generated.xml' path='docs/TreeWalkerNextSibling/*'/>
	public Node? NextSibling() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TreeWalkerPreviousNode/TreeWalkerPreviousNode.generated.xml' path='docs/TreeWalkerPreviousNode/*'/>
	public Node? PreviousNode() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TreeWalkerNextNode/TreeWalkerNextNode.generated.xml' path='docs/TreeWalkerNextNode/*'/>
	public Node? NextNode() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NodeFilter
{
		public const ushort FILTER_ACCEPT = 1;
		public const ushort FILTER_REJECT = 2;
		public const ushort FILTER_SKIP = 3;
		public const ulong SHOW_ALL = 0xFFFFFFFF;
		public const ulong SHOW_ELEMENT = 0x1;
		public const ulong SHOW_ATTRIBUTE = 0x2;
		public const ulong SHOW_TEXT = 0x4;
		public const ulong SHOW_CDATA_SECTION = 0x8;
		public const ulong SHOW_ENTITY_REFERENCE = 0x10;
		public const ulong SHOW_ENTITY = 0x20;
		public const ulong SHOW_PROCESSING_INSTRUCTION = 0x40;
		public const ulong SHOW_COMMENT = 0x80;
		public const ulong SHOW_DOCUMENT = 0x100;
		public const ulong SHOW_DOCUMENT_TYPE = 0x200;
		public const ulong SHOW_DOCUMENT_FRAGMENT = 0x400;
		public const ulong SHOW_NOTATION = 0x800;
		public ushort AcceptNode(Node node) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/DOMTokenList/DOMTokenList.generated.xml' path='docs/DOMTokenList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMTokenList
{
	///<include file='Utils/Docs/DOMTokenListLength/DOMTokenListLength.generated.xml' path='docs/DOMTokenListLength/*'/>
	public ulong Length { get; }
	
	///<include file='Utils/Docs/DOMTokenListContains/DOMTokenListContains.generated.xml' path='docs/DOMTokenListContains/*'/>
	public bool Contains(string token) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMTokenListAdd/DOMTokenListAdd.generated.xml' path='docs/DOMTokenListAdd/*'/>
	public Undefined Add(params string[] tokens) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMTokenListRemove/DOMTokenListRemove.generated.xml' path='docs/DOMTokenListRemove/*'/>
	public Undefined Remove(params string[] tokens) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMTokenListToggle/DOMTokenListToggle.generated.xml' path='docs/DOMTokenListToggle/*'/>
	public bool Toggle(string token, bool force) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMTokenListReplace/DOMTokenListReplace.generated.xml' path='docs/DOMTokenListReplace/*'/>
	public bool Replace(string token, string newToken) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMTokenListSupports/DOMTokenListSupports.generated.xml' path='docs/DOMTokenListSupports/*'/>
	public bool Supports(string token) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMTokenListValue/DOMTokenListValue.generated.xml' path='docs/DOMTokenListValue/*'/>
	public string Value { get; set; }
	public string this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
}

///<include file='Utils/Docs/XPathResult/XPathResult.generated.xml' path='docs/XPathResult/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XPathResult
{
		public const ushort ANY_TYPE = 0;
		public const ushort NUMBER_TYPE = 1;
		public const ushort STRING_TYPE = 2;
		public const ushort BOOLEAN_TYPE = 3;
		public const ushort UNORDERED_NODE_ITERATOR_TYPE = 4;
		public const ushort ORDERED_NODE_ITERATOR_TYPE = 5;
		public const ushort UNORDERED_NODE_SNAPSHOT_TYPE = 6;
		public const ushort ORDERED_NODE_SNAPSHOT_TYPE = 7;
		public const ushort ANY_UNORDERED_NODE_TYPE = 8;
		public const ushort FIRST_ORDERED_NODE_TYPE = 9;
	///<include file='Utils/Docs/XPathResultResultType/XPathResultResultType.generated.xml' path='docs/XPathResultResultType/*'/>
	public ushort ResultType { get; }
	///<include file='Utils/Docs/XPathResultNumberValue/XPathResultNumberValue.generated.xml' path='docs/XPathResultNumberValue/*'/>
	public double NumberValue { get; }
	///<include file='Utils/Docs/XPathResultStringValue/XPathResultStringValue.generated.xml' path='docs/XPathResultStringValue/*'/>
	public string StringValue { get; }
	///<include file='Utils/Docs/XPathResultBooleanValue/XPathResultBooleanValue.generated.xml' path='docs/XPathResultBooleanValue/*'/>
	public bool BooleanValue { get; }
	///<include file='Utils/Docs/XPathResultSingleNodeValue/XPathResultSingleNodeValue.generated.xml' path='docs/XPathResultSingleNodeValue/*'/>
	public Node? SingleNodeValue { get; }
	///<include file='Utils/Docs/XPathResultInvalidIteratorState/XPathResultInvalidIteratorState.generated.xml' path='docs/XPathResultInvalidIteratorState/*'/>
	public bool InvalidIteratorState { get; }
	///<include file='Utils/Docs/XPathResultSnapshotLength/XPathResultSnapshotLength.generated.xml' path='docs/XPathResultSnapshotLength/*'/>
	public ulong SnapshotLength { get; }
	///<include file='Utils/Docs/XPathResultIterateNext/XPathResultIterateNext.generated.xml' path='docs/XPathResultIterateNext/*'/>
	public Node? IterateNext() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XPathResultSnapshotItem/XPathResultSnapshotItem.generated.xml' path='docs/XPathResultSnapshotItem/*'/>
	public Node? SnapshotItem(ulong index) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XPathExpression/XPathExpression.generated.xml' path='docs/XPathExpression/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XPathExpression
{
	///<include file='Utils/Docs/XPathExpressionEvaluate/XPathExpressionEvaluate.generated.xml' path='docs/XPathExpressionEvaluate/*'/>
	public XPathResult Evaluate(Node contextNode, ushort type, XPathResult? result) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XPathNSResolver/XPathNSResolver.generated.xml' path='docs/XPathNSResolver/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface XPathNSResolver
{
	///<include file='Utils/Docs/XPathNSResolverLookupNamespaceURI/XPathNSResolverLookupNamespaceURI.generated.xml' path='docs/XPathNSResolverLookupNamespaceURI/*'/>
	public string? LookupNamespaceURI(string? prefix) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface XPathEvaluatorBase
{
		public XPathExpression CreateExpression(string expression, XPathNSResolver? resolver) { throw new System.NotImplementedException(); }
		public Node CreateNSResolver(Node nodeResolver) { throw new System.NotImplementedException(); }
		public XPathResult Evaluate(string expression, Node contextNode, XPathNSResolver? resolver, ushort type, XPathResult? result) { throw new System.NotImplementedException(); }
}


///<include file='Utils/Docs/XPathEvaluator/XPathEvaluator.generated.xml' path='docs/XPathEvaluator/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XPathEvaluator
{
	///<include file='Utils/Docs/XPathEvaluatorXPathEvaluator/XPathEvaluatorXPathEvaluator.generated.xml' path='docs/XPathEvaluatorXPathEvaluator/*'/>
	public XPathEvaluator() { }
}


///<include file='Utils/Docs/XSLTProcessor/XSLTProcessor.generated.xml' path='docs/XSLTProcessor/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XSLTProcessor
{
	///<include file='Utils/Docs/XSLTProcessorXSLTProcessor/XSLTProcessorXSLTProcessor.generated.xml' path='docs/XSLTProcessorXSLTProcessor/*'/>
	public XSLTProcessor() { }
	///<include file='Utils/Docs/XSLTProcessorImportStylesheet/XSLTProcessorImportStylesheet.generated.xml' path='docs/XSLTProcessorImportStylesheet/*'/>
	public Undefined ImportStylesheet(Node style) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XSLTProcessorTransformToFragment/XSLTProcessorTransformToFragment.generated.xml' path='docs/XSLTProcessorTransformToFragment/*'/>
	public DocumentFragment TransformToFragment(Node source, Document output) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XSLTProcessorTransformToDocument/XSLTProcessorTransformToDocument.generated.xml' path='docs/XSLTProcessorTransformToDocument/*'/>
	public Document TransformToDocument(Node source) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XSLTProcessorSetParameter/XSLTProcessorSetParameter.generated.xml' path='docs/XSLTProcessorSetParameter/*'/>
	public Undefined SetParameter(string namespaceURI, string localName, dynamic value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XSLTProcessorGetParameter/XSLTProcessorGetParameter.generated.xml' path='docs/XSLTProcessorGetParameter/*'/>
	public dynamic GetParameter(string namespaceURI, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XSLTProcessorRemoveParameter/XSLTProcessorRemoveParameter.generated.xml' path='docs/XSLTProcessorRemoveParameter/*'/>
	public Undefined RemoveParameter(string namespaceURI, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XSLTProcessorClearParameters/XSLTProcessorClearParameters.generated.xml' path='docs/XSLTProcessorClearParameters/*'/>
	public Undefined ClearParameters() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XSLTProcessorReset/XSLTProcessorReset.generated.xml' path='docs/XSLTProcessorReset/*'/>
	public Undefined Reset() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/DOMParser/DOMParser.generated.xml' path='docs/DOMParser/*'/>
public partial class DOMParser
{
	
	///<include file='Utils/Docs/DOMParserParseFromString/DOMParserParseFromString.generated.xml' path='docs/DOMParserParseFromString/*'/>
	public Document ParseFromString(string str, Unsupported /*SupportedType*/ type) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XMLSerializer/XMLSerializer.generated.xml' path='docs/XMLSerializer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XMLSerializer
{
	///<include file='Utils/Docs/XMLSerializerXMLSerializer/XMLSerializerXMLSerializer.generated.xml' path='docs/XMLSerializerXMLSerializer/*'/>
	public XMLSerializer() { }
	///<include file='Utils/Docs/XMLSerializerSerializeToString/XMLSerializerSerializeToString.generated.xml' path='docs/XMLSerializerSerializeToString/*'/>
	public string SerializeToString(Node root) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Element/Element.generated.xml' path='docs/Element/*'/>
public partial class Element
{
	///<include file='Utils/Docs/ElementInnerHTML/ElementInnerHTML.generated.xml' path='docs/ElementInnerHTML/*'/>
	public string InnerHTML { get; set; }
	///<include file='Utils/Docs/ElementOuterHTML/ElementOuterHTML.generated.xml' path='docs/ElementOuterHTML/*'/>
	public string OuterHTML { get; set; }
	///<include file='Utils/Docs/ElementInsertAdjacentHTML/ElementInsertAdjacentHTML.generated.xml' path='docs/ElementInsertAdjacentHTML/*'/>
	public Undefined InsertAdjacentHTML(string position, string text) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Range/Range.generated.xml' path='docs/Range/*'/>
public partial class Range
{
	///<include file='Utils/Docs/RangeCreateContextualFragment/RangeCreateContextualFragment.generated.xml' path='docs/RangeCreateContextualFragment/*'/>
	public DocumentFragment CreateContextualFragment(string fragment) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/PerformanceEventTiming/PerformanceEventTiming.generated.xml' path='docs/PerformanceEventTiming/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PerformanceEventTiming
{
	///<include file='Utils/Docs/PerformanceEventTimingProcessingStart/PerformanceEventTimingProcessingStart.generated.xml' path='docs/PerformanceEventTimingProcessingStart/*'/>
	public Unsupported /*DOMHighResTimeStamp*/ ProcessingStart { get; }
	///<include file='Utils/Docs/PerformanceEventTimingProcessingEnd/PerformanceEventTimingProcessingEnd.generated.xml' path='docs/PerformanceEventTimingProcessingEnd/*'/>
	public Unsupported /*DOMHighResTimeStamp*/ ProcessingEnd { get; }
	///<include file='Utils/Docs/PerformanceEventTimingCancelable/PerformanceEventTimingCancelable.generated.xml' path='docs/PerformanceEventTimingCancelable/*'/>
	public bool Cancelable { get; }
	///<include file='Utils/Docs/PerformanceEventTimingTarget/PerformanceEventTimingTarget.generated.xml' path='docs/PerformanceEventTimingTarget/*'/>
	public Node? Target { get; }
	///<include file='Utils/Docs/PerformanceEventTimingInteractionId/PerformanceEventTimingInteractionId.generated.xml' path='docs/PerformanceEventTimingInteractionId/*'/>
	public ulong InteractionId { get; }
	///<include file='Utils/Docs/PerformanceEventTimingToJSON/PerformanceEventTimingToJSON.generated.xml' path='docs/PerformanceEventTimingToJSON/*'/>
	public object ToJSON() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/EventCounts/EventCounts.generated.xml' path='docs/EventCounts/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class EventCounts
{
	
}

///<include file='Utils/Docs/Performance/Performance.generated.xml' path='docs/Performance/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Performance
{
	///<include file='Utils/Docs/PerformanceEventCounts/PerformanceEventCounts.generated.xml' path='docs/PerformanceEventCounts/*'/>
	public EventCounts EventCounts { get; }
		public ulong InteractionCount { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PerformanceObserverInit
{
		public Unsupported /*DOMHighResTimeStamp*/ DurationThreshold;
}

///<include file='Utils/Docs/Blob/Blob.generated.xml' path='docs/Blob/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Blob
{
	///<include file='Utils/Docs/BlobBlob/BlobBlob.generated.xml' path='docs/BlobBlob/*'/>
	public Blob(List<BlobPart> blobParts, BlobPropertyBag options) { }
	///<include file='Utils/Docs/BlobSize/BlobSize.generated.xml' path='docs/BlobSize/*'/>
	public ulong Size { get; }
	///<include file='Utils/Docs/BlobType/BlobType.generated.xml' path='docs/BlobType/*'/>
	public string Type { get; }
	///<include file='Utils/Docs/BlobSlice/BlobSlice.generated.xml' path='docs/BlobSlice/*'/>
	public Blob Slice(long start, long end, string contentType) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BlobStream/BlobStream.generated.xml' path='docs/BlobStream/*'/>
	public ReadableStream Stream() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BlobText/BlobText.generated.xml' path='docs/BlobText/*'/>
	public Task<string> Text() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BlobArrayBuffer/BlobArrayBuffer.generated.xml' path='docs/BlobArrayBuffer/*'/>
	public Task<byte[]> ArrayBuffer() { throw new System.NotImplementedException(); }
	public Blob() { }
}

public enum EndingType
{
	Transparent,
	Native,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class BlobPropertyBag
{
		public string Type;
		public EndingType Endings;
}


///<include file='Utils/Docs/File/File.generated.xml' path='docs/File/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class File : Blob
{
	///<include file='Utils/Docs/FileFile/FileFile.generated.xml' path='docs/FileFile/*'/>
	public File(List<BlobPart> fileBits, string fileName, FilePropertyBag options) { }
	///<include file='Utils/Docs/FileName/FileName.generated.xml' path='docs/FileName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs/FileLastModified/FileLastModified.generated.xml' path='docs/FileLastModified/*'/>
	public long LastModified { get; }
	public File() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FilePropertyBag : BlobPropertyBag
{
		public long LastModified;
}

///<include file='Utils/Docs/FileList/FileList.generated.xml' path='docs/FileList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FileList
{
	
	///<include file='Utils/Docs/FileListLength/FileListLength.generated.xml' path='docs/FileListLength/*'/>
	public ulong Length { get; }
}

///<include file='Utils/Docs/FileReader/FileReader.generated.xml' path='docs/FileReader/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FileReader : EventTarget
{
	///<include file='Utils/Docs/FileReaderFileReader/FileReaderFileReader.generated.xml' path='docs/FileReaderFileReader/*'/>
	public FileReader() { }
	///<include file='Utils/Docs/FileReaderReadAsArrayBuffer/FileReaderReadAsArrayBuffer.generated.xml' path='docs/FileReaderReadAsArrayBuffer/*'/>
	public Undefined ReadAsArrayBuffer(Blob blob) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileReaderReadAsBinaryString/FileReaderReadAsBinaryString.generated.xml' path='docs/FileReaderReadAsBinaryString/*'/>
	public Undefined ReadAsBinaryString(Blob blob) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileReaderReadAsText/FileReaderReadAsText.generated.xml' path='docs/FileReaderReadAsText/*'/>
	public Undefined ReadAsText(Blob blob, string encoding) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileReaderReadAsDataURL/FileReaderReadAsDataURL.generated.xml' path='docs/FileReaderReadAsDataURL/*'/>
	public Undefined ReadAsDataURL(Blob blob) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileReaderAbort/FileReaderAbort.generated.xml' path='docs/FileReaderAbort/*'/>
	public Undefined Abort() { throw new System.NotImplementedException(); }
		public const ushort EMPTY = 0;
		public const ushort LOADING = 1;
		public const ushort DONE = 2;
	///<include file='Utils/Docs/FileReaderReadyState/FileReaderReadyState.generated.xml' path='docs/FileReaderReadyState/*'/>
	public ushort ReadyState { get; }
	///<include file='Utils/Docs/FileReaderResult/FileReaderResult.generated.xml' path='docs/FileReaderResult/*'/>
	public Union52? Result { get; }
	///<include file='Utils/Docs/FileReaderError/FileReaderError.generated.xml' path='docs/FileReaderError/*'/>
	public DOMException? Error { get; }
		public EventHandler Onloadstart { get; set; }
		public EventHandler Onprogress { get; set; }
		public EventHandler Onload { get; set; }
		public EventHandler Onabort { get; set; }
		public EventHandler Onerror { get; set; }
		public EventHandler Onloadend { get; set; }
}

///<include file='Utils/Docs/FileReaderSync/FileReaderSync.generated.xml' path='docs/FileReaderSync/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FileReaderSync
{
	///<include file='Utils/Docs/FileReaderSyncFileReaderSync/FileReaderSyncFileReaderSync.generated.xml' path='docs/FileReaderSyncFileReaderSync/*'/>
	public FileReaderSync() { }
	///<include file='Utils/Docs/FileReaderSyncReadAsArrayBuffer/FileReaderSyncReadAsArrayBuffer.generated.xml' path='docs/FileReaderSyncReadAsArrayBuffer/*'/>
	public byte[] ReadAsArrayBuffer(Blob blob) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileReaderSyncReadAsBinaryString/FileReaderSyncReadAsBinaryString.generated.xml' path='docs/FileReaderSyncReadAsBinaryString/*'/>
	public string ReadAsBinaryString(Blob blob) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileReaderSyncReadAsText/FileReaderSyncReadAsText.generated.xml' path='docs/FileReaderSyncReadAsText/*'/>
	public string ReadAsText(Blob blob, string encoding) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileReaderSyncReadAsDataURL/FileReaderSyncReadAsDataURL.generated.xml' path='docs/FileReaderSyncReadAsDataURL/*'/>
	public string ReadAsDataURL(Blob blob) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/URL/URL.generated.xml' path='docs/URL/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class URL
{
		public static string CreateObjectURL(Union53 obj) { throw new System.NotImplementedException(); }
		public static Undefined RevokeObjectURL(string url) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/SVGFilterElement/SVGFilterElement.generated.xml' path='docs/SVGFilterElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFilterElement
{
		public Unsupported /*SVGAnimatedEnumeration*/ FilterUnits { get; }
		public Unsupported /*SVGAnimatedEnumeration*/ PrimitiveUnits { get; }
		public Unsupported /*SVGAnimatedLength*/ X { get; }
		public Unsupported /*SVGAnimatedLength*/ Y { get; }
		public Unsupported /*SVGAnimatedLength*/ Width { get; }
		public Unsupported /*SVGAnimatedLength*/ Height { get; }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial interface SVGFilterPrimitiveStandardAttributes
{
		public Unsupported /*SVGAnimatedLength*/ X { get { throw new System.NotImplementedException(); } }
		public Unsupported /*SVGAnimatedLength*/ Y { get { throw new System.NotImplementedException(); } }
		public Unsupported /*SVGAnimatedLength*/ Width { get { throw new System.NotImplementedException(); } }
		public Unsupported /*SVGAnimatedLength*/ Height { get { throw new System.NotImplementedException(); } }
		public Unsupported /*SVGAnimatedString*/ Result { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/SVGFEBlendElement/SVGFEBlendElement.generated.xml' path='docs/SVGFEBlendElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEBlendElement : SVGFilterPrimitiveStandardAttributes
{
		public const ushort SVG_FEBLEND_MODE_UNKNOWN = 0;
		public const ushort SVG_FEBLEND_MODE_NORMAL = 1;
		public const ushort SVG_FEBLEND_MODE_MULTIPLY = 2;
		public const ushort SVG_FEBLEND_MODE_SCREEN = 3;
		public const ushort SVG_FEBLEND_MODE_DARKEN = 4;
		public const ushort SVG_FEBLEND_MODE_LIGHTEN = 5;
		public const ushort SVG_FEBLEND_MODE_OVERLAY = 6;
		public const ushort SVG_FEBLEND_MODE_COLOR_DODGE = 7;
		public const ushort SVG_FEBLEND_MODE_COLOR_BURN = 8;
		public const ushort SVG_FEBLEND_MODE_HARD_LIGHT = 9;
		public const ushort SVG_FEBLEND_MODE_SOFT_LIGHT = 10;
		public const ushort SVG_FEBLEND_MODE_DIFFERENCE = 11;
		public const ushort SVG_FEBLEND_MODE_EXCLUSION = 12;
		public const ushort SVG_FEBLEND_MODE_HUE = 13;
		public const ushort SVG_FEBLEND_MODE_SATURATION = 14;
		public const ushort SVG_FEBLEND_MODE_COLOR = 15;
		public const ushort SVG_FEBLEND_MODE_LUMINOSITY = 16;
		public Unsupported /*SVGAnimatedString*/ In1 { get; }
		public Unsupported /*SVGAnimatedString*/ In2 { get; }
		public Unsupported /*SVGAnimatedEnumeration*/ Mode { get; }
}


///<include file='Utils/Docs/SVGFEColorMatrixElement/SVGFEColorMatrixElement.generated.xml' path='docs/SVGFEColorMatrixElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEColorMatrixElement : SVGFilterPrimitiveStandardAttributes
{
		public const ushort SVG_FECOLORMATRIX_TYPE_UNKNOWN = 0;
		public const ushort SVG_FECOLORMATRIX_TYPE_MATRIX = 1;
		public const ushort SVG_FECOLORMATRIX_TYPE_SATURATE = 2;
		public const ushort SVG_FECOLORMATRIX_TYPE_HUEROTATE = 3;
		public const ushort SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA = 4;
		public Unsupported /*SVGAnimatedString*/ In1 { get; }
		public Unsupported /*SVGAnimatedEnumeration*/ Type { get; }
		public Unsupported /*SVGAnimatedNumberList*/ Values { get; }
}


///<include file='Utils/Docs/SVGFEComponentTransferElement/SVGFEComponentTransferElement.generated.xml' path='docs/SVGFEComponentTransferElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEComponentTransferElement : SVGFilterPrimitiveStandardAttributes
{
		public Unsupported /*SVGAnimatedString*/ In1 { get; }
}


///<include file='Utils/Docs/SVGComponentTransferFunctionElement/SVGComponentTransferFunctionElement.generated.xml' path='docs/SVGComponentTransferFunctionElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGComponentTransferFunctionElement
{
		public const ushort SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN = 0;
		public const ushort SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY = 1;
		public const ushort SVG_FECOMPONENTTRANSFER_TYPE_TABLE = 2;
		public const ushort SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE = 3;
		public const ushort SVG_FECOMPONENTTRANSFER_TYPE_LINEAR = 4;
		public const ushort SVG_FECOMPONENTTRANSFER_TYPE_GAMMA = 5;
		public Unsupported /*SVGAnimatedEnumeration*/ Type { get; }
		public Unsupported /*SVGAnimatedNumberList*/ TableValues { get; }
		public Unsupported /*SVGAnimatedNumber*/ Slope { get; }
		public Unsupported /*SVGAnimatedNumber*/ Intercept { get; }
		public Unsupported /*SVGAnimatedNumber*/ Amplitude { get; }
		public Unsupported /*SVGAnimatedNumber*/ Exponent { get; }
		public Unsupported /*SVGAnimatedNumber*/ Offset { get; }
}

///<include file='Utils/Docs/SVGFEFuncRElement/SVGFEFuncRElement.generated.xml' path='docs/SVGFEFuncRElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEFuncRElement : SVGComponentTransferFunctionElement
{
}

///<include file='Utils/Docs/SVGFEFuncGElement/SVGFEFuncGElement.generated.xml' path='docs/SVGFEFuncGElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEFuncGElement : SVGComponentTransferFunctionElement
{
}

///<include file='Utils/Docs/SVGFEFuncBElement/SVGFEFuncBElement.generated.xml' path='docs/SVGFEFuncBElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEFuncBElement : SVGComponentTransferFunctionElement
{
}

///<include file='Utils/Docs/SVGFEFuncAElement/SVGFEFuncAElement.generated.xml' path='docs/SVGFEFuncAElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEFuncAElement : SVGComponentTransferFunctionElement
{
}

///<include file='Utils/Docs/SVGFECompositeElement/SVGFECompositeElement.generated.xml' path='docs/SVGFECompositeElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFECompositeElement : SVGFilterPrimitiveStandardAttributes
{
		public const ushort SVG_FECOMPOSITE_OPERATOR_UNKNOWN = 0;
		public const ushort SVG_FECOMPOSITE_OPERATOR_OVER = 1;
		public const ushort SVG_FECOMPOSITE_OPERATOR_IN = 2;
		public const ushort SVG_FECOMPOSITE_OPERATOR_OUT = 3;
		public const ushort SVG_FECOMPOSITE_OPERATOR_ATOP = 4;
		public const ushort SVG_FECOMPOSITE_OPERATOR_XOR = 5;
		public const ushort SVG_FECOMPOSITE_OPERATOR_ARITHMETIC = 6;
		public Unsupported /*SVGAnimatedString*/ In1 { get; }
		public Unsupported /*SVGAnimatedString*/ In2 { get; }
		public Unsupported /*SVGAnimatedEnumeration*/ Operator { get; }
		public Unsupported /*SVGAnimatedNumber*/ K1 { get; }
		public Unsupported /*SVGAnimatedNumber*/ K2 { get; }
		public Unsupported /*SVGAnimatedNumber*/ K3 { get; }
		public Unsupported /*SVGAnimatedNumber*/ K4 { get; }
}


///<include file='Utils/Docs/SVGFEConvolveMatrixElement/SVGFEConvolveMatrixElement.generated.xml' path='docs/SVGFEConvolveMatrixElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEConvolveMatrixElement : SVGFilterPrimitiveStandardAttributes
{
		public const ushort SVG_EDGEMODE_UNKNOWN = 0;
		public const ushort SVG_EDGEMODE_DUPLICATE = 1;
		public const ushort SVG_EDGEMODE_WRAP = 2;
		public const ushort SVG_EDGEMODE_NONE = 3;
		public Unsupported /*SVGAnimatedString*/ In1 { get; }
		public Unsupported /*SVGAnimatedInteger*/ OrderX { get; }
		public Unsupported /*SVGAnimatedInteger*/ OrderY { get; }
		public Unsupported /*SVGAnimatedNumberList*/ KernelMatrix { get; }
		public Unsupported /*SVGAnimatedNumber*/ Divisor { get; }
		public Unsupported /*SVGAnimatedNumber*/ Bias { get; }
		public Unsupported /*SVGAnimatedInteger*/ TargetX { get; }
		public Unsupported /*SVGAnimatedInteger*/ TargetY { get; }
		public Unsupported /*SVGAnimatedEnumeration*/ EdgeMode { get; }
		public Unsupported /*SVGAnimatedNumber*/ KernelUnitLengthX { get; }
		public Unsupported /*SVGAnimatedNumber*/ KernelUnitLengthY { get; }
		public Unsupported /*SVGAnimatedBoolean*/ PreserveAlpha { get; }
}


///<include file='Utils/Docs/SVGFEDiffuseLightingElement/SVGFEDiffuseLightingElement.generated.xml' path='docs/SVGFEDiffuseLightingElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEDiffuseLightingElement : SVGFilterPrimitiveStandardAttributes
{
		public Unsupported /*SVGAnimatedString*/ In1 { get; }
		public Unsupported /*SVGAnimatedNumber*/ SurfaceScale { get; }
		public Unsupported /*SVGAnimatedNumber*/ DiffuseConstant { get; }
		public Unsupported /*SVGAnimatedNumber*/ KernelUnitLengthX { get; }
		public Unsupported /*SVGAnimatedNumber*/ KernelUnitLengthY { get; }
}


///<include file='Utils/Docs/SVGFEDistantLightElement/SVGFEDistantLightElement.generated.xml' path='docs/SVGFEDistantLightElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEDistantLightElement
{
		public Unsupported /*SVGAnimatedNumber*/ Azimuth { get; }
		public Unsupported /*SVGAnimatedNumber*/ Elevation { get; }
}

///<include file='Utils/Docs/SVGFEPointLightElement/SVGFEPointLightElement.generated.xml' path='docs/SVGFEPointLightElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEPointLightElement
{
		public Unsupported /*SVGAnimatedNumber*/ X { get; }
		public Unsupported /*SVGAnimatedNumber*/ Y { get; }
		public Unsupported /*SVGAnimatedNumber*/ Z { get; }
}

///<include file='Utils/Docs/SVGFESpotLightElement/SVGFESpotLightElement.generated.xml' path='docs/SVGFESpotLightElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFESpotLightElement
{
		public Unsupported /*SVGAnimatedNumber*/ X { get; }
		public Unsupported /*SVGAnimatedNumber*/ Y { get; }
		public Unsupported /*SVGAnimatedNumber*/ Z { get; }
		public Unsupported /*SVGAnimatedNumber*/ PointsAtX { get; }
		public Unsupported /*SVGAnimatedNumber*/ PointsAtY { get; }
		public Unsupported /*SVGAnimatedNumber*/ PointsAtZ { get; }
		public Unsupported /*SVGAnimatedNumber*/ SpecularExponent { get; }
		public Unsupported /*SVGAnimatedNumber*/ LimitingConeAngle { get; }
}

///<include file='Utils/Docs/SVGFEDisplacementMapElement/SVGFEDisplacementMapElement.generated.xml' path='docs/SVGFEDisplacementMapElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEDisplacementMapElement : SVGFilterPrimitiveStandardAttributes
{
		public const ushort SVG_CHANNEL_UNKNOWN = 0;
		public const ushort SVG_CHANNEL_R = 1;
		public const ushort SVG_CHANNEL_G = 2;
		public const ushort SVG_CHANNEL_B = 3;
		public const ushort SVG_CHANNEL_A = 4;
		public Unsupported /*SVGAnimatedString*/ In1 { get; }
		public Unsupported /*SVGAnimatedString*/ In2 { get; }
		public Unsupported /*SVGAnimatedNumber*/ Scale { get; }
		public Unsupported /*SVGAnimatedEnumeration*/ XChannelSelector { get; }
		public Unsupported /*SVGAnimatedEnumeration*/ YChannelSelector { get; }
}


///<include file='Utils/Docs/SVGFEDropShadowElement/SVGFEDropShadowElement.generated.xml' path='docs/SVGFEDropShadowElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEDropShadowElement : SVGFilterPrimitiveStandardAttributes
{
		public Unsupported /*SVGAnimatedString*/ In1 { get; }
		public Unsupported /*SVGAnimatedNumber*/ Dx { get; }
		public Unsupported /*SVGAnimatedNumber*/ Dy { get; }
		public Unsupported /*SVGAnimatedNumber*/ StdDeviationX { get; }
		public Unsupported /*SVGAnimatedNumber*/ StdDeviationY { get; }
		public Undefined SetStdDeviation(Number stdDeviationX, Number stdDeviationY) { throw new System.NotImplementedException(); }
}


///<include file='Utils/Docs/SVGFEFloodElement/SVGFEFloodElement.generated.xml' path='docs/SVGFEFloodElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEFloodElement : SVGFilterPrimitiveStandardAttributes
{
}


///<include file='Utils/Docs/SVGFEGaussianBlurElement/SVGFEGaussianBlurElement.generated.xml' path='docs/SVGFEGaussianBlurElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEGaussianBlurElement : SVGFilterPrimitiveStandardAttributes
{
		public const ushort SVG_EDGEMODE_UNKNOWN = 0;
		public const ushort SVG_EDGEMODE_DUPLICATE = 1;
		public const ushort SVG_EDGEMODE_WRAP = 2;
		public const ushort SVG_EDGEMODE_NONE = 3;
		public Unsupported /*SVGAnimatedString*/ In1 { get; }
		public Unsupported /*SVGAnimatedNumber*/ StdDeviationX { get; }
		public Unsupported /*SVGAnimatedNumber*/ StdDeviationY { get; }
		public Unsupported /*SVGAnimatedEnumeration*/ EdgeMode { get; }
		public Undefined SetStdDeviation(Number stdDeviationX, Number stdDeviationY) { throw new System.NotImplementedException(); }
}


///<include file='Utils/Docs/SVGFEImageElement/SVGFEImageElement.generated.xml' path='docs/SVGFEImageElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEImageElement : SVGFilterPrimitiveStandardAttributes
{
		public Unsupported /*SVGAnimatedPreserveAspectRatio*/ PreserveAspectRatio { get; }
		public Unsupported /*SVGAnimatedString*/ CrossOrigin { get; }
}



///<include file='Utils/Docs/SVGFEMergeElement/SVGFEMergeElement.generated.xml' path='docs/SVGFEMergeElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEMergeElement : SVGFilterPrimitiveStandardAttributes
{
}


///<include file='Utils/Docs/SVGFEMergeNodeElement/SVGFEMergeNodeElement.generated.xml' path='docs/SVGFEMergeNodeElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEMergeNodeElement
{
		public Unsupported /*SVGAnimatedString*/ In1 { get; }
}

///<include file='Utils/Docs/SVGFEMorphologyElement/SVGFEMorphologyElement.generated.xml' path='docs/SVGFEMorphologyElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEMorphologyElement : SVGFilterPrimitiveStandardAttributes
{
		public const ushort SVG_MORPHOLOGY_OPERATOR_UNKNOWN = 0;
		public const ushort SVG_MORPHOLOGY_OPERATOR_ERODE = 1;
		public const ushort SVG_MORPHOLOGY_OPERATOR_DILATE = 2;
		public Unsupported /*SVGAnimatedString*/ In1 { get; }
		public Unsupported /*SVGAnimatedEnumeration*/ Operator { get; }
		public Unsupported /*SVGAnimatedNumber*/ RadiusX { get; }
		public Unsupported /*SVGAnimatedNumber*/ RadiusY { get; }
}


///<include file='Utils/Docs/SVGFEOffsetElement/SVGFEOffsetElement.generated.xml' path='docs/SVGFEOffsetElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFEOffsetElement : SVGFilterPrimitiveStandardAttributes
{
		public Unsupported /*SVGAnimatedString*/ In1 { get; }
		public Unsupported /*SVGAnimatedNumber*/ Dx { get; }
		public Unsupported /*SVGAnimatedNumber*/ Dy { get; }
}


///<include file='Utils/Docs/SVGFESpecularLightingElement/SVGFESpecularLightingElement.generated.xml' path='docs/SVGFESpecularLightingElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFESpecularLightingElement : SVGFilterPrimitiveStandardAttributes
{
		public Unsupported /*SVGAnimatedString*/ In1 { get; }
		public Unsupported /*SVGAnimatedNumber*/ SurfaceScale { get; }
		public Unsupported /*SVGAnimatedNumber*/ SpecularConstant { get; }
		public Unsupported /*SVGAnimatedNumber*/ SpecularExponent { get; }
		public Unsupported /*SVGAnimatedNumber*/ KernelUnitLengthX { get; }
		public Unsupported /*SVGAnimatedNumber*/ KernelUnitLengthY { get; }
}


///<include file='Utils/Docs/SVGFETileElement/SVGFETileElement.generated.xml' path='docs/SVGFETileElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFETileElement : SVGFilterPrimitiveStandardAttributes
{
		public Unsupported /*SVGAnimatedString*/ In1 { get; }
}


///<include file='Utils/Docs/SVGFETurbulenceElement/SVGFETurbulenceElement.generated.xml' path='docs/SVGFETurbulenceElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SVGFETurbulenceElement : SVGFilterPrimitiveStandardAttributes
{
		public const ushort SVG_TURBULENCE_TYPE_UNKNOWN = 0;
		public const ushort SVG_TURBULENCE_TYPE_FRACTALNOISE = 1;
		public const ushort SVG_TURBULENCE_TYPE_TURBULENCE = 2;
		public const ushort SVG_STITCHTYPE_UNKNOWN = 0;
		public const ushort SVG_STITCHTYPE_STITCH = 1;
		public const ushort SVG_STITCHTYPE_NOSTITCH = 2;
		public Unsupported /*SVGAnimatedNumber*/ BaseFrequencyX { get; }
		public Unsupported /*SVGAnimatedNumber*/ BaseFrequencyY { get; }
		public Unsupported /*SVGAnimatedInteger*/ NumOctaves { get; }
		public Unsupported /*SVGAnimatedNumber*/ Seed { get; }
		public Unsupported /*SVGAnimatedEnumeration*/ StitchTiles { get; }
		public Unsupported /*SVGAnimatedEnumeration*/ Type { get; }
}


///<include file='Utils/Docs/Sensor/Sensor.generated.xml' path='docs/Sensor/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Sensor : EventTarget
{
	///<include file='Utils/Docs/SensorActivated/SensorActivated.generated.xml' path='docs/SensorActivated/*'/>
	public bool Activated { get; }
	///<include file='Utils/Docs/SensorHasReading/SensorHasReading.generated.xml' path='docs/SensorHasReading/*'/>
	public bool HasReading { get; }
	///<include file='Utils/Docs/SensorTimestamp/SensorTimestamp.generated.xml' path='docs/SensorTimestamp/*'/>
	public Unsupported /*DOMHighResTimeStamp*/? Timestamp { get; }
	///<include file='Utils/Docs/SensorStart/SensorStart.generated.xml' path='docs/SensorStart/*'/>
	public Undefined Start() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/SensorStop/SensorStop.generated.xml' path='docs/SensorStop/*'/>
	public Undefined Stop() { throw new System.NotImplementedException(); }
		public EventHandler Onreading { get; set; }
		public EventHandler Onactivate { get; set; }
		public EventHandler Onerror { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class SensorOptions
{
		public Number Frequency;
}

///<include file='Utils/Docs/SensorErrorEvent/SensorErrorEvent.generated.xml' path='docs/SensorErrorEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SensorErrorEvent : Event
{
	///<include file='Utils/Docs/SensorErrorEventSensorErrorEvent/SensorErrorEventSensorErrorEvent.generated.xml' path='docs/SensorErrorEventSensorErrorEvent/*'/>
	public SensorErrorEvent(string type, SensorErrorEventInit errorEventInitDict) { }
	///<include file='Utils/Docs/SensorErrorEventError/SensorErrorEventError.generated.xml' path='docs/SensorErrorEventError/*'/>
	public DOMException Error { get; }
	public SensorErrorEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class SensorErrorEventInit : EventInit
{
		public required DOMException Error;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GeolocationSensor : Sensor
{
		public GeolocationSensor(GeolocationSensorOptions options) { }
		public static Task<GeolocationSensorReading> Read(ReadOptions readOptions) { throw new System.NotImplementedException(); }
		public double? Latitude { get; }
		public double? Longitude { get; }
		public double? Altitude { get; }
		public double? Accuracy { get; }
		public double? AltitudeAccuracy { get; }
		public double? Heading { get; }
		public double? Speed { get; }
	public GeolocationSensor() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GeolocationSensorOptions : SensorOptions
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ReadOptions : GeolocationSensorOptions
{
		public AbortSignal? Signal;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GeolocationSensorReading
{
		public Unsupported /*DOMHighResTimeStamp*/? Timestamp;
		public Number? Latitude;
		public Number? Longitude;
		public Number? Altitude;
		public Number? Accuracy;
		public Number? AltitudeAccuracy;
		public Number? Heading;
		public Number? Speed;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GeolocationReadingValues
{
		public required Number? Latitude;
		public required Number? Longitude;
		public required Number? Altitude;
		public required Number? Accuracy;
		public required Number? AltitudeAccuracy;
		public required Number? Heading;
		public required Number? Speed;
}

///<include file='Utils/Docs/DOMPointReadOnly/DOMPointReadOnly.generated.xml' path='docs/DOMPointReadOnly/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMPointReadOnly
{
	///<include file='Utils/Docs/DOMPointReadOnlyDOMPointReadOnly/DOMPointReadOnlyDOMPointReadOnly.generated.xml' path='docs/DOMPointReadOnlyDOMPointReadOnly/*'/>
	public DOMPointReadOnly(double x, double y, double z, double w) { }
		public static DOMPointReadOnly FromPoint(DOMPointInit other) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMPointReadOnlyX/DOMPointReadOnlyX.generated.xml' path='docs/DOMPointReadOnlyX/*'/>
	public double X { get; }
	///<include file='Utils/Docs/DOMPointReadOnlyY/DOMPointReadOnlyY.generated.xml' path='docs/DOMPointReadOnlyY/*'/>
	public double Y { get; }
	///<include file='Utils/Docs/DOMPointReadOnlyZ/DOMPointReadOnlyZ.generated.xml' path='docs/DOMPointReadOnlyZ/*'/>
	public double Z { get; }
	///<include file='Utils/Docs/DOMPointReadOnlyW/DOMPointReadOnlyW.generated.xml' path='docs/DOMPointReadOnlyW/*'/>
	public double W { get; }
		public DOMPoint MatrixTransform(DOMMatrixInit matrix) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMPointReadOnlyToJSON/DOMPointReadOnlyToJSON.generated.xml' path='docs/DOMPointReadOnlyToJSON/*'/>
	public object ToJSON() { throw new System.NotImplementedException(); }
	public DOMPointReadOnly() { }
}

///<include file='Utils/Docs/DOMPoint/DOMPoint.generated.xml' path='docs/DOMPoint/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMPoint : DOMPointReadOnly
{
	///<include file='Utils/Docs/DOMPointDOMPoint/DOMPointDOMPoint.generated.xml' path='docs/DOMPointDOMPoint/*'/>
	public DOMPoint(double x, double y, double z, double w) { }
		public static DOMPoint FromPoint(DOMPointInit other) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMPointX/DOMPointX.generated.xml' path='docs/DOMPointX/*'/>
	public double X { get; set; }
	///<include file='Utils/Docs/DOMPointY/DOMPointY.generated.xml' path='docs/DOMPointY/*'/>
	public double Y { get; set; }
	///<include file='Utils/Docs/DOMPointZ/DOMPointZ.generated.xml' path='docs/DOMPointZ/*'/>
	public double Z { get; set; }
	///<include file='Utils/Docs/DOMPointW/DOMPointW.generated.xml' path='docs/DOMPointW/*'/>
	public double W { get; set; }
	public DOMPoint() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMPointInit
{
		public double X;
		public double Y;
		public double Z;
		public double W;
}

///<include file='Utils/Docs/DOMRectReadOnly/DOMRectReadOnly.generated.xml' path='docs/DOMRectReadOnly/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMRectReadOnly
{
	///<include file='Utils/Docs/DOMRectReadOnlyDOMRectReadOnly/DOMRectReadOnlyDOMRectReadOnly.generated.xml' path='docs/DOMRectReadOnlyDOMRectReadOnly/*'/>
	public DOMRectReadOnly(double x, double y, double width, double height) { }
		public static DOMRectReadOnly FromRect(DOMRectInit other) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMRectReadOnlyX/DOMRectReadOnlyX.generated.xml' path='docs/DOMRectReadOnlyX/*'/>
	public double X { get; }
	///<include file='Utils/Docs/DOMRectReadOnlyY/DOMRectReadOnlyY.generated.xml' path='docs/DOMRectReadOnlyY/*'/>
	public double Y { get; }
	///<include file='Utils/Docs/DOMRectReadOnlyWidth/DOMRectReadOnlyWidth.generated.xml' path='docs/DOMRectReadOnlyWidth/*'/>
	public double Width { get; }
	///<include file='Utils/Docs/DOMRectReadOnlyHeight/DOMRectReadOnlyHeight.generated.xml' path='docs/DOMRectReadOnlyHeight/*'/>
	public double Height { get; }
	///<include file='Utils/Docs/DOMRectReadOnlyTop/DOMRectReadOnlyTop.generated.xml' path='docs/DOMRectReadOnlyTop/*'/>
	public double Top { get; }
	///<include file='Utils/Docs/DOMRectReadOnlyRight/DOMRectReadOnlyRight.generated.xml' path='docs/DOMRectReadOnlyRight/*'/>
	public double Right { get; }
	///<include file='Utils/Docs/DOMRectReadOnlyBottom/DOMRectReadOnlyBottom.generated.xml' path='docs/DOMRectReadOnlyBottom/*'/>
	public double Bottom { get; }
	///<include file='Utils/Docs/DOMRectReadOnlyLeft/DOMRectReadOnlyLeft.generated.xml' path='docs/DOMRectReadOnlyLeft/*'/>
	public double Left { get; }
		public object ToJSON() { throw new System.NotImplementedException(); }
	public DOMRectReadOnly() { }
}

///<include file='Utils/Docs/DOMRect/DOMRect.generated.xml' path='docs/DOMRect/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMRect : DOMRectReadOnly
{
	///<include file='Utils/Docs/DOMRectDOMRect/DOMRectDOMRect.generated.xml' path='docs/DOMRectDOMRect/*'/>
	public DOMRect(double x, double y, double width, double height) { }
		public static DOMRect FromRect(DOMRectInit other) { throw new System.NotImplementedException(); }
		public double X { get; set; }
		public double Y { get; set; }
		public double Width { get; set; }
		public double Height { get; set; }
	public DOMRect() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMRectInit
{
		public double X;
		public double Y;
		public double Width;
		public double Height;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMRectList
{
		public ulong Length { get; }
	
}

///<include file='Utils/Docs/DOMQuad/DOMQuad.generated.xml' path='docs/DOMQuad/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMQuad
{
		public DOMQuad(DOMPointInit p1, DOMPointInit p2, DOMPointInit p3, DOMPointInit p4) { }
		public static DOMQuad FromRect(DOMRectInit other) { throw new System.NotImplementedException(); }
		public static DOMQuad FromQuad(DOMQuadInit other) { throw new System.NotImplementedException(); }
		public DOMPoint P1 { get; }
		public DOMPoint P2 { get; }
		public DOMPoint P3 { get; }
		public DOMPoint P4 { get; }
		public DOMRect GetBounds() { throw new System.NotImplementedException(); }
		public object ToJSON() { throw new System.NotImplementedException(); }
	public DOMQuad() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMQuadInit
{
		public DOMPointInit P1;
		public DOMPointInit P2;
		public DOMPointInit P3;
		public DOMPointInit P4;
}

///<include file='Utils/Docs/DOMMatrixReadOnly/DOMMatrixReadOnly.generated.xml' path='docs/DOMMatrixReadOnly/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMMatrixReadOnly
{
	///<include file='Utils/Docs/DOMMatrixReadOnlyDOMMatrixReadOnly/DOMMatrixReadOnlyDOMMatrixReadOnly.generated.xml' path='docs/DOMMatrixReadOnlyDOMMatrixReadOnly/*'/>
	public DOMMatrixReadOnly(Union54 init) { }
		public static DOMMatrixReadOnly FromMatrix(DOMMatrixInit other) { throw new System.NotImplementedException(); }
		public static DOMMatrixReadOnly FromFloat32Array(System.Single array32) { throw new System.NotImplementedException(); }
		public static DOMMatrixReadOnly FromFloat64Array(System.Double array64) { throw new System.NotImplementedException(); }
		public double A { get; }
		public double B { get; }
		public double C { get; }
		public double D { get; }
		public double E { get; }
		public double F { get; }
		public double M11 { get; }
		public double M12 { get; }
		public double M13 { get; }
		public double M14 { get; }
		public double M21 { get; }
		public double M22 { get; }
		public double M23 { get; }
		public double M24 { get; }
		public double M31 { get; }
		public double M32 { get; }
		public double M33 { get; }
		public double M34 { get; }
		public double M41 { get; }
		public double M42 { get; }
		public double M43 { get; }
		public double M44 { get; }
		public bool Is2D { get; }
		public bool IsIdentity { get; }
	///<include file='Utils/Docs/DOMMatrixReadOnlyTranslate/DOMMatrixReadOnlyTranslate.generated.xml' path='docs/DOMMatrixReadOnlyTranslate/*'/>
	public DOMMatrix Translate(double tx, double ty, double tz) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMMatrixReadOnlyScale/DOMMatrixReadOnlyScale.generated.xml' path='docs/DOMMatrixReadOnlyScale/*'/>
	public DOMMatrix Scale(double scaleX, double scaleY, double scaleZ, double originX, double originY, double originZ) { throw new System.NotImplementedException(); }
		public DOMMatrix ScaleNonUniform(double scaleX, double scaleY) { throw new System.NotImplementedException(); }
		public DOMMatrix Scale3d(double scale, double originX, double originY, double originZ) { throw new System.NotImplementedException(); }
		public DOMMatrix Rotate(double rotX, double rotY, double rotZ) { throw new System.NotImplementedException(); }
		public DOMMatrix RotateFromVector(double x, double y) { throw new System.NotImplementedException(); }
		public DOMMatrix RotateAxisAngle(double x, double y, double z, double angle) { throw new System.NotImplementedException(); }
		public DOMMatrix SkewX(double sx) { throw new System.NotImplementedException(); }
		public DOMMatrix SkewY(double sy) { throw new System.NotImplementedException(); }
		public DOMMatrix Multiply(DOMMatrixInit other) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMMatrixReadOnlyFlipX/DOMMatrixReadOnlyFlipX.generated.xml' path='docs/DOMMatrixReadOnlyFlipX/*'/>
	public DOMMatrix FlipX() { throw new System.NotImplementedException(); }
		public DOMMatrix FlipY() { throw new System.NotImplementedException(); }
		public DOMMatrix Inverse() { throw new System.NotImplementedException(); }
		public DOMPoint TransformPoint(DOMPointInit point) { throw new System.NotImplementedException(); }
		public System.Single ToFloat32Array() { throw new System.NotImplementedException(); }
		public System.Double ToFloat64Array() { throw new System.NotImplementedException(); }
	
		public object ToJSON() { throw new System.NotImplementedException(); }
	public DOMMatrixReadOnly() { }
}

///<include file='Utils/Docs/DOMMatrix/DOMMatrix.generated.xml' path='docs/DOMMatrix/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMMatrix : DOMMatrixReadOnly
{
	///<include file='Utils/Docs/DOMMatrixDOMMatrix/DOMMatrixDOMMatrix.generated.xml' path='docs/DOMMatrixDOMMatrix/*'/>
	public DOMMatrix(Union55 init) { }
		public static DOMMatrix FromMatrix(DOMMatrixInit other) { throw new System.NotImplementedException(); }
		public static DOMMatrix FromFloat32Array(System.Single array32) { throw new System.NotImplementedException(); }
		public static DOMMatrix FromFloat64Array(System.Double array64) { throw new System.NotImplementedException(); }
		public double A { get; set; }
		public double B { get; set; }
		public double C { get; set; }
		public double D { get; set; }
		public double E { get; set; }
		public double F { get; set; }
		public double M11 { get; set; }
		public double M12 { get; set; }
		public double M13 { get; set; }
		public double M14 { get; set; }
		public double M21 { get; set; }
		public double M22 { get; set; }
		public double M23 { get; set; }
		public double M24 { get; set; }
		public double M31 { get; set; }
		public double M32 { get; set; }
		public double M33 { get; set; }
		public double M34 { get; set; }
		public double M41 { get; set; }
		public double M42 { get; set; }
		public double M43 { get; set; }
		public double M44 { get; set; }
		public DOMMatrix MultiplySelf(DOMMatrixInit other) { throw new System.NotImplementedException(); }
		public DOMMatrix PreMultiplySelf(DOMMatrixInit other) { throw new System.NotImplementedException(); }
		public DOMMatrix TranslateSelf(double tx, double ty, double tz) { throw new System.NotImplementedException(); }
		public DOMMatrix ScaleSelf(double scaleX, double scaleY, double scaleZ, double originX, double originY, double originZ) { throw new System.NotImplementedException(); }
		public DOMMatrix Scale3dSelf(double scale, double originX, double originY, double originZ) { throw new System.NotImplementedException(); }
		public DOMMatrix RotateSelf(double rotX, double rotY, double rotZ) { throw new System.NotImplementedException(); }
		public DOMMatrix RotateFromVectorSelf(double x, double y) { throw new System.NotImplementedException(); }
		public DOMMatrix RotateAxisAngleSelf(double x, double y, double z, double angle) { throw new System.NotImplementedException(); }
		public DOMMatrix SkewXSelf(double sx) { throw new System.NotImplementedException(); }
		public DOMMatrix SkewYSelf(double sy) { throw new System.NotImplementedException(); }
		public DOMMatrix InvertSelf() { throw new System.NotImplementedException(); }
		public DOMMatrix SetMatrixValue(string transformList) { throw new System.NotImplementedException(); }
	public DOMMatrix() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMMatrix2DInit
{
		public double A;
		public double B;
		public double C;
		public double D;
		public double E;
		public double F;
		public double M11;
		public double M12;
		public double M21;
		public double M22;
		public double M41;
		public double M42;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMMatrixInit : DOMMatrix2DInit
{
		public double M13;
		public double M14;
		public double M23;
		public double M24;
		public double M31;
		public double M32;
		public double M33;
		public double M34;
		public double M43;
		public double M44;
		public bool Is2D;
}

///<include file='Utils/Docs/Gyroscope/Gyroscope.generated.xml' path='docs/Gyroscope/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Gyroscope : Sensor
{
	///<include file='Utils/Docs/GyroscopeGyroscope/GyroscopeGyroscope.generated.xml' path='docs/GyroscopeGyroscope/*'/>
	public Gyroscope(GyroscopeSensorOptions sensorOptions) { }
	///<include file='Utils/Docs/GyroscopeX/GyroscopeX.generated.xml' path='docs/GyroscopeX/*'/>
	public Number? X { get; }
	///<include file='Utils/Docs/GyroscopeY/GyroscopeY.generated.xml' path='docs/GyroscopeY/*'/>
	public Number? Y { get; }
	///<include file='Utils/Docs/GyroscopeZ/GyroscopeZ.generated.xml' path='docs/GyroscopeZ/*'/>
	public Number? Z { get; }
	public Gyroscope() { }
}

public enum GyroscopeLocalCoordinateSystem
{
	Device,
	Screen,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GyroscopeSensorOptions : SensorOptions
{
		public GyroscopeLocalCoordinateSystem ReferenceFrame;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface TextDecoderCommon
{
		public string Encoding { get { throw new System.NotImplementedException(); } }
		public bool Fatal { get { throw new System.NotImplementedException(); } }
		public bool IgnoreBOM { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.Default)]
public partial class TextDecoderOptions
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Fatal;
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool IgnoreBOM;
}

[To(ToAttribute.Default)]
public partial class TextDecodeOptions
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public bool Stream;
}

///<include file='Utils/Docs/TextDecoder/TextDecoder.generated.xml' path='docs/TextDecoder/*'/>
[To(ToAttribute.Default)]
public partial class TextDecoder
{
	///<include file='Utils/Docs/TextDecoderTextDecoder/TextDecoderTextDecoder.generated.xml' path='docs/TextDecoderTextDecoder/*'/>
	public TextDecoder(string label, TextDecoderOptions options) { }
	///<include file='Utils/Docs/TextDecoderDecode/TextDecoderDecode.generated.xml' path='docs/TextDecoderDecode/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Decode(AllowSharedBufferSource input, TextDecodeOptions options) { throw new System.NotImplementedException(); }
	public TextDecoder() { }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial interface TextEncoderCommon
{
		public string Encoding { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.Default)]
public partial class TextEncoderEncodeIntoResult
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Read;
		[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Written;
}

///<include file='Utils/Docs/TextEncoder/TextEncoder.generated.xml' path='docs/TextEncoder/*'/>
[To(ToAttribute.Default)]
public partial class TextEncoder
{
	///<include file='Utils/Docs/TextEncoderTextEncoder/TextEncoderTextEncoder.generated.xml' path='docs/TextEncoderTextEncoder/*'/>
	public TextEncoder() { }
	///<include file='Utils/Docs/TextEncoderEncode/TextEncoderEncode.generated.xml' path='docs/TextEncoderEncode/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public System.Byte Encode(string input) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TextEncoderEncodeInto/TextEncoderEncodeInto.generated.xml' path='docs/TextEncoderEncodeInto/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public TextEncoderEncodeIntoResult EncodeInto(string source, System.Byte destination) { throw new System.NotImplementedException(); }
}


///<include file='Utils/Docs/TextDecoderStream/TextDecoderStream.generated.xml' path='docs/TextDecoderStream/*'/>
[To(ToAttribute.Default)]
public partial class TextDecoderStream
{
	///<include file='Utils/Docs/TextDecoderStreamTextDecoderStream/TextDecoderStreamTextDecoderStream.generated.xml' path='docs/TextDecoderStreamTextDecoderStream/*'/>
	public TextDecoderStream(string label, TextDecoderOptions options) { }
	public TextDecoderStream() { }
}



///<include file='Utils/Docs/TextEncoderStream/TextEncoderStream.generated.xml' path='docs/TextEncoderStream/*'/>
[To(ToAttribute.Default)]
public partial class TextEncoderStream
{
	///<include file='Utils/Docs/TextEncoderStreamTextEncoderStream/TextEncoderStreamTextEncoderStream.generated.xml' path='docs/TextEncoderStreamTextEncoderStream/*'/>
	public TextEncoderStream() { }
}




///<include file='Utils/Docs/Headers/Headers.generated.xml' path='docs/Headers/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Headers
{
	///<include file='Utils/Docs/HeadersHeaders/HeadersHeaders.generated.xml' path='docs/HeadersHeaders/*'/>
	public Headers(HeadersInit init) { }
	///<include file='Utils/Docs/HeadersAppend/HeadersAppend.generated.xml' path='docs/HeadersAppend/*'/>
	public Undefined Append(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HeadersDelete/HeadersDelete.generated.xml' path='docs/HeadersDelete/*'/>
	public Undefined Delete(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HeadersGet/HeadersGet.generated.xml' path='docs/HeadersGet/*'/>
	public string? Get(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HeadersGetSetCookie/HeadersGetSetCookie.generated.xml' path='docs/HeadersGetSetCookie/*'/>
	public List<string> GetSetCookie() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HeadersHas/HeadersHas.generated.xml' path='docs/HeadersHas/*'/>
	public bool Has(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HeadersSet/HeadersSet.generated.xml' path='docs/HeadersSet/*'/>
	public Undefined Set(string name, string value) { throw new System.NotImplementedException(); }
	public string this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	public Headers() { }
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial interface Body
{
		public ReadableStream? Body { get { throw new System.NotImplementedException(); } }
		public bool BodyUsed { get { throw new System.NotImplementedException(); } }
		public Task<byte[]> ArrayBuffer() { throw new System.NotImplementedException(); }
		public Task<Blob> Blob() { throw new System.NotImplementedException(); }
		public Task<FormData> FormData() { throw new System.NotImplementedException(); }
		public Task<dynamic> Json() { throw new System.NotImplementedException(); }
		public Task<string> Text() { throw new System.NotImplementedException(); }
}


///<include file='Utils/Docs/Request/Request.generated.xml' path='docs/Request/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Request
{
	///<include file='Utils/Docs/RequestRequest/RequestRequest.generated.xml' path='docs/RequestRequest/*'/>
	public Request(RequestInfo input, RequestInit init) { }
	///<include file='Utils/Docs/RequestMethod/RequestMethod.generated.xml' path='docs/RequestMethod/*'/>
	public string Method { get; }
	///<include file='Utils/Docs/RequestUrl/RequestUrl.generated.xml' path='docs/RequestUrl/*'/>
	public string Url { get; }
	///<include file='Utils/Docs/RequestHeaders/RequestHeaders.generated.xml' path='docs/RequestHeaders/*'/>
	public Headers Headers { get; }
	///<include file='Utils/Docs/RequestDestination/RequestDestination.generated.xml' path='docs/RequestDestination/*'/>
	public RequestDestination Destination { get; }
	///<include file='Utils/Docs/RequestReferrer/RequestReferrer.generated.xml' path='docs/RequestReferrer/*'/>
	public string Referrer { get; }
	///<include file='Utils/Docs/RequestReferrerPolicy/RequestReferrerPolicy.generated.xml' path='docs/RequestReferrerPolicy/*'/>
	public ReferrerPolicy ReferrerPolicy { get; }
	///<include file='Utils/Docs/RequestMode/RequestMode.generated.xml' path='docs/RequestMode/*'/>
	public RequestMode Mode { get; }
	///<include file='Utils/Docs/RequestCredentials/RequestCredentials.generated.xml' path='docs/RequestCredentials/*'/>
	public RequestCredentials Credentials { get; }
	///<include file='Utils/Docs/RequestCache/RequestCache.generated.xml' path='docs/RequestCache/*'/>
	public RequestCache Cache { get; }
	///<include file='Utils/Docs/RequestRedirect/RequestRedirect.generated.xml' path='docs/RequestRedirect/*'/>
	public RequestRedirect Redirect { get; }
	///<include file='Utils/Docs/RequestIntegrity/RequestIntegrity.generated.xml' path='docs/RequestIntegrity/*'/>
	public string Integrity { get; }
		public bool Keepalive { get; }
		public bool IsReloadNavigation { get; }
		public bool IsHistoryNavigation { get; }
	///<include file='Utils/Docs/RequestSignal/RequestSignal.generated.xml' path='docs/RequestSignal/*'/>
	public AbortSignal Signal { get; }
		public RequestDuplex Duplex { get; }
	///<include file='Utils/Docs/RequestClone/RequestClone.generated.xml' path='docs/RequestClone/*'/>
	public Request Clone() { throw new System.NotImplementedException(); }
	public Request() { }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class RequestInit
{
		public string Method;
		public HeadersInit Headers;
		public BodyInit? Body;
		public string Referrer;
		public ReferrerPolicy ReferrerPolicy;
		public RequestMode Mode;
		public RequestCredentials Credentials;
		public RequestCache Cache;
		public RequestRedirect Redirect;
		public string Integrity;
		public bool Keepalive;
		public AbortSignal? Signal;
		public RequestDuplex Duplex;
		public RequestPriority Priority;
		public dynamic Window;
}

///<include file='Utils/Docs/RequestDestination/RequestDestination.generated.xml' path='docs/RequestDestination/*'/>
public enum RequestDestination
{
	Empty,
	Audio,
	Audioworklet,
	Document,
	Embed,
	Font,
	Frame,
	Iframe,
	Image,
	Manifest,
	Object,
	Paintworklet,
	Report,
	Script,
	Sharedworker,
	Style,
	Track,
	Video,
	Worker,
	Xslt,
}

///<include file='Utils/Docs/RequestMode/RequestMode.generated.xml' path='docs/RequestMode/*'/>
public enum RequestMode
{
	Navigate,
	SameOrigin,
	NoCors,
	Cors,
}

///<include file='Utils/Docs/RequestCredentials/RequestCredentials.generated.xml' path='docs/RequestCredentials/*'/>
public enum RequestCredentials
{
	Omit,
	SameOrigin,
	Include,
}

///<include file='Utils/Docs/RequestCache/RequestCache.generated.xml' path='docs/RequestCache/*'/>
public enum RequestCache
{
	Default,
	NoStore,
	Reload,
	NoCache,
	ForceCache,
	OnlyIfCached,
}

///<include file='Utils/Docs/RequestRedirect/RequestRedirect.generated.xml' path='docs/RequestRedirect/*'/>
public enum RequestRedirect
{
	Follow,
	Error,
	Manual,
}

public enum RequestDuplex
{
	Half,
}

public enum RequestPriority
{
	High,
	Low,
	Auto,
}

///<include file='Utils/Docs/Response/Response.generated.xml' path='docs/Response/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Response
{
	///<include file='Utils/Docs/ResponseResponse/ResponseResponse.generated.xml' path='docs/ResponseResponse/*'/>
	public Response(BodyInit? body, ResponseInit init) { }
		public static Response Error() { throw new System.NotImplementedException(); }
		public static Response Redirect(string url, ushort status) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ResponseJson/ResponseJson.generated.xml' path='docs/ResponseJson/*'/>
	public static Response Json(dynamic data, ResponseInit init) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ResponseType/ResponseType.generated.xml' path='docs/ResponseType/*'/>
	public ResponseType Type { get; }
	///<include file='Utils/Docs/ResponseUrl/ResponseUrl.generated.xml' path='docs/ResponseUrl/*'/>
	public string Url { get; }
	///<include file='Utils/Docs/ResponseRedirected/ResponseRedirected.generated.xml' path='docs/ResponseRedirected/*'/>
	public bool Redirected { get; }
	///<include file='Utils/Docs/ResponseStatus/ResponseStatus.generated.xml' path='docs/ResponseStatus/*'/>
	public ushort Status { get; }
	///<include file='Utils/Docs/ResponseOk/ResponseOk.generated.xml' path='docs/ResponseOk/*'/>
	public bool Ok { get; }
	///<include file='Utils/Docs/ResponseStatusText/ResponseStatusText.generated.xml' path='docs/ResponseStatusText/*'/>
	public string StatusText { get; }
	///<include file='Utils/Docs/ResponseHeaders/ResponseHeaders.generated.xml' path='docs/ResponseHeaders/*'/>
	public Headers Headers { get; }
	///<include file='Utils/Docs/ResponseClone/ResponseClone.generated.xml' path='docs/ResponseClone/*'/>
	public Response Clone() { throw new System.NotImplementedException(); }
	public Response() { }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class ResponseInit
{
		public ushort Status;
		public string StatusText;
		public HeadersInit Headers;
}

///<include file='Utils/Docs/ResponseType/ResponseType.generated.xml' path='docs/ResponseType/*'/>
public enum ResponseType
{
	Basic,
	Cors,
	Default,
	Error,
	Opaque,
	Opaqueredirect,
}

public partial interface WindowOrWorkerGlobalScope
{
		public Task<Response> Fetch(RequestInfo input, RequestInit init) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/FileSystemHandleKind/FileSystemHandleKind.generated.xml' path='docs/FileSystemHandleKind/*'/>
public enum FileSystemHandleKind
{
	File,
	Directory,
}

///<include file='Utils/Docs/FileSystemHandle/FileSystemHandle.generated.xml' path='docs/FileSystemHandle/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FileSystemHandle
{
	///<include file='Utils/Docs/FileSystemHandleKind/FileSystemHandleKind.generated.xml' path='docs/FileSystemHandleKind/*'/>
	public FileSystemHandleKind Kind { get; }
	///<include file='Utils/Docs/FileSystemHandleName/FileSystemHandleName.generated.xml' path='docs/FileSystemHandleName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs/FileSystemHandleIsSameEntry/FileSystemHandleIsSameEntry.generated.xml' path='docs/FileSystemHandleIsSameEntry/*'/>
	public Task<bool> IsSameEntry(FileSystemHandle other) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FileSystemCreateWritableOptions
{
		public bool KeepExistingData;
}

///<include file='Utils/Docs/FileSystemFileHandle/FileSystemFileHandle.generated.xml' path='docs/FileSystemFileHandle/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FileSystemFileHandle : FileSystemHandle
{
	///<include file='Utils/Docs/FileSystemFileHandleGetFile/FileSystemFileHandleGetFile.generated.xml' path='docs/FileSystemFileHandleGetFile/*'/>
	public Task<File> GetFile() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileSystemFileHandleCreateWritable/FileSystemFileHandleCreateWritable.generated.xml' path='docs/FileSystemFileHandleCreateWritable/*'/>
	public Task<FileSystemWritableFileStream> CreateWritable(FileSystemCreateWritableOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileSystemFileHandleCreateSyncAccessHandle/FileSystemFileHandleCreateSyncAccessHandle.generated.xml' path='docs/FileSystemFileHandleCreateSyncAccessHandle/*'/>
	public Task<FileSystemSyncAccessHandle> CreateSyncAccessHandle() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FileSystemGetFileOptions
{
		public bool Create;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FileSystemGetDirectoryOptions
{
		public bool Create;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FileSystemRemoveOptions
{
		public bool Recursive;
}

///<include file='Utils/Docs/FileSystemDirectoryHandle/FileSystemDirectoryHandle.generated.xml' path='docs/FileSystemDirectoryHandle/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FileSystemDirectoryHandle : FileSystemHandle
{
	public string this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	///<include file='Utils/Docs/FileSystemDirectoryHandleGetFileHandle/FileSystemDirectoryHandleGetFileHandle.generated.xml' path='docs/FileSystemDirectoryHandleGetFileHandle/*'/>
	public Task<FileSystemFileHandle> GetFileHandle(string name, FileSystemGetFileOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileSystemDirectoryHandleGetDirectoryHandle/FileSystemDirectoryHandleGetDirectoryHandle.generated.xml' path='docs/FileSystemDirectoryHandleGetDirectoryHandle/*'/>
	public Task<FileSystemDirectoryHandle> GetDirectoryHandle(string name, FileSystemGetDirectoryOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileSystemDirectoryHandleRemoveEntry/FileSystemDirectoryHandleRemoveEntry.generated.xml' path='docs/FileSystemDirectoryHandleRemoveEntry/*'/>
	public Task<Undefined> RemoveEntry(string name, FileSystemRemoveOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileSystemDirectoryHandleResolve/FileSystemDirectoryHandleResolve.generated.xml' path='docs/FileSystemDirectoryHandleResolve/*'/>
	public Task<List<string>?> Resolve(FileSystemHandle possibleDescendant) { throw new System.NotImplementedException(); }
}

public enum WriteCommandType
{
	Write,
	Seek,
	Truncate,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WriteParams
{
		public required WriteCommandType Type;
		public ulong? Size;
		public ulong? Position;
		public Union60? Data;
}


///<include file='Utils/Docs/FileSystemWritableFileStream/FileSystemWritableFileStream.generated.xml' path='docs/FileSystemWritableFileStream/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FileSystemWritableFileStream : WritableStream
{
	///<include file='Utils/Docs/FileSystemWritableFileStreamWrite/FileSystemWritableFileStreamWrite.generated.xml' path='docs/FileSystemWritableFileStreamWrite/*'/>
	public Task<Undefined> Write(FileSystemWriteChunkType data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileSystemWritableFileStreamSeek/FileSystemWritableFileStreamSeek.generated.xml' path='docs/FileSystemWritableFileStreamSeek/*'/>
	public Task<Undefined> Seek(ulong position) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileSystemWritableFileStreamTruncate/FileSystemWritableFileStreamTruncate.generated.xml' path='docs/FileSystemWritableFileStreamTruncate/*'/>
	public Task<Undefined> Truncate(ulong size) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FileSystemReadWriteOptions
{
		public ulong At;
}

///<include file='Utils/Docs/FileSystemSyncAccessHandle/FileSystemSyncAccessHandle.generated.xml' path='docs/FileSystemSyncAccessHandle/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FileSystemSyncAccessHandle
{
	///<include file='Utils/Docs/FileSystemSyncAccessHandleRead/FileSystemSyncAccessHandleRead.generated.xml' path='docs/FileSystemSyncAccessHandleRead/*'/>
	public ulong Read(AllowSharedBufferSource buffer, FileSystemReadWriteOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileSystemSyncAccessHandleWrite/FileSystemSyncAccessHandleWrite.generated.xml' path='docs/FileSystemSyncAccessHandleWrite/*'/>
	public ulong Write(AllowSharedBufferSource buffer, FileSystemReadWriteOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileSystemSyncAccessHandleTruncate/FileSystemSyncAccessHandleTruncate.generated.xml' path='docs/FileSystemSyncAccessHandleTruncate/*'/>
	public Undefined Truncate(ulong newSize) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileSystemSyncAccessHandleGetSize/FileSystemSyncAccessHandleGetSize.generated.xml' path='docs/FileSystemSyncAccessHandleGetSize/*'/>
	public ulong GetSize() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileSystemSyncAccessHandleFlush/FileSystemSyncAccessHandleFlush.generated.xml' path='docs/FileSystemSyncAccessHandleFlush/*'/>
	public Undefined Flush() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FileSystemSyncAccessHandleClose/FileSystemSyncAccessHandleClose.generated.xml' path='docs/FileSystemSyncAccessHandleClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/StorageManager/StorageManager.generated.xml' path='docs/StorageManager/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class StorageManager
{
	///<include file='Utils/Docs/StorageManagerGetDirectory/StorageManagerGetDirectory.generated.xml' path='docs/StorageManagerGetDirectory/*'/>
	public Task<FileSystemDirectoryHandle> GetDirectory() { throw new System.NotImplementedException(); }
}

public enum FullscreenNavigationUI
{
	Auto,
	Show,
	Hide,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FullscreenOptions
{
		public FullscreenNavigationUI NavigationUI;
}

///<include file='Utils/Docs/Element/Element.generated.xml' path='docs/Element/*'/>
public partial class Element
{
	///<include file='Utils/Docs/ElementRequestFullscreen/ElementRequestFullscreen.generated.xml' path='docs/ElementRequestFullscreen/*'/>
	public Task<Undefined> RequestFullscreen(FullscreenOptions options) { throw new System.NotImplementedException(); }
		public EventHandler Onfullscreenchange { get; set; }
		public EventHandler Onfullscreenerror { get; set; }
}

///<include file='Utils/Docs/Document/Document.generated.xml' path='docs/Document/*'/>
public partial class Document
{
	///<include file='Utils/Docs/DocumentFullscreenEnabled/DocumentFullscreenEnabled.generated.xml' path='docs/DocumentFullscreenEnabled/*'/>
	public bool FullscreenEnabled { get; }
	///<include file='Utils/Docs/DocumentFullscreen/DocumentFullscreen.generated.xml' path='docs/DocumentFullscreen/*'/>
	public bool Fullscreen { get; }
	///<include file='Utils/Docs/DocumentExitFullscreen/DocumentExitFullscreen.generated.xml' path='docs/DocumentExitFullscreen/*'/>
	public Task<Undefined> ExitFullscreen() { throw new System.NotImplementedException(); }
		public EventHandler Onfullscreenchange { get; set; }
		public EventHandler Onfullscreenerror { get; set; }
}

public partial interface DocumentOrShadowRoot
{
		public Element? FullscreenElement { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/Notification/Notification.generated.xml' path='docs/Notification/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Notification : EventTarget
{
	///<include file='Utils/Docs/NotificationNotification/NotificationNotification.generated.xml' path='docs/NotificationNotification/*'/>
	public Notification(string title, NotificationOptions options) { }
		public static NotificationPermission Permission { get; }
		public static Task<NotificationPermission> RequestPermission(NotificationPermissionCallback deprecatedCallback) { throw new System.NotImplementedException(); }
		public static ulong MaxActions { get; }
		public EventHandler Onclick { get; set; }
		public EventHandler Onshow { get; set; }
		public EventHandler Onerror { get; set; }
		public EventHandler Onclose { get; set; }
	///<include file='Utils/Docs/NotificationTitle/NotificationTitle.generated.xml' path='docs/NotificationTitle/*'/>
	public string Title { get; }
	///<include file='Utils/Docs/NotificationDir/NotificationDir.generated.xml' path='docs/NotificationDir/*'/>
	public NotificationDirection Dir { get; }
	///<include file='Utils/Docs/NotificationLang/NotificationLang.generated.xml' path='docs/NotificationLang/*'/>
	public string Lang { get; }
	///<include file='Utils/Docs/NotificationBody/NotificationBody.generated.xml' path='docs/NotificationBody/*'/>
	public string Body { get; }
	///<include file='Utils/Docs/NotificationTag/NotificationTag.generated.xml' path='docs/NotificationTag/*'/>
	public string Tag { get; }
	///<include file='Utils/Docs/NotificationImage/NotificationImage.generated.xml' path='docs/NotificationImage/*'/>
	public string Image { get; }
	///<include file='Utils/Docs/NotificationIcon/NotificationIcon.generated.xml' path='docs/NotificationIcon/*'/>
	public string Icon { get; }
	///<include file='Utils/Docs/NotificationBadge/NotificationBadge.generated.xml' path='docs/NotificationBadge/*'/>
	public string Badge { get; }
	///<include file='Utils/Docs/NotificationVibrate/NotificationVibrate.generated.xml' path='docs/NotificationVibrate/*'/>
	public ulong[] Vibrate { get; }
	///<include file='Utils/Docs/NotificationTimestamp/NotificationTimestamp.generated.xml' path='docs/NotificationTimestamp/*'/>
	public Unsupported /*EpochTimeStamp*/ Timestamp { get; }
	///<include file='Utils/Docs/NotificationRenotify/NotificationRenotify.generated.xml' path='docs/NotificationRenotify/*'/>
	public bool Renotify { get; }
	///<include file='Utils/Docs/NotificationSilent/NotificationSilent.generated.xml' path='docs/NotificationSilent/*'/>
	public bool? Silent { get; }
	///<include file='Utils/Docs/NotificationRequireInteraction/NotificationRequireInteraction.generated.xml' path='docs/NotificationRequireInteraction/*'/>
	public bool RequireInteraction { get; }
	///<include file='Utils/Docs/NotificationData/NotificationData.generated.xml' path='docs/NotificationData/*'/>
	public dynamic Data { get; }
	///<include file='Utils/Docs/NotificationActions/NotificationActions.generated.xml' path='docs/NotificationActions/*'/>
	public NotificationAction[] Actions { get; }
	///<include file='Utils/Docs/NotificationClose/NotificationClose.generated.xml' path='docs/NotificationClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
	public Notification() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NotificationOptions
{
		public NotificationDirection Dir;
		public string Lang;
		public string Body;
		public string Tag;
		public string Image;
		public string Icon;
		public string Badge;
		public Unsupported /*VibratePattern*/ Vibrate;
		public Unsupported /*EpochTimeStamp*/ Timestamp;
		public bool Renotify;
		public bool? Silent;
		public bool RequireInteraction;
		public dynamic Data;
		public List<NotificationAction> Actions;
}

public enum NotificationPermission
{
	Default,
	Denied,
	Granted,
}

public enum NotificationDirection
{
	Auto,
	Ltr,
	Rtl,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NotificationAction
{
		public required string Action;
		public required string Title;
		public string Icon;
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct NotificationPermissionCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GetNotificationOptions
{
		public string Tag;
}

///<include file='Utils/Docs/ServiceWorkerRegistration/ServiceWorkerRegistration.generated.xml' path='docs/ServiceWorkerRegistration/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ServiceWorkerRegistration
{
	///<include file='Utils/Docs/ServiceWorkerRegistrationShowNotification/ServiceWorkerRegistrationShowNotification.generated.xml' path='docs/ServiceWorkerRegistrationShowNotification/*'/>
	public Task<Undefined> ShowNotification(string title, NotificationOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ServiceWorkerRegistrationGetNotifications/ServiceWorkerRegistrationGetNotifications.generated.xml' path='docs/ServiceWorkerRegistrationGetNotifications/*'/>
	public Task<List<Notification>> GetNotifications(GetNotificationOptions filter) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/NotificationEvent/NotificationEvent.generated.xml' path='docs/NotificationEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class NotificationEvent : ExtendableEvent
{
	///<include file='Utils/Docs/NotificationEventNotificationEvent/NotificationEventNotificationEvent.generated.xml' path='docs/NotificationEventNotificationEvent/*'/>
	public NotificationEvent(string type, NotificationEventInit eventInitDict) { }
	///<include file='Utils/Docs/NotificationEventNotification/NotificationEventNotification.generated.xml' path='docs/NotificationEventNotification/*'/>
	public Notification Notification { get; }
	///<include file='Utils/Docs/NotificationEventAction/NotificationEventAction.generated.xml' path='docs/NotificationEventAction/*'/>
	public string Action { get; }
	public NotificationEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NotificationEventInit : ExtendableEventInit
{
		public required Notification Notification;
		public string Action;
}

///<include file='Utils/Docs/ServiceWorkerGlobalScope/ServiceWorkerGlobalScope.generated.xml' path='docs/ServiceWorkerGlobalScope/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ServiceWorkerGlobalScope
{
		public EventHandler Onnotificationclick { get; set; }
		public EventHandler Onnotificationclose { get; set; }
}

///<include file='Utils/Docs/NavigatorStorage/NavigatorStorage.generated.xml' path='docs/NavigatorStorage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorStorage
{
		public StorageManager Storage { get { throw new System.NotImplementedException(); } }
}



///<include file='Utils/Docs/StorageManager/StorageManager.generated.xml' path='docs/StorageManager/*'/>
public partial class StorageManager
{
	///<include file='Utils/Docs/StorageManagerPersisted/StorageManagerPersisted.generated.xml' path='docs/StorageManagerPersisted/*'/>
	public Task<bool> Persisted() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/StorageManagerPersist/StorageManagerPersist.generated.xml' path='docs/StorageManagerPersist/*'/>
	public Task<bool> Persist() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/StorageManagerEstimate/StorageManagerEstimate.generated.xml' path='docs/StorageManagerEstimate/*'/>
	public Task<StorageEstimate> Estimate() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class StorageEstimate
{
		public ulong Usage;
		public ulong Quota;
}

///<include file='Utils/Docs/ReadableStream/ReadableStream.generated.xml' path='docs/ReadableStream/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ReadableStream
{
	///<include file='Utils/Docs/ReadableStreamReadableStream/ReadableStreamReadableStream.generated.xml' path='docs/ReadableStreamReadableStream/*'/>
	public ReadableStream(object underlyingSource, QueuingStrategy strategy) { }
		public static ReadableStream From(dynamic asyncIterable) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ReadableStreamLocked/ReadableStreamLocked.generated.xml' path='docs/ReadableStreamLocked/*'/>
	public bool Locked { get; }
	///<include file='Utils/Docs/ReadableStreamCancel/ReadableStreamCancel.generated.xml' path='docs/ReadableStreamCancel/*'/>
	public Task<Undefined> Cancel(dynamic reason) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ReadableStreamGetReader/ReadableStreamGetReader.generated.xml' path='docs/ReadableStreamGetReader/*'/>
	public ReadableStreamReader GetReader(ReadableStreamGetReaderOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ReadableStreamPipeThrough/ReadableStreamPipeThrough.generated.xml' path='docs/ReadableStreamPipeThrough/*'/>
	public ReadableStream PipeThrough(ReadableWritablePair transform, StreamPipeOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ReadableStreamPipeTo/ReadableStreamPipeTo.generated.xml' path='docs/ReadableStreamPipeTo/*'/>
	public Task<Undefined> PipeTo(WritableStream destination, StreamPipeOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ReadableStreamTee/ReadableStreamTee.generated.xml' path='docs/ReadableStreamTee/*'/>
	public List<ReadableStream> Tee() { throw new System.NotImplementedException(); }
	public dynamic this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	public ReadableStream() { }
}


public enum ReadableStreamReaderMode
{
	Byob,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ReadableStreamGetReaderOptions
{
		public ReadableStreamReaderMode Mode;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ReadableStreamIteratorOptions
{
		public bool PreventCancel;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ReadableWritablePair
{
		public required ReadableStream Readable;
		public required WritableStream Writable;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class StreamPipeOptions
{
		public bool PreventClose;
		public bool PreventAbort;
		public bool PreventCancel;
		public AbortSignal Signal;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class UnderlyingSource
{
		public UnderlyingSourceStartCallback Start;
		public UnderlyingSourcePullCallback Pull;
		public UnderlyingSourceCancelCallback Cancel;
		public ReadableStreamType Type;
		public ulong AutoAllocateChunkSize;
}


[To(ToAttribute.FirstCharToLowerCase)]
public struct UnderlyingSourceStartCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct UnderlyingSourcePullCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct UnderlyingSourceCancelCallback
{
}

public enum ReadableStreamType
{
	Bytes,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface ReadableStreamGenericReader
{
		public Task<Undefined> Closed { get { throw new System.NotImplementedException(); } }
		public Task<Undefined> Cancel(dynamic reason) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/ReadableStreamDefaultReader/ReadableStreamDefaultReader.generated.xml' path='docs/ReadableStreamDefaultReader/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ReadableStreamDefaultReader
{
	///<include file='Utils/Docs/ReadableStreamDefaultReaderReadableStreamDefaultReader/ReadableStreamDefaultReaderReadableStreamDefaultReader.generated.xml' path='docs/ReadableStreamDefaultReaderReadableStreamDefaultReader/*'/>
	public ReadableStreamDefaultReader(ReadableStream stream) { }
	///<include file='Utils/Docs/ReadableStreamDefaultReaderRead/ReadableStreamDefaultReaderRead.generated.xml' path='docs/ReadableStreamDefaultReaderRead/*'/>
	public Task<ReadableStreamReadResult> Read() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ReadableStreamDefaultReaderReleaseLock/ReadableStreamDefaultReaderReleaseLock.generated.xml' path='docs/ReadableStreamDefaultReaderReleaseLock/*'/>
	public Undefined ReleaseLock() { throw new System.NotImplementedException(); }
	public ReadableStreamDefaultReader() { }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class ReadableStreamReadResult
{
		public dynamic Value;
		public bool Done;
}

///<include file='Utils/Docs/ReadableStreamBYOBReader/ReadableStreamBYOBReader.generated.xml' path='docs/ReadableStreamBYOBReader/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ReadableStreamBYOBReader
{
	///<include file='Utils/Docs/ReadableStreamBYOBReaderReadableStreamBYOBReader/ReadableStreamBYOBReaderReadableStreamBYOBReader.generated.xml' path='docs/ReadableStreamBYOBReaderReadableStreamBYOBReader/*'/>
	public ReadableStreamBYOBReader(ReadableStream stream) { }
	///<include file='Utils/Docs/ReadableStreamBYOBReaderRead/ReadableStreamBYOBReaderRead.generated.xml' path='docs/ReadableStreamBYOBReaderRead/*'/>
	public Task<ReadableStreamReadResult> Read(ArrayBufferView view) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ReadableStreamBYOBReaderReleaseLock/ReadableStreamBYOBReaderReleaseLock.generated.xml' path='docs/ReadableStreamBYOBReaderReleaseLock/*'/>
	public Undefined ReleaseLock() { throw new System.NotImplementedException(); }
	public ReadableStreamBYOBReader() { }
}


///<include file='Utils/Docs/ReadableStreamDefaultController/ReadableStreamDefaultController.generated.xml' path='docs/ReadableStreamDefaultController/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ReadableStreamDefaultController
{
	///<include file='Utils/Docs/ReadableStreamDefaultControllerDesiredSize/ReadableStreamDefaultControllerDesiredSize.generated.xml' path='docs/ReadableStreamDefaultControllerDesiredSize/*'/>
	public double? DesiredSize { get; }
	///<include file='Utils/Docs/ReadableStreamDefaultControllerClose/ReadableStreamDefaultControllerClose.generated.xml' path='docs/ReadableStreamDefaultControllerClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ReadableStreamDefaultControllerEnqueue/ReadableStreamDefaultControllerEnqueue.generated.xml' path='docs/ReadableStreamDefaultControllerEnqueue/*'/>
	public Undefined Enqueue(dynamic chunk) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ReadableStreamDefaultControllerError/ReadableStreamDefaultControllerError.generated.xml' path='docs/ReadableStreamDefaultControllerError/*'/>
	public Undefined Error(dynamic e) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/ReadableByteStreamController/ReadableByteStreamController.generated.xml' path='docs/ReadableByteStreamController/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ReadableByteStreamController
{
	///<include file='Utils/Docs/ReadableByteStreamControllerByobRequest/ReadableByteStreamControllerByobRequest.generated.xml' path='docs/ReadableByteStreamControllerByobRequest/*'/>
	public ReadableStreamBYOBRequest? ByobRequest { get; }
	///<include file='Utils/Docs/ReadableByteStreamControllerDesiredSize/ReadableByteStreamControllerDesiredSize.generated.xml' path='docs/ReadableByteStreamControllerDesiredSize/*'/>
	public double? DesiredSize { get; }
	///<include file='Utils/Docs/ReadableByteStreamControllerClose/ReadableByteStreamControllerClose.generated.xml' path='docs/ReadableByteStreamControllerClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ReadableByteStreamControllerEnqueue/ReadableByteStreamControllerEnqueue.generated.xml' path='docs/ReadableByteStreamControllerEnqueue/*'/>
	public Undefined Enqueue(ArrayBufferView chunk) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ReadableByteStreamControllerError/ReadableByteStreamControllerError.generated.xml' path='docs/ReadableByteStreamControllerError/*'/>
	public Undefined Error(dynamic e) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/ReadableStreamBYOBRequest/ReadableStreamBYOBRequest.generated.xml' path='docs/ReadableStreamBYOBRequest/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ReadableStreamBYOBRequest
{
	///<include file='Utils/Docs/ReadableStreamBYOBRequestView/ReadableStreamBYOBRequestView.generated.xml' path='docs/ReadableStreamBYOBRequestView/*'/>
	public ArrayBufferView? View { get; }
	///<include file='Utils/Docs/ReadableStreamBYOBRequestRespond/ReadableStreamBYOBRequestRespond.generated.xml' path='docs/ReadableStreamBYOBRequestRespond/*'/>
	public Undefined Respond(ulong bytesWritten) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ReadableStreamBYOBRequestRespondWithNewView/ReadableStreamBYOBRequestRespondWithNewView.generated.xml' path='docs/ReadableStreamBYOBRequestRespondWithNewView/*'/>
	public Undefined RespondWithNewView(ArrayBufferView view) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/WritableStream/WritableStream.generated.xml' path='docs/WritableStream/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WritableStream
{
	///<include file='Utils/Docs/WritableStreamWritableStream/WritableStreamWritableStream.generated.xml' path='docs/WritableStreamWritableStream/*'/>
	public WritableStream(object underlyingSink, QueuingStrategy strategy) { }
	///<include file='Utils/Docs/WritableStreamLocked/WritableStreamLocked.generated.xml' path='docs/WritableStreamLocked/*'/>
	public bool Locked { get; }
	///<include file='Utils/Docs/WritableStreamAbort/WritableStreamAbort.generated.xml' path='docs/WritableStreamAbort/*'/>
	public Task<Undefined> Abort(dynamic reason) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WritableStreamClose/WritableStreamClose.generated.xml' path='docs/WritableStreamClose/*'/>
	public Task<Undefined> Close() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WritableStreamGetWriter/WritableStreamGetWriter.generated.xml' path='docs/WritableStreamGetWriter/*'/>
	public WritableStreamDefaultWriter GetWriter() { throw new System.NotImplementedException(); }
	public WritableStream() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class UnderlyingSink
{
		public UnderlyingSinkStartCallback Start;
		public UnderlyingSinkWriteCallback Write;
		public UnderlyingSinkCloseCallback Close;
		public UnderlyingSinkAbortCallback Abort;
		public dynamic Type;
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct UnderlyingSinkStartCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct UnderlyingSinkWriteCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct UnderlyingSinkCloseCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct UnderlyingSinkAbortCallback
{
}

///<include file='Utils/Docs/WritableStreamDefaultWriter/WritableStreamDefaultWriter.generated.xml' path='docs/WritableStreamDefaultWriter/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WritableStreamDefaultWriter
{
	///<include file='Utils/Docs/WritableStreamDefaultWriterWritableStreamDefaultWriter/WritableStreamDefaultWriterWritableStreamDefaultWriter.generated.xml' path='docs/WritableStreamDefaultWriterWritableStreamDefaultWriter/*'/>
	public WritableStreamDefaultWriter(WritableStream stream) { }
	///<include file='Utils/Docs/WritableStreamDefaultWriterClosed/WritableStreamDefaultWriterClosed.generated.xml' path='docs/WritableStreamDefaultWriterClosed/*'/>
	public Task<Undefined> Closed { get; }
	///<include file='Utils/Docs/WritableStreamDefaultWriterDesiredSize/WritableStreamDefaultWriterDesiredSize.generated.xml' path='docs/WritableStreamDefaultWriterDesiredSize/*'/>
	public double? DesiredSize { get; }
	///<include file='Utils/Docs/WritableStreamDefaultWriterReady/WritableStreamDefaultWriterReady.generated.xml' path='docs/WritableStreamDefaultWriterReady/*'/>
	public Task<Undefined> Ready { get; }
	///<include file='Utils/Docs/WritableStreamDefaultWriterAbort/WritableStreamDefaultWriterAbort.generated.xml' path='docs/WritableStreamDefaultWriterAbort/*'/>
	public Task<Undefined> Abort(dynamic reason) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WritableStreamDefaultWriterClose/WritableStreamDefaultWriterClose.generated.xml' path='docs/WritableStreamDefaultWriterClose/*'/>
	public Task<Undefined> Close() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WritableStreamDefaultWriterReleaseLock/WritableStreamDefaultWriterReleaseLock.generated.xml' path='docs/WritableStreamDefaultWriterReleaseLock/*'/>
	public Undefined ReleaseLock() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WritableStreamDefaultWriterWrite/WritableStreamDefaultWriterWrite.generated.xml' path='docs/WritableStreamDefaultWriterWrite/*'/>
	public Task<Undefined> Write(dynamic chunk) { throw new System.NotImplementedException(); }
	public WritableStreamDefaultWriter() { }
}

///<include file='Utils/Docs/WritableStreamDefaultController/WritableStreamDefaultController.generated.xml' path='docs/WritableStreamDefaultController/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WritableStreamDefaultController
{
	///<include file='Utils/Docs/WritableStreamDefaultControllerSignal/WritableStreamDefaultControllerSignal.generated.xml' path='docs/WritableStreamDefaultControllerSignal/*'/>
	public AbortSignal Signal { get; }
	///<include file='Utils/Docs/WritableStreamDefaultControllerError/WritableStreamDefaultControllerError.generated.xml' path='docs/WritableStreamDefaultControllerError/*'/>
	public Undefined Error(dynamic e) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/TransformStream/TransformStream.generated.xml' path='docs/TransformStream/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class TransformStream
{
	///<include file='Utils/Docs/TransformStreamTransformStream/TransformStreamTransformStream.generated.xml' path='docs/TransformStreamTransformStream/*'/>
	public TransformStream(object transformer, QueuingStrategy writableStrategy, QueuingStrategy readableStrategy) { }
	///<include file='Utils/Docs/TransformStreamReadable/TransformStreamReadable.generated.xml' path='docs/TransformStreamReadable/*'/>
	public ReadableStream Readable { get; }
	///<include file='Utils/Docs/TransformStreamWritable/TransformStreamWritable.generated.xml' path='docs/TransformStreamWritable/*'/>
	public WritableStream Writable { get; }
	public TransformStream() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class Transformer
{
		public TransformerStartCallback Start;
		public TransformerTransformCallback Transform;
		public TransformerFlushCallback Flush;
		public TransformerCancelCallback Cancel;
		public dynamic ReadableType;
		public dynamic WritableType;
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct TransformerStartCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct TransformerFlushCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct TransformerTransformCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct TransformerCancelCallback
{
}

///<include file='Utils/Docs/TransformStreamDefaultController/TransformStreamDefaultController.generated.xml' path='docs/TransformStreamDefaultController/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class TransformStreamDefaultController
{
	///<include file='Utils/Docs/TransformStreamDefaultControllerDesiredSize/TransformStreamDefaultControllerDesiredSize.generated.xml' path='docs/TransformStreamDefaultControllerDesiredSize/*'/>
	public double? DesiredSize { get; }
	///<include file='Utils/Docs/TransformStreamDefaultControllerEnqueue/TransformStreamDefaultControllerEnqueue.generated.xml' path='docs/TransformStreamDefaultControllerEnqueue/*'/>
	public Undefined Enqueue(dynamic chunk) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TransformStreamDefaultControllerError/TransformStreamDefaultControllerError.generated.xml' path='docs/TransformStreamDefaultControllerError/*'/>
	public Undefined Error(dynamic reason) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TransformStreamDefaultControllerTerminate/TransformStreamDefaultControllerTerminate.generated.xml' path='docs/TransformStreamDefaultControllerTerminate/*'/>
	public Undefined Terminate() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class QueuingStrategy
{
		public double HighWaterMark;
		public QueuingStrategySize Size;
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct QueuingStrategySize
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class QueuingStrategyInit
{
		public required double HighWaterMark;
}

///<include file='Utils/Docs/ByteLengthQueuingStrategy/ByteLengthQueuingStrategy.generated.xml' path='docs/ByteLengthQueuingStrategy/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ByteLengthQueuingStrategy
{
	///<include file='Utils/Docs/ByteLengthQueuingStrategyByteLengthQueuingStrategy/ByteLengthQueuingStrategyByteLengthQueuingStrategy.generated.xml' path='docs/ByteLengthQueuingStrategyByteLengthQueuingStrategy/*'/>
	public ByteLengthQueuingStrategy(QueuingStrategyInit init) { }
	///<include file='Utils/Docs/ByteLengthQueuingStrategyHighWaterMark/ByteLengthQueuingStrategyHighWaterMark.generated.xml' path='docs/ByteLengthQueuingStrategyHighWaterMark/*'/>
	public double HighWaterMark { get; }
	///<include file='Utils/Docs/ByteLengthQueuingStrategySize/ByteLengthQueuingStrategySize.generated.xml' path='docs/ByteLengthQueuingStrategySize/*'/>
	public Function Size { get; }
	public ByteLengthQueuingStrategy() { }
}

///<include file='Utils/Docs/CountQueuingStrategy/CountQueuingStrategy.generated.xml' path='docs/CountQueuingStrategy/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CountQueuingStrategy
{
	///<include file='Utils/Docs/CountQueuingStrategyCountQueuingStrategy/CountQueuingStrategyCountQueuingStrategy.generated.xml' path='docs/CountQueuingStrategyCountQueuingStrategy/*'/>
	public CountQueuingStrategy(QueuingStrategyInit init) { }
	///<include file='Utils/Docs/CountQueuingStrategyHighWaterMark/CountQueuingStrategyHighWaterMark.generated.xml' path='docs/CountQueuingStrategyHighWaterMark/*'/>
	public double HighWaterMark { get; }
	///<include file='Utils/Docs/CountQueuingStrategySize/CountQueuingStrategySize.generated.xml' path='docs/CountQueuingStrategySize/*'/>
	public Function Size { get; }
	public CountQueuingStrategy() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GenericTransformStream
{
		public ReadableStream Readable { get { throw new System.NotImplementedException(); } }
		public WritableStream Writable { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class TestUtils
{
		public Task<Undefined> Gc() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/URL/URL.generated.xml' path='docs/URL/*'/>
public partial class URL
{
	///<include file='Utils/Docs/URLURL/URLURL.generated.xml' path='docs/URLURL/*'/>
	public URL(string url, string base_) { }
		public static bool CanParse(string url, string base_) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/URLHref/URLHref.generated.xml' path='docs/URLHref/*'/>
	public string Href { get; set; }
	///<include file='Utils/Docs/URLOrigin/URLOrigin.generated.xml' path='docs/URLOrigin/*'/>
	public string Origin { get; }
	///<include file='Utils/Docs/URLProtocol/URLProtocol.generated.xml' path='docs/URLProtocol/*'/>
	public string Protocol { get; set; }
	///<include file='Utils/Docs/URLUsername/URLUsername.generated.xml' path='docs/URLUsername/*'/>
	public string Username { get; set; }
	///<include file='Utils/Docs/URLPassword/URLPassword.generated.xml' path='docs/URLPassword/*'/>
	public string Password { get; set; }
	///<include file='Utils/Docs/URLHost/URLHost.generated.xml' path='docs/URLHost/*'/>
	public string Host { get; set; }
	///<include file='Utils/Docs/URLHostname/URLHostname.generated.xml' path='docs/URLHostname/*'/>
	public string Hostname { get; set; }
	///<include file='Utils/Docs/URLPort/URLPort.generated.xml' path='docs/URLPort/*'/>
	public string Port { get; set; }
	///<include file='Utils/Docs/URLPathname/URLPathname.generated.xml' path='docs/URLPathname/*'/>
	public string Pathname { get; set; }
	///<include file='Utils/Docs/URLSearch/URLSearch.generated.xml' path='docs/URLSearch/*'/>
	public string Search { get; set; }
	///<include file='Utils/Docs/URLSearchParams/URLSearchParams.generated.xml' path='docs/URLSearchParams/*'/>
	public URLSearchParams SearchParams { get; }
	///<include file='Utils/Docs/URLHash/URLHash.generated.xml' path='docs/URLHash/*'/>
	public string Hash { get; set; }
	///<include file='Utils/Docs/URLToJSON/URLToJSON.generated.xml' path='docs/URLToJSON/*'/>
	public string ToJSON() { throw new System.NotImplementedException(); }
	public URL() { }
}

///<include file='Utils/Docs/URLSearchParams/URLSearchParams.generated.xml' path='docs/URLSearchParams/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class URLSearchParams
{
	///<include file='Utils/Docs/URLSearchParamsURLSearchParams/URLSearchParamsURLSearchParams.generated.xml' path='docs/URLSearchParamsURLSearchParams/*'/>
	public URLSearchParams(Union64 init) { }
	///<include file='Utils/Docs/URLSearchParamsSize/URLSearchParamsSize.generated.xml' path='docs/URLSearchParamsSize/*'/>
	public ulong Size { get; }
	///<include file='Utils/Docs/URLSearchParamsAppend/URLSearchParamsAppend.generated.xml' path='docs/URLSearchParamsAppend/*'/>
	public Undefined Append(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/URLSearchParamsDelete/URLSearchParamsDelete.generated.xml' path='docs/URLSearchParamsDelete/*'/>
	public Undefined Delete(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/URLSearchParamsGet/URLSearchParamsGet.generated.xml' path='docs/URLSearchParamsGet/*'/>
	public string? Get(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/URLSearchParamsGetAll/URLSearchParamsGetAll.generated.xml' path='docs/URLSearchParamsGetAll/*'/>
	public List<string> GetAll(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/URLSearchParamsHas/URLSearchParamsHas.generated.xml' path='docs/URLSearchParamsHas/*'/>
	public bool Has(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/URLSearchParamsSet/URLSearchParamsSet.generated.xml' path='docs/URLSearchParamsSet/*'/>
	public Undefined Set(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/URLSearchParamsSort/URLSearchParamsSort.generated.xml' path='docs/URLSearchParamsSort/*'/>
	public Undefined Sort() { throw new System.NotImplementedException(); }
	public string this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	
	public URLSearchParams() { }
}


///<include file='Utils/Docs/URLPattern/URLPattern.generated.xml' path='docs/URLPattern/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class URLPattern
{
	///<include file='Utils/Docs/URLPatternURLPattern/URLPatternURLPattern.generated.xml' path='docs/URLPatternURLPattern/*'/>
	public URLPattern(URLPatternInput input, string baseURL, URLPatternOptions options) { }
	///<include file='Utils/Docs/URLPatternURLPattern/URLPatternURLPattern.generated.xml' path='docs/URLPatternURLPattern/*'/>
	public URLPattern(URLPatternInput input, URLPatternOptions options) { }
	///<include file='Utils/Docs/URLPatternTest/URLPatternTest.generated.xml' path='docs/URLPatternTest/*'/>
	public bool Test(URLPatternInput input, string baseURL) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/URLPatternExec/URLPatternExec.generated.xml' path='docs/URLPatternExec/*'/>
	public URLPatternResult? Exec(URLPatternInput input, string baseURL) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/URLPatternProtocol/URLPatternProtocol.generated.xml' path='docs/URLPatternProtocol/*'/>
	public string Protocol { get; }
	///<include file='Utils/Docs/URLPatternUsername/URLPatternUsername.generated.xml' path='docs/URLPatternUsername/*'/>
	public string Username { get; }
	///<include file='Utils/Docs/URLPatternPassword/URLPatternPassword.generated.xml' path='docs/URLPatternPassword/*'/>
	public string Password { get; }
	///<include file='Utils/Docs/URLPatternHostname/URLPatternHostname.generated.xml' path='docs/URLPatternHostname/*'/>
	public string Hostname { get; }
	///<include file='Utils/Docs/URLPatternPort/URLPatternPort.generated.xml' path='docs/URLPatternPort/*'/>
	public string Port { get; }
	///<include file='Utils/Docs/URLPatternPathname/URLPatternPathname.generated.xml' path='docs/URLPatternPathname/*'/>
	public string Pathname { get; }
	///<include file='Utils/Docs/URLPatternSearch/URLPatternSearch.generated.xml' path='docs/URLPatternSearch/*'/>
	public string Search { get; }
	///<include file='Utils/Docs/URLPatternHash/URLPatternHash.generated.xml' path='docs/URLPatternHash/*'/>
	public string Hash { get; }
	public URLPattern() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class URLPatternInit
{
		public string Protocol;
		public string Username;
		public string Password;
		public string Hostname;
		public string Port;
		public string Pathname;
		public string Search;
		public string Hash;
		public string BaseURL;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class URLPatternOptions
{
		public bool IgnoreCase;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class URLPatternResult
{
		public List<URLPatternInput> Inputs;
		public URLPatternComponentResult Protocol;
		public URLPatternComponentResult Username;
		public URLPatternComponentResult Password;
		public URLPatternComponentResult Hostname;
		public URLPatternComponentResult Port;
		public URLPatternComponentResult Pathname;
		public URLPatternComponentResult Search;
		public URLPatternComponentResult Hash;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class URLPatternComponentResult
{
		public string Input;
		public Dictionary<string, string> Groups;
}




///<include file='Utils/Docs/DOMException/DOMException.generated.xml' path='docs/DOMException/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMException
{
	///<include file='Utils/Docs/DOMExceptionDOMException/DOMExceptionDOMException.generated.xml' path='docs/DOMExceptionDOMException/*'/>
	public DOMException(string message, string name) { }
	///<include file='Utils/Docs/DOMExceptionName/DOMExceptionName.generated.xml' path='docs/DOMExceptionName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs/DOMExceptionMessage/DOMExceptionMessage.generated.xml' path='docs/DOMExceptionMessage/*'/>
	public string Message { get; }
	///<include file='Utils/Docs/DOMExceptionCode/DOMExceptionCode.generated.xml' path='docs/DOMExceptionCode/*'/>
	public ushort Code { get; }
		public const ushort INDEX_SIZE_ERR = 1;
		public const ushort DOMSTRING_SIZE_ERR = 2;
		public const ushort HIERARCHY_REQUEST_ERR = 3;
		public const ushort WRONG_DOCUMENT_ERR = 4;
		public const ushort INVALID_CHARACTER_ERR = 5;
		public const ushort NO_DATA_ALLOWED_ERR = 6;
		public const ushort NO_MODIFICATION_ALLOWED_ERR = 7;
		public const ushort NOT_FOUND_ERR = 8;
		public const ushort NOT_SUPPORTED_ERR = 9;
		public const ushort INUSE_ATTRIBUTE_ERR = 10;
		public const ushort INVALID_STATE_ERR = 11;
		public const ushort SYNTAX_ERR = 12;
		public const ushort INVALID_MODIFICATION_ERR = 13;
		public const ushort NAMESPACE_ERR = 14;
		public const ushort INVALID_ACCESS_ERR = 15;
		public const ushort VALIDATION_ERR = 16;
		public const ushort TYPE_MISMATCH_ERR = 17;
		public const ushort SECURITY_ERR = 18;
		public const ushort NETWORK_ERR = 19;
		public const ushort ABORT_ERR = 20;
		public const ushort URL_MISMATCH_ERR = 21;
		public const ushort QUOTA_EXCEEDED_ERR = 22;
		public const ushort TIMEOUT_ERR = 23;
		public const ushort INVALID_NODE_TYPE_ERR = 24;
		public const ushort DATA_CLONE_ERR = 25;
	public DOMException() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct Function
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct VoidFunction
{
}

public enum BinaryType
{
	Blob,
	Arraybuffer,
}

///<include file='Utils/Docs/WebSocket/WebSocket.generated.xml' path='docs/WebSocket/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebSocket : EventTarget
{
	///<include file='Utils/Docs/WebSocketWebSocket/WebSocketWebSocket.generated.xml' path='docs/WebSocketWebSocket/*'/>
	public WebSocket(string url, Union69 protocols) { }
	///<include file='Utils/Docs/WebSocketUrl/WebSocketUrl.generated.xml' path='docs/WebSocketUrl/*'/>
	public string Url { get; }
		public const ushort CONNECTING = 0;
		public const ushort OPEN = 1;
		public const ushort CLOSING = 2;
		public const ushort CLOSED = 3;
	///<include file='Utils/Docs/WebSocketReadyState/WebSocketReadyState.generated.xml' path='docs/WebSocketReadyState/*'/>
	public ushort ReadyState { get; }
	///<include file='Utils/Docs/WebSocketBufferedAmount/WebSocketBufferedAmount.generated.xml' path='docs/WebSocketBufferedAmount/*'/>
	public ulong BufferedAmount { get; }
		public EventHandler Onopen { get; set; }
		public EventHandler Onerror { get; set; }
		public EventHandler Onclose { get; set; }
	///<include file='Utils/Docs/WebSocketExtensions/WebSocketExtensions.generated.xml' path='docs/WebSocketExtensions/*'/>
	public string Extensions { get; }
	///<include file='Utils/Docs/WebSocketProtocol/WebSocketProtocol.generated.xml' path='docs/WebSocketProtocol/*'/>
	public string Protocol { get; }
	///<include file='Utils/Docs/WebSocketClose/WebSocketClose.generated.xml' path='docs/WebSocketClose/*'/>
	public Undefined Close(ushort code, string reason) { throw new System.NotImplementedException(); }
		public EventHandler Onmessage { get; set; }
	///<include file='Utils/Docs/WebSocketBinaryType/WebSocketBinaryType.generated.xml' path='docs/WebSocketBinaryType/*'/>
	public BinaryType BinaryType { get; set; }
	///<include file='Utils/Docs/WebSocketSend/WebSocketSend.generated.xml' path='docs/WebSocketSend/*'/>
	public Undefined Send(Union70 data) { throw new System.NotImplementedException(); }
	public WebSocket() { }
}

///<include file='Utils/Docs/CloseEvent/CloseEvent.generated.xml' path='docs/CloseEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CloseEvent : Event
{
	///<include file='Utils/Docs/CloseEventCloseEvent/CloseEventCloseEvent.generated.xml' path='docs/CloseEventCloseEvent/*'/>
	public CloseEvent(string type, CloseEventInit eventInitDict) { }
	///<include file='Utils/Docs/CloseEventWasClean/CloseEventWasClean.generated.xml' path='docs/CloseEventWasClean/*'/>
	public bool WasClean { get; }
	///<include file='Utils/Docs/CloseEventCode/CloseEventCode.generated.xml' path='docs/CloseEventCode/*'/>
	public ushort Code { get; }
	///<include file='Utils/Docs/CloseEventReason/CloseEventReason.generated.xml' path='docs/CloseEventReason/*'/>
	public string Reason { get; }
	public CloseEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CloseEventInit : EventInit
{
		public bool WasClean;
		public ushort Code;
		public string Reason;
}

///<include file='Utils/Docs/XMLHttpRequestEventTarget/XMLHttpRequestEventTarget.generated.xml' path='docs/XMLHttpRequestEventTarget/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XMLHttpRequestEventTarget : EventTarget
{
		public EventHandler Onloadstart { get; set; }
		public EventHandler Onprogress { get; set; }
		public EventHandler Onabort { get; set; }
		public EventHandler Onerror { get; set; }
		public EventHandler Onload { get; set; }
		public EventHandler Ontimeout { get; set; }
		public EventHandler Onloadend { get; set; }
}

///<include file='Utils/Docs/XMLHttpRequestUpload/XMLHttpRequestUpload.generated.xml' path='docs/XMLHttpRequestUpload/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XMLHttpRequestUpload : XMLHttpRequestEventTarget
{
}

///<include file='Utils/Docs/XMLHttpRequestResponseType/XMLHttpRequestResponseType.generated.xml' path='docs/XMLHttpRequestResponseType/*'/>
public enum XMLHttpRequestResponseType
{
	Empty,
	Arraybuffer,
	Blob,
	Document,
	Json,
	Text,
}

///<include file='Utils/Docs/XMLHttpRequest/XMLHttpRequest.generated.xml' path='docs/XMLHttpRequest/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XMLHttpRequest : XMLHttpRequestEventTarget
{
	///<include file='Utils/Docs/XMLHttpRequestXMLHttpRequest/XMLHttpRequestXMLHttpRequest.generated.xml' path='docs/XMLHttpRequestXMLHttpRequest/*'/>
	public XMLHttpRequest() { }
		public EventHandler Onreadystatechange { get; set; }
		public const ushort UNSENT = 0;
		public const ushort OPENED = 1;
		public const ushort HEADERS_RECEIVED = 2;
		public const ushort LOADING = 3;
		public const ushort DONE = 4;
	///<include file='Utils/Docs/XMLHttpRequestReadyState/XMLHttpRequestReadyState.generated.xml' path='docs/XMLHttpRequestReadyState/*'/>
	public ushort ReadyState { get; }
	///<include file='Utils/Docs/XMLHttpRequestOpen/XMLHttpRequestOpen.generated.xml' path='docs/XMLHttpRequestOpen/*'/>
	public Undefined Open(string method, string url) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XMLHttpRequestOpen/XMLHttpRequestOpen.generated.xml' path='docs/XMLHttpRequestOpen/*'/>
	public Undefined Open(string method, string url, bool async, string? username, string? password) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XMLHttpRequestSetRequestHeader/XMLHttpRequestSetRequestHeader.generated.xml' path='docs/XMLHttpRequestSetRequestHeader/*'/>
	public Undefined SetRequestHeader(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XMLHttpRequestTimeout/XMLHttpRequestTimeout.generated.xml' path='docs/XMLHttpRequestTimeout/*'/>
	public ulong Timeout { get; set; }
	///<include file='Utils/Docs/XMLHttpRequestWithCredentials/XMLHttpRequestWithCredentials.generated.xml' path='docs/XMLHttpRequestWithCredentials/*'/>
	public bool WithCredentials { get; set; }
	///<include file='Utils/Docs/XMLHttpRequestUpload/XMLHttpRequestUpload.generated.xml' path='docs/XMLHttpRequestUpload/*'/>
	public XMLHttpRequestUpload Upload { get; }
	///<include file='Utils/Docs/XMLHttpRequestSend/XMLHttpRequestSend.generated.xml' path='docs/XMLHttpRequestSend/*'/>
	public Undefined Send(Union71? body) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XMLHttpRequestAbort/XMLHttpRequestAbort.generated.xml' path='docs/XMLHttpRequestAbort/*'/>
	public Undefined Abort() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XMLHttpRequestResponseURL/XMLHttpRequestResponseURL.generated.xml' path='docs/XMLHttpRequestResponseURL/*'/>
	public string ResponseURL { get; }
	///<include file='Utils/Docs/XMLHttpRequestStatus/XMLHttpRequestStatus.generated.xml' path='docs/XMLHttpRequestStatus/*'/>
	public ushort Status { get; }
	///<include file='Utils/Docs/XMLHttpRequestStatusText/XMLHttpRequestStatusText.generated.xml' path='docs/XMLHttpRequestStatusText/*'/>
	public string StatusText { get; }
	///<include file='Utils/Docs/XMLHttpRequestGetResponseHeader/XMLHttpRequestGetResponseHeader.generated.xml' path='docs/XMLHttpRequestGetResponseHeader/*'/>
	public string? GetResponseHeader(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XMLHttpRequestGetAllResponseHeaders/XMLHttpRequestGetAllResponseHeaders.generated.xml' path='docs/XMLHttpRequestGetAllResponseHeaders/*'/>
	public string GetAllResponseHeaders() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XMLHttpRequestOverrideMimeType/XMLHttpRequestOverrideMimeType.generated.xml' path='docs/XMLHttpRequestOverrideMimeType/*'/>
	public Undefined OverrideMimeType(string mime) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XMLHttpRequestResponseType/XMLHttpRequestResponseType.generated.xml' path='docs/XMLHttpRequestResponseType/*'/>
	public XMLHttpRequestResponseType ResponseType { get; set; }
	///<include file='Utils/Docs/XMLHttpRequestResponse/XMLHttpRequestResponse.generated.xml' path='docs/XMLHttpRequestResponse/*'/>
	public dynamic Response { get; }
	///<include file='Utils/Docs/XMLHttpRequestResponseText/XMLHttpRequestResponseText.generated.xml' path='docs/XMLHttpRequestResponseText/*'/>
	public string ResponseText { get; }
	///<include file='Utils/Docs/XMLHttpRequestResponseXML/XMLHttpRequestResponseXML.generated.xml' path='docs/XMLHttpRequestResponseXML/*'/>
	public Document? ResponseXML { get; }
}


///<include file='Utils/Docs/FormData/FormData.generated.xml' path='docs/FormData/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FormData
{
	///<include file='Utils/Docs/FormDataFormData/FormDataFormData.generated.xml' path='docs/FormDataFormData/*'/>
	public FormData(HTMLFormElement form, HTMLElement? submitter) { }
	///<include file='Utils/Docs/FormDataAppend/FormDataAppend.generated.xml' path='docs/FormDataAppend/*'/>
	public Undefined Append(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FormDataAppend/FormDataAppend.generated.xml' path='docs/FormDataAppend/*'/>
	public Undefined Append(string name, Blob blobValue, string filename) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FormDataDelete/FormDataDelete.generated.xml' path='docs/FormDataDelete/*'/>
	public Undefined Delete(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FormDataGet/FormDataGet.generated.xml' path='docs/FormDataGet/*'/>
	public FormDataEntryValue? Get(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FormDataGetAll/FormDataGetAll.generated.xml' path='docs/FormDataGetAll/*'/>
	public List<FormDataEntryValue> GetAll(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FormDataHas/FormDataHas.generated.xml' path='docs/FormDataHas/*'/>
	public bool Has(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FormDataSet/FormDataSet.generated.xml' path='docs/FormDataSet/*'/>
	public Undefined Set(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FormDataSet/FormDataSet.generated.xml' path='docs/FormDataSet/*'/>
	public Undefined Set(string name, Blob blobValue, string filename) { throw new System.NotImplementedException(); }
	public string this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	public FormData() { }
}

///<include file='Utils/Docs/ProgressEvent/ProgressEvent.generated.xml' path='docs/ProgressEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ProgressEvent : Event
{
	///<include file='Utils/Docs/ProgressEventProgressEvent/ProgressEventProgressEvent.generated.xml' path='docs/ProgressEventProgressEvent/*'/>
	public ProgressEvent(string type, ProgressEventInit eventInitDict) { }
	///<include file='Utils/Docs/ProgressEventLengthComputable/ProgressEventLengthComputable.generated.xml' path='docs/ProgressEventLengthComputable/*'/>
	public bool LengthComputable { get; }
	///<include file='Utils/Docs/ProgressEventLoaded/ProgressEventLoaded.generated.xml' path='docs/ProgressEventLoaded/*'/>
	public ulong Loaded { get; }
	///<include file='Utils/Docs/ProgressEventTotal/ProgressEventTotal.generated.xml' path='docs/ProgressEventTotal/*'/>
	public ulong Total { get; }
	public ProgressEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ProgressEventInit : EventInit
{
		public bool LengthComputable;
		public ulong Loaded;
		public ulong Total;
}

///<include file='Utils/Docs/Window/Window.generated.xml' path='docs/Window/*'/>
public partial class Window
{
	///<include file='Utils/Docs/WindowOrientation/WindowOrientation.generated.xml' path='docs/WindowOrientation/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Number Orientation { get; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onorientationchange { get; set; }
}

///<include file='Utils/Docs/HTMLBodyElement/HTMLBodyElement.generated.xml' path='docs/HTMLBodyElement/*'/>
public partial class HTMLBodyElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onorientationchange { get; set; }
}

///<include file='Utils/Docs/Console/Console.generated.xml' path='docs/Console/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class console
{
	///<include file='Utils/Docs/ConsoleAssert/ConsoleAssert.generated.xml' path='docs/ConsoleAssert/*'/>
	public Undefined Assert(bool condition, params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleClear/ConsoleClear.generated.xml' path='docs/ConsoleClear/*'/>
	public Undefined Clear() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleDebug/ConsoleDebug.generated.xml' path='docs/ConsoleDebug/*'/>
	public Undefined Debug(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleError/ConsoleError.generated.xml' path='docs/ConsoleError/*'/>
	public Undefined Error(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleInfo/ConsoleInfo.generated.xml' path='docs/ConsoleInfo/*'/>
	public Undefined Info(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleLog/ConsoleLog.generated.xml' path='docs/ConsoleLog/*'/>
	public Undefined Log(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleTable/ConsoleTable.generated.xml' path='docs/ConsoleTable/*'/>
	public Undefined Table(dynamic tabularData, List<string> properties) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleTrace/ConsoleTrace.generated.xml' path='docs/ConsoleTrace/*'/>
	public Undefined Trace(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleWarn/ConsoleWarn.generated.xml' path='docs/ConsoleWarn/*'/>
	public Undefined Warn(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleDir/ConsoleDir.generated.xml' path='docs/ConsoleDir/*'/>
	public Undefined Dir(dynamic item, object? options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleDirxml/ConsoleDirxml.generated.xml' path='docs/ConsoleDirxml/*'/>
	public Undefined Dirxml(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleCount/ConsoleCount.generated.xml' path='docs/ConsoleCount/*'/>
	public Undefined Count(string label) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleCountReset/ConsoleCountReset.generated.xml' path='docs/ConsoleCountReset/*'/>
	public Undefined CountReset(string label) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleGroup/ConsoleGroup.generated.xml' path='docs/ConsoleGroup/*'/>
	public Undefined Group(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleGroupCollapsed/ConsoleGroupCollapsed.generated.xml' path='docs/ConsoleGroupCollapsed/*'/>
	public Undefined GroupCollapsed(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleGroupEnd/ConsoleGroupEnd.generated.xml' path='docs/ConsoleGroupEnd/*'/>
	public Undefined GroupEnd() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleTime/ConsoleTime.generated.xml' path='docs/ConsoleTime/*'/>
	public Undefined Time(string label) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleTimeLog/ConsoleTimeLog.generated.xml' path='docs/ConsoleTimeLog/*'/>
	public Undefined TimeLog(string label, params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleTimeEnd/ConsoleTimeEnd.generated.xml' path='docs/ConsoleTimeEnd/*'/>
	public Undefined TimeEnd(string label) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/IDBRequest/IDBRequest.generated.xml' path='docs/IDBRequest/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class IDBRequest : EventTarget
{
	///<include file='Utils/Docs/IDBRequestResult/IDBRequestResult.generated.xml' path='docs/IDBRequestResult/*'/>
	public dynamic Result { get; }
	///<include file='Utils/Docs/IDBRequestError/IDBRequestError.generated.xml' path='docs/IDBRequestError/*'/>
	public DOMException? Error { get; }
	///<include file='Utils/Docs/IDBRequestSource/IDBRequestSource.generated.xml' path='docs/IDBRequestSource/*'/>
	public Union73? Source { get; }
	///<include file='Utils/Docs/IDBRequestTransaction/IDBRequestTransaction.generated.xml' path='docs/IDBRequestTransaction/*'/>
	public IDBTransaction? Transaction { get; }
	///<include file='Utils/Docs/IDBRequestReadyState/IDBRequestReadyState.generated.xml' path='docs/IDBRequestReadyState/*'/>
	public IDBRequestReadyState ReadyState { get; }
		public EventHandler Onsuccess { get; set; }
		public EventHandler Onerror { get; set; }
}

///<include file='Utils/Docs/IDBRequestReadyState/IDBRequestReadyState.generated.xml' path='docs/IDBRequestReadyState/*'/>
public enum IDBRequestReadyState
{
	Pending,
	Done,
}

///<include file='Utils/Docs/IDBOpenDBRequest/IDBOpenDBRequest.generated.xml' path='docs/IDBOpenDBRequest/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class IDBOpenDBRequest : IDBRequest
{
		public EventHandler Onblocked { get; set; }
		public EventHandler Onupgradeneeded { get; set; }
}

///<include file='Utils/Docs/IDBVersionChangeEvent/IDBVersionChangeEvent.generated.xml' path='docs/IDBVersionChangeEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class IDBVersionChangeEvent : Event
{
	///<include file='Utils/Docs/IDBVersionChangeEventIDBVersionChangeEvent/IDBVersionChangeEventIDBVersionChangeEvent.generated.xml' path='docs/IDBVersionChangeEventIDBVersionChangeEvent/*'/>
	public IDBVersionChangeEvent(string type, IDBVersionChangeEventInit eventInitDict) { }
	///<include file='Utils/Docs/IDBVersionChangeEventOldVersion/IDBVersionChangeEventOldVersion.generated.xml' path='docs/IDBVersionChangeEventOldVersion/*'/>
	public ulong OldVersion { get; }
	///<include file='Utils/Docs/IDBVersionChangeEventNewVersion/IDBVersionChangeEventNewVersion.generated.xml' path='docs/IDBVersionChangeEventNewVersion/*'/>
	public ulong? NewVersion { get; }
	public IDBVersionChangeEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class IDBVersionChangeEventInit : EventInit
{
		public ulong OldVersion;
		public ulong? NewVersion;
}

public partial interface WindowOrWorkerGlobalScope
{
		public IDBFactory IndexedDB { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/IDBFactory/IDBFactory.generated.xml' path='docs/IDBFactory/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class IDBFactory
{
	///<include file='Utils/Docs/IDBFactoryOpen/IDBFactoryOpen.generated.xml' path='docs/IDBFactoryOpen/*'/>
	public IDBOpenDBRequest Open(string name, ulong version) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBFactoryDeleteDatabase/IDBFactoryDeleteDatabase.generated.xml' path='docs/IDBFactoryDeleteDatabase/*'/>
	public IDBOpenDBRequest DeleteDatabase(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBFactoryDatabases/IDBFactoryDatabases.generated.xml' path='docs/IDBFactoryDatabases/*'/>
	public Task<List<IDBDatabaseInfo>> Databases() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBFactoryCmp/IDBFactoryCmp.generated.xml' path='docs/IDBFactoryCmp/*'/>
	public Number Cmp(dynamic first, dynamic second) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class IDBDatabaseInfo
{
		public string Name;
		public ulong Version;
}

///<include file='Utils/Docs/IDBDatabase/IDBDatabase.generated.xml' path='docs/IDBDatabase/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class IDBDatabase : EventTarget
{
	///<include file='Utils/Docs/IDBDatabaseName/IDBDatabaseName.generated.xml' path='docs/IDBDatabaseName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs/IDBDatabaseVersion/IDBDatabaseVersion.generated.xml' path='docs/IDBDatabaseVersion/*'/>
	public ulong Version { get; }
	///<include file='Utils/Docs/IDBDatabaseObjectStoreNames/IDBDatabaseObjectStoreNames.generated.xml' path='docs/IDBDatabaseObjectStoreNames/*'/>
	public string ObjectStoreNames { get; }
	///<include file='Utils/Docs/IDBDatabaseTransaction/IDBDatabaseTransaction.generated.xml' path='docs/IDBDatabaseTransaction/*'/>
	public IDBTransaction Transaction(Union74 storeNames, IDBTransactionMode mode, IDBTransactionOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBDatabaseClose/IDBDatabaseClose.generated.xml' path='docs/IDBDatabaseClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBDatabaseCreateObjectStore/IDBDatabaseCreateObjectStore.generated.xml' path='docs/IDBDatabaseCreateObjectStore/*'/>
	public IDBObjectStore CreateObjectStore(string name, IDBObjectStoreParameters options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBDatabaseDeleteObjectStore/IDBDatabaseDeleteObjectStore.generated.xml' path='docs/IDBDatabaseDeleteObjectStore/*'/>
	public Undefined DeleteObjectStore(string name) { throw new System.NotImplementedException(); }
		public EventHandler Onabort { get; set; }
		public EventHandler Onclose { get; set; }
		public EventHandler Onerror { get; set; }
		public EventHandler Onversionchange { get; set; }
}

///<include file='Utils/Docs/IDBTransactionDurability/IDBTransactionDurability.generated.xml' path='docs/IDBTransactionDurability/*'/>
public enum IDBTransactionDurability
{
	Default,
	Strict,
	Relaxed,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class IDBTransactionOptions
{
		public IDBTransactionDurability Durability;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class IDBObjectStoreParameters
{
		public Union75? KeyPath;
		public bool AutoIncrement;
}

///<include file='Utils/Docs/IDBObjectStore/IDBObjectStore.generated.xml' path='docs/IDBObjectStore/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class IDBObjectStore
{
	///<include file='Utils/Docs/IDBObjectStoreName/IDBObjectStoreName.generated.xml' path='docs/IDBObjectStoreName/*'/>
	public string Name { get; set; }
	///<include file='Utils/Docs/IDBObjectStoreKeyPath/IDBObjectStoreKeyPath.generated.xml' path='docs/IDBObjectStoreKeyPath/*'/>
	public dynamic KeyPath { get; }
	///<include file='Utils/Docs/IDBObjectStoreIndexNames/IDBObjectStoreIndexNames.generated.xml' path='docs/IDBObjectStoreIndexNames/*'/>
	public string IndexNames { get; }
	///<include file='Utils/Docs/IDBObjectStoreTransaction/IDBObjectStoreTransaction.generated.xml' path='docs/IDBObjectStoreTransaction/*'/>
	public IDBTransaction Transaction { get; }
	///<include file='Utils/Docs/IDBObjectStoreAutoIncrement/IDBObjectStoreAutoIncrement.generated.xml' path='docs/IDBObjectStoreAutoIncrement/*'/>
	public bool AutoIncrement { get; }
	///<include file='Utils/Docs/IDBObjectStorePut/IDBObjectStorePut.generated.xml' path='docs/IDBObjectStorePut/*'/>
	public IDBRequest Put(dynamic value, dynamic key) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBObjectStoreAdd/IDBObjectStoreAdd.generated.xml' path='docs/IDBObjectStoreAdd/*'/>
	public IDBRequest Add(dynamic value, dynamic key) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBObjectStoreDelete/IDBObjectStoreDelete.generated.xml' path='docs/IDBObjectStoreDelete/*'/>
	public IDBRequest Delete(dynamic query) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBObjectStoreClear/IDBObjectStoreClear.generated.xml' path='docs/IDBObjectStoreClear/*'/>
	public IDBRequest Clear() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBObjectStoreGet/IDBObjectStoreGet.generated.xml' path='docs/IDBObjectStoreGet/*'/>
	public IDBRequest Get(dynamic query) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBObjectStoreGetKey/IDBObjectStoreGetKey.generated.xml' path='docs/IDBObjectStoreGetKey/*'/>
	public IDBRequest GetKey(dynamic query) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBObjectStoreGetAll/IDBObjectStoreGetAll.generated.xml' path='docs/IDBObjectStoreGetAll/*'/>
	public IDBRequest GetAll(dynamic query, ulong count) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBObjectStoreGetAllKeys/IDBObjectStoreGetAllKeys.generated.xml' path='docs/IDBObjectStoreGetAllKeys/*'/>
	public IDBRequest GetAllKeys(dynamic query, ulong count) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBObjectStoreCount/IDBObjectStoreCount.generated.xml' path='docs/IDBObjectStoreCount/*'/>
	public IDBRequest Count(dynamic query) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBObjectStoreOpenCursor/IDBObjectStoreOpenCursor.generated.xml' path='docs/IDBObjectStoreOpenCursor/*'/>
	public IDBRequest OpenCursor(dynamic query, IDBCursorDirection direction) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBObjectStoreOpenKeyCursor/IDBObjectStoreOpenKeyCursor.generated.xml' path='docs/IDBObjectStoreOpenKeyCursor/*'/>
	public IDBRequest OpenKeyCursor(dynamic query, IDBCursorDirection direction) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBObjectStoreIndex/IDBObjectStoreIndex.generated.xml' path='docs/IDBObjectStoreIndex/*'/>
	public IDBIndex Index(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBObjectStoreCreateIndex/IDBObjectStoreCreateIndex.generated.xml' path='docs/IDBObjectStoreCreateIndex/*'/>
	public IDBIndex CreateIndex(string name, Union76 keyPath, IDBIndexParameters options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBObjectStoreDeleteIndex/IDBObjectStoreDeleteIndex.generated.xml' path='docs/IDBObjectStoreDeleteIndex/*'/>
	public Undefined DeleteIndex(string name) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class IDBIndexParameters
{
		public bool Unique;
		public bool MultiEntry;
}

///<include file='Utils/Docs/IDBIndex/IDBIndex.generated.xml' path='docs/IDBIndex/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class IDBIndex
{
	///<include file='Utils/Docs/IDBIndexName/IDBIndexName.generated.xml' path='docs/IDBIndexName/*'/>
	public string Name { get; set; }
	///<include file='Utils/Docs/IDBIndexObjectStore/IDBIndexObjectStore.generated.xml' path='docs/IDBIndexObjectStore/*'/>
	public IDBObjectStore ObjectStore { get; }
	///<include file='Utils/Docs/IDBIndexKeyPath/IDBIndexKeyPath.generated.xml' path='docs/IDBIndexKeyPath/*'/>
	public dynamic KeyPath { get; }
	///<include file='Utils/Docs/IDBIndexMultiEntry/IDBIndexMultiEntry.generated.xml' path='docs/IDBIndexMultiEntry/*'/>
	public bool MultiEntry { get; }
	///<include file='Utils/Docs/IDBIndexUnique/IDBIndexUnique.generated.xml' path='docs/IDBIndexUnique/*'/>
	public bool Unique { get; }
	///<include file='Utils/Docs/IDBIndexGet/IDBIndexGet.generated.xml' path='docs/IDBIndexGet/*'/>
	public IDBRequest Get(dynamic query) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBIndexGetKey/IDBIndexGetKey.generated.xml' path='docs/IDBIndexGetKey/*'/>
	public IDBRequest GetKey(dynamic query) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBIndexGetAll/IDBIndexGetAll.generated.xml' path='docs/IDBIndexGetAll/*'/>
	public IDBRequest GetAll(dynamic query, ulong count) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBIndexGetAllKeys/IDBIndexGetAllKeys.generated.xml' path='docs/IDBIndexGetAllKeys/*'/>
	public IDBRequest GetAllKeys(dynamic query, ulong count) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBIndexCount/IDBIndexCount.generated.xml' path='docs/IDBIndexCount/*'/>
	public IDBRequest Count(dynamic query) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBIndexOpenCursor/IDBIndexOpenCursor.generated.xml' path='docs/IDBIndexOpenCursor/*'/>
	public IDBRequest OpenCursor(dynamic query, IDBCursorDirection direction) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBIndexOpenKeyCursor/IDBIndexOpenKeyCursor.generated.xml' path='docs/IDBIndexOpenKeyCursor/*'/>
	public IDBRequest OpenKeyCursor(dynamic query, IDBCursorDirection direction) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/IDBKeyRange/IDBKeyRange.generated.xml' path='docs/IDBKeyRange/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class IDBKeyRange
{
	///<include file='Utils/Docs/IDBKeyRangeLower/IDBKeyRangeLower.generated.xml' path='docs/IDBKeyRangeLower/*'/>
	public dynamic Lower { get; }
	///<include file='Utils/Docs/IDBKeyRangeUpper/IDBKeyRangeUpper.generated.xml' path='docs/IDBKeyRangeUpper/*'/>
	public dynamic Upper { get; }
	///<include file='Utils/Docs/IDBKeyRangeLowerOpen/IDBKeyRangeLowerOpen.generated.xml' path='docs/IDBKeyRangeLowerOpen/*'/>
	public bool LowerOpen { get; }
	///<include file='Utils/Docs/IDBKeyRangeUpperOpen/IDBKeyRangeUpperOpen.generated.xml' path='docs/IDBKeyRangeUpperOpen/*'/>
	public bool UpperOpen { get; }
		public static IDBKeyRange Only(dynamic value) { throw new System.NotImplementedException(); }
		public static IDBKeyRange LowerBound(dynamic lower, bool open) { throw new System.NotImplementedException(); }
		public static IDBKeyRange UpperBound(dynamic upper, bool open) { throw new System.NotImplementedException(); }
		public static IDBKeyRange Bound(dynamic lower, dynamic upper, bool lowerOpen, bool upperOpen) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBKeyRangeIncludes/IDBKeyRangeIncludes.generated.xml' path='docs/IDBKeyRangeIncludes/*'/>
	public bool Includes(dynamic key) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/IDBCursor/IDBCursor.generated.xml' path='docs/IDBCursor/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class IDBCursor
{
	///<include file='Utils/Docs/IDBCursorSource/IDBCursorSource.generated.xml' path='docs/IDBCursorSource/*'/>
	public Union77 Source { get; }
	///<include file='Utils/Docs/IDBCursorDirection/IDBCursorDirection.generated.xml' path='docs/IDBCursorDirection/*'/>
	public IDBCursorDirection Direction { get; }
	///<include file='Utils/Docs/IDBCursorKey/IDBCursorKey.generated.xml' path='docs/IDBCursorKey/*'/>
	public dynamic Key { get; }
	///<include file='Utils/Docs/IDBCursorPrimaryKey/IDBCursorPrimaryKey.generated.xml' path='docs/IDBCursorPrimaryKey/*'/>
	public dynamic PrimaryKey { get; }
	///<include file='Utils/Docs/IDBCursorRequest/IDBCursorRequest.generated.xml' path='docs/IDBCursorRequest/*'/>
	public IDBRequest Request { get; }
	///<include file='Utils/Docs/IDBCursorAdvance/IDBCursorAdvance.generated.xml' path='docs/IDBCursorAdvance/*'/>
	public Undefined Advance(ulong count) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBCursorContinue/IDBCursorContinue.generated.xml' path='docs/IDBCursorContinue/*'/>
	public Undefined Continue(dynamic key) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBCursorContinuePrimaryKey/IDBCursorContinuePrimaryKey.generated.xml' path='docs/IDBCursorContinuePrimaryKey/*'/>
	public Undefined ContinuePrimaryKey(dynamic key, dynamic primaryKey) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBCursorUpdate/IDBCursorUpdate.generated.xml' path='docs/IDBCursorUpdate/*'/>
	public IDBRequest Update(dynamic value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBCursorDelete/IDBCursorDelete.generated.xml' path='docs/IDBCursorDelete/*'/>
	public IDBRequest Delete() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/IDBCursorDirection/IDBCursorDirection.generated.xml' path='docs/IDBCursorDirection/*'/>
public enum IDBCursorDirection
{
	Next,
	Nextunique,
	Prev,
	Prevunique,
}

///<include file='Utils/Docs/IDBCursorWithValue/IDBCursorWithValue.generated.xml' path='docs/IDBCursorWithValue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class IDBCursorWithValue : IDBCursor
{
	///<include file='Utils/Docs/IDBCursorWithValueValue/IDBCursorWithValueValue.generated.xml' path='docs/IDBCursorWithValueValue/*'/>
	public dynamic Value { get; }
}

///<include file='Utils/Docs/IDBTransaction/IDBTransaction.generated.xml' path='docs/IDBTransaction/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class IDBTransaction : EventTarget
{
	///<include file='Utils/Docs/IDBTransactionObjectStoreNames/IDBTransactionObjectStoreNames.generated.xml' path='docs/IDBTransactionObjectStoreNames/*'/>
	public string ObjectStoreNames { get; }
	///<include file='Utils/Docs/IDBTransactionMode/IDBTransactionMode.generated.xml' path='docs/IDBTransactionMode/*'/>
	public IDBTransactionMode Mode { get; }
	///<include file='Utils/Docs/IDBTransactionDurability/IDBTransactionDurability.generated.xml' path='docs/IDBTransactionDurability/*'/>
	public IDBTransactionDurability Durability { get; }
	///<include file='Utils/Docs/IDBTransactionDb/IDBTransactionDb.generated.xml' path='docs/IDBTransactionDb/*'/>
	public IDBDatabase Db { get; }
	///<include file='Utils/Docs/IDBTransactionError/IDBTransactionError.generated.xml' path='docs/IDBTransactionError/*'/>
	public DOMException? Error { get; }
	///<include file='Utils/Docs/IDBTransactionObjectStore/IDBTransactionObjectStore.generated.xml' path='docs/IDBTransactionObjectStore/*'/>
	public IDBObjectStore ObjectStore(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBTransactionCommit/IDBTransactionCommit.generated.xml' path='docs/IDBTransactionCommit/*'/>
	public Undefined Commit() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IDBTransactionAbort/IDBTransactionAbort.generated.xml' path='docs/IDBTransactionAbort/*'/>
	public Undefined Abort() { throw new System.NotImplementedException(); }
		public EventHandler Onabort { get; set; }
		public EventHandler Oncomplete { get; set; }
		public EventHandler Onerror { get; set; }
}

///<include file='Utils/Docs/IDBTransactionMode/IDBTransactionMode.generated.xml' path='docs/IDBTransactionMode/*'/>
public enum IDBTransactionMode
{
	Readonly,
	Readwrite,
	Versionchange,
}

///<include file='Utils/Docs/Element/Element.generated.xml' path='docs/Element/*'/>
public partial class Element
{
		public DOMTokenList Uiactions { get; }
}

///<include file='Utils/Docs/Element/Element.generated.xml' path='docs/Element/*'/>
public partial class Element
{
		public string Uitrigger { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class UIRequestEvent : UIEvent
{
		public UIRequestEvent(string typeArg, UIRequestEventInit dictUIRequestEventInit) { }
		public EventTarget Receiver { get; }
	public UIRequestEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class UIRequestEventInit : UIEventInit
{
		public bool Bubbles;
		public bool Cancelable;
		public WindowProxy? View;
		public long Detail;
		public EventTarget Receiver;
}

///<include file='Utils/Docs/Window/Window.generated.xml' path='docs/Window/*'/>
public partial class Window
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public Unsupported /*DOMstring*/? UserSetting(string key) { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined AddUserSettingListener(string key, UserSettingListener callback) { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined RemoveUserSettingListener(string key, UserSettingListener callback) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface UserSettingListener
{
		public Undefined HandleUserSettingChanged(string key) { throw new System.NotImplementedException(); }
}

public enum RestrictionCategory
{
	None,
	UserColors,
	UserFonts,
	UserMediaSettings,
	UserScreenReaderSettings,
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct IntersectionObserverCallback
{
}

///<include file='Utils/Docs/IntersectionObserver/IntersectionObserver.generated.xml' path='docs/IntersectionObserver/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class IntersectionObserver
{
	///<include file='Utils/Docs/IntersectionObserverIntersectionObserver/IntersectionObserverIntersectionObserver.generated.xml' path='docs/IntersectionObserverIntersectionObserver/*'/>
	public IntersectionObserver(IntersectionObserverCallback callback, IntersectionObserverInit options) { }
	///<include file='Utils/Docs/IntersectionObserverRoot/IntersectionObserverRoot.generated.xml' path='docs/IntersectionObserverRoot/*'/>
	public Union78? Root { get; }
	///<include file='Utils/Docs/IntersectionObserverRootMargin/IntersectionObserverRootMargin.generated.xml' path='docs/IntersectionObserverRootMargin/*'/>
	public string RootMargin { get; }
		public string ScrollMargin { get; }
	///<include file='Utils/Docs/IntersectionObserverThresholds/IntersectionObserverThresholds.generated.xml' path='docs/IntersectionObserverThresholds/*'/>
	public Number[] Thresholds { get; }
	///<include file='Utils/Docs/IntersectionObserverObserve/IntersectionObserverObserve.generated.xml' path='docs/IntersectionObserverObserve/*'/>
	public Undefined Observe(Element target) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IntersectionObserverUnobserve/IntersectionObserverUnobserve.generated.xml' path='docs/IntersectionObserverUnobserve/*'/>
	public Undefined Unobserve(Element target) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IntersectionObserverDisconnect/IntersectionObserverDisconnect.generated.xml' path='docs/IntersectionObserverDisconnect/*'/>
	public Undefined Disconnect() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/IntersectionObserverTakeRecords/IntersectionObserverTakeRecords.generated.xml' path='docs/IntersectionObserverTakeRecords/*'/>
	public List<IntersectionObserverEntry> TakeRecords() { throw new System.NotImplementedException(); }
	public IntersectionObserver() { }
}

///<include file='Utils/Docs/IntersectionObserverEntry/IntersectionObserverEntry.generated.xml' path='docs/IntersectionObserverEntry/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class IntersectionObserverEntry
{
		public IntersectionObserverEntry(IntersectionObserverEntryInit intersectionObserverEntryInit) { }
	///<include file='Utils/Docs/IntersectionObserverEntryTime/IntersectionObserverEntryTime.generated.xml' path='docs/IntersectionObserverEntryTime/*'/>
	public Unsupported /*DOMHighResTimeStamp*/ Time { get; }
	///<include file='Utils/Docs/IntersectionObserverEntryRootBounds/IntersectionObserverEntryRootBounds.generated.xml' path='docs/IntersectionObserverEntryRootBounds/*'/>
	public DOMRectReadOnly? RootBounds { get; }
	///<include file='Utils/Docs/IntersectionObserverEntryBoundingClientRect/IntersectionObserverEntryBoundingClientRect.generated.xml' path='docs/IntersectionObserverEntryBoundingClientRect/*'/>
	public DOMRectReadOnly BoundingClientRect { get; }
	///<include file='Utils/Docs/IntersectionObserverEntryIntersectionRect/IntersectionObserverEntryIntersectionRect.generated.xml' path='docs/IntersectionObserverEntryIntersectionRect/*'/>
	public DOMRectReadOnly IntersectionRect { get; }
	///<include file='Utils/Docs/IntersectionObserverEntryIsIntersecting/IntersectionObserverEntryIsIntersecting.generated.xml' path='docs/IntersectionObserverEntryIsIntersecting/*'/>
	public bool IsIntersecting { get; }
	///<include file='Utils/Docs/IntersectionObserverEntryIntersectionRatio/IntersectionObserverEntryIntersectionRatio.generated.xml' path='docs/IntersectionObserverEntryIntersectionRatio/*'/>
	public Number IntersectionRatio { get; }
	///<include file='Utils/Docs/IntersectionObserverEntryTarget/IntersectionObserverEntryTarget.generated.xml' path='docs/IntersectionObserverEntryTarget/*'/>
	public Element Target { get; }
	public IntersectionObserverEntry() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class IntersectionObserverEntryInit
{
		public required Unsupported /*DOMHighResTimeStamp*/ Time;
		public required DOMRectInit? RootBounds;
		public required DOMRectInit BoundingClientRect;
		public required DOMRectInit IntersectionRect;
		public required bool IsIntersecting;
		public required Number IntersectionRatio;
		public required Element Target;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class IntersectionObserverInit
{
		public Union79? Root;
		public string RootMargin;
		public string ScrollMargin;
		public Union80 Threshold;
}

///<include file='Utils/Docs/LargestContentfulPaint/LargestContentfulPaint.generated.xml' path='docs/LargestContentfulPaint/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class LargestContentfulPaint
{
	///<include file='Utils/Docs/LargestContentfulPaintRenderTime/LargestContentfulPaintRenderTime.generated.xml' path='docs/LargestContentfulPaintRenderTime/*'/>
	public Unsupported /*DOMHighResTimeStamp*/ RenderTime { get; }
	///<include file='Utils/Docs/LargestContentfulPaintLoadTime/LargestContentfulPaintLoadTime.generated.xml' path='docs/LargestContentfulPaintLoadTime/*'/>
	public Unsupported /*DOMHighResTimeStamp*/ LoadTime { get; }
	///<include file='Utils/Docs/LargestContentfulPaintSize/LargestContentfulPaintSize.generated.xml' path='docs/LargestContentfulPaintSize/*'/>
	public ulong Size { get; }
	///<include file='Utils/Docs/LargestContentfulPaintId/LargestContentfulPaintId.generated.xml' path='docs/LargestContentfulPaintId/*'/>
	public string Id { get; }
	///<include file='Utils/Docs/LargestContentfulPaintUrl/LargestContentfulPaintUrl.generated.xml' path='docs/LargestContentfulPaintUrl/*'/>
	public string Url { get; }
	///<include file='Utils/Docs/LargestContentfulPaintElement/LargestContentfulPaintElement.generated.xml' path='docs/LargestContentfulPaintElement/*'/>
	public Element? Element { get; }
	///<include file='Utils/Docs/LargestContentfulPaintToJSON/LargestContentfulPaintToJSON.generated.xml' path='docs/LargestContentfulPaintToJSON/*'/>
	public object ToJSON() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/PerformanceLongTaskTiming/PerformanceLongTaskTiming.generated.xml' path='docs/PerformanceLongTaskTiming/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PerformanceLongTaskTiming
{
	///<include file='Utils/Docs/PerformanceLongTaskTimingAttribution/PerformanceLongTaskTimingAttribution.generated.xml' path='docs/PerformanceLongTaskTimingAttribution/*'/>
	public TaskAttributionTiming[] Attribution { get; }
	///<include file='Utils/Docs/PerformanceLongTaskTimingToJSON/PerformanceLongTaskTimingToJSON.generated.xml' path='docs/PerformanceLongTaskTimingToJSON/*'/>
	public object ToJSON() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/TaskAttributionTiming/TaskAttributionTiming.generated.xml' path='docs/TaskAttributionTiming/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class TaskAttributionTiming
{
	///<include file='Utils/Docs/TaskAttributionTimingContainerType/TaskAttributionTimingContainerType.generated.xml' path='docs/TaskAttributionTimingContainerType/*'/>
	public string ContainerType { get; }
	///<include file='Utils/Docs/TaskAttributionTimingContainerSrc/TaskAttributionTimingContainerSrc.generated.xml' path='docs/TaskAttributionTimingContainerSrc/*'/>
	public string ContainerSrc { get; }
	///<include file='Utils/Docs/TaskAttributionTimingContainerId/TaskAttributionTimingContainerId.generated.xml' path='docs/TaskAttributionTimingContainerId/*'/>
	public string ContainerId { get; }
	///<include file='Utils/Docs/TaskAttributionTimingContainerName/TaskAttributionTimingContainerName.generated.xml' path='docs/TaskAttributionTimingContainerName/*'/>
	public string ContainerName { get; }
	///<include file='Utils/Docs/TaskAttributionTimingToJSON/TaskAttributionTimingToJSON.generated.xml' path='docs/TaskAttributionTimingToJSON/*'/>
	public object ToJSON() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Magnetometer/Magnetometer.generated.xml' path='docs/Magnetometer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Magnetometer : Sensor
{
	///<include file='Utils/Docs/MagnetometerMagnetometer/MagnetometerMagnetometer.generated.xml' path='docs/MagnetometerMagnetometer/*'/>
	public Magnetometer(MagnetometerSensorOptions sensorOptions) { }
	///<include file='Utils/Docs/MagnetometerX/MagnetometerX.generated.xml' path='docs/MagnetometerX/*'/>
	public Number? X { get; }
	///<include file='Utils/Docs/MagnetometerY/MagnetometerY.generated.xml' path='docs/MagnetometerY/*'/>
	public Number? Y { get; }
	///<include file='Utils/Docs/MagnetometerZ/MagnetometerZ.generated.xml' path='docs/MagnetometerZ/*'/>
	public Number? Z { get; }
	public Magnetometer() { }
}

public enum MagnetometerLocalCoordinateSystem
{
	Device,
	Screen,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MagnetometerSensorOptions : SensorOptions
{
		public MagnetometerLocalCoordinateSystem ReferenceFrame;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class UncalibratedMagnetometer : Sensor
{
		public UncalibratedMagnetometer(MagnetometerSensorOptions sensorOptions) { }
		public Number? X { get; }
		public Number? Y { get; }
		public Number? Z { get; }
		public Number? XBias { get; }
		public Number? YBias { get; }
		public Number? ZBias { get; }
	public UncalibratedMagnetometer() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MagnetometerReadingValues
{
		public required Number? X;
		public required Number? Y;
		public required Number? Z;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class UncalibratedMagnetometerReadingValues
{
		public required Number? X;
		public required Number? Y;
		public required Number? Z;
		public required Number? XBias;
		public required Number? YBias;
		public required Number? ZBias;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaConfiguration
{
		public VideoConfiguration Video;
		public AudioConfiguration Audio;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaDecodingConfiguration : MediaConfiguration
{
		public required MediaDecodingType Type;
		public MediaCapabilitiesKeySystemConfiguration KeySystemConfiguration;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaEncodingConfiguration : MediaConfiguration
{
		public required MediaEncodingType Type;
}

public enum MediaDecodingType
{
	File,
	MediaSource,
	Webrtc,
}

public enum MediaEncodingType
{
	Record,
	Webrtc,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoConfiguration
{
		public required string ContentType;
		public required ulong Width;
		public required ulong Height;
		public required ulong Bitrate;
		public required Number Framerate;
		public bool HasAlphaChannel;
		public HdrMetadataType HdrMetadataType;
		public ColorGamut ColorGamut;
		public TransferFunction TransferFunction;
		public string ScalabilityMode;
		public bool SpatialScalability;
}

public enum HdrMetadataType
{
	SmpteSt2086,
	SmpteSt209410,
	SmpteSt209440,
}

public enum ColorGamut
{
	Srgb,
	P3,
	Rec2020,
}

public enum TransferFunction
{
	Srgb,
	Pq,
	Hlg,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioConfiguration
{
		public required string ContentType;
		public string Channels;
		public ulong Bitrate;
		public ulong Samplerate;
		public bool SpatialRendering;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaCapabilitiesKeySystemConfiguration
{
		public required string KeySystem;
		public string InitDataType;
		public Unsupported /*MediaKeysRequirement*/ DistinctiveIdentifier;
		public Unsupported /*MediaKeysRequirement*/ PersistentState;
		public List<string> SessionTypes;
		public KeySystemTrackConfiguration Audio;
		public KeySystemTrackConfiguration Video;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class KeySystemTrackConfiguration
{
		public string Robustness;
		public string? EncryptionScheme;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaCapabilitiesInfo
{
		public required bool Supported;
		public required bool Smooth;
		public required bool PowerEfficient;
}

///<include file='Utils/Docs/MediaCapabilitiesDecodingInfo/MediaCapabilitiesDecodingInfo.generated.xml' path='docs/MediaCapabilitiesDecodingInfo/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaCapabilitiesDecodingInfo : MediaCapabilitiesInfo
{
		public required Unsupported /*MediaKeySystemAccess*/ KeySystemAccess;
		public MediaDecodingConfiguration Configuration;
}

///<include file='Utils/Docs/MediaCapabilitiesEncodingInfo/MediaCapabilitiesEncodingInfo.generated.xml' path='docs/MediaCapabilitiesEncodingInfo/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaCapabilitiesEncodingInfo : MediaCapabilitiesInfo
{
		public MediaEncodingConfiguration Configuration;
}

///<include file='Utils/Docs/Navigator/Navigator.generated.xml' path='docs/Navigator/*'/>
public partial class Navigator
{
	///<include file='Utils/Docs/NavigatorMediaCapabilities/NavigatorMediaCapabilities.generated.xml' path='docs/NavigatorMediaCapabilities/*'/>
	public MediaCapabilities MediaCapabilities { get; }
}

///<include file='Utils/Docs/WorkerNavigator/WorkerNavigator.generated.xml' path='docs/WorkerNavigator/*'/>
public partial class WorkerNavigator
{
	///<include file='Utils/Docs/WorkerNavigatorMediaCapabilities/WorkerNavigatorMediaCapabilities.generated.xml' path='docs/WorkerNavigatorMediaCapabilities/*'/>
	public MediaCapabilities MediaCapabilities { get; }
}

///<include file='Utils/Docs/MediaCapabilities/MediaCapabilities.generated.xml' path='docs/MediaCapabilities/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaCapabilities
{
	///<include file='Utils/Docs/MediaCapabilitiesDecodingInfo/MediaCapabilitiesDecodingInfo.generated.xml' path='docs/MediaCapabilitiesDecodingInfo/*'/>
	public Task<MediaCapabilitiesDecodingInfo> DecodingInfo(MediaDecodingConfiguration configuration) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MediaCapabilitiesEncodingInfo/MediaCapabilitiesEncodingInfo.generated.xml' path='docs/MediaCapabilitiesEncodingInfo/*'/>
	public Task<MediaCapabilitiesEncodingInfo> EncodingInfo(MediaEncodingConfiguration configuration) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Navigator/Navigator.generated.xml' path='docs/Navigator/*'/>
public partial class Navigator
{
	///<include file='Utils/Docs/NavigatorMediaSession/NavigatorMediaSession.generated.xml' path='docs/NavigatorMediaSession/*'/>
	public MediaSession MediaSession { get; }
}

///<include file='Utils/Docs/MediaSessionPlaybackState/MediaSessionPlaybackState.generated.xml' path='docs/MediaSessionPlaybackState/*'/>
public enum MediaSessionPlaybackState
{
	None,
	Paused,
	Playing,
}

public enum MediaSessionAction
{
	Play,
	Pause,
	Seekbackward,
	Seekforward,
	Previoustrack,
	Nexttrack,
	Skipad,
	Stop,
	Seekto,
	Togglemicrophone,
	Togglecamera,
	Hangup,
	Previousslide,
	Nextslide,
	Enterpictureinpicture,
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct MediaSessionActionHandler
{
}

///<include file='Utils/Docs/MediaSession/MediaSession.generated.xml' path='docs/MediaSession/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaSession
{
	///<include file='Utils/Docs/MediaSessionMetadata/MediaSessionMetadata.generated.xml' path='docs/MediaSessionMetadata/*'/>
	public MediaMetadata? Metadata { get; set; }
	///<include file='Utils/Docs/MediaSessionPlaybackState/MediaSessionPlaybackState.generated.xml' path='docs/MediaSessionPlaybackState/*'/>
	public MediaSessionPlaybackState PlaybackState { get; set; }
	///<include file='Utils/Docs/MediaSessionSetActionHandler/MediaSessionSetActionHandler.generated.xml' path='docs/MediaSessionSetActionHandler/*'/>
	public Undefined SetActionHandler(MediaSessionAction action, MediaSessionActionHandler? handler) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MediaSessionSetPositionState/MediaSessionSetPositionState.generated.xml' path='docs/MediaSessionSetPositionState/*'/>
	public Undefined SetPositionState(MediaPositionState state) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MediaSessionSetMicrophoneActive/MediaSessionSetMicrophoneActive.generated.xml' path='docs/MediaSessionSetMicrophoneActive/*'/>
	public Undefined SetMicrophoneActive(bool active) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MediaSessionSetCameraActive/MediaSessionSetCameraActive.generated.xml' path='docs/MediaSessionSetCameraActive/*'/>
	public Undefined SetCameraActive(bool active) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/MediaMetadata/MediaMetadata.generated.xml' path='docs/MediaMetadata/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaMetadata
{
	///<include file='Utils/Docs/MediaMetadataMediaMetadata/MediaMetadataMediaMetadata.generated.xml' path='docs/MediaMetadataMediaMetadata/*'/>
	public MediaMetadata(MediaMetadataInit init) { }
	///<include file='Utils/Docs/MediaMetadataTitle/MediaMetadataTitle.generated.xml' path='docs/MediaMetadataTitle/*'/>
	public string Title { get; set; }
	///<include file='Utils/Docs/MediaMetadataArtist/MediaMetadataArtist.generated.xml' path='docs/MediaMetadataArtist/*'/>
	public string Artist { get; set; }
	///<include file='Utils/Docs/MediaMetadataAlbum/MediaMetadataAlbum.generated.xml' path='docs/MediaMetadataAlbum/*'/>
	public string Album { get; set; }
	///<include file='Utils/Docs/MediaMetadataArtwork/MediaMetadataArtwork.generated.xml' path='docs/MediaMetadataArtwork/*'/>
	public MediaImage[] Artwork { get; set; }
	public MediaMetadata() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaMetadataInit
{
		public string Title;
		public string Artist;
		public string Album;
		public List<MediaImage> Artwork;
}

///<include file='Utils/Docs/MediaImage/MediaImage.generated.xml' path='docs/MediaImage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaImage
{
		public required string Src;
		public string Sizes;
		public string Type;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaPositionState
{
		public Number Duration;
		public Number PlaybackRate;
		public Number Position;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaSessionActionDetails
{
		public required MediaSessionAction Action;
		public Number SeekOffset;
		public Number SeekTime;
		public bool FastSeek;
}

///<include file='Utils/Docs/ImageCapture/ImageCapture.generated.xml' path='docs/ImageCapture/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageCapture
{
	///<include file='Utils/Docs/ImageCaptureImageCapture/ImageCaptureImageCapture.generated.xml' path='docs/ImageCaptureImageCapture/*'/>
	public ImageCapture(Unsupported /*MediaStreamTrack*/ videoTrack) { }
	///<include file='Utils/Docs/ImageCaptureTakePhoto/ImageCaptureTakePhoto.generated.xml' path='docs/ImageCaptureTakePhoto/*'/>
	public Task<Blob> TakePhoto(PhotoSettings photoSettings) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ImageCaptureGetPhotoCapabilities/ImageCaptureGetPhotoCapabilities.generated.xml' path='docs/ImageCaptureGetPhotoCapabilities/*'/>
	public Task<PhotoCapabilities> GetPhotoCapabilities() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ImageCaptureGetPhotoSettings/ImageCaptureGetPhotoSettings.generated.xml' path='docs/ImageCaptureGetPhotoSettings/*'/>
	public Task<PhotoSettings> GetPhotoSettings() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ImageCaptureGrabFrame/ImageCaptureGrabFrame.generated.xml' path='docs/ImageCaptureGrabFrame/*'/>
	public Task<ImageBitmap> GrabFrame() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ImageCaptureTrack/ImageCaptureTrack.generated.xml' path='docs/ImageCaptureTrack/*'/>
	public Unsupported /*MediaStreamTrack*/ Track { get; }
	public ImageCapture() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PhotoCapabilities
{
		public RedEyeReduction RedEyeReduction;
		public MediaSettingsRange ImageHeight;
		public MediaSettingsRange ImageWidth;
		public List<FillLightMode> FillLightMode;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PhotoSettings
{
		public FillLightMode FillLightMode;
		public Number ImageHeight;
		public Number ImageWidth;
		public bool RedEyeReduction;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaSettingsRange
{
		public Number Max;
		public Number Min;
		public Number Step;
}

public enum RedEyeReduction
{
	Never,
	Always,
	Controllable,
}

public enum FillLightMode
{
	Auto,
	Off,
	Flash,
}

///<include file='Utils/Docs/MediaTrackSupportedConstraints/MediaTrackSupportedConstraints.generated.xml' path='docs/MediaTrackSupportedConstraints/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaTrackSupportedConstraints
{
		public bool WhiteBalanceMode;
		public bool ExposureMode;
		public bool FocusMode;
		public bool PointsOfInterest;
		public bool ExposureCompensation;
		public bool ExposureTime;
		public bool ColorTemperature;
		public bool Iso;
		public bool Brightness;
		public bool Contrast;
		public bool Pan;
		public bool Saturation;
		public bool Sharpness;
		public bool FocusDistance;
		public bool Tilt;
		public bool Zoom;
		public bool Torch;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaTrackCapabilities
{
		public List<string> WhiteBalanceMode;
		public List<string> ExposureMode;
		public List<string> FocusMode;
		public MediaSettingsRange ExposureCompensation;
		public MediaSettingsRange ExposureTime;
		public MediaSettingsRange ColorTemperature;
		public MediaSettingsRange Iso;
		public MediaSettingsRange Brightness;
		public MediaSettingsRange Contrast;
		public MediaSettingsRange Saturation;
		public MediaSettingsRange Sharpness;
		public MediaSettingsRange FocusDistance;
		public MediaSettingsRange Pan;
		public MediaSettingsRange Tilt;
		public MediaSettingsRange Zoom;
		public List<bool> Torch;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaTrackConstraintSet
{
		public string WhiteBalanceMode;
		public string ExposureMode;
		public string FocusMode;
		public ConstrainPoint2D PointsOfInterest;
		public Unsupported /*ConstrainDouble*/ ExposureCompensation;
		public Unsupported /*ConstrainDouble*/ ExposureTime;
		public Unsupported /*ConstrainDouble*/ ColorTemperature;
		public Unsupported /*ConstrainDouble*/ Iso;
		public Unsupported /*ConstrainDouble*/ Brightness;
		public Unsupported /*ConstrainDouble*/ Contrast;
		public Unsupported /*ConstrainDouble*/ Saturation;
		public Unsupported /*ConstrainDouble*/ Sharpness;
		public Unsupported /*ConstrainDouble*/ FocusDistance;
		public Union81 Pan;
		public Union82 Tilt;
		public Union83 Zoom;
		public Unsupported /*ConstrainBoolean*/ Torch;
}

///<include file='Utils/Docs/MediaTrackSettings/MediaTrackSettings.generated.xml' path='docs/MediaTrackSettings/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaTrackSettings
{
		public string WhiteBalanceMode;
		public string ExposureMode;
		public string FocusMode;
		public List<Point2D> PointsOfInterest;
		public Number ExposureCompensation;
		public Number ExposureTime;
		public Number ColorTemperature;
		public Number Iso;
		public Number Brightness;
		public Number Contrast;
		public Number Saturation;
		public Number Sharpness;
		public Number FocusDistance;
		public Number Pan;
		public Number Tilt;
		public Number Zoom;
		public bool Torch;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ConstrainPoint2DParameters
{
		public List<Point2D> Exact;
		public List<Point2D> Ideal;
}


public enum MeteringMode
{
	None,
	Manual,
	SingleShot,
	Continuous,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class Point2D
{
		public Number X;
		public Number Y;
}

///<include file='Utils/Docs/MediaRecorder/MediaRecorder.generated.xml' path='docs/MediaRecorder/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaRecorder : EventTarget
{
	///<include file='Utils/Docs/MediaRecorderMediaRecorder/MediaRecorderMediaRecorder.generated.xml' path='docs/MediaRecorderMediaRecorder/*'/>
	public MediaRecorder(Unsupported /*MediaStream*/ stream, MediaRecorderOptions options) { }
	///<include file='Utils/Docs/MediaRecorderStream/MediaRecorderStream.generated.xml' path='docs/MediaRecorderStream/*'/>
	public Unsupported /*MediaStream*/ Stream { get; }
	///<include file='Utils/Docs/MediaRecorderMimeType/MediaRecorderMimeType.generated.xml' path='docs/MediaRecorderMimeType/*'/>
	public string MimeType { get; }
	///<include file='Utils/Docs/MediaRecorderState/MediaRecorderState.generated.xml' path='docs/MediaRecorderState/*'/>
	public RecordingState State { get; }
		public EventHandler Onstart { get; set; }
		public EventHandler Onstop { get; set; }
		public EventHandler Ondataavailable { get; set; }
		public EventHandler Onpause { get; set; }
		public EventHandler Onresume { get; set; }
		public EventHandler Onerror { get; set; }
	///<include file='Utils/Docs/MediaRecorderVideoBitsPerSecond/MediaRecorderVideoBitsPerSecond.generated.xml' path='docs/MediaRecorderVideoBitsPerSecond/*'/>
	public ulong VideoBitsPerSecond { get; }
	///<include file='Utils/Docs/MediaRecorderAudioBitsPerSecond/MediaRecorderAudioBitsPerSecond.generated.xml' path='docs/MediaRecorderAudioBitsPerSecond/*'/>
	public ulong AudioBitsPerSecond { get; }
		public BitrateMode AudioBitrateMode { get; }
	///<include file='Utils/Docs/MediaRecorderStart/MediaRecorderStart.generated.xml' path='docs/MediaRecorderStart/*'/>
	public Undefined Start(ulong timeslice) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MediaRecorderStop/MediaRecorderStop.generated.xml' path='docs/MediaRecorderStop/*'/>
	public Undefined Stop() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MediaRecorderPause/MediaRecorderPause.generated.xml' path='docs/MediaRecorderPause/*'/>
	public Undefined Pause() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MediaRecorderResume/MediaRecorderResume.generated.xml' path='docs/MediaRecorderResume/*'/>
	public Undefined Resume() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MediaRecorderRequestData/MediaRecorderRequestData.generated.xml' path='docs/MediaRecorderRequestData/*'/>
	public Undefined RequestData() { throw new System.NotImplementedException(); }
		public static bool IsTypeSupported(string type) { throw new System.NotImplementedException(); }
	public MediaRecorder() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaRecorderOptions
{
		public string MimeType;
		public ulong AudioBitsPerSecond;
		public ulong VideoBitsPerSecond;
		public ulong BitsPerSecond;
		public BitrateMode AudioBitrateMode;
		public Unsupported /*DOMHighResTimeStamp*/ VideoKeyFrameIntervalDuration;
		public ulong VideoKeyFrameIntervalCount;
}

public enum BitrateMode
{
	Constant,
	Variable,
}

public enum RecordingState
{
	Inactive,
	Recording,
	Paused,
}

///<include file='Utils/Docs/BlobEvent/BlobEvent.generated.xml' path='docs/BlobEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class BlobEvent : Event
{
	///<include file='Utils/Docs/BlobEventBlobEvent/BlobEventBlobEvent.generated.xml' path='docs/BlobEventBlobEvent/*'/>
	public BlobEvent(string type, BlobEventInit eventInitDict) { }
	///<include file='Utils/Docs/BlobEventData/BlobEventData.generated.xml' path='docs/BlobEventData/*'/>
	public Blob Data { get; }
	///<include file='Utils/Docs/BlobEventTimecode/BlobEventTimecode.generated.xml' path='docs/BlobEventTimecode/*'/>
	public Unsupported /*DOMHighResTimeStamp*/ Timecode { get; }
	public BlobEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class BlobEventInit
{
		public required Blob Data;
		public Unsupported /*DOMHighResTimeStamp*/ Timecode;
}

///<include file='Utils/Docs/MediaStreamTrackProcessor/MediaStreamTrackProcessor.generated.xml' path='docs/MediaStreamTrackProcessor/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaStreamTrackProcessor
{
	///<include file='Utils/Docs/MediaStreamTrackProcessorMediaStreamTrackProcessor/MediaStreamTrackProcessorMediaStreamTrackProcessor.generated.xml' path='docs/MediaStreamTrackProcessorMediaStreamTrackProcessor/*'/>
	public MediaStreamTrackProcessor(MediaStreamTrackProcessorInit init) { }
	///<include file='Utils/Docs/MediaStreamTrackProcessorReadable/MediaStreamTrackProcessorReadable.generated.xml' path='docs/MediaStreamTrackProcessorReadable/*'/>
	public ReadableStream Readable { get; set; }
	public MediaStreamTrackProcessor() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaStreamTrackProcessorInit
{
		public required Unsupported /*MediaStreamTrack*/ Track;
		public ushort MaxBufferSize;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoTrackGenerator
{
		public VideoTrackGenerator() { }
		public WritableStream Writable { get; }
		public bool Muted { get; set; }
		public Unsupported /*MediaStreamTrack*/ Track { get; }
}

///<include file='Utils/Docs/PerformanceTiming/PerformanceTiming.generated.xml' path='docs/PerformanceTiming/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PerformanceTiming
{
	///<include file='Utils/Docs/PerformanceTimingNavigationStart/PerformanceTimingNavigationStart.generated.xml' path='docs/PerformanceTimingNavigationStart/*'/>
	public ulong NavigationStart { get; }
	///<include file='Utils/Docs/PerformanceTimingUnloadEventStart/PerformanceTimingUnloadEventStart.generated.xml' path='docs/PerformanceTimingUnloadEventStart/*'/>
	public ulong UnloadEventStart { get; }
	///<include file='Utils/Docs/PerformanceTimingUnloadEventEnd/PerformanceTimingUnloadEventEnd.generated.xml' path='docs/PerformanceTimingUnloadEventEnd/*'/>
	public ulong UnloadEventEnd { get; }
	///<include file='Utils/Docs/PerformanceTimingRedirectStart/PerformanceTimingRedirectStart.generated.xml' path='docs/PerformanceTimingRedirectStart/*'/>
	public ulong RedirectStart { get; }
	///<include file='Utils/Docs/PerformanceTimingRedirectEnd/PerformanceTimingRedirectEnd.generated.xml' path='docs/PerformanceTimingRedirectEnd/*'/>
	public ulong RedirectEnd { get; }
	///<include file='Utils/Docs/PerformanceTimingFetchStart/PerformanceTimingFetchStart.generated.xml' path='docs/PerformanceTimingFetchStart/*'/>
	public ulong FetchStart { get; }
	///<include file='Utils/Docs/PerformanceTimingDomainLookupStart/PerformanceTimingDomainLookupStart.generated.xml' path='docs/PerformanceTimingDomainLookupStart/*'/>
	public ulong DomainLookupStart { get; }
	///<include file='Utils/Docs/PerformanceTimingDomainLookupEnd/PerformanceTimingDomainLookupEnd.generated.xml' path='docs/PerformanceTimingDomainLookupEnd/*'/>
	public ulong DomainLookupEnd { get; }
	///<include file='Utils/Docs/PerformanceTimingConnectStart/PerformanceTimingConnectStart.generated.xml' path='docs/PerformanceTimingConnectStart/*'/>
	public ulong ConnectStart { get; }
	///<include file='Utils/Docs/PerformanceTimingConnectEnd/PerformanceTimingConnectEnd.generated.xml' path='docs/PerformanceTimingConnectEnd/*'/>
	public ulong ConnectEnd { get; }
	///<include file='Utils/Docs/PerformanceTimingSecureConnectionStart/PerformanceTimingSecureConnectionStart.generated.xml' path='docs/PerformanceTimingSecureConnectionStart/*'/>
	public ulong SecureConnectionStart { get; }
	///<include file='Utils/Docs/PerformanceTimingRequestStart/PerformanceTimingRequestStart.generated.xml' path='docs/PerformanceTimingRequestStart/*'/>
	public ulong RequestStart { get; }
	///<include file='Utils/Docs/PerformanceTimingResponseStart/PerformanceTimingResponseStart.generated.xml' path='docs/PerformanceTimingResponseStart/*'/>
	public ulong ResponseStart { get; }
	///<include file='Utils/Docs/PerformanceTimingResponseEnd/PerformanceTimingResponseEnd.generated.xml' path='docs/PerformanceTimingResponseEnd/*'/>
	public ulong ResponseEnd { get; }
	///<include file='Utils/Docs/PerformanceTimingDomLoading/PerformanceTimingDomLoading.generated.xml' path='docs/PerformanceTimingDomLoading/*'/>
	public ulong DomLoading { get; }
	///<include file='Utils/Docs/PerformanceTimingDomInteractive/PerformanceTimingDomInteractive.generated.xml' path='docs/PerformanceTimingDomInteractive/*'/>
	public ulong DomInteractive { get; }
	///<include file='Utils/Docs/PerformanceTimingDomContentLoadedEventStart/PerformanceTimingDomContentLoadedEventStart.generated.xml' path='docs/PerformanceTimingDomContentLoadedEventStart/*'/>
	public ulong DomContentLoadedEventStart { get; }
	///<include file='Utils/Docs/PerformanceTimingDomContentLoadedEventEnd/PerformanceTimingDomContentLoadedEventEnd.generated.xml' path='docs/PerformanceTimingDomContentLoadedEventEnd/*'/>
	public ulong DomContentLoadedEventEnd { get; }
	///<include file='Utils/Docs/PerformanceTimingDomComplete/PerformanceTimingDomComplete.generated.xml' path='docs/PerformanceTimingDomComplete/*'/>
	public ulong DomComplete { get; }
	///<include file='Utils/Docs/PerformanceTimingLoadEventStart/PerformanceTimingLoadEventStart.generated.xml' path='docs/PerformanceTimingLoadEventStart/*'/>
	public ulong LoadEventStart { get; }
	///<include file='Utils/Docs/PerformanceTimingLoadEventEnd/PerformanceTimingLoadEventEnd.generated.xml' path='docs/PerformanceTimingLoadEventEnd/*'/>
	public ulong LoadEventEnd { get; }
}

///<include file='Utils/Docs/PerformanceNavigation/PerformanceNavigation.generated.xml' path='docs/PerformanceNavigation/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PerformanceNavigation
{
		public const ushort TYPE_NAVIGATE = 0;
		public const ushort TYPE_RELOAD = 1;
		public const ushort TYPE_BACK_FORWARD = 2;
		public const ushort TYPE_RESERVED = 255;
	///<include file='Utils/Docs/PerformanceNavigationType/PerformanceNavigationType.generated.xml' path='docs/PerformanceNavigationType/*'/>
	public ushort Type { get; }
	///<include file='Utils/Docs/PerformanceNavigationRedirectCount/PerformanceNavigationRedirectCount.generated.xml' path='docs/PerformanceNavigationRedirectCount/*'/>
	public ushort RedirectCount { get; }
}

///<include file='Utils/Docs/Performance/Performance.generated.xml' path='docs/Performance/*'/>
public partial class Performance
{
	///<include file='Utils/Docs/PerformanceTiming/PerformanceTiming.generated.xml' path='docs/PerformanceTiming/*'/>
	public PerformanceTiming Timing { get; }
	///<include file='Utils/Docs/PerformanceNavigation/PerformanceNavigation.generated.xml' path='docs/PerformanceNavigation/*'/>
	public PerformanceNavigation Navigation { get; }
}

///<include file='Utils/Docs/Window/Window.generated.xml' path='docs/Window/*'/>
public partial class Window
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public Performance Performance { get; }
}


///<include file='Utils/Docs/OrientationSensor/OrientationSensor.generated.xml' path='docs/OrientationSensor/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class OrientationSensor : Sensor
{
	///<include file='Utils/Docs/OrientationSensorQuaternion/OrientationSensorQuaternion.generated.xml' path='docs/OrientationSensorQuaternion/*'/>
	public Number[]? Quaternion { get; }
	///<include file='Utils/Docs/OrientationSensorPopulateMatrix/OrientationSensorPopulateMatrix.generated.xml' path='docs/OrientationSensorPopulateMatrix/*'/>
	public Undefined PopulateMatrix(RotationMatrixType targetMatrix) { throw new System.NotImplementedException(); }
}

public enum OrientationSensorLocalCoordinateSystem
{
	Device,
	Screen,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class OrientationSensorOptions : SensorOptions
{
		public OrientationSensorLocalCoordinateSystem ReferenceFrame;
}

///<include file='Utils/Docs/AbsoluteOrientationSensor/AbsoluteOrientationSensor.generated.xml' path='docs/AbsoluteOrientationSensor/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AbsoluteOrientationSensor : OrientationSensor
{
	///<include file='Utils/Docs/AbsoluteOrientationSensorAbsoluteOrientationSensor/AbsoluteOrientationSensorAbsoluteOrientationSensor.generated.xml' path='docs/AbsoluteOrientationSensorAbsoluteOrientationSensor/*'/>
	public AbsoluteOrientationSensor(OrientationSensorOptions sensorOptions) { }
	public AbsoluteOrientationSensor() { }
}

///<include file='Utils/Docs/RelativeOrientationSensor/RelativeOrientationSensor.generated.xml' path='docs/RelativeOrientationSensor/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class RelativeOrientationSensor : OrientationSensor
{
	///<include file='Utils/Docs/RelativeOrientationSensorRelativeOrientationSensor/RelativeOrientationSensorRelativeOrientationSensor.generated.xml' path='docs/RelativeOrientationSensorRelativeOrientationSensor/*'/>
	public RelativeOrientationSensor(OrientationSensorOptions sensorOptions) { }
	public RelativeOrientationSensor() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AbsoluteOrientationReadingValues
{
		public required Number[]? Quaternion;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class RelativeOrientationReadingValues : AbsoluteOrientationReadingValues
{
}

///<include file='Utils/Docs/PerformancePaintTiming/PerformancePaintTiming.generated.xml' path='docs/PerformancePaintTiming/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PerformancePaintTiming
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PermissionsPolicy
{
		public bool AllowsFeature(string feature, string origin) { throw new System.NotImplementedException(); }
		public List<string> Features() { throw new System.NotImplementedException(); }
		public List<string> AllowedFeatures() { throw new System.NotImplementedException(); }
		public List<string> GetAllowlistForFeature(string feature) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Document/Document.generated.xml' path='docs/Document/*'/>
public partial class Document
{
		public PermissionsPolicy PermissionsPolicy { get; }
}

///<include file='Utils/Docs/HTMLIFrameElement/HTMLIFrameElement.generated.xml' path='docs/HTMLIFrameElement/*'/>
public partial class HTMLIFrameElement
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public PermissionsPolicy PermissionsPolicy { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PermissionsPolicyViolationReportBody : ReportBody
{
		public string FeatureId { get; }
		public string? SourceFile { get; }
		public long? LineNumber { get; }
		public long? ColumnNumber { get; }
		public string Disposition { get; }
}

///<include file='Utils/Docs/HTMLVideoElement/HTMLVideoElement.generated.xml' path='docs/HTMLVideoElement/*'/>
public partial class HTMLVideoElement
{
	///<include file='Utils/Docs/HTMLVideoElementRequestPictureInPicture/HTMLVideoElementRequestPictureInPicture.generated.xml' path='docs/HTMLVideoElementRequestPictureInPicture/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public Task<PictureInPictureWindow> RequestPictureInPicture() { throw new System.NotImplementedException(); }
		[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onenterpictureinpicture { get; set; }
		[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onleavepictureinpicture { get; set; }
	///<include file='Utils/Docs/HTMLVideoElementDisablePictureInPicture/HTMLVideoElementDisablePictureInPicture.generated.xml' path='docs/HTMLVideoElementDisablePictureInPicture/*'/>
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool DisablePictureInPicture { get; set; }
}

///<include file='Utils/Docs/Document/Document.generated.xml' path='docs/Document/*'/>
public partial class Document
{
	///<include file='Utils/Docs/DocumentPictureInPictureEnabled/DocumentPictureInPictureEnabled.generated.xml' path='docs/DocumentPictureInPictureEnabled/*'/>
	public bool PictureInPictureEnabled { get; }
	///<include file='Utils/Docs/DocumentExitPictureInPicture/DocumentExitPictureInPicture.generated.xml' path='docs/DocumentExitPictureInPicture/*'/>
	public Task<Undefined> ExitPictureInPicture() { throw new System.NotImplementedException(); }
}

public partial interface DocumentOrShadowRoot
{
		public Element? PictureInPictureElement { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/PictureInPictureWindow/PictureInPictureWindow.generated.xml' path='docs/PictureInPictureWindow/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PictureInPictureWindow : EventTarget
{
	///<include file='Utils/Docs/PictureInPictureWindowWidth/PictureInPictureWindowWidth.generated.xml' path='docs/PictureInPictureWindowWidth/*'/>
	public long Width { get; }
	///<include file='Utils/Docs/PictureInPictureWindowHeight/PictureInPictureWindowHeight.generated.xml' path='docs/PictureInPictureWindowHeight/*'/>
	public long Height { get; }
		public EventHandler Onresize { get; set; }
}

///<include file='Utils/Docs/PictureInPictureEvent/PictureInPictureEvent.generated.xml' path='docs/PictureInPictureEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PictureInPictureEvent : Event
{
	///<include file='Utils/Docs/PictureInPictureEventPictureInPictureEvent/PictureInPictureEventPictureInPictureEvent.generated.xml' path='docs/PictureInPictureEventPictureInPictureEvent/*'/>
	public PictureInPictureEvent(string type, PictureInPictureEventInit eventInitDict) { }
		public PictureInPictureWindow PictureInPictureWindow { get; }
	public PictureInPictureEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PictureInPictureEventInit : EventInit
{
		public required PictureInPictureWindow PictureInPictureWindow;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ProximitySensor : Sensor
{
		public ProximitySensor(SensorOptions sensorOptions) { }
		public Number? Distance { get; }
		public Number? Max { get; }
		public bool? Near { get; }
	public ProximitySensor() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ProximityReadingValues
{
		public required Number? Distance;
		public required Number? Max;
		public required bool? Near;
}

public enum ReferrerPolicy
{
	Empty,
	NoReferrer,
	NoReferrerWhenDowngrade,
	SameOrigin,
	Origin,
	StrictOrigin,
	OriginWhenCrossOrigin,
	StrictOriginWhenCrossOrigin,
	UnsafeUrl,
}

///<include file='Utils/Docs/ReportBody/ReportBody.generated.xml' path='docs/ReportBody/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ReportBody
{
	///<include file='Utils/Docs/ReportBodyToJSON/ReportBodyToJSON.generated.xml' path='docs/ReportBodyToJSON/*'/>
	public object ToJSON() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Report/Report.generated.xml' path='docs/Report/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Report
{
		public object ToJSON() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ReportType/ReportType.generated.xml' path='docs/ReportType/*'/>
	public string Type { get; }
	///<include file='Utils/Docs/ReportUrl/ReportUrl.generated.xml' path='docs/ReportUrl/*'/>
	public string Url { get; }
	///<include file='Utils/Docs/ReportBody/ReportBody.generated.xml' path='docs/ReportBody/*'/>
	public ReportBody? Body { get; }
}

///<include file='Utils/Docs/ReportingObserver/ReportingObserver.generated.xml' path='docs/ReportingObserver/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ReportingObserver
{
	///<include file='Utils/Docs/ReportingObserverReportingObserver/ReportingObserverReportingObserver.generated.xml' path='docs/ReportingObserverReportingObserver/*'/>
	public ReportingObserver(ReportingObserverCallback callback, ReportingObserverOptions options) { }
	///<include file='Utils/Docs/ReportingObserverObserve/ReportingObserverObserve.generated.xml' path='docs/ReportingObserverObserve/*'/>
	public Undefined Observe() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ReportingObserverDisconnect/ReportingObserverDisconnect.generated.xml' path='docs/ReportingObserverDisconnect/*'/>
	public Undefined Disconnect() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ReportingObserverTakeRecords/ReportingObserverTakeRecords.generated.xml' path='docs/ReportingObserverTakeRecords/*'/>
	public ReportList TakeRecords() { throw new System.NotImplementedException(); }
	public ReportingObserver() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct ReportingObserverCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ReportingObserverOptions
{
		public List<string> Types;
		public bool Buffered;
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GenerateTestReportParameters
{
		public required string Message;
		public string Group;
}

public enum ResizeObserverBoxOptions
{
	BorderBox,
	ContentBox,
	DevicePixelContentBox,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ResizeObserverOptions
{
		public ResizeObserverBoxOptions Box;
}

///<include file='Utils/Docs/ResizeObserver/ResizeObserver.generated.xml' path='docs/ResizeObserver/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ResizeObserver
{
	///<include file='Utils/Docs/ResizeObserverResizeObserver/ResizeObserverResizeObserver.generated.xml' path='docs/ResizeObserverResizeObserver/*'/>
	public ResizeObserver(ResizeObserverCallback callback) { }
	///<include file='Utils/Docs/ResizeObserverObserve/ResizeObserverObserve.generated.xml' path='docs/ResizeObserverObserve/*'/>
	public Undefined Observe(Element target, ResizeObserverOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ResizeObserverUnobserve/ResizeObserverUnobserve.generated.xml' path='docs/ResizeObserverUnobserve/*'/>
	public Undefined Unobserve(Element target) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ResizeObserverDisconnect/ResizeObserverDisconnect.generated.xml' path='docs/ResizeObserverDisconnect/*'/>
	public Undefined Disconnect() { throw new System.NotImplementedException(); }
	public ResizeObserver() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct ResizeObserverCallback
{
}

///<include file='Utils/Docs/ResizeObserverEntry/ResizeObserverEntry.generated.xml' path='docs/ResizeObserverEntry/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ResizeObserverEntry
{
	///<include file='Utils/Docs/ResizeObserverEntryTarget/ResizeObserverEntryTarget.generated.xml' path='docs/ResizeObserverEntryTarget/*'/>
	public Element Target { get; }
	///<include file='Utils/Docs/ResizeObserverEntryContentRect/ResizeObserverEntryContentRect.generated.xml' path='docs/ResizeObserverEntryContentRect/*'/>
	public DOMRectReadOnly ContentRect { get; }
	///<include file='Utils/Docs/ResizeObserverEntryBorderBoxSize/ResizeObserverEntryBorderBoxSize.generated.xml' path='docs/ResizeObserverEntryBorderBoxSize/*'/>
	public List<ResizeObserverSize> BorderBoxSize { get; }
	///<include file='Utils/Docs/ResizeObserverEntryContentBoxSize/ResizeObserverEntryContentBoxSize.generated.xml' path='docs/ResizeObserverEntryContentBoxSize/*'/>
	public List<ResizeObserverSize> ContentBoxSize { get; }
	///<include file='Utils/Docs/ResizeObserverEntryDevicePixelContentBoxSize/ResizeObserverEntryDevicePixelContentBoxSize.generated.xml' path='docs/ResizeObserverEntryDevicePixelContentBoxSize/*'/>
	public List<ResizeObserverSize> DevicePixelContentBoxSize { get; }
}

///<include file='Utils/Docs/ResizeObserverSize/ResizeObserverSize.generated.xml' path='docs/ResizeObserverSize/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ResizeObserverSize
{
	///<include file='Utils/Docs/ResizeObserverSizeInlineSize/ResizeObserverSizeInlineSize.generated.xml' path='docs/ResizeObserverSizeInlineSize/*'/>
	public double InlineSize { get; }
	///<include file='Utils/Docs/ResizeObserverSizeBlockSize/ResizeObserverSizeBlockSize.generated.xml' path='docs/ResizeObserverSizeBlockSize/*'/>
	public double BlockSize { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ResizeObservation
{
		public ResizeObservation(Element target) { }
		public Element Target { get; }
		public ResizeObserverBoxOptions ObservedBox { get; }
		public List<ResizeObserverSize> LastReportedSizes { get; }
	public ResizeObservation() { }
}

public enum ScrollAxis
{
	Block,
	Inline,
	X,
	Y,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ScrollTimelineOptions
{
		public Element? Source;
		public ScrollAxis Axis;
}

///<include file='Utils/Docs/ScrollTimeline/ScrollTimeline.generated.xml' path='docs/ScrollTimeline/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ScrollTimeline : AnimationTimeline
{
	///<include file='Utils/Docs/ScrollTimelineScrollTimeline/ScrollTimelineScrollTimeline.generated.xml' path='docs/ScrollTimelineScrollTimeline/*'/>
	public ScrollTimeline(ScrollTimelineOptions options) { }
	///<include file='Utils/Docs/ScrollTimelineSource/ScrollTimelineSource.generated.xml' path='docs/ScrollTimelineSource/*'/>
	public Element? Source { get; }
	///<include file='Utils/Docs/ScrollTimelineAxis/ScrollTimelineAxis.generated.xml' path='docs/ScrollTimelineAxis/*'/>
	public ScrollAxis Axis { get; }
	public ScrollTimeline() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ViewTimelineOptions
{
		public Element Subject;
		public ScrollAxis Axis;
		public Union86 Inset;
}

///<include file='Utils/Docs/ViewTimeline/ViewTimeline.generated.xml' path='docs/ViewTimeline/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ViewTimeline : ScrollTimeline
{
	///<include file='Utils/Docs/ViewTimelineViewTimeline/ViewTimelineViewTimeline.generated.xml' path='docs/ViewTimelineViewTimeline/*'/>
	public ViewTimeline(ViewTimelineOptions options) { }
	///<include file='Utils/Docs/ViewTimelineSubject/ViewTimelineSubject.generated.xml' path='docs/ViewTimelineSubject/*'/>
	public Element Subject { get; }
	///<include file='Utils/Docs/ViewTimelineStartOffset/ViewTimelineStartOffset.generated.xml' path='docs/ViewTimelineStartOffset/*'/>
	public Unsupported /*CSSNumericValue*/ StartOffset { get; }
	///<include file='Utils/Docs/ViewTimelineEndOffset/ViewTimelineEndOffset.generated.xml' path='docs/ViewTimelineEndOffset/*'/>
	public Unsupported /*CSSNumericValue*/ EndOffset { get; }
	public ViewTimeline() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AnimationTimeOptions
{
		public string? Range;
}

///<include file='Utils/Docs/AnimationTimeline/AnimationTimeline.generated.xml' path='docs/AnimationTimeline/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AnimationTimeline
{
		public Unsupported /*CSSNumericValue*/? GetCurrentTime(AnimationTimeOptions options) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class SecurePaymentConfirmationRequest
{
		public required BufferSource Challenge;
		public required string RpId;
		public required List<BufferSource> CredentialIds;
		public required PaymentCredentialInstrument Instrument;
		public ulong Timeout;
		public string PayeeName;
		public string PayeeOrigin;
		public AuthenticationExtensionsClientInputs Extensions;
		public List<string> Locale;
		public bool ShowOptOut;
}

///<include file='Utils/Docs/PaymentRequest/PaymentRequest.generated.xml' path='docs/PaymentRequest/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PaymentRequest
{
		public static Task<bool> IsSecurePaymentConfirmationAvailable() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AuthenticationExtensionsClientInputs
{
		public AuthenticationExtensionsPaymentInputs Payment;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AuthenticationExtensionsPaymentInputs
{
		public bool IsPayment;
		public string RpId;
		public string TopOrigin;
		public string PayeeName;
		public string PayeeOrigin;
		public Unsupported /*PaymentCurrencyAmount*/ Total;
		public PaymentCredentialInstrument Instrument;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CollectedClientPaymentData : CollectedClientData
{
		public required CollectedClientAdditionalPaymentData Payment;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CollectedClientAdditionalPaymentData
{
		public required string RpId;
		public required string TopOrigin;
		public string PayeeName;
		public string PayeeOrigin;
		public required Unsupported /*PaymentCurrencyAmount*/ Total;
		public required PaymentCredentialInstrument Instrument;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PaymentCredentialInstrument
{
		public required string DisplayName;
		public required string Icon;
		public bool IconMustBeShown;
}

///<include file='Utils/Docs/ServiceWorker/ServiceWorker.generated.xml' path='docs/ServiceWorker/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ServiceWorker : EventTarget, AbstractWorker
{
	///<include file='Utils/Docs/ServiceWorkerScriptURL/ServiceWorkerScriptURL.generated.xml' path='docs/ServiceWorkerScriptURL/*'/>
	public string ScriptURL { get; }
	///<include file='Utils/Docs/ServiceWorkerState/ServiceWorkerState.generated.xml' path='docs/ServiceWorkerState/*'/>
	public ServiceWorkerState State { get; }
	///<include file='Utils/Docs/ServiceWorkerPostMessage/ServiceWorkerPostMessage.generated.xml' path='docs/ServiceWorkerPostMessage/*'/>
	public Undefined PostMessage(dynamic message, List<object> transfer) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ServiceWorkerPostMessage/ServiceWorkerPostMessage.generated.xml' path='docs/ServiceWorkerPostMessage/*'/>
	public Undefined PostMessage(dynamic message, StructuredSerializeOptions options) { throw new System.NotImplementedException(); }
		public EventHandler Onstatechange { get; set; }
}


///<include file='Utils/Docs/ServiceWorkerState/ServiceWorkerState.generated.xml' path='docs/ServiceWorkerState/*'/>
public enum ServiceWorkerState
{
	Parsed,
	Installing,
	Installed,
	Activating,
	Activated,
	Redundant,
}

///<include file='Utils/Docs/ServiceWorkerRegistration/ServiceWorkerRegistration.generated.xml' path='docs/ServiceWorkerRegistration/*'/>
public partial class ServiceWorkerRegistration : EventTarget
{
	///<include file='Utils/Docs/ServiceWorkerRegistrationInstalling/ServiceWorkerRegistrationInstalling.generated.xml' path='docs/ServiceWorkerRegistrationInstalling/*'/>
	public ServiceWorker? Installing { get; }
	///<include file='Utils/Docs/ServiceWorkerRegistrationWaiting/ServiceWorkerRegistrationWaiting.generated.xml' path='docs/ServiceWorkerRegistrationWaiting/*'/>
	public ServiceWorker? Waiting { get; }
	///<include file='Utils/Docs/ServiceWorkerRegistrationActive/ServiceWorkerRegistrationActive.generated.xml' path='docs/ServiceWorkerRegistrationActive/*'/>
	public ServiceWorker? Active { get; }
	///<include file='Utils/Docs/ServiceWorkerRegistrationNavigationPreload/ServiceWorkerRegistrationNavigationPreload.generated.xml' path='docs/ServiceWorkerRegistrationNavigationPreload/*'/>
	public NavigationPreloadManager NavigationPreload { get; }
	///<include file='Utils/Docs/ServiceWorkerRegistrationScope/ServiceWorkerRegistrationScope.generated.xml' path='docs/ServiceWorkerRegistrationScope/*'/>
	public string Scope { get; }
	///<include file='Utils/Docs/ServiceWorkerRegistrationUpdateViaCache/ServiceWorkerRegistrationUpdateViaCache.generated.xml' path='docs/ServiceWorkerRegistrationUpdateViaCache/*'/>
	public ServiceWorkerUpdateViaCache UpdateViaCache { get; }
	///<include file='Utils/Docs/ServiceWorkerRegistrationUpdate/ServiceWorkerRegistrationUpdate.generated.xml' path='docs/ServiceWorkerRegistrationUpdate/*'/>
	public Task<Undefined> Update() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ServiceWorkerRegistrationUnregister/ServiceWorkerRegistrationUnregister.generated.xml' path='docs/ServiceWorkerRegistrationUnregister/*'/>
	public Task<bool> Unregister() { throw new System.NotImplementedException(); }
		public EventHandler Onupdatefound { get; set; }
}

public enum ServiceWorkerUpdateViaCache
{
	Imports,
	All,
	None,
}

///<include file='Utils/Docs/Navigator/Navigator.generated.xml' path='docs/Navigator/*'/>
public partial class Navigator
{
	///<include file='Utils/Docs/NavigatorServiceWorker/NavigatorServiceWorker.generated.xml' path='docs/NavigatorServiceWorker/*'/>
	public ServiceWorkerContainer ServiceWorker { get; }
}

///<include file='Utils/Docs/WorkerNavigator/WorkerNavigator.generated.xml' path='docs/WorkerNavigator/*'/>
public partial class WorkerNavigator
{
		public ServiceWorkerContainer ServiceWorker { get; }
}

///<include file='Utils/Docs/ServiceWorkerContainer/ServiceWorkerContainer.generated.xml' path='docs/ServiceWorkerContainer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ServiceWorkerContainer : EventTarget
{
	///<include file='Utils/Docs/ServiceWorkerContainerController/ServiceWorkerContainerController.generated.xml' path='docs/ServiceWorkerContainerController/*'/>
	public ServiceWorker? Controller { get; }
	///<include file='Utils/Docs/ServiceWorkerContainerReady/ServiceWorkerContainerReady.generated.xml' path='docs/ServiceWorkerContainerReady/*'/>
	public Task<ServiceWorkerRegistration> Ready { get; }
	///<include file='Utils/Docs/ServiceWorkerContainerRegister/ServiceWorkerContainerRegister.generated.xml' path='docs/ServiceWorkerContainerRegister/*'/>
	public Task<ServiceWorkerRegistration> Register(string scriptURL, RegistrationOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ServiceWorkerContainerGetRegistration/ServiceWorkerContainerGetRegistration.generated.xml' path='docs/ServiceWorkerContainerGetRegistration/*'/>
	public Task<ServiceWorkerRegistration> GetRegistration(string clientURL) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ServiceWorkerContainerGetRegistrations/ServiceWorkerContainerGetRegistrations.generated.xml' path='docs/ServiceWorkerContainerGetRegistrations/*'/>
	public Task<ServiceWorkerRegistration[]> GetRegistrations() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ServiceWorkerContainerStartMessages/ServiceWorkerContainerStartMessages.generated.xml' path='docs/ServiceWorkerContainerStartMessages/*'/>
	public Undefined StartMessages() { throw new System.NotImplementedException(); }
		public EventHandler Oncontrollerchange { get; set; }
		public EventHandler Onmessage { get; set; }
		public EventHandler Onmessageerror { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class RegistrationOptions
{
		public string Scope;
		public WorkerType Type;
		public ServiceWorkerUpdateViaCache UpdateViaCache;
}

///<include file='Utils/Docs/NavigationPreloadManager/NavigationPreloadManager.generated.xml' path='docs/NavigationPreloadManager/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class NavigationPreloadManager
{
	///<include file='Utils/Docs/NavigationPreloadManagerEnable/NavigationPreloadManagerEnable.generated.xml' path='docs/NavigationPreloadManagerEnable/*'/>
	public Task<Undefined> Enable() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NavigationPreloadManagerDisable/NavigationPreloadManagerDisable.generated.xml' path='docs/NavigationPreloadManagerDisable/*'/>
	public Task<Undefined> Disable() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NavigationPreloadManagerSetHeaderValue/NavigationPreloadManagerSetHeaderValue.generated.xml' path='docs/NavigationPreloadManagerSetHeaderValue/*'/>
	public Task<Undefined> SetHeaderValue(string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NavigationPreloadManagerGetState/NavigationPreloadManagerGetState.generated.xml' path='docs/NavigationPreloadManagerGetState/*'/>
	public Task<NavigationPreloadState> GetState() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NavigationPreloadState
{
		public bool Enabled;
		public string HeaderValue;
}

///<include file='Utils/Docs/ServiceWorkerGlobalScope/ServiceWorkerGlobalScope.generated.xml' path='docs/ServiceWorkerGlobalScope/*'/>
public partial class ServiceWorkerGlobalScope : WorkerGlobalScope
{
	///<include file='Utils/Docs/ServiceWorkerGlobalScopeClients/ServiceWorkerGlobalScopeClients.generated.xml' path='docs/ServiceWorkerGlobalScopeClients/*'/>
	public Clients Clients { get; }
	///<include file='Utils/Docs/ServiceWorkerGlobalScopeRegistration/ServiceWorkerGlobalScopeRegistration.generated.xml' path='docs/ServiceWorkerGlobalScopeRegistration/*'/>
	public ServiceWorkerRegistration Registration { get; }
		public ServiceWorker ServiceWorker { get; }
	///<include file='Utils/Docs/ServiceWorkerGlobalScopeSkipWaiting/ServiceWorkerGlobalScopeSkipWaiting.generated.xml' path='docs/ServiceWorkerGlobalScopeSkipWaiting/*'/>
	public Task<Undefined> SkipWaiting() { throw new System.NotImplementedException(); }
		public EventHandler Oninstall { get; set; }
		public EventHandler Onactivate { get; set; }
		public EventHandler Onfetch { get; set; }
		public EventHandler Onmessage { get; set; }
		public EventHandler Onmessageerror { get; set; }
}

///<include file='Utils/Docs/Client/Client.generated.xml' path='docs/Client/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Client
{
	///<include file='Utils/Docs/ClientUrl/ClientUrl.generated.xml' path='docs/ClientUrl/*'/>
	public string Url { get; }
	///<include file='Utils/Docs/ClientFrameType/ClientFrameType.generated.xml' path='docs/ClientFrameType/*'/>
	public FrameType FrameType { get; }
	///<include file='Utils/Docs/ClientId/ClientId.generated.xml' path='docs/ClientId/*'/>
	public string Id { get; }
	///<include file='Utils/Docs/ClientType/ClientType.generated.xml' path='docs/ClientType/*'/>
	public ClientType Type { get; }
	///<include file='Utils/Docs/ClientPostMessage/ClientPostMessage.generated.xml' path='docs/ClientPostMessage/*'/>
	public Undefined PostMessage(dynamic message, List<object> transfer) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ClientPostMessage/ClientPostMessage.generated.xml' path='docs/ClientPostMessage/*'/>
	public Undefined PostMessage(dynamic message, StructuredSerializeOptions options) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/WindowClient/WindowClient.generated.xml' path='docs/WindowClient/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WindowClient : Client
{
	///<include file='Utils/Docs/WindowClientVisibilityState/WindowClientVisibilityState.generated.xml' path='docs/WindowClientVisibilityState/*'/>
	public Unsupported /*VisibilityState*/ VisibilityState { get; }
	///<include file='Utils/Docs/WindowClientFocused/WindowClientFocused.generated.xml' path='docs/WindowClientFocused/*'/>
	public bool Focused { get; }
		public string[] AncestorOrigins { get; }
	///<include file='Utils/Docs/WindowClientFocus/WindowClientFocus.generated.xml' path='docs/WindowClientFocus/*'/>
	public Task<WindowClient> Focus() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowClientNavigate/WindowClientNavigate.generated.xml' path='docs/WindowClientNavigate/*'/>
	public Task<WindowClient?> Navigate(string url) { throw new System.NotImplementedException(); }
}

public enum FrameType
{
	Auxiliary,
	TopLevel,
	Nested,
	None,
}

///<include file='Utils/Docs/Clients/Clients.generated.xml' path='docs/Clients/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Clients
{
	///<include file='Utils/Docs/ClientsGet/ClientsGet.generated.xml' path='docs/ClientsGet/*'/>
	public Task<Client> Get(string id) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ClientsMatchAll/ClientsMatchAll.generated.xml' path='docs/ClientsMatchAll/*'/>
	public Task<Client[]> MatchAll(ClientQueryOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ClientsOpenWindow/ClientsOpenWindow.generated.xml' path='docs/ClientsOpenWindow/*'/>
	public Task<WindowClient?> OpenWindow(string url) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ClientsClaim/ClientsClaim.generated.xml' path='docs/ClientsClaim/*'/>
	public Task<Undefined> Claim() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ClientQueryOptions
{
		public bool IncludeUncontrolled;
		public ClientType Type;
}

///<include file='Utils/Docs/ClientType/ClientType.generated.xml' path='docs/ClientType/*'/>
public enum ClientType
{
	Window,
	Worker,
	Sharedworker,
	All,
}

///<include file='Utils/Docs/ExtendableEvent/ExtendableEvent.generated.xml' path='docs/ExtendableEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ExtendableEvent : Event
{
	///<include file='Utils/Docs/ExtendableEventExtendableEvent/ExtendableEventExtendableEvent.generated.xml' path='docs/ExtendableEventExtendableEvent/*'/>
	public ExtendableEvent(string type, ExtendableEventInit eventInitDict) { }
	///<include file='Utils/Docs/ExtendableEventWaitUntil/ExtendableEventWaitUntil.generated.xml' path='docs/ExtendableEventWaitUntil/*'/>
	public Undefined WaitUntil(Task<dynamic> f) { throw new System.NotImplementedException(); }
	public ExtendableEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ExtendableEventInit : EventInit
{
}

///<include file='Utils/Docs/FetchEvent/FetchEvent.generated.xml' path='docs/FetchEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FetchEvent : ExtendableEvent
{
	///<include file='Utils/Docs/FetchEventFetchEvent/FetchEventFetchEvent.generated.xml' path='docs/FetchEventFetchEvent/*'/>
	public FetchEvent(string type, FetchEventInit eventInitDict) { }
	///<include file='Utils/Docs/FetchEventRequest/FetchEventRequest.generated.xml' path='docs/FetchEventRequest/*'/>
	public Request Request { get; }
	///<include file='Utils/Docs/FetchEventPreloadResponse/FetchEventPreloadResponse.generated.xml' path='docs/FetchEventPreloadResponse/*'/>
	public Task<dynamic> PreloadResponse { get; }
	///<include file='Utils/Docs/FetchEventClientId/FetchEventClientId.generated.xml' path='docs/FetchEventClientId/*'/>
	public string ClientId { get; }
	///<include file='Utils/Docs/FetchEventResultingClientId/FetchEventResultingClientId.generated.xml' path='docs/FetchEventResultingClientId/*'/>
	public string ResultingClientId { get; }
	///<include file='Utils/Docs/FetchEventReplacesClientId/FetchEventReplacesClientId.generated.xml' path='docs/FetchEventReplacesClientId/*'/>
	public string ReplacesClientId { get; }
	///<include file='Utils/Docs/FetchEventHandled/FetchEventHandled.generated.xml' path='docs/FetchEventHandled/*'/>
	public Task<Undefined> Handled { get; }
	///<include file='Utils/Docs/FetchEventRespondWith/FetchEventRespondWith.generated.xml' path='docs/FetchEventRespondWith/*'/>
	public Undefined RespondWith(Task<Response> r) { throw new System.NotImplementedException(); }
	public FetchEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FetchEventInit : ExtendableEventInit
{
		public required Request Request;
		public Task<dynamic> PreloadResponse;
		public string ClientId;
		public string ResultingClientId;
		public string ReplacesClientId;
		public Task<Undefined> Handled;
}

///<include file='Utils/Docs/ExtendableMessageEvent/ExtendableMessageEvent.generated.xml' path='docs/ExtendableMessageEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ExtendableMessageEvent : ExtendableEvent
{
	///<include file='Utils/Docs/ExtendableMessageEventExtendableMessageEvent/ExtendableMessageEventExtendableMessageEvent.generated.xml' path='docs/ExtendableMessageEventExtendableMessageEvent/*'/>
	public ExtendableMessageEvent(string type, ExtendableMessageEventInit eventInitDict) { }
	///<include file='Utils/Docs/ExtendableMessageEventData/ExtendableMessageEventData.generated.xml' path='docs/ExtendableMessageEventData/*'/>
	public dynamic Data { get; }
	///<include file='Utils/Docs/ExtendableMessageEventOrigin/ExtendableMessageEventOrigin.generated.xml' path='docs/ExtendableMessageEventOrigin/*'/>
	public string Origin { get; }
	///<include file='Utils/Docs/ExtendableMessageEventLastEventId/ExtendableMessageEventLastEventId.generated.xml' path='docs/ExtendableMessageEventLastEventId/*'/>
	public string LastEventId { get; }
	///<include file='Utils/Docs/ExtendableMessageEventSource/ExtendableMessageEventSource.generated.xml' path='docs/ExtendableMessageEventSource/*'/>
	public Union88? Source { get; }
	///<include file='Utils/Docs/ExtendableMessageEventPorts/ExtendableMessageEventPorts.generated.xml' path='docs/ExtendableMessageEventPorts/*'/>
	public MessagePort[] Ports { get; }
	public ExtendableMessageEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ExtendableMessageEventInit : ExtendableEventInit
{
		public dynamic Data;
		public string Origin;
		public string LastEventId;
		public Union89? Source;
		public List<MessagePort> Ports;
}

public partial interface WindowOrWorkerGlobalScope
{
		public CacheStorage Caches { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/Cache/Cache.generated.xml' path='docs/Cache/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Cache
{
	///<include file='Utils/Docs/CacheMatch/CacheMatch.generated.xml' path='docs/CacheMatch/*'/>
	public Task<Response> Match(RequestInfo request, CacheQueryOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CacheMatchAll/CacheMatchAll.generated.xml' path='docs/CacheMatchAll/*'/>
	public Task<Response[]> MatchAll(RequestInfo request, CacheQueryOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CacheAdd/CacheAdd.generated.xml' path='docs/CacheAdd/*'/>
	public Task<Undefined> Add(RequestInfo request) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CacheAddAll/CacheAddAll.generated.xml' path='docs/CacheAddAll/*'/>
	public Task<Undefined> AddAll(List<RequestInfo> requests) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CachePut/CachePut.generated.xml' path='docs/CachePut/*'/>
	public Task<Undefined> Put(RequestInfo request, Response response) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CacheDelete/CacheDelete.generated.xml' path='docs/CacheDelete/*'/>
	public Task<bool> Delete(RequestInfo request, CacheQueryOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CacheKeys/CacheKeys.generated.xml' path='docs/CacheKeys/*'/>
	public Task<Request[]> Keys(RequestInfo request, CacheQueryOptions options) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CacheQueryOptions
{
		public bool IgnoreSearch;
		public bool IgnoreMethod;
		public bool IgnoreVary;
}

///<include file='Utils/Docs/CacheStorage/CacheStorage.generated.xml' path='docs/CacheStorage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CacheStorage
{
	///<include file='Utils/Docs/CacheStorageMatch/CacheStorageMatch.generated.xml' path='docs/CacheStorageMatch/*'/>
	public Task<Response> Match(RequestInfo request, MultiCacheQueryOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CacheStorageHas/CacheStorageHas.generated.xml' path='docs/CacheStorageHas/*'/>
	public Task<bool> Has(string cacheName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CacheStorageOpen/CacheStorageOpen.generated.xml' path='docs/CacheStorageOpen/*'/>
	public Task<Cache> Open(string cacheName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CacheStorageDelete/CacheStorageDelete.generated.xml' path='docs/CacheStorageDelete/*'/>
	public Task<bool> Delete(string cacheName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CacheStorageKeys/CacheStorageKeys.generated.xml' path='docs/CacheStorageKeys/*'/>
	public Task<List<string>> Keys() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MultiCacheQueryOptions : CacheQueryOptions
{
		public string CacheName;
}

///<include file='Utils/Docs/Touch/Touch.generated.xml' path='docs/Touch/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Touch
{
	///<include file='Utils/Docs/TouchIdentifier/TouchIdentifier.generated.xml' path='docs/TouchIdentifier/*'/>
	public long Identifier { get; }
	///<include file='Utils/Docs/TouchTarget/TouchTarget.generated.xml' path='docs/TouchTarget/*'/>
	public EventTarget Target { get; }
	///<include file='Utils/Docs/TouchScreenX/TouchScreenX.generated.xml' path='docs/TouchScreenX/*'/>
	public long ScreenX { get; }
	///<include file='Utils/Docs/TouchScreenY/TouchScreenY.generated.xml' path='docs/TouchScreenY/*'/>
	public long ScreenY { get; }
	///<include file='Utils/Docs/TouchClientX/TouchClientX.generated.xml' path='docs/TouchClientX/*'/>
	public long ClientX { get; }
	///<include file='Utils/Docs/TouchClientY/TouchClientY.generated.xml' path='docs/TouchClientY/*'/>
	public long ClientY { get; }
	///<include file='Utils/Docs/TouchPageX/TouchPageX.generated.xml' path='docs/TouchPageX/*'/>
	public long PageX { get; }
	///<include file='Utils/Docs/TouchPageY/TouchPageY.generated.xml' path='docs/TouchPageY/*'/>
	public long PageY { get; }
}

///<include file='Utils/Docs/TouchList/TouchList.generated.xml' path='docs/TouchList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class TouchList
{
	///<include file='Utils/Docs/TouchListLength/TouchListLength.generated.xml' path='docs/TouchListLength/*'/>
	public ulong Length { get; }
	
}

///<include file='Utils/Docs/TouchEvent/TouchEvent.generated.xml' path='docs/TouchEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class TouchEvent : UIEvent
{
	///<include file='Utils/Docs/TouchEventTouches/TouchEventTouches.generated.xml' path='docs/TouchEventTouches/*'/>
	public TouchList Touches { get; }
	///<include file='Utils/Docs/TouchEventTargetTouches/TouchEventTargetTouches.generated.xml' path='docs/TouchEventTargetTouches/*'/>
	public TouchList TargetTouches { get; }
	///<include file='Utils/Docs/TouchEventChangedTouches/TouchEventChangedTouches.generated.xml' path='docs/TouchEventChangedTouches/*'/>
	public TouchList ChangedTouches { get; }
	///<include file='Utils/Docs/TouchEventAltKey/TouchEventAltKey.generated.xml' path='docs/TouchEventAltKey/*'/>
	public bool AltKey { get; }
	///<include file='Utils/Docs/TouchEventMetaKey/TouchEventMetaKey.generated.xml' path='docs/TouchEventMetaKey/*'/>
	public bool MetaKey { get; }
	///<include file='Utils/Docs/TouchEventCtrlKey/TouchEventCtrlKey.generated.xml' path='docs/TouchEventCtrlKey/*'/>
	public bool CtrlKey { get; }
	///<include file='Utils/Docs/TouchEventShiftKey/TouchEventShiftKey.generated.xml' path='docs/TouchEventShiftKey/*'/>
	public bool ShiftKey { get; }
}

///<include file='Utils/Docs/Document/Document.generated.xml' path='docs/Document/*'/>
public partial class Document
{
	///<include file='Utils/Docs/DocumentCreateTouch/DocumentCreateTouch.generated.xml' path='docs/DocumentCreateTouch/*'/>
	public Touch CreateTouch(WindowProxy view, EventTarget target, long identifier, long pageX, long pageY, long screenX, long screenY) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentCreateTouchList/DocumentCreateTouchList.generated.xml' path='docs/DocumentCreateTouchList/*'/>
	public TouchList CreateTouchList(params Touch[] touches) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/UIEvent/UIEvent.generated.xml' path='docs/UIEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class UIEvent : Event
{
	///<include file='Utils/Docs/UIEventUIEvent/UIEventUIEvent.generated.xml' path='docs/UIEventUIEvent/*'/>
	public UIEvent(string type, UIEventInit eventInitDict) { }
	///<include file='Utils/Docs/UIEventView/UIEventView.generated.xml' path='docs/UIEventView/*'/>
	public Window? View { get; }
	///<include file='Utils/Docs/UIEventDetail/UIEventDetail.generated.xml' path='docs/UIEventDetail/*'/>
	public long Detail { get; }
	public UIEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class UIEventInit : EventInit
{
		public Window? View;
		public long Detail;
}

///<include file='Utils/Docs/FocusEvent/FocusEvent.generated.xml' path='docs/FocusEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FocusEvent : UIEvent
{
	///<include file='Utils/Docs/FocusEventFocusEvent/FocusEventFocusEvent.generated.xml' path='docs/FocusEventFocusEvent/*'/>
	public FocusEvent(string type, FocusEventInit eventInitDict) { }
	///<include file='Utils/Docs/FocusEventRelatedTarget/FocusEventRelatedTarget.generated.xml' path='docs/FocusEventRelatedTarget/*'/>
	public EventTarget? RelatedTarget { get; }
	public FocusEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FocusEventInit : UIEventInit
{
		public EventTarget? RelatedTarget;
}

///<include file='Utils/Docs/MouseEvent/MouseEvent.generated.xml' path='docs/MouseEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MouseEvent : UIEvent
{
	///<include file='Utils/Docs/MouseEventMouseEvent/MouseEventMouseEvent.generated.xml' path='docs/MouseEventMouseEvent/*'/>
	public MouseEvent(string type, MouseEventInit eventInitDict) { }
	///<include file='Utils/Docs/MouseEventScreenX/MouseEventScreenX.generated.xml' path='docs/MouseEventScreenX/*'/>
	public long ScreenX { get; }
	///<include file='Utils/Docs/MouseEventScreenY/MouseEventScreenY.generated.xml' path='docs/MouseEventScreenY/*'/>
	public long ScreenY { get; }
	///<include file='Utils/Docs/MouseEventClientX/MouseEventClientX.generated.xml' path='docs/MouseEventClientX/*'/>
	public long ClientX { get; }
	///<include file='Utils/Docs/MouseEventClientY/MouseEventClientY.generated.xml' path='docs/MouseEventClientY/*'/>
	public long ClientY { get; }
	///<include file='Utils/Docs/MouseEventLayerX/MouseEventLayerX.generated.xml' path='docs/MouseEventLayerX/*'/>
	public long LayerX { get; }
	///<include file='Utils/Docs/MouseEventLayerY/MouseEventLayerY.generated.xml' path='docs/MouseEventLayerY/*'/>
	public long LayerY { get; }
	///<include file='Utils/Docs/MouseEventCtrlKey/MouseEventCtrlKey.generated.xml' path='docs/MouseEventCtrlKey/*'/>
	public bool CtrlKey { get; }
	///<include file='Utils/Docs/MouseEventShiftKey/MouseEventShiftKey.generated.xml' path='docs/MouseEventShiftKey/*'/>
	public bool ShiftKey { get; }
	///<include file='Utils/Docs/MouseEventAltKey/MouseEventAltKey.generated.xml' path='docs/MouseEventAltKey/*'/>
	public bool AltKey { get; }
	///<include file='Utils/Docs/MouseEventMetaKey/MouseEventMetaKey.generated.xml' path='docs/MouseEventMetaKey/*'/>
	public bool MetaKey { get; }
	///<include file='Utils/Docs/MouseEventButton/MouseEventButton.generated.xml' path='docs/MouseEventButton/*'/>
	public Number Button { get; }
	///<include file='Utils/Docs/MouseEventButtons/MouseEventButtons.generated.xml' path='docs/MouseEventButtons/*'/>
	public ushort Buttons { get; }
	///<include file='Utils/Docs/MouseEventRelatedTarget/MouseEventRelatedTarget.generated.xml' path='docs/MouseEventRelatedTarget/*'/>
	public EventTarget? RelatedTarget { get; }
	///<include file='Utils/Docs/MouseEventGetModifierState/MouseEventGetModifierState.generated.xml' path='docs/MouseEventGetModifierState/*'/>
	public bool GetModifierState(string keyArg) { throw new System.NotImplementedException(); }
	public MouseEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MouseEventInit : EventModifierInit
{
		public long ScreenX;
		public long ScreenY;
		public long ClientX;
		public long ClientY;
		public Number Button;
		public ushort Buttons;
		public EventTarget? RelatedTarget;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class EventModifierInit : UIEventInit
{
		public bool CtrlKey;
		public bool ShiftKey;
		public bool AltKey;
		public bool MetaKey;
		public bool ModifierAltGraph;
		public bool ModifierCapsLock;
		public bool ModifierFn;
		public bool ModifierFnLock;
		public bool ModifierHyper;
		public bool ModifierNumLock;
		public bool ModifierScrollLock;
		public bool ModifierSuper;
		public bool ModifierSymbol;
		public bool ModifierSymbolLock;
}

///<include file='Utils/Docs/WheelEvent/WheelEvent.generated.xml' path='docs/WheelEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WheelEvent : MouseEvent
{
	///<include file='Utils/Docs/WheelEventWheelEvent/WheelEventWheelEvent.generated.xml' path='docs/WheelEventWheelEvent/*'/>
	public WheelEvent(string type, WheelEventInit eventInitDict) { }
		public const ulong DOM_DELTA_PIXEL = 0x00;
		public const ulong DOM_DELTA_LINE = 0x01;
		public const ulong DOM_DELTA_PAGE = 0x02;
	///<include file='Utils/Docs/WheelEventDeltaX/WheelEventDeltaX.generated.xml' path='docs/WheelEventDeltaX/*'/>
	public Number DeltaX { get; }
	///<include file='Utils/Docs/WheelEventDeltaY/WheelEventDeltaY.generated.xml' path='docs/WheelEventDeltaY/*'/>
	public Number DeltaY { get; }
	///<include file='Utils/Docs/WheelEventDeltaZ/WheelEventDeltaZ.generated.xml' path='docs/WheelEventDeltaZ/*'/>
	public Number DeltaZ { get; }
	///<include file='Utils/Docs/WheelEventDeltaMode/WheelEventDeltaMode.generated.xml' path='docs/WheelEventDeltaMode/*'/>
	public ulong DeltaMode { get; }
	public WheelEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WheelEventInit : MouseEventInit
{
		public Number DeltaX;
		public Number DeltaY;
		public Number DeltaZ;
		public ulong DeltaMode;
}

///<include file='Utils/Docs/InputEvent/InputEvent.generated.xml' path='docs/InputEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class InputEvent : UIEvent
{
	///<include file='Utils/Docs/InputEventInputEvent/InputEventInputEvent.generated.xml' path='docs/InputEventInputEvent/*'/>
	public InputEvent(string type, InputEventInit eventInitDict) { }
	///<include file='Utils/Docs/InputEventData/InputEventData.generated.xml' path='docs/InputEventData/*'/>
	public string? Data { get; }
	///<include file='Utils/Docs/InputEventIsComposing/InputEventIsComposing.generated.xml' path='docs/InputEventIsComposing/*'/>
	public bool IsComposing { get; }
	///<include file='Utils/Docs/InputEventInputType/InputEventInputType.generated.xml' path='docs/InputEventInputType/*'/>
	public string InputType { get; }
	public InputEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class InputEventInit : UIEventInit
{
		public string? Data;
		public bool IsComposing;
		public string InputType;
}

///<include file='Utils/Docs/KeyboardEvent/KeyboardEvent.generated.xml' path='docs/KeyboardEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class KeyboardEvent : UIEvent
{
	///<include file='Utils/Docs/KeyboardEventKeyboardEvent/KeyboardEventKeyboardEvent.generated.xml' path='docs/KeyboardEventKeyboardEvent/*'/>
	public KeyboardEvent(string type, KeyboardEventInit eventInitDict) { }
		public const ulong DOM_KEY_LOCATION_STANDARD = 0x00;
		public const ulong DOM_KEY_LOCATION_LEFT = 0x01;
		public const ulong DOM_KEY_LOCATION_RIGHT = 0x02;
		public const ulong DOM_KEY_LOCATION_NUMPAD = 0x03;
	///<include file='Utils/Docs/KeyboardEventKey/KeyboardEventKey.generated.xml' path='docs/KeyboardEventKey/*'/>
	public string Key { get; }
	///<include file='Utils/Docs/KeyboardEventCode/KeyboardEventCode.generated.xml' path='docs/KeyboardEventCode/*'/>
	public string Code { get; }
	///<include file='Utils/Docs/KeyboardEventLocation/KeyboardEventLocation.generated.xml' path='docs/KeyboardEventLocation/*'/>
	public ulong Location { get; }
	///<include file='Utils/Docs/KeyboardEventCtrlKey/KeyboardEventCtrlKey.generated.xml' path='docs/KeyboardEventCtrlKey/*'/>
	public bool CtrlKey { get; }
	///<include file='Utils/Docs/KeyboardEventShiftKey/KeyboardEventShiftKey.generated.xml' path='docs/KeyboardEventShiftKey/*'/>
	public bool ShiftKey { get; }
	///<include file='Utils/Docs/KeyboardEventAltKey/KeyboardEventAltKey.generated.xml' path='docs/KeyboardEventAltKey/*'/>
	public bool AltKey { get; }
	///<include file='Utils/Docs/KeyboardEventMetaKey/KeyboardEventMetaKey.generated.xml' path='docs/KeyboardEventMetaKey/*'/>
	public bool MetaKey { get; }
	///<include file='Utils/Docs/KeyboardEventRepeat/KeyboardEventRepeat.generated.xml' path='docs/KeyboardEventRepeat/*'/>
	public bool Repeat { get; }
	///<include file='Utils/Docs/KeyboardEventIsComposing/KeyboardEventIsComposing.generated.xml' path='docs/KeyboardEventIsComposing/*'/>
	public bool IsComposing { get; }
	///<include file='Utils/Docs/KeyboardEventGetModifierState/KeyboardEventGetModifierState.generated.xml' path='docs/KeyboardEventGetModifierState/*'/>
	public bool GetModifierState(string keyArg) { throw new System.NotImplementedException(); }
	public KeyboardEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class KeyboardEventInit : EventModifierInit
{
		public string Key;
		public string Code;
		public ulong Location;
		public bool Repeat;
		public bool IsComposing;
}

///<include file='Utils/Docs/CompositionEvent/CompositionEvent.generated.xml' path='docs/CompositionEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CompositionEvent : UIEvent
{
	///<include file='Utils/Docs/CompositionEventCompositionEvent/CompositionEventCompositionEvent.generated.xml' path='docs/CompositionEventCompositionEvent/*'/>
	public CompositionEvent(string type, CompositionEventInit eventInitDict) { }
	///<include file='Utils/Docs/CompositionEventData/CompositionEventData.generated.xml' path='docs/CompositionEventData/*'/>
	public string Data { get; }
	public CompositionEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CompositionEventInit : UIEventInit
{
		public string Data;
}

///<include file='Utils/Docs/UIEvent/UIEvent.generated.xml' path='docs/UIEvent/*'/>
public partial class UIEvent
{
	///<include file='Utils/Docs/UIEventInitUIEvent/UIEventInitUIEvent.generated.xml' path='docs/UIEventInitUIEvent/*'/>
	public Undefined InitUIEvent(string typeArg, bool bubblesArg, bool cancelableArg, Window? viewArg, long detailArg) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/MouseEvent/MouseEvent.generated.xml' path='docs/MouseEvent/*'/>
public partial class MouseEvent
{
	///<include file='Utils/Docs/MouseEventInitMouseEvent/MouseEventInitMouseEvent.generated.xml' path='docs/MouseEventInitMouseEvent/*'/>
	public Undefined InitMouseEvent(string typeArg, bool bubblesArg, bool cancelableArg, Window? viewArg, long detailArg, long screenXArg, long screenYArg, long clientXArg, long clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, Number buttonArg, EventTarget? relatedTargetArg) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/KeyboardEvent/KeyboardEvent.generated.xml' path='docs/KeyboardEvent/*'/>
public partial class KeyboardEvent
{
	///<include file='Utils/Docs/KeyboardEventInitKeyboardEvent/KeyboardEventInitKeyboardEvent.generated.xml' path='docs/KeyboardEventInitKeyboardEvent/*'/>
	public Undefined InitKeyboardEvent(string typeArg, bool bubblesArg, bool cancelableArg, Window? viewArg, string keyArg, ulong locationArg, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/CompositionEvent/CompositionEvent.generated.xml' path='docs/CompositionEvent/*'/>
public partial class CompositionEvent
{
	///<include file='Utils/Docs/CompositionEventInitCompositionEvent/CompositionEventInitCompositionEvent.generated.xml' path='docs/CompositionEventInitCompositionEvent/*'/>
	public Undefined InitCompositionEvent(string typeArg, bool bubblesArg, bool cancelableArg, WindowProxy? viewArg, string dataArg) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/UIEvent/UIEvent.generated.xml' path='docs/UIEvent/*'/>
public partial class UIEvent
{
	///<include file='Utils/Docs/UIEventWhich/UIEventWhich.generated.xml' path='docs/UIEventWhich/*'/>
	public ulong Which { get; }
}

public partial class UIEventInit
{
		public ulong Which;
}

///<include file='Utils/Docs/KeyboardEvent/KeyboardEvent.generated.xml' path='docs/KeyboardEvent/*'/>
public partial class KeyboardEvent
{
	///<include file='Utils/Docs/KeyboardEventCharCode/KeyboardEventCharCode.generated.xml' path='docs/KeyboardEventCharCode/*'/>
	public ulong CharCode { get; }
	///<include file='Utils/Docs/KeyboardEventKeyCode/KeyboardEventKeyCode.generated.xml' path='docs/KeyboardEventKeyCode/*'/>
	public ulong KeyCode { get; }
}

public partial class KeyboardEventInit
{
		public ulong CharCode;
		public ulong KeyCode;
}

///<include file='Utils/Docs/MutationEvent/MutationEvent.generated.xml' path='docs/MutationEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MutationEvent : Event
{
		public const ushort MODIFICATION = 1;
		public const ushort ADDITION = 2;
		public const ushort REMOVAL = 3;
	///<include file='Utils/Docs/MutationEventRelatedNode/MutationEventRelatedNode.generated.xml' path='docs/MutationEventRelatedNode/*'/>
	public Node? RelatedNode { get; }
	///<include file='Utils/Docs/MutationEventPrevValue/MutationEventPrevValue.generated.xml' path='docs/MutationEventPrevValue/*'/>
	public string PrevValue { get; }
	///<include file='Utils/Docs/MutationEventNewValue/MutationEventNewValue.generated.xml' path='docs/MutationEventNewValue/*'/>
	public string NewValue { get; }
	///<include file='Utils/Docs/MutationEventAttrName/MutationEventAttrName.generated.xml' path='docs/MutationEventAttrName/*'/>
	public string AttrName { get; }
	///<include file='Utils/Docs/MutationEventAttrChange/MutationEventAttrChange.generated.xml' path='docs/MutationEventAttrChange/*'/>
	public ushort AttrChange { get; }
	///<include file='Utils/Docs/MutationEventInitMutationEvent/MutationEventInitMutationEvent.generated.xml' path='docs/MutationEventInitMutationEvent/*'/>
	public Undefined InitMutationEvent(string typeArg, bool bubblesArg, bool cancelableArg, Node? relatedNodeArg, string prevValueArg, string newValueArg, string attrNameArg, ushort attrChangeArg) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/AnimationTimeline/AnimationTimeline.generated.xml' path='docs/AnimationTimeline/*'/>
public partial class AnimationTimeline
{
	///<include file='Utils/Docs/AnimationTimelineCurrentTime/AnimationTimelineCurrentTime.generated.xml' path='docs/AnimationTimelineCurrentTime/*'/>
	public Unsupported /*CSSNumberish*/? CurrentTime { get; }
		public Unsupported /*CSSNumberish*/? Duration { get; }
		public Animation Play(AnimationEffect? effect) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Animation/Animation.generated.xml' path='docs/Animation/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Animation
{
	///<include file='Utils/Docs/AnimationStartTime/AnimationStartTime.generated.xml' path='docs/AnimationStartTime/*'/>
	public Unsupported /*CSSNumberish*/? StartTime { get; set; }
	///<include file='Utils/Docs/AnimationCurrentTime/AnimationCurrentTime.generated.xml' path='docs/AnimationCurrentTime/*'/>
	public Unsupported /*CSSNumberish*/? CurrentTime { get; set; }
}

///<include file='Utils/Docs/AnimationEffect/AnimationEffect.generated.xml' path='docs/AnimationEffect/*'/>
public partial class AnimationEffect
{
		public GroupEffect? Parent { get; }
		public AnimationEffect? PreviousSibling { get; }
		public AnimationEffect? NextSibling { get; }
		public Undefined Before(params AnimationEffect[] effects) { throw new System.NotImplementedException(); }
		public Undefined After(params AnimationEffect[] effects) { throw new System.NotImplementedException(); }
		public Undefined Replace(params AnimationEffect[] effects) { throw new System.NotImplementedException(); }
		public Undefined Remove() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class EffectTiming
{
		public Number Delay;
		public Number EndDelay;
		public Number PlaybackRate;
		public Union90 Duration;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class OptionalEffectTiming
{
		public Number PlaybackRate;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ComputedEffectTiming
{
		public Unsupported /*CSSNumberish*/ StartTime;
		public Unsupported /*CSSNumberish*/ EndTime;
		public Unsupported /*CSSNumberish*/ ActiveDuration;
		public Unsupported /*CSSNumberish*/? LocalTime;
}

public enum FillMode
{
	None,
	Forwards,
	Backwards,
	Both,
	Auto,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GroupEffect
{
		public GroupEffect(List<AnimationEffect>? children, Union91 timing) { }
		public AnimationNodeList Children { get; }
		public AnimationEffect? FirstChild { get; }
		public AnimationEffect? LastChild { get; }
		public GroupEffect Clone() { throw new System.NotImplementedException(); }
		public Undefined Prepend(params AnimationEffect[] effects) { throw new System.NotImplementedException(); }
		public Undefined Append(params AnimationEffect[] effects) { throw new System.NotImplementedException(); }
	public GroupEffect() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AnimationNodeList
{
		public ulong Length { get; }
	
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class SequenceEffect : GroupEffect
{
		public SequenceEffect(List<AnimationEffect>? children, Union92 timing) { }
		public SequenceEffect Clone() { throw new System.NotImplementedException(); }
	public SequenceEffect() { }
}

///<include file='Utils/Docs/KeyframeEffect/KeyframeEffect.generated.xml' path='docs/KeyframeEffect/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class KeyframeEffect
{
	///<include file='Utils/Docs/KeyframeEffectIterationComposite/KeyframeEffectIterationComposite.generated.xml' path='docs/KeyframeEffectIterationComposite/*'/>
	public IterationCompositeOperation IterationComposite { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class KeyframeEffectOptions
{
		public IterationCompositeOperation IterationComposite;
}

public enum IterationCompositeOperation
{
	Replace,
	Accumulate,
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct EffectCallback
{
}

///<include file='Utils/Docs/AnimationPlaybackEvent/AnimationPlaybackEvent.generated.xml' path='docs/AnimationPlaybackEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AnimationPlaybackEvent : Event
{
	///<include file='Utils/Docs/AnimationPlaybackEventAnimationPlaybackEvent/AnimationPlaybackEventAnimationPlaybackEvent.generated.xml' path='docs/AnimationPlaybackEventAnimationPlaybackEvent/*'/>
	public AnimationPlaybackEvent(string type, AnimationPlaybackEventInit eventInitDict) { }
	///<include file='Utils/Docs/AnimationPlaybackEventCurrentTime/AnimationPlaybackEventCurrentTime.generated.xml' path='docs/AnimationPlaybackEventCurrentTime/*'/>
	public Unsupported /*CSSNumberish*/? CurrentTime { get; }
	///<include file='Utils/Docs/AnimationPlaybackEventTimelineTime/AnimationPlaybackEventTimelineTime.generated.xml' path='docs/AnimationPlaybackEventTimelineTime/*'/>
	public Unsupported /*CSSNumberish*/? TimelineTime { get; }
	public AnimationPlaybackEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AnimationPlaybackEventInit : EventInit
{
		public Unsupported /*CSSNumberish*/? CurrentTime;
		public Unsupported /*CSSNumberish*/? TimelineTime;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebAssemblyInstantiatedSource
{
		public required Module Module;
		public required Instance Instance;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebAssembly
{
		public bool Validate(BufferSource bytes) { throw new System.NotImplementedException(); }
		public Task<Module> Compile(BufferSource bytes) { throw new System.NotImplementedException(); }
		public Task<WebAssemblyInstantiatedSource> Instantiate(BufferSource bytes, object importObject) { throw new System.NotImplementedException(); }
		public Task<Instance> Instantiate(Module moduleObject, object importObject) { throw new System.NotImplementedException(); }
}

public enum ImportExportKind
{
	Function,
	Table,
	Memory,
	Global,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ModuleExportDescriptor
{
		public required string Name;
		public required ImportExportKind Kind;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ModuleImportDescriptor
{
		public required string Module;
		public required string Name;
		public required ImportExportKind Kind;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class Module
{
		public Module(BufferSource bytes) { }
		public static List<ModuleExportDescriptor> Exports(Module moduleObject) { throw new System.NotImplementedException(); }
		public static List<ModuleImportDescriptor> Imports(Module moduleObject) { throw new System.NotImplementedException(); }
		public static List<byte[]> CustomSections(Module moduleObject, string sectionName) { throw new System.NotImplementedException(); }
	public Module() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class Instance
{
		public Instance(Module module, object importObject) { }
		public object Exports { get; }
	public Instance() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MemoryDescriptor
{
		public required ulong Initial;
		public ulong Maximum;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class Memory
{
		public Memory(MemoryDescriptor descriptor) { }
		public ulong Grow(ulong delta) { throw new System.NotImplementedException(); }
		public byte[] Buffer { get; }
	public Memory() { }
}

public enum TableKind
{
	Anyfunc,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class TableDescriptor
{
		public required TableKind Element;
		public required ulong Initial;
		public ulong Maximum;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class Table
{
		public Table(TableDescriptor descriptor) { }
		public ulong Grow(ulong delta) { throw new System.NotImplementedException(); }
		public Function? Get(ulong index) { throw new System.NotImplementedException(); }
		public Undefined Set(ulong index, Function? value) { throw new System.NotImplementedException(); }
		public ulong Length { get; }
	public Table() { }
}

public enum ValueType
{
	I32,
	I64,
	F32,
	F64,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GlobalDescriptor
{
		public required ValueType Value;
		public bool Mutable;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class Global
{
		public Global(GlobalDescriptor descriptor, dynamic v) { }
		public dynamic ValueOf() { throw new System.NotImplementedException(); }
		public dynamic Value { get; set; }
	public Global() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CompileError
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class LinkError
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class RuntimeError
{
}

public partial class WebAssembly
{
		public Task<Module> CompileStreaming(Task<Response> source) { throw new System.NotImplementedException(); }
		public Task<WebAssemblyInstantiatedSource> InstantiateStreaming(Task<Response> source, object importObject) { throw new System.NotImplementedException(); }
}

public enum AudioContextState
{
	Suspended,
	Running,
	Closed,
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct DecodeErrorCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct DecodeSuccessCallback
{
}

///<include file='Utils/Docs/BaseAudioContext/BaseAudioContext.generated.xml' path='docs/BaseAudioContext/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class BaseAudioContext : EventTarget
{
	///<include file='Utils/Docs/BaseAudioContextDestination/BaseAudioContextDestination.generated.xml' path='docs/BaseAudioContextDestination/*'/>
	public AudioDestinationNode Destination { get; }
	///<include file='Utils/Docs/BaseAudioContextSampleRate/BaseAudioContextSampleRate.generated.xml' path='docs/BaseAudioContextSampleRate/*'/>
	public Number SampleRate { get; }
	///<include file='Utils/Docs/BaseAudioContextCurrentTime/BaseAudioContextCurrentTime.generated.xml' path='docs/BaseAudioContextCurrentTime/*'/>
	public Number CurrentTime { get; }
	///<include file='Utils/Docs/BaseAudioContextListener/BaseAudioContextListener.generated.xml' path='docs/BaseAudioContextListener/*'/>
	public AudioListener Listener { get; }
	///<include file='Utils/Docs/BaseAudioContextState/BaseAudioContextState.generated.xml' path='docs/BaseAudioContextState/*'/>
	public AudioContextState State { get; }
	///<include file='Utils/Docs/BaseAudioContextAudioWorklet/BaseAudioContextAudioWorklet.generated.xml' path='docs/BaseAudioContextAudioWorklet/*'/>
	public AudioWorklet AudioWorklet { get; }
		public EventHandler Onstatechange { get; set; }
	///<include file='Utils/Docs/BaseAudioContextCreateAnalyser/BaseAudioContextCreateAnalyser.generated.xml' path='docs/BaseAudioContextCreateAnalyser/*'/>
	public AnalyserNode CreateAnalyser() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BaseAudioContextCreateBiquadFilter/BaseAudioContextCreateBiquadFilter.generated.xml' path='docs/BaseAudioContextCreateBiquadFilter/*'/>
	public BiquadFilterNode CreateBiquadFilter() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BaseAudioContextCreateBuffer/BaseAudioContextCreateBuffer.generated.xml' path='docs/BaseAudioContextCreateBuffer/*'/>
	public AudioBuffer CreateBuffer(ulong numberOfChannels, ulong length, Number sampleRate) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BaseAudioContextCreateBufferSource/BaseAudioContextCreateBufferSource.generated.xml' path='docs/BaseAudioContextCreateBufferSource/*'/>
	public AudioBufferSourceNode CreateBufferSource() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BaseAudioContextCreateChannelMerger/BaseAudioContextCreateChannelMerger.generated.xml' path='docs/BaseAudioContextCreateChannelMerger/*'/>
	public ChannelMergerNode CreateChannelMerger(ulong numberOfInputs) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BaseAudioContextCreateChannelSplitter/BaseAudioContextCreateChannelSplitter.generated.xml' path='docs/BaseAudioContextCreateChannelSplitter/*'/>
	public ChannelSplitterNode CreateChannelSplitter(ulong numberOfOutputs) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BaseAudioContextCreateConstantSource/BaseAudioContextCreateConstantSource.generated.xml' path='docs/BaseAudioContextCreateConstantSource/*'/>
	public ConstantSourceNode CreateConstantSource() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BaseAudioContextCreateConvolver/BaseAudioContextCreateConvolver.generated.xml' path='docs/BaseAudioContextCreateConvolver/*'/>
	public ConvolverNode CreateConvolver() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BaseAudioContextCreateDelay/BaseAudioContextCreateDelay.generated.xml' path='docs/BaseAudioContextCreateDelay/*'/>
	public DelayNode CreateDelay(Number maxDelayTime) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BaseAudioContextCreateDynamicsCompressor/BaseAudioContextCreateDynamicsCompressor.generated.xml' path='docs/BaseAudioContextCreateDynamicsCompressor/*'/>
	public DynamicsCompressorNode CreateDynamicsCompressor() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BaseAudioContextCreateGain/BaseAudioContextCreateGain.generated.xml' path='docs/BaseAudioContextCreateGain/*'/>
	public GainNode CreateGain() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BaseAudioContextCreateIIRFilter/BaseAudioContextCreateIIRFilter.generated.xml' path='docs/BaseAudioContextCreateIIRFilter/*'/>
	public IIRFilterNode CreateIIRFilter(List<Number> feedforward, List<Number> feedback) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BaseAudioContextCreateOscillator/BaseAudioContextCreateOscillator.generated.xml' path='docs/BaseAudioContextCreateOscillator/*'/>
	public OscillatorNode CreateOscillator() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BaseAudioContextCreatePanner/BaseAudioContextCreatePanner.generated.xml' path='docs/BaseAudioContextCreatePanner/*'/>
	public PannerNode CreatePanner() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BaseAudioContextCreatePeriodicWave/BaseAudioContextCreatePeriodicWave.generated.xml' path='docs/BaseAudioContextCreatePeriodicWave/*'/>
	public PeriodicWave CreatePeriodicWave(List<Number> real, List<Number> imag, PeriodicWaveConstraints constraints) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BaseAudioContextCreateScriptProcessor/BaseAudioContextCreateScriptProcessor.generated.xml' path='docs/BaseAudioContextCreateScriptProcessor/*'/>
	public ScriptProcessorNode CreateScriptProcessor(ulong bufferSize, ulong numberOfInputChannels, ulong numberOfOutputChannels) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BaseAudioContextCreateStereoPanner/BaseAudioContextCreateStereoPanner.generated.xml' path='docs/BaseAudioContextCreateStereoPanner/*'/>
	public StereoPannerNode CreateStereoPanner() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BaseAudioContextCreateWaveShaper/BaseAudioContextCreateWaveShaper.generated.xml' path='docs/BaseAudioContextCreateWaveShaper/*'/>
	public WaveShaperNode CreateWaveShaper() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BaseAudioContextDecodeAudioData/BaseAudioContextDecodeAudioData.generated.xml' path='docs/BaseAudioContextDecodeAudioData/*'/>
	public Task<AudioBuffer> DecodeAudioData(byte[] audioData, DecodeSuccessCallback? successCallback, DecodeErrorCallback? errorCallback) { throw new System.NotImplementedException(); }
}

public enum AudioContextLatencyCategory
{
	Balanced,
	Interactive,
	Playback,
}

///<include file='Utils/Docs/AudioContext/AudioContext.generated.xml' path='docs/AudioContext/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioContext : BaseAudioContext
{
	///<include file='Utils/Docs/AudioContextAudioContext/AudioContextAudioContext.generated.xml' path='docs/AudioContextAudioContext/*'/>
	public AudioContext(AudioContextOptions contextOptions) { }
	///<include file='Utils/Docs/AudioContextBaseLatency/AudioContextBaseLatency.generated.xml' path='docs/AudioContextBaseLatency/*'/>
	public Number BaseLatency { get; }
	///<include file='Utils/Docs/AudioContextOutputLatency/AudioContextOutputLatency.generated.xml' path='docs/AudioContextOutputLatency/*'/>
	public Number OutputLatency { get; }
	///<include file='Utils/Docs/AudioContextGetOutputTimestamp/AudioContextGetOutputTimestamp.generated.xml' path='docs/AudioContextGetOutputTimestamp/*'/>
	public AudioTimestamp GetOutputTimestamp() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioContextResume/AudioContextResume.generated.xml' path='docs/AudioContextResume/*'/>
	public Task<Undefined> Resume() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioContextSuspend/AudioContextSuspend.generated.xml' path='docs/AudioContextSuspend/*'/>
	public Task<Undefined> Suspend() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioContextClose/AudioContextClose.generated.xml' path='docs/AudioContextClose/*'/>
	public Task<Undefined> Close() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioContextCreateMediaElementSource/AudioContextCreateMediaElementSource.generated.xml' path='docs/AudioContextCreateMediaElementSource/*'/>
	public MediaElementAudioSourceNode CreateMediaElementSource(HTMLMediaElement mediaElement) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioContextCreateMediaStreamSource/AudioContextCreateMediaStreamSource.generated.xml' path='docs/AudioContextCreateMediaStreamSource/*'/>
	public MediaStreamAudioSourceNode CreateMediaStreamSource(Unsupported /*MediaStream*/ mediaStream) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioContextCreateMediaStreamTrackSource/AudioContextCreateMediaStreamTrackSource.generated.xml' path='docs/AudioContextCreateMediaStreamTrackSource/*'/>
	public MediaStreamTrackAudioSourceNode CreateMediaStreamTrackSource(Unsupported /*MediaStreamTrack*/ mediaStreamTrack) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioContextCreateMediaStreamDestination/AudioContextCreateMediaStreamDestination.generated.xml' path='docs/AudioContextCreateMediaStreamDestination/*'/>
	public MediaStreamAudioDestinationNode CreateMediaStreamDestination() { throw new System.NotImplementedException(); }
	public AudioContext() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioContextOptions
{
		public Union94 LatencyHint;
		public Number SampleRate;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioTimestamp
{
		public Number ContextTime;
		public Unsupported /*DOMHighResTimeStamp*/ PerformanceTime;
}

///<include file='Utils/Docs/OfflineAudioContext/OfflineAudioContext.generated.xml' path='docs/OfflineAudioContext/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class OfflineAudioContext : BaseAudioContext
{
	///<include file='Utils/Docs/OfflineAudioContextOfflineAudioContext/OfflineAudioContextOfflineAudioContext.generated.xml' path='docs/OfflineAudioContextOfflineAudioContext/*'/>
	public OfflineAudioContext(OfflineAudioContextOptions contextOptions) { }
	///<include file='Utils/Docs/OfflineAudioContextOfflineAudioContext/OfflineAudioContextOfflineAudioContext.generated.xml' path='docs/OfflineAudioContextOfflineAudioContext/*'/>
	public OfflineAudioContext(ulong numberOfChannels, ulong length, Number sampleRate) { }
	///<include file='Utils/Docs/OfflineAudioContextStartRendering/OfflineAudioContextStartRendering.generated.xml' path='docs/OfflineAudioContextStartRendering/*'/>
	public Task<AudioBuffer> StartRendering() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/OfflineAudioContextResume/OfflineAudioContextResume.generated.xml' path='docs/OfflineAudioContextResume/*'/>
	public Task<Undefined> Resume() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/OfflineAudioContextSuspend/OfflineAudioContextSuspend.generated.xml' path='docs/OfflineAudioContextSuspend/*'/>
	public Task<Undefined> Suspend(Number suspendTime) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/OfflineAudioContextLength/OfflineAudioContextLength.generated.xml' path='docs/OfflineAudioContextLength/*'/>
	public ulong Length { get; }
		public EventHandler Oncomplete { get; set; }
	public OfflineAudioContext() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class OfflineAudioContextOptions
{
		public ulong NumberOfChannels;
		public required ulong Length;
		public required Number SampleRate;
}

///<include file='Utils/Docs/OfflineAudioCompletionEvent/OfflineAudioCompletionEvent.generated.xml' path='docs/OfflineAudioCompletionEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class OfflineAudioCompletionEvent : Event
{
	///<include file='Utils/Docs/OfflineAudioCompletionEventOfflineAudioCompletionEvent/OfflineAudioCompletionEventOfflineAudioCompletionEvent.generated.xml' path='docs/OfflineAudioCompletionEventOfflineAudioCompletionEvent/*'/>
	public OfflineAudioCompletionEvent(string type, OfflineAudioCompletionEventInit eventInitDict) { }
	///<include file='Utils/Docs/OfflineAudioCompletionEventRenderedBuffer/OfflineAudioCompletionEventRenderedBuffer.generated.xml' path='docs/OfflineAudioCompletionEventRenderedBuffer/*'/>
	public AudioBuffer RenderedBuffer { get; }
	public OfflineAudioCompletionEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class OfflineAudioCompletionEventInit : EventInit
{
		public required AudioBuffer RenderedBuffer;
}

///<include file='Utils/Docs/AudioBuffer/AudioBuffer.generated.xml' path='docs/AudioBuffer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioBuffer
{
	///<include file='Utils/Docs/AudioBufferAudioBuffer/AudioBufferAudioBuffer.generated.xml' path='docs/AudioBufferAudioBuffer/*'/>
	public AudioBuffer(AudioBufferOptions options) { }
	///<include file='Utils/Docs/AudioBufferSampleRate/AudioBufferSampleRate.generated.xml' path='docs/AudioBufferSampleRate/*'/>
	public Number SampleRate { get; }
	///<include file='Utils/Docs/AudioBufferLength/AudioBufferLength.generated.xml' path='docs/AudioBufferLength/*'/>
	public ulong Length { get; }
	///<include file='Utils/Docs/AudioBufferDuration/AudioBufferDuration.generated.xml' path='docs/AudioBufferDuration/*'/>
	public Number Duration { get; }
	///<include file='Utils/Docs/AudioBufferNumberOfChannels/AudioBufferNumberOfChannels.generated.xml' path='docs/AudioBufferNumberOfChannels/*'/>
	public ulong NumberOfChannels { get; }
	///<include file='Utils/Docs/AudioBufferGetChannelData/AudioBufferGetChannelData.generated.xml' path='docs/AudioBufferGetChannelData/*'/>
	public System.Single GetChannelData(ulong channel) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioBufferCopyFromChannel/AudioBufferCopyFromChannel.generated.xml' path='docs/AudioBufferCopyFromChannel/*'/>
	public Undefined CopyFromChannel(System.Single destination, ulong channelNumber, ulong bufferOffset) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioBufferCopyToChannel/AudioBufferCopyToChannel.generated.xml' path='docs/AudioBufferCopyToChannel/*'/>
	public Undefined CopyToChannel(System.Single source, ulong channelNumber, ulong bufferOffset) { throw new System.NotImplementedException(); }
	public AudioBuffer() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioBufferOptions
{
		public ulong NumberOfChannels;
		public required ulong Length;
		public required Number SampleRate;
}

///<include file='Utils/Docs/AudioNode/AudioNode.generated.xml' path='docs/AudioNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioNode : EventTarget
{
	///<include file='Utils/Docs/AudioNodeConnect/AudioNodeConnect.generated.xml' path='docs/AudioNodeConnect/*'/>
	public AudioNode Connect(AudioNode destinationNode, ulong output, ulong input) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioNodeConnect/AudioNodeConnect.generated.xml' path='docs/AudioNodeConnect/*'/>
	public Undefined Connect(AudioParam destinationParam, ulong output) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioNodeDisconnect/AudioNodeDisconnect.generated.xml' path='docs/AudioNodeDisconnect/*'/>
	public Undefined Disconnect() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioNodeDisconnect/AudioNodeDisconnect.generated.xml' path='docs/AudioNodeDisconnect/*'/>
	public Undefined Disconnect(ulong output) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioNodeDisconnect/AudioNodeDisconnect.generated.xml' path='docs/AudioNodeDisconnect/*'/>
	public Undefined Disconnect(AudioNode destinationNode) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioNodeDisconnect/AudioNodeDisconnect.generated.xml' path='docs/AudioNodeDisconnect/*'/>
	public Undefined Disconnect(AudioNode destinationNode, ulong output) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioNodeDisconnect/AudioNodeDisconnect.generated.xml' path='docs/AudioNodeDisconnect/*'/>
	public Undefined Disconnect(AudioNode destinationNode, ulong output, ulong input) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioNodeDisconnect/AudioNodeDisconnect.generated.xml' path='docs/AudioNodeDisconnect/*'/>
	public Undefined Disconnect(AudioParam destinationParam) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioNodeDisconnect/AudioNodeDisconnect.generated.xml' path='docs/AudioNodeDisconnect/*'/>
	public Undefined Disconnect(AudioParam destinationParam, ulong output) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioNodeContext/AudioNodeContext.generated.xml' path='docs/AudioNodeContext/*'/>
	public BaseAudioContext Context { get; }
	///<include file='Utils/Docs/AudioNodeNumberOfInputs/AudioNodeNumberOfInputs.generated.xml' path='docs/AudioNodeNumberOfInputs/*'/>
	public ulong NumberOfInputs { get; }
	///<include file='Utils/Docs/AudioNodeNumberOfOutputs/AudioNodeNumberOfOutputs.generated.xml' path='docs/AudioNodeNumberOfOutputs/*'/>
	public ulong NumberOfOutputs { get; }
	///<include file='Utils/Docs/AudioNodeChannelCount/AudioNodeChannelCount.generated.xml' path='docs/AudioNodeChannelCount/*'/>
	public ulong ChannelCount { get; set; }
	///<include file='Utils/Docs/AudioNodeChannelCountMode/AudioNodeChannelCountMode.generated.xml' path='docs/AudioNodeChannelCountMode/*'/>
	public ChannelCountMode ChannelCountMode { get; set; }
	///<include file='Utils/Docs/AudioNodeChannelInterpretation/AudioNodeChannelInterpretation.generated.xml' path='docs/AudioNodeChannelInterpretation/*'/>
	public ChannelInterpretation ChannelInterpretation { get; set; }
}

public enum ChannelCountMode
{
	Max,
	ClampedMax,
	Explicit,
}

public enum ChannelInterpretation
{
	Speakers,
	Discrete,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioNodeOptions
{
		public ulong ChannelCount;
		public ChannelCountMode ChannelCountMode;
		public ChannelInterpretation ChannelInterpretation;
}

public enum AutomationRate
{
	ARate,
	KRate,
}

///<include file='Utils/Docs/AudioParam/AudioParam.generated.xml' path='docs/AudioParam/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioParam
{
	///<include file='Utils/Docs/AudioParamValue/AudioParamValue.generated.xml' path='docs/AudioParamValue/*'/>
	public Number Value { get; set; }
		public AutomationRate AutomationRate { get; set; }
	///<include file='Utils/Docs/AudioParamDefaultValue/AudioParamDefaultValue.generated.xml' path='docs/AudioParamDefaultValue/*'/>
	public Number DefaultValue { get; }
	///<include file='Utils/Docs/AudioParamMinValue/AudioParamMinValue.generated.xml' path='docs/AudioParamMinValue/*'/>
	public Number MinValue { get; }
	///<include file='Utils/Docs/AudioParamMaxValue/AudioParamMaxValue.generated.xml' path='docs/AudioParamMaxValue/*'/>
	public Number MaxValue { get; }
	///<include file='Utils/Docs/AudioParamSetValueAtTime/AudioParamSetValueAtTime.generated.xml' path='docs/AudioParamSetValueAtTime/*'/>
	public AudioParam SetValueAtTime(Number value, Number startTime) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioParamLinearRampToValueAtTime/AudioParamLinearRampToValueAtTime.generated.xml' path='docs/AudioParamLinearRampToValueAtTime/*'/>
	public AudioParam LinearRampToValueAtTime(Number value, Number endTime) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioParamExponentialRampToValueAtTime/AudioParamExponentialRampToValueAtTime.generated.xml' path='docs/AudioParamExponentialRampToValueAtTime/*'/>
	public AudioParam ExponentialRampToValueAtTime(Number value, Number endTime) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioParamSetTargetAtTime/AudioParamSetTargetAtTime.generated.xml' path='docs/AudioParamSetTargetAtTime/*'/>
	public AudioParam SetTargetAtTime(Number target, Number startTime, Number timeConstant) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioParamSetValueCurveAtTime/AudioParamSetValueCurveAtTime.generated.xml' path='docs/AudioParamSetValueCurveAtTime/*'/>
	public AudioParam SetValueCurveAtTime(List<Number> values, Number startTime, Number duration) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioParamCancelScheduledValues/AudioParamCancelScheduledValues.generated.xml' path='docs/AudioParamCancelScheduledValues/*'/>
	public AudioParam CancelScheduledValues(Number cancelTime) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioParamCancelAndHoldAtTime/AudioParamCancelAndHoldAtTime.generated.xml' path='docs/AudioParamCancelAndHoldAtTime/*'/>
	public AudioParam CancelAndHoldAtTime(Number cancelTime) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/AudioScheduledSourceNode/AudioScheduledSourceNode.generated.xml' path='docs/AudioScheduledSourceNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioScheduledSourceNode : AudioNode
{
		public EventHandler Onended { get; set; }
	///<include file='Utils/Docs/AudioScheduledSourceNodeStart/AudioScheduledSourceNodeStart.generated.xml' path='docs/AudioScheduledSourceNodeStart/*'/>
	public Undefined Start(Number when) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioScheduledSourceNodeStop/AudioScheduledSourceNodeStop.generated.xml' path='docs/AudioScheduledSourceNodeStop/*'/>
	public Undefined Stop(Number when) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/AnalyserNode/AnalyserNode.generated.xml' path='docs/AnalyserNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AnalyserNode : AudioNode
{
	///<include file='Utils/Docs/AnalyserNodeAnalyserNode/AnalyserNodeAnalyserNode.generated.xml' path='docs/AnalyserNodeAnalyserNode/*'/>
	public AnalyserNode(BaseAudioContext context, AnalyserOptions options) { }
	///<include file='Utils/Docs/AnalyserNodeGetFloatFrequencyData/AnalyserNodeGetFloatFrequencyData.generated.xml' path='docs/AnalyserNodeGetFloatFrequencyData/*'/>
	public Undefined GetFloatFrequencyData(System.Single array) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AnalyserNodeGetByteFrequencyData/AnalyserNodeGetByteFrequencyData.generated.xml' path='docs/AnalyserNodeGetByteFrequencyData/*'/>
	public Undefined GetByteFrequencyData(System.Byte array) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AnalyserNodeGetFloatTimeDomainData/AnalyserNodeGetFloatTimeDomainData.generated.xml' path='docs/AnalyserNodeGetFloatTimeDomainData/*'/>
	public Undefined GetFloatTimeDomainData(System.Single array) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AnalyserNodeGetByteTimeDomainData/AnalyserNodeGetByteTimeDomainData.generated.xml' path='docs/AnalyserNodeGetByteTimeDomainData/*'/>
	public Undefined GetByteTimeDomainData(System.Byte array) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AnalyserNodeFftSize/AnalyserNodeFftSize.generated.xml' path='docs/AnalyserNodeFftSize/*'/>
	public ulong FftSize { get; set; }
	///<include file='Utils/Docs/AnalyserNodeFrequencyBinCount/AnalyserNodeFrequencyBinCount.generated.xml' path='docs/AnalyserNodeFrequencyBinCount/*'/>
	public ulong FrequencyBinCount { get; }
	///<include file='Utils/Docs/AnalyserNodeMinDecibels/AnalyserNodeMinDecibels.generated.xml' path='docs/AnalyserNodeMinDecibels/*'/>
	public Number MinDecibels { get; set; }
	///<include file='Utils/Docs/AnalyserNodeMaxDecibels/AnalyserNodeMaxDecibels.generated.xml' path='docs/AnalyserNodeMaxDecibels/*'/>
	public Number MaxDecibels { get; set; }
	///<include file='Utils/Docs/AnalyserNodeSmoothingTimeConstant/AnalyserNodeSmoothingTimeConstant.generated.xml' path='docs/AnalyserNodeSmoothingTimeConstant/*'/>
	public Number SmoothingTimeConstant { get; set; }
	public AnalyserNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AnalyserOptions : AudioNodeOptions
{
		public ulong FftSize;
		public Number MaxDecibels;
		public Number MinDecibels;
		public Number SmoothingTimeConstant;
}

///<include file='Utils/Docs/AudioBufferSourceNode/AudioBufferSourceNode.generated.xml' path='docs/AudioBufferSourceNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioBufferSourceNode : AudioScheduledSourceNode
{
	///<include file='Utils/Docs/AudioBufferSourceNodeAudioBufferSourceNode/AudioBufferSourceNodeAudioBufferSourceNode.generated.xml' path='docs/AudioBufferSourceNodeAudioBufferSourceNode/*'/>
	public AudioBufferSourceNode(BaseAudioContext context, AudioBufferSourceOptions options) { }
	///<include file='Utils/Docs/AudioBufferSourceNodeBuffer/AudioBufferSourceNodeBuffer.generated.xml' path='docs/AudioBufferSourceNodeBuffer/*'/>
	public AudioBuffer? Buffer { get; set; }
	///<include file='Utils/Docs/AudioBufferSourceNodePlaybackRate/AudioBufferSourceNodePlaybackRate.generated.xml' path='docs/AudioBufferSourceNodePlaybackRate/*'/>
	public AudioParam PlaybackRate { get; }
	///<include file='Utils/Docs/AudioBufferSourceNodeDetune/AudioBufferSourceNodeDetune.generated.xml' path='docs/AudioBufferSourceNodeDetune/*'/>
	public AudioParam Detune { get; }
	///<include file='Utils/Docs/AudioBufferSourceNodeLoop/AudioBufferSourceNodeLoop.generated.xml' path='docs/AudioBufferSourceNodeLoop/*'/>
	public bool Loop { get; set; }
	///<include file='Utils/Docs/AudioBufferSourceNodeLoopStart/AudioBufferSourceNodeLoopStart.generated.xml' path='docs/AudioBufferSourceNodeLoopStart/*'/>
	public Number LoopStart { get; set; }
	///<include file='Utils/Docs/AudioBufferSourceNodeLoopEnd/AudioBufferSourceNodeLoopEnd.generated.xml' path='docs/AudioBufferSourceNodeLoopEnd/*'/>
	public Number LoopEnd { get; set; }
	///<include file='Utils/Docs/AudioBufferSourceNodeStart/AudioBufferSourceNodeStart.generated.xml' path='docs/AudioBufferSourceNodeStart/*'/>
	public Undefined Start(Number when, Number offset, Number duration) { throw new System.NotImplementedException(); }
	public AudioBufferSourceNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioBufferSourceOptions
{
		public AudioBuffer? Buffer;
		public Number Detune;
		public bool Loop;
		public Number LoopEnd;
		public Number LoopStart;
		public Number PlaybackRate;
}

///<include file='Utils/Docs/AudioDestinationNode/AudioDestinationNode.generated.xml' path='docs/AudioDestinationNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioDestinationNode : AudioNode
{
	///<include file='Utils/Docs/AudioDestinationNodeMaxChannelCount/AudioDestinationNodeMaxChannelCount.generated.xml' path='docs/AudioDestinationNodeMaxChannelCount/*'/>
	public ulong MaxChannelCount { get; }
}

///<include file='Utils/Docs/AudioListener/AudioListener.generated.xml' path='docs/AudioListener/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioListener
{
	///<include file='Utils/Docs/AudioListenerPositionX/AudioListenerPositionX.generated.xml' path='docs/AudioListenerPositionX/*'/>
	public AudioParam PositionX { get; }
	///<include file='Utils/Docs/AudioListenerPositionY/AudioListenerPositionY.generated.xml' path='docs/AudioListenerPositionY/*'/>
	public AudioParam PositionY { get; }
	///<include file='Utils/Docs/AudioListenerPositionZ/AudioListenerPositionZ.generated.xml' path='docs/AudioListenerPositionZ/*'/>
	public AudioParam PositionZ { get; }
	///<include file='Utils/Docs/AudioListenerForwardX/AudioListenerForwardX.generated.xml' path='docs/AudioListenerForwardX/*'/>
	public AudioParam ForwardX { get; }
	///<include file='Utils/Docs/AudioListenerForwardY/AudioListenerForwardY.generated.xml' path='docs/AudioListenerForwardY/*'/>
	public AudioParam ForwardY { get; }
	///<include file='Utils/Docs/AudioListenerForwardZ/AudioListenerForwardZ.generated.xml' path='docs/AudioListenerForwardZ/*'/>
	public AudioParam ForwardZ { get; }
	///<include file='Utils/Docs/AudioListenerUpX/AudioListenerUpX.generated.xml' path='docs/AudioListenerUpX/*'/>
	public AudioParam UpX { get; }
	///<include file='Utils/Docs/AudioListenerUpY/AudioListenerUpY.generated.xml' path='docs/AudioListenerUpY/*'/>
	public AudioParam UpY { get; }
	///<include file='Utils/Docs/AudioListenerUpZ/AudioListenerUpZ.generated.xml' path='docs/AudioListenerUpZ/*'/>
	public AudioParam UpZ { get; }
	///<include file='Utils/Docs/AudioListenerSetPosition/AudioListenerSetPosition.generated.xml' path='docs/AudioListenerSetPosition/*'/>
	public Undefined SetPosition(Number x, Number y, Number z) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioListenerSetOrientation/AudioListenerSetOrientation.generated.xml' path='docs/AudioListenerSetOrientation/*'/>
	public Undefined SetOrientation(Number x, Number y, Number z, Number xUp, Number yUp, Number zUp) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/AudioProcessingEvent/AudioProcessingEvent.generated.xml' path='docs/AudioProcessingEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioProcessingEvent : Event
{
	///<include file='Utils/Docs/AudioProcessingEventAudioProcessingEvent/AudioProcessingEventAudioProcessingEvent.generated.xml' path='docs/AudioProcessingEventAudioProcessingEvent/*'/>
	public AudioProcessingEvent(string type, AudioProcessingEventInit eventInitDict) { }
	///<include file='Utils/Docs/AudioProcessingEventPlaybackTime/AudioProcessingEventPlaybackTime.generated.xml' path='docs/AudioProcessingEventPlaybackTime/*'/>
	public Number PlaybackTime { get; }
	///<include file='Utils/Docs/AudioProcessingEventInputBuffer/AudioProcessingEventInputBuffer.generated.xml' path='docs/AudioProcessingEventInputBuffer/*'/>
	public AudioBuffer InputBuffer { get; }
	///<include file='Utils/Docs/AudioProcessingEventOutputBuffer/AudioProcessingEventOutputBuffer.generated.xml' path='docs/AudioProcessingEventOutputBuffer/*'/>
	public AudioBuffer OutputBuffer { get; }
	public AudioProcessingEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioProcessingEventInit : EventInit
{
		public required Number PlaybackTime;
		public required AudioBuffer InputBuffer;
		public required AudioBuffer OutputBuffer;
}

public enum BiquadFilterType
{
	Lowpass,
	Highpass,
	Bandpass,
	Lowshelf,
	Highshelf,
	Peaking,
	Notch,
	Allpass,
}

///<include file='Utils/Docs/BiquadFilterNode/BiquadFilterNode.generated.xml' path='docs/BiquadFilterNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class BiquadFilterNode : AudioNode
{
	///<include file='Utils/Docs/BiquadFilterNodeBiquadFilterNode/BiquadFilterNodeBiquadFilterNode.generated.xml' path='docs/BiquadFilterNodeBiquadFilterNode/*'/>
	public BiquadFilterNode(BaseAudioContext context, BiquadFilterOptions options) { }
	///<include file='Utils/Docs/BiquadFilterNodeType/BiquadFilterNodeType.generated.xml' path='docs/BiquadFilterNodeType/*'/>
	public BiquadFilterType Type { get; set; }
	///<include file='Utils/Docs/BiquadFilterNodeFrequency/BiquadFilterNodeFrequency.generated.xml' path='docs/BiquadFilterNodeFrequency/*'/>
	public AudioParam Frequency { get; }
	///<include file='Utils/Docs/BiquadFilterNodeDetune/BiquadFilterNodeDetune.generated.xml' path='docs/BiquadFilterNodeDetune/*'/>
	public AudioParam Detune { get; }
	///<include file='Utils/Docs/BiquadFilterNodeQ/BiquadFilterNodeQ.generated.xml' path='docs/BiquadFilterNodeQ/*'/>
	public AudioParam Q { get; }
	///<include file='Utils/Docs/BiquadFilterNodeGain/BiquadFilterNodeGain.generated.xml' path='docs/BiquadFilterNodeGain/*'/>
	public AudioParam Gain { get; }
	///<include file='Utils/Docs/BiquadFilterNodeGetFrequencyResponse/BiquadFilterNodeGetFrequencyResponse.generated.xml' path='docs/BiquadFilterNodeGetFrequencyResponse/*'/>
	public Undefined GetFrequencyResponse(System.Single frequencyHz, System.Single magResponse, System.Single phaseResponse) { throw new System.NotImplementedException(); }
	public BiquadFilterNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class BiquadFilterOptions : AudioNodeOptions
{
		public BiquadFilterType Type;
		public Number Q;
		public Number Detune;
		public Number Frequency;
		public Number Gain;
}

///<include file='Utils/Docs/ChannelMergerNode/ChannelMergerNode.generated.xml' path='docs/ChannelMergerNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ChannelMergerNode : AudioNode
{
	///<include file='Utils/Docs/ChannelMergerNodeChannelMergerNode/ChannelMergerNodeChannelMergerNode.generated.xml' path='docs/ChannelMergerNodeChannelMergerNode/*'/>
	public ChannelMergerNode(BaseAudioContext context, ChannelMergerOptions options) { }
	public ChannelMergerNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ChannelMergerOptions : AudioNodeOptions
{
		public ulong NumberOfInputs;
}

///<include file='Utils/Docs/ChannelSplitterNode/ChannelSplitterNode.generated.xml' path='docs/ChannelSplitterNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ChannelSplitterNode : AudioNode
{
	///<include file='Utils/Docs/ChannelSplitterNodeChannelSplitterNode/ChannelSplitterNodeChannelSplitterNode.generated.xml' path='docs/ChannelSplitterNodeChannelSplitterNode/*'/>
	public ChannelSplitterNode(BaseAudioContext context, ChannelSplitterOptions options) { }
	public ChannelSplitterNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ChannelSplitterOptions : AudioNodeOptions
{
		public ulong NumberOfOutputs;
}

///<include file='Utils/Docs/ConstantSourceNode/ConstantSourceNode.generated.xml' path='docs/ConstantSourceNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ConstantSourceNode : AudioScheduledSourceNode
{
	///<include file='Utils/Docs/ConstantSourceNodeConstantSourceNode/ConstantSourceNodeConstantSourceNode.generated.xml' path='docs/ConstantSourceNodeConstantSourceNode/*'/>
	public ConstantSourceNode(BaseAudioContext context, ConstantSourceOptions options) { }
	///<include file='Utils/Docs/ConstantSourceNodeOffset/ConstantSourceNodeOffset.generated.xml' path='docs/ConstantSourceNodeOffset/*'/>
	public AudioParam Offset { get; }
	public ConstantSourceNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ConstantSourceOptions
{
		public Number Offset;
}

///<include file='Utils/Docs/ConvolverNode/ConvolverNode.generated.xml' path='docs/ConvolverNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ConvolverNode : AudioNode
{
	///<include file='Utils/Docs/ConvolverNodeConvolverNode/ConvolverNodeConvolverNode.generated.xml' path='docs/ConvolverNodeConvolverNode/*'/>
	public ConvolverNode(BaseAudioContext context, ConvolverOptions options) { }
	///<include file='Utils/Docs/ConvolverNodeBuffer/ConvolverNodeBuffer.generated.xml' path='docs/ConvolverNodeBuffer/*'/>
	public AudioBuffer? Buffer { get; set; }
	///<include file='Utils/Docs/ConvolverNodeNormalize/ConvolverNodeNormalize.generated.xml' path='docs/ConvolverNodeNormalize/*'/>
	public bool Normalize { get; set; }
	public ConvolverNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ConvolverOptions : AudioNodeOptions
{
		public AudioBuffer? Buffer;
		public bool DisableNormalization;
}

///<include file='Utils/Docs/DelayNode/DelayNode.generated.xml' path='docs/DelayNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DelayNode : AudioNode
{
	///<include file='Utils/Docs/DelayNodeDelayNode/DelayNodeDelayNode.generated.xml' path='docs/DelayNodeDelayNode/*'/>
	public DelayNode(BaseAudioContext context, DelayOptions options) { }
	///<include file='Utils/Docs/DelayNodeDelayTime/DelayNodeDelayTime.generated.xml' path='docs/DelayNodeDelayTime/*'/>
	public AudioParam DelayTime { get; }
	public DelayNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class DelayOptions : AudioNodeOptions
{
		public Number MaxDelayTime;
		public Number DelayTime;
}

///<include file='Utils/Docs/DynamicsCompressorNode/DynamicsCompressorNode.generated.xml' path='docs/DynamicsCompressorNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DynamicsCompressorNode : AudioNode
{
	///<include file='Utils/Docs/DynamicsCompressorNodeDynamicsCompressorNode/DynamicsCompressorNodeDynamicsCompressorNode.generated.xml' path='docs/DynamicsCompressorNodeDynamicsCompressorNode/*'/>
	public DynamicsCompressorNode(BaseAudioContext context, DynamicsCompressorOptions options) { }
	///<include file='Utils/Docs/DynamicsCompressorNodeThreshold/DynamicsCompressorNodeThreshold.generated.xml' path='docs/DynamicsCompressorNodeThreshold/*'/>
	public AudioParam Threshold { get; }
	///<include file='Utils/Docs/DynamicsCompressorNodeKnee/DynamicsCompressorNodeKnee.generated.xml' path='docs/DynamicsCompressorNodeKnee/*'/>
	public AudioParam Knee { get; }
	///<include file='Utils/Docs/DynamicsCompressorNodeRatio/DynamicsCompressorNodeRatio.generated.xml' path='docs/DynamicsCompressorNodeRatio/*'/>
	public AudioParam Ratio { get; }
	///<include file='Utils/Docs/DynamicsCompressorNodeReduction/DynamicsCompressorNodeReduction.generated.xml' path='docs/DynamicsCompressorNodeReduction/*'/>
	public Number Reduction { get; }
	///<include file='Utils/Docs/DynamicsCompressorNodeAttack/DynamicsCompressorNodeAttack.generated.xml' path='docs/DynamicsCompressorNodeAttack/*'/>
	public AudioParam Attack { get; }
	///<include file='Utils/Docs/DynamicsCompressorNodeRelease/DynamicsCompressorNodeRelease.generated.xml' path='docs/DynamicsCompressorNodeRelease/*'/>
	public AudioParam Release { get; }
	public DynamicsCompressorNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class DynamicsCompressorOptions : AudioNodeOptions
{
		public Number Attack;
		public Number Knee;
		public Number Ratio;
		public Number Release;
		public Number Threshold;
}

///<include file='Utils/Docs/GainNode/GainNode.generated.xml' path='docs/GainNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GainNode : AudioNode
{
	///<include file='Utils/Docs/GainNodeGainNode/GainNodeGainNode.generated.xml' path='docs/GainNodeGainNode/*'/>
	public GainNode(BaseAudioContext context, GainOptions options) { }
	///<include file='Utils/Docs/GainNodeGain/GainNodeGain.generated.xml' path='docs/GainNodeGain/*'/>
	public AudioParam Gain { get; }
	public GainNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GainOptions : AudioNodeOptions
{
		public Number Gain;
}

///<include file='Utils/Docs/IIRFilterNode/IIRFilterNode.generated.xml' path='docs/IIRFilterNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class IIRFilterNode : AudioNode
{
	///<include file='Utils/Docs/IIRFilterNodeIIRFilterNode/IIRFilterNodeIIRFilterNode.generated.xml' path='docs/IIRFilterNodeIIRFilterNode/*'/>
	public IIRFilterNode(BaseAudioContext context, IIRFilterOptions options) { }
	///<include file='Utils/Docs/IIRFilterNodeGetFrequencyResponse/IIRFilterNodeGetFrequencyResponse.generated.xml' path='docs/IIRFilterNodeGetFrequencyResponse/*'/>
	public Undefined GetFrequencyResponse(System.Single frequencyHz, System.Single magResponse, System.Single phaseResponse) { throw new System.NotImplementedException(); }
	public IIRFilterNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class IIRFilterOptions : AudioNodeOptions
{
		public required List<Number> Feedforward;
		public required List<Number> Feedback;
}

///<include file='Utils/Docs/MediaElementAudioSourceNode/MediaElementAudioSourceNode.generated.xml' path='docs/MediaElementAudioSourceNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaElementAudioSourceNode : AudioNode
{
	///<include file='Utils/Docs/MediaElementAudioSourceNodeMediaElementAudioSourceNode/MediaElementAudioSourceNodeMediaElementAudioSourceNode.generated.xml' path='docs/MediaElementAudioSourceNodeMediaElementAudioSourceNode/*'/>
	public MediaElementAudioSourceNode(AudioContext context, MediaElementAudioSourceOptions options) { }
	///<include file='Utils/Docs/MediaElementAudioSourceNodeMediaElement/MediaElementAudioSourceNodeMediaElement.generated.xml' path='docs/MediaElementAudioSourceNodeMediaElement/*'/>
	public HTMLMediaElement MediaElement { get; }
	public MediaElementAudioSourceNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaElementAudioSourceOptions
{
		public required HTMLMediaElement MediaElement;
}

///<include file='Utils/Docs/MediaStreamAudioDestinationNode/MediaStreamAudioDestinationNode.generated.xml' path='docs/MediaStreamAudioDestinationNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaStreamAudioDestinationNode : AudioNode
{
	///<include file='Utils/Docs/MediaStreamAudioDestinationNodeMediaStreamAudioDestinationNo/MediaStreamAudioDestinationNodeMediaStreamAudioDestinationNo.generated.xml' path='docs/MediaStreamAudioDestinationNodeMediaStreamAudioDestinationNo/*'/>
	public MediaStreamAudioDestinationNode(AudioContext context, AudioNodeOptions options) { }
	///<include file='Utils/Docs/MediaStreamAudioDestinationNodeStream/MediaStreamAudioDestinationNodeStream.generated.xml' path='docs/MediaStreamAudioDestinationNodeStream/*'/>
	public Unsupported /*MediaStream*/ Stream { get; }
	public MediaStreamAudioDestinationNode() { }
}

///<include file='Utils/Docs/MediaStreamAudioSourceNode/MediaStreamAudioSourceNode.generated.xml' path='docs/MediaStreamAudioSourceNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaStreamAudioSourceNode : AudioNode
{
	///<include file='Utils/Docs/MediaStreamAudioSourceNodeMediaStreamAudioSourceNode/MediaStreamAudioSourceNodeMediaStreamAudioSourceNode.generated.xml' path='docs/MediaStreamAudioSourceNodeMediaStreamAudioSourceNode/*'/>
	public MediaStreamAudioSourceNode(AudioContext context, MediaStreamAudioSourceOptions options) { }
	///<include file='Utils/Docs/MediaStreamAudioSourceNodeMediaStream/MediaStreamAudioSourceNodeMediaStream.generated.xml' path='docs/MediaStreamAudioSourceNodeMediaStream/*'/>
	public Unsupported /*MediaStream*/ MediaStream { get; }
	public MediaStreamAudioSourceNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaStreamAudioSourceOptions
{
		public required Unsupported /*MediaStream*/ MediaStream;
}

///<include file='Utils/Docs/MediaStreamTrackAudioSourceNode/MediaStreamTrackAudioSourceNode.generated.xml' path='docs/MediaStreamTrackAudioSourceNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaStreamTrackAudioSourceNode : AudioNode
{
	///<include file='Utils/Docs/MediaStreamTrackAudioSourceNodeMediaStreamTrackAudioSourceNo/MediaStreamTrackAudioSourceNodeMediaStreamTrackAudioSourceNo.generated.xml' path='docs/MediaStreamTrackAudioSourceNodeMediaStreamTrackAudioSourceNo/*'/>
	public MediaStreamTrackAudioSourceNode(AudioContext context, MediaStreamTrackAudioSourceOptions options) { }
	public MediaStreamTrackAudioSourceNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaStreamTrackAudioSourceOptions
{
		public required Unsupported /*MediaStreamTrack*/ MediaStreamTrack;
}

public enum OscillatorType
{
	Sine,
	Square,
	Sawtooth,
	Triangle,
	Custom,
}

///<include file='Utils/Docs/OscillatorNode/OscillatorNode.generated.xml' path='docs/OscillatorNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class OscillatorNode : AudioScheduledSourceNode
{
	///<include file='Utils/Docs/OscillatorNodeOscillatorNode/OscillatorNodeOscillatorNode.generated.xml' path='docs/OscillatorNodeOscillatorNode/*'/>
	public OscillatorNode(BaseAudioContext context, OscillatorOptions options) { }
	///<include file='Utils/Docs/OscillatorNodeType/OscillatorNodeType.generated.xml' path='docs/OscillatorNodeType/*'/>
	public OscillatorType Type { get; set; }
	///<include file='Utils/Docs/OscillatorNodeFrequency/OscillatorNodeFrequency.generated.xml' path='docs/OscillatorNodeFrequency/*'/>
	public AudioParam Frequency { get; }
	///<include file='Utils/Docs/OscillatorNodeDetune/OscillatorNodeDetune.generated.xml' path='docs/OscillatorNodeDetune/*'/>
	public AudioParam Detune { get; }
	///<include file='Utils/Docs/OscillatorNodeSetPeriodicWave/OscillatorNodeSetPeriodicWave.generated.xml' path='docs/OscillatorNodeSetPeriodicWave/*'/>
	public Undefined SetPeriodicWave(PeriodicWave periodicWave) { throw new System.NotImplementedException(); }
	public OscillatorNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class OscillatorOptions : AudioNodeOptions
{
		public OscillatorType Type;
		public Number Frequency;
		public Number Detune;
		public PeriodicWave PeriodicWave;
}

public enum PanningModelType
{
	Equalpower,
	HRTF,
}

public enum DistanceModelType
{
	Linear,
	Inverse,
	Exponential,
}

///<include file='Utils/Docs/PannerNode/PannerNode.generated.xml' path='docs/PannerNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PannerNode : AudioNode
{
	///<include file='Utils/Docs/PannerNodePannerNode/PannerNodePannerNode.generated.xml' path='docs/PannerNodePannerNode/*'/>
	public PannerNode(BaseAudioContext context, PannerOptions options) { }
	///<include file='Utils/Docs/PannerNodePanningModel/PannerNodePanningModel.generated.xml' path='docs/PannerNodePanningModel/*'/>
	public PanningModelType PanningModel { get; set; }
	///<include file='Utils/Docs/PannerNodePositionX/PannerNodePositionX.generated.xml' path='docs/PannerNodePositionX/*'/>
	public AudioParam PositionX { get; }
	///<include file='Utils/Docs/PannerNodePositionY/PannerNodePositionY.generated.xml' path='docs/PannerNodePositionY/*'/>
	public AudioParam PositionY { get; }
	///<include file='Utils/Docs/PannerNodePositionZ/PannerNodePositionZ.generated.xml' path='docs/PannerNodePositionZ/*'/>
	public AudioParam PositionZ { get; }
	///<include file='Utils/Docs/PannerNodeOrientationX/PannerNodeOrientationX.generated.xml' path='docs/PannerNodeOrientationX/*'/>
	public AudioParam OrientationX { get; }
	///<include file='Utils/Docs/PannerNodeOrientationY/PannerNodeOrientationY.generated.xml' path='docs/PannerNodeOrientationY/*'/>
	public AudioParam OrientationY { get; }
	///<include file='Utils/Docs/PannerNodeOrientationZ/PannerNodeOrientationZ.generated.xml' path='docs/PannerNodeOrientationZ/*'/>
	public AudioParam OrientationZ { get; }
	///<include file='Utils/Docs/PannerNodeDistanceModel/PannerNodeDistanceModel.generated.xml' path='docs/PannerNodeDistanceModel/*'/>
	public DistanceModelType DistanceModel { get; set; }
	///<include file='Utils/Docs/PannerNodeRefDistance/PannerNodeRefDistance.generated.xml' path='docs/PannerNodeRefDistance/*'/>
	public Number RefDistance { get; set; }
	///<include file='Utils/Docs/PannerNodeMaxDistance/PannerNodeMaxDistance.generated.xml' path='docs/PannerNodeMaxDistance/*'/>
	public Number MaxDistance { get; set; }
	///<include file='Utils/Docs/PannerNodeRolloffFactor/PannerNodeRolloffFactor.generated.xml' path='docs/PannerNodeRolloffFactor/*'/>
	public Number RolloffFactor { get; set; }
	///<include file='Utils/Docs/PannerNodeConeInnerAngle/PannerNodeConeInnerAngle.generated.xml' path='docs/PannerNodeConeInnerAngle/*'/>
	public Number ConeInnerAngle { get; set; }
	///<include file='Utils/Docs/PannerNodeConeOuterAngle/PannerNodeConeOuterAngle.generated.xml' path='docs/PannerNodeConeOuterAngle/*'/>
	public Number ConeOuterAngle { get; set; }
	///<include file='Utils/Docs/PannerNodeConeOuterGain/PannerNodeConeOuterGain.generated.xml' path='docs/PannerNodeConeOuterGain/*'/>
	public Number ConeOuterGain { get; set; }
	///<include file='Utils/Docs/PannerNodeSetPosition/PannerNodeSetPosition.generated.xml' path='docs/PannerNodeSetPosition/*'/>
	public Undefined SetPosition(Number x, Number y, Number z) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/PannerNodeSetOrientation/PannerNodeSetOrientation.generated.xml' path='docs/PannerNodeSetOrientation/*'/>
	public Undefined SetOrientation(Number x, Number y, Number z) { throw new System.NotImplementedException(); }
	public PannerNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PannerOptions : AudioNodeOptions
{
		public PanningModelType PanningModel;
		public DistanceModelType DistanceModel;
		public Number PositionX;
		public Number PositionY;
		public Number PositionZ;
		public Number OrientationX;
		public Number OrientationY;
		public Number OrientationZ;
		public Number RefDistance;
		public Number MaxDistance;
		public Number RolloffFactor;
		public Number ConeInnerAngle;
		public Number ConeOuterAngle;
		public Number ConeOuterGain;
}

///<include file='Utils/Docs/PeriodicWave/PeriodicWave.generated.xml' path='docs/PeriodicWave/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PeriodicWave
{
	///<include file='Utils/Docs/PeriodicWavePeriodicWave/PeriodicWavePeriodicWave.generated.xml' path='docs/PeriodicWavePeriodicWave/*'/>
	public PeriodicWave(BaseAudioContext context, PeriodicWaveOptions options) { }
	public PeriodicWave() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PeriodicWaveConstraints
{
		public bool DisableNormalization;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PeriodicWaveOptions : PeriodicWaveConstraints
{
		public List<Number> Real;
		public List<Number> Imag;
}

///<include file='Utils/Docs/ScriptProcessorNode/ScriptProcessorNode.generated.xml' path='docs/ScriptProcessorNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ScriptProcessorNode : AudioNode
{
		public EventHandler Onaudioprocess { get; set; }
	///<include file='Utils/Docs/ScriptProcessorNodeBufferSize/ScriptProcessorNodeBufferSize.generated.xml' path='docs/ScriptProcessorNodeBufferSize/*'/>
	public long BufferSize { get; }
}

///<include file='Utils/Docs/StereoPannerNode/StereoPannerNode.generated.xml' path='docs/StereoPannerNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class StereoPannerNode : AudioNode
{
	///<include file='Utils/Docs/StereoPannerNodeStereoPannerNode/StereoPannerNodeStereoPannerNode.generated.xml' path='docs/StereoPannerNodeStereoPannerNode/*'/>
	public StereoPannerNode(BaseAudioContext context, StereoPannerOptions options) { }
	///<include file='Utils/Docs/StereoPannerNodePan/StereoPannerNodePan.generated.xml' path='docs/StereoPannerNodePan/*'/>
	public AudioParam Pan { get; }
	public StereoPannerNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class StereoPannerOptions : AudioNodeOptions
{
		public Number Pan;
}

public enum OverSampleType
{
	None,
	_2x,
	_4x,
}

///<include file='Utils/Docs/WaveShaperNode/WaveShaperNode.generated.xml' path='docs/WaveShaperNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WaveShaperNode : AudioNode
{
	///<include file='Utils/Docs/WaveShaperNodeWaveShaperNode/WaveShaperNodeWaveShaperNode.generated.xml' path='docs/WaveShaperNodeWaveShaperNode/*'/>
	public WaveShaperNode(BaseAudioContext context, WaveShaperOptions options) { }
	///<include file='Utils/Docs/WaveShaperNodeCurve/WaveShaperNodeCurve.generated.xml' path='docs/WaveShaperNodeCurve/*'/>
	public System.Single? Curve { get; set; }
	///<include file='Utils/Docs/WaveShaperNodeOversample/WaveShaperNodeOversample.generated.xml' path='docs/WaveShaperNodeOversample/*'/>
	public OverSampleType Oversample { get; set; }
	public WaveShaperNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WaveShaperOptions : AudioNodeOptions
{
		public List<Number> Curve;
		public OverSampleType Oversample;
}

///<include file='Utils/Docs/AudioWorklet/AudioWorklet.generated.xml' path='docs/AudioWorklet/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioWorklet : Worklet
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct AudioWorkletProcessorConstructor
{
}

///<include file='Utils/Docs/AudioWorkletGlobalScope/AudioWorkletGlobalScope.generated.xml' path='docs/AudioWorkletGlobalScope/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioWorkletGlobalScope : WorkletGlobalScope
{
	///<include file='Utils/Docs/AudioWorkletGlobalScopeRegisterProcessor/AudioWorkletGlobalScopeRegisterProcessor.generated.xml' path='docs/AudioWorkletGlobalScopeRegisterProcessor/*'/>
	public Undefined RegisterProcessor(string name, AudioWorkletProcessorConstructor processorCtor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioWorkletGlobalScopeCurrentFrame/AudioWorkletGlobalScopeCurrentFrame.generated.xml' path='docs/AudioWorkletGlobalScopeCurrentFrame/*'/>
	public ulong CurrentFrame { get; }
	///<include file='Utils/Docs/AudioWorkletGlobalScopeCurrentTime/AudioWorkletGlobalScopeCurrentTime.generated.xml' path='docs/AudioWorkletGlobalScopeCurrentTime/*'/>
	public Number CurrentTime { get; }
	///<include file='Utils/Docs/AudioWorkletGlobalScopeSampleRate/AudioWorkletGlobalScopeSampleRate.generated.xml' path='docs/AudioWorkletGlobalScopeSampleRate/*'/>
	public Number SampleRate { get; }
}

///<include file='Utils/Docs/AudioParamMap/AudioParamMap.generated.xml' path='docs/AudioParamMap/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioParamMap
{
	
}

///<include file='Utils/Docs/AudioWorkletNode/AudioWorkletNode.generated.xml' path='docs/AudioWorkletNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioWorkletNode : AudioNode
{
	///<include file='Utils/Docs/AudioWorkletNodeAudioWorkletNode/AudioWorkletNodeAudioWorkletNode.generated.xml' path='docs/AudioWorkletNodeAudioWorkletNode/*'/>
	public AudioWorkletNode(BaseAudioContext context, string name, AudioWorkletNodeOptions options) { }
	///<include file='Utils/Docs/AudioWorkletNodeParameters/AudioWorkletNodeParameters.generated.xml' path='docs/AudioWorkletNodeParameters/*'/>
	public AudioParamMap Parameters { get; }
	///<include file='Utils/Docs/AudioWorkletNodePort/AudioWorkletNodePort.generated.xml' path='docs/AudioWorkletNodePort/*'/>
	public MessagePort Port { get; }
		public EventHandler Onprocessorerror { get; set; }
	public AudioWorkletNode() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioWorkletNodeOptions : AudioNodeOptions
{
		public ulong NumberOfInputs;
		public ulong NumberOfOutputs;
		public List<ulong> OutputChannelCount;
		public Dictionary<string, Number> ParameterData;
		public object ProcessorOptions;
}

///<include file='Utils/Docs/AudioWorkletProcessor/AudioWorkletProcessor.generated.xml' path='docs/AudioWorkletProcessor/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioWorkletProcessor
{
	///<include file='Utils/Docs/AudioWorkletProcessorAudioWorkletProcessor/AudioWorkletProcessorAudioWorkletProcessor.generated.xml' path='docs/AudioWorkletProcessorAudioWorkletProcessor/*'/>
	public AudioWorkletProcessor() { }
	///<include file='Utils/Docs/AudioWorkletProcessorPort/AudioWorkletProcessorPort.generated.xml' path='docs/AudioWorkletProcessorPort/*'/>
	public MessagePort Port { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct AudioWorkletProcessCallback
{
}

///<include file='Utils/Docs/AudioParamDescriptor/AudioParamDescriptor.generated.xml' path='docs/AudioParamDescriptor/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioParamDescriptor
{
		public required string Name;
		public Number DefaultValue;
		public Number MinValue;
		public Number MaxValue;
		public AutomationRate AutomationRate;
}

///<include file='Utils/Docs/PublicKeyCredential/PublicKeyCredential.generated.xml' path='docs/PublicKeyCredential/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PublicKeyCredential : Credential
{
	///<include file='Utils/Docs/PublicKeyCredentialRawId/PublicKeyCredentialRawId.generated.xml' path='docs/PublicKeyCredentialRawId/*'/>
	public byte[] RawId { get; }
	///<include file='Utils/Docs/PublicKeyCredentialResponse/PublicKeyCredentialResponse.generated.xml' path='docs/PublicKeyCredentialResponse/*'/>
	public AuthenticatorResponse Response { get; }
	///<include file='Utils/Docs/PublicKeyCredentialGetClientExtensionResults/PublicKeyCredentialGetClientExtensionResults.generated.xml' path='docs/PublicKeyCredentialGetClientExtensionResults/*'/>
	public AuthenticationExtensionsClientOutputs GetClientExtensionResults() { throw new System.NotImplementedException(); }
}

public partial class CredentialCreationOptions
{
		public PublicKeyCredentialCreationOptions PublicKey;
}

public partial class CredentialRequestOptions
{
		public PublicKeyCredentialRequestOptions PublicKey;
}

///<include file='Utils/Docs/PublicKeyCredential/PublicKeyCredential.generated.xml' path='docs/PublicKeyCredential/*'/>
public partial class PublicKeyCredential
{
		public static Task<bool> IsUserVerifyingPlatformAuthenticatorAvailable() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/AuthenticatorResponse/AuthenticatorResponse.generated.xml' path='docs/AuthenticatorResponse/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AuthenticatorResponse
{
	///<include file='Utils/Docs/AuthenticatorResponseClientDataJSON/AuthenticatorResponseClientDataJSON.generated.xml' path='docs/AuthenticatorResponseClientDataJSON/*'/>
	public byte[] ClientDataJSON { get; }
}

///<include file='Utils/Docs/AuthenticatorAttestationResponse/AuthenticatorAttestationResponse.generated.xml' path='docs/AuthenticatorAttestationResponse/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AuthenticatorAttestationResponse : AuthenticatorResponse
{
	///<include file='Utils/Docs/AuthenticatorAttestationResponseAttestationObject/AuthenticatorAttestationResponseAttestationObject.generated.xml' path='docs/AuthenticatorAttestationResponseAttestationObject/*'/>
	public byte[] AttestationObject { get; }
}

///<include file='Utils/Docs/AuthenticatorAssertionResponse/AuthenticatorAssertionResponse.generated.xml' path='docs/AuthenticatorAssertionResponse/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AuthenticatorAssertionResponse : AuthenticatorResponse
{
	///<include file='Utils/Docs/AuthenticatorAssertionResponseAuthenticatorData/AuthenticatorAssertionResponseAuthenticatorData.generated.xml' path='docs/AuthenticatorAssertionResponseAuthenticatorData/*'/>
	public byte[] AuthenticatorData { get; }
	///<include file='Utils/Docs/AuthenticatorAssertionResponseSignature/AuthenticatorAssertionResponseSignature.generated.xml' path='docs/AuthenticatorAssertionResponseSignature/*'/>
	public byte[] Signature { get; }
	///<include file='Utils/Docs/AuthenticatorAssertionResponseUserHandle/AuthenticatorAssertionResponseUserHandle.generated.xml' path='docs/AuthenticatorAssertionResponseUserHandle/*'/>
	public byte[]? UserHandle { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PublicKeyCredentialParameters
{
		public required PublicKeyCredentialType Type;
		public required COSEAlgorithmIdentifier Alg;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PublicKeyCredentialCreationOptions
{
		public required PublicKeyCredentialRpEntity Rp;
		public required PublicKeyCredentialUserEntity User;
		public required BufferSource Challenge;
		public required List<PublicKeyCredentialParameters> PubKeyCredParams;
		public ulong Timeout;
		public List<PublicKeyCredentialDescriptor> ExcludeCredentials;
		public AuthenticatorSelectionCriteria AuthenticatorSelection;
		public AttestationConveyancePreference Attestation;
		public AuthenticationExtensionsClientInputs Extensions;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PublicKeyCredentialEntity
{
		public required string Name;
		public string Icon;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PublicKeyCredentialRpEntity : PublicKeyCredentialEntity
{
		public string Id;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PublicKeyCredentialUserEntity : PublicKeyCredentialEntity
{
		public required BufferSource Id;
		public required string DisplayName;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AuthenticatorSelectionCriteria
{
		public AuthenticatorAttachment AuthenticatorAttachment;
		public bool RequireResidentKey;
		public UserVerificationRequirement UserVerification;
}

public enum AuthenticatorAttachment
{
	Platform,
	CrossPlatform,
}

public enum AttestationConveyancePreference
{
	None,
	Indirect,
	Direct,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PublicKeyCredentialRequestOptions
{
		public required BufferSource Challenge;
		public ulong Timeout;
		public string RpId;
		public List<PublicKeyCredentialDescriptor> AllowCredentials;
		public UserVerificationRequirement UserVerification;
		public AuthenticationExtensionsClientInputs Extensions;
}

public partial class AuthenticationExtensionsClientInputs
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AuthenticationExtensionsClientOutputs
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class CollectedClientData
{
		public required string Type;
		public required string Challenge;
		public required string Origin;
		public TokenBinding TokenBinding;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class TokenBinding
{
		public required TokenBindingStatus Status;
		public string Id;
}

public enum TokenBindingStatus
{
	Present,
	Supported,
}

public enum PublicKeyCredentialType
{
	PublicKey,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PublicKeyCredentialDescriptor
{
		public required PublicKeyCredentialType Type;
		public required BufferSource Id;
		public List<AuthenticatorTransport> Transports;
}

public enum AuthenticatorTransport
{
	Usb,
	Nfc,
	Ble,
	Internal,
}


public enum UserVerificationRequirement
{
	Required,
	Preferred,
	Discouraged,
}

public partial class AuthenticationExtensionsClientInputs
{
		public string Appid;
}

public partial class AuthenticationExtensionsClientOutputs
{
		public bool Appid;
}

public partial class AuthenticationExtensionsClientInputs
{
		public string TxAuthSimple;
}

public partial class AuthenticationExtensionsClientOutputs
{
		public string TxAuthSimple;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class txAuthGenericArg
{
		public required string ContentType;
		public required byte[] Content;
}

public partial class AuthenticationExtensionsClientInputs
{
		public txAuthGenericArg TxAuthGeneric;
}

public partial class AuthenticationExtensionsClientOutputs
{
		public byte[] TxAuthGeneric;
}


public partial class AuthenticationExtensionsClientInputs
{
		public AuthenticatorSelectionList AuthnSel;
}


public partial class AuthenticationExtensionsClientOutputs
{
		public bool AuthnSel;
}

public partial class AuthenticationExtensionsClientInputs
{
		public bool Exts;
}


public partial class AuthenticationExtensionsClientOutputs
{
		public AuthenticationExtensionsSupported Exts;
}

public partial class AuthenticationExtensionsClientInputs
{
		public bool Uvi;
}

public partial class AuthenticationExtensionsClientOutputs
{
		public byte[] Uvi;
}

public partial class AuthenticationExtensionsClientInputs
{
		public bool Loc;
}

public partial class AuthenticationExtensionsClientOutputs
{
		public Unsupported /*Coordinates*/ Loc;
}

public partial class AuthenticationExtensionsClientInputs
{
		public bool Uvm;
}



public partial class AuthenticationExtensionsClientOutputs
{
		public UvmEntries Uvm;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class authenticatorBiometricPerfBounds
{
		public Number FAR;
		public Number FRR;
}

///<include file='Utils/Docs/AudioDecoder/AudioDecoder.generated.xml' path='docs/AudioDecoder/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioDecoder : EventTarget
{
	///<include file='Utils/Docs/AudioDecoderAudioDecoder/AudioDecoderAudioDecoder.generated.xml' path='docs/AudioDecoderAudioDecoder/*'/>
	public AudioDecoder(AudioDecoderInit init) { }
	///<include file='Utils/Docs/AudioDecoderState/AudioDecoderState.generated.xml' path='docs/AudioDecoderState/*'/>
	public CodecState State { get; }
	///<include file='Utils/Docs/AudioDecoderDecodeQueueSize/AudioDecoderDecodeQueueSize.generated.xml' path='docs/AudioDecoderDecodeQueueSize/*'/>
	public ulong DecodeQueueSize { get; }
		public EventHandler Ondequeue { get; set; }
	///<include file='Utils/Docs/AudioDecoderConfigure/AudioDecoderConfigure.generated.xml' path='docs/AudioDecoderConfigure/*'/>
	public Undefined Configure(AudioDecoderConfig config) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioDecoderDecode/AudioDecoderDecode.generated.xml' path='docs/AudioDecoderDecode/*'/>
	public Undefined Decode(EncodedAudioChunk chunk) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioDecoderFlush/AudioDecoderFlush.generated.xml' path='docs/AudioDecoderFlush/*'/>
	public Task<Undefined> Flush() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioDecoderReset/AudioDecoderReset.generated.xml' path='docs/AudioDecoderReset/*'/>
	public Undefined Reset() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioDecoderClose/AudioDecoderClose.generated.xml' path='docs/AudioDecoderClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
		public static Task<AudioDecoderSupport> IsConfigSupported(AudioDecoderConfig config) { throw new System.NotImplementedException(); }
	public AudioDecoder() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioDecoderInit
{
		public required AudioDataOutputCallback Output;
		public required WebCodecsErrorCallback Error;
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct AudioDataOutputCallback
{
}

///<include file='Utils/Docs/VideoDecoder/VideoDecoder.generated.xml' path='docs/VideoDecoder/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoDecoder : EventTarget
{
	///<include file='Utils/Docs/VideoDecoderVideoDecoder/VideoDecoderVideoDecoder.generated.xml' path='docs/VideoDecoderVideoDecoder/*'/>
	public VideoDecoder(VideoDecoderInit init) { }
	///<include file='Utils/Docs/VideoDecoderState/VideoDecoderState.generated.xml' path='docs/VideoDecoderState/*'/>
	public CodecState State { get; }
	///<include file='Utils/Docs/VideoDecoderDecodeQueueSize/VideoDecoderDecodeQueueSize.generated.xml' path='docs/VideoDecoderDecodeQueueSize/*'/>
	public ulong DecodeQueueSize { get; }
		public EventHandler Ondequeue { get; set; }
	///<include file='Utils/Docs/VideoDecoderConfigure/VideoDecoderConfigure.generated.xml' path='docs/VideoDecoderConfigure/*'/>
	public Undefined Configure(VideoDecoderConfig config) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/VideoDecoderDecode/VideoDecoderDecode.generated.xml' path='docs/VideoDecoderDecode/*'/>
	public Undefined Decode(EncodedVideoChunk chunk) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/VideoDecoderFlush/VideoDecoderFlush.generated.xml' path='docs/VideoDecoderFlush/*'/>
	public Task<Undefined> Flush() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/VideoDecoderReset/VideoDecoderReset.generated.xml' path='docs/VideoDecoderReset/*'/>
	public Undefined Reset() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/VideoDecoderClose/VideoDecoderClose.generated.xml' path='docs/VideoDecoderClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
		public static Task<VideoDecoderSupport> IsConfigSupported(VideoDecoderConfig config) { throw new System.NotImplementedException(); }
	public VideoDecoder() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoDecoderInit
{
		public required VideoFrameOutputCallback Output;
		public required WebCodecsErrorCallback Error;
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct VideoFrameOutputCallback
{
}

///<include file='Utils/Docs/AudioEncoder/AudioEncoder.generated.xml' path='docs/AudioEncoder/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioEncoder : EventTarget
{
	///<include file='Utils/Docs/AudioEncoderAudioEncoder/AudioEncoderAudioEncoder.generated.xml' path='docs/AudioEncoderAudioEncoder/*'/>
	public AudioEncoder(AudioEncoderInit init) { }
	///<include file='Utils/Docs/AudioEncoderState/AudioEncoderState.generated.xml' path='docs/AudioEncoderState/*'/>
	public CodecState State { get; }
	///<include file='Utils/Docs/AudioEncoderEncodeQueueSize/AudioEncoderEncodeQueueSize.generated.xml' path='docs/AudioEncoderEncodeQueueSize/*'/>
	public ulong EncodeQueueSize { get; }
		public EventHandler Ondequeue { get; set; }
	///<include file='Utils/Docs/AudioEncoderConfigure/AudioEncoderConfigure.generated.xml' path='docs/AudioEncoderConfigure/*'/>
	public Undefined Configure(AudioEncoderConfig config) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioEncoderEncode/AudioEncoderEncode.generated.xml' path='docs/AudioEncoderEncode/*'/>
	public Undefined Encode(AudioData data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioEncoderFlush/AudioEncoderFlush.generated.xml' path='docs/AudioEncoderFlush/*'/>
	public Task<Undefined> Flush() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioEncoderReset/AudioEncoderReset.generated.xml' path='docs/AudioEncoderReset/*'/>
	public Undefined Reset() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioEncoderClose/AudioEncoderClose.generated.xml' path='docs/AudioEncoderClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
		public static Task<AudioEncoderSupport> IsConfigSupported(AudioEncoderConfig config) { throw new System.NotImplementedException(); }
	public AudioEncoder() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioEncoderInit
{
		public required EncodedAudioChunkOutputCallback Output;
		public required WebCodecsErrorCallback Error;
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct EncodedAudioChunkOutputCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class EncodedAudioChunkMetadata
{
		public AudioDecoderConfig DecoderConfig;
}

///<include file='Utils/Docs/VideoEncoder/VideoEncoder.generated.xml' path='docs/VideoEncoder/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoEncoder : EventTarget
{
	///<include file='Utils/Docs/VideoEncoderVideoEncoder/VideoEncoderVideoEncoder.generated.xml' path='docs/VideoEncoderVideoEncoder/*'/>
	public VideoEncoder(VideoEncoderInit init) { }
	///<include file='Utils/Docs/VideoEncoderState/VideoEncoderState.generated.xml' path='docs/VideoEncoderState/*'/>
	public CodecState State { get; }
	///<include file='Utils/Docs/VideoEncoderEncodeQueueSize/VideoEncoderEncodeQueueSize.generated.xml' path='docs/VideoEncoderEncodeQueueSize/*'/>
	public ulong EncodeQueueSize { get; }
		public EventHandler Ondequeue { get; set; }
	///<include file='Utils/Docs/VideoEncoderConfigure/VideoEncoderConfigure.generated.xml' path='docs/VideoEncoderConfigure/*'/>
	public Undefined Configure(VideoEncoderConfig config) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/VideoEncoderEncode/VideoEncoderEncode.generated.xml' path='docs/VideoEncoderEncode/*'/>
	public Undefined Encode(VideoFrame frame, VideoEncoderEncodeOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/VideoEncoderFlush/VideoEncoderFlush.generated.xml' path='docs/VideoEncoderFlush/*'/>
	public Task<Undefined> Flush() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/VideoEncoderReset/VideoEncoderReset.generated.xml' path='docs/VideoEncoderReset/*'/>
	public Undefined Reset() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/VideoEncoderClose/VideoEncoderClose.generated.xml' path='docs/VideoEncoderClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
		public static Task<VideoEncoderSupport> IsConfigSupported(VideoEncoderConfig config) { throw new System.NotImplementedException(); }
	public VideoEncoder() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoEncoderInit
{
		public required EncodedVideoChunkOutputCallback Output;
		public required WebCodecsErrorCallback Error;
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct EncodedVideoChunkOutputCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class EncodedVideoChunkMetadata
{
		public VideoDecoderConfig DecoderConfig;
		public SvcOutputMetadata Svc;
		public BufferSource AlphaSideData;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class SvcOutputMetadata
{
		public ulong TemporalLayerId;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioDecoderSupport
{
		public bool Supported;
		public AudioDecoderConfig Config;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoDecoderSupport
{
		public bool Supported;
		public VideoDecoderConfig Config;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioEncoderSupport
{
		public bool Supported;
		public AudioEncoderConfig Config;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoEncoderSupport
{
		public bool Supported;
		public VideoEncoderConfig Config;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioDecoderConfig
{
		public required string Codec;
		public required ulong SampleRate;
		public required ulong NumberOfChannels;
		public BufferSource Description;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoDecoderConfig
{
		public required string Codec;
		public AllowSharedBufferSource Description;
		public ulong CodedWidth;
		public ulong CodedHeight;
		public ulong DisplayAspectWidth;
		public ulong DisplayAspectHeight;
		public VideoColorSpaceInit ColorSpace;
		public HardwareAcceleration HardwareAcceleration;
		public bool OptimizeForLatency;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioEncoderConfig
{
		public required string Codec;
		public ulong SampleRate;
		public ulong NumberOfChannels;
		public ulong Bitrate;
		public BitrateMode BitrateMode;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoEncoderConfig
{
		public required string Codec;
		public required ulong Width;
		public required ulong Height;
		public ulong DisplayWidth;
		public ulong DisplayHeight;
		public ulong Bitrate;
		public Number Framerate;
		public HardwareAcceleration HardwareAcceleration;
		public AlphaOption Alpha;
		public string ScalabilityMode;
		public VideoEncoderBitrateMode BitrateMode;
		public LatencyMode LatencyMode;
}

public enum HardwareAcceleration
{
	NoPreference,
	PreferHardware,
	PreferSoftware,
}

public enum AlphaOption
{
	Keep,
	Discard,
}

public enum LatencyMode
{
	Quality,
	Realtime,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoEncoderEncodeOptions
{
		public bool KeyFrame;
}

public enum VideoEncoderBitrateMode
{
	Constant,
	Variable,
	Quantizer,
}

public enum CodecState
{
	Unconfigured,
	Configured,
	Closed,
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct WebCodecsErrorCallback
{
}

///<include file='Utils/Docs/EncodedAudioChunk/EncodedAudioChunk.generated.xml' path='docs/EncodedAudioChunk/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class EncodedAudioChunk
{
	///<include file='Utils/Docs/EncodedAudioChunkEncodedAudioChunk/EncodedAudioChunkEncodedAudioChunk.generated.xml' path='docs/EncodedAudioChunkEncodedAudioChunk/*'/>
	public EncodedAudioChunk(EncodedAudioChunkInit init) { }
	///<include file='Utils/Docs/EncodedAudioChunkType/EncodedAudioChunkType.generated.xml' path='docs/EncodedAudioChunkType/*'/>
	public EncodedAudioChunkType Type { get; }
	///<include file='Utils/Docs/EncodedAudioChunkTimestamp/EncodedAudioChunkTimestamp.generated.xml' path='docs/EncodedAudioChunkTimestamp/*'/>
	public long Timestamp { get; }
	///<include file='Utils/Docs/EncodedAudioChunkDuration/EncodedAudioChunkDuration.generated.xml' path='docs/EncodedAudioChunkDuration/*'/>
	public ulong? Duration { get; }
	///<include file='Utils/Docs/EncodedAudioChunkByteLength/EncodedAudioChunkByteLength.generated.xml' path='docs/EncodedAudioChunkByteLength/*'/>
	public ulong ByteLength { get; }
	///<include file='Utils/Docs/EncodedAudioChunkCopyTo/EncodedAudioChunkCopyTo.generated.xml' path='docs/EncodedAudioChunkCopyTo/*'/>
	public Undefined CopyTo(AllowSharedBufferSource destination) { throw new System.NotImplementedException(); }
	public EncodedAudioChunk() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class EncodedAudioChunkInit
{
		public required EncodedAudioChunkType Type;
		public required long Timestamp;
		public ulong Duration;
		public required BufferSource Data;
		public List<byte[]> Transfer;
}

///<include file='Utils/Docs/EncodedAudioChunkType/EncodedAudioChunkType.generated.xml' path='docs/EncodedAudioChunkType/*'/>
public enum EncodedAudioChunkType
{
	Key,
	Delta,
}

///<include file='Utils/Docs/EncodedVideoChunk/EncodedVideoChunk.generated.xml' path='docs/EncodedVideoChunk/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class EncodedVideoChunk
{
	///<include file='Utils/Docs/EncodedVideoChunkEncodedVideoChunk/EncodedVideoChunkEncodedVideoChunk.generated.xml' path='docs/EncodedVideoChunkEncodedVideoChunk/*'/>
	public EncodedVideoChunk(EncodedVideoChunkInit init) { }
	///<include file='Utils/Docs/EncodedVideoChunkType/EncodedVideoChunkType.generated.xml' path='docs/EncodedVideoChunkType/*'/>
	public EncodedVideoChunkType Type { get; }
	///<include file='Utils/Docs/EncodedVideoChunkTimestamp/EncodedVideoChunkTimestamp.generated.xml' path='docs/EncodedVideoChunkTimestamp/*'/>
	public long Timestamp { get; }
	///<include file='Utils/Docs/EncodedVideoChunkDuration/EncodedVideoChunkDuration.generated.xml' path='docs/EncodedVideoChunkDuration/*'/>
	public ulong? Duration { get; }
	///<include file='Utils/Docs/EncodedVideoChunkByteLength/EncodedVideoChunkByteLength.generated.xml' path='docs/EncodedVideoChunkByteLength/*'/>
	public ulong ByteLength { get; }
	///<include file='Utils/Docs/EncodedVideoChunkCopyTo/EncodedVideoChunkCopyTo.generated.xml' path='docs/EncodedVideoChunkCopyTo/*'/>
	public Undefined CopyTo(AllowSharedBufferSource destination) { throw new System.NotImplementedException(); }
	public EncodedVideoChunk() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class EncodedVideoChunkInit
{
		public required EncodedVideoChunkType Type;
		public required long Timestamp;
		public ulong Duration;
		public required AllowSharedBufferSource Data;
		public List<byte[]> Transfer;
}

///<include file='Utils/Docs/EncodedVideoChunkType/EncodedVideoChunkType.generated.xml' path='docs/EncodedVideoChunkType/*'/>
public enum EncodedVideoChunkType
{
	Key,
	Delta,
}

///<include file='Utils/Docs/AudioData/AudioData.generated.xml' path='docs/AudioData/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioData
{
	///<include file='Utils/Docs/AudioDataAudioData/AudioDataAudioData.generated.xml' path='docs/AudioDataAudioData/*'/>
	public AudioData(AudioDataInit init) { }
	///<include file='Utils/Docs/AudioDataFormat/AudioDataFormat.generated.xml' path='docs/AudioDataFormat/*'/>
	public AudioSampleFormat? Format { get; }
	///<include file='Utils/Docs/AudioDataSampleRate/AudioDataSampleRate.generated.xml' path='docs/AudioDataSampleRate/*'/>
	public Number SampleRate { get; }
	///<include file='Utils/Docs/AudioDataNumberOfFrames/AudioDataNumberOfFrames.generated.xml' path='docs/AudioDataNumberOfFrames/*'/>
	public ulong NumberOfFrames { get; }
	///<include file='Utils/Docs/AudioDataNumberOfChannels/AudioDataNumberOfChannels.generated.xml' path='docs/AudioDataNumberOfChannels/*'/>
	public ulong NumberOfChannels { get; }
	///<include file='Utils/Docs/AudioDataDuration/AudioDataDuration.generated.xml' path='docs/AudioDataDuration/*'/>
	public ulong Duration { get; }
	///<include file='Utils/Docs/AudioDataTimestamp/AudioDataTimestamp.generated.xml' path='docs/AudioDataTimestamp/*'/>
	public long Timestamp { get; }
	///<include file='Utils/Docs/AudioDataAllocationSize/AudioDataAllocationSize.generated.xml' path='docs/AudioDataAllocationSize/*'/>
	public ulong AllocationSize(AudioDataCopyToOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioDataCopyTo/AudioDataCopyTo.generated.xml' path='docs/AudioDataCopyTo/*'/>
	public Undefined CopyTo(AllowSharedBufferSource destination, AudioDataCopyToOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioDataClone/AudioDataClone.generated.xml' path='docs/AudioDataClone/*'/>
	public AudioData Clone() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AudioDataClose/AudioDataClose.generated.xml' path='docs/AudioDataClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
	public AudioData() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioDataInit
{
		public required AudioSampleFormat Format;
		public required Number SampleRate;
		public required ulong NumberOfFrames;
		public required ulong NumberOfChannels;
		public required long Timestamp;
		public required BufferSource Data;
		public List<byte[]> Transfer;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioDataCopyToOptions
{
		public required ulong PlaneIndex;
		public ulong FrameOffset;
		public ulong FrameCount;
		public AudioSampleFormat Format;
}

public enum AudioSampleFormat
{
	U8,
	S16,
	S32,
	F32,
	U8Planar,
	S16Planar,
	S32Planar,
	F32Planar,
}

///<include file='Utils/Docs/VideoFrame/VideoFrame.generated.xml' path='docs/VideoFrame/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoFrame
{
	///<include file='Utils/Docs/VideoFrameVideoFrame/VideoFrameVideoFrame.generated.xml' path='docs/VideoFrameVideoFrame/*'/>
	public VideoFrame(CanvasImageSource image, VideoFrameInit init) { }
	///<include file='Utils/Docs/VideoFrameVideoFrame/VideoFrameVideoFrame.generated.xml' path='docs/VideoFrameVideoFrame/*'/>
	public VideoFrame(AllowSharedBufferSource data, VideoFrameBufferInit init) { }
	///<include file='Utils/Docs/VideoFrameFormat/VideoFrameFormat.generated.xml' path='docs/VideoFrameFormat/*'/>
	public VideoPixelFormat? Format { get; }
	///<include file='Utils/Docs/VideoFrameCodedWidth/VideoFrameCodedWidth.generated.xml' path='docs/VideoFrameCodedWidth/*'/>
	public ulong CodedWidth { get; }
	///<include file='Utils/Docs/VideoFrameCodedHeight/VideoFrameCodedHeight.generated.xml' path='docs/VideoFrameCodedHeight/*'/>
	public ulong CodedHeight { get; }
	///<include file='Utils/Docs/VideoFrameCodedRect/VideoFrameCodedRect.generated.xml' path='docs/VideoFrameCodedRect/*'/>
	public DOMRectReadOnly? CodedRect { get; }
	///<include file='Utils/Docs/VideoFrameVisibleRect/VideoFrameVisibleRect.generated.xml' path='docs/VideoFrameVisibleRect/*'/>
	public DOMRectReadOnly? VisibleRect { get; }
	///<include file='Utils/Docs/VideoFrameDisplayWidth/VideoFrameDisplayWidth.generated.xml' path='docs/VideoFrameDisplayWidth/*'/>
	public ulong DisplayWidth { get; }
	///<include file='Utils/Docs/VideoFrameDisplayHeight/VideoFrameDisplayHeight.generated.xml' path='docs/VideoFrameDisplayHeight/*'/>
	public ulong DisplayHeight { get; }
	///<include file='Utils/Docs/VideoFrameDuration/VideoFrameDuration.generated.xml' path='docs/VideoFrameDuration/*'/>
	public ulong? Duration { get; }
	///<include file='Utils/Docs/VideoFrameTimestamp/VideoFrameTimestamp.generated.xml' path='docs/VideoFrameTimestamp/*'/>
	public long Timestamp { get; }
	///<include file='Utils/Docs/VideoFrameColorSpace/VideoFrameColorSpace.generated.xml' path='docs/VideoFrameColorSpace/*'/>
	public VideoColorSpace ColorSpace { get; }
		public VideoFrameMetadata Metadata() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/VideoFrameAllocationSize/VideoFrameAllocationSize.generated.xml' path='docs/VideoFrameAllocationSize/*'/>
	public ulong AllocationSize(VideoFrameCopyToOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/VideoFrameCopyTo/VideoFrameCopyTo.generated.xml' path='docs/VideoFrameCopyTo/*'/>
	public Task<List<PlaneLayout>> CopyTo(AllowSharedBufferSource destination, VideoFrameCopyToOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/VideoFrameClone/VideoFrameClone.generated.xml' path='docs/VideoFrameClone/*'/>
	public VideoFrame Clone() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/VideoFrameClose/VideoFrameClose.generated.xml' path='docs/VideoFrameClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
	public VideoFrame() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoFrameInit
{
		public ulong Duration;
		public long Timestamp;
		public AlphaOption Alpha;
		public DOMRectInit VisibleRect;
		public ulong DisplayWidth;
		public ulong DisplayHeight;
		public VideoFrameMetadata Metadata;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoFrameBufferInit
{
		public required VideoPixelFormat Format;
		public required ulong CodedWidth;
		public required ulong CodedHeight;
		public required long Timestamp;
		public ulong Duration;
		public List<PlaneLayout> Layout;
		public DOMRectInit VisibleRect;
		public ulong DisplayWidth;
		public ulong DisplayHeight;
		public VideoColorSpaceInit ColorSpace;
		public List<byte[]> Transfer;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoFrameMetadata
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoFrameCopyToOptions
{
		public DOMRectInit Rect;
		public List<PlaneLayout> Layout;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PlaneLayout
{
		public required ulong Offset;
		public required ulong Stride;
}

public enum VideoPixelFormat
{
	I420,
	I420A,
	I422,
	I444,
	NV12,
	RGBA,
	RGBX,
	BGRA,
	BGRX,
}

///<include file='Utils/Docs/VideoColorSpace/VideoColorSpace.generated.xml' path='docs/VideoColorSpace/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoColorSpace
{
	///<include file='Utils/Docs/VideoColorSpaceVideoColorSpace/VideoColorSpaceVideoColorSpace.generated.xml' path='docs/VideoColorSpaceVideoColorSpace/*'/>
	public VideoColorSpace(VideoColorSpaceInit init) { }
	///<include file='Utils/Docs/VideoColorSpacePrimaries/VideoColorSpacePrimaries.generated.xml' path='docs/VideoColorSpacePrimaries/*'/>
	public VideoColorPrimaries? Primaries { get; }
	///<include file='Utils/Docs/VideoColorSpaceTransfer/VideoColorSpaceTransfer.generated.xml' path='docs/VideoColorSpaceTransfer/*'/>
	public VideoTransferCharacteristics? Transfer { get; }
	///<include file='Utils/Docs/VideoColorSpaceMatrix/VideoColorSpaceMatrix.generated.xml' path='docs/VideoColorSpaceMatrix/*'/>
	public VideoMatrixCoefficients? Matrix { get; }
	///<include file='Utils/Docs/VideoColorSpaceFullRange/VideoColorSpaceFullRange.generated.xml' path='docs/VideoColorSpaceFullRange/*'/>
	public bool? FullRange { get; }
	///<include file='Utils/Docs/VideoColorSpaceToJSON/VideoColorSpaceToJSON.generated.xml' path='docs/VideoColorSpaceToJSON/*'/>
	public VideoColorSpaceInit ToJSON() { throw new System.NotImplementedException(); }
	public VideoColorSpace() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoColorSpaceInit
{
		public VideoColorPrimaries? Primaries;
		public VideoTransferCharacteristics? Transfer;
		public VideoMatrixCoefficients? Matrix;
		public bool? FullRange;
}

public enum VideoColorPrimaries
{
	Bt709,
	Bt470bg,
	Smpte170m,
	Bt2020,
	Smpte432,
}

public enum VideoTransferCharacteristics
{
	Bt709,
	Smpte170m,
	Iec6196621,
	Linear,
	Pq,
	Hlg,
}

public enum VideoMatrixCoefficients
{
	Rgb,
	Bt709,
	Bt470bg,
	Smpte170m,
	Bt2020Ncl,
}

///<include file='Utils/Docs/ImageDecoder/ImageDecoder.generated.xml' path='docs/ImageDecoder/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageDecoder
{
	///<include file='Utils/Docs/ImageDecoderImageDecoder/ImageDecoderImageDecoder.generated.xml' path='docs/ImageDecoderImageDecoder/*'/>
	public ImageDecoder(ImageDecoderInit init) { }
	///<include file='Utils/Docs/ImageDecoderType/ImageDecoderType.generated.xml' path='docs/ImageDecoderType/*'/>
	public string Type { get; }
	///<include file='Utils/Docs/ImageDecoderComplete/ImageDecoderComplete.generated.xml' path='docs/ImageDecoderComplete/*'/>
	public bool Complete { get; }
	///<include file='Utils/Docs/ImageDecoderCompleted/ImageDecoderCompleted.generated.xml' path='docs/ImageDecoderCompleted/*'/>
	public Task<Undefined> Completed { get; }
	///<include file='Utils/Docs/ImageDecoderTracks/ImageDecoderTracks.generated.xml' path='docs/ImageDecoderTracks/*'/>
	public ImageTrackList Tracks { get; }
	///<include file='Utils/Docs/ImageDecoderDecode/ImageDecoderDecode.generated.xml' path='docs/ImageDecoderDecode/*'/>
	public Task<ImageDecodeResult> Decode(ImageDecodeOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ImageDecoderReset/ImageDecoderReset.generated.xml' path='docs/ImageDecoderReset/*'/>
	public Undefined Reset() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ImageDecoderClose/ImageDecoderClose.generated.xml' path='docs/ImageDecoderClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
		public static Task<bool> IsTypeSupported(string type) { throw new System.NotImplementedException(); }
	public ImageDecoder() { }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageDecoderInit
{
		public required string Type;
		public required ImageBufferSource Data;
		public ColorSpaceConversion ColorSpaceConversion;
		public ulong DesiredWidth;
		public ulong DesiredHeight;
		public bool PreferAnimation;
		public List<byte[]> Transfer;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageDecodeOptions
{
		public ulong FrameIndex;
		public bool CompleteFramesOnly;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageDecodeResult
{
		public required VideoFrame Image;
		public required bool Complete;
}

///<include file='Utils/Docs/ImageTrackList/ImageTrackList.generated.xml' path='docs/ImageTrackList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageTrackList
{
	
	///<include file='Utils/Docs/ImageTrackListReady/ImageTrackListReady.generated.xml' path='docs/ImageTrackListReady/*'/>
	public Task<Undefined> Ready { get; }
	///<include file='Utils/Docs/ImageTrackListLength/ImageTrackListLength.generated.xml' path='docs/ImageTrackListLength/*'/>
	public ulong Length { get; }
	///<include file='Utils/Docs/ImageTrackListSelectedIndex/ImageTrackListSelectedIndex.generated.xml' path='docs/ImageTrackListSelectedIndex/*'/>
	public long SelectedIndex { get; }
	///<include file='Utils/Docs/ImageTrackListSelectedTrack/ImageTrackListSelectedTrack.generated.xml' path='docs/ImageTrackListSelectedTrack/*'/>
	public ImageTrack? SelectedTrack { get; }
}

///<include file='Utils/Docs/ImageTrack/ImageTrack.generated.xml' path='docs/ImageTrack/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageTrack
{
	///<include file='Utils/Docs/ImageTrackAnimated/ImageTrackAnimated.generated.xml' path='docs/ImageTrackAnimated/*'/>
	public bool Animated { get; }
	///<include file='Utils/Docs/ImageTrackFrameCount/ImageTrackFrameCount.generated.xml' path='docs/ImageTrackFrameCount/*'/>
	public ulong FrameCount { get; }
	///<include file='Utils/Docs/ImageTrackRepetitionCount/ImageTrackRepetitionCount.generated.xml' path='docs/ImageTrackRepetitionCount/*'/>
	public float RepetitionCount { get; }
	///<include file='Utils/Docs/ImageTrackSelected/ImageTrackSelected.generated.xml' path='docs/ImageTrackSelected/*'/>
	public bool Selected { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GPUObjectBase
{
		public string Label { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUObjectDescriptorBase
{
		public string Label;
}

///<include file='Utils/Docs/GPUSupportedLimits/GPUSupportedLimits.generated.xml' path='docs/GPUSupportedLimits/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUSupportedLimits
{
		public ulong MaxTextureDimension1D { get; }
		public ulong MaxTextureDimension2D { get; }
		public ulong MaxTextureDimension3D { get; }
		public ulong MaxTextureArrayLayers { get; }
		public ulong MaxBindGroups { get; }
		public ulong MaxBindGroupsPlusVertexBuffers { get; }
		public ulong MaxBindingsPerBindGroup { get; }
		public ulong MaxDynamicUniformBuffersPerPipelineLayout { get; }
		public ulong MaxDynamicStorageBuffersPerPipelineLayout { get; }
		public ulong MaxSampledTexturesPerShaderStage { get; }
		public ulong MaxSamplersPerShaderStage { get; }
		public ulong MaxStorageBuffersPerShaderStage { get; }
		public ulong MaxStorageTexturesPerShaderStage { get; }
		public ulong MaxUniformBuffersPerShaderStage { get; }
		public ulong MaxUniformBufferBindingSize { get; }
		public ulong MaxStorageBufferBindingSize { get; }
		public ulong MinUniformBufferOffsetAlignment { get; }
		public ulong MinStorageBufferOffsetAlignment { get; }
		public ulong MaxVertexBuffers { get; }
		public ulong MaxBufferSize { get; }
		public ulong MaxVertexAttributes { get; }
		public ulong MaxVertexBufferArrayStride { get; }
		public ulong MaxInterStageShaderComponents { get; }
		public ulong MaxInterStageShaderVariables { get; }
		public ulong MaxColorAttachments { get; }
		public ulong MaxColorAttachmentBytesPerSample { get; }
		public ulong MaxComputeWorkgroupStorageSize { get; }
		public ulong MaxComputeInvocationsPerWorkgroup { get; }
		public ulong MaxComputeWorkgroupSizeX { get; }
		public ulong MaxComputeWorkgroupSizeY { get; }
		public ulong MaxComputeWorkgroupSizeZ { get; }
		public ulong MaxComputeWorkgroupsPerDimension { get; }
}

///<include file='Utils/Docs/GPUSupportedFeatures/GPUSupportedFeatures.generated.xml' path='docs/GPUSupportedFeatures/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUSupportedFeatures
{
	
}

///<include file='Utils/Docs/WGSLLanguageFeatures/WGSLLanguageFeatures.generated.xml' path='docs/WGSLLanguageFeatures/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WGSLLanguageFeatures
{
	
}

///<include file='Utils/Docs/GPUAdapterInfo/GPUAdapterInfo.generated.xml' path='docs/GPUAdapterInfo/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUAdapterInfo
{
	///<include file='Utils/Docs/GPUAdapterInfoVendor/GPUAdapterInfoVendor.generated.xml' path='docs/GPUAdapterInfoVendor/*'/>
	public string Vendor { get; }
	///<include file='Utils/Docs/GPUAdapterInfoArchitecture/GPUAdapterInfoArchitecture.generated.xml' path='docs/GPUAdapterInfoArchitecture/*'/>
	public string Architecture { get; }
	///<include file='Utils/Docs/GPUAdapterInfoDevice/GPUAdapterInfoDevice.generated.xml' path='docs/GPUAdapterInfoDevice/*'/>
	public string Device { get; }
	///<include file='Utils/Docs/GPUAdapterInfoDescription/GPUAdapterInfoDescription.generated.xml' path='docs/GPUAdapterInfoDescription/*'/>
	public string Description { get; }
}

///<include file='Utils/Docs/NavigatorGPU/NavigatorGPU.generated.xml' path='docs/NavigatorGPU/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorGPU
{
		public GPU Gpu { get { throw new System.NotImplementedException(); } }
}



///<include file='Utils/Docs/GPU/GPU.generated.xml' path='docs/GPU/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPU
{
	///<include file='Utils/Docs/GPURequestAdapter/GPURequestAdapter.generated.xml' path='docs/GPURequestAdapter/*'/>
	public Task<GPUAdapter?> RequestAdapter(GPURequestAdapterOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUGetPreferredCanvasFormat/GPUGetPreferredCanvasFormat.generated.xml' path='docs/GPUGetPreferredCanvasFormat/*'/>
	public GPUTextureFormat GetPreferredCanvasFormat() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUWgslLanguageFeatures/GPUWgslLanguageFeatures.generated.xml' path='docs/GPUWgslLanguageFeatures/*'/>
	public WGSLLanguageFeatures WgslLanguageFeatures { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPURequestAdapterOptions
{
		public GPUPowerPreference PowerPreference;
		public bool ForceFallbackAdapter;
}

public enum GPUPowerPreference
{
	LowPower,
	HighPerformance,
}

///<include file='Utils/Docs/GPUAdapter/GPUAdapter.generated.xml' path='docs/GPUAdapter/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUAdapter
{
	///<include file='Utils/Docs/GPUAdapterFeatures/GPUAdapterFeatures.generated.xml' path='docs/GPUAdapterFeatures/*'/>
	public GPUSupportedFeatures Features { get; }
	///<include file='Utils/Docs/GPUAdapterLimits/GPUAdapterLimits.generated.xml' path='docs/GPUAdapterLimits/*'/>
	public GPUSupportedLimits Limits { get; }
	///<include file='Utils/Docs/GPUAdapterIsFallbackAdapter/GPUAdapterIsFallbackAdapter.generated.xml' path='docs/GPUAdapterIsFallbackAdapter/*'/>
	public bool IsFallbackAdapter { get; }
	///<include file='Utils/Docs/GPUAdapterRequestDevice/GPUAdapterRequestDevice.generated.xml' path='docs/GPUAdapterRequestDevice/*'/>
	public Task<GPUDevice> RequestDevice(GPUDeviceDescriptor descriptor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUAdapterRequestAdapterInfo/GPUAdapterRequestAdapterInfo.generated.xml' path='docs/GPUAdapterRequestAdapterInfo/*'/>
	public Task<GPUAdapterInfo> RequestAdapterInfo() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUDeviceDescriptor : GPUObjectDescriptorBase
{
		public List<GPUFeatureName> RequiredFeatures;
		public Dictionary<string, GPUSize64> RequiredLimits;
		public GPUQueueDescriptor DefaultQueue;
}

public enum GPUFeatureName
{
	DepthClipControl,
	Depth32floatStencil8,
	TextureCompressionBc,
	TextureCompressionEtc2,
	TextureCompressionAstc,
	TimestampQuery,
	IndirectFirstInstance,
	ShaderF16,
	Rg11b10ufloatRenderable,
	Bgra8unormStorage,
	Float32Filterable,
}

///<include file='Utils/Docs/GPUDevice/GPUDevice.generated.xml' path='docs/GPUDevice/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUDevice : EventTarget, GPUObjectBase
{
	///<include file='Utils/Docs/GPUDeviceFeatures/GPUDeviceFeatures.generated.xml' path='docs/GPUDeviceFeatures/*'/>
	public GPUSupportedFeatures Features { get; }
	///<include file='Utils/Docs/GPUDeviceLimits/GPUDeviceLimits.generated.xml' path='docs/GPUDeviceLimits/*'/>
	public GPUSupportedLimits Limits { get; }
	///<include file='Utils/Docs/GPUDeviceQueue/GPUDeviceQueue.generated.xml' path='docs/GPUDeviceQueue/*'/>
	public GPUQueue Queue { get; }
	///<include file='Utils/Docs/GPUDeviceDestroy/GPUDeviceDestroy.generated.xml' path='docs/GPUDeviceDestroy/*'/>
	public Undefined Destroy() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUDeviceCreateBuffer/GPUDeviceCreateBuffer.generated.xml' path='docs/GPUDeviceCreateBuffer/*'/>
	public GPUBuffer CreateBuffer(GPUBufferDescriptor descriptor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUDeviceCreateTexture/GPUDeviceCreateTexture.generated.xml' path='docs/GPUDeviceCreateTexture/*'/>
	public GPUTexture CreateTexture(GPUTextureDescriptor descriptor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUDeviceCreateSampler/GPUDeviceCreateSampler.generated.xml' path='docs/GPUDeviceCreateSampler/*'/>
	public GPUSampler CreateSampler(GPUSamplerDescriptor descriptor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUDeviceImportExternalTexture/GPUDeviceImportExternalTexture.generated.xml' path='docs/GPUDeviceImportExternalTexture/*'/>
	public GPUExternalTexture ImportExternalTexture(GPUExternalTextureDescriptor descriptor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUDeviceCreateBindGroupLayout/GPUDeviceCreateBindGroupLayout.generated.xml' path='docs/GPUDeviceCreateBindGroupLayout/*'/>
	public GPUBindGroupLayout CreateBindGroupLayout(GPUBindGroupLayoutDescriptor descriptor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUDeviceCreatePipelineLayout/GPUDeviceCreatePipelineLayout.generated.xml' path='docs/GPUDeviceCreatePipelineLayout/*'/>
	public GPUPipelineLayout CreatePipelineLayout(GPUPipelineLayoutDescriptor descriptor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUDeviceCreateBindGroup/GPUDeviceCreateBindGroup.generated.xml' path='docs/GPUDeviceCreateBindGroup/*'/>
	public GPUBindGroup CreateBindGroup(GPUBindGroupDescriptor descriptor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUDeviceCreateShaderModule/GPUDeviceCreateShaderModule.generated.xml' path='docs/GPUDeviceCreateShaderModule/*'/>
	public GPUShaderModule CreateShaderModule(GPUShaderModuleDescriptor descriptor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUDeviceCreateComputePipeline/GPUDeviceCreateComputePipeline.generated.xml' path='docs/GPUDeviceCreateComputePipeline/*'/>
	public GPUComputePipeline CreateComputePipeline(GPUComputePipelineDescriptor descriptor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUDeviceCreateRenderPipeline/GPUDeviceCreateRenderPipeline.generated.xml' path='docs/GPUDeviceCreateRenderPipeline/*'/>
	public GPURenderPipeline CreateRenderPipeline(GPURenderPipelineDescriptor descriptor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUDeviceCreateComputePipelineAsync/GPUDeviceCreateComputePipelineAsync.generated.xml' path='docs/GPUDeviceCreateComputePipelineAsync/*'/>
	public Task<GPUComputePipeline> CreateComputePipelineAsync(GPUComputePipelineDescriptor descriptor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUDeviceCreateRenderPipelineAsync/GPUDeviceCreateRenderPipelineAsync.generated.xml' path='docs/GPUDeviceCreateRenderPipelineAsync/*'/>
	public Task<GPURenderPipeline> CreateRenderPipelineAsync(GPURenderPipelineDescriptor descriptor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUDeviceCreateCommandEncoder/GPUDeviceCreateCommandEncoder.generated.xml' path='docs/GPUDeviceCreateCommandEncoder/*'/>
	public GPUCommandEncoder CreateCommandEncoder(GPUCommandEncoderDescriptor descriptor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUDeviceCreateRenderBundleEncoder/GPUDeviceCreateRenderBundleEncoder.generated.xml' path='docs/GPUDeviceCreateRenderBundleEncoder/*'/>
	public GPURenderBundleEncoder CreateRenderBundleEncoder(GPURenderBundleEncoderDescriptor descriptor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUDeviceCreateQuerySet/GPUDeviceCreateQuerySet.generated.xml' path='docs/GPUDeviceCreateQuerySet/*'/>
	public GPUQuerySet CreateQuerySet(GPUQuerySetDescriptor descriptor) { throw new System.NotImplementedException(); }
}


///<include file='Utils/Docs/GPUBuffer/GPUBuffer.generated.xml' path='docs/GPUBuffer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUBuffer
{
	///<include file='Utils/Docs/GPUBufferSize/GPUBufferSize.generated.xml' path='docs/GPUBufferSize/*'/>
	public GPUSize64Out Size { get; }
	///<include file='Utils/Docs/GPUBufferUsage/GPUBufferUsage.generated.xml' path='docs/GPUBufferUsage/*'/>
	public GPUFlagsConstant Usage { get; }
	///<include file='Utils/Docs/GPUBufferMapState/GPUBufferMapState.generated.xml' path='docs/GPUBufferMapState/*'/>
	public GPUBufferMapState MapState { get; }
	///<include file='Utils/Docs/GPUBufferMapAsync/GPUBufferMapAsync.generated.xml' path='docs/GPUBufferMapAsync/*'/>
	public Task<Undefined> MapAsync(GPUMapModeFlags mode, GPUSize64 offset, GPUSize64 size) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUBufferGetMappedRange/GPUBufferGetMappedRange.generated.xml' path='docs/GPUBufferGetMappedRange/*'/>
	public byte[] GetMappedRange(GPUSize64 offset, GPUSize64 size) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUBufferUnmap/GPUBufferUnmap.generated.xml' path='docs/GPUBufferUnmap/*'/>
	public Undefined Unmap() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUBufferDestroy/GPUBufferDestroy.generated.xml' path='docs/GPUBufferDestroy/*'/>
	public Undefined Destroy() { throw new System.NotImplementedException(); }
}


///<include file='Utils/Docs/GPUBufferMapState/GPUBufferMapState.generated.xml' path='docs/GPUBufferMapState/*'/>
public enum GPUBufferMapState
{
	Unmapped,
	Pending,
	Mapped,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUBufferDescriptor : GPUObjectDescriptorBase
{
		public required GPUSize64 Size;
		public required GPUBufferUsageFlags Usage;
		public bool MappedAtCreation;
}


///<include file='Utils/Docs/GPUBufferUsage/GPUBufferUsage.generated.xml' path='docs/GPUBufferUsage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUBufferUsage
{
		public const GPUFlagsConstant MAP_READ = 0x0001;
		public const GPUFlagsConstant MAP_WRITE = 0x0002;
		public const GPUFlagsConstant COPY_SRC = 0x0004;
		public const GPUFlagsConstant COPY_DST = 0x0008;
		public const GPUFlagsConstant INDEX = 0x0010;
		public const GPUFlagsConstant VERTEX = 0x0020;
		public const GPUFlagsConstant UNIFORM = 0x0040;
		public const GPUFlagsConstant STORAGE = 0x0080;
		public const GPUFlagsConstant INDIRECT = 0x0100;
		public const GPUFlagsConstant QUERY_RESOLVE = 0x0200;
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUMapMode
{
		public const GPUFlagsConstant READ = 0x0001;
		public const GPUFlagsConstant WRITE = 0x0002;
}

///<include file='Utils/Docs/GPUTexture/GPUTexture.generated.xml' path='docs/GPUTexture/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUTexture
{
	///<include file='Utils/Docs/GPUTextureCreateView/GPUTextureCreateView.generated.xml' path='docs/GPUTextureCreateView/*'/>
	public GPUTextureView CreateView(GPUTextureViewDescriptor descriptor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUTextureDestroy/GPUTextureDestroy.generated.xml' path='docs/GPUTextureDestroy/*'/>
	public Undefined Destroy() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUTextureWidth/GPUTextureWidth.generated.xml' path='docs/GPUTextureWidth/*'/>
	public GPUIntegerCoordinateOut Width { get; }
	///<include file='Utils/Docs/GPUTextureHeight/GPUTextureHeight.generated.xml' path='docs/GPUTextureHeight/*'/>
	public GPUIntegerCoordinateOut Height { get; }
	///<include file='Utils/Docs/GPUTextureDepthOrArrayLayers/GPUTextureDepthOrArrayLayers.generated.xml' path='docs/GPUTextureDepthOrArrayLayers/*'/>
	public GPUIntegerCoordinateOut DepthOrArrayLayers { get; }
	///<include file='Utils/Docs/GPUTextureMipLevelCount/GPUTextureMipLevelCount.generated.xml' path='docs/GPUTextureMipLevelCount/*'/>
	public GPUIntegerCoordinateOut MipLevelCount { get; }
	///<include file='Utils/Docs/GPUTextureSampleCount/GPUTextureSampleCount.generated.xml' path='docs/GPUTextureSampleCount/*'/>
	public GPUSize32Out SampleCount { get; }
	///<include file='Utils/Docs/GPUTextureDimension/GPUTextureDimension.generated.xml' path='docs/GPUTextureDimension/*'/>
	public GPUTextureDimension Dimension { get; }
	///<include file='Utils/Docs/GPUTextureFormat/GPUTextureFormat.generated.xml' path='docs/GPUTextureFormat/*'/>
	public GPUTextureFormat Format { get; }
	///<include file='Utils/Docs/GPUTextureUsage/GPUTextureUsage.generated.xml' path='docs/GPUTextureUsage/*'/>
	public GPUFlagsConstant Usage { get; }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUTextureDescriptor : GPUObjectDescriptorBase
{
		public required GPUExtent3D Size;
		public GPUIntegerCoordinate MipLevelCount;
		public GPUSize32 SampleCount;
		public GPUTextureDimension Dimension;
		public required GPUTextureFormat Format;
		public required GPUTextureUsageFlags Usage;
		public List<GPUTextureFormat> ViewFormats;
}

///<include file='Utils/Docs/GPUTextureDimension/GPUTextureDimension.generated.xml' path='docs/GPUTextureDimension/*'/>
public enum GPUTextureDimension
{
	_1d,
	_2d,
	_3d,
}


///<include file='Utils/Docs/GPUTextureUsage/GPUTextureUsage.generated.xml' path='docs/GPUTextureUsage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUTextureUsage
{
		public const GPUFlagsConstant COPY_SRC = 0x01;
		public const GPUFlagsConstant COPY_DST = 0x02;
		public const GPUFlagsConstant TEXTURE_BINDING = 0x04;
		public const GPUFlagsConstant STORAGE_BINDING = 0x08;
		public const GPUFlagsConstant RENDER_ATTACHMENT = 0x10;
}

///<include file='Utils/Docs/GPUTextureView/GPUTextureView.generated.xml' path='docs/GPUTextureView/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUTextureView
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUTextureViewDescriptor : GPUObjectDescriptorBase
{
		public GPUTextureFormat Format;
		public GPUTextureViewDimension Dimension;
		public GPUTextureAspect Aspect;
		public GPUIntegerCoordinate BaseMipLevel;
		public GPUIntegerCoordinate MipLevelCount;
		public GPUIntegerCoordinate BaseArrayLayer;
		public GPUIntegerCoordinate ArrayLayerCount;
}

public enum GPUTextureViewDimension
{
	_1d,
	_2d,
	_2dArray,
	Cube,
	CubeArray,
	_3d,
}

public enum GPUTextureAspect
{
	All,
	StencilOnly,
	DepthOnly,
}

///<include file='Utils/Docs/GPUTextureFormat/GPUTextureFormat.generated.xml' path='docs/GPUTextureFormat/*'/>
public enum GPUTextureFormat
{
	R8unorm,
	R8snorm,
	R8uint,
	R8sint,
	R16uint,
	R16sint,
	R16float,
	Rg8unorm,
	Rg8snorm,
	Rg8uint,
	Rg8sint,
	R32uint,
	R32sint,
	R32float,
	Rg16uint,
	Rg16sint,
	Rg16float,
	Rgba8unorm,
	Rgba8unormSrgb,
	Rgba8snorm,
	Rgba8uint,
	Rgba8sint,
	Bgra8unorm,
	Bgra8unormSrgb,
	Rgb9e5ufloat,
	Rgb10a2uint,
	Rgb10a2unorm,
	Rg11b10ufloat,
	Rg32uint,
	Rg32sint,
	Rg32float,
	Rgba16uint,
	Rgba16sint,
	Rgba16float,
	Rgba32uint,
	Rgba32sint,
	Rgba32float,
	Stencil8,
	Depth16unorm,
	Depth24plus,
	Depth24plusStencil8,
	Depth32float,
	Depth32floatStencil8,
	Bc1RgbaUnorm,
	Bc1RgbaUnormSrgb,
	Bc2RgbaUnorm,
	Bc2RgbaUnormSrgb,
	Bc3RgbaUnorm,
	Bc3RgbaUnormSrgb,
	Bc4RUnorm,
	Bc4RSnorm,
	Bc5RgUnorm,
	Bc5RgSnorm,
	Bc6hRgbUfloat,
	Bc6hRgbFloat,
	Bc7RgbaUnorm,
	Bc7RgbaUnormSrgb,
	Etc2Rgb8unorm,
	Etc2Rgb8unormSrgb,
	Etc2Rgb8a1unorm,
	Etc2Rgb8a1unormSrgb,
	Etc2Rgba8unorm,
	Etc2Rgba8unormSrgb,
	EacR11unorm,
	EacR11snorm,
	EacRg11unorm,
	EacRg11snorm,
	Astc4x4Unorm,
	Astc4x4UnormSrgb,
	Astc5x4Unorm,
	Astc5x4UnormSrgb,
	Astc5x5Unorm,
	Astc5x5UnormSrgb,
	Astc6x5Unorm,
	Astc6x5UnormSrgb,
	Astc6x6Unorm,
	Astc6x6UnormSrgb,
	Astc8x5Unorm,
	Astc8x5UnormSrgb,
	Astc8x6Unorm,
	Astc8x6UnormSrgb,
	Astc8x8Unorm,
	Astc8x8UnormSrgb,
	Astc10x5Unorm,
	Astc10x5UnormSrgb,
	Astc10x6Unorm,
	Astc10x6UnormSrgb,
	Astc10x8Unorm,
	Astc10x8UnormSrgb,
	Astc10x10Unorm,
	Astc10x10UnormSrgb,
	Astc12x10Unorm,
	Astc12x10UnormSrgb,
	Astc12x12Unorm,
	Astc12x12UnormSrgb,
}

///<include file='Utils/Docs/GPUExternalTexture/GPUExternalTexture.generated.xml' path='docs/GPUExternalTexture/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUExternalTexture
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUExternalTextureDescriptor : GPUObjectDescriptorBase
{
		public required Union96 Source;
		public PredefinedColorSpace ColorSpace;
}

///<include file='Utils/Docs/GPUSampler/GPUSampler.generated.xml' path='docs/GPUSampler/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUSampler
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUSamplerDescriptor : GPUObjectDescriptorBase
{
		public GPUAddressMode AddressModeU;
		public GPUAddressMode AddressModeV;
		public GPUAddressMode AddressModeW;
		public GPUFilterMode MagFilter;
		public GPUFilterMode MinFilter;
		public GPUMipmapFilterMode MipmapFilter;
		public Number LodMinClamp;
		public Number LodMaxClamp;
		public GPUCompareFunction Compare;
		public ushort MaxAnisotropy;
}

public enum GPUAddressMode
{
	ClampToEdge,
	Repeat,
	MirrorRepeat,
}

public enum GPUFilterMode
{
	Nearest,
	Linear,
}

public enum GPUMipmapFilterMode
{
	Nearest,
	Linear,
}

public enum GPUCompareFunction
{
	Never,
	Less,
	Equal,
	LessEqual,
	Greater,
	NotEqual,
	GreaterEqual,
	Always,
}

///<include file='Utils/Docs/GPUBindGroupLayout/GPUBindGroupLayout.generated.xml' path='docs/GPUBindGroupLayout/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUBindGroupLayout
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUBindGroupLayoutDescriptor : GPUObjectDescriptorBase
{
		public required List<GPUBindGroupLayoutEntry> Entries;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUBindGroupLayoutEntry
{
		public required GPUIndex32 Binding;
		public required GPUShaderStageFlags Visibility;
		public GPUBufferBindingLayout Buffer;
		public GPUSamplerBindingLayout Sampler;
		public GPUTextureBindingLayout Texture;
		public GPUStorageTextureBindingLayout StorageTexture;
		public GPUExternalTextureBindingLayout ExternalTexture;
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUShaderStage
{
		public const GPUFlagsConstant VERTEX = 0x1;
		public const GPUFlagsConstant FRAGMENT = 0x2;
		public const GPUFlagsConstant COMPUTE = 0x4;
}

public enum GPUBufferBindingType
{
	Uniform,
	Storage,
	ReadOnlyStorage,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUBufferBindingLayout
{
		public GPUBufferBindingType Type;
		public bool HasDynamicOffset;
		public GPUSize64 MinBindingSize;
}

public enum GPUSamplerBindingType
{
	Filtering,
	NonFiltering,
	Comparison,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUSamplerBindingLayout
{
		public GPUSamplerBindingType Type;
}

public enum GPUTextureSampleType
{
	Float,
	UnfilterableFloat,
	Depth,
	Sint,
	Uint,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUTextureBindingLayout
{
		public GPUTextureSampleType SampleType;
		public GPUTextureViewDimension ViewDimension;
		public bool Multisampled;
}

public enum GPUStorageTextureAccess
{
	WriteOnly,
	ReadOnly,
	ReadWrite,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUStorageTextureBindingLayout
{
		public GPUStorageTextureAccess Access;
		public required GPUTextureFormat Format;
		public GPUTextureViewDimension ViewDimension;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUExternalTextureBindingLayout
{
}

///<include file='Utils/Docs/GPUBindGroup/GPUBindGroup.generated.xml' path='docs/GPUBindGroup/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUBindGroup
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUBindGroupDescriptor : GPUObjectDescriptorBase
{
		public required GPUBindGroupLayout Layout;
		public required List<GPUBindGroupEntry> Entries;
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUBindGroupEntry
{
		public required GPUIndex32 Binding;
		public required GPUBindingResource Resource;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUBufferBinding
{
		public required GPUBuffer Buffer;
		public GPUSize64 Offset;
		public GPUSize64 Size;
}

///<include file='Utils/Docs/GPUPipelineLayout/GPUPipelineLayout.generated.xml' path='docs/GPUPipelineLayout/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUPipelineLayout
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUPipelineLayoutDescriptor : GPUObjectDescriptorBase
{
		public required List<GPUBindGroupLayout> BindGroupLayouts;
}

///<include file='Utils/Docs/GPUShaderModule/GPUShaderModule.generated.xml' path='docs/GPUShaderModule/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUShaderModule
{
	///<include file='Utils/Docs/GPUShaderModuleGetCompilationInfo/GPUShaderModuleGetCompilationInfo.generated.xml' path='docs/GPUShaderModuleGetCompilationInfo/*'/>
	public Task<GPUCompilationInfo> GetCompilationInfo() { throw new System.NotImplementedException(); }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUShaderModuleDescriptor : GPUObjectDescriptorBase
{
		public required string Code;
		public object SourceMap;
		public List<GPUShaderModuleCompilationHint> CompilationHints;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUShaderModuleCompilationHint
{
		public required string EntryPoint;
		public Union98 Layout;
}

///<include file='Utils/Docs/GPUCompilationMessageType/GPUCompilationMessageType.generated.xml' path='docs/GPUCompilationMessageType/*'/>
public enum GPUCompilationMessageType
{
	Error,
	Warning,
	Info,
}

///<include file='Utils/Docs/GPUCompilationMessage/GPUCompilationMessage.generated.xml' path='docs/GPUCompilationMessage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUCompilationMessage
{
	///<include file='Utils/Docs/GPUCompilationMessageMessage/GPUCompilationMessageMessage.generated.xml' path='docs/GPUCompilationMessageMessage/*'/>
	public string Message { get; }
	///<include file='Utils/Docs/GPUCompilationMessageType/GPUCompilationMessageType.generated.xml' path='docs/GPUCompilationMessageType/*'/>
	public GPUCompilationMessageType Type { get; }
	///<include file='Utils/Docs/GPUCompilationMessageLineNum/GPUCompilationMessageLineNum.generated.xml' path='docs/GPUCompilationMessageLineNum/*'/>
	public ulong LineNum { get; }
	///<include file='Utils/Docs/GPUCompilationMessageLinePos/GPUCompilationMessageLinePos.generated.xml' path='docs/GPUCompilationMessageLinePos/*'/>
	public ulong LinePos { get; }
	///<include file='Utils/Docs/GPUCompilationMessageOffset/GPUCompilationMessageOffset.generated.xml' path='docs/GPUCompilationMessageOffset/*'/>
	public ulong Offset { get; }
	///<include file='Utils/Docs/GPUCompilationMessageLength/GPUCompilationMessageLength.generated.xml' path='docs/GPUCompilationMessageLength/*'/>
	public ulong Length { get; }
}

///<include file='Utils/Docs/GPUCompilationInfo/GPUCompilationInfo.generated.xml' path='docs/GPUCompilationInfo/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUCompilationInfo
{
	///<include file='Utils/Docs/GPUCompilationInfoMessages/GPUCompilationInfoMessages.generated.xml' path='docs/GPUCompilationInfoMessages/*'/>
	public GPUCompilationMessage[] Messages { get; }
}

///<include file='Utils/Docs/GPUPipelineError/GPUPipelineError.generated.xml' path='docs/GPUPipelineError/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUPipelineError : DOMException
{
	///<include file='Utils/Docs/GPUPipelineErrorGPUPipelineError/GPUPipelineErrorGPUPipelineError.generated.xml' path='docs/GPUPipelineErrorGPUPipelineError/*'/>
	public GPUPipelineError(string message, GPUPipelineErrorInit options) { }
	///<include file='Utils/Docs/GPUPipelineErrorReason/GPUPipelineErrorReason.generated.xml' path='docs/GPUPipelineErrorReason/*'/>
	public GPUPipelineErrorReason Reason { get; }
	public GPUPipelineError() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUPipelineErrorInit
{
		public required GPUPipelineErrorReason Reason;
}

///<include file='Utils/Docs/GPUPipelineErrorReason/GPUPipelineErrorReason.generated.xml' path='docs/GPUPipelineErrorReason/*'/>
public enum GPUPipelineErrorReason
{
	Validation,
	Internal,
}

public enum GPUAutoLayoutMode
{
	Auto,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUPipelineDescriptorBase : GPUObjectDescriptorBase
{
		public required Union99 Layout;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GPUPipelineBase
{
		public GPUBindGroupLayout GetBindGroupLayout(ulong index) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUProgrammableStage
{
		public required GPUShaderModule Module;
		public required string EntryPoint;
		public Dictionary<string, GPUPipelineConstantValue> Constants;
}


///<include file='Utils/Docs/GPUComputePipeline/GPUComputePipeline.generated.xml' path='docs/GPUComputePipeline/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUComputePipeline
{
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUComputePipelineDescriptor : GPUPipelineDescriptorBase
{
		public required GPUProgrammableStage Compute;
}

///<include file='Utils/Docs/GPURenderPipeline/GPURenderPipeline.generated.xml' path='docs/GPURenderPipeline/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPURenderPipeline
{
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPURenderPipelineDescriptor : GPUPipelineDescriptorBase
{
		public required GPUVertexState Vertex;
		public GPUPrimitiveState Primitive;
		public GPUDepthStencilState DepthStencil;
		public GPUMultisampleState Multisample;
		public GPUFragmentState Fragment;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUPrimitiveState
{
		public GPUPrimitiveTopology Topology;
		public GPUIndexFormat StripIndexFormat;
		public GPUFrontFace FrontFace;
		public GPUCullMode CullMode;
		public bool UnclippedDepth;
}

public enum GPUPrimitiveTopology
{
	PointList,
	LineList,
	LineStrip,
	TriangleList,
	TriangleStrip,
}

public enum GPUFrontFace
{
	Ccw,
	Cw,
}

public enum GPUCullMode
{
	None,
	Front,
	Back,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUMultisampleState
{
		public GPUSize32 Count;
		public GPUSampleMask Mask;
		public bool AlphaToCoverageEnabled;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUFragmentState : GPUProgrammableStage
{
		public required List<GPUColorTargetState?> Targets;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUColorTargetState
{
		public required GPUTextureFormat Format;
		public GPUBlendState Blend;
		public GPUColorWriteFlags WriteMask;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUBlendState
{
		public required GPUBlendComponent Color;
		public required GPUBlendComponent Alpha;
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUColorWrite
{
		public const GPUFlagsConstant RED = 0x1;
		public const GPUFlagsConstant GREEN = 0x2;
		public const GPUFlagsConstant BLUE = 0x4;
		public const GPUFlagsConstant ALPHA = 0x8;
		public const GPUFlagsConstant ALL = 0xF;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUBlendComponent
{
		public GPUBlendOperation Operation;
		public GPUBlendFactor SrcFactor;
		public GPUBlendFactor DstFactor;
}

public enum GPUBlendFactor
{
	Zero,
	One,
	Src,
	OneMinusSrc,
	SrcAlpha,
	OneMinusSrcAlpha,
	Dst,
	OneMinusDst,
	DstAlpha,
	OneMinusDstAlpha,
	SrcAlphaSaturated,
	Constant,
	OneMinusConstant,
}

public enum GPUBlendOperation
{
	Add,
	Subtract,
	ReverseSubtract,
	Min,
	Max,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUDepthStencilState
{
		public required GPUTextureFormat Format;
		public bool DepthWriteEnabled;
		public GPUCompareFunction DepthCompare;
		public GPUStencilFaceState StencilFront;
		public GPUStencilFaceState StencilBack;
		public GPUStencilValue StencilReadMask;
		public GPUStencilValue StencilWriteMask;
		public GPUDepthBias DepthBias;
		public Number DepthBiasSlopeScale;
		public Number DepthBiasClamp;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUStencilFaceState
{
		public GPUCompareFunction Compare;
		public GPUStencilOperation FailOp;
		public GPUStencilOperation DepthFailOp;
		public GPUStencilOperation PassOp;
}

public enum GPUStencilOperation
{
	Keep,
	Zero,
	Replace,
	Invert,
	IncrementClamp,
	DecrementClamp,
	IncrementWrap,
	DecrementWrap,
}

public enum GPUIndexFormat
{
	Uint16,
	Uint32,
}

public enum GPUVertexFormat
{
	Uint8x2,
	Uint8x4,
	Sint8x2,
	Sint8x4,
	Unorm8x2,
	Unorm8x4,
	Snorm8x2,
	Snorm8x4,
	Uint16x2,
	Uint16x4,
	Sint16x2,
	Sint16x4,
	Unorm16x2,
	Unorm16x4,
	Snorm16x2,
	Snorm16x4,
	Float16x2,
	Float16x4,
	Float32,
	Float32x2,
	Float32x3,
	Float32x4,
	Uint32,
	Uint32x2,
	Uint32x3,
	Uint32x4,
	Sint32,
	Sint32x2,
	Sint32x3,
	Sint32x4,
	Unorm1010102,
}

public enum GPUVertexStepMode
{
	Vertex,
	Instance,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUVertexState : GPUProgrammableStage
{
		public List<GPUVertexBufferLayout?> Buffers;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUVertexBufferLayout
{
		public required GPUSize64 ArrayStride;
		public GPUVertexStepMode StepMode;
		public required List<GPUVertexAttribute> Attributes;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUVertexAttribute
{
		public required GPUVertexFormat Format;
		public required GPUSize64 Offset;
		public required GPUIndex32 ShaderLocation;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUImageDataLayout
{
		public GPUSize64 Offset;
		public GPUSize32 BytesPerRow;
		public GPUSize32 RowsPerImage;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUImageCopyBuffer : GPUImageDataLayout
{
		public required GPUBuffer Buffer;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUImageCopyTexture
{
		public required GPUTexture Texture;
		public GPUIntegerCoordinate MipLevel;
		public GPUOrigin3D Origin;
		public GPUTextureAspect Aspect;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUImageCopyTextureTagged : GPUImageCopyTexture
{
		public PredefinedColorSpace ColorSpace;
		public bool PremultipliedAlpha;
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUImageCopyExternalImage
{
		public required GPUImageCopyExternalImageSource Source;
		public GPUOrigin2D Origin;
		public bool FlipY;
}

///<include file='Utils/Docs/GPUCommandBuffer/GPUCommandBuffer.generated.xml' path='docs/GPUCommandBuffer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUCommandBuffer
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUCommandBufferDescriptor : GPUObjectDescriptorBase
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GPUCommandsMixin
{
}

///<include file='Utils/Docs/GPUCommandEncoder/GPUCommandEncoder.generated.xml' path='docs/GPUCommandEncoder/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUCommandEncoder
{
	///<include file='Utils/Docs/GPUCommandEncoderBeginRenderPass/GPUCommandEncoderBeginRenderPass.generated.xml' path='docs/GPUCommandEncoderBeginRenderPass/*'/>
	public GPURenderPassEncoder BeginRenderPass(GPURenderPassDescriptor descriptor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUCommandEncoderBeginComputePass/GPUCommandEncoderBeginComputePass.generated.xml' path='docs/GPUCommandEncoderBeginComputePass/*'/>
	public GPUComputePassEncoder BeginComputePass(GPUComputePassDescriptor descriptor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUCommandEncoderCopyBufferToBuffer/GPUCommandEncoderCopyBufferToBuffer.generated.xml' path='docs/GPUCommandEncoderCopyBufferToBuffer/*'/>
	public Undefined CopyBufferToBuffer(GPUBuffer source, GPUSize64 sourceOffset, GPUBuffer destination, GPUSize64 destinationOffset, GPUSize64 size) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUCommandEncoderCopyBufferToTexture/GPUCommandEncoderCopyBufferToTexture.generated.xml' path='docs/GPUCommandEncoderCopyBufferToTexture/*'/>
	public Undefined CopyBufferToTexture(GPUImageCopyBuffer source, GPUImageCopyTexture destination, GPUExtent3D copySize) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUCommandEncoderCopyTextureToBuffer/GPUCommandEncoderCopyTextureToBuffer.generated.xml' path='docs/GPUCommandEncoderCopyTextureToBuffer/*'/>
	public Undefined CopyTextureToBuffer(GPUImageCopyTexture source, GPUImageCopyBuffer destination, GPUExtent3D copySize) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUCommandEncoderCopyTextureToTexture/GPUCommandEncoderCopyTextureToTexture.generated.xml' path='docs/GPUCommandEncoderCopyTextureToTexture/*'/>
	public Undefined CopyTextureToTexture(GPUImageCopyTexture source, GPUImageCopyTexture destination, GPUExtent3D copySize) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUCommandEncoderClearBuffer/GPUCommandEncoderClearBuffer.generated.xml' path='docs/GPUCommandEncoderClearBuffer/*'/>
	public Undefined ClearBuffer(GPUBuffer buffer, GPUSize64 offset, GPUSize64 size) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUCommandEncoderWriteTimestamp/GPUCommandEncoderWriteTimestamp.generated.xml' path='docs/GPUCommandEncoderWriteTimestamp/*'/>
	public Undefined WriteTimestamp(GPUQuerySet querySet, GPUSize32 queryIndex) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUCommandEncoderResolveQuerySet/GPUCommandEncoderResolveQuerySet.generated.xml' path='docs/GPUCommandEncoderResolveQuerySet/*'/>
	public Undefined ResolveQuerySet(GPUQuerySet querySet, GPUSize32 firstQuery, GPUSize32 queryCount, GPUBuffer destination, GPUSize64 destinationOffset) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUCommandEncoderFinish/GPUCommandEncoderFinish.generated.xml' path='docs/GPUCommandEncoderFinish/*'/>
	public GPUCommandBuffer Finish(GPUCommandBufferDescriptor descriptor) { throw new System.NotImplementedException(); }
}




[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUCommandEncoderDescriptor : GPUObjectDescriptorBase
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GPUBindingCommandsMixin
{
		public Undefined SetBindGroup(GPUIndex32 index, GPUBindGroup? bindGroup, List<GPUBufferDynamicOffset> dynamicOffsets) { throw new System.NotImplementedException(); }
		public Undefined SetBindGroup(GPUIndex32 index, GPUBindGroup? bindGroup, System.UInt32 dynamicOffsetsData, GPUSize64 dynamicOffsetsDataStart, GPUSize32 dynamicOffsetsDataLength) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GPUDebugCommandsMixin
{
		public Undefined PushDebugGroup(string groupLabel) { throw new System.NotImplementedException(); }
		public Undefined PopDebugGroup() { throw new System.NotImplementedException(); }
		public Undefined InsertDebugMarker(string markerLabel) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/GPUComputePassEncoder/GPUComputePassEncoder.generated.xml' path='docs/GPUComputePassEncoder/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUComputePassEncoder
{
	///<include file='Utils/Docs/GPUComputePassEncoderSetPipeline/GPUComputePassEncoderSetPipeline.generated.xml' path='docs/GPUComputePassEncoderSetPipeline/*'/>
	public Undefined SetPipeline(GPUComputePipeline pipeline) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUComputePassEncoderDispatchWorkgroups/GPUComputePassEncoderDispatchWorkgroups.generated.xml' path='docs/GPUComputePassEncoderDispatchWorkgroups/*'/>
	public Undefined DispatchWorkgroups(GPUSize32 workgroupCountX, GPUSize32 workgroupCountY, GPUSize32 workgroupCountZ) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUComputePassEncoderDispatchWorkgroupsIndirect/GPUComputePassEncoderDispatchWorkgroupsIndirect.generated.xml' path='docs/GPUComputePassEncoderDispatchWorkgroupsIndirect/*'/>
	public Undefined DispatchWorkgroupsIndirect(GPUBuffer indirectBuffer, GPUSize64 indirectOffset) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUComputePassEncoderEnd/GPUComputePassEncoderEnd.generated.xml' path='docs/GPUComputePassEncoderEnd/*'/>
	public Undefined End() { throw new System.NotImplementedException(); }
}





[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUComputePassTimestampWrites
{
		public required GPUQuerySet QuerySet;
		public GPUSize32 BeginningOfPassWriteIndex;
		public GPUSize32 EndOfPassWriteIndex;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUComputePassDescriptor : GPUObjectDescriptorBase
{
		public GPUComputePassTimestampWrites TimestampWrites;
}

///<include file='Utils/Docs/GPURenderPassEncoder/GPURenderPassEncoder.generated.xml' path='docs/GPURenderPassEncoder/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPURenderPassEncoder
{
	///<include file='Utils/Docs/GPURenderPassEncoderSetViewport/GPURenderPassEncoderSetViewport.generated.xml' path='docs/GPURenderPassEncoderSetViewport/*'/>
	public Undefined SetViewport(Number x, Number y, Number width, Number height, Number minDepth, Number maxDepth) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPURenderPassEncoderSetScissorRect/GPURenderPassEncoderSetScissorRect.generated.xml' path='docs/GPURenderPassEncoderSetScissorRect/*'/>
	public Undefined SetScissorRect(GPUIntegerCoordinate x, GPUIntegerCoordinate y, GPUIntegerCoordinate width, GPUIntegerCoordinate height) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPURenderPassEncoderSetBlendConstant/GPURenderPassEncoderSetBlendConstant.generated.xml' path='docs/GPURenderPassEncoderSetBlendConstant/*'/>
	public Undefined SetBlendConstant(GPUColor color) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPURenderPassEncoderSetStencilReference/GPURenderPassEncoderSetStencilReference.generated.xml' path='docs/GPURenderPassEncoderSetStencilReference/*'/>
	public Undefined SetStencilReference(GPUStencilValue reference) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPURenderPassEncoderBeginOcclusionQuery/GPURenderPassEncoderBeginOcclusionQuery.generated.xml' path='docs/GPURenderPassEncoderBeginOcclusionQuery/*'/>
	public Undefined BeginOcclusionQuery(GPUSize32 queryIndex) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPURenderPassEncoderEndOcclusionQuery/GPURenderPassEncoderEndOcclusionQuery.generated.xml' path='docs/GPURenderPassEncoderEndOcclusionQuery/*'/>
	public Undefined EndOcclusionQuery() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPURenderPassEncoderExecuteBundles/GPURenderPassEncoderExecuteBundles.generated.xml' path='docs/GPURenderPassEncoderExecuteBundles/*'/>
	public Undefined ExecuteBundles(List<GPURenderBundle> bundles) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPURenderPassEncoderEnd/GPURenderPassEncoderEnd.generated.xml' path='docs/GPURenderPassEncoderEnd/*'/>
	public Undefined End() { throw new System.NotImplementedException(); }
}






[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPURenderPassTimestampWrites
{
		public required GPUQuerySet QuerySet;
		public GPUSize32 BeginningOfPassWriteIndex;
		public GPUSize32 EndOfPassWriteIndex;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPURenderPassDescriptor : GPUObjectDescriptorBase
{
		public required List<GPURenderPassColorAttachment?> ColorAttachments;
		public GPURenderPassDepthStencilAttachment DepthStencilAttachment;
		public GPUQuerySet OcclusionQuerySet;
		public GPURenderPassTimestampWrites TimestampWrites;
		public GPUSize64 MaxDrawCount;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPURenderPassColorAttachment
{
		public required GPUTextureView View;
		public GPUIntegerCoordinate DepthSlice;
		public GPUTextureView ResolveTarget;
		public GPUColor ClearValue;
		public required GPULoadOp LoadOp;
		public required GPUStoreOp StoreOp;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPURenderPassDepthStencilAttachment
{
		public required GPUTextureView View;
		public Number DepthClearValue;
		public GPULoadOp DepthLoadOp;
		public GPUStoreOp DepthStoreOp;
		public bool DepthReadOnly;
		public GPUStencilValue StencilClearValue;
		public GPULoadOp StencilLoadOp;
		public GPUStoreOp StencilStoreOp;
		public bool StencilReadOnly;
}

public enum GPULoadOp
{
	Load,
	Clear,
}

public enum GPUStoreOp
{
	Store,
	Discard,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPURenderPassLayout : GPUObjectDescriptorBase
{
		public required List<GPUTextureFormat?> ColorFormats;
		public GPUTextureFormat DepthStencilFormat;
		public GPUSize32 SampleCount;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GPURenderCommandsMixin
{
		public Undefined SetPipeline(GPURenderPipeline pipeline) { throw new System.NotImplementedException(); }
		public Undefined SetIndexBuffer(GPUBuffer buffer, GPUIndexFormat indexFormat, GPUSize64 offset, GPUSize64 size) { throw new System.NotImplementedException(); }
		public Undefined SetVertexBuffer(GPUIndex32 slot, GPUBuffer? buffer, GPUSize64 offset, GPUSize64 size) { throw new System.NotImplementedException(); }
		public Undefined Draw(GPUSize32 vertexCount, GPUSize32 instanceCount, GPUSize32 firstVertex, GPUSize32 firstInstance) { throw new System.NotImplementedException(); }
		public Undefined DrawIndexed(GPUSize32 indexCount, GPUSize32 instanceCount, GPUSize32 firstIndex, GPUSignedOffset32 baseVertex, GPUSize32 firstInstance) { throw new System.NotImplementedException(); }
		public Undefined DrawIndirect(GPUBuffer indirectBuffer, GPUSize64 indirectOffset) { throw new System.NotImplementedException(); }
		public Undefined DrawIndexedIndirect(GPUBuffer indirectBuffer, GPUSize64 indirectOffset) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/GPURenderBundle/GPURenderBundle.generated.xml' path='docs/GPURenderBundle/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPURenderBundle
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPURenderBundleDescriptor : GPUObjectDescriptorBase
{
}

///<include file='Utils/Docs/GPURenderBundleEncoder/GPURenderBundleEncoder.generated.xml' path='docs/GPURenderBundleEncoder/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPURenderBundleEncoder
{
	///<include file='Utils/Docs/GPURenderBundleEncoderFinish/GPURenderBundleEncoderFinish.generated.xml' path='docs/GPURenderBundleEncoderFinish/*'/>
	public GPURenderBundle Finish(GPURenderBundleDescriptor descriptor) { throw new System.NotImplementedException(); }
}






[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPURenderBundleEncoderDescriptor : GPURenderPassLayout
{
		public bool DepthReadOnly;
		public bool StencilReadOnly;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUQueueDescriptor : GPUObjectDescriptorBase
{
}

///<include file='Utils/Docs/GPUQueue/GPUQueue.generated.xml' path='docs/GPUQueue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUQueue
{
	///<include file='Utils/Docs/GPUQueueSubmit/GPUQueueSubmit.generated.xml' path='docs/GPUQueueSubmit/*'/>
	public Undefined Submit(List<GPUCommandBuffer> commandBuffers) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUQueueOnSubmittedWorkDone/GPUQueueOnSubmittedWorkDone.generated.xml' path='docs/GPUQueueOnSubmittedWorkDone/*'/>
	public Task<Undefined> OnSubmittedWorkDone() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUQueueWriteBuffer/GPUQueueWriteBuffer.generated.xml' path='docs/GPUQueueWriteBuffer/*'/>
	public Undefined WriteBuffer(GPUBuffer buffer, GPUSize64 bufferOffset, AllowSharedBufferSource data, GPUSize64 dataOffset, GPUSize64 size) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUQueueWriteTexture/GPUQueueWriteTexture.generated.xml' path='docs/GPUQueueWriteTexture/*'/>
	public Undefined WriteTexture(GPUImageCopyTexture destination, AllowSharedBufferSource data, GPUImageDataLayout dataLayout, GPUExtent3D size) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUQueueCopyExternalImageToTexture/GPUQueueCopyExternalImageToTexture.generated.xml' path='docs/GPUQueueCopyExternalImageToTexture/*'/>
	public Undefined CopyExternalImageToTexture(GPUImageCopyExternalImage source, GPUImageCopyTextureTagged destination, GPUExtent3D copySize) { throw new System.NotImplementedException(); }
}


///<include file='Utils/Docs/GPUQuerySet/GPUQuerySet.generated.xml' path='docs/GPUQuerySet/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUQuerySet
{
	///<include file='Utils/Docs/GPUQuerySetDestroy/GPUQuerySetDestroy.generated.xml' path='docs/GPUQuerySetDestroy/*'/>
	public Undefined Destroy() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUQuerySetType/GPUQuerySetType.generated.xml' path='docs/GPUQuerySetType/*'/>
	public GPUQueryType Type { get; }
	///<include file='Utils/Docs/GPUQuerySetCount/GPUQuerySetCount.generated.xml' path='docs/GPUQuerySetCount/*'/>
	public GPUSize32Out Count { get; }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUQuerySetDescriptor : GPUObjectDescriptorBase
{
		public required GPUQueryType Type;
		public required GPUSize32 Count;
}

public enum GPUQueryType
{
	Occlusion,
	Timestamp,
}

///<include file='Utils/Docs/GPUCanvasContext/GPUCanvasContext.generated.xml' path='docs/GPUCanvasContext/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUCanvasContext
{
	///<include file='Utils/Docs/GPUCanvasContextCanvas/GPUCanvasContextCanvas.generated.xml' path='docs/GPUCanvasContextCanvas/*'/>
	public Union101 Canvas { get; }
	///<include file='Utils/Docs/GPUCanvasContextConfigure/GPUCanvasContextConfigure.generated.xml' path='docs/GPUCanvasContextConfigure/*'/>
	public Undefined Configure(GPUCanvasConfiguration configuration) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUCanvasContextUnconfigure/GPUCanvasContextUnconfigure.generated.xml' path='docs/GPUCanvasContextUnconfigure/*'/>
	public Undefined Unconfigure() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUCanvasContextGetCurrentTexture/GPUCanvasContextGetCurrentTexture.generated.xml' path='docs/GPUCanvasContextGetCurrentTexture/*'/>
	public GPUTexture GetCurrentTexture() { throw new System.NotImplementedException(); }
}

public enum GPUCanvasAlphaMode
{
	Opaque,
	Premultiplied,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUCanvasConfiguration
{
		public required GPUDevice Device;
		public required GPUTextureFormat Format;
		public GPUTextureUsageFlags Usage;
		public List<GPUTextureFormat> ViewFormats;
		public PredefinedColorSpace ColorSpace;
		public GPUCanvasAlphaMode AlphaMode;
}

public enum GPUDeviceLostReason
{
	Unknown,
	Destroyed,
}

///<include file='Utils/Docs/GPUDeviceLostInfo/GPUDeviceLostInfo.generated.xml' path='docs/GPUDeviceLostInfo/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUDeviceLostInfo
{
	///<include file='Utils/Docs/GPUDeviceLostInfoReason/GPUDeviceLostInfoReason.generated.xml' path='docs/GPUDeviceLostInfoReason/*'/>
	public GPUDeviceLostReason Reason { get; }
	///<include file='Utils/Docs/GPUDeviceLostInfoMessage/GPUDeviceLostInfoMessage.generated.xml' path='docs/GPUDeviceLostInfoMessage/*'/>
	public string Message { get; }
}

///<include file='Utils/Docs/GPUDevice/GPUDevice.generated.xml' path='docs/GPUDevice/*'/>
public partial class GPUDevice
{
	///<include file='Utils/Docs/GPUDeviceLost/GPUDeviceLost.generated.xml' path='docs/GPUDeviceLost/*'/>
	public Task<GPUDeviceLostInfo> Lost { get; }
}

///<include file='Utils/Docs/GPUError/GPUError.generated.xml' path='docs/GPUError/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUError
{
	///<include file='Utils/Docs/GPUErrorMessage/GPUErrorMessage.generated.xml' path='docs/GPUErrorMessage/*'/>
	public string Message { get; }
}

///<include file='Utils/Docs/GPUValidationError/GPUValidationError.generated.xml' path='docs/GPUValidationError/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUValidationError : GPUError
{
	///<include file='Utils/Docs/GPUValidationErrorGPUValidationError/GPUValidationErrorGPUValidationError.generated.xml' path='docs/GPUValidationErrorGPUValidationError/*'/>
	public GPUValidationError(string message) { }
	public GPUValidationError() { }
}

///<include file='Utils/Docs/GPUOutOfMemoryError/GPUOutOfMemoryError.generated.xml' path='docs/GPUOutOfMemoryError/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUOutOfMemoryError : GPUError
{
	///<include file='Utils/Docs/GPUOutOfMemoryErrorGPUOutOfMemoryError/GPUOutOfMemoryErrorGPUOutOfMemoryError.generated.xml' path='docs/GPUOutOfMemoryErrorGPUOutOfMemoryError/*'/>
	public GPUOutOfMemoryError(string message) { }
	public GPUOutOfMemoryError() { }
}

///<include file='Utils/Docs/GPUInternalError/GPUInternalError.generated.xml' path='docs/GPUInternalError/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUInternalError : GPUError
{
	///<include file='Utils/Docs/GPUInternalErrorGPUInternalError/GPUInternalErrorGPUInternalError.generated.xml' path='docs/GPUInternalErrorGPUInternalError/*'/>
	public GPUInternalError(string message) { }
	public GPUInternalError() { }
}

public enum GPUErrorFilter
{
	Validation,
	OutOfMemory,
	Internal,
}

///<include file='Utils/Docs/GPUDevice/GPUDevice.generated.xml' path='docs/GPUDevice/*'/>
public partial class GPUDevice
{
	///<include file='Utils/Docs/GPUDevicePushErrorScope/GPUDevicePushErrorScope.generated.xml' path='docs/GPUDevicePushErrorScope/*'/>
	public Undefined PushErrorScope(GPUErrorFilter filter) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/GPUDevicePopErrorScope/GPUDevicePopErrorScope.generated.xml' path='docs/GPUDevicePopErrorScope/*'/>
	public Task<GPUError?> PopErrorScope() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/GPUUncapturedErrorEvent/GPUUncapturedErrorEvent.generated.xml' path='docs/GPUUncapturedErrorEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUUncapturedErrorEvent : Event
{
	///<include file='Utils/Docs/GPUUncapturedErrorEventGPUUncapturedErrorEvent/GPUUncapturedErrorEventGPUUncapturedErrorEvent.generated.xml' path='docs/GPUUncapturedErrorEventGPUUncapturedErrorEvent/*'/>
	public GPUUncapturedErrorEvent(string type, GPUUncapturedErrorEventInit gpuUncapturedErrorEventInitDict) { }
	///<include file='Utils/Docs/GPUUncapturedErrorEventError/GPUUncapturedErrorEventError.generated.xml' path='docs/GPUUncapturedErrorEventError/*'/>
	public GPUError Error { get; }
	public GPUUncapturedErrorEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUUncapturedErrorEventInit : EventInit
{
		public required GPUError Error;
}

///<include file='Utils/Docs/GPUDevice/GPUDevice.generated.xml' path='docs/GPUDevice/*'/>
public partial class GPUDevice
{
		public EventHandler Onuncapturederror { get; set; }
}














[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUColorDict
{
		public required Number R;
		public required Number G;
		public required Number B;
		public required Number A;
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUOrigin2DDict
{
		public GPUIntegerCoordinate X;
		public GPUIntegerCoordinate Y;
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUOrigin3DDict
{
		public GPUIntegerCoordinate X;
		public GPUIntegerCoordinate Y;
		public GPUIntegerCoordinate Z;
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class GPUExtent3DDict
{
		public required GPUIntegerCoordinate Width;
		public GPUIntegerCoordinate Height;
		public GPUIntegerCoordinate DepthOrArrayLayers;
}


///<include file='Utils/Docs/NavigatorLocks/NavigatorLocks.generated.xml' path='docs/NavigatorLocks/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorLocks
{
		public LockManager Locks { get { throw new System.NotImplementedException(); } }
}



///<include file='Utils/Docs/LockManager/LockManager.generated.xml' path='docs/LockManager/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class LockManager
{
	///<include file='Utils/Docs/LockManagerRequest/LockManagerRequest.generated.xml' path='docs/LockManagerRequest/*'/>
	public Task<dynamic> Request(string name, LockGrantedCallback callback) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/LockManagerRequest/LockManagerRequest.generated.xml' path='docs/LockManagerRequest/*'/>
	public Task<dynamic> Request(string name, LockOptions options, LockGrantedCallback callback) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/LockManagerQuery/LockManagerQuery.generated.xml' path='docs/LockManagerQuery/*'/>
	public Task<LockManagerSnapshot> Query() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct LockGrantedCallback
{
}

///<include file='Utils/Docs/LockMode/LockMode.generated.xml' path='docs/LockMode/*'/>
public enum LockMode
{
	Shared,
	Exclusive,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class LockOptions
{
		public LockMode Mode;
		public bool IfAvailable;
		public bool Steal;
		public AbortSignal Signal;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class LockManagerSnapshot
{
		public List<LockInfo> Held;
		public List<LockInfo> Pending;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class LockInfo
{
		public string Name;
		public LockMode Mode;
		public string ClientId;
}

///<include file='Utils/Docs/Lock/Lock.generated.xml' path='docs/Lock/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Lock
{
	///<include file='Utils/Docs/LockName/LockName.generated.xml' path='docs/LockName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs/LockMode/LockMode.generated.xml' path='docs/LockMode/*'/>
	public LockMode Mode { get; }
}

///<include file='Utils/Docs/Navigator/Navigator.generated.xml' path='docs/Navigator/*'/>
public partial class Navigator
{
	///<include file='Utils/Docs/NavigatorRequestMIDIAccess/NavigatorRequestMIDIAccess.generated.xml' path='docs/NavigatorRequestMIDIAccess/*'/>
	public Task<MIDIAccess> RequestMIDIAccess(MIDIOptions options) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MIDIOptions
{
		public bool Sysex;
}

///<include file='Utils/Docs/MIDIInputMap/MIDIInputMap.generated.xml' path='docs/MIDIInputMap/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MIDIInputMap
{
	
}

///<include file='Utils/Docs/MIDIOutputMap/MIDIOutputMap.generated.xml' path='docs/MIDIOutputMap/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MIDIOutputMap
{
	
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct MIDISuccessCallback
{
}

///<include file='Utils/Docs/MIDIAccess/MIDIAccess.generated.xml' path='docs/MIDIAccess/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MIDIAccess : EventTarget
{
	///<include file='Utils/Docs/MIDIAccessInputs/MIDIAccessInputs.generated.xml' path='docs/MIDIAccessInputs/*'/>
	public MIDIInputMap Inputs { get; }
	///<include file='Utils/Docs/MIDIAccessOutputs/MIDIAccessOutputs.generated.xml' path='docs/MIDIAccessOutputs/*'/>
	public MIDIOutputMap Outputs { get; }
		public EventHandler Onstatechange { get; set; }
	///<include file='Utils/Docs/MIDIAccessSysexEnabled/MIDIAccessSysexEnabled.generated.xml' path='docs/MIDIAccessSysexEnabled/*'/>
	public bool SysexEnabled { get; }
}

///<include file='Utils/Docs/MIDIPortType/MIDIPortType.generated.xml' path='docs/MIDIPortType/*'/>
public enum MIDIPortType
{
	Input,
	Output,
}

public enum MIDIPortDeviceState
{
	Disconnected,
	Connected,
}

public enum MIDIPortConnectionState
{
	Open,
	Closed,
	Pending,
}

///<include file='Utils/Docs/MIDIPort/MIDIPort.generated.xml' path='docs/MIDIPort/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MIDIPort : EventTarget
{
	///<include file='Utils/Docs/MIDIPortId/MIDIPortId.generated.xml' path='docs/MIDIPortId/*'/>
	public string Id { get; }
	///<include file='Utils/Docs/MIDIPortManufacturer/MIDIPortManufacturer.generated.xml' path='docs/MIDIPortManufacturer/*'/>
	public string? Manufacturer { get; }
	///<include file='Utils/Docs/MIDIPortName/MIDIPortName.generated.xml' path='docs/MIDIPortName/*'/>
	public string? Name { get; }
	///<include file='Utils/Docs/MIDIPortType/MIDIPortType.generated.xml' path='docs/MIDIPortType/*'/>
	public MIDIPortType Type { get; }
	///<include file='Utils/Docs/MIDIPortVersion/MIDIPortVersion.generated.xml' path='docs/MIDIPortVersion/*'/>
	public string? Version { get; }
	///<include file='Utils/Docs/MIDIPortState/MIDIPortState.generated.xml' path='docs/MIDIPortState/*'/>
	public MIDIPortDeviceState State { get; }
	///<include file='Utils/Docs/MIDIPortConnection/MIDIPortConnection.generated.xml' path='docs/MIDIPortConnection/*'/>
	public MIDIPortConnectionState Connection { get; }
		public EventHandler Onstatechange { get; set; }
	///<include file='Utils/Docs/MIDIPortOpen/MIDIPortOpen.generated.xml' path='docs/MIDIPortOpen/*'/>
	public Task<MIDIPort> Open() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MIDIPortClose/MIDIPortClose.generated.xml' path='docs/MIDIPortClose/*'/>
	public Task<MIDIPort> Close() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/MIDIInput/MIDIInput.generated.xml' path='docs/MIDIInput/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MIDIInput : MIDIPort
{
		public EventHandler Onmidimessage { get; set; }
}

///<include file='Utils/Docs/MIDIOutput/MIDIOutput.generated.xml' path='docs/MIDIOutput/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MIDIOutput : MIDIPort
{
	///<include file='Utils/Docs/MIDIOutputSend/MIDIOutputSend.generated.xml' path='docs/MIDIOutputSend/*'/>
	public Undefined Send(List<byte> data, Number timestamp) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MIDIOutputClear/MIDIOutputClear.generated.xml' path='docs/MIDIOutputClear/*'/>
	public Undefined Clear() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/MIDIMessageEvent/MIDIMessageEvent.generated.xml' path='docs/MIDIMessageEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MIDIMessageEvent : Event
{
	///<include file='Utils/Docs/MIDIMessageEventMIDIMessageEvent/MIDIMessageEventMIDIMessageEvent.generated.xml' path='docs/MIDIMessageEventMIDIMessageEvent/*'/>
	public MIDIMessageEvent(string type, MIDIMessageEventInit eventInitDict) { }
		public Number ReceivedTime { get; }
	///<include file='Utils/Docs/MIDIMessageEventData/MIDIMessageEventData.generated.xml' path='docs/MIDIMessageEventData/*'/>
	public System.Byte Data { get; }
	public MIDIMessageEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MIDIMessageEventInit : EventInit
{
		public Number ReceivedTime;
		public System.Byte Data;
}

///<include file='Utils/Docs/MIDIConnectionEvent/MIDIConnectionEvent.generated.xml' path='docs/MIDIConnectionEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MIDIConnectionEvent : Event
{
	///<include file='Utils/Docs/MIDIConnectionEventMIDIConnectionEvent/MIDIConnectionEventMIDIConnectionEvent.generated.xml' path='docs/MIDIConnectionEventMIDIConnectionEvent/*'/>
	public MIDIConnectionEvent(string type, MIDIConnectionEventInit eventInitDict) { }
	///<include file='Utils/Docs/MIDIConnectionEventPort/MIDIConnectionEventPort.generated.xml' path='docs/MIDIConnectionEventPort/*'/>
	public MIDIPort Port { get; }
	public MIDIConnectionEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MIDIConnectionEventInit : EventInit
{
		public MIDIPort Port;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorML
{
		public ML Ml { get { throw new System.NotImplementedException(); } }
}



public enum MLDeviceType
{
	Cpu,
	Gpu,
}

public enum MLPowerPreference
{
	Default,
	HighPerformance,
	LowPower,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLContextOptions
{
		public MLDeviceType DeviceType;
		public MLPowerPreference PowerPreference;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ML
{
		public Task<MLContext> CreateContext(MLContextOptions options) { throw new System.NotImplementedException(); }
		public Task<MLContext> CreateContext(GPUDevice gpuDevice) { throw new System.NotImplementedException(); }
		public MLContext CreateContextSync(MLContextOptions options) { throw new System.NotImplementedException(); }
		public MLContext CreateContextSync(GPUDevice gpuDevice) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLGraph
{
}

public enum MLInputOperandLayout
{
	Nchw,
	Nhwc,
}

public enum MLOperandType
{
	Float32,
	Float16,
	Int32,
	Uint32,
	Int8,
	Uint8,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLOperandDescriptor
{
		public required MLOperandType Type;
		public List<ulong> Dimensions;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLOperand
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLActivation
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLContext
{
}

public partial class MLContext
{
		public Undefined ComputeSync(MLGraph graph, MLNamedArrayBufferViews inputs, MLNamedArrayBufferViews outputs) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLComputeResult
{
		public MLNamedArrayBufferViews Inputs;
		public MLNamedArrayBufferViews Outputs;
}

public partial class MLContext
{
		public Task<MLComputeResult> Compute(MLGraph graph, MLNamedArrayBufferViews inputs, MLNamedArrayBufferViews outputs) { throw new System.NotImplementedException(); }
}

public partial class MLContext
{
		public MLCommandEncoder CreateCommandEncoder() { throw new System.NotImplementedException(); }
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLCommandEncoder
{
}

public partial class MLCommandEncoder
{
		public Undefined InitializeGraph(MLGraph graph) { throw new System.NotImplementedException(); }
}

public partial class MLCommandEncoder
{
		public Undefined Dispatch(MLGraph graph, MLNamedGPUResources inputs, MLNamedGPUResources outputs) { throw new System.NotImplementedException(); }
}

public partial class MLCommandEncoder
{
		public GPUCommandBuffer Finish(GPUCommandBufferDescriptor descriptor) { throw new System.NotImplementedException(); }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLBufferResourceView
{
		public required GPUBuffer Resource;
		public ulong Offset;
		public ulong Size;
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLGraphBuilder
{
		public MLGraphBuilder(MLContext context) { }
		public MLOperand Input(string name, MLOperandDescriptor descriptor) { throw new System.NotImplementedException(); }
		public MLOperand Constant(MLOperandDescriptor descriptor, MLBufferView bufferView) { throw new System.NotImplementedException(); }
		public MLOperand Constant(Number value, MLOperandType type) { throw new System.NotImplementedException(); }
		public Task<MLGraph> Build(MLNamedOperands outputs) { throw new System.NotImplementedException(); }
		public MLGraph BuildSync(MLNamedOperands outputs) { throw new System.NotImplementedException(); }
	public MLGraphBuilder() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLBatchNormalizationOptions
{
		public MLOperand Scale;
		public MLOperand Bias;
		public ulong Axis;
		public Number Epsilon;
		public MLActivation Activation;
}

public partial class MLGraphBuilder
{
		public MLOperand BatchNormalization(MLOperand input, MLOperand mean, MLOperand variance, MLBatchNormalizationOptions options) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLClampOptions
{
		public Number MinValue;
		public Number MaxValue;
}

public partial class MLGraphBuilder
{
		public MLOperand Clamp(MLOperand operand, MLClampOptions options) { throw new System.NotImplementedException(); }
		public MLActivation Clamp(MLClampOptions options) { throw new System.NotImplementedException(); }
}

public partial class MLGraphBuilder
{
		public MLOperand Concat(List<MLOperand> inputs, ulong axis) { throw new System.NotImplementedException(); }
}

public enum MLConv2dFilterOperandLayout
{
	Oihw,
	Hwio,
	Ohwi,
	Ihwo,
}

public enum MLAutoPad
{
	Explicit,
	SameUpper,
	SameLower,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLConv2dOptions
{
		public List<ulong> Padding;
		public List<ulong> Strides;
		public List<ulong> Dilations;
		public MLAutoPad AutoPad;
		public ulong Groups;
		public MLInputOperandLayout InputLayout;
		public MLConv2dFilterOperandLayout FilterLayout;
		public MLOperand Bias;
		public MLActivation Activation;
}

public partial class MLGraphBuilder
{
		public MLOperand Conv2d(MLOperand input, MLOperand filter, MLConv2dOptions options) { throw new System.NotImplementedException(); }
}

public enum MLConvTranspose2dFilterOperandLayout
{
	Iohw,
	Hwoi,
	Ohwi,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLConvTranspose2dOptions
{
		public List<ulong> Padding;
		public List<ulong> Strides;
		public List<ulong> Dilations;
		public List<ulong> OutputPadding;
		public List<ulong> OutputSizes;
		public MLAutoPad AutoPad;
		public ulong Groups;
		public MLInputOperandLayout InputLayout;
		public MLConvTranspose2dFilterOperandLayout FilterLayout;
		public MLOperand Bias;
		public MLActivation Activation;
}

public partial class MLGraphBuilder
{
		public MLOperand ConvTranspose2d(MLOperand input, MLOperand filter, MLConvTranspose2dOptions options) { throw new System.NotImplementedException(); }
}

public partial class MLGraphBuilder
{
		public MLOperand Add(MLOperand a, MLOperand b) { throw new System.NotImplementedException(); }
		public MLOperand Sub(MLOperand a, MLOperand b) { throw new System.NotImplementedException(); }
		public MLOperand Mul(MLOperand a, MLOperand b) { throw new System.NotImplementedException(); }
		public MLOperand Div(MLOperand a, MLOperand b) { throw new System.NotImplementedException(); }
		public MLOperand Max(MLOperand a, MLOperand b) { throw new System.NotImplementedException(); }
		public MLOperand Min(MLOperand a, MLOperand b) { throw new System.NotImplementedException(); }
		public MLOperand Pow(MLOperand a, MLOperand b) { throw new System.NotImplementedException(); }
}

public partial class MLGraphBuilder
{
		public MLOperand Abs(MLOperand input) { throw new System.NotImplementedException(); }
		public MLOperand Ceil(MLOperand input) { throw new System.NotImplementedException(); }
		public MLOperand Cos(MLOperand input) { throw new System.NotImplementedException(); }
		public MLOperand Exp(MLOperand input) { throw new System.NotImplementedException(); }
		public MLOperand Floor(MLOperand input) { throw new System.NotImplementedException(); }
		public MLOperand Log(MLOperand input) { throw new System.NotImplementedException(); }
		public MLOperand Neg(MLOperand input) { throw new System.NotImplementedException(); }
		public MLOperand Sin(MLOperand input) { throw new System.NotImplementedException(); }
		public MLOperand Tan(MLOperand input) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLEluOptions
{
		public Number Alpha;
}

public partial class MLGraphBuilder
{
		public MLOperand Elu(MLOperand input, MLEluOptions options) { throw new System.NotImplementedException(); }
		public MLActivation Elu(MLEluOptions options) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLGemmOptions
{
		public MLOperand C;
		public Number Alpha;
		public Number Beta;
		public bool ATranspose;
		public bool BTranspose;
}

public partial class MLGraphBuilder
{
		public MLOperand Gemm(MLOperand a, MLOperand b, MLGemmOptions options) { throw new System.NotImplementedException(); }
}

public enum MLGruWeightLayout
{
	Zrn,
	Rzn,
}

public enum MLRecurrentNetworkDirection
{
	Forward,
	Backward,
	Both,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLGruOptions
{
		public MLOperand Bias;
		public MLOperand RecurrentBias;
		public MLOperand InitialHiddenState;
		public bool ResetAfter;
		public bool ReturnSequence;
		public MLRecurrentNetworkDirection Direction;
		public MLGruWeightLayout Layout;
		public List<MLActivation> Activations;
}

public partial class MLGraphBuilder
{
		public List<MLOperand> Gru(MLOperand input, MLOperand weight, MLOperand recurrentWeight, ulong steps, ulong hiddenSize, MLGruOptions options) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLGruCellOptions
{
		public MLOperand Bias;
		public MLOperand RecurrentBias;
		public bool ResetAfter;
		public MLGruWeightLayout Layout;
		public List<MLActivation> Activations;
}

public partial class MLGraphBuilder
{
		public MLOperand GruCell(MLOperand input, MLOperand weight, MLOperand recurrentWeight, MLOperand hiddenState, ulong hiddenSize, MLGruCellOptions options) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLHardSigmoidOptions
{
		public Number Alpha;
		public Number Beta;
}

public partial class MLGraphBuilder
{
		public MLOperand HardSigmoid(MLOperand input, MLHardSigmoidOptions options) { throw new System.NotImplementedException(); }
		public MLActivation HardSigmoid(MLHardSigmoidOptions options) { throw new System.NotImplementedException(); }
}

public partial class MLGraphBuilder
{
		public MLOperand HardSwish(MLOperand input) { throw new System.NotImplementedException(); }
		public MLActivation HardSwish() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLInstanceNormalizationOptions
{
		public MLOperand Scale;
		public MLOperand Bias;
		public Number Epsilon;
		public MLInputOperandLayout Layout;
}

public partial class MLGraphBuilder
{
		public MLOperand InstanceNormalization(MLOperand input, MLInstanceNormalizationOptions options) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLLeakyReluOptions
{
		public Number Alpha;
}

public partial class MLGraphBuilder
{
		public MLOperand LeakyRelu(MLOperand input, MLLeakyReluOptions options) { throw new System.NotImplementedException(); }
		public MLActivation LeakyRelu(MLLeakyReluOptions options) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLLinearOptions
{
		public Number Alpha;
		public Number Beta;
}

public partial class MLGraphBuilder
{
		public MLOperand Linear(MLOperand input, MLLinearOptions options) { throw new System.NotImplementedException(); }
		public MLActivation Linear(MLLinearOptions options) { throw new System.NotImplementedException(); }
}

public enum MLLstmWeightLayout
{
	Iofg,
	Ifgo,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLLstmOptions
{
		public MLOperand Bias;
		public MLOperand RecurrentBias;
		public MLOperand PeepholeWeight;
		public MLOperand InitialHiddenState;
		public MLOperand InitialCellState;
		public bool ReturnSequence;
		public MLRecurrentNetworkDirection Direction;
		public MLLstmWeightLayout Layout;
		public List<MLActivation> Activations;
}

public partial class MLGraphBuilder
{
		public List<MLOperand> Lstm(MLOperand input, MLOperand weight, MLOperand recurrentWeight, ulong steps, ulong hiddenSize, MLLstmOptions options) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLLstmCellOptions
{
		public MLOperand Bias;
		public MLOperand RecurrentBias;
		public MLOperand PeepholeWeight;
		public MLLstmWeightLayout Layout;
		public List<MLActivation> Activations;
}

public partial class MLGraphBuilder
{
		public List<MLOperand> LstmCell(MLOperand input, MLOperand weight, MLOperand recurrentWeight, MLOperand hiddenState, MLOperand cellState, ulong hiddenSize, MLLstmCellOptions options) { throw new System.NotImplementedException(); }
}

public partial class MLGraphBuilder
{
		public MLOperand Matmul(MLOperand a, MLOperand b) { throw new System.NotImplementedException(); }
}

public enum MLPaddingMode
{
	Constant,
	Edge,
	Reflection,
	Symmetric,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLPadOptions
{
		public MLPaddingMode Mode;
		public Number Value;
}

public partial class MLGraphBuilder
{
		public MLOperand Pad(MLOperand input, List<ulong> beginningPadding, List<ulong> endingPadding, MLPadOptions options) { throw new System.NotImplementedException(); }
}

public enum MLRoundingType
{
	Floor,
	Ceil,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLPool2dOptions
{
		public List<ulong> WindowDimensions;
		public List<ulong> Padding;
		public List<ulong> Strides;
		public List<ulong> Dilations;
		public MLAutoPad AutoPad;
		public MLInputOperandLayout Layout;
		public MLRoundingType RoundingType;
		public List<ulong> OutputSizes;
}

public partial class MLGraphBuilder
{
		public MLOperand AveragePool2d(MLOperand input, MLPool2dOptions options) { throw new System.NotImplementedException(); }
		public MLOperand L2Pool2d(MLOperand input, MLPool2dOptions options) { throw new System.NotImplementedException(); }
		public MLOperand MaxPool2d(MLOperand input, MLPool2dOptions options) { throw new System.NotImplementedException(); }
}

public partial class MLGraphBuilder
{
		public MLOperand Prelu(MLOperand input, MLOperand slope) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLReduceOptions
{
		public List<ulong> Axes;
		public bool KeepDimensions;
}

public partial class MLGraphBuilder
{
		public MLOperand ReduceL1(MLOperand input, MLReduceOptions options) { throw new System.NotImplementedException(); }
		public MLOperand ReduceL2(MLOperand input, MLReduceOptions options) { throw new System.NotImplementedException(); }
		public MLOperand ReduceLogSum(MLOperand input, MLReduceOptions options) { throw new System.NotImplementedException(); }
		public MLOperand ReduceLogSumExp(MLOperand input, MLReduceOptions options) { throw new System.NotImplementedException(); }
		public MLOperand ReduceMax(MLOperand input, MLReduceOptions options) { throw new System.NotImplementedException(); }
		public MLOperand ReduceMean(MLOperand input, MLReduceOptions options) { throw new System.NotImplementedException(); }
		public MLOperand ReduceMin(MLOperand input, MLReduceOptions options) { throw new System.NotImplementedException(); }
		public MLOperand ReduceProduct(MLOperand input, MLReduceOptions options) { throw new System.NotImplementedException(); }
		public MLOperand ReduceSum(MLOperand input, MLReduceOptions options) { throw new System.NotImplementedException(); }
		public MLOperand ReduceSumSquare(MLOperand input, MLReduceOptions options) { throw new System.NotImplementedException(); }
}

public partial class MLGraphBuilder
{
		public MLOperand Relu(MLOperand input) { throw new System.NotImplementedException(); }
		public MLActivation Relu() { throw new System.NotImplementedException(); }
}

public enum MLInterpolationMode
{
	NearestNeighbor,
	Linear,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLResample2dOptions
{
		public MLInterpolationMode Mode;
		public List<Number> Scales;
		public List<ulong> Sizes;
		public List<ulong> Axes;
}

public partial class MLGraphBuilder
{
		public MLOperand Resample2d(MLOperand input, MLResample2dOptions options) { throw new System.NotImplementedException(); }
}

public partial class MLGraphBuilder
{
		public MLOperand Reshape(MLOperand input, List<ulong?> newShape) { throw new System.NotImplementedException(); }
}

public partial class MLGraphBuilder
{
		public MLOperand Sigmoid(MLOperand input) { throw new System.NotImplementedException(); }
		public MLActivation Sigmoid() { throw new System.NotImplementedException(); }
}

public partial class MLGraphBuilder
{
		public MLOperand Slice(MLOperand input, List<ulong> starts, List<ulong> sizes) { throw new System.NotImplementedException(); }
}

public partial class MLGraphBuilder
{
		public MLOperand Softmax(MLOperand input) { throw new System.NotImplementedException(); }
		public MLActivation Softmax() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLSoftplusOptions
{
		public Number Steepness;
}

public partial class MLGraphBuilder
{
		public MLOperand Softplus(MLOperand input, MLSoftplusOptions options) { throw new System.NotImplementedException(); }
		public MLActivation Softplus(MLSoftplusOptions options) { throw new System.NotImplementedException(); }
}

public partial class MLGraphBuilder
{
		public MLOperand Softsign(MLOperand input) { throw new System.NotImplementedException(); }
		public MLActivation Softsign() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLSplitOptions
{
		public ulong Axis;
}

public partial class MLGraphBuilder
{
		public List<MLOperand> Split(MLOperand input, Union108 splits, MLSplitOptions options) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLSqueezeOptions
{
		public List<ulong> Axes;
}

public partial class MLGraphBuilder
{
		public MLOperand Squeeze(MLOperand input, MLSqueezeOptions options) { throw new System.NotImplementedException(); }
}

public partial class MLGraphBuilder
{
		public MLOperand Tanh(MLOperand input) { throw new System.NotImplementedException(); }
		public MLActivation Tanh() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MLTransposeOptions
{
		public List<ulong> Permutation;
}

public partial class MLGraphBuilder
{
		public MLOperand Transpose(MLOperand input, MLTransposeOptions options) { throw new System.NotImplementedException(); }
}


///<include file='Utils/Docs/RTCRtpSender/RTCRtpSender.generated.xml' path='docs/RTCRtpSender/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class RTCRtpSender
{
		public RTCRtpTransform? Transform { get; set; }
}

///<include file='Utils/Docs/RTCRtpReceiver/RTCRtpReceiver.generated.xml' path='docs/RTCRtpReceiver/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class RTCRtpReceiver
{
		public RTCRtpTransform? Transform { get; set; }
}

public enum SFrameTransformRole
{
	Encrypt,
	Decrypt,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class SFrameTransformOptions
{
		public SFrameTransformRole Role;
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial class SFrameTransform : EventTarget, GenericTransformStream
{
		public SFrameTransform(SFrameTransformOptions options) { }
		public Task<Undefined> SetEncryptionKey(Unsupported /*CryptoKey*/ key, CryptoKeyID keyID) { throw new System.NotImplementedException(); }
		public EventHandler Onerror { get; set; }
	public SFrameTransform() { }
}


public enum SFrameTransformErrorEventType
{
	Authentication,
	KeyID,
	Syntax,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class SFrameTransformErrorEvent : Event
{
		public SFrameTransformErrorEvent(string type, SFrameTransformErrorEventInit eventInitDict) { }
		public SFrameTransformErrorEventType ErrorType { get; }
		public CryptoKeyID? KeyID { get; }
		public dynamic Frame { get; }
	public SFrameTransformErrorEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class SFrameTransformErrorEventInit : EventInit
{
		public required SFrameTransformErrorEventType ErrorType;
		public required dynamic Frame;
		public CryptoKeyID? KeyID;
}

public enum RTCEncodedVideoFrameType
{
	Empty,
	Key,
	Delta,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class RTCEncodedVideoFrameMetadata
{
		public ulong FrameId;
		public List<ulong> Dependencies;
		public ushort Width;
		public ushort Height;
		public ulong SpatialIndex;
		public ulong TemporalIndex;
		public ulong SynchronizationSource;
		public byte PayloadType;
		public List<ulong> ContributingSources;
		public long Timestamp;
		public ulong RtpTimestamp;
		public string MimeType;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class RTCEncodedVideoFrame
{
		public RTCEncodedVideoFrameType Type { get; }
		public byte[] Data { get; set; }
		public RTCEncodedVideoFrameMetadata GetMetadata() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class RTCEncodedAudioFrameMetadata
{
		public ulong SynchronizationSource;
		public byte PayloadType;
		public List<ulong> ContributingSources;
		public Number SequenceNumber;
		public ulong RtpTimestamp;
		public string MimeType;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class RTCEncodedAudioFrame
{
		public byte[] Data { get; set; }
		public RTCEncodedAudioFrameMetadata GetMetadata() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class RTCTransformEvent : Event
{
		public RTCRtpScriptTransformer Transformer { get; }
}

///<include file='Utils/Docs/DedicatedWorkerGlobalScope/DedicatedWorkerGlobalScope.generated.xml' path='docs/DedicatedWorkerGlobalScope/*'/>
public partial class DedicatedWorkerGlobalScope
{
		public EventHandler Onrtctransform { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class RTCRtpScriptTransformer
{
		public ReadableStream Readable { get; }
		public WritableStream Writable { get; }
		public dynamic Options { get; }
		public Task<ulong> GenerateKeyFrame(string rid) { throw new System.NotImplementedException(); }
		public Task<Undefined> SendKeyFrameRequest() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class RTCRtpScriptTransform
{
		public RTCRtpScriptTransform(Worker worker, dynamic options, List<object> transfer) { }
	public RTCRtpScriptTransform() { }
}

///<include file='Utils/Docs/RTCRtpSender/RTCRtpSender.generated.xml' path='docs/RTCRtpSender/*'/>
public partial class RTCRtpSender
{
		public Task<Undefined> GenerateKeyFrame(List<string> rids) { throw new System.NotImplementedException(); }
}

public enum RTCPriorityType
{
	VeryLow,
	Low,
	Medium,
	High,
}

///<include file='Utils/Docs/RTCRtpEncodingParameters/RTCRtpEncodingParameters.generated.xml' path='docs/RTCRtpEncodingParameters/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class RTCRtpEncodingParameters
{
		public RTCPriorityType Priority;
		public RTCPriorityType NetworkPriority;
}

///<include file='Utils/Docs/RTCDataChannel/RTCDataChannel.generated.xml' path='docs/RTCDataChannel/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class RTCDataChannel
{
		public RTCPriorityType Priority { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class RTCDataChannelInit
{
		public RTCPriorityType Priority;
}

///<include file='Utils/Docs/WebTransportDatagramDuplexStream/WebTransportDatagramDuplexStream.generated.xml' path='docs/WebTransportDatagramDuplexStream/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebTransportDatagramDuplexStream
{
	///<include file='Utils/Docs/WebTransportDatagramDuplexStreamReadable/WebTransportDatagramDuplexStreamReadable.generated.xml' path='docs/WebTransportDatagramDuplexStreamReadable/*'/>
	public ReadableStream Readable { get; }
	///<include file='Utils/Docs/WebTransportDatagramDuplexStreamWritable/WebTransportDatagramDuplexStreamWritable.generated.xml' path='docs/WebTransportDatagramDuplexStreamWritable/*'/>
	public WritableStream Writable { get; }
	///<include file='Utils/Docs/WebTransportDatagramDuplexStreamMaxDatagramSize/WebTransportDatagramDuplexStreamMaxDatagramSize.generated.xml' path='docs/WebTransportDatagramDuplexStreamMaxDatagramSize/*'/>
	public ulong MaxDatagramSize { get; }
	///<include file='Utils/Docs/WebTransportDatagramDuplexStreamIncomingMaxAge/WebTransportDatagramDuplexStreamIncomingMaxAge.generated.xml' path='docs/WebTransportDatagramDuplexStreamIncomingMaxAge/*'/>
	public double IncomingMaxAge { get; set; }
	///<include file='Utils/Docs/WebTransportDatagramDuplexStreamOutgoingMaxAge/WebTransportDatagramDuplexStreamOutgoingMaxAge.generated.xml' path='docs/WebTransportDatagramDuplexStreamOutgoingMaxAge/*'/>
	public double OutgoingMaxAge { get; set; }
	///<include file='Utils/Docs/WebTransportDatagramDuplexStreamIncomingHighWaterMark/WebTransportDatagramDuplexStreamIncomingHighWaterMark.generated.xml' path='docs/WebTransportDatagramDuplexStreamIncomingHighWaterMark/*'/>
	public double IncomingHighWaterMark { get; set; }
	///<include file='Utils/Docs/WebTransportDatagramDuplexStreamOutgoingHighWaterMark/WebTransportDatagramDuplexStreamOutgoingHighWaterMark.generated.xml' path='docs/WebTransportDatagramDuplexStreamOutgoingHighWaterMark/*'/>
	public double OutgoingHighWaterMark { get; set; }
}

///<include file='Utils/Docs/WebTransport/WebTransport.generated.xml' path='docs/WebTransport/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebTransport
{
	///<include file='Utils/Docs/WebTransportWebTransport/WebTransportWebTransport.generated.xml' path='docs/WebTransportWebTransport/*'/>
	public WebTransport(string url, WebTransportOptions options) { }
	///<include file='Utils/Docs/WebTransportGetStats/WebTransportGetStats.generated.xml' path='docs/WebTransportGetStats/*'/>
	public Task<WebTransportStats> GetStats() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WebTransportReady/WebTransportReady.generated.xml' path='docs/WebTransportReady/*'/>
	public Task<Undefined> Ready { get; }
	///<include file='Utils/Docs/WebTransportReliability/WebTransportReliability.generated.xml' path='docs/WebTransportReliability/*'/>
	public WebTransportReliabilityMode Reliability { get; }
	///<include file='Utils/Docs/WebTransportCongestionControl/WebTransportCongestionControl.generated.xml' path='docs/WebTransportCongestionControl/*'/>
	public WebTransportCongestionControl CongestionControl { get; }
	///<include file='Utils/Docs/WebTransportClosed/WebTransportClosed.generated.xml' path='docs/WebTransportClosed/*'/>
	public Task<WebTransportCloseInfo> Closed { get; }
		public Task<Undefined> Draining { get; }
	///<include file='Utils/Docs/WebTransportClose/WebTransportClose.generated.xml' path='docs/WebTransportClose/*'/>
	public Undefined Close(WebTransportCloseInfo closeInfo) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WebTransportDatagrams/WebTransportDatagrams.generated.xml' path='docs/WebTransportDatagrams/*'/>
	public WebTransportDatagramDuplexStream Datagrams { get; }
	///<include file='Utils/Docs/WebTransportCreateBidirectionalStream/WebTransportCreateBidirectionalStream.generated.xml' path='docs/WebTransportCreateBidirectionalStream/*'/>
	public Task<WebTransportBidirectionalStream> CreateBidirectionalStream(WebTransportSendStreamOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WebTransportIncomingBidirectionalStreams/WebTransportIncomingBidirectionalStreams.generated.xml' path='docs/WebTransportIncomingBidirectionalStreams/*'/>
	public ReadableStream IncomingBidirectionalStreams { get; }
	///<include file='Utils/Docs/WebTransportCreateUnidirectionalStream/WebTransportCreateUnidirectionalStream.generated.xml' path='docs/WebTransportCreateUnidirectionalStream/*'/>
	public Task<WebTransportSendStream> CreateUnidirectionalStream(WebTransportSendStreamOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WebTransportIncomingUnidirectionalStreams/WebTransportIncomingUnidirectionalStreams.generated.xml' path='docs/WebTransportIncomingUnidirectionalStreams/*'/>
	public ReadableStream IncomingUnidirectionalStreams { get; }
	public WebTransport() { }
}

public enum WebTransportReliabilityMode
{
	Pending,
	ReliableOnly,
	SupportsUnreliable,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebTransportHash
{
		public string Algorithm;
		public BufferSource Value;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebTransportOptions
{
		public bool AllowPooling;
		public bool RequireUnreliable;
		public List<WebTransportHash> ServerCertificateHashes;
		public WebTransportCongestionControl CongestionControl;
}

///<include file='Utils/Docs/WebTransportCongestionControl/WebTransportCongestionControl.generated.xml' path='docs/WebTransportCongestionControl/*'/>
public enum WebTransportCongestionControl
{
	Default,
	Throughput,
	LowLatency,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebTransportCloseInfo
{
		public ulong CloseCode;
		public string Reason;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebTransportSendStreamOptions
{
		public long? SendOrder;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebTransportStats
{
		public Unsupported /*DOMHighResTimeStamp*/ Timestamp;
		public ulong BytesSent;
		public ulong PacketsSent;
		public ulong PacketsLost;
		public ulong NumOutgoingStreamsCreated;
		public ulong NumIncomingStreamsCreated;
		public ulong BytesReceived;
		public ulong PacketsReceived;
		public Unsupported /*DOMHighResTimeStamp*/ SmoothedRtt;
		public Unsupported /*DOMHighResTimeStamp*/ RttVariation;
		public Unsupported /*DOMHighResTimeStamp*/ MinRtt;
		public WebTransportDatagramStats Datagrams;
		public ulong? EstimatedSendRate;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebTransportDatagramStats
{
		public Unsupported /*DOMHighResTimeStamp*/ Timestamp;
		public ulong ExpiredOutgoing;
		public ulong DroppedIncoming;
		public ulong LostOutgoing;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebTransportSendStream : WritableStream
{
		public long? SendOrder { get; set; }
		public Task<WebTransportSendStreamStats> GetStats() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebTransportSendStreamStats
{
		public Unsupported /*DOMHighResTimeStamp*/ Timestamp;
		public ulong BytesWritten;
		public ulong BytesSent;
		public ulong BytesAcknowledged;
}

///<include file='Utils/Docs/WebTransportReceiveStream/WebTransportReceiveStream.generated.xml' path='docs/WebTransportReceiveStream/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebTransportReceiveStream : ReadableStream
{
	///<include file='Utils/Docs/WebTransportReceiveStreamGetStats/WebTransportReceiveStreamGetStats.generated.xml' path='docs/WebTransportReceiveStreamGetStats/*'/>
	public Task<WebTransportReceiveStreamStats> GetStats() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebTransportReceiveStreamStats
{
		public Unsupported /*DOMHighResTimeStamp*/ Timestamp;
		public ulong BytesReceived;
		public ulong BytesRead;
}

///<include file='Utils/Docs/WebTransportBidirectionalStream/WebTransportBidirectionalStream.generated.xml' path='docs/WebTransportBidirectionalStream/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebTransportBidirectionalStream
{
	///<include file='Utils/Docs/WebTransportBidirectionalStreamReadable/WebTransportBidirectionalStreamReadable.generated.xml' path='docs/WebTransportBidirectionalStreamReadable/*'/>
	public WebTransportReceiveStream Readable { get; }
	///<include file='Utils/Docs/WebTransportBidirectionalStreamWritable/WebTransportBidirectionalStreamWritable.generated.xml' path='docs/WebTransportBidirectionalStreamWritable/*'/>
	public WebTransportSendStream Writable { get; }
}

///<include file='Utils/Docs/WebTransportError/WebTransportError.generated.xml' path='docs/WebTransportError/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebTransportError : DOMException
{
	///<include file='Utils/Docs/WebTransportErrorWebTransportError/WebTransportErrorWebTransportError.generated.xml' path='docs/WebTransportErrorWebTransportError/*'/>
	public WebTransportError(string message, WebTransportErrorOptions options) { }
	///<include file='Utils/Docs/WebTransportErrorSource/WebTransportErrorSource.generated.xml' path='docs/WebTransportErrorSource/*'/>
	public WebTransportErrorSource Source { get; }
	///<include file='Utils/Docs/WebTransportErrorStreamErrorCode/WebTransportErrorStreamErrorCode.generated.xml' path='docs/WebTransportErrorStreamErrorCode/*'/>
	public ulong? StreamErrorCode { get; }
	public WebTransportError() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebTransportErrorOptions
{
		public WebTransportErrorSource Source;
		public ulong? StreamErrorCode;
}

///<include file='Utils/Docs/WebTransportErrorSource/WebTransportErrorSource.generated.xml' path='docs/WebTransportErrorSource/*'/>
public enum WebTransportErrorSource
{
	Stream,
	Session,
}

public enum AutoKeyword
{
	Auto,
}


public enum DirectionSetting
{
	Empty,
	Rl,
	Lr,
}

public enum LineAlignSetting
{
	Start,
	Center,
	End,
}

public enum PositionAlignSetting
{
	LineLeft,
	Center,
	LineRight,
	Auto,
}

public enum AlignSetting
{
	Start,
	Center,
	End,
	Left,
	Right,
}

///<include file='Utils/Docs/VTTCue/VTTCue.generated.xml' path='docs/VTTCue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class VTTCue : TextTrackCue
{
	///<include file='Utils/Docs/VTTCueVTTCue/VTTCueVTTCue.generated.xml' path='docs/VTTCueVTTCue/*'/>
	public VTTCue(Number startTime, Number endTime, string text) { }
	///<include file='Utils/Docs/VTTCueRegion/VTTCueRegion.generated.xml' path='docs/VTTCueRegion/*'/>
	public VTTRegion? Region { get; set; }
	///<include file='Utils/Docs/VTTCueVertical/VTTCueVertical.generated.xml' path='docs/VTTCueVertical/*'/>
	public DirectionSetting Vertical { get; set; }
	///<include file='Utils/Docs/VTTCueSnapToLines/VTTCueSnapToLines.generated.xml' path='docs/VTTCueSnapToLines/*'/>
	public bool SnapToLines { get; set; }
	///<include file='Utils/Docs/VTTCueLine/VTTCueLine.generated.xml' path='docs/VTTCueLine/*'/>
	public LineAndPositionSetting Line { get; set; }
	///<include file='Utils/Docs/VTTCueLineAlign/VTTCueLineAlign.generated.xml' path='docs/VTTCueLineAlign/*'/>
	public LineAlignSetting LineAlign { get; set; }
	///<include file='Utils/Docs/VTTCuePosition/VTTCuePosition.generated.xml' path='docs/VTTCuePosition/*'/>
	public LineAndPositionSetting Position { get; set; }
	///<include file='Utils/Docs/VTTCuePositionAlign/VTTCuePositionAlign.generated.xml' path='docs/VTTCuePositionAlign/*'/>
	public PositionAlignSetting PositionAlign { get; set; }
	///<include file='Utils/Docs/VTTCueSize/VTTCueSize.generated.xml' path='docs/VTTCueSize/*'/>
	public Number Size { get; set; }
	///<include file='Utils/Docs/VTTCueAlign/VTTCueAlign.generated.xml' path='docs/VTTCueAlign/*'/>
	public AlignSetting Align { get; set; }
	///<include file='Utils/Docs/VTTCueText/VTTCueText.generated.xml' path='docs/VTTCueText/*'/>
	public string Text { get; set; }
	///<include file='Utils/Docs/VTTCueGetCueAsHTML/VTTCueGetCueAsHTML.generated.xml' path='docs/VTTCueGetCueAsHTML/*'/>
	public DocumentFragment GetCueAsHTML() { throw new System.NotImplementedException(); }
	public VTTCue() { }
}

public enum ScrollSetting
{
	Empty,
	Up,
}

///<include file='Utils/Docs/VTTRegion/VTTRegion.generated.xml' path='docs/VTTRegion/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class VTTRegion
{
		public VTTRegion() { }
		public string Id { get; set; }
		public Number Width { get; set; }
		public ulong Lines { get; set; }
		public Number RegionAnchorX { get; set; }
		public Number RegionAnchorY { get; set; }
		public Number ViewportAnchorX { get; set; }
		public Number ViewportAnchorY { get; set; }
		public ScrollSetting Scroll { get; set; }
}

public enum XREnvironmentBlendMode
{
	Opaque,
	AlphaBlend,
	Additive,
}

///<include file='Utils/Docs/XRSession/XRSession.generated.xml' path='docs/XRSession/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRSession
{
	///<include file='Utils/Docs/XRSessionEnvironmentBlendMode/XRSessionEnvironmentBlendMode.generated.xml' path='docs/XRSessionEnvironmentBlendMode/*'/>
	public XREnvironmentBlendMode EnvironmentBlendMode { get; }
}

public enum XRInteractionMode
{
	ScreenSpace,
	WorldSpace,
}

///<include file='Utils/Docs/XRSession/XRSession.generated.xml' path='docs/XRSession/*'/>
public partial class XRSession
{
	///<include file='Utils/Docs/XRSessionInteractionMode/XRSessionInteractionMode.generated.xml' path='docs/XRSessionInteractionMode/*'/>
	public XRInteractionMode InteractionMode { get; }
}

///<include file='Utils/Docs/XRView/XRView.generated.xml' path='docs/XRView/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRView
{
	///<include file='Utils/Docs/XRViewIsFirstPersonObserver/XRViewIsFirstPersonObserver.generated.xml' path='docs/XRViewIsFirstPersonObserver/*'/>
	public bool IsFirstPersonObserver { get; }
}

public enum XRDepthUsage
{
	CpuOptimized,
	GpuOptimized,
}

public enum XRDepthDataFormat
{
	LuminanceAlpha,
	Float32,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRDepthStateInit
{
		public required List<XRDepthUsage> UsagePreference;
		public required List<XRDepthDataFormat> DataFormatPreference;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRSessionInit
{
		public XRDepthStateInit DepthSensing;
}

///<include file='Utils/Docs/XRSession/XRSession.generated.xml' path='docs/XRSession/*'/>
public partial class XRSession
{
	///<include file='Utils/Docs/XRSessionDepthUsage/XRSessionDepthUsage.generated.xml' path='docs/XRSessionDepthUsage/*'/>
	public XRDepthUsage DepthUsage { get; }
	///<include file='Utils/Docs/XRSessionDepthDataFormat/XRSessionDepthDataFormat.generated.xml' path='docs/XRSessionDepthDataFormat/*'/>
	public XRDepthDataFormat DepthDataFormat { get; }
}

///<include file='Utils/Docs/XRDepthInformation/XRDepthInformation.generated.xml' path='docs/XRDepthInformation/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRDepthInformation
{
	///<include file='Utils/Docs/XRDepthInformationWidth/XRDepthInformationWidth.generated.xml' path='docs/XRDepthInformationWidth/*'/>
	public ulong Width { get; }
	///<include file='Utils/Docs/XRDepthInformationHeight/XRDepthInformationHeight.generated.xml' path='docs/XRDepthInformationHeight/*'/>
	public ulong Height { get; }
	///<include file='Utils/Docs/XRDepthInformationNormDepthBufferFromNormView/XRDepthInformationNormDepthBufferFromNormView.generated.xml' path='docs/XRDepthInformationNormDepthBufferFromNormView/*'/>
	public XRRigidTransform NormDepthBufferFromNormView { get; }
	///<include file='Utils/Docs/XRDepthInformationRawValueToMeters/XRDepthInformationRawValueToMeters.generated.xml' path='docs/XRDepthInformationRawValueToMeters/*'/>
	public Number RawValueToMeters { get; }
}

///<include file='Utils/Docs/XRCPUDepthInformation/XRCPUDepthInformation.generated.xml' path='docs/XRCPUDepthInformation/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRCPUDepthInformation : XRDepthInformation
{
	///<include file='Utils/Docs/XRCPUDepthInformationData/XRCPUDepthInformationData.generated.xml' path='docs/XRCPUDepthInformationData/*'/>
	public byte[] Data { get; }
	///<include file='Utils/Docs/XRCPUDepthInformationGetDepthInMeters/XRCPUDepthInformationGetDepthInMeters.generated.xml' path='docs/XRCPUDepthInformationGetDepthInMeters/*'/>
	public Number GetDepthInMeters(Number x, Number y) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XRFrame/XRFrame.generated.xml' path='docs/XRFrame/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRFrame
{
	///<include file='Utils/Docs/XRFrameGetDepthInformation/XRFrameGetDepthInformation.generated.xml' path='docs/XRFrameGetDepthInformation/*'/>
	public XRCPUDepthInformation? GetDepthInformation(XRView view) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XRWebGLDepthInformation/XRWebGLDepthInformation.generated.xml' path='docs/XRWebGLDepthInformation/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRWebGLDepthInformation : XRDepthInformation
{
	///<include file='Utils/Docs/XRWebGLDepthInformationTexture/XRWebGLDepthInformationTexture.generated.xml' path='docs/XRWebGLDepthInformationTexture/*'/>
	public Unsupported /*WebGLTexture*/ Texture { get; }
}

///<include file='Utils/Docs/XRWebGLBinding/XRWebGLBinding.generated.xml' path='docs/XRWebGLBinding/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRWebGLBinding
{
	///<include file='Utils/Docs/XRWebGLBindingGetDepthInformation/XRWebGLBindingGetDepthInformation.generated.xml' path='docs/XRWebGLBindingGetDepthInformation/*'/>
	public XRWebGLDepthInformation? GetDepthInformation(XRView view) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Navigator/Navigator.generated.xml' path='docs/Navigator/*'/>
public partial class Navigator
{
	///<include file='Utils/Docs/NavigatorXr/NavigatorXr.generated.xml' path='docs/NavigatorXr/*'/>
	public XRSystem Xr { get; }
}

///<include file='Utils/Docs/XRSystem/XRSystem.generated.xml' path='docs/XRSystem/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRSystem : EventTarget
{
	///<include file='Utils/Docs/XRSystemIsSessionSupported/XRSystemIsSessionSupported.generated.xml' path='docs/XRSystemIsSessionSupported/*'/>
	public Task<bool> IsSessionSupported(XRSessionMode mode) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRSystemRequestSession/XRSystemRequestSession.generated.xml' path='docs/XRSystemRequestSession/*'/>
	public Task<XRSession> RequestSession(XRSessionMode mode, XRSessionInit options) { throw new System.NotImplementedException(); }
		public EventHandler Ondevicechange { get; set; }
}

public enum XRSessionMode
{
	Inline,
	ImmersiveVr,
	ImmersiveAr,
}

public partial class XRSessionInit
{
		public List<string> RequiredFeatures;
		public List<string> OptionalFeatures;
}

public enum XRVisibilityState
{
	Visible,
	VisibleBlurred,
	Hidden,
}

///<include file='Utils/Docs/XRSession/XRSession.generated.xml' path='docs/XRSession/*'/>
public partial class XRSession : EventTarget
{
	///<include file='Utils/Docs/XRSessionVisibilityState/XRSessionVisibilityState.generated.xml' path='docs/XRSessionVisibilityState/*'/>
	public XRVisibilityState VisibilityState { get; }
		public Number? FrameRate { get; }
		public System.Single? SupportedFrameRates { get; }
	///<include file='Utils/Docs/XRSessionRenderState/XRSessionRenderState.generated.xml' path='docs/XRSessionRenderState/*'/>
	public XRRenderState RenderState { get; }
	///<include file='Utils/Docs/XRSessionInputSources/XRSessionInputSources.generated.xml' path='docs/XRSessionInputSources/*'/>
	public XRInputSourceArray InputSources { get; }
		public string[] EnabledFeatures { get; }
		public bool IsSystemKeyboardSupported { get; }
	///<include file='Utils/Docs/XRSessionUpdateRenderState/XRSessionUpdateRenderState.generated.xml' path='docs/XRSessionUpdateRenderState/*'/>
	public Undefined UpdateRenderState(XRRenderStateInit state) { throw new System.NotImplementedException(); }
		public Task<Undefined> UpdateTargetFrameRate(Number rate) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRSessionRequestReferenceSpace/XRSessionRequestReferenceSpace.generated.xml' path='docs/XRSessionRequestReferenceSpace/*'/>
	public Task<XRReferenceSpace> RequestReferenceSpace(XRReferenceSpaceType type) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRSessionRequestAnimationFrame/XRSessionRequestAnimationFrame.generated.xml' path='docs/XRSessionRequestAnimationFrame/*'/>
	public ulong RequestAnimationFrame(XRFrameRequestCallback callback) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRSessionCancelAnimationFrame/XRSessionCancelAnimationFrame.generated.xml' path='docs/XRSessionCancelAnimationFrame/*'/>
	public Undefined CancelAnimationFrame(ulong handle) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRSessionEnd/XRSessionEnd.generated.xml' path='docs/XRSessionEnd/*'/>
	public Task<Undefined> End() { throw new System.NotImplementedException(); }
		public EventHandler Onend { get; set; }
		public EventHandler Oninputsourceschange { get; set; }
		public EventHandler Onselect { get; set; }
		public EventHandler Onselectstart { get; set; }
		public EventHandler Onselectend { get; set; }
		public EventHandler Onsqueeze { get; set; }
		public EventHandler Onsqueezestart { get; set; }
		public EventHandler Onsqueezeend { get; set; }
		public EventHandler Onvisibilitychange { get; set; }
		public EventHandler Onframeratechange { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRRenderStateInit
{
		public Number DepthNear;
		public Number DepthFar;
		public Number InlineVerticalFieldOfView;
		public XRWebGLLayer? BaseLayer;
		public List<XRLayer>? Layers;
}

///<include file='Utils/Docs/XRRenderState/XRRenderState.generated.xml' path='docs/XRRenderState/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRRenderState
{
	///<include file='Utils/Docs/XRRenderStateDepthNear/XRRenderStateDepthNear.generated.xml' path='docs/XRRenderStateDepthNear/*'/>
	public Number DepthNear { get; }
	///<include file='Utils/Docs/XRRenderStateDepthFar/XRRenderStateDepthFar.generated.xml' path='docs/XRRenderStateDepthFar/*'/>
	public Number DepthFar { get; }
	///<include file='Utils/Docs/XRRenderStateInlineVerticalFieldOfView/XRRenderStateInlineVerticalFieldOfView.generated.xml' path='docs/XRRenderStateInlineVerticalFieldOfView/*'/>
	public Number? InlineVerticalFieldOfView { get; }
	///<include file='Utils/Docs/XRRenderStateBaseLayer/XRRenderStateBaseLayer.generated.xml' path='docs/XRRenderStateBaseLayer/*'/>
	public XRWebGLLayer? BaseLayer { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct XRFrameRequestCallback
{
}

///<include file='Utils/Docs/XRFrame/XRFrame.generated.xml' path='docs/XRFrame/*'/>
public partial class XRFrame
{
	///<include file='Utils/Docs/XRFrameSession/XRFrameSession.generated.xml' path='docs/XRFrameSession/*'/>
	public XRSession Session { get; }
		public Unsupported /*DOMHighResTimeStamp*/ PredictedDisplayTime { get; }
	///<include file='Utils/Docs/XRFrameGetViewerPose/XRFrameGetViewerPose.generated.xml' path='docs/XRFrameGetViewerPose/*'/>
	public XRViewerPose? GetViewerPose(XRReferenceSpace referenceSpace) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRFrameGetPose/XRFrameGetPose.generated.xml' path='docs/XRFrameGetPose/*'/>
	public XRPose? GetPose(XRSpace space, XRSpace baseSpace) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XRSpace/XRSpace.generated.xml' path='docs/XRSpace/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRSpace : EventTarget
{
}

public enum XRReferenceSpaceType
{
	Viewer,
	Local,
	LocalFloor,
	BoundedFloor,
	Unbounded,
}

///<include file='Utils/Docs/XRReferenceSpace/XRReferenceSpace.generated.xml' path='docs/XRReferenceSpace/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRReferenceSpace : XRSpace
{
	///<include file='Utils/Docs/XRReferenceSpaceGetOffsetReferenceSpace/XRReferenceSpaceGetOffsetReferenceSpace.generated.xml' path='docs/XRReferenceSpaceGetOffsetReferenceSpace/*'/>
	public XRReferenceSpace GetOffsetReferenceSpace(XRRigidTransform originOffset) { throw new System.NotImplementedException(); }
		public EventHandler Onreset { get; set; }
}

///<include file='Utils/Docs/XRBoundedReferenceSpace/XRBoundedReferenceSpace.generated.xml' path='docs/XRBoundedReferenceSpace/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRBoundedReferenceSpace : XRReferenceSpace
{
	///<include file='Utils/Docs/XRBoundedReferenceSpaceBoundsGeometry/XRBoundedReferenceSpaceBoundsGeometry.generated.xml' path='docs/XRBoundedReferenceSpaceBoundsGeometry/*'/>
	public DOMPointReadOnly[] BoundsGeometry { get; }
}

public enum XREye
{
	None,
	Left,
	Right,
}

///<include file='Utils/Docs/XRView/XRView.generated.xml' path='docs/XRView/*'/>
public partial class XRView
{
	///<include file='Utils/Docs/XRViewEye/XRViewEye.generated.xml' path='docs/XRViewEye/*'/>
	public XREye Eye { get; }
	///<include file='Utils/Docs/XRViewProjectionMatrix/XRViewProjectionMatrix.generated.xml' path='docs/XRViewProjectionMatrix/*'/>
	public System.Single ProjectionMatrix { get; }
	///<include file='Utils/Docs/XRViewTransform/XRViewTransform.generated.xml' path='docs/XRViewTransform/*'/>
	public XRRigidTransform Transform { get; }
	///<include file='Utils/Docs/XRViewRecommendedViewportScale/XRViewRecommendedViewportScale.generated.xml' path='docs/XRViewRecommendedViewportScale/*'/>
	public Number? RecommendedViewportScale { get; }
	///<include file='Utils/Docs/XRViewRequestViewportScale/XRViewRequestViewportScale.generated.xml' path='docs/XRViewRequestViewportScale/*'/>
	public Undefined RequestViewportScale(Number? scale) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XRViewport/XRViewport.generated.xml' path='docs/XRViewport/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRViewport
{
	///<include file='Utils/Docs/XRViewportX/XRViewportX.generated.xml' path='docs/XRViewportX/*'/>
	public long X { get; }
	///<include file='Utils/Docs/XRViewportY/XRViewportY.generated.xml' path='docs/XRViewportY/*'/>
	public long Y { get; }
	///<include file='Utils/Docs/XRViewportWidth/XRViewportWidth.generated.xml' path='docs/XRViewportWidth/*'/>
	public long Width { get; }
	///<include file='Utils/Docs/XRViewportHeight/XRViewportHeight.generated.xml' path='docs/XRViewportHeight/*'/>
	public long Height { get; }
}

///<include file='Utils/Docs/XRRigidTransform/XRRigidTransform.generated.xml' path='docs/XRRigidTransform/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRRigidTransform
{
	///<include file='Utils/Docs/XRRigidTransformXRRigidTransform/XRRigidTransformXRRigidTransform.generated.xml' path='docs/XRRigidTransformXRRigidTransform/*'/>
	public XRRigidTransform(DOMPointInit position, DOMPointInit orientation) { }
	///<include file='Utils/Docs/XRRigidTransformPosition/XRRigidTransformPosition.generated.xml' path='docs/XRRigidTransformPosition/*'/>
	public DOMPointReadOnly Position { get; }
	///<include file='Utils/Docs/XRRigidTransformOrientation/XRRigidTransformOrientation.generated.xml' path='docs/XRRigidTransformOrientation/*'/>
	public DOMPointReadOnly Orientation { get; }
	///<include file='Utils/Docs/XRRigidTransformMatrix/XRRigidTransformMatrix.generated.xml' path='docs/XRRigidTransformMatrix/*'/>
	public System.Single Matrix { get; }
	///<include file='Utils/Docs/XRRigidTransformInverse/XRRigidTransformInverse.generated.xml' path='docs/XRRigidTransformInverse/*'/>
	public XRRigidTransform Inverse { get; }
	public XRRigidTransform() { }
}

///<include file='Utils/Docs/XRPose/XRPose.generated.xml' path='docs/XRPose/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRPose
{
	///<include file='Utils/Docs/XRPoseTransform/XRPoseTransform.generated.xml' path='docs/XRPoseTransform/*'/>
	public XRRigidTransform Transform { get; }
	///<include file='Utils/Docs/XRPoseLinearVelocity/XRPoseLinearVelocity.generated.xml' path='docs/XRPoseLinearVelocity/*'/>
	public DOMPointReadOnly? LinearVelocity { get; }
	///<include file='Utils/Docs/XRPoseAngularVelocity/XRPoseAngularVelocity.generated.xml' path='docs/XRPoseAngularVelocity/*'/>
	public DOMPointReadOnly? AngularVelocity { get; }
	///<include file='Utils/Docs/XRPoseEmulatedPosition/XRPoseEmulatedPosition.generated.xml' path='docs/XRPoseEmulatedPosition/*'/>
	public bool EmulatedPosition { get; }
}

///<include file='Utils/Docs/XRViewerPose/XRViewerPose.generated.xml' path='docs/XRViewerPose/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRViewerPose : XRPose
{
	///<include file='Utils/Docs/XRViewerPoseViews/XRViewerPoseViews.generated.xml' path='docs/XRViewerPoseViews/*'/>
	public XRView[] Views { get; }
}

public enum XRHandedness
{
	None,
	Left,
	Right,
}

public enum XRTargetRayMode
{
	Gaze,
	TrackedPointer,
	Screen,
	TransientPointer,
}

///<include file='Utils/Docs/XRInputSource/XRInputSource.generated.xml' path='docs/XRInputSource/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRInputSource
{
	///<include file='Utils/Docs/XRInputSourceHandedness/XRInputSourceHandedness.generated.xml' path='docs/XRInputSourceHandedness/*'/>
	public XRHandedness Handedness { get; }
	///<include file='Utils/Docs/XRInputSourceTargetRayMode/XRInputSourceTargetRayMode.generated.xml' path='docs/XRInputSourceTargetRayMode/*'/>
	public XRTargetRayMode TargetRayMode { get; }
	///<include file='Utils/Docs/XRInputSourceTargetRaySpace/XRInputSourceTargetRaySpace.generated.xml' path='docs/XRInputSourceTargetRaySpace/*'/>
	public XRSpace TargetRaySpace { get; }
	///<include file='Utils/Docs/XRInputSourceGripSpace/XRInputSourceGripSpace.generated.xml' path='docs/XRInputSourceGripSpace/*'/>
	public XRSpace? GripSpace { get; }
	///<include file='Utils/Docs/XRInputSourceProfiles/XRInputSourceProfiles.generated.xml' path='docs/XRInputSourceProfiles/*'/>
	public string[] Profiles { get; }
}

///<include file='Utils/Docs/XRInputSourceArray/XRInputSourceArray.generated.xml' path='docs/XRInputSourceArray/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRInputSourceArray
{
	public XRInputSource this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	///<include file='Utils/Docs/XRInputSourceArrayLength/XRInputSourceArrayLength.generated.xml' path='docs/XRInputSourceArrayLength/*'/>
	public ulong Length { get; }
	
}

///<include file='Utils/Docs/XRLayer/XRLayer.generated.xml' path='docs/XRLayer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRLayer : EventTarget
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRWebGLLayerInit
{
		public bool Antialias;
		public bool Depth;
		public bool Stencil;
		public bool Alpha;
		public bool IgnoreDepthValues;
		public Number FramebufferScaleFactor;
}

///<include file='Utils/Docs/XRWebGLLayer/XRWebGLLayer.generated.xml' path='docs/XRWebGLLayer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRWebGLLayer : XRLayer
{
	///<include file='Utils/Docs/XRWebGLLayerXRWebGLLayer/XRWebGLLayerXRWebGLLayer.generated.xml' path='docs/XRWebGLLayerXRWebGLLayer/*'/>
	public XRWebGLLayer(XRSession session, XRWebGLRenderingContext context, XRWebGLLayerInit layerInit) { }
	///<include file='Utils/Docs/XRWebGLLayerAntialias/XRWebGLLayerAntialias.generated.xml' path='docs/XRWebGLLayerAntialias/*'/>
	public bool Antialias { get; }
	///<include file='Utils/Docs/XRWebGLLayerIgnoreDepthValues/XRWebGLLayerIgnoreDepthValues.generated.xml' path='docs/XRWebGLLayerIgnoreDepthValues/*'/>
	public bool IgnoreDepthValues { get; }
	///<include file='Utils/Docs/XRWebGLLayerFixedFoveation/XRWebGLLayerFixedFoveation.generated.xml' path='docs/XRWebGLLayerFixedFoveation/*'/>
	public Number? FixedFoveation { get; set; }
	///<include file='Utils/Docs/XRWebGLLayerFramebuffer/XRWebGLLayerFramebuffer.generated.xml' path='docs/XRWebGLLayerFramebuffer/*'/>
	public Unsupported /*WebGLFramebuffer*/? Framebuffer { get; }
	///<include file='Utils/Docs/XRWebGLLayerFramebufferWidth/XRWebGLLayerFramebufferWidth.generated.xml' path='docs/XRWebGLLayerFramebufferWidth/*'/>
	public ulong FramebufferWidth { get; }
	///<include file='Utils/Docs/XRWebGLLayerFramebufferHeight/XRWebGLLayerFramebufferHeight.generated.xml' path='docs/XRWebGLLayerFramebufferHeight/*'/>
	public ulong FramebufferHeight { get; }
	///<include file='Utils/Docs/XRWebGLLayerGetViewport/XRWebGLLayerGetViewport.generated.xml' path='docs/XRWebGLLayerGetViewport/*'/>
	public XRViewport? GetViewport(XRView view) { throw new System.NotImplementedException(); }
		public static Number GetNativeFramebufferScaleFactor(XRSession session) { throw new System.NotImplementedException(); }
	public XRWebGLLayer() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebGLContextAttributes
{
		public bool XrCompatible;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface WebGLRenderingContextBase
{
		public Task<Undefined> MakeXRCompatible() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XRSessionEvent/XRSessionEvent.generated.xml' path='docs/XRSessionEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRSessionEvent : Event
{
	///<include file='Utils/Docs/XRSessionEventXRSessionEvent/XRSessionEventXRSessionEvent.generated.xml' path='docs/XRSessionEventXRSessionEvent/*'/>
	public XRSessionEvent(string type, XRSessionEventInit eventInitDict) { }
	///<include file='Utils/Docs/XRSessionEventSession/XRSessionEventSession.generated.xml' path='docs/XRSessionEventSession/*'/>
	public XRSession Session { get; }
	public XRSessionEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRSessionEventInit : EventInit
{
		public required XRSession Session;
}

///<include file='Utils/Docs/XRInputSourceEvent/XRInputSourceEvent.generated.xml' path='docs/XRInputSourceEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRInputSourceEvent : Event
{
	///<include file='Utils/Docs/XRInputSourceEventXRInputSourceEvent/XRInputSourceEventXRInputSourceEvent.generated.xml' path='docs/XRInputSourceEventXRInputSourceEvent/*'/>
	public XRInputSourceEvent(string type, XRInputSourceEventInit eventInitDict) { }
	///<include file='Utils/Docs/XRInputSourceEventFrame/XRInputSourceEventFrame.generated.xml' path='docs/XRInputSourceEventFrame/*'/>
	public XRFrame Frame { get; }
	///<include file='Utils/Docs/XRInputSourceEventInputSource/XRInputSourceEventInputSource.generated.xml' path='docs/XRInputSourceEventInputSource/*'/>
	public XRInputSource InputSource { get; }
	public XRInputSourceEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRInputSourceEventInit : EventInit
{
		public required XRFrame Frame;
		public required XRInputSource InputSource;
}

///<include file='Utils/Docs/XRInputSourcesChangeEvent/XRInputSourcesChangeEvent.generated.xml' path='docs/XRInputSourcesChangeEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRInputSourcesChangeEvent : Event
{
	///<include file='Utils/Docs/XRInputSourcesChangeEventXRInputSourcesChangeEvent/XRInputSourcesChangeEventXRInputSourcesChangeEvent.generated.xml' path='docs/XRInputSourcesChangeEventXRInputSourcesChangeEvent/*'/>
	public XRInputSourcesChangeEvent(string type, XRInputSourcesChangeEventInit eventInitDict) { }
	///<include file='Utils/Docs/XRInputSourcesChangeEventSession/XRInputSourcesChangeEventSession.generated.xml' path='docs/XRInputSourcesChangeEventSession/*'/>
	public XRSession Session { get; }
	///<include file='Utils/Docs/XRInputSourcesChangeEventAdded/XRInputSourcesChangeEventAdded.generated.xml' path='docs/XRInputSourcesChangeEventAdded/*'/>
	public XRInputSource[] Added { get; }
	///<include file='Utils/Docs/XRInputSourcesChangeEventRemoved/XRInputSourcesChangeEventRemoved.generated.xml' path='docs/XRInputSourcesChangeEventRemoved/*'/>
	public XRInputSource[] Removed { get; }
	public XRInputSourcesChangeEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRInputSourcesChangeEventInit : EventInit
{
		public required XRSession Session;
		public required XRInputSource[] Added;
		public required XRInputSource[] Removed;
}

///<include file='Utils/Docs/XRReferenceSpaceEvent/XRReferenceSpaceEvent.generated.xml' path='docs/XRReferenceSpaceEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRReferenceSpaceEvent : Event
{
	///<include file='Utils/Docs/XRReferenceSpaceEventXRReferenceSpaceEvent/XRReferenceSpaceEventXRReferenceSpaceEvent.generated.xml' path='docs/XRReferenceSpaceEventXRReferenceSpaceEvent/*'/>
	public XRReferenceSpaceEvent(string type, XRReferenceSpaceEventInit eventInitDict) { }
	///<include file='Utils/Docs/XRReferenceSpaceEventReferenceSpace/XRReferenceSpaceEventReferenceSpace.generated.xml' path='docs/XRReferenceSpaceEventReferenceSpace/*'/>
	public XRReferenceSpace ReferenceSpace { get; }
	///<include file='Utils/Docs/XRReferenceSpaceEventTransform/XRReferenceSpaceEventTransform.generated.xml' path='docs/XRReferenceSpaceEventTransform/*'/>
	public XRRigidTransform? Transform { get; }
	public XRReferenceSpaceEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRReferenceSpaceEventInit : EventInit
{
		public required XRReferenceSpace ReferenceSpace;
		public XRRigidTransform? Transform;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRSessionSupportedPermissionDescriptor
{
		public XRSessionMode Mode;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRPermissionDescriptor
{
		public XRSessionMode Mode;
		public List<string> RequiredFeatures;
		public List<string> OptionalFeatures;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRPermissionStatus
{
		public string[] Granted { get; set; }
}

public partial interface GlobalEventHandlers
{
		public EventHandler Onbeforexrselect { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

public partial class XRSessionInit
{
		public XRDOMOverlayInit? DomOverlay;
}

///<include file='Utils/Docs/XRSession/XRSession.generated.xml' path='docs/XRSession/*'/>
public partial class XRSession
{
	///<include file='Utils/Docs/XRSessionDomOverlayState/XRSessionDomOverlayState.generated.xml' path='docs/XRSessionDomOverlayState/*'/>
	public XRDOMOverlayState? DomOverlayState { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRDOMOverlayInit
{
		public required Element Root;
}

public enum XRDOMOverlayType
{
	Screen,
	Floating,
	HeadLocked,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRDOMOverlayState
{
		public XRDOMOverlayType Type;
}

///<include file='Utils/Docs/XRInputSource/XRInputSource.generated.xml' path='docs/XRInputSource/*'/>
public partial class XRInputSource
{
	///<include file='Utils/Docs/XRInputSourceGamepad/XRInputSourceGamepad.generated.xml' path='docs/XRInputSourceGamepad/*'/>
	public Unsupported /*Gamepad*/? Gamepad { get; }
}

///<include file='Utils/Docs/XRInputSource/XRInputSource.generated.xml' path='docs/XRInputSource/*'/>
public partial class XRInputSource
{
	///<include file='Utils/Docs/XRInputSourceHand/XRInputSourceHand.generated.xml' path='docs/XRInputSourceHand/*'/>
	public XRHand? Hand { get; }
}

public enum XRHandJoint
{
	Wrist,
	ThumbMetacarpal,
	ThumbPhalanxProximal,
	ThumbPhalanxDistal,
	ThumbTip,
	IndexFingerMetacarpal,
	IndexFingerPhalanxProximal,
	IndexFingerPhalanxIntermediate,
	IndexFingerPhalanxDistal,
	IndexFingerTip,
	MiddleFingerMetacarpal,
	MiddleFingerPhalanxProximal,
	MiddleFingerPhalanxIntermediate,
	MiddleFingerPhalanxDistal,
	MiddleFingerTip,
	RingFingerMetacarpal,
	RingFingerPhalanxProximal,
	RingFingerPhalanxIntermediate,
	RingFingerPhalanxDistal,
	RingFingerTip,
	PinkyFingerMetacarpal,
	PinkyFingerPhalanxProximal,
	PinkyFingerPhalanxIntermediate,
	PinkyFingerPhalanxDistal,
	PinkyFingerTip,
}

///<include file='Utils/Docs/XRHand/XRHand.generated.xml' path='docs/XRHand/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRHand
{
	public XRHandJoint this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
		public ulong Size { get; }
		public XRJointSpace Get(XRHandJoint key) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XRJointSpace/XRJointSpace.generated.xml' path='docs/XRJointSpace/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRJointSpace : XRSpace
{
	///<include file='Utils/Docs/XRJointSpaceJointName/XRJointSpaceJointName.generated.xml' path='docs/XRJointSpaceJointName/*'/>
	public XRHandJoint JointName { get; }
}

///<include file='Utils/Docs/XRFrame/XRFrame.generated.xml' path='docs/XRFrame/*'/>
public partial class XRFrame
{
	///<include file='Utils/Docs/XRFrameGetJointPose/XRFrameGetJointPose.generated.xml' path='docs/XRFrameGetJointPose/*'/>
	public XRJointPose? GetJointPose(XRJointSpace joint, XRSpace baseSpace) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRFrameFillJointRadii/XRFrameFillJointRadii.generated.xml' path='docs/XRFrameFillJointRadii/*'/>
	public bool FillJointRadii(List<XRJointSpace> jointSpaces, System.Single radii) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRFrameFillPoses/XRFrameFillPoses.generated.xml' path='docs/XRFrameFillPoses/*'/>
	public bool FillPoses(List<XRSpace> spaces, XRSpace baseSpace, System.Single transforms) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XRJointPose/XRJointPose.generated.xml' path='docs/XRJointPose/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRJointPose : XRPose
{
	///<include file='Utils/Docs/XRJointPoseRadius/XRJointPoseRadius.generated.xml' path='docs/XRJointPoseRadius/*'/>
	public Number Radius { get; }
}

public enum XRHitTestTrackableType
{
	Point,
	Plane,
	Mesh,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRHitTestOptionsInit
{
		public required XRSpace Space;
		public XRHitTestTrackableType[] EntityTypes;
		public XRRay OffsetRay;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRTransientInputHitTestOptionsInit
{
		public required string Profile;
		public XRHitTestTrackableType[] EntityTypes;
		public XRRay OffsetRay;
}

///<include file='Utils/Docs/XRHitTestSource/XRHitTestSource.generated.xml' path='docs/XRHitTestSource/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRHitTestSource
{
	///<include file='Utils/Docs/XRHitTestSourceCancel/XRHitTestSourceCancel.generated.xml' path='docs/XRHitTestSourceCancel/*'/>
	public Undefined Cancel() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XRTransientInputHitTestSource/XRTransientInputHitTestSource.generated.xml' path='docs/XRTransientInputHitTestSource/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRTransientInputHitTestSource
{
	///<include file='Utils/Docs/XRTransientInputHitTestSourceCancel/XRTransientInputHitTestSourceCancel.generated.xml' path='docs/XRTransientInputHitTestSourceCancel/*'/>
	public Undefined Cancel() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XRHitTestResult/XRHitTestResult.generated.xml' path='docs/XRHitTestResult/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRHitTestResult
{
	///<include file='Utils/Docs/XRHitTestResultGetPose/XRHitTestResultGetPose.generated.xml' path='docs/XRHitTestResultGetPose/*'/>
	public XRPose? GetPose(XRSpace baseSpace) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XRTransientInputHitTestResult/XRTransientInputHitTestResult.generated.xml' path='docs/XRTransientInputHitTestResult/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRTransientInputHitTestResult
{
	///<include file='Utils/Docs/XRTransientInputHitTestResultInputSource/XRTransientInputHitTestResultInputSource.generated.xml' path='docs/XRTransientInputHitTestResultInputSource/*'/>
	public XRInputSource InputSource { get; }
	///<include file='Utils/Docs/XRTransientInputHitTestResultResults/XRTransientInputHitTestResultResults.generated.xml' path='docs/XRTransientInputHitTestResultResults/*'/>
	public XRHitTestResult[] Results { get; }
}

///<include file='Utils/Docs/XRSession/XRSession.generated.xml' path='docs/XRSession/*'/>
public partial class XRSession
{
	///<include file='Utils/Docs/XRSessionRequestHitTestSource/XRSessionRequestHitTestSource.generated.xml' path='docs/XRSessionRequestHitTestSource/*'/>
	public Task<XRHitTestSource> RequestHitTestSource(XRHitTestOptionsInit options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRSessionRequestHitTestSourceForTransientInput/XRSessionRequestHitTestSourceForTransientInput.generated.xml' path='docs/XRSessionRequestHitTestSourceForTransientInput/*'/>
	public Task<XRTransientInputHitTestSource> RequestHitTestSourceForTransientInput(XRTransientInputHitTestOptionsInit options) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XRFrame/XRFrame.generated.xml' path='docs/XRFrame/*'/>
public partial class XRFrame
{
	///<include file='Utils/Docs/XRFrameGetHitTestResults/XRFrameGetHitTestResults.generated.xml' path='docs/XRFrameGetHitTestResults/*'/>
	public XRHitTestResult[] GetHitTestResults(XRHitTestSource hitTestSource) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRFrameGetHitTestResultsForTransientInput/XRFrameGetHitTestResultsForTransientInput.generated.xml' path='docs/XRFrameGetHitTestResultsForTransientInput/*'/>
	public XRTransientInputHitTestResult[] GetHitTestResultsForTransientInput(XRTransientInputHitTestSource hitTestSource) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRRayDirectionInit
{
		public Number X;
		public Number Y;
		public Number Z;
		public Number W;
}

///<include file='Utils/Docs/XRRay/XRRay.generated.xml' path='docs/XRRay/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRRay
{
	///<include file='Utils/Docs/XRRayXRRay/XRRayXRRay.generated.xml' path='docs/XRRayXRRay/*'/>
	public XRRay(DOMPointInit origin, XRRayDirectionInit direction) { }
	///<include file='Utils/Docs/XRRayXRRay/XRRayXRRay.generated.xml' path='docs/XRRayXRRay/*'/>
	public XRRay(XRRigidTransform transform) { }
	///<include file='Utils/Docs/XRRayOrigin/XRRayOrigin.generated.xml' path='docs/XRRayOrigin/*'/>
	public DOMPointReadOnly Origin { get; }
	///<include file='Utils/Docs/XRRayDirection/XRRayDirection.generated.xml' path='docs/XRRayDirection/*'/>
	public DOMPointReadOnly Direction { get; }
	///<include file='Utils/Docs/XRRayMatrix/XRRayMatrix.generated.xml' path='docs/XRRayMatrix/*'/>
	public System.Single Matrix { get; }
	public XRRay() { }
}

public enum XRLayerLayout
{
	Default,
	Mono,
	Stereo,
	StereoLeftRight,
	StereoTopBottom,
}

public enum XRLayerQuality
{
	Default,
	TextOptimized,
	GraphicsOptimized,
}

///<include file='Utils/Docs/XRCompositionLayer/XRCompositionLayer.generated.xml' path='docs/XRCompositionLayer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRCompositionLayer : XRLayer
{
	///<include file='Utils/Docs/XRCompositionLayerLayout/XRCompositionLayerLayout.generated.xml' path='docs/XRCompositionLayerLayout/*'/>
	public XRLayerLayout Layout { get; }
	///<include file='Utils/Docs/XRCompositionLayerBlendTextureSourceAlpha/XRCompositionLayerBlendTextureSourceAlpha.generated.xml' path='docs/XRCompositionLayerBlendTextureSourceAlpha/*'/>
	public bool BlendTextureSourceAlpha { get; set; }
		public bool ForceMonoPresentation { get; set; }
		public Number Opacity { get; set; }
	///<include file='Utils/Docs/XRCompositionLayerMipLevels/XRCompositionLayerMipLevels.generated.xml' path='docs/XRCompositionLayerMipLevels/*'/>
	public ulong MipLevels { get; }
		public XRLayerQuality Quality { get; set; }
	///<include file='Utils/Docs/XRCompositionLayerNeedsRedraw/XRCompositionLayerNeedsRedraw.generated.xml' path='docs/XRCompositionLayerNeedsRedraw/*'/>
	public bool NeedsRedraw { get; }
	///<include file='Utils/Docs/XRCompositionLayerDestroy/XRCompositionLayerDestroy.generated.xml' path='docs/XRCompositionLayerDestroy/*'/>
	public Undefined Destroy() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XRProjectionLayer/XRProjectionLayer.generated.xml' path='docs/XRProjectionLayer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRProjectionLayer : XRCompositionLayer
{
	///<include file='Utils/Docs/XRProjectionLayerTextureWidth/XRProjectionLayerTextureWidth.generated.xml' path='docs/XRProjectionLayerTextureWidth/*'/>
	public ulong TextureWidth { get; }
	///<include file='Utils/Docs/XRProjectionLayerTextureHeight/XRProjectionLayerTextureHeight.generated.xml' path='docs/XRProjectionLayerTextureHeight/*'/>
	public ulong TextureHeight { get; }
	///<include file='Utils/Docs/XRProjectionLayerTextureArrayLength/XRProjectionLayerTextureArrayLength.generated.xml' path='docs/XRProjectionLayerTextureArrayLength/*'/>
	public ulong TextureArrayLength { get; }
	///<include file='Utils/Docs/XRProjectionLayerIgnoreDepthValues/XRProjectionLayerIgnoreDepthValues.generated.xml' path='docs/XRProjectionLayerIgnoreDepthValues/*'/>
	public bool IgnoreDepthValues { get; }
	///<include file='Utils/Docs/XRProjectionLayerFixedFoveation/XRProjectionLayerFixedFoveation.generated.xml' path='docs/XRProjectionLayerFixedFoveation/*'/>
	public Number? FixedFoveation { get; set; }
		public XRRigidTransform? DeltaPose { get; set; }
}

///<include file='Utils/Docs/XRQuadLayer/XRQuadLayer.generated.xml' path='docs/XRQuadLayer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRQuadLayer : XRCompositionLayer
{
	///<include file='Utils/Docs/XRQuadLayerSpace/XRQuadLayerSpace.generated.xml' path='docs/XRQuadLayerSpace/*'/>
	public XRSpace Space { get; set; }
	///<include file='Utils/Docs/XRQuadLayerTransform/XRQuadLayerTransform.generated.xml' path='docs/XRQuadLayerTransform/*'/>
	public XRRigidTransform Transform { get; set; }
	///<include file='Utils/Docs/XRQuadLayerWidth/XRQuadLayerWidth.generated.xml' path='docs/XRQuadLayerWidth/*'/>
	public Number Width { get; set; }
	///<include file='Utils/Docs/XRQuadLayerHeight/XRQuadLayerHeight.generated.xml' path='docs/XRQuadLayerHeight/*'/>
	public Number Height { get; set; }
		public EventHandler Onredraw { get; set; }
}

///<include file='Utils/Docs/XRCylinderLayer/XRCylinderLayer.generated.xml' path='docs/XRCylinderLayer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRCylinderLayer : XRCompositionLayer
{
	///<include file='Utils/Docs/XRCylinderLayerSpace/XRCylinderLayerSpace.generated.xml' path='docs/XRCylinderLayerSpace/*'/>
	public XRSpace Space { get; set; }
	///<include file='Utils/Docs/XRCylinderLayerTransform/XRCylinderLayerTransform.generated.xml' path='docs/XRCylinderLayerTransform/*'/>
	public XRRigidTransform Transform { get; set; }
	///<include file='Utils/Docs/XRCylinderLayerRadius/XRCylinderLayerRadius.generated.xml' path='docs/XRCylinderLayerRadius/*'/>
	public Number Radius { get; set; }
	///<include file='Utils/Docs/XRCylinderLayerCentralAngle/XRCylinderLayerCentralAngle.generated.xml' path='docs/XRCylinderLayerCentralAngle/*'/>
	public Number CentralAngle { get; set; }
	///<include file='Utils/Docs/XRCylinderLayerAspectRatio/XRCylinderLayerAspectRatio.generated.xml' path='docs/XRCylinderLayerAspectRatio/*'/>
	public Number AspectRatio { get; set; }
		public EventHandler Onredraw { get; set; }
}

///<include file='Utils/Docs/XREquirectLayer/XREquirectLayer.generated.xml' path='docs/XREquirectLayer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XREquirectLayer : XRCompositionLayer
{
	///<include file='Utils/Docs/XREquirectLayerSpace/XREquirectLayerSpace.generated.xml' path='docs/XREquirectLayerSpace/*'/>
	public XRSpace Space { get; set; }
	///<include file='Utils/Docs/XREquirectLayerTransform/XREquirectLayerTransform.generated.xml' path='docs/XREquirectLayerTransform/*'/>
	public XRRigidTransform Transform { get; set; }
	///<include file='Utils/Docs/XREquirectLayerRadius/XREquirectLayerRadius.generated.xml' path='docs/XREquirectLayerRadius/*'/>
	public Number Radius { get; set; }
	///<include file='Utils/Docs/XREquirectLayerCentralHorizontalAngle/XREquirectLayerCentralHorizontalAngle.generated.xml' path='docs/XREquirectLayerCentralHorizontalAngle/*'/>
	public Number CentralHorizontalAngle { get; set; }
	///<include file='Utils/Docs/XREquirectLayerUpperVerticalAngle/XREquirectLayerUpperVerticalAngle.generated.xml' path='docs/XREquirectLayerUpperVerticalAngle/*'/>
	public Number UpperVerticalAngle { get; set; }
	///<include file='Utils/Docs/XREquirectLayerLowerVerticalAngle/XREquirectLayerLowerVerticalAngle.generated.xml' path='docs/XREquirectLayerLowerVerticalAngle/*'/>
	public Number LowerVerticalAngle { get; set; }
		public EventHandler Onredraw { get; set; }
}

///<include file='Utils/Docs/XRCubeLayer/XRCubeLayer.generated.xml' path='docs/XRCubeLayer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRCubeLayer : XRCompositionLayer
{
	///<include file='Utils/Docs/XRCubeLayerSpace/XRCubeLayerSpace.generated.xml' path='docs/XRCubeLayerSpace/*'/>
	public XRSpace Space { get; set; }
	///<include file='Utils/Docs/XRCubeLayerOrientation/XRCubeLayerOrientation.generated.xml' path='docs/XRCubeLayerOrientation/*'/>
	public DOMPointReadOnly Orientation { get; set; }
		public EventHandler Onredraw { get; set; }
}

///<include file='Utils/Docs/XRSubImage/XRSubImage.generated.xml' path='docs/XRSubImage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRSubImage
{
	///<include file='Utils/Docs/XRSubImageViewport/XRSubImageViewport.generated.xml' path='docs/XRSubImageViewport/*'/>
	public XRViewport Viewport { get; }
}

///<include file='Utils/Docs/XRWebGLSubImage/XRWebGLSubImage.generated.xml' path='docs/XRWebGLSubImage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRWebGLSubImage : XRSubImage
{
	///<include file='Utils/Docs/XRWebGLSubImageColorTexture/XRWebGLSubImageColorTexture.generated.xml' path='docs/XRWebGLSubImageColorTexture/*'/>
	public Unsupported /*WebGLTexture*/ ColorTexture { get; }
	///<include file='Utils/Docs/XRWebGLSubImageDepthStencilTexture/XRWebGLSubImageDepthStencilTexture.generated.xml' path='docs/XRWebGLSubImageDepthStencilTexture/*'/>
	public Unsupported /*WebGLTexture*/? DepthStencilTexture { get; }
		public Unsupported /*WebGLTexture*/? MotionVectorTexture { get; }
	///<include file='Utils/Docs/XRWebGLSubImageImageIndex/XRWebGLSubImageImageIndex.generated.xml' path='docs/XRWebGLSubImageImageIndex/*'/>
	public ulong? ImageIndex { get; }
	///<include file='Utils/Docs/XRWebGLSubImageColorTextureWidth/XRWebGLSubImageColorTextureWidth.generated.xml' path='docs/XRWebGLSubImageColorTextureWidth/*'/>
	public ulong ColorTextureWidth { get; }
	///<include file='Utils/Docs/XRWebGLSubImageColorTextureHeight/XRWebGLSubImageColorTextureHeight.generated.xml' path='docs/XRWebGLSubImageColorTextureHeight/*'/>
	public ulong ColorTextureHeight { get; }
		public ulong? DepthStencilTextureWidth { get; }
		public ulong? DepthStencilTextureHeight { get; }
		public ulong? MotionVectorTextureWidth { get; }
		public ulong? MotionVectorTextureHeight { get; }
}

public enum XRTextureType
{
	Texture,
	TextureArray,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRProjectionLayerInit
{
		public XRTextureType TextureType;
		public Unsupported /*GLenum*/ ColorFormat;
		public Unsupported /*GLenum*/ DepthFormat;
		public Number ScaleFactor;
		public bool ClearOnAccess;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRLayerInit
{
		public required XRSpace Space;
		public Unsupported /*GLenum*/ ColorFormat;
		public Unsupported /*GLenum*/? DepthFormat;
		public ulong MipLevels;
		public required ulong ViewPixelWidth;
		public required ulong ViewPixelHeight;
		public XRLayerLayout Layout;
		public bool IsStatic;
		public bool ClearOnAccess;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRQuadLayerInit : XRLayerInit
{
		public XRTextureType TextureType;
		public XRRigidTransform? Transform;
		public Number Width;
		public Number Height;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRCylinderLayerInit : XRLayerInit
{
		public XRTextureType TextureType;
		public XRRigidTransform? Transform;
		public Number Radius;
		public Number CentralAngle;
		public Number AspectRatio;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XREquirectLayerInit : XRLayerInit
{
		public XRTextureType TextureType;
		public XRRigidTransform? Transform;
		public Number Radius;
		public Number CentralHorizontalAngle;
		public Number UpperVerticalAngle;
		public Number LowerVerticalAngle;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRCubeLayerInit : XRLayerInit
{
		public DOMPointReadOnly? Orientation;
}

///<include file='Utils/Docs/XRWebGLBinding/XRWebGLBinding.generated.xml' path='docs/XRWebGLBinding/*'/>
public partial class XRWebGLBinding
{
	///<include file='Utils/Docs/XRWebGLBindingXRWebGLBinding/XRWebGLBindingXRWebGLBinding.generated.xml' path='docs/XRWebGLBindingXRWebGLBinding/*'/>
	public XRWebGLBinding(XRSession session, XRWebGLRenderingContext context) { }
	///<include file='Utils/Docs/XRWebGLBindingNativeProjectionScaleFactor/XRWebGLBindingNativeProjectionScaleFactor.generated.xml' path='docs/XRWebGLBindingNativeProjectionScaleFactor/*'/>
	public Number NativeProjectionScaleFactor { get; }
		public bool UsesDepthValues { get; }
	///<include file='Utils/Docs/XRWebGLBindingCreateProjectionLayer/XRWebGLBindingCreateProjectionLayer.generated.xml' path='docs/XRWebGLBindingCreateProjectionLayer/*'/>
	public XRProjectionLayer CreateProjectionLayer(XRProjectionLayerInit init) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRWebGLBindingCreateQuadLayer/XRWebGLBindingCreateQuadLayer.generated.xml' path='docs/XRWebGLBindingCreateQuadLayer/*'/>
	public XRQuadLayer CreateQuadLayer(XRQuadLayerInit init) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRWebGLBindingCreateCylinderLayer/XRWebGLBindingCreateCylinderLayer.generated.xml' path='docs/XRWebGLBindingCreateCylinderLayer/*'/>
	public XRCylinderLayer CreateCylinderLayer(XRCylinderLayerInit init) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRWebGLBindingCreateEquirectLayer/XRWebGLBindingCreateEquirectLayer.generated.xml' path='docs/XRWebGLBindingCreateEquirectLayer/*'/>
	public XREquirectLayer CreateEquirectLayer(XREquirectLayerInit init) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRWebGLBindingCreateCubeLayer/XRWebGLBindingCreateCubeLayer.generated.xml' path='docs/XRWebGLBindingCreateCubeLayer/*'/>
	public XRCubeLayer CreateCubeLayer(XRCubeLayerInit init) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRWebGLBindingGetSubImage/XRWebGLBindingGetSubImage.generated.xml' path='docs/XRWebGLBindingGetSubImage/*'/>
	public XRWebGLSubImage GetSubImage(XRCompositionLayer layer, XRFrame frame, XREye eye) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRWebGLBindingGetViewSubImage/XRWebGLBindingGetViewSubImage.generated.xml' path='docs/XRWebGLBindingGetViewSubImage/*'/>
	public XRWebGLSubImage GetViewSubImage(XRProjectionLayer layer, XRView view) { throw new System.NotImplementedException(); }
	public XRWebGLBinding() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRMediaLayerInit
{
		public required XRSpace Space;
		public XRLayerLayout Layout;
		public bool InvertStereo;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRMediaQuadLayerInit : XRMediaLayerInit
{
		public XRRigidTransform? Transform;
		public Number? Width;
		public Number? Height;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRMediaCylinderLayerInit : XRMediaLayerInit
{
		public XRRigidTransform? Transform;
		public Number Radius;
		public Number CentralAngle;
		public Number? AspectRatio;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRMediaEquirectLayerInit : XRMediaLayerInit
{
		public XRRigidTransform? Transform;
		public Number Radius;
		public Number CentralHorizontalAngle;
		public Number UpperVerticalAngle;
		public Number LowerVerticalAngle;
}

///<include file='Utils/Docs/XRMediaBinding/XRMediaBinding.generated.xml' path='docs/XRMediaBinding/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRMediaBinding
{
	///<include file='Utils/Docs/XRMediaBindingXRMediaBinding/XRMediaBindingXRMediaBinding.generated.xml' path='docs/XRMediaBindingXRMediaBinding/*'/>
	public XRMediaBinding(XRSession session) { }
	///<include file='Utils/Docs/XRMediaBindingCreateQuadLayer/XRMediaBindingCreateQuadLayer.generated.xml' path='docs/XRMediaBindingCreateQuadLayer/*'/>
	public XRQuadLayer CreateQuadLayer(HTMLVideoElement video, XRMediaQuadLayerInit init) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRMediaBindingCreateCylinderLayer/XRMediaBindingCreateCylinderLayer.generated.xml' path='docs/XRMediaBindingCreateCylinderLayer/*'/>
	public XRCylinderLayer CreateCylinderLayer(HTMLVideoElement video, XRMediaCylinderLayerInit init) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRMediaBindingCreateEquirectLayer/XRMediaBindingCreateEquirectLayer.generated.xml' path='docs/XRMediaBindingCreateEquirectLayer/*'/>
	public XREquirectLayer CreateEquirectLayer(HTMLVideoElement video, XRMediaEquirectLayerInit init) { throw new System.NotImplementedException(); }
	public XRMediaBinding() { }
}

///<include file='Utils/Docs/XRLayerEvent/XRLayerEvent.generated.xml' path='docs/XRLayerEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRLayerEvent : Event
{
	///<include file='Utils/Docs/XRLayerEventXRLayerEvent/XRLayerEventXRLayerEvent.generated.xml' path='docs/XRLayerEventXRLayerEvent/*'/>
	public XRLayerEvent(string type, XRLayerEventInit eventInitDict) { }
	///<include file='Utils/Docs/XRLayerEventLayer/XRLayerEventLayer.generated.xml' path='docs/XRLayerEventLayer/*'/>
	public XRLayer Layer { get; }
	public XRLayerEvent() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRLayerEventInit : EventInit
{
		public required XRLayer Layer;
}

///<include file='Utils/Docs/XRRenderState/XRRenderState.generated.xml' path='docs/XRRenderState/*'/>
public partial class XRRenderState
{
	///<include file='Utils/Docs/XRRenderStateLayers/XRRenderStateLayers.generated.xml' path='docs/XRRenderStateLayers/*'/>
	public XRLayer[] Layers { get; }
}

///<include file='Utils/Docs/XRLightProbe/XRLightProbe.generated.xml' path='docs/XRLightProbe/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRLightProbe : EventTarget
{
	///<include file='Utils/Docs/XRLightProbeProbeSpace/XRLightProbeProbeSpace.generated.xml' path='docs/XRLightProbeProbeSpace/*'/>
	public XRSpace ProbeSpace { get; }
		public EventHandler Onreflectionchange { get; set; }
}

public enum XRReflectionFormat
{
	Srgba8,
	Rgba16f,
}

///<include file='Utils/Docs/XRLightEstimate/XRLightEstimate.generated.xml' path='docs/XRLightEstimate/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRLightEstimate
{
	///<include file='Utils/Docs/XRLightEstimateSphericalHarmonicsCoefficients/XRLightEstimateSphericalHarmonicsCoefficients.generated.xml' path='docs/XRLightEstimateSphericalHarmonicsCoefficients/*'/>
	public System.Single SphericalHarmonicsCoefficients { get; }
	///<include file='Utils/Docs/XRLightEstimatePrimaryLightDirection/XRLightEstimatePrimaryLightDirection.generated.xml' path='docs/XRLightEstimatePrimaryLightDirection/*'/>
	public DOMPointReadOnly PrimaryLightDirection { get; }
	///<include file='Utils/Docs/XRLightEstimatePrimaryLightIntensity/XRLightEstimatePrimaryLightIntensity.generated.xml' path='docs/XRLightEstimatePrimaryLightIntensity/*'/>
	public DOMPointReadOnly PrimaryLightIntensity { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRLightProbeInit
{
		public XRReflectionFormat ReflectionFormat;
}

///<include file='Utils/Docs/XRSession/XRSession.generated.xml' path='docs/XRSession/*'/>
public partial class XRSession
{
	///<include file='Utils/Docs/XRSessionRequestLightProbe/XRSessionRequestLightProbe.generated.xml' path='docs/XRSessionRequestLightProbe/*'/>
	public Task<XRLightProbe> RequestLightProbe(XRLightProbeInit options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XRSessionPreferredReflectionFormat/XRSessionPreferredReflectionFormat.generated.xml' path='docs/XRSessionPreferredReflectionFormat/*'/>
	public XRReflectionFormat PreferredReflectionFormat { get; }
}

///<include file='Utils/Docs/XRFrame/XRFrame.generated.xml' path='docs/XRFrame/*'/>
public partial class XRFrame
{
	///<include file='Utils/Docs/XRFrameGetLightEstimate/XRFrameGetLightEstimate.generated.xml' path='docs/XRFrameGetLightEstimate/*'/>
	public XRLightEstimate? GetLightEstimate(XRLightProbe lightProbe) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XRWebGLBinding/XRWebGLBinding.generated.xml' path='docs/XRWebGLBinding/*'/>
public partial class XRWebGLBinding
{
	///<include file='Utils/Docs/XRWebGLBindingGetReflectionCubeMap/XRWebGLBindingGetReflectionCubeMap.generated.xml' path='docs/XRWebGLBindingGetReflectionCubeMap/*'/>
	public Unsupported /*WebGLTexture*/? GetReflectionCubeMap(XRLightProbe lightProbe) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Screen/Screen.generated.xml' path='docs/Screen/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Screen
{
		public bool IsExtended { get; }
		public EventHandler Onchange { get; set; }
}

///<include file='Utils/Docs/Window/Window.generated.xml' path='docs/Window/*'/>
public partial class Window
{
		[To(ToAttribute.FirstCharToLowerCase)]
	public Task<ScreenDetails> GetScreenDetails() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ScreenDetails : EventTarget
{
		public ScreenDetailed[] Screens { get; }
		public ScreenDetailed CurrentScreen { get; }
		public EventHandler Onscreenschange { get; set; }
		public EventHandler Oncurrentscreenchange { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ScreenDetailed : Screen
{
		public long AvailLeft { get; }
		public long AvailTop { get; }
		public long Left { get; }
		public long Top { get; }
		public bool IsPrimary { get; }
		public bool IsInternal { get; }
		public Number DevicePixelRatio { get; }
		public string Label { get; }
}

public partial class FullscreenOptions
{
		public ScreenDetailed Screen;
}

///<summary>
///<see cref="HTMLCollection"/> or <see cref="Element"/>
///</summary>
public struct Union0
{
	public dynamic Value { get; set; }
	public static implicit operator Union0(HTMLCollection value){return new Union0 { Value = value };}
	public static implicit operator Union0(Element value){return new Union0 { Value = value };}
}

///<summary>
///<see cref="HTMLCollection"/> or <see cref="Element"/>
///</summary>
public struct Union1
{
	public dynamic Value { get; set; }
	public static implicit operator Union1(HTMLCollection value){return new Union1 { Value = value };}
	public static implicit operator Union1(Element value){return new Union1 { Value = value };}
}

///<summary>
///<see cref="RadioNodeList"/> or <see cref="Element"/>
///</summary>
public struct Union2
{
	public dynamic Value { get; set; }
	public static implicit operator Union2(RadioNodeList value){return new Union2 { Value = value };}
	public static implicit operator Union2(Element value){return new Union2 { Value = value };}
}

///<summary>
///<see cref="HTMLOptionElement"/> or <see cref="HTMLOptGroupElement"/>
///</summary>
public struct Union3
{
	public dynamic Value { get; set; }
	public static implicit operator Union3(HTMLOptionElement value){return new Union3 { Value = value };}
	public static implicit operator Union3(HTMLOptGroupElement value){return new Union3 { Value = value };}
}

///<summary>
///<see cref="HTMLElement"/> or <see cref="long"/>
///</summary>
public struct Union4
{
	public dynamic Value { get; set; }
	public static implicit operator Union4(HTMLElement value){return new Union4 { Value = value };}
	public static implicit operator Union4(long value){return new Union4 { Value = value };}
}

///<summary>
///<see cref="HTMLScriptElement"/> or <see cref="Unsupported /*SVGScriptElement*/"/>
///</summary>
public struct Union5
{
	public dynamic Value { get; set; }
	public static implicit operator Union5(HTMLScriptElement value){return new Union5 { Value = value };}
	public static implicit operator Union5(Unsupported /*SVGScriptElement*/ value){return new Union5 { Value = value };}
}

///<summary>
///<see cref="bool"/> or <see cref="double"/> or <see cref="string"/>
///</summary>
public struct Union6
{
	public dynamic Value { get; set; }
	public static implicit operator Union6(bool value){return new Union6 { Value = value };}
	public static implicit operator Union6(double value){return new Union6 { Value = value };}
	public static implicit operator Union6(string value){return new Union6 { Value = value };}
}

///<summary>
///<see cref="Unsupported /*MediaStream*/"/> or <see cref="Unsupported /*MediaSource*/"/> or <see cref="Blob"/>
///</summary>
public struct Union7
{
	public dynamic Value { get; set; }
	public static implicit operator Union7(Unsupported /*MediaStream*/ value){return new Union7 { Value = value };}
	public static implicit operator Union7(Blob value){return new Union7 { Value = value };}
}

///<summary>
///<see cref="VideoTrack"/> or <see cref="AudioTrack"/> or <see cref="TextTrack"/>
///</summary>
public struct Union8
{
	public dynamic Value { get; set; }
	public static implicit operator Union8(VideoTrack value){return new Union8 { Value = value };}
	public static implicit operator Union8(AudioTrack value){return new Union8 { Value = value };}
	public static implicit operator Union8(TextTrack value){return new Union8 { Value = value };}
}

///<summary>
///<see cref="VideoTrack"/> or <see cref="AudioTrack"/> or <see cref="TextTrack"/>
///</summary>
public struct Union9
{
	public dynamic Value { get; set; }
	public static implicit operator Union9(VideoTrack value){return new Union9 { Value = value };}
	public static implicit operator Union9(AudioTrack value){return new Union9 { Value = value };}
	public static implicit operator Union9(TextTrack value){return new Union9 { Value = value };}
}

///<summary>
///<see cref="RadioNodeList"/> or <see cref="Element"/>
///</summary>
public struct Union10
{
	public dynamic Value { get; set; }
	public static implicit operator Union10(RadioNodeList value){return new Union10 { Value = value };}
	public static implicit operator Union10(Element value){return new Union10 { Value = value };}
}

///<summary>
///<see cref="HTMLOptionElement"/> or <see cref="HTMLOptGroupElement"/>
///</summary>
public struct Union11
{
	public dynamic Value { get; set; }
	public static implicit operator Union11(HTMLOptionElement value){return new Union11 { Value = value };}
	public static implicit operator Union11(HTMLOptGroupElement value){return new Union11 { Value = value };}
}

///<summary>
///<see cref="HTMLElement"/> or <see cref="long"/>
///</summary>
public struct Union12
{
	public dynamic Value { get; set; }
	public static implicit operator Union12(HTMLElement value){return new Union12 { Value = value };}
	public static implicit operator Union12(long value){return new Union12 { Value = value };}
}

///<summary>
///<see cref="Element"/> or <see cref="Text"/>
///</summary>
public struct Union13
{
	public dynamic Value { get; set; }
	public static implicit operator Union13(Element value){return new Union13 { Value = value };}
	public static implicit operator Union13(Text value){return new Union13 { Value = value };}
}

///<summary>
///<see cref="CanvasRenderingContext2D"/> or <see cref="ImageBitmapRenderingContext"/> or <see cref="Unsupported /*WebGLRenderingContext*/"/> or <see cref="Unsupported /*WebGL2RenderingContext*/"/> or <see cref="GPUCanvasContext"/>
///</summary>
public struct Union14
{
	public dynamic Value { get; set; }
	public static implicit operator Union14(CanvasRenderingContext2D value){return new Union14 { Value = value };}
	public static implicit operator Union14(ImageBitmapRenderingContext value){return new Union14 { Value = value };}
	public static implicit operator Union14(Unsupported /*WebGLRenderingContext*/ value){return new Union14 { Value = value };}
	public static implicit operator Union14(GPUCanvasContext value){return new Union14 { Value = value };}
}

///<summary>
///<see cref="HTMLImageElement"/> or <see cref="Unsupported /*SVGImageElement*/"/>
///</summary>
public struct Union15
{
	public dynamic Value { get; set; }
	public static implicit operator Union15(HTMLImageElement value){return new Union15 { Value = value };}
	public static implicit operator Union15(Unsupported /*SVGImageElement*/ value){return new Union15 { Value = value };}
}

///<summary>
///<see cref="HTMLOrSVGImageElement"/> or <see cref="HTMLVideoElement"/> or <see cref="HTMLCanvasElement"/> or <see cref="ImageBitmap"/> or <see cref="OffscreenCanvas"/> or <see cref="VideoFrame"/>
///</summary>
public struct Union16
{
	public dynamic Value { get; set; }
	public static implicit operator Union16(HTMLOrSVGImageElement value){return new Union16 { Value = value };}
	public static implicit operator Union16(HTMLVideoElement value){return new Union16 { Value = value };}
	public static implicit operator Union16(HTMLCanvasElement value){return new Union16 { Value = value };}
	public static implicit operator Union16(ImageBitmap value){return new Union16 { Value = value };}
	public static implicit operator Union16(OffscreenCanvas value){return new Union16 { Value = value };}
	public static implicit operator Union16(VideoFrame value){return new Union16 { Value = value };}
}

///<summary>
///<see cref="string"/> or <see cref="CanvasGradient"/> or <see cref="CanvasPattern"/>
///</summary>
public struct Union17
{
	public dynamic Value { get; set; }
	public static implicit operator Union17(string value){return new Union17 { Value = value };}
	public static implicit operator Union17(CanvasGradient value){return new Union17 { Value = value };}
	public static implicit operator Union17(CanvasPattern value){return new Union17 { Value = value };}
}

///<summary>
///<see cref="string"/> or <see cref="CanvasGradient"/> or <see cref="CanvasPattern"/>
///</summary>
public struct Union18
{
	public dynamic Value { get; set; }
	public static implicit operator Union18(string value){return new Union18 { Value = value };}
	public static implicit operator Union18(CanvasGradient value){return new Union18 { Value = value };}
	public static implicit operator Union18(CanvasPattern value){return new Union18 { Value = value };}
}

///<summary>
///<see cref="double"/> or <see cref="DOMPointInit"/>
///</summary>
public struct Union20
{
	public dynamic Value { get; set; }
	public static implicit operator Union20(double value){return new Union20 { Value = value };}
	public static implicit operator Union20(DOMPointInit value){return new Union20 { Value = value };}
}

///<summary>
///<see cref="double"/> or <see cref="DOMPointInit"/> or <c>List{Union20}</c>
///</summary>
public struct Union19
{
	public dynamic Value { get; set; }
	public static implicit operator Union19(double value){return new Union19 { Value = value };}
	public static implicit operator Union19(DOMPointInit value){return new Union19 { Value = value };}
	public static implicit operator Union19(List<Union20> value){return new Union19 { Value = value };}
}

///<summary>
///<see cref="Path2D"/> or <see cref="string"/>
///</summary>
public struct Union21
{
	public dynamic Value { get; set; }
	public static implicit operator Union21(Path2D value){return new Union21 { Value = value };}
	public static implicit operator Union21(string value){return new Union21 { Value = value };}
}

///<summary>
///<see cref="HTMLCanvasElement"/> or <see cref="OffscreenCanvas"/>
///</summary>
public struct Union22
{
	public dynamic Value { get; set; }
	public static implicit operator Union22(HTMLCanvasElement value){return new Union22 { Value = value };}
	public static implicit operator Union22(OffscreenCanvas value){return new Union22 { Value = value };}
}

///<summary>
///<see cref="OffscreenCanvasRenderingContext2D"/> or <see cref="ImageBitmapRenderingContext"/> or <see cref="Unsupported /*WebGLRenderingContext*/"/> or <see cref="Unsupported /*WebGL2RenderingContext*/"/> or <see cref="GPUCanvasContext"/>
///</summary>
public struct Union23
{
	public dynamic Value { get; set; }
	public static implicit operator Union23(OffscreenCanvasRenderingContext2D value){return new Union23 { Value = value };}
	public static implicit operator Union23(ImageBitmapRenderingContext value){return new Union23 { Value = value };}
	public static implicit operator Union23(Unsupported /*WebGLRenderingContext*/ value){return new Union23 { Value = value };}
	public static implicit operator Union23(GPUCanvasContext value){return new Union23 { Value = value };}
}

///<summary>
///<see cref="CustomElementConstructor"/> or <see cref="Undefined"/>
///</summary>
public struct Union24
{
	public dynamic Value { get; set; }
	public static implicit operator Union24(CustomElementConstructor value){return new Union24 { Value = value };}
	public static implicit operator Union24(Undefined value){return new Union24 { Value = value };}
}

///<summary>
///<see cref="File"/> or <see cref="string"/> or <see cref="FormData"/>
///</summary>
public struct Union25
{
	public dynamic Value { get; set; }
	public static implicit operator Union25(File value){return new Union25 { Value = value };}
	public static implicit operator Union25(string value){return new Union25 { Value = value };}
	public static implicit operator Union25(FormData value){return new Union25 { Value = value };}
}

///<summary>
///<see cref="File"/> or <see cref="string"/> or <see cref="FormData"/>
///</summary>
public struct Union26
{
	public dynamic Value { get; set; }
	public static implicit operator Union26(File value){return new Union26 { Value = value };}
	public static implicit operator Union26(string value){return new Union26 { Value = value };}
	public static implicit operator Union26(FormData value){return new Union26 { Value = value };}
}

///<summary>
///<see cref="Event"/> or <see cref="string"/>
///</summary>
public struct Union27
{
	public dynamic Value { get; set; }
	public static implicit operator Union27(Event value){return new Union27 { Value = value };}
	public static implicit operator Union27(string value){return new Union27 { Value = value };}
}

///<summary>
///<see cref="string"/> or <see cref="Function"/>
///</summary>
public struct Union28
{
	public dynamic Value { get; set; }
	public static implicit operator Union28(string value){return new Union28 { Value = value };}
	public static implicit operator Union28(Function value){return new Union28 { Value = value };}
}

///<summary>
///<see cref="CanvasImageSource"/> or <see cref="Blob"/> or <see cref="ImageData"/>
///</summary>
public struct Union29
{
	public dynamic Value { get; set; }
	public static implicit operator Union29(CanvasImageSource value){return new Union29 { Value = value };}
	public static implicit operator Union29(Blob value){return new Union29 { Value = value };}
	public static implicit operator Union29(ImageData value){return new Union29 { Value = value };}
}

///<summary>
///<see cref="WindowProxy"/> or <see cref="MessagePort"/> or <see cref="ServiceWorker"/>
///</summary>
public struct Union30
{
	public dynamic Value { get; set; }
	public static implicit operator Union30(WindowProxy value){return new Union30 { Value = value };}
	public static implicit operator Union30(MessagePort value){return new Union30 { Value = value };}
	public static implicit operator Union30(ServiceWorker value){return new Union30 { Value = value };}
}

///<summary>
///<see cref="string"/> or <see cref="WorkerOptions"/>
///</summary>
public struct Union31
{
	public dynamic Value { get; set; }
	public static implicit operator Union31(string value){return new Union31 { Value = value };}
	public static implicit operator Union31(WorkerOptions value){return new Union31 { Value = value };}
}

///<summary>
///<see cref="PasswordCredentialData"/> or <see cref="HTMLFormElement"/>
///</summary>
public struct Union32
{
	public dynamic Value { get; set; }
	public static implicit operator Union32(PasswordCredentialData value){return new Union32 { Value = value };}
	public static implicit operator Union32(HTMLFormElement value){return new Union32 { Value = value };}
}

///<summary>
///<see cref="AnimationEffect"/> or <c>List{AnimationEffect}</c>
///</summary>
public struct Union33
{
	public dynamic Value { get; set; }
	public static implicit operator Union33(AnimationEffect value){return new Union33 { Value = value };}
	public static implicit operator Union33(List<AnimationEffect> value){return new Union33 { Value = value };}
}

///<summary>
///<see cref="byte[]"/> or <see cref="ArrayBufferView"/>
///</summary>
public struct Union34
{
	public dynamic Value { get; set; }
	public static implicit operator Union34(byte[] value){return new Union34 { Value = value };}
	public static implicit operator Union34(ArrayBufferView value){return new Union34 { Value = value };}
}

///<summary>
///<see cref="Unsupported /*CSSOMString*/"/> or <see cref="BinaryData"/>
///</summary>
public struct Union35
{
	public dynamic Value { get; set; }
	public static implicit operator Union35(Unsupported /*CSSOMString*/ value){return new Union35 { Value = value };}
	public static implicit operator Union35(BinaryData value){return new Union35 { Value = value };}
}

///<summary>
///<see cref="IntrinsicSizesRequest"/> or <see cref="LayoutFragmentRequest"/>
///</summary>
public struct Union36
{
	public dynamic Value { get; set; }
	public static implicit operator Union36(IntrinsicSizesRequest value){return new Union36 { Value = value };}
	public static implicit operator Union36(LayoutFragmentRequest value){return new Union36 { Value = value };}
}

///<summary>
///<see cref="Element"/> or <see cref="ProcessingInstruction"/>
///</summary>
public struct Union37
{
	public dynamic Value { get; set; }
	public static implicit operator Union37(Element value){return new Union37 { Value = value };}
	public static implicit operator Union37(ProcessingInstruction value){return new Union37 { Value = value };}
}

///<summary>
///<see cref="MediaList"/> or <see cref="string"/>
///</summary>
public struct Union38
{
	public dynamic Value { get; set; }
	public static implicit operator Union38(MediaList value){return new Union38 { Value = value };}
	public static implicit operator Union38(string value){return new Union38 { Value = value };}
}

///<summary>
///<see cref="Element"/> or <see cref="CSSPseudoElement"/>
///</summary>
public struct Union39
{
	public dynamic Value { get; set; }
	public static implicit operator Union39(Element value){return new Union39 { Value = value };}
	public static implicit operator Union39(CSSPseudoElement value){return new Union39 { Value = value };}
}

///<summary>
///<see cref="Event"/> or <see cref="Undefined"/>
///</summary>
public struct Union40
{
	public dynamic Value { get; set; }
	public static implicit operator Union40(Event value){return new Union40 { Value = value };}
	public static implicit operator Union40(Undefined value){return new Union40 { Value = value };}
}

///<summary>
///<see cref="AddEventListenerOptions"/> or <see cref="bool"/>
///</summary>
public struct Union41
{
	public dynamic Value { get; set; }
	public static implicit operator Union41(AddEventListenerOptions value){return new Union41 { Value = value };}
	public static implicit operator Union41(bool value){return new Union41 { Value = value };}
}

///<summary>
///<see cref="EventListenerOptions"/> or <see cref="bool"/>
///</summary>
public struct Union42
{
	public dynamic Value { get; set; }
	public static implicit operator Union42(EventListenerOptions value){return new Union42 { Value = value };}
	public static implicit operator Union42(bool value){return new Union42 { Value = value };}
}

///<summary>
///<see cref="Node"/> or <see cref="string"/>
///</summary>
public struct Union43
{
	public dynamic Value { get; set; }
	public static implicit operator Union43(Node value){return new Union43 { Value = value };}
	public static implicit operator Union43(string value){return new Union43 { Value = value };}
}

///<summary>
///<see cref="Node"/> or <see cref="string"/>
///</summary>
public struct Union44
{
	public dynamic Value { get; set; }
	public static implicit operator Union44(Node value){return new Union44 { Value = value };}
	public static implicit operator Union44(string value){return new Union44 { Value = value };}
}

///<summary>
///<see cref="Node"/> or <see cref="string"/>
///</summary>
public struct Union45
{
	public dynamic Value { get; set; }
	public static implicit operator Union45(Node value){return new Union45 { Value = value };}
	public static implicit operator Union45(string value){return new Union45 { Value = value };}
}

///<summary>
///<see cref="Node"/> or <see cref="string"/>
///</summary>
public struct Union46
{
	public dynamic Value { get; set; }
	public static implicit operator Union46(Node value){return new Union46 { Value = value };}
	public static implicit operator Union46(string value){return new Union46 { Value = value };}
}

///<summary>
///<see cref="Node"/> or <see cref="string"/>
///</summary>
public struct Union47
{
	public dynamic Value { get; set; }
	public static implicit operator Union47(Node value){return new Union47 { Value = value };}
	public static implicit operator Union47(string value){return new Union47 { Value = value };}
}

///<summary>
///<see cref="Node"/> or <see cref="string"/>
///</summary>
public struct Union48
{
	public dynamic Value { get; set; }
	public static implicit operator Union48(Node value){return new Union48 { Value = value };}
	public static implicit operator Union48(string value){return new Union48 { Value = value };}
}

///<summary>
///<see cref="string"/> or <see cref="ElementCreationOptions"/>
///</summary>
public struct Union49
{
	public dynamic Value { get; set; }
	public static implicit operator Union49(string value){return new Union49 { Value = value };}
	public static implicit operator Union49(ElementCreationOptions value){return new Union49 { Value = value };}
}

///<summary>
///<see cref="string"/> or <see cref="ElementCreationOptions"/>
///</summary>
public struct Union50
{
	public dynamic Value { get; set; }
	public static implicit operator Union50(string value){return new Union50 { Value = value };}
	public static implicit operator Union50(ElementCreationOptions value){return new Union50 { Value = value };}
}

///<summary>
///<see cref="BufferSource"/> or <see cref="Blob"/> or <see cref="string"/>
///</summary>
public struct Union51
{
	public dynamic Value { get; set; }
	public static implicit operator Union51(BufferSource value){return new Union51 { Value = value };}
	public static implicit operator Union51(Blob value){return new Union51 { Value = value };}
	public static implicit operator Union51(string value){return new Union51 { Value = value };}
}

///<summary>
///<see cref="string"/> or <see cref="byte[]"/>
///</summary>
public struct Union52
{
	public dynamic Value { get; set; }
	public static implicit operator Union52(string value){return new Union52 { Value = value };}
	public static implicit operator Union52(byte[] value){return new Union52 { Value = value };}
}

///<summary>
///<see cref="Blob"/> or <see cref="Unsupported /*MediaSource*/"/>
///</summary>
public struct Union53
{
	public dynamic Value { get; set; }
	public static implicit operator Union53(Blob value){return new Union53 { Value = value };}
	public static implicit operator Union53(Unsupported /*MediaSource*/ value){return new Union53 { Value = value };}
}

///<summary>
///<see cref="string"/> or <c>List{double}</c>
///</summary>
public struct Union54
{
	public dynamic Value { get; set; }
	public static implicit operator Union54(string value){return new Union54 { Value = value };}
	public static implicit operator Union54(List<double> value){return new Union54 { Value = value };}
}

///<summary>
///<see cref="string"/> or <c>List{double}</c>
///</summary>
public struct Union55
{
	public dynamic Value { get; set; }
	public static implicit operator Union55(string value){return new Union55 { Value = value };}
	public static implicit operator Union55(List<double> value){return new Union55 { Value = value };}
}

///<summary>
///<c>List{List{string}}</c> or <c>Dictionary{string, string}</c>
///</summary>
public struct Union56
{
	public dynamic Value { get; set; }
	public static implicit operator Union56(List<List<string>> value){return new Union56 { Value = value };}
	public static implicit operator Union56(Dictionary<string, string> value){return new Union56 { Value = value };}
}

///<summary>
///<see cref="Blob"/> or <see cref="BufferSource"/> or <see cref="FormData"/> or <see cref="URLSearchParams"/> or <see cref="string"/>
///</summary>
public struct Union57
{
	public dynamic Value { get; set; }
	public static implicit operator Union57(Blob value){return new Union57 { Value = value };}
	public static implicit operator Union57(BufferSource value){return new Union57 { Value = value };}
	public static implicit operator Union57(FormData value){return new Union57 { Value = value };}
	public static implicit operator Union57(URLSearchParams value){return new Union57 { Value = value };}
	public static implicit operator Union57(string value){return new Union57 { Value = value };}
}

///<summary>
///<see cref="ReadableStream"/> or <see cref="XMLHttpRequestBodyInit"/>
///</summary>
public struct Union58
{
	public dynamic Value { get; set; }
	public static implicit operator Union58(ReadableStream value){return new Union58 { Value = value };}
	public static implicit operator Union58(XMLHttpRequestBodyInit value){return new Union58 { Value = value };}
}

///<summary>
///<see cref="Request"/> or <see cref="string"/>
///</summary>
public struct Union59
{
	public dynamic Value { get; set; }
	public static implicit operator Union59(Request value){return new Union59 { Value = value };}
	public static implicit operator Union59(string value){return new Union59 { Value = value };}
}

///<summary>
///<see cref="BufferSource"/> or <see cref="Blob"/> or <see cref="string"/>
///</summary>
public struct Union60
{
	public dynamic Value { get; set; }
	public static implicit operator Union60(BufferSource value){return new Union60 { Value = value };}
	public static implicit operator Union60(Blob value){return new Union60 { Value = value };}
	public static implicit operator Union60(string value){return new Union60 { Value = value };}
}

///<summary>
///<see cref="BufferSource"/> or <see cref="Blob"/> or <see cref="string"/> or <see cref="WriteParams"/>
///</summary>
public struct Union61
{
	public dynamic Value { get; set; }
	public static implicit operator Union61(BufferSource value){return new Union61 { Value = value };}
	public static implicit operator Union61(Blob value){return new Union61 { Value = value };}
	public static implicit operator Union61(string value){return new Union61 { Value = value };}
	public static implicit operator Union61(WriteParams value){return new Union61 { Value = value };}
}

///<summary>
///<see cref="ReadableStreamDefaultReader"/> or <see cref="ReadableStreamBYOBReader"/>
///</summary>
public struct Union62
{
	public dynamic Value { get; set; }
	public static implicit operator Union62(ReadableStreamDefaultReader value){return new Union62 { Value = value };}
	public static implicit operator Union62(ReadableStreamBYOBReader value){return new Union62 { Value = value };}
}

///<summary>
///<see cref="ReadableStreamDefaultController"/> or <see cref="ReadableByteStreamController"/>
///</summary>
public struct Union63
{
	public dynamic Value { get; set; }
	public static implicit operator Union63(ReadableStreamDefaultController value){return new Union63 { Value = value };}
	public static implicit operator Union63(ReadableByteStreamController value){return new Union63 { Value = value };}
}

///<summary>
///<c>List{List{string}}</c> or <c>Dictionary{string, string}</c> or <see cref="string"/>
///</summary>
public struct Union64
{
	public dynamic Value { get; set; }
	public static implicit operator Union64(List<List<string>> value){return new Union64 { Value = value };}
	public static implicit operator Union64(Dictionary<string, string> value){return new Union64 { Value = value };}
	public static implicit operator Union64(string value){return new Union64 { Value = value };}
}

///<summary>
///<see cref="string"/> or <see cref="URLPatternInit"/>
///</summary>
public struct Union65
{
	public dynamic Value { get; set; }
	public static implicit operator Union65(string value){return new Union65 { Value = value };}
	public static implicit operator Union65(URLPatternInit value){return new Union65 { Value = value };}
}

///<summary>
///<see cref="System.SByte"/> or <see cref="System.Int16"/> or <see cref="System.Int32"/> or <see cref="System.Byte"/> or <see cref="System.UInt16"/> or <see cref="System.UInt32"/> or <see cref="Unsupported /*Uint8ClampedArray*/"/> or <see cref="System.Int64"/> or <see cref="System.UInt64"/> or <see cref="System.Single"/> or <see cref="System.Double"/> or <see cref="Unsupported /*DataView*/"/>
///</summary>
public struct Union66
{
	public dynamic Value { get; set; }
	public static implicit operator Union66(System.SByte value){return new Union66 { Value = value };}
	public static implicit operator Union66(System.Int16 value){return new Union66 { Value = value };}
	public static implicit operator Union66(System.Int32 value){return new Union66 { Value = value };}
	public static implicit operator Union66(System.Byte value){return new Union66 { Value = value };}
	public static implicit operator Union66(System.UInt16 value){return new Union66 { Value = value };}
	public static implicit operator Union66(System.UInt32 value){return new Union66 { Value = value };}
	public static implicit operator Union66(Unsupported /*Uint8ClampedArray*/ value){return new Union66 { Value = value };}
	public static implicit operator Union66(System.Int64 value){return new Union66 { Value = value };}
	public static implicit operator Union66(System.UInt64 value){return new Union66 { Value = value };}
	public static implicit operator Union66(System.Single value){return new Union66 { Value = value };}
	public static implicit operator Union66(System.Double value){return new Union66 { Value = value };}
}

///<summary>
///<see cref="ArrayBufferView"/> or <see cref="byte[]"/>
///</summary>
public struct Union67
{
	public dynamic Value { get; set; }
	public static implicit operator Union67(ArrayBufferView value){return new Union67 { Value = value };}
	public static implicit operator Union67(byte[] value){return new Union67 { Value = value };}
}

///<summary>
///<see cref="byte[]"/> or <see cref="Unsupported /*SharedArrayBuffer*/"/> or <see cref="ArrayBufferView"/>
///</summary>
public struct Union68
{
	public dynamic Value { get; set; }
	public static implicit operator Union68(byte[] value){return new Union68 { Value = value };}
	public static implicit operator Union68(Unsupported /*SharedArrayBuffer*/ value){return new Union68 { Value = value };}
	public static implicit operator Union68(ArrayBufferView value){return new Union68 { Value = value };}
}

///<summary>
///<see cref="string"/> or <c>List{string}</c>
///</summary>
public struct Union69
{
	public dynamic Value { get; set; }
	public static implicit operator Union69(string value){return new Union69 { Value = value };}
	public static implicit operator Union69(List<string> value){return new Union69 { Value = value };}
}

///<summary>
///<see cref="BufferSource"/> or <see cref="Blob"/> or <see cref="string"/>
///</summary>
public struct Union70
{
	public dynamic Value { get; set; }
	public static implicit operator Union70(BufferSource value){return new Union70 { Value = value };}
	public static implicit operator Union70(Blob value){return new Union70 { Value = value };}
	public static implicit operator Union70(string value){return new Union70 { Value = value };}
}

///<summary>
///<see cref="Document"/> or <see cref="XMLHttpRequestBodyInit"/>
///</summary>
public struct Union71
{
	public dynamic Value { get; set; }
	public static implicit operator Union71(Document value){return new Union71 { Value = value };}
	public static implicit operator Union71(XMLHttpRequestBodyInit value){return new Union71 { Value = value };}
}

///<summary>
///<see cref="File"/> or <see cref="string"/>
///</summary>
public struct Union72
{
	public dynamic Value { get; set; }
	public static implicit operator Union72(File value){return new Union72 { Value = value };}
	public static implicit operator Union72(string value){return new Union72 { Value = value };}
}

///<summary>
///<see cref="IDBObjectStore"/> or <see cref="IDBIndex"/> or <see cref="IDBCursor"/>
///</summary>
public struct Union73
{
	public dynamic Value { get; set; }
	public static implicit operator Union73(IDBObjectStore value){return new Union73 { Value = value };}
	public static implicit operator Union73(IDBIndex value){return new Union73 { Value = value };}
	public static implicit operator Union73(IDBCursor value){return new Union73 { Value = value };}
}

///<summary>
///<see cref="string"/> or <c>List{string}</c>
///</summary>
public struct Union74
{
	public dynamic Value { get; set; }
	public static implicit operator Union74(string value){return new Union74 { Value = value };}
	public static implicit operator Union74(List<string> value){return new Union74 { Value = value };}
}

///<summary>
///<see cref="string"/> or <c>List{string}</c>
///</summary>
public struct Union75
{
	public dynamic Value { get; set; }
	public static implicit operator Union75(string value){return new Union75 { Value = value };}
	public static implicit operator Union75(List<string> value){return new Union75 { Value = value };}
}

///<summary>
///<see cref="string"/> or <c>List{string}</c>
///</summary>
public struct Union76
{
	public dynamic Value { get; set; }
	public static implicit operator Union76(string value){return new Union76 { Value = value };}
	public static implicit operator Union76(List<string> value){return new Union76 { Value = value };}
}

///<summary>
///<see cref="IDBObjectStore"/> or <see cref="IDBIndex"/>
///</summary>
public struct Union77
{
	public dynamic Value { get; set; }
	public static implicit operator Union77(IDBObjectStore value){return new Union77 { Value = value };}
	public static implicit operator Union77(IDBIndex value){return new Union77 { Value = value };}
}

///<summary>
///<see cref="Element"/> or <see cref="Document"/>
///</summary>
public struct Union78
{
	public dynamic Value { get; set; }
	public static implicit operator Union78(Element value){return new Union78 { Value = value };}
	public static implicit operator Union78(Document value){return new Union78 { Value = value };}
}

///<summary>
///<see cref="Element"/> or <see cref="Document"/>
///</summary>
public struct Union79
{
	public dynamic Value { get; set; }
	public static implicit operator Union79(Element value){return new Union79 { Value = value };}
	public static implicit operator Union79(Document value){return new Union79 { Value = value };}
}

///<summary>
///<see cref="Number"/> or <c>List{Number}</c>
///</summary>
public struct Union80
{
	public dynamic Value { get; set; }
	public static implicit operator Union80(Number value){return new Union80 { Value = value };}
	public static implicit operator Union80(List<Number> value){return new Union80 { Value = value };}
}

///<summary>
///<see cref="bool"/> or <see cref="Unsupported /*ConstrainDouble*/"/>
///</summary>
public struct Union81
{
	public dynamic Value { get; set; }
	public static implicit operator Union81(bool value){return new Union81 { Value = value };}
	public static implicit operator Union81(Unsupported /*ConstrainDouble*/ value){return new Union81 { Value = value };}
}

///<summary>
///<see cref="bool"/> or <see cref="Unsupported /*ConstrainDouble*/"/>
///</summary>
public struct Union82
{
	public dynamic Value { get; set; }
	public static implicit operator Union82(bool value){return new Union82 { Value = value };}
	public static implicit operator Union82(Unsupported /*ConstrainDouble*/ value){return new Union82 { Value = value };}
}

///<summary>
///<see cref="bool"/> or <see cref="Unsupported /*ConstrainDouble*/"/>
///</summary>
public struct Union83
{
	public dynamic Value { get; set; }
	public static implicit operator Union83(bool value){return new Union83 { Value = value };}
	public static implicit operator Union83(Unsupported /*ConstrainDouble*/ value){return new Union83 { Value = value };}
}

///<summary>
///<c>List{Point2D}</c> or <see cref="ConstrainPoint2DParameters"/>
///</summary>
public struct Union84
{
	public dynamic Value { get; set; }
	public static implicit operator Union84(List<Point2D> value){return new Union84 { Value = value };}
	public static implicit operator Union84(ConstrainPoint2DParameters value){return new Union84 { Value = value };}
}

///<summary>
///<see cref="System.Single"/> or <see cref="System.Double"/> or <see cref="DOMMatrix"/>
///</summary>
public struct Union85
{
	public dynamic Value { get; set; }
	public static implicit operator Union85(System.Single value){return new Union85 { Value = value };}
	public static implicit operator Union85(System.Double value){return new Union85 { Value = value };}
	public static implicit operator Union85(DOMMatrix value){return new Union85 { Value = value };}
}

///<summary>
///<see cref="Unsupported /*CSSNumericValue*/"/> or <see cref="Unsupported /*CSSKeywordValue*/"/>
///</summary>
public struct Union87
{
	public dynamic Value { get; set; }
	public static implicit operator Union87(Unsupported /*CSSNumericValue*/ value){return new Union87 { Value = value };}
}

///<summary>
///<see cref="string"/> or <c>List{Union87}</c>
///</summary>
public struct Union86
{
	public dynamic Value { get; set; }
	public static implicit operator Union86(string value){return new Union86 { Value = value };}
	public static implicit operator Union86(List<Union87> value){return new Union86 { Value = value };}
}

///<summary>
///<see cref="Client"/> or <see cref="ServiceWorker"/> or <see cref="MessagePort"/>
///</summary>
public struct Union88
{
	public dynamic Value { get; set; }
	public static implicit operator Union88(Client value){return new Union88 { Value = value };}
	public static implicit operator Union88(ServiceWorker value){return new Union88 { Value = value };}
	public static implicit operator Union88(MessagePort value){return new Union88 { Value = value };}
}

///<summary>
///<see cref="Client"/> or <see cref="ServiceWorker"/> or <see cref="MessagePort"/>
///</summary>
public struct Union89
{
	public dynamic Value { get; set; }
	public static implicit operator Union89(Client value){return new Union89 { Value = value };}
	public static implicit operator Union89(ServiceWorker value){return new Union89 { Value = value };}
	public static implicit operator Union89(MessagePort value){return new Union89 { Value = value };}
}

///<summary>
///<see cref="double"/> or <see cref="Unsupported /*CSSNumericValue*/"/> or <see cref="string"/>
///</summary>
public struct Union90
{
	public dynamic Value { get; set; }
	public static implicit operator Union90(double value){return new Union90 { Value = value };}
	public static implicit operator Union90(Unsupported /*CSSNumericValue*/ value){return new Union90 { Value = value };}
	public static implicit operator Union90(string value){return new Union90 { Value = value };}
}

///<summary>
///<see cref="double"/> or <see cref="EffectTiming"/>
///</summary>
public struct Union91
{
	public dynamic Value { get; set; }
	public static implicit operator Union91(double value){return new Union91 { Value = value };}
	public static implicit operator Union91(EffectTiming value){return new Union91 { Value = value };}
}

///<summary>
///<see cref="double"/> or <see cref="EffectTiming"/>
///</summary>
public struct Union92
{
	public dynamic Value { get; set; }
	public static implicit operator Union92(double value){return new Union92 { Value = value };}
	public static implicit operator Union92(EffectTiming value){return new Union92 { Value = value };}
}

///<summary>
///<see cref="Element"/> or <see cref="CSSPseudoElement"/>
///</summary>
public struct Union93
{
	public dynamic Value { get; set; }
	public static implicit operator Union93(Element value){return new Union93 { Value = value };}
	public static implicit operator Union93(CSSPseudoElement value){return new Union93 { Value = value };}
}

///<summary>
///<see cref="AudioContextLatencyCategory"/> or <see cref="Number"/>
///</summary>
public struct Union94
{
	public dynamic Value { get; set; }
	public static implicit operator Union94(AudioContextLatencyCategory value){return new Union94 { Value = value };}
	public static implicit operator Union94(Number value){return new Union94 { Value = value };}
}

///<summary>
///<see cref="BufferSource"/> or <see cref="ReadableStream"/>
///</summary>
public struct Union95
{
	public dynamic Value { get; set; }
	public static implicit operator Union95(BufferSource value){return new Union95 { Value = value };}
	public static implicit operator Union95(ReadableStream value){return new Union95 { Value = value };}
}

///<summary>
///<see cref="HTMLVideoElement"/> or <see cref="VideoFrame"/>
///</summary>
public struct Union96
{
	public dynamic Value { get; set; }
	public static implicit operator Union96(HTMLVideoElement value){return new Union96 { Value = value };}
	public static implicit operator Union96(VideoFrame value){return new Union96 { Value = value };}
}

///<summary>
///<see cref="GPUSampler"/> or <see cref="GPUTextureView"/> or <see cref="GPUBufferBinding"/> or <see cref="GPUExternalTexture"/>
///</summary>
public struct Union97
{
	public dynamic Value { get; set; }
	public static implicit operator Union97(GPUSampler value){return new Union97 { Value = value };}
	public static implicit operator Union97(GPUTextureView value){return new Union97 { Value = value };}
	public static implicit operator Union97(GPUBufferBinding value){return new Union97 { Value = value };}
	public static implicit operator Union97(GPUExternalTexture value){return new Union97 { Value = value };}
}

///<summary>
///<see cref="GPUPipelineLayout"/> or <see cref="GPUAutoLayoutMode"/>
///</summary>
public struct Union98
{
	public dynamic Value { get; set; }
	public static implicit operator Union98(GPUPipelineLayout value){return new Union98 { Value = value };}
	public static implicit operator Union98(GPUAutoLayoutMode value){return new Union98 { Value = value };}
}

///<summary>
///<see cref="GPUPipelineLayout"/> or <see cref="GPUAutoLayoutMode"/>
///</summary>
public struct Union99
{
	public dynamic Value { get; set; }
	public static implicit operator Union99(GPUPipelineLayout value){return new Union99 { Value = value };}
	public static implicit operator Union99(GPUAutoLayoutMode value){return new Union99 { Value = value };}
}

///<summary>
///<see cref="ImageBitmap"/> or <see cref="ImageData"/> or <see cref="HTMLImageElement"/> or <see cref="HTMLVideoElement"/> or <see cref="VideoFrame"/> or <see cref="HTMLCanvasElement"/> or <see cref="OffscreenCanvas"/>
///</summary>
public struct Union100
{
	public dynamic Value { get; set; }
	public static implicit operator Union100(ImageBitmap value){return new Union100 { Value = value };}
	public static implicit operator Union100(ImageData value){return new Union100 { Value = value };}
	public static implicit operator Union100(HTMLImageElement value){return new Union100 { Value = value };}
	public static implicit operator Union100(HTMLVideoElement value){return new Union100 { Value = value };}
	public static implicit operator Union100(VideoFrame value){return new Union100 { Value = value };}
	public static implicit operator Union100(HTMLCanvasElement value){return new Union100 { Value = value };}
	public static implicit operator Union100(OffscreenCanvas value){return new Union100 { Value = value };}
}

///<summary>
///<see cref="HTMLCanvasElement"/> or <see cref="OffscreenCanvas"/>
///</summary>
public struct Union101
{
	public dynamic Value { get; set; }
	public static implicit operator Union101(HTMLCanvasElement value){return new Union101 { Value = value };}
	public static implicit operator Union101(OffscreenCanvas value){return new Union101 { Value = value };}
}

///<summary>
///<c>List{Number}</c> or <see cref="GPUColorDict"/>
///</summary>
public struct Union102
{
	public dynamic Value { get; set; }
	public static implicit operator Union102(List<Number> value){return new Union102 { Value = value };}
	public static implicit operator Union102(GPUColorDict value){return new Union102 { Value = value };}
}

///<summary>
///<c>List{GPUIntegerCoordinate}</c> or <see cref="GPUOrigin2DDict"/>
///</summary>
public struct Union103
{
	public dynamic Value { get; set; }
	public static implicit operator Union103(List<GPUIntegerCoordinate> value){return new Union103 { Value = value };}
	public static implicit operator Union103(GPUOrigin2DDict value){return new Union103 { Value = value };}
}

///<summary>
///<c>List{GPUIntegerCoordinate}</c> or <see cref="GPUOrigin3DDict"/>
///</summary>
public struct Union104
{
	public dynamic Value { get; set; }
	public static implicit operator Union104(List<GPUIntegerCoordinate> value){return new Union104 { Value = value };}
	public static implicit operator Union104(GPUOrigin3DDict value){return new Union104 { Value = value };}
}

///<summary>
///<c>List{GPUIntegerCoordinate}</c> or <see cref="GPUExtent3DDict"/>
///</summary>
public struct Union105
{
	public dynamic Value { get; set; }
	public static implicit operator Union105(List<GPUIntegerCoordinate> value){return new Union105 { Value = value };}
	public static implicit operator Union105(GPUExtent3DDict value){return new Union105 { Value = value };}
}

///<summary>
///<see cref="GPUBuffer"/> or <see cref="GPUTexture"/>
///</summary>
public struct Union106
{
	public dynamic Value { get; set; }
	public static implicit operator Union106(GPUBuffer value){return new Union106 { Value = value };}
	public static implicit operator Union106(GPUTexture value){return new Union106 { Value = value };}
}

///<summary>
///<see cref="ArrayBufferView"/> or <see cref="MLBufferResourceView"/>
///</summary>
public struct Union107
{
	public dynamic Value { get; set; }
	public static implicit operator Union107(ArrayBufferView value){return new Union107 { Value = value };}
	public static implicit operator Union107(MLBufferResourceView value){return new Union107 { Value = value };}
}

///<summary>
///<see cref="ulong"/> or <c>List{ulong}</c>
///</summary>
public struct Union108
{
	public dynamic Value { get; set; }
	public static implicit operator Union108(ulong value){return new Union108 { Value = value };}
	public static implicit operator Union108(List<ulong> value){return new Union108 { Value = value };}
}

///<summary>
///<see cref="SFrameTransform"/> or <see cref="RTCRtpScriptTransform"/>
///</summary>
public struct Union109
{
	public dynamic Value { get; set; }
	public static implicit operator Union109(SFrameTransform value){return new Union109 { Value = value };}
	public static implicit operator Union109(RTCRtpScriptTransform value){return new Union109 { Value = value };}
}

///<summary>
///<see cref="SmallCryptoKeyID"/> or <see cref="double"/>
///</summary>
public struct Union110
{
	public dynamic Value { get; set; }
	public static implicit operator Union110(SmallCryptoKeyID value){return new Union110 { Value = value };}
	public static implicit operator Union110(double value){return new Union110 { Value = value };}
}

///<summary>
///<see cref="Number"/> or <see cref="AutoKeyword"/>
///</summary>
public struct Union111
{
	public dynamic Value { get; set; }
	public static implicit operator Union111(Number value){return new Union111 { Value = value };}
	public static implicit operator Union111(AutoKeyword value){return new Union111 { Value = value };}
}

///<summary>
///<see cref="Unsupported /*WebGLRenderingContext*/"/> or <see cref="Unsupported /*WebGL2RenderingContext*/"/>
///</summary>
public struct Union112
{
	public dynamic Value { get; set; }
	public static implicit operator Union112(Unsupported /*WebGLRenderingContext*/ value){return new Union112 { Value = value };}
}

