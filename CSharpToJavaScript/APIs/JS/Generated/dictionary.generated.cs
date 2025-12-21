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


[ToObject]
public partial class AccelerometerSensorOptions : SensorOptions
{
	[Value("referenceFrame")]
	public AccelerometerLocalCoordinateSystem ReferenceFrame;
}

[ToObject]
public partial class AttributionReportingRequestOptions
{
	[Value("eventSourceEligible")]
	public required bool EventSourceEligible;
	[Value("triggerEligible")]
	public required bool TriggerEligible;
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInit/*'/>
[ToObject]
public partial class RequestInit
{
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitAttributionReporting/*'/>
[Value("attributionReporting")]
	public AttributionReportingRequestOptions AttributionReporting;
}

[ToObject]
public partial class AudioOutputOptions
{
	[Value("deviceId")]
	public DOMString DeviceId;
}

[ToObject]
public partial class BackgroundFetchUIOptions
{
	[Value("icons")]
	public List<ImageResource> Icons;
	[Value("title")]
	public DOMString Title;
}

[ToObject]
public partial class BackgroundFetchOptions : BackgroundFetchUIOptions
{
	[Value("downloadTotal")]
	public ulong DownloadTotal;
}

[ToObject]
public partial class BackgroundFetchEventInit : ExtendableEventInit
{
	[Value("registration")]
	public required BackgroundFetchRegistration Registration;
}

[ToObject]
public partial class SyncEventInit : ExtendableEventInit
{
	[Value("tag")]
	public required DOMString Tag;
	[Value("lastChance")]
	public bool LastChance;
}

[ToObject]
public partial class CaptureHandleConfig
{
	[Value("exposeOrigin")]
	public bool ExposeOrigin;
	[Value("handle")]
	public DOMString Handle;
	[Value("permittedOrigins")]
	public List<DOMString> PermittedOrigins;
}

[ToObject]
public partial class CaptureHandle
{
	[Value("origin")]
	public DOMString Origin;
	[Value("handle")]
	public DOMString Handle;
}

[ToObject]
public partial class CapturedMouseEventInit : EventInit
{
	[Value("surfaceX")]
	public long SurfaceX;
	[Value("surfaceY")]
	public long SurfaceY;
}

[ToObject]
public partial class ClipboardEventInit : EventInit
{
	[Value("clipboardData")]
	public DataTransfer? ClipboardData;
}

[ToObject]
public partial class ClipboardItemOptions
{
	[Value("presentationStyle")]
	public PresentationStyle PresentationStyle;
}


[ToObject]
public partial class ClipboardUnsanitizedFormats
{
	[Value("unsanitized")]
	public List<DOMString> Unsanitized;
}

[ToObject]
public partial class ClipboardPermissionDescriptor : PermissionDescriptor
{
	[Value("allowWithoutGesture")]
	public bool AllowWithoutGesture;
}

[ToObject]
public partial class PressureObserverOptions
{
	[Value("sampleInterval")]
	public ulong SampleInterval;
}

[ToObject]
public partial class ContactInfo
{
	[Value("address")]
	public List<ContactAddress> Address;
	[Value("email")]
	public List<DOMString> Email;
	[Value("icon")]
	public List<Blob> Icon;
	[Value("name")]
	public List<DOMString> Name;
	[Value("tel")]
	public List<DOMString> Tel;
}

[ToObject]
public partial class ContactsSelectOptions
{
	[Value("multiple")]
	public bool Multiple;
}

[ToObject]
public partial class ContentDescription
{
	[Value("id")]
	public required DOMString Id;
	[Value("title")]
	public required DOMString Title;
	[Value("description")]
	public required DOMString Description;
	[Value("category")]
	public ContentCategory Category;
	[Value("icons")]
	public List<ImageResource> Icons;
	[Value("url")]
	public required USVString Url;
}

[ToObject]
public partial class ContentIndexEventInit : ExtendableEventInit
{
	[Value("id")]
	public required DOMString Id;
}

[ToObject]
public partial class CookieStoreGetOptions
{
	[Value("name")]
	public USVString Name;
	[Value("url")]
	public USVString Url;
}

[ToObject]
public partial class CookieInit
{
	[Value("name")]
	public required USVString Name;
	[Value("value")]
	public required USVString Value;
	[Value("expires")]
	public DOMHighResTimeStamp? Expires;
	[Value("domain")]
	public USVString? Domain;
	[Value("path")]
	public USVString Path;
	[Value("sameSite")]
	public CookieSameSite SameSite;
	[Value("partitioned")]
	public bool Partitioned;
}

[ToObject]
public partial class CookieStoreDeleteOptions
{
	[Value("name")]
	public required USVString Name;
	[Value("domain")]
	public USVString? Domain;
	[Value("path")]
	public USVString Path;
	[Value("partitioned")]
	public bool Partitioned;
}

[ToObject]
public partial class CookieListItem
{
	[Value("name")]
	public USVString Name;
	[Value("value")]
	public USVString Value;
	[Value("domain")]
	public USVString? Domain;
	[Value("path")]
	public USVString Path;
	[Value("expires")]
	public DOMHighResTimeStamp? Expires;
	[Value("secure")]
	public bool Secure;
	[Value("sameSite")]
	public CookieSameSite SameSite;
	[Value("partitioned")]
	public bool Partitioned;
}


[ToObject]
public partial class CookieChangeEventInit : EventInit
{
	[Value("changed")]
	public CookieList Changed;
	[Value("deleted")]
	public CookieList Deleted;
}

[ToObject]
public partial class ExtendableCookieChangeEventInit : ExtendableEventInit
{
	[Value("changed")]
	public CookieList Changed;
	[Value("deleted")]
	public CookieList Deleted;
}

[ToObject]
public partial class CredentialData
{
	[Value("id")]
	public required USVString Id;
}

[ToObject]
public partial class CredentialRequestOptions
{
	[Value("mediation")]
	public CredentialMediationRequirement Mediation;
	[Value("signal")]
	public AbortSignal Signal;
}

[ToObject]
public partial class CredentialCreationOptions
{
	[Value("mediation")]
	public CredentialMediationRequirement Mediation;
	[Value("signal")]
	public AbortSignal Signal;
}

public partial class CredentialRequestOptions
{
	[Value("password")]
	public bool Password;
}

[ToObject]
public partial class PasswordCredentialData : CredentialData
{
	[Value("name")]
	public USVString Name;
	[Value("iconURL")]
	public USVString IconURL;
	[Value("origin")]
	public required USVString Origin;
	[Value("password")]
	public required USVString Password;
}


public partial class CredentialCreationOptions
{
	[Value("password")]
	public PasswordCredentialInit Password;
}

[ToObject]
public partial class FederatedCredentialRequestOptions
{
	[Value("providers")]
	public List<USVString> Providers;
	[Value("protocols")]
	public List<DOMString> Protocols;
}

public partial class CredentialRequestOptions
{
	[Value("federated")]
	public FederatedCredentialRequestOptions Federated;
}

///<include file='CSharpToJavaScript/Utils/Docs/federatedcredentialinit/federatedcredentialinit.generated.xml' path='docs/FederatedCredentialInit/*'/>
[ToObject]
public partial class FederatedCredentialInit : CredentialData
{
	///<include file='CSharpToJavaScript/Utils/Docs/federatedcredentialinit/federatedcredentialinit.generated.xml' path='docs/FederatedCredentialInitName/*'/>
[Value("name")]
	public USVString Name;
	///<include file='CSharpToJavaScript/Utils/Docs/federatedcredentialinit/federatedcredentialinit.generated.xml' path='docs/FederatedCredentialInitIconURL/*'/>
[Value("iconURL")]
	public USVString IconURL;
	///<include file='CSharpToJavaScript/Utils/Docs/federatedcredentialinit/federatedcredentialinit.generated.xml' path='docs/FederatedCredentialInitOrigin/*'/>
[Value("origin")]
	public required USVString Origin;
	///<include file='CSharpToJavaScript/Utils/Docs/federatedcredentialinit/federatedcredentialinit.generated.xml' path='docs/FederatedCredentialInitProvider/*'/>
[Value("provider")]
	public required USVString Provider;
	///<include file='CSharpToJavaScript/Utils/Docs/federatedcredentialinit/federatedcredentialinit.generated.xml' path='docs/FederatedCredentialInitProtocol/*'/>
[Value("protocol")]
	public DOMString Protocol;
}

public partial class CredentialCreationOptions
{
	[Value("federated")]
	public FederatedCredentialInit Federated;
}

[ToObject]
public partial class SecurityPolicyViolationEventInit : EventInit
{
	[Value("documentURI")]
	public USVString DocumentURI;
	[Value("referrer")]
	public USVString Referrer;
	[Value("blockedURI")]
	public USVString BlockedURI;
	[Value("violatedDirective")]
	public DOMString ViolatedDirective;
	[Value("effectiveDirective")]
	public DOMString EffectiveDirective;
	[Value("originalPolicy")]
	public DOMString OriginalPolicy;
	[Value("sourceFile")]
	public USVString SourceFile;
	[Value("sample")]
	public DOMString Sample;
	[Value("disposition")]
	public SecurityPolicyViolationEventDisposition Disposition;
	[Value("statusCode")]
	public ushort StatusCode;
	[Value("lineNumber")]
	public ulong LineNumber;
	[Value("columnNumber")]
	public ulong ColumnNumber;
}

[ToObject]
public partial class AnimationEventInit : EventInit
{
	[Value("animationName")]
	public CSSOMString AnimationName;
	[Value("elapsedTime")]
	public Number ElapsedTime;
	[Value("pseudoElement")]
	public CSSOMString PseudoElement;
}

[ToObject]
public partial class ContentVisibilityAutoStateChangeEventInit : EventInit
{
	[Value("skipped")]
	public bool Skipped;
}

[ToObject]
public partial class FontFaceDescriptors
{
	[Value("style")]
	public CSSOMString Style;
	[Value("weight")]
	public CSSOMString Weight;
	[Value("stretch")]
	public CSSOMString Stretch;
	[Value("unicodeRange")]
	public CSSOMString UnicodeRange;
	[Value("featureSettings")]
	public CSSOMString FeatureSettings;
	[Value("variationSettings")]
	public CSSOMString VariationSettings;
	[Value("display")]
	public CSSOMString Display;
	[Value("ascentOverride")]
	public CSSOMString AscentOverride;
	[Value("descentOverride")]
	public CSSOMString DescentOverride;
	[Value("lineGapOverride")]
	public CSSOMString LineGapOverride;
}

[ToObject]
public partial class FontFaceSetLoadEventInit : EventInit
{
	[Value("fontfaces")]
	public List<FontFace> Fontfaces;
}

[ToObject]
public partial class LayoutOptions
{
	[Value("childDisplay")]
	public ChildDisplayType ChildDisplay;
	[Value("sizing")]
	public LayoutSizingMode Sizing;
}

[ToObject]
public partial class LayoutConstraintsOptions
{
	[Value("availableInlineSize")]
	public Number AvailableInlineSize;
	[Value("availableBlockSize")]
	public Number AvailableBlockSize;
	[Value("fixedInlineSize")]
	public Number FixedInlineSize;
	[Value("fixedBlockSize")]
	public Number FixedBlockSize;
	[Value("percentageInlineSize")]
	public Number PercentageInlineSize;
	[Value("percentageBlockSize")]
	public Number PercentageBlockSize;
	[Value("blockFragmentationOffset")]
	public Number BlockFragmentationOffset;
	[Value("blockFragmentationType")]
	public BlockFragmentationType BlockFragmentationType;
	[Value("data")]
	public dynamic Data;
}

[ToObject]
public partial class BreakTokenOptions
{
	[Value("childBreakTokens")]
	public List<ChildBreakToken> ChildBreakTokens;
	[Value("data")]
	public dynamic Data;
}

[ToObject]
public partial class FragmentResultOptions
{
	[Value("inlineSize")]
	public Number InlineSize;
	[Value("blockSize")]
	public Number BlockSize;
	[Value("autoBlockSize")]
	public Number AutoBlockSize;
	[Value("childFragments")]
	public List<LayoutFragment> ChildFragments;
	[Value("data")]
	public dynamic Data;
	[Value("breakToken")]
	public BreakTokenOptions BreakToken;
}

[ToObject]
public partial class IntrinsicSizesResultOptions
{
	[Value("maxContentSize")]
	public Number MaxContentSize;
	[Value("minContentSize")]
	public Number MinContentSize;
}

[ToObject]
public partial class FocusableAreasOption
{
	[Value("mode")]
	public FocusableAreaSearchMode Mode;
}

[ToObject]
public partial class SpatialNavigationSearchOptions
{
	[Value("candidates")]
	public List<Node>? Candidates;
	[Value("container")]
	public Node? Container;
}

[ToObject]
public partial class NavigationEventInit : UIEventInit
{
	[Value("dir")]
	public SpatialNavigationDirection Dir;
	[Value("relatedTarget")]
	public EventTarget? RelatedTarget;
}

[ToObject]
public partial class PaintRenderingContext2DSettings
{
	[Value("alpha")]
	public bool Alpha;
}

[ToObject]
public partial class CSSParserOptions
{
	[Value("atRules")]
	public Object AtRules;
}

[ToObject]
public partial class PropertyDefinition
{
	[Value("name")]
	public required DOMString Name;
	[Value("syntax")]
	public DOMString Syntax;
	[Value("inherits")]
	public required bool Inherits;
	[Value("initialValue")]
	public DOMString InitialValue;
}

[ToObject]
public partial class SnapEventInit : EventInit
{
	[Value("snapTargetBlock")]
	public Node? SnapTargetBlock;
	[Value("snapTargetInline")]
	public Node? SnapTargetInline;
}

[ToObject]
public partial class TransitionEventInit : EventInit
{
	[Value("propertyName")]
	public CSSOMString PropertyName;
	[Value("elapsedTime")]
	public Number ElapsedTime;
	[Value("pseudoElement")]
	public CSSOMString PseudoElement;
}

[ToObject]
public partial class CSSNumericType
{
	[Value("length")]
	public long Length;
	[Value("angle")]
	public long Angle;
	[Value("time")]
	public long Time;
	[Value("frequency")]
	public long Frequency;
	[Value("resolution")]
	public long Resolution;
	[Value("flex")]
	public long Flex;
	[Value("percent")]
	public long Percent;
	[Value("percentHint")]
	public CSSNumericBaseType PercentHint;
}

[ToObject]
public partial class CSSMatrixComponentOptions
{
	[Value("is2D")]
	public bool Is2D;
}

[ToObject]
public partial class StartViewTransitionOptions
{
	[Value("update")]
	public ViewTransitionUpdateCallback? Update;
	[Value("types")]
	public List<DOMString>? Types;
}

[ToObject]
public partial class ScrollOptions
{
	[Value("behavior")]
	public ScrollBehavior Behavior;
}

[ToObject]
public partial class ScrollToOptions : ScrollOptions
{
	[Value("left")]
	public double Left;
	[Value("top")]
	public double Top;
}

[ToObject]
public partial class MediaQueryListEventInit : EventInit
{
	[Value("media")]
	public CSSOMString Media;
	[Value("matches")]
	public bool Matches;
}

[ToObject]
public partial class CaretPositionFromPointOptions
{
	[Value("shadowRoots")]
	public List<ShadowRoot> ShadowRoots;
}

[ToObject]
public partial class ScrollIntoViewOptions : ScrollOptions
{
	[Value("block")]
	public ScrollLogicalPosition Block;
	[Value("inline")]
	public ScrollLogicalPosition Inline;
}

[ToObject]
public partial class CheckVisibilityOptions
{
	[Value("checkOpacity")]
	public bool CheckOpacity;
	[Value("checkVisibilityCSS")]
	public bool CheckVisibilityCSS;
	[Value("contentVisibilityAuto")]
	public bool ContentVisibilityAuto;
	[Value("opacityProperty")]
	public bool OpacityProperty;
	[Value("visibilityProperty")]
	public bool VisibilityProperty;
}

[ToObject]
public partial class BoxQuadOptions
{
	[Value("box")]
	public CSSBoxType Box;
	[Value("relativeTo")]
	public GeometryNode RelativeTo;
}

[ToObject]
public partial class ConvertCoordinateOptions
{
	[Value("fromBox")]
	public CSSBoxType FromBox;
	[Value("toBox")]
	public CSSBoxType ToBox;
}

[ToObject]
public partial class CSSStyleSheetInit
{
	[Value("baseURL")]
	public DOMString BaseURL;
	[Value("media")]
	public Union24 Media;
	[Value("disabled")]
	public bool Disabled;
}

public partial class CredentialRequestOptions
{
	[Value("digital")]
	public DigitalCredentialRequestOptions Digital;
}

[ToObject]
public partial class DigitalCredentialRequestOptions
{
	[Value("requests")]
	public List<DigitalCredentialRequest> Requests;
}

[ToObject]
public partial class DigitalCredentialRequest
{
	[Value("protocol")]
	public required DOMString Protocol;
	[Value("data")]
	public required Object Data;
}

[ToObject]
public partial class ItemDetails
{
	[Value("itemId")]
	public required DOMString ItemId;
	[Value("title")]
	public required DOMString Title;
	[Value("price")]
	public required PaymentCurrencyAmount Price;
	[Value("type")]
	public ItemType Type;
	[Value("description")]
	public DOMString Description;
	[Value("iconURLs")]
	public List<DOMString> IconURLs;
	[Value("subscriptionPeriod")]
	public DOMString SubscriptionPeriod;
	[Value("freeTrialPeriod")]
	public DOMString FreeTrialPeriod;
	[Value("introductoryPrice")]
	public PaymentCurrencyAmount IntroductoryPrice;
	[Value("introductoryPricePeriod")]
	public DOMString IntroductoryPricePeriod;
	[Value("introductoryPriceCycles")]
	public ulong IntroductoryPriceCycles;
}

[ToObject]
public partial class PurchaseDetails
{
	[Value("itemId")]
	public required DOMString ItemId;
	[Value("purchaseToken")]
	public required DOMString PurchaseToken;
}

[ToObject]
public partial class DocumentPictureInPictureOptions
{
	[Value("width")]
	public ulong Width;
	[Value("height")]
	public ulong Height;
	[Value("disallowReturnToOpener")]
	public bool DisallowReturnToOpener;
	[Value("preferInitialWindowPlacement")]
	public bool PreferInitialWindowPlacement;
}

[ToObject]
public partial class DocumentPictureInPictureEventInit : EventInit
{
	[Value("window")]
	public required Window Window;
}

[ToObject]
public partial class EventInit
{
	[Value("bubbles")]
	public bool Bubbles;
	[Value("cancelable")]
	public bool Cancelable;
	[Value("composed")]
	public bool Composed;
}

[ToObject]
public partial class CustomEventInit : EventInit
{
	[Value("detail")]
	public dynamic Detail;
}

[ToObject]
public partial class EventListenerOptions
{
	[Value("capture")]
	public bool Capture;
}

[ToObject]
public partial class AddEventListenerOptions : EventListenerOptions
{
	[Value("passive")]
	public bool Passive;
	[Value("once")]
	public bool Once;
	[Value("signal")]
	public AbortSignal Signal;
}

[ToObject]
public partial class MutationObserverInit
{
	[Value("childList")]
	public bool ChildList;
	[Value("attributes")]
	public bool Attributes;
	[Value("characterData")]
	public bool CharacterData;
	[Value("subtree")]
	public bool Subtree;
	[Value("attributeOldValue")]
	public bool AttributeOldValue;
	[Value("characterDataOldValue")]
	public bool CharacterDataOldValue;
	[Value("attributeFilter")]
	public List<DOMString> AttributeFilter;
}

[ToObject]
public partial class GetRootNodeOptions
{
	[Value("composed")]
	public bool Composed;
}

[ToObject]
public partial class ElementCreationOptions
{
	[Value("is")]
	public DOMString Is;
}

[ToObject]
public partial class ShadowRootInit
{
	[Value("mode")]
	public required ShadowRootMode Mode;
	[Value("delegatesFocus")]
	public bool DelegatesFocus;
	[Value("slotAssignment")]
	public SlotAssignmentMode SlotAssignment;
	[Value("clonable")]
	public bool Clonable;
	[Value("serializable")]
	public bool Serializable;
}

[ToObject]
public partial class StaticRangeInit
{
	[Value("startContainer")]
	public required Node StartContainer;
	[Value("startOffset")]
	public required ulong StartOffset;
	[Value("endContainer")]
	public required Node EndContainer;
	[Value("endOffset")]
	public required ulong EndOffset;
}

[ToObject]
public partial class EditContextInit
{
	[Value("text")]
	public DOMString Text;
	[Value("selectionStart")]
	public ulong SelectionStart;
	[Value("selectionEnd")]
	public ulong SelectionEnd;
}

[ToObject]
public partial class TextUpdateEventInit : EventInit
{
	[Value("updateRangeStart")]
	public ulong UpdateRangeStart;
	[Value("updateRangeEnd")]
	public ulong UpdateRangeEnd;
	[Value("text")]
	public DOMString Text;
	[Value("selectionStart")]
	public ulong SelectionStart;
	[Value("selectionEnd")]
	public ulong SelectionEnd;
	[Value("compositionStart")]
	public ulong CompositionStart;
	[Value("compositionEnd")]
	public ulong CompositionEnd;
}

[ToObject]
public partial class TextFormatInit
{
	[Value("rangeStart")]
	public ulong RangeStart;
	[Value("rangeEnd")]
	public ulong RangeEnd;
	[Value("underlineStyle")]
	public UnderlineStyle UnderlineStyle;
	[Value("underlineThickness")]
	public UnderlineThickness UnderlineThickness;
}

[ToObject]
public partial class TextFormatUpdateEventInit : EventInit
{
	[Value("textFormats")]
	public List<TextFormat> TextFormats;
}

[ToObject]
public partial class CharacterBoundsUpdateEventInit : EventInit
{
	[Value("rangeStart")]
	public ulong RangeStart;
	[Value("rangeEnd")]
	public ulong RangeEnd;
}

[ToObject]
public partial class TextDecoderOptions
{
	[Value("fatal")]
	public bool Fatal;
	[Value("ignoreBOM")]
	public bool IgnoreBOM;
}

[ToObject]
public partial class TextDecodeOptions
{
	[Value("stream")]
	public bool Stream;
}

[ToObject]
public partial class TextEncoderEncodeIntoResult
{
	[Value("read")]
	public ulong Read;
	[Value("written")]
	public ulong Written;
}

[ToObject]
public partial class MediaKeySystemConfiguration
{
	[Value("label")]
	public DOMString Label;
	[Value("initDataTypes")]
	public List<DOMString> InitDataTypes;
	[Value("audioCapabilities")]
	public List<MediaKeySystemMediaCapability> AudioCapabilities;
	[Value("videoCapabilities")]
	public List<MediaKeySystemMediaCapability> VideoCapabilities;
	[Value("distinctiveIdentifier")]
	public MediaKeysRequirement DistinctiveIdentifier;
	[Value("persistentState")]
	public MediaKeysRequirement PersistentState;
	[Value("sessionTypes")]
	public List<DOMString> SessionTypes;
}

[ToObject]
public partial class MediaKeySystemMediaCapability
{
	[Value("contentType")]
	public DOMString ContentType;
	[Value("encryptionScheme")]
	public DOMString? EncryptionScheme;
	[Value("robustness")]
	public DOMString Robustness;
}

[ToObject]
public partial class MediaKeysPolicy
{
	[Value("minHdcpVersion")]
	public DOMString MinHdcpVersion;
}

[ToObject]
public partial class MediaKeyMessageEventInit : EventInit
{
	[Value("messageType")]
	public required MediaKeyMessageType MessageType;
	[Value("message")]
	public required ArrayBuffer Message;
}

[ToObject]
public partial class MediaEncryptedEventInit : EventInit
{
	[Value("initDataType")]
	public DOMString InitDataType;
	[Value("initData")]
	public ArrayBuffer? InitData;
}

[ToObject]
public partial class FileSystemFlags
{
	[Value("create")]
	public bool Create;
	[Value("exclusive")]
	public bool Exclusive;
}

[ToObject]
public partial class PerformanceObserverInit
{
	[Value("durationThreshold")]
	public DOMHighResTimeStamp DurationThreshold;
}

[ToObject]
public partial class ColorSelectionResult
{
	[Value("sRGBHex")]
	public DOMString SRGBHex;
}

[ToObject]
public partial class ColorSelectionOptions
{
	[Value("signal")]
	public AbortSignal Signal;
}

[ToObject]
public partial class IdentityCredentialDisconnectOptions : IdentityProviderConfig
{
	[Value("accountHint")]
	public required USVString AccountHint;
}

[ToObject]
public partial class DisconnectedAccount
{
	[Value("account_id")]
	public required USVString Account_id;
}

public partial class CredentialRequestOptions
{
	[Value("identity")]
	public IdentityCredentialRequestOptions Identity;
}

///<include file='CSharpToJavaScript/Utils/Docs/identitycredentialrequestoptions/identitycredentialrequestoptions.generated.xml' path='docs/IdentityCredentialRequestOptions/*'/>
[ToObject]
public partial class IdentityCredentialRequestOptions
{
	///<include file='CSharpToJavaScript/Utils/Docs/identitycredentialrequestoptions/identitycredentialrequestoptions.generated.xml' path='docs/IdentityCredentialRequestOptionsProviders/*'/>
[Value("providers")]
	public required List<IdentityProviderRequestOptions> Providers;
	///<include file='CSharpToJavaScript/Utils/Docs/identitycredentialrequestoptions/identitycredentialrequestoptions.generated.xml' path='docs/IdentityCredentialRequestOptionsContext/*'/>
[Value("context")]
	public IdentityCredentialRequestOptionsContext Context;
	///<include file='CSharpToJavaScript/Utils/Docs/identitycredentialrequestoptions/identitycredentialrequestoptions.generated.xml' path='docs/IdentityCredentialRequestOptionsMode/*'/>
[Value("mode")]
	public IdentityCredentialRequestOptionsMode Mode;
}

[ToObject]
public partial class IdentityProviderConfig
{
	[Value("configURL")]
	public required USVString ConfigURL;
	[Value("clientId")]
	public required USVString ClientId;
}

[ToObject]
public partial class IdentityProviderRequestOptions : IdentityProviderConfig
{
	[Value("nonce")]
	public USVString Nonce;
	[Value("loginHint")]
	public DOMString LoginHint;
	[Value("domainHint")]
	public DOMString DomainHint;
	[Value("fields")]
	public List<USVString> Fields;
	[Value("params")]
	public dynamic Params;
}

[ToObject]
public partial class IdentityProviderWellKnown
{
	[Value("provider_urls")]
	public List<USVString> Provider_urls;
	[Value("accounts_endpoint")]
	public USVString Accounts_endpoint;
	[Value("login_url")]
	public USVString Login_url;
}

[ToObject]
public partial class IdentityProviderIcon
{
	[Value("url")]
	public required USVString Url;
	[Value("size")]
	public ulong Size;
}

[ToObject]
public partial class IdentityProviderBranding
{
	[Value("background_color")]
	public USVString Background_color;
	[Value("color")]
	public USVString Color;
	[Value("icons")]
	public List<IdentityProviderIcon> Icons;
	[Value("name")]
	public USVString Name;
}

[ToObject]
public partial class IdentityProviderAPIConfig
{
	[Value("accounts_endpoint")]
	public required USVString Accounts_endpoint;
	[Value("client_metadata_endpoint")]
	public required USVString Client_metadata_endpoint;
	[Value("id_assertion_endpoint")]
	public required USVString Id_assertion_endpoint;
	[Value("login_url")]
	public required USVString Login_url;
	[Value("disconnect_endpoint")]
	public USVString Disconnect_endpoint;
	[Value("branding")]
	public IdentityProviderBranding Branding;
}

[ToObject]
public partial class IdentityProviderAccount
{
	[Value("id")]
	public required USVString Id;
	[Value("name")]
	public required USVString Name;
	[Value("email")]
	public required USVString Email;
	[Value("given_name")]
	public USVString Given_name;
	[Value("picture")]
	public USVString Picture;
	[Value("approved_clients")]
	public List<USVString> Approved_clients;
	[Value("login_hints")]
	public List<DOMString> Login_hints;
	[Value("domain_hints")]
	public List<DOMString> Domain_hints;
}

[ToObject]
public partial class IdentityProviderAccountList
{
	[Value("accounts")]
	public List<IdentityProviderAccount> Accounts;
}

[ToObject]
public partial class IdentityAssertionResponse
{
	[Value("token")]
	public USVString Token;
	[Value("continue_on")]
	public USVString Continue_on;
}

[ToObject]
public partial class IdentityProviderClientMetadata
{
	[Value("privacy_policy_url")]
	public USVString Privacy_policy_url;
	[Value("terms_of_service_url")]
	public USVString Terms_of_service_url;
}

[ToObject]
public partial class IdentityUserInfo
{
	[Value("email")]
	public USVString Email;
	[Value("name")]
	public USVString Name;
	[Value("givenName")]
	public USVString GivenName;
	[Value("picture")]
	public USVString Picture;
}

[ToObject]
public partial class IdentityResolveOptions
{
	[Value("accountId")]
	public USVString AccountId;
}

[ToObject]
public partial class FenceEvent
{
	[Value("eventType")]
	public DOMString EventType;
	[Value("eventData")]
	public DOMString EventData;
	[Value("destination")]
	public List<FenceReportingDestination> Destination;
	[Value("crossOriginExposed")]
	public bool CrossOriginExposed;
	[Value("once")]
	public bool Once;
	[Value("destinationURL")]
	public USVString DestinationURL;
}


///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInit/*'/>
public partial class RequestInit
{
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitMethod/*'/>
[Value("method")]
	public ByteString Method;
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitHeaders/*'/>
[Value("headers")]
	public HeadersInit Headers;
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitBody/*'/>
[Value("body")]
	public BodyInit? Body;
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitReferrer/*'/>
[Value("referrer")]
	public USVString Referrer;
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitReferrerPolicy/*'/>
[Value("referrerPolicy")]
	public ReferrerPolicy ReferrerPolicy;
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitMode/*'/>
[Value("mode")]
	public RequestMode Mode;
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitCredentials/*'/>
[Value("credentials")]
	public RequestCredentials Credentials;
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitCache/*'/>
[Value("cache")]
	public RequestCache Cache;
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitRedirect/*'/>
[Value("redirect")]
	public RequestRedirect Redirect;
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitIntegrity/*'/>
[Value("integrity")]
	public DOMString Integrity;
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitKeepalive/*'/>
[Value("keepalive")]
	public bool Keepalive;
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitSignal/*'/>
[Value("signal")]
	public AbortSignal? Signal;
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitDuplex/*'/>
[Value("duplex")]
	public RequestDuplex Duplex;
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitPriority/*'/>
[Value("priority")]
	public RequestPriority Priority;
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitWindow/*'/>
[Value("window")]
	public dynamic Window;
}

[ToObject]
public partial class ResponseInit
{
	[Value("status")]
	public ushort Status;
	[Value("statusText")]
	public ByteString StatusText;
	[Value("headers")]
	public HeadersInit Headers;
}

[ToObject]
public partial class AuthenticationExtensionsClientInputs
{
	[Value("credentialProtectionPolicy")]
	public USVString CredentialProtectionPolicy;
	[Value("enforceCredentialProtectionPolicy")]
	public bool EnforceCredentialProtectionPolicy;
}

public partial class AuthenticationExtensionsClientInputs
{
	[Value("credBlob")]
	public ArrayBuffer CredBlob;
}

public partial class AuthenticationExtensionsClientInputs
{
	[Value("getCredBlob")]
	public bool GetCredBlob;
}

public partial class AuthenticationExtensionsClientInputs
{
	[Value("minPinLength")]
	public bool MinPinLength;
}

public partial class AuthenticationExtensionsClientInputs
{
	[Value("hmacCreateSecret")]
	public bool HmacCreateSecret;
}

[ToObject]
public partial class HMACGetSecretInput
{
	[Value("salt1")]
	public required ArrayBuffer Salt1;
	[Value("salt2")]
	public ArrayBuffer Salt2;
}

public partial class AuthenticationExtensionsClientInputs
{
	[Value("hmacGetSecret")]
	public HMACGetSecretInput HmacGetSecret;
}

[ToObject]
public partial class AuthenticationExtensionsClientOutputs
{
	[Value("hmacCreateSecret")]
	public bool HmacCreateSecret;
}

[ToObject]
public partial class HMACGetSecretOutput
{
	[Value("output1")]
	public required ArrayBuffer Output1;
	[Value("output2")]
	public ArrayBuffer Output2;
}

public partial class AuthenticationExtensionsClientOutputs
{
	[Value("hmacGetSecret")]
	public HMACGetSecretOutput HmacGetSecret;
}

[ToObject]
public partial class FileSystemPermissionDescriptor : PermissionDescriptor
{
	[Value("handle")]
	public required FileSystemHandle Handle;
	[Value("mode")]
	public FileSystemPermissionMode Mode;
}

[ToObject]
public partial class FileSystemHandlePermissionDescriptor
{
	[Value("mode")]
	public FileSystemPermissionMode Mode;
}

[ToObject]
public partial class FilePickerAcceptType
{
	[Value("description")]
	public USVString Description;
	[Value("accept")]
	public Dictionary<USVString, USVString> Accept;
}

[ToObject]
public partial class FilePickerOptions
{
	[Value("types")]
	public List<FilePickerAcceptType> Types;
	[Value("excludeAcceptAllOption")]
	public bool ExcludeAcceptAllOption;
	[Value("id")]
	public DOMString Id;
	[Value("startIn")]
	public StartInDirectory StartIn;
}

[ToObject]
public partial class OpenFilePickerOptions : FilePickerOptions
{
	[Value("multiple")]
	public bool Multiple;
}

[ToObject]
public partial class SaveFilePickerOptions : FilePickerOptions
{
	[Value("suggestedName")]
	public USVString? SuggestedName;
}

[ToObject]
public partial class DirectoryPickerOptions
{
	[Value("id")]
	public DOMString Id;
	[Value("startIn")]
	public StartInDirectory StartIn;
	[Value("mode")]
	public FileSystemPermissionMode Mode;
}

[ToObject]
public partial class BlobPropertyBag
{
	[Value("type")]
	public DOMString Type;
	[Value("endings")]
	public EndingType Endings;
}


[ToObject]
public partial class FilePropertyBag : BlobPropertyBag
{
	[Value("lastModified")]
	public long LastModified;
}

[ToObject]
public partial class FileSystemCreateWritableOptions
{
	[Value("keepExistingData")]
	public bool KeepExistingData;
}

[ToObject]
public partial class FileSystemGetFileOptions
{
	[Value("create")]
	public bool Create;
}

[ToObject]
public partial class FileSystemGetDirectoryOptions
{
	[Value("create")]
	public bool Create;
}

[ToObject]
public partial class FileSystemRemoveOptions
{
	[Value("recursive")]
	public bool Recursive;
}

[ToObject]
public partial class WriteParams
{
	[Value("type")]
	public required WriteCommandType Type;
	[Value("size")]
	public ulong? Size;
	[Value("position")]
	public ulong? Position;
	[Value("data")]
	public Union47? Data;
}


[ToObject]
public partial class FileSystemReadWriteOptions
{
	[Value("at")]
	public ulong At;
}

[ToObject]
public partial class FullscreenOptions
{
	[Value("navigationUI")]
	public FullscreenNavigationUI NavigationUI;
}

[ToObject]
public partial class GamepadEffectParameters
{
	[Value("duration")]
	public ulong Duration;
	[Value("startDelay")]
	public ulong StartDelay;
	[Value("strongMagnitude")]
	public Number StrongMagnitude;
	[Value("weakMagnitude")]
	public Number WeakMagnitude;
	[Value("leftTrigger")]
	public Number LeftTrigger;
	[Value("rightTrigger")]
	public Number RightTrigger;
}

[ToObject]
public partial class GamepadEventInit : EventInit
{
	[Value("gamepad")]
	public required Gamepad Gamepad;
}

[ToObject]
public partial class SensorOptions
{
	[Value("frequency")]
	public Number Frequency;
}

[ToObject]
public partial class SensorErrorEventInit : EventInit
{
	[Value("error")]
	public required DOMException Error;
}

[ToObject]
public partial class GeolocationSensorOptions : SensorOptions
{
}

[ToObject]
public partial class ReadOptions : GeolocationSensorOptions
{
	[Value("signal")]
	public AbortSignal? Signal;
}

[ToObject]
public partial class GeolocationSensorReading
{
	[Value("timestamp")]
	public DOMHighResTimeStamp? Timestamp;
	[Value("latitude")]
	public Number? Latitude;
	[Value("longitude")]
	public Number? Longitude;
	[Value("altitude")]
	public Number? Altitude;
	[Value("accuracy")]
	public Number? Accuracy;
	[Value("altitudeAccuracy")]
	public Number? AltitudeAccuracy;
	[Value("heading")]
	public Number? Heading;
	[Value("speed")]
	public Number? Speed;
}

[ToObject]
public partial class PositionOptions
{
	[Value("enableHighAccuracy")]
	public bool EnableHighAccuracy;
	[Value("timeout")]
	public ulong Timeout;
	[Value("maximumAge")]
	public ulong MaximumAge;
}

[ToObject]
public partial class DOMPointInit
{
	[Value("x")]
	public double X;
	[Value("y")]
	public double Y;
	[Value("z")]
	public double Z;
	[Value("w")]
	public double W;
}

[ToObject]
public partial class DOMRectInit
{
	[Value("x")]
	public double X;
	[Value("y")]
	public double Y;
	[Value("width")]
	public double Width;
	[Value("height")]
	public double Height;
}

[ToObject]
public partial class DOMQuadInit
{
	[Value("p1")]
	public DOMPointInit P1;
	[Value("p2")]
	public DOMPointInit P2;
	[Value("p3")]
	public DOMPointInit P3;
	[Value("p4")]
	public DOMPointInit P4;
}

[ToObject]
public partial class DOMMatrix2DInit
{
	[Value("a")]
	public double A;
	[Value("b")]
	public double B;
	[Value("c")]
	public double C;
	[Value("d")]
	public double D;
	[Value("e")]
	public double E;
	[Value("f")]
	public double F;
	[Value("m11")]
	public double M11;
	[Value("m12")]
	public double M12;
	[Value("m21")]
	public double M21;
	[Value("m22")]
	public double M22;
	[Value("m41")]
	public double M41;
	[Value("m42")]
	public double M42;
}

[ToObject]
public partial class DOMMatrixInit : DOMMatrix2DInit
{
	[Value("m13")]
	public double M13;
	[Value("m14")]
	public double M14;
	[Value("m23")]
	public double M23;
	[Value("m24")]
	public double M24;
	[Value("m31")]
	public double M31;
	[Value("m32")]
	public double M32;
	[Value("m33")]
	public double M33;
	[Value("m34")]
	public double M34;
	[Value("m43")]
	public double M43;
	[Value("m44")]
	public double M44;
	[Value("is2D")]
	public bool Is2D;
}

[ToObject]
public partial class RelatedApplication
{
	[Value("platform")]
	public required USVString Platform;
	[Value("url")]
	public USVString Url;
	[Value("id")]
	public DOMString Id;
	[Value("version")]
	public USVString Version;
}

[ToObject]
public partial class GyroscopeSensorOptions : SensorOptions
{
	[Value("referenceFrame")]
	public GyroscopeLocalCoordinateSystem ReferenceFrame;
}

[ToObject]
public partial class HandwritingModelConstraint
{
	[Value("languages")]
	public required List<DOMString> Languages;
}

[ToObject]
public partial class HandwritingRecognizerQueryResult
{
	[Value("textAlternatives")]
	public bool TextAlternatives;
	[Value("textSegmentation")]
	public bool TextSegmentation;
	[Value("hints")]
	public HandwritingHintsQueryResult Hints;
}

[ToObject]
public partial class HandwritingHintsQueryResult
{
	[Value("recognitionType")]
	public List<HandwritingRecognitionType> RecognitionType;
	[Value("inputType")]
	public List<HandwritingInputType> InputType;
	[Value("textContext")]
	public bool TextContext;
	[Value("alternatives")]
	public bool Alternatives;
}

[ToObject]
public partial class HandwritingHints
{
	[Value("recognitionType")]
	public DOMString RecognitionType;
	[Value("inputType")]
	public DOMString InputType;
	[Value("textContext")]
	public DOMString TextContext;
	[Value("alternatives")]
	public ulong Alternatives;
}

[ToObject]
public partial class HandwritingPoint
{
	[Value("x")]
	public required Number X;
	[Value("y")]
	public required Number Y;
	[Value("t")]
	public DOMHighResTimeStamp T;
}

[ToObject]
public partial class HandwritingPrediction
{
	[Value("text")]
	public required DOMString Text;
	[Value("segmentationResult")]
	public List<HandwritingSegment> SegmentationResult;
}

[ToObject]
public partial class HandwritingSegment
{
	[Value("grapheme")]
	public required DOMString Grapheme;
	[Value("beginIndex")]
	public required ulong BeginIndex;
	[Value("endIndex")]
	public required ulong EndIndex;
	[Value("drawingSegments")]
	public required List<HandwritingDrawingSegment> DrawingSegments;
}

[ToObject]
public partial class HandwritingDrawingSegment
{
	[Value("strokeIndex")]
	public required ulong StrokeIndex;
	[Value("beginPointIndex")]
	public required ulong BeginPointIndex;
	[Value("endPointIndex")]
	public required ulong EndPointIndex;
}



[ToObject]
public partial class ShowPopoverOptions
{
	[Value("source")]
	public HTMLElement Source;
}

[ToObject]
public partial class TogglePopoverOptions : ShowPopoverOptions
{
	[Value("force")]
	public bool Force;
}




[ToObject]
public partial class TrackEventInit : EventInit
{
	[Value("track")]
	public Union65? Track;
}

[ToObject]
public partial class SubmitEventInit : EventInit
{
	[Value("submitter")]
	public HTMLElement? Submitter;
}

[ToObject]
public partial class FormDataEventInit : EventInit
{
	[Value("formData")]
	public required FormData FormData;
}

[ToObject]
public partial class AssignedNodesOptions
{
	[Value("flatten")]
	public bool Flatten;
}


[ToObject]
public partial class CanvasRenderingContext2DSettings
{
	[Value("alpha")]
	public bool Alpha;
	[Value("desynchronized")]
	public bool Desynchronized;
	[Value("colorSpace")]
	public PredefinedColorSpace ColorSpace;
	[Value("willReadFrequently")]
	public bool WillReadFrequently;
}

[ToObject]
public partial class ImageDataSettings
{
	[Value("colorSpace")]
	public PredefinedColorSpace ColorSpace;
}

[ToObject]
public partial class ImageBitmapRenderingContextSettings
{
	[Value("alpha")]
	public bool Alpha;
}


[ToObject]
public partial class ImageEncodeOptions
{
	[Value("type")]
	public DOMString Type;
	[Value("quality")]
	public double Quality;
}

[ToObject]
public partial class ElementDefinitionOptions
{
	[Value("extends")]
	public DOMString Extends;
}

[ToObject]
public partial class ValidityStateFlags
{
	[Value("valueMissing")]
	public bool ValueMissing;
	[Value("typeMismatch")]
	public bool TypeMismatch;
	[Value("patternMismatch")]
	public bool PatternMismatch;
	[Value("tooLong")]
	public bool TooLong;
	[Value("tooShort")]
	public bool TooShort;
	[Value("rangeUnderflow")]
	public bool RangeUnderflow;
	[Value("rangeOverflow")]
	public bool RangeOverflow;
	[Value("stepMismatch")]
	public bool StepMismatch;
	[Value("badInput")]
	public bool BadInput;
	[Value("customError")]
	public bool CustomError;
}

[ToObject]
public partial class ToggleEventInit : EventInit
{
	[Value("oldState")]
	public DOMString OldState;
	[Value("newState")]
	public DOMString NewState;
}

[ToObject]
public partial class FocusOptions
{
	[Value("preventScroll")]
	public bool PreventScroll;
	[Value("focusVisible")]
	public bool FocusVisible;
}

[ToObject]
public partial class CloseWatcherOptions
{
	[Value("signal")]
	public AbortSignal Signal;
}

[ToObject]
public partial class DragEventInit : MouseEventInit
{
	[Value("dataTransfer")]
	public DataTransfer? DataTransfer;
}

[ToObject]
public partial class WindowPostMessageOptions : StructuredSerializeOptions
{
	[Value("targetOrigin")]
	public USVString TargetOrigin;
}

[ToObject]
public partial class NavigationUpdateCurrentEntryOptions
{
	[Value("state")]
	public required dynamic State;
}

[ToObject]
public partial class NavigationOptions
{
	[Value("info")]
	public dynamic Info;
}

[ToObject]
public partial class NavigationNavigateOptions : NavigationOptions
{
	[Value("state")]
	public dynamic State;
	[Value("history")]
	public NavigationHistoryBehavior History;
}

[ToObject]
public partial class NavigationReloadOptions : NavigationOptions
{
	[Value("state")]
	public dynamic State;
}

[ToObject]
public partial class NavigationResult
{
	[Value("committed")]
	public Task<NavigationHistoryEntry> Committed;
	[Value("finished")]
	public Task<NavigationHistoryEntry> Finished;
}

[ToObject]
public partial class NavigateEventInit : EventInit
{
	[Value("navigationType")]
	public NavigationType NavigationType;
	[Value("destination")]
	public required NavigationDestination Destination;
	[Value("canIntercept")]
	public bool CanIntercept;
	[Value("userInitiated")]
	public bool UserInitiated;
	[Value("hashChange")]
	public bool HashChange;
	[Value("signal")]
	public required AbortSignal Signal;
	[Value("formData")]
	public FormData? FormData;
	[Value("downloadRequest")]
	public DOMString? DownloadRequest;
	[Value("info")]
	public dynamic Info;
	[Value("hasUAVisualTransition")]
	public bool HasUAVisualTransition;
}

[ToObject]
public partial class NavigationInterceptOptions
{
	[Value("handler")]
	public NavigationInterceptHandler Handler;
	[Value("focusReset")]
	public NavigationFocusReset FocusReset;
	[Value("scroll")]
	public NavigationScrollBehavior Scroll;
}

[ToObject]
public partial class NavigationCurrentEntryChangeEventInit : EventInit
{
	[Value("navigationType")]
	public NavigationType? NavigationType;
	[Value("from")]
	public required NavigationHistoryEntry From;
}

[ToObject]
public partial class PopStateEventInit : EventInit
{
	[Value("state")]
	public dynamic State;
	[Value("hasUAVisualTransition")]
	public bool HasUAVisualTransition;
}

[ToObject]
public partial class HashChangeEventInit : EventInit
{
	[Value("oldURL")]
	public USVString OldURL;
	[Value("newURL")]
	public USVString NewURL;
}

[ToObject]
public partial class PageSwapEventInit : EventInit
{
	[Value("activation")]
	public NavigationActivation? Activation;
	[Value("viewTransition")]
	public ViewTransition? ViewTransition;
}

[ToObject]
public partial class PageRevealEventInit : EventInit
{
	[Value("viewTransition")]
	public ViewTransition? ViewTransition;
}

[ToObject]
public partial class PageTransitionEventInit : EventInit
{
	[Value("persisted")]
	public bool Persisted;
}

[ToObject]
public partial class ErrorEventInit : EventInit
{
	[Value("message")]
	public DOMString Message;
	[Value("filename")]
	public USVString Filename;
	[Value("lineno")]
	public ulong Lineno;
	[Value("colno")]
	public ulong Colno;
	[Value("error")]
	public dynamic Error;
}

[ToObject]
public partial class PromiseRejectionEventInit : EventInit
{
	[Value("promise")]
	public required Object Promise;
	[Value("reason")]
	public dynamic Reason;
}

[ToObject]
public partial class GetHTMLOptions
{
	[Value("serializableShadowRoots")]
	public bool SerializableShadowRoots;
	[Value("shadowRoots")]
	public List<ShadowRoot> ShadowRoots;
}

[ToObject]
public partial class ImageBitmapOptions
{
	[Value("imageOrientation")]
	public ImageOrientation ImageOrientation;
	[Value("premultiplyAlpha")]
	public PremultiplyAlpha PremultiplyAlpha;
	[Value("colorSpaceConversion")]
	public ColorSpaceConversion ColorSpaceConversion;
	[Value("resizeWidth")]
	public ulong ResizeWidth;
	[Value("resizeHeight")]
	public ulong ResizeHeight;
	[Value("resizeQuality")]
	public ResizeQuality ResizeQuality;
}

[ToObject]
public partial class MessageEventInit : EventInit
{
	[Value("data")]
	public dynamic Data;
	[Value("origin")]
	public USVString Origin;
	[Value("lastEventId")]
	public DOMString LastEventId;
	[Value("source")]
	public MessageEventSource? Source;
	[Value("ports")]
	public List<MessagePort> Ports;
}


[ToObject]
public partial class EventSourceInit
{
	[Value("withCredentials")]
	public bool WithCredentials;
}

[ToObject]
public partial class StructuredSerializeOptions
{
	[Value("transfer")]
	public List<Object> Transfer;
}

[ToObject]
public partial class WorkerOptions
{
	[Value("type")]
	public WorkerType Type;
	[Value("credentials")]
	public RequestCredentials Credentials;
	[Value("name")]
	public DOMString Name;
}

[ToObject]
public partial class WorkletOptions
{
	[Value("credentials")]
	public RequestCredentials Credentials;
}

[ToObject]
public partial class StorageEventInit : EventInit
{
	[Value("key")]
	public DOMString? Key;
	[Value("oldValue")]
	public DOMString? OldValue;
	[Value("newValue")]
	public DOMString? NewValue;
	[Value("url")]
	public USVString Url;
	[Value("storageArea")]
	public Storage? StorageArea;
}

[ToObject]
public partial class IdleOptions
{
	[Value("threshold")]
	public ulong Threshold;
	[Value("signal")]
	public AbortSignal Signal;
}

[ToObject]
public partial class PhotoCapabilities
{
	[Value("redEyeReduction")]
	public RedEyeReduction RedEyeReduction;
	[Value("imageHeight")]
	public MediaSettingsRange ImageHeight;
	[Value("imageWidth")]
	public MediaSettingsRange ImageWidth;
	[Value("fillLightMode")]
	public List<FillLightMode> FillLightMode;
}

[ToObject]
public partial class PhotoSettings
{
	[Value("fillLightMode")]
	public FillLightMode FillLightMode;
	[Value("imageHeight")]
	public Number ImageHeight;
	[Value("imageWidth")]
	public Number ImageWidth;
	[Value("redEyeReduction")]
	public bool RedEyeReduction;
}

[ToObject]
public partial class MediaSettingsRange
{
	[Value("max")]
	public Number Max;
	[Value("min")]
	public Number Min;
	[Value("step")]
	public Number Step;
}

///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraints/*'/>
[ToObject]
public partial class MediaTrackSupportedConstraints
{
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsWhiteBalanceMode/*'/>
[Value("whiteBalanceMode")]
	public bool WhiteBalanceMode;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsExposureMode/*'/>
[Value("exposureMode")]
	public bool ExposureMode;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsFocusMode/*'/>
[Value("focusMode")]
	public bool FocusMode;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsPointsOfInterest/*'/>
[Value("pointsOfInterest")]
	public bool PointsOfInterest;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsExposureCompensation/*'/>
[Value("exposureCompensation")]
	public bool ExposureCompensation;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsExposureTime/*'/>
[Value("exposureTime")]
	public bool ExposureTime;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsColorTemperature/*'/>
[Value("colorTemperature")]
	public bool ColorTemperature;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsIso/*'/>
[Value("iso")]
	public bool Iso;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsBrightness/*'/>
[Value("brightness")]
	public bool Brightness;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsContrast/*'/>
[Value("contrast")]
	public bool Contrast;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsPan/*'/>
[Value("pan")]
	public bool Pan;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsSaturation/*'/>
[Value("saturation")]
	public bool Saturation;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsSharpness/*'/>
[Value("sharpness")]
	public bool Sharpness;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsFocusDistance/*'/>
[Value("focusDistance")]
	public bool FocusDistance;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsTilt/*'/>
[Value("tilt")]
	public bool Tilt;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsZoom/*'/>
[Value("zoom")]
	public bool Zoom;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsTorch/*'/>
[Value("torch")]
	public bool Torch;
}

[ToObject]
public partial class MediaTrackCapabilities
{
	[Value("whiteBalanceMode")]
	public List<DOMString> WhiteBalanceMode;
	[Value("exposureMode")]
	public List<DOMString> ExposureMode;
	[Value("focusMode")]
	public List<DOMString> FocusMode;
	[Value("exposureCompensation")]
	public MediaSettingsRange ExposureCompensation;
	[Value("exposureTime")]
	public MediaSettingsRange ExposureTime;
	[Value("colorTemperature")]
	public MediaSettingsRange ColorTemperature;
	[Value("iso")]
	public MediaSettingsRange Iso;
	[Value("brightness")]
	public MediaSettingsRange Brightness;
	[Value("contrast")]
	public MediaSettingsRange Contrast;
	[Value("saturation")]
	public MediaSettingsRange Saturation;
	[Value("sharpness")]
	public MediaSettingsRange Sharpness;
	[Value("focusDistance")]
	public MediaSettingsRange FocusDistance;
	[Value("pan")]
	public MediaSettingsRange Pan;
	[Value("tilt")]
	public MediaSettingsRange Tilt;
	[Value("zoom")]
	public MediaSettingsRange Zoom;
	[Value("torch")]
	public List<bool> Torch;
}

[ToObject]
public partial class MediaTrackConstraintSet
{
	[Value("whiteBalanceMode")]
	public ConstrainDOMString WhiteBalanceMode;
	[Value("exposureMode")]
	public ConstrainDOMString ExposureMode;
	[Value("focusMode")]
	public ConstrainDOMString FocusMode;
	[Value("pointsOfInterest")]
	public ConstrainPoint2D PointsOfInterest;
	[Value("exposureCompensation")]
	public ConstrainDouble ExposureCompensation;
	[Value("exposureTime")]
	public ConstrainDouble ExposureTime;
	[Value("colorTemperature")]
	public ConstrainDouble ColorTemperature;
	[Value("iso")]
	public ConstrainDouble Iso;
	[Value("brightness")]
	public ConstrainDouble Brightness;
	[Value("contrast")]
	public ConstrainDouble Contrast;
	[Value("saturation")]
	public ConstrainDouble Saturation;
	[Value("sharpness")]
	public ConstrainDouble Sharpness;
	[Value("focusDistance")]
	public ConstrainDouble FocusDistance;
	[Value("pan")]
	public Union99 Pan;
	[Value("tilt")]
	public Union100 Tilt;
	[Value("zoom")]
	public Union101 Zoom;
	[Value("torch")]
	public ConstrainBoolean Torch;
}

///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettings/*'/>
[ToObject]
public partial class MediaTrackSettings
{
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsWhiteBalanceMode/*'/>
[Value("whiteBalanceMode")]
	public DOMString WhiteBalanceMode;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsExposureMode/*'/>
[Value("exposureMode")]
	public DOMString ExposureMode;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsFocusMode/*'/>
[Value("focusMode")]
	public DOMString FocusMode;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsPointsOfInterest/*'/>
[Value("pointsOfInterest")]
	public List<Point2D> PointsOfInterest;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsExposureCompensation/*'/>
[Value("exposureCompensation")]
	public Number ExposureCompensation;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsExposureTime/*'/>
[Value("exposureTime")]
	public Number ExposureTime;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsColorTemperature/*'/>
[Value("colorTemperature")]
	public Number ColorTemperature;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsIso/*'/>
[Value("iso")]
	public Number Iso;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsBrightness/*'/>
[Value("brightness")]
	public Number Brightness;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsContrast/*'/>
[Value("contrast")]
	public Number Contrast;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsSaturation/*'/>
[Value("saturation")]
	public Number Saturation;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsSharpness/*'/>
[Value("sharpness")]
	public Number Sharpness;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsFocusDistance/*'/>
[Value("focusDistance")]
	public Number FocusDistance;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsPan/*'/>
[Value("pan")]
	public Number Pan;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsTilt/*'/>
[Value("tilt")]
	public Number Tilt;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsZoom/*'/>
[Value("zoom")]
	public Number Zoom;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsTorch/*'/>
[Value("torch")]
	public bool Torch;
}

[ToObject]
public partial class ConstrainPoint2DParameters
{
	[Value("exact")]
	public List<Point2D> Exact;
	[Value("ideal")]
	public List<Point2D> Ideal;
}


[ToObject]
public partial class Point2D
{
	[Value("x")]
	public Number X;
	[Value("y")]
	public Number Y;
}

[ToObject]
public partial class ImageResource
{
	[Value("src")]
	public required USVString Src;
	[Value("sizes")]
	public DOMString Sizes;
	[Value("type")]
	public DOMString Type;
	[Value("label")]
	public DOMString Label;
}

[ToObject]
public partial class IDBVersionChangeEventInit : EventInit
{
	[Value("oldVersion")]
	public ulong OldVersion;
	[Value("newVersion")]
	public ulong? NewVersion;
}

[ToObject]
public partial class IDBDatabaseInfo
{
	[Value("name")]
	public DOMString Name;
	[Value("version")]
	public ulong Version;
}

[ToObject]
public partial class IDBTransactionOptions
{
	[Value("durability")]
	public IDBTransactionDurability Durability;
}

[ToObject]
public partial class IDBObjectStoreParameters
{
	[Value("keyPath")]
	public Union105? KeyPath;
	[Value("autoIncrement")]
	public bool AutoIncrement;
}

[ToObject]
public partial class IDBIndexParameters
{
	[Value("unique")]
	public bool Unique;
	[Value("multiEntry")]
	public bool MultiEntry;
}

[ToObject]
public partial class InkPresenterParam
{
	[Value("presentationArea")]
	public Element? PresentationArea;
}

[ToObject]
public partial class InkTrailStyle
{
	[Value("color")]
	public required DOMString Color;
	[Value("diameter")]
	public required double Diameter;
}

[ToObject]
public partial class InputDeviceCapabilitiesInit
{
	[Value("firesTouchEvents")]
	public bool FiresTouchEvents;
	[Value("pointerMovementScrolls")]
	public bool PointerMovementScrolls;
}

[ToObject]
public partial class UIEventInit
{
	[Value("sourceCapabilities")]
	public InputDeviceCapabilities? SourceCapabilities;
}

[ToObject]
public partial class InputEventInit
{
	[Value("dataTransfer")]
	public DataTransfer? DataTransfer;
	[Value("targetRanges")]
	public List<StaticRange> TargetRanges;
}

[ToObject]
public partial class IntersectionObserverEntryInit
{
	[Value("time")]
	public required DOMHighResTimeStamp Time;
	[Value("rootBounds")]
	public required DOMRectInit? RootBounds;
	[Value("boundingClientRect")]
	public required DOMRectInit BoundingClientRect;
	[Value("intersectionRect")]
	public required DOMRectInit IntersectionRect;
	[Value("isIntersecting")]
	public required bool IsIntersecting;
	[Value("isVisible")]
	public required bool IsVisible;
	[Value("intersectionRatio")]
	public required Number IntersectionRatio;
	[Value("target")]
	public required Element Target;
}

[ToObject]
public partial class IntersectionObserverInit
{
	[Value("root")]
	public Union109? Root;
	[Value("rootMargin")]
	public DOMString RootMargin;
	[Value("scrollMargin")]
	public DOMString ScrollMargin;
	[Value("threshold")]
	public Union110 Threshold;
	[Value("delay")]
	public long Delay;
	[Value("trackVisibility")]
	public bool TrackVisibility;
}

[ToObject]
public partial class IsInputPendingOptions
{
	[Value("includeContinuous")]
	public bool IncludeContinuous;
}

[ToObject]
public partial class ProfilerTrace
{
	[Value("resources")]
	public required List<ProfilerResource> Resources;
	[Value("frames")]
	public required List<ProfilerFrame> Frames;
	[Value("stacks")]
	public required List<ProfilerStack> Stacks;
	[Value("samples")]
	public required List<ProfilerSample> Samples;
}

[ToObject]
public partial class ProfilerSample
{
	[Value("timestamp")]
	public required DOMHighResTimeStamp Timestamp;
	[Value("stackId")]
	public ulong StackId;
}

[ToObject]
public partial class ProfilerStack
{
	[Value("parentId")]
	public ulong ParentId;
	[Value("frameId")]
	public required ulong FrameId;
}

[ToObject]
public partial class ProfilerFrame
{
	[Value("name")]
	public required DOMString Name;
	[Value("resourceId")]
	public ulong ResourceId;
	[Value("line")]
	public ulong Line;
	[Value("column")]
	public ulong Column;
}

[ToObject]
public partial class ProfilerInitOptions
{
	[Value("sampleInterval")]
	public required DOMHighResTimeStamp SampleInterval;
	[Value("maxBufferSize")]
	public required ulong MaxBufferSize;
}

[ToObject]
public partial class QueryOptions
{
	[Value("postscriptNames")]
	public List<DOMString> PostscriptNames;
}

[ToObject]
public partial class MagnetometerSensorOptions : SensorOptions
{
	[Value("referenceFrame")]
	public MagnetometerLocalCoordinateSystem ReferenceFrame;
}

[ToObject]
public partial class PromptResponseObject
{
	[Value("userChoice")]
	public AppBannerPromptOutcome UserChoice;
}

[ToObject]
public partial class MediaConfiguration
{
	[Value("video")]
	public VideoConfiguration Video;
	[Value("audio")]
	public AudioConfiguration Audio;
}

[ToObject]
public partial class MediaDecodingConfiguration : MediaConfiguration
{
	[Value("type")]
	public required MediaDecodingType Type;
	[Value("keySystemConfiguration")]
	public MediaCapabilitiesKeySystemConfiguration KeySystemConfiguration;
}

[ToObject]
public partial class MediaEncodingConfiguration : MediaConfiguration
{
	[Value("type")]
	public required MediaEncodingType Type;
}

[ToObject]
public partial class VideoConfiguration
{
	[Value("contentType")]
	public required DOMString ContentType;
	[Value("width")]
	public required ulong Width;
	[Value("height")]
	public required ulong Height;
	[Value("bitrate")]
	public required ulong Bitrate;
	[Value("framerate")]
	public required Number Framerate;
	[Value("hasAlphaChannel")]
	public bool HasAlphaChannel;
	[Value("hdrMetadataType")]
	public HdrMetadataType HdrMetadataType;
	[Value("colorGamut")]
	public ColorGamut ColorGamut;
	[Value("transferFunction")]
	public TransferFunction TransferFunction;
	[Value("scalabilityMode")]
	public DOMString ScalabilityMode;
	[Value("spatialScalability")]
	public bool SpatialScalability;
}

[ToObject]
public partial class AudioConfiguration
{
	[Value("contentType")]
	public required DOMString ContentType;
	[Value("channels")]
	public DOMString Channels;
	[Value("bitrate")]
	public ulong Bitrate;
	[Value("samplerate")]
	public ulong Samplerate;
	[Value("spatialRendering")]
	public bool SpatialRendering;
}

[ToObject]
public partial class MediaCapabilitiesKeySystemConfiguration
{
	[Value("keySystem")]
	public required DOMString KeySystem;
	[Value("initDataType")]
	public DOMString InitDataType;
	[Value("distinctiveIdentifier")]
	public MediaKeysRequirement DistinctiveIdentifier;
	[Value("persistentState")]
	public MediaKeysRequirement PersistentState;
	[Value("sessionTypes")]
	public List<DOMString> SessionTypes;
	[Value("audio")]
	public KeySystemTrackConfiguration Audio;
	[Value("video")]
	public KeySystemTrackConfiguration Video;
}

[ToObject]
public partial class KeySystemTrackConfiguration
{
	[Value("robustness")]
	public DOMString Robustness;
	[Value("encryptionScheme")]
	public DOMString? EncryptionScheme;
}

[ToObject]
public partial class MediaCapabilitiesInfo
{
	[Value("supported")]
	public required bool Supported;
	[Value("smooth")]
	public required bool Smooth;
	[Value("powerEfficient")]
	public required bool PowerEfficient;
}

[ToObject]
public partial class MediaCapabilitiesDecodingInfo : MediaCapabilitiesInfo
{
	[Value("keySystemAccess")]
	public required MediaKeySystemAccess KeySystemAccess;
	[Value("configuration")]
	public MediaDecodingConfiguration Configuration;
}

[ToObject]
public partial class MediaCapabilitiesEncodingInfo : MediaCapabilitiesInfo
{
	[Value("configuration")]
	public MediaEncodingConfiguration Configuration;
}

[ToObject]
public partial class BufferedChangeEventInit : EventInit
{
	[Value("addedRanges")]
	public TimeRanges AddedRanges;
	[Value("removedRanges")]
	public TimeRanges RemovedRanges;
}

[ToObject]
public partial class MockCapturePromptResultConfiguration
{
	[Value("getUserMedia")]
	public MockCapturePromptResult GetUserMedia;
	[Value("getDisplayMedia")]
	public MockCapturePromptResult GetDisplayMedia;
}

[ToObject]
public partial class MockCaptureDeviceConfiguration
{
	[Value("label")]
	public DOMString Label;
	[Value("deviceId")]
	public DOMString DeviceId;
	[Value("groupId")]
	public DOMString GroupId;
}

[ToObject]
public partial class MockCameraConfiguration : MockCaptureDeviceConfiguration
{
	[Value("defaultFrameRate")]
	public Number DefaultFrameRate;
	[Value("facingMode")]
	public DOMString FacingMode;
}

[ToObject]
public partial class MockMicrophoneConfiguration : MockCaptureDeviceConfiguration
{
	[Value("defaultSampleRate")]
	public ulong DefaultSampleRate;
}

[ToObject]
public partial class CaptureActionEventInit : EventInit
{
	[Value("action")]
	public DOMString Action;
}

///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraints/*'/>
public partial class MediaTrackSupportedConstraints
{
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsWidth/*'/>
[Value("width")]
	public bool Width;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsHeight/*'/>
[Value("height")]
	public bool Height;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsAspectRatio/*'/>
[Value("aspectRatio")]
	public bool AspectRatio;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsFrameRate/*'/>
[Value("frameRate")]
	public bool FrameRate;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsFacingMode/*'/>
[Value("facingMode")]
	public bool FacingMode;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsResizeMode/*'/>
[Value("resizeMode")]
	public bool ResizeMode;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsSampleRate/*'/>
[Value("sampleRate")]
	public bool SampleRate;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsSampleSize/*'/>
[Value("sampleSize")]
	public bool SampleSize;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsEchoCancellation/*'/>
[Value("echoCancellation")]
	public bool EchoCancellation;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsAutoGainControl/*'/>
[Value("autoGainControl")]
	public bool AutoGainControl;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsNoiseSuppression/*'/>
[Value("noiseSuppression")]
	public bool NoiseSuppression;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsLatency/*'/>
[Value("latency")]
	public bool Latency;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsChannelCount/*'/>
[Value("channelCount")]
	public bool ChannelCount;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsDeviceId/*'/>
[Value("deviceId")]
	public bool DeviceId;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsGroupId/*'/>
[Value("groupId")]
	public bool GroupId;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsBackgroundBlur/*'/>
[Value("backgroundBlur")]
	public bool BackgroundBlur;
}

public partial class MediaTrackCapabilities
{
	[Value("width")]
	public ULongRange Width;
	[Value("height")]
	public ULongRange Height;
	[Value("aspectRatio")]
	public DoubleRange AspectRatio;
	[Value("frameRate")]
	public DoubleRange FrameRate;
	[Value("facingMode")]
	public List<DOMString> FacingMode;
	[Value("resizeMode")]
	public List<DOMString> ResizeMode;
	[Value("sampleRate")]
	public ULongRange SampleRate;
	[Value("sampleSize")]
	public ULongRange SampleSize;
	[Value("echoCancellation")]
	public List<bool> EchoCancellation;
	[Value("autoGainControl")]
	public List<bool> AutoGainControl;
	[Value("noiseSuppression")]
	public List<bool> NoiseSuppression;
	[Value("latency")]
	public DoubleRange Latency;
	[Value("channelCount")]
	public ULongRange ChannelCount;
	[Value("deviceId")]
	public DOMString DeviceId;
	[Value("groupId")]
	public DOMString GroupId;
	[Value("backgroundBlur")]
	public List<bool> BackgroundBlur;
}

///<include file='CSharpToJavaScript/Utils/Docs/mediatrackconstraints/mediatrackconstraints.generated.xml' path='docs/MediaTrackConstraints/*'/>
[ToObject]
public partial class MediaTrackConstraints : MediaTrackConstraintSet
{
	///<include file='CSharpToJavaScript/Utils/Docs/mediatrackconstraints/mediatrackconstraints.generated.xml' path='docs/MediaTrackConstraintsAdvanced/*'/>
[Value("advanced")]
	public List<MediaTrackConstraintSet> Advanced;
}

public partial class MediaTrackConstraintSet
{
	[Value("width")]
	public ConstrainULong Width;
	[Value("height")]
	public ConstrainULong Height;
	[Value("aspectRatio")]
	public ConstrainDouble AspectRatio;
	[Value("frameRate")]
	public ConstrainDouble FrameRate;
	[Value("facingMode")]
	public ConstrainDOMString FacingMode;
	[Value("resizeMode")]
	public ConstrainDOMString ResizeMode;
	[Value("sampleRate")]
	public ConstrainULong SampleRate;
	[Value("sampleSize")]
	public ConstrainULong SampleSize;
	[Value("echoCancellation")]
	public ConstrainBoolean EchoCancellation;
	[Value("autoGainControl")]
	public ConstrainBoolean AutoGainControl;
	[Value("noiseSuppression")]
	public ConstrainBoolean NoiseSuppression;
	[Value("latency")]
	public ConstrainDouble Latency;
	[Value("channelCount")]
	public ConstrainULong ChannelCount;
	[Value("deviceId")]
	public ConstrainDOMString DeviceId;
	[Value("groupId")]
	public ConstrainDOMString GroupId;
	[Value("backgroundBlur")]
	public ConstrainBoolean BackgroundBlur;
}

///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettings/*'/>
public partial class MediaTrackSettings
{
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsWidth/*'/>
[Value("width")]
	public ulong Width;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsHeight/*'/>
[Value("height")]
	public ulong Height;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsAspectRatio/*'/>
[Value("aspectRatio")]
	public Number AspectRatio;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsFrameRate/*'/>
[Value("frameRate")]
	public Number FrameRate;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsFacingMode/*'/>
[Value("facingMode")]
	public DOMString FacingMode;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsResizeMode/*'/>
[Value("resizeMode")]
	public DOMString ResizeMode;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsSampleRate/*'/>
[Value("sampleRate")]
	public ulong SampleRate;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsSampleSize/*'/>
[Value("sampleSize")]
	public ulong SampleSize;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsEchoCancellation/*'/>
[Value("echoCancellation")]
	public bool EchoCancellation;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsAutoGainControl/*'/>
[Value("autoGainControl")]
	public bool AutoGainControl;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsNoiseSuppression/*'/>
[Value("noiseSuppression")]
	public bool NoiseSuppression;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsLatency/*'/>
[Value("latency")]
	public Number Latency;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsChannelCount/*'/>
[Value("channelCount")]
	public ulong ChannelCount;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsDeviceId/*'/>
[Value("deviceId")]
	public DOMString DeviceId;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsGroupId/*'/>
[Value("groupId")]
	public DOMString GroupId;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsBackgroundBlur/*'/>
[Value("backgroundBlur")]
	public bool BackgroundBlur;
}

[ToObject]
public partial class MediaStreamTrackEventInit : EventInit
{
	[Value("track")]
	public required MediaStreamTrack Track;
}

[ToObject]
public partial class DeviceChangeEventInit : EventInit
{
	[Value("devices")]
	public List<MediaDeviceInfo> Devices;
}

[ToObject]
public partial class MediaStreamConstraints
{
	[Value("video")]
	public Union111 Video;
	[Value("audio")]
	public Union112 Audio;
}

[ToObject]
public partial class DoubleRange
{
	[Value("max")]
	public Number Max;
	[Value("min")]
	public Number Min;
}

[ToObject]
public partial class ConstrainDoubleRange : DoubleRange
{
	[Value("exact")]
	public Number Exact;
	[Value("ideal")]
	public Number Ideal;
}

[ToObject]
public partial class ULongRange
{
	[Value("max")]
	public ulong Max;
	[Value("min")]
	public ulong Min;
}

[ToObject]
public partial class ConstrainULongRange : ULongRange
{
	[Value("exact")]
	public ulong Exact;
	[Value("ideal")]
	public ulong Ideal;
}

[ToObject]
public partial class ConstrainBooleanParameters
{
	[Value("exact")]
	public bool Exact;
	[Value("ideal")]
	public bool Ideal;
}

[ToObject]
public partial class ConstrainDOMStringParameters
{
	[Value("exact")]
	public Union113 Exact;
	[Value("ideal")]
	public Union114 Ideal;
}





[ToObject]
public partial class CameraDevicePermissionDescriptor : PermissionDescriptor
{
	[Value("panTiltZoom")]
	public bool PanTiltZoom;
}

[ToObject]
public partial class MediaStreamTrackProcessorInit
{
	[Value("track")]
	public required MediaStreamTrack Track;
	[Value("maxBufferSize")]
	public ushort MaxBufferSize;
}

[ToObject]
public partial class MediaMetadataInit
{
	[Value("title")]
	public DOMString Title;
	[Value("artist")]
	public DOMString Artist;
	[Value("album")]
	public DOMString Album;
	[Value("artwork")]
	public List<MediaImage> Artwork;
	[Value("chapterInfo")]
	public List<ChapterInformationInit> ChapterInfo;
}

[ToObject]
public partial class ChapterInformationInit
{
	[Value("title")]
	public DOMString Title;
	[Value("startTime")]
	public Number StartTime;
	[Value("artwork")]
	public List<MediaImage> Artwork;
}

[ToObject]
public partial class MediaImage
{
	[Value("src")]
	public required USVString Src;
	[Value("sizes")]
	public DOMString Sizes;
	[Value("type")]
	public DOMString Type;
}

[ToObject]
public partial class MediaPositionState
{
	[Value("duration")]
	public double Duration;
	[Value("playbackRate")]
	public Number PlaybackRate;
	[Value("position")]
	public Number Position;
}

[ToObject]
public partial class MediaSessionActionDetails
{
	[Value("action")]
	public required MediaSessionAction Action;
	[Value("seekOffset")]
	public Number SeekOffset;
	[Value("seekTime")]
	public Number SeekTime;
	[Value("fastSeek")]
	public bool FastSeek;
	[Value("isActivating")]
	public bool IsActivating;
}

[ToObject]
public partial class MediaRecorderOptions
{
	[Value("mimeType")]
	public DOMString MimeType;
	[Value("audioBitsPerSecond")]
	public ulong AudioBitsPerSecond;
	[Value("videoBitsPerSecond")]
	public ulong VideoBitsPerSecond;
	[Value("bitsPerSecond")]
	public ulong BitsPerSecond;
	[Value("audioBitrateMode")]
	public BitrateMode AudioBitrateMode;
	[Value("videoKeyFrameIntervalDuration")]
	public DOMHighResTimeStamp VideoKeyFrameIntervalDuration;
	[Value("videoKeyFrameIntervalCount")]
	public ulong VideoKeyFrameIntervalCount;
}

[ToObject]
public partial class BlobEventInit
{
	[Value("data")]
	public required Blob Data;
	[Value("timecode")]
	public DOMHighResTimeStamp Timecode;
}

[ToObject]
public partial class RTCRtpSendParameters
{
	[Value("degradationPreference")]
	public RTCDegradationPreference DegradationPreference;
}

[ToObject]
public partial class NotificationOptions
{
	[Value("dir")]
	public NotificationDirection Dir;
	[Value("lang")]
	public DOMString Lang;
	[Value("body")]
	public DOMString Body;
	[Value("tag")]
	public DOMString Tag;
	[Value("image")]
	public USVString Image;
	[Value("icon")]
	public USVString Icon;
	[Value("badge")]
	public USVString Badge;
	[Value("vibrate")]
	public VibratePattern Vibrate;
	[Value("timestamp")]
	public EpochTimeStamp Timestamp;
	[Value("renotify")]
	public bool Renotify;
	[Value("silent")]
	public bool? Silent;
	[Value("requireInteraction")]
	public bool RequireInteraction;
	[Value("data")]
	public dynamic Data;
	[Value("actions")]
	public List<NotificationAction> Actions;
}

[ToObject]
public partial class NotificationAction
{
	[Value("action")]
	public required DOMString Action;
	[Value("title")]
	public required DOMString Title;
	[Value("icon")]
	public USVString Icon;
}

[ToObject]
public partial class GetNotificationOptions
{
	[Value("tag")]
	public DOMString Tag;
}

[ToObject]
public partial class NotificationEventInit : ExtendableEventInit
{
	[Value("notification")]
	public required Notification Notification;
	[Value("action")]
	public DOMString Action;
}

[ToObject]
public partial class SubscriptionObserver
{
	[Value("next")]
	public ObservableSubscriptionCallback Next;
	[Value("error")]
	public ObservableSubscriptionCallback Error;
	[Value("complete")]
	public VoidFunction Complete;
}

[ToObject]
public partial class ObservableInspector
{
	[Value("next")]
	public ObservableSubscriptionCallback Next;
	[Value("error")]
	public ObservableSubscriptionCallback Error;
	[Value("complete")]
	public VoidFunction Complete;
	[Value("subscribe")]
	public VoidFunction Subscribe;
	[Value("abort")]
	public ObservableInspectorAbortHandler Abort;
}



[ToObject]
public partial class SubscribeOptions
{
	[Value("signal")]
	public AbortSignal Signal;
}

[ToObject]
public partial class ObservableEventListenerOptions
{
	[Value("capture")]
	public bool Capture;
	[Value("passive")]
	public bool Passive;
}

[ToObject]
public partial class DeviceOrientationEventInit : EventInit
{
	[Value("alpha")]
	public Number? Alpha;
	[Value("beta")]
	public Number? Beta;
	[Value("gamma")]
	public Number? Gamma;
	[Value("absolute")]
	public bool Absolute;
}

[ToObject]
public partial class DeviceMotionEventAccelerationInit
{
	[Value("x")]
	public Number? X;
	[Value("y")]
	public Number? Y;
	[Value("z")]
	public Number? Z;
}

[ToObject]
public partial class DeviceMotionEventRotationRateInit
{
	[Value("alpha")]
	public Number? Alpha;
	[Value("beta")]
	public Number? Beta;
	[Value("gamma")]
	public Number? Gamma;
}

[ToObject]
public partial class DeviceMotionEventInit : EventInit
{
	[Value("acceleration")]
	public DeviceMotionEventAccelerationInit Acceleration;
	[Value("accelerationIncludingGravity")]
	public DeviceMotionEventAccelerationInit AccelerationIncludingGravity;
	[Value("rotationRate")]
	public DeviceMotionEventRotationRateInit RotationRate;
	[Value("interval")]
	public Number Interval;
}


[ToObject]
public partial class OrientationSensorOptions : SensorOptions
{
	[Value("referenceFrame")]
	public OrientationSensorLocalCoordinateSystem ReferenceFrame;
}

[ToObject]
public partial class PaymentRequestDetailsUpdate
{
	[Value("error")]
	public DOMString Error;
	[Value("total")]
	public PaymentCurrencyAmount Total;
	[Value("modifiers")]
	public List<PaymentDetailsModifier> Modifiers;
	[Value("shippingOptions")]
	public List<PaymentShippingOption> ShippingOptions;
	[Value("paymentMethodErrors")]
	public Object PaymentMethodErrors;
	[Value("shippingAddressErrors")]
	public AddressErrors ShippingAddressErrors;
}

[ToObject]
public partial class PaymentRequestEventInit : ExtendableEventInit
{
	[Value("topOrigin")]
	public USVString TopOrigin;
	[Value("paymentRequestOrigin")]
	public USVString PaymentRequestOrigin;
	[Value("paymentRequestId")]
	public DOMString PaymentRequestId;
	[Value("methodData")]
	public List<PaymentMethodData> MethodData;
	[Value("total")]
	public PaymentCurrencyAmount Total;
	[Value("modifiers")]
	public List<PaymentDetailsModifier> Modifiers;
	[Value("paymentOptions")]
	public PaymentOptions PaymentOptions;
	[Value("shippingOptions")]
	public List<PaymentShippingOption> ShippingOptions;
}

[ToObject]
public partial class PaymentHandlerResponse
{
	[Value("methodName")]
	public DOMString MethodName;
	[Value("details")]
	public Object Details;
	[Value("payerName")]
	public DOMString? PayerName;
	[Value("payerEmail")]
	public DOMString? PayerEmail;
	[Value("payerPhone")]
	public DOMString? PayerPhone;
	[Value("shippingAddress")]
	public AddressInit ShippingAddress;
	[Value("shippingOption")]
	public DOMString? ShippingOption;
}

[ToObject]
public partial class AddressInit
{
	[Value("country")]
	public DOMString Country;
	[Value("addressLine")]
	public List<DOMString> AddressLine;
	[Value("region")]
	public DOMString Region;
	[Value("city")]
	public DOMString City;
	[Value("dependentLocality")]
	public DOMString DependentLocality;
	[Value("postalCode")]
	public DOMString PostalCode;
	[Value("sortingCode")]
	public DOMString SortingCode;
	[Value("organization")]
	public DOMString Organization;
	[Value("recipient")]
	public DOMString Recipient;
	[Value("phone")]
	public DOMString Phone;
}

[ToObject]
public partial class PaymentMethodData
{
	[Value("supportedMethods")]
	public required DOMString SupportedMethods;
	[Value("data")]
	public Object Data;
}

[ToObject]
public partial class PaymentCurrencyAmount
{
	[Value("currency")]
	public required DOMString Currency;
	[Value("value")]
	public required DOMString Value;
}

[ToObject]
public partial class PaymentDetailsBase
{
	[Value("displayItems")]
	public List<PaymentItem> DisplayItems;
	[Value("shippingOptions")]
	public List<PaymentShippingOption> ShippingOptions;
	[Value("modifiers")]
	public List<PaymentDetailsModifier> Modifiers;
}

[ToObject]
public partial class PaymentDetailsInit : PaymentDetailsBase
{
	[Value("id")]
	public DOMString Id;
	[Value("total")]
	public required PaymentItem Total;
}

[ToObject]
public partial class PaymentDetailsUpdate : PaymentDetailsBase
{
	[Value("error")]
	public DOMString Error;
	[Value("total")]
	public PaymentItem Total;
	[Value("shippingAddressErrors")]
	public AddressErrors ShippingAddressErrors;
	[Value("payerErrors")]
	public PayerErrors PayerErrors;
	[Value("paymentMethodErrors")]
	public Object PaymentMethodErrors;
}

[ToObject]
public partial class PaymentDetailsModifier
{
	[Value("supportedMethods")]
	public required DOMString SupportedMethods;
	[Value("total")]
	public PaymentItem Total;
	[Value("additionalDisplayItems")]
	public List<PaymentItem> AdditionalDisplayItems;
	[Value("data")]
	public Object Data;
}

[ToObject]
public partial class PaymentOptions
{
	[Value("requestPayerName")]
	public bool RequestPayerName;
	[Value("requestBillingAddress")]
	public bool RequestBillingAddress;
	[Value("requestPayerEmail")]
	public bool RequestPayerEmail;
	[Value("requestPayerPhone")]
	public bool RequestPayerPhone;
	[Value("requestShipping")]
	public bool RequestShipping;
	[Value("shippingType")]
	public PaymentShippingType ShippingType;
}

[ToObject]
public partial class PaymentItem
{
	[Value("label")]
	public required DOMString Label;
	[Value("amount")]
	public required PaymentCurrencyAmount Amount;
	[Value("pending")]
	public bool Pending;
}

[ToObject]
public partial class PaymentCompleteDetails
{
	[Value("data")]
	public Object? Data;
}

[ToObject]
public partial class PaymentShippingOption
{
	[Value("id")]
	public required DOMString Id;
	[Value("label")]
	public required DOMString Label;
	[Value("amount")]
	public required PaymentCurrencyAmount Amount;
	[Value("selected")]
	public bool Selected;
}

[ToObject]
public partial class PaymentValidationErrors
{
	[Value("payer")]
	public PayerErrors Payer;
	[Value("shippingAddress")]
	public AddressErrors ShippingAddress;
	[Value("error")]
	public DOMString Error;
	[Value("paymentMethod")]
	public Object PaymentMethod;
}

[ToObject]
public partial class PayerErrors
{
	[Value("email")]
	public DOMString Email;
	[Value("name")]
	public DOMString Name;
	[Value("phone")]
	public DOMString Phone;
}

[ToObject]
public partial class AddressErrors
{
	[Value("addressLine")]
	public DOMString AddressLine;
	[Value("city")]
	public DOMString City;
	[Value("country")]
	public DOMString Country;
	[Value("dependentLocality")]
	public DOMString DependentLocality;
	[Value("organization")]
	public DOMString Organization;
	[Value("phone")]
	public DOMString Phone;
	[Value("postalCode")]
	public DOMString PostalCode;
	[Value("recipient")]
	public DOMString Recipient;
	[Value("region")]
	public DOMString Region;
	[Value("sortingCode")]
	public DOMString SortingCode;
}

[ToObject]
public partial class PaymentMethodChangeEventInit : PaymentRequestUpdateEventInit
{
	[Value("methodName")]
	public DOMString MethodName;
	[Value("methodDetails")]
	public Object? MethodDetails;
}

[ToObject]
public partial class PaymentRequestUpdateEventInit : EventInit
{
}

[ToObject]
public partial class MemoryMeasurement
{
	[Value("bytes")]
	public ulong Bytes;
	[Value("breakdown")]
	public List<MemoryBreakdownEntry> Breakdown;
}

[ToObject]
public partial class MemoryBreakdownEntry
{
	[Value("bytes")]
	public ulong Bytes;
	[Value("attribution")]
	public List<MemoryAttribution> Attribution;
	[Value("types")]
	public List<DOMString> Types;
}

[ToObject]
public partial class MemoryAttribution
{
	[Value("url")]
	public USVString Url;
	[Value("container")]
	public MemoryAttributionContainer Container;
	[Value("scope")]
	public DOMString Scope;
}

[ToObject]
public partial class MemoryAttributionContainer
{
	[Value("id")]
	public DOMString Id;
	[Value("src")]
	public USVString Src;
}

[ToObject]
public partial class PerformanceObserverCallbackOptions
{
	[Value("droppedEntriesCount")]
	public ulong DroppedEntriesCount;
}

public partial class PerformanceObserverInit
{
	[Value("entryTypes")]
	public List<DOMString> EntryTypes;
	[Value("type")]
	public DOMString Type;
	[Value("buffered")]
	public bool Buffered;
}

[ToObject]
public partial class BackgroundSyncOptions
{
	[Value("minInterval")]
	public ulong MinInterval;
}

[ToObject]
public partial class PeriodicSyncEventInit : ExtendableEventInit
{
	[Value("tag")]
	public required DOMString Tag;
}

[ToObject]
public partial class PermissionDescriptor
{
	[Value("name")]
	public required DOMString Name;
}

[ToObject]
public partial class PermissionSetParameters
{
	[Value("descriptor")]
	public required Object Descriptor;
	[Value("state")]
	public required PermissionState State;
}

[ToObject]
public partial class PictureInPictureEventInit : EventInit
{
	[Value("pictureInPictureWindow")]
	public required PictureInPictureWindow PictureInPictureWindow;
}

[ToObject]
public partial class PointerEventInit : MouseEventInit
{
	[Value("pointerId")]
	public long PointerId;
	[Value("width")]
	public Number Width;
	[Value("height")]
	public Number Height;
	[Value("pressure")]
	public Number Pressure;
	[Value("tangentialPressure")]
	public Number TangentialPressure;
	[Value("tiltX")]
	public long TiltX;
	[Value("tiltY")]
	public long TiltY;
	[Value("twist")]
	public long Twist;
	[Value("altitudeAngle")]
	public Number AltitudeAngle;
	[Value("azimuthAngle")]
	public Number AzimuthAngle;
	[Value("pointerType")]
	public DOMString PointerType;
	[Value("isPrimary")]
	public bool IsPrimary;
	[Value("persistentDeviceId")]
	public long PersistentDeviceId;
	[Value("coalescedEvents")]
	public List<PointerEvent> CoalescedEvents;
	[Value("predictedEvents")]
	public List<PointerEvent> PredictedEvents;
}

[ToObject]
public partial class PointerLockOptions
{
	[Value("unadjustedMovement")]
	public bool UnadjustedMovement;
}

[ToObject]
public partial class MouseEventInit
{
	[Value("movementX")]
	public Number MovementX;
	[Value("movementY")]
	public Number MovementY;
}

[ToObject]
public partial class PortalActivateOptions : StructuredSerializeOptions
{
	[Value("data")]
	public dynamic Data;
}

[ToObject]
public partial class PortalActivateEventInit : EventInit
{
	[Value("data")]
	public dynamic Data;
}

public partial class MediaStreamConstraints
{
	[Value("preferCurrentTab")]
	public bool PreferCurrentTab;
}

[ToObject]
public partial class PresentationConnectionAvailableEventInit : EventInit
{
	[Value("connection")]
	public required PresentationConnection Connection;
}

[ToObject]
public partial class PresentationConnectionCloseEventInit : EventInit
{
	[Value("reason")]
	public required PresentationConnectionCloseReason Reason;
	[Value("message")]
	public DOMString Message;
}

[ToObject]
public partial class PAHistogramContribution
{
	[Value("bucket")]
	public required BigInt Bucket;
	[Value("value")]
	public required long Value;
	[Value("filteringId")]
	public BigInt FilteringId;
}

[ToObject]
public partial class PADebugModeOptions
{
	[Value("debugKey")]
	public required BigInt DebugKey;
}

[ToObject]
public partial class PrivateNetworkAccessPermissionDescriptor : PermissionDescriptor
{
	[Value("id")]
	public DOMString Id;
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInit/*'/>
public partial class RequestInit
{
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitTargetAddressSpace/*'/>
[Value("targetAddressSpace")]
	public IPAddressSpace TargetAddressSpace;
}

[ToObject]
public partial class PushPermissionDescriptor : PermissionDescriptor
{
	[Value("userVisibleOnly")]
	public bool UserVisibleOnly;
}

[ToObject]
public partial class PushSubscriptionOptionsInit
{
	[Value("userVisibleOnly")]
	public bool UserVisibleOnly;
	[Value("applicationServerKey")]
	public Union122? ApplicationServerKey;
}

[ToObject]
public partial class PushSubscriptionJSON
{
	[Value("endpoint")]
	public USVString Endpoint;
	[Value("expirationTime")]
	public EpochTimeStamp? ExpirationTime;
	[Value("keys")]
	public Dictionary<DOMString, USVString> Keys;
}

[ToObject]
public partial class PushEventInit : ExtendableEventInit
{
	[Value("data")]
	public PushMessageDataInit Data;
}

[ToObject]
public partial class PushSubscriptionChangeEventInit : ExtendableEventInit
{
	[Value("newSubscription")]
	public PushSubscription NewSubscription;
	[Value("oldSubscription")]
	public PushSubscription OldSubscription;
}

[ToObject]
public partial class ReportingObserverOptions
{
	[Value("types")]
	public List<DOMString> Types;
	[Value("buffered")]
	public bool Buffered;
}


[ToObject]
public partial class GenerateTestReportParameters
{
	[Value("message")]
	public required DOMString Message;
	[Value("group")]
	public DOMString Group;
}

[ToObject]
public partial class IdleRequestOptions
{
	[Value("timeout")]
	public ulong Timeout;
}

[ToObject]
public partial class TopLevelStorageAccessPermissionDescriptor : PermissionDescriptor
{
	[Value("requestedOrigin")]
	public USVString RequestedOrigin;
}

[ToObject]
public partial class ResizeObserverOptions
{
	[Value("box")]
	public ResizeObserverBoxOptions Box;
}

[ToObject]
public partial class StorageAccessTypes
{
	[Value("all")]
	public bool All;
	[Value("cookies")]
	public bool Cookies;
	[Value("sessionStorage")]
	public bool SessionStorage;
	[Value("localStorage")]
	public bool LocalStorage;
	[Value("indexedDB")]
	public bool IndexedDB;
	[Value("locks")]
	public bool Locks;
	[Value("caches")]
	public bool Caches;
	[Value("getDirectory")]
	public bool GetDirectory;
	[Value("estimate")]
	public bool Estimate;
	[Value("createObjectURL")]
	public bool CreateObjectURL;
	[Value("revokeObjectURL")]
	public bool RevokeObjectURL;
	[Value("BroadcastChannel")]
	public bool BroadcastChannel;
	[Value("SharedWorker")]
	public bool SharedWorker;
}

[ToObject]
public partial class SharedWorkerOptions : WorkerOptions
{
	[Value("sameSiteCookies")]
	public SameSiteCookiesType SameSiteCookies;
}

[ToObject]
public partial class SetHTMLOptions
{
	[Value("sanitizer")]
	public Union126 Sanitizer;
}

[ToObject]
public partial class SetHTMLUnsafeOptions
{
	[Value("sanitizer")]
	public Union127 Sanitizer;
}

[ToObject]
public partial class SanitizerElementNamespace
{
	[Value("name")]
	public required DOMString Name;
	[Value("namespace")]
	public DOMString? Namespace;
}

[ToObject]
public partial class SanitizerElementNamespaceWithAttributes : SanitizerElementNamespace
{
	[Value("attributes")]
	public List<SanitizerAttribute> Attributes;
	[Value("removeAttributes")]
	public List<SanitizerAttribute> RemoveAttributes;
}



[ToObject]
public partial class SanitizerAttributeNamespace
{
	[Value("name")]
	public required DOMString Name;
	[Value("namespace")]
	public DOMString? Namespace;
}


///<include file='CSharpToJavaScript/Utils/Docs/sanitizerconfig/sanitizerconfig.generated.xml' path='docs/SanitizerConfig/*'/>
[ToObject]
public partial class SanitizerConfig
{
	///<include file='CSharpToJavaScript/Utils/Docs/sanitizerconfig/sanitizerconfig.generated.xml' path='docs/SanitizerConfigElements/*'/>
[Value("elements")]
	public List<SanitizerElementWithAttributes> Elements;
	///<include file='CSharpToJavaScript/Utils/Docs/sanitizerconfig/sanitizerconfig.generated.xml' path='docs/SanitizerConfigRemoveElements/*'/>
[Value("removeElements")]
	public List<SanitizerElement> RemoveElements;
	///<include file='CSharpToJavaScript/Utils/Docs/sanitizerconfig/sanitizerconfig.generated.xml' path='docs/SanitizerConfigReplaceWithChildrenElements/*'/>
[Value("replaceWithChildrenElements")]
	public List<SanitizerElement> ReplaceWithChildrenElements;
	///<include file='CSharpToJavaScript/Utils/Docs/sanitizerconfig/sanitizerconfig.generated.xml' path='docs/SanitizerConfigAttributes/*'/>
[Value("attributes")]
	public List<SanitizerAttribute> Attributes;
	///<include file='CSharpToJavaScript/Utils/Docs/sanitizerconfig/sanitizerconfig.generated.xml' path='docs/SanitizerConfigRemoveAttributes/*'/>
[Value("removeAttributes")]
	public List<SanitizerAttribute> RemoveAttributes;
	///<include file='CSharpToJavaScript/Utils/Docs/sanitizerconfig/sanitizerconfig.generated.xml' path='docs/SanitizerConfigComments/*'/>
[Value("comments")]
	public bool Comments;
	///<include file='CSharpToJavaScript/Utils/Docs/sanitizerconfig/sanitizerconfig.generated.xml' path='docs/SanitizerConfigDataAttributes/*'/>
[Value("dataAttributes")]
	public bool DataAttributes;
}

[ToObject]
public partial class SchedulerPostTaskOptions
{
	[Value("signal")]
	public AbortSignal Signal;
	[Value("priority")]
	public TaskPriority Priority;
	[Value("delay")]
	public ulong Delay;
}

[ToObject]
public partial class TaskPriorityChangeEventInit : EventInit
{
	[Value("previousPriority")]
	public required TaskPriority PreviousPriority;
}

[ToObject]
public partial class TaskControllerInit
{
	[Value("priority")]
	public TaskPriority Priority;
}

[ToObject]
public partial class TaskSignalAnyInit
{
	[Value("priority")]
	public Union132 Priority;
}

[ToObject]
public partial class DisplayMediaStreamOptions
{
	[Value("video")]
	public Union133 Video;
	[Value("audio")]
	public Union134 Audio;
	[Value("controller")]
	public CaptureController Controller;
	[Value("selfBrowserSurface")]
	public SelfCapturePreferenceEnum SelfBrowserSurface;
	[Value("systemAudio")]
	public SystemAudioPreferenceEnum SystemAudio;
	[Value("surfaceSwitching")]
	public SurfaceSwitchingPreferenceEnum SurfaceSwitching;
	[Value("monitorTypeSurfaces")]
	public MonitorTypeSurfacesEnum MonitorTypeSurfaces;
}

///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraints/*'/>
public partial class MediaTrackSupportedConstraints
{
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsDisplaySurface/*'/>
[Value("displaySurface")]
	public bool DisplaySurface;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsLogicalSurface/*'/>
[Value("logicalSurface")]
	public bool LogicalSurface;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsCursor/*'/>
[Value("cursor")]
	public bool Cursor;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsRestrictOwnAudio/*'/>
[Value("restrictOwnAudio")]
	public bool RestrictOwnAudio;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksupportedconstraints/mediatracksupportedconstraints.generated.xml' path='docs/MediaTrackSupportedConstraintsSuppressLocalAudioPlayback/*'/>
[Value("suppressLocalAudioPlayback")]
	public bool SuppressLocalAudioPlayback;
}

public partial class MediaTrackConstraintSet
{
	[Value("displaySurface")]
	public ConstrainDOMString DisplaySurface;
	[Value("logicalSurface")]
	public ConstrainBoolean LogicalSurface;
	[Value("cursor")]
	public ConstrainDOMString Cursor;
	[Value("restrictOwnAudio")]
	public ConstrainBoolean RestrictOwnAudio;
	[Value("suppressLocalAudioPlayback")]
	public ConstrainBoolean SuppressLocalAudioPlayback;
}

///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettings/*'/>
public partial class MediaTrackSettings
{
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsDisplaySurface/*'/>
[Value("displaySurface")]
	public DOMString DisplaySurface;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsLogicalSurface/*'/>
[Value("logicalSurface")]
	public bool LogicalSurface;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsCursor/*'/>
[Value("cursor")]
	public DOMString Cursor;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsRestrictOwnAudio/*'/>
[Value("restrictOwnAudio")]
	public bool RestrictOwnAudio;
	///<include file='CSharpToJavaScript/Utils/Docs/mediatracksettings/mediatracksettings.generated.xml' path='docs/MediaTrackSettingsSuppressLocalAudioPlayback/*'/>
[Value("suppressLocalAudioPlayback")]
	public bool SuppressLocalAudioPlayback;
}

public partial class MediaTrackCapabilities
{
	[Value("displaySurface")]
	public DOMString DisplaySurface;
	[Value("logicalSurface")]
	public bool LogicalSurface;
	[Value("cursor")]
	public List<DOMString> Cursor;
}

[ToObject]
public partial class ScrollTimelineOptions
{
	[Value("source")]
	public Element? Source;
	[Value("axis")]
	public ScrollAxis Axis;
}

[ToObject]
public partial class ViewTimelineOptions
{
	[Value("subject")]
	public Element Subject;
	[Value("axis")]
	public ScrollAxis Axis;
	[Value("inset")]
	public Union135 Inset;
}

///<include file='CSharpToJavaScript/Utils/Docs/securepaymentconfirmationrequest/securepaymentconfirmationrequest.generated.xml' path='docs/SecurePaymentConfirmationRequest/*'/>
[ToObject]
public partial class SecurePaymentConfirmationRequest
{
	///<include file='CSharpToJavaScript/Utils/Docs/securepaymentconfirmationrequest/securepaymentconfirmationrequest.generated.xml' path='docs/SecurePaymentConfirmationRequestChallenge/*'/>
[Value("challenge")]
	public required BufferSource Challenge;
	///<include file='CSharpToJavaScript/Utils/Docs/securepaymentconfirmationrequest/securepaymentconfirmationrequest.generated.xml' path='docs/SecurePaymentConfirmationRequestRpId/*'/>
[Value("rpId")]
	public required USVString RpId;
	///<include file='CSharpToJavaScript/Utils/Docs/securepaymentconfirmationrequest/securepaymentconfirmationrequest.generated.xml' path='docs/SecurePaymentConfirmationRequestCredentialIds/*'/>
[Value("credentialIds")]
	public required List<BufferSource> CredentialIds;
	///<include file='CSharpToJavaScript/Utils/Docs/securepaymentconfirmationrequest/securepaymentconfirmationrequest.generated.xml' path='docs/SecurePaymentConfirmationRequestInstrument/*'/>
[Value("instrument")]
	public required PaymentCredentialInstrument Instrument;
	///<include file='CSharpToJavaScript/Utils/Docs/securepaymentconfirmationrequest/securepaymentconfirmationrequest.generated.xml' path='docs/SecurePaymentConfirmationRequestTimeout/*'/>
[Value("timeout")]
	public ulong Timeout;
	///<include file='CSharpToJavaScript/Utils/Docs/securepaymentconfirmationrequest/securepaymentconfirmationrequest.generated.xml' path='docs/SecurePaymentConfirmationRequestPayeeName/*'/>
[Value("payeeName")]
	public USVString PayeeName;
	///<include file='CSharpToJavaScript/Utils/Docs/securepaymentconfirmationrequest/securepaymentconfirmationrequest.generated.xml' path='docs/SecurePaymentConfirmationRequestPayeeOrigin/*'/>
[Value("payeeOrigin")]
	public USVString PayeeOrigin;
	///<include file='CSharpToJavaScript/Utils/Docs/securepaymentconfirmationrequest/securepaymentconfirmationrequest.generated.xml' path='docs/SecurePaymentConfirmationRequestExtensions/*'/>
[Value("extensions")]
	public AuthenticationExtensionsClientInputs Extensions;
	///<include file='CSharpToJavaScript/Utils/Docs/securepaymentconfirmationrequest/securepaymentconfirmationrequest.generated.xml' path='docs/SecurePaymentConfirmationRequestLocale/*'/>
[Value("locale")]
	public List<USVString> Locale;
	///<include file='CSharpToJavaScript/Utils/Docs/securepaymentconfirmationrequest/securepaymentconfirmationrequest.generated.xml' path='docs/SecurePaymentConfirmationRequestShowOptOut/*'/>
[Value("showOptOut")]
	public bool ShowOptOut;
}

public partial class AuthenticationExtensionsClientInputs
{
	[Value("payment")]
	public AuthenticationExtensionsPaymentInputs Payment;
}

[ToObject]
public partial class AuthenticationExtensionsPaymentInputs
{
	[Value("isPayment")]
	public bool IsPayment;
	[Value("rpId")]
	public USVString RpId;
	[Value("topOrigin")]
	public USVString TopOrigin;
	[Value("payeeName")]
	public USVString PayeeName;
	[Value("payeeOrigin")]
	public USVString PayeeOrigin;
	[Value("total")]
	public PaymentCurrencyAmount Total;
	[Value("instrument")]
	public PaymentCredentialInstrument Instrument;
}

[ToObject]
public partial class CollectedClientPaymentData : CollectedClientData
{
	[Value("payment")]
	public required CollectedClientAdditionalPaymentData Payment;
}

[ToObject]
public partial class CollectedClientAdditionalPaymentData
{
	[Value("rpId")]
	public required USVString RpId;
	[Value("topOrigin")]
	public required USVString TopOrigin;
	[Value("payeeName")]
	public USVString PayeeName;
	[Value("payeeOrigin")]
	public USVString PayeeOrigin;
	[Value("total")]
	public required PaymentCurrencyAmount Total;
	[Value("instrument")]
	public required PaymentCredentialInstrument Instrument;
}

[ToObject]
public partial class PaymentCredentialInstrument
{
	[Value("displayName")]
	public required USVString DisplayName;
	[Value("icon")]
	public required USVString Icon;
	[Value("iconMustBeShown")]
	public bool IconMustBeShown;
}

[ToObject]
public partial class GetComposedRangesOptions
{
	[Value("shadowRoots")]
	public List<ShadowRoot> ShadowRoots;
}

[ToObject]
public partial class SerialPortRequestOptions
{
	[Value("filters")]
	public List<SerialPortFilter> Filters;
	[Value("allowedBluetoothServiceClassIds")]
	public List<BluetoothServiceUUID> AllowedBluetoothServiceClassIds;
}

[ToObject]
public partial class SerialPortFilter
{
	[Value("usbVendorId")]
	public ushort UsbVendorId;
	[Value("usbProductId")]
	public ushort UsbProductId;
	[Value("bluetoothServiceClassId")]
	public BluetoothServiceUUID BluetoothServiceClassId;
}

[ToObject]
public partial class SerialPortInfo
{
	[Value("usbVendorId")]
	public ushort UsbVendorId;
	[Value("usbProductId")]
	public ushort UsbProductId;
	[Value("bluetoothServiceClassId")]
	public BluetoothServiceUUID BluetoothServiceClassId;
}

[ToObject]
public partial class SerialOptions
{
	[Value("baudRate")]
	public required ulong BaudRate;
	[Value("dataBits")]
	public byte DataBits;
	[Value("stopBits")]
	public byte StopBits;
	[Value("parity")]
	public ParityType Parity;
	[Value("bufferSize")]
	public ulong BufferSize;
	[Value("flowControl")]
	public FlowControlType FlowControl;
}

[ToObject]
public partial class SerialOutputSignals
{
	[Value("dataTerminalReady")]
	public bool DataTerminalReady;
	[Value("requestToSend")]
	public bool RequestToSend;
	[Value("break")]
	public bool Break;
}

[ToObject]
public partial class SerialInputSignals
{
	[Value("dataCarrierDetect")]
	public required bool DataCarrierDetect;
	[Value("clearToSend")]
	public required bool ClearToSend;
	[Value("ringIndicator")]
	public required bool RingIndicator;
	[Value("dataSetReady")]
	public required bool DataSetReady;
}

[ToObject]
public partial class RegistrationOptions
{
	[Value("scope")]
	public USVString Scope;
	[Value("type")]
	public WorkerType Type;
	[Value("updateViaCache")]
	public ServiceWorkerUpdateViaCache UpdateViaCache;
}

[ToObject]
public partial class NavigationPreloadState
{
	[Value("enabled")]
	public bool Enabled;
	[Value("headerValue")]
	public ByteString HeaderValue;
}

[ToObject]
public partial class ClientQueryOptions
{
	[Value("includeUncontrolled")]
	public bool IncludeUncontrolled;
	[Value("type")]
	public ClientType Type;
}

[ToObject]
public partial class ExtendableEventInit : EventInit
{
}

[ToObject]
public partial class RouterRule
{
	[Value("condition")]
	public required RouterCondition Condition;
	[Value("source")]
	public required RouterSource Source;
}

[ToObject]
public partial class RouterCondition
{
	[Value("urlPattern")]
	public URLPatternCompatible UrlPattern;
	[Value("requestMethod")]
	public ByteString RequestMethod;
	[Value("requestMode")]
	public RequestMode RequestMode;
	[Value("requestDestination")]
	public RequestDestination RequestDestination;
	[Value("runningStatus")]
	public RunningStatus RunningStatus;
	[Value("or")]
	public List<RouterCondition> Or;
	[Value("not")]
	public RouterCondition Not;
}


[ToObject]
public partial class RouterSourceDict
{
	[Value("cacheName")]
	public DOMString CacheName;
}

[ToObject]
public partial class FetchEventInit : ExtendableEventInit
{
	[Value("request")]
	public required Request Request;
	[Value("preloadResponse")]
	public Task<dynamic> PreloadResponse;
	[Value("clientId")]
	public DOMString ClientId;
	[Value("resultingClientId")]
	public DOMString ResultingClientId;
	[Value("replacesClientId")]
	public DOMString ReplacesClientId;
	[Value("handled")]
	public Task<Undefined> Handled;
}

[ToObject]
public partial class ExtendableMessageEventInit : ExtendableEventInit
{
	[Value("data")]
	public dynamic Data;
	[Value("origin")]
	public USVString Origin;
	[Value("lastEventId")]
	public DOMString LastEventId;
	[Value("source")]
	public Union141? Source;
	[Value("ports")]
	public List<MessagePort> Ports;
}

[ToObject]
public partial class CacheQueryOptions
{
	[Value("ignoreSearch")]
	public bool IgnoreSearch;
	[Value("ignoreMethod")]
	public bool IgnoreMethod;
	[Value("ignoreVary")]
	public bool IgnoreVary;
}

[ToObject]
public partial class MultiCacheQueryOptions : CacheQueryOptions
{
	[Value("cacheName")]
	public DOMString CacheName;
}

[ToObject]
public partial class FaceDetectorOptions
{
	[Value("maxDetectedFaces")]
	public ushort MaxDetectedFaces;
	[Value("fastMode")]
	public bool FastMode;
}

[ToObject]
public partial class DetectedFace
{
	[Value("boundingBox")]
	public required DOMRectReadOnly BoundingBox;
	[Value("landmarks")]
	public required List<Landmark>? Landmarks;
}

[ToObject]
public partial class Landmark
{
	[Value("locations")]
	public required List<Point2D> Locations;
	[Value("type")]
	public LandmarkType Type;
}

[ToObject]
public partial class BarcodeDetectorOptions
{
	[Value("formats")]
	public List<BarcodeFormat> Formats;
}

[ToObject]
public partial class DetectedBarcode
{
	[Value("boundingBox")]
	public required DOMRectReadOnly BoundingBox;
	[Value("rawValue")]
	public required DOMString RawValue;
	[Value("format")]
	public required BarcodeFormat Format;
	[Value("cornerPoints")]
	public required List<Point2D> CornerPoints;
}

[ToObject]
public partial class SharedStorageUrlWithMetadata
{
	[Value("url")]
	public required USVString Url;
	[Value("reportingMetadata")]
	public Object ReportingMetadata;
}

[ToObject]
public partial class SharedStorageModifierMethodOptions
{
	[Value("withLock")]
	public DOMString WithLock;
}

[ToObject]
public partial class SharedStorageSetMethodOptions : SharedStorageModifierMethodOptions
{
	[Value("ignoreIfPresent")]
	public bool IgnoreIfPresent;
}

[ToObject]
public partial class SharedStoragePrivateAggregationConfig
{
	[Value("aggregationCoordinatorOrigin")]
	public USVString AggregationCoordinatorOrigin;
	[Value("contextId")]
	public USVString ContextId;
	[Value("filteringIdMaxBytes")]
	public ulong FilteringIdMaxBytes;
}

[ToObject]
public partial class SharedStorageRunOperationMethodOptions
{
	[Value("data")]
	public Object Data;
	[Value("resolveToConfig")]
	public bool ResolveToConfig;
	[Value("keepAlive")]
	public bool KeepAlive;
	[Value("privateAggregationConfig")]
	public SharedStoragePrivateAggregationConfig PrivateAggregationConfig;
	[Value("savedQuery")]
	public DOMString SavedQuery;
}

[ToObject]
public partial class SharedStorageWorkletOptions : WorkletOptions
{
	[Value("dataOrigin")]
	public USVString DataOrigin;
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInit/*'/>
public partial class RequestInit
{
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitSharedStorageWritable/*'/>
[Value("sharedStorageWritable")]
	public bool SharedStorageWritable;
}

[ToObject]
public partial class SpeechRecognitionErrorEventInit : EventInit
{
	[Value("error")]
	public required SpeechRecognitionErrorCode Error;
	[Value("message")]
	public DOMString Message;
}

[ToObject]
public partial class SpeechRecognitionEventInit : EventInit
{
	[Value("resultIndex")]
	public ulong ResultIndex;
	[Value("results")]
	public required SpeechRecognitionResultList Results;
}

[ToObject]
public partial class SpeechSynthesisEventInit : EventInit
{
	[Value("utterance")]
	public required SpeechSynthesisUtterance Utterance;
	[Value("charIndex")]
	public ulong CharIndex;
	[Value("charLength")]
	public ulong CharLength;
	[Value("elapsedTime")]
	public Number ElapsedTime;
	[Value("name")]
	public DOMString Name;
}

[ToObject]
public partial class SpeechSynthesisErrorEventInit : SpeechSynthesisEventInit
{
	[Value("error")]
	public required SpeechSynthesisErrorCode Error;
}

[ToObject]
public partial class StorageBucketOptions
{
	[Value("persisted")]
	public bool Persisted;
	[Value("quota")]
	public ulong Quota;
	[Value("expires")]
	public DOMHighResTimeStamp Expires;
}

[ToObject]
public partial class StorageEstimate
{
	[Value("usage")]
	public ulong Usage;
	[Value("quota")]
	public ulong Quota;
}

[ToObject]
public partial class ReadableStreamGetReaderOptions
{
	[Value("mode")]
	public ReadableStreamReaderMode Mode;
}

[ToObject]
public partial class ReadableStreamIteratorOptions
{
	[Value("preventCancel")]
	public bool PreventCancel;
}

[ToObject]
public partial class ReadableWritablePair
{
	[Value("readable")]
	public required ReadableStream Readable;
	[Value("writable")]
	public required WritableStream Writable;
}

[ToObject]
public partial class StreamPipeOptions
{
	[Value("preventClose")]
	public bool PreventClose;
	[Value("preventAbort")]
	public bool PreventAbort;
	[Value("preventCancel")]
	public bool PreventCancel;
	[Value("signal")]
	public AbortSignal Signal;
}

[ToObject]
public partial class UnderlyingSource
{
	[Value("start")]
	public UnderlyingSourceStartCallback Start;
	[Value("pull")]
	public UnderlyingSourcePullCallback Pull;
	[Value("cancel")]
	public UnderlyingSourceCancelCallback Cancel;
	[Value("type")]
	public ReadableStreamType Type;
	[Value("autoAllocateChunkSize")]
	public ulong AutoAllocateChunkSize;
}


[ToObject]
public partial class ReadableStreamReadResult
{
	[Value("value")]
	public dynamic Value;
	[Value("done")]
	public bool Done;
}

[ToObject]
public partial class ReadableStreamBYOBReaderReadOptions
{
	[Value("min")]
	public ulong Min;
}

[ToObject]
public partial class UnderlyingSink
{
	[Value("start")]
	public UnderlyingSinkStartCallback Start;
	[Value("write")]
	public UnderlyingSinkWriteCallback Write;
	[Value("close")]
	public UnderlyingSinkCloseCallback Close;
	[Value("abort")]
	public UnderlyingSinkAbortCallback Abort;
	[Value("type")]
	public dynamic Type;
}

[ToObject]
public partial class Transformer
{
	[Value("start")]
	public TransformerStartCallback Start;
	[Value("transform")]
	public TransformerTransformCallback Transform;
	[Value("flush")]
	public TransformerFlushCallback Flush;
	[Value("cancel")]
	public TransformerCancelCallback Cancel;
	[Value("readableType")]
	public dynamic ReadableType;
	[Value("writableType")]
	public dynamic WritableType;
}

[ToObject]
public partial class QueuingStrategy
{
	[Value("highWaterMark")]
	public double HighWaterMark;
	[Value("size")]
	public QueuingStrategySize Size;
}

[ToObject]
public partial class QueuingStrategyInit
{
	[Value("highWaterMark")]
	public required double HighWaterMark;
}

[ToObject]
public partial class SVGBoundingBoxOptions
{
	[Value("fill")]
	public bool Fill;
	[Value("stroke")]
	public bool Stroke;
	[Value("markers")]
	public bool Markers;
	[Value("clipped")]
	public bool Clipped;
}

[ToObject]
public partial class DetectedText
{
	[Value("boundingBox")]
	public required DOMRectReadOnly BoundingBox;
	[Value("rawValue")]
	public required DOMString RawValue;
	[Value("cornerPoints")]
	public required List<Point2D> CornerPoints;
}

[ToObject]
public partial class TouchInit
{
	[Value("identifier")]
	public required long Identifier;
	[Value("target")]
	public required EventTarget Target;
	[Value("clientX")]
	public Number ClientX;
	[Value("clientY")]
	public Number ClientY;
	[Value("screenX")]
	public Number ScreenX;
	[Value("screenY")]
	public Number ScreenY;
	[Value("pageX")]
	public Number PageX;
	[Value("pageY")]
	public Number PageY;
	[Value("radiusX")]
	public Number RadiusX;
	[Value("radiusY")]
	public Number RadiusY;
	[Value("rotationAngle")]
	public Number RotationAngle;
	[Value("force")]
	public Number Force;
	[Value("altitudeAngle")]
	public Number AltitudeAngle;
	[Value("azimuthAngle")]
	public Number AzimuthAngle;
	[Value("touchType")]
	public TouchType TouchType;
}

[ToObject]
public partial class TouchEventInit : EventModifierInit
{
	[Value("touches")]
	public List<Touch> Touches;
	[Value("targetTouches")]
	public List<Touch> TargetTouches;
	[Value("changedTouches")]
	public List<Touch> ChangedTouches;
}

[ToObject]
public partial class PrivateToken
{
	[Value("version")]
	public required TokenVersion Version;
	[Value("operation")]
	public required OperationType Operation;
	[Value("refreshPolicy")]
	public RefreshPolicy RefreshPolicy;
	[Value("issuers")]
	public List<USVString> Issuers;
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInit/*'/>
public partial class RequestInit
{
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitPrivateToken/*'/>
[Value("privateToken")]
	public PrivateToken PrivateToken;
}

[ToObject]
public partial class TrustedTypePolicyOptions
{
	[Value("createHTML")]
	public CreateHTMLCallback CreateHTML;
	[Value("createScript")]
	public CreateScriptCallback CreateScript;
	[Value("createScriptURL")]
	public CreateScriptURLCallback CreateScriptURL;
}

[ToObject]
public partial class AuctionAd
{
	[Value("renderURL")]
	public required USVString RenderURL;
	[Value("sizeGroup")]
	public USVString SizeGroup;
	[Value("metadata")]
	public dynamic Metadata;
	[Value("buyerReportingId")]
	public USVString BuyerReportingId;
	[Value("buyerAndSellerReportingId")]
	public USVString BuyerAndSellerReportingId;
	[Value("selectableBuyerAndSellerReportingIds")]
	public List<USVString> SelectableBuyerAndSellerReportingIds;
	[Value("allowedReportingOrigins")]
	public List<USVString> AllowedReportingOrigins;
	[Value("adRenderId")]
	public DOMString AdRenderId;
}

[ToObject]
public partial class AuctionAdInterestGroupSize
{
	[Value("width")]
	public required USVString Width;
	[Value("height")]
	public required USVString Height;
}

[ToObject]
public partial class GenerateBidInterestGroup
{
	[Value("owner")]
	public required USVString Owner;
	[Value("name")]
	public required USVString Name;
	[Value("enableBiddingSignalsPrioritization")]
	public bool EnableBiddingSignalsPrioritization;
	[Value("priorityVector")]
	public Dictionary<DOMString, Number> PriorityVector;
	[Value("sellerCapabilities")]
	public Dictionary<USVString, List<DOMString>> SellerCapabilities;
	[Value("executionMode")]
	public DOMString ExecutionMode;
	[Value("biddingLogicURL")]
	public USVString BiddingLogicURL;
	[Value("biddingWasmHelperURL")]
	public USVString BiddingWasmHelperURL;
	[Value("updateURL")]
	public USVString UpdateURL;
	[Value("trustedBiddingSignalsURL")]
	public USVString TrustedBiddingSignalsURL;
	[Value("trustedBiddingSignalsKeys")]
	public List<USVString> TrustedBiddingSignalsKeys;
	[Value("trustedBiddingSignalsSlotSizeMode")]
	public DOMString TrustedBiddingSignalsSlotSizeMode;
	[Value("maxTrustedBiddingSignalsURLLength")]
	public long MaxTrustedBiddingSignalsURLLength;
	[Value("trustedBiddingSignalsCoordinator")]
	public USVString TrustedBiddingSignalsCoordinator;
	[Value("userBiddingSignals")]
	public dynamic UserBiddingSignals;
	[Value("ads")]
	public List<AuctionAd> Ads;
	[Value("adComponents")]
	public List<AuctionAd> AdComponents;
	[Value("adSizes")]
	public Dictionary<DOMString, AuctionAdInterestGroupSize> AdSizes;
	[Value("sizeGroups")]
	public Dictionary<DOMString, List<DOMString>> SizeGroups;
}

[ToObject]
public partial class ProtectedAudiencePrivateAggregationConfig
{
	[Value("aggregationCoordinatorOrigin")]
	public USVString AggregationCoordinatorOrigin;
}

[ToObject]
public partial class AuctionAdInterestGroup : GenerateBidInterestGroup
{
	[Value("priority")]
	public Number Priority;
	[Value("prioritySignalsOverrides")]
	public Dictionary<DOMString, Number> PrioritySignalsOverrides;
	[Value("lifetimeMs")]
	public required Number LifetimeMs;
	[Value("additionalBidKey")]
	public DOMString AdditionalBidKey;
	[Value("privateAggregationConfig")]
	public ProtectedAudiencePrivateAggregationConfig PrivateAggregationConfig;
}

[ToObject]
public partial class AuctionAdInterestGroupKey
{
	[Value("owner")]
	public required USVString Owner;
	[Value("name")]
	public required USVString Name;
}

[ToObject]
public partial class AuctionReportBuyersConfig
{
	[Value("bucket")]
	public required BigInt Bucket;
	[Value("scale")]
	public required Number Scale;
}

[ToObject]
public partial class AuctionReportBuyerDebugModeConfig
{
	[Value("enabled")]
	public bool Enabled;
	[Value("debugKey")]
	public BigInt? DebugKey;
}

[ToObject]
public partial class AuctionRealTimeReportingConfig
{
	[Value("type")]
	public required DOMString Type;
}

[ToObject]
public partial class AuctionAdConfig
{
	[Value("seller")]
	public required USVString Seller;
	[Value("decisionLogicURL")]
	public required USVString DecisionLogicURL;
	[Value("trustedScoringSignalsURL")]
	public USVString TrustedScoringSignalsURL;
	[Value("maxTrustedScoringSignalsURLLength")]
	public long MaxTrustedScoringSignalsURLLength;
	[Value("trustedScoringSignalsCoordinator")]
	public USVString TrustedScoringSignalsCoordinator;
	[Value("interestGroupBuyers")]
	public List<USVString> InterestGroupBuyers;
	[Value("auctionSignals")]
	public Task<dynamic> AuctionSignals;
	[Value("sellerSignals")]
	public Task<dynamic> SellerSignals;
	[Value("directFromSellerSignalsHeaderAdSlot")]
	public Task<DOMString?> DirectFromSellerSignalsHeaderAdSlot;
	[Value("deprecatedRenderURLReplacements")]
	public Task<Dictionary<USVString, USVString>?> DeprecatedRenderURLReplacements;
	[Value("sellerTimeout")]
	public ulong SellerTimeout;
	[Value("sellerExperimentGroupId")]
	public ushort SellerExperimentGroupId;
	[Value("perBuyerSignals")]
	public Task<Dictionary<USVString, dynamic>?> PerBuyerSignals;
	[Value("perBuyerTimeouts")]
	public Task<Dictionary<USVString, ulong>?> PerBuyerTimeouts;
	[Value("perBuyerCumulativeTimeouts")]
	public Task<Dictionary<USVString, ulong>?> PerBuyerCumulativeTimeouts;
	[Value("reportingTimeout")]
	public ulong ReportingTimeout;
	[Value("sellerCurrency")]
	public USVString SellerCurrency;
	[Value("perBuyerCurrencies")]
	public Task<Dictionary<USVString, USVString>?> PerBuyerCurrencies;
	[Value("perBuyerMultiBidLimits")]
	public Dictionary<USVString, ushort> PerBuyerMultiBidLimits;
	[Value("perBuyerGroupLimits")]
	public Dictionary<USVString, ushort> PerBuyerGroupLimits;
	[Value("perBuyerExperimentGroupIds")]
	public Dictionary<USVString, ushort> PerBuyerExperimentGroupIds;
	[Value("perBuyerPrioritySignals")]
	public Dictionary<USVString, Dictionary<USVString, Number>> PerBuyerPrioritySignals;
	[Value("auctionReportBuyerKeys")]
	public List<BigInt> AuctionReportBuyerKeys;
	[Value("auctionReportBuyers")]
	public Dictionary<DOMString, AuctionReportBuyersConfig> AuctionReportBuyers;
	[Value("auctionReportBuyerDebugModeConfig")]
	public AuctionReportBuyerDebugModeConfig AuctionReportBuyerDebugModeConfig;
	[Value("requiredSellerCapabilities")]
	public List<DOMString> RequiredSellerCapabilities;
	[Value("privateAggregationConfig")]
	public ProtectedAudiencePrivateAggregationConfig PrivateAggregationConfig;
	[Value("requestedSize")]
	public Dictionary<DOMString, DOMString> RequestedSize;
	[Value("allSlotsRequestedSizes")]
	public List<Dictionary<DOMString, DOMString>> AllSlotsRequestedSizes;
	[Value("additionalBids")]
	public Task<Undefined> AdditionalBids;
	[Value("auctionNonce")]
	public DOMString AuctionNonce;
	[Value("sellerRealTimeReportingConfig")]
	public AuctionRealTimeReportingConfig SellerRealTimeReportingConfig;
	[Value("perBuyerRealTimeReportingConfig")]
	public Dictionary<USVString, AuctionRealTimeReportingConfig> PerBuyerRealTimeReportingConfig;
	[Value("componentAuctions")]
	public List<AuctionAdConfig> ComponentAuctions;
	[Value("signal")]
	public AbortSignal? Signal;
	[Value("resolveToConfig")]
	public Task<bool> ResolveToConfig;
	[Value("serverResponse")]
	public Task<Uint8Array> ServerResponse;
	[Value("requestId")]
	public USVString RequestId;
}

[ToObject]
public partial class AdAuctionData
{
	[Value("request")]
	public required Uint8Array Request;
	[Value("requestId")]
	public required USVString RequestId;
}

[ToObject]
public partial class AdAuctionDataConfig
{
	[Value("seller")]
	public required USVString Seller;
	[Value("coordinatorOrigin")]
	public required USVString CoordinatorOrigin;
	[Value("requestSize")]
	public ulong RequestSize;
	[Value("perBuyerConfig")]
	public Dictionary<USVString, AdAuctionDataBuyerConfig> PerBuyerConfig;
}

[ToObject]
public partial class AdAuctionDataBuyerConfig
{
	[Value("targetSize")]
	public ulong TargetSize;
}

[ToObject]
public partial class StorageInterestGroup : AuctionAdInterestGroup
{
	[Value("joinCount")]
	public ulong JoinCount;
	[Value("bidCount")]
	public ulong BidCount;
	[Value("prevWinsMs")]
	public List<PreviousWin> PrevWinsMs;
	[Value("joiningOrigin")]
	public USVString JoiningOrigin;
	[Value("timeSinceGroupJoinedMs")]
	public long TimeSinceGroupJoinedMs;
	[Value("lifetimeRemainingMs")]
	public long LifetimeRemainingMs;
	[Value("timeSinceLastUpdateMs")]
	public long TimeSinceLastUpdateMs;
	[Value("timeUntilNextUpdateMs")]
	public long TimeUntilNextUpdateMs;
	[Value("estimatedSize")]
	public ulong EstimatedSize;
}

[ToObject]
public partial class PASignalValue
{
	[Value("baseValue")]
	public required DOMString BaseValue;
	[Value("scale")]
	public Number Scale;
	[Value("offset")]
	public Union147 Offset;
}

[ToObject]
public partial class PAExtendedHistogramContribution
{
	[Value("bucket")]
	public required Union148 Bucket;
	[Value("value")]
	public required Union149 Value;
	[Value("filteringId")]
	public BigInt FilteringId;
}

[ToObject]
public partial class RealTimeContribution
{
	[Value("bucket")]
	public required long Bucket;
	[Value("priorityWeight")]
	public required Number PriorityWeight;
	[Value("latencyThreshold")]
	public long LatencyThreshold;
}

[ToObject]
public partial class AdRender
{
	[Value("url")]
	public required DOMString Url;
	[Value("width")]
	public DOMString Width;
	[Value("height")]
	public DOMString Height;
}

[ToObject]
public partial class GenerateBidOutput
{
	[Value("bid")]
	public Number Bid;
	[Value("bidCurrency")]
	public DOMString BidCurrency;
	[Value("render")]
	public Union151 Render;
	[Value("ad")]
	public dynamic Ad;
	[Value("selectedBuyerAndSellerReportingId")]
	public USVString SelectedBuyerAndSellerReportingId;
	[Value("adComponents")]
	public List<DOMString> AdComponents;
	[Value("adCost")]
	public Number AdCost;
	[Value("modelingSignals")]
	public double ModelingSignals;
	[Value("allowComponentAuction")]
	public bool AllowComponentAuction;
	[Value("targetNumAdComponents")]
	public ulong TargetNumAdComponents;
	[Value("numMandatoryAdComponents")]
	public ulong NumMandatoryAdComponents;
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInit/*'/>
public partial class RequestInit
{
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestInitAdAuctionHeaders/*'/>
[Value("adAuctionHeaders")]
	public bool AdAuctionHeaders;
}

[ToObject]
public partial class BiddingBrowserSignals
{
	[Value("topWindowHostname")]
	public required DOMString TopWindowHostname;
	[Value("seller")]
	public required USVString Seller;
	[Value("joinCount")]
	public required long JoinCount;
	[Value("bidCount")]
	public required long BidCount;
	[Value("recency")]
	public required long Recency;
	[Value("adComponentsLimit")]
	public required long AdComponentsLimit;
	[Value("multiBidLimit")]
	public required ushort MultiBidLimit;
	[Value("requestedSize")]
	public Dictionary<DOMString, DOMString> RequestedSize;
	[Value("topLevelSeller")]
	public USVString TopLevelSeller;
	[Value("prevWinsMs")]
	public List<PreviousWin> PrevWinsMs;
	[Value("wasmHelper")]
	public Object WasmHelper;
	[Value("dataVersion")]
	public ulong DataVersion;
	[Value("crossOriginDataVersion")]
	public ulong CrossOriginDataVersion;
	[Value("forDebuggingOnlyInCooldownOrLockout")]
	public bool ForDebuggingOnlyInCooldownOrLockout;
}

[ToObject]
public partial class ScoringBrowserSignals
{
	[Value("topWindowHostname")]
	public required DOMString TopWindowHostname;
	[Value("interestGroupOwner")]
	public required USVString InterestGroupOwner;
	[Value("renderURL")]
	public required USVString RenderURL;
	[Value("biddingDurationMsec")]
	public required ulong BiddingDurationMsec;
	[Value("bidCurrency")]
	public required DOMString BidCurrency;
	[Value("renderSize")]
	public Dictionary<DOMString, DOMString> RenderSize;
	[Value("dataVersion")]
	public ulong DataVersion;
	[Value("crossOriginDataVersion")]
	public ulong CrossOriginDataVersion;
	[Value("adComponents")]
	public List<USVString> AdComponents;
	[Value("forDebuggingOnlyInCooldownOrLockout")]
	public bool ForDebuggingOnlyInCooldownOrLockout;
}

[ToObject]
public partial class ReportingBrowserSignals
{
	[Value("topWindowHostname")]
	public required DOMString TopWindowHostname;
	[Value("interestGroupOwner")]
	public required USVString InterestGroupOwner;
	[Value("renderURL")]
	public required USVString RenderURL;
	[Value("bid")]
	public required Number Bid;
	[Value("highestScoringOtherBid")]
	public required Number HighestScoringOtherBid;
	[Value("bidCurrency")]
	public DOMString BidCurrency;
	[Value("highestScoringOtherBidCurrency")]
	public DOMString HighestScoringOtherBidCurrency;
	[Value("topLevelSeller")]
	public USVString TopLevelSeller;
	[Value("componentSeller")]
	public USVString ComponentSeller;
	[Value("buyerAndSellerReportingId")]
	public USVString BuyerAndSellerReportingId;
	[Value("selectedBuyerAndSellerReportingId")]
	public USVString SelectedBuyerAndSellerReportingId;
}

[ToObject]
public partial class ReportResultBrowserSignals : ReportingBrowserSignals
{
	[Value("desirability")]
	public required Number Desirability;
	[Value("topLevelSellerSignals")]
	public DOMString TopLevelSellerSignals;
	[Value("modifiedBid")]
	public Number ModifiedBid;
	[Value("dataVersion")]
	public ulong DataVersion;
}

[ToObject]
public partial class ReportWinBrowserSignals : ReportingBrowserSignals
{
	[Value("adCost")]
	public Number AdCost;
	[Value("seller")]
	public USVString Seller;
	[Value("madeHighestScoringOtherBid")]
	public bool MadeHighestScoringOtherBid;
	[Value("interestGroupName")]
	public DOMString InterestGroupName;
	[Value("buyerReportingId")]
	public DOMString BuyerReportingId;
	[Value("modelingSignals")]
	public ushort ModelingSignals;
	[Value("dataVersion")]
	public ulong DataVersion;
	[Value("kAnonStatus")]
	public KAnonStatus KAnonStatus;
}

[ToObject]
public partial class DirectFromSellerSignalsForBuyer
{
	[Value("auctionSignals")]
	public dynamic AuctionSignals;
	[Value("perBuyerSignals")]
	public dynamic PerBuyerSignals;
}

[ToObject]
public partial class DirectFromSellerSignalsForSeller
{
	[Value("auctionSignals")]
	public dynamic AuctionSignals;
	[Value("sellerSignals")]
	public dynamic SellerSignals;
}

[ToObject]
public partial class ScoreAdOutput
{
	[Value("desirability")]
	public required Number Desirability;
	[Value("bid")]
	public Number Bid;
	[Value("bidCurrency")]
	public DOMString BidCurrency;
	[Value("incomingBidInSellerCurrency")]
	public Number IncomingBidInSellerCurrency;
	[Value("allowComponentAuction")]
	public bool AllowComponentAuction;
}

[ToObject]
public partial class NavigatorUABrandVersion
{
	[Value("brand")]
	public DOMString Brand;
	[Value("version")]
	public DOMString Version;
}

[ToObject]
public partial class UADataValues
{
	[Value("architecture")]
	public DOMString Architecture;
	[Value("bitness")]
	public DOMString Bitness;
	[Value("brands")]
	public List<NavigatorUABrandVersion> Brands;
	[Value("formFactors")]
	public List<DOMString> FormFactors;
	[Value("fullVersionList")]
	public List<NavigatorUABrandVersion> FullVersionList;
	[Value("model")]
	public DOMString Model;
	[Value("mobile")]
	public bool Mobile;
	[Value("platform")]
	public DOMString Platform;
	[Value("platformVersion")]
	public DOMString PlatformVersion;
	[Value("uaFullVersion")]
	public DOMString UaFullVersion;
	[Value("wow64")]
	public bool Wow64;
}

[ToObject]
public partial class UALowEntropyJSON
{
	[Value("brands")]
	public List<NavigatorUABrandVersion> Brands;
	[Value("mobile")]
	public bool Mobile;
	[Value("platform")]
	public DOMString Platform;
}

public partial class UIEventInit : EventInit
{
	[Value("view")]
	public Window? View;
	[Value("detail")]
	public long Detail;
}

[ToObject]
public partial class FocusEventInit : UIEventInit
{
	[Value("relatedTarget")]
	public EventTarget? RelatedTarget;
}

public partial class MouseEventInit : EventModifierInit
{
	[Value("screenX")]
	public long ScreenX;
	[Value("screenY")]
	public long ScreenY;
	[Value("clientX")]
	public long ClientX;
	[Value("clientY")]
	public long ClientY;
	[Value("button")]
	public Number Button;
	[Value("buttons")]
	public ushort Buttons;
	[Value("relatedTarget")]
	public EventTarget? RelatedTarget;
}

[ToObject]
public partial class EventModifierInit : UIEventInit
{
	[Value("ctrlKey")]
	public bool CtrlKey;
	[Value("shiftKey")]
	public bool ShiftKey;
	[Value("altKey")]
	public bool AltKey;
	[Value("metaKey")]
	public bool MetaKey;
	[Value("modifierAltGraph")]
	public bool ModifierAltGraph;
	[Value("modifierCapsLock")]
	public bool ModifierCapsLock;
	[Value("modifierFn")]
	public bool ModifierFn;
	[Value("modifierFnLock")]
	public bool ModifierFnLock;
	[Value("modifierHyper")]
	public bool ModifierHyper;
	[Value("modifierNumLock")]
	public bool ModifierNumLock;
	[Value("modifierScrollLock")]
	public bool ModifierScrollLock;
	[Value("modifierSuper")]
	public bool ModifierSuper;
	[Value("modifierSymbol")]
	public bool ModifierSymbol;
	[Value("modifierSymbolLock")]
	public bool ModifierSymbolLock;
}

[ToObject]
public partial class WheelEventInit : MouseEventInit
{
	[Value("deltaX")]
	public Number DeltaX;
	[Value("deltaY")]
	public Number DeltaY;
	[Value("deltaZ")]
	public Number DeltaZ;
	[Value("deltaMode")]
	public ulong DeltaMode;
}

public partial class InputEventInit : UIEventInit
{
	[Value("data")]
	public DOMString? Data;
	[Value("isComposing")]
	public bool IsComposing;
	[Value("inputType")]
	public DOMString InputType;
}

[ToObject]
public partial class KeyboardEventInit : EventModifierInit
{
	[Value("key")]
	public DOMString Key;
	[Value("code")]
	public DOMString Code;
	[Value("location")]
	public ulong Location;
	[Value("repeat")]
	public bool Repeat;
	[Value("isComposing")]
	public bool IsComposing;
}

[ToObject]
public partial class CompositionEventInit : UIEventInit
{
	[Value("data")]
	public DOMString Data;
}

public partial class UIEventInit
{
	[Value("which")]
	public ulong Which;
}

public partial class KeyboardEventInit
{
	[Value("charCode")]
	public ulong CharCode;
	[Value("keyCode")]
	public ulong KeyCode;
}

[ToObject]
public partial class URLPatternInit
{
	[Value("protocol")]
	public USVString Protocol;
	[Value("username")]
	public USVString Username;
	[Value("password")]
	public USVString Password;
	[Value("hostname")]
	public USVString Hostname;
	[Value("port")]
	public USVString Port;
	[Value("pathname")]
	public USVString Pathname;
	[Value("search")]
	public USVString Search;
	[Value("hash")]
	public USVString Hash;
	[Value("baseURL")]
	public USVString BaseURL;
}

[ToObject]
public partial class URLPatternOptions
{
	[Value("ignoreCase")]
	public bool IgnoreCase;
}

[ToObject]
public partial class URLPatternResult
{
	[Value("inputs")]
	public List<URLPatternInput> Inputs;
	[Value("protocol")]
	public URLPatternComponentResult Protocol;
	[Value("username")]
	public URLPatternComponentResult Username;
	[Value("password")]
	public URLPatternComponentResult Password;
	[Value("hostname")]
	public URLPatternComponentResult Hostname;
	[Value("port")]
	public URLPatternComponentResult Port;
	[Value("pathname")]
	public URLPatternComponentResult Pathname;
	[Value("search")]
	public URLPatternComponentResult Search;
	[Value("hash")]
	public URLPatternComponentResult Hash;
}

[ToObject]
public partial class URLPatternComponentResult
{
	[Value("input")]
	public USVString Input;
	[Value("groups")]
	public Dictionary<USVString, USVString> Groups;
}


[ToObject]
public partial class PerformanceMarkOptions
{
	[Value("detail")]
	public dynamic Detail;
	[Value("startTime")]
	public DOMHighResTimeStamp StartTime;
}

[ToObject]
public partial class PerformanceMeasureOptions
{
	[Value("detail")]
	public dynamic Detail;
	[Value("start")]
	public Union156 Start;
	[Value("duration")]
	public DOMHighResTimeStamp Duration;
	[Value("end")]
	public Union157 End;
}

[ToObject]
public partial class VideoFrameCallbackMetadata
{
	[Value("presentationTime")]
	public required DOMHighResTimeStamp PresentationTime;
	[Value("expectedDisplayTime")]
	public required DOMHighResTimeStamp ExpectedDisplayTime;
	[Value("width")]
	public required ulong Width;
	[Value("height")]
	public required ulong Height;
	[Value("mediaTime")]
	public required Number MediaTime;
	[Value("presentedFrames")]
	public required ulong PresentedFrames;
	[Value("processingDuration")]
	public Number ProcessingDuration;
	[Value("captureTime")]
	public DOMHighResTimeStamp CaptureTime;
	[Value("receiveTime")]
	public DOMHighResTimeStamp ReceiveTime;
	[Value("rtpTimestamp")]
	public ulong RtpTimestamp;
}

[ToObject]
public partial class WebAssemblyInstantiatedSource
{
	[Value("module")]
	public required Module Module;
	[Value("instance")]
	public required Instance Instance;
}

[ToObject]
public partial class ModuleExportDescriptor
{
	[Value("name")]
	public required USVString Name;
	[Value("kind")]
	public required ImportExportKind Kind;
}

[ToObject]
public partial class ModuleImportDescriptor
{
	[Value("module")]
	public required USVString Module;
	[Value("name")]
	public required USVString Name;
	[Value("kind")]
	public required ImportExportKind Kind;
}

[ToObject]
public partial class MemoryDescriptor
{
	[Value("initial")]
	public required ulong Initial;
	[Value("maximum")]
	public ulong Maximum;
}

[ToObject]
public partial class TableDescriptor
{
	[Value("element")]
	public required TableKind Element;
	[Value("initial")]
	public required ulong Initial;
	[Value("maximum")]
	public ulong Maximum;
}

[ToObject]
public partial class GlobalDescriptor
{
	[Value("value")]
	public required ValueType Value;
	[Value("mutable")]
	public bool Mutable;
}

[ToObject]
public partial class EffectTiming
{
	[Value("delay")]
	public Number Delay;
	[Value("endDelay")]
	public Number EndDelay;
	[Value("playbackRate")]
	public Number PlaybackRate;
	[Value("duration")]
	public Union160 Duration;
}

[ToObject]
public partial class OptionalEffectTiming
{
	[Value("playbackRate")]
	public Number PlaybackRate;
}

[ToObject]
public partial class ComputedEffectTiming
{
	[Value("startTime")]
	public CSSNumberish StartTime;
	[Value("endTime")]
	public CSSNumberish EndTime;
	[Value("activeDuration")]
	public CSSNumberish ActiveDuration;
	[Value("localTime")]
	public CSSNumberish? LocalTime;
}

[ToObject]
public partial class KeyframeEffectOptions
{
	[Value("iterationComposite")]
	public IterationCompositeOperation IterationComposite;
}

[ToObject]
public partial class TimelineRangeOffset
{
	[Value("rangeName")]
	public CSSOMString? RangeName;
	[Value("offset")]
	public CSSNumericValue Offset;
}

[ToObject]
public partial class KeyframeAnimationOptions
{
	[Value("rangeStart")]
	public Union164 RangeStart;
	[Value("rangeEnd")]
	public Union165 RangeEnd;
}

[ToObject]
public partial class AnimationPlaybackEventInit : EventInit
{
	[Value("currentTime")]
	public CSSNumberish? CurrentTime;
	[Value("timelineTime")]
	public CSSNumberish? TimelineTime;
}

[ToObject]
public partial class DocumentTimelineOptions
{
	[Value("originTime")]
	public DOMHighResTimeStamp OriginTime;
}

public partial class EffectTiming
{
	[Value("fill")]
	public FillMode Fill;
	[Value("iterationStart")]
	public Number IterationStart;
	[Value("iterations")]
	public double Iterations;
	[Value("direction")]
	public PlaybackDirection Direction;
	[Value("easing")]
	public DOMString Easing;
}

public partial class OptionalEffectTiming
{
	[Value("delay")]
	public Number Delay;
	[Value("endDelay")]
	public Number EndDelay;
	[Value("fill")]
	public FillMode Fill;
	[Value("iterationStart")]
	public Number IterationStart;
	[Value("iterations")]
	public double Iterations;
	[Value("duration")]
	public Union166 Duration;
	[Value("direction")]
	public PlaybackDirection Direction;
	[Value("easing")]
	public DOMString Easing;
}

public partial class ComputedEffectTiming : EffectTiming
{
	[Value("progress")]
	public Number? Progress;
	[Value("currentIteration")]
	public double? CurrentIteration;
}

[ToObject]
public partial class BaseComputedKeyframe
{
	[Value("offset")]
	public Number? Offset;
	[Value("computedOffset")]
	public Number ComputedOffset;
	[Value("easing")]
	public DOMString Easing;
	[Value("composite")]
	public CompositeOperationOrAuto Composite;
}

[ToObject]
public partial class BasePropertyIndexedKeyframe
{
	[Value("offset")]
	public Union168 Offset;
	[Value("easing")]
	public Union169 Easing;
	[Value("composite")]
	public Union170 Composite;
}

[ToObject]
public partial class BaseKeyframe
{
	[Value("offset")]
	public Number? Offset;
	[Value("easing")]
	public DOMString Easing;
	[Value("composite")]
	public CompositeOperationOrAuto Composite;
}

public partial class KeyframeEffectOptions : EffectTiming
{
	[Value("composite")]
	public CompositeOperation Composite;
	[Value("pseudoElement")]
	public CSSOMString? PseudoElement;
}

public partial class KeyframeAnimationOptions : KeyframeEffectOptions
{
	[Value("id")]
	public DOMString Id;
	[Value("timeline")]
	public AnimationTimeline? Timeline;
}

[ToObject]
public partial class GetAnimationsOptions
{
	[Value("subtree")]
	public bool Subtree;
	[Value("pseudoElement")]
	public CSSOMString? PseudoElement;
}

[ToObject]
public partial class BluetoothLEScanOptions
{
	[Value("filters")]
	public List<BluetoothLEScanFilterInit> Filters;
	[Value("keepRepeatedDevices")]
	public bool KeepRepeatedDevices;
	[Value("acceptAllAdvertisements")]
	public bool AcceptAllAdvertisements;
}

[ToObject]
public partial class BluetoothLEScanPermissionDescriptor : PermissionDescriptor
{
	[Value("filters")]
	public List<BluetoothLEScanFilterInit> Filters;
	[Value("keepRepeatedDevices")]
	public bool KeepRepeatedDevices;
	[Value("acceptAllAdvertisements")]
	public bool AcceptAllAdvertisements;
}

[ToObject]
public partial class BluetoothDataFilterInit
{
	[Value("dataPrefix")]
	public BufferSource DataPrefix;
	[Value("mask")]
	public BufferSource Mask;
}

[ToObject]
public partial class BluetoothManufacturerDataFilterInit : BluetoothDataFilterInit
{
	[Value("companyIdentifier")]
	public required ushort CompanyIdentifier;
}

[ToObject]
public partial class BluetoothServiceDataFilterInit : BluetoothDataFilterInit
{
	[Value("service")]
	public required BluetoothServiceUUID Service;
}

[ToObject]
public partial class BluetoothLEScanFilterInit
{
	[Value("services")]
	public List<BluetoothServiceUUID> Services;
	[Value("name")]
	public DOMString Name;
	[Value("namePrefix")]
	public DOMString NamePrefix;
	[Value("manufacturerData")]
	public List<BluetoothManufacturerDataFilterInit> ManufacturerData;
	[Value("serviceData")]
	public List<BluetoothServiceDataFilterInit> ServiceData;
}

///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestDeviceOptions/*'/>
[ToObject]
public partial class RequestDeviceOptions
{
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestDeviceOptionsFilters/*'/>
[Value("filters")]
	public List<BluetoothLEScanFilterInit> Filters;
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestDeviceOptionsExclusionFilters/*'/>
[Value("exclusionFilters")]
	public List<BluetoothLEScanFilterInit> ExclusionFilters;
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestDeviceOptionsOptionalServices/*'/>
[Value("optionalServices")]
	public List<BluetoothServiceUUID> OptionalServices;
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestDeviceOptionsOptionalManufacturerData/*'/>
[Value("optionalManufacturerData")]
	public List<ushort> OptionalManufacturerData;
	///<include file='CSharpToJavaScript/Utils/Docs/request/request.generated.xml' path='docs/RequestDeviceOptionsAcceptAllDevices/*'/>
[Value("acceptAllDevices")]
	public bool AcceptAllDevices;
}

[ToObject]
public partial class BluetoothPermissionDescriptor : PermissionDescriptor
{
	[Value("deviceId")]
	public DOMString DeviceId;
	[Value("filters")]
	public List<BluetoothLEScanFilterInit> Filters;
	[Value("optionalServices")]
	public List<BluetoothServiceUUID> OptionalServices;
	[Value("optionalManufacturerData")]
	public List<ushort> OptionalManufacturerData;
	[Value("acceptAllDevices")]
	public bool AcceptAllDevices;
}

[ToObject]
public partial class AllowedBluetoothDevice
{
	[Value("deviceId")]
	public required DOMString DeviceId;
	[Value("mayUseGATT")]
	public required bool MayUseGATT;
	[Value("allowedServices")]
	public required Union172 AllowedServices;
	[Value("allowedManufacturerData")]
	public required List<ushort> AllowedManufacturerData;
}

[ToObject]
public partial class BluetoothPermissionStorage
{
	[Value("allowedDevices")]
	public required List<AllowedBluetoothDevice> AllowedDevices;
}

[ToObject]
public partial class ValueEventInit : EventInit
{
	[Value("value")]
	public dynamic Value;
}

[ToObject]
public partial class WatchAdvertisementsOptions
{
	[Value("signal")]
	public AbortSignal Signal;
}

[ToObject]
public partial class BluetoothAdvertisingEventInit : EventInit
{
	[Value("device")]
	public required BluetoothDevice Device;
	[Value("uuids")]
	public List<DOMString> Uuids;
	[Value("name")]
	public DOMString Name;
	[Value("appearance")]
	public ushort Appearance;
	[Value("txPower")]
	public byte TxPower;
	[Value("rssi")]
	public byte Rssi;
	[Value("manufacturerData")]
	public BluetoothManufacturerDataMap ManufacturerData;
	[Value("serviceData")]
	public BluetoothServiceDataMap ServiceData;
}

[ToObject]
public partial class LockOptions
{
	[Value("mode")]
	public LockMode Mode;
	[Value("ifAvailable")]
	public bool IfAvailable;
	[Value("steal")]
	public bool Steal;
	[Value("signal")]
	public AbortSignal Signal;
}

[ToObject]
public partial class LockManagerSnapshot
{
	[Value("held")]
	public List<LockInfo> Held;
	[Value("pending")]
	public List<LockInfo> Pending;
}

[ToObject]
public partial class LockInfo
{
	[Value("name")]
	public DOMString Name;
	[Value("mode")]
	public LockMode Mode;
	[Value("clientId")]
	public DOMString ClientId;
}

[ToObject]
public partial class NDEFMessageInit
{
	[Value("records")]
	public required List<NDEFRecordInit> Records;
}

[ToObject]
public partial class NDEFRecordInit
{
	[Value("recordType")]
	public required USVString RecordType;
	[Value("mediaType")]
	public USVString MediaType;
	[Value("id")]
	public USVString Id;
	[Value("encoding")]
	public USVString Encoding;
	[Value("lang")]
	public USVString Lang;
	[Value("data")]
	public dynamic Data;
}


[ToObject]
public partial class NDEFReadingEventInit : EventInit
{
	[Value("serialNumber")]
	public DOMString? SerialNumber;
	[Value("message")]
	public required NDEFMessageInit Message;
}

[ToObject]
public partial class NDEFWriteOptions
{
	[Value("overwrite")]
	public bool Overwrite;
	[Value("signal")]
	public AbortSignal? Signal;
}

[ToObject]
public partial class NDEFMakeReadOnlyOptions
{
	[Value("signal")]
	public AbortSignal? Signal;
}

[ToObject]
public partial class NDEFScanOptions
{
	[Value("signal")]
	public AbortSignal Signal;
}

public partial class CredentialRequestOptions
{
	[Value("otp")]
	public OTPCredentialRequestOptions Otp;
}

[ToObject]
public partial class OTPCredentialRequestOptions
{
	[Value("transport")]
	public List<OTPCredentialTransportType> Transport;
}

[ToObject]
public partial class ShareData
{
	[Value("files")]
	public List<File> Files;
	[Value("title")]
	public USVString Title;
	[Value("text")]
	public USVString Text;
	[Value("url")]
	public USVString Url;
}

[ToObject]
public partial class AudioContextOptions
{
	[Value("latencyHint")]
	public Union182 LatencyHint;
	[Value("sampleRate")]
	public Number SampleRate;
	[Value("sinkId")]
	public Union183 SinkId;
	[Value("renderSizeHint")]
	public Union184 RenderSizeHint;
}

[ToObject]
public partial class AudioSinkOptions
{
	[Value("type")]
	public required AudioSinkType Type;
}

[ToObject]
public partial class AudioTimestamp
{
	[Value("contextTime")]
	public Number ContextTime;
	[Value("performanceTime")]
	public DOMHighResTimeStamp PerformanceTime;
}

[ToObject]
public partial class AudioRenderCapacityOptions
{
	[Value("updateInterval")]
	public Number UpdateInterval;
}

[ToObject]
public partial class AudioRenderCapacityEventInit : EventInit
{
	[Value("timestamp")]
	public Number Timestamp;
	[Value("averageLoad")]
	public Number AverageLoad;
	[Value("peakLoad")]
	public Number PeakLoad;
	[Value("underrunRatio")]
	public Number UnderrunRatio;
}

[ToObject]
public partial class OfflineAudioContextOptions
{
	[Value("numberOfChannels")]
	public ulong NumberOfChannels;
	[Value("length")]
	public required ulong Length;
	[Value("sampleRate")]
	public required Number SampleRate;
	[Value("renderSizeHint")]
	public Union185 RenderSizeHint;
}

[ToObject]
public partial class OfflineAudioCompletionEventInit : EventInit
{
	[Value("renderedBuffer")]
	public required AudioBuffer RenderedBuffer;
}

[ToObject]
public partial class AudioBufferOptions
{
	[Value("numberOfChannels")]
	public ulong NumberOfChannels;
	[Value("length")]
	public required ulong Length;
	[Value("sampleRate")]
	public required Number SampleRate;
}

[ToObject]
public partial class AudioNodeOptions
{
	[Value("channelCount")]
	public ulong ChannelCount;
	[Value("channelCountMode")]
	public ChannelCountMode ChannelCountMode;
	[Value("channelInterpretation")]
	public ChannelInterpretation ChannelInterpretation;
}

[ToObject]
public partial class AnalyserOptions : AudioNodeOptions
{
	[Value("fftSize")]
	public ulong FftSize;
	[Value("maxDecibels")]
	public Number MaxDecibels;
	[Value("minDecibels")]
	public Number MinDecibels;
	[Value("smoothingTimeConstant")]
	public Number SmoothingTimeConstant;
}

[ToObject]
public partial class AudioBufferSourceOptions
{
	[Value("buffer")]
	public AudioBuffer? Buffer;
	[Value("detune")]
	public Number Detune;
	[Value("loop")]
	public bool Loop;
	[Value("loopEnd")]
	public Number LoopEnd;
	[Value("loopStart")]
	public Number LoopStart;
	[Value("playbackRate")]
	public Number PlaybackRate;
}

[ToObject]
public partial class AudioProcessingEventInit : EventInit
{
	[Value("playbackTime")]
	public required Number PlaybackTime;
	[Value("inputBuffer")]
	public required AudioBuffer InputBuffer;
	[Value("outputBuffer")]
	public required AudioBuffer OutputBuffer;
}

[ToObject]
public partial class BiquadFilterOptions : AudioNodeOptions
{
	[Value("type")]
	public BiquadFilterType Type;
	[Value("Q")]
	public Number Q;
	[Value("detune")]
	public Number Detune;
	[Value("frequency")]
	public Number Frequency;
	[Value("gain")]
	public Number Gain;
}

[ToObject]
public partial class ChannelMergerOptions : AudioNodeOptions
{
	[Value("numberOfInputs")]
	public ulong NumberOfInputs;
}

[ToObject]
public partial class ChannelSplitterOptions : AudioNodeOptions
{
	[Value("numberOfOutputs")]
	public ulong NumberOfOutputs;
}

[ToObject]
public partial class ConstantSourceOptions
{
	[Value("offset")]
	public Number Offset;
}

[ToObject]
public partial class ConvolverOptions : AudioNodeOptions
{
	[Value("buffer")]
	public AudioBuffer? Buffer;
	[Value("disableNormalization")]
	public bool DisableNormalization;
}

[ToObject]
public partial class DelayOptions : AudioNodeOptions
{
	[Value("maxDelayTime")]
	public Number MaxDelayTime;
	[Value("delayTime")]
	public Number DelayTime;
}

[ToObject]
public partial class DynamicsCompressorOptions : AudioNodeOptions
{
	[Value("attack")]
	public Number Attack;
	[Value("knee")]
	public Number Knee;
	[Value("ratio")]
	public Number Ratio;
	[Value("release")]
	public Number Release;
	[Value("threshold")]
	public Number Threshold;
}

[ToObject]
public partial class GainOptions : AudioNodeOptions
{
	[Value("gain")]
	public Number Gain;
}

[ToObject]
public partial class IIRFilterOptions : AudioNodeOptions
{
	[Value("feedforward")]
	public required List<Number> Feedforward;
	[Value("feedback")]
	public required List<Number> Feedback;
}

[ToObject]
public partial class MediaElementAudioSourceOptions
{
	[Value("mediaElement")]
	public required HTMLMediaElement MediaElement;
}

[ToObject]
public partial class MediaStreamAudioSourceOptions
{
	[Value("mediaStream")]
	public required MediaStream MediaStream;
}

[ToObject]
public partial class MediaStreamTrackAudioSourceOptions
{
	[Value("mediaStreamTrack")]
	public required MediaStreamTrack MediaStreamTrack;
}

[ToObject]
public partial class OscillatorOptions : AudioNodeOptions
{
	[Value("type")]
	public OscillatorType Type;
	[Value("frequency")]
	public Number Frequency;
	[Value("detune")]
	public Number Detune;
	[Value("periodicWave")]
	public PeriodicWave PeriodicWave;
}

[ToObject]
public partial class PannerOptions : AudioNodeOptions
{
	[Value("panningModel")]
	public PanningModelType PanningModel;
	[Value("distanceModel")]
	public DistanceModelType DistanceModel;
	[Value("positionX")]
	public Number PositionX;
	[Value("positionY")]
	public Number PositionY;
	[Value("positionZ")]
	public Number PositionZ;
	[Value("orientationX")]
	public Number OrientationX;
	[Value("orientationY")]
	public Number OrientationY;
	[Value("orientationZ")]
	public Number OrientationZ;
	[Value("refDistance")]
	public Number RefDistance;
	[Value("maxDistance")]
	public Number MaxDistance;
	[Value("rolloffFactor")]
	public Number RolloffFactor;
	[Value("coneInnerAngle")]
	public Number ConeInnerAngle;
	[Value("coneOuterAngle")]
	public Number ConeOuterAngle;
	[Value("coneOuterGain")]
	public Number ConeOuterGain;
}

[ToObject]
public partial class PeriodicWaveConstraints
{
	[Value("disableNormalization")]
	public bool DisableNormalization;
}

[ToObject]
public partial class PeriodicWaveOptions : PeriodicWaveConstraints
{
	[Value("real")]
	public List<Number> Real;
	[Value("imag")]
	public List<Number> Imag;
}

[ToObject]
public partial class StereoPannerOptions : AudioNodeOptions
{
	[Value("pan")]
	public Number Pan;
}

[ToObject]
public partial class WaveShaperOptions : AudioNodeOptions
{
	[Value("curve")]
	public List<Number> Curve;
	[Value("oversample")]
	public OverSampleType Oversample;
}

[ToObject]
public partial class AudioWorkletNodeOptions : AudioNodeOptions
{
	[Value("numberOfInputs")]
	public ulong NumberOfInputs;
	[Value("numberOfOutputs")]
	public ulong NumberOfOutputs;
	[Value("outputChannelCount")]
	public List<ulong> OutputChannelCount;
	[Value("parameterData")]
	public Dictionary<DOMString, Number> ParameterData;
	[Value("processorOptions")]
	public Object ProcessorOptions;
}

///<include file='CSharpToJavaScript/Utils/Docs/audioparamdescriptor/audioparamdescriptor.generated.xml' path='docs/AudioParamDescriptor/*'/>
[ToObject]
public partial class AudioParamDescriptor
{
	///<include file='CSharpToJavaScript/Utils/Docs/audioparamdescriptor/audioparamdescriptor.generated.xml' path='docs/AudioParamDescriptorName/*'/>
[Value("name")]
	public required DOMString Name;
	///<include file='CSharpToJavaScript/Utils/Docs/audioparamdescriptor/audioparamdescriptor.generated.xml' path='docs/AudioParamDescriptorDefaultValue/*'/>
[Value("defaultValue")]
	public Number DefaultValue;
	///<include file='CSharpToJavaScript/Utils/Docs/audioparamdescriptor/audioparamdescriptor.generated.xml' path='docs/AudioParamDescriptorMinValue/*'/>
[Value("minValue")]
	public Number MinValue;
	///<include file='CSharpToJavaScript/Utils/Docs/audioparamdescriptor/audioparamdescriptor.generated.xml' path='docs/AudioParamDescriptorMaxValue/*'/>
[Value("maxValue")]
	public Number MaxValue;
	///<include file='CSharpToJavaScript/Utils/Docs/audioparamdescriptor/audioparamdescriptor.generated.xml' path='docs/AudioParamDescriptorAutomationRate/*'/>
[Value("automationRate")]
	public AutomationRate AutomationRate;
}

[ToObject]
public partial class RegistrationResponseJSON
{
	[Value("id")]
	public required DOMString Id;
	[Value("rawId")]
	public required Base64URLString RawId;
	[Value("response")]
	public required AuthenticatorAttestationResponseJSON Response;
	[Value("authenticatorAttachment")]
	public DOMString AuthenticatorAttachment;
	[Value("clientExtensionResults")]
	public required AuthenticationExtensionsClientOutputsJSON ClientExtensionResults;
	[Value("type")]
	public required DOMString Type;
}

[ToObject]
public partial class AuthenticatorAttestationResponseJSON
{
	[Value("clientDataJSON")]
	public required Base64URLString ClientDataJSON;
	[Value("authenticatorData")]
	public required Base64URLString AuthenticatorData;
	[Value("transports")]
	public required List<DOMString> Transports;
	[Value("publicKey")]
	public Base64URLString PublicKey;
	[Value("publicKeyAlgorithm")]
	public required COSEAlgorithmIdentifier PublicKeyAlgorithm;
	[Value("attestationObject")]
	public required Base64URLString AttestationObject;
}

[ToObject]
public partial class AuthenticationResponseJSON
{
	[Value("id")]
	public required DOMString Id;
	[Value("rawId")]
	public required Base64URLString RawId;
	[Value("response")]
	public required AuthenticatorAssertionResponseJSON Response;
	[Value("authenticatorAttachment")]
	public DOMString AuthenticatorAttachment;
	[Value("clientExtensionResults")]
	public required AuthenticationExtensionsClientOutputsJSON ClientExtensionResults;
	[Value("type")]
	public required DOMString Type;
}

[ToObject]
public partial class AuthenticatorAssertionResponseJSON
{
	[Value("clientDataJSON")]
	public required Base64URLString ClientDataJSON;
	[Value("authenticatorData")]
	public required Base64URLString AuthenticatorData;
	[Value("signature")]
	public required Base64URLString Signature;
	[Value("userHandle")]
	public Base64URLString UserHandle;
}

[ToObject]
public partial class AuthenticationExtensionsClientOutputsJSON
{
}

public partial class CredentialCreationOptions
{
	[Value("publicKey")]
	public PublicKeyCredentialCreationOptions PublicKey;
}

public partial class CredentialRequestOptions
{
	[Value("publicKey")]
	public PublicKeyCredentialRequestOptions PublicKey;
}

[ToObject]
public partial class PublicKeyCredentialCreationOptionsJSON
{
	[Value("rp")]
	public required PublicKeyCredentialRpEntity Rp;
	[Value("user")]
	public required PublicKeyCredentialUserEntityJSON User;
	[Value("challenge")]
	public required Base64URLString Challenge;
	[Value("pubKeyCredParams")]
	public required List<PublicKeyCredentialParameters> PubKeyCredParams;
	[Value("timeout")]
	public ulong Timeout;
	[Value("excludeCredentials")]
	public List<PublicKeyCredentialDescriptorJSON> ExcludeCredentials;
	[Value("authenticatorSelection")]
	public AuthenticatorSelectionCriteria AuthenticatorSelection;
	[Value("hints")]
	public List<DOMString> Hints;
	[Value("attestation")]
	public DOMString Attestation;
	[Value("attestationFormats")]
	public List<DOMString> AttestationFormats;
	[Value("extensions")]
	public AuthenticationExtensionsClientInputsJSON Extensions;
}

[ToObject]
public partial class PublicKeyCredentialUserEntityJSON
{
	[Value("id")]
	public required Base64URLString Id;
	[Value("name")]
	public required DOMString Name;
	[Value("displayName")]
	public required DOMString DisplayName;
}

[ToObject]
public partial class PublicKeyCredentialDescriptorJSON
{
	[Value("type")]
	public required DOMString Type;
	[Value("id")]
	public required Base64URLString Id;
	[Value("transports")]
	public List<DOMString> Transports;
}

[ToObject]
public partial class AuthenticationExtensionsClientInputsJSON
{
}

[ToObject]
public partial class PublicKeyCredentialRequestOptionsJSON
{
	[Value("challenge")]
	public required Base64URLString Challenge;
	[Value("timeout")]
	public ulong Timeout;
	[Value("rpId")]
	public DOMString RpId;
	[Value("allowCredentials")]
	public List<PublicKeyCredentialDescriptorJSON> AllowCredentials;
	[Value("userVerification")]
	public DOMString UserVerification;
	[Value("hints")]
	public List<DOMString> Hints;
	[Value("extensions")]
	public AuthenticationExtensionsClientInputsJSON Extensions;
}

[ToObject]
public partial class UnknownCredentialOptions
{
	[Value("rpId")]
	public required DOMString RpId;
	[Value("credentialId")]
	public required Base64URLString CredentialId;
}

[ToObject]
public partial class AllAcceptedCredentialsOptions
{
	[Value("rpId")]
	public required DOMString RpId;
	[Value("userId")]
	public required Base64URLString UserId;
	[Value("allAcceptedCredentialIds")]
	public required List<Base64URLString> AllAcceptedCredentialIds;
}

[ToObject]
public partial class CurrentUserDetailsOptions
{
	[Value("rpId")]
	public required DOMString RpId;
	[Value("userId")]
	public required Base64URLString UserId;
	[Value("name")]
	public required DOMString Name;
	[Value("displayName")]
	public required DOMString DisplayName;
}

[ToObject]
public partial class PublicKeyCredentialParameters
{
	[Value("type")]
	public required DOMString Type;
	[Value("alg")]
	public required COSEAlgorithmIdentifier Alg;
}

///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialcreationoptions/publickeycredentialcreationoptions.generated.xml' path='docs/PublicKeyCredentialCreationOptions/*'/>
[ToObject]
public partial class PublicKeyCredentialCreationOptions
{
	///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialcreationoptions/publickeycredentialcreationoptions.generated.xml' path='docs/PublicKeyCredentialCreationOptionsRp/*'/>
[Value("rp")]
	public required PublicKeyCredentialRpEntity Rp;
	///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialcreationoptions/publickeycredentialcreationoptions.generated.xml' path='docs/PublicKeyCredentialCreationOptionsUser/*'/>
[Value("user")]
	public required PublicKeyCredentialUserEntity User;
	///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialcreationoptions/publickeycredentialcreationoptions.generated.xml' path='docs/PublicKeyCredentialCreationOptionsChallenge/*'/>
[Value("challenge")]
	public required BufferSource Challenge;
	///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialcreationoptions/publickeycredentialcreationoptions.generated.xml' path='docs/PublicKeyCredentialCreationOptionsPubKeyCredParams/*'/>
[Value("pubKeyCredParams")]
	public required List<PublicKeyCredentialParameters> PubKeyCredParams;
	///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialcreationoptions/publickeycredentialcreationoptions.generated.xml' path='docs/PublicKeyCredentialCreationOptionsTimeout/*'/>
[Value("timeout")]
	public ulong Timeout;
	///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialcreationoptions/publickeycredentialcreationoptions.generated.xml' path='docs/PublicKeyCredentialCreationOptionsExcludeCredentials/*'/>
[Value("excludeCredentials")]
	public List<PublicKeyCredentialDescriptor> ExcludeCredentials;
	///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialcreationoptions/publickeycredentialcreationoptions.generated.xml' path='docs/PublicKeyCredentialCreationOptionsAuthenticatorSelection/*'/>
[Value("authenticatorSelection")]
	public AuthenticatorSelectionCriteria AuthenticatorSelection;
	///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialcreationoptions/publickeycredentialcreationoptions.generated.xml' path='docs/PublicKeyCredentialCreationOptionsHints/*'/>
[Value("hints")]
	public List<DOMString> Hints;
	///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialcreationoptions/publickeycredentialcreationoptions.generated.xml' path='docs/PublicKeyCredentialCreationOptionsAttestation/*'/>
[Value("attestation")]
	public DOMString Attestation;
	///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialcreationoptions/publickeycredentialcreationoptions.generated.xml' path='docs/PublicKeyCredentialCreationOptionsAttestationFormats/*'/>
[Value("attestationFormats")]
	public List<DOMString> AttestationFormats;
	///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialcreationoptions/publickeycredentialcreationoptions.generated.xml' path='docs/PublicKeyCredentialCreationOptionsExtensions/*'/>
[Value("extensions")]
	public AuthenticationExtensionsClientInputs Extensions;
}

[ToObject]
public partial class PublicKeyCredentialEntity
{
	[Value("name")]
	public required DOMString Name;
}

[ToObject]
public partial class PublicKeyCredentialRpEntity : PublicKeyCredentialEntity
{
	[Value("id")]
	public DOMString Id;
}

[ToObject]
public partial class PublicKeyCredentialUserEntity : PublicKeyCredentialEntity
{
	[Value("id")]
	public required BufferSource Id;
	[Value("displayName")]
	public required DOMString DisplayName;
}

[ToObject]
public partial class AuthenticatorSelectionCriteria
{
	[Value("authenticatorAttachment")]
	public DOMString AuthenticatorAttachment;
	[Value("residentKey")]
	public DOMString ResidentKey;
	[Value("requireResidentKey")]
	public bool RequireResidentKey;
	[Value("userVerification")]
	public DOMString UserVerification;
}

///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialrequestoptions/publickeycredentialrequestoptions.generated.xml' path='docs/PublicKeyCredentialRequestOptions/*'/>
[ToObject]
public partial class PublicKeyCredentialRequestOptions
{
	///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialrequestoptions/publickeycredentialrequestoptions.generated.xml' path='docs/PublicKeyCredentialRequestOptionsChallenge/*'/>
[Value("challenge")]
	public required BufferSource Challenge;
	///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialrequestoptions/publickeycredentialrequestoptions.generated.xml' path='docs/PublicKeyCredentialRequestOptionsTimeout/*'/>
[Value("timeout")]
	public ulong Timeout;
	///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialrequestoptions/publickeycredentialrequestoptions.generated.xml' path='docs/PublicKeyCredentialRequestOptionsRpId/*'/>
[Value("rpId")]
	public DOMString RpId;
	///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialrequestoptions/publickeycredentialrequestoptions.generated.xml' path='docs/PublicKeyCredentialRequestOptionsAllowCredentials/*'/>
[Value("allowCredentials")]
	public List<PublicKeyCredentialDescriptor> AllowCredentials;
	///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialrequestoptions/publickeycredentialrequestoptions.generated.xml' path='docs/PublicKeyCredentialRequestOptionsUserVerification/*'/>
[Value("userVerification")]
	public DOMString UserVerification;
	///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialrequestoptions/publickeycredentialrequestoptions.generated.xml' path='docs/PublicKeyCredentialRequestOptionsHints/*'/>
[Value("hints")]
	public List<DOMString> Hints;
	///<include file='CSharpToJavaScript/Utils/Docs/publickeycredentialrequestoptions/publickeycredentialrequestoptions.generated.xml' path='docs/PublicKeyCredentialRequestOptionsExtensions/*'/>
[Value("extensions")]
	public AuthenticationExtensionsClientInputs Extensions;
}

public partial class AuthenticationExtensionsClientInputs
{
}

public partial class AuthenticationExtensionsClientOutputs
{
}

[ToObject]
public partial class CollectedClientData
{
	[Value("type")]
	public required DOMString Type;
	[Value("challenge")]
	public required DOMString Challenge;
	[Value("origin")]
	public required DOMString Origin;
	[Value("crossOrigin")]
	public bool CrossOrigin;
	[Value("topOrigin")]
	public DOMString TopOrigin;
}

[ToObject]
public partial class TokenBinding
{
	[Value("status")]
	public required DOMString Status;
	[Value("id")]
	public DOMString Id;
}

[ToObject]
public partial class PublicKeyCredentialDescriptor
{
	[Value("type")]
	public required DOMString Type;
	[Value("id")]
	public required BufferSource Id;
	[Value("transports")]
	public List<DOMString> Transports;
}

public partial class AuthenticationExtensionsClientInputs
{
	[Value("appid")]
	public DOMString Appid;
}

public partial class AuthenticationExtensionsClientOutputs
{
	[Value("appid")]
	public bool Appid;
}

public partial class AuthenticationExtensionsClientInputs
{
	[Value("appidExclude")]
	public DOMString AppidExclude;
}

public partial class AuthenticationExtensionsClientOutputs
{
	[Value("appidExclude")]
	public bool AppidExclude;
}

public partial class AuthenticationExtensionsClientInputs
{
	[Value("credProps")]
	public bool CredProps;
}

[ToObject]
public partial class CredentialPropertiesOutput
{
	[Value("rk")]
	public bool Rk;
}

public partial class AuthenticationExtensionsClientOutputs
{
	[Value("credProps")]
	public CredentialPropertiesOutput CredProps;
}

[ToObject]
public partial class AuthenticationExtensionsPRFValues
{
	[Value("first")]
	public required BufferSource First;
	[Value("second")]
	public BufferSource Second;
}

[ToObject]
public partial class AuthenticationExtensionsPRFInputs
{
	[Value("eval")]
	public AuthenticationExtensionsPRFValues Eval;
	[Value("evalByCredential")]
	public Dictionary<DOMString, AuthenticationExtensionsPRFValues> EvalByCredential;
}

public partial class AuthenticationExtensionsClientInputs
{
	[Value("prf")]
	public AuthenticationExtensionsPRFInputs Prf;
}

[ToObject]
public partial class AuthenticationExtensionsPRFOutputs
{
	[Value("enabled")]
	public bool Enabled;
	[Value("results")]
	public AuthenticationExtensionsPRFValues Results;
}

public partial class AuthenticationExtensionsClientOutputs
{
	[Value("prf")]
	public AuthenticationExtensionsPRFOutputs Prf;
}

public partial class AuthenticationExtensionsClientInputs
{
	[Value("largeBlob")]
	public AuthenticationExtensionsLargeBlobInputs LargeBlob;
}

[ToObject]
public partial class AuthenticationExtensionsLargeBlobInputs
{
	[Value("support")]
	public DOMString Support;
	[Value("read")]
	public bool Read;
	[Value("write")]
	public BufferSource Write;
}

public partial class AuthenticationExtensionsClientOutputs
{
	[Value("largeBlob")]
	public AuthenticationExtensionsLargeBlobOutputs LargeBlob;
}

[ToObject]
public partial class AuthenticationExtensionsLargeBlobOutputs
{
	[Value("supported")]
	public bool Supported;
	[Value("blob")]
	public ArrayBuffer Blob;
	[Value("written")]
	public bool Written;
}

[ToObject]
public partial class AudioEncoderConfig
{
	[Value("aac")]
	public AacEncoderConfig Aac;
}

[ToObject]
public partial class AacEncoderConfig
{
	[Value("format")]
	public AacBitstreamFormat Format;
}

[ToObject]
public partial class VideoEncoderEncodeOptions
{
	[Value("av1")]
	public VideoEncoderEncodeOptionsForAv1 Av1;
}

[ToObject]
public partial class VideoEncoderEncodeOptionsForAv1
{
	[Value("quantizer")]
	public ushort? Quantizer;
}

[ToObject]
public partial class VideoEncoderConfig
{
	[Value("avc")]
	public AvcEncoderConfig Avc;
}

[ToObject]
public partial class AvcEncoderConfig
{
	[Value("format")]
	public AvcBitstreamFormat Format;
}

public partial class VideoEncoderEncodeOptions
{
	[Value("avc")]
	public VideoEncoderEncodeOptionsForAvc Avc;
}

[ToObject]
public partial class VideoEncoderEncodeOptionsForAvc
{
	[Value("quantizer")]
	public ushort? Quantizer;
}

public partial class AudioEncoderConfig
{
	[Value("flac")]
	public FlacEncoderConfig Flac;
}

[ToObject]
public partial class FlacEncoderConfig
{
	[Value("blockSize")]
	public ulong BlockSize;
	[Value("compressLevel")]
	public ulong CompressLevel;
}

public partial class VideoEncoderConfig
{
	[Value("hevc")]
	public HevcEncoderConfig Hevc;
}

[ToObject]
public partial class HevcEncoderConfig
{
	[Value("format")]
	public HevcBitstreamFormat Format;
}

public partial class VideoEncoderEncodeOptions
{
	[Value("hevc")]
	public VideoEncoderEncodeOptionsForHevc Hevc;
}

[ToObject]
public partial class VideoEncoderEncodeOptionsForHevc
{
	[Value("quantizer")]
	public ushort? Quantizer;
}

public partial class AudioEncoderConfig
{
	[Value("opus")]
	public OpusEncoderConfig Opus;
}

[ToObject]
public partial class OpusEncoderConfig
{
	[Value("format")]
	public OpusBitstreamFormat Format;
	[Value("signal")]
	public OpusSignal Signal;
	[Value("application")]
	public OpusApplication Application;
	[Value("frameDuration")]
	public ulong FrameDuration;
	[Value("complexity")]
	public ulong Complexity;
	[Value("packetlossperc")]
	public ulong Packetlossperc;
	[Value("useinbandfec")]
	public bool Useinbandfec;
	[Value("usedtx")]
	public bool Usedtx;
}

public partial class VideoEncoderEncodeOptions
{
	[Value("vp9")]
	public VideoEncoderEncodeOptionsForVp9 Vp9;
}

[ToObject]
public partial class VideoEncoderEncodeOptionsForVp9
{
	[Value("quantizer")]
	public ushort? Quantizer;
}

[ToObject]
public partial class AudioDecoderInit
{
	[Value("output")]
	public required AudioDataOutputCallback Output;
	[Value("error")]
	public required WebCodecsErrorCallback Error;
}

[ToObject]
public partial class VideoDecoderInit
{
	[Value("output")]
	public required VideoFrameOutputCallback Output;
	[Value("error")]
	public required WebCodecsErrorCallback Error;
}

[ToObject]
public partial class AudioEncoderInit
{
	[Value("output")]
	public required EncodedAudioChunkOutputCallback Output;
	[Value("error")]
	public required WebCodecsErrorCallback Error;
}

[ToObject]
public partial class EncodedAudioChunkMetadata
{
	[Value("decoderConfig")]
	public AudioDecoderConfig DecoderConfig;
}

[ToObject]
public partial class VideoEncoderInit
{
	[Value("output")]
	public required EncodedVideoChunkOutputCallback Output;
	[Value("error")]
	public required WebCodecsErrorCallback Error;
}

[ToObject]
public partial class EncodedVideoChunkMetadata
{
	[Value("decoderConfig")]
	public VideoDecoderConfig DecoderConfig;
	[Value("svc")]
	public SvcOutputMetadata Svc;
	[Value("alphaSideData")]
	public BufferSource AlphaSideData;
}

[ToObject]
public partial class SvcOutputMetadata
{
	[Value("temporalLayerId")]
	public ulong TemporalLayerId;
}

[ToObject]
public partial class AudioDecoderSupport
{
	[Value("supported")]
	public bool Supported;
	[Value("config")]
	public AudioDecoderConfig Config;
}

[ToObject]
public partial class VideoDecoderSupport
{
	[Value("supported")]
	public bool Supported;
	[Value("config")]
	public VideoDecoderConfig Config;
}

[ToObject]
public partial class AudioEncoderSupport
{
	[Value("supported")]
	public bool Supported;
	[Value("config")]
	public AudioEncoderConfig Config;
}

[ToObject]
public partial class VideoEncoderSupport
{
	[Value("supported")]
	public bool Supported;
	[Value("config")]
	public VideoEncoderConfig Config;
}

[ToObject]
public partial class AudioDecoderConfig
{
	[Value("codec")]
	public required DOMString Codec;
	[Value("sampleRate")]
	public required ulong SampleRate;
	[Value("numberOfChannels")]
	public required ulong NumberOfChannels;
	[Value("description")]
	public BufferSource Description;
}

[ToObject]
public partial class VideoDecoderConfig
{
	[Value("codec")]
	public required DOMString Codec;
	[Value("description")]
	public AllowSharedBufferSource Description;
	[Value("codedWidth")]
	public ulong CodedWidth;
	[Value("codedHeight")]
	public ulong CodedHeight;
	[Value("displayAspectWidth")]
	public ulong DisplayAspectWidth;
	[Value("displayAspectHeight")]
	public ulong DisplayAspectHeight;
	[Value("colorSpace")]
	public VideoColorSpaceInit ColorSpace;
	[Value("hardwareAcceleration")]
	public HardwareAcceleration HardwareAcceleration;
	[Value("optimizeForLatency")]
	public bool OptimizeForLatency;
}

public partial class AudioEncoderConfig
{
	[Value("codec")]
	public required DOMString Codec;
	[Value("sampleRate")]
	public required ulong SampleRate;
	[Value("numberOfChannels")]
	public required ulong NumberOfChannels;
	[Value("bitrate")]
	public ulong Bitrate;
	[Value("bitrateMode")]
	public BitrateMode BitrateMode;
}

public partial class VideoEncoderConfig
{
	[Value("codec")]
	public required DOMString Codec;
	[Value("width")]
	public required ulong Width;
	[Value("height")]
	public required ulong Height;
	[Value("displayWidth")]
	public ulong DisplayWidth;
	[Value("displayHeight")]
	public ulong DisplayHeight;
	[Value("bitrate")]
	public ulong Bitrate;
	[Value("framerate")]
	public Number Framerate;
	[Value("hardwareAcceleration")]
	public HardwareAcceleration HardwareAcceleration;
	[Value("alpha")]
	public AlphaOption Alpha;
	[Value("scalabilityMode")]
	public DOMString ScalabilityMode;
	[Value("bitrateMode")]
	public VideoEncoderBitrateMode BitrateMode;
	[Value("latencyMode")]
	public LatencyMode LatencyMode;
	[Value("contentHint")]
	public DOMString ContentHint;
}

public partial class VideoEncoderEncodeOptions
{
	[Value("keyFrame")]
	public bool KeyFrame;
}

[ToObject]
public partial class EncodedAudioChunkInit
{
	[Value("type")]
	public required EncodedAudioChunkType Type;
	[Value("timestamp")]
	public required long Timestamp;
	[Value("duration")]
	public ulong Duration;
	[Value("data")]
	public required AllowSharedBufferSource Data;
	[Value("transfer")]
	public List<ArrayBuffer> Transfer;
}

[ToObject]
public partial class EncodedVideoChunkInit
{
	[Value("type")]
	public required EncodedVideoChunkType Type;
	[Value("timestamp")]
	public required long Timestamp;
	[Value("duration")]
	public ulong Duration;
	[Value("data")]
	public required AllowSharedBufferSource Data;
	[Value("transfer")]
	public List<ArrayBuffer> Transfer;
}

[ToObject]
public partial class AudioDataInit
{
	[Value("format")]
	public required AudioSampleFormat Format;
	[Value("sampleRate")]
	public required Number SampleRate;
	[Value("numberOfFrames")]
	public required ulong NumberOfFrames;
	[Value("numberOfChannels")]
	public required ulong NumberOfChannels;
	[Value("timestamp")]
	public required long Timestamp;
	[Value("data")]
	public required BufferSource Data;
	[Value("transfer")]
	public List<ArrayBuffer> Transfer;
}

[ToObject]
public partial class AudioDataCopyToOptions
{
	[Value("planeIndex")]
	public required ulong PlaneIndex;
	[Value("frameOffset")]
	public ulong FrameOffset;
	[Value("frameCount")]
	public ulong FrameCount;
	[Value("format")]
	public AudioSampleFormat Format;
}

[ToObject]
public partial class VideoFrameInit
{
	[Value("duration")]
	public ulong Duration;
	[Value("timestamp")]
	public long Timestamp;
	[Value("alpha")]
	public AlphaOption Alpha;
	[Value("visibleRect")]
	public DOMRectInit VisibleRect;
	[Value("rotation")]
	public Number Rotation;
	[Value("flip")]
	public bool Flip;
	[Value("displayWidth")]
	public ulong DisplayWidth;
	[Value("displayHeight")]
	public ulong DisplayHeight;
	[Value("metadata")]
	public VideoFrameMetadata Metadata;
}

[ToObject]
public partial class VideoFrameBufferInit
{
	[Value("format")]
	public required VideoPixelFormat Format;
	[Value("codedWidth")]
	public required ulong CodedWidth;
	[Value("codedHeight")]
	public required ulong CodedHeight;
	[Value("timestamp")]
	public required long Timestamp;
	[Value("duration")]
	public ulong Duration;
	[Value("layout")]
	public List<PlaneLayout> Layout;
	[Value("visibleRect")]
	public DOMRectInit VisibleRect;
	[Value("rotation")]
	public Number Rotation;
	[Value("flip")]
	public bool Flip;
	[Value("displayWidth")]
	public ulong DisplayWidth;
	[Value("displayHeight")]
	public ulong DisplayHeight;
	[Value("colorSpace")]
	public VideoColorSpaceInit ColorSpace;
	[Value("transfer")]
	public List<ArrayBuffer> Transfer;
	[Value("metadata")]
	public VideoFrameMetadata Metadata;
}

[ToObject]
public partial class VideoFrameMetadata
{
}

[ToObject]
public partial class VideoFrameCopyToOptions
{
	[Value("rect")]
	public DOMRectInit Rect;
	[Value("layout")]
	public List<PlaneLayout> Layout;
	[Value("format")]
	public VideoPixelFormat Format;
	[Value("colorSpace")]
	public PredefinedColorSpace ColorSpace;
}

[ToObject]
public partial class PlaneLayout
{
	[Value("offset")]
	public required ulong Offset;
	[Value("stride")]
	public required ulong Stride;
}

[ToObject]
public partial class VideoColorSpaceInit
{
	[Value("primaries")]
	public VideoColorPrimaries? Primaries;
	[Value("transfer")]
	public VideoTransferCharacteristics? Transfer;
	[Value("matrix")]
	public VideoMatrixCoefficients? Matrix;
	[Value("fullRange")]
	public bool? FullRange;
}

[ToObject]
public partial class ImageDecoderInit
{
	[Value("type")]
	public required DOMString Type;
	[Value("data")]
	public required ImageBufferSource Data;
	[Value("colorSpaceConversion")]
	public ColorSpaceConversion ColorSpaceConversion;
	[Value("desiredWidth")]
	public ulong DesiredWidth;
	[Value("desiredHeight")]
	public ulong DesiredHeight;
	[Value("preferAnimation")]
	public bool PreferAnimation;
	[Value("transfer")]
	public List<ArrayBuffer> Transfer;
}

[ToObject]
public partial class ImageDecodeOptions
{
	[Value("frameIndex")]
	public ulong FrameIndex;
	[Value("completeFramesOnly")]
	public bool CompleteFramesOnly;
}

[ToObject]
public partial class ImageDecodeResult
{
	[Value("image")]
	public required VideoFrame Image;
	[Value("complete")]
	public required bool Complete;
}

[ToObject]
public partial class Ed448Params : Algorithm
{
	[Value("context")]
	public BufferSource Context;
}

[ToObject]
public partial class Algorithm
{
	[Value("name")]
	public required DOMString Name;
}

[ToObject]
public partial class KeyAlgorithm
{
	[Value("name")]
	public required DOMString Name;
}

[ToObject]
public partial class RsaOtherPrimesInfo
{
	[Value("r")]
	public DOMString R;
	[Value("d")]
	public DOMString D;
	[Value("t")]
	public DOMString T;
}

[ToObject]
public partial class JsonWebKey
{
	[Value("kty")]
	public DOMString Kty;
	[Value("use")]
	public DOMString Use;
	[Value("key_ops")]
	public List<DOMString> Key_ops;
	[Value("alg")]
	public DOMString Alg;
	[Value("ext")]
	public bool Ext;
	[Value("crv")]
	public DOMString Crv;
	[Value("x")]
	public DOMString X;
	[Value("y")]
	public DOMString Y;
	[Value("d")]
	public DOMString D;
	[Value("n")]
	public DOMString N;
	[Value("e")]
	public DOMString E;
	[Value("p")]
	public DOMString P;
	[Value("q")]
	public DOMString Q;
	[Value("dp")]
	public DOMString Dp;
	[Value("dq")]
	public DOMString Dq;
	[Value("qi")]
	public DOMString Qi;
	[Value("oth")]
	public List<RsaOtherPrimesInfo> Oth;
	[Value("k")]
	public DOMString K;
}


///<include file='CSharpToJavaScript/Utils/Docs/cryptokeypair/cryptokeypair.generated.xml' path='docs/CryptoKeyPair/*'/>
[ToObject]
public partial class CryptoKeyPair
{
	///<include file='CSharpToJavaScript/Utils/Docs/cryptokeypair/cryptokeypair.generated.xml' path='docs/CryptoKeyPairPublicKey/*'/>
[Value("publicKey")]
	public CryptoKey PublicKey;
	///<include file='CSharpToJavaScript/Utils/Docs/cryptokeypair/cryptokeypair.generated.xml' path='docs/CryptoKeyPairPrivateKey/*'/>
[Value("privateKey")]
	public CryptoKey PrivateKey;
}

[ToObject]
public partial class RsaKeyGenParams : Algorithm
{
	[Value("modulusLength")]
	public required ulong ModulusLength;
	[Value("publicExponent")]
	public required BigInteger PublicExponent;
}

///<include file='CSharpToJavaScript/Utils/Docs/rsahashedkeygenparams/rsahashedkeygenparams.generated.xml' path='docs/RsaHashedKeyGenParams/*'/>
[ToObject]
public partial class RsaHashedKeyGenParams : RsaKeyGenParams
{
	///<include file='CSharpToJavaScript/Utils/Docs/rsahashedkeygenparams/rsahashedkeygenparams.generated.xml' path='docs/RsaHashedKeyGenParamsHash/*'/>
[Value("hash")]
	public required HashAlgorithmIdentifier Hash;
}

[ToObject]
public partial class RsaKeyAlgorithm : KeyAlgorithm
{
	[Value("modulusLength")]
	public required ulong ModulusLength;
	[Value("publicExponent")]
	public required BigInteger PublicExponent;
}

[ToObject]
public partial class RsaHashedKeyAlgorithm : RsaKeyAlgorithm
{
	[Value("hash")]
	public required KeyAlgorithm Hash;
}

///<include file='CSharpToJavaScript/Utils/Docs/rsahashedimportparams/rsahashedimportparams.generated.xml' path='docs/RsaHashedImportParams/*'/>
[ToObject]
public partial class RsaHashedImportParams : Algorithm
{
	///<include file='CSharpToJavaScript/Utils/Docs/rsahashedimportparams/rsahashedimportparams.generated.xml' path='docs/RsaHashedImportParamsHash/*'/>
[Value("hash")]
	public required HashAlgorithmIdentifier Hash;
}

///<include file='CSharpToJavaScript/Utils/Docs/rsapssparams/rsapssparams.generated.xml' path='docs/RsaPssParams/*'/>
[ToObject]
public partial class RsaPssParams : Algorithm
{
	///<include file='CSharpToJavaScript/Utils/Docs/rsapssparams/rsapssparams.generated.xml' path='docs/RsaPssParamsSaltLength/*'/>
[Value("saltLength")]
	public required ulong SaltLength;
}

///<include file='CSharpToJavaScript/Utils/Docs/rsaoaepparams/rsaoaepparams.generated.xml' path='docs/RsaOaepParams/*'/>
[ToObject]
public partial class RsaOaepParams : Algorithm
{
	///<include file='CSharpToJavaScript/Utils/Docs/rsaoaepparams/rsaoaepparams.generated.xml' path='docs/RsaOaepParamsLabel/*'/>
[Value("label")]
	public BufferSource Label;
}

///<include file='CSharpToJavaScript/Utils/Docs/ecdsaparams/ecdsaparams.generated.xml' path='docs/EcdsaParams/*'/>
[ToObject]
public partial class EcdsaParams : Algorithm
{
	///<include file='CSharpToJavaScript/Utils/Docs/ecdsaparams/ecdsaparams.generated.xml' path='docs/EcdsaParamsHash/*'/>
[Value("hash")]
	public required HashAlgorithmIdentifier Hash;
}


///<include file='CSharpToJavaScript/Utils/Docs/eckeygenparams/eckeygenparams.generated.xml' path='docs/EcKeyGenParams/*'/>
[ToObject]
public partial class EcKeyGenParams : Algorithm
{
	///<include file='CSharpToJavaScript/Utils/Docs/eckeygenparams/eckeygenparams.generated.xml' path='docs/EcKeyGenParamsNamedCurve/*'/>
[Value("namedCurve")]
	public required NamedCurve NamedCurve;
}

[ToObject]
public partial class EcKeyAlgorithm : KeyAlgorithm
{
	[Value("namedCurve")]
	public required NamedCurve NamedCurve;
}

///<include file='CSharpToJavaScript/Utils/Docs/eckeyimportparams/eckeyimportparams.generated.xml' path='docs/EcKeyImportParams/*'/>
[ToObject]
public partial class EcKeyImportParams : Algorithm
{
	///<include file='CSharpToJavaScript/Utils/Docs/eckeyimportparams/eckeyimportparams.generated.xml' path='docs/EcKeyImportParamsNamedCurve/*'/>
[Value("namedCurve")]
	public required NamedCurve NamedCurve;
}

///<include file='CSharpToJavaScript/Utils/Docs/ecdhkeyderiveparams/ecdhkeyderiveparams.generated.xml' path='docs/EcdhKeyDeriveParams/*'/>
[ToObject]
public partial class EcdhKeyDeriveParams : Algorithm
{
	///<include file='CSharpToJavaScript/Utils/Docs/ecdhkeyderiveparams/ecdhkeyderiveparams.generated.xml' path='docs/EcdhKeyDeriveParamsPublic/*'/>
[Value("public")]
	public required CryptoKey Public;
}

///<include file='CSharpToJavaScript/Utils/Docs/aesctrparams/aesctrparams.generated.xml' path='docs/AesCtrParams/*'/>
[ToObject]
public partial class AesCtrParams : Algorithm
{
	///<include file='CSharpToJavaScript/Utils/Docs/aesctrparams/aesctrparams.generated.xml' path='docs/AesCtrParamsCounter/*'/>
[Value("counter")]
	public required BufferSource Counter;
	///<include file='CSharpToJavaScript/Utils/Docs/aesctrparams/aesctrparams.generated.xml' path='docs/AesCtrParamsLength/*'/>
[Value("length")]
	public required byte Length;
}

[ToObject]
public partial class AesKeyAlgorithm : KeyAlgorithm
{
	[Value("length")]
	public required ushort Length;
}

///<include file='CSharpToJavaScript/Utils/Docs/aeskeygenparams/aeskeygenparams.generated.xml' path='docs/AesKeyGenParams/*'/>
[ToObject]
public partial class AesKeyGenParams : Algorithm
{
	///<include file='CSharpToJavaScript/Utils/Docs/aeskeygenparams/aeskeygenparams.generated.xml' path='docs/AesKeyGenParamsLength/*'/>
[Value("length")]
	public required ushort Length;
}

[ToObject]
public partial class AesDerivedKeyParams : Algorithm
{
	[Value("length")]
	public required ushort Length;
}

///<include file='CSharpToJavaScript/Utils/Docs/aescbcparams/aescbcparams.generated.xml' path='docs/AesCbcParams/*'/>
[ToObject]
public partial class AesCbcParams : Algorithm
{
	///<include file='CSharpToJavaScript/Utils/Docs/aescbcparams/aescbcparams.generated.xml' path='docs/AesCbcParamsIv/*'/>
[Value("iv")]
	public required BufferSource Iv;
}

///<include file='CSharpToJavaScript/Utils/Docs/aesgcmparams/aesgcmparams.generated.xml' path='docs/AesGcmParams/*'/>
[ToObject]
public partial class AesGcmParams : Algorithm
{
	///<include file='CSharpToJavaScript/Utils/Docs/aesgcmparams/aesgcmparams.generated.xml' path='docs/AesGcmParamsIv/*'/>
[Value("iv")]
	public required BufferSource Iv;
	///<include file='CSharpToJavaScript/Utils/Docs/aesgcmparams/aesgcmparams.generated.xml' path='docs/AesGcmParamsAdditionalData/*'/>
[Value("additionalData")]
	public BufferSource AdditionalData;
	///<include file='CSharpToJavaScript/Utils/Docs/aesgcmparams/aesgcmparams.generated.xml' path='docs/AesGcmParamsTagLength/*'/>
[Value("tagLength")]
	public byte TagLength;
}

///<include file='CSharpToJavaScript/Utils/Docs/hmacimportparams/hmacimportparams.generated.xml' path='docs/HmacImportParams/*'/>
[ToObject]
public partial class HmacImportParams : Algorithm
{
	///<include file='CSharpToJavaScript/Utils/Docs/hmacimportparams/hmacimportparams.generated.xml' path='docs/HmacImportParamsHash/*'/>
[Value("hash")]
	public required HashAlgorithmIdentifier Hash;
	///<include file='CSharpToJavaScript/Utils/Docs/hmacimportparams/hmacimportparams.generated.xml' path='docs/HmacImportParamsLength/*'/>
[Value("length")]
	public ulong Length;
}

[ToObject]
public partial class HmacKeyAlgorithm : KeyAlgorithm
{
	[Value("hash")]
	public required KeyAlgorithm Hash;
	[Value("length")]
	public required ulong Length;
}

///<include file='CSharpToJavaScript/Utils/Docs/hmackeygenparams/hmackeygenparams.generated.xml' path='docs/HmacKeyGenParams/*'/>
[ToObject]
public partial class HmacKeyGenParams : Algorithm
{
	///<include file='CSharpToJavaScript/Utils/Docs/hmackeygenparams/hmackeygenparams.generated.xml' path='docs/HmacKeyGenParamsHash/*'/>
[Value("hash")]
	public required HashAlgorithmIdentifier Hash;
	///<include file='CSharpToJavaScript/Utils/Docs/hmackeygenparams/hmackeygenparams.generated.xml' path='docs/HmacKeyGenParamsLength/*'/>
[Value("length")]
	public ulong Length;
}

///<include file='CSharpToJavaScript/Utils/Docs/hkdfparams/hkdfparams.generated.xml' path='docs/HkdfParams/*'/>
[ToObject]
public partial class HkdfParams : Algorithm
{
	///<include file='CSharpToJavaScript/Utils/Docs/hkdfparams/hkdfparams.generated.xml' path='docs/HkdfParamsHash/*'/>
[Value("hash")]
	public required HashAlgorithmIdentifier Hash;
	///<include file='CSharpToJavaScript/Utils/Docs/hkdfparams/hkdfparams.generated.xml' path='docs/HkdfParamsSalt/*'/>
[Value("salt")]
	public required BufferSource Salt;
	///<include file='CSharpToJavaScript/Utils/Docs/hkdfparams/hkdfparams.generated.xml' path='docs/HkdfParamsInfo/*'/>
[Value("info")]
	public required BufferSource Info;
}

///<include file='CSharpToJavaScript/Utils/Docs/pbkdf2params/pbkdf2params.generated.xml' path='docs/Pbkdf2Params/*'/>
[ToObject]
public partial class Pbkdf2Params : Algorithm
{
	///<include file='CSharpToJavaScript/Utils/Docs/pbkdf2params/pbkdf2params.generated.xml' path='docs/Pbkdf2ParamsSalt/*'/>
[Value("salt")]
	public required BufferSource Salt;
	///<include file='CSharpToJavaScript/Utils/Docs/pbkdf2params/pbkdf2params.generated.xml' path='docs/Pbkdf2ParamsIterations/*'/>
[Value("iterations")]
	public required ulong Iterations;
	///<include file='CSharpToJavaScript/Utils/Docs/pbkdf2params/pbkdf2params.generated.xml' path='docs/Pbkdf2ParamsHash/*'/>
[Value("hash")]
	public required HashAlgorithmIdentifier Hash;
}

[ToObject]
public partial class WebGLContextAttributes
{
	[Value("alpha")]
	public bool Alpha;
	[Value("depth")]
	public bool Depth;
	[Value("stencil")]
	public bool Stencil;
	[Value("antialias")]
	public bool Antialias;
	[Value("premultipliedAlpha")]
	public bool PremultipliedAlpha;
	[Value("preserveDrawingBuffer")]
	public bool PreserveDrawingBuffer;
	[Value("powerPreference")]
	public WebGLPowerPreference PowerPreference;
	[Value("failIfMajorPerformanceCaveat")]
	public bool FailIfMajorPerformanceCaveat;
	[Value("desynchronized")]
	public bool Desynchronized;
}

[ToObject]
public partial class WebGLContextEventInit : EventInit
{
	[Value("statusMessage")]
	public DOMString StatusMessage;
}



[ToObject]
public partial class GPUObjectDescriptorBase
{
	[Value("label")]
	public USVString Label;
}

[ToObject]
public partial class GPURequestAdapterOptions
{
	[Value("featureLevel")]
	public DOMString FeatureLevel;
	[Value("powerPreference")]
	public GPUPowerPreference PowerPreference;
	[Value("forceFallbackAdapter")]
	public bool ForceFallbackAdapter;
	[Value("xrCompatible")]
	public bool XrCompatible;
}

[ToObject]
public partial class GPUDeviceDescriptor : GPUObjectDescriptorBase
{
	[Value("requiredFeatures")]
	public List<GPUFeatureName> RequiredFeatures;
	[Value("requiredLimits")]
	public Dictionary<DOMString, GPUSize64> RequiredLimits;
	[Value("defaultQueue")]
	public GPUQueueDescriptor DefaultQueue;
}

[ToObject]
public partial class GPUBufferDescriptor : GPUObjectDescriptorBase
{
	[Value("size")]
	public required GPUSize64 Size;
	[Value("usage")]
	public required GPUBufferUsageFlags Usage;
	[Value("mappedAtCreation")]
	public bool MappedAtCreation;
}


[ToObject]
public partial class GPUTextureDescriptor : GPUObjectDescriptorBase
{
	[Value("size")]
	public required GPUExtent3D Size;
	[Value("mipLevelCount")]
	public GPUIntegerCoordinate MipLevelCount;
	[Value("sampleCount")]
	public GPUSize32 SampleCount;
	[Value("dimension")]
	public GPUTextureDimension Dimension;
	[Value("format")]
	public required GPUTextureFormat Format;
	[Value("usage")]
	public required GPUTextureUsageFlags Usage;
	[Value("viewFormats")]
	public List<GPUTextureFormat> ViewFormats;
}

[ToObject]
public partial class GPUTextureViewDescriptor : GPUObjectDescriptorBase
{
	[Value("format")]
	public GPUTextureFormat Format;
	[Value("dimension")]
	public GPUTextureViewDimension Dimension;
	[Value("usage")]
	public GPUTextureUsageFlags Usage;
	[Value("aspect")]
	public GPUTextureAspect Aspect;
	[Value("baseMipLevel")]
	public GPUIntegerCoordinate BaseMipLevel;
	[Value("mipLevelCount")]
	public GPUIntegerCoordinate MipLevelCount;
	[Value("baseArrayLayer")]
	public GPUIntegerCoordinate BaseArrayLayer;
	[Value("arrayLayerCount")]
	public GPUIntegerCoordinate ArrayLayerCount;
}

[ToObject]
public partial class GPUExternalTextureDescriptor : GPUObjectDescriptorBase
{
	[Value("source")]
	public required Union213 Source;
	[Value("colorSpace")]
	public PredefinedColorSpace ColorSpace;
}

[ToObject]
public partial class GPUSamplerDescriptor : GPUObjectDescriptorBase
{
	[Value("addressModeU")]
	public GPUAddressMode AddressModeU;
	[Value("addressModeV")]
	public GPUAddressMode AddressModeV;
	[Value("addressModeW")]
	public GPUAddressMode AddressModeW;
	[Value("magFilter")]
	public GPUFilterMode MagFilter;
	[Value("minFilter")]
	public GPUFilterMode MinFilter;
	[Value("mipmapFilter")]
	public GPUMipmapFilterMode MipmapFilter;
	[Value("lodMinClamp")]
	public Number LodMinClamp;
	[Value("lodMaxClamp")]
	public Number LodMaxClamp;
	[Value("compare")]
	public GPUCompareFunction Compare;
	[Value("maxAnisotropy")]
	public ushort MaxAnisotropy;
}

[ToObject]
public partial class GPUBindGroupLayoutDescriptor : GPUObjectDescriptorBase
{
	[Value("entries")]
	public required List<GPUBindGroupLayoutEntry> Entries;
}

[ToObject]
public partial class GPUBindGroupLayoutEntry
{
	[Value("binding")]
	public required GPUIndex32 Binding;
	[Value("visibility")]
	public required GPUShaderStageFlags Visibility;
	[Value("buffer")]
	public GPUBufferBindingLayout Buffer;
	[Value("sampler")]
	public GPUSamplerBindingLayout Sampler;
	[Value("texture")]
	public GPUTextureBindingLayout Texture;
	[Value("storageTexture")]
	public GPUStorageTextureBindingLayout StorageTexture;
	[Value("externalTexture")]
	public GPUExternalTextureBindingLayout ExternalTexture;
}


[ToObject]
public partial class GPUBufferBindingLayout
{
	[Value("type")]
	public GPUBufferBindingType Type;
	[Value("hasDynamicOffset")]
	public bool HasDynamicOffset;
	[Value("minBindingSize")]
	public GPUSize64 MinBindingSize;
}

[ToObject]
public partial class GPUSamplerBindingLayout
{
	[Value("type")]
	public GPUSamplerBindingType Type;
}

[ToObject]
public partial class GPUTextureBindingLayout
{
	[Value("sampleType")]
	public GPUTextureSampleType SampleType;
	[Value("viewDimension")]
	public GPUTextureViewDimension ViewDimension;
	[Value("multisampled")]
	public bool Multisampled;
}

[ToObject]
public partial class GPUStorageTextureBindingLayout
{
	[Value("access")]
	public GPUStorageTextureAccess Access;
	[Value("format")]
	public required GPUTextureFormat Format;
	[Value("viewDimension")]
	public GPUTextureViewDimension ViewDimension;
}

[ToObject]
public partial class GPUExternalTextureBindingLayout
{
}

[ToObject]
public partial class GPUBindGroupDescriptor : GPUObjectDescriptorBase
{
	[Value("layout")]
	public required GPUBindGroupLayout Layout;
	[Value("entries")]
	public required List<GPUBindGroupEntry> Entries;
}


[ToObject]
public partial class GPUBindGroupEntry
{
	[Value("binding")]
	public required GPUIndex32 Binding;
	[Value("resource")]
	public required GPUBindingResource Resource;
}

[ToObject]
public partial class GPUBufferBinding
{
	[Value("buffer")]
	public required GPUBuffer Buffer;
	[Value("offset")]
	public GPUSize64 Offset;
	[Value("size")]
	public GPUSize64 Size;
}

[ToObject]
public partial class GPUPipelineLayoutDescriptor : GPUObjectDescriptorBase
{
	[Value("bindGroupLayouts")]
	public required List<GPUBindGroupLayout?> BindGroupLayouts;
}

[ToObject]
public partial class GPUShaderModuleDescriptor : GPUObjectDescriptorBase
{
	[Value("code")]
	public required USVString Code;
	[Value("compilationHints")]
	public List<GPUShaderModuleCompilationHint> CompilationHints;
}

[ToObject]
public partial class GPUShaderModuleCompilationHint
{
	[Value("entryPoint")]
	public required USVString EntryPoint;
	[Value("layout")]
	public Union215 Layout;
}

[ToObject]
public partial class GPUPipelineErrorInit
{
	[Value("reason")]
	public required GPUPipelineErrorReason Reason;
}

[ToObject]
public partial class GPUPipelineDescriptorBase : GPUObjectDescriptorBase
{
	[Value("layout")]
	public required Union216 Layout;
}

[ToObject]
public partial class GPUProgrammableStage
{
	[Value("module")]
	public required GPUShaderModule Module;
	[Value("entryPoint")]
	public USVString EntryPoint;
	[Value("constants")]
	public Dictionary<USVString, GPUPipelineConstantValue> Constants;
}


[ToObject]
public partial class GPUComputePipelineDescriptor : GPUPipelineDescriptorBase
{
	[Value("compute")]
	public required GPUProgrammableStage Compute;
}

[ToObject]
public partial class GPURenderPipelineDescriptor : GPUPipelineDescriptorBase
{
	[Value("vertex")]
	public required GPUVertexState Vertex;
	[Value("primitive")]
	public GPUPrimitiveState Primitive;
	[Value("depthStencil")]
	public GPUDepthStencilState DepthStencil;
	[Value("multisample")]
	public GPUMultisampleState Multisample;
	[Value("fragment")]
	public GPUFragmentState Fragment;
}

[ToObject]
public partial class GPUPrimitiveState
{
	[Value("topology")]
	public GPUPrimitiveTopology Topology;
	[Value("stripIndexFormat")]
	public GPUIndexFormat StripIndexFormat;
	[Value("frontFace")]
	public GPUFrontFace FrontFace;
	[Value("cullMode")]
	public GPUCullMode CullMode;
	[Value("unclippedDepth")]
	public bool UnclippedDepth;
}

[ToObject]
public partial class GPUMultisampleState
{
	[Value("count")]
	public GPUSize32 Count;
	[Value("mask")]
	public GPUSampleMask Mask;
	[Value("alphaToCoverageEnabled")]
	public bool AlphaToCoverageEnabled;
}

[ToObject]
public partial class GPUFragmentState : GPUProgrammableStage
{
	[Value("targets")]
	public required List<GPUColorTargetState?> Targets;
}

[ToObject]
public partial class GPUColorTargetState
{
	[Value("format")]
	public required GPUTextureFormat Format;
	[Value("blend")]
	public GPUBlendState Blend;
	[Value("writeMask")]
	public GPUColorWriteFlags WriteMask;
}

[ToObject]
public partial class GPUBlendState
{
	[Value("color")]
	public required GPUBlendComponent Color;
	[Value("alpha")]
	public required GPUBlendComponent Alpha;
}


[ToObject]
public partial class GPUBlendComponent
{
	[Value("operation")]
	public GPUBlendOperation Operation;
	[Value("srcFactor")]
	public GPUBlendFactor SrcFactor;
	[Value("dstFactor")]
	public GPUBlendFactor DstFactor;
}

[ToObject]
public partial class GPUDepthStencilState
{
	[Value("format")]
	public required GPUTextureFormat Format;
	[Value("depthWriteEnabled")]
	public bool DepthWriteEnabled;
	[Value("depthCompare")]
	public GPUCompareFunction DepthCompare;
	[Value("stencilFront")]
	public GPUStencilFaceState StencilFront;
	[Value("stencilBack")]
	public GPUStencilFaceState StencilBack;
	[Value("stencilReadMask")]
	public GPUStencilValue StencilReadMask;
	[Value("stencilWriteMask")]
	public GPUStencilValue StencilWriteMask;
	[Value("depthBias")]
	public GPUDepthBias DepthBias;
	[Value("depthBiasSlopeScale")]
	public Number DepthBiasSlopeScale;
	[Value("depthBiasClamp")]
	public Number DepthBiasClamp;
}

[ToObject]
public partial class GPUStencilFaceState
{
	[Value("compare")]
	public GPUCompareFunction Compare;
	[Value("failOp")]
	public GPUStencilOperation FailOp;
	[Value("depthFailOp")]
	public GPUStencilOperation DepthFailOp;
	[Value("passOp")]
	public GPUStencilOperation PassOp;
}

[ToObject]
public partial class GPUVertexState : GPUProgrammableStage
{
	[Value("buffers")]
	public List<GPUVertexBufferLayout?> Buffers;
}

[ToObject]
public partial class GPUVertexBufferLayout
{
	[Value("arrayStride")]
	public required GPUSize64 ArrayStride;
	[Value("stepMode")]
	public GPUVertexStepMode StepMode;
	[Value("attributes")]
	public required List<GPUVertexAttribute> Attributes;
}

[ToObject]
public partial class GPUVertexAttribute
{
	[Value("format")]
	public required GPUVertexFormat Format;
	[Value("offset")]
	public required GPUSize64 Offset;
	[Value("shaderLocation")]
	public required GPUIndex32 ShaderLocation;
}

[ToObject]
public partial class GPUTexelCopyBufferLayout
{
	[Value("offset")]
	public GPUSize64 Offset;
	[Value("bytesPerRow")]
	public GPUSize32 BytesPerRow;
	[Value("rowsPerImage")]
	public GPUSize32 RowsPerImage;
}

[ToObject]
public partial class GPUTexelCopyBufferInfo : GPUTexelCopyBufferLayout
{
	[Value("buffer")]
	public required GPUBuffer Buffer;
}

[ToObject]
public partial class GPUTexelCopyTextureInfo
{
	[Value("texture")]
	public required GPUTexture Texture;
	[Value("mipLevel")]
	public GPUIntegerCoordinate MipLevel;
	[Value("origin")]
	public GPUOrigin3D Origin;
	[Value("aspect")]
	public GPUTextureAspect Aspect;
}

[ToObject]
public partial class GPUCopyExternalImageDestInfo : GPUTexelCopyTextureInfo
{
	[Value("colorSpace")]
	public PredefinedColorSpace ColorSpace;
	[Value("premultipliedAlpha")]
	public bool PremultipliedAlpha;
}


[ToObject]
public partial class GPUCopyExternalImageSourceInfo
{
	[Value("source")]
	public required GPUCopyExternalImageSource Source;
	[Value("origin")]
	public GPUOrigin2D Origin;
	[Value("flipY")]
	public bool FlipY;
}

[ToObject]
public partial class GPUCommandBufferDescriptor : GPUObjectDescriptorBase
{
}

[ToObject]
public partial class GPUCommandEncoderDescriptor : GPUObjectDescriptorBase
{
}

[ToObject]
public partial class GPUComputePassTimestampWrites
{
	[Value("querySet")]
	public required GPUQuerySet QuerySet;
	[Value("beginningOfPassWriteIndex")]
	public GPUSize32 BeginningOfPassWriteIndex;
	[Value("endOfPassWriteIndex")]
	public GPUSize32 EndOfPassWriteIndex;
}

[ToObject]
public partial class GPUComputePassDescriptor : GPUObjectDescriptorBase
{
	[Value("timestampWrites")]
	public GPUComputePassTimestampWrites TimestampWrites;
}

[ToObject]
public partial class GPURenderPassTimestampWrites
{
	[Value("querySet")]
	public required GPUQuerySet QuerySet;
	[Value("beginningOfPassWriteIndex")]
	public GPUSize32 BeginningOfPassWriteIndex;
	[Value("endOfPassWriteIndex")]
	public GPUSize32 EndOfPassWriteIndex;
}

[ToObject]
public partial class GPURenderPassDescriptor : GPUObjectDescriptorBase
{
	[Value("colorAttachments")]
	public required List<GPURenderPassColorAttachment?> ColorAttachments;
	[Value("depthStencilAttachment")]
	public GPURenderPassDepthStencilAttachment DepthStencilAttachment;
	[Value("occlusionQuerySet")]
	public GPUQuerySet OcclusionQuerySet;
	[Value("timestampWrites")]
	public GPURenderPassTimestampWrites TimestampWrites;
	[Value("maxDrawCount")]
	public GPUSize64 MaxDrawCount;
}

[ToObject]
public partial class GPURenderPassColorAttachment
{
	[Value("view")]
	public required GPUTextureView View;
	[Value("depthSlice")]
	public GPUIntegerCoordinate DepthSlice;
	[Value("resolveTarget")]
	public GPUTextureView ResolveTarget;
	[Value("clearValue")]
	public GPUColor ClearValue;
	[Value("loadOp")]
	public required GPULoadOp LoadOp;
	[Value("storeOp")]
	public required GPUStoreOp StoreOp;
}

[ToObject]
public partial class GPURenderPassDepthStencilAttachment
{
	[Value("view")]
	public required GPUTextureView View;
	[Value("depthClearValue")]
	public Number DepthClearValue;
	[Value("depthLoadOp")]
	public GPULoadOp DepthLoadOp;
	[Value("depthStoreOp")]
	public GPUStoreOp DepthStoreOp;
	[Value("depthReadOnly")]
	public bool DepthReadOnly;
	[Value("stencilClearValue")]
	public GPUStencilValue StencilClearValue;
	[Value("stencilLoadOp")]
	public GPULoadOp StencilLoadOp;
	[Value("stencilStoreOp")]
	public GPUStoreOp StencilStoreOp;
	[Value("stencilReadOnly")]
	public bool StencilReadOnly;
}

[ToObject]
public partial class GPURenderPassLayout : GPUObjectDescriptorBase
{
	[Value("colorFormats")]
	public required List<GPUTextureFormat?> ColorFormats;
	[Value("depthStencilFormat")]
	public GPUTextureFormat DepthStencilFormat;
	[Value("sampleCount")]
	public GPUSize32 SampleCount;
}

[ToObject]
public partial class GPURenderBundleDescriptor : GPUObjectDescriptorBase
{
}

[ToObject]
public partial class GPURenderBundleEncoderDescriptor : GPURenderPassLayout
{
	[Value("depthReadOnly")]
	public bool DepthReadOnly;
	[Value("stencilReadOnly")]
	public bool StencilReadOnly;
}

[ToObject]
public partial class GPUQueueDescriptor : GPUObjectDescriptorBase
{
}

[ToObject]
public partial class GPUQuerySetDescriptor : GPUObjectDescriptorBase
{
	[Value("type")]
	public required GPUQueryType Type;
	[Value("count")]
	public required GPUSize32 Count;
}

[ToObject]
public partial class GPUCanvasToneMapping
{
	[Value("mode")]
	public GPUCanvasToneMappingMode Mode;
}

[ToObject]
public partial class GPUCanvasConfiguration
{
	[Value("device")]
	public required GPUDevice Device;
	[Value("format")]
	public required GPUTextureFormat Format;
	[Value("usage")]
	public GPUTextureUsageFlags Usage;
	[Value("viewFormats")]
	public List<GPUTextureFormat> ViewFormats;
	[Value("colorSpace")]
	public PredefinedColorSpace ColorSpace;
	[Value("toneMapping")]
	public GPUCanvasToneMapping ToneMapping;
	[Value("alphaMode")]
	public GPUCanvasAlphaMode AlphaMode;
}

[ToObject]
public partial class GPUUncapturedErrorEventInit : EventInit
{
	[Value("error")]
	public required GPUError Error;
}

[ToObject]
public partial class GPUColorDict
{
	[Value("r")]
	public required Number R;
	[Value("g")]
	public required Number G;
	[Value("b")]
	public required Number B;
	[Value("a")]
	public required Number A;
}


[ToObject]
public partial class GPUOrigin2DDict
{
	[Value("x")]
	public GPUIntegerCoordinate X;
	[Value("y")]
	public GPUIntegerCoordinate Y;
}


[ToObject]
public partial class GPUOrigin3DDict
{
	[Value("x")]
	public GPUIntegerCoordinate X;
	[Value("y")]
	public GPUIntegerCoordinate Y;
	[Value("z")]
	public GPUIntegerCoordinate Z;
}


[ToObject]
public partial class GPUExtent3DDict
{
	[Value("width")]
	public required GPUIntegerCoordinate Width;
	[Value("height")]
	public GPUIntegerCoordinate Height;
	[Value("depthOrArrayLayers")]
	public GPUIntegerCoordinate DepthOrArrayLayers;
}


[ToObject]
public partial class HIDDeviceRequestOptions
{
	[Value("filters")]
	public required List<HIDDeviceFilter> Filters;
	[Value("exclusionFilters")]
	public List<HIDDeviceFilter> ExclusionFilters;
}

[ToObject]
public partial class HIDDeviceFilter
{
	[Value("vendorId")]
	public ulong VendorId;
	[Value("productId")]
	public ushort ProductId;
	[Value("usagePage")]
	public ushort UsagePage;
	[Value("usage")]
	public ushort Usage;
}

[ToObject]
public partial class HIDConnectionEventInit : EventInit
{
	[Value("device")]
	public required HIDDevice Device;
}

[ToObject]
public partial class HIDInputReportEventInit : EventInit
{
	[Value("device")]
	public required HIDDevice Device;
	[Value("reportId")]
	public required byte ReportId;
	[Value("data")]
	public required DataView Data;
}

[ToObject]
public partial class HIDCollectionInfo
{
	[Value("usagePage")]
	public ushort UsagePage;
	[Value("usage")]
	public ushort Usage;
	[Value("type")]
	public byte Type;
	[Value("children")]
	public List<HIDCollectionInfo> Children;
	[Value("inputReports")]
	public List<HIDReportInfo> InputReports;
	[Value("outputReports")]
	public List<HIDReportInfo> OutputReports;
	[Value("featureReports")]
	public List<HIDReportInfo> FeatureReports;
}

[ToObject]
public partial class HIDReportInfo
{
	[Value("reportId")]
	public byte ReportId;
	[Value("items")]
	public List<HIDReportItem> Items;
}

[ToObject]
public partial class HIDReportItem
{
	[Value("isAbsolute")]
	public bool IsAbsolute;
	[Value("isArray")]
	public bool IsArray;
	[Value("isBufferedBytes")]
	public bool IsBufferedBytes;
	[Value("isConstant")]
	public bool IsConstant;
	[Value("isLinear")]
	public bool IsLinear;
	[Value("isRange")]
	public bool IsRange;
	[Value("isVolatile")]
	public bool IsVolatile;
	[Value("hasNull")]
	public bool HasNull;
	[Value("hasPreferredState")]
	public bool HasPreferredState;
	[Value("wrap")]
	public bool Wrap;
	[Value("usages")]
	public List<ulong> Usages;
	[Value("usageMinimum")]
	public ulong UsageMinimum;
	[Value("usageMaximum")]
	public ulong UsageMaximum;
	[Value("reportSize")]
	public ushort ReportSize;
	[Value("reportCount")]
	public ushort ReportCount;
	[Value("unitExponent")]
	public byte UnitExponent;
	[Value("unitSystem")]
	public HIDUnitSystem UnitSystem;
	[Value("unitFactorLengthExponent")]
	public byte UnitFactorLengthExponent;
	[Value("unitFactorMassExponent")]
	public byte UnitFactorMassExponent;
	[Value("unitFactorTimeExponent")]
	public byte UnitFactorTimeExponent;
	[Value("unitFactorTemperatureExponent")]
	public byte UnitFactorTemperatureExponent;
	[Value("unitFactorCurrentExponent")]
	public byte UnitFactorCurrentExponent;
	[Value("unitFactorLuminousIntensityExponent")]
	public byte UnitFactorLuminousIntensityExponent;
	[Value("logicalMinimum")]
	public long LogicalMinimum;
	[Value("logicalMaximum")]
	public long LogicalMaximum;
	[Value("physicalMinimum")]
	public long PhysicalMinimum;
	[Value("physicalMaximum")]
	public long PhysicalMaximum;
	[Value("strings")]
	public List<DOMString> Strings;
}

[ToObject]
public partial class MidiPermissionDescriptor : PermissionDescriptor
{
	[Value("sysex")]
	public bool Sysex;
}

[ToObject]
public partial class MIDIOptions
{
	[Value("sysex")]
	public bool Sysex;
	[Value("software")]
	public bool Software;
}

[ToObject]
public partial class MIDIMessageEventInit : EventInit
{
	[Value("data")]
	public Uint8Array Data;
}

[ToObject]
public partial class MIDIConnectionEventInit : EventInit
{
	[Value("port")]
	public MIDIPort Port;
}

[ToObject]
public partial class MLContextOptions
{
	[Value("deviceType")]
	public MLDeviceType DeviceType;
	[Value("powerPreference")]
	public MLPowerPreference PowerPreference;
}

[ToObject]
public partial class MLContextLostInfo
{
	[Value("message")]
	public DOMString Message;
}

[ToObject]
public partial class MLOpSupportLimits
{
	[Value("preferredInputLayout")]
	public MLInputOperandLayout PreferredInputLayout;
	[Value("input")]
	public MLSupportLimits Input;
	[Value("constant")]
	public MLSupportLimits Constant;
	[Value("output")]
	public MLSupportLimits Output;
}

[ToObject]
public partial class MLSupportLimits
{
	[Value("dataTypes")]
	public List<MLOperandDataType> DataTypes;
}

[ToObject]
public partial class MLBinarySupportLimits
{
	[Value("a")]
	public MLSupportLimits A;
	[Value("b")]
	public MLSupportLimits B;
	[Value("output")]
	public MLSupportLimits Output;
}

[ToObject]
public partial class MLSingleInputSupportLimits
{
	[Value("input")]
	public MLSupportLimits Input;
	[Value("output")]
	public MLSupportLimits Output;
}

[ToObject]
public partial class MLOperandDescriptor
{
	[Value("dataType")]
	public required MLOperandDataType DataType;
	[Value("shape")]
	public required List<ulong> Shape;
}

[ToObject]
public partial class MLOperatorOptions
{
	[Value("label")]
	public USVString Label;
}


[ToObject]
public partial class MLTensorDescriptor : MLOperandDescriptor
{
	[Value("readable")]
	public bool Readable;
	[Value("writable")]
	public bool Writable;
}

[ToObject]
public partial class MLArgMinMaxOptions : MLOperatorOptions
{
	[Value("keepDimensions")]
	public bool KeepDimensions;
	[Value("outputDataType")]
	public MLOperandDataType OutputDataType;
}

public partial class MLOpSupportLimits
{
	[Value("argMin")]
	public MLSingleInputSupportLimits ArgMin;
	[Value("argMax")]
	public MLSingleInputSupportLimits ArgMax;
}

[ToObject]
public partial class MLBatchNormalizationOptions : MLOperatorOptions
{
	[Value("scale")]
	public MLOperand Scale;
	[Value("bias")]
	public MLOperand Bias;
	[Value("axis")]
	public ulong Axis;
	[Value("epsilon")]
	public Number Epsilon;
}

[ToObject]
public partial class MLBatchNormalizationSupportLimits
{
	[Value("input")]
	public MLSupportLimits Input;
	[Value("mean")]
	public MLSupportLimits Mean;
	[Value("variance")]
	public MLSupportLimits Variance;
	[Value("scale")]
	public MLSupportLimits Scale;
	[Value("bias")]
	public MLSupportLimits Bias;
	[Value("output")]
	public MLSupportLimits Output;
}

public partial class MLOpSupportLimits
{
	[Value("batchNormalization")]
	public MLBatchNormalizationSupportLimits BatchNormalization;
}

public partial class MLOpSupportLimits
{
	[Value("cast")]
	public MLSingleInputSupportLimits Cast;
}

[ToObject]
public partial class MLClampOptions : MLOperatorOptions
{
	[Value("minValue")]
	public MLNumber MinValue;
	[Value("maxValue")]
	public MLNumber MaxValue;
}

public partial class MLOpSupportLimits
{
	[Value("clamp")]
	public MLSingleInputSupportLimits Clamp;
}

[ToObject]
public partial class MLConcatSupportLimits
{
	[Value("inputs")]
	public MLSupportLimits Inputs;
	[Value("output")]
	public MLSupportLimits Output;
}

public partial class MLOpSupportLimits
{
	[Value("concat")]
	public MLConcatSupportLimits Concat;
}

[ToObject]
public partial class MLConv2dOptions : MLOperatorOptions
{
	[Value("padding")]
	public List<ulong> Padding;
	[Value("strides")]
	public List<ulong> Strides;
	[Value("dilations")]
	public List<ulong> Dilations;
	[Value("groups")]
	public ulong Groups;
	[Value("inputLayout")]
	public MLInputOperandLayout InputLayout;
	[Value("filterLayout")]
	public MLConv2dFilterOperandLayout FilterLayout;
	[Value("bias")]
	public MLOperand Bias;
}

[ToObject]
public partial class MLConv2dSupportLimits
{
	[Value("input")]
	public MLSupportLimits Input;
	[Value("filter")]
	public MLSupportLimits Filter;
	[Value("bias")]
	public MLSupportLimits Bias;
	[Value("output")]
	public MLSupportLimits Output;
}

public partial class MLOpSupportLimits
{
	[Value("conv2d")]
	public MLConv2dSupportLimits Conv2d;
}

[ToObject]
public partial class MLConvTranspose2dOptions : MLOperatorOptions
{
	[Value("padding")]
	public List<ulong> Padding;
	[Value("strides")]
	public List<ulong> Strides;
	[Value("dilations")]
	public List<ulong> Dilations;
	[Value("outputPadding")]
	public List<ulong> OutputPadding;
	[Value("outputSizes")]
	public List<ulong> OutputSizes;
	[Value("groups")]
	public ulong Groups;
	[Value("inputLayout")]
	public MLInputOperandLayout InputLayout;
	[Value("filterLayout")]
	public MLConvTranspose2dFilterOperandLayout FilterLayout;
	[Value("bias")]
	public MLOperand Bias;
}

public partial class MLOpSupportLimits
{
	[Value("convTranspose2d")]
	public MLConv2dSupportLimits ConvTranspose2d;
}

public partial class MLOpSupportLimits
{
	[Value("add")]
	public MLBinarySupportLimits Add;
	[Value("sub")]
	public MLBinarySupportLimits Sub;
	[Value("mul")]
	public MLBinarySupportLimits Mul;
	[Value("div")]
	public MLBinarySupportLimits Div;
	[Value("max")]
	public MLBinarySupportLimits Max;
	[Value("min")]
	public MLBinarySupportLimits Min;
	[Value("pow")]
	public MLBinarySupportLimits Pow;
}

[ToObject]
public partial class MLLogicalNotSupportLimits
{
	[Value("a")]
	public MLSupportLimits A;
	[Value("output")]
	public MLSupportLimits Output;
}

public partial class MLOpSupportLimits
{
	[Value("equal")]
	public MLBinarySupportLimits Equal;
	[Value("greater")]
	public MLBinarySupportLimits Greater;
	[Value("greaterOrEqual")]
	public MLBinarySupportLimits GreaterOrEqual;
	[Value("lesser")]
	public MLBinarySupportLimits Lesser;
	[Value("lesserOrEqual")]
	public MLBinarySupportLimits LesserOrEqual;
	[Value("logicalNot")]
	public MLLogicalNotSupportLimits LogicalNot;
}

public partial class MLOpSupportLimits
{
	[Value("abs")]
	public MLSingleInputSupportLimits Abs;
	[Value("ceil")]
	public MLSingleInputSupportLimits Ceil;
	[Value("cos")]
	public MLSingleInputSupportLimits Cos;
	[Value("erf")]
	public MLSingleInputSupportLimits Erf;
	[Value("exp")]
	public MLSingleInputSupportLimits Exp;
	[Value("floor")]
	public MLSingleInputSupportLimits Floor;
	[Value("identity")]
	public MLSingleInputSupportLimits Identity;
	[Value("log")]
	public MLSingleInputSupportLimits Log;
	[Value("neg")]
	public MLSingleInputSupportLimits Neg;
	[Value("reciprocal")]
	public MLSingleInputSupportLimits Reciprocal;
	[Value("sin")]
	public MLSingleInputSupportLimits Sin;
	[Value("sqrt")]
	public MLSingleInputSupportLimits Sqrt;
	[Value("tan")]
	public MLSingleInputSupportLimits Tan;
}

[ToObject]
public partial class MLEluOptions : MLOperatorOptions
{
	[Value("alpha")]
	public Number Alpha;
}

public partial class MLOpSupportLimits
{
	[Value("elu")]
	public MLSingleInputSupportLimits Elu;
}

public partial class MLOpSupportLimits
{
	[Value("expand")]
	public MLSingleInputSupportLimits Expand;
}

[ToObject]
public partial class MLGatherOptions : MLOperatorOptions
{
	[Value("axis")]
	public ulong Axis;
}

[ToObject]
public partial class MLGatherSupportLimits
{
	[Value("input")]
	public MLSupportLimits Input;
	[Value("indices")]
	public MLSupportLimits Indices;
	[Value("output")]
	public MLSupportLimits Output;
}

public partial class MLOpSupportLimits
{
	[Value("gather")]
	public MLGatherSupportLimits Gather;
}

public partial class MLOpSupportLimits
{
	[Value("gelu")]
	public MLSingleInputSupportLimits Gelu;
}

[ToObject]
public partial class MLGemmOptions : MLOperatorOptions
{
	[Value("c")]
	public MLOperand C;
	[Value("alpha")]
	public Number Alpha;
	[Value("beta")]
	public Number Beta;
	[Value("aTranspose")]
	public bool ATranspose;
	[Value("bTranspose")]
	public bool BTranspose;
}

[ToObject]
public partial class MLGemmSupportLimits
{
	[Value("a")]
	public MLSupportLimits A;
	[Value("b")]
	public MLSupportLimits B;
	[Value("c")]
	public MLSupportLimits C;
	[Value("output")]
	public MLSupportLimits Output;
}

public partial class MLOpSupportLimits
{
	[Value("gemm")]
	public MLGemmSupportLimits Gemm;
}

[ToObject]
public partial class MLGruOptions : MLOperatorOptions
{
	[Value("bias")]
	public MLOperand Bias;
	[Value("recurrentBias")]
	public MLOperand RecurrentBias;
	[Value("initialHiddenState")]
	public MLOperand InitialHiddenState;
	[Value("resetAfter")]
	public bool ResetAfter;
	[Value("returnSequence")]
	public bool ReturnSequence;
	[Value("direction")]
	public MLRecurrentNetworkDirection Direction;
	[Value("layout")]
	public MLGruWeightLayout Layout;
	[Value("activations")]
	public List<MLRecurrentNetworkActivation> Activations;
}

[ToObject]
public partial class MLGruSupportLimits
{
	[Value("input")]
	public MLSupportLimits Input;
	[Value("weight")]
	public MLSupportLimits Weight;
	[Value("recurrentWeight")]
	public MLSupportLimits RecurrentWeight;
	[Value("bias")]
	public MLSupportLimits Bias;
	[Value("recurrentBias")]
	public MLSupportLimits RecurrentBias;
	[Value("initialHiddenState")]
	public MLSupportLimits InitialHiddenState;
	[Value("outputs")]
	public MLSupportLimits Outputs;
}

public partial class MLOpSupportLimits
{
	[Value("gru")]
	public MLGruSupportLimits Gru;
}

[ToObject]
public partial class MLGruCellOptions : MLOperatorOptions
{
	[Value("bias")]
	public MLOperand Bias;
	[Value("recurrentBias")]
	public MLOperand RecurrentBias;
	[Value("resetAfter")]
	public bool ResetAfter;
	[Value("layout")]
	public MLGruWeightLayout Layout;
	[Value("activations")]
	public List<MLRecurrentNetworkActivation> Activations;
}

[ToObject]
public partial class MLGruCellSupportLimits
{
	[Value("input")]
	public MLSupportLimits Input;
	[Value("weight")]
	public MLSupportLimits Weight;
	[Value("recurrentWeight")]
	public MLSupportLimits RecurrentWeight;
	[Value("hiddenState")]
	public MLSupportLimits HiddenState;
	[Value("bias")]
	public MLSupportLimits Bias;
	[Value("recurrentBias")]
	public MLSupportLimits RecurrentBias;
	[Value("output")]
	public MLSupportLimits Output;
}

public partial class MLOpSupportLimits
{
	[Value("gruCell")]
	public MLGruCellSupportLimits GruCell;
}

[ToObject]
public partial class MLHardSigmoidOptions : MLOperatorOptions
{
	[Value("alpha")]
	public Number Alpha;
	[Value("beta")]
	public Number Beta;
}

public partial class MLOpSupportLimits
{
	[Value("hardSigmoid")]
	public MLSingleInputSupportLimits HardSigmoid;
}

public partial class MLOpSupportLimits
{
	[Value("hardSwish")]
	public MLSingleInputSupportLimits HardSwish;
}

[ToObject]
public partial class MLInstanceNormalizationOptions : MLOperatorOptions
{
	[Value("scale")]
	public MLOperand Scale;
	[Value("bias")]
	public MLOperand Bias;
	[Value("epsilon")]
	public Number Epsilon;
	[Value("layout")]
	public MLInputOperandLayout Layout;
}

[ToObject]
public partial class MLNormalizationSupportLimits
{
	[Value("input")]
	public MLSupportLimits Input;
	[Value("scale")]
	public MLSupportLimits Scale;
	[Value("bias")]
	public MLSupportLimits Bias;
	[Value("output")]
	public MLSupportLimits Output;
}

public partial class MLOpSupportLimits
{
	[Value("instanceNormalization")]
	public MLNormalizationSupportLimits InstanceNormalization;
}

[ToObject]
public partial class MLLayerNormalizationOptions : MLOperatorOptions
{
	[Value("scale")]
	public MLOperand Scale;
	[Value("bias")]
	public MLOperand Bias;
	[Value("axes")]
	public List<ulong> Axes;
	[Value("epsilon")]
	public Number Epsilon;
}

public partial class MLOpSupportLimits
{
	[Value("layerNormalization")]
	public MLNormalizationSupportLimits LayerNormalization;
}

[ToObject]
public partial class MLLeakyReluOptions : MLOperatorOptions
{
	[Value("alpha")]
	public Number Alpha;
}

public partial class MLOpSupportLimits
{
	[Value("leakyRelu")]
	public MLSingleInputSupportLimits LeakyRelu;
}

[ToObject]
public partial class MLLinearOptions : MLOperatorOptions
{
	[Value("alpha")]
	public Number Alpha;
	[Value("beta")]
	public Number Beta;
}

public partial class MLOpSupportLimits
{
	[Value("linear")]
	public MLSingleInputSupportLimits Linear;
}

[ToObject]
public partial class MLLstmOptions : MLOperatorOptions
{
	[Value("bias")]
	public MLOperand Bias;
	[Value("recurrentBias")]
	public MLOperand RecurrentBias;
	[Value("peepholeWeight")]
	public MLOperand PeepholeWeight;
	[Value("initialHiddenState")]
	public MLOperand InitialHiddenState;
	[Value("initialCellState")]
	public MLOperand InitialCellState;
	[Value("returnSequence")]
	public bool ReturnSequence;
	[Value("direction")]
	public MLRecurrentNetworkDirection Direction;
	[Value("layout")]
	public MLLstmWeightLayout Layout;
	[Value("activations")]
	public List<MLRecurrentNetworkActivation> Activations;
}

[ToObject]
public partial class MLLstmSupportLimits
{
	[Value("input")]
	public MLSupportLimits Input;
	[Value("weight")]
	public MLSupportLimits Weight;
	[Value("recurrentWeight")]
	public MLSupportLimits RecurrentWeight;
	[Value("bias")]
	public MLSupportLimits Bias;
	[Value("recurrentBias")]
	public MLSupportLimits RecurrentBias;
	[Value("peepholeWeight")]
	public MLSupportLimits PeepholeWeight;
	[Value("initialHiddenState")]
	public MLSupportLimits InitialHiddenState;
	[Value("initialCellState")]
	public MLSupportLimits InitialCellState;
	[Value("outputs")]
	public MLSupportLimits Outputs;
}

public partial class MLOpSupportLimits
{
	[Value("lstm")]
	public MLLstmSupportLimits Lstm;
}

[ToObject]
public partial class MLLstmCellOptions : MLOperatorOptions
{
	[Value("bias")]
	public MLOperand Bias;
	[Value("recurrentBias")]
	public MLOperand RecurrentBias;
	[Value("peepholeWeight")]
	public MLOperand PeepholeWeight;
	[Value("layout")]
	public MLLstmWeightLayout Layout;
	[Value("activations")]
	public List<MLRecurrentNetworkActivation> Activations;
}

[ToObject]
public partial class MLLstmCellSupportLimits
{
	[Value("input")]
	public MLSupportLimits Input;
	[Value("weight")]
	public MLSupportLimits Weight;
	[Value("recurrentWeight")]
	public MLSupportLimits RecurrentWeight;
	[Value("hiddenState")]
	public MLSupportLimits HiddenState;
	[Value("cellState")]
	public MLSupportLimits CellState;
	[Value("bias")]
	public MLSupportLimits Bias;
	[Value("recurrentBias")]
	public MLSupportLimits RecurrentBias;
	[Value("peepholeWeight")]
	public MLSupportLimits PeepholeWeight;
	[Value("outputs")]
	public MLSupportLimits Outputs;
}

public partial class MLOpSupportLimits
{
	[Value("lstmCell")]
	public MLLstmCellSupportLimits LstmCell;
}

public partial class MLOpSupportLimits
{
	[Value("matmul")]
	public MLBinarySupportLimits Matmul;
}

[ToObject]
public partial class MLPadOptions : MLOperatorOptions
{
	[Value("mode")]
	public MLPaddingMode Mode;
	[Value("value")]
	public MLNumber Value;
}

public partial class MLOpSupportLimits
{
	[Value("pad")]
	public MLSingleInputSupportLimits Pad;
}

[ToObject]
public partial class MLPool2dOptions : MLOperatorOptions
{
	[Value("windowDimensions")]
	public List<ulong> WindowDimensions;
	[Value("padding")]
	public List<ulong> Padding;
	[Value("strides")]
	public List<ulong> Strides;
	[Value("dilations")]
	public List<ulong> Dilations;
	[Value("layout")]
	public MLInputOperandLayout Layout;
	[Value("roundingType")]
	public MLRoundingType RoundingType;
	[Value("outputSizes")]
	public List<ulong> OutputSizes;
}

public partial class MLOpSupportLimits
{
	[Value("averagePool2d")]
	public MLSingleInputSupportLimits AveragePool2d;
	[Value("l2Pool2d")]
	public MLSingleInputSupportLimits L2Pool2d;
	[Value("maxPool2d")]
	public MLSingleInputSupportLimits MaxPool2d;
}

[ToObject]
public partial class MLPreluSupportLimits
{
	[Value("input")]
	public MLSupportLimits Input;
	[Value("slope")]
	public MLSupportLimits Slope;
	[Value("output")]
	public MLSupportLimits Output;
}

public partial class MLOpSupportLimits
{
	[Value("prelu")]
	public MLPreluSupportLimits Prelu;
}

[ToObject]
public partial class MLReduceOptions : MLOperatorOptions
{
	[Value("axes")]
	public List<ulong> Axes;
	[Value("keepDimensions")]
	public bool KeepDimensions;
}

public partial class MLOpSupportLimits
{
	[Value("reduceL1")]
	public MLSingleInputSupportLimits ReduceL1;
	[Value("reduceL2")]
	public MLSingleInputSupportLimits ReduceL2;
	[Value("reduceLogSum")]
	public MLSingleInputSupportLimits ReduceLogSum;
	[Value("reduceLogSumExp")]
	public MLSingleInputSupportLimits ReduceLogSumExp;
	[Value("reduceMax")]
	public MLSingleInputSupportLimits ReduceMax;
	[Value("reduceMean")]
	public MLSingleInputSupportLimits ReduceMean;
	[Value("reduceMin")]
	public MLSingleInputSupportLimits ReduceMin;
	[Value("reduceProduct")]
	public MLSingleInputSupportLimits ReduceProduct;
	[Value("reduceSum")]
	public MLSingleInputSupportLimits ReduceSum;
	[Value("reduceSumSquare")]
	public MLSingleInputSupportLimits ReduceSumSquare;
}

public partial class MLOpSupportLimits
{
	[Value("relu")]
	public MLSingleInputSupportLimits Relu;
}

[ToObject]
public partial class MLResample2dOptions : MLOperatorOptions
{
	[Value("mode")]
	public MLInterpolationMode Mode;
	[Value("scales")]
	public List<Number> Scales;
	[Value("sizes")]
	public List<ulong> Sizes;
	[Value("axes")]
	public List<ulong> Axes;
}

public partial class MLOpSupportLimits
{
	[Value("resample2d")]
	public MLSingleInputSupportLimits Resample2d;
}

public partial class MLOpSupportLimits
{
	[Value("reshape")]
	public MLSingleInputSupportLimits Reshape;
}

public partial class MLOpSupportLimits
{
	[Value("sigmoid")]
	public MLSingleInputSupportLimits Sigmoid;
}

public partial class MLOpSupportLimits
{
	[Value("slice")]
	public MLSingleInputSupportLimits Slice;
}

public partial class MLOpSupportLimits
{
	[Value("softmax")]
	public MLSingleInputSupportLimits Softmax;
}

public partial class MLOpSupportLimits
{
	[Value("softplus")]
	public MLSingleInputSupportLimits Softplus;
}

public partial class MLOpSupportLimits
{
	[Value("softsign")]
	public MLSingleInputSupportLimits Softsign;
}

[ToObject]
public partial class MLSplitOptions : MLOperatorOptions
{
	[Value("axis")]
	public ulong Axis;
}

[ToObject]
public partial class MLSplitSupportLimits
{
	[Value("input")]
	public MLSupportLimits Input;
	[Value("outputs")]
	public MLSupportLimits Outputs;
}

public partial class MLOpSupportLimits
{
	[Value("split")]
	public MLSplitSupportLimits Split;
}

public partial class MLOpSupportLimits
{
	[Value("tanh")]
	public MLSingleInputSupportLimits Tanh;
}

[ToObject]
public partial class MLTransposeOptions : MLOperatorOptions
{
	[Value("permutation")]
	public List<ulong> Permutation;
}

public partial class MLOpSupportLimits
{
	[Value("transpose")]
	public MLSingleInputSupportLimits Transpose;
}

[ToObject]
public partial class MLTriangularOptions : MLOperatorOptions
{
	[Value("upper")]
	public bool Upper;
	[Value("diagonal")]
	public long Diagonal;
}

public partial class MLOpSupportLimits
{
	[Value("triangular")]
	public MLSingleInputSupportLimits Triangular;
}

[ToObject]
public partial class MLWhereSupportLimits
{
	[Value("condition")]
	public MLSupportLimits Condition;
	[Value("trueValue")]
	public MLSupportLimits TrueValue;
	[Value("falseValue")]
	public MLSupportLimits FalseValue;
	[Value("output")]
	public MLSupportLimits Output;
}

public partial class MLOpSupportLimits
{
	[Value("where")]
	public MLWhereSupportLimits Where;
}


[ToObject]
public partial class SFrameTransformOptions
{
	[Value("role")]
	public SFrameTransformRole Role;
}



[ToObject]
public partial class SFrameTransformErrorEventInit : EventInit
{
	[Value("errorType")]
	public required SFrameTransformErrorEventType ErrorType;
	[Value("frame")]
	public required dynamic Frame;
	[Value("keyID")]
	public CryptoKeyID? KeyID;
}

[ToObject]
public partial class RTCEncodedVideoFrameMetadata
{
	[Value("frameId")]
	public ulong FrameId;
	[Value("dependencies")]
	public List<ulong> Dependencies;
	[Value("width")]
	public ushort Width;
	[Value("height")]
	public ushort Height;
	[Value("spatialIndex")]
	public ulong SpatialIndex;
	[Value("temporalIndex")]
	public ulong TemporalIndex;
	[Value("synchronizationSource")]
	public ulong SynchronizationSource;
	[Value("payloadType")]
	public byte PayloadType;
	[Value("contributingSources")]
	public List<ulong> ContributingSources;
	[Value("timestamp")]
	public long Timestamp;
	[Value("rtpTimestamp")]
	public ulong RtpTimestamp;
	[Value("mimeType")]
	public DOMString MimeType;
}

[ToObject]
public partial class RTCEncodedVideoFrameOptions
{
	[Value("metadata")]
	public RTCEncodedVideoFrameMetadata Metadata;
}

[ToObject]
public partial class RTCEncodedAudioFrameMetadata
{
	[Value("synchronizationSource")]
	public ulong SynchronizationSource;
	[Value("payloadType")]
	public byte PayloadType;
	[Value("contributingSources")]
	public List<ulong> ContributingSources;
	[Value("sequenceNumber")]
	public Number SequenceNumber;
	[Value("rtpTimestamp")]
	public ulong RtpTimestamp;
	[Value("mimeType")]
	public DOMString MimeType;
}

[ToObject]
public partial class RTCEncodedAudioFrameOptions
{
	[Value("metadata")]
	public RTCEncodedAudioFrameMetadata Metadata;
}

///<include file='CSharpToJavaScript/Utils/Docs/rtciceparameters/rtciceparameters.generated.xml' path='docs/RTCIceParameters/*'/>
[ToObject]
public partial class RTCIceParameters
{
	///<include file='CSharpToJavaScript/Utils/Docs/rtciceparameters/rtciceparameters.generated.xml' path='docs/RTCIceParametersIceLite/*'/>
[Value("iceLite")]
	public bool IceLite;
}

[ToObject]
public partial class RTCIceGatherOptions
{
	[Value("gatherPolicy")]
	public RTCIceTransportPolicy GatherPolicy;
	[Value("iceServers")]
	public List<RTCIceServer> IceServers;
}

[ToObject]
public partial class RTCIdentityProvider
{
	[Value("generateAssertion")]
	public required GenerateAssertionCallback GenerateAssertion;
	[Value("validateAssertion")]
	public required ValidateAssertionCallback ValidateAssertion;
}

[ToObject]
public partial class RTCIdentityAssertionResult
{
	[Value("idp")]
	public required RTCIdentityProviderDetails Idp;
	[Value("assertion")]
	public required DOMString Assertion;
}

[ToObject]
public partial class RTCIdentityProviderDetails
{
	[Value("domain")]
	public required DOMString Domain;
	[Value("protocol")]
	public DOMString Protocol;
}

[ToObject]
public partial class RTCIdentityValidationResult
{
	[Value("identity")]
	public required DOMString Identity;
	[Value("contents")]
	public required DOMString Contents;
}

[ToObject]
public partial class RTCConfiguration
{
	[Value("peerIdentity")]
	public DOMString PeerIdentity;
}

[ToObject]
public partial class RTCIdentityProviderOptions
{
	[Value("protocol")]
	public DOMString Protocol;
	[Value("usernameHint")]
	public DOMString UsernameHint;
	[Value("peerIdentity")]
	public DOMString PeerIdentity;
}

[ToObject]
public partial class RTCErrorInit
{
	[Value("httpRequestStatusCode")]
	public long HttpRequestStatusCode;
}

public partial class MediaStreamConstraints
{
	[Value("peerIdentity")]
	public DOMString PeerIdentity;
}

[ToObject]
public partial class RTCRtpEncodingParameters
{
	[Value("priority")]
	public RTCPriorityType Priority;
	[Value("networkPriority")]
	public RTCPriorityType NetworkPriority;
}

[ToObject]
public partial class RTCDataChannelInit
{
	[Value("priority")]
	public RTCPriorityType Priority;
}

[ToObject]
public partial class RTCRtpStreamStats : RTCStats
{
	[Value("ssrc")]
	public required ulong Ssrc;
	[Value("kind")]
	public required DOMString Kind;
	[Value("transportId")]
	public DOMString TransportId;
	[Value("codecId")]
	public DOMString CodecId;
}

///<include file='CSharpToJavaScript/Utils/Docs/rtccodecstats/rtccodecstats.generated.xml' path='docs/RTCCodecStats/*'/>
[ToObject]
public partial class RTCCodecStats : RTCStats
{
	///<include file='CSharpToJavaScript/Utils/Docs/rtccodecstats/rtccodecstats.generated.xml' path='docs/RTCCodecStatsPayloadType/*'/>
[Value("payloadType")]
	public required ulong PayloadType;
	///<include file='CSharpToJavaScript/Utils/Docs/rtccodecstats/rtccodecstats.generated.xml' path='docs/RTCCodecStatsTransportId/*'/>
[Value("transportId")]
	public required DOMString TransportId;
	///<include file='CSharpToJavaScript/Utils/Docs/rtccodecstats/rtccodecstats.generated.xml' path='docs/RTCCodecStatsMimeType/*'/>
[Value("mimeType")]
	public required DOMString MimeType;
	///<include file='CSharpToJavaScript/Utils/Docs/rtccodecstats/rtccodecstats.generated.xml' path='docs/RTCCodecStatsClockRate/*'/>
[Value("clockRate")]
	public ulong ClockRate;
	///<include file='CSharpToJavaScript/Utils/Docs/rtccodecstats/rtccodecstats.generated.xml' path='docs/RTCCodecStatsChannels/*'/>
[Value("channels")]
	public ulong Channels;
	///<include file='CSharpToJavaScript/Utils/Docs/rtccodecstats/rtccodecstats.generated.xml' path='docs/RTCCodecStatsSdpFmtpLine/*'/>
[Value("sdpFmtpLine")]
	public DOMString SdpFmtpLine;
}

[ToObject]
public partial class RTCReceivedRtpStreamStats : RTCRtpStreamStats
{
	[Value("packetsReceived")]
	public ulong PacketsReceived;
	[Value("packetsLost")]
	public long PacketsLost;
	[Value("jitter")]
	public Number Jitter;
}

///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStats/*'/>
[ToObject]
public partial class RTCInboundRtpStreamStats : RTCReceivedRtpStreamStats
{
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsTrackIdentifier/*'/>
[Value("trackIdentifier")]
	public required DOMString TrackIdentifier;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsMid/*'/>
[Value("mid")]
	public DOMString Mid;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsRemoteId/*'/>
[Value("remoteId")]
	public DOMString RemoteId;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsFramesDecoded/*'/>
[Value("framesDecoded")]
	public ulong FramesDecoded;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsKeyFramesDecoded/*'/>
[Value("keyFramesDecoded")]
	public ulong KeyFramesDecoded;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsFramesRendered/*'/>
[Value("framesRendered")]
	public ulong FramesRendered;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsFramesDropped/*'/>
[Value("framesDropped")]
	public ulong FramesDropped;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsFrameWidth/*'/>
[Value("frameWidth")]
	public ulong FrameWidth;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsFrameHeight/*'/>
[Value("frameHeight")]
	public ulong FrameHeight;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsFramesPerSecond/*'/>
[Value("framesPerSecond")]
	public Number FramesPerSecond;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsQpSum/*'/>
[Value("qpSum")]
	public ulong QpSum;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsTotalDecodeTime/*'/>
[Value("totalDecodeTime")]
	public Number TotalDecodeTime;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsTotalInterFrameDelay/*'/>
[Value("totalInterFrameDelay")]
	public Number TotalInterFrameDelay;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsTotalSquaredInterFrameDelay/*'/>
[Value("totalSquaredInterFrameDelay")]
	public Number TotalSquaredInterFrameDelay;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsPauseCount/*'/>
[Value("pauseCount")]
	public ulong PauseCount;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsTotalPausesDuration/*'/>
[Value("totalPausesDuration")]
	public Number TotalPausesDuration;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsFreezeCount/*'/>
[Value("freezeCount")]
	public ulong FreezeCount;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsTotalFreezesDuration/*'/>
[Value("totalFreezesDuration")]
	public Number TotalFreezesDuration;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsLastPacketReceivedTimestamp/*'/>
[Value("lastPacketReceivedTimestamp")]
	public DOMHighResTimeStamp LastPacketReceivedTimestamp;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsHeaderBytesReceived/*'/>
[Value("headerBytesReceived")]
	public ulong HeaderBytesReceived;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsPacketsDiscarded/*'/>
[Value("packetsDiscarded")]
	public ulong PacketsDiscarded;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsFecBytesReceived/*'/>
[Value("fecBytesReceived")]
	public ulong FecBytesReceived;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsFecPacketsReceived/*'/>
[Value("fecPacketsReceived")]
	public ulong FecPacketsReceived;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsFecPacketsDiscarded/*'/>
[Value("fecPacketsDiscarded")]
	public ulong FecPacketsDiscarded;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsBytesReceived/*'/>
[Value("bytesReceived")]
	public ulong BytesReceived;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsNackCount/*'/>
[Value("nackCount")]
	public ulong NackCount;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsFirCount/*'/>
[Value("firCount")]
	public ulong FirCount;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsPliCount/*'/>
[Value("pliCount")]
	public ulong PliCount;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsTotalProcessingDelay/*'/>
[Value("totalProcessingDelay")]
	public Number TotalProcessingDelay;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsEstimatedPlayoutTimestamp/*'/>
[Value("estimatedPlayoutTimestamp")]
	public DOMHighResTimeStamp EstimatedPlayoutTimestamp;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsJitterBufferDelay/*'/>
[Value("jitterBufferDelay")]
	public Number JitterBufferDelay;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsJitterBufferTargetDelay/*'/>
[Value("jitterBufferTargetDelay")]
	public Number JitterBufferTargetDelay;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsJitterBufferEmittedCount/*'/>
[Value("jitterBufferEmittedCount")]
	public ulong JitterBufferEmittedCount;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsJitterBufferMinimumDelay/*'/>
[Value("jitterBufferMinimumDelay")]
	public Number JitterBufferMinimumDelay;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsTotalSamplesReceived/*'/>
[Value("totalSamplesReceived")]
	public ulong TotalSamplesReceived;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsConcealedSamples/*'/>
[Value("concealedSamples")]
	public ulong ConcealedSamples;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsSilentConcealedSamples/*'/>
[Value("silentConcealedSamples")]
	public ulong SilentConcealedSamples;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsConcealmentEvents/*'/>
[Value("concealmentEvents")]
	public ulong ConcealmentEvents;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsInsertedSamplesForDeceleration/*'/>
[Value("insertedSamplesForDeceleration")]
	public ulong InsertedSamplesForDeceleration;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsRemovedSamplesForAcceleration/*'/>
[Value("removedSamplesForAcceleration")]
	public ulong RemovedSamplesForAcceleration;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsAudioLevel/*'/>
[Value("audioLevel")]
	public Number AudioLevel;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsTotalAudioEnergy/*'/>
[Value("totalAudioEnergy")]
	public Number TotalAudioEnergy;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsTotalSamplesDuration/*'/>
[Value("totalSamplesDuration")]
	public Number TotalSamplesDuration;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsFramesReceived/*'/>
[Value("framesReceived")]
	public ulong FramesReceived;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsDecoderImplementation/*'/>
[Value("decoderImplementation")]
	public DOMString DecoderImplementation;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsPlayoutId/*'/>
[Value("playoutId")]
	public DOMString PlayoutId;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsPowerEfficientDecoder/*'/>
[Value("powerEfficientDecoder")]
	public bool PowerEfficientDecoder;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsFramesAssembledFromMultiplePackets/*'/>
[Value("framesAssembledFromMultiplePackets")]
	public ulong FramesAssembledFromMultiplePackets;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsTotalAssemblyTime/*'/>
[Value("totalAssemblyTime")]
	public Number TotalAssemblyTime;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsRetransmittedPacketsReceived/*'/>
[Value("retransmittedPacketsReceived")]
	public ulong RetransmittedPacketsReceived;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsRetransmittedBytesReceived/*'/>
[Value("retransmittedBytesReceived")]
	public ulong RetransmittedBytesReceived;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsRtxSsrc/*'/>
[Value("rtxSsrc")]
	public ulong RtxSsrc;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsFecSsrc/*'/>
[Value("fecSsrc")]
	public ulong FecSsrc;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsTotalCorruptionProbability/*'/>
[Value("totalCorruptionProbability")]
	public Number TotalCorruptionProbability;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsTotalSquaredCorruptionProbability/*'/>
[Value("totalSquaredCorruptionProbability")]
	public Number TotalSquaredCorruptionProbability;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcinboundrtpstreamstats/rtcinboundrtpstreamstats.generated.xml' path='docs/RTCInboundRtpStreamStatsCorruptionMeasurements/*'/>
[Value("corruptionMeasurements")]
	public ulong CorruptionMeasurements;
}

///<include file='CSharpToJavaScript/Utils/Docs/rtcremoteinboundrtpstreamstats/rtcremoteinboundrtpstreamstats.generated.xml' path='docs/RTCRemoteInboundRtpStreamStats/*'/>
[ToObject]
public partial class RTCRemoteInboundRtpStreamStats : RTCReceivedRtpStreamStats
{
	///<include file='CSharpToJavaScript/Utils/Docs/rtcremoteinboundrtpstreamstats/rtcremoteinboundrtpstreamstats.generated.xml' path='docs/RTCRemoteInboundRtpStreamStatsLocalId/*'/>
[Value("localId")]
	public DOMString LocalId;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcremoteinboundrtpstreamstats/rtcremoteinboundrtpstreamstats.generated.xml' path='docs/RTCRemoteInboundRtpStreamStatsRoundTripTime/*'/>
[Value("roundTripTime")]
	public Number RoundTripTime;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcremoteinboundrtpstreamstats/rtcremoteinboundrtpstreamstats.generated.xml' path='docs/RTCRemoteInboundRtpStreamStatsTotalRoundTripTime/*'/>
[Value("totalRoundTripTime")]
	public Number TotalRoundTripTime;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcremoteinboundrtpstreamstats/rtcremoteinboundrtpstreamstats.generated.xml' path='docs/RTCRemoteInboundRtpStreamStatsFractionLost/*'/>
[Value("fractionLost")]
	public Number FractionLost;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcremoteinboundrtpstreamstats/rtcremoteinboundrtpstreamstats.generated.xml' path='docs/RTCRemoteInboundRtpStreamStatsRoundTripTimeMeasurements/*'/>
[Value("roundTripTimeMeasurements")]
	public ulong RoundTripTimeMeasurements;
}

[ToObject]
public partial class RTCSentRtpStreamStats : RTCRtpStreamStats
{
	[Value("packetsSent")]
	public ulong PacketsSent;
	[Value("bytesSent")]
	public ulong BytesSent;
}

///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStats/*'/>
[ToObject]
public partial class RTCOutboundRtpStreamStats : RTCSentRtpStreamStats
{
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsMid/*'/>
[Value("mid")]
	public DOMString Mid;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsMediaSourceId/*'/>
[Value("mediaSourceId")]
	public DOMString MediaSourceId;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsRemoteId/*'/>
[Value("remoteId")]
	public DOMString RemoteId;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsRid/*'/>
[Value("rid")]
	public DOMString Rid;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsHeaderBytesSent/*'/>
[Value("headerBytesSent")]
	public ulong HeaderBytesSent;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsRetransmittedPacketsSent/*'/>
[Value("retransmittedPacketsSent")]
	public ulong RetransmittedPacketsSent;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsRetransmittedBytesSent/*'/>
[Value("retransmittedBytesSent")]
	public ulong RetransmittedBytesSent;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsRtxSsrc/*'/>
[Value("rtxSsrc")]
	public ulong RtxSsrc;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsTargetBitrate/*'/>
[Value("targetBitrate")]
	public Number TargetBitrate;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsTotalEncodedBytesTarget/*'/>
[Value("totalEncodedBytesTarget")]
	public ulong TotalEncodedBytesTarget;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsFrameWidth/*'/>
[Value("frameWidth")]
	public ulong FrameWidth;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsFrameHeight/*'/>
[Value("frameHeight")]
	public ulong FrameHeight;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsFramesPerSecond/*'/>
[Value("framesPerSecond")]
	public Number FramesPerSecond;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsFramesSent/*'/>
[Value("framesSent")]
	public ulong FramesSent;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsHugeFramesSent/*'/>
[Value("hugeFramesSent")]
	public ulong HugeFramesSent;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsFramesEncoded/*'/>
[Value("framesEncoded")]
	public ulong FramesEncoded;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsKeyFramesEncoded/*'/>
[Value("keyFramesEncoded")]
	public ulong KeyFramesEncoded;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsQpSum/*'/>
[Value("qpSum")]
	public ulong QpSum;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsTotalEncodeTime/*'/>
[Value("totalEncodeTime")]
	public Number TotalEncodeTime;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsTotalPacketSendDelay/*'/>
[Value("totalPacketSendDelay")]
	public Number TotalPacketSendDelay;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsQualityLimitationReason/*'/>
[Value("qualityLimitationReason")]
	public RTCQualityLimitationReason QualityLimitationReason;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsQualityLimitationDurations/*'/>
[Value("qualityLimitationDurations")]
	public Dictionary<DOMString, Number> QualityLimitationDurations;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsQualityLimitationResolutionChanges/*'/>
[Value("qualityLimitationResolutionChanges")]
	public ulong QualityLimitationResolutionChanges;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsNackCount/*'/>
[Value("nackCount")]
	public ulong NackCount;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsFirCount/*'/>
[Value("firCount")]
	public ulong FirCount;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsPliCount/*'/>
[Value("pliCount")]
	public ulong PliCount;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsEncoderImplementation/*'/>
[Value("encoderImplementation")]
	public DOMString EncoderImplementation;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsPowerEfficientEncoder/*'/>
[Value("powerEfficientEncoder")]
	public bool PowerEfficientEncoder;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsActive/*'/>
[Value("active")]
	public bool Active;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcoutboundrtpstreamstats/rtcoutboundrtpstreamstats.generated.xml' path='docs/RTCOutboundRtpStreamStatsScalabilityMode/*'/>
[Value("scalabilityMode")]
	public DOMString ScalabilityMode;
}

///<include file='CSharpToJavaScript/Utils/Docs/rtcremoteoutboundrtpstreamstats/rtcremoteoutboundrtpstreamstats.generated.xml' path='docs/RTCRemoteOutboundRtpStreamStats/*'/>
[ToObject]
public partial class RTCRemoteOutboundRtpStreamStats : RTCSentRtpStreamStats
{
	///<include file='CSharpToJavaScript/Utils/Docs/rtcremoteoutboundrtpstreamstats/rtcremoteoutboundrtpstreamstats.generated.xml' path='docs/RTCRemoteOutboundRtpStreamStatsLocalId/*'/>
[Value("localId")]
	public DOMString LocalId;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcremoteoutboundrtpstreamstats/rtcremoteoutboundrtpstreamstats.generated.xml' path='docs/RTCRemoteOutboundRtpStreamStatsRemoteTimestamp/*'/>
[Value("remoteTimestamp")]
	public DOMHighResTimeStamp RemoteTimestamp;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcremoteoutboundrtpstreamstats/rtcremoteoutboundrtpstreamstats.generated.xml' path='docs/RTCRemoteOutboundRtpStreamStatsReportsSent/*'/>
[Value("reportsSent")]
	public ulong ReportsSent;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcremoteoutboundrtpstreamstats/rtcremoteoutboundrtpstreamstats.generated.xml' path='docs/RTCRemoteOutboundRtpStreamStatsRoundTripTime/*'/>
[Value("roundTripTime")]
	public Number RoundTripTime;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcremoteoutboundrtpstreamstats/rtcremoteoutboundrtpstreamstats.generated.xml' path='docs/RTCRemoteOutboundRtpStreamStatsTotalRoundTripTime/*'/>
[Value("totalRoundTripTime")]
	public Number TotalRoundTripTime;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcremoteoutboundrtpstreamstats/rtcremoteoutboundrtpstreamstats.generated.xml' path='docs/RTCRemoteOutboundRtpStreamStatsRoundTripTimeMeasurements/*'/>
[Value("roundTripTimeMeasurements")]
	public ulong RoundTripTimeMeasurements;
}

[ToObject]
public partial class RTCMediaSourceStats : RTCStats
{
	[Value("trackIdentifier")]
	public required DOMString TrackIdentifier;
	[Value("kind")]
	public required DOMString Kind;
}

///<include file='CSharpToJavaScript/Utils/Docs/rtcaudiosourcestats/rtcaudiosourcestats.generated.xml' path='docs/RTCAudioSourceStats/*'/>
[ToObject]
public partial class RTCAudioSourceStats : RTCMediaSourceStats
{
	///<include file='CSharpToJavaScript/Utils/Docs/rtcaudiosourcestats/rtcaudiosourcestats.generated.xml' path='docs/RTCAudioSourceStatsAudioLevel/*'/>
[Value("audioLevel")]
	public Number AudioLevel;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcaudiosourcestats/rtcaudiosourcestats.generated.xml' path='docs/RTCAudioSourceStatsTotalAudioEnergy/*'/>
[Value("totalAudioEnergy")]
	public Number TotalAudioEnergy;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcaudiosourcestats/rtcaudiosourcestats.generated.xml' path='docs/RTCAudioSourceStatsTotalSamplesDuration/*'/>
[Value("totalSamplesDuration")]
	public Number TotalSamplesDuration;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcaudiosourcestats/rtcaudiosourcestats.generated.xml' path='docs/RTCAudioSourceStatsEchoReturnLoss/*'/>
[Value("echoReturnLoss")]
	public Number EchoReturnLoss;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcaudiosourcestats/rtcaudiosourcestats.generated.xml' path='docs/RTCAudioSourceStatsEchoReturnLossEnhancement/*'/>
[Value("echoReturnLossEnhancement")]
	public Number EchoReturnLossEnhancement;
}

///<include file='CSharpToJavaScript/Utils/Docs/rtcvideosourcestats/rtcvideosourcestats.generated.xml' path='docs/RTCVideoSourceStats/*'/>
[ToObject]
public partial class RTCVideoSourceStats : RTCMediaSourceStats
{
	///<include file='CSharpToJavaScript/Utils/Docs/rtcvideosourcestats/rtcvideosourcestats.generated.xml' path='docs/RTCVideoSourceStatsWidth/*'/>
[Value("width")]
	public ulong Width;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcvideosourcestats/rtcvideosourcestats.generated.xml' path='docs/RTCVideoSourceStatsHeight/*'/>
[Value("height")]
	public ulong Height;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcvideosourcestats/rtcvideosourcestats.generated.xml' path='docs/RTCVideoSourceStatsFrames/*'/>
[Value("frames")]
	public ulong Frames;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcvideosourcestats/rtcvideosourcestats.generated.xml' path='docs/RTCVideoSourceStatsFramesPerSecond/*'/>
[Value("framesPerSecond")]
	public Number FramesPerSecond;
}

[ToObject]
public partial class RTCAudioPlayoutStats : RTCStats
{
	[Value("kind")]
	public required DOMString Kind;
	[Value("synthesizedSamplesDuration")]
	public Number SynthesizedSamplesDuration;
	[Value("synthesizedSamplesEvents")]
	public ulong SynthesizedSamplesEvents;
	[Value("totalSamplesDuration")]
	public Number TotalSamplesDuration;
	[Value("totalPlayoutDelay")]
	public Number TotalPlayoutDelay;
	[Value("totalSamplesCount")]
	public ulong TotalSamplesCount;
}

///<include file='CSharpToJavaScript/Utils/Docs/rtcpeerconnectionstats/rtcpeerconnectionstats.generated.xml' path='docs/RTCPeerConnectionStats/*'/>
[ToObject]
public partial class RTCPeerConnectionStats : RTCStats
{
	///<include file='CSharpToJavaScript/Utils/Docs/rtcpeerconnectionstats/rtcpeerconnectionstats.generated.xml' path='docs/RTCPeerConnectionStatsDataChannelsOpened/*'/>
[Value("dataChannelsOpened")]
	public ulong DataChannelsOpened;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcpeerconnectionstats/rtcpeerconnectionstats.generated.xml' path='docs/RTCPeerConnectionStatsDataChannelsClosed/*'/>
[Value("dataChannelsClosed")]
	public ulong DataChannelsClosed;
}

///<include file='CSharpToJavaScript/Utils/Docs/rtcdatachannelstats/rtcdatachannelstats.generated.xml' path='docs/RTCDataChannelStats/*'/>
[ToObject]
public partial class RTCDataChannelStats : RTCStats
{
	///<include file='CSharpToJavaScript/Utils/Docs/rtcdatachannelstats/rtcdatachannelstats.generated.xml' path='docs/RTCDataChannelStatsLabel/*'/>
[Value("label")]
	public DOMString Label;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcdatachannelstats/rtcdatachannelstats.generated.xml' path='docs/RTCDataChannelStatsProtocol/*'/>
[Value("protocol")]
	public DOMString Protocol;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcdatachannelstats/rtcdatachannelstats.generated.xml' path='docs/RTCDataChannelStatsDataChannelIdentifier/*'/>
[Value("dataChannelIdentifier")]
	public ushort DataChannelIdentifier;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcdatachannelstats/rtcdatachannelstats.generated.xml' path='docs/RTCDataChannelStatsState/*'/>
[Value("state")]
	public required RTCDataChannelState State;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcdatachannelstats/rtcdatachannelstats.generated.xml' path='docs/RTCDataChannelStatsMessagesSent/*'/>
[Value("messagesSent")]
	public ulong MessagesSent;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcdatachannelstats/rtcdatachannelstats.generated.xml' path='docs/RTCDataChannelStatsBytesSent/*'/>
[Value("bytesSent")]
	public ulong BytesSent;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcdatachannelstats/rtcdatachannelstats.generated.xml' path='docs/RTCDataChannelStatsMessagesReceived/*'/>
[Value("messagesReceived")]
	public ulong MessagesReceived;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcdatachannelstats/rtcdatachannelstats.generated.xml' path='docs/RTCDataChannelStatsBytesReceived/*'/>
[Value("bytesReceived")]
	public ulong BytesReceived;
}

///<include file='CSharpToJavaScript/Utils/Docs/rtctransportstats/rtctransportstats.generated.xml' path='docs/RTCTransportStats/*'/>
[ToObject]
public partial class RTCTransportStats : RTCStats
{
	///<include file='CSharpToJavaScript/Utils/Docs/rtctransportstats/rtctransportstats.generated.xml' path='docs/RTCTransportStatsPacketsSent/*'/>
[Value("packetsSent")]
	public ulong PacketsSent;
	///<include file='CSharpToJavaScript/Utils/Docs/rtctransportstats/rtctransportstats.generated.xml' path='docs/RTCTransportStatsPacketsReceived/*'/>
[Value("packetsReceived")]
	public ulong PacketsReceived;
	///<include file='CSharpToJavaScript/Utils/Docs/rtctransportstats/rtctransportstats.generated.xml' path='docs/RTCTransportStatsBytesSent/*'/>
[Value("bytesSent")]
	public ulong BytesSent;
	///<include file='CSharpToJavaScript/Utils/Docs/rtctransportstats/rtctransportstats.generated.xml' path='docs/RTCTransportStatsBytesReceived/*'/>
[Value("bytesReceived")]
	public ulong BytesReceived;
	///<include file='CSharpToJavaScript/Utils/Docs/rtctransportstats/rtctransportstats.generated.xml' path='docs/RTCTransportStatsIceRole/*'/>
[Value("iceRole")]
	public RTCIceRole IceRole;
	///<include file='CSharpToJavaScript/Utils/Docs/rtctransportstats/rtctransportstats.generated.xml' path='docs/RTCTransportStatsIceLocalUsernameFragment/*'/>
[Value("iceLocalUsernameFragment")]
	public DOMString IceLocalUsernameFragment;
	///<include file='CSharpToJavaScript/Utils/Docs/rtctransportstats/rtctransportstats.generated.xml' path='docs/RTCTransportStatsDtlsState/*'/>
[Value("dtlsState")]
	public required RTCDtlsTransportState DtlsState;
	///<include file='CSharpToJavaScript/Utils/Docs/rtctransportstats/rtctransportstats.generated.xml' path='docs/RTCTransportStatsIceState/*'/>
[Value("iceState")]
	public RTCIceTransportState IceState;
	///<include file='CSharpToJavaScript/Utils/Docs/rtctransportstats/rtctransportstats.generated.xml' path='docs/RTCTransportStatsSelectedCandidatePairId/*'/>
[Value("selectedCandidatePairId")]
	public DOMString SelectedCandidatePairId;
	///<include file='CSharpToJavaScript/Utils/Docs/rtctransportstats/rtctransportstats.generated.xml' path='docs/RTCTransportStatsLocalCertificateId/*'/>
[Value("localCertificateId")]
	public DOMString LocalCertificateId;
	///<include file='CSharpToJavaScript/Utils/Docs/rtctransportstats/rtctransportstats.generated.xml' path='docs/RTCTransportStatsRemoteCertificateId/*'/>
[Value("remoteCertificateId")]
	public DOMString RemoteCertificateId;
	///<include file='CSharpToJavaScript/Utils/Docs/rtctransportstats/rtctransportstats.generated.xml' path='docs/RTCTransportStatsTlsVersion/*'/>
[Value("tlsVersion")]
	public DOMString TlsVersion;
	///<include file='CSharpToJavaScript/Utils/Docs/rtctransportstats/rtctransportstats.generated.xml' path='docs/RTCTransportStatsDtlsCipher/*'/>
[Value("dtlsCipher")]
	public DOMString DtlsCipher;
	///<include file='CSharpToJavaScript/Utils/Docs/rtctransportstats/rtctransportstats.generated.xml' path='docs/RTCTransportStatsDtlsRole/*'/>
[Value("dtlsRole")]
	public RTCDtlsRole DtlsRole;
	///<include file='CSharpToJavaScript/Utils/Docs/rtctransportstats/rtctransportstats.generated.xml' path='docs/RTCTransportStatsSrtpCipher/*'/>
[Value("srtpCipher")]
	public DOMString SrtpCipher;
	///<include file='CSharpToJavaScript/Utils/Docs/rtctransportstats/rtctransportstats.generated.xml' path='docs/RTCTransportStatsSelectedCandidatePairChanges/*'/>
[Value("selectedCandidatePairChanges")]
	public ulong SelectedCandidatePairChanges;
}

///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatestats/rtcicecandidatestats.generated.xml' path='docs/RTCIceCandidateStats/*'/>
[ToObject]
public partial class RTCIceCandidateStats : RTCStats
{
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatestats/rtcicecandidatestats.generated.xml' path='docs/RTCIceCandidateStatsTransportId/*'/>
[Value("transportId")]
	public required DOMString TransportId;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatestats/rtcicecandidatestats.generated.xml' path='docs/RTCIceCandidateStatsAddress/*'/>
[Value("address")]
	public DOMString? Address;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatestats/rtcicecandidatestats.generated.xml' path='docs/RTCIceCandidateStatsPort/*'/>
[Value("port")]
	public long Port;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatestats/rtcicecandidatestats.generated.xml' path='docs/RTCIceCandidateStatsProtocol/*'/>
[Value("protocol")]
	public DOMString Protocol;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatestats/rtcicecandidatestats.generated.xml' path='docs/RTCIceCandidateStatsCandidateType/*'/>
[Value("candidateType")]
	public required RTCIceCandidateType CandidateType;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatestats/rtcicecandidatestats.generated.xml' path='docs/RTCIceCandidateStatsPriority/*'/>
[Value("priority")]
	public long Priority;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatestats/rtcicecandidatestats.generated.xml' path='docs/RTCIceCandidateStatsUrl/*'/>
[Value("url")]
	public DOMString Url;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatestats/rtcicecandidatestats.generated.xml' path='docs/RTCIceCandidateStatsRelayProtocol/*'/>
[Value("relayProtocol")]
	public RTCIceServerTransportProtocol RelayProtocol;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatestats/rtcicecandidatestats.generated.xml' path='docs/RTCIceCandidateStatsFoundation/*'/>
[Value("foundation")]
	public DOMString Foundation;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatestats/rtcicecandidatestats.generated.xml' path='docs/RTCIceCandidateStatsRelatedAddress/*'/>
[Value("relatedAddress")]
	public DOMString RelatedAddress;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatestats/rtcicecandidatestats.generated.xml' path='docs/RTCIceCandidateStatsRelatedPort/*'/>
[Value("relatedPort")]
	public long RelatedPort;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatestats/rtcicecandidatestats.generated.xml' path='docs/RTCIceCandidateStatsUsernameFragment/*'/>
[Value("usernameFragment")]
	public DOMString UsernameFragment;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatestats/rtcicecandidatestats.generated.xml' path='docs/RTCIceCandidateStatsTcpType/*'/>
[Value("tcpType")]
	public RTCIceTcpCandidateType TcpType;
}

///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStats/*'/>
[ToObject]
public partial class RTCIceCandidatePairStats : RTCStats
{
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsTransportId/*'/>
[Value("transportId")]
	public required DOMString TransportId;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsLocalCandidateId/*'/>
[Value("localCandidateId")]
	public required DOMString LocalCandidateId;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsRemoteCandidateId/*'/>
[Value("remoteCandidateId")]
	public required DOMString RemoteCandidateId;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsState/*'/>
[Value("state")]
	public required RTCStatsIceCandidatePairState State;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsNominated/*'/>
[Value("nominated")]
	public bool Nominated;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsPacketsSent/*'/>
[Value("packetsSent")]
	public ulong PacketsSent;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsPacketsReceived/*'/>
[Value("packetsReceived")]
	public ulong PacketsReceived;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsBytesSent/*'/>
[Value("bytesSent")]
	public ulong BytesSent;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsBytesReceived/*'/>
[Value("bytesReceived")]
	public ulong BytesReceived;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsLastPacketSentTimestamp/*'/>
[Value("lastPacketSentTimestamp")]
	public DOMHighResTimeStamp LastPacketSentTimestamp;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsLastPacketReceivedTimestamp/*'/>
[Value("lastPacketReceivedTimestamp")]
	public DOMHighResTimeStamp LastPacketReceivedTimestamp;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsTotalRoundTripTime/*'/>
[Value("totalRoundTripTime")]
	public Number TotalRoundTripTime;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsCurrentRoundTripTime/*'/>
[Value("currentRoundTripTime")]
	public Number CurrentRoundTripTime;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsAvailableOutgoingBitrate/*'/>
[Value("availableOutgoingBitrate")]
	public Number AvailableOutgoingBitrate;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsAvailableIncomingBitrate/*'/>
[Value("availableIncomingBitrate")]
	public Number AvailableIncomingBitrate;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsRequestsReceived/*'/>
[Value("requestsReceived")]
	public ulong RequestsReceived;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsRequestsSent/*'/>
[Value("requestsSent")]
	public ulong RequestsSent;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsResponsesReceived/*'/>
[Value("responsesReceived")]
	public ulong ResponsesReceived;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsResponsesSent/*'/>
[Value("responsesSent")]
	public ulong ResponsesSent;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsConsentRequestsSent/*'/>
[Value("consentRequestsSent")]
	public ulong ConsentRequestsSent;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsPacketsDiscardedOnSend/*'/>
[Value("packetsDiscardedOnSend")]
	public ulong PacketsDiscardedOnSend;
	///<include file='CSharpToJavaScript/Utils/Docs/rtcicecandidatepairstats/rtcicecandidatepairstats.generated.xml' path='docs/RTCIceCandidatePairStatsBytesDiscardedOnSend/*'/>
[Value("bytesDiscardedOnSend")]
	public ulong BytesDiscardedOnSend;
}

///<include file='CSharpToJavaScript/Utils/Docs/rtccertificatestats/rtccertificatestats.generated.xml' path='docs/RTCCertificateStats/*'/>
[ToObject]
public partial class RTCCertificateStats : RTCStats
{
	///<include file='CSharpToJavaScript/Utils/Docs/rtccertificatestats/rtccertificatestats.generated.xml' path='docs/RTCCertificateStatsFingerprint/*'/>
[Value("fingerprint")]
	public required DOMString Fingerprint;
	///<include file='CSharpToJavaScript/Utils/Docs/rtccertificatestats/rtccertificatestats.generated.xml' path='docs/RTCCertificateStatsFingerprintAlgorithm/*'/>
[Value("fingerprintAlgorithm")]
	public required DOMString FingerprintAlgorithm;
	///<include file='CSharpToJavaScript/Utils/Docs/rtccertificatestats/rtccertificatestats.generated.xml' path='docs/RTCCertificateStatsBase64Certificate/*'/>
[Value("base64Certificate")]
	public required DOMString Base64Certificate;
	///<include file='CSharpToJavaScript/Utils/Docs/rtccertificatestats/rtccertificatestats.generated.xml' path='docs/RTCCertificateStatsIssuerCertificateId/*'/>
[Value("issuerCertificateId")]
	public DOMString IssuerCertificateId;
}

public partial class RTCRtpEncodingParameters
{
	[Value("scalabilityMode")]
	public DOMString ScalabilityMode;
}

public partial class RTCConfiguration
{
	[Value("iceServers")]
	public List<RTCIceServer> IceServers;
	[Value("iceTransportPolicy")]
	public RTCIceTransportPolicy IceTransportPolicy;
	[Value("bundlePolicy")]
	public RTCBundlePolicy BundlePolicy;
	[Value("rtcpMuxPolicy")]
	public RTCRtcpMuxPolicy RtcpMuxPolicy;
	[Value("certificates")]
	public List<RTCCertificate> Certificates;
	[Value("iceCandidatePoolSize")]
	public byte IceCandidatePoolSize;
}

[ToObject]
public partial class RTCIceServer
{
	[Value("urls")]
	public required Union230 Urls;
	[Value("username")]
	public DOMString Username;
	[Value("credential")]
	public DOMString Credential;
}

[ToObject]
public partial class RTCOfferAnswerOptions
{
}

[ToObject]
public partial class RTCOfferOptions : RTCOfferAnswerOptions
{
	[Value("iceRestart")]
	public bool IceRestart;
}

[ToObject]
public partial class RTCAnswerOptions : RTCOfferAnswerOptions
{
}

public partial class RTCOfferOptions
{
	[Value("offerToReceiveAudio")]
	public bool OfferToReceiveAudio;
	[Value("offerToReceiveVideo")]
	public bool OfferToReceiveVideo;
}

[ToObject]
public partial class RTCSessionDescriptionInit
{
	[Value("type")]
	public required RTCSdpType Type;
	[Value("sdp")]
	public DOMString Sdp;
}

[ToObject]
public partial class RTCLocalSessionDescriptionInit
{
	[Value("type")]
	public RTCSdpType Type;
	[Value("sdp")]
	public DOMString Sdp;
}

[ToObject]
public partial class RTCIceCandidateInit
{
	[Value("candidate")]
	public DOMString Candidate;
	[Value("sdpMid")]
	public DOMString? SdpMid;
	[Value("sdpMLineIndex")]
	public ushort? SdpMLineIndex;
	[Value("usernameFragment")]
	public DOMString? UsernameFragment;
}

[ToObject]
public partial class RTCPeerConnectionIceEventInit : EventInit
{
	[Value("candidate")]
	public RTCIceCandidate? Candidate;
	[Value("url")]
	public DOMString? Url;
}

[ToObject]
public partial class RTCPeerConnectionIceErrorEventInit : EventInit
{
	[Value("address")]
	public DOMString? Address;
	[Value("port")]
	public ushort? Port;
	[Value("url")]
	public DOMString Url;
	[Value("errorCode")]
	public required ushort ErrorCode;
	[Value("errorText")]
	public USVString ErrorText;
}

[ToObject]
public partial class RTCCertificateExpiration
{
	[Value("expires")]
	public ulong Expires;
}

[ToObject]
public partial class RTCRtpTransceiverInit
{
	[Value("direction")]
	public RTCRtpTransceiverDirection Direction;
	[Value("streams")]
	public List<MediaStream> Streams;
	[Value("sendEncodings")]
	public List<RTCRtpEncodingParameters> SendEncodings;
}

[ToObject]
public partial class RTCRtpParameters
{
	[Value("headerExtensions")]
	public required List<RTCRtpHeaderExtensionParameters> HeaderExtensions;
	[Value("rtcp")]
	public required RTCRtcpParameters Rtcp;
	[Value("codecs")]
	public required List<RTCRtpCodecParameters> Codecs;
}

public partial class RTCRtpSendParameters : RTCRtpParameters
{
	[Value("transactionId")]
	public required DOMString TransactionId;
	[Value("encodings")]
	public required List<RTCRtpEncodingParameters> Encodings;
}

[ToObject]
public partial class RTCRtpReceiveParameters : RTCRtpParameters
{
}

[ToObject]
public partial class RTCRtpCodingParameters
{
	[Value("rid")]
	public DOMString Rid;
}

public partial class RTCRtpEncodingParameters : RTCRtpCodingParameters
{
	[Value("active")]
	public bool Active;
	[Value("codec")]
	public RTCRtpCodec Codec;
	[Value("maxBitrate")]
	public ulong MaxBitrate;
	[Value("maxFramerate")]
	public Number MaxFramerate;
	[Value("scaleResolutionDownBy")]
	public Number ScaleResolutionDownBy;
}

[ToObject]
public partial class RTCRtcpParameters
{
	[Value("cname")]
	public DOMString Cname;
	[Value("reducedSize")]
	public bool ReducedSize;
}

[ToObject]
public partial class RTCRtpHeaderExtensionParameters
{
	[Value("uri")]
	public required DOMString Uri;
	[Value("id")]
	public required ushort Id;
	[Value("encrypted")]
	public bool Encrypted;
}

[ToObject]
public partial class RTCRtpCodec
{
	[Value("mimeType")]
	public required DOMString MimeType;
	[Value("clockRate")]
	public required ulong ClockRate;
	[Value("channels")]
	public ushort Channels;
	[Value("sdpFmtpLine")]
	public DOMString SdpFmtpLine;
}

[ToObject]
public partial class RTCRtpCodecParameters : RTCRtpCodec
{
	[Value("payloadType")]
	public required byte PayloadType;
}

[ToObject]
public partial class RTCRtpCapabilities
{
	[Value("codecs")]
	public required List<RTCRtpCodec> Codecs;
	[Value("headerExtensions")]
	public required List<RTCRtpHeaderExtensionCapability> HeaderExtensions;
}

[ToObject]
public partial class RTCRtpHeaderExtensionCapability
{
	[Value("uri")]
	public required DOMString Uri;
}

[ToObject]
public partial class RTCSetParameterOptions
{
}

[ToObject]
public partial class RTCRtpContributingSource
{
	[Value("timestamp")]
	public required DOMHighResTimeStamp Timestamp;
	[Value("source")]
	public required ulong Source;
	[Value("audioLevel")]
	public Number AudioLevel;
	[Value("rtpTimestamp")]
	public required ulong RtpTimestamp;
}

[ToObject]
public partial class RTCRtpSynchronizationSource : RTCRtpContributingSource
{
}

[ToObject]
public partial class RTCDtlsFingerprint
{
	[Value("algorithm")]
	public DOMString Algorithm;
	[Value("value")]
	public DOMString Value;
}

///<include file='CSharpToJavaScript/Utils/Docs/rtciceparameters/rtciceparameters.generated.xml' path='docs/RTCIceParameters/*'/>
public partial class RTCIceParameters
{
	///<include file='CSharpToJavaScript/Utils/Docs/rtciceparameters/rtciceparameters.generated.xml' path='docs/RTCIceParametersUsernameFragment/*'/>
[Value("usernameFragment")]
	public DOMString UsernameFragment;
	///<include file='CSharpToJavaScript/Utils/Docs/rtciceparameters/rtciceparameters.generated.xml' path='docs/RTCIceParametersPassword/*'/>
[Value("password")]
	public DOMString Password;
}

[ToObject]
public partial class RTCTrackEventInit : EventInit
{
	[Value("receiver")]
	public required RTCRtpReceiver Receiver;
	[Value("track")]
	public required MediaStreamTrack Track;
	[Value("streams")]
	public List<MediaStream> Streams;
	[Value("transceiver")]
	public required RTCRtpTransceiver Transceiver;
}

public partial class RTCDataChannelInit
{
	[Value("ordered")]
	public bool Ordered;
	[Value("maxPacketLifeTime")]
	public ushort MaxPacketLifeTime;
	[Value("maxRetransmits")]
	public ushort MaxRetransmits;
	[Value("protocol")]
	public USVString Protocol;
	[Value("negotiated")]
	public bool Negotiated;
	[Value("id")]
	public ushort Id;
}

[ToObject]
public partial class RTCDataChannelEventInit : EventInit
{
	[Value("channel")]
	public required RTCDataChannel Channel;
}

[ToObject]
public partial class RTCDTMFToneChangeEventInit : EventInit
{
	[Value("tone")]
	public DOMString Tone;
}

[ToObject]
public partial class RTCStats
{
	[Value("timestamp")]
	public required DOMHighResTimeStamp Timestamp;
	[Value("type")]
	public required RTCStatsType Type;
	[Value("id")]
	public required DOMString Id;
}

public partial class RTCErrorInit
{
	[Value("errorDetail")]
	public required RTCErrorDetailType ErrorDetail;
	[Value("sdpLineNumber")]
	public long SdpLineNumber;
	[Value("sctpCauseCode")]
	public long SctpCauseCode;
	[Value("receivedAlert")]
	public ulong ReceivedAlert;
	[Value("sentAlert")]
	public ulong SentAlert;
}

[ToObject]
public partial class RTCErrorEventInit : EventInit
{
	[Value("error")]
	public required RTCError Error;
}

[ToObject]
public partial class CloseEventInit : EventInit
{
	[Value("wasClean")]
	public bool WasClean;
	[Value("code")]
	public ushort Code;
	[Value("reason")]
	public USVString Reason;
}

[ToObject]
public partial class WebTransportHash
{
	[Value("algorithm")]
	public DOMString Algorithm;
	[Value("value")]
	public BufferSource Value;
}

[ToObject]
public partial class WebTransportOptions
{
	[Value("allowPooling")]
	public bool AllowPooling;
	[Value("requireUnreliable")]
	public bool RequireUnreliable;
	[Value("serverCertificateHashes")]
	public List<WebTransportHash> ServerCertificateHashes;
	[Value("congestionControl")]
	public WebTransportCongestionControl CongestionControl;
	[Value("anticipatedConcurrentIncomingUnidirectionalStreams")]
	public ushort? AnticipatedConcurrentIncomingUnidirectionalStreams;
	[Value("anticipatedConcurrentIncomingBidirectionalStreams")]
	public ushort? AnticipatedConcurrentIncomingBidirectionalStreams;
	[Value("protocols")]
	public List<DOMString> Protocols;
}

[ToObject]
public partial class WebTransportCloseInfo
{
	[Value("closeCode")]
	public ulong CloseCode;
	[Value("reason")]
	public USVString Reason;
}

[ToObject]
public partial class WebTransportSendStreamOptions
{
	[Value("sendGroup")]
	public WebTransportSendGroup? SendGroup;
	[Value("sendOrder")]
	public long SendOrder;
	[Value("waitUntilAvailable")]
	public bool WaitUntilAvailable;
}

[ToObject]
public partial class WebTransportConnectionStats
{
	[Value("bytesSent")]
	public ulong BytesSent;
	[Value("packetsSent")]
	public ulong PacketsSent;
	[Value("bytesLost")]
	public ulong BytesLost;
	[Value("packetsLost")]
	public ulong PacketsLost;
	[Value("bytesReceived")]
	public ulong BytesReceived;
	[Value("packetsReceived")]
	public ulong PacketsReceived;
	[Value("smoothedRtt")]
	public required DOMHighResTimeStamp SmoothedRtt;
	[Value("rttVariation")]
	public required DOMHighResTimeStamp RttVariation;
	[Value("minRtt")]
	public required DOMHighResTimeStamp MinRtt;
	[Value("datagrams")]
	public required WebTransportDatagramStats Datagrams;
	[Value("estimatedSendRate")]
	public ulong? EstimatedSendRate;
	[Value("atSendCapacity")]
	public bool AtSendCapacity;
}

[ToObject]
public partial class WebTransportDatagramStats
{
	[Value("droppedIncoming")]
	public ulong DroppedIncoming;
	[Value("expiredIncoming")]
	public ulong ExpiredIncoming;
	[Value("expiredOutgoing")]
	public ulong ExpiredOutgoing;
	[Value("lostOutgoing")]
	public ulong LostOutgoing;
}

[ToObject]
public partial class WebTransportSendStreamStats
{
	[Value("bytesWritten")]
	public ulong BytesWritten;
	[Value("bytesSent")]
	public ulong BytesSent;
	[Value("bytesAcknowledged")]
	public ulong BytesAcknowledged;
}

[ToObject]
public partial class WebTransportReceiveStreamStats
{
	[Value("bytesReceived")]
	public ulong BytesReceived;
	[Value("bytesRead")]
	public ulong BytesRead;
}

[ToObject]
public partial class WebTransportErrorOptions
{
	[Value("source")]
	public WebTransportErrorSource Source;
	[Value("streamErrorCode")]
	public ulong? StreamErrorCode;
}

[ToObject]
public partial class USBDeviceFilter
{
	[Value("vendorId")]
	public ushort VendorId;
	[Value("productId")]
	public ushort ProductId;
	[Value("classCode")]
	public byte ClassCode;
	[Value("subclassCode")]
	public byte SubclassCode;
	[Value("protocolCode")]
	public byte ProtocolCode;
	[Value("serialNumber")]
	public DOMString SerialNumber;
}

[ToObject]
public partial class USBDeviceRequestOptions
{
	[Value("filters")]
	public required List<USBDeviceFilter> Filters;
	[Value("exclusionFilters")]
	public List<USBDeviceFilter> ExclusionFilters;
}

[ToObject]
public partial class USBConnectionEventInit : EventInit
{
	[Value("device")]
	public required USBDevice Device;
}

[ToObject]
public partial class USBControlTransferParameters
{
	[Value("requestType")]
	public required USBRequestType RequestType;
	[Value("recipient")]
	public required USBRecipient Recipient;
	[Value("request")]
	public required byte Request;
	[Value("value")]
	public required ushort Value;
	[Value("index")]
	public required ushort Index;
}

[ToObject]
public partial class USBBlocklistEntry
{
	[Value("idVendor")]
	public required ushort IdVendor;
	[Value("idProduct")]
	public required ushort IdProduct;
	[Value("bcdDevice")]
	public required ushort BcdDevice;
}

[ToObject]
public partial class USBPermissionDescriptor : PermissionDescriptor
{
	[Value("filters")]
	public List<USBDeviceFilter> Filters;
	[Value("exclusionFilters")]
	public List<USBDeviceFilter> ExclusionFilters;
}

[ToObject]
public partial class AllowedUSBDevice
{
	[Value("vendorId")]
	public required byte VendorId;
	[Value("productId")]
	public required byte ProductId;
	[Value("serialNumber")]
	public DOMString SerialNumber;
}

[ToObject]
public partial class USBPermissionStorage
{
	[Value("allowedDevices")]
	public List<AllowedUSBDevice> AllowedDevices;
}

[ToObject]
public partial class XRDepthStateInit
{
	[Value("usagePreference")]
	public required List<XRDepthUsage> UsagePreference;
	[Value("dataFormatPreference")]
	public required List<XRDepthDataFormat> DataFormatPreference;
}

[ToObject]
public partial class XRSessionInit
{
	[Value("depthSensing")]
	public XRDepthStateInit DepthSensing;
}

public partial class XRSessionInit
{
	[Value("domOverlay")]
	public XRDOMOverlayInit? DomOverlay;
}

[ToObject]
public partial class XRDOMOverlayInit
{
	[Value("root")]
	public required Element Root;
}

[ToObject]
public partial class XRDOMOverlayState
{
	[Value("type")]
	public XRDOMOverlayType Type;
}

[ToObject]
public partial class XRHitTestOptionsInit
{
	[Value("space")]
	public required XRSpace Space;
	[Value("entityTypes")]
	public List<XRHitTestTrackableType> EntityTypes;
	[Value("offsetRay")]
	public XRRay OffsetRay;
}

[ToObject]
public partial class XRTransientInputHitTestOptionsInit
{
	[Value("profile")]
	public required DOMString Profile;
	[Value("entityTypes")]
	public List<XRHitTestTrackableType> EntityTypes;
	[Value("offsetRay")]
	public XRRay OffsetRay;
}

[ToObject]
public partial class XRRayDirectionInit
{
	[Value("x")]
	public Number X;
	[Value("y")]
	public Number Y;
	[Value("z")]
	public Number Z;
	[Value("w")]
	public Number W;
}

[ToObject]
public partial class XRLightProbeInit
{
	[Value("reflectionFormat")]
	public XRReflectionFormat ReflectionFormat;
}

public partial class XRSessionInit
{
	[Value("requiredFeatures")]
	public List<DOMString> RequiredFeatures;
	[Value("optionalFeatures")]
	public List<DOMString> OptionalFeatures;
}

[ToObject]
public partial class XRRenderStateInit
{
	[Value("depthNear")]
	public Number DepthNear;
	[Value("depthFar")]
	public Number DepthFar;
	[Value("inlineVerticalFieldOfView")]
	public Number InlineVerticalFieldOfView;
	[Value("baseLayer")]
	public XRWebGLLayer? BaseLayer;
	[Value("layers")]
	public List<XRLayer>? Layers;
}

[ToObject]
public partial class XRWebGLLayerInit
{
	[Value("antialias")]
	public bool Antialias;
	[Value("depth")]
	public bool Depth;
	[Value("stencil")]
	public bool Stencil;
	[Value("alpha")]
	public bool Alpha;
	[Value("ignoreDepthValues")]
	public bool IgnoreDepthValues;
	[Value("framebufferScaleFactor")]
	public Number FramebufferScaleFactor;
}

public partial class WebGLContextAttributes
{
	[Value("xrCompatible")]
	public bool XrCompatible;
}

[ToObject]
public partial class XRSessionEventInit : EventInit
{
	[Value("session")]
	public required XRSession Session;
}

[ToObject]
public partial class XRInputSourceEventInit : EventInit
{
	[Value("frame")]
	public required XRFrame Frame;
	[Value("inputSource")]
	public required XRInputSource InputSource;
}

[ToObject]
public partial class XRInputSourcesChangeEventInit : EventInit
{
	[Value("session")]
	public required XRSession Session;
	[Value("added")]
	public required List<XRInputSource> Added;
	[Value("removed")]
	public required List<XRInputSource> Removed;
}

[ToObject]
public partial class XRReferenceSpaceEventInit : EventInit
{
	[Value("referenceSpace")]
	public required XRReferenceSpace ReferenceSpace;
	[Value("transform")]
	public XRRigidTransform? Transform;
}

[ToObject]
public partial class XRSessionSupportedPermissionDescriptor : PermissionDescriptor
{
	[Value("mode")]
	public XRSessionMode Mode;
}

[ToObject]
public partial class XRPermissionDescriptor : PermissionDescriptor
{
	[Value("mode")]
	public XRSessionMode Mode;
	[Value("requiredFeatures")]
	public List<DOMString> RequiredFeatures;
	[Value("optionalFeatures")]
	public List<DOMString> OptionalFeatures;
}

[ToObject]
public partial class XRProjectionLayerInit
{
	[Value("textureType")]
	public XRTextureType TextureType;
	[Value("colorFormat")]
	public GLenum ColorFormat;
	[Value("depthFormat")]
	public GLenum DepthFormat;
	[Value("scaleFactor")]
	public Number ScaleFactor;
	[Value("clearOnAccess")]
	public bool ClearOnAccess;
}

[ToObject]
public partial class XRLayerInit
{
	[Value("space")]
	public required XRSpace Space;
	[Value("colorFormat")]
	public GLenum ColorFormat;
	[Value("depthFormat")]
	public GLenum? DepthFormat;
	[Value("mipLevels")]
	public ulong MipLevels;
	[Value("viewPixelWidth")]
	public required ulong ViewPixelWidth;
	[Value("viewPixelHeight")]
	public required ulong ViewPixelHeight;
	[Value("layout")]
	public XRLayerLayout Layout;
	[Value("isStatic")]
	public bool IsStatic;
	[Value("clearOnAccess")]
	public bool ClearOnAccess;
}

[ToObject]
public partial class XRQuadLayerInit : XRLayerInit
{
	[Value("textureType")]
	public XRTextureType TextureType;
	[Value("transform")]
	public XRRigidTransform? Transform;
	[Value("width")]
	public Number Width;
	[Value("height")]
	public Number Height;
}

[ToObject]
public partial class XRCylinderLayerInit : XRLayerInit
{
	[Value("textureType")]
	public XRTextureType TextureType;
	[Value("transform")]
	public XRRigidTransform? Transform;
	[Value("radius")]
	public Number Radius;
	[Value("centralAngle")]
	public Number CentralAngle;
	[Value("aspectRatio")]
	public Number AspectRatio;
}

[ToObject]
public partial class XREquirectLayerInit : XRLayerInit
{
	[Value("textureType")]
	public XRTextureType TextureType;
	[Value("transform")]
	public XRRigidTransform? Transform;
	[Value("radius")]
	public Number Radius;
	[Value("centralHorizontalAngle")]
	public Number CentralHorizontalAngle;
	[Value("upperVerticalAngle")]
	public Number UpperVerticalAngle;
	[Value("lowerVerticalAngle")]
	public Number LowerVerticalAngle;
}

[ToObject]
public partial class XRCubeLayerInit : XRLayerInit
{
	[Value("orientation")]
	public DOMPointReadOnly? Orientation;
}

[ToObject]
public partial class XRMediaLayerInit
{
	[Value("space")]
	public required XRSpace Space;
	[Value("layout")]
	public XRLayerLayout Layout;
	[Value("invertStereo")]
	public bool InvertStereo;
}

[ToObject]
public partial class XRMediaQuadLayerInit : XRMediaLayerInit
{
	[Value("transform")]
	public XRRigidTransform? Transform;
	[Value("width")]
	public Number? Width;
	[Value("height")]
	public Number? Height;
}

[ToObject]
public partial class XRMediaCylinderLayerInit : XRMediaLayerInit
{
	[Value("transform")]
	public XRRigidTransform? Transform;
	[Value("radius")]
	public Number Radius;
	[Value("centralAngle")]
	public Number CentralAngle;
	[Value("aspectRatio")]
	public Number? AspectRatio;
}

[ToObject]
public partial class XRMediaEquirectLayerInit : XRMediaLayerInit
{
	[Value("transform")]
	public XRRigidTransform? Transform;
	[Value("radius")]
	public Number Radius;
	[Value("centralHorizontalAngle")]
	public Number CentralHorizontalAngle;
	[Value("upperVerticalAngle")]
	public Number UpperVerticalAngle;
	[Value("lowerVerticalAngle")]
	public Number LowerVerticalAngle;
}

[ToObject]
public partial class XRLayerEventInit : EventInit
{
	[Value("layer")]
	public required XRLayer Layer;
}

[ToObject]
public partial class WindowControlsOverlayGeometryChangeEventInit : EventInit
{
	[Value("titlebarAreaRect")]
	public required DOMRect TitlebarAreaRect;
	[Value("visible")]
	public bool Visible;
}

public partial class FullscreenOptions
{
	[Value("screen")]
	public ScreenDetailed Screen;
}

[ToObject]
public partial class ProgressEventInit : EventInit
{
	[Value("lengthComputable")]
	public bool LengthComputable;
	[Value("loaded")]
	public ulong Loaded;
	[Value("total")]
	public ulong Total;
}

