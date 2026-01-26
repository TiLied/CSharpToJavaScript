//13.01.2026 17:12:20

#nullable enable
//Disable missing XML comments.
#pragma warning disable CS1591
//Ignore files not found.
#pragma warning disable CS1589
//Ignore 'Cannot convert null literal to non-nullable reference type.'
#pragma warning disable CS8625
//Ignore non-nullable property must contain a non-null value
#pragma warning disable CS8618

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


///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/Console/*'/>
[Value("console")]
public partial class console
{
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleAssert/*'/>
[Value("assert")]
	public Undefined Assert(bool condition = default, params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleClear/*'/>
[Value("clear")]
	public Undefined Clear() { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleDebug/*'/>
[Value("debug")]
	public Undefined Debug(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleError/*'/>
[Value("error")]
	public Undefined Error(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleInfo/*'/>
[Value("info")]
	public Undefined Info(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleLog/*'/>
[Value("log")]
	public Undefined Log(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleTable/*'/>
[Value("table")]
	public Undefined Table(dynamic tabularData = default, List<DOMString> properties = default) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleTrace/*'/>
[Value("trace")]
	public Undefined Trace(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleWarn/*'/>
[Value("warn")]
	public Undefined Warn(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleDir/*'/>
[Value("dir")]
	public Undefined Dir(dynamic item = default, Object? options = default) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleDirxml/*'/>
[Value("dirxml")]
	public Undefined Dirxml(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleCount/*'/>
[Value("count")]
	public Undefined Count(DOMString label = default) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleCountReset/*'/>
[Value("countReset")]
	public Undefined CountReset(DOMString label = default) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleGroup/*'/>
[Value("group")]
	public Undefined Group(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleGroupCollapsed/*'/>
[Value("groupCollapsed")]
	public Undefined GroupCollapsed(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleGroupEnd/*'/>
[Value("groupEnd")]
	public Undefined GroupEnd() { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleTime/*'/>
[Value("time")]
	public Undefined Time(DOMString label = default) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleTimeLog/*'/>
[Value("timeLog")]
	public Undefined TimeLog(DOMString label = default, params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/console/console.generated.xml' path='docs/ConsoleTimeEnd/*'/>
[Value("timeEnd")]
	public Undefined TimeEnd(DOMString label = default) { throw new System.NotImplementedException(); }
}

///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSS/*'/>
[Value("CSS")]
public partial class CSS
{
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSAnimationWorklet/*'/>
[Value("animationWorklet")]
	public Worklet AnimationWorklet { get; }
}

///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSS/*'/>
public partial class CSS
{
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSSupports/*'/>
[Value("supports")]
	public bool Supports(CSSOMString property, CSSOMString value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSSupports/*'/>
[Value("supports")]
	public bool Supports(CSSOMString conditionText) { throw new System.NotImplementedException(); }
}

///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSS/*'/>
public partial class CSS
{
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSHighlights/*'/>
[Value("highlights")]
	public HighlightRegistry Highlights { get; }
}

///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSS/*'/>
public partial class CSS
{
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSElementSources/*'/>
[Value("elementSources")]
	public dynamic ElementSources { get; }
}

///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSS/*'/>
public partial class CSS
{
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSLayoutWorklet/*'/>
[Value("layoutWorklet")]
	public Worklet LayoutWorklet { get; }
}

///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSS/*'/>
public partial class CSS
{
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSPaintWorklet/*'/>
[Value("paintWorklet")]
	public Worklet PaintWorklet { get; }
}

///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSS/*'/>
public partial class CSS
{
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSParseStylesheet/*'/>
[Value("parseStylesheet")]
	public Task<List<CSSParserRule>> ParseStylesheet(CSSStringSource css, CSSParserOptions options = default) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSParseRuleList/*'/>
[Value("parseRuleList")]
	public Task<List<CSSParserRule>> ParseRuleList(CSSStringSource css, CSSParserOptions options = default) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSParseRule/*'/>
[Value("parseRule")]
	public Task<CSSParserRule> ParseRule(CSSStringSource css, CSSParserOptions options = default) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSParseDeclarationList/*'/>
[Value("parseDeclarationList")]
	public Task<List<CSSParserRule>> ParseDeclarationList(CSSStringSource css, CSSParserOptions options = default) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSParseDeclaration/*'/>
[Value("parseDeclaration")]
	public CSSParserDeclaration ParseDeclaration(DOMString css, CSSParserOptions options = default) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSParseValue/*'/>
[Value("parseValue")]
	public CSSToken ParseValue(DOMString css) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSParseValueList/*'/>
[Value("parseValueList")]
	public List<CSSToken> ParseValueList(DOMString css) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSParseCommaValueList/*'/>
[Value("parseCommaValueList")]
	public List<List<CSSToken>> ParseCommaValueList(DOMString css) { throw new System.NotImplementedException(); }
}

///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSS/*'/>
public partial class CSS
{
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSRegisterProperty/*'/>
[Value("registerProperty")]
	public Undefined RegisterProperty(PropertyDefinition definition) { throw new System.NotImplementedException(); }
}

///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSS/*'/>
public partial class CSS
{
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSNumber/*'/>
[Value("number")]
	public CSSUnitValue Number(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSPercent/*'/>
[Value("percent")]
	public CSSUnitValue Percent(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSCap/*'/>
[Value("cap")]
	public CSSUnitValue Cap(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSCh/*'/>
[Value("ch")]
	public CSSUnitValue Ch(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSEm/*'/>
[Value("em")]
	public CSSUnitValue Em(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSEx/*'/>
[Value("ex")]
	public CSSUnitValue Ex(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSIc/*'/>
[Value("ic")]
	public CSSUnitValue Ic(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSLh/*'/>
[Value("lh")]
	public CSSUnitValue Lh(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSRcap/*'/>
[Value("rcap")]
	public CSSUnitValue Rcap(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSRch/*'/>
[Value("rch")]
	public CSSUnitValue Rch(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSRem/*'/>
[Value("rem")]
	public CSSUnitValue Rem(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSRex/*'/>
[Value("rex")]
	public CSSUnitValue Rex(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSRic/*'/>
[Value("ric")]
	public CSSUnitValue Ric(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSRlh/*'/>
[Value("rlh")]
	public CSSUnitValue Rlh(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSVw/*'/>
[Value("vw")]
	public CSSUnitValue Vw(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSVh/*'/>
[Value("vh")]
	public CSSUnitValue Vh(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSVi/*'/>
[Value("vi")]
	public CSSUnitValue Vi(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSVb/*'/>
[Value("vb")]
	public CSSUnitValue Vb(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSVmin/*'/>
[Value("vmin")]
	public CSSUnitValue Vmin(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSVmax/*'/>
[Value("vmax")]
	public CSSUnitValue Vmax(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSSvw/*'/>
[Value("svw")]
	public CSSUnitValue Svw(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSSvh/*'/>
[Value("svh")]
	public CSSUnitValue Svh(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSSvi/*'/>
[Value("svi")]
	public CSSUnitValue Svi(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSSvb/*'/>
[Value("svb")]
	public CSSUnitValue Svb(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSSvmin/*'/>
[Value("svmin")]
	public CSSUnitValue Svmin(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSSvmax/*'/>
[Value("svmax")]
	public CSSUnitValue Svmax(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSLvw/*'/>
[Value("lvw")]
	public CSSUnitValue Lvw(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSLvh/*'/>
[Value("lvh")]
	public CSSUnitValue Lvh(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSLvi/*'/>
[Value("lvi")]
	public CSSUnitValue Lvi(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSLvb/*'/>
[Value("lvb")]
	public CSSUnitValue Lvb(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSLvmin/*'/>
[Value("lvmin")]
	public CSSUnitValue Lvmin(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSLvmax/*'/>
[Value("lvmax")]
	public CSSUnitValue Lvmax(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSDvw/*'/>
[Value("dvw")]
	public CSSUnitValue Dvw(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSDvh/*'/>
[Value("dvh")]
	public CSSUnitValue Dvh(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSDvi/*'/>
[Value("dvi")]
	public CSSUnitValue Dvi(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSDvb/*'/>
[Value("dvb")]
	public CSSUnitValue Dvb(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSDvmin/*'/>
[Value("dvmin")]
	public CSSUnitValue Dvmin(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSDvmax/*'/>
[Value("dvmax")]
	public CSSUnitValue Dvmax(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSCqw/*'/>
[Value("cqw")]
	public CSSUnitValue Cqw(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSCqh/*'/>
[Value("cqh")]
	public CSSUnitValue Cqh(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSCqi/*'/>
[Value("cqi")]
	public CSSUnitValue Cqi(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSCqb/*'/>
[Value("cqb")]
	public CSSUnitValue Cqb(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSCqmin/*'/>
[Value("cqmin")]
	public CSSUnitValue Cqmin(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSCqmax/*'/>
[Value("cqmax")]
	public CSSUnitValue Cqmax(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSCm/*'/>
[Value("cm")]
	public CSSUnitValue Cm(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSMm/*'/>
[Value("mm")]
	public CSSUnitValue Mm(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSQ/*'/>
[Value("Q")]
	public CSSUnitValue Q(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSIn/*'/>
[Value("in")]
	public CSSUnitValue In(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSPt/*'/>
[Value("pt")]
	public CSSUnitValue Pt(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSPc/*'/>
[Value("pc")]
	public CSSUnitValue Pc(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSPx/*'/>
[Value("px")]
	public CSSUnitValue Px(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSDeg/*'/>
[Value("deg")]
	public CSSUnitValue Deg(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSGrad/*'/>
[Value("grad")]
	public CSSUnitValue Grad(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSRad/*'/>
[Value("rad")]
	public CSSUnitValue Rad(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSTurn/*'/>
[Value("turn")]
	public CSSUnitValue Turn(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSS/*'/>
[Value("s")]
	public CSSUnitValue S(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSMs/*'/>
[Value("ms")]
	public CSSUnitValue Ms(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSHz/*'/>
[Value("Hz")]
	public CSSUnitValue Hz(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSKHz/*'/>
[Value("kHz")]
	public CSSUnitValue KHz(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSDpi/*'/>
[Value("dpi")]
	public CSSUnitValue Dpi(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSDpcm/*'/>
[Value("dpcm")]
	public CSSUnitValue Dpcm(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSDppx/*'/>
[Value("dppx")]
	public CSSUnitValue Dppx(Number value) { throw new System.NotImplementedException(); }
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSFr/*'/>
[Value("fr")]
	public CSSUnitValue Fr(Number value) { throw new System.NotImplementedException(); }
}

///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSS/*'/>
public partial class CSS
{
	///<include file='CSharpToJavaScript/Utils/Docs/css/css.generated.xml' path='docs/CSSEscape/*'/>
[Value("escape")]
	public CSSOMString Escape(CSSOMString ident) { throw new System.NotImplementedException(); }
}

[Value("TestUtils")]
public partial class TestUtils
{
	[Value("gc")]
	public Task<Undefined> Gc() { throw new System.NotImplementedException(); }
}

[Value("WebAssembly")]
public partial class WebAssembly
{
	[Value("validate")]
	public bool Validate(BufferSource bytes) { throw new System.NotImplementedException(); }
	[Value("compile")]
	public Task<Module> Compile(BufferSource bytes) { throw new System.NotImplementedException(); }
	[Value("instantiate")]
	public Task<WebAssemblyInstantiatedSource> Instantiate(BufferSource bytes, Object importObject = default) { throw new System.NotImplementedException(); }
	[Value("instantiate")]
	public Task<Instance> Instantiate(Module moduleObject, Object importObject = default) { throw new System.NotImplementedException(); }
}

public partial class WebAssembly
{
	[Value("compileStreaming")]
	public Task<Module> CompileStreaming(Task<Response> source) { throw new System.NotImplementedException(); }
	[Value("instantiateStreaming")]
	public Task<WebAssemblyInstantiatedSource> InstantiateStreaming(Task<Response> source, Object importObject = default) { throw new System.NotImplementedException(); }
}

[Value("GPUBufferUsage")]
public partial class GPUBufferUsage
{
	[Value("MAP_READ")]
	public const GPUFlagsConstant MAP_READ = 0x0001;
	[Value("MAP_WRITE")]
	public const GPUFlagsConstant MAP_WRITE = 0x0002;
	[Value("COPY_SRC")]
	public const GPUFlagsConstant COPY_SRC = 0x0004;
	[Value("COPY_DST")]
	public const GPUFlagsConstant COPY_DST = 0x0008;
	[Value("INDEX")]
	public const GPUFlagsConstant INDEX = 0x0010;
	[Value("VERTEX")]
	public const GPUFlagsConstant VERTEX = 0x0020;
	[Value("UNIFORM")]
	public const GPUFlagsConstant UNIFORM = 0x0040;
	[Value("STORAGE")]
	public const GPUFlagsConstant STORAGE = 0x0080;
	[Value("INDIRECT")]
	public const GPUFlagsConstant INDIRECT = 0x0100;
	[Value("QUERY_RESOLVE")]
	public const GPUFlagsConstant QUERY_RESOLVE = 0x0200;
}


[Value("GPUMapMode")]
public partial class GPUMapMode
{
	[Value("READ")]
	public const GPUFlagsConstant READ = 0x0001;
	[Value("WRITE")]
	public const GPUFlagsConstant WRITE = 0x0002;
}

[Value("GPUTextureUsage")]
public partial class GPUTextureUsage
{
	[Value("COPY_SRC")]
	public const GPUFlagsConstant COPY_SRC = 0x01;
	[Value("COPY_DST")]
	public const GPUFlagsConstant COPY_DST = 0x02;
	[Value("TEXTURE_BINDING")]
	public const GPUFlagsConstant TEXTURE_BINDING = 0x04;
	[Value("STORAGE_BINDING")]
	public const GPUFlagsConstant STORAGE_BINDING = 0x08;
	[Value("RENDER_ATTACHMENT")]
	public const GPUFlagsConstant RENDER_ATTACHMENT = 0x10;
}

[Value("GPUShaderStage")]
public partial class GPUShaderStage
{
	[Value("VERTEX")]
	public const GPUFlagsConstant VERTEX = 0x1;
	[Value("FRAGMENT")]
	public const GPUFlagsConstant FRAGMENT = 0x2;
	[Value("COMPUTE")]
	public const GPUFlagsConstant COMPUTE = 0x4;
}

[Value("GPUColorWrite")]
public partial class GPUColorWrite
{
	[Value("RED")]
	public const GPUFlagsConstant RED = 0x1;
	[Value("GREEN")]
	public const GPUFlagsConstant GREEN = 0x2;
	[Value("BLUE")]
	public const GPUFlagsConstant BLUE = 0x4;
	[Value("ALPHA")]
	public const GPUFlagsConstant ALPHA = 0x8;
	[Value("ALL")]
	public const GPUFlagsConstant ALL = 0xF;
}

