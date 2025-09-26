//25.09.2025 17:09:11

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


[Value("Accelerometer")]
public partial class Accelerometer : Sensor
{
		public Accelerometer(AccelerometerSensorOptions options = default) { }
	[Value("x")]
	public Number? X { get; }
	[Value("y")]
	public Number? Y { get; }
	[Value("z")]
	public Number? Z { get; }
	public Accelerometer() { }
}

[Value("AccelerometerSensorOptions")]
public partial class AccelerometerSensorOptions : SensorOptions
{
	[Value("referenceFrame")]
	public AccelerometerLocalCoordinateSystem ReferenceFrame;
}

[Value("LinearAccelerationSensor")]
public partial class LinearAccelerationSensor : Accelerometer
{
		public LinearAccelerationSensor(AccelerometerSensorOptions options = default) { }
	public LinearAccelerationSensor() { }
}

[Value("GravitySensor")]
public partial class GravitySensor : Accelerometer
{
		public GravitySensor(AccelerometerSensorOptions options = default) { }
	public GravitySensor() { }
}

[Value("AmbientLightSensor")]
public partial class AmbientLightSensor : Sensor
{
		public AmbientLightSensor(SensorOptions sensorOptions = default) { }
	[Value("illuminance")]
	public Number? Illuminance { get; }
	public AmbientLightSensor() { }
}

[Value("XRAnchor")]
public partial class XRAnchor
{
	[Value("anchorSpace")]
	public XRSpace AnchorSpace { get; }
	[Value("requestPersistentHandle")]
	public Task<DOMString> RequestPersistentHandle() { throw new System.NotImplementedException(); }
	[Value("delete")]
	public Undefined Delete() { throw new System.NotImplementedException(); }
}

[Value("XRFrame")]
public partial class XRFrame
{
	[Value("createAnchor")]
	public Task<XRAnchor> CreateAnchor(XRRigidTransform pose, XRSpace space) { throw new System.NotImplementedException(); }
}

[Value("XRSession")]
public partial class XRSession
{
	[Value("persistentAnchors")]
	public DOMString[] PersistentAnchors { get; }
	[Value("restorePersistentAnchor")]
	public Task<XRAnchor> RestorePersistentAnchor(DOMString uuid) { throw new System.NotImplementedException(); }
	[Value("deletePersistentAnchor")]
	public Task<Undefined> DeletePersistentAnchor(DOMString uuid) { throw new System.NotImplementedException(); }
}

[Value("XRHitTestResult")]
public partial class XRHitTestResult
{
	[Value("createAnchor")]
	public Task<XRAnchor> CreateAnchor() { throw new System.NotImplementedException(); }
}

[Value("XRAnchorSet")]
public partial class XRAnchorSet
{
	
}

public partial class XRFrame
{
	[Value("trackedAnchors")]
	public XRAnchorSet TrackedAnchors { get; }
}

[Value("ANGLE_instanced_arrays")]
public partial class ANGLE_instanced_arrays
{
	[Value("VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE")]
	public const GLenum VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE = 0x88FE;
	[Value("drawArraysInstancedANGLE")]
	public Undefined DrawArraysInstancedANGLE(GLenum mode, GLint first, GLsizei count, GLsizei primcount) { throw new System.NotImplementedException(); }
	[Value("drawElementsInstancedANGLE")]
	public Undefined DrawElementsInstancedANGLE(GLenum mode, GLsizei count, GLenum type, GLintptr offset, GLsizei primcount) { throw new System.NotImplementedException(); }
	[Value("vertexAttribDivisorANGLE")]
	public Undefined VertexAttribDivisorANGLE(GLuint index, GLuint divisor) { throw new System.NotImplementedException(); }
}

[Value("HTMLIFrameElement")]
public partial class HTMLIFrameElement
{
	[Value("credentialless")]
	public bool Credentialless { get; set; }
}

[Value("Window")]
public partial class Window
{
	[Value("credentialless")]
	public bool Credentialless { get; }
}

[Value("AttributionReportingRequestOptions")]
public partial class AttributionReportingRequestOptions
{
	[Value("eventSourceEligible")]
	public required bool EventSourceEligible;
	[Value("triggerEligible")]
	public required bool TriggerEligible;
}

[Value("RequestInit")]
public partial class RequestInit
{
	[Value("attributionReporting")]
	public AttributionReportingRequestOptions AttributionReporting;
}

[Value("XMLHttpRequest")]
public partial class XMLHttpRequest
{
	[Value("setAttributionReporting")]
	public Undefined SetAttributionReporting(AttributionReportingRequestOptions options) { throw new System.NotImplementedException(); }
}

[Value("HTMLMediaElement")]
public partial class HTMLMediaElement
{
	[Value("sinkId")]
	public DOMString SinkId { get; }
	[Value("setSinkId")]
	public Task<Undefined> SetSinkId(DOMString sinkId) { throw new System.NotImplementedException(); }
}

[Value("MediaDevices")]
public partial class MediaDevices
{
	[Value("selectAudioOutput")]
	public Task<MediaDeviceInfo> SelectAudioOutput(AudioOutputOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("AudioOutputOptions")]
public partial class AudioOutputOptions
{
	[Value("deviceId")]
	public DOMString DeviceId;
}

[Value("AudioSession")]
public partial class AudioSession : EventTarget
{
	[Value("type")]
	public AudioSessionType Type { get; set; }
	[Value("state")]
	public AudioSessionState State { get; }
	[Value("onstatechange")]
	public EventHandler Onstatechange { get; set; }
}

[Value("Navigator")]
public partial class Navigator
{
	[Value("audioSession")]
	public AudioSession AudioSession { get; }
}

public partial class Navigator
{
	[Value("getAutoplayPolicy")]
	public AutoplayPolicy GetAutoplayPolicy(AutoplayPolicyMediaType type) { throw new System.NotImplementedException(); }
	[Value("getAutoplayPolicy")]
	public AutoplayPolicy GetAutoplayPolicy(HTMLMediaElement element) { throw new System.NotImplementedException(); }
	[Value("getAutoplayPolicy")]
	public AutoplayPolicy GetAutoplayPolicy(AudioContext context) { throw new System.NotImplementedException(); }
}

[Value("ServiceWorkerGlobalScope")]
public partial class ServiceWorkerGlobalScope
{
	[Value("onbackgroundfetchsuccess")]
	public EventHandler Onbackgroundfetchsuccess { get; set; }
	[Value("onbackgroundfetchfail")]
	public EventHandler Onbackgroundfetchfail { get; set; }
	[Value("onbackgroundfetchabort")]
	public EventHandler Onbackgroundfetchabort { get; set; }
	[Value("onbackgroundfetchclick")]
	public EventHandler Onbackgroundfetchclick { get; set; }
}

[Value("ServiceWorkerRegistration")]
public partial class ServiceWorkerRegistration
{
	[Value("backgroundFetch")]
	public BackgroundFetchManager BackgroundFetch { get; }
}

[Value("BackgroundFetchManager")]
public partial class BackgroundFetchManager
{
	[Value("fetch")]
	public Task<BackgroundFetchRegistration> Fetch(DOMString id, Union0 requests, BackgroundFetchOptions options = default) { throw new System.NotImplementedException(); }
	[Value("get")]
	public Task<BackgroundFetchRegistration?> Get(DOMString id) { throw new System.NotImplementedException(); }
	[Value("getIds")]
	public Task<List<DOMString>> GetIds() { throw new System.NotImplementedException(); }
}

[Value("BackgroundFetchUIOptions")]
public partial class BackgroundFetchUIOptions
{
	[Value("icons")]
	public List<ImageResource> Icons;
	[Value("title")]
	public DOMString Title;
}

[Value("BackgroundFetchOptions")]
public partial class BackgroundFetchOptions : BackgroundFetchUIOptions
{
	[Value("downloadTotal")]
	public ulong DownloadTotal;
}

[Value("BackgroundFetchRegistration")]
public partial class BackgroundFetchRegistration : EventTarget
{
	[Value("id")]
	public DOMString Id { get; }
	[Value("uploadTotal")]
	public ulong UploadTotal { get; }
	[Value("uploaded")]
	public ulong Uploaded { get; }
	[Value("downloadTotal")]
	public ulong DownloadTotal { get; }
	[Value("downloaded")]
	public ulong Downloaded { get; }
	[Value("result")]
	public BackgroundFetchResult Result { get; }
	[Value("failureReason")]
	public BackgroundFetchFailureReason FailureReason { get; }
	[Value("recordsAvailable")]
	public bool RecordsAvailable { get; }
	[Value("onprogress")]
	public EventHandler Onprogress { get; set; }
	[Value("abort")]
	public Task<bool> Abort() { throw new System.NotImplementedException(); }
	[Value("match")]
	public Task<BackgroundFetchRecord> Match(RequestInfo request, CacheQueryOptions options = default) { throw new System.NotImplementedException(); }
	[Value("matchAll")]
	public Task<List<BackgroundFetchRecord>> MatchAll(RequestInfo request = default, CacheQueryOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("BackgroundFetchRecord")]
public partial class BackgroundFetchRecord
{
	[Value("request")]
	public Request Request { get; }
	[Value("responseReady")]
	public Task<Response> ResponseReady { get; }
}

[Value("BackgroundFetchEvent")]
public partial class BackgroundFetchEvent : ExtendableEvent
{
		public BackgroundFetchEvent(DOMString type, BackgroundFetchEventInit init) { }
	[Value("registration")]
	public BackgroundFetchRegistration Registration { get; }
	public BackgroundFetchEvent() { }
}

[Value("BackgroundFetchEventInit")]
public partial class BackgroundFetchEventInit : ExtendableEventInit
{
	[Value("registration")]
	public required BackgroundFetchRegistration Registration;
}

[Value("BackgroundFetchUpdateUIEvent")]
public partial class BackgroundFetchUpdateUIEvent : BackgroundFetchEvent
{
		public BackgroundFetchUpdateUIEvent(DOMString type, BackgroundFetchEventInit init) { }
	[Value("updateUI")]
	public Task<Undefined> UpdateUI(BackgroundFetchUIOptions options = default) { throw new System.NotImplementedException(); }
	public BackgroundFetchUpdateUIEvent() { }
}

public partial class ServiceWorkerRegistration
{
	[Value("sync")]
	public SyncManager Sync { get; }
}

[Value("SyncManager")]
public partial class SyncManager
{
	[Value("register")]
	public Task<Undefined> Register(DOMString tag) { throw new System.NotImplementedException(); }
	[Value("getTags")]
	public Task<List<DOMString>> GetTags() { throw new System.NotImplementedException(); }
}

public partial class ServiceWorkerGlobalScope
{
	[Value("onsync")]
	public EventHandler Onsync { get; set; }
}

[Value("SyncEvent")]
public partial class SyncEvent : ExtendableEvent
{
		public SyncEvent(DOMString type, SyncEventInit init) { }
	[Value("tag")]
	public DOMString Tag { get; }
	[Value("lastChance")]
	public bool LastChance { get; }
	public SyncEvent() { }
}

[Value("SyncEventInit")]
public partial class SyncEventInit : ExtendableEventInit
{
	[Value("tag")]
	public required DOMString Tag;
	[Value("lastChance")]
	public bool LastChance;
}

public partial class Navigator
{
	[Value("getBattery")]
	public Task<BatteryManager> GetBattery() { throw new System.NotImplementedException(); }
}

[Value("BatteryManager")]
public partial class BatteryManager : EventTarget
{
	[Value("charging")]
	public bool Charging { get; }
	[Value("chargingTime")]
	public double ChargingTime { get; }
	[Value("dischargingTime")]
	public double DischargingTime { get; }
	[Value("level")]
	public Number Level { get; }
	[Value("onchargingchange")]
	public EventHandler Onchargingchange { get; set; }
	[Value("onchargingtimechange")]
	public EventHandler Onchargingtimechange { get; set; }
	[Value("ondischargingtimechange")]
	public EventHandler Ondischargingtimechange { get; set; }
	[Value("onlevelchange")]
	public EventHandler Onlevelchange { get; set; }
}

public partial class Navigator
{
	[Value("sendBeacon")]
	public bool SendBeacon(USVString url, BodyInit? data = default) { throw new System.NotImplementedException(); }
}

[Value("CaptureHandleConfig")]
public partial class CaptureHandleConfig
{
	[Value("exposeOrigin")]
	public bool ExposeOrigin;
	[Value("handle")]
	public DOMString Handle;
	[Value("permittedOrigins")]
	public List<DOMString> PermittedOrigins;
}

public partial class MediaDevices
{
	[Value("setCaptureHandleConfig")]
	public Undefined SetCaptureHandleConfig(CaptureHandleConfig config = default) { throw new System.NotImplementedException(); }
}

[Value("CaptureHandle")]
public partial class CaptureHandle
{
	[Value("origin")]
	public DOMString Origin;
	[Value("handle")]
	public DOMString Handle;
}

[Value("MediaStreamTrack")]
public partial class MediaStreamTrack
{
	[Value("getCaptureHandle")]
	public CaptureHandle? GetCaptureHandle() { throw new System.NotImplementedException(); }
}

public partial class MediaStreamTrack
{
	[Value("oncapturehandlechange")]
	public EventHandler Oncapturehandlechange { get; set; }
}

[Value("CapturedMouseEvent")]
public partial class CapturedMouseEvent : Event
{
		public CapturedMouseEvent(DOMString type, CapturedMouseEventInit eventInitDict = default) { }
	[Value("surfaceX")]
	public long SurfaceX { get; }
	[Value("surfaceY")]
	public long SurfaceY { get; }
	public CapturedMouseEvent() { }
}

[Value("CapturedMouseEventInit")]
public partial class CapturedMouseEventInit : EventInit
{
	[Value("surfaceX")]
	public long SurfaceX;
	[Value("surfaceY")]
	public long SurfaceY;
}

[Value("CaptureController")]
public partial class CaptureController
{
	[Value("oncapturedmousechange")]
	public EventHandler Oncapturedmousechange { get; set; }
}

[Value("ClipboardEventInit")]
public partial class ClipboardEventInit : EventInit
{
	[Value("clipboardData")]
	public DataTransfer? ClipboardData;
}

[Value("ClipboardEvent")]
public partial class ClipboardEvent : Event
{
		public ClipboardEvent(DOMString type, ClipboardEventInit eventInitDict = default) { }
	[Value("clipboardData")]
	public DataTransfer? ClipboardData { get; }
	public ClipboardEvent() { }
}

public partial class Navigator
{
	[Value("clipboard")]
	public Clipboard Clipboard { get; }
}


[Value("ClipboardItem")]
public partial class ClipboardItem
{
		public ClipboardItem(Dictionary<DOMString, ClipboardItemData> items, ClipboardItemOptions options = default) { }
	[Value("presentationStyle")]
	public PresentationStyle PresentationStyle { get; }
	[Value("types")]
	public DOMString[] Types { get; }
	[Value("getType")]
	public Task<Blob> GetType(DOMString type) { throw new System.NotImplementedException(); }
	[Value("supports")]
	public static bool Supports(DOMString type) { throw new System.NotImplementedException(); }
	public ClipboardItem() { }
}

[Value("ClipboardItemOptions")]
public partial class ClipboardItemOptions
{
	[Value("presentationStyle")]
	public PresentationStyle PresentationStyle;
}


[Value("Clipboard")]
public partial class Clipboard : EventTarget
{
	[Value("read")]
	public Task<ClipboardItems> Read(ClipboardUnsanitizedFormats formats = default) { throw new System.NotImplementedException(); }
	[Value("readText")]
	public Task<DOMString> ReadText() { throw new System.NotImplementedException(); }
	[Value("write")]
	public Task<Undefined> Write(ClipboardItems data) { throw new System.NotImplementedException(); }
	[Value("writeText")]
	public Task<Undefined> WriteText(DOMString data) { throw new System.NotImplementedException(); }
}

[Value("ClipboardUnsanitizedFormats")]
public partial class ClipboardUnsanitizedFormats
{
	[Value("unsanitized")]
	public List<DOMString> Unsanitized;
}

[Value("ClipboardPermissionDescriptor")]
public partial class ClipboardPermissionDescriptor : PermissionDescriptor
{
	[Value("allowWithoutGesture")]
	public bool AllowWithoutGesture;
}

public partial class Window
{
	[Value("orientation")]
	public Number Orientation { get; }
	[Value("onorientationchange")]
	public EventHandler Onorientationchange { get; set; }
}

[Value("HTMLBodyElement")]
public partial class HTMLBodyElement
{
	[Value("onorientationchange")]
	public EventHandler Onorientationchange { get; set; }
}

[Value("CompressionStream")]
public partial class CompressionStream
{
		public CompressionStream(CompressionFormat format) { }
	public CompressionStream() { }
}


[Value("DecompressionStream")]
public partial class DecompressionStream
{
		public DecompressionStream(CompressionFormat format) { }
	public DecompressionStream() { }
}


[Value("PressureObserver")]
public partial class PressureObserver
{
		public PressureObserver(PressureUpdateCallback callback) { }
	[Value("observe")]
	public Task<Undefined> Observe(PressureSource source, PressureObserverOptions options = default) { throw new System.NotImplementedException(); }
	[Value("unobserve")]
	public Undefined Unobserve(PressureSource source) { throw new System.NotImplementedException(); }
	[Value("disconnect")]
	public Undefined Disconnect() { throw new System.NotImplementedException(); }
	[Value("takeRecords")]
	public List<PressureRecord> TakeRecords() { throw new System.NotImplementedException(); }
	[Value("knownSources")]
	public static PressureSource[] KnownSources { get; }
	public PressureObserver() { }
}

[Value("PressureRecord")]
public partial class PressureRecord
{
	[Value("source")]
	public PressureSource Source { get; }
	[Value("state")]
	public PressureState State { get; }
	[Value("time")]
	public DOMHighResTimeStamp Time { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

[Value("PressureObserverOptions")]
public partial class PressureObserverOptions
{
	[Value("sampleInterval")]
	public ulong SampleInterval;
}

[Value("console")]
public partial class console
{
	[Value("assert")]
	public Undefined Assert(bool condition = default, params dynamic[] data) { throw new System.NotImplementedException(); }
	[Value("clear")]
	public Undefined Clear() { throw new System.NotImplementedException(); }
	[Value("debug")]
	public Undefined Debug(params dynamic[] data) { throw new System.NotImplementedException(); }
	[Value("error")]
	public Undefined Error(params dynamic[] data) { throw new System.NotImplementedException(); }
	[Value("info")]
	public Undefined Info(params dynamic[] data) { throw new System.NotImplementedException(); }
	[Value("log")]
	public Undefined Log(params dynamic[] data) { throw new System.NotImplementedException(); }
	[Value("table")]
	public Undefined Table(dynamic tabularData = default, List<DOMString> properties = default) { throw new System.NotImplementedException(); }
	[Value("trace")]
	public Undefined Trace(params dynamic[] data) { throw new System.NotImplementedException(); }
	[Value("warn")]
	public Undefined Warn(params dynamic[] data) { throw new System.NotImplementedException(); }
	[Value("dir")]
	public Undefined Dir(dynamic item = default, Object? options = default) { throw new System.NotImplementedException(); }
	[Value("dirxml")]
	public Undefined Dirxml(params dynamic[] data) { throw new System.NotImplementedException(); }
	[Value("count")]
	public Undefined Count(DOMString label = default) { throw new System.NotImplementedException(); }
	[Value("countReset")]
	public Undefined CountReset(DOMString label = default) { throw new System.NotImplementedException(); }
	[Value("group")]
	public Undefined Group(params dynamic[] data) { throw new System.NotImplementedException(); }
	[Value("groupCollapsed")]
	public Undefined GroupCollapsed(params dynamic[] data) { throw new System.NotImplementedException(); }
	[Value("groupEnd")]
	public Undefined GroupEnd() { throw new System.NotImplementedException(); }
	[Value("time")]
	public Undefined Time(DOMString label = default) { throw new System.NotImplementedException(); }
	[Value("timeLog")]
	public Undefined TimeLog(DOMString label = default, params dynamic[] data) { throw new System.NotImplementedException(); }
	[Value("timeEnd")]
	public Undefined TimeEnd(DOMString label = default) { throw new System.NotImplementedException(); }
}

public partial class Navigator
{
	[Value("contacts")]
	public ContactsManager Contacts { get; }
}

[Value("ContactAddress")]
public partial class ContactAddress
{
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
	[Value("city")]
	public DOMString City { get; }
	[Value("country")]
	public DOMString Country { get; }
	[Value("dependentLocality")]
	public DOMString DependentLocality { get; }
	[Value("organization")]
	public DOMString Organization { get; }
	[Value("phone")]
	public DOMString Phone { get; }
	[Value("postalCode")]
	public DOMString PostalCode { get; }
	[Value("recipient")]
	public DOMString Recipient { get; }
	[Value("region")]
	public DOMString Region { get; }
	[Value("sortingCode")]
	public DOMString SortingCode { get; }
	[Value("addressLine")]
	public DOMString[] AddressLine { get; }
}

[Value("ContactInfo")]
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

[Value("ContactsSelectOptions")]
public partial class ContactsSelectOptions
{
	[Value("multiple")]
	public bool Multiple;
}

[Value("ContactsManager")]
public partial class ContactsManager
{
	[Value("getProperties")]
	public Task<List<ContactProperty>> GetProperties() { throw new System.NotImplementedException(); }
	[Value("select")]
	public Task<List<ContactInfo>> Select(List<ContactProperty> properties, ContactsSelectOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class ServiceWorkerGlobalScope
{
	[Value("oncontentdelete")]
	public EventHandler Oncontentdelete { get; set; }
}

public partial class ServiceWorkerRegistration
{
	[Value("index")]
	public ContentIndex Index { get; }
}

[Value("ContentDescription")]
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

[Value("ContentIndex")]
public partial class ContentIndex
{
	[Value("add")]
	public Task<Undefined> Add(ContentDescription description) { throw new System.NotImplementedException(); }
	[Value("delete")]
	public Task<Undefined> Delete(DOMString id) { throw new System.NotImplementedException(); }
	[Value("getAll")]
	public Task<List<ContentDescription>> GetAll() { throw new System.NotImplementedException(); }
}

[Value("ContentIndexEventInit")]
public partial class ContentIndexEventInit : ExtendableEventInit
{
	[Value("id")]
	public required DOMString Id;
}

[Value("ContentIndexEvent")]
public partial class ContentIndexEvent : ExtendableEvent
{
		public ContentIndexEvent(DOMString type, ContentIndexEventInit init) { }
	[Value("id")]
	public DOMString Id { get; }
	public ContentIndexEvent() { }
}

[Value("CookieStore")]
public partial class CookieStore : EventTarget
{
	[Value("get")]
	public Task<CookieListItem?> Get(USVString name) { throw new System.NotImplementedException(); }
	[Value("get")]
	public Task<CookieListItem?> Get(CookieStoreGetOptions options = default) { throw new System.NotImplementedException(); }
	[Value("getAll")]
	public Task<CookieList> GetAll(USVString name) { throw new System.NotImplementedException(); }
	[Value("getAll")]
	public Task<CookieList> GetAll(CookieStoreGetOptions options = default) { throw new System.NotImplementedException(); }
	[Value("set")]
	public Task<Undefined> Set(USVString name, USVString value) { throw new System.NotImplementedException(); }
	[Value("set")]
	public Task<Undefined> Set(CookieInit options) { throw new System.NotImplementedException(); }
	[Value("delete")]
	public Task<Undefined> Delete(USVString name) { throw new System.NotImplementedException(); }
	[Value("delete")]
	public Task<Undefined> Delete(CookieStoreDeleteOptions options) { throw new System.NotImplementedException(); }
	[Value("onchange")]
	public EventHandler Onchange { get; set; }
}

[Value("CookieStoreGetOptions")]
public partial class CookieStoreGetOptions
{
	[Value("name")]
	public USVString Name;
	[Value("url")]
	public USVString Url;
}

[Value("CookieInit")]
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

[Value("CookieStoreDeleteOptions")]
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

[Value("CookieListItem")]
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


[Value("CookieStoreManager")]
public partial class CookieStoreManager
{
	[Value("subscribe")]
	public Task<Undefined> Subscribe(List<CookieStoreGetOptions> subscriptions) { throw new System.NotImplementedException(); }
	[Value("getSubscriptions")]
	public Task<List<CookieStoreGetOptions>> GetSubscriptions() { throw new System.NotImplementedException(); }
	[Value("unsubscribe")]
	public Task<Undefined> Unsubscribe(List<CookieStoreGetOptions> subscriptions) { throw new System.NotImplementedException(); }
}

public partial class ServiceWorkerRegistration
{
	[Value("cookies")]
	public CookieStoreManager Cookies { get; }
}

[Value("CookieChangeEvent")]
public partial class CookieChangeEvent : Event
{
		public CookieChangeEvent(DOMString type, CookieChangeEventInit eventInitDict = default) { }
	[Value("changed")]
	public CookieListItem[] Changed { get; }
	[Value("deleted")]
	public CookieListItem[] Deleted { get; }
	public CookieChangeEvent() { }
}

[Value("CookieChangeEventInit")]
public partial class CookieChangeEventInit : EventInit
{
	[Value("changed")]
	public CookieList Changed;
	[Value("deleted")]
	public CookieList Deleted;
}

[Value("ExtendableCookieChangeEvent")]
public partial class ExtendableCookieChangeEvent : ExtendableEvent
{
		public ExtendableCookieChangeEvent(DOMString type, ExtendableCookieChangeEventInit eventInitDict = default) { }
	[Value("changed")]
	public CookieListItem[] Changed { get; }
	[Value("deleted")]
	public CookieListItem[] Deleted { get; }
	public ExtendableCookieChangeEvent() { }
}

[Value("ExtendableCookieChangeEventInit")]
public partial class ExtendableCookieChangeEventInit : ExtendableEventInit
{
	[Value("changed")]
	public CookieList Changed;
	[Value("deleted")]
	public CookieList Deleted;
}

public partial class Window
{
	[Value("cookieStore")]
	public CookieStore CookieStore { get; }
}

public partial class ServiceWorkerGlobalScope
{
	[Value("cookieStore")]
	public CookieStore CookieStore { get; }
	[Value("oncookiechange")]
	public EventHandler Oncookiechange { get; set; }
}

[Value("CrashReportBody")]
public partial class CrashReportBody : ReportBody
{
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
	[Value("reason")]
	public DOMString? Reason { get; }
	[Value("stack")]
	public DOMString? Stack { get; }
}

[Value("Credential")]
public partial class Credential
{
	[Value("id")]
	public USVString Id { get; }
	[Value("type")]
	public DOMString Type { get; }
	[Value("isConditionalMediationAvailable")]
	public static Task<bool> IsConditionalMediationAvailable() { throw new System.NotImplementedException(); }
	[Value("willRequestConditionalCreation")]
	public static Task<Undefined> WillRequestConditionalCreation() { throw new System.NotImplementedException(); }
}

public partial class Navigator
{
	[Value("credentials")]
	public CredentialsContainer Credentials { get; }
}

[Value("CredentialsContainer")]
public partial class CredentialsContainer
{
	[Value("get")]
	public Task<Credential?> Get(CredentialRequestOptions options = default) { throw new System.NotImplementedException(); }
	[Value("store")]
	public Task<Undefined> Store(Credential credential) { throw new System.NotImplementedException(); }
	[Value("create")]
	public Task<Credential?> Create(CredentialCreationOptions options = default) { throw new System.NotImplementedException(); }
	[Value("preventSilentAccess")]
	public Task<Undefined> PreventSilentAccess() { throw new System.NotImplementedException(); }
}

[Value("CredentialData")]
public partial class CredentialData
{
	[Value("id")]
	public required USVString Id;
}

[Value("CredentialRequestOptions")]
public partial class CredentialRequestOptions
{
	[Value("mediation")]
	public CredentialMediationRequirement Mediation;
	[Value("signal")]
	public AbortSignal Signal;
}

[Value("CredentialCreationOptions")]
public partial class CredentialCreationOptions
{
	[Value("mediation")]
	public CredentialMediationRequirement Mediation;
	[Value("signal")]
	public AbortSignal Signal;
}

[Value("PasswordCredential")]
public partial class PasswordCredential : Credential, CredentialUserData
{
		public PasswordCredential(HTMLFormElement form) { }
		public PasswordCredential(PasswordCredentialData data) { }
	[Value("password")]
	public USVString Password { get; }
	public PasswordCredential() { }
}


public partial class CredentialRequestOptions
{
	[Value("password")]
	public bool Password;
}

[Value("PasswordCredentialData")]
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

[Value("FederatedCredential")]
public partial class FederatedCredential : Credential, CredentialUserData
{
		public FederatedCredential(FederatedCredentialInit data) { }
	[Value("provider")]
	public USVString Provider { get; }
	[Value("protocol")]
	public DOMString? Protocol { get; }
	public FederatedCredential() { }
}


[Value("FederatedCredentialRequestOptions")]
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

[Value("FederatedCredentialInit")]
public partial class FederatedCredentialInit : CredentialData
{
	[Value("name")]
	public USVString Name;
	[Value("iconURL")]
	public USVString IconURL;
	[Value("origin")]
	public required USVString Origin;
	[Value("provider")]
	public required USVString Provider;
	[Value("protocol")]
	public DOMString Protocol;
}

public partial class CredentialCreationOptions
{
	[Value("federated")]
	public FederatedCredentialInit Federated;
}

public partial class HTMLIFrameElement
{
	[Value("csp")]
	public DOMString Csp { get; set; }
}

[Value("ScriptingPolicyReportBody")]
public partial class ScriptingPolicyReportBody : ReportBody
{
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
	[Value("violationType")]
	public DOMString ViolationType { get; }
	[Value("violationURL")]
	public USVString? ViolationURL { get; }
	[Value("violationSample")]
	public USVString? ViolationSample { get; }
	[Value("lineno")]
	public ulong Lineno { get; }
	[Value("colno")]
	public ulong Colno { get; }
}

[Value("CSPViolationReportBody")]
public partial class CSPViolationReportBody : ReportBody
{
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
	[Value("documentURL")]
	public USVString DocumentURL { get; }
	[Value("referrer")]
	public USVString? Referrer { get; }
	[Value("blockedURL")]
	public USVString? BlockedURL { get; }
	[Value("effectiveDirective")]
	public DOMString EffectiveDirective { get; }
	[Value("originalPolicy")]
	public DOMString OriginalPolicy { get; }
	[Value("sourceFile")]
	public USVString? SourceFile { get; }
	[Value("sample")]
	public DOMString? Sample { get; }
	[Value("disposition")]
	public SecurityPolicyViolationEventDisposition Disposition { get; }
	[Value("statusCode")]
	public ushort StatusCode { get; }
	[Value("lineNumber")]
	public ulong? LineNumber { get; }
	[Value("columnNumber")]
	public ulong? ColumnNumber { get; }
}

[Value("SecurityPolicyViolationEvent")]
public partial class SecurityPolicyViolationEvent : Event
{
		public SecurityPolicyViolationEvent(DOMString type, SecurityPolicyViolationEventInit eventInitDict = default) { }
	[Value("documentURI")]
	public USVString DocumentURI { get; }
	[Value("referrer")]
	public USVString Referrer { get; }
	[Value("blockedURI")]
	public USVString BlockedURI { get; }
	[Value("effectiveDirective")]
	public DOMString EffectiveDirective { get; }
	[Value("violatedDirective")]
	public DOMString ViolatedDirective { get; }
	[Value("originalPolicy")]
	public DOMString OriginalPolicy { get; }
	[Value("sourceFile")]
	public USVString SourceFile { get; }
	[Value("sample")]
	public DOMString Sample { get; }
	[Value("disposition")]
	public SecurityPolicyViolationEventDisposition Disposition { get; }
	[Value("statusCode")]
	public ushort StatusCode { get; }
	[Value("lineNumber")]
	public ulong LineNumber { get; }
	[Value("columnNumber")]
	public ulong ColumnNumber { get; }
	public SecurityPolicyViolationEvent() { }
}

[Value("SecurityPolicyViolationEventInit")]
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

[Value("CSSPositionTryRule")]
public partial class CSSPositionTryRule : CSSRule
{
	[Value("name")]
	public CSSOMString Name { get; }
	[Value("style")]
	public CSSPositionTryDescriptors Style { get; }
}

[Value("CSSPositionTryDescriptors")]
public partial class CSSPositionTryDescriptors : CSSStyleDeclaration
{
	[Value("margin")]
	public CSSOMString Margin { get; set; }
	[Value("marginTop")]
	public CSSOMString MarginTop { get; set; }
	[Value("marginRight")]
	public CSSOMString MarginRight { get; set; }
	[Value("marginBottom")]
	public CSSOMString MarginBottom { get; set; }
	[Value("marginLeft")]
	public CSSOMString MarginLeft { get; set; }
	[Value("marginBlock")]
	public CSSOMString MarginBlock { get; set; }
	[Value("marginBlockStart")]
	public CSSOMString MarginBlockStart { get; set; }
	[Value("marginBlockEnd")]
	public CSSOMString MarginBlockEnd { get; set; }
	[Value("marginInline")]
	public CSSOMString MarginInline { get; set; }
	[Value("marginInlineStart")]
	public CSSOMString MarginInlineStart { get; set; }
	[Value("marginInlineEnd")]
	public CSSOMString MarginInlineEnd { get; set; }
	[Value("margin-top")]
	public CSSOMString Margin_top { get; set; }
	[Value("margin-right")]
	public CSSOMString Margin_right { get; set; }
	[Value("margin-bottom")]
	public CSSOMString Margin_bottom { get; set; }
	[Value("margin-left")]
	public CSSOMString Margin_left { get; set; }
	[Value("margin-block")]
	public CSSOMString Margin_block { get; set; }
	[Value("margin-block-start")]
	public CSSOMString Margin_block_start { get; set; }
	[Value("margin-block-end")]
	public CSSOMString Margin_block_end { get; set; }
	[Value("margin-inline")]
	public CSSOMString Margin_inline { get; set; }
	[Value("margin-inline-start")]
	public CSSOMString Margin_inline_start { get; set; }
	[Value("margin-inline-end")]
	public CSSOMString Margin_inline_end { get; set; }
	[Value("inset")]
	public CSSOMString Inset { get; set; }
	[Value("insetBlock")]
	public CSSOMString InsetBlock { get; set; }
	[Value("insetBlockStart")]
	public CSSOMString InsetBlockStart { get; set; }
	[Value("insetBlockEnd")]
	public CSSOMString InsetBlockEnd { get; set; }
	[Value("insetInline")]
	public CSSOMString InsetInline { get; set; }
	[Value("insetInlineStart")]
	public CSSOMString InsetInlineStart { get; set; }
	[Value("insetInlineEnd")]
	public CSSOMString InsetInlineEnd { get; set; }
	[Value("top")]
	public CSSOMString Top { get; set; }
	[Value("left")]
	public CSSOMString Left { get; set; }
	[Value("right")]
	public CSSOMString Right { get; set; }
	[Value("bottom")]
	public CSSOMString Bottom { get; set; }
	[Value("inset-block")]
	public CSSOMString Inset_block { get; set; }
	[Value("inset-block-start")]
	public CSSOMString Inset_block_start { get; set; }
	[Value("inset-block-end")]
	public CSSOMString Inset_block_end { get; set; }
	[Value("inset-inline")]
	public CSSOMString Inset_inline { get; set; }
	[Value("inset-inline-start")]
	public CSSOMString Inset_inline_start { get; set; }
	[Value("inset-inline-end")]
	public CSSOMString Inset_inline_end { get; set; }
	[Value("width")]
	public CSSOMString Width { get; set; }
	[Value("minWidth")]
	public CSSOMString MinWidth { get; set; }
	[Value("maxWidth")]
	public CSSOMString MaxWidth { get; set; }
	[Value("height")]
	public CSSOMString Height { get; set; }
	[Value("minHeight")]
	public CSSOMString MinHeight { get; set; }
	[Value("maxHeight")]
	public CSSOMString MaxHeight { get; set; }
	[Value("blockSize")]
	public CSSOMString BlockSize { get; set; }
	[Value("minBlockSize")]
	public CSSOMString MinBlockSize { get; set; }
	[Value("maxBlockSize")]
	public CSSOMString MaxBlockSize { get; set; }
	[Value("inlineSize")]
	public CSSOMString InlineSize { get; set; }
	[Value("minInlineSize")]
	public CSSOMString MinInlineSize { get; set; }
	[Value("maxInlineSize")]
	public CSSOMString MaxInlineSize { get; set; }
	[Value("min-width")]
	public CSSOMString Min_width { get; set; }
	[Value("max-width")]
	public CSSOMString Max_width { get; set; }
	[Value("min-height")]
	public CSSOMString Min_height { get; set; }
	[Value("max-height")]
	public CSSOMString Max_height { get; set; }
	[Value("block-size")]
	public CSSOMString Block_size { get; set; }
	[Value("min-block-size")]
	public CSSOMString Min_block_size { get; set; }
	[Value("max-block-size")]
	public CSSOMString Max_block_size { get; set; }
	[Value("inline-size")]
	public CSSOMString Inline_size { get; set; }
	[Value("min-inline-size")]
	public CSSOMString Min_inline_size { get; set; }
	[Value("max-inline-size")]
	public CSSOMString Max_inline_size { get; set; }
	[Value("placeSelf")]
	public CSSOMString PlaceSelf { get; set; }
	[Value("alignSelf")]
	public CSSOMString AlignSelf { get; set; }
	[Value("justifySelf")]
	public CSSOMString JustifySelf { get; set; }
	[Value("place-self")]
	public CSSOMString Place_self { get; set; }
	[Value("align-self")]
	public CSSOMString Align_self { get; set; }
	[Value("justify-self")]
	public CSSOMString Justify_self { get; set; }
	[Value("positionAnchor")]
	public CSSOMString PositionAnchor { get; set; }
	[Value("position-anchor")]
	public CSSOMString Position_anchor { get; set; }
	[Value("positionArea")]
	public CSSOMString PositionArea { get; set; }
	[Value("position-area")]
	public CSSOMString Position_area { get; set; }
}

[Value("CSS")]
public partial class CSS
{
	[Value("animationWorklet")]
	public Worklet AnimationWorklet { get; }
}

[Value("AnimationWorkletGlobalScope")]
public partial class AnimationWorkletGlobalScope : WorkletGlobalScope
{
	[Value("registerAnimator")]
	public Undefined RegisterAnimator(DOMString name, AnimatorInstanceConstructor animatorCtor) { throw new System.NotImplementedException(); }
}

[Value("WorkletAnimationEffect")]
public partial class WorkletAnimationEffect
{
	[Value("getTiming")]
	public EffectTiming GetTiming() { throw new System.NotImplementedException(); }
	[Value("getComputedTiming")]
	public ComputedEffectTiming GetComputedTiming() { throw new System.NotImplementedException(); }
	[Value("localTime")]
	public Number? LocalTime { get; set; }
}

[Value("WorkletAnimation")]
public partial class WorkletAnimation : Animation
{
		public WorkletAnimation(DOMString animatorName, Union2? effects = default, AnimationTimeline? timeline = default, dynamic options = default) { }
	[Value("animatorName")]
	public DOMString AnimatorName { get; }
	public WorkletAnimation() { }
}

[Value("WorkletGroupEffect")]
public partial class WorkletGroupEffect
{
	[Value("getChildren")]
	public List<WorkletAnimationEffect> GetChildren() { throw new System.NotImplementedException(); }
}

[Value("CSSAnimation")]
public partial class CSSAnimation : Animation
{
	[Value("animationName")]
	public CSSOMString AnimationName { get; }
}

[Value("AnimationEvent")]
public partial class AnimationEvent : Event
{
		public AnimationEvent(CSSOMString type, AnimationEventInit animationEventInitDict = default) { }
	[Value("animationName")]
	public CSSOMString AnimationName { get; }
	[Value("elapsedTime")]
	public Number ElapsedTime { get; }
	[Value("pseudoElement")]
	public CSSOMString PseudoElement { get; }
	public AnimationEvent() { }
}

[Value("AnimationEventInit")]
public partial class AnimationEventInit : EventInit
{
	[Value("animationName")]
	public CSSOMString AnimationName;
	[Value("elapsedTime")]
	public Number ElapsedTime;
	[Value("pseudoElement")]
	public CSSOMString PseudoElement;
}

[Value("CSSRule")]
public partial class CSSRule
{
	[Value("KEYFRAMES_RULE")]
	public const ushort KEYFRAMES_RULE = 7;
	[Value("KEYFRAME_RULE")]
	public const ushort KEYFRAME_RULE = 8;
}

[Value("CSSKeyframeRule")]
public partial class CSSKeyframeRule : CSSRule
{
	[Value("keyText")]
	public CSSOMString KeyText { get; set; }
	[Value("style")]
	public CSSStyleProperties Style { get; }
}

[Value("CSSKeyframesRule")]
public partial class CSSKeyframesRule : CSSRule
{
	[Value("name")]
	public CSSOMString Name { get; set; }
	[Value("cssRules")]
	public CSSRuleList CssRules { get; }
	[Value("length")]
	public ulong Length { get; }
	
	[Value("appendRule")]
	public Undefined AppendRule(CSSOMString rule) { throw new System.NotImplementedException(); }
	[Value("deleteRule")]
	public Undefined DeleteRule(CSSOMString select) { throw new System.NotImplementedException(); }
	[Value("findRule")]
	public CSSKeyframeRule? FindRule(CSSOMString select) { throw new System.NotImplementedException(); }
}

[Value("CSSScopeRule")]
public partial class CSSScopeRule : CSSGroupingRule
{
	[Value("start")]
	public CSSOMString? Start { get; }
	[Value("end")]
	public CSSOMString? End { get; }
}

[Value("CSSLayerBlockRule")]
public partial class CSSLayerBlockRule : CSSGroupingRule
{
	[Value("name")]
	public CSSOMString Name { get; }
}

[Value("CSSLayerStatementRule")]
public partial class CSSLayerStatementRule : CSSRule
{
	[Value("nameList")]
	public CSSOMString[] NameList { get; }
}

[Value("CSSColorProfileRule")]
public partial class CSSColorProfileRule : CSSRule
{
	[Value("name")]
	public CSSOMString Name { get; }
	[Value("src")]
	public CSSOMString Src { get; }
	[Value("renderingIntent")]
	public CSSOMString RenderingIntent { get; }
	[Value("components")]
	public CSSOMString Components { get; }
}

[Value("CSSContainerRule")]
public partial class CSSContainerRule : CSSConditionRule
{
	[Value("containerName")]
	public CSSOMString ContainerName { get; }
	[Value("containerQuery")]
	public CSSOMString ContainerQuery { get; }
}

public partial class CSSRule
{
	[Value("SUPPORTS_RULE")]
	public const ushort SUPPORTS_RULE = 12;
}

[Value("CSSConditionRule")]
public partial class CSSConditionRule : CSSGroupingRule
{
	[Value("conditionText")]
	public CSSOMString ConditionText { get; }
}

[Value("CSSMediaRule")]
public partial class CSSMediaRule : CSSConditionRule
{
	[Value("media")]
	public MediaList Media { get; }
	[Value("matches")]
	public bool Matches { get; }
}

[Value("CSSSupportsRule")]
public partial class CSSSupportsRule : CSSConditionRule
{
	[Value("matches")]
	public bool Matches { get; }
}

public partial class CSS
{
	[Value("supports")]
	public bool Supports(CSSOMString property, CSSOMString value) { throw new System.NotImplementedException(); }
	[Value("supports")]
	public bool Supports(CSSOMString conditionText) { throw new System.NotImplementedException(); }
}

[Value("ContentVisibilityAutoStateChangeEvent")]
public partial class ContentVisibilityAutoStateChangeEvent : Event
{
		public ContentVisibilityAutoStateChangeEvent(DOMString type, ContentVisibilityAutoStateChangeEventInit eventInitDict = default) { }
	[Value("skipped")]
	public bool Skipped { get; }
	public ContentVisibilityAutoStateChangeEvent() { }
}

[Value("ContentVisibilityAutoStateChangeEventInit")]
public partial class ContentVisibilityAutoStateChangeEventInit : EventInit
{
	[Value("skipped")]
	public bool Skipped;
}

public partial class CSSRule
{
	[Value("COUNTER_STYLE_RULE")]
	public const ushort COUNTER_STYLE_RULE = 11;
}

[Value("CSSCounterStyleRule")]
public partial class CSSCounterStyleRule : CSSRule
{
	[Value("name")]
	public CSSOMString Name { get; set; }
	[Value("system")]
	public CSSOMString System { get; set; }
	[Value("symbols")]
	public CSSOMString Symbols { get; set; }
	[Value("additiveSymbols")]
	public CSSOMString AdditiveSymbols { get; set; }
	[Value("negative")]
	public CSSOMString Negative { get; set; }
	[Value("prefix")]
	public CSSOMString Prefix { get; set; }
	[Value("suffix")]
	public CSSOMString Suffix { get; set; }
	[Value("range")]
	public CSSOMString Range { get; set; }
	[Value("pad")]
	public CSSOMString Pad { get; set; }
	[Value("speakAs")]
	public CSSOMString SpeakAs { get; set; }
	[Value("fallback")]
	public CSSOMString Fallback { get; set; }
}

[Value("FontFaceDescriptors")]
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

[Value("FontFace")]
public partial class FontFace
{
		public FontFace(CSSOMString family, Union3 source, FontFaceDescriptors descriptors = default) { }
	[Value("family")]
	public CSSOMString Family { get; set; }
	[Value("style")]
	public CSSOMString Style { get; set; }
	[Value("weight")]
	public CSSOMString Weight { get; set; }
	[Value("stretch")]
	public CSSOMString Stretch { get; set; }
	[Value("unicodeRange")]
	public CSSOMString UnicodeRange { get; set; }
	[Value("featureSettings")]
	public CSSOMString FeatureSettings { get; set; }
	[Value("variationSettings")]
	public CSSOMString VariationSettings { get; set; }
	[Value("display")]
	public CSSOMString Display { get; set; }
	[Value("ascentOverride")]
	public CSSOMString AscentOverride { get; set; }
	[Value("descentOverride")]
	public CSSOMString DescentOverride { get; set; }
	[Value("lineGapOverride")]
	public CSSOMString LineGapOverride { get; set; }
	[Value("status")]
	public FontFaceLoadStatus Status { get; }
	[Value("load")]
	public Task<FontFace> Load() { throw new System.NotImplementedException(); }
	[Value("loaded")]
	public Task<FontFace> Loaded { get; }
	public FontFace() { }
}

[Value("FontFaceFeatures")]
public partial class FontFaceFeatures
{
}

[Value("FontFaceVariationAxis")]
public partial class FontFaceVariationAxis
{
	[Value("name")]
	public DOMString Name { get; }
	[Value("axisTag")]
	public DOMString AxisTag { get; }
	[Value("minimumValue")]
	public Number MinimumValue { get; }
	[Value("maximumValue")]
	public Number MaximumValue { get; }
	[Value("defaultValue")]
	public Number DefaultValue { get; }
}

[Value("FontFaceVariations")]
public partial class FontFaceVariations
{
	
}

[Value("FontFacePalette")]
public partial class FontFacePalette
{
	public DOMString this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	[Value("length")]
	public ulong Length { get; }
	
	[Value("usableWithLightBackground")]
	public bool UsableWithLightBackground { get; }
	[Value("usableWithDarkBackground")]
	public bool UsableWithDarkBackground { get; }
}

[Value("FontFacePalettes")]
public partial class FontFacePalettes
{
	public FontFacePalette this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	[Value("length")]
	public ulong Length { get; }
	
}

public partial class FontFace
{
	[Value("features")]
	public FontFaceFeatures Features { get; }
	[Value("variations")]
	public FontFaceVariations Variations { get; }
	[Value("palettes")]
	public FontFacePalettes Palettes { get; }
}

[Value("FontFaceSetLoadEventInit")]
public partial class FontFaceSetLoadEventInit : EventInit
{
	[Value("fontfaces")]
	public List<FontFace> Fontfaces;
}

[Value("FontFaceSetLoadEvent")]
public partial class FontFaceSetLoadEvent : Event
{
		public FontFaceSetLoadEvent(CSSOMString type, FontFaceSetLoadEventInit eventInitDict = default) { }
	[Value("fontfaces")]
	public FontFace[] Fontfaces { get; }
	public FontFaceSetLoadEvent() { }
}

[Value("FontFaceSet")]
public partial class FontFaceSet : EventTarget
{
	
	[Value("add")]
	public FontFaceSet Add(FontFace font) { throw new System.NotImplementedException(); }
	[Value("delete")]
	public bool Delete(FontFace font) { throw new System.NotImplementedException(); }
	[Value("clear")]
	public Undefined Clear() { throw new System.NotImplementedException(); }
	[Value("onloading")]
	public EventHandler Onloading { get; set; }
	[Value("onloadingdone")]
	public EventHandler Onloadingdone { get; set; }
	[Value("onloadingerror")]
	public EventHandler Onloadingerror { get; set; }
	[Value("load")]
	public Task<List<FontFace>> Load(CSSOMString font, CSSOMString text = default) { throw new System.NotImplementedException(); }
	[Value("check")]
	public bool Check(CSSOMString font, CSSOMString text = default) { throw new System.NotImplementedException(); }
	[Value("ready")]
	public Task<FontFaceSet> Ready { get; }
	[Value("status")]
	public FontFaceSetLoadStatus Status { get; }
}

[Value("CSSFontFaceDescriptors")]
public partial class CSSFontFaceDescriptors : CSSStyleDeclaration
{
	[Value("src")]
	public CSSOMString Src { get; set; }
	[Value("fontFamily")]
	public CSSOMString FontFamily { get; set; }
	[Value("font-family")]
	public CSSOMString Font_family { get; set; }
	[Value("fontStyle")]
	public CSSOMString FontStyle { get; set; }
	[Value("font-style")]
	public CSSOMString Font_style { get; set; }
	[Value("fontWeight")]
	public CSSOMString FontWeight { get; set; }
	[Value("font-weight")]
	public CSSOMString Font_weight { get; set; }
	[Value("fontStretch")]
	public CSSOMString FontStretch { get; set; }
	[Value("font-stretch")]
	public CSSOMString Font_stretch { get; set; }
	[Value("fontWidth")]
	public CSSOMString FontWidth { get; set; }
	[Value("font-width")]
	public CSSOMString Font_width { get; set; }
	[Value("fontSize")]
	public CSSOMString FontSize { get; set; }
	[Value("font-size")]
	public CSSOMString Font_size { get; set; }
	[Value("sizeAdjust")]
	public CSSOMString SizeAdjust { get; set; }
	[Value("size-adjust")]
	public CSSOMString Size_adjust { get; set; }
	[Value("unicodeRange")]
	public CSSOMString UnicodeRange { get; set; }
	[Value("unicode-range")]
	public CSSOMString Unicode_range { get; set; }
	[Value("fontFeatureSettings")]
	public CSSOMString FontFeatureSettings { get; set; }
	[Value("font-feature-settings")]
	public CSSOMString Font_feature_settings { get; set; }
	[Value("fontVariationSettings")]
	public CSSOMString FontVariationSettings { get; set; }
	[Value("font-variation-settings")]
	public CSSOMString Font_variation_settings { get; set; }
	[Value("fontNamedInstance")]
	public CSSOMString FontNamedInstance { get; set; }
	[Value("font-named-instance")]
	public CSSOMString Font_named_instance { get; set; }
	[Value("fontDisplay")]
	public CSSOMString FontDisplay { get; set; }
	[Value("font-display")]
	public CSSOMString Font_display { get; set; }
	[Value("fontLanguageOverride")]
	public CSSOMString FontLanguageOverride { get; set; }
	[Value("font-language-override")]
	public CSSOMString Font_language_override { get; set; }
	[Value("ascentOverride")]
	public CSSOMString AscentOverride { get; set; }
	[Value("ascent-override")]
	public CSSOMString Ascent_override { get; set; }
	[Value("descentOverride")]
	public CSSOMString DescentOverride { get; set; }
	[Value("descent-override")]
	public CSSOMString Descent_override { get; set; }
	[Value("lineGapOverride")]
	public CSSOMString LineGapOverride { get; set; }
	[Value("line-gap-override")]
	public CSSOMString Line_gap_override { get; set; }
	[Value("superscriptPositionOverride")]
	public CSSOMString SuperscriptPositionOverride { get; set; }
	[Value("superscript-position-override")]
	public CSSOMString Superscript_position_override { get; set; }
	[Value("subscriptPositionOverride")]
	public CSSOMString SubscriptPositionOverride { get; set; }
	[Value("subscript-position-override")]
	public CSSOMString Subscript_position_override { get; set; }
	[Value("superscriptSizeOverride")]
	public CSSOMString SuperscriptSizeOverride { get; set; }
	[Value("superscript-size-override")]
	public CSSOMString Superscript_size_override { get; set; }
	[Value("subscriptSizeOverride")]
	public CSSOMString SubscriptSizeOverride { get; set; }
	[Value("subscript-size-override")]
	public CSSOMString Subscript_size_override { get; set; }
}

[Value("CSSFontFaceRule")]
public partial class CSSFontFaceRule : CSSRule
{
	[Value("style")]
	public CSSFontFaceDescriptors Style { get; }
}

public partial class CSSRule
{
	[Value("FONT_FEATURE_VALUES_RULE")]
	public const ushort FONT_FEATURE_VALUES_RULE = 14;
}

[Value("CSSFontFeatureValuesRule")]
public partial class CSSFontFeatureValuesRule : CSSRule
{
	[Value("fontFamily")]
	public CSSOMString FontFamily { get; set; }
	[Value("annotation")]
	public CSSFontFeatureValuesMap Annotation { get; }
	[Value("ornaments")]
	public CSSFontFeatureValuesMap Ornaments { get; }
	[Value("stylistic")]
	public CSSFontFeatureValuesMap Stylistic { get; }
	[Value("swash")]
	public CSSFontFeatureValuesMap Swash { get; }
	[Value("characterVariant")]
	public CSSFontFeatureValuesMap CharacterVariant { get; }
	[Value("styleset")]
	public CSSFontFeatureValuesMap Styleset { get; }
	[Value("historicalForms")]
	public CSSFontFeatureValuesMap HistoricalForms { get; }
}

[Value("CSSFontFeatureValuesMap")]
public partial class CSSFontFeatureValuesMap
{
	
	[Value("set")]
	public Undefined Set(CSSOMString featureValueName, Union4 values) { throw new System.NotImplementedException(); }
}

[Value("CSSFontPaletteValuesRule")]
public partial class CSSFontPaletteValuesRule : CSSRule
{
	[Value("name")]
	public CSSOMString Name { get; }
	[Value("fontFamily")]
	public CSSOMString FontFamily { get; }
	[Value("basePalette")]
	public CSSOMString BasePalette { get; }
	[Value("overrideColors")]
	public CSSOMString OverrideColors { get; }
}

[Value("Highlight")]
public partial class Highlight
{
		public Highlight(params AbstractRange[] initialRanges) { }
	
	[Value("priority")]
	public long Priority { get; set; }
	[Value("type")]
	public HighlightType Type { get; set; }
	public Highlight() { }
}

public partial class CSS
{
	[Value("highlights")]
	public HighlightRegistry Highlights { get; }
}

[Value("HighlightRegistry")]
public partial class HighlightRegistry
{
	
}

public partial class CSS
{
	[Value("elementSources")]
	public dynamic ElementSources { get; }
}

public partial class CSS
{
	[Value("layoutWorklet")]
	public Worklet LayoutWorklet { get; }
}

[Value("LayoutWorkletGlobalScope")]
public partial class LayoutWorkletGlobalScope : WorkletGlobalScope
{
	[Value("registerLayout")]
	public Undefined RegisterLayout(DOMString name, VoidFunction layoutCtor) { throw new System.NotImplementedException(); }
}

[Value("LayoutOptions")]
public partial class LayoutOptions
{
	[Value("childDisplay")]
	public ChildDisplayType ChildDisplay;
	[Value("sizing")]
	public LayoutSizingMode Sizing;
}

[Value("LayoutChild")]
public partial class LayoutChild
{
	[Value("styleMap")]
	public StylePropertyMapReadOnly StyleMap { get; }
	[Value("intrinsicSizes")]
	public Task<IntrinsicSizes> IntrinsicSizes() { throw new System.NotImplementedException(); }
	[Value("layoutNextFragment")]
	public Task<LayoutFragment> LayoutNextFragment(LayoutConstraintsOptions constraints, ChildBreakToken breakToken) { throw new System.NotImplementedException(); }
}

[Value("LayoutFragment")]
public partial class LayoutFragment
{
	[Value("inlineSize")]
	public Number InlineSize { get; }
	[Value("blockSize")]
	public Number BlockSize { get; }
	[Value("inlineOffset")]
	public Number InlineOffset { get; set; }
	[Value("blockOffset")]
	public Number BlockOffset { get; set; }
	[Value("data")]
	public dynamic Data { get; }
	[Value("breakToken")]
	public ChildBreakToken? BreakToken { get; }
}

[Value("IntrinsicSizes")]
public partial class IntrinsicSizes
{
	[Value("minContentSize")]
	public Number MinContentSize { get; }
	[Value("maxContentSize")]
	public Number MaxContentSize { get; }
}

[Value("LayoutConstraints")]
public partial class LayoutConstraints
{
	[Value("availableInlineSize")]
	public Number AvailableInlineSize { get; }
	[Value("availableBlockSize")]
	public Number AvailableBlockSize { get; }
	[Value("fixedInlineSize")]
	public Number? FixedInlineSize { get; }
	[Value("fixedBlockSize")]
	public Number? FixedBlockSize { get; }
	[Value("percentageInlineSize")]
	public Number PercentageInlineSize { get; }
	[Value("percentageBlockSize")]
	public Number PercentageBlockSize { get; }
	[Value("blockFragmentationOffset")]
	public Number? BlockFragmentationOffset { get; }
	[Value("blockFragmentationType")]
	public BlockFragmentationType BlockFragmentationType { get; }
	[Value("data")]
	public dynamic Data { get; }
}

[Value("LayoutConstraintsOptions")]
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

[Value("ChildBreakToken")]
public partial class ChildBreakToken
{
	[Value("breakType")]
	public BreakType BreakType { get; }
	[Value("child")]
	public LayoutChild Child { get; }
}

[Value("BreakToken")]
public partial class BreakToken
{
	[Value("childBreakTokens")]
	public ChildBreakToken[] ChildBreakTokens { get; }
	[Value("data")]
	public dynamic Data { get; }
}

[Value("BreakTokenOptions")]
public partial class BreakTokenOptions
{
	[Value("childBreakTokens")]
	public List<ChildBreakToken> ChildBreakTokens;
	[Value("data")]
	public dynamic Data;
}

[Value("LayoutEdges")]
public partial class LayoutEdges
{
	[Value("inlineStart")]
	public Number InlineStart { get; }
	[Value("inlineEnd")]
	public Number InlineEnd { get; }
	[Value("blockStart")]
	public Number BlockStart { get; }
	[Value("blockEnd")]
	public Number BlockEnd { get; }
	[Value("inline")]
	public Number Inline { get; }
	[Value("block")]
	public Number Block { get; }
}

[Value("FragmentResultOptions")]
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

[Value("FragmentResult")]
public partial class FragmentResult
{
		public FragmentResult(FragmentResultOptions options = default) { }
	[Value("inlineSize")]
	public Number InlineSize { get; }
	[Value("blockSize")]
	public Number BlockSize { get; }
	public FragmentResult() { }
}

[Value("IntrinsicSizesResultOptions")]
public partial class IntrinsicSizesResultOptions
{
	[Value("maxContentSize")]
	public Number MaxContentSize;
	[Value("minContentSize")]
	public Number MinContentSize;
}

[Value("SVGClipPathElement")]
public partial class SVGClipPathElement : SVGElement
{
	[Value("clipPathUnits")]
	public SVGAnimatedEnumeration ClipPathUnits { get; }
	[Value("transform")]
	public SVGAnimatedTransformList Transform { get; }
}

[Value("SVGMaskElement")]
public partial class SVGMaskElement : SVGElement
{
	[Value("maskUnits")]
	public SVGAnimatedEnumeration MaskUnits { get; }
	[Value("maskContentUnits")]
	public SVGAnimatedEnumeration MaskContentUnits { get; }
	[Value("x")]
	public SVGAnimatedLength X { get; }
	[Value("y")]
	public SVGAnimatedLength Y { get; }
	[Value("width")]
	public SVGAnimatedLength Width { get; }
	[Value("height")]
	public SVGAnimatedLength Height { get; }
}

[Value("CSSFunctionRule")]
public partial class CSSFunctionRule : CSSGroupingRule
{
}

[Value("CSSFunctionDescriptors")]
public partial class CSSFunctionDescriptors : CSSStyleDeclaration
{
	[Value("result")]
	public CSSOMString Result { get; set; }
}

[Value("CSSFunctionDeclarations")]
public partial class CSSFunctionDeclarations : CSSRule
{
	[Value("style")]
	public CSSFunctionDescriptors Style { get; }
}

public partial class Window
{
	[Value("navigate")]
	public Undefined Navigate(SpatialNavigationDirection dir) { throw new System.NotImplementedException(); }
}

[Value("FocusableAreasOption")]
public partial class FocusableAreasOption
{
	[Value("mode")]
	public FocusableAreaSearchMode Mode;
}

[Value("SpatialNavigationSearchOptions")]
public partial class SpatialNavigationSearchOptions
{
	[Value("candidates")]
	public List<Node>? Candidates;
	[Value("container")]
	public Node? Container;
}

[Value("Element")]
public partial class Element
{
	[Value("getSpatialNavigationContainer")]
	public Node GetSpatialNavigationContainer() { throw new System.NotImplementedException(); }
	[Value("focusableAreas")]
	public List<Node> FocusableAreas(FocusableAreasOption option = default) { throw new System.NotImplementedException(); }
	[Value("spatialNavigationSearch")]
	public Node? SpatialNavigationSearch(SpatialNavigationDirection dir, SpatialNavigationSearchOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("NavigationEvent")]
public partial class NavigationEvent : UIEvent
{
		public NavigationEvent(DOMString type, NavigationEventInit eventInitDict = default) { }
	[Value("dir")]
	public SpatialNavigationDirection Dir { get; }
	[Value("relatedTarget")]
	public EventTarget? RelatedTarget { get; }
	public NavigationEvent() { }
}

[Value("NavigationEventInit")]
public partial class NavigationEventInit : UIEventInit
{
	[Value("dir")]
	public SpatialNavigationDirection Dir;
	[Value("relatedTarget")]
	public EventTarget? RelatedTarget;
}

[Value("CSSNestedDeclarations")]
public partial class CSSNestedDeclarations : CSSRule
{
	[Value("style")]
	public CSSStyleProperties Style { get; }
}

public partial class CSS
{
	[Value("paintWorklet")]
	public Worklet PaintWorklet { get; }
}

[Value("PaintWorkletGlobalScope")]
public partial class PaintWorkletGlobalScope : WorkletGlobalScope
{
	[Value("registerPaint")]
	public Undefined RegisterPaint(DOMString name, VoidFunction paintCtor) { throw new System.NotImplementedException(); }
	[Value("devicePixelRatio")]
	public double DevicePixelRatio { get; }
}

[Value("PaintRenderingContext2DSettings")]
public partial class PaintRenderingContext2DSettings
{
	[Value("alpha")]
	public bool Alpha;
}

[Value("PaintRenderingContext2D")]
public partial class PaintRenderingContext2D
{
}












[Value("PaintSize")]
public partial class PaintSize
{
	[Value("width")]
	public Number Width { get; }
	[Value("height")]
	public Number Height { get; }
}



public partial class CSS
{
	[Value("parseStylesheet")]
	public Task<List<CSSParserRule>> ParseStylesheet(CSSStringSource css, CSSParserOptions options = default) { throw new System.NotImplementedException(); }
	[Value("parseRuleList")]
	public Task<List<CSSParserRule>> ParseRuleList(CSSStringSource css, CSSParserOptions options = default) { throw new System.NotImplementedException(); }
	[Value("parseRule")]
	public Task<CSSParserRule> ParseRule(CSSStringSource css, CSSParserOptions options = default) { throw new System.NotImplementedException(); }
	[Value("parseDeclarationList")]
	public Task<List<CSSParserRule>> ParseDeclarationList(CSSStringSource css, CSSParserOptions options = default) { throw new System.NotImplementedException(); }
	[Value("parseDeclaration")]
	public CSSParserDeclaration ParseDeclaration(DOMString css, CSSParserOptions options = default) { throw new System.NotImplementedException(); }
	[Value("parseValue")]
	public CSSToken ParseValue(DOMString css) { throw new System.NotImplementedException(); }
	[Value("parseValueList")]
	public List<CSSToken> ParseValueList(DOMString css) { throw new System.NotImplementedException(); }
	[Value("parseCommaValueList")]
	public List<List<CSSToken>> ParseCommaValueList(DOMString css) { throw new System.NotImplementedException(); }
}

[Value("CSSParserOptions")]
public partial class CSSParserOptions
{
	[Value("atRules")]
	public Object AtRules;
}

[Value("CSSParserRule")]
public partial class CSSParserRule
{
}

[Value("CSSParserAtRule")]
public partial class CSSParserAtRule : CSSParserRule
{
		public CSSParserAtRule(DOMString name, List<CSSToken> prelude, List<CSSParserRule>? body = default) { }
	[Value("name")]
	public DOMString Name { get; }
	[Value("prelude")]
	public CSSParserValue[] Prelude { get; }
	[Value("body")]
	public CSSParserRule[]? Body { get; }
	
	public CSSParserAtRule() { }
}

[Value("CSSParserQualifiedRule")]
public partial class CSSParserQualifiedRule : CSSParserRule
{
		public CSSParserQualifiedRule(List<CSSToken> prelude, List<CSSParserRule>? body = default) { }
	[Value("prelude")]
	public CSSParserValue[] Prelude { get; }
	[Value("body")]
	public CSSParserRule[] Body { get; }
	
	public CSSParserQualifiedRule() { }
}

[Value("CSSParserDeclaration")]
public partial class CSSParserDeclaration : CSSParserRule
{
		public CSSParserDeclaration(DOMString name, List<CSSParserRule> body = default) { }
	[Value("name")]
	public DOMString Name { get; }
	[Value("body")]
	public CSSParserValue[] Body { get; }
	
	public CSSParserDeclaration() { }
}

[Value("CSSParserValue")]
public partial class CSSParserValue
{
}

[Value("CSSParserBlock")]
public partial class CSSParserBlock : CSSParserValue
{
		public CSSParserBlock(DOMString name, List<CSSParserValue> body) { }
	[Value("name")]
	public DOMString Name { get; }
	[Value("body")]
	public CSSParserValue[] Body { get; }
	
	public CSSParserBlock() { }
}

[Value("CSSParserFunction")]
public partial class CSSParserFunction : CSSParserValue
{
		public CSSParserFunction(DOMString name, List<List<CSSParserValue>> args) { }
	[Value("name")]
	public DOMString Name { get; }
	[Value("args")]
	public CSSParserValue[][] Args { get; }
	
	public CSSParserFunction() { }
}

[Value("PropertyDefinition")]
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

public partial class CSS
{
	[Value("registerProperty")]
	public Undefined RegisterProperty(PropertyDefinition definition) { throw new System.NotImplementedException(); }
}

[Value("CSSPropertyRule")]
public partial class CSSPropertyRule : CSSRule
{
	[Value("name")]
	public CSSOMString Name { get; }
	[Value("syntax")]
	public CSSOMString Syntax { get; }
	[Value("inherits")]
	public bool Inherits { get; }
	[Value("initialValue")]
	public CSSOMString? InitialValue { get; }
}

[Value("CSSPseudoElement")]
public partial class CSSPseudoElement : EventTarget, GeometryUtils
{
	[Value("type")]
	public CSSOMString Type { get; }
	[Value("element")]
	public Element Element { get; }
	[Value("parent")]
	public Union7 Parent { get; }
	[Value("pseudo")]
	public CSSPseudoElement? Pseudo(CSSOMString type) { throw new System.NotImplementedException(); }
}

public partial class Element
{
	[Value("pseudo")]
	public CSSPseudoElement? Pseudo(CSSOMString type) { throw new System.NotImplementedException(); }
}

[Value("Document")]
public partial class Document
{
	[Value("namedFlows")]
	public NamedFlowMap NamedFlows { get; }
}

[Value("NamedFlowMap")]
public partial class NamedFlowMap
{
	
}

[Value("NamedFlow")]
public partial class NamedFlow : EventTarget
{
	[Value("name")]
	public CSSOMString Name { get; }
	[Value("overset")]
	public bool Overset { get; }
	[Value("getRegions")]
	public List<Element> GetRegions() { throw new System.NotImplementedException(); }
	[Value("firstEmptyRegionIndex")]
	public Number FirstEmptyRegionIndex { get; }
	[Value("getContent")]
	public List<Node> GetContent() { throw new System.NotImplementedException(); }
	[Value("getRegionsByContent")]
	public List<Element> GetRegionsByContent(Node node) { throw new System.NotImplementedException(); }
}

[Value("SnapEventInit")]
public partial class SnapEventInit : EventInit
{
	[Value("snapTargetBlock")]
	public Node? SnapTargetBlock;
	[Value("snapTargetInline")]
	public Node? SnapTargetInline;
}

[Value("SnapEvent")]
public partial class SnapEvent : Event
{
		public SnapEvent(DOMString type, SnapEventInit eventInitDict = default) { }
	[Value("snapTargetBlock")]
	public Node? SnapTargetBlock { get; }
	[Value("snapTargetInline")]
	public Node? SnapTargetInline { get; }
	public SnapEvent() { }
}

public partial class Element
{
	[Value("part")]
	public DOMTokenList Part { get; }
}

[Value("CSSStartingStyleRule")]
public partial class CSSStartingStyleRule : CSSGroupingRule
{
}

[Value("CSSTransition")]
public partial class CSSTransition : Animation
{
	[Value("transitionProperty")]
	public CSSOMString TransitionProperty { get; }
}

[Value("TransitionEvent")]
public partial class TransitionEvent : Event
{
		public TransitionEvent(CSSOMString type, TransitionEventInit transitionEventInitDict = default) { }
	[Value("propertyName")]
	public CSSOMString PropertyName { get; }
	[Value("elapsedTime")]
	public Number ElapsedTime { get; }
	[Value("pseudoElement")]
	public CSSOMString PseudoElement { get; }
	public TransitionEvent() { }
}

[Value("TransitionEventInit")]
public partial class TransitionEventInit : EventInit
{
	[Value("propertyName")]
	public CSSOMString PropertyName;
	[Value("elapsedTime")]
	public Number ElapsedTime;
	[Value("pseudoElement")]
	public CSSOMString PseudoElement;
}

[Value("CSSStyleValue")]
public partial class CSSStyleValue
{
	
	[Value("parse")]
	public static CSSStyleValue Parse(USVString property, USVString cssText) { throw new System.NotImplementedException(); }
	[Value("parseAll")]
	public static List<CSSStyleValue> ParseAll(USVString property, USVString cssText) { throw new System.NotImplementedException(); }
}

[Value("StylePropertyMapReadOnly")]
public partial class StylePropertyMapReadOnly
{
	public USVString this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	[Value("get")]
	public Union8 Get(USVString property) { throw new System.NotImplementedException(); }
	[Value("getAll")]
	public List<CSSStyleValue> GetAll(USVString property) { throw new System.NotImplementedException(); }
	[Value("has")]
	public bool Has(USVString property) { throw new System.NotImplementedException(); }
	[Value("size")]
	public ulong Size { get; }
}

[Value("StylePropertyMap")]
public partial class StylePropertyMap : StylePropertyMapReadOnly
{
	[Value("set")]
	public Undefined Set(USVString property, params Union9[] values) { throw new System.NotImplementedException(); }
	[Value("append")]
	public Undefined Append(USVString property, params Union10[] values) { throw new System.NotImplementedException(); }
	[Value("delete")]
	public Undefined Delete(USVString property) { throw new System.NotImplementedException(); }
	[Value("clear")]
	public Undefined Clear() { throw new System.NotImplementedException(); }
}

public partial class Element
{
	[Value("computedStyleMap")]
	public StylePropertyMapReadOnly ComputedStyleMap() { throw new System.NotImplementedException(); }
}

[Value("CSSStyleRule")]
public partial class CSSStyleRule
{
	[Value("styleMap")]
	public StylePropertyMap StyleMap { get; }
}

[Value("CSSUnparsedValue")]
public partial class CSSUnparsedValue : CSSStyleValue
{
		public CSSUnparsedValue(List<CSSUnparsedSegment> members) { }
	public CSSUnparsedSegment this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	[Value("length")]
	public ulong Length { get; }
	
	
	public CSSUnparsedValue() { }
}


[Value("CSSVariableReferenceValue")]
public partial class CSSVariableReferenceValue
{
		public CSSVariableReferenceValue(USVString variable, CSSUnparsedValue? fallback = default) { }
	[Value("variable")]
	public USVString Variable { get; set; }
	[Value("fallback")]
	public CSSUnparsedValue? Fallback { get; }
	public CSSVariableReferenceValue() { }
}

[Value("CSSKeywordValue")]
public partial class CSSKeywordValue : CSSStyleValue
{
		public CSSKeywordValue(USVString value) { }
	[Value("value")]
	public USVString Value { get; set; }
	public CSSKeywordValue() { }
}



[Value("CSSNumericType")]
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

[Value("CSSNumericValue")]
public partial class CSSNumericValue : CSSStyleValue
{
	[Value("add")]
	public CSSNumericValue Add(params CSSNumberish[] values) { throw new System.NotImplementedException(); }
	[Value("sub")]
	public CSSNumericValue Sub(params CSSNumberish[] values) { throw new System.NotImplementedException(); }
	[Value("mul")]
	public CSSNumericValue Mul(params CSSNumberish[] values) { throw new System.NotImplementedException(); }
	[Value("div")]
	public CSSNumericValue Div(params CSSNumberish[] values) { throw new System.NotImplementedException(); }
	[Value("min")]
	public CSSNumericValue Min(params CSSNumberish[] values) { throw new System.NotImplementedException(); }
	[Value("max")]
	public CSSNumericValue Max(params CSSNumberish[] values) { throw new System.NotImplementedException(); }
	[Value("equals")]
	public bool Equals(params CSSNumberish[] value) { throw new System.NotImplementedException(); }
	[Value("to")]
	public CSSUnitValue To(USVString unit) { throw new System.NotImplementedException(); }
	[Value("toSum")]
	public CSSMathSum ToSum(params USVString[] units) { throw new System.NotImplementedException(); }
	[Value("type")]
	public CSSNumericType Type() { throw new System.NotImplementedException(); }
	[Value("parse")]
	public static CSSNumericValue Parse(USVString cssText) { throw new System.NotImplementedException(); }
}

[Value("CSSUnitValue")]
public partial class CSSUnitValue : CSSNumericValue
{
		public CSSUnitValue(Number value, USVString unit) { }
	[Value("value")]
	public Number Value { get; set; }
	[Value("unit")]
	public USVString Unit { get; }
	public CSSUnitValue() { }
}

[Value("CSSMathValue")]
public partial class CSSMathValue : CSSNumericValue
{
	[Value("operator")]
	public CSSMathOperator Operator { get; }
}

[Value("CSSMathSum")]
public partial class CSSMathSum : CSSMathValue
{
		public CSSMathSum(params CSSNumberish[] args) { }
	[Value("values")]
	public CSSNumericArray Values { get; }
	public CSSMathSum() { }
}

[Value("CSSMathProduct")]
public partial class CSSMathProduct : CSSMathValue
{
		public CSSMathProduct(params CSSNumberish[] args) { }
	[Value("values")]
	public CSSNumericArray Values { get; }
	public CSSMathProduct() { }
}

[Value("CSSMathNegate")]
public partial class CSSMathNegate : CSSMathValue
{
		public CSSMathNegate(CSSNumberish arg) { }
	[Value("value")]
	public CSSNumericValue Value { get; }
	public CSSMathNegate() { }
}

[Value("CSSMathInvert")]
public partial class CSSMathInvert : CSSMathValue
{
		public CSSMathInvert(CSSNumberish arg) { }
	[Value("value")]
	public CSSNumericValue Value { get; }
	public CSSMathInvert() { }
}

[Value("CSSMathMin")]
public partial class CSSMathMin : CSSMathValue
{
		public CSSMathMin(params CSSNumberish[] args) { }
	[Value("values")]
	public CSSNumericArray Values { get; }
	public CSSMathMin() { }
}

[Value("CSSMathMax")]
public partial class CSSMathMax : CSSMathValue
{
		public CSSMathMax(params CSSNumberish[] args) { }
	[Value("values")]
	public CSSNumericArray Values { get; }
	public CSSMathMax() { }
}

[Value("CSSMathClamp")]
public partial class CSSMathClamp : CSSMathValue
{
		public CSSMathClamp(CSSNumberish lower, CSSNumberish value, CSSNumberish upper) { }
	[Value("lower")]
	public CSSNumericValue Lower { get; }
	[Value("value")]
	public CSSNumericValue Value { get; }
	[Value("upper")]
	public CSSNumericValue Upper { get; }
	public CSSMathClamp() { }
}

[Value("CSSNumericArray")]
public partial class CSSNumericArray
{
	public CSSNumericValue this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	[Value("length")]
	public ulong Length { get; }
	
}

public partial class CSS
{
	[Value("number")]
	public CSSUnitValue Number(Number value) { throw new System.NotImplementedException(); }
	[Value("percent")]
	public CSSUnitValue Percent(Number value) { throw new System.NotImplementedException(); }
	[Value("cap")]
	public CSSUnitValue Cap(Number value) { throw new System.NotImplementedException(); }
	[Value("ch")]
	public CSSUnitValue Ch(Number value) { throw new System.NotImplementedException(); }
	[Value("em")]
	public CSSUnitValue Em(Number value) { throw new System.NotImplementedException(); }
	[Value("ex")]
	public CSSUnitValue Ex(Number value) { throw new System.NotImplementedException(); }
	[Value("ic")]
	public CSSUnitValue Ic(Number value) { throw new System.NotImplementedException(); }
	[Value("lh")]
	public CSSUnitValue Lh(Number value) { throw new System.NotImplementedException(); }
	[Value("rcap")]
	public CSSUnitValue Rcap(Number value) { throw new System.NotImplementedException(); }
	[Value("rch")]
	public CSSUnitValue Rch(Number value) { throw new System.NotImplementedException(); }
	[Value("rem")]
	public CSSUnitValue Rem(Number value) { throw new System.NotImplementedException(); }
	[Value("rex")]
	public CSSUnitValue Rex(Number value) { throw new System.NotImplementedException(); }
	[Value("ric")]
	public CSSUnitValue Ric(Number value) { throw new System.NotImplementedException(); }
	[Value("rlh")]
	public CSSUnitValue Rlh(Number value) { throw new System.NotImplementedException(); }
	[Value("vw")]
	public CSSUnitValue Vw(Number value) { throw new System.NotImplementedException(); }
	[Value("vh")]
	public CSSUnitValue Vh(Number value) { throw new System.NotImplementedException(); }
	[Value("vi")]
	public CSSUnitValue Vi(Number value) { throw new System.NotImplementedException(); }
	[Value("vb")]
	public CSSUnitValue Vb(Number value) { throw new System.NotImplementedException(); }
	[Value("vmin")]
	public CSSUnitValue Vmin(Number value) { throw new System.NotImplementedException(); }
	[Value("vmax")]
	public CSSUnitValue Vmax(Number value) { throw new System.NotImplementedException(); }
	[Value("svw")]
	public CSSUnitValue Svw(Number value) { throw new System.NotImplementedException(); }
	[Value("svh")]
	public CSSUnitValue Svh(Number value) { throw new System.NotImplementedException(); }
	[Value("svi")]
	public CSSUnitValue Svi(Number value) { throw new System.NotImplementedException(); }
	[Value("svb")]
	public CSSUnitValue Svb(Number value) { throw new System.NotImplementedException(); }
	[Value("svmin")]
	public CSSUnitValue Svmin(Number value) { throw new System.NotImplementedException(); }
	[Value("svmax")]
	public CSSUnitValue Svmax(Number value) { throw new System.NotImplementedException(); }
	[Value("lvw")]
	public CSSUnitValue Lvw(Number value) { throw new System.NotImplementedException(); }
	[Value("lvh")]
	public CSSUnitValue Lvh(Number value) { throw new System.NotImplementedException(); }
	[Value("lvi")]
	public CSSUnitValue Lvi(Number value) { throw new System.NotImplementedException(); }
	[Value("lvb")]
	public CSSUnitValue Lvb(Number value) { throw new System.NotImplementedException(); }
	[Value("lvmin")]
	public CSSUnitValue Lvmin(Number value) { throw new System.NotImplementedException(); }
	[Value("lvmax")]
	public CSSUnitValue Lvmax(Number value) { throw new System.NotImplementedException(); }
	[Value("dvw")]
	public CSSUnitValue Dvw(Number value) { throw new System.NotImplementedException(); }
	[Value("dvh")]
	public CSSUnitValue Dvh(Number value) { throw new System.NotImplementedException(); }
	[Value("dvi")]
	public CSSUnitValue Dvi(Number value) { throw new System.NotImplementedException(); }
	[Value("dvb")]
	public CSSUnitValue Dvb(Number value) { throw new System.NotImplementedException(); }
	[Value("dvmin")]
	public CSSUnitValue Dvmin(Number value) { throw new System.NotImplementedException(); }
	[Value("dvmax")]
	public CSSUnitValue Dvmax(Number value) { throw new System.NotImplementedException(); }
	[Value("cqw")]
	public CSSUnitValue Cqw(Number value) { throw new System.NotImplementedException(); }
	[Value("cqh")]
	public CSSUnitValue Cqh(Number value) { throw new System.NotImplementedException(); }
	[Value("cqi")]
	public CSSUnitValue Cqi(Number value) { throw new System.NotImplementedException(); }
	[Value("cqb")]
	public CSSUnitValue Cqb(Number value) { throw new System.NotImplementedException(); }
	[Value("cqmin")]
	public CSSUnitValue Cqmin(Number value) { throw new System.NotImplementedException(); }
	[Value("cqmax")]
	public CSSUnitValue Cqmax(Number value) { throw new System.NotImplementedException(); }
	[Value("cm")]
	public CSSUnitValue Cm(Number value) { throw new System.NotImplementedException(); }
	[Value("mm")]
	public CSSUnitValue Mm(Number value) { throw new System.NotImplementedException(); }
	[Value("Q")]
	public CSSUnitValue Q(Number value) { throw new System.NotImplementedException(); }
	[Value("in")]
	public CSSUnitValue In(Number value) { throw new System.NotImplementedException(); }
	[Value("pt")]
	public CSSUnitValue Pt(Number value) { throw new System.NotImplementedException(); }
	[Value("pc")]
	public CSSUnitValue Pc(Number value) { throw new System.NotImplementedException(); }
	[Value("px")]
	public CSSUnitValue Px(Number value) { throw new System.NotImplementedException(); }
	[Value("deg")]
	public CSSUnitValue Deg(Number value) { throw new System.NotImplementedException(); }
	[Value("grad")]
	public CSSUnitValue Grad(Number value) { throw new System.NotImplementedException(); }
	[Value("rad")]
	public CSSUnitValue Rad(Number value) { throw new System.NotImplementedException(); }
	[Value("turn")]
	public CSSUnitValue Turn(Number value) { throw new System.NotImplementedException(); }
	[Value("s")]
	public CSSUnitValue S(Number value) { throw new System.NotImplementedException(); }
	[Value("ms")]
	public CSSUnitValue Ms(Number value) { throw new System.NotImplementedException(); }
	[Value("Hz")]
	public CSSUnitValue Hz(Number value) { throw new System.NotImplementedException(); }
	[Value("kHz")]
	public CSSUnitValue KHz(Number value) { throw new System.NotImplementedException(); }
	[Value("dpi")]
	public CSSUnitValue Dpi(Number value) { throw new System.NotImplementedException(); }
	[Value("dpcm")]
	public CSSUnitValue Dpcm(Number value) { throw new System.NotImplementedException(); }
	[Value("dppx")]
	public CSSUnitValue Dppx(Number value) { throw new System.NotImplementedException(); }
	[Value("fr")]
	public CSSUnitValue Fr(Number value) { throw new System.NotImplementedException(); }
}

[Value("CSSTransformValue")]
public partial class CSSTransformValue : CSSStyleValue
{
		public CSSTransformValue(List<CSSTransformComponent> transforms) { }
	public CSSTransformComponent this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	[Value("length")]
	public ulong Length { get; }
	
	
	[Value("is2D")]
	public bool Is2D { get; }
	[Value("toMatrix")]
	public DOMMatrix ToMatrix() { throw new System.NotImplementedException(); }
	public CSSTransformValue() { }
}


[Value("CSSTransformComponent")]
public partial class CSSTransformComponent
{
	
	[Value("is2D")]
	public bool Is2D { get; set; }
	[Value("toMatrix")]
	public DOMMatrix ToMatrix() { throw new System.NotImplementedException(); }
}

[Value("CSSTranslate")]
public partial class CSSTranslate : CSSTransformComponent
{
		public CSSTranslate(CSSNumericValue x, CSSNumericValue y, CSSNumericValue z = default) { }
	[Value("x")]
	public CSSNumericValue X { get; set; }
	[Value("y")]
	public CSSNumericValue Y { get; set; }
	[Value("z")]
	public CSSNumericValue Z { get; set; }
	public CSSTranslate() { }
}

[Value("CSSRotate")]
public partial class CSSRotate : CSSTransformComponent
{
		public CSSRotate(CSSNumericValue angle) { }
		public CSSRotate(CSSNumberish x, CSSNumberish y, CSSNumberish z, CSSNumericValue angle) { }
	[Value("x")]
	public CSSNumberish X { get; set; }
	[Value("y")]
	public CSSNumberish Y { get; set; }
	[Value("z")]
	public CSSNumberish Z { get; set; }
	[Value("angle")]
	public CSSNumericValue Angle { get; set; }
	public CSSRotate() { }
}

[Value("CSSScale")]
public partial class CSSScale : CSSTransformComponent
{
		public CSSScale(CSSNumberish x, CSSNumberish y, CSSNumberish z = default) { }
	[Value("x")]
	public CSSNumberish X { get; set; }
	[Value("y")]
	public CSSNumberish Y { get; set; }
	[Value("z")]
	public CSSNumberish Z { get; set; }
	public CSSScale() { }
}

[Value("CSSSkew")]
public partial class CSSSkew : CSSTransformComponent
{
		public CSSSkew(CSSNumericValue ax, CSSNumericValue ay) { }
	[Value("ax")]
	public CSSNumericValue Ax { get; set; }
	[Value("ay")]
	public CSSNumericValue Ay { get; set; }
	public CSSSkew() { }
}

[Value("CSSSkewX")]
public partial class CSSSkewX : CSSTransformComponent
{
		public CSSSkewX(CSSNumericValue ax) { }
	[Value("ax")]
	public CSSNumericValue Ax { get; set; }
	public CSSSkewX() { }
}

[Value("CSSSkewY")]
public partial class CSSSkewY : CSSTransformComponent
{
		public CSSSkewY(CSSNumericValue ay) { }
	[Value("ay")]
	public CSSNumericValue Ay { get; set; }
	public CSSSkewY() { }
}

[Value("CSSPerspective")]
public partial class CSSPerspective : CSSTransformComponent
{
		public CSSPerspective(CSSPerspectiveValue length) { }
	[Value("length")]
	public CSSPerspectiveValue Length { get; set; }
	public CSSPerspective() { }
}

[Value("CSSMatrixComponent")]
public partial class CSSMatrixComponent : CSSTransformComponent
{
		public CSSMatrixComponent(DOMMatrixReadOnly matrix, CSSMatrixComponentOptions options = default) { }
	[Value("matrix")]
	public DOMMatrix Matrix { get; set; }
	public CSSMatrixComponent() { }
}

[Value("CSSMatrixComponentOptions")]
public partial class CSSMatrixComponentOptions
{
	[Value("is2D")]
	public bool Is2D;
}

[Value("CSSImageValue")]
public partial class CSSImageValue : CSSStyleValue
{
}

[Value("CSSColorValue")]
public partial class CSSColorValue : CSSStyleValue
{
	[Value("parse")]
	public static Union15 Parse(USVString cssText) { throw new System.NotImplementedException(); }
}





[Value("CSSRGB")]
public partial class CSSRGB : CSSColorValue
{
		public CSSRGB(CSSColorRGBComp r, CSSColorRGBComp g, CSSColorRGBComp b, CSSColorPercent alpha = default) { }
	[Value("r")]
	public CSSColorRGBComp R { get; set; }
	[Value("g")]
	public CSSColorRGBComp G { get; set; }
	[Value("b")]
	public CSSColorRGBComp B { get; set; }
	[Value("alpha")]
	public CSSColorPercent Alpha { get; set; }
	public CSSRGB() { }
}

[Value("CSSHSL")]
public partial class CSSHSL : CSSColorValue
{
		public CSSHSL(CSSColorAngle h, CSSColorPercent s, CSSColorPercent l, CSSColorPercent alpha = default) { }
	[Value("h")]
	public CSSColorAngle H { get; set; }
	[Value("s")]
	public CSSColorPercent S { get; set; }
	[Value("l")]
	public CSSColorPercent L { get; set; }
	[Value("alpha")]
	public CSSColorPercent Alpha { get; set; }
	public CSSHSL() { }
}

[Value("CSSHWB")]
public partial class CSSHWB : CSSColorValue
{
		public CSSHWB(CSSNumericValue h, CSSNumberish w, CSSNumberish b, CSSNumberish alpha = default) { }
	[Value("h")]
	public CSSNumericValue H { get; set; }
	[Value("w")]
	public CSSNumberish W { get; set; }
	[Value("b")]
	public CSSNumberish B { get; set; }
	[Value("alpha")]
	public CSSNumberish Alpha { get; set; }
	public CSSHWB() { }
}

[Value("CSSLab")]
public partial class CSSLab : CSSColorValue
{
		public CSSLab(CSSColorPercent l, CSSColorNumber a, CSSColorNumber b, CSSColorPercent alpha = default) { }
	[Value("l")]
	public CSSColorPercent L { get; set; }
	[Value("a")]
	public CSSColorNumber A { get; set; }
	[Value("b")]
	public CSSColorNumber B { get; set; }
	[Value("alpha")]
	public CSSColorPercent Alpha { get; set; }
	public CSSLab() { }
}

[Value("CSSLCH")]
public partial class CSSLCH : CSSColorValue
{
		public CSSLCH(CSSColorPercent l, CSSColorPercent c, CSSColorAngle h, CSSColorPercent alpha = default) { }
	[Value("l")]
	public CSSColorPercent L { get; set; }
	[Value("c")]
	public CSSColorPercent C { get; set; }
	[Value("h")]
	public CSSColorAngle H { get; set; }
	[Value("alpha")]
	public CSSColorPercent Alpha { get; set; }
	public CSSLCH() { }
}

[Value("CSSOKLab")]
public partial class CSSOKLab : CSSColorValue
{
		public CSSOKLab(CSSColorPercent l, CSSColorNumber a, CSSColorNumber b, CSSColorPercent alpha = default) { }
	[Value("l")]
	public CSSColorPercent L { get; set; }
	[Value("a")]
	public CSSColorNumber A { get; set; }
	[Value("b")]
	public CSSColorNumber B { get; set; }
	[Value("alpha")]
	public CSSColorPercent Alpha { get; set; }
	public CSSOKLab() { }
}

[Value("CSSOKLCH")]
public partial class CSSOKLCH : CSSColorValue
{
		public CSSOKLCH(CSSColorPercent l, CSSColorPercent c, CSSColorAngle h, CSSColorPercent alpha = default) { }
	[Value("l")]
	public CSSColorPercent L { get; set; }
	[Value("c")]
	public CSSColorPercent C { get; set; }
	[Value("h")]
	public CSSColorAngle H { get; set; }
	[Value("alpha")]
	public CSSColorPercent Alpha { get; set; }
	public CSSOKLCH() { }
}

[Value("CSSColor")]
public partial class CSSColor : CSSColorValue
{
		public CSSColor(CSSKeywordish colorSpace, List<CSSColorPercent> channels, CSSNumberish alpha = default) { }
	[Value("colorSpace")]
	public CSSKeywordish ColorSpace { get; set; }
	[Value("channels")]
	public CSSColorPercent[] Channels { get; set; }
	[Value("alpha")]
	public CSSNumberish Alpha { get; set; }
	public CSSColor() { }
}

[Value("CSSViewTransitionRule")]
public partial class CSSViewTransitionRule : CSSRule
{
	[Value("navigation")]
	public CSSOMString Navigation { get; }
	[Value("types")]
	public CSSOMString[] Types { get; }
}

[Value("ViewTransitionTypeSet")]
public partial class ViewTransitionTypeSet
{
	
}

[Value("ViewTransition")]
public partial class ViewTransition
{
	[Value("types")]
	public ViewTransitionTypeSet Types { get; set; }
}

[Value("StartViewTransitionOptions")]
public partial class StartViewTransitionOptions
{
	[Value("update")]
	public ViewTransitionUpdateCallback? Update;
	[Value("types")]
	public List<DOMString>? Types;
}

public partial class Document
{
	[Value("startViewTransition")]
	public ViewTransition StartViewTransition(Union20 callbackOptions = default) { throw new System.NotImplementedException(); }
}

public partial class ViewTransition
{
	[Value("updateCallbackDone")]
	public Task<Undefined> UpdateCallbackDone { get; }
	[Value("ready")]
	public Task<Undefined> Ready { get; }
	[Value("finished")]
	public Task<Undefined> Finished { get; }
	[Value("skipTransition")]
	public Undefined SkipTransition() { throw new System.NotImplementedException(); }
}

public partial class Window
{
	[Value("viewport")]
	public Viewport Viewport { get; }
}

[Value("Viewport")]
public partial class Viewport
{
	[Value("segments")]
	public DOMRect[]? Segments { get; }
}

[Value("ScrollOptions")]
public partial class ScrollOptions
{
	[Value("behavior")]
	public ScrollBehavior Behavior;
}

[Value("ScrollToOptions")]
public partial class ScrollToOptions : ScrollOptions
{
	[Value("left")]
	public double Left;
	[Value("top")]
	public double Top;
}

public partial class Window
{
	[Value("matchMedia")]
	public MediaQueryList MatchMedia(CSSOMString query) { throw new System.NotImplementedException(); }
	[Value("screen")]
	public Screen Screen { get; }
	[Value("visualViewport")]
	public VisualViewport? VisualViewport { get; }
	[Value("moveTo")]
	public Undefined MoveTo(long x, long y) { throw new System.NotImplementedException(); }
	[Value("moveBy")]
	public Undefined MoveBy(long x, long y) { throw new System.NotImplementedException(); }
	[Value("resizeTo")]
	public Undefined ResizeTo(long width, long height) { throw new System.NotImplementedException(); }
	[Value("resizeBy")]
	public Undefined ResizeBy(long x, long y) { throw new System.NotImplementedException(); }
	[Value("innerWidth")]
	public long InnerWidth { get; }
	[Value("innerHeight")]
	public long InnerHeight { get; }
	[Value("scrollX")]
	public Number ScrollX { get; }
	[Value("pageXOffset")]
	public Number PageXOffset { get; }
	[Value("scrollY")]
	public Number ScrollY { get; }
	[Value("pageYOffset")]
	public Number PageYOffset { get; }
	[Value("scroll")]
	public Undefined Scroll(ScrollToOptions options = default) { throw new System.NotImplementedException(); }
	[Value("scroll")]
	public Undefined Scroll(double x, double y) { throw new System.NotImplementedException(); }
	[Value("scrollTo")]
	public Undefined ScrollTo(ScrollToOptions options = default) { throw new System.NotImplementedException(); }
	[Value("scrollTo")]
	public Undefined ScrollTo(double x, double y) { throw new System.NotImplementedException(); }
	[Value("scrollBy")]
	public Undefined ScrollBy(ScrollToOptions options = default) { throw new System.NotImplementedException(); }
	[Value("scrollBy")]
	public Undefined ScrollBy(double x, double y) { throw new System.NotImplementedException(); }
	[Value("screenX")]
	public long ScreenX { get; }
	[Value("screenLeft")]
	public long ScreenLeft { get; }
	[Value("screenY")]
	public long ScreenY { get; }
	[Value("screenTop")]
	public long ScreenTop { get; }
	[Value("outerWidth")]
	public long OuterWidth { get; }
	[Value("outerHeight")]
	public long OuterHeight { get; }
	[Value("devicePixelRatio")]
	public Number DevicePixelRatio { get; }
}

[Value("MediaQueryList")]
public partial class MediaQueryList : EventTarget
{
	[Value("media")]
	public CSSOMString Media { get; }
	[Value("matches")]
	public bool Matches { get; }
	[Value("addListener")]
	public Undefined AddListener(EventListener? callback) { throw new System.NotImplementedException(); }
	[Value("removeListener")]
	public Undefined RemoveListener(EventListener? callback) { throw new System.NotImplementedException(); }
	[Value("onchange")]
	public EventHandler Onchange { get; set; }
}

[Value("MediaQueryListEvent")]
public partial class MediaQueryListEvent : Event
{
		public MediaQueryListEvent(CSSOMString type, MediaQueryListEventInit eventInitDict = default) { }
	[Value("media")]
	public CSSOMString Media { get; }
	[Value("matches")]
	public bool Matches { get; }
	public MediaQueryListEvent() { }
}

[Value("MediaQueryListEventInit")]
public partial class MediaQueryListEventInit : EventInit
{
	[Value("media")]
	public CSSOMString Media;
	[Value("matches")]
	public bool Matches;
}

[Value("Screen")]
public partial class Screen
{
	[Value("availWidth")]
	public long AvailWidth { get; }
	[Value("availHeight")]
	public long AvailHeight { get; }
	[Value("width")]
	public long Width { get; }
	[Value("height")]
	public long Height { get; }
	[Value("colorDepth")]
	public ulong ColorDepth { get; }
	[Value("pixelDepth")]
	public ulong PixelDepth { get; }
}

public partial class Document
{
	[Value("elementFromPoint")]
	public Element? ElementFromPoint(Number x, Number y) { throw new System.NotImplementedException(); }
	[Value("elementsFromPoint")]
	public List<Element> ElementsFromPoint(Number x, Number y) { throw new System.NotImplementedException(); }
	[Value("caretPositionFromPoint")]
	public CaretPosition? CaretPositionFromPoint(Number x, Number y, CaretPositionFromPointOptions options = default) { throw new System.NotImplementedException(); }
	[Value("scrollingElement")]
	public Element? ScrollingElement { get; }
}

[Value("CaretPositionFromPointOptions")]
public partial class CaretPositionFromPointOptions
{
	[Value("shadowRoots")]
	public List<ShadowRoot> ShadowRoots;
}

[Value("CaretPosition")]
public partial class CaretPosition
{
	[Value("offsetNode")]
	public Node OffsetNode { get; }
	[Value("offset")]
	public ulong Offset { get; }
	[Value("getClientRect")]
	public DOMRect? GetClientRect() { throw new System.NotImplementedException(); }
}

[Value("ScrollIntoViewOptions")]
public partial class ScrollIntoViewOptions : ScrollOptions
{
	[Value("block")]
	public ScrollLogicalPosition Block;
	[Value("inline")]
	public ScrollLogicalPosition Inline;
}

[Value("CheckVisibilityOptions")]
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

public partial class Element
{
	[Value("getClientRects")]
	public DOMRectList GetClientRects() { throw new System.NotImplementedException(); }
	[Value("getBoundingClientRect")]
	public DOMRect GetBoundingClientRect() { throw new System.NotImplementedException(); }
	[Value("checkVisibility")]
	public bool CheckVisibility(CheckVisibilityOptions options = default) { throw new System.NotImplementedException(); }
	[Value("scrollIntoView")]
	public Undefined ScrollIntoView(Union21 arg = default) { throw new System.NotImplementedException(); }
	[Value("scroll")]
	public Undefined Scroll(ScrollToOptions options = default) { throw new System.NotImplementedException(); }
	[Value("scroll")]
	public Undefined Scroll(double x, double y) { throw new System.NotImplementedException(); }
	[Value("scrollTo")]
	public Undefined ScrollTo(ScrollToOptions options = default) { throw new System.NotImplementedException(); }
	[Value("scrollTo")]
	public Undefined ScrollTo(double x, double y) { throw new System.NotImplementedException(); }
	[Value("scrollBy")]
	public Undefined ScrollBy(ScrollToOptions options = default) { throw new System.NotImplementedException(); }
	[Value("scrollBy")]
	public Undefined ScrollBy(double x, double y) { throw new System.NotImplementedException(); }
	[Value("scrollTop")]
	public double ScrollTop { get; set; }
	[Value("scrollLeft")]
	public double ScrollLeft { get; set; }
	[Value("scrollWidth")]
	public long ScrollWidth { get; }
	[Value("scrollHeight")]
	public long ScrollHeight { get; }
	[Value("clientTop")]
	public long ClientTop { get; }
	[Value("clientLeft")]
	public long ClientLeft { get; }
	[Value("clientWidth")]
	public long ClientWidth { get; }
	[Value("clientHeight")]
	public long ClientHeight { get; }
	[Value("currentCSSZoom")]
	public Number CurrentCSSZoom { get; }
}

[Value("HTMLElement")]
public partial class HTMLElement
{
	[Value("offsetParent")]
	public Element? OffsetParent { get; }
	[Value("offsetTop")]
	public long OffsetTop { get; }
	[Value("offsetLeft")]
	public long OffsetLeft { get; }
	[Value("offsetWidth")]
	public long OffsetWidth { get; }
	[Value("offsetHeight")]
	public long OffsetHeight { get; }
}

[Value("HTMLImageElement")]
public partial class HTMLImageElement
{
	[Value("x")]
	public long X { get; }
	[Value("y")]
	public long Y { get; }
}

[Value("Range")]
public partial class Range
{
	[Value("getClientRects")]
	public DOMRectList GetClientRects() { throw new System.NotImplementedException(); }
	[Value("getBoundingClientRect")]
	public DOMRect GetBoundingClientRect() { throw new System.NotImplementedException(); }
}

[Value("MouseEvent")]
public partial class MouseEvent
{
	[Value("pageX")]
	public Number PageX { get; }
	[Value("pageY")]
	public Number PageY { get; }
	[Value("x")]
	public Number X { get; }
	[Value("y")]
	public Number Y { get; }
	[Value("offsetX")]
	public Number OffsetX { get; }
	[Value("offsetY")]
	public Number OffsetY { get; }
}

[Value("BoxQuadOptions")]
public partial class BoxQuadOptions
{
	[Value("box")]
	public CSSBoxType Box;
	[Value("relativeTo")]
	public GeometryNode RelativeTo;
}

[Value("ConvertCoordinateOptions")]
public partial class ConvertCoordinateOptions
{
	[Value("fromBox")]
	public CSSBoxType FromBox;
	[Value("toBox")]
	public CSSBoxType ToBox;
}

[Value("VisualViewport")]
public partial class VisualViewport : EventTarget
{
	[Value("offsetLeft")]
	public Number OffsetLeft { get; }
	[Value("offsetTop")]
	public Number OffsetTop { get; }
	[Value("pageLeft")]
	public Number PageLeft { get; }
	[Value("pageTop")]
	public Number PageTop { get; }
	[Value("width")]
	public Number Width { get; }
	[Value("height")]
	public Number Height { get; }
	[Value("scale")]
	public Number Scale { get; }
	[Value("onresize")]
	public EventHandler Onresize { get; set; }
	[Value("onscroll")]
	public EventHandler Onscroll { get; set; }
	[Value("onscrollend")]
	public EventHandler Onscrollend { get; set; }
}


[Value("MediaList")]
public partial class MediaList
{
	[Value("mediaText")]
	public CSSOMString MediaText { get; set; }
	[Value("length")]
	public ulong Length { get; }
	
	[Value("appendMedium")]
	public Undefined AppendMedium(CSSOMString medium) { throw new System.NotImplementedException(); }
	[Value("deleteMedium")]
	public Undefined DeleteMedium(CSSOMString medium) { throw new System.NotImplementedException(); }
}

[Value("StyleSheet")]
public partial class StyleSheet
{
	[Value("type")]
	public CSSOMString Type { get; }
	[Value("href")]
	public USVString? Href { get; }
	[Value("ownerNode")]
	public Union23? OwnerNode { get; }
	[Value("parentStyleSheet")]
	public CSSStyleSheet? ParentStyleSheet { get; }
	[Value("title")]
	public DOMString? Title { get; }
	[Value("media")]
	public MediaList Media { get; }
	[Value("disabled")]
	public bool Disabled { get; set; }
}

[Value("CSSStyleSheet")]
public partial class CSSStyleSheet : StyleSheet
{
		public CSSStyleSheet(CSSStyleSheetInit options = default) { }
	[Value("ownerRule")]
	public CSSRule? OwnerRule { get; }
	[Value("cssRules")]
	public CSSRuleList CssRules { get; }
	[Value("insertRule")]
	public ulong InsertRule(CSSOMString rule, ulong index = default) { throw new System.NotImplementedException(); }
	[Value("deleteRule")]
	public Undefined DeleteRule(ulong index) { throw new System.NotImplementedException(); }
	[Value("replace")]
	public Task<CSSStyleSheet> Replace(USVString text) { throw new System.NotImplementedException(); }
	[Value("replaceSync")]
	public Undefined ReplaceSync(USVString text) { throw new System.NotImplementedException(); }
	public CSSStyleSheet() { }
}

[Value("CSSStyleSheetInit")]
public partial class CSSStyleSheetInit
{
	[Value("baseURL")]
	public DOMString BaseURL;
	[Value("media")]
	public Union24 Media;
	[Value("disabled")]
	public bool Disabled;
}

public partial class CSSStyleSheet
{
	[Value("rules")]
	public CSSRuleList Rules { get; }
	[Value("addRule")]
	public long AddRule(DOMString selector = default, DOMString style = default, ulong index = default) { throw new System.NotImplementedException(); }
	[Value("removeRule")]
	public Undefined RemoveRule(ulong index = default) { throw new System.NotImplementedException(); }
}

[Value("StyleSheetList")]
public partial class StyleSheetList
{
	
	[Value("length")]
	public ulong Length { get; }
}

[Value("CSSRuleList")]
public partial class CSSRuleList
{
	
	[Value("length")]
	public ulong Length { get; }
}

public partial class CSSRule
{
	[Value("cssText")]
	public CSSOMString CssText { get; set; }
	[Value("parentRule")]
	public CSSRule? ParentRule { get; }
	[Value("parentStyleSheet")]
	public CSSStyleSheet? ParentStyleSheet { get; }
	[Value("type")]
	public ushort Type { get; }
	[Value("STYLE_RULE")]
	public const ushort STYLE_RULE = 1;
	[Value("CHARSET_RULE")]
	public const ushort CHARSET_RULE = 2;
	[Value("IMPORT_RULE")]
	public const ushort IMPORT_RULE = 3;
	[Value("MEDIA_RULE")]
	public const ushort MEDIA_RULE = 4;
	[Value("FONT_FACE_RULE")]
	public const ushort FONT_FACE_RULE = 5;
	[Value("PAGE_RULE")]
	public const ushort PAGE_RULE = 6;
	[Value("MARGIN_RULE")]
	public const ushort MARGIN_RULE = 9;
	[Value("NAMESPACE_RULE")]
	public const ushort NAMESPACE_RULE = 10;
}

public partial class CSSStyleRule : CSSGroupingRule
{
	[Value("selectorText")]
	public CSSOMString SelectorText { get; set; }
	[Value("style")]
	public CSSStyleProperties Style { get; }
}

[Value("CSSImportRule")]
public partial class CSSImportRule : CSSRule
{
	[Value("href")]
	public USVString Href { get; }
	[Value("media")]
	public MediaList Media { get; }
	[Value("styleSheet")]
	public CSSStyleSheet? StyleSheet { get; }
	[Value("layerName")]
	public CSSOMString? LayerName { get; }
	[Value("supportsText")]
	public CSSOMString? SupportsText { get; }
}

[Value("CSSGroupingRule")]
public partial class CSSGroupingRule : CSSRule
{
	[Value("cssRules")]
	public CSSRuleList CssRules { get; }
	[Value("insertRule")]
	public ulong InsertRule(CSSOMString rule, ulong index = default) { throw new System.NotImplementedException(); }
	[Value("deleteRule")]
	public Undefined DeleteRule(ulong index) { throw new System.NotImplementedException(); }
}

[Value("CSSPageDescriptors")]
public partial class CSSPageDescriptors : CSSStyleDeclaration
{
	[Value("margin")]
	public CSSOMString Margin { get; set; }
	[Value("marginTop")]
	public CSSOMString MarginTop { get; set; }
	[Value("marginRight")]
	public CSSOMString MarginRight { get; set; }
	[Value("marginBottom")]
	public CSSOMString MarginBottom { get; set; }
	[Value("marginLeft")]
	public CSSOMString MarginLeft { get; set; }
	[Value("margin-top")]
	public CSSOMString Margin_top { get; set; }
	[Value("margin-right")]
	public CSSOMString Margin_right { get; set; }
	[Value("margin-bottom")]
	public CSSOMString Margin_bottom { get; set; }
	[Value("margin-left")]
	public CSSOMString Margin_left { get; set; }
	[Value("size")]
	public CSSOMString Size { get; set; }
	[Value("pageOrientation")]
	public CSSOMString PageOrientation { get; set; }
	[Value("page-orientation")]
	public CSSOMString Page_orientation { get; set; }
	[Value("marks")]
	public CSSOMString Marks { get; set; }
	[Value("bleed")]
	public CSSOMString Bleed { get; set; }
}

[Value("CSSPageRule")]
public partial class CSSPageRule : CSSGroupingRule
{
	[Value("selectorText")]
	public CSSOMString SelectorText { get; set; }
	[Value("style")]
	public CSSPageDescriptors Style { get; }
}

[Value("CSSMarginRule")]
public partial class CSSMarginRule : CSSRule
{
	[Value("name")]
	public CSSOMString Name { get; }
	[Value("style")]
	public CSSStyleDeclaration Style { get; }
}

[Value("CSSNamespaceRule")]
public partial class CSSNamespaceRule : CSSRule
{
	[Value("namespaceURI")]
	public CSSOMString NamespaceURI { get; }
	[Value("prefix")]
	public CSSOMString Prefix { get; }
}

[Value("CSSStyleDeclaration")]
public partial class CSSStyleDeclaration
{
	[Value("cssText")]
	public CSSOMString CssText { get; set; }
	[Value("length")]
	public ulong Length { get; }
	
	[Value("getPropertyValue")]
	public CSSOMString GetPropertyValue(CSSOMString property) { throw new System.NotImplementedException(); }
	[Value("getPropertyPriority")]
	public CSSOMString GetPropertyPriority(CSSOMString property) { throw new System.NotImplementedException(); }
	[Value("setProperty")]
	public Undefined SetProperty(CSSOMString property, CSSOMString value, CSSOMString priority = default) { throw new System.NotImplementedException(); }
	[Value("removeProperty")]
	public CSSOMString RemoveProperty(CSSOMString property) { throw new System.NotImplementedException(); }
	[Value("parentRule")]
	public CSSRule? ParentRule { get; }
}

[Value("CSSStyleProperties")]
public partial class CSSStyleProperties : CSSStyleDeclaration
{
	[Value("cssFloat")]
	public CSSOMString CssFloat { get; set; }
}

public partial class Window
{
	[Value("getComputedStyle")]
	public CSSStyleDeclaration GetComputedStyle(Element elt, CSSOMString? pseudoElt = default) { throw new System.NotImplementedException(); }
}

public partial class CSS
{
	[Value("escape")]
	public CSSOMString Escape(CSSOMString ident) { throw new System.NotImplementedException(); }
}

[Value("DataCue")]
public partial class DataCue : TextTrackCue
{
		public DataCue(Number startTime, double endTime, dynamic value, DOMString type = default) { }
	[Value("value")]
	public dynamic Value { get; set; }
	[Value("type")]
	public DOMString Type { get; }
	public DataCue() { }
}

[Value("DeprecationReportBody")]
public partial class DeprecationReportBody : ReportBody
{
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
	[Value("id")]
	public DOMString Id { get; }
	[Value("anticipatedRemoval")]
	public Object? AnticipatedRemoval { get; }
	[Value("message")]
	public DOMString Message { get; }
	[Value("sourceFile")]
	public DOMString? SourceFile { get; }
	[Value("lineNumber")]
	public ulong? LineNumber { get; }
	[Value("columnNumber")]
	public ulong? ColumnNumber { get; }
}

[Value("NavigatorManagedData")]
public partial class NavigatorManagedData
{
	[Value("getAnnotatedAssetId")]
	public Task<DOMString> GetAnnotatedAssetId() { throw new System.NotImplementedException(); }
	[Value("getAnnotatedLocation")]
	public Task<DOMString> GetAnnotatedLocation() { throw new System.NotImplementedException(); }
	[Value("getDirectoryId")]
	public Task<DOMString> GetDirectoryId() { throw new System.NotImplementedException(); }
	[Value("getHostname")]
	public Task<DOMString> GetHostname() { throw new System.NotImplementedException(); }
	[Value("getSerialNumber")]
	public Task<DOMString> GetSerialNumber() { throw new System.NotImplementedException(); }
}

public partial class Navigator
{
	[Value("devicePosture")]
	public DevicePosture DevicePosture { get; }
}

[Value("DevicePosture")]
public partial class DevicePosture : EventTarget
{
	[Value("type")]
	public DevicePostureType Type { get; }
	[Value("onchange")]
	public EventHandler Onchange { get; set; }
}

public partial class CredentialRequestOptions
{
	[Value("digital")]
	public DigitalCredentialRequestOptions Digital;
}

[Value("DigitalCredentialRequestOptions")]
public partial class DigitalCredentialRequestOptions
{
	[Value("requests")]
	public List<DigitalCredentialRequest> Requests;
}

[Value("DigitalCredentialRequest")]
public partial class DigitalCredentialRequest
{
	[Value("protocol")]
	public required DOMString Protocol;
	[Value("data")]
	public required Object Data;
}

[Value("DigitalCredential")]
public partial class DigitalCredential : Credential
{
	[Value("protocol")]
	public DOMString Protocol { get; }
	[Value("data")]
	public Object Data { get; }
}

public partial class Window
{
	[Value("getDigitalGoodsService")]
	public Task<DigitalGoodsService> GetDigitalGoodsService(DOMString serviceProvider) { throw new System.NotImplementedException(); }
}

[Value("DigitalGoodsService")]
public partial class DigitalGoodsService
{
	[Value("getDetails")]
	public Task<List<ItemDetails>> GetDetails(List<DOMString> itemIds) { throw new System.NotImplementedException(); }
	[Value("listPurchases")]
	public Task<List<PurchaseDetails>> ListPurchases() { throw new System.NotImplementedException(); }
	[Value("listPurchaseHistory")]
	public Task<List<PurchaseDetails>> ListPurchaseHistory() { throw new System.NotImplementedException(); }
	[Value("consume")]
	public Task<Undefined> Consume(DOMString purchaseToken) { throw new System.NotImplementedException(); }
}

[Value("ItemDetails")]
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

[Value("PurchaseDetails")]
public partial class PurchaseDetails
{
	[Value("itemId")]
	public required DOMString ItemId;
	[Value("purchaseToken")]
	public required DOMString PurchaseToken;
}

public partial class Window
{
	[Value("documentPictureInPicture")]
	public DocumentPictureInPicture DocumentPictureInPicture { get; }
}

[Value("DocumentPictureInPicture")]
public partial class DocumentPictureInPicture : EventTarget
{
	[Value("requestWindow")]
	public Task<Window> RequestWindow(DocumentPictureInPictureOptions options = default) { throw new System.NotImplementedException(); }
	[Value("window")]
	public Window _window { get; }
	[Value("onenter")]
	public EventHandler Onenter { get; set; }
}

[Value("DocumentPictureInPictureOptions")]
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

[Value("DocumentPictureInPictureEvent")]
public partial class DocumentPictureInPictureEvent : Event
{
		public DocumentPictureInPictureEvent(DOMString type, DocumentPictureInPictureEventInit eventInitDict) { }
	[Value("window")]
	public Window _window { get; }
	public DocumentPictureInPictureEvent() { }
}

[Value("DocumentPictureInPictureEventInit")]
public partial class DocumentPictureInPictureEventInit : EventInit
{
	[Value("window")]
	public required Window Window;
}

[Value("XMLSerializer")]
public partial class XMLSerializer
{
		public XMLSerializer() { }
	[Value("serializeToString")]
	public DOMString SerializeToString(Node root) { throw new System.NotImplementedException(); }
}

[Value("Event")]
public partial class Event
{
		public Event(DOMString type, EventInit eventInitDict = default) { }
	[Value("type")]
	public DOMString Type { get; }
	[Value("target")]
	public EventTarget? Target { get; }
	[Value("srcElement")]
	public EventTarget? SrcElement { get; }
	[Value("currentTarget")]
	public EventTarget? CurrentTarget { get; }
	[Value("composedPath")]
	public List<EventTarget> ComposedPath() { throw new System.NotImplementedException(); }
	[Value("NONE")]
	public const ushort NONE = 0;
	[Value("CAPTURING_PHASE")]
	public const ushort CAPTURING_PHASE = 1;
	[Value("AT_TARGET")]
	public const ushort AT_TARGET = 2;
	[Value("BUBBLING_PHASE")]
	public const ushort BUBBLING_PHASE = 3;
	[Value("eventPhase")]
	public ushort EventPhase { get; }
	[Value("stopPropagation")]
	public Undefined StopPropagation() { throw new System.NotImplementedException(); }
	[Value("cancelBubble")]
	public bool CancelBubble { get; set; }
	[Value("stopImmediatePropagation")]
	public Undefined StopImmediatePropagation() { throw new System.NotImplementedException(); }
	[Value("bubbles")]
	public bool Bubbles { get; }
	[Value("cancelable")]
	public bool Cancelable { get; }
	[Value("returnValue")]
	public bool ReturnValue { get; set; }
	[Value("preventDefault")]
	public Undefined PreventDefault() { throw new System.NotImplementedException(); }
	[Value("defaultPrevented")]
	public bool DefaultPrevented { get; }
	[Value("composed")]
	public bool Composed { get; }
	[Value("isTrusted")]
	public bool IsTrusted { get; }
	[Value("timeStamp")]
	public DOMHighResTimeStamp TimeStamp { get; }
	[Value("initEvent")]
	public Undefined InitEvent(DOMString type, bool bubbles = default, bool cancelable = default) { throw new System.NotImplementedException(); }
	public Event() { }
}

[Value("EventInit")]
public partial class EventInit
{
	[Value("bubbles")]
	public bool Bubbles;
	[Value("cancelable")]
	public bool Cancelable;
	[Value("composed")]
	public bool Composed;
}

public partial class Window
{
	[Value("event")]
	public Union25 Event { get; }
}

[Value("CustomEvent")]
public partial class CustomEvent : Event
{
		public CustomEvent(DOMString type, CustomEventInit eventInitDict = default) { }
	[Value("detail")]
	public dynamic Detail { get; }
	[Value("initCustomEvent")]
	public Undefined InitCustomEvent(DOMString type, bool bubbles = default, bool cancelable = default, dynamic detail = default) { throw new System.NotImplementedException(); }
	public CustomEvent() { }
}

[Value("CustomEventInit")]
public partial class CustomEventInit : EventInit
{
	[Value("detail")]
	public dynamic Detail;
}

[Value("EventTarget")]
public partial class EventTarget
{
		public EventTarget() { }
	[Value("addEventListener")]
	public Undefined AddEventListener(DOMString type, EventListener? callback, Union26 options = default) { throw new System.NotImplementedException(); }
	[Value("removeEventListener")]
	public Undefined RemoveEventListener(DOMString type, EventListener? callback, Union27 options = default) { throw new System.NotImplementedException(); }
	[Value("dispatchEvent")]
	public bool DispatchEvent(Event event_) { throw new System.NotImplementedException(); }
}

[Value("EventListenerOptions")]
public partial class EventListenerOptions
{
	[Value("capture")]
	public bool Capture;
}

[Value("AddEventListenerOptions")]
public partial class AddEventListenerOptions : EventListenerOptions
{
	[Value("passive")]
	public bool Passive;
	[Value("once")]
	public bool Once;
	[Value("signal")]
	public AbortSignal Signal;
}

[Value("AbortController")]
public partial class AbortController
{
		public AbortController() { }
	[Value("signal")]
	public AbortSignal Signal { get; }
	[Value("abort")]
	public Undefined Abort(dynamic reason = default) { throw new System.NotImplementedException(); }
}

[Value("AbortSignal")]
public partial class AbortSignal : EventTarget
{
	[Value("abort")]
	public static AbortSignal Abort(dynamic reason = default) { throw new System.NotImplementedException(); }
	[Value("timeout")]
	public static AbortSignal Timeout(ulong milliseconds) { throw new System.NotImplementedException(); }
	[Value("any")]
	public static AbortSignal Any(List<AbortSignal> signals) { throw new System.NotImplementedException(); }
	[Value("aborted")]
	public bool Aborted { get; }
	[Value("reason")]
	public dynamic Reason { get; }
	[Value("throwIfAborted")]
	public Undefined ThrowIfAborted() { throw new System.NotImplementedException(); }
	[Value("onabort")]
	public EventHandler Onabort { get; set; }
}

[Value("NodeList")]
public partial class NodeList
{
	
	[Value("length")]
	public ulong Length { get; }
	public Node this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
}

[Value("HTMLCollection")]
public partial class HTMLCollection
{
	[Value("length")]
	public ulong Length { get; }
	
	
}

[Value("MutationObserver")]
public partial class MutationObserver
{
		public MutationObserver(MutationCallback callback) { }
	[Value("observe")]
	public Undefined Observe(Node target, MutationObserverInit options = default) { throw new System.NotImplementedException(); }
	[Value("disconnect")]
	public Undefined Disconnect() { throw new System.NotImplementedException(); }
	[Value("takeRecords")]
	public List<MutationRecord> TakeRecords() { throw new System.NotImplementedException(); }
	public MutationObserver() { }
}

[Value("MutationObserverInit")]
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

[Value("MutationRecord")]
public partial class MutationRecord
{
	[Value("type")]
	public DOMString Type { get; }
	[Value("target")]
	public Node Target { get; }
	[Value("addedNodes")]
	public NodeList AddedNodes { get; }
	[Value("removedNodes")]
	public NodeList RemovedNodes { get; }
	[Value("previousSibling")]
	public Node? PreviousSibling { get; }
	[Value("nextSibling")]
	public Node? NextSibling { get; }
	[Value("attributeName")]
	public DOMString? AttributeName { get; }
	[Value("attributeNamespace")]
	public DOMString? AttributeNamespace { get; }
	[Value("oldValue")]
	public DOMString? OldValue { get; }
}

[Value("Node")]
public partial class Node : EventTarget
{
	[Value("ELEMENT_NODE")]
	public const ushort ELEMENT_NODE = 1;
	[Value("ATTRIBUTE_NODE")]
	public const ushort ATTRIBUTE_NODE = 2;
	[Value("TEXT_NODE")]
	public const ushort TEXT_NODE = 3;
	[Value("CDATA_SECTION_NODE")]
	public const ushort CDATA_SECTION_NODE = 4;
	[Value("ENTITY_REFERENCE_NODE")]
	public const ushort ENTITY_REFERENCE_NODE = 5;
	[Value("ENTITY_NODE")]
	public const ushort ENTITY_NODE = 6;
	[Value("PROCESSING_INSTRUCTION_NODE")]
	public const ushort PROCESSING_INSTRUCTION_NODE = 7;
	[Value("COMMENT_NODE")]
	public const ushort COMMENT_NODE = 8;
	[Value("DOCUMENT_NODE")]
	public const ushort DOCUMENT_NODE = 9;
	[Value("DOCUMENT_TYPE_NODE")]
	public const ushort DOCUMENT_TYPE_NODE = 10;
	[Value("DOCUMENT_FRAGMENT_NODE")]
	public const ushort DOCUMENT_FRAGMENT_NODE = 11;
	[Value("NOTATION_NODE")]
	public const ushort NOTATION_NODE = 12;
	[Value("nodeType")]
	public ushort NodeType { get; }
	[Value("nodeName")]
	public DOMString NodeName { get; }
	[Value("baseURI")]
	public USVString BaseURI { get; }
	[Value("isConnected")]
	public bool IsConnected { get; }
	[Value("ownerDocument")]
	public Document? OwnerDocument { get; }
	[Value("getRootNode")]
	public Node GetRootNode(GetRootNodeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("parentNode")]
	public Node? ParentNode { get; }
	[Value("parentElement")]
	public Element? ParentElement { get; }
	[Value("hasChildNodes")]
	public bool HasChildNodes() { throw new System.NotImplementedException(); }
	[Value("childNodes")]
	public NodeList ChildNodes { get; }
	[Value("firstChild")]
	public Node? FirstChild { get; }
	[Value("lastChild")]
	public Node? LastChild { get; }
	[Value("previousSibling")]
	public Node? PreviousSibling { get; }
	[Value("nextSibling")]
	public Node? NextSibling { get; }
	[Value("nodeValue")]
	public DOMString? NodeValue { get; set; }
	[Value("textContent")]
	public DOMString? TextContent { get; set; }
	[Value("normalize")]
	public Undefined Normalize() { throw new System.NotImplementedException(); }
	[Value("cloneNode")]
	public Node CloneNode(bool subtree = default) { throw new System.NotImplementedException(); }
	[Value("isEqualNode")]
	public bool IsEqualNode(Node? otherNode) { throw new System.NotImplementedException(); }
	[Value("isSameNode")]
	public bool IsSameNode(Node? otherNode) { throw new System.NotImplementedException(); }
	[Value("DOCUMENT_POSITION_DISCONNECTED")]
	public const ushort DOCUMENT_POSITION_DISCONNECTED = 0x01;
	[Value("DOCUMENT_POSITION_PRECEDING")]
	public const ushort DOCUMENT_POSITION_PRECEDING = 0x02;
	[Value("DOCUMENT_POSITION_FOLLOWING")]
	public const ushort DOCUMENT_POSITION_FOLLOWING = 0x04;
	[Value("DOCUMENT_POSITION_CONTAINS")]
	public const ushort DOCUMENT_POSITION_CONTAINS = 0x08;
	[Value("DOCUMENT_POSITION_CONTAINED_BY")]
	public const ushort DOCUMENT_POSITION_CONTAINED_BY = 0x10;
	[Value("DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC")]
	public const ushort DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC = 0x20;
	[Value("compareDocumentPosition")]
	public ushort CompareDocumentPosition(Node other) { throw new System.NotImplementedException(); }
	[Value("contains")]
	public bool Contains(Node? other) { throw new System.NotImplementedException(); }
	[Value("lookupPrefix")]
	public DOMString? LookupPrefix(DOMString? namespace_) { throw new System.NotImplementedException(); }
	[Value("lookupNamespaceURI")]
	public DOMString? LookupNamespaceURI(DOMString? prefix) { throw new System.NotImplementedException(); }
	[Value("isDefaultNamespace")]
	public bool IsDefaultNamespace(DOMString? namespace_) { throw new System.NotImplementedException(); }
	[Value("insertBefore")]
	public Node InsertBefore(Node node, Node? child) { throw new System.NotImplementedException(); }
	[Value("appendChild")]
	public Node AppendChild(Node node) { throw new System.NotImplementedException(); }
	[Value("replaceChild")]
	public Node ReplaceChild(Node node, Node child) { throw new System.NotImplementedException(); }
	[Value("removeChild")]
	public Node RemoveChild(Node child) { throw new System.NotImplementedException(); }
}

[Value("GetRootNodeOptions")]
public partial class GetRootNodeOptions
{
	[Value("composed")]
	public bool Composed;
}

public partial class Document : Node
{
		public Document() { }
	[Value("implementation")]
	public DOMImplementation Implementation { get; }
	[Value("URL")]
	public USVString URL { get; }
	[Value("documentURI")]
	public USVString DocumentURI { get; }
	[Value("compatMode")]
	public DOMString CompatMode { get; }
	[Value("characterSet")]
	public DOMString CharacterSet { get; }
	[Value("charset")]
	public DOMString Charset { get; }
	[Value("inputEncoding")]
	public DOMString InputEncoding { get; }
	[Value("contentType")]
	public DOMString ContentType { get; }
	[Value("doctype")]
	public DocumentType? Doctype { get; }
	[Value("documentElement")]
	public Element? DocumentElement { get; }
	[Value("getElementsByTagName")]
	public HTMLCollection GetElementsByTagName(DOMString qualifiedName) { throw new System.NotImplementedException(); }
	[Value("getElementsByTagNameNS")]
	public HTMLCollection GetElementsByTagNameNS(DOMString? namespace_, DOMString localName) { throw new System.NotImplementedException(); }
	[Value("getElementsByClassName")]
	public HTMLCollection GetElementsByClassName(DOMString classNames) { throw new System.NotImplementedException(); }
	[Value("createElement")]
	public Element CreateElement(DOMString localName, Union34 options = default) { throw new System.NotImplementedException(); }
	[Value("createElementNS")]
	public Element CreateElementNS(DOMString? namespace_, DOMString qualifiedName, Union35 options = default) { throw new System.NotImplementedException(); }
	[Value("createDocumentFragment")]
	public DocumentFragment CreateDocumentFragment() { throw new System.NotImplementedException(); }
	[Value("createTextNode")]
	public Text CreateTextNode(DOMString data) { throw new System.NotImplementedException(); }
	[Value("createCDATASection")]
	public CDATASection CreateCDATASection(DOMString data) { throw new System.NotImplementedException(); }
	[Value("createComment")]
	public Comment CreateComment(DOMString data) { throw new System.NotImplementedException(); }
	[Value("createProcessingInstruction")]
	public ProcessingInstruction CreateProcessingInstruction(DOMString target, DOMString data) { throw new System.NotImplementedException(); }
	[Value("importNode")]
	public Node ImportNode(Node node, bool subtree = default) { throw new System.NotImplementedException(); }
	[Value("adoptNode")]
	public Node AdoptNode(Node node) { throw new System.NotImplementedException(); }
	[Value("createAttribute")]
	public Attr CreateAttribute(DOMString localName) { throw new System.NotImplementedException(); }
	[Value("createAttributeNS")]
	public Attr CreateAttributeNS(DOMString? namespace_, DOMString qualifiedName) { throw new System.NotImplementedException(); }
	[Value("createEvent")]
	public Event CreateEvent(DOMString interface_) { throw new System.NotImplementedException(); }
	[Value("createRange")]
	public Range CreateRange() { throw new System.NotImplementedException(); }
	[Value("createNodeIterator")]
	public NodeIterator CreateNodeIterator(Node root, ulong whatToShow = default, NodeFilter? filter = default) { throw new System.NotImplementedException(); }
	[Value("createTreeWalker")]
	public TreeWalker CreateTreeWalker(Node root, ulong whatToShow = default, NodeFilter? filter = default) { throw new System.NotImplementedException(); }
}

[Value("XMLDocument")]
public partial class XMLDocument : Document
{
}

[Value("ElementCreationOptions")]
public partial class ElementCreationOptions
{
	[Value("is")]
	public DOMString Is;
}

[Value("DOMImplementation")]
public partial class DOMImplementation
{
	[Value("createDocumentType")]
	public DocumentType CreateDocumentType(DOMString qualifiedName, DOMString publicId, DOMString systemId) { throw new System.NotImplementedException(); }
	[Value("createDocument")]
	public XMLDocument CreateDocument(DOMString? namespace_, DOMString qualifiedName, DocumentType? doctype = default) { throw new System.NotImplementedException(); }
	[Value("createHTMLDocument")]
	public Document CreateHTMLDocument(DOMString title = default) { throw new System.NotImplementedException(); }
	[Value("hasFeature")]
	public bool HasFeature() { throw new System.NotImplementedException(); }
}

[Value("DocumentType")]
public partial class DocumentType : Node, ChildNode
{
	[Value("name")]
	public DOMString Name { get; }
	[Value("publicId")]
	public DOMString PublicId { get; }
	[Value("systemId")]
	public DOMString SystemId { get; }
}

[Value("DocumentFragment")]
public partial class DocumentFragment : Node, NonElementParentNode, ParentNode
{
		public DocumentFragment() { }
}

[Value("ShadowRoot")]
public partial class ShadowRoot : DocumentFragment, DocumentOrShadowRoot
{
	[Value("mode")]
	public ShadowRootMode Mode { get; }
	[Value("delegatesFocus")]
	public bool DelegatesFocus { get; }
	[Value("slotAssignment")]
	public SlotAssignmentMode SlotAssignment { get; }
	[Value("clonable")]
	public bool Clonable { get; }
	[Value("serializable")]
	public bool Serializable { get; }
	[Value("host")]
	public Element Host { get; }
	[Value("onslotchange")]
	public EventHandler Onslotchange { get; set; }
}

public partial class Element : Node
{
	[Value("namespaceURI")]
	public DOMString? NamespaceURI { get; }
	[Value("prefix")]
	public DOMString? Prefix { get; }
	[Value("localName")]
	public DOMString LocalName { get; }
	[Value("tagName")]
	public DOMString TagName { get; }
	[Value("id")]
	public DOMString Id { get; set; }
	[Value("className")]
	public DOMString ClassName { get; set; }
	[Value("classList")]
	public DOMTokenList ClassList { get; }
	[Value("slot")]
	public DOMString Slot { get; set; }
	[Value("hasAttributes")]
	public bool HasAttributes() { throw new System.NotImplementedException(); }
	[Value("attributes")]
	public NamedNodeMap Attributes { get; }
	[Value("getAttributeNames")]
	public List<DOMString> GetAttributeNames() { throw new System.NotImplementedException(); }
	[Value("getAttribute")]
	public DOMString? GetAttribute(DOMString qualifiedName) { throw new System.NotImplementedException(); }
	[Value("getAttributeNS")]
	public DOMString? GetAttributeNS(DOMString? namespace_, DOMString localName) { throw new System.NotImplementedException(); }
	[Value("setAttribute")]
	public Undefined SetAttribute(DOMString qualifiedName, DOMString value) { throw new System.NotImplementedException(); }
	[Value("setAttributeNS")]
	public Undefined SetAttributeNS(DOMString? namespace_, DOMString qualifiedName, DOMString value) { throw new System.NotImplementedException(); }
	[Value("removeAttribute")]
	public Undefined RemoveAttribute(DOMString qualifiedName) { throw new System.NotImplementedException(); }
	[Value("removeAttributeNS")]
	public Undefined RemoveAttributeNS(DOMString? namespace_, DOMString localName) { throw new System.NotImplementedException(); }
	[Value("toggleAttribute")]
	public bool ToggleAttribute(DOMString qualifiedName, bool force = default) { throw new System.NotImplementedException(); }
	[Value("hasAttribute")]
	public bool HasAttribute(DOMString qualifiedName) { throw new System.NotImplementedException(); }
	[Value("hasAttributeNS")]
	public bool HasAttributeNS(DOMString? namespace_, DOMString localName) { throw new System.NotImplementedException(); }
	[Value("getAttributeNode")]
	public Attr? GetAttributeNode(DOMString qualifiedName) { throw new System.NotImplementedException(); }
	[Value("getAttributeNodeNS")]
	public Attr? GetAttributeNodeNS(DOMString? namespace_, DOMString localName) { throw new System.NotImplementedException(); }
	[Value("setAttributeNode")]
	public Attr? SetAttributeNode(Attr attr) { throw new System.NotImplementedException(); }
	[Value("setAttributeNodeNS")]
	public Attr? SetAttributeNodeNS(Attr attr) { throw new System.NotImplementedException(); }
	[Value("removeAttributeNode")]
	public Attr RemoveAttributeNode(Attr attr) { throw new System.NotImplementedException(); }
	[Value("attachShadow")]
	public ShadowRoot AttachShadow(ShadowRootInit init) { throw new System.NotImplementedException(); }
	[Value("shadowRoot")]
	public ShadowRoot? ShadowRoot { get; }
	[Value("closest")]
	public Element? Closest(DOMString selectors) { throw new System.NotImplementedException(); }
	[Value("matches")]
	public bool Matches(DOMString selectors) { throw new System.NotImplementedException(); }
	[Value("webkitMatchesSelector")]
	public bool WebkitMatchesSelector(DOMString selectors) { throw new System.NotImplementedException(); }
	[Value("getElementsByTagName")]
	public HTMLCollection GetElementsByTagName(DOMString qualifiedName) { throw new System.NotImplementedException(); }
	[Value("getElementsByTagNameNS")]
	public HTMLCollection GetElementsByTagNameNS(DOMString? namespace_, DOMString localName) { throw new System.NotImplementedException(); }
	[Value("getElementsByClassName")]
	public HTMLCollection GetElementsByClassName(DOMString classNames) { throw new System.NotImplementedException(); }
	[Value("insertAdjacentElement")]
	public Element? InsertAdjacentElement(DOMString where, Element element) { throw new System.NotImplementedException(); }
	[Value("insertAdjacentText")]
	public Undefined InsertAdjacentText(DOMString where, DOMString data) { throw new System.NotImplementedException(); }
}

[Value("ShadowRootInit")]
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

[Value("NamedNodeMap")]
public partial class NamedNodeMap
{
	[Value("length")]
	public ulong Length { get; }
	
	
	[Value("getNamedItemNS")]
	public Attr? GetNamedItemNS(DOMString? namespace_, DOMString localName) { throw new System.NotImplementedException(); }
	[Value("setNamedItem")]
	public Attr? SetNamedItem(Attr attr) { throw new System.NotImplementedException(); }
	[Value("setNamedItemNS")]
	public Attr? SetNamedItemNS(Attr attr) { throw new System.NotImplementedException(); }
	[Value("removeNamedItem")]
	public Attr RemoveNamedItem(DOMString qualifiedName) { throw new System.NotImplementedException(); }
	[Value("removeNamedItemNS")]
	public Attr RemoveNamedItemNS(DOMString? namespace_, DOMString localName) { throw new System.NotImplementedException(); }
}

[Value("Attr")]
public partial class Attr : Node
{
	[Value("namespaceURI")]
	public DOMString? NamespaceURI { get; }
	[Value("prefix")]
	public DOMString? Prefix { get; }
	[Value("localName")]
	public DOMString LocalName { get; }
	[Value("name")]
	public DOMString Name { get; }
	[Value("value")]
	public DOMString Value { get; set; }
	[Value("ownerElement")]
	public Element? OwnerElement { get; }
	[Value("specified")]
	public bool Specified { get; }
}

[Value("CharacterData")]
public partial class CharacterData : Node, NonDocumentTypeChildNode, ChildNode
{
	[Value("data")]
	public DOMString Data { get; set; }
	[Value("length")]
	public ulong Length { get; }
	[Value("substringData")]
	public DOMString SubstringData(ulong offset, ulong count) { throw new System.NotImplementedException(); }
	[Value("appendData")]
	public Undefined AppendData(DOMString data) { throw new System.NotImplementedException(); }
	[Value("insertData")]
	public Undefined InsertData(ulong offset, DOMString data) { throw new System.NotImplementedException(); }
	[Value("deleteData")]
	public Undefined DeleteData(ulong offset, ulong count) { throw new System.NotImplementedException(); }
	[Value("replaceData")]
	public Undefined ReplaceData(ulong offset, ulong count, DOMString data) { throw new System.NotImplementedException(); }
}

[Value("Text")]
public partial class Text : CharacterData, GeometryUtils, Slottable
{
		public Text(DOMString data = default) { }
	[Value("splitText")]
	public Text SplitText(ulong offset) { throw new System.NotImplementedException(); }
	[Value("wholeText")]
	public DOMString WholeText { get; }
	public Text() { }
}

[Value("CDATASection")]
public partial class CDATASection : Text
{
}

[Value("ProcessingInstruction")]
public partial class ProcessingInstruction : CharacterData, LinkStyle
{
	[Value("target")]
	public DOMString Target { get; }
}

[Value("Comment")]
public partial class Comment : CharacterData
{
		public Comment(DOMString data = default) { }
	public Comment() { }
}

[Value("AbstractRange")]
public partial class AbstractRange
{
	[Value("startContainer")]
	public Node StartContainer { get; }
	[Value("startOffset")]
	public ulong StartOffset { get; }
	[Value("endContainer")]
	public Node EndContainer { get; }
	[Value("endOffset")]
	public ulong EndOffset { get; }
	[Value("collapsed")]
	public bool Collapsed { get; }
}

[Value("StaticRangeInit")]
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

[Value("StaticRange")]
public partial class StaticRange : AbstractRange
{
		public StaticRange(StaticRangeInit init) { }
	public StaticRange() { }
}

public partial class Range : AbstractRange
{
		public Range() { }
	[Value("commonAncestorContainer")]
	public Node CommonAncestorContainer { get; }
	[Value("setStart")]
	public Undefined SetStart(Node node, ulong offset) { throw new System.NotImplementedException(); }
	[Value("setEnd")]
	public Undefined SetEnd(Node node, ulong offset) { throw new System.NotImplementedException(); }
	[Value("setStartBefore")]
	public Undefined SetStartBefore(Node node) { throw new System.NotImplementedException(); }
	[Value("setStartAfter")]
	public Undefined SetStartAfter(Node node) { throw new System.NotImplementedException(); }
	[Value("setEndBefore")]
	public Undefined SetEndBefore(Node node) { throw new System.NotImplementedException(); }
	[Value("setEndAfter")]
	public Undefined SetEndAfter(Node node) { throw new System.NotImplementedException(); }
	[Value("collapse")]
	public Undefined Collapse(bool toStart = default) { throw new System.NotImplementedException(); }
	[Value("selectNode")]
	public Undefined SelectNode(Node node) { throw new System.NotImplementedException(); }
	[Value("selectNodeContents")]
	public Undefined SelectNodeContents(Node node) { throw new System.NotImplementedException(); }
	[Value("START_TO_START")]
	public const ushort START_TO_START = 0;
	[Value("START_TO_END")]
	public const ushort START_TO_END = 1;
	[Value("END_TO_END")]
	public const ushort END_TO_END = 2;
	[Value("END_TO_START")]
	public const ushort END_TO_START = 3;
	[Value("compareBoundaryPoints")]
	public Number CompareBoundaryPoints(ushort how, Range sourceRange) { throw new System.NotImplementedException(); }
	[Value("deleteContents")]
	public Undefined DeleteContents() { throw new System.NotImplementedException(); }
	[Value("extractContents")]
	public DocumentFragment ExtractContents() { throw new System.NotImplementedException(); }
	[Value("cloneContents")]
	public DocumentFragment CloneContents() { throw new System.NotImplementedException(); }
	[Value("insertNode")]
	public Undefined InsertNode(Node node) { throw new System.NotImplementedException(); }
	[Value("surroundContents")]
	public Undefined SurroundContents(Node newParent) { throw new System.NotImplementedException(); }
	[Value("cloneRange")]
	public Range CloneRange() { throw new System.NotImplementedException(); }
	[Value("detach")]
	public Undefined Detach() { throw new System.NotImplementedException(); }
	[Value("isPointInRange")]
	public bool IsPointInRange(Node node, ulong offset) { throw new System.NotImplementedException(); }
	[Value("comparePoint")]
	public Number ComparePoint(Node node, ulong offset) { throw new System.NotImplementedException(); }
	[Value("intersectsNode")]
	public bool IntersectsNode(Node node) { throw new System.NotImplementedException(); }
	
}

[Value("NodeIterator")]
public partial class NodeIterator
{
	[Value("root")]
	public Node Root { get; }
	[Value("referenceNode")]
	public Node ReferenceNode { get; }
	[Value("pointerBeforeReferenceNode")]
	public bool PointerBeforeReferenceNode { get; }
	[Value("whatToShow")]
	public ulong WhatToShow { get; }
	[Value("filter")]
	public NodeFilter? Filter { get; }
	[Value("nextNode")]
	public Node? NextNode() { throw new System.NotImplementedException(); }
	[Value("previousNode")]
	public Node? PreviousNode() { throw new System.NotImplementedException(); }
	[Value("detach")]
	public Undefined Detach() { throw new System.NotImplementedException(); }
}

[Value("TreeWalker")]
public partial class TreeWalker
{
	[Value("root")]
	public Node Root { get; }
	[Value("whatToShow")]
	public ulong WhatToShow { get; }
	[Value("filter")]
	public NodeFilter? Filter { get; }
	[Value("currentNode")]
	public Node CurrentNode { get; set; }
	[Value("parentNode")]
	public Node? ParentNode() { throw new System.NotImplementedException(); }
	[Value("firstChild")]
	public Node? FirstChild() { throw new System.NotImplementedException(); }
	[Value("lastChild")]
	public Node? LastChild() { throw new System.NotImplementedException(); }
	[Value("previousSibling")]
	public Node? PreviousSibling() { throw new System.NotImplementedException(); }
	[Value("nextSibling")]
	public Node? NextSibling() { throw new System.NotImplementedException(); }
	[Value("previousNode")]
	public Node? PreviousNode() { throw new System.NotImplementedException(); }
	[Value("nextNode")]
	public Node? NextNode() { throw new System.NotImplementedException(); }
}

[Value("DOMTokenList")]
public partial class DOMTokenList
{
	[Value("length")]
	public ulong Length { get; }
	
	[Value("contains")]
	public bool Contains(DOMString token) { throw new System.NotImplementedException(); }
	[Value("add")]
	public Undefined Add(params DOMString[] tokens) { throw new System.NotImplementedException(); }
	[Value("remove")]
	public Undefined Remove(params DOMString[] tokens) { throw new System.NotImplementedException(); }
	[Value("toggle")]
	public bool Toggle(DOMString token, bool force = default) { throw new System.NotImplementedException(); }
	[Value("replace")]
	public bool Replace(DOMString token, DOMString newToken) { throw new System.NotImplementedException(); }
	[Value("supports")]
	public bool Supports(DOMString token) { throw new System.NotImplementedException(); }
	[Value("value")]
	public DOMString Value { get; set; }
	public DOMString this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
}

[Value("XPathResult")]
public partial class XPathResult
{
	[Value("ANY_TYPE")]
	public const ushort ANY_TYPE = 0;
	[Value("NUMBER_TYPE")]
	public const ushort NUMBER_TYPE = 1;
	[Value("STRING_TYPE")]
	public const ushort STRING_TYPE = 2;
	[Value("BOOLEAN_TYPE")]
	public const ushort BOOLEAN_TYPE = 3;
	[Value("UNORDERED_NODE_ITERATOR_TYPE")]
	public const ushort UNORDERED_NODE_ITERATOR_TYPE = 4;
	[Value("ORDERED_NODE_ITERATOR_TYPE")]
	public const ushort ORDERED_NODE_ITERATOR_TYPE = 5;
	[Value("UNORDERED_NODE_SNAPSHOT_TYPE")]
	public const ushort UNORDERED_NODE_SNAPSHOT_TYPE = 6;
	[Value("ORDERED_NODE_SNAPSHOT_TYPE")]
	public const ushort ORDERED_NODE_SNAPSHOT_TYPE = 7;
	[Value("ANY_UNORDERED_NODE_TYPE")]
	public const ushort ANY_UNORDERED_NODE_TYPE = 8;
	[Value("FIRST_ORDERED_NODE_TYPE")]
	public const ushort FIRST_ORDERED_NODE_TYPE = 9;
	[Value("resultType")]
	public ushort ResultType { get; }
	[Value("numberValue")]
	public double NumberValue { get; }
	[Value("stringValue")]
	public DOMString StringValue { get; }
	[Value("booleanValue")]
	public bool BooleanValue { get; }
	[Value("singleNodeValue")]
	public Node? SingleNodeValue { get; }
	[Value("invalidIteratorState")]
	public bool InvalidIteratorState { get; }
	[Value("snapshotLength")]
	public ulong SnapshotLength { get; }
	[Value("iterateNext")]
	public Node? IterateNext() { throw new System.NotImplementedException(); }
	[Value("snapshotItem")]
	public Node? SnapshotItem(ulong index) { throw new System.NotImplementedException(); }
}

[Value("XPathExpression")]
public partial class XPathExpression
{
	[Value("evaluate")]
	public XPathResult Evaluate(Node contextNode, ushort type = default, XPathResult? result = default) { throw new System.NotImplementedException(); }
}

[Value("XPathEvaluator")]
public partial class XPathEvaluator
{
		public XPathEvaluator() { }
}


[Value("XSLTProcessor")]
public partial class XSLTProcessor
{
		public XSLTProcessor() { }
	[Value("importStylesheet")]
	public Undefined ImportStylesheet(Node style) { throw new System.NotImplementedException(); }
	[Value("transformToFragment")]
	public DocumentFragment TransformToFragment(Node source, Document output) { throw new System.NotImplementedException(); }
	[Value("transformToDocument")]
	public Document TransformToDocument(Node source) { throw new System.NotImplementedException(); }
	[Value("setParameter")]
	public Undefined SetParameter(DOMString namespaceURI, DOMString localName, dynamic value) { throw new System.NotImplementedException(); }
	[Value("getParameter")]
	public dynamic GetParameter(DOMString namespaceURI, DOMString localName) { throw new System.NotImplementedException(); }
	[Value("removeParameter")]
	public Undefined RemoveParameter(DOMString namespaceURI, DOMString localName) { throw new System.NotImplementedException(); }
	[Value("clearParameters")]
	public Undefined ClearParameters() { throw new System.NotImplementedException(); }
	[Value("reset")]
	public Undefined Reset() { throw new System.NotImplementedException(); }
}

public partial class HTMLElement
{
	[Value("editContext")]
	public EditContext? EditContext { get; set; }
}

[Value("EditContextInit")]
public partial class EditContextInit
{
	[Value("text")]
	public DOMString Text;
	[Value("selectionStart")]
	public ulong SelectionStart;
	[Value("selectionEnd")]
	public ulong SelectionEnd;
}

[Value("EditContext")]
public partial class EditContext : EventTarget
{
		public EditContext(EditContextInit options = default) { }
	[Value("updateText")]
	public Undefined UpdateText(ulong rangeStart, ulong rangeEnd, DOMString text) { throw new System.NotImplementedException(); }
	[Value("updateSelection")]
	public Undefined UpdateSelection(ulong start, ulong end) { throw new System.NotImplementedException(); }
	[Value("updateControlBounds")]
	public Undefined UpdateControlBounds(DOMRect controlBounds) { throw new System.NotImplementedException(); }
	[Value("updateSelectionBounds")]
	public Undefined UpdateSelectionBounds(DOMRect selectionBounds) { throw new System.NotImplementedException(); }
	[Value("updateCharacterBounds")]
	public Undefined UpdateCharacterBounds(ulong rangeStart, List<DOMRect> characterBounds) { throw new System.NotImplementedException(); }
	[Value("attachedElements")]
	public List<HTMLElement> AttachedElements() { throw new System.NotImplementedException(); }
	[Value("text")]
	public DOMString Text { get; }
	[Value("selectionStart")]
	public ulong SelectionStart { get; }
	[Value("selectionEnd")]
	public ulong SelectionEnd { get; }
	[Value("characterBoundsRangeStart")]
	public ulong CharacterBoundsRangeStart { get; }
	[Value("characterBounds")]
	public List<DOMRect> CharacterBounds() { throw new System.NotImplementedException(); }
	[Value("ontextupdate")]
	public EventHandler Ontextupdate { get; set; }
	[Value("ontextformatupdate")]
	public EventHandler Ontextformatupdate { get; set; }
	[Value("oncharacterboundsupdate")]
	public EventHandler Oncharacterboundsupdate { get; set; }
	[Value("oncompositionstart")]
	public EventHandler Oncompositionstart { get; set; }
	[Value("oncompositionend")]
	public EventHandler Oncompositionend { get; set; }
	public EditContext() { }
}

[Value("TextUpdateEventInit")]
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

[Value("TextUpdateEvent")]
public partial class TextUpdateEvent : Event
{
		public TextUpdateEvent(DOMString type, TextUpdateEventInit options = default) { }
	[Value("updateRangeStart")]
	public ulong UpdateRangeStart { get; }
	[Value("updateRangeEnd")]
	public ulong UpdateRangeEnd { get; }
	[Value("text")]
	public DOMString Text { get; }
	[Value("selectionStart")]
	public ulong SelectionStart { get; }
	[Value("selectionEnd")]
	public ulong SelectionEnd { get; }
	public TextUpdateEvent() { }
}

[Value("TextFormatInit")]
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

[Value("TextFormat")]
public partial class TextFormat
{
		public TextFormat(TextFormatInit options = default) { }
	[Value("rangeStart")]
	public ulong RangeStart { get; }
	[Value("rangeEnd")]
	public ulong RangeEnd { get; }
	[Value("underlineStyle")]
	public UnderlineStyle UnderlineStyle { get; }
	[Value("underlineThickness")]
	public UnderlineThickness UnderlineThickness { get; }
	public TextFormat() { }
}

[Value("TextFormatUpdateEventInit")]
public partial class TextFormatUpdateEventInit : EventInit
{
	[Value("textFormats")]
	public List<TextFormat> TextFormats;
}

[Value("TextFormatUpdateEvent")]
public partial class TextFormatUpdateEvent : Event
{
		public TextFormatUpdateEvent(DOMString type, TextFormatUpdateEventInit options = default) { }
	[Value("getTextFormats")]
	public List<TextFormat> GetTextFormats() { throw new System.NotImplementedException(); }
	public TextFormatUpdateEvent() { }
}

[Value("CharacterBoundsUpdateEventInit")]
public partial class CharacterBoundsUpdateEventInit : EventInit
{
	[Value("rangeStart")]
	public ulong RangeStart;
	[Value("rangeEnd")]
	public ulong RangeEnd;
}

[Value("CharacterBoundsUpdateEvent")]
public partial class CharacterBoundsUpdateEvent : Event
{
		public CharacterBoundsUpdateEvent(DOMString type, CharacterBoundsUpdateEventInit options = default) { }
	[Value("rangeStart")]
	public ulong RangeStart { get; }
	[Value("rangeEnd")]
	public ulong RangeEnd { get; }
	public CharacterBoundsUpdateEvent() { }
}

[Value("RestrictionTarget")]
public partial class RestrictionTarget
{
	[Value("fromElement")]
	public static Task<RestrictionTarget> FromElement(Element element) { throw new System.NotImplementedException(); }
}

[Value("BrowserCaptureMediaStreamTrack")]
public partial class BrowserCaptureMediaStreamTrack
{
	[Value("restrictTo")]
	public Task<Undefined> RestrictTo(RestrictionTarget? RestrictionTarget) { throw new System.NotImplementedException(); }
}

[Value("PerformanceElementTiming")]
public partial class PerformanceElementTiming : PerformanceEntry, PaintTimingMixin
{
	[Value("renderTime")]
	public DOMHighResTimeStamp RenderTime { get; }
	[Value("loadTime")]
	public DOMHighResTimeStamp LoadTime { get; }
	[Value("intersectionRect")]
	public DOMRectReadOnly IntersectionRect { get; }
	[Value("identifier")]
	public DOMString Identifier { get; }
	[Value("naturalWidth")]
	public ulong NaturalWidth { get; }
	[Value("naturalHeight")]
	public ulong NaturalHeight { get; }
	[Value("id")]
	public DOMString Id { get; }
	[Value("element")]
	public Element? Element { get; }
	[Value("url")]
	public DOMString Url { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}


public partial class Element
{
	[Value("elementTiming")]
	public DOMString ElementTiming { get; set; }
}

[Value("TextDecoderOptions")]
public partial class TextDecoderOptions
{
	[Value("fatal")]
	public bool Fatal;
	[Value("ignoreBOM")]
	public bool IgnoreBOM;
}

[Value("TextDecodeOptions")]
public partial class TextDecodeOptions
{
	[Value("stream")]
	public bool Stream;
}

[Value("TextDecoder")]
public partial class TextDecoder
{
		public TextDecoder(DOMString label = default, TextDecoderOptions options = default) { }
	[Value("decode")]
	public USVString Decode(AllowSharedBufferSource input = default, TextDecodeOptions options = default) { throw new System.NotImplementedException(); }
	public TextDecoder() { }
}


[Value("TextEncoderEncodeIntoResult")]
public partial class TextEncoderEncodeIntoResult
{
	[Value("read")]
	public ulong Read;
	[Value("written")]
	public ulong Written;
}

[Value("TextEncoder")]
public partial class TextEncoder
{
		public TextEncoder() { }
	[Value("encode")]
	public Uint8Array Encode(USVString input = default) { throw new System.NotImplementedException(); }
	[Value("encodeInto")]
	public TextEncoderEncodeIntoResult EncodeInto(USVString source, Uint8Array destination) { throw new System.NotImplementedException(); }
}


[Value("TextDecoderStream")]
public partial class TextDecoderStream
{
		public TextDecoderStream(DOMString label = default, TextDecoderOptions options = default) { }
	public TextDecoderStream() { }
}



[Value("TextEncoderStream")]
public partial class TextEncoderStream
{
		public TextEncoderStream() { }
}



public partial class Navigator
{
	[Value("requestMediaKeySystemAccess")]
	public Task<MediaKeySystemAccess> RequestMediaKeySystemAccess(DOMString keySystem, List<MediaKeySystemConfiguration> supportedConfigurations) { throw new System.NotImplementedException(); }
}

[Value("MediaKeySystemConfiguration")]
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

[Value("MediaKeySystemMediaCapability")]
public partial class MediaKeySystemMediaCapability
{
	[Value("contentType")]
	public DOMString ContentType;
	[Value("encryptionScheme")]
	public DOMString? EncryptionScheme;
	[Value("robustness")]
	public DOMString Robustness;
}

[Value("MediaKeySystemAccess")]
public partial class MediaKeySystemAccess
{
	[Value("keySystem")]
	public DOMString KeySystem { get; }
	[Value("getConfiguration")]
	public MediaKeySystemConfiguration GetConfiguration() { throw new System.NotImplementedException(); }
	[Value("createMediaKeys")]
	public Task<MediaKeys> CreateMediaKeys() { throw new System.NotImplementedException(); }
}

[Value("MediaKeys")]
public partial class MediaKeys
{
	[Value("createSession")]
	public MediaKeySession CreateSession(MediaKeySessionType sessionType = default) { throw new System.NotImplementedException(); }
	[Value("getStatusForPolicy")]
	public Task<MediaKeyStatus> GetStatusForPolicy(MediaKeysPolicy policy = default) { throw new System.NotImplementedException(); }
	[Value("setServerCertificate")]
	public Task<bool> SetServerCertificate(BufferSource serverCertificate) { throw new System.NotImplementedException(); }
}

[Value("MediaKeysPolicy")]
public partial class MediaKeysPolicy
{
	[Value("minHdcpVersion")]
	public DOMString MinHdcpVersion;
}

[Value("MediaKeySession")]
public partial class MediaKeySession : EventTarget
{
	[Value("sessionId")]
	public DOMString SessionId { get; }
	[Value("expiration")]
	public double Expiration { get; }
	[Value("closed")]
	public Task<MediaKeySessionClosedReason> Closed { get; }
	[Value("keyStatuses")]
	public MediaKeyStatusMap KeyStatuses { get; }
	[Value("onkeystatuseschange")]
	public EventHandler Onkeystatuseschange { get; set; }
	[Value("onmessage")]
	public EventHandler Onmessage { get; set; }
	[Value("generateRequest")]
	public Task<Undefined> GenerateRequest(DOMString initDataType, BufferSource initData) { throw new System.NotImplementedException(); }
	[Value("load")]
	public Task<bool> Load(DOMString sessionId) { throw new System.NotImplementedException(); }
	[Value("update")]
	public Task<Undefined> Update(BufferSource response) { throw new System.NotImplementedException(); }
	[Value("close")]
	public Task<Undefined> Close() { throw new System.NotImplementedException(); }
	[Value("remove")]
	public Task<Undefined> Remove() { throw new System.NotImplementedException(); }
}

[Value("MediaKeyStatusMap")]
public partial class MediaKeyStatusMap
{
	public BufferSource this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	[Value("size")]
	public ulong Size { get; }
	[Value("has")]
	public bool Has(BufferSource keyId) { throw new System.NotImplementedException(); }
	[Value("get")]
	public Union36 Get(BufferSource keyId) { throw new System.NotImplementedException(); }
}

[Value("MediaKeyMessageEvent")]
public partial class MediaKeyMessageEvent : Event
{
		public MediaKeyMessageEvent(DOMString type, MediaKeyMessageEventInit eventInitDict) { }
	[Value("messageType")]
	public MediaKeyMessageType MessageType { get; }
	[Value("message")]
	public ArrayBuffer Message { get; }
	public MediaKeyMessageEvent() { }
}

[Value("MediaKeyMessageEventInit")]
public partial class MediaKeyMessageEventInit : EventInit
{
	[Value("messageType")]
	public required MediaKeyMessageType MessageType;
	[Value("message")]
	public required ArrayBuffer Message;
}

public partial class HTMLMediaElement
{
	[Value("mediaKeys")]
	public MediaKeys? MediaKeys { get; }
	[Value("onencrypted")]
	public EventHandler Onencrypted { get; set; }
	[Value("onwaitingforkey")]
	public EventHandler Onwaitingforkey { get; set; }
	[Value("setMediaKeys")]
	public Task<Undefined> SetMediaKeys(MediaKeys? mediaKeys) { throw new System.NotImplementedException(); }
}

[Value("MediaEncryptedEvent")]
public partial class MediaEncryptedEvent : Event
{
		public MediaEncryptedEvent(DOMString type, MediaEncryptedEventInit eventInitDict = default) { }
	[Value("initDataType")]
	public DOMString InitDataType { get; }
	[Value("initData")]
	public ArrayBuffer? InitData { get; }
	public MediaEncryptedEvent() { }
}

[Value("MediaEncryptedEventInit")]
public partial class MediaEncryptedEventInit : EventInit
{
	[Value("initDataType")]
	public DOMString InitDataType;
	[Value("initData")]
	public ArrayBuffer? InitData;
}

[Value("File")]
public partial class File
{
	[Value("webkitRelativePath")]
	public USVString WebkitRelativePath { get; }
}

[Value("HTMLInputElement")]
public partial class HTMLInputElement
{
	[Value("webkitdirectory")]
	public bool Webkitdirectory { get; set; }
	[Value("webkitEntries")]
	public FileSystemEntry[] WebkitEntries { get; }
}

[Value("DataTransferItem")]
public partial class DataTransferItem
{
	[Value("webkitGetAsEntry")]
	public FileSystemEntry? WebkitGetAsEntry() { throw new System.NotImplementedException(); }
}

[Value("FileSystemEntry")]
public partial class FileSystemEntry
{
	[Value("isFile")]
	public bool IsFile { get; }
	[Value("isDirectory")]
	public bool IsDirectory { get; }
	[Value("name")]
	public USVString Name { get; }
	[Value("fullPath")]
	public USVString FullPath { get; }
	[Value("filesystem")]
	public FileSystem Filesystem { get; }
	[Value("getParent")]
	public Undefined GetParent(FileSystemEntryCallback successCallback = default, ErrorCallback errorCallback = default) { throw new System.NotImplementedException(); }
}

[Value("FileSystemDirectoryEntry")]
public partial class FileSystemDirectoryEntry : FileSystemEntry
{
	[Value("createReader")]
	public FileSystemDirectoryReader CreateReader() { throw new System.NotImplementedException(); }
	[Value("getFile")]
	public Undefined GetFile(USVString? path = default, FileSystemFlags options = default, FileSystemEntryCallback successCallback = default, ErrorCallback errorCallback = default) { throw new System.NotImplementedException(); }
	[Value("getDirectory")]
	public Undefined GetDirectory(USVString? path = default, FileSystemFlags options = default, FileSystemEntryCallback successCallback = default, ErrorCallback errorCallback = default) { throw new System.NotImplementedException(); }
}

[Value("FileSystemFlags")]
public partial class FileSystemFlags
{
	[Value("create")]
	public bool Create;
	[Value("exclusive")]
	public bool Exclusive;
}

[Value("FileSystemDirectoryReader")]
public partial class FileSystemDirectoryReader
{
	[Value("readEntries")]
	public Undefined ReadEntries(FileSystemEntriesCallback successCallback, ErrorCallback errorCallback = default) { throw new System.NotImplementedException(); }
}

[Value("FileSystemFileEntry")]
public partial class FileSystemFileEntry : FileSystemEntry
{
	[Value("file")]
	public Undefined File(FileCallback successCallback, ErrorCallback errorCallback = default) { throw new System.NotImplementedException(); }
}

[Value("FileSystem")]
public partial class FileSystem
{
	[Value("name")]
	public USVString Name { get; }
	[Value("root")]
	public FileSystemDirectoryEntry Root { get; }
}

[Value("PerformanceEventTiming")]
public partial class PerformanceEventTiming : PerformanceEntry
{
	[Value("processingStart")]
	public DOMHighResTimeStamp ProcessingStart { get; }
	[Value("processingEnd")]
	public DOMHighResTimeStamp ProcessingEnd { get; }
	[Value("cancelable")]
	public bool Cancelable { get; }
	[Value("target")]
	public Node? Target { get; }
	[Value("interactionId")]
	public ulong InteractionId { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

[Value("EventCounts")]
public partial class EventCounts
{
	
}

[Value("Performance")]
public partial class Performance
{
	[Value("eventCounts")]
	public EventCounts EventCounts { get; }
	[Value("interactionCount")]
	public ulong InteractionCount { get; }
}

[Value("PerformanceObserverInit")]
public partial class PerformanceObserverInit
{
	[Value("durationThreshold")]
	public DOMHighResTimeStamp DurationThreshold;
}

[Value("EXT_blend_minmax")]
public partial class EXT_blend_minmax
{
	[Value("MIN_EXT")]
	public const GLenum MIN_EXT = 0x8007;
	[Value("MAX_EXT")]
	public const GLenum MAX_EXT = 0x8008;
}

[Value("EXT_color_buffer_float")]
public partial class EXT_color_buffer_float
{
}

[Value("EXT_color_buffer_half_float")]
public partial class EXT_color_buffer_half_float
{
	[Value("RGBA16F_EXT")]
	public const GLenum RGBA16F_EXT = 0x881A;
	[Value("RGB16F_EXT")]
	public const GLenum RGB16F_EXT = 0x881B;
	[Value("FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT")]
	public const GLenum FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT = 0x8211;
	[Value("UNSIGNED_NORMALIZED_EXT")]
	public const GLenum UNSIGNED_NORMALIZED_EXT = 0x8C17;
}


[Value("WebGLTimerQueryEXT")]
public partial class WebGLTimerQueryEXT : WebGLObject
{
}

[Value("EXT_disjoint_timer_query")]
public partial class EXT_disjoint_timer_query
{
	[Value("QUERY_COUNTER_BITS_EXT")]
	public const GLenum QUERY_COUNTER_BITS_EXT = 0x8864;
	[Value("CURRENT_QUERY_EXT")]
	public const GLenum CURRENT_QUERY_EXT = 0x8865;
	[Value("QUERY_RESULT_EXT")]
	public const GLenum QUERY_RESULT_EXT = 0x8866;
	[Value("QUERY_RESULT_AVAILABLE_EXT")]
	public const GLenum QUERY_RESULT_AVAILABLE_EXT = 0x8867;
	[Value("TIME_ELAPSED_EXT")]
	public const GLenum TIME_ELAPSED_EXT = 0x88BF;
	[Value("TIMESTAMP_EXT")]
	public const GLenum TIMESTAMP_EXT = 0x8E28;
	[Value("GPU_DISJOINT_EXT")]
	public const GLenum GPU_DISJOINT_EXT = 0x8FBB;
	[Value("createQueryEXT")]
	public WebGLTimerQueryEXT CreateQueryEXT() { throw new System.NotImplementedException(); }
	[Value("deleteQueryEXT")]
	public Undefined DeleteQueryEXT(WebGLTimerQueryEXT? query) { throw new System.NotImplementedException(); }
	[Value("isQueryEXT")]
	public bool IsQueryEXT(WebGLTimerQueryEXT? query) { throw new System.NotImplementedException(); }
	[Value("beginQueryEXT")]
	public Undefined BeginQueryEXT(GLenum target, WebGLTimerQueryEXT query) { throw new System.NotImplementedException(); }
	[Value("endQueryEXT")]
	public Undefined EndQueryEXT(GLenum target) { throw new System.NotImplementedException(); }
	[Value("queryCounterEXT")]
	public Undefined QueryCounterEXT(WebGLTimerQueryEXT query, GLenum target) { throw new System.NotImplementedException(); }
	[Value("getQueryEXT")]
	public dynamic GetQueryEXT(GLenum target, GLenum pname) { throw new System.NotImplementedException(); }
	[Value("getQueryObjectEXT")]
	public dynamic GetQueryObjectEXT(WebGLTimerQueryEXT query, GLenum pname) { throw new System.NotImplementedException(); }
}

[Value("EXT_disjoint_timer_query_webgl2")]
public partial class EXT_disjoint_timer_query_webgl2
{
	[Value("QUERY_COUNTER_BITS_EXT")]
	public const GLenum QUERY_COUNTER_BITS_EXT = 0x8864;
	[Value("TIME_ELAPSED_EXT")]
	public const GLenum TIME_ELAPSED_EXT = 0x88BF;
	[Value("TIMESTAMP_EXT")]
	public const GLenum TIMESTAMP_EXT = 0x8E28;
	[Value("GPU_DISJOINT_EXT")]
	public const GLenum GPU_DISJOINT_EXT = 0x8FBB;
	[Value("queryCounterEXT")]
	public Undefined QueryCounterEXT(WebGLQuery query, GLenum target) { throw new System.NotImplementedException(); }
}

[Value("EXT_float_blend")]
public partial class EXT_float_blend
{
}

[Value("EXT_frag_depth")]
public partial class EXT_frag_depth
{
}

[Value("EXT_shader_texture_lod")]
public partial class EXT_shader_texture_lod
{
}

[Value("EXT_sRGB")]
public partial class EXT_sRGB
{
	[Value("SRGB_EXT")]
	public const GLenum SRGB_EXT = 0x8C40;
	[Value("SRGB_ALPHA_EXT")]
	public const GLenum SRGB_ALPHA_EXT = 0x8C42;
	[Value("SRGB8_ALPHA8_EXT")]
	public const GLenum SRGB8_ALPHA8_EXT = 0x8C43;
	[Value("FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT")]
	public const GLenum FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT = 0x8210;
}

[Value("EXT_texture_compression_bptc")]
public partial class EXT_texture_compression_bptc
{
	[Value("COMPRESSED_RGBA_BPTC_UNORM_EXT")]
	public const GLenum COMPRESSED_RGBA_BPTC_UNORM_EXT = 0x8E8C;
	[Value("COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT")]
	public const GLenum COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT = 0x8E8D;
	[Value("COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT")]
	public const GLenum COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT = 0x8E8E;
	[Value("COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT")]
	public const GLenum COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT = 0x8E8F;
}

[Value("EXT_texture_compression_rgtc")]
public partial class EXT_texture_compression_rgtc
{
	[Value("COMPRESSED_RED_RGTC1_EXT")]
	public const GLenum COMPRESSED_RED_RGTC1_EXT = 0x8DBB;
	[Value("COMPRESSED_SIGNED_RED_RGTC1_EXT")]
	public const GLenum COMPRESSED_SIGNED_RED_RGTC1_EXT = 0x8DBC;
	[Value("COMPRESSED_RED_GREEN_RGTC2_EXT")]
	public const GLenum COMPRESSED_RED_GREEN_RGTC2_EXT = 0x8DBD;
	[Value("COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT")]
	public const GLenum COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT = 0x8DBE;
}

[Value("EXT_texture_filter_anisotropic")]
public partial class EXT_texture_filter_anisotropic
{
	[Value("TEXTURE_MAX_ANISOTROPY_EXT")]
	public const GLenum TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE;
	[Value("MAX_TEXTURE_MAX_ANISOTROPY_EXT")]
	public const GLenum MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF;
}

[Value("EXT_texture_norm16")]
public partial class EXT_texture_norm16
{
	[Value("R16_EXT")]
	public const GLenum R16_EXT = 0x822A;
	[Value("RG16_EXT")]
	public const GLenum RG16_EXT = 0x822C;
	[Value("RGB16_EXT")]
	public const GLenum RGB16_EXT = 0x8054;
	[Value("RGBA16_EXT")]
	public const GLenum RGBA16_EXT = 0x805B;
	[Value("R16_SNORM_EXT")]
	public const GLenum R16_SNORM_EXT = 0x8F98;
	[Value("RG16_SNORM_EXT")]
	public const GLenum RG16_SNORM_EXT = 0x8F99;
	[Value("RGB16_SNORM_EXT")]
	public const GLenum RGB16_SNORM_EXT = 0x8F9A;
	[Value("RGBA16_SNORM_EXT")]
	public const GLenum RGBA16_SNORM_EXT = 0x8F9B;
}

[Value("ColorSelectionResult")]
public partial class ColorSelectionResult
{
	[Value("sRGBHex")]
	public DOMString SRGBHex;
}

[Value("ColorSelectionOptions")]
public partial class ColorSelectionOptions
{
	[Value("signal")]
	public AbortSignal Signal;
}

[Value("EyeDropper")]
public partial class EyeDropper
{
		public EyeDropper() { }
	[Value("open")]
	public Task<ColorSelectionResult> Open(ColorSelectionOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("IdentityCredentialDisconnectOptions")]
public partial class IdentityCredentialDisconnectOptions : IdentityProviderConfig
{
	[Value("accountHint")]
	public required USVString AccountHint;
}

[Value("IdentityCredential")]
public partial class IdentityCredential : Credential
{
	[Value("disconnect")]
	public static Task<Undefined> Disconnect(IdentityCredentialDisconnectOptions options = default) { throw new System.NotImplementedException(); }
	[Value("token")]
	public USVString? Token { get; }
	[Value("isAutoSelected")]
	public bool IsAutoSelected { get; }
}

[Value("DisconnectedAccount")]
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

[Value("IdentityCredentialRequestOptions")]
public partial class IdentityCredentialRequestOptions
{
	[Value("providers")]
	public required List<IdentityProviderRequestOptions> Providers;
	[Value("context")]
	public IdentityCredentialRequestOptionsContext Context;
	[Value("mode")]
	public IdentityCredentialRequestOptionsMode Mode;
}

[Value("IdentityProviderConfig")]
public partial class IdentityProviderConfig
{
	[Value("configURL")]
	public required USVString ConfigURL;
	[Value("clientId")]
	public required USVString ClientId;
}

[Value("IdentityProviderRequestOptions")]
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

[Value("IdentityProviderWellKnown")]
public partial class IdentityProviderWellKnown
{
	[Value("provider_urls")]
	public List<USVString> Provider_urls;
	[Value("accounts_endpoint")]
	public USVString Accounts_endpoint;
	[Value("login_url")]
	public USVString Login_url;
}

[Value("IdentityProviderIcon")]
public partial class IdentityProviderIcon
{
	[Value("url")]
	public required USVString Url;
	[Value("size")]
	public ulong Size;
}

[Value("IdentityProviderBranding")]
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

[Value("IdentityProviderAPIConfig")]
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

[Value("IdentityProviderAccount")]
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

[Value("IdentityProviderAccountList")]
public partial class IdentityProviderAccountList
{
	[Value("accounts")]
	public List<IdentityProviderAccount> Accounts;
}

[Value("IdentityAssertionResponse")]
public partial class IdentityAssertionResponse
{
	[Value("token")]
	public USVString Token;
	[Value("continue_on")]
	public USVString Continue_on;
}

[Value("IdentityProviderClientMetadata")]
public partial class IdentityProviderClientMetadata
{
	[Value("privacy_policy_url")]
	public USVString Privacy_policy_url;
	[Value("terms_of_service_url")]
	public USVString Terms_of_service_url;
}

[Value("IdentityUserInfo")]
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

[Value("IdentityResolveOptions")]
public partial class IdentityResolveOptions
{
	[Value("accountId")]
	public USVString AccountId;
}

[Value("IdentityProvider")]
public partial class IdentityProvider
{
	[Value("close")]
	public static Undefined Close() { throw new System.NotImplementedException(); }
	[Value("resolve")]
	public static Undefined Resolve(DOMString token, IdentityResolveOptions options = default) { throw new System.NotImplementedException(); }
	[Value("getUserInfo")]
	public static Task<List<IdentityUserInfo>> GetUserInfo(IdentityProviderConfig config) { throw new System.NotImplementedException(); }
}

[Value("HTMLFencedFrameElement")]
public partial class HTMLFencedFrameElement : HTMLElement
{
		public HTMLFencedFrameElement() { }
	[Value("config")]
	public FencedFrameConfig? Config { get; set; }
	[Value("width")]
	public DOMString Width { get; set; }
	[Value("height")]
	public DOMString Height { get; set; }
	[Value("sandbox")]
	public DOMTokenList Sandbox { get; }
	[Value("allow")]
	public DOMString Allow { get; set; }
}

[Value("FencedFrameConfig")]
public partial class FencedFrameConfig
{
		public FencedFrameConfig(USVString url) { }
	[Value("setSharedStorageContext")]
	public Undefined SetSharedStorageContext(DOMString contextString) { throw new System.NotImplementedException(); }
	public FencedFrameConfig() { }
}


public partial class Navigator
{
	[Value("deprecatedReplaceInURN")]
	public Task<Undefined> DeprecatedReplaceInURN(UrnOrConfig urnOrConfig, Dictionary<USVString, USVString> replacements) { throw new System.NotImplementedException(); }
	[Value("deprecatedURNtoURL")]
	public Task<USVString> DeprecatedURNtoURL(UrnOrConfig urnOrConfig, bool send_reports = default) { throw new System.NotImplementedException(); }
	[Value("adAuctionComponents")]
	public List<USVString> AdAuctionComponents(ushort numAdComponents) { throw new System.NotImplementedException(); }
}

[Value("FenceEvent")]
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


[Value("Fence")]
public partial class Fence
{
	[Value("reportEvent")]
	public Undefined ReportEvent(ReportEventType event_ = default) { throw new System.NotImplementedException(); }
	[Value("setReportEventDataForAutomaticBeacons")]
	public Undefined SetReportEventDataForAutomaticBeacons(FenceEvent event_ = default) { throw new System.NotImplementedException(); }
	[Value("getNestedConfigs")]
	public List<FencedFrameConfig> GetNestedConfigs() { throw new System.NotImplementedException(); }
	[Value("disableUntrustedNetwork")]
	public Task<Undefined> DisableUntrustedNetwork() { throw new System.NotImplementedException(); }
	[Value("notifyEvent")]
	public Undefined NotifyEvent(Event event_) { throw new System.NotImplementedException(); }
}

public partial class Window
{
	[Value("fence")]
	public Fence? Fence { get; }
}

[Value("Headers")]
public partial class Headers
{
		public Headers(HeadersInit init = default) { }
	[Value("append")]
	public Undefined Append(ByteString name, ByteString value) { throw new System.NotImplementedException(); }
	[Value("delete")]
	public Undefined Delete(ByteString name) { throw new System.NotImplementedException(); }
	[Value("get")]
	public ByteString? Get(ByteString name) { throw new System.NotImplementedException(); }
	[Value("getSetCookie")]
	public List<ByteString> GetSetCookie() { throw new System.NotImplementedException(); }
	[Value("has")]
	public bool Has(ByteString name) { throw new System.NotImplementedException(); }
	[Value("set")]
	public Undefined Set(ByteString name, ByteString value) { throw new System.NotImplementedException(); }
	public ByteString this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	public Headers() { }
}



[Value("Request")]
public partial class Request
{
		public Request(RequestInfo input, RequestInit init = default) { }
	[Value("method")]
	public ByteString Method { get; }
	[Value("url")]
	public USVString Url { get; }
	[Value("headers")]
	public Headers Headers { get; }
	[Value("destination")]
	public RequestDestination Destination { get; }
	[Value("referrer")]
	public USVString Referrer { get; }
	[Value("referrerPolicy")]
	public ReferrerPolicy ReferrerPolicy { get; }
	[Value("mode")]
	public RequestMode Mode { get; }
	[Value("credentials")]
	public RequestCredentials Credentials { get; }
	[Value("cache")]
	public RequestCache Cache { get; }
	[Value("redirect")]
	public RequestRedirect Redirect { get; }
	[Value("integrity")]
	public DOMString Integrity { get; }
	[Value("keepalive")]
	public bool Keepalive { get; }
	[Value("isReloadNavigation")]
	public bool IsReloadNavigation { get; }
	[Value("isHistoryNavigation")]
	public bool IsHistoryNavigation { get; }
	[Value("signal")]
	public AbortSignal Signal { get; }
	[Value("duplex")]
	public RequestDuplex Duplex { get; }
	[Value("clone")]
	public Request Clone() { throw new System.NotImplementedException(); }
	public Request() { }
}


public partial class RequestInit
{
	[Value("method")]
	public ByteString Method;
	[Value("headers")]
	public HeadersInit Headers;
	[Value("body")]
	public BodyInit? Body;
	[Value("referrer")]
	public USVString Referrer;
	[Value("referrerPolicy")]
	public ReferrerPolicy ReferrerPolicy;
	[Value("mode")]
	public RequestMode Mode;
	[Value("credentials")]
	public RequestCredentials Credentials;
	[Value("cache")]
	public RequestCache Cache;
	[Value("redirect")]
	public RequestRedirect Redirect;
	[Value("integrity")]
	public DOMString Integrity;
	[Value("keepalive")]
	public bool Keepalive;
	[Value("signal")]
	public AbortSignal? Signal;
	[Value("duplex")]
	public RequestDuplex Duplex;
	[Value("priority")]
	public RequestPriority Priority;
	[Value("window")]
	public dynamic Window;
}

[Value("Response")]
public partial class Response
{
		public Response(BodyInit? body = default, ResponseInit init = default) { }
	[Value("error")]
	public static Response Error() { throw new System.NotImplementedException(); }
	[Value("redirect")]
	public static Response Redirect(USVString url, ushort status = default) { throw new System.NotImplementedException(); }
	[Value("json")]
	public static Response Json(dynamic data, ResponseInit init = default) { throw new System.NotImplementedException(); }
	[Value("type")]
	public ResponseType Type { get; }
	[Value("url")]
	public USVString Url { get; }
	[Value("redirected")]
	public bool Redirected { get; }
	[Value("status")]
	public ushort Status { get; }
	[Value("ok")]
	public bool Ok { get; }
	[Value("statusText")]
	public ByteString StatusText { get; }
	[Value("headers")]
	public Headers Headers { get; }
	[Value("clone")]
	public Response Clone() { throw new System.NotImplementedException(); }
	public Response() { }
}


[Value("ResponseInit")]
public partial class ResponseInit
{
	[Value("status")]
	public ushort Status;
	[Value("statusText")]
	public ByteString StatusText;
	[Value("headers")]
	public HeadersInit Headers;
}

[Value("AuthenticationExtensionsClientInputs")]
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

[Value("HMACGetSecretInput")]
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

[Value("AuthenticationExtensionsClientOutputs")]
public partial class AuthenticationExtensionsClientOutputs
{
	[Value("hmacCreateSecret")]
	public bool HmacCreateSecret;
}

[Value("HMACGetSecretOutput")]
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

[Value("FileSystemPermissionDescriptor")]
public partial class FileSystemPermissionDescriptor : PermissionDescriptor
{
	[Value("handle")]
	public required FileSystemHandle Handle;
	[Value("mode")]
	public FileSystemPermissionMode Mode;
}

[Value("FileSystemHandlePermissionDescriptor")]
public partial class FileSystemHandlePermissionDescriptor
{
	[Value("mode")]
	public FileSystemPermissionMode Mode;
}

[Value("FileSystemHandle")]
public partial class FileSystemHandle
{
	[Value("queryPermission")]
	public Task<PermissionState> QueryPermission(FileSystemHandlePermissionDescriptor descriptor = default) { throw new System.NotImplementedException(); }
	[Value("requestPermission")]
	public Task<PermissionState> RequestPermission(FileSystemHandlePermissionDescriptor descriptor = default) { throw new System.NotImplementedException(); }
}

[Value("FilePickerAcceptType")]
public partial class FilePickerAcceptType
{
	[Value("description")]
	public USVString Description;
	[Value("accept")]
	public Dictionary<USVString, USVString> Accept;
}

[Value("FilePickerOptions")]
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

[Value("OpenFilePickerOptions")]
public partial class OpenFilePickerOptions : FilePickerOptions
{
	[Value("multiple")]
	public bool Multiple;
}

[Value("SaveFilePickerOptions")]
public partial class SaveFilePickerOptions : FilePickerOptions
{
	[Value("suggestedName")]
	public USVString? SuggestedName;
}

[Value("DirectoryPickerOptions")]
public partial class DirectoryPickerOptions
{
	[Value("id")]
	public DOMString Id;
	[Value("startIn")]
	public StartInDirectory StartIn;
	[Value("mode")]
	public FileSystemPermissionMode Mode;
}

public partial class Window
{
	[Value("showOpenFilePicker")]
	public Task<List<FileSystemFileHandle>> ShowOpenFilePicker(OpenFilePickerOptions options = default) { throw new System.NotImplementedException(); }
	[Value("showSaveFilePicker")]
	public Task<FileSystemFileHandle> ShowSaveFilePicker(SaveFilePickerOptions options = default) { throw new System.NotImplementedException(); }
	[Value("showDirectoryPicker")]
	public Task<FileSystemDirectoryHandle> ShowDirectoryPicker(DirectoryPickerOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class DataTransferItem
{
	[Value("getAsFileSystemHandle")]
	public Task<FileSystemHandle?> GetAsFileSystemHandle() { throw new System.NotImplementedException(); }
}

[Value("Blob")]
public partial class Blob
{
		public Blob(List<BlobPart> blobParts = default, BlobPropertyBag options = default) { }
	[Value("size")]
	public ulong Size { get; }
	[Value("type")]
	public DOMString Type { get; }
	[Value("slice")]
	public Blob Slice(long start = default, long end = default, DOMString contentType = default) { throw new System.NotImplementedException(); }
	[Value("stream")]
	public ReadableStream Stream() { throw new System.NotImplementedException(); }
	[Value("text")]
	public Task<USVString> Text() { throw new System.NotImplementedException(); }
	[Value("arrayBuffer")]
	public Task<ArrayBuffer> ArrayBuffer() { throw new System.NotImplementedException(); }
	[Value("bytes")]
	public Task<Uint8Array> Bytes() { throw new System.NotImplementedException(); }
	public Blob() { }
}

[Value("BlobPropertyBag")]
public partial class BlobPropertyBag
{
	[Value("type")]
	public DOMString Type;
	[Value("endings")]
	public EndingType Endings;
}


public partial class File : Blob
{
		public File(List<BlobPart> fileBits, USVString fileName, FilePropertyBag options = default) { }
	[Value("name")]
	public DOMString Name { get; }
	[Value("lastModified")]
	public long LastModified { get; }
	public File() { }
}

[Value("FilePropertyBag")]
public partial class FilePropertyBag : BlobPropertyBag
{
	[Value("lastModified")]
	public long LastModified;
}

[Value("FileList")]
public partial class FileList
{
	
	[Value("length")]
	public ulong Length { get; }
}

[Value("FileReader")]
public partial class FileReader : EventTarget
{
		public FileReader() { }
	[Value("readAsArrayBuffer")]
	public Undefined ReadAsArrayBuffer(Blob blob) { throw new System.NotImplementedException(); }
	[Value("readAsBinaryString")]
	public Undefined ReadAsBinaryString(Blob blob) { throw new System.NotImplementedException(); }
	[Value("readAsText")]
	public Undefined ReadAsText(Blob blob, DOMString encoding = default) { throw new System.NotImplementedException(); }
	[Value("readAsDataURL")]
	public Undefined ReadAsDataURL(Blob blob) { throw new System.NotImplementedException(); }
	[Value("abort")]
	public Undefined Abort() { throw new System.NotImplementedException(); }
	[Value("EMPTY")]
	public const ushort EMPTY = 0;
	[Value("LOADING")]
	public const ushort LOADING = 1;
	[Value("DONE")]
	public const ushort DONE = 2;
	[Value("readyState")]
	public ushort ReadyState { get; }
	[Value("result")]
	public Union45? Result { get; }
	[Value("error")]
	public DOMException? Error { get; }
	[Value("onloadstart")]
	public EventHandler Onloadstart { get; set; }
	[Value("onprogress")]
	public EventHandler Onprogress { get; set; }
	[Value("onload")]
	public EventHandler Onload { get; set; }
	[Value("onabort")]
	public EventHandler Onabort { get; set; }
	[Value("onerror")]
	public EventHandler Onerror { get; set; }
	[Value("onloadend")]
	public EventHandler Onloadend { get; set; }
}

[Value("FileReaderSync")]
public partial class FileReaderSync
{
		public FileReaderSync() { }
	[Value("readAsArrayBuffer")]
	public ArrayBuffer ReadAsArrayBuffer(Blob blob) { throw new System.NotImplementedException(); }
	[Value("readAsBinaryString")]
	public DOMString ReadAsBinaryString(Blob blob) { throw new System.NotImplementedException(); }
	[Value("readAsText")]
	public DOMString ReadAsText(Blob blob, DOMString encoding = default) { throw new System.NotImplementedException(); }
	[Value("readAsDataURL")]
	public DOMString ReadAsDataURL(Blob blob) { throw new System.NotImplementedException(); }
}

[Value("URL")]
public partial class URL
{
	[Value("createObjectURL")]
	public static DOMString CreateObjectURL(Union46 obj) { throw new System.NotImplementedException(); }
	[Value("revokeObjectURL")]
	public static Undefined RevokeObjectURL(DOMString url) { throw new System.NotImplementedException(); }
}

[Value("SVGFilterElement")]
public partial class SVGFilterElement : SVGElement, SVGURIReference
{
	[Value("filterUnits")]
	public SVGAnimatedEnumeration FilterUnits { get; }
	[Value("primitiveUnits")]
	public SVGAnimatedEnumeration PrimitiveUnits { get; }
	[Value("x")]
	public SVGAnimatedLength X { get; }
	[Value("y")]
	public SVGAnimatedLength Y { get; }
	[Value("width")]
	public SVGAnimatedLength Width { get; }
	[Value("height")]
	public SVGAnimatedLength Height { get; }
}


[Value("SVGFEBlendElement")]
public partial class SVGFEBlendElement : SVGElement, SVGFilterPrimitiveStandardAttributes
{
	[Value("SVG_FEBLEND_MODE_UNKNOWN")]
	public const ushort SVG_FEBLEND_MODE_UNKNOWN = 0;
	[Value("SVG_FEBLEND_MODE_NORMAL")]
	public const ushort SVG_FEBLEND_MODE_NORMAL = 1;
	[Value("SVG_FEBLEND_MODE_MULTIPLY")]
	public const ushort SVG_FEBLEND_MODE_MULTIPLY = 2;
	[Value("SVG_FEBLEND_MODE_SCREEN")]
	public const ushort SVG_FEBLEND_MODE_SCREEN = 3;
	[Value("SVG_FEBLEND_MODE_DARKEN")]
	public const ushort SVG_FEBLEND_MODE_DARKEN = 4;
	[Value("SVG_FEBLEND_MODE_LIGHTEN")]
	public const ushort SVG_FEBLEND_MODE_LIGHTEN = 5;
	[Value("SVG_FEBLEND_MODE_OVERLAY")]
	public const ushort SVG_FEBLEND_MODE_OVERLAY = 6;
	[Value("SVG_FEBLEND_MODE_COLOR_DODGE")]
	public const ushort SVG_FEBLEND_MODE_COLOR_DODGE = 7;
	[Value("SVG_FEBLEND_MODE_COLOR_BURN")]
	public const ushort SVG_FEBLEND_MODE_COLOR_BURN = 8;
	[Value("SVG_FEBLEND_MODE_HARD_LIGHT")]
	public const ushort SVG_FEBLEND_MODE_HARD_LIGHT = 9;
	[Value("SVG_FEBLEND_MODE_SOFT_LIGHT")]
	public const ushort SVG_FEBLEND_MODE_SOFT_LIGHT = 10;
	[Value("SVG_FEBLEND_MODE_DIFFERENCE")]
	public const ushort SVG_FEBLEND_MODE_DIFFERENCE = 11;
	[Value("SVG_FEBLEND_MODE_EXCLUSION")]
	public const ushort SVG_FEBLEND_MODE_EXCLUSION = 12;
	[Value("SVG_FEBLEND_MODE_HUE")]
	public const ushort SVG_FEBLEND_MODE_HUE = 13;
	[Value("SVG_FEBLEND_MODE_SATURATION")]
	public const ushort SVG_FEBLEND_MODE_SATURATION = 14;
	[Value("SVG_FEBLEND_MODE_COLOR")]
	public const ushort SVG_FEBLEND_MODE_COLOR = 15;
	[Value("SVG_FEBLEND_MODE_LUMINOSITY")]
	public const ushort SVG_FEBLEND_MODE_LUMINOSITY = 16;
	[Value("in1")]
	public SVGAnimatedString In1 { get; }
	[Value("in2")]
	public SVGAnimatedString In2 { get; }
	[Value("mode")]
	public SVGAnimatedEnumeration Mode { get; }
}


[Value("SVGFEColorMatrixElement")]
public partial class SVGFEColorMatrixElement : SVGElement, SVGFilterPrimitiveStandardAttributes
{
	[Value("SVG_FECOLORMATRIX_TYPE_UNKNOWN")]
	public const ushort SVG_FECOLORMATRIX_TYPE_UNKNOWN = 0;
	[Value("SVG_FECOLORMATRIX_TYPE_MATRIX")]
	public const ushort SVG_FECOLORMATRIX_TYPE_MATRIX = 1;
	[Value("SVG_FECOLORMATRIX_TYPE_SATURATE")]
	public const ushort SVG_FECOLORMATRIX_TYPE_SATURATE = 2;
	[Value("SVG_FECOLORMATRIX_TYPE_HUEROTATE")]
	public const ushort SVG_FECOLORMATRIX_TYPE_HUEROTATE = 3;
	[Value("SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA")]
	public const ushort SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA = 4;
	[Value("in1")]
	public SVGAnimatedString In1 { get; }
	[Value("type")]
	public SVGAnimatedEnumeration Type { get; }
	[Value("values")]
	public SVGAnimatedNumberList Values { get; }
}


[Value("SVGFEComponentTransferElement")]
public partial class SVGFEComponentTransferElement : SVGElement, SVGFilterPrimitiveStandardAttributes
{
	[Value("in1")]
	public SVGAnimatedString In1 { get; }
}


[Value("SVGComponentTransferFunctionElement")]
public partial class SVGComponentTransferFunctionElement : SVGElement
{
	[Value("SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN")]
	public const ushort SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN = 0;
	[Value("SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY")]
	public const ushort SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY = 1;
	[Value("SVG_FECOMPONENTTRANSFER_TYPE_TABLE")]
	public const ushort SVG_FECOMPONENTTRANSFER_TYPE_TABLE = 2;
	[Value("SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE")]
	public const ushort SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE = 3;
	[Value("SVG_FECOMPONENTTRANSFER_TYPE_LINEAR")]
	public const ushort SVG_FECOMPONENTTRANSFER_TYPE_LINEAR = 4;
	[Value("SVG_FECOMPONENTTRANSFER_TYPE_GAMMA")]
	public const ushort SVG_FECOMPONENTTRANSFER_TYPE_GAMMA = 5;
	[Value("type")]
	public SVGAnimatedEnumeration Type { get; }
	[Value("tableValues")]
	public SVGAnimatedNumberList TableValues { get; }
	[Value("slope")]
	public SVGAnimatedNumber Slope { get; }
	[Value("intercept")]
	public SVGAnimatedNumber Intercept { get; }
	[Value("amplitude")]
	public SVGAnimatedNumber Amplitude { get; }
	[Value("exponent")]
	public SVGAnimatedNumber Exponent { get; }
	[Value("offset")]
	public SVGAnimatedNumber Offset { get; }
}

[Value("SVGFEFuncRElement")]
public partial class SVGFEFuncRElement : SVGComponentTransferFunctionElement
{
}

[Value("SVGFEFuncGElement")]
public partial class SVGFEFuncGElement : SVGComponentTransferFunctionElement
{
}

[Value("SVGFEFuncBElement")]
public partial class SVGFEFuncBElement : SVGComponentTransferFunctionElement
{
}

[Value("SVGFEFuncAElement")]
public partial class SVGFEFuncAElement : SVGComponentTransferFunctionElement
{
}

[Value("SVGFECompositeElement")]
public partial class SVGFECompositeElement : SVGElement, SVGFilterPrimitiveStandardAttributes
{
	[Value("SVG_FECOMPOSITE_OPERATOR_UNKNOWN")]
	public const ushort SVG_FECOMPOSITE_OPERATOR_UNKNOWN = 0;
	[Value("SVG_FECOMPOSITE_OPERATOR_OVER")]
	public const ushort SVG_FECOMPOSITE_OPERATOR_OVER = 1;
	[Value("SVG_FECOMPOSITE_OPERATOR_IN")]
	public const ushort SVG_FECOMPOSITE_OPERATOR_IN = 2;
	[Value("SVG_FECOMPOSITE_OPERATOR_OUT")]
	public const ushort SVG_FECOMPOSITE_OPERATOR_OUT = 3;
	[Value("SVG_FECOMPOSITE_OPERATOR_ATOP")]
	public const ushort SVG_FECOMPOSITE_OPERATOR_ATOP = 4;
	[Value("SVG_FECOMPOSITE_OPERATOR_XOR")]
	public const ushort SVG_FECOMPOSITE_OPERATOR_XOR = 5;
	[Value("SVG_FECOMPOSITE_OPERATOR_ARITHMETIC")]
	public const ushort SVG_FECOMPOSITE_OPERATOR_ARITHMETIC = 6;
	[Value("in1")]
	public SVGAnimatedString In1 { get; }
	[Value("in2")]
	public SVGAnimatedString In2 { get; }
	[Value("operator")]
	public SVGAnimatedEnumeration Operator { get; }
	[Value("k1")]
	public SVGAnimatedNumber K1 { get; }
	[Value("k2")]
	public SVGAnimatedNumber K2 { get; }
	[Value("k3")]
	public SVGAnimatedNumber K3 { get; }
	[Value("k4")]
	public SVGAnimatedNumber K4 { get; }
}


[Value("SVGFEConvolveMatrixElement")]
public partial class SVGFEConvolveMatrixElement : SVGElement, SVGFilterPrimitiveStandardAttributes
{
	[Value("SVG_EDGEMODE_UNKNOWN")]
	public const ushort SVG_EDGEMODE_UNKNOWN = 0;
	[Value("SVG_EDGEMODE_DUPLICATE")]
	public const ushort SVG_EDGEMODE_DUPLICATE = 1;
	[Value("SVG_EDGEMODE_WRAP")]
	public const ushort SVG_EDGEMODE_WRAP = 2;
	[Value("SVG_EDGEMODE_NONE")]
	public const ushort SVG_EDGEMODE_NONE = 3;
	[Value("in1")]
	public SVGAnimatedString In1 { get; }
	[Value("orderX")]
	public SVGAnimatedInteger OrderX { get; }
	[Value("orderY")]
	public SVGAnimatedInteger OrderY { get; }
	[Value("kernelMatrix")]
	public SVGAnimatedNumberList KernelMatrix { get; }
	[Value("divisor")]
	public SVGAnimatedNumber Divisor { get; }
	[Value("bias")]
	public SVGAnimatedNumber Bias { get; }
	[Value("targetX")]
	public SVGAnimatedInteger TargetX { get; }
	[Value("targetY")]
	public SVGAnimatedInteger TargetY { get; }
	[Value("edgeMode")]
	public SVGAnimatedEnumeration EdgeMode { get; }
	[Value("kernelUnitLengthX")]
	public SVGAnimatedNumber KernelUnitLengthX { get; }
	[Value("kernelUnitLengthY")]
	public SVGAnimatedNumber KernelUnitLengthY { get; }
	[Value("preserveAlpha")]
	public SVGAnimatedBoolean PreserveAlpha { get; }
}


[Value("SVGFEDiffuseLightingElement")]
public partial class SVGFEDiffuseLightingElement : SVGElement, SVGFilterPrimitiveStandardAttributes
{
	[Value("in1")]
	public SVGAnimatedString In1 { get; }
	[Value("surfaceScale")]
	public SVGAnimatedNumber SurfaceScale { get; }
	[Value("diffuseConstant")]
	public SVGAnimatedNumber DiffuseConstant { get; }
	[Value("kernelUnitLengthX")]
	public SVGAnimatedNumber KernelUnitLengthX { get; }
	[Value("kernelUnitLengthY")]
	public SVGAnimatedNumber KernelUnitLengthY { get; }
}


[Value("SVGFEDistantLightElement")]
public partial class SVGFEDistantLightElement : SVGElement
{
	[Value("azimuth")]
	public SVGAnimatedNumber Azimuth { get; }
	[Value("elevation")]
	public SVGAnimatedNumber Elevation { get; }
}

[Value("SVGFEPointLightElement")]
public partial class SVGFEPointLightElement : SVGElement
{
	[Value("x")]
	public SVGAnimatedNumber X { get; }
	[Value("y")]
	public SVGAnimatedNumber Y { get; }
	[Value("z")]
	public SVGAnimatedNumber Z { get; }
}

[Value("SVGFESpotLightElement")]
public partial class SVGFESpotLightElement : SVGElement
{
	[Value("x")]
	public SVGAnimatedNumber X { get; }
	[Value("y")]
	public SVGAnimatedNumber Y { get; }
	[Value("z")]
	public SVGAnimatedNumber Z { get; }
	[Value("pointsAtX")]
	public SVGAnimatedNumber PointsAtX { get; }
	[Value("pointsAtY")]
	public SVGAnimatedNumber PointsAtY { get; }
	[Value("pointsAtZ")]
	public SVGAnimatedNumber PointsAtZ { get; }
	[Value("specularExponent")]
	public SVGAnimatedNumber SpecularExponent { get; }
	[Value("limitingConeAngle")]
	public SVGAnimatedNumber LimitingConeAngle { get; }
}

[Value("SVGFEDisplacementMapElement")]
public partial class SVGFEDisplacementMapElement : SVGElement, SVGFilterPrimitiveStandardAttributes
{
	[Value("SVG_CHANNEL_UNKNOWN")]
	public const ushort SVG_CHANNEL_UNKNOWN = 0;
	[Value("SVG_CHANNEL_R")]
	public const ushort SVG_CHANNEL_R = 1;
	[Value("SVG_CHANNEL_G")]
	public const ushort SVG_CHANNEL_G = 2;
	[Value("SVG_CHANNEL_B")]
	public const ushort SVG_CHANNEL_B = 3;
	[Value("SVG_CHANNEL_A")]
	public const ushort SVG_CHANNEL_A = 4;
	[Value("in1")]
	public SVGAnimatedString In1 { get; }
	[Value("in2")]
	public SVGAnimatedString In2 { get; }
	[Value("scale")]
	public SVGAnimatedNumber Scale { get; }
	[Value("xChannelSelector")]
	public SVGAnimatedEnumeration XChannelSelector { get; }
	[Value("yChannelSelector")]
	public SVGAnimatedEnumeration YChannelSelector { get; }
}


[Value("SVGFEDropShadowElement")]
public partial class SVGFEDropShadowElement : SVGElement, SVGFilterPrimitiveStandardAttributes
{
	[Value("in1")]
	public SVGAnimatedString In1 { get; }
	[Value("dx")]
	public SVGAnimatedNumber Dx { get; }
	[Value("dy")]
	public SVGAnimatedNumber Dy { get; }
	[Value("stdDeviationX")]
	public SVGAnimatedNumber StdDeviationX { get; }
	[Value("stdDeviationY")]
	public SVGAnimatedNumber StdDeviationY { get; }
	[Value("setStdDeviation")]
	public Undefined SetStdDeviation(Number stdDeviationX, Number stdDeviationY) { throw new System.NotImplementedException(); }
}


[Value("SVGFEFloodElement")]
public partial class SVGFEFloodElement : SVGElement, SVGFilterPrimitiveStandardAttributes
{
}


[Value("SVGFEGaussianBlurElement")]
public partial class SVGFEGaussianBlurElement : SVGElement, SVGFilterPrimitiveStandardAttributes
{
	[Value("SVG_EDGEMODE_UNKNOWN")]
	public const ushort SVG_EDGEMODE_UNKNOWN = 0;
	[Value("SVG_EDGEMODE_DUPLICATE")]
	public const ushort SVG_EDGEMODE_DUPLICATE = 1;
	[Value("SVG_EDGEMODE_WRAP")]
	public const ushort SVG_EDGEMODE_WRAP = 2;
	[Value("SVG_EDGEMODE_NONE")]
	public const ushort SVG_EDGEMODE_NONE = 3;
	[Value("in1")]
	public SVGAnimatedString In1 { get; }
	[Value("stdDeviationX")]
	public SVGAnimatedNumber StdDeviationX { get; }
	[Value("stdDeviationY")]
	public SVGAnimatedNumber StdDeviationY { get; }
	[Value("edgeMode")]
	public SVGAnimatedEnumeration EdgeMode { get; }
	[Value("setStdDeviation")]
	public Undefined SetStdDeviation(Number stdDeviationX, Number stdDeviationY) { throw new System.NotImplementedException(); }
}


[Value("SVGFEImageElement")]
public partial class SVGFEImageElement : SVGElement, SVGFilterPrimitiveStandardAttributes, SVGURIReference
{
	[Value("preserveAspectRatio")]
	public SVGAnimatedPreserveAspectRatio PreserveAspectRatio { get; }
	[Value("crossOrigin")]
	public SVGAnimatedString CrossOrigin { get; }
}



[Value("SVGFEMergeElement")]
public partial class SVGFEMergeElement : SVGElement, SVGFilterPrimitiveStandardAttributes
{
}


[Value("SVGFEMergeNodeElement")]
public partial class SVGFEMergeNodeElement : SVGElement
{
	[Value("in1")]
	public SVGAnimatedString In1 { get; }
}

[Value("SVGFEMorphologyElement")]
public partial class SVGFEMorphologyElement : SVGElement, SVGFilterPrimitiveStandardAttributes
{
	[Value("SVG_MORPHOLOGY_OPERATOR_UNKNOWN")]
	public const ushort SVG_MORPHOLOGY_OPERATOR_UNKNOWN = 0;
	[Value("SVG_MORPHOLOGY_OPERATOR_ERODE")]
	public const ushort SVG_MORPHOLOGY_OPERATOR_ERODE = 1;
	[Value("SVG_MORPHOLOGY_OPERATOR_DILATE")]
	public const ushort SVG_MORPHOLOGY_OPERATOR_DILATE = 2;
	[Value("in1")]
	public SVGAnimatedString In1 { get; }
	[Value("operator")]
	public SVGAnimatedEnumeration Operator { get; }
	[Value("radiusX")]
	public SVGAnimatedNumber RadiusX { get; }
	[Value("radiusY")]
	public SVGAnimatedNumber RadiusY { get; }
}


[Value("SVGFEOffsetElement")]
public partial class SVGFEOffsetElement : SVGElement, SVGFilterPrimitiveStandardAttributes
{
	[Value("in1")]
	public SVGAnimatedString In1 { get; }
	[Value("dx")]
	public SVGAnimatedNumber Dx { get; }
	[Value("dy")]
	public SVGAnimatedNumber Dy { get; }
}


[Value("SVGFESpecularLightingElement")]
public partial class SVGFESpecularLightingElement : SVGElement, SVGFilterPrimitiveStandardAttributes
{
	[Value("in1")]
	public SVGAnimatedString In1 { get; }
	[Value("surfaceScale")]
	public SVGAnimatedNumber SurfaceScale { get; }
	[Value("specularConstant")]
	public SVGAnimatedNumber SpecularConstant { get; }
	[Value("specularExponent")]
	public SVGAnimatedNumber SpecularExponent { get; }
	[Value("kernelUnitLengthX")]
	public SVGAnimatedNumber KernelUnitLengthX { get; }
	[Value("kernelUnitLengthY")]
	public SVGAnimatedNumber KernelUnitLengthY { get; }
}


[Value("SVGFETileElement")]
public partial class SVGFETileElement : SVGElement, SVGFilterPrimitiveStandardAttributes
{
	[Value("in1")]
	public SVGAnimatedString In1 { get; }
}


[Value("SVGFETurbulenceElement")]
public partial class SVGFETurbulenceElement : SVGElement, SVGFilterPrimitiveStandardAttributes
{
	[Value("SVG_TURBULENCE_TYPE_UNKNOWN")]
	public const ushort SVG_TURBULENCE_TYPE_UNKNOWN = 0;
	[Value("SVG_TURBULENCE_TYPE_FRACTALNOISE")]
	public const ushort SVG_TURBULENCE_TYPE_FRACTALNOISE = 1;
	[Value("SVG_TURBULENCE_TYPE_TURBULENCE")]
	public const ushort SVG_TURBULENCE_TYPE_TURBULENCE = 2;
	[Value("SVG_STITCHTYPE_UNKNOWN")]
	public const ushort SVG_STITCHTYPE_UNKNOWN = 0;
	[Value("SVG_STITCHTYPE_STITCH")]
	public const ushort SVG_STITCHTYPE_STITCH = 1;
	[Value("SVG_STITCHTYPE_NOSTITCH")]
	public const ushort SVG_STITCHTYPE_NOSTITCH = 2;
	[Value("baseFrequencyX")]
	public SVGAnimatedNumber BaseFrequencyX { get; }
	[Value("baseFrequencyY")]
	public SVGAnimatedNumber BaseFrequencyY { get; }
	[Value("numOctaves")]
	public SVGAnimatedInteger NumOctaves { get; }
	[Value("seed")]
	public SVGAnimatedNumber Seed { get; }
	[Value("stitchTiles")]
	public SVGAnimatedEnumeration StitchTiles { get; }
	[Value("type")]
	public SVGAnimatedEnumeration Type { get; }
}


public partial class Document
{
	[Value("measureElement")]
	public FontMetrics MeasureElement(Element element) { throw new System.NotImplementedException(); }
	[Value("measureText")]
	public FontMetrics MeasureText(DOMString text, StylePropertyMapReadOnly styleMap) { throw new System.NotImplementedException(); }
}

[Value("FontMetrics")]
public partial class FontMetrics
{
	[Value("width")]
	public Number Width { get; }
	[Value("advances")]
	public Number[] Advances { get; }
	[Value("boundingBoxLeft")]
	public Number BoundingBoxLeft { get; }
	[Value("boundingBoxRight")]
	public Number BoundingBoxRight { get; }
	[Value("height")]
	public Number Height { get; }
	[Value("emHeightAscent")]
	public Number EmHeightAscent { get; }
	[Value("emHeightDescent")]
	public Number EmHeightDescent { get; }
	[Value("boundingBoxAscent")]
	public Number BoundingBoxAscent { get; }
	[Value("boundingBoxDescent")]
	public Number BoundingBoxDescent { get; }
	[Value("fontBoundingBoxAscent")]
	public Number FontBoundingBoxAscent { get; }
	[Value("fontBoundingBoxDescent")]
	public Number FontBoundingBoxDescent { get; }
	[Value("dominantBaseline")]
	public Baseline DominantBaseline { get; }
	[Value("baselines")]
	public Baseline[] Baselines { get; }
	[Value("fonts")]
	public Font[] Fonts { get; }
}

[Value("Baseline")]
public partial class Baseline
{
	[Value("name")]
	public DOMString Name { get; }
	[Value("value")]
	public Number Value { get; }
}

[Value("Font")]
public partial class Font
{
	[Value("name")]
	public DOMString Name { get; }
	[Value("glyphsRendered")]
	public ulong GlyphsRendered { get; }
}

public partial class FileSystemHandle
{
	[Value("kind")]
	public FileSystemHandleKind Kind { get; }
	[Value("name")]
	public USVString Name { get; }
	[Value("isSameEntry")]
	public Task<bool> IsSameEntry(FileSystemHandle other) { throw new System.NotImplementedException(); }
}

[Value("FileSystemCreateWritableOptions")]
public partial class FileSystemCreateWritableOptions
{
	[Value("keepExistingData")]
	public bool KeepExistingData;
}

[Value("FileSystemFileHandle")]
public partial class FileSystemFileHandle : FileSystemHandle
{
	[Value("getFile")]
	public Task<File> GetFile() { throw new System.NotImplementedException(); }
	[Value("createWritable")]
	public Task<FileSystemWritableFileStream> CreateWritable(FileSystemCreateWritableOptions options = default) { throw new System.NotImplementedException(); }
	[Value("createSyncAccessHandle")]
	public Task<FileSystemSyncAccessHandle> CreateSyncAccessHandle() { throw new System.NotImplementedException(); }
}

[Value("FileSystemGetFileOptions")]
public partial class FileSystemGetFileOptions
{
	[Value("create")]
	public bool Create;
}

[Value("FileSystemGetDirectoryOptions")]
public partial class FileSystemGetDirectoryOptions
{
	[Value("create")]
	public bool Create;
}

[Value("FileSystemRemoveOptions")]
public partial class FileSystemRemoveOptions
{
	[Value("recursive")]
	public bool Recursive;
}

[Value("FileSystemDirectoryHandle")]
public partial class FileSystemDirectoryHandle : FileSystemHandle
{
	public USVString this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	[Value("getFileHandle")]
	public Task<FileSystemFileHandle> GetFileHandle(USVString name, FileSystemGetFileOptions options = default) { throw new System.NotImplementedException(); }
	[Value("getDirectoryHandle")]
	public Task<FileSystemDirectoryHandle> GetDirectoryHandle(USVString name, FileSystemGetDirectoryOptions options = default) { throw new System.NotImplementedException(); }
	[Value("removeEntry")]
	public Task<Undefined> RemoveEntry(USVString name, FileSystemRemoveOptions options = default) { throw new System.NotImplementedException(); }
	[Value("resolve")]
	public Task<List<USVString>?> Resolve(FileSystemHandle possibleDescendant) { throw new System.NotImplementedException(); }
}

[Value("WriteParams")]
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


[Value("FileSystemWritableFileStream")]
public partial class FileSystemWritableFileStream : WritableStream
{
	[Value("write")]
	public Task<Undefined> Write(FileSystemWriteChunkType data) { throw new System.NotImplementedException(); }
	[Value("seek")]
	public Task<Undefined> Seek(ulong position) { throw new System.NotImplementedException(); }
	[Value("truncate")]
	public Task<Undefined> Truncate(ulong size) { throw new System.NotImplementedException(); }
}

[Value("FileSystemReadWriteOptions")]
public partial class FileSystemReadWriteOptions
{
	[Value("at")]
	public ulong At;
}

[Value("FileSystemSyncAccessHandle")]
public partial class FileSystemSyncAccessHandle
{
	[Value("read")]
	public ulong Read(AllowSharedBufferSource buffer, FileSystemReadWriteOptions options = default) { throw new System.NotImplementedException(); }
	[Value("write")]
	public ulong Write(AllowSharedBufferSource buffer, FileSystemReadWriteOptions options = default) { throw new System.NotImplementedException(); }
	[Value("truncate")]
	public Undefined Truncate(ulong newSize) { throw new System.NotImplementedException(); }
	[Value("getSize")]
	public ulong GetSize() { throw new System.NotImplementedException(); }
	[Value("flush")]
	public Undefined Flush() { throw new System.NotImplementedException(); }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
}

[Value("StorageManager")]
public partial class StorageManager
{
	[Value("getDirectory")]
	public Task<FileSystemDirectoryHandle> GetDirectory() { throw new System.NotImplementedException(); }
}

[Value("FullscreenOptions")]
public partial class FullscreenOptions
{
	[Value("navigationUI")]
	public FullscreenNavigationUI NavigationUI;
}

public partial class Element
{
	[Value("requestFullscreen")]
	public Task<Undefined> RequestFullscreen(FullscreenOptions options = default) { throw new System.NotImplementedException(); }
	[Value("onfullscreenchange")]
	public EventHandler Onfullscreenchange { get; set; }
	[Value("onfullscreenerror")]
	public EventHandler Onfullscreenerror { get; set; }
}

public partial class Document
{
	[Value("fullscreenEnabled")]
	public bool FullscreenEnabled { get; }
	[Value("fullscreen")]
	public bool Fullscreen { get; }
	[Value("exitFullscreen")]
	public Task<Undefined> ExitFullscreen() { throw new System.NotImplementedException(); }
	[Value("onfullscreenchange")]
	public EventHandler Onfullscreenchange { get; set; }
	[Value("onfullscreenerror")]
	public EventHandler Onfullscreenerror { get; set; }
}

[Value("GamepadPose")]
public partial class GamepadPose
{
	[Value("hasOrientation")]
	public bool HasOrientation { get; }
	[Value("hasPosition")]
	public bool HasPosition { get; }
	[Value("position")]
	public Float32Array? Position { get; }
	[Value("linearVelocity")]
	public Float32Array? LinearVelocity { get; }
	[Value("linearAcceleration")]
	public Float32Array? LinearAcceleration { get; }
	[Value("orientation")]
	public Float32Array? Orientation { get; }
	[Value("angularVelocity")]
	public Float32Array? AngularVelocity { get; }
	[Value("angularAcceleration")]
	public Float32Array? AngularAcceleration { get; }
}

[Value("GamepadTouch")]
public partial class GamepadTouch
{
	[Value("touchId")]
	public ulong TouchId { get; }
	[Value("surfaceId")]
	public byte SurfaceId { get; }
	[Value("position")]
	public Float32Array Position { get; }
	[Value("surfaceDimensions")]
	public Uint32Array? SurfaceDimensions { get; }
}

[Value("Gamepad")]
public partial class Gamepad
{
	[Value("hand")]
	public GamepadHand Hand { get; }
	[Value("hapticActuators")]
	public GamepadHapticActuator[] HapticActuators { get; }
	[Value("pose")]
	public GamepadPose? Pose { get; }
	[Value("touchEvents")]
	public GamepadTouch[]? TouchEvents { get; }
}

[Value("GamepadHapticActuator")]
public partial class GamepadHapticActuator
{
	[Value("pulse")]
	public Task<bool> Pulse(Number value, Number duration) { throw new System.NotImplementedException(); }
}

public partial class Gamepad
{
	[Value("id")]
	public DOMString Id { get; }
	[Value("index")]
	public long Index { get; }
	[Value("connected")]
	public bool Connected { get; }
	[Value("timestamp")]
	public DOMHighResTimeStamp Timestamp { get; }
	[Value("mapping")]
	public GamepadMappingType Mapping { get; }
	[Value("axes")]
	public Number[] Axes { get; }
	[Value("buttons")]
	public GamepadButton[] Buttons { get; }
	[Value("vibrationActuator")]
	public GamepadHapticActuator VibrationActuator { get; }
}

[Value("GamepadButton")]
public partial class GamepadButton
{
	[Value("pressed")]
	public bool Pressed { get; }
	[Value("touched")]
	public bool Touched { get; }
	[Value("value")]
	public Number Value { get; }
}

public partial class GamepadHapticActuator
{
	[Value("effects")]
	public GamepadHapticEffectType[] Effects { get; }
	[Value("playEffect")]
	public Task<GamepadHapticsResult> PlayEffect(GamepadHapticEffectType type, GamepadEffectParameters params_ = default) { throw new System.NotImplementedException(); }
	[Value("reset")]
	public Task<GamepadHapticsResult> Reset() { throw new System.NotImplementedException(); }
}

[Value("GamepadEffectParameters")]
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

public partial class Navigator
{
	[Value("getGamepads")]
	public List<Gamepad?> GetGamepads() { throw new System.NotImplementedException(); }
}

[Value("GamepadEvent")]
public partial class GamepadEvent : Event
{
		public GamepadEvent(DOMString type, GamepadEventInit eventInitDict) { }
	[Value("gamepad")]
	public Gamepad Gamepad { get; }
	public GamepadEvent() { }
}

[Value("GamepadEventInit")]
public partial class GamepadEventInit : EventInit
{
	[Value("gamepad")]
	public required Gamepad Gamepad;
}

[Value("Sensor")]
public partial class Sensor : EventTarget
{
	[Value("activated")]
	public bool Activated { get; }
	[Value("hasReading")]
	public bool HasReading { get; }
	[Value("timestamp")]
	public DOMHighResTimeStamp? Timestamp { get; }
	[Value("start")]
	public Undefined Start() { throw new System.NotImplementedException(); }
	[Value("stop")]
	public Undefined Stop() { throw new System.NotImplementedException(); }
	[Value("onreading")]
	public EventHandler Onreading { get; set; }
	[Value("onactivate")]
	public EventHandler Onactivate { get; set; }
	[Value("onerror")]
	public EventHandler Onerror { get; set; }
}

[Value("SensorOptions")]
public partial class SensorOptions
{
	[Value("frequency")]
	public Number Frequency;
}

[Value("SensorErrorEvent")]
public partial class SensorErrorEvent : Event
{
		public SensorErrorEvent(DOMString type, SensorErrorEventInit errorEventInitDict) { }
	[Value("error")]
	public DOMException Error { get; }
	public SensorErrorEvent() { }
}

[Value("SensorErrorEventInit")]
public partial class SensorErrorEventInit : EventInit
{
	[Value("error")]
	public required DOMException Error;
}

[Value("GeolocationSensor")]
public partial class GeolocationSensor : Sensor
{
		public GeolocationSensor(GeolocationSensorOptions options = default) { }
	[Value("read")]
	public static Task<GeolocationSensorReading> Read(ReadOptions readOptions = default) { throw new System.NotImplementedException(); }
	[Value("latitude")]
	public double? Latitude { get; }
	[Value("longitude")]
	public double? Longitude { get; }
	[Value("altitude")]
	public double? Altitude { get; }
	[Value("accuracy")]
	public double? Accuracy { get; }
	[Value("altitudeAccuracy")]
	public double? AltitudeAccuracy { get; }
	[Value("heading")]
	public double? Heading { get; }
	[Value("speed")]
	public double? Speed { get; }
	public GeolocationSensor() { }
}

[Value("GeolocationSensorOptions")]
public partial class GeolocationSensorOptions : SensorOptions
{
}

[Value("ReadOptions")]
public partial class ReadOptions : GeolocationSensorOptions
{
	[Value("signal")]
	public AbortSignal? Signal;
}

[Value("GeolocationSensorReading")]
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

public partial class Navigator
{
	[Value("geolocation")]
	public Geolocation Geolocation { get; }
}

[Value("Geolocation")]
public partial class Geolocation
{
	[Value("getCurrentPosition")]
	public Undefined GetCurrentPosition(PositionCallback successCallback, PositionErrorCallback? errorCallback = default, PositionOptions options = default) { throw new System.NotImplementedException(); }
	[Value("watchPosition")]
	public long WatchPosition(PositionCallback successCallback, PositionErrorCallback? errorCallback = default, PositionOptions options = default) { throw new System.NotImplementedException(); }
	[Value("clearWatch")]
	public Undefined ClearWatch(long watchId) { throw new System.NotImplementedException(); }
}

[Value("PositionOptions")]
public partial class PositionOptions
{
	[Value("enableHighAccuracy")]
	public bool EnableHighAccuracy;
	[Value("timeout")]
	public ulong Timeout;
	[Value("maximumAge")]
	public ulong MaximumAge;
}

[Value("GeolocationPosition")]
public partial class GeolocationPosition
{
	[Value("coords")]
	public GeolocationCoordinates Coords { get; }
	[Value("timestamp")]
	public EpochTimeStamp Timestamp { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

[Value("GeolocationCoordinates")]
public partial class GeolocationCoordinates
{
	[Value("accuracy")]
	public Number Accuracy { get; }
	[Value("latitude")]
	public Number Latitude { get; }
	[Value("longitude")]
	public Number Longitude { get; }
	[Value("altitude")]
	public Number? Altitude { get; }
	[Value("altitudeAccuracy")]
	public Number? AltitudeAccuracy { get; }
	[Value("heading")]
	public Number? Heading { get; }
	[Value("speed")]
	public Number? Speed { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

[Value("GeolocationPositionError")]
public partial class GeolocationPositionError
{
	[Value("PERMISSION_DENIED")]
	public const ushort PERMISSION_DENIED = 1;
	[Value("POSITION_UNAVAILABLE")]
	public const ushort POSITION_UNAVAILABLE = 2;
	[Value("TIMEOUT")]
	public const ushort TIMEOUT = 3;
	[Value("code")]
	public ushort Code { get; }
	[Value("message")]
	public DOMString Message { get; }
}

[Value("DOMPointReadOnly")]
public partial class DOMPointReadOnly
{
		public DOMPointReadOnly(double x = default, double y = default, double z = default, double w = default) { }
	[Value("fromPoint")]
	public static DOMPointReadOnly FromPoint(DOMPointInit other = default) { throw new System.NotImplementedException(); }
	[Value("x")]
	public double X { get; }
	[Value("y")]
	public double Y { get; }
	[Value("z")]
	public double Z { get; }
	[Value("w")]
	public double W { get; }
	[Value("matrixTransform")]
	public DOMPoint MatrixTransform(DOMMatrixInit matrix = default) { throw new System.NotImplementedException(); }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
	public DOMPointReadOnly() { }
}

[Value("DOMPoint")]
public partial class DOMPoint : DOMPointReadOnly
{
		public DOMPoint(double x = default, double y = default, double z = default, double w = default) { }
	[Value("fromPoint")]
	public static DOMPoint FromPoint(DOMPointInit other = default) { throw new System.NotImplementedException(); }
	[Value("x")]
	public double X { get; set; }
	[Value("y")]
	public double Y { get; set; }
	[Value("z")]
	public double Z { get; set; }
	[Value("w")]
	public double W { get; set; }
	public DOMPoint() { }
}

[Value("DOMPointInit")]
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

[Value("DOMRectReadOnly")]
public partial class DOMRectReadOnly
{
		public DOMRectReadOnly(double x = default, double y = default, double width = default, double height = default) { }
	[Value("fromRect")]
	public static DOMRectReadOnly FromRect(DOMRectInit other = default) { throw new System.NotImplementedException(); }
	[Value("x")]
	public double X { get; }
	[Value("y")]
	public double Y { get; }
	[Value("width")]
	public double Width { get; }
	[Value("height")]
	public double Height { get; }
	[Value("top")]
	public double Top { get; }
	[Value("right")]
	public double Right { get; }
	[Value("bottom")]
	public double Bottom { get; }
	[Value("left")]
	public double Left { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
	public DOMRectReadOnly() { }
}

[Value("DOMRect")]
public partial class DOMRect : DOMRectReadOnly
{
		public DOMRect(double x = default, double y = default, double width = default, double height = default) { }
	[Value("fromRect")]
	public static DOMRect FromRect(DOMRectInit other = default) { throw new System.NotImplementedException(); }
	[Value("x")]
	public double X { get; set; }
	[Value("y")]
	public double Y { get; set; }
	[Value("width")]
	public double Width { get; set; }
	[Value("height")]
	public double Height { get; set; }
	public DOMRect() { }
}

[Value("DOMRectInit")]
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

[Value("DOMRectList")]
public partial class DOMRectList
{
	[Value("length")]
	public ulong Length { get; }
	
}

[Value("DOMQuad")]
public partial class DOMQuad
{
		public DOMQuad(DOMPointInit p1 = default, DOMPointInit p2 = default, DOMPointInit p3 = default, DOMPointInit p4 = default) { }
	[Value("fromRect")]
	public static DOMQuad FromRect(DOMRectInit other = default) { throw new System.NotImplementedException(); }
	[Value("fromQuad")]
	public static DOMQuad FromQuad(DOMQuadInit other = default) { throw new System.NotImplementedException(); }
	[Value("p1")]
	public DOMPoint P1 { get; }
	[Value("p2")]
	public DOMPoint P2 { get; }
	[Value("p3")]
	public DOMPoint P3 { get; }
	[Value("p4")]
	public DOMPoint P4 { get; }
	[Value("getBounds")]
	public DOMRect GetBounds() { throw new System.NotImplementedException(); }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
	public DOMQuad() { }
}

[Value("DOMQuadInit")]
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

[Value("DOMMatrixReadOnly")]
public partial class DOMMatrixReadOnly
{
		public DOMMatrixReadOnly(Union49 init = default) { }
	[Value("fromMatrix")]
	public static DOMMatrixReadOnly FromMatrix(DOMMatrixInit other = default) { throw new System.NotImplementedException(); }
	[Value("fromFloat32Array")]
	public static DOMMatrixReadOnly FromFloat32Array(Float32Array array32) { throw new System.NotImplementedException(); }
	[Value("fromFloat64Array")]
	public static DOMMatrixReadOnly FromFloat64Array(Float64Array array64) { throw new System.NotImplementedException(); }
	[Value("a")]
	public double A { get; }
	[Value("b")]
	public double B { get; }
	[Value("c")]
	public double C { get; }
	[Value("d")]
	public double D { get; }
	[Value("e")]
	public double E { get; }
	[Value("f")]
	public double F { get; }
	[Value("m11")]
	public double M11 { get; }
	[Value("m12")]
	public double M12 { get; }
	[Value("m13")]
	public double M13 { get; }
	[Value("m14")]
	public double M14 { get; }
	[Value("m21")]
	public double M21 { get; }
	[Value("m22")]
	public double M22 { get; }
	[Value("m23")]
	public double M23 { get; }
	[Value("m24")]
	public double M24 { get; }
	[Value("m31")]
	public double M31 { get; }
	[Value("m32")]
	public double M32 { get; }
	[Value("m33")]
	public double M33 { get; }
	[Value("m34")]
	public double M34 { get; }
	[Value("m41")]
	public double M41 { get; }
	[Value("m42")]
	public double M42 { get; }
	[Value("m43")]
	public double M43 { get; }
	[Value("m44")]
	public double M44 { get; }
	[Value("is2D")]
	public bool Is2D { get; }
	[Value("isIdentity")]
	public bool IsIdentity { get; }
	[Value("translate")]
	public DOMMatrix Translate(double tx = default, double ty = default, double tz = default) { throw new System.NotImplementedException(); }
	[Value("scale")]
	public DOMMatrix Scale(double scaleX = default, double scaleY = default, double scaleZ = default, double originX = default, double originY = default, double originZ = default) { throw new System.NotImplementedException(); }
	[Value("scaleNonUniform")]
	public DOMMatrix ScaleNonUniform(double scaleX = default, double scaleY = default) { throw new System.NotImplementedException(); }
	[Value("scale3d")]
	public DOMMatrix Scale3d(double scale = default, double originX = default, double originY = default, double originZ = default) { throw new System.NotImplementedException(); }
	[Value("rotate")]
	public DOMMatrix Rotate(double rotX = default, double rotY = default, double rotZ = default) { throw new System.NotImplementedException(); }
	[Value("rotateFromVector")]
	public DOMMatrix RotateFromVector(double x = default, double y = default) { throw new System.NotImplementedException(); }
	[Value("rotateAxisAngle")]
	public DOMMatrix RotateAxisAngle(double x = default, double y = default, double z = default, double angle = default) { throw new System.NotImplementedException(); }
	[Value("skewX")]
	public DOMMatrix SkewX(double sx = default) { throw new System.NotImplementedException(); }
	[Value("skewY")]
	public DOMMatrix SkewY(double sy = default) { throw new System.NotImplementedException(); }
	[Value("multiply")]
	public DOMMatrix Multiply(DOMMatrixInit other = default) { throw new System.NotImplementedException(); }
	[Value("flipX")]
	public DOMMatrix FlipX() { throw new System.NotImplementedException(); }
	[Value("flipY")]
	public DOMMatrix FlipY() { throw new System.NotImplementedException(); }
	[Value("inverse")]
	public DOMMatrix Inverse() { throw new System.NotImplementedException(); }
	[Value("transformPoint")]
	public DOMPoint TransformPoint(DOMPointInit point = default) { throw new System.NotImplementedException(); }
	[Value("toFloat32Array")]
	public Float32Array ToFloat32Array() { throw new System.NotImplementedException(); }
	[Value("toFloat64Array")]
	public Float64Array ToFloat64Array() { throw new System.NotImplementedException(); }
	
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
	public DOMMatrixReadOnly() { }
}

[Value("DOMMatrix")]
public partial class DOMMatrix : DOMMatrixReadOnly
{
		public DOMMatrix(Union50 init = default) { }
	[Value("fromMatrix")]
	public static DOMMatrix FromMatrix(DOMMatrixInit other = default) { throw new System.NotImplementedException(); }
	[Value("fromFloat32Array")]
	public static DOMMatrix FromFloat32Array(Float32Array array32) { throw new System.NotImplementedException(); }
	[Value("fromFloat64Array")]
	public static DOMMatrix FromFloat64Array(Float64Array array64) { throw new System.NotImplementedException(); }
	[Value("a")]
	public double A { get; set; }
	[Value("b")]
	public double B { get; set; }
	[Value("c")]
	public double C { get; set; }
	[Value("d")]
	public double D { get; set; }
	[Value("e")]
	public double E { get; set; }
	[Value("f")]
	public double F { get; set; }
	[Value("m11")]
	public double M11 { get; set; }
	[Value("m12")]
	public double M12 { get; set; }
	[Value("m13")]
	public double M13 { get; set; }
	[Value("m14")]
	public double M14 { get; set; }
	[Value("m21")]
	public double M21 { get; set; }
	[Value("m22")]
	public double M22 { get; set; }
	[Value("m23")]
	public double M23 { get; set; }
	[Value("m24")]
	public double M24 { get; set; }
	[Value("m31")]
	public double M31 { get; set; }
	[Value("m32")]
	public double M32 { get; set; }
	[Value("m33")]
	public double M33 { get; set; }
	[Value("m34")]
	public double M34 { get; set; }
	[Value("m41")]
	public double M41 { get; set; }
	[Value("m42")]
	public double M42 { get; set; }
	[Value("m43")]
	public double M43 { get; set; }
	[Value("m44")]
	public double M44 { get; set; }
	[Value("multiplySelf")]
	public DOMMatrix MultiplySelf(DOMMatrixInit other = default) { throw new System.NotImplementedException(); }
	[Value("preMultiplySelf")]
	public DOMMatrix PreMultiplySelf(DOMMatrixInit other = default) { throw new System.NotImplementedException(); }
	[Value("translateSelf")]
	public DOMMatrix TranslateSelf(double tx = default, double ty = default, double tz = default) { throw new System.NotImplementedException(); }
	[Value("scaleSelf")]
	public DOMMatrix ScaleSelf(double scaleX = default, double scaleY = default, double scaleZ = default, double originX = default, double originY = default, double originZ = default) { throw new System.NotImplementedException(); }
	[Value("scale3dSelf")]
	public DOMMatrix Scale3dSelf(double scale = default, double originX = default, double originY = default, double originZ = default) { throw new System.NotImplementedException(); }
	[Value("rotateSelf")]
	public DOMMatrix RotateSelf(double rotX = default, double rotY = default, double rotZ = default) { throw new System.NotImplementedException(); }
	[Value("rotateFromVectorSelf")]
	public DOMMatrix RotateFromVectorSelf(double x = default, double y = default) { throw new System.NotImplementedException(); }
	[Value("rotateAxisAngleSelf")]
	public DOMMatrix RotateAxisAngleSelf(double x = default, double y = default, double z = default, double angle = default) { throw new System.NotImplementedException(); }
	[Value("skewXSelf")]
	public DOMMatrix SkewXSelf(double sx = default) { throw new System.NotImplementedException(); }
	[Value("skewYSelf")]
	public DOMMatrix SkewYSelf(double sy = default) { throw new System.NotImplementedException(); }
	[Value("invertSelf")]
	public DOMMatrix InvertSelf() { throw new System.NotImplementedException(); }
	[Value("setMatrixValue")]
	public DOMMatrix SetMatrixValue(DOMString transformList) { throw new System.NotImplementedException(); }
	public DOMMatrix() { }
}

[Value("DOMMatrix2DInit")]
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

[Value("DOMMatrixInit")]
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

[Value("RelatedApplication")]
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

public partial class Navigator
{
	[Value("getInstalledRelatedApps")]
	public Task<List<RelatedApplication>> GetInstalledRelatedApps() { throw new System.NotImplementedException(); }
}

[Value("Gyroscope")]
public partial class Gyroscope : Sensor
{
		public Gyroscope(GyroscopeSensorOptions sensorOptions = default) { }
	[Value("x")]
	public Number? X { get; }
	[Value("y")]
	public Number? Y { get; }
	[Value("z")]
	public Number? Z { get; }
	public Gyroscope() { }
}

[Value("GyroscopeSensorOptions")]
public partial class GyroscopeSensorOptions : SensorOptions
{
	[Value("referenceFrame")]
	public GyroscopeLocalCoordinateSystem ReferenceFrame;
}

public partial class Navigator
{
	[Value("queryHandwritingRecognizer")]
	public Task<HandwritingRecognizerQueryResult?> QueryHandwritingRecognizer(HandwritingModelConstraint constraint) { throw new System.NotImplementedException(); }
}

[Value("HandwritingModelConstraint")]
public partial class HandwritingModelConstraint
{
	[Value("languages")]
	public required List<DOMString> Languages;
}

[Value("HandwritingRecognizerQueryResult")]
public partial class HandwritingRecognizerQueryResult
{
	[Value("textAlternatives")]
	public bool TextAlternatives;
	[Value("textSegmentation")]
	public bool TextSegmentation;
	[Value("hints")]
	public HandwritingHintsQueryResult Hints;
}

[Value("HandwritingHintsQueryResult")]
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

public partial class Navigator
{
	[Value("createHandwritingRecognizer")]
	public Task<HandwritingRecognizer> CreateHandwritingRecognizer(HandwritingModelConstraint constraint) { throw new System.NotImplementedException(); }
}

[Value("HandwritingRecognizer")]
public partial class HandwritingRecognizer
{
	[Value("startDrawing")]
	public HandwritingDrawing StartDrawing(HandwritingHints hints = default) { throw new System.NotImplementedException(); }
	[Value("finish")]
	public Undefined Finish() { throw new System.NotImplementedException(); }
}

[Value("HandwritingHints")]
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

[Value("HandwritingDrawing")]
public partial class HandwritingDrawing
{
	[Value("addStroke")]
	public Undefined AddStroke(HandwritingStroke stroke) { throw new System.NotImplementedException(); }
	[Value("removeStroke")]
	public Undefined RemoveStroke(HandwritingStroke stroke) { throw new System.NotImplementedException(); }
	[Value("clear")]
	public Undefined Clear() { throw new System.NotImplementedException(); }
	[Value("getStrokes")]
	public List<HandwritingStroke> GetStrokes() { throw new System.NotImplementedException(); }
	[Value("getPrediction")]
	public Task<List<HandwritingPrediction>> GetPrediction() { throw new System.NotImplementedException(); }
}

[Value("HandwritingStroke")]
public partial class HandwritingStroke
{
		public HandwritingStroke() { }
	[Value("addPoint")]
	public Undefined AddPoint(HandwritingPoint point) { throw new System.NotImplementedException(); }
	[Value("getPoints")]
	public List<HandwritingPoint> GetPoints() { throw new System.NotImplementedException(); }
	[Value("clear")]
	public Undefined Clear() { throw new System.NotImplementedException(); }
}

[Value("HandwritingPoint")]
public partial class HandwritingPoint
{
	[Value("x")]
	public required Number X;
	[Value("y")]
	public required Number Y;
	[Value("t")]
	public DOMHighResTimeStamp T;
}

[Value("HandwritingPrediction")]
public partial class HandwritingPrediction
{
	[Value("text")]
	public required DOMString Text;
	[Value("segmentationResult")]
	public List<HandwritingSegment> SegmentationResult;
}

[Value("HandwritingSegment")]
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

[Value("HandwritingDrawingSegment")]
public partial class HandwritingDrawingSegment
{
	[Value("strokeIndex")]
	public required ulong StrokeIndex;
	[Value("beginPointIndex")]
	public required ulong BeginPointIndex;
	[Value("endPointIndex")]
	public required ulong EndPointIndex;
}



public partial class Performance : EventTarget
{
	[Value("now")]
	public DOMHighResTimeStamp Now() { throw new System.NotImplementedException(); }
	[Value("timeOrigin")]
	public DOMHighResTimeStamp TimeOrigin { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

public partial class HTMLInputElement
{
	[Value("capture")]
	public DOMString Capture { get; set; }
}

[Value("HTMLAllCollection")]
public partial class HTMLAllCollection
{
	[Value("length")]
	public ulong Length { get; }
	
	
	[Value("item")]
	public Union52? Item(DOMString nameOrIndex = default) { throw new System.NotImplementedException(); }
}

[Value("HTMLFormControlsCollection")]
public partial class HTMLFormControlsCollection : HTMLCollection
{
	
}

[Value("RadioNodeList")]
public partial class RadioNodeList : NodeList
{
	[Value("value")]
	public DOMString Value { get; set; }
}

[Value("HTMLOptionsCollection")]
public partial class HTMLOptionsCollection : HTMLCollection
{
	[Value("length")]
	public ulong Length { get; set; }
	
	[Value("add")]
	public Undefined Add(Union54 element, Union55? before = default) { throw new System.NotImplementedException(); }
	[Value("remove")]
	public Undefined Remove(long index) { throw new System.NotImplementedException(); }
	[Value("selectedIndex")]
	public long SelectedIndex { get; set; }
}

[Value("DOMStringList")]
public partial class DOMStringList
{
	[Value("length")]
	public ulong Length { get; }
	
	[Value("contains")]
	public bool Contains(DOMString string_) { throw new System.NotImplementedException(); }
}

public partial class Document
{
	[Value("parseHTMLUnsafe")]
	public static Document ParseHTMLUnsafe(Union57 html) { throw new System.NotImplementedException(); }
	[Value("location")]
	public Location? Location { get; }
	[Value("domain")]
	public USVString Domain { get; set; }
	[Value("referrer")]
	public USVString Referrer { get; }
	[Value("cookie")]
	public USVString Cookie { get; set; }
	[Value("lastModified")]
	public DOMString LastModified { get; }
	[Value("readyState")]
	public DocumentReadyState ReadyState { get; }
	
	[Value("title")]
	public DOMString Title { get; set; }
	[Value("dir")]
	public DOMString Dir { get; set; }
	[Value("body")]
	public HTMLElement? Body { get; set; }
	[Value("head")]
	public HTMLHeadElement? Head { get; }
	[Value("images")]
	public HTMLCollection Images { get; }
	[Value("embeds")]
	public HTMLCollection Embeds { get; }
	[Value("plugins")]
	public HTMLCollection Plugins { get; }
	[Value("links")]
	public HTMLCollection Links { get; }
	[Value("forms")]
	public HTMLCollection Forms { get; }
	[Value("scripts")]
	public HTMLCollection Scripts { get; }
	[Value("getElementsByName")]
	public NodeList GetElementsByName(DOMString elementName) { throw new System.NotImplementedException(); }
	[Value("currentScript")]
	public HTMLOrSVGScriptElement? CurrentScript { get; }
	[Value("open")]
	public Document Open(DOMString unused1 = default, DOMString unused2 = default) { throw new System.NotImplementedException(); }
	[Value("open")]
	public WindowProxy? Open(USVString url, DOMString name, DOMString features) { throw new System.NotImplementedException(); }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	[Value("write")]
	public Undefined Write(params Union58[] text) { throw new System.NotImplementedException(); }
	[Value("writeln")]
	public Undefined Writeln(params Union59[] text) { throw new System.NotImplementedException(); }
	[Value("defaultView")]
	public WindowProxy? DefaultView { get; }
	[Value("hasFocus")]
	public bool HasFocus() { throw new System.NotImplementedException(); }
	[Value("designMode")]
	public DOMString DesignMode { get; set; }
	[Value("execCommand")]
	public bool ExecCommand(DOMString commandId, bool showUI = default, DOMString value = default) { throw new System.NotImplementedException(); }
	[Value("queryCommandEnabled")]
	public bool QueryCommandEnabled(DOMString commandId) { throw new System.NotImplementedException(); }
	[Value("queryCommandIndeterm")]
	public bool QueryCommandIndeterm(DOMString commandId) { throw new System.NotImplementedException(); }
	[Value("queryCommandState")]
	public bool QueryCommandState(DOMString commandId) { throw new System.NotImplementedException(); }
	[Value("queryCommandSupported")]
	public bool QueryCommandSupported(DOMString commandId) { throw new System.NotImplementedException(); }
	[Value("queryCommandValue")]
	public DOMString QueryCommandValue(DOMString commandId) { throw new System.NotImplementedException(); }
	[Value("hidden")]
	public bool Hidden { get; }
	[Value("visibilityState")]
	public DocumentVisibilityState VisibilityState { get; }
	[Value("onreadystatechange")]
	public EventHandler Onreadystatechange { get; set; }
	[Value("onvisibilitychange")]
	public EventHandler Onvisibilitychange { get; set; }
}


public partial class HTMLElement : Element
{
		public HTMLElement() { }
	[Value("title")]
	public DOMString Title { get; set; }
	[Value("lang")]
	public DOMString Lang { get; set; }
	[Value("translate")]
	public bool Translate { get; set; }
	[Value("dir")]
	public DOMString Dir { get; set; }
	[Value("hidden")]
	public Union60? Hidden { get; set; }
	[Value("inert")]
	public bool Inert { get; set; }
	[Value("click")]
	public Undefined Click() { throw new System.NotImplementedException(); }
	[Value("accessKey")]
	public DOMString AccessKey { get; set; }
	[Value("accessKeyLabel")]
	public DOMString AccessKeyLabel { get; }
	[Value("draggable")]
	public bool Draggable { get; set; }
	[Value("spellcheck")]
	public bool Spellcheck { get; set; }
	[Value("writingSuggestions")]
	public DOMString WritingSuggestions { get; set; }
	[Value("autocapitalize")]
	public DOMString Autocapitalize { get; set; }
	[Value("autocorrect")]
	public bool Autocorrect { get; set; }
	[Value("innerText")]
	public DOMString InnerText { get; set; }
	[Value("outerText")]
	public DOMString OuterText { get; set; }
	[Value("attachInternals")]
	public ElementInternals AttachInternals() { throw new System.NotImplementedException(); }
	[Value("showPopover")]
	public Undefined ShowPopover(ShowPopoverOptions options = default) { throw new System.NotImplementedException(); }
	[Value("hidePopover")]
	public Undefined HidePopover() { throw new System.NotImplementedException(); }
	[Value("togglePopover")]
	public bool TogglePopover(Union61 options = default) { throw new System.NotImplementedException(); }
	[Value("popover")]
	public DOMString? Popover { get; set; }
}

[Value("ShowPopoverOptions")]
public partial class ShowPopoverOptions
{
	[Value("source")]
	public HTMLElement Source;
}

[Value("TogglePopoverOptions")]
public partial class TogglePopoverOptions : ShowPopoverOptions
{
	[Value("force")]
	public bool Force;
}




[Value("HTMLUnknownElement")]
public partial class HTMLUnknownElement : HTMLElement
{
}

[Value("DOMStringMap")]
public partial class DOMStringMap
{
	
	
	
}

[Value("HTMLHtmlElement")]
public partial class HTMLHtmlElement : HTMLElement
{
		public HTMLHtmlElement() { }
}

[Value("HTMLHeadElement")]
public partial class HTMLHeadElement : HTMLElement
{
		public HTMLHeadElement() { }
}

[Value("HTMLTitleElement")]
public partial class HTMLTitleElement : HTMLElement
{
		public HTMLTitleElement() { }
	[Value("text")]
	public DOMString Text { get; set; }
}

[Value("HTMLBaseElement")]
public partial class HTMLBaseElement : HTMLElement
{
		public HTMLBaseElement() { }
	[Value("href")]
	public USVString Href { get; set; }
	[Value("target")]
	public DOMString Target { get; set; }
}

[Value("HTMLLinkElement")]
public partial class HTMLLinkElement : HTMLElement, LinkStyle
{
		public HTMLLinkElement() { }
	[Value("href")]
	public USVString Href { get; set; }
	[Value("crossOrigin")]
	public DOMString? CrossOrigin { get; set; }
	[Value("rel")]
	public DOMString Rel { get; set; }
	[Value("as")]
	public DOMString As { get; set; }
	[Value("relList")]
	public DOMTokenList RelList { get; }
	[Value("media")]
	public DOMString Media { get; set; }
	[Value("integrity")]
	public DOMString Integrity { get; set; }
	[Value("hreflang")]
	public DOMString Hreflang { get; set; }
	[Value("type")]
	public DOMString Type { get; set; }
	[Value("sizes")]
	public DOMTokenList Sizes { get; }
	[Value("imageSrcset")]
	public USVString ImageSrcset { get; set; }
	[Value("imageSizes")]
	public DOMString ImageSizes { get; set; }
	[Value("referrerPolicy")]
	public DOMString ReferrerPolicy { get; set; }
	[Value("blocking")]
	public DOMTokenList Blocking { get; }
	[Value("disabled")]
	public bool Disabled { get; set; }
	[Value("fetchPriority")]
	public DOMString FetchPriority { get; set; }
}


[Value("HTMLMetaElement")]
public partial class HTMLMetaElement : HTMLElement
{
		public HTMLMetaElement() { }
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("httpEquiv")]
	public DOMString HttpEquiv { get; set; }
	[Value("content")]
	public DOMString Content { get; set; }
	[Value("media")]
	public DOMString Media { get; set; }
}

[Value("HTMLStyleElement")]
public partial class HTMLStyleElement : HTMLElement, LinkStyle
{
		public HTMLStyleElement() { }
	[Value("disabled")]
	public bool Disabled { get; set; }
	[Value("media")]
	public DOMString Media { get; set; }
	[Value("blocking")]
	public DOMTokenList Blocking { get; }
}


public partial class HTMLBodyElement : HTMLElement
{
		public HTMLBodyElement() { }
}


[Value("HTMLHeadingElement")]
public partial class HTMLHeadingElement : HTMLElement
{
		public HTMLHeadingElement() { }
}

[Value("HTMLParagraphElement")]
public partial class HTMLParagraphElement : HTMLElement
{
		public HTMLParagraphElement() { }
}

[Value("HTMLHRElement")]
public partial class HTMLHRElement : HTMLElement
{
		public HTMLHRElement() { }
}

[Value("HTMLPreElement")]
public partial class HTMLPreElement : HTMLElement
{
		public HTMLPreElement() { }
}

[Value("HTMLQuoteElement")]
public partial class HTMLQuoteElement : HTMLElement
{
		public HTMLQuoteElement() { }
	[Value("cite")]
	public USVString Cite { get; set; }
}

[Value("HTMLOListElement")]
public partial class HTMLOListElement : HTMLElement
{
		public HTMLOListElement() { }
	[Value("reversed")]
	public bool Reversed { get; set; }
	[Value("start")]
	public long Start { get; set; }
	[Value("type")]
	public DOMString Type { get; set; }
}

[Value("HTMLUListElement")]
public partial class HTMLUListElement : HTMLElement
{
		public HTMLUListElement() { }
}

[Value("HTMLMenuElement")]
public partial class HTMLMenuElement : HTMLElement
{
		public HTMLMenuElement() { }
}

[Value("HTMLLIElement")]
public partial class HTMLLIElement : HTMLElement
{
		public HTMLLIElement() { }
	[Value("value")]
	public long Value { get; set; }
}

[Value("HTMLDListElement")]
public partial class HTMLDListElement : HTMLElement
{
		public HTMLDListElement() { }
}

[Value("HTMLDivElement")]
public partial class HTMLDivElement : HTMLElement
{
		public HTMLDivElement() { }
}

[Value("HTMLAnchorElement")]
public partial class HTMLAnchorElement : HTMLElement, HTMLAttributionSrcElementUtils, HTMLHyperlinkElementUtils
{
		public HTMLAnchorElement() { }
	[Value("target")]
	public DOMString Target { get; set; }
	[Value("download")]
	public DOMString Download { get; set; }
	[Value("ping")]
	public USVString Ping { get; set; }
	[Value("rel")]
	public DOMString Rel { get; set; }
	[Value("relList")]
	public DOMTokenList RelList { get; }
	[Value("hreflang")]
	public DOMString Hreflang { get; set; }
	[Value("type")]
	public DOMString Type { get; set; }
	[Value("text")]
	public DOMString Text { get; set; }
	[Value("referrerPolicy")]
	public DOMString ReferrerPolicy { get; set; }
}


[Value("HTMLDataElement")]
public partial class HTMLDataElement : HTMLElement
{
		public HTMLDataElement() { }
	[Value("value")]
	public DOMString Value { get; set; }
}

[Value("HTMLTimeElement")]
public partial class HTMLTimeElement : HTMLElement
{
		public HTMLTimeElement() { }
	[Value("dateTime")]
	public DOMString DateTime { get; set; }
}

[Value("HTMLSpanElement")]
public partial class HTMLSpanElement : HTMLElement
{
		public HTMLSpanElement() { }
}

[Value("HTMLBRElement")]
public partial class HTMLBRElement : HTMLElement
{
		public HTMLBRElement() { }
}

[Value("HTMLModElement")]
public partial class HTMLModElement : HTMLElement
{
		public HTMLModElement() { }
	[Value("cite")]
	public USVString Cite { get; set; }
	[Value("dateTime")]
	public DOMString DateTime { get; set; }
}

[Value("HTMLPictureElement")]
public partial class HTMLPictureElement : HTMLElement
{
		public HTMLPictureElement() { }
}

[Value("HTMLSourceElement")]
public partial class HTMLSourceElement : HTMLElement
{
		public HTMLSourceElement() { }
	[Value("src")]
	public USVString Src { get; set; }
	[Value("type")]
	public DOMString Type { get; set; }
	[Value("srcset")]
	public USVString Srcset { get; set; }
	[Value("sizes")]
	public DOMString Sizes { get; set; }
	[Value("media")]
	public DOMString Media { get; set; }
	[Value("width")]
	public ulong Width { get; set; }
	[Value("height")]
	public ulong Height { get; set; }
}

public partial class HTMLImageElement : HTMLElement
{
		public HTMLImageElement() { }
	[Value("alt")]
	public DOMString Alt { get; set; }
	[Value("src")]
	public USVString Src { get; set; }
	[Value("srcset")]
	public USVString Srcset { get; set; }
	[Value("sizes")]
	public DOMString Sizes { get; set; }
	[Value("crossOrigin")]
	public DOMString? CrossOrigin { get; set; }
	[Value("useMap")]
	public DOMString UseMap { get; set; }
	[Value("isMap")]
	public bool IsMap { get; set; }
	[Value("width")]
	public ulong Width { get; set; }
	[Value("height")]
	public ulong Height { get; set; }
	[Value("naturalWidth")]
	public ulong NaturalWidth { get; }
	[Value("naturalHeight")]
	public ulong NaturalHeight { get; }
	[Value("complete")]
	public bool Complete { get; }
	[Value("currentSrc")]
	public USVString CurrentSrc { get; }
	[Value("referrerPolicy")]
	public DOMString ReferrerPolicy { get; set; }
	[Value("decoding")]
	public DOMString Decoding { get; set; }
	[Value("loading")]
	public DOMString Loading { get; set; }
	[Value("fetchPriority")]
	public DOMString FetchPriority { get; set; }
	[Value("decode")]
	public Task<Undefined> Decode() { throw new System.NotImplementedException(); }
}

public partial class HTMLIFrameElement : HTMLElement
{
		public HTMLIFrameElement() { }
	[Value("src")]
	public USVString Src { get; set; }
	[Value("srcdoc")]
	public Union62 Srcdoc { get; set; }
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("sandbox")]
	public DOMTokenList Sandbox { get; }
	[Value("allow")]
	public DOMString Allow { get; set; }
	[Value("allowFullscreen")]
	public bool AllowFullscreen { get; set; }
	[Value("width")]
	public DOMString Width { get; set; }
	[Value("height")]
	public DOMString Height { get; set; }
	[Value("referrerPolicy")]
	public DOMString ReferrerPolicy { get; set; }
	[Value("loading")]
	public DOMString Loading { get; set; }
	[Value("contentDocument")]
	public Document? ContentDocument { get; }
	[Value("contentWindow")]
	public WindowProxy? ContentWindow { get; }
	[Value("getSVGDocument")]
	public Document? GetSVGDocument() { throw new System.NotImplementedException(); }
}

[Value("HTMLEmbedElement")]
public partial class HTMLEmbedElement : HTMLElement
{
		public HTMLEmbedElement() { }
	[Value("src")]
	public USVString Src { get; set; }
	[Value("type")]
	public DOMString Type { get; set; }
	[Value("width")]
	public DOMString Width { get; set; }
	[Value("height")]
	public DOMString Height { get; set; }
	[Value("getSVGDocument")]
	public Document? GetSVGDocument() { throw new System.NotImplementedException(); }
}

[Value("HTMLObjectElement")]
public partial class HTMLObjectElement : HTMLElement
{
		public HTMLObjectElement() { }
	[Value("data")]
	public USVString Data { get; set; }
	[Value("type")]
	public DOMString Type { get; set; }
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("form")]
	public HTMLFormElement? Form { get; }
	[Value("width")]
	public DOMString Width { get; set; }
	[Value("height")]
	public DOMString Height { get; set; }
	[Value("contentDocument")]
	public Document? ContentDocument { get; }
	[Value("contentWindow")]
	public WindowProxy? ContentWindow { get; }
	[Value("getSVGDocument")]
	public Document? GetSVGDocument() { throw new System.NotImplementedException(); }
	[Value("willValidate")]
	public bool WillValidate { get; }
	[Value("validity")]
	public ValidityState Validity { get; }
	[Value("validationMessage")]
	public DOMString ValidationMessage { get; }
	[Value("checkValidity")]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[Value("reportValidity")]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[Value("setCustomValidity")]
	public Undefined SetCustomValidity(DOMString error) { throw new System.NotImplementedException(); }
}

[Value("HTMLVideoElement")]
public partial class HTMLVideoElement : HTMLMediaElement
{
		public HTMLVideoElement() { }
	[Value("width")]
	public ulong Width { get; set; }
	[Value("height")]
	public ulong Height { get; set; }
	[Value("videoWidth")]
	public ulong VideoWidth { get; }
	[Value("videoHeight")]
	public ulong VideoHeight { get; }
	[Value("poster")]
	public USVString Poster { get; set; }
	[Value("playsInline")]
	public bool PlaysInline { get; set; }
}

[Value("HTMLAudioElement")]
public partial class HTMLAudioElement : HTMLMediaElement
{
		public HTMLAudioElement() { }
}

[Value("HTMLTrackElement")]
public partial class HTMLTrackElement : HTMLElement
{
		public HTMLTrackElement() { }
	[Value("kind")]
	public DOMString Kind { get; set; }
	[Value("src")]
	public USVString Src { get; set; }
	[Value("srclang")]
	public DOMString Srclang { get; set; }
	[Value("label")]
	public DOMString Label { get; set; }
	[Value("default")]
	public bool Default { get; set; }
	[Value("NONE")]
	public const ushort NONE = 0;
	[Value("LOADING")]
	public const ushort LOADING = 1;
	[Value("LOADED")]
	public const ushort LOADED = 2;
	[Value("ERROR")]
	public const ushort ERROR = 3;
	[Value("readyState")]
	public ushort ReadyState { get; }
	[Value("track")]
	public TextTrack Track { get; }
}

public partial class HTMLMediaElement : HTMLElement
{
	[Value("error")]
	public MediaError? Error { get; }
	[Value("src")]
	public USVString Src { get; set; }
	[Value("srcObject")]
	public MediaProvider? SrcObject { get; set; }
	[Value("currentSrc")]
	public USVString CurrentSrc { get; }
	[Value("crossOrigin")]
	public DOMString? CrossOrigin { get; set; }
	[Value("NETWORK_EMPTY")]
	public const ushort NETWORK_EMPTY = 0;
	[Value("NETWORK_IDLE")]
	public const ushort NETWORK_IDLE = 1;
	[Value("NETWORK_LOADING")]
	public const ushort NETWORK_LOADING = 2;
	[Value("NETWORK_NO_SOURCE")]
	public const ushort NETWORK_NO_SOURCE = 3;
	[Value("networkState")]
	public ushort NetworkState { get; }
	[Value("preload")]
	public DOMString Preload { get; set; }
	[Value("buffered")]
	public TimeRanges Buffered { get; }
	[Value("load")]
	public Undefined Load() { throw new System.NotImplementedException(); }
	[Value("canPlayType")]
	public CanPlayTypeResult CanPlayType(DOMString type) { throw new System.NotImplementedException(); }
	[Value("HAVE_NOTHING")]
	public const ushort HAVE_NOTHING = 0;
	[Value("HAVE_METADATA")]
	public const ushort HAVE_METADATA = 1;
	[Value("HAVE_CURRENT_DATA")]
	public const ushort HAVE_CURRENT_DATA = 2;
	[Value("HAVE_FUTURE_DATA")]
	public const ushort HAVE_FUTURE_DATA = 3;
	[Value("HAVE_ENOUGH_DATA")]
	public const ushort HAVE_ENOUGH_DATA = 4;
	[Value("readyState")]
	public ushort ReadyState { get; }
	[Value("seeking")]
	public bool Seeking { get; }
	[Value("currentTime")]
	public Number CurrentTime { get; set; }
	[Value("fastSeek")]
	public Undefined FastSeek(Number time) { throw new System.NotImplementedException(); }
	[Value("duration")]
	public double Duration { get; }
	[Value("getStartDate")]
	public Object GetStartDate() { throw new System.NotImplementedException(); }
	[Value("paused")]
	public bool Paused { get; }
	[Value("defaultPlaybackRate")]
	public Number DefaultPlaybackRate { get; set; }
	[Value("playbackRate")]
	public Number PlaybackRate { get; set; }
	[Value("preservesPitch")]
	public bool PreservesPitch { get; set; }
	[Value("played")]
	public TimeRanges Played { get; }
	[Value("seekable")]
	public TimeRanges Seekable { get; }
	[Value("ended")]
	public bool Ended { get; }
	[Value("autoplay")]
	public bool Autoplay { get; set; }
	[Value("loop")]
	public bool Loop { get; set; }
	[Value("play")]
	public Task<Undefined> Play() { throw new System.NotImplementedException(); }
	[Value("pause")]
	public Undefined Pause() { throw new System.NotImplementedException(); }
	[Value("controls")]
	public bool Controls { get; set; }
	[Value("volume")]
	public Number Volume { get; set; }
	[Value("muted")]
	public bool Muted { get; set; }
	[Value("defaultMuted")]
	public bool DefaultMuted { get; set; }
	[Value("audioTracks")]
	public AudioTrackList AudioTracks { get; }
	[Value("videoTracks")]
	public VideoTrackList VideoTracks { get; }
	[Value("textTracks")]
	public TextTrackList TextTracks { get; }
	[Value("addTextTrack")]
	public TextTrack AddTextTrack(TextTrackKind kind, DOMString label = default, DOMString language = default) { throw new System.NotImplementedException(); }
}

[Value("MediaError")]
public partial class MediaError
{
	[Value("MEDIA_ERR_ABORTED")]
	public const ushort MEDIA_ERR_ABORTED = 1;
	[Value("MEDIA_ERR_NETWORK")]
	public const ushort MEDIA_ERR_NETWORK = 2;
	[Value("MEDIA_ERR_DECODE")]
	public const ushort MEDIA_ERR_DECODE = 3;
	[Value("MEDIA_ERR_SRC_NOT_SUPPORTED")]
	public const ushort MEDIA_ERR_SRC_NOT_SUPPORTED = 4;
	[Value("code")]
	public ushort Code { get; }
	[Value("message")]
	public DOMString Message { get; }
}

[Value("AudioTrackList")]
public partial class AudioTrackList : EventTarget
{
	[Value("length")]
	public ulong Length { get; }
	
	[Value("getTrackById")]
	public AudioTrack? GetTrackById(DOMString id) { throw new System.NotImplementedException(); }
	[Value("onchange")]
	public EventHandler Onchange { get; set; }
	[Value("onaddtrack")]
	public EventHandler Onaddtrack { get; set; }
	[Value("onremovetrack")]
	public EventHandler Onremovetrack { get; set; }
}

[Value("AudioTrack")]
public partial class AudioTrack
{
	[Value("id")]
	public DOMString Id { get; }
	[Value("kind")]
	public DOMString Kind { get; }
	[Value("label")]
	public DOMString Label { get; }
	[Value("language")]
	public DOMString Language { get; }
	[Value("enabled")]
	public bool Enabled { get; set; }
}

[Value("VideoTrackList")]
public partial class VideoTrackList : EventTarget
{
	[Value("length")]
	public ulong Length { get; }
	
	[Value("getTrackById")]
	public VideoTrack? GetTrackById(DOMString id) { throw new System.NotImplementedException(); }
	[Value("selectedIndex")]
	public long SelectedIndex { get; }
	[Value("onchange")]
	public EventHandler Onchange { get; set; }
	[Value("onaddtrack")]
	public EventHandler Onaddtrack { get; set; }
	[Value("onremovetrack")]
	public EventHandler Onremovetrack { get; set; }
}

[Value("VideoTrack")]
public partial class VideoTrack
{
	[Value("id")]
	public DOMString Id { get; }
	[Value("kind")]
	public DOMString Kind { get; }
	[Value("label")]
	public DOMString Label { get; }
	[Value("language")]
	public DOMString Language { get; }
	[Value("selected")]
	public bool Selected { get; set; }
}

[Value("TextTrackList")]
public partial class TextTrackList : EventTarget
{
	[Value("length")]
	public ulong Length { get; }
	
	[Value("getTrackById")]
	public TextTrack? GetTrackById(DOMString id) { throw new System.NotImplementedException(); }
	[Value("onchange")]
	public EventHandler Onchange { get; set; }
	[Value("onaddtrack")]
	public EventHandler Onaddtrack { get; set; }
	[Value("onremovetrack")]
	public EventHandler Onremovetrack { get; set; }
}

[Value("TextTrack")]
public partial class TextTrack : EventTarget
{
	[Value("kind")]
	public TextTrackKind Kind { get; }
	[Value("label")]
	public DOMString Label { get; }
	[Value("language")]
	public DOMString Language { get; }
	[Value("id")]
	public DOMString Id { get; }
	[Value("inBandMetadataTrackDispatchType")]
	public DOMString InBandMetadataTrackDispatchType { get; }
	[Value("mode")]
	public TextTrackMode Mode { get; set; }
	[Value("cues")]
	public TextTrackCueList? Cues { get; }
	[Value("activeCues")]
	public TextTrackCueList? ActiveCues { get; }
	[Value("addCue")]
	public Undefined AddCue(TextTrackCue cue) { throw new System.NotImplementedException(); }
	[Value("removeCue")]
	public Undefined RemoveCue(TextTrackCue cue) { throw new System.NotImplementedException(); }
	[Value("oncuechange")]
	public EventHandler Oncuechange { get; set; }
}

[Value("TextTrackCueList")]
public partial class TextTrackCueList
{
	[Value("length")]
	public ulong Length { get; }
	
	[Value("getCueById")]
	public TextTrackCue? GetCueById(DOMString id) { throw new System.NotImplementedException(); }
}

[Value("TextTrackCue")]
public partial class TextTrackCue : EventTarget
{
	[Value("track")]
	public TextTrack? Track { get; }
	[Value("id")]
	public DOMString Id { get; set; }
	[Value("startTime")]
	public Number StartTime { get; set; }
	[Value("endTime")]
	public double EndTime { get; set; }
	[Value("pauseOnExit")]
	public bool PauseOnExit { get; set; }
	[Value("onenter")]
	public EventHandler Onenter { get; set; }
	[Value("onexit")]
	public EventHandler Onexit { get; set; }
}

[Value("TimeRanges")]
public partial class TimeRanges
{
	[Value("length")]
	public ulong Length { get; }
	[Value("start")]
	public Number Start(ulong index) { throw new System.NotImplementedException(); }
	[Value("end")]
	public Number End(ulong index) { throw new System.NotImplementedException(); }
}

[Value("TrackEvent")]
public partial class TrackEvent : Event
{
		public TrackEvent(DOMString type, TrackEventInit eventInitDict = default) { }
	[Value("track")]
	public Union64? Track { get; }
	public TrackEvent() { }
}

[Value("TrackEventInit")]
public partial class TrackEventInit : EventInit
{
	[Value("track")]
	public Union65? Track;
}

[Value("HTMLMapElement")]
public partial class HTMLMapElement : HTMLElement
{
		public HTMLMapElement() { }
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("areas")]
	public HTMLCollection Areas { get; }
}

[Value("HTMLAreaElement")]
public partial class HTMLAreaElement : HTMLElement, HTMLAttributionSrcElementUtils, HTMLHyperlinkElementUtils
{
		public HTMLAreaElement() { }
	[Value("alt")]
	public DOMString Alt { get; set; }
	[Value("coords")]
	public DOMString Coords { get; set; }
	[Value("shape")]
	public DOMString Shape { get; set; }
	[Value("target")]
	public DOMString Target { get; set; }
	[Value("download")]
	public DOMString Download { get; set; }
	[Value("ping")]
	public USVString Ping { get; set; }
	[Value("rel")]
	public DOMString Rel { get; set; }
	[Value("relList")]
	public DOMTokenList RelList { get; }
	[Value("referrerPolicy")]
	public DOMString ReferrerPolicy { get; set; }
}


[Value("HTMLTableElement")]
public partial class HTMLTableElement : HTMLElement
{
		public HTMLTableElement() { }
	[Value("caption")]
	public HTMLTableCaptionElement? Caption { get; set; }
	[Value("createCaption")]
	public HTMLTableCaptionElement CreateCaption() { throw new System.NotImplementedException(); }
	[Value("deleteCaption")]
	public Undefined DeleteCaption() { throw new System.NotImplementedException(); }
	[Value("tHead")]
	public HTMLTableSectionElement? THead { get; set; }
	[Value("createTHead")]
	public HTMLTableSectionElement CreateTHead() { throw new System.NotImplementedException(); }
	[Value("deleteTHead")]
	public Undefined DeleteTHead() { throw new System.NotImplementedException(); }
	[Value("tFoot")]
	public HTMLTableSectionElement? TFoot { get; set; }
	[Value("createTFoot")]
	public HTMLTableSectionElement CreateTFoot() { throw new System.NotImplementedException(); }
	[Value("deleteTFoot")]
	public Undefined DeleteTFoot() { throw new System.NotImplementedException(); }
	[Value("tBodies")]
	public HTMLCollection TBodies { get; }
	[Value("createTBody")]
	public HTMLTableSectionElement CreateTBody() { throw new System.NotImplementedException(); }
	[Value("rows")]
	public HTMLCollection Rows { get; }
	[Value("insertRow")]
	public HTMLTableRowElement InsertRow(long index = default) { throw new System.NotImplementedException(); }
	[Value("deleteRow")]
	public Undefined DeleteRow(long index) { throw new System.NotImplementedException(); }
}

[Value("HTMLTableCaptionElement")]
public partial class HTMLTableCaptionElement : HTMLElement
{
		public HTMLTableCaptionElement() { }
}

[Value("HTMLTableColElement")]
public partial class HTMLTableColElement : HTMLElement
{
		public HTMLTableColElement() { }
	[Value("span")]
	public ulong Span { get; set; }
}

[Value("HTMLTableSectionElement")]
public partial class HTMLTableSectionElement : HTMLElement
{
		public HTMLTableSectionElement() { }
	[Value("rows")]
	public HTMLCollection Rows { get; }
	[Value("insertRow")]
	public HTMLTableRowElement InsertRow(long index = default) { throw new System.NotImplementedException(); }
	[Value("deleteRow")]
	public Undefined DeleteRow(long index) { throw new System.NotImplementedException(); }
}

[Value("HTMLTableRowElement")]
public partial class HTMLTableRowElement : HTMLElement
{
		public HTMLTableRowElement() { }
	[Value("rowIndex")]
	public long RowIndex { get; }
	[Value("sectionRowIndex")]
	public long SectionRowIndex { get; }
	[Value("cells")]
	public HTMLCollection Cells { get; }
	[Value("insertCell")]
	public HTMLTableCellElement InsertCell(long index = default) { throw new System.NotImplementedException(); }
	[Value("deleteCell")]
	public Undefined DeleteCell(long index) { throw new System.NotImplementedException(); }
}

[Value("HTMLTableCellElement")]
public partial class HTMLTableCellElement : HTMLElement
{
		public HTMLTableCellElement() { }
	[Value("colSpan")]
	public ulong ColSpan { get; set; }
	[Value("rowSpan")]
	public ulong RowSpan { get; set; }
	[Value("headers")]
	public DOMString Headers { get; set; }
	[Value("cellIndex")]
	public long CellIndex { get; }
	[Value("scope")]
	public DOMString Scope { get; set; }
	[Value("abbr")]
	public DOMString Abbr { get; set; }
}

[Value("HTMLFormElement")]
public partial class HTMLFormElement : HTMLElement
{
		public HTMLFormElement() { }
	[Value("acceptCharset")]
	public DOMString AcceptCharset { get; set; }
	[Value("action")]
	public USVString Action { get; set; }
	[Value("autocomplete")]
	public DOMString Autocomplete { get; set; }
	[Value("enctype")]
	public DOMString Enctype { get; set; }
	[Value("encoding")]
	public DOMString Encoding { get; set; }
	[Value("method")]
	public DOMString Method { get; set; }
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("noValidate")]
	public bool NoValidate { get; set; }
	[Value("target")]
	public DOMString Target { get; set; }
	[Value("rel")]
	public DOMString Rel { get; set; }
	[Value("relList")]
	public DOMTokenList RelList { get; }
	[Value("elements")]
	public HTMLFormControlsCollection Elements { get; }
	[Value("length")]
	public ulong Length { get; }
	
	
	[Value("submit")]
	public Undefined Submit() { throw new System.NotImplementedException(); }
	[Value("requestSubmit")]
	public Undefined RequestSubmit(HTMLElement? submitter = default) { throw new System.NotImplementedException(); }
	[Value("reset")]
	public Undefined Reset() { throw new System.NotImplementedException(); }
	[Value("checkValidity")]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[Value("reportValidity")]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
}

[Value("HTMLLabelElement")]
public partial class HTMLLabelElement : HTMLElement
{
		public HTMLLabelElement() { }
	[Value("form")]
	public HTMLFormElement? Form { get; }
	[Value("htmlFor")]
	public DOMString HtmlFor { get; set; }
	[Value("control")]
	public HTMLElement? Control { get; }
}

public partial class HTMLInputElement : HTMLElement
{
		public HTMLInputElement() { }
	[Value("accept")]
	public DOMString Accept { get; set; }
	[Value("alpha")]
	public bool Alpha { get; set; }
	[Value("alt")]
	public DOMString Alt { get; set; }
	[Value("autocomplete")]
	public DOMString Autocomplete { get; set; }
	[Value("defaultChecked")]
	public bool DefaultChecked { get; set; }
	[Value("checked")]
	public bool Checked { get; set; }
	[Value("colorSpace")]
	public DOMString ColorSpace { get; set; }
	[Value("dirName")]
	public DOMString DirName { get; set; }
	[Value("disabled")]
	public bool Disabled { get; set; }
	[Value("form")]
	public HTMLFormElement? Form { get; }
	[Value("files")]
	public FileList? Files { get; set; }
	[Value("formAction")]
	public USVString FormAction { get; set; }
	[Value("formEnctype")]
	public DOMString FormEnctype { get; set; }
	[Value("formMethod")]
	public DOMString FormMethod { get; set; }
	[Value("formNoValidate")]
	public bool FormNoValidate { get; set; }
	[Value("formTarget")]
	public DOMString FormTarget { get; set; }
	[Value("height")]
	public ulong Height { get; set; }
	[Value("indeterminate")]
	public bool Indeterminate { get; set; }
	[Value("list")]
	public HTMLDataListElement? List { get; }
	[Value("max")]
	public DOMString Max { get; set; }
	[Value("maxLength")]
	public long MaxLength { get; set; }
	[Value("min")]
	public DOMString Min { get; set; }
	[Value("minLength")]
	public long MinLength { get; set; }
	[Value("multiple")]
	public bool Multiple { get; set; }
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("pattern")]
	public DOMString Pattern { get; set; }
	[Value("placeholder")]
	public DOMString Placeholder { get; set; }
	[Value("readOnly")]
	public bool ReadOnly { get; set; }
	[Value("required")]
	public bool Required { get; set; }
	[Value("size")]
	public ulong Size { get; set; }
	[Value("src")]
	public USVString Src { get; set; }
	[Value("step")]
	public DOMString Step { get; set; }
	[Value("type")]
	public DOMString Type { get; set; }
	[Value("defaultValue")]
	public DOMString DefaultValue { get; set; }
	[Value("value")]
	public DOMString Value { get; set; }
	[Value("valueAsDate")]
	public Object? ValueAsDate { get; set; }
	[Value("valueAsNumber")]
	public double ValueAsNumber { get; set; }
	[Value("width")]
	public ulong Width { get; set; }
	[Value("stepUp")]
	public Undefined StepUp(long n = default) { throw new System.NotImplementedException(); }
	[Value("stepDown")]
	public Undefined StepDown(long n = default) { throw new System.NotImplementedException(); }
	[Value("willValidate")]
	public bool WillValidate { get; }
	[Value("validity")]
	public ValidityState Validity { get; }
	[Value("validationMessage")]
	public DOMString ValidationMessage { get; }
	[Value("checkValidity")]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[Value("reportValidity")]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[Value("setCustomValidity")]
	public Undefined SetCustomValidity(DOMString error) { throw new System.NotImplementedException(); }
	[Value("labels")]
	public NodeList? Labels { get; }
	[Value("select")]
	public Undefined Select() { throw new System.NotImplementedException(); }
	[Value("selectionStart")]
	public ulong? SelectionStart { get; set; }
	[Value("selectionEnd")]
	public ulong? SelectionEnd { get; set; }
	[Value("selectionDirection")]
	public DOMString? SelectionDirection { get; set; }
	[Value("setRangeText")]
	public Undefined SetRangeText(DOMString replacement) { throw new System.NotImplementedException(); }
	[Value("setRangeText")]
	public Undefined SetRangeText(DOMString replacement, ulong start, ulong end, SelectionMode selectionMode = default) { throw new System.NotImplementedException(); }
	[Value("setSelectionRange")]
	public Undefined SetSelectionRange(ulong start, ulong end, DOMString direction = default) { throw new System.NotImplementedException(); }
	[Value("showPicker")]
	public Undefined ShowPicker() { throw new System.NotImplementedException(); }
}


[Value("HTMLButtonElement")]
public partial class HTMLButtonElement : HTMLElement, PopoverInvokerElement
{
		public HTMLButtonElement() { }
	[Value("disabled")]
	public bool Disabled { get; set; }
	[Value("form")]
	public HTMLFormElement? Form { get; }
	[Value("formAction")]
	public USVString FormAction { get; set; }
	[Value("formEnctype")]
	public DOMString FormEnctype { get; set; }
	[Value("formMethod")]
	public DOMString FormMethod { get; set; }
	[Value("formNoValidate")]
	public bool FormNoValidate { get; set; }
	[Value("formTarget")]
	public DOMString FormTarget { get; set; }
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("type")]
	public DOMString Type { get; set; }
	[Value("value")]
	public DOMString Value { get; set; }
	[Value("willValidate")]
	public bool WillValidate { get; }
	[Value("validity")]
	public ValidityState Validity { get; }
	[Value("validationMessage")]
	public DOMString ValidationMessage { get; }
	[Value("checkValidity")]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[Value("reportValidity")]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[Value("setCustomValidity")]
	public Undefined SetCustomValidity(DOMString error) { throw new System.NotImplementedException(); }
	[Value("labels")]
	public NodeList Labels { get; }
}


[Value("HTMLSelectElement")]
public partial class HTMLSelectElement : HTMLElement
{
		public HTMLSelectElement() { }
	[Value("autocomplete")]
	public DOMString Autocomplete { get; set; }
	[Value("disabled")]
	public bool Disabled { get; set; }
	[Value("form")]
	public HTMLFormElement? Form { get; }
	[Value("multiple")]
	public bool Multiple { get; set; }
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("required")]
	public bool Required { get; set; }
	[Value("size")]
	public ulong Size { get; set; }
	[Value("type")]
	public DOMString Type { get; }
	[Value("options")]
	public HTMLOptionsCollection Options { get; }
	[Value("length")]
	public ulong Length { get; set; }
	
	[Value("namedItem")]
	public HTMLOptionElement? NamedItem(DOMString name) { throw new System.NotImplementedException(); }
	[Value("add")]
	public Undefined Add(Union67 element, Union68? before = default) { throw new System.NotImplementedException(); }
	[Value("remove")]
	public Undefined Remove() { throw new System.NotImplementedException(); }
	[Value("remove")]
	public Undefined Remove(long index) { throw new System.NotImplementedException(); }
	
	[Value("selectedOptions")]
	public HTMLCollection SelectedOptions { get; }
	[Value("selectedIndex")]
	public long SelectedIndex { get; set; }
	[Value("value")]
	public DOMString Value { get; set; }
	[Value("willValidate")]
	public bool WillValidate { get; }
	[Value("validity")]
	public ValidityState Validity { get; }
	[Value("validationMessage")]
	public DOMString ValidationMessage { get; }
	[Value("checkValidity")]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[Value("reportValidity")]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[Value("setCustomValidity")]
	public Undefined SetCustomValidity(DOMString error) { throw new System.NotImplementedException(); }
	[Value("showPicker")]
	public Undefined ShowPicker() { throw new System.NotImplementedException(); }
	[Value("labels")]
	public NodeList Labels { get; }
}

[Value("HTMLDataListElement")]
public partial class HTMLDataListElement : HTMLElement
{
		public HTMLDataListElement() { }
	[Value("options")]
	public HTMLCollection Options { get; }
}

[Value("HTMLOptGroupElement")]
public partial class HTMLOptGroupElement : HTMLElement
{
		public HTMLOptGroupElement() { }
	[Value("disabled")]
	public bool Disabled { get; set; }
	[Value("label")]
	public DOMString Label { get; set; }
}

[Value("HTMLOptionElement")]
public partial class HTMLOptionElement : HTMLElement
{
		public HTMLOptionElement() { }
	[Value("disabled")]
	public bool Disabled { get; set; }
	[Value("form")]
	public HTMLFormElement? Form { get; }
	[Value("label")]
	public DOMString Label { get; set; }
	[Value("defaultSelected")]
	public bool DefaultSelected { get; set; }
	[Value("selected")]
	public bool Selected { get; set; }
	[Value("value")]
	public DOMString Value { get; set; }
	[Value("text")]
	public DOMString Text { get; set; }
	[Value("index")]
	public long Index { get; }
}

[Value("HTMLTextAreaElement")]
public partial class HTMLTextAreaElement : HTMLElement
{
		public HTMLTextAreaElement() { }
	[Value("autocomplete")]
	public DOMString Autocomplete { get; set; }
	[Value("cols")]
	public ulong Cols { get; set; }
	[Value("dirName")]
	public DOMString DirName { get; set; }
	[Value("disabled")]
	public bool Disabled { get; set; }
	[Value("form")]
	public HTMLFormElement? Form { get; }
	[Value("maxLength")]
	public long MaxLength { get; set; }
	[Value("minLength")]
	public long MinLength { get; set; }
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("placeholder")]
	public DOMString Placeholder { get; set; }
	[Value("readOnly")]
	public bool ReadOnly { get; set; }
	[Value("required")]
	public bool Required { get; set; }
	[Value("rows")]
	public ulong Rows { get; set; }
	[Value("wrap")]
	public DOMString Wrap { get; set; }
	[Value("type")]
	public DOMString Type { get; }
	[Value("defaultValue")]
	public DOMString DefaultValue { get; set; }
	[Value("value")]
	public DOMString Value { get; set; }
	[Value("textLength")]
	public ulong TextLength { get; }
	[Value("willValidate")]
	public bool WillValidate { get; }
	[Value("validity")]
	public ValidityState Validity { get; }
	[Value("validationMessage")]
	public DOMString ValidationMessage { get; }
	[Value("checkValidity")]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[Value("reportValidity")]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[Value("setCustomValidity")]
	public Undefined SetCustomValidity(DOMString error) { throw new System.NotImplementedException(); }
	[Value("labels")]
	public NodeList Labels { get; }
	[Value("select")]
	public Undefined Select() { throw new System.NotImplementedException(); }
	[Value("selectionStart")]
	public ulong SelectionStart { get; set; }
	[Value("selectionEnd")]
	public ulong SelectionEnd { get; set; }
	[Value("selectionDirection")]
	public DOMString SelectionDirection { get; set; }
	[Value("setRangeText")]
	public Undefined SetRangeText(DOMString replacement) { throw new System.NotImplementedException(); }
	[Value("setRangeText")]
	public Undefined SetRangeText(DOMString replacement, ulong start, ulong end, SelectionMode selectionMode = default) { throw new System.NotImplementedException(); }
	[Value("setSelectionRange")]
	public Undefined SetSelectionRange(ulong start, ulong end, DOMString direction = default) { throw new System.NotImplementedException(); }
}

[Value("HTMLOutputElement")]
public partial class HTMLOutputElement : HTMLElement
{
		public HTMLOutputElement() { }
	[Value("htmlFor")]
	public DOMTokenList HtmlFor { get; }
	[Value("form")]
	public HTMLFormElement? Form { get; }
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("type")]
	public DOMString Type { get; }
	[Value("defaultValue")]
	public DOMString DefaultValue { get; set; }
	[Value("value")]
	public DOMString Value { get; set; }
	[Value("willValidate")]
	public bool WillValidate { get; }
	[Value("validity")]
	public ValidityState Validity { get; }
	[Value("validationMessage")]
	public DOMString ValidationMessage { get; }
	[Value("checkValidity")]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[Value("reportValidity")]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[Value("setCustomValidity")]
	public Undefined SetCustomValidity(DOMString error) { throw new System.NotImplementedException(); }
	[Value("labels")]
	public NodeList Labels { get; }
}

[Value("HTMLProgressElement")]
public partial class HTMLProgressElement : HTMLElement
{
		public HTMLProgressElement() { }
	[Value("value")]
	public Number Value { get; set; }
	[Value("max")]
	public Number Max { get; set; }
	[Value("position")]
	public Number Position { get; }
	[Value("labels")]
	public NodeList Labels { get; }
}

[Value("HTMLMeterElement")]
public partial class HTMLMeterElement : HTMLElement
{
		public HTMLMeterElement() { }
	[Value("value")]
	public Number Value { get; set; }
	[Value("min")]
	public Number Min { get; set; }
	[Value("max")]
	public Number Max { get; set; }
	[Value("low")]
	public Number Low { get; set; }
	[Value("high")]
	public Number High { get; set; }
	[Value("optimum")]
	public Number Optimum { get; set; }
	[Value("labels")]
	public NodeList Labels { get; }
}

[Value("HTMLFieldSetElement")]
public partial class HTMLFieldSetElement : HTMLElement
{
		public HTMLFieldSetElement() { }
	[Value("disabled")]
	public bool Disabled { get; set; }
	[Value("form")]
	public HTMLFormElement? Form { get; }
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("type")]
	public DOMString Type { get; }
	[Value("elements")]
	public HTMLCollection Elements { get; }
	[Value("willValidate")]
	public bool WillValidate { get; }
	[Value("validity")]
	public ValidityState Validity { get; }
	[Value("validationMessage")]
	public DOMString ValidationMessage { get; }
	[Value("checkValidity")]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[Value("reportValidity")]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[Value("setCustomValidity")]
	public Undefined SetCustomValidity(DOMString error) { throw new System.NotImplementedException(); }
}

[Value("HTMLLegendElement")]
public partial class HTMLLegendElement : HTMLElement
{
		public HTMLLegendElement() { }
	[Value("form")]
	public HTMLFormElement? Form { get; }
}

[Value("ValidityState")]
public partial class ValidityState
{
	[Value("valueMissing")]
	public bool ValueMissing { get; }
	[Value("typeMismatch")]
	public bool TypeMismatch { get; }
	[Value("patternMismatch")]
	public bool PatternMismatch { get; }
	[Value("tooLong")]
	public bool TooLong { get; }
	[Value("tooShort")]
	public bool TooShort { get; }
	[Value("rangeUnderflow")]
	public bool RangeUnderflow { get; }
	[Value("rangeOverflow")]
	public bool RangeOverflow { get; }
	[Value("stepMismatch")]
	public bool StepMismatch { get; }
	[Value("badInput")]
	public bool BadInput { get; }
	[Value("customError")]
	public bool CustomError { get; }
	[Value("valid")]
	public bool Valid { get; }
}

[Value("SubmitEvent")]
public partial class SubmitEvent : Event
{
		public SubmitEvent(DOMString type, SubmitEventInit eventInitDict = default) { }
	[Value("submitter")]
	public HTMLElement? Submitter { get; }
	public SubmitEvent() { }
}

[Value("SubmitEventInit")]
public partial class SubmitEventInit : EventInit
{
	[Value("submitter")]
	public HTMLElement? Submitter;
}

[Value("FormDataEvent")]
public partial class FormDataEvent : Event
{
		public FormDataEvent(DOMString type, FormDataEventInit eventInitDict) { }
	[Value("formData")]
	public FormData FormData { get; }
	public FormDataEvent() { }
}

[Value("FormDataEventInit")]
public partial class FormDataEventInit : EventInit
{
	[Value("formData")]
	public required FormData FormData;
}

[Value("HTMLDetailsElement")]
public partial class HTMLDetailsElement : HTMLElement
{
		public HTMLDetailsElement() { }
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("open")]
	public bool Open { get; set; }
}

[Value("HTMLDialogElement")]
public partial class HTMLDialogElement : HTMLElement
{
		public HTMLDialogElement() { }
	[Value("open")]
	public bool Open { get; set; }
	[Value("returnValue")]
	public DOMString ReturnValue { get; set; }
	[Value("closedBy")]
	public DOMString ClosedBy { get; set; }
	[Value("show")]
	public Undefined Show() { throw new System.NotImplementedException(); }
	[Value("showModal")]
	public Undefined ShowModal() { throw new System.NotImplementedException(); }
	[Value("close")]
	public Undefined Close(DOMString returnValue = default) { throw new System.NotImplementedException(); }
	[Value("requestClose")]
	public Undefined RequestClose(DOMString returnValue = default) { throw new System.NotImplementedException(); }
}

[Value("HTMLScriptElement")]
public partial class HTMLScriptElement : HTMLElement, HTMLAttributionSrcElementUtils
{
		public HTMLScriptElement() { }
	[Value("src")]
	public USVString Src { get; set; }
	[Value("type")]
	public DOMString Type { get; set; }
	[Value("noModule")]
	public bool NoModule { get; set; }
	[Value("async")]
	public bool Async { get; set; }
	[Value("defer")]
	public bool Defer { get; set; }
	[Value("crossOrigin")]
	public DOMString? CrossOrigin { get; set; }
	[Value("text")]
	public DOMString Text { get; set; }
	[Value("integrity")]
	public DOMString Integrity { get; set; }
	[Value("referrerPolicy")]
	public DOMString ReferrerPolicy { get; set; }
	[Value("blocking")]
	public DOMTokenList Blocking { get; }
	[Value("fetchPriority")]
	public DOMString FetchPriority { get; set; }
	[Value("supports")]
	public static bool Supports(DOMString type) { throw new System.NotImplementedException(); }
}

[Value("HTMLTemplateElement")]
public partial class HTMLTemplateElement : HTMLElement
{
		public HTMLTemplateElement() { }
	[Value("content")]
	public DocumentFragment Content { get; }
	[Value("shadowRootMode")]
	public DOMString ShadowRootMode { get; set; }
	[Value("shadowRootDelegatesFocus")]
	public bool ShadowRootDelegatesFocus { get; set; }
	[Value("shadowRootClonable")]
	public bool ShadowRootClonable { get; set; }
	[Value("shadowRootSerializable")]
	public bool ShadowRootSerializable { get; set; }
}

[Value("HTMLSlotElement")]
public partial class HTMLSlotElement : HTMLElement
{
		public HTMLSlotElement() { }
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("assignedNodes")]
	public List<Node> AssignedNodes(AssignedNodesOptions options = default) { throw new System.NotImplementedException(); }
	[Value("assignedElements")]
	public List<Element> AssignedElements(AssignedNodesOptions options = default) { throw new System.NotImplementedException(); }
	[Value("assign")]
	public Undefined Assign(params Union69[] nodes) { throw new System.NotImplementedException(); }
}

[Value("AssignedNodesOptions")]
public partial class AssignedNodesOptions
{
	[Value("flatten")]
	public bool Flatten;
}


[Value("HTMLCanvasElement")]
public partial class HTMLCanvasElement : HTMLElement
{
		public HTMLCanvasElement() { }
	[Value("width")]
	public ulong Width { get; set; }
	[Value("height")]
	public ulong Height { get; set; }
	[Value("getContext")]
	public RenderingContext? GetContext(DOMString contextId, dynamic options = default) { throw new System.NotImplementedException(); }
	[Value("toDataURL")]
	public USVString ToDataURL(DOMString type = default, dynamic quality = default) { throw new System.NotImplementedException(); }
	[Value("toBlob")]
	public Undefined ToBlob(BlobCallback callback, DOMString type = default, dynamic quality = default) { throw new System.NotImplementedException(); }
	[Value("transferControlToOffscreen")]
	public OffscreenCanvas TransferControlToOffscreen() { throw new System.NotImplementedException(); }
}

[Value("CanvasRenderingContext2DSettings")]
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

[Value("CanvasRenderingContext2D")]
public partial class CanvasRenderingContext2D
{
	[Value("canvas")]
	public HTMLCanvasElement Canvas { get; }
	[Value("getContextAttributes")]
	public CanvasRenderingContext2DSettings GetContextAttributes() { throw new System.NotImplementedException(); }
}

















[Value("CanvasGradient")]
public partial class CanvasGradient
{
	[Value("addColorStop")]
	public Undefined AddColorStop(Number offset, DOMString color) { throw new System.NotImplementedException(); }
}

[Value("CanvasPattern")]
public partial class CanvasPattern
{
	[Value("setTransform")]
	public Undefined SetTransform(DOMMatrix2DInit transform = default) { throw new System.NotImplementedException(); }
}

[Value("TextMetrics")]
public partial class TextMetrics
{
	[Value("width")]
	public Number Width { get; }
	[Value("actualBoundingBoxLeft")]
	public Number ActualBoundingBoxLeft { get; }
	[Value("actualBoundingBoxRight")]
	public Number ActualBoundingBoxRight { get; }
	[Value("fontBoundingBoxAscent")]
	public Number FontBoundingBoxAscent { get; }
	[Value("fontBoundingBoxDescent")]
	public Number FontBoundingBoxDescent { get; }
	[Value("actualBoundingBoxAscent")]
	public Number ActualBoundingBoxAscent { get; }
	[Value("actualBoundingBoxDescent")]
	public Number ActualBoundingBoxDescent { get; }
	[Value("emHeightAscent")]
	public Number EmHeightAscent { get; }
	[Value("emHeightDescent")]
	public Number EmHeightDescent { get; }
	[Value("hangingBaseline")]
	public Number HangingBaseline { get; }
	[Value("alphabeticBaseline")]
	public Number AlphabeticBaseline { get; }
	[Value("ideographicBaseline")]
	public Number IdeographicBaseline { get; }
}

[Value("ImageDataSettings")]
public partial class ImageDataSettings
{
	[Value("colorSpace")]
	public PredefinedColorSpace ColorSpace;
}

[Value("ImageData")]
public partial class ImageData
{
		public ImageData(ulong sw, ulong sh, ImageDataSettings settings = default) { }
		public ImageData(Uint8ClampedArray data, ulong sw, ulong sh = default, ImageDataSettings settings = default) { }
	[Value("width")]
	public ulong Width { get; }
	[Value("height")]
	public ulong Height { get; }
	[Value("data")]
	public Uint8ClampedArray Data { get; }
	[Value("colorSpace")]
	public PredefinedColorSpace ColorSpace { get; }
	public ImageData() { }
}

[Value("Path2D")]
public partial class Path2D
{
		public Path2D(Union77 path = default) { }
	[Value("addPath")]
	public Undefined AddPath(Path2D path, DOMMatrix2DInit transform = default) { throw new System.NotImplementedException(); }
	public Path2D() { }
}


[Value("ImageBitmapRenderingContext")]
public partial class ImageBitmapRenderingContext
{
	[Value("canvas")]
	public Union78 Canvas { get; }
	[Value("transferFromImageBitmap")]
	public Undefined TransferFromImageBitmap(ImageBitmap? bitmap) { throw new System.NotImplementedException(); }
}

[Value("ImageBitmapRenderingContextSettings")]
public partial class ImageBitmapRenderingContextSettings
{
	[Value("alpha")]
	public bool Alpha;
}


[Value("ImageEncodeOptions")]
public partial class ImageEncodeOptions
{
	[Value("type")]
	public DOMString Type;
	[Value("quality")]
	public double Quality;
}

[Value("OffscreenCanvas")]
public partial class OffscreenCanvas : EventTarget
{
		public OffscreenCanvas(ulong width, ulong height) { }
	[Value("width")]
	public ulong Width { get; set; }
	[Value("height")]
	public ulong Height { get; set; }
	[Value("getContext")]
	public OffscreenRenderingContext? GetContext(OffscreenRenderingContextId contextId, dynamic options = default) { throw new System.NotImplementedException(); }
	[Value("transferToImageBitmap")]
	public ImageBitmap TransferToImageBitmap() { throw new System.NotImplementedException(); }
	[Value("convertToBlob")]
	public Task<Blob> ConvertToBlob(ImageEncodeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("oncontextlost")]
	public EventHandler Oncontextlost { get; set; }
	[Value("oncontextrestored")]
	public EventHandler Oncontextrestored { get; set; }
	public OffscreenCanvas() { }
}

[Value("OffscreenCanvasRenderingContext2D")]
public partial class OffscreenCanvasRenderingContext2D
{
	[Value("canvas")]
	public OffscreenCanvas Canvas { get; }
}
















[Value("CustomElementRegistry")]
public partial class CustomElementRegistry
{
	[Value("define")]
	public Undefined Define(DOMString name, CustomElementConstructor constructor, ElementDefinitionOptions options = default) { throw new System.NotImplementedException(); }
	[Value("get")]
	public Union80 Get(DOMString name) { throw new System.NotImplementedException(); }
	[Value("getName")]
	public DOMString? GetName(CustomElementConstructor constructor) { throw new System.NotImplementedException(); }
	[Value("whenDefined")]
	public Task<CustomElementConstructor> WhenDefined(DOMString name) { throw new System.NotImplementedException(); }
	[Value("upgrade")]
	public Undefined Upgrade(Node root) { throw new System.NotImplementedException(); }
}

[Value("ElementDefinitionOptions")]
public partial class ElementDefinitionOptions
{
	[Value("extends")]
	public DOMString Extends;
}

[Value("ElementInternals")]
public partial class ElementInternals
{
	[Value("shadowRoot")]
	public ShadowRoot? ShadowRoot { get; }
	[Value("setFormValue")]
	public Undefined SetFormValue(Union81? value, Union82? state = default) { throw new System.NotImplementedException(); }
	[Value("form")]
	public HTMLFormElement? Form { get; }
	[Value("setValidity")]
	public Undefined SetValidity(ValidityStateFlags flags = default, DOMString message = default, HTMLElement anchor = default) { throw new System.NotImplementedException(); }
	[Value("willValidate")]
	public bool WillValidate { get; }
	[Value("validity")]
	public ValidityState Validity { get; }
	[Value("validationMessage")]
	public DOMString ValidationMessage { get; }
	[Value("checkValidity")]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[Value("reportValidity")]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[Value("labels")]
	public NodeList Labels { get; }
	[Value("states")]
	public CustomStateSet States { get; }
}


[Value("ValidityStateFlags")]
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

[Value("CustomStateSet")]
public partial class CustomStateSet
{
	
}

[Value("VisibilityStateEntry")]
public partial class VisibilityStateEntry : PerformanceEntry
{
	[Value("name")]
	public DOMString Name { get; }
	[Value("entryType")]
	public DOMString EntryType { get; }
	[Value("startTime")]
	public DOMHighResTimeStamp StartTime { get; }
	[Value("duration")]
	public ulong Duration { get; }
}

[Value("UserActivation")]
public partial class UserActivation
{
	[Value("hasBeenActive")]
	public bool HasBeenActive { get; }
	[Value("isActive")]
	public bool IsActive { get; }
}

public partial class Navigator
{
	[Value("userActivation")]
	public UserActivation UserActivation { get; }
}

[Value("ToggleEvent")]
public partial class ToggleEvent : Event
{
		public ToggleEvent(DOMString type, ToggleEventInit eventInitDict = default) { }
	[Value("oldState")]
	public DOMString OldState { get; }
	[Value("newState")]
	public DOMString NewState { get; }
	public ToggleEvent() { }
}

[Value("ToggleEventInit")]
public partial class ToggleEventInit : EventInit
{
	[Value("oldState")]
	public DOMString OldState;
	[Value("newState")]
	public DOMString NewState;
}

[Value("FocusOptions")]
public partial class FocusOptions
{
	[Value("preventScroll")]
	public bool PreventScroll;
	[Value("focusVisible")]
	public bool FocusVisible;
}

[Value("CloseWatcher")]
public partial class CloseWatcher : EventTarget
{
		public CloseWatcher(CloseWatcherOptions options = default) { }
	[Value("requestClose")]
	public Undefined RequestClose() { throw new System.NotImplementedException(); }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	[Value("destroy")]
	public Undefined Destroy() { throw new System.NotImplementedException(); }
	[Value("oncancel")]
	public EventHandler Oncancel { get; set; }
	[Value("onclose")]
	public EventHandler Onclose { get; set; }
	public CloseWatcher() { }
}

[Value("CloseWatcherOptions")]
public partial class CloseWatcherOptions
{
	[Value("signal")]
	public AbortSignal Signal;
}

[Value("DataTransfer")]
public partial class DataTransfer
{
		public DataTransfer() { }
	[Value("dropEffect")]
	public DOMString DropEffect { get; set; }
	[Value("effectAllowed")]
	public DOMString EffectAllowed { get; set; }
	[Value("items")]
	public DataTransferItemList Items { get; }
	[Value("setDragImage")]
	public Undefined SetDragImage(Element image, long x, long y) { throw new System.NotImplementedException(); }
	[Value("types")]
	public DOMString[] Types { get; }
	[Value("getData")]
	public DOMString GetData(DOMString format) { throw new System.NotImplementedException(); }
	[Value("setData")]
	public Undefined SetData(DOMString format, DOMString data) { throw new System.NotImplementedException(); }
	[Value("clearData")]
	public Undefined ClearData(DOMString format = default) { throw new System.NotImplementedException(); }
	[Value("files")]
	public FileList Files { get; }
}

[Value("DataTransferItemList")]
public partial class DataTransferItemList
{
	[Value("length")]
	public ulong Length { get; }
	
	[Value("add")]
	public DataTransferItem? Add(DOMString data, DOMString type) { throw new System.NotImplementedException(); }
	[Value("add")]
	public DataTransferItem? Add(File data) { throw new System.NotImplementedException(); }
	[Value("remove")]
	public Undefined Remove(ulong index) { throw new System.NotImplementedException(); }
	[Value("clear")]
	public Undefined Clear() { throw new System.NotImplementedException(); }
}

public partial class DataTransferItem
{
	[Value("kind")]
	public DOMString Kind { get; }
	[Value("type")]
	public DOMString Type { get; }
	[Value("getAsString")]
	public Undefined GetAsString(FunctionStringCallback? callback) { throw new System.NotImplementedException(); }
	[Value("getAsFile")]
	public File? GetAsFile() { throw new System.NotImplementedException(); }
}

[Value("DragEvent")]
public partial class DragEvent : MouseEvent
{
		public DragEvent(DOMString type, DragEventInit eventInitDict = default) { }
	[Value("dataTransfer")]
	public DataTransfer? DataTransfer { get; }
	public DragEvent() { }
}

[Value("DragEventInit")]
public partial class DragEventInit : MouseEventInit
{
	[Value("dataTransfer")]
	public DataTransfer? DataTransfer;
}

public partial class Window : EventTarget
{
	[Value("window")]
	public WindowProxy _window { get; }
	[Value("self")]
	public WindowProxy Self { get; }
	[Value("document")]
	public Document Document { get; }
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("location")]
	public Location Location { get; }
	[Value("history")]
	public History History { get; }
	[Value("navigation")]
	public Navigation Navigation { get; }
	[Value("customElements")]
	public CustomElementRegistry CustomElements { get; }
	[Value("locationbar")]
	public BarProp Locationbar { get; }
	[Value("menubar")]
	public BarProp Menubar { get; }
	[Value("personalbar")]
	public BarProp Personalbar { get; }
	[Value("scrollbars")]
	public BarProp Scrollbars { get; }
	[Value("statusbar")]
	public BarProp Statusbar { get; }
	[Value("toolbar")]
	public BarProp Toolbar { get; }
	[Value("status")]
	public DOMString Status { get; set; }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	[Value("closed")]
	public bool Closed { get; }
	[Value("stop")]
	public Undefined Stop() { throw new System.NotImplementedException(); }
	[Value("focus")]
	public Undefined Focus() { throw new System.NotImplementedException(); }
	[Value("blur")]
	public Undefined Blur() { throw new System.NotImplementedException(); }
	[Value("frames")]
	public WindowProxy Frames { get; }
	[Value("length")]
	public ulong Length { get; }
	[Value("top")]
	public WindowProxy? Top { get; }
	[Value("opener")]
	public dynamic Opener { get; set; }
	[Value("parent")]
	public WindowProxy? Parent { get; }
	[Value("frameElement")]
	public Element? FrameElement { get; }
	[Value("open")]
	public WindowProxy? Open(USVString url = default, DOMString target = default, DOMString features = default) { throw new System.NotImplementedException(); }
	
	[Value("navigator")]
	public Navigator Navigator { get; }
	[Value("clientInformation")]
	public Navigator ClientInformation { get; }
	[Value("originAgentCluster")]
	public bool OriginAgentCluster { get; }
	[Value("alert")]
	public Undefined Alert() { throw new System.NotImplementedException(); }
	[Value("alert")]
	public Undefined Alert(DOMString message) { throw new System.NotImplementedException(); }
	[Value("confirm")]
	public bool Confirm(DOMString message = default) { throw new System.NotImplementedException(); }
	[Value("prompt")]
	public DOMString? Prompt(DOMString message = default, DOMString default_ = default) { throw new System.NotImplementedException(); }
	[Value("print")]
	public Undefined Print() { throw new System.NotImplementedException(); }
	[Value("postMessage")]
	public Undefined PostMessage(dynamic message, USVString targetOrigin, List<Object> transfer = default) { throw new System.NotImplementedException(); }
	[Value("postMessage")]
	public Undefined PostMessage(dynamic message, WindowPostMessageOptions options = default) { throw new System.NotImplementedException(); }
}



[Value("WindowPostMessageOptions")]
public partial class WindowPostMessageOptions : StructuredSerializeOptions
{
	[Value("targetOrigin")]
	public USVString TargetOrigin;
}

[Value("BarProp")]
public partial class BarProp
{
	[Value("visible")]
	public bool Visible { get; }
}

[Value("Location")]
public partial class Location
{
	[Value("href")]
	public USVString Href { get; set; }
	[Value("origin")]
	public USVString Origin { get; }
	[Value("protocol")]
	public USVString Protocol { get; set; }
	[Value("host")]
	public USVString Host { get; set; }
	[Value("hostname")]
	public USVString Hostname { get; set; }
	[Value("port")]
	public USVString Port { get; set; }
	[Value("pathname")]
	public USVString Pathname { get; set; }
	[Value("search")]
	public USVString Search { get; set; }
	[Value("hash")]
	public USVString Hash { get; set; }
	[Value("assign")]
	public Undefined Assign(USVString url) { throw new System.NotImplementedException(); }
	[Value("replace")]
	public Undefined Replace(USVString url) { throw new System.NotImplementedException(); }
	[Value("reload")]
	public Undefined Reload() { throw new System.NotImplementedException(); }
	[Value("ancestorOrigins")]
	public DOMStringList AncestorOrigins { get; }
}

[Value("History")]
public partial class History
{
	[Value("length")]
	public ulong Length { get; }
	[Value("scrollRestoration")]
	public ScrollRestoration ScrollRestoration { get; set; }
	[Value("state")]
	public dynamic State { get; }
	[Value("go")]
	public Undefined Go(long delta = default) { throw new System.NotImplementedException(); }
	[Value("back")]
	public Undefined Back() { throw new System.NotImplementedException(); }
	[Value("forward")]
	public Undefined Forward() { throw new System.NotImplementedException(); }
	[Value("pushState")]
	public Undefined PushState(dynamic data, DOMString unused, USVString? url = default) { throw new System.NotImplementedException(); }
	[Value("replaceState")]
	public Undefined ReplaceState(dynamic data, DOMString unused, USVString? url = default) { throw new System.NotImplementedException(); }
}

[Value("Navigation")]
public partial class Navigation : EventTarget
{
	[Value("entries")]
	public List<NavigationHistoryEntry> Entries() { throw new System.NotImplementedException(); }
	[Value("currentEntry")]
	public NavigationHistoryEntry? CurrentEntry { get; }
	[Value("updateCurrentEntry")]
	public Undefined UpdateCurrentEntry(NavigationUpdateCurrentEntryOptions options) { throw new System.NotImplementedException(); }
	[Value("transition")]
	public NavigationTransition? Transition { get; }
	[Value("activation")]
	public NavigationActivation? Activation { get; }
	[Value("canGoBack")]
	public bool CanGoBack { get; }
	[Value("canGoForward")]
	public bool CanGoForward { get; }
	[Value("navigate")]
	public NavigationResult Navigate(USVString url, NavigationNavigateOptions options = default) { throw new System.NotImplementedException(); }
	[Value("reload")]
	public NavigationResult Reload(NavigationReloadOptions options = default) { throw new System.NotImplementedException(); }
	[Value("traverseTo")]
	public NavigationResult TraverseTo(DOMString key, NavigationOptions options = default) { throw new System.NotImplementedException(); }
	[Value("back")]
	public NavigationResult Back(NavigationOptions options = default) { throw new System.NotImplementedException(); }
	[Value("forward")]
	public NavigationResult Forward(NavigationOptions options = default) { throw new System.NotImplementedException(); }
	[Value("onnavigate")]
	public EventHandler Onnavigate { get; set; }
	[Value("onnavigatesuccess")]
	public EventHandler Onnavigatesuccess { get; set; }
	[Value("onnavigateerror")]
	public EventHandler Onnavigateerror { get; set; }
	[Value("oncurrententrychange")]
	public EventHandler Oncurrententrychange { get; set; }
}

[Value("NavigationUpdateCurrentEntryOptions")]
public partial class NavigationUpdateCurrentEntryOptions
{
	[Value("state")]
	public required dynamic State;
}

[Value("NavigationOptions")]
public partial class NavigationOptions
{
	[Value("info")]
	public dynamic Info;
}

[Value("NavigationNavigateOptions")]
public partial class NavigationNavigateOptions : NavigationOptions
{
	[Value("state")]
	public dynamic State;
	[Value("history")]
	public NavigationHistoryBehavior History;
}

[Value("NavigationReloadOptions")]
public partial class NavigationReloadOptions : NavigationOptions
{
	[Value("state")]
	public dynamic State;
}

[Value("NavigationResult")]
public partial class NavigationResult
{
	[Value("committed")]
	public Task<NavigationHistoryEntry> Committed;
	[Value("finished")]
	public Task<NavigationHistoryEntry> Finished;
}

[Value("NavigationHistoryEntry")]
public partial class NavigationHistoryEntry : EventTarget
{
	[Value("url")]
	public USVString? Url { get; }
	[Value("key")]
	public DOMString Key { get; }
	[Value("id")]
	public DOMString Id { get; }
	[Value("index")]
	public long Index { get; }
	[Value("sameDocument")]
	public bool SameDocument { get; }
	[Value("getState")]
	public dynamic GetState() { throw new System.NotImplementedException(); }
	[Value("ondispose")]
	public EventHandler Ondispose { get; set; }
}

[Value("NavigationTransition")]
public partial class NavigationTransition
{
	[Value("navigationType")]
	public NavigationType NavigationType { get; }
	[Value("from")]
	public NavigationHistoryEntry From { get; }
	[Value("finished")]
	public Task<Undefined> Finished { get; }
}

[Value("NavigationActivation")]
public partial class NavigationActivation
{
	[Value("from")]
	public NavigationHistoryEntry? From { get; }
	[Value("entry")]
	public NavigationHistoryEntry Entry { get; }
	[Value("navigationType")]
	public NavigationType NavigationType { get; }
}

[Value("NavigateEvent")]
public partial class NavigateEvent : Event
{
		public NavigateEvent(DOMString type, NavigateEventInit eventInitDict) { }
	[Value("navigationType")]
	public NavigationType NavigationType { get; }
	[Value("destination")]
	public NavigationDestination Destination { get; }
	[Value("canIntercept")]
	public bool CanIntercept { get; }
	[Value("userInitiated")]
	public bool UserInitiated { get; }
	[Value("hashChange")]
	public bool HashChange { get; }
	[Value("signal")]
	public AbortSignal Signal { get; }
	[Value("formData")]
	public FormData? FormData { get; }
	[Value("downloadRequest")]
	public DOMString? DownloadRequest { get; }
	[Value("info")]
	public dynamic Info { get; }
	[Value("hasUAVisualTransition")]
	public bool HasUAVisualTransition { get; }
	[Value("intercept")]
	public Undefined Intercept(NavigationInterceptOptions options = default) { throw new System.NotImplementedException(); }
	[Value("scroll")]
	public Undefined Scroll() { throw new System.NotImplementedException(); }
	public NavigateEvent() { }
}

[Value("NavigateEventInit")]
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

[Value("NavigationInterceptOptions")]
public partial class NavigationInterceptOptions
{
	[Value("handler")]
	public NavigationInterceptHandler Handler;
	[Value("focusReset")]
	public NavigationFocusReset FocusReset;
	[Value("scroll")]
	public NavigationScrollBehavior Scroll;
}

[Value("NavigationDestination")]
public partial class NavigationDestination
{
	[Value("url")]
	public USVString Url { get; }
	[Value("key")]
	public DOMString Key { get; }
	[Value("id")]
	public DOMString Id { get; }
	[Value("index")]
	public long Index { get; }
	[Value("sameDocument")]
	public bool SameDocument { get; }
	[Value("getState")]
	public dynamic GetState() { throw new System.NotImplementedException(); }
}

[Value("NavigationCurrentEntryChangeEvent")]
public partial class NavigationCurrentEntryChangeEvent : Event
{
		public NavigationCurrentEntryChangeEvent(DOMString type, NavigationCurrentEntryChangeEventInit eventInitDict) { }
	[Value("navigationType")]
	public NavigationType? NavigationType { get; }
	[Value("from")]
	public NavigationHistoryEntry From { get; }
	public NavigationCurrentEntryChangeEvent() { }
}

[Value("NavigationCurrentEntryChangeEventInit")]
public partial class NavigationCurrentEntryChangeEventInit : EventInit
{
	[Value("navigationType")]
	public NavigationType? NavigationType;
	[Value("from")]
	public required NavigationHistoryEntry From;
}

[Value("PopStateEvent")]
public partial class PopStateEvent : Event
{
		public PopStateEvent(DOMString type, PopStateEventInit eventInitDict = default) { }
	[Value("state")]
	public dynamic State { get; }
	[Value("hasUAVisualTransition")]
	public bool HasUAVisualTransition { get; }
	public PopStateEvent() { }
}

[Value("PopStateEventInit")]
public partial class PopStateEventInit : EventInit
{
	[Value("state")]
	public dynamic State;
	[Value("hasUAVisualTransition")]
	public bool HasUAVisualTransition;
}

[Value("HashChangeEvent")]
public partial class HashChangeEvent : Event
{
		public HashChangeEvent(DOMString type, HashChangeEventInit eventInitDict = default) { }
	[Value("oldURL")]
	public USVString OldURL { get; }
	[Value("newURL")]
	public USVString NewURL { get; }
	public HashChangeEvent() { }
}

[Value("HashChangeEventInit")]
public partial class HashChangeEventInit : EventInit
{
	[Value("oldURL")]
	public USVString OldURL;
	[Value("newURL")]
	public USVString NewURL;
}

[Value("PageSwapEvent")]
public partial class PageSwapEvent : Event
{
		public PageSwapEvent(DOMString type, PageSwapEventInit eventInitDict = default) { }
	[Value("activation")]
	public NavigationActivation? Activation { get; }
	[Value("viewTransition")]
	public ViewTransition? ViewTransition { get; }
	public PageSwapEvent() { }
}

[Value("PageSwapEventInit")]
public partial class PageSwapEventInit : EventInit
{
	[Value("activation")]
	public NavigationActivation? Activation;
	[Value("viewTransition")]
	public ViewTransition? ViewTransition;
}

[Value("PageRevealEvent")]
public partial class PageRevealEvent : Event
{
		public PageRevealEvent(DOMString type, PageRevealEventInit eventInitDict = default) { }
	[Value("viewTransition")]
	public ViewTransition? ViewTransition { get; }
	public PageRevealEvent() { }
}

[Value("PageRevealEventInit")]
public partial class PageRevealEventInit : EventInit
{
	[Value("viewTransition")]
	public ViewTransition? ViewTransition;
}

[Value("PageTransitionEvent")]
public partial class PageTransitionEvent : Event
{
		public PageTransitionEvent(DOMString type, PageTransitionEventInit eventInitDict = default) { }
	[Value("persisted")]
	public bool Persisted { get; }
	public PageTransitionEvent() { }
}

[Value("PageTransitionEventInit")]
public partial class PageTransitionEventInit : EventInit
{
	[Value("persisted")]
	public bool Persisted;
}

[Value("BeforeUnloadEvent")]
public partial class BeforeUnloadEvent : Event
{
	[Value("returnValue")]
	public DOMString ReturnValue { get; set; }
}

[Value("NotRestoredReasonDetails")]
public partial class NotRestoredReasonDetails
{
	[Value("reason")]
	public DOMString Reason { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

[Value("NotRestoredReasons")]
public partial class NotRestoredReasons
{
	[Value("src")]
	public DOMString? Src { get; }
	[Value("id")]
	public DOMString? Id { get; }
	[Value("name")]
	public DOMString? Name { get; }
	[Value("url")]
	public DOMString? Url { get; }
	[Value("reasons")]
	public NotRestoredReasonDetails[]? Reasons { get; }
	[Value("children")]
	public NotRestoredReasons[]? Children { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

[Value("ErrorEvent")]
public partial class ErrorEvent : Event
{
		public ErrorEvent(DOMString type, ErrorEventInit eventInitDict = default) { }
	[Value("message")]
	public DOMString Message { get; }
	[Value("filename")]
	public USVString Filename { get; }
	[Value("lineno")]
	public ulong Lineno { get; }
	[Value("colno")]
	public ulong Colno { get; }
	[Value("error")]
	public dynamic Error { get; }
	public ErrorEvent() { }
}

[Value("ErrorEventInit")]
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

[Value("PromiseRejectionEvent")]
public partial class PromiseRejectionEvent : Event
{
		public PromiseRejectionEvent(DOMString type, PromiseRejectionEventInit eventInitDict) { }
	[Value("promise")]
	public Object Promise { get; }
	[Value("reason")]
	public dynamic Reason { get; }
	public PromiseRejectionEvent() { }
}

[Value("PromiseRejectionEventInit")]
public partial class PromiseRejectionEventInit : EventInit
{
	[Value("promise")]
	public required Object Promise;
	[Value("reason")]
	public dynamic Reason;
}

public partial class Element
{
	[Value("setHTMLUnsafe")]
	public Undefined SetHTMLUnsafe(Union85 html) { throw new System.NotImplementedException(); }
	[Value("getHTML")]
	public DOMString GetHTML(GetHTMLOptions options = default) { throw new System.NotImplementedException(); }
	[Value("innerHTML")]
	public Union86 InnerHTML { get; set; }
	[Value("outerHTML")]
	public Union87 OuterHTML { get; set; }
	[Value("insertAdjacentHTML")]
	public Undefined InsertAdjacentHTML(DOMString position, Union88 string_) { throw new System.NotImplementedException(); }
}

public partial class ShadowRoot
{
	[Value("setHTMLUnsafe")]
	public Undefined SetHTMLUnsafe(Union89 html) { throw new System.NotImplementedException(); }
	[Value("getHTML")]
	public DOMString GetHTML(GetHTMLOptions options = default) { throw new System.NotImplementedException(); }
	[Value("innerHTML")]
	public Union90 InnerHTML { get; set; }
}

[Value("GetHTMLOptions")]
public partial class GetHTMLOptions
{
	[Value("serializableShadowRoots")]
	public bool SerializableShadowRoots;
	[Value("shadowRoots")]
	public List<ShadowRoot> ShadowRoots;
}

[Value("DOMParser")]
public partial class DOMParser
{
		public DOMParser() { }
	[Value("parseFromString")]
	public Document ParseFromString(Union91 string_, DOMParserSupportedType type) { throw new System.NotImplementedException(); }
}

public partial class Range
{
	[Value("createContextualFragment")]
	public DocumentFragment CreateContextualFragment(Union92 string_) { throw new System.NotImplementedException(); }
}

public partial class Navigator
{
}








[Value("PluginArray")]
public partial class PluginArray
{
	[Value("refresh")]
	public Undefined Refresh() { throw new System.NotImplementedException(); }
	[Value("length")]
	public ulong Length { get; }
	
	
}

[Value("MimeTypeArray")]
public partial class MimeTypeArray
{
	[Value("length")]
	public ulong Length { get; }
	
	
}

[Value("Plugin")]
public partial class Plugin
{
	[Value("name")]
	public DOMString Name { get; }
	[Value("description")]
	public DOMString Description { get; }
	[Value("filename")]
	public DOMString Filename { get; }
	[Value("length")]
	public ulong Length { get; }
	
	
}

[Value("MimeType")]
public partial class MimeType
{
	[Value("type")]
	public DOMString Type { get; }
	[Value("description")]
	public DOMString Description { get; }
	[Value("suffixes")]
	public DOMString Suffixes { get; }
	[Value("enabledPlugin")]
	public Plugin EnabledPlugin { get; }
}

[Value("ImageBitmap")]
public partial class ImageBitmap
{
	[Value("width")]
	public ulong Width { get; }
	[Value("height")]
	public ulong Height { get; }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
}


[Value("ImageBitmapOptions")]
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

[Value("MessageEvent")]
public partial class MessageEvent : Event
{
		public MessageEvent(DOMString type, MessageEventInit eventInitDict = default) { }
	[Value("data")]
	public dynamic Data { get; }
	[Value("origin")]
	public USVString Origin { get; }
	[Value("lastEventId")]
	public DOMString LastEventId { get; }
	[Value("source")]
	public MessageEventSource? Source { get; }
	[Value("ports")]
	public MessagePort[] Ports { get; }
	[Value("initMessageEvent")]
	public Undefined InitMessageEvent(DOMString type, bool bubbles = default, bool cancelable = default, dynamic data = default, USVString origin = default, DOMString lastEventId = default, MessageEventSource? source = default, List<MessagePort> ports = default) { throw new System.NotImplementedException(); }
	public MessageEvent() { }
}

[Value("MessageEventInit")]
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


[Value("EventSource")]
public partial class EventSource : EventTarget
{
		public EventSource(USVString url, EventSourceInit eventSourceInitDict = default) { }
	[Value("url")]
	public USVString Url { get; }
	[Value("withCredentials")]
	public bool WithCredentials { get; }
	[Value("CONNECTING")]
	public const ushort CONNECTING = 0;
	[Value("OPEN")]
	public const ushort OPEN = 1;
	[Value("CLOSED")]
	public const ushort CLOSED = 2;
	[Value("readyState")]
	public ushort ReadyState { get; }
	[Value("onopen")]
	public EventHandler Onopen { get; set; }
	[Value("onmessage")]
	public EventHandler Onmessage { get; set; }
	[Value("onerror")]
	public EventHandler Onerror { get; set; }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	public EventSource() { }
}

[Value("EventSourceInit")]
public partial class EventSourceInit
{
	[Value("withCredentials")]
	public bool WithCredentials;
}

[Value("MessageChannel")]
public partial class MessageChannel
{
		public MessageChannel() { }
	[Value("port1")]
	public MessagePort Port1 { get; }
	[Value("port2")]
	public MessagePort Port2 { get; }
}

[Value("MessagePort")]
public partial class MessagePort : EventTarget, MessageEventTarget
{
	[Value("postMessage")]
	public Undefined PostMessage(dynamic message, List<Object> transfer) { throw new System.NotImplementedException(); }
	[Value("postMessage")]
	public Undefined PostMessage(dynamic message, StructuredSerializeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("start")]
	public Undefined Start() { throw new System.NotImplementedException(); }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	[Value("onclose")]
	public EventHandler Onclose { get; set; }
}


[Value("StructuredSerializeOptions")]
public partial class StructuredSerializeOptions
{
	[Value("transfer")]
	public List<Object> Transfer;
}

[Value("BroadcastChannel")]
public partial class BroadcastChannel : EventTarget
{
		public BroadcastChannel(DOMString name) { }
	[Value("name")]
	public DOMString Name { get; }
	[Value("postMessage")]
	public Undefined PostMessage(dynamic message) { throw new System.NotImplementedException(); }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	[Value("onmessage")]
	public EventHandler Onmessage { get; set; }
	[Value("onmessageerror")]
	public EventHandler Onmessageerror { get; set; }
	public BroadcastChannel() { }
}

[Value("WorkerGlobalScope")]
public partial class WorkerGlobalScope : EventTarget, FontFaceSource, WindowOrWorkerGlobalScope
{
	[Value("self")]
	public WorkerGlobalScope Self { get; }
	[Value("location")]
	public WorkerLocation Location { get; }
	[Value("navigator")]
	public WorkerNavigator Navigator { get; }
	[Value("importScripts")]
	public Undefined ImportScripts(params Union95[] urls) { throw new System.NotImplementedException(); }
	[Value("onerror")]
	public OnErrorEventHandler Onerror { get; set; }
	[Value("onlanguagechange")]
	public EventHandler Onlanguagechange { get; set; }
	[Value("onoffline")]
	public EventHandler Onoffline { get; set; }
	[Value("ononline")]
	public EventHandler Ononline { get; set; }
	[Value("onrejectionhandled")]
	public EventHandler Onrejectionhandled { get; set; }
	[Value("onunhandledrejection")]
	public EventHandler Onunhandledrejection { get; set; }
}

[Value("DedicatedWorkerGlobalScope")]
public partial class DedicatedWorkerGlobalScope : WorkerGlobalScope, AnimationFrameProvider, MessageEventTarget
{
	[Value("name")]
	public DOMString Name { get; }
	[Value("postMessage")]
	public Undefined PostMessage(dynamic message, List<Object> transfer) { throw new System.NotImplementedException(); }
	[Value("postMessage")]
	public Undefined PostMessage(dynamic message, StructuredSerializeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
}


[Value("SharedWorkerGlobalScope")]
public partial class SharedWorkerGlobalScope : WorkerGlobalScope
{
	[Value("name")]
	public DOMString Name { get; }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	[Value("onconnect")]
	public EventHandler Onconnect { get; set; }
}

[Value("Worker")]
public partial class Worker : EventTarget, AbstractWorker, MessageEventTarget
{
		public Worker(Union96 scriptURL, WorkerOptions options = default) { }
	[Value("terminate")]
	public Undefined Terminate() { throw new System.NotImplementedException(); }
	[Value("postMessage")]
	public Undefined PostMessage(dynamic message, List<Object> transfer) { throw new System.NotImplementedException(); }
	[Value("postMessage")]
	public Undefined PostMessage(dynamic message, StructuredSerializeOptions options = default) { throw new System.NotImplementedException(); }
	public Worker() { }
}

[Value("WorkerOptions")]
public partial class WorkerOptions
{
	[Value("type")]
	public WorkerType Type;
	[Value("credentials")]
	public RequestCredentials Credentials;
	[Value("name")]
	public DOMString Name;
}

[Value("SharedWorker")]
public partial class SharedWorker : EventTarget, AbstractWorker
{
		public SharedWorker(Union97 scriptURL, Union98 options = default) { }
	[Value("port")]
	public MessagePort Port { get; }
	public SharedWorker() { }
}


[Value("WorkerNavigator")]
public partial class WorkerNavigator
{
}





[Value("WorkerLocation")]
public partial class WorkerLocation
{
	[Value("href")]
	public USVString Href { get; }
	[Value("origin")]
	public USVString Origin { get; }
	[Value("protocol")]
	public USVString Protocol { get; }
	[Value("host")]
	public USVString Host { get; }
	[Value("hostname")]
	public USVString Hostname { get; }
	[Value("port")]
	public USVString Port { get; }
	[Value("pathname")]
	public USVString Pathname { get; }
	[Value("search")]
	public USVString Search { get; }
	[Value("hash")]
	public USVString Hash { get; }
}

[Value("WorkletGlobalScope")]
public partial class WorkletGlobalScope
{
}

[Value("Worklet")]
public partial class Worklet
{
	[Value("addModule")]
	public Task<Undefined> AddModule(USVString moduleURL, WorkletOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("WorkletOptions")]
public partial class WorkletOptions
{
	[Value("credentials")]
	public RequestCredentials Credentials;
}

[Value("Storage")]
public partial class Storage
{
	[Value("length")]
	public ulong Length { get; }
	[Value("key")]
	public DOMString? Key(ulong index) { throw new System.NotImplementedException(); }
	
	
	
	[Value("clear")]
	public Undefined Clear() { throw new System.NotImplementedException(); }
}

[Value("StorageEvent")]
public partial class StorageEvent : Event
{
		public StorageEvent(DOMString type, StorageEventInit eventInitDict = default) { }
	[Value("key")]
	public DOMString? Key { get; }
	[Value("oldValue")]
	public DOMString? OldValue { get; }
	[Value("newValue")]
	public DOMString? NewValue { get; }
	[Value("url")]
	public USVString Url { get; }
	[Value("storageArea")]
	public Storage? StorageArea { get; }
	[Value("initStorageEvent")]
	public Undefined InitStorageEvent(DOMString type, bool bubbles = default, bool cancelable = default, DOMString? key = default, DOMString? oldValue = default, DOMString? newValue = default, USVString url = default, Storage? storageArea = default) { throw new System.NotImplementedException(); }
	public StorageEvent() { }
}

[Value("StorageEventInit")]
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

[Value("HTMLMarqueeElement")]
public partial class HTMLMarqueeElement : HTMLElement
{
		public HTMLMarqueeElement() { }
	[Value("behavior")]
	public DOMString Behavior { get; set; }
	[Value("bgColor")]
	public DOMString BgColor { get; set; }
	[Value("direction")]
	public DOMString Direction { get; set; }
	[Value("height")]
	public DOMString Height { get; set; }
	[Value("hspace")]
	public ulong Hspace { get; set; }
	[Value("loop")]
	public long Loop { get; set; }
	[Value("scrollAmount")]
	public ulong ScrollAmount { get; set; }
	[Value("scrollDelay")]
	public ulong ScrollDelay { get; set; }
	[Value("trueSpeed")]
	public bool TrueSpeed { get; set; }
	[Value("vspace")]
	public ulong Vspace { get; set; }
	[Value("width")]
	public DOMString Width { get; set; }
	[Value("start")]
	public Undefined Start() { throw new System.NotImplementedException(); }
	[Value("stop")]
	public Undefined Stop() { throw new System.NotImplementedException(); }
}

[Value("HTMLFrameSetElement")]
public partial class HTMLFrameSetElement : HTMLElement, WindowEventHandlers
{
		public HTMLFrameSetElement() { }
	[Value("cols")]
	public DOMString Cols { get; set; }
	[Value("rows")]
	public DOMString Rows { get; set; }
}


[Value("HTMLFrameElement")]
public partial class HTMLFrameElement : HTMLElement
{
		public HTMLFrameElement() { }
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("scrolling")]
	public DOMString Scrolling { get; set; }
	[Value("src")]
	public USVString Src { get; set; }
	[Value("frameBorder")]
	public DOMString FrameBorder { get; set; }
	[Value("longDesc")]
	public USVString LongDesc { get; set; }
	[Value("noResize")]
	public bool NoResize { get; set; }
	[Value("contentDocument")]
	public Document? ContentDocument { get; }
	[Value("contentWindow")]
	public WindowProxy? ContentWindow { get; }
	[Value("marginHeight")]
	public DOMString MarginHeight { get; set; }
	[Value("marginWidth")]
	public DOMString MarginWidth { get; set; }
}

public partial class HTMLAnchorElement
{
	[Value("coords")]
	public DOMString Coords { get; set; }
	[Value("charset")]
	public DOMString Charset { get; set; }
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("rev")]
	public DOMString Rev { get; set; }
	[Value("shape")]
	public DOMString Shape { get; set; }
}

public partial class HTMLAreaElement
{
	[Value("noHref")]
	public bool NoHref { get; set; }
}

public partial class HTMLBodyElement
{
	[Value("text")]
	public DOMString Text { get; set; }
	[Value("link")]
	public DOMString Link { get; set; }
	[Value("vLink")]
	public DOMString VLink { get; set; }
	[Value("aLink")]
	public DOMString ALink { get; set; }
	[Value("bgColor")]
	public DOMString BgColor { get; set; }
	[Value("background")]
	public DOMString Background { get; set; }
}

public partial class HTMLBRElement
{
	[Value("clear")]
	public DOMString Clear { get; set; }
}

public partial class HTMLTableCaptionElement
{
	[Value("align")]
	public DOMString Align { get; set; }
}

public partial class HTMLTableColElement
{
	[Value("align")]
	public DOMString Align { get; set; }
	[Value("ch")]
	public DOMString Ch { get; set; }
	[Value("chOff")]
	public DOMString ChOff { get; set; }
	[Value("vAlign")]
	public DOMString VAlign { get; set; }
	[Value("width")]
	public DOMString Width { get; set; }
}

[Value("HTMLDirectoryElement")]
public partial class HTMLDirectoryElement : HTMLElement
{
		public HTMLDirectoryElement() { }
	[Value("compact")]
	public bool Compact { get; set; }
}

public partial class HTMLDivElement
{
	[Value("align")]
	public DOMString Align { get; set; }
}

public partial class HTMLDListElement
{
	[Value("compact")]
	public bool Compact { get; set; }
}

public partial class HTMLEmbedElement
{
	[Value("align")]
	public DOMString Align { get; set; }
	[Value("name")]
	public DOMString Name { get; set; }
}

[Value("HTMLFontElement")]
public partial class HTMLFontElement : HTMLElement
{
		public HTMLFontElement() { }
	[Value("color")]
	public DOMString Color { get; set; }
	[Value("face")]
	public DOMString Face { get; set; }
	[Value("size")]
	public DOMString Size { get; set; }
}

public partial class HTMLHeadingElement
{
	[Value("align")]
	public DOMString Align { get; set; }
}

public partial class HTMLHRElement
{
	[Value("align")]
	public DOMString Align { get; set; }
	[Value("color")]
	public DOMString Color { get; set; }
	[Value("noShade")]
	public bool NoShade { get; set; }
	[Value("size")]
	public DOMString Size { get; set; }
	[Value("width")]
	public DOMString Width { get; set; }
}

public partial class HTMLHtmlElement
{
	[Value("version")]
	public DOMString Version { get; set; }
}

public partial class HTMLIFrameElement
{
	[Value("align")]
	public DOMString Align { get; set; }
	[Value("scrolling")]
	public DOMString Scrolling { get; set; }
	[Value("frameBorder")]
	public DOMString FrameBorder { get; set; }
	[Value("longDesc")]
	public USVString LongDesc { get; set; }
	[Value("marginHeight")]
	public DOMString MarginHeight { get; set; }
	[Value("marginWidth")]
	public DOMString MarginWidth { get; set; }
}

public partial class HTMLImageElement
{
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("lowsrc")]
	public USVString Lowsrc { get; set; }
	[Value("align")]
	public DOMString Align { get; set; }
	[Value("hspace")]
	public ulong Hspace { get; set; }
	[Value("vspace")]
	public ulong Vspace { get; set; }
	[Value("longDesc")]
	public USVString LongDesc { get; set; }
	[Value("border")]
	public DOMString Border { get; set; }
}

public partial class HTMLInputElement
{
	[Value("align")]
	public DOMString Align { get; set; }
	[Value("useMap")]
	public DOMString UseMap { get; set; }
}

public partial class HTMLLegendElement
{
	[Value("align")]
	public DOMString Align { get; set; }
}

public partial class HTMLLIElement
{
	[Value("type")]
	public DOMString Type { get; set; }
}

public partial class HTMLLinkElement
{
	[Value("charset")]
	public DOMString Charset { get; set; }
	[Value("rev")]
	public DOMString Rev { get; set; }
	[Value("target")]
	public DOMString Target { get; set; }
}

public partial class HTMLMenuElement
{
	[Value("compact")]
	public bool Compact { get; set; }
}

public partial class HTMLMetaElement
{
	[Value("scheme")]
	public DOMString Scheme { get; set; }
}

public partial class HTMLObjectElement
{
	[Value("align")]
	public DOMString Align { get; set; }
	[Value("archive")]
	public DOMString Archive { get; set; }
	[Value("code")]
	public DOMString Code { get; set; }
	[Value("declare")]
	public bool Declare { get; set; }
	[Value("hspace")]
	public ulong Hspace { get; set; }
	[Value("standby")]
	public DOMString Standby { get; set; }
	[Value("vspace")]
	public ulong Vspace { get; set; }
	[Value("codeBase")]
	public DOMString CodeBase { get; set; }
	[Value("codeType")]
	public DOMString CodeType { get; set; }
	[Value("useMap")]
	public DOMString UseMap { get; set; }
	[Value("border")]
	public DOMString Border { get; set; }
}

public partial class HTMLOListElement
{
	[Value("compact")]
	public bool Compact { get; set; }
}

public partial class HTMLParagraphElement
{
	[Value("align")]
	public DOMString Align { get; set; }
}

[Value("HTMLParamElement")]
public partial class HTMLParamElement : HTMLElement
{
		public HTMLParamElement() { }
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("value")]
	public DOMString Value { get; set; }
	[Value("type")]
	public DOMString Type { get; set; }
	[Value("valueType")]
	public DOMString ValueType { get; set; }
}

public partial class HTMLPreElement
{
	[Value("width")]
	public long Width { get; set; }
}

public partial class HTMLStyleElement
{
	[Value("type")]
	public DOMString Type { get; set; }
}

public partial class HTMLScriptElement
{
	[Value("charset")]
	public DOMString Charset { get; set; }
	[Value("event")]
	public DOMString Event { get; set; }
	[Value("htmlFor")]
	public DOMString HtmlFor { get; set; }
}

public partial class HTMLTableElement
{
	[Value("align")]
	public DOMString Align { get; set; }
	[Value("border")]
	public DOMString Border { get; set; }
	[Value("frame")]
	public DOMString Frame { get; set; }
	[Value("rules")]
	public DOMString Rules { get; set; }
	[Value("summary")]
	public DOMString Summary { get; set; }
	[Value("width")]
	public DOMString Width { get; set; }
	[Value("bgColor")]
	public DOMString BgColor { get; set; }
	[Value("cellPadding")]
	public DOMString CellPadding { get; set; }
	[Value("cellSpacing")]
	public DOMString CellSpacing { get; set; }
}

public partial class HTMLTableSectionElement
{
	[Value("align")]
	public DOMString Align { get; set; }
	[Value("ch")]
	public DOMString Ch { get; set; }
	[Value("chOff")]
	public DOMString ChOff { get; set; }
	[Value("vAlign")]
	public DOMString VAlign { get; set; }
}

public partial class HTMLTableCellElement
{
	[Value("align")]
	public DOMString Align { get; set; }
	[Value("axis")]
	public DOMString Axis { get; set; }
	[Value("height")]
	public DOMString Height { get; set; }
	[Value("width")]
	public DOMString Width { get; set; }
	[Value("ch")]
	public DOMString Ch { get; set; }
	[Value("chOff")]
	public DOMString ChOff { get; set; }
	[Value("noWrap")]
	public bool NoWrap { get; set; }
	[Value("vAlign")]
	public DOMString VAlign { get; set; }
	[Value("bgColor")]
	public DOMString BgColor { get; set; }
}

public partial class HTMLTableRowElement
{
	[Value("align")]
	public DOMString Align { get; set; }
	[Value("ch")]
	public DOMString Ch { get; set; }
	[Value("chOff")]
	public DOMString ChOff { get; set; }
	[Value("vAlign")]
	public DOMString VAlign { get; set; }
	[Value("bgColor")]
	public DOMString BgColor { get; set; }
}

public partial class HTMLUListElement
{
	[Value("compact")]
	public bool Compact { get; set; }
	[Value("type")]
	public DOMString Type { get; set; }
}

public partial class Document
{
	[Value("fgColor")]
	public DOMString FgColor { get; set; }
	[Value("linkColor")]
	public DOMString LinkColor { get; set; }
	[Value("vlinkColor")]
	public DOMString VlinkColor { get; set; }
	[Value("alinkColor")]
	public DOMString AlinkColor { get; set; }
	[Value("bgColor")]
	public DOMString BgColor { get; set; }
	[Value("anchors")]
	public HTMLCollection Anchors { get; }
	[Value("applets")]
	public HTMLCollection Applets { get; }
	[Value("clear")]
	public Undefined Clear() { throw new System.NotImplementedException(); }
	[Value("captureEvents")]
	public Undefined CaptureEvents() { throw new System.NotImplementedException(); }
	[Value("releaseEvents")]
	public Undefined ReleaseEvents() { throw new System.NotImplementedException(); }
	[Value("all")]
	public HTMLAllCollection All { get; }
}

public partial class Window
{
	[Value("captureEvents")]
	public Undefined CaptureEvents() { throw new System.NotImplementedException(); }
	[Value("releaseEvents")]
	public Undefined ReleaseEvents() { throw new System.NotImplementedException(); }
	[Value("external")]
	public External External { get; }
}

[Value("External")]
public partial class External
{
	[Value("AddSearchProvider")]
	public Undefined AddSearchProvider() { throw new System.NotImplementedException(); }
	[Value("IsSearchProviderInstalled")]
	public Undefined IsSearchProviderInstalled() { throw new System.NotImplementedException(); }
}

[Value("IdleOptions")]
public partial class IdleOptions
{
	[Value("threshold")]
	public ulong Threshold;
	[Value("signal")]
	public AbortSignal Signal;
}

[Value("IdleDetector")]
public partial class IdleDetector : EventTarget
{
		public IdleDetector() { }
	[Value("userState")]
	public UserIdleState? UserState { get; }
	[Value("screenState")]
	public ScreenIdleState? ScreenState { get; }
	[Value("onchange")]
	public EventHandler Onchange { get; set; }
	[Value("requestPermission")]
	public static Task<PermissionState> RequestPermission() { throw new System.NotImplementedException(); }
	[Value("start")]
	public Task<Undefined> Start(IdleOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("ImageCapture")]
public partial class ImageCapture
{
		public ImageCapture(MediaStreamTrack videoTrack) { }
	[Value("takePhoto")]
	public Task<Blob> TakePhoto(PhotoSettings photoSettings = default) { throw new System.NotImplementedException(); }
	[Value("getPhotoCapabilities")]
	public Task<PhotoCapabilities> GetPhotoCapabilities() { throw new System.NotImplementedException(); }
	[Value("getPhotoSettings")]
	public Task<PhotoSettings> GetPhotoSettings() { throw new System.NotImplementedException(); }
	[Value("grabFrame")]
	public Task<ImageBitmap> GrabFrame() { throw new System.NotImplementedException(); }
	[Value("track")]
	public MediaStreamTrack Track { get; }
	public ImageCapture() { }
}

[Value("PhotoCapabilities")]
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

[Value("PhotoSettings")]
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

[Value("MediaSettingsRange")]
public partial class MediaSettingsRange
{
	[Value("max")]
	public Number Max;
	[Value("min")]
	public Number Min;
	[Value("step")]
	public Number Step;
}

[Value("MediaTrackSupportedConstraints")]
public partial class MediaTrackSupportedConstraints
{
	[Value("whiteBalanceMode")]
	public bool WhiteBalanceMode;
	[Value("exposureMode")]
	public bool ExposureMode;
	[Value("focusMode")]
	public bool FocusMode;
	[Value("pointsOfInterest")]
	public bool PointsOfInterest;
	[Value("exposureCompensation")]
	public bool ExposureCompensation;
	[Value("exposureTime")]
	public bool ExposureTime;
	[Value("colorTemperature")]
	public bool ColorTemperature;
	[Value("iso")]
	public bool Iso;
	[Value("brightness")]
	public bool Brightness;
	[Value("contrast")]
	public bool Contrast;
	[Value("pan")]
	public bool Pan;
	[Value("saturation")]
	public bool Saturation;
	[Value("sharpness")]
	public bool Sharpness;
	[Value("focusDistance")]
	public bool FocusDistance;
	[Value("tilt")]
	public bool Tilt;
	[Value("zoom")]
	public bool Zoom;
	[Value("torch")]
	public bool Torch;
}

[Value("MediaTrackCapabilities")]
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

[Value("MediaTrackConstraintSet")]
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

[Value("MediaTrackSettings")]
public partial class MediaTrackSettings
{
	[Value("whiteBalanceMode")]
	public DOMString WhiteBalanceMode;
	[Value("exposureMode")]
	public DOMString ExposureMode;
	[Value("focusMode")]
	public DOMString FocusMode;
	[Value("pointsOfInterest")]
	public List<Point2D> PointsOfInterest;
	[Value("exposureCompensation")]
	public Number ExposureCompensation;
	[Value("exposureTime")]
	public Number ExposureTime;
	[Value("colorTemperature")]
	public Number ColorTemperature;
	[Value("iso")]
	public Number Iso;
	[Value("brightness")]
	public Number Brightness;
	[Value("contrast")]
	public Number Contrast;
	[Value("saturation")]
	public Number Saturation;
	[Value("sharpness")]
	public Number Sharpness;
	[Value("focusDistance")]
	public Number FocusDistance;
	[Value("pan")]
	public Number Pan;
	[Value("tilt")]
	public Number Tilt;
	[Value("zoom")]
	public Number Zoom;
	[Value("torch")]
	public bool Torch;
}

[Value("ConstrainPoint2DParameters")]
public partial class ConstrainPoint2DParameters
{
	[Value("exact")]
	public List<Point2D> Exact;
	[Value("ideal")]
	public List<Point2D> Ideal;
}


[Value("Point2D")]
public partial class Point2D
{
	[Value("x")]
	public Number X;
	[Value("y")]
	public Number Y;
}

[Value("ImageResource")]
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

[Value("IDBRequest")]
public partial class IDBRequest : EventTarget
{
	[Value("result")]
	public dynamic Result { get; }
	[Value("error")]
	public DOMException? Error { get; }
	[Value("source")]
	public Union103? Source { get; }
	[Value("transaction")]
	public IDBTransaction? Transaction { get; }
	[Value("readyState")]
	public IDBRequestReadyState ReadyState { get; }
	[Value("onsuccess")]
	public EventHandler Onsuccess { get; set; }
	[Value("onerror")]
	public EventHandler Onerror { get; set; }
}

[Value("IDBOpenDBRequest")]
public partial class IDBOpenDBRequest : IDBRequest
{
	[Value("onblocked")]
	public EventHandler Onblocked { get; set; }
	[Value("onupgradeneeded")]
	public EventHandler Onupgradeneeded { get; set; }
}

[Value("IDBVersionChangeEvent")]
public partial class IDBVersionChangeEvent : Event
{
		public IDBVersionChangeEvent(DOMString type, IDBVersionChangeEventInit eventInitDict = default) { }
	[Value("oldVersion")]
	public ulong OldVersion { get; }
	[Value("newVersion")]
	public ulong? NewVersion { get; }
	public IDBVersionChangeEvent() { }
}

[Value("IDBVersionChangeEventInit")]
public partial class IDBVersionChangeEventInit : EventInit
{
	[Value("oldVersion")]
	public ulong OldVersion;
	[Value("newVersion")]
	public ulong? NewVersion;
}

[Value("IDBFactory")]
public partial class IDBFactory
{
	[Value("open")]
	public IDBOpenDBRequest Open(DOMString name, ulong version = default) { throw new System.NotImplementedException(); }
	[Value("deleteDatabase")]
	public IDBOpenDBRequest DeleteDatabase(DOMString name) { throw new System.NotImplementedException(); }
	[Value("databases")]
	public Task<List<IDBDatabaseInfo>> Databases() { throw new System.NotImplementedException(); }
	[Value("cmp")]
	public Number Cmp(dynamic first, dynamic second) { throw new System.NotImplementedException(); }
}

[Value("IDBDatabaseInfo")]
public partial class IDBDatabaseInfo
{
	[Value("name")]
	public DOMString Name;
	[Value("version")]
	public ulong Version;
}

[Value("IDBDatabase")]
public partial class IDBDatabase : EventTarget
{
	[Value("name")]
	public DOMString Name { get; }
	[Value("version")]
	public ulong Version { get; }
	[Value("objectStoreNames")]
	public DOMStringList ObjectStoreNames { get; }
	[Value("transaction")]
	public IDBTransaction Transaction(Union104 storeNames, IDBTransactionMode mode = default, IDBTransactionOptions options = default) { throw new System.NotImplementedException(); }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	[Value("createObjectStore")]
	public IDBObjectStore CreateObjectStore(DOMString name, IDBObjectStoreParameters options = default) { throw new System.NotImplementedException(); }
	[Value("deleteObjectStore")]
	public Undefined DeleteObjectStore(DOMString name) { throw new System.NotImplementedException(); }
	[Value("onabort")]
	public EventHandler Onabort { get; set; }
	[Value("onclose")]
	public EventHandler Onclose { get; set; }
	[Value("onerror")]
	public EventHandler Onerror { get; set; }
	[Value("onversionchange")]
	public EventHandler Onversionchange { get; set; }
}

[Value("IDBTransactionOptions")]
public partial class IDBTransactionOptions
{
	[Value("durability")]
	public IDBTransactionDurability Durability;
}

[Value("IDBObjectStoreParameters")]
public partial class IDBObjectStoreParameters
{
	[Value("keyPath")]
	public Union105? KeyPath;
	[Value("autoIncrement")]
	public bool AutoIncrement;
}

[Value("IDBObjectStore")]
public partial class IDBObjectStore
{
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("keyPath")]
	public dynamic KeyPath { get; }
	[Value("indexNames")]
	public DOMStringList IndexNames { get; }
	[Value("transaction")]
	public IDBTransaction Transaction { get; }
	[Value("autoIncrement")]
	public bool AutoIncrement { get; }
	[Value("put")]
	public IDBRequest Put(dynamic value, dynamic key = default) { throw new System.NotImplementedException(); }
	[Value("add")]
	public IDBRequest Add(dynamic value, dynamic key = default) { throw new System.NotImplementedException(); }
	[Value("delete")]
	public IDBRequest Delete(dynamic query) { throw new System.NotImplementedException(); }
	[Value("clear")]
	public IDBRequest Clear() { throw new System.NotImplementedException(); }
	[Value("get")]
	public IDBRequest Get(dynamic query) { throw new System.NotImplementedException(); }
	[Value("getKey")]
	public IDBRequest GetKey(dynamic query) { throw new System.NotImplementedException(); }
	[Value("getAll")]
	public IDBRequest GetAll(dynamic query = default, ulong count = default) { throw new System.NotImplementedException(); }
	[Value("getAllKeys")]
	public IDBRequest GetAllKeys(dynamic query = default, ulong count = default) { throw new System.NotImplementedException(); }
	[Value("count")]
	public IDBRequest Count(dynamic query = default) { throw new System.NotImplementedException(); }
	[Value("openCursor")]
	public IDBRequest OpenCursor(dynamic query = default, IDBCursorDirection direction = default) { throw new System.NotImplementedException(); }
	[Value("openKeyCursor")]
	public IDBRequest OpenKeyCursor(dynamic query = default, IDBCursorDirection direction = default) { throw new System.NotImplementedException(); }
	[Value("index")]
	public IDBIndex Index(DOMString name) { throw new System.NotImplementedException(); }
	[Value("createIndex")]
	public IDBIndex CreateIndex(DOMString name, Union106 keyPath, IDBIndexParameters options = default) { throw new System.NotImplementedException(); }
	[Value("deleteIndex")]
	public Undefined DeleteIndex(DOMString name) { throw new System.NotImplementedException(); }
}

[Value("IDBIndexParameters")]
public partial class IDBIndexParameters
{
	[Value("unique")]
	public bool Unique;
	[Value("multiEntry")]
	public bool MultiEntry;
}

[Value("IDBIndex")]
public partial class IDBIndex
{
	[Value("name")]
	public DOMString Name { get; set; }
	[Value("objectStore")]
	public IDBObjectStore ObjectStore { get; }
	[Value("keyPath")]
	public dynamic KeyPath { get; }
	[Value("multiEntry")]
	public bool MultiEntry { get; }
	[Value("unique")]
	public bool Unique { get; }
	[Value("get")]
	public IDBRequest Get(dynamic query) { throw new System.NotImplementedException(); }
	[Value("getKey")]
	public IDBRequest GetKey(dynamic query) { throw new System.NotImplementedException(); }
	[Value("getAll")]
	public IDBRequest GetAll(dynamic query = default, ulong count = default) { throw new System.NotImplementedException(); }
	[Value("getAllKeys")]
	public IDBRequest GetAllKeys(dynamic query = default, ulong count = default) { throw new System.NotImplementedException(); }
	[Value("count")]
	public IDBRequest Count(dynamic query = default) { throw new System.NotImplementedException(); }
	[Value("openCursor")]
	public IDBRequest OpenCursor(dynamic query = default, IDBCursorDirection direction = default) { throw new System.NotImplementedException(); }
	[Value("openKeyCursor")]
	public IDBRequest OpenKeyCursor(dynamic query = default, IDBCursorDirection direction = default) { throw new System.NotImplementedException(); }
}

[Value("IDBKeyRange")]
public partial class IDBKeyRange
{
	[Value("lower")]
	public dynamic Lower { get; }
	[Value("upper")]
	public dynamic Upper { get; }
	[Value("lowerOpen")]
	public bool LowerOpen { get; }
	[Value("upperOpen")]
	public bool UpperOpen { get; }
	[Value("only")]
	public static IDBKeyRange Only(dynamic value) { throw new System.NotImplementedException(); }
	[Value("lowerBound")]
	public static IDBKeyRange LowerBound(dynamic lower, bool open = default) { throw new System.NotImplementedException(); }
	[Value("upperBound")]
	public static IDBKeyRange UpperBound(dynamic upper, bool open = default) { throw new System.NotImplementedException(); }
	[Value("bound")]
	public static IDBKeyRange Bound(dynamic lower, dynamic upper, bool lowerOpen = default, bool upperOpen = default) { throw new System.NotImplementedException(); }
	[Value("includes")]
	public bool Includes(dynamic key) { throw new System.NotImplementedException(); }
}

[Value("IDBCursor")]
public partial class IDBCursor
{
	[Value("source")]
	public Union107 Source { get; }
	[Value("direction")]
	public IDBCursorDirection Direction { get; }
	[Value("key")]
	public dynamic Key { get; }
	[Value("primaryKey")]
	public dynamic PrimaryKey { get; }
	[Value("request")]
	public IDBRequest Request { get; }
	[Value("advance")]
	public Undefined Advance(ulong count) { throw new System.NotImplementedException(); }
	[Value("continue")]
	public Undefined Continue(dynamic key = default) { throw new System.NotImplementedException(); }
	[Value("continuePrimaryKey")]
	public Undefined ContinuePrimaryKey(dynamic key, dynamic primaryKey) { throw new System.NotImplementedException(); }
	[Value("update")]
	public IDBRequest Update(dynamic value) { throw new System.NotImplementedException(); }
	[Value("delete")]
	public IDBRequest Delete() { throw new System.NotImplementedException(); }
}

[Value("IDBCursorWithValue")]
public partial class IDBCursorWithValue : IDBCursor
{
	[Value("value")]
	public dynamic Value { get; }
}

[Value("IDBTransaction")]
public partial class IDBTransaction : EventTarget
{
	[Value("objectStoreNames")]
	public DOMStringList ObjectStoreNames { get; }
	[Value("mode")]
	public IDBTransactionMode Mode { get; }
	[Value("durability")]
	public IDBTransactionDurability Durability { get; }
	[Value("db")]
	public IDBDatabase Db { get; }
	[Value("error")]
	public DOMException? Error { get; }
	[Value("objectStore")]
	public IDBObjectStore ObjectStore(DOMString name) { throw new System.NotImplementedException(); }
	[Value("commit")]
	public Undefined Commit() { throw new System.NotImplementedException(); }
	[Value("abort")]
	public Undefined Abort() { throw new System.NotImplementedException(); }
	[Value("onabort")]
	public EventHandler Onabort { get; set; }
	[Value("oncomplete")]
	public EventHandler Oncomplete { get; set; }
	[Value("onerror")]
	public EventHandler Onerror { get; set; }
}

[Value("Ink")]
public partial class Ink
{
	[Value("requestPresenter")]
	public Task<DelegatedInkTrailPresenter> RequestPresenter(InkPresenterParam param = default) { throw new System.NotImplementedException(); }
}

[Value("InkPresenterParam")]
public partial class InkPresenterParam
{
	[Value("presentationArea")]
	public Element? PresentationArea;
}

[Value("DelegatedInkTrailPresenter")]
public partial class DelegatedInkTrailPresenter
{
	[Value("presentationArea")]
	public Element? PresentationArea { get; }
	[Value("updateInkTrailStartPoint")]
	public Undefined UpdateInkTrailStartPoint(PointerEvent event_, InkTrailStyle style) { throw new System.NotImplementedException(); }
}

[Value("InkTrailStyle")]
public partial class InkTrailStyle
{
	[Value("color")]
	public required DOMString Color;
	[Value("diameter")]
	public required double Diameter;
}

public partial class Navigator
{
	[Value("ink")]
	public Ink Ink { get; }
}

[Value("InputDeviceCapabilities")]
public partial class InputDeviceCapabilities
{
		public InputDeviceCapabilities(InputDeviceCapabilitiesInit deviceInitDict = default) { }
	[Value("firesTouchEvents")]
	public bool FiresTouchEvents { get; }
	[Value("pointerMovementScrolls")]
	public bool PointerMovementScrolls { get; }
	public InputDeviceCapabilities() { }
}

[Value("InputDeviceCapabilitiesInit")]
public partial class InputDeviceCapabilitiesInit
{
	[Value("firesTouchEvents")]
	public bool FiresTouchEvents;
	[Value("pointerMovementScrolls")]
	public bool PointerMovementScrolls;
}

[Value("UIEvent")]
public partial class UIEvent
{
	[Value("sourceCapabilities")]
	public InputDeviceCapabilities? SourceCapabilities { get; }
}

[Value("UIEventInit")]
public partial class UIEventInit
{
	[Value("sourceCapabilities")]
	public InputDeviceCapabilities? SourceCapabilities;
}

[Value("InputEvent")]
public partial class InputEvent
{
	[Value("dataTransfer")]
	public DataTransfer? DataTransfer { get; }
	[Value("getTargetRanges")]
	public List<StaticRange> GetTargetRanges() { throw new System.NotImplementedException(); }
}

[Value("InputEventInit")]
public partial class InputEventInit
{
	[Value("dataTransfer")]
	public DataTransfer? DataTransfer;
	[Value("targetRanges")]
	public List<StaticRange> TargetRanges;
}

[Value("IntersectionObserver")]
public partial class IntersectionObserver
{
		public IntersectionObserver(IntersectionObserverCallback callback, IntersectionObserverInit options = default) { }
	[Value("root")]
	public Union108? Root { get; }
	[Value("rootMargin")]
	public DOMString RootMargin { get; }
	[Value("scrollMargin")]
	public DOMString ScrollMargin { get; }
	[Value("thresholds")]
	public Number[] Thresholds { get; }
	[Value("delay")]
	public long Delay { get; }
	[Value("trackVisibility")]
	public bool TrackVisibility { get; }
	[Value("observe")]
	public Undefined Observe(Element target) { throw new System.NotImplementedException(); }
	[Value("unobserve")]
	public Undefined Unobserve(Element target) { throw new System.NotImplementedException(); }
	[Value("disconnect")]
	public Undefined Disconnect() { throw new System.NotImplementedException(); }
	[Value("takeRecords")]
	public List<IntersectionObserverEntry> TakeRecords() { throw new System.NotImplementedException(); }
	public IntersectionObserver() { }
}

[Value("IntersectionObserverEntry")]
public partial class IntersectionObserverEntry
{
		public IntersectionObserverEntry(IntersectionObserverEntryInit intersectionObserverEntryInit) { }
	[Value("time")]
	public DOMHighResTimeStamp Time { get; }
	[Value("rootBounds")]
	public DOMRectReadOnly? RootBounds { get; }
	[Value("boundingClientRect")]
	public DOMRectReadOnly BoundingClientRect { get; }
	[Value("intersectionRect")]
	public DOMRectReadOnly IntersectionRect { get; }
	[Value("isIntersecting")]
	public bool IsIntersecting { get; }
	[Value("isVisible")]
	public bool IsVisible { get; }
	[Value("intersectionRatio")]
	public Number IntersectionRatio { get; }
	[Value("target")]
	public Element Target { get; }
	public IntersectionObserverEntry() { }
}

[Value("IntersectionObserverEntryInit")]
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

[Value("IntersectionObserverInit")]
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

[Value("InterventionReportBody")]
public partial class InterventionReportBody : ReportBody
{
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
	[Value("id")]
	public DOMString Id { get; }
	[Value("message")]
	public DOMString Message { get; }
	[Value("sourceFile")]
	public DOMString? SourceFile { get; }
	[Value("lineNumber")]
	public ulong? LineNumber { get; }
	[Value("columnNumber")]
	public ulong? ColumnNumber { get; }
}

[Value("IsInputPendingOptions")]
public partial class IsInputPendingOptions
{
	[Value("includeContinuous")]
	public bool IncludeContinuous;
}

[Value("Scheduling")]
public partial class Scheduling
{
	[Value("isInputPending")]
	public bool IsInputPending(IsInputPendingOptions isInputPendingOptions = default) { throw new System.NotImplementedException(); }
}

public partial class Navigator
{
	[Value("scheduling")]
	public Scheduling Scheduling { get; }
}

[Value("Profiler")]
public partial class Profiler : EventTarget
{
	[Value("sampleInterval")]
	public DOMHighResTimeStamp SampleInterval { get; }
	[Value("stopped")]
	public bool Stopped { get; }
		public Profiler(ProfilerInitOptions options) { }
	[Value("stop")]
	public Task<ProfilerTrace> Stop() { throw new System.NotImplementedException(); }
	public Profiler() { }
}


[Value("ProfilerTrace")]
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

[Value("ProfilerSample")]
public partial class ProfilerSample
{
	[Value("timestamp")]
	public required DOMHighResTimeStamp Timestamp;
	[Value("stackId")]
	public ulong StackId;
}

[Value("ProfilerStack")]
public partial class ProfilerStack
{
	[Value("parentId")]
	public ulong ParentId;
	[Value("frameId")]
	public required ulong FrameId;
}

[Value("ProfilerFrame")]
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

[Value("ProfilerInitOptions")]
public partial class ProfilerInitOptions
{
	[Value("sampleInterval")]
	public required DOMHighResTimeStamp SampleInterval;
	[Value("maxBufferSize")]
	public required ulong MaxBufferSize;
}

public partial class Navigator
{
	[Value("keyboard")]
	public Keyboard Keyboard { get; }
}

[Value("Keyboard")]
public partial class Keyboard : EventTarget
{
	[Value("lock")]
	public Task<Undefined> Lock(List<DOMString> keyCodes = default) { throw new System.NotImplementedException(); }
	[Value("unlock")]
	public Undefined Unlock() { throw new System.NotImplementedException(); }
}

[Value("KeyboardLayoutMap")]
public partial class KeyboardLayoutMap
{
	
}

public partial class Keyboard
{
	[Value("getLayoutMap")]
	public Task<KeyboardLayoutMap> GetLayoutMap() { throw new System.NotImplementedException(); }
	[Value("onlayoutchange")]
	public EventHandler Onlayoutchange { get; set; }
}

[Value("KHR_parallel_shader_compile")]
public partial class KHR_parallel_shader_compile
{
	[Value("COMPLETION_STATUS_KHR")]
	public const GLenum COMPLETION_STATUS_KHR = 0x91B1;
}

[Value("LargestContentfulPaint")]
public partial class LargestContentfulPaint : PerformanceEntry
{
	[Value("renderTime")]
	public DOMHighResTimeStamp RenderTime { get; }
	[Value("loadTime")]
	public DOMHighResTimeStamp LoadTime { get; }
	[Value("size")]
	public ulong Size { get; }
	[Value("id")]
	public DOMString Id { get; }
	[Value("url")]
	public DOMString Url { get; }
	[Value("element")]
	public Element? Element { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

[Value("LayoutShift")]
public partial class LayoutShift : PerformanceEntry
{
	[Value("value")]
	public Number Value { get; }
	[Value("hadRecentInput")]
	public bool HadRecentInput { get; }
	[Value("lastInputTime")]
	public DOMHighResTimeStamp LastInputTime { get; }
	[Value("sources")]
	public LayoutShiftAttribution[] Sources { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

[Value("LayoutShiftAttribution")]
public partial class LayoutShiftAttribution
{
	[Value("node")]
	public Node? Node { get; }
	[Value("previousRect")]
	public DOMRectReadOnly PreviousRect { get; }
	[Value("currentRect")]
	public DOMRectReadOnly CurrentRect { get; }
}

public partial class Window
{
	[Value("queryLocalFonts")]
	public Task<List<FontData>> QueryLocalFonts(QueryOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("QueryOptions")]
public partial class QueryOptions
{
	[Value("postscriptNames")]
	public List<DOMString> PostscriptNames;
}

[Value("FontData")]
public partial class FontData
{
	[Value("blob")]
	public Task<Blob> Blob() { throw new System.NotImplementedException(); }
	[Value("postscriptName")]
	public USVString PostscriptName { get; }
	[Value("fullName")]
	public USVString FullName { get; }
	[Value("family")]
	public USVString Family { get; }
	[Value("style")]
	public USVString Style { get; }
}

[Value("NavigatorLogin")]
public partial class NavigatorLogin
{
	[Value("setStatus")]
	public Task<Undefined> SetStatus(LoginStatus status) { throw new System.NotImplementedException(); }
}

public partial class Navigator
{
	[Value("login")]
	public NavigatorLogin Login { get; }
}

[Value("PerformanceLongAnimationFrameTiming")]
public partial class PerformanceLongAnimationFrameTiming : PerformanceEntry, PaintTimingMixin
{
	[Value("startTime")]
	public DOMHighResTimeStamp StartTime { get; }
	[Value("duration")]
	public DOMHighResTimeStamp Duration { get; }
	[Value("name")]
	public DOMString Name { get; }
	[Value("entryType")]
	public DOMString EntryType { get; }
	[Value("renderStart")]
	public DOMHighResTimeStamp RenderStart { get; }
	[Value("styleAndLayoutStart")]
	public DOMHighResTimeStamp StyleAndLayoutStart { get; }
	[Value("blockingDuration")]
	public DOMHighResTimeStamp BlockingDuration { get; }
	[Value("firstUIEventTimestamp")]
	public DOMHighResTimeStamp FirstUIEventTimestamp { get; }
	[Value("scripts")]
	public PerformanceScriptTiming[] Scripts { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}


[Value("PerformanceScriptTiming")]
public partial class PerformanceScriptTiming : PerformanceEntry
{
	[Value("startTime")]
	public DOMHighResTimeStamp StartTime { get; }
	[Value("duration")]
	public DOMHighResTimeStamp Duration { get; }
	[Value("name")]
	public DOMString Name { get; }
	[Value("entryType")]
	public DOMString EntryType { get; }
	[Value("invokerType")]
	public ScriptInvokerType InvokerType { get; }
	[Value("invoker")]
	public DOMString Invoker { get; }
	[Value("executionStart")]
	public DOMHighResTimeStamp ExecutionStart { get; }
	[Value("sourceURL")]
	public DOMString SourceURL { get; }
	[Value("sourceFunctionName")]
	public DOMString SourceFunctionName { get; }
	[Value("sourceCharPosition")]
	public long SourceCharPosition { get; }
	[Value("pauseDuration")]
	public DOMHighResTimeStamp PauseDuration { get; }
	[Value("forcedStyleAndLayoutDuration")]
	public DOMHighResTimeStamp ForcedStyleAndLayoutDuration { get; }
	[Value("window")]
	public Window? _window { get; }
	[Value("windowAttribution")]
	public ScriptWindowAttribution WindowAttribution { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

[Value("PerformanceLongTaskTiming")]
public partial class PerformanceLongTaskTiming : PerformanceEntry
{
	[Value("startTime")]
	public DOMHighResTimeStamp StartTime { get; }
	[Value("duration")]
	public DOMHighResTimeStamp Duration { get; }
	[Value("name")]
	public DOMString Name { get; }
	[Value("entryType")]
	public DOMString EntryType { get; }
	[Value("attribution")]
	public TaskAttributionTiming[] Attribution { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

[Value("TaskAttributionTiming")]
public partial class TaskAttributionTiming : PerformanceEntry
{
	[Value("startTime")]
	public DOMHighResTimeStamp StartTime { get; }
	[Value("duration")]
	public DOMHighResTimeStamp Duration { get; }
	[Value("name")]
	public DOMString Name { get; }
	[Value("entryType")]
	public DOMString EntryType { get; }
	[Value("containerType")]
	public DOMString ContainerType { get; }
	[Value("containerSrc")]
	public DOMString ContainerSrc { get; }
	[Value("containerId")]
	public DOMString ContainerId { get; }
	[Value("containerName")]
	public DOMString ContainerName { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

[Value("Magnetometer")]
public partial class Magnetometer : Sensor
{
		public Magnetometer(MagnetometerSensorOptions sensorOptions = default) { }
	[Value("x")]
	public Number? X { get; }
	[Value("y")]
	public Number? Y { get; }
	[Value("z")]
	public Number? Z { get; }
	public Magnetometer() { }
}

[Value("MagnetometerSensorOptions")]
public partial class MagnetometerSensorOptions : SensorOptions
{
	[Value("referenceFrame")]
	public MagnetometerLocalCoordinateSystem ReferenceFrame;
}

[Value("UncalibratedMagnetometer")]
public partial class UncalibratedMagnetometer : Sensor
{
		public UncalibratedMagnetometer(MagnetometerSensorOptions sensorOptions = default) { }
	[Value("x")]
	public Number? X { get; }
	[Value("y")]
	public Number? Y { get; }
	[Value("z")]
	public Number? Z { get; }
	[Value("xBias")]
	public Number? XBias { get; }
	[Value("yBias")]
	public Number? YBias { get; }
	[Value("zBias")]
	public Number? ZBias { get; }
	public UncalibratedMagnetometer() { }
}

public partial class Navigator
{
	[Value("managed")]
	public NavigatorManagedData Managed { get; }
}

public partial class NavigatorManagedData : EventTarget
{
	[Value("getManagedConfiguration")]
	public Task<Dictionary<DOMString, Object>> GetManagedConfiguration(List<DOMString> keys) { throw new System.NotImplementedException(); }
	[Value("onmanagedconfigurationchange")]
	public EventHandler Onmanagedconfigurationchange { get; set; }
}

[Value("BeforeInstallPromptEvent")]
public partial class BeforeInstallPromptEvent : Event
{
		public BeforeInstallPromptEvent(DOMString type, EventInit eventInitDict = default) { }
	[Value("prompt")]
	public Task<PromptResponseObject> Prompt() { throw new System.NotImplementedException(); }
	public BeforeInstallPromptEvent() { }
}

[Value("PromptResponseObject")]
public partial class PromptResponseObject
{
	[Value("userChoice")]
	public AppBannerPromptOutcome UserChoice;
}

public partial class Window
{
	[Value("onappinstalled")]
	public EventHandler Onappinstalled { get; set; }
	[Value("onbeforeinstallprompt")]
	public EventHandler Onbeforeinstallprompt { get; set; }
}

[Value("MathMLElement")]
public partial class MathMLElement : Element, ElementCSSInlineStyle, GlobalEventHandlers, HTMLOrSVGElement
{
}



[Value("MediaConfiguration")]
public partial class MediaConfiguration
{
	[Value("video")]
	public VideoConfiguration Video;
	[Value("audio")]
	public AudioConfiguration Audio;
}

[Value("MediaDecodingConfiguration")]
public partial class MediaDecodingConfiguration : MediaConfiguration
{
	[Value("type")]
	public required MediaDecodingType Type;
	[Value("keySystemConfiguration")]
	public MediaCapabilitiesKeySystemConfiguration KeySystemConfiguration;
}

[Value("MediaEncodingConfiguration")]
public partial class MediaEncodingConfiguration : MediaConfiguration
{
	[Value("type")]
	public required MediaEncodingType Type;
}

[Value("VideoConfiguration")]
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

[Value("AudioConfiguration")]
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

[Value("MediaCapabilitiesKeySystemConfiguration")]
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

[Value("KeySystemTrackConfiguration")]
public partial class KeySystemTrackConfiguration
{
	[Value("robustness")]
	public DOMString Robustness;
	[Value("encryptionScheme")]
	public DOMString? EncryptionScheme;
}

[Value("MediaCapabilitiesInfo")]
public partial class MediaCapabilitiesInfo
{
	[Value("supported")]
	public required bool Supported;
	[Value("smooth")]
	public required bool Smooth;
	[Value("powerEfficient")]
	public required bool PowerEfficient;
}

[Value("MediaCapabilitiesDecodingInfo")]
public partial class MediaCapabilitiesDecodingInfo : MediaCapabilitiesInfo
{
	[Value("keySystemAccess")]
	public required MediaKeySystemAccess KeySystemAccess;
	[Value("configuration")]
	public MediaDecodingConfiguration Configuration;
}

[Value("MediaCapabilitiesEncodingInfo")]
public partial class MediaCapabilitiesEncodingInfo : MediaCapabilitiesInfo
{
	[Value("configuration")]
	public MediaEncodingConfiguration Configuration;
}

public partial class Navigator
{
	[Value("mediaCapabilities")]
	public MediaCapabilities MediaCapabilities { get; }
}

public partial class WorkerNavigator
{
	[Value("mediaCapabilities")]
	public MediaCapabilities MediaCapabilities { get; }
}

[Value("MediaCapabilities")]
public partial class MediaCapabilities
{
	[Value("decodingInfo")]
	public Task<MediaCapabilitiesDecodingInfo> DecodingInfo(MediaDecodingConfiguration configuration) { throw new System.NotImplementedException(); }
	[Value("encodingInfo")]
	public Task<MediaCapabilitiesEncodingInfo> EncodingInfo(MediaEncodingConfiguration configuration) { throw new System.NotImplementedException(); }
}

public partial class HTMLVideoElement
{
	[Value("getVideoPlaybackQuality")]
	public VideoPlaybackQuality GetVideoPlaybackQuality() { throw new System.NotImplementedException(); }
}

[Value("VideoPlaybackQuality")]
public partial class VideoPlaybackQuality
{
	[Value("creationTime")]
	public DOMHighResTimeStamp CreationTime { get; }
	[Value("droppedVideoFrames")]
	public ulong DroppedVideoFrames { get; }
	[Value("totalVideoFrames")]
	public ulong TotalVideoFrames { get; }
	[Value("corruptedVideoFrames")]
	public ulong CorruptedVideoFrames { get; }
}

[Value("MediaSource")]
public partial class MediaSource : EventTarget
{
		public MediaSource() { }
	[Value("handle")]
	public MediaSourceHandle Handle { get; }
	[Value("sourceBuffers")]
	public SourceBufferList SourceBuffers { get; }
	[Value("activeSourceBuffers")]
	public SourceBufferList ActiveSourceBuffers { get; }
	[Value("readyState")]
	public ReadyState ReadyState { get; }
	[Value("duration")]
	public double Duration { get; set; }
	[Value("onsourceopen")]
	public EventHandler Onsourceopen { get; set; }
	[Value("onsourceended")]
	public EventHandler Onsourceended { get; set; }
	[Value("onsourceclose")]
	public EventHandler Onsourceclose { get; set; }
	[Value("canConstructInDedicatedWorker")]
	public static bool CanConstructInDedicatedWorker { get; }
	[Value("addSourceBuffer")]
	public SourceBuffer AddSourceBuffer(DOMString type) { throw new System.NotImplementedException(); }
	[Value("removeSourceBuffer")]
	public Undefined RemoveSourceBuffer(SourceBuffer sourceBuffer) { throw new System.NotImplementedException(); }
	[Value("endOfStream")]
	public Undefined EndOfStream(EndOfStreamError error = default) { throw new System.NotImplementedException(); }
	[Value("setLiveSeekableRange")]
	public Undefined SetLiveSeekableRange(Number start, Number end) { throw new System.NotImplementedException(); }
	[Value("clearLiveSeekableRange")]
	public Undefined ClearLiveSeekableRange() { throw new System.NotImplementedException(); }
	[Value("isTypeSupported")]
	public static bool IsTypeSupported(DOMString type) { throw new System.NotImplementedException(); }
}

[Value("MediaSourceHandle")]
public partial class MediaSourceHandle
{
}

[Value("SourceBuffer")]
public partial class SourceBuffer : EventTarget
{
	[Value("mode")]
	public AppendMode Mode { get; set; }
	[Value("updating")]
	public bool Updating { get; }
	[Value("buffered")]
	public TimeRanges Buffered { get; }
	[Value("timestampOffset")]
	public Number TimestampOffset { get; set; }
	[Value("audioTracks")]
	public AudioTrackList AudioTracks { get; }
	[Value("videoTracks")]
	public VideoTrackList VideoTracks { get; }
	[Value("textTracks")]
	public TextTrackList TextTracks { get; }
	[Value("appendWindowStart")]
	public Number AppendWindowStart { get; set; }
	[Value("appendWindowEnd")]
	public double AppendWindowEnd { get; set; }
	[Value("onupdatestart")]
	public EventHandler Onupdatestart { get; set; }
	[Value("onupdate")]
	public EventHandler Onupdate { get; set; }
	[Value("onupdateend")]
	public EventHandler Onupdateend { get; set; }
	[Value("onerror")]
	public EventHandler Onerror { get; set; }
	[Value("onabort")]
	public EventHandler Onabort { get; set; }
	[Value("appendBuffer")]
	public Undefined AppendBuffer(BufferSource data) { throw new System.NotImplementedException(); }
	[Value("abort")]
	public Undefined Abort() { throw new System.NotImplementedException(); }
	[Value("changeType")]
	public Undefined ChangeType(DOMString type) { throw new System.NotImplementedException(); }
	[Value("remove")]
	public Undefined Remove(Number start, double end) { throw new System.NotImplementedException(); }
}

[Value("SourceBufferList")]
public partial class SourceBufferList : EventTarget
{
	[Value("length")]
	public ulong Length { get; }
	[Value("onaddsourcebuffer")]
	public EventHandler Onaddsourcebuffer { get; set; }
	[Value("onremovesourcebuffer")]
	public EventHandler Onremovesourcebuffer { get; set; }
	
}

[Value("ManagedMediaSource")]
public partial class ManagedMediaSource : MediaSource
{
		public ManagedMediaSource() { }
	[Value("streaming")]
	public bool Streaming { get; }
	[Value("onstartstreaming")]
	public EventHandler Onstartstreaming { get; set; }
	[Value("onendstreaming")]
	public EventHandler Onendstreaming { get; set; }
}

[Value("BufferedChangeEvent")]
public partial class BufferedChangeEvent : Event
{
		public BufferedChangeEvent(DOMString type, BufferedChangeEventInit eventInitDict = default) { }
	[Value("addedRanges")]
	public TimeRanges AddedRanges { get; }
	[Value("removedRanges")]
	public TimeRanges RemovedRanges { get; }
	public BufferedChangeEvent() { }
}

[Value("BufferedChangeEventInit")]
public partial class BufferedChangeEventInit : EventInit
{
	[Value("addedRanges")]
	public TimeRanges AddedRanges;
	[Value("removedRanges")]
	public TimeRanges RemovedRanges;
}

[Value("ManagedSourceBuffer")]
public partial class ManagedSourceBuffer : SourceBuffer
{
	[Value("onbufferedchange")]
	public EventHandler Onbufferedchange { get; set; }
}

public partial class AudioTrack
{
	[Value("sourceBuffer")]
	public SourceBuffer? SourceBuffer { get; }
}

public partial class VideoTrack
{
	[Value("sourceBuffer")]
	public SourceBuffer? SourceBuffer { get; }
}

public partial class TextTrack
{
	[Value("sourceBuffer")]
	public SourceBuffer? SourceBuffer { get; }
}

[Value("MockCapturePromptResultConfiguration")]
public partial class MockCapturePromptResultConfiguration
{
	[Value("getUserMedia")]
	public MockCapturePromptResult GetUserMedia;
	[Value("getDisplayMedia")]
	public MockCapturePromptResult GetDisplayMedia;
}

[Value("MockCaptureDeviceConfiguration")]
public partial class MockCaptureDeviceConfiguration
{
	[Value("label")]
	public DOMString Label;
	[Value("deviceId")]
	public DOMString DeviceId;
	[Value("groupId")]
	public DOMString GroupId;
}

[Value("MockCameraConfiguration")]
public partial class MockCameraConfiguration : MockCaptureDeviceConfiguration
{
	[Value("defaultFrameRate")]
	public Number DefaultFrameRate;
	[Value("facingMode")]
	public DOMString FacingMode;
}

[Value("MockMicrophoneConfiguration")]
public partial class MockMicrophoneConfiguration : MockCaptureDeviceConfiguration
{
	[Value("defaultSampleRate")]
	public ulong DefaultSampleRate;
}

public partial class HTMLMediaElement
{
	[Value("captureStream")]
	public MediaStream CaptureStream() { throw new System.NotImplementedException(); }
}

public partial class HTMLCanvasElement
{
	[Value("captureStream")]
	public MediaStream CaptureStream(Number frameRequestRate = default) { throw new System.NotImplementedException(); }
}

[Value("CanvasCaptureMediaStreamTrack")]
public partial class CanvasCaptureMediaStreamTrack : MediaStreamTrack
{
	[Value("canvas")]
	public HTMLCanvasElement Canvas { get; }
	[Value("requestFrame")]
	public Undefined RequestFrame() { throw new System.NotImplementedException(); }
}

public partial class MediaDevices
{
	[Value("setSupportedCaptureActions")]
	public Undefined SetSupportedCaptureActions(List<DOMString> actions) { throw new System.NotImplementedException(); }
	[Value("oncaptureaction")]
	public EventHandler Oncaptureaction { get; set; }
}

[Value("CaptureActionEvent")]
public partial class CaptureActionEvent : Event
{
		public CaptureActionEvent(CaptureActionEventInit init = default) { }
	[Value("action")]
	public CaptureAction Action { get; }
	public CaptureActionEvent() { }
}

[Value("CaptureActionEventInit")]
public partial class CaptureActionEventInit : EventInit
{
	[Value("action")]
	public DOMString Action;
}

public partial class MediaStreamTrack
{
	[Value("getSupportedCaptureActions")]
	public List<DOMString> GetSupportedCaptureActions() { throw new System.NotImplementedException(); }
	[Value("sendCaptureAction")]
	public Task<Undefined> SendCaptureAction(CaptureAction action) { throw new System.NotImplementedException(); }
}

[Value("CropTarget")]
public partial class CropTarget
{
	[Value("fromElement")]
	public static Task<CropTarget> FromElement(Element element) { throw new System.NotImplementedException(); }
}

public partial class BrowserCaptureMediaStreamTrack : MediaStreamTrack
{
	[Value("cropTo")]
	public Task<Undefined> CropTo(CropTarget? cropTarget) { throw new System.NotImplementedException(); }
	[Value("clone")]
	public BrowserCaptureMediaStreamTrack Clone() { throw new System.NotImplementedException(); }
}

[Value("MediaStream")]
public partial class MediaStream : EventTarget
{
		public MediaStream() { }
		public MediaStream(MediaStream stream) { }
		public MediaStream(List<MediaStreamTrack> tracks) { }
	[Value("id")]
	public DOMString Id { get; }
	[Value("getAudioTracks")]
	public List<MediaStreamTrack> GetAudioTracks() { throw new System.NotImplementedException(); }
	[Value("getVideoTracks")]
	public List<MediaStreamTrack> GetVideoTracks() { throw new System.NotImplementedException(); }
	[Value("getTracks")]
	public List<MediaStreamTrack> GetTracks() { throw new System.NotImplementedException(); }
	[Value("getTrackById")]
	public MediaStreamTrack? GetTrackById(DOMString trackId) { throw new System.NotImplementedException(); }
	[Value("addTrack")]
	public Undefined AddTrack(MediaStreamTrack track) { throw new System.NotImplementedException(); }
	[Value("removeTrack")]
	public Undefined RemoveTrack(MediaStreamTrack track) { throw new System.NotImplementedException(); }
	[Value("clone")]
	public MediaStream Clone() { throw new System.NotImplementedException(); }
	[Value("active")]
	public bool Active { get; }
	[Value("onaddtrack")]
	public EventHandler Onaddtrack { get; set; }
	[Value("onremovetrack")]
	public EventHandler Onremovetrack { get; set; }
}

public partial class MediaStreamTrack : EventTarget
{
	[Value("kind")]
	public DOMString Kind { get; }
	[Value("id")]
	public DOMString Id { get; }
	[Value("label")]
	public DOMString Label { get; }
	[Value("enabled")]
	public bool Enabled { get; set; }
	[Value("muted")]
	public bool Muted { get; }
	[Value("onmute")]
	public EventHandler Onmute { get; set; }
	[Value("onunmute")]
	public EventHandler Onunmute { get; set; }
	[Value("readyState")]
	public MediaStreamTrackState ReadyState { get; }
	[Value("onended")]
	public EventHandler Onended { get; set; }
	[Value("clone")]
	public MediaStreamTrack Clone() { throw new System.NotImplementedException(); }
	[Value("stop")]
	public Undefined Stop() { throw new System.NotImplementedException(); }
	[Value("getCapabilities")]
	public MediaTrackCapabilities GetCapabilities() { throw new System.NotImplementedException(); }
	[Value("getConstraints")]
	public MediaTrackConstraints GetConstraints() { throw new System.NotImplementedException(); }
	[Value("getSettings")]
	public MediaTrackSettings GetSettings() { throw new System.NotImplementedException(); }
	[Value("applyConstraints")]
	public Task<Undefined> ApplyConstraints(MediaTrackConstraints constraints = default) { throw new System.NotImplementedException(); }
}

public partial class MediaTrackSupportedConstraints
{
	[Value("width")]
	public bool Width;
	[Value("height")]
	public bool Height;
	[Value("aspectRatio")]
	public bool AspectRatio;
	[Value("frameRate")]
	public bool FrameRate;
	[Value("facingMode")]
	public bool FacingMode;
	[Value("resizeMode")]
	public bool ResizeMode;
	[Value("sampleRate")]
	public bool SampleRate;
	[Value("sampleSize")]
	public bool SampleSize;
	[Value("echoCancellation")]
	public bool EchoCancellation;
	[Value("autoGainControl")]
	public bool AutoGainControl;
	[Value("noiseSuppression")]
	public bool NoiseSuppression;
	[Value("latency")]
	public bool Latency;
	[Value("channelCount")]
	public bool ChannelCount;
	[Value("deviceId")]
	public bool DeviceId;
	[Value("groupId")]
	public bool GroupId;
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

[Value("MediaTrackConstraints")]
public partial class MediaTrackConstraints : MediaTrackConstraintSet
{
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

public partial class MediaTrackSettings
{
	[Value("width")]
	public ulong Width;
	[Value("height")]
	public ulong Height;
	[Value("aspectRatio")]
	public Number AspectRatio;
	[Value("frameRate")]
	public Number FrameRate;
	[Value("facingMode")]
	public DOMString FacingMode;
	[Value("resizeMode")]
	public DOMString ResizeMode;
	[Value("sampleRate")]
	public ulong SampleRate;
	[Value("sampleSize")]
	public ulong SampleSize;
	[Value("echoCancellation")]
	public bool EchoCancellation;
	[Value("autoGainControl")]
	public bool AutoGainControl;
	[Value("noiseSuppression")]
	public bool NoiseSuppression;
	[Value("latency")]
	public Number Latency;
	[Value("channelCount")]
	public ulong ChannelCount;
	[Value("deviceId")]
	public DOMString DeviceId;
	[Value("groupId")]
	public DOMString GroupId;
	[Value("backgroundBlur")]
	public bool BackgroundBlur;
}

[Value("MediaStreamTrackEvent")]
public partial class MediaStreamTrackEvent : Event
{
		public MediaStreamTrackEvent(DOMString type, MediaStreamTrackEventInit eventInitDict) { }
	[Value("track")]
	public MediaStreamTrack Track { get; }
	public MediaStreamTrackEvent() { }
}

[Value("MediaStreamTrackEventInit")]
public partial class MediaStreamTrackEventInit : EventInit
{
	[Value("track")]
	public required MediaStreamTrack Track;
}

[Value("OverconstrainedError")]
public partial class OverconstrainedError : DOMException
{
		public OverconstrainedError(DOMString constraint, DOMString message = default) { }
	[Value("constraint")]
	public DOMString Constraint { get; }
	public OverconstrainedError() { }
}

public partial class Navigator
{
	[Value("mediaDevices")]
	public MediaDevices MediaDevices { get; }
}

public partial class MediaDevices : EventTarget
{
	[Value("ondevicechange")]
	public EventHandler Ondevicechange { get; set; }
	[Value("enumerateDevices")]
	public Task<List<MediaDeviceInfo>> EnumerateDevices() { throw new System.NotImplementedException(); }
}

[Value("MediaDeviceInfo")]
public partial class MediaDeviceInfo
{
	[Value("deviceId")]
	public DOMString DeviceId { get; }
	[Value("kind")]
	public MediaDeviceKind Kind { get; }
	[Value("label")]
	public DOMString Label { get; }
	[Value("groupId")]
	public DOMString GroupId { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

[Value("InputDeviceInfo")]
public partial class InputDeviceInfo : MediaDeviceInfo
{
	[Value("getCapabilities")]
	public MediaTrackCapabilities GetCapabilities() { throw new System.NotImplementedException(); }
}

[Value("DeviceChangeEvent")]
public partial class DeviceChangeEvent : Event
{
		public DeviceChangeEvent(DOMString type, DeviceChangeEventInit eventInitDict = default) { }
	[Value("devices")]
	public MediaDeviceInfo[] Devices { get; }
	[Value("userInsertedDevices")]
	public MediaDeviceInfo[] UserInsertedDevices { get; }
	public DeviceChangeEvent() { }
}

[Value("DeviceChangeEventInit")]
public partial class DeviceChangeEventInit : EventInit
{
	[Value("devices")]
	public List<MediaDeviceInfo> Devices;
}

public partial class MediaDevices
{
	[Value("getSupportedConstraints")]
	public MediaTrackSupportedConstraints GetSupportedConstraints() { throw new System.NotImplementedException(); }
	[Value("getUserMedia")]
	public Task<MediaStream> GetUserMedia(MediaStreamConstraints constraints = default) { throw new System.NotImplementedException(); }
}

[Value("MediaStreamConstraints")]
public partial class MediaStreamConstraints
{
	[Value("video")]
	public Union111 Video;
	[Value("audio")]
	public Union112 Audio;
}

[Value("DoubleRange")]
public partial class DoubleRange
{
	[Value("max")]
	public Number Max;
	[Value("min")]
	public Number Min;
}

[Value("ConstrainDoubleRange")]
public partial class ConstrainDoubleRange : DoubleRange
{
	[Value("exact")]
	public Number Exact;
	[Value("ideal")]
	public Number Ideal;
}

[Value("ULongRange")]
public partial class ULongRange
{
	[Value("max")]
	public ulong Max;
	[Value("min")]
	public ulong Min;
}

[Value("ConstrainULongRange")]
public partial class ConstrainULongRange : ULongRange
{
	[Value("exact")]
	public ulong Exact;
	[Value("ideal")]
	public ulong Ideal;
}

[Value("ConstrainBooleanParameters")]
public partial class ConstrainBooleanParameters
{
	[Value("exact")]
	public bool Exact;
	[Value("ideal")]
	public bool Ideal;
}

[Value("ConstrainDOMStringParameters")]
public partial class ConstrainDOMStringParameters
{
	[Value("exact")]
	public Union113 Exact;
	[Value("ideal")]
	public Union114 Ideal;
}





[Value("CameraDevicePermissionDescriptor")]
public partial class CameraDevicePermissionDescriptor : PermissionDescriptor
{
	[Value("panTiltZoom")]
	public bool PanTiltZoom;
}

public partial class CaptureController
{
	[Value("getSupportedZoomLevels")]
	public List<long> GetSupportedZoomLevels() { throw new System.NotImplementedException(); }
	[Value("getZoomLevel")]
	public long GetZoomLevel() { throw new System.NotImplementedException(); }
	[Value("setZoomLevel")]
	public Task<Undefined> SetZoomLevel(long zoomLevel) { throw new System.NotImplementedException(); }
	[Value("oncapturedzoomlevelchange")]
	public EventHandler Oncapturedzoomlevelchange { get; set; }
}

public partial class CaptureController
{
	
	[Value("forwardWheel")]
	public Task<Undefined> ForwardWheel(HTMLElement? element) { throw new System.NotImplementedException(); }
}

[Value("MediaStreamTrackProcessor")]
public partial class MediaStreamTrackProcessor
{
		public MediaStreamTrackProcessor(MediaStreamTrackProcessorInit init) { }
	[Value("readable")]
	public ReadableStream Readable { get; }
	public MediaStreamTrackProcessor() { }
}

[Value("MediaStreamTrackProcessorInit")]
public partial class MediaStreamTrackProcessorInit
{
	[Value("track")]
	public required MediaStreamTrack Track;
	[Value("maxBufferSize")]
	public ushort MaxBufferSize;
}

[Value("VideoTrackGenerator")]
public partial class VideoTrackGenerator
{
		public VideoTrackGenerator() { }
	[Value("writable")]
	public WritableStream Writable { get; }
	[Value("muted")]
	public bool Muted { get; set; }
	[Value("track")]
	public MediaStreamTrack Track { get; }
}

public partial class MediaDevices
{
	[Value("getViewportMedia")]
	public Task<MediaStream> GetViewportMedia(DisplayMediaStreamOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class Navigator
{
	[Value("preferences")]
	public PreferenceManager Preferences { get; }
}

[Value("PreferenceManager")]
public partial class PreferenceManager
{
	[Value("colorScheme")]
	public PreferenceObject ColorScheme { get; }
	[Value("contrast")]
	public PreferenceObject Contrast { get; }
	[Value("reducedMotion")]
	public PreferenceObject ReducedMotion { get; }
	[Value("reducedTransparency")]
	public PreferenceObject ReducedTransparency { get; }
	[Value("reducedData")]
	public PreferenceObject ReducedData { get; }
}

[Value("PreferenceObject")]
public partial class PreferenceObject : EventTarget
{
	[Value("override")]
	public DOMString? Override { get; }
	[Value("value")]
	public DOMString Value { get; }
	[Value("validValues")]
	public DOMString[] ValidValues { get; }
	[Value("clearOverride")]
	public Undefined ClearOverride() { throw new System.NotImplementedException(); }
	[Value("requestOverride")]
	public Task<Undefined> RequestOverride(DOMString? value) { throw new System.NotImplementedException(); }
	[Value("onchange")]
	public EventHandler Onchange { get; set; }
}

public partial class Navigator
{
	[Value("mediaSession")]
	public MediaSession MediaSession { get; }
}

[Value("MediaSession")]
public partial class MediaSession
{
	[Value("metadata")]
	public MediaMetadata? Metadata { get; set; }
	[Value("playbackState")]
	public MediaSessionPlaybackState PlaybackState { get; set; }
	[Value("setActionHandler")]
	public Undefined SetActionHandler(MediaSessionAction action, MediaSessionActionHandler? handler) { throw new System.NotImplementedException(); }
	[Value("setPositionState")]
	public Undefined SetPositionState(MediaPositionState state = default) { throw new System.NotImplementedException(); }
	[Value("setMicrophoneActive")]
	public Task<Undefined> SetMicrophoneActive(bool active) { throw new System.NotImplementedException(); }
	[Value("setCameraActive")]
	public Task<Undefined> SetCameraActive(bool active) { throw new System.NotImplementedException(); }
	[Value("setScreenshareActive")]
	public Task<Undefined> SetScreenshareActive(bool active) { throw new System.NotImplementedException(); }
}

[Value("MediaMetadata")]
public partial class MediaMetadata
{
		public MediaMetadata(MediaMetadataInit init = default) { }
	[Value("title")]
	public DOMString Title { get; set; }
	[Value("artist")]
	public DOMString Artist { get; set; }
	[Value("album")]
	public DOMString Album { get; set; }
	[Value("artwork")]
	public Object[] Artwork { get; set; }
	[Value("chapterInfo")]
	public ChapterInformation[] ChapterInfo { get; }
	public MediaMetadata() { }
}

[Value("MediaMetadataInit")]
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

[Value("ChapterInformation")]
public partial class ChapterInformation
{
	[Value("title")]
	public DOMString Title { get; }
	[Value("startTime")]
	public Number StartTime { get; }
	[Value("artwork")]
	public MediaImage[] Artwork { get; }
}

[Value("ChapterInformationInit")]
public partial class ChapterInformationInit
{
	[Value("title")]
	public DOMString Title;
	[Value("startTime")]
	public Number StartTime;
	[Value("artwork")]
	public List<MediaImage> Artwork;
}

[Value("MediaImage")]
public partial class MediaImage
{
	[Value("src")]
	public required USVString Src;
	[Value("sizes")]
	public DOMString Sizes;
	[Value("type")]
	public DOMString Type;
}

[Value("MediaPositionState")]
public partial class MediaPositionState
{
	[Value("duration")]
	public double Duration;
	[Value("playbackRate")]
	public Number PlaybackRate;
	[Value("position")]
	public Number Position;
}

[Value("MediaSessionActionDetails")]
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

[Value("MediaRecorder")]
public partial class MediaRecorder : EventTarget
{
		public MediaRecorder(MediaStream stream, MediaRecorderOptions options = default) { }
	[Value("stream")]
	public MediaStream Stream { get; }
	[Value("mimeType")]
	public DOMString MimeType { get; }
	[Value("state")]
	public RecordingState State { get; }
	[Value("onstart")]
	public EventHandler Onstart { get; set; }
	[Value("onstop")]
	public EventHandler Onstop { get; set; }
	[Value("ondataavailable")]
	public EventHandler Ondataavailable { get; set; }
	[Value("onpause")]
	public EventHandler Onpause { get; set; }
	[Value("onresume")]
	public EventHandler Onresume { get; set; }
	[Value("onerror")]
	public EventHandler Onerror { get; set; }
	[Value("videoBitsPerSecond")]
	public ulong VideoBitsPerSecond { get; }
	[Value("audioBitsPerSecond")]
	public ulong AudioBitsPerSecond { get; }
	[Value("audioBitrateMode")]
	public BitrateMode AudioBitrateMode { get; }
	[Value("start")]
	public Undefined Start(ulong timeslice = default) { throw new System.NotImplementedException(); }
	[Value("stop")]
	public Undefined Stop() { throw new System.NotImplementedException(); }
	[Value("pause")]
	public Undefined Pause() { throw new System.NotImplementedException(); }
	[Value("resume")]
	public Undefined Resume() { throw new System.NotImplementedException(); }
	[Value("requestData")]
	public Undefined RequestData() { throw new System.NotImplementedException(); }
	[Value("isTypeSupported")]
	public static bool IsTypeSupported(DOMString type) { throw new System.NotImplementedException(); }
	public MediaRecorder() { }
}

[Value("MediaRecorderOptions")]
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

[Value("BlobEvent")]
public partial class BlobEvent : Event
{
		public BlobEvent(DOMString type, BlobEventInit eventInitDict) { }
	[Value("data")]
	public Blob Data { get; }
	[Value("timecode")]
	public DOMHighResTimeStamp Timecode { get; }
	public BlobEvent() { }
}

[Value("BlobEventInit")]
public partial class BlobEventInit
{
	[Value("data")]
	public required Blob Data;
	[Value("timecode")]
	public DOMHighResTimeStamp Timecode;
}

[Value("HTMLModelElement")]
public partial class HTMLModelElement : HTMLElement
{
}

public partial class MediaStreamTrack
{
	[Value("contentHint")]
	public DOMString ContentHint { get; set; }
}

[Value("RTCRtpSendParameters")]
public partial class RTCRtpSendParameters
{
	[Value("degradationPreference")]
	public RTCDegradationPreference DegradationPreference;
}

[Value("PerformanceNavigationTiming")]
public partial class PerformanceNavigationTiming : PerformanceResourceTiming
{
	[Value("unloadEventStart")]
	public DOMHighResTimeStamp UnloadEventStart { get; }
	[Value("unloadEventEnd")]
	public DOMHighResTimeStamp UnloadEventEnd { get; }
	[Value("domInteractive")]
	public DOMHighResTimeStamp DomInteractive { get; }
	[Value("domContentLoadedEventStart")]
	public DOMHighResTimeStamp DomContentLoadedEventStart { get; }
	[Value("domContentLoadedEventEnd")]
	public DOMHighResTimeStamp DomContentLoadedEventEnd { get; }
	[Value("domComplete")]
	public DOMHighResTimeStamp DomComplete { get; }
	[Value("loadEventStart")]
	public DOMHighResTimeStamp LoadEventStart { get; }
	[Value("loadEventEnd")]
	public DOMHighResTimeStamp LoadEventEnd { get; }
	[Value("type")]
	public NavigationTimingType Type { get; }
	[Value("redirectCount")]
	public ushort RedirectCount { get; }
	[Value("criticalCHRestart")]
	public DOMHighResTimeStamp CriticalCHRestart { get; }
	[Value("notRestoredReasons")]
	public NotRestoredReasons? NotRestoredReasons { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

[Value("PerformanceTiming")]
public partial class PerformanceTiming
{
	[Value("navigationStart")]
	public ulong NavigationStart { get; }
	[Value("unloadEventStart")]
	public ulong UnloadEventStart { get; }
	[Value("unloadEventEnd")]
	public ulong UnloadEventEnd { get; }
	[Value("redirectStart")]
	public ulong RedirectStart { get; }
	[Value("redirectEnd")]
	public ulong RedirectEnd { get; }
	[Value("fetchStart")]
	public ulong FetchStart { get; }
	[Value("domainLookupStart")]
	public ulong DomainLookupStart { get; }
	[Value("domainLookupEnd")]
	public ulong DomainLookupEnd { get; }
	[Value("connectStart")]
	public ulong ConnectStart { get; }
	[Value("connectEnd")]
	public ulong ConnectEnd { get; }
	[Value("secureConnectionStart")]
	public ulong SecureConnectionStart { get; }
	[Value("requestStart")]
	public ulong RequestStart { get; }
	[Value("responseStart")]
	public ulong ResponseStart { get; }
	[Value("responseEnd")]
	public ulong ResponseEnd { get; }
	[Value("domLoading")]
	public ulong DomLoading { get; }
	[Value("domInteractive")]
	public ulong DomInteractive { get; }
	[Value("domContentLoadedEventStart")]
	public ulong DomContentLoadedEventStart { get; }
	[Value("domContentLoadedEventEnd")]
	public ulong DomContentLoadedEventEnd { get; }
	[Value("domComplete")]
	public ulong DomComplete { get; }
	[Value("loadEventStart")]
	public ulong LoadEventStart { get; }
	[Value("loadEventEnd")]
	public ulong LoadEventEnd { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

[Value("PerformanceNavigation")]
public partial class PerformanceNavigation
{
	[Value("TYPE_NAVIGATE")]
	public const ushort TYPE_NAVIGATE = 0;
	[Value("TYPE_RELOAD")]
	public const ushort TYPE_RELOAD = 1;
	[Value("TYPE_BACK_FORWARD")]
	public const ushort TYPE_BACK_FORWARD = 2;
	[Value("TYPE_RESERVED")]
	public const ushort TYPE_RESERVED = 255;
	[Value("type")]
	public ushort Type { get; }
	[Value("redirectCount")]
	public ushort RedirectCount { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

public partial class Performance
{
	[Value("timing")]
	public PerformanceTiming Timing { get; }
	[Value("navigation")]
	public PerformanceNavigation Navigation { get; }
}

[Value("NetworkInformation")]
public partial class NetworkInformation : EventTarget, NetworkInformationSaveData
{
	[Value("type")]
	public ConnectionType Type { get; }
	[Value("effectiveType")]
	public EffectiveConnectionType EffectiveType { get; }
	[Value("downlinkMax")]
	public Megabit DownlinkMax { get; }
	[Value("downlink")]
	public Megabit Downlink { get; }
	[Value("rtt")]
	public Millisecond Rtt { get; }
	[Value("onchange")]
	public EventHandler Onchange { get; set; }
}



[Value("Notification")]
public partial class Notification : EventTarget
{
		public Notification(DOMString title, NotificationOptions options = default) { }
	[Value("permission")]
	public static NotificationPermission Permission { get; }
	[Value("requestPermission")]
	public static Task<NotificationPermission> RequestPermission(NotificationPermissionCallback deprecatedCallback = default) { throw new System.NotImplementedException(); }
	[Value("maxActions")]
	public static ulong MaxActions { get; }
	[Value("onclick")]
	public EventHandler Onclick { get; set; }
	[Value("onshow")]
	public EventHandler Onshow { get; set; }
	[Value("onerror")]
	public EventHandler Onerror { get; set; }
	[Value("onclose")]
	public EventHandler Onclose { get; set; }
	[Value("title")]
	public DOMString Title { get; }
	[Value("dir")]
	public NotificationDirection Dir { get; }
	[Value("lang")]
	public DOMString Lang { get; }
	[Value("body")]
	public DOMString Body { get; }
	[Value("tag")]
	public DOMString Tag { get; }
	[Value("image")]
	public USVString Image { get; }
	[Value("icon")]
	public USVString Icon { get; }
	[Value("badge")]
	public USVString Badge { get; }
	[Value("vibrate")]
	public ulong[] Vibrate { get; }
	[Value("timestamp")]
	public EpochTimeStamp Timestamp { get; }
	[Value("renotify")]
	public bool Renotify { get; }
	[Value("silent")]
	public bool? Silent { get; }
	[Value("requireInteraction")]
	public bool RequireInteraction { get; }
	[Value("data")]
	public dynamic Data { get; }
	[Value("actions")]
	public NotificationAction[] Actions { get; }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	public Notification() { }
}

[Value("NotificationOptions")]
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

[Value("NotificationAction")]
public partial class NotificationAction
{
	[Value("action")]
	public required DOMString Action;
	[Value("title")]
	public required DOMString Title;
	[Value("icon")]
	public USVString Icon;
}

[Value("GetNotificationOptions")]
public partial class GetNotificationOptions
{
	[Value("tag")]
	public DOMString Tag;
}

public partial class ServiceWorkerRegistration
{
	[Value("showNotification")]
	public Task<Undefined> ShowNotification(DOMString title, NotificationOptions options = default) { throw new System.NotImplementedException(); }
	[Value("getNotifications")]
	public Task<List<Notification>> GetNotifications(GetNotificationOptions filter = default) { throw new System.NotImplementedException(); }
}

[Value("NotificationEvent")]
public partial class NotificationEvent : ExtendableEvent
{
		public NotificationEvent(DOMString type, NotificationEventInit eventInitDict) { }
	[Value("notification")]
	public Notification Notification { get; }
	[Value("action")]
	public DOMString Action { get; }
	public NotificationEvent() { }
}

[Value("NotificationEventInit")]
public partial class NotificationEventInit : ExtendableEventInit
{
	[Value("notification")]
	public required Notification Notification;
	[Value("action")]
	public DOMString Action;
}

public partial class ServiceWorkerGlobalScope
{
	[Value("onnotificationclick")]
	public EventHandler Onnotificationclick { get; set; }
	[Value("onnotificationclose")]
	public EventHandler Onnotificationclose { get; set; }
}

[Value("Subscriber")]
public partial class Subscriber
{
	[Value("next")]
	public Undefined Next(dynamic value) { throw new System.NotImplementedException(); }
	[Value("error")]
	public Undefined Error(dynamic error) { throw new System.NotImplementedException(); }
	[Value("complete")]
	public Undefined Complete() { throw new System.NotImplementedException(); }
	[Value("addTeardown")]
	public Undefined AddTeardown(VoidFunction teardown) { throw new System.NotImplementedException(); }
	[Value("active")]
	public bool Active { get; }
	[Value("signal")]
	public AbortSignal Signal { get; }
}

[Value("SubscriptionObserver")]
public partial class SubscriptionObserver
{
	[Value("next")]
	public ObservableSubscriptionCallback Next;
	[Value("error")]
	public ObservableSubscriptionCallback Error;
	[Value("complete")]
	public VoidFunction Complete;
}

[Value("ObservableInspector")]
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



[Value("SubscribeOptions")]
public partial class SubscribeOptions
{
	[Value("signal")]
	public AbortSignal Signal;
}

[Value("Observable")]
public partial class Observable
{
		public Observable(SubscribeCallback callback) { }
	[Value("subscribe")]
	public Undefined Subscribe(ObserverUnion observer = default, SubscribeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("from")]
	public static Observable From(dynamic value) { throw new System.NotImplementedException(); }
	[Value("takeUntil")]
	public Observable TakeUntil(dynamic notifier) { throw new System.NotImplementedException(); }
	[Value("map")]
	public Observable Map(Mapper mapper) { throw new System.NotImplementedException(); }
	[Value("filter")]
	public Observable Filter(Predicate predicate) { throw new System.NotImplementedException(); }
	[Value("take")]
	public Observable Take(ulong amount) { throw new System.NotImplementedException(); }
	[Value("drop")]
	public Observable Drop(ulong amount) { throw new System.NotImplementedException(); }
	[Value("flatMap")]
	public Observable FlatMap(Mapper mapper) { throw new System.NotImplementedException(); }
	[Value("switchMap")]
	public Observable SwitchMap(Mapper mapper) { throw new System.NotImplementedException(); }
	[Value("inspect")]
	public Observable Inspect(ObservableInspectorUnion inspectorUnion = default) { throw new System.NotImplementedException(); }
	[Value("catch")]
	public Observable Catch(CatchCallback callback) { throw new System.NotImplementedException(); }
	[Value("finally")]
	public Observable Finally(VoidFunction callback) { throw new System.NotImplementedException(); }
	[Value("toArray")]
	public Task<List<dynamic>> ToArray(SubscribeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("forEach")]
	public Task<Undefined> ForEach(Visitor callback, SubscribeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("every")]
	public Task<bool> Every(Predicate predicate, SubscribeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("first")]
	public Task<dynamic> First(SubscribeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("last")]
	public Task<dynamic> Last(SubscribeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("find")]
	public Task<dynamic> Find(Predicate predicate, SubscribeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("some")]
	public Task<bool> Some(Predicate predicate, SubscribeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("reduce")]
	public Task<dynamic> Reduce(Reducer reducer, dynamic initialValue = default, SubscribeOptions options = default) { throw new System.NotImplementedException(); }
	public Observable() { }
}

[Value("ObservableEventListenerOptions")]
public partial class ObservableEventListenerOptions
{
	[Value("capture")]
	public bool Capture;
	[Value("passive")]
	public bool Passive;
}

public partial class EventTarget
{
	[Value("when")]
	public Observable When(DOMString type, ObservableEventListenerOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("OES_draw_buffers_indexed")]
public partial class OES_draw_buffers_indexed
{
	[Value("enableiOES")]
	public Undefined EnableiOES(GLenum target, GLuint index) { throw new System.NotImplementedException(); }
	[Value("disableiOES")]
	public Undefined DisableiOES(GLenum target, GLuint index) { throw new System.NotImplementedException(); }
	[Value("blendEquationiOES")]
	public Undefined BlendEquationiOES(GLuint buf, GLenum mode) { throw new System.NotImplementedException(); }
	[Value("blendEquationSeparateiOES")]
	public Undefined BlendEquationSeparateiOES(GLuint buf, GLenum modeRGB, GLenum modeAlpha) { throw new System.NotImplementedException(); }
	[Value("blendFunciOES")]
	public Undefined BlendFunciOES(GLuint buf, GLenum src, GLenum dst) { throw new System.NotImplementedException(); }
	[Value("blendFuncSeparateiOES")]
	public Undefined BlendFuncSeparateiOES(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha) { throw new System.NotImplementedException(); }
	[Value("colorMaskiOES")]
	public Undefined ColorMaskiOES(GLuint buf, bool r, bool g, bool b, bool a) { throw new System.NotImplementedException(); }
}

[Value("OES_element_index_uint")]
public partial class OES_element_index_uint
{
}

[Value("OES_fbo_render_mipmap")]
public partial class OES_fbo_render_mipmap
{
}

[Value("OES_standard_derivatives")]
public partial class OES_standard_derivatives
{
	[Value("FRAGMENT_SHADER_DERIVATIVE_HINT_OES")]
	public const GLenum FRAGMENT_SHADER_DERIVATIVE_HINT_OES = 0x8B8B;
}

[Value("OES_texture_float")]
public partial class OES_texture_float
{
}

[Value("OES_texture_float_linear")]
public partial class OES_texture_float_linear
{
}

[Value("OES_texture_half_float")]
public partial class OES_texture_half_float
{
	[Value("HALF_FLOAT_OES")]
	public const GLenum HALF_FLOAT_OES = 0x8D61;
}

[Value("OES_texture_half_float_linear")]
public partial class OES_texture_half_float_linear
{
}

[Value("WebGLVertexArrayObjectOES")]
public partial class WebGLVertexArrayObjectOES : WebGLObject
{
}

[Value("OES_vertex_array_object")]
public partial class OES_vertex_array_object
{
	[Value("VERTEX_ARRAY_BINDING_OES")]
	public const GLenum VERTEX_ARRAY_BINDING_OES = 0x85B5;
	[Value("createVertexArrayOES")]
	public WebGLVertexArrayObjectOES CreateVertexArrayOES() { throw new System.NotImplementedException(); }
	[Value("deleteVertexArrayOES")]
	public Undefined DeleteVertexArrayOES(WebGLVertexArrayObjectOES? arrayObject) { throw new System.NotImplementedException(); }
	[Value("isVertexArrayOES")]
	public bool IsVertexArrayOES(WebGLVertexArrayObjectOES? arrayObject) { throw new System.NotImplementedException(); }
	[Value("bindVertexArrayOES")]
	public Undefined BindVertexArrayOES(WebGLVertexArrayObjectOES? arrayObject) { throw new System.NotImplementedException(); }
}

public partial class Window
{
	[Value("ondeviceorientation")]
	public EventHandler Ondeviceorientation { get; set; }
}

[Value("DeviceOrientationEvent")]
public partial class DeviceOrientationEvent : Event
{
		public DeviceOrientationEvent(DOMString type, DeviceOrientationEventInit eventInitDict = default) { }
	[Value("alpha")]
	public Number? Alpha { get; }
	[Value("beta")]
	public Number? Beta { get; }
	[Value("gamma")]
	public Number? Gamma { get; }
	[Value("absolute")]
	public bool Absolute { get; }
	[Value("requestPermission")]
	public static Task<PermissionState> RequestPermission(bool absolute = default) { throw new System.NotImplementedException(); }
	public DeviceOrientationEvent() { }
}

[Value("DeviceOrientationEventInit")]
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

public partial class Window
{
	[Value("ondeviceorientationabsolute")]
	public EventHandler Ondeviceorientationabsolute { get; set; }
}

[Value("DeviceMotionEventAcceleration")]
public partial class DeviceMotionEventAcceleration
{
	[Value("x")]
	public Number? X { get; }
	[Value("y")]
	public Number? Y { get; }
	[Value("z")]
	public Number? Z { get; }
}

[Value("DeviceMotionEventRotationRate")]
public partial class DeviceMotionEventRotationRate
{
	[Value("alpha")]
	public Number? Alpha { get; }
	[Value("beta")]
	public Number? Beta { get; }
	[Value("gamma")]
	public Number? Gamma { get; }
}

public partial class Window
{
	[Value("ondevicemotion")]
	public EventHandler Ondevicemotion { get; set; }
}

[Value("DeviceMotionEvent")]
public partial class DeviceMotionEvent : Event
{
		public DeviceMotionEvent(DOMString type, DeviceMotionEventInit eventInitDict = default) { }
	[Value("acceleration")]
	public DeviceMotionEventAcceleration? Acceleration { get; }
	[Value("accelerationIncludingGravity")]
	public DeviceMotionEventAcceleration? AccelerationIncludingGravity { get; }
	[Value("rotationRate")]
	public DeviceMotionEventRotationRate? RotationRate { get; }
	[Value("interval")]
	public Number Interval { get; }
	[Value("requestPermission")]
	public static Task<PermissionState> RequestPermission() { throw new System.NotImplementedException(); }
	public DeviceMotionEvent() { }
}

[Value("DeviceMotionEventAccelerationInit")]
public partial class DeviceMotionEventAccelerationInit
{
	[Value("x")]
	public Number? X;
	[Value("y")]
	public Number? Y;
	[Value("z")]
	public Number? Z;
}

[Value("DeviceMotionEventRotationRateInit")]
public partial class DeviceMotionEventRotationRateInit
{
	[Value("alpha")]
	public Number? Alpha;
	[Value("beta")]
	public Number? Beta;
	[Value("gamma")]
	public Number? Gamma;
}

[Value("DeviceMotionEventInit")]
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


[Value("OrientationSensor")]
public partial class OrientationSensor : Sensor
{
	[Value("quaternion")]
	public Number[]? Quaternion { get; }
	[Value("populateMatrix")]
	public Undefined PopulateMatrix(RotationMatrixType targetMatrix) { throw new System.NotImplementedException(); }
}

[Value("OrientationSensorOptions")]
public partial class OrientationSensorOptions : SensorOptions
{
	[Value("referenceFrame")]
	public OrientationSensorLocalCoordinateSystem ReferenceFrame;
}

[Value("AbsoluteOrientationSensor")]
public partial class AbsoluteOrientationSensor : OrientationSensor
{
		public AbsoluteOrientationSensor(OrientationSensorOptions sensorOptions = default) { }
	public AbsoluteOrientationSensor() { }
}

[Value("RelativeOrientationSensor")]
public partial class RelativeOrientationSensor : OrientationSensor
{
		public RelativeOrientationSensor(OrientationSensorOptions sensorOptions = default) { }
	public RelativeOrientationSensor() { }
}

[Value("OVR_multiview2")]
public partial class OVR_multiview2
{
	[Value("FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR")]
	public const GLenum FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR = 0x9630;
	[Value("FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR")]
	public const GLenum FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR = 0x9632;
	[Value("MAX_VIEWS_OVR")]
	public const GLenum MAX_VIEWS_OVR = 0x9631;
	[Value("FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR")]
	public const GLenum FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR = 0x9633;
	[Value("framebufferTextureMultiviewOVR")]
	public Undefined FramebufferTextureMultiviewOVR(GLenum target, GLenum attachment, WebGLTexture? texture, GLint level, GLint baseViewIndex, GLsizei numViews) { throw new System.NotImplementedException(); }
}

public partial class Document
{
	[Value("onfreeze")]
	public EventHandler Onfreeze { get; set; }
	[Value("onresume")]
	public EventHandler Onresume { get; set; }
	[Value("wasDiscarded")]
	public bool WasDiscarded { get; }
}

[Value("Client")]
public partial class Client
{
	[Value("lifecycleState")]
	public ClientLifecycleState LifecycleState { get; }
}

[Value("PerformancePaintTiming")]
public partial class PerformancePaintTiming : PerformanceEntry, PaintTimingMixin
{
}


public partial class ServiceWorkerRegistration
{
	[Value("paymentManager")]
	public PaymentManager PaymentManager { get; }
}

[Value("PaymentManager")]
public partial class PaymentManager
{
	[Value("userHint")]
	public DOMString UserHint { get; set; }
	[Value("enableDelegations")]
	public Task<Undefined> EnableDelegations(List<PaymentDelegation> delegations) { throw new System.NotImplementedException(); }
}

public partial class ServiceWorkerGlobalScope
{
	[Value("oncanmakepayment")]
	public EventHandler Oncanmakepayment { get; set; }
}

[Value("CanMakePaymentEvent")]
public partial class CanMakePaymentEvent : ExtendableEvent
{
		public CanMakePaymentEvent(DOMString type) { }
	[Value("respondWith")]
	public Undefined RespondWith(Task<bool> canMakePaymentResponse) { throw new System.NotImplementedException(); }
	public CanMakePaymentEvent() { }
}

public partial class ServiceWorkerGlobalScope
{
	[Value("onpaymentrequest")]
	public EventHandler Onpaymentrequest { get; set; }
}

[Value("PaymentRequestDetailsUpdate")]
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

[Value("PaymentRequestEvent")]
public partial class PaymentRequestEvent : ExtendableEvent
{
		public PaymentRequestEvent(DOMString type, PaymentRequestEventInit eventInitDict = default) { }
	[Value("topOrigin")]
	public USVString TopOrigin { get; }
	[Value("paymentRequestOrigin")]
	public USVString PaymentRequestOrigin { get; }
	[Value("paymentRequestId")]
	public DOMString PaymentRequestId { get; }
	[Value("methodData")]
	public PaymentMethodData[] MethodData { get; }
	[Value("total")]
	public Object Total { get; }
	[Value("modifiers")]
	public PaymentDetailsModifier[] Modifiers { get; }
	[Value("paymentOptions")]
	public Object? PaymentOptions { get; }
	[Value("shippingOptions")]
	public PaymentShippingOption[]? ShippingOptions { get; }
	[Value("openWindow")]
	public Task<WindowClient?> OpenWindow(USVString url) { throw new System.NotImplementedException(); }
	[Value("changePaymentMethod")]
	public Task<PaymentRequestDetailsUpdate?> ChangePaymentMethod(DOMString methodName, Object? methodDetails = default) { throw new System.NotImplementedException(); }
	[Value("changeShippingAddress")]
	public Task<PaymentRequestDetailsUpdate?> ChangeShippingAddress(AddressInit shippingAddress = default) { throw new System.NotImplementedException(); }
	[Value("changeShippingOption")]
	public Task<PaymentRequestDetailsUpdate?> ChangeShippingOption(DOMString shippingOption) { throw new System.NotImplementedException(); }
	[Value("respondWith")]
	public Undefined RespondWith(Task<PaymentHandlerResponse> handlerResponsePromise) { throw new System.NotImplementedException(); }
	public PaymentRequestEvent() { }
}

[Value("PaymentRequestEventInit")]
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

[Value("PaymentHandlerResponse")]
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

[Value("AddressInit")]
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

[Value("PaymentRequest")]
public partial class PaymentRequest : EventTarget
{
		public PaymentRequest(List<PaymentMethodData> methodData, PaymentDetailsInit details, PaymentOptions options = default) { }
	[Value("show")]
	public Task<PaymentResponse> Show(Task<PaymentDetailsUpdate> detailsPromise = default) { throw new System.NotImplementedException(); }
	[Value("abort")]
	public Task<Undefined> Abort() { throw new System.NotImplementedException(); }
	[Value("canMakePayment")]
	public Task<bool> CanMakePayment() { throw new System.NotImplementedException(); }
	[Value("id")]
	public DOMString Id { get; }
	[Value("shippingAddress")]
	public ContactAddress? ShippingAddress { get; }
	[Value("shippingOption")]
	public DOMString? ShippingOption { get; }
	[Value("shippingType")]
	public PaymentShippingType? ShippingType { get; }
	[Value("onshippingaddresschange")]
	public EventHandler Onshippingaddresschange { get; set; }
	[Value("onshippingoptionchange")]
	public EventHandler Onshippingoptionchange { get; set; }
	[Value("onpaymentmethodchange")]
	public EventHandler Onpaymentmethodchange { get; set; }
	public PaymentRequest() { }
}

[Value("PaymentMethodData")]
public partial class PaymentMethodData
{
	[Value("supportedMethods")]
	public required DOMString SupportedMethods;
	[Value("data")]
	public Object Data;
}

[Value("PaymentCurrencyAmount")]
public partial class PaymentCurrencyAmount
{
	[Value("currency")]
	public required DOMString Currency;
	[Value("value")]
	public required DOMString Value;
}

[Value("PaymentDetailsBase")]
public partial class PaymentDetailsBase
{
	[Value("displayItems")]
	public List<PaymentItem> DisplayItems;
	[Value("shippingOptions")]
	public List<PaymentShippingOption> ShippingOptions;
	[Value("modifiers")]
	public List<PaymentDetailsModifier> Modifiers;
}

[Value("PaymentDetailsInit")]
public partial class PaymentDetailsInit : PaymentDetailsBase
{
	[Value("id")]
	public DOMString Id;
	[Value("total")]
	public required PaymentItem Total;
}

[Value("PaymentDetailsUpdate")]
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

[Value("PaymentDetailsModifier")]
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

[Value("PaymentOptions")]
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

[Value("PaymentItem")]
public partial class PaymentItem
{
	[Value("label")]
	public required DOMString Label;
	[Value("amount")]
	public required PaymentCurrencyAmount Amount;
	[Value("pending")]
	public bool Pending;
}

[Value("PaymentCompleteDetails")]
public partial class PaymentCompleteDetails
{
	[Value("data")]
	public Object? Data;
}

[Value("PaymentShippingOption")]
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

[Value("PaymentResponse")]
public partial class PaymentResponse : EventTarget
{
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
	[Value("requestId")]
	public DOMString RequestId { get; }
	[Value("methodName")]
	public DOMString MethodName { get; }
	[Value("details")]
	public Object Details { get; }
	[Value("shippingAddress")]
	public ContactAddress? ShippingAddress { get; }
	[Value("shippingOption")]
	public DOMString? ShippingOption { get; }
	[Value("payerName")]
	public DOMString? PayerName { get; }
	[Value("payerEmail")]
	public DOMString? PayerEmail { get; }
	[Value("payerPhone")]
	public DOMString? PayerPhone { get; }
	[Value("complete")]
	public Task<Undefined> Complete(PaymentComplete result = default, PaymentCompleteDetails details = default) { throw new System.NotImplementedException(); }
	[Value("retry")]
	public Task<Undefined> Retry(PaymentValidationErrors errorFields = default) { throw new System.NotImplementedException(); }
	[Value("onpayerdetailchange")]
	public EventHandler Onpayerdetailchange { get; set; }
}

[Value("PaymentValidationErrors")]
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

[Value("PayerErrors")]
public partial class PayerErrors
{
	[Value("email")]
	public DOMString Email;
	[Value("name")]
	public DOMString Name;
	[Value("phone")]
	public DOMString Phone;
}

[Value("AddressErrors")]
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

[Value("PaymentMethodChangeEvent")]
public partial class PaymentMethodChangeEvent : PaymentRequestUpdateEvent
{
		public PaymentMethodChangeEvent(DOMString type, PaymentMethodChangeEventInit eventInitDict = default) { }
	[Value("methodName")]
	public DOMString MethodName { get; }
	[Value("methodDetails")]
	public Object? MethodDetails { get; }
	public PaymentMethodChangeEvent() { }
}

[Value("PaymentMethodChangeEventInit")]
public partial class PaymentMethodChangeEventInit : PaymentRequestUpdateEventInit
{
	[Value("methodName")]
	public DOMString MethodName;
	[Value("methodDetails")]
	public Object? MethodDetails;
}

[Value("PaymentRequestUpdateEvent")]
public partial class PaymentRequestUpdateEvent : Event
{
		public PaymentRequestUpdateEvent(DOMString type, PaymentRequestUpdateEventInit eventInitDict = default) { }
	[Value("updateWith")]
	public Undefined UpdateWith(Task<PaymentDetailsUpdate> detailsPromise) { throw new System.NotImplementedException(); }
	public PaymentRequestUpdateEvent() { }
}

[Value("PaymentRequestUpdateEventInit")]
public partial class PaymentRequestUpdateEventInit : EventInit
{
}

[Value("MemoryMeasurement")]
public partial class MemoryMeasurement
{
	[Value("bytes")]
	public ulong Bytes;
	[Value("breakdown")]
	public List<MemoryBreakdownEntry> Breakdown;
}

[Value("MemoryBreakdownEntry")]
public partial class MemoryBreakdownEntry
{
	[Value("bytes")]
	public ulong Bytes;
	[Value("attribution")]
	public List<MemoryAttribution> Attribution;
	[Value("types")]
	public List<DOMString> Types;
}

[Value("MemoryAttribution")]
public partial class MemoryAttribution
{
	[Value("url")]
	public USVString Url;
	[Value("container")]
	public MemoryAttributionContainer Container;
	[Value("scope")]
	public DOMString Scope;
}

[Value("MemoryAttributionContainer")]
public partial class MemoryAttributionContainer
{
	[Value("id")]
	public DOMString Id;
	[Value("src")]
	public USVString Src;
}

public partial class Performance
{
	[Value("measureUserAgentSpecificMemory")]
	public Task<MemoryMeasurement> MeasureUserAgentSpecificMemory() { throw new System.NotImplementedException(); }
}

public partial class Performance
{
	[Value("getEntries")]
	public PerformanceEntryList GetEntries() { throw new System.NotImplementedException(); }
	[Value("getEntriesByType")]
	public PerformanceEntryList GetEntriesByType(DOMString type) { throw new System.NotImplementedException(); }
	[Value("getEntriesByName")]
	public PerformanceEntryList GetEntriesByName(DOMString name, DOMString type = default) { throw new System.NotImplementedException(); }
}


[Value("PerformanceEntry")]
public partial class PerformanceEntry
{
	[Value("id")]
	public ulong Id { get; }
	[Value("name")]
	public DOMString Name { get; }
	[Value("entryType")]
	public DOMString EntryType { get; }
	[Value("startTime")]
	public DOMHighResTimeStamp StartTime { get; }
	[Value("duration")]
	public DOMHighResTimeStamp Duration { get; }
	[Value("navigationId")]
	public ulong NavigationId { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

[Value("PerformanceObserver")]
public partial class PerformanceObserver
{
		public PerformanceObserver(PerformanceObserverCallback callback) { }
	[Value("observe")]
	public Undefined Observe(PerformanceObserverInit options = default) { throw new System.NotImplementedException(); }
	[Value("disconnect")]
	public Undefined Disconnect() { throw new System.NotImplementedException(); }
	[Value("takeRecords")]
	public PerformanceEntryList TakeRecords() { throw new System.NotImplementedException(); }
	[Value("supportedEntryTypes")]
	public static DOMString[] SupportedEntryTypes { get; }
	public PerformanceObserver() { }
}

[Value("PerformanceObserverCallbackOptions")]
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

[Value("PerformanceObserverEntryList")]
public partial class PerformanceObserverEntryList
{
	[Value("getEntries")]
	public PerformanceEntryList GetEntries() { throw new System.NotImplementedException(); }
	[Value("getEntriesByType")]
	public PerformanceEntryList GetEntriesByType(DOMString type) { throw new System.NotImplementedException(); }
	[Value("getEntriesByName")]
	public PerformanceEntryList GetEntriesByName(DOMString name, DOMString type = default) { throw new System.NotImplementedException(); }
}

public partial class ServiceWorkerGlobalScope
{
	[Value("onperiodicsync")]
	public EventHandler Onperiodicsync { get; set; }
}

public partial class ServiceWorkerRegistration
{
	[Value("periodicSync")]
	public PeriodicSyncManager PeriodicSync { get; }
}

[Value("PeriodicSyncManager")]
public partial class PeriodicSyncManager
{
	[Value("register")]
	public Task<Undefined> Register(DOMString tag, BackgroundSyncOptions options = default) { throw new System.NotImplementedException(); }
	[Value("getTags")]
	public Task<List<DOMString>> GetTags() { throw new System.NotImplementedException(); }
	[Value("unregister")]
	public Task<Undefined> Unregister(DOMString tag) { throw new System.NotImplementedException(); }
}

[Value("BackgroundSyncOptions")]
public partial class BackgroundSyncOptions
{
	[Value("minInterval")]
	public ulong MinInterval;
}

[Value("PeriodicSyncEventInit")]
public partial class PeriodicSyncEventInit : ExtendableEventInit
{
	[Value("tag")]
	public required DOMString Tag;
}

[Value("PeriodicSyncEvent")]
public partial class PeriodicSyncEvent : ExtendableEvent
{
		public PeriodicSyncEvent(DOMString type, PeriodicSyncEventInit init) { }
	[Value("tag")]
	public DOMString Tag { get; }
	public PeriodicSyncEvent() { }
}

[Value("PermissionsPolicy")]
public partial class PermissionsPolicy
{
	[Value("allowsFeature")]
	public bool AllowsFeature(DOMString feature, DOMString origin = default) { throw new System.NotImplementedException(); }
	[Value("features")]
	public List<DOMString> Features() { throw new System.NotImplementedException(); }
	[Value("allowedFeatures")]
	public List<DOMString> AllowedFeatures() { throw new System.NotImplementedException(); }
	[Value("getAllowlistForFeature")]
	public List<DOMString> GetAllowlistForFeature(DOMString feature) { throw new System.NotImplementedException(); }
}

public partial class Document
{
	[Value("permissionsPolicy")]
	public PermissionsPolicy PermissionsPolicy { get; }
}

public partial class HTMLIFrameElement
{
	[Value("permissionsPolicy")]
	public PermissionsPolicy PermissionsPolicy { get; }
}

[Value("PermissionsPolicyViolationReportBody")]
public partial class PermissionsPolicyViolationReportBody : ReportBody
{
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
	[Value("featureId")]
	public DOMString FeatureId { get; }
	[Value("sourceFile")]
	public DOMString? SourceFile { get; }
	[Value("lineNumber")]
	public long? LineNumber { get; }
	[Value("columnNumber")]
	public long? ColumnNumber { get; }
	[Value("disposition")]
	public DOMString Disposition { get; }
	[Value("allowAttribute")]
	public DOMString? AllowAttribute { get; }
}

[Value("Permissions")]
public partial class Permissions
{
	[Value("request")]
	public Task<PermissionStatus> Request(Object permissionDesc) { throw new System.NotImplementedException(); }
}

public partial class Permissions
{
	[Value("revoke")]
	public Task<PermissionStatus> Revoke(Object permissionDesc) { throw new System.NotImplementedException(); }
}

public partial class Navigator
{
	[Value("permissions")]
	public Permissions Permissions { get; }
}

public partial class WorkerNavigator
{
	[Value("permissions")]
	public Permissions Permissions { get; }
}

public partial class Permissions
{
	[Value("query")]
	public Task<PermissionStatus> Query(Object permissionDesc) { throw new System.NotImplementedException(); }
}

[Value("PermissionDescriptor")]
public partial class PermissionDescriptor
{
	[Value("name")]
	public required DOMString Name;
}

[Value("PermissionStatus")]
public partial class PermissionStatus : EventTarget
{
	[Value("state")]
	public PermissionState State { get; }
	[Value("name")]
	public DOMString Name { get; }
	[Value("onchange")]
	public EventHandler Onchange { get; set; }
}

[Value("PermissionSetParameters")]
public partial class PermissionSetParameters
{
	[Value("descriptor")]
	public required Object Descriptor;
	[Value("state")]
	public required PermissionState State;
}

public partial class HTMLVideoElement
{
	[Value("requestPictureInPicture")]
	public Task<PictureInPictureWindow> RequestPictureInPicture() { throw new System.NotImplementedException(); }
	[Value("onenterpictureinpicture")]
	public EventHandler Onenterpictureinpicture { get; set; }
	[Value("onleavepictureinpicture")]
	public EventHandler Onleavepictureinpicture { get; set; }
	[Value("disablePictureInPicture")]
	public bool DisablePictureInPicture { get; set; }
}

public partial class Document
{
	[Value("pictureInPictureEnabled")]
	public bool PictureInPictureEnabled { get; }
	[Value("exitPictureInPicture")]
	public Task<Undefined> ExitPictureInPicture() { throw new System.NotImplementedException(); }
}

[Value("PictureInPictureWindow")]
public partial class PictureInPictureWindow : EventTarget
{
	[Value("width")]
	public long Width { get; }
	[Value("height")]
	public long Height { get; }
	[Value("onresize")]
	public EventHandler Onresize { get; set; }
}

[Value("PictureInPictureEvent")]
public partial class PictureInPictureEvent : Event
{
		public PictureInPictureEvent(DOMString type, PictureInPictureEventInit eventInitDict) { }
	[Value("pictureInPictureWindow")]
	public PictureInPictureWindow PictureInPictureWindow { get; }
	public PictureInPictureEvent() { }
}

[Value("PictureInPictureEventInit")]
public partial class PictureInPictureEventInit : EventInit
{
	[Value("pictureInPictureWindow")]
	public required PictureInPictureWindow PictureInPictureWindow;
}

[Value("PointerEventInit")]
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

[Value("PointerEvent")]
public partial class PointerEvent : MouseEvent
{
		public PointerEvent(DOMString type, PointerEventInit eventInitDict = default) { }
	[Value("pointerId")]
	public long PointerId { get; }
	[Value("width")]
	public Number Width { get; }
	[Value("height")]
	public Number Height { get; }
	[Value("pressure")]
	public Number Pressure { get; }
	[Value("tangentialPressure")]
	public Number TangentialPressure { get; }
	[Value("tiltX")]
	public long TiltX { get; }
	[Value("tiltY")]
	public long TiltY { get; }
	[Value("twist")]
	public long Twist { get; }
	[Value("altitudeAngle")]
	public Number AltitudeAngle { get; }
	[Value("azimuthAngle")]
	public Number AzimuthAngle { get; }
	[Value("pointerType")]
	public DOMString PointerType { get; }
	[Value("isPrimary")]
	public bool IsPrimary { get; }
	[Value("persistentDeviceId")]
	public long PersistentDeviceId { get; }
	[Value("getCoalescedEvents")]
	public List<PointerEvent> GetCoalescedEvents() { throw new System.NotImplementedException(); }
	[Value("getPredictedEvents")]
	public List<PointerEvent> GetPredictedEvents() { throw new System.NotImplementedException(); }
	public PointerEvent() { }
}

public partial class Element
{
	[Value("setPointerCapture")]
	public Undefined SetPointerCapture(long pointerId) { throw new System.NotImplementedException(); }
	[Value("releasePointerCapture")]
	public Undefined ReleasePointerCapture(long pointerId) { throw new System.NotImplementedException(); }
	[Value("hasPointerCapture")]
	public bool HasPointerCapture(long pointerId) { throw new System.NotImplementedException(); }
}

public partial class Navigator
{
	[Value("maxTouchPoints")]
	public long MaxTouchPoints { get; }
}

[Value("PointerLockOptions")]
public partial class PointerLockOptions
{
	[Value("unadjustedMovement")]
	public bool UnadjustedMovement;
}

public partial class Element
{
	[Value("requestPointerLock")]
	public Task<Undefined> RequestPointerLock(PointerLockOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class Document
{
	[Value("onpointerlockchange")]
	public EventHandler Onpointerlockchange { get; set; }
	[Value("onpointerlockerror")]
	public EventHandler Onpointerlockerror { get; set; }
	[Value("exitPointerLock")]
	public Undefined ExitPointerLock() { throw new System.NotImplementedException(); }
}

public partial class MouseEvent
{
	[Value("movementX")]
	public Number MovementX { get; }
	[Value("movementY")]
	public Number MovementY { get; }
}

[Value("MouseEventInit")]
public partial class MouseEventInit
{
	[Value("movementX")]
	public Number MovementX;
	[Value("movementY")]
	public Number MovementY;
}

[Value("HTMLPortalElement")]
public partial class HTMLPortalElement : HTMLElement
{
		public HTMLPortalElement() { }
	[Value("src")]
	public USVString Src { get; set; }
	[Value("referrerPolicy")]
	public DOMString ReferrerPolicy { get; set; }
	[Value("activate")]
	public Task<Undefined> Activate(PortalActivateOptions options = default) { throw new System.NotImplementedException(); }
	[Value("postMessage")]
	public Undefined PostMessage(dynamic message, StructuredSerializeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("onmessage")]
	public EventHandler Onmessage { get; set; }
	[Value("onmessageerror")]
	public EventHandler Onmessageerror { get; set; }
}

[Value("PortalActivateOptions")]
public partial class PortalActivateOptions : StructuredSerializeOptions
{
	[Value("data")]
	public dynamic Data;
}

public partial class Window
{
	[Value("portalHost")]
	public PortalHost? PortalHost { get; }
}

[Value("PortalHost")]
public partial class PortalHost : EventTarget
{
	[Value("postMessage")]
	public Undefined PostMessage(dynamic message, StructuredSerializeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("onmessage")]
	public EventHandler Onmessage { get; set; }
	[Value("onmessageerror")]
	public EventHandler Onmessageerror { get; set; }
}

[Value("PortalActivateEvent")]
public partial class PortalActivateEvent : Event
{
		public PortalActivateEvent(DOMString type, PortalActivateEventInit eventInitDict = default) { }
	[Value("data")]
	public dynamic Data { get; }
	[Value("adoptPredecessor")]
	public HTMLPortalElement AdoptPredecessor() { throw new System.NotImplementedException(); }
	public PortalActivateEvent() { }
}

[Value("PortalActivateEventInit")]
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

public partial class Document
{
	[Value("prerendering")]
	public bool Prerendering { get; }
	[Value("onprerenderingchange")]
	public EventHandler Onprerenderingchange { get; set; }
}

public partial class PerformanceNavigationTiming
{
	[Value("activationStart")]
	public DOMHighResTimeStamp ActivationStart { get; }
}

public partial class Navigator
{
	[Value("presentation")]
	public Presentation Presentation { get; }
}

[Value("Presentation")]
public partial class Presentation
{
}

public partial class Presentation
{
	[Value("defaultRequest")]
	public PresentationRequest? DefaultRequest { get; set; }
}

public partial class Presentation
{
	[Value("receiver")]
	public PresentationReceiver? Receiver { get; }
}

[Value("PresentationRequest")]
public partial class PresentationRequest : EventTarget
{
		public PresentationRequest(USVString url) { }
		public PresentationRequest(List<USVString> urls) { }
	[Value("start")]
	public Task<PresentationConnection> Start() { throw new System.NotImplementedException(); }
	[Value("reconnect")]
	public Task<PresentationConnection> Reconnect(USVString presentationId) { throw new System.NotImplementedException(); }
	[Value("getAvailability")]
	public Task<PresentationAvailability> GetAvailability() { throw new System.NotImplementedException(); }
	[Value("onconnectionavailable")]
	public EventHandler Onconnectionavailable { get; set; }
	public PresentationRequest() { }
}

[Value("PresentationAvailability")]
public partial class PresentationAvailability : EventTarget
{
	[Value("value")]
	public bool Value { get; }
	[Value("onchange")]
	public EventHandler Onchange { get; set; }
}

[Value("PresentationConnectionAvailableEvent")]
public partial class PresentationConnectionAvailableEvent : Event
{
		public PresentationConnectionAvailableEvent(DOMString type, PresentationConnectionAvailableEventInit eventInitDict) { }
	[Value("connection")]
	public PresentationConnection Connection { get; }
	public PresentationConnectionAvailableEvent() { }
}

[Value("PresentationConnectionAvailableEventInit")]
public partial class PresentationConnectionAvailableEventInit : EventInit
{
	[Value("connection")]
	public required PresentationConnection Connection;
}

[Value("PresentationConnection")]
public partial class PresentationConnection : EventTarget
{
	[Value("id")]
	public USVString Id { get; }
	[Value("url")]
	public USVString Url { get; }
	[Value("state")]
	public PresentationConnectionState State { get; }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	[Value("terminate")]
	public Undefined Terminate() { throw new System.NotImplementedException(); }
	[Value("onconnect")]
	public EventHandler Onconnect { get; set; }
	[Value("onclose")]
	public EventHandler Onclose { get; set; }
	[Value("onterminate")]
	public EventHandler Onterminate { get; set; }
	[Value("binaryType")]
	public BinaryType BinaryType { get; set; }
	[Value("onmessage")]
	public EventHandler Onmessage { get; set; }
	[Value("send")]
	public Undefined Send(DOMString message) { throw new System.NotImplementedException(); }
	[Value("send")]
	public Undefined Send(Blob data) { throw new System.NotImplementedException(); }
	[Value("send")]
	public Undefined Send(ArrayBuffer data) { throw new System.NotImplementedException(); }
	[Value("send")]
	public Undefined Send(ArrayBufferView data) { throw new System.NotImplementedException(); }
}

[Value("PresentationConnectionCloseEvent")]
public partial class PresentationConnectionCloseEvent : Event
{
		public PresentationConnectionCloseEvent(DOMString type, PresentationConnectionCloseEventInit eventInitDict) { }
	[Value("reason")]
	public PresentationConnectionCloseReason Reason { get; }
	[Value("message")]
	public DOMString Message { get; }
	public PresentationConnectionCloseEvent() { }
}

[Value("PresentationConnectionCloseEventInit")]
public partial class PresentationConnectionCloseEventInit : EventInit
{
	[Value("reason")]
	public required PresentationConnectionCloseReason Reason;
	[Value("message")]
	public DOMString Message;
}

[Value("PresentationReceiver")]
public partial class PresentationReceiver
{
	[Value("connectionList")]
	public Task<PresentationConnectionList> ConnectionList { get; }
}

[Value("PresentationConnectionList")]
public partial class PresentationConnectionList : EventTarget
{
	[Value("connections")]
	public PresentationConnection[] Connections { get; }
	[Value("onconnectionavailable")]
	public EventHandler Onconnectionavailable { get; set; }
}

[Value("PrivateAggregation")]
public partial class PrivateAggregation
{
	[Value("contributeToHistogram")]
	public Undefined ContributeToHistogram(PAHistogramContribution contribution) { throw new System.NotImplementedException(); }
	[Value("enableDebugMode")]
	public Undefined EnableDebugMode(PADebugModeOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("PAHistogramContribution")]
public partial class PAHistogramContribution
{
	[Value("bucket")]
	public required BigInt Bucket;
	[Value("value")]
	public required long Value;
	[Value("filteringId")]
	public BigInt FilteringId;
}

[Value("PADebugModeOptions")]
public partial class PADebugModeOptions
{
	[Value("debugKey")]
	public required BigInt DebugKey;
}

public partial class HTMLAnchorElement
{
	[Value("attributionSourceId")]
	public ulong AttributionSourceId { get; set; }
}

[Value("PrivateNetworkAccessPermissionDescriptor")]
public partial class PrivateNetworkAccessPermissionDescriptor : PermissionDescriptor
{
	[Value("id")]
	public DOMString Id;
}

public partial class RequestInit
{
	[Value("targetAddressSpace")]
	public IPAddressSpace TargetAddressSpace;
}

public partial class Request
{
	[Value("targetAddressSpace")]
	public IPAddressSpace TargetAddressSpace { get; }
}

[Value("ProximitySensor")]
public partial class ProximitySensor : Sensor
{
		public ProximitySensor(SensorOptions sensorOptions = default) { }
	[Value("distance")]
	public Number? Distance { get; }
	[Value("max")]
	public Number? Max { get; }
	[Value("near")]
	public bool? Near { get; }
	public ProximitySensor() { }
}

[Value("PushPermissionDescriptor")]
public partial class PushPermissionDescriptor : PermissionDescriptor
{
	[Value("userVisibleOnly")]
	public bool UserVisibleOnly;
}

public partial class ServiceWorkerRegistration
{
	[Value("pushManager")]
	public PushManager PushManager { get; }
}

[Value("PushManager")]
public partial class PushManager
{
	[Value("supportedContentEncodings")]
	public static DOMString[] SupportedContentEncodings { get; }
	[Value("subscribe")]
	public Task<PushSubscription> Subscribe(PushSubscriptionOptionsInit options = default) { throw new System.NotImplementedException(); }
	[Value("getSubscription")]
	public Task<PushSubscription?> GetSubscription() { throw new System.NotImplementedException(); }
	[Value("permissionState")]
	public Task<PermissionState> PermissionState(PushSubscriptionOptionsInit options = default) { throw new System.NotImplementedException(); }
}

[Value("PushSubscriptionOptions")]
public partial class PushSubscriptionOptions
{
	[Value("userVisibleOnly")]
	public bool UserVisibleOnly { get; }
	[Value("applicationServerKey")]
	public ArrayBuffer? ApplicationServerKey { get; }
}

[Value("PushSubscriptionOptionsInit")]
public partial class PushSubscriptionOptionsInit
{
	[Value("userVisibleOnly")]
	public bool UserVisibleOnly;
	[Value("applicationServerKey")]
	public Union122? ApplicationServerKey;
}

[Value("PushSubscription")]
public partial class PushSubscription
{
	[Value("endpoint")]
	public USVString Endpoint { get; }
	[Value("expirationTime")]
	public EpochTimeStamp? ExpirationTime { get; }
	[Value("options")]
	public PushSubscriptionOptions Options { get; }
	[Value("getKey")]
	public ArrayBuffer? GetKey(PushEncryptionKeyName name) { throw new System.NotImplementedException(); }
	[Value("unsubscribe")]
	public Task<bool> Unsubscribe() { throw new System.NotImplementedException(); }
	[Value("toJSON")]
	public PushSubscriptionJSON ToJSON() { throw new System.NotImplementedException(); }
}

[Value("PushSubscriptionJSON")]
public partial class PushSubscriptionJSON
{
	[Value("endpoint")]
	public USVString Endpoint;
	[Value("expirationTime")]
	public EpochTimeStamp? ExpirationTime;
	[Value("keys")]
	public Dictionary<DOMString, USVString> Keys;
}

[Value("PushMessageData")]
public partial class PushMessageData
{
	[Value("arrayBuffer")]
	public ArrayBuffer ArrayBuffer() { throw new System.NotImplementedException(); }
	[Value("blob")]
	public Blob Blob() { throw new System.NotImplementedException(); }
	[Value("bytes")]
	public Uint8Array Bytes() { throw new System.NotImplementedException(); }
	[Value("json")]
	public dynamic Json() { throw new System.NotImplementedException(); }
	[Value("text")]
	public USVString Text() { throw new System.NotImplementedException(); }
}

public partial class ServiceWorkerGlobalScope
{
	[Value("onpush")]
	public EventHandler Onpush { get; set; }
	[Value("onpushsubscriptionchange")]
	public EventHandler Onpushsubscriptionchange { get; set; }
}

[Value("PushEvent")]
public partial class PushEvent : ExtendableEvent
{
		public PushEvent(DOMString type, PushEventInit eventInitDict = default) { }
	[Value("data")]
	public PushMessageData? Data { get; }
	public PushEvent() { }
}


[Value("PushEventInit")]
public partial class PushEventInit : ExtendableEventInit
{
	[Value("data")]
	public PushMessageDataInit Data;
}

[Value("PushSubscriptionChangeEvent")]
public partial class PushSubscriptionChangeEvent : ExtendableEvent
{
		public PushSubscriptionChangeEvent(DOMString type, PushSubscriptionChangeEventInit eventInitDict = default) { }
	[Value("newSubscription")]
	public PushSubscription? NewSubscription { get; }
	[Value("oldSubscription")]
	public PushSubscription? OldSubscription { get; }
	public PushSubscriptionChangeEvent() { }
}

[Value("PushSubscriptionChangeEventInit")]
public partial class PushSubscriptionChangeEventInit : ExtendableEventInit
{
	[Value("newSubscription")]
	public PushSubscription NewSubscription;
	[Value("oldSubscription")]
	public PushSubscription OldSubscription;
}

[Value("XRView")]
public partial class XRView
{
	[Value("camera")]
	public XRCamera? Camera { get; }
}

[Value("XRCamera")]
public partial class XRCamera
{
	[Value("width")]
	public ulong Width { get; }
	[Value("height")]
	public ulong Height { get; }
}

[Value("XRWebGLBinding")]
public partial class XRWebGLBinding
{
	[Value("getCameraImage")]
	public WebGLTexture? GetCameraImage(XRCamera camera) { throw new System.NotImplementedException(); }
}

[Value("XRMesh")]
public partial class XRMesh
{
	[Value("meshSpace")]
	public XRSpace MeshSpace { get; }
	[Value("vertices")]
	public Float32Array[] Vertices { get; }
	[Value("indices")]
	public Uint32Array Indices { get; }
	[Value("lastChangedTime")]
	public DOMHighResTimeStamp LastChangedTime { get; }
	[Value("semanticLabel")]
	public DOMString? SemanticLabel { get; }
}

[Value("XRMeshSet")]
public partial class XRMeshSet
{
	
}

public partial class XRFrame
{
	[Value("detectedMeshes")]
	public XRMeshSet DetectedMeshes { get; }
}

[Value("RemotePlayback")]
public partial class RemotePlayback : EventTarget
{
	[Value("watchAvailability")]
	public Task<long> WatchAvailability(RemotePlaybackAvailabilityCallback callback) { throw new System.NotImplementedException(); }
	[Value("cancelWatchAvailability")]
	public Task<Undefined> CancelWatchAvailability(long id = default) { throw new System.NotImplementedException(); }
	[Value("state")]
	public RemotePlaybackState State { get; }
	[Value("onconnecting")]
	public EventHandler Onconnecting { get; set; }
	[Value("onconnect")]
	public EventHandler Onconnect { get; set; }
	[Value("ondisconnect")]
	public EventHandler Ondisconnect { get; set; }
	[Value("prompt")]
	public Task<Undefined> Prompt() { throw new System.NotImplementedException(); }
}

public partial class HTMLMediaElement
{
	[Value("remote")]
	public RemotePlayback Remote { get; }
	[Value("disableRemotePlayback")]
	public bool DisableRemotePlayback { get; set; }
}

[Value("ReportBody")]
public partial class ReportBody
{
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

[Value("Report")]
public partial class Report
{
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
	[Value("type")]
	public DOMString Type { get; }
	[Value("url")]
	public DOMString Url { get; }
	[Value("body")]
	public ReportBody? Body { get; }
}

[Value("ReportingObserver")]
public partial class ReportingObserver
{
		public ReportingObserver(ReportingObserverCallback callback, ReportingObserverOptions options = default) { }
	[Value("observe")]
	public Undefined Observe() { throw new System.NotImplementedException(); }
	[Value("disconnect")]
	public Undefined Disconnect() { throw new System.NotImplementedException(); }
	[Value("takeRecords")]
	public ReportList TakeRecords() { throw new System.NotImplementedException(); }
	public ReportingObserver() { }
}

[Value("ReportingObserverOptions")]
public partial class ReportingObserverOptions
{
	[Value("types")]
	public List<DOMString> Types;
	[Value("buffered")]
	public bool Buffered;
}


[Value("GenerateTestReportParameters")]
public partial class GenerateTestReportParameters
{
	[Value("message")]
	public required DOMString Message;
	[Value("group")]
	public DOMString Group;
}

public partial class Window
{
	[Value("requestIdleCallback")]
	public ulong RequestIdleCallback(IdleRequestCallback callback, IdleRequestOptions options = default) { throw new System.NotImplementedException(); }
	[Value("cancelIdleCallback")]
	public Undefined CancelIdleCallback(ulong handle) { throw new System.NotImplementedException(); }
}

[Value("IdleRequestOptions")]
public partial class IdleRequestOptions
{
	[Value("timeout")]
	public ulong Timeout;
}

[Value("IdleDeadline")]
public partial class IdleDeadline
{
	[Value("timeRemaining")]
	public DOMHighResTimeStamp TimeRemaining() { throw new System.NotImplementedException(); }
	[Value("didTimeout")]
	public bool DidTimeout { get; }
}

public partial class Document
{
	[Value("requestStorageAccessFor")]
	public Task<Undefined> RequestStorageAccessFor(USVString requestedOrigin) { throw new System.NotImplementedException(); }
}

[Value("TopLevelStorageAccessPermissionDescriptor")]
public partial class TopLevelStorageAccessPermissionDescriptor : PermissionDescriptor
{
	[Value("requestedOrigin")]
	public USVString RequestedOrigin;
}

[Value("ResizeObserverOptions")]
public partial class ResizeObserverOptions
{
	[Value("box")]
	public ResizeObserverBoxOptions Box;
}

[Value("ResizeObserver")]
public partial class ResizeObserver
{
		public ResizeObserver(ResizeObserverCallback callback) { }
	[Value("observe")]
	public Undefined Observe(Element target, ResizeObserverOptions options = default) { throw new System.NotImplementedException(); }
	[Value("unobserve")]
	public Undefined Unobserve(Element target) { throw new System.NotImplementedException(); }
	[Value("disconnect")]
	public Undefined Disconnect() { throw new System.NotImplementedException(); }
	public ResizeObserver() { }
}

[Value("ResizeObserverEntry")]
public partial class ResizeObserverEntry
{
	[Value("target")]
	public Element Target { get; }
	[Value("contentRect")]
	public DOMRectReadOnly ContentRect { get; }
	[Value("borderBoxSize")]
	public ResizeObserverSize[] BorderBoxSize { get; }
	[Value("contentBoxSize")]
	public ResizeObserverSize[] ContentBoxSize { get; }
	[Value("devicePixelContentBoxSize")]
	public ResizeObserverSize[] DevicePixelContentBoxSize { get; }
}

[Value("ResizeObserverSize")]
public partial class ResizeObserverSize
{
	[Value("inlineSize")]
	public double InlineSize { get; }
	[Value("blockSize")]
	public double BlockSize { get; }
}

[Value("PerformanceResourceTiming")]
public partial class PerformanceResourceTiming : PerformanceEntry
{
	[Value("initiatorType")]
	public DOMString InitiatorType { get; }
	[Value("deliveryType")]
	public DOMString DeliveryType { get; }
	[Value("nextHopProtocol")]
	public ByteString NextHopProtocol { get; }
	[Value("workerStart")]
	public DOMHighResTimeStamp WorkerStart { get; }
	[Value("redirectStart")]
	public DOMHighResTimeStamp RedirectStart { get; }
	[Value("redirectEnd")]
	public DOMHighResTimeStamp RedirectEnd { get; }
	[Value("fetchStart")]
	public DOMHighResTimeStamp FetchStart { get; }
	[Value("domainLookupStart")]
	public DOMHighResTimeStamp DomainLookupStart { get; }
	[Value("domainLookupEnd")]
	public DOMHighResTimeStamp DomainLookupEnd { get; }
	[Value("connectStart")]
	public DOMHighResTimeStamp ConnectStart { get; }
	[Value("connectEnd")]
	public DOMHighResTimeStamp ConnectEnd { get; }
	[Value("secureConnectionStart")]
	public DOMHighResTimeStamp SecureConnectionStart { get; }
	[Value("requestStart")]
	public DOMHighResTimeStamp RequestStart { get; }
	[Value("finalResponseHeadersStart")]
	public DOMHighResTimeStamp FinalResponseHeadersStart { get; }
	[Value("firstInterimResponseStart")]
	public DOMHighResTimeStamp FirstInterimResponseStart { get; }
	[Value("responseStart")]
	public DOMHighResTimeStamp ResponseStart { get; }
	[Value("responseEnd")]
	public DOMHighResTimeStamp ResponseEnd { get; }
	[Value("transferSize")]
	public ulong TransferSize { get; }
	[Value("encodedBodySize")]
	public ulong EncodedBodySize { get; }
	[Value("decodedBodySize")]
	public ulong DecodedBodySize { get; }
	[Value("responseStatus")]
	public ushort ResponseStatus { get; }
	[Value("renderBlockingStatus")]
	public RenderBlockingStatusType RenderBlockingStatus { get; }
	[Value("contentType")]
	public DOMString ContentType { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

public partial class Performance
{
	[Value("clearResourceTimings")]
	public Undefined ClearResourceTimings() { throw new System.NotImplementedException(); }
	[Value("setResourceTimingBufferSize")]
	public Undefined SetResourceTimingBufferSize(ulong maxSize) { throw new System.NotImplementedException(); }
	[Value("onresourcetimingbufferfull")]
	public EventHandler Onresourcetimingbufferfull { get; set; }
}

[Value("StorageAccessTypes")]
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

[Value("StorageAccessHandle")]
public partial class StorageAccessHandle
{
	[Value("sessionStorage")]
	public Storage SessionStorage { get; }
	[Value("localStorage")]
	public Storage LocalStorage { get; }
	[Value("indexedDB")]
	public IDBFactory IndexedDB { get; }
	[Value("locks")]
	public LockManager Locks { get; }
	[Value("caches")]
	public CacheStorage Caches { get; }
	[Value("getDirectory")]
	public Task<FileSystemDirectoryHandle> GetDirectory() { throw new System.NotImplementedException(); }
	[Value("estimate")]
	public Task<StorageEstimate> Estimate() { throw new System.NotImplementedException(); }
	[Value("createObjectURL")]
	public DOMString CreateObjectURL(Union124 obj) { throw new System.NotImplementedException(); }
	[Value("revokeObjectURL")]
	public Undefined RevokeObjectURL(DOMString url) { throw new System.NotImplementedException(); }
	[Value("BroadcastChannel")]
	public BroadcastChannel BroadcastChannel(DOMString name) { throw new System.NotImplementedException(); }
	[Value("SharedWorker")]
	public SharedWorker SharedWorker(USVString scriptURL, Union125 options = default) { throw new System.NotImplementedException(); }
}

public partial class Document
{
	[Value("hasUnpartitionedCookieAccess")]
	public Task<bool> HasUnpartitionedCookieAccess() { throw new System.NotImplementedException(); }
}

[Value("SharedWorkerOptions")]
public partial class SharedWorkerOptions : WorkerOptions
{
	[Value("sameSiteCookies")]
	public SameSiteCookiesType SameSiteCookies;
}

[Value("SetHTMLOptions")]
public partial class SetHTMLOptions
{
	[Value("sanitizer")]
	public Union126 Sanitizer;
}

[Value("SetHTMLUnsafeOptions")]
public partial class SetHTMLUnsafeOptions
{
	[Value("sanitizer")]
	public Union127 Sanitizer;
}

[Value("Sanitizer")]
public partial class Sanitizer
{
		public Sanitizer(Union128 configuration = default) { }
	[Value("get")]
	public SanitizerConfig Get() { throw new System.NotImplementedException(); }
	[Value("allowElement")]
	public Undefined AllowElement(SanitizerElementWithAttributes element) { throw new System.NotImplementedException(); }
	[Value("removeElement")]
	public Undefined RemoveElement(SanitizerElement element) { throw new System.NotImplementedException(); }
	[Value("replaceElementWithChildren")]
	public Undefined ReplaceElementWithChildren(SanitizerElement element) { throw new System.NotImplementedException(); }
	[Value("allowAttribute")]
	public Undefined AllowAttribute(SanitizerAttribute attribute) { throw new System.NotImplementedException(); }
	[Value("removeAttribute")]
	public Undefined RemoveAttribute(SanitizerAttribute attribute) { throw new System.NotImplementedException(); }
	[Value("setComments")]
	public Undefined SetComments(bool allow) { throw new System.NotImplementedException(); }
	[Value("setDataAttributes")]
	public Undefined SetDataAttributes(bool allow) { throw new System.NotImplementedException(); }
	[Value("removeUnsafe")]
	public Undefined RemoveUnsafe() { throw new System.NotImplementedException(); }
	public Sanitizer() { }
}

[Value("SanitizerElementNamespace")]
public partial class SanitizerElementNamespace
{
	[Value("name")]
	public required DOMString Name;
	[Value("namespace")]
	public DOMString? Namespace;
}

[Value("SanitizerElementNamespaceWithAttributes")]
public partial class SanitizerElementNamespaceWithAttributes : SanitizerElementNamespace
{
	[Value("attributes")]
	public List<SanitizerAttribute> Attributes;
	[Value("removeAttributes")]
	public List<SanitizerAttribute> RemoveAttributes;
}



[Value("SanitizerAttributeNamespace")]
public partial class SanitizerAttributeNamespace
{
	[Value("name")]
	public required DOMString Name;
	[Value("namespace")]
	public DOMString? Namespace;
}


[Value("SanitizerConfig")]
public partial class SanitizerConfig
{
	[Value("elements")]
	public List<SanitizerElementWithAttributes> Elements;
	[Value("removeElements")]
	public List<SanitizerElement> RemoveElements;
	[Value("replaceWithChildrenElements")]
	public List<SanitizerElement> ReplaceWithChildrenElements;
	[Value("attributes")]
	public List<SanitizerAttribute> Attributes;
	[Value("removeAttributes")]
	public List<SanitizerAttribute> RemoveAttributes;
	[Value("comments")]
	public bool Comments;
	[Value("dataAttributes")]
	public bool DataAttributes;
}

[Value("SchedulerPostTaskOptions")]
public partial class SchedulerPostTaskOptions
{
	[Value("signal")]
	public AbortSignal Signal;
	[Value("priority")]
	public TaskPriority Priority;
	[Value("delay")]
	public ulong Delay;
}

[Value("Scheduler")]
public partial class Scheduler
{
	[Value("postTask")]
	public Task<dynamic> PostTask(SchedulerPostTaskCallback callback, SchedulerPostTaskOptions options = default) { throw new System.NotImplementedException(); }
	[Value("yield")]
	public Task<Undefined> Yield() { throw new System.NotImplementedException(); }
}

[Value("TaskPriorityChangeEvent")]
public partial class TaskPriorityChangeEvent : Event
{
		public TaskPriorityChangeEvent(DOMString type, TaskPriorityChangeEventInit priorityChangeEventInitDict) { }
	[Value("previousPriority")]
	public TaskPriority PreviousPriority { get; }
	public TaskPriorityChangeEvent() { }
}

[Value("TaskPriorityChangeEventInit")]
public partial class TaskPriorityChangeEventInit : EventInit
{
	[Value("previousPriority")]
	public required TaskPriority PreviousPriority;
}

[Value("TaskControllerInit")]
public partial class TaskControllerInit
{
	[Value("priority")]
	public TaskPriority Priority;
}

[Value("TaskController")]
public partial class TaskController : AbortController
{
		public TaskController(TaskControllerInit init = default) { }
	[Value("setPriority")]
	public Undefined SetPriority(TaskPriority priority) { throw new System.NotImplementedException(); }
	public TaskController() { }
}

[Value("TaskSignalAnyInit")]
public partial class TaskSignalAnyInit
{
	[Value("priority")]
	public Union132 Priority;
}

[Value("TaskSignal")]
public partial class TaskSignal : AbortSignal
{
	[Value("any")]
	public static TaskSignal Any(List<AbortSignal> signals, TaskSignalAnyInit init = default) { throw new System.NotImplementedException(); }
	[Value("priority")]
	public TaskPriority Priority { get; }
	[Value("onprioritychange")]
	public EventHandler Onprioritychange { get; set; }
}

public partial class MediaDevices
{
	[Value("getDisplayMedia")]
	public Task<MediaStream> GetDisplayMedia(DisplayMediaStreamOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class CaptureController : EventTarget
{
	
	[Value("setFocusBehavior")]
	public Undefined SetFocusBehavior(CaptureStartFocusBehavior focusBehavior) { throw new System.NotImplementedException(); }
}

[Value("DisplayMediaStreamOptions")]
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

public partial class MediaTrackSupportedConstraints
{
	[Value("displaySurface")]
	public bool DisplaySurface;
	[Value("logicalSurface")]
	public bool LogicalSurface;
	[Value("cursor")]
	public bool Cursor;
	[Value("restrictOwnAudio")]
	public bool RestrictOwnAudio;
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

public partial class MediaTrackSettings
{
	[Value("displaySurface")]
	public DOMString DisplaySurface;
	[Value("logicalSurface")]
	public bool LogicalSurface;
	[Value("cursor")]
	public DOMString Cursor;
	[Value("restrictOwnAudio")]
	public bool RestrictOwnAudio;
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

public partial class Screen
{
	[Value("orientation")]
	public ScreenOrientation Orientation { get; }
}

[Value("ScreenOrientation")]
public partial class ScreenOrientation : EventTarget
{
	[Value("lock")]
	public Task<Undefined> Lock(OrientationLockType orientation) { throw new System.NotImplementedException(); }
	[Value("unlock")]
	public Undefined Unlock() { throw new System.NotImplementedException(); }
	[Value("type")]
	public OrientationType Type { get; }
	[Value("angle")]
	public ushort Angle { get; }
	[Value("onchange")]
	public EventHandler Onchange { get; set; }
}

public partial class Navigator
{
	[Value("wakeLock")]
	public WakeLock WakeLock { get; }
}

[Value("WakeLock")]
public partial class WakeLock
{
	[Value("request")]
	public Task<WakeLockSentinel> Request(WakeLockType type = default) { throw new System.NotImplementedException(); }
}

[Value("WakeLockSentinel")]
public partial class WakeLockSentinel : EventTarget
{
	[Value("released")]
	public bool Released { get; }
	[Value("type")]
	public WakeLockType Type { get; }
	[Value("release")]
	public Task<Undefined> Release() { throw new System.NotImplementedException(); }
	[Value("onrelease")]
	public EventHandler Onrelease { get; set; }
}

[Value("ScrollTimelineOptions")]
public partial class ScrollTimelineOptions
{
	[Value("source")]
	public Element? Source;
	[Value("axis")]
	public ScrollAxis Axis;
}

[Value("ScrollTimeline")]
public partial class ScrollTimeline : AnimationTimeline
{
		public ScrollTimeline(ScrollTimelineOptions options = default) { }
	[Value("source")]
	public Element? Source { get; }
	[Value("axis")]
	public ScrollAxis Axis { get; }
	public ScrollTimeline() { }
}

[Value("ViewTimelineOptions")]
public partial class ViewTimelineOptions
{
	[Value("subject")]
	public Element Subject;
	[Value("axis")]
	public ScrollAxis Axis;
	[Value("inset")]
	public Union135 Inset;
}

[Value("ViewTimeline")]
public partial class ViewTimeline : ScrollTimeline
{
		public ViewTimeline(ViewTimelineOptions options = default) { }
	[Value("subject")]
	public Element Subject { get; }
	[Value("startOffset")]
	public CSSNumericValue StartOffset { get; }
	[Value("endOffset")]
	public CSSNumericValue EndOffset { get; }
	public ViewTimeline() { }
}

[Value("FragmentDirective")]
public partial class FragmentDirective
{
}

public partial class Document
{
	[Value("fragmentDirective")]
	public FragmentDirective FragmentDirective { get; }
}

[Value("SecurePaymentConfirmationRequest")]
public partial class SecurePaymentConfirmationRequest
{
	[Value("challenge")]
	public required BufferSource Challenge;
	[Value("rpId")]
	public required USVString RpId;
	[Value("credentialIds")]
	public required List<BufferSource> CredentialIds;
	[Value("instrument")]
	public required PaymentCredentialInstrument Instrument;
	[Value("timeout")]
	public ulong Timeout;
	[Value("payeeName")]
	public USVString PayeeName;
	[Value("payeeOrigin")]
	public USVString PayeeOrigin;
	[Value("extensions")]
	public AuthenticationExtensionsClientInputs Extensions;
	[Value("locale")]
	public List<USVString> Locale;
	[Value("showOptOut")]
	public bool ShowOptOut;
}

public partial class PaymentRequest
{
	[Value("isSecurePaymentConfirmationAvailable")]
	public static Task<bool> IsSecurePaymentConfirmationAvailable() { throw new System.NotImplementedException(); }
}

public partial class AuthenticationExtensionsClientInputs
{
	[Value("payment")]
	public AuthenticationExtensionsPaymentInputs Payment;
}

[Value("AuthenticationExtensionsPaymentInputs")]
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

[Value("CollectedClientPaymentData")]
public partial class CollectedClientPaymentData : CollectedClientData
{
	[Value("payment")]
	public required CollectedClientAdditionalPaymentData Payment;
}

[Value("CollectedClientAdditionalPaymentData")]
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

[Value("PaymentCredentialInstrument")]
public partial class PaymentCredentialInstrument
{
	[Value("displayName")]
	public required USVString DisplayName;
	[Value("icon")]
	public required USVString Icon;
	[Value("iconMustBeShown")]
	public bool IconMustBeShown;
}

[Value("Selection")]
public partial class Selection
{
	[Value("anchorNode")]
	public Node? AnchorNode { get; }
	[Value("anchorOffset")]
	public ulong AnchorOffset { get; }
	[Value("focusNode")]
	public Node? FocusNode { get; }
	[Value("focusOffset")]
	public ulong FocusOffset { get; }
	[Value("isCollapsed")]
	public bool IsCollapsed { get; }
	[Value("rangeCount")]
	public ulong RangeCount { get; }
	[Value("type")]
	public DOMString Type { get; }
	[Value("direction")]
	public DOMString Direction { get; }
	[Value("getRangeAt")]
	public Range GetRangeAt(ulong index) { throw new System.NotImplementedException(); }
	[Value("addRange")]
	public Undefined AddRange(Range range) { throw new System.NotImplementedException(); }
	[Value("removeRange")]
	public Undefined RemoveRange(Range range) { throw new System.NotImplementedException(); }
	[Value("removeAllRanges")]
	public Undefined RemoveAllRanges() { throw new System.NotImplementedException(); }
	[Value("empty")]
	public Undefined Empty() { throw new System.NotImplementedException(); }
	[Value("getComposedRanges")]
	public List<StaticRange> GetComposedRanges(GetComposedRangesOptions options = default) { throw new System.NotImplementedException(); }
	[Value("collapse")]
	public Undefined Collapse(Node? node, ulong offset = default) { throw new System.NotImplementedException(); }
	[Value("setPosition")]
	public Undefined SetPosition(Node? node, ulong offset = default) { throw new System.NotImplementedException(); }
	[Value("collapseToStart")]
	public Undefined CollapseToStart() { throw new System.NotImplementedException(); }
	[Value("collapseToEnd")]
	public Undefined CollapseToEnd() { throw new System.NotImplementedException(); }
	[Value("extend")]
	public Undefined Extend(Node node, ulong offset = default) { throw new System.NotImplementedException(); }
	[Value("setBaseAndExtent")]
	public Undefined SetBaseAndExtent(Node anchorNode, ulong anchorOffset, Node focusNode, ulong focusOffset) { throw new System.NotImplementedException(); }
	[Value("selectAllChildren")]
	public Undefined SelectAllChildren(Node node) { throw new System.NotImplementedException(); }
	[Value("modify")]
	public Undefined Modify(DOMString alter = default, DOMString direction = default, DOMString granularity = default) { throw new System.NotImplementedException(); }
	[Value("deleteFromDocument")]
	public Undefined DeleteFromDocument() { throw new System.NotImplementedException(); }
	[Value("containsNode")]
	public bool ContainsNode(Node node, bool allowPartialContainment = default) { throw new System.NotImplementedException(); }
	
}

[Value("GetComposedRangesOptions")]
public partial class GetComposedRangesOptions
{
	[Value("shadowRoots")]
	public List<ShadowRoot> ShadowRoots;
}

public partial class Document
{
	[Value("getSelection")]
	public Selection? GetSelection() { throw new System.NotImplementedException(); }
}

public partial class Window
{
	[Value("getSelection")]
	public Selection? GetSelection() { throw new System.NotImplementedException(); }
}

public partial class Navigator
{
	[Value("serial")]
	public Serial Serial { get; }
}

public partial class WorkerNavigator
{
	[Value("serial")]
	public Serial Serial { get; }
}

[Value("Serial")]
public partial class Serial : EventTarget
{
	[Value("onconnect")]
	public EventHandler Onconnect { get; set; }
	[Value("ondisconnect")]
	public EventHandler Ondisconnect { get; set; }
	[Value("getPorts")]
	public Task<List<SerialPort>> GetPorts() { throw new System.NotImplementedException(); }
	[Value("requestPort")]
	public Task<SerialPort> RequestPort(SerialPortRequestOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("SerialPortRequestOptions")]
public partial class SerialPortRequestOptions
{
	[Value("filters")]
	public List<SerialPortFilter> Filters;
	[Value("allowedBluetoothServiceClassIds")]
	public List<BluetoothServiceUUID> AllowedBluetoothServiceClassIds;
}

[Value("SerialPortFilter")]
public partial class SerialPortFilter
{
	[Value("usbVendorId")]
	public ushort UsbVendorId;
	[Value("usbProductId")]
	public ushort UsbProductId;
	[Value("bluetoothServiceClassId")]
	public BluetoothServiceUUID BluetoothServiceClassId;
}

[Value("SerialPort")]
public partial class SerialPort : EventTarget
{
	[Value("onconnect")]
	public EventHandler Onconnect { get; set; }
	[Value("ondisconnect")]
	public EventHandler Ondisconnect { get; set; }
	[Value("connected")]
	public bool Connected { get; }
	[Value("readable")]
	public ReadableStream Readable { get; }
	[Value("writable")]
	public WritableStream Writable { get; }
	[Value("getInfo")]
	public SerialPortInfo GetInfo() { throw new System.NotImplementedException(); }
	[Value("open")]
	public Task<Undefined> Open(SerialOptions options) { throw new System.NotImplementedException(); }
	[Value("setSignals")]
	public Task<Undefined> SetSignals(SerialOutputSignals signals = default) { throw new System.NotImplementedException(); }
	[Value("getSignals")]
	public Task<SerialInputSignals> GetSignals() { throw new System.NotImplementedException(); }
	[Value("close")]
	public Task<Undefined> Close() { throw new System.NotImplementedException(); }
	[Value("forget")]
	public Task<Undefined> Forget() { throw new System.NotImplementedException(); }
}

[Value("SerialPortInfo")]
public partial class SerialPortInfo
{
	[Value("usbVendorId")]
	public ushort UsbVendorId;
	[Value("usbProductId")]
	public ushort UsbProductId;
	[Value("bluetoothServiceClassId")]
	public BluetoothServiceUUID BluetoothServiceClassId;
}

[Value("SerialOptions")]
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

[Value("SerialOutputSignals")]
public partial class SerialOutputSignals
{
	[Value("dataTerminalReady")]
	public bool DataTerminalReady;
	[Value("requestToSend")]
	public bool RequestToSend;
	[Value("break")]
	public bool Break;
}

[Value("SerialInputSignals")]
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

[Value("PerformanceServerTiming")]
public partial class PerformanceServerTiming
{
	[Value("name")]
	public DOMString Name { get; }
	[Value("duration")]
	public DOMHighResTimeStamp Duration { get; }
	[Value("description")]
	public DOMString Description { get; }
	[Value("toJSON")]
	public Object ToJSON() { throw new System.NotImplementedException(); }
}

public partial class PerformanceResourceTiming
{
	[Value("serverTiming")]
	public PerformanceServerTiming[] ServerTiming { get; }
}

[Value("ServiceWorker")]
public partial class ServiceWorker : EventTarget, AbstractWorker
{
	[Value("scriptURL")]
	public USVString ScriptURL { get; }
	[Value("state")]
	public ServiceWorkerState State { get; }
	[Value("postMessage")]
	public Undefined PostMessage(dynamic message, List<Object> transfer) { throw new System.NotImplementedException(); }
	[Value("postMessage")]
	public Undefined PostMessage(dynamic message, StructuredSerializeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("onstatechange")]
	public EventHandler Onstatechange { get; set; }
}


public partial class ServiceWorkerRegistration : EventTarget
{
	[Value("installing")]
	public ServiceWorker? Installing { get; }
	[Value("waiting")]
	public ServiceWorker? Waiting { get; }
	[Value("active")]
	public ServiceWorker? Active { get; }
	[Value("navigationPreload")]
	public NavigationPreloadManager NavigationPreload { get; }
	[Value("scope")]
	public USVString Scope { get; }
	[Value("updateViaCache")]
	public ServiceWorkerUpdateViaCache UpdateViaCache { get; }
	[Value("update")]
	public Task<Undefined> Update() { throw new System.NotImplementedException(); }
	[Value("unregister")]
	public Task<bool> Unregister() { throw new System.NotImplementedException(); }
	[Value("onupdatefound")]
	public EventHandler Onupdatefound { get; set; }
}

public partial class Navigator
{
	[Value("serviceWorker")]
	public ServiceWorkerContainer ServiceWorker { get; }
}

public partial class WorkerNavigator
{
	[Value("serviceWorker")]
	public ServiceWorkerContainer ServiceWorker { get; }
}

[Value("ServiceWorkerContainer")]
public partial class ServiceWorkerContainer : EventTarget
{
	[Value("controller")]
	public ServiceWorker? Controller { get; }
	[Value("ready")]
	public Task<ServiceWorkerRegistration> Ready { get; }
	[Value("register")]
	public Task<ServiceWorkerRegistration> Register(Union137 scriptURL, RegistrationOptions options = default) { throw new System.NotImplementedException(); }
	[Value("getRegistration")]
	public Task<ServiceWorkerRegistration> GetRegistration(USVString clientURL = default) { throw new System.NotImplementedException(); }
	[Value("getRegistrations")]
	public Task<ServiceWorkerRegistration[]> GetRegistrations() { throw new System.NotImplementedException(); }
	[Value("startMessages")]
	public Undefined StartMessages() { throw new System.NotImplementedException(); }
	[Value("oncontrollerchange")]
	public EventHandler Oncontrollerchange { get; set; }
	[Value("onmessage")]
	public EventHandler Onmessage { get; set; }
	[Value("onmessageerror")]
	public EventHandler Onmessageerror { get; set; }
}

[Value("RegistrationOptions")]
public partial class RegistrationOptions
{
	[Value("scope")]
	public USVString Scope;
	[Value("type")]
	public WorkerType Type;
	[Value("updateViaCache")]
	public ServiceWorkerUpdateViaCache UpdateViaCache;
}

[Value("NavigationPreloadManager")]
public partial class NavigationPreloadManager
{
	[Value("enable")]
	public Task<Undefined> Enable() { throw new System.NotImplementedException(); }
	[Value("disable")]
	public Task<Undefined> Disable() { throw new System.NotImplementedException(); }
	[Value("setHeaderValue")]
	public Task<Undefined> SetHeaderValue(ByteString value) { throw new System.NotImplementedException(); }
	[Value("getState")]
	public Task<NavigationPreloadState> GetState() { throw new System.NotImplementedException(); }
}

[Value("NavigationPreloadState")]
public partial class NavigationPreloadState
{
	[Value("enabled")]
	public bool Enabled;
	[Value("headerValue")]
	public ByteString HeaderValue;
}

public partial class ServiceWorkerGlobalScope : WorkerGlobalScope
{
	[Value("clients")]
	public Clients Clients { get; }
	[Value("registration")]
	public ServiceWorkerRegistration Registration { get; }
	[Value("serviceWorker")]
	public ServiceWorker ServiceWorker { get; }
	[Value("skipWaiting")]
	public Task<Undefined> SkipWaiting() { throw new System.NotImplementedException(); }
	[Value("oninstall")]
	public EventHandler Oninstall { get; set; }
	[Value("onactivate")]
	public EventHandler Onactivate { get; set; }
	[Value("onfetch")]
	public EventHandler Onfetch { get; set; }
	[Value("onmessage")]
	public EventHandler Onmessage { get; set; }
	[Value("onmessageerror")]
	public EventHandler Onmessageerror { get; set; }
}

public partial class Client
{
	[Value("url")]
	public USVString Url { get; }
	[Value("frameType")]
	public FrameType FrameType { get; }
	[Value("id")]
	public DOMString Id { get; }
	[Value("type")]
	public ClientType Type { get; }
	[Value("postMessage")]
	public Undefined PostMessage(dynamic message, List<Object> transfer) { throw new System.NotImplementedException(); }
	[Value("postMessage")]
	public Undefined PostMessage(dynamic message, StructuredSerializeOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("WindowClient")]
public partial class WindowClient : Client
{
	[Value("visibilityState")]
	public DocumentVisibilityState VisibilityState { get; }
	[Value("focused")]
	public bool Focused { get; }
	[Value("ancestorOrigins")]
	public USVString[] AncestorOrigins { get; }
	[Value("focus")]
	public Task<WindowClient> Focus() { throw new System.NotImplementedException(); }
	[Value("navigate")]
	public Task<WindowClient?> Navigate(USVString url) { throw new System.NotImplementedException(); }
}

[Value("Clients")]
public partial class Clients
{
	[Value("get")]
	public Task<Client> Get(DOMString id) { throw new System.NotImplementedException(); }
	[Value("matchAll")]
	public Task<Client[]> MatchAll(ClientQueryOptions options = default) { throw new System.NotImplementedException(); }
	[Value("openWindow")]
	public Task<WindowClient?> OpenWindow(USVString url) { throw new System.NotImplementedException(); }
	[Value("claim")]
	public Task<Undefined> Claim() { throw new System.NotImplementedException(); }
}

[Value("ClientQueryOptions")]
public partial class ClientQueryOptions
{
	[Value("includeUncontrolled")]
	public bool IncludeUncontrolled;
	[Value("type")]
	public ClientType Type;
}

[Value("ExtendableEvent")]
public partial class ExtendableEvent : Event
{
		public ExtendableEvent(DOMString type, ExtendableEventInit eventInitDict = default) { }
	[Value("waitUntil")]
	public Undefined WaitUntil(Task<dynamic> f) { throw new System.NotImplementedException(); }
	public ExtendableEvent() { }
}

[Value("ExtendableEventInit")]
public partial class ExtendableEventInit : EventInit
{
}

[Value("InstallEvent")]
public partial class InstallEvent : ExtendableEvent
{
		public InstallEvent(DOMString type, ExtendableEventInit eventInitDict = default) { }
	[Value("addRoutes")]
	public Task<Undefined> AddRoutes(Union138 rules) { throw new System.NotImplementedException(); }
	public InstallEvent() { }
}

[Value("RouterRule")]
public partial class RouterRule
{
	[Value("condition")]
	public required RouterCondition Condition;
	[Value("source")]
	public required RouterSource Source;
}

[Value("RouterCondition")]
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


[Value("RouterSourceDict")]
public partial class RouterSourceDict
{
	[Value("cacheName")]
	public DOMString CacheName;
}

[Value("FetchEvent")]
public partial class FetchEvent : ExtendableEvent
{
		public FetchEvent(DOMString type, FetchEventInit eventInitDict) { }
	[Value("request")]
	public Request Request { get; }
	[Value("preloadResponse")]
	public Task<dynamic> PreloadResponse { get; }
	[Value("clientId")]
	public DOMString ClientId { get; }
	[Value("resultingClientId")]
	public DOMString ResultingClientId { get; }
	[Value("replacesClientId")]
	public DOMString ReplacesClientId { get; }
	[Value("handled")]
	public Task<Undefined> Handled { get; }
	[Value("respondWith")]
	public Undefined RespondWith(Task<Response> r) { throw new System.NotImplementedException(); }
	public FetchEvent() { }
}

[Value("FetchEventInit")]
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

[Value("ExtendableMessageEvent")]
public partial class ExtendableMessageEvent : ExtendableEvent
{
		public ExtendableMessageEvent(DOMString type, ExtendableMessageEventInit eventInitDict = default) { }
	[Value("data")]
	public dynamic Data { get; }
	[Value("origin")]
	public USVString Origin { get; }
	[Value("lastEventId")]
	public DOMString LastEventId { get; }
	[Value("source")]
	public Union140? Source { get; }
	[Value("ports")]
	public MessagePort[] Ports { get; }
	public ExtendableMessageEvent() { }
}

[Value("ExtendableMessageEventInit")]
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

[Value("Cache")]
public partial class Cache
{
	[Value("match")]
	public Task<Response> Match(RequestInfo request, CacheQueryOptions options = default) { throw new System.NotImplementedException(); }
	[Value("matchAll")]
	public Task<Response[]> MatchAll(RequestInfo request = default, CacheQueryOptions options = default) { throw new System.NotImplementedException(); }
	[Value("add")]
	public Task<Undefined> Add(RequestInfo request) { throw new System.NotImplementedException(); }
	[Value("addAll")]
	public Task<Undefined> AddAll(List<RequestInfo> requests) { throw new System.NotImplementedException(); }
	[Value("put")]
	public Task<Undefined> Put(RequestInfo request, Response response) { throw new System.NotImplementedException(); }
	[Value("delete")]
	public Task<bool> Delete(RequestInfo request, CacheQueryOptions options = default) { throw new System.NotImplementedException(); }
	[Value("keys")]
	public Task<Request[]> Keys(RequestInfo request = default, CacheQueryOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("CacheQueryOptions")]
public partial class CacheQueryOptions
{
	[Value("ignoreSearch")]
	public bool IgnoreSearch;
	[Value("ignoreMethod")]
	public bool IgnoreMethod;
	[Value("ignoreVary")]
	public bool IgnoreVary;
}

[Value("CacheStorage")]
public partial class CacheStorage
{
	[Value("match")]
	public Task<Response> Match(RequestInfo request, MultiCacheQueryOptions options = default) { throw new System.NotImplementedException(); }
	[Value("has")]
	public Task<bool> Has(DOMString cacheName) { throw new System.NotImplementedException(); }
	[Value("open")]
	public Task<Cache> Open(DOMString cacheName) { throw new System.NotImplementedException(); }
	[Value("delete")]
	public Task<bool> Delete(DOMString cacheName) { throw new System.NotImplementedException(); }
	[Value("keys")]
	public Task<List<DOMString>> Keys() { throw new System.NotImplementedException(); }
}

[Value("MultiCacheQueryOptions")]
public partial class MultiCacheQueryOptions : CacheQueryOptions
{
	[Value("cacheName")]
	public DOMString CacheName;
}

[Value("FaceDetector")]
public partial class FaceDetector
{
		public FaceDetector(FaceDetectorOptions faceDetectorOptions = default) { }
	[Value("detect")]
	public Task<List<DetectedFace>> Detect(ImageBitmapSource image) { throw new System.NotImplementedException(); }
	public FaceDetector() { }
}

[Value("FaceDetectorOptions")]
public partial class FaceDetectorOptions
{
	[Value("maxDetectedFaces")]
	public ushort MaxDetectedFaces;
	[Value("fastMode")]
	public bool FastMode;
}

[Value("DetectedFace")]
public partial class DetectedFace
{
	[Value("boundingBox")]
	public required DOMRectReadOnly BoundingBox;
	[Value("landmarks")]
	public required List<Landmark>? Landmarks;
}

[Value("Landmark")]
public partial class Landmark
{
	[Value("locations")]
	public required List<Point2D> Locations;
	[Value("type")]
	public LandmarkType Type;
}

[Value("BarcodeDetector")]
public partial class BarcodeDetector
{
		public BarcodeDetector(BarcodeDetectorOptions barcodeDetectorOptions = default) { }
	[Value("getSupportedFormats")]
	public static Task<List<BarcodeFormat>> GetSupportedFormats() { throw new System.NotImplementedException(); }
	[Value("detect")]
	public Task<List<DetectedBarcode>> Detect(ImageBitmapSource image) { throw new System.NotImplementedException(); }
	public BarcodeDetector() { }
}

[Value("BarcodeDetectorOptions")]
public partial class BarcodeDetectorOptions
{
	[Value("formats")]
	public List<BarcodeFormat> Formats;
}

[Value("DetectedBarcode")]
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

[Value("SharedStorageWorklet")]
public partial class SharedStorageWorklet : Worklet
{
	[Value("selectURL")]
	public Task<SharedStorageResponse> SelectURL(DOMString name, List<SharedStorageUrlWithMetadata> urls, SharedStorageRunOperationMethodOptions options = default) { throw new System.NotImplementedException(); }
	[Value("run")]
	public Task<dynamic> Run(DOMString name, SharedStorageRunOperationMethodOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("SharedStorageWorkletGlobalScope")]
public partial class SharedStorageWorkletGlobalScope : WorkletGlobalScope
{
	[Value("register")]
	public Undefined Register(DOMString name, Function operationCtor) { throw new System.NotImplementedException(); }
	[Value("sharedStorage")]
	public SharedStorage SharedStorage { get; }
	[Value("privateAggregation")]
	public PrivateAggregation PrivateAggregation { get; }
	[Value("interestGroups")]
	public Task<List<StorageInterestGroup>> InterestGroups() { throw new System.NotImplementedException(); }
	[Value("navigator")]
	public SharedStorageWorkletNavigator Navigator { get; }
}

[Value("SharedStorageUrlWithMetadata")]
public partial class SharedStorageUrlWithMetadata
{
	[Value("url")]
	public required USVString Url;
	[Value("reportingMetadata")]
	public Object ReportingMetadata;
}

public partial class Window
{
	[Value("sharedStorage")]
	public SharedStorage? SharedStorage { get; }
}

[Value("SharedStorageModifierMethod")]
public partial class SharedStorageModifierMethod
{
}

[Value("SharedStorageSetMethod")]
public partial class SharedStorageSetMethod : SharedStorageModifierMethod
{
		public SharedStorageSetMethod(DOMString key, DOMString value, SharedStorageSetMethodOptions options = default) { }
	public SharedStorageSetMethod() { }
}

[Value("SharedStorageAppendMethod")]
public partial class SharedStorageAppendMethod : SharedStorageModifierMethod
{
		public SharedStorageAppendMethod(DOMString key, DOMString value, SharedStorageModifierMethodOptions options = default) { }
	public SharedStorageAppendMethod() { }
}

[Value("SharedStorageDeleteMethod")]
public partial class SharedStorageDeleteMethod : SharedStorageModifierMethod
{
		public SharedStorageDeleteMethod(DOMString key, SharedStorageModifierMethodOptions options = default) { }
	public SharedStorageDeleteMethod() { }
}

[Value("SharedStorageClearMethod")]
public partial class SharedStorageClearMethod : SharedStorageModifierMethod
{
		public SharedStorageClearMethod(SharedStorageModifierMethodOptions options = default) { }
	public SharedStorageClearMethod() { }
}

[Value("SharedStorageModifierMethodOptions")]
public partial class SharedStorageModifierMethodOptions
{
	[Value("withLock")]
	public DOMString WithLock;
}

[Value("SharedStorageSetMethodOptions")]
public partial class SharedStorageSetMethodOptions : SharedStorageModifierMethodOptions
{
	[Value("ignoreIfPresent")]
	public bool IgnoreIfPresent;
}

[Value("SharedStorage")]
public partial class SharedStorage
{
	[Value("set")]
	public Task<dynamic> Set(DOMString key, DOMString value, SharedStorageSetMethodOptions options = default) { throw new System.NotImplementedException(); }
	[Value("append")]
	public Task<dynamic> Append(DOMString key, DOMString value, SharedStorageModifierMethodOptions options = default) { throw new System.NotImplementedException(); }
	[Value("delete")]
	public Task<dynamic> Delete(DOMString key, SharedStorageModifierMethodOptions options = default) { throw new System.NotImplementedException(); }
	[Value("clear")]
	public Task<dynamic> Clear(SharedStorageModifierMethodOptions options = default) { throw new System.NotImplementedException(); }
	[Value("batchUpdate")]
	public Task<dynamic> BatchUpdate(List<SharedStorageModifierMethod> methods, SharedStorageModifierMethodOptions options = default) { throw new System.NotImplementedException(); }
	[Value("selectURL")]
	public Task<SharedStorageResponse> SelectURL(DOMString name, List<SharedStorageUrlWithMetadata> urls, SharedStorageRunOperationMethodOptions options = default) { throw new System.NotImplementedException(); }
	[Value("run")]
	public Task<dynamic> Run(DOMString name, SharedStorageRunOperationMethodOptions options = default) { throw new System.NotImplementedException(); }
	[Value("createWorklet")]
	public Task<SharedStorageWorklet> CreateWorklet(USVString moduleURL, SharedStorageWorkletOptions options = default) { throw new System.NotImplementedException(); }
	[Value("worklet")]
	public SharedStorageWorklet Worklet { get; }
	[Value("get")]
	public Task<DOMString> Get(DOMString key) { throw new System.NotImplementedException(); }
	[Value("length")]
	public Task<ulong> Length() { throw new System.NotImplementedException(); }
	[Value("remainingBudget")]
	public Task<Number> RemainingBudget() { throw new System.NotImplementedException(); }
	public DOMString this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
}

[Value("SharedStoragePrivateAggregationConfig")]
public partial class SharedStoragePrivateAggregationConfig
{
	[Value("aggregationCoordinatorOrigin")]
	public USVString AggregationCoordinatorOrigin;
	[Value("contextId")]
	public USVString ContextId;
	[Value("filteringIdMaxBytes")]
	public ulong FilteringIdMaxBytes;
}

[Value("SharedStorageRunOperationMethodOptions")]
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

[Value("SharedStorageWorkletOptions")]
public partial class SharedStorageWorkletOptions : WorkletOptions
{
	[Value("dataOrigin")]
	public USVString DataOrigin;
}

public partial class RequestInit
{
	[Value("sharedStorageWritable")]
	public bool SharedStorageWritable;
}

[Value("SharedStorageWorkletNavigator")]
public partial class SharedStorageWorkletNavigator
{
}


[Value("SpeechRecognition")]
public partial class SpeechRecognition : EventTarget
{
		public SpeechRecognition() { }
	[Value("grammars")]
	public SpeechGrammarList Grammars { get; set; }
	[Value("lang")]
	public DOMString Lang { get; set; }
	[Value("continuous")]
	public bool Continuous { get; set; }
	[Value("interimResults")]
	public bool InterimResults { get; set; }
	[Value("maxAlternatives")]
	public ulong MaxAlternatives { get; set; }
	[Value("start")]
	public Undefined Start() { throw new System.NotImplementedException(); }
	[Value("stop")]
	public Undefined Stop() { throw new System.NotImplementedException(); }
	[Value("abort")]
	public Undefined Abort() { throw new System.NotImplementedException(); }
	[Value("onaudiostart")]
	public EventHandler Onaudiostart { get; set; }
	[Value("onsoundstart")]
	public EventHandler Onsoundstart { get; set; }
	[Value("onspeechstart")]
	public EventHandler Onspeechstart { get; set; }
	[Value("onspeechend")]
	public EventHandler Onspeechend { get; set; }
	[Value("onsoundend")]
	public EventHandler Onsoundend { get; set; }
	[Value("onaudioend")]
	public EventHandler Onaudioend { get; set; }
	[Value("onresult")]
	public EventHandler Onresult { get; set; }
	[Value("onnomatch")]
	public EventHandler Onnomatch { get; set; }
	[Value("onerror")]
	public EventHandler Onerror { get; set; }
	[Value("onstart")]
	public EventHandler Onstart { get; set; }
	[Value("onend")]
	public EventHandler Onend { get; set; }
}

[Value("SpeechRecognitionErrorEvent")]
public partial class SpeechRecognitionErrorEvent : Event
{
		public SpeechRecognitionErrorEvent(DOMString type, SpeechRecognitionErrorEventInit eventInitDict) { }
	[Value("error")]
	public SpeechRecognitionErrorCode Error { get; }
	[Value("message")]
	public DOMString Message { get; }
	public SpeechRecognitionErrorEvent() { }
}

[Value("SpeechRecognitionErrorEventInit")]
public partial class SpeechRecognitionErrorEventInit : EventInit
{
	[Value("error")]
	public required SpeechRecognitionErrorCode Error;
	[Value("message")]
	public DOMString Message;
}

[Value("SpeechRecognitionAlternative")]
public partial class SpeechRecognitionAlternative
{
	[Value("transcript")]
	public DOMString Transcript { get; }
	[Value("confidence")]
	public Number Confidence { get; }
}

[Value("SpeechRecognitionResult")]
public partial class SpeechRecognitionResult
{
	[Value("length")]
	public ulong Length { get; }
	
	[Value("isFinal")]
	public bool IsFinal { get; }
}

[Value("SpeechRecognitionResultList")]
public partial class SpeechRecognitionResultList
{
	[Value("length")]
	public ulong Length { get; }
	
}

[Value("SpeechRecognitionEvent")]
public partial class SpeechRecognitionEvent : Event
{
		public SpeechRecognitionEvent(DOMString type, SpeechRecognitionEventInit eventInitDict) { }
	[Value("resultIndex")]
	public ulong ResultIndex { get; }
	[Value("results")]
	public SpeechRecognitionResultList Results { get; }
	public SpeechRecognitionEvent() { }
}

[Value("SpeechRecognitionEventInit")]
public partial class SpeechRecognitionEventInit : EventInit
{
	[Value("resultIndex")]
	public ulong ResultIndex;
	[Value("results")]
	public required SpeechRecognitionResultList Results;
}

[Value("SpeechGrammar")]
public partial class SpeechGrammar
{
	[Value("src")]
	public DOMString Src { get; set; }
	[Value("weight")]
	public Number Weight { get; set; }
}

[Value("SpeechGrammarList")]
public partial class SpeechGrammarList
{
		public SpeechGrammarList() { }
	[Value("length")]
	public ulong Length { get; }
	
	[Value("addFromURI")]
	public Undefined AddFromURI(DOMString src, Number weight = default) { throw new System.NotImplementedException(); }
	[Value("addFromString")]
	public Undefined AddFromString(DOMString string_, Number weight = default) { throw new System.NotImplementedException(); }
}

[Value("SpeechSynthesis")]
public partial class SpeechSynthesis : EventTarget
{
	[Value("pending")]
	public bool Pending { get; }
	[Value("speaking")]
	public bool Speaking { get; }
	[Value("paused")]
	public bool Paused { get; }
	[Value("onvoiceschanged")]
	public EventHandler Onvoiceschanged { get; set; }
	[Value("speak")]
	public Undefined Speak(SpeechSynthesisUtterance utterance) { throw new System.NotImplementedException(); }
	[Value("cancel")]
	public Undefined Cancel() { throw new System.NotImplementedException(); }
	[Value("pause")]
	public Undefined Pause() { throw new System.NotImplementedException(); }
	[Value("resume")]
	public Undefined Resume() { throw new System.NotImplementedException(); }
	[Value("getVoices")]
	public List<SpeechSynthesisVoice> GetVoices() { throw new System.NotImplementedException(); }
}

public partial class Window
{
	[Value("speechSynthesis")]
	public SpeechSynthesis SpeechSynthesis { get; }
}

[Value("SpeechSynthesisUtterance")]
public partial class SpeechSynthesisUtterance : EventTarget
{
		public SpeechSynthesisUtterance(DOMString text = default) { }
	[Value("text")]
	public DOMString Text { get; set; }
	[Value("lang")]
	public DOMString Lang { get; set; }
	[Value("voice")]
	public SpeechSynthesisVoice? Voice { get; set; }
	[Value("volume")]
	public Number Volume { get; set; }
	[Value("rate")]
	public Number Rate { get; set; }
	[Value("pitch")]
	public Number Pitch { get; set; }
	[Value("onstart")]
	public EventHandler Onstart { get; set; }
	[Value("onend")]
	public EventHandler Onend { get; set; }
	[Value("onerror")]
	public EventHandler Onerror { get; set; }
	[Value("onpause")]
	public EventHandler Onpause { get; set; }
	[Value("onresume")]
	public EventHandler Onresume { get; set; }
	[Value("onmark")]
	public EventHandler Onmark { get; set; }
	[Value("onboundary")]
	public EventHandler Onboundary { get; set; }
	public SpeechSynthesisUtterance() { }
}

[Value("SpeechSynthesisEvent")]
public partial class SpeechSynthesisEvent : Event
{
		public SpeechSynthesisEvent(DOMString type, SpeechSynthesisEventInit eventInitDict) { }
	[Value("utterance")]
	public SpeechSynthesisUtterance Utterance { get; }
	[Value("charIndex")]
	public ulong CharIndex { get; }
	[Value("charLength")]
	public ulong CharLength { get; }
	[Value("elapsedTime")]
	public Number ElapsedTime { get; }
	[Value("name")]
	public DOMString Name { get; }
	public SpeechSynthesisEvent() { }
}

[Value("SpeechSynthesisEventInit")]
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

[Value("SpeechSynthesisErrorEvent")]
public partial class SpeechSynthesisErrorEvent : SpeechSynthesisEvent
{
		public SpeechSynthesisErrorEvent(DOMString type, SpeechSynthesisErrorEventInit eventInitDict) { }
	[Value("error")]
	public SpeechSynthesisErrorCode Error { get; }
	public SpeechSynthesisErrorEvent() { }
}

[Value("SpeechSynthesisErrorEventInit")]
public partial class SpeechSynthesisErrorEventInit : SpeechSynthesisEventInit
{
	[Value("error")]
	public required SpeechSynthesisErrorCode Error;
}

[Value("SpeechSynthesisVoice")]
public partial class SpeechSynthesisVoice
{
	[Value("voiceURI")]
	public DOMString VoiceURI { get; }
	[Value("name")]
	public DOMString Name { get; }
	[Value("lang")]
	public DOMString Lang { get; }
	[Value("localService")]
	public bool LocalService { get; }
	[Value("default")]
	public bool Default { get; }
}

public partial class Document
{
	[Value("hasStorageAccess")]
	public Task<bool> HasStorageAccess() { throw new System.NotImplementedException(); }
	[Value("requestStorageAccess")]
	public Task<Undefined> RequestStorageAccess() { throw new System.NotImplementedException(); }
}

[Value("StorageBucketManager")]
public partial class StorageBucketManager
{
	[Value("open")]
	public Task<StorageBucket> Open(DOMString name, StorageBucketOptions options = default) { throw new System.NotImplementedException(); }
	[Value("keys")]
	public Task<List<DOMString>> Keys() { throw new System.NotImplementedException(); }
	[Value("delete")]
	public Task<Undefined> Delete(DOMString name) { throw new System.NotImplementedException(); }
}

[Value("StorageBucketOptions")]
public partial class StorageBucketOptions
{
	[Value("persisted")]
	public bool Persisted;
	[Value("quota")]
	public ulong Quota;
	[Value("expires")]
	public DOMHighResTimeStamp Expires;
}

[Value("StorageBucket")]
public partial class StorageBucket
{
	[Value("name")]
	public DOMString Name { get; }
	[Value("persist")]
	public Task<bool> Persist() { throw new System.NotImplementedException(); }
	[Value("persisted")]
	public Task<bool> Persisted() { throw new System.NotImplementedException(); }
	[Value("estimate")]
	public Task<StorageEstimate> Estimate() { throw new System.NotImplementedException(); }
	[Value("setExpires")]
	public Task<Undefined> SetExpires(DOMHighResTimeStamp expires) { throw new System.NotImplementedException(); }
	[Value("expires")]
	public Task<DOMHighResTimeStamp?> Expires() { throw new System.NotImplementedException(); }
	[Value("indexedDB")]
	public IDBFactory IndexedDB { get; }
	[Value("caches")]
	public CacheStorage Caches { get; }
	[Value("getDirectory")]
	public Task<FileSystemDirectoryHandle> GetDirectory() { throw new System.NotImplementedException(); }
}

public partial class StorageManager
{
	[Value("persisted")]
	public Task<bool> Persisted() { throw new System.NotImplementedException(); }
	[Value("persist")]
	public Task<bool> Persist() { throw new System.NotImplementedException(); }
	[Value("estimate")]
	public Task<StorageEstimate> Estimate() { throw new System.NotImplementedException(); }
}

[Value("StorageEstimate")]
public partial class StorageEstimate
{
	[Value("usage")]
	public ulong Usage;
	[Value("quota")]
	public ulong Quota;
}

[Value("ReadableStream")]
public partial class ReadableStream
{
		public ReadableStream(Object underlyingSource = default, QueuingStrategy strategy = default) { }
	[Value("from")]
	public static ReadableStream From(dynamic asyncIterable) { throw new System.NotImplementedException(); }
	[Value("locked")]
	public bool Locked { get; }
	[Value("cancel")]
	public Task<Undefined> Cancel(dynamic reason = default) { throw new System.NotImplementedException(); }
	[Value("getReader")]
	public ReadableStreamReader GetReader(ReadableStreamGetReaderOptions options = default) { throw new System.NotImplementedException(); }
	[Value("pipeThrough")]
	public ReadableStream PipeThrough(ReadableWritablePair transform, StreamPipeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("pipeTo")]
	public Task<Undefined> PipeTo(WritableStream destination, StreamPipeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("tee")]
	public List<ReadableStream> Tee() { throw new System.NotImplementedException(); }
	public dynamic this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	public ReadableStream() { }
}


[Value("ReadableStreamGetReaderOptions")]
public partial class ReadableStreamGetReaderOptions
{
	[Value("mode")]
	public ReadableStreamReaderMode Mode;
}

[Value("ReadableStreamIteratorOptions")]
public partial class ReadableStreamIteratorOptions
{
	[Value("preventCancel")]
	public bool PreventCancel;
}

[Value("ReadableWritablePair")]
public partial class ReadableWritablePair
{
	[Value("readable")]
	public required ReadableStream Readable;
	[Value("writable")]
	public required WritableStream Writable;
}

[Value("StreamPipeOptions")]
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

[Value("UnderlyingSource")]
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


[Value("ReadableStreamDefaultReader")]
public partial class ReadableStreamDefaultReader
{
		public ReadableStreamDefaultReader(ReadableStream stream) { }
	[Value("read")]
	public Task<ReadableStreamReadResult> Read() { throw new System.NotImplementedException(); }
	[Value("releaseLock")]
	public Undefined ReleaseLock() { throw new System.NotImplementedException(); }
	public ReadableStreamDefaultReader() { }
}


[Value("ReadableStreamReadResult")]
public partial class ReadableStreamReadResult
{
	[Value("value")]
	public dynamic Value;
	[Value("done")]
	public bool Done;
}

[Value("ReadableStreamBYOBReader")]
public partial class ReadableStreamBYOBReader
{
		public ReadableStreamBYOBReader(ReadableStream stream) { }
	[Value("read")]
	public Task<ReadableStreamReadResult> Read(ArrayBufferView view, ReadableStreamBYOBReaderReadOptions options = default) { throw new System.NotImplementedException(); }
	[Value("releaseLock")]
	public Undefined ReleaseLock() { throw new System.NotImplementedException(); }
	public ReadableStreamBYOBReader() { }
}


[Value("ReadableStreamBYOBReaderReadOptions")]
public partial class ReadableStreamBYOBReaderReadOptions
{
	[Value("min")]
	public ulong Min;
}

[Value("ReadableStreamDefaultController")]
public partial class ReadableStreamDefaultController
{
	[Value("desiredSize")]
	public double? DesiredSize { get; }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	[Value("enqueue")]
	public Undefined Enqueue(dynamic chunk = default) { throw new System.NotImplementedException(); }
	[Value("error")]
	public Undefined Error(dynamic e = default) { throw new System.NotImplementedException(); }
}

[Value("ReadableByteStreamController")]
public partial class ReadableByteStreamController
{
	[Value("byobRequest")]
	public ReadableStreamBYOBRequest? ByobRequest { get; }
	[Value("desiredSize")]
	public double? DesiredSize { get; }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	[Value("enqueue")]
	public Undefined Enqueue(ArrayBufferView chunk) { throw new System.NotImplementedException(); }
	[Value("error")]
	public Undefined Error(dynamic e = default) { throw new System.NotImplementedException(); }
}

[Value("ReadableStreamBYOBRequest")]
public partial class ReadableStreamBYOBRequest
{
	[Value("view")]
	public ArrayBufferView? View { get; }
	[Value("respond")]
	public Undefined Respond(ulong bytesWritten) { throw new System.NotImplementedException(); }
	[Value("respondWithNewView")]
	public Undefined RespondWithNewView(ArrayBufferView view) { throw new System.NotImplementedException(); }
}

[Value("WritableStream")]
public partial class WritableStream
{
		public WritableStream(Object underlyingSink = default, QueuingStrategy strategy = default) { }
	[Value("locked")]
	public bool Locked { get; }
	[Value("abort")]
	public Task<Undefined> Abort(dynamic reason = default) { throw new System.NotImplementedException(); }
	[Value("close")]
	public Task<Undefined> Close() { throw new System.NotImplementedException(); }
	[Value("getWriter")]
	public WritableStreamDefaultWriter GetWriter() { throw new System.NotImplementedException(); }
	public WritableStream() { }
}

[Value("UnderlyingSink")]
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

[Value("WritableStreamDefaultWriter")]
public partial class WritableStreamDefaultWriter
{
		public WritableStreamDefaultWriter(WritableStream stream) { }
	[Value("closed")]
	public Task<Undefined> Closed { get; }
	[Value("desiredSize")]
	public double? DesiredSize { get; }
	[Value("ready")]
	public Task<Undefined> Ready { get; }
	[Value("abort")]
	public Task<Undefined> Abort(dynamic reason = default) { throw new System.NotImplementedException(); }
	[Value("close")]
	public Task<Undefined> Close() { throw new System.NotImplementedException(); }
	[Value("releaseLock")]
	public Undefined ReleaseLock() { throw new System.NotImplementedException(); }
	[Value("write")]
	public Task<Undefined> Write(dynamic chunk = default) { throw new System.NotImplementedException(); }
	public WritableStreamDefaultWriter() { }
}

[Value("WritableStreamDefaultController")]
public partial class WritableStreamDefaultController
{
	[Value("signal")]
	public AbortSignal Signal { get; }
	[Value("error")]
	public Undefined Error(dynamic e = default) { throw new System.NotImplementedException(); }
}

[Value("TransformStream")]
public partial class TransformStream
{
		public TransformStream(Object transformer = default, QueuingStrategy writableStrategy = default, QueuingStrategy readableStrategy = default) { }
	[Value("readable")]
	public ReadableStream Readable { get; }
	[Value("writable")]
	public WritableStream Writable { get; }
	public TransformStream() { }
}

[Value("Transformer")]
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

[Value("TransformStreamDefaultController")]
public partial class TransformStreamDefaultController
{
	[Value("desiredSize")]
	public double? DesiredSize { get; }
	[Value("enqueue")]
	public Undefined Enqueue(dynamic chunk = default) { throw new System.NotImplementedException(); }
	[Value("error")]
	public Undefined Error(dynamic reason = default) { throw new System.NotImplementedException(); }
	[Value("terminate")]
	public Undefined Terminate() { throw new System.NotImplementedException(); }
}

[Value("QueuingStrategy")]
public partial class QueuingStrategy
{
	[Value("highWaterMark")]
	public double HighWaterMark;
	[Value("size")]
	public QueuingStrategySize Size;
}

[Value("QueuingStrategyInit")]
public partial class QueuingStrategyInit
{
	[Value("highWaterMark")]
	public required double HighWaterMark;
}

[Value("ByteLengthQueuingStrategy")]
public partial class ByteLengthQueuingStrategy
{
		public ByteLengthQueuingStrategy(QueuingStrategyInit init) { }
	[Value("highWaterMark")]
	public double HighWaterMark { get; }
	[Value("size")]
	public Function Size { get; }
	public ByteLengthQueuingStrategy() { }
}

[Value("CountQueuingStrategy")]
public partial class CountQueuingStrategy
{
		public CountQueuingStrategy(QueuingStrategyInit init) { }
	[Value("highWaterMark")]
	public double HighWaterMark { get; }
	[Value("size")]
	public Function Size { get; }
	public CountQueuingStrategy() { }
}

[Value("TimeEvent")]
public partial class TimeEvent : Event
{
	[Value("view")]
	public WindowProxy? View { get; }
	[Value("detail")]
	public long Detail { get; }
	[Value("initTimeEvent")]
	public Undefined InitTimeEvent(DOMString typeArg, Window? viewArg, long detailArg) { throw new System.NotImplementedException(); }
}

[Value("SVGAnimationElement")]
public partial class SVGAnimationElement : SVGElement, SVGTests
{
	[Value("targetElement")]
	public SVGElement? TargetElement { get; }
	[Value("onbegin")]
	public EventHandler Onbegin { get; set; }
	[Value("onend")]
	public EventHandler Onend { get; set; }
	[Value("onrepeat")]
	public EventHandler Onrepeat { get; set; }
	[Value("getStartTime")]
	public Number GetStartTime() { throw new System.NotImplementedException(); }
	[Value("getCurrentTime")]
	public Number GetCurrentTime() { throw new System.NotImplementedException(); }
	[Value("getSimpleDuration")]
	public Number GetSimpleDuration() { throw new System.NotImplementedException(); }
	[Value("beginElement")]
	public Undefined BeginElement() { throw new System.NotImplementedException(); }
	[Value("beginElementAt")]
	public Undefined BeginElementAt(Number offset) { throw new System.NotImplementedException(); }
	[Value("endElement")]
	public Undefined EndElement() { throw new System.NotImplementedException(); }
	[Value("endElementAt")]
	public Undefined EndElementAt(Number offset) { throw new System.NotImplementedException(); }
}


[Value("SVGAnimateElement")]
public partial class SVGAnimateElement : SVGAnimationElement
{
}

[Value("SVGSetElement")]
public partial class SVGSetElement : SVGAnimationElement
{
}

[Value("SVGAnimateMotionElement")]
public partial class SVGAnimateMotionElement : SVGAnimationElement
{
}

[Value("SVGMPathElement")]
public partial class SVGMPathElement : SVGElement, SVGURIReference
{
}


[Value("SVGAnimateTransformElement")]
public partial class SVGAnimateTransformElement : SVGAnimationElement
{
}

[Value("SVGDiscardElement")]
public partial class SVGDiscardElement : SVGAnimationElement
{
}

[Value("SVGSVGElement")]
public partial class SVGSVGElement
{
	[Value("pauseAnimations")]
	public Undefined PauseAnimations() { throw new System.NotImplementedException(); }
	[Value("unpauseAnimations")]
	public Undefined UnpauseAnimations() { throw new System.NotImplementedException(); }
	[Value("animationsPaused")]
	public bool AnimationsPaused() { throw new System.NotImplementedException(); }
	[Value("getCurrentTime")]
	public Number GetCurrentTime() { throw new System.NotImplementedException(); }
	[Value("setCurrentTime")]
	public Undefined SetCurrentTime(Number seconds) { throw new System.NotImplementedException(); }
}

[Value("SVGElement")]
public partial class SVGElement : Element, ElementCSSInlineStyle, GlobalEventHandlers, SVGElementInstance, HTMLOrSVGElement
{
	[Value("className")]
	public SVGAnimatedString ClassName { get; }
	[Value("ownerSVGElement")]
	public SVGSVGElement? OwnerSVGElement { get; }
	[Value("viewportElement")]
	public SVGElement? ViewportElement { get; }
}




[Value("SVGBoundingBoxOptions")]
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

[Value("SVGGraphicsElement")]
public partial class SVGGraphicsElement : SVGElement, SVGTests
{
	[Value("transform")]
	public SVGAnimatedTransformList Transform { get; }
	[Value("getBBox")]
	public DOMRect GetBBox(SVGBoundingBoxOptions options = default) { throw new System.NotImplementedException(); }
	[Value("getCTM")]
	public DOMMatrix? GetCTM() { throw new System.NotImplementedException(); }
	[Value("getScreenCTM")]
	public DOMMatrix? GetScreenCTM() { throw new System.NotImplementedException(); }
}


[Value("SVGGeometryElement")]
public partial class SVGGeometryElement : SVGGraphicsElement
{
	[Value("pathLength")]
	public SVGAnimatedNumber PathLength { get; }
	[Value("isPointInFill")]
	public bool IsPointInFill(DOMPointInit point = default) { throw new System.NotImplementedException(); }
	[Value("isPointInStroke")]
	public bool IsPointInStroke(DOMPointInit point = default) { throw new System.NotImplementedException(); }
	[Value("getTotalLength")]
	public Number GetTotalLength() { throw new System.NotImplementedException(); }
	[Value("getPointAtLength")]
	public DOMPoint GetPointAtLength(Number distance) { throw new System.NotImplementedException(); }
}

[Value("SVGNumber")]
public partial class SVGNumber
{
	[Value("value")]
	public Number Value { get; set; }
}

[Value("SVGLength")]
public partial class SVGLength
{
	[Value("SVG_LENGTHTYPE_UNKNOWN")]
	public const ushort SVG_LENGTHTYPE_UNKNOWN = 0;
	[Value("SVG_LENGTHTYPE_NUMBER")]
	public const ushort SVG_LENGTHTYPE_NUMBER = 1;
	[Value("SVG_LENGTHTYPE_PERCENTAGE")]
	public const ushort SVG_LENGTHTYPE_PERCENTAGE = 2;
	[Value("SVG_LENGTHTYPE_EMS")]
	public const ushort SVG_LENGTHTYPE_EMS = 3;
	[Value("SVG_LENGTHTYPE_EXS")]
	public const ushort SVG_LENGTHTYPE_EXS = 4;
	[Value("SVG_LENGTHTYPE_PX")]
	public const ushort SVG_LENGTHTYPE_PX = 5;
	[Value("SVG_LENGTHTYPE_CM")]
	public const ushort SVG_LENGTHTYPE_CM = 6;
	[Value("SVG_LENGTHTYPE_MM")]
	public const ushort SVG_LENGTHTYPE_MM = 7;
	[Value("SVG_LENGTHTYPE_IN")]
	public const ushort SVG_LENGTHTYPE_IN = 8;
	[Value("SVG_LENGTHTYPE_PT")]
	public const ushort SVG_LENGTHTYPE_PT = 9;
	[Value("SVG_LENGTHTYPE_PC")]
	public const ushort SVG_LENGTHTYPE_PC = 10;
	[Value("unitType")]
	public ushort UnitType { get; }
	[Value("value")]
	public Number Value { get; set; }
	[Value("valueInSpecifiedUnits")]
	public Number ValueInSpecifiedUnits { get; set; }
	[Value("valueAsString")]
	public DOMString ValueAsString { get; set; }
	[Value("newValueSpecifiedUnits")]
	public Undefined NewValueSpecifiedUnits(ushort unitType, Number valueInSpecifiedUnits) { throw new System.NotImplementedException(); }
	[Value("convertToSpecifiedUnits")]
	public Undefined ConvertToSpecifiedUnits(ushort unitType) { throw new System.NotImplementedException(); }
}

[Value("SVGAngle")]
public partial class SVGAngle
{
	[Value("SVG_ANGLETYPE_UNKNOWN")]
	public const ushort SVG_ANGLETYPE_UNKNOWN = 0;
	[Value("SVG_ANGLETYPE_UNSPECIFIED")]
	public const ushort SVG_ANGLETYPE_UNSPECIFIED = 1;
	[Value("SVG_ANGLETYPE_DEG")]
	public const ushort SVG_ANGLETYPE_DEG = 2;
	[Value("SVG_ANGLETYPE_RAD")]
	public const ushort SVG_ANGLETYPE_RAD = 3;
	[Value("SVG_ANGLETYPE_GRAD")]
	public const ushort SVG_ANGLETYPE_GRAD = 4;
	[Value("unitType")]
	public ushort UnitType { get; }
	[Value("value")]
	public Number Value { get; set; }
	[Value("valueInSpecifiedUnits")]
	public Number ValueInSpecifiedUnits { get; set; }
	[Value("valueAsString")]
	public DOMString ValueAsString { get; set; }
	[Value("newValueSpecifiedUnits")]
	public Undefined NewValueSpecifiedUnits(ushort unitType, Number valueInSpecifiedUnits) { throw new System.NotImplementedException(); }
	[Value("convertToSpecifiedUnits")]
	public Undefined ConvertToSpecifiedUnits(ushort unitType) { throw new System.NotImplementedException(); }
}

[Value("SVGNumberList")]
public partial class SVGNumberList
{
	[Value("length")]
	public ulong Length { get; }
	[Value("numberOfItems")]
	public ulong NumberOfItems { get; }
	[Value("clear")]
	public Undefined Clear() { throw new System.NotImplementedException(); }
	[Value("initialize")]
	public SVGNumber Initialize(SVGNumber newItem) { throw new System.NotImplementedException(); }
	
	[Value("insertItemBefore")]
	public SVGNumber InsertItemBefore(SVGNumber newItem, ulong index) { throw new System.NotImplementedException(); }
	[Value("replaceItem")]
	public SVGNumber ReplaceItem(SVGNumber newItem, ulong index) { throw new System.NotImplementedException(); }
	[Value("removeItem")]
	public SVGNumber RemoveItem(ulong index) { throw new System.NotImplementedException(); }
	[Value("appendItem")]
	public SVGNumber AppendItem(SVGNumber newItem) { throw new System.NotImplementedException(); }
	
}

[Value("SVGLengthList")]
public partial class SVGLengthList
{
	[Value("length")]
	public ulong Length { get; }
	[Value("numberOfItems")]
	public ulong NumberOfItems { get; }
	[Value("clear")]
	public Undefined Clear() { throw new System.NotImplementedException(); }
	[Value("initialize")]
	public SVGLength Initialize(SVGLength newItem) { throw new System.NotImplementedException(); }
	
	[Value("insertItemBefore")]
	public SVGLength InsertItemBefore(SVGLength newItem, ulong index) { throw new System.NotImplementedException(); }
	[Value("replaceItem")]
	public SVGLength ReplaceItem(SVGLength newItem, ulong index) { throw new System.NotImplementedException(); }
	[Value("removeItem")]
	public SVGLength RemoveItem(ulong index) { throw new System.NotImplementedException(); }
	[Value("appendItem")]
	public SVGLength AppendItem(SVGLength newItem) { throw new System.NotImplementedException(); }
	
}

[Value("SVGStringList")]
public partial class SVGStringList
{
	[Value("length")]
	public ulong Length { get; }
	[Value("numberOfItems")]
	public ulong NumberOfItems { get; }
	[Value("clear")]
	public Undefined Clear() { throw new System.NotImplementedException(); }
	[Value("initialize")]
	public DOMString Initialize(DOMString newItem) { throw new System.NotImplementedException(); }
	
	[Value("insertItemBefore")]
	public DOMString InsertItemBefore(DOMString newItem, ulong index) { throw new System.NotImplementedException(); }
	[Value("replaceItem")]
	public DOMString ReplaceItem(DOMString newItem, ulong index) { throw new System.NotImplementedException(); }
	[Value("removeItem")]
	public DOMString RemoveItem(ulong index) { throw new System.NotImplementedException(); }
	[Value("appendItem")]
	public DOMString AppendItem(DOMString newItem) { throw new System.NotImplementedException(); }
	
}

[Value("SVGAnimatedBoolean")]
public partial class SVGAnimatedBoolean
{
	[Value("baseVal")]
	public bool BaseVal { get; set; }
	[Value("animVal")]
	public bool AnimVal { get; }
}

[Value("SVGAnimatedEnumeration")]
public partial class SVGAnimatedEnumeration
{
	[Value("baseVal")]
	public ushort BaseVal { get; set; }
	[Value("animVal")]
	public ushort AnimVal { get; }
}

[Value("SVGAnimatedInteger")]
public partial class SVGAnimatedInteger
{
	[Value("baseVal")]
	public long BaseVal { get; set; }
	[Value("animVal")]
	public long AnimVal { get; }
}

[Value("SVGAnimatedNumber")]
public partial class SVGAnimatedNumber
{
	[Value("baseVal")]
	public Number BaseVal { get; set; }
	[Value("animVal")]
	public Number AnimVal { get; }
}

[Value("SVGAnimatedLength")]
public partial class SVGAnimatedLength
{
	[Value("baseVal")]
	public SVGLength BaseVal { get; }
	[Value("animVal")]
	public SVGLength AnimVal { get; }
}

[Value("SVGAnimatedAngle")]
public partial class SVGAnimatedAngle
{
	[Value("baseVal")]
	public SVGAngle BaseVal { get; }
	[Value("animVal")]
	public SVGAngle AnimVal { get; }
}

[Value("SVGAnimatedString")]
public partial class SVGAnimatedString
{
	[Value("baseVal")]
	public DOMString BaseVal { get; set; }
	[Value("animVal")]
	public DOMString AnimVal { get; }
}

[Value("SVGAnimatedRect")]
public partial class SVGAnimatedRect
{
	[Value("baseVal")]
	public DOMRect BaseVal { get; }
	[Value("animVal")]
	public DOMRectReadOnly AnimVal { get; }
}

[Value("SVGAnimatedNumberList")]
public partial class SVGAnimatedNumberList
{
	[Value("baseVal")]
	public SVGNumberList BaseVal { get; }
	[Value("animVal")]
	public SVGNumberList AnimVal { get; }
}

[Value("SVGAnimatedLengthList")]
public partial class SVGAnimatedLengthList
{
	[Value("baseVal")]
	public SVGLengthList BaseVal { get; }
	[Value("animVal")]
	public SVGLengthList AnimVal { get; }
}

[Value("SVGUnitTypes")]
public partial class SVGUnitTypes
{
	[Value("SVG_UNIT_TYPE_UNKNOWN")]
	public const ushort SVG_UNIT_TYPE_UNKNOWN = 0;
	[Value("SVG_UNIT_TYPE_USERSPACEONUSE")]
	public const ushort SVG_UNIT_TYPE_USERSPACEONUSE = 1;
	[Value("SVG_UNIT_TYPE_OBJECTBOUNDINGBOX")]
	public const ushort SVG_UNIT_TYPE_OBJECTBOUNDINGBOX = 2;
}

public partial class Document
{
	[Value("rootElement")]
	public SVGSVGElement? RootElement { get; }
}

public partial class SVGSVGElement : SVGGraphicsElement
{
	[Value("x")]
	public SVGAnimatedLength X { get; }
	[Value("y")]
	public SVGAnimatedLength Y { get; }
	[Value("width")]
	public SVGAnimatedLength Width { get; }
	[Value("height")]
	public SVGAnimatedLength Height { get; }
	[Value("currentScale")]
	public Number CurrentScale { get; set; }
	[Value("currentTranslate")]
	public DOMPointReadOnly CurrentTranslate { get; }
	[Value("getIntersectionList")]
	public NodeList GetIntersectionList(DOMRectReadOnly rect, SVGElement? referenceElement) { throw new System.NotImplementedException(); }
	[Value("getEnclosureList")]
	public NodeList GetEnclosureList(DOMRectReadOnly rect, SVGElement? referenceElement) { throw new System.NotImplementedException(); }
	[Value("checkIntersection")]
	public bool CheckIntersection(SVGElement element, DOMRectReadOnly rect) { throw new System.NotImplementedException(); }
	[Value("checkEnclosure")]
	public bool CheckEnclosure(SVGElement element, DOMRectReadOnly rect) { throw new System.NotImplementedException(); }
	[Value("deselectAll")]
	public Undefined DeselectAll() { throw new System.NotImplementedException(); }
	[Value("createSVGNumber")]
	public SVGNumber CreateSVGNumber() { throw new System.NotImplementedException(); }
	[Value("createSVGLength")]
	public SVGLength CreateSVGLength() { throw new System.NotImplementedException(); }
	[Value("createSVGAngle")]
	public SVGAngle CreateSVGAngle() { throw new System.NotImplementedException(); }
	[Value("createSVGPoint")]
	public DOMPoint CreateSVGPoint() { throw new System.NotImplementedException(); }
	[Value("createSVGMatrix")]
	public DOMMatrix CreateSVGMatrix() { throw new System.NotImplementedException(); }
	[Value("createSVGRect")]
	public DOMRect CreateSVGRect() { throw new System.NotImplementedException(); }
	[Value("createSVGTransform")]
	public SVGTransform CreateSVGTransform() { throw new System.NotImplementedException(); }
	[Value("createSVGTransformFromMatrix")]
	public SVGTransform CreateSVGTransformFromMatrix(DOMMatrix2DInit matrix = default) { throw new System.NotImplementedException(); }
	[Value("getElementById")]
	public Element GetElementById(DOMString elementId) { throw new System.NotImplementedException(); }
	[Value("suspendRedraw")]
	public ulong SuspendRedraw(ulong maxWaitMilliseconds) { throw new System.NotImplementedException(); }
	[Value("unsuspendRedraw")]
	public Undefined UnsuspendRedraw(ulong suspendHandleID) { throw new System.NotImplementedException(); }
	[Value("unsuspendRedrawAll")]
	public Undefined UnsuspendRedrawAll() { throw new System.NotImplementedException(); }
	[Value("forceRedraw")]
	public Undefined ForceRedraw() { throw new System.NotImplementedException(); }
}



[Value("SVGGElement")]
public partial class SVGGElement : SVGGraphicsElement
{
}

[Value("SVGDefsElement")]
public partial class SVGDefsElement : SVGGraphicsElement
{
}

[Value("SVGDescElement")]
public partial class SVGDescElement : SVGElement
{
}

[Value("SVGMetadataElement")]
public partial class SVGMetadataElement : SVGElement
{
}

[Value("SVGTitleElement")]
public partial class SVGTitleElement : SVGElement
{
}

[Value("SVGSymbolElement")]
public partial class SVGSymbolElement : SVGGraphicsElement, SVGFitToViewBox
{
}


[Value("SVGUseElement")]
public partial class SVGUseElement : SVGGraphicsElement, SVGURIReference
{
	[Value("x")]
	public SVGAnimatedLength X { get; }
	[Value("y")]
	public SVGAnimatedLength Y { get; }
	[Value("width")]
	public SVGAnimatedLength Width { get; }
	[Value("height")]
	public SVGAnimatedLength Height { get; }
	[Value("instanceRoot")]
	public SVGElement? InstanceRoot { get; }
	[Value("animatedInstanceRoot")]
	public SVGElement? AnimatedInstanceRoot { get; }
}


[Value("SVGUseElementShadowRoot")]
public partial class SVGUseElementShadowRoot : ShadowRoot
{
}

[Value("ShadowAnimation")]
public partial class ShadowAnimation : Animation
{
		public ShadowAnimation(Animation source, Union145 newTarget) { }
	[Value("sourceAnimation")]
	public Animation SourceAnimation { get; }
	public ShadowAnimation() { }
}

[Value("SVGSwitchElement")]
public partial class SVGSwitchElement : SVGGraphicsElement
{
}

[Value("SVGStyleElement")]
public partial class SVGStyleElement : SVGElement, LinkStyle
{
	[Value("type")]
	public DOMString Type { get; set; }
	[Value("media")]
	public DOMString Media { get; set; }
	[Value("title")]
	public DOMString Title { get; set; }
}


[Value("SVGTransform")]
public partial class SVGTransform
{
	[Value("SVG_TRANSFORM_UNKNOWN")]
	public const ushort SVG_TRANSFORM_UNKNOWN = 0;
	[Value("SVG_TRANSFORM_MATRIX")]
	public const ushort SVG_TRANSFORM_MATRIX = 1;
	[Value("SVG_TRANSFORM_TRANSLATE")]
	public const ushort SVG_TRANSFORM_TRANSLATE = 2;
	[Value("SVG_TRANSFORM_SCALE")]
	public const ushort SVG_TRANSFORM_SCALE = 3;
	[Value("SVG_TRANSFORM_ROTATE")]
	public const ushort SVG_TRANSFORM_ROTATE = 4;
	[Value("SVG_TRANSFORM_SKEWX")]
	public const ushort SVG_TRANSFORM_SKEWX = 5;
	[Value("SVG_TRANSFORM_SKEWY")]
	public const ushort SVG_TRANSFORM_SKEWY = 6;
	[Value("type")]
	public ushort Type { get; }
	[Value("matrix")]
	public DOMMatrix Matrix { get; }
	[Value("angle")]
	public Number Angle { get; }
	[Value("setMatrix")]
	public Undefined SetMatrix(DOMMatrix2DInit matrix = default) { throw new System.NotImplementedException(); }
	[Value("setTranslate")]
	public Undefined SetTranslate(Number tx, Number ty) { throw new System.NotImplementedException(); }
	[Value("setScale")]
	public Undefined SetScale(Number sx, Number sy) { throw new System.NotImplementedException(); }
	[Value("setRotate")]
	public Undefined SetRotate(Number angle, Number cx, Number cy) { throw new System.NotImplementedException(); }
	[Value("setSkewX")]
	public Undefined SetSkewX(Number angle) { throw new System.NotImplementedException(); }
	[Value("setSkewY")]
	public Undefined SetSkewY(Number angle) { throw new System.NotImplementedException(); }
}

[Value("SVGTransformList")]
public partial class SVGTransformList
{
	[Value("length")]
	public ulong Length { get; }
	[Value("numberOfItems")]
	public ulong NumberOfItems { get; }
	[Value("clear")]
	public Undefined Clear() { throw new System.NotImplementedException(); }
	[Value("initialize")]
	public SVGTransform Initialize(SVGTransform newItem) { throw new System.NotImplementedException(); }
	
	[Value("insertItemBefore")]
	public SVGTransform InsertItemBefore(SVGTransform newItem, ulong index) { throw new System.NotImplementedException(); }
	[Value("replaceItem")]
	public SVGTransform ReplaceItem(SVGTransform newItem, ulong index) { throw new System.NotImplementedException(); }
	[Value("removeItem")]
	public SVGTransform RemoveItem(ulong index) { throw new System.NotImplementedException(); }
	[Value("appendItem")]
	public SVGTransform AppendItem(SVGTransform newItem) { throw new System.NotImplementedException(); }
	
	[Value("createSVGTransformFromMatrix")]
	public SVGTransform CreateSVGTransformFromMatrix(DOMMatrix2DInit matrix = default) { throw new System.NotImplementedException(); }
	[Value("consolidate")]
	public SVGTransform? Consolidate() { throw new System.NotImplementedException(); }
}

[Value("SVGAnimatedTransformList")]
public partial class SVGAnimatedTransformList
{
	[Value("baseVal")]
	public SVGTransformList BaseVal { get; }
	[Value("animVal")]
	public SVGTransformList AnimVal { get; }
}

[Value("SVGPreserveAspectRatio")]
public partial class SVGPreserveAspectRatio
{
	[Value("SVG_PRESERVEASPECTRATIO_UNKNOWN")]
	public const ushort SVG_PRESERVEASPECTRATIO_UNKNOWN = 0;
	[Value("SVG_PRESERVEASPECTRATIO_NONE")]
	public const ushort SVG_PRESERVEASPECTRATIO_NONE = 1;
	[Value("SVG_PRESERVEASPECTRATIO_XMINYMIN")]
	public const ushort SVG_PRESERVEASPECTRATIO_XMINYMIN = 2;
	[Value("SVG_PRESERVEASPECTRATIO_XMIDYMIN")]
	public const ushort SVG_PRESERVEASPECTRATIO_XMIDYMIN = 3;
	[Value("SVG_PRESERVEASPECTRATIO_XMAXYMIN")]
	public const ushort SVG_PRESERVEASPECTRATIO_XMAXYMIN = 4;
	[Value("SVG_PRESERVEASPECTRATIO_XMINYMID")]
	public const ushort SVG_PRESERVEASPECTRATIO_XMINYMID = 5;
	[Value("SVG_PRESERVEASPECTRATIO_XMIDYMID")]
	public const ushort SVG_PRESERVEASPECTRATIO_XMIDYMID = 6;
	[Value("SVG_PRESERVEASPECTRATIO_XMAXYMID")]
	public const ushort SVG_PRESERVEASPECTRATIO_XMAXYMID = 7;
	[Value("SVG_PRESERVEASPECTRATIO_XMINYMAX")]
	public const ushort SVG_PRESERVEASPECTRATIO_XMINYMAX = 8;
	[Value("SVG_PRESERVEASPECTRATIO_XMIDYMAX")]
	public const ushort SVG_PRESERVEASPECTRATIO_XMIDYMAX = 9;
	[Value("SVG_PRESERVEASPECTRATIO_XMAXYMAX")]
	public const ushort SVG_PRESERVEASPECTRATIO_XMAXYMAX = 10;
	[Value("SVG_MEETORSLICE_UNKNOWN")]
	public const ushort SVG_MEETORSLICE_UNKNOWN = 0;
	[Value("SVG_MEETORSLICE_MEET")]
	public const ushort SVG_MEETORSLICE_MEET = 1;
	[Value("SVG_MEETORSLICE_SLICE")]
	public const ushort SVG_MEETORSLICE_SLICE = 2;
	[Value("align")]
	public ushort Align { get; set; }
	[Value("meetOrSlice")]
	public ushort MeetOrSlice { get; set; }
}

[Value("SVGAnimatedPreserveAspectRatio")]
public partial class SVGAnimatedPreserveAspectRatio
{
	[Value("baseVal")]
	public SVGPreserveAspectRatio BaseVal { get; }
	[Value("animVal")]
	public SVGPreserveAspectRatio AnimVal { get; }
}

[Value("SVGPathElement")]
public partial class SVGPathElement : SVGGeometryElement
{
}

[Value("SVGRectElement")]
public partial class SVGRectElement : SVGGeometryElement
{
	[Value("x")]
	public SVGAnimatedLength X { get; }
	[Value("y")]
	public SVGAnimatedLength Y { get; }
	[Value("width")]
	public SVGAnimatedLength Width { get; }
	[Value("height")]
	public SVGAnimatedLength Height { get; }
	[Value("rx")]
	public SVGAnimatedLength Rx { get; }
	[Value("ry")]
	public SVGAnimatedLength Ry { get; }
}

[Value("SVGCircleElement")]
public partial class SVGCircleElement : SVGGeometryElement
{
	[Value("cx")]
	public SVGAnimatedLength Cx { get; }
	[Value("cy")]
	public SVGAnimatedLength Cy { get; }
	[Value("r")]
	public SVGAnimatedLength R { get; }
}

[Value("SVGEllipseElement")]
public partial class SVGEllipseElement : SVGGeometryElement
{
	[Value("cx")]
	public SVGAnimatedLength Cx { get; }
	[Value("cy")]
	public SVGAnimatedLength Cy { get; }
	[Value("rx")]
	public SVGAnimatedLength Rx { get; }
	[Value("ry")]
	public SVGAnimatedLength Ry { get; }
}

[Value("SVGLineElement")]
public partial class SVGLineElement : SVGGeometryElement
{
	[Value("x1")]
	public SVGAnimatedLength X1 { get; }
	[Value("y1")]
	public SVGAnimatedLength Y1 { get; }
	[Value("x2")]
	public SVGAnimatedLength X2 { get; }
	[Value("y2")]
	public SVGAnimatedLength Y2 { get; }
}

[Value("SVGPointList")]
public partial class SVGPointList
{
	[Value("length")]
	public ulong Length { get; }
	[Value("numberOfItems")]
	public ulong NumberOfItems { get; }
	[Value("clear")]
	public Undefined Clear() { throw new System.NotImplementedException(); }
	[Value("initialize")]
	public DOMPoint Initialize(DOMPoint newItem) { throw new System.NotImplementedException(); }
	
	[Value("insertItemBefore")]
	public DOMPoint InsertItemBefore(DOMPoint newItem, ulong index) { throw new System.NotImplementedException(); }
	[Value("replaceItem")]
	public DOMPoint ReplaceItem(DOMPoint newItem, ulong index) { throw new System.NotImplementedException(); }
	[Value("removeItem")]
	public DOMPoint RemoveItem(ulong index) { throw new System.NotImplementedException(); }
	[Value("appendItem")]
	public DOMPoint AppendItem(DOMPoint newItem) { throw new System.NotImplementedException(); }
	
}

[Value("SVGPolylineElement")]
public partial class SVGPolylineElement : SVGGeometryElement, SVGAnimatedPoints
{
}


[Value("SVGPolygonElement")]
public partial class SVGPolygonElement : SVGGeometryElement, SVGAnimatedPoints
{
}


[Value("SVGTextContentElement")]
public partial class SVGTextContentElement : SVGGraphicsElement
{
	[Value("LENGTHADJUST_UNKNOWN")]
	public const ushort LENGTHADJUST_UNKNOWN = 0;
	[Value("LENGTHADJUST_SPACING")]
	public const ushort LENGTHADJUST_SPACING = 1;
	[Value("LENGTHADJUST_SPACINGANDGLYPHS")]
	public const ushort LENGTHADJUST_SPACINGANDGLYPHS = 2;
	[Value("textLength")]
	public SVGAnimatedLength TextLength { get; }
	[Value("lengthAdjust")]
	public SVGAnimatedEnumeration LengthAdjust { get; }
	[Value("getNumberOfChars")]
	public long GetNumberOfChars() { throw new System.NotImplementedException(); }
	[Value("getComputedTextLength")]
	public Number GetComputedTextLength() { throw new System.NotImplementedException(); }
	[Value("getSubStringLength")]
	public Number GetSubStringLength(ulong charnum, ulong nchars) { throw new System.NotImplementedException(); }
	[Value("getStartPositionOfChar")]
	public DOMPoint GetStartPositionOfChar(ulong charnum) { throw new System.NotImplementedException(); }
	[Value("getEndPositionOfChar")]
	public DOMPoint GetEndPositionOfChar(ulong charnum) { throw new System.NotImplementedException(); }
	[Value("getExtentOfChar")]
	public DOMRect GetExtentOfChar(ulong charnum) { throw new System.NotImplementedException(); }
	[Value("getRotationOfChar")]
	public Number GetRotationOfChar(ulong charnum) { throw new System.NotImplementedException(); }
	[Value("getCharNumAtPosition")]
	public long GetCharNumAtPosition(DOMPointInit point = default) { throw new System.NotImplementedException(); }
	[Value("selectSubString")]
	public Undefined SelectSubString(ulong charnum, ulong nchars) { throw new System.NotImplementedException(); }
}

[Value("SVGTextPositioningElement")]
public partial class SVGTextPositioningElement : SVGTextContentElement
{
	[Value("x")]
	public SVGAnimatedLengthList X { get; }
	[Value("y")]
	public SVGAnimatedLengthList Y { get; }
	[Value("dx")]
	public SVGAnimatedLengthList Dx { get; }
	[Value("dy")]
	public SVGAnimatedLengthList Dy { get; }
	[Value("rotate")]
	public SVGAnimatedNumberList Rotate { get; }
}

[Value("SVGTextElement")]
public partial class SVGTextElement : SVGTextPositioningElement
{
}

[Value("SVGTSpanElement")]
public partial class SVGTSpanElement : SVGTextPositioningElement
{
}

[Value("SVGTextPathElement")]
public partial class SVGTextPathElement : SVGTextContentElement, SVGURIReference
{
	[Value("TEXTPATH_METHODTYPE_UNKNOWN")]
	public const ushort TEXTPATH_METHODTYPE_UNKNOWN = 0;
	[Value("TEXTPATH_METHODTYPE_ALIGN")]
	public const ushort TEXTPATH_METHODTYPE_ALIGN = 1;
	[Value("TEXTPATH_METHODTYPE_STRETCH")]
	public const ushort TEXTPATH_METHODTYPE_STRETCH = 2;
	[Value("TEXTPATH_SPACINGTYPE_UNKNOWN")]
	public const ushort TEXTPATH_SPACINGTYPE_UNKNOWN = 0;
	[Value("TEXTPATH_SPACINGTYPE_AUTO")]
	public const ushort TEXTPATH_SPACINGTYPE_AUTO = 1;
	[Value("TEXTPATH_SPACINGTYPE_EXACT")]
	public const ushort TEXTPATH_SPACINGTYPE_EXACT = 2;
	[Value("startOffset")]
	public SVGAnimatedLength StartOffset { get; }
	[Value("method")]
	public SVGAnimatedEnumeration Method { get; }
	[Value("spacing")]
	public SVGAnimatedEnumeration Spacing { get; }
}


[Value("SVGImageElement")]
public partial class SVGImageElement : SVGGraphicsElement, SVGURIReference
{
	[Value("x")]
	public SVGAnimatedLength X { get; }
	[Value("y")]
	public SVGAnimatedLength Y { get; }
	[Value("width")]
	public SVGAnimatedLength Width { get; }
	[Value("height")]
	public SVGAnimatedLength Height { get; }
	[Value("preserveAspectRatio")]
	public SVGAnimatedPreserveAspectRatio PreserveAspectRatio { get; }
	[Value("crossOrigin")]
	public DOMString? CrossOrigin { get; set; }
}


[Value("SVGForeignObjectElement")]
public partial class SVGForeignObjectElement : SVGGraphicsElement
{
	[Value("x")]
	public SVGAnimatedLength X { get; }
	[Value("y")]
	public SVGAnimatedLength Y { get; }
	[Value("width")]
	public SVGAnimatedLength Width { get; }
	[Value("height")]
	public SVGAnimatedLength Height { get; }
}

[Value("SVGMarkerElement")]
public partial class SVGMarkerElement : SVGElement, SVGFitToViewBox
{
	[Value("SVG_MARKERUNITS_UNKNOWN")]
	public const ushort SVG_MARKERUNITS_UNKNOWN = 0;
	[Value("SVG_MARKERUNITS_USERSPACEONUSE")]
	public const ushort SVG_MARKERUNITS_USERSPACEONUSE = 1;
	[Value("SVG_MARKERUNITS_STROKEWIDTH")]
	public const ushort SVG_MARKERUNITS_STROKEWIDTH = 2;
	[Value("SVG_MARKER_ORIENT_UNKNOWN")]
	public const ushort SVG_MARKER_ORIENT_UNKNOWN = 0;
	[Value("SVG_MARKER_ORIENT_AUTO")]
	public const ushort SVG_MARKER_ORIENT_AUTO = 1;
	[Value("SVG_MARKER_ORIENT_ANGLE")]
	public const ushort SVG_MARKER_ORIENT_ANGLE = 2;
	[Value("refX")]
	public SVGAnimatedLength RefX { get; }
	[Value("refY")]
	public SVGAnimatedLength RefY { get; }
	[Value("markerUnits")]
	public SVGAnimatedEnumeration MarkerUnits { get; }
	[Value("markerWidth")]
	public SVGAnimatedLength MarkerWidth { get; }
	[Value("markerHeight")]
	public SVGAnimatedLength MarkerHeight { get; }
	[Value("orientType")]
	public SVGAnimatedEnumeration OrientType { get; }
	[Value("orientAngle")]
	public SVGAnimatedAngle OrientAngle { get; }
	[Value("orient")]
	public DOMString Orient { get; set; }
	[Value("setOrientToAuto")]
	public Undefined SetOrientToAuto() { throw new System.NotImplementedException(); }
	[Value("setOrientToAngle")]
	public Undefined SetOrientToAngle(SVGAngle angle) { throw new System.NotImplementedException(); }
}


[Value("SVGGradientElement")]
public partial class SVGGradientElement : SVGElement, SVGURIReference
{
	[Value("SVG_SPREADMETHOD_UNKNOWN")]
	public const ushort SVG_SPREADMETHOD_UNKNOWN = 0;
	[Value("SVG_SPREADMETHOD_PAD")]
	public const ushort SVG_SPREADMETHOD_PAD = 1;
	[Value("SVG_SPREADMETHOD_REFLECT")]
	public const ushort SVG_SPREADMETHOD_REFLECT = 2;
	[Value("SVG_SPREADMETHOD_REPEAT")]
	public const ushort SVG_SPREADMETHOD_REPEAT = 3;
	[Value("gradientUnits")]
	public SVGAnimatedEnumeration GradientUnits { get; }
	[Value("gradientTransform")]
	public SVGAnimatedTransformList GradientTransform { get; }
	[Value("spreadMethod")]
	public SVGAnimatedEnumeration SpreadMethod { get; }
}


[Value("SVGLinearGradientElement")]
public partial class SVGLinearGradientElement : SVGGradientElement
{
	[Value("x1")]
	public SVGAnimatedLength X1 { get; }
	[Value("y1")]
	public SVGAnimatedLength Y1 { get; }
	[Value("x2")]
	public SVGAnimatedLength X2 { get; }
	[Value("y2")]
	public SVGAnimatedLength Y2 { get; }
}

[Value("SVGRadialGradientElement")]
public partial class SVGRadialGradientElement : SVGGradientElement
{
	[Value("cx")]
	public SVGAnimatedLength Cx { get; }
	[Value("cy")]
	public SVGAnimatedLength Cy { get; }
	[Value("r")]
	public SVGAnimatedLength R { get; }
	[Value("fx")]
	public SVGAnimatedLength Fx { get; }
	[Value("fy")]
	public SVGAnimatedLength Fy { get; }
	[Value("fr")]
	public SVGAnimatedLength Fr { get; }
}

[Value("SVGStopElement")]
public partial class SVGStopElement : SVGElement
{
	[Value("offset")]
	public SVGAnimatedNumber Offset { get; }
}

[Value("SVGPatternElement")]
public partial class SVGPatternElement : SVGElement, SVGFitToViewBox, SVGURIReference
{
	[Value("patternUnits")]
	public SVGAnimatedEnumeration PatternUnits { get; }
	[Value("patternContentUnits")]
	public SVGAnimatedEnumeration PatternContentUnits { get; }
	[Value("patternTransform")]
	public SVGAnimatedTransformList PatternTransform { get; }
	[Value("x")]
	public SVGAnimatedLength X { get; }
	[Value("y")]
	public SVGAnimatedLength Y { get; }
	[Value("width")]
	public SVGAnimatedLength Width { get; }
	[Value("height")]
	public SVGAnimatedLength Height { get; }
}



[Value("SVGScriptElement")]
public partial class SVGScriptElement : SVGElement, SVGURIReference
{
	[Value("type")]
	public DOMString Type { get; set; }
	[Value("crossOrigin")]
	public DOMString? CrossOrigin { get; set; }
}


[Value("SVGAElement")]
public partial class SVGAElement : SVGGraphicsElement, SVGURIReference
{
	[Value("target")]
	public SVGAnimatedString Target { get; }
	[Value("download")]
	public DOMString Download { get; set; }
	[Value("ping")]
	public USVString Ping { get; set; }
	[Value("rel")]
	public DOMString Rel { get; set; }
	[Value("relList")]
	public DOMTokenList RelList { get; }
	[Value("hreflang")]
	public DOMString Hreflang { get; set; }
	[Value("type")]
	public DOMString Type { get; set; }
	[Value("text")]
	public DOMString Text { get; set; }
	[Value("referrerPolicy")]
	public DOMString ReferrerPolicy { get; set; }
}


public partial class SVGAElement
{
	[Value("origin")]
	public USVString Origin { get; }
	[Value("protocol")]
	public USVString Protocol { get; set; }
	[Value("username")]
	public USVString Username { get; set; }
	[Value("password")]
	public USVString Password { get; set; }
	[Value("host")]
	public USVString Host { get; set; }
	[Value("hostname")]
	public USVString Hostname { get; set; }
	[Value("port")]
	public USVString Port { get; set; }
	[Value("pathname")]
	public USVString Pathname { get; set; }
	[Value("search")]
	public USVString Search { get; set; }
	[Value("hash")]
	public USVString Hash { get; set; }
}

[Value("SVGViewElement")]
public partial class SVGViewElement : SVGElement, SVGFitToViewBox
{
}


[Value("TestUtils")]
public partial class TestUtils
{
	[Value("gc")]
	public Task<Undefined> Gc() { throw new System.NotImplementedException(); }
}

[Value("TextDetector")]
public partial class TextDetector
{
		public TextDetector() { }
	[Value("detect")]
	public Task<List<DetectedText>> Detect(ImageBitmapSource image) { throw new System.NotImplementedException(); }
}

[Value("DetectedText")]
public partial class DetectedText
{
	[Value("boundingBox")]
	public required DOMRectReadOnly BoundingBox;
	[Value("rawValue")]
	public required DOMString RawValue;
	[Value("cornerPoints")]
	public required List<Point2D> CornerPoints;
}

[Value("TouchInit")]
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

[Value("Touch")]
public partial class Touch
{
		public Touch(TouchInit touchInitDict) { }
	[Value("identifier")]
	public long Identifier { get; }
	[Value("target")]
	public EventTarget Target { get; }
	[Value("screenX")]
	public Number ScreenX { get; }
	[Value("screenY")]
	public Number ScreenY { get; }
	[Value("clientX")]
	public Number ClientX { get; }
	[Value("clientY")]
	public Number ClientY { get; }
	[Value("pageX")]
	public Number PageX { get; }
	[Value("pageY")]
	public Number PageY { get; }
	[Value("radiusX")]
	public Number RadiusX { get; }
	[Value("radiusY")]
	public Number RadiusY { get; }
	[Value("rotationAngle")]
	public Number RotationAngle { get; }
	[Value("force")]
	public Number Force { get; }
	[Value("altitudeAngle")]
	public Number AltitudeAngle { get; }
	[Value("azimuthAngle")]
	public Number AzimuthAngle { get; }
	[Value("touchType")]
	public TouchType TouchType { get; }
	public Touch() { }
}

[Value("TouchList")]
public partial class TouchList
{
	[Value("length")]
	public ulong Length { get; }
	
}

[Value("TouchEventInit")]
public partial class TouchEventInit : EventModifierInit
{
	[Value("touches")]
	public List<Touch> Touches;
	[Value("targetTouches")]
	public List<Touch> TargetTouches;
	[Value("changedTouches")]
	public List<Touch> ChangedTouches;
}

[Value("TouchEvent")]
public partial class TouchEvent : UIEvent
{
		public TouchEvent(DOMString type, TouchEventInit eventInitDict = default) { }
	[Value("touches")]
	public TouchList Touches { get; }
	[Value("targetTouches")]
	public TouchList TargetTouches { get; }
	[Value("changedTouches")]
	public TouchList ChangedTouches { get; }
	[Value("altKey")]
	public bool AltKey { get; }
	[Value("metaKey")]
	public bool MetaKey { get; }
	[Value("ctrlKey")]
	public bool CtrlKey { get; }
	[Value("shiftKey")]
	public bool ShiftKey { get; }
	
	public TouchEvent() { }
}

[Value("PrivateToken")]
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

public partial class RequestInit
{
	[Value("privateToken")]
	public PrivateToken PrivateToken;
}

public partial class HTMLIFrameElement
{
	[Value("privateToken")]
	public DOMString PrivateToken { get; set; }
}

public partial class XMLHttpRequest
{
	[Value("setPrivateToken")]
	public Undefined SetPrivateToken(PrivateToken privateToken) { throw new System.NotImplementedException(); }
}

public partial class Document
{
	[Value("hasPrivateToken")]
	public Task<bool> HasPrivateToken(USVString issuer) { throw new System.NotImplementedException(); }
	[Value("hasRedemptionRecord")]
	public Task<bool> HasRedemptionRecord(USVString issuer) { throw new System.NotImplementedException(); }
}

[Value("TrustedHTML")]
public partial class TrustedHTML
{
	
	[Value("toJSON")]
	public DOMString ToJSON() { throw new System.NotImplementedException(); }
}

[Value("TrustedScript")]
public partial class TrustedScript
{
	
	[Value("toJSON")]
	public DOMString ToJSON() { throw new System.NotImplementedException(); }
}

[Value("TrustedScriptURL")]
public partial class TrustedScriptURL
{
	
	[Value("toJSON")]
	public USVString ToJSON() { throw new System.NotImplementedException(); }
}

[Value("TrustedTypePolicyFactory")]
public partial class TrustedTypePolicyFactory
{
	[Value("createPolicy")]
	public TrustedTypePolicy CreatePolicy(DOMString policyName, TrustedTypePolicyOptions policyOptions = default) { throw new System.NotImplementedException(); }
	[Value("isHTML")]
	public bool IsHTML(dynamic value) { throw new System.NotImplementedException(); }
	[Value("isScript")]
	public bool IsScript(dynamic value) { throw new System.NotImplementedException(); }
	[Value("isScriptURL")]
	public bool IsScriptURL(dynamic value) { throw new System.NotImplementedException(); }
	[Value("emptyHTML")]
	public TrustedHTML EmptyHTML { get; }
	[Value("emptyScript")]
	public TrustedScript EmptyScript { get; }
	[Value("getAttributeType")]
	public DOMString? GetAttributeType(DOMString tagName, DOMString attribute, DOMString? elementNs = default, DOMString? attrNs = default) { throw new System.NotImplementedException(); }
	[Value("getPropertyType")]
	public DOMString? GetPropertyType(DOMString tagName, DOMString property, DOMString? elementNs = default) { throw new System.NotImplementedException(); }
	[Value("defaultPolicy")]
	public TrustedTypePolicy? DefaultPolicy { get; }
}

[Value("TrustedTypePolicy")]
public partial class TrustedTypePolicy
{
	[Value("name")]
	public DOMString Name { get; }
	[Value("createHTML")]
	public TrustedHTML CreateHTML(DOMString input, params dynamic[] arguments) { throw new System.NotImplementedException(); }
	[Value("createScript")]
	public TrustedScript CreateScript(DOMString input, params dynamic[] arguments) { throw new System.NotImplementedException(); }
	[Value("createScriptURL")]
	public TrustedScriptURL CreateScriptURL(DOMString input, params dynamic[] arguments) { throw new System.NotImplementedException(); }
}

[Value("TrustedTypePolicyOptions")]
public partial class TrustedTypePolicyOptions
{
	[Value("createHTML")]
	public CreateHTMLCallback CreateHTML;
	[Value("createScript")]
	public CreateScriptCallback CreateScript;
	[Value("createScriptURL")]
	public CreateScriptURLCallback CreateScriptURL;
}

public partial class Navigator
{
	[Value("joinAdInterestGroup")]
	public Task<Undefined> JoinAdInterestGroup(AuctionAdInterestGroup group) { throw new System.NotImplementedException(); }
}

[Value("AuctionAd")]
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

[Value("AuctionAdInterestGroupSize")]
public partial class AuctionAdInterestGroupSize
{
	[Value("width")]
	public required USVString Width;
	[Value("height")]
	public required USVString Height;
}

[Value("GenerateBidInterestGroup")]
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

[Value("ProtectedAudiencePrivateAggregationConfig")]
public partial class ProtectedAudiencePrivateAggregationConfig
{
	[Value("aggregationCoordinatorOrigin")]
	public USVString AggregationCoordinatorOrigin;
}

[Value("AuctionAdInterestGroup")]
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

public partial class Navigator
{
	[Value("leaveAdInterestGroup")]
	public Task<Undefined> LeaveAdInterestGroup(AuctionAdInterestGroupKey group = default) { throw new System.NotImplementedException(); }
}

[Value("AuctionAdInterestGroupKey")]
public partial class AuctionAdInterestGroupKey
{
	[Value("owner")]
	public required USVString Owner;
	[Value("name")]
	public required USVString Name;
}

public partial class Navigator
{
	[Value("clearOriginJoinedAdInterestGroups")]
	public Task<Undefined> ClearOriginJoinedAdInterestGroups(USVString owner, List<USVString> interestGroupsToKeep = default) { throw new System.NotImplementedException(); }
}

public partial class Navigator
{
	[Value("runAdAuction")]
	public Task<USVString?> RunAdAuction(AuctionAdConfig config) { throw new System.NotImplementedException(); }
	[Value("deprecatedRunAdAuctionEnforcesKAnonymity")]
	public bool DeprecatedRunAdAuctionEnforcesKAnonymity { get; }
}

[Value("AuctionReportBuyersConfig")]
public partial class AuctionReportBuyersConfig
{
	[Value("bucket")]
	public required BigInt Bucket;
	[Value("scale")]
	public required Number Scale;
}

[Value("AuctionReportBuyerDebugModeConfig")]
public partial class AuctionReportBuyerDebugModeConfig
{
	[Value("enabled")]
	public bool Enabled;
	[Value("debugKey")]
	public BigInt? DebugKey;
}

[Value("AuctionRealTimeReportingConfig")]
public partial class AuctionRealTimeReportingConfig
{
	[Value("type")]
	public required DOMString Type;
}

[Value("AuctionAdConfig")]
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

public partial class Navigator
{
	[Value("canLoadAdAuctionFencedFrame")]
	public bool CanLoadAdAuctionFencedFrame() { throw new System.NotImplementedException(); }
}

public partial class Navigator
{
	[Value("getInterestGroupAdAuctionData")]
	public Task<AdAuctionData> GetInterestGroupAdAuctionData(AdAuctionDataConfig config) { throw new System.NotImplementedException(); }
}

[Value("AdAuctionData")]
public partial class AdAuctionData
{
	[Value("request")]
	public required Uint8Array Request;
	[Value("requestId")]
	public required USVString RequestId;
}

[Value("AdAuctionDataConfig")]
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

[Value("AdAuctionDataBuyerConfig")]
public partial class AdAuctionDataBuyerConfig
{
	[Value("targetSize")]
	public ulong TargetSize;
}

[Value("StorageInterestGroup")]
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

public partial class Navigator
{
	[Value("createAuctionNonce")]
	public Task<DOMString> CreateAuctionNonce() { throw new System.NotImplementedException(); }
}

[Value("InterestGroupScriptRunnerGlobalScope")]
public partial class InterestGroupScriptRunnerGlobalScope
{
	[Value("privateAggregation")]
	public PrivateAggregation? PrivateAggregation { get; }
}

[Value("PASignalValue")]
public partial class PASignalValue
{
	[Value("baseValue")]
	public required DOMString BaseValue;
	[Value("scale")]
	public Number Scale;
	[Value("offset")]
	public Union147 Offset;
}

[Value("PAExtendedHistogramContribution")]
public partial class PAExtendedHistogramContribution
{
	[Value("bucket")]
	public required Union148 Bucket;
	[Value("value")]
	public required Union149 Value;
	[Value("filteringId")]
	public BigInt FilteringId;
}

public partial class PrivateAggregation
{
	[Value("contributeToHistogramOnEvent")]
	public Undefined ContributeToHistogramOnEvent(DOMString event_, PAExtendedHistogramContribution contribution) { throw new System.NotImplementedException(); }
}

[Value("ForDebuggingOnly")]
public partial class ForDebuggingOnly
{
	[Value("reportAdAuctionWin")]
	public Undefined ReportAdAuctionWin(USVString url) { throw new System.NotImplementedException(); }
	[Value("reportAdAuctionLoss")]
	public Undefined ReportAdAuctionLoss(USVString url) { throw new System.NotImplementedException(); }
}

[Value("RealTimeReporting")]
public partial class RealTimeReporting
{
	[Value("contributeToHistogram")]
	public Undefined ContributeToHistogram(RealTimeContribution contribution) { throw new System.NotImplementedException(); }
}

[Value("RealTimeContribution")]
public partial class RealTimeContribution
{
	[Value("bucket")]
	public required long Bucket;
	[Value("priorityWeight")]
	public required Number PriorityWeight;
	[Value("latencyThreshold")]
	public long LatencyThreshold;
}

[Value("InterestGroupBiddingAndScoringScriptRunnerGlobalScope")]
public partial class InterestGroupBiddingAndScoringScriptRunnerGlobalScope : InterestGroupScriptRunnerGlobalScope
{
	[Value("forDebuggingOnly")]
	public ForDebuggingOnly ForDebuggingOnly { get; }
	[Value("realTimeReporting")]
	public RealTimeReporting RealTimeReporting { get; }
}

[Value("InterestGroupBiddingScriptRunnerGlobalScope")]
public partial class InterestGroupBiddingScriptRunnerGlobalScope : InterestGroupBiddingAndScoringScriptRunnerGlobalScope
{
	[Value("setBid")]
	public bool SetBid(Union150 oneOrManyBids = default) { throw new System.NotImplementedException(); }
	[Value("setPriority")]
	public Undefined SetPriority(Number priority) { throw new System.NotImplementedException(); }
	[Value("setPrioritySignalsOverride")]
	public Undefined SetPrioritySignalsOverride(DOMString key, Number? priority = default) { throw new System.NotImplementedException(); }
}

[Value("AdRender")]
public partial class AdRender
{
	[Value("url")]
	public required DOMString Url;
	[Value("width")]
	public DOMString Width;
	[Value("height")]
	public DOMString Height;
}

[Value("GenerateBidOutput")]
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

[Value("InterestGroupScoringScriptRunnerGlobalScope")]
public partial class InterestGroupScoringScriptRunnerGlobalScope : InterestGroupBiddingAndScoringScriptRunnerGlobalScope
{
}

[Value("InterestGroupReportingScriptRunnerGlobalScope")]
public partial class InterestGroupReportingScriptRunnerGlobalScope : InterestGroupScriptRunnerGlobalScope
{
	[Value("sendReportTo")]
	public Undefined SendReportTo(DOMString url) { throw new System.NotImplementedException(); }
	[Value("registerAdBeacon")]
	public Undefined RegisterAdBeacon(Dictionary<DOMString, USVString> map) { throw new System.NotImplementedException(); }
	[Value("registerAdMacro")]
	public Undefined RegisterAdMacro(DOMString name, USVString value) { throw new System.NotImplementedException(); }
}

public partial class Navigator
{
	[Value("updateAdInterestGroups")]
	public Undefined UpdateAdInterestGroups() { throw new System.NotImplementedException(); }
}

public partial class Navigator
{
	[Value("protectedAudience")]
	public ProtectedAudience ProtectedAudience { get; }
}

[Value("ProtectedAudience")]
public partial class ProtectedAudience
{
	[Value("queryFeatureSupport")]
	public dynamic QueryFeatureSupport(DOMString feature) { throw new System.NotImplementedException(); }
}

public partial class RequestInit
{
	[Value("adAuctionHeaders")]
	public bool AdAuctionHeaders;
}

public partial class HTMLIFrameElement
{
	[Value("adAuctionHeaders")]
	public bool AdAuctionHeaders { get; set; }
}



[Value("BiddingBrowserSignals")]
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

[Value("ScoringBrowserSignals")]
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

[Value("ReportingBrowserSignals")]
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

[Value("ReportResultBrowserSignals")]
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

[Value("ReportWinBrowserSignals")]
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

[Value("DirectFromSellerSignalsForBuyer")]
public partial class DirectFromSellerSignalsForBuyer
{
	[Value("auctionSignals")]
	public dynamic AuctionSignals;
	[Value("perBuyerSignals")]
	public dynamic PerBuyerSignals;
}

[Value("DirectFromSellerSignalsForSeller")]
public partial class DirectFromSellerSignalsForSeller
{
	[Value("auctionSignals")]
	public dynamic AuctionSignals;
	[Value("sellerSignals")]
	public dynamic SellerSignals;
}

[Value("ScoreAdOutput")]
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

[Value("NavigatorUABrandVersion")]
public partial class NavigatorUABrandVersion
{
	[Value("brand")]
	public DOMString Brand;
	[Value("version")]
	public DOMString Version;
}

[Value("UADataValues")]
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

[Value("UALowEntropyJSON")]
public partial class UALowEntropyJSON
{
	[Value("brands")]
	public List<NavigatorUABrandVersion> Brands;
	[Value("mobile")]
	public bool Mobile;
	[Value("platform")]
	public DOMString Platform;
}

[Value("NavigatorUAData")]
public partial class NavigatorUAData
{
	[Value("brands")]
	public NavigatorUABrandVersion[] Brands { get; }
	[Value("mobile")]
	public bool Mobile { get; }
	[Value("platform")]
	public DOMString Platform { get; }
	[Value("getHighEntropyValues")]
	public Task<UADataValues> GetHighEntropyValues(List<DOMString> hints) { throw new System.NotImplementedException(); }
	[Value("toJSON")]
	public UALowEntropyJSON ToJSON() { throw new System.NotImplementedException(); }
}

public partial class UIEvent : Event
{
		public UIEvent(DOMString type, UIEventInit eventInitDict = default) { }
	[Value("view")]
	public Window? View { get; }
	[Value("detail")]
	public long Detail { get; }
	public UIEvent() { }
}

public partial class UIEventInit : EventInit
{
	[Value("view")]
	public Window? View;
	[Value("detail")]
	public long Detail;
}

[Value("FocusEvent")]
public partial class FocusEvent : UIEvent
{
		public FocusEvent(DOMString type, FocusEventInit eventInitDict = default) { }
	[Value("relatedTarget")]
	public EventTarget? RelatedTarget { get; }
	public FocusEvent() { }
}

[Value("FocusEventInit")]
public partial class FocusEventInit : UIEventInit
{
	[Value("relatedTarget")]
	public EventTarget? RelatedTarget;
}

public partial class MouseEvent : UIEvent
{
		public MouseEvent(DOMString type, MouseEventInit eventInitDict = default) { }
	[Value("screenX")]
	public long ScreenX { get; }
	[Value("screenY")]
	public long ScreenY { get; }
	[Value("clientX")]
	public long ClientX { get; }
	[Value("clientY")]
	public long ClientY { get; }
	[Value("layerX")]
	public long LayerX { get; }
	[Value("layerY")]
	public long LayerY { get; }
	[Value("ctrlKey")]
	public bool CtrlKey { get; }
	[Value("shiftKey")]
	public bool ShiftKey { get; }
	[Value("altKey")]
	public bool AltKey { get; }
	[Value("metaKey")]
	public bool MetaKey { get; }
	[Value("button")]
	public Number Button { get; }
	[Value("buttons")]
	public ushort Buttons { get; }
	[Value("relatedTarget")]
	public EventTarget? RelatedTarget { get; }
	[Value("getModifierState")]
	public bool GetModifierState(DOMString keyArg) { throw new System.NotImplementedException(); }
	public MouseEvent() { }
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

[Value("EventModifierInit")]
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

[Value("WheelEvent")]
public partial class WheelEvent : MouseEvent
{
		public WheelEvent(DOMString type, WheelEventInit eventInitDict = default) { }
	[Value("DOM_DELTA_PIXEL")]
	public const ulong DOM_DELTA_PIXEL = 0x00;
	[Value("DOM_DELTA_LINE")]
	public const ulong DOM_DELTA_LINE = 0x01;
	[Value("DOM_DELTA_PAGE")]
	public const ulong DOM_DELTA_PAGE = 0x02;
	[Value("deltaX")]
	public Number DeltaX { get; }
	[Value("deltaY")]
	public Number DeltaY { get; }
	[Value("deltaZ")]
	public Number DeltaZ { get; }
	[Value("deltaMode")]
	public ulong DeltaMode { get; }
	public WheelEvent() { }
}

[Value("WheelEventInit")]
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

public partial class InputEvent : UIEvent
{
		public InputEvent(DOMString type, InputEventInit eventInitDict = default) { }
	[Value("data")]
	public USVString? Data { get; }
	[Value("isComposing")]
	public bool IsComposing { get; }
	[Value("inputType")]
	public DOMString InputType { get; }
	public InputEvent() { }
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

[Value("KeyboardEvent")]
public partial class KeyboardEvent : UIEvent
{
		public KeyboardEvent(DOMString type, KeyboardEventInit eventInitDict = default) { }
	[Value("DOM_KEY_LOCATION_STANDARD")]
	public const ulong DOM_KEY_LOCATION_STANDARD = 0x00;
	[Value("DOM_KEY_LOCATION_LEFT")]
	public const ulong DOM_KEY_LOCATION_LEFT = 0x01;
	[Value("DOM_KEY_LOCATION_RIGHT")]
	public const ulong DOM_KEY_LOCATION_RIGHT = 0x02;
	[Value("DOM_KEY_LOCATION_NUMPAD")]
	public const ulong DOM_KEY_LOCATION_NUMPAD = 0x03;
	[Value("key")]
	public DOMString Key { get; }
	[Value("code")]
	public DOMString Code { get; }
	[Value("location")]
	public ulong Location { get; }
	[Value("ctrlKey")]
	public bool CtrlKey { get; }
	[Value("shiftKey")]
	public bool ShiftKey { get; }
	[Value("altKey")]
	public bool AltKey { get; }
	[Value("metaKey")]
	public bool MetaKey { get; }
	[Value("repeat")]
	public bool Repeat { get; }
	[Value("isComposing")]
	public bool IsComposing { get; }
	[Value("getModifierState")]
	public bool GetModifierState(DOMString keyArg) { throw new System.NotImplementedException(); }
	public KeyboardEvent() { }
}

[Value("KeyboardEventInit")]
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

[Value("CompositionEvent")]
public partial class CompositionEvent : UIEvent
{
		public CompositionEvent(DOMString type, CompositionEventInit eventInitDict = default) { }
	[Value("data")]
	public USVString Data { get; }
	public CompositionEvent() { }
}

[Value("CompositionEventInit")]
public partial class CompositionEventInit : UIEventInit
{
	[Value("data")]
	public DOMString Data;
}

public partial class UIEvent
{
	[Value("initUIEvent")]
	public Undefined InitUIEvent(DOMString typeArg, bool bubblesArg = default, bool cancelableArg = default, Window? viewArg = default, long detailArg = default) { throw new System.NotImplementedException(); }
}

public partial class MouseEvent
{
	[Value("initMouseEvent")]
	public Undefined InitMouseEvent(DOMString typeArg, bool bubblesArg = default, bool cancelableArg = default, Window? viewArg = default, long detailArg = default, long screenXArg = default, long screenYArg = default, long clientXArg = default, long clientYArg = default, bool ctrlKeyArg = default, bool altKeyArg = default, bool shiftKeyArg = default, bool metaKeyArg = default, Number buttonArg = default, EventTarget? relatedTargetArg = default) { throw new System.NotImplementedException(); }
}

public partial class KeyboardEvent
{
	[Value("initKeyboardEvent")]
	public Undefined InitKeyboardEvent(DOMString typeArg, bool bubblesArg = default, bool cancelableArg = default, Window? viewArg = default, DOMString keyArg = default, ulong locationArg = default, bool ctrlKey = default, bool altKey = default, bool shiftKey = default, bool metaKey = default) { throw new System.NotImplementedException(); }
}

public partial class CompositionEvent
{
	[Value("initCompositionEvent")]
	public Undefined InitCompositionEvent(DOMString typeArg, bool bubblesArg = default, bool cancelableArg = default, WindowProxy? viewArg = default, DOMString dataArg = default) { throw new System.NotImplementedException(); }
}

public partial class UIEvent
{
	[Value("which")]
	public ulong Which { get; }
}

public partial class UIEventInit
{
	[Value("which")]
	public ulong Which;
}

public partial class KeyboardEvent
{
	[Value("charCode")]
	public ulong CharCode { get; }
	[Value("keyCode")]
	public ulong KeyCode { get; }
}

public partial class KeyboardEventInit
{
	[Value("charCode")]
	public ulong CharCode;
	[Value("keyCode")]
	public ulong KeyCode;
}

[Value("TextEvent")]
public partial class TextEvent : UIEvent
{
	[Value("data")]
	public DOMString Data { get; }
	[Value("initTextEvent")]
	public Undefined InitTextEvent(DOMString type, bool bubbles = default, bool cancelable = default, Window? view = default, DOMString data = default) { throw new System.NotImplementedException(); }
}

public partial class URL
{
		public URL(USVString url, USVString base_ = default) { }
	[Value("parse")]
	public static URL? Parse(USVString url, USVString base_ = default) { throw new System.NotImplementedException(); }
	[Value("canParse")]
	public static bool CanParse(USVString url, USVString base_ = default) { throw new System.NotImplementedException(); }
	[Value("href")]
	public USVString Href { get; set; }
	[Value("origin")]
	public USVString Origin { get; }
	[Value("protocol")]
	public USVString Protocol { get; set; }
	[Value("username")]
	public USVString Username { get; set; }
	[Value("password")]
	public USVString Password { get; set; }
	[Value("host")]
	public USVString Host { get; set; }
	[Value("hostname")]
	public USVString Hostname { get; set; }
	[Value("port")]
	public USVString Port { get; set; }
	[Value("pathname")]
	public USVString Pathname { get; set; }
	[Value("search")]
	public USVString Search { get; set; }
	[Value("searchParams")]
	public URLSearchParams SearchParams { get; }
	[Value("hash")]
	public USVString Hash { get; set; }
	[Value("toJSON")]
	public USVString ToJSON() { throw new System.NotImplementedException(); }
	public URL() { }
}

[Value("URLSearchParams")]
public partial class URLSearchParams
{
		public URLSearchParams(Union153 init = default) { }
	[Value("size")]
	public ulong Size { get; }
	[Value("append")]
	public Undefined Append(USVString name, USVString value) { throw new System.NotImplementedException(); }
	[Value("delete")]
	public Undefined Delete(USVString name, USVString value = default) { throw new System.NotImplementedException(); }
	[Value("get")]
	public USVString? Get(USVString name) { throw new System.NotImplementedException(); }
	[Value("getAll")]
	public List<USVString> GetAll(USVString name) { throw new System.NotImplementedException(); }
	[Value("has")]
	public bool Has(USVString name, USVString value = default) { throw new System.NotImplementedException(); }
	[Value("set")]
	public Undefined Set(USVString name, USVString value) { throw new System.NotImplementedException(); }
	[Value("sort")]
	public Undefined Sort() { throw new System.NotImplementedException(); }
	public USVString this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	
	public URLSearchParams() { }
}


[Value("URLPattern")]
public partial class URLPattern
{
		public URLPattern(URLPatternInput input, USVString baseURL, URLPatternOptions options = default) { }
		public URLPattern(URLPatternInput input = default, URLPatternOptions options = default) { }
	[Value("test")]
	public bool Test(URLPatternInput input = default, USVString baseURL = default) { throw new System.NotImplementedException(); }
	[Value("exec")]
	public URLPatternResult? Exec(URLPatternInput input = default, USVString baseURL = default) { throw new System.NotImplementedException(); }
	[Value("protocol")]
	public USVString Protocol { get; }
	[Value("username")]
	public USVString Username { get; }
	[Value("password")]
	public USVString Password { get; }
	[Value("hostname")]
	public USVString Hostname { get; }
	[Value("port")]
	public USVString Port { get; }
	[Value("pathname")]
	public USVString Pathname { get; }
	[Value("search")]
	public USVString Search { get; }
	[Value("hash")]
	public USVString Hash { get; }
	[Value("hasRegExpGroups")]
	public bool HasRegExpGroups { get; }
	public URLPattern() { }
}

[Value("URLPatternInit")]
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

[Value("URLPatternOptions")]
public partial class URLPatternOptions
{
	[Value("ignoreCase")]
	public bool IgnoreCase;
}

[Value("URLPatternResult")]
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

[Value("URLPatternComponentResult")]
public partial class URLPatternComponentResult
{
	[Value("input")]
	public USVString Input;
	[Value("groups")]
	public Dictionary<USVString, USVString> Groups;
}


[Value("PerformanceMarkOptions")]
public partial class PerformanceMarkOptions
{
	[Value("detail")]
	public dynamic Detail;
	[Value("startTime")]
	public DOMHighResTimeStamp StartTime;
}

[Value("PerformanceMeasureOptions")]
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

public partial class Performance
{
	[Value("mark")]
	public PerformanceMark Mark(DOMString markName, PerformanceMarkOptions markOptions = default) { throw new System.NotImplementedException(); }
	[Value("clearMarks")]
	public Undefined ClearMarks(DOMString markName = default) { throw new System.NotImplementedException(); }
	[Value("measure")]
	public PerformanceMeasure Measure(DOMString measureName, Union158 startOrMeasureOptions = default, DOMString endMark = default) { throw new System.NotImplementedException(); }
	[Value("clearMeasures")]
	public Undefined ClearMeasures(DOMString measureName = default) { throw new System.NotImplementedException(); }
}

[Value("PerformanceMark")]
public partial class PerformanceMark : PerformanceEntry
{
		public PerformanceMark(DOMString markName, PerformanceMarkOptions markOptions = default) { }
	[Value("detail")]
	public dynamic Detail { get; }
	public PerformanceMark() { }
}

[Value("PerformanceMeasure")]
public partial class PerformanceMeasure : PerformanceEntry
{
	[Value("detail")]
	public dynamic Detail { get; }
}


public partial class Navigator
{
	[Value("vibrate")]
	public bool Vibrate(VibratePattern pattern) { throw new System.NotImplementedException(); }
}

[Value("VideoFrameCallbackMetadata")]
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

public partial class HTMLVideoElement
{
	[Value("requestVideoFrameCallback")]
	public ulong RequestVideoFrameCallback(VideoFrameRequestCallback callback) { throw new System.NotImplementedException(); }
	[Value("cancelVideoFrameCallback")]
	public Undefined CancelVideoFrameCallback(ulong handle) { throw new System.NotImplementedException(); }
}

public partial class Navigator
{
	[Value("virtualKeyboard")]
	public VirtualKeyboard VirtualKeyboard { get; }
}

[Value("VirtualKeyboard")]
public partial class VirtualKeyboard : EventTarget
{
	[Value("show")]
	public Undefined Show() { throw new System.NotImplementedException(); }
	[Value("hide")]
	public Undefined Hide() { throw new System.NotImplementedException(); }
	[Value("boundingRect")]
	public DOMRect BoundingRect { get; }
	[Value("overlaysContent")]
	public bool OverlaysContent { get; set; }
	[Value("ongeometrychange")]
	public EventHandler Ongeometrychange { get; set; }
}

[Value("WebAssemblyInstantiatedSource")]
public partial class WebAssemblyInstantiatedSource
{
	[Value("module")]
	public required Module Module;
	[Value("instance")]
	public required Instance Instance;
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

[Value("ModuleExportDescriptor")]
public partial class ModuleExportDescriptor
{
	[Value("name")]
	public required USVString Name;
	[Value("kind")]
	public required ImportExportKind Kind;
}

[Value("ModuleImportDescriptor")]
public partial class ModuleImportDescriptor
{
	[Value("module")]
	public required USVString Module;
	[Value("name")]
	public required USVString Name;
	[Value("kind")]
	public required ImportExportKind Kind;
}

[Value("Module")]
public partial class Module
{
		public Module(BufferSource bytes) { }
	[Value("exports")]
	public static List<ModuleExportDescriptor> Exports(Module moduleObject) { throw new System.NotImplementedException(); }
	[Value("imports")]
	public static List<ModuleImportDescriptor> Imports(Module moduleObject) { throw new System.NotImplementedException(); }
	[Value("customSections")]
	public static List<ArrayBuffer> CustomSections(Module moduleObject, DOMString sectionName) { throw new System.NotImplementedException(); }
	public Module() { }
}

[Value("Instance")]
public partial class Instance
{
		public Instance(Module module, Object importObject = default) { }
	[Value("exports")]
	public Object Exports { get; }
	public Instance() { }
}

[Value("MemoryDescriptor")]
public partial class MemoryDescriptor
{
	[Value("initial")]
	public required ulong Initial;
	[Value("maximum")]
	public ulong Maximum;
}

[Value("Memory")]
public partial class Memory
{
		public Memory(MemoryDescriptor descriptor) { }
	[Value("grow")]
	public ulong Grow(ulong delta) { throw new System.NotImplementedException(); }
	[Value("toFixedLengthBuffer")]
	public ArrayBuffer ToFixedLengthBuffer() { throw new System.NotImplementedException(); }
	[Value("toResizableBuffer")]
	public ArrayBuffer ToResizableBuffer() { throw new System.NotImplementedException(); }
	[Value("buffer")]
	public ArrayBuffer Buffer { get; }
	public Memory() { }
}

[Value("TableDescriptor")]
public partial class TableDescriptor
{
	[Value("element")]
	public required TableKind Element;
	[Value("initial")]
	public required ulong Initial;
	[Value("maximum")]
	public ulong Maximum;
}

[Value("Table")]
public partial class Table
{
		public Table(TableDescriptor descriptor, dynamic value = default) { }
	[Value("grow")]
	public ulong Grow(ulong delta, dynamic value = default) { throw new System.NotImplementedException(); }
	[Value("get")]
	public dynamic Get(ulong index) { throw new System.NotImplementedException(); }
	[Value("set")]
	public Undefined Set(ulong index, dynamic value = default) { throw new System.NotImplementedException(); }
	[Value("length")]
	public ulong Length { get; }
	public Table() { }
}

[Value("GlobalDescriptor")]
public partial class GlobalDescriptor
{
	[Value("value")]
	public required ValueType Value;
	[Value("mutable")]
	public bool Mutable;
}

[Value("Global")]
public partial class Global
{
		public Global(GlobalDescriptor descriptor, dynamic v = default) { }
	[Value("valueOf")]
	public dynamic ValueOf() { throw new System.NotImplementedException(); }
	[Value("value")]
	public dynamic Value { get; set; }
	public Global() { }
}

public partial class WebAssembly
{
	[Value("compileStreaming")]
	public Task<Module> CompileStreaming(Task<Response> source) { throw new System.NotImplementedException(); }
	[Value("instantiateStreaming")]
	public Task<WebAssemblyInstantiatedSource> InstantiateStreaming(Task<Response> source, Object importObject = default) { throw new System.NotImplementedException(); }
}

[Value("AnimationTimeline")]
public partial class AnimationTimeline
{
	[Value("currentTime")]
	public CSSNumberish? CurrentTime { get; }
	[Value("duration")]
	public CSSNumberish? Duration { get; }
	[Value("play")]
	public Animation Play(AnimationEffect? effect = default) { throw new System.NotImplementedException(); }
}

[Value("Animation")]
public partial class Animation
{
	[Value("startTime")]
	public CSSNumberish? StartTime { get; set; }
	[Value("currentTime")]
	public CSSNumberish? CurrentTime { get; set; }
	[Value("overallProgress")]
	public Number? OverallProgress { get; }
}

[Value("AnimationEffect")]
public partial class AnimationEffect
{
	[Value("parent")]
	public GroupEffect? Parent { get; }
	[Value("previousSibling")]
	public AnimationEffect? PreviousSibling { get; }
	[Value("nextSibling")]
	public AnimationEffect? NextSibling { get; }
	[Value("before")]
	public Undefined Before(params AnimationEffect[] effects) { throw new System.NotImplementedException(); }
	[Value("after")]
	public Undefined After(params AnimationEffect[] effects) { throw new System.NotImplementedException(); }
	[Value("replace")]
	public Undefined Replace(params AnimationEffect[] effects) { throw new System.NotImplementedException(); }
	[Value("remove")]
	public Undefined Remove() { throw new System.NotImplementedException(); }
}

[Value("EffectTiming")]
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

[Value("OptionalEffectTiming")]
public partial class OptionalEffectTiming
{
	[Value("playbackRate")]
	public Number PlaybackRate;
}

[Value("ComputedEffectTiming")]
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

[Value("GroupEffect")]
public partial class GroupEffect
{
		public GroupEffect(List<AnimationEffect>? children, Union161 timing = default) { }
	[Value("children")]
	public AnimationNodeList Children { get; }
	[Value("firstChild")]
	public AnimationEffect? FirstChild { get; }
	[Value("lastChild")]
	public AnimationEffect? LastChild { get; }
	[Value("clone")]
	public GroupEffect Clone() { throw new System.NotImplementedException(); }
	[Value("prepend")]
	public Undefined Prepend(params AnimationEffect[] effects) { throw new System.NotImplementedException(); }
	[Value("append")]
	public Undefined Append(params AnimationEffect[] effects) { throw new System.NotImplementedException(); }
	public GroupEffect() { }
}

[Value("AnimationNodeList")]
public partial class AnimationNodeList
{
	[Value("length")]
	public ulong Length { get; }
	
}

[Value("SequenceEffect")]
public partial class SequenceEffect : GroupEffect
{
		public SequenceEffect(List<AnimationEffect>? children, Union162 timing = default) { }
	[Value("clone")]
	public SequenceEffect Clone() { throw new System.NotImplementedException(); }
	public SequenceEffect() { }
}

[Value("KeyframeEffect")]
public partial class KeyframeEffect
{
	[Value("iterationComposite")]
	public IterationCompositeOperation IterationComposite { get; set; }
}

[Value("KeyframeEffectOptions")]
public partial class KeyframeEffectOptions
{
	[Value("iterationComposite")]
	public IterationCompositeOperation IterationComposite;
}

[Value("TimelineRangeOffset")]
public partial class TimelineRangeOffset
{
	[Value("rangeName")]
	public CSSOMString? RangeName;
	[Value("offset")]
	public CSSNumericValue Offset;
}

[Value("KeyframeAnimationOptions")]
public partial class KeyframeAnimationOptions
{
	[Value("rangeStart")]
	public Union164 RangeStart;
	[Value("rangeEnd")]
	public Union165 RangeEnd;
}

[Value("AnimationPlaybackEvent")]
public partial class AnimationPlaybackEvent : Event
{
		public AnimationPlaybackEvent(DOMString type, AnimationPlaybackEventInit eventInitDict = default) { }
	[Value("currentTime")]
	public CSSNumberish? CurrentTime { get; }
	[Value("timelineTime")]
	public CSSNumberish? TimelineTime { get; }
	public AnimationPlaybackEvent() { }
}

[Value("AnimationPlaybackEventInit")]
public partial class AnimationPlaybackEventInit : EventInit
{
	[Value("currentTime")]
	public CSSNumberish? CurrentTime;
	[Value("timelineTime")]
	public CSSNumberish? TimelineTime;
}

public partial class AnimationTimeline
{
}

[Value("DocumentTimelineOptions")]
public partial class DocumentTimelineOptions
{
	[Value("originTime")]
	public DOMHighResTimeStamp OriginTime;
}

[Value("DocumentTimeline")]
public partial class DocumentTimeline : AnimationTimeline
{
		public DocumentTimeline(DocumentTimelineOptions options = default) { }
	public DocumentTimeline() { }
}

public partial class Animation : EventTarget
{
		public Animation(AnimationEffect? effect = default, AnimationTimeline? timeline = default) { }
	[Value("id")]
	public DOMString Id { get; set; }
	[Value("effect")]
	public AnimationEffect? Effect { get; set; }
	[Value("timeline")]
	public AnimationTimeline? Timeline { get; set; }
	[Value("playbackRate")]
	public Number PlaybackRate { get; set; }
	[Value("playState")]
	public AnimationPlayState PlayState { get; }
	[Value("replaceState")]
	public AnimationReplaceState ReplaceState { get; }
	[Value("pending")]
	public bool Pending { get; }
	[Value("ready")]
	public Task<Animation> Ready { get; }
	[Value("finished")]
	public Task<Animation> Finished { get; }
	[Value("onfinish")]
	public EventHandler Onfinish { get; set; }
	[Value("oncancel")]
	public EventHandler Oncancel { get; set; }
	[Value("onremove")]
	public EventHandler Onremove { get; set; }
	[Value("cancel")]
	public Undefined Cancel() { throw new System.NotImplementedException(); }
	[Value("finish")]
	public Undefined Finish() { throw new System.NotImplementedException(); }
	[Value("play")]
	public Undefined Play() { throw new System.NotImplementedException(); }
	[Value("pause")]
	public Undefined Pause() { throw new System.NotImplementedException(); }
	[Value("updatePlaybackRate")]
	public Undefined UpdatePlaybackRate(Number playbackRate) { throw new System.NotImplementedException(); }
	[Value("reverse")]
	public Undefined Reverse() { throw new System.NotImplementedException(); }
	[Value("persist")]
	public Undefined Persist() { throw new System.NotImplementedException(); }
	[Value("commitStyles")]
	public Undefined CommitStyles() { throw new System.NotImplementedException(); }
	public Animation() { }
}

public partial class AnimationEffect
{
	[Value("getTiming")]
	public EffectTiming GetTiming() { throw new System.NotImplementedException(); }
	[Value("getComputedTiming")]
	public ComputedEffectTiming GetComputedTiming() { throw new System.NotImplementedException(); }
	[Value("updateTiming")]
	public Undefined UpdateTiming(OptionalEffectTiming timing = default) { throw new System.NotImplementedException(); }
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

public partial class KeyframeEffect : AnimationEffect
{
		public KeyframeEffect(Element? target, Object? keyframes, Union167 options = default) { }
		public KeyframeEffect(KeyframeEffect source) { }
	[Value("target")]
	public Element? Target { get; set; }
	[Value("pseudoElement")]
	public CSSOMString? PseudoElement { get; set; }
	[Value("composite")]
	public CompositeOperation Composite { get; set; }
	[Value("getKeyframes")]
	public List<Object> GetKeyframes() { throw new System.NotImplementedException(); }
	[Value("setKeyframes")]
	public Undefined SetKeyframes(Object? keyframes) { throw new System.NotImplementedException(); }
	public KeyframeEffect() { }
}

[Value("BaseComputedKeyframe")]
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

[Value("BasePropertyIndexedKeyframe")]
public partial class BasePropertyIndexedKeyframe
{
	[Value("offset")]
	public Union168 Offset;
	[Value("easing")]
	public Union169 Easing;
	[Value("composite")]
	public Union170 Composite;
}

[Value("BaseKeyframe")]
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

[Value("GetAnimationsOptions")]
public partial class GetAnimationsOptions
{
	[Value("subtree")]
	public bool Subtree;
	[Value("pseudoElement")]
	public CSSOMString? PseudoElement;
}

public partial class Document
{
	[Value("timeline")]
	public DocumentTimeline Timeline { get; }
}

[Value("LaunchParams")]
public partial class LaunchParams
{
	[Value("targetURL")]
	public DOMString? TargetURL { get; }
	[Value("files")]
	public FileSystemHandle[] Files { get; }
}

public partial class Window
{
	[Value("launchQueue")]
	public LaunchQueue LaunchQueue { get; }
}

[Value("LaunchQueue")]
public partial class LaunchQueue
{
	[Value("setConsumer")]
	public Undefined SetConsumer(LaunchConsumer consumer) { throw new System.NotImplementedException(); }
}

[Value("BluetoothLEScanOptions")]
public partial class BluetoothLEScanOptions
{
	[Value("filters")]
	public List<BluetoothLEScanFilterInit> Filters;
	[Value("keepRepeatedDevices")]
	public bool KeepRepeatedDevices;
	[Value("acceptAllAdvertisements")]
	public bool AcceptAllAdvertisements;
}

[Value("Bluetooth")]
public partial class Bluetooth
{
	[Value("requestLEScan")]
	public Task<BluetoothLEScan> RequestLEScan(BluetoothLEScanOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("BluetoothDataFilter")]
public partial class BluetoothDataFilter
{
		public BluetoothDataFilter(BluetoothDataFilterInit init = default) { }
	[Value("dataPrefix")]
	public ArrayBuffer DataPrefix { get; }
	[Value("mask")]
	public ArrayBuffer Mask { get; }
	public BluetoothDataFilter() { }
}

[Value("BluetoothManufacturerDataFilter")]
public partial class BluetoothManufacturerDataFilter
{
		public BluetoothManufacturerDataFilter(Object init = default) { }
	
	public BluetoothManufacturerDataFilter() { }
}

[Value("BluetoothServiceDataFilter")]
public partial class BluetoothServiceDataFilter
{
		public BluetoothServiceDataFilter(Object init = default) { }
	
	public BluetoothServiceDataFilter() { }
}

[Value("BluetoothLEScanFilter")]
public partial class BluetoothLEScanFilter
{
		public BluetoothLEScanFilter(BluetoothLEScanFilterInit init = default) { }
	[Value("name")]
	public DOMString? Name { get; }
	[Value("namePrefix")]
	public DOMString? NamePrefix { get; }
	[Value("services")]
	public UUID[] Services { get; }
	[Value("manufacturerData")]
	public BluetoothManufacturerDataFilter ManufacturerData { get; }
	[Value("serviceData")]
	public BluetoothServiceDataFilter ServiceData { get; }
	public BluetoothLEScanFilter() { }
}

[Value("BluetoothLEScan")]
public partial class BluetoothLEScan
{
	[Value("filters")]
	public BluetoothLEScanFilter[] Filters { get; }
	[Value("keepRepeatedDevices")]
	public bool KeepRepeatedDevices { get; }
	[Value("acceptAllAdvertisements")]
	public bool AcceptAllAdvertisements { get; }
	[Value("active")]
	public bool Active { get; }
	[Value("stop")]
	public Undefined Stop() { throw new System.NotImplementedException(); }
}

[Value("BluetoothLEScanPermissionDescriptor")]
public partial class BluetoothLEScanPermissionDescriptor : PermissionDescriptor
{
	[Value("filters")]
	public List<BluetoothLEScanFilterInit> Filters;
	[Value("keepRepeatedDevices")]
	public bool KeepRepeatedDevices;
	[Value("acceptAllAdvertisements")]
	public bool AcceptAllAdvertisements;
}

[Value("BluetoothLEScanPermissionResult")]
public partial class BluetoothLEScanPermissionResult : PermissionStatus
{
	[Value("scans")]
	public BluetoothLEScan[] Scans { get; set; }
}

[Value("BluetoothDataFilterInit")]
public partial class BluetoothDataFilterInit
{
	[Value("dataPrefix")]
	public BufferSource DataPrefix;
	[Value("mask")]
	public BufferSource Mask;
}

[Value("BluetoothManufacturerDataFilterInit")]
public partial class BluetoothManufacturerDataFilterInit : BluetoothDataFilterInit
{
	[Value("companyIdentifier")]
	public required ushort CompanyIdentifier;
}

[Value("BluetoothServiceDataFilterInit")]
public partial class BluetoothServiceDataFilterInit : BluetoothDataFilterInit
{
	[Value("service")]
	public required BluetoothServiceUUID Service;
}

[Value("BluetoothLEScanFilterInit")]
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

[Value("RequestDeviceOptions")]
public partial class RequestDeviceOptions
{
	[Value("filters")]
	public List<BluetoothLEScanFilterInit> Filters;
	[Value("exclusionFilters")]
	public List<BluetoothLEScanFilterInit> ExclusionFilters;
	[Value("optionalServices")]
	public List<BluetoothServiceUUID> OptionalServices;
	[Value("optionalManufacturerData")]
	public List<ushort> OptionalManufacturerData;
	[Value("acceptAllDevices")]
	public bool AcceptAllDevices;
}

public partial class Bluetooth : EventTarget
{
	[Value("getAvailability")]
	public Task<bool> GetAvailability() { throw new System.NotImplementedException(); }
	[Value("onavailabilitychanged")]
	public EventHandler Onavailabilitychanged { get; set; }
	[Value("referringDevice")]
	public BluetoothDevice? ReferringDevice { get; }
	[Value("getDevices")]
	public Task<List<BluetoothDevice>> GetDevices() { throw new System.NotImplementedException(); }
	[Value("requestDevice")]
	public Task<BluetoothDevice> RequestDevice(RequestDeviceOptions options = default) { throw new System.NotImplementedException(); }
}




[Value("BluetoothPermissionDescriptor")]
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

[Value("AllowedBluetoothDevice")]
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

[Value("BluetoothPermissionStorage")]
public partial class BluetoothPermissionStorage
{
	[Value("allowedDevices")]
	public required List<AllowedBluetoothDevice> AllowedDevices;
}

[Value("BluetoothPermissionResult")]
public partial class BluetoothPermissionResult : PermissionStatus
{
	[Value("devices")]
	public BluetoothDevice[] Devices { get; set; }
}

[Value("ValueEvent")]
public partial class ValueEvent : Event
{
		public ValueEvent(DOMString type, ValueEventInit initDict = default) { }
	[Value("value")]
	public dynamic Value { get; }
	public ValueEvent() { }
}

[Value("ValueEventInit")]
public partial class ValueEventInit : EventInit
{
	[Value("value")]
	public dynamic Value;
}

[Value("BluetoothDevice")]
public partial class BluetoothDevice : EventTarget, BluetoothDeviceEventHandlers, CharacteristicEventHandlers, ServiceEventHandlers
{
	[Value("id")]
	public DOMString Id { get; }
	[Value("name")]
	public DOMString? Name { get; }
	[Value("gatt")]
	public BluetoothRemoteGATTServer? Gatt { get; }
	[Value("forget")]
	public Task<Undefined> Forget() { throw new System.NotImplementedException(); }
	[Value("watchAdvertisements")]
	public Task<Undefined> WatchAdvertisements(WatchAdvertisementsOptions options = default) { throw new System.NotImplementedException(); }
	[Value("watchingAdvertisements")]
	public bool WatchingAdvertisements { get; }
}




[Value("WatchAdvertisementsOptions")]
public partial class WatchAdvertisementsOptions
{
	[Value("signal")]
	public AbortSignal Signal;
}

[Value("BluetoothManufacturerDataMap")]
public partial class BluetoothManufacturerDataMap
{
	
}

[Value("BluetoothServiceDataMap")]
public partial class BluetoothServiceDataMap
{
	
}

[Value("BluetoothAdvertisingEvent")]
public partial class BluetoothAdvertisingEvent : Event
{
		public BluetoothAdvertisingEvent(DOMString type, BluetoothAdvertisingEventInit init) { }
	[Value("device")]
	public BluetoothDevice Device { get; }
	[Value("uuids")]
	public UUID[] Uuids { get; }
	[Value("name")]
	public DOMString? Name { get; }
	[Value("appearance")]
	public ushort? Appearance { get; }
	[Value("txPower")]
	public byte? TxPower { get; }
	[Value("rssi")]
	public byte? Rssi { get; }
	[Value("manufacturerData")]
	public BluetoothManufacturerDataMap ManufacturerData { get; }
	[Value("serviceData")]
	public BluetoothServiceDataMap ServiceData { get; }
	public BluetoothAdvertisingEvent() { }
}

[Value("BluetoothAdvertisingEventInit")]
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

[Value("BluetoothRemoteGATTServer")]
public partial class BluetoothRemoteGATTServer
{
	[Value("device")]
	public BluetoothDevice Device { get; }
	[Value("connected")]
	public bool Connected { get; }
	[Value("connect")]
	public Task<BluetoothRemoteGATTServer> Connect() { throw new System.NotImplementedException(); }
	[Value("disconnect")]
	public Undefined Disconnect() { throw new System.NotImplementedException(); }
	[Value("getPrimaryService")]
	public Task<BluetoothRemoteGATTService> GetPrimaryService(BluetoothServiceUUID service) { throw new System.NotImplementedException(); }
	[Value("getPrimaryServices")]
	public Task<List<BluetoothRemoteGATTService>> GetPrimaryServices(BluetoothServiceUUID service = default) { throw new System.NotImplementedException(); }
}

[Value("BluetoothRemoteGATTService")]
public partial class BluetoothRemoteGATTService : EventTarget, CharacteristicEventHandlers, ServiceEventHandlers
{
	[Value("device")]
	public BluetoothDevice Device { get; }
	[Value("uuid")]
	public UUID Uuid { get; }
	[Value("isPrimary")]
	public bool IsPrimary { get; }
	[Value("getCharacteristic")]
	public Task<BluetoothRemoteGATTCharacteristic> GetCharacteristic(BluetoothCharacteristicUUID characteristic) { throw new System.NotImplementedException(); }
	[Value("getCharacteristics")]
	public Task<List<BluetoothRemoteGATTCharacteristic>> GetCharacteristics(BluetoothCharacteristicUUID characteristic = default) { throw new System.NotImplementedException(); }
	[Value("getIncludedService")]
	public Task<BluetoothRemoteGATTService> GetIncludedService(BluetoothServiceUUID service) { throw new System.NotImplementedException(); }
	[Value("getIncludedServices")]
	public Task<List<BluetoothRemoteGATTService>> GetIncludedServices(BluetoothServiceUUID service = default) { throw new System.NotImplementedException(); }
}



[Value("BluetoothRemoteGATTCharacteristic")]
public partial class BluetoothRemoteGATTCharacteristic : EventTarget, CharacteristicEventHandlers
{
	[Value("service")]
	public BluetoothRemoteGATTService Service { get; }
	[Value("uuid")]
	public UUID Uuid { get; }
	[Value("properties")]
	public BluetoothCharacteristicProperties Properties { get; }
	[Value("value")]
	public DataView? Value { get; }
	[Value("getDescriptor")]
	public Task<BluetoothRemoteGATTDescriptor> GetDescriptor(BluetoothDescriptorUUID descriptor) { throw new System.NotImplementedException(); }
	[Value("getDescriptors")]
	public Task<List<BluetoothRemoteGATTDescriptor>> GetDescriptors(BluetoothDescriptorUUID descriptor = default) { throw new System.NotImplementedException(); }
	[Value("readValue")]
	public Task<DataView> ReadValue() { throw new System.NotImplementedException(); }
	[Value("writeValue")]
	public Task<Undefined> WriteValue(BufferSource value) { throw new System.NotImplementedException(); }
	[Value("writeValueWithResponse")]
	public Task<Undefined> WriteValueWithResponse(BufferSource value) { throw new System.NotImplementedException(); }
	[Value("writeValueWithoutResponse")]
	public Task<Undefined> WriteValueWithoutResponse(BufferSource value) { throw new System.NotImplementedException(); }
	[Value("startNotifications")]
	public Task<BluetoothRemoteGATTCharacteristic> StartNotifications() { throw new System.NotImplementedException(); }
	[Value("stopNotifications")]
	public Task<BluetoothRemoteGATTCharacteristic> StopNotifications() { throw new System.NotImplementedException(); }
}


[Value("BluetoothCharacteristicProperties")]
public partial class BluetoothCharacteristicProperties
{
	[Value("broadcast")]
	public bool Broadcast { get; }
	[Value("read")]
	public bool Read { get; }
	[Value("writeWithoutResponse")]
	public bool WriteWithoutResponse { get; }
	[Value("write")]
	public bool Write { get; }
	[Value("notify")]
	public bool Notify { get; }
	[Value("indicate")]
	public bool Indicate { get; }
	[Value("authenticatedSignedWrites")]
	public bool AuthenticatedSignedWrites { get; }
	[Value("reliableWrite")]
	public bool ReliableWrite { get; }
	[Value("writableAuxiliaries")]
	public bool WritableAuxiliaries { get; }
}

[Value("BluetoothRemoteGATTDescriptor")]
public partial class BluetoothRemoteGATTDescriptor
{
	[Value("characteristic")]
	public BluetoothRemoteGATTCharacteristic Characteristic { get; }
	[Value("uuid")]
	public UUID Uuid { get; }
	[Value("value")]
	public DataView? Value { get; }
	[Value("readValue")]
	public Task<DataView> ReadValue() { throw new System.NotImplementedException(); }
	[Value("writeValue")]
	public Task<Undefined> WriteValue(BufferSource value) { throw new System.NotImplementedException(); }
}

[Value("BluetoothUUID")]
public partial class BluetoothUUID
{
	[Value("getService")]
	public static UUID GetService(Union173 name) { throw new System.NotImplementedException(); }
	[Value("getCharacteristic")]
	public static UUID GetCharacteristic(Union174 name) { throw new System.NotImplementedException(); }
	[Value("getDescriptor")]
	public static UUID GetDescriptor(Union175 name) { throw new System.NotImplementedException(); }
	[Value("canonicalUUID")]
	public static UUID CanonicalUUID(ulong alias) { throw new System.NotImplementedException(); }
}




public partial class Navigator
{
	[Value("bluetooth")]
	public Bluetooth Bluetooth { get; }
}

[Value("LockManager")]
public partial class LockManager
{
	[Value("request")]
	public Task<dynamic> Request(DOMString name, LockGrantedCallback callback) { throw new System.NotImplementedException(); }
	[Value("request")]
	public Task<dynamic> Request(DOMString name, LockOptions options, LockGrantedCallback callback) { throw new System.NotImplementedException(); }
	[Value("query")]
	public Task<LockManagerSnapshot> Query() { throw new System.NotImplementedException(); }
}

[Value("LockOptions")]
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

[Value("LockManagerSnapshot")]
public partial class LockManagerSnapshot
{
	[Value("held")]
	public List<LockInfo> Held;
	[Value("pending")]
	public List<LockInfo> Pending;
}

[Value("LockInfo")]
public partial class LockInfo
{
	[Value("name")]
	public DOMString Name;
	[Value("mode")]
	public LockMode Mode;
	[Value("clientId")]
	public DOMString ClientId;
}

[Value("Lock")]
public partial class Lock
{
	[Value("name")]
	public DOMString Name { get; }
	[Value("mode")]
	public LockMode Mode { get; }
}

[Value("NDEFMessage")]
public partial class NDEFMessage
{
		public NDEFMessage(NDEFMessageInit messageInit) { }
	[Value("records")]
	public NDEFRecord[] Records { get; }
	public NDEFMessage() { }
}

[Value("NDEFMessageInit")]
public partial class NDEFMessageInit
{
	[Value("records")]
	public required List<NDEFRecordInit> Records;
}

[Value("NDEFRecord")]
public partial class NDEFRecord
{
		public NDEFRecord(NDEFRecordInit recordInit) { }
	[Value("recordType")]
	public USVString RecordType { get; }
	[Value("mediaType")]
	public USVString? MediaType { get; }
	[Value("id")]
	public USVString? Id { get; }
	[Value("data")]
	public DataView? Data { get; }
	[Value("encoding")]
	public USVString? Encoding { get; }
	[Value("lang")]
	public USVString? Lang { get; }
	[Value("toRecords")]
	public List<NDEFRecord>? ToRecords() { throw new System.NotImplementedException(); }
	public NDEFRecord() { }
}

[Value("NDEFRecordInit")]
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


[Value("NDEFReader")]
public partial class NDEFReader : EventTarget
{
		public NDEFReader() { }
	[Value("onreading")]
	public EventHandler Onreading { get; set; }
	[Value("onreadingerror")]
	public EventHandler Onreadingerror { get; set; }
	[Value("scan")]
	public Task<Undefined> Scan(NDEFScanOptions options = default) { throw new System.NotImplementedException(); }
	[Value("write")]
	public Task<Undefined> Write(NDEFMessageSource message, NDEFWriteOptions options = default) { throw new System.NotImplementedException(); }
	[Value("makeReadOnly")]
	public Task<Undefined> MakeReadOnly(NDEFMakeReadOnlyOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("NDEFReadingEvent")]
public partial class NDEFReadingEvent : Event
{
		public NDEFReadingEvent(DOMString type, NDEFReadingEventInit readingEventInitDict) { }
	[Value("serialNumber")]
	public DOMString SerialNumber { get; }
	[Value("message")]
	public NDEFMessage Message { get; }
	public NDEFReadingEvent() { }
}

[Value("NDEFReadingEventInit")]
public partial class NDEFReadingEventInit : EventInit
{
	[Value("serialNumber")]
	public DOMString? SerialNumber;
	[Value("message")]
	public required NDEFMessageInit Message;
}

[Value("NDEFWriteOptions")]
public partial class NDEFWriteOptions
{
	[Value("overwrite")]
	public bool Overwrite;
	[Value("signal")]
	public AbortSignal? Signal;
}

[Value("NDEFMakeReadOnlyOptions")]
public partial class NDEFMakeReadOnlyOptions
{
	[Value("signal")]
	public AbortSignal? Signal;
}

[Value("NDEFScanOptions")]
public partial class NDEFScanOptions
{
	[Value("signal")]
	public AbortSignal Signal;
}

[Value("OTPCredential")]
public partial class OTPCredential : Credential
{
	[Value("code")]
	public DOMString Code { get; }
}

public partial class CredentialRequestOptions
{
	[Value("otp")]
	public OTPCredentialRequestOptions Otp;
}

[Value("OTPCredentialRequestOptions")]
public partial class OTPCredentialRequestOptions
{
	[Value("transport")]
	public List<OTPCredentialTransportType> Transport;
}

public partial class Navigator
{
	[Value("share")]
	public Task<Undefined> Share(ShareData data = default) { throw new System.NotImplementedException(); }
	[Value("canShare")]
	public bool CanShare(ShareData data = default) { throw new System.NotImplementedException(); }
}

[Value("ShareData")]
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

[Value("BaseAudioContext")]
public partial class BaseAudioContext : EventTarget
{
	[Value("destination")]
	public AudioDestinationNode Destination { get; }
	[Value("sampleRate")]
	public Number SampleRate { get; }
	[Value("currentTime")]
	public Number CurrentTime { get; }
	[Value("listener")]
	public AudioListener Listener { get; }
	[Value("state")]
	public AudioContextState State { get; }
	[Value("renderQuantumSize")]
	public ulong RenderQuantumSize { get; }
	[Value("audioWorklet")]
	public AudioWorklet AudioWorklet { get; }
	[Value("onstatechange")]
	public EventHandler Onstatechange { get; set; }
	[Value("createAnalyser")]
	public AnalyserNode CreateAnalyser() { throw new System.NotImplementedException(); }
	[Value("createBiquadFilter")]
	public BiquadFilterNode CreateBiquadFilter() { throw new System.NotImplementedException(); }
	[Value("createBuffer")]
	public AudioBuffer CreateBuffer(ulong numberOfChannels, ulong length, Number sampleRate) { throw new System.NotImplementedException(); }
	[Value("createBufferSource")]
	public AudioBufferSourceNode CreateBufferSource() { throw new System.NotImplementedException(); }
	[Value("createChannelMerger")]
	public ChannelMergerNode CreateChannelMerger(ulong numberOfInputs = default) { throw new System.NotImplementedException(); }
	[Value("createChannelSplitter")]
	public ChannelSplitterNode CreateChannelSplitter(ulong numberOfOutputs = default) { throw new System.NotImplementedException(); }
	[Value("createConstantSource")]
	public ConstantSourceNode CreateConstantSource() { throw new System.NotImplementedException(); }
	[Value("createConvolver")]
	public ConvolverNode CreateConvolver() { throw new System.NotImplementedException(); }
	[Value("createDelay")]
	public DelayNode CreateDelay(Number maxDelayTime = default) { throw new System.NotImplementedException(); }
	[Value("createDynamicsCompressor")]
	public DynamicsCompressorNode CreateDynamicsCompressor() { throw new System.NotImplementedException(); }
	[Value("createGain")]
	public GainNode CreateGain() { throw new System.NotImplementedException(); }
	[Value("createIIRFilter")]
	public IIRFilterNode CreateIIRFilter(List<Number> feedforward, List<Number> feedback) { throw new System.NotImplementedException(); }
	[Value("createOscillator")]
	public OscillatorNode CreateOscillator() { throw new System.NotImplementedException(); }
	[Value("createPanner")]
	public PannerNode CreatePanner() { throw new System.NotImplementedException(); }
	[Value("createPeriodicWave")]
	public PeriodicWave CreatePeriodicWave(List<Number> real, List<Number> imag, PeriodicWaveConstraints constraints = default) { throw new System.NotImplementedException(); }
	[Value("createScriptProcessor")]
	public ScriptProcessorNode CreateScriptProcessor(ulong bufferSize = default, ulong numberOfInputChannels = default, ulong numberOfOutputChannels = default) { throw new System.NotImplementedException(); }
	[Value("createStereoPanner")]
	public StereoPannerNode CreateStereoPanner() { throw new System.NotImplementedException(); }
	[Value("createWaveShaper")]
	public WaveShaperNode CreateWaveShaper() { throw new System.NotImplementedException(); }
	[Value("decodeAudioData")]
	public Task<AudioBuffer> DecodeAudioData(ArrayBuffer audioData, DecodeSuccessCallback? successCallback = default, DecodeErrorCallback? errorCallback = default) { throw new System.NotImplementedException(); }
}

[Value("AudioContext")]
public partial class AudioContext : BaseAudioContext
{
		public AudioContext(AudioContextOptions contextOptions = default) { }
	[Value("baseLatency")]
	public Number BaseLatency { get; }
	[Value("outputLatency")]
	public Number OutputLatency { get; }
	[Value("sinkId")]
	public Union180 SinkId { get; }
	[Value("renderCapacity")]
	public AudioRenderCapacity RenderCapacity { get; }
	[Value("onsinkchange")]
	public EventHandler Onsinkchange { get; set; }
	[Value("onerror")]
	public EventHandler Onerror { get; set; }
	[Value("getOutputTimestamp")]
	public AudioTimestamp GetOutputTimestamp() { throw new System.NotImplementedException(); }
	[Value("resume")]
	public Task<Undefined> Resume() { throw new System.NotImplementedException(); }
	[Value("suspend")]
	public Task<Undefined> Suspend() { throw new System.NotImplementedException(); }
	[Value("close")]
	public Task<Undefined> Close() { throw new System.NotImplementedException(); }
	[Value("setSinkId")]
	public Task<Undefined> SetSinkId(Union181 sinkId) { throw new System.NotImplementedException(); }
	[Value("createMediaElementSource")]
	public MediaElementAudioSourceNode CreateMediaElementSource(HTMLMediaElement mediaElement) { throw new System.NotImplementedException(); }
	[Value("createMediaStreamSource")]
	public MediaStreamAudioSourceNode CreateMediaStreamSource(MediaStream mediaStream) { throw new System.NotImplementedException(); }
	[Value("createMediaStreamTrackSource")]
	public MediaStreamTrackAudioSourceNode CreateMediaStreamTrackSource(MediaStreamTrack mediaStreamTrack) { throw new System.NotImplementedException(); }
	[Value("createMediaStreamDestination")]
	public MediaStreamAudioDestinationNode CreateMediaStreamDestination() { throw new System.NotImplementedException(); }
	public AudioContext() { }
}

[Value("AudioContextOptions")]
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

[Value("AudioSinkOptions")]
public partial class AudioSinkOptions
{
	[Value("type")]
	public required AudioSinkType Type;
}

[Value("AudioSinkInfo")]
public partial class AudioSinkInfo
{
	[Value("type")]
	public AudioSinkType Type { get; }
}

[Value("AudioTimestamp")]
public partial class AudioTimestamp
{
	[Value("contextTime")]
	public Number ContextTime;
	[Value("performanceTime")]
	public DOMHighResTimeStamp PerformanceTime;
}

[Value("AudioRenderCapacity")]
public partial class AudioRenderCapacity : EventTarget
{
	[Value("start")]
	public Undefined Start(AudioRenderCapacityOptions options = default) { throw new System.NotImplementedException(); }
	[Value("stop")]
	public Undefined Stop() { throw new System.NotImplementedException(); }
	[Value("onupdate")]
	public EventHandler Onupdate { get; set; }
}

[Value("AudioRenderCapacityOptions")]
public partial class AudioRenderCapacityOptions
{
	[Value("updateInterval")]
	public Number UpdateInterval;
}

[Value("AudioRenderCapacityEvent")]
public partial class AudioRenderCapacityEvent : Event
{
		public AudioRenderCapacityEvent(DOMString type, AudioRenderCapacityEventInit eventInitDict = default) { }
	[Value("timestamp")]
	public Number Timestamp { get; }
	[Value("averageLoad")]
	public Number AverageLoad { get; }
	[Value("peakLoad")]
	public Number PeakLoad { get; }
	[Value("underrunRatio")]
	public Number UnderrunRatio { get; }
	public AudioRenderCapacityEvent() { }
}

[Value("AudioRenderCapacityEventInit")]
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

[Value("OfflineAudioContext")]
public partial class OfflineAudioContext : BaseAudioContext
{
		public OfflineAudioContext(OfflineAudioContextOptions contextOptions) { }
		public OfflineAudioContext(ulong numberOfChannels, ulong length, Number sampleRate) { }
	[Value("startRendering")]
	public Task<AudioBuffer> StartRendering() { throw new System.NotImplementedException(); }
	[Value("resume")]
	public Task<Undefined> Resume() { throw new System.NotImplementedException(); }
	[Value("suspend")]
	public Task<Undefined> Suspend(Number suspendTime) { throw new System.NotImplementedException(); }
	[Value("length")]
	public ulong Length { get; }
	[Value("oncomplete")]
	public EventHandler Oncomplete { get; set; }
	public OfflineAudioContext() { }
}

[Value("OfflineAudioContextOptions")]
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

[Value("OfflineAudioCompletionEvent")]
public partial class OfflineAudioCompletionEvent : Event
{
		public OfflineAudioCompletionEvent(DOMString type, OfflineAudioCompletionEventInit eventInitDict) { }
	[Value("renderedBuffer")]
	public AudioBuffer RenderedBuffer { get; }
	public OfflineAudioCompletionEvent() { }
}

[Value("OfflineAudioCompletionEventInit")]
public partial class OfflineAudioCompletionEventInit : EventInit
{
	[Value("renderedBuffer")]
	public required AudioBuffer RenderedBuffer;
}

[Value("AudioBuffer")]
public partial class AudioBuffer
{
		public AudioBuffer(AudioBufferOptions options) { }
	[Value("sampleRate")]
	public Number SampleRate { get; }
	[Value("length")]
	public ulong Length { get; }
	[Value("duration")]
	public Number Duration { get; }
	[Value("numberOfChannels")]
	public ulong NumberOfChannels { get; }
	[Value("getChannelData")]
	public Float32Array GetChannelData(ulong channel) { throw new System.NotImplementedException(); }
	[Value("copyFromChannel")]
	public Undefined CopyFromChannel(Float32Array destination, ulong channelNumber, ulong bufferOffset = default) { throw new System.NotImplementedException(); }
	[Value("copyToChannel")]
	public Undefined CopyToChannel(Float32Array source, ulong channelNumber, ulong bufferOffset = default) { throw new System.NotImplementedException(); }
	public AudioBuffer() { }
}

[Value("AudioBufferOptions")]
public partial class AudioBufferOptions
{
	[Value("numberOfChannels")]
	public ulong NumberOfChannels;
	[Value("length")]
	public required ulong Length;
	[Value("sampleRate")]
	public required Number SampleRate;
}

[Value("AudioNode")]
public partial class AudioNode : EventTarget
{
	[Value("connect")]
	public AudioNode Connect(AudioNode destinationNode, ulong output = default, ulong input = default) { throw new System.NotImplementedException(); }
	[Value("connect")]
	public Undefined Connect(AudioParam destinationParam, ulong output = default) { throw new System.NotImplementedException(); }
	[Value("disconnect")]
	public Undefined Disconnect() { throw new System.NotImplementedException(); }
	[Value("disconnect")]
	public Undefined Disconnect(ulong output) { throw new System.NotImplementedException(); }
	[Value("disconnect")]
	public Undefined Disconnect(AudioNode destinationNode) { throw new System.NotImplementedException(); }
	[Value("disconnect")]
	public Undefined Disconnect(AudioNode destinationNode, ulong output) { throw new System.NotImplementedException(); }
	[Value("disconnect")]
	public Undefined Disconnect(AudioNode destinationNode, ulong output, ulong input) { throw new System.NotImplementedException(); }
	[Value("disconnect")]
	public Undefined Disconnect(AudioParam destinationParam) { throw new System.NotImplementedException(); }
	[Value("disconnect")]
	public Undefined Disconnect(AudioParam destinationParam, ulong output) { throw new System.NotImplementedException(); }
	[Value("context")]
	public BaseAudioContext Context { get; }
	[Value("numberOfInputs")]
	public ulong NumberOfInputs { get; }
	[Value("numberOfOutputs")]
	public ulong NumberOfOutputs { get; }
	[Value("channelCount")]
	public ulong ChannelCount { get; set; }
	[Value("channelCountMode")]
	public ChannelCountMode ChannelCountMode { get; set; }
	[Value("channelInterpretation")]
	public ChannelInterpretation ChannelInterpretation { get; set; }
}

[Value("AudioNodeOptions")]
public partial class AudioNodeOptions
{
	[Value("channelCount")]
	public ulong ChannelCount;
	[Value("channelCountMode")]
	public ChannelCountMode ChannelCountMode;
	[Value("channelInterpretation")]
	public ChannelInterpretation ChannelInterpretation;
}

[Value("AudioParam")]
public partial class AudioParam
{
	[Value("value")]
	public Number Value { get; set; }
	[Value("automationRate")]
	public AutomationRate AutomationRate { get; set; }
	[Value("defaultValue")]
	public Number DefaultValue { get; }
	[Value("minValue")]
	public Number MinValue { get; }
	[Value("maxValue")]
	public Number MaxValue { get; }
	[Value("setValueAtTime")]
	public AudioParam SetValueAtTime(Number value, Number startTime) { throw new System.NotImplementedException(); }
	[Value("linearRampToValueAtTime")]
	public AudioParam LinearRampToValueAtTime(Number value, Number endTime) { throw new System.NotImplementedException(); }
	[Value("exponentialRampToValueAtTime")]
	public AudioParam ExponentialRampToValueAtTime(Number value, Number endTime) { throw new System.NotImplementedException(); }
	[Value("setTargetAtTime")]
	public AudioParam SetTargetAtTime(Number target, Number startTime, Number timeConstant) { throw new System.NotImplementedException(); }
	[Value("setValueCurveAtTime")]
	public AudioParam SetValueCurveAtTime(List<Number> values, Number startTime, Number duration) { throw new System.NotImplementedException(); }
	[Value("cancelScheduledValues")]
	public AudioParam CancelScheduledValues(Number cancelTime) { throw new System.NotImplementedException(); }
	[Value("cancelAndHoldAtTime")]
	public AudioParam CancelAndHoldAtTime(Number cancelTime) { throw new System.NotImplementedException(); }
}

[Value("AudioScheduledSourceNode")]
public partial class AudioScheduledSourceNode : AudioNode
{
	[Value("onended")]
	public EventHandler Onended { get; set; }
	[Value("start")]
	public Undefined Start(Number when = default) { throw new System.NotImplementedException(); }
	[Value("stop")]
	public Undefined Stop(Number when = default) { throw new System.NotImplementedException(); }
}

[Value("AnalyserNode")]
public partial class AnalyserNode : AudioNode
{
		public AnalyserNode(BaseAudioContext context, AnalyserOptions options = default) { }
	[Value("getFloatFrequencyData")]
	public Undefined GetFloatFrequencyData(Float32Array array) { throw new System.NotImplementedException(); }
	[Value("getByteFrequencyData")]
	public Undefined GetByteFrequencyData(Uint8Array array) { throw new System.NotImplementedException(); }
	[Value("getFloatTimeDomainData")]
	public Undefined GetFloatTimeDomainData(Float32Array array) { throw new System.NotImplementedException(); }
	[Value("getByteTimeDomainData")]
	public Undefined GetByteTimeDomainData(Uint8Array array) { throw new System.NotImplementedException(); }
	[Value("fftSize")]
	public ulong FftSize { get; set; }
	[Value("frequencyBinCount")]
	public ulong FrequencyBinCount { get; }
	[Value("minDecibels")]
	public Number MinDecibels { get; set; }
	[Value("maxDecibels")]
	public Number MaxDecibels { get; set; }
	[Value("smoothingTimeConstant")]
	public Number SmoothingTimeConstant { get; set; }
	public AnalyserNode() { }
}

[Value("AnalyserOptions")]
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

[Value("AudioBufferSourceNode")]
public partial class AudioBufferSourceNode : AudioScheduledSourceNode
{
		public AudioBufferSourceNode(BaseAudioContext context, AudioBufferSourceOptions options = default) { }
	[Value("buffer")]
	public AudioBuffer? Buffer { get; set; }
	[Value("playbackRate")]
	public AudioParam PlaybackRate { get; }
	[Value("detune")]
	public AudioParam Detune { get; }
	[Value("loop")]
	public bool Loop { get; set; }
	[Value("loopStart")]
	public Number LoopStart { get; set; }
	[Value("loopEnd")]
	public Number LoopEnd { get; set; }
	[Value("start")]
	public Undefined Start(Number when = default, Number offset = default, Number duration = default) { throw new System.NotImplementedException(); }
	public AudioBufferSourceNode() { }
}

[Value("AudioBufferSourceOptions")]
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

[Value("AudioDestinationNode")]
public partial class AudioDestinationNode : AudioNode
{
	[Value("maxChannelCount")]
	public ulong MaxChannelCount { get; }
}

[Value("AudioListener")]
public partial class AudioListener
{
	[Value("positionX")]
	public AudioParam PositionX { get; }
	[Value("positionY")]
	public AudioParam PositionY { get; }
	[Value("positionZ")]
	public AudioParam PositionZ { get; }
	[Value("forwardX")]
	public AudioParam ForwardX { get; }
	[Value("forwardY")]
	public AudioParam ForwardY { get; }
	[Value("forwardZ")]
	public AudioParam ForwardZ { get; }
	[Value("upX")]
	public AudioParam UpX { get; }
	[Value("upY")]
	public AudioParam UpY { get; }
	[Value("upZ")]
	public AudioParam UpZ { get; }
	[Value("setPosition")]
	public Undefined SetPosition(Number x, Number y, Number z) { throw new System.NotImplementedException(); }
	[Value("setOrientation")]
	public Undefined SetOrientation(Number x, Number y, Number z, Number xUp, Number yUp, Number zUp) { throw new System.NotImplementedException(); }
}

[Value("AudioProcessingEvent")]
public partial class AudioProcessingEvent : Event
{
		public AudioProcessingEvent(DOMString type, AudioProcessingEventInit eventInitDict) { }
	[Value("playbackTime")]
	public Number PlaybackTime { get; }
	[Value("inputBuffer")]
	public AudioBuffer InputBuffer { get; }
	[Value("outputBuffer")]
	public AudioBuffer OutputBuffer { get; }
	public AudioProcessingEvent() { }
}

[Value("AudioProcessingEventInit")]
public partial class AudioProcessingEventInit : EventInit
{
	[Value("playbackTime")]
	public required Number PlaybackTime;
	[Value("inputBuffer")]
	public required AudioBuffer InputBuffer;
	[Value("outputBuffer")]
	public required AudioBuffer OutputBuffer;
}

[Value("BiquadFilterNode")]
public partial class BiquadFilterNode : AudioNode
{
		public BiquadFilterNode(BaseAudioContext context, BiquadFilterOptions options = default) { }
	[Value("type")]
	public BiquadFilterType Type { get; set; }
	[Value("frequency")]
	public AudioParam Frequency { get; }
	[Value("detune")]
	public AudioParam Detune { get; }
	[Value("Q")]
	public AudioParam Q { get; }
	[Value("gain")]
	public AudioParam Gain { get; }
	[Value("getFrequencyResponse")]
	public Undefined GetFrequencyResponse(Float32Array frequencyHz, Float32Array magResponse, Float32Array phaseResponse) { throw new System.NotImplementedException(); }
	public BiquadFilterNode() { }
}

[Value("BiquadFilterOptions")]
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

[Value("ChannelMergerNode")]
public partial class ChannelMergerNode : AudioNode
{
		public ChannelMergerNode(BaseAudioContext context, ChannelMergerOptions options = default) { }
	public ChannelMergerNode() { }
}

[Value("ChannelMergerOptions")]
public partial class ChannelMergerOptions : AudioNodeOptions
{
	[Value("numberOfInputs")]
	public ulong NumberOfInputs;
}

[Value("ChannelSplitterNode")]
public partial class ChannelSplitterNode : AudioNode
{
		public ChannelSplitterNode(BaseAudioContext context, ChannelSplitterOptions options = default) { }
	public ChannelSplitterNode() { }
}

[Value("ChannelSplitterOptions")]
public partial class ChannelSplitterOptions : AudioNodeOptions
{
	[Value("numberOfOutputs")]
	public ulong NumberOfOutputs;
}

[Value("ConstantSourceNode")]
public partial class ConstantSourceNode : AudioScheduledSourceNode
{
		public ConstantSourceNode(BaseAudioContext context, ConstantSourceOptions options = default) { }
	[Value("offset")]
	public AudioParam Offset { get; }
	public ConstantSourceNode() { }
}

[Value("ConstantSourceOptions")]
public partial class ConstantSourceOptions
{
	[Value("offset")]
	public Number Offset;
}

[Value("ConvolverNode")]
public partial class ConvolverNode : AudioNode
{
		public ConvolverNode(BaseAudioContext context, ConvolverOptions options = default) { }
	[Value("buffer")]
	public AudioBuffer? Buffer { get; set; }
	[Value("normalize")]
	public bool Normalize { get; set; }
	public ConvolverNode() { }
}

[Value("ConvolverOptions")]
public partial class ConvolverOptions : AudioNodeOptions
{
	[Value("buffer")]
	public AudioBuffer? Buffer;
	[Value("disableNormalization")]
	public bool DisableNormalization;
}

[Value("DelayNode")]
public partial class DelayNode : AudioNode
{
		public DelayNode(BaseAudioContext context, DelayOptions options = default) { }
	[Value("delayTime")]
	public AudioParam DelayTime { get; }
	public DelayNode() { }
}

[Value("DelayOptions")]
public partial class DelayOptions : AudioNodeOptions
{
	[Value("maxDelayTime")]
	public Number MaxDelayTime;
	[Value("delayTime")]
	public Number DelayTime;
}

[Value("DynamicsCompressorNode")]
public partial class DynamicsCompressorNode : AudioNode
{
		public DynamicsCompressorNode(BaseAudioContext context, DynamicsCompressorOptions options = default) { }
	[Value("threshold")]
	public AudioParam Threshold { get; }
	[Value("knee")]
	public AudioParam Knee { get; }
	[Value("ratio")]
	public AudioParam Ratio { get; }
	[Value("reduction")]
	public Number Reduction { get; }
	[Value("attack")]
	public AudioParam Attack { get; }
	[Value("release")]
	public AudioParam Release { get; }
	public DynamicsCompressorNode() { }
}

[Value("DynamicsCompressorOptions")]
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

[Value("GainNode")]
public partial class GainNode : AudioNode
{
		public GainNode(BaseAudioContext context, GainOptions options = default) { }
	[Value("gain")]
	public AudioParam Gain { get; }
	public GainNode() { }
}

[Value("GainOptions")]
public partial class GainOptions : AudioNodeOptions
{
	[Value("gain")]
	public Number Gain;
}

[Value("IIRFilterNode")]
public partial class IIRFilterNode : AudioNode
{
		public IIRFilterNode(BaseAudioContext context, IIRFilterOptions options) { }
	[Value("getFrequencyResponse")]
	public Undefined GetFrequencyResponse(Float32Array frequencyHz, Float32Array magResponse, Float32Array phaseResponse) { throw new System.NotImplementedException(); }
	public IIRFilterNode() { }
}

[Value("IIRFilterOptions")]
public partial class IIRFilterOptions : AudioNodeOptions
{
	[Value("feedforward")]
	public required List<Number> Feedforward;
	[Value("feedback")]
	public required List<Number> Feedback;
}

[Value("MediaElementAudioSourceNode")]
public partial class MediaElementAudioSourceNode : AudioNode
{
		public MediaElementAudioSourceNode(AudioContext context, MediaElementAudioSourceOptions options) { }
	[Value("mediaElement")]
	public HTMLMediaElement MediaElement { get; }
	public MediaElementAudioSourceNode() { }
}

[Value("MediaElementAudioSourceOptions")]
public partial class MediaElementAudioSourceOptions
{
	[Value("mediaElement")]
	public required HTMLMediaElement MediaElement;
}

[Value("MediaStreamAudioDestinationNode")]
public partial class MediaStreamAudioDestinationNode : AudioNode
{
		public MediaStreamAudioDestinationNode(AudioContext context, AudioNodeOptions options = default) { }
	[Value("stream")]
	public MediaStream Stream { get; }
	public MediaStreamAudioDestinationNode() { }
}

[Value("MediaStreamAudioSourceNode")]
public partial class MediaStreamAudioSourceNode : AudioNode
{
		public MediaStreamAudioSourceNode(AudioContext context, MediaStreamAudioSourceOptions options) { }
	[Value("mediaStream")]
	public MediaStream MediaStream { get; }
	public MediaStreamAudioSourceNode() { }
}

[Value("MediaStreamAudioSourceOptions")]
public partial class MediaStreamAudioSourceOptions
{
	[Value("mediaStream")]
	public required MediaStream MediaStream;
}

[Value("MediaStreamTrackAudioSourceNode")]
public partial class MediaStreamTrackAudioSourceNode : AudioNode
{
		public MediaStreamTrackAudioSourceNode(AudioContext context, MediaStreamTrackAudioSourceOptions options) { }
	public MediaStreamTrackAudioSourceNode() { }
}

[Value("MediaStreamTrackAudioSourceOptions")]
public partial class MediaStreamTrackAudioSourceOptions
{
	[Value("mediaStreamTrack")]
	public required MediaStreamTrack MediaStreamTrack;
}

[Value("OscillatorNode")]
public partial class OscillatorNode : AudioScheduledSourceNode
{
		public OscillatorNode(BaseAudioContext context, OscillatorOptions options = default) { }
	[Value("type")]
	public OscillatorType Type { get; set; }
	[Value("frequency")]
	public AudioParam Frequency { get; }
	[Value("detune")]
	public AudioParam Detune { get; }
	[Value("setPeriodicWave")]
	public Undefined SetPeriodicWave(PeriodicWave periodicWave) { throw new System.NotImplementedException(); }
	public OscillatorNode() { }
}

[Value("OscillatorOptions")]
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

[Value("PannerNode")]
public partial class PannerNode : AudioNode
{
		public PannerNode(BaseAudioContext context, PannerOptions options = default) { }
	[Value("panningModel")]
	public PanningModelType PanningModel { get; set; }
	[Value("positionX")]
	public AudioParam PositionX { get; }
	[Value("positionY")]
	public AudioParam PositionY { get; }
	[Value("positionZ")]
	public AudioParam PositionZ { get; }
	[Value("orientationX")]
	public AudioParam OrientationX { get; }
	[Value("orientationY")]
	public AudioParam OrientationY { get; }
	[Value("orientationZ")]
	public AudioParam OrientationZ { get; }
	[Value("distanceModel")]
	public DistanceModelType DistanceModel { get; set; }
	[Value("refDistance")]
	public Number RefDistance { get; set; }
	[Value("maxDistance")]
	public Number MaxDistance { get; set; }
	[Value("rolloffFactor")]
	public Number RolloffFactor { get; set; }
	[Value("coneInnerAngle")]
	public Number ConeInnerAngle { get; set; }
	[Value("coneOuterAngle")]
	public Number ConeOuterAngle { get; set; }
	[Value("coneOuterGain")]
	public Number ConeOuterGain { get; set; }
	[Value("setPosition")]
	public Undefined SetPosition(Number x, Number y, Number z) { throw new System.NotImplementedException(); }
	[Value("setOrientation")]
	public Undefined SetOrientation(Number x, Number y, Number z) { throw new System.NotImplementedException(); }
	public PannerNode() { }
}

[Value("PannerOptions")]
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

[Value("PeriodicWave")]
public partial class PeriodicWave
{
		public PeriodicWave(BaseAudioContext context, PeriodicWaveOptions options = default) { }
	public PeriodicWave() { }
}

[Value("PeriodicWaveConstraints")]
public partial class PeriodicWaveConstraints
{
	[Value("disableNormalization")]
	public bool DisableNormalization;
}

[Value("PeriodicWaveOptions")]
public partial class PeriodicWaveOptions : PeriodicWaveConstraints
{
	[Value("real")]
	public List<Number> Real;
	[Value("imag")]
	public List<Number> Imag;
}

[Value("ScriptProcessorNode")]
public partial class ScriptProcessorNode : AudioNode
{
	[Value("onaudioprocess")]
	public EventHandler Onaudioprocess { get; set; }
	[Value("bufferSize")]
	public long BufferSize { get; }
}

[Value("StereoPannerNode")]
public partial class StereoPannerNode : AudioNode
{
		public StereoPannerNode(BaseAudioContext context, StereoPannerOptions options = default) { }
	[Value("pan")]
	public AudioParam Pan { get; }
	public StereoPannerNode() { }
}

[Value("StereoPannerOptions")]
public partial class StereoPannerOptions : AudioNodeOptions
{
	[Value("pan")]
	public Number Pan;
}

[Value("WaveShaperNode")]
public partial class WaveShaperNode : AudioNode
{
		public WaveShaperNode(BaseAudioContext context, WaveShaperOptions options = default) { }
	[Value("curve")]
	public Float32Array? Curve { get; set; }
	[Value("oversample")]
	public OverSampleType Oversample { get; set; }
	public WaveShaperNode() { }
}

[Value("WaveShaperOptions")]
public partial class WaveShaperOptions : AudioNodeOptions
{
	[Value("curve")]
	public List<Number> Curve;
	[Value("oversample")]
	public OverSampleType Oversample;
}

[Value("AudioWorklet")]
public partial class AudioWorklet : Worklet
{
	[Value("port")]
	public MessagePort Port { get; }
}

[Value("AudioWorkletGlobalScope")]
public partial class AudioWorkletGlobalScope : WorkletGlobalScope
{
	[Value("registerProcessor")]
	public Undefined RegisterProcessor(DOMString name, AudioWorkletProcessorConstructor processorCtor) { throw new System.NotImplementedException(); }
	[Value("currentFrame")]
	public ulong CurrentFrame { get; }
	[Value("currentTime")]
	public Number CurrentTime { get; }
	[Value("sampleRate")]
	public Number SampleRate { get; }
	[Value("renderQuantumSize")]
	public ulong RenderQuantumSize { get; }
	[Value("port")]
	public MessagePort Port { get; }
}

[Value("AudioParamMap")]
public partial class AudioParamMap
{
	
}

[Value("AudioWorkletNode")]
public partial class AudioWorkletNode : AudioNode
{
		public AudioWorkletNode(BaseAudioContext context, DOMString name, AudioWorkletNodeOptions options = default) { }
	[Value("parameters")]
	public AudioParamMap Parameters { get; }
	[Value("port")]
	public MessagePort Port { get; }
	[Value("onprocessorerror")]
	public EventHandler Onprocessorerror { get; set; }
	public AudioWorkletNode() { }
}

[Value("AudioWorkletNodeOptions")]
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

[Value("AudioWorkletProcessor")]
public partial class AudioWorkletProcessor
{
		public AudioWorkletProcessor() { }
	[Value("port")]
	public MessagePort Port { get; }
}

[Value("AudioParamDescriptor")]
public partial class AudioParamDescriptor
{
	[Value("name")]
	public required DOMString Name;
	[Value("defaultValue")]
	public Number DefaultValue;
	[Value("minValue")]
	public Number MinValue;
	[Value("maxValue")]
	public Number MaxValue;
	[Value("automationRate")]
	public AutomationRate AutomationRate;
}

[Value("PublicKeyCredential")]
public partial class PublicKeyCredential : Credential
{
	[Value("rawId")]
	public ArrayBuffer RawId { get; }
	[Value("response")]
	public AuthenticatorResponse Response { get; }
	[Value("authenticatorAttachment")]
	public DOMString? AuthenticatorAttachment { get; }
	[Value("getClientExtensionResults")]
	public AuthenticationExtensionsClientOutputs GetClientExtensionResults() { throw new System.NotImplementedException(); }
	[Value("isConditionalMediationAvailable")]
	public static Task<bool> IsConditionalMediationAvailable() { throw new System.NotImplementedException(); }
	[Value("toJSON")]
	public PublicKeyCredentialJSON ToJSON() { throw new System.NotImplementedException(); }
}



[Value("RegistrationResponseJSON")]
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

[Value("AuthenticatorAttestationResponseJSON")]
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

[Value("AuthenticationResponseJSON")]
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

[Value("AuthenticatorAssertionResponseJSON")]
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

[Value("AuthenticationExtensionsClientOutputsJSON")]
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

public partial class PublicKeyCredential
{
	[Value("isUserVerifyingPlatformAuthenticatorAvailable")]
	public static Task<bool> IsUserVerifyingPlatformAuthenticatorAvailable() { throw new System.NotImplementedException(); }
}

public partial class PublicKeyCredential
{
	[Value("getClientCapabilities")]
	public static Task<PublicKeyCredentialClientCapabilities> GetClientCapabilities() { throw new System.NotImplementedException(); }
}


public partial class PublicKeyCredential
{
	[Value("parseCreationOptionsFromJSON")]
	public static PublicKeyCredentialCreationOptions ParseCreationOptionsFromJSON(PublicKeyCredentialCreationOptionsJSON options) { throw new System.NotImplementedException(); }
}

[Value("PublicKeyCredentialCreationOptionsJSON")]
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

[Value("PublicKeyCredentialUserEntityJSON")]
public partial class PublicKeyCredentialUserEntityJSON
{
	[Value("id")]
	public required Base64URLString Id;
	[Value("name")]
	public required DOMString Name;
	[Value("displayName")]
	public required DOMString DisplayName;
}

[Value("PublicKeyCredentialDescriptorJSON")]
public partial class PublicKeyCredentialDescriptorJSON
{
	[Value("type")]
	public required DOMString Type;
	[Value("id")]
	public required Base64URLString Id;
	[Value("transports")]
	public List<DOMString> Transports;
}

[Value("AuthenticationExtensionsClientInputsJSON")]
public partial class AuthenticationExtensionsClientInputsJSON
{
}

public partial class PublicKeyCredential
{
	[Value("parseRequestOptionsFromJSON")]
	public static PublicKeyCredentialRequestOptions ParseRequestOptionsFromJSON(PublicKeyCredentialRequestOptionsJSON options) { throw new System.NotImplementedException(); }
}

[Value("PublicKeyCredentialRequestOptionsJSON")]
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

public partial class PublicKeyCredential
{
	[Value("signalUnknownCredential")]
	public static Task<Undefined> SignalUnknownCredential(UnknownCredentialOptions options) { throw new System.NotImplementedException(); }
	[Value("signalAllAcceptedCredentials")]
	public static Task<Undefined> SignalAllAcceptedCredentials(AllAcceptedCredentialsOptions options) { throw new System.NotImplementedException(); }
	[Value("signalCurrentUserDetails")]
	public static Task<Undefined> SignalCurrentUserDetails(CurrentUserDetailsOptions options) { throw new System.NotImplementedException(); }
}

[Value("UnknownCredentialOptions")]
public partial class UnknownCredentialOptions
{
	[Value("rpId")]
	public required DOMString RpId;
	[Value("credentialId")]
	public required Base64URLString CredentialId;
}

[Value("AllAcceptedCredentialsOptions")]
public partial class AllAcceptedCredentialsOptions
{
	[Value("rpId")]
	public required DOMString RpId;
	[Value("userId")]
	public required Base64URLString UserId;
	[Value("allAcceptedCredentialIds")]
	public required List<Base64URLString> AllAcceptedCredentialIds;
}

[Value("CurrentUserDetailsOptions")]
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

[Value("AuthenticatorResponse")]
public partial class AuthenticatorResponse
{
	[Value("clientDataJSON")]
	public ArrayBuffer ClientDataJSON { get; }
}

[Value("AuthenticatorAttestationResponse")]
public partial class AuthenticatorAttestationResponse : AuthenticatorResponse
{
	[Value("attestationObject")]
	public ArrayBuffer AttestationObject { get; }
	[Value("getTransports")]
	public List<DOMString> GetTransports() { throw new System.NotImplementedException(); }
	[Value("getAuthenticatorData")]
	public ArrayBuffer GetAuthenticatorData() { throw new System.NotImplementedException(); }
	[Value("getPublicKey")]
	public ArrayBuffer? GetPublicKey() { throw new System.NotImplementedException(); }
	[Value("getPublicKeyAlgorithm")]
	public COSEAlgorithmIdentifier GetPublicKeyAlgorithm() { throw new System.NotImplementedException(); }
}

[Value("AuthenticatorAssertionResponse")]
public partial class AuthenticatorAssertionResponse : AuthenticatorResponse
{
	[Value("authenticatorData")]
	public ArrayBuffer AuthenticatorData { get; }
	[Value("signature")]
	public ArrayBuffer Signature { get; }
	[Value("userHandle")]
	public ArrayBuffer? UserHandle { get; }
}

[Value("PublicKeyCredentialParameters")]
public partial class PublicKeyCredentialParameters
{
	[Value("type")]
	public required DOMString Type;
	[Value("alg")]
	public required COSEAlgorithmIdentifier Alg;
}

[Value("PublicKeyCredentialCreationOptions")]
public partial class PublicKeyCredentialCreationOptions
{
	[Value("rp")]
	public required PublicKeyCredentialRpEntity Rp;
	[Value("user")]
	public required PublicKeyCredentialUserEntity User;
	[Value("challenge")]
	public required BufferSource Challenge;
	[Value("pubKeyCredParams")]
	public required List<PublicKeyCredentialParameters> PubKeyCredParams;
	[Value("timeout")]
	public ulong Timeout;
	[Value("excludeCredentials")]
	public List<PublicKeyCredentialDescriptor> ExcludeCredentials;
	[Value("authenticatorSelection")]
	public AuthenticatorSelectionCriteria AuthenticatorSelection;
	[Value("hints")]
	public List<DOMString> Hints;
	[Value("attestation")]
	public DOMString Attestation;
	[Value("attestationFormats")]
	public List<DOMString> AttestationFormats;
	[Value("extensions")]
	public AuthenticationExtensionsClientInputs Extensions;
}

[Value("PublicKeyCredentialEntity")]
public partial class PublicKeyCredentialEntity
{
	[Value("name")]
	public required DOMString Name;
}

[Value("PublicKeyCredentialRpEntity")]
public partial class PublicKeyCredentialRpEntity : PublicKeyCredentialEntity
{
	[Value("id")]
	public DOMString Id;
}

[Value("PublicKeyCredentialUserEntity")]
public partial class PublicKeyCredentialUserEntity : PublicKeyCredentialEntity
{
	[Value("id")]
	public required BufferSource Id;
	[Value("displayName")]
	public required DOMString DisplayName;
}

[Value("AuthenticatorSelectionCriteria")]
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

[Value("PublicKeyCredentialRequestOptions")]
public partial class PublicKeyCredentialRequestOptions
{
	[Value("challenge")]
	public required BufferSource Challenge;
	[Value("timeout")]
	public ulong Timeout;
	[Value("rpId")]
	public DOMString RpId;
	[Value("allowCredentials")]
	public List<PublicKeyCredentialDescriptor> AllowCredentials;
	[Value("userVerification")]
	public DOMString UserVerification;
	[Value("hints")]
	public List<DOMString> Hints;
	[Value("extensions")]
	public AuthenticationExtensionsClientInputs Extensions;
}

public partial class AuthenticationExtensionsClientInputs
{
}

public partial class AuthenticationExtensionsClientOutputs
{
}

[Value("CollectedClientData")]
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

[Value("TokenBinding")]
public partial class TokenBinding
{
	[Value("status")]
	public required DOMString Status;
	[Value("id")]
	public DOMString Id;
}

[Value("PublicKeyCredentialDescriptor")]
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

[Value("CredentialPropertiesOutput")]
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

[Value("AuthenticationExtensionsPRFValues")]
public partial class AuthenticationExtensionsPRFValues
{
	[Value("first")]
	public required BufferSource First;
	[Value("second")]
	public BufferSource Second;
}

[Value("AuthenticationExtensionsPRFInputs")]
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

[Value("AuthenticationExtensionsPRFOutputs")]
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

[Value("AuthenticationExtensionsLargeBlobInputs")]
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

[Value("AuthenticationExtensionsLargeBlobOutputs")]
public partial class AuthenticationExtensionsLargeBlobOutputs
{
	[Value("supported")]
	public bool Supported;
	[Value("blob")]
	public ArrayBuffer Blob;
	[Value("written")]
	public bool Written;
}

[Value("AudioEncoderConfig")]
public partial class AudioEncoderConfig
{
	[Value("aac")]
	public AacEncoderConfig Aac;
}

[Value("AacEncoderConfig")]
public partial class AacEncoderConfig
{
	[Value("format")]
	public AacBitstreamFormat Format;
}

[Value("VideoEncoderEncodeOptions")]
public partial class VideoEncoderEncodeOptions
{
	[Value("av1")]
	public VideoEncoderEncodeOptionsForAv1 Av1;
}

[Value("VideoEncoderEncodeOptionsForAv1")]
public partial class VideoEncoderEncodeOptionsForAv1
{
	[Value("quantizer")]
	public ushort? Quantizer;
}

[Value("VideoEncoderConfig")]
public partial class VideoEncoderConfig
{
	[Value("avc")]
	public AvcEncoderConfig Avc;
}

[Value("AvcEncoderConfig")]
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

[Value("VideoEncoderEncodeOptionsForAvc")]
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

[Value("FlacEncoderConfig")]
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

[Value("HevcEncoderConfig")]
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

[Value("VideoEncoderEncodeOptionsForHevc")]
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

[Value("OpusEncoderConfig")]
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

[Value("VideoEncoderEncodeOptionsForVp9")]
public partial class VideoEncoderEncodeOptionsForVp9
{
	[Value("quantizer")]
	public ushort? Quantizer;
}

[Value("AudioDecoder")]
public partial class AudioDecoder : EventTarget
{
		public AudioDecoder(AudioDecoderInit init) { }
	[Value("state")]
	public CodecState State { get; }
	[Value("decodeQueueSize")]
	public ulong DecodeQueueSize { get; }
	[Value("ondequeue")]
	public EventHandler Ondequeue { get; set; }
	[Value("configure")]
	public Undefined Configure(AudioDecoderConfig config) { throw new System.NotImplementedException(); }
	[Value("decode")]
	public Undefined Decode(EncodedAudioChunk chunk) { throw new System.NotImplementedException(); }
	[Value("flush")]
	public Task<Undefined> Flush() { throw new System.NotImplementedException(); }
	[Value("reset")]
	public Undefined Reset() { throw new System.NotImplementedException(); }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	[Value("isConfigSupported")]
	public static Task<AudioDecoderSupport> IsConfigSupported(AudioDecoderConfig config) { throw new System.NotImplementedException(); }
	public AudioDecoder() { }
}

[Value("AudioDecoderInit")]
public partial class AudioDecoderInit
{
	[Value("output")]
	public required AudioDataOutputCallback Output;
	[Value("error")]
	public required WebCodecsErrorCallback Error;
}

[Value("VideoDecoder")]
public partial class VideoDecoder : EventTarget
{
		public VideoDecoder(VideoDecoderInit init) { }
	[Value("state")]
	public CodecState State { get; }
	[Value("decodeQueueSize")]
	public ulong DecodeQueueSize { get; }
	[Value("ondequeue")]
	public EventHandler Ondequeue { get; set; }
	[Value("configure")]
	public Undefined Configure(VideoDecoderConfig config) { throw new System.NotImplementedException(); }
	[Value("decode")]
	public Undefined Decode(EncodedVideoChunk chunk) { throw new System.NotImplementedException(); }
	[Value("flush")]
	public Task<Undefined> Flush() { throw new System.NotImplementedException(); }
	[Value("reset")]
	public Undefined Reset() { throw new System.NotImplementedException(); }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	[Value("isConfigSupported")]
	public static Task<VideoDecoderSupport> IsConfigSupported(VideoDecoderConfig config) { throw new System.NotImplementedException(); }
	public VideoDecoder() { }
}

[Value("VideoDecoderInit")]
public partial class VideoDecoderInit
{
	[Value("output")]
	public required VideoFrameOutputCallback Output;
	[Value("error")]
	public required WebCodecsErrorCallback Error;
}

[Value("AudioEncoder")]
public partial class AudioEncoder : EventTarget
{
		public AudioEncoder(AudioEncoderInit init) { }
	[Value("state")]
	public CodecState State { get; }
	[Value("encodeQueueSize")]
	public ulong EncodeQueueSize { get; }
	[Value("ondequeue")]
	public EventHandler Ondequeue { get; set; }
	[Value("configure")]
	public Undefined Configure(AudioEncoderConfig config) { throw new System.NotImplementedException(); }
	[Value("encode")]
	public Undefined Encode(AudioData data) { throw new System.NotImplementedException(); }
	[Value("flush")]
	public Task<Undefined> Flush() { throw new System.NotImplementedException(); }
	[Value("reset")]
	public Undefined Reset() { throw new System.NotImplementedException(); }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	[Value("isConfigSupported")]
	public static Task<AudioEncoderSupport> IsConfigSupported(AudioEncoderConfig config) { throw new System.NotImplementedException(); }
	public AudioEncoder() { }
}

[Value("AudioEncoderInit")]
public partial class AudioEncoderInit
{
	[Value("output")]
	public required EncodedAudioChunkOutputCallback Output;
	[Value("error")]
	public required WebCodecsErrorCallback Error;
}

[Value("EncodedAudioChunkMetadata")]
public partial class EncodedAudioChunkMetadata
{
	[Value("decoderConfig")]
	public AudioDecoderConfig DecoderConfig;
}

[Value("VideoEncoder")]
public partial class VideoEncoder : EventTarget
{
		public VideoEncoder(VideoEncoderInit init) { }
	[Value("state")]
	public CodecState State { get; }
	[Value("encodeQueueSize")]
	public ulong EncodeQueueSize { get; }
	[Value("ondequeue")]
	public EventHandler Ondequeue { get; set; }
	[Value("configure")]
	public Undefined Configure(VideoEncoderConfig config) { throw new System.NotImplementedException(); }
	[Value("encode")]
	public Undefined Encode(VideoFrame frame, VideoEncoderEncodeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("flush")]
	public Task<Undefined> Flush() { throw new System.NotImplementedException(); }
	[Value("reset")]
	public Undefined Reset() { throw new System.NotImplementedException(); }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	[Value("isConfigSupported")]
	public static Task<VideoEncoderSupport> IsConfigSupported(VideoEncoderConfig config) { throw new System.NotImplementedException(); }
	public VideoEncoder() { }
}

[Value("VideoEncoderInit")]
public partial class VideoEncoderInit
{
	[Value("output")]
	public required EncodedVideoChunkOutputCallback Output;
	[Value("error")]
	public required WebCodecsErrorCallback Error;
}

[Value("EncodedVideoChunkMetadata")]
public partial class EncodedVideoChunkMetadata
{
	[Value("decoderConfig")]
	public VideoDecoderConfig DecoderConfig;
	[Value("svc")]
	public SvcOutputMetadata Svc;
	[Value("alphaSideData")]
	public BufferSource AlphaSideData;
}

[Value("SvcOutputMetadata")]
public partial class SvcOutputMetadata
{
	[Value("temporalLayerId")]
	public ulong TemporalLayerId;
}

[Value("AudioDecoderSupport")]
public partial class AudioDecoderSupport
{
	[Value("supported")]
	public bool Supported;
	[Value("config")]
	public AudioDecoderConfig Config;
}

[Value("VideoDecoderSupport")]
public partial class VideoDecoderSupport
{
	[Value("supported")]
	public bool Supported;
	[Value("config")]
	public VideoDecoderConfig Config;
}

[Value("AudioEncoderSupport")]
public partial class AudioEncoderSupport
{
	[Value("supported")]
	public bool Supported;
	[Value("config")]
	public AudioEncoderConfig Config;
}

[Value("VideoEncoderSupport")]
public partial class VideoEncoderSupport
{
	[Value("supported")]
	public bool Supported;
	[Value("config")]
	public VideoEncoderConfig Config;
}

[Value("AudioDecoderConfig")]
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

[Value("VideoDecoderConfig")]
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

[Value("EncodedAudioChunk")]
public partial class EncodedAudioChunk
{
		public EncodedAudioChunk(EncodedAudioChunkInit init) { }
	[Value("type")]
	public EncodedAudioChunkType Type { get; }
	[Value("timestamp")]
	public long Timestamp { get; }
	[Value("duration")]
	public ulong? Duration { get; }
	[Value("byteLength")]
	public ulong ByteLength { get; }
	[Value("copyTo")]
	public Undefined CopyTo(AllowSharedBufferSource destination) { throw new System.NotImplementedException(); }
	public EncodedAudioChunk() { }
}

[Value("EncodedAudioChunkInit")]
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

[Value("EncodedVideoChunk")]
public partial class EncodedVideoChunk
{
		public EncodedVideoChunk(EncodedVideoChunkInit init) { }
	[Value("type")]
	public EncodedVideoChunkType Type { get; }
	[Value("timestamp")]
	public long Timestamp { get; }
	[Value("duration")]
	public ulong? Duration { get; }
	[Value("byteLength")]
	public ulong ByteLength { get; }
	[Value("copyTo")]
	public Undefined CopyTo(AllowSharedBufferSource destination) { throw new System.NotImplementedException(); }
	public EncodedVideoChunk() { }
}

[Value("EncodedVideoChunkInit")]
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

[Value("AudioData")]
public partial class AudioData
{
		public AudioData(AudioDataInit init) { }
	[Value("format")]
	public AudioSampleFormat? Format { get; }
	[Value("sampleRate")]
	public Number SampleRate { get; }
	[Value("numberOfFrames")]
	public ulong NumberOfFrames { get; }
	[Value("numberOfChannels")]
	public ulong NumberOfChannels { get; }
	[Value("duration")]
	public ulong Duration { get; }
	[Value("timestamp")]
	public long Timestamp { get; }
	[Value("allocationSize")]
	public ulong AllocationSize(AudioDataCopyToOptions options) { throw new System.NotImplementedException(); }
	[Value("copyTo")]
	public Undefined CopyTo(AllowSharedBufferSource destination, AudioDataCopyToOptions options) { throw new System.NotImplementedException(); }
	[Value("clone")]
	public AudioData Clone() { throw new System.NotImplementedException(); }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	public AudioData() { }
}

[Value("AudioDataInit")]
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

[Value("AudioDataCopyToOptions")]
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

[Value("VideoFrame")]
public partial class VideoFrame
{
		public VideoFrame(CanvasImageSource image, VideoFrameInit init = default) { }
		public VideoFrame(AllowSharedBufferSource data, VideoFrameBufferInit init) { }
	[Value("format")]
	public VideoPixelFormat? Format { get; }
	[Value("codedWidth")]
	public ulong CodedWidth { get; }
	[Value("codedHeight")]
	public ulong CodedHeight { get; }
	[Value("codedRect")]
	public DOMRectReadOnly? CodedRect { get; }
	[Value("visibleRect")]
	public DOMRectReadOnly? VisibleRect { get; }
	[Value("rotation")]
	public Number Rotation { get; }
	[Value("flip")]
	public bool Flip { get; }
	[Value("displayWidth")]
	public ulong DisplayWidth { get; }
	[Value("displayHeight")]
	public ulong DisplayHeight { get; }
	[Value("duration")]
	public ulong? Duration { get; }
	[Value("timestamp")]
	public long Timestamp { get; }
	[Value("colorSpace")]
	public VideoColorSpace ColorSpace { get; }
	[Value("metadata")]
	public VideoFrameMetadata Metadata() { throw new System.NotImplementedException(); }
	[Value("allocationSize")]
	public ulong AllocationSize(VideoFrameCopyToOptions options = default) { throw new System.NotImplementedException(); }
	[Value("copyTo")]
	public Task<List<PlaneLayout>> CopyTo(AllowSharedBufferSource destination, VideoFrameCopyToOptions options = default) { throw new System.NotImplementedException(); }
	[Value("clone")]
	public VideoFrame Clone() { throw new System.NotImplementedException(); }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	public VideoFrame() { }
}

[Value("VideoFrameInit")]
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

[Value("VideoFrameBufferInit")]
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

[Value("VideoFrameMetadata")]
public partial class VideoFrameMetadata
{
}

[Value("VideoFrameCopyToOptions")]
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

[Value("PlaneLayout")]
public partial class PlaneLayout
{
	[Value("offset")]
	public required ulong Offset;
	[Value("stride")]
	public required ulong Stride;
}

[Value("VideoColorSpace")]
public partial class VideoColorSpace
{
		public VideoColorSpace(VideoColorSpaceInit init = default) { }
	[Value("primaries")]
	public VideoColorPrimaries? Primaries { get; }
	[Value("transfer")]
	public VideoTransferCharacteristics? Transfer { get; }
	[Value("matrix")]
	public VideoMatrixCoefficients? Matrix { get; }
	[Value("fullRange")]
	public bool? FullRange { get; }
	[Value("toJSON")]
	public VideoColorSpaceInit ToJSON() { throw new System.NotImplementedException(); }
	public VideoColorSpace() { }
}

[Value("VideoColorSpaceInit")]
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

[Value("ImageDecoder")]
public partial class ImageDecoder
{
		public ImageDecoder(ImageDecoderInit init) { }
	[Value("type")]
	public DOMString Type { get; }
	[Value("complete")]
	public bool Complete { get; }
	[Value("completed")]
	public Task<Undefined> Completed { get; }
	[Value("tracks")]
	public ImageTrackList Tracks { get; }
	[Value("decode")]
	public Task<ImageDecodeResult> Decode(ImageDecodeOptions options = default) { throw new System.NotImplementedException(); }
	[Value("reset")]
	public Undefined Reset() { throw new System.NotImplementedException(); }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	[Value("isTypeSupported")]
	public static Task<bool> IsTypeSupported(DOMString type) { throw new System.NotImplementedException(); }
	public ImageDecoder() { }
}


[Value("ImageDecoderInit")]
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

[Value("ImageDecodeOptions")]
public partial class ImageDecodeOptions
{
	[Value("frameIndex")]
	public ulong FrameIndex;
	[Value("completeFramesOnly")]
	public bool CompleteFramesOnly;
}

[Value("ImageDecodeResult")]
public partial class ImageDecodeResult
{
	[Value("image")]
	public required VideoFrame Image;
	[Value("complete")]
	public required bool Complete;
}

[Value("ImageTrackList")]
public partial class ImageTrackList
{
	
	[Value("ready")]
	public Task<Undefined> Ready { get; }
	[Value("length")]
	public ulong Length { get; }
	[Value("selectedIndex")]
	public long SelectedIndex { get; }
	[Value("selectedTrack")]
	public ImageTrack? SelectedTrack { get; }
}

[Value("ImageTrack")]
public partial class ImageTrack
{
	[Value("animated")]
	public bool Animated { get; }
	[Value("frameCount")]
	public ulong FrameCount { get; }
	[Value("repetitionCount")]
	public float RepetitionCount { get; }
	[Value("selected")]
	public bool Selected { get; set; }
}

[Value("Ed448Params")]
public partial class Ed448Params : Algorithm
{
	[Value("context")]
	public BufferSource Context;
}

[Value("Crypto")]
public partial class Crypto
{
	[Value("subtle")]
	public SubtleCrypto Subtle { get; }
	[Value("getRandomValues")]
	public ArrayBufferView GetRandomValues(ArrayBufferView array) { throw new System.NotImplementedException(); }
	[Value("randomUUID")]
	public DOMString RandomUUID() { throw new System.NotImplementedException(); }
}



[Value("Algorithm")]
public partial class Algorithm
{
	[Value("name")]
	public required DOMString Name;
}

[Value("KeyAlgorithm")]
public partial class KeyAlgorithm
{
	[Value("name")]
	public required DOMString Name;
}

[Value("CryptoKey")]
public partial class CryptoKey
{
	[Value("type")]
	public KeyType Type { get; }
	[Value("extractable")]
	public bool Extractable { get; }
	[Value("algorithm")]
	public Object Algorithm { get; }
	[Value("usages")]
	public Object Usages { get; }
}

[Value("SubtleCrypto")]
public partial class SubtleCrypto
{
	[Value("encrypt")]
	public Task<ArrayBuffer> Encrypt(AlgorithmIdentifier algorithm, CryptoKey key, BufferSource data) { throw new System.NotImplementedException(); }
	[Value("decrypt")]
	public Task<ArrayBuffer> Decrypt(AlgorithmIdentifier algorithm, CryptoKey key, BufferSource data) { throw new System.NotImplementedException(); }
	[Value("sign")]
	public Task<ArrayBuffer> Sign(AlgorithmIdentifier algorithm, CryptoKey key, BufferSource data) { throw new System.NotImplementedException(); }
	[Value("verify")]
	public Task<bool> Verify(AlgorithmIdentifier algorithm, CryptoKey key, BufferSource signature, BufferSource data) { throw new System.NotImplementedException(); }
	[Value("digest")]
	public Task<ArrayBuffer> Digest(AlgorithmIdentifier algorithm, BufferSource data) { throw new System.NotImplementedException(); }
	[Value("generateKey")]
	public Task<CryptoKey> GenerateKey(AlgorithmIdentifier algorithm, bool extractable, List<KeyUsage> keyUsages) { throw new System.NotImplementedException(); }
	[Value("deriveKey")]
	public Task<CryptoKey> DeriveKey(AlgorithmIdentifier algorithm, CryptoKey baseKey, AlgorithmIdentifier derivedKeyType, bool extractable, List<KeyUsage> keyUsages) { throw new System.NotImplementedException(); }
	[Value("deriveBits")]
	public Task<ArrayBuffer> DeriveBits(AlgorithmIdentifier algorithm, CryptoKey baseKey, ulong? length = default) { throw new System.NotImplementedException(); }
	[Value("importKey")]
	public Task<CryptoKey> ImportKey(KeyFormat format, Union188 keyData, AlgorithmIdentifier algorithm, bool extractable, List<KeyUsage> keyUsages) { throw new System.NotImplementedException(); }
	[Value("exportKey")]
	public Task<ArrayBuffer> ExportKey(KeyFormat format, CryptoKey key) { throw new System.NotImplementedException(); }
	[Value("wrapKey")]
	public Task<ArrayBuffer> WrapKey(KeyFormat format, CryptoKey key, CryptoKey wrappingKey, AlgorithmIdentifier wrapAlgorithm) { throw new System.NotImplementedException(); }
	[Value("unwrapKey")]
	public Task<CryptoKey> UnwrapKey(KeyFormat format, BufferSource wrappedKey, CryptoKey unwrappingKey, AlgorithmIdentifier unwrapAlgorithm, AlgorithmIdentifier unwrappedKeyAlgorithm, bool extractable, List<KeyUsage> keyUsages) { throw new System.NotImplementedException(); }
}

[Value("RsaOtherPrimesInfo")]
public partial class RsaOtherPrimesInfo
{
	[Value("r")]
	public DOMString R;
	[Value("d")]
	public DOMString D;
	[Value("t")]
	public DOMString T;
}

[Value("JsonWebKey")]
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


[Value("CryptoKeyPair")]
public partial class CryptoKeyPair
{
	[Value("publicKey")]
	public CryptoKey PublicKey;
	[Value("privateKey")]
	public CryptoKey PrivateKey;
}

[Value("RsaKeyGenParams")]
public partial class RsaKeyGenParams : Algorithm
{
	[Value("modulusLength")]
	public required ulong ModulusLength;
	[Value("publicExponent")]
	public required BigInteger PublicExponent;
}

[Value("RsaHashedKeyGenParams")]
public partial class RsaHashedKeyGenParams : RsaKeyGenParams
{
	[Value("hash")]
	public required HashAlgorithmIdentifier Hash;
}

[Value("RsaKeyAlgorithm")]
public partial class RsaKeyAlgorithm : KeyAlgorithm
{
	[Value("modulusLength")]
	public required ulong ModulusLength;
	[Value("publicExponent")]
	public required BigInteger PublicExponent;
}

[Value("RsaHashedKeyAlgorithm")]
public partial class RsaHashedKeyAlgorithm : RsaKeyAlgorithm
{
	[Value("hash")]
	public required KeyAlgorithm Hash;
}

[Value("RsaHashedImportParams")]
public partial class RsaHashedImportParams : Algorithm
{
	[Value("hash")]
	public required HashAlgorithmIdentifier Hash;
}

[Value("RsaPssParams")]
public partial class RsaPssParams : Algorithm
{
	[Value("saltLength")]
	public required ulong SaltLength;
}

[Value("RsaOaepParams")]
public partial class RsaOaepParams : Algorithm
{
	[Value("label")]
	public BufferSource Label;
}

[Value("EcdsaParams")]
public partial class EcdsaParams : Algorithm
{
	[Value("hash")]
	public required HashAlgorithmIdentifier Hash;
}


[Value("EcKeyGenParams")]
public partial class EcKeyGenParams : Algorithm
{
	[Value("namedCurve")]
	public required NamedCurve NamedCurve;
}

[Value("EcKeyAlgorithm")]
public partial class EcKeyAlgorithm : KeyAlgorithm
{
	[Value("namedCurve")]
	public required NamedCurve NamedCurve;
}

[Value("EcKeyImportParams")]
public partial class EcKeyImportParams : Algorithm
{
	[Value("namedCurve")]
	public required NamedCurve NamedCurve;
}

[Value("EcdhKeyDeriveParams")]
public partial class EcdhKeyDeriveParams : Algorithm
{
	[Value("public")]
	public required CryptoKey Public;
}

[Value("AesCtrParams")]
public partial class AesCtrParams : Algorithm
{
	[Value("counter")]
	public required BufferSource Counter;
	[Value("length")]
	public required byte Length;
}

[Value("AesKeyAlgorithm")]
public partial class AesKeyAlgorithm : KeyAlgorithm
{
	[Value("length")]
	public required ushort Length;
}

[Value("AesKeyGenParams")]
public partial class AesKeyGenParams : Algorithm
{
	[Value("length")]
	public required ushort Length;
}

[Value("AesDerivedKeyParams")]
public partial class AesDerivedKeyParams : Algorithm
{
	[Value("length")]
	public required ushort Length;
}

[Value("AesCbcParams")]
public partial class AesCbcParams : Algorithm
{
	[Value("iv")]
	public required BufferSource Iv;
}

[Value("AesGcmParams")]
public partial class AesGcmParams : Algorithm
{
	[Value("iv")]
	public required BufferSource Iv;
	[Value("additionalData")]
	public BufferSource AdditionalData;
	[Value("tagLength")]
	public byte TagLength;
}

[Value("HmacImportParams")]
public partial class HmacImportParams : Algorithm
{
	[Value("hash")]
	public required HashAlgorithmIdentifier Hash;
	[Value("length")]
	public ulong Length;
}

[Value("HmacKeyAlgorithm")]
public partial class HmacKeyAlgorithm : KeyAlgorithm
{
	[Value("hash")]
	public required KeyAlgorithm Hash;
	[Value("length")]
	public required ulong Length;
}

[Value("HmacKeyGenParams")]
public partial class HmacKeyGenParams : Algorithm
{
	[Value("hash")]
	public required HashAlgorithmIdentifier Hash;
	[Value("length")]
	public ulong Length;
}

[Value("HkdfParams")]
public partial class HkdfParams : Algorithm
{
	[Value("hash")]
	public required HashAlgorithmIdentifier Hash;
	[Value("salt")]
	public required BufferSource Salt;
	[Value("info")]
	public required BufferSource Info;
}

[Value("Pbkdf2Params")]
public partial class Pbkdf2Params : Algorithm
{
	[Value("salt")]
	public required BufferSource Salt;
	[Value("iterations")]
	public required ulong Iterations;
	[Value("hash")]
	public required HashAlgorithmIdentifier Hash;
}

[Value("WebGLContextAttributes")]
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

[Value("WebGLObject")]
public partial class WebGLObject
{
	[Value("label")]
	public USVString Label { get; set; }
}

[Value("WebGLBuffer")]
public partial class WebGLBuffer : WebGLObject
{
}

[Value("WebGLFramebuffer")]
public partial class WebGLFramebuffer : WebGLObject
{
}

[Value("WebGLProgram")]
public partial class WebGLProgram : WebGLObject
{
}

[Value("WebGLRenderbuffer")]
public partial class WebGLRenderbuffer : WebGLObject
{
}

[Value("WebGLShader")]
public partial class WebGLShader : WebGLObject
{
}

[Value("WebGLTexture")]
public partial class WebGLTexture : WebGLObject
{
}

[Value("WebGLUniformLocation")]
public partial class WebGLUniformLocation
{
}

[Value("WebGLActiveInfo")]
public partial class WebGLActiveInfo
{
	[Value("size")]
	public GLint Size { get; }
	[Value("type")]
	public GLenum Type { get; }
	[Value("name")]
	public DOMString Name { get; }
}

[Value("WebGLShaderPrecisionFormat")]
public partial class WebGLShaderPrecisionFormat
{
	[Value("rangeMin")]
	public GLint RangeMin { get; }
	[Value("rangeMax")]
	public GLint RangeMax { get; }
	[Value("precision")]
	public GLint Precision { get; }
}




[Value("WebGLRenderingContext")]
public partial class WebGLRenderingContext
{
}



[Value("WebGLContextEvent")]
public partial class WebGLContextEvent : Event
{
		public WebGLContextEvent(DOMString type, WebGLContextEventInit eventInit = default) { }
	[Value("statusMessage")]
	public DOMString StatusMessage { get; }
	public WebGLContextEvent() { }
}

[Value("WebGLContextEventInit")]
public partial class WebGLContextEventInit : EventInit
{
	[Value("statusMessage")]
	public DOMString StatusMessage;
}



[Value("WebGLQuery")]
public partial class WebGLQuery : WebGLObject
{
}

[Value("WebGLSampler")]
public partial class WebGLSampler : WebGLObject
{
}

[Value("WebGLSync")]
public partial class WebGLSync : WebGLObject
{
}

[Value("WebGLTransformFeedback")]
public partial class WebGLTransformFeedback : WebGLObject
{
}

[Value("WebGLVertexArrayObject")]
public partial class WebGLVertexArrayObject : WebGLObject
{
}


[Value("WebGL2RenderingContext")]
public partial class WebGL2RenderingContext
{
}




[Value("WEBGL_blend_equation_advanced_coherent")]
public partial class WEBGL_blend_equation_advanced_coherent
{
	[Value("MULTIPLY")]
	public const GLenum MULTIPLY = 0x9294;
	[Value("SCREEN")]
	public const GLenum SCREEN = 0x9295;
	[Value("OVERLAY")]
	public const GLenum OVERLAY = 0x9296;
	[Value("DARKEN")]
	public const GLenum DARKEN = 0x9297;
	[Value("LIGHTEN")]
	public const GLenum LIGHTEN = 0x9298;
	[Value("COLORDODGE")]
	public const GLenum COLORDODGE = 0x9299;
	[Value("COLORBURN")]
	public const GLenum COLORBURN = 0x929A;
	[Value("HARDLIGHT")]
	public const GLenum HARDLIGHT = 0x929B;
	[Value("SOFTLIGHT")]
	public const GLenum SOFTLIGHT = 0x929C;
	[Value("DIFFERENCE")]
	public const GLenum DIFFERENCE = 0x929E;
	[Value("EXCLUSION")]
	public const GLenum EXCLUSION = 0x92A0;
	[Value("HSL_HUE")]
	public const GLenum HSL_HUE = 0x92AD;
	[Value("HSL_SATURATION")]
	public const GLenum HSL_SATURATION = 0x92AE;
	[Value("HSL_COLOR")]
	public const GLenum HSL_COLOR = 0x92AF;
	[Value("HSL_LUMINOSITY")]
	public const GLenum HSL_LUMINOSITY = 0x92B0;
}

[Value("WEBGL_clip_cull_distance")]
public partial class WEBGL_clip_cull_distance
{
	[Value("MAX_CLIP_DISTANCES_WEBGL")]
	public const GLenum MAX_CLIP_DISTANCES_WEBGL = 0x0D32;
	[Value("MAX_CULL_DISTANCES_WEBGL")]
	public const GLenum MAX_CULL_DISTANCES_WEBGL = 0x82F9;
	[Value("MAX_COMBINED_CLIP_AND_CULL_DISTANCES_WEBGL")]
	public const GLenum MAX_COMBINED_CLIP_AND_CULL_DISTANCES_WEBGL = 0x82FA;
	[Value("CLIP_DISTANCE0_WEBGL")]
	public const GLenum CLIP_DISTANCE0_WEBGL = 0x3000;
	[Value("CLIP_DISTANCE1_WEBGL")]
	public const GLenum CLIP_DISTANCE1_WEBGL = 0x3001;
	[Value("CLIP_DISTANCE2_WEBGL")]
	public const GLenum CLIP_DISTANCE2_WEBGL = 0x3002;
	[Value("CLIP_DISTANCE3_WEBGL")]
	public const GLenum CLIP_DISTANCE3_WEBGL = 0x3003;
	[Value("CLIP_DISTANCE4_WEBGL")]
	public const GLenum CLIP_DISTANCE4_WEBGL = 0x3004;
	[Value("CLIP_DISTANCE5_WEBGL")]
	public const GLenum CLIP_DISTANCE5_WEBGL = 0x3005;
	[Value("CLIP_DISTANCE6_WEBGL")]
	public const GLenum CLIP_DISTANCE6_WEBGL = 0x3006;
	[Value("CLIP_DISTANCE7_WEBGL")]
	public const GLenum CLIP_DISTANCE7_WEBGL = 0x3007;
}

[Value("WEBGL_color_buffer_float")]
public partial class WEBGL_color_buffer_float
{
	[Value("RGBA32F_EXT")]
	public const GLenum RGBA32F_EXT = 0x8814;
	[Value("FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT")]
	public const GLenum FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT = 0x8211;
	[Value("UNSIGNED_NORMALIZED_EXT")]
	public const GLenum UNSIGNED_NORMALIZED_EXT = 0x8C17;
}

[Value("WEBGL_compressed_texture_astc")]
public partial class WEBGL_compressed_texture_astc
{
	[Value("COMPRESSED_RGBA_ASTC_4x4_KHR")]
	public const GLenum COMPRESSED_RGBA_ASTC_4x4_KHR = 0x93B0;
	[Value("COMPRESSED_RGBA_ASTC_5x4_KHR")]
	public const GLenum COMPRESSED_RGBA_ASTC_5x4_KHR = 0x93B1;
	[Value("COMPRESSED_RGBA_ASTC_5x5_KHR")]
	public const GLenum COMPRESSED_RGBA_ASTC_5x5_KHR = 0x93B2;
	[Value("COMPRESSED_RGBA_ASTC_6x5_KHR")]
	public const GLenum COMPRESSED_RGBA_ASTC_6x5_KHR = 0x93B3;
	[Value("COMPRESSED_RGBA_ASTC_6x6_KHR")]
	public const GLenum COMPRESSED_RGBA_ASTC_6x6_KHR = 0x93B4;
	[Value("COMPRESSED_RGBA_ASTC_8x5_KHR")]
	public const GLenum COMPRESSED_RGBA_ASTC_8x5_KHR = 0x93B5;
	[Value("COMPRESSED_RGBA_ASTC_8x6_KHR")]
	public const GLenum COMPRESSED_RGBA_ASTC_8x6_KHR = 0x93B6;
	[Value("COMPRESSED_RGBA_ASTC_8x8_KHR")]
	public const GLenum COMPRESSED_RGBA_ASTC_8x8_KHR = 0x93B7;
	[Value("COMPRESSED_RGBA_ASTC_10x5_KHR")]
	public const GLenum COMPRESSED_RGBA_ASTC_10x5_KHR = 0x93B8;
	[Value("COMPRESSED_RGBA_ASTC_10x6_KHR")]
	public const GLenum COMPRESSED_RGBA_ASTC_10x6_KHR = 0x93B9;
	[Value("COMPRESSED_RGBA_ASTC_10x8_KHR")]
	public const GLenum COMPRESSED_RGBA_ASTC_10x8_KHR = 0x93BA;
	[Value("COMPRESSED_RGBA_ASTC_10x10_KHR")]
	public const GLenum COMPRESSED_RGBA_ASTC_10x10_KHR = 0x93BB;
	[Value("COMPRESSED_RGBA_ASTC_12x10_KHR")]
	public const GLenum COMPRESSED_RGBA_ASTC_12x10_KHR = 0x93BC;
	[Value("COMPRESSED_RGBA_ASTC_12x12_KHR")]
	public const GLenum COMPRESSED_RGBA_ASTC_12x12_KHR = 0x93BD;
	[Value("COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR")]
	public const GLenum COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR = 0x93D0;
	[Value("COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR")]
	public const GLenum COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR = 0x93D1;
	[Value("COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR")]
	public const GLenum COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR = 0x93D2;
	[Value("COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR")]
	public const GLenum COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR = 0x93D3;
	[Value("COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR")]
	public const GLenum COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR = 0x93D4;
	[Value("COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR")]
	public const GLenum COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR = 0x93D5;
	[Value("COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR")]
	public const GLenum COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR = 0x93D6;
	[Value("COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR")]
	public const GLenum COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR = 0x93D7;
	[Value("COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR")]
	public const GLenum COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR = 0x93D8;
	[Value("COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR")]
	public const GLenum COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR = 0x93D9;
	[Value("COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR")]
	public const GLenum COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR = 0x93DA;
	[Value("COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR")]
	public const GLenum COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR = 0x93DB;
	[Value("COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR")]
	public const GLenum COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR = 0x93DC;
	[Value("COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR")]
	public const GLenum COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR = 0x93DD;
	[Value("getSupportedProfiles")]
	public List<DOMString> GetSupportedProfiles() { throw new System.NotImplementedException(); }
}

[Value("WEBGL_compressed_texture_etc")]
public partial class WEBGL_compressed_texture_etc
{
	[Value("COMPRESSED_R11_EAC")]
	public const GLenum COMPRESSED_R11_EAC = 0x9270;
	[Value("COMPRESSED_SIGNED_R11_EAC")]
	public const GLenum COMPRESSED_SIGNED_R11_EAC = 0x9271;
	[Value("COMPRESSED_RG11_EAC")]
	public const GLenum COMPRESSED_RG11_EAC = 0x9272;
	[Value("COMPRESSED_SIGNED_RG11_EAC")]
	public const GLenum COMPRESSED_SIGNED_RG11_EAC = 0x9273;
	[Value("COMPRESSED_RGB8_ETC2")]
	public const GLenum COMPRESSED_RGB8_ETC2 = 0x9274;
	[Value("COMPRESSED_SRGB8_ETC2")]
	public const GLenum COMPRESSED_SRGB8_ETC2 = 0x9275;
	[Value("COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2")]
	public const GLenum COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;
	[Value("COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2")]
	public const GLenum COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;
	[Value("COMPRESSED_RGBA8_ETC2_EAC")]
	public const GLenum COMPRESSED_RGBA8_ETC2_EAC = 0x9278;
	[Value("COMPRESSED_SRGB8_ALPHA8_ETC2_EAC")]
	public const GLenum COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;
}

[Value("WEBGL_compressed_texture_etc1")]
public partial class WEBGL_compressed_texture_etc1
{
	[Value("COMPRESSED_RGB_ETC1_WEBGL")]
	public const GLenum COMPRESSED_RGB_ETC1_WEBGL = 0x8D64;
}

[Value("WEBGL_compressed_texture_pvrtc")]
public partial class WEBGL_compressed_texture_pvrtc
{
	[Value("COMPRESSED_RGB_PVRTC_4BPPV1_IMG")]
	public const GLenum COMPRESSED_RGB_PVRTC_4BPPV1_IMG = 0x8C00;
	[Value("COMPRESSED_RGB_PVRTC_2BPPV1_IMG")]
	public const GLenum COMPRESSED_RGB_PVRTC_2BPPV1_IMG = 0x8C01;
	[Value("COMPRESSED_RGBA_PVRTC_4BPPV1_IMG")]
	public const GLenum COMPRESSED_RGBA_PVRTC_4BPPV1_IMG = 0x8C02;
	[Value("COMPRESSED_RGBA_PVRTC_2BPPV1_IMG")]
	public const GLenum COMPRESSED_RGBA_PVRTC_2BPPV1_IMG = 0x8C03;
}

[Value("WEBGL_compressed_texture_s3tc")]
public partial class WEBGL_compressed_texture_s3tc
{
	[Value("COMPRESSED_RGB_S3TC_DXT1_EXT")]
	public const GLenum COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0;
	[Value("COMPRESSED_RGBA_S3TC_DXT1_EXT")]
	public const GLenum COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1;
	[Value("COMPRESSED_RGBA_S3TC_DXT3_EXT")]
	public const GLenum COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2;
	[Value("COMPRESSED_RGBA_S3TC_DXT5_EXT")]
	public const GLenum COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3;
}

[Value("WEBGL_compressed_texture_s3tc_srgb")]
public partial class WEBGL_compressed_texture_s3tc_srgb
{
	[Value("COMPRESSED_SRGB_S3TC_DXT1_EXT")]
	public const GLenum COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C;
	[Value("COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT")]
	public const GLenum COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D;
	[Value("COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT")]
	public const GLenum COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E;
	[Value("COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT")]
	public const GLenum COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F;
}

[Value("WEBGL_debug_renderer_info")]
public partial class WEBGL_debug_renderer_info
{
	[Value("UNMASKED_VENDOR_WEBGL")]
	public const GLenum UNMASKED_VENDOR_WEBGL = 0x9245;
	[Value("UNMASKED_RENDERER_WEBGL")]
	public const GLenum UNMASKED_RENDERER_WEBGL = 0x9246;
}

[Value("WEBGL_debug_shaders")]
public partial class WEBGL_debug_shaders
{
	[Value("getTranslatedShaderSource")]
	public DOMString GetTranslatedShaderSource(WebGLShader shader) { throw new System.NotImplementedException(); }
}

[Value("WEBGL_depth_texture")]
public partial class WEBGL_depth_texture
{
	[Value("UNSIGNED_INT_24_8_WEBGL")]
	public const GLenum UNSIGNED_INT_24_8_WEBGL = 0x84FA;
}

[Value("WEBGL_draw_buffers")]
public partial class WEBGL_draw_buffers
{
	[Value("COLOR_ATTACHMENT0_WEBGL")]
	public const GLenum COLOR_ATTACHMENT0_WEBGL = 0x8CE0;
	[Value("COLOR_ATTACHMENT1_WEBGL")]
	public const GLenum COLOR_ATTACHMENT1_WEBGL = 0x8CE1;
	[Value("COLOR_ATTACHMENT2_WEBGL")]
	public const GLenum COLOR_ATTACHMENT2_WEBGL = 0x8CE2;
	[Value("COLOR_ATTACHMENT3_WEBGL")]
	public const GLenum COLOR_ATTACHMENT3_WEBGL = 0x8CE3;
	[Value("COLOR_ATTACHMENT4_WEBGL")]
	public const GLenum COLOR_ATTACHMENT4_WEBGL = 0x8CE4;
	[Value("COLOR_ATTACHMENT5_WEBGL")]
	public const GLenum COLOR_ATTACHMENT5_WEBGL = 0x8CE5;
	[Value("COLOR_ATTACHMENT6_WEBGL")]
	public const GLenum COLOR_ATTACHMENT6_WEBGL = 0x8CE6;
	[Value("COLOR_ATTACHMENT7_WEBGL")]
	public const GLenum COLOR_ATTACHMENT7_WEBGL = 0x8CE7;
	[Value("COLOR_ATTACHMENT8_WEBGL")]
	public const GLenum COLOR_ATTACHMENT8_WEBGL = 0x8CE8;
	[Value("COLOR_ATTACHMENT9_WEBGL")]
	public const GLenum COLOR_ATTACHMENT9_WEBGL = 0x8CE9;
	[Value("COLOR_ATTACHMENT10_WEBGL")]
	public const GLenum COLOR_ATTACHMENT10_WEBGL = 0x8CEA;
	[Value("COLOR_ATTACHMENT11_WEBGL")]
	public const GLenum COLOR_ATTACHMENT11_WEBGL = 0x8CEB;
	[Value("COLOR_ATTACHMENT12_WEBGL")]
	public const GLenum COLOR_ATTACHMENT12_WEBGL = 0x8CEC;
	[Value("COLOR_ATTACHMENT13_WEBGL")]
	public const GLenum COLOR_ATTACHMENT13_WEBGL = 0x8CED;
	[Value("COLOR_ATTACHMENT14_WEBGL")]
	public const GLenum COLOR_ATTACHMENT14_WEBGL = 0x8CEE;
	[Value("COLOR_ATTACHMENT15_WEBGL")]
	public const GLenum COLOR_ATTACHMENT15_WEBGL = 0x8CEF;
	[Value("DRAW_BUFFER0_WEBGL")]
	public const GLenum DRAW_BUFFER0_WEBGL = 0x8825;
	[Value("DRAW_BUFFER1_WEBGL")]
	public const GLenum DRAW_BUFFER1_WEBGL = 0x8826;
	[Value("DRAW_BUFFER2_WEBGL")]
	public const GLenum DRAW_BUFFER2_WEBGL = 0x8827;
	[Value("DRAW_BUFFER3_WEBGL")]
	public const GLenum DRAW_BUFFER3_WEBGL = 0x8828;
	[Value("DRAW_BUFFER4_WEBGL")]
	public const GLenum DRAW_BUFFER4_WEBGL = 0x8829;
	[Value("DRAW_BUFFER5_WEBGL")]
	public const GLenum DRAW_BUFFER5_WEBGL = 0x882A;
	[Value("DRAW_BUFFER6_WEBGL")]
	public const GLenum DRAW_BUFFER6_WEBGL = 0x882B;
	[Value("DRAW_BUFFER7_WEBGL")]
	public const GLenum DRAW_BUFFER7_WEBGL = 0x882C;
	[Value("DRAW_BUFFER8_WEBGL")]
	public const GLenum DRAW_BUFFER8_WEBGL = 0x882D;
	[Value("DRAW_BUFFER9_WEBGL")]
	public const GLenum DRAW_BUFFER9_WEBGL = 0x882E;
	[Value("DRAW_BUFFER10_WEBGL")]
	public const GLenum DRAW_BUFFER10_WEBGL = 0x882F;
	[Value("DRAW_BUFFER11_WEBGL")]
	public const GLenum DRAW_BUFFER11_WEBGL = 0x8830;
	[Value("DRAW_BUFFER12_WEBGL")]
	public const GLenum DRAW_BUFFER12_WEBGL = 0x8831;
	[Value("DRAW_BUFFER13_WEBGL")]
	public const GLenum DRAW_BUFFER13_WEBGL = 0x8832;
	[Value("DRAW_BUFFER14_WEBGL")]
	public const GLenum DRAW_BUFFER14_WEBGL = 0x8833;
	[Value("DRAW_BUFFER15_WEBGL")]
	public const GLenum DRAW_BUFFER15_WEBGL = 0x8834;
	[Value("MAX_COLOR_ATTACHMENTS_WEBGL")]
	public const GLenum MAX_COLOR_ATTACHMENTS_WEBGL = 0x8CDF;
	[Value("MAX_DRAW_BUFFERS_WEBGL")]
	public const GLenum MAX_DRAW_BUFFERS_WEBGL = 0x8824;
	[Value("drawBuffersWEBGL")]
	public Undefined DrawBuffersWEBGL(List<GLenum> buffers) { throw new System.NotImplementedException(); }
}

[Value("WEBGL_draw_instanced_base_vertex_base_instance")]
public partial class WEBGL_draw_instanced_base_vertex_base_instance
{
	[Value("drawArraysInstancedBaseInstanceWEBGL")]
	public Undefined DrawArraysInstancedBaseInstanceWEBGL(GLenum mode, GLint first, GLsizei count, GLsizei instanceCount, GLuint baseInstance) { throw new System.NotImplementedException(); }
	[Value("drawElementsInstancedBaseVertexBaseInstanceWEBGL")]
	public Undefined DrawElementsInstancedBaseVertexBaseInstanceWEBGL(GLenum mode, GLsizei count, GLenum type, GLintptr offset, GLsizei instanceCount, GLint baseVertex, GLuint baseInstance) { throw new System.NotImplementedException(); }
}

[Value("WEBGL_lose_context")]
public partial class WEBGL_lose_context
{
	[Value("loseContext")]
	public Undefined LoseContext() { throw new System.NotImplementedException(); }
	[Value("restoreContext")]
	public Undefined RestoreContext() { throw new System.NotImplementedException(); }
}

[Value("WEBGL_multi_draw")]
public partial class WEBGL_multi_draw
{
	[Value("multiDrawArraysWEBGL")]
	public Undefined MultiDrawArraysWEBGL(GLenum mode, Union194 firstsList, ulong firstsOffset, Union195 countsList, ulong countsOffset, GLsizei drawcount) { throw new System.NotImplementedException(); }
	[Value("multiDrawElementsWEBGL")]
	public Undefined MultiDrawElementsWEBGL(GLenum mode, Union196 countsList, ulong countsOffset, GLenum type, Union197 offsetsList, ulong offsetsOffset, GLsizei drawcount) { throw new System.NotImplementedException(); }
	[Value("multiDrawArraysInstancedWEBGL")]
	public Undefined MultiDrawArraysInstancedWEBGL(GLenum mode, Union198 firstsList, ulong firstsOffset, Union199 countsList, ulong countsOffset, Union200 instanceCountsList, ulong instanceCountsOffset, GLsizei drawcount) { throw new System.NotImplementedException(); }
	[Value("multiDrawElementsInstancedWEBGL")]
	public Undefined MultiDrawElementsInstancedWEBGL(GLenum mode, Union201 countsList, ulong countsOffset, GLenum type, Union202 offsetsList, ulong offsetsOffset, Union203 instanceCountsList, ulong instanceCountsOffset, GLsizei drawcount) { throw new System.NotImplementedException(); }
}

[Value("WEBGL_multi_draw_instanced_base_vertex_base_instance")]
public partial class WEBGL_multi_draw_instanced_base_vertex_base_instance
{
	[Value("multiDrawArraysInstancedBaseInstanceWEBGL")]
	public Undefined MultiDrawArraysInstancedBaseInstanceWEBGL(GLenum mode, Union204 firstsList, ulong firstsOffset, Union205 countsList, ulong countsOffset, Union206 instanceCountsList, ulong instanceCountsOffset, Union207 baseInstancesList, ulong baseInstancesOffset, GLsizei drawcount) { throw new System.NotImplementedException(); }
	[Value("multiDrawElementsInstancedBaseVertexBaseInstanceWEBGL")]
	public Undefined MultiDrawElementsInstancedBaseVertexBaseInstanceWEBGL(GLenum mode, Union208 countsList, ulong countsOffset, GLenum type, Union209 offsetsList, ulong offsetsOffset, Union210 instanceCountsList, ulong instanceCountsOffset, Union211 baseVerticesList, ulong baseVerticesOffset, Union212 baseInstancesList, ulong baseInstancesOffset, GLsizei drawcount) { throw new System.NotImplementedException(); }
}

[Value("WEBGL_provoking_vertex")]
public partial class WEBGL_provoking_vertex
{
	[Value("FIRST_VERTEX_CONVENTION_WEBGL")]
	public const GLenum FIRST_VERTEX_CONVENTION_WEBGL = 0x8E4D;
	[Value("LAST_VERTEX_CONVENTION_WEBGL")]
	public const GLenum LAST_VERTEX_CONVENTION_WEBGL = 0x8E4E;
	[Value("PROVOKING_VERTEX_WEBGL")]
	public const GLenum PROVOKING_VERTEX_WEBGL = 0x8E4F;
	[Value("provokingVertexWEBGL")]
	public Undefined ProvokingVertexWEBGL(GLenum provokeMode) { throw new System.NotImplementedException(); }
}

[Value("GPUObjectDescriptorBase")]
public partial class GPUObjectDescriptorBase
{
	[Value("label")]
	public USVString Label;
}

[Value("GPUSupportedLimits")]
public partial class GPUSupportedLimits
{
	[Value("maxTextureDimension1D")]
	public ulong MaxTextureDimension1D { get; }
	[Value("maxTextureDimension2D")]
	public ulong MaxTextureDimension2D { get; }
	[Value("maxTextureDimension3D")]
	public ulong MaxTextureDimension3D { get; }
	[Value("maxTextureArrayLayers")]
	public ulong MaxTextureArrayLayers { get; }
	[Value("maxBindGroups")]
	public ulong MaxBindGroups { get; }
	[Value("maxBindGroupsPlusVertexBuffers")]
	public ulong MaxBindGroupsPlusVertexBuffers { get; }
	[Value("maxBindingsPerBindGroup")]
	public ulong MaxBindingsPerBindGroup { get; }
	[Value("maxDynamicUniformBuffersPerPipelineLayout")]
	public ulong MaxDynamicUniformBuffersPerPipelineLayout { get; }
	[Value("maxDynamicStorageBuffersPerPipelineLayout")]
	public ulong MaxDynamicStorageBuffersPerPipelineLayout { get; }
	[Value("maxSampledTexturesPerShaderStage")]
	public ulong MaxSampledTexturesPerShaderStage { get; }
	[Value("maxSamplersPerShaderStage")]
	public ulong MaxSamplersPerShaderStage { get; }
	[Value("maxStorageBuffersPerShaderStage")]
	public ulong MaxStorageBuffersPerShaderStage { get; }
	[Value("maxStorageTexturesPerShaderStage")]
	public ulong MaxStorageTexturesPerShaderStage { get; }
	[Value("maxUniformBuffersPerShaderStage")]
	public ulong MaxUniformBuffersPerShaderStage { get; }
	[Value("maxUniformBufferBindingSize")]
	public ulong MaxUniformBufferBindingSize { get; }
	[Value("maxStorageBufferBindingSize")]
	public ulong MaxStorageBufferBindingSize { get; }
	[Value("minUniformBufferOffsetAlignment")]
	public ulong MinUniformBufferOffsetAlignment { get; }
	[Value("minStorageBufferOffsetAlignment")]
	public ulong MinStorageBufferOffsetAlignment { get; }
	[Value("maxVertexBuffers")]
	public ulong MaxVertexBuffers { get; }
	[Value("maxBufferSize")]
	public ulong MaxBufferSize { get; }
	[Value("maxVertexAttributes")]
	public ulong MaxVertexAttributes { get; }
	[Value("maxVertexBufferArrayStride")]
	public ulong MaxVertexBufferArrayStride { get; }
	[Value("maxInterStageShaderVariables")]
	public ulong MaxInterStageShaderVariables { get; }
	[Value("maxColorAttachments")]
	public ulong MaxColorAttachments { get; }
	[Value("maxColorAttachmentBytesPerSample")]
	public ulong MaxColorAttachmentBytesPerSample { get; }
	[Value("maxComputeWorkgroupStorageSize")]
	public ulong MaxComputeWorkgroupStorageSize { get; }
	[Value("maxComputeInvocationsPerWorkgroup")]
	public ulong MaxComputeInvocationsPerWorkgroup { get; }
	[Value("maxComputeWorkgroupSizeX")]
	public ulong MaxComputeWorkgroupSizeX { get; }
	[Value("maxComputeWorkgroupSizeY")]
	public ulong MaxComputeWorkgroupSizeY { get; }
	[Value("maxComputeWorkgroupSizeZ")]
	public ulong MaxComputeWorkgroupSizeZ { get; }
	[Value("maxComputeWorkgroupsPerDimension")]
	public ulong MaxComputeWorkgroupsPerDimension { get; }
}

[Value("GPUSupportedFeatures")]
public partial class GPUSupportedFeatures
{
	
}

[Value("WGSLLanguageFeatures")]
public partial class WGSLLanguageFeatures
{
	
}

[Value("GPUAdapterInfo")]
public partial class GPUAdapterInfo
{
	[Value("vendor")]
	public DOMString Vendor { get; }
	[Value("architecture")]
	public DOMString Architecture { get; }
	[Value("device")]
	public DOMString Device { get; }
	[Value("description")]
	public DOMString Description { get; }
}

[Value("GPU")]
public partial class GPU
{
	[Value("requestAdapter")]
	public Task<GPUAdapter?> RequestAdapter(GPURequestAdapterOptions options = default) { throw new System.NotImplementedException(); }
	[Value("getPreferredCanvasFormat")]
	public GPUTextureFormat GetPreferredCanvasFormat() { throw new System.NotImplementedException(); }
	[Value("wgslLanguageFeatures")]
	public WGSLLanguageFeatures WgslLanguageFeatures { get; }
}

[Value("GPURequestAdapterOptions")]
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

[Value("GPUAdapter")]
public partial class GPUAdapter
{
	[Value("features")]
	public GPUSupportedFeatures Features { get; }
	[Value("limits")]
	public GPUSupportedLimits Limits { get; }
	[Value("info")]
	public GPUAdapterInfo Info { get; }
	[Value("isFallbackAdapter")]
	public bool IsFallbackAdapter { get; }
	[Value("requestDevice")]
	public Task<GPUDevice> RequestDevice(GPUDeviceDescriptor descriptor = default) { throw new System.NotImplementedException(); }
}

[Value("GPUDeviceDescriptor")]
public partial class GPUDeviceDescriptor : GPUObjectDescriptorBase
{
	[Value("requiredFeatures")]
	public List<GPUFeatureName> RequiredFeatures;
	[Value("requiredLimits")]
	public Dictionary<DOMString, GPUSize64> RequiredLimits;
	[Value("defaultQueue")]
	public GPUQueueDescriptor DefaultQueue;
}

[Value("GPUDevice")]
public partial class GPUDevice : EventTarget, GPUObjectBase
{
	[Value("features")]
	public GPUSupportedFeatures Features { get; }
	[Value("limits")]
	public GPUSupportedLimits Limits { get; }
	[Value("adapterInfo")]
	public GPUAdapterInfo AdapterInfo { get; }
	[Value("queue")]
	public GPUQueue Queue { get; }
	[Value("destroy")]
	public Undefined Destroy() { throw new System.NotImplementedException(); }
	[Value("createBuffer")]
	public GPUBuffer CreateBuffer(GPUBufferDescriptor descriptor) { throw new System.NotImplementedException(); }
	[Value("createTexture")]
	public GPUTexture CreateTexture(GPUTextureDescriptor descriptor) { throw new System.NotImplementedException(); }
	[Value("createSampler")]
	public GPUSampler CreateSampler(GPUSamplerDescriptor descriptor = default) { throw new System.NotImplementedException(); }
	[Value("importExternalTexture")]
	public GPUExternalTexture ImportExternalTexture(GPUExternalTextureDescriptor descriptor) { throw new System.NotImplementedException(); }
	[Value("createBindGroupLayout")]
	public GPUBindGroupLayout CreateBindGroupLayout(GPUBindGroupLayoutDescriptor descriptor) { throw new System.NotImplementedException(); }
	[Value("createPipelineLayout")]
	public GPUPipelineLayout CreatePipelineLayout(GPUPipelineLayoutDescriptor descriptor) { throw new System.NotImplementedException(); }
	[Value("createBindGroup")]
	public GPUBindGroup CreateBindGroup(GPUBindGroupDescriptor descriptor) { throw new System.NotImplementedException(); }
	[Value("createShaderModule")]
	public GPUShaderModule CreateShaderModule(GPUShaderModuleDescriptor descriptor) { throw new System.NotImplementedException(); }
	[Value("createComputePipeline")]
	public GPUComputePipeline CreateComputePipeline(GPUComputePipelineDescriptor descriptor) { throw new System.NotImplementedException(); }
	[Value("createRenderPipeline")]
	public GPURenderPipeline CreateRenderPipeline(GPURenderPipelineDescriptor descriptor) { throw new System.NotImplementedException(); }
	[Value("createComputePipelineAsync")]
	public Task<GPUComputePipeline> CreateComputePipelineAsync(GPUComputePipelineDescriptor descriptor) { throw new System.NotImplementedException(); }
	[Value("createRenderPipelineAsync")]
	public Task<GPURenderPipeline> CreateRenderPipelineAsync(GPURenderPipelineDescriptor descriptor) { throw new System.NotImplementedException(); }
	[Value("createCommandEncoder")]
	public GPUCommandEncoder CreateCommandEncoder(GPUCommandEncoderDescriptor descriptor = default) { throw new System.NotImplementedException(); }
	[Value("createRenderBundleEncoder")]
	public GPURenderBundleEncoder CreateRenderBundleEncoder(GPURenderBundleEncoderDescriptor descriptor) { throw new System.NotImplementedException(); }
	[Value("createQuerySet")]
	public GPUQuerySet CreateQuerySet(GPUQuerySetDescriptor descriptor) { throw new System.NotImplementedException(); }
}


[Value("GPUBuffer")]
public partial class GPUBuffer
{
	[Value("size")]
	public GPUSize64Out Size { get; }
	[Value("usage")]
	public GPUFlagsConstant Usage { get; }
	[Value("mapState")]
	public GPUBufferMapState MapState { get; }
	[Value("mapAsync")]
	public Task<Undefined> MapAsync(GPUMapModeFlags mode, GPUSize64 offset = default, GPUSize64 size = default) { throw new System.NotImplementedException(); }
	[Value("getMappedRange")]
	public ArrayBuffer GetMappedRange(GPUSize64 offset = default, GPUSize64 size = default) { throw new System.NotImplementedException(); }
	[Value("unmap")]
	public Undefined Unmap() { throw new System.NotImplementedException(); }
	[Value("destroy")]
	public Undefined Destroy() { throw new System.NotImplementedException(); }
}


[Value("GPUBufferDescriptor")]
public partial class GPUBufferDescriptor : GPUObjectDescriptorBase
{
	[Value("size")]
	public required GPUSize64 Size;
	[Value("usage")]
	public required GPUBufferUsageFlags Usage;
	[Value("mappedAtCreation")]
	public bool MappedAtCreation;
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

[Value("GPUTexture")]
public partial class GPUTexture
{
	[Value("createView")]
	public GPUTextureView CreateView(GPUTextureViewDescriptor descriptor = default) { throw new System.NotImplementedException(); }
	[Value("destroy")]
	public Undefined Destroy() { throw new System.NotImplementedException(); }
	[Value("width")]
	public GPUIntegerCoordinateOut Width { get; }
	[Value("height")]
	public GPUIntegerCoordinateOut Height { get; }
	[Value("depthOrArrayLayers")]
	public GPUIntegerCoordinateOut DepthOrArrayLayers { get; }
	[Value("mipLevelCount")]
	public GPUIntegerCoordinateOut MipLevelCount { get; }
	[Value("sampleCount")]
	public GPUSize32Out SampleCount { get; }
	[Value("dimension")]
	public GPUTextureDimension Dimension { get; }
	[Value("format")]
	public GPUTextureFormat Format { get; }
	[Value("usage")]
	public GPUFlagsConstant Usage { get; }
}


[Value("GPUTextureDescriptor")]
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

[Value("GPUTextureView")]
public partial class GPUTextureView
{
}


[Value("GPUTextureViewDescriptor")]
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

[Value("GPUExternalTexture")]
public partial class GPUExternalTexture
{
}


[Value("GPUExternalTextureDescriptor")]
public partial class GPUExternalTextureDescriptor : GPUObjectDescriptorBase
{
	[Value("source")]
	public required Union213 Source;
	[Value("colorSpace")]
	public PredefinedColorSpace ColorSpace;
}

[Value("GPUSampler")]
public partial class GPUSampler
{
}


[Value("GPUSamplerDescriptor")]
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

[Value("GPUBindGroupLayout")]
public partial class GPUBindGroupLayout
{
}


[Value("GPUBindGroupLayoutDescriptor")]
public partial class GPUBindGroupLayoutDescriptor : GPUObjectDescriptorBase
{
	[Value("entries")]
	public required List<GPUBindGroupLayoutEntry> Entries;
}

[Value("GPUBindGroupLayoutEntry")]
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

[Value("GPUBufferBindingLayout")]
public partial class GPUBufferBindingLayout
{
	[Value("type")]
	public GPUBufferBindingType Type;
	[Value("hasDynamicOffset")]
	public bool HasDynamicOffset;
	[Value("minBindingSize")]
	public GPUSize64 MinBindingSize;
}

[Value("GPUSamplerBindingLayout")]
public partial class GPUSamplerBindingLayout
{
	[Value("type")]
	public GPUSamplerBindingType Type;
}

[Value("GPUTextureBindingLayout")]
public partial class GPUTextureBindingLayout
{
	[Value("sampleType")]
	public GPUTextureSampleType SampleType;
	[Value("viewDimension")]
	public GPUTextureViewDimension ViewDimension;
	[Value("multisampled")]
	public bool Multisampled;
}

[Value("GPUStorageTextureBindingLayout")]
public partial class GPUStorageTextureBindingLayout
{
	[Value("access")]
	public GPUStorageTextureAccess Access;
	[Value("format")]
	public required GPUTextureFormat Format;
	[Value("viewDimension")]
	public GPUTextureViewDimension ViewDimension;
}

[Value("GPUExternalTextureBindingLayout")]
public partial class GPUExternalTextureBindingLayout
{
}

[Value("GPUBindGroup")]
public partial class GPUBindGroup
{
}


[Value("GPUBindGroupDescriptor")]
public partial class GPUBindGroupDescriptor : GPUObjectDescriptorBase
{
	[Value("layout")]
	public required GPUBindGroupLayout Layout;
	[Value("entries")]
	public required List<GPUBindGroupEntry> Entries;
}


[Value("GPUBindGroupEntry")]
public partial class GPUBindGroupEntry
{
	[Value("binding")]
	public required GPUIndex32 Binding;
	[Value("resource")]
	public required GPUBindingResource Resource;
}

[Value("GPUBufferBinding")]
public partial class GPUBufferBinding
{
	[Value("buffer")]
	public required GPUBuffer Buffer;
	[Value("offset")]
	public GPUSize64 Offset;
	[Value("size")]
	public GPUSize64 Size;
}

[Value("GPUPipelineLayout")]
public partial class GPUPipelineLayout
{
}


[Value("GPUPipelineLayoutDescriptor")]
public partial class GPUPipelineLayoutDescriptor : GPUObjectDescriptorBase
{
	[Value("bindGroupLayouts")]
	public required List<GPUBindGroupLayout?> BindGroupLayouts;
}

[Value("GPUShaderModule")]
public partial class GPUShaderModule
{
	[Value("getCompilationInfo")]
	public Task<GPUCompilationInfo> GetCompilationInfo() { throw new System.NotImplementedException(); }
}


[Value("GPUShaderModuleDescriptor")]
public partial class GPUShaderModuleDescriptor : GPUObjectDescriptorBase
{
	[Value("code")]
	public required USVString Code;
	[Value("compilationHints")]
	public List<GPUShaderModuleCompilationHint> CompilationHints;
}

[Value("GPUShaderModuleCompilationHint")]
public partial class GPUShaderModuleCompilationHint
{
	[Value("entryPoint")]
	public required USVString EntryPoint;
	[Value("layout")]
	public Union215 Layout;
}

[Value("GPUCompilationMessage")]
public partial class GPUCompilationMessage
{
	[Value("message")]
	public DOMString Message { get; }
	[Value("type")]
	public GPUCompilationMessageType Type { get; }
	[Value("lineNum")]
	public ulong LineNum { get; }
	[Value("linePos")]
	public ulong LinePos { get; }
	[Value("offset")]
	public ulong Offset { get; }
	[Value("length")]
	public ulong Length { get; }
}

[Value("GPUCompilationInfo")]
public partial class GPUCompilationInfo
{
	[Value("messages")]
	public GPUCompilationMessage[] Messages { get; }
}

[Value("GPUPipelineError")]
public partial class GPUPipelineError : DOMException
{
		public GPUPipelineError(DOMString message = default, GPUPipelineErrorInit options = default) { }
	[Value("reason")]
	public GPUPipelineErrorReason Reason { get; }
	public GPUPipelineError() { }
}

[Value("GPUPipelineErrorInit")]
public partial class GPUPipelineErrorInit
{
	[Value("reason")]
	public required GPUPipelineErrorReason Reason;
}

[Value("GPUPipelineDescriptorBase")]
public partial class GPUPipelineDescriptorBase : GPUObjectDescriptorBase
{
	[Value("layout")]
	public required Union216 Layout;
}

[Value("GPUProgrammableStage")]
public partial class GPUProgrammableStage
{
	[Value("module")]
	public required GPUShaderModule Module;
	[Value("entryPoint")]
	public USVString EntryPoint;
	[Value("constants")]
	public Dictionary<USVString, GPUPipelineConstantValue> Constants;
}


[Value("GPUComputePipeline")]
public partial class GPUComputePipeline
{
}



[Value("GPUComputePipelineDescriptor")]
public partial class GPUComputePipelineDescriptor : GPUPipelineDescriptorBase
{
	[Value("compute")]
	public required GPUProgrammableStage Compute;
}

[Value("GPURenderPipeline")]
public partial class GPURenderPipeline
{
}



[Value("GPURenderPipelineDescriptor")]
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

[Value("GPUPrimitiveState")]
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

[Value("GPUMultisampleState")]
public partial class GPUMultisampleState
{
	[Value("count")]
	public GPUSize32 Count;
	[Value("mask")]
	public GPUSampleMask Mask;
	[Value("alphaToCoverageEnabled")]
	public bool AlphaToCoverageEnabled;
}

[Value("GPUFragmentState")]
public partial class GPUFragmentState : GPUProgrammableStage
{
	[Value("targets")]
	public required List<GPUColorTargetState?> Targets;
}

[Value("GPUColorTargetState")]
public partial class GPUColorTargetState
{
	[Value("format")]
	public required GPUTextureFormat Format;
	[Value("blend")]
	public GPUBlendState Blend;
	[Value("writeMask")]
	public GPUColorWriteFlags WriteMask;
}

[Value("GPUBlendState")]
public partial class GPUBlendState
{
	[Value("color")]
	public required GPUBlendComponent Color;
	[Value("alpha")]
	public required GPUBlendComponent Alpha;
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

[Value("GPUBlendComponent")]
public partial class GPUBlendComponent
{
	[Value("operation")]
	public GPUBlendOperation Operation;
	[Value("srcFactor")]
	public GPUBlendFactor SrcFactor;
	[Value("dstFactor")]
	public GPUBlendFactor DstFactor;
}

[Value("GPUDepthStencilState")]
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

[Value("GPUStencilFaceState")]
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

[Value("GPUVertexState")]
public partial class GPUVertexState : GPUProgrammableStage
{
	[Value("buffers")]
	public List<GPUVertexBufferLayout?> Buffers;
}

[Value("GPUVertexBufferLayout")]
public partial class GPUVertexBufferLayout
{
	[Value("arrayStride")]
	public required GPUSize64 ArrayStride;
	[Value("stepMode")]
	public GPUVertexStepMode StepMode;
	[Value("attributes")]
	public required List<GPUVertexAttribute> Attributes;
}

[Value("GPUVertexAttribute")]
public partial class GPUVertexAttribute
{
	[Value("format")]
	public required GPUVertexFormat Format;
	[Value("offset")]
	public required GPUSize64 Offset;
	[Value("shaderLocation")]
	public required GPUIndex32 ShaderLocation;
}

[Value("GPUTexelCopyBufferLayout")]
public partial class GPUTexelCopyBufferLayout
{
	[Value("offset")]
	public GPUSize64 Offset;
	[Value("bytesPerRow")]
	public GPUSize32 BytesPerRow;
	[Value("rowsPerImage")]
	public GPUSize32 RowsPerImage;
}

[Value("GPUTexelCopyBufferInfo")]
public partial class GPUTexelCopyBufferInfo : GPUTexelCopyBufferLayout
{
	[Value("buffer")]
	public required GPUBuffer Buffer;
}

[Value("GPUTexelCopyTextureInfo")]
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

[Value("GPUCopyExternalImageDestInfo")]
public partial class GPUCopyExternalImageDestInfo : GPUTexelCopyTextureInfo
{
	[Value("colorSpace")]
	public PredefinedColorSpace ColorSpace;
	[Value("premultipliedAlpha")]
	public bool PremultipliedAlpha;
}


[Value("GPUCopyExternalImageSourceInfo")]
public partial class GPUCopyExternalImageSourceInfo
{
	[Value("source")]
	public required GPUCopyExternalImageSource Source;
	[Value("origin")]
	public GPUOrigin2D Origin;
	[Value("flipY")]
	public bool FlipY;
}

[Value("GPUCommandBuffer")]
public partial class GPUCommandBuffer
{
}


[Value("GPUCommandBufferDescriptor")]
public partial class GPUCommandBufferDescriptor : GPUObjectDescriptorBase
{
}

[Value("GPUCommandEncoder")]
public partial class GPUCommandEncoder
{
	[Value("beginRenderPass")]
	public GPURenderPassEncoder BeginRenderPass(GPURenderPassDescriptor descriptor) { throw new System.NotImplementedException(); }
	[Value("beginComputePass")]
	public GPUComputePassEncoder BeginComputePass(GPUComputePassDescriptor descriptor = default) { throw new System.NotImplementedException(); }
	[Value("copyBufferToBuffer")]
	public Undefined CopyBufferToBuffer(GPUBuffer source, GPUSize64 sourceOffset, GPUBuffer destination, GPUSize64 destinationOffset, GPUSize64 size) { throw new System.NotImplementedException(); }
	[Value("copyBufferToTexture")]
	public Undefined CopyBufferToTexture(GPUTexelCopyBufferInfo source, GPUTexelCopyTextureInfo destination, GPUExtent3D copySize) { throw new System.NotImplementedException(); }
	[Value("copyTextureToBuffer")]
	public Undefined CopyTextureToBuffer(GPUTexelCopyTextureInfo source, GPUTexelCopyBufferInfo destination, GPUExtent3D copySize) { throw new System.NotImplementedException(); }
	[Value("copyTextureToTexture")]
	public Undefined CopyTextureToTexture(GPUTexelCopyTextureInfo source, GPUTexelCopyTextureInfo destination, GPUExtent3D copySize) { throw new System.NotImplementedException(); }
	[Value("clearBuffer")]
	public Undefined ClearBuffer(GPUBuffer buffer, GPUSize64 offset = default, GPUSize64 size = default) { throw new System.NotImplementedException(); }
	[Value("resolveQuerySet")]
	public Undefined ResolveQuerySet(GPUQuerySet querySet, GPUSize32 firstQuery, GPUSize32 queryCount, GPUBuffer destination, GPUSize64 destinationOffset) { throw new System.NotImplementedException(); }
	[Value("finish")]
	public GPUCommandBuffer Finish(GPUCommandBufferDescriptor descriptor = default) { throw new System.NotImplementedException(); }
}




[Value("GPUCommandEncoderDescriptor")]
public partial class GPUCommandEncoderDescriptor : GPUObjectDescriptorBase
{
}

[Value("GPUComputePassEncoder")]
public partial class GPUComputePassEncoder
{
	[Value("setPipeline")]
	public Undefined SetPipeline(GPUComputePipeline pipeline) { throw new System.NotImplementedException(); }
	[Value("dispatchWorkgroups")]
	public Undefined DispatchWorkgroups(GPUSize32 workgroupCountX, GPUSize32 workgroupCountY = default, GPUSize32 workgroupCountZ = default) { throw new System.NotImplementedException(); }
	[Value("dispatchWorkgroupsIndirect")]
	public Undefined DispatchWorkgroupsIndirect(GPUBuffer indirectBuffer, GPUSize64 indirectOffset) { throw new System.NotImplementedException(); }
	[Value("end")]
	public Undefined End() { throw new System.NotImplementedException(); }
}





[Value("GPUComputePassTimestampWrites")]
public partial class GPUComputePassTimestampWrites
{
	[Value("querySet")]
	public required GPUQuerySet QuerySet;
	[Value("beginningOfPassWriteIndex")]
	public GPUSize32 BeginningOfPassWriteIndex;
	[Value("endOfPassWriteIndex")]
	public GPUSize32 EndOfPassWriteIndex;
}

[Value("GPUComputePassDescriptor")]
public partial class GPUComputePassDescriptor : GPUObjectDescriptorBase
{
	[Value("timestampWrites")]
	public GPUComputePassTimestampWrites TimestampWrites;
}

[Value("GPURenderPassEncoder")]
public partial class GPURenderPassEncoder
{
	[Value("setViewport")]
	public Undefined SetViewport(Number x, Number y, Number width, Number height, Number minDepth, Number maxDepth) { throw new System.NotImplementedException(); }
	[Value("setScissorRect")]
	public Undefined SetScissorRect(GPUIntegerCoordinate x, GPUIntegerCoordinate y, GPUIntegerCoordinate width, GPUIntegerCoordinate height) { throw new System.NotImplementedException(); }
	[Value("setBlendConstant")]
	public Undefined SetBlendConstant(GPUColor color) { throw new System.NotImplementedException(); }
	[Value("setStencilReference")]
	public Undefined SetStencilReference(GPUStencilValue reference) { throw new System.NotImplementedException(); }
	[Value("beginOcclusionQuery")]
	public Undefined BeginOcclusionQuery(GPUSize32 queryIndex) { throw new System.NotImplementedException(); }
	[Value("endOcclusionQuery")]
	public Undefined EndOcclusionQuery() { throw new System.NotImplementedException(); }
	[Value("executeBundles")]
	public Undefined ExecuteBundles(List<GPURenderBundle> bundles) { throw new System.NotImplementedException(); }
	[Value("end")]
	public Undefined End() { throw new System.NotImplementedException(); }
}






[Value("GPURenderPassTimestampWrites")]
public partial class GPURenderPassTimestampWrites
{
	[Value("querySet")]
	public required GPUQuerySet QuerySet;
	[Value("beginningOfPassWriteIndex")]
	public GPUSize32 BeginningOfPassWriteIndex;
	[Value("endOfPassWriteIndex")]
	public GPUSize32 EndOfPassWriteIndex;
}

[Value("GPURenderPassDescriptor")]
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

[Value("GPURenderPassColorAttachment")]
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

[Value("GPURenderPassDepthStencilAttachment")]
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

[Value("GPURenderPassLayout")]
public partial class GPURenderPassLayout : GPUObjectDescriptorBase
{
	[Value("colorFormats")]
	public required List<GPUTextureFormat?> ColorFormats;
	[Value("depthStencilFormat")]
	public GPUTextureFormat DepthStencilFormat;
	[Value("sampleCount")]
	public GPUSize32 SampleCount;
}

[Value("GPURenderBundle")]
public partial class GPURenderBundle
{
}


[Value("GPURenderBundleDescriptor")]
public partial class GPURenderBundleDescriptor : GPUObjectDescriptorBase
{
}

[Value("GPURenderBundleEncoder")]
public partial class GPURenderBundleEncoder
{
	[Value("finish")]
	public GPURenderBundle Finish(GPURenderBundleDescriptor descriptor = default) { throw new System.NotImplementedException(); }
}






[Value("GPURenderBundleEncoderDescriptor")]
public partial class GPURenderBundleEncoderDescriptor : GPURenderPassLayout
{
	[Value("depthReadOnly")]
	public bool DepthReadOnly;
	[Value("stencilReadOnly")]
	public bool StencilReadOnly;
}

[Value("GPUQueueDescriptor")]
public partial class GPUQueueDescriptor : GPUObjectDescriptorBase
{
}

[Value("GPUQueue")]
public partial class GPUQueue
{
	[Value("submit")]
	public Undefined Submit(List<GPUCommandBuffer> commandBuffers) { throw new System.NotImplementedException(); }
	[Value("onSubmittedWorkDone")]
	public Task<Undefined> OnSubmittedWorkDone() { throw new System.NotImplementedException(); }
	[Value("writeBuffer")]
	public Undefined WriteBuffer(GPUBuffer buffer, GPUSize64 bufferOffset, AllowSharedBufferSource data, GPUSize64 dataOffset = default, GPUSize64 size = default) { throw new System.NotImplementedException(); }
	[Value("writeTexture")]
	public Undefined WriteTexture(GPUTexelCopyTextureInfo destination, AllowSharedBufferSource data, GPUTexelCopyBufferLayout dataLayout, GPUExtent3D size) { throw new System.NotImplementedException(); }
	[Value("copyExternalImageToTexture")]
	public Undefined CopyExternalImageToTexture(GPUCopyExternalImageSourceInfo source, GPUCopyExternalImageDestInfo destination, GPUExtent3D copySize) { throw new System.NotImplementedException(); }
}


[Value("GPUQuerySet")]
public partial class GPUQuerySet
{
	[Value("destroy")]
	public Undefined Destroy() { throw new System.NotImplementedException(); }
	[Value("type")]
	public GPUQueryType Type { get; }
	[Value("count")]
	public GPUSize32Out Count { get; }
}


[Value("GPUQuerySetDescriptor")]
public partial class GPUQuerySetDescriptor : GPUObjectDescriptorBase
{
	[Value("type")]
	public required GPUQueryType Type;
	[Value("count")]
	public required GPUSize32 Count;
}

[Value("GPUCanvasContext")]
public partial class GPUCanvasContext
{
	[Value("canvas")]
	public Union218 Canvas { get; }
	[Value("configure")]
	public Undefined Configure(GPUCanvasConfiguration configuration) { throw new System.NotImplementedException(); }
	[Value("unconfigure")]
	public Undefined Unconfigure() { throw new System.NotImplementedException(); }
	[Value("getConfiguration")]
	public GPUCanvasConfiguration? GetConfiguration() { throw new System.NotImplementedException(); }
	[Value("getCurrentTexture")]
	public GPUTexture GetCurrentTexture() { throw new System.NotImplementedException(); }
}

[Value("GPUCanvasToneMapping")]
public partial class GPUCanvasToneMapping
{
	[Value("mode")]
	public GPUCanvasToneMappingMode Mode;
}

[Value("GPUCanvasConfiguration")]
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

[Value("GPUDeviceLostInfo")]
public partial class GPUDeviceLostInfo
{
	[Value("reason")]
	public GPUDeviceLostReason Reason { get; }
	[Value("message")]
	public DOMString Message { get; }
}

public partial class GPUDevice
{
	[Value("lost")]
	public Task<GPUDeviceLostInfo> Lost { get; }
}

[Value("GPUError")]
public partial class GPUError
{
	[Value("message")]
	public DOMString Message { get; }
}

[Value("GPUValidationError")]
public partial class GPUValidationError : GPUError
{
		public GPUValidationError(DOMString message) { }
	public GPUValidationError() { }
}

[Value("GPUOutOfMemoryError")]
public partial class GPUOutOfMemoryError : GPUError
{
		public GPUOutOfMemoryError(DOMString message) { }
	public GPUOutOfMemoryError() { }
}

[Value("GPUInternalError")]
public partial class GPUInternalError : GPUError
{
		public GPUInternalError(DOMString message) { }
	public GPUInternalError() { }
}

public partial class GPUDevice
{
	[Value("pushErrorScope")]
	public Undefined PushErrorScope(GPUErrorFilter filter) { throw new System.NotImplementedException(); }
	[Value("popErrorScope")]
	public Task<GPUError?> PopErrorScope() { throw new System.NotImplementedException(); }
}

[Value("GPUUncapturedErrorEvent")]
public partial class GPUUncapturedErrorEvent : Event
{
		public GPUUncapturedErrorEvent(DOMString type, GPUUncapturedErrorEventInit gpuUncapturedErrorEventInitDict) { }
	[Value("error")]
	public GPUError Error { get; }
	public GPUUncapturedErrorEvent() { }
}

[Value("GPUUncapturedErrorEventInit")]
public partial class GPUUncapturedErrorEventInit : EventInit
{
	[Value("error")]
	public required GPUError Error;
}

public partial class GPUDevice
{
	[Value("onuncapturederror")]
	public EventHandler Onuncapturederror { get; set; }
}














[Value("GPUColorDict")]
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


[Value("GPUOrigin2DDict")]
public partial class GPUOrigin2DDict
{
	[Value("x")]
	public GPUIntegerCoordinate X;
	[Value("y")]
	public GPUIntegerCoordinate Y;
}


[Value("GPUOrigin3DDict")]
public partial class GPUOrigin3DDict
{
	[Value("x")]
	public GPUIntegerCoordinate X;
	[Value("y")]
	public GPUIntegerCoordinate Y;
	[Value("z")]
	public GPUIntegerCoordinate Z;
}


[Value("GPUExtent3DDict")]
public partial class GPUExtent3DDict
{
	[Value("width")]
	public required GPUIntegerCoordinate Width;
	[Value("height")]
	public GPUIntegerCoordinate Height;
	[Value("depthOrArrayLayers")]
	public GPUIntegerCoordinate DepthOrArrayLayers;
}


public partial class Navigator
{
	[Value("hid")]
	public HID Hid { get; }
}

public partial class WorkerNavigator
{
	[Value("hid")]
	public HID Hid { get; }
}

[Value("HID")]
public partial class HID : EventTarget
{
	[Value("onconnect")]
	public EventHandler Onconnect { get; set; }
	[Value("ondisconnect")]
	public EventHandler Ondisconnect { get; set; }
	[Value("getDevices")]
	public Task<List<HIDDevice>> GetDevices() { throw new System.NotImplementedException(); }
	[Value("requestDevice")]
	public Task<List<HIDDevice>> RequestDevice(HIDDeviceRequestOptions options) { throw new System.NotImplementedException(); }
}

[Value("HIDDeviceRequestOptions")]
public partial class HIDDeviceRequestOptions
{
	[Value("filters")]
	public required List<HIDDeviceFilter> Filters;
	[Value("exclusionFilters")]
	public List<HIDDeviceFilter> ExclusionFilters;
}

[Value("HIDDeviceFilter")]
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

[Value("HIDDevice")]
public partial class HIDDevice : EventTarget
{
	[Value("oninputreport")]
	public EventHandler Oninputreport { get; set; }
	[Value("opened")]
	public bool Opened { get; }
	[Value("vendorId")]
	public ushort VendorId { get; }
	[Value("productId")]
	public ushort ProductId { get; }
	[Value("productName")]
	public DOMString ProductName { get; }
	[Value("collections")]
	public HIDCollectionInfo[] Collections { get; }
	[Value("open")]
	public Task<Undefined> Open() { throw new System.NotImplementedException(); }
	[Value("close")]
	public Task<Undefined> Close() { throw new System.NotImplementedException(); }
	[Value("forget")]
	public Task<Undefined> Forget() { throw new System.NotImplementedException(); }
	[Value("sendReport")]
	public Task<Undefined> SendReport(byte reportId, BufferSource data) { throw new System.NotImplementedException(); }
	[Value("sendFeatureReport")]
	public Task<Undefined> SendFeatureReport(byte reportId, BufferSource data) { throw new System.NotImplementedException(); }
	[Value("receiveFeatureReport")]
	public Task<DataView> ReceiveFeatureReport(byte reportId) { throw new System.NotImplementedException(); }
}

[Value("HIDConnectionEvent")]
public partial class HIDConnectionEvent : Event
{
		public HIDConnectionEvent(DOMString type, HIDConnectionEventInit eventInitDict) { }
	[Value("device")]
	public HIDDevice Device { get; }
	public HIDConnectionEvent() { }
}

[Value("HIDConnectionEventInit")]
public partial class HIDConnectionEventInit : EventInit
{
	[Value("device")]
	public required HIDDevice Device;
}

[Value("HIDInputReportEvent")]
public partial class HIDInputReportEvent : Event
{
		public HIDInputReportEvent(DOMString type, HIDInputReportEventInit eventInitDict) { }
	[Value("device")]
	public HIDDevice Device { get; }
	[Value("reportId")]
	public byte ReportId { get; }
	[Value("data")]
	public DataView Data { get; }
	public HIDInputReportEvent() { }
}

[Value("HIDInputReportEventInit")]
public partial class HIDInputReportEventInit : EventInit
{
	[Value("device")]
	public required HIDDevice Device;
	[Value("reportId")]
	public required byte ReportId;
	[Value("data")]
	public required DataView Data;
}

[Value("HIDCollectionInfo")]
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

[Value("HIDReportInfo")]
public partial class HIDReportInfo
{
	[Value("reportId")]
	public byte ReportId;
	[Value("items")]
	public List<HIDReportItem> Items;
}

[Value("HIDReportItem")]
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

[Value("DOMException")]
public partial class DOMException
{
		public DOMException(DOMString message = default, DOMString name = default) { }
	[Value("name")]
	public DOMString Name { get; }
	[Value("message")]
	public DOMString Message { get; }
	[Value("code")]
	public ushort Code { get; }
	[Value("INDEX_SIZE_ERR")]
	public const ushort INDEX_SIZE_ERR = 1;
	[Value("DOMSTRING_SIZE_ERR")]
	public const ushort DOMSTRING_SIZE_ERR = 2;
	[Value("HIERARCHY_REQUEST_ERR")]
	public const ushort HIERARCHY_REQUEST_ERR = 3;
	[Value("WRONG_DOCUMENT_ERR")]
	public const ushort WRONG_DOCUMENT_ERR = 4;
	[Value("INVALID_CHARACTER_ERR")]
	public const ushort INVALID_CHARACTER_ERR = 5;
	[Value("NO_DATA_ALLOWED_ERR")]
	public const ushort NO_DATA_ALLOWED_ERR = 6;
	[Value("NO_MODIFICATION_ALLOWED_ERR")]
	public const ushort NO_MODIFICATION_ALLOWED_ERR = 7;
	[Value("NOT_FOUND_ERR")]
	public const ushort NOT_FOUND_ERR = 8;
	[Value("NOT_SUPPORTED_ERR")]
	public const ushort NOT_SUPPORTED_ERR = 9;
	[Value("INUSE_ATTRIBUTE_ERR")]
	public const ushort INUSE_ATTRIBUTE_ERR = 10;
	[Value("INVALID_STATE_ERR")]
	public const ushort INVALID_STATE_ERR = 11;
	[Value("SYNTAX_ERR")]
	public const ushort SYNTAX_ERR = 12;
	[Value("INVALID_MODIFICATION_ERR")]
	public const ushort INVALID_MODIFICATION_ERR = 13;
	[Value("NAMESPACE_ERR")]
	public const ushort NAMESPACE_ERR = 14;
	[Value("INVALID_ACCESS_ERR")]
	public const ushort INVALID_ACCESS_ERR = 15;
	[Value("VALIDATION_ERR")]
	public const ushort VALIDATION_ERR = 16;
	[Value("TYPE_MISMATCH_ERR")]
	public const ushort TYPE_MISMATCH_ERR = 17;
	[Value("SECURITY_ERR")]
	public const ushort SECURITY_ERR = 18;
	[Value("NETWORK_ERR")]
	public const ushort NETWORK_ERR = 19;
	[Value("ABORT_ERR")]
	public const ushort ABORT_ERR = 20;
	[Value("URL_MISMATCH_ERR")]
	public const ushort URL_MISMATCH_ERR = 21;
	[Value("QUOTA_EXCEEDED_ERR")]
	public const ushort QUOTA_EXCEEDED_ERR = 22;
	[Value("TIMEOUT_ERR")]
	public const ushort TIMEOUT_ERR = 23;
	[Value("INVALID_NODE_TYPE_ERR")]
	public const ushort INVALID_NODE_TYPE_ERR = 24;
	[Value("DATA_CLONE_ERR")]
	public const ushort DATA_CLONE_ERR = 25;
	public DOMException() { }
}

[Value("MidiPermissionDescriptor")]
public partial class MidiPermissionDescriptor : PermissionDescriptor
{
	[Value("sysex")]
	public bool Sysex;
}

public partial class Navigator
{
	[Value("requestMIDIAccess")]
	public Task<MIDIAccess> RequestMIDIAccess(MIDIOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("MIDIOptions")]
public partial class MIDIOptions
{
	[Value("sysex")]
	public bool Sysex;
	[Value("software")]
	public bool Software;
}

[Value("MIDIInputMap")]
public partial class MIDIInputMap
{
	
}

[Value("MIDIOutputMap")]
public partial class MIDIOutputMap
{
	
}

[Value("MIDIAccess")]
public partial class MIDIAccess : EventTarget
{
	[Value("inputs")]
	public MIDIInputMap Inputs { get; }
	[Value("outputs")]
	public MIDIOutputMap Outputs { get; }
	[Value("onstatechange")]
	public EventHandler Onstatechange { get; set; }
	[Value("sysexEnabled")]
	public bool SysexEnabled { get; }
}

[Value("MIDIPort")]
public partial class MIDIPort : EventTarget
{
	[Value("id")]
	public DOMString Id { get; }
	[Value("manufacturer")]
	public DOMString? Manufacturer { get; }
	[Value("name")]
	public DOMString? Name { get; }
	[Value("type")]
	public MIDIPortType Type { get; }
	[Value("version")]
	public DOMString? Version { get; }
	[Value("state")]
	public MIDIPortDeviceState State { get; }
	[Value("connection")]
	public MIDIPortConnectionState Connection { get; }
	[Value("onstatechange")]
	public EventHandler Onstatechange { get; set; }
	[Value("open")]
	public Task<MIDIPort> Open() { throw new System.NotImplementedException(); }
	[Value("close")]
	public Task<MIDIPort> Close() { throw new System.NotImplementedException(); }
}

[Value("MIDIInput")]
public partial class MIDIInput : MIDIPort
{
	[Value("onmidimessage")]
	public EventHandler Onmidimessage { get; set; }
}

[Value("MIDIOutput")]
public partial class MIDIOutput : MIDIPort
{
	[Value("send")]
	public Undefined Send(List<byte> data, DOMHighResTimeStamp timestamp = default) { throw new System.NotImplementedException(); }
	[Value("clear")]
	public Undefined Clear() { throw new System.NotImplementedException(); }
}

[Value("MIDIMessageEvent")]
public partial class MIDIMessageEvent : Event
{
		public MIDIMessageEvent(DOMString type, MIDIMessageEventInit eventInitDict = default) { }
	[Value("data")]
	public Uint8Array? Data { get; }
	public MIDIMessageEvent() { }
}

[Value("MIDIMessageEventInit")]
public partial class MIDIMessageEventInit : EventInit
{
	[Value("data")]
	public Uint8Array Data;
}

[Value("MIDIConnectionEvent")]
public partial class MIDIConnectionEvent : Event
{
		public MIDIConnectionEvent(DOMString type, MIDIConnectionEventInit eventInitDict = default) { }
	[Value("port")]
	public MIDIPort? Port { get; }
	public MIDIConnectionEvent() { }
}

[Value("MIDIConnectionEventInit")]
public partial class MIDIConnectionEventInit : EventInit
{
	[Value("port")]
	public MIDIPort Port;
}

[Value("MLContextOptions")]
public partial class MLContextOptions
{
	[Value("deviceType")]
	public MLDeviceType DeviceType;
	[Value("powerPreference")]
	public MLPowerPreference PowerPreference;
}

[Value("ML")]
public partial class ML
{
	[Value("createContext")]
	public Task<MLContext> CreateContext(MLContextOptions options = default) { throw new System.NotImplementedException(); }
	[Value("createContext")]
	public Task<MLContext> CreateContext(GPUDevice gpuDevice) { throw new System.NotImplementedException(); }
}


[Value("MLContextLostInfo")]
public partial class MLContextLostInfo
{
	[Value("message")]
	public DOMString Message;
}

[Value("MLContext")]
public partial class MLContext
{
	[Value("dispatch")]
	public Undefined Dispatch(MLGraph graph, MLNamedTensors inputs, MLNamedTensors outputs) { throw new System.NotImplementedException(); }
	[Value("createTensor")]
	public Task<MLTensor> CreateTensor(MLTensorDescriptor descriptor) { throw new System.NotImplementedException(); }
	[Value("readTensor")]
	public Task<ArrayBuffer> ReadTensor(MLTensor tensor) { throw new System.NotImplementedException(); }
	[Value("readTensor")]
	public Task<Undefined> ReadTensor(MLTensor tensor, AllowSharedBufferSource outputData) { throw new System.NotImplementedException(); }
	[Value("writeTensor")]
	public Undefined WriteTensor(MLTensor tensor, AllowSharedBufferSource inputData) { throw new System.NotImplementedException(); }
	[Value("opSupportLimits")]
	public MLOpSupportLimits OpSupportLimits() { throw new System.NotImplementedException(); }
	[Value("destroy")]
	public Undefined Destroy() { throw new System.NotImplementedException(); }
	[Value("lost")]
	public Task<MLContextLostInfo> Lost { get; }
}

[Value("MLOpSupportLimits")]
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

[Value("MLSupportLimits")]
public partial class MLSupportLimits
{
	[Value("dataTypes")]
	public List<MLOperandDataType> DataTypes;
}

[Value("MLBinarySupportLimits")]
public partial class MLBinarySupportLimits
{
	[Value("a")]
	public MLSupportLimits A;
	[Value("b")]
	public MLSupportLimits B;
	[Value("output")]
	public MLSupportLimits Output;
}

[Value("MLSingleInputSupportLimits")]
public partial class MLSingleInputSupportLimits
{
	[Value("input")]
	public MLSupportLimits Input;
	[Value("output")]
	public MLSupportLimits Output;
}

[Value("MLGraph")]
public partial class MLGraph
{
	[Value("destroy")]
	public Undefined Destroy() { throw new System.NotImplementedException(); }
}

[Value("MLOperandDescriptor")]
public partial class MLOperandDescriptor
{
	[Value("dataType")]
	public required MLOperandDataType DataType;
	[Value("shape")]
	public required List<ulong> Shape;
}

[Value("MLOperand")]
public partial class MLOperand
{
	[Value("dataType")]
	public MLOperandDataType DataType { get; }
	[Value("shape")]
	public ulong[] Shape { get; }
}

[Value("MLOperatorOptions")]
public partial class MLOperatorOptions
{
	[Value("label")]
	public USVString Label;
}


[Value("MLTensorDescriptor")]
public partial class MLTensorDescriptor : MLOperandDescriptor
{
	[Value("readable")]
	public bool Readable;
	[Value("writable")]
	public bool Writable;
}

[Value("MLTensor")]
public partial class MLTensor
{
	[Value("dataType")]
	public MLOperandDataType DataType { get; }
	[Value("shape")]
	public ulong[] Shape { get; }
	[Value("readable")]
	public bool Readable { get; }
	[Value("writable")]
	public bool Writable { get; }
	[Value("destroy")]
	public Undefined Destroy() { throw new System.NotImplementedException(); }
}


[Value("MLGraphBuilder")]
public partial class MLGraphBuilder
{
		public MLGraphBuilder(MLContext context) { }
	[Value("input")]
	public MLOperand Input(USVString name, MLOperandDescriptor descriptor) { throw new System.NotImplementedException(); }
	[Value("constant")]
	public MLOperand Constant(MLOperandDescriptor descriptor, AllowSharedBufferSource buffer) { throw new System.NotImplementedException(); }
	[Value("constant")]
	public MLOperand Constant(MLOperandDataType type, MLNumber value) { throw new System.NotImplementedException(); }
	[Value("build")]
	public Task<MLGraph> Build(MLNamedOperands outputs) { throw new System.NotImplementedException(); }
	public MLGraphBuilder() { }
}

[Value("MLArgMinMaxOptions")]
public partial class MLArgMinMaxOptions : MLOperatorOptions
{
	[Value("keepDimensions")]
	public bool KeepDimensions;
	[Value("outputDataType")]
	public MLOperandDataType OutputDataType;
}

public partial class MLGraphBuilder
{
	[Value("argMin")]
	public MLOperand ArgMin(MLOperand input, ulong axis, MLArgMinMaxOptions options = default) { throw new System.NotImplementedException(); }
	[Value("argMax")]
	public MLOperand ArgMax(MLOperand input, ulong axis, MLArgMinMaxOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("argMin")]
	public MLSingleInputSupportLimits ArgMin;
	[Value("argMax")]
	public MLSingleInputSupportLimits ArgMax;
}

[Value("MLBatchNormalizationOptions")]
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

public partial class MLGraphBuilder
{
	[Value("batchNormalization")]
	public MLOperand BatchNormalization(MLOperand input, MLOperand mean, MLOperand variance, MLBatchNormalizationOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("MLBatchNormalizationSupportLimits")]
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

public partial class MLGraphBuilder
{
	[Value("cast")]
	public MLOperand Cast(MLOperand input, MLOperandDataType type, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("cast")]
	public MLSingleInputSupportLimits Cast;
}

[Value("MLClampOptions")]
public partial class MLClampOptions : MLOperatorOptions
{
	[Value("minValue")]
	public MLNumber MinValue;
	[Value("maxValue")]
	public MLNumber MaxValue;
}

public partial class MLGraphBuilder
{
	[Value("clamp")]
	public MLOperand Clamp(MLOperand input, MLClampOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("clamp")]
	public MLSingleInputSupportLimits Clamp;
}

public partial class MLGraphBuilder
{
	[Value("concat")]
	public MLOperand Concat(List<MLOperand> inputs, ulong axis, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("MLConcatSupportLimits")]
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

[Value("MLConv2dOptions")]
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

public partial class MLGraphBuilder
{
	[Value("conv2d")]
	public MLOperand Conv2d(MLOperand input, MLOperand filter, MLConv2dOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("MLConv2dSupportLimits")]
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

[Value("MLConvTranspose2dOptions")]
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

public partial class MLGraphBuilder
{
	[Value("convTranspose2d")]
	public MLOperand ConvTranspose2d(MLOperand input, MLOperand filter, MLConvTranspose2dOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("convTranspose2d")]
	public MLConv2dSupportLimits ConvTranspose2d;
}

public partial class MLGraphBuilder
{
	[Value("add")]
	public MLOperand Add(MLOperand a, MLOperand b, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("sub")]
	public MLOperand Sub(MLOperand a, MLOperand b, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("mul")]
	public MLOperand Mul(MLOperand a, MLOperand b, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("div")]
	public MLOperand Div(MLOperand a, MLOperand b, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("max")]
	public MLOperand Max(MLOperand a, MLOperand b, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("min")]
	public MLOperand Min(MLOperand a, MLOperand b, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("pow")]
	public MLOperand Pow(MLOperand a, MLOperand b, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
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

public partial class MLGraphBuilder
{
	[Value("equal")]
	public MLOperand Equal(MLOperand a, MLOperand b, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("greater")]
	public MLOperand Greater(MLOperand a, MLOperand b, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("greaterOrEqual")]
	public MLOperand GreaterOrEqual(MLOperand a, MLOperand b, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("lesser")]
	public MLOperand Lesser(MLOperand a, MLOperand b, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("lesserOrEqual")]
	public MLOperand LesserOrEqual(MLOperand a, MLOperand b, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("logicalNot")]
	public MLOperand LogicalNot(MLOperand a, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("MLLogicalNotSupportLimits")]
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

public partial class MLGraphBuilder
{
	[Value("abs")]
	public MLOperand Abs(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("ceil")]
	public MLOperand Ceil(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("cos")]
	public MLOperand Cos(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("erf")]
	public MLOperand Erf(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("exp")]
	public MLOperand Exp(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("floor")]
	public MLOperand Floor(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("identity")]
	public MLOperand Identity(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("log")]
	public MLOperand Log(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("neg")]
	public MLOperand Neg(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("reciprocal")]
	public MLOperand Reciprocal(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("sin")]
	public MLOperand Sin(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("sqrt")]
	public MLOperand Sqrt(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
	[Value("tan")]
	public MLOperand Tan(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
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

[Value("MLEluOptions")]
public partial class MLEluOptions : MLOperatorOptions
{
	[Value("alpha")]
	public Number Alpha;
}

public partial class MLGraphBuilder
{
	[Value("elu")]
	public MLOperand Elu(MLOperand input, MLEluOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("elu")]
	public MLSingleInputSupportLimits Elu;
}

public partial class MLGraphBuilder
{
	[Value("expand")]
	public MLOperand Expand(MLOperand input, List<ulong> newShape, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("expand")]
	public MLSingleInputSupportLimits Expand;
}

[Value("MLGatherOptions")]
public partial class MLGatherOptions : MLOperatorOptions
{
	[Value("axis")]
	public ulong Axis;
}

public partial class MLGraphBuilder
{
	[Value("gather")]
	public MLOperand Gather(MLOperand input, MLOperand indices, MLGatherOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("MLGatherSupportLimits")]
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

public partial class MLGraphBuilder
{
	[Value("gelu")]
	public MLOperand Gelu(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("gelu")]
	public MLSingleInputSupportLimits Gelu;
}

[Value("MLGemmOptions")]
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

public partial class MLGraphBuilder
{
	[Value("gemm")]
	public MLOperand Gemm(MLOperand a, MLOperand b, MLGemmOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("MLGemmSupportLimits")]
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

[Value("MLGruOptions")]
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

public partial class MLGraphBuilder
{
	[Value("gru")]
	public List<MLOperand> Gru(MLOperand input, MLOperand weight, MLOperand recurrentWeight, ulong steps, ulong hiddenSize, MLGruOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("MLGruSupportLimits")]
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

[Value("MLGruCellOptions")]
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

public partial class MLGraphBuilder
{
	[Value("gruCell")]
	public MLOperand GruCell(MLOperand input, MLOperand weight, MLOperand recurrentWeight, MLOperand hiddenState, ulong hiddenSize, MLGruCellOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("MLGruCellSupportLimits")]
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

[Value("MLHardSigmoidOptions")]
public partial class MLHardSigmoidOptions : MLOperatorOptions
{
	[Value("alpha")]
	public Number Alpha;
	[Value("beta")]
	public Number Beta;
}

public partial class MLGraphBuilder
{
	[Value("hardSigmoid")]
	public MLOperand HardSigmoid(MLOperand input, MLHardSigmoidOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("hardSigmoid")]
	public MLSingleInputSupportLimits HardSigmoid;
}

public partial class MLGraphBuilder
{
	[Value("hardSwish")]
	public MLOperand HardSwish(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("hardSwish")]
	public MLSingleInputSupportLimits HardSwish;
}

[Value("MLInstanceNormalizationOptions")]
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

public partial class MLGraphBuilder
{
	[Value("instanceNormalization")]
	public MLOperand InstanceNormalization(MLOperand input, MLInstanceNormalizationOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("MLNormalizationSupportLimits")]
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

[Value("MLLayerNormalizationOptions")]
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

public partial class MLGraphBuilder
{
	[Value("layerNormalization")]
	public MLOperand LayerNormalization(MLOperand input, MLLayerNormalizationOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("layerNormalization")]
	public MLNormalizationSupportLimits LayerNormalization;
}

[Value("MLLeakyReluOptions")]
public partial class MLLeakyReluOptions : MLOperatorOptions
{
	[Value("alpha")]
	public Number Alpha;
}

public partial class MLGraphBuilder
{
	[Value("leakyRelu")]
	public MLOperand LeakyRelu(MLOperand input, MLLeakyReluOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("leakyRelu")]
	public MLSingleInputSupportLimits LeakyRelu;
}

[Value("MLLinearOptions")]
public partial class MLLinearOptions : MLOperatorOptions
{
	[Value("alpha")]
	public Number Alpha;
	[Value("beta")]
	public Number Beta;
}

public partial class MLGraphBuilder
{
	[Value("linear")]
	public MLOperand Linear(MLOperand input, MLLinearOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("linear")]
	public MLSingleInputSupportLimits Linear;
}

[Value("MLLstmOptions")]
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

public partial class MLGraphBuilder
{
	[Value("lstm")]
	public List<MLOperand> Lstm(MLOperand input, MLOperand weight, MLOperand recurrentWeight, ulong steps, ulong hiddenSize, MLLstmOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("MLLstmSupportLimits")]
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

[Value("MLLstmCellOptions")]
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

public partial class MLGraphBuilder
{
	[Value("lstmCell")]
	public List<MLOperand> LstmCell(MLOperand input, MLOperand weight, MLOperand recurrentWeight, MLOperand hiddenState, MLOperand cellState, ulong hiddenSize, MLLstmCellOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("MLLstmCellSupportLimits")]
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

public partial class MLGraphBuilder
{
	[Value("matmul")]
	public MLOperand Matmul(MLOperand a, MLOperand b, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("matmul")]
	public MLBinarySupportLimits Matmul;
}

[Value("MLPadOptions")]
public partial class MLPadOptions : MLOperatorOptions
{
	[Value("mode")]
	public MLPaddingMode Mode;
	[Value("value")]
	public MLNumber Value;
}

public partial class MLGraphBuilder
{
	[Value("pad")]
	public MLOperand Pad(MLOperand input, List<ulong> beginningPadding, List<ulong> endingPadding, MLPadOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("pad")]
	public MLSingleInputSupportLimits Pad;
}

[Value("MLPool2dOptions")]
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

public partial class MLGraphBuilder
{
	[Value("averagePool2d")]
	public MLOperand AveragePool2d(MLOperand input, MLPool2dOptions options = default) { throw new System.NotImplementedException(); }
	[Value("l2Pool2d")]
	public MLOperand L2Pool2d(MLOperand input, MLPool2dOptions options = default) { throw new System.NotImplementedException(); }
	[Value("maxPool2d")]
	public MLOperand MaxPool2d(MLOperand input, MLPool2dOptions options = default) { throw new System.NotImplementedException(); }
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

public partial class MLGraphBuilder
{
	[Value("prelu")]
	public MLOperand Prelu(MLOperand input, MLOperand slope, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("MLPreluSupportLimits")]
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

[Value("MLReduceOptions")]
public partial class MLReduceOptions : MLOperatorOptions
{
	[Value("axes")]
	public List<ulong> Axes;
	[Value("keepDimensions")]
	public bool KeepDimensions;
}

public partial class MLGraphBuilder
{
	[Value("reduceL1")]
	public MLOperand ReduceL1(MLOperand input, MLReduceOptions options = default) { throw new System.NotImplementedException(); }
	[Value("reduceL2")]
	public MLOperand ReduceL2(MLOperand input, MLReduceOptions options = default) { throw new System.NotImplementedException(); }
	[Value("reduceLogSum")]
	public MLOperand ReduceLogSum(MLOperand input, MLReduceOptions options = default) { throw new System.NotImplementedException(); }
	[Value("reduceLogSumExp")]
	public MLOperand ReduceLogSumExp(MLOperand input, MLReduceOptions options = default) { throw new System.NotImplementedException(); }
	[Value("reduceMax")]
	public MLOperand ReduceMax(MLOperand input, MLReduceOptions options = default) { throw new System.NotImplementedException(); }
	[Value("reduceMean")]
	public MLOperand ReduceMean(MLOperand input, MLReduceOptions options = default) { throw new System.NotImplementedException(); }
	[Value("reduceMin")]
	public MLOperand ReduceMin(MLOperand input, MLReduceOptions options = default) { throw new System.NotImplementedException(); }
	[Value("reduceProduct")]
	public MLOperand ReduceProduct(MLOperand input, MLReduceOptions options = default) { throw new System.NotImplementedException(); }
	[Value("reduceSum")]
	public MLOperand ReduceSum(MLOperand input, MLReduceOptions options = default) { throw new System.NotImplementedException(); }
	[Value("reduceSumSquare")]
	public MLOperand ReduceSumSquare(MLOperand input, MLReduceOptions options = default) { throw new System.NotImplementedException(); }
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

public partial class MLGraphBuilder
{
	[Value("relu")]
	public MLOperand Relu(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("relu")]
	public MLSingleInputSupportLimits Relu;
}

[Value("MLResample2dOptions")]
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

public partial class MLGraphBuilder
{
	[Value("resample2d")]
	public MLOperand Resample2d(MLOperand input, MLResample2dOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("resample2d")]
	public MLSingleInputSupportLimits Resample2d;
}

public partial class MLGraphBuilder
{
	[Value("reshape")]
	public MLOperand Reshape(MLOperand input, List<ulong> newShape, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("reshape")]
	public MLSingleInputSupportLimits Reshape;
}

public partial class MLGraphBuilder
{
	[Value("sigmoid")]
	public MLOperand Sigmoid(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("sigmoid")]
	public MLSingleInputSupportLimits Sigmoid;
}

public partial class MLGraphBuilder
{
	[Value("slice")]
	public MLOperand Slice(MLOperand input, List<ulong> starts, List<ulong> sizes, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("slice")]
	public MLSingleInputSupportLimits Slice;
}

public partial class MLGraphBuilder
{
	[Value("softmax")]
	public MLOperand Softmax(MLOperand input, ulong axis, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("softmax")]
	public MLSingleInputSupportLimits Softmax;
}

public partial class MLGraphBuilder
{
	[Value("softplus")]
	public MLOperand Softplus(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("softplus")]
	public MLSingleInputSupportLimits Softplus;
}

public partial class MLGraphBuilder
{
	[Value("softsign")]
	public MLOperand Softsign(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("softsign")]
	public MLSingleInputSupportLimits Softsign;
}

[Value("MLSplitOptions")]
public partial class MLSplitOptions : MLOperatorOptions
{
	[Value("axis")]
	public ulong Axis;
}

public partial class MLGraphBuilder
{
	[Value("split")]
	public List<MLOperand> Split(MLOperand input, Union227 splits, MLSplitOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("MLSplitSupportLimits")]
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

public partial class MLGraphBuilder
{
	[Value("tanh")]
	public MLOperand Tanh(MLOperand input, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("tanh")]
	public MLSingleInputSupportLimits Tanh;
}

[Value("MLTransposeOptions")]
public partial class MLTransposeOptions : MLOperatorOptions
{
	[Value("permutation")]
	public List<ulong> Permutation;
}

public partial class MLGraphBuilder
{
	[Value("transpose")]
	public MLOperand Transpose(MLOperand input, MLTransposeOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("transpose")]
	public MLSingleInputSupportLimits Transpose;
}

[Value("MLTriangularOptions")]
public partial class MLTriangularOptions : MLOperatorOptions
{
	[Value("upper")]
	public bool Upper;
	[Value("diagonal")]
	public long Diagonal;
}

public partial class MLGraphBuilder
{
	[Value("triangular")]
	public MLOperand Triangular(MLOperand input, MLTriangularOptions options = default) { throw new System.NotImplementedException(); }
}

public partial class MLOpSupportLimits
{
	[Value("triangular")]
	public MLSingleInputSupportLimits Triangular;
}

public partial class MLGraphBuilder
{
	[Value("where")]
	public MLOperand Where(MLOperand condition, MLOperand trueValue, MLOperand falseValue, MLOperatorOptions options = default) { throw new System.NotImplementedException(); }
}

[Value("MLWhereSupportLimits")]
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


[Value("RTCRtpSender")]
public partial class RTCRtpSender
{
	[Value("transform")]
	public RTCRtpTransform? Transform { get; set; }
}

[Value("RTCRtpReceiver")]
public partial class RTCRtpReceiver
{
	[Value("transform")]
	public RTCRtpTransform? Transform { get; set; }
}

[Value("SFrameTransformOptions")]
public partial class SFrameTransformOptions
{
	[Value("role")]
	public SFrameTransformRole Role;
}



[Value("SFrameTransform")]
public partial class SFrameTransform : EventTarget, GenericTransformStream
{
		public SFrameTransform(SFrameTransformOptions options = default) { }
	[Value("setEncryptionKey")]
	public Task<Undefined> SetEncryptionKey(CryptoKey key, CryptoKeyID keyID = default) { throw new System.NotImplementedException(); }
	[Value("onerror")]
	public EventHandler Onerror { get; set; }
	public SFrameTransform() { }
}


[Value("SFrameTransformErrorEvent")]
public partial class SFrameTransformErrorEvent : Event
{
		public SFrameTransformErrorEvent(DOMString type, SFrameTransformErrorEventInit eventInitDict) { }
	[Value("errorType")]
	public SFrameTransformErrorEventType ErrorType { get; }
	[Value("keyID")]
	public CryptoKeyID? KeyID { get; }
	[Value("frame")]
	public dynamic Frame { get; }
	public SFrameTransformErrorEvent() { }
}

[Value("SFrameTransformErrorEventInit")]
public partial class SFrameTransformErrorEventInit : EventInit
{
	[Value("errorType")]
	public required SFrameTransformErrorEventType ErrorType;
	[Value("frame")]
	public required dynamic Frame;
	[Value("keyID")]
	public CryptoKeyID? KeyID;
}

[Value("RTCEncodedVideoFrameMetadata")]
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

[Value("RTCEncodedVideoFrameOptions")]
public partial class RTCEncodedVideoFrameOptions
{
	[Value("metadata")]
	public RTCEncodedVideoFrameMetadata Metadata;
}

[Value("RTCEncodedVideoFrame")]
public partial class RTCEncodedVideoFrame
{
		public RTCEncodedVideoFrame(RTCEncodedVideoFrame originalFrame, RTCEncodedVideoFrameOptions options = default) { }
	[Value("type")]
	public RTCEncodedVideoFrameType Type { get; }
	[Value("data")]
	public ArrayBuffer Data { get; set; }
	[Value("getMetadata")]
	public RTCEncodedVideoFrameMetadata GetMetadata() { throw new System.NotImplementedException(); }
	public RTCEncodedVideoFrame() { }
}

[Value("RTCEncodedAudioFrameMetadata")]
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

[Value("RTCEncodedAudioFrameOptions")]
public partial class RTCEncodedAudioFrameOptions
{
	[Value("metadata")]
	public RTCEncodedAudioFrameMetadata Metadata;
}

[Value("RTCEncodedAudioFrame")]
public partial class RTCEncodedAudioFrame
{
		public RTCEncodedAudioFrame(RTCEncodedAudioFrame originalFrame, RTCEncodedAudioFrameOptions options = default) { }
	[Value("data")]
	public ArrayBuffer Data { get; set; }
	[Value("getMetadata")]
	public RTCEncodedAudioFrameMetadata GetMetadata() { throw new System.NotImplementedException(); }
	public RTCEncodedAudioFrame() { }
}

[Value("RTCTransformEvent")]
public partial class RTCTransformEvent : Event
{
	[Value("transformer")]
	public RTCRtpScriptTransformer Transformer { get; }
}

public partial class DedicatedWorkerGlobalScope
{
	[Value("onrtctransform")]
	public EventHandler Onrtctransform { get; set; }
}

[Value("RTCRtpScriptTransformer")]
public partial class RTCRtpScriptTransformer : EventTarget
{
	[Value("readable")]
	public ReadableStream Readable { get; }
	[Value("generateKeyFrame")]
	public Task<ulong> GenerateKeyFrame(DOMString rid = default) { throw new System.NotImplementedException(); }
	[Value("sendKeyFrameRequest")]
	public Task<Undefined> SendKeyFrameRequest() { throw new System.NotImplementedException(); }
	[Value("writable")]
	public WritableStream Writable { get; }
	[Value("onkeyframerequest")]
	public EventHandler Onkeyframerequest { get; set; }
	[Value("options")]
	public dynamic Options { get; }
}

[Value("RTCRtpScriptTransform")]
public partial class RTCRtpScriptTransform
{
		public RTCRtpScriptTransform(Worker worker, dynamic options = default, List<Object> transfer = default) { }
	public RTCRtpScriptTransform() { }
}

[Value("KeyFrameRequestEvent")]
public partial class KeyFrameRequestEvent : Event
{
		public KeyFrameRequestEvent(DOMString type, DOMString rid = default) { }
	[Value("rid")]
	public DOMString? Rid { get; }
	public KeyFrameRequestEvent() { }
}

public partial class RTCRtpSender
{
	[Value("generateKeyFrame")]
	public Task<Undefined> GenerateKeyFrame(List<DOMString> rids = default) { throw new System.NotImplementedException(); }
}

[Value("RTCIceParameters")]
public partial class RTCIceParameters
{
	[Value("iceLite")]
	public bool IceLite;
}

[Value("RTCIceGatherOptions")]
public partial class RTCIceGatherOptions
{
	[Value("gatherPolicy")]
	public RTCIceTransportPolicy GatherPolicy;
	[Value("iceServers")]
	public List<RTCIceServer> IceServers;
}

[Value("RTCIceTransport")]
public partial class RTCIceTransport
{
		public RTCIceTransport() { }
	[Value("gather")]
	public Undefined Gather(RTCIceGatherOptions options = default) { throw new System.NotImplementedException(); }
	[Value("start")]
	public Undefined Start(RTCIceParameters remoteParameters = default, RTCIceRole role = default) { throw new System.NotImplementedException(); }
	[Value("stop")]
	public Undefined Stop() { throw new System.NotImplementedException(); }
	[Value("addRemoteCandidate")]
	public Undefined AddRemoteCandidate(RTCIceCandidateInit remoteCandidate = default) { throw new System.NotImplementedException(); }
	[Value("onerror")]
	public EventHandler Onerror { get; set; }
	[Value("onicecandidate")]
	public EventHandler Onicecandidate { get; set; }
}

[Value("RTCIdentityProviderGlobalScope")]
public partial class RTCIdentityProviderGlobalScope : WorkerGlobalScope
{
	[Value("rtcIdentityProvider")]
	public RTCIdentityProviderRegistrar RtcIdentityProvider { get; }
}

[Value("RTCIdentityProviderRegistrar")]
public partial class RTCIdentityProviderRegistrar
{
	[Value("register")]
	public Undefined Register(RTCIdentityProvider idp) { throw new System.NotImplementedException(); }
}

[Value("RTCIdentityProvider")]
public partial class RTCIdentityProvider
{
	[Value("generateAssertion")]
	public required GenerateAssertionCallback GenerateAssertion;
	[Value("validateAssertion")]
	public required ValidateAssertionCallback ValidateAssertion;
}

[Value("RTCIdentityAssertionResult")]
public partial class RTCIdentityAssertionResult
{
	[Value("idp")]
	public required RTCIdentityProviderDetails Idp;
	[Value("assertion")]
	public required DOMString Assertion;
}

[Value("RTCIdentityProviderDetails")]
public partial class RTCIdentityProviderDetails
{
	[Value("domain")]
	public required DOMString Domain;
	[Value("protocol")]
	public DOMString Protocol;
}

[Value("RTCIdentityValidationResult")]
public partial class RTCIdentityValidationResult
{
	[Value("identity")]
	public required DOMString Identity;
	[Value("contents")]
	public required DOMString Contents;
}

[Value("RTCPeerConnection")]
public partial class RTCPeerConnection
{
	[Value("setIdentityProvider")]
	public Undefined SetIdentityProvider(DOMString provider, RTCIdentityProviderOptions options = default) { throw new System.NotImplementedException(); }
	[Value("getIdentityAssertion")]
	public Task<DOMString> GetIdentityAssertion() { throw new System.NotImplementedException(); }
	[Value("peerIdentity")]
	public Task<RTCIdentityAssertion> PeerIdentity { get; }
	[Value("idpLoginUrl")]
	public DOMString? IdpLoginUrl { get; }
	[Value("idpErrorInfo")]
	public DOMString? IdpErrorInfo { get; }
}

[Value("RTCConfiguration")]
public partial class RTCConfiguration
{
	[Value("peerIdentity")]
	public DOMString PeerIdentity;
}

[Value("RTCIdentityProviderOptions")]
public partial class RTCIdentityProviderOptions
{
	[Value("protocol")]
	public DOMString Protocol;
	[Value("usernameHint")]
	public DOMString UsernameHint;
	[Value("peerIdentity")]
	public DOMString PeerIdentity;
}

[Value("RTCIdentityAssertion")]
public partial class RTCIdentityAssertion
{
		public RTCIdentityAssertion(DOMString idp, DOMString name) { }
	[Value("idp")]
	public DOMString Idp { get; set; }
	[Value("name")]
	public DOMString Name { get; set; }
	public RTCIdentityAssertion() { }
}

[Value("RTCError")]
public partial class RTCError
{
	[Value("httpRequestStatusCode")]
	public long? HttpRequestStatusCode { get; }
}

[Value("RTCErrorInit")]
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

public partial class MediaStreamTrack
{
	[Value("isolated")]
	public bool Isolated { get; }
	[Value("onisolationchange")]
	public EventHandler Onisolationchange { get; set; }
}

[Value("RTCRtpEncodingParameters")]
public partial class RTCRtpEncodingParameters
{
	[Value("priority")]
	public RTCPriorityType Priority;
	[Value("networkPriority")]
	public RTCPriorityType NetworkPriority;
}

[Value("RTCDataChannel")]
public partial class RTCDataChannel
{
	[Value("priority")]
	public RTCPriorityType Priority { get; }
}

[Value("RTCDataChannelInit")]
public partial class RTCDataChannelInit
{
	[Value("priority")]
	public RTCPriorityType Priority;
}

[Value("RTCRtpStreamStats")]
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

[Value("RTCCodecStats")]
public partial class RTCCodecStats : RTCStats
{
	[Value("payloadType")]
	public required ulong PayloadType;
	[Value("transportId")]
	public required DOMString TransportId;
	[Value("mimeType")]
	public required DOMString MimeType;
	[Value("clockRate")]
	public ulong ClockRate;
	[Value("channels")]
	public ulong Channels;
	[Value("sdpFmtpLine")]
	public DOMString SdpFmtpLine;
}

[Value("RTCReceivedRtpStreamStats")]
public partial class RTCReceivedRtpStreamStats : RTCRtpStreamStats
{
	[Value("packetsReceived")]
	public ulong PacketsReceived;
	[Value("packetsLost")]
	public long PacketsLost;
	[Value("jitter")]
	public Number Jitter;
}

[Value("RTCInboundRtpStreamStats")]
public partial class RTCInboundRtpStreamStats : RTCReceivedRtpStreamStats
{
	[Value("trackIdentifier")]
	public required DOMString TrackIdentifier;
	[Value("mid")]
	public DOMString Mid;
	[Value("remoteId")]
	public DOMString RemoteId;
	[Value("framesDecoded")]
	public ulong FramesDecoded;
	[Value("keyFramesDecoded")]
	public ulong KeyFramesDecoded;
	[Value("framesRendered")]
	public ulong FramesRendered;
	[Value("framesDropped")]
	public ulong FramesDropped;
	[Value("frameWidth")]
	public ulong FrameWidth;
	[Value("frameHeight")]
	public ulong FrameHeight;
	[Value("framesPerSecond")]
	public Number FramesPerSecond;
	[Value("qpSum")]
	public ulong QpSum;
	[Value("totalDecodeTime")]
	public Number TotalDecodeTime;
	[Value("totalInterFrameDelay")]
	public Number TotalInterFrameDelay;
	[Value("totalSquaredInterFrameDelay")]
	public Number TotalSquaredInterFrameDelay;
	[Value("pauseCount")]
	public ulong PauseCount;
	[Value("totalPausesDuration")]
	public Number TotalPausesDuration;
	[Value("freezeCount")]
	public ulong FreezeCount;
	[Value("totalFreezesDuration")]
	public Number TotalFreezesDuration;
	[Value("lastPacketReceivedTimestamp")]
	public DOMHighResTimeStamp LastPacketReceivedTimestamp;
	[Value("headerBytesReceived")]
	public ulong HeaderBytesReceived;
	[Value("packetsDiscarded")]
	public ulong PacketsDiscarded;
	[Value("fecBytesReceived")]
	public ulong FecBytesReceived;
	[Value("fecPacketsReceived")]
	public ulong FecPacketsReceived;
	[Value("fecPacketsDiscarded")]
	public ulong FecPacketsDiscarded;
	[Value("bytesReceived")]
	public ulong BytesReceived;
	[Value("nackCount")]
	public ulong NackCount;
	[Value("firCount")]
	public ulong FirCount;
	[Value("pliCount")]
	public ulong PliCount;
	[Value("totalProcessingDelay")]
	public Number TotalProcessingDelay;
	[Value("estimatedPlayoutTimestamp")]
	public DOMHighResTimeStamp EstimatedPlayoutTimestamp;
	[Value("jitterBufferDelay")]
	public Number JitterBufferDelay;
	[Value("jitterBufferTargetDelay")]
	public Number JitterBufferTargetDelay;
	[Value("jitterBufferEmittedCount")]
	public ulong JitterBufferEmittedCount;
	[Value("jitterBufferMinimumDelay")]
	public Number JitterBufferMinimumDelay;
	[Value("totalSamplesReceived")]
	public ulong TotalSamplesReceived;
	[Value("concealedSamples")]
	public ulong ConcealedSamples;
	[Value("silentConcealedSamples")]
	public ulong SilentConcealedSamples;
	[Value("concealmentEvents")]
	public ulong ConcealmentEvents;
	[Value("insertedSamplesForDeceleration")]
	public ulong InsertedSamplesForDeceleration;
	[Value("removedSamplesForAcceleration")]
	public ulong RemovedSamplesForAcceleration;
	[Value("audioLevel")]
	public Number AudioLevel;
	[Value("totalAudioEnergy")]
	public Number TotalAudioEnergy;
	[Value("totalSamplesDuration")]
	public Number TotalSamplesDuration;
	[Value("framesReceived")]
	public ulong FramesReceived;
	[Value("decoderImplementation")]
	public DOMString DecoderImplementation;
	[Value("playoutId")]
	public DOMString PlayoutId;
	[Value("powerEfficientDecoder")]
	public bool PowerEfficientDecoder;
	[Value("framesAssembledFromMultiplePackets")]
	public ulong FramesAssembledFromMultiplePackets;
	[Value("totalAssemblyTime")]
	public Number TotalAssemblyTime;
	[Value("retransmittedPacketsReceived")]
	public ulong RetransmittedPacketsReceived;
	[Value("retransmittedBytesReceived")]
	public ulong RetransmittedBytesReceived;
	[Value("rtxSsrc")]
	public ulong RtxSsrc;
	[Value("fecSsrc")]
	public ulong FecSsrc;
	[Value("totalCorruptionProbability")]
	public Number TotalCorruptionProbability;
	[Value("totalSquaredCorruptionProbability")]
	public Number TotalSquaredCorruptionProbability;
	[Value("corruptionMeasurements")]
	public ulong CorruptionMeasurements;
}

[Value("RTCRemoteInboundRtpStreamStats")]
public partial class RTCRemoteInboundRtpStreamStats : RTCReceivedRtpStreamStats
{
	[Value("localId")]
	public DOMString LocalId;
	[Value("roundTripTime")]
	public Number RoundTripTime;
	[Value("totalRoundTripTime")]
	public Number TotalRoundTripTime;
	[Value("fractionLost")]
	public Number FractionLost;
	[Value("roundTripTimeMeasurements")]
	public ulong RoundTripTimeMeasurements;
}

[Value("RTCSentRtpStreamStats")]
public partial class RTCSentRtpStreamStats : RTCRtpStreamStats
{
	[Value("packetsSent")]
	public ulong PacketsSent;
	[Value("bytesSent")]
	public ulong BytesSent;
}

[Value("RTCOutboundRtpStreamStats")]
public partial class RTCOutboundRtpStreamStats : RTCSentRtpStreamStats
{
	[Value("mid")]
	public DOMString Mid;
	[Value("mediaSourceId")]
	public DOMString MediaSourceId;
	[Value("remoteId")]
	public DOMString RemoteId;
	[Value("rid")]
	public DOMString Rid;
	[Value("headerBytesSent")]
	public ulong HeaderBytesSent;
	[Value("retransmittedPacketsSent")]
	public ulong RetransmittedPacketsSent;
	[Value("retransmittedBytesSent")]
	public ulong RetransmittedBytesSent;
	[Value("rtxSsrc")]
	public ulong RtxSsrc;
	[Value("targetBitrate")]
	public Number TargetBitrate;
	[Value("totalEncodedBytesTarget")]
	public ulong TotalEncodedBytesTarget;
	[Value("frameWidth")]
	public ulong FrameWidth;
	[Value("frameHeight")]
	public ulong FrameHeight;
	[Value("framesPerSecond")]
	public Number FramesPerSecond;
	[Value("framesSent")]
	public ulong FramesSent;
	[Value("hugeFramesSent")]
	public ulong HugeFramesSent;
	[Value("framesEncoded")]
	public ulong FramesEncoded;
	[Value("keyFramesEncoded")]
	public ulong KeyFramesEncoded;
	[Value("qpSum")]
	public ulong QpSum;
	[Value("totalEncodeTime")]
	public Number TotalEncodeTime;
	[Value("totalPacketSendDelay")]
	public Number TotalPacketSendDelay;
	[Value("qualityLimitationReason")]
	public RTCQualityLimitationReason QualityLimitationReason;
	[Value("qualityLimitationDurations")]
	public Dictionary<DOMString, Number> QualityLimitationDurations;
	[Value("qualityLimitationResolutionChanges")]
	public ulong QualityLimitationResolutionChanges;
	[Value("nackCount")]
	public ulong NackCount;
	[Value("firCount")]
	public ulong FirCount;
	[Value("pliCount")]
	public ulong PliCount;
	[Value("encoderImplementation")]
	public DOMString EncoderImplementation;
	[Value("powerEfficientEncoder")]
	public bool PowerEfficientEncoder;
	[Value("active")]
	public bool Active;
	[Value("scalabilityMode")]
	public DOMString ScalabilityMode;
}

[Value("RTCRemoteOutboundRtpStreamStats")]
public partial class RTCRemoteOutboundRtpStreamStats : RTCSentRtpStreamStats
{
	[Value("localId")]
	public DOMString LocalId;
	[Value("remoteTimestamp")]
	public DOMHighResTimeStamp RemoteTimestamp;
	[Value("reportsSent")]
	public ulong ReportsSent;
	[Value("roundTripTime")]
	public Number RoundTripTime;
	[Value("totalRoundTripTime")]
	public Number TotalRoundTripTime;
	[Value("roundTripTimeMeasurements")]
	public ulong RoundTripTimeMeasurements;
}

[Value("RTCMediaSourceStats")]
public partial class RTCMediaSourceStats : RTCStats
{
	[Value("trackIdentifier")]
	public required DOMString TrackIdentifier;
	[Value("kind")]
	public required DOMString Kind;
}

[Value("RTCAudioSourceStats")]
public partial class RTCAudioSourceStats : RTCMediaSourceStats
{
	[Value("audioLevel")]
	public Number AudioLevel;
	[Value("totalAudioEnergy")]
	public Number TotalAudioEnergy;
	[Value("totalSamplesDuration")]
	public Number TotalSamplesDuration;
	[Value("echoReturnLoss")]
	public Number EchoReturnLoss;
	[Value("echoReturnLossEnhancement")]
	public Number EchoReturnLossEnhancement;
}

[Value("RTCVideoSourceStats")]
public partial class RTCVideoSourceStats : RTCMediaSourceStats
{
	[Value("width")]
	public ulong Width;
	[Value("height")]
	public ulong Height;
	[Value("frames")]
	public ulong Frames;
	[Value("framesPerSecond")]
	public Number FramesPerSecond;
}

[Value("RTCAudioPlayoutStats")]
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

[Value("RTCPeerConnectionStats")]
public partial class RTCPeerConnectionStats : RTCStats
{
	[Value("dataChannelsOpened")]
	public ulong DataChannelsOpened;
	[Value("dataChannelsClosed")]
	public ulong DataChannelsClosed;
}

[Value("RTCDataChannelStats")]
public partial class RTCDataChannelStats : RTCStats
{
	[Value("label")]
	public DOMString Label;
	[Value("protocol")]
	public DOMString Protocol;
	[Value("dataChannelIdentifier")]
	public ushort DataChannelIdentifier;
	[Value("state")]
	public required RTCDataChannelState State;
	[Value("messagesSent")]
	public ulong MessagesSent;
	[Value("bytesSent")]
	public ulong BytesSent;
	[Value("messagesReceived")]
	public ulong MessagesReceived;
	[Value("bytesReceived")]
	public ulong BytesReceived;
}

[Value("RTCTransportStats")]
public partial class RTCTransportStats : RTCStats
{
	[Value("packetsSent")]
	public ulong PacketsSent;
	[Value("packetsReceived")]
	public ulong PacketsReceived;
	[Value("bytesSent")]
	public ulong BytesSent;
	[Value("bytesReceived")]
	public ulong BytesReceived;
	[Value("iceRole")]
	public RTCIceRole IceRole;
	[Value("iceLocalUsernameFragment")]
	public DOMString IceLocalUsernameFragment;
	[Value("dtlsState")]
	public required RTCDtlsTransportState DtlsState;
	[Value("iceState")]
	public RTCIceTransportState IceState;
	[Value("selectedCandidatePairId")]
	public DOMString SelectedCandidatePairId;
	[Value("localCertificateId")]
	public DOMString LocalCertificateId;
	[Value("remoteCertificateId")]
	public DOMString RemoteCertificateId;
	[Value("tlsVersion")]
	public DOMString TlsVersion;
	[Value("dtlsCipher")]
	public DOMString DtlsCipher;
	[Value("dtlsRole")]
	public RTCDtlsRole DtlsRole;
	[Value("srtpCipher")]
	public DOMString SrtpCipher;
	[Value("selectedCandidatePairChanges")]
	public ulong SelectedCandidatePairChanges;
}

[Value("RTCIceCandidateStats")]
public partial class RTCIceCandidateStats : RTCStats
{
	[Value("transportId")]
	public required DOMString TransportId;
	[Value("address")]
	public DOMString? Address;
	[Value("port")]
	public long Port;
	[Value("protocol")]
	public DOMString Protocol;
	[Value("candidateType")]
	public required RTCIceCandidateType CandidateType;
	[Value("priority")]
	public long Priority;
	[Value("url")]
	public DOMString Url;
	[Value("relayProtocol")]
	public RTCIceServerTransportProtocol RelayProtocol;
	[Value("foundation")]
	public DOMString Foundation;
	[Value("relatedAddress")]
	public DOMString RelatedAddress;
	[Value("relatedPort")]
	public long RelatedPort;
	[Value("usernameFragment")]
	public DOMString UsernameFragment;
	[Value("tcpType")]
	public RTCIceTcpCandidateType TcpType;
}

[Value("RTCIceCandidatePairStats")]
public partial class RTCIceCandidatePairStats : RTCStats
{
	[Value("transportId")]
	public required DOMString TransportId;
	[Value("localCandidateId")]
	public required DOMString LocalCandidateId;
	[Value("remoteCandidateId")]
	public required DOMString RemoteCandidateId;
	[Value("state")]
	public required RTCStatsIceCandidatePairState State;
	[Value("nominated")]
	public bool Nominated;
	[Value("packetsSent")]
	public ulong PacketsSent;
	[Value("packetsReceived")]
	public ulong PacketsReceived;
	[Value("bytesSent")]
	public ulong BytesSent;
	[Value("bytesReceived")]
	public ulong BytesReceived;
	[Value("lastPacketSentTimestamp")]
	public DOMHighResTimeStamp LastPacketSentTimestamp;
	[Value("lastPacketReceivedTimestamp")]
	public DOMHighResTimeStamp LastPacketReceivedTimestamp;
	[Value("totalRoundTripTime")]
	public Number TotalRoundTripTime;
	[Value("currentRoundTripTime")]
	public Number CurrentRoundTripTime;
	[Value("availableOutgoingBitrate")]
	public Number AvailableOutgoingBitrate;
	[Value("availableIncomingBitrate")]
	public Number AvailableIncomingBitrate;
	[Value("requestsReceived")]
	public ulong RequestsReceived;
	[Value("requestsSent")]
	public ulong RequestsSent;
	[Value("responsesReceived")]
	public ulong ResponsesReceived;
	[Value("responsesSent")]
	public ulong ResponsesSent;
	[Value("consentRequestsSent")]
	public ulong ConsentRequestsSent;
	[Value("packetsDiscardedOnSend")]
	public ulong PacketsDiscardedOnSend;
	[Value("bytesDiscardedOnSend")]
	public ulong BytesDiscardedOnSend;
}

[Value("RTCCertificateStats")]
public partial class RTCCertificateStats : RTCStats
{
	[Value("fingerprint")]
	public required DOMString Fingerprint;
	[Value("fingerprintAlgorithm")]
	public required DOMString FingerprintAlgorithm;
	[Value("base64Certificate")]
	public required DOMString Base64Certificate;
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

[Value("RTCIceServer")]
public partial class RTCIceServer
{
	[Value("urls")]
	public required Union230 Urls;
	[Value("username")]
	public DOMString Username;
	[Value("credential")]
	public DOMString Credential;
}

[Value("RTCOfferAnswerOptions")]
public partial class RTCOfferAnswerOptions
{
}

[Value("RTCOfferOptions")]
public partial class RTCOfferOptions : RTCOfferAnswerOptions
{
	[Value("iceRestart")]
	public bool IceRestart;
}

[Value("RTCAnswerOptions")]
public partial class RTCAnswerOptions : RTCOfferAnswerOptions
{
}

public partial class RTCPeerConnection : EventTarget
{
		public RTCPeerConnection(RTCConfiguration configuration = default) { }
	[Value("createOffer")]
	public Task<RTCSessionDescriptionInit> CreateOffer(RTCOfferOptions options = default) { throw new System.NotImplementedException(); }
	[Value("createAnswer")]
	public Task<RTCSessionDescriptionInit> CreateAnswer(RTCAnswerOptions options = default) { throw new System.NotImplementedException(); }
	[Value("setLocalDescription")]
	public Task<Undefined> SetLocalDescription(RTCLocalSessionDescriptionInit description = default) { throw new System.NotImplementedException(); }
	[Value("localDescription")]
	public RTCSessionDescription? LocalDescription { get; }
	[Value("currentLocalDescription")]
	public RTCSessionDescription? CurrentLocalDescription { get; }
	[Value("pendingLocalDescription")]
	public RTCSessionDescription? PendingLocalDescription { get; }
	[Value("setRemoteDescription")]
	public Task<Undefined> SetRemoteDescription(RTCSessionDescriptionInit description) { throw new System.NotImplementedException(); }
	[Value("remoteDescription")]
	public RTCSessionDescription? RemoteDescription { get; }
	[Value("currentRemoteDescription")]
	public RTCSessionDescription? CurrentRemoteDescription { get; }
	[Value("pendingRemoteDescription")]
	public RTCSessionDescription? PendingRemoteDescription { get; }
	[Value("addIceCandidate")]
	public Task<Undefined> AddIceCandidate(RTCIceCandidateInit candidate = default) { throw new System.NotImplementedException(); }
	[Value("signalingState")]
	public RTCSignalingState SignalingState { get; }
	[Value("iceGatheringState")]
	public RTCIceGatheringState IceGatheringState { get; }
	[Value("iceConnectionState")]
	public RTCIceConnectionState IceConnectionState { get; }
	[Value("connectionState")]
	public RTCPeerConnectionState ConnectionState { get; }
	[Value("canTrickleIceCandidates")]
	public bool? CanTrickleIceCandidates { get; }
	[Value("restartIce")]
	public Undefined RestartIce() { throw new System.NotImplementedException(); }
	[Value("getConfiguration")]
	public RTCConfiguration GetConfiguration() { throw new System.NotImplementedException(); }
	[Value("setConfiguration")]
	public Undefined SetConfiguration(RTCConfiguration configuration = default) { throw new System.NotImplementedException(); }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	[Value("onnegotiationneeded")]
	public EventHandler Onnegotiationneeded { get; set; }
	[Value("onicecandidate")]
	public EventHandler Onicecandidate { get; set; }
	[Value("onicecandidateerror")]
	public EventHandler Onicecandidateerror { get; set; }
	[Value("onsignalingstatechange")]
	public EventHandler Onsignalingstatechange { get; set; }
	[Value("oniceconnectionstatechange")]
	public EventHandler Oniceconnectionstatechange { get; set; }
	[Value("onicegatheringstatechange")]
	public EventHandler Onicegatheringstatechange { get; set; }
	[Value("onconnectionstatechange")]
	public EventHandler Onconnectionstatechange { get; set; }
	[Value("createOffer")]
	public Task<Undefined> CreateOffer(RTCSessionDescriptionCallback successCallback, RTCPeerConnectionErrorCallback failureCallback, RTCOfferOptions options = default) { throw new System.NotImplementedException(); }
	[Value("setLocalDescription")]
	public Task<Undefined> SetLocalDescription(RTCLocalSessionDescriptionInit description, VoidFunction successCallback, RTCPeerConnectionErrorCallback failureCallback) { throw new System.NotImplementedException(); }
	[Value("createAnswer")]
	public Task<Undefined> CreateAnswer(RTCSessionDescriptionCallback successCallback, RTCPeerConnectionErrorCallback failureCallback) { throw new System.NotImplementedException(); }
	[Value("setRemoteDescription")]
	public Task<Undefined> SetRemoteDescription(RTCSessionDescriptionInit description, VoidFunction successCallback, RTCPeerConnectionErrorCallback failureCallback) { throw new System.NotImplementedException(); }
	[Value("addIceCandidate")]
	public Task<Undefined> AddIceCandidate(RTCIceCandidateInit candidate, VoidFunction successCallback, RTCPeerConnectionErrorCallback failureCallback) { throw new System.NotImplementedException(); }
	public RTCPeerConnection() { }
}

public partial class RTCOfferOptions
{
	[Value("offerToReceiveAudio")]
	public bool OfferToReceiveAudio;
	[Value("offerToReceiveVideo")]
	public bool OfferToReceiveVideo;
}

[Value("RTCSessionDescription")]
public partial class RTCSessionDescription
{
		public RTCSessionDescription(RTCSessionDescriptionInit descriptionInitDict) { }
	[Value("type")]
	public RTCSdpType Type { get; }
	[Value("sdp")]
	public DOMString Sdp { get; }
	[Value("toJSON")]
	public RTCSessionDescriptionInit ToJSON() { throw new System.NotImplementedException(); }
	public RTCSessionDescription() { }
}

[Value("RTCSessionDescriptionInit")]
public partial class RTCSessionDescriptionInit
{
	[Value("type")]
	public required RTCSdpType Type;
	[Value("sdp")]
	public DOMString Sdp;
}

[Value("RTCLocalSessionDescriptionInit")]
public partial class RTCLocalSessionDescriptionInit
{
	[Value("type")]
	public RTCSdpType Type;
	[Value("sdp")]
	public DOMString Sdp;
}

[Value("RTCIceCandidate")]
public partial class RTCIceCandidate
{
		public RTCIceCandidate(RTCIceCandidateInit candidateInitDict = default) { }
	[Value("candidate")]
	public DOMString Candidate { get; }
	[Value("sdpMid")]
	public DOMString? SdpMid { get; }
	[Value("sdpMLineIndex")]
	public ushort? SdpMLineIndex { get; }
	[Value("foundation")]
	public DOMString? Foundation { get; }
	[Value("component")]
	public RTCIceComponent? Component { get; }
	[Value("priority")]
	public ulong? Priority { get; }
	[Value("address")]
	public DOMString? Address { get; }
	[Value("protocol")]
	public RTCIceProtocol? Protocol { get; }
	[Value("port")]
	public ushort? Port { get; }
	[Value("type")]
	public RTCIceCandidateType? Type { get; }
	[Value("tcpType")]
	public RTCIceTcpCandidateType? TcpType { get; }
	[Value("relatedAddress")]
	public DOMString? RelatedAddress { get; }
	[Value("relatedPort")]
	public ushort? RelatedPort { get; }
	[Value("usernameFragment")]
	public DOMString? UsernameFragment { get; }
	[Value("relayProtocol")]
	public RTCIceServerTransportProtocol? RelayProtocol { get; }
	[Value("url")]
	public DOMString? Url { get; }
	[Value("toJSON")]
	public RTCIceCandidateInit ToJSON() { throw new System.NotImplementedException(); }
	public RTCIceCandidate() { }
}

[Value("RTCIceCandidateInit")]
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

[Value("RTCPeerConnectionIceEvent")]
public partial class RTCPeerConnectionIceEvent : Event
{
		public RTCPeerConnectionIceEvent(DOMString type, RTCPeerConnectionIceEventInit eventInitDict = default) { }
	[Value("candidate")]
	public RTCIceCandidate? Candidate { get; }
	[Value("url")]
	public DOMString? Url { get; }
	public RTCPeerConnectionIceEvent() { }
}

[Value("RTCPeerConnectionIceEventInit")]
public partial class RTCPeerConnectionIceEventInit : EventInit
{
	[Value("candidate")]
	public RTCIceCandidate? Candidate;
	[Value("url")]
	public DOMString? Url;
}

[Value("RTCPeerConnectionIceErrorEvent")]
public partial class RTCPeerConnectionIceErrorEvent : Event
{
		public RTCPeerConnectionIceErrorEvent(DOMString type, RTCPeerConnectionIceErrorEventInit eventInitDict) { }
	[Value("address")]
	public DOMString? Address { get; }
	[Value("port")]
	public ushort? Port { get; }
	[Value("url")]
	public DOMString Url { get; }
	[Value("errorCode")]
	public ushort ErrorCode { get; }
	[Value("errorText")]
	public USVString ErrorText { get; }
	public RTCPeerConnectionIceErrorEvent() { }
}

[Value("RTCPeerConnectionIceErrorEventInit")]
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

public partial class RTCPeerConnection
{
	[Value("generateCertificate")]
	public static Task<RTCCertificate> GenerateCertificate(AlgorithmIdentifier keygenAlgorithm) { throw new System.NotImplementedException(); }
}

[Value("RTCCertificateExpiration")]
public partial class RTCCertificateExpiration
{
	[Value("expires")]
	public ulong Expires;
}

[Value("RTCCertificate")]
public partial class RTCCertificate
{
	[Value("expires")]
	public EpochTimeStamp Expires { get; }
	[Value("getFingerprints")]
	public List<RTCDtlsFingerprint> GetFingerprints() { throw new System.NotImplementedException(); }
}

public partial class RTCPeerConnection
{
	[Value("getSenders")]
	public List<RTCRtpSender> GetSenders() { throw new System.NotImplementedException(); }
	[Value("getReceivers")]
	public List<RTCRtpReceiver> GetReceivers() { throw new System.NotImplementedException(); }
	[Value("getTransceivers")]
	public List<RTCRtpTransceiver> GetTransceivers() { throw new System.NotImplementedException(); }
	[Value("addTrack")]
	public RTCRtpSender AddTrack(MediaStreamTrack track, params MediaStream[] streams) { throw new System.NotImplementedException(); }
	[Value("removeTrack")]
	public Undefined RemoveTrack(RTCRtpSender sender) { throw new System.NotImplementedException(); }
	[Value("addTransceiver")]
	public RTCRtpTransceiver AddTransceiver(Union231 trackOrKind, RTCRtpTransceiverInit init = default) { throw new System.NotImplementedException(); }
	[Value("ontrack")]
	public EventHandler Ontrack { get; set; }
}

[Value("RTCRtpTransceiverInit")]
public partial class RTCRtpTransceiverInit
{
	[Value("direction")]
	public RTCRtpTransceiverDirection Direction;
	[Value("streams")]
	public List<MediaStream> Streams;
	[Value("sendEncodings")]
	public List<RTCRtpEncodingParameters> SendEncodings;
}

public partial class RTCRtpSender
{
	[Value("track")]
	public MediaStreamTrack? Track { get; }
	[Value("transport")]
	public RTCDtlsTransport? Transport { get; }
	[Value("getCapabilities")]
	public static RTCRtpCapabilities? GetCapabilities(DOMString kind) { throw new System.NotImplementedException(); }
	[Value("setParameters")]
	public Task<Undefined> SetParameters(RTCRtpSendParameters parameters, RTCSetParameterOptions setParameterOptions = default) { throw new System.NotImplementedException(); }
	[Value("getParameters")]
	public RTCRtpSendParameters GetParameters() { throw new System.NotImplementedException(); }
	[Value("replaceTrack")]
	public Task<Undefined> ReplaceTrack(MediaStreamTrack? withTrack) { throw new System.NotImplementedException(); }
	[Value("setStreams")]
	public Undefined SetStreams(params MediaStream[] streams) { throw new System.NotImplementedException(); }
	[Value("getStats")]
	public Task<RTCStatsReport> GetStats() { throw new System.NotImplementedException(); }
}

[Value("RTCRtpParameters")]
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

[Value("RTCRtpReceiveParameters")]
public partial class RTCRtpReceiveParameters : RTCRtpParameters
{
}

[Value("RTCRtpCodingParameters")]
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

[Value("RTCRtcpParameters")]
public partial class RTCRtcpParameters
{
	[Value("cname")]
	public DOMString Cname;
	[Value("reducedSize")]
	public bool ReducedSize;
}

[Value("RTCRtpHeaderExtensionParameters")]
public partial class RTCRtpHeaderExtensionParameters
{
	[Value("uri")]
	public required DOMString Uri;
	[Value("id")]
	public required ushort Id;
	[Value("encrypted")]
	public bool Encrypted;
}

[Value("RTCRtpCodec")]
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

[Value("RTCRtpCodecParameters")]
public partial class RTCRtpCodecParameters : RTCRtpCodec
{
	[Value("payloadType")]
	public required byte PayloadType;
}

[Value("RTCRtpCapabilities")]
public partial class RTCRtpCapabilities
{
	[Value("codecs")]
	public required List<RTCRtpCodec> Codecs;
	[Value("headerExtensions")]
	public required List<RTCRtpHeaderExtensionCapability> HeaderExtensions;
}

[Value("RTCRtpHeaderExtensionCapability")]
public partial class RTCRtpHeaderExtensionCapability
{
	[Value("uri")]
	public required DOMString Uri;
}

[Value("RTCSetParameterOptions")]
public partial class RTCSetParameterOptions
{
}

public partial class RTCRtpReceiver
{
	[Value("track")]
	public MediaStreamTrack Track { get; }
	[Value("transport")]
	public RTCDtlsTransport? Transport { get; }
	[Value("getCapabilities")]
	public static RTCRtpCapabilities? GetCapabilities(DOMString kind) { throw new System.NotImplementedException(); }
	[Value("getParameters")]
	public RTCRtpReceiveParameters GetParameters() { throw new System.NotImplementedException(); }
	[Value("getContributingSources")]
	public List<RTCRtpContributingSource> GetContributingSources() { throw new System.NotImplementedException(); }
	[Value("getSynchronizationSources")]
	public List<RTCRtpSynchronizationSource> GetSynchronizationSources() { throw new System.NotImplementedException(); }
	[Value("getStats")]
	public Task<RTCStatsReport> GetStats() { throw new System.NotImplementedException(); }
	[Value("jitterBufferTarget")]
	public DOMHighResTimeStamp? JitterBufferTarget { get; set; }
}

[Value("RTCRtpContributingSource")]
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

[Value("RTCRtpSynchronizationSource")]
public partial class RTCRtpSynchronizationSource : RTCRtpContributingSource
{
}

[Value("RTCRtpTransceiver")]
public partial class RTCRtpTransceiver
{
	[Value("mid")]
	public DOMString? Mid { get; }
	[Value("sender")]
	public RTCRtpSender Sender { get; }
	[Value("receiver")]
	public RTCRtpReceiver Receiver { get; }
	[Value("direction")]
	public RTCRtpTransceiverDirection Direction { get; set; }
	[Value("currentDirection")]
	public RTCRtpTransceiverDirection? CurrentDirection { get; }
	[Value("stop")]
	public Undefined Stop() { throw new System.NotImplementedException(); }
	[Value("setCodecPreferences")]
	public Undefined SetCodecPreferences(List<RTCRtpCodec> codecs) { throw new System.NotImplementedException(); }
}

[Value("RTCDtlsTransport")]
public partial class RTCDtlsTransport : EventTarget
{
	[Value("iceTransport")]
	public RTCIceTransport IceTransport { get; }
	[Value("state")]
	public RTCDtlsTransportState State { get; }
	[Value("getRemoteCertificates")]
	public List<ArrayBuffer> GetRemoteCertificates() { throw new System.NotImplementedException(); }
	[Value("onstatechange")]
	public EventHandler Onstatechange { get; set; }
	[Value("onerror")]
	public EventHandler Onerror { get; set; }
}

[Value("RTCDtlsFingerprint")]
public partial class RTCDtlsFingerprint
{
	[Value("algorithm")]
	public DOMString Algorithm;
	[Value("value")]
	public DOMString Value;
}

public partial class RTCIceTransport : EventTarget
{
	[Value("role")]
	public RTCIceRole Role { get; }
	[Value("component")]
	public RTCIceComponent Component { get; }
	[Value("state")]
	public RTCIceTransportState State { get; }
	[Value("gatheringState")]
	public RTCIceGathererState GatheringState { get; }
	[Value("getLocalCandidates")]
	public List<RTCIceCandidate> GetLocalCandidates() { throw new System.NotImplementedException(); }
	[Value("getRemoteCandidates")]
	public List<RTCIceCandidate> GetRemoteCandidates() { throw new System.NotImplementedException(); }
	[Value("getSelectedCandidatePair")]
	public RTCIceCandidatePair? GetSelectedCandidatePair() { throw new System.NotImplementedException(); }
	[Value("getLocalParameters")]
	public RTCIceParameters? GetLocalParameters() { throw new System.NotImplementedException(); }
	[Value("getRemoteParameters")]
	public RTCIceParameters? GetRemoteParameters() { throw new System.NotImplementedException(); }
	[Value("onstatechange")]
	public EventHandler Onstatechange { get; set; }
	[Value("ongatheringstatechange")]
	public EventHandler Ongatheringstatechange { get; set; }
	[Value("onselectedcandidatepairchange")]
	public EventHandler Onselectedcandidatepairchange { get; set; }
}

public partial class RTCIceParameters
{
	[Value("usernameFragment")]
	public DOMString UsernameFragment;
	[Value("password")]
	public DOMString Password;
}

[Value("RTCIceCandidatePair")]
public partial class RTCIceCandidatePair
{
	[Value("local")]
	public RTCIceCandidate Local { get; }
	[Value("remote")]
	public RTCIceCandidate Remote { get; }
}

[Value("RTCTrackEvent")]
public partial class RTCTrackEvent : Event
{
		public RTCTrackEvent(DOMString type, RTCTrackEventInit eventInitDict) { }
	[Value("receiver")]
	public RTCRtpReceiver Receiver { get; }
	[Value("track")]
	public MediaStreamTrack Track { get; }
	[Value("streams")]
	public MediaStream[] Streams { get; }
	[Value("transceiver")]
	public RTCRtpTransceiver Transceiver { get; }
	public RTCTrackEvent() { }
}

[Value("RTCTrackEventInit")]
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

public partial class RTCPeerConnection
{
	[Value("sctp")]
	public RTCSctpTransport? Sctp { get; }
	[Value("createDataChannel")]
	public RTCDataChannel CreateDataChannel(USVString label, RTCDataChannelInit dataChannelDict = default) { throw new System.NotImplementedException(); }
	[Value("ondatachannel")]
	public EventHandler Ondatachannel { get; set; }
}

[Value("RTCSctpTransport")]
public partial class RTCSctpTransport : EventTarget
{
	[Value("transport")]
	public RTCDtlsTransport Transport { get; }
	[Value("state")]
	public RTCSctpTransportState State { get; }
	[Value("maxMessageSize")]
	public double MaxMessageSize { get; }
	[Value("maxChannels")]
	public ushort? MaxChannels { get; }
	[Value("onstatechange")]
	public EventHandler Onstatechange { get; set; }
}

public partial class RTCDataChannel : EventTarget
{
	[Value("label")]
	public USVString Label { get; }
	[Value("ordered")]
	public bool Ordered { get; }
	[Value("maxPacketLifeTime")]
	public ushort? MaxPacketLifeTime { get; }
	[Value("maxRetransmits")]
	public ushort? MaxRetransmits { get; }
	[Value("protocol")]
	public USVString Protocol { get; }
	[Value("negotiated")]
	public bool Negotiated { get; }
	[Value("id")]
	public ushort? Id { get; }
	[Value("readyState")]
	public RTCDataChannelState ReadyState { get; }
	[Value("bufferedAmount")]
	public ulong BufferedAmount { get; }
	[Value("bufferedAmountLowThreshold")]
	public ulong BufferedAmountLowThreshold { get; set; }
	[Value("onopen")]
	public EventHandler Onopen { get; set; }
	[Value("onbufferedamountlow")]
	public EventHandler Onbufferedamountlow { get; set; }
	[Value("onerror")]
	public EventHandler Onerror { get; set; }
	[Value("onclosing")]
	public EventHandler Onclosing { get; set; }
	[Value("onclose")]
	public EventHandler Onclose { get; set; }
	[Value("close")]
	public Undefined Close() { throw new System.NotImplementedException(); }
	[Value("onmessage")]
	public EventHandler Onmessage { get; set; }
	[Value("binaryType")]
	public BinaryType BinaryType { get; set; }
	[Value("send")]
	public Undefined Send(USVString data) { throw new System.NotImplementedException(); }
	[Value("send")]
	public Undefined Send(Blob data) { throw new System.NotImplementedException(); }
	[Value("send")]
	public Undefined Send(ArrayBuffer data) { throw new System.NotImplementedException(); }
	[Value("send")]
	public Undefined Send(ArrayBufferView data) { throw new System.NotImplementedException(); }
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

[Value("RTCDataChannelEvent")]
public partial class RTCDataChannelEvent : Event
{
		public RTCDataChannelEvent(DOMString type, RTCDataChannelEventInit eventInitDict) { }
	[Value("channel")]
	public RTCDataChannel Channel { get; }
	public RTCDataChannelEvent() { }
}

[Value("RTCDataChannelEventInit")]
public partial class RTCDataChannelEventInit : EventInit
{
	[Value("channel")]
	public required RTCDataChannel Channel;
}

public partial class RTCRtpSender
{
	[Value("dtmf")]
	public RTCDTMFSender? Dtmf { get; }
}

[Value("RTCDTMFSender")]
public partial class RTCDTMFSender : EventTarget
{
	[Value("insertDTMF")]
	public Undefined InsertDTMF(DOMString tones, ulong duration = default, ulong interToneGap = default) { throw new System.NotImplementedException(); }
	[Value("ontonechange")]
	public EventHandler Ontonechange { get; set; }
	[Value("canInsertDTMF")]
	public bool CanInsertDTMF { get; }
	[Value("toneBuffer")]
	public DOMString ToneBuffer { get; }
}

[Value("RTCDTMFToneChangeEvent")]
public partial class RTCDTMFToneChangeEvent : Event
{
		public RTCDTMFToneChangeEvent(DOMString type, RTCDTMFToneChangeEventInit eventInitDict = default) { }
	[Value("tone")]
	public DOMString Tone { get; }
	public RTCDTMFToneChangeEvent() { }
}

[Value("RTCDTMFToneChangeEventInit")]
public partial class RTCDTMFToneChangeEventInit : EventInit
{
	[Value("tone")]
	public DOMString Tone;
}

public partial class RTCPeerConnection
{
	[Value("getStats")]
	public Task<RTCStatsReport> GetStats(MediaStreamTrack? selector = default) { throw new System.NotImplementedException(); }
}

[Value("RTCStatsReport")]
public partial class RTCStatsReport
{
	
}

[Value("RTCStats")]
public partial class RTCStats
{
	[Value("timestamp")]
	public required DOMHighResTimeStamp Timestamp;
	[Value("type")]
	public required RTCStatsType Type;
	[Value("id")]
	public required DOMString Id;
}

public partial class RTCError : DOMException
{
		public RTCError(RTCErrorInit init, DOMString message = default) { }
	[Value("errorDetail")]
	public RTCErrorDetailType ErrorDetail { get; }
	[Value("sdpLineNumber")]
	public long? SdpLineNumber { get; }
	[Value("sctpCauseCode")]
	public long? SctpCauseCode { get; }
	[Value("receivedAlert")]
	public ulong? ReceivedAlert { get; }
	[Value("sentAlert")]
	public ulong? SentAlert { get; }
	public RTCError() { }
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

[Value("RTCErrorEvent")]
public partial class RTCErrorEvent : Event
{
		public RTCErrorEvent(DOMString type, RTCErrorEventInit eventInitDict) { }
	[Value("error")]
	public RTCError Error { get; }
	public RTCErrorEvent() { }
}

[Value("RTCErrorEventInit")]
public partial class RTCErrorEventInit : EventInit
{
	[Value("error")]
	public required RTCError Error;
}

[Value("WebSocket")]
public partial class WebSocket : EventTarget
{
		public WebSocket(USVString url, Union232 protocols = default) { }
	[Value("url")]
	public USVString Url { get; }
	[Value("CONNECTING")]
	public const ushort CONNECTING = 0;
	[Value("OPEN")]
	public const ushort OPEN = 1;
	[Value("CLOSING")]
	public const ushort CLOSING = 2;
	[Value("CLOSED")]
	public const ushort CLOSED = 3;
	[Value("readyState")]
	public ushort ReadyState { get; }
	[Value("bufferedAmount")]
	public ulong BufferedAmount { get; }
	[Value("onopen")]
	public EventHandler Onopen { get; set; }
	[Value("onerror")]
	public EventHandler Onerror { get; set; }
	[Value("onclose")]
	public EventHandler Onclose { get; set; }
	[Value("extensions")]
	public DOMString Extensions { get; }
	[Value("protocol")]
	public DOMString Protocol { get; }
	[Value("close")]
	public Undefined Close(ushort code = default, USVString reason = default) { throw new System.NotImplementedException(); }
	[Value("onmessage")]
	public EventHandler Onmessage { get; set; }
	[Value("binaryType")]
	public BinaryType BinaryType { get; set; }
	[Value("send")]
	public Undefined Send(Union233 data) { throw new System.NotImplementedException(); }
	public WebSocket() { }
}

[Value("CloseEvent")]
public partial class CloseEvent : Event
{
		public CloseEvent(DOMString type, CloseEventInit eventInitDict = default) { }
	[Value("wasClean")]
	public bool WasClean { get; }
	[Value("code")]
	public ushort Code { get; }
	[Value("reason")]
	public USVString Reason { get; }
	public CloseEvent() { }
}

[Value("CloseEventInit")]
public partial class CloseEventInit : EventInit
{
	[Value("wasClean")]
	public bool WasClean;
	[Value("code")]
	public ushort Code;
	[Value("reason")]
	public USVString Reason;
}

[Value("WebTransportDatagramDuplexStream")]
public partial class WebTransportDatagramDuplexStream
{
	[Value("readable")]
	public ReadableStream Readable { get; }
	[Value("writable")]
	public WritableStream Writable { get; }
	[Value("maxDatagramSize")]
	public ulong MaxDatagramSize { get; }
	[Value("incomingMaxAge")]
	public double? IncomingMaxAge { get; set; }
	[Value("outgoingMaxAge")]
	public double? OutgoingMaxAge { get; set; }
	[Value("incomingHighWaterMark")]
	public double IncomingHighWaterMark { get; set; }
	[Value("outgoingHighWaterMark")]
	public double OutgoingHighWaterMark { get; set; }
}

[Value("WebTransport")]
public partial class WebTransport
{
		public WebTransport(USVString url, WebTransportOptions options = default) { }
	[Value("getStats")]
	public Task<WebTransportConnectionStats> GetStats() { throw new System.NotImplementedException(); }
	[Value("ready")]
	public Task<Undefined> Ready { get; }
	[Value("reliability")]
	public WebTransportReliabilityMode Reliability { get; }
	[Value("congestionControl")]
	public WebTransportCongestionControl CongestionControl { get; }
	[Value("anticipatedConcurrentIncomingUnidirectionalStreams")]
	public ushort? AnticipatedConcurrentIncomingUnidirectionalStreams { get; set; }
	[Value("anticipatedConcurrentIncomingBidirectionalStreams")]
	public ushort? AnticipatedConcurrentIncomingBidirectionalStreams { get; set; }
	[Value("protocol")]
	public DOMString Protocol { get; }
	[Value("closed")]
	public Task<WebTransportCloseInfo> Closed { get; }
	[Value("draining")]
	public Task<Undefined> Draining { get; }
	[Value("close")]
	public Undefined Close(WebTransportCloseInfo closeInfo = default) { throw new System.NotImplementedException(); }
	[Value("datagrams")]
	public WebTransportDatagramDuplexStream Datagrams { get; }
	[Value("createBidirectionalStream")]
	public Task<WebTransportBidirectionalStream> CreateBidirectionalStream(WebTransportSendStreamOptions options = default) { throw new System.NotImplementedException(); }
	[Value("incomingBidirectionalStreams")]
	public ReadableStream IncomingBidirectionalStreams { get; }
	[Value("createUnidirectionalStream")]
	public Task<WebTransportSendStream> CreateUnidirectionalStream(WebTransportSendStreamOptions options = default) { throw new System.NotImplementedException(); }
	[Value("incomingUnidirectionalStreams")]
	public ReadableStream IncomingUnidirectionalStreams { get; }
	[Value("createSendGroup")]
	public WebTransportSendGroup CreateSendGroup() { throw new System.NotImplementedException(); }
	[Value("supportsReliableOnly")]
	public static bool SupportsReliableOnly { get; }
	public WebTransport() { }
}

[Value("WebTransportHash")]
public partial class WebTransportHash
{
	[Value("algorithm")]
	public DOMString Algorithm;
	[Value("value")]
	public BufferSource Value;
}

[Value("WebTransportOptions")]
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

[Value("WebTransportCloseInfo")]
public partial class WebTransportCloseInfo
{
	[Value("closeCode")]
	public ulong CloseCode;
	[Value("reason")]
	public USVString Reason;
}

[Value("WebTransportSendStreamOptions")]
public partial class WebTransportSendStreamOptions
{
	[Value("sendGroup")]
	public WebTransportSendGroup? SendGroup;
	[Value("sendOrder")]
	public long SendOrder;
	[Value("waitUntilAvailable")]
	public bool WaitUntilAvailable;
}

[Value("WebTransportConnectionStats")]
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

[Value("WebTransportDatagramStats")]
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

[Value("WebTransportSendStream")]
public partial class WebTransportSendStream : WritableStream
{
	[Value("sendGroup")]
	public WebTransportSendGroup? SendGroup { get; set; }
	[Value("sendOrder")]
	public long SendOrder { get; set; }
	[Value("getStats")]
	public Task<WebTransportSendStreamStats> GetStats() { throw new System.NotImplementedException(); }
	[Value("getWriter")]
	public WebTransportWriter GetWriter() { throw new System.NotImplementedException(); }
}

[Value("WebTransportSendStreamStats")]
public partial class WebTransportSendStreamStats
{
	[Value("bytesWritten")]
	public ulong BytesWritten;
	[Value("bytesSent")]
	public ulong BytesSent;
	[Value("bytesAcknowledged")]
	public ulong BytesAcknowledged;
}

[Value("WebTransportSendGroup")]
public partial class WebTransportSendGroup
{
	[Value("getStats")]
	public Task<WebTransportSendStreamStats> GetStats() { throw new System.NotImplementedException(); }
}

[Value("WebTransportReceiveStream")]
public partial class WebTransportReceiveStream : ReadableStream
{
	[Value("getStats")]
	public Task<WebTransportReceiveStreamStats> GetStats() { throw new System.NotImplementedException(); }
}

[Value("WebTransportReceiveStreamStats")]
public partial class WebTransportReceiveStreamStats
{
	[Value("bytesReceived")]
	public ulong BytesReceived;
	[Value("bytesRead")]
	public ulong BytesRead;
}

[Value("WebTransportBidirectionalStream")]
public partial class WebTransportBidirectionalStream
{
	[Value("readable")]
	public WebTransportReceiveStream Readable { get; }
	[Value("writable")]
	public WebTransportSendStream Writable { get; }
}

[Value("WebTransportWriter")]
public partial class WebTransportWriter : WritableStreamDefaultWriter
{
	[Value("atomicWrite")]
	public Task<Undefined> AtomicWrite(dynamic chunk = default) { throw new System.NotImplementedException(); }
}

[Value("WebTransportError")]
public partial class WebTransportError : DOMException
{
		public WebTransportError(DOMString message = default, WebTransportErrorOptions options = default) { }
	[Value("source")]
	public WebTransportErrorSource Source { get; }
	[Value("streamErrorCode")]
	public ulong? StreamErrorCode { get; }
	public WebTransportError() { }
}

[Value("WebTransportErrorOptions")]
public partial class WebTransportErrorOptions
{
	[Value("source")]
	public WebTransportErrorSource Source;
	[Value("streamErrorCode")]
	public ulong? StreamErrorCode;
}

[Value("USBDeviceFilter")]
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

[Value("USBDeviceRequestOptions")]
public partial class USBDeviceRequestOptions
{
	[Value("filters")]
	public required List<USBDeviceFilter> Filters;
	[Value("exclusionFilters")]
	public List<USBDeviceFilter> ExclusionFilters;
}

[Value("USB")]
public partial class USB : EventTarget
{
	[Value("onconnect")]
	public EventHandler Onconnect { get; set; }
	[Value("ondisconnect")]
	public EventHandler Ondisconnect { get; set; }
	[Value("getDevices")]
	public Task<List<USBDevice>> GetDevices() { throw new System.NotImplementedException(); }
	[Value("requestDevice")]
	public Task<USBDevice> RequestDevice(USBDeviceRequestOptions options) { throw new System.NotImplementedException(); }
}

public partial class Navigator
{
	[Value("usb")]
	public USB Usb { get; }
}

public partial class WorkerNavigator
{
	[Value("usb")]
	public USB Usb { get; }
}

[Value("USBConnectionEventInit")]
public partial class USBConnectionEventInit : EventInit
{
	[Value("device")]
	public required USBDevice Device;
}

[Value("USBConnectionEvent")]
public partial class USBConnectionEvent : Event
{
		public USBConnectionEvent(DOMString type, USBConnectionEventInit eventInitDict) { }
	[Value("device")]
	public USBDevice Device { get; }
	public USBConnectionEvent() { }
}

[Value("USBInTransferResult")]
public partial class USBInTransferResult
{
		public USBInTransferResult(USBTransferStatus status, DataView? data = default) { }
	[Value("data")]
	public DataView? Data { get; }
	[Value("status")]
	public USBTransferStatus Status { get; }
	public USBInTransferResult() { }
}

[Value("USBOutTransferResult")]
public partial class USBOutTransferResult
{
		public USBOutTransferResult(USBTransferStatus status, ulong bytesWritten = default) { }
	[Value("bytesWritten")]
	public ulong BytesWritten { get; }
	[Value("status")]
	public USBTransferStatus Status { get; }
	public USBOutTransferResult() { }
}

[Value("USBIsochronousInTransferPacket")]
public partial class USBIsochronousInTransferPacket
{
		public USBIsochronousInTransferPacket(USBTransferStatus status, DataView? data = default) { }
	[Value("data")]
	public DataView? Data { get; }
	[Value("status")]
	public USBTransferStatus Status { get; }
	public USBIsochronousInTransferPacket() { }
}

[Value("USBIsochronousInTransferResult")]
public partial class USBIsochronousInTransferResult
{
		public USBIsochronousInTransferResult(List<USBIsochronousInTransferPacket> packets, DataView? data = default) { }
	[Value("data")]
	public DataView? Data { get; }
	[Value("packets")]
	public USBIsochronousInTransferPacket[] Packets { get; }
	public USBIsochronousInTransferResult() { }
}

[Value("USBIsochronousOutTransferPacket")]
public partial class USBIsochronousOutTransferPacket
{
		public USBIsochronousOutTransferPacket(USBTransferStatus status, ulong bytesWritten = default) { }
	[Value("bytesWritten")]
	public ulong BytesWritten { get; }
	[Value("status")]
	public USBTransferStatus Status { get; }
	public USBIsochronousOutTransferPacket() { }
}

[Value("USBIsochronousOutTransferResult")]
public partial class USBIsochronousOutTransferResult
{
		public USBIsochronousOutTransferResult(List<USBIsochronousOutTransferPacket> packets) { }
	[Value("packets")]
	public USBIsochronousOutTransferPacket[] Packets { get; }
	public USBIsochronousOutTransferResult() { }
}

[Value("USBDevice")]
public partial class USBDevice
{
	[Value("usbVersionMajor")]
	public byte UsbVersionMajor { get; }
	[Value("usbVersionMinor")]
	public byte UsbVersionMinor { get; }
	[Value("usbVersionSubminor")]
	public byte UsbVersionSubminor { get; }
	[Value("deviceClass")]
	public byte DeviceClass { get; }
	[Value("deviceSubclass")]
	public byte DeviceSubclass { get; }
	[Value("deviceProtocol")]
	public byte DeviceProtocol { get; }
	[Value("vendorId")]
	public ushort VendorId { get; }
	[Value("productId")]
	public ushort ProductId { get; }
	[Value("deviceVersionMajor")]
	public byte DeviceVersionMajor { get; }
	[Value("deviceVersionMinor")]
	public byte DeviceVersionMinor { get; }
	[Value("deviceVersionSubminor")]
	public byte DeviceVersionSubminor { get; }
	[Value("manufacturerName")]
	public DOMString? ManufacturerName { get; }
	[Value("productName")]
	public DOMString? ProductName { get; }
	[Value("serialNumber")]
	public DOMString? SerialNumber { get; }
	[Value("configuration")]
	public USBConfiguration? Configuration { get; }
	[Value("configurations")]
	public USBConfiguration[] Configurations { get; }
	[Value("opened")]
	public bool Opened { get; }
	[Value("open")]
	public Task<Undefined> Open() { throw new System.NotImplementedException(); }
	[Value("close")]
	public Task<Undefined> Close() { throw new System.NotImplementedException(); }
	[Value("forget")]
	public Task<Undefined> Forget() { throw new System.NotImplementedException(); }
	[Value("selectConfiguration")]
	public Task<Undefined> SelectConfiguration(byte configurationValue) { throw new System.NotImplementedException(); }
	[Value("claimInterface")]
	public Task<Undefined> ClaimInterface(byte interfaceNumber) { throw new System.NotImplementedException(); }
	[Value("releaseInterface")]
	public Task<Undefined> ReleaseInterface(byte interfaceNumber) { throw new System.NotImplementedException(); }
	[Value("selectAlternateInterface")]
	public Task<Undefined> SelectAlternateInterface(byte interfaceNumber, byte alternateSetting) { throw new System.NotImplementedException(); }
	[Value("controlTransferIn")]
	public Task<USBInTransferResult> ControlTransferIn(USBControlTransferParameters setup, ushort length) { throw new System.NotImplementedException(); }
	[Value("controlTransferOut")]
	public Task<USBOutTransferResult> ControlTransferOut(USBControlTransferParameters setup, BufferSource data = default) { throw new System.NotImplementedException(); }
	[Value("clearHalt")]
	public Task<Undefined> ClearHalt(USBDirection direction, byte endpointNumber) { throw new System.NotImplementedException(); }
	[Value("transferIn")]
	public Task<USBInTransferResult> TransferIn(byte endpointNumber, ulong length) { throw new System.NotImplementedException(); }
	[Value("transferOut")]
	public Task<USBOutTransferResult> TransferOut(byte endpointNumber, BufferSource data) { throw new System.NotImplementedException(); }
	[Value("isochronousTransferIn")]
	public Task<USBIsochronousInTransferResult> IsochronousTransferIn(byte endpointNumber, List<ulong> packetLengths) { throw new System.NotImplementedException(); }
	[Value("isochronousTransferOut")]
	public Task<USBIsochronousOutTransferResult> IsochronousTransferOut(byte endpointNumber, BufferSource data, List<ulong> packetLengths) { throw new System.NotImplementedException(); }
	[Value("reset")]
	public Task<Undefined> Reset() { throw new System.NotImplementedException(); }
}

[Value("USBControlTransferParameters")]
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

[Value("USBConfiguration")]
public partial class USBConfiguration
{
		public USBConfiguration(USBDevice device, byte configurationValue) { }
	[Value("configurationValue")]
	public byte ConfigurationValue { get; }
	[Value("configurationName")]
	public DOMString? ConfigurationName { get; }
	[Value("interfaces")]
	public USBInterface[] Interfaces { get; }
	public USBConfiguration() { }
}

[Value("USBInterface")]
public partial class USBInterface
{
		public USBInterface(USBConfiguration configuration, byte interfaceNumber) { }
	[Value("interfaceNumber")]
	public byte InterfaceNumber { get; }
	[Value("alternate")]
	public USBAlternateInterface Alternate { get; }
	[Value("alternates")]
	public USBAlternateInterface[] Alternates { get; }
	[Value("claimed")]
	public bool Claimed { get; }
	public USBInterface() { }
}

[Value("USBAlternateInterface")]
public partial class USBAlternateInterface
{
		public USBAlternateInterface(USBInterface deviceInterface, byte alternateSetting) { }
	[Value("alternateSetting")]
	public byte AlternateSetting { get; }
	[Value("interfaceClass")]
	public byte InterfaceClass { get; }
	[Value("interfaceSubclass")]
	public byte InterfaceSubclass { get; }
	[Value("interfaceProtocol")]
	public byte InterfaceProtocol { get; }
	[Value("interfaceName")]
	public DOMString? InterfaceName { get; }
	[Value("endpoints")]
	public USBEndpoint[] Endpoints { get; }
	public USBAlternateInterface() { }
}

[Value("USBEndpoint")]
public partial class USBEndpoint
{
		public USBEndpoint(USBAlternateInterface alternate, byte endpointNumber, USBDirection direction) { }
	[Value("endpointNumber")]
	public byte EndpointNumber { get; }
	[Value("direction")]
	public USBDirection Direction { get; }
	[Value("type")]
	public USBEndpointType Type { get; }
	[Value("packetSize")]
	public ulong PacketSize { get; }
	public USBEndpoint() { }
}

[Value("USBBlocklistEntry")]
public partial class USBBlocklistEntry
{
	[Value("idVendor")]
	public required ushort IdVendor;
	[Value("idProduct")]
	public required ushort IdProduct;
	[Value("bcdDevice")]
	public required ushort BcdDevice;
}

[Value("USBPermissionDescriptor")]
public partial class USBPermissionDescriptor : PermissionDescriptor
{
	[Value("filters")]
	public List<USBDeviceFilter> Filters;
	[Value("exclusionFilters")]
	public List<USBDeviceFilter> ExclusionFilters;
}

[Value("AllowedUSBDevice")]
public partial class AllowedUSBDevice
{
	[Value("vendorId")]
	public required byte VendorId;
	[Value("productId")]
	public required byte ProductId;
	[Value("serialNumber")]
	public DOMString SerialNumber;
}

[Value("USBPermissionStorage")]
public partial class USBPermissionStorage
{
	[Value("allowedDevices")]
	public List<AllowedUSBDevice> AllowedDevices;
}

[Value("USBPermissionResult")]
public partial class USBPermissionResult : PermissionStatus
{
	[Value("devices")]
	public USBDevice[] Devices { get; set; }
}

[Value("VTTCue")]
public partial class VTTCue : TextTrackCue
{
		public VTTCue(Number startTime, double endTime, DOMString text) { }
	[Value("region")]
	public VTTRegion? Region { get; set; }
	[Value("vertical")]
	public DirectionSetting Vertical { get; set; }
	[Value("snapToLines")]
	public bool SnapToLines { get; set; }
	[Value("line")]
	public LineAndPositionSetting Line { get; set; }
	[Value("lineAlign")]
	public LineAlignSetting LineAlign { get; set; }
	[Value("position")]
	public LineAndPositionSetting Position { get; set; }
	[Value("positionAlign")]
	public PositionAlignSetting PositionAlign { get; set; }
	[Value("size")]
	public Number Size { get; set; }
	[Value("align")]
	public AlignSetting Align { get; set; }
	[Value("text")]
	public DOMString Text { get; set; }
	[Value("getCueAsHTML")]
	public DocumentFragment GetCueAsHTML() { throw new System.NotImplementedException(); }
	public VTTCue() { }
}

[Value("VTTRegion")]
public partial class VTTRegion
{
		public VTTRegion() { }
	[Value("id")]
	public DOMString Id { get; set; }
	[Value("width")]
	public Number Width { get; set; }
	[Value("lines")]
	public ulong Lines { get; set; }
	[Value("regionAnchorX")]
	public Number RegionAnchorX { get; set; }
	[Value("regionAnchorY")]
	public Number RegionAnchorY { get; set; }
	[Value("viewportAnchorX")]
	public Number ViewportAnchorX { get; set; }
	[Value("viewportAnchorY")]
	public Number ViewportAnchorY { get; set; }
	[Value("scroll")]
	public ScrollSetting Scroll { get; set; }
}

public partial class XRSession
{
	[Value("environmentBlendMode")]
	public XREnvironmentBlendMode EnvironmentBlendMode { get; }
}

public partial class XRSession
{
	[Value("interactionMode")]
	public XRInteractionMode InteractionMode { get; }
}

public partial class XRView
{
	[Value("isFirstPersonObserver")]
	public bool IsFirstPersonObserver { get; }
}

[Value("XRDepthStateInit")]
public partial class XRDepthStateInit
{
	[Value("usagePreference")]
	public required List<XRDepthUsage> UsagePreference;
	[Value("dataFormatPreference")]
	public required List<XRDepthDataFormat> DataFormatPreference;
}

[Value("XRSessionInit")]
public partial class XRSessionInit
{
	[Value("depthSensing")]
	public XRDepthStateInit DepthSensing;
}

public partial class XRSession
{
	[Value("depthUsage")]
	public XRDepthUsage DepthUsage { get; }
	[Value("depthDataFormat")]
	public XRDepthDataFormat DepthDataFormat { get; }
}

[Value("XRDepthInformation")]
public partial class XRDepthInformation
{
	[Value("width")]
	public ulong Width { get; }
	[Value("height")]
	public ulong Height { get; }
	[Value("normDepthBufferFromNormView")]
	public XRRigidTransform NormDepthBufferFromNormView { get; }
	[Value("rawValueToMeters")]
	public Number RawValueToMeters { get; }
}

[Value("XRCPUDepthInformation")]
public partial class XRCPUDepthInformation : XRDepthInformation
{
	[Value("data")]
	public ArrayBuffer Data { get; }
	[Value("getDepthInMeters")]
	public Number GetDepthInMeters(Number x, Number y) { throw new System.NotImplementedException(); }
}

public partial class XRFrame
{
	[Value("getDepthInformation")]
	public XRCPUDepthInformation? GetDepthInformation(XRView view) { throw new System.NotImplementedException(); }
}

[Value("XRWebGLDepthInformation")]
public partial class XRWebGLDepthInformation : XRDepthInformation
{
	[Value("texture")]
	public WebGLTexture Texture { get; }
	[Value("textureType")]
	public XRTextureType TextureType { get; }
	[Value("imageIndex")]
	public ulong? ImageIndex { get; }
}

public partial class XRWebGLBinding
{
	[Value("getDepthInformation")]
	public XRWebGLDepthInformation? GetDepthInformation(XRView view) { throw new System.NotImplementedException(); }
}

public partial class XRSessionInit
{
	[Value("domOverlay")]
	public XRDOMOverlayInit? DomOverlay;
}

public partial class XRSession
{
	[Value("domOverlayState")]
	public XRDOMOverlayState? DomOverlayState { get; }
}

[Value("XRDOMOverlayInit")]
public partial class XRDOMOverlayInit
{
	[Value("root")]
	public required Element Root;
}

[Value("XRDOMOverlayState")]
public partial class XRDOMOverlayState
{
	[Value("type")]
	public XRDOMOverlayType Type;
}

[Value("XRInputSource")]
public partial class XRInputSource
{
	[Value("gamepad")]
	public Gamepad? Gamepad { get; }
}

public partial class XRInputSource
{
	[Value("hand")]
	public XRHand? Hand { get; }
}

[Value("XRHand")]
public partial class XRHand
{
	public XRHandJoint this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	[Value("size")]
	public ulong Size { get; }
	[Value("get")]
	public XRJointSpace Get(XRHandJoint key) { throw new System.NotImplementedException(); }
}

[Value("XRJointSpace")]
public partial class XRJointSpace : XRSpace
{
	[Value("jointName")]
	public XRHandJoint JointName { get; }
}

public partial class XRFrame
{
	[Value("getJointPose")]
	public XRJointPose? GetJointPose(XRJointSpace joint, XRSpace baseSpace) { throw new System.NotImplementedException(); }
	[Value("fillJointRadii")]
	public bool FillJointRadii(List<XRJointSpace> jointSpaces, Float32Array radii) { throw new System.NotImplementedException(); }
	[Value("fillPoses")]
	public bool FillPoses(List<XRSpace> spaces, XRSpace baseSpace, Float32Array transforms) { throw new System.NotImplementedException(); }
}

[Value("XRJointPose")]
public partial class XRJointPose : XRPose
{
	[Value("radius")]
	public Number Radius { get; }
}

[Value("XRHitTestOptionsInit")]
public partial class XRHitTestOptionsInit
{
	[Value("space")]
	public required XRSpace Space;
	[Value("entityTypes")]
	public List<XRHitTestTrackableType> EntityTypes;
	[Value("offsetRay")]
	public XRRay OffsetRay;
}

[Value("XRTransientInputHitTestOptionsInit")]
public partial class XRTransientInputHitTestOptionsInit
{
	[Value("profile")]
	public required DOMString Profile;
	[Value("entityTypes")]
	public List<XRHitTestTrackableType> EntityTypes;
	[Value("offsetRay")]
	public XRRay OffsetRay;
}

[Value("XRHitTestSource")]
public partial class XRHitTestSource
{
	[Value("cancel")]
	public Undefined Cancel() { throw new System.NotImplementedException(); }
}

[Value("XRTransientInputHitTestSource")]
public partial class XRTransientInputHitTestSource
{
	[Value("cancel")]
	public Undefined Cancel() { throw new System.NotImplementedException(); }
}

public partial class XRHitTestResult
{
	[Value("getPose")]
	public XRPose? GetPose(XRSpace baseSpace) { throw new System.NotImplementedException(); }
}

[Value("XRTransientInputHitTestResult")]
public partial class XRTransientInputHitTestResult
{
	[Value("inputSource")]
	public XRInputSource InputSource { get; }
	[Value("results")]
	public XRHitTestResult[] Results { get; }
}

public partial class XRSession
{
	[Value("requestHitTestSource")]
	public Task<XRHitTestSource> RequestHitTestSource(XRHitTestOptionsInit options) { throw new System.NotImplementedException(); }
	[Value("requestHitTestSourceForTransientInput")]
	public Task<XRTransientInputHitTestSource> RequestHitTestSourceForTransientInput(XRTransientInputHitTestOptionsInit options) { throw new System.NotImplementedException(); }
}

public partial class XRFrame
{
	[Value("getHitTestResults")]
	public List<XRHitTestResult> GetHitTestResults(XRHitTestSource hitTestSource) { throw new System.NotImplementedException(); }
	[Value("getHitTestResultsForTransientInput")]
	public List<XRTransientInputHitTestResult> GetHitTestResultsForTransientInput(XRTransientInputHitTestSource hitTestSource) { throw new System.NotImplementedException(); }
}

[Value("XRRayDirectionInit")]
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

[Value("XRRay")]
public partial class XRRay
{
		public XRRay(DOMPointInit origin = default, XRRayDirectionInit direction = default) { }
		public XRRay(XRRigidTransform transform) { }
	[Value("origin")]
	public DOMPointReadOnly Origin { get; }
	[Value("direction")]
	public DOMPointReadOnly Direction { get; }
	[Value("matrix")]
	public Float32Array Matrix { get; }
	public XRRay() { }
}

[Value("XRLightProbe")]
public partial class XRLightProbe : EventTarget
{
	[Value("probeSpace")]
	public XRSpace ProbeSpace { get; }
	[Value("onreflectionchange")]
	public EventHandler Onreflectionchange { get; set; }
}

[Value("XRLightEstimate")]
public partial class XRLightEstimate
{
	[Value("sphericalHarmonicsCoefficients")]
	public Float32Array SphericalHarmonicsCoefficients { get; }
	[Value("primaryLightDirection")]
	public DOMPointReadOnly PrimaryLightDirection { get; }
	[Value("primaryLightIntensity")]
	public DOMPointReadOnly PrimaryLightIntensity { get; }
}

[Value("XRLightProbeInit")]
public partial class XRLightProbeInit
{
	[Value("reflectionFormat")]
	public XRReflectionFormat ReflectionFormat;
}

public partial class XRSession
{
	[Value("requestLightProbe")]
	public Task<XRLightProbe> RequestLightProbe(XRLightProbeInit options = default) { throw new System.NotImplementedException(); }
	[Value("preferredReflectionFormat")]
	public XRReflectionFormat PreferredReflectionFormat { get; }
}

public partial class XRFrame
{
	[Value("getLightEstimate")]
	public XRLightEstimate? GetLightEstimate(XRLightProbe lightProbe) { throw new System.NotImplementedException(); }
}

public partial class XRWebGLBinding
{
	[Value("getReflectionCubeMap")]
	public WebGLTexture? GetReflectionCubeMap(XRLightProbe lightProbe) { throw new System.NotImplementedException(); }
}

[Value("XRPlane")]
public partial class XRPlane
{
	[Value("planeSpace")]
	public XRSpace PlaneSpace { get; }
	[Value("polygon")]
	public DOMPointReadOnly[] Polygon { get; }
	[Value("orientation")]
	public XRPlaneOrientation? Orientation { get; }
	[Value("lastChangedTime")]
	public DOMHighResTimeStamp LastChangedTime { get; }
	[Value("semanticLabel")]
	public DOMString? SemanticLabel { get; }
}

[Value("XRPlaneSet")]
public partial class XRPlaneSet
{
	
}

public partial class XRFrame
{
	[Value("detectedPlanes")]
	public XRPlaneSet DetectedPlanes { get; }
}

public partial class XRSession
{
	[Value("initiateRoomCapture")]
	public Task<Undefined> InitiateRoomCapture() { throw new System.NotImplementedException(); }
}

public partial class Navigator
{
	[Value("xr")]
	public XRSystem Xr { get; }
}

[Value("XRSystem")]
public partial class XRSystem : EventTarget
{
	[Value("isSessionSupported")]
	public Task<bool> IsSessionSupported(XRSessionMode mode) { throw new System.NotImplementedException(); }
	[Value("requestSession")]
	public Task<XRSession> RequestSession(XRSessionMode mode, XRSessionInit options = default) { throw new System.NotImplementedException(); }
	[Value("ondevicechange")]
	public EventHandler Ondevicechange { get; set; }
}

public partial class XRSessionInit
{
	[Value("requiredFeatures")]
	public List<DOMString> RequiredFeatures;
	[Value("optionalFeatures")]
	public List<DOMString> OptionalFeatures;
}

public partial class XRSession : EventTarget
{
	[Value("visibilityState")]
	public XRVisibilityState VisibilityState { get; }
	[Value("frameRate")]
	public Number? FrameRate { get; }
	[Value("supportedFrameRates")]
	public Float32Array? SupportedFrameRates { get; }
	[Value("renderState")]
	public XRRenderState RenderState { get; }
	[Value("inputSources")]
	public XRInputSourceArray InputSources { get; }
	[Value("trackedSources")]
	public XRInputSourceArray TrackedSources { get; }
	[Value("enabledFeatures")]
	public DOMString[] EnabledFeatures { get; }
	[Value("isSystemKeyboardSupported")]
	public bool IsSystemKeyboardSupported { get; }
	[Value("updateRenderState")]
	public Undefined UpdateRenderState(XRRenderStateInit state = default) { throw new System.NotImplementedException(); }
	[Value("updateTargetFrameRate")]
	public Task<Undefined> UpdateTargetFrameRate(Number rate) { throw new System.NotImplementedException(); }
	[Value("requestReferenceSpace")]
	public Task<XRReferenceSpace> RequestReferenceSpace(XRReferenceSpaceType type) { throw new System.NotImplementedException(); }
	[Value("requestAnimationFrame")]
	public ulong RequestAnimationFrame(XRFrameRequestCallback callback) { throw new System.NotImplementedException(); }
	[Value("cancelAnimationFrame")]
	public Undefined CancelAnimationFrame(ulong handle) { throw new System.NotImplementedException(); }
	[Value("end")]
	public Task<Undefined> End() { throw new System.NotImplementedException(); }
	[Value("onend")]
	public EventHandler Onend { get; set; }
	[Value("oninputsourceschange")]
	public EventHandler Oninputsourceschange { get; set; }
	[Value("onselect")]
	public EventHandler Onselect { get; set; }
	[Value("onselectstart")]
	public EventHandler Onselectstart { get; set; }
	[Value("onselectend")]
	public EventHandler Onselectend { get; set; }
	[Value("onsqueeze")]
	public EventHandler Onsqueeze { get; set; }
	[Value("onsqueezestart")]
	public EventHandler Onsqueezestart { get; set; }
	[Value("onsqueezeend")]
	public EventHandler Onsqueezeend { get; set; }
	[Value("onvisibilitychange")]
	public EventHandler Onvisibilitychange { get; set; }
	[Value("onframeratechange")]
	public EventHandler Onframeratechange { get; set; }
}

[Value("XRRenderStateInit")]
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

[Value("XRRenderState")]
public partial class XRRenderState
{
	[Value("depthNear")]
	public Number DepthNear { get; }
	[Value("depthFar")]
	public Number DepthFar { get; }
	[Value("inlineVerticalFieldOfView")]
	public Number? InlineVerticalFieldOfView { get; }
	[Value("baseLayer")]
	public XRWebGLLayer? BaseLayer { get; }
}

public partial class XRFrame
{
	[Value("session")]
	public XRSession Session { get; }
	[Value("predictedDisplayTime")]
	public DOMHighResTimeStamp PredictedDisplayTime { get; }
	[Value("getViewerPose")]
	public XRViewerPose? GetViewerPose(XRReferenceSpace referenceSpace) { throw new System.NotImplementedException(); }
	[Value("getPose")]
	public XRPose? GetPose(XRSpace space, XRSpace baseSpace) { throw new System.NotImplementedException(); }
}

[Value("XRSpace")]
public partial class XRSpace : EventTarget
{
}

[Value("XRReferenceSpace")]
public partial class XRReferenceSpace : XRSpace
{
	[Value("getOffsetReferenceSpace")]
	public XRReferenceSpace GetOffsetReferenceSpace(XRRigidTransform originOffset) { throw new System.NotImplementedException(); }
	[Value("onreset")]
	public EventHandler Onreset { get; set; }
}

[Value("XRBoundedReferenceSpace")]
public partial class XRBoundedReferenceSpace : XRReferenceSpace
{
	[Value("boundsGeometry")]
	public DOMPointReadOnly[] BoundsGeometry { get; }
}

public partial class XRView
{
	[Value("eye")]
	public XREye Eye { get; }
	[Value("projectionMatrix")]
	public Float32Array ProjectionMatrix { get; }
	[Value("transform")]
	public XRRigidTransform Transform { get; }
	[Value("recommendedViewportScale")]
	public Number? RecommendedViewportScale { get; }
	[Value("requestViewportScale")]
	public Undefined RequestViewportScale(Number? scale) { throw new System.NotImplementedException(); }
}

[Value("XRViewport")]
public partial class XRViewport
{
	[Value("x")]
	public long X { get; }
	[Value("y")]
	public long Y { get; }
	[Value("width")]
	public long Width { get; }
	[Value("height")]
	public long Height { get; }
}

[Value("XRRigidTransform")]
public partial class XRRigidTransform
{
		public XRRigidTransform(DOMPointInit position = default, DOMPointInit orientation = default) { }
	[Value("position")]
	public DOMPointReadOnly Position { get; }
	[Value("orientation")]
	public DOMPointReadOnly Orientation { get; }
	[Value("matrix")]
	public Float32Array Matrix { get; }
	[Value("inverse")]
	public XRRigidTransform Inverse { get; }
	public XRRigidTransform() { }
}

[Value("XRPose")]
public partial class XRPose
{
	[Value("transform")]
	public XRRigidTransform Transform { get; }
	[Value("linearVelocity")]
	public DOMPointReadOnly? LinearVelocity { get; }
	[Value("angularVelocity")]
	public DOMPointReadOnly? AngularVelocity { get; }
	[Value("emulatedPosition")]
	public bool EmulatedPosition { get; }
}

[Value("XRViewerPose")]
public partial class XRViewerPose : XRPose
{
	[Value("views")]
	public XRView[] Views { get; }
}

public partial class XRInputSource
{
	[Value("handedness")]
	public XRHandedness Handedness { get; }
	[Value("targetRayMode")]
	public XRTargetRayMode TargetRayMode { get; }
	[Value("targetRaySpace")]
	public XRSpace TargetRaySpace { get; }
	[Value("gripSpace")]
	public XRSpace? GripSpace { get; }
	[Value("profiles")]
	public DOMString[] Profiles { get; }
	[Value("skipRendering")]
	public bool SkipRendering { get; }
}

[Value("XRInputSourceArray")]
public partial class XRInputSourceArray
{
	public XRInputSource this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	[Value("length")]
	public ulong Length { get; }
	
}

[Value("XRLayer")]
public partial class XRLayer : EventTarget
{
}


[Value("XRWebGLLayerInit")]
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

[Value("XRWebGLLayer")]
public partial class XRWebGLLayer : XRLayer
{
		public XRWebGLLayer(XRSession session, XRWebGLRenderingContext context, XRWebGLLayerInit layerInit = default) { }
	[Value("antialias")]
	public bool Antialias { get; }
	[Value("ignoreDepthValues")]
	public bool IgnoreDepthValues { get; }
	[Value("fixedFoveation")]
	public Number? FixedFoveation { get; set; }
	[Value("framebuffer")]
	public WebGLFramebuffer? Framebuffer { get; }
	[Value("framebufferWidth")]
	public ulong FramebufferWidth { get; }
	[Value("framebufferHeight")]
	public ulong FramebufferHeight { get; }
	[Value("getViewport")]
	public XRViewport? GetViewport(XRView view) { throw new System.NotImplementedException(); }
	[Value("getNativeFramebufferScaleFactor")]
	public static Number GetNativeFramebufferScaleFactor(XRSession session) { throw new System.NotImplementedException(); }
	public XRWebGLLayer() { }
}

public partial class WebGLContextAttributes
{
	[Value("xrCompatible")]
	public bool XrCompatible;
}

[Value("XRSessionEvent")]
public partial class XRSessionEvent : Event
{
		public XRSessionEvent(DOMString type, XRSessionEventInit eventInitDict) { }
	[Value("session")]
	public XRSession Session { get; }
	public XRSessionEvent() { }
}

[Value("XRSessionEventInit")]
public partial class XRSessionEventInit : EventInit
{
	[Value("session")]
	public required XRSession Session;
}

[Value("XRInputSourceEvent")]
public partial class XRInputSourceEvent : Event
{
		public XRInputSourceEvent(DOMString type, XRInputSourceEventInit eventInitDict) { }
	[Value("frame")]
	public XRFrame Frame { get; }
	[Value("inputSource")]
	public XRInputSource InputSource { get; }
	public XRInputSourceEvent() { }
}

[Value("XRInputSourceEventInit")]
public partial class XRInputSourceEventInit : EventInit
{
	[Value("frame")]
	public required XRFrame Frame;
	[Value("inputSource")]
	public required XRInputSource InputSource;
}

[Value("XRInputSourcesChangeEvent")]
public partial class XRInputSourcesChangeEvent : Event
{
		public XRInputSourcesChangeEvent(DOMString type, XRInputSourcesChangeEventInit eventInitDict) { }
	[Value("session")]
	public XRSession Session { get; }
	[Value("added")]
	public XRInputSource[] Added { get; }
	[Value("removed")]
	public XRInputSource[] Removed { get; }
	public XRInputSourcesChangeEvent() { }
}

[Value("XRInputSourcesChangeEventInit")]
public partial class XRInputSourcesChangeEventInit : EventInit
{
	[Value("session")]
	public required XRSession Session;
	[Value("added")]
	public required List<XRInputSource> Added;
	[Value("removed")]
	public required List<XRInputSource> Removed;
}

[Value("XRReferenceSpaceEvent")]
public partial class XRReferenceSpaceEvent : Event
{
		public XRReferenceSpaceEvent(DOMString type, XRReferenceSpaceEventInit eventInitDict) { }
	[Value("referenceSpace")]
	public XRReferenceSpace ReferenceSpace { get; }
	[Value("transform")]
	public XRRigidTransform? Transform { get; }
	public XRReferenceSpaceEvent() { }
}

[Value("XRReferenceSpaceEventInit")]
public partial class XRReferenceSpaceEventInit : EventInit
{
	[Value("referenceSpace")]
	public required XRReferenceSpace ReferenceSpace;
	[Value("transform")]
	public XRRigidTransform? Transform;
}

[Value("XRSessionSupportedPermissionDescriptor")]
public partial class XRSessionSupportedPermissionDescriptor : PermissionDescriptor
{
	[Value("mode")]
	public XRSessionMode Mode;
}

[Value("XRPermissionDescriptor")]
public partial class XRPermissionDescriptor : PermissionDescriptor
{
	[Value("mode")]
	public XRSessionMode Mode;
	[Value("requiredFeatures")]
	public List<DOMString> RequiredFeatures;
	[Value("optionalFeatures")]
	public List<DOMString> OptionalFeatures;
}

[Value("XRPermissionStatus")]
public partial class XRPermissionStatus : PermissionStatus
{
	[Value("granted")]
	public DOMString[] Granted { get; set; }
}

[Value("XRCompositionLayer")]
public partial class XRCompositionLayer : XRLayer
{
	[Value("layout")]
	public XRLayerLayout Layout { get; }
	[Value("blendTextureSourceAlpha")]
	public bool BlendTextureSourceAlpha { get; set; }
	[Value("forceMonoPresentation")]
	public bool ForceMonoPresentation { get; set; }
	[Value("opacity")]
	public Number Opacity { get; set; }
	[Value("mipLevels")]
	public ulong MipLevels { get; }
	[Value("quality")]
	public XRLayerQuality Quality { get; set; }
	[Value("needsRedraw")]
	public bool NeedsRedraw { get; }
	[Value("destroy")]
	public Undefined Destroy() { throw new System.NotImplementedException(); }
}

[Value("XRProjectionLayer")]
public partial class XRProjectionLayer : XRCompositionLayer
{
	[Value("textureWidth")]
	public ulong TextureWidth { get; }
	[Value("textureHeight")]
	public ulong TextureHeight { get; }
	[Value("textureArrayLength")]
	public ulong TextureArrayLength { get; }
	[Value("ignoreDepthValues")]
	public bool IgnoreDepthValues { get; }
	[Value("fixedFoveation")]
	public Number? FixedFoveation { get; set; }
	[Value("deltaPose")]
	public XRRigidTransform? DeltaPose { get; set; }
}

[Value("XRQuadLayer")]
public partial class XRQuadLayer : XRCompositionLayer
{
	[Value("space")]
	public XRSpace Space { get; set; }
	[Value("transform")]
	public XRRigidTransform Transform { get; set; }
	[Value("width")]
	public Number Width { get; set; }
	[Value("height")]
	public Number Height { get; set; }
	[Value("onredraw")]
	public EventHandler Onredraw { get; set; }
}

[Value("XRCylinderLayer")]
public partial class XRCylinderLayer : XRCompositionLayer
{
	[Value("space")]
	public XRSpace Space { get; set; }
	[Value("transform")]
	public XRRigidTransform Transform { get; set; }
	[Value("radius")]
	public Number Radius { get; set; }
	[Value("centralAngle")]
	public Number CentralAngle { get; set; }
	[Value("aspectRatio")]
	public Number AspectRatio { get; set; }
	[Value("onredraw")]
	public EventHandler Onredraw { get; set; }
}

[Value("XREquirectLayer")]
public partial class XREquirectLayer : XRCompositionLayer
{
	[Value("space")]
	public XRSpace Space { get; set; }
	[Value("transform")]
	public XRRigidTransform Transform { get; set; }
	[Value("radius")]
	public Number Radius { get; set; }
	[Value("centralHorizontalAngle")]
	public Number CentralHorizontalAngle { get; set; }
	[Value("upperVerticalAngle")]
	public Number UpperVerticalAngle { get; set; }
	[Value("lowerVerticalAngle")]
	public Number LowerVerticalAngle { get; set; }
	[Value("onredraw")]
	public EventHandler Onredraw { get; set; }
}

[Value("XRCubeLayer")]
public partial class XRCubeLayer : XRCompositionLayer
{
	[Value("space")]
	public XRSpace Space { get; set; }
	[Value("orientation")]
	public DOMPointReadOnly Orientation { get; set; }
	[Value("onredraw")]
	public EventHandler Onredraw { get; set; }
}

[Value("XRSubImage")]
public partial class XRSubImage
{
	[Value("viewport")]
	public XRViewport Viewport { get; }
}

[Value("XRWebGLSubImage")]
public partial class XRWebGLSubImage : XRSubImage
{
	[Value("colorTexture")]
	public WebGLTexture ColorTexture { get; }
	[Value("depthStencilTexture")]
	public WebGLTexture? DepthStencilTexture { get; }
	[Value("motionVectorTexture")]
	public WebGLTexture? MotionVectorTexture { get; }
	[Value("imageIndex")]
	public ulong? ImageIndex { get; }
	[Value("colorTextureWidth")]
	public ulong ColorTextureWidth { get; }
	[Value("colorTextureHeight")]
	public ulong ColorTextureHeight { get; }
	[Value("depthStencilTextureWidth")]
	public ulong? DepthStencilTextureWidth { get; }
	[Value("depthStencilTextureHeight")]
	public ulong? DepthStencilTextureHeight { get; }
	[Value("motionVectorTextureWidth")]
	public ulong? MotionVectorTextureWidth { get; }
	[Value("motionVectorTextureHeight")]
	public ulong? MotionVectorTextureHeight { get; }
}

[Value("XRProjectionLayerInit")]
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

[Value("XRLayerInit")]
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

[Value("XRQuadLayerInit")]
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

[Value("XRCylinderLayerInit")]
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

[Value("XREquirectLayerInit")]
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

[Value("XRCubeLayerInit")]
public partial class XRCubeLayerInit : XRLayerInit
{
	[Value("orientation")]
	public DOMPointReadOnly? Orientation;
}

public partial class XRWebGLBinding
{
		public XRWebGLBinding(XRSession session, XRWebGLRenderingContext context) { }
	[Value("nativeProjectionScaleFactor")]
	public Number NativeProjectionScaleFactor { get; }
	[Value("usesDepthValues")]
	public bool UsesDepthValues { get; }
	[Value("createProjectionLayer")]
	public XRProjectionLayer CreateProjectionLayer(XRProjectionLayerInit init = default) { throw new System.NotImplementedException(); }
	[Value("createQuadLayer")]
	public XRQuadLayer CreateQuadLayer(XRQuadLayerInit init = default) { throw new System.NotImplementedException(); }
	[Value("createCylinderLayer")]
	public XRCylinderLayer CreateCylinderLayer(XRCylinderLayerInit init = default) { throw new System.NotImplementedException(); }
	[Value("createEquirectLayer")]
	public XREquirectLayer CreateEquirectLayer(XREquirectLayerInit init = default) { throw new System.NotImplementedException(); }
	[Value("createCubeLayer")]
	public XRCubeLayer CreateCubeLayer(XRCubeLayerInit init = default) { throw new System.NotImplementedException(); }
	[Value("getSubImage")]
	public XRWebGLSubImage GetSubImage(XRCompositionLayer layer, XRFrame frame, XREye eye = default) { throw new System.NotImplementedException(); }
	[Value("getViewSubImage")]
	public XRWebGLSubImage GetViewSubImage(XRProjectionLayer layer, XRView view) { throw new System.NotImplementedException(); }
	public XRWebGLBinding() { }
}

[Value("XRMediaLayerInit")]
public partial class XRMediaLayerInit
{
	[Value("space")]
	public required XRSpace Space;
	[Value("layout")]
	public XRLayerLayout Layout;
	[Value("invertStereo")]
	public bool InvertStereo;
}

[Value("XRMediaQuadLayerInit")]
public partial class XRMediaQuadLayerInit : XRMediaLayerInit
{
	[Value("transform")]
	public XRRigidTransform? Transform;
	[Value("width")]
	public Number? Width;
	[Value("height")]
	public Number? Height;
}

[Value("XRMediaCylinderLayerInit")]
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

[Value("XRMediaEquirectLayerInit")]
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

[Value("XRMediaBinding")]
public partial class XRMediaBinding
{
		public XRMediaBinding(XRSession session) { }
	[Value("createQuadLayer")]
	public XRQuadLayer CreateQuadLayer(HTMLVideoElement video, XRMediaQuadLayerInit init = default) { throw new System.NotImplementedException(); }
	[Value("createCylinderLayer")]
	public XRCylinderLayer CreateCylinderLayer(HTMLVideoElement video, XRMediaCylinderLayerInit init = default) { throw new System.NotImplementedException(); }
	[Value("createEquirectLayer")]
	public XREquirectLayer CreateEquirectLayer(HTMLVideoElement video, XRMediaEquirectLayerInit init = default) { throw new System.NotImplementedException(); }
	public XRMediaBinding() { }
}

[Value("XRLayerEvent")]
public partial class XRLayerEvent : Event
{
		public XRLayerEvent(DOMString type, XRLayerEventInit eventInitDict) { }
	[Value("layer")]
	public XRLayer Layer { get; }
	public XRLayerEvent() { }
}

[Value("XRLayerEventInit")]
public partial class XRLayerEventInit : EventInit
{
	[Value("layer")]
	public required XRLayer Layer;
}

public partial class XRRenderState
{
	[Value("layers")]
	public XRLayer[] Layers { get; }
}

public partial class Navigator
{
	[Value("windowControlsOverlay")]
	public WindowControlsOverlay WindowControlsOverlay { get; }
}

[Value("WindowControlsOverlay")]
public partial class WindowControlsOverlay : EventTarget
{
	[Value("visible")]
	public bool Visible { get; }
	[Value("getTitlebarAreaRect")]
	public DOMRect GetTitlebarAreaRect() { throw new System.NotImplementedException(); }
	[Value("ongeometrychange")]
	public EventHandler Ongeometrychange { get; set; }
}

[Value("WindowControlsOverlayGeometryChangeEvent")]
public partial class WindowControlsOverlayGeometryChangeEvent : Event
{
		public WindowControlsOverlayGeometryChangeEvent(DOMString type, WindowControlsOverlayGeometryChangeEventInit eventInitDict) { }
	[Value("titlebarAreaRect")]
	public DOMRect TitlebarAreaRect { get; }
	[Value("visible")]
	public bool Visible { get; }
	public WindowControlsOverlayGeometryChangeEvent() { }
}

[Value("WindowControlsOverlayGeometryChangeEventInit")]
public partial class WindowControlsOverlayGeometryChangeEventInit : EventInit
{
	[Value("titlebarAreaRect")]
	public required DOMRect TitlebarAreaRect;
	[Value("visible")]
	public bool Visible;
}

public partial class Screen
{
	[Value("isExtended")]
	public bool IsExtended { get; }
	[Value("onchange")]
	public EventHandler Onchange { get; set; }
}

public partial class Window
{
	[Value("getScreenDetails")]
	public Task<ScreenDetails> GetScreenDetails() { throw new System.NotImplementedException(); }
}

[Value("ScreenDetails")]
public partial class ScreenDetails : EventTarget
{
	[Value("screens")]
	public ScreenDetailed[] Screens { get; }
	[Value("currentScreen")]
	public ScreenDetailed CurrentScreen { get; }
	[Value("onscreenschange")]
	public EventHandler Onscreenschange { get; set; }
	[Value("oncurrentscreenchange")]
	public EventHandler Oncurrentscreenchange { get; set; }
}

[Value("ScreenDetailed")]
public partial class ScreenDetailed : Screen
{
	[Value("availLeft")]
	public long AvailLeft { get; }
	[Value("availTop")]
	public long AvailTop { get; }
	[Value("left")]
	public long Left { get; }
	[Value("top")]
	public long Top { get; }
	[Value("isPrimary")]
	public bool IsPrimary { get; }
	[Value("isInternal")]
	public bool IsInternal { get; }
	[Value("devicePixelRatio")]
	public Number DevicePixelRatio { get; }
	[Value("label")]
	public DOMString Label { get; }
}

public partial class FullscreenOptions
{
	[Value("screen")]
	public ScreenDetailed Screen;
}

[Value("XMLHttpRequestEventTarget")]
public partial class XMLHttpRequestEventTarget : EventTarget
{
	[Value("onloadstart")]
	public EventHandler Onloadstart { get; set; }
	[Value("onprogress")]
	public EventHandler Onprogress { get; set; }
	[Value("onabort")]
	public EventHandler Onabort { get; set; }
	[Value("onerror")]
	public EventHandler Onerror { get; set; }
	[Value("onload")]
	public EventHandler Onload { get; set; }
	[Value("ontimeout")]
	public EventHandler Ontimeout { get; set; }
	[Value("onloadend")]
	public EventHandler Onloadend { get; set; }
}

[Value("XMLHttpRequestUpload")]
public partial class XMLHttpRequestUpload : XMLHttpRequestEventTarget
{
}

public partial class XMLHttpRequest : XMLHttpRequestEventTarget
{
		public XMLHttpRequest() { }
	[Value("onreadystatechange")]
	public EventHandler Onreadystatechange { get; set; }
	[Value("UNSENT")]
	public const ushort UNSENT = 0;
	[Value("OPENED")]
	public const ushort OPENED = 1;
	[Value("HEADERS_RECEIVED")]
	public const ushort HEADERS_RECEIVED = 2;
	[Value("LOADING")]
	public const ushort LOADING = 3;
	[Value("DONE")]
	public const ushort DONE = 4;
	[Value("readyState")]
	public ushort ReadyState { get; }
	[Value("open")]
	public Undefined Open(ByteString method, USVString url) { throw new System.NotImplementedException(); }
	[Value("open")]
	public Undefined Open(ByteString method, USVString url, bool async, USVString? username = default, USVString? password = default) { throw new System.NotImplementedException(); }
	[Value("setRequestHeader")]
	public Undefined SetRequestHeader(ByteString name, ByteString value) { throw new System.NotImplementedException(); }
	[Value("timeout")]
	public ulong Timeout { get; set; }
	[Value("withCredentials")]
	public bool WithCredentials { get; set; }
	[Value("upload")]
	public XMLHttpRequestUpload Upload { get; }
	[Value("send")]
	public Undefined Send(Union236? body = default) { throw new System.NotImplementedException(); }
	[Value("abort")]
	public Undefined Abort() { throw new System.NotImplementedException(); }
	[Value("responseURL")]
	public USVString ResponseURL { get; }
	[Value("status")]
	public ushort Status { get; }
	[Value("statusText")]
	public ByteString StatusText { get; }
	[Value("getResponseHeader")]
	public ByteString? GetResponseHeader(ByteString name) { throw new System.NotImplementedException(); }
	[Value("getAllResponseHeaders")]
	public ByteString GetAllResponseHeaders() { throw new System.NotImplementedException(); }
	[Value("overrideMimeType")]
	public Undefined OverrideMimeType(DOMString mime) { throw new System.NotImplementedException(); }
	[Value("responseType")]
	public XMLHttpRequestResponseType ResponseType { get; set; }
	[Value("response")]
	public dynamic Response { get; }
	[Value("responseText")]
	public USVString ResponseText { get; }
	[Value("responseXML")]
	public Document? ResponseXML { get; }
}


[Value("FormData")]
public partial class FormData
{
		public FormData(HTMLFormElement form = default, HTMLElement? submitter = default) { }
	[Value("append")]
	public Undefined Append(USVString name, USVString value) { throw new System.NotImplementedException(); }
	[Value("append")]
	public Undefined Append(USVString name, Blob blobValue, USVString filename = default) { throw new System.NotImplementedException(); }
	[Value("delete")]
	public Undefined Delete(USVString name) { throw new System.NotImplementedException(); }
	[Value("get")]
	public FormDataEntryValue? Get(USVString name) { throw new System.NotImplementedException(); }
	[Value("getAll")]
	public List<FormDataEntryValue> GetAll(USVString name) { throw new System.NotImplementedException(); }
	[Value("has")]
	public bool Has(USVString name) { throw new System.NotImplementedException(); }
	[Value("set")]
	public Undefined Set(USVString name, USVString value) { throw new System.NotImplementedException(); }
	[Value("set")]
	public Undefined Set(USVString name, Blob blobValue, USVString filename = default) { throw new System.NotImplementedException(); }
	public USVString this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	public FormData() { }
}

[Value("ProgressEvent")]
public partial class ProgressEvent : Event
{
		public ProgressEvent(DOMString type, ProgressEventInit eventInitDict = default) { }
	[Value("lengthComputable")]
	public bool LengthComputable { get; }
	[Value("loaded")]
	public ulong Loaded { get; }
	[Value("total")]
	public ulong Total { get; }
	public ProgressEvent() { }
}

[Value("ProgressEventInit")]
public partial class ProgressEventInit : EventInit
{
	[Value("lengthComputable")]
	public bool LengthComputable;
	[Value("loaded")]
	public ulong Loaded;
	[Value("total")]
	public ulong Total;
}

