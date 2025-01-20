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


///<summary>
///<see cref="RequestInfo"/> or <see cref="List{RequestInfo}"/>
///</summary>
public struct Union0
{
	public dynamic Value { get; set; }
	public static implicit operator Union0(RequestInfo value){return new Union0 { Value = value };}
	public static implicit operator Union0(List<RequestInfo> value){return new Union0 { Value = value };}
}

///<summary>
///<see cref="PasswordCredentialData"/> or <see cref="HTMLFormElement"/>
///</summary>
public struct Union1
{
	public dynamic Value { get; set; }
	public static implicit operator Union1(PasswordCredentialData value){return new Union1 { Value = value };}
	public static implicit operator Union1(HTMLFormElement value){return new Union1 { Value = value };}
}

///<summary>
///<see cref="AnimationEffect"/> or <see cref="List{AnimationEffect}"/>
///</summary>
public struct Union2
{
	public dynamic Value { get; set; }
	public static implicit operator Union2(AnimationEffect value){return new Union2 { Value = value };}
	public static implicit operator Union2(List<AnimationEffect> value){return new Union2 { Value = value };}
}

///<summary>
///<see cref="CSSOMString"/> or <see cref="BufferSource"/>
///</summary>
public struct Union3
{
	public dynamic Value { get; set; }
	public static implicit operator Union3(CSSOMString value){return new Union3 { Value = value };}
	public static implicit operator Union3(BufferSource value){return new Union3 { Value = value };}
}

