//21.12.2025 16:22:31

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


[To(ToAttribute.None)]
public enum AccelerometerLocalCoordinateSystem
{
	[EnumValue("device")]
	Device,
	[EnumValue("screen")]
	Screen,
}

[To(ToAttribute.None)]
public enum AudioSessionType
{
	[EnumValue("auto")]
	Auto,
	[EnumValue("playback")]
	Playback,
	[EnumValue("transient")]
	Transient,
	[EnumValue("transient-solo")]
	TransientSolo,
	[EnumValue("ambient")]
	Ambient,
	[EnumValue("play-and-record")]
	PlayAndRecord,
}

[To(ToAttribute.None)]
public enum AudioSessionState
{
	[EnumValue("inactive")]
	Inactive,
	[EnumValue("active")]
	Active,
	[EnumValue("interrupted")]
	Interrupted,
}

[To(ToAttribute.None)]
public enum AutoplayPolicy
{
	[EnumValue("allowed")]
	Allowed,
	[EnumValue("allowed-muted")]
	AllowedMuted,
	[EnumValue("disallowed")]
	Disallowed,
}

[To(ToAttribute.None)]
public enum AutoplayPolicyMediaType
{
	[EnumValue("mediaelement")]
	Mediaelement,
	[EnumValue("audiocontext")]
	Audiocontext,
}

[To(ToAttribute.None)]
public enum BackgroundFetchResult
{
	[EnumValue("")]
	Empty,
	[EnumValue("success")]
	Success,
	[EnumValue("failure")]
	Failure,
}

[To(ToAttribute.None)]
public enum BackgroundFetchFailureReason
{
	[EnumValue("")]
	Empty,
	[EnumValue("aborted")]
	Aborted,
	[EnumValue("bad-status")]
	BadStatus,
	[EnumValue("fetch-error")]
	FetchError,
	[EnumValue("quota-exceeded")]
	QuotaExceeded,
	[EnumValue("download-total-exceeded")]
	DownloadTotalExceeded,
}

[To(ToAttribute.None)]
public enum PresentationStyle
{
	[EnumValue("unspecified")]
	Unspecified,
	[EnumValue("inline")]
	Inline,
	[EnumValue("attachment")]
	Attachment,
}

[To(ToAttribute.None)]
public enum CompressionFormat
{
	[EnumValue("deflate")]
	Deflate,
	[EnumValue("deflate-raw")]
	DeflateRaw,
	[EnumValue("gzip")]
	Gzip,
}

[To(ToAttribute.None)]
public enum PressureSource
{
	[EnumValue("cpu")]
	Cpu,
}

[To(ToAttribute.None)]
public enum PressureState
{
	[EnumValue("nominal")]
	Nominal,
	[EnumValue("fair")]
	Fair,
	[EnumValue("serious")]
	Serious,
	[EnumValue("critical")]
	Critical,
}

[To(ToAttribute.None)]
public enum ContactProperty
{
	[EnumValue("address")]
	Address,
	[EnumValue("email")]
	Email,
	[EnumValue("icon")]
	Icon,
	[EnumValue("name")]
	Name,
	[EnumValue("tel")]
	Tel,
}

[To(ToAttribute.None)]
public enum ContentCategory
{
	[EnumValue("")]
	Empty,
	[EnumValue("homepage")]
	Homepage,
	[EnumValue("article")]
	Article,
	[EnumValue("video")]
	Video,
	[EnumValue("audio")]
	Audio,
}

[To(ToAttribute.None)]
public enum CookieSameSite
{
	[EnumValue("strict")]
	Strict,
	[EnumValue("lax")]
	Lax,
	[EnumValue("none")]
	None,
}

[To(ToAttribute.None)]
public enum CredentialMediationRequirement
{
	[EnumValue("silent")]
	Silent,
	[EnumValue("optional")]
	Optional,
	[EnumValue("conditional")]
	Conditional,
	[EnumValue("required")]
	Required,
}

[To(ToAttribute.None)]
public enum ScriptingPolicyViolationType
{
	[EnumValue("externalScript")]
	ExternalScript,
	[EnumValue("inlineScript")]
	InlineScript,
	[EnumValue("inlineEventHandler")]
	InlineEventHandler,
	[EnumValue("eval")]
	Eval,
}

[To(ToAttribute.None)]
public enum SecurityPolicyViolationEventDisposition
{
	[EnumValue("enforce")]
	Enforce,
	[EnumValue("report")]
	Report,
}

[To(ToAttribute.None)]
public enum FontFaceLoadStatus
{
	[EnumValue("unloaded")]
	Unloaded,
	[EnumValue("loading")]
	Loading,
	[EnumValue("loaded")]
	Loaded,
	[EnumValue("error")]
	Error,
}

[To(ToAttribute.None)]
public enum FontFaceSetLoadStatus
{
	[EnumValue("loading")]
	Loading,
	[EnumValue("loaded")]
	Loaded,
}

[To(ToAttribute.None)]
public enum HighlightType
{
	[EnumValue("highlight")]
	Highlight,
	[EnumValue("spelling-error")]
	SpellingError,
	[EnumValue("grammar-error")]
	GrammarError,
}

[To(ToAttribute.None)]
public enum ChildDisplayType
{
	[EnumValue("block")]
	Block,
	[EnumValue("normal")]
	Normal,
}

[To(ToAttribute.None)]
public enum LayoutSizingMode
{
	[EnumValue("block-like")]
	BlockLike,
	[EnumValue("manual")]
	Manual,
}

[To(ToAttribute.None)]
public enum BlockFragmentationType
{
	[EnumValue("none")]
	None,
	[EnumValue("page")]
	Page,
	[EnumValue("column")]
	Column,
	[EnumValue("region")]
	Region,
}

[To(ToAttribute.None)]
public enum BreakType
{
	[EnumValue("none")]
	None,
	[EnumValue("line")]
	Line,
	[EnumValue("column")]
	Column,
	[EnumValue("page")]
	Page,
	[EnumValue("region")]
	Region,
}

[To(ToAttribute.None)]
public enum SpatialNavigationDirection
{
	[EnumValue("up")]
	Up,
	[EnumValue("down")]
	Down,
	[EnumValue("left")]
	Left,
	[EnumValue("right")]
	Right,
}

[To(ToAttribute.None)]
public enum FocusableAreaSearchMode
{
	[EnumValue("visible")]
	Visible,
	[EnumValue("all")]
	All,
}

[To(ToAttribute.None)]
public enum CSSNumericBaseType
{
	[EnumValue("length")]
	Length,
	[EnumValue("angle")]
	Angle,
	[EnumValue("time")]
	Time,
	[EnumValue("frequency")]
	Frequency,
	[EnumValue("resolution")]
	Resolution,
	[EnumValue("flex")]
	Flex,
	[EnumValue("percent")]
	Percent,
}

[To(ToAttribute.None)]
public enum CSSMathOperator
{
	[EnumValue("sum")]
	Sum,
	[EnumValue("product")]
	Product,
	[EnumValue("negate")]
	Negate,
	[EnumValue("invert")]
	Invert,
	[EnumValue("min")]
	Min,
	[EnumValue("max")]
	Max,
	[EnumValue("clamp")]
	Clamp,
}

[To(ToAttribute.None)]
public enum ScrollBehavior
{
	[EnumValue("auto")]
	Auto,
	[EnumValue("instant")]
	Instant,
	[EnumValue("smooth")]
	Smooth,
}

[To(ToAttribute.None)]
public enum ScrollLogicalPosition
{
	[EnumValue("start")]
	Start,
	[EnumValue("center")]
	Center,
	[EnumValue("end")]
	End,
	[EnumValue("nearest")]
	Nearest,
}

[To(ToAttribute.None)]
public enum CSSBoxType
{
	[EnumValue("margin")]
	Margin,
	[EnumValue("border")]
	Border,
	[EnumValue("padding")]
	Padding,
	[EnumValue("content")]
	Content,
}

[To(ToAttribute.None)]
public enum DevicePostureType
{
	[EnumValue("continuous")]
	Continuous,
	[EnumValue("folded")]
	Folded,
}

[To(ToAttribute.None)]
public enum ItemType
{
	[EnumValue("product")]
	Product,
	[EnumValue("subscription")]
	Subscription,
}

[To(ToAttribute.None)]
public enum ShadowRootMode
{
	[EnumValue("open")]
	Open,
	[EnumValue("closed")]
	Closed,
}

[To(ToAttribute.None)]
public enum SlotAssignmentMode
{
	[EnumValue("manual")]
	Manual,
	[EnumValue("named")]
	Named,
}

[To(ToAttribute.None)]
public enum UnderlineStyle
{
	[EnumValue("none")]
	None,
	[EnumValue("solid")]
	Solid,
	[EnumValue("dotted")]
	Dotted,
	[EnumValue("dashed")]
	Dashed,
	[EnumValue("wavy")]
	Wavy,
}

[To(ToAttribute.None)]
public enum UnderlineThickness
{
	[EnumValue("none")]
	None,
	[EnumValue("thin")]
	Thin,
	[EnumValue("thick")]
	Thick,
}

[To(ToAttribute.None)]
public enum MediaKeysRequirement
{
	[EnumValue("required")]
	Required,
	[EnumValue("optional")]
	Optional,
	[EnumValue("not-allowed")]
	NotAllowed,
}

[To(ToAttribute.None)]
public enum MediaKeySessionType
{
	[EnumValue("temporary")]
	Temporary,
	[EnumValue("persistent-license")]
	PersistentLicense,
}

[To(ToAttribute.None)]
public enum MediaKeySessionClosedReason
{
	[EnumValue("internal-error")]
	InternalError,
	[EnumValue("closed-by-application")]
	ClosedByApplication,
	[EnumValue("release-acknowledged")]
	ReleaseAcknowledged,
	[EnumValue("hardware-context-reset")]
	HardwareContextReset,
	[EnumValue("resource-evicted")]
	ResourceEvicted,
}

[To(ToAttribute.None)]
public enum MediaKeyStatus
{
	[EnumValue("usable")]
	Usable,
	[EnumValue("expired")]
	Expired,
	[EnumValue("released")]
	Released,
	[EnumValue("output-restricted")]
	OutputRestricted,
	[EnumValue("output-downscaled")]
	OutputDownscaled,
	[EnumValue("usable-in-future")]
	UsableInFuture,
	[EnumValue("status-pending")]
	StatusPending,
	[EnumValue("internal-error")]
	InternalError,
}

[To(ToAttribute.None)]
public enum MediaKeyMessageType
{
	[EnumValue("license-request")]
	LicenseRequest,
	[EnumValue("license-renewal")]
	LicenseRenewal,
	[EnumValue("license-release")]
	LicenseRelease,
	[EnumValue("individualization-request")]
	IndividualizationRequest,
}

[To(ToAttribute.None)]
public enum IdentityCredentialRequestOptionsContext
{
	[EnumValue("signin")]
	Signin,
	[EnumValue("signup")]
	Signup,
	[EnumValue("use")]
	Use,
	[EnumValue("continue")]
	Continue,
}

[To(ToAttribute.None)]
public enum IdentityCredentialRequestOptionsMode
{
	[EnumValue("active")]
	Active,
	[EnumValue("passive")]
	Passive,
}

[To(ToAttribute.None)]
public enum OpaqueProperty
{
	[EnumValue("opaque")]
	Opaque,
}

