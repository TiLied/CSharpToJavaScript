//02.05.2025 19:37:02

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
public partial class PressureUpdateCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AnimatorInstanceConstructor
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ViewTransitionUpdateCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MutationCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ErrorCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FileSystemEntryCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FileSystemEntriesCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FileCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PositionCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PositionErrorCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class BlobCallback
{
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial class CustomElementConstructor
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FunctionStringCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NavigationInterceptHandler
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class EventHandlerNonNull
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class OnErrorEventHandlerNonNull
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class OnBeforeUnloadEventHandlerNonNull
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class FrameRequestCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class IntersectionObserverCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaSessionActionHandler
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NotificationPermissionCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class SubscribeCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ObservableSubscriptionCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ObservableInspectorAbortHandler
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class Predicate
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class Reducer
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class Mapper
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class Visitor
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CatchCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PerformanceObserverCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class RemotePlaybackAvailabilityCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ReportingObserverCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class IdleRequestCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ResizeObserverCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class SchedulerPostTaskCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class RunFunctionForSharedStorageSelectURLOperation
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class UnderlyingSourceStartCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class UnderlyingSourcePullCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class UnderlyingSourceCancelCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class UnderlyingSinkStartCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class UnderlyingSinkWriteCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class UnderlyingSinkCloseCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class UnderlyingSinkAbortCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class TransformerStartCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class TransformerFlushCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class TransformerTransformCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class TransformerCancelCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class QueuingStrategySize
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CreateHTMLCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CreateScriptCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CreateScriptURLCallback
{
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoFrameRequestCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class EffectCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class LaunchConsumer
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class LockGrantedCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class DecodeErrorCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class DecodeSuccessCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioWorkletProcessorConstructor
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioWorkletProcessCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioDataOutputCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoFrameOutputCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class EncodedAudioChunkOutputCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class EncodedVideoChunkOutputCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WebCodecsErrorCallback
{
}

[To(ToAttribute.Default)]
public partial class Function
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class VoidFunction
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GenerateAssertionCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ValidateAssertionCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class RTCPeerConnectionErrorCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class RTCSessionDescriptionCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class XRFrameRequestCallback
{
}

