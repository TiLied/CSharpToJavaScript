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


public delegate Undefined PressureUpdateCallback(List<PressureRecord> changes, PressureObserver observer);

public delegate dynamic AnimatorInstanceConstructor(dynamic options, dynamic state = default);

public delegate Task<dynamic> ViewTransitionUpdateCallback();

public delegate Undefined MutationCallback(List<MutationRecord> mutations, MutationObserver observer);

public delegate Undefined ErrorCallback(DOMException err);

public delegate Undefined FileSystemEntryCallback(FileSystemEntry entry);

public delegate Undefined FileSystemEntriesCallback(List<FileSystemEntry> entries);

public delegate Undefined FileCallback(File file);

public delegate Undefined PositionCallback(GeolocationPosition position);

public delegate Undefined PositionErrorCallback(GeolocationPositionError positionError);

public delegate Undefined BlobCallback(Blob? blob);



public delegate HTMLElement CustomElementConstructor();

public delegate Undefined FunctionStringCallback(DOMString data);

public delegate Task<Undefined> NavigationInterceptHandler();

public delegate dynamic EventHandlerNonNull(Event event_);


public delegate dynamic OnErrorEventHandlerNonNull(Union83 event_, DOMString source = default, ulong lineno = default, ulong colno = default, dynamic error = default);


public delegate DOMString? OnBeforeUnloadEventHandlerNonNull(Event event_);


public delegate Undefined FrameRequestCallback(DOMHighResTimeStamp time);

public delegate Undefined IntersectionObserverCallback(List<IntersectionObserverEntry> entries, IntersectionObserver observer);

public delegate Undefined MediaSessionActionHandler(MediaSessionActionDetails details);

public delegate Undefined NotificationPermissionCallback(NotificationPermission permission);

public delegate Undefined SubscribeCallback(Subscriber subscriber);

public delegate Undefined ObservableSubscriptionCallback(dynamic value);

public delegate Undefined ObservableInspectorAbortHandler(dynamic value);

public delegate bool Predicate(dynamic value, ulong index);

public delegate dynamic Reducer(dynamic accumulator, dynamic currentValue, ulong index);

public delegate dynamic Mapper(dynamic value, ulong index);

public delegate Undefined Visitor(dynamic value, ulong index);

public delegate dynamic CatchCallback(dynamic value);

public delegate Undefined PerformanceObserverCallback(PerformanceObserverEntryList entries, PerformanceObserver observer, PerformanceObserverCallbackOptions options = default);

public delegate Undefined RemotePlaybackAvailabilityCallback(bool available);

public delegate Undefined ReportingObserverCallback(List<Report> reports, ReportingObserver observer);

public delegate Undefined IdleRequestCallback(IdleDeadline deadline);

public delegate Undefined ResizeObserverCallback(List<ResizeObserverEntry> entries, ResizeObserver observer);

public delegate dynamic SchedulerPostTaskCallback();

public delegate Task<ulong> RunFunctionForSharedStorageSelectURLOperation(List<USVString> urls, dynamic data = default);

public delegate dynamic UnderlyingSourceStartCallback(ReadableStreamController controller);

public delegate Task<Undefined> UnderlyingSourcePullCallback(ReadableStreamController controller);

public delegate Task<Undefined> UnderlyingSourceCancelCallback(dynamic reason = default);

public delegate dynamic UnderlyingSinkStartCallback(WritableStreamDefaultController controller);

public delegate Task<Undefined> UnderlyingSinkWriteCallback(dynamic chunk, WritableStreamDefaultController controller);

public delegate Task<Undefined> UnderlyingSinkCloseCallback();

public delegate Task<Undefined> UnderlyingSinkAbortCallback(dynamic reason = default);

public delegate dynamic TransformerStartCallback(TransformStreamDefaultController controller);

public delegate Task<Undefined> TransformerFlushCallback(TransformStreamDefaultController controller);

public delegate Task<Undefined> TransformerTransformCallback(dynamic chunk, TransformStreamDefaultController controller);

public delegate Task<Undefined> TransformerCancelCallback(dynamic reason);

public delegate double QueuingStrategySize(dynamic chunk);

public delegate DOMString? CreateHTMLCallback(DOMString input, params dynamic[] arguments);

public delegate DOMString? CreateScriptCallback(DOMString input, params dynamic[] arguments);

public delegate USVString? CreateScriptURLCallback(DOMString input, params dynamic[] arguments);


public delegate Undefined VideoFrameRequestCallback(DOMHighResTimeStamp now, VideoFrameCallbackMetadata metadata);

public delegate Undefined EffectCallback(Number? progress, Union163 currentTarget, Animation animation);

public delegate dynamic LaunchConsumer(LaunchParams params_);

public delegate Task<dynamic> LockGrantedCallback(Lock? lock_);

public delegate Undefined DecodeErrorCallback(DOMException error);

public delegate Undefined DecodeSuccessCallback(AudioBuffer decodedData);

public delegate AudioWorkletProcessor AudioWorkletProcessorConstructor(Object options);

public delegate bool AudioWorkletProcessCallback(Float32Array[][] inputs, Float32Array[][] outputs, Object parameters);

public delegate Undefined AudioDataOutputCallback(AudioData output);

public delegate Undefined VideoFrameOutputCallback(VideoFrame output);

public delegate Undefined EncodedAudioChunkOutputCallback(EncodedAudioChunk output, EncodedAudioChunkMetadata metadata = default);

public delegate Undefined EncodedVideoChunkOutputCallback(EncodedVideoChunk chunk, EncodedVideoChunkMetadata metadata = default);

public delegate Undefined WebCodecsErrorCallback(DOMException error);

public delegate dynamic Function(params dynamic[] arguments);

public delegate Undefined VoidFunction();

public delegate Task<RTCIdentityAssertionResult> GenerateAssertionCallback(DOMString contents, DOMString origin, RTCIdentityProviderOptions options);

public delegate Task<RTCIdentityValidationResult> ValidateAssertionCallback(DOMString assertion, DOMString origin);

public delegate Undefined RTCPeerConnectionErrorCallback(DOMException error);

public delegate Undefined RTCSessionDescriptionCallback(RTCSessionDescriptionInit description);

public delegate Undefined XRFrameRequestCallback(DOMHighResTimeStamp time, XRFrame frame);

