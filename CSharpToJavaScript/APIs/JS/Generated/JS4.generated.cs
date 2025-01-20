//20.01.2025 16:03:12

using static CSharpToJavaScript.APIs.JS.GlobalObject;
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
using BigInteger = System.Byte;
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
public struct PressureUpdateCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct AnimatorInstanceConstructor
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct ViewTransitionUpdateCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct MutationCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct ErrorCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct FileSystemEntryCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct FileSystemEntriesCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct FileCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct PositionCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct PositionErrorCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct BlobCallback
{
}



[To(ToAttribute.FirstCharToLowerCase)]
public struct CustomElementConstructor
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct FunctionStringCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct NavigationInterceptHandler
{
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
public struct FrameRequestCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct IntersectionObserverCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct MediaSessionActionHandler
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct NotificationPermissionCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct SubscribeCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct ObservableSubscriptionCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct ObservableInspectorAbortHandler
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct Predicate
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct Reducer
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct Mapper
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct Visitor
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct CatchCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct PerformanceObserverCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct RemotePlaybackAvailabilityCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct ReportingObserverCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct IdleRequestCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct ResizeObserverCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct SchedulerPostTaskCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct RunFunctionForSharedStorageSelectURLOperation
{
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

[To(ToAttribute.FirstCharToLowerCase)]
public struct QueuingStrategySize
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct CreateHTMLCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct CreateScriptCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct CreateScriptURLCallback
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public struct VideoFrameRequestCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct EffectCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct LaunchConsumer
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct LockGrantedCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct DecodeErrorCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct DecodeSuccessCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct AudioWorkletProcessorConstructor
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct AudioWorkletProcessCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct AudioDataOutputCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct VideoFrameOutputCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct EncodedAudioChunkOutputCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct EncodedVideoChunkOutputCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct WebCodecsErrorCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct Function
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct VoidFunction
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct GenerateAssertionCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct ValidateAssertionCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct RTCPeerConnectionErrorCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct RTCSessionDescriptionCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct XRFrameRequestCallback
{
}

