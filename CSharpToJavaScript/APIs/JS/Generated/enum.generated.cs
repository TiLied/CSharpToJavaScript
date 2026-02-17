//16.02.2026 21:28:23

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


[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AccelerometerLocalCoordinateSystem
{
	[Value("\"device\"")]
	Device,
	[Value("\"screen\"")]
	Screen,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AudioSessionType
{
	[Value("\"auto\"")]
	Auto,
	[Value("\"playback\"")]
	Playback,
	[Value("\"transient\"")]
	Transient,
	[Value("\"transient-solo\"")]
	TransientSolo,
	[Value("\"ambient\"")]
	Ambient,
	[Value("\"play-and-record\"")]
	PlayAndRecord,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AudioSessionState
{
	[Value("\"inactive\"")]
	Inactive,
	[Value("\"active\"")]
	Active,
	[Value("\"interrupted\"")]
	Interrupted,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AutoplayPolicy
{
	[Value("\"allowed\"")]
	Allowed,
	[Value("\"allowed-muted\"")]
	AllowedMuted,
	[Value("\"disallowed\"")]
	Disallowed,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AutoplayPolicyMediaType
{
	[Value("\"mediaelement\"")]
	Mediaelement,
	[Value("\"audiocontext\"")]
	Audiocontext,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum BackgroundFetchResult
{
	[Value("\"\"")]
	Empty,
	[Value("\"success\"")]
	Success,
	[Value("\"failure\"")]
	Failure,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum BackgroundFetchFailureReason
{
	[Value("\"\"")]
	Empty,
	[Value("\"aborted\"")]
	Aborted,
	[Value("\"bad-status\"")]
	BadStatus,
	[Value("\"fetch-error\"")]
	FetchError,
	[Value("\"quota-exceeded\"")]
	QuotaExceeded,
	[Value("\"download-total-exceeded\"")]
	DownloadTotalExceeded,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum PresentationStyle
{
	[Value("\"unspecified\"")]
	Unspecified,
	[Value("\"inline\"")]
	Inline,
	[Value("\"attachment\"")]
	Attachment,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CompressionFormat
{
	[Value("\"deflate\"")]
	Deflate,
	[Value("\"deflate-raw\"")]
	DeflateRaw,
	[Value("\"gzip\"")]
	Gzip,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum PressureSource
{
	[Value("\"cpu\"")]
	Cpu,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum PressureState
{
	[Value("\"nominal\"")]
	Nominal,
	[Value("\"fair\"")]
	Fair,
	[Value("\"serious\"")]
	Serious,
	[Value("\"critical\"")]
	Critical,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ContactProperty
{
	[Value("\"address\"")]
	Address,
	[Value("\"email\"")]
	Email,
	[Value("\"icon\"")]
	Icon,
	[Value("\"name\"")]
	Name,
	[Value("\"tel\"")]
	Tel,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ContentCategory
{
	[Value("\"\"")]
	Empty,
	[Value("\"homepage\"")]
	Homepage,
	[Value("\"article\"")]
	Article,
	[Value("\"video\"")]
	Video,
	[Value("\"audio\"")]
	Audio,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CookieSameSite
{
	[Value("\"strict\"")]
	Strict,
	[Value("\"lax\"")]
	Lax,
	[Value("\"none\"")]
	None,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CredentialMediationRequirement
{
	[Value("\"silent\"")]
	Silent,
	[Value("\"optional\"")]
	Optional,
	[Value("\"conditional\"")]
	Conditional,
	[Value("\"required\"")]
	Required,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ScriptingPolicyViolationType
{
	[Value("\"externalScript\"")]
	ExternalScript,
	[Value("\"inlineScript\"")]
	InlineScript,
	[Value("\"inlineEventHandler\"")]
	InlineEventHandler,
	[Value("\"eval\"")]
	Eval,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum SecurityPolicyViolationEventDisposition
{
	[Value("\"enforce\"")]
	Enforce,
	[Value("\"report\"")]
	Report,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum FontFaceLoadStatus
{
	[Value("\"unloaded\"")]
	Unloaded,
	[Value("\"loading\"")]
	Loading,
	[Value("\"loaded\"")]
	Loaded,
	[Value("\"error\"")]
	Error,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum FontFaceSetLoadStatus
{
	[Value("\"loading\"")]
	Loading,
	[Value("\"loaded\"")]
	Loaded,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum HighlightType
{
	[Value("\"highlight\"")]
	Highlight,
	[Value("\"spelling-error\"")]
	SpellingError,
	[Value("\"grammar-error\"")]
	GrammarError,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ChildDisplayType
{
	[Value("\"block\"")]
	Block,
	[Value("\"normal\"")]
	Normal,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum LayoutSizingMode
{
	[Value("\"block-like\"")]
	BlockLike,
	[Value("\"manual\"")]
	Manual,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum BlockFragmentationType
{
	[Value("\"none\"")]
	None,
	[Value("\"page\"")]
	Page,
	[Value("\"column\"")]
	Column,
	[Value("\"region\"")]
	Region,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum BreakType
{
	[Value("\"none\"")]
	None,
	[Value("\"line\"")]
	Line,
	[Value("\"column\"")]
	Column,
	[Value("\"page\"")]
	Page,
	[Value("\"region\"")]
	Region,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum SpatialNavigationDirection
{
	[Value("\"up\"")]
	Up,
	[Value("\"down\"")]
	Down,
	[Value("\"left\"")]
	Left,
	[Value("\"right\"")]
	Right,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum FocusableAreaSearchMode
{
	[Value("\"visible\"")]
	Visible,
	[Value("\"all\"")]
	All,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CSSNumericBaseType
{
	[Value("\"length\"")]
	Length,
	[Value("\"angle\"")]
	Angle,
	[Value("\"time\"")]
	Time,
	[Value("\"frequency\"")]
	Frequency,
	[Value("\"resolution\"")]
	Resolution,
	[Value("\"flex\"")]
	Flex,
	[Value("\"percent\"")]
	Percent,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CSSMathOperator
{
	[Value("\"sum\"")]
	Sum,
	[Value("\"product\"")]
	Product,
	[Value("\"negate\"")]
	Negate,
	[Value("\"invert\"")]
	Invert,
	[Value("\"min\"")]
	Min,
	[Value("\"max\"")]
	Max,
	[Value("\"clamp\"")]
	Clamp,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ScrollBehavior
{
	[Value("\"auto\"")]
	Auto,
	[Value("\"instant\"")]
	Instant,
	[Value("\"smooth\"")]
	Smooth,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ScrollLogicalPosition
{
	[Value("\"start\"")]
	Start,
	[Value("\"center\"")]
	Center,
	[Value("\"end\"")]
	End,
	[Value("\"nearest\"")]
	Nearest,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CSSBoxType
{
	[Value("\"margin\"")]
	Margin,
	[Value("\"border\"")]
	Border,
	[Value("\"padding\"")]
	Padding,
	[Value("\"content\"")]
	Content,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum DevicePostureType
{
	[Value("\"continuous\"")]
	Continuous,
	[Value("\"folded\"")]
	Folded,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ItemType
{
	[Value("\"product\"")]
	Product,
	[Value("\"subscription\"")]
	Subscription,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ShadowRootMode
{
	[Value("\"open\"")]
	Open,
	[Value("\"closed\"")]
	Closed,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum SlotAssignmentMode
{
	[Value("\"manual\"")]
	Manual,
	[Value("\"named\"")]
	Named,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum UnderlineStyle
{
	[Value("\"none\"")]
	None,
	[Value("\"solid\"")]
	Solid,
	[Value("\"dotted\"")]
	Dotted,
	[Value("\"dashed\"")]
	Dashed,
	[Value("\"wavy\"")]
	Wavy,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum UnderlineThickness
{
	[Value("\"none\"")]
	None,
	[Value("\"thin\"")]
	Thin,
	[Value("\"thick\"")]
	Thick,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MediaKeysRequirement
{
	[Value("\"required\"")]
	Required,
	[Value("\"optional\"")]
	Optional,
	[Value("\"not-allowed\"")]
	NotAllowed,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MediaKeySessionType
{
	[Value("\"temporary\"")]
	Temporary,
	[Value("\"persistent-license\"")]
	PersistentLicense,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MediaKeySessionClosedReason
{
	[Value("\"internal-error\"")]
	InternalError,
	[Value("\"closed-by-application\"")]
	ClosedByApplication,
	[Value("\"release-acknowledged\"")]
	ReleaseAcknowledged,
	[Value("\"hardware-context-reset\"")]
	HardwareContextReset,
	[Value("\"resource-evicted\"")]
	ResourceEvicted,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MediaKeyStatus
{
	[Value("\"usable\"")]
	Usable,
	[Value("\"expired\"")]
	Expired,
	[Value("\"released\"")]
	Released,
	[Value("\"output-restricted\"")]
	OutputRestricted,
	[Value("\"output-downscaled\"")]
	OutputDownscaled,
	[Value("\"usable-in-future\"")]
	UsableInFuture,
	[Value("\"status-pending\"")]
	StatusPending,
	[Value("\"internal-error\"")]
	InternalError,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MediaKeyMessageType
{
	[Value("\"license-request\"")]
	LicenseRequest,
	[Value("\"license-renewal\"")]
	LicenseRenewal,
	[Value("\"license-release\"")]
	LicenseRelease,
	[Value("\"individualization-request\"")]
	IndividualizationRequest,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum IdentityCredentialRequestOptionsContext
{
	[Value("\"signin\"")]
	Signin,
	[Value("\"signup\"")]
	Signup,
	[Value("\"use\"")]
	Use,
	[Value("\"continue\"")]
	Continue,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum IdentityCredentialRequestOptionsMode
{
	[Value("\"active\"")]
	Active,
	[Value("\"passive\"")]
	Passive,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum OpaqueProperty
{
	[Value("\"opaque\"")]
	Opaque,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum FenceReportingDestination
{
	[Value("\"buyer\"")]
	Buyer,
	[Value("\"seller\"")]
	Seller,
	[Value("\"component-seller\"")]
	ComponentSeller,
	[Value("\"direct-seller\"")]
	DirectSeller,
	[Value("\"shared-storage-select-url\"")]
	SharedStorageSelectUrl,
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestDestination/*'/>
[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RequestDestination
{
	[Value("\"\"")]
	Empty,
	[Value("\"audio\"")]
	Audio,
	[Value("\"audioworklet\"")]
	Audioworklet,
	[Value("\"document\"")]
	Document,
	[Value("\"embed\"")]
	Embed,
	[Value("\"font\"")]
	Font,
	[Value("\"frame\"")]
	Frame,
	[Value("\"iframe\"")]
	Iframe,
	[Value("\"image\"")]
	Image,
	[Value("\"json\"")]
	Json,
	[Value("\"manifest\"")]
	Manifest,
	[Value("\"object\"")]
	Object,
	[Value("\"paintworklet\"")]
	Paintworklet,
	[Value("\"report\"")]
	Report,
	[Value("\"script\"")]
	Script,
	[Value("\"sharedworker\"")]
	Sharedworker,
	[Value("\"style\"")]
	Style,
	[Value("\"track\"")]
	Track,
	[Value("\"video\"")]
	Video,
	[Value("\"worker\"")]
	Worker,
	[Value("\"xslt\"")]
	Xslt,
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestMode/*'/>
[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RequestMode
{
	[Value("\"navigate\"")]
	Navigate,
	[Value("\"same-origin\"")]
	SameOrigin,
	[Value("\"no-cors\"")]
	NoCors,
	[Value("\"cors\"")]
	Cors,
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestCredentials/*'/>
[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RequestCredentials
{
	[Value("\"omit\"")]
	Omit,
	[Value("\"same-origin\"")]
	SameOrigin,
	[Value("\"include\"")]
	Include,
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestCache/*'/>
[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RequestCache
{
	[Value("\"default\"")]
	Default,
	[Value("\"no-store\"")]
	NoStore,
	[Value("\"reload\"")]
	Reload,
	[Value("\"no-cache\"")]
	NoCache,
	[Value("\"force-cache\"")]
	ForceCache,
	[Value("\"only-if-cached\"")]
	OnlyIfCached,
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestRedirect/*'/>
[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RequestRedirect
{
	[Value("\"follow\"")]
	Follow,
	[Value("\"error\"")]
	Error,
	[Value("\"manual\"")]
	Manual,
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestDuplex/*'/>
[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RequestDuplex
{
	[Value("\"half\"")]
	Half,
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestPriority/*'/>
[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RequestPriority
{
	[Value("\"high\"")]
	High,
	[Value("\"low\"")]
	Low,
	[Value("\"auto\"")]
	Auto,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ResponseType
{
	[Value("\"basic\"")]
	Basic,
	[Value("\"cors\"")]
	Cors,
	[Value("\"default\"")]
	Default,
	[Value("\"error\"")]
	Error,
	[Value("\"opaque\"")]
	Opaque,
	[Value("\"opaqueredirect\"")]
	Opaqueredirect,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum FileSystemPermissionMode
{
	[Value("\"read\"")]
	Read,
	[Value("\"readwrite\"")]
	Readwrite,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum WellKnownDirectory
{
	[Value("\"desktop\"")]
	Desktop,
	[Value("\"documents\"")]
	Documents,
	[Value("\"downloads\"")]
	Downloads,
	[Value("\"music\"")]
	Music,
	[Value("\"pictures\"")]
	Pictures,
	[Value("\"videos\"")]
	Videos,
}


[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum EndingType
{
	[Value("\"transparent\"")]
	Transparent,
	[Value("\"native\"")]
	Native,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum FileSystemHandleKind
{
	[Value("\"file\"")]
	File,
	[Value("\"directory\"")]
	Directory,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum WriteCommandType
{
	[Value("\"write\"")]
	Write,
	[Value("\"seek\"")]
	Seek,
	[Value("\"truncate\"")]
	Truncate,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum FullscreenNavigationUI
{
	[Value("\"auto\"")]
	Auto,
	[Value("\"show\"")]
	Show,
	[Value("\"hide\"")]
	Hide,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GamepadHand
{
	[Value("\"\"")]
	Empty,
	[Value("\"left\"")]
	Left,
	[Value("\"right\"")]
	Right,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GamepadMappingType
{
	[Value("\"\"")]
	Empty,
	[Value("\"standard\"")]
	Standard,
	[Value("\"xr-standard\"")]
	XrStandard,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GamepadHapticsResult
{
	[Value("\"complete\"")]
	Complete,
	[Value("\"preempted\"")]
	Preempted,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GamepadHapticEffectType
{
	[Value("\"dual-rumble\"")]
	DualRumble,
	[Value("\"trigger-rumble\"")]
	TriggerRumble,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GyroscopeLocalCoordinateSystem
{
	[Value("\"device\"")]
	Device,
	[Value("\"screen\"")]
	Screen,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum HandwritingRecognitionType
{
	[Value("\"text\"")]
	Text,
	[Value("\"per-character\"")]
	PerCharacter,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum HandwritingInputType
{
	[Value("\"mouse\"")]
	Mouse,
	[Value("\"stylus\"")]
	Stylus,
	[Value("\"touch\"")]
	Touch,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum DocumentReadyState
{
	[Value("\"loading\"")]
	Loading,
	[Value("\"interactive\"")]
	Interactive,
	[Value("\"complete\"")]
	Complete,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum DocumentVisibilityState
{
	[Value("\"visible\"")]
	Visible,
	[Value("\"hidden\"")]
	Hidden,
}


[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CanPlayTypeResult
{
	[Value("\"\"")]
	Empty,
	[Value("\"maybe\"")]
	Maybe,
	[Value("\"probably\"")]
	Probably,
}


[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum TextTrackMode
{
	[Value("\"disabled\"")]
	Disabled,
	[Value("\"hidden\"")]
	Hidden,
	[Value("\"showing\"")]
	Showing,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum TextTrackKind
{
	[Value("\"subtitles\"")]
	Subtitles,
	[Value("\"captions\"")]
	Captions,
	[Value("\"descriptions\"")]
	Descriptions,
	[Value("\"chapters\"")]
	Chapters,
	[Value("\"metadata\"")]
	Metadata,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum SelectionMode
{
	[Value("\"select\"")]
	Select,
	[Value("\"start\"")]
	Start,
	[Value("\"end\"")]
	End,
	[Value("\"preserve\"")]
	Preserve,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum PredefinedColorSpace
{
	[Value("\"srgb\"")]
	Srgb,
	[Value("\"display-p3\"")]
	DisplayP3,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CanvasFillRule
{
	[Value("\"nonzero\"")]
	Nonzero,
	[Value("\"evenodd\"")]
	Evenodd,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ImageSmoothingQuality
{
	[Value("\"low\"")]
	Low,
	[Value("\"medium\"")]
	Medium,
	[Value("\"high\"")]
	High,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CanvasLineCap
{
	[Value("\"butt\"")]
	Butt,
	[Value("\"round\"")]
	Round,
	[Value("\"square\"")]
	Square,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CanvasLineJoin
{
	[Value("\"round\"")]
	Round,
	[Value("\"bevel\"")]
	Bevel,
	[Value("\"miter\"")]
	Miter,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CanvasTextAlign
{
	[Value("\"start\"")]
	Start,
	[Value("\"end\"")]
	End,
	[Value("\"left\"")]
	Left,
	[Value("\"right\"")]
	Right,
	[Value("\"center\"")]
	Center,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CanvasTextBaseline
{
	[Value("\"top\"")]
	Top,
	[Value("\"hanging\"")]
	Hanging,
	[Value("\"middle\"")]
	Middle,
	[Value("\"alphabetic\"")]
	Alphabetic,
	[Value("\"ideographic\"")]
	Ideographic,
	[Value("\"bottom\"")]
	Bottom,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CanvasDirection
{
	[Value("\"ltr\"")]
	Ltr,
	[Value("\"rtl\"")]
	Rtl,
	[Value("\"inherit\"")]
	Inherit,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CanvasFontKerning
{
	[Value("\"auto\"")]
	Auto,
	[Value("\"normal\"")]
	Normal,
	[Value("\"none\"")]
	None,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CanvasFontStretch
{
	[Value("\"ultra-condensed\"")]
	UltraCondensed,
	[Value("\"extra-condensed\"")]
	ExtraCondensed,
	[Value("\"condensed\"")]
	Condensed,
	[Value("\"semi-condensed\"")]
	SemiCondensed,
	[Value("\"normal\"")]
	Normal,
	[Value("\"semi-expanded\"")]
	SemiExpanded,
	[Value("\"expanded\"")]
	Expanded,
	[Value("\"extra-expanded\"")]
	ExtraExpanded,
	[Value("\"ultra-expanded\"")]
	UltraExpanded,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CanvasFontVariantCaps
{
	[Value("\"normal\"")]
	Normal,
	[Value("\"small-caps\"")]
	SmallCaps,
	[Value("\"all-small-caps\"")]
	AllSmallCaps,
	[Value("\"petite-caps\"")]
	PetiteCaps,
	[Value("\"all-petite-caps\"")]
	AllPetiteCaps,
	[Value("\"unicase\"")]
	Unicase,
	[Value("\"titling-caps\"")]
	TitlingCaps,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CanvasTextRendering
{
	[Value("\"auto\"")]
	Auto,
	[Value("\"optimizeSpeed\"")]
	OptimizeSpeed,
	[Value("\"optimizeLegibility\"")]
	OptimizeLegibility,
	[Value("\"geometricPrecision\"")]
	GeometricPrecision,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum OffscreenRenderingContextId
{
	[Value("\"2d\"")]
	_2d,
	[Value("\"bitmaprenderer\"")]
	Bitmaprenderer,
	[Value("\"webgl\"")]
	Webgl,
	[Value("\"webgl2\"")]
	Webgl2,
	[Value("\"webgpu\"")]
	Webgpu,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ScrollRestoration
{
	[Value("\"auto\"")]
	Auto,
	[Value("\"manual\"")]
	Manual,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum NavigationHistoryBehavior
{
	[Value("\"auto\"")]
	Auto,
	[Value("\"push\"")]
	Push,
	[Value("\"replace\"")]
	Replace,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum NavigationType
{
	[Value("\"push\"")]
	Push,
	[Value("\"replace\"")]
	Replace,
	[Value("\"reload\"")]
	Reload,
	[Value("\"traverse\"")]
	Traverse,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum NavigationFocusReset
{
	[Value("\"after-transition\"")]
	AfterTransition,
	[Value("\"manual\"")]
	Manual,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum NavigationScrollBehavior
{
	[Value("\"after-transition\"")]
	AfterTransition,
	[Value("\"manual\"")]
	Manual,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum DOMParserSupportedType
{
	[Value("\"text/html\"")]
	TextHtml,
	[Value("\"text/xml\"")]
	TextXml,
	[Value("\"application/xml\"")]
	ApplicationXml,
	[Value("\"application/xhtml+xml\"")]
	ApplicationXhtmlXml,
	[Value("\"image/svg+xml\"")]
	ImageSvgXml,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ImageOrientation
{
	[Value("\"from-image\"")]
	FromImage,
	[Value("\"flipY\"")]
	FlipY,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum PremultiplyAlpha
{
	[Value("\"none\"")]
	None,
	[Value("\"premultiply\"")]
	Premultiply,
	[Value("\"default\"")]
	Default,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ColorSpaceConversion
{
	[Value("\"none\"")]
	None,
	[Value("\"default\"")]
	Default,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ResizeQuality
{
	[Value("\"pixelated\"")]
	Pixelated,
	[Value("\"low\"")]
	Low,
	[Value("\"medium\"")]
	Medium,
	[Value("\"high\"")]
	High,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum WorkerType
{
	[Value("\"classic\"")]
	Classic,
	[Value("\"module\"")]
	Module,
}



[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum UserIdleState
{
	[Value("\"active\"")]
	Active,
	[Value("\"idle\"")]
	Idle,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ScreenIdleState
{
	[Value("\"locked\"")]
	Locked,
	[Value("\"unlocked\"")]
	Unlocked,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RedEyeReduction
{
	[Value("\"never\"")]
	Never,
	[Value("\"always\"")]
	Always,
	[Value("\"controllable\"")]
	Controllable,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum FillLightMode
{
	[Value("\"auto\"")]
	Auto,
	[Value("\"off\"")]
	Off,
	[Value("\"flash\"")]
	Flash,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MeteringMode
{
	[Value("\"none\"")]
	None,
	[Value("\"manual\"")]
	Manual,
	[Value("\"single-shot\"")]
	SingleShot,
	[Value("\"continuous\"")]
	Continuous,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum IDBRequestReadyState
{
	[Value("\"pending\"")]
	Pending,
	[Value("\"done\"")]
	Done,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum IDBTransactionDurability
{
	[Value("\"default\"")]
	Default,
	[Value("\"strict\"")]
	Strict,
	[Value("\"relaxed\"")]
	Relaxed,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum IDBCursorDirection
{
	[Value("\"next\"")]
	Next,
	[Value("\"nextunique\"")]
	Nextunique,
	[Value("\"prev\"")]
	Prev,
	[Value("\"prevunique\"")]
	Prevunique,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum IDBTransactionMode
{
	[Value("\"readonly\"")]
	Readonly,
	[Value("\"readwrite\"")]
	Readwrite,
	[Value("\"versionchange\"")]
	Versionchange,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum LoginStatus
{
	[Value("\"logged-in\"")]
	LoggedIn,
	[Value("\"logged-out\"")]
	LoggedOut,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ScriptInvokerType
{
	[Value("\"classic-script\"")]
	ClassicScript,
	[Value("\"module-script\"")]
	ModuleScript,
	[Value("\"event-listener\"")]
	EventListener,
	[Value("\"user-callback\"")]
	UserCallback,
	[Value("\"resolve-promise\"")]
	ResolvePromise,
	[Value("\"reject-promise\"")]
	RejectPromise,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ScriptWindowAttribution
{
	[Value("\"self\"")]
	Self,
	[Value("\"descendant\"")]
	Descendant,
	[Value("\"ancestor\"")]
	Ancestor,
	[Value("\"same-page\"")]
	SamePage,
	[Value("\"other\"")]
	Other,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MagnetometerLocalCoordinateSystem
{
	[Value("\"device\"")]
	Device,
	[Value("\"screen\"")]
	Screen,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AppBannerPromptOutcome
{
	[Value("\"accepted\"")]
	Accepted,
	[Value("\"dismissed\"")]
	Dismissed,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MediaDecodingType
{
	[Value("\"file\"")]
	File,
	[Value("\"media-source\"")]
	MediaSource,
	[Value("\"webrtc\"")]
	Webrtc,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MediaEncodingType
{
	[Value("\"record\"")]
	Record,
	[Value("\"webrtc\"")]
	Webrtc,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum HdrMetadataType
{
	[Value("\"smpteSt2086\"")]
	SmpteSt2086,
	[Value("\"smpteSt2094-10\"")]
	SmpteSt209410,
	[Value("\"smpteSt2094-40\"")]
	SmpteSt209440,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ColorGamut
{
	[Value("\"srgb\"")]
	Srgb,
	[Value("\"p3\"")]
	P3,
	[Value("\"rec2020\"")]
	Rec2020,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum TransferFunction
{
	[Value("\"srgb\"")]
	Srgb,
	[Value("\"pq\"")]
	Pq,
	[Value("\"hlg\"")]
	Hlg,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ReadyState
{
	[Value("\"closed\"")]
	Closed,
	[Value("\"open\"")]
	Open,
	[Value("\"ended\"")]
	Ended,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum EndOfStreamError
{
	[Value("\"network\"")]
	Network,
	[Value("\"decode\"")]
	Decode,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AppendMode
{
	[Value("\"segments\"")]
	Segments,
	[Value("\"sequence\"")]
	Sequence,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MockCapturePromptResult
{
	[Value("\"granted\"")]
	Granted,
	[Value("\"denied\"")]
	Denied,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CaptureAction
{
	[Value("\"next\"")]
	Next,
	[Value("\"previous\"")]
	Previous,
	[Value("\"first\"")]
	First,
	[Value("\"last\"")]
	Last,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MediaStreamTrackState
{
	[Value("\"live\"")]
	Live,
	[Value("\"ended\"")]
	Ended,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum VideoFacingModeEnum
{
	[Value("\"user\"")]
	User,
	[Value("\"environment\"")]
	Environment,
	[Value("\"left\"")]
	Left,
	[Value("\"right\"")]
	Right,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum VideoResizeModeEnum
{
	[Value("\"none\"")]
	None,
	[Value("\"crop-and-scale\"")]
	CropAndScale,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MediaDeviceKind
{
	[Value("\"audioinput\"")]
	Audioinput,
	[Value("\"audiooutput\"")]
	Audiooutput,
	[Value("\"videoinput\"")]
	Videoinput,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MediaSessionPlaybackState
{
	[Value("\"none\"")]
	None,
	[Value("\"paused\"")]
	Paused,
	[Value("\"playing\"")]
	Playing,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MediaSessionAction
{
	[Value("\"play\"")]
	Play,
	[Value("\"pause\"")]
	Pause,
	[Value("\"seekbackward\"")]
	Seekbackward,
	[Value("\"seekforward\"")]
	Seekforward,
	[Value("\"previoustrack\"")]
	Previoustrack,
	[Value("\"nexttrack\"")]
	Nexttrack,
	[Value("\"skipad\"")]
	Skipad,
	[Value("\"stop\"")]
	Stop,
	[Value("\"seekto\"")]
	Seekto,
	[Value("\"togglemicrophone\"")]
	Togglemicrophone,
	[Value("\"togglecamera\"")]
	Togglecamera,
	[Value("\"togglescreenshare\"")]
	Togglescreenshare,
	[Value("\"hangup\"")]
	Hangup,
	[Value("\"previousslide\"")]
	Previousslide,
	[Value("\"nextslide\"")]
	Nextslide,
	[Value("\"enterpictureinpicture\"")]
	Enterpictureinpicture,
	[Value("\"voiceactivity\"")]
	Voiceactivity,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum BitrateMode
{
	[Value("\"constant\"")]
	Constant,
	[Value("\"variable\"")]
	Variable,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RecordingState
{
	[Value("\"inactive\"")]
	Inactive,
	[Value("\"recording\"")]
	Recording,
	[Value("\"paused\"")]
	Paused,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCDegradationPreference
{
	[Value("\"maintain-framerate\"")]
	MaintainFramerate,
	[Value("\"maintain-resolution\"")]
	MaintainResolution,
	[Value("\"balanced\"")]
	Balanced,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum NavigationTimingType
{
	[Value("\"navigate\"")]
	Navigate,
	[Value("\"reload\"")]
	Reload,
	[Value("\"back_forward\"")]
	Back_forward,
	[Value("\"prerender\"")]
	Prerender,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ConnectionType
{
	[Value("\"bluetooth\"")]
	Bluetooth,
	[Value("\"cellular\"")]
	Cellular,
	[Value("\"ethernet\"")]
	Ethernet,
	[Value("\"mixed\"")]
	Mixed,
	[Value("\"none\"")]
	None,
	[Value("\"other\"")]
	Other,
	[Value("\"unknown\"")]
	Unknown,
	[Value("\"wifi\"")]
	Wifi,
	[Value("\"wimax\"")]
	Wimax,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum EffectiveConnectionType
{
	[Value("\"2g\"")]
	_2g,
	[Value("\"3g\"")]
	_3g,
	[Value("\"4g\"")]
	_4g,
	[Value("\"slow-2g\"")]
	Slow2g,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum NotificationPermission
{
	[Value("\"default\"")]
	Default,
	[Value("\"denied\"")]
	Denied,
	[Value("\"granted\"")]
	Granted,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum NotificationDirection
{
	[Value("\"auto\"")]
	Auto,
	[Value("\"ltr\"")]
	Ltr,
	[Value("\"rtl\"")]
	Rtl,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum OrientationSensorLocalCoordinateSystem
{
	[Value("\"device\"")]
	Device,
	[Value("\"screen\"")]
	Screen,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ClientLifecycleState
{
	[Value("\"active\"")]
	Active,
	[Value("\"frozen\"")]
	Frozen,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum PaymentDelegation
{
	[Value("\"shippingAddress\"")]
	ShippingAddress,
	[Value("\"payerName\"")]
	PayerName,
	[Value("\"payerPhone\"")]
	PayerPhone,
	[Value("\"payerEmail\"")]
	PayerEmail,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum PaymentShippingType
{
	[Value("\"shipping\"")]
	Shipping,
	[Value("\"delivery\"")]
	Delivery,
	[Value("\"pickup\"")]
	Pickup,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum PaymentComplete
{
	[Value("\"fail\"")]
	Fail,
	[Value("\"success\"")]
	Success,
	[Value("\"unknown\"")]
	Unknown,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum PermissionState
{
	[Value("\"granted\"")]
	Granted,
	[Value("\"denied\"")]
	Denied,
	[Value("\"prompt\"")]
	Prompt,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum PresentationConnectionState
{
	[Value("\"connecting\"")]
	Connecting,
	[Value("\"connected\"")]
	Connected,
	[Value("\"closed\"")]
	Closed,
	[Value("\"terminated\"")]
	Terminated,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum PresentationConnectionCloseReason
{
	[Value("\"error\"")]
	Error,
	[Value("\"closed\"")]
	Closed,
	[Value("\"wentaway\"")]
	Wentaway,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum IPAddressSpace
{
	[Value("\"public\"")]
	Public,
	[Value("\"private\"")]
	Private,
	[Value("\"local\"")]
	Local,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum PushEncryptionKeyName
{
	[Value("\"p256dh\"")]
	P256dh,
	[Value("\"auth\"")]
	Auth,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ReferrerPolicy
{
	[Value("\"\"")]
	Empty,
	[Value("\"no-referrer\"")]
	NoReferrer,
	[Value("\"no-referrer-when-downgrade\"")]
	NoReferrerWhenDowngrade,
	[Value("\"same-origin\"")]
	SameOrigin,
	[Value("\"origin\"")]
	Origin,
	[Value("\"strict-origin\"")]
	StrictOrigin,
	[Value("\"origin-when-cross-origin\"")]
	OriginWhenCrossOrigin,
	[Value("\"strict-origin-when-cross-origin\"")]
	StrictOriginWhenCrossOrigin,
	[Value("\"unsafe-url\"")]
	UnsafeUrl,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RemotePlaybackState
{
	[Value("\"connecting\"")]
	Connecting,
	[Value("\"connected\"")]
	Connected,
	[Value("\"disconnected\"")]
	Disconnected,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ResizeObserverBoxOptions
{
	[Value("\"border-box\"")]
	BorderBox,
	[Value("\"content-box\"")]
	ContentBox,
	[Value("\"device-pixel-content-box\"")]
	DevicePixelContentBox,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RenderBlockingStatusType
{
	[Value("\"blocking\"")]
	Blocking,
	[Value("\"non-blocking\"")]
	NonBlocking,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum SameSiteCookiesType
{
	[Value("\"all\"")]
	All,
	[Value("\"none\"")]
	None,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum SanitizerPresets
{
	[Value("\"default\"")]
	Default,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum TaskPriority
{
	[Value("\"user-blocking\"")]
	UserBlocking,
	[Value("\"user-visible\"")]
	UserVisible,
	[Value("\"background\"")]
	Background,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CaptureStartFocusBehavior
{
	[Value("\"focus-capturing-application\"")]
	FocusCapturingApplication,
	[Value("\"focus-captured-surface\"")]
	FocusCapturedSurface,
	[Value("\"no-focus-change\"")]
	NoFocusChange,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum SelfCapturePreferenceEnum
{
	[Value("\"include\"")]
	Include,
	[Value("\"exclude\"")]
	Exclude,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum SystemAudioPreferenceEnum
{
	[Value("\"include\"")]
	Include,
	[Value("\"exclude\"")]
	Exclude,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum SurfaceSwitchingPreferenceEnum
{
	[Value("\"include\"")]
	Include,
	[Value("\"exclude\"")]
	Exclude,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MonitorTypeSurfacesEnum
{
	[Value("\"include\"")]
	Include,
	[Value("\"exclude\"")]
	Exclude,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum DisplayCaptureSurfaceType
{
	[Value("\"monitor\"")]
	Monitor,
	[Value("\"window\"")]
	Window,
	[Value("\"browser\"")]
	Browser,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CursorCaptureConstraint
{
	[Value("\"never\"")]
	Never,
	[Value("\"always\"")]
	Always,
	[Value("\"motion\"")]
	Motion,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum OrientationLockType
{
	[Value("\"any\"")]
	Any,
	[Value("\"natural\"")]
	Natural,
	[Value("\"landscape\"")]
	Landscape,
	[Value("\"portrait\"")]
	Portrait,
	[Value("\"portrait-primary\"")]
	PortraitPrimary,
	[Value("\"portrait-secondary\"")]
	PortraitSecondary,
	[Value("\"landscape-primary\"")]
	LandscapePrimary,
	[Value("\"landscape-secondary\"")]
	LandscapeSecondary,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum OrientationType
{
	[Value("\"portrait-primary\"")]
	PortraitPrimary,
	[Value("\"portrait-secondary\"")]
	PortraitSecondary,
	[Value("\"landscape-primary\"")]
	LandscapePrimary,
	[Value("\"landscape-secondary\"")]
	LandscapeSecondary,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum WakeLockType
{
	[Value("\"screen\"")]
	Screen,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ScrollAxis
{
	[Value("\"block\"")]
	Block,
	[Value("\"inline\"")]
	Inline,
	[Value("\"x\"")]
	X,
	[Value("\"y\"")]
	Y,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ParityType
{
	[Value("\"none\"")]
	None,
	[Value("\"even\"")]
	Even,
	[Value("\"odd\"")]
	Odd,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum FlowControlType
{
	[Value("\"none\"")]
	None,
	[Value("\"hardware\"")]
	Hardware,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ServiceWorkerState
{
	[Value("\"parsed\"")]
	Parsed,
	[Value("\"installing\"")]
	Installing,
	[Value("\"installed\"")]
	Installed,
	[Value("\"activating\"")]
	Activating,
	[Value("\"activated\"")]
	Activated,
	[Value("\"redundant\"")]
	Redundant,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ServiceWorkerUpdateViaCache
{
	[Value("\"imports\"")]
	Imports,
	[Value("\"all\"")]
	All,
	[Value("\"none\"")]
	None,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum FrameType
{
	[Value("\"auxiliary\"")]
	Auxiliary,
	[Value("\"top-level\"")]
	TopLevel,
	[Value("\"nested\"")]
	Nested,
	[Value("\"none\"")]
	None,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ClientType
{
	[Value("\"window\"")]
	Window,
	[Value("\"worker\"")]
	Worker,
	[Value("\"sharedworker\"")]
	Sharedworker,
	[Value("\"all\"")]
	All,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RunningStatus
{
	[Value("\"running\"")]
	Running,
	[Value("\"not-running\"")]
	NotRunning,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RouterSourceEnum
{
	[Value("\"cache\"")]
	Cache,
	[Value("\"fetch-event\"")]
	FetchEvent,
	[Value("\"network\"")]
	Network,
	[Value("\"race-network-and-fetch-handler\"")]
	RaceNetworkAndFetchHandler,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum LandmarkType
{
	[Value("\"mouth\"")]
	Mouth,
	[Value("\"eye\"")]
	Eye,
	[Value("\"nose\"")]
	Nose,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum BarcodeFormat
{
	[Value("\"aztec\"")]
	Aztec,
	[Value("\"code_128\"")]
	Code_128,
	[Value("\"code_39\"")]
	Code_39,
	[Value("\"code_93\"")]
	Code_93,
	[Value("\"codabar\"")]
	Codabar,
	[Value("\"data_matrix\"")]
	Data_matrix,
	[Value("\"ean_13\"")]
	Ean_13,
	[Value("\"ean_8\"")]
	Ean_8,
	[Value("\"itf\"")]
	Itf,
	[Value("\"pdf417\"")]
	Pdf417,
	[Value("\"qr_code\"")]
	Qr_code,
	[Value("\"unknown\"")]
	Unknown,
	[Value("\"upc_a\"")]
	Upc_a,
	[Value("\"upc_e\"")]
	Upc_e,
}


[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum SpeechRecognitionErrorCode
{
	[Value("\"no-speech\"")]
	NoSpeech,
	[Value("\"aborted\"")]
	Aborted,
	[Value("\"audio-capture\"")]
	AudioCapture,
	[Value("\"network\"")]
	Network,
	[Value("\"not-allowed\"")]
	NotAllowed,
	[Value("\"service-not-allowed\"")]
	ServiceNotAllowed,
	[Value("\"bad-grammar\"")]
	BadGrammar,
	[Value("\"language-not-supported\"")]
	LanguageNotSupported,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum SpeechSynthesisErrorCode
{
	[Value("\"canceled\"")]
	Canceled,
	[Value("\"interrupted\"")]
	Interrupted,
	[Value("\"audio-busy\"")]
	AudioBusy,
	[Value("\"audio-hardware\"")]
	AudioHardware,
	[Value("\"network\"")]
	Network,
	[Value("\"synthesis-unavailable\"")]
	SynthesisUnavailable,
	[Value("\"synthesis-failed\"")]
	SynthesisFailed,
	[Value("\"language-unavailable\"")]
	LanguageUnavailable,
	[Value("\"voice-unavailable\"")]
	VoiceUnavailable,
	[Value("\"text-too-long\"")]
	TextTooLong,
	[Value("\"invalid-argument\"")]
	InvalidArgument,
	[Value("\"not-allowed\"")]
	NotAllowed,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ReadableStreamReaderMode
{
	[Value("\"byob\"")]
	Byob,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ReadableStreamType
{
	[Value("\"bytes\"")]
	Bytes,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum TouchType
{
	[Value("\"direct\"")]
	Direct,
	[Value("\"stylus\"")]
	Stylus,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RefreshPolicy
{
	[Value("\"none\"")]
	None,
	[Value("\"refresh\"")]
	Refresh,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum TokenVersion
{
	[Value("\"1\"")]
	_1,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum OperationType
{
	[Value("\"token-request\"")]
	TokenRequest,
	[Value("\"send-redemption-record\"")]
	SendRedemptionRecord,
	[Value("\"token-redemption\"")]
	TokenRedemption,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum KAnonStatus
{
	[Value("\"passedAndEnforced\"")]
	PassedAndEnforced,
	[Value("\"passedNotEnforced\"")]
	PassedNotEnforced,
	[Value("\"belowThreshold\"")]
	BelowThreshold,
	[Value("\"notCalculated\"")]
	NotCalculated,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ImportExportKind
{
	[Value("\"function\"")]
	Function,
	[Value("\"table\"")]
	Table,
	[Value("\"memory\"")]
	Memory,
	[Value("\"global\"")]
	Global,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum TableKind
{
	[Value("\"externref\"")]
	Externref,
	[Value("\"anyfunc\"")]
	Anyfunc,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ValueType
{
	[Value("\"i32\"")]
	I32,
	[Value("\"i64\"")]
	I64,
	[Value("\"f32\"")]
	F32,
	[Value("\"f64\"")]
	F64,
	[Value("\"v128\"")]
	V128,
	[Value("\"externref\"")]
	Externref,
	[Value("\"anyfunc\"")]
	Anyfunc,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum IterationCompositeOperation
{
	[Value("\"replace\"")]
	Replace,
	[Value("\"accumulate\"")]
	Accumulate,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AnimationPlayState
{
	[Value("\"idle\"")]
	Idle,
	[Value("\"running\"")]
	Running,
	[Value("\"paused\"")]
	Paused,
	[Value("\"finished\"")]
	Finished,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AnimationReplaceState
{
	[Value("\"active\"")]
	Active,
	[Value("\"removed\"")]
	Removed,
	[Value("\"persisted\"")]
	Persisted,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum FillMode
{
	[Value("\"none\"")]
	None,
	[Value("\"forwards\"")]
	Forwards,
	[Value("\"backwards\"")]
	Backwards,
	[Value("\"both\"")]
	Both,
	[Value("\"auto\"")]
	Auto,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum PlaybackDirection
{
	[Value("\"normal\"")]
	Normal,
	[Value("\"reverse\"")]
	Reverse,
	[Value("\"alternate\"")]
	Alternate,
	[Value("\"alternate-reverse\"")]
	AlternateReverse,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CompositeOperation
{
	[Value("\"replace\"")]
	Replace,
	[Value("\"add\"")]
	Add,
	[Value("\"accumulate\"")]
	Accumulate,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CompositeOperationOrAuto
{
	[Value("\"replace\"")]
	Replace,
	[Value("\"add\"")]
	Add,
	[Value("\"accumulate\"")]
	Accumulate,
	[Value("\"auto\"")]
	Auto,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum LockMode
{
	[Value("\"shared\"")]
	Shared,
	[Value("\"exclusive\"")]
	Exclusive,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum OTPCredentialTransportType
{
	[Value("\"sms\"")]
	Sms,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AudioContextState
{
	[Value("\"suspended\"")]
	Suspended,
	[Value("\"running\"")]
	Running,
	[Value("\"closed\"")]
	Closed,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AudioContextRenderSizeCategory
{
	[Value("\"default\"")]
	Default,
	[Value("\"hardware\"")]
	Hardware,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AudioContextLatencyCategory
{
	[Value("\"balanced\"")]
	Balanced,
	[Value("\"interactive\"")]
	Interactive,
	[Value("\"playback\"")]
	Playback,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AudioSinkType
{
	[Value("\"none\"")]
	None,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ChannelCountMode
{
	[Value("\"max\"")]
	Max,
	[Value("\"clamped-max\"")]
	ClampedMax,
	[Value("\"explicit\"")]
	Explicit,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ChannelInterpretation
{
	[Value("\"speakers\"")]
	Speakers,
	[Value("\"discrete\"")]
	Discrete,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AutomationRate
{
	[Value("\"a-rate\"")]
	ARate,
	[Value("\"k-rate\"")]
	KRate,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum BiquadFilterType
{
	[Value("\"lowpass\"")]
	Lowpass,
	[Value("\"highpass\"")]
	Highpass,
	[Value("\"bandpass\"")]
	Bandpass,
	[Value("\"lowshelf\"")]
	Lowshelf,
	[Value("\"highshelf\"")]
	Highshelf,
	[Value("\"peaking\"")]
	Peaking,
	[Value("\"notch\"")]
	Notch,
	[Value("\"allpass\"")]
	Allpass,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum OscillatorType
{
	[Value("\"sine\"")]
	Sine,
	[Value("\"square\"")]
	Square,
	[Value("\"sawtooth\"")]
	Sawtooth,
	[Value("\"triangle\"")]
	Triangle,
	[Value("\"custom\"")]
	Custom,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum PanningModelType
{
	[Value("\"equalpower\"")]
	Equalpower,
	[Value("\"HRTF\"")]
	HRTF,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum DistanceModelType
{
	[Value("\"linear\"")]
	Linear,
	[Value("\"inverse\"")]
	Inverse,
	[Value("\"exponential\"")]
	Exponential,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum OverSampleType
{
	[Value("\"none\"")]
	None,
	[Value("\"2x\"")]
	_2x,
	[Value("\"4x\"")]
	_4x,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AuthenticatorAttachment
{
	[Value("\"platform\"")]
	Platform,
	[Value("\"cross-platform\"")]
	CrossPlatform,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ResidentKeyRequirement
{
	[Value("\"discouraged\"")]
	Discouraged,
	[Value("\"preferred\"")]
	Preferred,
	[Value("\"required\"")]
	Required,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AttestationConveyancePreference
{
	[Value("\"none\"")]
	None,
	[Value("\"indirect\"")]
	Indirect,
	[Value("\"direct\"")]
	Direct,
	[Value("\"enterprise\"")]
	Enterprise,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum TokenBindingStatus
{
	[Value("\"present\"")]
	Present,
	[Value("\"supported\"")]
	Supported,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum PublicKeyCredentialType
{
	[Value("\"public-key\"")]
	PublicKey,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AuthenticatorTransport
{
	[Value("\"usb\"")]
	Usb,
	[Value("\"nfc\"")]
	Nfc,
	[Value("\"ble\"")]
	Ble,
	[Value("\"smart-card\"")]
	SmartCard,
	[Value("\"hybrid\"")]
	Hybrid,
	[Value("\"internal\"")]
	Internal,
}


[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum UserVerificationRequirement
{
	[Value("\"required\"")]
	Required,
	[Value("\"preferred\"")]
	Preferred,
	[Value("\"discouraged\"")]
	Discouraged,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ClientCapability
{
	[Value("\"conditionalCreate\"")]
	ConditionalCreate,
	[Value("\"conditionalGet\"")]
	ConditionalGet,
	[Value("\"hybridTransport\"")]
	HybridTransport,
	[Value("\"passkeyPlatformAuthenticator\"")]
	PasskeyPlatformAuthenticator,
	[Value("\"userVerifyingPlatformAuthenticator\"")]
	UserVerifyingPlatformAuthenticator,
	[Value("\"relatedOrigins\"")]
	RelatedOrigins,
	[Value("\"signalAllAcceptedCredentials\"")]
	SignalAllAcceptedCredentials,
	[Value("\"signalCurrentUserDetails\"")]
	SignalCurrentUserDetails,
	[Value("\"signalUnknownCredential\"")]
	SignalUnknownCredential,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum PublicKeyCredentialHint
{
	[Value("\"security-key\"")]
	SecurityKey,
	[Value("\"client-device\"")]
	ClientDevice,
	[Value("\"hybrid\"")]
	Hybrid,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum LargeBlobSupport
{
	[Value("\"required\"")]
	Required,
	[Value("\"preferred\"")]
	Preferred,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AacBitstreamFormat
{
	[Value("\"aac\"")]
	Aac,
	[Value("\"adts\"")]
	Adts,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AvcBitstreamFormat
{
	[Value("\"annexb\"")]
	Annexb,
	[Value("\"avc\"")]
	Avc,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum HevcBitstreamFormat
{
	[Value("\"annexb\"")]
	Annexb,
	[Value("\"hevc\"")]
	Hevc,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum OpusBitstreamFormat
{
	[Value("\"opus\"")]
	Opus,
	[Value("\"ogg\"")]
	Ogg,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum OpusSignal
{
	[Value("\"auto\"")]
	Auto,
	[Value("\"music\"")]
	Music,
	[Value("\"voice\"")]
	Voice,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum OpusApplication
{
	[Value("\"voip\"")]
	Voip,
	[Value("\"audio\"")]
	Audio,
	[Value("\"lowdelay\"")]
	Lowdelay,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum HardwareAcceleration
{
	[Value("\"no-preference\"")]
	NoPreference,
	[Value("\"prefer-hardware\"")]
	PreferHardware,
	[Value("\"prefer-software\"")]
	PreferSoftware,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AlphaOption
{
	[Value("\"keep\"")]
	Keep,
	[Value("\"discard\"")]
	Discard,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum LatencyMode
{
	[Value("\"quality\"")]
	Quality,
	[Value("\"realtime\"")]
	Realtime,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum VideoEncoderBitrateMode
{
	[Value("\"constant\"")]
	Constant,
	[Value("\"variable\"")]
	Variable,
	[Value("\"quantizer\"")]
	Quantizer,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum CodecState
{
	[Value("\"unconfigured\"")]
	Unconfigured,
	[Value("\"configured\"")]
	Configured,
	[Value("\"closed\"")]
	Closed,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum EncodedAudioChunkType
{
	[Value("\"key\"")]
	Key,
	[Value("\"delta\"")]
	Delta,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum EncodedVideoChunkType
{
	[Value("\"key\"")]
	Key,
	[Value("\"delta\"")]
	Delta,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AudioSampleFormat
{
	[Value("\"u8\"")]
	U8,
	[Value("\"s16\"")]
	S16,
	[Value("\"s32\"")]
	S32,
	[Value("\"f32\"")]
	F32,
	[Value("\"u8-planar\"")]
	U8Planar,
	[Value("\"s16-planar\"")]
	S16Planar,
	[Value("\"s32-planar\"")]
	S32Planar,
	[Value("\"f32-planar\"")]
	F32Planar,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum VideoPixelFormat
{
	[Value("\"I420\"")]
	I420,
	[Value("\"I420P10\"")]
	I420P10,
	[Value("\"I420P12\"")]
	I420P12,
	[Value("\"I420A\"")]
	I420A,
	[Value("\"I420AP10\"")]
	I420AP10,
	[Value("\"I420AP12\"")]
	I420AP12,
	[Value("\"I422\"")]
	I422,
	[Value("\"I422P10\"")]
	I422P10,
	[Value("\"I422P12\"")]
	I422P12,
	[Value("\"I422A\"")]
	I422A,
	[Value("\"I422AP10\"")]
	I422AP10,
	[Value("\"I422AP12\"")]
	I422AP12,
	[Value("\"I444\"")]
	I444,
	[Value("\"I444P10\"")]
	I444P10,
	[Value("\"I444P12\"")]
	I444P12,
	[Value("\"I444A\"")]
	I444A,
	[Value("\"I444AP10\"")]
	I444AP10,
	[Value("\"I444AP12\"")]
	I444AP12,
	[Value("\"NV12\"")]
	NV12,
	[Value("\"RGBA\"")]
	RGBA,
	[Value("\"RGBX\"")]
	RGBX,
	[Value("\"BGRA\"")]
	BGRA,
	[Value("\"BGRX\"")]
	BGRX,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum VideoColorPrimaries
{
	[Value("\"bt709\"")]
	Bt709,
	[Value("\"bt470bg\"")]
	Bt470bg,
	[Value("\"smpte170m\"")]
	Smpte170m,
	[Value("\"bt2020\"")]
	Bt2020,
	[Value("\"smpte432\"")]
	Smpte432,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum VideoTransferCharacteristics
{
	[Value("\"bt709\"")]
	Bt709,
	[Value("\"smpte170m\"")]
	Smpte170m,
	[Value("\"iec61966-2-1\"")]
	Iec6196621,
	[Value("\"linear\"")]
	Linear,
	[Value("\"pq\"")]
	Pq,
	[Value("\"hlg\"")]
	Hlg,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum VideoMatrixCoefficients
{
	[Value("\"rgb\"")]
	Rgb,
	[Value("\"bt709\"")]
	Bt709,
	[Value("\"bt470bg\"")]
	Bt470bg,
	[Value("\"smpte170m\"")]
	Smpte170m,
	[Value("\"bt2020-ncl\"")]
	Bt2020Ncl,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum KeyType
{
	[Value("\"public\"")]
	Public,
	[Value("\"private\"")]
	Private,
	[Value("\"secret\"")]
	Secret,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum KeyUsage
{
	[Value("\"encrypt\"")]
	Encrypt,
	[Value("\"decrypt\"")]
	Decrypt,
	[Value("\"sign\"")]
	Sign,
	[Value("\"verify\"")]
	Verify,
	[Value("\"deriveKey\"")]
	DeriveKey,
	[Value("\"deriveBits\"")]
	DeriveBits,
	[Value("\"wrapKey\"")]
	WrapKey,
	[Value("\"unwrapKey\"")]
	UnwrapKey,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum KeyFormat
{
	[Value("\"raw\"")]
	Raw,
	[Value("\"spki\"")]
	Spki,
	[Value("\"pkcs8\"")]
	Pkcs8,
	[Value("\"jwk\"")]
	Jwk,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum WebGLPowerPreference
{
	[Value("\"default\"")]
	Default,
	[Value("\"low-power\"")]
	LowPower,
	[Value("\"high-performance\"")]
	HighPerformance,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUPowerPreference
{
	[Value("\"low-power\"")]
	LowPower,
	[Value("\"high-performance\"")]
	HighPerformance,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUFeatureName
{
	[Value("\"depth-clip-control\"")]
	DepthClipControl,
	[Value("\"depth32float-stencil8\"")]
	Depth32floatStencil8,
	[Value("\"texture-compression-bc\"")]
	TextureCompressionBc,
	[Value("\"texture-compression-bc-sliced-3d\"")]
	TextureCompressionBcSliced3d,
	[Value("\"texture-compression-etc2\"")]
	TextureCompressionEtc2,
	[Value("\"texture-compression-astc\"")]
	TextureCompressionAstc,
	[Value("\"texture-compression-astc-sliced-3d\"")]
	TextureCompressionAstcSliced3d,
	[Value("\"timestamp-query\"")]
	TimestampQuery,
	[Value("\"indirect-first-instance\"")]
	IndirectFirstInstance,
	[Value("\"shader-f16\"")]
	ShaderF16,
	[Value("\"rg11b10ufloat-renderable\"")]
	Rg11b10ufloatRenderable,
	[Value("\"bgra8unorm-storage\"")]
	Bgra8unormStorage,
	[Value("\"float32-filterable\"")]
	Float32Filterable,
	[Value("\"float32-blendable\"")]
	Float32Blendable,
	[Value("\"clip-distances\"")]
	ClipDistances,
	[Value("\"dual-source-blending\"")]
	DualSourceBlending,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUBufferMapState
{
	[Value("\"unmapped\"")]
	Unmapped,
	[Value("\"pending\"")]
	Pending,
	[Value("\"mapped\"")]
	Mapped,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUTextureDimension
{
	[Value("\"1d\"")]
	_1d,
	[Value("\"2d\"")]
	_2d,
	[Value("\"3d\"")]
	_3d,
}


[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUTextureViewDimension
{
	[Value("\"1d\"")]
	_1d,
	[Value("\"2d\"")]
	_2d,
	[Value("\"2d-array\"")]
	_2dArray,
	[Value("\"cube\"")]
	Cube,
	[Value("\"cube-array\"")]
	CubeArray,
	[Value("\"3d\"")]
	_3d,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUTextureAspect
{
	[Value("\"all\"")]
	All,
	[Value("\"stencil-only\"")]
	StencilOnly,
	[Value("\"depth-only\"")]
	DepthOnly,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUTextureFormat
{
	[Value("\"r8unorm\"")]
	R8unorm,
	[Value("\"r8snorm\"")]
	R8snorm,
	[Value("\"r8uint\"")]
	R8uint,
	[Value("\"r8sint\"")]
	R8sint,
	[Value("\"r16uint\"")]
	R16uint,
	[Value("\"r16sint\"")]
	R16sint,
	[Value("\"r16float\"")]
	R16float,
	[Value("\"rg8unorm\"")]
	Rg8unorm,
	[Value("\"rg8snorm\"")]
	Rg8snorm,
	[Value("\"rg8uint\"")]
	Rg8uint,
	[Value("\"rg8sint\"")]
	Rg8sint,
	[Value("\"r32uint\"")]
	R32uint,
	[Value("\"r32sint\"")]
	R32sint,
	[Value("\"r32float\"")]
	R32float,
	[Value("\"rg16uint\"")]
	Rg16uint,
	[Value("\"rg16sint\"")]
	Rg16sint,
	[Value("\"rg16float\"")]
	Rg16float,
	[Value("\"rgba8unorm\"")]
	Rgba8unorm,
	[Value("\"rgba8unorm-srgb\"")]
	Rgba8unormSrgb,
	[Value("\"rgba8snorm\"")]
	Rgba8snorm,
	[Value("\"rgba8uint\"")]
	Rgba8uint,
	[Value("\"rgba8sint\"")]
	Rgba8sint,
	[Value("\"bgra8unorm\"")]
	Bgra8unorm,
	[Value("\"bgra8unorm-srgb\"")]
	Bgra8unormSrgb,
	[Value("\"rgb9e5ufloat\"")]
	Rgb9e5ufloat,
	[Value("\"rgb10a2uint\"")]
	Rgb10a2uint,
	[Value("\"rgb10a2unorm\"")]
	Rgb10a2unorm,
	[Value("\"rg11b10ufloat\"")]
	Rg11b10ufloat,
	[Value("\"rg32uint\"")]
	Rg32uint,
	[Value("\"rg32sint\"")]
	Rg32sint,
	[Value("\"rg32float\"")]
	Rg32float,
	[Value("\"rgba16uint\"")]
	Rgba16uint,
	[Value("\"rgba16sint\"")]
	Rgba16sint,
	[Value("\"rgba16float\"")]
	Rgba16float,
	[Value("\"rgba32uint\"")]
	Rgba32uint,
	[Value("\"rgba32sint\"")]
	Rgba32sint,
	[Value("\"rgba32float\"")]
	Rgba32float,
	[Value("\"stencil8\"")]
	Stencil8,
	[Value("\"depth16unorm\"")]
	Depth16unorm,
	[Value("\"depth24plus\"")]
	Depth24plus,
	[Value("\"depth24plus-stencil8\"")]
	Depth24plusStencil8,
	[Value("\"depth32float\"")]
	Depth32float,
	[Value("\"depth32float-stencil8\"")]
	Depth32floatStencil8,
	[Value("\"bc1-rgba-unorm\"")]
	Bc1RgbaUnorm,
	[Value("\"bc1-rgba-unorm-srgb\"")]
	Bc1RgbaUnormSrgb,
	[Value("\"bc2-rgba-unorm\"")]
	Bc2RgbaUnorm,
	[Value("\"bc2-rgba-unorm-srgb\"")]
	Bc2RgbaUnormSrgb,
	[Value("\"bc3-rgba-unorm\"")]
	Bc3RgbaUnorm,
	[Value("\"bc3-rgba-unorm-srgb\"")]
	Bc3RgbaUnormSrgb,
	[Value("\"bc4-r-unorm\"")]
	Bc4RUnorm,
	[Value("\"bc4-r-snorm\"")]
	Bc4RSnorm,
	[Value("\"bc5-rg-unorm\"")]
	Bc5RgUnorm,
	[Value("\"bc5-rg-snorm\"")]
	Bc5RgSnorm,
	[Value("\"bc6h-rgb-ufloat\"")]
	Bc6hRgbUfloat,
	[Value("\"bc6h-rgb-float\"")]
	Bc6hRgbFloat,
	[Value("\"bc7-rgba-unorm\"")]
	Bc7RgbaUnorm,
	[Value("\"bc7-rgba-unorm-srgb\"")]
	Bc7RgbaUnormSrgb,
	[Value("\"etc2-rgb8unorm\"")]
	Etc2Rgb8unorm,
	[Value("\"etc2-rgb8unorm-srgb\"")]
	Etc2Rgb8unormSrgb,
	[Value("\"etc2-rgb8a1unorm\"")]
	Etc2Rgb8a1unorm,
	[Value("\"etc2-rgb8a1unorm-srgb\"")]
	Etc2Rgb8a1unormSrgb,
	[Value("\"etc2-rgba8unorm\"")]
	Etc2Rgba8unorm,
	[Value("\"etc2-rgba8unorm-srgb\"")]
	Etc2Rgba8unormSrgb,
	[Value("\"eac-r11unorm\"")]
	EacR11unorm,
	[Value("\"eac-r11snorm\"")]
	EacR11snorm,
	[Value("\"eac-rg11unorm\"")]
	EacRg11unorm,
	[Value("\"eac-rg11snorm\"")]
	EacRg11snorm,
	[Value("\"astc-4x4-unorm\"")]
	Astc4x4Unorm,
	[Value("\"astc-4x4-unorm-srgb\"")]
	Astc4x4UnormSrgb,
	[Value("\"astc-5x4-unorm\"")]
	Astc5x4Unorm,
	[Value("\"astc-5x4-unorm-srgb\"")]
	Astc5x4UnormSrgb,
	[Value("\"astc-5x5-unorm\"")]
	Astc5x5Unorm,
	[Value("\"astc-5x5-unorm-srgb\"")]
	Astc5x5UnormSrgb,
	[Value("\"astc-6x5-unorm\"")]
	Astc6x5Unorm,
	[Value("\"astc-6x5-unorm-srgb\"")]
	Astc6x5UnormSrgb,
	[Value("\"astc-6x6-unorm\"")]
	Astc6x6Unorm,
	[Value("\"astc-6x6-unorm-srgb\"")]
	Astc6x6UnormSrgb,
	[Value("\"astc-8x5-unorm\"")]
	Astc8x5Unorm,
	[Value("\"astc-8x5-unorm-srgb\"")]
	Astc8x5UnormSrgb,
	[Value("\"astc-8x6-unorm\"")]
	Astc8x6Unorm,
	[Value("\"astc-8x6-unorm-srgb\"")]
	Astc8x6UnormSrgb,
	[Value("\"astc-8x8-unorm\"")]
	Astc8x8Unorm,
	[Value("\"astc-8x8-unorm-srgb\"")]
	Astc8x8UnormSrgb,
	[Value("\"astc-10x5-unorm\"")]
	Astc10x5Unorm,
	[Value("\"astc-10x5-unorm-srgb\"")]
	Astc10x5UnormSrgb,
	[Value("\"astc-10x6-unorm\"")]
	Astc10x6Unorm,
	[Value("\"astc-10x6-unorm-srgb\"")]
	Astc10x6UnormSrgb,
	[Value("\"astc-10x8-unorm\"")]
	Astc10x8Unorm,
	[Value("\"astc-10x8-unorm-srgb\"")]
	Astc10x8UnormSrgb,
	[Value("\"astc-10x10-unorm\"")]
	Astc10x10Unorm,
	[Value("\"astc-10x10-unorm-srgb\"")]
	Astc10x10UnormSrgb,
	[Value("\"astc-12x10-unorm\"")]
	Astc12x10Unorm,
	[Value("\"astc-12x10-unorm-srgb\"")]
	Astc12x10UnormSrgb,
	[Value("\"astc-12x12-unorm\"")]
	Astc12x12Unorm,
	[Value("\"astc-12x12-unorm-srgb\"")]
	Astc12x12UnormSrgb,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUAddressMode
{
	[Value("\"clamp-to-edge\"")]
	ClampToEdge,
	[Value("\"repeat\"")]
	Repeat,
	[Value("\"mirror-repeat\"")]
	MirrorRepeat,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUFilterMode
{
	[Value("\"nearest\"")]
	Nearest,
	[Value("\"linear\"")]
	Linear,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUMipmapFilterMode
{
	[Value("\"nearest\"")]
	Nearest,
	[Value("\"linear\"")]
	Linear,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUCompareFunction
{
	[Value("\"never\"")]
	Never,
	[Value("\"less\"")]
	Less,
	[Value("\"equal\"")]
	Equal,
	[Value("\"less-equal\"")]
	LessEqual,
	[Value("\"greater\"")]
	Greater,
	[Value("\"not-equal\"")]
	NotEqual,
	[Value("\"greater-equal\"")]
	GreaterEqual,
	[Value("\"always\"")]
	Always,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUBufferBindingType
{
	[Value("\"uniform\"")]
	Uniform,
	[Value("\"storage\"")]
	Storage,
	[Value("\"read-only-storage\"")]
	ReadOnlyStorage,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUSamplerBindingType
{
	[Value("\"filtering\"")]
	Filtering,
	[Value("\"non-filtering\"")]
	NonFiltering,
	[Value("\"comparison\"")]
	Comparison,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUTextureSampleType
{
	[Value("\"float\"")]
	Float,
	[Value("\"unfilterable-float\"")]
	UnfilterableFloat,
	[Value("\"depth\"")]
	Depth,
	[Value("\"sint\"")]
	Sint,
	[Value("\"uint\"")]
	Uint,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUStorageTextureAccess
{
	[Value("\"write-only\"")]
	WriteOnly,
	[Value("\"read-only\"")]
	ReadOnly,
	[Value("\"read-write\"")]
	ReadWrite,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUCompilationMessageType
{
	[Value("\"error\"")]
	Error,
	[Value("\"warning\"")]
	Warning,
	[Value("\"info\"")]
	Info,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUPipelineErrorReason
{
	[Value("\"validation\"")]
	Validation,
	[Value("\"internal\"")]
	Internal,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUAutoLayoutMode
{
	[Value("\"auto\"")]
	Auto,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUPrimitiveTopology
{
	[Value("\"point-list\"")]
	PointList,
	[Value("\"line-list\"")]
	LineList,
	[Value("\"line-strip\"")]
	LineStrip,
	[Value("\"triangle-list\"")]
	TriangleList,
	[Value("\"triangle-strip\"")]
	TriangleStrip,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUFrontFace
{
	[Value("\"ccw\"")]
	Ccw,
	[Value("\"cw\"")]
	Cw,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUCullMode
{
	[Value("\"none\"")]
	None,
	[Value("\"front\"")]
	Front,
	[Value("\"back\"")]
	Back,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUBlendFactor
{
	[Value("\"zero\"")]
	Zero,
	[Value("\"one\"")]
	One,
	[Value("\"src\"")]
	Src,
	[Value("\"one-minus-src\"")]
	OneMinusSrc,
	[Value("\"src-alpha\"")]
	SrcAlpha,
	[Value("\"one-minus-src-alpha\"")]
	OneMinusSrcAlpha,
	[Value("\"dst\"")]
	Dst,
	[Value("\"one-minus-dst\"")]
	OneMinusDst,
	[Value("\"dst-alpha\"")]
	DstAlpha,
	[Value("\"one-minus-dst-alpha\"")]
	OneMinusDstAlpha,
	[Value("\"src-alpha-saturated\"")]
	SrcAlphaSaturated,
	[Value("\"constant\"")]
	Constant,
	[Value("\"one-minus-constant\"")]
	OneMinusConstant,
	[Value("\"src1\"")]
	Src1,
	[Value("\"one-minus-src1\"")]
	OneMinusSrc1,
	[Value("\"src1-alpha\"")]
	Src1Alpha,
	[Value("\"one-minus-src1-alpha\"")]
	OneMinusSrc1Alpha,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUBlendOperation
{
	[Value("\"add\"")]
	Add,
	[Value("\"subtract\"")]
	Subtract,
	[Value("\"reverse-subtract\"")]
	ReverseSubtract,
	[Value("\"min\"")]
	Min,
	[Value("\"max\"")]
	Max,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUStencilOperation
{
	[Value("\"keep\"")]
	Keep,
	[Value("\"zero\"")]
	Zero,
	[Value("\"replace\"")]
	Replace,
	[Value("\"invert\"")]
	Invert,
	[Value("\"increment-clamp\"")]
	IncrementClamp,
	[Value("\"decrement-clamp\"")]
	DecrementClamp,
	[Value("\"increment-wrap\"")]
	IncrementWrap,
	[Value("\"decrement-wrap\"")]
	DecrementWrap,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUIndexFormat
{
	[Value("\"uint16\"")]
	Uint16,
	[Value("\"uint32\"")]
	Uint32,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUVertexFormat
{
	[Value("\"uint8\"")]
	Uint8,
	[Value("\"uint8x2\"")]
	Uint8x2,
	[Value("\"uint8x4\"")]
	Uint8x4,
	[Value("\"sint8\"")]
	Sint8,
	[Value("\"sint8x2\"")]
	Sint8x2,
	[Value("\"sint8x4\"")]
	Sint8x4,
	[Value("\"unorm8\"")]
	Unorm8,
	[Value("\"unorm8x2\"")]
	Unorm8x2,
	[Value("\"unorm8x4\"")]
	Unorm8x4,
	[Value("\"snorm8\"")]
	Snorm8,
	[Value("\"snorm8x2\"")]
	Snorm8x2,
	[Value("\"snorm8x4\"")]
	Snorm8x4,
	[Value("\"uint16\"")]
	Uint16,
	[Value("\"uint16x2\"")]
	Uint16x2,
	[Value("\"uint16x4\"")]
	Uint16x4,
	[Value("\"sint16\"")]
	Sint16,
	[Value("\"sint16x2\"")]
	Sint16x2,
	[Value("\"sint16x4\"")]
	Sint16x4,
	[Value("\"unorm16\"")]
	Unorm16,
	[Value("\"unorm16x2\"")]
	Unorm16x2,
	[Value("\"unorm16x4\"")]
	Unorm16x4,
	[Value("\"snorm16\"")]
	Snorm16,
	[Value("\"snorm16x2\"")]
	Snorm16x2,
	[Value("\"snorm16x4\"")]
	Snorm16x4,
	[Value("\"float16\"")]
	Float16,
	[Value("\"float16x2\"")]
	Float16x2,
	[Value("\"float16x4\"")]
	Float16x4,
	[Value("\"float32\"")]
	Float32,
	[Value("\"float32x2\"")]
	Float32x2,
	[Value("\"float32x3\"")]
	Float32x3,
	[Value("\"float32x4\"")]
	Float32x4,
	[Value("\"uint32\"")]
	Uint32,
	[Value("\"uint32x2\"")]
	Uint32x2,
	[Value("\"uint32x3\"")]
	Uint32x3,
	[Value("\"uint32x4\"")]
	Uint32x4,
	[Value("\"sint32\"")]
	Sint32,
	[Value("\"sint32x2\"")]
	Sint32x2,
	[Value("\"sint32x3\"")]
	Sint32x3,
	[Value("\"sint32x4\"")]
	Sint32x4,
	[Value("\"unorm10-10-10-2\"")]
	Unorm1010102,
	[Value("\"unorm8x4-bgra\"")]
	Unorm8x4Bgra,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUVertexStepMode
{
	[Value("\"vertex\"")]
	Vertex,
	[Value("\"instance\"")]
	Instance,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPULoadOp
{
	[Value("\"load\"")]
	Load,
	[Value("\"clear\"")]
	Clear,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUStoreOp
{
	[Value("\"store\"")]
	Store,
	[Value("\"discard\"")]
	Discard,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUQueryType
{
	[Value("\"occlusion\"")]
	Occlusion,
	[Value("\"timestamp\"")]
	Timestamp,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUCanvasAlphaMode
{
	[Value("\"opaque\"")]
	Opaque,
	[Value("\"premultiplied\"")]
	Premultiplied,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUCanvasToneMappingMode
{
	[Value("\"standard\"")]
	Standard,
	[Value("\"extended\"")]
	Extended,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUDeviceLostReason
{
	[Value("\"unknown\"")]
	Unknown,
	[Value("\"destroyed\"")]
	Destroyed,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum GPUErrorFilter
{
	[Value("\"validation\"")]
	Validation,
	[Value("\"out-of-memory\"")]
	OutOfMemory,
	[Value("\"internal\"")]
	Internal,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum HIDUnitSystem
{
	[Value("\"none\"")]
	None,
	[Value("\"si-linear\"")]
	SiLinear,
	[Value("\"si-rotation\"")]
	SiRotation,
	[Value("\"english-linear\"")]
	EnglishLinear,
	[Value("\"english-rotation\"")]
	EnglishRotation,
	[Value("\"vendor-defined\"")]
	VendorDefined,
	[Value("\"reserved\"")]
	Reserved,
}




[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MIDIPortType
{
	[Value("\"input\"")]
	Input,
	[Value("\"output\"")]
	Output,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MIDIPortDeviceState
{
	[Value("\"disconnected\"")]
	Disconnected,
	[Value("\"connected\"")]
	Connected,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MIDIPortConnectionState
{
	[Value("\"open\"")]
	Open,
	[Value("\"closed\"")]
	Closed,
	[Value("\"pending\"")]
	Pending,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MLDeviceType
{
	[Value("\"cpu\"")]
	Cpu,
	[Value("\"gpu\"")]
	Gpu,
	[Value("\"npu\"")]
	Npu,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MLPowerPreference
{
	[Value("\"default\"")]
	Default,
	[Value("\"high-performance\"")]
	HighPerformance,
	[Value("\"low-power\"")]
	LowPower,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MLInputOperandLayout
{
	[Value("\"nchw\"")]
	Nchw,
	[Value("\"nhwc\"")]
	Nhwc,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MLOperandDataType
{
	[Value("\"float32\"")]
	Float32,
	[Value("\"float16\"")]
	Float16,
	[Value("\"int32\"")]
	Int32,
	[Value("\"uint32\"")]
	Uint32,
	[Value("\"int64\"")]
	Int64,
	[Value("\"uint64\"")]
	Uint64,
	[Value("\"int8\"")]
	Int8,
	[Value("\"uint8\"")]
	Uint8,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MLConv2dFilterOperandLayout
{
	[Value("\"oihw\"")]
	Oihw,
	[Value("\"hwio\"")]
	Hwio,
	[Value("\"ohwi\"")]
	Ohwi,
	[Value("\"ihwo\"")]
	Ihwo,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MLConvTranspose2dFilterOperandLayout
{
	[Value("\"iohw\"")]
	Iohw,
	[Value("\"hwoi\"")]
	Hwoi,
	[Value("\"ohwi\"")]
	Ohwi,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MLGruWeightLayout
{
	[Value("\"zrn\"")]
	Zrn,
	[Value("\"rzn\"")]
	Rzn,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MLRecurrentNetworkActivation
{
	[Value("\"relu\"")]
	Relu,
	[Value("\"sigmoid\"")]
	Sigmoid,
	[Value("\"tanh\"")]
	Tanh,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MLRecurrentNetworkDirection
{
	[Value("\"forward\"")]
	Forward,
	[Value("\"backward\"")]
	Backward,
	[Value("\"both\"")]
	Both,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MLLstmWeightLayout
{
	[Value("\"iofg\"")]
	Iofg,
	[Value("\"ifgo\"")]
	Ifgo,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MLPaddingMode
{
	[Value("\"constant\"")]
	Constant,
	[Value("\"edge\"")]
	Edge,
	[Value("\"reflection\"")]
	Reflection,
	[Value("\"symmetric\"")]
	Symmetric,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MLRoundingType
{
	[Value("\"floor\"")]
	Floor,
	[Value("\"ceil\"")]
	Ceil,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum MLInterpolationMode
{
	[Value("\"nearest-neighbor\"")]
	NearestNeighbor,
	[Value("\"linear\"")]
	Linear,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum SFrameTransformRole
{
	[Value("\"encrypt\"")]
	Encrypt,
	[Value("\"decrypt\"")]
	Decrypt,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum SFrameTransformErrorEventType
{
	[Value("\"authentication\"")]
	Authentication,
	[Value("\"keyID\"")]
	KeyID,
	[Value("\"syntax\"")]
	Syntax,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCEncodedVideoFrameType
{
	[Value("\"empty\"")]
	Empty,
	[Value("\"key\"")]
	Key,
	[Value("\"delta\"")]
	Delta,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCErrorDetailTypeIdp
{
	[Value("\"idp-bad-script-failure\"")]
	IdpBadScriptFailure,
	[Value("\"idp-execution-failure\"")]
	IdpExecutionFailure,
	[Value("\"idp-load-failure\"")]
	IdpLoadFailure,
	[Value("\"idp-need-login\"")]
	IdpNeedLogin,
	[Value("\"idp-timeout\"")]
	IdpTimeout,
	[Value("\"idp-tls-failure\"")]
	IdpTlsFailure,
	[Value("\"idp-token-expired\"")]
	IdpTokenExpired,
	[Value("\"idp-token-invalid\"")]
	IdpTokenInvalid,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCPriorityType
{
	[Value("\"very-low\"")]
	VeryLow,
	[Value("\"low\"")]
	Low,
	[Value("\"medium\"")]
	Medium,
	[Value("\"high\"")]
	High,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCStatsType
{
	[Value("\"codec\"")]
	Codec,
	[Value("\"inbound-rtp\"")]
	InboundRtp,
	[Value("\"outbound-rtp\"")]
	OutboundRtp,
	[Value("\"remote-inbound-rtp\"")]
	RemoteInboundRtp,
	[Value("\"remote-outbound-rtp\"")]
	RemoteOutboundRtp,
	[Value("\"media-source\"")]
	MediaSource,
	[Value("\"media-playout\"")]
	MediaPlayout,
	[Value("\"peer-connection\"")]
	PeerConnection,
	[Value("\"data-channel\"")]
	DataChannel,
	[Value("\"transport\"")]
	Transport,
	[Value("\"candidate-pair\"")]
	CandidatePair,
	[Value("\"local-candidate\"")]
	LocalCandidate,
	[Value("\"remote-candidate\"")]
	RemoteCandidate,
	[Value("\"certificate\"")]
	Certificate,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCQualityLimitationReason
{
	[Value("\"none\"")]
	None,
	[Value("\"cpu\"")]
	Cpu,
	[Value("\"bandwidth\"")]
	Bandwidth,
	[Value("\"other\"")]
	Other,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCDtlsRole
{
	[Value("\"client\"")]
	Client,
	[Value("\"server\"")]
	Server,
	[Value("\"unknown\"")]
	Unknown,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCStatsIceCandidatePairState
{
	[Value("\"frozen\"")]
	Frozen,
	[Value("\"waiting\"")]
	Waiting,
	[Value("\"in-progress\"")]
	InProgress,
	[Value("\"failed\"")]
	Failed,
	[Value("\"succeeded\"")]
	Succeeded,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCIceTransportPolicy
{
	[Value("\"relay\"")]
	Relay,
	[Value("\"all\"")]
	All,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCBundlePolicy
{
	[Value("\"balanced\"")]
	Balanced,
	[Value("\"max-compat\"")]
	MaxCompat,
	[Value("\"max-bundle\"")]
	MaxBundle,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCRtcpMuxPolicy
{
	[Value("\"require\"")]
	Require,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCSignalingState
{
	[Value("\"stable\"")]
	Stable,
	[Value("\"have-local-offer\"")]
	HaveLocalOffer,
	[Value("\"have-remote-offer\"")]
	HaveRemoteOffer,
	[Value("\"have-local-pranswer\"")]
	HaveLocalPranswer,
	[Value("\"have-remote-pranswer\"")]
	HaveRemotePranswer,
	[Value("\"closed\"")]
	Closed,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCIceGatheringState
{
	[Value("\"new\"")]
	New,
	[Value("\"gathering\"")]
	Gathering,
	[Value("\"complete\"")]
	Complete,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCPeerConnectionState
{
	[Value("\"closed\"")]
	Closed,
	[Value("\"failed\"")]
	Failed,
	[Value("\"disconnected\"")]
	Disconnected,
	[Value("\"new\"")]
	New,
	[Value("\"connecting\"")]
	Connecting,
	[Value("\"connected\"")]
	Connected,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCIceConnectionState
{
	[Value("\"closed\"")]
	Closed,
	[Value("\"failed\"")]
	Failed,
	[Value("\"disconnected\"")]
	Disconnected,
	[Value("\"new\"")]
	New,
	[Value("\"checking\"")]
	Checking,
	[Value("\"completed\"")]
	Completed,
	[Value("\"connected\"")]
	Connected,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCSdpType
{
	[Value("\"offer\"")]
	Offer,
	[Value("\"pranswer\"")]
	Pranswer,
	[Value("\"answer\"")]
	Answer,
	[Value("\"rollback\"")]
	Rollback,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCIceProtocol
{
	[Value("\"udp\"")]
	Udp,
	[Value("\"tcp\"")]
	Tcp,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCIceTcpCandidateType
{
	[Value("\"active\"")]
	Active,
	[Value("\"passive\"")]
	Passive,
	[Value("\"so\"")]
	So,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCIceCandidateType
{
	[Value("\"host\"")]
	Host,
	[Value("\"srflx\"")]
	Srflx,
	[Value("\"prflx\"")]
	Prflx,
	[Value("\"relay\"")]
	Relay,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCIceServerTransportProtocol
{
	[Value("\"udp\"")]
	Udp,
	[Value("\"tcp\"")]
	Tcp,
	[Value("\"tls\"")]
	Tls,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCRtpTransceiverDirection
{
	[Value("\"sendrecv\"")]
	Sendrecv,
	[Value("\"sendonly\"")]
	Sendonly,
	[Value("\"recvonly\"")]
	Recvonly,
	[Value("\"inactive\"")]
	Inactive,
	[Value("\"stopped\"")]
	Stopped,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCDtlsTransportState
{
	[Value("\"new\"")]
	New,
	[Value("\"connecting\"")]
	Connecting,
	[Value("\"connected\"")]
	Connected,
	[Value("\"closed\"")]
	Closed,
	[Value("\"failed\"")]
	Failed,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCIceGathererState
{
	[Value("\"new\"")]
	New,
	[Value("\"gathering\"")]
	Gathering,
	[Value("\"complete\"")]
	Complete,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCIceTransportState
{
	[Value("\"closed\"")]
	Closed,
	[Value("\"failed\"")]
	Failed,
	[Value("\"disconnected\"")]
	Disconnected,
	[Value("\"new\"")]
	New,
	[Value("\"checking\"")]
	Checking,
	[Value("\"completed\"")]
	Completed,
	[Value("\"connected\"")]
	Connected,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCIceRole
{
	[Value("\"unknown\"")]
	Unknown,
	[Value("\"controlling\"")]
	Controlling,
	[Value("\"controlled\"")]
	Controlled,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCIceComponent
{
	[Value("\"rtp\"")]
	Rtp,
	[Value("\"rtcp\"")]
	Rtcp,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCSctpTransportState
{
	[Value("\"connecting\"")]
	Connecting,
	[Value("\"connected\"")]
	Connected,
	[Value("\"closed\"")]
	Closed,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCDataChannelState
{
	[Value("\"connecting\"")]
	Connecting,
	[Value("\"open\"")]
	Open,
	[Value("\"closing\"")]
	Closing,
	[Value("\"closed\"")]
	Closed,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum RTCErrorDetailType
{
	[Value("\"data-channel-failure\"")]
	DataChannelFailure,
	[Value("\"dtls-failure\"")]
	DtlsFailure,
	[Value("\"fingerprint-failure\"")]
	FingerprintFailure,
	[Value("\"sctp-failure\"")]
	SctpFailure,
	[Value("\"sdp-syntax-error\"")]
	SdpSyntaxError,
	[Value("\"hardware-encoder-not-available\"")]
	HardwareEncoderNotAvailable,
	[Value("\"hardware-encoder-error\"")]
	HardwareEncoderError,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum BinaryType
{
	[Value("\"blob\"")]
	Blob,
	[Value("\"arraybuffer\"")]
	Arraybuffer,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum WebTransportReliabilityMode
{
	[Value("\"pending\"")]
	Pending,
	[Value("\"reliable-only\"")]
	ReliableOnly,
	[Value("\"supports-unreliable\"")]
	SupportsUnreliable,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum WebTransportCongestionControl
{
	[Value("\"default\"")]
	Default,
	[Value("\"throughput\"")]
	Throughput,
	[Value("\"low-latency\"")]
	LowLatency,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum WebTransportErrorSource
{
	[Value("\"stream\"")]
	Stream,
	[Value("\"session\"")]
	Session,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum USBTransferStatus
{
	[Value("\"ok\"")]
	Ok,
	[Value("\"stall\"")]
	Stall,
	[Value("\"babble\"")]
	Babble,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum USBRequestType
{
	[Value("\"standard\"")]
	Standard,
	[Value("\"class\"")]
	Class,
	[Value("\"vendor\"")]
	Vendor,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum USBRecipient
{
	[Value("\"device\"")]
	Device,
	[Value("\"interface\"")]
	Interface,
	[Value("\"endpoint\"")]
	Endpoint,
	[Value("\"other\"")]
	Other,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum USBDirection
{
	[Value("\"in\"")]
	In,
	[Value("\"out\"")]
	Out,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum USBEndpointType
{
	[Value("\"bulk\"")]
	Bulk,
	[Value("\"interrupt\"")]
	Interrupt,
	[Value("\"isochronous\"")]
	Isochronous,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AutoKeyword
{
	[Value("\"auto\"")]
	Auto,
}


[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum DirectionSetting
{
	[Value("\"\"")]
	Empty,
	[Value("\"rl\"")]
	Rl,
	[Value("\"lr\"")]
	Lr,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum LineAlignSetting
{
	[Value("\"start\"")]
	Start,
	[Value("\"center\"")]
	Center,
	[Value("\"end\"")]
	End,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum PositionAlignSetting
{
	[Value("\"line-left\"")]
	LineLeft,
	[Value("\"center\"")]
	Center,
	[Value("\"line-right\"")]
	LineRight,
	[Value("\"auto\"")]
	Auto,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum AlignSetting
{
	[Value("\"start\"")]
	Start,
	[Value("\"center\"")]
	Center,
	[Value("\"end\"")]
	End,
	[Value("\"left\"")]
	Left,
	[Value("\"right\"")]
	Right,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum ScrollSetting
{
	[Value("\"\"")]
	Empty,
	[Value("\"up\"")]
	Up,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XREnvironmentBlendMode
{
	[Value("\"opaque\"")]
	Opaque,
	[Value("\"alpha-blend\"")]
	AlphaBlend,
	[Value("\"additive\"")]
	Additive,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XRInteractionMode
{
	[Value("\"screen-space\"")]
	ScreenSpace,
	[Value("\"world-space\"")]
	WorldSpace,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XRDepthUsage
{
	[Value("\"cpu-optimized\"")]
	CpuOptimized,
	[Value("\"gpu-optimized\"")]
	GpuOptimized,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XRDepthDataFormat
{
	[Value("\"luminance-alpha\"")]
	LuminanceAlpha,
	[Value("\"float32\"")]
	Float32,
	[Value("\"unsigned-short\"")]
	UnsignedShort,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XRDOMOverlayType
{
	[Value("\"screen\"")]
	Screen,
	[Value("\"floating\"")]
	Floating,
	[Value("\"head-locked\"")]
	HeadLocked,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XRHandJoint
{
	[Value("\"wrist\"")]
	Wrist,
	[Value("\"thumb-metacarpal\"")]
	ThumbMetacarpal,
	[Value("\"thumb-phalanx-proximal\"")]
	ThumbPhalanxProximal,
	[Value("\"thumb-phalanx-distal\"")]
	ThumbPhalanxDistal,
	[Value("\"thumb-tip\"")]
	ThumbTip,
	[Value("\"index-finger-metacarpal\"")]
	IndexFingerMetacarpal,
	[Value("\"index-finger-phalanx-proximal\"")]
	IndexFingerPhalanxProximal,
	[Value("\"index-finger-phalanx-intermediate\"")]
	IndexFingerPhalanxIntermediate,
	[Value("\"index-finger-phalanx-distal\"")]
	IndexFingerPhalanxDistal,
	[Value("\"index-finger-tip\"")]
	IndexFingerTip,
	[Value("\"middle-finger-metacarpal\"")]
	MiddleFingerMetacarpal,
	[Value("\"middle-finger-phalanx-proximal\"")]
	MiddleFingerPhalanxProximal,
	[Value("\"middle-finger-phalanx-intermediate\"")]
	MiddleFingerPhalanxIntermediate,
	[Value("\"middle-finger-phalanx-distal\"")]
	MiddleFingerPhalanxDistal,
	[Value("\"middle-finger-tip\"")]
	MiddleFingerTip,
	[Value("\"ring-finger-metacarpal\"")]
	RingFingerMetacarpal,
	[Value("\"ring-finger-phalanx-proximal\"")]
	RingFingerPhalanxProximal,
	[Value("\"ring-finger-phalanx-intermediate\"")]
	RingFingerPhalanxIntermediate,
	[Value("\"ring-finger-phalanx-distal\"")]
	RingFingerPhalanxDistal,
	[Value("\"ring-finger-tip\"")]
	RingFingerTip,
	[Value("\"pinky-finger-metacarpal\"")]
	PinkyFingerMetacarpal,
	[Value("\"pinky-finger-phalanx-proximal\"")]
	PinkyFingerPhalanxProximal,
	[Value("\"pinky-finger-phalanx-intermediate\"")]
	PinkyFingerPhalanxIntermediate,
	[Value("\"pinky-finger-phalanx-distal\"")]
	PinkyFingerPhalanxDistal,
	[Value("\"pinky-finger-tip\"")]
	PinkyFingerTip,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XRHitTestTrackableType
{
	[Value("\"point\"")]
	Point,
	[Value("\"plane\"")]
	Plane,
	[Value("\"mesh\"")]
	Mesh,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XRReflectionFormat
{
	[Value("\"srgba8\"")]
	Srgba8,
	[Value("\"rgba16f\"")]
	Rgba16f,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XRPlaneOrientation
{
	[Value("\"horizontal\"")]
	Horizontal,
	[Value("\"vertical\"")]
	Vertical,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XRSessionMode
{
	[Value("\"inline\"")]
	Inline,
	[Value("\"immersive-vr\"")]
	ImmersiveVr,
	[Value("\"immersive-ar\"")]
	ImmersiveAr,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XRVisibilityState
{
	[Value("\"visible\"")]
	Visible,
	[Value("\"visible-blurred\"")]
	VisibleBlurred,
	[Value("\"hidden\"")]
	Hidden,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XRReferenceSpaceType
{
	[Value("\"viewer\"")]
	Viewer,
	[Value("\"local\"")]
	Local,
	[Value("\"local-floor\"")]
	LocalFloor,
	[Value("\"bounded-floor\"")]
	BoundedFloor,
	[Value("\"unbounded\"")]
	Unbounded,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XREye
{
	[Value("\"none\"")]
	None,
	[Value("\"left\"")]
	Left,
	[Value("\"right\"")]
	Right,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XRHandedness
{
	[Value("\"none\"")]
	None,
	[Value("\"left\"")]
	Left,
	[Value("\"right\"")]
	Right,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XRTargetRayMode
{
	[Value("\"gaze\"")]
	Gaze,
	[Value("\"tracked-pointer\"")]
	TrackedPointer,
	[Value("\"screen\"")]
	Screen,
	[Value("\"transient-pointer\"")]
	TransientPointer,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XRLayerLayout
{
	[Value("\"default\"")]
	Default,
	[Value("\"mono\"")]
	Mono,
	[Value("\"stereo\"")]
	Stereo,
	[Value("\"stereo-left-right\"")]
	StereoLeftRight,
	[Value("\"stereo-top-bottom\"")]
	StereoTopBottom,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XRLayerQuality
{
	[Value("\"default\"")]
	Default,
	[Value("\"text-optimized\"")]
	TextOptimized,
	[Value("\"graphics-optimized\"")]
	GraphicsOptimized,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XRTextureType
{
	[Value("\"texture\"")]
	Texture,
	[Value("\"texture-array\"")]
	TextureArray,
}

[To(ToAttribute.NoneWithTailingDotRemoved)]
public enum XMLHttpRequestResponseType
{
	[Value("\"\"")]
	Empty,
	[Value("\"arraybuffer\"")]
	Arraybuffer,
	[Value("\"blob\"")]
	Blob,
	[Value("\"document\"")]
	Document,
	[Value("\"json\"")]
	Json,
	[Value("\"text\"")]
	Text,
}

