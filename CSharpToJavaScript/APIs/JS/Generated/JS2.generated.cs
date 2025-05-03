//03.05.2025 17:58:03

#nullable enable
//Disable missing XML comments.
#pragma warning disable CS1591

using static CSharpToJavaScript.APIs.JS.Ecma.GlobalObject;
using CSharpToJavaScript.APIs.JS.Ecma;
using CSharpToJavaScript.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpToJavaScript.APIs.JS;

//
using WindowProxy = Window;
using USVString = string;
using ByteString = string;
using DOMString = string;
//

using ClipboardItemData = Task<string>;
using ClipboardItems = List<ClipboardItem>;
using CookieList = List<CookieListItem>;
using PasswordCredentialInit = Union1;
using CSSStringSource = Union5;
using CSSToken = Union6;
using CSSUnparsedSegment = Union11;
using CSSKeywordish = Union12;
using CSSNumberish = Union13;
using CSSPerspectiveValue = Union14;
using CSSColorRGBComp = Union16;
using CSSColorPercent = Union17;
using CSSColorNumber = Union18;
using CSSColorAngle = Union19;
using GeometryNode = Union22;
using CSSOMString = string;
using GLuint64EXT = ulong;
using UrnOrConfig = Union37;
using ReportEventType = Union38;
using HeadersInit = Union39;
using XMLHttpRequestBodyInit = Union40;
using BodyInit = Union41;
using RequestInfo = Union42;
using StartInDirectory = Union43;
using BlobPart = Union44;
using FileSystemWriteChunkType = Union48;
using DOMHighResTimeStamp = Number;
using EpochTimeStamp = ulong;
using HTMLOrSVGScriptElement = Union56;
using MediaProvider = Union63;
using RenderingContext = Union70;
using HTMLOrSVGImageElement = Union71;
using CanvasImageSource = Union72;
using OffscreenRenderingContext = Union79;
using EventHandler = EventHandlerNonNull;
using OnErrorEventHandler = OnErrorEventHandlerNonNull;
using OnBeforeUnloadEventHandler = OnBeforeUnloadEventHandlerNonNull;
using TimerHandler = Union84;
using ImageBitmapSource = Union93;
using MessageEventSource = Union94;
using ConstrainPoint2D = Union102;
using ProfilerResource = string;
using ConstrainULong = Union115;
using ConstrainDouble = Union116;
using ConstrainBoolean = Union117;
using ConstrainDOMString = Union118;
using Megabit = double;
using Millisecond = ulong;
using ObserverUnion = Union119;
using ObservableInspectorUnion = Union120;
using RotationMatrixType = Union121;
using PerformanceEntryList = List<PerformanceEntry>;
using PushMessageDataInit = Union123;
using ReportList = List<Report>;
using SanitizerElement = Union129;
using SanitizerElementWithAttributes = Union130;
using SanitizerAttribute = Union131;
using RouterSource = Union139;
using SharedStorageResponse = Union142;
using ReadableStreamReader = Union143;
using ReadableStreamController = Union144;
using TrustedType = Union146;
using PreviousWinElement = Union152;
using PreviousWin = List<Unsupported /*PreviousWinElement*/>;
using URLPatternInput = Union154;
using URLPatternCompatible = Union155;
using VibratePattern = Union159;
using UUID = string;
using BluetoothServiceUUID = Union176;
using BluetoothCharacteristicUUID = Union177;
using BluetoothDescriptorUUID = Union178;
using NDEFMessageSource = Union179;
using Base64URLString = string;
using PublicKeyCredentialJSON = Object;
using PublicKeyCredentialClientCapabilities = Dictionary<string, bool>;
using COSEAlgorithmIdentifier = long;
using ImageBufferSource = Union186;
using AlgorithmIdentifier = Union187;
using HashAlgorithmIdentifier = Unsupported /*AlgorithmIdentifier*/;
using BigInteger = Uint8Array;
using NamedCurve = string;
using GLenum = ulong;
using GLboolean = bool;
using GLbitfield = ulong;
using GLbyte = byte;
using GLshort = Number;
using GLint = long;
using GLsizei = long;
using GLintptr = long;
using GLsizeiptr = long;
using GLubyte = byte;
using GLushort = ushort;
using GLuint = ulong;
using GLfloat = float;
using GLclampf = float;
using TexImageSource = Union189;
using Float32List = Union190;
using Int32List = Union191;
using GLint64 = long;
using GLuint64 = ulong;
using Uint32List = Union193;
using GPUBufferUsageFlags = ulong;
using GPUMapModeFlags = ulong;
using GPUTextureUsageFlags = ulong;
using GPUShaderStageFlags = ulong;
using GPUBindingResource = Union214;
using GPUPipelineConstantValue = Number;
using GPUColorWriteFlags = ulong;
using GPUCopyExternalImageSource = Union217;
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
using GPUColor = Union219;
using GPUOrigin2D = Union220;
using GPUOrigin3D = Union221;
using GPUExtent3D = Union222;
using ArrayBufferView = Union223;
using BufferSource = Union224;
using AllowSharedBufferSource = Union225;
using MLNamedTensors = Dictionary<string, MLTensor>;
using MLNumber = Union226;
using MLNamedOperands = Dictionary<string, MLOperand>;
using RTCRtpTransform = Union228;
using SmallCryptoKeyID = ulong;
using CryptoKeyID = Union229;
using LineAndPositionSetting = Union234;
using XRWebGLRenderingContext = Union235;
using FormDataEntryValue = Union237;


