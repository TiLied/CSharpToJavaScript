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


[Value("PressureUpdateCallback")]
public partial class PressureUpdateCallback
{
}

[Value("AnimatorInstanceConstructor")]
public partial class AnimatorInstanceConstructor
{
}

[Value("ViewTransitionUpdateCallback")]
public partial class ViewTransitionUpdateCallback
{
}

[Value("MutationCallback")]
public partial class MutationCallback
{
}

[Value("ErrorCallback")]
public partial class ErrorCallback
{
}

[Value("FileSystemEntryCallback")]
public partial class FileSystemEntryCallback
{
}

[Value("FileSystemEntriesCallback")]
public partial class FileSystemEntriesCallback
{
}

[Value("FileCallback")]
public partial class FileCallback
{
}

[Value("PositionCallback")]
public partial class PositionCallback
{
}

[Value("PositionErrorCallback")]
public partial class PositionErrorCallback
{
}

[Value("BlobCallback")]
public partial class BlobCallback
{
}



[Value("CustomElementConstructor")]
public partial class CustomElementConstructor
{
}

[Value("FunctionStringCallback")]
public partial class FunctionStringCallback
{
}

[Value("NavigationInterceptHandler")]
public partial class NavigationInterceptHandler
{
}

[Value("EventHandlerNonNull")]
public partial class EventHandlerNonNull
{
}


[Value("OnErrorEventHandlerNonNull")]
public partial class OnErrorEventHandlerNonNull
{
}


[Value("OnBeforeUnloadEventHandlerNonNull")]
public partial class OnBeforeUnloadEventHandlerNonNull
{
}


[Value("FrameRequestCallback")]
public partial class FrameRequestCallback
{
}

[Value("IntersectionObserverCallback")]
public partial class IntersectionObserverCallback
{
}

[Value("MediaSessionActionHandler")]
public partial class MediaSessionActionHandler
{
}

[Value("NotificationPermissionCallback")]
public partial class NotificationPermissionCallback
{
}

[Value("SubscribeCallback")]
public partial class SubscribeCallback
{
}

[Value("ObservableSubscriptionCallback")]
public partial class ObservableSubscriptionCallback
{
}

[Value("ObservableInspectorAbortHandler")]
public partial class ObservableInspectorAbortHandler
{
}

[Value("Predicate")]
public partial class Predicate
{
}

[Value("Reducer")]
public partial class Reducer
{
}

[Value("Mapper")]
public partial class Mapper
{
}

[Value("Visitor")]
public partial class Visitor
{
}

[Value("CatchCallback")]
public partial class CatchCallback
{
}

[Value("PerformanceObserverCallback")]
public partial class PerformanceObserverCallback
{
}

[Value("RemotePlaybackAvailabilityCallback")]
public partial class RemotePlaybackAvailabilityCallback
{
}

[Value("ReportingObserverCallback")]
public partial class ReportingObserverCallback
{
}

[Value("IdleRequestCallback")]
public partial class IdleRequestCallback
{
}

[Value("ResizeObserverCallback")]
public partial class ResizeObserverCallback
{
}

[Value("SchedulerPostTaskCallback")]
public partial class SchedulerPostTaskCallback
{
}

[Value("RunFunctionForSharedStorageSelectURLOperation")]
public partial class RunFunctionForSharedStorageSelectURLOperation
{
}

[Value("UnderlyingSourceStartCallback")]
public partial class UnderlyingSourceStartCallback
{
}

[Value("UnderlyingSourcePullCallback")]
public partial class UnderlyingSourcePullCallback
{
}

[Value("UnderlyingSourceCancelCallback")]
public partial class UnderlyingSourceCancelCallback
{
}

[Value("UnderlyingSinkStartCallback")]
public partial class UnderlyingSinkStartCallback
{
}

[Value("UnderlyingSinkWriteCallback")]
public partial class UnderlyingSinkWriteCallback
{
}

[Value("UnderlyingSinkCloseCallback")]
public partial class UnderlyingSinkCloseCallback
{
}

[Value("UnderlyingSinkAbortCallback")]
public partial class UnderlyingSinkAbortCallback
{
}

[Value("TransformerStartCallback")]
public partial class TransformerStartCallback
{
}

[Value("TransformerFlushCallback")]
public partial class TransformerFlushCallback
{
}

[Value("TransformerTransformCallback")]
public partial class TransformerTransformCallback
{
}

[Value("TransformerCancelCallback")]
public partial class TransformerCancelCallback
{
}

[Value("QueuingStrategySize")]
public partial class QueuingStrategySize
{
}

[Value("CreateHTMLCallback")]
public partial class CreateHTMLCallback
{
}

[Value("CreateScriptCallback")]
public partial class CreateScriptCallback
{
}

[Value("CreateScriptURLCallback")]
public partial class CreateScriptURLCallback
{
}


[Value("VideoFrameRequestCallback")]
public partial class VideoFrameRequestCallback
{
}

[Value("EffectCallback")]
public partial class EffectCallback
{
}

[Value("LaunchConsumer")]
public partial class LaunchConsumer
{
}

[Value("LockGrantedCallback")]
public partial class LockGrantedCallback
{
}

[Value("DecodeErrorCallback")]
public partial class DecodeErrorCallback
{
}

[Value("DecodeSuccessCallback")]
public partial class DecodeSuccessCallback
{
}

[Value("AudioWorkletProcessorConstructor")]
public partial class AudioWorkletProcessorConstructor
{
}

[Value("AudioWorkletProcessCallback")]
public partial class AudioWorkletProcessCallback
{
}

[Value("AudioDataOutputCallback")]
public partial class AudioDataOutputCallback
{
}

[Value("VideoFrameOutputCallback")]
public partial class VideoFrameOutputCallback
{
}

[Value("EncodedAudioChunkOutputCallback")]
public partial class EncodedAudioChunkOutputCallback
{
}

[Value("EncodedVideoChunkOutputCallback")]
public partial class EncodedVideoChunkOutputCallback
{
}

[Value("WebCodecsErrorCallback")]
public partial class WebCodecsErrorCallback
{
}

[Value("Function")]
public partial class Function
{
}

[Value("VoidFunction")]
public partial class VoidFunction
{
}

[Value("GenerateAssertionCallback")]
public partial class GenerateAssertionCallback
{
}

[Value("ValidateAssertionCallback")]
public partial class ValidateAssertionCallback
{
}

[Value("RTCPeerConnectionErrorCallback")]
public partial class RTCPeerConnectionErrorCallback
{
}

[Value("RTCSessionDescriptionCallback")]
public partial class RTCSessionDescriptionCallback
{
}

[Value("XRFrameRequestCallback")]
public partial class XRFrameRequestCallback
{
}