///<summary>
///<see cref="ulong"/> or <see cref="List{ulong}"/>
///</summary>
public struct Union4
{
	public dynamic Value { get; set; }
	public static implicit operator Union4(ulong value){return new Union4 { Value = value };}
	public static implicit operator Union4(List<ulong> value){return new Union4 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="ReadableStream"/>
///</summary>
public struct Union5
{
	public dynamic Value { get; set; }
	public static implicit operator Union5(DOMString value){return new Union5 { Value = value };}
	public static implicit operator Union5(ReadableStream value){return new Union5 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="CSSStyleValue"/> or <see cref="CSSParserValue"/>
///</summary>
public struct Union6
{
	public dynamic Value { get; set; }
	public static implicit operator Union6(DOMString value){return new Union6 { Value = value };}
	public static implicit operator Union6(CSSStyleValue value){return new Union6 { Value = value };}
	public static implicit operator Union6(CSSParserValue value){return new Union6 { Value = value };}
}

///<summary>
///<see cref="Element"/> or <see cref="CSSPseudoElement"/>
///</summary>
public struct Union7
{
	public dynamic Value { get; set; }
	public static implicit operator Union7(Element value){return new Union7 { Value = value };}
	public static implicit operator Union7(CSSPseudoElement value){return new Union7 { Value = value };}
}

///<summary>
///<see cref="Undefined"/> or <see cref="CSSStyleValue"/>
///</summary>
public struct Union8
{
	public dynamic Value { get; set; }
	public static implicit operator Union8(Undefined value){return new Union8 { Value = value };}
	public static implicit operator Union8(CSSStyleValue value){return new Union8 { Value = value };}
}

///<summary>
///<see cref="CSSStyleValue"/> or <see cref="USVString"/>
///</summary>
public struct Union9
{
	public dynamic Value { get; set; }
	public static implicit operator Union9(CSSStyleValue value){return new Union9 { Value = value };}
	public static implicit operator Union9(USVString value){return new Union9 { Value = value };}
}

///<summary>
///<see cref="CSSStyleValue"/> or <see cref="USVString"/>
///</summary>
public struct Union10
{
	public dynamic Value { get; set; }
	public static implicit operator Union10(CSSStyleValue value){return new Union10 { Value = value };}
	public static implicit operator Union10(USVString value){return new Union10 { Value = value };}
}

///<summary>
///<see cref="USVString"/> or <see cref="CSSVariableReferenceValue"/>
///</summary>
public struct Union11
{
	public dynamic Value { get; set; }
	public static implicit operator Union11(USVString value){return new Union11 { Value = value };}
	public static implicit operator Union11(CSSVariableReferenceValue value){return new Union11 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="CSSKeywordValue"/>
///</summary>
public struct Union12
{
	public dynamic Value { get; set; }
	public static implicit operator Union12(DOMString value){return new Union12 { Value = value };}
	public static implicit operator Union12(CSSKeywordValue value){return new Union12 { Value = value };}
}

///<summary>
///<see cref="Number"/> or <see cref="CSSNumericValue"/>
///</summary>
public struct Union13
{
	public dynamic Value { get; set; }
	public static implicit operator Union13(Number value){return new Union13 { Value = value };}
	public static implicit operator Union13(CSSNumericValue value){return new Union13 { Value = value };}
}

///<summary>
///<see cref="CSSNumericValue"/> or <see cref="CSSKeywordish"/>
///</summary>
public struct Union14
{
	public dynamic Value { get; set; }
	public static implicit operator Union14(CSSNumericValue value){return new Union14 { Value = value };}
	public static implicit operator Union14(CSSKeywordish value){return new Union14 { Value = value };}
}

///<summary>
///<see cref="CSSColorValue"/> or <see cref="CSSStyleValue"/>
///</summary>
public struct Union15
{
	public dynamic Value { get; set; }
	public static implicit operator Union15(CSSColorValue value){return new Union15 { Value = value };}
	public static implicit operator Union15(CSSStyleValue value){return new Union15 { Value = value };}
}

///<summary>
///<see cref="CSSNumberish"/> or <see cref="CSSKeywordish"/>
///</summary>
public struct Union16
{
	public dynamic Value { get; set; }
	public static implicit operator Union16(CSSNumberish value){return new Union16 { Value = value };}
	public static implicit operator Union16(CSSKeywordish value){return new Union16 { Value = value };}
}

///<summary>
///<see cref="CSSNumberish"/> or <see cref="CSSKeywordish"/>
///</summary>
public struct Union17
{
	public dynamic Value { get; set; }
	public static implicit operator Union17(CSSNumberish value){return new Union17 { Value = value };}
	public static implicit operator Union17(CSSKeywordish value){return new Union17 { Value = value };}
}

///<summary>
///<see cref="CSSNumberish"/> or <see cref="CSSKeywordish"/>
///</summary>
public struct Union18
{
	public dynamic Value { get; set; }
	public static implicit operator Union18(CSSNumberish value){return new Union18 { Value = value };}
	public static implicit operator Union18(CSSKeywordish value){return new Union18 { Value = value };}
}

///<summary>
///<see cref="CSSNumberish"/> or <see cref="CSSKeywordish"/>
///</summary>
public struct Union19
{
	public dynamic Value { get; set; }
	public static implicit operator Union19(CSSNumberish value){return new Union19 { Value = value };}
	public static implicit operator Union19(CSSKeywordish value){return new Union19 { Value = value };}
}

///<summary>
///<see cref="ViewTransitionUpdateCallback"/> or <see cref="StartViewTransitionOptions"/>
///</summary>
public struct Union20
{
	public dynamic Value { get; set; }
	public static implicit operator Union20(ViewTransitionUpdateCallback value){return new Union20 { Value = value };}
	public static implicit operator Union20(StartViewTransitionOptions value){return new Union20 { Value = value };}
}

///<summary>
///<see cref="bool"/> or <see cref="ScrollIntoViewOptions"/>
///</summary>
public struct Union21
{
	public dynamic Value { get; set; }
	public static implicit operator Union21(bool value){return new Union21 { Value = value };}
	public static implicit operator Union21(ScrollIntoViewOptions value){return new Union21 { Value = value };}
}

///<summary>
///<see cref="Text"/> or <see cref="Element"/> or <see cref="CSSPseudoElement"/> or <see cref="Document"/>
///</summary>
public struct Union22
{
	public dynamic Value { get; set; }
	public static implicit operator Union22(Text value){return new Union22 { Value = value };}
	public static implicit operator Union22(Element value){return new Union22 { Value = value };}
	public static implicit operator Union22(CSSPseudoElement value){return new Union22 { Value = value };}
	public static implicit operator Union22(Document value){return new Union22 { Value = value };}
}

///<summary>
///<see cref="Element"/> or <see cref="ProcessingInstruction"/>
///</summary>
public struct Union23
{
	public dynamic Value { get; set; }
	public static implicit operator Union23(Element value){return new Union23 { Value = value };}
	public static implicit operator Union23(ProcessingInstruction value){return new Union23 { Value = value };}
}

///<summary>
///<see cref="MediaList"/> or <see cref="DOMString"/>
///</summary>
public struct Union24
{
	public dynamic Value { get; set; }
	public static implicit operator Union24(MediaList value){return new Union24 { Value = value };}
	public static implicit operator Union24(DOMString value){return new Union24 { Value = value };}
}

///<summary>
///<see cref="Event"/> or <see cref="Undefined"/>
///</summary>
public struct Union25
{
	public dynamic Value { get; set; }
	public static implicit operator Union25(Event value){return new Union25 { Value = value };}
	public static implicit operator Union25(Undefined value){return new Union25 { Value = value };}
}

///<summary>
///<see cref="AddEventListenerOptions"/> or <see cref="bool"/>
///</summary>
public struct Union26
{
	public dynamic Value { get; set; }
	public static implicit operator Union26(AddEventListenerOptions value){return new Union26 { Value = value };}
	public static implicit operator Union26(bool value){return new Union26 { Value = value };}
}

///<summary>
///<see cref="EventListenerOptions"/> or <see cref="bool"/>
///</summary>
public struct Union27
{
	public dynamic Value { get; set; }
	public static implicit operator Union27(EventListenerOptions value){return new Union27 { Value = value };}
	public static implicit operator Union27(bool value){return new Union27 { Value = value };}
}

///<summary>
///<see cref="Node"/> or <see cref="DOMString"/>
///</summary>
public struct Union28
{
	public dynamic Value { get; set; }
	public static implicit operator Union28(Node value){return new Union28 { Value = value };}
	public static implicit operator Union28(DOMString value){return new Union28 { Value = value };}
}

///<summary>
///<see cref="Node"/> or <see cref="DOMString"/>
///</summary>
public struct Union29
{
	public dynamic Value { get; set; }
	public static implicit operator Union29(Node value){return new Union29 { Value = value };}
	public static implicit operator Union29(DOMString value){return new Union29 { Value = value };}
}

///<summary>
///<see cref="Node"/> or <see cref="DOMString"/>
///</summary>
public struct Union30
{
	public dynamic Value { get; set; }
	public static implicit operator Union30(Node value){return new Union30 { Value = value };}
	public static implicit operator Union30(DOMString value){return new Union30 { Value = value };}
}

///<summary>
///<see cref="Node"/> or <see cref="DOMString"/>
///</summary>
public struct Union31
{
	public dynamic Value { get; set; }
	public static implicit operator Union31(Node value){return new Union31 { Value = value };}
	public static implicit operator Union31(DOMString value){return new Union31 { Value = value };}
}

///<summary>
///<see cref="Node"/> or <see cref="DOMString"/>
///</summary>
public struct Union32
{
	public dynamic Value { get; set; }
	public static implicit operator Union32(Node value){return new Union32 { Value = value };}
	public static implicit operator Union32(DOMString value){return new Union32 { Value = value };}
}

///<summary>
///<see cref="Node"/> or <see cref="DOMString"/>
///</summary>
public struct Union33
{
	public dynamic Value { get; set; }
	public static implicit operator Union33(Node value){return new Union33 { Value = value };}
	public static implicit operator Union33(DOMString value){return new Union33 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="ElementCreationOptions"/>
///</summary>
public struct Union34
{
	public dynamic Value { get; set; }
	public static implicit operator Union34(DOMString value){return new Union34 { Value = value };}
	public static implicit operator Union34(ElementCreationOptions value){return new Union34 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="ElementCreationOptions"/>
///</summary>
public struct Union35
{
	public dynamic Value { get; set; }
	public static implicit operator Union35(DOMString value){return new Union35 { Value = value };}
	public static implicit operator Union35(ElementCreationOptions value){return new Union35 { Value = value };}
}

///<summary>
///<see cref="MediaKeyStatus"/> or <see cref="Undefined"/>
///</summary>
public struct Union36
{
	public dynamic Value { get; set; }
	public static implicit operator Union36(MediaKeyStatus value){return new Union36 { Value = value };}
	public static implicit operator Union36(Undefined value){return new Union36 { Value = value };}
}

///<summary>
///<see cref="USVString"/> or <see cref="FencedFrameConfig"/>
///</summary>
public struct Union37
{
	public dynamic Value { get; set; }
	public static implicit operator Union37(USVString value){return new Union37 { Value = value };}
	public static implicit operator Union37(FencedFrameConfig value){return new Union37 { Value = value };}
}

///<summary>
///<see cref="FenceEvent"/> or <see cref="DOMString"/>
///</summary>
public struct Union38
{
	public dynamic Value { get; set; }
	public static implicit operator Union38(FenceEvent value){return new Union38 { Value = value };}
	public static implicit operator Union38(DOMString value){return new Union38 { Value = value };}
}

///<summary>
///<see cref="List{List{ByteString}}"/> or <see cref="Dictionary{ByteString, ByteString}"/>
///</summary>
public struct Union39
{
	public dynamic Value { get; set; }
	public static implicit operator Union39(List<List<ByteString>> value){return new Union39 { Value = value };}
	public static implicit operator Union39(Dictionary<ByteString, ByteString> value){return new Union39 { Value = value };}
}

///<summary>
///<see cref="Blob"/> or <see cref="BufferSource"/> or <see cref="FormData"/> or <see cref="URLSearchParams"/> or <see cref="USVString"/>
///</summary>
public struct Union40
{
	public dynamic Value { get; set; }
	public static implicit operator Union40(Blob value){return new Union40 { Value = value };}
	public static implicit operator Union40(BufferSource value){return new Union40 { Value = value };}
	public static implicit operator Union40(FormData value){return new Union40 { Value = value };}
	public static implicit operator Union40(URLSearchParams value){return new Union40 { Value = value };}
	public static implicit operator Union40(USVString value){return new Union40 { Value = value };}
}

///<summary>
///<see cref="ReadableStream"/> or <see cref="XMLHttpRequestBodyInit"/>
///</summary>
public struct Union41
{
	public dynamic Value { get; set; }
	public static implicit operator Union41(ReadableStream value){return new Union41 { Value = value };}
	public static implicit operator Union41(XMLHttpRequestBodyInit value){return new Union41 { Value = value };}
}

///<summary>
///<see cref="Request"/> or <see cref="USVString"/>
///</summary>
public struct Union42
{
	public dynamic Value { get; set; }
	public static implicit operator Union42(Request value){return new Union42 { Value = value };}
	public static implicit operator Union42(USVString value){return new Union42 { Value = value };}
}

///<summary>
///<see cref="WellKnownDirectory"/> or <see cref="FileSystemHandle"/>
///</summary>
public struct Union43
{
	public dynamic Value { get; set; }
	public static implicit operator Union43(WellKnownDirectory value){return new Union43 { Value = value };}
	public static implicit operator Union43(FileSystemHandle value){return new Union43 { Value = value };}
}

///<summary>
///<see cref="BufferSource"/> or <see cref="Blob"/> or <see cref="USVString"/>
///</summary>
public struct Union44
{
	public dynamic Value { get; set; }
	public static implicit operator Union44(BufferSource value){return new Union44 { Value = value };}
	public static implicit operator Union44(Blob value){return new Union44 { Value = value };}
	public static implicit operator Union44(USVString value){return new Union44 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="byte"/>
///</summary>
public struct Union45
{
	public dynamic Value { get; set; }
	public static implicit operator Union45(DOMString value){return new Union45 { Value = value };}
	public static implicit operator Union45(byte[] value){return new Union45 { Value = value };}
}

///<summary>
///<see cref="Blob"/> or <see cref="MediaSource"/>
///</summary>
public struct Union46
{
	public dynamic Value { get; set; }
	public static implicit operator Union46(Blob value){return new Union46 { Value = value };}
	public static implicit operator Union46(MediaSource value){return new Union46 { Value = value };}
}

///<summary>
///<see cref="BufferSource"/> or <see cref="Blob"/> or <see cref="USVString"/>
///</summary>
public struct Union47
{
	public dynamic Value { get; set; }
	public static implicit operator Union47(BufferSource value){return new Union47 { Value = value };}
	public static implicit operator Union47(Blob value){return new Union47 { Value = value };}
	public static implicit operator Union47(USVString value){return new Union47 { Value = value };}
}

///<summary>
///<see cref="BufferSource"/> or <see cref="Blob"/> or <see cref="USVString"/> or <see cref="WriteParams"/>
///</summary>
public struct Union48
{
	public dynamic Value { get; set; }
	public static implicit operator Union48(BufferSource value){return new Union48 { Value = value };}
	public static implicit operator Union48(Blob value){return new Union48 { Value = value };}
	public static implicit operator Union48(USVString value){return new Union48 { Value = value };}
	public static implicit operator Union48(WriteParams value){return new Union48 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="List{double}"/>
///</summary>
public struct Union49
{
	public dynamic Value { get; set; }
	public static implicit operator Union49(DOMString value){return new Union49 { Value = value };}
	public static implicit operator Union49(List<double> value){return new Union49 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="List{double}"/>
///</summary>
public struct Union50
{
	public dynamic Value { get; set; }
	public static implicit operator Union50(DOMString value){return new Union50 { Value = value };}
	public static implicit operator Union50(List<double> value){return new Union50 { Value = value };}
}

///<summary>
///<see cref="HTMLCollection"/> or <see cref="Element"/>
///</summary>
public struct Union51
{
	public dynamic Value { get; set; }
	public static implicit operator Union51(HTMLCollection value){return new Union51 { Value = value };}
	public static implicit operator Union51(Element value){return new Union51 { Value = value };}
}

///<summary>
///<see cref="HTMLCollection"/> or <see cref="Element"/>
///</summary>
public struct Union52
{
	public dynamic Value { get; set; }
	public static implicit operator Union52(HTMLCollection value){return new Union52 { Value = value };}
	public static implicit operator Union52(Element value){return new Union52 { Value = value };}
}

///<summary>
///<see cref="RadioNodeList"/> or <see cref="Element"/>
///</summary>
public struct Union53
{
	public dynamic Value { get; set; }
	public static implicit operator Union53(RadioNodeList value){return new Union53 { Value = value };}
	public static implicit operator Union53(Element value){return new Union53 { Value = value };}
}

///<summary>
///<see cref="HTMLOptionElement"/> or <see cref="HTMLOptGroupElement"/>
///</summary>
public struct Union54
{
	public dynamic Value { get; set; }
	public static implicit operator Union54(HTMLOptionElement value){return new Union54 { Value = value };}
	public static implicit operator Union54(HTMLOptGroupElement value){return new Union54 { Value = value };}
}

///<summary>
///<see cref="HTMLElement"/> or <see cref="long"/>
///</summary>
public struct Union55
{
	public dynamic Value { get; set; }
	public static implicit operator Union55(HTMLElement value){return new Union55 { Value = value };}
	public static implicit operator Union55(long value){return new Union55 { Value = value };}
}

///<summary>
///<see cref="HTMLScriptElement"/> or <see cref="SVGScriptElement"/>
///</summary>
public struct Union56
{
	public dynamic Value { get; set; }
	public static implicit operator Union56(HTMLScriptElement value){return new Union56 { Value = value };}
	public static implicit operator Union56(SVGScriptElement value){return new Union56 { Value = value };}
}

///<summary>
///<see cref="TrustedHTML"/> or <see cref="DOMString"/>
///</summary>
public struct Union57
{
	public dynamic Value { get; set; }
	public static implicit operator Union57(TrustedHTML value){return new Union57 { Value = value };}
	public static implicit operator Union57(DOMString value){return new Union57 { Value = value };}
}

///<summary>
///<see cref="TrustedHTML"/> or <see cref="DOMString"/>
///</summary>
public struct Union58
{
	public dynamic Value { get; set; }
	public static implicit operator Union58(TrustedHTML value){return new Union58 { Value = value };}
	public static implicit operator Union58(DOMString value){return new Union58 { Value = value };}
}

///<summary>
///<see cref="TrustedHTML"/> or <see cref="DOMString"/>
///</summary>
public struct Union59
{
	public dynamic Value { get; set; }
	public static implicit operator Union59(TrustedHTML value){return new Union59 { Value = value };}
	public static implicit operator Union59(DOMString value){return new Union59 { Value = value };}
}

///<summary>
///<see cref="bool"/> or <see cref="double"/> or <see cref="DOMString"/>
///</summary>
public struct Union60
{
	public dynamic Value { get; set; }
	public static implicit operator Union60(bool value){return new Union60 { Value = value };}
	public static implicit operator Union60(double value){return new Union60 { Value = value };}
	public static implicit operator Union60(DOMString value){return new Union60 { Value = value };}
}

///<summary>
///<see cref="TogglePopoverOptions"/> or <see cref="bool"/>
///</summary>
public struct Union61
{
	public dynamic Value { get; set; }
	public static implicit operator Union61(TogglePopoverOptions value){return new Union61 { Value = value };}
	public static implicit operator Union61(bool value){return new Union61 { Value = value };}
}

///<summary>
///<see cref="TrustedHTML"/> or <see cref="DOMString"/>
///</summary>
public struct Union62
{
	public dynamic Value { get; set; }
	public static implicit operator Union62(TrustedHTML value){return new Union62 { Value = value };}
	public static implicit operator Union62(DOMString value){return new Union62 { Value = value };}
}

///<summary>
///<see cref="MediaStream"/> or <see cref="MediaSource"/> or <see cref="Blob"/>
///</summary>
public struct Union63
{
	public dynamic Value { get; set; }
	public static implicit operator Union63(MediaStream value){return new Union63 { Value = value };}
	public static implicit operator Union63(MediaSource value){return new Union63 { Value = value };}
	public static implicit operator Union63(Blob value){return new Union63 { Value = value };}
}

///<summary>
///<see cref="VideoTrack"/> or <see cref="AudioTrack"/> or <see cref="TextTrack"/>
///</summary>
public struct Union64
{
	public dynamic Value { get; set; }
	public static implicit operator Union64(VideoTrack value){return new Union64 { Value = value };}
	public static implicit operator Union64(AudioTrack value){return new Union64 { Value = value };}
	public static implicit operator Union64(TextTrack value){return new Union64 { Value = value };}
}

///<summary>
///<see cref="VideoTrack"/> or <see cref="AudioTrack"/> or <see cref="TextTrack"/>
///</summary>
public struct Union65
{
	public dynamic Value { get; set; }
	public static implicit operator Union65(VideoTrack value){return new Union65 { Value = value };}
	public static implicit operator Union65(AudioTrack value){return new Union65 { Value = value };}
	public static implicit operator Union65(TextTrack value){return new Union65 { Value = value };}
}

///<summary>
///<see cref="RadioNodeList"/> or <see cref="Element"/>
///</summary>
public struct Union66
{
	public dynamic Value { get; set; }
	public static implicit operator Union66(RadioNodeList value){return new Union66 { Value = value };}
	public static implicit operator Union66(Element value){return new Union66 { Value = value };}
}

///<summary>
///<see cref="HTMLOptionElement"/> or <see cref="HTMLOptGroupElement"/>
///</summary>
public struct Union67
{
	public dynamic Value { get; set; }
	public static implicit operator Union67(HTMLOptionElement value){return new Union67 { Value = value };}
	public static implicit operator Union67(HTMLOptGroupElement value){return new Union67 { Value = value };}
}

///<summary>
///<see cref="HTMLElement"/> or <see cref="long"/>
///</summary>
public struct Union68
{
	public dynamic Value { get; set; }
	public static implicit operator Union68(HTMLElement value){return new Union68 { Value = value };}
	public static implicit operator Union68(long value){return new Union68 { Value = value };}
}

///<summary>
///<see cref="Element"/> or <see cref="Text"/>
///</summary>
public struct Union69
{
	public dynamic Value { get; set; }
	public static implicit operator Union69(Element value){return new Union69 { Value = value };}
	public static implicit operator Union69(Text value){return new Union69 { Value = value };}
}

///<summary>
///<see cref="CanvasRenderingContext2D"/> or <see cref="ImageBitmapRenderingContext"/> or <see cref="WebGLRenderingContext"/> or <see cref="WebGL2RenderingContext"/> or <see cref="GPUCanvasContext"/>
///</summary>
public struct Union70
{
	public dynamic Value { get; set; }
	public static implicit operator Union70(CanvasRenderingContext2D value){return new Union70 { Value = value };}
	public static implicit operator Union70(ImageBitmapRenderingContext value){return new Union70 { Value = value };}
	public static implicit operator Union70(WebGLRenderingContext value){return new Union70 { Value = value };}
	public static implicit operator Union70(WebGL2RenderingContext value){return new Union70 { Value = value };}
	public static implicit operator Union70(GPUCanvasContext value){return new Union70 { Value = value };}
}

///<summary>
///<see cref="HTMLImageElement"/> or <see cref="SVGImageElement"/>
///</summary>
public struct Union71
{
	public dynamic Value { get; set; }
	public static implicit operator Union71(HTMLImageElement value){return new Union71 { Value = value };}
	public static implicit operator Union71(SVGImageElement value){return new Union71 { Value = value };}
}

///<summary>
///<see cref="HTMLOrSVGImageElement"/> or <see cref="HTMLVideoElement"/> or <see cref="HTMLCanvasElement"/> or <see cref="ImageBitmap"/> or <see cref="OffscreenCanvas"/> or <see cref="VideoFrame"/>
///</summary>
public struct Union72
{
	public dynamic Value { get; set; }
	public static implicit operator Union72(HTMLOrSVGImageElement value){return new Union72 { Value = value };}
	public static implicit operator Union72(HTMLVideoElement value){return new Union72 { Value = value };}
	public static implicit operator Union72(HTMLCanvasElement value){return new Union72 { Value = value };}
	public static implicit operator Union72(ImageBitmap value){return new Union72 { Value = value };}
	public static implicit operator Union72(OffscreenCanvas value){return new Union72 { Value = value };}
	public static implicit operator Union72(VideoFrame value){return new Union72 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="CanvasGradient"/> or <see cref="CanvasPattern"/>
///</summary>
public struct Union73
{
	public dynamic Value { get; set; }
	public static implicit operator Union73(DOMString value){return new Union73 { Value = value };}
	public static implicit operator Union73(CanvasGradient value){return new Union73 { Value = value };}
	public static implicit operator Union73(CanvasPattern value){return new Union73 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="CanvasGradient"/> or <see cref="CanvasPattern"/>
///</summary>
public struct Union74
{
	public dynamic Value { get; set; }
	public static implicit operator Union74(DOMString value){return new Union74 { Value = value };}
	public static implicit operator Union74(CanvasGradient value){return new Union74 { Value = value };}
	public static implicit operator Union74(CanvasPattern value){return new Union74 { Value = value };}
}

///<summary>
///<see cref="double"/> or <see cref="DOMPointInit"/>
///</summary>
public struct Union76
{
	public dynamic Value { get; set; }
	public static implicit operator Union76(double value){return new Union76 { Value = value };}
	public static implicit operator Union76(DOMPointInit value){return new Union76 { Value = value };}
}

///<summary>
///<see cref="double"/> or <see cref="DOMPointInit"/> or <see cref="List{Union76}"/>
///</summary>
public struct Union75
{
	public dynamic Value { get; set; }
	public static implicit operator Union75(double value){return new Union75 { Value = value };}
	public static implicit operator Union75(DOMPointInit value){return new Union75 { Value = value };}
	public static implicit operator Union75(List<Union76> value){return new Union75 { Value = value };}
}

///<summary>
///<see cref="Path2D"/> or <see cref="DOMString"/>
///</summary>
public struct Union77
{
	public dynamic Value { get; set; }
	public static implicit operator Union77(Path2D value){return new Union77 { Value = value };}
	public static implicit operator Union77(DOMString value){return new Union77 { Value = value };}
}

///<summary>
///<see cref="HTMLCanvasElement"/> or <see cref="OffscreenCanvas"/>
///</summary>
public struct Union78
{
	public dynamic Value { get; set; }
	public static implicit operator Union78(HTMLCanvasElement value){return new Union78 { Value = value };}
	public static implicit operator Union78(OffscreenCanvas value){return new Union78 { Value = value };}
}

///<summary>
///<see cref="OffscreenCanvasRenderingContext2D"/> or <see cref="ImageBitmapRenderingContext"/> or <see cref="WebGLRenderingContext"/> or <see cref="WebGL2RenderingContext"/> or <see cref="GPUCanvasContext"/>
///</summary>
public struct Union79
{
	public dynamic Value { get; set; }
	public static implicit operator Union79(OffscreenCanvasRenderingContext2D value){return new Union79 { Value = value };}
	public static implicit operator Union79(ImageBitmapRenderingContext value){return new Union79 { Value = value };}
	public static implicit operator Union79(WebGLRenderingContext value){return new Union79 { Value = value };}
	public static implicit operator Union79(WebGL2RenderingContext value){return new Union79 { Value = value };}
	public static implicit operator Union79(GPUCanvasContext value){return new Union79 { Value = value };}
}

///<summary>
///<see cref="CustomElementConstructor"/> or <see cref="Undefined"/>
///</summary>
public struct Union80
{
	public dynamic Value { get; set; }
	public static implicit operator Union80(CustomElementConstructor value){return new Union80 { Value = value };}
	public static implicit operator Union80(Undefined value){return new Union80 { Value = value };}
}

///<summary>
///<see cref="File"/> or <see cref="USVString"/> or <see cref="FormData"/>
///</summary>
public struct Union81
{
	public dynamic Value { get; set; }
	public static implicit operator Union81(File value){return new Union81 { Value = value };}
	public static implicit operator Union81(USVString value){return new Union81 { Value = value };}
	public static implicit operator Union81(FormData value){return new Union81 { Value = value };}
}

///<summary>
///<see cref="File"/> or <see cref="USVString"/> or <see cref="FormData"/>
///</summary>
public struct Union82
{
	public dynamic Value { get; set; }
	public static implicit operator Union82(File value){return new Union82 { Value = value };}
	public static implicit operator Union82(USVString value){return new Union82 { Value = value };}
	public static implicit operator Union82(FormData value){return new Union82 { Value = value };}
}

///<summary>
///<see cref="Event"/> or <see cref="DOMString"/>
///</summary>
public struct Union83
{
	public dynamic Value { get; set; }
	public static implicit operator Union83(Event value){return new Union83 { Value = value };}
	public static implicit operator Union83(DOMString value){return new Union83 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="Function"/> or <see cref="TrustedScript"/>
///</summary>
public struct Union84
{
	public dynamic Value { get; set; }
	public static implicit operator Union84(DOMString value){return new Union84 { Value = value };}
	public static implicit operator Union84(Function value){return new Union84 { Value = value };}
	public static implicit operator Union84(TrustedScript value){return new Union84 { Value = value };}
}

///<summary>
///<see cref="TrustedHTML"/> or <see cref="DOMString"/>
///</summary>
public struct Union85
{
	public dynamic Value { get; set; }
	public static implicit operator Union85(TrustedHTML value){return new Union85 { Value = value };}
	public static implicit operator Union85(DOMString value){return new Union85 { Value = value };}
}

///<summary>
///<see cref="TrustedHTML"/> or <see cref="DOMString"/>
///</summary>
public struct Union86
{
	public dynamic Value { get; set; }
	public static implicit operator Union86(TrustedHTML value){return new Union86 { Value = value };}
	public static implicit operator Union86(DOMString value){return new Union86 { Value = value };}
}

///<summary>
///<see cref="TrustedHTML"/> or <see cref="DOMString"/>
///</summary>
public struct Union87
{
	public dynamic Value { get; set; }
	public static implicit operator Union87(TrustedHTML value){return new Union87 { Value = value };}
	public static implicit operator Union87(DOMString value){return new Union87 { Value = value };}
}

///<summary>
///<see cref="TrustedHTML"/> or <see cref="DOMString"/>
///</summary>
public struct Union88
{
	public dynamic Value { get; set; }
	public static implicit operator Union88(TrustedHTML value){return new Union88 { Value = value };}
	public static implicit operator Union88(DOMString value){return new Union88 { Value = value };}
}

///<summary>
///<see cref="TrustedHTML"/> or <see cref="DOMString"/>
///</summary>
public struct Union89
{
	public dynamic Value { get; set; }
	public static implicit operator Union89(TrustedHTML value){return new Union89 { Value = value };}
	public static implicit operator Union89(DOMString value){return new Union89 { Value = value };}
}

///<summary>
///<see cref="TrustedHTML"/> or <see cref="DOMString"/>
///</summary>
public struct Union90
{
	public dynamic Value { get; set; }
	public static implicit operator Union90(TrustedHTML value){return new Union90 { Value = value };}
	public static implicit operator Union90(DOMString value){return new Union90 { Value = value };}
}

///<summary>
///<see cref="TrustedHTML"/> or <see cref="DOMString"/>
///</summary>
public struct Union91
{
	public dynamic Value { get; set; }
	public static implicit operator Union91(TrustedHTML value){return new Union91 { Value = value };}
	public static implicit operator Union91(DOMString value){return new Union91 { Value = value };}
}

///<summary>
///<see cref="TrustedHTML"/> or <see cref="DOMString"/>
///</summary>
public struct Union92
{
	public dynamic Value { get; set; }
	public static implicit operator Union92(TrustedHTML value){return new Union92 { Value = value };}
	public static implicit operator Union92(DOMString value){return new Union92 { Value = value };}
}

///<summary>
///<see cref="CanvasImageSource"/> or <see cref="Blob"/> or <see cref="ImageData"/>
///</summary>
public struct Union93
{
	public dynamic Value { get; set; }
	public static implicit operator Union93(CanvasImageSource value){return new Union93 { Value = value };}
	public static implicit operator Union93(Blob value){return new Union93 { Value = value };}
	public static implicit operator Union93(ImageData value){return new Union93 { Value = value };}
}

///<summary>
///<see cref="WindowProxy"/> or <see cref="MessagePort"/> or <see cref="ServiceWorker"/>
///</summary>
public struct Union94
{
	public dynamic Value { get; set; }
	public static implicit operator Union94(WindowProxy value){return new Union94 { Value = value };}
	public static implicit operator Union94(MessagePort value){return new Union94 { Value = value };}
	public static implicit operator Union94(ServiceWorker value){return new Union94 { Value = value };}
}

///<summary>
///<see cref="TrustedScriptURL"/> or <see cref="USVString"/>
///</summary>
public struct Union95
{
	public dynamic Value { get; set; }
	public static implicit operator Union95(TrustedScriptURL value){return new Union95 { Value = value };}
	public static implicit operator Union95(USVString value){return new Union95 { Value = value };}
}

///<summary>
///<see cref="TrustedScriptURL"/> or <see cref="USVString"/>
///</summary>
public struct Union96
{
	public dynamic Value { get; set; }
	public static implicit operator Union96(TrustedScriptURL value){return new Union96 { Value = value };}
	public static implicit operator Union96(USVString value){return new Union96 { Value = value };}
}

///<summary>
///<see cref="TrustedScriptURL"/> or <see cref="USVString"/>
///</summary>
public struct Union97
{
	public dynamic Value { get; set; }
	public static implicit operator Union97(TrustedScriptURL value){return new Union97 { Value = value };}
	public static implicit operator Union97(USVString value){return new Union97 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="WorkerOptions"/>
///</summary>
public struct Union98
{
	public dynamic Value { get; set; }
	public static implicit operator Union98(DOMString value){return new Union98 { Value = value };}
	public static implicit operator Union98(WorkerOptions value){return new Union98 { Value = value };}
}

///<summary>
///<see cref="bool"/> or <see cref="ConstrainDouble"/>
///</summary>
public struct Union99
{
	public dynamic Value { get; set; }
	public static implicit operator Union99(bool value){return new Union99 { Value = value };}
	public static implicit operator Union99(ConstrainDouble value){return new Union99 { Value = value };}
}

///<summary>
///<see cref="bool"/> or <see cref="ConstrainDouble"/>
///</summary>
public struct Union100
{
	public dynamic Value { get; set; }
	public static implicit operator Union100(bool value){return new Union100 { Value = value };}
	public static implicit operator Union100(ConstrainDouble value){return new Union100 { Value = value };}
}

///<summary>
///<see cref="bool"/> or <see cref="ConstrainDouble"/>
///</summary>
public struct Union101
{
	public dynamic Value { get; set; }
	public static implicit operator Union101(bool value){return new Union101 { Value = value };}
	public static implicit operator Union101(ConstrainDouble value){return new Union101 { Value = value };}
}

///<summary>
///<see cref="List{Point2D}"/> or <see cref="ConstrainPoint2DParameters"/>
///</summary>
public struct Union102
{
	public dynamic Value { get; set; }
	public static implicit operator Union102(List<Point2D> value){return new Union102 { Value = value };}
	public static implicit operator Union102(ConstrainPoint2DParameters value){return new Union102 { Value = value };}
}

///<summary>
///<see cref="IDBObjectStore"/> or <see cref="IDBIndex"/> or <see cref="IDBCursor"/>
///</summary>
public struct Union103
{
	public dynamic Value { get; set; }
	public static implicit operator Union103(IDBObjectStore value){return new Union103 { Value = value };}
	public static implicit operator Union103(IDBIndex value){return new Union103 { Value = value };}
	public static implicit operator Union103(IDBCursor value){return new Union103 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="List{DOMString}"/>
///</summary>
public struct Union104
{
	public dynamic Value { get; set; }
	public static implicit operator Union104(DOMString value){return new Union104 { Value = value };}
	public static implicit operator Union104(List<DOMString> value){return new Union104 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="List{DOMString}"/>
///</summary>
public struct Union105
{
	public dynamic Value { get; set; }
	public static implicit operator Union105(DOMString value){return new Union105 { Value = value };}
	public static implicit operator Union105(List<DOMString> value){return new Union105 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="List{DOMString}"/>
///</summary>
public struct Union106
{
	public dynamic Value { get; set; }
	public static implicit operator Union106(DOMString value){return new Union106 { Value = value };}
	public static implicit operator Union106(List<DOMString> value){return new Union106 { Value = value };}
}

///<summary>
///<see cref="IDBObjectStore"/> or <see cref="IDBIndex"/>
///</summary>
public struct Union107
{
	public dynamic Value { get; set; }
	public static implicit operator Union107(IDBObjectStore value){return new Union107 { Value = value };}
	public static implicit operator Union107(IDBIndex value){return new Union107 { Value = value };}
}

///<summary>
///<see cref="Element"/> or <see cref="Document"/>
///</summary>
public struct Union108
{
	public dynamic Value { get; set; }
	public static implicit operator Union108(Element value){return new Union108 { Value = value };}
	public static implicit operator Union108(Document value){return new Union108 { Value = value };}
}

///<summary>
///<see cref="Element"/> or <see cref="Document"/>
///</summary>
public struct Union109
{
	public dynamic Value { get; set; }
	public static implicit operator Union109(Element value){return new Union109 { Value = value };}
	public static implicit operator Union109(Document value){return new Union109 { Value = value };}
}

///<summary>
///<see cref="Number"/> or <see cref="List{Number}"/>
///</summary>
public struct Union110
{
	public dynamic Value { get; set; }
	public static implicit operator Union110(Number value){return new Union110 { Value = value };}
	public static implicit operator Union110(List<Number> value){return new Union110 { Value = value };}
}

///<summary>
///<see cref="bool"/> or <see cref="MediaTrackConstraints"/>
///</summary>
public struct Union111
{
	public dynamic Value { get; set; }
	public static implicit operator Union111(bool value){return new Union111 { Value = value };}
	public static implicit operator Union111(MediaTrackConstraints value){return new Union111 { Value = value };}
}

///<summary>
///<see cref="bool"/> or <see cref="MediaTrackConstraints"/>
///</summary>
public struct Union112
{
	public dynamic Value { get; set; }
	public static implicit operator Union112(bool value){return new Union112 { Value = value };}
	public static implicit operator Union112(MediaTrackConstraints value){return new Union112 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="List{DOMString}"/>
///</summary>
public struct Union113
{
	public dynamic Value { get; set; }
	public static implicit operator Union113(DOMString value){return new Union113 { Value = value };}
	public static implicit operator Union113(List<DOMString> value){return new Union113 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="List{DOMString}"/>
///</summary>
public struct Union114
{
	public dynamic Value { get; set; }
	public static implicit operator Union114(DOMString value){return new Union114 { Value = value };}
	public static implicit operator Union114(List<DOMString> value){return new Union114 { Value = value };}
}

///<summary>
///<see cref="ulong"/> or <see cref="ConstrainULongRange"/>
///</summary>
public struct Union115
{
	public dynamic Value { get; set; }
	public static implicit operator Union115(ulong value){return new Union115 { Value = value };}
	public static implicit operator Union115(ConstrainULongRange value){return new Union115 { Value = value };}
}

///<summary>
///<see cref="Number"/> or <see cref="ConstrainDoubleRange"/>
///</summary>
public struct Union116
{
	public dynamic Value { get; set; }
	public static implicit operator Union116(Number value){return new Union116 { Value = value };}
	public static implicit operator Union116(ConstrainDoubleRange value){return new Union116 { Value = value };}
}

///<summary>
///<see cref="bool"/> or <see cref="ConstrainBooleanParameters"/>
///</summary>
public struct Union117
{
	public dynamic Value { get; set; }
	public static implicit operator Union117(bool value){return new Union117 { Value = value };}
	public static implicit operator Union117(ConstrainBooleanParameters value){return new Union117 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="List{DOMString}"/> or <see cref="ConstrainDOMStringParameters"/>
///</summary>
public struct Union118
{
	public dynamic Value { get; set; }
	public static implicit operator Union118(DOMString value){return new Union118 { Value = value };}
	public static implicit operator Union118(List<DOMString> value){return new Union118 { Value = value };}
	public static implicit operator Union118(ConstrainDOMStringParameters value){return new Union118 { Value = value };}
}

///<summary>
///<see cref="ObservableSubscriptionCallback"/> or <see cref="SubscriptionObserver"/>
///</summary>
public struct Union119
{
	public dynamic Value { get; set; }
	public static implicit operator Union119(ObservableSubscriptionCallback value){return new Union119 { Value = value };}
	public static implicit operator Union119(SubscriptionObserver value){return new Union119 { Value = value };}
}

///<summary>
///<see cref="ObservableSubscriptionCallback"/> or <see cref="ObservableInspector"/>
///</summary>
public struct Union120
{
	public dynamic Value { get; set; }
	public static implicit operator Union120(ObservableSubscriptionCallback value){return new Union120 { Value = value };}
	public static implicit operator Union120(ObservableInspector value){return new Union120 { Value = value };}
}

///<summary>
///<see cref="System.Single"/> or <see cref="System.Double"/> or <see cref="DOMMatrix"/>
///</summary>
public struct Union121
{
	public dynamic Value { get; set; }
	public static implicit operator Union121(System.Single value){return new Union121 { Value = value };}
	public static implicit operator Union121(System.Double value){return new Union121 { Value = value };}
	public static implicit operator Union121(DOMMatrix value){return new Union121 { Value = value };}
}

///<summary>
///<see cref="BufferSource"/> or <see cref="DOMString"/>
///</summary>
public struct Union122
{
	public dynamic Value { get; set; }
	public static implicit operator Union122(BufferSource value){return new Union122 { Value = value };}
	public static implicit operator Union122(DOMString value){return new Union122 { Value = value };}
}

///<summary>
///<see cref="BufferSource"/> or <see cref="USVString"/>
///</summary>
public struct Union123
{
	public dynamic Value { get; set; }
	public static implicit operator Union123(BufferSource value){return new Union123 { Value = value };}
	public static implicit operator Union123(USVString value){return new Union123 { Value = value };}
}

///<summary>
///<see cref="Blob"/> or <see cref="MediaSource"/>
///</summary>
public struct Union124
{
	public dynamic Value { get; set; }
	public static implicit operator Union124(Blob value){return new Union124 { Value = value };}
	public static implicit operator Union124(MediaSource value){return new Union124 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="SharedWorkerOptions"/>
///</summary>
public struct Union125
{
	public dynamic Value { get; set; }
	public static implicit operator Union125(DOMString value){return new Union125 { Value = value };}
	public static implicit operator Union125(SharedWorkerOptions value){return new Union125 { Value = value };}
}

///<summary>
///<see cref="Sanitizer"/> or <see cref="SanitizerConfig"/> or <see cref="SanitizerPresets"/>
///</summary>
public struct Union126
{
	public dynamic Value { get; set; }
	public static implicit operator Union126(Sanitizer value){return new Union126 { Value = value };}
	public static implicit operator Union126(SanitizerConfig value){return new Union126 { Value = value };}
	public static implicit operator Union126(SanitizerPresets value){return new Union126 { Value = value };}
}

///<summary>
///<see cref="Sanitizer"/> or <see cref="SanitizerConfig"/> or <see cref="SanitizerPresets"/>
///</summary>
public struct Union127
{
	public dynamic Value { get; set; }
	public static implicit operator Union127(Sanitizer value){return new Union127 { Value = value };}
	public static implicit operator Union127(SanitizerConfig value){return new Union127 { Value = value };}
	public static implicit operator Union127(SanitizerPresets value){return new Union127 { Value = value };}
}

///<summary>
///<see cref="SanitizerConfig"/> or <see cref="SanitizerPresets"/>
///</summary>
public struct Union128
{
	public dynamic Value { get; set; }
	public static implicit operator Union128(SanitizerConfig value){return new Union128 { Value = value };}
	public static implicit operator Union128(SanitizerPresets value){return new Union128 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="SanitizerElementNamespace"/>
///</summary>
public struct Union129
{
	public dynamic Value { get; set; }
	public static implicit operator Union129(DOMString value){return new Union129 { Value = value };}
	public static implicit operator Union129(SanitizerElementNamespace value){return new Union129 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="SanitizerElementNamespaceWithAttributes"/>
///</summary>
public struct Union130
{
	public dynamic Value { get; set; }
	public static implicit operator Union130(DOMString value){return new Union130 { Value = value };}
	public static implicit operator Union130(SanitizerElementNamespaceWithAttributes value){return new Union130 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="SanitizerAttributeNamespace"/>
///</summary>
public struct Union131
{
	public dynamic Value { get; set; }
	public static implicit operator Union131(DOMString value){return new Union131 { Value = value };}
	public static implicit operator Union131(SanitizerAttributeNamespace value){return new Union131 { Value = value };}
}

///<summary>
///<see cref="TaskPriority"/> or <see cref="TaskSignal"/>
///</summary>
public struct Union132
{
	public dynamic Value { get; set; }
	public static implicit operator Union132(TaskPriority value){return new Union132 { Value = value };}
	public static implicit operator Union132(TaskSignal value){return new Union132 { Value = value };}
}

///<summary>
///<see cref="bool"/> or <see cref="MediaTrackConstraints"/>
///</summary>
public struct Union133
{
	public dynamic Value { get; set; }
	public static implicit operator Union133(bool value){return new Union133 { Value = value };}
	public static implicit operator Union133(MediaTrackConstraints value){return new Union133 { Value = value };}
}

///<summary>
///<see cref="bool"/> or <see cref="MediaTrackConstraints"/>
///</summary>
public struct Union134
{
	public dynamic Value { get; set; }
	public static implicit operator Union134(bool value){return new Union134 { Value = value };}
	public static implicit operator Union134(MediaTrackConstraints value){return new Union134 { Value = value };}
}

///<summary>
///<see cref="CSSNumericValue"/> or <see cref="CSSKeywordValue"/>
///</summary>
public struct Union136
{
	public dynamic Value { get; set; }
	public static implicit operator Union136(CSSNumericValue value){return new Union136 { Value = value };}
	public static implicit operator Union136(CSSKeywordValue value){return new Union136 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="List{Union136}"/>
///</summary>
public struct Union135
{
	public dynamic Value { get; set; }
	public static implicit operator Union135(DOMString value){return new Union135 { Value = value };}
	public static implicit operator Union135(List<Union136> value){return new Union135 { Value = value };}
}

///<summary>
///<see cref="TrustedScriptURL"/> or <see cref="USVString"/>
///</summary>
public struct Union137
{
	public dynamic Value { get; set; }
	public static implicit operator Union137(TrustedScriptURL value){return new Union137 { Value = value };}
	public static implicit operator Union137(USVString value){return new Union137 { Value = value };}
}

///<summary>
///<see cref="RouterRule"/> or <see cref="List{RouterRule}"/>
///</summary>
public struct Union138
{
	public dynamic Value { get; set; }
	public static implicit operator Union138(RouterRule value){return new Union138 { Value = value };}
	public static implicit operator Union138(List<RouterRule> value){return new Union138 { Value = value };}
}

///<summary>
///<see cref="RouterSourceDict"/> or <see cref="RouterSourceEnum"/>
///</summary>
public struct Union139
{
	public dynamic Value { get; set; }
	public static implicit operator Union139(RouterSourceDict value){return new Union139 { Value = value };}
	public static implicit operator Union139(RouterSourceEnum value){return new Union139 { Value = value };}
}

///<summary>
///<see cref="Client"/> or <see cref="ServiceWorker"/> or <see cref="MessagePort"/>
///</summary>
public struct Union140
{
	public dynamic Value { get; set; }
	public static implicit operator Union140(Client value){return new Union140 { Value = value };}
	public static implicit operator Union140(ServiceWorker value){return new Union140 { Value = value };}
	public static implicit operator Union140(MessagePort value){return new Union140 { Value = value };}
}

///<summary>
///<see cref="Client"/> or <see cref="ServiceWorker"/> or <see cref="MessagePort"/>
///</summary>
public struct Union141
{
	public dynamic Value { get; set; }
	public static implicit operator Union141(Client value){return new Union141 { Value = value };}
	public static implicit operator Union141(ServiceWorker value){return new Union141 { Value = value };}
	public static implicit operator Union141(MessagePort value){return new Union141 { Value = value };}
}

///<summary>
///<see cref="USVString"/> or <see cref="FencedFrameConfig"/>
///</summary>
public struct Union142
{
	public dynamic Value { get; set; }
	public static implicit operator Union142(USVString value){return new Union142 { Value = value };}
	public static implicit operator Union142(FencedFrameConfig value){return new Union142 { Value = value };}
}

///<summary>
///<see cref="ReadableStreamDefaultReader"/> or <see cref="ReadableStreamBYOBReader"/>
///</summary>
public struct Union143
{
	public dynamic Value { get; set; }
	public static implicit operator Union143(ReadableStreamDefaultReader value){return new Union143 { Value = value };}
	public static implicit operator Union143(ReadableStreamBYOBReader value){return new Union143 { Value = value };}
}

///<summary>
///<see cref="ReadableStreamDefaultController"/> or <see cref="ReadableByteStreamController"/>
///</summary>
public struct Union144
{
	public dynamic Value { get; set; }
	public static implicit operator Union144(ReadableStreamDefaultController value){return new Union144 { Value = value };}
	public static implicit operator Union144(ReadableByteStreamController value){return new Union144 { Value = value };}
}

///<summary>
///<see cref="Element"/> or <see cref="CSSPseudoElement"/>
///</summary>
public struct Union145
{
	public dynamic Value { get; set; }
	public static implicit operator Union145(Element value){return new Union145 { Value = value };}
	public static implicit operator Union145(CSSPseudoElement value){return new Union145 { Value = value };}
}

///<summary>
///<see cref="TrustedHTML"/> or <see cref="TrustedScript"/> or <see cref="TrustedScriptURL"/>
///</summary>
public struct Union146
{
	public dynamic Value { get; set; }
	public static implicit operator Union146(TrustedHTML value){return new Union146 { Value = value };}
	public static implicit operator Union146(TrustedScript value){return new Union146 { Value = value };}
	public static implicit operator Union146(TrustedScriptURL value){return new Union146 { Value = value };}
}

///<summary>
///<see cref="BigInt"/> or <see cref="long"/>
///</summary>
public struct Union147
{
	public dynamic Value { get; set; }
	public static implicit operator Union147(BigInt value){return new Union147 { Value = value };}
	public static implicit operator Union147(long value){return new Union147 { Value = value };}
}

///<summary>
///<see cref="PASignalValue"/> or <see cref="BigInt"/>
///</summary>
public struct Union148
{
	public dynamic Value { get; set; }
	public static implicit operator Union148(PASignalValue value){return new Union148 { Value = value };}
	public static implicit operator Union148(BigInt value){return new Union148 { Value = value };}
}

///<summary>
///<see cref="PASignalValue"/> or <see cref="long"/>
///</summary>
public struct Union149
{
	public dynamic Value { get; set; }
	public static implicit operator Union149(PASignalValue value){return new Union149 { Value = value };}
	public static implicit operator Union149(long value){return new Union149 { Value = value };}
}

///<summary>
///<see cref="GenerateBidOutput"/> or <see cref="List{GenerateBidOutput}"/>
///</summary>
public struct Union150
{
	public dynamic Value { get; set; }
	public static implicit operator Union150(GenerateBidOutput value){return new Union150 { Value = value };}
	public static implicit operator Union150(List<GenerateBidOutput> value){return new Union150 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="AdRender"/>
///</summary>
public struct Union151
{
	public dynamic Value { get; set; }
	public static implicit operator Union151(DOMString value){return new Union151 { Value = value };}
	public static implicit operator Union151(AdRender value){return new Union151 { Value = value };}
}

///<summary>
///<see cref="long"/> or <see cref="AuctionAd"/>
///</summary>
public struct Union152
{
	public dynamic Value { get; set; }
	public static implicit operator Union152(long value){return new Union152 { Value = value };}
	public static implicit operator Union152(AuctionAd value){return new Union152 { Value = value };}
}

///<summary>
///<see cref="List{List{USVString}}"/> or <see cref="Dictionary{USVString, USVString}"/> or <see cref="USVString"/>
///</summary>
public struct Union153
{
	public dynamic Value { get; set; }
	public static implicit operator Union153(List<List<USVString>> value){return new Union153 { Value = value };}
	public static implicit operator Union153(Dictionary<USVString, USVString> value){return new Union153 { Value = value };}
	public static implicit operator Union153(USVString value){return new Union153 { Value = value };}
}

///<summary>
///<see cref="USVString"/> or <see cref="URLPatternInit"/>
///</summary>
public struct Union154
{
	public dynamic Value { get; set; }
	public static implicit operator Union154(USVString value){return new Union154 { Value = value };}
	public static implicit operator Union154(URLPatternInit value){return new Union154 { Value = value };}
}

///<summary>
///<see cref="USVString"/> or <see cref="URLPatternInit"/> or <see cref="URLPattern"/>
///</summary>
public struct Union155
{
	public dynamic Value { get; set; }
	public static implicit operator Union155(USVString value){return new Union155 { Value = value };}
	public static implicit operator Union155(URLPatternInit value){return new Union155 { Value = value };}
	public static implicit operator Union155(URLPattern value){return new Union155 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="DOMHighResTimeStamp"/>
///</summary>
public struct Union156
{
	public dynamic Value { get; set; }
	public static implicit operator Union156(DOMString value){return new Union156 { Value = value };}
	public static implicit operator Union156(DOMHighResTimeStamp value){return new Union156 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="DOMHighResTimeStamp"/>
///</summary>
public struct Union157
{
	public dynamic Value { get; set; }
	public static implicit operator Union157(DOMString value){return new Union157 { Value = value };}
	public static implicit operator Union157(DOMHighResTimeStamp value){return new Union157 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="PerformanceMeasureOptions"/>
///</summary>
public struct Union158
{
	public dynamic Value { get; set; }
	public static implicit operator Union158(DOMString value){return new Union158 { Value = value };}
	public static implicit operator Union158(PerformanceMeasureOptions value){return new Union158 { Value = value };}
}

///<summary>
///<see cref="ulong"/> or <see cref="List{ulong}"/>
///</summary>
public struct Union159
{
	public dynamic Value { get; set; }
	public static implicit operator Union159(ulong value){return new Union159 { Value = value };}
	public static implicit operator Union159(List<ulong> value){return new Union159 { Value = value };}
}

///<summary>
///<see cref="double"/> or <see cref="CSSNumericValue"/> or <see cref="DOMString"/>
///</summary>
public struct Union160
{
	public dynamic Value { get; set; }
	public static implicit operator Union160(double value){return new Union160 { Value = value };}
	public static implicit operator Union160(CSSNumericValue value){return new Union160 { Value = value };}
	public static implicit operator Union160(DOMString value){return new Union160 { Value = value };}
}

///<summary>
///<see cref="double"/> or <see cref="EffectTiming"/>
///</summary>
public struct Union161
{
	public dynamic Value { get; set; }
	public static implicit operator Union161(double value){return new Union161 { Value = value };}
	public static implicit operator Union161(EffectTiming value){return new Union161 { Value = value };}
}

///<summary>
///<see cref="double"/> or <see cref="EffectTiming"/>
///</summary>
public struct Union162
{
	public dynamic Value { get; set; }
	public static implicit operator Union162(double value){return new Union162 { Value = value };}
	public static implicit operator Union162(EffectTiming value){return new Union162 { Value = value };}
}

///<summary>
///<see cref="Element"/> or <see cref="CSSPseudoElement"/>
///</summary>
public struct Union163
{
	public dynamic Value { get; set; }
	public static implicit operator Union163(Element value){return new Union163 { Value = value };}
	public static implicit operator Union163(CSSPseudoElement value){return new Union163 { Value = value };}
}

///<summary>
///<see cref="TimelineRangeOffset"/> or <see cref="CSSNumericValue"/> or <see cref="CSSKeywordValue"/> or <see cref="DOMString"/>
///</summary>
public struct Union164
{
	public dynamic Value { get; set; }
	public static implicit operator Union164(TimelineRangeOffset value){return new Union164 { Value = value };}
	public static implicit operator Union164(CSSNumericValue value){return new Union164 { Value = value };}
	public static implicit operator Union164(CSSKeywordValue value){return new Union164 { Value = value };}
	public static implicit operator Union164(DOMString value){return new Union164 { Value = value };}
}

///<summary>
///<see cref="TimelineRangeOffset"/> or <see cref="CSSNumericValue"/> or <see cref="CSSKeywordValue"/> or <see cref="DOMString"/>
///</summary>
public struct Union165
{
	public dynamic Value { get; set; }
	public static implicit operator Union165(TimelineRangeOffset value){return new Union165 { Value = value };}
	public static implicit operator Union165(CSSNumericValue value){return new Union165 { Value = value };}
	public static implicit operator Union165(CSSKeywordValue value){return new Union165 { Value = value };}
	public static implicit operator Union165(DOMString value){return new Union165 { Value = value };}
}

///<summary>
///<see cref="double"/> or <see cref="DOMString"/>
///</summary>
public struct Union166
{
	public dynamic Value { get; set; }
	public static implicit operator Union166(double value){return new Union166 { Value = value };}
	public static implicit operator Union166(DOMString value){return new Union166 { Value = value };}
}

///<summary>
///<see cref="double"/> or <see cref="KeyframeEffectOptions"/>
///</summary>
public struct Union167
{
	public dynamic Value { get; set; }
	public static implicit operator Union167(double value){return new Union167 { Value = value };}
	public static implicit operator Union167(KeyframeEffectOptions value){return new Union167 { Value = value };}
}

///<summary>
///<see cref="Number?"/> or <see cref="List{Number?}"/>
///</summary>
public struct Union168
{
	public dynamic Value { get; set; }
	public static implicit operator Union168(Number? value){return new Union168 { Value = value };}
	public static implicit operator Union168(List<Number?> value){return new Union168 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="List{DOMString}"/>
///</summary>
public struct Union169
{
	public dynamic Value { get; set; }
	public static implicit operator Union169(DOMString value){return new Union169 { Value = value };}
	public static implicit operator Union169(List<DOMString> value){return new Union169 { Value = value };}
}

///<summary>
///<see cref="CompositeOperationOrAuto"/> or <see cref="List{CompositeOperationOrAuto}"/>
///</summary>
public struct Union170
{
	public dynamic Value { get; set; }
	public static implicit operator Union170(CompositeOperationOrAuto value){return new Union170 { Value = value };}
	public static implicit operator Union170(List<CompositeOperationOrAuto> value){return new Union170 { Value = value };}
}

///<summary>
///<see cref="double"/> or <see cref="KeyframeAnimationOptions"/>
///</summary>
public struct Union171
{
	public dynamic Value { get; set; }
	public static implicit operator Union171(double value){return new Union171 { Value = value };}
	public static implicit operator Union171(KeyframeAnimationOptions value){return new Union171 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="List{UUID}"/>
///</summary>
public struct Union172
{
	public dynamic Value { get; set; }
	public static implicit operator Union172(DOMString value){return new Union172 { Value = value };}
	public static implicit operator Union172(List<UUID> value){return new Union172 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="ulong"/>
///</summary>
public struct Union173
{
	public dynamic Value { get; set; }
	public static implicit operator Union173(DOMString value){return new Union173 { Value = value };}
	public static implicit operator Union173(ulong value){return new Union173 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="ulong"/>
///</summary>
public struct Union174
{
	public dynamic Value { get; set; }
	public static implicit operator Union174(DOMString value){return new Union174 { Value = value };}
	public static implicit operator Union174(ulong value){return new Union174 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="ulong"/>
///</summary>
public struct Union175
{
	public dynamic Value { get; set; }
	public static implicit operator Union175(DOMString value){return new Union175 { Value = value };}
	public static implicit operator Union175(ulong value){return new Union175 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="ulong"/>
///</summary>
public struct Union176
{
	public dynamic Value { get; set; }
	public static implicit operator Union176(DOMString value){return new Union176 { Value = value };}
	public static implicit operator Union176(ulong value){return new Union176 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="ulong"/>
///</summary>
public struct Union177
{
	public dynamic Value { get; set; }
	public static implicit operator Union177(DOMString value){return new Union177 { Value = value };}
	public static implicit operator Union177(ulong value){return new Union177 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="ulong"/>
///</summary>
public struct Union178
{
	public dynamic Value { get; set; }
	public static implicit operator Union178(DOMString value){return new Union178 { Value = value };}
	public static implicit operator Union178(ulong value){return new Union178 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="BufferSource"/> or <see cref="NDEFMessageInit"/>
///</summary>
public struct Union179
{
	public dynamic Value { get; set; }
	public static implicit operator Union179(DOMString value){return new Union179 { Value = value };}
	public static implicit operator Union179(BufferSource value){return new Union179 { Value = value };}
	public static implicit operator Union179(NDEFMessageInit value){return new Union179 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="AudioSinkInfo"/>
///</summary>
public struct Union180
{
	public dynamic Value { get; set; }
	public static implicit operator Union180(DOMString value){return new Union180 { Value = value };}
	public static implicit operator Union180(AudioSinkInfo value){return new Union180 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="AudioSinkOptions"/>
///</summary>
public struct Union181
{
	public dynamic Value { get; set; }
	public static implicit operator Union181(DOMString value){return new Union181 { Value = value };}
	public static implicit operator Union181(AudioSinkOptions value){return new Union181 { Value = value };}
}

///<summary>
///<see cref="AudioContextLatencyCategory"/> or <see cref="Number"/>
///</summary>
public struct Union182
{
	public dynamic Value { get; set; }
	public static implicit operator Union182(AudioContextLatencyCategory value){return new Union182 { Value = value };}
	public static implicit operator Union182(Number value){return new Union182 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="AudioSinkOptions"/>
///</summary>
public struct Union183
{
	public dynamic Value { get; set; }
	public static implicit operator Union183(DOMString value){return new Union183 { Value = value };}
	public static implicit operator Union183(AudioSinkOptions value){return new Union183 { Value = value };}
}

///<summary>
///<see cref="AudioContextRenderSizeCategory"/> or <see cref="ulong"/>
///</summary>
public struct Union184
{
	public dynamic Value { get; set; }
	public static implicit operator Union184(AudioContextRenderSizeCategory value){return new Union184 { Value = value };}
	public static implicit operator Union184(ulong value){return new Union184 { Value = value };}
}

///<summary>
///<see cref="AudioContextRenderSizeCategory"/> or <see cref="ulong"/>
///</summary>
public struct Union185
{
	public dynamic Value { get; set; }
	public static implicit operator Union185(AudioContextRenderSizeCategory value){return new Union185 { Value = value };}
	public static implicit operator Union185(ulong value){return new Union185 { Value = value };}
}

///<summary>
///<see cref="AllowSharedBufferSource"/> or <see cref="ReadableStream"/>
///</summary>
public struct Union186
{
	public dynamic Value { get; set; }
	public static implicit operator Union186(AllowSharedBufferSource value){return new Union186 { Value = value };}
	public static implicit operator Union186(ReadableStream value){return new Union186 { Value = value };}
}

///<summary>
///<see cref="Object"/> or <see cref="DOMString"/>
///</summary>
public struct Union187
{
	public dynamic Value { get; set; }
	public static implicit operator Union187(Object value){return new Union187 { Value = value };}
	public static implicit operator Union187(DOMString value){return new Union187 { Value = value };}
}

///<summary>
///<see cref="BufferSource"/> or <see cref="JsonWebKey"/>
///</summary>
public struct Union188
{
	public dynamic Value { get; set; }
	public static implicit operator Union188(BufferSource value){return new Union188 { Value = value };}
	public static implicit operator Union188(JsonWebKey value){return new Union188 { Value = value };}
}

///<summary>
///<see cref="ImageBitmap"/> or <see cref="ImageData"/> or <see cref="HTMLImageElement"/> or <see cref="HTMLCanvasElement"/> or <see cref="HTMLVideoElement"/> or <see cref="OffscreenCanvas"/> or <see cref="VideoFrame"/>
///</summary>
public struct Union189
{
	public dynamic Value { get; set; }
	public static implicit operator Union189(ImageBitmap value){return new Union189 { Value = value };}
	public static implicit operator Union189(ImageData value){return new Union189 { Value = value };}
	public static implicit operator Union189(HTMLImageElement value){return new Union189 { Value = value };}
	public static implicit operator Union189(HTMLCanvasElement value){return new Union189 { Value = value };}
	public static implicit operator Union189(HTMLVideoElement value){return new Union189 { Value = value };}
	public static implicit operator Union189(OffscreenCanvas value){return new Union189 { Value = value };}
	public static implicit operator Union189(VideoFrame value){return new Union189 { Value = value };}
}

///<summary>
///<see cref="System.Single"/> or <see cref="List{Number}"/>
///</summary>
public struct Union190
{
	public dynamic Value { get; set; }
	public static implicit operator Union190(System.Single value){return new Union190 { Value = value };}
	public static implicit operator Union190(List<Number> value){return new Union190 { Value = value };}
}

///<summary>
///<see cref="System.Int32"/> or <see cref="List{GLint}"/>
///</summary>
public struct Union191
{
	public dynamic Value { get; set; }
	public static implicit operator Union191(System.Int32 value){return new Union191 { Value = value };}
	public static implicit operator Union191(List<GLint> value){return new Union191 { Value = value };}
}

///<summary>
///<see cref="HTMLCanvasElement"/> or <see cref="OffscreenCanvas"/>
///</summary>
public struct Union192
{
	public dynamic Value { get; set; }
	public static implicit operator Union192(HTMLCanvasElement value){return new Union192 { Value = value };}
	public static implicit operator Union192(OffscreenCanvas value){return new Union192 { Value = value };}
}

///<summary>
///<see cref="System.UInt32"/> or <see cref="List{GLuint}"/>
///</summary>
public struct Union193
{
	public dynamic Value { get; set; }
	public static implicit operator Union193(System.UInt32 value){return new Union193 { Value = value };}
	public static implicit operator Union193(List<GLuint> value){return new Union193 { Value = value };}
}

///<summary>
///<see cref="System.Int32"/> or <see cref="List{GLint}"/>
///</summary>
public struct Union194
{
	public dynamic Value { get; set; }
	public static implicit operator Union194(System.Int32 value){return new Union194 { Value = value };}
	public static implicit operator Union194(List<GLint> value){return new Union194 { Value = value };}
}

///<summary>
///<see cref="System.Int32"/> or <see cref="List{GLsizei}"/>
///</summary>
public struct Union195
{
	public dynamic Value { get; set; }
	public static implicit operator Union195(System.Int32 value){return new Union195 { Value = value };}
	public static implicit operator Union195(List<GLsizei> value){return new Union195 { Value = value };}
}

///<summary>
///<see cref="System.Int32"/> or <see cref="List{GLsizei}"/>
///</summary>
public struct Union196
{
	public dynamic Value { get; set; }
	public static implicit operator Union196(System.Int32 value){return new Union196 { Value = value };}
	public static implicit operator Union196(List<GLsizei> value){return new Union196 { Value = value };}
}

///<summary>
///<see cref="System.Int32"/> or <see cref="List{GLsizei}"/>
///</summary>
public struct Union197
{
	public dynamic Value { get; set; }
	public static implicit operator Union197(System.Int32 value){return new Union197 { Value = value };}
	public static implicit operator Union197(List<GLsizei> value){return new Union197 { Value = value };}
}

///<summary>
///<see cref="System.Int32"/> or <see cref="List{GLint}"/>
///</summary>
public struct Union198
{
	public dynamic Value { get; set; }
	public static implicit operator Union198(System.Int32 value){return new Union198 { Value = value };}
	public static implicit operator Union198(List<GLint> value){return new Union198 { Value = value };}
}

///<summary>
///<see cref="System.Int32"/> or <see cref="List{GLsizei}"/>
///</summary>
public struct Union199
{
	public dynamic Value { get; set; }
	public static implicit operator Union199(System.Int32 value){return new Union199 { Value = value };}
	public static implicit operator Union199(List<GLsizei> value){return new Union199 { Value = value };}
}

///<summary>
///<see cref="System.Int32"/> or <see cref="List{GLsizei}"/>
///</summary>
public struct Union200
{
	public dynamic Value { get; set; }
	public static implicit operator Union200(System.Int32 value){return new Union200 { Value = value };}
	public static implicit operator Union200(List<GLsizei> value){return new Union200 { Value = value };}
}

///<summary>
///<see cref="System.Int32"/> or <see cref="List{GLsizei}"/>
///</summary>
public struct Union201
{
	public dynamic Value { get; set; }
	public static implicit operator Union201(System.Int32 value){return new Union201 { Value = value };}
	public static implicit operator Union201(List<GLsizei> value){return new Union201 { Value = value };}
}

///<summary>
///<see cref="System.Int32"/> or <see cref="List{GLsizei}"/>
///</summary>
public struct Union202
{
	public dynamic Value { get; set; }
	public static implicit operator Union202(System.Int32 value){return new Union202 { Value = value };}
	public static implicit operator Union202(List<GLsizei> value){return new Union202 { Value = value };}
}

///<summary>
///<see cref="System.Int32"/> or <see cref="List{GLsizei}"/>
///</summary>
public struct Union203
{
	public dynamic Value { get; set; }
	public static implicit operator Union203(System.Int32 value){return new Union203 { Value = value };}
	public static implicit operator Union203(List<GLsizei> value){return new Union203 { Value = value };}
}

///<summary>
///<see cref="System.Int32"/> or <see cref="List{GLint}"/>
///</summary>
public struct Union204
{
	public dynamic Value { get; set; }
	public static implicit operator Union204(System.Int32 value){return new Union204 { Value = value };}
	public static implicit operator Union204(List<GLint> value){return new Union204 { Value = value };}
}

///<summary>
///<see cref="System.Int32"/> or <see cref="List{GLsizei}"/>
///</summary>
public struct Union205
{
	public dynamic Value { get; set; }
	public static implicit operator Union205(System.Int32 value){return new Union205 { Value = value };}
	public static implicit operator Union205(List<GLsizei> value){return new Union205 { Value = value };}
}

///<summary>
///<see cref="System.Int32"/> or <see cref="List{GLsizei}"/>
///</summary>
public struct Union206
{
	public dynamic Value { get; set; }
	public static implicit operator Union206(System.Int32 value){return new Union206 { Value = value };}
	public static implicit operator Union206(List<GLsizei> value){return new Union206 { Value = value };}
}

///<summary>
///<see cref="System.UInt32"/> or <see cref="List{GLuint}"/>
///</summary>
public struct Union207
{
	public dynamic Value { get; set; }
	public static implicit operator Union207(System.UInt32 value){return new Union207 { Value = value };}
	public static implicit operator Union207(List<GLuint> value){return new Union207 { Value = value };}
}

///<summary>
///<see cref="System.Int32"/> or <see cref="List{GLsizei}"/>
///</summary>
public struct Union208
{
	public dynamic Value { get; set; }
	public static implicit operator Union208(System.Int32 value){return new Union208 { Value = value };}
	public static implicit operator Union208(List<GLsizei> value){return new Union208 { Value = value };}
}

///<summary>
///<see cref="System.Int32"/> or <see cref="List{GLsizei}"/>
///</summary>
public struct Union209
{
	public dynamic Value { get; set; }
	public static implicit operator Union209(System.Int32 value){return new Union209 { Value = value };}
	public static implicit operator Union209(List<GLsizei> value){return new Union209 { Value = value };}
}

///<summary>
///<see cref="System.Int32"/> or <see cref="List{GLsizei}"/>
///</summary>
public struct Union210
{
	public dynamic Value { get; set; }
	public static implicit operator Union210(System.Int32 value){return new Union210 { Value = value };}
	public static implicit operator Union210(List<GLsizei> value){return new Union210 { Value = value };}
}

///<summary>
///<see cref="System.Int32"/> or <see cref="List{GLint}"/>
///</summary>
public struct Union211
{
	public dynamic Value { get; set; }
	public static implicit operator Union211(System.Int32 value){return new Union211 { Value = value };}
	public static implicit operator Union211(List<GLint> value){return new Union211 { Value = value };}
}

///<summary>
///<see cref="System.UInt32"/> or <see cref="List{GLuint}"/>
///</summary>
public struct Union212
{
	public dynamic Value { get; set; }
	public static implicit operator Union212(System.UInt32 value){return new Union212 { Value = value };}
	public static implicit operator Union212(List<GLuint> value){return new Union212 { Value = value };}
}

///<summary>
///<see cref="HTMLVideoElement"/> or <see cref="VideoFrame"/>
///</summary>
public struct Union213
{
	public dynamic Value { get; set; }
	public static implicit operator Union213(HTMLVideoElement value){return new Union213 { Value = value };}
	public static implicit operator Union213(VideoFrame value){return new Union213 { Value = value };}
}

///<summary>
///<see cref="GPUSampler"/> or <see cref="GPUTextureView"/> or <see cref="GPUBufferBinding"/> or <see cref="GPUExternalTexture"/>
///</summary>
public struct Union214
{
	public dynamic Value { get; set; }
	public static implicit operator Union214(GPUSampler value){return new Union214 { Value = value };}
	public static implicit operator Union214(GPUTextureView value){return new Union214 { Value = value };}
	public static implicit operator Union214(GPUBufferBinding value){return new Union214 { Value = value };}
	public static implicit operator Union214(GPUExternalTexture value){return new Union214 { Value = value };}
}

///<summary>
///<see cref="GPUPipelineLayout"/> or <see cref="GPUAutoLayoutMode"/>
///</summary>
public struct Union215
{
	public dynamic Value { get; set; }
	public static implicit operator Union215(GPUPipelineLayout value){return new Union215 { Value = value };}
	public static implicit operator Union215(GPUAutoLayoutMode value){return new Union215 { Value = value };}
}

///<summary>
///<see cref="GPUPipelineLayout"/> or <see cref="GPUAutoLayoutMode"/>
///</summary>
public struct Union216
{
	public dynamic Value { get; set; }
	public static implicit operator Union216(GPUPipelineLayout value){return new Union216 { Value = value };}
	public static implicit operator Union216(GPUAutoLayoutMode value){return new Union216 { Value = value };}
}

///<summary>
///<see cref="ImageBitmap"/> or <see cref="ImageData"/> or <see cref="HTMLImageElement"/> or <see cref="HTMLVideoElement"/> or <see cref="VideoFrame"/> or <see cref="HTMLCanvasElement"/> or <see cref="OffscreenCanvas"/>
///</summary>
public struct Union217
{
	public dynamic Value { get; set; }
	public static implicit operator Union217(ImageBitmap value){return new Union217 { Value = value };}
	public static implicit operator Union217(ImageData value){return new Union217 { Value = value };}
	public static implicit operator Union217(HTMLImageElement value){return new Union217 { Value = value };}
	public static implicit operator Union217(HTMLVideoElement value){return new Union217 { Value = value };}
	public static implicit operator Union217(VideoFrame value){return new Union217 { Value = value };}
	public static implicit operator Union217(HTMLCanvasElement value){return new Union217 { Value = value };}
	public static implicit operator Union217(OffscreenCanvas value){return new Union217 { Value = value };}
}

///<summary>
///<see cref="HTMLCanvasElement"/> or <see cref="OffscreenCanvas"/>
///</summary>
public struct Union218
{
	public dynamic Value { get; set; }
	public static implicit operator Union218(HTMLCanvasElement value){return new Union218 { Value = value };}
	public static implicit operator Union218(OffscreenCanvas value){return new Union218 { Value = value };}
}

///<summary>
///<see cref="List{Number}"/> or <see cref="GPUColorDict"/>
///</summary>
public struct Union219
{
	public dynamic Value { get; set; }
	public static implicit operator Union219(List<Number> value){return new Union219 { Value = value };}
	public static implicit operator Union219(GPUColorDict value){return new Union219 { Value = value };}
}

///<summary>
///<see cref="List{GPUIntegerCoordinate}"/> or <see cref="GPUOrigin2DDict"/>
///</summary>
public struct Union220
{
	public dynamic Value { get; set; }
	public static implicit operator Union220(List<GPUIntegerCoordinate> value){return new Union220 { Value = value };}
	public static implicit operator Union220(GPUOrigin2DDict value){return new Union220 { Value = value };}
}

///<summary>
///<see cref="List{GPUIntegerCoordinate}"/> or <see cref="GPUOrigin3DDict"/>
///</summary>
public struct Union221
{
	public dynamic Value { get; set; }
	public static implicit operator Union221(List<GPUIntegerCoordinate> value){return new Union221 { Value = value };}
	public static implicit operator Union221(GPUOrigin3DDict value){return new Union221 { Value = value };}
}

///<summary>
///<see cref="List{GPUIntegerCoordinate}"/> or <see cref="GPUExtent3DDict"/>
///</summary>
public struct Union222
{
	public dynamic Value { get; set; }
	public static implicit operator Union222(List<GPUIntegerCoordinate> value){return new Union222 { Value = value };}
	public static implicit operator Union222(GPUExtent3DDict value){return new Union222 { Value = value };}
}

///<summary>
///<see cref="System.SByte"/> or <see cref="System.Int16"/> or <see cref="System.Int32"/> or <see cref="System.Byte"/> or <see cref="System.UInt16"/> or <see cref="System.UInt32"/> or <see cref="Unsupported /*Uint8ClampedArray*/"/> or <see cref="System.Int64"/> or <see cref="System.UInt64"/> or <see cref="Unsupported /*Float16Array*/"/> or <see cref="System.Single"/> or <see cref="System.Double"/> or <see cref="Unsupported /*DataView*/"/>
///</summary>
public struct Union223
{
	public dynamic Value { get; set; }
	public static implicit operator Union223(System.SByte value){return new Union223 { Value = value };}
	public static implicit operator Union223(System.Int16 value){return new Union223 { Value = value };}
	public static implicit operator Union223(System.Int32 value){return new Union223 { Value = value };}
	public static implicit operator Union223(System.Byte value){return new Union223 { Value = value };}
	public static implicit operator Union223(System.UInt16 value){return new Union223 { Value = value };}
	public static implicit operator Union223(System.UInt32 value){return new Union223 { Value = value };}
	public static implicit operator Union223(Unsupported /*Uint8ClampedArray*/ value){return new Union223 { Value = value };}
	public static implicit operator Union223(System.Int64 value){return new Union223 { Value = value };}
	public static implicit operator Union223(System.UInt64 value){return new Union223 { Value = value };}
	public static implicit operator Union223(System.Single value){return new Union223 { Value = value };}
	public static implicit operator Union223(System.Double value){return new Union223 { Value = value };}
}

///<summary>
///<see cref="ArrayBufferView"/> or <see cref="byte"/>
///</summary>
public struct Union224
{
	public dynamic Value { get; set; }
	public static implicit operator Union224(ArrayBufferView value){return new Union224 { Value = value };}
	public static implicit operator Union224(byte[] value){return new Union224 { Value = value };}
}

///<summary>
///<see cref="byte"/> or <see cref="Unsupported /*SharedArrayBuffer*/"/> or <see cref="ArrayBufferView"/>
///</summary>
public struct Union225
{
	public dynamic Value { get; set; }
	public static implicit operator Union225(byte[] value){return new Union225 { Value = value };}
	public static implicit operator Union225(Unsupported /*SharedArrayBuffer*/ value){return new Union225 { Value = value };}
	public static implicit operator Union225(ArrayBufferView value){return new Union225 { Value = value };}
}

///<summary>
///<see cref="BigInt"/> or <see cref="double"/>
///</summary>
public struct Union226
{
	public dynamic Value { get; set; }
	public static implicit operator Union226(BigInt value){return new Union226 { Value = value };}
	public static implicit operator Union226(double value){return new Union226 { Value = value };}
}

///<summary>
///<see cref="ulong"/> or <see cref="List{ulong}"/>
///</summary>
public struct Union227
{
	public dynamic Value { get; set; }
	public static implicit operator Union227(ulong value){return new Union227 { Value = value };}
	public static implicit operator Union227(List<ulong> value){return new Union227 { Value = value };}
}

///<summary>
///<see cref="SFrameTransform"/> or <see cref="RTCRtpScriptTransform"/>
///</summary>
public struct Union228
{
	public dynamic Value { get; set; }
	public static implicit operator Union228(SFrameTransform value){return new Union228 { Value = value };}
	public static implicit operator Union228(RTCRtpScriptTransform value){return new Union228 { Value = value };}
}

///<summary>
///<see cref="SmallCryptoKeyID"/> or <see cref="BigInt"/>
///</summary>
public struct Union229
{
	public dynamic Value { get; set; }
	public static implicit operator Union229(SmallCryptoKeyID value){return new Union229 { Value = value };}
	public static implicit operator Union229(BigInt value){return new Union229 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="List{DOMString}"/>
///</summary>
public struct Union230
{
	public dynamic Value { get; set; }
	public static implicit operator Union230(DOMString value){return new Union230 { Value = value };}
	public static implicit operator Union230(List<DOMString> value){return new Union230 { Value = value };}
}

///<summary>
///<see cref="MediaStreamTrack"/> or <see cref="DOMString"/>
///</summary>
public struct Union231
{
	public dynamic Value { get; set; }
	public static implicit operator Union231(MediaStreamTrack value){return new Union231 { Value = value };}
	public static implicit operator Union231(DOMString value){return new Union231 { Value = value };}
}

///<summary>
///<see cref="DOMString"/> or <see cref="List{DOMString}"/>
///</summary>
public struct Union232
{
	public dynamic Value { get; set; }
	public static implicit operator Union232(DOMString value){return new Union232 { Value = value };}
	public static implicit operator Union232(List<DOMString> value){return new Union232 { Value = value };}
}

///<summary>
///<see cref="BufferSource"/> or <see cref="Blob"/> or <see cref="USVString"/>
///</summary>
public struct Union233
{
	public dynamic Value { get; set; }
	public static implicit operator Union233(BufferSource value){return new Union233 { Value = value };}
	public static implicit operator Union233(Blob value){return new Union233 { Value = value };}
	public static implicit operator Union233(USVString value){return new Union233 { Value = value };}
}

///<summary>
///<see cref="Number"/> or <see cref="AutoKeyword"/>
///</summary>
public struct Union234
{
	public dynamic Value { get; set; }
	public static implicit operator Union234(Number value){return new Union234 { Value = value };}
	public static implicit operator Union234(AutoKeyword value){return new Union234 { Value = value };}
}

///<summary>
///<see cref="WebGLRenderingContext"/> or <see cref="WebGL2RenderingContext"/>
///</summary>
public struct Union235
{
	public dynamic Value { get; set; }
	public static implicit operator Union235(WebGLRenderingContext value){return new Union235 { Value = value };}
	public static implicit operator Union235(WebGL2RenderingContext value){return new Union235 { Value = value };}
}

///<summary>
///<see cref="Document"/> or <see cref="XMLHttpRequestBodyInit"/>
///</summary>
public struct Union236
{
	public dynamic Value { get; set; }
	public static implicit operator Union236(Document value){return new Union236 { Value = value };}
	public static implicit operator Union236(XMLHttpRequestBodyInit value){return new Union236 { Value = value };}
}

///<summary>
///<see cref="File"/> or <see cref="USVString"/>
///</summary>
public struct Union237
{
	public dynamic Value { get; set; }
	public static implicit operator Union237(File value){return new Union237 { Value = value };}
	public static implicit operator Union237(USVString value){return new Union237 { Value = value };}
}

