//01.05.2025 20:45:13

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


[To(ToAttribute.FirstCharToLowerCase)]
public partial interface HTMLAttributionSrcElementUtils
{
		public USVString AttributionSrc { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}





[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorBadge
{
		public Task<Undefined> SetAppBadge(ulong contents = default) { throw new System.NotImplementedException(); }
		public Task<Undefined> ClearAppBadge() { throw new System.NotImplementedException(); }
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CredentialUserData
{
		public USVString Name { get { throw new System.NotImplementedException(); } }
		public USVString IconURL { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GlobalEventHandlers
{
		public EventHandler Onanimationstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onanimationiteration { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onanimationend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onanimationcancel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface FontFaceSource
{
		public FontFaceSet Fonts { get { throw new System.NotImplementedException(); } }
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial interface Region
{
		public CSSOMString RegionOverset { get { throw new System.NotImplementedException(); } }
		public List<Range>? GetRegionFlowRanges() { throw new System.NotImplementedException(); }
}


public partial interface GlobalEventHandlers
{
		public EventHandler Onsnapchanged { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onsnapchanging { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

public partial interface GlobalEventHandlers
{
		public EventHandler Ontransitionrun { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ontransitionstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ontransitionend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ontransitioncancel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface ElementCSSInlineStyle
{
		public StylePropertyMap AttributeStyleMap { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GeometryUtils
{
		public List<DOMQuad> GetBoxQuads(BoxQuadOptions options = default) { throw new System.NotImplementedException(); }
		public DOMQuad ConvertQuadFromNode(DOMQuadInit quad, GeometryNode from, ConvertCoordinateOptions options = default) { throw new System.NotImplementedException(); }
		public DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, GeometryNode from, ConvertCoordinateOptions options = default) { throw new System.NotImplementedException(); }
		public DOMPoint ConvertPointFromNode(DOMPointInit point, GeometryNode from, ConvertCoordinateOptions options = default) { throw new System.NotImplementedException(); }
}






[To(ToAttribute.FirstCharToLowerCase)]
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


public partial interface ElementCSSInlineStyle
{
		public CSSStyleDeclaration Style { get { throw new System.NotImplementedException(); } }
}




///<include file='Utils/Docs/NavigatorDeviceMemory/NavigatorDeviceMemory.generated.xml' path='docs/NavigatorDeviceMemory/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorDeviceMemory
{
		public Number DeviceMemory { get { throw new System.NotImplementedException(); } }
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial interface EventListener
{
		public Undefined HandleEvent(Event event_) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Document/Document.generated.xml' path='docs/Document/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NonElementParentNode
{
	///<include file='Utils/Docs/DocumentGetElementById/DocumentGetElementById.generated.xml' path='docs/DocumentGetElementById/*'/>
	public Element? GetElementById(DOMString elementId) { throw new System.NotImplementedException(); }
}



public partial interface DocumentOrShadowRoot
{
}



///<include file='Utils/Docs/Element/Element.generated.xml' path='docs/Element/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface ParentNode
{
	///<include file='Utils/Docs/ElementChildren/ElementChildren.generated.xml' path='docs/ElementChildren/*'/>
	public HTMLCollection Children { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/ElementFirstElementChild/ElementFirstElementChild.generated.xml' path='docs/ElementFirstElementChild/*'/>
	public Element? FirstElementChild { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/ElementLastElementChild/ElementLastElementChild.generated.xml' path='docs/ElementLastElementChild/*'/>
	public Element? LastElementChild { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/ElementChildElementCount/ElementChildElementCount.generated.xml' path='docs/ElementChildElementCount/*'/>
	public ulong ChildElementCount { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/ElementPrepend/ElementPrepend.generated.xml' path='docs/ElementPrepend/*'/>
	public Undefined Prepend(params Union28[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementAppend/ElementAppend.generated.xml' path='docs/ElementAppend/*'/>
	public Undefined Append(params Union29[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementReplaceChildren/ElementReplaceChildren.generated.xml' path='docs/ElementReplaceChildren/*'/>
	public Undefined ReplaceChildren(params Union30[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementQuerySelector/ElementQuerySelector.generated.xml' path='docs/ElementQuerySelector/*'/>
	public Element? QuerySelector(DOMString selectors) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementQuerySelectorAll/ElementQuerySelectorAll.generated.xml' path='docs/ElementQuerySelectorAll/*'/>
	public NodeList QuerySelectorAll(DOMString selectors) { throw new System.NotImplementedException(); }
}




[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NonDocumentTypeChildNode
{
		public Element? PreviousElementSibling { get { throw new System.NotImplementedException(); } }
		public Element? NextElementSibling { get { throw new System.NotImplementedException(); } }
}



///<include file='Utils/Docs/Element/Element.generated.xml' path='docs/Element/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface ChildNode
{
	///<include file='Utils/Docs/ElementBefore/ElementBefore.generated.xml' path='docs/ElementBefore/*'/>
	public Undefined Before(params Union31[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementAfter/ElementAfter.generated.xml' path='docs/ElementAfter/*'/>
	public Undefined After(params Union32[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementReplaceWith/ElementReplaceWith.generated.xml' path='docs/ElementReplaceWith/*'/>
	public Undefined ReplaceWith(params Union33[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementRemove/ElementRemove.generated.xml' path='docs/ElementRemove/*'/>
	public Undefined Remove() { throw new System.NotImplementedException(); }
}




[To(ToAttribute.FirstCharToLowerCase)]
public partial interface Slottable
{
		public HTMLSlotElement? AssignedSlot { get { throw new System.NotImplementedException(); } }
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

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface XPathNSResolver
{
		public DOMString? LookupNamespaceURI(DOMString? prefix) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface XPathEvaluatorBase
{
		public XPathExpression CreateExpression(DOMString expression, XPathNSResolver? resolver = default) { throw new System.NotImplementedException(); }
		public Node CreateNSResolver(Node nodeResolver) { throw new System.NotImplementedException(); }
		public XPathResult Evaluate(DOMString expression, Node contextNode, XPathNSResolver? resolver = default, ushort type = default, XPathResult? result = default) { throw new System.NotImplementedException(); }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial interface TextDecoderCommon
{
		public DOMString Encoding { get { throw new System.NotImplementedException(); } }
		public bool Fatal { get { throw new System.NotImplementedException(); } }
		public bool IgnoreBOM { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface TextEncoderCommon
{
		public DOMString Encoding { get { throw new System.NotImplementedException(); } }
}

public partial interface GlobalEventHandlers
{
		public EventHandler Onfencedtreeclick { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial interface Body
{
		public ReadableStream? Body { get { throw new System.NotImplementedException(); } }
		public bool BodyUsed { get { throw new System.NotImplementedException(); } }
		public Task<byte[]> ArrayBuffer() { throw new System.NotImplementedException(); }
		public Task<Blob> Blob() { throw new System.NotImplementedException(); }
		public Task<Uint8Array> Bytes() { throw new System.NotImplementedException(); }
		public Task<FormData> FormData() { throw new System.NotImplementedException(); }
		public Task<dynamic> Json() { throw new System.NotImplementedException(); }
		public Task<USVString> Text() { throw new System.NotImplementedException(); }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial interface WindowOrWorkerGlobalScope
{
		public Task<Response> Fetch(RequestInfo input, RequestInit init = default) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface SVGFilterPrimitiveStandardAttributes
{
		public SVGAnimatedLength X { get { throw new System.NotImplementedException(); } }
		public SVGAnimatedLength Y { get { throw new System.NotImplementedException(); } }
		public SVGAnimatedLength Width { get { throw new System.NotImplementedException(); } }
		public SVGAnimatedLength Height { get { throw new System.NotImplementedException(); } }
		public SVGAnimatedString Result { get { throw new System.NotImplementedException(); } }
}

public partial interface DocumentOrShadowRoot
{
		public Element? FullscreenElement { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface WindowEventHandlers
{
		public EventHandler Ongamepadconnected { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ongamepaddisconnected { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GlobalPrivacyControl
{
		public bool GlobalPrivacyControl { get { throw new System.NotImplementedException(); } }
}



public partial interface WindowOrWorkerGlobalScope
{
		public Performance Performance { get { throw new System.NotImplementedException(); } }
}

public partial interface DocumentOrShadowRoot
{
		public Element? ActiveElement { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface HTMLOrSVGElement
{
		public DOMStringMap Dataset { get { throw new System.NotImplementedException(); } }
		public DOMString Nonce { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public bool Autofocus { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public long TabIndex { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public Undefined Focus(FocusOptions options = default) { throw new System.NotImplementedException(); }
		public Undefined Blur() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface HTMLHyperlinkElementUtils
{
		public USVString Href { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public USVString Origin { get { throw new System.NotImplementedException(); } }
		public USVString Protocol { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public USVString Username { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public USVString Password { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public USVString Host { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public USVString Hostname { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public USVString Port { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public USVString Pathname { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public USVString Search { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public USVString Hash { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
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
		public Undefined SetTransform(DOMMatrix2DInit transform = default) { throw new System.NotImplementedException(); }
		public Undefined ResetTransform() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasCompositing
{
		public double GlobalAlpha { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString GlobalCompositeOperation { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
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
		public Union73 StrokeStyle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public Union74 FillStyle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasGradient CreateLinearGradient(Number x0, Number y0, Number x1, Number y1) { throw new System.NotImplementedException(); }
		public CanvasGradient CreateRadialGradient(Number x0, Number y0, Number r0, Number x1, Number y1, Number r1) { throw new System.NotImplementedException(); }
		public CanvasGradient CreateConicGradient(Number startAngle, Number x, Number y) { throw new System.NotImplementedException(); }
		public CanvasPattern? CreatePattern(CanvasImageSource image, DOMString repetition) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasShadowStyles
{
		public double ShadowOffsetX { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public double ShadowOffsetY { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public double ShadowBlur { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString ShadowColor { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasFilters
{
		public DOMString Filter { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
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
		public Undefined Fill(CanvasFillRule fillRule = default) { throw new System.NotImplementedException(); }
		public Undefined Fill(Path2D path, CanvasFillRule fillRule = default) { throw new System.NotImplementedException(); }
		public Undefined Stroke() { throw new System.NotImplementedException(); }
		public Undefined Stroke(Path2D path) { throw new System.NotImplementedException(); }
		public Undefined Clip(CanvasFillRule fillRule = default) { throw new System.NotImplementedException(); }
		public Undefined Clip(Path2D path, CanvasFillRule fillRule = default) { throw new System.NotImplementedException(); }
		public bool IsPointInPath(double x, double y, CanvasFillRule fillRule = default) { throw new System.NotImplementedException(); }
		public bool IsPointInPath(Path2D path, double x, double y, CanvasFillRule fillRule = default) { throw new System.NotImplementedException(); }
		public bool IsPointInStroke(double x, double y) { throw new System.NotImplementedException(); }
		public bool IsPointInStroke(Path2D path, double x, double y) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasUserInterface
{
		public Undefined DrawFocusIfNeeded(Element element) { throw new System.NotImplementedException(); }
		public Undefined DrawFocusIfNeeded(Path2D path, Element element) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasText
{
		public Undefined FillText(DOMString text, double x, double y, double maxWidth = default) { throw new System.NotImplementedException(); }
		public Undefined StrokeText(DOMString text, double x, double y, double maxWidth = default) { throw new System.NotImplementedException(); }
		public TextMetrics MeasureText(DOMString text) { throw new System.NotImplementedException(); }
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
		public ImageData CreateImageData(long sw, long sh, ImageDataSettings settings = default) { throw new System.NotImplementedException(); }
		public ImageData CreateImageData(ImageData imagedata) { throw new System.NotImplementedException(); }
		public ImageData GetImageData(long sx, long sy, long sw, long sh, ImageDataSettings settings = default) { throw new System.NotImplementedException(); }
		public Undefined PutImageData(ImageData imagedata, long dx, long dy) { throw new System.NotImplementedException(); }
		public Undefined PutImageData(ImageData imagedata, long dx, long dy, long dirtyX, long dirtyY, long dirtyWidth, long dirtyHeight) { throw new System.NotImplementedException(); }
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
		public DOMString Font { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasTextAlign TextAlign { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasTextBaseline TextBaseline { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasDirection Direction { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString LetterSpacing { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasFontKerning FontKerning { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasFontStretch FontStretch { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasFontVariantCaps FontVariantCaps { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasTextRendering TextRendering { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString WordSpacing { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
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
		public Undefined RoundRect(double x, double y, double w, double h, Union75 radii = default) { throw new System.NotImplementedException(); }
		public Undefined Arc(double x, double y, double radius, double startAngle, double endAngle, bool counterclockwise = default) { throw new System.NotImplementedException(); }
		public Undefined Ellipse(double x, double y, double radiusX, double radiusY, double rotation, double startAngle, double endAngle, bool counterclockwise = default) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface ElementContentEditable
{
		public DOMString ContentEditable { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString EnterKeyHint { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public bool IsContentEditable { get { throw new System.NotImplementedException(); } }
		public DOMString InputMode { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface PopoverInvokerElement
{
		public Element? PopoverTargetElement { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString PopoverTargetAction { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

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
		public EventHandler Onpagereveal { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpageshow { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpageswap { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpopstate { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onrejectionhandled { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onstorage { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onunhandledrejection { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onunload { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}


public partial interface WindowOrWorkerGlobalScope
{
		public USVString Origin { get { throw new System.NotImplementedException(); } }
		public bool IsSecureContext { get { throw new System.NotImplementedException(); } }
		public bool CrossOriginIsolated { get { throw new System.NotImplementedException(); } }
		public Undefined ReportError(dynamic e) { throw new System.NotImplementedException(); }
		public DOMString Btoa(DOMString data) { throw new System.NotImplementedException(); }
		public ByteString Atob(DOMString data) { throw new System.NotImplementedException(); }
		public long SetTimeout(TimerHandler handler, long timeout = default, params dynamic[] arguments) { throw new System.NotImplementedException(); }
		public Undefined ClearTimeout(long id = default) { throw new System.NotImplementedException(); }
		public long SetInterval(TimerHandler handler, long timeout = default, params dynamic[] arguments) { throw new System.NotImplementedException(); }
		public Undefined ClearInterval(long id = default) { throw new System.NotImplementedException(); }
		public Undefined QueueMicrotask(VoidFunction callback) { throw new System.NotImplementedException(); }
		public Task<ImageBitmap> CreateImageBitmap(ImageBitmapSource image, ImageBitmapOptions options = default) { throw new System.NotImplementedException(); }
		public Task<ImageBitmap> CreateImageBitmap(ImageBitmapSource image, long sx, long sy, long sw, long sh, ImageBitmapOptions options = default) { throw new System.NotImplementedException(); }
		public dynamic StructuredClone(dynamic value, StructuredSerializeOptions options = default) { throw new System.NotImplementedException(); }
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorID
{
		public DOMString AppCodeName { get { throw new System.NotImplementedException(); } }
		public DOMString AppName { get { throw new System.NotImplementedException(); } }
		public DOMString AppVersion { get { throw new System.NotImplementedException(); } }
		public DOMString Platform { get { throw new System.NotImplementedException(); } }
		public DOMString Product { get { throw new System.NotImplementedException(); } }
		public DOMString ProductSub { get { throw new System.NotImplementedException(); } }
		public DOMString UserAgent { get { throw new System.NotImplementedException(); } }
		public DOMString Vendor { get { throw new System.NotImplementedException(); } }
		public DOMString VendorSub { get { throw new System.NotImplementedException(); } }
}

public partial interface NavigatorID
{
		public bool TaintEnabled() { throw new System.NotImplementedException(); }
		public DOMString Oscpu { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NavigatorLanguage/NavigatorLanguage.generated.xml' path='docs/NavigatorLanguage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorLanguage
{
		public DOMString Language { get { throw new System.NotImplementedException(); } }
		public DOMString[] Languages { get { throw new System.NotImplementedException(); } }
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
		public Undefined RegisterProtocolHandler(DOMString scheme, USVString url) { throw new System.NotImplementedException(); }
		public Undefined UnregisterProtocolHandler(DOMString scheme, USVString url) { throw new System.NotImplementedException(); }
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

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface AnimationFrameProvider
{
		public ulong RequestAnimationFrame(FrameRequestCallback callback) { throw new System.NotImplementedException(); }
		public Undefined CancelAnimationFrame(ulong handle) { throw new System.NotImplementedException(); }
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial interface MessageEventTarget
{
		public EventHandler Onmessage { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmessageerror { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface AbstractWorker
{
		public EventHandler Onerror { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorConcurrentHardware
{
		public ulong HardwareConcurrency { get { throw new System.NotImplementedException(); } }
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


public partial interface WindowOrWorkerGlobalScope
{
		public IDBFactory IndexedDB { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorNetworkInformation
{
		public NetworkInformation Connection { get { throw new System.NotImplementedException(); } }
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial interface PaintTimingMixin
{
		public DOMHighResTimeStamp PaintTime { get { throw new System.NotImplementedException(); } }
		public DOMHighResTimeStamp? PresentationTime { get { throw new System.NotImplementedException(); } }
}

public partial interface DocumentOrShadowRoot
{
		public Element? PictureInPictureElement { get { throw new System.NotImplementedException(); } }
}

public partial interface GlobalEventHandlers
{
		public EventHandler Onpointerover { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpointerenter { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpointerdown { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpointermove { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpointerrawupdate { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpointerup { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpointercancel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpointerout { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpointerleave { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ongotpointercapture { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onlostpointercapture { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

public partial interface DocumentOrShadowRoot
{
		public Element? PointerLockElement { get { throw new System.NotImplementedException(); } }
}

public partial interface WindowEventHandlers
{
		public EventHandler Onportalactivate { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NetworkInformationSaveData/NetworkInformationSaveData.generated.xml' path='docs/NetworkInformationSaveData/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NetworkInformationSaveData
{
		public bool SaveData { get { throw new System.NotImplementedException(); } }
}


public partial interface WindowOrWorkerGlobalScope
{
		public Scheduler Scheduler { get { throw new System.NotImplementedException(); } }
}

public partial interface GlobalEventHandlers
{
		public EventHandler Onselectstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onselectionchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

public partial interface WindowOrWorkerGlobalScope
{
		public CacheStorage Caches { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface HTMLSharedStorageWritableElementUtils
{
		public bool SharedStorageWritable { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorStorageBuckets
{
		public StorageBucketManager StorageBuckets { get { throw new System.NotImplementedException(); } }
}



///<include file='Utils/Docs/NavigatorStorage/NavigatorStorage.generated.xml' path='docs/NavigatorStorage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorStorage
{
		public StorageManager Storage { get { throw new System.NotImplementedException(); } }
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial interface ReadableStreamGenericReader
{
		public Task<Undefined> Closed { get { throw new System.NotImplementedException(); } }
		public Task<Undefined> Cancel(dynamic reason = default) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GenericTransformStream
{
		public ReadableStream Readable { get { throw new System.NotImplementedException(); } }
		public WritableStream Writable { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface SVGTests
{
		public SVGStringList RequiredExtensions { get { throw new System.NotImplementedException(); } }
		public SVGStringList SystemLanguage { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface SVGFitToViewBox
{
		public SVGAnimatedRect ViewBox { get { throw new System.NotImplementedException(); } }
		public SVGAnimatedPreserveAspectRatio PreserveAspectRatio { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface SVGURIReference
{
		public SVGAnimatedString Href { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface SVGElementInstance
{
		public SVGElement? CorrespondingElement { get { throw new System.NotImplementedException(); } }
		public SVGUseElement? CorrespondingUseElement { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GetSVGDocument
{
		public Document GetSVGDocument() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface SVGAnimatedPoints
{
		public SVGPointList Points { get { throw new System.NotImplementedException(); } }
		public SVGPointList AnimatedPoints { get { throw new System.NotImplementedException(); } }
}

public partial interface GlobalEventHandlers
{
		public EventHandler Ontouchstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ontouchend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ontouchmove { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ontouchcancel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

public partial interface WindowOrWorkerGlobalScope
{
		public TrustedTypePolicyFactory TrustedTypes { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorUA
{
		public NavigatorUAData UserAgentData { get { throw new System.NotImplementedException(); } }
}



public partial interface ElementContentEditable
{
		public DOMString VirtualKeyboardPolicy { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface ARIAMixin
{
		public DOMString? Role { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public Element? AriaActiveDescendantElement { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaAtomic { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaAutoComplete { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaBrailleLabel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaBrailleRoleDescription { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaBusy { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaChecked { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaColCount { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaColIndex { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaColIndexText { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaColSpan { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public Element[]? AriaControlsElements { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaCurrent { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public Element[]? AriaDescribedByElements { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaDescription { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public Element[]? AriaDetailsElements { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaDisabled { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public Element[]? AriaErrorMessageElements { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaExpanded { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public Element[]? AriaFlowToElements { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaHasPopup { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaHidden { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaInvalid { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaKeyShortcuts { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaLabel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public Element[]? AriaLabelledByElements { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaLevel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaLive { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaModal { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaMultiLine { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaMultiSelectable { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaOrientation { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public Element[]? AriaOwnsElements { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaPlaceholder { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaPosInSet { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaPressed { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaReadOnly { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaRelevant { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaRequired { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaRoleDescription { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaRowCount { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaRowIndex { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaRowIndexText { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaRowSpan { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaSelected { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaSetSize { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaSort { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaValueMax { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaValueMin { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaValueNow { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public DOMString? AriaValueText { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial interface Animatable
{
		public Animation Animate(Object? keyframes, Union171 options = default) { throw new System.NotImplementedException(); }
		public List<Animation> GetAnimations(GetAnimationsOptions options = default) { throw new System.NotImplementedException(); }
}

public partial interface DocumentOrShadowRoot
{
		public List<Animation> GetAnimations() { throw new System.NotImplementedException(); }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CharacteristicEventHandlers
{
		public EventHandler Oncharacteristicvaluechanged { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface BluetoothDeviceEventHandlers
{
		public EventHandler Onadvertisementreceived { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ongattserverdisconnected { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface ServiceEventHandlers
{
		public EventHandler Onserviceadded { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onservicechanged { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onserviceremoved { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}


///<include file='Utils/Docs/NavigatorLocks/NavigatorLocks.generated.xml' path='docs/NavigatorLocks/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorLocks
{
		public LockManager Locks { get { throw new System.NotImplementedException(); } }
}



public partial interface WindowOrWorkerGlobalScope
{
		public Crypto Crypto { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorAutomationInformation
{
		public bool Webdriver { get { throw new System.NotImplementedException(); } }
}
















[To(ToAttribute.FirstCharToLowerCase)]
public partial interface WebGLRenderingContextBase
{
		public const GLenum DEPTH_BUFFER_BIT = 0x00000100;
		public const GLenum STENCIL_BUFFER_BIT = 0x00000400;
		public const GLenum COLOR_BUFFER_BIT = 0x00004000;
		public const GLenum POINTS = 0x0000;
		public const GLenum LINES = 0x0001;
		public const GLenum LINE_LOOP = 0x0002;
		public const GLenum LINE_STRIP = 0x0003;
		public const GLenum TRIANGLES = 0x0004;
		public const GLenum TRIANGLE_STRIP = 0x0005;
		public const GLenum TRIANGLE_FAN = 0x0006;
		public const GLenum ZERO = 0;
		public const GLenum ONE = 1;
		public const GLenum SRC_COLOR = 0x0300;
		public const GLenum ONE_MINUS_SRC_COLOR = 0x0301;
		public const GLenum SRC_ALPHA = 0x0302;
		public const GLenum ONE_MINUS_SRC_ALPHA = 0x0303;
		public const GLenum DST_ALPHA = 0x0304;
		public const GLenum ONE_MINUS_DST_ALPHA = 0x0305;
		public const GLenum DST_COLOR = 0x0306;
		public const GLenum ONE_MINUS_DST_COLOR = 0x0307;
		public const GLenum SRC_ALPHA_SATURATE = 0x0308;
		public const GLenum FUNC_ADD = 0x8006;
		public const GLenum BLEND_EQUATION = 0x8009;
		public const GLenum BLEND_EQUATION_RGB = 0x8009;
		public const GLenum BLEND_EQUATION_ALPHA = 0x883D;
		public const GLenum FUNC_SUBTRACT = 0x800A;
		public const GLenum FUNC_REVERSE_SUBTRACT = 0x800B;
		public const GLenum BLEND_DST_RGB = 0x80C8;
		public const GLenum BLEND_SRC_RGB = 0x80C9;
		public const GLenum BLEND_DST_ALPHA = 0x80CA;
		public const GLenum BLEND_SRC_ALPHA = 0x80CB;
		public const GLenum CONSTANT_COLOR = 0x8001;
		public const GLenum ONE_MINUS_CONSTANT_COLOR = 0x8002;
		public const GLenum CONSTANT_ALPHA = 0x8003;
		public const GLenum ONE_MINUS_CONSTANT_ALPHA = 0x8004;
		public const GLenum BLEND_COLOR = 0x8005;
		public const GLenum ARRAY_BUFFER = 0x8892;
		public const GLenum ELEMENT_ARRAY_BUFFER = 0x8893;
		public const GLenum ARRAY_BUFFER_BINDING = 0x8894;
		public const GLenum ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
		public const GLenum STREAM_DRAW = 0x88E0;
		public const GLenum STATIC_DRAW = 0x88E4;
		public const GLenum DYNAMIC_DRAW = 0x88E8;
		public const GLenum BUFFER_SIZE = 0x8764;
		public const GLenum BUFFER_USAGE = 0x8765;
		public const GLenum CURRENT_VERTEX_ATTRIB = 0x8626;
		public const GLenum FRONT = 0x0404;
		public const GLenum BACK = 0x0405;
		public const GLenum FRONT_AND_BACK = 0x0408;
		public const GLenum CULL_FACE = 0x0B44;
		public const GLenum BLEND = 0x0BE2;
		public const GLenum DITHER = 0x0BD0;
		public const GLenum STENCIL_TEST = 0x0B90;
		public const GLenum DEPTH_TEST = 0x0B71;
		public const GLenum SCISSOR_TEST = 0x0C11;
		public const GLenum POLYGON_OFFSET_FILL = 0x8037;
		public const GLenum SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
		public const GLenum SAMPLE_COVERAGE = 0x80A0;
		public const GLenum NO_ERROR = 0;
		public const GLenum INVALID_ENUM = 0x0500;
		public const GLenum INVALID_VALUE = 0x0501;
		public const GLenum INVALID_OPERATION = 0x0502;
		public const GLenum OUT_OF_MEMORY = 0x0505;
		public const GLenum CW = 0x0900;
		public const GLenum CCW = 0x0901;
		public const GLenum LINE_WIDTH = 0x0B21;
		public const GLenum ALIASED_POINT_SIZE_RANGE = 0x846D;
		public const GLenum ALIASED_LINE_WIDTH_RANGE = 0x846E;
		public const GLenum CULL_FACE_MODE = 0x0B45;
		public const GLenum FRONT_FACE = 0x0B46;
		public const GLenum DEPTH_RANGE = 0x0B70;
		public const GLenum DEPTH_WRITEMASK = 0x0B72;
		public const GLenum DEPTH_CLEAR_VALUE = 0x0B73;
		public const GLenum DEPTH_FUNC = 0x0B74;
		public const GLenum STENCIL_CLEAR_VALUE = 0x0B91;
		public const GLenum STENCIL_FUNC = 0x0B92;
		public const GLenum STENCIL_FAIL = 0x0B94;
		public const GLenum STENCIL_PASS_DEPTH_FAIL = 0x0B95;
		public const GLenum STENCIL_PASS_DEPTH_PASS = 0x0B96;
		public const GLenum STENCIL_REF = 0x0B97;
		public const GLenum STENCIL_VALUE_MASK = 0x0B93;
		public const GLenum STENCIL_WRITEMASK = 0x0B98;
		public const GLenum STENCIL_BACK_FUNC = 0x8800;
		public const GLenum STENCIL_BACK_FAIL = 0x8801;
		public const GLenum STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
		public const GLenum STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
		public const GLenum STENCIL_BACK_REF = 0x8CA3;
		public const GLenum STENCIL_BACK_VALUE_MASK = 0x8CA4;
		public const GLenum STENCIL_BACK_WRITEMASK = 0x8CA5;
		public const GLenum VIEWPORT = 0x0BA2;
		public const GLenum SCISSOR_BOX = 0x0C10;
		public const GLenum COLOR_CLEAR_VALUE = 0x0C22;
		public const GLenum COLOR_WRITEMASK = 0x0C23;
		public const GLenum UNPACK_ALIGNMENT = 0x0CF5;
		public const GLenum PACK_ALIGNMENT = 0x0D05;
		public const GLenum MAX_TEXTURE_SIZE = 0x0D33;
		public const GLenum MAX_VIEWPORT_DIMS = 0x0D3A;
		public const GLenum SUBPIXEL_BITS = 0x0D50;
		public const GLenum RED_BITS = 0x0D52;
		public const GLenum GREEN_BITS = 0x0D53;
		public const GLenum BLUE_BITS = 0x0D54;
		public const GLenum ALPHA_BITS = 0x0D55;
		public const GLenum DEPTH_BITS = 0x0D56;
		public const GLenum STENCIL_BITS = 0x0D57;
		public const GLenum POLYGON_OFFSET_UNITS = 0x2A00;
		public const GLenum POLYGON_OFFSET_FACTOR = 0x8038;
		public const GLenum TEXTURE_BINDING_2D = 0x8069;
		public const GLenum SAMPLE_BUFFERS = 0x80A8;
		public const GLenum SAMPLES = 0x80A9;
		public const GLenum SAMPLE_COVERAGE_VALUE = 0x80AA;
		public const GLenum SAMPLE_COVERAGE_INVERT = 0x80AB;
		public const GLenum COMPRESSED_TEXTURE_FORMATS = 0x86A3;
		public const GLenum DONT_CARE = 0x1100;
		public const GLenum FASTEST = 0x1101;
		public const GLenum NICEST = 0x1102;
		public const GLenum GENERATE_MIPMAP_HINT = 0x8192;
		public const GLenum BYTE = 0x1400;
		public const GLenum UNSIGNED_BYTE = 0x1401;
		public const GLenum SHORT = 0x1402;
		public const GLenum UNSIGNED_SHORT = 0x1403;
		public const GLenum INT = 0x1404;
		public const GLenum UNSIGNED_INT = 0x1405;
		public const GLenum FLOAT = 0x1406;
		public const GLenum DEPTH_COMPONENT = 0x1902;
		public const GLenum ALPHA = 0x1906;
		public const GLenum RGB = 0x1907;
		public const GLenum RGBA = 0x1908;
		public const GLenum LUMINANCE = 0x1909;
		public const GLenum LUMINANCE_ALPHA = 0x190A;
		public const GLenum UNSIGNED_SHORT_4_4_4_4 = 0x8033;
		public const GLenum UNSIGNED_SHORT_5_5_5_1 = 0x8034;
		public const GLenum UNSIGNED_SHORT_5_6_5 = 0x8363;
		public const GLenum FRAGMENT_SHADER = 0x8B30;
		public const GLenum VERTEX_SHADER = 0x8B31;
		public const GLenum MAX_VERTEX_ATTRIBS = 0x8869;
		public const GLenum MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
		public const GLenum MAX_VARYING_VECTORS = 0x8DFC;
		public const GLenum MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
		public const GLenum MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
		public const GLenum MAX_TEXTURE_IMAGE_UNITS = 0x8872;
		public const GLenum MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
		public const GLenum SHADER_TYPE = 0x8B4F;
		public const GLenum DELETE_STATUS = 0x8B80;
		public const GLenum LINK_STATUS = 0x8B82;
		public const GLenum VALIDATE_STATUS = 0x8B83;
		public const GLenum ATTACHED_SHADERS = 0x8B85;
		public const GLenum ACTIVE_UNIFORMS = 0x8B86;
		public const GLenum ACTIVE_ATTRIBUTES = 0x8B89;
		public const GLenum SHADING_LANGUAGE_VERSION = 0x8B8C;
		public const GLenum CURRENT_PROGRAM = 0x8B8D;
		public const GLenum NEVER = 0x0200;
		public const GLenum LESS = 0x0201;
		public const GLenum EQUAL = 0x0202;
		public const GLenum LEQUAL = 0x0203;
		public const GLenum GREATER = 0x0204;
		public const GLenum NOTEQUAL = 0x0205;
		public const GLenum GEQUAL = 0x0206;
		public const GLenum ALWAYS = 0x0207;
		public const GLenum KEEP = 0x1E00;
		public const GLenum REPLACE = 0x1E01;
		public const GLenum INCR = 0x1E02;
		public const GLenum DECR = 0x1E03;
		public const GLenum INVERT = 0x150A;
		public const GLenum INCR_WRAP = 0x8507;
		public const GLenum DECR_WRAP = 0x8508;
		public const GLenum VENDOR = 0x1F00;
		public const GLenum RENDERER = 0x1F01;
		public const GLenum VERSION = 0x1F02;
		public const GLenum NEAREST = 0x2600;
		public const GLenum LINEAR = 0x2601;
		public const GLenum NEAREST_MIPMAP_NEAREST = 0x2700;
		public const GLenum LINEAR_MIPMAP_NEAREST = 0x2701;
		public const GLenum NEAREST_MIPMAP_LINEAR = 0x2702;
		public const GLenum LINEAR_MIPMAP_LINEAR = 0x2703;
		public const GLenum TEXTURE_MAG_FILTER = 0x2800;
		public const GLenum TEXTURE_MIN_FILTER = 0x2801;
		public const GLenum TEXTURE_WRAP_S = 0x2802;
		public const GLenum TEXTURE_WRAP_T = 0x2803;
		public const GLenum TEXTURE_2D = 0x0DE1;
		public const GLenum TEXTURE = 0x1702;
		public const GLenum TEXTURE_CUBE_MAP = 0x8513;
		public const GLenum TEXTURE_BINDING_CUBE_MAP = 0x8514;
		public const GLenum TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
		public const GLenum TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
		public const GLenum TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
		public const GLenum TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
		public const GLenum TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
		public const GLenum TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
		public const GLenum MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
		public const GLenum TEXTURE0 = 0x84C0;
		public const GLenum TEXTURE1 = 0x84C1;
		public const GLenum TEXTURE2 = 0x84C2;
		public const GLenum TEXTURE3 = 0x84C3;
		public const GLenum TEXTURE4 = 0x84C4;
		public const GLenum TEXTURE5 = 0x84C5;
		public const GLenum TEXTURE6 = 0x84C6;
		public const GLenum TEXTURE7 = 0x84C7;
		public const GLenum TEXTURE8 = 0x84C8;
		public const GLenum TEXTURE9 = 0x84C9;
		public const GLenum TEXTURE10 = 0x84CA;
		public const GLenum TEXTURE11 = 0x84CB;
		public const GLenum TEXTURE12 = 0x84CC;
		public const GLenum TEXTURE13 = 0x84CD;
		public const GLenum TEXTURE14 = 0x84CE;
		public const GLenum TEXTURE15 = 0x84CF;
		public const GLenum TEXTURE16 = 0x84D0;
		public const GLenum TEXTURE17 = 0x84D1;
		public const GLenum TEXTURE18 = 0x84D2;
		public const GLenum TEXTURE19 = 0x84D3;
		public const GLenum TEXTURE20 = 0x84D4;
		public const GLenum TEXTURE21 = 0x84D5;
		public const GLenum TEXTURE22 = 0x84D6;
		public const GLenum TEXTURE23 = 0x84D7;
		public const GLenum TEXTURE24 = 0x84D8;
		public const GLenum TEXTURE25 = 0x84D9;
		public const GLenum TEXTURE26 = 0x84DA;
		public const GLenum TEXTURE27 = 0x84DB;
		public const GLenum TEXTURE28 = 0x84DC;
		public const GLenum TEXTURE29 = 0x84DD;
		public const GLenum TEXTURE30 = 0x84DE;
		public const GLenum TEXTURE31 = 0x84DF;
		public const GLenum ACTIVE_TEXTURE = 0x84E0;
		public const GLenum REPEAT = 0x2901;
		public const GLenum CLAMP_TO_EDGE = 0x812F;
		public const GLenum MIRRORED_REPEAT = 0x8370;
		public const GLenum FLOAT_VEC2 = 0x8B50;
		public const GLenum FLOAT_VEC3 = 0x8B51;
		public const GLenum FLOAT_VEC4 = 0x8B52;
		public const GLenum INT_VEC2 = 0x8B53;
		public const GLenum INT_VEC3 = 0x8B54;
		public const GLenum INT_VEC4 = 0x8B55;
		public const GLenum BOOL = 0x8B56;
		public const GLenum BOOL_VEC2 = 0x8B57;
		public const GLenum BOOL_VEC3 = 0x8B58;
		public const GLenum BOOL_VEC4 = 0x8B59;
		public const GLenum FLOAT_MAT2 = 0x8B5A;
		public const GLenum FLOAT_MAT3 = 0x8B5B;
		public const GLenum FLOAT_MAT4 = 0x8B5C;
		public const GLenum SAMPLER_2D = 0x8B5E;
		public const GLenum SAMPLER_CUBE = 0x8B60;
		public const GLenum VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
		public const GLenum VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
		public const GLenum VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
		public const GLenum VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
		public const GLenum VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
		public const GLenum VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
		public const GLenum VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
		public const GLenum IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
		public const GLenum IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
		public const GLenum COMPILE_STATUS = 0x8B81;
		public const GLenum LOW_FLOAT = 0x8DF0;
		public const GLenum MEDIUM_FLOAT = 0x8DF1;
		public const GLenum HIGH_FLOAT = 0x8DF2;
		public const GLenum LOW_INT = 0x8DF3;
		public const GLenum MEDIUM_INT = 0x8DF4;
		public const GLenum HIGH_INT = 0x8DF5;
		public const GLenum FRAMEBUFFER = 0x8D40;
		public const GLenum RENDERBUFFER = 0x8D41;
		public const GLenum RGBA4 = 0x8056;
		public const GLenum RGB5_A1 = 0x8057;
		public const GLenum RGBA8 = 0x8058;
		public const GLenum RGB565 = 0x8D62;
		public const GLenum DEPTH_COMPONENT16 = 0x81A5;
		public const GLenum STENCIL_INDEX8 = 0x8D48;
		public const GLenum DEPTH_STENCIL = 0x84F9;
		public const GLenum RENDERBUFFER_WIDTH = 0x8D42;
		public const GLenum RENDERBUFFER_HEIGHT = 0x8D43;
		public const GLenum RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
		public const GLenum RENDERBUFFER_RED_SIZE = 0x8D50;
		public const GLenum RENDERBUFFER_GREEN_SIZE = 0x8D51;
		public const GLenum RENDERBUFFER_BLUE_SIZE = 0x8D52;
		public const GLenum RENDERBUFFER_ALPHA_SIZE = 0x8D53;
		public const GLenum RENDERBUFFER_DEPTH_SIZE = 0x8D54;
		public const GLenum RENDERBUFFER_STENCIL_SIZE = 0x8D55;
		public const GLenum FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
		public const GLenum FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
		public const GLenum FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
		public const GLenum FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
		public const GLenum COLOR_ATTACHMENT0 = 0x8CE0;
		public const GLenum DEPTH_ATTACHMENT = 0x8D00;
		public const GLenum STENCIL_ATTACHMENT = 0x8D20;
		public const GLenum DEPTH_STENCIL_ATTACHMENT = 0x821A;
		public const GLenum NONE = 0;
		public const GLenum FRAMEBUFFER_COMPLETE = 0x8CD5;
		public const GLenum FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
		public const GLenum FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
		public const GLenum FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;
		public const GLenum FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
		public const GLenum FRAMEBUFFER_BINDING = 0x8CA6;
		public const GLenum RENDERBUFFER_BINDING = 0x8CA7;
		public const GLenum MAX_RENDERBUFFER_SIZE = 0x84E8;
		public const GLenum INVALID_FRAMEBUFFER_OPERATION = 0x0506;
		public const GLenum UNPACK_FLIP_Y_WEBGL = 0x9240;
		public const GLenum UNPACK_PREMULTIPLY_ALPHA_WEBGL = 0x9241;
		public const GLenum CONTEXT_LOST_WEBGL = 0x9242;
		public const GLenum UNPACK_COLORSPACE_CONVERSION_WEBGL = 0x9243;
		public const GLenum BROWSER_DEFAULT_WEBGL = 0x9244;
		public Union192 Canvas { get { throw new System.NotImplementedException(); } }
		public GLsizei DrawingBufferWidth { get { throw new System.NotImplementedException(); } }
		public GLsizei DrawingBufferHeight { get { throw new System.NotImplementedException(); } }
		public GLenum DrawingBufferFormat { get { throw new System.NotImplementedException(); } }
		public PredefinedColorSpace DrawingBufferColorSpace { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public PredefinedColorSpace UnpackColorSpace { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public WebGLContextAttributes? GetContextAttributes() { throw new System.NotImplementedException(); }
		public bool IsContextLost() { throw new System.NotImplementedException(); }
		public List<DOMString>? GetSupportedExtensions() { throw new System.NotImplementedException(); }
		public Object? GetExtension(DOMString name) { throw new System.NotImplementedException(); }
		public Undefined DrawingBufferStorage(GLenum sizedFormat, ulong width, ulong height) { throw new System.NotImplementedException(); }
		public Undefined ActiveTexture(GLenum texture) { throw new System.NotImplementedException(); }
		public Undefined AttachShader(WebGLProgram program, WebGLShader shader) { throw new System.NotImplementedException(); }
		public Undefined BindAttribLocation(WebGLProgram program, GLuint index, DOMString name) { throw new System.NotImplementedException(); }
		public Undefined BindBuffer(GLenum target, WebGLBuffer? buffer) { throw new System.NotImplementedException(); }
		public Undefined BindFramebuffer(GLenum target, WebGLFramebuffer? framebuffer) { throw new System.NotImplementedException(); }
		public Undefined BindRenderbuffer(GLenum target, WebGLRenderbuffer? renderbuffer) { throw new System.NotImplementedException(); }
		public Undefined BindTexture(GLenum target, WebGLTexture? texture) { throw new System.NotImplementedException(); }
		public Undefined BlendColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha) { throw new System.NotImplementedException(); }
		public Undefined BlendEquation(GLenum mode) { throw new System.NotImplementedException(); }
		public Undefined BlendEquationSeparate(GLenum modeRGB, GLenum modeAlpha) { throw new System.NotImplementedException(); }
		public Undefined BlendFunc(GLenum sfactor, GLenum dfactor) { throw new System.NotImplementedException(); }
		public Undefined BlendFuncSeparate(GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha) { throw new System.NotImplementedException(); }
		public GLenum CheckFramebufferStatus(GLenum target) { throw new System.NotImplementedException(); }
		public Undefined Clear(GLbitfield mask) { throw new System.NotImplementedException(); }
		public Undefined ClearColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha) { throw new System.NotImplementedException(); }
		public Undefined ClearDepth(GLclampf depth) { throw new System.NotImplementedException(); }
		public Undefined ClearStencil(GLint s) { throw new System.NotImplementedException(); }
		public Undefined ColorMask(bool red, bool green, bool blue, bool alpha) { throw new System.NotImplementedException(); }
		public Undefined CompileShader(WebGLShader shader) { throw new System.NotImplementedException(); }
		public Undefined CopyTexImage2D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border) { throw new System.NotImplementedException(); }
		public Undefined CopyTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height) { throw new System.NotImplementedException(); }
		public WebGLBuffer CreateBuffer() { throw new System.NotImplementedException(); }
		public WebGLFramebuffer CreateFramebuffer() { throw new System.NotImplementedException(); }
		public WebGLProgram CreateProgram() { throw new System.NotImplementedException(); }
		public WebGLRenderbuffer CreateRenderbuffer() { throw new System.NotImplementedException(); }
		public WebGLShader? CreateShader(GLenum type) { throw new System.NotImplementedException(); }
		public WebGLTexture CreateTexture() { throw new System.NotImplementedException(); }
		public Undefined CullFace(GLenum mode) { throw new System.NotImplementedException(); }
		public Undefined DeleteBuffer(WebGLBuffer? buffer) { throw new System.NotImplementedException(); }
		public Undefined DeleteFramebuffer(WebGLFramebuffer? framebuffer) { throw new System.NotImplementedException(); }
		public Undefined DeleteProgram(WebGLProgram? program) { throw new System.NotImplementedException(); }
		public Undefined DeleteRenderbuffer(WebGLRenderbuffer? renderbuffer) { throw new System.NotImplementedException(); }
		public Undefined DeleteShader(WebGLShader? shader) { throw new System.NotImplementedException(); }
		public Undefined DeleteTexture(WebGLTexture? texture) { throw new System.NotImplementedException(); }
		public Undefined DepthFunc(GLenum func) { throw new System.NotImplementedException(); }
		public Undefined DepthMask(bool flag) { throw new System.NotImplementedException(); }
		public Undefined DepthRange(GLclampf zNear, GLclampf zFar) { throw new System.NotImplementedException(); }
		public Undefined DetachShader(WebGLProgram program, WebGLShader shader) { throw new System.NotImplementedException(); }
		public Undefined Disable(GLenum cap) { throw new System.NotImplementedException(); }
		public Undefined DisableVertexAttribArray(GLuint index) { throw new System.NotImplementedException(); }
		public Undefined DrawArrays(GLenum mode, GLint first, GLsizei count) { throw new System.NotImplementedException(); }
		public Undefined DrawElements(GLenum mode, GLsizei count, GLenum type, GLintptr offset) { throw new System.NotImplementedException(); }
		public Undefined Enable(GLenum cap) { throw new System.NotImplementedException(); }
		public Undefined EnableVertexAttribArray(GLuint index) { throw new System.NotImplementedException(); }
		public Undefined Finish() { throw new System.NotImplementedException(); }
		public Undefined Flush() { throw new System.NotImplementedException(); }
		public Undefined FramebufferRenderbuffer(GLenum target, GLenum attachment, GLenum renderbuffertarget, WebGLRenderbuffer? renderbuffer) { throw new System.NotImplementedException(); }
		public Undefined FramebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, WebGLTexture? texture, GLint level) { throw new System.NotImplementedException(); }
		public Undefined FrontFace(GLenum mode) { throw new System.NotImplementedException(); }
		public Undefined GenerateMipmap(GLenum target) { throw new System.NotImplementedException(); }
		public WebGLActiveInfo? GetActiveAttrib(WebGLProgram program, GLuint index) { throw new System.NotImplementedException(); }
		public WebGLActiveInfo? GetActiveUniform(WebGLProgram program, GLuint index) { throw new System.NotImplementedException(); }
		public List<WebGLShader>? GetAttachedShaders(WebGLProgram program) { throw new System.NotImplementedException(); }
		public GLint GetAttribLocation(WebGLProgram program, DOMString name) { throw new System.NotImplementedException(); }
		public dynamic GetBufferParameter(GLenum target, GLenum pname) { throw new System.NotImplementedException(); }
		public dynamic GetParameter(GLenum pname) { throw new System.NotImplementedException(); }
		public GLenum GetError() { throw new System.NotImplementedException(); }
		public dynamic GetFramebufferAttachmentParameter(GLenum target, GLenum attachment, GLenum pname) { throw new System.NotImplementedException(); }
		public dynamic GetProgramParameter(WebGLProgram program, GLenum pname) { throw new System.NotImplementedException(); }
		public DOMString? GetProgramInfoLog(WebGLProgram program) { throw new System.NotImplementedException(); }
		public dynamic GetRenderbufferParameter(GLenum target, GLenum pname) { throw new System.NotImplementedException(); }
		public dynamic GetShaderParameter(WebGLShader shader, GLenum pname) { throw new System.NotImplementedException(); }
		public WebGLShaderPrecisionFormat? GetShaderPrecisionFormat(GLenum shadertype, GLenum precisiontype) { throw new System.NotImplementedException(); }
		public DOMString? GetShaderInfoLog(WebGLShader shader) { throw new System.NotImplementedException(); }
		public DOMString? GetShaderSource(WebGLShader shader) { throw new System.NotImplementedException(); }
		public dynamic GetTexParameter(GLenum target, GLenum pname) { throw new System.NotImplementedException(); }
		public dynamic GetUniform(WebGLProgram program, WebGLUniformLocation location) { throw new System.NotImplementedException(); }
		public WebGLUniformLocation? GetUniformLocation(WebGLProgram program, DOMString name) { throw new System.NotImplementedException(); }
		public dynamic GetVertexAttrib(GLuint index, GLenum pname) { throw new System.NotImplementedException(); }
		public GLintptr GetVertexAttribOffset(GLuint index, GLenum pname) { throw new System.NotImplementedException(); }
		public Undefined Hint(GLenum target, GLenum mode) { throw new System.NotImplementedException(); }
		public bool IsBuffer(WebGLBuffer? buffer) { throw new System.NotImplementedException(); }
		public bool IsEnabled(GLenum cap) { throw new System.NotImplementedException(); }
		public bool IsFramebuffer(WebGLFramebuffer? framebuffer) { throw new System.NotImplementedException(); }
		public bool IsProgram(WebGLProgram? program) { throw new System.NotImplementedException(); }
		public bool IsRenderbuffer(WebGLRenderbuffer? renderbuffer) { throw new System.NotImplementedException(); }
		public bool IsShader(WebGLShader? shader) { throw new System.NotImplementedException(); }
		public bool IsTexture(WebGLTexture? texture) { throw new System.NotImplementedException(); }
		public Undefined LineWidth(Number width) { throw new System.NotImplementedException(); }
		public Undefined LinkProgram(WebGLProgram program) { throw new System.NotImplementedException(); }
		public Undefined PixelStorei(GLenum pname, GLint param) { throw new System.NotImplementedException(); }
		public Undefined PolygonOffset(Number factor, Number units) { throw new System.NotImplementedException(); }
		public Undefined RenderbufferStorage(GLenum target, GLenum internalformat, GLsizei width, GLsizei height) { throw new System.NotImplementedException(); }
		public Undefined SampleCoverage(GLclampf value, bool invert) { throw new System.NotImplementedException(); }
		public Undefined Scissor(GLint x, GLint y, GLsizei width, GLsizei height) { throw new System.NotImplementedException(); }
		public Undefined ShaderSource(WebGLShader shader, DOMString source) { throw new System.NotImplementedException(); }
		public Undefined StencilFunc(GLenum func, GLint ref_, GLuint mask) { throw new System.NotImplementedException(); }
		public Undefined StencilFuncSeparate(GLenum face, GLenum func, GLint ref_, GLuint mask) { throw new System.NotImplementedException(); }
		public Undefined StencilMask(GLuint mask) { throw new System.NotImplementedException(); }
		public Undefined StencilMaskSeparate(GLenum face, GLuint mask) { throw new System.NotImplementedException(); }
		public Undefined StencilOp(GLenum fail, GLenum zfail, GLenum zpass) { throw new System.NotImplementedException(); }
		public Undefined StencilOpSeparate(GLenum face, GLenum fail, GLenum zfail, GLenum zpass) { throw new System.NotImplementedException(); }
		public Undefined TexParameterf(GLenum target, GLenum pname, Number param) { throw new System.NotImplementedException(); }
		public Undefined TexParameteri(GLenum target, GLenum pname, GLint param) { throw new System.NotImplementedException(); }
		public Undefined Uniform1f(WebGLUniformLocation? location, Number x) { throw new System.NotImplementedException(); }
		public Undefined Uniform2f(WebGLUniformLocation? location, Number x, Number y) { throw new System.NotImplementedException(); }
		public Undefined Uniform3f(WebGLUniformLocation? location, Number x, Number y, Number z) { throw new System.NotImplementedException(); }
		public Undefined Uniform4f(WebGLUniformLocation? location, Number x, Number y, Number z, Number w) { throw new System.NotImplementedException(); }
		public Undefined Uniform1i(WebGLUniformLocation? location, GLint x) { throw new System.NotImplementedException(); }
		public Undefined Uniform2i(WebGLUniformLocation? location, GLint x, GLint y) { throw new System.NotImplementedException(); }
		public Undefined Uniform3i(WebGLUniformLocation? location, GLint x, GLint y, GLint z) { throw new System.NotImplementedException(); }
		public Undefined Uniform4i(WebGLUniformLocation? location, GLint x, GLint y, GLint z, GLint w) { throw new System.NotImplementedException(); }
		public Undefined UseProgram(WebGLProgram? program) { throw new System.NotImplementedException(); }
		public Undefined ValidateProgram(WebGLProgram program) { throw new System.NotImplementedException(); }
		public Undefined VertexAttrib1f(GLuint index, Number x) { throw new System.NotImplementedException(); }
		public Undefined VertexAttrib2f(GLuint index, Number x, Number y) { throw new System.NotImplementedException(); }
		public Undefined VertexAttrib3f(GLuint index, Number x, Number y, Number z) { throw new System.NotImplementedException(); }
		public Undefined VertexAttrib4f(GLuint index, Number x, Number y, Number z, Number w) { throw new System.NotImplementedException(); }
		public Undefined VertexAttrib1fv(GLuint index, Float32List values) { throw new System.NotImplementedException(); }
		public Undefined VertexAttrib2fv(GLuint index, Float32List values) { throw new System.NotImplementedException(); }
		public Undefined VertexAttrib3fv(GLuint index, Float32List values) { throw new System.NotImplementedException(); }
		public Undefined VertexAttrib4fv(GLuint index, Float32List values) { throw new System.NotImplementedException(); }
		public Undefined VertexAttribPointer(GLuint index, GLint size, GLenum type, bool normalized, GLsizei stride, GLintptr offset) { throw new System.NotImplementedException(); }
		public Undefined Viewport(GLint x, GLint y, GLsizei width, GLsizei height) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface WebGLRenderingContextOverloads
{
		public Undefined BufferData(GLenum target, GLsizeiptr size, GLenum usage) { throw new System.NotImplementedException(); }
		public Undefined BufferData(GLenum target, AllowSharedBufferSource? data, GLenum usage) { throw new System.NotImplementedException(); }
		public Undefined BufferSubData(GLenum target, GLintptr offset, AllowSharedBufferSource data) { throw new System.NotImplementedException(); }
		public Undefined CompressedTexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, ArrayBufferView data) { throw new System.NotImplementedException(); }
		public Undefined CompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, ArrayBufferView data) { throw new System.NotImplementedException(); }
		public Undefined ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, ArrayBufferView? pixels) { throw new System.NotImplementedException(); }
		public Undefined TexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, ArrayBufferView? pixels) { throw new System.NotImplementedException(); }
		public Undefined TexImage2D(GLenum target, GLint level, GLint internalformat, GLenum format, GLenum type, TexImageSource source) { throw new System.NotImplementedException(); }
		public Undefined TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, ArrayBufferView? pixels) { throw new System.NotImplementedException(); }
		public Undefined TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLenum format, GLenum type, TexImageSource source) { throw new System.NotImplementedException(); }
		public Undefined Uniform1fv(WebGLUniformLocation? location, Float32List v) { throw new System.NotImplementedException(); }
		public Undefined Uniform2fv(WebGLUniformLocation? location, Float32List v) { throw new System.NotImplementedException(); }
		public Undefined Uniform3fv(WebGLUniformLocation? location, Float32List v) { throw new System.NotImplementedException(); }
		public Undefined Uniform4fv(WebGLUniformLocation? location, Float32List v) { throw new System.NotImplementedException(); }
		public Undefined Uniform1iv(WebGLUniformLocation? location, Int32List v) { throw new System.NotImplementedException(); }
		public Undefined Uniform2iv(WebGLUniformLocation? location, Int32List v) { throw new System.NotImplementedException(); }
		public Undefined Uniform3iv(WebGLUniformLocation? location, Int32List v) { throw new System.NotImplementedException(); }
		public Undefined Uniform4iv(WebGLUniformLocation? location, Int32List v) { throw new System.NotImplementedException(); }
		public Undefined UniformMatrix2fv(WebGLUniformLocation? location, bool transpose, Float32List value) { throw new System.NotImplementedException(); }
		public Undefined UniformMatrix3fv(WebGLUniformLocation? location, bool transpose, Float32List value) { throw new System.NotImplementedException(); }
		public Undefined UniformMatrix4fv(WebGLUniformLocation? location, bool transpose, Float32List value) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface WebGL2RenderingContextBase
{
		public const GLenum READ_BUFFER = 0x0C02;
		public const GLenum UNPACK_ROW_LENGTH = 0x0CF2;
		public const GLenum UNPACK_SKIP_ROWS = 0x0CF3;
		public const GLenum UNPACK_SKIP_PIXELS = 0x0CF4;
		public const GLenum PACK_ROW_LENGTH = 0x0D02;
		public const GLenum PACK_SKIP_ROWS = 0x0D03;
		public const GLenum PACK_SKIP_PIXELS = 0x0D04;
		public const GLenum COLOR = 0x1800;
		public const GLenum DEPTH = 0x1801;
		public const GLenum STENCIL = 0x1802;
		public const GLenum RED = 0x1903;
		public const GLenum RGB8 = 0x8051;
		public const GLenum RGB10_A2 = 0x8059;
		public const GLenum TEXTURE_BINDING_3D = 0x806A;
		public const GLenum UNPACK_SKIP_IMAGES = 0x806D;
		public const GLenum UNPACK_IMAGE_HEIGHT = 0x806E;
		public const GLenum TEXTURE_3D = 0x806F;
		public const GLenum TEXTURE_WRAP_R = 0x8072;
		public const GLenum MAX_3D_TEXTURE_SIZE = 0x8073;
		public const GLenum UNSIGNED_INT_2_10_10_10_REV = 0x8368;
		public const GLenum MAX_ELEMENTS_VERTICES = 0x80E8;
		public const GLenum MAX_ELEMENTS_INDICES = 0x80E9;
		public const GLenum TEXTURE_MIN_LOD = 0x813A;
		public const GLenum TEXTURE_MAX_LOD = 0x813B;
		public const GLenum TEXTURE_BASE_LEVEL = 0x813C;
		public const GLenum TEXTURE_MAX_LEVEL = 0x813D;
		public const GLenum MIN = 0x8007;
		public const GLenum MAX = 0x8008;
		public const GLenum DEPTH_COMPONENT24 = 0x81A6;
		public const GLenum MAX_TEXTURE_LOD_BIAS = 0x84FD;
		public const GLenum TEXTURE_COMPARE_MODE = 0x884C;
		public const GLenum TEXTURE_COMPARE_FUNC = 0x884D;
		public const GLenum CURRENT_QUERY = 0x8865;
		public const GLenum QUERY_RESULT = 0x8866;
		public const GLenum QUERY_RESULT_AVAILABLE = 0x8867;
		public const GLenum STREAM_READ = 0x88E1;
		public const GLenum STREAM_COPY = 0x88E2;
		public const GLenum STATIC_READ = 0x88E5;
		public const GLenum STATIC_COPY = 0x88E6;
		public const GLenum DYNAMIC_READ = 0x88E9;
		public const GLenum DYNAMIC_COPY = 0x88EA;
		public const GLenum MAX_DRAW_BUFFERS = 0x8824;
		public const GLenum DRAW_BUFFER0 = 0x8825;
		public const GLenum DRAW_BUFFER1 = 0x8826;
		public const GLenum DRAW_BUFFER2 = 0x8827;
		public const GLenum DRAW_BUFFER3 = 0x8828;
		public const GLenum DRAW_BUFFER4 = 0x8829;
		public const GLenum DRAW_BUFFER5 = 0x882A;
		public const GLenum DRAW_BUFFER6 = 0x882B;
		public const GLenum DRAW_BUFFER7 = 0x882C;
		public const GLenum DRAW_BUFFER8 = 0x882D;
		public const GLenum DRAW_BUFFER9 = 0x882E;
		public const GLenum DRAW_BUFFER10 = 0x882F;
		public const GLenum DRAW_BUFFER11 = 0x8830;
		public const GLenum DRAW_BUFFER12 = 0x8831;
		public const GLenum DRAW_BUFFER13 = 0x8832;
		public const GLenum DRAW_BUFFER14 = 0x8833;
		public const GLenum DRAW_BUFFER15 = 0x8834;
		public const GLenum MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;
		public const GLenum MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;
		public const GLenum SAMPLER_3D = 0x8B5F;
		public const GLenum SAMPLER_2D_SHADOW = 0x8B62;
		public const GLenum FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;
		public const GLenum PIXEL_PACK_BUFFER = 0x88EB;
		public const GLenum PIXEL_UNPACK_BUFFER = 0x88EC;
		public const GLenum PIXEL_PACK_BUFFER_BINDING = 0x88ED;
		public const GLenum PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
		public const GLenum FLOAT_MAT2x3 = 0x8B65;
		public const GLenum FLOAT_MAT2x4 = 0x8B66;
		public const GLenum FLOAT_MAT3x2 = 0x8B67;
		public const GLenum FLOAT_MAT3x4 = 0x8B68;
		public const GLenum FLOAT_MAT4x2 = 0x8B69;
		public const GLenum FLOAT_MAT4x3 = 0x8B6A;
		public const GLenum SRGB = 0x8C40;
		public const GLenum SRGB8 = 0x8C41;
		public const GLenum SRGB8_ALPHA8 = 0x8C43;
		public const GLenum COMPARE_REF_TO_TEXTURE = 0x884E;
		public const GLenum RGBA32F = 0x8814;
		public const GLenum RGB32F = 0x8815;
		public const GLenum RGBA16F = 0x881A;
		public const GLenum RGB16F = 0x881B;
		public const GLenum VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;
		public const GLenum MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;
		public const GLenum MIN_PROGRAM_TEXEL_OFFSET = 0x8904;
		public const GLenum MAX_PROGRAM_TEXEL_OFFSET = 0x8905;
		public const GLenum MAX_VARYING_COMPONENTS = 0x8B4B;
		public const GLenum TEXTURE_2D_ARRAY = 0x8C1A;
		public const GLenum TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
		public const GLenum R11F_G11F_B10F = 0x8C3A;
		public const GLenum UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
		public const GLenum RGB9_E5 = 0x8C3D;
		public const GLenum UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
		public const GLenum TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
		public const GLenum MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
		public const GLenum TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;
		public const GLenum TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
		public const GLenum TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
		public const GLenum TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
		public const GLenum RASTERIZER_DISCARD = 0x8C89;
		public const GLenum MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
		public const GLenum MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
		public const GLenum INTERLEAVED_ATTRIBS = 0x8C8C;
		public const GLenum SEPARATE_ATTRIBS = 0x8C8D;
		public const GLenum TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
		public const GLenum TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;
		public const GLenum RGBA32UI = 0x8D70;
		public const GLenum RGB32UI = 0x8D71;
		public const GLenum RGBA16UI = 0x8D76;
		public const GLenum RGB16UI = 0x8D77;
		public const GLenum RGBA8UI = 0x8D7C;
		public const GLenum RGB8UI = 0x8D7D;
		public const GLenum RGBA32I = 0x8D82;
		public const GLenum RGB32I = 0x8D83;
		public const GLenum RGBA16I = 0x8D88;
		public const GLenum RGB16I = 0x8D89;
		public const GLenum RGBA8I = 0x8D8E;
		public const GLenum RGB8I = 0x8D8F;
		public const GLenum RED_INTEGER = 0x8D94;
		public const GLenum RGB_INTEGER = 0x8D98;
		public const GLenum RGBA_INTEGER = 0x8D99;
		public const GLenum SAMPLER_2D_ARRAY = 0x8DC1;
		public const GLenum SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;
		public const GLenum SAMPLER_CUBE_SHADOW = 0x8DC5;
		public const GLenum UNSIGNED_INT_VEC2 = 0x8DC6;
		public const GLenum UNSIGNED_INT_VEC3 = 0x8DC7;
		public const GLenum UNSIGNED_INT_VEC4 = 0x8DC8;
		public const GLenum INT_SAMPLER_2D = 0x8DCA;
		public const GLenum INT_SAMPLER_3D = 0x8DCB;
		public const GLenum INT_SAMPLER_CUBE = 0x8DCC;
		public const GLenum INT_SAMPLER_2D_ARRAY = 0x8DCF;
		public const GLenum UNSIGNED_INT_SAMPLER_2D = 0x8DD2;
		public const GLenum UNSIGNED_INT_SAMPLER_3D = 0x8DD3;
		public const GLenum UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;
		public const GLenum UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;
		public const GLenum DEPTH_COMPONENT32F = 0x8CAC;
		public const GLenum DEPTH32F_STENCIL8 = 0x8CAD;
		public const GLenum FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
		public const GLenum FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
		public const GLenum FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
		public const GLenum FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
		public const GLenum FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
		public const GLenum FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
		public const GLenum FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
		public const GLenum FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
		public const GLenum FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
		public const GLenum FRAMEBUFFER_DEFAULT = 0x8218;
		public const GLenum UNSIGNED_INT_24_8 = 0x84FA;
		public const GLenum DEPTH24_STENCIL8 = 0x88F0;
		public const GLenum UNSIGNED_NORMALIZED = 0x8C17;
		public const GLenum DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
		public const GLenum READ_FRAMEBUFFER = 0x8CA8;
		public const GLenum DRAW_FRAMEBUFFER = 0x8CA9;
		public const GLenum READ_FRAMEBUFFER_BINDING = 0x8CAA;
		public const GLenum RENDERBUFFER_SAMPLES = 0x8CAB;
		public const GLenum FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
		public const GLenum MAX_COLOR_ATTACHMENTS = 0x8CDF;
		public const GLenum COLOR_ATTACHMENT1 = 0x8CE1;
		public const GLenum COLOR_ATTACHMENT2 = 0x8CE2;
		public const GLenum COLOR_ATTACHMENT3 = 0x8CE3;
		public const GLenum COLOR_ATTACHMENT4 = 0x8CE4;
		public const GLenum COLOR_ATTACHMENT5 = 0x8CE5;
		public const GLenum COLOR_ATTACHMENT6 = 0x8CE6;
		public const GLenum COLOR_ATTACHMENT7 = 0x8CE7;
		public const GLenum COLOR_ATTACHMENT8 = 0x8CE8;
		public const GLenum COLOR_ATTACHMENT9 = 0x8CE9;
		public const GLenum COLOR_ATTACHMENT10 = 0x8CEA;
		public const GLenum COLOR_ATTACHMENT11 = 0x8CEB;
		public const GLenum COLOR_ATTACHMENT12 = 0x8CEC;
		public const GLenum COLOR_ATTACHMENT13 = 0x8CED;
		public const GLenum COLOR_ATTACHMENT14 = 0x8CEE;
		public const GLenum COLOR_ATTACHMENT15 = 0x8CEF;
		public const GLenum FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
		public const GLenum MAX_SAMPLES = 0x8D57;
		public const GLenum HALF_FLOAT = 0x140B;
		public const GLenum RG = 0x8227;
		public const GLenum RG_INTEGER = 0x8228;
		public const GLenum R8 = 0x8229;
		public const GLenum RG8 = 0x822B;
		public const GLenum R16F = 0x822D;
		public const GLenum R32F = 0x822E;
		public const GLenum RG16F = 0x822F;
		public const GLenum RG32F = 0x8230;
		public const GLenum R8I = 0x8231;
		public const GLenum R8UI = 0x8232;
		public const GLenum R16I = 0x8233;
		public const GLenum R16UI = 0x8234;
		public const GLenum R32I = 0x8235;
		public const GLenum R32UI = 0x8236;
		public const GLenum RG8I = 0x8237;
		public const GLenum RG8UI = 0x8238;
		public const GLenum RG16I = 0x8239;
		public const GLenum RG16UI = 0x823A;
		public const GLenum RG32I = 0x823B;
		public const GLenum RG32UI = 0x823C;
		public const GLenum VERTEX_ARRAY_BINDING = 0x85B5;
		public const GLenum R8_SNORM = 0x8F94;
		public const GLenum RG8_SNORM = 0x8F95;
		public const GLenum RGB8_SNORM = 0x8F96;
		public const GLenum RGBA8_SNORM = 0x8F97;
		public const GLenum SIGNED_NORMALIZED = 0x8F9C;
		public const GLenum COPY_READ_BUFFER = 0x8F36;
		public const GLenum COPY_WRITE_BUFFER = 0x8F37;
		public const GLenum COPY_READ_BUFFER_BINDING = 0x8F36;
		public const GLenum COPY_WRITE_BUFFER_BINDING = 0x8F37;
		public const GLenum UNIFORM_BUFFER = 0x8A11;
		public const GLenum UNIFORM_BUFFER_BINDING = 0x8A28;
		public const GLenum UNIFORM_BUFFER_START = 0x8A29;
		public const GLenum UNIFORM_BUFFER_SIZE = 0x8A2A;
		public const GLenum MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
		public const GLenum MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
		public const GLenum MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
		public const GLenum MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
		public const GLenum MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
		public const GLenum MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
		public const GLenum MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
		public const GLenum UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
		public const GLenum ACTIVE_UNIFORM_BLOCKS = 0x8A36;
		public const GLenum UNIFORM_TYPE = 0x8A37;
		public const GLenum UNIFORM_SIZE = 0x8A38;
		public const GLenum UNIFORM_BLOCK_INDEX = 0x8A3A;
		public const GLenum UNIFORM_OFFSET = 0x8A3B;
		public const GLenum UNIFORM_ARRAY_STRIDE = 0x8A3C;
		public const GLenum UNIFORM_MATRIX_STRIDE = 0x8A3D;
		public const GLenum UNIFORM_IS_ROW_MAJOR = 0x8A3E;
		public const GLenum UNIFORM_BLOCK_BINDING = 0x8A3F;
		public const GLenum UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
		public const GLenum UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
		public const GLenum UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
		public const GLenum UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
		public const GLenum UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
		public const GLenum INVALID_INDEX = 0xFFFFFFFF;
		public const GLenum MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;
		public const GLenum MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;
		public const GLenum MAX_SERVER_WAIT_TIMEOUT = 0x9111;
		public const GLenum OBJECT_TYPE = 0x9112;
		public const GLenum SYNC_CONDITION = 0x9113;
		public const GLenum SYNC_STATUS = 0x9114;
		public const GLenum SYNC_FLAGS = 0x9115;
		public const GLenum SYNC_FENCE = 0x9116;
		public const GLenum SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
		public const GLenum UNSIGNALED = 0x9118;
		public const GLenum SIGNALED = 0x9119;
		public const GLenum ALREADY_SIGNALED = 0x911A;
		public const GLenum TIMEOUT_EXPIRED = 0x911B;
		public const GLenum CONDITION_SATISFIED = 0x911C;
		public const GLenum WAIT_FAILED = 0x911D;
		public const GLenum SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
		public const GLenum VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;
		public const GLenum ANY_SAMPLES_PASSED = 0x8C2F;
		public const GLenum ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;
		public const GLenum SAMPLER_BINDING = 0x8919;
		public const GLenum RGB10_A2UI = 0x906F;
		public const GLenum INT_2_10_10_10_REV = 0x8D9F;
		public const GLenum TRANSFORM_FEEDBACK = 0x8E22;
		public const GLenum TRANSFORM_FEEDBACK_PAUSED = 0x8E23;
		public const GLenum TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;
		public const GLenum TRANSFORM_FEEDBACK_BINDING = 0x8E25;
		public const GLenum TEXTURE_IMMUTABLE_FORMAT = 0x912F;
		public const GLenum MAX_ELEMENT_INDEX = 0x8D6B;
		public const GLenum TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
		public const GLint64 TIMEOUT_IGNORED = -1;
		public const GLenum MAX_CLIENT_WAIT_TIMEOUT_WEBGL = 0x9247;
		public Undefined CopyBufferSubData(GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size) { throw new System.NotImplementedException(); }
		public Undefined GetBufferSubData(GLenum target, GLintptr srcByteOffset, ArrayBufferView dstBuffer, ulong dstOffset = default, GLuint length = default) { throw new System.NotImplementedException(); }
		public Undefined BlitFramebuffer(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter) { throw new System.NotImplementedException(); }
		public Undefined FramebufferTextureLayer(GLenum target, GLenum attachment, WebGLTexture? texture, GLint level, GLint layer) { throw new System.NotImplementedException(); }
		public Undefined InvalidateFramebuffer(GLenum target, List<GLenum> attachments) { throw new System.NotImplementedException(); }
		public Undefined InvalidateSubFramebuffer(GLenum target, List<GLenum> attachments, GLint x, GLint y, GLsizei width, GLsizei height) { throw new System.NotImplementedException(); }
		public Undefined ReadBuffer(GLenum src) { throw new System.NotImplementedException(); }
		public dynamic GetInternalformatParameter(GLenum target, GLenum internalformat, GLenum pname) { throw new System.NotImplementedException(); }
		public Undefined RenderbufferStorageMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height) { throw new System.NotImplementedException(); }
		public Undefined TexStorage2D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height) { throw new System.NotImplementedException(); }
		public Undefined TexStorage3D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth) { throw new System.NotImplementedException(); }
		public Undefined TexImage3D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, GLintptr pboOffset) { throw new System.NotImplementedException(); }
		public Undefined TexImage3D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, TexImageSource source) { throw new System.NotImplementedException(); }
		public Undefined TexImage3D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, ArrayBufferView? srcData) { throw new System.NotImplementedException(); }
		public Undefined TexImage3D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, ArrayBufferView srcData, ulong srcOffset) { throw new System.NotImplementedException(); }
		public Undefined TexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, GLintptr pboOffset) { throw new System.NotImplementedException(); }
		public Undefined TexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, TexImageSource source) { throw new System.NotImplementedException(); }
		public Undefined TexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, ArrayBufferView? srcData, ulong srcOffset = default) { throw new System.NotImplementedException(); }
		public Undefined CopyTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height) { throw new System.NotImplementedException(); }
		public Undefined CompressedTexImage3D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, GLintptr offset) { throw new System.NotImplementedException(); }
		public Undefined CompressedTexImage3D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, ArrayBufferView srcData, ulong srcOffset = default, GLuint srcLengthOverride = default) { throw new System.NotImplementedException(); }
		public Undefined CompressedTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, GLintptr offset) { throw new System.NotImplementedException(); }
		public Undefined CompressedTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, ArrayBufferView srcData, ulong srcOffset = default, GLuint srcLengthOverride = default) { throw new System.NotImplementedException(); }
		public GLint GetFragDataLocation(WebGLProgram program, DOMString name) { throw new System.NotImplementedException(); }
		public Undefined Uniform1ui(WebGLUniformLocation? location, GLuint v0) { throw new System.NotImplementedException(); }
		public Undefined Uniform2ui(WebGLUniformLocation? location, GLuint v0, GLuint v1) { throw new System.NotImplementedException(); }
		public Undefined Uniform3ui(WebGLUniformLocation? location, GLuint v0, GLuint v1, GLuint v2) { throw new System.NotImplementedException(); }
		public Undefined Uniform4ui(WebGLUniformLocation? location, GLuint v0, GLuint v1, GLuint v2, GLuint v3) { throw new System.NotImplementedException(); }
		public Undefined Uniform1uiv(WebGLUniformLocation? location, Uint32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined Uniform2uiv(WebGLUniformLocation? location, Uint32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined Uniform3uiv(WebGLUniformLocation? location, Uint32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined Uniform4uiv(WebGLUniformLocation? location, Uint32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined UniformMatrix3x2fv(WebGLUniformLocation? location, bool transpose, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined UniformMatrix4x2fv(WebGLUniformLocation? location, bool transpose, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined UniformMatrix2x3fv(WebGLUniformLocation? location, bool transpose, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined UniformMatrix4x3fv(WebGLUniformLocation? location, bool transpose, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined UniformMatrix2x4fv(WebGLUniformLocation? location, bool transpose, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined UniformMatrix3x4fv(WebGLUniformLocation? location, bool transpose, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined VertexAttribI4i(GLuint index, GLint x, GLint y, GLint z, GLint w) { throw new System.NotImplementedException(); }
		public Undefined VertexAttribI4iv(GLuint index, Int32List values) { throw new System.NotImplementedException(); }
		public Undefined VertexAttribI4ui(GLuint index, GLuint x, GLuint y, GLuint z, GLuint w) { throw new System.NotImplementedException(); }
		public Undefined VertexAttribI4uiv(GLuint index, Uint32List values) { throw new System.NotImplementedException(); }
		public Undefined VertexAttribIPointer(GLuint index, GLint size, GLenum type, GLsizei stride, GLintptr offset) { throw new System.NotImplementedException(); }
		public Undefined VertexAttribDivisor(GLuint index, GLuint divisor) { throw new System.NotImplementedException(); }
		public Undefined DrawArraysInstanced(GLenum mode, GLint first, GLsizei count, GLsizei instanceCount) { throw new System.NotImplementedException(); }
		public Undefined DrawElementsInstanced(GLenum mode, GLsizei count, GLenum type, GLintptr offset, GLsizei instanceCount) { throw new System.NotImplementedException(); }
		public Undefined DrawRangeElements(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, GLintptr offset) { throw new System.NotImplementedException(); }
		public Undefined DrawBuffers(List<GLenum> buffers) { throw new System.NotImplementedException(); }
		public Undefined ClearBufferfv(GLenum buffer, GLint drawbuffer, Float32List values, ulong srcOffset = default) { throw new System.NotImplementedException(); }
		public Undefined ClearBufferiv(GLenum buffer, GLint drawbuffer, Int32List values, ulong srcOffset = default) { throw new System.NotImplementedException(); }
		public Undefined ClearBufferuiv(GLenum buffer, GLint drawbuffer, Uint32List values, ulong srcOffset = default) { throw new System.NotImplementedException(); }
		public Undefined ClearBufferfi(GLenum buffer, GLint drawbuffer, Number depth, GLint stencil) { throw new System.NotImplementedException(); }
		public WebGLQuery CreateQuery() { throw new System.NotImplementedException(); }
		public Undefined DeleteQuery(WebGLQuery? query) { throw new System.NotImplementedException(); }
		public bool IsQuery(WebGLQuery? query) { throw new System.NotImplementedException(); }
		public Undefined BeginQuery(GLenum target, WebGLQuery query) { throw new System.NotImplementedException(); }
		public Undefined EndQuery(GLenum target) { throw new System.NotImplementedException(); }
		public WebGLQuery? GetQuery(GLenum target, GLenum pname) { throw new System.NotImplementedException(); }
		public dynamic GetQueryParameter(WebGLQuery query, GLenum pname) { throw new System.NotImplementedException(); }
		public WebGLSampler CreateSampler() { throw new System.NotImplementedException(); }
		public Undefined DeleteSampler(WebGLSampler? sampler) { throw new System.NotImplementedException(); }
		public bool IsSampler(WebGLSampler? sampler) { throw new System.NotImplementedException(); }
		public Undefined BindSampler(GLuint unit, WebGLSampler? sampler) { throw new System.NotImplementedException(); }
		public Undefined SamplerParameteri(WebGLSampler sampler, GLenum pname, GLint param) { throw new System.NotImplementedException(); }
		public Undefined SamplerParameterf(WebGLSampler sampler, GLenum pname, Number param) { throw new System.NotImplementedException(); }
		public dynamic GetSamplerParameter(WebGLSampler sampler, GLenum pname) { throw new System.NotImplementedException(); }
		public WebGLSync? FenceSync(GLenum condition, GLbitfield flags) { throw new System.NotImplementedException(); }
		public bool IsSync(WebGLSync? sync) { throw new System.NotImplementedException(); }
		public Undefined DeleteSync(WebGLSync? sync) { throw new System.NotImplementedException(); }
		public GLenum ClientWaitSync(WebGLSync sync, GLbitfield flags, GLuint64 timeout) { throw new System.NotImplementedException(); }
		public Undefined WaitSync(WebGLSync sync, GLbitfield flags, GLint64 timeout) { throw new System.NotImplementedException(); }
		public dynamic GetSyncParameter(WebGLSync sync, GLenum pname) { throw new System.NotImplementedException(); }
		public WebGLTransformFeedback CreateTransformFeedback() { throw new System.NotImplementedException(); }
		public Undefined DeleteTransformFeedback(WebGLTransformFeedback? tf) { throw new System.NotImplementedException(); }
		public bool IsTransformFeedback(WebGLTransformFeedback? tf) { throw new System.NotImplementedException(); }
		public Undefined BindTransformFeedback(GLenum target, WebGLTransformFeedback? tf) { throw new System.NotImplementedException(); }
		public Undefined BeginTransformFeedback(GLenum primitiveMode) { throw new System.NotImplementedException(); }
		public Undefined EndTransformFeedback() { throw new System.NotImplementedException(); }
		public Undefined TransformFeedbackVaryings(WebGLProgram program, List<DOMString> varyings, GLenum bufferMode) { throw new System.NotImplementedException(); }
		public WebGLActiveInfo? GetTransformFeedbackVarying(WebGLProgram program, GLuint index) { throw new System.NotImplementedException(); }
		public Undefined PauseTransformFeedback() { throw new System.NotImplementedException(); }
		public Undefined ResumeTransformFeedback() { throw new System.NotImplementedException(); }
		public Undefined BindBufferBase(GLenum target, GLuint index, WebGLBuffer? buffer) { throw new System.NotImplementedException(); }
		public Undefined BindBufferRange(GLenum target, GLuint index, WebGLBuffer? buffer, GLintptr offset, GLsizeiptr size) { throw new System.NotImplementedException(); }
		public dynamic GetIndexedParameter(GLenum target, GLuint index) { throw new System.NotImplementedException(); }
		public List<GLuint>? GetUniformIndices(WebGLProgram program, List<DOMString> uniformNames) { throw new System.NotImplementedException(); }
		public dynamic GetActiveUniforms(WebGLProgram program, List<GLuint> uniformIndices, GLenum pname) { throw new System.NotImplementedException(); }
		public GLuint GetUniformBlockIndex(WebGLProgram program, DOMString uniformBlockName) { throw new System.NotImplementedException(); }
		public dynamic GetActiveUniformBlockParameter(WebGLProgram program, GLuint uniformBlockIndex, GLenum pname) { throw new System.NotImplementedException(); }
		public DOMString? GetActiveUniformBlockName(WebGLProgram program, GLuint uniformBlockIndex) { throw new System.NotImplementedException(); }
		public Undefined UniformBlockBinding(WebGLProgram program, GLuint uniformBlockIndex, GLuint uniformBlockBinding) { throw new System.NotImplementedException(); }
		public WebGLVertexArrayObject CreateVertexArray() { throw new System.NotImplementedException(); }
		public Undefined DeleteVertexArray(WebGLVertexArrayObject? vertexArray) { throw new System.NotImplementedException(); }
		public bool IsVertexArray(WebGLVertexArrayObject? vertexArray) { throw new System.NotImplementedException(); }
		public Undefined BindVertexArray(WebGLVertexArrayObject? array) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface WebGL2RenderingContextOverloads
{
		public Undefined BufferData(GLenum target, GLsizeiptr size, GLenum usage) { throw new System.NotImplementedException(); }
		public Undefined BufferData(GLenum target, AllowSharedBufferSource? srcData, GLenum usage) { throw new System.NotImplementedException(); }
		public Undefined BufferSubData(GLenum target, GLintptr dstByteOffset, AllowSharedBufferSource srcData) { throw new System.NotImplementedException(); }
		public Undefined BufferData(GLenum target, ArrayBufferView srcData, GLenum usage, ulong srcOffset, GLuint length = default) { throw new System.NotImplementedException(); }
		public Undefined BufferSubData(GLenum target, GLintptr dstByteOffset, ArrayBufferView srcData, ulong srcOffset, GLuint length = default) { throw new System.NotImplementedException(); }
		public Undefined TexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, ArrayBufferView? pixels) { throw new System.NotImplementedException(); }
		public Undefined TexImage2D(GLenum target, GLint level, GLint internalformat, GLenum format, GLenum type, TexImageSource source) { throw new System.NotImplementedException(); }
		public Undefined TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, ArrayBufferView? pixels) { throw new System.NotImplementedException(); }
		public Undefined TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLenum format, GLenum type, TexImageSource source) { throw new System.NotImplementedException(); }
		public Undefined TexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, GLintptr pboOffset) { throw new System.NotImplementedException(); }
		public Undefined TexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, TexImageSource source) { throw new System.NotImplementedException(); }
		public Undefined TexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, ArrayBufferView srcData, ulong srcOffset) { throw new System.NotImplementedException(); }
		public Undefined TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, GLintptr pboOffset) { throw new System.NotImplementedException(); }
		public Undefined TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, TexImageSource source) { throw new System.NotImplementedException(); }
		public Undefined TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, ArrayBufferView srcData, ulong srcOffset) { throw new System.NotImplementedException(); }
		public Undefined CompressedTexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, GLintptr offset) { throw new System.NotImplementedException(); }
		public Undefined CompressedTexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, ArrayBufferView srcData, ulong srcOffset = default, GLuint srcLengthOverride = default) { throw new System.NotImplementedException(); }
		public Undefined CompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, GLintptr offset) { throw new System.NotImplementedException(); }
		public Undefined CompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, ArrayBufferView srcData, ulong srcOffset = default, GLuint srcLengthOverride = default) { throw new System.NotImplementedException(); }
		public Undefined Uniform1fv(WebGLUniformLocation? location, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined Uniform2fv(WebGLUniformLocation? location, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined Uniform3fv(WebGLUniformLocation? location, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined Uniform4fv(WebGLUniformLocation? location, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined Uniform1iv(WebGLUniformLocation? location, Int32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined Uniform2iv(WebGLUniformLocation? location, Int32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined Uniform3iv(WebGLUniformLocation? location, Int32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined Uniform4iv(WebGLUniformLocation? location, Int32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined UniformMatrix2fv(WebGLUniformLocation? location, bool transpose, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined UniformMatrix3fv(WebGLUniformLocation? location, bool transpose, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined UniformMatrix4fv(WebGLUniformLocation? location, bool transpose, Float32List data, ulong srcOffset = default, GLuint srcLength = default) { throw new System.NotImplementedException(); }
		public Undefined ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, ArrayBufferView? dstData) { throw new System.NotImplementedException(); }
		public Undefined ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLintptr offset) { throw new System.NotImplementedException(); }
		public Undefined ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, ArrayBufferView dstData, ulong dstOffset) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GPUObjectBase
{
		public USVString Label { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NavigatorGPU/NavigatorGPU.generated.xml' path='docs/NavigatorGPU/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorGPU
{
		public GPU Gpu { get { throw new System.NotImplementedException(); } }
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GPUPipelineBase
{
		public GPUBindGroupLayout GetBindGroupLayout(ulong index) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GPUCommandsMixin
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GPUBindingCommandsMixin
{
		public Undefined SetBindGroup(GPUIndex32 index, GPUBindGroup? bindGroup, List<GPUBufferDynamicOffset> dynamicOffsets = default) { throw new System.NotImplementedException(); }
		public Undefined SetBindGroup(GPUIndex32 index, GPUBindGroup? bindGroup, Uint32Array dynamicOffsetsData, GPUSize64 dynamicOffsetsDataStart, GPUSize32 dynamicOffsetsDataLength) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GPUDebugCommandsMixin
{
		public Undefined PushDebugGroup(USVString groupLabel) { throw new System.NotImplementedException(); }
		public Undefined PopDebugGroup() { throw new System.NotImplementedException(); }
		public Undefined InsertDebugMarker(USVString markerLabel) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GPURenderCommandsMixin
{
		public Undefined SetPipeline(GPURenderPipeline pipeline) { throw new System.NotImplementedException(); }
		public Undefined SetIndexBuffer(GPUBuffer buffer, GPUIndexFormat indexFormat, GPUSize64 offset = default, GPUSize64 size = default) { throw new System.NotImplementedException(); }
		public Undefined SetVertexBuffer(GPUIndex32 slot, GPUBuffer? buffer, GPUSize64 offset = default, GPUSize64 size = default) { throw new System.NotImplementedException(); }
		public Undefined Draw(GPUSize32 vertexCount, GPUSize32 instanceCount = default, GPUSize32 firstVertex = default, GPUSize32 firstInstance = default) { throw new System.NotImplementedException(); }
		public Undefined DrawIndexed(GPUSize32 indexCount, GPUSize32 instanceCount = default, GPUSize32 firstIndex = default, GPUSignedOffset32 baseVertex = default, GPUSize32 firstInstance = default) { throw new System.NotImplementedException(); }
		public Undefined DrawIndirect(GPUBuffer indirectBuffer, GPUSize64 indirectOffset) { throw new System.NotImplementedException(); }
		public Undefined DrawIndexedIndirect(GPUBuffer indirectBuffer, GPUSize64 indirectOffset) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorML
{
		public ML Ml { get { throw new System.NotImplementedException(); } }
}



public partial interface GlobalEventHandlers
{
		public EventHandler Onbeforexrselect { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

public partial interface WebGLRenderingContextBase
{
		public Task<Undefined> MakeXRCompatible() { throw new System.NotImplementedException(); }
}