[To(ToAttribute.None)]
public enum FenceReportingDestination
{
	[EnumValue("buyer")]
	Buyer,
	[EnumValue("seller")]
	Seller,
	[EnumValue("component-seller")]
	ComponentSeller,
	[EnumValue("direct-seller")]
	DirectSeller,
	[EnumValue("shared-storage-select-url")]
	SharedStorageSelectUrl,
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestDestination/*'/>
[To(ToAttribute.None)]
public enum RequestDestination
{
	[EnumValue("")]
	Empty,
	[EnumValue("audio")]
	Audio,
	[EnumValue("audioworklet")]
	Audioworklet,
	[EnumValue("document")]
	Document,
	[EnumValue("embed")]
	Embed,
	[EnumValue("font")]
	Font,
	[EnumValue("frame")]
	Frame,
	[EnumValue("iframe")]
	Iframe,
	[EnumValue("image")]
	Image,
	[EnumValue("json")]
	Json,
	[EnumValue("manifest")]
	Manifest,
	[EnumValue("object")]
	Object,
	[EnumValue("paintworklet")]
	Paintworklet,
	[EnumValue("report")]
	Report,
	[EnumValue("script")]
	Script,
	[EnumValue("sharedworker")]
	Sharedworker,
	[EnumValue("style")]
	Style,
	[EnumValue("track")]
	Track,
	[EnumValue("video")]
	Video,
	[EnumValue("worker")]
	Worker,
	[EnumValue("xslt")]
	Xslt,
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestMode/*'/>
[To(ToAttribute.None)]
public enum RequestMode
{
	[EnumValue("navigate")]
	Navigate,
	[EnumValue("same-origin")]
	SameOrigin,
	[EnumValue("no-cors")]
	NoCors,
	[EnumValue("cors")]
	Cors,
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestCredentials/*'/>
[To(ToAttribute.None)]
public enum RequestCredentials
{
	[EnumValue("omit")]
	Omit,
	[EnumValue("same-origin")]
	SameOrigin,
	[EnumValue("include")]
	Include,
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestCache/*'/>
[To(ToAttribute.None)]
public enum RequestCache
{
	[EnumValue("default")]
	Default,
	[EnumValue("no-store")]
	NoStore,
	[EnumValue("reload")]
	Reload,
	[EnumValue("no-cache")]
	NoCache,
	[EnumValue("force-cache")]
	ForceCache,
	[EnumValue("only-if-cached")]
	OnlyIfCached,
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestRedirect/*'/>
[To(ToAttribute.None)]
public enum RequestRedirect
{
	[EnumValue("follow")]
	Follow,
	[EnumValue("error")]
	Error,
	[EnumValue("manual")]
	Manual,
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestDuplex/*'/>
[To(ToAttribute.None)]
public enum RequestDuplex
{
	[EnumValue("half")]
	Half,
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestPriority/*'/>
[To(ToAttribute.None)]
public enum RequestPriority
{
	[EnumValue("high")]
	High,
	[EnumValue("low")]
	Low,
	[EnumValue("auto")]
	Auto,
}

[To(ToAttribute.None)]
public enum ResponseType
{
	[EnumValue("basic")]
	Basic,
	[EnumValue("cors")]
	Cors,
	[EnumValue("default")]
	Default,
	[EnumValue("error")]
	Error,
	[EnumValue("opaque")]
	Opaque,
	[EnumValue("opaqueredirect")]
	Opaqueredirect,
}

[To(ToAttribute.None)]
public enum FileSystemPermissionMode
{
	[EnumValue("read")]
	Read,
	[EnumValue("readwrite")]
	Readwrite,
}

[To(ToAttribute.None)]
public enum WellKnownDirectory
{
	[EnumValue("desktop")]
	Desktop,
	[EnumValue("documents")]
	Documents,
	[EnumValue("downloads")]
	Downloads,
	[EnumValue("music")]
	Music,
	[EnumValue("pictures")]
	Pictures,
	[EnumValue("videos")]
	Videos,
}


[To(ToAttribute.None)]
public enum EndingType
{
	[EnumValue("transparent")]
	Transparent,
	[EnumValue("native")]
	Native,
}

[To(ToAttribute.None)]
public enum FileSystemHandleKind
{
	[EnumValue("file")]
	File,
	[EnumValue("directory")]
	Directory,
}

[To(ToAttribute.None)]
public enum WriteCommandType
{
	[EnumValue("write")]
	Write,
	[EnumValue("seek")]
	Seek,
	[EnumValue("truncate")]
	Truncate,
}

[To(ToAttribute.None)]
public enum FullscreenNavigationUI
{
	[EnumValue("auto")]
	Auto,
	[EnumValue("show")]
	Show,
	[EnumValue("hide")]
	Hide,
}

[To(ToAttribute.None)]
public enum GamepadHand
{
	[EnumValue("")]
	Empty,
	[EnumValue("left")]
	Left,
	[EnumValue("right")]
	Right,
}

[To(ToAttribute.None)]
public enum GamepadMappingType
{
	[EnumValue("")]
	Empty,
	[EnumValue("standard")]
	Standard,
	[EnumValue("xr-standard")]
	XrStandard,
}

[To(ToAttribute.None)]
public enum GamepadHapticsResult
{
	[EnumValue("complete")]
	Complete,
	[EnumValue("preempted")]
	Preempted,
}

[To(ToAttribute.None)]
public enum GamepadHapticEffectType
{
	[EnumValue("dual-rumble")]
	DualRumble,
	[EnumValue("trigger-rumble")]
	TriggerRumble,
}

[To(ToAttribute.None)]
public enum GyroscopeLocalCoordinateSystem
{
	[EnumValue("device")]
	Device,
	[EnumValue("screen")]
	Screen,
}

[To(ToAttribute.None)]
public enum HandwritingRecognitionType
{
	[EnumValue("text")]
	Text,
	[EnumValue("per-character")]
	PerCharacter,
}

[To(ToAttribute.None)]
public enum HandwritingInputType
{
	[EnumValue("mouse")]
	Mouse,
	[EnumValue("stylus")]
	Stylus,
	[EnumValue("touch")]
	Touch,
}

[To(ToAttribute.None)]
public enum DocumentReadyState
{
	[EnumValue("loading")]
	Loading,
	[EnumValue("interactive")]
	Interactive,
	[EnumValue("complete")]
	Complete,
}

[To(ToAttribute.None)]
public enum DocumentVisibilityState
{
	[EnumValue("visible")]
	Visible,
	[EnumValue("hidden")]
	Hidden,
}


[To(ToAttribute.None)]
public enum CanPlayTypeResult
{
	[EnumValue("")]
	Empty,
	[EnumValue("maybe")]
	Maybe,
	[EnumValue("probably")]
	Probably,
}


[To(ToAttribute.None)]
public enum TextTrackMode
{
	[EnumValue("disabled")]
	Disabled,
	[EnumValue("hidden")]
	Hidden,
	[EnumValue("showing")]
	Showing,
}

[To(ToAttribute.None)]
public enum TextTrackKind
{
	[EnumValue("subtitles")]
	Subtitles,
	[EnumValue("captions")]
	Captions,
	[EnumValue("descriptions")]
	Descriptions,
	[EnumValue("chapters")]
	Chapters,
	[EnumValue("metadata")]
	Metadata,
}

[To(ToAttribute.None)]
public enum SelectionMode
{
	[EnumValue("select")]
	Select,
	[EnumValue("start")]
	Start,
	[EnumValue("end")]
	End,
	[EnumValue("preserve")]
	Preserve,
}

[To(ToAttribute.None)]
public enum PredefinedColorSpace
{
	[EnumValue("srgb")]
	Srgb,
	[EnumValue("display-p3")]
	DisplayP3,
}

[To(ToAttribute.None)]
public enum CanvasFillRule
{
	[EnumValue("nonzero")]
	Nonzero,
	[EnumValue("evenodd")]
	Evenodd,
}

[To(ToAttribute.None)]
public enum ImageSmoothingQuality
{
	[EnumValue("low")]
	Low,
	[EnumValue("medium")]
	Medium,
	[EnumValue("high")]
	High,
}

[To(ToAttribute.None)]
public enum CanvasLineCap
{
	[EnumValue("butt")]
	Butt,
	[EnumValue("round")]
	Round,
	[EnumValue("square")]
	Square,
}

[To(ToAttribute.None)]
public enum CanvasLineJoin
{
	[EnumValue("round")]
	Round,
	[EnumValue("bevel")]
	Bevel,
	[EnumValue("miter")]
	Miter,
}

[To(ToAttribute.None)]
public enum CanvasTextAlign
{
	[EnumValue("start")]
	Start,
	[EnumValue("end")]
	End,
	[EnumValue("left")]
	Left,
	[EnumValue("right")]
	Right,
	[EnumValue("center")]
	Center,
}

[To(ToAttribute.None)]
public enum CanvasTextBaseline
{
	[EnumValue("top")]
	Top,
	[EnumValue("hanging")]
	Hanging,
	[EnumValue("middle")]
	Middle,
	[EnumValue("alphabetic")]
	Alphabetic,
	[EnumValue("ideographic")]
	Ideographic,
	[EnumValue("bottom")]
	Bottom,
}

[To(ToAttribute.None)]
public enum CanvasDirection
{
	[EnumValue("ltr")]
	Ltr,
	[EnumValue("rtl")]
	Rtl,
	[EnumValue("inherit")]
	Inherit,
}

[To(ToAttribute.None)]
public enum CanvasFontKerning
{
	[EnumValue("auto")]
	Auto,
	[EnumValue("normal")]
	Normal,
	[EnumValue("none")]
	None,
}

[To(ToAttribute.None)]
public enum CanvasFontStretch
{
	[EnumValue("ultra-condensed")]
	UltraCondensed,
	[EnumValue("extra-condensed")]
	ExtraCondensed,
	[EnumValue("condensed")]
	Condensed,
	[EnumValue("semi-condensed")]
	SemiCondensed,
	[EnumValue("normal")]
	Normal,
	[EnumValue("semi-expanded")]
	SemiExpanded,
	[EnumValue("expanded")]
	Expanded,
	[EnumValue("extra-expanded")]
	ExtraExpanded,
	[EnumValue("ultra-expanded")]
	UltraExpanded,
}

[To(ToAttribute.None)]
public enum CanvasFontVariantCaps
{
	[EnumValue("normal")]
	Normal,
	[EnumValue("small-caps")]
	SmallCaps,
	[EnumValue("all-small-caps")]
	AllSmallCaps,
	[EnumValue("petite-caps")]
	PetiteCaps,
	[EnumValue("all-petite-caps")]
	AllPetiteCaps,
	[EnumValue("unicase")]
	Unicase,
	[EnumValue("titling-caps")]
	TitlingCaps,
}

[To(ToAttribute.None)]
public enum CanvasTextRendering
{
	[EnumValue("auto")]
	Auto,
	[EnumValue("optimizeSpeed")]
	OptimizeSpeed,
	[EnumValue("optimizeLegibility")]
	OptimizeLegibility,
	[EnumValue("geometricPrecision")]
	GeometricPrecision,
}

[To(ToAttribute.None)]
public enum OffscreenRenderingContextId
{
	[EnumValue("2d")]
	_2d,
	[EnumValue("bitmaprenderer")]
	Bitmaprenderer,
	[EnumValue("webgl")]
	Webgl,
	[EnumValue("webgl2")]
	Webgl2,
	[EnumValue("webgpu")]
	Webgpu,
}

[To(ToAttribute.None)]
public enum ScrollRestoration
{
	[EnumValue("auto")]
	Auto,
	[EnumValue("manual")]
	Manual,
}

[To(ToAttribute.None)]
public enum NavigationHistoryBehavior
{
	[EnumValue("auto")]
	Auto,
	[EnumValue("push")]
	Push,
	[EnumValue("replace")]
	Replace,
}

[To(ToAttribute.None)]
public enum NavigationType
{
	[EnumValue("push")]
	Push,
	[EnumValue("replace")]
	Replace,
	[EnumValue("reload")]
	Reload,
	[EnumValue("traverse")]
	Traverse,
}

[To(ToAttribute.None)]
public enum NavigationFocusReset
{
	[EnumValue("after-transition")]
	AfterTransition,
	[EnumValue("manual")]
	Manual,
}

[To(ToAttribute.None)]
public enum NavigationScrollBehavior
{
	[EnumValue("after-transition")]
	AfterTransition,
	[EnumValue("manual")]
	Manual,
}

[To(ToAttribute.None)]
public enum DOMParserSupportedType
{
	[EnumValue("text/html")]
	TextHtml,
	[EnumValue("text/xml")]
	TextXml,
	[EnumValue("application/xml")]
	ApplicationXml,
	[EnumValue("application/xhtml+xml")]
	ApplicationXhtmlXml,
	[EnumValue("image/svg+xml")]
	ImageSvgXml,
}

[To(ToAttribute.None)]
public enum ImageOrientation
{
	[EnumValue("from-image")]
	FromImage,
	[EnumValue("flipY")]
	FlipY,
}

[To(ToAttribute.None)]
public enum PremultiplyAlpha
{
	[EnumValue("none")]
	None,
	[EnumValue("premultiply")]
	Premultiply,
	[EnumValue("default")]
	Default,
}

[To(ToAttribute.None)]
public enum ColorSpaceConversion
{
	[EnumValue("none")]
	None,
	[EnumValue("default")]
	Default,
}

[To(ToAttribute.None)]
public enum ResizeQuality
{
	[EnumValue("pixelated")]
	Pixelated,
	[EnumValue("low")]
	Low,
	[EnumValue("medium")]
	Medium,
	[EnumValue("high")]
	High,
}

[To(ToAttribute.None)]
public enum WorkerType
{
	[EnumValue("classic")]
	Classic,
	[EnumValue("module")]
	Module,
}



[To(ToAttribute.None)]
public enum UserIdleState
{
	[EnumValue("active")]
	Active,
	[EnumValue("idle")]
	Idle,
}

[To(ToAttribute.None)]
public enum ScreenIdleState
{
	[EnumValue("locked")]
	Locked,
	[EnumValue("unlocked")]
	Unlocked,
}

[To(ToAttribute.None)]
public enum RedEyeReduction
{
	[EnumValue("never")]
	Never,
	[EnumValue("always")]
	Always,
	[EnumValue("controllable")]
	Controllable,
}

[To(ToAttribute.None)]
public enum FillLightMode
{
	[EnumValue("auto")]
	Auto,
	[EnumValue("off")]
	Off,
	[EnumValue("flash")]
	Flash,
}

[To(ToAttribute.None)]
public enum MeteringMode
{
	[EnumValue("none")]
	None,
	[EnumValue("manual")]
	Manual,
	[EnumValue("single-shot")]
	SingleShot,
	[EnumValue("continuous")]
	Continuous,
}

[To(ToAttribute.None)]
public enum IDBRequestReadyState
{
	[EnumValue("pending")]
	Pending,
	[EnumValue("done")]
	Done,
}

[To(ToAttribute.None)]
public enum IDBTransactionDurability
{
	[EnumValue("default")]
	Default,
	[EnumValue("strict")]
	Strict,
	[EnumValue("relaxed")]
	Relaxed,
}

[To(ToAttribute.None)]
public enum IDBCursorDirection
{
	[EnumValue("next")]
	Next,
	[EnumValue("nextunique")]
	Nextunique,
	[EnumValue("prev")]
	Prev,
	[EnumValue("prevunique")]
	Prevunique,
}

[To(ToAttribute.None)]
public enum IDBTransactionMode
{
	[EnumValue("readonly")]
	Readonly,
	[EnumValue("readwrite")]
	Readwrite,
	[EnumValue("versionchange")]
	Versionchange,
}

[To(ToAttribute.None)]
public enum LoginStatus
{
	[EnumValue("logged-in")]
	LoggedIn,
	[EnumValue("logged-out")]
	LoggedOut,
}

[To(ToAttribute.None)]
public enum ScriptInvokerType
{
	[EnumValue("classic-script")]
	ClassicScript,
	[EnumValue("module-script")]
	ModuleScript,
	[EnumValue("event-listener")]
	EventListener,
	[EnumValue("user-callback")]
	UserCallback,
	[EnumValue("resolve-promise")]
	ResolvePromise,
	[EnumValue("reject-promise")]
	RejectPromise,
}

[To(ToAttribute.None)]
public enum ScriptWindowAttribution
{
	[EnumValue("self")]
	Self,
	[EnumValue("descendant")]
	Descendant,
	[EnumValue("ancestor")]
	Ancestor,
	[EnumValue("same-page")]
	SamePage,
	[EnumValue("other")]
	Other,
}

[To(ToAttribute.None)]
public enum MagnetometerLocalCoordinateSystem
{
	[EnumValue("device")]
	Device,
	[EnumValue("screen")]
	Screen,
}

[To(ToAttribute.None)]
public enum AppBannerPromptOutcome
{
	[EnumValue("accepted")]
	Accepted,
	[EnumValue("dismissed")]
	Dismissed,
}

[To(ToAttribute.None)]
public enum MediaDecodingType
{
	[EnumValue("file")]
	File,
	[EnumValue("media-source")]
	MediaSource,
	[EnumValue("webrtc")]
	Webrtc,
}

[To(ToAttribute.None)]
public enum MediaEncodingType
{
	[EnumValue("record")]
	Record,
	[EnumValue("webrtc")]
	Webrtc,
}

[To(ToAttribute.None)]
public enum HdrMetadataType
{
	[EnumValue("smpteSt2086")]
	SmpteSt2086,
	[EnumValue("smpteSt2094-10")]
	SmpteSt209410,
	[EnumValue("smpteSt2094-40")]
	SmpteSt209440,
}

[To(ToAttribute.None)]
public enum ColorGamut
{
	[EnumValue("srgb")]
	Srgb,
	[EnumValue("p3")]
	P3,
	[EnumValue("rec2020")]
	Rec2020,
}

[To(ToAttribute.None)]
public enum TransferFunction
{
	[EnumValue("srgb")]
	Srgb,
	[EnumValue("pq")]
	Pq,
	[EnumValue("hlg")]
	Hlg,
}

[To(ToAttribute.None)]
public enum ReadyState
{
	[EnumValue("closed")]
	Closed,
	[EnumValue("open")]
	Open,
	[EnumValue("ended")]
	Ended,
}

[To(ToAttribute.None)]
public enum EndOfStreamError
{
	[EnumValue("network")]
	Network,
	[EnumValue("decode")]
	Decode,
}

[To(ToAttribute.None)]
public enum AppendMode
{
	[EnumValue("segments")]
	Segments,
	[EnumValue("sequence")]
	Sequence,
}

[To(ToAttribute.None)]
public enum MockCapturePromptResult
{
	[EnumValue("granted")]
	Granted,
	[EnumValue("denied")]
	Denied,
}

[To(ToAttribute.None)]
public enum CaptureAction
{
	[EnumValue("next")]
	Next,
	[EnumValue("previous")]
	Previous,
	[EnumValue("first")]
	First,
	[EnumValue("last")]
	Last,
}

[To(ToAttribute.None)]
public enum MediaStreamTrackState
{
	[EnumValue("live")]
	Live,
	[EnumValue("ended")]
	Ended,
}

[To(ToAttribute.None)]
public enum VideoFacingModeEnum
{
	[EnumValue("user")]
	User,
	[EnumValue("environment")]
	Environment,
	[EnumValue("left")]
	Left,
	[EnumValue("right")]
	Right,
}

[To(ToAttribute.None)]
public enum VideoResizeModeEnum
{
	[EnumValue("none")]
	None,
	[EnumValue("crop-and-scale")]
	CropAndScale,
}

[To(ToAttribute.None)]
public enum MediaDeviceKind
{
	[EnumValue("audioinput")]
	Audioinput,
	[EnumValue("audiooutput")]
	Audiooutput,
	[EnumValue("videoinput")]
	Videoinput,
}

[To(ToAttribute.None)]
public enum MediaSessionPlaybackState
{
	[EnumValue("none")]
	None,
	[EnumValue("paused")]
	Paused,
	[EnumValue("playing")]
	Playing,
}

[To(ToAttribute.None)]
public enum MediaSessionAction
{
	[EnumValue("play")]
	Play,
	[EnumValue("pause")]
	Pause,
	[EnumValue("seekbackward")]
	Seekbackward,
	[EnumValue("seekforward")]
	Seekforward,
	[EnumValue("previoustrack")]
	Previoustrack,
	[EnumValue("nexttrack")]
	Nexttrack,
	[EnumValue("skipad")]
	Skipad,
	[EnumValue("stop")]
	Stop,
	[EnumValue("seekto")]
	Seekto,
	[EnumValue("togglemicrophone")]
	Togglemicrophone,
	[EnumValue("togglecamera")]
	Togglecamera,
	[EnumValue("togglescreenshare")]
	Togglescreenshare,
	[EnumValue("hangup")]
	Hangup,
	[EnumValue("previousslide")]
	Previousslide,
	[EnumValue("nextslide")]
	Nextslide,
	[EnumValue("enterpictureinpicture")]
	Enterpictureinpicture,
	[EnumValue("voiceactivity")]
	Voiceactivity,
}

[To(ToAttribute.None)]
public enum BitrateMode
{
	[EnumValue("constant")]
	Constant,
	[EnumValue("variable")]
	Variable,
}

[To(ToAttribute.None)]
public enum RecordingState
{
	[EnumValue("inactive")]
	Inactive,
	[EnumValue("recording")]
	Recording,
	[EnumValue("paused")]
	Paused,
}

[To(ToAttribute.None)]
public enum RTCDegradationPreference
{
	[EnumValue("maintain-framerate")]
	MaintainFramerate,
	[EnumValue("maintain-resolution")]
	MaintainResolution,
	[EnumValue("balanced")]
	Balanced,
}

[To(ToAttribute.None)]
public enum NavigationTimingType
{
	[EnumValue("navigate")]
	Navigate,
	[EnumValue("reload")]
	Reload,
	[EnumValue("back_forward")]
	Back_forward,
	[EnumValue("prerender")]
	Prerender,
}

[To(ToAttribute.None)]
public enum ConnectionType
{
	[EnumValue("bluetooth")]
	Bluetooth,
	[EnumValue("cellular")]
	Cellular,
	[EnumValue("ethernet")]
	Ethernet,
	[EnumValue("mixed")]
	Mixed,
	[EnumValue("none")]
	None,
	[EnumValue("other")]
	Other,
	[EnumValue("unknown")]
	Unknown,
	[EnumValue("wifi")]
	Wifi,
	[EnumValue("wimax")]
	Wimax,
}

[To(ToAttribute.None)]
public enum EffectiveConnectionType
{
	[EnumValue("2g")]
	_2g,
	[EnumValue("3g")]
	_3g,
	[EnumValue("4g")]
	_4g,
	[EnumValue("slow-2g")]
	Slow2g,
}

[To(ToAttribute.None)]
public enum NotificationPermission
{
	[EnumValue("default")]
	Default,
	[EnumValue("denied")]
	Denied,
	[EnumValue("granted")]
	Granted,
}

[To(ToAttribute.None)]
public enum NotificationDirection
{
	[EnumValue("auto")]
	Auto,
	[EnumValue("ltr")]
	Ltr,
	[EnumValue("rtl")]
	Rtl,
}

[To(ToAttribute.None)]
public enum OrientationSensorLocalCoordinateSystem
{
	[EnumValue("device")]
	Device,
	[EnumValue("screen")]
	Screen,
}

[To(ToAttribute.None)]
public enum ClientLifecycleState
{
	[EnumValue("active")]
	Active,
	[EnumValue("frozen")]
	Frozen,
}

[To(ToAttribute.None)]
public enum PaymentDelegation
{
	[EnumValue("shippingAddress")]
	ShippingAddress,
	[EnumValue("payerName")]
	PayerName,
	[EnumValue("payerPhone")]
	PayerPhone,
	[EnumValue("payerEmail")]
	PayerEmail,
}

[To(ToAttribute.None)]
public enum PaymentShippingType
{
	[EnumValue("shipping")]
	Shipping,
	[EnumValue("delivery")]
	Delivery,
	[EnumValue("pickup")]
	Pickup,
}

[To(ToAttribute.None)]
public enum PaymentComplete
{
	[EnumValue("fail")]
	Fail,
	[EnumValue("success")]
	Success,
	[EnumValue("unknown")]
	Unknown,
}

[To(ToAttribute.None)]
public enum PermissionState
{
	[EnumValue("granted")]
	Granted,
	[EnumValue("denied")]
	Denied,
	[EnumValue("prompt")]
	Prompt,
}

[To(ToAttribute.None)]
public enum PresentationConnectionState
{
	[EnumValue("connecting")]
	Connecting,
	[EnumValue("connected")]
	Connected,
	[EnumValue("closed")]
	Closed,
	[EnumValue("terminated")]
	Terminated,
}

[To(ToAttribute.None)]
public enum PresentationConnectionCloseReason
{
	[EnumValue("error")]
	Error,
	[EnumValue("closed")]
	Closed,
	[EnumValue("wentaway")]
	Wentaway,
}

[To(ToAttribute.None)]
public enum IPAddressSpace
{
	[EnumValue("public")]
	Public,
	[EnumValue("private")]
	Private,
	[EnumValue("local")]
	Local,
}

[To(ToAttribute.None)]
public enum PushEncryptionKeyName
{
	[EnumValue("p256dh")]
	P256dh,
	[EnumValue("auth")]
	Auth,
}

[To(ToAttribute.None)]
public enum ReferrerPolicy
{
	[EnumValue("")]
	Empty,
	[EnumValue("no-referrer")]
	NoReferrer,
	[EnumValue("no-referrer-when-downgrade")]
	NoReferrerWhenDowngrade,
	[EnumValue("same-origin")]
	SameOrigin,
	[EnumValue("origin")]
	Origin,
	[EnumValue("strict-origin")]
	StrictOrigin,
	[EnumValue("origin-when-cross-origin")]
	OriginWhenCrossOrigin,
	[EnumValue("strict-origin-when-cross-origin")]
	StrictOriginWhenCrossOrigin,
	[EnumValue("unsafe-url")]
	UnsafeUrl,
}

[To(ToAttribute.None)]
public enum RemotePlaybackState
{
	[EnumValue("connecting")]
	Connecting,
	[EnumValue("connected")]
	Connected,
	[EnumValue("disconnected")]
	Disconnected,
}

[To(ToAttribute.None)]
public enum ResizeObserverBoxOptions
{
	[EnumValue("border-box")]
	BorderBox,
	[EnumValue("content-box")]
	ContentBox,
	[EnumValue("device-pixel-content-box")]
	DevicePixelContentBox,
}

[To(ToAttribute.None)]
public enum RenderBlockingStatusType
{
	[EnumValue("blocking")]
	Blocking,
	[EnumValue("non-blocking")]
	NonBlocking,
}

[To(ToAttribute.None)]
public enum SameSiteCookiesType
{
	[EnumValue("all")]
	All,
	[EnumValue("none")]
	None,
}

[To(ToAttribute.None)]
public enum SanitizerPresets
{
	[EnumValue("default")]
	Default,
}

[To(ToAttribute.None)]
public enum TaskPriority
{
	[EnumValue("user-blocking")]
	UserBlocking,
	[EnumValue("user-visible")]
	UserVisible,
	[EnumValue("background")]
	Background,
}

[To(ToAttribute.None)]
public enum CaptureStartFocusBehavior
{
	[EnumValue("focus-capturing-application")]
	FocusCapturingApplication,
	[EnumValue("focus-captured-surface")]
	FocusCapturedSurface,
	[EnumValue("no-focus-change")]
	NoFocusChange,
}

[To(ToAttribute.None)]
public enum SelfCapturePreferenceEnum
{
	[EnumValue("include")]
	Include,
	[EnumValue("exclude")]
	Exclude,
}

[To(ToAttribute.None)]
public enum SystemAudioPreferenceEnum
{
	[EnumValue("include")]
	Include,
	[EnumValue("exclude")]
	Exclude,
}

[To(ToAttribute.None)]
public enum SurfaceSwitchingPreferenceEnum
{
	[EnumValue("include")]
	Include,
	[EnumValue("exclude")]
	Exclude,
}

[To(ToAttribute.None)]
public enum MonitorTypeSurfacesEnum
{
	[EnumValue("include")]
	Include,
	[EnumValue("exclude")]
	Exclude,
}

[To(ToAttribute.None)]
public enum DisplayCaptureSurfaceType
{
	[EnumValue("monitor")]
	Monitor,
	[EnumValue("window")]
	Window,
	[EnumValue("browser")]
	Browser,
}

[To(ToAttribute.None)]
public enum CursorCaptureConstraint
{
	[EnumValue("never")]
	Never,
	[EnumValue("always")]
	Always,
	[EnumValue("motion")]
	Motion,
}

[To(ToAttribute.None)]
public enum OrientationLockType
{
	[EnumValue("any")]
	Any,
	[EnumValue("natural")]
	Natural,
	[EnumValue("landscape")]
	Landscape,
	[EnumValue("portrait")]
	Portrait,
	[EnumValue("portrait-primary")]
	PortraitPrimary,
	[EnumValue("portrait-secondary")]
	PortraitSecondary,
	[EnumValue("landscape-primary")]
	LandscapePrimary,
	[EnumValue("landscape-secondary")]
	LandscapeSecondary,
}

[To(ToAttribute.None)]
public enum OrientationType
{
	[EnumValue("portrait-primary")]
	PortraitPrimary,
	[EnumValue("portrait-secondary")]
	PortraitSecondary,
	[EnumValue("landscape-primary")]
	LandscapePrimary,
	[EnumValue("landscape-secondary")]
	LandscapeSecondary,
}

[To(ToAttribute.None)]
public enum WakeLockType
{
	[EnumValue("screen")]
	Screen,
}

[To(ToAttribute.None)]
public enum ScrollAxis
{
	[EnumValue("block")]
	Block,
	[EnumValue("inline")]
	Inline,
	[EnumValue("x")]
	X,
	[EnumValue("y")]
	Y,
}

[To(ToAttribute.None)]
public enum ParityType
{
	[EnumValue("none")]
	None,
	[EnumValue("even")]
	Even,
	[EnumValue("odd")]
	Odd,
}

[To(ToAttribute.None)]
public enum FlowControlType
{
	[EnumValue("none")]
	None,
	[EnumValue("hardware")]
	Hardware,
}

[To(ToAttribute.None)]
public enum ServiceWorkerState
{
	[EnumValue("parsed")]
	Parsed,
	[EnumValue("installing")]
	Installing,
	[EnumValue("installed")]
	Installed,
	[EnumValue("activating")]
	Activating,
	[EnumValue("activated")]
	Activated,
	[EnumValue("redundant")]
	Redundant,
}

[To(ToAttribute.None)]
public enum ServiceWorkerUpdateViaCache
{
	[EnumValue("imports")]
	Imports,
	[EnumValue("all")]
	All,
	[EnumValue("none")]
	None,
}

[To(ToAttribute.None)]
public enum FrameType
{
	[EnumValue("auxiliary")]
	Auxiliary,
	[EnumValue("top-level")]
	TopLevel,
	[EnumValue("nested")]
	Nested,
	[EnumValue("none")]
	None,
}

[To(ToAttribute.None)]
public enum ClientType
{
	[EnumValue("window")]
	Window,
	[EnumValue("worker")]
	Worker,
	[EnumValue("sharedworker")]
	Sharedworker,
	[EnumValue("all")]
	All,
}

[To(ToAttribute.None)]
public enum RunningStatus
{
	[EnumValue("running")]
	Running,
	[EnumValue("not-running")]
	NotRunning,
}

[To(ToAttribute.None)]
public enum RouterSourceEnum
{
	[EnumValue("cache")]
	Cache,
	[EnumValue("fetch-event")]
	FetchEvent,
	[EnumValue("network")]
	Network,
	[EnumValue("race-network-and-fetch-handler")]
	RaceNetworkAndFetchHandler,
}

[To(ToAttribute.None)]
public enum LandmarkType
{
	[EnumValue("mouth")]
	Mouth,
	[EnumValue("eye")]
	Eye,
	[EnumValue("nose")]
	Nose,
}

[To(ToAttribute.None)]
public enum BarcodeFormat
{
	[EnumValue("aztec")]
	Aztec,
	[EnumValue("code_128")]
	Code_128,
	[EnumValue("code_39")]
	Code_39,
	[EnumValue("code_93")]
	Code_93,
	[EnumValue("codabar")]
	Codabar,
	[EnumValue("data_matrix")]
	Data_matrix,
	[EnumValue("ean_13")]
	Ean_13,
	[EnumValue("ean_8")]
	Ean_8,
	[EnumValue("itf")]
	Itf,
	[EnumValue("pdf417")]
	Pdf417,
	[EnumValue("qr_code")]
	Qr_code,
	[EnumValue("unknown")]
	Unknown,
	[EnumValue("upc_a")]
	Upc_a,
	[EnumValue("upc_e")]
	Upc_e,
}


[To(ToAttribute.None)]
public enum SpeechRecognitionErrorCode
{
	[EnumValue("no-speech")]
	NoSpeech,
	[EnumValue("aborted")]
	Aborted,
	[EnumValue("audio-capture")]
	AudioCapture,
	[EnumValue("network")]
	Network,
	[EnumValue("not-allowed")]
	NotAllowed,
	[EnumValue("service-not-allowed")]
	ServiceNotAllowed,
	[EnumValue("bad-grammar")]
	BadGrammar,
	[EnumValue("language-not-supported")]
	LanguageNotSupported,
}

[To(ToAttribute.None)]
public enum SpeechSynthesisErrorCode
{
	[EnumValue("canceled")]
	Canceled,
	[EnumValue("interrupted")]
	Interrupted,
	[EnumValue("audio-busy")]
	AudioBusy,
	[EnumValue("audio-hardware")]
	AudioHardware,
	[EnumValue("network")]
	Network,
	[EnumValue("synthesis-unavailable")]
	SynthesisUnavailable,
	[EnumValue("synthesis-failed")]
	SynthesisFailed,
	[EnumValue("language-unavailable")]
	LanguageUnavailable,
	[EnumValue("voice-unavailable")]
	VoiceUnavailable,
	[EnumValue("text-too-long")]
	TextTooLong,
	[EnumValue("invalid-argument")]
	InvalidArgument,
	[EnumValue("not-allowed")]
	NotAllowed,
}

[To(ToAttribute.None)]
public enum ReadableStreamReaderMode
{
	[EnumValue("byob")]
	Byob,
}

[To(ToAttribute.None)]
public enum ReadableStreamType
{
	[EnumValue("bytes")]
	Bytes,
}

[To(ToAttribute.None)]
public enum TouchType
{
	[EnumValue("direct")]
	Direct,
	[EnumValue("stylus")]
	Stylus,
}

[To(ToAttribute.None)]
public enum RefreshPolicy
{
	[EnumValue("none")]
	None,
	[EnumValue("refresh")]
	Refresh,
}

[To(ToAttribute.None)]
public enum TokenVersion
{
	[EnumValue("1")]
	_1,
}

[To(ToAttribute.None)]
public enum OperationType
{
	[EnumValue("token-request")]
	TokenRequest,
	[EnumValue("send-redemption-record")]
	SendRedemptionRecord,
	[EnumValue("token-redemption")]
	TokenRedemption,
}

[To(ToAttribute.None)]
public enum KAnonStatus
{
	[EnumValue("passedAndEnforced")]
	PassedAndEnforced,
	[EnumValue("passedNotEnforced")]
	PassedNotEnforced,
	[EnumValue("belowThreshold")]
	BelowThreshold,
	[EnumValue("notCalculated")]
	NotCalculated,
}

[To(ToAttribute.None)]
public enum ImportExportKind
{
	[EnumValue("function")]
	Function,
	[EnumValue("table")]
	Table,
	[EnumValue("memory")]
	Memory,
	[EnumValue("global")]
	Global,
}

[To(ToAttribute.None)]
public enum TableKind
{
	[EnumValue("externref")]
	Externref,
	[EnumValue("anyfunc")]
	Anyfunc,
}

[To(ToAttribute.None)]
public enum ValueType
{
	[EnumValue("i32")]
	I32,
	[EnumValue("i64")]
	I64,
	[EnumValue("f32")]
	F32,
	[EnumValue("f64")]
	F64,
	[EnumValue("v128")]
	V128,
	[EnumValue("externref")]
	Externref,
	[EnumValue("anyfunc")]
	Anyfunc,
}

[To(ToAttribute.None)]
public enum IterationCompositeOperation
{
	[EnumValue("replace")]
	Replace,
	[EnumValue("accumulate")]
	Accumulate,
}

[To(ToAttribute.None)]
public enum AnimationPlayState
{
	[EnumValue("idle")]
	Idle,
	[EnumValue("running")]
	Running,
	[EnumValue("paused")]
	Paused,
	[EnumValue("finished")]
	Finished,
}

[To(ToAttribute.None)]
public enum AnimationReplaceState
{
	[EnumValue("active")]
	Active,
	[EnumValue("removed")]
	Removed,
	[EnumValue("persisted")]
	Persisted,
}

[To(ToAttribute.None)]
public enum FillMode
{
	[EnumValue("none")]
	None,
	[EnumValue("forwards")]
	Forwards,
	[EnumValue("backwards")]
	Backwards,
	[EnumValue("both")]
	Both,
	[EnumValue("auto")]
	Auto,
}

[To(ToAttribute.None)]
public enum PlaybackDirection
{
	[EnumValue("normal")]
	Normal,
	[EnumValue("reverse")]
	Reverse,
	[EnumValue("alternate")]
	Alternate,
	[EnumValue("alternate-reverse")]
	AlternateReverse,
}

[To(ToAttribute.None)]
public enum CompositeOperation
{
	[EnumValue("replace")]
	Replace,
	[EnumValue("add")]
	Add,
	[EnumValue("accumulate")]
	Accumulate,
}

[To(ToAttribute.None)]
public enum CompositeOperationOrAuto
{
	[EnumValue("replace")]
	Replace,
	[EnumValue("add")]
	Add,
	[EnumValue("accumulate")]
	Accumulate,
	[EnumValue("auto")]
	Auto,
}

[To(ToAttribute.None)]
public enum LockMode
{
	[EnumValue("shared")]
	Shared,
	[EnumValue("exclusive")]
	Exclusive,
}

[To(ToAttribute.None)]
public enum OTPCredentialTransportType
{
	[EnumValue("sms")]
	Sms,
}

[To(ToAttribute.None)]
public enum AudioContextState
{
	[EnumValue("suspended")]
	Suspended,
	[EnumValue("running")]
	Running,
	[EnumValue("closed")]
	Closed,
}

[To(ToAttribute.None)]
public enum AudioContextRenderSizeCategory
{
	[EnumValue("default")]
	Default,
	[EnumValue("hardware")]
	Hardware,
}

[To(ToAttribute.None)]
public enum AudioContextLatencyCategory
{
	[EnumValue("balanced")]
	Balanced,
	[EnumValue("interactive")]
	Interactive,
	[EnumValue("playback")]
	Playback,
}

[To(ToAttribute.None)]
public enum AudioSinkType
{
	[EnumValue("none")]
	None,
}

[To(ToAttribute.None)]
public enum ChannelCountMode
{
	[EnumValue("max")]
	Max,
	[EnumValue("clamped-max")]
	ClampedMax,
	[EnumValue("explicit")]
	Explicit,
}

[To(ToAttribute.None)]
public enum ChannelInterpretation
{
	[EnumValue("speakers")]
	Speakers,
	[EnumValue("discrete")]
	Discrete,
}

[To(ToAttribute.None)]
public enum AutomationRate
{
	[EnumValue("a-rate")]
	ARate,
	[EnumValue("k-rate")]
	KRate,
}

[To(ToAttribute.None)]
public enum BiquadFilterType
{
	[EnumValue("lowpass")]
	Lowpass,
	[EnumValue("highpass")]
	Highpass,
	[EnumValue("bandpass")]
	Bandpass,
	[EnumValue("lowshelf")]
	Lowshelf,
	[EnumValue("highshelf")]
	Highshelf,
	[EnumValue("peaking")]
	Peaking,
	[EnumValue("notch")]
	Notch,
	[EnumValue("allpass")]
	Allpass,
}

[To(ToAttribute.None)]
public enum OscillatorType
{
	[EnumValue("sine")]
	Sine,
	[EnumValue("square")]
	Square,
	[EnumValue("sawtooth")]
	Sawtooth,
	[EnumValue("triangle")]
	Triangle,
	[EnumValue("custom")]
	Custom,
}

[To(ToAttribute.None)]
public enum PanningModelType
{
	[EnumValue("equalpower")]
	Equalpower,
	[EnumValue("HRTF")]
	HRTF,
}

[To(ToAttribute.None)]
public enum DistanceModelType
{
	[EnumValue("linear")]
	Linear,
	[EnumValue("inverse")]
	Inverse,
	[EnumValue("exponential")]
	Exponential,
}

[To(ToAttribute.None)]
public enum OverSampleType
{
	[EnumValue("none")]
	None,
	[EnumValue("2x")]
	_2x,
	[EnumValue("4x")]
	_4x,
}

[To(ToAttribute.None)]
public enum AuthenticatorAttachment
{
	[EnumValue("platform")]
	Platform,
	[EnumValue("cross-platform")]
	CrossPlatform,
}

[To(ToAttribute.None)]
public enum ResidentKeyRequirement
{
	[EnumValue("discouraged")]
	Discouraged,
	[EnumValue("preferred")]
	Preferred,
	[EnumValue("required")]
	Required,
}

[To(ToAttribute.None)]
public enum AttestationConveyancePreference
{
	[EnumValue("none")]
	None,
	[EnumValue("indirect")]
	Indirect,
	[EnumValue("direct")]
	Direct,
	[EnumValue("enterprise")]
	Enterprise,
}

[To(ToAttribute.None)]
public enum TokenBindingStatus
{
	[EnumValue("present")]
	Present,
	[EnumValue("supported")]
	Supported,
}

[To(ToAttribute.None)]
public enum PublicKeyCredentialType
{
	[EnumValue("public-key")]
	PublicKey,
}

[To(ToAttribute.None)]
public enum AuthenticatorTransport
{
	[EnumValue("usb")]
	Usb,
	[EnumValue("nfc")]
	Nfc,
	[EnumValue("ble")]
	Ble,
	[EnumValue("smart-card")]
	SmartCard,
	[EnumValue("hybrid")]
	Hybrid,
	[EnumValue("internal")]
	Internal,
}


[To(ToAttribute.None)]
public enum UserVerificationRequirement
{
	[EnumValue("required")]
	Required,
	[EnumValue("preferred")]
	Preferred,
	[EnumValue("discouraged")]
	Discouraged,
}

[To(ToAttribute.None)]
public enum ClientCapability
{
	[EnumValue("conditionalCreate")]
	ConditionalCreate,
	[EnumValue("conditionalGet")]
	ConditionalGet,
	[EnumValue("hybridTransport")]
	HybridTransport,
	[EnumValue("passkeyPlatformAuthenticator")]
	PasskeyPlatformAuthenticator,
	[EnumValue("userVerifyingPlatformAuthenticator")]
	UserVerifyingPlatformAuthenticator,
	[EnumValue("relatedOrigins")]
	RelatedOrigins,
	[EnumValue("signalAllAcceptedCredentials")]
	SignalAllAcceptedCredentials,
	[EnumValue("signalCurrentUserDetails")]
	SignalCurrentUserDetails,
	[EnumValue("signalUnknownCredential")]
	SignalUnknownCredential,
}

[To(ToAttribute.None)]
public enum PublicKeyCredentialHint
{
	[EnumValue("security-key")]
	SecurityKey,
	[EnumValue("client-device")]
	ClientDevice,
	[EnumValue("hybrid")]
	Hybrid,
}

[To(ToAttribute.None)]
public enum LargeBlobSupport
{
	[EnumValue("required")]
	Required,
	[EnumValue("preferred")]
	Preferred,
}

[To(ToAttribute.None)]
public enum AacBitstreamFormat
{
	[EnumValue("aac")]
	Aac,
	[EnumValue("adts")]
	Adts,
}

[To(ToAttribute.None)]
public enum AvcBitstreamFormat
{
	[EnumValue("annexb")]
	Annexb,
	[EnumValue("avc")]
	Avc,
}

[To(ToAttribute.None)]
public enum HevcBitstreamFormat
{
	[EnumValue("annexb")]
	Annexb,
	[EnumValue("hevc")]
	Hevc,
}

[To(ToAttribute.None)]
public enum OpusBitstreamFormat
{
	[EnumValue("opus")]
	Opus,
	[EnumValue("ogg")]
	Ogg,
}

[To(ToAttribute.None)]
public enum OpusSignal
{
	[EnumValue("auto")]
	Auto,
	[EnumValue("music")]
	Music,
	[EnumValue("voice")]
	Voice,
}

[To(ToAttribute.None)]
public enum OpusApplication
{
	[EnumValue("voip")]
	Voip,
	[EnumValue("audio")]
	Audio,
	[EnumValue("lowdelay")]
	Lowdelay,
}

[To(ToAttribute.None)]
public enum HardwareAcceleration
{
	[EnumValue("no-preference")]
	NoPreference,
	[EnumValue("prefer-hardware")]
	PreferHardware,
	[EnumValue("prefer-software")]
	PreferSoftware,
}

[To(ToAttribute.None)]
public enum AlphaOption
{
	[EnumValue("keep")]
	Keep,
	[EnumValue("discard")]
	Discard,
}

[To(ToAttribute.None)]
public enum LatencyMode
{
	[EnumValue("quality")]
	Quality,
	[EnumValue("realtime")]
	Realtime,
}

[To(ToAttribute.None)]
public enum VideoEncoderBitrateMode
{
	[EnumValue("constant")]
	Constant,
	[EnumValue("variable")]
	Variable,
	[EnumValue("quantizer")]
	Quantizer,
}

[To(ToAttribute.None)]
public enum CodecState
{
	[EnumValue("unconfigured")]
	Unconfigured,
	[EnumValue("configured")]
	Configured,
	[EnumValue("closed")]
	Closed,
}

[To(ToAttribute.None)]
public enum EncodedAudioChunkType
{
	[EnumValue("key")]
	Key,
	[EnumValue("delta")]
	Delta,
}

[To(ToAttribute.None)]
public enum EncodedVideoChunkType
{
	[EnumValue("key")]
	Key,
	[EnumValue("delta")]
	Delta,
}

[To(ToAttribute.None)]
public enum AudioSampleFormat
{
	[EnumValue("u8")]
	U8,
	[EnumValue("s16")]
	S16,
	[EnumValue("s32")]
	S32,
	[EnumValue("f32")]
	F32,
	[EnumValue("u8-planar")]
	U8Planar,
	[EnumValue("s16-planar")]
	S16Planar,
	[EnumValue("s32-planar")]
	S32Planar,
	[EnumValue("f32-planar")]
	F32Planar,
}

[To(ToAttribute.None)]
public enum VideoPixelFormat
{
	[EnumValue("I420")]
	I420,
	[EnumValue("I420P10")]
	I420P10,
	[EnumValue("I420P12")]
	I420P12,
	[EnumValue("I420A")]
	I420A,
	[EnumValue("I420AP10")]
	I420AP10,
	[EnumValue("I420AP12")]
	I420AP12,
	[EnumValue("I422")]
	I422,
	[EnumValue("I422P10")]
	I422P10,
	[EnumValue("I422P12")]
	I422P12,
	[EnumValue("I422A")]
	I422A,
	[EnumValue("I422AP10")]
	I422AP10,
	[EnumValue("I422AP12")]
	I422AP12,
	[EnumValue("I444")]
	I444,
	[EnumValue("I444P10")]
	I444P10,
	[EnumValue("I444P12")]
	I444P12,
	[EnumValue("I444A")]
	I444A,
	[EnumValue("I444AP10")]
	I444AP10,
	[EnumValue("I444AP12")]
	I444AP12,
	[EnumValue("NV12")]
	NV12,
	[EnumValue("RGBA")]
	RGBA,
	[EnumValue("RGBX")]
	RGBX,
	[EnumValue("BGRA")]
	BGRA,
	[EnumValue("BGRX")]
	BGRX,
}

[To(ToAttribute.None)]
public enum VideoColorPrimaries
{
	[EnumValue("bt709")]
	Bt709,
	[EnumValue("bt470bg")]
	Bt470bg,
	[EnumValue("smpte170m")]
	Smpte170m,
	[EnumValue("bt2020")]
	Bt2020,
	[EnumValue("smpte432")]
	Smpte432,
}

[To(ToAttribute.None)]
public enum VideoTransferCharacteristics
{
	[EnumValue("bt709")]
	Bt709,
	[EnumValue("smpte170m")]
	Smpte170m,
	[EnumValue("iec61966-2-1")]
	Iec6196621,
	[EnumValue("linear")]
	Linear,
	[EnumValue("pq")]
	Pq,
	[EnumValue("hlg")]
	Hlg,
}

[To(ToAttribute.None)]
public enum VideoMatrixCoefficients
{
	[EnumValue("rgb")]
	Rgb,
	[EnumValue("bt709")]
	Bt709,
	[EnumValue("bt470bg")]
	Bt470bg,
	[EnumValue("smpte170m")]
	Smpte170m,
	[EnumValue("bt2020-ncl")]
	Bt2020Ncl,
}

[To(ToAttribute.None)]
public enum KeyType
{
	[EnumValue("public")]
	Public,
	[EnumValue("private")]
	Private,
	[EnumValue("secret")]
	Secret,
}

[To(ToAttribute.None)]
public enum KeyUsage
{
	[EnumValue("encrypt")]
	Encrypt,
	[EnumValue("decrypt")]
	Decrypt,
	[EnumValue("sign")]
	Sign,
	[EnumValue("verify")]
	Verify,
	[EnumValue("deriveKey")]
	DeriveKey,
	[EnumValue("deriveBits")]
	DeriveBits,
	[EnumValue("wrapKey")]
	WrapKey,
	[EnumValue("unwrapKey")]
	UnwrapKey,
}

[To(ToAttribute.None)]
public enum KeyFormat
{
	[EnumValue("raw")]
	Raw,
	[EnumValue("spki")]
	Spki,
	[EnumValue("pkcs8")]
	Pkcs8,
	[EnumValue("jwk")]
	Jwk,
}

[To(ToAttribute.None)]
public enum WebGLPowerPreference
{
	[EnumValue("default")]
	Default,
	[EnumValue("low-power")]
	LowPower,
	[EnumValue("high-performance")]
	HighPerformance,
}

[To(ToAttribute.None)]
public enum GPUPowerPreference
{
	[EnumValue("low-power")]
	LowPower,
	[EnumValue("high-performance")]
	HighPerformance,
}

[To(ToAttribute.None)]
public enum GPUFeatureName
{
	[EnumValue("depth-clip-control")]
	DepthClipControl,
	[EnumValue("depth32float-stencil8")]
	Depth32floatStencil8,
	[EnumValue("texture-compression-bc")]
	TextureCompressionBc,
	[EnumValue("texture-compression-bc-sliced-3d")]
	TextureCompressionBcSliced3d,
	[EnumValue("texture-compression-etc2")]
	TextureCompressionEtc2,
	[EnumValue("texture-compression-astc")]
	TextureCompressionAstc,
	[EnumValue("texture-compression-astc-sliced-3d")]
	TextureCompressionAstcSliced3d,
	[EnumValue("timestamp-query")]
	TimestampQuery,
	[EnumValue("indirect-first-instance")]
	IndirectFirstInstance,
	[EnumValue("shader-f16")]
	ShaderF16,
	[EnumValue("rg11b10ufloat-renderable")]
	Rg11b10ufloatRenderable,
	[EnumValue("bgra8unorm-storage")]
	Bgra8unormStorage,
	[EnumValue("float32-filterable")]
	Float32Filterable,
	[EnumValue("float32-blendable")]
	Float32Blendable,
	[EnumValue("clip-distances")]
	ClipDistances,
	[EnumValue("dual-source-blending")]
	DualSourceBlending,
}

[To(ToAttribute.None)]
public enum GPUBufferMapState
{
	[EnumValue("unmapped")]
	Unmapped,
	[EnumValue("pending")]
	Pending,
	[EnumValue("mapped")]
	Mapped,
}

[To(ToAttribute.None)]
public enum GPUTextureDimension
{
	[EnumValue("1d")]
	_1d,
	[EnumValue("2d")]
	_2d,
	[EnumValue("3d")]
	_3d,
}


[To(ToAttribute.None)]
public enum GPUTextureViewDimension
{
	[EnumValue("1d")]
	_1d,
	[EnumValue("2d")]
	_2d,
	[EnumValue("2d-array")]
	_2dArray,
	[EnumValue("cube")]
	Cube,
	[EnumValue("cube-array")]
	CubeArray,
	[EnumValue("3d")]
	_3d,
}

[To(ToAttribute.None)]
public enum GPUTextureAspect
{
	[EnumValue("all")]
	All,
	[EnumValue("stencil-only")]
	StencilOnly,
	[EnumValue("depth-only")]
	DepthOnly,
}

[To(ToAttribute.None)]
public enum GPUTextureFormat
{
	[EnumValue("r8unorm")]
	R8unorm,
	[EnumValue("r8snorm")]
	R8snorm,
	[EnumValue("r8uint")]
	R8uint,
	[EnumValue("r8sint")]
	R8sint,
	[EnumValue("r16uint")]
	R16uint,
	[EnumValue("r16sint")]
	R16sint,
	[EnumValue("r16float")]
	R16float,
	[EnumValue("rg8unorm")]
	Rg8unorm,
	[EnumValue("rg8snorm")]
	Rg8snorm,
	[EnumValue("rg8uint")]
	Rg8uint,
	[EnumValue("rg8sint")]
	Rg8sint,
	[EnumValue("r32uint")]
	R32uint,
	[EnumValue("r32sint")]
	R32sint,
	[EnumValue("r32float")]
	R32float,
	[EnumValue("rg16uint")]
	Rg16uint,
	[EnumValue("rg16sint")]
	Rg16sint,
	[EnumValue("rg16float")]
	Rg16float,
	[EnumValue("rgba8unorm")]
	Rgba8unorm,
	[EnumValue("rgba8unorm-srgb")]
	Rgba8unormSrgb,
	[EnumValue("rgba8snorm")]
	Rgba8snorm,
	[EnumValue("rgba8uint")]
	Rgba8uint,
	[EnumValue("rgba8sint")]
	Rgba8sint,
	[EnumValue("bgra8unorm")]
	Bgra8unorm,
	[EnumValue("bgra8unorm-srgb")]
	Bgra8unormSrgb,
	[EnumValue("rgb9e5ufloat")]
	Rgb9e5ufloat,
	[EnumValue("rgb10a2uint")]
	Rgb10a2uint,
	[EnumValue("rgb10a2unorm")]
	Rgb10a2unorm,
	[EnumValue("rg11b10ufloat")]
	Rg11b10ufloat,
	[EnumValue("rg32uint")]
	Rg32uint,
	[EnumValue("rg32sint")]
	Rg32sint,
	[EnumValue("rg32float")]
	Rg32float,
	[EnumValue("rgba16uint")]
	Rgba16uint,
	[EnumValue("rgba16sint")]
	Rgba16sint,
	[EnumValue("rgba16float")]
	Rgba16float,
	[EnumValue("rgba32uint")]
	Rgba32uint,
	[EnumValue("rgba32sint")]
	Rgba32sint,
	[EnumValue("rgba32float")]
	Rgba32float,
	[EnumValue("stencil8")]
	Stencil8,
	[EnumValue("depth16unorm")]
	Depth16unorm,
	[EnumValue("depth24plus")]
	Depth24plus,
	[EnumValue("depth24plus-stencil8")]
	Depth24plusStencil8,
	[EnumValue("depth32float")]
	Depth32float,
	[EnumValue("depth32float-stencil8")]
	Depth32floatStencil8,
	[EnumValue("bc1-rgba-unorm")]
	Bc1RgbaUnorm,
	[EnumValue("bc1-rgba-unorm-srgb")]
	Bc1RgbaUnormSrgb,
	[EnumValue("bc2-rgba-unorm")]
	Bc2RgbaUnorm,
	[EnumValue("bc2-rgba-unorm-srgb")]
	Bc2RgbaUnormSrgb,
	[EnumValue("bc3-rgba-unorm")]
	Bc3RgbaUnorm,
	[EnumValue("bc3-rgba-unorm-srgb")]
	Bc3RgbaUnormSrgb,
	[EnumValue("bc4-r-unorm")]
	Bc4RUnorm,
	[EnumValue("bc4-r-snorm")]
	Bc4RSnorm,
	[EnumValue("bc5-rg-unorm")]
	Bc5RgUnorm,
	[EnumValue("bc5-rg-snorm")]
	Bc5RgSnorm,
	[EnumValue("bc6h-rgb-ufloat")]
	Bc6hRgbUfloat,
	[EnumValue("bc6h-rgb-float")]
	Bc6hRgbFloat,
	[EnumValue("bc7-rgba-unorm")]
	Bc7RgbaUnorm,
	[EnumValue("bc7-rgba-unorm-srgb")]
	Bc7RgbaUnormSrgb,
	[EnumValue("etc2-rgb8unorm")]
	Etc2Rgb8unorm,
	[EnumValue("etc2-rgb8unorm-srgb")]
	Etc2Rgb8unormSrgb,
	[EnumValue("etc2-rgb8a1unorm")]
	Etc2Rgb8a1unorm,
	[EnumValue("etc2-rgb8a1unorm-srgb")]
	Etc2Rgb8a1unormSrgb,
	[EnumValue("etc2-rgba8unorm")]
	Etc2Rgba8unorm,
	[EnumValue("etc2-rgba8unorm-srgb")]
	Etc2Rgba8unormSrgb,
	[EnumValue("eac-r11unorm")]
	EacR11unorm,
	[EnumValue("eac-r11snorm")]
	EacR11snorm,
	[EnumValue("eac-rg11unorm")]
	EacRg11unorm,
	[EnumValue("eac-rg11snorm")]
	EacRg11snorm,
	[EnumValue("astc-4x4-unorm")]
	Astc4x4Unorm,
	[EnumValue("astc-4x4-unorm-srgb")]
	Astc4x4UnormSrgb,
	[EnumValue("astc-5x4-unorm")]
	Astc5x4Unorm,
	[EnumValue("astc-5x4-unorm-srgb")]
	Astc5x4UnormSrgb,
	[EnumValue("astc-5x5-unorm")]
	Astc5x5Unorm,
	[EnumValue("astc-5x5-unorm-srgb")]
	Astc5x5UnormSrgb,
	[EnumValue("astc-6x5-unorm")]
	Astc6x5Unorm,
	[EnumValue("astc-6x5-unorm-srgb")]
	Astc6x5UnormSrgb,
	[EnumValue("astc-6x6-unorm")]
	Astc6x6Unorm,
	[EnumValue("astc-6x6-unorm-srgb")]
	Astc6x6UnormSrgb,
	[EnumValue("astc-8x5-unorm")]
	Astc8x5Unorm,
	[EnumValue("astc-8x5-unorm-srgb")]
	Astc8x5UnormSrgb,
	[EnumValue("astc-8x6-unorm")]
	Astc8x6Unorm,
	[EnumValue("astc-8x6-unorm-srgb")]
	Astc8x6UnormSrgb,
	[EnumValue("astc-8x8-unorm")]
	Astc8x8Unorm,
	[EnumValue("astc-8x8-unorm-srgb")]
	Astc8x8UnormSrgb,
	[EnumValue("astc-10x5-unorm")]
	Astc10x5Unorm,
	[EnumValue("astc-10x5-unorm-srgb")]
	Astc10x5UnormSrgb,
	[EnumValue("astc-10x6-unorm")]
	Astc10x6Unorm,
	[EnumValue("astc-10x6-unorm-srgb")]
	Astc10x6UnormSrgb,
	[EnumValue("astc-10x8-unorm")]
	Astc10x8Unorm,
	[EnumValue("astc-10x8-unorm-srgb")]
	Astc10x8UnormSrgb,
	[EnumValue("astc-10x10-unorm")]
	Astc10x10Unorm,
	[EnumValue("astc-10x10-unorm-srgb")]
	Astc10x10UnormSrgb,
	[EnumValue("astc-12x10-unorm")]
	Astc12x10Unorm,
	[EnumValue("astc-12x10-unorm-srgb")]
	Astc12x10UnormSrgb,
	[EnumValue("astc-12x12-unorm")]
	Astc12x12Unorm,
	[EnumValue("astc-12x12-unorm-srgb")]
	Astc12x12UnormSrgb,
}

[To(ToAttribute.None)]
public enum GPUAddressMode
{
	[EnumValue("clamp-to-edge")]
	ClampToEdge,
	[EnumValue("repeat")]
	Repeat,
	[EnumValue("mirror-repeat")]
	MirrorRepeat,
}

[To(ToAttribute.None)]
public enum GPUFilterMode
{
	[EnumValue("nearest")]
	Nearest,
	[EnumValue("linear")]
	Linear,
}

[To(ToAttribute.None)]
public enum GPUMipmapFilterMode
{
	[EnumValue("nearest")]
	Nearest,
	[EnumValue("linear")]
	Linear,
}

[To(ToAttribute.None)]
public enum GPUCompareFunction
{
	[EnumValue("never")]
	Never,
	[EnumValue("less")]
	Less,
	[EnumValue("equal")]
	Equal,
	[EnumValue("less-equal")]
	LessEqual,
	[EnumValue("greater")]
	Greater,
	[EnumValue("not-equal")]
	NotEqual,
	[EnumValue("greater-equal")]
	GreaterEqual,
	[EnumValue("always")]
	Always,
}

[To(ToAttribute.None)]
public enum GPUBufferBindingType
{
	[EnumValue("uniform")]
	Uniform,
	[EnumValue("storage")]
	Storage,
	[EnumValue("read-only-storage")]
	ReadOnlyStorage,
}

[To(ToAttribute.None)]
public enum GPUSamplerBindingType
{
	[EnumValue("filtering")]
	Filtering,
	[EnumValue("non-filtering")]
	NonFiltering,
	[EnumValue("comparison")]
	Comparison,
}

[To(ToAttribute.None)]
public enum GPUTextureSampleType
{
	[EnumValue("float")]
	Float,
	[EnumValue("unfilterable-float")]
	UnfilterableFloat,
	[EnumValue("depth")]
	Depth,
	[EnumValue("sint")]
	Sint,
	[EnumValue("uint")]
	Uint,
}

[To(ToAttribute.None)]
public enum GPUStorageTextureAccess
{
	[EnumValue("write-only")]
	WriteOnly,
	[EnumValue("read-only")]
	ReadOnly,
	[EnumValue("read-write")]
	ReadWrite,
}

[To(ToAttribute.None)]
public enum GPUCompilationMessageType
{
	[EnumValue("error")]
	Error,
	[EnumValue("warning")]
	Warning,
	[EnumValue("info")]
	Info,
}

[To(ToAttribute.None)]
public enum GPUPipelineErrorReason
{
	[EnumValue("validation")]
	Validation,
	[EnumValue("internal")]
	Internal,
}

[To(ToAttribute.None)]
public enum GPUAutoLayoutMode
{
	[EnumValue("auto")]
	Auto,
}

[To(ToAttribute.None)]
public enum GPUPrimitiveTopology
{
	[EnumValue("point-list")]
	PointList,
	[EnumValue("line-list")]
	LineList,
	[EnumValue("line-strip")]
	LineStrip,
	[EnumValue("triangle-list")]
	TriangleList,
	[EnumValue("triangle-strip")]
	TriangleStrip,
}

[To(ToAttribute.None)]
public enum GPUFrontFace
{
	[EnumValue("ccw")]
	Ccw,
	[EnumValue("cw")]
	Cw,
}

[To(ToAttribute.None)]
public enum GPUCullMode
{
	[EnumValue("none")]
	None,
	[EnumValue("front")]
	Front,
	[EnumValue("back")]
	Back,
}

[To(ToAttribute.None)]
public enum GPUBlendFactor
{
	[EnumValue("zero")]
	Zero,
	[EnumValue("one")]
	One,
	[EnumValue("src")]
	Src,
	[EnumValue("one-minus-src")]
	OneMinusSrc,
	[EnumValue("src-alpha")]
	SrcAlpha,
	[EnumValue("one-minus-src-alpha")]
	OneMinusSrcAlpha,
	[EnumValue("dst")]
	Dst,
	[EnumValue("one-minus-dst")]
	OneMinusDst,
	[EnumValue("dst-alpha")]
	DstAlpha,
	[EnumValue("one-minus-dst-alpha")]
	OneMinusDstAlpha,
	[EnumValue("src-alpha-saturated")]
	SrcAlphaSaturated,
	[EnumValue("constant")]
	Constant,
	[EnumValue("one-minus-constant")]
	OneMinusConstant,
	[EnumValue("src1")]
	Src1,
	[EnumValue("one-minus-src1")]
	OneMinusSrc1,
	[EnumValue("src1-alpha")]
	Src1Alpha,
	[EnumValue("one-minus-src1-alpha")]
	OneMinusSrc1Alpha,
}

[To(ToAttribute.None)]
public enum GPUBlendOperation
{
	[EnumValue("add")]
	Add,
	[EnumValue("subtract")]
	Subtract,
	[EnumValue("reverse-subtract")]
	ReverseSubtract,
	[EnumValue("min")]
	Min,
	[EnumValue("max")]
	Max,
}

[To(ToAttribute.None)]
public enum GPUStencilOperation
{
	[EnumValue("keep")]
	Keep,
	[EnumValue("zero")]
	Zero,
	[EnumValue("replace")]
	Replace,
	[EnumValue("invert")]
	Invert,
	[EnumValue("increment-clamp")]
	IncrementClamp,
	[EnumValue("decrement-clamp")]
	DecrementClamp,
	[EnumValue("increment-wrap")]
	IncrementWrap,
	[EnumValue("decrement-wrap")]
	DecrementWrap,
}

[To(ToAttribute.None)]
public enum GPUIndexFormat
{
	[EnumValue("uint16")]
	Uint16,
	[EnumValue("uint32")]
	Uint32,
}

[To(ToAttribute.None)]
public enum GPUVertexFormat
{
	[EnumValue("uint8")]
	Uint8,
	[EnumValue("uint8x2")]
	Uint8x2,
	[EnumValue("uint8x4")]
	Uint8x4,
	[EnumValue("sint8")]
	Sint8,
	[EnumValue("sint8x2")]
	Sint8x2,
	[EnumValue("sint8x4")]
	Sint8x4,
	[EnumValue("unorm8")]
	Unorm8,
	[EnumValue("unorm8x2")]
	Unorm8x2,
	[EnumValue("unorm8x4")]
	Unorm8x4,
	[EnumValue("snorm8")]
	Snorm8,
	[EnumValue("snorm8x2")]
	Snorm8x2,
	[EnumValue("snorm8x4")]
	Snorm8x4,
	[EnumValue("uint16")]
	Uint16,
	[EnumValue("uint16x2")]
	Uint16x2,
	[EnumValue("uint16x4")]
	Uint16x4,
	[EnumValue("sint16")]
	Sint16,
	[EnumValue("sint16x2")]
	Sint16x2,
	[EnumValue("sint16x4")]
	Sint16x4,
	[EnumValue("unorm16")]
	Unorm16,
	[EnumValue("unorm16x2")]
	Unorm16x2,
	[EnumValue("unorm16x4")]
	Unorm16x4,
	[EnumValue("snorm16")]
	Snorm16,
	[EnumValue("snorm16x2")]
	Snorm16x2,
	[EnumValue("snorm16x4")]
	Snorm16x4,
	[EnumValue("float16")]
	Float16,
	[EnumValue("float16x2")]
	Float16x2,
	[EnumValue("float16x4")]
	Float16x4,
	[EnumValue("float32")]
	Float32,
	[EnumValue("float32x2")]
	Float32x2,
	[EnumValue("float32x3")]
	Float32x3,
	[EnumValue("float32x4")]
	Float32x4,
	[EnumValue("uint32")]
	Uint32,
	[EnumValue("uint32x2")]
	Uint32x2,
	[EnumValue("uint32x3")]
	Uint32x3,
	[EnumValue("uint32x4")]
	Uint32x4,
	[EnumValue("sint32")]
	Sint32,
	[EnumValue("sint32x2")]
	Sint32x2,
	[EnumValue("sint32x3")]
	Sint32x3,
	[EnumValue("sint32x4")]
	Sint32x4,
	[EnumValue("unorm10-10-10-2")]
	Unorm1010102,
	[EnumValue("unorm8x4-bgra")]
	Unorm8x4Bgra,
}

[To(ToAttribute.None)]
public enum GPUVertexStepMode
{
	[EnumValue("vertex")]
	Vertex,
	[EnumValue("instance")]
	Instance,
}

[To(ToAttribute.None)]
public enum GPULoadOp
{
	[EnumValue("load")]
	Load,
	[EnumValue("clear")]
	Clear,
}

[To(ToAttribute.None)]
public enum GPUStoreOp
{
	[EnumValue("store")]
	Store,
	[EnumValue("discard")]
	Discard,
}

[To(ToAttribute.None)]
public enum GPUQueryType
{
	[EnumValue("occlusion")]
	Occlusion,
	[EnumValue("timestamp")]
	Timestamp,
}

[To(ToAttribute.None)]
public enum GPUCanvasAlphaMode
{
	[EnumValue("opaque")]
	Opaque,
	[EnumValue("premultiplied")]
	Premultiplied,
}

[To(ToAttribute.None)]
public enum GPUCanvasToneMappingMode
{
	[EnumValue("standard")]
	Standard,
	[EnumValue("extended")]
	Extended,
}

[To(ToAttribute.None)]
public enum GPUDeviceLostReason
{
	[EnumValue("unknown")]
	Unknown,
	[EnumValue("destroyed")]
	Destroyed,
}

[To(ToAttribute.None)]
public enum GPUErrorFilter
{
	[EnumValue("validation")]
	Validation,
	[EnumValue("out-of-memory")]
	OutOfMemory,
	[EnumValue("internal")]
	Internal,
}

[To(ToAttribute.None)]
public enum HIDUnitSystem
{
	[EnumValue("none")]
	None,
	[EnumValue("si-linear")]
	SiLinear,
	[EnumValue("si-rotation")]
	SiRotation,
	[EnumValue("english-linear")]
	EnglishLinear,
	[EnumValue("english-rotation")]
	EnglishRotation,
	[EnumValue("vendor-defined")]
	VendorDefined,
	[EnumValue("reserved")]
	Reserved,
}




[To(ToAttribute.None)]
public enum MIDIPortType
{
	[EnumValue("input")]
	Input,
	[EnumValue("output")]
	Output,
}

[To(ToAttribute.None)]
public enum MIDIPortDeviceState
{
	[EnumValue("disconnected")]
	Disconnected,
	[EnumValue("connected")]
	Connected,
}

[To(ToAttribute.None)]
public enum MIDIPortConnectionState
{
	[EnumValue("open")]
	Open,
	[EnumValue("closed")]
	Closed,
	[EnumValue("pending")]
	Pending,
}

[To(ToAttribute.None)]
public enum MLDeviceType
{
	[EnumValue("cpu")]
	Cpu,
	[EnumValue("gpu")]
	Gpu,
	[EnumValue("npu")]
	Npu,
}

[To(ToAttribute.None)]
public enum MLPowerPreference
{
	[EnumValue("default")]
	Default,
	[EnumValue("high-performance")]
	HighPerformance,
	[EnumValue("low-power")]
	LowPower,
}

[To(ToAttribute.None)]
public enum MLInputOperandLayout
{
	[EnumValue("nchw")]
	Nchw,
	[EnumValue("nhwc")]
	Nhwc,
}

[To(ToAttribute.None)]
public enum MLOperandDataType
{
	[EnumValue("float32")]
	Float32,
	[EnumValue("float16")]
	Float16,
	[EnumValue("int32")]
	Int32,
	[EnumValue("uint32")]
	Uint32,
	[EnumValue("int64")]
	Int64,
	[EnumValue("uint64")]
	Uint64,
	[EnumValue("int8")]
	Int8,
	[EnumValue("uint8")]
	Uint8,
}

[To(ToAttribute.None)]
public enum MLConv2dFilterOperandLayout
{
	[EnumValue("oihw")]
	Oihw,
	[EnumValue("hwio")]
	Hwio,
	[EnumValue("ohwi")]
	Ohwi,
	[EnumValue("ihwo")]
	Ihwo,
}

[To(ToAttribute.None)]
public enum MLConvTranspose2dFilterOperandLayout
{
	[EnumValue("iohw")]
	Iohw,
	[EnumValue("hwoi")]
	Hwoi,
	[EnumValue("ohwi")]
	Ohwi,
}

[To(ToAttribute.None)]
public enum MLGruWeightLayout
{
	[EnumValue("zrn")]
	Zrn,
	[EnumValue("rzn")]
	Rzn,
}

[To(ToAttribute.None)]
public enum MLRecurrentNetworkActivation
{
	[EnumValue("relu")]
	Relu,
	[EnumValue("sigmoid")]
	Sigmoid,
	[EnumValue("tanh")]
	Tanh,
}

[To(ToAttribute.None)]
public enum MLRecurrentNetworkDirection
{
	[EnumValue("forward")]
	Forward,
	[EnumValue("backward")]
	Backward,
	[EnumValue("both")]
	Both,
}

[To(ToAttribute.None)]
public enum MLLstmWeightLayout
{
	[EnumValue("iofg")]
	Iofg,
	[EnumValue("ifgo")]
	Ifgo,
}

[To(ToAttribute.None)]
public enum MLPaddingMode
{
	[EnumValue("constant")]
	Constant,
	[EnumValue("edge")]
	Edge,
	[EnumValue("reflection")]
	Reflection,
	[EnumValue("symmetric")]
	Symmetric,
}

[To(ToAttribute.None)]
public enum MLRoundingType
{
	[EnumValue("floor")]
	Floor,
	[EnumValue("ceil")]
	Ceil,
}

[To(ToAttribute.None)]
public enum MLInterpolationMode
{
	[EnumValue("nearest-neighbor")]
	NearestNeighbor,
	[EnumValue("linear")]
	Linear,
}

[To(ToAttribute.None)]
public enum SFrameTransformRole
{
	[EnumValue("encrypt")]
	Encrypt,
	[EnumValue("decrypt")]
	Decrypt,
}

[To(ToAttribute.None)]
public enum SFrameTransformErrorEventType
{
	[EnumValue("authentication")]
	Authentication,
	[EnumValue("keyID")]
	KeyID,
	[EnumValue("syntax")]
	Syntax,
}

[To(ToAttribute.None)]
public enum RTCEncodedVideoFrameType
{
	[EnumValue("empty")]
	Empty,
	[EnumValue("key")]
	Key,
	[EnumValue("delta")]
	Delta,
}

[To(ToAttribute.None)]
public enum RTCErrorDetailTypeIdp
{
	[EnumValue("idp-bad-script-failure")]
	IdpBadScriptFailure,
	[EnumValue("idp-execution-failure")]
	IdpExecutionFailure,
	[EnumValue("idp-load-failure")]
	IdpLoadFailure,
	[EnumValue("idp-need-login")]
	IdpNeedLogin,
	[EnumValue("idp-timeout")]
	IdpTimeout,
	[EnumValue("idp-tls-failure")]
	IdpTlsFailure,
	[EnumValue("idp-token-expired")]
	IdpTokenExpired,
	[EnumValue("idp-token-invalid")]
	IdpTokenInvalid,
}

[To(ToAttribute.None)]
public enum RTCPriorityType
{
	[EnumValue("very-low")]
	VeryLow,
	[EnumValue("low")]
	Low,
	[EnumValue("medium")]
	Medium,
	[EnumValue("high")]
	High,
}

[To(ToAttribute.None)]
public enum RTCStatsType
{
	[EnumValue("codec")]
	Codec,
	[EnumValue("inbound-rtp")]
	InboundRtp,
	[EnumValue("outbound-rtp")]
	OutboundRtp,
	[EnumValue("remote-inbound-rtp")]
	RemoteInboundRtp,
	[EnumValue("remote-outbound-rtp")]
	RemoteOutboundRtp,
	[EnumValue("media-source")]
	MediaSource,
	[EnumValue("media-playout")]
	MediaPlayout,
	[EnumValue("peer-connection")]
	PeerConnection,
	[EnumValue("data-channel")]
	DataChannel,
	[EnumValue("transport")]
	Transport,
	[EnumValue("candidate-pair")]
	CandidatePair,
	[EnumValue("local-candidate")]
	LocalCandidate,
	[EnumValue("remote-candidate")]
	RemoteCandidate,
	[EnumValue("certificate")]
	Certificate,
}

[To(ToAttribute.None)]
public enum RTCQualityLimitationReason
{
	[EnumValue("none")]
	None,
	[EnumValue("cpu")]
	Cpu,
	[EnumValue("bandwidth")]
	Bandwidth,
	[EnumValue("other")]
	Other,
}

[To(ToAttribute.None)]
public enum RTCDtlsRole
{
	[EnumValue("client")]
	Client,
	[EnumValue("server")]
	Server,
	[EnumValue("unknown")]
	Unknown,
}

[To(ToAttribute.None)]
public enum RTCStatsIceCandidatePairState
{
	[EnumValue("frozen")]
	Frozen,
	[EnumValue("waiting")]
	Waiting,
	[EnumValue("in-progress")]
	InProgress,
	[EnumValue("failed")]
	Failed,
	[EnumValue("succeeded")]
	Succeeded,
}

[To(ToAttribute.None)]
public enum RTCIceTransportPolicy
{
	[EnumValue("relay")]
	Relay,
	[EnumValue("all")]
	All,
}

[To(ToAttribute.None)]
public enum RTCBundlePolicy
{
	[EnumValue("balanced")]
	Balanced,
	[EnumValue("max-compat")]
	MaxCompat,
	[EnumValue("max-bundle")]
	MaxBundle,
}

[To(ToAttribute.None)]
public enum RTCRtcpMuxPolicy
{
	[EnumValue("require")]
	Require,
}

[To(ToAttribute.None)]
public enum RTCSignalingState
{
	[EnumValue("stable")]
	Stable,
	[EnumValue("have-local-offer")]
	HaveLocalOffer,
	[EnumValue("have-remote-offer")]
	HaveRemoteOffer,
	[EnumValue("have-local-pranswer")]
	HaveLocalPranswer,
	[EnumValue("have-remote-pranswer")]
	HaveRemotePranswer,
	[EnumValue("closed")]
	Closed,
}

[To(ToAttribute.None)]
public enum RTCIceGatheringState
{
	[EnumValue("new")]
	New,
	[EnumValue("gathering")]
	Gathering,
	[EnumValue("complete")]
	Complete,
}

[To(ToAttribute.None)]
public enum RTCPeerConnectionState
{
	[EnumValue("closed")]
	Closed,
	[EnumValue("failed")]
	Failed,
	[EnumValue("disconnected")]
	Disconnected,
	[EnumValue("new")]
	New,
	[EnumValue("connecting")]
	Connecting,
	[EnumValue("connected")]
	Connected,
}

[To(ToAttribute.None)]
public enum RTCIceConnectionState
{
	[EnumValue("closed")]
	Closed,
	[EnumValue("failed")]
	Failed,
	[EnumValue("disconnected")]
	Disconnected,
	[EnumValue("new")]
	New,
	[EnumValue("checking")]
	Checking,
	[EnumValue("completed")]
	Completed,
	[EnumValue("connected")]
	Connected,
}

[To(ToAttribute.None)]
public enum RTCSdpType
{
	[EnumValue("offer")]
	Offer,
	[EnumValue("pranswer")]
	Pranswer,
	[EnumValue("answer")]
	Answer,
	[EnumValue("rollback")]
	Rollback,
}

[To(ToAttribute.None)]
public enum RTCIceProtocol
{
	[EnumValue("udp")]
	Udp,
	[EnumValue("tcp")]
	Tcp,
}

[To(ToAttribute.None)]
public enum RTCIceTcpCandidateType
{
	[EnumValue("active")]
	Active,
	[EnumValue("passive")]
	Passive,
	[EnumValue("so")]
	So,
}

[To(ToAttribute.None)]
public enum RTCIceCandidateType
{
	[EnumValue("host")]
	Host,
	[EnumValue("srflx")]
	Srflx,
	[EnumValue("prflx")]
	Prflx,
	[EnumValue("relay")]
	Relay,
}

[To(ToAttribute.None)]
public enum RTCIceServerTransportProtocol
{
	[EnumValue("udp")]
	Udp,
	[EnumValue("tcp")]
	Tcp,
	[EnumValue("tls")]
	Tls,
}

[To(ToAttribute.None)]
public enum RTCRtpTransceiverDirection
{
	[EnumValue("sendrecv")]
	Sendrecv,
	[EnumValue("sendonly")]
	Sendonly,
	[EnumValue("recvonly")]
	Recvonly,
	[EnumValue("inactive")]
	Inactive,
	[EnumValue("stopped")]
	Stopped,
}

[To(ToAttribute.None)]
public enum RTCDtlsTransportState
{
	[EnumValue("new")]
	New,
	[EnumValue("connecting")]
	Connecting,
	[EnumValue("connected")]
	Connected,
	[EnumValue("closed")]
	Closed,
	[EnumValue("failed")]
	Failed,
}

[To(ToAttribute.None)]
public enum RTCIceGathererState
{
	[EnumValue("new")]
	New,
	[EnumValue("gathering")]
	Gathering,
	[EnumValue("complete")]
	Complete,
}

[To(ToAttribute.None)]
public enum RTCIceTransportState
{
	[EnumValue("closed")]
	Closed,
	[EnumValue("failed")]
	Failed,
	[EnumValue("disconnected")]
	Disconnected,
	[EnumValue("new")]
	New,
	[EnumValue("checking")]
	Checking,
	[EnumValue("completed")]
	Completed,
	[EnumValue("connected")]
	Connected,
}

[To(ToAttribute.None)]
public enum RTCIceRole
{
	[EnumValue("unknown")]
	Unknown,
	[EnumValue("controlling")]
	Controlling,
	[EnumValue("controlled")]
	Controlled,
}

[To(ToAttribute.None)]
public enum RTCIceComponent
{
	[EnumValue("rtp")]
	Rtp,
	[EnumValue("rtcp")]
	Rtcp,
}

[To(ToAttribute.None)]
public enum RTCSctpTransportState
{
	[EnumValue("connecting")]
	Connecting,
	[EnumValue("connected")]
	Connected,
	[EnumValue("closed")]
	Closed,
}

[To(ToAttribute.None)]
public enum RTCDataChannelState
{
	[EnumValue("connecting")]
	Connecting,
	[EnumValue("open")]
	Open,
	[EnumValue("closing")]
	Closing,
	[EnumValue("closed")]
	Closed,
}

[To(ToAttribute.None)]
public enum RTCErrorDetailType
{
	[EnumValue("data-channel-failure")]
	DataChannelFailure,
	[EnumValue("dtls-failure")]
	DtlsFailure,
	[EnumValue("fingerprint-failure")]
	FingerprintFailure,
	[EnumValue("sctp-failure")]
	SctpFailure,
	[EnumValue("sdp-syntax-error")]
	SdpSyntaxError,
	[EnumValue("hardware-encoder-not-available")]
	HardwareEncoderNotAvailable,
	[EnumValue("hardware-encoder-error")]
	HardwareEncoderError,
}

[To(ToAttribute.None)]
public enum BinaryType
{
	[EnumValue("blob")]
	Blob,
	[EnumValue("arraybuffer")]
	Arraybuffer,
}

[To(ToAttribute.None)]
public enum WebTransportReliabilityMode
{
	[EnumValue("pending")]
	Pending,
	[EnumValue("reliable-only")]
	ReliableOnly,
	[EnumValue("supports-unreliable")]
	SupportsUnreliable,
}

[To(ToAttribute.None)]
public enum WebTransportCongestionControl
{
	[EnumValue("default")]
	Default,
	[EnumValue("throughput")]
	Throughput,
	[EnumValue("low-latency")]
	LowLatency,
}

[To(ToAttribute.None)]
public enum WebTransportErrorSource
{
	[EnumValue("stream")]
	Stream,
	[EnumValue("session")]
	Session,
}

[To(ToAttribute.None)]
public enum USBTransferStatus
{
	[EnumValue("ok")]
	Ok,
	[EnumValue("stall")]
	Stall,
	[EnumValue("babble")]
	Babble,
}

[To(ToAttribute.None)]
public enum USBRequestType
{
	[EnumValue("standard")]
	Standard,
	[EnumValue("class")]
	Class,
	[EnumValue("vendor")]
	Vendor,
}

[To(ToAttribute.None)]
public enum USBRecipient
{
	[EnumValue("device")]
	Device,
	[EnumValue("interface")]
	Interface,
	[EnumValue("endpoint")]
	Endpoint,
	[EnumValue("other")]
	Other,
}

[To(ToAttribute.None)]
public enum USBDirection
{
	[EnumValue("in")]
	In,
	[EnumValue("out")]
	Out,
}

[To(ToAttribute.None)]
public enum USBEndpointType
{
	[EnumValue("bulk")]
	Bulk,
	[EnumValue("interrupt")]
	Interrupt,
	[EnumValue("isochronous")]
	Isochronous,
}

[To(ToAttribute.None)]
public enum AutoKeyword
{
	[EnumValue("auto")]
	Auto,
}


[To(ToAttribute.None)]
public enum DirectionSetting
{
	[EnumValue("")]
	Empty,
	[EnumValue("rl")]
	Rl,
	[EnumValue("lr")]
	Lr,
}

[To(ToAttribute.None)]
public enum LineAlignSetting
{
	[EnumValue("start")]
	Start,
	[EnumValue("center")]
	Center,
	[EnumValue("end")]
	End,
}

[To(ToAttribute.None)]
public enum PositionAlignSetting
{
	[EnumValue("line-left")]
	LineLeft,
	[EnumValue("center")]
	Center,
	[EnumValue("line-right")]
	LineRight,
	[EnumValue("auto")]
	Auto,
}

[To(ToAttribute.None)]
public enum AlignSetting
{
	[EnumValue("start")]
	Start,
	[EnumValue("center")]
	Center,
	[EnumValue("end")]
	End,
	[EnumValue("left")]
	Left,
	[EnumValue("right")]
	Right,
}

[To(ToAttribute.None)]
public enum ScrollSetting
{
	[EnumValue("")]
	Empty,
	[EnumValue("up")]
	Up,
}

[To(ToAttribute.None)]
public enum XREnvironmentBlendMode
{
	[EnumValue("opaque")]
	Opaque,
	[EnumValue("alpha-blend")]
	AlphaBlend,
	[EnumValue("additive")]
	Additive,
}

[To(ToAttribute.None)]
public enum XRInteractionMode
{
	[EnumValue("screen-space")]
	ScreenSpace,
	[EnumValue("world-space")]
	WorldSpace,
}

[To(ToAttribute.None)]
public enum XRDepthUsage
{
	[EnumValue("cpu-optimized")]
	CpuOptimized,
	[EnumValue("gpu-optimized")]
	GpuOptimized,
}

[To(ToAttribute.None)]
public enum XRDepthDataFormat
{
	[EnumValue("luminance-alpha")]
	LuminanceAlpha,
	[EnumValue("float32")]
	Float32,
	[EnumValue("unsigned-short")]
	UnsignedShort,
}

[To(ToAttribute.None)]
public enum XRDOMOverlayType
{
	[EnumValue("screen")]
	Screen,
	[EnumValue("floating")]
	Floating,
	[EnumValue("head-locked")]
	HeadLocked,
}

[To(ToAttribute.None)]
public enum XRHandJoint
{
	[EnumValue("wrist")]
	Wrist,
	[EnumValue("thumb-metacarpal")]
	ThumbMetacarpal,
	[EnumValue("thumb-phalanx-proximal")]
	ThumbPhalanxProximal,
	[EnumValue("thumb-phalanx-distal")]
	ThumbPhalanxDistal,
	[EnumValue("thumb-tip")]
	ThumbTip,
	[EnumValue("index-finger-metacarpal")]
	IndexFingerMetacarpal,
	[EnumValue("index-finger-phalanx-proximal")]
	IndexFingerPhalanxProximal,
	[EnumValue("index-finger-phalanx-intermediate")]
	IndexFingerPhalanxIntermediate,
	[EnumValue("index-finger-phalanx-distal")]
	IndexFingerPhalanxDistal,
	[EnumValue("index-finger-tip")]
	IndexFingerTip,
	[EnumValue("middle-finger-metacarpal")]
	MiddleFingerMetacarpal,
	[EnumValue("middle-finger-phalanx-proximal")]
	MiddleFingerPhalanxProximal,
	[EnumValue("middle-finger-phalanx-intermediate")]
	MiddleFingerPhalanxIntermediate,
	[EnumValue("middle-finger-phalanx-distal")]
	MiddleFingerPhalanxDistal,
	[EnumValue("middle-finger-tip")]
	MiddleFingerTip,
	[EnumValue("ring-finger-metacarpal")]
	RingFingerMetacarpal,
	[EnumValue("ring-finger-phalanx-proximal")]
	RingFingerPhalanxProximal,
	[EnumValue("ring-finger-phalanx-intermediate")]
	RingFingerPhalanxIntermediate,
	[EnumValue("ring-finger-phalanx-distal")]
	RingFingerPhalanxDistal,
	[EnumValue("ring-finger-tip")]
	RingFingerTip,
	[EnumValue("pinky-finger-metacarpal")]
	PinkyFingerMetacarpal,
	[EnumValue("pinky-finger-phalanx-proximal")]
	PinkyFingerPhalanxProximal,
	[EnumValue("pinky-finger-phalanx-intermediate")]
	PinkyFingerPhalanxIntermediate,
	[EnumValue("pinky-finger-phalanx-distal")]
	PinkyFingerPhalanxDistal,
	[EnumValue("pinky-finger-tip")]
	PinkyFingerTip,
}

[To(ToAttribute.None)]
public enum XRHitTestTrackableType
{
	[EnumValue("point")]
	Point,
	[EnumValue("plane")]
	Plane,
	[EnumValue("mesh")]
	Mesh,
}

[To(ToAttribute.None)]
public enum XRReflectionFormat
{
	[EnumValue("srgba8")]
	Srgba8,
	[EnumValue("rgba16f")]
	Rgba16f,
}

[To(ToAttribute.None)]
public enum XRPlaneOrientation
{
	[EnumValue("horizontal")]
	Horizontal,
	[EnumValue("vertical")]
	Vertical,
}

[To(ToAttribute.None)]
public enum XRSessionMode
{
	[EnumValue("inline")]
	Inline,
	[EnumValue("immersive-vr")]
	ImmersiveVr,
	[EnumValue("immersive-ar")]
	ImmersiveAr,
}

[To(ToAttribute.None)]
public enum XRVisibilityState
{
	[EnumValue("visible")]
	Visible,
	[EnumValue("visible-blurred")]
	VisibleBlurred,
	[EnumValue("hidden")]
	Hidden,
}

[To(ToAttribute.None)]
public enum XRReferenceSpaceType
{
	[EnumValue("viewer")]
	Viewer,
	[EnumValue("local")]
	Local,
	[EnumValue("local-floor")]
	LocalFloor,
	[EnumValue("bounded-floor")]
	BoundedFloor,
	[EnumValue("unbounded")]
	Unbounded,
}

[To(ToAttribute.None)]
public enum XREye
{
	[EnumValue("none")]
	None,
	[EnumValue("left")]
	Left,
	[EnumValue("right")]
	Right,
}

[To(ToAttribute.None)]
public enum XRHandedness
{
	[EnumValue("none")]
	None,
	[EnumValue("left")]
	Left,
	[EnumValue("right")]
	Right,
}

[To(ToAttribute.None)]
public enum XRTargetRayMode
{
	[EnumValue("gaze")]
	Gaze,
	[EnumValue("tracked-pointer")]
	TrackedPointer,
	[EnumValue("screen")]
	Screen,
	[EnumValue("transient-pointer")]
	TransientPointer,
}

[To(ToAttribute.None)]
public enum XRLayerLayout
{
	[EnumValue("default")]
	Default,
	[EnumValue("mono")]
	Mono,
	[EnumValue("stereo")]
	Stereo,
	[EnumValue("stereo-left-right")]
	StereoLeftRight,
	[EnumValue("stereo-top-bottom")]
	StereoTopBottom,
}

[To(ToAttribute.None)]
public enum XRLayerQuality
{
	[EnumValue("default")]
	Default,
	[EnumValue("text-optimized")]
	TextOptimized,
	[EnumValue("graphics-optimized")]
	GraphicsOptimized,
}

[To(ToAttribute.None)]
public enum XRTextureType
{
	[EnumValue("texture")]
	Texture,
	[EnumValue("texture-array")]
	TextureArray,
}

[To(ToAttribute.None)]
public enum XMLHttpRequestResponseType
{
	[EnumValue("")]
	Empty,
	[EnumValue("arraybuffer")]
	Arraybuffer,
	[EnumValue("blob")]
	Blob,
	[EnumValue("document")]
	Document,
	[EnumValue("json")]
	Json,
	[EnumValue("text")]
	Text,
}

