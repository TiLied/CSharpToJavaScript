//07.05.2023 21:25:48
using CSharpToJavaScript.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpToJavaScript.APIs.JS;

using HeadersInit = Union9;
using XMLHttpRequestBodyInit = Union10;
using BodyInit = Union11;
using RequestInfo = Union12;
using HTMLOrSVGScriptElement = Union18;
using MediaProvider = Union20;
using RenderingContext = Union27;
using HTMLOrSVGImageElement = Union28;
using CanvasImageSource = Union29;
using CanvasFilterInput = Dictionary<string, dynamic>;
using OffscreenRenderingContext = Union38;
using EventHandler = EventHandlerNonNull;
using OnErrorEventHandler = OnErrorEventHandlerNonNull;
using OnBeforeUnloadEventHandler = OnBeforeUnloadEventHandlerNonNull;
using TimerHandler = Union43;
using ImageBitmapSource = Union44;
using MessageEventSource = Union45;
using ArrayBufferView = Union48;
using BufferSource = Union49;
using FormDataEntryValue = Union51;

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Window/*'/>
public partial class Window
{
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOrientation/*'/>
	public short Orientation { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOnorientationchange/*'/>
	public EventHandler Onorientationchange { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLBodyElement/*'/>
public partial class HTMLBodyElement
{
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLBodyElementOnorientationchange/*'/>
	public EventHandler Onorientationchange { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/console/*'/>
public partial class console
{
	///<include file='Utils/Docs.generated.xml' path='docs/consoleAssert/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Assert(bool condition, params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/consoleClear/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Clear() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/consoleDebug/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Debug(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/consoleError/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Error(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/consoleInfo/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Info(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/consoleLog/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Log(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/consoleTable/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Table(dynamic tabularData, List<string> properties) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/consoleTrace/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Trace(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/consoleWarn/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Warn(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/consoleDir/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Dir(dynamic item, object? options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/consoleDirxml/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Dirxml(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/consoleCount/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Count(string label) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/consoleCountReset/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ CountReset(string label) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/consoleGroup/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Group(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/consoleGroupCollapsed/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ GroupCollapsed(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/consoleGroupEnd/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ GroupEnd() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/consoleTime/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Time(string label) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/consoleTimeLog/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ TimeLog(string label, params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/consoleTimeEnd/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ TimeEnd(string label) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Event/*'/>
public partial class Event
{
	///<include file='Utils/Docs.generated.xml' path='docs/Event/*'/>
	public Event(string type, EventInit eventInitDict) { }
	///<include file='Utils/Docs.generated.xml' path='docs/EventType/*'/>
	public string Type { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventTarget/*'/>
	public EventTarget? Target { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventSrcElement/*'/>
	public EventTarget? SrcElement { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventCurrentTarget/*'/>
	public EventTarget? CurrentTarget { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventComposedPath/*'/>
	public List<EventTarget> ComposedPath() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/EventNONE/*'/>
	public const ushort NONE = 0;
	///<include file='Utils/Docs.generated.xml' path='docs/EventCAPTURING_PHASE/*'/>
	public const ushort CAPTURING_PHASE = 1;
	///<include file='Utils/Docs.generated.xml' path='docs/EventAT_TARGET/*'/>
	public const ushort AT_TARGET = 2;
	///<include file='Utils/Docs.generated.xml' path='docs/EventBUBBLING_PHASE/*'/>
	public const ushort BUBBLING_PHASE = 3;
	///<include file='Utils/Docs.generated.xml' path='docs/EventEventPhase/*'/>
	public ushort EventPhase { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventStopPropagation/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ StopPropagation() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/EventCancelBubble/*'/>
	public bool CancelBubble { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventStopImmediatePropagation/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ StopImmediatePropagation() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/EventBubbles/*'/>
	public bool Bubbles { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventCancelable/*'/>
	public bool Cancelable { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventReturnValue/*'/>
	public bool ReturnValue { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventPreventDefault/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ PreventDefault() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/EventDefaultPrevented/*'/>
	public bool DefaultPrevented { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventComposed/*'/>
	public bool Composed { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventIsTrusted/*'/>
	public bool IsTrusted { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventTimeStamp/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*DOMHighResTimeStamp*/ TimeStamp { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventInitEvent/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ InitEvent(string type, bool bubbles, bool cancelable) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/EventInit/*'/>
public partial class EventInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/EventInitBubbles/*'/>
	public bool Bubbles;
	///<include file='Utils/Docs.generated.xml' path='docs/EventInitCancelable/*'/>
	public bool Cancelable;
	///<include file='Utils/Docs.generated.xml' path='docs/EventInitComposed/*'/>
	public bool Composed;
}

///<include file='Utils/Docs.generated.xml' path='docs/Window/*'/>
public partial class Window
{
	///<include file='Utils/Docs.generated.xml' path='docs/WindowEvent/*'/>
	public Union0 Event { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CustomEvent/*'/>
public partial class CustomEvent : Event
{
	///<include file='Utils/Docs.generated.xml' path='docs/CustomEvent/*'/>
	public CustomEvent(string type, CustomEventInit eventInitDict) { }
	///<include file='Utils/Docs.generated.xml' path='docs/CustomEventDetail/*'/>
	public dynamic Detail { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/CustomEventInitCustomEvent/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ InitCustomEvent(string type, bool bubbles, bool cancelable, dynamic detail) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CustomEventInit/*'/>
public partial class CustomEventInit : EventInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/CustomEventInitDetail/*'/>
	public dynamic Detail;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/EventTarget/*'/>
public partial class EventTarget
{
	///<include file='Utils/Docs.generated.xml' path='docs/EventTarget/*'/>
	public EventTarget() { }
	///<include file='Utils/Docs.generated.xml' path='docs/EventTargetAddEventListener/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ AddEventListener(string type, EventListener? callback, Union1 options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/EventTargetRemoveEventListener/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ RemoveEventListener(string type, EventListener? callback, Union2 options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/EventTargetDispatchEvent/*'/>
	public bool DispatchEvent(Event event_) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/EventListener/*'/>
public partial interface EventListener
{
	///<include file='Utils/Docs.generated.xml' path='docs/EventListenerHandleEvent/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ HandleEvent(Event event_) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/EventListenerOptions/*'/>
public partial class EventListenerOptions
{
	///<include file='Utils/Docs.generated.xml' path='docs/EventListenerOptionsCapture/*'/>
	public bool Capture;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/AddEventListenerOptions/*'/>
public partial class AddEventListenerOptions : EventListenerOptions
{
	///<include file='Utils/Docs.generated.xml' path='docs/AddEventListenerOptionsPassive/*'/>
	public bool Passive;
	///<include file='Utils/Docs.generated.xml' path='docs/AddEventListenerOptionsOnce/*'/>
	public bool Once;
	///<include file='Utils/Docs.generated.xml' path='docs/AddEventListenerOptionsSignal/*'/>
	public AbortSignal Signal;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/AbortController/*'/>
public partial class AbortController
{
	///<include file='Utils/Docs.generated.xml' path='docs/AbortController/*'/>
	public AbortController() { }
	///<include file='Utils/Docs.generated.xml' path='docs/AbortControllerSignal/*'/>
	public AbortSignal Signal { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/AbortControllerAbort/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Abort(dynamic reason) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/AbortSignal/*'/>
public partial class AbortSignal : EventTarget
{
	///<include file='Utils/Docs.generated.xml' path='docs/AbortSignalAbort/*'/>
	public static AbortSignal Abort(dynamic reason) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/AbortSignalTimeout/*'/>
	public static AbortSignal Timeout(ulong milliseconds) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/AbortSignalAborted/*'/>
	public bool Aborted { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/AbortSignalReason/*'/>
	public dynamic Reason { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/AbortSignalThrowIfAborted/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ThrowIfAborted() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/AbortSignalOnabort/*'/>
	public EventHandler Onabort { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NonElementParentNode/*'/>
public partial interface NonElementParentNode
{
	///<include file='Utils/Docs.generated.xml' path='docs/NonElementParentNodeGetElementById/*'/>
	public Element? GetElementById(string elementId) { throw new System.NotImplementedException(); }
}



[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/DocumentOrShadowRoot/*'/>
public partial interface DocumentOrShadowRoot
{
}



[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ParentNode/*'/>
public partial interface ParentNode
{
	///<include file='Utils/Docs.generated.xml' path='docs/ParentNodeChildren/*'/>
	public HTMLCollection Children { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/ParentNodeFirstElementChild/*'/>
	public Element? FirstElementChild { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/ParentNodeLastElementChild/*'/>
	public Element? LastElementChild { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/ParentNodeChildElementCount/*'/>
	public ulong ChildElementCount { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/ParentNodePrepend/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Prepend(params Union3[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ParentNodeAppend/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Append(params Union4[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ParentNodeReplaceChildren/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ReplaceChildren(params Union5[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ParentNodeQuerySelector/*'/>
	public Element? QuerySelector(string selectors) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ParentNodeQuerySelectorAll/*'/>
	public NodeList QuerySelectorAll(string selectors) { throw new System.NotImplementedException(); }
}




[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NonDocumentTypeChildNode/*'/>
public partial interface NonDocumentTypeChildNode
{
	///<include file='Utils/Docs.generated.xml' path='docs/NonDocumentTypeChildNodePreviousElementSibling/*'/>
	public Element? PreviousElementSibling { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/NonDocumentTypeChildNodeNextElementSibling/*'/>
	public Element? NextElementSibling { get { throw new System.NotImplementedException(); } }
}



[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ChildNode/*'/>
public partial interface ChildNode
{
	///<include file='Utils/Docs.generated.xml' path='docs/ChildNodeBefore/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Before(params Union6[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ChildNodeAfter/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ After(params Union7[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ChildNodeReplaceWith/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ReplaceWith(params Union8[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ChildNodeRemove/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Remove() { throw new System.NotImplementedException(); }
}




[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Slottable/*'/>
public partial interface Slottable
{
	///<include file='Utils/Docs.generated.xml' path='docs/SlottableAssignedSlot/*'/>
	public HTMLSlotElement? AssignedSlot { get { throw new System.NotImplementedException(); } }
}



[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NodeList/*'/>
public partial class NodeList
{
	
	///<include file='Utils/Docs.generated.xml' path='docs/NodeListLength/*'/>
	public ulong Length { get; }
	
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLCollection/*'/>
public partial class HTMLCollection
{
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLCollectionLength/*'/>
	public ulong Length { get; }
	
	
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/MutationObserver/*'/>
public partial class MutationObserver
{
	///<include file='Utils/Docs.generated.xml' path='docs/MutationObserver/*'/>
	public MutationObserver(MutationCallback callback) { }
	///<include file='Utils/Docs.generated.xml' path='docs/MutationObserverObserve/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Observe(Node target, MutationObserverInit options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/MutationObserverDisconnect/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Disconnect() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/MutationObserverTakeRecords/*'/>
	public List<MutationRecord> TakeRecords() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/MutationCallback/*'/>
public struct MutationCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/MutationObserverInit/*'/>
public partial class MutationObserverInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/MutationObserverInitChildList/*'/>
	public bool ChildList;
	///<include file='Utils/Docs.generated.xml' path='docs/MutationObserverInitAttributes/*'/>
	public bool Attributes;
	///<include file='Utils/Docs.generated.xml' path='docs/MutationObserverInitCharacterData/*'/>
	public bool CharacterData;
	///<include file='Utils/Docs.generated.xml' path='docs/MutationObserverInitSubtree/*'/>
	public bool Subtree;
	///<include file='Utils/Docs.generated.xml' path='docs/MutationObserverInitAttributeOldValue/*'/>
	public bool AttributeOldValue;
	///<include file='Utils/Docs.generated.xml' path='docs/MutationObserverInitCharacterDataOldValue/*'/>
	public bool CharacterDataOldValue;
	///<include file='Utils/Docs.generated.xml' path='docs/MutationObserverInitAttributeFilter/*'/>
	public List<string> AttributeFilter;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/MutationRecord/*'/>
public partial class MutationRecord
{
	///<include file='Utils/Docs.generated.xml' path='docs/MutationRecordType/*'/>
	public string Type { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/MutationRecordTarget/*'/>
	public Node Target { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/MutationRecordAddedNodes/*'/>
	public NodeList AddedNodes { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/MutationRecordRemovedNodes/*'/>
	public NodeList RemovedNodes { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/MutationRecordPreviousSibling/*'/>
	public Node? PreviousSibling { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/MutationRecordNextSibling/*'/>
	public Node? NextSibling { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/MutationRecordAttributeName/*'/>
	public string? AttributeName { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/MutationRecordAttributeNamespace/*'/>
	public string? AttributeNamespace { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/MutationRecordOldValue/*'/>
	public string? OldValue { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Node/*'/>
public partial class Node : EventTarget
{
	///<include file='Utils/Docs.generated.xml' path='docs/NodeELEMENT_NODE/*'/>
	public const ushort ELEMENT_NODE = 1;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeATTRIBUTE_NODE/*'/>
	public const ushort ATTRIBUTE_NODE = 2;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeTEXT_NODE/*'/>
	public const ushort TEXT_NODE = 3;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeCDATA_SECTION_NODE/*'/>
	public const ushort CDATA_SECTION_NODE = 4;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeENTITY_REFERENCE_NODE/*'/>
	public const ushort ENTITY_REFERENCE_NODE = 5;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeENTITY_NODE/*'/>
	public const ushort ENTITY_NODE = 6;
	///<include file='Utils/Docs.generated.xml' path='docs/NodePROCESSING_INSTRUCTION_NODE/*'/>
	public const ushort PROCESSING_INSTRUCTION_NODE = 7;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeCOMMENT_NODE/*'/>
	public const ushort COMMENT_NODE = 8;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeDOCUMENT_NODE/*'/>
	public const ushort DOCUMENT_NODE = 9;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeDOCUMENT_TYPE_NODE/*'/>
	public const ushort DOCUMENT_TYPE_NODE = 10;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeDOCUMENT_FRAGMENT_NODE/*'/>
	public const ushort DOCUMENT_FRAGMENT_NODE = 11;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeNOTATION_NODE/*'/>
	public const ushort NOTATION_NODE = 12;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeNodeType/*'/>
	public ushort NodeType { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeNodeName/*'/>
	public string NodeName { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeBaseURI/*'/>
	public string BaseURI { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeIsConnected/*'/>
	public bool IsConnected { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeOwnerDocument/*'/>
	public Document? OwnerDocument { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeGetRootNode/*'/>
	public Node GetRootNode(GetRootNodeOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeParentNode/*'/>
	public Node? ParentNode { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeParentElement/*'/>
	public Element? ParentElement { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeHasChildNodes/*'/>
	public bool HasChildNodes() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeChildNodes/*'/>
	public NodeList ChildNodes { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeFirstChild/*'/>
	public Node? FirstChild { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeLastChild/*'/>
	public Node? LastChild { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodePreviousSibling/*'/>
	public Node? PreviousSibling { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeNextSibling/*'/>
	public Node? NextSibling { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeNodeValue/*'/>
	public string? NodeValue { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeTextContent/*'/>
	public string? TextContent { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeNormalize/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Normalize() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeCloneNode/*'/>
	public Node CloneNode(bool deep) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeIsEqualNode/*'/>
	public bool IsEqualNode(Node? otherNode) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeIsSameNode/*'/>
	public bool IsSameNode(Node? otherNode) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeDOCUMENT_POSITION_DISCONNECTED/*'/>
	public const ushort DOCUMENT_POSITION_DISCONNECTED = 0x01;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeDOCUMENT_POSITION_PRECEDING/*'/>
	public const ushort DOCUMENT_POSITION_PRECEDING = 0x02;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeDOCUMENT_POSITION_FOLLOWING/*'/>
	public const ushort DOCUMENT_POSITION_FOLLOWING = 0x04;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeDOCUMENT_POSITION_CONTAINS/*'/>
	public const ushort DOCUMENT_POSITION_CONTAINS = 0x08;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeDOCUMENT_POSITION_CONTAINED_BY/*'/>
	public const ushort DOCUMENT_POSITION_CONTAINED_BY = 0x10;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeDOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC/*'/>
	public const ushort DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC = 0x20;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeCompareDocumentPosition/*'/>
	public ushort CompareDocumentPosition(Node other) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeContains/*'/>
	public bool Contains(Node? other) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeLookupPrefix/*'/>
	public string? LookupPrefix(string? namespace_) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeLookupNamespaceURI/*'/>
	public string? LookupNamespaceURI(string? prefix) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeIsDefaultNamespace/*'/>
	public bool IsDefaultNamespace(string? namespace_) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeInsertBefore/*'/>
	public Node InsertBefore(Node node, Node? child) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeAppendChild/*'/>
	public Node AppendChild(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeReplaceChild/*'/>
	public Node ReplaceChild(Node node, Node child) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeRemoveChild/*'/>
	public Node RemoveChild(Node child) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/GetRootNodeOptions/*'/>
public partial class GetRootNodeOptions
{
	///<include file='Utils/Docs.generated.xml' path='docs/GetRootNodeOptionsComposed/*'/>
	public bool Composed;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/DOMImplementation/*'/>
public partial class DOMImplementation
{
	///<include file='Utils/Docs.generated.xml' path='docs/DOMImplementationCreateDocumentType/*'/>
	public DocumentType CreateDocumentType(string qualifiedName, string publicId, string systemId) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DOMImplementationCreateDocument/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*XMLDocument*/ CreateDocument(string? namespace_, string qualifiedName, DocumentType? doctype) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DOMImplementationCreateHTMLDocument/*'/>
	public Document CreateHTMLDocument(string title) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DOMImplementationHasFeature/*'/>
	public bool HasFeature() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/DocumentType/*'/>
public partial class DocumentType : Node, ChildNode
{
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentTypeName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentTypePublicId/*'/>
	public string PublicId { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentTypeSystemId/*'/>
	public string SystemId { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/DocumentFragment/*'/>
public partial class DocumentFragment : Node, NonElementParentNode, ParentNode
{
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentFragment/*'/>
	public DocumentFragment() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ShadowRoot/*'/>
public partial class ShadowRoot : DocumentFragment, DocumentOrShadowRoot
{
	///<include file='Utils/Docs.generated.xml' path='docs/ShadowRootMode/*'/>
	public ShadowRootMode Mode { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ShadowRootDelegatesFocus/*'/>
	public bool DelegatesFocus { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ShadowRootSlotAssignment/*'/>
	public SlotAssignmentMode SlotAssignment { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ShadowRootHost/*'/>
	public Element Host { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ShadowRootOnslotchange/*'/>
	public EventHandler Onslotchange { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/ShadowRootMode/*'/>
public enum ShadowRootMode
{
	Open,
	Closed,
}

///<include file='Utils/Docs.generated.xml' path='docs/SlotAssignmentMode/*'/>
public enum SlotAssignmentMode
{
	Manual,
	Named,
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Element/*'/>
public partial class Element : Node, ParentNode, NonDocumentTypeChildNode, ChildNode, Slottable
{
	///<include file='Utils/Docs.generated.xml' path='docs/ElementNamespaceURI/*'/>
	public string? NamespaceURI { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementPrefix/*'/>
	public string? Prefix { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementLocalName/*'/>
	public string LocalName { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementTagName/*'/>
	public string TagName { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementId/*'/>
	public string Id { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementClassName/*'/>
	public string ClassName { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementClassList/*'/>
	public DOMTokenList ClassList { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementSlot/*'/>
	public string Slot { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementHasAttributes/*'/>
	public bool HasAttributes() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementAttributes/*'/>
	public NamedNodeMap Attributes { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementGetAttributeNames/*'/>
	public List<string> GetAttributeNames() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementGetAttribute/*'/>
	public string? GetAttribute(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementGetAttributeNS/*'/>
	public string? GetAttributeNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementSetAttribute/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetAttribute(string qualifiedName, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementSetAttributeNS/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetAttributeNS(string? namespace_, string qualifiedName, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementRemoveAttribute/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ RemoveAttribute(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementRemoveAttributeNS/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ RemoveAttributeNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementToggleAttribute/*'/>
	public bool ToggleAttribute(string qualifiedName, bool force) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementHasAttribute/*'/>
	public bool HasAttribute(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementHasAttributeNS/*'/>
	public bool HasAttributeNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementGetAttributeNode/*'/>
	public Attr? GetAttributeNode(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementGetAttributeNodeNS/*'/>
	public Attr? GetAttributeNodeNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementSetAttributeNode/*'/>
	public Attr? SetAttributeNode(Attr attr) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementSetAttributeNodeNS/*'/>
	public Attr? SetAttributeNodeNS(Attr attr) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementRemoveAttributeNode/*'/>
	public Attr RemoveAttributeNode(Attr attr) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementAttachShadow/*'/>
	public ShadowRoot AttachShadow(ShadowRootInit init) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementShadowRoot/*'/>
	public ShadowRoot? ShadowRoot { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementClosest/*'/>
	public Element? Closest(string selectors) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementMatches/*'/>
	public bool Matches(string selectors) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementWebkitMatchesSelector/*'/>
	public bool WebkitMatchesSelector(string selectors) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementGetElementsByTagName/*'/>
	public HTMLCollection GetElementsByTagName(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementGetElementsByTagNameNS/*'/>
	public HTMLCollection GetElementsByTagNameNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementGetElementsByClassName/*'/>
	public HTMLCollection GetElementsByClassName(string classNames) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementInsertAdjacentElement/*'/>
	public Element? InsertAdjacentElement(string where, Element element) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementInsertAdjacentText/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ InsertAdjacentText(string where, string data) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ShadowRootInit/*'/>
public partial class ShadowRootInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/ShadowRootInitMode/*'/>
	public required ShadowRootMode Mode;
	///<include file='Utils/Docs.generated.xml' path='docs/ShadowRootInitDelegatesFocus/*'/>
	public bool DelegatesFocus;
	///<include file='Utils/Docs.generated.xml' path='docs/ShadowRootInitSlotAssignment/*'/>
	public SlotAssignmentMode SlotAssignment;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NamedNodeMap/*'/>
public partial class NamedNodeMap
{
	///<include file='Utils/Docs.generated.xml' path='docs/NamedNodeMapLength/*'/>
	public ulong Length { get; }
	
	
	///<include file='Utils/Docs.generated.xml' path='docs/NamedNodeMapGetNamedItemNS/*'/>
	public Attr? GetNamedItemNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NamedNodeMapSetNamedItem/*'/>
	public Attr? SetNamedItem(Attr attr) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NamedNodeMapSetNamedItemNS/*'/>
	public Attr? SetNamedItemNS(Attr attr) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NamedNodeMapRemoveNamedItem/*'/>
	public Attr RemoveNamedItem(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NamedNodeMapRemoveNamedItemNS/*'/>
	public Attr RemoveNamedItemNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Attr/*'/>
public partial class Attr : Node
{
	///<include file='Utils/Docs.generated.xml' path='docs/AttrNamespaceURI/*'/>
	public string? NamespaceURI { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/AttrPrefix/*'/>
	public string? Prefix { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/AttrLocalName/*'/>
	public string LocalName { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/AttrName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/AttrValue/*'/>
	public string Value { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/AttrOwnerElement/*'/>
	public Element? OwnerElement { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/AttrSpecified/*'/>
	public bool Specified { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CharacterData/*'/>
public partial class CharacterData : Node, NonDocumentTypeChildNode, ChildNode
{
	///<include file='Utils/Docs.generated.xml' path='docs/CharacterDataData/*'/>
	public string Data { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/CharacterDataLength/*'/>
	public ulong Length { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/CharacterDataSubstringData/*'/>
	public string SubstringData(ulong offset, ulong count) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CharacterDataAppendData/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ AppendData(string data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CharacterDataInsertData/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ InsertData(ulong offset, string data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CharacterDataDeleteData/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ DeleteData(ulong offset, ulong count) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CharacterDataReplaceData/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ReplaceData(ulong offset, ulong count, string data) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/Text/*'/>
public partial class Text : CharacterData, Slottable
{
	///<include file='Utils/Docs.generated.xml' path='docs/Text/*'/>
	public Text(string data) { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextSplitText/*'/>
	public Text SplitText(ulong offset) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextWholeText/*'/>
	public string WholeText { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CDATASection/*'/>
public partial class CDATASection : Text
{
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ProcessingInstruction/*'/>
public partial class ProcessingInstruction : CharacterData
{
	///<include file='Utils/Docs.generated.xml' path='docs/ProcessingInstructionTarget/*'/>
	public string Target { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Comment/*'/>
public partial class Comment : CharacterData
{
	///<include file='Utils/Docs.generated.xml' path='docs/Comment/*'/>
	public Comment(string data) { }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/AbstractRange/*'/>
public partial class AbstractRange
{
	///<include file='Utils/Docs.generated.xml' path='docs/AbstractRangeStartContainer/*'/>
	public Node StartContainer { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/AbstractRangeStartOffset/*'/>
	public ulong StartOffset { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/AbstractRangeEndContainer/*'/>
	public Node EndContainer { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/AbstractRangeEndOffset/*'/>
	public ulong EndOffset { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/AbstractRangeCollapsed/*'/>
	public bool Collapsed { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/StaticRangeInit/*'/>
public partial class StaticRangeInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/StaticRangeInitStartContainer/*'/>
	public required Node StartContainer;
	///<include file='Utils/Docs.generated.xml' path='docs/StaticRangeInitStartOffset/*'/>
	public required ulong StartOffset;
	///<include file='Utils/Docs.generated.xml' path='docs/StaticRangeInitEndContainer/*'/>
	public required Node EndContainer;
	///<include file='Utils/Docs.generated.xml' path='docs/StaticRangeInitEndOffset/*'/>
	public required ulong EndOffset;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/StaticRange/*'/>
public partial class StaticRange : AbstractRange
{
	///<include file='Utils/Docs.generated.xml' path='docs/StaticRange/*'/>
	public StaticRange(StaticRangeInit init) { }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Range/*'/>
public partial class Range : AbstractRange
{
	///<include file='Utils/Docs.generated.xml' path='docs/Range/*'/>
	public Range() { }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeCommonAncestorContainer/*'/>
	public Node CommonAncestorContainer { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeSetStart/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetStart(Node node, ulong offset) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeSetEnd/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetEnd(Node node, ulong offset) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeSetStartBefore/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetStartBefore(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeSetStartAfter/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetStartAfter(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeSetEndBefore/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetEndBefore(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeSetEndAfter/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetEndAfter(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeCollapse/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Collapse(bool toStart) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeSelectNode/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SelectNode(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeSelectNodeContents/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SelectNodeContents(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeSTART_TO_START/*'/>
	public const ushort START_TO_START = 0;
	///<include file='Utils/Docs.generated.xml' path='docs/RangeSTART_TO_END/*'/>
	public const ushort START_TO_END = 1;
	///<include file='Utils/Docs.generated.xml' path='docs/RangeEND_TO_END/*'/>
	public const ushort END_TO_END = 2;
	///<include file='Utils/Docs.generated.xml' path='docs/RangeEND_TO_START/*'/>
	public const ushort END_TO_START = 3;
	///<include file='Utils/Docs.generated.xml' path='docs/RangeCompareBoundaryPoints/*'/>
	public short CompareBoundaryPoints(ushort how, Range sourceRange) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeDeleteContents/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ DeleteContents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeExtractContents/*'/>
	public DocumentFragment ExtractContents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeCloneContents/*'/>
	public DocumentFragment CloneContents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeInsertNode/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ InsertNode(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeSurroundContents/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SurroundContents(Node newParent) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeCloneRange/*'/>
	public Range CloneRange() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeDetach/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Detach() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeIsPointInRange/*'/>
	public bool IsPointInRange(Node node, ulong offset) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeComparePoint/*'/>
	public short ComparePoint(Node node, ulong offset) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/RangeIntersectsNode/*'/>
	public bool IntersectsNode(Node node) { throw new System.NotImplementedException(); }
	
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NodeIterator/*'/>
public partial class NodeIterator
{
	///<include file='Utils/Docs.generated.xml' path='docs/NodeIteratorRoot/*'/>
	public Node Root { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeIteratorReferenceNode/*'/>
	public Node ReferenceNode { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeIteratorPointerBeforeReferenceNode/*'/>
	public bool PointerBeforeReferenceNode { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeIteratorWhatToShow/*'/>
	public ulong WhatToShow { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeIteratorFilter/*'/>
	public NodeFilter? Filter { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeIteratorNextNode/*'/>
	public Node? NextNode() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeIteratorPreviousNode/*'/>
	public Node? PreviousNode() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NodeIteratorDetach/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Detach() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TreeWalker/*'/>
public partial class TreeWalker
{
	///<include file='Utils/Docs.generated.xml' path='docs/TreeWalkerRoot/*'/>
	public Node Root { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/TreeWalkerWhatToShow/*'/>
	public ulong WhatToShow { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/TreeWalkerFilter/*'/>
	public NodeFilter? Filter { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/TreeWalkerCurrentNode/*'/>
	public Node CurrentNode { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/TreeWalkerParentNode/*'/>
	public Node? ParentNode() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/TreeWalkerFirstChild/*'/>
	public Node? FirstChild() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/TreeWalkerLastChild/*'/>
	public Node? LastChild() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/TreeWalkerPreviousSibling/*'/>
	public Node? PreviousSibling() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/TreeWalkerNextSibling/*'/>
	public Node? NextSibling() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/TreeWalkerPreviousNode/*'/>
	public Node? PreviousNode() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/TreeWalkerNextNode/*'/>
	public Node? NextNode() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NodeFilter/*'/>
public partial interface NodeFilter
{
	///<include file='Utils/Docs.generated.xml' path='docs/NodeFilterFILTER_ACCEPT/*'/>
	public const ushort FILTER_ACCEPT = 1;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeFilterFILTER_REJECT/*'/>
	public const ushort FILTER_REJECT = 2;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeFilterFILTER_SKIP/*'/>
	public const ushort FILTER_SKIP = 3;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeFilterSHOW_ALL/*'/>
	public const ulong SHOW_ALL = 0xFFFFFFFF;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeFilterSHOW_ELEMENT/*'/>
	public const ulong SHOW_ELEMENT = 0x1;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeFilterSHOW_ATTRIBUTE/*'/>
	public const ulong SHOW_ATTRIBUTE = 0x2;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeFilterSHOW_TEXT/*'/>
	public const ulong SHOW_TEXT = 0x4;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeFilterSHOW_CDATA_SECTION/*'/>
	public const ulong SHOW_CDATA_SECTION = 0x8;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeFilterSHOW_ENTITY_REFERENCE/*'/>
	public const ulong SHOW_ENTITY_REFERENCE = 0x10;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeFilterSHOW_ENTITY/*'/>
	public const ulong SHOW_ENTITY = 0x20;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeFilterSHOW_PROCESSING_INSTRUCTION/*'/>
	public const ulong SHOW_PROCESSING_INSTRUCTION = 0x40;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeFilterSHOW_COMMENT/*'/>
	public const ulong SHOW_COMMENT = 0x80;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeFilterSHOW_DOCUMENT/*'/>
	public const ulong SHOW_DOCUMENT = 0x100;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeFilterSHOW_DOCUMENT_TYPE/*'/>
	public const ulong SHOW_DOCUMENT_TYPE = 0x200;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeFilterSHOW_DOCUMENT_FRAGMENT/*'/>
	public const ulong SHOW_DOCUMENT_FRAGMENT = 0x400;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeFilterSHOW_NOTATION/*'/>
	public const ulong SHOW_NOTATION = 0x800;
	///<include file='Utils/Docs.generated.xml' path='docs/NodeFilterAcceptNode/*'/>
	public ushort AcceptNode(Node node) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/DOMTokenList/*'/>
public partial class DOMTokenList
{
	///<include file='Utils/Docs.generated.xml' path='docs/DOMTokenListLength/*'/>
	public ulong Length { get; }
	
	///<include file='Utils/Docs.generated.xml' path='docs/DOMTokenListContains/*'/>
	public bool Contains(string token) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DOMTokenListAdd/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Add(params string[] tokens) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DOMTokenListRemove/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Remove(params string[] tokens) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DOMTokenListToggle/*'/>
	public bool Toggle(string token, bool force) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DOMTokenListReplace/*'/>
	public bool Replace(string token, string newToken) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DOMTokenListSupports/*'/>
	public bool Supports(string token) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DOMTokenListValue/*'/>
	public string Value { get; set; }
	
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/XPathResult/*'/>
public partial class XPathResult
{
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultANY_TYPE/*'/>
	public const ushort ANY_TYPE = 0;
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultNUMBER_TYPE/*'/>
	public const ushort NUMBER_TYPE = 1;
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultSTRING_TYPE/*'/>
	public const ushort STRING_TYPE = 2;
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultBOOLEAN_TYPE/*'/>
	public const ushort BOOLEAN_TYPE = 3;
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultUNORDERED_NODE_ITERATOR_TYPE/*'/>
	public const ushort UNORDERED_NODE_ITERATOR_TYPE = 4;
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultORDERED_NODE_ITERATOR_TYPE/*'/>
	public const ushort ORDERED_NODE_ITERATOR_TYPE = 5;
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultUNORDERED_NODE_SNAPSHOT_TYPE/*'/>
	public const ushort UNORDERED_NODE_SNAPSHOT_TYPE = 6;
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultORDERED_NODE_SNAPSHOT_TYPE/*'/>
	public const ushort ORDERED_NODE_SNAPSHOT_TYPE = 7;
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultANY_UNORDERED_NODE_TYPE/*'/>
	public const ushort ANY_UNORDERED_NODE_TYPE = 8;
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultFIRST_ORDERED_NODE_TYPE/*'/>
	public const ushort FIRST_ORDERED_NODE_TYPE = 9;
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultResultType/*'/>
	public ushort ResultType { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultNumberValue/*'/>
	public double NumberValue { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultStringValue/*'/>
	public string StringValue { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultBooleanValue/*'/>
	public bool BooleanValue { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultSingleNodeValue/*'/>
	public Node? SingleNodeValue { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultInvalidIteratorState/*'/>
	public bool InvalidIteratorState { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultSnapshotLength/*'/>
	public ulong SnapshotLength { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultIterateNext/*'/>
	public Node? IterateNext() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/XPathResultSnapshotItem/*'/>
	public Node? SnapshotItem(ulong index) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/XPathExpression/*'/>
public partial class XPathExpression
{
	///<include file='Utils/Docs.generated.xml' path='docs/XPathExpressionEvaluate/*'/>
	public XPathResult Evaluate(Node contextNode, ushort type, XPathResult? result) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/XPathNSResolver/*'/>
public partial interface XPathNSResolver
{
	///<include file='Utils/Docs.generated.xml' path='docs/XPathNSResolverLookupNamespaceURI/*'/>
	public string? LookupNamespaceURI(string? prefix) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/XPathEvaluatorBase/*'/>
public partial interface XPathEvaluatorBase
{
	///<include file='Utils/Docs.generated.xml' path='docs/XPathEvaluatorBaseCreateExpression/*'/>
	public XPathExpression CreateExpression(string expression, XPathNSResolver? resolver) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/XPathEvaluatorBaseCreateNSResolver/*'/>
	public XPathNSResolver CreateNSResolver(Node nodeResolver) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/XPathEvaluatorBaseEvaluate/*'/>
	public XPathResult Evaluate(string expression, Node contextNode, XPathNSResolver? resolver, ushort type, XPathResult? result) { throw new System.NotImplementedException(); }
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/XPathEvaluator/*'/>
public partial class XPathEvaluator
{
	///<include file='Utils/Docs.generated.xml' path='docs/XPathEvaluator/*'/>
	public XPathEvaluator() { }
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/XSLTProcessor/*'/>
public partial class XSLTProcessor
{
	///<include file='Utils/Docs.generated.xml' path='docs/XSLTProcessor/*'/>
	public XSLTProcessor() { }
	///<include file='Utils/Docs.generated.xml' path='docs/XSLTProcessorImportStylesheet/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ImportStylesheet(Node style) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/XSLTProcessorTransformToFragment/*'/>
	public DocumentFragment TransformToFragment(Node source, Document output) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/XSLTProcessorTransformToDocument/*'/>
	public Document TransformToDocument(Node source) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/XSLTProcessorSetParameter/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetParameter(string namespaceURI, string localName, dynamic value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/XSLTProcessorGetParameter/*'/>
	public dynamic GetParameter(string namespaceURI, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/XSLTProcessorRemoveParameter/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ RemoveParameter(string namespaceURI, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/XSLTProcessorClearParameters/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ClearParameters() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/XSLTProcessorReset/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Reset() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextDecoderCommon/*'/>
public partial interface TextDecoderCommon
{
	///<include file='Utils/Docs.generated.xml' path='docs/TextDecoderCommonEncoding/*'/>
	public string Encoding { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/TextDecoderCommonFatal/*'/>
	public bool Fatal { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/TextDecoderCommonIgnoreBOM/*'/>
	public bool IgnoreBOM { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/TextDecoderOptions/*'/>
public partial class TextDecoderOptions
{
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextDecoderOptionsFatal/*'/>
	public bool Fatal;
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextDecoderOptionsIgnoreBOM/*'/>
	public bool IgnoreBOM;
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/TextDecodeOptions/*'/>
public partial class TextDecodeOptions
{
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextDecodeOptionsStream/*'/>
	public bool Stream;
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/TextDecoder/*'/>
public partial class TextDecoder
{
	///<include file='Utils/Docs.generated.xml' path='docs/TextDecoder/*'/>
	public TextDecoder(string label, TextDecoderOptions options) { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextDecoderDecode/*'/>
	public string Decode(BufferSource input, TextDecodeOptions options) { throw new System.NotImplementedException(); }
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextEncoderCommon/*'/>
public partial interface TextEncoderCommon
{
	///<include file='Utils/Docs.generated.xml' path='docs/TextEncoderCommonEncoding/*'/>
	public string Encoding { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/TextEncoderEncodeIntoResult/*'/>
public partial class TextEncoderEncodeIntoResult
{
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextEncoderEncodeIntoResultRead/*'/>
	public ulong Read;
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextEncoderEncodeIntoResultWritten/*'/>
	public ulong Written;
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/TextEncoder/*'/>
public partial class TextEncoder
{
	///<include file='Utils/Docs.generated.xml' path='docs/TextEncoder/*'/>
	public TextEncoder() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextEncoderEncode/*'/>
	public System.Byte Encode(string input) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextEncoderEncodeInto/*'/>
	public TextEncoderEncodeIntoResult EncodeInto(string source, System.Byte destination) { throw new System.NotImplementedException(); }
}


[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/TextDecoderStream/*'/>
public partial class TextDecoderStream
{
	///<include file='Utils/Docs.generated.xml' path='docs/TextDecoderStream/*'/>
	public TextDecoderStream(string label, TextDecoderOptions options) { }
}



[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/TextEncoderStream/*'/>
public partial class TextEncoderStream
{
	///<include file='Utils/Docs.generated.xml' path='docs/TextEncoderStream/*'/>
	public TextEncoderStream() { }
}




[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Headers/*'/>
public partial class Headers
{
	///<include file='Utils/Docs.generated.xml' path='docs/Headers/*'/>
	public Headers(HeadersInit init) { }
	///<include file='Utils/Docs.generated.xml' path='docs/HeadersAppend/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Append(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/HeadersDelete/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Delete(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/HeadersGet/*'/>
	public string? Get(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/HeadersHas/*'/>
	public bool Has(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/HeadersSet/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Set(string name, string value) { throw new System.NotImplementedException(); }
	
}



[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Body/*'/>
public partial interface Body
{
	///<include file='Utils/Docs.generated.xml' path='docs/BodyBody/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*ReadableStream*/? Body { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/BodyBodyUsed/*'/>
	public bool BodyUsed { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/BodyArrayBuffer/*'/>
	public Task<byte[]> ArrayBuffer() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/BodyBlob/*'/>
	public Task<CSharpToJavaScript.Utils.Unsupported /*Blob*/> Blob() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/BodyFormData/*'/>
	public Task<FormData> FormData() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/BodyJson/*'/>
	public Task<dynamic> Json() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/BodyText/*'/>
	public Task<string> Text() { throw new System.NotImplementedException(); }
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Request/*'/>
public partial class Request
{
	///<include file='Utils/Docs.generated.xml' path='docs/Request/*'/>
	public Request(RequestInfo input, RequestInit init) { }
	///<include file='Utils/Docs.generated.xml' path='docs/RequestMethod/*'/>
	public string Method { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/RequestUrl/*'/>
	public string Url { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/RequestHeaders/*'/>
	public Headers Headers { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/RequestDestination/*'/>
	public RequestDestination Destination { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/RequestReferrer/*'/>
	public string Referrer { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/RequestReferrerPolicy/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*ReferrerPolicy*/ ReferrerPolicy { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/RequestMode/*'/>
	public RequestMode Mode { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/RequestCredentials/*'/>
	public RequestCredentials Credentials { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/RequestCache/*'/>
	public RequestCache Cache { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/RequestRedirect/*'/>
	public RequestRedirect Redirect { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/RequestIntegrity/*'/>
	public string Integrity { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/RequestKeepalive/*'/>
	public bool Keepalive { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/RequestIsReloadNavigation/*'/>
	public bool IsReloadNavigation { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/RequestIsHistoryNavigation/*'/>
	public bool IsHistoryNavigation { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/RequestSignal/*'/>
	public AbortSignal Signal { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/RequestClone/*'/>
	public Request Clone() { throw new System.NotImplementedException(); }
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/RequestInit/*'/>
public partial class RequestInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/RequestInitMethod/*'/>
	public string Method;
	///<include file='Utils/Docs.generated.xml' path='docs/RequestInitHeaders/*'/>
	public HeadersInit Headers;
	///<include file='Utils/Docs.generated.xml' path='docs/RequestInitBody/*'/>
	public BodyInit? Body;
	///<include file='Utils/Docs.generated.xml' path='docs/RequestInitReferrer/*'/>
	public string Referrer;
	///<include file='Utils/Docs.generated.xml' path='docs/RequestInitReferrerPolicy/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*ReferrerPolicy*/ ReferrerPolicy;
	///<include file='Utils/Docs.generated.xml' path='docs/RequestInitMode/*'/>
	public RequestMode Mode;
	///<include file='Utils/Docs.generated.xml' path='docs/RequestInitCredentials/*'/>
	public RequestCredentials Credentials;
	///<include file='Utils/Docs.generated.xml' path='docs/RequestInitCache/*'/>
	public RequestCache Cache;
	///<include file='Utils/Docs.generated.xml' path='docs/RequestInitRedirect/*'/>
	public RequestRedirect Redirect;
	///<include file='Utils/Docs.generated.xml' path='docs/RequestInitIntegrity/*'/>
	public string Integrity;
	///<include file='Utils/Docs.generated.xml' path='docs/RequestInitKeepalive/*'/>
	public bool Keepalive;
	///<include file='Utils/Docs.generated.xml' path='docs/RequestInitSignal/*'/>
	public AbortSignal? Signal;
	///<include file='Utils/Docs.generated.xml' path='docs/RequestInitWindow/*'/>
	public dynamic Window;
}

///<include file='Utils/Docs.generated.xml' path='docs/RequestDestination/*'/>
public enum RequestDestination
{
	Empty,
	Audio,
	Audioworklet,
	Document,
	Embed,
	Font,
	Frame,
	Iframe,
	Image,
	Manifest,
	Object,
	Paintworklet,
	Report,
	Script,
	Sharedworker,
	Style,
	Track,
	Video,
	Worker,
	Xslt,
}

///<include file='Utils/Docs.generated.xml' path='docs/RequestMode/*'/>
public enum RequestMode
{
	Navigate,
	SameOrigin,
	NoCors,
	Cors,
}

///<include file='Utils/Docs.generated.xml' path='docs/RequestCredentials/*'/>
public enum RequestCredentials
{
	Omit,
	SameOrigin,
	Include,
}

///<include file='Utils/Docs.generated.xml' path='docs/RequestCache/*'/>
public enum RequestCache
{
	Default,
	NoStore,
	Reload,
	NoCache,
	ForceCache,
	OnlyIfCached,
}

///<include file='Utils/Docs.generated.xml' path='docs/RequestRedirect/*'/>
public enum RequestRedirect
{
	Follow,
	Error,
	Manual,
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Response/*'/>
public partial class Response
{
	///<include file='Utils/Docs.generated.xml' path='docs/Response/*'/>
	public Response(BodyInit? body, ResponseInit init) { }
	///<include file='Utils/Docs.generated.xml' path='docs/ResponseError/*'/>
	public static Response Error() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ResponseRedirect/*'/>
	public static Response Redirect(string url, ushort status) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ResponseJson/*'/>
	public static Response Json(dynamic data, ResponseInit init) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ResponseType/*'/>
	public ResponseType Type { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ResponseUrl/*'/>
	public string Url { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ResponseRedirected/*'/>
	public bool Redirected { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ResponseStatus/*'/>
	public ushort Status { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ResponseOk/*'/>
	public bool Ok { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ResponseStatusText/*'/>
	public string StatusText { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ResponseHeaders/*'/>
	public Headers Headers { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ResponseClone/*'/>
	public Response Clone() { throw new System.NotImplementedException(); }
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ResponseInit/*'/>
public partial class ResponseInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/ResponseInitStatus/*'/>
	public ushort Status;
	///<include file='Utils/Docs.generated.xml' path='docs/ResponseInitStatusText/*'/>
	public string StatusText;
	///<include file='Utils/Docs.generated.xml' path='docs/ResponseInitHeaders/*'/>
	public HeadersInit Headers;
}

///<include file='Utils/Docs.generated.xml' path='docs/ResponseType/*'/>
public enum ResponseType
{
	Basic,
	Cors,
	Default,
	Error,
	Opaque,
	Opaqueredirect,
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/WindowOrWorkerGlobalScope/*'/>
public partial interface WindowOrWorkerGlobalScope
{
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOrWorkerGlobalScopeFetch/*'/>
	public Task<Response> Fetch(RequestInfo input, RequestInit init) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs.generated.xml' path='docs/FullscreenNavigationUI/*'/>
public enum FullscreenNavigationUI
{
	Auto,
	Show,
	Hide,
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/FullscreenOptions/*'/>
public partial class FullscreenOptions
{
	///<include file='Utils/Docs.generated.xml' path='docs/FullscreenOptionsNavigationUI/*'/>
	public FullscreenNavigationUI NavigationUI;
}

///<include file='Utils/Docs.generated.xml' path='docs/Element/*'/>
public partial class Element
{
	///<include file='Utils/Docs.generated.xml' path='docs/ElementRequestFullscreen/*'/>
	public Task<CSharpToJavaScript.Utils.Unsupported /*undefined*/> RequestFullscreen(FullscreenOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementOnfullscreenchange/*'/>
	public EventHandler Onfullscreenchange { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementOnfullscreenerror/*'/>
	public EventHandler Onfullscreenerror { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Document/*'/>
public partial class Document
{
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentFullscreenEnabled/*'/>
	public bool FullscreenEnabled { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentFullscreen/*'/>
	public bool Fullscreen { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentExitFullscreen/*'/>
	public Task<CSharpToJavaScript.Utils.Unsupported /*undefined*/> ExitFullscreen() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentOnfullscreenchange/*'/>
	public EventHandler Onfullscreenchange { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentOnfullscreenerror/*'/>
	public EventHandler Onfullscreenerror { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/DocumentOrShadowRoot/*'/>
public partial interface DocumentOrShadowRoot
{
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentOrShadowRootFullscreenElement/*'/>
	public Element? FullscreenElement { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAllCollection/*'/>
public partial class HTMLAllCollection
{
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAllCollectionLength/*'/>
	public ulong Length { get; }
	
	
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAllCollectionItem/*'/>
	public Union14? Item(string nameOrIndex) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormControlsCollection/*'/>
public partial class HTMLFormControlsCollection : HTMLCollection
{
	
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/RadioNodeList/*'/>
public partial class RadioNodeList : NodeList
{
	///<include file='Utils/Docs.generated.xml' path='docs/RadioNodeListValue/*'/>
	public string Value { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptionsCollection/*'/>
public partial class HTMLOptionsCollection : HTMLCollection
{
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptionsCollectionLength/*'/>
	public ulong Length { get; set; }
	
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptionsCollectionAdd/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Add(Union16 element, Union17? before) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptionsCollectionRemove/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Remove(long index) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptionsCollectionSelectedIndex/*'/>
	public long SelectedIndex { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/DOMStringList/*'/>
public partial class DOMStringList
{
	///<include file='Utils/Docs.generated.xml' path='docs/DOMStringListLength/*'/>
	public ulong Length { get; }
	
	///<include file='Utils/Docs.generated.xml' path='docs/DOMStringListContains/*'/>
	public bool Contains(string string_) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs.generated.xml' path='docs/DocumentReadyState/*'/>
public enum DocumentReadyState
{
	Loading,
	Interactive,
	Complete,
}

///<include file='Utils/Docs.generated.xml' path='docs/DocumentVisibilityState/*'/>
public enum DocumentVisibilityState
{
	Visible,
	Hidden,
}


///<include file='Utils/Docs.generated.xml' path='docs/Document/*'/>
public partial class Document
{
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentLocation/*'/>
	public Location? Location { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentDomain/*'/>
	public string Domain { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentReferrer/*'/>
	public string Referrer { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentCookie/*'/>
	public string Cookie { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentLastModified/*'/>
	public string LastModified { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentReadyState/*'/>
	public DocumentReadyState ReadyState { get; }
	
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentTitle/*'/>
	public string Title { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentDir/*'/>
	public string Dir { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentBody/*'/>
	public HTMLElement? Body { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentHead/*'/>
	public HTMLHeadElement? Head { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentImages/*'/>
	public HTMLCollection Images { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentEmbeds/*'/>
	public HTMLCollection Embeds { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentPlugins/*'/>
	public HTMLCollection Plugins { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentLinks/*'/>
	public HTMLCollection Links { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentForms/*'/>
	public HTMLCollection Forms { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentScripts/*'/>
	public HTMLCollection Scripts { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentGetElementsByName/*'/>
	public NodeList GetElementsByName(string elementName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentCurrentScript/*'/>
	public HTMLOrSVGScriptElement? CurrentScript { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentOpen/*'/>
	public Document Open(string unused1, string unused2) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentOpen/*'/>
	public Window? Open(string url, string name, string features) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentClose/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Close() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentWrite/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Write(params string[] text) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentWriteln/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Writeln(params string[] text) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentDefaultView/*'/>
	public Window? DefaultView { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentHasFocus/*'/>
	public bool HasFocus() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentDesignMode/*'/>
	public string DesignMode { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentExecCommand/*'/>
	public bool ExecCommand(string commandId, bool showUI, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentQueryCommandEnabled/*'/>
	public bool QueryCommandEnabled(string commandId) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentQueryCommandIndeterm/*'/>
	public bool QueryCommandIndeterm(string commandId) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentQueryCommandState/*'/>
	public bool QueryCommandState(string commandId) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentQueryCommandSupported/*'/>
	public bool QueryCommandSupported(string commandId) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentQueryCommandValue/*'/>
	public string QueryCommandValue(string commandId) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentHidden/*'/>
	public bool Hidden { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentVisibilityState/*'/>
	public DocumentVisibilityState VisibilityState { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentOnreadystatechange/*'/>
	public EventHandler Onreadystatechange { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentOnvisibilitychange/*'/>
	public EventHandler Onvisibilitychange { get; set; }
}



///<include file='Utils/Docs.generated.xml' path='docs/DocumentOrShadowRoot/*'/>
public partial interface DocumentOrShadowRoot
{
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentOrShadowRootActiveElement/*'/>
	public Element? ActiveElement { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLElement/*'/>
public partial class HTMLElement : Element, GlobalEventHandlers, DocumentAndElementEventHandlers, ElementContentEditable, HTMLOrSVGElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLElement/*'/>
	public HTMLElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLElementTitle/*'/>
	public string Title { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLElementLang/*'/>
	public string Lang { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLElementTranslate/*'/>
	public bool Translate { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLElementDir/*'/>
	public string Dir { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLElementHidden/*'/>
	public Union19? Hidden { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLElementInert/*'/>
	public bool Inert { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLElementClick/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Click() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLElementAccessKey/*'/>
	public string AccessKey { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLElementAccessKeyLabel/*'/>
	public string AccessKeyLabel { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLElementDraggable/*'/>
	public bool Draggable { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLElementSpellcheck/*'/>
	public bool Spellcheck { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLElementAutocapitalize/*'/>
	public string Autocapitalize { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLElementInnerText/*'/>
	public string InnerText { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLElementOuterText/*'/>
	public string OuterText { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLElementAttachInternals/*'/>
	public ElementInternals AttachInternals() { throw new System.NotImplementedException(); }
}





[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLUnknownElement/*'/>
public partial class HTMLUnknownElement : HTMLElement
{
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOrSVGElement/*'/>
public partial interface HTMLOrSVGElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLOrSVGElementDataset/*'/>
	public string Dataset { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLOrSVGElementNonce/*'/>
	public string Nonce { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLOrSVGElementAutofocus/*'/>
	public bool Autofocus { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLOrSVGElementTabIndex/*'/>
	public long TabIndex { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLOrSVGElementFocus/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Focus(FocusOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLOrSVGElementBlur/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Blur() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/DOMStringMap/*'/>
public partial class DOMStringMap
{
	
	
	
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLHtmlElement/*'/>
public partial class HTMLHtmlElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHtmlElement/*'/>
	public HTMLHtmlElement() { }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLHeadElement/*'/>
public partial class HTMLHeadElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHeadElement/*'/>
	public HTMLHeadElement() { }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTitleElement/*'/>
public partial class HTMLTitleElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTitleElement/*'/>
	public HTMLTitleElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTitleElementText/*'/>
	public string Text { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLBaseElement/*'/>
public partial class HTMLBaseElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLBaseElement/*'/>
	public HTMLBaseElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLBaseElementHref/*'/>
	public string Href { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLBaseElementTarget/*'/>
	public string Target { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElement/*'/>
public partial class HTMLLinkElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElement/*'/>
	public HTMLLinkElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElementHref/*'/>
	public string Href { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElementCrossOrigin/*'/>
	public string? CrossOrigin { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElementRel/*'/>
	public string Rel { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElementAs/*'/>
	public string As { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElementRelList/*'/>
	public DOMTokenList RelList { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElementMedia/*'/>
	public string Media { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElementIntegrity/*'/>
	public string Integrity { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElementHreflang/*'/>
	public string Hreflang { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElementType/*'/>
	public string Type { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElementSizes/*'/>
	public DOMTokenList Sizes { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElementImageSrcset/*'/>
	public string ImageSrcset { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElementImageSizes/*'/>
	public string ImageSizes { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElementReferrerPolicy/*'/>
	public string ReferrerPolicy { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElementBlocking/*'/>
	public DOMTokenList Blocking { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElementDisabled/*'/>
	public bool Disabled { get; set; }
}


[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMetaElement/*'/>
public partial class HTMLMetaElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLMetaElement/*'/>
	public HTMLMetaElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMetaElementName/*'/>
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMetaElementHttpEquiv/*'/>
	public string HttpEquiv { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMetaElementContent/*'/>
	public string Content { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMetaElementMedia/*'/>
	public string Media { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLStyleElement/*'/>
public partial class HTMLStyleElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLStyleElement/*'/>
	public HTMLStyleElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLStyleElementDisabled/*'/>
	public bool Disabled { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLStyleElementMedia/*'/>
	public string Media { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLStyleElementBlocking/*'/>
	public DOMTokenList Blocking { get; }
}


///<include file='Utils/Docs.generated.xml' path='docs/HTMLBodyElement/*'/>
public partial class HTMLBodyElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLBodyElement/*'/>
	public HTMLBodyElement() { }
}


[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLHeadingElement/*'/>
public partial class HTMLHeadingElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHeadingElement/*'/>
	public HTMLHeadingElement() { }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLParagraphElement/*'/>
public partial class HTMLParagraphElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLParagraphElement/*'/>
	public HTMLParagraphElement() { }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLHRElement/*'/>
public partial class HTMLHRElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHRElement/*'/>
	public HTMLHRElement() { }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLPreElement/*'/>
public partial class HTMLPreElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLPreElement/*'/>
	public HTMLPreElement() { }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLQuoteElement/*'/>
public partial class HTMLQuoteElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLQuoteElement/*'/>
	public HTMLQuoteElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLQuoteElementCite/*'/>
	public string Cite { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOListElement/*'/>
public partial class HTMLOListElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLOListElement/*'/>
	public HTMLOListElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOListElementReversed/*'/>
	public bool Reversed { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOListElementStart/*'/>
	public long Start { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOListElementType/*'/>
	public string Type { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLUListElement/*'/>
public partial class HTMLUListElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLUListElement/*'/>
	public HTMLUListElement() { }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMenuElement/*'/>
public partial class HTMLMenuElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLMenuElement/*'/>
	public HTMLMenuElement() { }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLIElement/*'/>
public partial class HTMLLIElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLLIElement/*'/>
	public HTMLLIElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLIElementValue/*'/>
	public long Value { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLDListElement/*'/>
public partial class HTMLDListElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLDListElement/*'/>
	public HTMLDListElement() { }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLDivElement/*'/>
public partial class HTMLDivElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLDivElement/*'/>
	public HTMLDivElement() { }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAnchorElement/*'/>
public partial class HTMLAnchorElement : HTMLElement, HTMLHyperlinkElementUtils
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLAnchorElement/*'/>
	public HTMLAnchorElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAnchorElementTarget/*'/>
	public string Target { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAnchorElementDownload/*'/>
	public string Download { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAnchorElementPing/*'/>
	public string Ping { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAnchorElementRel/*'/>
	public string Rel { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAnchorElementRelList/*'/>
	public DOMTokenList RelList { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAnchorElementHreflang/*'/>
	public string Hreflang { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAnchorElementType/*'/>
	public string Type { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAnchorElementText/*'/>
	public string Text { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAnchorElementReferrerPolicy/*'/>
	public string ReferrerPolicy { get; set; }
}


[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLDataElement/*'/>
public partial class HTMLDataElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLDataElement/*'/>
	public HTMLDataElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLDataElementValue/*'/>
	public string Value { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTimeElement/*'/>
public partial class HTMLTimeElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTimeElement/*'/>
	public HTMLTimeElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTimeElementDateTime/*'/>
	public string DateTime { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSpanElement/*'/>
public partial class HTMLSpanElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLSpanElement/*'/>
	public HTMLSpanElement() { }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLBRElement/*'/>
public partial class HTMLBRElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLBRElement/*'/>
	public HTMLBRElement() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLHyperlinkElementUtils/*'/>
public partial interface HTMLHyperlinkElementUtils
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHyperlinkElementUtilsHref/*'/>
	public string Href { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHyperlinkElementUtilsOrigin/*'/>
	public string Origin { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHyperlinkElementUtilsProtocol/*'/>
	public string Protocol { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHyperlinkElementUtilsUsername/*'/>
	public string Username { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHyperlinkElementUtilsPassword/*'/>
	public string Password { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHyperlinkElementUtilsHost/*'/>
	public string Host { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHyperlinkElementUtilsHostname/*'/>
	public string Hostname { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHyperlinkElementUtilsPort/*'/>
	public string Port { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHyperlinkElementUtilsPathname/*'/>
	public string Pathname { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHyperlinkElementUtilsSearch/*'/>
	public string Search { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHyperlinkElementUtilsHash/*'/>
	public string Hash { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLModElement/*'/>
public partial class HTMLModElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLModElement/*'/>
	public HTMLModElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLModElementCite/*'/>
	public string Cite { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLModElementDateTime/*'/>
	public string DateTime { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLPictureElement/*'/>
public partial class HTMLPictureElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLPictureElement/*'/>
	public HTMLPictureElement() { }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSourceElement/*'/>
public partial class HTMLSourceElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLSourceElement/*'/>
	public HTMLSourceElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSourceElementSrc/*'/>
	public string Src { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSourceElementType/*'/>
	public string Type { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSourceElementSrcset/*'/>
	public string Srcset { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSourceElementSizes/*'/>
	public string Sizes { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSourceElementMedia/*'/>
	public string Media { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSourceElementWidth/*'/>
	public ulong Width { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSourceElementHeight/*'/>
	public ulong Height { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElement/*'/>
public partial class HTMLImageElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElement/*'/>
	public HTMLImageElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementAlt/*'/>
	public string Alt { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementSrc/*'/>
	public string Src { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementSrcset/*'/>
	public string Srcset { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementSizes/*'/>
	public string Sizes { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementCrossOrigin/*'/>
	public string? CrossOrigin { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementUseMap/*'/>
	public string UseMap { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementIsMap/*'/>
	public bool IsMap { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementWidth/*'/>
	public ulong Width { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementHeight/*'/>
	public ulong Height { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementNaturalWidth/*'/>
	public ulong NaturalWidth { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementNaturalHeight/*'/>
	public ulong NaturalHeight { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementComplete/*'/>
	public bool Complete { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementCurrentSrc/*'/>
	public string CurrentSrc { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementReferrerPolicy/*'/>
	public string ReferrerPolicy { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementDecoding/*'/>
	public string Decoding { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementLoading/*'/>
	public string Loading { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementDecode/*'/>
	public Task<CSharpToJavaScript.Utils.Unsupported /*undefined*/> Decode() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElement/*'/>
public partial class HTMLIFrameElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElement/*'/>
	public HTMLIFrameElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementSrc/*'/>
	public string Src { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementSrcdoc/*'/>
	public string Srcdoc { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementName/*'/>
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementSandbox/*'/>
	public DOMTokenList Sandbox { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementAllow/*'/>
	public string Allow { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementAllowFullscreen/*'/>
	public bool AllowFullscreen { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementWidth/*'/>
	public string Width { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementHeight/*'/>
	public string Height { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementReferrerPolicy/*'/>
	public string ReferrerPolicy { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementLoading/*'/>
	public string Loading { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementContentDocument/*'/>
	public Document? ContentDocument { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementContentWindow/*'/>
	public Window? ContentWindow { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementGetSVGDocument/*'/>
	public Document? GetSVGDocument() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLEmbedElement/*'/>
public partial class HTMLEmbedElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLEmbedElement/*'/>
	public HTMLEmbedElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLEmbedElementSrc/*'/>
	public string Src { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLEmbedElementType/*'/>
	public string Type { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLEmbedElementWidth/*'/>
	public string Width { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLEmbedElementHeight/*'/>
	public string Height { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLEmbedElementGetSVGDocument/*'/>
	public Document? GetSVGDocument() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElement/*'/>
public partial class HTMLObjectElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElement/*'/>
	public HTMLObjectElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementData/*'/>
	public string Data { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementType/*'/>
	public string Type { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementName/*'/>
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementForm/*'/>
	public HTMLFormElement? Form { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementWidth/*'/>
	public string Width { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementHeight/*'/>
	public string Height { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementContentDocument/*'/>
	public Document? ContentDocument { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementContentWindow/*'/>
	public Window? ContentWindow { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementGetSVGDocument/*'/>
	public Document? GetSVGDocument() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementWillValidate/*'/>
	public bool WillValidate { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementValidity/*'/>
	public ValidityState Validity { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementValidationMessage/*'/>
	public string ValidationMessage { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementCheckValidity/*'/>
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementReportValidity/*'/>
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementSetCustomValidity/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetCustomValidity(string error) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLVideoElement/*'/>
public partial class HTMLVideoElement : HTMLMediaElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLVideoElement/*'/>
	public HTMLVideoElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLVideoElementWidth/*'/>
	public ulong Width { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLVideoElementHeight/*'/>
	public ulong Height { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLVideoElementVideoWidth/*'/>
	public ulong VideoWidth { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLVideoElementVideoHeight/*'/>
	public ulong VideoHeight { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLVideoElementPoster/*'/>
	public string Poster { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLVideoElementPlaysInline/*'/>
	public bool PlaysInline { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAudioElement/*'/>
public partial class HTMLAudioElement : HTMLMediaElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLAudioElement/*'/>
	public HTMLAudioElement() { }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTrackElement/*'/>
public partial class HTMLTrackElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTrackElement/*'/>
	public HTMLTrackElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTrackElementKind/*'/>
	public string Kind { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTrackElementSrc/*'/>
	public string Src { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTrackElementSrclang/*'/>
	public string Srclang { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTrackElementLabel/*'/>
	public string Label { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTrackElementDefault/*'/>
	public bool Default { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTrackElementNONE/*'/>
	public const ushort NONE = 0;
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTrackElementLOADING/*'/>
	public const ushort LOADING = 1;
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTrackElementLOADED/*'/>
	public const ushort LOADED = 2;
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTrackElementERROR/*'/>
	public const ushort ERROR = 3;
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTrackElementReadyState/*'/>
	public ushort ReadyState { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTrackElementTrack/*'/>
	public TextTrack Track { get; }
}

///<include file='Utils/Docs.generated.xml' path='docs/CanPlayTypeResult/*'/>
public enum CanPlayTypeResult
{
	Empty,
	Maybe,
	Probably,
}


[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElement/*'/>
public partial class HTMLMediaElement : HTMLElement
{
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementError/*'/>
	public MediaError? Error { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementSrc/*'/>
	public string Src { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementSrcObject/*'/>
	public MediaProvider? SrcObject { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementCurrentSrc/*'/>
	public string CurrentSrc { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementCrossOrigin/*'/>
	public string? CrossOrigin { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementNETWORK_EMPTY/*'/>
	public const ushort NETWORK_EMPTY = 0;
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementNETWORK_IDLE/*'/>
	public const ushort NETWORK_IDLE = 1;
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementNETWORK_LOADING/*'/>
	public const ushort NETWORK_LOADING = 2;
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementNETWORK_NO_SOURCE/*'/>
	public const ushort NETWORK_NO_SOURCE = 3;
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementNetworkState/*'/>
	public ushort NetworkState { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementPreload/*'/>
	public string Preload { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementBufferingThrottled/*'/>
	public bool BufferingThrottled { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementBuffered/*'/>
	public TimeRanges Buffered { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementLoad/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Load() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementCanPlayType/*'/>
	public CanPlayTypeResult CanPlayType(string type) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementHAVE_NOTHING/*'/>
	public const ushort HAVE_NOTHING = 0;
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementHAVE_METADATA/*'/>
	public const ushort HAVE_METADATA = 1;
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementHAVE_CURRENT_DATA/*'/>
	public const ushort HAVE_CURRENT_DATA = 2;
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementHAVE_FUTURE_DATA/*'/>
	public const ushort HAVE_FUTURE_DATA = 3;
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementHAVE_ENOUGH_DATA/*'/>
	public const ushort HAVE_ENOUGH_DATA = 4;
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementReadyState/*'/>
	public ushort ReadyState { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementSeeking/*'/>
	public bool Seeking { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementCurrentTime/*'/>
	public double CurrentTime { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementFastSeek/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ FastSeek(double time) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementDuration/*'/>
	public double Duration { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementGetStartDate/*'/>
	public object GetStartDate() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementPaused/*'/>
	public bool Paused { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementDefaultPlaybackRate/*'/>
	public double DefaultPlaybackRate { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementPlaybackRate/*'/>
	public double PlaybackRate { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementPreservesPitch/*'/>
	public bool PreservesPitch { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementPlayed/*'/>
	public TimeRanges Played { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementSeekable/*'/>
	public TimeRanges Seekable { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementEnded/*'/>
	public bool Ended { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementAutoplay/*'/>
	public bool Autoplay { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementLoop/*'/>
	public bool Loop { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementPlay/*'/>
	public Task<CSharpToJavaScript.Utils.Unsupported /*undefined*/> Play() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementPause/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Pause() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementControls/*'/>
	public bool Controls { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementVolume/*'/>
	public double Volume { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementMuted/*'/>
	public bool Muted { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementDefaultMuted/*'/>
	public bool DefaultMuted { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementAudioTracks/*'/>
	public AudioTrackList AudioTracks { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementVideoTracks/*'/>
	public VideoTrackList VideoTracks { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementTextTracks/*'/>
	public TextTrackList TextTracks { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMediaElementAddTextTrack/*'/>
	public TextTrack AddTextTrack(TextTrackKind kind, string label, string language) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/MediaError/*'/>
public partial class MediaError
{
	///<include file='Utils/Docs.generated.xml' path='docs/MediaErrorMEDIA_ERR_ABORTED/*'/>
	public const ushort MEDIA_ERR_ABORTED = 1;
	///<include file='Utils/Docs.generated.xml' path='docs/MediaErrorMEDIA_ERR_NETWORK/*'/>
	public const ushort MEDIA_ERR_NETWORK = 2;
	///<include file='Utils/Docs.generated.xml' path='docs/MediaErrorMEDIA_ERR_DECODE/*'/>
	public const ushort MEDIA_ERR_DECODE = 3;
	///<include file='Utils/Docs.generated.xml' path='docs/MediaErrorMEDIA_ERR_SRC_NOT_SUPPORTED/*'/>
	public const ushort MEDIA_ERR_SRC_NOT_SUPPORTED = 4;
	///<include file='Utils/Docs.generated.xml' path='docs/MediaErrorCode/*'/>
	public ushort Code { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/MediaErrorMessage/*'/>
	public string Message { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/AudioTrackList/*'/>
public partial class AudioTrackList : EventTarget
{
	///<include file='Utils/Docs.generated.xml' path='docs/AudioTrackListLength/*'/>
	public ulong Length { get; }
	
	///<include file='Utils/Docs.generated.xml' path='docs/AudioTrackListGetTrackById/*'/>
	public AudioTrack? GetTrackById(string id) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/AudioTrackListOnchange/*'/>
	public EventHandler Onchange { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/AudioTrackListOnaddtrack/*'/>
	public EventHandler Onaddtrack { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/AudioTrackListOnremovetrack/*'/>
	public EventHandler Onremovetrack { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/AudioTrack/*'/>
public partial class AudioTrack
{
	///<include file='Utils/Docs.generated.xml' path='docs/AudioTrackId/*'/>
	public string Id { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/AudioTrackKind/*'/>
	public string Kind { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/AudioTrackLabel/*'/>
	public string Label { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/AudioTrackLanguage/*'/>
	public string Language { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/AudioTrackEnabled/*'/>
	public bool Enabled { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/VideoTrackList/*'/>
public partial class VideoTrackList : EventTarget
{
	///<include file='Utils/Docs.generated.xml' path='docs/VideoTrackListLength/*'/>
	public ulong Length { get; }
	
	///<include file='Utils/Docs.generated.xml' path='docs/VideoTrackListGetTrackById/*'/>
	public VideoTrack? GetTrackById(string id) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/VideoTrackListSelectedIndex/*'/>
	public long SelectedIndex { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/VideoTrackListOnchange/*'/>
	public EventHandler Onchange { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/VideoTrackListOnaddtrack/*'/>
	public EventHandler Onaddtrack { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/VideoTrackListOnremovetrack/*'/>
	public EventHandler Onremovetrack { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/VideoTrack/*'/>
public partial class VideoTrack
{
	///<include file='Utils/Docs.generated.xml' path='docs/VideoTrackId/*'/>
	public string Id { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/VideoTrackKind/*'/>
	public string Kind { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/VideoTrackLabel/*'/>
	public string Label { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/VideoTrackLanguage/*'/>
	public string Language { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/VideoTrackSelected/*'/>
	public bool Selected { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackList/*'/>
public partial class TextTrackList : EventTarget
{
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackListLength/*'/>
	public ulong Length { get; }
	
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackListGetTrackById/*'/>
	public TextTrack? GetTrackById(string id) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackListOnchange/*'/>
	public EventHandler Onchange { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackListOnaddtrack/*'/>
	public EventHandler Onaddtrack { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackListOnremovetrack/*'/>
	public EventHandler Onremovetrack { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/TextTrackMode/*'/>
public enum TextTrackMode
{
	Disabled,
	Hidden,
	Showing,
}

///<include file='Utils/Docs.generated.xml' path='docs/TextTrackKind/*'/>
public enum TextTrackKind
{
	Subtitles,
	Captions,
	Descriptions,
	Chapters,
	Metadata,
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrack/*'/>
public partial class TextTrack : EventTarget
{
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackKind/*'/>
	public TextTrackKind Kind { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackLabel/*'/>
	public string Label { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackLanguage/*'/>
	public string Language { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackId/*'/>
	public string Id { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackInBandMetadataTrackDispatchType/*'/>
	public string InBandMetadataTrackDispatchType { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackMode/*'/>
	public TextTrackMode Mode { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackCues/*'/>
	public TextTrackCueList? Cues { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackActiveCues/*'/>
	public TextTrackCueList? ActiveCues { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackAddCue/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ AddCue(TextTrackCue cue) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackRemoveCue/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ RemoveCue(TextTrackCue cue) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackOncuechange/*'/>
	public EventHandler Oncuechange { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackCueList/*'/>
public partial class TextTrackCueList
{
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackCueListLength/*'/>
	public ulong Length { get; }
	
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackCueListGetCueById/*'/>
	public TextTrackCue? GetCueById(string id) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackCue/*'/>
public partial class TextTrackCue : EventTarget
{
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackCueTrack/*'/>
	public TextTrack? Track { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackCueId/*'/>
	public string Id { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackCueStartTime/*'/>
	public double StartTime { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackCueEndTime/*'/>
	public double EndTime { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackCuePauseOnExit/*'/>
	public bool PauseOnExit { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackCueOnenter/*'/>
	public EventHandler Onenter { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextTrackCueOnexit/*'/>
	public EventHandler Onexit { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TimeRanges/*'/>
public partial class TimeRanges
{
	///<include file='Utils/Docs.generated.xml' path='docs/TimeRangesLength/*'/>
	public ulong Length { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/TimeRangesStart/*'/>
	public double Start(ulong index) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/TimeRangesEnd/*'/>
	public double End(ulong index) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TrackEvent/*'/>
public partial class TrackEvent : Event
{
	///<include file='Utils/Docs.generated.xml' path='docs/TrackEvent/*'/>
	public TrackEvent(string type, TrackEventInit eventInitDict) { }
	///<include file='Utils/Docs.generated.xml' path='docs/TrackEventTrack/*'/>
	public Union21? Track { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TrackEventInit/*'/>
public partial class TrackEventInit : EventInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/TrackEventInitTrack/*'/>
	public Union22? Track;
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMapElement/*'/>
public partial class HTMLMapElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLMapElement/*'/>
	public HTMLMapElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMapElementName/*'/>
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMapElementAreas/*'/>
	public HTMLCollection Areas { get; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAreaElement/*'/>
public partial class HTMLAreaElement : HTMLElement, HTMLHyperlinkElementUtils
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLAreaElement/*'/>
	public HTMLAreaElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAreaElementAlt/*'/>
	public string Alt { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAreaElementCoords/*'/>
	public string Coords { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAreaElementShape/*'/>
	public string Shape { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAreaElementTarget/*'/>
	public string Target { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAreaElementDownload/*'/>
	public string Download { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAreaElementPing/*'/>
	public string Ping { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAreaElementRel/*'/>
	public string Rel { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAreaElementRelList/*'/>
	public DOMTokenList RelList { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLAreaElementReferrerPolicy/*'/>
	public string ReferrerPolicy { get; set; }
}


[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElement/*'/>
public partial class HTMLTableElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElement/*'/>
	public HTMLTableElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementCaption/*'/>
	public HTMLTableCaptionElement? Caption { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementCreateCaption/*'/>
	public HTMLTableCaptionElement CreateCaption() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementDeleteCaption/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ DeleteCaption() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementTHead/*'/>
	public HTMLTableSectionElement? THead { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementCreateTHead/*'/>
	public HTMLTableSectionElement CreateTHead() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementDeleteTHead/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ DeleteTHead() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementTFoot/*'/>
	public HTMLTableSectionElement? TFoot { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementCreateTFoot/*'/>
	public HTMLTableSectionElement CreateTFoot() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementDeleteTFoot/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ DeleteTFoot() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementTBodies/*'/>
	public HTMLCollection TBodies { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementCreateTBody/*'/>
	public HTMLTableSectionElement CreateTBody() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementRows/*'/>
	public HTMLCollection Rows { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementInsertRow/*'/>
	public HTMLTableRowElement InsertRow(long index) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementDeleteRow/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ DeleteRow(long index) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCaptionElement/*'/>
public partial class HTMLTableCaptionElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCaptionElement/*'/>
	public HTMLTableCaptionElement() { }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableColElement/*'/>
public partial class HTMLTableColElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableColElement/*'/>
	public HTMLTableColElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableColElementSpan/*'/>
	public ulong Span { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableSectionElement/*'/>
public partial class HTMLTableSectionElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableSectionElement/*'/>
	public HTMLTableSectionElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableSectionElementRows/*'/>
	public HTMLCollection Rows { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableSectionElementInsertRow/*'/>
	public HTMLTableRowElement InsertRow(long index) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableSectionElementDeleteRow/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ DeleteRow(long index) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableRowElement/*'/>
public partial class HTMLTableRowElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableRowElement/*'/>
	public HTMLTableRowElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableRowElementRowIndex/*'/>
	public long RowIndex { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableRowElementSectionRowIndex/*'/>
	public long SectionRowIndex { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableRowElementCells/*'/>
	public HTMLCollection Cells { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableRowElementInsertCell/*'/>
	public HTMLTableCellElement InsertCell(long index) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableRowElementDeleteCell/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ DeleteCell(long index) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCellElement/*'/>
public partial class HTMLTableCellElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCellElement/*'/>
	public HTMLTableCellElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCellElementColSpan/*'/>
	public ulong ColSpan { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCellElementRowSpan/*'/>
	public ulong RowSpan { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCellElementHeaders/*'/>
	public string Headers { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCellElementCellIndex/*'/>
	public long CellIndex { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCellElementScope/*'/>
	public string Scope { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCellElementAbbr/*'/>
	public string Abbr { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElement/*'/>
public partial class HTMLFormElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElement/*'/>
	public HTMLFormElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElementAcceptCharset/*'/>
	public string AcceptCharset { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElementAction/*'/>
	public string Action { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElementAutocomplete/*'/>
	public string Autocomplete { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElementEnctype/*'/>
	public string Enctype { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElementEncoding/*'/>
	public string Encoding { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElementMethod/*'/>
	public string Method { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElementName/*'/>
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElementNoValidate/*'/>
	public bool NoValidate { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElementTarget/*'/>
	public string Target { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElementRel/*'/>
	public string Rel { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElementRelList/*'/>
	public DOMTokenList RelList { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElementElements/*'/>
	public HTMLFormControlsCollection Elements { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElementLength/*'/>
	public ulong Length { get; }
	
	
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElementSubmit/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Submit() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElementRequestSubmit/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ RequestSubmit(HTMLElement? submitter) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElementReset/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Reset() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElementCheckValidity/*'/>
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFormElementReportValidity/*'/>
	public bool ReportValidity() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLabelElement/*'/>
public partial class HTMLLabelElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLLabelElement/*'/>
	public HTMLLabelElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLabelElementForm/*'/>
	public HTMLFormElement? Form { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLabelElementHtmlFor/*'/>
	public string HtmlFor { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLabelElementControl/*'/>
	public HTMLElement? Control { get; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElement/*'/>
public partial class HTMLInputElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElement/*'/>
	public HTMLInputElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementAccept/*'/>
	public string Accept { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementAlt/*'/>
	public string Alt { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementAutocomplete/*'/>
	public string Autocomplete { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementDefaultChecked/*'/>
	public bool DefaultChecked { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementChecked/*'/>
	public bool Checked { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementDirName/*'/>
	public string DirName { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementDisabled/*'/>
	public bool Disabled { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementForm/*'/>
	public HTMLFormElement? Form { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementFiles/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*FileList*/? Files { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementFormAction/*'/>
	public string FormAction { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementFormEnctype/*'/>
	public string FormEnctype { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementFormMethod/*'/>
	public string FormMethod { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementFormNoValidate/*'/>
	public bool FormNoValidate { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementFormTarget/*'/>
	public string FormTarget { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementHeight/*'/>
	public ulong Height { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementIndeterminate/*'/>
	public bool Indeterminate { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementList/*'/>
	public HTMLElement? List { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementMax/*'/>
	public string Max { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementMaxLength/*'/>
	public long MaxLength { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementMin/*'/>
	public string Min { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementMinLength/*'/>
	public long MinLength { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementMultiple/*'/>
	public bool Multiple { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementName/*'/>
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementPattern/*'/>
	public string Pattern { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementPlaceholder/*'/>
	public string Placeholder { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementReadOnly/*'/>
	public bool ReadOnly { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementRequired/*'/>
	public bool Required { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementSize/*'/>
	public ulong Size { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementSrc/*'/>
	public string Src { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementStep/*'/>
	public string Step { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementType/*'/>
	public string Type { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementDefaultValue/*'/>
	public string DefaultValue { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementValue/*'/>
	public string Value { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementValueAsDate/*'/>
	public object? ValueAsDate { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementValueAsNumber/*'/>
	public double ValueAsNumber { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementWidth/*'/>
	public ulong Width { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementStepUp/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ StepUp(long n) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementStepDown/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ StepDown(long n) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementWillValidate/*'/>
	public bool WillValidate { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementValidity/*'/>
	public ValidityState Validity { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementValidationMessage/*'/>
	public string ValidationMessage { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementCheckValidity/*'/>
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementReportValidity/*'/>
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementSetCustomValidity/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetCustomValidity(string error) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementLabels/*'/>
	public NodeList? Labels { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementSelect/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Select() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementSelectionStart/*'/>
	public ulong? SelectionStart { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementSelectionEnd/*'/>
	public ulong? SelectionEnd { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementSelectionDirection/*'/>
	public string? SelectionDirection { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementSetRangeText/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetRangeText(string replacement) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementSetRangeText/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetRangeText(string replacement, ulong start, ulong end, SelectionMode selectionMode) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementSetSelectionRange/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetSelectionRange(ulong start, ulong end, string direction) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementShowPicker/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ShowPicker() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElement/*'/>
public partial class HTMLButtonElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElement/*'/>
	public HTMLButtonElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElementDisabled/*'/>
	public bool Disabled { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElementForm/*'/>
	public HTMLFormElement? Form { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElementFormAction/*'/>
	public string FormAction { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElementFormEnctype/*'/>
	public string FormEnctype { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElementFormMethod/*'/>
	public string FormMethod { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElementFormNoValidate/*'/>
	public bool FormNoValidate { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElementFormTarget/*'/>
	public string FormTarget { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElementName/*'/>
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElementType/*'/>
	public string Type { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElementValue/*'/>
	public string Value { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElementWillValidate/*'/>
	public bool WillValidate { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElementValidity/*'/>
	public ValidityState Validity { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElementValidationMessage/*'/>
	public string ValidationMessage { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElementCheckValidity/*'/>
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElementReportValidity/*'/>
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElementSetCustomValidity/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetCustomValidity(string error) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLButtonElementLabels/*'/>
	public NodeList Labels { get; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElement/*'/>
public partial class HTMLSelectElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElement/*'/>
	public HTMLSelectElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementAutocomplete/*'/>
	public string Autocomplete { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementDisabled/*'/>
	public bool Disabled { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementForm/*'/>
	public HTMLFormElement? Form { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementMultiple/*'/>
	public bool Multiple { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementName/*'/>
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementRequired/*'/>
	public bool Required { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementSize/*'/>
	public ulong Size { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementType/*'/>
	public string Type { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementOptions/*'/>
	public HTMLOptionsCollection Options { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementLength/*'/>
	public ulong Length { get; set; }
	
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementNamedItem/*'/>
	public HTMLOptionElement? NamedItem(string name) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementAdd/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Add(Union24 element, Union25? before) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementRemove/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Remove() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementRemove/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Remove(long index) { throw new System.NotImplementedException(); }
	
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementSelectedOptions/*'/>
	public HTMLCollection SelectedOptions { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementSelectedIndex/*'/>
	public long SelectedIndex { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementValue/*'/>
	public string Value { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementWillValidate/*'/>
	public bool WillValidate { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementValidity/*'/>
	public ValidityState Validity { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementValidationMessage/*'/>
	public string ValidationMessage { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementCheckValidity/*'/>
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementReportValidity/*'/>
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementSetCustomValidity/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetCustomValidity(string error) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSelectElementLabels/*'/>
	public NodeList Labels { get; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLDataListElement/*'/>
public partial class HTMLDataListElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLDataListElement/*'/>
	public HTMLDataListElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLDataListElementOptions/*'/>
	public HTMLCollection Options { get; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptGroupElement/*'/>
public partial class HTMLOptGroupElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptGroupElement/*'/>
	public HTMLOptGroupElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptGroupElementDisabled/*'/>
	public bool Disabled { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptGroupElementLabel/*'/>
	public string Label { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptionElement/*'/>
public partial class HTMLOptionElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptionElement/*'/>
	public HTMLOptionElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptionElementDisabled/*'/>
	public bool Disabled { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptionElementForm/*'/>
	public HTMLFormElement? Form { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptionElementLabel/*'/>
	public string Label { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptionElementDefaultSelected/*'/>
	public bool DefaultSelected { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptionElementSelected/*'/>
	public bool Selected { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptionElementValue/*'/>
	public string Value { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptionElementText/*'/>
	public string Text { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOptionElementIndex/*'/>
	public long Index { get; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElement/*'/>
public partial class HTMLTextAreaElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElement/*'/>
	public HTMLTextAreaElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementAutocomplete/*'/>
	public string Autocomplete { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementCols/*'/>
	public ulong Cols { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementDirName/*'/>
	public string DirName { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementDisabled/*'/>
	public bool Disabled { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementForm/*'/>
	public HTMLFormElement? Form { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementMaxLength/*'/>
	public long MaxLength { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementMinLength/*'/>
	public long MinLength { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementName/*'/>
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementPlaceholder/*'/>
	public string Placeholder { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementReadOnly/*'/>
	public bool ReadOnly { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementRequired/*'/>
	public bool Required { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementRows/*'/>
	public ulong Rows { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementWrap/*'/>
	public string Wrap { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementType/*'/>
	public string Type { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementDefaultValue/*'/>
	public string DefaultValue { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementValue/*'/>
	public string Value { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementTextLength/*'/>
	public ulong TextLength { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementWillValidate/*'/>
	public bool WillValidate { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementValidity/*'/>
	public ValidityState Validity { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementValidationMessage/*'/>
	public string ValidationMessage { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementCheckValidity/*'/>
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementReportValidity/*'/>
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementSetCustomValidity/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetCustomValidity(string error) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementLabels/*'/>
	public NodeList Labels { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementSelect/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Select() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementSelectionStart/*'/>
	public ulong SelectionStart { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementSelectionEnd/*'/>
	public ulong SelectionEnd { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementSelectionDirection/*'/>
	public string SelectionDirection { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementSetRangeText/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetRangeText(string replacement) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementSetRangeText/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetRangeText(string replacement, ulong start, ulong end, SelectionMode selectionMode) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTextAreaElementSetSelectionRange/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetSelectionRange(ulong start, ulong end, string direction) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOutputElement/*'/>
public partial class HTMLOutputElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLOutputElement/*'/>
	public HTMLOutputElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOutputElementHtmlFor/*'/>
	public DOMTokenList HtmlFor { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOutputElementForm/*'/>
	public HTMLFormElement? Form { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOutputElementName/*'/>
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOutputElementType/*'/>
	public string Type { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOutputElementDefaultValue/*'/>
	public string DefaultValue { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOutputElementValue/*'/>
	public string Value { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOutputElementWillValidate/*'/>
	public bool WillValidate { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOutputElementValidity/*'/>
	public ValidityState Validity { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOutputElementValidationMessage/*'/>
	public string ValidationMessage { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOutputElementCheckValidity/*'/>
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOutputElementReportValidity/*'/>
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOutputElementSetCustomValidity/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetCustomValidity(string error) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLOutputElementLabels/*'/>
	public NodeList Labels { get; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLProgressElement/*'/>
public partial class HTMLProgressElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLProgressElement/*'/>
	public HTMLProgressElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLProgressElementValue/*'/>
	public double Value { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLProgressElementMax/*'/>
	public double Max { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLProgressElementPosition/*'/>
	public double Position { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLProgressElementLabels/*'/>
	public NodeList Labels { get; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMeterElement/*'/>
public partial class HTMLMeterElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLMeterElement/*'/>
	public HTMLMeterElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMeterElementValue/*'/>
	public double Value { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMeterElementMin/*'/>
	public double Min { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMeterElementMax/*'/>
	public double Max { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMeterElementLow/*'/>
	public double Low { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMeterElementHigh/*'/>
	public double High { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMeterElementOptimum/*'/>
	public double Optimum { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMeterElementLabels/*'/>
	public NodeList Labels { get; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFieldSetElement/*'/>
public partial class HTMLFieldSetElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLFieldSetElement/*'/>
	public HTMLFieldSetElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFieldSetElementDisabled/*'/>
	public bool Disabled { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFieldSetElementForm/*'/>
	public HTMLFormElement? Form { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFieldSetElementName/*'/>
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFieldSetElementType/*'/>
	public string Type { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFieldSetElementElements/*'/>
	public HTMLCollection Elements { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFieldSetElementWillValidate/*'/>
	public bool WillValidate { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFieldSetElementValidity/*'/>
	public ValidityState Validity { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFieldSetElementValidationMessage/*'/>
	public string ValidationMessage { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFieldSetElementCheckValidity/*'/>
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFieldSetElementReportValidity/*'/>
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFieldSetElementSetCustomValidity/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetCustomValidity(string error) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLegendElement/*'/>
public partial class HTMLLegendElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLLegendElement/*'/>
	public HTMLLegendElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLLegendElementForm/*'/>
	public HTMLFormElement? Form { get; }
}

///<include file='Utils/Docs.generated.xml' path='docs/SelectionMode/*'/>
public enum SelectionMode
{
	Select,
	Start,
	End,
	Preserve,
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ValidityState/*'/>
public partial class ValidityState
{
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateValueMissing/*'/>
	public bool ValueMissing { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateTypeMismatch/*'/>
	public bool TypeMismatch { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStatePatternMismatch/*'/>
	public bool PatternMismatch { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateTooLong/*'/>
	public bool TooLong { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateTooShort/*'/>
	public bool TooShort { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateRangeUnderflow/*'/>
	public bool RangeUnderflow { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateRangeOverflow/*'/>
	public bool RangeOverflow { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateStepMismatch/*'/>
	public bool StepMismatch { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateBadInput/*'/>
	public bool BadInput { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateCustomError/*'/>
	public bool CustomError { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateValid/*'/>
	public bool Valid { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/SubmitEvent/*'/>
public partial class SubmitEvent : Event
{
	///<include file='Utils/Docs.generated.xml' path='docs/SubmitEvent/*'/>
	public SubmitEvent(string type, SubmitEventInit eventInitDict) { }
	///<include file='Utils/Docs.generated.xml' path='docs/SubmitEventSubmitter/*'/>
	public HTMLElement? Submitter { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/SubmitEventInit/*'/>
public partial class SubmitEventInit : EventInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/SubmitEventInitSubmitter/*'/>
	public HTMLElement? Submitter;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/FormDataEvent/*'/>
public partial class FormDataEvent : Event
{
	///<include file='Utils/Docs.generated.xml' path='docs/FormDataEvent/*'/>
	public FormDataEvent(string type, FormDataEventInit eventInitDict) { }
	///<include file='Utils/Docs.generated.xml' path='docs/FormDataEventFormData/*'/>
	public FormData FormData { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/FormDataEventInit/*'/>
public partial class FormDataEventInit : EventInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/FormDataEventInitFormData/*'/>
	public required FormData FormData;
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLDetailsElement/*'/>
public partial class HTMLDetailsElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLDetailsElement/*'/>
	public HTMLDetailsElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLDetailsElementOpen/*'/>
	public bool Open { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLDialogElement/*'/>
public partial class HTMLDialogElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLDialogElement/*'/>
	public HTMLDialogElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLDialogElementOpen/*'/>
	public bool Open { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLDialogElementReturnValue/*'/>
	public string ReturnValue { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLDialogElementShow/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Show() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLDialogElementShowModal/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ShowModal() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLDialogElementClose/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Close(string returnValue) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLScriptElement/*'/>
public partial class HTMLScriptElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLScriptElement/*'/>
	public HTMLScriptElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLScriptElementSrc/*'/>
	public string Src { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLScriptElementType/*'/>
	public string Type { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLScriptElementNoModule/*'/>
	public bool NoModule { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLScriptElementAsync/*'/>
	public bool Async { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLScriptElementDefer/*'/>
	public bool Defer { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLScriptElementCrossOrigin/*'/>
	public string? CrossOrigin { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLScriptElementText/*'/>
	public string Text { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLScriptElementIntegrity/*'/>
	public string Integrity { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLScriptElementReferrerPolicy/*'/>
	public string ReferrerPolicy { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLScriptElementBlocking/*'/>
	public DOMTokenList Blocking { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLScriptElementSupports/*'/>
	public static bool Supports(string type) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTemplateElement/*'/>
public partial class HTMLTemplateElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTemplateElement/*'/>
	public HTMLTemplateElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLTemplateElementContent/*'/>
	public DocumentFragment Content { get; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSlotElement/*'/>
public partial class HTMLSlotElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLSlotElement/*'/>
	public HTMLSlotElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSlotElementName/*'/>
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSlotElementAssignedNodes/*'/>
	public List<Node> AssignedNodes(AssignedNodesOptions options) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSlotElementAssignedElements/*'/>
	public List<Element> AssignedElements(AssignedNodesOptions options) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLSlotElementAssign/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Assign(params Union26[] nodes) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/AssignedNodesOptions/*'/>
public partial class AssignedNodesOptions
{
	///<include file='Utils/Docs.generated.xml' path='docs/AssignedNodesOptionsFlatten/*'/>
	public bool Flatten;
}


[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLCanvasElement/*'/>
public partial class HTMLCanvasElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLCanvasElement/*'/>
	public HTMLCanvasElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLCanvasElementWidth/*'/>
	public ulong Width { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLCanvasElementHeight/*'/>
	public ulong Height { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLCanvasElementGetContext/*'/>
	public RenderingContext? GetContext(string contextId, dynamic options) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLCanvasElementToDataURL/*'/>
	public string ToDataURL(string type, dynamic quality) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLCanvasElementToBlob/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ToBlob(BlobCallback callback, string type, dynamic quality) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLCanvasElementTransferControlToOffscreen/*'/>
	public OffscreenCanvas TransferControlToOffscreen() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/BlobCallback/*'/>
public struct BlobCallback
{
}



///<include file='Utils/Docs.generated.xml' path='docs/PredefinedColorSpace/*'/>
public enum PredefinedColorSpace
{
	Srgb,
	DisplayP3,
}

///<include file='Utils/Docs.generated.xml' path='docs/CanvasFillRule/*'/>
public enum CanvasFillRule
{
	Nonzero,
	Evenodd,
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasRenderingContext2DSettings/*'/>
public partial class CanvasRenderingContext2DSettings
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasRenderingContext2DSettingsAlpha/*'/>
	public bool Alpha;
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasRenderingContext2DSettingsDesynchronized/*'/>
	public bool Desynchronized;
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasRenderingContext2DSettingsColorSpace/*'/>
	public PredefinedColorSpace ColorSpace;
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasRenderingContext2DSettingsWillReadFrequently/*'/>
	public bool WillReadFrequently;
}

///<include file='Utils/Docs.generated.xml' path='docs/ImageSmoothingQuality/*'/>
public enum ImageSmoothingQuality
{
	Low,
	Medium,
	High,
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasRenderingContext2D/*'/>
public partial class CanvasRenderingContext2D
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasRenderingContext2DCanvas/*'/>
	public HTMLCanvasElement Canvas { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasRenderingContext2DGetContextAttributes/*'/>
	public CanvasRenderingContext2DSettings GetContextAttributes() { throw new System.NotImplementedException(); }
}

















[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasState/*'/>
public partial interface CanvasState
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasStateSave/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Save() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasStateRestore/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Restore() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasStateReset/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Reset() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasStateIsContextLost/*'/>
	public bool IsContextLost() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasTransform/*'/>
public partial interface CanvasTransform
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTransformScale/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Scale(double x, double y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTransformRotate/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Rotate(double angle) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTransformTranslate/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Translate(double x, double y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTransformTransform/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Transform(double a, double b, double c, double d, double e, double f) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTransformGetTransform/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*DOMMatrix*/ GetTransform() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTransformSetTransform/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetTransform(double a, double b, double c, double d, double e, double f) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTransformSetTransform/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetTransform(CSharpToJavaScript.Utils.Unsupported /*DOMMatrix2DInit*/ transform) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTransformResetTransform/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ResetTransform() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasCompositing/*'/>
public partial interface CanvasCompositing
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasCompositingGlobalAlpha/*'/>
	public double GlobalAlpha { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasCompositingGlobalCompositeOperation/*'/>
	public string GlobalCompositeOperation { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasImageSmoothing/*'/>
public partial interface CanvasImageSmoothing
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasImageSmoothingImageSmoothingEnabled/*'/>
	public bool ImageSmoothingEnabled { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasImageSmoothingImageSmoothingQuality/*'/>
	public ImageSmoothingQuality ImageSmoothingQuality { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasFillStrokeStyles/*'/>
public partial interface CanvasFillStrokeStyles
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasFillStrokeStylesStrokeStyle/*'/>
	public Union30 StrokeStyle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasFillStrokeStylesFillStyle/*'/>
	public Union31 FillStyle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasFillStrokeStylesCreateLinearGradient/*'/>
	public CanvasGradient CreateLinearGradient(double x0, double y0, double x1, double y1) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasFillStrokeStylesCreateRadialGradient/*'/>
	public CanvasGradient CreateRadialGradient(double x0, double y0, double r0, double x1, double y1, double r1) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasFillStrokeStylesCreateConicGradient/*'/>
	public CanvasGradient CreateConicGradient(double startAngle, double x, double y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasFillStrokeStylesCreatePattern/*'/>
	public CanvasPattern? CreatePattern(CanvasImageSource image, string repetition) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasShadowStyles/*'/>
public partial interface CanvasShadowStyles
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasShadowStylesShadowOffsetX/*'/>
	public double ShadowOffsetX { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasShadowStylesShadowOffsetY/*'/>
	public double ShadowOffsetY { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasShadowStylesShadowBlur/*'/>
	public double ShadowBlur { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasShadowStylesShadowColor/*'/>
	public string ShadowColor { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasFilters/*'/>
public partial interface CanvasFilters
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasFiltersFilter/*'/>
	public Union32 Filter { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasFilter/*'/>
public partial class CanvasFilter
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasFilter/*'/>
	public CanvasFilter(Union33 filters) { }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasRect/*'/>
public partial interface CanvasRect
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasRectClearRect/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ClearRect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasRectFillRect/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ FillRect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasRectStrokeRect/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ StrokeRect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasDrawPath/*'/>
public partial interface CanvasDrawPath
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasDrawPathBeginPath/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ BeginPath() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasDrawPathFill/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Fill(CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasDrawPathFill/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Fill(Path2D path, CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasDrawPathStroke/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Stroke() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasDrawPathStroke/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Stroke(Path2D path) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasDrawPathClip/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Clip(CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasDrawPathClip/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Clip(Path2D path, CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasDrawPathIsPointInPath/*'/>
	public bool IsPointInPath(double x, double y, CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasDrawPathIsPointInPath/*'/>
	public bool IsPointInPath(Path2D path, double x, double y, CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasDrawPathIsPointInStroke/*'/>
	public bool IsPointInStroke(double x, double y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasDrawPathIsPointInStroke/*'/>
	public bool IsPointInStroke(Path2D path, double x, double y) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasUserInterface/*'/>
public partial interface CanvasUserInterface
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasUserInterfaceDrawFocusIfNeeded/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ DrawFocusIfNeeded(Element element) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasUserInterfaceDrawFocusIfNeeded/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ DrawFocusIfNeeded(Path2D path, Element element) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasUserInterfaceScrollPathIntoView/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ScrollPathIntoView() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasUserInterfaceScrollPathIntoView/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ScrollPathIntoView(Path2D path) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasText/*'/>
public partial interface CanvasText
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTextFillText/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ FillText(string text, double x, double y, double maxWidth) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTextStrokeText/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ StrokeText(string text, double x, double y, double maxWidth) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTextMeasureText/*'/>
	public TextMetrics MeasureText(string text) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasDrawImage/*'/>
public partial interface CanvasDrawImage
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasDrawImageDrawImage/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ DrawImage(CanvasImageSource image, double dx, double dy) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasDrawImageDrawImage/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ DrawImage(CanvasImageSource image, double dx, double dy, double dw, double dh) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasDrawImageDrawImage/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ DrawImage(CanvasImageSource image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasImageData/*'/>
public partial interface CanvasImageData
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasImageDataCreateImageData/*'/>
	public ImageData CreateImageData(long sw, long sh, ImageDataSettings settings) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasImageDataCreateImageData/*'/>
	public ImageData CreateImageData(ImageData imagedata) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasImageDataGetImageData/*'/>
	public ImageData GetImageData(long sx, long sy, long sw, long sh, ImageDataSettings settings) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasImageDataPutImageData/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ PutImageData(ImageData imagedata, long dx, long dy) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasImageDataPutImageData/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ PutImageData(ImageData imagedata, long dx, long dy, long dirtyX, long dirtyY, long dirtyWidth, long dirtyHeight) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs.generated.xml' path='docs/CanvasLineCap/*'/>
public enum CanvasLineCap
{
	Butt,
	Round,
	Square,
}

///<include file='Utils/Docs.generated.xml' path='docs/CanvasLineJoin/*'/>
public enum CanvasLineJoin
{
	Round,
	Bevel,
	Miter,
}

///<include file='Utils/Docs.generated.xml' path='docs/CanvasTextAlign/*'/>
public enum CanvasTextAlign
{
	Start,
	End,
	Left,
	Right,
	Center,
}

///<include file='Utils/Docs.generated.xml' path='docs/CanvasTextBaseline/*'/>
public enum CanvasTextBaseline
{
	Top,
	Hanging,
	Middle,
	Alphabetic,
	Ideographic,
	Bottom,
}

///<include file='Utils/Docs.generated.xml' path='docs/CanvasDirection/*'/>
public enum CanvasDirection
{
	Ltr,
	Rtl,
	Inherit,
}

///<include file='Utils/Docs.generated.xml' path='docs/CanvasFontKerning/*'/>
public enum CanvasFontKerning
{
	Auto,
	Normal,
	None,
}

///<include file='Utils/Docs.generated.xml' path='docs/CanvasFontStretch/*'/>
public enum CanvasFontStretch
{
	UltraCondensed,
	ExtraCondensed,
	Condensed,
	SemiCondensed,
	Normal,
	SemiExpanded,
	Expanded,
	ExtraExpanded,
	UltraExpanded,
}

///<include file='Utils/Docs.generated.xml' path='docs/CanvasFontVariantCaps/*'/>
public enum CanvasFontVariantCaps
{
	Normal,
	SmallCaps,
	AllSmallCaps,
	PetiteCaps,
	AllPetiteCaps,
	Unicase,
	TitlingCaps,
}

///<include file='Utils/Docs.generated.xml' path='docs/CanvasTextRendering/*'/>
public enum CanvasTextRendering
{
	Auto,
	OptimizeSpeed,
	OptimizeLegibility,
	GeometricPrecision,
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasPathDrawingStyles/*'/>
public partial interface CanvasPathDrawingStyles
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasPathDrawingStylesLineWidth/*'/>
	public double LineWidth { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasPathDrawingStylesLineCap/*'/>
	public CanvasLineCap LineCap { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasPathDrawingStylesLineJoin/*'/>
	public CanvasLineJoin LineJoin { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasPathDrawingStylesMiterLimit/*'/>
	public double MiterLimit { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasPathDrawingStylesSetLineDash/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetLineDash(List<double> segments) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasPathDrawingStylesGetLineDash/*'/>
	public List<double> GetLineDash() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasPathDrawingStylesLineDashOffset/*'/>
	public double LineDashOffset { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasTextDrawingStyles/*'/>
public partial interface CanvasTextDrawingStyles
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTextDrawingStylesFont/*'/>
	public string Font { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTextDrawingStylesTextAlign/*'/>
	public CanvasTextAlign TextAlign { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTextDrawingStylesTextBaseline/*'/>
	public CanvasTextBaseline TextBaseline { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTextDrawingStylesDirection/*'/>
	public CanvasDirection Direction { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTextDrawingStylesLetterSpacing/*'/>
	public string LetterSpacing { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTextDrawingStylesFontKerning/*'/>
	public CanvasFontKerning FontKerning { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTextDrawingStylesFontStretch/*'/>
	public CanvasFontStretch FontStretch { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTextDrawingStylesFontVariantCaps/*'/>
	public CanvasFontVariantCaps FontVariantCaps { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTextDrawingStylesTextRendering/*'/>
	public CanvasTextRendering TextRendering { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasTextDrawingStylesWordSpacing/*'/>
	public string WordSpacing { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasPath/*'/>
public partial interface CanvasPath
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasPathClosePath/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ClosePath() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasPathMoveTo/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ MoveTo(double x, double y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasPathLineTo/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ LineTo(double x, double y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasPathQuadraticCurveTo/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ QuadraticCurveTo(double cpx, double cpy, double x, double y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasPathBezierCurveTo/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ BezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasPathArcTo/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ArcTo(double x1, double y1, double x2, double y2, double radius) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasPathRect/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Rect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasPathRoundRect/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ RoundRect(double x, double y, double w, double h, Union34 radii) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasPathArc/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Arc(double x, double y, double radius, double startAngle, double endAngle, bool counterclockwise) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasPathEllipse/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Ellipse(double x, double y, double radiusX, double radiusY, double rotation, double startAngle, double endAngle, bool counterclockwise) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasGradient/*'/>
public partial class CanvasGradient
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasGradientAddColorStop/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ AddColorStop(double offset, string color) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CanvasPattern/*'/>
public partial class CanvasPattern
{
	///<include file='Utils/Docs.generated.xml' path='docs/CanvasPatternSetTransform/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetTransform(CSharpToJavaScript.Utils.Unsupported /*DOMMatrix2DInit*/ transform) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/TextMetrics/*'/>
public partial class TextMetrics
{
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextMetricsWidth/*'/>
	public double Width { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextMetricsActualBoundingBoxLeft/*'/>
	public double ActualBoundingBoxLeft { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextMetricsActualBoundingBoxRight/*'/>
	public double ActualBoundingBoxRight { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextMetricsFontBoundingBoxAscent/*'/>
	public double FontBoundingBoxAscent { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextMetricsFontBoundingBoxDescent/*'/>
	public double FontBoundingBoxDescent { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextMetricsActualBoundingBoxAscent/*'/>
	public double ActualBoundingBoxAscent { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextMetricsActualBoundingBoxDescent/*'/>
	public double ActualBoundingBoxDescent { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextMetricsEmHeightAscent/*'/>
	public double EmHeightAscent { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextMetricsEmHeightDescent/*'/>
	public double EmHeightDescent { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextMetricsHangingBaseline/*'/>
	public double HangingBaseline { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextMetricsAlphabeticBaseline/*'/>
	public double AlphabeticBaseline { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/TextMetricsIdeographicBaseline/*'/>
	public double IdeographicBaseline { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ImageDataSettings/*'/>
public partial class ImageDataSettings
{
	///<include file='Utils/Docs.generated.xml' path='docs/ImageDataSettingsColorSpace/*'/>
	public PredefinedColorSpace ColorSpace;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ImageData/*'/>
public partial class ImageData
{
	///<include file='Utils/Docs.generated.xml' path='docs/ImageData/*'/>
	public ImageData(ulong sw, ulong sh, ImageDataSettings settings) { }
	///<include file='Utils/Docs.generated.xml' path='docs/ImageData/*'/>
	public ImageData(CSharpToJavaScript.Utils.Unsupported /*Uint8ClampedArray*/ data, ulong sw, ulong sh, ImageDataSettings settings) { }
	///<include file='Utils/Docs.generated.xml' path='docs/ImageDataWidth/*'/>
	public ulong Width { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ImageDataHeight/*'/>
	public ulong Height { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ImageDataData/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*Uint8ClampedArray*/ Data { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ImageDataColorSpace/*'/>
	public PredefinedColorSpace ColorSpace { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Path2D/*'/>
public partial class Path2D
{
	///<include file='Utils/Docs.generated.xml' path='docs/Path2D/*'/>
	public Path2D(Union36 path) { }
	///<include file='Utils/Docs.generated.xml' path='docs/Path2DAddPath/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ AddPath(Path2D path, CSharpToJavaScript.Utils.Unsupported /*DOMMatrix2DInit*/ transform) { throw new System.NotImplementedException(); }
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ImageBitmapRenderingContext/*'/>
public partial class ImageBitmapRenderingContext
{
	///<include file='Utils/Docs.generated.xml' path='docs/ImageBitmapRenderingContextCanvas/*'/>
	public Union37 Canvas { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ImageBitmapRenderingContextTransferFromImageBitmap/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ TransferFromImageBitmap(ImageBitmap? bitmap) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ImageBitmapRenderingContextSettings/*'/>
public partial class ImageBitmapRenderingContextSettings
{
	///<include file='Utils/Docs.generated.xml' path='docs/ImageBitmapRenderingContextSettingsAlpha/*'/>
	public bool Alpha;
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ImageEncodeOptions/*'/>
public partial class ImageEncodeOptions
{
	///<include file='Utils/Docs.generated.xml' path='docs/ImageEncodeOptionsType/*'/>
	public string Type;
	///<include file='Utils/Docs.generated.xml' path='docs/ImageEncodeOptionsQuality/*'/>
	public double Quality;
}

///<include file='Utils/Docs.generated.xml' path='docs/OffscreenRenderingContextId/*'/>
public enum OffscreenRenderingContextId
{
	_2d,
	Bitmaprenderer,
	Webgl,
	Webgl2,
	Webgpu,
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/OffscreenCanvas/*'/>
public partial class OffscreenCanvas : EventTarget
{
	///<include file='Utils/Docs.generated.xml' path='docs/OffscreenCanvas/*'/>
	public OffscreenCanvas(ulong width, ulong height) { }
	///<include file='Utils/Docs.generated.xml' path='docs/OffscreenCanvasWidth/*'/>
	public ulong Width { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/OffscreenCanvasHeight/*'/>
	public ulong Height { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/OffscreenCanvasGetContext/*'/>
	public OffscreenRenderingContext? GetContext(OffscreenRenderingContextId contextId, dynamic options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/OffscreenCanvasTransferToImageBitmap/*'/>
	public ImageBitmap TransferToImageBitmap() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/OffscreenCanvasConvertToBlob/*'/>
	public Task<CSharpToJavaScript.Utils.Unsupported /*Blob*/> ConvertToBlob(ImageEncodeOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/OffscreenCanvasOncontextlost/*'/>
	public EventHandler Oncontextlost { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/OffscreenCanvasOncontextrestored/*'/>
	public EventHandler Oncontextrestored { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/OffscreenCanvasRenderingContext2D/*'/>
public partial class OffscreenCanvasRenderingContext2D
{
	///<include file='Utils/Docs.generated.xml' path='docs/OffscreenCanvasRenderingContext2DCommit/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Commit() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/OffscreenCanvasRenderingContext2DCanvas/*'/>
	public OffscreenCanvas Canvas { get; }
}
















[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CustomElementRegistry/*'/>
public partial class CustomElementRegistry
{
	///<include file='Utils/Docs.generated.xml' path='docs/CustomElementRegistryDefine/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Define(string name, CustomElementConstructor constructor, ElementDefinitionOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CustomElementRegistryGet/*'/>
	public Union39 Get(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CustomElementRegistryWhenDefined/*'/>
	public Task<CustomElementConstructor> WhenDefined(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/CustomElementRegistryUpgrade/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Upgrade(Node root) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/CustomElementConstructor/*'/>
public struct CustomElementConstructor
{
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ElementDefinitionOptions/*'/>
public partial class ElementDefinitionOptions
{
	///<include file='Utils/Docs.generated.xml' path='docs/ElementDefinitionOptionsExtends/*'/>
	public string Extends;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ElementInternals/*'/>
public partial class ElementInternals
{
	///<include file='Utils/Docs.generated.xml' path='docs/ElementInternalsShadowRoot/*'/>
	public ShadowRoot? ShadowRoot { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementInternalsSetFormValue/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetFormValue(Union40? value, Union41? state) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementInternalsForm/*'/>
	public HTMLFormElement? Form { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementInternalsSetValidity/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetValidity(ValidityStateFlags flags, string message, HTMLElement anchor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementInternalsWillValidate/*'/>
	public bool WillValidate { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementInternalsValidity/*'/>
	public ValidityState Validity { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementInternalsValidationMessage/*'/>
	public string ValidationMessage { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementInternalsCheckValidity/*'/>
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementInternalsReportValidity/*'/>
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementInternalsLabels/*'/>
	public NodeList Labels { get; }
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateFlags/*'/>
public partial class ValidityStateFlags
{
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateFlagsValueMissing/*'/>
	public bool ValueMissing;
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateFlagsTypeMismatch/*'/>
	public bool TypeMismatch;
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateFlagsPatternMismatch/*'/>
	public bool PatternMismatch;
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateFlagsTooLong/*'/>
	public bool TooLong;
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateFlagsTooShort/*'/>
	public bool TooShort;
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateFlagsRangeUnderflow/*'/>
	public bool RangeUnderflow;
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateFlagsRangeOverflow/*'/>
	public bool RangeOverflow;
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateFlagsStepMismatch/*'/>
	public bool StepMismatch;
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateFlagsBadInput/*'/>
	public bool BadInput;
	///<include file='Utils/Docs.generated.xml' path='docs/ValidityStateFlagsCustomError/*'/>
	public bool CustomError;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/FocusOptions/*'/>
public partial class FocusOptions
{
	///<include file='Utils/Docs.generated.xml' path='docs/FocusOptionsPreventScroll/*'/>
	public bool PreventScroll;
	///<include file='Utils/Docs.generated.xml' path='docs/FocusOptionsFocusVisible/*'/>
	public bool FocusVisible;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ElementContentEditable/*'/>
public partial interface ElementContentEditable
{
	///<include file='Utils/Docs.generated.xml' path='docs/ElementContentEditableContentEditable/*'/>
	public string ContentEditable { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementContentEditableEnterKeyHint/*'/>
	public string EnterKeyHint { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementContentEditableIsContentEditable/*'/>
	public bool IsContentEditable { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/ElementContentEditableInputMode/*'/>
	public string InputMode { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/DataTransfer/*'/>
public partial class DataTransfer
{
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransfer/*'/>
	public DataTransfer() { }
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransferDropEffect/*'/>
	public string DropEffect { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransferEffectAllowed/*'/>
	public string EffectAllowed { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransferItems/*'/>
	public DataTransferItemList Items { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransferSetDragImage/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetDragImage(Element image, long x, long y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransferTypes/*'/>
	public string[] Types { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransferGetData/*'/>
	public string GetData(string format) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransferSetData/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetData(string format, string data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransferClearData/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ClearData(string format) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransferFiles/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*FileList*/ Files { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/DataTransferItemList/*'/>
public partial class DataTransferItemList
{
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransferItemListLength/*'/>
	public ulong Length { get; }
	
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransferItemListAdd/*'/>
	public DataTransferItem? Add(string data, string type) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransferItemListAdd/*'/>
	public DataTransferItem? Add(CSharpToJavaScript.Utils.Unsupported /*File*/ data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransferItemListRemove/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Remove(ulong index) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransferItemListClear/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Clear() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/DataTransferItem/*'/>
public partial class DataTransferItem
{
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransferItemKind/*'/>
	public string Kind { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransferItemType/*'/>
	public string Type { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransferItemGetAsString/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ GetAsString(FunctionStringCallback? callback) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DataTransferItemGetAsFile/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*File*/? GetAsFile() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/FunctionStringCallback/*'/>
public struct FunctionStringCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/FunctionObjectCallback/*'/>
public struct FunctionObjectCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/DragEvent/*'/>
public partial class DragEvent
{
	///<include file='Utils/Docs.generated.xml' path='docs/DragEvent/*'/>
	public DragEvent(string type, DragEventInit eventInitDict) { }
	///<include file='Utils/Docs.generated.xml' path='docs/DragEventDataTransfer/*'/>
	public DataTransfer? DataTransfer { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/DragEventInit/*'/>
public partial class DragEventInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/DragEventInitDataTransfer/*'/>
	public DataTransfer? DataTransfer;
}

///<include file='Utils/Docs.generated.xml' path='docs/Window/*'/>
public partial class Window : EventTarget
{
	///<include file='Utils/Docs.generated.xml' path='docs/WindowWindow/*'/>
	public Window _window { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowSelf/*'/>
	public Window Self { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowDocument/*'/>
	public Document Document { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowName/*'/>
	public string Name { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowLocation/*'/>
	public Location Location { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowHistory/*'/>
	public History History { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowCustomElements/*'/>
	public CustomElementRegistry CustomElements { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowLocationbar/*'/>
	public BarProp Locationbar { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowMenubar/*'/>
	public BarProp Menubar { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowPersonalbar/*'/>
	public BarProp Personalbar { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowScrollbars/*'/>
	public BarProp Scrollbars { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowStatusbar/*'/>
	public BarProp Statusbar { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowToolbar/*'/>
	public BarProp Toolbar { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowStatus/*'/>
	public string Status { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowClose/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Close() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowClosed/*'/>
	public bool Closed { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowStop/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Stop() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowFocus/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Focus() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowBlur/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Blur() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowFrames/*'/>
	public Window Frames { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowLength/*'/>
	public ulong Length { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowTop/*'/>
	public Window? Top { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOpener/*'/>
	public dynamic Opener { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowParent/*'/>
	public Window? Parent { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowFrameElement/*'/>
	public Element? FrameElement { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOpen/*'/>
	public Window? Open(string url, string target, string features) { throw new System.NotImplementedException(); }
	
	///<include file='Utils/Docs.generated.xml' path='docs/WindowNavigator/*'/>
	public Navigator Navigator { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowClientInformation/*'/>
	public Navigator ClientInformation { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOriginAgentCluster/*'/>
	public bool OriginAgentCluster { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowAlert/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Alert() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowAlert/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Alert(string message) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowConfirm/*'/>
	public bool Confirm(string message) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowPrompt/*'/>
	public string? Prompt(string message, string default_) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowPrint/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Print() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowPostMessage/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ PostMessage(dynamic message, string targetOrigin, List<object> transfer) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowPostMessage/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ PostMessage(dynamic message, WindowPostMessageOptions options) { throw new System.NotImplementedException(); }
}



[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/WindowPostMessageOptions/*'/>
public partial class WindowPostMessageOptions : StructuredSerializeOptions
{
	///<include file='Utils/Docs.generated.xml' path='docs/WindowPostMessageOptionsTargetOrigin/*'/>
	public string TargetOrigin;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/BarProp/*'/>
public partial class BarProp
{
	///<include file='Utils/Docs.generated.xml' path='docs/BarPropVisible/*'/>
	public bool Visible { get; }
}

///<include file='Utils/Docs.generated.xml' path='docs/ScrollRestoration/*'/>
public enum ScrollRestoration
{
	Auto,
	Manual,
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/History/*'/>
public partial class History
{
	///<include file='Utils/Docs.generated.xml' path='docs/HistoryLength/*'/>
	public ulong Length { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/HistoryScrollRestoration/*'/>
	public ScrollRestoration ScrollRestoration { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HistoryState/*'/>
	public dynamic State { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/HistoryGo/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Go(long delta) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/HistoryBack/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Back() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/HistoryForward/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Forward() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/HistoryPushState/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ PushState(dynamic data, string unused, string? url) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/HistoryReplaceState/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ReplaceState(dynamic data, string unused, string? url) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Location/*'/>
public partial class Location
{
	///<include file='Utils/Docs.generated.xml' path='docs/LocationHref/*'/>
	public string Href { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/LocationOrigin/*'/>
	public string Origin { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/LocationProtocol/*'/>
	public string Protocol { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/LocationHost/*'/>
	public string Host { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/LocationHostname/*'/>
	public string Hostname { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/LocationPort/*'/>
	public string Port { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/LocationPathname/*'/>
	public string Pathname { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/LocationSearch/*'/>
	public string Search { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/LocationHash/*'/>
	public string Hash { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/LocationAssign/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Assign(string url) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/LocationReplace/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Replace(string url) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/LocationReload/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Reload() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/LocationAncestorOrigins/*'/>
	public string AncestorOrigins { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/PopStateEvent/*'/>
public partial class PopStateEvent : Event
{
	///<include file='Utils/Docs.generated.xml' path='docs/PopStateEvent/*'/>
	public PopStateEvent(string type, PopStateEventInit eventInitDict) { }
	///<include file='Utils/Docs.generated.xml' path='docs/PopStateEventState/*'/>
	public dynamic State { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/PopStateEventInit/*'/>
public partial class PopStateEventInit : EventInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/PopStateEventInitState/*'/>
	public dynamic State;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HashChangeEvent/*'/>
public partial class HashChangeEvent : Event
{
	///<include file='Utils/Docs.generated.xml' path='docs/HashChangeEvent/*'/>
	public HashChangeEvent(string type, HashChangeEventInit eventInitDict) { }
	///<include file='Utils/Docs.generated.xml' path='docs/HashChangeEventOldURL/*'/>
	public string OldURL { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/HashChangeEventNewURL/*'/>
	public string NewURL { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HashChangeEventInit/*'/>
public partial class HashChangeEventInit : EventInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/HashChangeEventInitOldURL/*'/>
	public string OldURL;
	///<include file='Utils/Docs.generated.xml' path='docs/HashChangeEventInitNewURL/*'/>
	public string NewURL;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/PageTransitionEvent/*'/>
public partial class PageTransitionEvent : Event
{
	///<include file='Utils/Docs.generated.xml' path='docs/PageTransitionEvent/*'/>
	public PageTransitionEvent(string type, PageTransitionEventInit eventInitDict) { }
	///<include file='Utils/Docs.generated.xml' path='docs/PageTransitionEventPersisted/*'/>
	public bool Persisted { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/PageTransitionEventInit/*'/>
public partial class PageTransitionEventInit : EventInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/PageTransitionEventInitPersisted/*'/>
	public bool Persisted;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/BeforeUnloadEvent/*'/>
public partial class BeforeUnloadEvent : Event
{
	///<include file='Utils/Docs.generated.xml' path='docs/BeforeUnloadEventReturnValue/*'/>
	public string ReturnValue { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ErrorEvent/*'/>
public partial class ErrorEvent : Event
{
	///<include file='Utils/Docs.generated.xml' path='docs/ErrorEvent/*'/>
	public ErrorEvent(string type, ErrorEventInit eventInitDict) { }
	///<include file='Utils/Docs.generated.xml' path='docs/ErrorEventMessage/*'/>
	public string Message { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ErrorEventFilename/*'/>
	public string Filename { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ErrorEventLineno/*'/>
	public ulong Lineno { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ErrorEventColno/*'/>
	public ulong Colno { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ErrorEventError/*'/>
	public dynamic Error { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ErrorEventInit/*'/>
public partial class ErrorEventInit : EventInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/ErrorEventInitMessage/*'/>
	public string Message;
	///<include file='Utils/Docs.generated.xml' path='docs/ErrorEventInitFilename/*'/>
	public string Filename;
	///<include file='Utils/Docs.generated.xml' path='docs/ErrorEventInitLineno/*'/>
	public ulong Lineno;
	///<include file='Utils/Docs.generated.xml' path='docs/ErrorEventInitColno/*'/>
	public ulong Colno;
	///<include file='Utils/Docs.generated.xml' path='docs/ErrorEventInitError/*'/>
	public dynamic Error;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/PromiseRejectionEvent/*'/>
public partial class PromiseRejectionEvent : Event
{
	///<include file='Utils/Docs.generated.xml' path='docs/PromiseRejectionEvent/*'/>
	public PromiseRejectionEvent(string type, PromiseRejectionEventInit eventInitDict) { }
	///<include file='Utils/Docs.generated.xml' path='docs/PromiseRejectionEventPromise/*'/>
	public Task<dynamic> Promise { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/PromiseRejectionEventReason/*'/>
	public dynamic Reason { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/PromiseRejectionEventInit/*'/>
public partial class PromiseRejectionEventInit : EventInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/PromiseRejectionEventInitPromise/*'/>
	public required Task<dynamic> Promise;
	///<include file='Utils/Docs.generated.xml' path='docs/PromiseRejectionEventInitReason/*'/>
	public dynamic Reason;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/EventHandlerNonNull/*'/>
public struct EventHandlerNonNull
{
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/OnErrorEventHandlerNonNull/*'/>
public struct OnErrorEventHandlerNonNull
{
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/OnBeforeUnloadEventHandlerNonNull/*'/>
public struct OnBeforeUnloadEventHandlerNonNull
{
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlers/*'/>
public partial interface GlobalEventHandlers
{
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnabort/*'/>
	public EventHandler Onabort { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnauxclick/*'/>
	public EventHandler Onauxclick { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnbeforeinput/*'/>
	public EventHandler Onbeforeinput { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnbeforematch/*'/>
	public EventHandler Onbeforematch { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnblur/*'/>
	public EventHandler Onblur { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOncancel/*'/>
	public EventHandler Oncancel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOncanplay/*'/>
	public EventHandler Oncanplay { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOncanplaythrough/*'/>
	public EventHandler Oncanplaythrough { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnchange/*'/>
	public EventHandler Onchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnclick/*'/>
	public EventHandler Onclick { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnclose/*'/>
	public EventHandler Onclose { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOncontextlost/*'/>
	public EventHandler Oncontextlost { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOncontextmenu/*'/>
	public EventHandler Oncontextmenu { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOncontextrestored/*'/>
	public EventHandler Oncontextrestored { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOncuechange/*'/>
	public EventHandler Oncuechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOndblclick/*'/>
	public EventHandler Ondblclick { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOndrag/*'/>
	public EventHandler Ondrag { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOndragend/*'/>
	public EventHandler Ondragend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOndragenter/*'/>
	public EventHandler Ondragenter { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOndragleave/*'/>
	public EventHandler Ondragleave { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOndragover/*'/>
	public EventHandler Ondragover { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOndragstart/*'/>
	public EventHandler Ondragstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOndrop/*'/>
	public EventHandler Ondrop { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOndurationchange/*'/>
	public EventHandler Ondurationchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnemptied/*'/>
	public EventHandler Onemptied { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnended/*'/>
	public EventHandler Onended { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnerror/*'/>
	public OnErrorEventHandler Onerror { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnfocus/*'/>
	public EventHandler Onfocus { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnformdata/*'/>
	public EventHandler Onformdata { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOninput/*'/>
	public EventHandler Oninput { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOninvalid/*'/>
	public EventHandler Oninvalid { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnkeydown/*'/>
	public EventHandler Onkeydown { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnkeypress/*'/>
	public EventHandler Onkeypress { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnkeyup/*'/>
	public EventHandler Onkeyup { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnload/*'/>
	public EventHandler Onload { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnloadeddata/*'/>
	public EventHandler Onloadeddata { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnloadedmetadata/*'/>
	public EventHandler Onloadedmetadata { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnloadstart/*'/>
	public EventHandler Onloadstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnmousedown/*'/>
	public EventHandler Onmousedown { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnmouseenter/*'/>
	public EventHandler Onmouseenter { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnmouseleave/*'/>
	public EventHandler Onmouseleave { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnmousemove/*'/>
	public EventHandler Onmousemove { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnmouseout/*'/>
	public EventHandler Onmouseout { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnmouseover/*'/>
	public EventHandler Onmouseover { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnmouseup/*'/>
	public EventHandler Onmouseup { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnpause/*'/>
	public EventHandler Onpause { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnplay/*'/>
	public EventHandler Onplay { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnplaying/*'/>
	public EventHandler Onplaying { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnprogress/*'/>
	public EventHandler Onprogress { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnratechange/*'/>
	public EventHandler Onratechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnreset/*'/>
	public EventHandler Onreset { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnresize/*'/>
	public EventHandler Onresize { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnscroll/*'/>
	public EventHandler Onscroll { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnsecuritypolicyviolation/*'/>
	public EventHandler Onsecuritypolicyviolation { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnseeked/*'/>
	public EventHandler Onseeked { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnseeking/*'/>
	public EventHandler Onseeking { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnselect/*'/>
	public EventHandler Onselect { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnslotchange/*'/>
	public EventHandler Onslotchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnstalled/*'/>
	public EventHandler Onstalled { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnsubmit/*'/>
	public EventHandler Onsubmit { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnsuspend/*'/>
	public EventHandler Onsuspend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOntimeupdate/*'/>
	public EventHandler Ontimeupdate { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOntoggle/*'/>
	public EventHandler Ontoggle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnvolumechange/*'/>
	public EventHandler Onvolumechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnwaiting/*'/>
	public EventHandler Onwaiting { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnwebkitanimationend/*'/>
	public EventHandler Onwebkitanimationend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnwebkitanimationiteration/*'/>
	public EventHandler Onwebkitanimationiteration { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnwebkitanimationstart/*'/>
	public EventHandler Onwebkitanimationstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnwebkittransitionend/*'/>
	public EventHandler Onwebkittransitionend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/GlobalEventHandlersOnwheel/*'/>
	public EventHandler Onwheel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/WindowEventHandlers/*'/>
public partial interface WindowEventHandlers
{
	///<include file='Utils/Docs.generated.xml' path='docs/WindowEventHandlersOnafterprint/*'/>
	public EventHandler Onafterprint { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowEventHandlersOnbeforeprint/*'/>
	public EventHandler Onbeforeprint { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowEventHandlersOnbeforeunload/*'/>
	public OnBeforeUnloadEventHandler Onbeforeunload { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowEventHandlersOnhashchange/*'/>
	public EventHandler Onhashchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowEventHandlersOnlanguagechange/*'/>
	public EventHandler Onlanguagechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowEventHandlersOnmessage/*'/>
	public EventHandler Onmessage { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowEventHandlersOnmessageerror/*'/>
	public EventHandler Onmessageerror { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowEventHandlersOnoffline/*'/>
	public EventHandler Onoffline { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowEventHandlersOnonline/*'/>
	public EventHandler Ononline { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowEventHandlersOnpagehide/*'/>
	public EventHandler Onpagehide { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowEventHandlersOnpageshow/*'/>
	public EventHandler Onpageshow { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowEventHandlersOnpopstate/*'/>
	public EventHandler Onpopstate { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowEventHandlersOnrejectionhandled/*'/>
	public EventHandler Onrejectionhandled { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowEventHandlersOnstorage/*'/>
	public EventHandler Onstorage { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowEventHandlersOnunhandledrejection/*'/>
	public EventHandler Onunhandledrejection { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowEventHandlersOnunload/*'/>
	public EventHandler Onunload { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/DocumentAndElementEventHandlers/*'/>
public partial interface DocumentAndElementEventHandlers
{
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentAndElementEventHandlersOncopy/*'/>
	public EventHandler Oncopy { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentAndElementEventHandlersOncut/*'/>
	public EventHandler Oncut { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentAndElementEventHandlersOnpaste/*'/>
	public EventHandler Onpaste { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}


///<include file='Utils/Docs.generated.xml' path='docs/WindowOrWorkerGlobalScope/*'/>
public partial interface WindowOrWorkerGlobalScope
{
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOrWorkerGlobalScopeOrigin/*'/>
	public string Origin { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOrWorkerGlobalScopeIsSecureContext/*'/>
	public bool IsSecureContext { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOrWorkerGlobalScopeCrossOriginIsolated/*'/>
	public bool CrossOriginIsolated { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOrWorkerGlobalScopeReportError/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ReportError(dynamic e) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOrWorkerGlobalScopeBtoa/*'/>
	public string Btoa(string data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOrWorkerGlobalScopeAtob/*'/>
	public string Atob(string data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOrWorkerGlobalScopeSetTimeout/*'/>
	public long SetTimeout(TimerHandler handler, long timeout, params dynamic[] arguments) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOrWorkerGlobalScopeClearTimeout/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ClearTimeout(long id) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOrWorkerGlobalScopeSetInterval/*'/>
	public long SetInterval(TimerHandler handler, long timeout, params dynamic[] arguments) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOrWorkerGlobalScopeClearInterval/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ClearInterval(long id) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOrWorkerGlobalScopeQueueMicrotask/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ QueueMicrotask(VoidFunction callback) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOrWorkerGlobalScopeCreateImageBitmap/*'/>
	public Task<ImageBitmap> CreateImageBitmap(ImageBitmapSource image, ImageBitmapOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOrWorkerGlobalScopeCreateImageBitmap/*'/>
	public Task<ImageBitmap> CreateImageBitmap(ImageBitmapSource image, long sx, long sy, long sw, long sh, ImageBitmapOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowOrWorkerGlobalScopeStructuredClone/*'/>
	public dynamic StructuredClone(dynamic value, StructuredSerializeOptions options) { throw new System.NotImplementedException(); }
}



[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/DOMParser/*'/>
public partial class DOMParser
{
	///<include file='Utils/Docs.generated.xml' path='docs/DOMParser/*'/>
	public DOMParser() { }
	///<include file='Utils/Docs.generated.xml' path='docs/DOMParserParseFromString/*'/>
	public Document ParseFromString(string string_, DOMParserSupportedType type) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs.generated.xml' path='docs/DOMParserSupportedType/*'/>
public enum DOMParserSupportedType
{
	TextHtml,
	TextXml,
	ApplicationXml,
	ApplicationXhtmlXml,
	ImageSvgXml,
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Navigator/*'/>
public partial class Navigator
{
}








[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NavigatorID/*'/>
public partial interface NavigatorID
{
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorIDAppCodeName/*'/>
	public string AppCodeName { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorIDAppName/*'/>
	public string AppName { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorIDAppVersion/*'/>
	public string AppVersion { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorIDPlatform/*'/>
	public string Platform { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorIDProduct/*'/>
	public string Product { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorIDProductSub/*'/>
	public string ProductSub { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorIDUserAgent/*'/>
	public string UserAgent { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorIDVendor/*'/>
	public string Vendor { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorIDVendorSub/*'/>
	public string VendorSub { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs.generated.xml' path='docs/NavigatorID/*'/>
public partial interface NavigatorID
{
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorIDTaintEnabled/*'/>
	public bool TaintEnabled() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorIDOscpu/*'/>
	public string Oscpu { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NavigatorLanguage/*'/>
public partial interface NavigatorLanguage
{
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorLanguageLanguage/*'/>
	public string Language { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorLanguageLanguages/*'/>
	public string[] Languages { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NavigatorOnLine/*'/>
public partial interface NavigatorOnLine
{
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorOnLineOnLine/*'/>
	public bool OnLine { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NavigatorContentUtils/*'/>
public partial interface NavigatorContentUtils
{
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorContentUtilsRegisterProtocolHandler/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ RegisterProtocolHandler(string scheme, string url) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorContentUtilsUnregisterProtocolHandler/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ UnregisterProtocolHandler(string scheme, string url) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NavigatorCookies/*'/>
public partial interface NavigatorCookies
{
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorCookiesCookieEnabled/*'/>
	public bool CookieEnabled { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NavigatorPlugins/*'/>
public partial interface NavigatorPlugins
{
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorPluginsPlugins/*'/>
	public PluginArray Plugins { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorPluginsMimeTypes/*'/>
	public MimeTypeArray MimeTypes { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorPluginsJavaEnabled/*'/>
	public bool JavaEnabled() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorPluginsPdfViewerEnabled/*'/>
	public bool PdfViewerEnabled { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/PluginArray/*'/>
public partial class PluginArray
{
	///<include file='Utils/Docs.generated.xml' path='docs/PluginArrayRefresh/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Refresh() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/PluginArrayLength/*'/>
	public ulong Length { get; }
	
	
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/MimeTypeArray/*'/>
public partial class MimeTypeArray
{
	///<include file='Utils/Docs.generated.xml' path='docs/MimeTypeArrayLength/*'/>
	public ulong Length { get; }
	
	
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Plugin/*'/>
public partial class Plugin
{
	///<include file='Utils/Docs.generated.xml' path='docs/PluginName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/PluginDescription/*'/>
	public string Description { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/PluginFilename/*'/>
	public string Filename { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/PluginLength/*'/>
	public ulong Length { get; }
	
	
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/MimeType/*'/>
public partial class MimeType
{
	///<include file='Utils/Docs.generated.xml' path='docs/MimeTypeType/*'/>
	public string Type { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/MimeTypeDescription/*'/>
	public string Description { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/MimeTypeSuffixes/*'/>
	public string Suffixes { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/MimeTypeEnabledPlugin/*'/>
	public Plugin EnabledPlugin { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ImageBitmap/*'/>
public partial class ImageBitmap
{
	///<include file='Utils/Docs.generated.xml' path='docs/ImageBitmapWidth/*'/>
	public ulong Width { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ImageBitmapHeight/*'/>
	public ulong Height { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ImageBitmapClose/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Close() { throw new System.NotImplementedException(); }
}


///<include file='Utils/Docs.generated.xml' path='docs/ImageOrientation/*'/>
public enum ImageOrientation
{
	None,
	FlipY,
}

///<include file='Utils/Docs.generated.xml' path='docs/PremultiplyAlpha/*'/>
public enum PremultiplyAlpha
{
	None,
	Premultiply,
	Default,
}

///<include file='Utils/Docs.generated.xml' path='docs/ColorSpaceConversion/*'/>
public enum ColorSpaceConversion
{
	None,
	Default,
}

///<include file='Utils/Docs.generated.xml' path='docs/ResizeQuality/*'/>
public enum ResizeQuality
{
	Pixelated,
	Low,
	Medium,
	High,
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ImageBitmapOptions/*'/>
public partial class ImageBitmapOptions
{
	///<include file='Utils/Docs.generated.xml' path='docs/ImageBitmapOptionsImageOrientation/*'/>
	public ImageOrientation ImageOrientation;
	///<include file='Utils/Docs.generated.xml' path='docs/ImageBitmapOptionsPremultiplyAlpha/*'/>
	public PremultiplyAlpha PremultiplyAlpha;
	///<include file='Utils/Docs.generated.xml' path='docs/ImageBitmapOptionsColorSpaceConversion/*'/>
	public ColorSpaceConversion ColorSpaceConversion;
	///<include file='Utils/Docs.generated.xml' path='docs/ImageBitmapOptionsResizeWidth/*'/>
	public ulong ResizeWidth;
	///<include file='Utils/Docs.generated.xml' path='docs/ImageBitmapOptionsResizeHeight/*'/>
	public ulong ResizeHeight;
	///<include file='Utils/Docs.generated.xml' path='docs/ImageBitmapOptionsResizeQuality/*'/>
	public ResizeQuality ResizeQuality;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/FrameRequestCallback/*'/>
public struct FrameRequestCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/AnimationFrameProvider/*'/>
public partial interface AnimationFrameProvider
{
	///<include file='Utils/Docs.generated.xml' path='docs/AnimationFrameProviderRequestAnimationFrame/*'/>
	public ulong RequestAnimationFrame(FrameRequestCallback callback) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/AnimationFrameProviderCancelAnimationFrame/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ CancelAnimationFrame(ulong handle) { throw new System.NotImplementedException(); }
}



[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/MessageEvent/*'/>
public partial class MessageEvent : Event
{
	///<include file='Utils/Docs.generated.xml' path='docs/MessageEvent/*'/>
	public MessageEvent(string type, MessageEventInit eventInitDict) { }
	///<include file='Utils/Docs.generated.xml' path='docs/MessageEventData/*'/>
	public dynamic Data { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/MessageEventOrigin/*'/>
	public string Origin { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/MessageEventLastEventId/*'/>
	public string LastEventId { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/MessageEventSource/*'/>
	public MessageEventSource? Source { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/MessageEventPorts/*'/>
	public MessagePort[] Ports { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/MessageEventInitMessageEvent/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ InitMessageEvent(string type, bool bubbles, bool cancelable, dynamic data, string origin, string lastEventId, MessageEventSource? source, List<MessagePort> ports) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/MessageEventInit/*'/>
public partial class MessageEventInit : EventInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/MessageEventInitData/*'/>
	public dynamic Data;
	///<include file='Utils/Docs.generated.xml' path='docs/MessageEventInitOrigin/*'/>
	public string Origin;
	///<include file='Utils/Docs.generated.xml' path='docs/MessageEventInitLastEventId/*'/>
	public string LastEventId;
	///<include file='Utils/Docs.generated.xml' path='docs/MessageEventInitSource/*'/>
	public MessageEventSource? Source;
	///<include file='Utils/Docs.generated.xml' path='docs/MessageEventInitPorts/*'/>
	public List<MessagePort> Ports;
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/EventSource/*'/>
public partial class EventSource : EventTarget
{
	///<include file='Utils/Docs.generated.xml' path='docs/EventSource/*'/>
	public EventSource(string url, EventSourceInit eventSourceInitDict) { }
	///<include file='Utils/Docs.generated.xml' path='docs/EventSourceUrl/*'/>
	public string Url { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventSourceWithCredentials/*'/>
	public bool WithCredentials { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventSourceCONNECTING/*'/>
	public const ushort CONNECTING = 0;
	///<include file='Utils/Docs.generated.xml' path='docs/EventSourceOPEN/*'/>
	public const ushort OPEN = 1;
	///<include file='Utils/Docs.generated.xml' path='docs/EventSourceCLOSED/*'/>
	public const ushort CLOSED = 2;
	///<include file='Utils/Docs.generated.xml' path='docs/EventSourceReadyState/*'/>
	public ushort ReadyState { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventSourceOnopen/*'/>
	public EventHandler Onopen { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventSourceOnmessage/*'/>
	public EventHandler Onmessage { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventSourceOnerror/*'/>
	public EventHandler Onerror { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/EventSourceClose/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Close() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/EventSourceInit/*'/>
public partial class EventSourceInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/EventSourceInitWithCredentials/*'/>
	public bool WithCredentials;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/MessageChannel/*'/>
public partial class MessageChannel
{
	///<include file='Utils/Docs.generated.xml' path='docs/MessageChannel/*'/>
	public MessageChannel() { }
	///<include file='Utils/Docs.generated.xml' path='docs/MessageChannelPort1/*'/>
	public MessagePort Port1 { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/MessageChannelPort2/*'/>
	public MessagePort Port2 { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/MessagePort/*'/>
public partial class MessagePort : EventTarget
{
	///<include file='Utils/Docs.generated.xml' path='docs/MessagePortPostMessage/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ PostMessage(dynamic message, List<object> transfer) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/MessagePortPostMessage/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ PostMessage(dynamic message, StructuredSerializeOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/MessagePortStart/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Start() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/MessagePortClose/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Close() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/MessagePortOnmessage/*'/>
	public EventHandler Onmessage { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/MessagePortOnmessageerror/*'/>
	public EventHandler Onmessageerror { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/StructuredSerializeOptions/*'/>
public partial class StructuredSerializeOptions
{
	///<include file='Utils/Docs.generated.xml' path='docs/StructuredSerializeOptionsTransfer/*'/>
	public List<object> Transfer;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/BroadcastChannel/*'/>
public partial class BroadcastChannel : EventTarget
{
	///<include file='Utils/Docs.generated.xml' path='docs/BroadcastChannel/*'/>
	public BroadcastChannel(string name) { }
	///<include file='Utils/Docs.generated.xml' path='docs/BroadcastChannelName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/BroadcastChannelPostMessage/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ PostMessage(dynamic message) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/BroadcastChannelClose/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Close() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/BroadcastChannelOnmessage/*'/>
	public EventHandler Onmessage { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/BroadcastChannelOnmessageerror/*'/>
	public EventHandler Onmessageerror { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/WorkerGlobalScope/*'/>
public partial class WorkerGlobalScope : EventTarget, WindowOrWorkerGlobalScope
{
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerGlobalScopeSelf/*'/>
	public WorkerGlobalScope Self { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerGlobalScopeLocation/*'/>
	public WorkerLocation Location { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerGlobalScopeNavigator/*'/>
	public WorkerNavigator Navigator { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerGlobalScopeImportScripts/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ImportScripts(params string[] urls) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerGlobalScopeOnerror/*'/>
	public OnErrorEventHandler Onerror { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerGlobalScopeOnlanguagechange/*'/>
	public EventHandler Onlanguagechange { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerGlobalScopeOnoffline/*'/>
	public EventHandler Onoffline { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerGlobalScopeOnonline/*'/>
	public EventHandler Ononline { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerGlobalScopeOnrejectionhandled/*'/>
	public EventHandler Onrejectionhandled { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerGlobalScopeOnunhandledrejection/*'/>
	public EventHandler Onunhandledrejection { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/DedicatedWorkerGlobalScope/*'/>
public partial class DedicatedWorkerGlobalScope : WorkerGlobalScope, AnimationFrameProvider
{
	///<include file='Utils/Docs.generated.xml' path='docs/DedicatedWorkerGlobalScopeName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DedicatedWorkerGlobalScopePostMessage/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ PostMessage(dynamic message, List<object> transfer) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DedicatedWorkerGlobalScopePostMessage/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ PostMessage(dynamic message, StructuredSerializeOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DedicatedWorkerGlobalScopeClose/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Close() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DedicatedWorkerGlobalScopeOnmessage/*'/>
	public EventHandler Onmessage { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/DedicatedWorkerGlobalScopeOnmessageerror/*'/>
	public EventHandler Onmessageerror { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/SharedWorkerGlobalScope/*'/>
public partial class SharedWorkerGlobalScope : WorkerGlobalScope
{
	///<include file='Utils/Docs.generated.xml' path='docs/SharedWorkerGlobalScopeName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/SharedWorkerGlobalScopeClose/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Close() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/SharedWorkerGlobalScopeOnconnect/*'/>
	public EventHandler Onconnect { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/AbstractWorker/*'/>
public partial interface AbstractWorker
{
	///<include file='Utils/Docs.generated.xml' path='docs/AbstractWorkerOnerror/*'/>
	public EventHandler Onerror { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Worker/*'/>
public partial class Worker : EventTarget, AbstractWorker
{
	///<include file='Utils/Docs.generated.xml' path='docs/Worker/*'/>
	public Worker(string scriptURL, WorkerOptions options) { }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerTerminate/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Terminate() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerPostMessage/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ PostMessage(dynamic message, List<object> transfer) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerPostMessage/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ PostMessage(dynamic message, StructuredSerializeOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerOnmessage/*'/>
	public EventHandler Onmessage { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerOnmessageerror/*'/>
	public EventHandler Onmessageerror { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/WorkerOptions/*'/>
public partial class WorkerOptions
{
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerOptionsType/*'/>
	public WorkerType Type;
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerOptionsCredentials/*'/>
	public RequestCredentials Credentials;
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerOptionsName/*'/>
	public string Name;
}

///<include file='Utils/Docs.generated.xml' path='docs/WorkerType/*'/>
public enum WorkerType
{
	Classic,
	Module,
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/SharedWorker/*'/>
public partial class SharedWorker : EventTarget, AbstractWorker
{
	///<include file='Utils/Docs.generated.xml' path='docs/SharedWorker/*'/>
	public SharedWorker(string scriptURL, Union46 options) { }
	///<include file='Utils/Docs.generated.xml' path='docs/SharedWorkerPort/*'/>
	public MessagePort Port { get; }
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NavigatorConcurrentHardware/*'/>
public partial interface NavigatorConcurrentHardware
{
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorConcurrentHardwareHardwareConcurrency/*'/>
	public ulong HardwareConcurrency { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/WorkerNavigator/*'/>
public partial class WorkerNavigator
{
}





[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/WorkerLocation/*'/>
public partial class WorkerLocation
{
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerLocationHref/*'/>
	public string Href { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerLocationOrigin/*'/>
	public string Origin { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerLocationProtocol/*'/>
	public string Protocol { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerLocationHost/*'/>
	public string Host { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerLocationHostname/*'/>
	public string Hostname { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerLocationPort/*'/>
	public string Port { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerLocationPathname/*'/>
	public string Pathname { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerLocationSearch/*'/>
	public string Search { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/WorkerLocationHash/*'/>
	public string Hash { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/WorkletGlobalScope/*'/>
public partial class WorkletGlobalScope
{
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Worklet/*'/>
public partial class Worklet
{
	///<include file='Utils/Docs.generated.xml' path='docs/WorkletAddModule/*'/>
	public Task<CSharpToJavaScript.Utils.Unsupported /*undefined*/> AddModule(string moduleURL, WorkletOptions options) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/WorkletOptions/*'/>
public partial class WorkletOptions
{
	///<include file='Utils/Docs.generated.xml' path='docs/WorkletOptionsCredentials/*'/>
	public RequestCredentials Credentials;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Storage/*'/>
public partial class Storage
{
	///<include file='Utils/Docs.generated.xml' path='docs/StorageLength/*'/>
	public ulong Length { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/StorageKey/*'/>
	public string? Key(ulong index) { throw new System.NotImplementedException(); }
	
	
	
	///<include file='Utils/Docs.generated.xml' path='docs/StorageClear/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Clear() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/WindowSessionStorage/*'/>
public partial interface WindowSessionStorage
{
	///<include file='Utils/Docs.generated.xml' path='docs/WindowSessionStorageSessionStorage/*'/>
	public Storage SessionStorage { get { throw new System.NotImplementedException(); } }
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/WindowLocalStorage/*'/>
public partial interface WindowLocalStorage
{
	///<include file='Utils/Docs.generated.xml' path='docs/WindowLocalStorageLocalStorage/*'/>
	public Storage LocalStorage { get { throw new System.NotImplementedException(); } }
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/StorageEvent/*'/>
public partial class StorageEvent : Event
{
	///<include file='Utils/Docs.generated.xml' path='docs/StorageEvent/*'/>
	public StorageEvent(string type, StorageEventInit eventInitDict) { }
	///<include file='Utils/Docs.generated.xml' path='docs/StorageEventKey/*'/>
	public string? Key { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/StorageEventOldValue/*'/>
	public string? OldValue { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/StorageEventNewValue/*'/>
	public string? NewValue { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/StorageEventUrl/*'/>
	public string Url { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/StorageEventStorageArea/*'/>
	public Storage? StorageArea { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/StorageEventInitStorageEvent/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ InitStorageEvent(string type, bool bubbles, bool cancelable, string? key, string? oldValue, string? newValue, string url, Storage? storageArea) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/StorageEventInit/*'/>
public partial class StorageEventInit : EventInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/StorageEventInitKey/*'/>
	public string? Key;
	///<include file='Utils/Docs.generated.xml' path='docs/StorageEventInitOldValue/*'/>
	public string? OldValue;
	///<include file='Utils/Docs.generated.xml' path='docs/StorageEventInitNewValue/*'/>
	public string? NewValue;
	///<include file='Utils/Docs.generated.xml' path='docs/StorageEventInitUrl/*'/>
	public string Url;
	///<include file='Utils/Docs.generated.xml' path='docs/StorageEventInitStorageArea/*'/>
	public Storage? StorageArea;
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMarqueeElement/*'/>
public partial class HTMLMarqueeElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLMarqueeElement/*'/>
	public HTMLMarqueeElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMarqueeElementBehavior/*'/>
	public string Behavior { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMarqueeElementBgColor/*'/>
	public string BgColor { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMarqueeElementDirection/*'/>
	public string Direction { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMarqueeElementHeight/*'/>
	public string Height { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMarqueeElementHspace/*'/>
	public ulong Hspace { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMarqueeElementLoop/*'/>
	public long Loop { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMarqueeElementScrollAmount/*'/>
	public ulong ScrollAmount { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMarqueeElementScrollDelay/*'/>
	public ulong ScrollDelay { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMarqueeElementTrueSpeed/*'/>
	public bool TrueSpeed { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMarqueeElementVspace/*'/>
	public ulong Vspace { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMarqueeElementWidth/*'/>
	public string Width { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMarqueeElementStart/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Start() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLMarqueeElementStop/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Stop() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFrameSetElement/*'/>
public partial class HTMLFrameSetElement : HTMLElement, WindowEventHandlers
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLFrameSetElement/*'/>
	public HTMLFrameSetElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFrameSetElementCols/*'/>
	public string Cols { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFrameSetElementRows/*'/>
	public string Rows { get; set; }
}


[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFrameElement/*'/>
public partial class HTMLFrameElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLFrameElement/*'/>
	public HTMLFrameElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFrameElementName/*'/>
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFrameElementScrolling/*'/>
	public string Scrolling { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFrameElementSrc/*'/>
	public string Src { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFrameElementFrameBorder/*'/>
	public string FrameBorder { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFrameElementLongDesc/*'/>
	public string LongDesc { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFrameElementNoResize/*'/>
	public bool NoResize { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFrameElementContentDocument/*'/>
	public Document? ContentDocument { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFrameElementContentWindow/*'/>
	public Window? ContentWindow { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFrameElementMarginHeight/*'/>
	public string MarginHeight { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFrameElementMarginWidth/*'/>
	public string MarginWidth { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLAnchorElement/*'/>
public partial class HTMLAnchorElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLAnchorElementCoords/*'/>
	public string Coords { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLAnchorElementCharset/*'/>
	public string Charset { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLAnchorElementName/*'/>
	public string Name { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLAnchorElementRev/*'/>
	public string Rev { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLAnchorElementShape/*'/>
	public string Shape { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLAreaElement/*'/>
public partial class HTMLAreaElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLAreaElementNoHref/*'/>
	public bool NoHref { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLBodyElement/*'/>
public partial class HTMLBodyElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLBodyElementText/*'/>
	public string Text { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLBodyElementLink/*'/>
	public string Link { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLBodyElementVLink/*'/>
	public string VLink { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLBodyElementALink/*'/>
	public string ALink { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLBodyElementBgColor/*'/>
	public string BgColor { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLBodyElementBackground/*'/>
	public string Background { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLBRElement/*'/>
public partial class HTMLBRElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLBRElementClear/*'/>
	public string Clear { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCaptionElement/*'/>
public partial class HTMLTableCaptionElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCaptionElementAlign/*'/>
	public string Align { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableColElement/*'/>
public partial class HTMLTableColElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableColElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableColElementCh/*'/>
	public string Ch { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableColElementChOff/*'/>
	public string ChOff { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableColElementVAlign/*'/>
	public string VAlign { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableColElementWidth/*'/>
	public string Width { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLDirectoryElement/*'/>
public partial class HTMLDirectoryElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLDirectoryElement/*'/>
	public HTMLDirectoryElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLDirectoryElementCompact/*'/>
	public bool Compact { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLDivElement/*'/>
public partial class HTMLDivElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLDivElementAlign/*'/>
	public string Align { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLDListElement/*'/>
public partial class HTMLDListElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLDListElementCompact/*'/>
	public bool Compact { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLEmbedElement/*'/>
public partial class HTMLEmbedElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLEmbedElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLEmbedElementName/*'/>
	public string Name { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFontElement/*'/>
public partial class HTMLFontElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLFontElement/*'/>
	public HTMLFontElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFontElementColor/*'/>
	public string Color { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFontElementFace/*'/>
	public string Face { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLFontElementSize/*'/>
	public string Size { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLHeadingElement/*'/>
public partial class HTMLHeadingElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHeadingElementAlign/*'/>
	public string Align { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLHRElement/*'/>
public partial class HTMLHRElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHRElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHRElementColor/*'/>
	public string Color { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHRElementNoShade/*'/>
	public bool NoShade { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHRElementSize/*'/>
	public string Size { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHRElementWidth/*'/>
	public string Width { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLHtmlElement/*'/>
public partial class HTMLHtmlElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLHtmlElementVersion/*'/>
	public string Version { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElement/*'/>
public partial class HTMLIFrameElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementScrolling/*'/>
	public string Scrolling { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementFrameBorder/*'/>
	public string FrameBorder { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementLongDesc/*'/>
	public string LongDesc { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementMarginHeight/*'/>
	public string MarginHeight { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLIFrameElementMarginWidth/*'/>
	public string MarginWidth { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElement/*'/>
public partial class HTMLImageElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementName/*'/>
	public string Name { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementLowsrc/*'/>
	public string Lowsrc { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementHspace/*'/>
	public ulong Hspace { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementVspace/*'/>
	public ulong Vspace { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementLongDesc/*'/>
	public string LongDesc { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLImageElementBorder/*'/>
	public string Border { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElement/*'/>
public partial class HTMLInputElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLInputElementUseMap/*'/>
	public string UseMap { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLLegendElement/*'/>
public partial class HTMLLegendElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLLegendElementAlign/*'/>
	public string Align { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLLIElement/*'/>
public partial class HTMLLIElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLLIElementType/*'/>
	public string Type { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElement/*'/>
public partial class HTMLLinkElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElementCharset/*'/>
	public string Charset { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElementRev/*'/>
	public string Rev { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLLinkElementTarget/*'/>
	public string Target { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLMenuElement/*'/>
public partial class HTMLMenuElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLMenuElementCompact/*'/>
	public bool Compact { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLMetaElement/*'/>
public partial class HTMLMetaElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLMetaElementScheme/*'/>
	public string Scheme { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElement/*'/>
public partial class HTMLObjectElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementArchive/*'/>
	public string Archive { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementCode/*'/>
	public string Code { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementDeclare/*'/>
	public bool Declare { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementHspace/*'/>
	public ulong Hspace { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementStandby/*'/>
	public string Standby { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementVspace/*'/>
	public ulong Vspace { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementCodeBase/*'/>
	public string CodeBase { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementCodeType/*'/>
	public string CodeType { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementUseMap/*'/>
	public string UseMap { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLObjectElementBorder/*'/>
	public string Border { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLOListElement/*'/>
public partial class HTMLOListElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLOListElementCompact/*'/>
	public bool Compact { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLParagraphElement/*'/>
public partial class HTMLParagraphElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLParagraphElementAlign/*'/>
	public string Align { get; set; }
}

[To(ToAttribute.Default)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLParamElement/*'/>
public partial class HTMLParamElement : HTMLElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLParamElement/*'/>
	public HTMLParamElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLParamElementName/*'/>
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLParamElementValue/*'/>
	public string Value { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLParamElementType/*'/>
	public string Type { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/HTMLParamElementValueType/*'/>
	public string ValueType { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLPreElement/*'/>
public partial class HTMLPreElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLPreElementWidth/*'/>
	public long Width { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLStyleElement/*'/>
public partial class HTMLStyleElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLStyleElementType/*'/>
	public string Type { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLScriptElement/*'/>
public partial class HTMLScriptElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLScriptElementCharset/*'/>
	public string Charset { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLScriptElementEvent/*'/>
	public string Event { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLScriptElementHtmlFor/*'/>
	public string HtmlFor { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElement/*'/>
public partial class HTMLTableElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementBorder/*'/>
	public string Border { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementFrame/*'/>
	public string Frame { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementRules/*'/>
	public string Rules { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementSummary/*'/>
	public string Summary { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementWidth/*'/>
	public string Width { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementBgColor/*'/>
	public string BgColor { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementCellPadding/*'/>
	public string CellPadding { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableElementCellSpacing/*'/>
	public string CellSpacing { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableSectionElement/*'/>
public partial class HTMLTableSectionElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableSectionElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableSectionElementCh/*'/>
	public string Ch { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableSectionElementChOff/*'/>
	public string ChOff { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableSectionElementVAlign/*'/>
	public string VAlign { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCellElement/*'/>
public partial class HTMLTableCellElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCellElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCellElementAxis/*'/>
	public string Axis { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCellElementHeight/*'/>
	public string Height { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCellElementWidth/*'/>
	public string Width { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCellElementCh/*'/>
	public string Ch { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCellElementChOff/*'/>
	public string ChOff { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCellElementNoWrap/*'/>
	public bool NoWrap { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCellElementVAlign/*'/>
	public string VAlign { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableCellElementBgColor/*'/>
	public string BgColor { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableRowElement/*'/>
public partial class HTMLTableRowElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableRowElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableRowElementCh/*'/>
	public string Ch { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableRowElementChOff/*'/>
	public string ChOff { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableRowElementVAlign/*'/>
	public string VAlign { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLTableRowElementBgColor/*'/>
	public string BgColor { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/HTMLUListElement/*'/>
public partial class HTMLUListElement
{
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLUListElementCompact/*'/>
	public bool Compact { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/HTMLUListElementType/*'/>
	public string Type { get; set; }
}

///<include file='Utils/Docs.generated.xml' path='docs/Document/*'/>
public partial class Document
{
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentFgColor/*'/>
	public string FgColor { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentLinkColor/*'/>
	public string LinkColor { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentVlinkColor/*'/>
	public string VlinkColor { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentAlinkColor/*'/>
	public string AlinkColor { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentBgColor/*'/>
	public string BgColor { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentAnchors/*'/>
	public HTMLCollection Anchors { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentApplets/*'/>
	public HTMLCollection Applets { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentClear/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Clear() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentCaptureEvents/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ CaptureEvents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentReleaseEvents/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ReleaseEvents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/DocumentAll/*'/>
	public HTMLAllCollection All { get; }
}

///<include file='Utils/Docs.generated.xml' path='docs/Window/*'/>
public partial class Window
{
	///<include file='Utils/Docs.generated.xml' path='docs/WindowCaptureEvents/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ CaptureEvents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowReleaseEvents/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ ReleaseEvents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/WindowExternal/*'/>
	public External External { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/External/*'/>
public partial class External
{
	///<include file='Utils/Docs.generated.xml' path='docs/ExternalAddSearchProvider/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ AddSearchProvider() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ExternalIsSearchProviderInstalled/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ IsSearchProviderInstalled() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Notification/*'/>
public partial class Notification : EventTarget
{
	///<include file='Utils/Docs.generated.xml' path='docs/Notification/*'/>
	public Notification(string title, NotificationOptions options) { }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationPermission/*'/>
	public static NotificationPermission Permission { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationRequestPermission/*'/>
	public static Task<NotificationPermission> RequestPermission(NotificationPermissionCallback deprecatedCallback) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationMaxActions/*'/>
	public static ulong MaxActions { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationOnclick/*'/>
	public EventHandler Onclick { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationOnshow/*'/>
	public EventHandler Onshow { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationOnerror/*'/>
	public EventHandler Onerror { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationOnclose/*'/>
	public EventHandler Onclose { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationTitle/*'/>
	public string Title { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationDir/*'/>
	public NotificationDirection Dir { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationLang/*'/>
	public string Lang { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationBody/*'/>
	public string Body { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationTag/*'/>
	public string Tag { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationImage/*'/>
	public string Image { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationIcon/*'/>
	public string Icon { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationBadge/*'/>
	public string Badge { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationVibrate/*'/>
	public ulong[] Vibrate { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationTimestamp/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*EpochTimeStamp*/ Timestamp { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationRenotify/*'/>
	public bool Renotify { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationSilent/*'/>
	public bool Silent { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationRequireInteraction/*'/>
	public bool RequireInteraction { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationData/*'/>
	public dynamic Data { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationActions/*'/>
	public NotificationAction[] Actions { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationClose/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Close() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NotificationOptions/*'/>
public partial class NotificationOptions
{
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationOptionsDir/*'/>
	public NotificationDirection Dir;
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationOptionsLang/*'/>
	public string Lang;
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationOptionsBody/*'/>
	public string Body;
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationOptionsTag/*'/>
	public string Tag;
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationOptionsImage/*'/>
	public string Image;
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationOptionsIcon/*'/>
	public string Icon;
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationOptionsBadge/*'/>
	public string Badge;
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationOptionsVibrate/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*VibratePattern*/ Vibrate;
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationOptionsTimestamp/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*EpochTimeStamp*/ Timestamp;
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationOptionsRenotify/*'/>
	public bool Renotify;
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationOptionsSilent/*'/>
	public bool Silent;
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationOptionsRequireInteraction/*'/>
	public bool RequireInteraction;
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationOptionsData/*'/>
	public dynamic Data;
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationOptionsActions/*'/>
	public List<NotificationAction> Actions;
}

///<include file='Utils/Docs.generated.xml' path='docs/NotificationPermission/*'/>
public enum NotificationPermission
{
	Default,
	Denied,
	Granted,
}

///<include file='Utils/Docs.generated.xml' path='docs/NotificationDirection/*'/>
public enum NotificationDirection
{
	Auto,
	Ltr,
	Rtl,
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NotificationAction/*'/>
public partial class NotificationAction
{
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationActionAction/*'/>
	public required string Action;
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationActionTitle/*'/>
	public required string Title;
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationActionIcon/*'/>
	public string Icon;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NotificationPermissionCallback/*'/>
public struct NotificationPermissionCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/GetNotificationOptions/*'/>
public partial class GetNotificationOptions
{
	///<include file='Utils/Docs.generated.xml' path='docs/GetNotificationOptionsTag/*'/>
	public string Tag;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ServiceWorkerRegistration/*'/>
public partial class ServiceWorkerRegistration
{
	///<include file='Utils/Docs.generated.xml' path='docs/ServiceWorkerRegistrationShowNotification/*'/>
	public Task<CSharpToJavaScript.Utils.Unsupported /*undefined*/> ShowNotification(string title, NotificationOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/ServiceWorkerRegistrationGetNotifications/*'/>
	public Task<List<Notification>> GetNotifications(GetNotificationOptions filter) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NotificationEvent/*'/>
public partial class NotificationEvent
{
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationEvent/*'/>
	public NotificationEvent(string type, NotificationEventInit eventInitDict) { }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationEventNotification/*'/>
	public Notification Notification { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationEventAction/*'/>
	public string Action { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NotificationEventInit/*'/>
public partial class NotificationEventInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationEventInitNotification/*'/>
	public required Notification Notification;
	///<include file='Utils/Docs.generated.xml' path='docs/NotificationEventInitAction/*'/>
	public string Action;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ServiceWorkerGlobalScope/*'/>
public partial class ServiceWorkerGlobalScope
{
	///<include file='Utils/Docs.generated.xml' path='docs/ServiceWorkerGlobalScopeOnnotificationclick/*'/>
	public EventHandler Onnotificationclick { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/ServiceWorkerGlobalScopeOnnotificationclose/*'/>
	public EventHandler Onnotificationclose { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/NavigatorStorage/*'/>
public partial interface NavigatorStorage
{
	///<include file='Utils/Docs.generated.xml' path='docs/NavigatorStorageStorage/*'/>
	public StorageManager Storage { get { throw new System.NotImplementedException(); } }
}



[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/StorageManager/*'/>
public partial class StorageManager
{
	///<include file='Utils/Docs.generated.xml' path='docs/StorageManagerPersisted/*'/>
	public Task<bool> Persisted() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/StorageManagerPersist/*'/>
	public Task<bool> Persist() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/StorageManagerEstimate/*'/>
	public Task<StorageEstimate> Estimate() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/StorageEstimate/*'/>
public partial class StorageEstimate
{
	///<include file='Utils/Docs.generated.xml' path='docs/StorageEstimateUsage/*'/>
	public ulong Usage;
	///<include file='Utils/Docs.generated.xml' path='docs/StorageEstimateQuota/*'/>
	public ulong Quota;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/URL/*'/>
public partial class URL
{
	///<include file='Utils/Docs.generated.xml' path='docs/URL/*'/>
	public URL(string url, string base_) { }
	///<include file='Utils/Docs.generated.xml' path='docs/URLHref/*'/>
	public string Href { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/URLOrigin/*'/>
	public string Origin { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/URLProtocol/*'/>
	public string Protocol { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/URLUsername/*'/>
	public string Username { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/URLPassword/*'/>
	public string Password { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/URLHost/*'/>
	public string Host { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/URLHostname/*'/>
	public string Hostname { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/URLPort/*'/>
	public string Port { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/URLPathname/*'/>
	public string Pathname { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/URLSearch/*'/>
	public string Search { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/URLSearchParams/*'/>
	public URLSearchParams SearchParams { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/URLHash/*'/>
	public string Hash { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/URLToJSON/*'/>
	public string ToJSON() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/URLSearchParams/*'/>
public partial class URLSearchParams
{
	///<include file='Utils/Docs.generated.xml' path='docs/URLSearchParams/*'/>
	public URLSearchParams(Union47 init) { }
	///<include file='Utils/Docs.generated.xml' path='docs/URLSearchParamsAppend/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Append(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/URLSearchParamsDelete/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Delete(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/URLSearchParamsGet/*'/>
	public string? Get(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/URLSearchParamsGetAll/*'/>
	public List<string> GetAll(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/URLSearchParamsHas/*'/>
	public bool Has(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/URLSearchParamsSet/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Set(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/URLSearchParamsSort/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Sort() { throw new System.NotImplementedException(); }
	
	
}



[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/DOMException/*'/>
public partial class DOMException
{
	///<include file='Utils/Docs.generated.xml' path='docs/DOMException/*'/>
	public DOMException(string message, string name) { }
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionMessage/*'/>
	public string Message { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionCode/*'/>
	public ushort Code { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionINDEX_SIZE_ERR/*'/>
	public const ushort INDEX_SIZE_ERR = 1;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionDOMSTRING_SIZE_ERR/*'/>
	public const ushort DOMSTRING_SIZE_ERR = 2;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionHIERARCHY_REQUEST_ERR/*'/>
	public const ushort HIERARCHY_REQUEST_ERR = 3;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionWRONG_DOCUMENT_ERR/*'/>
	public const ushort WRONG_DOCUMENT_ERR = 4;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionINVALID_CHARACTER_ERR/*'/>
	public const ushort INVALID_CHARACTER_ERR = 5;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionNO_DATA_ALLOWED_ERR/*'/>
	public const ushort NO_DATA_ALLOWED_ERR = 6;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionNO_MODIFICATION_ALLOWED_ERR/*'/>
	public const ushort NO_MODIFICATION_ALLOWED_ERR = 7;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionNOT_FOUND_ERR/*'/>
	public const ushort NOT_FOUND_ERR = 8;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionNOT_SUPPORTED_ERR/*'/>
	public const ushort NOT_SUPPORTED_ERR = 9;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionINUSE_ATTRIBUTE_ERR/*'/>
	public const ushort INUSE_ATTRIBUTE_ERR = 10;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionINVALID_STATE_ERR/*'/>
	public const ushort INVALID_STATE_ERR = 11;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionSYNTAX_ERR/*'/>
	public const ushort SYNTAX_ERR = 12;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionINVALID_MODIFICATION_ERR/*'/>
	public const ushort INVALID_MODIFICATION_ERR = 13;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionNAMESPACE_ERR/*'/>
	public const ushort NAMESPACE_ERR = 14;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionINVALID_ACCESS_ERR/*'/>
	public const ushort INVALID_ACCESS_ERR = 15;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionVALIDATION_ERR/*'/>
	public const ushort VALIDATION_ERR = 16;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionTYPE_MISMATCH_ERR/*'/>
	public const ushort TYPE_MISMATCH_ERR = 17;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionSECURITY_ERR/*'/>
	public const ushort SECURITY_ERR = 18;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionNETWORK_ERR/*'/>
	public const ushort NETWORK_ERR = 19;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionABORT_ERR/*'/>
	public const ushort ABORT_ERR = 20;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionURL_MISMATCH_ERR/*'/>
	public const ushort URL_MISMATCH_ERR = 21;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionQUOTA_EXCEEDED_ERR/*'/>
	public const ushort QUOTA_EXCEEDED_ERR = 22;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionTIMEOUT_ERR/*'/>
	public const ushort TIMEOUT_ERR = 23;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionINVALID_NODE_TYPE_ERR/*'/>
	public const ushort INVALID_NODE_TYPE_ERR = 24;
	///<include file='Utils/Docs.generated.xml' path='docs/DOMExceptionDATA_CLONE_ERR/*'/>
	public const ushort DATA_CLONE_ERR = 25;
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/Function/*'/>
public struct Function
{
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/VoidFunction/*'/>
public struct VoidFunction
{
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestEventTarget/*'/>
public partial class XMLHttpRequestEventTarget : EventTarget
{
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestEventTargetOnloadstart/*'/>
	public EventHandler Onloadstart { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestEventTargetOnprogress/*'/>
	public EventHandler Onprogress { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestEventTargetOnabort/*'/>
	public EventHandler Onabort { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestEventTargetOnerror/*'/>
	public EventHandler Onerror { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestEventTargetOnload/*'/>
	public EventHandler Onload { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestEventTargetOntimeout/*'/>
	public EventHandler Ontimeout { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestEventTargetOnloadend/*'/>
	public EventHandler Onloadend { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestUpload/*'/>
public partial class XMLHttpRequestUpload : XMLHttpRequestEventTarget
{
}

///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestResponseType/*'/>
public enum XMLHttpRequestResponseType
{
	Empty,
	Arraybuffer,
	Blob,
	Document,
	Json,
	Text,
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequest/*'/>
public partial class XMLHttpRequest : XMLHttpRequestEventTarget
{
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequest/*'/>
	public XMLHttpRequest() { }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestOnreadystatechange/*'/>
	public EventHandler Onreadystatechange { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestUNSENT/*'/>
	public const ushort UNSENT = 0;
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestOPENED/*'/>
	public const ushort OPENED = 1;
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestHEADERS_RECEIVED/*'/>
	public const ushort HEADERS_RECEIVED = 2;
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestLOADING/*'/>
	public const ushort LOADING = 3;
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestDONE/*'/>
	public const ushort DONE = 4;
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestReadyState/*'/>
	public ushort ReadyState { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestOpen/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Open(string method, string url) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestOpen/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Open(string method, string url, bool async, string? username, string? password) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestSetRequestHeader/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ SetRequestHeader(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestTimeout/*'/>
	public ulong Timeout { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestWithCredentials/*'/>
	public bool WithCredentials { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestUpload/*'/>
	public XMLHttpRequestUpload Upload { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestSend/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Send(Union50? body) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestAbort/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Abort() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestResponseURL/*'/>
	public string ResponseURL { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestStatus/*'/>
	public ushort Status { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestStatusText/*'/>
	public string StatusText { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestGetResponseHeader/*'/>
	public string? GetResponseHeader(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestGetAllResponseHeaders/*'/>
	public string GetAllResponseHeaders() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestOverrideMimeType/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ OverrideMimeType(string mime) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestResponseType/*'/>
	public XMLHttpRequestResponseType ResponseType { get; set; }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestResponse/*'/>
	public dynamic Response { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestResponseText/*'/>
	public string ResponseText { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/XMLHttpRequestResponseXML/*'/>
	public Document? ResponseXML { get; }
}


[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/FormData/*'/>
public partial class FormData
{
	///<include file='Utils/Docs.generated.xml' path='docs/FormData/*'/>
	public FormData(HTMLFormElement form) { }
	///<include file='Utils/Docs.generated.xml' path='docs/FormDataAppend/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Append(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/FormDataAppend/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Append(string name, CSharpToJavaScript.Utils.Unsupported /*Blob*/ blobValue, string filename) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/FormDataDelete/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Delete(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/FormDataGet/*'/>
	public FormDataEntryValue? Get(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/FormDataGetAll/*'/>
	public List<FormDataEntryValue> GetAll(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/FormDataHas/*'/>
	public bool Has(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/FormDataSet/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Set(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs.generated.xml' path='docs/FormDataSet/*'/>
	public CSharpToJavaScript.Utils.Unsupported /*undefined*/ Set(string name, CSharpToJavaScript.Utils.Unsupported /*Blob*/ blobValue, string filename) { throw new System.NotImplementedException(); }
	
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ProgressEvent/*'/>
public partial class ProgressEvent : Event
{
	///<include file='Utils/Docs.generated.xml' path='docs/ProgressEvent/*'/>
	public ProgressEvent(string type, ProgressEventInit eventInitDict) { }
	///<include file='Utils/Docs.generated.xml' path='docs/ProgressEventLengthComputable/*'/>
	public bool LengthComputable { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ProgressEventLoaded/*'/>
	public ulong Loaded { get; }
	///<include file='Utils/Docs.generated.xml' path='docs/ProgressEventTotal/*'/>
	public ulong Total { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
///<include file='Utils/Docs.generated.xml' path='docs/ProgressEventInit/*'/>
public partial class ProgressEventInit : EventInit
{
	///<include file='Utils/Docs.generated.xml' path='docs/ProgressEventInitLengthComputable/*'/>
	public bool LengthComputable;
	///<include file='Utils/Docs.generated.xml' path='docs/ProgressEventInitLoaded/*'/>
	public ulong Loaded;
	///<include file='Utils/Docs.generated.xml' path='docs/ProgressEventInitTotal/*'/>
	public ulong Total;
}

public struct Union0
{
	public dynamic Value { get; set; }
	public static implicit operator Union0(Event value){return new Union0 { Value = value };}
	public static implicit operator Union0(CSharpToJavaScript.Utils.Unsupported /*undefined*/ value){return new Union0 { Value = value };}
}

public struct Union1
{
	public dynamic Value { get; set; }
	public static implicit operator Union1(AddEventListenerOptions value){return new Union1 { Value = value };}
	public static implicit operator Union1(bool value){return new Union1 { Value = value };}
}

public struct Union2
{
	public dynamic Value { get; set; }
	public static implicit operator Union2(EventListenerOptions value){return new Union2 { Value = value };}
	public static implicit operator Union2(bool value){return new Union2 { Value = value };}
}

public struct Union3
{
	public dynamic Value { get; set; }
	public static implicit operator Union3(Node value){return new Union3 { Value = value };}
	public static implicit operator Union3(string value){return new Union3 { Value = value };}
}

public struct Union4
{
	public dynamic Value { get; set; }
	public static implicit operator Union4(Node value){return new Union4 { Value = value };}
	public static implicit operator Union4(string value){return new Union4 { Value = value };}
}

public struct Union5
{
	public dynamic Value { get; set; }
	public static implicit operator Union5(Node value){return new Union5 { Value = value };}
	public static implicit operator Union5(string value){return new Union5 { Value = value };}
}

public struct Union6
{
	public dynamic Value { get; set; }
	public static implicit operator Union6(Node value){return new Union6 { Value = value };}
	public static implicit operator Union6(string value){return new Union6 { Value = value };}
}

public struct Union7
{
	public dynamic Value { get; set; }
	public static implicit operator Union7(Node value){return new Union7 { Value = value };}
	public static implicit operator Union7(string value){return new Union7 { Value = value };}
}

public struct Union8
{
	public dynamic Value { get; set; }
	public static implicit operator Union8(Node value){return new Union8 { Value = value };}
	public static implicit operator Union8(string value){return new Union8 { Value = value };}
}

public struct Union9
{
	public dynamic Value { get; set; }
	public static implicit operator Union9(List<List<string>> value){return new Union9 { Value = value };}
	public static implicit operator Union9(Dictionary<string, string> value){return new Union9 { Value = value };}
}

public struct Union10
{
	public dynamic Value { get; set; }
	public static implicit operator Union10(CSharpToJavaScript.Utils.Unsupported /*Blob*/ value){return new Union10 { Value = value };}
	public static implicit operator Union10(BufferSource value){return new Union10 { Value = value };}
	public static implicit operator Union10(FormData value){return new Union10 { Value = value };}
	public static implicit operator Union10(URLSearchParams value){return new Union10 { Value = value };}
	public static implicit operator Union10(string value){return new Union10 { Value = value };}
}

public struct Union11
{
	public dynamic Value { get; set; }
	public static implicit operator Union11(CSharpToJavaScript.Utils.Unsupported /*ReadableStream*/ value){return new Union11 { Value = value };}
	public static implicit operator Union11(XMLHttpRequestBodyInit value){return new Union11 { Value = value };}
}

public struct Union12
{
	public dynamic Value { get; set; }
	public static implicit operator Union12(Request value){return new Union12 { Value = value };}
	public static implicit operator Union12(string value){return new Union12 { Value = value };}
}

public struct Union13
{
	public dynamic Value { get; set; }
	public static implicit operator Union13(HTMLCollection value){return new Union13 { Value = value };}
	public static implicit operator Union13(Element value){return new Union13 { Value = value };}
}

public struct Union14
{
	public dynamic Value { get; set; }
	public static implicit operator Union14(HTMLCollection value){return new Union14 { Value = value };}
	public static implicit operator Union14(Element value){return new Union14 { Value = value };}
}

public struct Union15
{
	public dynamic Value { get; set; }
	public static implicit operator Union15(RadioNodeList value){return new Union15 { Value = value };}
	public static implicit operator Union15(Element value){return new Union15 { Value = value };}
}

public struct Union16
{
	public dynamic Value { get; set; }
	public static implicit operator Union16(HTMLOptionElement value){return new Union16 { Value = value };}
	public static implicit operator Union16(HTMLOptGroupElement value){return new Union16 { Value = value };}
}

public struct Union17
{
	public dynamic Value { get; set; }
	public static implicit operator Union17(HTMLElement value){return new Union17 { Value = value };}
	public static implicit operator Union17(long value){return new Union17 { Value = value };}
}

public struct Union18
{
	public dynamic Value { get; set; }
	public static implicit operator Union18(HTMLScriptElement value){return new Union18 { Value = value };}
	public static implicit operator Union18(CSharpToJavaScript.Utils.Unsupported /*SVGScriptElement*/ value){return new Union18 { Value = value };}
}

public struct Union19
{
	public dynamic Value { get; set; }
	public static implicit operator Union19(bool value){return new Union19 { Value = value };}
	public static implicit operator Union19(double value){return new Union19 { Value = value };}
	public static implicit operator Union19(string value){return new Union19 { Value = value };}
}

public struct Union20
{
	public dynamic Value { get; set; }
	public static implicit operator Union20(CSharpToJavaScript.Utils.Unsupported /*MediaStream*/ value){return new Union20 { Value = value };}
}

public struct Union21
{
	public dynamic Value { get; set; }
	public static implicit operator Union21(VideoTrack value){return new Union21 { Value = value };}
	public static implicit operator Union21(AudioTrack value){return new Union21 { Value = value };}
	public static implicit operator Union21(TextTrack value){return new Union21 { Value = value };}
}

public struct Union22
{
	public dynamic Value { get; set; }
	public static implicit operator Union22(VideoTrack value){return new Union22 { Value = value };}
	public static implicit operator Union22(AudioTrack value){return new Union22 { Value = value };}
	public static implicit operator Union22(TextTrack value){return new Union22 { Value = value };}
}

public struct Union23
{
	public dynamic Value { get; set; }
	public static implicit operator Union23(RadioNodeList value){return new Union23 { Value = value };}
	public static implicit operator Union23(Element value){return new Union23 { Value = value };}
}

public struct Union24
{
	public dynamic Value { get; set; }
	public static implicit operator Union24(HTMLOptionElement value){return new Union24 { Value = value };}
	public static implicit operator Union24(HTMLOptGroupElement value){return new Union24 { Value = value };}
}

public struct Union25
{
	public dynamic Value { get; set; }
	public static implicit operator Union25(HTMLElement value){return new Union25 { Value = value };}
	public static implicit operator Union25(long value){return new Union25 { Value = value };}
}

public struct Union26
{
	public dynamic Value { get; set; }
	public static implicit operator Union26(Element value){return new Union26 { Value = value };}
	public static implicit operator Union26(Text value){return new Union26 { Value = value };}
}

public struct Union27
{
	public dynamic Value { get; set; }
	public static implicit operator Union27(CanvasRenderingContext2D value){return new Union27 { Value = value };}
	public static implicit operator Union27(ImageBitmapRenderingContext value){return new Union27 { Value = value };}
	public static implicit operator Union27(CSharpToJavaScript.Utils.Unsupported /*WebGLRenderingContext*/ value){return new Union27 { Value = value };}
}

public struct Union28
{
	public dynamic Value { get; set; }
	public static implicit operator Union28(HTMLImageElement value){return new Union28 { Value = value };}
	public static implicit operator Union28(CSharpToJavaScript.Utils.Unsupported /*SVGImageElement*/ value){return new Union28 { Value = value };}
}

public struct Union29
{
	public dynamic Value { get; set; }
	public static implicit operator Union29(HTMLOrSVGImageElement value){return new Union29 { Value = value };}
	public static implicit operator Union29(HTMLVideoElement value){return new Union29 { Value = value };}
	public static implicit operator Union29(HTMLCanvasElement value){return new Union29 { Value = value };}
	public static implicit operator Union29(ImageBitmap value){return new Union29 { Value = value };}
	public static implicit operator Union29(OffscreenCanvas value){return new Union29 { Value = value };}
	public static implicit operator Union29(CSharpToJavaScript.Utils.Unsupported /*VideoFrame*/ value){return new Union29 { Value = value };}
}

public struct Union30
{
	public dynamic Value { get; set; }
	public static implicit operator Union30(string value){return new Union30 { Value = value };}
	public static implicit operator Union30(CanvasGradient value){return new Union30 { Value = value };}
	public static implicit operator Union30(CanvasPattern value){return new Union30 { Value = value };}
}

public struct Union31
{
	public dynamic Value { get; set; }
	public static implicit operator Union31(string value){return new Union31 { Value = value };}
	public static implicit operator Union31(CanvasGradient value){return new Union31 { Value = value };}
	public static implicit operator Union31(CanvasPattern value){return new Union31 { Value = value };}
}

public struct Union32
{
	public dynamic Value { get; set; }
	public static implicit operator Union32(string value){return new Union32 { Value = value };}
	public static implicit operator Union32(CanvasFilter value){return new Union32 { Value = value };}
}

public struct Union33
{
	public dynamic Value { get; set; }
	public static implicit operator Union33(CanvasFilterInput value){return new Union33 { Value = value };}
	public static implicit operator Union33(List<CanvasFilterInput> value){return new Union33 { Value = value };}
}

public struct Union35
{
	public dynamic Value { get; set; }
	public static implicit operator Union35(double value){return new Union35 { Value = value };}
	public static implicit operator Union35(CSharpToJavaScript.Utils.Unsupported /*DOMPointInit*/ value){return new Union35 { Value = value };}
}

public struct Union34
{
	public dynamic Value { get; set; }
	public static implicit operator Union34(double value){return new Union34 { Value = value };}
	public static implicit operator Union34(CSharpToJavaScript.Utils.Unsupported /*DOMPointInit*/ value){return new Union34 { Value = value };}
	public static implicit operator Union34(List<Union35> value){return new Union34 { Value = value };}
}

public struct Union36
{
	public dynamic Value { get; set; }
	public static implicit operator Union36(Path2D value){return new Union36 { Value = value };}
	public static implicit operator Union36(string value){return new Union36 { Value = value };}
}

public struct Union37
{
	public dynamic Value { get; set; }
	public static implicit operator Union37(HTMLCanvasElement value){return new Union37 { Value = value };}
	public static implicit operator Union37(OffscreenCanvas value){return new Union37 { Value = value };}
}

public struct Union38
{
	public dynamic Value { get; set; }
	public static implicit operator Union38(OffscreenCanvasRenderingContext2D value){return new Union38 { Value = value };}
	public static implicit operator Union38(ImageBitmapRenderingContext value){return new Union38 { Value = value };}
	public static implicit operator Union38(CSharpToJavaScript.Utils.Unsupported /*WebGLRenderingContext*/ value){return new Union38 { Value = value };}
}

public struct Union39
{
	public dynamic Value { get; set; }
	public static implicit operator Union39(CustomElementConstructor value){return new Union39 { Value = value };}
	public static implicit operator Union39(CSharpToJavaScript.Utils.Unsupported /*undefined*/ value){return new Union39 { Value = value };}
}

public struct Union40
{
	public dynamic Value { get; set; }
	public static implicit operator Union40(CSharpToJavaScript.Utils.Unsupported /*File*/ value){return new Union40 { Value = value };}
	public static implicit operator Union40(string value){return new Union40 { Value = value };}
	public static implicit operator Union40(FormData value){return new Union40 { Value = value };}
}

public struct Union41
{
	public dynamic Value { get; set; }
	public static implicit operator Union41(CSharpToJavaScript.Utils.Unsupported /*File*/ value){return new Union41 { Value = value };}
	public static implicit operator Union41(string value){return new Union41 { Value = value };}
	public static implicit operator Union41(FormData value){return new Union41 { Value = value };}
}

public struct Union42
{
	public dynamic Value { get; set; }
	public static implicit operator Union42(Event value){return new Union42 { Value = value };}
	public static implicit operator Union42(string value){return new Union42 { Value = value };}
}

public struct Union43
{
	public dynamic Value { get; set; }
	public static implicit operator Union43(string value){return new Union43 { Value = value };}
	public static implicit operator Union43(Function value){return new Union43 { Value = value };}
}

public struct Union44
{
	public dynamic Value { get; set; }
	public static implicit operator Union44(CanvasImageSource value){return new Union44 { Value = value };}
	public static implicit operator Union44(CSharpToJavaScript.Utils.Unsupported /*Blob*/ value){return new Union44 { Value = value };}
	public static implicit operator Union44(ImageData value){return new Union44 { Value = value };}
}

public struct Union45
{
	public dynamic Value { get; set; }
	public static implicit operator Union45(Window value){return new Union45 { Value = value };}
	public static implicit operator Union45(MessagePort value){return new Union45 { Value = value };}
	public static implicit operator Union45(CSharpToJavaScript.Utils.Unsupported /*ServiceWorker*/ value){return new Union45 { Value = value };}
}

public struct Union46
{
	public dynamic Value { get; set; }
	public static implicit operator Union46(string value){return new Union46 { Value = value };}
	public static implicit operator Union46(WorkerOptions value){return new Union46 { Value = value };}
}

public struct Union47
{
	public dynamic Value { get; set; }
	public static implicit operator Union47(List<List<string>> value){return new Union47 { Value = value };}
	public static implicit operator Union47(Dictionary<string, string> value){return new Union47 { Value = value };}
	public static implicit operator Union47(string value){return new Union47 { Value = value };}
}

public struct Union48
{
	public dynamic Value { get; set; }
	public static implicit operator Union48(System.SByte value){return new Union48 { Value = value };}
	public static implicit operator Union48(System.Int16 value){return new Union48 { Value = value };}
	public static implicit operator Union48(System.Int32 value){return new Union48 { Value = value };}
	public static implicit operator Union48(System.Byte value){return new Union48 { Value = value };}
	public static implicit operator Union48(System.UInt16 value){return new Union48 { Value = value };}
	public static implicit operator Union48(System.UInt32 value){return new Union48 { Value = value };}
	public static implicit operator Union48(CSharpToJavaScript.Utils.Unsupported /*Uint8ClampedArray*/ value){return new Union48 { Value = value };}
	public static implicit operator Union48(System.Int64 value){return new Union48 { Value = value };}
	public static implicit operator Union48(System.UInt64 value){return new Union48 { Value = value };}
	public static implicit operator Union48(System.Single value){return new Union48 { Value = value };}
	public static implicit operator Union48(System.Double value){return new Union48 { Value = value };}
}

public struct Union49
{
	public dynamic Value { get; set; }
	public static implicit operator Union49(ArrayBufferView value){return new Union49 { Value = value };}
	public static implicit operator Union49(byte[] value){return new Union49 { Value = value };}
}

public struct Union50
{
	public dynamic Value { get; set; }
	public static implicit operator Union50(Document value){return new Union50 { Value = value };}
	public static implicit operator Union50(XMLHttpRequestBodyInit value){return new Union50 { Value = value };}
}

public struct Union51
{
	public dynamic Value { get; set; }
	public static implicit operator Union51(CSharpToJavaScript.Utils.Unsupported /*File*/ value){return new Union51 { Value = value };}
	public static implicit operator Union51(string value){return new Union51 { Value = value };}
}

