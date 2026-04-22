//22.04.2026 19:18:40

#nullable enable
//Disable missing XML comments.
#pragma warning disable CS1591
//Ignore files not found.
#pragma warning disable CS1589
//Ignore 'Cannot convert null literal to non-nullable reference type.'
#pragma warning disable CS8625
//Ignore non-nullable property must contain a non-null value
#pragma warning disable CS8618
//Ignore 'Use the new keyword if hiding was intended.'
#pragma warning disable CS0108

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


[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum AccelerometerLocalCoordinateSystem
{
	[Value("\"device\"")]
	Device,
	[Value("\"screen\"")]
	Screen,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum AudioSessionState
{
	[Value("\"inactive\"")]
	Inactive,
	[Value("\"active\"")]
	Active,
	[Value("\"interrupted\"")]
	Interrupted,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum AutoplayPolicy
{
	[Value("\"allowed\"")]
	Allowed,
	[Value("\"allowed-muted\"")]
	AllowedMuted,
	[Value("\"disallowed\"")]
	Disallowed,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum AutoplayPolicyMediaType
{
	[Value("\"mediaelement\"")]
	Mediaelement,
	[Value("\"audiocontext\"")]
	Audiocontext,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum BackgroundFetchResult
{
	[Value("\"\"")]
	Empty,
	[Value("\"success\"")]
	Success,
	[Value("\"failure\"")]
	Failure,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum PresentationStyle
{
	[Value("\"unspecified\"")]
	Unspecified,
	[Value("\"inline\"")]
	Inline,
	[Value("\"attachment\"")]
	Attachment,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum CompressionFormat
{
	[Value("\"deflate\"")]
	Deflate,
	[Value("\"deflate-raw\"")]
	DeflateRaw,
	[Value("\"gzip\"")]
	Gzip,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum PressureSource
{
	[Value("\"cpu\"")]
	Cpu,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum CookieSameSite
{
	[Value("\"strict\"")]
	Strict,
	[Value("\"lax\"")]
	Lax,
	[Value("\"none\"")]
	None,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum SecurityPolicyViolationEventDisposition
{
	[Value("\"enforce\"")]
	Enforce,
	[Value("\"report\"")]
	Report,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum FontFaceSetLoadStatus
{
	[Value("\"loading\"")]
	Loading,
	[Value("\"loaded\"")]
	Loaded,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum HighlightType
{
	[Value("\"highlight\"")]
	Highlight,
	[Value("\"spelling-error\"")]
	SpellingError,
	[Value("\"grammar-error\"")]
	GrammarError,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ChildDisplayType
{
	[Value("\"block\"")]
	Block,
	[Value("\"normal\"")]
	Normal,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum LayoutSizingMode
{
	[Value("\"block-like\"")]
	BlockLike,
	[Value("\"manual\"")]
	Manual,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum FocusableAreaSearchMode
{
	[Value("\"visible\"")]
	Visible,
	[Value("\"all\"")]
	All,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ScrollBehavior
{
	[Value("\"auto\"")]
	Auto,
	[Value("\"instant\"")]
	Instant,
	[Value("\"smooth\"")]
	Smooth,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum DevicePostureType
{
	[Value("\"continuous\"")]
	Continuous,
	[Value("\"folded\"")]
	Folded,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ItemType
{
	[Value("\"product\"")]
	Product,
	[Value("\"subscription\"")]
	Subscription,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ShadowRootMode
{
	[Value("\"open\"")]
	Open,
	[Value("\"closed\"")]
	Closed,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum SlotAssignmentMode
{
	[Value("\"manual\"")]
	Manual,
	[Value("\"named\"")]
	Named,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum UnderlineThickness
{
	[Value("\"none\"")]
	None,
	[Value("\"thin\"")]
	Thin,
	[Value("\"thick\"")]
	Thick,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MediaKeysRequirement
{
	[Value("\"required\"")]
	Required,
	[Value("\"optional\"")]
	Optional,
	[Value("\"not-allowed\"")]
	NotAllowed,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MediaKeySessionType
{
	[Value("\"temporary\"")]
	Temporary,
	[Value("\"persistent-license\"")]
	PersistentLicense,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum IdentityCredentialRequestOptionsMode
{
	[Value("\"active\"")]
	Active,
	[Value("\"passive\"")]
	Passive,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum OpaqueProperty
{
	[Value("\"opaque\"")]
	Opaque,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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
[To(ToAttribute.NoneWithTrailingDotRemoved)]
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
[To(ToAttribute.NoneWithTrailingDotRemoved)]
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
[To(ToAttribute.NoneWithTrailingDotRemoved)]
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
[To(ToAttribute.NoneWithTrailingDotRemoved)]
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
[To(ToAttribute.NoneWithTrailingDotRemoved)]
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
[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RequestDuplex
{
	[Value("\"half\"")]
	Half,
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestPriority/*'/>
[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RequestPriority
{
	[Value("\"high\"")]
	High,
	[Value("\"low\"")]
	Low,
	[Value("\"auto\"")]
	Auto,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum FileSystemPermissionMode
{
	[Value("\"read\"")]
	Read,
	[Value("\"readwrite\"")]
	Readwrite,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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


[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum EndingType
{
	[Value("\"transparent\"")]
	Transparent,
	[Value("\"native\"")]
	Native,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum FileSystemHandleKind
{
	[Value("\"file\"")]
	File,
	[Value("\"directory\"")]
	Directory,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum WriteCommandType
{
	[Value("\"write\"")]
	Write,
	[Value("\"seek\"")]
	Seek,
	[Value("\"truncate\"")]
	Truncate,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum FullscreenNavigationUI
{
	[Value("\"auto\"")]
	Auto,
	[Value("\"show\"")]
	Show,
	[Value("\"hide\"")]
	Hide,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GamepadHand
{
	[Value("\"\"")]
	Empty,
	[Value("\"left\"")]
	Left,
	[Value("\"right\"")]
	Right,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GamepadMappingType
{
	[Value("\"\"")]
	Empty,
	[Value("\"standard\"")]
	Standard,
	[Value("\"xr-standard\"")]
	XrStandard,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GamepadHapticsResult
{
	[Value("\"complete\"")]
	Complete,
	[Value("\"preempted\"")]
	Preempted,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GamepadHapticEffectType
{
	[Value("\"dual-rumble\"")]
	DualRumble,
	[Value("\"trigger-rumble\"")]
	TriggerRumble,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GyroscopeLocalCoordinateSystem
{
	[Value("\"device\"")]
	Device,
	[Value("\"screen\"")]
	Screen,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum HandwritingRecognitionType
{
	[Value("\"text\"")]
	Text,
	[Value("\"per-character\"")]
	PerCharacter,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum HandwritingInputType
{
	[Value("\"mouse\"")]
	Mouse,
	[Value("\"stylus\"")]
	Stylus,
	[Value("\"touch\"")]
	Touch,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum DocumentReadyState
{
	[Value("\"loading\"")]
	Loading,
	[Value("\"interactive\"")]
	Interactive,
	[Value("\"complete\"")]
	Complete,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum DocumentVisibilityState
{
	[Value("\"visible\"")]
	Visible,
	[Value("\"hidden\"")]
	Hidden,
}


[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum CanPlayTypeResult
{
	[Value("\"\"")]
	Empty,
	[Value("\"maybe\"")]
	Maybe,
	[Value("\"probably\"")]
	Probably,
}


[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum TextTrackMode
{
	[Value("\"disabled\"")]
	Disabled,
	[Value("\"hidden\"")]
	Hidden,
	[Value("\"showing\"")]
	Showing,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum PredefinedColorSpace
{
	[Value("\"srgb\"")]
	Srgb,
	[Value("\"display-p3\"")]
	DisplayP3,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum CanvasFillRule
{
	[Value("\"nonzero\"")]
	Nonzero,
	[Value("\"evenodd\"")]
	Evenodd,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ImageSmoothingQuality
{
	[Value("\"low\"")]
	Low,
	[Value("\"medium\"")]
	Medium,
	[Value("\"high\"")]
	High,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum CanvasLineCap
{
	[Value("\"butt\"")]
	Butt,
	[Value("\"round\"")]
	Round,
	[Value("\"square\"")]
	Square,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum CanvasLineJoin
{
	[Value("\"round\"")]
	Round,
	[Value("\"bevel\"")]
	Bevel,
	[Value("\"miter\"")]
	Miter,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum CanvasDirection
{
	[Value("\"ltr\"")]
	Ltr,
	[Value("\"rtl\"")]
	Rtl,
	[Value("\"inherit\"")]
	Inherit,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum CanvasFontKerning
{
	[Value("\"auto\"")]
	Auto,
	[Value("\"normal\"")]
	Normal,
	[Value("\"none\"")]
	None,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ScrollRestoration
{
	[Value("\"auto\"")]
	Auto,
	[Value("\"manual\"")]
	Manual,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum NavigationHistoryBehavior
{
	[Value("\"auto\"")]
	Auto,
	[Value("\"push\"")]
	Push,
	[Value("\"replace\"")]
	Replace,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum NavigationFocusReset
{
	[Value("\"after-transition\"")]
	AfterTransition,
	[Value("\"manual\"")]
	Manual,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum NavigationScrollBehavior
{
	[Value("\"after-transition\"")]
	AfterTransition,
	[Value("\"manual\"")]
	Manual,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ImageOrientation
{
	[Value("\"from-image\"")]
	FromImage,
	[Value("\"flipY\"")]
	FlipY,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum PremultiplyAlpha
{
	[Value("\"none\"")]
	None,
	[Value("\"premultiply\"")]
	Premultiply,
	[Value("\"default\"")]
	Default,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ColorSpaceConversion
{
	[Value("\"none\"")]
	None,
	[Value("\"default\"")]
	Default,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum WorkerType
{
	[Value("\"classic\"")]
	Classic,
	[Value("\"module\"")]
	Module,
}



[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum UserIdleState
{
	[Value("\"active\"")]
	Active,
	[Value("\"idle\"")]
	Idle,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ScreenIdleState
{
	[Value("\"locked\"")]
	Locked,
	[Value("\"unlocked\"")]
	Unlocked,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RedEyeReduction
{
	[Value("\"never\"")]
	Never,
	[Value("\"always\"")]
	Always,
	[Value("\"controllable\"")]
	Controllable,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum FillLightMode
{
	[Value("\"auto\"")]
	Auto,
	[Value("\"off\"")]
	Off,
	[Value("\"flash\"")]
	Flash,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum IDBRequestReadyState
{
	[Value("\"pending\"")]
	Pending,
	[Value("\"done\"")]
	Done,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum IDBTransactionDurability
{
	[Value("\"default\"")]
	Default,
	[Value("\"strict\"")]
	Strict,
	[Value("\"relaxed\"")]
	Relaxed,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum IDBTransactionMode
{
	[Value("\"readonly\"")]
	Readonly,
	[Value("\"readwrite\"")]
	Readwrite,
	[Value("\"versionchange\"")]
	Versionchange,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum LoginStatus
{
	[Value("\"logged-in\"")]
	LoggedIn,
	[Value("\"logged-out\"")]
	LoggedOut,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MagnetometerLocalCoordinateSystem
{
	[Value("\"device\"")]
	Device,
	[Value("\"screen\"")]
	Screen,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum AppBannerPromptOutcome
{
	[Value("\"accepted\"")]
	Accepted,
	[Value("\"dismissed\"")]
	Dismissed,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MediaDecodingType
{
	[Value("\"file\"")]
	File,
	[Value("\"media-source\"")]
	MediaSource,
	[Value("\"webrtc\"")]
	Webrtc,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MediaEncodingType
{
	[Value("\"record\"")]
	Record,
	[Value("\"webrtc\"")]
	Webrtc,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum HdrMetadataType
{
	[Value("\"smpteSt2086\"")]
	SmpteSt2086,
	[Value("\"smpteSt2094-10\"")]
	SmpteSt209410,
	[Value("\"smpteSt2094-40\"")]
	SmpteSt209440,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ColorGamut
{
	[Value("\"srgb\"")]
	Srgb,
	[Value("\"p3\"")]
	P3,
	[Value("\"rec2020\"")]
	Rec2020,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum TransferFunction
{
	[Value("\"srgb\"")]
	Srgb,
	[Value("\"pq\"")]
	Pq,
	[Value("\"hlg\"")]
	Hlg,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ReadyState
{
	[Value("\"closed\"")]
	Closed,
	[Value("\"open\"")]
	Open,
	[Value("\"ended\"")]
	Ended,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum EndOfStreamError
{
	[Value("\"network\"")]
	Network,
	[Value("\"decode\"")]
	Decode,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum AppendMode
{
	[Value("\"segments\"")]
	Segments,
	[Value("\"sequence\"")]
	Sequence,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MockCapturePromptResult
{
	[Value("\"granted\"")]
	Granted,
	[Value("\"denied\"")]
	Denied,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MediaStreamTrackState
{
	[Value("\"live\"")]
	Live,
	[Value("\"ended\"")]
	Ended,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum VideoResizeModeEnum
{
	[Value("\"none\"")]
	None,
	[Value("\"crop-and-scale\"")]
	CropAndScale,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MediaDeviceKind
{
	[Value("\"audioinput\"")]
	Audioinput,
	[Value("\"audiooutput\"")]
	Audiooutput,
	[Value("\"videoinput\"")]
	Videoinput,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MediaSessionPlaybackState
{
	[Value("\"none\"")]
	None,
	[Value("\"paused\"")]
	Paused,
	[Value("\"playing\"")]
	Playing,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum BitrateMode
{
	[Value("\"constant\"")]
	Constant,
	[Value("\"variable\"")]
	Variable,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RecordingState
{
	[Value("\"inactive\"")]
	Inactive,
	[Value("\"recording\"")]
	Recording,
	[Value("\"paused\"")]
	Paused,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RTCDegradationPreference
{
	[Value("\"maintain-framerate\"")]
	MaintainFramerate,
	[Value("\"maintain-resolution\"")]
	MaintainResolution,
	[Value("\"balanced\"")]
	Balanced,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum NotificationPermission
{
	[Value("\"default\"")]
	Default,
	[Value("\"denied\"")]
	Denied,
	[Value("\"granted\"")]
	Granted,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum NotificationDirection
{
	[Value("\"auto\"")]
	Auto,
	[Value("\"ltr\"")]
	Ltr,
	[Value("\"rtl\"")]
	Rtl,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum OrientationSensorLocalCoordinateSystem
{
	[Value("\"device\"")]
	Device,
	[Value("\"screen\"")]
	Screen,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ClientLifecycleState
{
	[Value("\"active\"")]
	Active,
	[Value("\"frozen\"")]
	Frozen,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum PaymentShippingType
{
	[Value("\"shipping\"")]
	Shipping,
	[Value("\"delivery\"")]
	Delivery,
	[Value("\"pickup\"")]
	Pickup,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum PaymentComplete
{
	[Value("\"fail\"")]
	Fail,
	[Value("\"success\"")]
	Success,
	[Value("\"unknown\"")]
	Unknown,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum PermissionState
{
	[Value("\"granted\"")]
	Granted,
	[Value("\"denied\"")]
	Denied,
	[Value("\"prompt\"")]
	Prompt,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum PresentationConnectionCloseReason
{
	[Value("\"error\"")]
	Error,
	[Value("\"closed\"")]
	Closed,
	[Value("\"wentaway\"")]
	Wentaway,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum IPAddressSpace
{
	[Value("\"public\"")]
	Public,
	[Value("\"private\"")]
	Private,
	[Value("\"local\"")]
	Local,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum PushEncryptionKeyName
{
	[Value("\"p256dh\"")]
	P256dh,
	[Value("\"auth\"")]
	Auth,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RemotePlaybackState
{
	[Value("\"connecting\"")]
	Connecting,
	[Value("\"connected\"")]
	Connected,
	[Value("\"disconnected\"")]
	Disconnected,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ResizeObserverBoxOptions
{
	[Value("\"border-box\"")]
	BorderBox,
	[Value("\"content-box\"")]
	ContentBox,
	[Value("\"device-pixel-content-box\"")]
	DevicePixelContentBox,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RenderBlockingStatusType
{
	[Value("\"blocking\"")]
	Blocking,
	[Value("\"non-blocking\"")]
	NonBlocking,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum SameSiteCookiesType
{
	[Value("\"all\"")]
	All,
	[Value("\"none\"")]
	None,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum SanitizerPresets
{
	[Value("\"default\"")]
	Default,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum TaskPriority
{
	[Value("\"user-blocking\"")]
	UserBlocking,
	[Value("\"user-visible\"")]
	UserVisible,
	[Value("\"background\"")]
	Background,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum CaptureStartFocusBehavior
{
	[Value("\"focus-capturing-application\"")]
	FocusCapturingApplication,
	[Value("\"focus-captured-surface\"")]
	FocusCapturedSurface,
	[Value("\"no-focus-change\"")]
	NoFocusChange,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum SelfCapturePreferenceEnum
{
	[Value("\"include\"")]
	Include,
	[Value("\"exclude\"")]
	Exclude,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum SystemAudioPreferenceEnum
{
	[Value("\"include\"")]
	Include,
	[Value("\"exclude\"")]
	Exclude,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum SurfaceSwitchingPreferenceEnum
{
	[Value("\"include\"")]
	Include,
	[Value("\"exclude\"")]
	Exclude,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MonitorTypeSurfacesEnum
{
	[Value("\"include\"")]
	Include,
	[Value("\"exclude\"")]
	Exclude,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum DisplayCaptureSurfaceType
{
	[Value("\"monitor\"")]
	Monitor,
	[Value("\"window\"")]
	Window,
	[Value("\"browser\"")]
	Browser,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum CursorCaptureConstraint
{
	[Value("\"never\"")]
	Never,
	[Value("\"always\"")]
	Always,
	[Value("\"motion\"")]
	Motion,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum WakeLockType
{
	[Value("\"screen\"")]
	Screen,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ParityType
{
	[Value("\"none\"")]
	None,
	[Value("\"even\"")]
	Even,
	[Value("\"odd\"")]
	Odd,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum FlowControlType
{
	[Value("\"none\"")]
	None,
	[Value("\"hardware\"")]
	Hardware,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ServiceWorkerUpdateViaCache
{
	[Value("\"imports\"")]
	Imports,
	[Value("\"all\"")]
	All,
	[Value("\"none\"")]
	None,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RunningStatus
{
	[Value("\"running\"")]
	Running,
	[Value("\"not-running\"")]
	NotRunning,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum LandmarkType
{
	[Value("\"mouth\"")]
	Mouth,
	[Value("\"eye\"")]
	Eye,
	[Value("\"nose\"")]
	Nose,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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


[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ReadableStreamReaderMode
{
	[Value("\"byob\"")]
	Byob,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ReadableStreamType
{
	[Value("\"bytes\"")]
	Bytes,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum TouchType
{
	[Value("\"direct\"")]
	Direct,
	[Value("\"stylus\"")]
	Stylus,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RefreshPolicy
{
	[Value("\"none\"")]
	None,
	[Value("\"refresh\"")]
	Refresh,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum TokenVersion
{
	[Value("\"1\"")]
	_1,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum OperationType
{
	[Value("\"token-request\"")]
	TokenRequest,
	[Value("\"send-redemption-record\"")]
	SendRedemptionRecord,
	[Value("\"token-redemption\"")]
	TokenRedemption,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum TableKind
{
	[Value("\"externref\"")]
	Externref,
	[Value("\"anyfunc\"")]
	Anyfunc,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum IterationCompositeOperation
{
	[Value("\"replace\"")]
	Replace,
	[Value("\"accumulate\"")]
	Accumulate,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum AnimationReplaceState
{
	[Value("\"active\"")]
	Active,
	[Value("\"removed\"")]
	Removed,
	[Value("\"persisted\"")]
	Persisted,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum CompositeOperation
{
	[Value("\"replace\"")]
	Replace,
	[Value("\"add\"")]
	Add,
	[Value("\"accumulate\"")]
	Accumulate,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum LockMode
{
	[Value("\"shared\"")]
	Shared,
	[Value("\"exclusive\"")]
	Exclusive,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum OTPCredentialTransportType
{
	[Value("\"sms\"")]
	Sms,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum AudioContextState
{
	[Value("\"suspended\"")]
	Suspended,
	[Value("\"running\"")]
	Running,
	[Value("\"closed\"")]
	Closed,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum AudioContextRenderSizeCategory
{
	[Value("\"default\"")]
	Default,
	[Value("\"hardware\"")]
	Hardware,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum AudioContextLatencyCategory
{
	[Value("\"balanced\"")]
	Balanced,
	[Value("\"interactive\"")]
	Interactive,
	[Value("\"playback\"")]
	Playback,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum AudioSinkType
{
	[Value("\"none\"")]
	None,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ChannelCountMode
{
	[Value("\"max\"")]
	Max,
	[Value("\"clamped-max\"")]
	ClampedMax,
	[Value("\"explicit\"")]
	Explicit,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ChannelInterpretation
{
	[Value("\"speakers\"")]
	Speakers,
	[Value("\"discrete\"")]
	Discrete,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum AutomationRate
{
	[Value("\"a-rate\"")]
	ARate,
	[Value("\"k-rate\"")]
	KRate,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum PanningModelType
{
	[Value("\"equalpower\"")]
	Equalpower,
	[Value("\"HRTF\"")]
	HRTF,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum DistanceModelType
{
	[Value("\"linear\"")]
	Linear,
	[Value("\"inverse\"")]
	Inverse,
	[Value("\"exponential\"")]
	Exponential,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum OverSampleType
{
	[Value("\"none\"")]
	None,
	[Value("\"2x\"")]
	_2x,
	[Value("\"4x\"")]
	_4x,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum AuthenticatorAttachment
{
	[Value("\"platform\"")]
	Platform,
	[Value("\"cross-platform\"")]
	CrossPlatform,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ResidentKeyRequirement
{
	[Value("\"discouraged\"")]
	Discouraged,
	[Value("\"preferred\"")]
	Preferred,
	[Value("\"required\"")]
	Required,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum TokenBindingStatus
{
	[Value("\"present\"")]
	Present,
	[Value("\"supported\"")]
	Supported,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum PublicKeyCredentialType
{
	[Value("\"public-key\"")]
	PublicKey,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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


[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum UserVerificationRequirement
{
	[Value("\"required\"")]
	Required,
	[Value("\"preferred\"")]
	Preferred,
	[Value("\"discouraged\"")]
	Discouraged,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum PublicKeyCredentialHint
{
	[Value("\"security-key\"")]
	SecurityKey,
	[Value("\"client-device\"")]
	ClientDevice,
	[Value("\"hybrid\"")]
	Hybrid,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum LargeBlobSupport
{
	[Value("\"required\"")]
	Required,
	[Value("\"preferred\"")]
	Preferred,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum AacBitstreamFormat
{
	[Value("\"aac\"")]
	Aac,
	[Value("\"adts\"")]
	Adts,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum AvcBitstreamFormat
{
	[Value("\"annexb\"")]
	Annexb,
	[Value("\"avc\"")]
	Avc,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum HevcBitstreamFormat
{
	[Value("\"annexb\"")]
	Annexb,
	[Value("\"hevc\"")]
	Hevc,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum OpusBitstreamFormat
{
	[Value("\"opus\"")]
	Opus,
	[Value("\"ogg\"")]
	Ogg,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum OpusSignal
{
	[Value("\"auto\"")]
	Auto,
	[Value("\"music\"")]
	Music,
	[Value("\"voice\"")]
	Voice,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum OpusApplication
{
	[Value("\"voip\"")]
	Voip,
	[Value("\"audio\"")]
	Audio,
	[Value("\"lowdelay\"")]
	Lowdelay,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum HardwareAcceleration
{
	[Value("\"no-preference\"")]
	NoPreference,
	[Value("\"prefer-hardware\"")]
	PreferHardware,
	[Value("\"prefer-software\"")]
	PreferSoftware,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum AlphaOption
{
	[Value("\"keep\"")]
	Keep,
	[Value("\"discard\"")]
	Discard,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum LatencyMode
{
	[Value("\"quality\"")]
	Quality,
	[Value("\"realtime\"")]
	Realtime,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum VideoEncoderBitrateMode
{
	[Value("\"constant\"")]
	Constant,
	[Value("\"variable\"")]
	Variable,
	[Value("\"quantizer\"")]
	Quantizer,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum CodecState
{
	[Value("\"unconfigured\"")]
	Unconfigured,
	[Value("\"configured\"")]
	Configured,
	[Value("\"closed\"")]
	Closed,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum EncodedAudioChunkType
{
	[Value("\"key\"")]
	Key,
	[Value("\"delta\"")]
	Delta,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum EncodedVideoChunkType
{
	[Value("\"key\"")]
	Key,
	[Value("\"delta\"")]
	Delta,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum KeyType
{
	[Value("\"public\"")]
	Public,
	[Value("\"private\"")]
	Private,
	[Value("\"secret\"")]
	Secret,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum WebGLPowerPreference
{
	[Value("\"default\"")]
	Default,
	[Value("\"low-power\"")]
	LowPower,
	[Value("\"high-performance\"")]
	HighPerformance,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUPowerPreference
{
	[Value("\"low-power\"")]
	LowPower,
	[Value("\"high-performance\"")]
	HighPerformance,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUBufferMapState
{
	[Value("\"unmapped\"")]
	Unmapped,
	[Value("\"pending\"")]
	Pending,
	[Value("\"mapped\"")]
	Mapped,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUTextureDimension
{
	[Value("\"1d\"")]
	_1d,
	[Value("\"2d\"")]
	_2d,
	[Value("\"3d\"")]
	_3d,
}


[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUTextureAspect
{
	[Value("\"all\"")]
	All,
	[Value("\"stencil-only\"")]
	StencilOnly,
	[Value("\"depth-only\"")]
	DepthOnly,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUAddressMode
{
	[Value("\"clamp-to-edge\"")]
	ClampToEdge,
	[Value("\"repeat\"")]
	Repeat,
	[Value("\"mirror-repeat\"")]
	MirrorRepeat,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUFilterMode
{
	[Value("\"nearest\"")]
	Nearest,
	[Value("\"linear\"")]
	Linear,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUMipmapFilterMode
{
	[Value("\"nearest\"")]
	Nearest,
	[Value("\"linear\"")]
	Linear,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUBufferBindingType
{
	[Value("\"uniform\"")]
	Uniform,
	[Value("\"storage\"")]
	Storage,
	[Value("\"read-only-storage\"")]
	ReadOnlyStorage,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUSamplerBindingType
{
	[Value("\"filtering\"")]
	Filtering,
	[Value("\"non-filtering\"")]
	NonFiltering,
	[Value("\"comparison\"")]
	Comparison,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUStorageTextureAccess
{
	[Value("\"write-only\"")]
	WriteOnly,
	[Value("\"read-only\"")]
	ReadOnly,
	[Value("\"read-write\"")]
	ReadWrite,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUCompilationMessageType
{
	[Value("\"error\"")]
	Error,
	[Value("\"warning\"")]
	Warning,
	[Value("\"info\"")]
	Info,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUPipelineErrorReason
{
	[Value("\"validation\"")]
	Validation,
	[Value("\"internal\"")]
	Internal,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUAutoLayoutMode
{
	[Value("\"auto\"")]
	Auto,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUFrontFace
{
	[Value("\"ccw\"")]
	Ccw,
	[Value("\"cw\"")]
	Cw,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUCullMode
{
	[Value("\"none\"")]
	None,
	[Value("\"front\"")]
	Front,
	[Value("\"back\"")]
	Back,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUIndexFormat
{
	[Value("\"uint16\"")]
	Uint16,
	[Value("\"uint32\"")]
	Uint32,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUVertexStepMode
{
	[Value("\"vertex\"")]
	Vertex,
	[Value("\"instance\"")]
	Instance,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPULoadOp
{
	[Value("\"load\"")]
	Load,
	[Value("\"clear\"")]
	Clear,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUStoreOp
{
	[Value("\"store\"")]
	Store,
	[Value("\"discard\"")]
	Discard,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUQueryType
{
	[Value("\"occlusion\"")]
	Occlusion,
	[Value("\"timestamp\"")]
	Timestamp,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUCanvasAlphaMode
{
	[Value("\"opaque\"")]
	Opaque,
	[Value("\"premultiplied\"")]
	Premultiplied,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUCanvasToneMappingMode
{
	[Value("\"standard\"")]
	Standard,
	[Value("\"extended\"")]
	Extended,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUDeviceLostReason
{
	[Value("\"unknown\"")]
	Unknown,
	[Value("\"destroyed\"")]
	Destroyed,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum GPUErrorFilter
{
	[Value("\"validation\"")]
	Validation,
	[Value("\"out-of-memory\"")]
	OutOfMemory,
	[Value("\"internal\"")]
	Internal,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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




[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MIDIPortType
{
	[Value("\"input\"")]
	Input,
	[Value("\"output\"")]
	Output,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MIDIPortDeviceState
{
	[Value("\"disconnected\"")]
	Disconnected,
	[Value("\"connected\"")]
	Connected,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MIDIPortConnectionState
{
	[Value("\"open\"")]
	Open,
	[Value("\"closed\"")]
	Closed,
	[Value("\"pending\"")]
	Pending,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MLDeviceType
{
	[Value("\"cpu\"")]
	Cpu,
	[Value("\"gpu\"")]
	Gpu,
	[Value("\"npu\"")]
	Npu,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MLPowerPreference
{
	[Value("\"default\"")]
	Default,
	[Value("\"high-performance\"")]
	HighPerformance,
	[Value("\"low-power\"")]
	LowPower,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MLInputOperandLayout
{
	[Value("\"nchw\"")]
	Nchw,
	[Value("\"nhwc\"")]
	Nhwc,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MLConvTranspose2dFilterOperandLayout
{
	[Value("\"iohw\"")]
	Iohw,
	[Value("\"hwoi\"")]
	Hwoi,
	[Value("\"ohwi\"")]
	Ohwi,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MLGruWeightLayout
{
	[Value("\"zrn\"")]
	Zrn,
	[Value("\"rzn\"")]
	Rzn,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MLRecurrentNetworkActivation
{
	[Value("\"relu\"")]
	Relu,
	[Value("\"sigmoid\"")]
	Sigmoid,
	[Value("\"tanh\"")]
	Tanh,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MLRecurrentNetworkDirection
{
	[Value("\"forward\"")]
	Forward,
	[Value("\"backward\"")]
	Backward,
	[Value("\"both\"")]
	Both,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MLLstmWeightLayout
{
	[Value("\"iofg\"")]
	Iofg,
	[Value("\"ifgo\"")]
	Ifgo,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MLRoundingType
{
	[Value("\"floor\"")]
	Floor,
	[Value("\"ceil\"")]
	Ceil,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum MLInterpolationMode
{
	[Value("\"nearest-neighbor\"")]
	NearestNeighbor,
	[Value("\"linear\"")]
	Linear,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum SFrameTransformRole
{
	[Value("\"encrypt\"")]
	Encrypt,
	[Value("\"decrypt\"")]
	Decrypt,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum SFrameTransformErrorEventType
{
	[Value("\"authentication\"")]
	Authentication,
	[Value("\"keyID\"")]
	KeyID,
	[Value("\"syntax\"")]
	Syntax,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RTCEncodedVideoFrameType
{
	[Value("\"empty\"")]
	Empty,
	[Value("\"key\"")]
	Key,
	[Value("\"delta\"")]
	Delta,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RTCDtlsRole
{
	[Value("\"client\"")]
	Client,
	[Value("\"server\"")]
	Server,
	[Value("\"unknown\"")]
	Unknown,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RTCIceTransportPolicy
{
	[Value("\"relay\"")]
	Relay,
	[Value("\"all\"")]
	All,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RTCBundlePolicy
{
	[Value("\"balanced\"")]
	Balanced,
	[Value("\"max-compat\"")]
	MaxCompat,
	[Value("\"max-bundle\"")]
	MaxBundle,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RTCRtcpMuxPolicy
{
	[Value("\"require\"")]
	Require,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RTCIceGatheringState
{
	[Value("\"new\"")]
	New,
	[Value("\"gathering\"")]
	Gathering,
	[Value("\"complete\"")]
	Complete,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RTCIceProtocol
{
	[Value("\"udp\"")]
	Udp,
	[Value("\"tcp\"")]
	Tcp,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RTCIceTcpCandidateType
{
	[Value("\"active\"")]
	Active,
	[Value("\"passive\"")]
	Passive,
	[Value("\"so\"")]
	So,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RTCIceServerTransportProtocol
{
	[Value("\"udp\"")]
	Udp,
	[Value("\"tcp\"")]
	Tcp,
	[Value("\"tls\"")]
	Tls,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RTCIceGathererState
{
	[Value("\"new\"")]
	New,
	[Value("\"gathering\"")]
	Gathering,
	[Value("\"complete\"")]
	Complete,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RTCIceRole
{
	[Value("\"unknown\"")]
	Unknown,
	[Value("\"controlling\"")]
	Controlling,
	[Value("\"controlled\"")]
	Controlled,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RTCIceComponent
{
	[Value("\"rtp\"")]
	Rtp,
	[Value("\"rtcp\"")]
	Rtcp,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum RTCSctpTransportState
{
	[Value("\"connecting\"")]
	Connecting,
	[Value("\"connected\"")]
	Connected,
	[Value("\"closed\"")]
	Closed,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum BinaryType
{
	[Value("\"blob\"")]
	Blob,
	[Value("\"arraybuffer\"")]
	Arraybuffer,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum WebTransportReliabilityMode
{
	[Value("\"pending\"")]
	Pending,
	[Value("\"reliable-only\"")]
	ReliableOnly,
	[Value("\"supports-unreliable\"")]
	SupportsUnreliable,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum WebTransportCongestionControl
{
	[Value("\"default\"")]
	Default,
	[Value("\"throughput\"")]
	Throughput,
	[Value("\"low-latency\"")]
	LowLatency,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum WebTransportErrorSource
{
	[Value("\"stream\"")]
	Stream,
	[Value("\"session\"")]
	Session,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum USBTransferStatus
{
	[Value("\"ok\"")]
	Ok,
	[Value("\"stall\"")]
	Stall,
	[Value("\"babble\"")]
	Babble,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum USBRequestType
{
	[Value("\"standard\"")]
	Standard,
	[Value("\"class\"")]
	Class,
	[Value("\"vendor\"")]
	Vendor,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum USBDirection
{
	[Value("\"in\"")]
	In,
	[Value("\"out\"")]
	Out,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum USBEndpointType
{
	[Value("\"bulk\"")]
	Bulk,
	[Value("\"interrupt\"")]
	Interrupt,
	[Value("\"isochronous\"")]
	Isochronous,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum AutoKeyword
{
	[Value("\"auto\"")]
	Auto,
}


[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum DirectionSetting
{
	[Value("\"\"")]
	Empty,
	[Value("\"rl\"")]
	Rl,
	[Value("\"lr\"")]
	Lr,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum LineAlignSetting
{
	[Value("\"start\"")]
	Start,
	[Value("\"center\"")]
	Center,
	[Value("\"end\"")]
	End,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum ScrollSetting
{
	[Value("\"\"")]
	Empty,
	[Value("\"up\"")]
	Up,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum XREnvironmentBlendMode
{
	[Value("\"opaque\"")]
	Opaque,
	[Value("\"alpha-blend\"")]
	AlphaBlend,
	[Value("\"additive\"")]
	Additive,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum XRInteractionMode
{
	[Value("\"screen-space\"")]
	ScreenSpace,
	[Value("\"world-space\"")]
	WorldSpace,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum XRDepthUsage
{
	[Value("\"cpu-optimized\"")]
	CpuOptimized,
	[Value("\"gpu-optimized\"")]
	GpuOptimized,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum XRDepthDataFormat
{
	[Value("\"luminance-alpha\"")]
	LuminanceAlpha,
	[Value("\"float32\"")]
	Float32,
	[Value("\"unsigned-short\"")]
	UnsignedShort,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum XRDOMOverlayType
{
	[Value("\"screen\"")]
	Screen,
	[Value("\"floating\"")]
	Floating,
	[Value("\"head-locked\"")]
	HeadLocked,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum XRHitTestTrackableType
{
	[Value("\"point\"")]
	Point,
	[Value("\"plane\"")]
	Plane,
	[Value("\"mesh\"")]
	Mesh,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum XRReflectionFormat
{
	[Value("\"srgba8\"")]
	Srgba8,
	[Value("\"rgba16f\"")]
	Rgba16f,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum XRPlaneOrientation
{
	[Value("\"horizontal\"")]
	Horizontal,
	[Value("\"vertical\"")]
	Vertical,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum XRSessionMode
{
	[Value("\"inline\"")]
	Inline,
	[Value("\"immersive-vr\"")]
	ImmersiveVr,
	[Value("\"immersive-ar\"")]
	ImmersiveAr,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum XRVisibilityState
{
	[Value("\"visible\"")]
	Visible,
	[Value("\"visible-blurred\"")]
	VisibleBlurred,
	[Value("\"hidden\"")]
	Hidden,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum XREye
{
	[Value("\"none\"")]
	None,
	[Value("\"left\"")]
	Left,
	[Value("\"right\"")]
	Right,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum XRHandedness
{
	[Value("\"none\"")]
	None,
	[Value("\"left\"")]
	Left,
	[Value("\"right\"")]
	Right,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum XRLayerQuality
{
	[Value("\"default\"")]
	Default,
	[Value("\"text-optimized\"")]
	TextOptimized,
	[Value("\"graphics-optimized\"")]
	GraphicsOptimized,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
public enum XRTextureType
{
	[Value("\"texture\"")]
	Texture,
	[Value("\"texture-array\"")]
	TextureArray,
}

[To(ToAttribute.NoneWithTrailingDotRemoved)]
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

