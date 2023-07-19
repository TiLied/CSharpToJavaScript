//19.07.2023 14:14:54
using static CSharpToJavaScript.APIs.JS.GlobalObject;
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

///<include file='Utils/Docs/Window/Window.generated.xml' path='docs/Window/*'/>
[To(ToAttribute.Default)]
public partial class Window
{
	///<include file='Utils/Docs/WindowOrientation/WindowOrientation.generated.xml' path='docs/WindowOrientation/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public short Orientation { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onorientationchange { get; set; }
}

///<include file='Utils/Docs/HTMLBodyElement/HTMLBodyElement.generated.xml' path='docs/HTMLBodyElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLBodyElement
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onorientationchange { get; set; }
}

///<include file='Utils/Docs/Console/Console.generated.xml' path='docs/Console/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class console
{
	///<include file='Utils/Docs/ConsoleAssert/ConsoleAssert.generated.xml' path='docs/ConsoleAssert/*'/>
	public Undefined Assert(bool condition, params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleClear/ConsoleClear.generated.xml' path='docs/ConsoleClear/*'/>
	public Undefined Clear() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleDebug/ConsoleDebug.generated.xml' path='docs/ConsoleDebug/*'/>
	public Undefined Debug(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleError/ConsoleError.generated.xml' path='docs/ConsoleError/*'/>
	public Undefined Error(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleInfo/ConsoleInfo.generated.xml' path='docs/ConsoleInfo/*'/>
	public Undefined Info(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleLog/ConsoleLog.generated.xml' path='docs/ConsoleLog/*'/>
	public Undefined Log(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleTable/ConsoleTable.generated.xml' path='docs/ConsoleTable/*'/>
	public Undefined Table(dynamic tabularData, List<string> properties) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleTrace/ConsoleTrace.generated.xml' path='docs/ConsoleTrace/*'/>
	public Undefined Trace(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleWarn/ConsoleWarn.generated.xml' path='docs/ConsoleWarn/*'/>
	public Undefined Warn(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleDir/ConsoleDir.generated.xml' path='docs/ConsoleDir/*'/>
	public Undefined Dir(dynamic item, object? options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleDirxml/ConsoleDirxml.generated.xml' path='docs/ConsoleDirxml/*'/>
	public Undefined Dirxml(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleCount/ConsoleCount.generated.xml' path='docs/ConsoleCount/*'/>
	public Undefined Count(string label) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleCountReset/ConsoleCountReset.generated.xml' path='docs/ConsoleCountReset/*'/>
	public Undefined CountReset(string label) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleGroup/ConsoleGroup.generated.xml' path='docs/ConsoleGroup/*'/>
	public Undefined Group(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleGroupCollapsed/ConsoleGroupCollapsed.generated.xml' path='docs/ConsoleGroupCollapsed/*'/>
	public Undefined GroupCollapsed(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleGroupEnd/ConsoleGroupEnd.generated.xml' path='docs/ConsoleGroupEnd/*'/>
	public Undefined GroupEnd() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleTime/ConsoleTime.generated.xml' path='docs/ConsoleTime/*'/>
	public Undefined Time(string label) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleTimeLog/ConsoleTimeLog.generated.xml' path='docs/ConsoleTimeLog/*'/>
	public Undefined TimeLog(string label, params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ConsoleTimeEnd/ConsoleTimeEnd.generated.xml' path='docs/ConsoleTimeEnd/*'/>
	public Undefined TimeEnd(string label) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Event/Event.generated.xml' path='docs/Event/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Event
{
	///<include file='Utils/Docs/EventEvent/EventEvent.generated.xml' path='docs/EventEvent/*'/>
	public Event(string type, EventInit eventInitDict) { }
	///<include file='Utils/Docs/EventType/EventType.generated.xml' path='docs/EventType/*'/>
	public string Type { get; }
	///<include file='Utils/Docs/EventTarget/EventTarget.generated.xml' path='docs/EventTarget/*'/>
	public EventTarget? Target { get; }
	///<include file='Utils/Docs/EventSrcElement/EventSrcElement.generated.xml' path='docs/EventSrcElement/*'/>
	public EventTarget? SrcElement { get; }
	///<include file='Utils/Docs/EventCurrentTarget/EventCurrentTarget.generated.xml' path='docs/EventCurrentTarget/*'/>
	public EventTarget? CurrentTarget { get; }
	///<include file='Utils/Docs/EventComposedPath/EventComposedPath.generated.xml' path='docs/EventComposedPath/*'/>
	public List<EventTarget> ComposedPath() { throw new System.NotImplementedException(); }
		public const ushort NONE = 0;
		public const ushort CAPTURING_PHASE = 1;
		public const ushort AT_TARGET = 2;
		public const ushort BUBBLING_PHASE = 3;
	///<include file='Utils/Docs/EventEventPhase/EventEventPhase.generated.xml' path='docs/EventEventPhase/*'/>
	public ushort EventPhase { get; }
	///<include file='Utils/Docs/EventStopPropagation/EventStopPropagation.generated.xml' path='docs/EventStopPropagation/*'/>
	public Undefined StopPropagation() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/EventCancelBubble/EventCancelBubble.generated.xml' path='docs/EventCancelBubble/*'/>
	public bool CancelBubble { get; set; }
	///<include file='Utils/Docs/EventStopImmediatePropagation/EventStopImmediatePropagation.generated.xml' path='docs/EventStopImmediatePropagation/*'/>
	public Undefined StopImmediatePropagation() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/EventBubbles/EventBubbles.generated.xml' path='docs/EventBubbles/*'/>
	public bool Bubbles { get; }
	///<include file='Utils/Docs/EventCancelable/EventCancelable.generated.xml' path='docs/EventCancelable/*'/>
	public bool Cancelable { get; }
	///<include file='Utils/Docs/EventReturnValue/EventReturnValue.generated.xml' path='docs/EventReturnValue/*'/>
	public bool ReturnValue { get; set; }
	///<include file='Utils/Docs/EventPreventDefault/EventPreventDefault.generated.xml' path='docs/EventPreventDefault/*'/>
	public Undefined PreventDefault() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/EventDefaultPrevented/EventDefaultPrevented.generated.xml' path='docs/EventDefaultPrevented/*'/>
	public bool DefaultPrevented { get; }
	///<include file='Utils/Docs/EventComposed/EventComposed.generated.xml' path='docs/EventComposed/*'/>
	public bool Composed { get; }
	///<include file='Utils/Docs/EventIsTrusted/EventIsTrusted.generated.xml' path='docs/EventIsTrusted/*'/>
	public bool IsTrusted { get; }
	///<include file='Utils/Docs/EventTimeStamp/EventTimeStamp.generated.xml' path='docs/EventTimeStamp/*'/>
	public Unsupported /*DOMHighResTimeStamp*/ TimeStamp { get; }
	///<include file='Utils/Docs/EventInitEvent/EventInitEvent.generated.xml' path='docs/EventInitEvent/*'/>
	public Undefined InitEvent(string type, bool bubbles, bool cancelable) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class EventInit
{
		public bool Bubbles;
		public bool Cancelable;
		public bool Composed;
}

///<include file='Utils/Docs/Window/Window.generated.xml' path='docs/Window/*'/>
public partial class Window
{
	///<include file='Utils/Docs/WindowEvent/WindowEvent.generated.xml' path='docs/WindowEvent/*'/>
	public Union0 Event { get; }
}

///<include file='Utils/Docs/CustomEvent/CustomEvent.generated.xml' path='docs/CustomEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CustomEvent : Event
{
	///<include file='Utils/Docs/CustomEventCustomEvent/CustomEventCustomEvent.generated.xml' path='docs/CustomEventCustomEvent/*'/>
	public CustomEvent(string type, CustomEventInit eventInitDict) { }
	///<include file='Utils/Docs/CustomEventDetail/CustomEventDetail.generated.xml' path='docs/CustomEventDetail/*'/>
	public dynamic Detail { get; }
	///<include file='Utils/Docs/CustomEventInitCustomEvent/CustomEventInitCustomEvent.generated.xml' path='docs/CustomEventInitCustomEvent/*'/>
	public Undefined InitCustomEvent(string type, bool bubbles, bool cancelable, dynamic detail) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CustomEventInit : EventInit
{
		public dynamic Detail;
}

///<include file='Utils/Docs/EventTarget/EventTarget.generated.xml' path='docs/EventTarget/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class EventTarget
{
	///<include file='Utils/Docs/EventTargetEventTarget/EventTargetEventTarget.generated.xml' path='docs/EventTargetEventTarget/*'/>
	public EventTarget() { }
	///<include file='Utils/Docs/EventTargetAddEventListener/EventTargetAddEventListener.generated.xml' path='docs/EventTargetAddEventListener/*'/>
	public Undefined AddEventListener(string type, EventListener? callback, Union1 options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/EventTargetRemoveEventListener/EventTargetRemoveEventListener.generated.xml' path='docs/EventTargetRemoveEventListener/*'/>
	public Undefined RemoveEventListener(string type, EventListener? callback, Union2 options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/EventTargetDispatchEvent/EventTargetDispatchEvent.generated.xml' path='docs/EventTargetDispatchEvent/*'/>
	public bool DispatchEvent(Event event_) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface EventListener
{
		public Undefined HandleEvent(Event event_) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class EventListenerOptions
{
		public bool Capture;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AddEventListenerOptions : EventListenerOptions
{
		public bool Passive;
		public bool Once;
		public AbortSignal Signal;
}

///<include file='Utils/Docs/AbortController/AbortController.generated.xml' path='docs/AbortController/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AbortController
{
	///<include file='Utils/Docs/AbortControllerAbortController/AbortControllerAbortController.generated.xml' path='docs/AbortControllerAbortController/*'/>
	public AbortController() { }
	///<include file='Utils/Docs/AbortControllerSignal/AbortControllerSignal.generated.xml' path='docs/AbortControllerSignal/*'/>
	public AbortSignal Signal { get; }
	///<include file='Utils/Docs/AbortControllerAbort/AbortControllerAbort.generated.xml' path='docs/AbortControllerAbort/*'/>
	public Undefined Abort(dynamic reason) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/AbortSignal/AbortSignal.generated.xml' path='docs/AbortSignal/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AbortSignal : EventTarget
{
		public static AbortSignal Abort(dynamic reason) { throw new System.NotImplementedException(); }
		public static AbortSignal Timeout(ulong milliseconds) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AbortSignalAborted/AbortSignalAborted.generated.xml' path='docs/AbortSignalAborted/*'/>
	public bool Aborted { get; }
	///<include file='Utils/Docs/AbortSignalReason/AbortSignalReason.generated.xml' path='docs/AbortSignalReason/*'/>
	public dynamic Reason { get; }
	///<include file='Utils/Docs/AbortSignalThrowIfAborted/AbortSignalThrowIfAborted.generated.xml' path='docs/AbortSignalThrowIfAborted/*'/>
	public Undefined ThrowIfAborted() { throw new System.NotImplementedException(); }
		public EventHandler Onabort { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NonElementParentNode
{
		public Element? GetElementById(string elementId) { throw new System.NotImplementedException(); }
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial interface DocumentOrShadowRoot
{
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial interface ParentNode
{
		public HTMLCollection Children { get { throw new System.NotImplementedException(); } }
		public Element? FirstElementChild { get { throw new System.NotImplementedException(); } }
		public Element? LastElementChild { get { throw new System.NotImplementedException(); } }
		public ulong ChildElementCount { get { throw new System.NotImplementedException(); } }
		public Undefined Prepend(params Union3[] nodes) { throw new System.NotImplementedException(); }
		public Undefined Append(params Union4[] nodes) { throw new System.NotImplementedException(); }
		public Undefined ReplaceChildren(params Union5[] nodes) { throw new System.NotImplementedException(); }
		public Element? QuerySelector(string selectors) { throw new System.NotImplementedException(); }
		public NodeList QuerySelectorAll(string selectors) { throw new System.NotImplementedException(); }
}




[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NonDocumentTypeChildNode
{
		public Element? PreviousElementSibling { get { throw new System.NotImplementedException(); } }
		public Element? NextElementSibling { get { throw new System.NotImplementedException(); } }
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial interface ChildNode
{
		public Undefined Before(params Union6[] nodes) { throw new System.NotImplementedException(); }
		public Undefined After(params Union7[] nodes) { throw new System.NotImplementedException(); }
		public Undefined ReplaceWith(params Union8[] nodes) { throw new System.NotImplementedException(); }
		public Undefined Remove() { throw new System.NotImplementedException(); }
}




[To(ToAttribute.FirstCharToLowerCase)]
public partial interface Slottable
{
		public HTMLSlotElement? AssignedSlot { get { throw new System.NotImplementedException(); } }
}



///<include file='Utils/Docs/NodeList/NodeList.generated.xml' path='docs/NodeList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class NodeList
{
	
	///<include file='Utils/Docs/NodeListLength/NodeListLength.generated.xml' path='docs/NodeListLength/*'/>
	public ulong Length { get; }
	public Node this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
}

///<include file='Utils/Docs/HTMLCollection/HTMLCollection.generated.xml' path='docs/HTMLCollection/*'/>
[To(ToAttribute.Default)]
public partial class HTMLCollection
{
	///<include file='Utils/Docs/HTMLCollectionLength/HTMLCollectionLength.generated.xml' path='docs/HTMLCollectionLength/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Length { get; }
	
	
}

///<include file='Utils/Docs/MutationObserver/MutationObserver.generated.xml' path='docs/MutationObserver/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MutationObserver
{
	///<include file='Utils/Docs/MutationObserverMutationObserver/MutationObserverMutationObserver.generated.xml' path='docs/MutationObserverMutationObserver/*'/>
	public MutationObserver(MutationCallback callback) { }
	///<include file='Utils/Docs/MutationObserverObserve/MutationObserverObserve.generated.xml' path='docs/MutationObserverObserve/*'/>
	public Undefined Observe(Node target, MutationObserverInit options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MutationObserverDisconnect/MutationObserverDisconnect.generated.xml' path='docs/MutationObserverDisconnect/*'/>
	public Undefined Disconnect() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MutationObserverTakeRecords/MutationObserverTakeRecords.generated.xml' path='docs/MutationObserverTakeRecords/*'/>
	public List<MutationRecord> TakeRecords() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct MutationCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MutationObserverInit
{
		public bool ChildList;
		public bool Attributes;
		public bool CharacterData;
		public bool Subtree;
		public bool AttributeOldValue;
		public bool CharacterDataOldValue;
		public List<string> AttributeFilter;
}

///<include file='Utils/Docs/MutationRecord/MutationRecord.generated.xml' path='docs/MutationRecord/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MutationRecord
{
	///<include file='Utils/Docs/MutationRecordType/MutationRecordType.generated.xml' path='docs/MutationRecordType/*'/>
	public string Type { get; }
	///<include file='Utils/Docs/MutationRecordTarget/MutationRecordTarget.generated.xml' path='docs/MutationRecordTarget/*'/>
	public Node Target { get; }
	///<include file='Utils/Docs/MutationRecordAddedNodes/MutationRecordAddedNodes.generated.xml' path='docs/MutationRecordAddedNodes/*'/>
	public NodeList AddedNodes { get; }
	///<include file='Utils/Docs/MutationRecordRemovedNodes/MutationRecordRemovedNodes.generated.xml' path='docs/MutationRecordRemovedNodes/*'/>
	public NodeList RemovedNodes { get; }
	///<include file='Utils/Docs/MutationRecordPreviousSibling/MutationRecordPreviousSibling.generated.xml' path='docs/MutationRecordPreviousSibling/*'/>
	public Node? PreviousSibling { get; }
	///<include file='Utils/Docs/MutationRecordNextSibling/MutationRecordNextSibling.generated.xml' path='docs/MutationRecordNextSibling/*'/>
	public Node? NextSibling { get; }
	///<include file='Utils/Docs/MutationRecordAttributeName/MutationRecordAttributeName.generated.xml' path='docs/MutationRecordAttributeName/*'/>
	public string? AttributeName { get; }
	///<include file='Utils/Docs/MutationRecordAttributeNamespace/MutationRecordAttributeNamespace.generated.xml' path='docs/MutationRecordAttributeNamespace/*'/>
	public string? AttributeNamespace { get; }
	///<include file='Utils/Docs/MutationRecordOldValue/MutationRecordOldValue.generated.xml' path='docs/MutationRecordOldValue/*'/>
	public string? OldValue { get; }
}

///<include file='Utils/Docs/Node/Node.generated.xml' path='docs/Node/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Node : EventTarget
{
		public const ushort ELEMENT_NODE = 1;
		public const ushort ATTRIBUTE_NODE = 2;
		public const ushort TEXT_NODE = 3;
		public const ushort CDATA_SECTION_NODE = 4;
		public const ushort ENTITY_REFERENCE_NODE = 5;
		public const ushort ENTITY_NODE = 6;
		public const ushort PROCESSING_INSTRUCTION_NODE = 7;
		public const ushort COMMENT_NODE = 8;
		public const ushort DOCUMENT_NODE = 9;
		public const ushort DOCUMENT_TYPE_NODE = 10;
		public const ushort DOCUMENT_FRAGMENT_NODE = 11;
		public const ushort NOTATION_NODE = 12;
	///<include file='Utils/Docs/NodeNodeType/NodeNodeType.generated.xml' path='docs/NodeNodeType/*'/>
	public ushort NodeType { get; }
	///<include file='Utils/Docs/NodeNodeName/NodeNodeName.generated.xml' path='docs/NodeNodeName/*'/>
	public string NodeName { get; }
	///<include file='Utils/Docs/NodeBaseURI/NodeBaseURI.generated.xml' path='docs/NodeBaseURI/*'/>
	public string BaseURI { get; }
	///<include file='Utils/Docs/NodeIsConnected/NodeIsConnected.generated.xml' path='docs/NodeIsConnected/*'/>
	public bool IsConnected { get; }
	///<include file='Utils/Docs/NodeOwnerDocument/NodeOwnerDocument.generated.xml' path='docs/NodeOwnerDocument/*'/>
	public Document? OwnerDocument { get; }
	///<include file='Utils/Docs/NodeGetRootNode/NodeGetRootNode.generated.xml' path='docs/NodeGetRootNode/*'/>
	public Node GetRootNode(GetRootNodeOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeParentNode/NodeParentNode.generated.xml' path='docs/NodeParentNode/*'/>
	public Node? ParentNode { get; }
	///<include file='Utils/Docs/NodeParentElement/NodeParentElement.generated.xml' path='docs/NodeParentElement/*'/>
	public Element? ParentElement { get; }
	///<include file='Utils/Docs/NodeHasChildNodes/NodeHasChildNodes.generated.xml' path='docs/NodeHasChildNodes/*'/>
	public bool HasChildNodes() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeChildNodes/NodeChildNodes.generated.xml' path='docs/NodeChildNodes/*'/>
	public NodeList ChildNodes { get; }
	///<include file='Utils/Docs/NodeFirstChild/NodeFirstChild.generated.xml' path='docs/NodeFirstChild/*'/>
	public Node? FirstChild { get; }
	///<include file='Utils/Docs/NodeLastChild/NodeLastChild.generated.xml' path='docs/NodeLastChild/*'/>
	public Node? LastChild { get; }
	///<include file='Utils/Docs/NodePreviousSibling/NodePreviousSibling.generated.xml' path='docs/NodePreviousSibling/*'/>
	public Node? PreviousSibling { get; }
	///<include file='Utils/Docs/NodeNextSibling/NodeNextSibling.generated.xml' path='docs/NodeNextSibling/*'/>
	public Node? NextSibling { get; }
	///<include file='Utils/Docs/NodeNodeValue/NodeNodeValue.generated.xml' path='docs/NodeNodeValue/*'/>
	public string? NodeValue { get; set; }
	///<include file='Utils/Docs/NodeTextContent/NodeTextContent.generated.xml' path='docs/NodeTextContent/*'/>
	public string? TextContent { get; set; }
	///<include file='Utils/Docs/NodeNormalize/NodeNormalize.generated.xml' path='docs/NodeNormalize/*'/>
	public Undefined Normalize() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeCloneNode/NodeCloneNode.generated.xml' path='docs/NodeCloneNode/*'/>
	public Node CloneNode(bool deep) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeIsEqualNode/NodeIsEqualNode.generated.xml' path='docs/NodeIsEqualNode/*'/>
	public bool IsEqualNode(Node? otherNode) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeIsSameNode/NodeIsSameNode.generated.xml' path='docs/NodeIsSameNode/*'/>
	public bool IsSameNode(Node? otherNode) { throw new System.NotImplementedException(); }
		public const ushort DOCUMENT_POSITION_DISCONNECTED = 0x01;
		public const ushort DOCUMENT_POSITION_PRECEDING = 0x02;
		public const ushort DOCUMENT_POSITION_FOLLOWING = 0x04;
		public const ushort DOCUMENT_POSITION_CONTAINS = 0x08;
		public const ushort DOCUMENT_POSITION_CONTAINED_BY = 0x10;
		public const ushort DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC = 0x20;
	///<include file='Utils/Docs/NodeCompareDocumentPosition/NodeCompareDocumentPosition.generated.xml' path='docs/NodeCompareDocumentPosition/*'/>
	public ushort CompareDocumentPosition(Node other) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeContains/NodeContains.generated.xml' path='docs/NodeContains/*'/>
	public bool Contains(Node? other) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeLookupPrefix/NodeLookupPrefix.generated.xml' path='docs/NodeLookupPrefix/*'/>
	public string? LookupPrefix(string? namespace_) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeLookupNamespaceURI/NodeLookupNamespaceURI.generated.xml' path='docs/NodeLookupNamespaceURI/*'/>
	public string? LookupNamespaceURI(string? prefix) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeIsDefaultNamespace/NodeIsDefaultNamespace.generated.xml' path='docs/NodeIsDefaultNamespace/*'/>
	public bool IsDefaultNamespace(string? namespace_) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeInsertBefore/NodeInsertBefore.generated.xml' path='docs/NodeInsertBefore/*'/>
	public Node InsertBefore(Node node, Node? child) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeAppendChild/NodeAppendChild.generated.xml' path='docs/NodeAppendChild/*'/>
	public Node AppendChild(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeReplaceChild/NodeReplaceChild.generated.xml' path='docs/NodeReplaceChild/*'/>
	public Node ReplaceChild(Node node, Node child) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeRemoveChild/NodeRemoveChild.generated.xml' path='docs/NodeRemoveChild/*'/>
	public Node RemoveChild(Node child) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GetRootNodeOptions
{
		public bool Composed;
}

///<include file='Utils/Docs/DOMImplementation/DOMImplementation.generated.xml' path='docs/DOMImplementation/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMImplementation
{
	///<include file='Utils/Docs/DOMImplementationCreateDocumentType/DOMImplementationCreateDocumentType.generated.xml' path='docs/DOMImplementationCreateDocumentType/*'/>
	public DocumentType CreateDocumentType(string qualifiedName, string publicId, string systemId) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMImplementationCreateDocument/DOMImplementationCreateDocument.generated.xml' path='docs/DOMImplementationCreateDocument/*'/>
	public Unsupported /*XMLDocument*/ CreateDocument(string? namespace_, string qualifiedName, DocumentType? doctype) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMImplementationCreateHTMLDocument/DOMImplementationCreateHTMLDocument.generated.xml' path='docs/DOMImplementationCreateHTMLDocument/*'/>
	public Document CreateHTMLDocument(string title) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMImplementationHasFeature/DOMImplementationHasFeature.generated.xml' path='docs/DOMImplementationHasFeature/*'/>
	public bool HasFeature() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/DocumentType/DocumentType.generated.xml' path='docs/DocumentType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DocumentType : Node, ChildNode
{
	///<include file='Utils/Docs/DocumentTypeName/DocumentTypeName.generated.xml' path='docs/DocumentTypeName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs/DocumentTypePublicId/DocumentTypePublicId.generated.xml' path='docs/DocumentTypePublicId/*'/>
	public string PublicId { get; }
	///<include file='Utils/Docs/DocumentTypeSystemId/DocumentTypeSystemId.generated.xml' path='docs/DocumentTypeSystemId/*'/>
	public string SystemId { get; }
}

///<include file='Utils/Docs/DocumentFragment/DocumentFragment.generated.xml' path='docs/DocumentFragment/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DocumentFragment : Node, NonElementParentNode, ParentNode
{
	///<include file='Utils/Docs/DocumentFragmentDocumentFragment/DocumentFragmentDocumentFragment.generated.xml' path='docs/DocumentFragmentDocumentFragment/*'/>
	public DocumentFragment() { }
}

///<include file='Utils/Docs/ShadowRoot/ShadowRoot.generated.xml' path='docs/ShadowRoot/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ShadowRoot : DocumentFragment, DocumentOrShadowRoot
{
	///<include file='Utils/Docs/ShadowRootMode/ShadowRootMode.generated.xml' path='docs/ShadowRootMode/*'/>
	public ShadowRootMode Mode { get; }
	///<include file='Utils/Docs/ShadowRootDelegatesFocus/ShadowRootDelegatesFocus.generated.xml' path='docs/ShadowRootDelegatesFocus/*'/>
	public bool DelegatesFocus { get; }
	///<include file='Utils/Docs/ShadowRootSlotAssignment/ShadowRootSlotAssignment.generated.xml' path='docs/ShadowRootSlotAssignment/*'/>
	public SlotAssignmentMode SlotAssignment { get; }
	///<include file='Utils/Docs/ShadowRootHost/ShadowRootHost.generated.xml' path='docs/ShadowRootHost/*'/>
	public Element Host { get; }
		public EventHandler Onslotchange { get; set; }
}

///<include file='Utils/Docs/ShadowRootMode/ShadowRootMode.generated.xml' path='docs/ShadowRootMode/*'/>
public enum ShadowRootMode
{
	Open,
	Closed,
}

public enum SlotAssignmentMode
{
	Manual,
	Named,
}

///<include file='Utils/Docs/Element/Element.generated.xml' path='docs/Element/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Element : Node, ParentNode, NonDocumentTypeChildNode, ChildNode, Slottable
{
	///<include file='Utils/Docs/ElementNamespaceURI/ElementNamespaceURI.generated.xml' path='docs/ElementNamespaceURI/*'/>
	public string? NamespaceURI { get; }
	///<include file='Utils/Docs/ElementPrefix/ElementPrefix.generated.xml' path='docs/ElementPrefix/*'/>
	public string? Prefix { get; }
	///<include file='Utils/Docs/ElementLocalName/ElementLocalName.generated.xml' path='docs/ElementLocalName/*'/>
	public string LocalName { get; }
	///<include file='Utils/Docs/ElementTagName/ElementTagName.generated.xml' path='docs/ElementTagName/*'/>
	public string TagName { get; }
	///<include file='Utils/Docs/ElementId/ElementId.generated.xml' path='docs/ElementId/*'/>
	public string Id { get; set; }
	///<include file='Utils/Docs/ElementClassName/ElementClassName.generated.xml' path='docs/ElementClassName/*'/>
	public string ClassName { get; set; }
	///<include file='Utils/Docs/ElementClassList/ElementClassList.generated.xml' path='docs/ElementClassList/*'/>
	public DOMTokenList ClassList { get; }
	///<include file='Utils/Docs/ElementSlot/ElementSlot.generated.xml' path='docs/ElementSlot/*'/>
	public string Slot { get; set; }
	///<include file='Utils/Docs/ElementHasAttributes/ElementHasAttributes.generated.xml' path='docs/ElementHasAttributes/*'/>
	public bool HasAttributes() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementAttributes/ElementAttributes.generated.xml' path='docs/ElementAttributes/*'/>
	public NamedNodeMap Attributes { get; }
	///<include file='Utils/Docs/ElementGetAttributeNames/ElementGetAttributeNames.generated.xml' path='docs/ElementGetAttributeNames/*'/>
	public List<string> GetAttributeNames() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementGetAttribute/ElementGetAttribute.generated.xml' path='docs/ElementGetAttribute/*'/>
	public string? GetAttribute(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementGetAttributeNS/ElementGetAttributeNS.generated.xml' path='docs/ElementGetAttributeNS/*'/>
	public string? GetAttributeNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementSetAttribute/ElementSetAttribute.generated.xml' path='docs/ElementSetAttribute/*'/>
	public Undefined SetAttribute(string qualifiedName, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementSetAttributeNS/ElementSetAttributeNS.generated.xml' path='docs/ElementSetAttributeNS/*'/>
	public Undefined SetAttributeNS(string? namespace_, string qualifiedName, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementRemoveAttribute/ElementRemoveAttribute.generated.xml' path='docs/ElementRemoveAttribute/*'/>
	public Undefined RemoveAttribute(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementRemoveAttributeNS/ElementRemoveAttributeNS.generated.xml' path='docs/ElementRemoveAttributeNS/*'/>
	public Undefined RemoveAttributeNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementToggleAttribute/ElementToggleAttribute.generated.xml' path='docs/ElementToggleAttribute/*'/>
	public bool ToggleAttribute(string qualifiedName, bool force) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementHasAttribute/ElementHasAttribute.generated.xml' path='docs/ElementHasAttribute/*'/>
	public bool HasAttribute(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementHasAttributeNS/ElementHasAttributeNS.generated.xml' path='docs/ElementHasAttributeNS/*'/>
	public bool HasAttributeNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementGetAttributeNode/ElementGetAttributeNode.generated.xml' path='docs/ElementGetAttributeNode/*'/>
	public Attr? GetAttributeNode(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementGetAttributeNodeNS/ElementGetAttributeNodeNS.generated.xml' path='docs/ElementGetAttributeNodeNS/*'/>
	public Attr? GetAttributeNodeNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementSetAttributeNode/ElementSetAttributeNode.generated.xml' path='docs/ElementSetAttributeNode/*'/>
	public Attr? SetAttributeNode(Attr attr) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementSetAttributeNodeNS/ElementSetAttributeNodeNS.generated.xml' path='docs/ElementSetAttributeNodeNS/*'/>
	public Attr? SetAttributeNodeNS(Attr attr) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementRemoveAttributeNode/ElementRemoveAttributeNode.generated.xml' path='docs/ElementRemoveAttributeNode/*'/>
	public Attr RemoveAttributeNode(Attr attr) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementAttachShadow/ElementAttachShadow.generated.xml' path='docs/ElementAttachShadow/*'/>
	public ShadowRoot AttachShadow(ShadowRootInit init) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementShadowRoot/ElementShadowRoot.generated.xml' path='docs/ElementShadowRoot/*'/>
	public ShadowRoot? ShadowRoot { get; }
	///<include file='Utils/Docs/ElementClosest/ElementClosest.generated.xml' path='docs/ElementClosest/*'/>
	public Element? Closest(string selectors) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementMatches/ElementMatches.generated.xml' path='docs/ElementMatches/*'/>
	public bool Matches(string selectors) { throw new System.NotImplementedException(); }
		public bool WebkitMatchesSelector(string selectors) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementGetElementsByTagName/ElementGetElementsByTagName.generated.xml' path='docs/ElementGetElementsByTagName/*'/>
	public HTMLCollection GetElementsByTagName(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementGetElementsByTagNameNS/ElementGetElementsByTagNameNS.generated.xml' path='docs/ElementGetElementsByTagNameNS/*'/>
	public HTMLCollection GetElementsByTagNameNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementGetElementsByClassName/ElementGetElementsByClassName.generated.xml' path='docs/ElementGetElementsByClassName/*'/>
	public HTMLCollection GetElementsByClassName(string classNames) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementInsertAdjacentElement/ElementInsertAdjacentElement.generated.xml' path='docs/ElementInsertAdjacentElement/*'/>
	public Element? InsertAdjacentElement(string where, Element element) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementInsertAdjacentText/ElementInsertAdjacentText.generated.xml' path='docs/ElementInsertAdjacentText/*'/>
	public Undefined InsertAdjacentText(string where, string data) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ShadowRootInit
{
		public required ShadowRootMode Mode;
		public bool DelegatesFocus;
		public SlotAssignmentMode SlotAssignment;
}

///<include file='Utils/Docs/NamedNodeMap/NamedNodeMap.generated.xml' path='docs/NamedNodeMap/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class NamedNodeMap
{
	///<include file='Utils/Docs/NamedNodeMapLength/NamedNodeMapLength.generated.xml' path='docs/NamedNodeMapLength/*'/>
	public ulong Length { get; }
	
	
	///<include file='Utils/Docs/NamedNodeMapGetNamedItemNS/NamedNodeMapGetNamedItemNS.generated.xml' path='docs/NamedNodeMapGetNamedItemNS/*'/>
	public Attr? GetNamedItemNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NamedNodeMapSetNamedItem/NamedNodeMapSetNamedItem.generated.xml' path='docs/NamedNodeMapSetNamedItem/*'/>
	public Attr? SetNamedItem(Attr attr) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NamedNodeMapSetNamedItemNS/NamedNodeMapSetNamedItemNS.generated.xml' path='docs/NamedNodeMapSetNamedItemNS/*'/>
	public Attr? SetNamedItemNS(Attr attr) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NamedNodeMapRemoveNamedItem/NamedNodeMapRemoveNamedItem.generated.xml' path='docs/NamedNodeMapRemoveNamedItem/*'/>
	public Attr RemoveNamedItem(string qualifiedName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NamedNodeMapRemoveNamedItemNS/NamedNodeMapRemoveNamedItemNS.generated.xml' path='docs/NamedNodeMapRemoveNamedItemNS/*'/>
	public Attr RemoveNamedItemNS(string? namespace_, string localName) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Attr/Attr.generated.xml' path='docs/Attr/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Attr : Node
{
	///<include file='Utils/Docs/AttrNamespaceURI/AttrNamespaceURI.generated.xml' path='docs/AttrNamespaceURI/*'/>
	public string? NamespaceURI { get; }
	///<include file='Utils/Docs/AttrPrefix/AttrPrefix.generated.xml' path='docs/AttrPrefix/*'/>
	public string? Prefix { get; }
	///<include file='Utils/Docs/AttrLocalName/AttrLocalName.generated.xml' path='docs/AttrLocalName/*'/>
	public string LocalName { get; }
	///<include file='Utils/Docs/AttrName/AttrName.generated.xml' path='docs/AttrName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs/AttrValue/AttrValue.generated.xml' path='docs/AttrValue/*'/>
	public string Value { get; set; }
	///<include file='Utils/Docs/AttrOwnerElement/AttrOwnerElement.generated.xml' path='docs/AttrOwnerElement/*'/>
	public Element? OwnerElement { get; }
	///<include file='Utils/Docs/AttrSpecified/AttrSpecified.generated.xml' path='docs/AttrSpecified/*'/>
	public bool Specified { get; }
}

///<include file='Utils/Docs/CharacterData/CharacterData.generated.xml' path='docs/CharacterData/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CharacterData : Node, NonDocumentTypeChildNode, ChildNode
{
	///<include file='Utils/Docs/CharacterDataData/CharacterDataData.generated.xml' path='docs/CharacterDataData/*'/>
	public string Data { get; set; }
	///<include file='Utils/Docs/CharacterDataLength/CharacterDataLength.generated.xml' path='docs/CharacterDataLength/*'/>
	public ulong Length { get; }
	///<include file='Utils/Docs/CharacterDataSubstringData/CharacterDataSubstringData.generated.xml' path='docs/CharacterDataSubstringData/*'/>
	public string SubstringData(ulong offset, ulong count) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CharacterDataAppendData/CharacterDataAppendData.generated.xml' path='docs/CharacterDataAppendData/*'/>
	public Undefined AppendData(string data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CharacterDataInsertData/CharacterDataInsertData.generated.xml' path='docs/CharacterDataInsertData/*'/>
	public Undefined InsertData(ulong offset, string data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CharacterDataDeleteData/CharacterDataDeleteData.generated.xml' path='docs/CharacterDataDeleteData/*'/>
	public Undefined DeleteData(ulong offset, ulong count) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CharacterDataReplaceData/CharacterDataReplaceData.generated.xml' path='docs/CharacterDataReplaceData/*'/>
	public Undefined ReplaceData(ulong offset, ulong count, string data) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Text/Text.generated.xml' path='docs/Text/*'/>
[To(ToAttribute.Default)]
public partial class Text : CharacterData, Slottable
{
	///<include file='Utils/Docs/TextText/TextText.generated.xml' path='docs/TextText/*'/>
	public Text(string data) { }
	///<include file='Utils/Docs/TextSplitText/TextSplitText.generated.xml' path='docs/TextSplitText/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Text SplitText(ulong offset) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TextWholeText/TextWholeText.generated.xml' path='docs/TextWholeText/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string WholeText { get; }
}

///<include file='Utils/Docs/CDATASection/CDATASection.generated.xml' path='docs/CDATASection/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CDATASection : Text
{
}

///<include file='Utils/Docs/ProcessingInstruction/ProcessingInstruction.generated.xml' path='docs/ProcessingInstruction/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ProcessingInstruction : CharacterData
{
	///<include file='Utils/Docs/ProcessingInstructionTarget/ProcessingInstructionTarget.generated.xml' path='docs/ProcessingInstructionTarget/*'/>
	public string Target { get; }
}

///<include file='Utils/Docs/Comment/Comment.generated.xml' path='docs/Comment/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Comment : CharacterData
{
	///<include file='Utils/Docs/CommentComment/CommentComment.generated.xml' path='docs/CommentComment/*'/>
	public Comment(string data) { }
}

///<include file='Utils/Docs/AbstractRange/AbstractRange.generated.xml' path='docs/AbstractRange/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AbstractRange
{
	///<include file='Utils/Docs/AbstractRangeStartContainer/AbstractRangeStartContainer.generated.xml' path='docs/AbstractRangeStartContainer/*'/>
	public Node StartContainer { get; }
	///<include file='Utils/Docs/AbstractRangeStartOffset/AbstractRangeStartOffset.generated.xml' path='docs/AbstractRangeStartOffset/*'/>
	public ulong StartOffset { get; }
	///<include file='Utils/Docs/AbstractRangeEndContainer/AbstractRangeEndContainer.generated.xml' path='docs/AbstractRangeEndContainer/*'/>
	public Node EndContainer { get; }
	///<include file='Utils/Docs/AbstractRangeEndOffset/AbstractRangeEndOffset.generated.xml' path='docs/AbstractRangeEndOffset/*'/>
	public ulong EndOffset { get; }
	///<include file='Utils/Docs/AbstractRangeCollapsed/AbstractRangeCollapsed.generated.xml' path='docs/AbstractRangeCollapsed/*'/>
	public bool Collapsed { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class StaticRangeInit
{
		public required Node StartContainer;
		public required ulong StartOffset;
		public required Node EndContainer;
		public required ulong EndOffset;
}

///<include file='Utils/Docs/StaticRange/StaticRange.generated.xml' path='docs/StaticRange/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class StaticRange : AbstractRange
{
	///<include file='Utils/Docs/StaticRangeStaticRange/StaticRangeStaticRange.generated.xml' path='docs/StaticRangeStaticRange/*'/>
	public StaticRange(StaticRangeInit init) { }
}

///<include file='Utils/Docs/Range/Range.generated.xml' path='docs/Range/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Range : AbstractRange
{
	///<include file='Utils/Docs/RangeRange/RangeRange.generated.xml' path='docs/RangeRange/*'/>
	public Range() { }
	///<include file='Utils/Docs/RangeCommonAncestorContainer/RangeCommonAncestorContainer.generated.xml' path='docs/RangeCommonAncestorContainer/*'/>
	public Node CommonAncestorContainer { get; }
	///<include file='Utils/Docs/RangeSetStart/RangeSetStart.generated.xml' path='docs/RangeSetStart/*'/>
	public Undefined SetStart(Node node, ulong offset) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeSetEnd/RangeSetEnd.generated.xml' path='docs/RangeSetEnd/*'/>
	public Undefined SetEnd(Node node, ulong offset) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeSetStartBefore/RangeSetStartBefore.generated.xml' path='docs/RangeSetStartBefore/*'/>
	public Undefined SetStartBefore(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeSetStartAfter/RangeSetStartAfter.generated.xml' path='docs/RangeSetStartAfter/*'/>
	public Undefined SetStartAfter(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeSetEndBefore/RangeSetEndBefore.generated.xml' path='docs/RangeSetEndBefore/*'/>
	public Undefined SetEndBefore(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeSetEndAfter/RangeSetEndAfter.generated.xml' path='docs/RangeSetEndAfter/*'/>
	public Undefined SetEndAfter(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeCollapse/RangeCollapse.generated.xml' path='docs/RangeCollapse/*'/>
	public Undefined Collapse(bool toStart) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeSelectNode/RangeSelectNode.generated.xml' path='docs/RangeSelectNode/*'/>
	public Undefined SelectNode(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeSelectNodeContents/RangeSelectNodeContents.generated.xml' path='docs/RangeSelectNodeContents/*'/>
	public Undefined SelectNodeContents(Node node) { throw new System.NotImplementedException(); }
		public const ushort START_TO_START = 0;
		public const ushort START_TO_END = 1;
		public const ushort END_TO_END = 2;
		public const ushort END_TO_START = 3;
	///<include file='Utils/Docs/RangeCompareBoundaryPoints/RangeCompareBoundaryPoints.generated.xml' path='docs/RangeCompareBoundaryPoints/*'/>
	public short CompareBoundaryPoints(ushort how, Range sourceRange) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeDeleteContents/RangeDeleteContents.generated.xml' path='docs/RangeDeleteContents/*'/>
	public Undefined DeleteContents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeExtractContents/RangeExtractContents.generated.xml' path='docs/RangeExtractContents/*'/>
	public DocumentFragment ExtractContents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeCloneContents/RangeCloneContents.generated.xml' path='docs/RangeCloneContents/*'/>
	public DocumentFragment CloneContents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeInsertNode/RangeInsertNode.generated.xml' path='docs/RangeInsertNode/*'/>
	public Undefined InsertNode(Node node) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeSurroundContents/RangeSurroundContents.generated.xml' path='docs/RangeSurroundContents/*'/>
	public Undefined SurroundContents(Node newParent) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeCloneRange/RangeCloneRange.generated.xml' path='docs/RangeCloneRange/*'/>
	public Range CloneRange() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeDetach/RangeDetach.generated.xml' path='docs/RangeDetach/*'/>
	public Undefined Detach() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeIsPointInRange/RangeIsPointInRange.generated.xml' path='docs/RangeIsPointInRange/*'/>
	public bool IsPointInRange(Node node, ulong offset) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeComparePoint/RangeComparePoint.generated.xml' path='docs/RangeComparePoint/*'/>
	public short ComparePoint(Node node, ulong offset) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/RangeIntersectsNode/RangeIntersectsNode.generated.xml' path='docs/RangeIntersectsNode/*'/>
	public bool IntersectsNode(Node node) { throw new System.NotImplementedException(); }
	
}

///<include file='Utils/Docs/NodeIterator/NodeIterator.generated.xml' path='docs/NodeIterator/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class NodeIterator
{
	///<include file='Utils/Docs/NodeIteratorRoot/NodeIteratorRoot.generated.xml' path='docs/NodeIteratorRoot/*'/>
	public Node Root { get; }
	///<include file='Utils/Docs/NodeIteratorReferenceNode/NodeIteratorReferenceNode.generated.xml' path='docs/NodeIteratorReferenceNode/*'/>
	public Node ReferenceNode { get; }
	///<include file='Utils/Docs/NodeIteratorPointerBeforeReferenceNode/NodeIteratorPointerBeforeReferenceNode.generated.xml' path='docs/NodeIteratorPointerBeforeReferenceNode/*'/>
	public bool PointerBeforeReferenceNode { get; }
	///<include file='Utils/Docs/NodeIteratorWhatToShow/NodeIteratorWhatToShow.generated.xml' path='docs/NodeIteratorWhatToShow/*'/>
	public ulong WhatToShow { get; }
	///<include file='Utils/Docs/NodeIteratorFilter/NodeIteratorFilter.generated.xml' path='docs/NodeIteratorFilter/*'/>
	public NodeFilter? Filter { get; }
	///<include file='Utils/Docs/NodeIteratorNextNode/NodeIteratorNextNode.generated.xml' path='docs/NodeIteratorNextNode/*'/>
	public Node? NextNode() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeIteratorPreviousNode/NodeIteratorPreviousNode.generated.xml' path='docs/NodeIteratorPreviousNode/*'/>
	public Node? PreviousNode() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NodeIteratorDetach/NodeIteratorDetach.generated.xml' path='docs/NodeIteratorDetach/*'/>
	public Undefined Detach() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/TreeWalker/TreeWalker.generated.xml' path='docs/TreeWalker/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class TreeWalker
{
	///<include file='Utils/Docs/TreeWalkerRoot/TreeWalkerRoot.generated.xml' path='docs/TreeWalkerRoot/*'/>
	public Node Root { get; }
	///<include file='Utils/Docs/TreeWalkerWhatToShow/TreeWalkerWhatToShow.generated.xml' path='docs/TreeWalkerWhatToShow/*'/>
	public ulong WhatToShow { get; }
	///<include file='Utils/Docs/TreeWalkerFilter/TreeWalkerFilter.generated.xml' path='docs/TreeWalkerFilter/*'/>
	public NodeFilter? Filter { get; }
	///<include file='Utils/Docs/TreeWalkerCurrentNode/TreeWalkerCurrentNode.generated.xml' path='docs/TreeWalkerCurrentNode/*'/>
	public Node CurrentNode { get; set; }
	///<include file='Utils/Docs/TreeWalkerParentNode/TreeWalkerParentNode.generated.xml' path='docs/TreeWalkerParentNode/*'/>
	public Node? ParentNode() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TreeWalkerFirstChild/TreeWalkerFirstChild.generated.xml' path='docs/TreeWalkerFirstChild/*'/>
	public Node? FirstChild() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TreeWalkerLastChild/TreeWalkerLastChild.generated.xml' path='docs/TreeWalkerLastChild/*'/>
	public Node? LastChild() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TreeWalkerPreviousSibling/TreeWalkerPreviousSibling.generated.xml' path='docs/TreeWalkerPreviousSibling/*'/>
	public Node? PreviousSibling() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TreeWalkerNextSibling/TreeWalkerNextSibling.generated.xml' path='docs/TreeWalkerNextSibling/*'/>
	public Node? NextSibling() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TreeWalkerPreviousNode/TreeWalkerPreviousNode.generated.xml' path='docs/TreeWalkerPreviousNode/*'/>
	public Node? PreviousNode() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TreeWalkerNextNode/TreeWalkerNextNode.generated.xml' path='docs/TreeWalkerNextNode/*'/>
	public Node? NextNode() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NodeFilter
{
		public const ushort FILTER_ACCEPT = 1;
		public const ushort FILTER_REJECT = 2;
		public const ushort FILTER_SKIP = 3;
		public const ulong SHOW_ALL = 0xFFFFFFFF;
		public const ulong SHOW_ELEMENT = 0x1;
		public const ulong SHOW_ATTRIBUTE = 0x2;
		public const ulong SHOW_TEXT = 0x4;
		public const ulong SHOW_CDATA_SECTION = 0x8;
		public const ulong SHOW_ENTITY_REFERENCE = 0x10;
		public const ulong SHOW_ENTITY = 0x20;
		public const ulong SHOW_PROCESSING_INSTRUCTION = 0x40;
		public const ulong SHOW_COMMENT = 0x80;
		public const ulong SHOW_DOCUMENT = 0x100;
		public const ulong SHOW_DOCUMENT_TYPE = 0x200;
		public const ulong SHOW_DOCUMENT_FRAGMENT = 0x400;
		public const ulong SHOW_NOTATION = 0x800;
		public ushort AcceptNode(Node node) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/DOMTokenList/DOMTokenList.generated.xml' path='docs/DOMTokenList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMTokenList
{
	///<include file='Utils/Docs/DOMTokenListLength/DOMTokenListLength.generated.xml' path='docs/DOMTokenListLength/*'/>
	public ulong Length { get; }
	
	///<include file='Utils/Docs/DOMTokenListContains/DOMTokenListContains.generated.xml' path='docs/DOMTokenListContains/*'/>
	public bool Contains(string token) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMTokenListAdd/DOMTokenListAdd.generated.xml' path='docs/DOMTokenListAdd/*'/>
	public Undefined Add(params string[] tokens) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMTokenListRemove/DOMTokenListRemove.generated.xml' path='docs/DOMTokenListRemove/*'/>
	public Undefined Remove(params string[] tokens) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMTokenListToggle/DOMTokenListToggle.generated.xml' path='docs/DOMTokenListToggle/*'/>
	public bool Toggle(string token, bool force) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMTokenListReplace/DOMTokenListReplace.generated.xml' path='docs/DOMTokenListReplace/*'/>
	public bool Replace(string token, string newToken) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMTokenListSupports/DOMTokenListSupports.generated.xml' path='docs/DOMTokenListSupports/*'/>
	public bool Supports(string token) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DOMTokenListValue/DOMTokenListValue.generated.xml' path='docs/DOMTokenListValue/*'/>
	public string Value { get; set; }
	public string this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
}

///<include file='Utils/Docs/XPathResult/XPathResult.generated.xml' path='docs/XPathResult/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XPathResult
{
		public const ushort ANY_TYPE = 0;
		public const ushort NUMBER_TYPE = 1;
		public const ushort STRING_TYPE = 2;
		public const ushort BOOLEAN_TYPE = 3;
		public const ushort UNORDERED_NODE_ITERATOR_TYPE = 4;
		public const ushort ORDERED_NODE_ITERATOR_TYPE = 5;
		public const ushort UNORDERED_NODE_SNAPSHOT_TYPE = 6;
		public const ushort ORDERED_NODE_SNAPSHOT_TYPE = 7;
		public const ushort ANY_UNORDERED_NODE_TYPE = 8;
		public const ushort FIRST_ORDERED_NODE_TYPE = 9;
	///<include file='Utils/Docs/XPathResultResultType/XPathResultResultType.generated.xml' path='docs/XPathResultResultType/*'/>
	public ushort ResultType { get; }
	///<include file='Utils/Docs/XPathResultNumberValue/XPathResultNumberValue.generated.xml' path='docs/XPathResultNumberValue/*'/>
	public double NumberValue { get; }
	///<include file='Utils/Docs/XPathResultStringValue/XPathResultStringValue.generated.xml' path='docs/XPathResultStringValue/*'/>
	public string StringValue { get; }
	///<include file='Utils/Docs/XPathResultBooleanValue/XPathResultBooleanValue.generated.xml' path='docs/XPathResultBooleanValue/*'/>
	public bool BooleanValue { get; }
	///<include file='Utils/Docs/XPathResultSingleNodeValue/XPathResultSingleNodeValue.generated.xml' path='docs/XPathResultSingleNodeValue/*'/>
	public Node? SingleNodeValue { get; }
	///<include file='Utils/Docs/XPathResultInvalidIteratorState/XPathResultInvalidIteratorState.generated.xml' path='docs/XPathResultInvalidIteratorState/*'/>
	public bool InvalidIteratorState { get; }
	///<include file='Utils/Docs/XPathResultSnapshotLength/XPathResultSnapshotLength.generated.xml' path='docs/XPathResultSnapshotLength/*'/>
	public ulong SnapshotLength { get; }
	///<include file='Utils/Docs/XPathResultIterateNext/XPathResultIterateNext.generated.xml' path='docs/XPathResultIterateNext/*'/>
	public Node? IterateNext() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XPathResultSnapshotItem/XPathResultSnapshotItem.generated.xml' path='docs/XPathResultSnapshotItem/*'/>
	public Node? SnapshotItem(ulong index) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XPathExpression/XPathExpression.generated.xml' path='docs/XPathExpression/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XPathExpression
{
	///<include file='Utils/Docs/XPathExpressionEvaluate/XPathExpressionEvaluate.generated.xml' path='docs/XPathExpressionEvaluate/*'/>
	public XPathResult Evaluate(Node contextNode, ushort type, XPathResult? result) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/XPathNSResolver/XPathNSResolver.generated.xml' path='docs/XPathNSResolver/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface XPathNSResolver
{
	///<include file='Utils/Docs/XPathNSResolverLookupNamespaceURI/XPathNSResolverLookupNamespaceURI.generated.xml' path='docs/XPathNSResolverLookupNamespaceURI/*'/>
	public string? LookupNamespaceURI(string? prefix) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface XPathEvaluatorBase
{
		public XPathExpression CreateExpression(string expression, XPathNSResolver? resolver) { throw new System.NotImplementedException(); }
		public XPathNSResolver CreateNSResolver(Node nodeResolver) { throw new System.NotImplementedException(); }
		public XPathResult Evaluate(string expression, Node contextNode, XPathNSResolver? resolver, ushort type, XPathResult? result) { throw new System.NotImplementedException(); }
}


///<include file='Utils/Docs/XPathEvaluator/XPathEvaluator.generated.xml' path='docs/XPathEvaluator/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XPathEvaluator
{
	///<include file='Utils/Docs/XPathEvaluatorXPathEvaluator/XPathEvaluatorXPathEvaluator.generated.xml' path='docs/XPathEvaluatorXPathEvaluator/*'/>
	public XPathEvaluator() { }
}


///<include file='Utils/Docs/XSLTProcessor/XSLTProcessor.generated.xml' path='docs/XSLTProcessor/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XSLTProcessor
{
	///<include file='Utils/Docs/XSLTProcessorXSLTProcessor/XSLTProcessorXSLTProcessor.generated.xml' path='docs/XSLTProcessorXSLTProcessor/*'/>
	public XSLTProcessor() { }
	///<include file='Utils/Docs/XSLTProcessorImportStylesheet/XSLTProcessorImportStylesheet.generated.xml' path='docs/XSLTProcessorImportStylesheet/*'/>
	public Undefined ImportStylesheet(Node style) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XSLTProcessorTransformToFragment/XSLTProcessorTransformToFragment.generated.xml' path='docs/XSLTProcessorTransformToFragment/*'/>
	public DocumentFragment TransformToFragment(Node source, Document output) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XSLTProcessorTransformToDocument/XSLTProcessorTransformToDocument.generated.xml' path='docs/XSLTProcessorTransformToDocument/*'/>
	public Document TransformToDocument(Node source) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XSLTProcessorSetParameter/XSLTProcessorSetParameter.generated.xml' path='docs/XSLTProcessorSetParameter/*'/>
	public Undefined SetParameter(string namespaceURI, string localName, dynamic value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XSLTProcessorGetParameter/XSLTProcessorGetParameter.generated.xml' path='docs/XSLTProcessorGetParameter/*'/>
	public dynamic GetParameter(string namespaceURI, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XSLTProcessorRemoveParameter/XSLTProcessorRemoveParameter.generated.xml' path='docs/XSLTProcessorRemoveParameter/*'/>
	public Undefined RemoveParameter(string namespaceURI, string localName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XSLTProcessorClearParameters/XSLTProcessorClearParameters.generated.xml' path='docs/XSLTProcessorClearParameters/*'/>
	public Undefined ClearParameters() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XSLTProcessorReset/XSLTProcessorReset.generated.xml' path='docs/XSLTProcessorReset/*'/>
	public Undefined Reset() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface TextDecoderCommon
{
		public string Encoding { get { throw new System.NotImplementedException(); } }
		public bool Fatal { get { throw new System.NotImplementedException(); } }
		public bool IgnoreBOM { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.Default)]
public partial class TextDecoderOptions
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Fatal;
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool IgnoreBOM;
}

[To(ToAttribute.Default)]
public partial class TextDecodeOptions
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Stream;
}

///<include file='Utils/Docs/TextDecoder/TextDecoder.generated.xml' path='docs/TextDecoder/*'/>
[To(ToAttribute.Default)]
public partial class TextDecoder
{
	///<include file='Utils/Docs/TextDecoderTextDecoder/TextDecoderTextDecoder.generated.xml' path='docs/TextDecoderTextDecoder/*'/>
	public TextDecoder(string label, TextDecoderOptions options) { }
	///<include file='Utils/Docs/TextDecoderDecode/TextDecoderDecode.generated.xml' path='docs/TextDecoderDecode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Decode(BufferSource input, TextDecodeOptions options) { throw new System.NotImplementedException(); }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial interface TextEncoderCommon
{
		public string Encoding { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.Default)]
public partial class TextEncoderEncodeIntoResult
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Read;
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Written;
}

///<include file='Utils/Docs/TextEncoder/TextEncoder.generated.xml' path='docs/TextEncoder/*'/>
[To(ToAttribute.Default)]
public partial class TextEncoder
{
	///<include file='Utils/Docs/TextEncoderTextEncoder/TextEncoderTextEncoder.generated.xml' path='docs/TextEncoderTextEncoder/*'/>
	public TextEncoder() { }
	///<include file='Utils/Docs/TextEncoderEncode/TextEncoderEncode.generated.xml' path='docs/TextEncoderEncode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public System.Byte Encode(string input) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TextEncoderEncodeInto/TextEncoderEncodeInto.generated.xml' path='docs/TextEncoderEncodeInto/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public TextEncoderEncodeIntoResult EncodeInto(string source, System.Byte destination) { throw new System.NotImplementedException(); }
}


///<include file='Utils/Docs/TextDecoderStream/TextDecoderStream.generated.xml' path='docs/TextDecoderStream/*'/>
[To(ToAttribute.Default)]
public partial class TextDecoderStream
{
	///<include file='Utils/Docs/TextDecoderStreamTextDecoderStream/TextDecoderStreamTextDecoderStream.generated.xml' path='docs/TextDecoderStreamTextDecoderStream/*'/>
	public TextDecoderStream(string label, TextDecoderOptions options) { }
}



///<include file='Utils/Docs/TextEncoderStream/TextEncoderStream.generated.xml' path='docs/TextEncoderStream/*'/>
[To(ToAttribute.Default)]
public partial class TextEncoderStream
{
	///<include file='Utils/Docs/TextEncoderStreamTextEncoderStream/TextEncoderStreamTextEncoderStream.generated.xml' path='docs/TextEncoderStreamTextEncoderStream/*'/>
	public TextEncoderStream() { }
}




///<include file='Utils/Docs/Headers/Headers.generated.xml' path='docs/Headers/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Headers
{
	///<include file='Utils/Docs/HeadersHeaders/HeadersHeaders.generated.xml' path='docs/HeadersHeaders/*'/>
	public Headers(HeadersInit init) { }
	///<include file='Utils/Docs/HeadersAppend/HeadersAppend.generated.xml' path='docs/HeadersAppend/*'/>
	public Undefined Append(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HeadersDelete/HeadersDelete.generated.xml' path='docs/HeadersDelete/*'/>
	public Undefined Delete(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HeadersGet/HeadersGet.generated.xml' path='docs/HeadersGet/*'/>
	public string? Get(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HeadersHas/HeadersHas.generated.xml' path='docs/HeadersHas/*'/>
	public bool Has(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HeadersSet/HeadersSet.generated.xml' path='docs/HeadersSet/*'/>
	public Undefined Set(string name, string value) { throw new System.NotImplementedException(); }
	public string this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial interface Body
{
		public Unsupported /*ReadableStream*/? Body { get { throw new System.NotImplementedException(); } }
		public bool BodyUsed { get { throw new System.NotImplementedException(); } }
		public Task<byte[]> ArrayBuffer() { throw new System.NotImplementedException(); }
		public Task<Unsupported /*Blob*/> Blob() { throw new System.NotImplementedException(); }
		public Task<FormData> FormData() { throw new System.NotImplementedException(); }
		public Task<dynamic> Json() { throw new System.NotImplementedException(); }
		public Task<string> Text() { throw new System.NotImplementedException(); }
}


///<include file='Utils/Docs/Request/Request.generated.xml' path='docs/Request/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Request
{
	///<include file='Utils/Docs/RequestRequest/RequestRequest.generated.xml' path='docs/RequestRequest/*'/>
	public Request(RequestInfo input, RequestInit init) { }
	///<include file='Utils/Docs/RequestMethod/RequestMethod.generated.xml' path='docs/RequestMethod/*'/>
	public string Method { get; }
	///<include file='Utils/Docs/RequestUrl/RequestUrl.generated.xml' path='docs/RequestUrl/*'/>
	public string Url { get; }
	///<include file='Utils/Docs/RequestHeaders/RequestHeaders.generated.xml' path='docs/RequestHeaders/*'/>
	public Headers Headers { get; }
	///<include file='Utils/Docs/RequestDestination/RequestDestination.generated.xml' path='docs/RequestDestination/*'/>
	public RequestDestination Destination { get; }
	///<include file='Utils/Docs/RequestReferrer/RequestReferrer.generated.xml' path='docs/RequestReferrer/*'/>
	public string Referrer { get; }
	///<include file='Utils/Docs/RequestReferrerPolicy/RequestReferrerPolicy.generated.xml' path='docs/RequestReferrerPolicy/*'/>
	public Unsupported /*ReferrerPolicy*/ ReferrerPolicy { get; }
	///<include file='Utils/Docs/RequestMode/RequestMode.generated.xml' path='docs/RequestMode/*'/>
	public RequestMode Mode { get; }
	///<include file='Utils/Docs/RequestCredentials/RequestCredentials.generated.xml' path='docs/RequestCredentials/*'/>
	public RequestCredentials Credentials { get; }
	///<include file='Utils/Docs/RequestCache/RequestCache.generated.xml' path='docs/RequestCache/*'/>
	public RequestCache Cache { get; }
	///<include file='Utils/Docs/RequestRedirect/RequestRedirect.generated.xml' path='docs/RequestRedirect/*'/>
	public RequestRedirect Redirect { get; }
	///<include file='Utils/Docs/RequestIntegrity/RequestIntegrity.generated.xml' path='docs/RequestIntegrity/*'/>
	public string Integrity { get; }
		public bool Keepalive { get; }
		public bool IsReloadNavigation { get; }
		public bool IsHistoryNavigation { get; }
	///<include file='Utils/Docs/RequestSignal/RequestSignal.generated.xml' path='docs/RequestSignal/*'/>
	public AbortSignal Signal { get; }
	///<include file='Utils/Docs/RequestClone/RequestClone.generated.xml' path='docs/RequestClone/*'/>
	public Request Clone() { throw new System.NotImplementedException(); }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class RequestInit
{
		public string Method;
		public HeadersInit Headers;
		public BodyInit? Body;
		public string Referrer;
		public Unsupported /*ReferrerPolicy*/ ReferrerPolicy;
		public RequestMode Mode;
		public RequestCredentials Credentials;
		public RequestCache Cache;
		public RequestRedirect Redirect;
		public string Integrity;
		public bool Keepalive;
		public AbortSignal? Signal;
		public dynamic Window;
}

///<include file='Utils/Docs/RequestDestination/RequestDestination.generated.xml' path='docs/RequestDestination/*'/>
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

///<include file='Utils/Docs/RequestMode/RequestMode.generated.xml' path='docs/RequestMode/*'/>
public enum RequestMode
{
	Navigate,
	SameOrigin,
	NoCors,
	Cors,
}

///<include file='Utils/Docs/RequestCredentials/RequestCredentials.generated.xml' path='docs/RequestCredentials/*'/>
public enum RequestCredentials
{
	Omit,
	SameOrigin,
	Include,
}

///<include file='Utils/Docs/RequestCache/RequestCache.generated.xml' path='docs/RequestCache/*'/>
public enum RequestCache
{
	Default,
	NoStore,
	Reload,
	NoCache,
	ForceCache,
	OnlyIfCached,
}

///<include file='Utils/Docs/RequestRedirect/RequestRedirect.generated.xml' path='docs/RequestRedirect/*'/>
public enum RequestRedirect
{
	Follow,
	Error,
	Manual,
}

///<include file='Utils/Docs/Response/Response.generated.xml' path='docs/Response/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Response
{
	///<include file='Utils/Docs/ResponseResponse/ResponseResponse.generated.xml' path='docs/ResponseResponse/*'/>
	public Response(BodyInit? body, ResponseInit init) { }
		public static Response Error() { throw new System.NotImplementedException(); }
		public static Response Redirect(string url, ushort status) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ResponseJson/ResponseJson.generated.xml' path='docs/ResponseJson/*'/>
	public static Response Json(dynamic data, ResponseInit init) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ResponseType/ResponseType.generated.xml' path='docs/ResponseType/*'/>
	public ResponseType Type { get; }
	///<include file='Utils/Docs/ResponseUrl/ResponseUrl.generated.xml' path='docs/ResponseUrl/*'/>
	public string Url { get; }
	///<include file='Utils/Docs/ResponseRedirected/ResponseRedirected.generated.xml' path='docs/ResponseRedirected/*'/>
	public bool Redirected { get; }
	///<include file='Utils/Docs/ResponseStatus/ResponseStatus.generated.xml' path='docs/ResponseStatus/*'/>
	public ushort Status { get; }
	///<include file='Utils/Docs/ResponseOk/ResponseOk.generated.xml' path='docs/ResponseOk/*'/>
	public bool Ok { get; }
	///<include file='Utils/Docs/ResponseStatusText/ResponseStatusText.generated.xml' path='docs/ResponseStatusText/*'/>
	public string StatusText { get; }
	///<include file='Utils/Docs/ResponseHeaders/ResponseHeaders.generated.xml' path='docs/ResponseHeaders/*'/>
	public Headers Headers { get; }
	///<include file='Utils/Docs/ResponseClone/ResponseClone.generated.xml' path='docs/ResponseClone/*'/>
	public Response Clone() { throw new System.NotImplementedException(); }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class ResponseInit
{
		public ushort Status;
		public string StatusText;
		public HeadersInit Headers;
}

///<include file='Utils/Docs/ResponseType/ResponseType.generated.xml' path='docs/ResponseType/*'/>
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
public partial interface WindowOrWorkerGlobalScope
{
		public Task<Response> Fetch(RequestInfo input, RequestInit init) { throw new System.NotImplementedException(); }
}

public enum FullscreenNavigationUI
{
	Auto,
	Show,
	Hide,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FullscreenOptions
{
		public FullscreenNavigationUI NavigationUI;
}

///<include file='Utils/Docs/Element/Element.generated.xml' path='docs/Element/*'/>
public partial class Element
{
	///<include file='Utils/Docs/ElementRequestFullscreen/ElementRequestFullscreen.generated.xml' path='docs/ElementRequestFullscreen/*'/>
	public Task<Undefined> RequestFullscreen(FullscreenOptions options) { throw new System.NotImplementedException(); }
		public EventHandler Onfullscreenchange { get; set; }
		public EventHandler Onfullscreenerror { get; set; }
}

///<include file='Utils/Docs/Document/Document.generated.xml' path='docs/Document/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Document
{
	///<include file='Utils/Docs/DocumentFullscreenEnabled/DocumentFullscreenEnabled.generated.xml' path='docs/DocumentFullscreenEnabled/*'/>
	public bool FullscreenEnabled { get; }
	///<include file='Utils/Docs/DocumentFullscreen/DocumentFullscreen.generated.xml' path='docs/DocumentFullscreen/*'/>
	public bool Fullscreen { get; }
	///<include file='Utils/Docs/DocumentExitFullscreen/DocumentExitFullscreen.generated.xml' path='docs/DocumentExitFullscreen/*'/>
	public Task<Undefined> ExitFullscreen() { throw new System.NotImplementedException(); }
		public EventHandler Onfullscreenchange { get; set; }
		public EventHandler Onfullscreenerror { get; set; }
}

public partial interface DocumentOrShadowRoot
{
		public Element? FullscreenElement { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.Default)]
public partial class HTMLAllCollection
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Length { get; }
	
	
	[To(ToAttribute.FirstCharToLowerCase)]
	public Union14? Item(string nameOrIndex) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLFormControlsCollection/HTMLFormControlsCollection.generated.xml' path='docs/HTMLFormControlsCollection/*'/>
[To(ToAttribute.Default)]
public partial class HTMLFormControlsCollection : HTMLCollection
{
	
}

///<include file='Utils/Docs/RadioNodeList/RadioNodeList.generated.xml' path='docs/RadioNodeList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class RadioNodeList : NodeList
{
	///<include file='Utils/Docs/RadioNodeListValue/RadioNodeListValue.generated.xml' path='docs/RadioNodeListValue/*'/>
	public string Value { get; set; }
}

///<include file='Utils/Docs/HTMLOptionsCollection/HTMLOptionsCollection.generated.xml' path='docs/HTMLOptionsCollection/*'/>
[To(ToAttribute.Default)]
public partial class HTMLOptionsCollection : HTMLCollection
{
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Length { get; set; }
	
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Add(Union16 element, Union17? before) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Remove(long index) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public long SelectedIndex { get; set; }
}

///<include file='Utils/Docs/DOMStringList/DOMStringList.generated.xml' path='docs/DOMStringList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMStringList
{
	///<include file='Utils/Docs/DOMStringListLength/DOMStringListLength.generated.xml' path='docs/DOMStringListLength/*'/>
	public ulong Length { get; }
	
	///<include file='Utils/Docs/DOMStringListContains/DOMStringListContains.generated.xml' path='docs/DOMStringListContains/*'/>
	public bool Contains(string string_) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/DocumentReadyState/DocumentReadyState.generated.xml' path='docs/DocumentReadyState/*'/>
public enum DocumentReadyState
{
	Loading,
	Interactive,
	Complete,
}

///<include file='Utils/Docs/DocumentVisibilityState/DocumentVisibilityState.generated.xml' path='docs/DocumentVisibilityState/*'/>
public enum DocumentVisibilityState
{
	Visible,
	Hidden,
}


///<include file='Utils/Docs/Document/Document.generated.xml' path='docs/Document/*'/>
public partial class Document
{
	///<include file='Utils/Docs/DocumentLocation/DocumentLocation.generated.xml' path='docs/DocumentLocation/*'/>
	public Location? Location { get; }
	///<include file='Utils/Docs/DocumentDomain/DocumentDomain.generated.xml' path='docs/DocumentDomain/*'/>
	public string Domain { get; set; }
	///<include file='Utils/Docs/DocumentReferrer/DocumentReferrer.generated.xml' path='docs/DocumentReferrer/*'/>
	public string Referrer { get; }
	///<include file='Utils/Docs/DocumentCookie/DocumentCookie.generated.xml' path='docs/DocumentCookie/*'/>
	public string Cookie { get; set; }
	///<include file='Utils/Docs/DocumentLastModified/DocumentLastModified.generated.xml' path='docs/DocumentLastModified/*'/>
	public string LastModified { get; }
	///<include file='Utils/Docs/DocumentReadyState/DocumentReadyState.generated.xml' path='docs/DocumentReadyState/*'/>
	public DocumentReadyState ReadyState { get; }
	
	///<include file='Utils/Docs/DocumentTitle/DocumentTitle.generated.xml' path='docs/DocumentTitle/*'/>
	public string Title { get; set; }
	///<include file='Utils/Docs/DocumentDir/DocumentDir.generated.xml' path='docs/DocumentDir/*'/>
	public string Dir { get; set; }
	///<include file='Utils/Docs/DocumentBody/DocumentBody.generated.xml' path='docs/DocumentBody/*'/>
	public HTMLElement? Body { get; set; }
	///<include file='Utils/Docs/DocumentHead/DocumentHead.generated.xml' path='docs/DocumentHead/*'/>
	public HTMLHeadElement? Head { get; }
	///<include file='Utils/Docs/DocumentImages/DocumentImages.generated.xml' path='docs/DocumentImages/*'/>
	public HTMLCollection Images { get; }
	///<include file='Utils/Docs/DocumentEmbeds/DocumentEmbeds.generated.xml' path='docs/DocumentEmbeds/*'/>
	public HTMLCollection Embeds { get; }
	///<include file='Utils/Docs/DocumentPlugins/DocumentPlugins.generated.xml' path='docs/DocumentPlugins/*'/>
	public HTMLCollection Plugins { get; }
	///<include file='Utils/Docs/DocumentLinks/DocumentLinks.generated.xml' path='docs/DocumentLinks/*'/>
	public HTMLCollection Links { get; }
	///<include file='Utils/Docs/DocumentForms/DocumentForms.generated.xml' path='docs/DocumentForms/*'/>
	public HTMLCollection Forms { get; }
	///<include file='Utils/Docs/DocumentScripts/DocumentScripts.generated.xml' path='docs/DocumentScripts/*'/>
	public HTMLCollection Scripts { get; }
	///<include file='Utils/Docs/DocumentGetElementsByName/DocumentGetElementsByName.generated.xml' path='docs/DocumentGetElementsByName/*'/>
	public NodeList GetElementsByName(string elementName) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentCurrentScript/DocumentCurrentScript.generated.xml' path='docs/DocumentCurrentScript/*'/>
	public HTMLOrSVGScriptElement? CurrentScript { get; }
	///<include file='Utils/Docs/DocumentOpen/DocumentOpen.generated.xml' path='docs/DocumentOpen/*'/>
	public Document Open(string unused1, string unused2) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentOpen/DocumentOpen.generated.xml' path='docs/DocumentOpen/*'/>
	public Window? Open(string url, string name, string features) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentClose/DocumentClose.generated.xml' path='docs/DocumentClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentWrite/DocumentWrite.generated.xml' path='docs/DocumentWrite/*'/>
	public Undefined Write(params string[] text) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentWriteln/DocumentWriteln.generated.xml' path='docs/DocumentWriteln/*'/>
	public Undefined Writeln(params string[] text) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentDefaultView/DocumentDefaultView.generated.xml' path='docs/DocumentDefaultView/*'/>
	public Window? DefaultView { get; }
	///<include file='Utils/Docs/DocumentHasFocus/DocumentHasFocus.generated.xml' path='docs/DocumentHasFocus/*'/>
	public bool HasFocus() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentDesignMode/DocumentDesignMode.generated.xml' path='docs/DocumentDesignMode/*'/>
	public string DesignMode { get; set; }
	///<include file='Utils/Docs/DocumentExecCommand/DocumentExecCommand.generated.xml' path='docs/DocumentExecCommand/*'/>
	public bool ExecCommand(string commandId, bool showUI, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentQueryCommandEnabled/DocumentQueryCommandEnabled.generated.xml' path='docs/DocumentQueryCommandEnabled/*'/>
	public bool QueryCommandEnabled(string commandId) { throw new System.NotImplementedException(); }
		public bool QueryCommandIndeterm(string commandId) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentQueryCommandState/DocumentQueryCommandState.generated.xml' path='docs/DocumentQueryCommandState/*'/>
	public bool QueryCommandState(string commandId) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentQueryCommandSupported/DocumentQueryCommandSupported.generated.xml' path='docs/DocumentQueryCommandSupported/*'/>
	public bool QueryCommandSupported(string commandId) { throw new System.NotImplementedException(); }
		public string QueryCommandValue(string commandId) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentHidden/DocumentHidden.generated.xml' path='docs/DocumentHidden/*'/>
	public bool Hidden { get; }
	///<include file='Utils/Docs/DocumentVisibilityState/DocumentVisibilityState.generated.xml' path='docs/DocumentVisibilityState/*'/>
	public DocumentVisibilityState VisibilityState { get; }
		public EventHandler Onreadystatechange { get; set; }
		public EventHandler Onvisibilitychange { get; set; }
}



public partial interface DocumentOrShadowRoot
{
		public Element? ActiveElement { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/HTMLElement/HTMLElement.generated.xml' path='docs/HTMLElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLElement : Element, GlobalEventHandlers, DocumentAndElementEventHandlers, ElementContentEditable, HTMLOrSVGElement
{
		public HTMLElement() { }
	///<include file='Utils/Docs/HTMLElementTitle/HTMLElementTitle.generated.xml' path='docs/HTMLElementTitle/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Title { get; set; }
	///<include file='Utils/Docs/HTMLElementLang/HTMLElementLang.generated.xml' path='docs/HTMLElementLang/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Lang { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Translate { get; set; }
	///<include file='Utils/Docs/HTMLElementDir/HTMLElementDir.generated.xml' path='docs/HTMLElementDir/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Dir { get; set; }
	///<include file='Utils/Docs/HTMLElementHidden/HTMLElementHidden.generated.xml' path='docs/HTMLElementHidden/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Union19? Hidden { get; set; }
	///<include file='Utils/Docs/HTMLElementInert/HTMLElementInert.generated.xml' path='docs/HTMLElementInert/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Inert { get; set; }
	///<include file='Utils/Docs/HTMLElementClick/HTMLElementClick.generated.xml' path='docs/HTMLElementClick/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Click() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLElementAccessKey/HTMLElementAccessKey.generated.xml' path='docs/HTMLElementAccessKey/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string AccessKey { get; set; }
	///<include file='Utils/Docs/HTMLElementAccessKeyLabel/HTMLElementAccessKeyLabel.generated.xml' path='docs/HTMLElementAccessKeyLabel/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string AccessKeyLabel { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Draggable { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Spellcheck { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Autocapitalize { get; set; }
	///<include file='Utils/Docs/HTMLElementInnerText/HTMLElementInnerText.generated.xml' path='docs/HTMLElementInnerText/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string InnerText { get; set; }
	///<include file='Utils/Docs/HTMLElementOuterText/HTMLElementOuterText.generated.xml' path='docs/HTMLElementOuterText/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string OuterText { get; set; }
	///<include file='Utils/Docs/HTMLElementAttachInternals/HTMLElementAttachInternals.generated.xml' path='docs/HTMLElementAttachInternals/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ElementInternals AttachInternals() { throw new System.NotImplementedException(); }
}





///<include file='Utils/Docs/HTMLUnknownElement/HTMLUnknownElement.generated.xml' path='docs/HTMLUnknownElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLUnknownElement : HTMLElement
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface HTMLOrSVGElement
{
		public string Dataset { get { throw new System.NotImplementedException(); } }
		public string Nonce { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public bool Autofocus { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public long TabIndex { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public Undefined Focus(FocusOptions options) { throw new System.NotImplementedException(); }
		public Undefined Blur() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/DOMStringMap/DOMStringMap.generated.xml' path='docs/DOMStringMap/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMStringMap
{
	
	
	
}

///<include file='Utils/Docs/HTMLHtmlElement/HTMLHtmlElement.generated.xml' path='docs/HTMLHtmlElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLHtmlElement : HTMLElement
{
		public HTMLHtmlElement() { }
}

///<include file='Utils/Docs/HTMLHeadElement/HTMLHeadElement.generated.xml' path='docs/HTMLHeadElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLHeadElement : HTMLElement
{
		public HTMLHeadElement() { }
}

///<include file='Utils/Docs/HTMLTitleElement/HTMLTitleElement.generated.xml' path='docs/HTMLTitleElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTitleElement : HTMLElement
{
		public HTMLTitleElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Text { get; set; }
}

///<include file='Utils/Docs/HTMLBaseElement/HTMLBaseElement.generated.xml' path='docs/HTMLBaseElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLBaseElement : HTMLElement
{
		public HTMLBaseElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Href { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Target { get; set; }
}

///<include file='Utils/Docs/HTMLLinkElement/HTMLLinkElement.generated.xml' path='docs/HTMLLinkElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLLinkElement : HTMLElement
{
		public HTMLLinkElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Href { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string? CrossOrigin { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementRel/HTMLLinkElementRel.generated.xml' path='docs/HTMLLinkElementRel/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Rel { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementAs/HTMLLinkElementAs.generated.xml' path='docs/HTMLLinkElementAs/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string As { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementRelList/HTMLLinkElementRelList.generated.xml' path='docs/HTMLLinkElementRelList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList RelList { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Media { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Integrity { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Hreflang { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList Sizes { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string ImageSrcset { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string ImageSizes { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementReferrerPolicy/HTMLLinkElementReferrerPolicy.generated.xml' path='docs/HTMLLinkElementReferrerPolicy/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ReferrerPolicy { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList Blocking { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
}


///<include file='Utils/Docs/HTMLMetaElement/HTMLMetaElement.generated.xml' path='docs/HTMLMetaElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLMetaElement : HTMLElement
{
		public HTMLMetaElement() { }
	///<include file='Utils/Docs/HTMLMetaElementName/HTMLMetaElementName.generated.xml' path='docs/HTMLMetaElementName/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	///<include file='Utils/Docs/HTMLMetaElementHttpEquiv/HTMLMetaElementHttpEquiv.generated.xml' path='docs/HTMLMetaElementHttpEquiv/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string HttpEquiv { get; set; }
	///<include file='Utils/Docs/HTMLMetaElementContent/HTMLMetaElementContent.generated.xml' path='docs/HTMLMetaElementContent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Content { get; set; }
	///<include file='Utils/Docs/HTMLMetaElementMedia/HTMLMetaElementMedia.generated.xml' path='docs/HTMLMetaElementMedia/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Media { get; set; }
}

///<include file='Utils/Docs/HTMLStyleElement/HTMLStyleElement.generated.xml' path='docs/HTMLStyleElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLStyleElement : HTMLElement
{
		public HTMLStyleElement() { }
	///<include file='Utils/Docs/HTMLStyleElementDisabled/HTMLStyleElementDisabled.generated.xml' path='docs/HTMLStyleElementDisabled/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	///<include file='Utils/Docs/HTMLStyleElementMedia/HTMLStyleElementMedia.generated.xml' path='docs/HTMLStyleElementMedia/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Media { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList Blocking { get; }
}


///<include file='Utils/Docs/HTMLBodyElement/HTMLBodyElement.generated.xml' path='docs/HTMLBodyElement/*'/>
public partial class HTMLBodyElement : HTMLElement
{
		public HTMLBodyElement() { }
}


///<include file='Utils/Docs/HTMLHeadingElement/HTMLHeadingElement.generated.xml' path='docs/HTMLHeadingElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLHeadingElement : HTMLElement
{
		public HTMLHeadingElement() { }
}

///<include file='Utils/Docs/HTMLParagraphElement/HTMLParagraphElement.generated.xml' path='docs/HTMLParagraphElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLParagraphElement : HTMLElement
{
		public HTMLParagraphElement() { }
}

///<include file='Utils/Docs/HTMLHRElement/HTMLHRElement.generated.xml' path='docs/HTMLHRElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLHRElement : HTMLElement
{
		public HTMLHRElement() { }
}

///<include file='Utils/Docs/HTMLPreElement/HTMLPreElement.generated.xml' path='docs/HTMLPreElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLPreElement : HTMLElement
{
		public HTMLPreElement() { }
}

///<include file='Utils/Docs/HTMLQuoteElement/HTMLQuoteElement.generated.xml' path='docs/HTMLQuoteElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLQuoteElement : HTMLElement
{
		public HTMLQuoteElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Cite { get; set; }
}

///<include file='Utils/Docs/HTMLOListElement/HTMLOListElement.generated.xml' path='docs/HTMLOListElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLOListElement : HTMLElement
{
		public HTMLOListElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Reversed { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public long Start { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
}

///<include file='Utils/Docs/HTMLUListElement/HTMLUListElement.generated.xml' path='docs/HTMLUListElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLUListElement : HTMLElement
{
		public HTMLUListElement() { }
}

///<include file='Utils/Docs/HTMLMenuElement/HTMLMenuElement.generated.xml' path='docs/HTMLMenuElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLMenuElement : HTMLElement
{
		public HTMLMenuElement() { }
}

///<include file='Utils/Docs/HTMLLIElement/HTMLLIElement.generated.xml' path='docs/HTMLLIElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLLIElement : HTMLElement
{
		public HTMLLIElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public long Value { get; set; }
}

///<include file='Utils/Docs/HTMLDListElement/HTMLDListElement.generated.xml' path='docs/HTMLDListElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLDListElement : HTMLElement
{
		public HTMLDListElement() { }
}

///<include file='Utils/Docs/HTMLDivElement/HTMLDivElement.generated.xml' path='docs/HTMLDivElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLDivElement : HTMLElement
{
		public HTMLDivElement() { }
}

///<include file='Utils/Docs/HTMLAnchorElement/HTMLAnchorElement.generated.xml' path='docs/HTMLAnchorElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLAnchorElement : HTMLElement, HTMLHyperlinkElementUtils
{
		public HTMLAnchorElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Target { get; set; }
	///<include file='Utils/Docs/HTMLAnchorElementDownload/HTMLAnchorElementDownload.generated.xml' path='docs/HTMLAnchorElementDownload/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Download { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Ping { get; set; }
	///<include file='Utils/Docs/HTMLAnchorElementRel/HTMLAnchorElementRel.generated.xml' path='docs/HTMLAnchorElementRel/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Rel { get; set; }
	///<include file='Utils/Docs/HTMLAnchorElementRelList/HTMLAnchorElementRelList.generated.xml' path='docs/HTMLAnchorElementRelList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList RelList { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Hreflang { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Text { get; set; }
	///<include file='Utils/Docs/HTMLAnchorElementReferrerPolicy/HTMLAnchorElementReferrerPolicy.generated.xml' path='docs/HTMLAnchorElementReferrerPolicy/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ReferrerPolicy { get; set; }
}


///<include file='Utils/Docs/HTMLDataElement/HTMLDataElement.generated.xml' path='docs/HTMLDataElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLDataElement : HTMLElement
{
		public HTMLDataElement() { }
	///<include file='Utils/Docs/HTMLDataElementValue/HTMLDataElementValue.generated.xml' path='docs/HTMLDataElementValue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
}

///<include file='Utils/Docs/HTMLTimeElement/HTMLTimeElement.generated.xml' path='docs/HTMLTimeElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTimeElement : HTMLElement
{
		public HTMLTimeElement() { }
	///<include file='Utils/Docs/HTMLTimeElementDateTime/HTMLTimeElementDateTime.generated.xml' path='docs/HTMLTimeElementDateTime/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string DateTime { get; set; }
}

///<include file='Utils/Docs/HTMLSpanElement/HTMLSpanElement.generated.xml' path='docs/HTMLSpanElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLSpanElement : HTMLElement
{
		public HTMLSpanElement() { }
}

///<include file='Utils/Docs/HTMLBRElement/HTMLBRElement.generated.xml' path='docs/HTMLBRElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLBRElement : HTMLElement
{
		public HTMLBRElement() { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface HTMLHyperlinkElementUtils
{
		public string Href { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string Origin { get { throw new System.NotImplementedException(); } }
		public string Protocol { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string Username { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string Password { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string Host { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string Hostname { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string Port { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string Pathname { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string Search { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string Hash { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/HTMLModElement/HTMLModElement.generated.xml' path='docs/HTMLModElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLModElement : HTMLElement
{
		public HTMLModElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Cite { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string DateTime { get; set; }
}

///<include file='Utils/Docs/HTMLPictureElement/HTMLPictureElement.generated.xml' path='docs/HTMLPictureElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLPictureElement : HTMLElement
{
		public HTMLPictureElement() { }
}

///<include file='Utils/Docs/HTMLSourceElement/HTMLSourceElement.generated.xml' path='docs/HTMLSourceElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLSourceElement : HTMLElement
{
		public HTMLSourceElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Srcset { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Sizes { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Media { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Width { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Height { get; set; }
}

///<include file='Utils/Docs/HTMLImageElement/HTMLImageElement.generated.xml' path='docs/HTMLImageElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLImageElement : HTMLElement
{
		public HTMLImageElement() { }
	///<include file='Utils/Docs/HTMLImageElementAlt/HTMLImageElementAlt.generated.xml' path='docs/HTMLImageElementAlt/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Alt { get; set; }
	///<include file='Utils/Docs/HTMLImageElementSrc/HTMLImageElementSrc.generated.xml' path='docs/HTMLImageElementSrc/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	///<include file='Utils/Docs/HTMLImageElementSrcset/HTMLImageElementSrcset.generated.xml' path='docs/HTMLImageElementSrcset/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Srcset { get; set; }
	///<include file='Utils/Docs/HTMLImageElementSizes/HTMLImageElementSizes.generated.xml' path='docs/HTMLImageElementSizes/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Sizes { get; set; }
	///<include file='Utils/Docs/HTMLImageElementCrossOrigin/HTMLImageElementCrossOrigin.generated.xml' path='docs/HTMLImageElementCrossOrigin/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string? CrossOrigin { get; set; }
	///<include file='Utils/Docs/HTMLImageElementUseMap/HTMLImageElementUseMap.generated.xml' path='docs/HTMLImageElementUseMap/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string UseMap { get; set; }
	///<include file='Utils/Docs/HTMLImageElementIsMap/HTMLImageElementIsMap.generated.xml' path='docs/HTMLImageElementIsMap/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool IsMap { get; set; }
	///<include file='Utils/Docs/HTMLImageElementWidth/HTMLImageElementWidth.generated.xml' path='docs/HTMLImageElementWidth/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Width { get; set; }
	///<include file='Utils/Docs/HTMLImageElementHeight/HTMLImageElementHeight.generated.xml' path='docs/HTMLImageElementHeight/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Height { get; set; }
	///<include file='Utils/Docs/HTMLImageElementNaturalWidth/HTMLImageElementNaturalWidth.generated.xml' path='docs/HTMLImageElementNaturalWidth/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong NaturalWidth { get; }
	///<include file='Utils/Docs/HTMLImageElementNaturalHeight/HTMLImageElementNaturalHeight.generated.xml' path='docs/HTMLImageElementNaturalHeight/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong NaturalHeight { get; }
	///<include file='Utils/Docs/HTMLImageElementComplete/HTMLImageElementComplete.generated.xml' path='docs/HTMLImageElementComplete/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Complete { get; }
	///<include file='Utils/Docs/HTMLImageElementCurrentSrc/HTMLImageElementCurrentSrc.generated.xml' path='docs/HTMLImageElementCurrentSrc/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string CurrentSrc { get; }
	///<include file='Utils/Docs/HTMLImageElementReferrerPolicy/HTMLImageElementReferrerPolicy.generated.xml' path='docs/HTMLImageElementReferrerPolicy/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ReferrerPolicy { get; set; }
	///<include file='Utils/Docs/HTMLImageElementDecoding/HTMLImageElementDecoding.generated.xml' path='docs/HTMLImageElementDecoding/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Decoding { get; set; }
	///<include file='Utils/Docs/HTMLImageElementLoading/HTMLImageElementLoading.generated.xml' path='docs/HTMLImageElementLoading/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Loading { get; set; }
	///<include file='Utils/Docs/HTMLImageElementDecode/HTMLImageElementDecode.generated.xml' path='docs/HTMLImageElementDecode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Task<Undefined> Decode() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLIFrameElement/HTMLIFrameElement.generated.xml' path='docs/HTMLIFrameElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLIFrameElement : HTMLElement
{
		public HTMLIFrameElement() { }
	///<include file='Utils/Docs/HTMLIFrameElementSrc/HTMLIFrameElementSrc.generated.xml' path='docs/HTMLIFrameElementSrc/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementSrcdoc/HTMLIFrameElementSrcdoc.generated.xml' path='docs/HTMLIFrameElementSrcdoc/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Srcdoc { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList Sandbox { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Allow { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool AllowFullscreen { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Width { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Height { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementReferrerPolicy/HTMLIFrameElementReferrerPolicy.generated.xml' path='docs/HTMLIFrameElementReferrerPolicy/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ReferrerPolicy { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Loading { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementContentDocument/HTMLIFrameElementContentDocument.generated.xml' path='docs/HTMLIFrameElementContentDocument/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Document? ContentDocument { get; }
	///<include file='Utils/Docs/HTMLIFrameElementContentWindow/HTMLIFrameElementContentWindow.generated.xml' path='docs/HTMLIFrameElementContentWindow/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Window? ContentWindow { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public Document? GetSVGDocument() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLEmbedElement/HTMLEmbedElement.generated.xml' path='docs/HTMLEmbedElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLEmbedElement : HTMLElement
{
		public HTMLEmbedElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Width { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Height { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public Document? GetSVGDocument() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLObjectElement/HTMLObjectElement.generated.xml' path='docs/HTMLObjectElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLObjectElement : HTMLElement
{
		public HTMLObjectElement() { }
	///<include file='Utils/Docs/HTMLObjectElementData/HTMLObjectElementData.generated.xml' path='docs/HTMLObjectElementData/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Data { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementType/HTMLObjectElementType.generated.xml' path='docs/HTMLObjectElementType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementName/HTMLObjectElementName.generated.xml' path='docs/HTMLObjectElementName/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementForm/HTMLObjectElementForm.generated.xml' path='docs/HTMLObjectElementForm/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	///<include file='Utils/Docs/HTMLObjectElementWidth/HTMLObjectElementWidth.generated.xml' path='docs/HTMLObjectElementWidth/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Width { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementHeight/HTMLObjectElementHeight.generated.xml' path='docs/HTMLObjectElementHeight/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Height { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementContentDocument/HTMLObjectElementContentDocument.generated.xml' path='docs/HTMLObjectElementContentDocument/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Document? ContentDocument { get; }
	///<include file='Utils/Docs/HTMLObjectElementContentWindow/HTMLObjectElementContentWindow.generated.xml' path='docs/HTMLObjectElementContentWindow/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Window? ContentWindow { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public Document? GetSVGDocument() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLObjectElementWillValidate/HTMLObjectElementWillValidate.generated.xml' path='docs/HTMLObjectElementWillValidate/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
	///<include file='Utils/Docs/HTMLObjectElementValidity/HTMLObjectElementValidity.generated.xml' path='docs/HTMLObjectElementValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
	///<include file='Utils/Docs/HTMLObjectElementValidationMessage/HTMLObjectElementValidationMessage.generated.xml' path='docs/HTMLObjectElementValidationMessage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
	///<include file='Utils/Docs/HTMLObjectElementCheckValidity/HTMLObjectElementCheckValidity.generated.xml' path='docs/HTMLObjectElementCheckValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLObjectElementSetCustomValidity/HTMLObjectElementSetCustomValidity.generated.xml' path='docs/HTMLObjectElementSetCustomValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetCustomValidity(string error) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLVideoElement/HTMLVideoElement.generated.xml' path='docs/HTMLVideoElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLVideoElement : HTMLMediaElement
{
		public HTMLVideoElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Width { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Height { get; set; }
	///<include file='Utils/Docs/HTMLVideoElementVideoWidth/HTMLVideoElementVideoWidth.generated.xml' path='docs/HTMLVideoElementVideoWidth/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong VideoWidth { get; }
	///<include file='Utils/Docs/HTMLVideoElementVideoHeight/HTMLVideoElementVideoHeight.generated.xml' path='docs/HTMLVideoElementVideoHeight/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong VideoHeight { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Poster { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool PlaysInline { get; set; }
}

///<include file='Utils/Docs/HTMLAudioElement/HTMLAudioElement.generated.xml' path='docs/HTMLAudioElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLAudioElement : HTMLMediaElement
{
		public HTMLAudioElement() { }
}

///<include file='Utils/Docs/HTMLTrackElement/HTMLTrackElement.generated.xml' path='docs/HTMLTrackElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTrackElement : HTMLElement
{
		public HTMLTrackElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Kind { get; set; }
	///<include file='Utils/Docs/HTMLTrackElementSrc/HTMLTrackElementSrc.generated.xml' path='docs/HTMLTrackElementSrc/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Srclang { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Label { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Default { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort NONE = 0;
	[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort LOADING = 1;
	[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort LOADED = 2;
	[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort ERROR = 3;
	[To(ToAttribute.FirstCharToLowerCase)]
	public ushort ReadyState { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrack Track { get; }
}

public enum CanPlayTypeResult
{
	Empty,
	Maybe,
	Probably,
}


///<include file='Utils/Docs/HTMLMediaElement/HTMLMediaElement.generated.xml' path='docs/HTMLMediaElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLMediaElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLMediaElementError/HTMLMediaElementError.generated.xml' path='docs/HTMLMediaElementError/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public MediaError? Error { get; }
	///<include file='Utils/Docs/HTMLMediaElementSrc/HTMLMediaElementSrc.generated.xml' path='docs/HTMLMediaElementSrc/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementSrcObject/HTMLMediaElementSrcObject.generated.xml' path='docs/HTMLMediaElementSrcObject/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public MediaProvider? SrcObject { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementCurrentSrc/HTMLMediaElementCurrentSrc.generated.xml' path='docs/HTMLMediaElementCurrentSrc/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string CurrentSrc { get; }
	///<include file='Utils/Docs/HTMLMediaElementCrossOrigin/HTMLMediaElementCrossOrigin.generated.xml' path='docs/HTMLMediaElementCrossOrigin/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string? CrossOrigin { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort NETWORK_EMPTY = 0;
	[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort NETWORK_IDLE = 1;
	[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort NETWORK_LOADING = 2;
	[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort NETWORK_NO_SOURCE = 3;
	///<include file='Utils/Docs/HTMLMediaElementNetworkState/HTMLMediaElementNetworkState.generated.xml' path='docs/HTMLMediaElementNetworkState/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ushort NetworkState { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Preload { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool BufferingThrottled { get; }
	///<include file='Utils/Docs/HTMLMediaElementBuffered/HTMLMediaElementBuffered.generated.xml' path='docs/HTMLMediaElementBuffered/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public TimeRanges Buffered { get; }
	///<include file='Utils/Docs/HTMLMediaElementLoad/HTMLMediaElementLoad.generated.xml' path='docs/HTMLMediaElementLoad/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Load() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLMediaElementCanPlayType/HTMLMediaElementCanPlayType.generated.xml' path='docs/HTMLMediaElementCanPlayType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public CanPlayTypeResult CanPlayType(string type) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort HAVE_NOTHING = 0;
	[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort HAVE_METADATA = 1;
	[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort HAVE_CURRENT_DATA = 2;
	[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort HAVE_FUTURE_DATA = 3;
	[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort HAVE_ENOUGH_DATA = 4;
	///<include file='Utils/Docs/HTMLMediaElementReadyState/HTMLMediaElementReadyState.generated.xml' path='docs/HTMLMediaElementReadyState/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ushort ReadyState { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Seeking { get; }
	///<include file='Utils/Docs/HTMLMediaElementCurrentTime/HTMLMediaElementCurrentTime.generated.xml' path='docs/HTMLMediaElementCurrentTime/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double CurrentTime { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementFastSeek/HTMLMediaElementFastSeek.generated.xml' path='docs/HTMLMediaElementFastSeek/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined FastSeek(double time) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLMediaElementDuration/HTMLMediaElementDuration.generated.xml' path='docs/HTMLMediaElementDuration/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double Duration { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public object GetStartDate() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLMediaElementPaused/HTMLMediaElementPaused.generated.xml' path='docs/HTMLMediaElementPaused/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Paused { get; }
	///<include file='Utils/Docs/HTMLMediaElementDefaultPlaybackRate/HTMLMediaElementDefaultPlaybackRate.generated.xml' path='docs/HTMLMediaElementDefaultPlaybackRate/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double DefaultPlaybackRate { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementPlaybackRate/HTMLMediaElementPlaybackRate.generated.xml' path='docs/HTMLMediaElementPlaybackRate/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double PlaybackRate { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementPreservesPitch/HTMLMediaElementPreservesPitch.generated.xml' path='docs/HTMLMediaElementPreservesPitch/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool PreservesPitch { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public TimeRanges Played { get; }
	///<include file='Utils/Docs/HTMLMediaElementSeekable/HTMLMediaElementSeekable.generated.xml' path='docs/HTMLMediaElementSeekable/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public TimeRanges Seekable { get; }
	///<include file='Utils/Docs/HTMLMediaElementEnded/HTMLMediaElementEnded.generated.xml' path='docs/HTMLMediaElementEnded/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Ended { get; }
	///<include file='Utils/Docs/HTMLMediaElementAutoplay/HTMLMediaElementAutoplay.generated.xml' path='docs/HTMLMediaElementAutoplay/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Autoplay { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementLoop/HTMLMediaElementLoop.generated.xml' path='docs/HTMLMediaElementLoop/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Loop { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementPlay/HTMLMediaElementPlay.generated.xml' path='docs/HTMLMediaElementPlay/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Task<Undefined> Play() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLMediaElementPause/HTMLMediaElementPause.generated.xml' path='docs/HTMLMediaElementPause/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Pause() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLMediaElementControls/HTMLMediaElementControls.generated.xml' path='docs/HTMLMediaElementControls/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Controls { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementVolume/HTMLMediaElementVolume.generated.xml' path='docs/HTMLMediaElementVolume/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double Volume { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementMuted/HTMLMediaElementMuted.generated.xml' path='docs/HTMLMediaElementMuted/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Muted { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementDefaultMuted/HTMLMediaElementDefaultMuted.generated.xml' path='docs/HTMLMediaElementDefaultMuted/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool DefaultMuted { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementAudioTracks/HTMLMediaElementAudioTracks.generated.xml' path='docs/HTMLMediaElementAudioTracks/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public AudioTrackList AudioTracks { get; }
	///<include file='Utils/Docs/HTMLMediaElementVideoTracks/HTMLMediaElementVideoTracks.generated.xml' path='docs/HTMLMediaElementVideoTracks/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public VideoTrackList VideoTracks { get; }
	///<include file='Utils/Docs/HTMLMediaElementTextTracks/HTMLMediaElementTextTracks.generated.xml' path='docs/HTMLMediaElementTextTracks/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrackList TextTracks { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrack AddTextTrack(TextTrackKind kind, string label, string language) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/MediaError/MediaError.generated.xml' path='docs/MediaError/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaError
{
		public const ushort MEDIA_ERR_ABORTED = 1;
		public const ushort MEDIA_ERR_NETWORK = 2;
		public const ushort MEDIA_ERR_DECODE = 3;
		public const ushort MEDIA_ERR_SRC_NOT_SUPPORTED = 4;
	///<include file='Utils/Docs/MediaErrorCode/MediaErrorCode.generated.xml' path='docs/MediaErrorCode/*'/>
	public ushort Code { get; }
	///<include file='Utils/Docs/MediaErrorMessage/MediaErrorMessage.generated.xml' path='docs/MediaErrorMessage/*'/>
	public string Message { get; }
}

///<include file='Utils/Docs/AudioTrackList/AudioTrackList.generated.xml' path='docs/AudioTrackList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioTrackList : EventTarget
{
	///<include file='Utils/Docs/AudioTrackListLength/AudioTrackListLength.generated.xml' path='docs/AudioTrackListLength/*'/>
	public ulong Length { get; }
	
	///<include file='Utils/Docs/AudioTrackListGetTrackById/AudioTrackListGetTrackById.generated.xml' path='docs/AudioTrackListGetTrackById/*'/>
	public AudioTrack? GetTrackById(string id) { throw new System.NotImplementedException(); }
		public EventHandler Onchange { get; set; }
		public EventHandler Onaddtrack { get; set; }
		public EventHandler Onremovetrack { get; set; }
}

///<include file='Utils/Docs/AudioTrack/AudioTrack.generated.xml' path='docs/AudioTrack/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AudioTrack
{
	///<include file='Utils/Docs/AudioTrackId/AudioTrackId.generated.xml' path='docs/AudioTrackId/*'/>
	public string Id { get; }
	///<include file='Utils/Docs/AudioTrackKind/AudioTrackKind.generated.xml' path='docs/AudioTrackKind/*'/>
	public string Kind { get; }
	///<include file='Utils/Docs/AudioTrackLabel/AudioTrackLabel.generated.xml' path='docs/AudioTrackLabel/*'/>
	public string Label { get; }
	///<include file='Utils/Docs/AudioTrackLanguage/AudioTrackLanguage.generated.xml' path='docs/AudioTrackLanguage/*'/>
	public string Language { get; }
	///<include file='Utils/Docs/AudioTrackEnabled/AudioTrackEnabled.generated.xml' path='docs/AudioTrackEnabled/*'/>
	public bool Enabled { get; set; }
}

///<include file='Utils/Docs/VideoTrackList/VideoTrackList.generated.xml' path='docs/VideoTrackList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoTrackList : EventTarget
{
	///<include file='Utils/Docs/VideoTrackListLength/VideoTrackListLength.generated.xml' path='docs/VideoTrackListLength/*'/>
	public ulong Length { get; }
	
	///<include file='Utils/Docs/VideoTrackListGetTrackById/VideoTrackListGetTrackById.generated.xml' path='docs/VideoTrackListGetTrackById/*'/>
	public VideoTrack? GetTrackById(string id) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/VideoTrackListSelectedIndex/VideoTrackListSelectedIndex.generated.xml' path='docs/VideoTrackListSelectedIndex/*'/>
	public long SelectedIndex { get; }
		public EventHandler Onchange { get; set; }
		public EventHandler Onaddtrack { get; set; }
		public EventHandler Onremovetrack { get; set; }
}

///<include file='Utils/Docs/VideoTrack/VideoTrack.generated.xml' path='docs/VideoTrack/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class VideoTrack
{
	///<include file='Utils/Docs/VideoTrackId/VideoTrackId.generated.xml' path='docs/VideoTrackId/*'/>
	public string Id { get; }
	///<include file='Utils/Docs/VideoTrackKind/VideoTrackKind.generated.xml' path='docs/VideoTrackKind/*'/>
	public string Kind { get; }
	///<include file='Utils/Docs/VideoTrackLabel/VideoTrackLabel.generated.xml' path='docs/VideoTrackLabel/*'/>
	public string Label { get; }
	///<include file='Utils/Docs/VideoTrackLanguage/VideoTrackLanguage.generated.xml' path='docs/VideoTrackLanguage/*'/>
	public string Language { get; }
	///<include file='Utils/Docs/VideoTrackSelected/VideoTrackSelected.generated.xml' path='docs/VideoTrackSelected/*'/>
	public bool Selected { get; set; }
}

///<include file='Utils/Docs/TextTrackList/TextTrackList.generated.xml' path='docs/TextTrackList/*'/>
[To(ToAttribute.Default)]
public partial class TextTrackList : EventTarget
{
	///<include file='Utils/Docs/TextTrackListLength/TextTrackListLength.generated.xml' path='docs/TextTrackListLength/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Length { get; }
	
	///<include file='Utils/Docs/TextTrackListGetTrackById/TextTrackListGetTrackById.generated.xml' path='docs/TextTrackListGetTrackById/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrack? GetTrackById(string id) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onchange { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onaddtrack { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onremovetrack { get; set; }
}

///<include file='Utils/Docs/TextTrackMode/TextTrackMode.generated.xml' path='docs/TextTrackMode/*'/>
public enum TextTrackMode
{
	Disabled,
	Hidden,
	Showing,
}

///<include file='Utils/Docs/TextTrackKind/TextTrackKind.generated.xml' path='docs/TextTrackKind/*'/>
public enum TextTrackKind
{
	Subtitles,
	Captions,
	Descriptions,
	Chapters,
	Metadata,
}

///<include file='Utils/Docs/TextTrack/TextTrack.generated.xml' path='docs/TextTrack/*'/>
[To(ToAttribute.Default)]
public partial class TextTrack : EventTarget
{
	///<include file='Utils/Docs/TextTrackKind/TextTrackKind.generated.xml' path='docs/TextTrackKind/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrackKind Kind { get; }
	///<include file='Utils/Docs/TextTrackLabel/TextTrackLabel.generated.xml' path='docs/TextTrackLabel/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Label { get; }
	///<include file='Utils/Docs/TextTrackLanguage/TextTrackLanguage.generated.xml' path='docs/TextTrackLanguage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Language { get; }
	///<include file='Utils/Docs/TextTrackId/TextTrackId.generated.xml' path='docs/TextTrackId/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Id { get; }
	///<include file='Utils/Docs/TextTrackInBandMetadataTrackDispatchType/TextTrackInBandMetadataTrackDispatchType.generated.xml' path='docs/TextTrackInBandMetadataTrackDispatchType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string InBandMetadataTrackDispatchType { get; }
	///<include file='Utils/Docs/TextTrackMode/TextTrackMode.generated.xml' path='docs/TextTrackMode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrackMode Mode { get; set; }
	///<include file='Utils/Docs/TextTrackCues/TextTrackCues.generated.xml' path='docs/TextTrackCues/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrackCueList? Cues { get; }
	///<include file='Utils/Docs/TextTrackActiveCues/TextTrackActiveCues.generated.xml' path='docs/TextTrackActiveCues/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrackCueList? ActiveCues { get; }
	///<include file='Utils/Docs/TextTrackAddCue/TextTrackAddCue.generated.xml' path='docs/TextTrackAddCue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined AddCue(TextTrackCue cue) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TextTrackRemoveCue/TextTrackRemoveCue.generated.xml' path='docs/TextTrackRemoveCue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined RemoveCue(TextTrackCue cue) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Oncuechange { get; set; }
}

///<include file='Utils/Docs/TextTrackCueList/TextTrackCueList.generated.xml' path='docs/TextTrackCueList/*'/>
[To(ToAttribute.Default)]
public partial class TextTrackCueList
{
	///<include file='Utils/Docs/TextTrackCueListLength/TextTrackCueListLength.generated.xml' path='docs/TextTrackCueListLength/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Length { get; }
	
	///<include file='Utils/Docs/TextTrackCueListGetCueById/TextTrackCueListGetCueById.generated.xml' path='docs/TextTrackCueListGetCueById/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrackCue? GetCueById(string id) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/TextTrackCue/TextTrackCue.generated.xml' path='docs/TextTrackCue/*'/>
[To(ToAttribute.Default)]
public partial class TextTrackCue : EventTarget
{
	///<include file='Utils/Docs/TextTrackCueTrack/TextTrackCueTrack.generated.xml' path='docs/TextTrackCueTrack/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrack? Track { get; }
	///<include file='Utils/Docs/TextTrackCueId/TextTrackCueId.generated.xml' path='docs/TextTrackCueId/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Id { get; set; }
	///<include file='Utils/Docs/TextTrackCueStartTime/TextTrackCueStartTime.generated.xml' path='docs/TextTrackCueStartTime/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double StartTime { get; set; }
	///<include file='Utils/Docs/TextTrackCueEndTime/TextTrackCueEndTime.generated.xml' path='docs/TextTrackCueEndTime/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double EndTime { get; set; }
	///<include file='Utils/Docs/TextTrackCuePauseOnExit/TextTrackCuePauseOnExit.generated.xml' path='docs/TextTrackCuePauseOnExit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool PauseOnExit { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onenter { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onexit { get; set; }
}

///<include file='Utils/Docs/TimeRanges/TimeRanges.generated.xml' path='docs/TimeRanges/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class TimeRanges
{
	///<include file='Utils/Docs/TimeRangesLength/TimeRangesLength.generated.xml' path='docs/TimeRangesLength/*'/>
	public ulong Length { get; }
	///<include file='Utils/Docs/TimeRangesStart/TimeRangesStart.generated.xml' path='docs/TimeRangesStart/*'/>
	public double Start(ulong index) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/TimeRangesEnd/TimeRangesEnd.generated.xml' path='docs/TimeRangesEnd/*'/>
	public double End(ulong index) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/TrackEvent/TrackEvent.generated.xml' path='docs/TrackEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class TrackEvent : Event
{
	///<include file='Utils/Docs/TrackEventTrackEvent/TrackEventTrackEvent.generated.xml' path='docs/TrackEventTrackEvent/*'/>
	public TrackEvent(string type, TrackEventInit eventInitDict) { }
	///<include file='Utils/Docs/TrackEventTrack/TrackEventTrack.generated.xml' path='docs/TrackEventTrack/*'/>
	public Union21? Track { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class TrackEventInit : EventInit
{
		public Union22? Track;
}

///<include file='Utils/Docs/HTMLMapElement/HTMLMapElement.generated.xml' path='docs/HTMLMapElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLMapElement : HTMLElement
{
		public HTMLMapElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection Areas { get; }
}

///<include file='Utils/Docs/HTMLAreaElement/HTMLAreaElement.generated.xml' path='docs/HTMLAreaElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLAreaElement : HTMLElement, HTMLHyperlinkElementUtils
{
		public HTMLAreaElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Alt { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Coords { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Shape { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Target { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Download { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Ping { get; set; }
	///<include file='Utils/Docs/HTMLAreaElementRel/HTMLAreaElementRel.generated.xml' path='docs/HTMLAreaElementRel/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Rel { get; set; }
	///<include file='Utils/Docs/HTMLAreaElementRelList/HTMLAreaElementRelList.generated.xml' path='docs/HTMLAreaElementRelList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList RelList { get; }
	///<include file='Utils/Docs/HTMLAreaElementReferrerPolicy/HTMLAreaElementReferrerPolicy.generated.xml' path='docs/HTMLAreaElementReferrerPolicy/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ReferrerPolicy { get; set; }
}


///<include file='Utils/Docs/HTMLTableElement/HTMLTableElement.generated.xml' path='docs/HTMLTableElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTableElement : HTMLElement
{
		public HTMLTableElement() { }
	///<include file='Utils/Docs/HTMLTableElementCaption/HTMLTableElementCaption.generated.xml' path='docs/HTMLTableElementCaption/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableCaptionElement? Caption { get; set; }
	///<include file='Utils/Docs/HTMLTableElementCreateCaption/HTMLTableElementCreateCaption.generated.xml' path='docs/HTMLTableElementCreateCaption/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableCaptionElement CreateCaption() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTableElementDeleteCaption/HTMLTableElementDeleteCaption.generated.xml' path='docs/HTMLTableElementDeleteCaption/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined DeleteCaption() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTableElementTHead/HTMLTableElementTHead.generated.xml' path='docs/HTMLTableElementTHead/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableSectionElement? THead { get; set; }
	///<include file='Utils/Docs/HTMLTableElementCreateTHead/HTMLTableElementCreateTHead.generated.xml' path='docs/HTMLTableElementCreateTHead/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableSectionElement CreateTHead() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTableElementDeleteTHead/HTMLTableElementDeleteTHead.generated.xml' path='docs/HTMLTableElementDeleteTHead/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined DeleteTHead() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTableElementTFoot/HTMLTableElementTFoot.generated.xml' path='docs/HTMLTableElementTFoot/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableSectionElement? TFoot { get; set; }
	///<include file='Utils/Docs/HTMLTableElementCreateTFoot/HTMLTableElementCreateTFoot.generated.xml' path='docs/HTMLTableElementCreateTFoot/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableSectionElement CreateTFoot() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTableElementDeleteTFoot/HTMLTableElementDeleteTFoot.generated.xml' path='docs/HTMLTableElementDeleteTFoot/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined DeleteTFoot() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTableElementTBodies/HTMLTableElementTBodies.generated.xml' path='docs/HTMLTableElementTBodies/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection TBodies { get; }
	///<include file='Utils/Docs/HTMLTableElementCreateTBody/HTMLTableElementCreateTBody.generated.xml' path='docs/HTMLTableElementCreateTBody/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableSectionElement CreateTBody() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTableElementRows/HTMLTableElementRows.generated.xml' path='docs/HTMLTableElementRows/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection Rows { get; }
	///<include file='Utils/Docs/HTMLTableElementInsertRow/HTMLTableElementInsertRow.generated.xml' path='docs/HTMLTableElementInsertRow/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableRowElement InsertRow(long index) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTableElementDeleteRow/HTMLTableElementDeleteRow.generated.xml' path='docs/HTMLTableElementDeleteRow/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined DeleteRow(long index) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLTableCaptionElement/HTMLTableCaptionElement.generated.xml' path='docs/HTMLTableCaptionElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTableCaptionElement : HTMLElement
{
		public HTMLTableCaptionElement() { }
}

///<include file='Utils/Docs/HTMLTableColElement/HTMLTableColElement.generated.xml' path='docs/HTMLTableColElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTableColElement : HTMLElement
{
		public HTMLTableColElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Span { get; set; }
}

///<include file='Utils/Docs/HTMLTableSectionElement/HTMLTableSectionElement.generated.xml' path='docs/HTMLTableSectionElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTableSectionElement : HTMLElement
{
		public HTMLTableSectionElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection Rows { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableRowElement InsertRow(long index) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined DeleteRow(long index) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLTableRowElement/HTMLTableRowElement.generated.xml' path='docs/HTMLTableRowElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTableRowElement : HTMLElement
{
		public HTMLTableRowElement() { }
	///<include file='Utils/Docs/HTMLTableRowElementRowIndex/HTMLTableRowElementRowIndex.generated.xml' path='docs/HTMLTableRowElementRowIndex/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public long RowIndex { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public long SectionRowIndex { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection Cells { get; }
	///<include file='Utils/Docs/HTMLTableRowElementInsertCell/HTMLTableRowElementInsertCell.generated.xml' path='docs/HTMLTableRowElementInsertCell/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableCellElement InsertCell(long index) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined DeleteCell(long index) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLTableCellElement/HTMLTableCellElement.generated.xml' path='docs/HTMLTableCellElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTableCellElement : HTMLElement
{
		public HTMLTableCellElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong ColSpan { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong RowSpan { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Headers { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public long CellIndex { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Scope { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Abbr { get; set; }
}

///<include file='Utils/Docs/HTMLFormElement/HTMLFormElement.generated.xml' path='docs/HTMLFormElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLFormElement : HTMLElement
{
		public HTMLFormElement() { }
	///<include file='Utils/Docs/HTMLFormElementAcceptCharset/HTMLFormElementAcceptCharset.generated.xml' path='docs/HTMLFormElementAcceptCharset/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string AcceptCharset { get; set; }
	///<include file='Utils/Docs/HTMLFormElementAction/HTMLFormElementAction.generated.xml' path='docs/HTMLFormElementAction/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Action { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Autocomplete { get; set; }
	///<include file='Utils/Docs/HTMLFormElementEnctype/HTMLFormElementEnctype.generated.xml' path='docs/HTMLFormElementEnctype/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Enctype { get; set; }
	///<include file='Utils/Docs/HTMLFormElementEncoding/HTMLFormElementEncoding.generated.xml' path='docs/HTMLFormElementEncoding/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Encoding { get; set; }
	///<include file='Utils/Docs/HTMLFormElementMethod/HTMLFormElementMethod.generated.xml' path='docs/HTMLFormElementMethod/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Method { get; set; }
	///<include file='Utils/Docs/HTMLFormElementName/HTMLFormElementName.generated.xml' path='docs/HTMLFormElementName/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool NoValidate { get; set; }
	///<include file='Utils/Docs/HTMLFormElementTarget/HTMLFormElementTarget.generated.xml' path='docs/HTMLFormElementTarget/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Target { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Rel { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList RelList { get; }
	///<include file='Utils/Docs/HTMLFormElementElements/HTMLFormElementElements.generated.xml' path='docs/HTMLFormElementElements/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormControlsCollection Elements { get; }
	///<include file='Utils/Docs/HTMLFormElementLength/HTMLFormElementLength.generated.xml' path='docs/HTMLFormElementLength/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Length { get; }
	
	
	///<include file='Utils/Docs/HTMLFormElementSubmit/HTMLFormElementSubmit.generated.xml' path='docs/HTMLFormElementSubmit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Submit() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLFormElementRequestSubmit/HTMLFormElementRequestSubmit.generated.xml' path='docs/HTMLFormElementRequestSubmit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined RequestSubmit(HTMLElement? submitter) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLFormElementReset/HTMLFormElementReset.generated.xml' path='docs/HTMLFormElementReset/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Reset() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLFormElementReportValidity/HTMLFormElementReportValidity.generated.xml' path='docs/HTMLFormElementReportValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLLabelElement/HTMLLabelElement.generated.xml' path='docs/HTMLLabelElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLLabelElement : HTMLElement
{
		public HTMLLabelElement() { }
	///<include file='Utils/Docs/HTMLLabelElementForm/HTMLLabelElementForm.generated.xml' path='docs/HTMLLabelElementForm/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	///<include file='Utils/Docs/HTMLLabelElementHtmlFor/HTMLLabelElementHtmlFor.generated.xml' path='docs/HTMLLabelElementHtmlFor/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string HtmlFor { get; set; }
	///<include file='Utils/Docs/HTMLLabelElementControl/HTMLLabelElementControl.generated.xml' path='docs/HTMLLabelElementControl/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLElement? Control { get; }
}

///<include file='Utils/Docs/HTMLInputElement/HTMLInputElement.generated.xml' path='docs/HTMLInputElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLInputElement : HTMLElement
{
		public HTMLInputElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Accept { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Alt { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Autocomplete { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool DefaultChecked { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Checked { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string DirName { get; set; }
	///<include file='Utils/Docs/HTMLInputElementDisabled/HTMLInputElementDisabled.generated.xml' path='docs/HTMLInputElementDisabled/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	///<include file='Utils/Docs/HTMLInputElementFiles/HTMLInputElementFiles.generated.xml' path='docs/HTMLInputElementFiles/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Unsupported /*FileList*/? Files { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string FormAction { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string FormEnctype { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string FormMethod { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool FormNoValidate { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string FormTarget { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Height { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Indeterminate { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLElement? List { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Max { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public long MaxLength { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Min { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public long MinLength { get; set; }
	///<include file='Utils/Docs/HTMLInputElementMultiple/HTMLInputElementMultiple.generated.xml' path='docs/HTMLInputElementMultiple/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Multiple { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Pattern { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Placeholder { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReadOnly { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Required { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Size { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Step { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string DefaultValue { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public object? ValueAsDate { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public double ValueAsNumber { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Width { get; set; }
	///<include file='Utils/Docs/HTMLInputElementStepUp/HTMLInputElementStepUp.generated.xml' path='docs/HTMLInputElementStepUp/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined StepUp(long n) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLInputElementStepDown/HTMLInputElementStepDown.generated.xml' path='docs/HTMLInputElementStepDown/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined StepDown(long n) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
	///<include file='Utils/Docs/HTMLInputElementCheckValidity/HTMLInputElementCheckValidity.generated.xml' path='docs/HTMLInputElementCheckValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLInputElementReportValidity/HTMLInputElementReportValidity.generated.xml' path='docs/HTMLInputElementReportValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLInputElementSetCustomValidity/HTMLInputElementSetCustomValidity.generated.xml' path='docs/HTMLInputElementSetCustomValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetCustomValidity(string error) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLInputElementLabels/HTMLInputElementLabels.generated.xml' path='docs/HTMLInputElementLabels/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public NodeList? Labels { get; }
	///<include file='Utils/Docs/HTMLInputElementSelect/HTMLInputElementSelect.generated.xml' path='docs/HTMLInputElementSelect/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Select() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong? SelectionStart { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong? SelectionEnd { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string? SelectionDirection { get; set; }
	///<include file='Utils/Docs/HTMLInputElementSetRangeText/HTMLInputElementSetRangeText.generated.xml' path='docs/HTMLInputElementSetRangeText/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetRangeText(string replacement) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLInputElementSetRangeText/HTMLInputElementSetRangeText.generated.xml' path='docs/HTMLInputElementSetRangeText/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetRangeText(string replacement, ulong start, ulong end, SelectionMode selectionMode) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLInputElementSetSelectionRange/HTMLInputElementSetSelectionRange.generated.xml' path='docs/HTMLInputElementSetSelectionRange/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetSelectionRange(ulong start, ulong end, string direction) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLInputElementShowPicker/HTMLInputElementShowPicker.generated.xml' path='docs/HTMLInputElementShowPicker/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined ShowPicker() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLButtonElement/HTMLButtonElement.generated.xml' path='docs/HTMLButtonElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLButtonElement : HTMLElement
{
		public HTMLButtonElement() { }
	///<include file='Utils/Docs/HTMLButtonElementDisabled/HTMLButtonElementDisabled.generated.xml' path='docs/HTMLButtonElementDisabled/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string FormAction { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string FormEnctype { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string FormMethod { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool FormNoValidate { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string FormTarget { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetCustomValidity(string error) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLButtonElementLabels/HTMLButtonElementLabels.generated.xml' path='docs/HTMLButtonElementLabels/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public NodeList Labels { get; }
}

///<include file='Utils/Docs/HTMLSelectElement/HTMLSelectElement.generated.xml' path='docs/HTMLSelectElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLSelectElement : HTMLElement
{
		public HTMLSelectElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Autocomplete { get; set; }
	///<include file='Utils/Docs/HTMLSelectElementDisabled/HTMLSelectElementDisabled.generated.xml' path='docs/HTMLSelectElementDisabled/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	///<include file='Utils/Docs/HTMLSelectElementForm/HTMLSelectElementForm.generated.xml' path='docs/HTMLSelectElementForm/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Multiple { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Required { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Size { get; set; }
	///<include file='Utils/Docs/HTMLSelectElementType/HTMLSelectElementType.generated.xml' path='docs/HTMLSelectElementType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; }
	///<include file='Utils/Docs/HTMLSelectElementOptions/HTMLSelectElementOptions.generated.xml' path='docs/HTMLSelectElementOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLOptionsCollection Options { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Length { get; set; }
	
	///<include file='Utils/Docs/HTMLSelectElementNamedItem/HTMLSelectElementNamedItem.generated.xml' path='docs/HTMLSelectElementNamedItem/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLOptionElement? NamedItem(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLSelectElementAdd/HTMLSelectElementAdd.generated.xml' path='docs/HTMLSelectElementAdd/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Add(Union24 element, Union25? before) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLSelectElementRemove/HTMLSelectElementRemove.generated.xml' path='docs/HTMLSelectElementRemove/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Remove() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLSelectElementRemove/HTMLSelectElementRemove.generated.xml' path='docs/HTMLSelectElementRemove/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Remove(long index) { throw new System.NotImplementedException(); }
	
	///<include file='Utils/Docs/HTMLSelectElementSelectedOptions/HTMLSelectElementSelectedOptions.generated.xml' path='docs/HTMLSelectElementSelectedOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection SelectedOptions { get; }
	///<include file='Utils/Docs/HTMLSelectElementSelectedIndex/HTMLSelectElementSelectedIndex.generated.xml' path='docs/HTMLSelectElementSelectedIndex/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public long SelectedIndex { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
	///<include file='Utils/Docs/HTMLSelectElementCheckValidity/HTMLSelectElementCheckValidity.generated.xml' path='docs/HTMLSelectElementCheckValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLSelectElementSetCustomValidity/HTMLSelectElementSetCustomValidity.generated.xml' path='docs/HTMLSelectElementSetCustomValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetCustomValidity(string error) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLSelectElementLabels/HTMLSelectElementLabels.generated.xml' path='docs/HTMLSelectElementLabels/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public NodeList Labels { get; }
}

///<include file='Utils/Docs/HTMLDataListElement/HTMLDataListElement.generated.xml' path='docs/HTMLDataListElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLDataListElement : HTMLElement
{
		public HTMLDataListElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection Options { get; }
}

///<include file='Utils/Docs/HTMLOptGroupElement/HTMLOptGroupElement.generated.xml' path='docs/HTMLOptGroupElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLOptGroupElement : HTMLElement
{
		public HTMLOptGroupElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Label { get; set; }
}

///<include file='Utils/Docs/HTMLOptionElement/HTMLOptionElement.generated.xml' path='docs/HTMLOptionElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLOptionElement : HTMLElement
{
		public HTMLOptionElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Label { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool DefaultSelected { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Selected { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Text { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public long Index { get; }
}

///<include file='Utils/Docs/HTMLTextAreaElement/HTMLTextAreaElement.generated.xml' path='docs/HTMLTextAreaElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTextAreaElement : HTMLElement
{
		public HTMLTextAreaElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Autocomplete { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Cols { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string DirName { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public long MaxLength { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public long MinLength { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Placeholder { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReadOnly { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Required { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Rows { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Wrap { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string DefaultValue { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong TextLength { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetCustomValidity(string error) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTextAreaElementLabels/HTMLTextAreaElementLabels.generated.xml' path='docs/HTMLTextAreaElementLabels/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public NodeList Labels { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Select() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong SelectionStart { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong SelectionEnd { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string SelectionDirection { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetRangeText(string replacement) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetRangeText(string replacement, ulong start, ulong end, SelectionMode selectionMode) { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetSelectionRange(ulong start, ulong end, string direction) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLOutputElement/HTMLOutputElement.generated.xml' path='docs/HTMLOutputElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLOutputElement : HTMLElement
{
		public HTMLOutputElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList HtmlFor { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string DefaultValue { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetCustomValidity(string error) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLOutputElementLabels/HTMLOutputElementLabels.generated.xml' path='docs/HTMLOutputElementLabels/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public NodeList Labels { get; }
}

///<include file='Utils/Docs/HTMLProgressElement/HTMLProgressElement.generated.xml' path='docs/HTMLProgressElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLProgressElement : HTMLElement
{
		public HTMLProgressElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public double Value { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public double Max { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public double Position { get; }
	///<include file='Utils/Docs/HTMLProgressElementLabels/HTMLProgressElementLabels.generated.xml' path='docs/HTMLProgressElementLabels/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public NodeList Labels { get; }
}

///<include file='Utils/Docs/HTMLMeterElement/HTMLMeterElement.generated.xml' path='docs/HTMLMeterElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLMeterElement : HTMLElement
{
		public HTMLMeterElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public double Value { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public double Min { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public double Max { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public double Low { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public double High { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public double Optimum { get; set; }
	///<include file='Utils/Docs/HTMLMeterElementLabels/HTMLMeterElementLabels.generated.xml' path='docs/HTMLMeterElementLabels/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public NodeList Labels { get; }
}

///<include file='Utils/Docs/HTMLFieldSetElement/HTMLFieldSetElement.generated.xml' path='docs/HTMLFieldSetElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLFieldSetElement : HTMLElement
{
		public HTMLFieldSetElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection Elements { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetCustomValidity(string error) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLLegendElement/HTMLLegendElement.generated.xml' path='docs/HTMLLegendElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLLegendElement : HTMLElement
{
		public HTMLLegendElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
}

public enum SelectionMode
{
	Select,
	Start,
	End,
	Preserve,
}

///<include file='Utils/Docs/ValidityState/ValidityState.generated.xml' path='docs/ValidityState/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ValidityState
{
	///<include file='Utils/Docs/ValidityStateValueMissing/ValidityStateValueMissing.generated.xml' path='docs/ValidityStateValueMissing/*'/>
	public bool ValueMissing { get; }
	///<include file='Utils/Docs/ValidityStateTypeMismatch/ValidityStateTypeMismatch.generated.xml' path='docs/ValidityStateTypeMismatch/*'/>
	public bool TypeMismatch { get; }
	///<include file='Utils/Docs/ValidityStatePatternMismatch/ValidityStatePatternMismatch.generated.xml' path='docs/ValidityStatePatternMismatch/*'/>
	public bool PatternMismatch { get; }
	///<include file='Utils/Docs/ValidityStateTooLong/ValidityStateTooLong.generated.xml' path='docs/ValidityStateTooLong/*'/>
	public bool TooLong { get; }
	///<include file='Utils/Docs/ValidityStateTooShort/ValidityStateTooShort.generated.xml' path='docs/ValidityStateTooShort/*'/>
	public bool TooShort { get; }
	///<include file='Utils/Docs/ValidityStateRangeUnderflow/ValidityStateRangeUnderflow.generated.xml' path='docs/ValidityStateRangeUnderflow/*'/>
	public bool RangeUnderflow { get; }
	///<include file='Utils/Docs/ValidityStateRangeOverflow/ValidityStateRangeOverflow.generated.xml' path='docs/ValidityStateRangeOverflow/*'/>
	public bool RangeOverflow { get; }
	///<include file='Utils/Docs/ValidityStateStepMismatch/ValidityStateStepMismatch.generated.xml' path='docs/ValidityStateStepMismatch/*'/>
	public bool StepMismatch { get; }
	///<include file='Utils/Docs/ValidityStateBadInput/ValidityStateBadInput.generated.xml' path='docs/ValidityStateBadInput/*'/>
	public bool BadInput { get; }
		public bool CustomError { get; }
		public bool Valid { get; }
}

///<include file='Utils/Docs/SubmitEvent/SubmitEvent.generated.xml' path='docs/SubmitEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SubmitEvent : Event
{
	///<include file='Utils/Docs/SubmitEventSubmitEvent/SubmitEventSubmitEvent.generated.xml' path='docs/SubmitEventSubmitEvent/*'/>
	public SubmitEvent(string type, SubmitEventInit eventInitDict) { }
	///<include file='Utils/Docs/SubmitEventSubmitter/SubmitEventSubmitter.generated.xml' path='docs/SubmitEventSubmitter/*'/>
	public HTMLElement? Submitter { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class SubmitEventInit : EventInit
{
		public HTMLElement? Submitter;
}

///<include file='Utils/Docs/FormDataEvent/FormDataEvent.generated.xml' path='docs/FormDataEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FormDataEvent : Event
{
	///<include file='Utils/Docs/FormDataEventFormDataEvent/FormDataEventFormDataEvent.generated.xml' path='docs/FormDataEventFormDataEvent/*'/>
	public FormDataEvent(string type, FormDataEventInit eventInitDict) { }
	///<include file='Utils/Docs/FormDataEventFormData/FormDataEventFormData.generated.xml' path='docs/FormDataEventFormData/*'/>
	public FormData FormData { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FormDataEventInit : EventInit
{
		public required FormData FormData;
}

///<include file='Utils/Docs/HTMLDetailsElement/HTMLDetailsElement.generated.xml' path='docs/HTMLDetailsElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLDetailsElement : HTMLElement
{
		public HTMLDetailsElement() { }
	///<include file='Utils/Docs/HTMLDetailsElementOpen/HTMLDetailsElementOpen.generated.xml' path='docs/HTMLDetailsElementOpen/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Open { get; set; }
}

///<include file='Utils/Docs/HTMLDialogElement/HTMLDialogElement.generated.xml' path='docs/HTMLDialogElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLDialogElement : HTMLElement
{
		public HTMLDialogElement() { }
	///<include file='Utils/Docs/HTMLDialogElementOpen/HTMLDialogElementOpen.generated.xml' path='docs/HTMLDialogElementOpen/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Open { get; set; }
	///<include file='Utils/Docs/HTMLDialogElementReturnValue/HTMLDialogElementReturnValue.generated.xml' path='docs/HTMLDialogElementReturnValue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ReturnValue { get; set; }
	///<include file='Utils/Docs/HTMLDialogElementShow/HTMLDialogElementShow.generated.xml' path='docs/HTMLDialogElementShow/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Show() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLDialogElementShowModal/HTMLDialogElementShowModal.generated.xml' path='docs/HTMLDialogElementShowModal/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined ShowModal() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLDialogElementClose/HTMLDialogElementClose.generated.xml' path='docs/HTMLDialogElementClose/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Close(string returnValue) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLScriptElement/HTMLScriptElement.generated.xml' path='docs/HTMLScriptElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLScriptElement : HTMLElement
{
		public HTMLScriptElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool NoModule { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Async { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Defer { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string? CrossOrigin { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Text { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Integrity { get; set; }
	///<include file='Utils/Docs/HTMLScriptElementReferrerPolicy/HTMLScriptElementReferrerPolicy.generated.xml' path='docs/HTMLScriptElementReferrerPolicy/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ReferrerPolicy { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList Blocking { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public static bool Supports(string type) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLTemplateElement/HTMLTemplateElement.generated.xml' path='docs/HTMLTemplateElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTemplateElement : HTMLElement
{
		public HTMLTemplateElement() { }
	///<include file='Utils/Docs/HTMLTemplateElementContent/HTMLTemplateElementContent.generated.xml' path='docs/HTMLTemplateElementContent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public DocumentFragment Content { get; }
}

///<include file='Utils/Docs/HTMLSlotElement/HTMLSlotElement.generated.xml' path='docs/HTMLSlotElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLSlotElement : HTMLElement
{
		public HTMLSlotElement() { }
	///<include file='Utils/Docs/HTMLSlotElementName/HTMLSlotElementName.generated.xml' path='docs/HTMLSlotElementName/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	///<include file='Utils/Docs/HTMLSlotElementAssignedNodes/HTMLSlotElementAssignedNodes.generated.xml' path='docs/HTMLSlotElementAssignedNodes/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public List<Node> AssignedNodes(AssignedNodesOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLSlotElementAssignedElements/HTMLSlotElementAssignedElements.generated.xml' path='docs/HTMLSlotElementAssignedElements/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public List<Element> AssignedElements(AssignedNodesOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLSlotElementAssign/HTMLSlotElementAssign.generated.xml' path='docs/HTMLSlotElementAssign/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Assign(params Union26[] nodes) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class AssignedNodesOptions
{
		public bool Flatten;
}


///<include file='Utils/Docs/HTMLCanvasElement/HTMLCanvasElement.generated.xml' path='docs/HTMLCanvasElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLCanvasElement : HTMLElement
{
		public HTMLCanvasElement() { }
	///<include file='Utils/Docs/HTMLCanvasElementWidth/HTMLCanvasElementWidth.generated.xml' path='docs/HTMLCanvasElementWidth/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Width { get; set; }
	///<include file='Utils/Docs/HTMLCanvasElementHeight/HTMLCanvasElementHeight.generated.xml' path='docs/HTMLCanvasElementHeight/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Height { get; set; }
	///<include file='Utils/Docs/HTMLCanvasElementGetContext/HTMLCanvasElementGetContext.generated.xml' path='docs/HTMLCanvasElementGetContext/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public RenderingContext? GetContext(string contextId, dynamic options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLCanvasElementToDataURL/HTMLCanvasElementToDataURL.generated.xml' path='docs/HTMLCanvasElementToDataURL/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ToDataURL(string type, dynamic quality) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLCanvasElementToBlob/HTMLCanvasElementToBlob.generated.xml' path='docs/HTMLCanvasElementToBlob/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined ToBlob(BlobCallback callback, string type, dynamic quality) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLCanvasElementTransferControlToOffscreen/HTMLCanvasElementTransferControlToOffscreen.generated.xml' path='docs/HTMLCanvasElementTransferControlToOffscreen/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public OffscreenCanvas TransferControlToOffscreen() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct BlobCallback
{
}



public enum PredefinedColorSpace
{
	Srgb,
	DisplayP3,
}

public enum CanvasFillRule
{
	Nonzero,
	Evenodd,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class CanvasRenderingContext2DSettings
{
		public bool Alpha;
		public bool Desynchronized;
		public PredefinedColorSpace ColorSpace;
		public bool WillReadFrequently;
}

public enum ImageSmoothingQuality
{
	Low,
	Medium,
	High,
}

///<include file='Utils/Docs/CanvasRenderingContext2D/CanvasRenderingContext2D.generated.xml' path='docs/CanvasRenderingContext2D/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CanvasRenderingContext2D
{
	///<include file='Utils/Docs/CanvasRenderingContext2DCanvas/CanvasRenderingContext2DCanvas.generated.xml' path='docs/CanvasRenderingContext2DCanvas/*'/>
	public HTMLCanvasElement Canvas { get; }
	///<include file='Utils/Docs/CanvasRenderingContext2DGetContextAttributes/CanvasRenderingContext2DGetContextAttributes.generated.xml' path='docs/CanvasRenderingContext2DGetContextAttributes/*'/>
	public CanvasRenderingContext2DSettings GetContextAttributes() { throw new System.NotImplementedException(); }
}

















[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasState
{
		public Undefined Save() { throw new System.NotImplementedException(); }
		public Undefined Restore() { throw new System.NotImplementedException(); }
		public Undefined Reset() { throw new System.NotImplementedException(); }
		public bool IsContextLost() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasTransform
{
		public Undefined Scale(double x, double y) { throw new System.NotImplementedException(); }
		public Undefined Rotate(double angle) { throw new System.NotImplementedException(); }
		public Undefined Translate(double x, double y) { throw new System.NotImplementedException(); }
		public Undefined Transform(double a, double b, double c, double d, double e, double f) { throw new System.NotImplementedException(); }
		public Unsupported /*DOMMatrix*/ GetTransform() { throw new System.NotImplementedException(); }
		public Undefined SetTransform(double a, double b, double c, double d, double e, double f) { throw new System.NotImplementedException(); }
		public Undefined SetTransform(Unsupported /*DOMMatrix2DInit*/ transform) { throw new System.NotImplementedException(); }
		public Undefined ResetTransform() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasCompositing
{
		public double GlobalAlpha { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string GlobalCompositeOperation { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasImageSmoothing
{
		public bool ImageSmoothingEnabled { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public ImageSmoothingQuality ImageSmoothingQuality { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasFillStrokeStyles
{
		public Union30 StrokeStyle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public Union31 FillStyle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasGradient CreateLinearGradient(double x0, double y0, double x1, double y1) { throw new System.NotImplementedException(); }
		public CanvasGradient CreateRadialGradient(double x0, double y0, double r0, double x1, double y1, double r1) { throw new System.NotImplementedException(); }
		public CanvasGradient CreateConicGradient(double startAngle, double x, double y) { throw new System.NotImplementedException(); }
		public CanvasPattern? CreatePattern(CanvasImageSource image, string repetition) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasShadowStyles
{
		public double ShadowOffsetX { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public double ShadowOffsetY { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public double ShadowBlur { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string ShadowColor { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasFilters
{
		public Union32 Filter { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class CanvasFilter
{
		public CanvasFilter(Union33 filters) { }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasRect
{
		public Undefined ClearRect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
		public Undefined FillRect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
		public Undefined StrokeRect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasDrawPath
{
		public Undefined BeginPath() { throw new System.NotImplementedException(); }
		public Undefined Fill(CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
		public Undefined Fill(Path2D path, CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
		public Undefined Stroke() { throw new System.NotImplementedException(); }
		public Undefined Stroke(Path2D path) { throw new System.NotImplementedException(); }
		public Undefined Clip(CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
		public Undefined Clip(Path2D path, CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
		public bool IsPointInPath(double x, double y, CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
		public bool IsPointInPath(Path2D path, double x, double y, CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
		public bool IsPointInStroke(double x, double y) { throw new System.NotImplementedException(); }
		public bool IsPointInStroke(Path2D path, double x, double y) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasUserInterface
{
		public Undefined DrawFocusIfNeeded(Element element) { throw new System.NotImplementedException(); }
		public Undefined DrawFocusIfNeeded(Path2D path, Element element) { throw new System.NotImplementedException(); }
		public Undefined ScrollPathIntoView() { throw new System.NotImplementedException(); }
		public Undefined ScrollPathIntoView(Path2D path) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasText
{
		public Undefined FillText(string text, double x, double y, double maxWidth) { throw new System.NotImplementedException(); }
		public Undefined StrokeText(string text, double x, double y, double maxWidth) { throw new System.NotImplementedException(); }
		public TextMetrics MeasureText(string text) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasDrawImage
{
		public Undefined DrawImage(CanvasImageSource image, double dx, double dy) { throw new System.NotImplementedException(); }
		public Undefined DrawImage(CanvasImageSource image, double dx, double dy, double dw, double dh) { throw new System.NotImplementedException(); }
		public Undefined DrawImage(CanvasImageSource image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasImageData
{
		public ImageData CreateImageData(long sw, long sh, ImageDataSettings settings) { throw new System.NotImplementedException(); }
		public ImageData CreateImageData(ImageData imagedata) { throw new System.NotImplementedException(); }
		public ImageData GetImageData(long sx, long sy, long sw, long sh, ImageDataSettings settings) { throw new System.NotImplementedException(); }
		public Undefined PutImageData(ImageData imagedata, long dx, long dy) { throw new System.NotImplementedException(); }
		public Undefined PutImageData(ImageData imagedata, long dx, long dy, long dirtyX, long dirtyY, long dirtyWidth, long dirtyHeight) { throw new System.NotImplementedException(); }
}

public enum CanvasLineCap
{
	Butt,
	Round,
	Square,
}

public enum CanvasLineJoin
{
	Round,
	Bevel,
	Miter,
}

public enum CanvasTextAlign
{
	Start,
	End,
	Left,
	Right,
	Center,
}

public enum CanvasTextBaseline
{
	Top,
	Hanging,
	Middle,
	Alphabetic,
	Ideographic,
	Bottom,
}

public enum CanvasDirection
{
	Ltr,
	Rtl,
	Inherit,
}

public enum CanvasFontKerning
{
	Auto,
	Normal,
	None,
}

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

public enum CanvasTextRendering
{
	Auto,
	OptimizeSpeed,
	OptimizeLegibility,
	GeometricPrecision,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasPathDrawingStyles
{
		public double LineWidth { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasLineCap LineCap { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasLineJoin LineJoin { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public double MiterLimit { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public Undefined SetLineDash(List<double> segments) { throw new System.NotImplementedException(); }
		public List<double> GetLineDash() { throw new System.NotImplementedException(); }
		public double LineDashOffset { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasTextDrawingStyles
{
		public string Font { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasTextAlign TextAlign { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasTextBaseline TextBaseline { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasDirection Direction { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string LetterSpacing { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasFontKerning FontKerning { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasFontStretch FontStretch { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasFontVariantCaps FontVariantCaps { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public CanvasTextRendering TextRendering { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string WordSpacing { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasPath
{
		public Undefined ClosePath() { throw new System.NotImplementedException(); }
		public Undefined MoveTo(double x, double y) { throw new System.NotImplementedException(); }
		public Undefined LineTo(double x, double y) { throw new System.NotImplementedException(); }
		public Undefined QuadraticCurveTo(double cpx, double cpy, double x, double y) { throw new System.NotImplementedException(); }
		public Undefined BezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y) { throw new System.NotImplementedException(); }
		public Undefined ArcTo(double x1, double y1, double x2, double y2, double radius) { throw new System.NotImplementedException(); }
		public Undefined Rect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
		public Undefined RoundRect(double x, double y, double w, double h, Union34 radii) { throw new System.NotImplementedException(); }
		public Undefined Arc(double x, double y, double radius, double startAngle, double endAngle, bool counterclockwise) { throw new System.NotImplementedException(); }
		public Undefined Ellipse(double x, double y, double radiusX, double radiusY, double rotation, double startAngle, double endAngle, bool counterclockwise) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/CanvasGradient/CanvasGradient.generated.xml' path='docs/CanvasGradient/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CanvasGradient
{
	///<include file='Utils/Docs/CanvasGradientAddColorStop/CanvasGradientAddColorStop.generated.xml' path='docs/CanvasGradientAddColorStop/*'/>
	public Undefined AddColorStop(double offset, string color) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/CanvasPattern/CanvasPattern.generated.xml' path='docs/CanvasPattern/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CanvasPattern
{
	///<include file='Utils/Docs/CanvasPatternSetTransform/CanvasPatternSetTransform.generated.xml' path='docs/CanvasPatternSetTransform/*'/>
	public Undefined SetTransform(Unsupported /*DOMMatrix2DInit*/ transform) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/TextMetrics/TextMetrics.generated.xml' path='docs/TextMetrics/*'/>
[To(ToAttribute.Default)]
public partial class TextMetrics
{
	///<include file='Utils/Docs/TextMetricsWidth/TextMetricsWidth.generated.xml' path='docs/TextMetricsWidth/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double Width { get; }
	///<include file='Utils/Docs/TextMetricsActualBoundingBoxLeft/TextMetricsActualBoundingBoxLeft.generated.xml' path='docs/TextMetricsActualBoundingBoxLeft/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double ActualBoundingBoxLeft { get; }
	///<include file='Utils/Docs/TextMetricsActualBoundingBoxRight/TextMetricsActualBoundingBoxRight.generated.xml' path='docs/TextMetricsActualBoundingBoxRight/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double ActualBoundingBoxRight { get; }
	///<include file='Utils/Docs/TextMetricsFontBoundingBoxAscent/TextMetricsFontBoundingBoxAscent.generated.xml' path='docs/TextMetricsFontBoundingBoxAscent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double FontBoundingBoxAscent { get; }
	///<include file='Utils/Docs/TextMetricsFontBoundingBoxDescent/TextMetricsFontBoundingBoxDescent.generated.xml' path='docs/TextMetricsFontBoundingBoxDescent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double FontBoundingBoxDescent { get; }
	///<include file='Utils/Docs/TextMetricsActualBoundingBoxAscent/TextMetricsActualBoundingBoxAscent.generated.xml' path='docs/TextMetricsActualBoundingBoxAscent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double ActualBoundingBoxAscent { get; }
	///<include file='Utils/Docs/TextMetricsActualBoundingBoxDescent/TextMetricsActualBoundingBoxDescent.generated.xml' path='docs/TextMetricsActualBoundingBoxDescent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double ActualBoundingBoxDescent { get; }
	///<include file='Utils/Docs/TextMetricsEmHeightAscent/TextMetricsEmHeightAscent.generated.xml' path='docs/TextMetricsEmHeightAscent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double EmHeightAscent { get; }
	///<include file='Utils/Docs/TextMetricsEmHeightDescent/TextMetricsEmHeightDescent.generated.xml' path='docs/TextMetricsEmHeightDescent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double EmHeightDescent { get; }
	///<include file='Utils/Docs/TextMetricsHangingBaseline/TextMetricsHangingBaseline.generated.xml' path='docs/TextMetricsHangingBaseline/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double HangingBaseline { get; }
	///<include file='Utils/Docs/TextMetricsAlphabeticBaseline/TextMetricsAlphabeticBaseline.generated.xml' path='docs/TextMetricsAlphabeticBaseline/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double AlphabeticBaseline { get; }
	///<include file='Utils/Docs/TextMetricsIdeographicBaseline/TextMetricsIdeographicBaseline.generated.xml' path='docs/TextMetricsIdeographicBaseline/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double IdeographicBaseline { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageDataSettings
{
		public PredefinedColorSpace ColorSpace;
}

///<include file='Utils/Docs/ImageData/ImageData.generated.xml' path='docs/ImageData/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageData
{
	///<include file='Utils/Docs/ImageDataImageData/ImageDataImageData.generated.xml' path='docs/ImageDataImageData/*'/>
	public ImageData(ulong sw, ulong sh, ImageDataSettings settings) { }
	///<include file='Utils/Docs/ImageDataImageData/ImageDataImageData.generated.xml' path='docs/ImageDataImageData/*'/>
	public ImageData(Unsupported /*Uint8ClampedArray*/ data, ulong sw, ulong sh, ImageDataSettings settings) { }
	///<include file='Utils/Docs/ImageDataWidth/ImageDataWidth.generated.xml' path='docs/ImageDataWidth/*'/>
	public ulong Width { get; }
	///<include file='Utils/Docs/ImageDataHeight/ImageDataHeight.generated.xml' path='docs/ImageDataHeight/*'/>
	public ulong Height { get; }
	///<include file='Utils/Docs/ImageDataData/ImageDataData.generated.xml' path='docs/ImageDataData/*'/>
	public Unsupported /*Uint8ClampedArray*/ Data { get; }
	///<include file='Utils/Docs/ImageDataColorSpace/ImageDataColorSpace.generated.xml' path='docs/ImageDataColorSpace/*'/>
	public PredefinedColorSpace ColorSpace { get; }
}

///<include file='Utils/Docs/Path2D/Path2D.generated.xml' path='docs/Path2D/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Path2D
{
	///<include file='Utils/Docs/Path2DPath2D/Path2DPath2D.generated.xml' path='docs/Path2DPath2D/*'/>
	public Path2D(Union36 path) { }
	///<include file='Utils/Docs/Path2DAddPath/Path2DAddPath.generated.xml' path='docs/Path2DAddPath/*'/>
	public Undefined AddPath(Path2D path, Unsupported /*DOMMatrix2DInit*/ transform) { throw new System.NotImplementedException(); }
}


///<include file='Utils/Docs/ImageBitmapRenderingContext/ImageBitmapRenderingContext.generated.xml' path='docs/ImageBitmapRenderingContext/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageBitmapRenderingContext
{
		public Union37 Canvas { get; }
	///<include file='Utils/Docs/ImageBitmapRenderingContextTransferFromImageBitmap/ImageBitmapRenderingContextTransferFromImageBitmap.generated.xml' path='docs/ImageBitmapRenderingContextTransferFromImageBitmap/*'/>
	public Undefined TransferFromImageBitmap(ImageBitmap? bitmap) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageBitmapRenderingContextSettings
{
		public bool Alpha;
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageEncodeOptions
{
		public string Type;
		public double Quality;
}

public enum OffscreenRenderingContextId
{
	_2d,
	Bitmaprenderer,
	Webgl,
	Webgl2,
	Webgpu,
}

///<include file='Utils/Docs/OffscreenCanvas/OffscreenCanvas.generated.xml' path='docs/OffscreenCanvas/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class OffscreenCanvas : EventTarget
{
	///<include file='Utils/Docs/OffscreenCanvasOffscreenCanvas/OffscreenCanvasOffscreenCanvas.generated.xml' path='docs/OffscreenCanvasOffscreenCanvas/*'/>
	public OffscreenCanvas(ulong width, ulong height) { }
	///<include file='Utils/Docs/OffscreenCanvasWidth/OffscreenCanvasWidth.generated.xml' path='docs/OffscreenCanvasWidth/*'/>
	public ulong Width { get; set; }
	///<include file='Utils/Docs/OffscreenCanvasHeight/OffscreenCanvasHeight.generated.xml' path='docs/OffscreenCanvasHeight/*'/>
	public ulong Height { get; set; }
	///<include file='Utils/Docs/OffscreenCanvasGetContext/OffscreenCanvasGetContext.generated.xml' path='docs/OffscreenCanvasGetContext/*'/>
	public OffscreenRenderingContext? GetContext(OffscreenRenderingContextId contextId, dynamic options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/OffscreenCanvasTransferToImageBitmap/OffscreenCanvasTransferToImageBitmap.generated.xml' path='docs/OffscreenCanvasTransferToImageBitmap/*'/>
	public ImageBitmap TransferToImageBitmap() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/OffscreenCanvasConvertToBlob/OffscreenCanvasConvertToBlob.generated.xml' path='docs/OffscreenCanvasConvertToBlob/*'/>
	public Task<Unsupported /*Blob*/> ConvertToBlob(ImageEncodeOptions options) { throw new System.NotImplementedException(); }
		public EventHandler Oncontextlost { get; set; }
		public EventHandler Oncontextrestored { get; set; }
}

///<include file='Utils/Docs/OffscreenCanvasRenderingContext2D/OffscreenCanvasRenderingContext2D.generated.xml' path='docs/OffscreenCanvasRenderingContext2D/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class OffscreenCanvasRenderingContext2D
{
	///<include file='Utils/Docs/OffscreenCanvasRenderingContext2DCommit/OffscreenCanvasRenderingContext2DCommit.generated.xml' path='docs/OffscreenCanvasRenderingContext2DCommit/*'/>
	public Undefined Commit() { throw new System.NotImplementedException(); }
		public OffscreenCanvas Canvas { get; }
}
















///<include file='Utils/Docs/CustomElementRegistry/CustomElementRegistry.generated.xml' path='docs/CustomElementRegistry/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CustomElementRegistry
{
	///<include file='Utils/Docs/CustomElementRegistryDefine/CustomElementRegistryDefine.generated.xml' path='docs/CustomElementRegistryDefine/*'/>
	public Undefined Define(string name, CustomElementConstructor constructor, ElementDefinitionOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CustomElementRegistryGet/CustomElementRegistryGet.generated.xml' path='docs/CustomElementRegistryGet/*'/>
	public Union39 Get(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CustomElementRegistryWhenDefined/CustomElementRegistryWhenDefined.generated.xml' path='docs/CustomElementRegistryWhenDefined/*'/>
	public Task<CustomElementConstructor> WhenDefined(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CustomElementRegistryUpgrade/CustomElementRegistryUpgrade.generated.xml' path='docs/CustomElementRegistryUpgrade/*'/>
	public Undefined Upgrade(Node root) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct CustomElementConstructor
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ElementDefinitionOptions
{
		public string Extends;
}

///<include file='Utils/Docs/ElementInternals/ElementInternals.generated.xml' path='docs/ElementInternals/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ElementInternals
{
	///<include file='Utils/Docs/ElementInternalsShadowRoot/ElementInternalsShadowRoot.generated.xml' path='docs/ElementInternalsShadowRoot/*'/>
	public ShadowRoot? ShadowRoot { get; }
	///<include file='Utils/Docs/ElementInternalsSetFormValue/ElementInternalsSetFormValue.generated.xml' path='docs/ElementInternalsSetFormValue/*'/>
	public Undefined SetFormValue(Union40? value, Union41? state) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementInternalsForm/ElementInternalsForm.generated.xml' path='docs/ElementInternalsForm/*'/>
	public HTMLFormElement? Form { get; }
	///<include file='Utils/Docs/ElementInternalsSetValidity/ElementInternalsSetValidity.generated.xml' path='docs/ElementInternalsSetValidity/*'/>
	public Undefined SetValidity(ValidityStateFlags flags, string message, HTMLElement anchor) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementInternalsWillValidate/ElementInternalsWillValidate.generated.xml' path='docs/ElementInternalsWillValidate/*'/>
	public bool WillValidate { get; }
	///<include file='Utils/Docs/ElementInternalsValidity/ElementInternalsValidity.generated.xml' path='docs/ElementInternalsValidity/*'/>
	public ValidityState Validity { get; }
	///<include file='Utils/Docs/ElementInternalsValidationMessage/ElementInternalsValidationMessage.generated.xml' path='docs/ElementInternalsValidationMessage/*'/>
	public string ValidationMessage { get; }
	///<include file='Utils/Docs/ElementInternalsCheckValidity/ElementInternalsCheckValidity.generated.xml' path='docs/ElementInternalsCheckValidity/*'/>
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementInternalsReportValidity/ElementInternalsReportValidity.generated.xml' path='docs/ElementInternalsReportValidity/*'/>
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementInternalsLabels/ElementInternalsLabels.generated.xml' path='docs/ElementInternalsLabels/*'/>
	public NodeList Labels { get; }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial class ValidityStateFlags
{
		public bool ValueMissing;
		public bool TypeMismatch;
		public bool PatternMismatch;
		public bool TooLong;
		public bool TooShort;
		public bool RangeUnderflow;
		public bool RangeOverflow;
		public bool StepMismatch;
		public bool BadInput;
		public bool CustomError;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class FocusOptions
{
		public bool PreventScroll;
		public bool FocusVisible;
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface ElementContentEditable
{
		public string ContentEditable { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public string EnterKeyHint { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public bool IsContentEditable { get { throw new System.NotImplementedException(); } }
		public string InputMode { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/DataTransfer/DataTransfer.generated.xml' path='docs/DataTransfer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DataTransfer
{
	///<include file='Utils/Docs/DataTransferDataTransfer/DataTransferDataTransfer.generated.xml' path='docs/DataTransferDataTransfer/*'/>
	public DataTransfer() { }
	///<include file='Utils/Docs/DataTransferDropEffect/DataTransferDropEffect.generated.xml' path='docs/DataTransferDropEffect/*'/>
	public string DropEffect { get; set; }
	///<include file='Utils/Docs/DataTransferEffectAllowed/DataTransferEffectAllowed.generated.xml' path='docs/DataTransferEffectAllowed/*'/>
	public string EffectAllowed { get; set; }
	///<include file='Utils/Docs/DataTransferItems/DataTransferItems.generated.xml' path='docs/DataTransferItems/*'/>
	public DataTransferItemList Items { get; }
	///<include file='Utils/Docs/DataTransferSetDragImage/DataTransferSetDragImage.generated.xml' path='docs/DataTransferSetDragImage/*'/>
	public Undefined SetDragImage(Element image, long x, long y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DataTransferTypes/DataTransferTypes.generated.xml' path='docs/DataTransferTypes/*'/>
	public string[] Types { get; }
	///<include file='Utils/Docs/DataTransferGetData/DataTransferGetData.generated.xml' path='docs/DataTransferGetData/*'/>
	public string GetData(string format) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DataTransferSetData/DataTransferSetData.generated.xml' path='docs/DataTransferSetData/*'/>
	public Undefined SetData(string format, string data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DataTransferClearData/DataTransferClearData.generated.xml' path='docs/DataTransferClearData/*'/>
	public Undefined ClearData(string format) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DataTransferFiles/DataTransferFiles.generated.xml' path='docs/DataTransferFiles/*'/>
	public Unsupported /*FileList*/ Files { get; }
}

///<include file='Utils/Docs/DataTransferItemList/DataTransferItemList.generated.xml' path='docs/DataTransferItemList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DataTransferItemList
{
	///<include file='Utils/Docs/DataTransferItemListLength/DataTransferItemListLength.generated.xml' path='docs/DataTransferItemListLength/*'/>
	public ulong Length { get; }
	
	///<include file='Utils/Docs/DataTransferItemListAdd/DataTransferItemListAdd.generated.xml' path='docs/DataTransferItemListAdd/*'/>
	public DataTransferItem? Add(string data, string type) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DataTransferItemListAdd/DataTransferItemListAdd.generated.xml' path='docs/DataTransferItemListAdd/*'/>
	public DataTransferItem? Add(Unsupported /*File*/ data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DataTransferItemListRemove/DataTransferItemListRemove.generated.xml' path='docs/DataTransferItemListRemove/*'/>
	public Undefined Remove(ulong index) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DataTransferItemListClear/DataTransferItemListClear.generated.xml' path='docs/DataTransferItemListClear/*'/>
	public Undefined Clear() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/DataTransferItem/DataTransferItem.generated.xml' path='docs/DataTransferItem/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DataTransferItem
{
	///<include file='Utils/Docs/DataTransferItemKind/DataTransferItemKind.generated.xml' path='docs/DataTransferItemKind/*'/>
	public string Kind { get; }
	///<include file='Utils/Docs/DataTransferItemType/DataTransferItemType.generated.xml' path='docs/DataTransferItemType/*'/>
	public string Type { get; }
	///<include file='Utils/Docs/DataTransferItemGetAsString/DataTransferItemGetAsString.generated.xml' path='docs/DataTransferItemGetAsString/*'/>
	public Undefined GetAsString(FunctionStringCallback? callback) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DataTransferItemGetAsFile/DataTransferItemGetAsFile.generated.xml' path='docs/DataTransferItemGetAsFile/*'/>
	public Unsupported /*File*/? GetAsFile() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct FunctionStringCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct FunctionObjectCallback
{
}

///<include file='Utils/Docs/DragEvent/DragEvent.generated.xml' path='docs/DragEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DragEvent
{
	///<include file='Utils/Docs/DragEventDragEvent/DragEventDragEvent.generated.xml' path='docs/DragEventDragEvent/*'/>
	public DragEvent(string type, DragEventInit eventInitDict) { }
	///<include file='Utils/Docs/DragEventDataTransfer/DragEventDataTransfer.generated.xml' path='docs/DragEventDataTransfer/*'/>
	public DataTransfer? DataTransfer { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class DragEventInit
{
		public DataTransfer? DataTransfer;
}

///<include file='Utils/Docs/Window/Window.generated.xml' path='docs/Window/*'/>
public partial class Window : EventTarget
{
	///<include file='Utils/Docs/WindowWindow/WindowWindow.generated.xml' path='docs/WindowWindow/*'/>
	public Window _window { get; }
	///<include file='Utils/Docs/WindowSelf/WindowSelf.generated.xml' path='docs/WindowSelf/*'/>
	public Window Self { get; }
	///<include file='Utils/Docs/WindowDocument/WindowDocument.generated.xml' path='docs/WindowDocument/*'/>
	public Document Document { get; }
	///<include file='Utils/Docs/WindowName/WindowName.generated.xml' path='docs/WindowName/*'/>
	public string Name { get; set; }
	///<include file='Utils/Docs/WindowLocation/WindowLocation.generated.xml' path='docs/WindowLocation/*'/>
	public Location Location { get; }
	///<include file='Utils/Docs/WindowHistory/WindowHistory.generated.xml' path='docs/WindowHistory/*'/>
	public History History { get; }
	///<include file='Utils/Docs/WindowCustomElements/WindowCustomElements.generated.xml' path='docs/WindowCustomElements/*'/>
	public CustomElementRegistry CustomElements { get; }
	///<include file='Utils/Docs/WindowLocationbar/WindowLocationbar.generated.xml' path='docs/WindowLocationbar/*'/>
	public BarProp Locationbar { get; }
	///<include file='Utils/Docs/WindowMenubar/WindowMenubar.generated.xml' path='docs/WindowMenubar/*'/>
	public BarProp Menubar { get; }
	///<include file='Utils/Docs/WindowPersonalbar/WindowPersonalbar.generated.xml' path='docs/WindowPersonalbar/*'/>
	public BarProp Personalbar { get; }
	///<include file='Utils/Docs/WindowScrollbars/WindowScrollbars.generated.xml' path='docs/WindowScrollbars/*'/>
	public BarProp Scrollbars { get; }
	///<include file='Utils/Docs/WindowStatusbar/WindowStatusbar.generated.xml' path='docs/WindowStatusbar/*'/>
	public BarProp Statusbar { get; }
	///<include file='Utils/Docs/WindowToolbar/WindowToolbar.generated.xml' path='docs/WindowToolbar/*'/>
	public BarProp Toolbar { get; }
	///<include file='Utils/Docs/WindowStatus/WindowStatus.generated.xml' path='docs/WindowStatus/*'/>
	public string Status { get; set; }
	///<include file='Utils/Docs/WindowClose/WindowClose.generated.xml' path='docs/WindowClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowClosed/WindowClosed.generated.xml' path='docs/WindowClosed/*'/>
	public bool Closed { get; }
	///<include file='Utils/Docs/WindowStop/WindowStop.generated.xml' path='docs/WindowStop/*'/>
	public Undefined Stop() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowFocus/WindowFocus.generated.xml' path='docs/WindowFocus/*'/>
	public Undefined Focus() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowBlur/WindowBlur.generated.xml' path='docs/WindowBlur/*'/>
	public Undefined Blur() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowFrames/WindowFrames.generated.xml' path='docs/WindowFrames/*'/>
	public Window Frames { get; }
	///<include file='Utils/Docs/WindowLength/WindowLength.generated.xml' path='docs/WindowLength/*'/>
	public ulong Length { get; }
	///<include file='Utils/Docs/WindowTop/WindowTop.generated.xml' path='docs/WindowTop/*'/>
	public Window? Top { get; }
	///<include file='Utils/Docs/WindowOpener/WindowOpener.generated.xml' path='docs/WindowOpener/*'/>
	public dynamic Opener { get; set; }
	///<include file='Utils/Docs/WindowParent/WindowParent.generated.xml' path='docs/WindowParent/*'/>
	public Window? Parent { get; }
	///<include file='Utils/Docs/WindowFrameElement/WindowFrameElement.generated.xml' path='docs/WindowFrameElement/*'/>
	public Element? FrameElement { get; }
	///<include file='Utils/Docs/WindowOpen/WindowOpen.generated.xml' path='docs/WindowOpen/*'/>
	public Window? Open(string url, string target, string features) { throw new System.NotImplementedException(); }
	
	///<include file='Utils/Docs/WindowNavigator/WindowNavigator.generated.xml' path='docs/WindowNavigator/*'/>
	public Navigator Navigator { get; }
		public Navigator ClientInformation { get; }
		public bool OriginAgentCluster { get; }
	///<include file='Utils/Docs/WindowAlert/WindowAlert.generated.xml' path='docs/WindowAlert/*'/>
	public Undefined Alert() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowAlert/WindowAlert.generated.xml' path='docs/WindowAlert/*'/>
	public Undefined Alert(string message) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowConfirm/WindowConfirm.generated.xml' path='docs/WindowConfirm/*'/>
	public bool Confirm(string message) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowPrompt/WindowPrompt.generated.xml' path='docs/WindowPrompt/*'/>
	public string? Prompt(string message, string default_) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowPrint/WindowPrint.generated.xml' path='docs/WindowPrint/*'/>
	public Undefined Print() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowPostMessage/WindowPostMessage.generated.xml' path='docs/WindowPostMessage/*'/>
	public Undefined PostMessage(dynamic message, string targetOrigin, List<object> transfer) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowPostMessage/WindowPostMessage.generated.xml' path='docs/WindowPostMessage/*'/>
	public Undefined PostMessage(dynamic message, WindowPostMessageOptions options) { throw new System.NotImplementedException(); }
}



[To(ToAttribute.FirstCharToLowerCase)]
public partial class WindowPostMessageOptions : StructuredSerializeOptions
{
		public string TargetOrigin;
}

///<include file='Utils/Docs/BarProp/BarProp.generated.xml' path='docs/BarProp/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class BarProp
{
	///<include file='Utils/Docs/BarPropVisible/BarPropVisible.generated.xml' path='docs/BarPropVisible/*'/>
	public bool Visible { get; }
}

public enum ScrollRestoration
{
	Auto,
	Manual,
}

///<include file='Utils/Docs/History/History.generated.xml' path='docs/History/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class History
{
	///<include file='Utils/Docs/HistoryLength/HistoryLength.generated.xml' path='docs/HistoryLength/*'/>
	public ulong Length { get; }
	///<include file='Utils/Docs/HistoryScrollRestoration/HistoryScrollRestoration.generated.xml' path='docs/HistoryScrollRestoration/*'/>
	public ScrollRestoration ScrollRestoration { get; set; }
	///<include file='Utils/Docs/HistoryState/HistoryState.generated.xml' path='docs/HistoryState/*'/>
	public dynamic State { get; }
	///<include file='Utils/Docs/HistoryGo/HistoryGo.generated.xml' path='docs/HistoryGo/*'/>
	public Undefined Go(long delta) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HistoryBack/HistoryBack.generated.xml' path='docs/HistoryBack/*'/>
	public Undefined Back() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HistoryForward/HistoryForward.generated.xml' path='docs/HistoryForward/*'/>
	public Undefined Forward() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HistoryPushState/HistoryPushState.generated.xml' path='docs/HistoryPushState/*'/>
	public Undefined PushState(dynamic data, string unused, string? url) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HistoryReplaceState/HistoryReplaceState.generated.xml' path='docs/HistoryReplaceState/*'/>
	public Undefined ReplaceState(dynamic data, string unused, string? url) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Location/Location.generated.xml' path='docs/Location/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Location
{
	///<include file='Utils/Docs/LocationHref/LocationHref.generated.xml' path='docs/LocationHref/*'/>
	public string Href { get; set; }
	///<include file='Utils/Docs/LocationOrigin/LocationOrigin.generated.xml' path='docs/LocationOrigin/*'/>
	public string Origin { get; }
	///<include file='Utils/Docs/LocationProtocol/LocationProtocol.generated.xml' path='docs/LocationProtocol/*'/>
	public string Protocol { get; set; }
	///<include file='Utils/Docs/LocationHost/LocationHost.generated.xml' path='docs/LocationHost/*'/>
	public string Host { get; set; }
	///<include file='Utils/Docs/LocationHostname/LocationHostname.generated.xml' path='docs/LocationHostname/*'/>
	public string Hostname { get; set; }
	///<include file='Utils/Docs/LocationPort/LocationPort.generated.xml' path='docs/LocationPort/*'/>
	public string Port { get; set; }
	///<include file='Utils/Docs/LocationPathname/LocationPathname.generated.xml' path='docs/LocationPathname/*'/>
	public string Pathname { get; set; }
	///<include file='Utils/Docs/LocationSearch/LocationSearch.generated.xml' path='docs/LocationSearch/*'/>
	public string Search { get; set; }
	///<include file='Utils/Docs/LocationHash/LocationHash.generated.xml' path='docs/LocationHash/*'/>
	public string Hash { get; set; }
	///<include file='Utils/Docs/LocationAssign/LocationAssign.generated.xml' path='docs/LocationAssign/*'/>
	public Undefined Assign(string url) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/LocationReplace/LocationReplace.generated.xml' path='docs/LocationReplace/*'/>
	public Undefined Replace(string url) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/LocationReload/LocationReload.generated.xml' path='docs/LocationReload/*'/>
	public Undefined Reload() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/LocationAncestorOrigins/LocationAncestorOrigins.generated.xml' path='docs/LocationAncestorOrigins/*'/>
	public string AncestorOrigins { get; }
}

///<include file='Utils/Docs/PopStateEvent/PopStateEvent.generated.xml' path='docs/PopStateEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PopStateEvent : Event
{
	///<include file='Utils/Docs/PopStateEventPopStateEvent/PopStateEventPopStateEvent.generated.xml' path='docs/PopStateEventPopStateEvent/*'/>
	public PopStateEvent(string type, PopStateEventInit eventInitDict) { }
	///<include file='Utils/Docs/PopStateEventState/PopStateEventState.generated.xml' path='docs/PopStateEventState/*'/>
	public dynamic State { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PopStateEventInit : EventInit
{
		public dynamic State;
}

///<include file='Utils/Docs/HashChangeEvent/HashChangeEvent.generated.xml' path='docs/HashChangeEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class HashChangeEvent : Event
{
	///<include file='Utils/Docs/HashChangeEventHashChangeEvent/HashChangeEventHashChangeEvent.generated.xml' path='docs/HashChangeEventHashChangeEvent/*'/>
	public HashChangeEvent(string type, HashChangeEventInit eventInitDict) { }
	///<include file='Utils/Docs/HashChangeEventOldURL/HashChangeEventOldURL.generated.xml' path='docs/HashChangeEventOldURL/*'/>
	public string OldURL { get; }
	///<include file='Utils/Docs/HashChangeEventNewURL/HashChangeEventNewURL.generated.xml' path='docs/HashChangeEventNewURL/*'/>
	public string NewURL { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class HashChangeEventInit : EventInit
{
		public string OldURL;
		public string NewURL;
}

///<include file='Utils/Docs/PageTransitionEvent/PageTransitionEvent.generated.xml' path='docs/PageTransitionEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PageTransitionEvent : Event
{
	///<include file='Utils/Docs/PageTransitionEventPageTransitionEvent/PageTransitionEventPageTransitionEvent.generated.xml' path='docs/PageTransitionEventPageTransitionEvent/*'/>
	public PageTransitionEvent(string type, PageTransitionEventInit eventInitDict) { }
	///<include file='Utils/Docs/PageTransitionEventPersisted/PageTransitionEventPersisted.generated.xml' path='docs/PageTransitionEventPersisted/*'/>
	public bool Persisted { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PageTransitionEventInit : EventInit
{
		public bool Persisted;
}

///<include file='Utils/Docs/BeforeUnloadEvent/BeforeUnloadEvent.generated.xml' path='docs/BeforeUnloadEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class BeforeUnloadEvent : Event
{
		public string ReturnValue { get; set; }
}

///<include file='Utils/Docs/ErrorEvent/ErrorEvent.generated.xml' path='docs/ErrorEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ErrorEvent : Event
{
		public ErrorEvent(string type, ErrorEventInit eventInitDict) { }
		public string Message { get; }
		public string Filename { get; }
		public ulong Lineno { get; }
		public ulong Colno { get; }
		public dynamic Error { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ErrorEventInit : EventInit
{
		public string Message;
		public string Filename;
		public ulong Lineno;
		public ulong Colno;
		public dynamic Error;
}

///<include file='Utils/Docs/PromiseRejectionEvent/PromiseRejectionEvent.generated.xml' path='docs/PromiseRejectionEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PromiseRejectionEvent : Event
{
	///<include file='Utils/Docs/PromiseRejectionEventPromiseRejectionEvent/PromiseRejectionEventPromiseRejectionEvent.generated.xml' path='docs/PromiseRejectionEventPromiseRejectionEvent/*'/>
	public PromiseRejectionEvent(string type, PromiseRejectionEventInit eventInitDict) { }
	///<include file='Utils/Docs/PromiseRejectionEventPromise/PromiseRejectionEventPromise.generated.xml' path='docs/PromiseRejectionEventPromise/*'/>
	public Task<dynamic> Promise { get; }
	///<include file='Utils/Docs/PromiseRejectionEventReason/PromiseRejectionEventReason.generated.xml' path='docs/PromiseRejectionEventReason/*'/>
	public dynamic Reason { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class PromiseRejectionEventInit : EventInit
{
		public required Task<dynamic> Promise;
		public dynamic Reason;
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
public partial interface GlobalEventHandlers
{
		public EventHandler Onabort { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onauxclick { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onbeforeinput { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onbeforematch { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onblur { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oncancel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oncanplay { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oncanplaythrough { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onclick { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onclose { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oncontextlost { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oncontextmenu { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oncontextrestored { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oncuechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ondblclick { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ondrag { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ondragend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ondragenter { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ondragleave { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ondragover { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ondragstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ondrop { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ondurationchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onemptied { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onended { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public OnErrorEventHandler Onerror { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onfocus { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onformdata { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oninput { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oninvalid { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onkeydown { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onkeypress { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onkeyup { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onload { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onloadeddata { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onloadedmetadata { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onloadstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmousedown { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmouseenter { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmouseleave { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmousemove { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmouseout { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmouseover { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmouseup { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpause { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onplay { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onplaying { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onprogress { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onratechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onreset { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onresize { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onscroll { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onsecuritypolicyviolation { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onseeked { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onseeking { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onselect { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onslotchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onstalled { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onsubmit { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onsuspend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ontimeupdate { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ontoggle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onvolumechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onwaiting { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onwebkitanimationend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onwebkitanimationiteration { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onwebkitanimationstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onwebkittransitionend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onwheel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface WindowEventHandlers
{
		public EventHandler Onafterprint { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onbeforeprint { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public OnBeforeUnloadEventHandler Onbeforeunload { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onhashchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onlanguagechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmessage { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onmessageerror { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onoffline { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Ononline { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpagehide { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpageshow { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpopstate { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onrejectionhandled { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onstorage { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onunhandledrejection { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onunload { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface DocumentAndElementEventHandlers
{
		public EventHandler Oncopy { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Oncut { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
		public EventHandler Onpaste { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}


public partial interface WindowOrWorkerGlobalScope
{
		public string Origin { get { throw new System.NotImplementedException(); } }
		public bool IsSecureContext { get { throw new System.NotImplementedException(); } }
		public bool CrossOriginIsolated { get { throw new System.NotImplementedException(); } }
		public Undefined ReportError(dynamic e) { throw new System.NotImplementedException(); }
		public string Btoa(string data) { throw new System.NotImplementedException(); }
		public string Atob(string data) { throw new System.NotImplementedException(); }
		public long SetTimeout(TimerHandler handler, long timeout, params dynamic[] arguments) { throw new System.NotImplementedException(); }
		public Undefined ClearTimeout(long id) { throw new System.NotImplementedException(); }
		public long SetInterval(TimerHandler handler, long timeout, params dynamic[] arguments) { throw new System.NotImplementedException(); }
		public Undefined ClearInterval(long id) { throw new System.NotImplementedException(); }
		public Undefined QueueMicrotask(VoidFunction callback) { throw new System.NotImplementedException(); }
		public Task<ImageBitmap> CreateImageBitmap(ImageBitmapSource image, ImageBitmapOptions options) { throw new System.NotImplementedException(); }
		public Task<ImageBitmap> CreateImageBitmap(ImageBitmapSource image, long sx, long sy, long sw, long sh, ImageBitmapOptions options) { throw new System.NotImplementedException(); }
		public dynamic StructuredClone(dynamic value, StructuredSerializeOptions options) { throw new System.NotImplementedException(); }
}



///<include file='Utils/Docs/DOMParser/DOMParser.generated.xml' path='docs/DOMParser/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMParser
{
	///<include file='Utils/Docs/DOMParserDOMParser/DOMParserDOMParser.generated.xml' path='docs/DOMParserDOMParser/*'/>
	public DOMParser() { }
	///<include file='Utils/Docs/DOMParserParseFromString/DOMParserParseFromString.generated.xml' path='docs/DOMParserParseFromString/*'/>
	public Document ParseFromString(string string_, DOMParserSupportedType type) { throw new System.NotImplementedException(); }
}

public enum DOMParserSupportedType
{
	TextHtml,
	TextXml,
	ApplicationXml,
	ApplicationXhtmlXml,
	ImageSvgXml,
}

///<include file='Utils/Docs/Navigator/Navigator.generated.xml' path='docs/Navigator/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Navigator
{
}








[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorID
{
		public string AppCodeName { get { throw new System.NotImplementedException(); } }
		public string AppName { get { throw new System.NotImplementedException(); } }
		public string AppVersion { get { throw new System.NotImplementedException(); } }
		public string Platform { get { throw new System.NotImplementedException(); } }
		public string Product { get { throw new System.NotImplementedException(); } }
		public string ProductSub { get { throw new System.NotImplementedException(); } }
		public string UserAgent { get { throw new System.NotImplementedException(); } }
		public string Vendor { get { throw new System.NotImplementedException(); } }
		public string VendorSub { get { throw new System.NotImplementedException(); } }
}

public partial interface NavigatorID
{
		public bool TaintEnabled() { throw new System.NotImplementedException(); }
		public string Oscpu { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NavigatorLanguage/NavigatorLanguage.generated.xml' path='docs/NavigatorLanguage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorLanguage
{
		public string Language { get { throw new System.NotImplementedException(); } }
		public string[] Languages { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NavigatorOnLine/NavigatorOnLine.generated.xml' path='docs/NavigatorOnLine/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorOnLine
{
		public bool OnLine { get { throw new System.NotImplementedException(); } }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorContentUtils
{
		public Undefined RegisterProtocolHandler(string scheme, string url) { throw new System.NotImplementedException(); }
		public Undefined UnregisterProtocolHandler(string scheme, string url) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorCookies
{
		public bool CookieEnabled { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NavigatorPlugins/NavigatorPlugins.generated.xml' path='docs/NavigatorPlugins/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorPlugins
{
		public PluginArray Plugins { get { throw new System.NotImplementedException(); } }
		public MimeTypeArray MimeTypes { get { throw new System.NotImplementedException(); } }
		public bool JavaEnabled() { throw new System.NotImplementedException(); }
		public bool PdfViewerEnabled { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/PluginArray/PluginArray.generated.xml' path='docs/PluginArray/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PluginArray
{
		public Undefined Refresh() { throw new System.NotImplementedException(); }
		public ulong Length { get; }
	
	
}

///<include file='Utils/Docs/MimeTypeArray/MimeTypeArray.generated.xml' path='docs/MimeTypeArray/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MimeTypeArray
{
		public ulong Length { get; }
	
	
}

///<include file='Utils/Docs/Plugin/Plugin.generated.xml' path='docs/Plugin/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Plugin
{
		public string Name { get; }
		public string Description { get; }
		public string Filename { get; }
		public ulong Length { get; }
	
	
}

///<include file='Utils/Docs/MimeType/MimeType.generated.xml' path='docs/MimeType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MimeType
{
		public string Type { get; }
		public string Description { get; }
		public string Suffixes { get; }
		public Plugin EnabledPlugin { get; }
}

///<include file='Utils/Docs/ImageBitmap/ImageBitmap.generated.xml' path='docs/ImageBitmap/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageBitmap
{
	///<include file='Utils/Docs/ImageBitmapWidth/ImageBitmapWidth.generated.xml' path='docs/ImageBitmapWidth/*'/>
	public ulong Width { get; }
	///<include file='Utils/Docs/ImageBitmapHeight/ImageBitmapHeight.generated.xml' path='docs/ImageBitmapHeight/*'/>
	public ulong Height { get; }
	///<include file='Utils/Docs/ImageBitmapClose/ImageBitmapClose.generated.xml' path='docs/ImageBitmapClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
}


public enum ImageOrientation
{
	None,
	FlipY,
}

public enum PremultiplyAlpha
{
	None,
	Premultiply,
	Default,
}

public enum ColorSpaceConversion
{
	None,
	Default,
}

public enum ResizeQuality
{
	Pixelated,
	Low,
	Medium,
	High,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageBitmapOptions
{
		public ImageOrientation ImageOrientation;
		public PremultiplyAlpha PremultiplyAlpha;
		public ColorSpaceConversion ColorSpaceConversion;
		public ulong ResizeWidth;
		public ulong ResizeHeight;
		public ResizeQuality ResizeQuality;
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct FrameRequestCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface AnimationFrameProvider
{
		public ulong RequestAnimationFrame(FrameRequestCallback callback) { throw new System.NotImplementedException(); }
		public Undefined CancelAnimationFrame(ulong handle) { throw new System.NotImplementedException(); }
}



///<include file='Utils/Docs/MessageEvent/MessageEvent.generated.xml' path='docs/MessageEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MessageEvent : Event
{
	///<include file='Utils/Docs/MessageEventMessageEvent/MessageEventMessageEvent.generated.xml' path='docs/MessageEventMessageEvent/*'/>
	public MessageEvent(string type, MessageEventInit eventInitDict) { }
	///<include file='Utils/Docs/MessageEventData/MessageEventData.generated.xml' path='docs/MessageEventData/*'/>
	public dynamic Data { get; }
	///<include file='Utils/Docs/MessageEventOrigin/MessageEventOrigin.generated.xml' path='docs/MessageEventOrigin/*'/>
	public string Origin { get; }
	///<include file='Utils/Docs/MessageEventLastEventId/MessageEventLastEventId.generated.xml' path='docs/MessageEventLastEventId/*'/>
	public string LastEventId { get; }
	///<include file='Utils/Docs/MessageEventSource/MessageEventSource.generated.xml' path='docs/MessageEventSource/*'/>
	public MessageEventSource? Source { get; }
	///<include file='Utils/Docs/MessageEventPorts/MessageEventPorts.generated.xml' path='docs/MessageEventPorts/*'/>
	public MessagePort[] Ports { get; }
		public Undefined InitMessageEvent(string type, bool bubbles, bool cancelable, dynamic data, string origin, string lastEventId, MessageEventSource? source, List<MessagePort> ports) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class MessageEventInit : EventInit
{
		public dynamic Data;
		public string Origin;
		public string LastEventId;
		public MessageEventSource? Source;
		public List<MessagePort> Ports;
}


///<include file='Utils/Docs/EventSource/EventSource.generated.xml' path='docs/EventSource/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class EventSource : EventTarget
{
	///<include file='Utils/Docs/EventSourceEventSource/EventSourceEventSource.generated.xml' path='docs/EventSourceEventSource/*'/>
	public EventSource(string url, EventSourceInit eventSourceInitDict) { }
	///<include file='Utils/Docs/EventSourceUrl/EventSourceUrl.generated.xml' path='docs/EventSourceUrl/*'/>
	public string Url { get; }
	///<include file='Utils/Docs/EventSourceWithCredentials/EventSourceWithCredentials.generated.xml' path='docs/EventSourceWithCredentials/*'/>
	public bool WithCredentials { get; }
		public const ushort CONNECTING = 0;
		public const ushort OPEN = 1;
		public const ushort CLOSED = 2;
	///<include file='Utils/Docs/EventSourceReadyState/EventSourceReadyState.generated.xml' path='docs/EventSourceReadyState/*'/>
	public ushort ReadyState { get; }
		public EventHandler Onopen { get; set; }
		public EventHandler Onmessage { get; set; }
		public EventHandler Onerror { get; set; }
	///<include file='Utils/Docs/EventSourceClose/EventSourceClose.generated.xml' path='docs/EventSourceClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class EventSourceInit
{
		public bool WithCredentials;
}

///<include file='Utils/Docs/MessageChannel/MessageChannel.generated.xml' path='docs/MessageChannel/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MessageChannel
{
	///<include file='Utils/Docs/MessageChannelMessageChannel/MessageChannelMessageChannel.generated.xml' path='docs/MessageChannelMessageChannel/*'/>
	public MessageChannel() { }
	///<include file='Utils/Docs/MessageChannelPort1/MessageChannelPort1.generated.xml' path='docs/MessageChannelPort1/*'/>
	public MessagePort Port1 { get; }
	///<include file='Utils/Docs/MessageChannelPort2/MessageChannelPort2.generated.xml' path='docs/MessageChannelPort2/*'/>
	public MessagePort Port2 { get; }
}

///<include file='Utils/Docs/MessagePort/MessagePort.generated.xml' path='docs/MessagePort/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MessagePort : EventTarget
{
	///<include file='Utils/Docs/MessagePortPostMessage/MessagePortPostMessage.generated.xml' path='docs/MessagePortPostMessage/*'/>
	public Undefined PostMessage(dynamic message, List<object> transfer) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MessagePortPostMessage/MessagePortPostMessage.generated.xml' path='docs/MessagePortPostMessage/*'/>
	public Undefined PostMessage(dynamic message, StructuredSerializeOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MessagePortStart/MessagePortStart.generated.xml' path='docs/MessagePortStart/*'/>
	public Undefined Start() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/MessagePortClose/MessagePortClose.generated.xml' path='docs/MessagePortClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
		public EventHandler Onmessage { get; set; }
		public EventHandler Onmessageerror { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class StructuredSerializeOptions
{
		public List<object> Transfer;
}

///<include file='Utils/Docs/BroadcastChannel/BroadcastChannel.generated.xml' path='docs/BroadcastChannel/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class BroadcastChannel : EventTarget
{
	///<include file='Utils/Docs/BroadcastChannelBroadcastChannel/BroadcastChannelBroadcastChannel.generated.xml' path='docs/BroadcastChannelBroadcastChannel/*'/>
	public BroadcastChannel(string name) { }
	///<include file='Utils/Docs/BroadcastChannelName/BroadcastChannelName.generated.xml' path='docs/BroadcastChannelName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs/BroadcastChannelPostMessage/BroadcastChannelPostMessage.generated.xml' path='docs/BroadcastChannelPostMessage/*'/>
	public Undefined PostMessage(dynamic message) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BroadcastChannelClose/BroadcastChannelClose.generated.xml' path='docs/BroadcastChannelClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
		public EventHandler Onmessage { get; set; }
		public EventHandler Onmessageerror { get; set; }
}

///<include file='Utils/Docs/WorkerGlobalScope/WorkerGlobalScope.generated.xml' path='docs/WorkerGlobalScope/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WorkerGlobalScope : EventTarget, WindowOrWorkerGlobalScope
{
	///<include file='Utils/Docs/WorkerGlobalScopeSelf/WorkerGlobalScopeSelf.generated.xml' path='docs/WorkerGlobalScopeSelf/*'/>
	public WorkerGlobalScope Self { get; }
	///<include file='Utils/Docs/WorkerGlobalScopeLocation/WorkerGlobalScopeLocation.generated.xml' path='docs/WorkerGlobalScopeLocation/*'/>
	public WorkerLocation Location { get; }
	///<include file='Utils/Docs/WorkerGlobalScopeNavigator/WorkerGlobalScopeNavigator.generated.xml' path='docs/WorkerGlobalScopeNavigator/*'/>
	public WorkerNavigator Navigator { get; }
	///<include file='Utils/Docs/WorkerGlobalScopeImportScripts/WorkerGlobalScopeImportScripts.generated.xml' path='docs/WorkerGlobalScopeImportScripts/*'/>
	public Undefined ImportScripts(params string[] urls) { throw new System.NotImplementedException(); }
		public OnErrorEventHandler Onerror { get; set; }
		public EventHandler Onlanguagechange { get; set; }
		public EventHandler Onoffline { get; set; }
		public EventHandler Ononline { get; set; }
		public EventHandler Onrejectionhandled { get; set; }
		public EventHandler Onunhandledrejection { get; set; }
}

///<include file='Utils/Docs/DedicatedWorkerGlobalScope/DedicatedWorkerGlobalScope.generated.xml' path='docs/DedicatedWorkerGlobalScope/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DedicatedWorkerGlobalScope : WorkerGlobalScope, AnimationFrameProvider
{
	///<include file='Utils/Docs/DedicatedWorkerGlobalScopeName/DedicatedWorkerGlobalScopeName.generated.xml' path='docs/DedicatedWorkerGlobalScopeName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs/DedicatedWorkerGlobalScopePostMessage/DedicatedWorkerGlobalScopePostMessage.generated.xml' path='docs/DedicatedWorkerGlobalScopePostMessage/*'/>
	public Undefined PostMessage(dynamic message, List<object> transfer) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DedicatedWorkerGlobalScopePostMessage/DedicatedWorkerGlobalScopePostMessage.generated.xml' path='docs/DedicatedWorkerGlobalScopePostMessage/*'/>
	public Undefined PostMessage(dynamic message, StructuredSerializeOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DedicatedWorkerGlobalScopeClose/DedicatedWorkerGlobalScopeClose.generated.xml' path='docs/DedicatedWorkerGlobalScopeClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
		public EventHandler Onmessage { get; set; }
		public EventHandler Onmessageerror { get; set; }
}

///<include file='Utils/Docs/SharedWorkerGlobalScope/SharedWorkerGlobalScope.generated.xml' path='docs/SharedWorkerGlobalScope/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SharedWorkerGlobalScope : WorkerGlobalScope
{
	///<include file='Utils/Docs/SharedWorkerGlobalScopeName/SharedWorkerGlobalScopeName.generated.xml' path='docs/SharedWorkerGlobalScopeName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs/SharedWorkerGlobalScopeClose/SharedWorkerGlobalScopeClose.generated.xml' path='docs/SharedWorkerGlobalScopeClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
		public EventHandler Onconnect { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial interface AbstractWorker
{
		public EventHandler Onerror { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/Worker/Worker.generated.xml' path='docs/Worker/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Worker : EventTarget, AbstractWorker
{
	///<include file='Utils/Docs/WorkerWorker/WorkerWorker.generated.xml' path='docs/WorkerWorker/*'/>
	public Worker(string scriptURL, WorkerOptions options) { }
	///<include file='Utils/Docs/WorkerTerminate/WorkerTerminate.generated.xml' path='docs/WorkerTerminate/*'/>
	public Undefined Terminate() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WorkerPostMessage/WorkerPostMessage.generated.xml' path='docs/WorkerPostMessage/*'/>
	public Undefined PostMessage(dynamic message, List<object> transfer) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WorkerPostMessage/WorkerPostMessage.generated.xml' path='docs/WorkerPostMessage/*'/>
	public Undefined PostMessage(dynamic message, StructuredSerializeOptions options) { throw new System.NotImplementedException(); }
		public EventHandler Onmessage { get; set; }
		public EventHandler Onmessageerror { get; set; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WorkerOptions
{
		public WorkerType Type;
		public RequestCredentials Credentials;
		public string Name;
}

public enum WorkerType
{
	Classic,
	Module,
}


///<include file='Utils/Docs/SharedWorker/SharedWorker.generated.xml' path='docs/SharedWorker/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SharedWorker : EventTarget, AbstractWorker
{
	///<include file='Utils/Docs/SharedWorkerSharedWorker/SharedWorkerSharedWorker.generated.xml' path='docs/SharedWorkerSharedWorker/*'/>
	public SharedWorker(string scriptURL, Union46 options) { }
	///<include file='Utils/Docs/SharedWorkerPort/SharedWorkerPort.generated.xml' path='docs/SharedWorkerPort/*'/>
	public MessagePort Port { get; }
}


[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorConcurrentHardware
{
		public ulong HardwareConcurrency { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/WorkerNavigator/WorkerNavigator.generated.xml' path='docs/WorkerNavigator/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WorkerNavigator
{
}





///<include file='Utils/Docs/WorkerLocation/WorkerLocation.generated.xml' path='docs/WorkerLocation/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WorkerLocation
{
	///<include file='Utils/Docs/WorkerLocationHref/WorkerLocationHref.generated.xml' path='docs/WorkerLocationHref/*'/>
	public string Href { get; }
	///<include file='Utils/Docs/WorkerLocationOrigin/WorkerLocationOrigin.generated.xml' path='docs/WorkerLocationOrigin/*'/>
	public string Origin { get; }
	///<include file='Utils/Docs/WorkerLocationProtocol/WorkerLocationProtocol.generated.xml' path='docs/WorkerLocationProtocol/*'/>
	public string Protocol { get; }
	///<include file='Utils/Docs/WorkerLocationHost/WorkerLocationHost.generated.xml' path='docs/WorkerLocationHost/*'/>
	public string Host { get; }
	///<include file='Utils/Docs/WorkerLocationHostname/WorkerLocationHostname.generated.xml' path='docs/WorkerLocationHostname/*'/>
	public string Hostname { get; }
	///<include file='Utils/Docs/WorkerLocationPort/WorkerLocationPort.generated.xml' path='docs/WorkerLocationPort/*'/>
	public string Port { get; }
	///<include file='Utils/Docs/WorkerLocationPathname/WorkerLocationPathname.generated.xml' path='docs/WorkerLocationPathname/*'/>
	public string Pathname { get; }
	///<include file='Utils/Docs/WorkerLocationSearch/WorkerLocationSearch.generated.xml' path='docs/WorkerLocationSearch/*'/>
	public string Search { get; }
	///<include file='Utils/Docs/WorkerLocationHash/WorkerLocationHash.generated.xml' path='docs/WorkerLocationHash/*'/>
	public string Hash { get; }
}

///<include file='Utils/Docs/WorkletGlobalScope/WorkletGlobalScope.generated.xml' path='docs/WorkletGlobalScope/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WorkletGlobalScope
{
}

///<include file='Utils/Docs/Worklet/Worklet.generated.xml' path='docs/Worklet/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Worklet
{
	///<include file='Utils/Docs/WorkletAddModule/WorkletAddModule.generated.xml' path='docs/WorkletAddModule/*'/>
	public Task<Undefined> AddModule(string moduleURL, WorkletOptions options) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class WorkletOptions
{
		public RequestCredentials Credentials;
}

///<include file='Utils/Docs/Storage/Storage.generated.xml' path='docs/Storage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Storage
{
	///<include file='Utils/Docs/StorageLength/StorageLength.generated.xml' path='docs/StorageLength/*'/>
	public ulong Length { get; }
	///<include file='Utils/Docs/StorageKey/StorageKey.generated.xml' path='docs/StorageKey/*'/>
	public string? Key(ulong index) { throw new System.NotImplementedException(); }
	
	
	
	///<include file='Utils/Docs/StorageClear/StorageClear.generated.xml' path='docs/StorageClear/*'/>
	public Undefined Clear() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/WindowSessionStorage/WindowSessionStorage.generated.xml' path='docs/WindowSessionStorage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface WindowSessionStorage
{
		public Storage SessionStorage { get { throw new System.NotImplementedException(); } }
}


///<include file='Utils/Docs/WindowLocalStorage/WindowLocalStorage.generated.xml' path='docs/WindowLocalStorage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface WindowLocalStorage
{
		public Storage LocalStorage { get { throw new System.NotImplementedException(); } }
}


///<include file='Utils/Docs/StorageEvent/StorageEvent.generated.xml' path='docs/StorageEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class StorageEvent : Event
{
		public StorageEvent(string type, StorageEventInit eventInitDict) { }
		public string? Key { get; }
		public string? OldValue { get; }
		public string? NewValue { get; }
		public string Url { get; }
		public Storage? StorageArea { get; }
	///<include file='Utils/Docs/StorageEventInitStorageEvent/StorageEventInitStorageEvent.generated.xml' path='docs/StorageEventInitStorageEvent/*'/>
	public Undefined InitStorageEvent(string type, bool bubbles, bool cancelable, string? key, string? oldValue, string? newValue, string url, Storage? storageArea) { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class StorageEventInit : EventInit
{
		public string? Key;
		public string? OldValue;
		public string? NewValue;
		public string Url;
		public Storage? StorageArea;
}

///<include file='Utils/Docs/HTMLMarqueeElement/HTMLMarqueeElement.generated.xml' path='docs/HTMLMarqueeElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLMarqueeElement : HTMLElement
{
		public HTMLMarqueeElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Behavior { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string BgColor { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Direction { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Height { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Hspace { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public long Loop { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong ScrollAmount { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong ScrollDelay { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool TrueSpeed { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Vspace { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Width { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Start() { throw new System.NotImplementedException(); }
	[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Stop() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLFrameSetElement/HTMLFrameSetElement.generated.xml' path='docs/HTMLFrameSetElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLFrameSetElement : HTMLElement, WindowEventHandlers
{
		public HTMLFrameSetElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Cols { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Rows { get; set; }
}


[To(ToAttribute.Default)]
public partial class HTMLFrameElement : HTMLElement
{
		public HTMLFrameElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Scrolling { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string FrameBorder { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string LongDesc { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool NoResize { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public Document? ContentDocument { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public Window? ContentWindow { get; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string MarginHeight { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string MarginWidth { get; set; }
}

///<include file='Utils/Docs/HTMLAnchorElement/HTMLAnchorElement.generated.xml' path='docs/HTMLAnchorElement/*'/>
public partial class HTMLAnchorElement
{
		public string Coords { get; set; }
		public string Charset { get; set; }
		public string Name { get; set; }
		public string Rev { get; set; }
		public string Shape { get; set; }
}

///<include file='Utils/Docs/HTMLAreaElement/HTMLAreaElement.generated.xml' path='docs/HTMLAreaElement/*'/>
public partial class HTMLAreaElement
{
		public bool NoHref { get; set; }
}

///<include file='Utils/Docs/HTMLBodyElement/HTMLBodyElement.generated.xml' path='docs/HTMLBodyElement/*'/>
public partial class HTMLBodyElement
{
		public string Text { get; set; }
		public string Link { get; set; }
		public string VLink { get; set; }
		public string ALink { get; set; }
		public string BgColor { get; set; }
		public string Background { get; set; }
}

///<include file='Utils/Docs/HTMLBRElement/HTMLBRElement.generated.xml' path='docs/HTMLBRElement/*'/>
public partial class HTMLBRElement
{
		public string Clear { get; set; }
}

///<include file='Utils/Docs/HTMLTableCaptionElement/HTMLTableCaptionElement.generated.xml' path='docs/HTMLTableCaptionElement/*'/>
public partial class HTMLTableCaptionElement
{
		public string Align { get; set; }
}

///<include file='Utils/Docs/HTMLTableColElement/HTMLTableColElement.generated.xml' path='docs/HTMLTableColElement/*'/>
public partial class HTMLTableColElement
{
		public string Align { get; set; }
		public string Ch { get; set; }
		public string ChOff { get; set; }
		public string VAlign { get; set; }
		public string Width { get; set; }
}

[To(ToAttribute.Default)]
public partial class HTMLDirectoryElement : HTMLElement
{
		public HTMLDirectoryElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public bool Compact { get; set; }
}

///<include file='Utils/Docs/HTMLDivElement/HTMLDivElement.generated.xml' path='docs/HTMLDivElement/*'/>
public partial class HTMLDivElement
{
		public string Align { get; set; }
}

///<include file='Utils/Docs/HTMLDListElement/HTMLDListElement.generated.xml' path='docs/HTMLDListElement/*'/>
public partial class HTMLDListElement
{
		public bool Compact { get; set; }
}

///<include file='Utils/Docs/HTMLEmbedElement/HTMLEmbedElement.generated.xml' path='docs/HTMLEmbedElement/*'/>
public partial class HTMLEmbedElement
{
		public string Align { get; set; }
		public string Name { get; set; }
}

///<include file='Utils/Docs/HTMLFontElement/HTMLFontElement.generated.xml' path='docs/HTMLFontElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLFontElement : HTMLElement
{
		public HTMLFontElement() { }
	///<include file='Utils/Docs/HTMLFontElementColor/HTMLFontElementColor.generated.xml' path='docs/HTMLFontElementColor/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Color { get; set; }
	///<include file='Utils/Docs/HTMLFontElementFace/HTMLFontElementFace.generated.xml' path='docs/HTMLFontElementFace/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Face { get; set; }
	///<include file='Utils/Docs/HTMLFontElementSize/HTMLFontElementSize.generated.xml' path='docs/HTMLFontElementSize/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Size { get; set; }
}

///<include file='Utils/Docs/HTMLHeadingElement/HTMLHeadingElement.generated.xml' path='docs/HTMLHeadingElement/*'/>
public partial class HTMLHeadingElement
{
		public string Align { get; set; }
}

///<include file='Utils/Docs/HTMLHRElement/HTMLHRElement.generated.xml' path='docs/HTMLHRElement/*'/>
public partial class HTMLHRElement
{
		public string Align { get; set; }
		public string Color { get; set; }
		public bool NoShade { get; set; }
		public string Size { get; set; }
		public string Width { get; set; }
}

///<include file='Utils/Docs/HTMLHtmlElement/HTMLHtmlElement.generated.xml' path='docs/HTMLHtmlElement/*'/>
public partial class HTMLHtmlElement
{
	///<include file='Utils/Docs/HTMLHtmlElementVersion/HTMLHtmlElementVersion.generated.xml' path='docs/HTMLHtmlElementVersion/*'/>
	public string Version { get; set; }
}

///<include file='Utils/Docs/HTMLIFrameElement/HTMLIFrameElement.generated.xml' path='docs/HTMLIFrameElement/*'/>
public partial class HTMLIFrameElement
{
		public string Align { get; set; }
		public string Scrolling { get; set; }
		public string FrameBorder { get; set; }
		public string LongDesc { get; set; }
		public string MarginHeight { get; set; }
		public string MarginWidth { get; set; }
}

///<include file='Utils/Docs/HTMLImageElement/HTMLImageElement.generated.xml' path='docs/HTMLImageElement/*'/>
public partial class HTMLImageElement
{
	///<include file='Utils/Docs/HTMLImageElementName/HTMLImageElementName.generated.xml' path='docs/HTMLImageElementName/*'/>
	public string Name { get; set; }
		public string Lowsrc { get; set; }
	///<include file='Utils/Docs/HTMLImageElementAlign/HTMLImageElementAlign.generated.xml' path='docs/HTMLImageElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs/HTMLImageElementHspace/HTMLImageElementHspace.generated.xml' path='docs/HTMLImageElementHspace/*'/>
	public ulong Hspace { get; set; }
	///<include file='Utils/Docs/HTMLImageElementVspace/HTMLImageElementVspace.generated.xml' path='docs/HTMLImageElementVspace/*'/>
	public ulong Vspace { get; set; }
	///<include file='Utils/Docs/HTMLImageElementLongDesc/HTMLImageElementLongDesc.generated.xml' path='docs/HTMLImageElementLongDesc/*'/>
	public string LongDesc { get; set; }
	///<include file='Utils/Docs/HTMLImageElementBorder/HTMLImageElementBorder.generated.xml' path='docs/HTMLImageElementBorder/*'/>
	public string Border { get; set; }
}

///<include file='Utils/Docs/HTMLInputElement/HTMLInputElement.generated.xml' path='docs/HTMLInputElement/*'/>
public partial class HTMLInputElement
{
		public string Align { get; set; }
		public string UseMap { get; set; }
}

///<include file='Utils/Docs/HTMLLegendElement/HTMLLegendElement.generated.xml' path='docs/HTMLLegendElement/*'/>
public partial class HTMLLegendElement
{
		public string Align { get; set; }
}

///<include file='Utils/Docs/HTMLLIElement/HTMLLIElement.generated.xml' path='docs/HTMLLIElement/*'/>
public partial class HTMLLIElement
{
		public string Type { get; set; }
}

///<include file='Utils/Docs/HTMLLinkElement/HTMLLinkElement.generated.xml' path='docs/HTMLLinkElement/*'/>
public partial class HTMLLinkElement
{
		public string Charset { get; set; }
		public string Rev { get; set; }
		public string Target { get; set; }
}

///<include file='Utils/Docs/HTMLMenuElement/HTMLMenuElement.generated.xml' path='docs/HTMLMenuElement/*'/>
public partial class HTMLMenuElement
{
		public bool Compact { get; set; }
}

///<include file='Utils/Docs/HTMLMetaElement/HTMLMetaElement.generated.xml' path='docs/HTMLMetaElement/*'/>
public partial class HTMLMetaElement
{
	///<include file='Utils/Docs/HTMLMetaElementScheme/HTMLMetaElementScheme.generated.xml' path='docs/HTMLMetaElementScheme/*'/>
	public string Scheme { get; set; }
}

///<include file='Utils/Docs/HTMLObjectElement/HTMLObjectElement.generated.xml' path='docs/HTMLObjectElement/*'/>
public partial class HTMLObjectElement
{
		public string Align { get; set; }
		public string Archive { get; set; }
		public string Code { get; set; }
		public bool Declare { get; set; }
		public ulong Hspace { get; set; }
		public string Standby { get; set; }
		public ulong Vspace { get; set; }
		public string CodeBase { get; set; }
		public string CodeType { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementUseMap/HTMLObjectElementUseMap.generated.xml' path='docs/HTMLObjectElementUseMap/*'/>
	public string UseMap { get; set; }
		public string Border { get; set; }
}

///<include file='Utils/Docs/HTMLOListElement/HTMLOListElement.generated.xml' path='docs/HTMLOListElement/*'/>
public partial class HTMLOListElement
{
		public bool Compact { get; set; }
}

///<include file='Utils/Docs/HTMLParagraphElement/HTMLParagraphElement.generated.xml' path='docs/HTMLParagraphElement/*'/>
public partial class HTMLParagraphElement
{
		public string Align { get; set; }
}

///<include file='Utils/Docs/HTMLParamElement/HTMLParamElement.generated.xml' path='docs/HTMLParamElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLParamElement : HTMLElement
{
		public HTMLParamElement() { }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
	[To(ToAttribute.FirstCharToLowerCase)]
	public string ValueType { get; set; }
}

///<include file='Utils/Docs/HTMLPreElement/HTMLPreElement.generated.xml' path='docs/HTMLPreElement/*'/>
public partial class HTMLPreElement
{
		public long Width { get; set; }
}

///<include file='Utils/Docs/HTMLStyleElement/HTMLStyleElement.generated.xml' path='docs/HTMLStyleElement/*'/>
public partial class HTMLStyleElement
{
	///<include file='Utils/Docs/HTMLStyleElementType/HTMLStyleElementType.generated.xml' path='docs/HTMLStyleElementType/*'/>
	public string Type { get; set; }
}

///<include file='Utils/Docs/HTMLScriptElement/HTMLScriptElement.generated.xml' path='docs/HTMLScriptElement/*'/>
public partial class HTMLScriptElement
{
		public string Charset { get; set; }
		public string Event { get; set; }
		public string HtmlFor { get; set; }
}

///<include file='Utils/Docs/HTMLTableElement/HTMLTableElement.generated.xml' path='docs/HTMLTableElement/*'/>
public partial class HTMLTableElement
{
	///<include file='Utils/Docs/HTMLTableElementAlign/HTMLTableElementAlign.generated.xml' path='docs/HTMLTableElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs/HTMLTableElementBorder/HTMLTableElementBorder.generated.xml' path='docs/HTMLTableElementBorder/*'/>
	public string Border { get; set; }
	///<include file='Utils/Docs/HTMLTableElementFrame/HTMLTableElementFrame.generated.xml' path='docs/HTMLTableElementFrame/*'/>
	public string Frame { get; set; }
	///<include file='Utils/Docs/HTMLTableElementRules/HTMLTableElementRules.generated.xml' path='docs/HTMLTableElementRules/*'/>
	public string Rules { get; set; }
	///<include file='Utils/Docs/HTMLTableElementSummary/HTMLTableElementSummary.generated.xml' path='docs/HTMLTableElementSummary/*'/>
	public string Summary { get; set; }
	///<include file='Utils/Docs/HTMLTableElementWidth/HTMLTableElementWidth.generated.xml' path='docs/HTMLTableElementWidth/*'/>
	public string Width { get; set; }
	///<include file='Utils/Docs/HTMLTableElementBgColor/HTMLTableElementBgColor.generated.xml' path='docs/HTMLTableElementBgColor/*'/>
	public string BgColor { get; set; }
	///<include file='Utils/Docs/HTMLTableElementCellPadding/HTMLTableElementCellPadding.generated.xml' path='docs/HTMLTableElementCellPadding/*'/>
	public string CellPadding { get; set; }
	///<include file='Utils/Docs/HTMLTableElementCellSpacing/HTMLTableElementCellSpacing.generated.xml' path='docs/HTMLTableElementCellSpacing/*'/>
	public string CellSpacing { get; set; }
}

///<include file='Utils/Docs/HTMLTableSectionElement/HTMLTableSectionElement.generated.xml' path='docs/HTMLTableSectionElement/*'/>
public partial class HTMLTableSectionElement
{
		public string Align { get; set; }
		public string Ch { get; set; }
		public string ChOff { get; set; }
		public string VAlign { get; set; }
}

///<include file='Utils/Docs/HTMLTableCellElement/HTMLTableCellElement.generated.xml' path='docs/HTMLTableCellElement/*'/>
public partial class HTMLTableCellElement
{
		public string Align { get; set; }
		public string Axis { get; set; }
		public string Height { get; set; }
		public string Width { get; set; }
		public string Ch { get; set; }
		public string ChOff { get; set; }
		public bool NoWrap { get; set; }
		public string VAlign { get; set; }
		public string BgColor { get; set; }
}

///<include file='Utils/Docs/HTMLTableRowElement/HTMLTableRowElement.generated.xml' path='docs/HTMLTableRowElement/*'/>
public partial class HTMLTableRowElement
{
		public string Align { get; set; }
		public string Ch { get; set; }
		public string ChOff { get; set; }
		public string VAlign { get; set; }
		public string BgColor { get; set; }
}

///<include file='Utils/Docs/HTMLUListElement/HTMLUListElement.generated.xml' path='docs/HTMLUListElement/*'/>
public partial class HTMLUListElement
{
		public bool Compact { get; set; }
		public string Type { get; set; }
}

///<include file='Utils/Docs/Document/Document.generated.xml' path='docs/Document/*'/>
public partial class Document
{
	///<include file='Utils/Docs/DocumentFgColor/DocumentFgColor.generated.xml' path='docs/DocumentFgColor/*'/>
	public string FgColor { get; set; }
	///<include file='Utils/Docs/DocumentLinkColor/DocumentLinkColor.generated.xml' path='docs/DocumentLinkColor/*'/>
	public string LinkColor { get; set; }
	///<include file='Utils/Docs/DocumentVlinkColor/DocumentVlinkColor.generated.xml' path='docs/DocumentVlinkColor/*'/>
	public string VlinkColor { get; set; }
	///<include file='Utils/Docs/DocumentAlinkColor/DocumentAlinkColor.generated.xml' path='docs/DocumentAlinkColor/*'/>
	public string AlinkColor { get; set; }
	///<include file='Utils/Docs/DocumentBgColor/DocumentBgColor.generated.xml' path='docs/DocumentBgColor/*'/>
	public string BgColor { get; set; }
	///<include file='Utils/Docs/DocumentAnchors/DocumentAnchors.generated.xml' path='docs/DocumentAnchors/*'/>
	public HTMLCollection Anchors { get; }
	///<include file='Utils/Docs/DocumentApplets/DocumentApplets.generated.xml' path='docs/DocumentApplets/*'/>
	public HTMLCollection Applets { get; }
	///<include file='Utils/Docs/DocumentClear/DocumentClear.generated.xml' path='docs/DocumentClear/*'/>
	public Undefined Clear() { throw new System.NotImplementedException(); }
		public Undefined CaptureEvents() { throw new System.NotImplementedException(); }
		public Undefined ReleaseEvents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentAll/DocumentAll.generated.xml' path='docs/DocumentAll/*'/>
	public HTMLAllCollection All { get; }
}

///<include file='Utils/Docs/Window/Window.generated.xml' path='docs/Window/*'/>
public partial class Window
{
	///<include file='Utils/Docs/WindowCaptureEvents/WindowCaptureEvents.generated.xml' path='docs/WindowCaptureEvents/*'/>
	public Undefined CaptureEvents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowReleaseEvents/WindowReleaseEvents.generated.xml' path='docs/WindowReleaseEvents/*'/>
	public Undefined ReleaseEvents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowExternal/WindowExternal.generated.xml' path='docs/WindowExternal/*'/>
	public External External { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class External
{
		public Undefined AddSearchProvider() { throw new System.NotImplementedException(); }
		public Undefined IsSearchProviderInstalled() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Notification/Notification.generated.xml' path='docs/Notification/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Notification : EventTarget
{
	///<include file='Utils/Docs/NotificationNotification/NotificationNotification.generated.xml' path='docs/NotificationNotification/*'/>
	public Notification(string title, NotificationOptions options) { }
		public static NotificationPermission Permission { get; }
		public static Task<NotificationPermission> RequestPermission(NotificationPermissionCallback deprecatedCallback) { throw new System.NotImplementedException(); }
		public static ulong MaxActions { get; }
		public EventHandler Onclick { get; set; }
		public EventHandler Onshow { get; set; }
		public EventHandler Onerror { get; set; }
		public EventHandler Onclose { get; set; }
	///<include file='Utils/Docs/NotificationTitle/NotificationTitle.generated.xml' path='docs/NotificationTitle/*'/>
	public string Title { get; }
	///<include file='Utils/Docs/NotificationDir/NotificationDir.generated.xml' path='docs/NotificationDir/*'/>
	public NotificationDirection Dir { get; }
	///<include file='Utils/Docs/NotificationLang/NotificationLang.generated.xml' path='docs/NotificationLang/*'/>
	public string Lang { get; }
	///<include file='Utils/Docs/NotificationBody/NotificationBody.generated.xml' path='docs/NotificationBody/*'/>
	public string Body { get; }
	///<include file='Utils/Docs/NotificationTag/NotificationTag.generated.xml' path='docs/NotificationTag/*'/>
	public string Tag { get; }
	///<include file='Utils/Docs/NotificationImage/NotificationImage.generated.xml' path='docs/NotificationImage/*'/>
	public string Image { get; }
	///<include file='Utils/Docs/NotificationIcon/NotificationIcon.generated.xml' path='docs/NotificationIcon/*'/>
	public string Icon { get; }
	///<include file='Utils/Docs/NotificationBadge/NotificationBadge.generated.xml' path='docs/NotificationBadge/*'/>
	public string Badge { get; }
	///<include file='Utils/Docs/NotificationVibrate/NotificationVibrate.generated.xml' path='docs/NotificationVibrate/*'/>
	public ulong[] Vibrate { get; }
	///<include file='Utils/Docs/NotificationTimestamp/NotificationTimestamp.generated.xml' path='docs/NotificationTimestamp/*'/>
	public Unsupported /*EpochTimeStamp*/ Timestamp { get; }
	///<include file='Utils/Docs/NotificationRenotify/NotificationRenotify.generated.xml' path='docs/NotificationRenotify/*'/>
	public bool Renotify { get; }
	///<include file='Utils/Docs/NotificationSilent/NotificationSilent.generated.xml' path='docs/NotificationSilent/*'/>
	public bool Silent { get; }
	///<include file='Utils/Docs/NotificationRequireInteraction/NotificationRequireInteraction.generated.xml' path='docs/NotificationRequireInteraction/*'/>
	public bool RequireInteraction { get; }
	///<include file='Utils/Docs/NotificationData/NotificationData.generated.xml' path='docs/NotificationData/*'/>
	public dynamic Data { get; }
	///<include file='Utils/Docs/NotificationActions/NotificationActions.generated.xml' path='docs/NotificationActions/*'/>
	public NotificationAction[] Actions { get; }
	///<include file='Utils/Docs/NotificationClose/NotificationClose.generated.xml' path='docs/NotificationClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NotificationOptions
{
		public NotificationDirection Dir;
		public string Lang;
		public string Body;
		public string Tag;
		public string Image;
		public string Icon;
		public string Badge;
		public Unsupported /*VibratePattern*/ Vibrate;
		public Unsupported /*EpochTimeStamp*/ Timestamp;
		public bool Renotify;
		public bool Silent;
		public bool RequireInteraction;
		public dynamic Data;
		public List<NotificationAction> Actions;
}

public enum NotificationPermission
{
	Default,
	Denied,
	Granted,
}

public enum NotificationDirection
{
	Auto,
	Ltr,
	Rtl,
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NotificationAction
{
		public required string Action;
		public required string Title;
		public string Icon;
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct NotificationPermissionCallback
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class GetNotificationOptions
{
		public string Tag;
}

///<include file='Utils/Docs/ServiceWorkerRegistration/ServiceWorkerRegistration.generated.xml' path='docs/ServiceWorkerRegistration/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ServiceWorkerRegistration
{
	///<include file='Utils/Docs/ServiceWorkerRegistrationShowNotification/ServiceWorkerRegistrationShowNotification.generated.xml' path='docs/ServiceWorkerRegistrationShowNotification/*'/>
	public Task<Undefined> ShowNotification(string title, NotificationOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ServiceWorkerRegistrationGetNotifications/ServiceWorkerRegistrationGetNotifications.generated.xml' path='docs/ServiceWorkerRegistrationGetNotifications/*'/>
	public Task<List<Notification>> GetNotifications(GetNotificationOptions filter) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/NotificationEvent/NotificationEvent.generated.xml' path='docs/NotificationEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class NotificationEvent
{
	///<include file='Utils/Docs/NotificationEventNotificationEvent/NotificationEventNotificationEvent.generated.xml' path='docs/NotificationEventNotificationEvent/*'/>
	public NotificationEvent(string type, NotificationEventInit eventInitDict) { }
	///<include file='Utils/Docs/NotificationEventNotification/NotificationEventNotification.generated.xml' path='docs/NotificationEventNotification/*'/>
	public Notification Notification { get; }
	///<include file='Utils/Docs/NotificationEventAction/NotificationEventAction.generated.xml' path='docs/NotificationEventAction/*'/>
	public string Action { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class NotificationEventInit
{
		public required Notification Notification;
		public string Action;
}

///<include file='Utils/Docs/ServiceWorkerGlobalScope/ServiceWorkerGlobalScope.generated.xml' path='docs/ServiceWorkerGlobalScope/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ServiceWorkerGlobalScope
{
		public EventHandler Onnotificationclick { get; set; }
		public EventHandler Onnotificationclose { get; set; }
}

///<include file='Utils/Docs/NavigatorStorage/NavigatorStorage.generated.xml' path='docs/NavigatorStorage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorStorage
{
		public StorageManager Storage { get { throw new System.NotImplementedException(); } }
}



///<include file='Utils/Docs/StorageManager/StorageManager.generated.xml' path='docs/StorageManager/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class StorageManager
{
	///<include file='Utils/Docs/StorageManagerPersisted/StorageManagerPersisted.generated.xml' path='docs/StorageManagerPersisted/*'/>
	public Task<bool> Persisted() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/StorageManagerPersist/StorageManagerPersist.generated.xml' path='docs/StorageManagerPersist/*'/>
	public Task<bool> Persist() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/StorageManagerEstimate/StorageManagerEstimate.generated.xml' path='docs/StorageManagerEstimate/*'/>
	public Task<StorageEstimate> Estimate() { throw new System.NotImplementedException(); }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class StorageEstimate
{
		public ulong Usage;
		public ulong Quota;
}

///<include file='Utils/Docs/URL/URL.generated.xml' path='docs/URL/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class URL
{
	///<include file='Utils/Docs/URLURL/URLURL.generated.xml' path='docs/URLURL/*'/>
	public URL(string url, string base_) { }
	///<include file='Utils/Docs/URLHref/URLHref.generated.xml' path='docs/URLHref/*'/>
	public string Href { get; set; }
	///<include file='Utils/Docs/URLOrigin/URLOrigin.generated.xml' path='docs/URLOrigin/*'/>
	public string Origin { get; }
	///<include file='Utils/Docs/URLProtocol/URLProtocol.generated.xml' path='docs/URLProtocol/*'/>
	public string Protocol { get; set; }
	///<include file='Utils/Docs/URLUsername/URLUsername.generated.xml' path='docs/URLUsername/*'/>
	public string Username { get; set; }
	///<include file='Utils/Docs/URLPassword/URLPassword.generated.xml' path='docs/URLPassword/*'/>
	public string Password { get; set; }
	///<include file='Utils/Docs/URLHost/URLHost.generated.xml' path='docs/URLHost/*'/>
	public string Host { get; set; }
	///<include file='Utils/Docs/URLHostname/URLHostname.generated.xml' path='docs/URLHostname/*'/>
	public string Hostname { get; set; }
	///<include file='Utils/Docs/URLPort/URLPort.generated.xml' path='docs/URLPort/*'/>
	public string Port { get; set; }
	///<include file='Utils/Docs/URLPathname/URLPathname.generated.xml' path='docs/URLPathname/*'/>
	public string Pathname { get; set; }
	///<include file='Utils/Docs/URLSearch/URLSearch.generated.xml' path='docs/URLSearch/*'/>
	public string Search { get; set; }
	///<include file='Utils/Docs/URLSearchParams/URLSearchParams.generated.xml' path='docs/URLSearchParams/*'/>
	public URLSearchParams SearchParams { get; }
	///<include file='Utils/Docs/URLHash/URLHash.generated.xml' path='docs/URLHash/*'/>
	public string Hash { get; set; }
	///<include file='Utils/Docs/URLToJSON/URLToJSON.generated.xml' path='docs/URLToJSON/*'/>
	public string ToJSON() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/URLSearchParams/URLSearchParams.generated.xml' path='docs/URLSearchParams/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class URLSearchParams
{
	///<include file='Utils/Docs/URLSearchParamsURLSearchParams/URLSearchParamsURLSearchParams.generated.xml' path='docs/URLSearchParamsURLSearchParams/*'/>
	public URLSearchParams(Union47 init) { }
	///<include file='Utils/Docs/URLSearchParamsAppend/URLSearchParamsAppend.generated.xml' path='docs/URLSearchParamsAppend/*'/>
	public Undefined Append(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/URLSearchParamsDelete/URLSearchParamsDelete.generated.xml' path='docs/URLSearchParamsDelete/*'/>
	public Undefined Delete(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/URLSearchParamsGet/URLSearchParamsGet.generated.xml' path='docs/URLSearchParamsGet/*'/>
	public string? Get(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/URLSearchParamsGetAll/URLSearchParamsGetAll.generated.xml' path='docs/URLSearchParamsGetAll/*'/>
	public List<string> GetAll(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/URLSearchParamsHas/URLSearchParamsHas.generated.xml' path='docs/URLSearchParamsHas/*'/>
	public bool Has(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/URLSearchParamsSet/URLSearchParamsSet.generated.xml' path='docs/URLSearchParamsSet/*'/>
	public Undefined Set(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/URLSearchParamsSort/URLSearchParamsSort.generated.xml' path='docs/URLSearchParamsSort/*'/>
	public Undefined Sort() { throw new System.NotImplementedException(); }
	public string this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
	
}



///<include file='Utils/Docs/DOMException/DOMException.generated.xml' path='docs/DOMException/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DOMException
{
	///<include file='Utils/Docs/DOMExceptionDOMException/DOMExceptionDOMException.generated.xml' path='docs/DOMExceptionDOMException/*'/>
	public DOMException(string message, string name) { }
	///<include file='Utils/Docs/DOMExceptionName/DOMExceptionName.generated.xml' path='docs/DOMExceptionName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs/DOMExceptionMessage/DOMExceptionMessage.generated.xml' path='docs/DOMExceptionMessage/*'/>
	public string Message { get; }
	///<include file='Utils/Docs/DOMExceptionCode/DOMExceptionCode.generated.xml' path='docs/DOMExceptionCode/*'/>
	public ushort Code { get; }
		public const ushort INDEX_SIZE_ERR = 1;
		public const ushort DOMSTRING_SIZE_ERR = 2;
		public const ushort HIERARCHY_REQUEST_ERR = 3;
		public const ushort WRONG_DOCUMENT_ERR = 4;
		public const ushort INVALID_CHARACTER_ERR = 5;
		public const ushort NO_DATA_ALLOWED_ERR = 6;
		public const ushort NO_MODIFICATION_ALLOWED_ERR = 7;
		public const ushort NOT_FOUND_ERR = 8;
		public const ushort NOT_SUPPORTED_ERR = 9;
		public const ushort INUSE_ATTRIBUTE_ERR = 10;
		public const ushort INVALID_STATE_ERR = 11;
		public const ushort SYNTAX_ERR = 12;
		public const ushort INVALID_MODIFICATION_ERR = 13;
		public const ushort NAMESPACE_ERR = 14;
		public const ushort INVALID_ACCESS_ERR = 15;
		public const ushort VALIDATION_ERR = 16;
		public const ushort TYPE_MISMATCH_ERR = 17;
		public const ushort SECURITY_ERR = 18;
		public const ushort NETWORK_ERR = 19;
		public const ushort ABORT_ERR = 20;
		public const ushort URL_MISMATCH_ERR = 21;
		public const ushort QUOTA_EXCEEDED_ERR = 22;
		public const ushort TIMEOUT_ERR = 23;
		public const ushort INVALID_NODE_TYPE_ERR = 24;
		public const ushort DATA_CLONE_ERR = 25;
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct Function
{
}

[To(ToAttribute.FirstCharToLowerCase)]
public struct VoidFunction
{
}

///<include file='Utils/Docs/XMLHttpRequestEventTarget/XMLHttpRequestEventTarget.generated.xml' path='docs/XMLHttpRequestEventTarget/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XMLHttpRequestEventTarget : EventTarget
{
		public EventHandler Onloadstart { get; set; }
		public EventHandler Onprogress { get; set; }
		public EventHandler Onabort { get; set; }
		public EventHandler Onerror { get; set; }
		public EventHandler Onload { get; set; }
		public EventHandler Ontimeout { get; set; }
		public EventHandler Onloadend { get; set; }
}

///<include file='Utils/Docs/XMLHttpRequestUpload/XMLHttpRequestUpload.generated.xml' path='docs/XMLHttpRequestUpload/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XMLHttpRequestUpload : XMLHttpRequestEventTarget
{
}

///<include file='Utils/Docs/XMLHttpRequestResponseType/XMLHttpRequestResponseType.generated.xml' path='docs/XMLHttpRequestResponseType/*'/>
public enum XMLHttpRequestResponseType
{
	Empty,
	Arraybuffer,
	Blob,
	Document,
	Json,
	Text,
}

///<include file='Utils/Docs/XMLHttpRequest/XMLHttpRequest.generated.xml' path='docs/XMLHttpRequest/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XMLHttpRequest : XMLHttpRequestEventTarget
{
	///<include file='Utils/Docs/XMLHttpRequestXMLHttpRequest/XMLHttpRequestXMLHttpRequest.generated.xml' path='docs/XMLHttpRequestXMLHttpRequest/*'/>
	public XMLHttpRequest() { }
		public EventHandler Onreadystatechange { get; set; }
		public const ushort UNSENT = 0;
		public const ushort OPENED = 1;
		public const ushort HEADERS_RECEIVED = 2;
		public const ushort LOADING = 3;
		public const ushort DONE = 4;
	///<include file='Utils/Docs/XMLHttpRequestReadyState/XMLHttpRequestReadyState.generated.xml' path='docs/XMLHttpRequestReadyState/*'/>
	public ushort ReadyState { get; }
	///<include file='Utils/Docs/XMLHttpRequestOpen/XMLHttpRequestOpen.generated.xml' path='docs/XMLHttpRequestOpen/*'/>
	public Undefined Open(string method, string url) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XMLHttpRequestOpen/XMLHttpRequestOpen.generated.xml' path='docs/XMLHttpRequestOpen/*'/>
	public Undefined Open(string method, string url, bool async, string? username, string? password) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XMLHttpRequestSetRequestHeader/XMLHttpRequestSetRequestHeader.generated.xml' path='docs/XMLHttpRequestSetRequestHeader/*'/>
	public Undefined SetRequestHeader(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XMLHttpRequestTimeout/XMLHttpRequestTimeout.generated.xml' path='docs/XMLHttpRequestTimeout/*'/>
	public ulong Timeout { get; set; }
	///<include file='Utils/Docs/XMLHttpRequestWithCredentials/XMLHttpRequestWithCredentials.generated.xml' path='docs/XMLHttpRequestWithCredentials/*'/>
	public bool WithCredentials { get; set; }
	///<include file='Utils/Docs/XMLHttpRequestUpload/XMLHttpRequestUpload.generated.xml' path='docs/XMLHttpRequestUpload/*'/>
	public XMLHttpRequestUpload Upload { get; }
	///<include file='Utils/Docs/XMLHttpRequestSend/XMLHttpRequestSend.generated.xml' path='docs/XMLHttpRequestSend/*'/>
	public Undefined Send(Union50? body) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XMLHttpRequestAbort/XMLHttpRequestAbort.generated.xml' path='docs/XMLHttpRequestAbort/*'/>
	public Undefined Abort() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XMLHttpRequestResponseURL/XMLHttpRequestResponseURL.generated.xml' path='docs/XMLHttpRequestResponseURL/*'/>
	public string ResponseURL { get; }
	///<include file='Utils/Docs/XMLHttpRequestStatus/XMLHttpRequestStatus.generated.xml' path='docs/XMLHttpRequestStatus/*'/>
	public ushort Status { get; }
	///<include file='Utils/Docs/XMLHttpRequestStatusText/XMLHttpRequestStatusText.generated.xml' path='docs/XMLHttpRequestStatusText/*'/>
	public string StatusText { get; }
	///<include file='Utils/Docs/XMLHttpRequestGetResponseHeader/XMLHttpRequestGetResponseHeader.generated.xml' path='docs/XMLHttpRequestGetResponseHeader/*'/>
	public string? GetResponseHeader(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XMLHttpRequestGetAllResponseHeaders/XMLHttpRequestGetAllResponseHeaders.generated.xml' path='docs/XMLHttpRequestGetAllResponseHeaders/*'/>
	public string GetAllResponseHeaders() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XMLHttpRequestOverrideMimeType/XMLHttpRequestOverrideMimeType.generated.xml' path='docs/XMLHttpRequestOverrideMimeType/*'/>
	public Undefined OverrideMimeType(string mime) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XMLHttpRequestResponseType/XMLHttpRequestResponseType.generated.xml' path='docs/XMLHttpRequestResponseType/*'/>
	public XMLHttpRequestResponseType ResponseType { get; set; }
	///<include file='Utils/Docs/XMLHttpRequestResponse/XMLHttpRequestResponse.generated.xml' path='docs/XMLHttpRequestResponse/*'/>
	public dynamic Response { get; }
	///<include file='Utils/Docs/XMLHttpRequestResponseText/XMLHttpRequestResponseText.generated.xml' path='docs/XMLHttpRequestResponseText/*'/>
	public string ResponseText { get; }
	///<include file='Utils/Docs/XMLHttpRequestResponseXML/XMLHttpRequestResponseXML.generated.xml' path='docs/XMLHttpRequestResponseXML/*'/>
	public Document? ResponseXML { get; }
}


///<include file='Utils/Docs/FormData/FormData.generated.xml' path='docs/FormData/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FormData
{
	///<include file='Utils/Docs/FormDataFormData/FormDataFormData.generated.xml' path='docs/FormDataFormData/*'/>
	public FormData(HTMLFormElement form) { }
	///<include file='Utils/Docs/FormDataAppend/FormDataAppend.generated.xml' path='docs/FormDataAppend/*'/>
	public Undefined Append(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FormDataAppend/FormDataAppend.generated.xml' path='docs/FormDataAppend/*'/>
	public Undefined Append(string name, Unsupported /*Blob*/ blobValue, string filename) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FormDataDelete/FormDataDelete.generated.xml' path='docs/FormDataDelete/*'/>
	public Undefined Delete(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FormDataGet/FormDataGet.generated.xml' path='docs/FormDataGet/*'/>
	public FormDataEntryValue? Get(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FormDataGetAll/FormDataGetAll.generated.xml' path='docs/FormDataGetAll/*'/>
	public List<FormDataEntryValue> GetAll(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FormDataHas/FormDataHas.generated.xml' path='docs/FormDataHas/*'/>
	public bool Has(string name) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FormDataSet/FormDataSet.generated.xml' path='docs/FormDataSet/*'/>
	public Undefined Set(string name, string value) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/FormDataSet/FormDataSet.generated.xml' path='docs/FormDataSet/*'/>
	public Undefined Set(string name, Unsupported /*Blob*/ blobValue, string filename) { throw new System.NotImplementedException(); }
	public string this[int i]  {  get { throw new System.NotImplementedException(); }  set { throw new System.NotImplementedException(); }  } 
}

///<include file='Utils/Docs/ProgressEvent/ProgressEvent.generated.xml' path='docs/ProgressEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ProgressEvent : Event
{
	///<include file='Utils/Docs/ProgressEventProgressEvent/ProgressEventProgressEvent.generated.xml' path='docs/ProgressEventProgressEvent/*'/>
	public ProgressEvent(string type, ProgressEventInit eventInitDict) { }
	///<include file='Utils/Docs/ProgressEventLengthComputable/ProgressEventLengthComputable.generated.xml' path='docs/ProgressEventLengthComputable/*'/>
	public bool LengthComputable { get; }
	///<include file='Utils/Docs/ProgressEventLoaded/ProgressEventLoaded.generated.xml' path='docs/ProgressEventLoaded/*'/>
	public ulong Loaded { get; }
	///<include file='Utils/Docs/ProgressEventTotal/ProgressEventTotal.generated.xml' path='docs/ProgressEventTotal/*'/>
	public ulong Total { get; }
}

[To(ToAttribute.FirstCharToLowerCase)]
public partial class ProgressEventInit : EventInit
{
		public bool LengthComputable;
		public ulong Loaded;
		public ulong Total;
}

///<summary>
///<see cref="Event"/> or <see cref="Undefined"/>
///</summary>
public struct Union0
{
	public dynamic Value { get; set; }
	public static implicit operator Union0(Event value){return new Union0 { Value = value };}
	public static implicit operator Union0(Undefined value){return new Union0 { Value = value };}
}

///<summary>
///<see cref="AddEventListenerOptions"/> or <see cref="bool"/>
///</summary>
public struct Union1
{
	public dynamic Value { get; set; }
	public static implicit operator Union1(AddEventListenerOptions value){return new Union1 { Value = value };}
	public static implicit operator Union1(bool value){return new Union1 { Value = value };}
}

///<summary>
///<see cref="EventListenerOptions"/> or <see cref="bool"/>
///</summary>
public struct Union2
{
	public dynamic Value { get; set; }
	public static implicit operator Union2(EventListenerOptions value){return new Union2 { Value = value };}
	public static implicit operator Union2(bool value){return new Union2 { Value = value };}
}

///<summary>
///<see cref="Node"/> or <see cref="string"/>
///</summary>
public struct Union3
{
	public dynamic Value { get; set; }
	public static implicit operator Union3(Node value){return new Union3 { Value = value };}
	public static implicit operator Union3(string value){return new Union3 { Value = value };}
}

///<summary>
///<see cref="Node"/> or <see cref="string"/>
///</summary>
public struct Union4
{
	public dynamic Value { get; set; }
	public static implicit operator Union4(Node value){return new Union4 { Value = value };}
	public static implicit operator Union4(string value){return new Union4 { Value = value };}
}

///<summary>
///<see cref="Node"/> or <see cref="string"/>
///</summary>
public struct Union5
{
	public dynamic Value { get; set; }
	public static implicit operator Union5(Node value){return new Union5 { Value = value };}
	public static implicit operator Union5(string value){return new Union5 { Value = value };}
}

///<summary>
///<see cref="Node"/> or <see cref="string"/>
///</summary>
public struct Union6
{
	public dynamic Value { get; set; }
	public static implicit operator Union6(Node value){return new Union6 { Value = value };}
	public static implicit operator Union6(string value){return new Union6 { Value = value };}
}

///<summary>
///<see cref="Node"/> or <see cref="string"/>
///</summary>
public struct Union7
{
	public dynamic Value { get; set; }
	public static implicit operator Union7(Node value){return new Union7 { Value = value };}
	public static implicit operator Union7(string value){return new Union7 { Value = value };}
}

///<summary>
///<see cref="Node"/> or <see cref="string"/>
///</summary>
public struct Union8
{
	public dynamic Value { get; set; }
	public static implicit operator Union8(Node value){return new Union8 { Value = value };}
	public static implicit operator Union8(string value){return new Union8 { Value = value };}
}

///<summary>
///<c>List{List{string}}</c> or <c>Dictionary{string, string}</c>
///</summary>
public struct Union9
{
	public dynamic Value { get; set; }
	public static implicit operator Union9(List<List<string>> value){return new Union9 { Value = value };}
	public static implicit operator Union9(Dictionary<string, string> value){return new Union9 { Value = value };}
}

///<summary>
///<see cref="Unsupported /*Blob*/"/> or <see cref="BufferSource"/> or <see cref="FormData"/> or <see cref="URLSearchParams"/> or <see cref="string"/>
///</summary>
public struct Union10
{
	public dynamic Value { get; set; }
	public static implicit operator Union10(Unsupported /*Blob*/ value){return new Union10 { Value = value };}
	public static implicit operator Union10(BufferSource value){return new Union10 { Value = value };}
	public static implicit operator Union10(FormData value){return new Union10 { Value = value };}
	public static implicit operator Union10(URLSearchParams value){return new Union10 { Value = value };}
	public static implicit operator Union10(string value){return new Union10 { Value = value };}
}

///<summary>
///<see cref="Unsupported /*ReadableStream*/"/> or <see cref="XMLHttpRequestBodyInit"/>
///</summary>
public struct Union11
{
	public dynamic Value { get; set; }
	public static implicit operator Union11(Unsupported /*ReadableStream*/ value){return new Union11 { Value = value };}
	public static implicit operator Union11(XMLHttpRequestBodyInit value){return new Union11 { Value = value };}
}

///<summary>
///<see cref="Request"/> or <see cref="string"/>
///</summary>
public struct Union12
{
	public dynamic Value { get; set; }
	public static implicit operator Union12(Request value){return new Union12 { Value = value };}
	public static implicit operator Union12(string value){return new Union12 { Value = value };}
}

///<summary>
///<see cref="HTMLCollection"/> or <see cref="Element"/>
///</summary>
public struct Union13
{
	public dynamic Value { get; set; }
	public static implicit operator Union13(HTMLCollection value){return new Union13 { Value = value };}
	public static implicit operator Union13(Element value){return new Union13 { Value = value };}
}

///<summary>
///<see cref="HTMLCollection"/> or <see cref="Element"/>
///</summary>
public struct Union14
{
	public dynamic Value { get; set; }
	public static implicit operator Union14(HTMLCollection value){return new Union14 { Value = value };}
	public static implicit operator Union14(Element value){return new Union14 { Value = value };}
}

///<summary>
///<see cref="RadioNodeList"/> or <see cref="Element"/>
///</summary>
public struct Union15
{
	public dynamic Value { get; set; }
	public static implicit operator Union15(RadioNodeList value){return new Union15 { Value = value };}
	public static implicit operator Union15(Element value){return new Union15 { Value = value };}
}

///<summary>
///<see cref="HTMLOptionElement"/> or <see cref="HTMLOptGroupElement"/>
///</summary>
public struct Union16
{
	public dynamic Value { get; set; }
	public static implicit operator Union16(HTMLOptionElement value){return new Union16 { Value = value };}
	public static implicit operator Union16(HTMLOptGroupElement value){return new Union16 { Value = value };}
}

///<summary>
///<see cref="HTMLElement"/> or <see cref="long"/>
///</summary>
public struct Union17
{
	public dynamic Value { get; set; }
	public static implicit operator Union17(HTMLElement value){return new Union17 { Value = value };}
	public static implicit operator Union17(long value){return new Union17 { Value = value };}
}

///<summary>
///<see cref="HTMLScriptElement"/> or <see cref="Unsupported /*SVGScriptElement*/"/>
///</summary>
public struct Union18
{
	public dynamic Value { get; set; }
	public static implicit operator Union18(HTMLScriptElement value){return new Union18 { Value = value };}
	public static implicit operator Union18(Unsupported /*SVGScriptElement*/ value){return new Union18 { Value = value };}
}

///<summary>
///<see cref="bool"/> or <see cref="double"/> or <see cref="string"/>
///</summary>
public struct Union19
{
	public dynamic Value { get; set; }
	public static implicit operator Union19(bool value){return new Union19 { Value = value };}
	public static implicit operator Union19(double value){return new Union19 { Value = value };}
	public static implicit operator Union19(string value){return new Union19 { Value = value };}
}

///<summary>
///<see cref="Unsupported /*MediaStream*/"/> or <see cref="Unsupported /*MediaSource*/"/> or <see cref="Unsupported /*Blob*/"/>
///</summary>
public struct Union20
{
	public dynamic Value { get; set; }
	public static implicit operator Union20(Unsupported /*MediaStream*/ value){return new Union20 { Value = value };}
}

///<summary>
///<see cref="VideoTrack"/> or <see cref="AudioTrack"/> or <see cref="TextTrack"/>
///</summary>
public struct Union21
{
	public dynamic Value { get; set; }
	public static implicit operator Union21(VideoTrack value){return new Union21 { Value = value };}
	public static implicit operator Union21(AudioTrack value){return new Union21 { Value = value };}
	public static implicit operator Union21(TextTrack value){return new Union21 { Value = value };}
}

///<summary>
///<see cref="VideoTrack"/> or <see cref="AudioTrack"/> or <see cref="TextTrack"/>
///</summary>
public struct Union22
{
	public dynamic Value { get; set; }
	public static implicit operator Union22(VideoTrack value){return new Union22 { Value = value };}
	public static implicit operator Union22(AudioTrack value){return new Union22 { Value = value };}
	public static implicit operator Union22(TextTrack value){return new Union22 { Value = value };}
}

///<summary>
///<see cref="RadioNodeList"/> or <see cref="Element"/>
///</summary>
public struct Union23
{
	public dynamic Value { get; set; }
	public static implicit operator Union23(RadioNodeList value){return new Union23 { Value = value };}
	public static implicit operator Union23(Element value){return new Union23 { Value = value };}
}

///<summary>
///<see cref="HTMLOptionElement"/> or <see cref="HTMLOptGroupElement"/>
///</summary>
public struct Union24
{
	public dynamic Value { get; set; }
	public static implicit operator Union24(HTMLOptionElement value){return new Union24 { Value = value };}
	public static implicit operator Union24(HTMLOptGroupElement value){return new Union24 { Value = value };}
}

///<summary>
///<see cref="HTMLElement"/> or <see cref="long"/>
///</summary>
public struct Union25
{
	public dynamic Value { get; set; }
	public static implicit operator Union25(HTMLElement value){return new Union25 { Value = value };}
	public static implicit operator Union25(long value){return new Union25 { Value = value };}
}

///<summary>
///<see cref="Element"/> or <see cref="Text"/>
///</summary>
public struct Union26
{
	public dynamic Value { get; set; }
	public static implicit operator Union26(Element value){return new Union26 { Value = value };}
	public static implicit operator Union26(Text value){return new Union26 { Value = value };}
}

///<summary>
///<see cref="CanvasRenderingContext2D"/> or <see cref="ImageBitmapRenderingContext"/> or <see cref="Unsupported /*WebGLRenderingContext*/"/> or <see cref="Unsupported /*WebGL2RenderingContext*/"/> or <see cref="Unsupported /*GPUCanvasContext*/"/>
///</summary>
public struct Union27
{
	public dynamic Value { get; set; }
	public static implicit operator Union27(CanvasRenderingContext2D value){return new Union27 { Value = value };}
	public static implicit operator Union27(ImageBitmapRenderingContext value){return new Union27 { Value = value };}
	public static implicit operator Union27(Unsupported /*WebGLRenderingContext*/ value){return new Union27 { Value = value };}
}

///<summary>
///<see cref="HTMLImageElement"/> or <see cref="Unsupported /*SVGImageElement*/"/>
///</summary>
public struct Union28
{
	public dynamic Value { get; set; }
	public static implicit operator Union28(HTMLImageElement value){return new Union28 { Value = value };}
	public static implicit operator Union28(Unsupported /*SVGImageElement*/ value){return new Union28 { Value = value };}
}

///<summary>
///<see cref="HTMLOrSVGImageElement"/> or <see cref="HTMLVideoElement"/> or <see cref="HTMLCanvasElement"/> or <see cref="ImageBitmap"/> or <see cref="OffscreenCanvas"/> or <see cref="Unsupported /*VideoFrame*/"/>
///</summary>
public struct Union29
{
	public dynamic Value { get; set; }
	public static implicit operator Union29(HTMLOrSVGImageElement value){return new Union29 { Value = value };}
	public static implicit operator Union29(HTMLVideoElement value){return new Union29 { Value = value };}
	public static implicit operator Union29(HTMLCanvasElement value){return new Union29 { Value = value };}
	public static implicit operator Union29(ImageBitmap value){return new Union29 { Value = value };}
	public static implicit operator Union29(OffscreenCanvas value){return new Union29 { Value = value };}
	public static implicit operator Union29(Unsupported /*VideoFrame*/ value){return new Union29 { Value = value };}
}

///<summary>
///<see cref="string"/> or <see cref="CanvasGradient"/> or <see cref="CanvasPattern"/>
///</summary>
public struct Union30
{
	public dynamic Value { get; set; }
	public static implicit operator Union30(string value){return new Union30 { Value = value };}
	public static implicit operator Union30(CanvasGradient value){return new Union30 { Value = value };}
	public static implicit operator Union30(CanvasPattern value){return new Union30 { Value = value };}
}

///<summary>
///<see cref="string"/> or <see cref="CanvasGradient"/> or <see cref="CanvasPattern"/>
///</summary>
public struct Union31
{
	public dynamic Value { get; set; }
	public static implicit operator Union31(string value){return new Union31 { Value = value };}
	public static implicit operator Union31(CanvasGradient value){return new Union31 { Value = value };}
	public static implicit operator Union31(CanvasPattern value){return new Union31 { Value = value };}
}

///<summary>
///<see cref="string"/> or <see cref="CanvasFilter"/>
///</summary>
public struct Union32
{
	public dynamic Value { get; set; }
	public static implicit operator Union32(string value){return new Union32 { Value = value };}
	public static implicit operator Union32(CanvasFilter value){return new Union32 { Value = value };}
}

///<summary>
///<see cref="CanvasFilterInput"/> or <c>List{CanvasFilterInput}</c>
///</summary>
public struct Union33
{
	public dynamic Value { get; set; }
	public static implicit operator Union33(CanvasFilterInput value){return new Union33 { Value = value };}
	public static implicit operator Union33(List<CanvasFilterInput> value){return new Union33 { Value = value };}
}

///<summary>
///<see cref="double"/> or <see cref="Unsupported /*DOMPointInit*/"/>
///</summary>
public struct Union35
{
	public dynamic Value { get; set; }
	public static implicit operator Union35(double value){return new Union35 { Value = value };}
	public static implicit operator Union35(Unsupported /*DOMPointInit*/ value){return new Union35 { Value = value };}
}

///<summary>
///<see cref="double"/> or <see cref="Unsupported /*DOMPointInit*/"/> or <c>List{Union35}</c>
///</summary>
public struct Union34
{
	public dynamic Value { get; set; }
	public static implicit operator Union34(double value){return new Union34 { Value = value };}
	public static implicit operator Union34(Unsupported /*DOMPointInit*/ value){return new Union34 { Value = value };}
	public static implicit operator Union34(List<Union35> value){return new Union34 { Value = value };}
}

///<summary>
///<see cref="Path2D"/> or <see cref="string"/>
///</summary>
public struct Union36
{
	public dynamic Value { get; set; }
	public static implicit operator Union36(Path2D value){return new Union36 { Value = value };}
	public static implicit operator Union36(string value){return new Union36 { Value = value };}
}

///<summary>
///<see cref="HTMLCanvasElement"/> or <see cref="OffscreenCanvas"/>
///</summary>
public struct Union37
{
	public dynamic Value { get; set; }
	public static implicit operator Union37(HTMLCanvasElement value){return new Union37 { Value = value };}
	public static implicit operator Union37(OffscreenCanvas value){return new Union37 { Value = value };}
}

///<summary>
///<see cref="OffscreenCanvasRenderingContext2D"/> or <see cref="ImageBitmapRenderingContext"/> or <see cref="Unsupported /*WebGLRenderingContext*/"/> or <see cref="Unsupported /*WebGL2RenderingContext*/"/> or <see cref="Unsupported /*GPUCanvasContext*/"/>
///</summary>
public struct Union38
{
	public dynamic Value { get; set; }
	public static implicit operator Union38(OffscreenCanvasRenderingContext2D value){return new Union38 { Value = value };}
	public static implicit operator Union38(ImageBitmapRenderingContext value){return new Union38 { Value = value };}
	public static implicit operator Union38(Unsupported /*WebGLRenderingContext*/ value){return new Union38 { Value = value };}
}

///<summary>
///<see cref="CustomElementConstructor"/> or <see cref="Undefined"/>
///</summary>
public struct Union39
{
	public dynamic Value { get; set; }
	public static implicit operator Union39(CustomElementConstructor value){return new Union39 { Value = value };}
	public static implicit operator Union39(Undefined value){return new Union39 { Value = value };}
}

///<summary>
///<see cref="Unsupported /*File*/"/> or <see cref="string"/> or <see cref="FormData"/>
///</summary>
public struct Union40
{
	public dynamic Value { get; set; }
	public static implicit operator Union40(Unsupported /*File*/ value){return new Union40 { Value = value };}
	public static implicit operator Union40(string value){return new Union40 { Value = value };}
	public static implicit operator Union40(FormData value){return new Union40 { Value = value };}
}

///<summary>
///<see cref="Unsupported /*File*/"/> or <see cref="string"/> or <see cref="FormData"/>
///</summary>
public struct Union41
{
	public dynamic Value { get; set; }
	public static implicit operator Union41(Unsupported /*File*/ value){return new Union41 { Value = value };}
	public static implicit operator Union41(string value){return new Union41 { Value = value };}
	public static implicit operator Union41(FormData value){return new Union41 { Value = value };}
}

///<summary>
///<see cref="Event"/> or <see cref="string"/>
///</summary>
public struct Union42
{
	public dynamic Value { get; set; }
	public static implicit operator Union42(Event value){return new Union42 { Value = value };}
	public static implicit operator Union42(string value){return new Union42 { Value = value };}
}

///<summary>
///<see cref="string"/> or <see cref="Function"/>
///</summary>
public struct Union43
{
	public dynamic Value { get; set; }
	public static implicit operator Union43(string value){return new Union43 { Value = value };}
	public static implicit operator Union43(Function value){return new Union43 { Value = value };}
}

///<summary>
///<see cref="CanvasImageSource"/> or <see cref="Unsupported /*Blob*/"/> or <see cref="ImageData"/>
///</summary>
public struct Union44
{
	public dynamic Value { get; set; }
	public static implicit operator Union44(CanvasImageSource value){return new Union44 { Value = value };}
	public static implicit operator Union44(Unsupported /*Blob*/ value){return new Union44 { Value = value };}
	public static implicit operator Union44(ImageData value){return new Union44 { Value = value };}
}

///<summary>
///<see cref="Window"/> or <see cref="MessagePort"/> or <see cref="Unsupported /*ServiceWorker*/"/>
///</summary>
public struct Union45
{
	public dynamic Value { get; set; }
	public static implicit operator Union45(Window value){return new Union45 { Value = value };}
	public static implicit operator Union45(MessagePort value){return new Union45 { Value = value };}
	public static implicit operator Union45(Unsupported /*ServiceWorker*/ value){return new Union45 { Value = value };}
}

///<summary>
///<see cref="string"/> or <see cref="WorkerOptions"/>
///</summary>
public struct Union46
{
	public dynamic Value { get; set; }
	public static implicit operator Union46(string value){return new Union46 { Value = value };}
	public static implicit operator Union46(WorkerOptions value){return new Union46 { Value = value };}
}

///<summary>
///<c>List{List{string}}</c> or <c>Dictionary{string, string}</c> or <see cref="string"/>
///</summary>
public struct Union47
{
	public dynamic Value { get; set; }
	public static implicit operator Union47(List<List<string>> value){return new Union47 { Value = value };}
	public static implicit operator Union47(Dictionary<string, string> value){return new Union47 { Value = value };}
	public static implicit operator Union47(string value){return new Union47 { Value = value };}
}

///<summary>
///<see cref="System.SByte"/> or <see cref="System.Int16"/> or <see cref="System.Int32"/> or <see cref="System.Byte"/> or <see cref="System.UInt16"/> or <see cref="System.UInt32"/> or <see cref="Unsupported /*Uint8ClampedArray*/"/> or <see cref="System.Int64"/> or <see cref="System.UInt64"/> or <see cref="System.Single"/> or <see cref="System.Double"/> or <see cref="Unsupported /*DataView*/"/>
///</summary>
public struct Union48
{
	public dynamic Value { get; set; }
	public static implicit operator Union48(System.SByte value){return new Union48 { Value = value };}
	public static implicit operator Union48(System.Int16 value){return new Union48 { Value = value };}
	public static implicit operator Union48(System.Int32 value){return new Union48 { Value = value };}
	public static implicit operator Union48(System.Byte value){return new Union48 { Value = value };}
	public static implicit operator Union48(System.UInt16 value){return new Union48 { Value = value };}
	public static implicit operator Union48(System.UInt32 value){return new Union48 { Value = value };}
	public static implicit operator Union48(Unsupported /*Uint8ClampedArray*/ value){return new Union48 { Value = value };}
	public static implicit operator Union48(System.Int64 value){return new Union48 { Value = value };}
	public static implicit operator Union48(System.UInt64 value){return new Union48 { Value = value };}
	public static implicit operator Union48(System.Single value){return new Union48 { Value = value };}
	public static implicit operator Union48(System.Double value){return new Union48 { Value = value };}
}

///<summary>
///<see cref="ArrayBufferView"/> or <see cref="byte[]"/>
///</summary>
public struct Union49
{
	public dynamic Value { get; set; }
	public static implicit operator Union49(ArrayBufferView value){return new Union49 { Value = value };}
	public static implicit operator Union49(byte[] value){return new Union49 { Value = value };}
}

///<summary>
///<see cref="Document"/> or <see cref="XMLHttpRequestBodyInit"/>
///</summary>
public struct Union50
{
	public dynamic Value { get; set; }
	public static implicit operator Union50(Document value){return new Union50 { Value = value };}
	public static implicit operator Union50(XMLHttpRequestBodyInit value){return new Union50 { Value = value };}
}

///<summary>
///<see cref="Unsupported /*File*/"/> or <see cref="string"/>
///</summary>
public struct Union51
{
	public dynamic Value { get; set; }
	public static implicit operator Union51(Unsupported /*File*/ value){return new Union51 { Value = value };}
	public static implicit operator Union51(string value){return new Union51 { Value = value };}
}