[Value("HTMLAttributionSrcElementUtils")]
public partial interface HTMLAttributionSrcElementUtils
{
	[Value("attributionSrc")]
	public USVString AttributionSrc { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}





[Value("NavigatorBadge")]
public partial interface NavigatorBadge
{
	[Value("setAppBadge")]
	public Task<Undefined> SetAppBadge(ulong contents = default) { throw new System.NotImplementedException(); }
	[Value("clearAppBadge")]
	public Task<Undefined> ClearAppBadge() { throw new System.NotImplementedException(); }
}



[Value("CredentialUserData")]
public partial interface CredentialUserData
{
	[Value("name")]
	public USVString Name { get { throw new System.NotImplementedException(); } }
	[Value("iconURL")]
	public USVString IconURL { get { throw new System.NotImplementedException(); } }
}

[Value("GlobalEventHandlers")]
public partial interface GlobalEventHandlers
{
	[Value("onanimationstart")]
	public EventHandler Onanimationstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onanimationiteration")]
	public EventHandler Onanimationiteration { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onanimationend")]
	public EventHandler Onanimationend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onanimationcancel")]
	public EventHandler Onanimationcancel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[Value("FontFaceSource")]
public partial interface FontFaceSource
{
	[Value("fonts")]
	public FontFaceSet Fonts { get { throw new System.NotImplementedException(); } }
}



[Value("Region")]
public partial interface Region
{
	[Value("regionOverset")]
	public CSSOMString RegionOverset { get { throw new System.NotImplementedException(); } }
	[Value("getRegionFlowRanges")]
	public List<Range>? GetRegionFlowRanges() { throw new System.NotImplementedException(); }
}


public partial interface GlobalEventHandlers
{
	[Value("onsnapchanged")]
	public EventHandler Onsnapchanged { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onsnapchanging")]
	public EventHandler Onsnapchanging { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

public partial interface GlobalEventHandlers
{
	[Value("ontransitionrun")]
	public EventHandler Ontransitionrun { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ontransitionstart")]
	public EventHandler Ontransitionstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ontransitionend")]
	public EventHandler Ontransitionend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ontransitioncancel")]
	public EventHandler Ontransitioncancel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[Value("ElementCSSInlineStyle")]
public partial interface ElementCSSInlineStyle
{
	[Value("attributeStyleMap")]
	public StylePropertyMap AttributeStyleMap { get { throw new System.NotImplementedException(); } }
}

[Value("GeometryUtils")]
public partial interface GeometryUtils
{
	[Value("getBoxQuads")]
	public List<DOMQuad> GetBoxQuads(BoxQuadOptions options = default) { throw new System.NotImplementedException(); }
	[Value("convertQuadFromNode")]
	public DOMQuad ConvertQuadFromNode(DOMQuadInit quad, GeometryNode from, ConvertCoordinateOptions options = default) { throw new System.NotImplementedException(); }
	[Value("convertRectFromNode")]
	public DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, GeometryNode from, ConvertCoordinateOptions options = default) { throw new System.NotImplementedException(); }
	[Value("convertPointFromNode")]
	public DOMPoint ConvertPointFromNode(DOMPointInit point, GeometryNode from, ConvertCoordinateOptions options = default) { throw new System.NotImplementedException(); }
}






[Value("DocumentOrShadowRoot")]
public partial interface DocumentOrShadowRoot
{
	[Value("styleSheets")]
	public StyleSheetList StyleSheets { get { throw new System.NotImplementedException(); } }
	[Value("adoptedStyleSheets")]
	public CSSStyleSheet[] AdoptedStyleSheets { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[Value("LinkStyle")]
public partial interface LinkStyle
{
	[Value("sheet")]
	public CSSStyleSheet? Sheet { get { throw new System.NotImplementedException(); } }
}


public partial interface ElementCSSInlineStyle
{
	[Value("style")]
	public CSSStyleDeclaration Style { get { throw new System.NotImplementedException(); } }
}




///<include file='Utils/Docs/NavigatorDeviceMemory/NavigatorDeviceMemory.generated.xml' path='docs/NavigatorDeviceMemory/*'/>
[Value("NavigatorDeviceMemory")]
public partial interface NavigatorDeviceMemory
{
	[Value("deviceMemory")]
	public Number DeviceMemory { get { throw new System.NotImplementedException(); } }
}



[Value("EventListener")]
public partial interface EventListener
{
	[Value("handleEvent")]
	public Undefined HandleEvent(Event event_) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Document/Document.generated.xml' path='docs/Document/*'/>
[Value("NonElementParentNode")]
public partial interface NonElementParentNode
{
	///<include file='Utils/Docs/DocumentGetElementById/DocumentGetElementById.generated.xml' path='docs/DocumentGetElementById/*'/>
[Value("getElementById")]
	public Element? GetElementById(DOMString elementId) { throw new System.NotImplementedException(); }
}



public partial interface DocumentOrShadowRoot
{
}



///<include file='Utils/Docs/Element/Element.generated.xml' path='docs/Element/*'/>
[Value("ParentNode")]
public partial interface ParentNode
{
	///<include file='Utils/Docs/ElementChildren/ElementChildren.generated.xml' path='docs/ElementChildren/*'/>
[Value("children")]
	public HTMLCollection Children { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/ElementFirstElementChild/ElementFirstElementChild.generated.xml' path='docs/ElementFirstElementChild/*'/>
[Value("firstElementChild")]
	public Element? FirstElementChild { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/ElementLastElementChild/ElementLastElementChild.generated.xml' path='docs/ElementLastElementChild/*'/>
[Value("lastElementChild")]
	public Element? LastElementChild { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/ElementChildElementCount/ElementChildElementCount.generated.xml' path='docs/ElementChildElementCount/*'/>
[Value("childElementCount")]
	public ulong ChildElementCount { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/ElementPrepend/ElementPrepend.generated.xml' path='docs/ElementPrepend/*'/>
[Value("prepend")]
	public Undefined Prepend(params Union28[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementAppend/ElementAppend.generated.xml' path='docs/ElementAppend/*'/>
[Value("append")]
	public Undefined Append(params Union29[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementReplaceChildren/ElementReplaceChildren.generated.xml' path='docs/ElementReplaceChildren/*'/>
[Value("replaceChildren")]
	public Undefined ReplaceChildren(params Union30[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementQuerySelector/ElementQuerySelector.generated.xml' path='docs/ElementQuerySelector/*'/>
[Value("querySelector")]
	public Element? QuerySelector(DOMString selectors) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementQuerySelectorAll/ElementQuerySelectorAll.generated.xml' path='docs/ElementQuerySelectorAll/*'/>
[Value("querySelectorAll")]
	public NodeList QuerySelectorAll(DOMString selectors) { throw new System.NotImplementedException(); }
}




[Value("NonDocumentTypeChildNode")]
public partial interface NonDocumentTypeChildNode
{
	[Value("previousElementSibling")]
	public Element? PreviousElementSibling { get { throw new System.NotImplementedException(); } }
	[Value("nextElementSibling")]
	public Element? NextElementSibling { get { throw new System.NotImplementedException(); } }
}



///<include file='Utils/Docs/Element/Element.generated.xml' path='docs/Element/*'/>
[Value("ChildNode")]
public partial interface ChildNode
{
	///<include file='Utils/Docs/ElementBefore/ElementBefore.generated.xml' path='docs/ElementBefore/*'/>
[Value("before")]
	public Undefined Before(params Union31[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementAfter/ElementAfter.generated.xml' path='docs/ElementAfter/*'/>
[Value("after")]
	public Undefined After(params Union32[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementReplaceWith/ElementReplaceWith.generated.xml' path='docs/ElementReplaceWith/*'/>
[Value("replaceWith")]
	public Undefined ReplaceWith(params Union33[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementRemove/ElementRemove.generated.xml' path='docs/ElementRemove/*'/>
[Value("remove")]
	public Undefined Remove() { throw new System.NotImplementedException(); }
}




[Value("Slottable")]
public partial interface Slottable
{
	[Value("assignedSlot")]
	public HTMLSlotElement? AssignedSlot { get { throw new System.NotImplementedException(); } }
}



[Value("NodeFilter")]
public partial interface NodeFilter
{
	[Value("FILTER_ACCEPT")]
	public const ushort FILTER_ACCEPT = 1;
	[Value("FILTER_REJECT")]
	public const ushort FILTER_REJECT = 2;
	[Value("FILTER_SKIP")]
	public const ushort FILTER_SKIP = 3;
	[Value("SHOW_ALL")]
	public const ulong SHOW_ALL = 0xFFFFFFFF;
	[Value("SHOW_ELEMENT")]
	public const ulong SHOW_ELEMENT = 0x1;
	[Value("SHOW_ATTRIBUTE")]
	public const ulong SHOW_ATTRIBUTE = 0x2;
	[Value("SHOW_TEXT")]
	public const ulong SHOW_TEXT = 0x4;
	[Value("SHOW_CDATA_SECTION")]
	public const ulong SHOW_CDATA_SECTION = 0x8;
	[Value("SHOW_ENTITY_REFERENCE")]
	public const ulong SHOW_ENTITY_REFERENCE = 0x10;
	[Value("SHOW_ENTITY")]
	public const ulong SHOW_ENTITY = 0x20;
	[Value("SHOW_PROCESSING_INSTRUCTION")]
	public const ulong SHOW_PROCESSING_INSTRUCTION = 0x40;
	[Value("SHOW_COMMENT")]
	public const ulong SHOW_COMMENT = 0x80;
	[Value("SHOW_DOCUMENT")]
	public const ulong SHOW_DOCUMENT = 0x100;
	[Value("SHOW_DOCUMENT_TYPE")]
	public const ulong SHOW_DOCUMENT_TYPE = 0x200;
	[Value("SHOW_DOCUMENT_FRAGMENT")]
	public const ulong SHOW_DOCUMENT_FRAGMENT = 0x400;
	[Value("SHOW_NOTATION")]
	public const ulong SHOW_NOTATION = 0x800;
	[Value("acceptNode")]
	public ushort AcceptNode(Node node) { throw new System.NotImplementedException(); }
}

[Value("XPathNSResolver")]
public partial interface XPathNSResolver
{
	[Value("lookupNamespaceURI")]
	public DOMString? LookupNamespaceURI(DOMString? prefix) { throw new System.NotImplementedException(); }
}

[Value("XPathEvaluatorBase")]
public partial interface XPathEvaluatorBase
{
	[Value("createExpression")]
	public XPathExpression CreateExpression(DOMString expression, XPathNSResolver? resolver = default) { throw new System.NotImplementedException(); }
	[Value("createNSResolver")]
	public Node CreateNSResolver(Node nodeResolver) { throw new System.NotImplementedException(); }
	[Value("evaluate")]
	public XPathResult Evaluate(DOMString expression, Node contextNode, XPathNSResolver? resolver = default, ushort type = default, XPathResult? result = default) { throw new System.NotImplementedException(); }
}


[Value("TextDecoderCommon")]
public partial interface TextDecoderCommon
{
	[Value("encoding")]
	public DOMString Encoding { get { throw new System.NotImplementedException(); } }
	[Value("fatal")]
	public bool Fatal { get { throw new System.NotImplementedException(); } }
	[Value("ignoreBOM")]
	public bool IgnoreBOM { get { throw new System.NotImplementedException(); } }
}

[Value("TextEncoderCommon")]
public partial interface TextEncoderCommon
{
	[Value("encoding")]
	public DOMString Encoding { get { throw new System.NotImplementedException(); } }
}

public partial interface GlobalEventHandlers
{
	[Value("onfencedtreeclick")]
	public EventHandler Onfencedtreeclick { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}


[Value("Body")]
public partial interface Body
{
	[Value("body")]
	public ReadableStream? Body { get { throw new System.NotImplementedException(); } }
	[Value("bodyUsed")]
	public bool BodyUsed { get { throw new System.NotImplementedException(); } }
	[Value("arrayBuffer")]
	public Task<ArrayBuffer> ArrayBuffer() { throw new System.NotImplementedException(); }
	[Value("blob")]
	public Task<Blob> Blob() { throw new System.NotImplementedException(); }
	[Value("bytes")]
	public Task<Uint8Array> Bytes() { throw new System.NotImplementedException(); }
	[Value("formData")]
	public Task<FormData> FormData() { throw new System.NotImplementedException(); }
	[Value("json")]
	public Task<dynamic> Json() { throw new System.NotImplementedException(); }
	[Value("text")]
	public Task<USVString> Text() { throw new System.NotImplementedException(); }
}


[Value("WindowOrWorkerGlobalScope")]
public partial interface WindowOrWorkerGlobalScope
{
	[Value("fetch")]
	public Task<Response> Fetch(RequestInfo input, RequestInit init = default) { throw new System.NotImplementedException(); }
}

[Value("SVGFilterPrimitiveStandardAttributes")]
public partial interface SVGFilterPrimitiveStandardAttributes
{
	[Value("x")]
	public SVGAnimatedLength X { get { throw new System.NotImplementedException(); } }
	[Value("y")]
	public SVGAnimatedLength Y { get { throw new System.NotImplementedException(); } }
	[Value("width")]
	public SVGAnimatedLength Width { get { throw new System.NotImplementedException(); } }
	[Value("height")]
	public SVGAnimatedLength Height { get { throw new System.NotImplementedException(); } }
	[Value("result")]
	public SVGAnimatedString Result { get { throw new System.NotImplementedException(); } }
}

public partial interface DocumentOrShadowRoot
{
	[Value("fullscreenElement")]
	public Element? FullscreenElement { get { throw new System.NotImplementedException(); } }
}

[Value("WindowEventHandlers")]
public partial interface WindowEventHandlers
{
	[Value("ongamepadconnected")]
	public EventHandler Ongamepadconnected { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ongamepaddisconnected")]
	public EventHandler Ongamepaddisconnected { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[Value("GlobalPrivacyControl")]
public partial interface GlobalPrivacyControl
{
	[Value("globalPrivacyControl")]
	public bool GlobalPrivacyControl { get { throw new System.NotImplementedException(); } }
}



public partial interface WindowOrWorkerGlobalScope
{
	[Value("performance")]
	public Performance Performance { get { throw new System.NotImplementedException(); } }
}

public partial interface DocumentOrShadowRoot
{
	[Value("activeElement")]
	public Element? ActiveElement { get { throw new System.NotImplementedException(); } }
}

[Value("HTMLOrSVGElement")]
public partial interface HTMLOrSVGElement
{
	[Value("dataset")]
	public DOMStringMap Dataset { get { throw new System.NotImplementedException(); } }
	[Value("nonce")]
	public DOMString Nonce { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("autofocus")]
	public bool Autofocus { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("tabIndex")]
	public long TabIndex { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("focus")]
	public Undefined Focus(FocusOptions options = default) { throw new System.NotImplementedException(); }
	[Value("blur")]
	public Undefined Blur() { throw new System.NotImplementedException(); }
}

[Value("HTMLHyperlinkElementUtils")]
public partial interface HTMLHyperlinkElementUtils
{
	[Value("href")]
	public USVString Href { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("origin")]
	public USVString Origin { get { throw new System.NotImplementedException(); } }
	[Value("protocol")]
	public USVString Protocol { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("username")]
	public USVString Username { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("password")]
	public USVString Password { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("host")]
	public USVString Host { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("hostname")]
	public USVString Hostname { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("port")]
	public USVString Port { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("pathname")]
	public USVString Pathname { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("search")]
	public USVString Search { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("hash")]
	public USVString Hash { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[Value("CanvasState")]
public partial interface CanvasState
{
	[Value("save")]
	public Undefined Save() { throw new System.NotImplementedException(); }
	[Value("restore")]
	public Undefined Restore() { throw new System.NotImplementedException(); }
	[Value("reset")]
	public Undefined Reset() { throw new System.NotImplementedException(); }
	[Value("isContextLost")]
	public bool IsContextLost() { throw new System.NotImplementedException(); }
}

[Value("CanvasTransform")]
public partial interface CanvasTransform
{
	[Value("scale")]
	public Undefined Scale(double x, double y) { throw new System.NotImplementedException(); }
	[Value("rotate")]
	public Undefined Rotate(double angle) { throw new System.NotImplementedException(); }
	[Value("translate")]
	public Undefined Translate(double x, double y) { throw new System.NotImplementedException(); }
	[Value("transform")]
	public Undefined Transform(double a, double b, double c, double d, double e, double f) { throw new System.NotImplementedException(); }
	[Value("getTransform")]
	public DOMMatrix GetTransform() { throw new System.NotImplementedException(); }
	[Value("setTransform")]
	public Undefined SetTransform(double a, double b, double c, double d, double e, double f) { throw new System.NotImplementedException(); }
	[Value("setTransform")]
	public Undefined SetTransform(DOMMatrix2DInit transform = default) { throw new System.NotImplementedException(); }
	[Value("resetTransform")]
	public Undefined ResetTransform() { throw new System.NotImplementedException(); }
}

[Value("CanvasCompositing")]
public partial interface CanvasCompositing
{
	[Value("globalAlpha")]
	public double GlobalAlpha { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("globalCompositeOperation")]
	public DOMString GlobalCompositeOperation { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[Value("CanvasImageSmoothing")]
public partial interface CanvasImageSmoothing
{
	[Value("imageSmoothingEnabled")]
	public bool ImageSmoothingEnabled { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("imageSmoothingQuality")]
	public ImageSmoothingQuality ImageSmoothingQuality { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[Value("CanvasFillStrokeStyles")]
public partial interface CanvasFillStrokeStyles
{
	[Value("strokeStyle")]
	public Union73 StrokeStyle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("fillStyle")]
	public Union74 FillStyle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("createLinearGradient")]
	public CanvasGradient CreateLinearGradient(Number x0, Number y0, Number x1, Number y1) { throw new System.NotImplementedException(); }
	[Value("createRadialGradient")]
	public CanvasGradient CreateRadialGradient(Number x0, Number y0, Number r0, Number x1, Number y1, Number r1) { throw new System.NotImplementedException(); }
	[Value("createConicGradient")]
	public CanvasGradient CreateConicGradient(Number startAngle, Number x, Number y) { throw new System.NotImplementedException(); }
	[Value("createPattern")]
	public CanvasPattern? CreatePattern(CanvasImageSource image, DOMString repetition) { throw new System.NotImplementedException(); }
}

[Value("CanvasShadowStyles")]
public partial interface CanvasShadowStyles
{
	[Value("shadowOffsetX")]
	public double ShadowOffsetX { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("shadowOffsetY")]
	public double ShadowOffsetY { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("shadowBlur")]
	public double ShadowBlur { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("shadowColor")]
	public DOMString ShadowColor { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[Value("CanvasFilters")]
public partial interface CanvasFilters
{
	[Value("filter")]
	public DOMString Filter { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[Value("CanvasRect")]
public partial interface CanvasRect
{
	[Value("clearRect")]
	public Undefined ClearRect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
	[Value("fillRect")]
	public Undefined FillRect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
	[Value("strokeRect")]
	public Undefined StrokeRect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
}

[Value("CanvasDrawPath")]
public partial interface CanvasDrawPath
{
	[Value("beginPath")]
	public Undefined BeginPath() { throw new System.NotImplementedException(); }
	[Value("fill")]
	public Undefined Fill(CanvasFillRule fillRule = default) { throw new System.NotImplementedException(); }
	[Value("fill")]
	public Undefined Fill(Path2D path, CanvasFillRule fillRule = default) { throw new System.NotImplementedException(); }
	[Value("stroke")]
	public Undefined Stroke() { throw new System.NotImplementedException(); }
	[Value("stroke")]
	public Undefined Stroke(Path2D path) { throw new System.NotImplementedException(); }
	[Value("clip")]
	public Undefined Clip(CanvasFillRule fillRule = default) { throw new System.NotImplementedException(); }
	[Value("clip")]
	public Undefined Clip(Path2D path, CanvasFillRule fillRule = default) { throw new System.NotImplementedException(); }
	[Value("isPointInPath")]
	public bool IsPointInPath(double x, double y, CanvasFillRule fillRule = default) { throw new System.NotImplementedException(); }
	[Value("isPointInPath")]
	public bool IsPointInPath(Path2D path, double x, double y, CanvasFillRule fillRule = default) { throw new System.NotImplementedException(); }
	[Value("isPointInStroke")]
	public bool IsPointInStroke(double x, double y) { throw new System.NotImplementedException(); }
	[Value("isPointInStroke")]
	public bool IsPointInStroke(Path2D path, double x, double y) { throw new System.NotImplementedException(); }
}

[Value("CanvasUserInterface")]
public partial interface CanvasUserInterface
{
	[Value("drawFocusIfNeeded")]
	public Undefined DrawFocusIfNeeded(Element element) { throw new System.NotImplementedException(); }
	[Value("drawFocusIfNeeded")]
	public Undefined DrawFocusIfNeeded(Path2D path, Element element) { throw new System.NotImplementedException(); }
}

[Value("CanvasText")]
public partial interface CanvasText
{
	[Value("fillText")]
	public Undefined FillText(DOMString text, double x, double y, double maxWidth = default) { throw new System.NotImplementedException(); }
	[Value("strokeText")]
	public Undefined StrokeText(DOMString text, double x, double y, double maxWidth = default) { throw new System.NotImplementedException(); }
	[Value("measureText")]
	public TextMetrics MeasureText(DOMString text) { throw new System.NotImplementedException(); }
}

[Value("CanvasDrawImage")]
public partial interface CanvasDrawImage
{
	[Value("drawImage")]
	public Undefined DrawImage(CanvasImageSource image, double dx, double dy) { throw new System.NotImplementedException(); }
	[Value("drawImage")]
	public Undefined DrawImage(CanvasImageSource image, double dx, double dy, double dw, double dh) { throw new System.NotImplementedException(); }
	[Value("drawImage")]
	public Undefined DrawImage(CanvasImageSource image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh) { throw new System.NotImplementedException(); }
}

[Value("CanvasImageData")]
public partial interface CanvasImageData
{
	[Value("createImageData")]
	public ImageData CreateImageData(long sw, long sh, ImageDataSettings settings = default) { throw new System.NotImplementedException(); }
	[Value("createImageData")]
	public ImageData CreateImageData(ImageData imagedata) { throw new System.NotImplementedException(); }
	[Value("getImageData")]
	public ImageData GetImageData(long sx, long sy, long sw, long sh, ImageDataSettings settings = default) { throw new System.NotImplementedException(); }
	[Value("putImageData")]
	public Undefined PutImageData(ImageData imagedata, long dx, long dy) { throw new System.NotImplementedException(); }
	[Value("putImageData")]
	public Undefined PutImageData(ImageData imagedata, long dx, long dy, long dirtyX, long dirtyY, long dirtyWidth, long dirtyHeight) { throw new System.NotImplementedException(); }
}

[Value("CanvasPathDrawingStyles")]
public partial interface CanvasPathDrawingStyles
{
	[Value("lineWidth")]
	public double LineWidth { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("lineCap")]
	public CanvasLineCap LineCap { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("lineJoin")]
	public CanvasLineJoin LineJoin { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("miterLimit")]
	public double MiterLimit { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("setLineDash")]
	public Undefined SetLineDash(List<double> segments) { throw new System.NotImplementedException(); }
	[Value("getLineDash")]
	public List<double> GetLineDash() { throw new System.NotImplementedException(); }
	[Value("lineDashOffset")]
	public double LineDashOffset { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[Value("CanvasTextDrawingStyles")]
public partial interface CanvasTextDrawingStyles
{
	[Value("font")]
	public DOMString Font { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("textAlign")]
	public CanvasTextAlign TextAlign { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("textBaseline")]
	public CanvasTextBaseline TextBaseline { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("direction")]
	public CanvasDirection Direction { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("letterSpacing")]
	public DOMString LetterSpacing { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("fontKerning")]
	public CanvasFontKerning FontKerning { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("fontStretch")]
	public CanvasFontStretch FontStretch { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("fontVariantCaps")]
	public CanvasFontVariantCaps FontVariantCaps { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("textRendering")]
	public CanvasTextRendering TextRendering { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("wordSpacing")]
	public DOMString WordSpacing { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[Value("CanvasPath")]
public partial interface CanvasPath
{
	[Value("closePath")]
	public Undefined ClosePath() { throw new System.NotImplementedException(); }
	[Value("moveTo")]
	public Undefined MoveTo(double x, double y) { throw new System.NotImplementedException(); }
	[Value("lineTo")]
	public Undefined LineTo(double x, double y) { throw new System.NotImplementedException(); }
	[Value("quadraticCurveTo")]
	public Undefined QuadraticCurveTo(double cpx, double cpy, double x, double y) { throw new System.NotImplementedException(); }
	[Value("bezierCurveTo")]
	public Undefined BezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y) { throw new System.NotImplementedException(); }
	[Value("arcTo")]
	public Undefined ArcTo(double x1, double y1, double x2, double y2, double radius) { throw new System.NotImplementedException(); }
	[Value("rect")]
	public Undefined Rect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
	[Value("roundRect")]
	public Undefined RoundRect(double x, double y, double w, double h, Union75 radii = default) { throw new System.NotImplementedException(); }
	[Value("arc")]
	public Undefined Arc(double x, double y, double radius, double startAngle, double endAngle, bool counterclockwise = default) { throw new System.NotImplementedException(); }
	[Value("ellipse")]
	public Undefined Ellipse(double x, double y, double radiusX, double radiusY, double rotation, double startAngle, double endAngle, bool counterclockwise = default) { throw new System.NotImplementedException(); }
}

[Value("ElementContentEditable")]
public partial interface ElementContentEditable
{
	[Value("contentEditable")]
	public DOMString ContentEditable { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("enterKeyHint")]
	public DOMString EnterKeyHint { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("isContentEditable")]
	public bool IsContentEditable { get { throw new System.NotImplementedException(); } }
	[Value("inputMode")]
	public DOMString InputMode { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[Value("PopoverInvokerElement")]
public partial interface PopoverInvokerElement
{
	[Value("popoverTargetElement")]
	public Element? PopoverTargetElement { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("popoverTargetAction")]
	public DOMString PopoverTargetAction { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

public partial interface GlobalEventHandlers
{
	[Value("onabort")]
	public EventHandler Onabort { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onauxclick")]
	public EventHandler Onauxclick { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onbeforeinput")]
	public EventHandler Onbeforeinput { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onbeforematch")]
	public EventHandler Onbeforematch { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onbeforetoggle")]
	public EventHandler Onbeforetoggle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onblur")]
	public EventHandler Onblur { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("oncancel")]
	public EventHandler Oncancel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("oncanplay")]
	public EventHandler Oncanplay { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("oncanplaythrough")]
	public EventHandler Oncanplaythrough { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onchange")]
	public EventHandler Onchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onclick")]
	public EventHandler Onclick { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onclose")]
	public EventHandler Onclose { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("oncontextlost")]
	public EventHandler Oncontextlost { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("oncontextmenu")]
	public EventHandler Oncontextmenu { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("oncontextrestored")]
	public EventHandler Oncontextrestored { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("oncopy")]
	public EventHandler Oncopy { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("oncuechange")]
	public EventHandler Oncuechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("oncut")]
	public EventHandler Oncut { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ondblclick")]
	public EventHandler Ondblclick { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ondrag")]
	public EventHandler Ondrag { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ondragend")]
	public EventHandler Ondragend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ondragenter")]
	public EventHandler Ondragenter { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ondragleave")]
	public EventHandler Ondragleave { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ondragover")]
	public EventHandler Ondragover { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ondragstart")]
	public EventHandler Ondragstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ondrop")]
	public EventHandler Ondrop { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ondurationchange")]
	public EventHandler Ondurationchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onemptied")]
	public EventHandler Onemptied { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onended")]
	public EventHandler Onended { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onerror")]
	public OnErrorEventHandler Onerror { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onfocus")]
	public EventHandler Onfocus { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onformdata")]
	public EventHandler Onformdata { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("oninput")]
	public EventHandler Oninput { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("oninvalid")]
	public EventHandler Oninvalid { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onkeydown")]
	public EventHandler Onkeydown { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onkeypress")]
	public EventHandler Onkeypress { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onkeyup")]
	public EventHandler Onkeyup { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onload")]
	public EventHandler Onload { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onloadeddata")]
	public EventHandler Onloadeddata { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onloadedmetadata")]
	public EventHandler Onloadedmetadata { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onloadstart")]
	public EventHandler Onloadstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onmousedown")]
	public EventHandler Onmousedown { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onmouseenter")]
	public EventHandler Onmouseenter { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onmouseleave")]
	public EventHandler Onmouseleave { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onmousemove")]
	public EventHandler Onmousemove { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onmouseout")]
	public EventHandler Onmouseout { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onmouseover")]
	public EventHandler Onmouseover { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onmouseup")]
	public EventHandler Onmouseup { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onpaste")]
	public EventHandler Onpaste { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onpause")]
	public EventHandler Onpause { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onplay")]
	public EventHandler Onplay { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onplaying")]
	public EventHandler Onplaying { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onprogress")]
	public EventHandler Onprogress { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onratechange")]
	public EventHandler Onratechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onreset")]
	public EventHandler Onreset { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onresize")]
	public EventHandler Onresize { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onscroll")]
	public EventHandler Onscroll { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onscrollend")]
	public EventHandler Onscrollend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onsecuritypolicyviolation")]
	public EventHandler Onsecuritypolicyviolation { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onseeked")]
	public EventHandler Onseeked { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onseeking")]
	public EventHandler Onseeking { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onselect")]
	public EventHandler Onselect { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onslotchange")]
	public EventHandler Onslotchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onstalled")]
	public EventHandler Onstalled { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onsubmit")]
	public EventHandler Onsubmit { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onsuspend")]
	public EventHandler Onsuspend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ontimeupdate")]
	public EventHandler Ontimeupdate { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ontoggle")]
	public EventHandler Ontoggle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onvolumechange")]
	public EventHandler Onvolumechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onwaiting")]
	public EventHandler Onwaiting { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onwebkitanimationend")]
	public EventHandler Onwebkitanimationend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onwebkitanimationiteration")]
	public EventHandler Onwebkitanimationiteration { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onwebkitanimationstart")]
	public EventHandler Onwebkitanimationstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onwebkittransitionend")]
	public EventHandler Onwebkittransitionend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onwheel")]
	public EventHandler Onwheel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

public partial interface WindowEventHandlers
{
	[Value("onafterprint")]
	public EventHandler Onafterprint { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onbeforeprint")]
	public EventHandler Onbeforeprint { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onbeforeunload")]
	public OnBeforeUnloadEventHandler Onbeforeunload { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onhashchange")]
	public EventHandler Onhashchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onlanguagechange")]
	public EventHandler Onlanguagechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onmessage")]
	public EventHandler Onmessage { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onmessageerror")]
	public EventHandler Onmessageerror { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onoffline")]
	public EventHandler Onoffline { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ononline")]
	public EventHandler Ononline { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onpagehide")]
	public EventHandler Onpagehide { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onpagereveal")]
	public EventHandler Onpagereveal { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onpageshow")]
	public EventHandler Onpageshow { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onpageswap")]
	public EventHandler Onpageswap { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onpopstate")]
	public EventHandler Onpopstate { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onrejectionhandled")]
	public EventHandler Onrejectionhandled { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onstorage")]
	public EventHandler Onstorage { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onunhandledrejection")]
	public EventHandler Onunhandledrejection { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onunload")]
	public EventHandler Onunload { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}


public partial interface WindowOrWorkerGlobalScope
{
	[Value("origin")]
	public USVString Origin { get { throw new System.NotImplementedException(); } }
	[Value("isSecureContext")]
	public bool IsSecureContext { get { throw new System.NotImplementedException(); } }
	[Value("crossOriginIsolated")]
	public bool CrossOriginIsolated { get { throw new System.NotImplementedException(); } }
	[Value("reportError")]
	public Undefined ReportError(dynamic e) { throw new System.NotImplementedException(); }
	[Value("btoa")]
	public DOMString Btoa(DOMString data) { throw new System.NotImplementedException(); }
	[Value("atob")]
	public ByteString Atob(DOMString data) { throw new System.NotImplementedException(); }
	[Value("setTimeout")]
	public long SetTimeout(TimerHandler handler, long timeout = default, params dynamic[] arguments) { throw new System.NotImplementedException(); }
	[Value("clearTimeout")]
	public Undefined ClearTimeout(long id = default) { throw new System.NotImplementedException(); }
	[Value("setInterval")]
	public long SetInterval(TimerHandler handler, long timeout = default, params dynamic[] arguments) { throw new System.NotImplementedException(); }
	[Value("clearInterval")]
	public Undefined ClearInterval(long id = default) { throw new System.NotImplementedException(); }
	[Value("queueMicrotask")]
	public Undefined QueueMicrotask(VoidFunction callback) { throw new System.NotImplementedException(); }
	[Value("createImageBitmap")]
	public Task<ImageBitmap> CreateImageBitmap(ImageBitmapSource image, ImageBitmapOptions options = default) { throw new System.NotImplementedException(); }
	[Value("createImageBitmap")]
	public Task<ImageBitmap> CreateImageBitmap(ImageBitmapSource image, long sx, long sy, long sw, long sh, ImageBitmapOptions options = default) { throw new System.NotImplementedException(); }
	[Value("structuredClone")]
	public dynamic StructuredClone(dynamic value, StructuredSerializeOptions options = default) { throw new System.NotImplementedException(); }
}



[Value("NavigatorID")]
public partial interface NavigatorID
{
	[Value("appCodeName")]
	public DOMString AppCodeName { get { throw new System.NotImplementedException(); } }
	[Value("appName")]
	public DOMString AppName { get { throw new System.NotImplementedException(); } }
	[Value("appVersion")]
	public DOMString AppVersion { get { throw new System.NotImplementedException(); } }
	[Value("platform")]
	public DOMString Platform { get { throw new System.NotImplementedException(); } }
	[Value("product")]
	public DOMString Product { get { throw new System.NotImplementedException(); } }
	[Value("productSub")]
	public DOMString ProductSub { get { throw new System.NotImplementedException(); } }
	[Value("userAgent")]
	public DOMString UserAgent { get { throw new System.NotImplementedException(); } }
	[Value("vendor")]
	public DOMString Vendor { get { throw new System.NotImplementedException(); } }
	[Value("vendorSub")]
	public DOMString VendorSub { get { throw new System.NotImplementedException(); } }
}

public partial interface NavigatorID
{
	[Value("taintEnabled")]
	public bool TaintEnabled() { throw new System.NotImplementedException(); }
	[Value("oscpu")]
	public DOMString Oscpu { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NavigatorLanguage/NavigatorLanguage.generated.xml' path='docs/NavigatorLanguage/*'/>
[Value("NavigatorLanguage")]
public partial interface NavigatorLanguage
{
	[Value("language")]
	public DOMString Language { get { throw new System.NotImplementedException(); } }
	[Value("languages")]
	public DOMString[] Languages { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NavigatorOnLine/NavigatorOnLine.generated.xml' path='docs/NavigatorOnLine/*'/>
[Value("NavigatorOnLine")]
public partial interface NavigatorOnLine
{
	[Value("onLine")]
	public bool OnLine { get { throw new System.NotImplementedException(); } }
}

[Value("NavigatorContentUtils")]
public partial interface NavigatorContentUtils
{
	[Value("registerProtocolHandler")]
	public Undefined RegisterProtocolHandler(DOMString scheme, USVString url) { throw new System.NotImplementedException(); }
	[Value("unregisterProtocolHandler")]
	public Undefined UnregisterProtocolHandler(DOMString scheme, USVString url) { throw new System.NotImplementedException(); }
}

[Value("NavigatorCookies")]
public partial interface NavigatorCookies
{
	[Value("cookieEnabled")]
	public bool CookieEnabled { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NavigatorPlugins/NavigatorPlugins.generated.xml' path='docs/NavigatorPlugins/*'/>
[Value("NavigatorPlugins")]
public partial interface NavigatorPlugins
{
	[Value("plugins")]
	public PluginArray Plugins { get { throw new System.NotImplementedException(); } }
	[Value("mimeTypes")]
	public MimeTypeArray MimeTypes { get { throw new System.NotImplementedException(); } }
	[Value("javaEnabled")]
	public bool JavaEnabled() { throw new System.NotImplementedException(); }
	[Value("pdfViewerEnabled")]
	public bool PdfViewerEnabled { get { throw new System.NotImplementedException(); } }
}

[Value("AnimationFrameProvider")]
public partial interface AnimationFrameProvider
{
	[Value("requestAnimationFrame")]
	public ulong RequestAnimationFrame(FrameRequestCallback callback) { throw new System.NotImplementedException(); }
	[Value("cancelAnimationFrame")]
	public Undefined CancelAnimationFrame(ulong handle) { throw new System.NotImplementedException(); }
}



[Value("MessageEventTarget")]
public partial interface MessageEventTarget
{
	[Value("onmessage")]
	public EventHandler Onmessage { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onmessageerror")]
	public EventHandler Onmessageerror { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[Value("AbstractWorker")]
public partial interface AbstractWorker
{
	[Value("onerror")]
	public EventHandler Onerror { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[Value("NavigatorConcurrentHardware")]
public partial interface NavigatorConcurrentHardware
{
	[Value("hardwareConcurrency")]
	public ulong HardwareConcurrency { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/WindowSessionStorage/WindowSessionStorage.generated.xml' path='docs/WindowSessionStorage/*'/>
[Value("WindowSessionStorage")]
public partial interface WindowSessionStorage
{
	[Value("sessionStorage")]
	public Storage SessionStorage { get { throw new System.NotImplementedException(); } }
}


///<include file='Utils/Docs/WindowLocalStorage/WindowLocalStorage.generated.xml' path='docs/WindowLocalStorage/*'/>
[Value("WindowLocalStorage")]
public partial interface WindowLocalStorage
{
	[Value("localStorage")]
	public Storage LocalStorage { get { throw new System.NotImplementedException(); } }
}


public partial interface WindowOrWorkerGlobalScope
{
	[Value("indexedDB")]
	public IDBFactory IndexedDB { get { throw new System.NotImplementedException(); } }
}

[Value("NavigatorNetworkInformation")]
public partial interface NavigatorNetworkInformation
{
	[Value("connection")]
	public NetworkInformation Connection { get { throw new System.NotImplementedException(); } }
}



[Value("PaintTimingMixin")]
public partial interface PaintTimingMixin
{
	[Value("paintTime")]
	public DOMHighResTimeStamp PaintTime { get { throw new System.NotImplementedException(); } }
	[Value("presentationTime")]
	public DOMHighResTimeStamp? PresentationTime { get { throw new System.NotImplementedException(); } }
}

public partial interface DocumentOrShadowRoot
{
	[Value("pictureInPictureElement")]
	public Element? PictureInPictureElement { get { throw new System.NotImplementedException(); } }
}

public partial interface GlobalEventHandlers
{
	[Value("onpointerover")]
	public EventHandler Onpointerover { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onpointerenter")]
	public EventHandler Onpointerenter { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onpointerdown")]
	public EventHandler Onpointerdown { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onpointermove")]
	public EventHandler Onpointermove { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onpointerrawupdate")]
	public EventHandler Onpointerrawupdate { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onpointerup")]
	public EventHandler Onpointerup { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onpointercancel")]
	public EventHandler Onpointercancel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onpointerout")]
	public EventHandler Onpointerout { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onpointerleave")]
	public EventHandler Onpointerleave { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ongotpointercapture")]
	public EventHandler Ongotpointercapture { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onlostpointercapture")]
	public EventHandler Onlostpointercapture { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

public partial interface DocumentOrShadowRoot
{
	[Value("pointerLockElement")]
	public Element? PointerLockElement { get { throw new System.NotImplementedException(); } }
}

public partial interface WindowEventHandlers
{
	[Value("onportalactivate")]
	public EventHandler Onportalactivate { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NetworkInformationSaveData/NetworkInformationSaveData.generated.xml' path='docs/NetworkInformationSaveData/*'/>
[Value("NetworkInformationSaveData")]
public partial interface NetworkInformationSaveData
{
	[Value("saveData")]
	public bool SaveData { get { throw new System.NotImplementedException(); } }
}


public partial interface WindowOrWorkerGlobalScope
{
	[Value("scheduler")]
	public Scheduler Scheduler { get { throw new System.NotImplementedException(); } }
}

public partial interface GlobalEventHandlers
{
	[Value("onselectstart")]
	public EventHandler Onselectstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onselectionchange")]
	public EventHandler Onselectionchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

public partial interface WindowOrWorkerGlobalScope
{
	[Value("caches")]
	public CacheStorage Caches { get { throw new System.NotImplementedException(); } }
}

[Value("HTMLSharedStorageWritableElementUtils")]
public partial interface HTMLSharedStorageWritableElementUtils
{
	[Value("sharedStorageWritable")]
	public bool SharedStorageWritable { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}



[Value("NavigatorStorageBuckets")]
public partial interface NavigatorStorageBuckets
{
	[Value("storageBuckets")]
	public StorageBucketManager StorageBuckets { get { throw new System.NotImplementedException(); } }
}



///<include file='Utils/Docs/NavigatorStorage/NavigatorStorage.generated.xml' path='docs/NavigatorStorage/*'/>
[Value("NavigatorStorage")]
public partial interface NavigatorStorage
{
	[Value("storage")]
	public StorageManager Storage { get { throw new System.NotImplementedException(); } }
}



[Value("ReadableStreamGenericReader")]
public partial interface ReadableStreamGenericReader
{
	[Value("closed")]
	public Task<Undefined> Closed { get { throw new System.NotImplementedException(); } }
	[Value("cancel")]
	public Task<Undefined> Cancel(dynamic reason = default) { throw new System.NotImplementedException(); }
}

[Value("GenericTransformStream")]
public partial interface GenericTransformStream
{
	[Value("readable")]
	public ReadableStream Readable { get { throw new System.NotImplementedException(); } }
	[Value("writable")]
	public WritableStream Writable { get { throw new System.NotImplementedException(); } }
}

[Value("SVGTests")]
public partial interface SVGTests
{
	[Value("requiredExtensions")]
	public SVGStringList RequiredExtensions { get { throw new System.NotImplementedException(); } }
	[Value("systemLanguage")]
	public SVGStringList SystemLanguage { get { throw new System.NotImplementedException(); } }
}

[Value("SVGFitToViewBox")]
public partial interface SVGFitToViewBox
{
	[Value("viewBox")]
	public SVGAnimatedRect ViewBox { get { throw new System.NotImplementedException(); } }
	[Value("preserveAspectRatio")]
	public SVGAnimatedPreserveAspectRatio PreserveAspectRatio { get { throw new System.NotImplementedException(); } }
}

[Value("SVGURIReference")]
public partial interface SVGURIReference
{
	[Value("href")]
	public SVGAnimatedString Href { get { throw new System.NotImplementedException(); } }
}

[Value("SVGElementInstance")]
public partial interface SVGElementInstance
{
	[Value("correspondingElement")]
	public SVGElement? CorrespondingElement { get { throw new System.NotImplementedException(); } }
	[Value("correspondingUseElement")]
	public SVGUseElement? CorrespondingUseElement { get { throw new System.NotImplementedException(); } }
}

[Value("GetSVGDocument")]
public partial interface GetSVGDocument
{
	[Value("getSVGDocument")]
	public Document GetSVGDocument() { throw new System.NotImplementedException(); }
}

[Value("SVGAnimatedPoints")]
public partial interface SVGAnimatedPoints
{
	[Value("points")]
	public SVGPointList Points { get { throw new System.NotImplementedException(); } }
	[Value("animatedPoints")]
	public SVGPointList AnimatedPoints { get { throw new System.NotImplementedException(); } }
}

public partial interface GlobalEventHandlers
{
	[Value("ontouchstart")]
	public EventHandler Ontouchstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ontouchend")]
	public EventHandler Ontouchend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ontouchmove")]
	public EventHandler Ontouchmove { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ontouchcancel")]
	public EventHandler Ontouchcancel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

public partial interface WindowOrWorkerGlobalScope
{
	[Value("trustedTypes")]
	public TrustedTypePolicyFactory TrustedTypes { get { throw new System.NotImplementedException(); } }
}

[Value("NavigatorUA")]
public partial interface NavigatorUA
{
	[Value("userAgentData")]
	public NavigatorUAData UserAgentData { get { throw new System.NotImplementedException(); } }
}



public partial interface ElementContentEditable
{
	[Value("virtualKeyboardPolicy")]
	public DOMString VirtualKeyboardPolicy { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[Value("ARIAMixin")]
public partial interface ARIAMixin
{
	[Value("role")]
	public DOMString? Role { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaActiveDescendantElement")]
	public Element? AriaActiveDescendantElement { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaAtomic")]
	public DOMString? AriaAtomic { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaAutoComplete")]
	public DOMString? AriaAutoComplete { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaBrailleLabel")]
	public DOMString? AriaBrailleLabel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaBrailleRoleDescription")]
	public DOMString? AriaBrailleRoleDescription { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaBusy")]
	public DOMString? AriaBusy { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaChecked")]
	public DOMString? AriaChecked { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaColCount")]
	public DOMString? AriaColCount { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaColIndex")]
	public DOMString? AriaColIndex { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaColIndexText")]
	public DOMString? AriaColIndexText { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaColSpan")]
	public DOMString? AriaColSpan { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaControlsElements")]
	public Element[]? AriaControlsElements { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaCurrent")]
	public DOMString? AriaCurrent { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaDescribedByElements")]
	public Element[]? AriaDescribedByElements { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaDescription")]
	public DOMString? AriaDescription { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaDetailsElements")]
	public Element[]? AriaDetailsElements { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaDisabled")]
	public DOMString? AriaDisabled { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaErrorMessageElements")]
	public Element[]? AriaErrorMessageElements { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaExpanded")]
	public DOMString? AriaExpanded { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaFlowToElements")]
	public Element[]? AriaFlowToElements { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaHasPopup")]
	public DOMString? AriaHasPopup { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaHidden")]
	public DOMString? AriaHidden { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaInvalid")]
	public DOMString? AriaInvalid { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaKeyShortcuts")]
	public DOMString? AriaKeyShortcuts { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaLabel")]
	public DOMString? AriaLabel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaLabelledByElements")]
	public Element[]? AriaLabelledByElements { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaLevel")]
	public DOMString? AriaLevel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaLive")]
	public DOMString? AriaLive { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaModal")]
	public DOMString? AriaModal { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaMultiLine")]
	public DOMString? AriaMultiLine { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaMultiSelectable")]
	public DOMString? AriaMultiSelectable { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaOrientation")]
	public DOMString? AriaOrientation { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaOwnsElements")]
	public Element[]? AriaOwnsElements { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaPlaceholder")]
	public DOMString? AriaPlaceholder { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaPosInSet")]
	public DOMString? AriaPosInSet { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaPressed")]
	public DOMString? AriaPressed { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaReadOnly")]
	public DOMString? AriaReadOnly { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaRelevant")]
	public DOMString? AriaRelevant { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaRequired")]
	public DOMString? AriaRequired { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaRoleDescription")]
	public DOMString? AriaRoleDescription { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaRowCount")]
	public DOMString? AriaRowCount { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaRowIndex")]
	public DOMString? AriaRowIndex { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaRowIndexText")]
	public DOMString? AriaRowIndexText { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaRowSpan")]
	public DOMString? AriaRowSpan { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaSelected")]
	public DOMString? AriaSelected { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaSetSize")]
	public DOMString? AriaSetSize { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaSort")]
	public DOMString? AriaSort { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaValueMax")]
	public DOMString? AriaValueMax { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaValueMin")]
	public DOMString? AriaValueMin { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaValueNow")]
	public DOMString? AriaValueNow { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ariaValueText")]
	public DOMString? AriaValueText { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}


[Value("Animatable")]
public partial interface Animatable
{
	[Value("animate")]
	public Animation Animate(Object? keyframes, Union171 options = default) { throw new System.NotImplementedException(); }
	[Value("getAnimations")]
	public List<Animation> GetAnimations(GetAnimationsOptions options = default) { throw new System.NotImplementedException(); }
}

public partial interface DocumentOrShadowRoot
{
	[Value("getAnimations")]
	public List<Animation> GetAnimations() { throw new System.NotImplementedException(); }
}


[Value("CharacteristicEventHandlers")]
public partial interface CharacteristicEventHandlers
{
	[Value("oncharacteristicvaluechanged")]
	public EventHandler Oncharacteristicvaluechanged { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[Value("BluetoothDeviceEventHandlers")]
public partial interface BluetoothDeviceEventHandlers
{
	[Value("onadvertisementreceived")]
	public EventHandler Onadvertisementreceived { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("ongattserverdisconnected")]
	public EventHandler Ongattserverdisconnected { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[Value("ServiceEventHandlers")]
public partial interface ServiceEventHandlers
{
	[Value("onserviceadded")]
	public EventHandler Onserviceadded { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onservicechanged")]
	public EventHandler Onservicechanged { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("onserviceremoved")]
	public EventHandler Onserviceremoved { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}


///<include file='Utils/Docs/NavigatorLocks/NavigatorLocks.generated.xml' path='docs/NavigatorLocks/*'/>
[Value("NavigatorLocks")]
public partial interface NavigatorLocks
{
	[Value("locks")]
	public LockManager Locks { get { throw new System.NotImplementedException(); } }
}



public partial interface WindowOrWorkerGlobalScope
{
	[Value("crypto")]
	public Crypto Crypto { get { throw new System.NotImplementedException(); } }
}

[Value("NavigatorAutomationInformation")]
public partial interface NavigatorAutomationInformation
{
	[Value("webdriver")]
	public bool Webdriver { get { throw new System.NotImplementedException(); } }
}
















[Value("WebGLRenderingContextBase")]
public partial interface WebGLRenderingContextBase
{
	[Value("DEPTH_BUFFER_BIT")]
	public const GLenum DEPTH_BUFFER_BIT = 0x00000100;
	[Value("STENCIL_BUFFER_BIT")]
	public const GLenum STENCIL_BUFFER_BIT = 0x00000400;
	[Value("COLOR_BUFFER_BIT")]
	public const GLenum COLOR_BUFFER_BIT = 0x00004000;
	[Value("POINTS")]
	public const GLenum POINTS = 0x0000;
	[Value("LINES")]
	public const GLenum LINES = 0x0001;
	[Value("LINE_LOOP")]
	public const GLenum LINE_LOOP = 0x0002;
	[Value("LINE_STRIP")]
	public const GLenum LINE_STRIP = 0x0003;
	[Value("TRIANGLES")]
	public const GLenum TRIANGLES = 0x0004;
	[Value("TRIANGLE_STRIP")]
	public const GLenum TRIANGLE_STRIP = 0x0005;
	[Value("TRIANGLE_FAN")]
	public const GLenum TRIANGLE_FAN = 0x0006;
	[Value("ZERO")]
	public const GLenum ZERO = 0;
	[Value("ONE")]
	public const GLenum ONE = 1;
	[Value("SRC_COLOR")]
	public const GLenum SRC_COLOR = 0x0300;
	[Value("ONE_MINUS_SRC_COLOR")]
	public const GLenum ONE_MINUS_SRC_COLOR = 0x0301;
	[Value("SRC_ALPHA")]
	public const GLenum SRC_ALPHA = 0x0302;
	[Value("ONE_MINUS_SRC_ALPHA")]
	public const GLenum ONE_MINUS_SRC_ALPHA = 0x0303;
	[Value("DST_ALPHA")]
	public const GLenum DST_ALPHA = 0x0304;
	[Value("ONE_MINUS_DST_ALPHA")]
	public const GLenum ONE_MINUS_DST_ALPHA = 0x0305;
	[Value("DST_COLOR")]
	public const GLenum DST_COLOR = 0x0306;
	[Value("ONE_MINUS_DST_COLOR")]
	public const GLenum ONE_MINUS_DST_COLOR = 0x0307;
	[Value("SRC_ALPHA_SATURATE")]
	public const GLenum SRC_ALPHA_SATURATE = 0x0308;
	[Value("FUNC_ADD")]
	public const GLenum FUNC_ADD = 0x8006;
	[Value("BLEND_EQUATION")]
	public const GLenum BLEND_EQUATION = 0x8009;
	[Value("BLEND_EQUATION_RGB")]
	public const GLenum BLEND_EQUATION_RGB = 0x8009;
	[Value("BLEND_EQUATION_ALPHA")]
	public const GLenum BLEND_EQUATION_ALPHA = 0x883D;
	[Value("FUNC_SUBTRACT")]
	public const GLenum FUNC_SUBTRACT = 0x800A;
	[Value("FUNC_REVERSE_SUBTRACT")]
	public const GLenum FUNC_REVERSE_SUBTRACT = 0x800B;
	[Value("BLEND_DST_RGB")]
	public const GLenum BLEND_DST_RGB = 0x80C8;
	[Value("BLEND_SRC_RGB")]
	public const GLenum BLEND_SRC_RGB = 0x80C9;
	[Value("BLEND_DST_ALPHA")]
	public const GLenum BLEND_DST_ALPHA = 0x80CA;
	[Value("BLEND_SRC_ALPHA")]
	public const GLenum BLEND_SRC_ALPHA = 0x80CB;
	[Value("CONSTANT_COLOR")]
	public const GLenum CONSTANT_COLOR = 0x8001;
	[Value("ONE_MINUS_CONSTANT_COLOR")]
	public const GLenum ONE_MINUS_CONSTANT_COLOR = 0x8002;
	[Value("CONSTANT_ALPHA")]
	public const GLenum CONSTANT_ALPHA = 0x8003;
	[Value("ONE_MINUS_CONSTANT_ALPHA")]
	public const GLenum ONE_MINUS_CONSTANT_ALPHA = 0x8004;
	[Value("BLEND_COLOR")]
	public const GLenum BLEND_COLOR = 0x8005;
	[Value("ARRAY_BUFFER")]
	public const GLenum ARRAY_BUFFER = 0x8892;
	[Value("ELEMENT_ARRAY_BUFFER")]
	public const GLenum ELEMENT_ARRAY_BUFFER = 0x8893;
	[Value("ARRAY_BUFFER_BINDING")]
	public const GLenum ARRAY_BUFFER_BINDING = 0x8894;
	[Value("ELEMENT_ARRAY_BUFFER_BINDING")]
	public const GLenum ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
	[Value("STREAM_DRAW")]
	public const GLenum STREAM_DRAW = 0x88E0;
	[Value("STATIC_DRAW")]
	public const GLenum STATIC_DRAW = 0x88E4;
	[Value("DYNAMIC_DRAW")]
	public const GLenum DYNAMIC_DRAW = 0x88E8;
	[Value("BUFFER_SIZE")]
	public const GLenum BUFFER_SIZE = 0x8764;
	[Value("BUFFER_USAGE")]
	public const GLenum BUFFER_USAGE = 0x8765;
	[Value("CURRENT_VERTEX_ATTRIB")]
	public const GLenum CURRENT_VERTEX_ATTRIB = 0x8626;
	[Value("FRONT")]
	public const GLenum FRONT = 0x0404;
	[Value("BACK")]
	public const GLenum BACK = 0x0405;
	[Value("FRONT_AND_BACK")]
	public const GLenum FRONT_AND_BACK = 0x0408;
	[Value("CULL_FACE")]
	public const GLenum CULL_FACE = 0x0B44;
	[Value("BLEND")]
	public const GLenum BLEND = 0x0BE2;
	[Value("DITHER")]
	public const GLenum DITHER = 0x0BD0;
	[Value("STENCIL_TEST")]
	public const GLenum STENCIL_TEST = 0x0B90;
	[Value("DEPTH_TEST")]
	public const GLenum DEPTH_TEST = 0x0B71;
	[Value("SCISSOR_TEST")]
	public const GLenum SCISSOR_TEST = 0x0C11;
	[Value("POLYGON_OFFSET_FILL")]
	public const GLenum POLYGON_OFFSET_FILL = 0x8037;
	[Value("SAMPLE_ALPHA_TO_COVERAGE")]
	public const GLenum SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
	[Value("SAMPLE_COVERAGE")]
	public const GLenum SAMPLE_COVERAGE = 0x80A0;
	[Value("NO_ERROR")]
	public const GLenum NO_ERROR = 0;
	[Value("INVALID_ENUM")]
	public const GLenum INVALID_ENUM = 0x0500;
	[Value("INVALID_VALUE")]
	public const GLenum INVALID_VALUE = 0x0501;
	[Value("INVALID_OPERATION")]
	public const GLenum INVALID_OPERATION = 0x0502;
	[Value("OUT_OF_MEMORY")]
	public const GLenum OUT_OF_MEMORY = 0x0505;
	[Value("CW")]
	public const GLenum CW = 0x0900;
	[Value("CCW")]
	public const GLenum CCW = 0x0901;
	[Value("LINE_WIDTH")]
	public const GLenum LINE_WIDTH = 0x0B21;
	[Value("ALIASED_POINT_SIZE_RANGE")]
	public const GLenum ALIASED_POINT_SIZE_RANGE = 0x846D;
	[Value("ALIASED_LINE_WIDTH_RANGE")]
	public const GLenum ALIASED_LINE_WIDTH_RANGE = 0x846E;
	[Value("CULL_FACE_MODE")]
	public const GLenum CULL_FACE_MODE = 0x0B45;
	[Value("FRONT_FACE")]
	public const GLenum FRONT_FACE = 0x0B46;
	[Value("DEPTH_RANGE")]
	public const GLenum DEPTH_RANGE = 0x0B70;
	[Value("DEPTH_WRITEMASK")]
	public const GLenum DEPTH_WRITEMASK = 0x0B72;
	[Value("DEPTH_CLEAR_VALUE")]
	public const GLenum DEPTH_CLEAR_VALUE = 0x0B73;
	[Value("DEPTH_FUNC")]
	public const GLenum DEPTH_FUNC = 0x0B74;
	[Value("STENCIL_CLEAR_VALUE")]
	public const GLenum STENCIL_CLEAR_VALUE = 0x0B91;
	[Value("STENCIL_FUNC")]
	public const GLenum STENCIL_FUNC = 0x0B92;
	[Value("STENCIL_FAIL")]
	public const GLenum STENCIL_FAIL = 0x0B94;
	[Value("STENCIL_PASS_DEPTH_FAIL")]
	public const GLenum STENCIL_PASS_DEPTH_FAIL = 0x0B95;
	[Value("STENCIL_PASS_DEPTH_PASS")]
	public const GLenum STENCIL_PASS_DEPTH_PASS = 0x0B96;
	[Value("STENCIL_REF")]
	public const GLenum STENCIL_REF = 0x0B97;
	[Value("STENCIL_VALUE_MASK")]
	public const GLenum STENCIL_VALUE_MASK = 0x0B93;
	[Value("STENCIL_WRITEMASK")]
	public const GLenum STENCIL_WRITEMASK = 0x0B98;
	[Value("STENCIL_BACK_FUNC")]
	public const GLenum STENCIL_BACK_FUNC = 0x8800;
	[Value("STENCIL_BACK_FAIL")]
	public const GLenum STENCIL_BACK_FAIL = 0x8801;
	[Value("STENCIL_BACK_PASS_DEPTH_FAIL")]
	public const GLenum STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
	[Value("STENCIL_BACK_PASS_DEPTH_PASS")]
	public const GLenum STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
	[Value("STENCIL_BACK_REF")]
	public const GLenum STENCIL_BACK_REF = 0x8CA3;
	[Value("STENCIL_BACK_VALUE_MASK")]
	public const GLenum STENCIL_BACK_VALUE_MASK = 0x8CA4;
	[Value("STENCIL_BACK_WRITEMASK")]
	public const GLenum STENCIL_BACK_WRITEMASK = 0x8CA5;
	[Value("VIEWPORT")]
	public const GLenum VIEWPORT = 0x0BA2;
	[Value("SCISSOR_BOX")]
	public const GLenum SCISSOR_BOX = 0x0C10;
	[Value("COLOR_CLEAR_VALUE")]
	public const GLenum COLOR_CLEAR_VALUE = 0x0C22;
	[Value("COLOR_WRITEMASK")]
	public const GLenum COLOR_WRITEMASK = 0x0C23;
	[Value("UNPACK_ALIGNMENT")]
	public const GLenum UNPACK_ALIGNMENT = 0x0CF5;
	[Value("PACK_ALIGNMENT")]
	public const GLenum PACK_ALIGNMENT = 0x0D05;
	[Value("MAX_TEXTURE_SIZE")]
	public const GLenum MAX_TEXTURE_SIZE = 0x0D33;
	[Value("MAX_VIEWPORT_DIMS")]
	public const GLenum MAX_VIEWPORT_DIMS = 0x0D3A;
	[Value("SUBPIXEL_BITS")]
	public const GLenum SUBPIXEL_BITS = 0x0D50;
	[Value("RED_BITS")]
	public const GLenum RED_BITS = 0x0D52;
	[Value("GREEN_BITS")]
	public const GLenum GREEN_BITS = 0x0D53;
	[Value("BLUE_BITS")]
	public const GLenum BLUE_BITS = 0x0D54;
	[Value("ALPHA_BITS")]
	public const GLenum ALPHA_BITS = 0x0D55;
	[Value("DEPTH_BITS")]
	public const GLenum DEPTH_BITS = 0x0D56;
	[Value("STENCIL_BITS")]
	public const GLenum STENCIL_BITS = 0x0D57;
	[Value("POLYGON_OFFSET_UNITS")]
	public const GLenum POLYGON_OFFSET_UNITS = 0x2A00;
	[Value("POLYGON_OFFSET_FACTOR")]
	public const GLenum POLYGON_OFFSET_FACTOR = 0x8038;
	[Value("TEXTURE_BINDING_2D")]
	public const GLenum TEXTURE_BINDING_2D = 0x8069;
	[Value("SAMPLE_BUFFERS")]
	public const GLenum SAMPLE_BUFFERS = 0x80A8;
	[Value("SAMPLES")]
	public const GLenum SAMPLES = 0x80A9;
	[Value("SAMPLE_COVERAGE_VALUE")]
	public const GLenum SAMPLE_COVERAGE_VALUE = 0x80AA;
	[Value("SAMPLE_COVERAGE_INVERT")]
	public const GLenum SAMPLE_COVERAGE_INVERT = 0x80AB;
	[Value("COMPRESSED_TEXTURE_FORMATS")]
	public const GLenum COMPRESSED_TEXTURE_FORMATS = 0x86A3;
	[Value("DONT_CARE")]
	public const GLenum DONT_CARE = 0x1100;
	[Value("FASTEST")]
	public const GLenum FASTEST = 0x1101;
	[Value("NICEST")]
	public const GLenum NICEST = 0x1102;
	[Value("GENERATE_MIPMAP_HINT")]
	public const GLenum GENERATE_MIPMAP_HINT = 0x8192;
	[Value("BYTE")]
	public const GLenum BYTE = 0x1400;
	[Value("UNSIGNED_BYTE")]
	public const GLenum UNSIGNED_BYTE = 0x1401;
	[Value("SHORT")]
	public const GLenum SHORT = 0x1402;
	[Value("UNSIGNED_SHORT")]
	public const GLenum UNSIGNED_SHORT = 0x1403;
	[Value("INT")]
	public const GLenum INT = 0x1404;
	[Value("UNSIGNED_INT")]
	public const GLenum UNSIGNED_INT = 0x1405;
	[Value("FLOAT")]
	public const GLenum FLOAT = 0x1406;
	[Value("DEPTH_COMPONENT")]
	public const GLenum DEPTH_COMPONENT = 0x1902;
	[Value("ALPHA")]
	public const GLenum ALPHA = 0x1906;
	[Value("RGB")]
	public const GLenum RGB = 0x1907;
	[Value("RGBA")]
	public const GLenum RGBA = 0x1908;
	[Value("LUMINANCE")]
	public const GLenum LUMINANCE = 0x1909;
	[Value("LUMINANCE_ALPHA")]
	public const GLenum LUMINANCE_ALPHA = 0x190A;
	[Value("UNSIGNED_SHORT_4_4_4_4")]
	public const GLenum UNSIGNED_SHORT_4_4_4_4 = 0x8033;
	[Value("UNSIGNED_SHORT_5_5_5_1")]
	public const GLenum UNSIGNED_SHORT_5_5_5_1 = 0x8034;
	[Value("UNSIGNED_SHORT_5_6_5")]
	public const GLenum UNSIGNED_SHORT_5_6_5 = 0x8363;
	[Value("FRAGMENT_SHADER")]
	public const GLenum FRAGMENT_SHADER = 0x8B30;
	[Value("VERTEX_SHADER")]
	public const GLenum VERTEX_SHADER = 0x8B31;
	[Value("MAX_VERTEX_ATTRIBS")]
	public const GLenum MAX_VERTEX_ATTRIBS = 0x8869;
	[Value("MAX_VERTEX_UNIFORM_VECTORS")]
	public const GLenum MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
	[Value("MAX_VARYING_VECTORS")]
	public const GLenum MAX_VARYING_VECTORS = 0x8DFC;
	[Value("MAX_COMBINED_TEXTURE_IMAGE_UNITS")]
	public const GLenum MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
	[Value("MAX_VERTEX_TEXTURE_IMAGE_UNITS")]
	public const GLenum MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
	[Value("MAX_TEXTURE_IMAGE_UNITS")]
	public const GLenum MAX_TEXTURE_IMAGE_UNITS = 0x8872;
	[Value("MAX_FRAGMENT_UNIFORM_VECTORS")]
	public const GLenum MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
	[Value("SHADER_TYPE")]
	public const GLenum SHADER_TYPE = 0x8B4F;
	[Value("DELETE_STATUS")]
	public const GLenum DELETE_STATUS = 0x8B80;
	[Value("LINK_STATUS")]
	public const GLenum LINK_STATUS = 0x8B82;
	[Value("VALIDATE_STATUS")]
	public const GLenum VALIDATE_STATUS = 0x8B83;
	[Value("ATTACHED_SHADERS")]
	public const GLenum ATTACHED_SHADERS = 0x8B85;
	[Value("ACTIVE_UNIFORMS")]
	public const GLenum ACTIVE_UNIFORMS = 0x8B86;
	[Value("ACTIVE_ATTRIBUTES")]
	public const GLenum ACTIVE_ATTRIBUTES = 0x8B89;
	[Value("SHADING_LANGUAGE_VERSION")]
	public const GLenum SHADING_LANGUAGE_VERSION = 0x8B8C;
	[Value("CURRENT_PROGRAM")]
	public const GLenum CURRENT_PROGRAM = 0x8B8D;
	[Value("NEVER")]
	public const GLenum NEVER = 0x0200;
	[Value("LESS")]
	public const GLenum LESS = 0x0201;
	[Value("EQUAL")]
	public const GLenum EQUAL = 0x0202;
	[Value("LEQUAL")]
	public const GLenum LEQUAL = 0x0203;
	[Value("GREATER")]
	public const GLenum GREATER = 0x0204;
	[Value("NOTEQUAL")]
	public const GLenum NOTEQUAL = 0x0205;
	[Value("GEQUAL")]
	public const GLenum GEQUAL = 0x0206;
	[Value("ALWAYS")]
	public const GLenum ALWAYS = 0x0207;
	[Value("KEEP")]
	public const GLenum KEEP = 0x1E00;
	[Value("REPLACE")]
	public const GLenum REPLACE = 0x1E01;
	[Value("INCR")]
	public const GLenum INCR = 0x1E02;
	[Value("DECR")]
	public const GLenum DECR = 0x1E03;
	[Value("INVERT")]
	public const GLenum INVERT = 0x150A;
	[Value("INCR_WRAP")]
	public const GLenum INCR_WRAP = 0x8507;
	[Value("DECR_WRAP")]
	public const GLenum DECR_WRAP = 0x8508;
	[Value("VENDOR")]
	public const GLenum VENDOR = 0x1F00;
	[Value("RENDERER")]
	public const GLenum RENDERER = 0x1F01;
	[Value("VERSION")]
	public const GLenum VERSION = 0x1F02;
	[Value("NEAREST")]
	public const GLenum NEAREST = 0x2600;
	[Value("LINEAR")]
	public const GLenum LINEAR = 0x2601;
	[Value("NEAREST_MIPMAP_NEAREST")]
	public const GLenum NEAREST_MIPMAP_NEAREST = 0x2700;
	[Value("LINEAR_MIPMAP_NEAREST")]
	public const GLenum LINEAR_MIPMAP_NEAREST = 0x2701;
	[Value("NEAREST_MIPMAP_LINEAR")]
	public const GLenum NEAREST_MIPMAP_LINEAR = 0x2702;
	[Value("LINEAR_MIPMAP_LINEAR")]
	public const GLenum LINEAR_MIPMAP_LINEAR = 0x2703;
	[Value("TEXTURE_MAG_FILTER")]
	public const GLenum TEXTURE_MAG_FILTER = 0x2800;
	[Value("TEXTURE_MIN_FILTER")]
	public const GLenum TEXTURE_MIN_FILTER = 0x2801;
	[Value("TEXTURE_WRAP_S")]
	public const GLenum TEXTURE_WRAP_S = 0x2802;
	[Value("TEXTURE_WRAP_T")]
	public const GLenum TEXTURE_WRAP_T = 0x2803;
	[Value("TEXTURE_2D")]
	public const GLenum TEXTURE_2D = 0x0DE1;
	[Value("TEXTURE")]
	public const GLenum TEXTURE = 0x1702;
	[Value("TEXTURE_CUBE_MAP")]
	public const GLenum TEXTURE_CUBE_MAP = 0x8513;
	[Value("TEXTURE_BINDING_CUBE_MAP")]
	public const GLenum TEXTURE_BINDING_CUBE_MAP = 0x8514;
	[Value("TEXTURE_CUBE_MAP_POSITIVE_X")]
	public const GLenum TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
	[Value("TEXTURE_CUBE_MAP_NEGATIVE_X")]
	public const GLenum TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
	[Value("TEXTURE_CUBE_MAP_POSITIVE_Y")]
	public const GLenum TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
	[Value("TEXTURE_CUBE_MAP_NEGATIVE_Y")]
	public const GLenum TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
	[Value("TEXTURE_CUBE_MAP_POSITIVE_Z")]
	public const GLenum TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
	[Value("TEXTURE_CUBE_MAP_NEGATIVE_Z")]
	public const GLenum TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
	[Value("MAX_CUBE_MAP_TEXTURE_SIZE")]
	public const GLenum MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
	[Value("TEXTURE0")]
	public const GLenum TEXTURE0 = 0x84C0;
	[Value("TEXTURE1")]
	public const GLenum TEXTURE1 = 0x84C1;
	[Value("TEXTURE2")]
	public const GLenum TEXTURE2 = 0x84C2;
	[Value("TEXTURE3")]
	public const GLenum TEXTURE3 = 0x84C3;
	[Value("TEXTURE4")]
	public const GLenum TEXTURE4 = 0x84C4;
	[Value("TEXTURE5")]
	public const GLenum TEXTURE5 = 0x84C5;
	[Value("TEXTURE6")]
	public const GLenum TEXTURE6 = 0x84C6;
	[Value("TEXTURE7")]
	public const GLenum TEXTURE7 = 0x84C7;
	[Value("TEXTURE8")]
	public const GLenum TEXTURE8 = 0x84C8;
	[Value("TEXTURE9")]
	public const GLenum TEXTURE9 = 0x84C9;
	[Value("TEXTURE10")]
	public const GLenum TEXTURE10 = 0x84CA;
	[Value("TEXTURE11")]
	public const GLenum TEXTURE11 = 0x84CB;
	[Value("TEXTURE12")]
	public const GLenum TEXTURE12 = 0x84CC;
	[Value("TEXTURE13")]
	public const GLenum TEXTURE13 = 0x84CD;
	[Value("TEXTURE14")]
	public const GLenum TEXTURE14 = 0x84CE;
	[Value("TEXTURE15")]
	public const GLenum TEXTURE15 = 0x84CF;
	[Value("TEXTURE16")]
	public const GLenum TEXTURE16 = 0x84D0;
	[Value("TEXTURE17")]
	public const GLenum TEXTURE17 = 0x84D1;
	[Value("TEXTURE18")]
	public const GLenum TEXTURE18 = 0x84D2;
	[Value("TEXTURE19")]
	public const GLenum TEXTURE19 = 0x84D3;
	[Value("TEXTURE20")]
	public const GLenum TEXTURE20 = 0x84D4;
	[Value("TEXTURE21")]
	public const GLenum TEXTURE21 = 0x84D5;
	[Value("TEXTURE22")]
	public const GLenum TEXTURE22 = 0x84D6;
	[Value("TEXTURE23")]
	public const GLenum TEXTURE23 = 0x84D7;
	[Value("TEXTURE24")]
	public const GLenum TEXTURE24 = 0x84D8;
	[Value("TEXTURE25")]
	public const GLenum TEXTURE25 = 0x84D9;
	[Value("TEXTURE26")]
	public const GLenum TEXTURE26 = 0x84DA;
	[Value("TEXTURE27")]
	public const GLenum TEXTURE27 = 0x84DB;
	[Value("TEXTURE28")]
	public const GLenum TEXTURE28 = 0x84DC;
	[Value("TEXTURE29")]
	public const GLenum TEXTURE29 = 0x84DD;
	[Value("TEXTURE30")]
	public const GLenum TEXTURE30 = 0x84DE;
	[Value("TEXTURE31")]
	public const GLenum TEXTURE31 = 0x84DF;
	[Value("ACTIVE_TEXTURE")]
	public const GLenum ACTIVE_TEXTURE = 0x84E0;
	[Value("REPEAT")]
	public const GLenum REPEAT = 0x2901;
	[Value("CLAMP_TO_EDGE")]
	public const GLenum CLAMP_TO_EDGE = 0x812F;
	[Value("MIRRORED_REPEAT")]
	public const GLenum MIRRORED_REPEAT = 0x8370;
	[Value("FLOAT_VEC2")]
	public const GLenum FLOAT_VEC2 = 0x8B50;
	[Value("FLOAT_VEC3")]
	public const GLenum FLOAT_VEC3 = 0x8B51;
	[Value("FLOAT_VEC4")]
	public const GLenum FLOAT_VEC4 = 0x8B52;
	[Value("INT_VEC2")]
	public const GLenum INT_VEC2 = 0x8B53;
	[Value("INT_VEC3")]
	public const GLenum INT_VEC3 = 0x8B54;
	[Value("INT_VEC4")]
	public const GLenum INT_VEC4 = 0x8B55;
	[Value("BOOL")]
	public const GLenum BOOL = 0x8B56;
	[Value("BOOL_VEC2")]
	public const GLenum BOOL_VEC2 = 0x8B57;
	[Value("BOOL_VEC3")]
	public const GLenum BOOL_VEC3 = 0x8B58;
	[Value("BOOL_VEC4")]
	public const GLenum BOOL_VEC4 = 0x8B59;
	[Value("FLOAT_MAT2")]
	public const GLenum FLOAT_MAT2 = 0x8B5A;
	[Value("FLOAT_MAT3")]
	public const GLenum FLOAT_MAT3 = 0x8B5B;
	[Value("FLOAT_MAT4")]
	public const GLenum FLOAT_MAT4 = 0x8B5C;
	[Value("SAMPLER_2D")]
	public const GLenum SAMPLER_2D = 0x8B5E;
	[Value("SAMPLER_CUBE")]
	public const GLenum SAMPLER_CUBE = 0x8B60;
	[Value("VERTEX_ATTRIB_ARRAY_ENABLED")]
	public const GLenum VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
	[Value("VERTEX_ATTRIB_ARRAY_SIZE")]
	public const GLenum VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
	[Value("VERTEX_ATTRIB_ARRAY_STRIDE")]
	public const GLenum VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
	[Value("VERTEX_ATTRIB_ARRAY_TYPE")]
	public const GLenum VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
	[Value("VERTEX_ATTRIB_ARRAY_NORMALIZED")]
	public const GLenum VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
	[Value("VERTEX_ATTRIB_ARRAY_POINTER")]
	public const GLenum VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
	[Value("VERTEX_ATTRIB_ARRAY_BUFFER_BINDING")]
	public const GLenum VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
	[Value("IMPLEMENTATION_COLOR_READ_TYPE")]
	public const GLenum IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
	[Value("IMPLEMENTATION_COLOR_READ_FORMAT")]
	public const GLenum IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
	[Value("COMPILE_STATUS")]
	public const GLenum COMPILE_STATUS = 0x8B81;
	[Value("LOW_FLOAT")]
	public const GLenum LOW_FLOAT = 0x8DF0;
	[Value("MEDIUM_FLOAT")]
	public const GLenum MEDIUM_FLOAT = 0x8DF1;
	[Value("HIGH_FLOAT")]
	public const GLenum HIGH_FLOAT = 0x8DF2;
	[Value("LOW_INT")]
	public const GLenum LOW_INT = 0x8DF3;
	[Value("MEDIUM_INT")]
	public const GLenum MEDIUM_INT = 0x8DF4;
	[Value("HIGH_INT")]
	public const GLenum HIGH_INT = 0x8DF5;
	[Value("FRAMEBUFFER")]
	public const GLenum FRAMEBUFFER = 0x8D40;
	[Value("RENDERBUFFER")]
	public const GLenum RENDERBUFFER = 0x8D41;
	[Value("RGBA4")]
	public const GLenum RGBA4 = 0x8056;
	[Value("RGB5_A1")]
	public const GLenum RGB5_A1 = 0x8057;
	[Value("RGBA8")]
	public const GLenum RGBA8 = 0x8058;
	[Value("RGB565")]
	public const GLenum RGB565 = 0x8D62;
	[Value("DEPTH_COMPONENT16")]
	public const GLenum DEPTH_COMPONENT16 = 0x81A5;
	[Value("STENCIL_INDEX8")]
	public const GLenum STENCIL_INDEX8 = 0x8D48;
	[Value("DEPTH_STENCIL")]
	public const GLenum DEPTH_STENCIL = 0x84F9;
	[Value("RENDERBUFFER_WIDTH")]
	public const GLenum RENDERBUFFER_WIDTH = 0x8D42;
	[Value("RENDERBUFFER_HEIGHT")]
	public const GLenum RENDERBUFFER_HEIGHT = 0x8D43;
	[Value("RENDERBUFFER_INTERNAL_FORMAT")]
	public const GLenum RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
	[Value("RENDERBUFFER_RED_SIZE")]
	public const GLenum RENDERBUFFER_RED_SIZE = 0x8D50;
	[Value("RENDERBUFFER_GREEN_SIZE")]
	public const GLenum RENDERBUFFER_GREEN_SIZE = 0x8D51;
	[Value("RENDERBUFFER_BLUE_SIZE")]
	public const GLenum RENDERBUFFER_BLUE_SIZE = 0x8D52;
	[Value("RENDERBUFFER_ALPHA_SIZE")]
	public const GLenum RENDERBUFFER_ALPHA_SIZE = 0x8D53;
	[Value("RENDERBUFFER_DEPTH_SIZE")]
	public const GLenum RENDERBUFFER_DEPTH_SIZE = 0x8D54;
	[Value("RENDERBUFFER_STENCIL_SIZE")]
	public const GLenum RENDERBUFFER_STENCIL_SIZE = 0x8D55;
	[Value("FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE")]
	public const GLenum FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
	[Value("FRAMEBUFFER_ATTACHMENT_OBJECT_NAME")]
	public const GLenum FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
	[Value("FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL")]
	public const GLenum FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
	[Value("FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE")]
	public const GLenum FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
	[Value("COLOR_ATTACHMENT0")]
	public const GLenum COLOR_ATTACHMENT0 = 0x8CE0;
	[Value("DEPTH_ATTACHMENT")]
	public const GLenum DEPTH_ATTACHMENT = 0x8D00;
	[Value("STENCIL_ATTACHMENT")]
	public const GLenum STENCIL_ATTACHMENT = 0x8D20;
	[Value("DEPTH_STENCIL_ATTACHMENT")]
	public const GLenum DEPTH_STENCIL_ATTACHMENT = 0x821A;
	[Value("NONE")]
	public const GLenum NONE = 0;
	[Value("FRAMEBUFFER_COMPLETE")]
	public const GLenum FRAMEBUFFER_COMPLETE = 0x8CD5;
	[Value("FRAMEBUFFER_INCOMPLETE_ATTACHMENT")]
	public const GLenum FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
	[Value("FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT")]
	public const GLenum FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
	[Value("FRAMEBUFFER_INCOMPLETE_DIMENSIONS")]
	public const GLenum FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;
	[Value("FRAMEBUFFER_UNSUPPORTED")]
	public const GLenum FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
	[Value("FRAMEBUFFER_BINDING")]
	public const GLenum FRAMEBUFFER_BINDING = 0x8CA6;
	[Value("RENDERBUFFER_BINDING")]
	public const GLenum RENDERBUFFER_BINDING = 0x8CA7;
	[Value("MAX_RENDERBUFFER_SIZE")]
	public const GLenum MAX_RENDERBUFFER_SIZE = 0x84E8;
	[Value("INVALID_FRAMEBUFFER_OPERATION")]
	public const GLenum INVALID_FRAMEBUFFER_OPERATION = 0x0506;
	[Value("UNPACK_FLIP_Y_WEBGL")]
	public const GLenum UNPACK_FLIP_Y_WEBGL = 0x9240;
	[Value("UNPACK_PREMULTIPLY_ALPHA_WEBGL")]
	public const GLenum UNPACK_PREMULTIPLY_ALPHA_WEBGL = 0x9241;
	[Value("CONTEXT_LOST_WEBGL")]
	public const GLenum CONTEXT_LOST_WEBGL = 0x9242;
	[Value("UNPACK_COLORSPACE_CONVERSION_WEBGL")]
	public const GLenum UNPACK_COLORSPACE_CONVERSION_WEBGL = 0x9243;
	[Value("BROWSER_DEFAULT_WEBGL")]
	public const GLenum BROWSER_DEFAULT_WEBGL = 0x9244;
	[Value("canvas")]
	public Union192 Canvas { get { throw new System.NotImplementedException(); } }
	[Value("drawingBufferWidth")]
	public GLsizei DrawingBufferWidth { get { throw new System.NotImplementedException(); } }
	[Value("drawingBufferHeight")]
	public GLsizei DrawingBufferHeight { get { throw new System.NotImplementedException(); } }
	[Value("drawingBufferFormat")]
	public GLenum DrawingBufferFormat { get { throw new System.NotImplementedException(); } }
	[Value("drawingBufferColorSpace")]
	public PredefinedColorSpace DrawingBufferColorSpace { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("unpackColorSpace")]
	public PredefinedColorSpace UnpackColorSpace { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	[Value("getContextAttributes")]
	public WebGLContextAttributes? GetContextAttributes() { throw new System.NotImplementedException(); }
	[Value("isContextLost")]
	public bool IsContextLost() { throw new System.NotImplementedException(); }
	[Value("getSupportedExtensions")]
	public List<DOMString>? GetSupportedExtensions() { throw new System.NotImplementedException(); }
	[Value("getExtension")]
	public Object? GetExtension(DOMString name) { throw new System.NotImplementedException(); }
	[Value("drawingBufferStorage")]
	public Undefined DrawingBufferStorage(GLenum sizedFormat, ulong width, ulong height) { throw new System.NotImplementedException(); }
	[Value("activeTexture")]
	public Undefined ActiveTexture(GLenum texture) { throw new System.NotImplementedException(); }
	[Value("attachShader")]
	public Undefined AttachShader(WebGLProgram program, WebGLShader shader) { throw new System.NotImplementedException(); }
	[Value("bindAttribLocation")]
	public Undefined BindAttribLocation(WebGLProgram program, GLuint index, DOMString name) { throw new System.NotImplementedException(); }
	[Value("bindBuffer")]
	public Undefined BindBuffer(GLenum target, WebGLBuffer? buffer) { throw new System.NotImplementedException(); }
	[Value("bindFramebuffer")]
	public Undefined BindFramebuffer(GLenum target, WebGLFramebuffer? framebuffer) { throw new System.NotImplementedException(); }
	[Value("bindRenderbuffer")]
	public Undefined BindRenderbuffer(GLenum target, WebGLRenderbuffer? renderbuffer) { throw new System.NotImplementedException(); }
	[Value("bindTexture")]
	public Undefined BindTexture(GLenum target, WebGLTexture? texture) { throw new System.NotImplementedException(); }
	[Value("blendColor")]
	public Undefined BlendColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha) { throw new System.NotImplementedException(); }
	[Value("blendEquation")]
	public Undefined BlendEquation(GLenum mode) { throw new System.NotImplementedException(); }
	[Value("blendEquationSeparate")]
	public Undefined BlendEquationSeparate(GLenum modeRGB, GLenum modeAlpha) { throw new System.NotImplementedException(); }
	[Value("blendFunc")]
	public Undefined BlendFunc(GLenum sfactor, GLenum dfactor) { throw new System.NotImplementedException(); }
	[Value("blendFuncSeparate")]
	public Undefined BlendFuncSeparate(GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha) { throw new System.NotImplementedException(); }
	[Value("checkFramebufferStatus")]
	public GLenum CheckFramebufferStatus(GLenum target) { throw new System.NotImplementedException(); }
	[Value("clear")]
	public Undefined Clear(GLbitfield mask) { throw new System.NotImplementedException(); }
	[Value("clearColor")]
	public Undefined ClearColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha) { throw new System.NotImplementedException(); }
	[Value("clearDepth")]
	public Undefined ClearDepth(GLclampf depth) { throw new System.NotImplementedException(); }
	[Value("clearStencil")]
	public Undefined ClearStencil(GLint s) { throw new System.NotImplementedException(); }
	[Value("colorMask")]
	public Undefined ColorMask(bool red, bool green, bool blue, bool alpha) { throw new System.NotImplementedException(); }
	[Value("compileShader")]
	public Undefined CompileShader(WebGLShader shader) { throw new System.NotImplementedException(); }
	[Value("copyTexImage2D")]
	public Undefined CopyTexImage2D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border) { throw new System.NotImplementedException(); }
	[Value("copyTexSubImage2D")]
	public Undefined CopyTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height) { throw new System.NotImplementedException(); }
	[Value("createBuffer")]
	public WebGLBuffer CreateBuffer() { throw new System.NotImplementedException(); }
	[Value("createFramebuffer")]
	public WebGLFramebuffer CreateFramebuffer() { throw new System.NotImplementedException(); }
	[Value("createProgram")]
	public WebGLProgram CreateProgram() { throw new System.NotImplementedException(); }
	[Value("createRenderbuffer")]
	public WebGLRenderbuffer CreateRenderbuffer() { throw new System.NotImplementedException(); }
	[Value("createShader")]
	public WebGLShader? CreateShader(GLenum type) { throw new System.NotImplementedException(); }
	[Value("createTexture")]
	public WebGLTexture CreateTexture() { throw new System.NotImplementedException(); }
	[Value("cullFace")]
	public Undefined CullFace(GLenum mode) { throw new System.NotImplementedException(); }
	[Value("deleteBuffer")]
	public Undefined DeleteBuffer(WebGLBuffer? buffer) { throw new System.NotImplementedException(); }
	[Value("deleteFramebuffer")]
	public Undefined DeleteFramebuffer(WebGLFramebuffer? framebuffer) { throw new System.NotImplementedException(); }
	[Value("deleteProgram")]
	public Undefined DeleteProgram(WebGLProgram? program) { throw new System.NotImplementedException(); }
	[Value("deleteRenderbuffer")]
	public Undefined DeleteRenderbuffer(WebGLRenderbuffer? renderbuffer) { throw new System.NotImplementedException(); }
	[Value("deleteShader")]
	public Undefined DeleteShader(WebGLShader? shader) { throw new System.NotImplementedException(); }
	[Value("deleteTexture")]
	public Undefined DeleteTexture(WebGLTexture? texture) { throw new System.NotImplementedException(); }
	[Value("depthFunc")]
	public Undefined DepthFunc(GLenum func) { throw new System.NotImplementedException(); }
	[Value("depthMask")]
	public Undefined DepthMask(bool flag) { throw new System.NotImplementedException(); }
	[Value("depthRange")]
	public Undefined DepthRange(GLclampf zNear, GLclampf zFar) { throw new System.NotImplementedException(); }
	[Value("detachShader")]
	public Undefined DetachShader(WebGLProgram program, WebGLShader shader) { throw new System.NotImplementedException(); }
	[Value("disable")]
	public Undefined Disable(GLenum cap) { throw new System.NotImplementedException(); }
	[Value("disableVertexAttribArray")]
	public Undefined DisableVertexAttribArray(GLuint index) { throw new System.NotImplementedException(); }
	[Value("drawArrays")]
	public Undefined DrawArrays(GLenum mode, GLint first, GLsizei count) { throw new System.NotImplementedException(); }
	[Value("drawElements")]
	public Undefined DrawElements(GLenum mode, GLsizei count, GLenum type, GLintptr offset) { throw new System.NotImplementedException(); }
	[Value("enable")]
	public Undefined Enable(GLenum cap) { throw new System.NotImplementedException(); }
	[Value("enableVertexAttribArray")]
	public Undefined EnableVertexAttribArray(GLuint index) { throw new System.NotImplementedException(); }
	[Value("finish")]
	public Undefined Finish() { throw new System.NotImplementedException(); }
	[Value("flush")]
	public Undefined Flush() { throw new System.NotImplementedException(); }
	[Value("framebufferRenderbuffer")]
	public Undefined FramebufferRenderbuffer(GLenum target, GLenum attachment, GLenum renderbuffertarget, WebGLRenderbuffer? renderbuffer) { throw new System.NotImplementedException(); }
	[Value("framebufferTexture2D")]
	public Undefined FramebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, WebGLTexture? texture, GLint level) { throw new System.NotImplementedException(); }
	[Value("frontFace")]
	public Undefined FrontFace(GLenum mode) { throw new System.NotImplementedException(); }
	[Value("generateMipmap")]
	public Undefined GenerateMipmap(GLenum target) { throw new System.NotImplementedException(); }
	[Value("getActiveAttrib")]
	public WebGLActiveInfo? GetActiveAttrib(WebGLProgram program, GLuint index) { throw new System.NotImplementedException(); }
	[Value("getActiveUniform")]
	public WebGLActiveInfo? GetActiveUniform(WebGLProgram program, GLuint index) { throw new System.NotImplementedException(); }
	[Value("getAttachedShaders")]
	public List<WebGLShader>? GetAttachedShaders(WebGLProgram program) { throw new System.NotImplementedException(); }
	[Value("getAttribLocation")]
	public GLint GetAttribLocation(WebGLProgram program, DOMString name) { throw new System.NotImplementedException(); }
	[Value("getBufferParameter")]
	public dynamic GetBufferParameter(GLenum target, GLenum pname) { throw new System.NotImplementedException(); }
	[Value("getParameter")]
	public dynamic GetParameter(GLenum pname) { throw new System.NotImplementedException(); }
	[Value("getError")]
	public GLenum GetError() { throw new System.NotImplementedException(); }
	[Value("getFramebufferAttachmentParameter")]
	public dynamic GetFramebufferAttachmentParameter(GLenum target, GLenum attachment, GLenum pname) { throw new System.NotImplementedException(); }
	[Value("getProgramParameter")]
	public dynamic GetProgramParameter(WebGLProgram program, GLenum pname) { throw new System.NotImplementedException(); }
	[Value("getProgramInfoLog")]
	public DOMString? GetProgramInfoLog(WebGLProgram program) { throw new System.NotImplementedException(); }
	[Value("getRenderbufferParameter")]
	public dynamic GetRenderbufferParameter(GLenum target, GLenum pname) { throw new System.NotImplementedException(); }
	[Value("getShaderParameter")]
	public dynamic GetShaderParameter(WebGLShader shader, GLenum pname) { throw new System.NotImplementedException(); }
	[Value("getShaderPrecisionFormat")]
	public WebGLShaderPrecisionFormat? GetShaderPrecisionFormat(GLenum shadertype, GLenum precisiontype) { throw new System.NotImplementedException(); }
	[Value("getShaderInfoLog")]
	public DOMString? GetShaderInfoLog(WebGLShader shader) { throw new System.NotImplementedException(); }
	[Value("getShaderSource")]
	public DOMString? GetShaderSource(WebGLShader shader) { throw new System.NotImplementedException(); }
	[Value("getTexParameter")]
	public dynamic GetTexParameter(GLenum target, GLenum pname) { throw new System.NotImplementedException(); }
	[Value("getUniform")]
	public dynamic GetUniform(WebGLProgram program, WebGLUniformLocation location) { throw new System.NotImplementedException(); }
	[Value("getUniformLocation")]
	public WebGLUniformLocation? GetUniformLocation(WebGLProgram program, DOMString name) { throw new System.NotImplementedException(); }
	[Value("getVertexAttrib")]
	public dynamic GetVertexAttrib(GLuint index, GLenum pname) { throw new System.NotImplementedException(); }
	[Value("getVertexAttribOffset")]
	public GLintptr GetVertexAttribOffset(GLuint index, GLenum pname) { throw new System.NotImplementedException(); }
	[Value("hint")]
	public Undefined Hint(GLenum target, GLenum mode) { throw new System.NotImplementedException(); }
	[Value("isBuffer")]
	public bool IsBuffer(WebGLBuffer? buffer) { throw new System.NotImplementedException(); }
	[Value("isEnabled")]
	public bool IsEnabled(GLenum cap) { throw new System.NotImplementedException(); }
	[Value("isFramebuffer")]
	public bool IsFramebuffer(WebGLFramebuffer? framebuffer) { throw new System.NotImplementedException(); }
	[Value("isProgram")]
	public bool IsProgram(WebGLProgram? program) { throw new System.NotImplementedException(); }
	[Value("isRenderbuffer")]
	public bool IsRenderbuffer(WebGLRenderbuffer? renderbuffer) { throw new System.NotImplementedException(); }
	[Value("isShader")]
	public bool IsShader(WebGLShader? shader) { throw new System.NotImplementedException(); }
	[Value("isTexture")]
	public bool IsTexture(WebGLTexture? texture) { throw new System.NotImplementedException(); }
	[Value("lineWidth")]
	public Undefined LineWidth(Number width) { throw new System.NotImplementedException(); }
	[Value("linkProgram")]
	public Undefined LinkProgram(WebGLProgram program) { throw new System.NotImplementedException(); }
	[Value("pixelStorei")]
	public Undefined PixelStorei(GLenum pname, GLint param) { throw new System.NotImplementedException(); }
	[Value("polygonOffset")]
	public Undefined PolygonOffset(Number factor, Number units) { throw new System.NotImplementedException(); }
	[Value("renderbufferStorage")]
	public Undefined RenderbufferStorage(GLenum target, GLenum internalformat, GLsizei width, GLsizei height) { throw new System.NotImplementedException(); }
	[Value("sampleCoverage")]
	public Undefined SampleCoverage(GLclampf value, bool invert) { throw new System.NotImplementedException(); }
	[Value("scissor")]
	public Undefined Scissor(GLint x, GLint y, GLsizei width, GLsizei height) { throw new System.NotImplementedException(); }
	[Value("shaderSource")]
	public Undefined ShaderSource(WebGLShader shader, DOMString source) { throw new System.NotImplementedException(); }
	[Value("stencilFunc")]
	public Undefined StencilFunc(GLenum func, GLint ref_, GLuint mask) { throw new System.NotImplementedException(); }
	[Value("stencilFuncSeparate")]
	public Undefined StencilFuncSeparate(GLenum face, GLenum func, GLint ref_, GLuint mask) { throw new System.NotImplementedException(); }
	[Value("stencilMask")]
	public Undefined StencilMask(GLuint mask) { throw new System.NotImplementedException(); }
	[Value("stencilMaskSeparate")]
	public Undefined StencilMaskSeparate(GLenum face, GLuint mask) { throw new System.NotImplementedException(); }
	[Value("stencilOp")]
	public Undefined StencilOp(GLenum fail, GLenum zfail, GLenum zpass) { throw new System.NotImplementedException(); }
	[Value("stencilOpSeparate")]
	public Undefined StencilOpSeparate(GLenum face, GLenum fail, GLenum zfail, GLenum zpass) { throw new System.NotImplementedException(); }
	[Value("texParameterf")]
	public Undefined TexParameterf(GLenum target, GLenum pname, Number param) { throw new System.NotImplementedException(); }
	[Value("texParameteri")]
	public Undefined TexParameteri(GLenum target, GLenum pname, GLint param) { throw new System.NotImplementedException(); }
	[Value("uniform1f")]
	public Undefined Uniform1f(WebGLUniformLocation? location, Number x) { throw new System.NotImplementedException(); }
	[Value("uniform2f")]
	public Undefined Uniform2f(WebGLUniformLocation? location, Number x, Number y) { throw new System.NotImplementedException(); }
	[Value("uniform3f")]
	public Undefined Uniform3f(WebGLUniformLocation? location, Number x, Number y, Number z) { throw new System.NotImplementedException(); }
	[Value("uniform4f")]
	public Undefined Uniform4f(WebGLUniformLocation? location, Number x, Number y, Number z, Number w) { throw new System.NotImplementedException(); }
	[Value("uniform1i")]
	public Undefined Uniform1i(WebGLUniformLocation? location, GLint x) { throw new System.NotImplementedException(); }
	[Value("uniform2i")]
	public Undefined Uniform2i(WebGLUniformLocation? location, GLint x, GLint y) { throw new System.NotImplementedException(); }
	[Value("uniform3i")]
	public Undefined Uniform3i(WebGLUniformLocation? location, GLint x, GLint y, GLint z) { throw new System.NotImplementedException(); }
	[Value("uniform4i")]
	public Undefined Uniform4i(WebGLUniformLocation? location, GLint x, GLint y, GLint z, GLint w) { throw new System.NotImplementedException(); }
	[Value("useProgram")]
	public Undefined UseProgram(WebGLProgram? program) { throw new System.NotImplementedException(); }
	[Value("validateProgram")]
	public Undefined ValidateProgram(WebGLProgram program) { throw new System.NotImplementedException(); }
	[Value("vertexAttrib1f")]
	public Undefined VertexAttrib1f(GLuint index, Number x) { throw new System.NotImplementedException(); }
	[Value("vertexAttrib2f")]
	public Undefined VertexAttrib2f(GLuint index, Number x, Number y) { throw new System.NotImplementedException(); }
	[Value("vertexAttrib3f")]
	public Undefined VertexAttrib3f(GLuint index, Number x, Number y, Number z) { throw new System.NotImplementedException(); }
	[Value("vertexAttrib4f")]
	public Undefined VertexAttrib4f(GLuint index, Number x, Number y, Number z, Number w) { throw new System.NotImplementedException(); }
	[Value("vertexAttrib1fv")]
	public Undefined VertexAttrib1fv(GLuint index, Float32List values) { throw new System.NotImplementedException(); }
	[Value("vertexAttrib2fv")]
	public Undefined VertexAttrib2fv(GLuint index, Float32List values) { throw new System.NotImplementedException(); }
	[Value("vertexAttrib3fv")]
	public Undefined VertexAttrib3fv(GLuint index, Float32List values) { throw new System.NotImplementedException(); }
	[Value("vertexAttrib4fv")]
	public Undefined VertexAttrib4fv(GLuint index, Float32List values) { throw new System.NotImplementedException(); }
	[Value("vertexAttribPointer")]
	public Undefined VertexAttribPointer(GLuint index, GLint size, GLenum type, bool normalized, GLsizei stride, GLintptr offset) { throw new System.NotImplementedException(); }
	[Value("viewport")]
	public Undefined Viewport(GLint x, GLint y, GLsizei width, GLsizei height) { throw new System.NotImplementedException(); }
}

[Value("WebGLRenderingContextOverloads")]
public partial interface WebGLRenderingContextOverloads
{
	[Value("bufferData")]
	public Undefined BufferData(GLenum target, GLsizeiptr size, GLenum usage) { throw new System.NotImplementedException(); }
	[Value("bufferData")]
	public Undefined BufferData(GLenum target, AllowSharedBufferSource? data, GLenum usage) { throw new System.NotImplementedException(); }
	[Value("bufferSubData")]
	public Undefined BufferSubData(GLenum target, GLintptr offset, AllowSharedBufferSource data) { throw new System.NotImplementedException(); }
	[Value("compressedTexImage2D")]
	public Undefined CompressedTexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, ArrayBufferView data) { throw new System.NotImplementedException(); }
	[Value("compressedTexSubImage2D")]
	public Undefined CompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, ArrayBufferView data) { throw new System.NotImplementedException(); }
	[Value("readPixels")]
	public Undefined ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, ArrayBufferView? pixels) { throw new System.NotImplementedException(); }
	[Value("texImage2D")]
	public Undefined TexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, ArrayBufferView? pixels) { throw new System.NotImplementedException(); }
	[Value("texImage2D")]
	public Undefined TexImage2D(GLenum target, GLint level, GLint internalformat, GLenum format, GLenum type, TexImageSource source) { throw new System.NotImplementedException(); }
	[Value("texSubImage2D")]
	public Undefined TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, ArrayBufferView? pixels) { throw new System.NotImplementedException(); }
	[Value("texSubImage2D")]
	public Undefined TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLenum format, GLenum type, TexImageSource source) { throw new System.NotImplementedException(); }
	[Value("uniform1fv")]
	public Undefined Uniform1fv(WebGLUniformLocation? location, Float32List v) { throw new System.NotImplementedException(); }
	[Value("uniform2fv")]
	public Undefined Uniform2fv(WebGLUniformLocation? location, Float32List v) { throw new System.NotImplementedException(); }
	[Value("uniform3fv")]
	public Undefined Uniform3fv(WebGLUniformLocation? location, Float32List v) { throw new System.NotImplementedException(); }
	[Value("uniform4fv")]
	public Undefined Uniform4fv(WebGLUniformLocation? location, Float32List v) { throw new System.NotImplementedException(); }
	[Value("uniform1iv")]
	public Undefined Uniform1iv(WebGLUniformLocation? location, Int32List v) { throw new System.NotImplementedException(); }
	[Value("uniform2iv")]
	public Undefined Uniform2iv(WebGLUniformLocation? location, Int32List v) { throw new System.NotImplementedException(); }
	[Value("uniform3iv")]
	public Undefined Uniform3iv(WebGLUniformLocation? location, Int32List v) { throw new System.NotImplementedException(); }
	[Value("uniform4iv")]
	public Undefined Uniform4iv(WebGLUniformLocation? location, Int32List v) { throw new System.NotImplementedException(); }
	[Value("uniformMatrix2fv")]
	public Undefined UniformMatrix2fv(WebGLUniformLocation? location, bool transpose, Float32List value) { throw new System.NotImplementedException(); }
	[Value("uniformMatrix3fv")]
	public Undefined UniformMatrix3fv(WebGLUniformLocation? location, bool transpose, Float32List value) { throw new System.NotImplementedException(); }
	[Value("uniformMatrix4fv")]
	public Undefined UniformMatrix4fv(WebGLUniformLocation? location, bool transpose, Float32List value) { throw new System.NotImplementedException(); }
}

[Value("WebGL2RenderingContextBase")]
public partial interface WebGL2RenderingContextBase
{
	[Value("READ_BUFFER")]
	public const GLenum READ_BUFFER = 0x0C02;
	[Value("UNPACK_ROW_LENGTH")]
	public const GLenum UNPACK_ROW_LENGTH = 0x0CF2;
	[Value("UNPACK_SKIP_ROWS")]
	public const GLenum UNPACK_SKIP_ROWS = 0x0CF3;
	[Value("UNPACK_SKIP_PIXELS")]
	public const GLenum UNPACK_SKIP_PIXELS = 0x0CF4;
	[Value("PACK_ROW_LENGTH")]
	public const GLenum PACK_ROW_LENGTH = 0x0D02;
	[Value("PACK_SKIP_ROWS")]
	public const GLenum PACK_SKIP_ROWS = 0x0D03;
	[Value("PACK_SKIP_PIXELS")]
	public const GLenum PACK_SKIP_PIXELS = 0x0D04;
	[Value("COLOR")]
	public const GLenum COLOR = 0x1800;
	[Value("DEPTH")]
	public const GLenum DEPTH = 0x1801;
	[Value("STENCIL")]
	public const GLenum STENCIL = 0x1802;
	[Value("RED")]
	public const GLenum RED = 0x1903;
	[Value("RGB8")]
	public const GLenum RGB8 = 0x8051;
	[Value("RGB10_A2")]
	public const GLenum RGB10_A2 = 0x8059;
	[Value("TEXTURE_BINDING_3D")]
	public const GLenum TEXTURE_BINDING_3D = 0x806A;
	[Value("UNPACK_SKIP_IMAGES")]
	public const GLenum UNPACK_SKIP_IMAGES = 0x806D;
	[Value("UNPACK_IMAGE_HEIGHT")]
	public const GLenum UNPACK_IMAGE_HEIGHT = 0x806E;
	[Value("TEXTURE_3D")]
	public const GLenum TEXTURE_3D = 0x806F;
	[Value("TEXTURE_WRAP_R")]
	public const GLenum TEXTURE_WRAP_R = 0x8072;
	[Value("MAX_3D_TEXTURE_SIZE")]
	public const GLenum MAX_3D_TEXTURE_SIZE = 0x8073;
	[Value("UNSIGNED_INT_2_10_10_10_REV")]
	public const GLenum UNSIGNED_INT_2_10_10_10_REV = 0x8368;
	[Value("MAX_ELEMENTS_VERTICES")]
	public const GLenum MAX_ELEMENTS_VERTICES = 0x80E8;
	[Value("MAX_ELEMENTS_INDICES")]
	public const GLenum MAX_ELEMENTS_INDICES = 0x80E9;
	[Value("TEXTURE_MIN_LOD")]
	public const GLenum TEXTURE_MIN_LOD = 0x813A;
	[Value("TEXTURE_MAX_LOD")]
	public const GLenum TEXTURE_MAX_LOD = 0x813B;
	[Value("TEXTURE_BASE_LEVEL")]
	public const GLenum TEXTURE_BASE_LEVEL = 0x813C;
	[Value("TEXTURE_MAX_LEVEL")]
	public const GLenum TEXTURE_MAX_LEVEL = 0x813D;
	[Value("MIN")]
	public const GLenum MIN = 0x8007;
	[Value("MAX")]
	public const GLenum MAX = 0x8008;
	[Value("DEPTH_COMPONENT24")]
	public const GLenum DEPTH_COMPONENT24 = 0x81A6;
	[Value("MAX_TEXTURE_LOD_BIAS")]
	public const GLenum MAX_TEXTURE_LOD_BIAS = 0x84FD;
	[Value("TEXTURE_COMPARE_MODE")]
	public const GLenum TEXTURE_COMPARE_MODE = 0x884C;
	[Value("TEXTURE_COMPARE_FUNC")]
	public const GLenum TEXTURE_COMPARE_FUNC = 0x884D;
	[Value("CURRENT_QUERY")]
	public const GLenum CURRENT_QUERY = 0x8865;
	[Value("QUERY_RESULT")]
	public const GLenum QUERY_RESULT = 0x8866;
	[Value("QUERY_RESULT_AVAILABLE")]
	public const GLenum QUERY_RESULT_AVAILABLE = 0x8867;
	[Value("STREAM_READ")]
	public const GLenum STREAM_READ = 0x88E1;
	[Value("STREAM_COPY")]
	public const GLenum STREAM_COPY = 0x88E2;
	[Value("STATIC_READ")]
	public const GLenum STATIC_READ = 0x88E5;
	[Value("STATIC_COPY")]
	public const GLenum STATIC_COPY = 0x88E6;
	[Value("DYNAMIC_READ")]
	public const GLenum DYNAMIC_READ = 0x88E9;
	[Value("DYNAMIC_COPY")]
	public const GLenum DYNAMIC_COPY = 0x88EA;
	[Value("MAX_DRAW_BUFFERS")]
	public const GLenum MAX_DRAW_BUFFERS = 0x8824;
	[Value("DRAW_BUFFER0")]
	public const GLenum DRAW_BUFFER0 = 0x8825;
	[Value("DRAW_BUFFER1")]
	public const GLenum DRAW_BUFFER1 = 0x8826;
	[Value("DRAW_BUFFER2")]
	public const GLenum DRAW_BUFFER2 = 0x8827;
	[Value("DRAW_BUFFER3")]
	public const GLenum DRAW_BUFFER3 = 0x8828;
	[Value("DRAW_BUFFER4")]
	public const GLenum DRAW_BUFFER4 = 0x8829;
	[Value("DRAW_BUFFER5")]
	public const GLenum DRAW_BUFFER5 = 0x882A;
	[Value("DRAW_BUFFER6")]
	public const GLenum DRAW_BUFFER6 = 0x882B;
	[Value("DRAW_BUFFER7")]
	public const GLenum DRAW_BUFFER7 = 0x882C;
	[Value("DRAW_BUFFER8")]
	public const GLenum DRAW_BUFFER8 = 0x882D;
	[Value("DRAW_BUFFER9")]
	public const GLenum DRAW_BUFFER9 = 0x882E;
	[Value("DRAW_BUFFER10")]
	public const GLenum DRAW_BUFFER10 = 0x882F;
	[Value("DRAW_BUFFER11")]
	public const GLenum DRAW_BUFFER11 = 0x8830;
	[Value("DRAW_BUFFER12")]
	public const GLenum DRAW_BUFFER12 = 0x8831;
	[Value("DRAW_BUFFER13")]
	public const GLenum DRAW_BUFFER13 = 0x8832;
	[Value("DRAW_BUFFER14")]
	public const GLenum DRAW_BUFFER14 = 0x8833;
	[Value("DRAW_BUFFER15")]
	public const GLenum DRAW_BUFFER15 = 0x8834;
	[Value("MAX_FRAGMENT_UNIFORM_COMPONENTS")]
	public const GLenum MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;
	[Value("MAX_VERTEX_UNIFORM_COMPONENTS")]
	public const GLenum MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;
	[Value("SAMPLER_3D")]
	public const GLenum SAMPLER_3D = 0x8B5F;
	[Value("SAMPLER_2D_SHADOW")]
	public const GLenum SAMPLER_2D_SHADOW = 0x8B62;
	[Value("FRAGMENT_SHADER_DERIVATIVE_HINT")]
	public const GLenum FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;
	[Value("PIXEL_PACK_BUFFER")]
	public const GLenum PIXEL_PACK_BUFFER = 0x88EB;
	[Value("PIXEL_UNPACK_BUFFER")]
	public const GLenum PIXEL_UNPACK_BUFFER = 0x88EC;
	[Value("PIXEL_PACK_BUFFER_BINDING")]
	public const GLenum PIXEL_PACK_BUFFER_BINDING = 0x88ED;
	[Value("PIXEL_UNPACK_BUFFER_BINDING")]
	public const GLenum PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
	[Value("FLOAT_MAT2x3")]
	public const GLenum FLOAT_MAT2x3 = 0x8B65;
	[Value("FLOAT_MAT2x4")]
	public const GLenum FLOAT_MAT2x4 = 0x8B66;
	[Value("FLOAT_MAT3x2")]
	public const GLenum FLOAT_MAT3x2 = 0x8B67;
	[Value("FLOAT_MAT3x4")]
	public const GLenum FLOAT_MAT3x4 = 0x8B68;
	[Value("FLOAT_MAT4x2")]
	public const GLenum FLOAT_MAT4x2 = 0x8B69;
	[Value("FLOAT_MAT4x3")]
	public const GLenum FLOAT_MAT4x3 = 0x8B6A;
	[Value("SRGB")]
	public const GLenum SRGB = 0x8C40;
	[Value("SRGB8")]
	public const GLenum SRGB8 = 0x8C41;
	[Value("SRGB8_ALPHA8")]
	public const GLenum SRGB8_ALPHA8 = 0x8C43;
	[Value("COMPARE_REF_TO_TEXTURE")]
	public const GLenum COMPARE_REF_TO_TEXTURE = 0x884E;
	[Value("RGBA32F")]
	public const GLenum RGBA32F = 0x8814;
	[Value("RGB32F")]
	public const GLenum RGB32F = 0x8815;
	[Value("RGBA16F")]
	public const GLenum RGBA16F = 0x881A;
	[Value("RGB16F")]
	public const GLenum RGB16F = 0x881B;
	[Value("VERTEX_ATTRIB_ARRAY_INTEGER")]
	public const GLenum VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;
	[Value("MAX_ARRAY_TEXTURE_LAYERS")]
	public const GLenum MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;
	[Value("MIN_PROGRAM_TEXEL_OFFSET")]
	public const GLenum MIN_PROGRAM_TEXEL_OFFSET = 0x8904;
	[Value("MAX_PROGRAM_TEXEL_OFFSET")]
	public const GLenum MAX_PROGRAM_TEXEL_OFFSET = 0x8905;
	[Value("MAX_VARYING_COMPONENTS")]
	public const GLenum MAX_VARYING_COMPONENTS = 0x8B4B;
	[Value("TEXTURE_2D_ARRAY")]
	public const GLenum TEXTURE_2D_ARRAY = 0x8C1A;
	[Value("TEXTURE_BINDING_2D_ARRAY")]
	public const GLenum TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
	[Value("R11F_G11F_B10F")]
	public const GLenum R11F_G11F_B10F = 0x8C3A;
	[Value("UNSIGNED_INT_10F_11F_11F_REV")]
	public const GLenum UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
	[Value("RGB9_E5")]
	public const GLenum RGB9_E5 = 0x8C3D;
	[Value("UNSIGNED_INT_5_9_9_9_REV")]
	public const GLenum UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
	[Value("TRANSFORM_FEEDBACK_BUFFER_MODE")]
	public const GLenum TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
	[Value("MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS")]
	public const GLenum MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
	[Value("TRANSFORM_FEEDBACK_VARYINGS")]
	public const GLenum TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;
	[Value("TRANSFORM_FEEDBACK_BUFFER_START")]
	public const GLenum TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
	[Value("TRANSFORM_FEEDBACK_BUFFER_SIZE")]
	public const GLenum TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
	[Value("TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN")]
	public const GLenum TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
	[Value("RASTERIZER_DISCARD")]
	public const GLenum RASTERIZER_DISCARD = 0x8C89;
	[Value("MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS")]
	public const GLenum MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
	[Value("MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS")]
	public const GLenum MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
	[Value("INTERLEAVED_ATTRIBS")]
	public const GLenum INTERLEAVED_ATTRIBS = 0x8C8C;
	[Value("SEPARATE_ATTRIBS")]
	public const GLenum SEPARATE_ATTRIBS = 0x8C8D;
	[Value("TRANSFORM_FEEDBACK_BUFFER")]
	public const GLenum TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
	[Value("TRANSFORM_FEEDBACK_BUFFER_BINDING")]
	public const GLenum TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;
	[Value("RGBA32UI")]
	public const GLenum RGBA32UI = 0x8D70;
	[Value("RGB32UI")]
	public const GLenum RGB32UI = 0x8D71;
	[Value("RGBA16UI")]
	public const GLenum RGBA16UI = 0x8D76;
	[Value("RGB16UI")]
	public const GLenum RGB16UI = 0x8D77;
	[Value("RGBA8UI")]
	public const GLenum RGBA8UI = 0x8D7C;
	[Value("RGB8UI")]
	public const GLenum RGB8UI = 0x8D7D;
	[Value("RGBA32I")]
	public const GLenum RGBA32I = 0x8D82;
	[Value("RGB32I")]
	public const GLenum RGB32I = 0x8D83;
	[Value("RGBA16I")]
	public const GLenum RGBA16I = 0x8D88;
	[Value("RGB16I")]
	public const GLenum RGB16I = 0x8D89;
	[Value("RGBA8I")]
	public const GLenum RGBA8I = 0x8D8E;
	[Value("RGB8I")]
	public const GLenum RGB8I = 0x8D8F;
	[Value("RED_INTEGER")]
	public const GLenum RED_INTEGER = 0x8D94;
	[Value("RGB_INTEGER")]
	public const GLenum RGB_INTEGER = 0x8D98;
	[Value("RGBA_INTEGER")]
	public const GLenum RGBA_INTEGER = 0x8D99;
	[Value("SAMPLER_2D_ARRAY")]
	public const GLenum SAMPLER_2D_ARRAY = 0x8DC1;
	[Value("SAMPLER_2D_ARRAY_SHADOW")]
	public const GLenum SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;
	[Value("SAMPLER_CUBE_SHADOW")]
	public const GLenum SAMPLER_CUBE_SHADOW = 0x8DC5;
	[Value("UNSIGNED_INT_VEC2")]
	public const GLenum UNSIGNED_INT_VEC2 = 0x8DC6;
	[Value("UNSIGNED_INT_VEC3")]
	public const GLenum UNSIGNED_INT_VEC3 = 0x8DC7;
	[Value("UNSIGNED_INT_VEC4")]
	public const GLenum UNSIGNED_INT_VEC4 = 0x8DC8;
	[Value("INT_SAMPLER_2D")]
	public const GLenum INT_SAMPLER_2D = 0x8DCA;
	[Value("INT_SAMPLER_3D")]
	public const GLenum INT_SAMPLER_3D = 0x8DCB;
	[Value("INT_SAMPLER_CUBE")]
	public const GLenum INT_SAMPLER_CUBE = 0x8DCC;
	[Value("INT_SAMPLER_2D_ARRAY")]
	public const GLenum INT_SAMPLER_2D_ARRAY = 0x8DCF;
	[Value("UNSIGNED_INT_SAMPLER_2D")]
	public const GLenum UNSIGNED_INT_SAMPLER_2D = 0x8DD2;
	[Value("UNSIGNED_INT_SAMPLER_3D")]
	public const GLenum UNSIGNED_INT_SAMPLER_3D = 0x8DD3;
	[Value("UNSIGNED_INT_SAMPLER_CUBE")]
	public const GLenum UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;
	[Value("UNSIGNED_INT_SAMPLER_2D_ARRAY")]
	public const GLenum UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;
	[Value("DEPTH_COMPONENT32F")]
	public const GLenum DEPTH_COMPONENT32F = 0x8CAC;
	[Value("DEPTH32F_STENCIL8")]
	public const GLenum DEPTH32F_STENCIL8 = 0x8CAD;
	[Value("FLOAT_32_UNSIGNED_INT_24_8_REV")]
	public const GLenum FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
	[Value("FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING")]
	public const GLenum FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
	[Value("FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE")]
	public const GLenum FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
	[Value("FRAMEBUFFER_ATTACHMENT_RED_SIZE")]
	public const GLenum FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
	[Value("FRAMEBUFFER_ATTACHMENT_GREEN_SIZE")]
	public const GLenum FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
	[Value("FRAMEBUFFER_ATTACHMENT_BLUE_SIZE")]
	public const GLenum FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
	[Value("FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE")]
	public const GLenum FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
	[Value("FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE")]
	public const GLenum FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
	[Value("FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE")]
	public const GLenum FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
	[Value("FRAMEBUFFER_DEFAULT")]
	public const GLenum FRAMEBUFFER_DEFAULT = 0x8218;
	[Value("UNSIGNED_INT_24_8")]
	public const GLenum UNSIGNED_INT_24_8 = 0x84FA;
	[Value("DEPTH24_STENCIL8")]
	public const GLenum DEPTH24_STENCIL8 = 0x88F0;
	[Value("UNSIGNED_NORMALIZED")]
	public const GLenum UNSIGNED_NORMALIZED = 0x8C17;
	[Value("DRAW_FRAMEBUFFER_BINDING")]
	public const GLenum DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
	[Value("READ_FRAMEBUFFER")]
	public const GLenum READ_FRAMEBUFFER = 0x8CA8;
	[Value("DRAW_FRAMEBUFFER")]
	public const GLenum DRAW_FRAMEBUFFER = 0x8CA9;
	[Value("READ_FRAMEBUFFER_BINDING")]
	public const GLenum READ_FRAMEBUFFER_BINDING = 0x8CAA;
	[Value("RENDERBUFFER_SAMPLES")]
	public const GLenum RENDERBUFFER_SAMPLES = 0x8CAB;
	[Value("FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER")]
	public const GLenum FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
	[Value("MAX_COLOR_ATTACHMENTS")]
	public const GLenum MAX_COLOR_ATTACHMENTS = 0x8CDF;
	[Value("COLOR_ATTACHMENT1")]
	public const GLenum COLOR_ATTACHMENT1 = 0x8CE1;
	[Value("COLOR_ATTACHMENT2")]
	public const GLenum COLOR_ATTACHMENT2 = 0x8CE2;
	[Value("COLOR_ATTACHMENT3")]
	public const GLenum COLOR_ATTACHMENT3 = 0x8CE3;
	[Value("COLOR_ATTACHMENT4")]
	public const GLenum COLOR_ATTACHMENT4 = 0x8CE4;
	[Value("COLOR_ATTACHMENT5")]
	public const GLenum COLOR_ATTACHMENT5 = 0x8CE5;
	[Value("COLOR_ATTACHMENT6")]
	public const GLenum COLOR_ATTACHMENT6 = 0x8CE6;
	[Value("COLOR_ATTACHMENT7")]
	public const GLenum COLOR_ATTACHMENT7 = 0x8CE7;
	[Value("COLOR_ATTACHMENT8")]
	public const GLenum COLOR_ATTACHMENT8 = 0x8CE8;
	[Value("COLOR_ATTACHMENT9")]
	public const GLenum COLOR_ATTACHMENT9 = 0x8CE9;
	[Value("COLOR_ATTACHMENT10")]
	public const GLenum COLOR_ATTACHMENT10 = 0x8CEA;
	[Value("COLOR_ATTACHMENT11")]
	public const GLenum COLOR_ATTACHMENT11 = 0x8CEB;
	[Value("COLOR_ATTACHMENT12")]
	public const GLenum COLOR_ATTACHMENT12 = 0x8CEC;
	[Value("COLOR_ATTACHMENT13")]
	public const GLenum COLOR_ATTACHMENT13 = 0x8CED;
	[Value("COLOR_ATTACHMENT14")]
	public const GLenum COLOR_ATTACHMENT14 = 0x8CEE;
	[Value("COLOR_ATTACHMENT15")]
	public const GLenum COLOR_ATTACHMENT15 = 0x8CEF;
	[Value("FRAMEBUFFER_INCOMPLETE_MULTISAMPLE")]
	public const GLenum FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
	[Value("MAX_SAMPLES")]
	public const GLenum MAX_SAMPLES = 0x8D57;
	[Value("HALF_FLOAT")]
	public const GLenum HALF_FLOAT = 0x140B;
	[Value("RG")]
	public const GLenum RG = 0x8227;
	[Value("RG_INTEGER")]
	public const GLenum RG_INTEGER = 0x8228;
	[Value("R8")]
	public const GLenum R8 = 0x8229;
	[Value("RG8")]
	public const GLenum RG8 = 0x822B;
	[Value("R16F")]
	public const GLenum R16F = 0x822D;
	[Value("R32F")]
	public const GLenum R32F = 0x822E;
	[Value("RG16F")]
	public const GLenum RG16F = 0x822F;
	[Value("RG32F")]
	public const GLenum RG32F = 0x8230;
	[Value("R8I")]
	public const GLenum R8I = 0x8231;
	[Value("R8UI")]
	public const GLenum R8UI = 0x8232;
	[Value("R16I")]
	public const GLenum R16I = 0x8233;
	[Value("R16UI")]
	public const GLenum R16UI = 0x8234;
	[Value("R32I")]
	public const GLenum R32I = 0x8235;
	[Value("R32UI")]
	public const GLenum R32UI = 0x8236;
	[Value("RG8I")]
	public const GLenum RG8I = 0x8237;
	[Value("RG8UI")]
	public const GLenum RG8UI = 0x8238;
	[Value("RG16I")]
	public const GLenum RG16I = 0x8239;
	[Value("RG16UI")]
	public const GLenum RG16UI = 0x823A;
	[Value("RG32I")]
	public const GLenum RG32I = 0x823B;
	[Value("RG32UI")]
	public const GLenum RG32UI = 0x823C;
	[Value("VERTEX_ARRAY_BINDING")]
	public const GLenum VERTEX_ARRAY_BINDING = 0x85B5;
	[Value("R8_SNORM")]
	public const GLenum R8_SNORM = 0x8F94;
	[Value("RG8_SNORM")]
	public const GLenum RG8_SNORM = 0x8F95;
	[Value("RGB8_SNORM")]
	public const GLenum RGB8_SNORM = 0x8F96;
	[Value("RGBA8_SNORM")]
	public const GLenum RGBA8_SNORM = 0x8F97;
	[Value("SIGNED_NORMALIZED")]
	public const GLenum SIGNED_NORMALIZED = 0x8F9C;
	[Value("COPY_READ_BUFFER")]
	public const GLenum COPY_READ_BUFFER = 0x8F36;
	[Value("COPY_WRITE_BUFFER")]
	public const GLenum COPY_WRITE_BUFFER = 0x8F37;
	[Value("COPY_READ_BUFFER_BINDING")]
	public const GLenum COPY_READ_BUFFER_BINDING = 0x8F36;
	[Value("COPY_WRITE_BUFFER_BINDING")]
	public const GLenum COPY_WRITE_BUFFER_BINDING = 0x8F37;
	[Value("UNIFORM_BUFFER")]
	public const GLenum UNIFORM_BUFFER = 0x8A11;
	[Value("UNIFORM_BUFFER_BINDING")]
	public const GLenum UNIFORM_BUFFER_BINDING = 0x8A28;
	[Value("UNIFORM_BUFFER_START")]
	public const GLenum UNIFORM_BUFFER_START = 0x8A29;
	[Value("UNIFORM_BUFFER_SIZE")]
	public const GLenum UNIFORM_BUFFER_SIZE = 0x8A2A;
	[Value("MAX_VERTEX_UNIFORM_BLOCKS")]
	public const GLenum MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
	[Value("MAX_FRAGMENT_UNIFORM_BLOCKS")]
	public const GLenum MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
	[Value("MAX_COMBINED_UNIFORM_BLOCKS")]
	public const GLenum MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
	[Value("MAX_UNIFORM_BUFFER_BINDINGS")]
	public const GLenum MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
	[Value("MAX_UNIFORM_BLOCK_SIZE")]
	public const GLenum MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
	[Value("MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS")]
	public const GLenum MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
	[Value("MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS")]
	public const GLenum MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
	[Value("UNIFORM_BUFFER_OFFSET_ALIGNMENT")]
	public const GLenum UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
	[Value("ACTIVE_UNIFORM_BLOCKS")]
	public const GLenum ACTIVE_UNIFORM_BLOCKS = 0x8A36;
	[Value("UNIFORM_TYPE")]
	public const GLenum UNIFORM_TYPE = 0x8A37;
	[Value("UNIFORM_SIZE")]
	public const GLenum UNIFORM_SIZE = 0x8A38;
	[Value("UNIFORM_BLOCK_INDEX")]
	public const GLenum UNIFORM_BLOCK_INDEX = 0x8A3A;
	[Value("UNIFORM_OFFSET")]
	public const GLenum UNIFORM_OFFSET = 0x8A3B;
	[Value("UNIFORM_ARRAY_STRIDE")]
	public const GLenum UNIFORM_ARRAY_STRIDE = 0x8A3C;
	[Value("UNIFORM_MATRIX_STRIDE")]
	public const GLenum UNIFORM_MATRIX_STRIDE = 0x8A3D;
	[Value("UNIFORM_IS_ROW_MAJOR")]
	public const GLenum UNIFORM_IS_ROW_MAJOR = 0x8A3E;
	[Value("UNIFORM_BLOCK_BINDING")]
	public const GLenum UNIFORM_BLOCK_BINDING = 0x8A3F;
	[Value("UNIFORM_BLOCK_DATA_SIZE")]
	public const GLenum UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
	[Value("UNIFORM_BLOCK_ACTIVE_UNIFORMS")]
	public const GLenum UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
	[Value("UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES")]
	public const GLenum UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
	[Value("UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER")]
	public const GLenum UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
	[Value("UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER")]
	public const GLenum UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
	[Value("INVALID_INDEX")]
	public const GLenum INVALID_INDEX = 0xFFFFFFFF;
	[Value("MAX_VERTEX_OUTPUT_COMPONENTS")]
	public const GLenum MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;
	[Value("MAX_FRAGMENT_INPUT_COMPONENTS")]
	public const GLenum MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;
	[Value("MAX_SERVER_WAIT_TIMEOUT")]
	public const GLenum MAX_SERVER_WAIT_TIMEOUT = 0x9111;
	[Value("OBJECT_TYPE")]
	public const GLenum OBJECT_TYPE = 0x9112;
	[Value("SYNC_CONDITION")]
	public const GLenum SYNC_CONDITION = 0x9113;
	[Value("SYNC_STATUS")]
	public const GLenum SYNC_STATUS = 0x9114;
	[Value("SYNC_FLAGS")]
	public const GLenum SYNC_FLAGS = 0x9115;
	[Value("SYNC_FENCE")]
	public const GLenum SYNC_FENCE = 0x9116;
	[Value("SYNC_GPU_COMMANDS_COMPLETE")]
	public const GLenum SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
	[Value("UNSIGNALED")]
	public const GLenum UNSIGNALED = 0x9118;
	[Value("SIGNALED")]
	public const GLenum SIGNALED = 0x9119;
	[Value("ALREADY_SIGNALED")]
	public const GLenum ALREADY_SIGNALED = 0x911A;
	[Value("TIMEOUT_EXPIRED")]
	public const GLenum TIMEOUT_EXPIRED = 0x911B;
	[Value("CONDITION_SATISFIED")]
	public const GLenum CONDITION_SATISFIED = 0x911C;
	[Value("WAIT_FAILED")]
	public const GLenum WAIT_FAILED = 0x911D;
	[Value("SYNC_FLUSH_COMMANDS_BIT")]
	public const GLenum SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
	[Value("VERTEX_ATTRIB_ARRAY_DIVISOR")]
	public const GLenum VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;
	[Value("ANY_SAMPLES_PASSED")]
	public const GLenum ANY_SAMPLES_PASSED = 0x8C2F;
	[Value("ANY_SAMPLES_PASSED_CONSERVATIVE")]
	public const GLenum ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;
	[Value("SAMPLER_BINDING")]
	public const GLenum SAMPLER_BINDING = 0x8919;
	[Value("RGB10_A2UI")]
	public const GLenum RGB10_A2UI = 0x906F;
	[Value("INT_2_10_10_10_REV")]
	public const GLenum INT_2_10_10_10_REV = 0x8D9F;
	[Value("TRANSFORM_FEEDBACK")]
	public const GLenum TRANSFORM_FEEDBACK = 0x8E22;
	[Value("TRANSFORM_FEEDBACK_PAUSED")]
	public const GLenum TRANSFORM_FEEDBACK_PAUSED = 0x8E23;
	[Value("TRANSFORM_FEEDBACK_ACTIVE")]
	public const GLenum TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;
	[Value("TRANSFORM_FEEDBACK_BINDING")]
	public const GLenum TRANSFORM_FEEDBACK_BINDING = 0x8E25;
	[Value("TEXTURE_IMMUTABLE_FORMAT")]
	public const GLenum TEXTURE_IMMUTABLE_FORMAT = 0x912F;
	[Value("MAX_ELEMENT_INDEX")]
	public const GLenum MAX_ELEMENT_INDEX = 0x8D6B;
	[Value("TEXTURE_IMMUTABLE_LEVELS")]
	public const GLenum TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
	[Value("TIMEOUT_IGNORED")]
	public const GLint64 TIMEOUT_IGNORED = -1;
	[Value("MAX_CLIENT_WAIT_TIMEOUT_WEBGL")]
	public const GLenum MAX_CLIENT_WAIT_TIMEOUT_WEBGL = 0x9247;
	[Value("copyBufferSubData")]
	public Undefined CopyBufferSubData(GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size) { throw new System.NotImplementedException(); }
	[Value("getBufferSubData")]
	public Undefined GetBufferSubData(GLenum target, GLintptr srcByteOffset, ArrayBufferView dstBuffer, ulong dstOffset = default, GLuint length = default) { throw new System.NotImplementedException(); }
	[Value("blitFramebuffer")]
	public Undefined BlitFramebuffer(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter) { throw new System.NotImplementedException(); }
	[Value("framebufferTextureLayer")]
	public Undefined FramebufferTextureLayer(GLenum target, GLenum attachment, WebGLTexture? texture, GLint level, GLint layer) { throw new System.NotImplementedException(); }
	[Value("invalidateFramebuffer")]
	public Undefined InvalidateFramebuffer(GLenum target, List<GLenum> attachments) { throw new System.NotImplementedException(); }
	[Value("invalidateSubFramebuffer")]
	public Undefined InvalidateSubFramebuffer(GLenum target, List<GLenum> attachments, GLint x, GLint y, GLsizei width, GLsizei height) { throw new System.NotImplementedException(); }
	[Value("readBuffer")]
	public Undefined ReadBuffer(GLenum src) { throw new System.NotImplementedException(); }
	[Value("getInternalformatParameter")]
	public dynamic GetInternalformatParameter(GLenum target, GLenum internalformat, GLenum pname) { throw new System.NotImplementedException(); }
	[Value("renderbufferStorageMultisample")]
	public Undefined RenderbufferStorageMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height) { throw new System.NotImplementedException(); }
	[Value("texStorage2D")]
	public Undefined TexStorage2D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height) { throw new System.NotImplementedException(); }
	[Value("texStorage3D")]
	public Undefined TexStorage3D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth) { throw new System.NotImplementedException(); }
	[Value("texImage3D")]
	public Undefined TexImage3D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, GLintptr pboOffset) { throw new System.NotImplementedException(); }
	[Value("texImage3D")]
	public Undefined TexImage3D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, TexImageSource source) { throw new System.NotImplementedException(); }
	[Value("texImage3D")]
	public Undefined TexImage3D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, ArrayBufferView? srcData) { throw new System.NotImplementedException(); }
	[Value("texImage3D")]
	public Undefined TexImage3D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, ArrayBufferView srcData, ulong srcOffset) { throw new System.NotImplementedException(); }
	[Value("texSubImage3D")]
	public Undefined TexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, GLintptr pboOffset) { throw new System.NotImplementedException(); }
	[Value("texSubImage3D")]
	public Undefined TexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, TexImageSource source) { throw new System.NotImplementedException(); }
	[Value("texSubImage3D")]
	public Undefined TexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, ArrayBufferView? srcData, ulong srcOffset = default) { throw new System.NotImplementedException(); }
	[Value("copyTexSubImage3D")]
	public Undefined CopyTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height) { throw new System.NotImplementedException(); }
	[Value("compressedTexImage3D")]
	public Undefined CompressedTexImage3D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, GLintptr offset) { throw new System.NotImplementedException(); }
	[Value("compressedTexImage3D")]
	public Undefined CompressedTexImage3D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, ArrayBufferView srcData, ulong srcOffset = default, GLuint srcLengthOverride = default) { throw new System.NotImplementedException(); }
	[Value("compressedTexSubImage3D")]
	public Undefined CompressedTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, GLintptr offset) { throw new System.NotImplementedException(); }
	[Value("compressedTexSubImage3D")]
	public Undefined CompressedTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, ArrayBufferView srcData, ulong srcOffset = default, GLuint srcLengthOverride = default) { throw new System.NotImplementedException(); }
	[Value("getFragDataLocation")]
	public GLint GetFragDataLocation(WebGLProgram program, DOMString name) { throw new System.NotImplementedException(); }
	[Value("uniform1ui")]
	public Undefined Uniform1ui(WebGLUniformLocation? location, GLuint v0) { throw new System.NotImplementedException(); }
	[Value("uniform2ui")]
	public Undefined Uniform2ui(WebGLUniformLocation? location, GLuint v0, GLuint v1) { throw new System.NotImplementedException(); }
	[Value("uniform3ui")]
	public Undefined Uniform3ui(WebGLUniformLocation? location, GLuint v0, GLuint v1, GLuint v2) { throw new System.NotImplementedException(); }
	[Value("uniform4ui")]
	public Undefined Uniform4ui(WebGLUniformLocation? location, GLuint v0, GLuint v1, GLuint v2, GLuint v3) { throw new System.NotImplementedException(); }
	[Value("uniform1uiv")]
	public Undefined Uniform1uiv(WebGLUniformLocation? location, Uint32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniform2uiv")]
	public Undefined Uniform2uiv(WebGLUniformLocation? location, Uint32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniform3uiv")]
	public Undefined Uniform3uiv(WebGLUniformLocation? location, Uint32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniform4uiv")]
	public Undefined Uniform4uiv(WebGLUniformLocation? location, Uint32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniformMatrix3x2fv")]
	public Undefined UniformMatrix3x2fv(WebGLUniformLocation? location, bool transpose, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniformMatrix4x2fv")]
	public Undefined UniformMatrix4x2fv(WebGLUniformLocation? location, bool transpose, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniformMatrix2x3fv")]
	public Undefined UniformMatrix2x3fv(WebGLUniformLocation? location, bool transpose, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniformMatrix4x3fv")]
	public Undefined UniformMatrix4x3fv(WebGLUniformLocation? location, bool transpose, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniformMatrix2x4fv")]
	public Undefined UniformMatrix2x4fv(WebGLUniformLocation? location, bool transpose, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniformMatrix3x4fv")]
	public Undefined UniformMatrix3x4fv(WebGLUniformLocation? location, bool transpose, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("vertexAttribI4i")]
	public Undefined VertexAttribI4i(GLuint index, GLint x, GLint y, GLint z, GLint w) { throw new System.NotImplementedException(); }
	[Value("vertexAttribI4iv")]
	public Undefined VertexAttribI4iv(GLuint index, Int32List values) { throw new System.NotImplementedException(); }
	[Value("vertexAttribI4ui")]
	public Undefined VertexAttribI4ui(GLuint index, GLuint x, GLuint y, GLuint z, GLuint w) { throw new System.NotImplementedException(); }
	[Value("vertexAttribI4uiv")]
	public Undefined VertexAttribI4uiv(GLuint index, Uint32List values) { throw new System.NotImplementedException(); }
	[Value("vertexAttribIPointer")]
	public Undefined VertexAttribIPointer(GLuint index, GLint size, GLenum type, GLsizei stride, GLintptr offset) { throw new System.NotImplementedException(); }
	[Value("vertexAttribDivisor")]
	public Undefined VertexAttribDivisor(GLuint index, GLuint divisor) { throw new System.NotImplementedException(); }
	[Value("drawArraysInstanced")]
	public Undefined DrawArraysInstanced(GLenum mode, GLint first, GLsizei count, GLsizei instanceCount) { throw new System.NotImplementedException(); }
	[Value("drawElementsInstanced")]
	public Undefined DrawElementsInstanced(GLenum mode, GLsizei count, GLenum type, GLintptr offset, GLsizei instanceCount) { throw new System.NotImplementedException(); }
	[Value("drawRangeElements")]
	public Undefined DrawRangeElements(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, GLintptr offset) { throw new System.NotImplementedException(); }
	[Value("drawBuffers")]
	public Undefined DrawBuffers(List<GLenum> buffers) { throw new System.NotImplementedException(); }
	[Value("clearBufferfv")]
	public Undefined ClearBufferfv(GLenum buffer, GLint drawbuffer, Float32List values, ulong srcOffset = default) { throw new System.NotImplementedException(); }
	[Value("clearBufferiv")]
	public Undefined ClearBufferiv(GLenum buffer, GLint drawbuffer, Int32List values, ulong srcOffset = default) { throw new System.NotImplementedException(); }
	[Value("clearBufferuiv")]
	public Undefined ClearBufferuiv(GLenum buffer, GLint drawbuffer, Uint32List values, ulong srcOffset = default) { throw new System.NotImplementedException(); }
	[Value("clearBufferfi")]
	public Undefined ClearBufferfi(GLenum buffer, GLint drawbuffer, Number depth, GLint stencil) { throw new System.NotImplementedException(); }
	[Value("createQuery")]
	public WebGLQuery CreateQuery() { throw new System.NotImplementedException(); }
	[Value("deleteQuery")]
	public Undefined DeleteQuery(WebGLQuery? query) { throw new System.NotImplementedException(); }
	[Value("isQuery")]
	public bool IsQuery(WebGLQuery? query) { throw new System.NotImplementedException(); }
	[Value("beginQuery")]
	public Undefined BeginQuery(GLenum target, WebGLQuery query) { throw new System.NotImplementedException(); }
	[Value("endQuery")]
	public Undefined EndQuery(GLenum target) { throw new System.NotImplementedException(); }
	[Value("getQuery")]
	public WebGLQuery? GetQuery(GLenum target, GLenum pname) { throw new System.NotImplementedException(); }
	[Value("getQueryParameter")]
	public dynamic GetQueryParameter(WebGLQuery query, GLenum pname) { throw new System.NotImplementedException(); }
	[Value("createSampler")]
	public WebGLSampler CreateSampler() { throw new System.NotImplementedException(); }
	[Value("deleteSampler")]
	public Undefined DeleteSampler(WebGLSampler? sampler) { throw new System.NotImplementedException(); }
	[Value("isSampler")]
	public bool IsSampler(WebGLSampler? sampler) { throw new System.NotImplementedException(); }
	[Value("bindSampler")]
	public Undefined BindSampler(GLuint unit, WebGLSampler? sampler) { throw new System.NotImplementedException(); }
	[Value("samplerParameteri")]
	public Undefined SamplerParameteri(WebGLSampler sampler, GLenum pname, GLint param) { throw new System.NotImplementedException(); }
	[Value("samplerParameterf")]
	public Undefined SamplerParameterf(WebGLSampler sampler, GLenum pname, Number param) { throw new System.NotImplementedException(); }
	[Value("getSamplerParameter")]
	public dynamic GetSamplerParameter(WebGLSampler sampler, GLenum pname) { throw new System.NotImplementedException(); }
	[Value("fenceSync")]
	public WebGLSync? FenceSync(GLenum condition, GLbitfield flags) { throw new System.NotImplementedException(); }
	[Value("isSync")]
	public bool IsSync(WebGLSync? sync) { throw new System.NotImplementedException(); }
	[Value("deleteSync")]
	public Undefined DeleteSync(WebGLSync? sync) { throw new System.NotImplementedException(); }
	[Value("clientWaitSync")]
	public GLenum ClientWaitSync(WebGLSync sync, GLbitfield flags, GLuint64 timeout) { throw new System.NotImplementedException(); }
	[Value("waitSync")]
	public Undefined WaitSync(WebGLSync sync, GLbitfield flags, GLint64 timeout) { throw new System.NotImplementedException(); }
	[Value("getSyncParameter")]
	public dynamic GetSyncParameter(WebGLSync sync, GLenum pname) { throw new System.NotImplementedException(); }
	[Value("createTransformFeedback")]
	public WebGLTransformFeedback CreateTransformFeedback() { throw new System.NotImplementedException(); }
	[Value("deleteTransformFeedback")]
	public Undefined DeleteTransformFeedback(WebGLTransformFeedback? tf) { throw new System.NotImplementedException(); }
	[Value("isTransformFeedback")]
	public bool IsTransformFeedback(WebGLTransformFeedback? tf) { throw new System.NotImplementedException(); }
	[Value("bindTransformFeedback")]
	public Undefined BindTransformFeedback(GLenum target, WebGLTransformFeedback? tf) { throw new System.NotImplementedException(); }
	[Value("beginTransformFeedback")]
	public Undefined BeginTransformFeedback(GLenum primitiveMode) { throw new System.NotImplementedException(); }
	[Value("endTransformFeedback")]
	public Undefined EndTransformFeedback() { throw new System.NotImplementedException(); }
	[Value("transformFeedbackVaryings")]
	public Undefined TransformFeedbackVaryings(WebGLProgram program, List<DOMString> varyings, GLenum bufferMode) { throw new System.NotImplementedException(); }
	[Value("getTransformFeedbackVarying")]
	public WebGLActiveInfo? GetTransformFeedbackVarying(WebGLProgram program, GLuint index) { throw new System.NotImplementedException(); }
	[Value("pauseTransformFeedback")]
	public Undefined PauseTransformFeedback() { throw new System.NotImplementedException(); }
	[Value("resumeTransformFeedback")]
	public Undefined ResumeTransformFeedback() { throw new System.NotImplementedException(); }
	[Value("bindBufferBase")]
	public Undefined BindBufferBase(GLenum target, GLuint index, WebGLBuffer? buffer) { throw new System.NotImplementedException(); }
	[Value("bindBufferRange")]
	public Undefined BindBufferRange(GLenum target, GLuint index, WebGLBuffer? buffer, GLintptr offset, GLsizeiptr size) { throw new System.NotImplementedException(); }
	[Value("getIndexedParameter")]
	public dynamic GetIndexedParameter(GLenum target, GLuint index) { throw new System.NotImplementedException(); }
	[Value("getUniformIndices")]
	public List<GLuint>? GetUniformIndices(WebGLProgram program, List<DOMString> uniformNames) { throw new System.NotImplementedException(); }
	[Value("getActiveUniforms")]
	public dynamic GetActiveUniforms(WebGLProgram program, List<GLuint> uniformIndices, GLenum pname) { throw new System.NotImplementedException(); }
	[Value("getUniformBlockIndex")]
	public GLuint GetUniformBlockIndex(WebGLProgram program, DOMString uniformBlockName) { throw new System.NotImplementedException(); }
	[Value("getActiveUniformBlockParameter")]
	public dynamic GetActiveUniformBlockParameter(WebGLProgram program, GLuint uniformBlockIndex, GLenum pname) { throw new System.NotImplementedException(); }
	[Value("getActiveUniformBlockName")]
	public DOMString? GetActiveUniformBlockName(WebGLProgram program, GLuint uniformBlockIndex) { throw new System.NotImplementedException(); }
	[Value("uniformBlockBinding")]
	public Undefined UniformBlockBinding(WebGLProgram program, GLuint uniformBlockIndex, GLuint uniformBlockBinding) { throw new System.NotImplementedException(); }
	[Value("createVertexArray")]
	public WebGLVertexArrayObject CreateVertexArray() { throw new System.NotImplementedException(); }
	[Value("deleteVertexArray")]
	public Undefined DeleteVertexArray(WebGLVertexArrayObject? vertexArray) { throw new System.NotImplementedException(); }
	[Value("isVertexArray")]
	public bool IsVertexArray(WebGLVertexArrayObject? vertexArray) { throw new System.NotImplementedException(); }
	[Value("bindVertexArray")]
	public Undefined BindVertexArray(WebGLVertexArrayObject? array) { throw new System.NotImplementedException(); }
}

[Value("WebGL2RenderingContextOverloads")]
public partial interface WebGL2RenderingContextOverloads
{
	[Value("bufferData")]
	public Undefined BufferData(GLenum target, GLsizeiptr size, GLenum usage) { throw new System.NotImplementedException(); }
	[Value("bufferData")]
	public Undefined BufferData(GLenum target, AllowSharedBufferSource? srcData, GLenum usage) { throw new System.NotImplementedException(); }
	[Value("bufferSubData")]
	public Undefined BufferSubData(GLenum target, GLintptr dstByteOffset, AllowSharedBufferSource srcData) { throw new System.NotImplementedException(); }
	[Value("bufferData")]
	public Undefined BufferData(GLenum target, ArrayBufferView srcData, GLenum usage, ulong srcOffset, GLuint length = default) { throw new System.NotImplementedException(); }
	[Value("bufferSubData")]
	public Undefined BufferSubData(GLenum target, GLintptr dstByteOffset, ArrayBufferView srcData, ulong srcOffset, GLuint length = default) { throw new System.NotImplementedException(); }
	[Value("texImage2D")]
	public Undefined TexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, ArrayBufferView? pixels) { throw new System.NotImplementedException(); }
	[Value("texImage2D")]
	public Undefined TexImage2D(GLenum target, GLint level, GLint internalformat, GLenum format, GLenum type, TexImageSource source) { throw new System.NotImplementedException(); }
	[Value("texSubImage2D")]
	public Undefined TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, ArrayBufferView? pixels) { throw new System.NotImplementedException(); }
	[Value("texSubImage2D")]
	public Undefined TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLenum format, GLenum type, TexImageSource source) { throw new System.NotImplementedException(); }
	[Value("texImage2D")]
	public Undefined TexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, GLintptr pboOffset) { throw new System.NotImplementedException(); }
	[Value("texImage2D")]
	public Undefined TexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, TexImageSource source) { throw new System.NotImplementedException(); }
	[Value("texImage2D")]
	public Undefined TexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, ArrayBufferView srcData, ulong srcOffset) { throw new System.NotImplementedException(); }
	[Value("texSubImage2D")]
	public Undefined TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, GLintptr pboOffset) { throw new System.NotImplementedException(); }
	[Value("texSubImage2D")]
	public Undefined TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, TexImageSource source) { throw new System.NotImplementedException(); }
	[Value("texSubImage2D")]
	public Undefined TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, ArrayBufferView srcData, ulong srcOffset) { throw new System.NotImplementedException(); }
	[Value("compressedTexImage2D")]
	public Undefined CompressedTexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, GLintptr offset) { throw new System.NotImplementedException(); }
	[Value("compressedTexImage2D")]
	public Undefined CompressedTexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, ArrayBufferView srcData, ulong srcOffset = default, GLuint srcLengthOverride = default) { throw new System.NotImplementedException(); }
	[Value("compressedTexSubImage2D")]
	public Undefined CompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, GLintptr offset) { throw new System.NotImplementedException(); }
	[Value("compressedTexSubImage2D")]
	public Undefined CompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, ArrayBufferView srcData, ulong srcOffset = default, GLuint srcLengthOverride = default) { throw new System.NotImplementedException(); }
	[Value("uniform1fv")]
	public Undefined Uniform1fv(WebGLUniformLocation? location, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniform2fv")]
	public Undefined Uniform2fv(WebGLUniformLocation? location, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniform3fv")]
	public Undefined Uniform3fv(WebGLUniformLocation? location, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniform4fv")]
	public Undefined Uniform4fv(WebGLUniformLocation? location, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniform1iv")]
	public Undefined Uniform1iv(WebGLUniformLocation? location, Int32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniform2iv")]
	public Undefined Uniform2iv(WebGLUniformLocation? location, Int32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniform3iv")]
	public Undefined Uniform3iv(WebGLUniformLocation? location, Int32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniform4iv")]
	public Undefined Uniform4iv(WebGLUniformLocation? location, Int32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniformMatrix2fv")]
	public Undefined UniformMatrix2fv(WebGLUniformLocation? location, bool transpose, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniformMatrix3fv")]
	public Undefined UniformMatrix3fv(WebGLUniformLocation? location, bool transpose, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("uniformMatrix4fv")]
	public Undefined UniformMatrix4fv(WebGLUniformLocation? location, bool transpose, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
	[Value("readPixels")]
	public Undefined ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, ArrayBufferView? dstData) { throw new System.NotImplementedException(); }
	[Value("readPixels")]
	public Undefined ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLintptr offset) { throw new System.NotImplementedException(); }
	[Value("readPixels")]
	public Undefined ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, ArrayBufferView dstData, ulong dstOffset) { throw new System.NotImplementedException(); }
}

[Value("GPUObjectBase")]
public partial interface GPUObjectBase
{
	[Value("label")]
	public USVString Label { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NavigatorGPU/NavigatorGPU.generated.xml' path='docs/NavigatorGPU/*'/>
[Value("NavigatorGPU")]
public partial interface NavigatorGPU
{
	[Value("gpu")]
	public GPU Gpu { get { throw new System.NotImplementedException(); } }
}



[Value("GPUPipelineBase")]
public partial interface GPUPipelineBase
{
	[Value("getBindGroupLayout")]
	public GPUBindGroupLayout GetBindGroupLayout(ulong index) { throw new System.NotImplementedException(); }
}

[Value("GPUCommandsMixin")]
public partial interface GPUCommandsMixin
{
}

[Value("GPUBindingCommandsMixin")]
public partial interface GPUBindingCommandsMixin
{
	[Value("setBindGroup")]
	public Undefined SetBindGroup(GPUIndex32 index, GPUBindGroup? bindGroup, List<GPUBufferDynamicOffset> dynamicOffsets = default) { throw new System.NotImplementedException(); }
	[Value("setBindGroup")]
	public Undefined SetBindGroup(GPUIndex32 index, GPUBindGroup? bindGroup, Uint32Array dynamicOffsetsData, GPUSize64 dynamicOffsetsDataStart, GPUSize32 dynamicOffsetsDataLength) { throw new System.NotImplementedException(); }
}

[Value("GPUDebugCommandsMixin")]
public partial interface GPUDebugCommandsMixin
{
	[Value("pushDebugGroup")]
	public Undefined PushDebugGroup(USVString groupLabel) { throw new System.NotImplementedException(); }
	[Value("popDebugGroup")]
	public Undefined PopDebugGroup() { throw new System.NotImplementedException(); }
	[Value("insertDebugMarker")]
	public Undefined InsertDebugMarker(USVString markerLabel) { throw new System.NotImplementedException(); }
}

[Value("GPURenderCommandsMixin")]
public partial interface GPURenderCommandsMixin
{
	[Value("setPipeline")]
	public Undefined SetPipeline(GPURenderPipeline pipeline) { throw new System.NotImplementedException(); }
	[Value("setIndexBuffer")]
	public Undefined SetIndexBuffer(GPUBuffer buffer, GPUIndexFormat indexFormat, GPUSize64 offset = default, GPUSize64 size = default) { throw new System.NotImplementedException(); }
	[Value("setVertexBuffer")]
	public Undefined SetVertexBuffer(GPUIndex32 slot, GPUBuffer? buffer, GPUSize64 offset = default, GPUSize64 size = default) { throw new System.NotImplementedException(); }
	[Value("draw")]
	public Undefined Draw(GPUSize32 vertexCount, GPUSize32 instanceCount = default, GPUSize32 firstVertex = default, GPUSize32 firstInstance = default) { throw new System.NotImplementedException(); }
	[Value("drawIndexed")]
	public Undefined DrawIndexed(GPUSize32 indexCount, GPUSize32 instanceCount = default, GPUSize32 firstIndex = default, GPUSignedOffset32 baseVertex = default, GPUSize32 firstInstance = default) { throw new System.NotImplementedException(); }
	[Value("drawIndirect")]
	public Undefined DrawIndirect(GPUBuffer indirectBuffer, GPUSize64 indirectOffset) { throw new System.NotImplementedException(); }
	[Value("drawIndexedIndirect")]
	public Undefined DrawIndexedIndirect(GPUBuffer indirectBuffer, GPUSize64 indirectOffset) { throw new System.NotImplementedException(); }
}

[Value("NavigatorML")]
public partial interface NavigatorML
{
	[Value("ml")]
	public ML Ml { get { throw new System.NotImplementedException(); } }
}



public partial interface GlobalEventHandlers
{
	[Value("onbeforexrselect")]
	public EventHandler Onbeforexrselect { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

public partial interface WebGLRenderingContextBase
{
	[Value("makeXRCompatible")]
	public Task<Undefined> MakeXRCompatible() { throw new System.NotImplementedException(); }
}

