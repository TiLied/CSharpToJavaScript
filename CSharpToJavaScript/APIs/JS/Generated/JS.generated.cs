//18.07.2023 12:26:56
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
	///<include file='Utils/Docs/WindowOnorientationchange/WindowOnorientationchange.generated.xml' path='docs/WindowOnorientationchange/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onorientationchange { get; set; }
}

///<include file='Utils/Docs/HTMLBodyElement/HTMLBodyElement.generated.xml' path='docs/HTMLBodyElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLBodyElement
{
	///<include file='Utils/Docs/HTMLBodyElementOnorientationchange/HTMLBodyElementOnorientationchange.generated.xml' path='docs/HTMLBodyElementOnorientationchange/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onorientationchange { get; set; }
}

///<include file='Utils/Docs/console/console.generated.xml' path='docs/console/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class console
{
	///<include file='Utils/Docs/consoleAssert/consoleAssert.generated.xml' path='docs/consoleAssert/*'/>
	public Undefined Assert(bool condition, params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/consoleClear/consoleClear.generated.xml' path='docs/consoleClear/*'/>
	public Undefined Clear() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/consoleDebug/consoleDebug.generated.xml' path='docs/consoleDebug/*'/>
	public Undefined Debug(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/consoleError/consoleError.generated.xml' path='docs/consoleError/*'/>
	public Undefined Error(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/consoleInfo/consoleInfo.generated.xml' path='docs/consoleInfo/*'/>
	public Undefined Info(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/consoleLog/consoleLog.generated.xml' path='docs/consoleLog/*'/>
	public Undefined Log(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/consoleTable/consoleTable.generated.xml' path='docs/consoleTable/*'/>
	public Undefined Table(dynamic tabularData, List<string> properties) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/consoleTrace/consoleTrace.generated.xml' path='docs/consoleTrace/*'/>
	public Undefined Trace(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/consoleWarn/consoleWarn.generated.xml' path='docs/consoleWarn/*'/>
	public Undefined Warn(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/consoleDir/consoleDir.generated.xml' path='docs/consoleDir/*'/>
	public Undefined Dir(dynamic item, object? options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/consoleDirxml/consoleDirxml.generated.xml' path='docs/consoleDirxml/*'/>
	public Undefined Dirxml(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/consoleCount/consoleCount.generated.xml' path='docs/consoleCount/*'/>
	public Undefined Count(string label) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/consoleCountReset/consoleCountReset.generated.xml' path='docs/consoleCountReset/*'/>
	public Undefined CountReset(string label) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/consoleGroup/consoleGroup.generated.xml' path='docs/consoleGroup/*'/>
	public Undefined Group(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/consoleGroupCollapsed/consoleGroupCollapsed.generated.xml' path='docs/consoleGroupCollapsed/*'/>
	public Undefined GroupCollapsed(params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/consoleGroupEnd/consoleGroupEnd.generated.xml' path='docs/consoleGroupEnd/*'/>
	public Undefined GroupEnd() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/consoleTime/consoleTime.generated.xml' path='docs/consoleTime/*'/>
	public Undefined Time(string label) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/consoleTimeLog/consoleTimeLog.generated.xml' path='docs/consoleTimeLog/*'/>
	public Undefined TimeLog(string label, params dynamic[] data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/consoleTimeEnd/consoleTimeEnd.generated.xml' path='docs/consoleTimeEnd/*'/>
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
	///<include file='Utils/Docs/EventNONE/EventNONE.generated.xml' path='docs/EventNONE/*'/>
	public const ushort NONE = 0;
	///<include file='Utils/Docs/EventCAPTURING_PHASE/EventCAPTURING_PHASE.generated.xml' path='docs/EventCAPTURING_PHASE/*'/>
	public const ushort CAPTURING_PHASE = 1;
	///<include file='Utils/Docs/EventAT_TARGET/EventAT_TARGET.generated.xml' path='docs/EventAT_TARGET/*'/>
	public const ushort AT_TARGET = 2;
	///<include file='Utils/Docs/EventBUBBLING_PHASE/EventBUBBLING_PHASE.generated.xml' path='docs/EventBUBBLING_PHASE/*'/>
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

///<include file='Utils/Docs/EventInit/EventInit.generated.xml' path='docs/EventInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class EventInit
{
	///<include file='Utils/Docs/EventInitBubbles/EventInitBubbles.generated.xml' path='docs/EventInitBubbles/*'/>
	public bool Bubbles;
	///<include file='Utils/Docs/EventInitCancelable/EventInitCancelable.generated.xml' path='docs/EventInitCancelable/*'/>
	public bool Cancelable;
	///<include file='Utils/Docs/EventInitComposed/EventInitComposed.generated.xml' path='docs/EventInitComposed/*'/>
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

///<include file='Utils/Docs/CustomEventInit/CustomEventInit.generated.xml' path='docs/CustomEventInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CustomEventInit : EventInit
{
	///<include file='Utils/Docs/CustomEventInitDetail/CustomEventInitDetail.generated.xml' path='docs/CustomEventInitDetail/*'/>
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

///<include file='Utils/Docs/EventListener/EventListener.generated.xml' path='docs/EventListener/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface EventListener
{
	///<include file='Utils/Docs/EventListenerHandleEvent/EventListenerHandleEvent.generated.xml' path='docs/EventListenerHandleEvent/*'/>
	public Undefined HandleEvent(Event event_) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/EventListenerOptions/EventListenerOptions.generated.xml' path='docs/EventListenerOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class EventListenerOptions
{
	///<include file='Utils/Docs/EventListenerOptionsCapture/EventListenerOptionsCapture.generated.xml' path='docs/EventListenerOptionsCapture/*'/>
	public bool Capture;
}

///<include file='Utils/Docs/AddEventListenerOptions/AddEventListenerOptions.generated.xml' path='docs/AddEventListenerOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AddEventListenerOptions : EventListenerOptions
{
	///<include file='Utils/Docs/AddEventListenerOptionsPassive/AddEventListenerOptionsPassive.generated.xml' path='docs/AddEventListenerOptionsPassive/*'/>
	public bool Passive;
	///<include file='Utils/Docs/AddEventListenerOptionsOnce/AddEventListenerOptionsOnce.generated.xml' path='docs/AddEventListenerOptionsOnce/*'/>
	public bool Once;
	///<include file='Utils/Docs/AddEventListenerOptionsSignal/AddEventListenerOptionsSignal.generated.xml' path='docs/AddEventListenerOptionsSignal/*'/>
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
	///<include file='Utils/Docs/AbortSignalAbort/AbortSignalAbort.generated.xml' path='docs/AbortSignalAbort/*'/>
	public static AbortSignal Abort(dynamic reason) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AbortSignalTimeout/AbortSignalTimeout.generated.xml' path='docs/AbortSignalTimeout/*'/>
	public static AbortSignal Timeout(ulong milliseconds) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AbortSignalAborted/AbortSignalAborted.generated.xml' path='docs/AbortSignalAborted/*'/>
	public bool Aborted { get; }
	///<include file='Utils/Docs/AbortSignalReason/AbortSignalReason.generated.xml' path='docs/AbortSignalReason/*'/>
	public dynamic Reason { get; }
	///<include file='Utils/Docs/AbortSignalThrowIfAborted/AbortSignalThrowIfAborted.generated.xml' path='docs/AbortSignalThrowIfAborted/*'/>
	public Undefined ThrowIfAborted() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AbortSignalOnabort/AbortSignalOnabort.generated.xml' path='docs/AbortSignalOnabort/*'/>
	public EventHandler Onabort { get; set; }
}

///<include file='Utils/Docs/NonElementParentNode/NonElementParentNode.generated.xml' path='docs/NonElementParentNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NonElementParentNode
{
	///<include file='Utils/Docs/NonElementParentNodeGetElementById/NonElementParentNodeGetElementById.generated.xml' path='docs/NonElementParentNodeGetElementById/*'/>
	public Element? GetElementById(string elementId) { throw new System.NotImplementedException(); }
}



///<include file='Utils/Docs/DocumentOrShadowRoot/DocumentOrShadowRoot.generated.xml' path='docs/DocumentOrShadowRoot/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface DocumentOrShadowRoot
{
}



///<include file='Utils/Docs/ParentNode/ParentNode.generated.xml' path='docs/ParentNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface ParentNode
{
	///<include file='Utils/Docs/ParentNodeChildren/ParentNodeChildren.generated.xml' path='docs/ParentNodeChildren/*'/>
	public HTMLCollection Children { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/ParentNodeFirstElementChild/ParentNodeFirstElementChild.generated.xml' path='docs/ParentNodeFirstElementChild/*'/>
	public Element? FirstElementChild { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/ParentNodeLastElementChild/ParentNodeLastElementChild.generated.xml' path='docs/ParentNodeLastElementChild/*'/>
	public Element? LastElementChild { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/ParentNodeChildElementCount/ParentNodeChildElementCount.generated.xml' path='docs/ParentNodeChildElementCount/*'/>
	public ulong ChildElementCount { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/ParentNodePrepend/ParentNodePrepend.generated.xml' path='docs/ParentNodePrepend/*'/>
	public Undefined Prepend(params Union3[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ParentNodeAppend/ParentNodeAppend.generated.xml' path='docs/ParentNodeAppend/*'/>
	public Undefined Append(params Union4[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ParentNodeReplaceChildren/ParentNodeReplaceChildren.generated.xml' path='docs/ParentNodeReplaceChildren/*'/>
	public Undefined ReplaceChildren(params Union5[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ParentNodeQuerySelector/ParentNodeQuerySelector.generated.xml' path='docs/ParentNodeQuerySelector/*'/>
	public Element? QuerySelector(string selectors) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ParentNodeQuerySelectorAll/ParentNodeQuerySelectorAll.generated.xml' path='docs/ParentNodeQuerySelectorAll/*'/>
	public NodeList QuerySelectorAll(string selectors) { throw new System.NotImplementedException(); }
}




///<include file='Utils/Docs/NonDocumentTypeChildNode/NonDocumentTypeChildNode.generated.xml' path='docs/NonDocumentTypeChildNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NonDocumentTypeChildNode
{
	///<include file='Utils/Docs/NonDocumentTypeChildNodePreviousElementSibling/NonDocumentTypeChildNodePreviousElementSibling.generated.xml' path='docs/NonDocumentTypeChildNodePreviousElementSibling/*'/>
	public Element? PreviousElementSibling { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/NonDocumentTypeChildNodeNextElementSibling/NonDocumentTypeChildNodeNextElementSibling.generated.xml' path='docs/NonDocumentTypeChildNodeNextElementSibling/*'/>
	public Element? NextElementSibling { get { throw new System.NotImplementedException(); } }
}



///<include file='Utils/Docs/ChildNode/ChildNode.generated.xml' path='docs/ChildNode/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface ChildNode
{
	///<include file='Utils/Docs/ChildNodeBefore/ChildNodeBefore.generated.xml' path='docs/ChildNodeBefore/*'/>
	public Undefined Before(params Union6[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ChildNodeAfter/ChildNodeAfter.generated.xml' path='docs/ChildNodeAfter/*'/>
	public Undefined After(params Union7[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ChildNodeReplaceWith/ChildNodeReplaceWith.generated.xml' path='docs/ChildNodeReplaceWith/*'/>
	public Undefined ReplaceWith(params Union8[] nodes) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ChildNodeRemove/ChildNodeRemove.generated.xml' path='docs/ChildNodeRemove/*'/>
	public Undefined Remove() { throw new System.NotImplementedException(); }
}




///<include file='Utils/Docs/Slottable/Slottable.generated.xml' path='docs/Slottable/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface Slottable
{
	///<include file='Utils/Docs/SlottableAssignedSlot/SlottableAssignedSlot.generated.xml' path='docs/SlottableAssignedSlot/*'/>
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

///<include file='Utils/Docs/MutationCallback/MutationCallback.generated.xml' path='docs/MutationCallback/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public struct MutationCallback
{
}

///<include file='Utils/Docs/MutationObserverInit/MutationObserverInit.generated.xml' path='docs/MutationObserverInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MutationObserverInit
{
	///<include file='Utils/Docs/MutationObserverInitChildList/MutationObserverInitChildList.generated.xml' path='docs/MutationObserverInitChildList/*'/>
	public bool ChildList;
	///<include file='Utils/Docs/MutationObserverInitAttributes/MutationObserverInitAttributes.generated.xml' path='docs/MutationObserverInitAttributes/*'/>
	public bool Attributes;
	///<include file='Utils/Docs/MutationObserverInitCharacterData/MutationObserverInitCharacterData.generated.xml' path='docs/MutationObserverInitCharacterData/*'/>
	public bool CharacterData;
	///<include file='Utils/Docs/MutationObserverInitSubtree/MutationObserverInitSubtree.generated.xml' path='docs/MutationObserverInitSubtree/*'/>
	public bool Subtree;
	///<include file='Utils/Docs/MutationObserverInitAttributeOldValue/MutationObserverInitAttributeOldValue.generated.xml' path='docs/MutationObserverInitAttributeOldValue/*'/>
	public bool AttributeOldValue;
	///<include file='Utils/Docs/MutationObserverInitCharacterDataOldValue/MutationObserverInitCharacterDataOldValue.generated.xml' path='docs/MutationObserverInitCharacterDataOldValue/*'/>
	public bool CharacterDataOldValue;
	///<include file='Utils/Docs/MutationObserverInitAttributeFilter/MutationObserverInitAttributeFilter.generated.xml' path='docs/MutationObserverInitAttributeFilter/*'/>
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
	///<include file='Utils/Docs/NodeELEMENT_NODE/NodeELEMENT_NODE.generated.xml' path='docs/NodeELEMENT_NODE/*'/>
	public const ushort ELEMENT_NODE = 1;
	///<include file='Utils/Docs/NodeATTRIBUTE_NODE/NodeATTRIBUTE_NODE.generated.xml' path='docs/NodeATTRIBUTE_NODE/*'/>
	public const ushort ATTRIBUTE_NODE = 2;
	///<include file='Utils/Docs/NodeTEXT_NODE/NodeTEXT_NODE.generated.xml' path='docs/NodeTEXT_NODE/*'/>
	public const ushort TEXT_NODE = 3;
	///<include file='Utils/Docs/NodeCDATA_SECTION_NODE/NodeCDATA_SECTION_NODE.generated.xml' path='docs/NodeCDATA_SECTION_NODE/*'/>
	public const ushort CDATA_SECTION_NODE = 4;
	///<include file='Utils/Docs/NodeENTITY_REFERENCE_NODE/NodeENTITY_REFERENCE_NODE.generated.xml' path='docs/NodeENTITY_REFERENCE_NODE/*'/>
	public const ushort ENTITY_REFERENCE_NODE = 5;
	///<include file='Utils/Docs/NodeENTITY_NODE/NodeENTITY_NODE.generated.xml' path='docs/NodeENTITY_NODE/*'/>
	public const ushort ENTITY_NODE = 6;
	///<include file='Utils/Docs/NodePROCESSING_INSTRUCTION_NODE/NodePROCESSING_INSTRUCTION_NODE.generated.xml' path='docs/NodePROCESSING_INSTRUCTION_NODE/*'/>
	public const ushort PROCESSING_INSTRUCTION_NODE = 7;
	///<include file='Utils/Docs/NodeCOMMENT_NODE/NodeCOMMENT_NODE.generated.xml' path='docs/NodeCOMMENT_NODE/*'/>
	public const ushort COMMENT_NODE = 8;
	///<include file='Utils/Docs/NodeDOCUMENT_NODE/NodeDOCUMENT_NODE.generated.xml' path='docs/NodeDOCUMENT_NODE/*'/>
	public const ushort DOCUMENT_NODE = 9;
	///<include file='Utils/Docs/NodeDOCUMENT_TYPE_NODE/NodeDOCUMENT_TYPE_NODE.generated.xml' path='docs/NodeDOCUMENT_TYPE_NODE/*'/>
	public const ushort DOCUMENT_TYPE_NODE = 10;
	///<include file='Utils/Docs/NodeDOCUMENT_FRAGMENT_NODE/NodeDOCUMENT_FRAGMENT_NODE.generated.xml' path='docs/NodeDOCUMENT_FRAGMENT_NODE/*'/>
	public const ushort DOCUMENT_FRAGMENT_NODE = 11;
	///<include file='Utils/Docs/NodeNOTATION_NODE/NodeNOTATION_NODE.generated.xml' path='docs/NodeNOTATION_NODE/*'/>
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
	///<include file='Utils/Docs/NodeDOCUMENT_POSITION_DISCONNECTED/NodeDOCUMENT_POSITION_DISCONNECTED.generated.xml' path='docs/NodeDOCUMENT_POSITION_DISCONNECTED/*'/>
	public const ushort DOCUMENT_POSITION_DISCONNECTED = 0x01;
	///<include file='Utils/Docs/NodeDOCUMENT_POSITION_PRECEDING/NodeDOCUMENT_POSITION_PRECEDING.generated.xml' path='docs/NodeDOCUMENT_POSITION_PRECEDING/*'/>
	public const ushort DOCUMENT_POSITION_PRECEDING = 0x02;
	///<include file='Utils/Docs/NodeDOCUMENT_POSITION_FOLLOWING/NodeDOCUMENT_POSITION_FOLLOWING.generated.xml' path='docs/NodeDOCUMENT_POSITION_FOLLOWING/*'/>
	public const ushort DOCUMENT_POSITION_FOLLOWING = 0x04;
	///<include file='Utils/Docs/NodeDOCUMENT_POSITION_CONTAINS/NodeDOCUMENT_POSITION_CONTAINS.generated.xml' path='docs/NodeDOCUMENT_POSITION_CONTAINS/*'/>
	public const ushort DOCUMENT_POSITION_CONTAINS = 0x08;
	///<include file='Utils/Docs/NodeDOCUMENT_POSITION_CONTAINED_BY/NodeDOCUMENT_POSITION_CONTAINED_BY.generated.xml' path='docs/NodeDOCUMENT_POSITION_CONTAINED_BY/*'/>
	public const ushort DOCUMENT_POSITION_CONTAINED_BY = 0x10;
	///<include file='Utils/Docs/NodeDOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC/NodeDOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC.generated.xml' path='docs/NodeDOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC/*'/>
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

///<include file='Utils/Docs/GetRootNodeOptions/GetRootNodeOptions.generated.xml' path='docs/GetRootNodeOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GetRootNodeOptions
{
	///<include file='Utils/Docs/GetRootNodeOptionsComposed/GetRootNodeOptionsComposed.generated.xml' path='docs/GetRootNodeOptionsComposed/*'/>
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
	///<include file='Utils/Docs/ShadowRootOnslotchange/ShadowRootOnslotchange.generated.xml' path='docs/ShadowRootOnslotchange/*'/>
	public EventHandler Onslotchange { get; set; }
}

///<include file='Utils/Docs/ShadowRootMode/ShadowRootMode.generated.xml' path='docs/ShadowRootMode/*'/>
public enum ShadowRootMode
{
	Open,
	Closed,
}

///<include file='Utils/Docs/SlotAssignmentMode/SlotAssignmentMode.generated.xml' path='docs/SlotAssignmentMode/*'/>
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
	///<include file='Utils/Docs/ElementWebkitMatchesSelector/ElementWebkitMatchesSelector.generated.xml' path='docs/ElementWebkitMatchesSelector/*'/>
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

///<include file='Utils/Docs/ShadowRootInit/ShadowRootInit.generated.xml' path='docs/ShadowRootInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ShadowRootInit
{
	///<include file='Utils/Docs/ShadowRootInitMode/ShadowRootInitMode.generated.xml' path='docs/ShadowRootInitMode/*'/>
	public required ShadowRootMode Mode;
	///<include file='Utils/Docs/ShadowRootInitDelegatesFocus/ShadowRootInitDelegatesFocus.generated.xml' path='docs/ShadowRootInitDelegatesFocus/*'/>
	public bool DelegatesFocus;
	///<include file='Utils/Docs/ShadowRootInitSlotAssignment/ShadowRootInitSlotAssignment.generated.xml' path='docs/ShadowRootInitSlotAssignment/*'/>
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

///<include file='Utils/Docs/StaticRangeInit/StaticRangeInit.generated.xml' path='docs/StaticRangeInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class StaticRangeInit
{
	///<include file='Utils/Docs/StaticRangeInitStartContainer/StaticRangeInitStartContainer.generated.xml' path='docs/StaticRangeInitStartContainer/*'/>
	public required Node StartContainer;
	///<include file='Utils/Docs/StaticRangeInitStartOffset/StaticRangeInitStartOffset.generated.xml' path='docs/StaticRangeInitStartOffset/*'/>
	public required ulong StartOffset;
	///<include file='Utils/Docs/StaticRangeInitEndContainer/StaticRangeInitEndContainer.generated.xml' path='docs/StaticRangeInitEndContainer/*'/>
	public required Node EndContainer;
	///<include file='Utils/Docs/StaticRangeInitEndOffset/StaticRangeInitEndOffset.generated.xml' path='docs/StaticRangeInitEndOffset/*'/>
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
	///<include file='Utils/Docs/RangeSTART_TO_START/RangeSTART_TO_START.generated.xml' path='docs/RangeSTART_TO_START/*'/>
	public const ushort START_TO_START = 0;
	///<include file='Utils/Docs/RangeSTART_TO_END/RangeSTART_TO_END.generated.xml' path='docs/RangeSTART_TO_END/*'/>
	public const ushort START_TO_END = 1;
	///<include file='Utils/Docs/RangeEND_TO_END/RangeEND_TO_END.generated.xml' path='docs/RangeEND_TO_END/*'/>
	public const ushort END_TO_END = 2;
	///<include file='Utils/Docs/RangeEND_TO_START/RangeEND_TO_START.generated.xml' path='docs/RangeEND_TO_START/*'/>
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

///<include file='Utils/Docs/NodeFilter/NodeFilter.generated.xml' path='docs/NodeFilter/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NodeFilter
{
	///<include file='Utils/Docs/NodeFilterFILTER_ACCEPT/NodeFilterFILTER_ACCEPT.generated.xml' path='docs/NodeFilterFILTER_ACCEPT/*'/>
	public const ushort FILTER_ACCEPT = 1;
	///<include file='Utils/Docs/NodeFilterFILTER_REJECT/NodeFilterFILTER_REJECT.generated.xml' path='docs/NodeFilterFILTER_REJECT/*'/>
	public const ushort FILTER_REJECT = 2;
	///<include file='Utils/Docs/NodeFilterFILTER_SKIP/NodeFilterFILTER_SKIP.generated.xml' path='docs/NodeFilterFILTER_SKIP/*'/>
	public const ushort FILTER_SKIP = 3;
	///<include file='Utils/Docs/NodeFilterSHOW_ALL/NodeFilterSHOW_ALL.generated.xml' path='docs/NodeFilterSHOW_ALL/*'/>
	public const ulong SHOW_ALL = 0xFFFFFFFF;
	///<include file='Utils/Docs/NodeFilterSHOW_ELEMENT/NodeFilterSHOW_ELEMENT.generated.xml' path='docs/NodeFilterSHOW_ELEMENT/*'/>
	public const ulong SHOW_ELEMENT = 0x1;
	///<include file='Utils/Docs/NodeFilterSHOW_ATTRIBUTE/NodeFilterSHOW_ATTRIBUTE.generated.xml' path='docs/NodeFilterSHOW_ATTRIBUTE/*'/>
	public const ulong SHOW_ATTRIBUTE = 0x2;
	///<include file='Utils/Docs/NodeFilterSHOW_TEXT/NodeFilterSHOW_TEXT.generated.xml' path='docs/NodeFilterSHOW_TEXT/*'/>
	public const ulong SHOW_TEXT = 0x4;
	///<include file='Utils/Docs/NodeFilterSHOW_CDATA_SECTION/NodeFilterSHOW_CDATA_SECTION.generated.xml' path='docs/NodeFilterSHOW_CDATA_SECTION/*'/>
	public const ulong SHOW_CDATA_SECTION = 0x8;
	///<include file='Utils/Docs/NodeFilterSHOW_ENTITY_REFERENCE/NodeFilterSHOW_ENTITY_REFERENCE.generated.xml' path='docs/NodeFilterSHOW_ENTITY_REFERENCE/*'/>
	public const ulong SHOW_ENTITY_REFERENCE = 0x10;
	///<include file='Utils/Docs/NodeFilterSHOW_ENTITY/NodeFilterSHOW_ENTITY.generated.xml' path='docs/NodeFilterSHOW_ENTITY/*'/>
	public const ulong SHOW_ENTITY = 0x20;
	///<include file='Utils/Docs/NodeFilterSHOW_PROCESSING_INSTRUCTION/NodeFilterSHOW_PROCESSING_INSTRUCTION.generated.xml' path='docs/NodeFilterSHOW_PROCESSING_INSTRUCTION/*'/>
	public const ulong SHOW_PROCESSING_INSTRUCTION = 0x40;
	///<include file='Utils/Docs/NodeFilterSHOW_COMMENT/NodeFilterSHOW_COMMENT.generated.xml' path='docs/NodeFilterSHOW_COMMENT/*'/>
	public const ulong SHOW_COMMENT = 0x80;
	///<include file='Utils/Docs/NodeFilterSHOW_DOCUMENT/NodeFilterSHOW_DOCUMENT.generated.xml' path='docs/NodeFilterSHOW_DOCUMENT/*'/>
	public const ulong SHOW_DOCUMENT = 0x100;
	///<include file='Utils/Docs/NodeFilterSHOW_DOCUMENT_TYPE/NodeFilterSHOW_DOCUMENT_TYPE.generated.xml' path='docs/NodeFilterSHOW_DOCUMENT_TYPE/*'/>
	public const ulong SHOW_DOCUMENT_TYPE = 0x200;
	///<include file='Utils/Docs/NodeFilterSHOW_DOCUMENT_FRAGMENT/NodeFilterSHOW_DOCUMENT_FRAGMENT.generated.xml' path='docs/NodeFilterSHOW_DOCUMENT_FRAGMENT/*'/>
	public const ulong SHOW_DOCUMENT_FRAGMENT = 0x400;
	///<include file='Utils/Docs/NodeFilterSHOW_NOTATION/NodeFilterSHOW_NOTATION.generated.xml' path='docs/NodeFilterSHOW_NOTATION/*'/>
	public const ulong SHOW_NOTATION = 0x800;
	///<include file='Utils/Docs/NodeFilterAcceptNode/NodeFilterAcceptNode.generated.xml' path='docs/NodeFilterAcceptNode/*'/>
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
	///<include file='Utils/Docs/XPathResultANY_TYPE/XPathResultANY_TYPE.generated.xml' path='docs/XPathResultANY_TYPE/*'/>
	public const ushort ANY_TYPE = 0;
	///<include file='Utils/Docs/XPathResultNUMBER_TYPE/XPathResultNUMBER_TYPE.generated.xml' path='docs/XPathResultNUMBER_TYPE/*'/>
	public const ushort NUMBER_TYPE = 1;
	///<include file='Utils/Docs/XPathResultSTRING_TYPE/XPathResultSTRING_TYPE.generated.xml' path='docs/XPathResultSTRING_TYPE/*'/>
	public const ushort STRING_TYPE = 2;
	///<include file='Utils/Docs/XPathResultBOOLEAN_TYPE/XPathResultBOOLEAN_TYPE.generated.xml' path='docs/XPathResultBOOLEAN_TYPE/*'/>
	public const ushort BOOLEAN_TYPE = 3;
	///<include file='Utils/Docs/XPathResultUNORDERED_NODE_ITERATOR_TYPE/XPathResultUNORDERED_NODE_ITERATOR_TYPE.generated.xml' path='docs/XPathResultUNORDERED_NODE_ITERATOR_TYPE/*'/>
	public const ushort UNORDERED_NODE_ITERATOR_TYPE = 4;
	///<include file='Utils/Docs/XPathResultORDERED_NODE_ITERATOR_TYPE/XPathResultORDERED_NODE_ITERATOR_TYPE.generated.xml' path='docs/XPathResultORDERED_NODE_ITERATOR_TYPE/*'/>
	public const ushort ORDERED_NODE_ITERATOR_TYPE = 5;
	///<include file='Utils/Docs/XPathResultUNORDERED_NODE_SNAPSHOT_TYPE/XPathResultUNORDERED_NODE_SNAPSHOT_TYPE.generated.xml' path='docs/XPathResultUNORDERED_NODE_SNAPSHOT_TYPE/*'/>
	public const ushort UNORDERED_NODE_SNAPSHOT_TYPE = 6;
	///<include file='Utils/Docs/XPathResultORDERED_NODE_SNAPSHOT_TYPE/XPathResultORDERED_NODE_SNAPSHOT_TYPE.generated.xml' path='docs/XPathResultORDERED_NODE_SNAPSHOT_TYPE/*'/>
	public const ushort ORDERED_NODE_SNAPSHOT_TYPE = 7;
	///<include file='Utils/Docs/XPathResultANY_UNORDERED_NODE_TYPE/XPathResultANY_UNORDERED_NODE_TYPE.generated.xml' path='docs/XPathResultANY_UNORDERED_NODE_TYPE/*'/>
	public const ushort ANY_UNORDERED_NODE_TYPE = 8;
	///<include file='Utils/Docs/XPathResultFIRST_ORDERED_NODE_TYPE/XPathResultFIRST_ORDERED_NODE_TYPE.generated.xml' path='docs/XPathResultFIRST_ORDERED_NODE_TYPE/*'/>
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

///<include file='Utils/Docs/XPathEvaluatorBase/XPathEvaluatorBase.generated.xml' path='docs/XPathEvaluatorBase/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface XPathEvaluatorBase
{
	///<include file='Utils/Docs/XPathEvaluatorBaseCreateExpression/XPathEvaluatorBaseCreateExpression.generated.xml' path='docs/XPathEvaluatorBaseCreateExpression/*'/>
	public XPathExpression CreateExpression(string expression, XPathNSResolver? resolver) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XPathEvaluatorBaseCreateNSResolver/XPathEvaluatorBaseCreateNSResolver.generated.xml' path='docs/XPathEvaluatorBaseCreateNSResolver/*'/>
	public XPathNSResolver CreateNSResolver(Node nodeResolver) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/XPathEvaluatorBaseEvaluate/XPathEvaluatorBaseEvaluate.generated.xml' path='docs/XPathEvaluatorBaseEvaluate/*'/>
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

///<include file='Utils/Docs/TextDecoderCommon/TextDecoderCommon.generated.xml' path='docs/TextDecoderCommon/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface TextDecoderCommon
{
	///<include file='Utils/Docs/TextDecoderCommonEncoding/TextDecoderCommonEncoding.generated.xml' path='docs/TextDecoderCommonEncoding/*'/>
	public string Encoding { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/TextDecoderCommonFatal/TextDecoderCommonFatal.generated.xml' path='docs/TextDecoderCommonFatal/*'/>
	public bool Fatal { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/TextDecoderCommonIgnoreBOM/TextDecoderCommonIgnoreBOM.generated.xml' path='docs/TextDecoderCommonIgnoreBOM/*'/>
	public bool IgnoreBOM { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/TextDecoderOptions/TextDecoderOptions.generated.xml' path='docs/TextDecoderOptions/*'/>
[To(ToAttribute.Default)]
public partial class TextDecoderOptions
{
	///<include file='Utils/Docs/TextDecoderOptionsFatal/TextDecoderOptionsFatal.generated.xml' path='docs/TextDecoderOptionsFatal/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Fatal;
	///<include file='Utils/Docs/TextDecoderOptionsIgnoreBOM/TextDecoderOptionsIgnoreBOM.generated.xml' path='docs/TextDecoderOptionsIgnoreBOM/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool IgnoreBOM;
}

///<include file='Utils/Docs/TextDecodeOptions/TextDecodeOptions.generated.xml' path='docs/TextDecodeOptions/*'/>
[To(ToAttribute.Default)]
public partial class TextDecodeOptions
{
	///<include file='Utils/Docs/TextDecodeOptionsStream/TextDecodeOptionsStream.generated.xml' path='docs/TextDecodeOptionsStream/*'/>
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


///<include file='Utils/Docs/TextEncoderCommon/TextEncoderCommon.generated.xml' path='docs/TextEncoderCommon/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface TextEncoderCommon
{
	///<include file='Utils/Docs/TextEncoderCommonEncoding/TextEncoderCommonEncoding.generated.xml' path='docs/TextEncoderCommonEncoding/*'/>
	public string Encoding { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/TextEncoderEncodeIntoResult/TextEncoderEncodeIntoResult.generated.xml' path='docs/TextEncoderEncodeIntoResult/*'/>
[To(ToAttribute.Default)]
public partial class TextEncoderEncodeIntoResult
{
	///<include file='Utils/Docs/TextEncoderEncodeIntoResultRead/TextEncoderEncodeIntoResultRead.generated.xml' path='docs/TextEncoderEncodeIntoResultRead/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Read;
	///<include file='Utils/Docs/TextEncoderEncodeIntoResultWritten/TextEncoderEncodeIntoResultWritten.generated.xml' path='docs/TextEncoderEncodeIntoResultWritten/*'/>
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



///<include file='Utils/Docs/Body/Body.generated.xml' path='docs/Body/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface Body
{
	///<include file='Utils/Docs/BodyBody/BodyBody.generated.xml' path='docs/BodyBody/*'/>
	public Unsupported /*ReadableStream*/? Body { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/BodyBodyUsed/BodyBodyUsed.generated.xml' path='docs/BodyBodyUsed/*'/>
	public bool BodyUsed { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/BodyArrayBuffer/BodyArrayBuffer.generated.xml' path='docs/BodyArrayBuffer/*'/>
	public Task<byte[]> ArrayBuffer() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BodyBlob/BodyBlob.generated.xml' path='docs/BodyBlob/*'/>
	public Task<Unsupported /*Blob*/> Blob() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BodyFormData/BodyFormData.generated.xml' path='docs/BodyFormData/*'/>
	public Task<FormData> FormData() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BodyJson/BodyJson.generated.xml' path='docs/BodyJson/*'/>
	public Task<dynamic> Json() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/BodyText/BodyText.generated.xml' path='docs/BodyText/*'/>
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
	///<include file='Utils/Docs/RequestKeepalive/RequestKeepalive.generated.xml' path='docs/RequestKeepalive/*'/>
	public bool Keepalive { get; }
	///<include file='Utils/Docs/RequestIsReloadNavigation/RequestIsReloadNavigation.generated.xml' path='docs/RequestIsReloadNavigation/*'/>
	public bool IsReloadNavigation { get; }
	///<include file='Utils/Docs/RequestIsHistoryNavigation/RequestIsHistoryNavigation.generated.xml' path='docs/RequestIsHistoryNavigation/*'/>
	public bool IsHistoryNavigation { get; }
	///<include file='Utils/Docs/RequestSignal/RequestSignal.generated.xml' path='docs/RequestSignal/*'/>
	public AbortSignal Signal { get; }
	///<include file='Utils/Docs/RequestClone/RequestClone.generated.xml' path='docs/RequestClone/*'/>
	public Request Clone() { throw new System.NotImplementedException(); }
}


///<include file='Utils/Docs/RequestInit/RequestInit.generated.xml' path='docs/RequestInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class RequestInit
{
	///<include file='Utils/Docs/RequestInitMethod/RequestInitMethod.generated.xml' path='docs/RequestInitMethod/*'/>
	public string Method;
	///<include file='Utils/Docs/RequestInitHeaders/RequestInitHeaders.generated.xml' path='docs/RequestInitHeaders/*'/>
	public HeadersInit Headers;
	///<include file='Utils/Docs/RequestInitBody/RequestInitBody.generated.xml' path='docs/RequestInitBody/*'/>
	public BodyInit? Body;
	///<include file='Utils/Docs/RequestInitReferrer/RequestInitReferrer.generated.xml' path='docs/RequestInitReferrer/*'/>
	public string Referrer;
	///<include file='Utils/Docs/RequestInitReferrerPolicy/RequestInitReferrerPolicy.generated.xml' path='docs/RequestInitReferrerPolicy/*'/>
	public Unsupported /*ReferrerPolicy*/ ReferrerPolicy;
	///<include file='Utils/Docs/RequestInitMode/RequestInitMode.generated.xml' path='docs/RequestInitMode/*'/>
	public RequestMode Mode;
	///<include file='Utils/Docs/RequestInitCredentials/RequestInitCredentials.generated.xml' path='docs/RequestInitCredentials/*'/>
	public RequestCredentials Credentials;
	///<include file='Utils/Docs/RequestInitCache/RequestInitCache.generated.xml' path='docs/RequestInitCache/*'/>
	public RequestCache Cache;
	///<include file='Utils/Docs/RequestInitRedirect/RequestInitRedirect.generated.xml' path='docs/RequestInitRedirect/*'/>
	public RequestRedirect Redirect;
	///<include file='Utils/Docs/RequestInitIntegrity/RequestInitIntegrity.generated.xml' path='docs/RequestInitIntegrity/*'/>
	public string Integrity;
	///<include file='Utils/Docs/RequestInitKeepalive/RequestInitKeepalive.generated.xml' path='docs/RequestInitKeepalive/*'/>
	public bool Keepalive;
	///<include file='Utils/Docs/RequestInitSignal/RequestInitSignal.generated.xml' path='docs/RequestInitSignal/*'/>
	public AbortSignal? Signal;
	///<include file='Utils/Docs/RequestInitWindow/RequestInitWindow.generated.xml' path='docs/RequestInitWindow/*'/>
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
	///<include file='Utils/Docs/ResponseError/ResponseError.generated.xml' path='docs/ResponseError/*'/>
	public static Response Error() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ResponseRedirect/ResponseRedirect.generated.xml' path='docs/ResponseRedirect/*'/>
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


///<include file='Utils/Docs/ResponseInit/ResponseInit.generated.xml' path='docs/ResponseInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ResponseInit
{
	///<include file='Utils/Docs/ResponseInitStatus/ResponseInitStatus.generated.xml' path='docs/ResponseInitStatus/*'/>
	public ushort Status;
	///<include file='Utils/Docs/ResponseInitStatusText/ResponseInitStatusText.generated.xml' path='docs/ResponseInitStatusText/*'/>
	public string StatusText;
	///<include file='Utils/Docs/ResponseInitHeaders/ResponseInitHeaders.generated.xml' path='docs/ResponseInitHeaders/*'/>
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

///<include file='Utils/Docs/WindowOrWorkerGlobalScope/WindowOrWorkerGlobalScope.generated.xml' path='docs/WindowOrWorkerGlobalScope/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface WindowOrWorkerGlobalScope
{
	///<include file='Utils/Docs/WindowOrWorkerGlobalScopeFetch/WindowOrWorkerGlobalScopeFetch.generated.xml' path='docs/WindowOrWorkerGlobalScopeFetch/*'/>
	public Task<Response> Fetch(RequestInfo input, RequestInit init) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/FullscreenNavigationUI/FullscreenNavigationUI.generated.xml' path='docs/FullscreenNavigationUI/*'/>
public enum FullscreenNavigationUI
{
	Auto,
	Show,
	Hide,
}

///<include file='Utils/Docs/FullscreenOptions/FullscreenOptions.generated.xml' path='docs/FullscreenOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FullscreenOptions
{
	///<include file='Utils/Docs/FullscreenOptionsNavigationUI/FullscreenOptionsNavigationUI.generated.xml' path='docs/FullscreenOptionsNavigationUI/*'/>
	public FullscreenNavigationUI NavigationUI;
}

///<include file='Utils/Docs/Element/Element.generated.xml' path='docs/Element/*'/>
public partial class Element
{
	///<include file='Utils/Docs/ElementRequestFullscreen/ElementRequestFullscreen.generated.xml' path='docs/ElementRequestFullscreen/*'/>
	public Task<Undefined> RequestFullscreen(FullscreenOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ElementOnfullscreenchange/ElementOnfullscreenchange.generated.xml' path='docs/ElementOnfullscreenchange/*'/>
	public EventHandler Onfullscreenchange { get; set; }
	///<include file='Utils/Docs/ElementOnfullscreenerror/ElementOnfullscreenerror.generated.xml' path='docs/ElementOnfullscreenerror/*'/>
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
	///<include file='Utils/Docs/DocumentOnfullscreenchange/DocumentOnfullscreenchange.generated.xml' path='docs/DocumentOnfullscreenchange/*'/>
	public EventHandler Onfullscreenchange { get; set; }
	///<include file='Utils/Docs/DocumentOnfullscreenerror/DocumentOnfullscreenerror.generated.xml' path='docs/DocumentOnfullscreenerror/*'/>
	public EventHandler Onfullscreenerror { get; set; }
}

///<include file='Utils/Docs/DocumentOrShadowRoot/DocumentOrShadowRoot.generated.xml' path='docs/DocumentOrShadowRoot/*'/>
public partial interface DocumentOrShadowRoot
{
	///<include file='Utils/Docs/DocumentOrShadowRootFullscreenElement/DocumentOrShadowRootFullscreenElement.generated.xml' path='docs/DocumentOrShadowRootFullscreenElement/*'/>
	public Element? FullscreenElement { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/HTMLAllCollection/HTMLAllCollection.generated.xml' path='docs/HTMLAllCollection/*'/>
[To(ToAttribute.Default)]
public partial class HTMLAllCollection
{
	///<include file='Utils/Docs/HTMLAllCollectionLength/HTMLAllCollectionLength.generated.xml' path='docs/HTMLAllCollectionLength/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Length { get; }
	
	
	///<include file='Utils/Docs/HTMLAllCollectionItem/HTMLAllCollectionItem.generated.xml' path='docs/HTMLAllCollectionItem/*'/>
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
	///<include file='Utils/Docs/HTMLOptionsCollectionLength/HTMLOptionsCollectionLength.generated.xml' path='docs/HTMLOptionsCollectionLength/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Length { get; set; }
	
	///<include file='Utils/Docs/HTMLOptionsCollectionAdd/HTMLOptionsCollectionAdd.generated.xml' path='docs/HTMLOptionsCollectionAdd/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Add(Union16 element, Union17? before) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLOptionsCollectionRemove/HTMLOptionsCollectionRemove.generated.xml' path='docs/HTMLOptionsCollectionRemove/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Remove(long index) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLOptionsCollectionSelectedIndex/HTMLOptionsCollectionSelectedIndex.generated.xml' path='docs/HTMLOptionsCollectionSelectedIndex/*'/>
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
	///<include file='Utils/Docs/DocumentQueryCommandIndeterm/DocumentQueryCommandIndeterm.generated.xml' path='docs/DocumentQueryCommandIndeterm/*'/>
	public bool QueryCommandIndeterm(string commandId) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentQueryCommandState/DocumentQueryCommandState.generated.xml' path='docs/DocumentQueryCommandState/*'/>
	public bool QueryCommandState(string commandId) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentQueryCommandSupported/DocumentQueryCommandSupported.generated.xml' path='docs/DocumentQueryCommandSupported/*'/>
	public bool QueryCommandSupported(string commandId) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentQueryCommandValue/DocumentQueryCommandValue.generated.xml' path='docs/DocumentQueryCommandValue/*'/>
	public string QueryCommandValue(string commandId) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentHidden/DocumentHidden.generated.xml' path='docs/DocumentHidden/*'/>
	public bool Hidden { get; }
	///<include file='Utils/Docs/DocumentVisibilityState/DocumentVisibilityState.generated.xml' path='docs/DocumentVisibilityState/*'/>
	public DocumentVisibilityState VisibilityState { get; }
	///<include file='Utils/Docs/DocumentOnreadystatechange/DocumentOnreadystatechange.generated.xml' path='docs/DocumentOnreadystatechange/*'/>
	public EventHandler Onreadystatechange { get; set; }
	///<include file='Utils/Docs/DocumentOnvisibilitychange/DocumentOnvisibilitychange.generated.xml' path='docs/DocumentOnvisibilitychange/*'/>
	public EventHandler Onvisibilitychange { get; set; }
}



///<include file='Utils/Docs/DocumentOrShadowRoot/DocumentOrShadowRoot.generated.xml' path='docs/DocumentOrShadowRoot/*'/>
public partial interface DocumentOrShadowRoot
{
	///<include file='Utils/Docs/DocumentOrShadowRootActiveElement/DocumentOrShadowRootActiveElement.generated.xml' path='docs/DocumentOrShadowRootActiveElement/*'/>
	public Element? ActiveElement { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/HTMLElement/HTMLElement.generated.xml' path='docs/HTMLElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLElement : Element, GlobalEventHandlers, DocumentAndElementEventHandlers, ElementContentEditable, HTMLOrSVGElement
{
	///<include file='Utils/Docs/HTMLElementHTMLElement/HTMLElementHTMLElement.generated.xml' path='docs/HTMLElementHTMLElement/*'/>
	public HTMLElement() { }
	///<include file='Utils/Docs/HTMLElementTitle/HTMLElementTitle.generated.xml' path='docs/HTMLElementTitle/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Title { get; set; }
	///<include file='Utils/Docs/HTMLElementLang/HTMLElementLang.generated.xml' path='docs/HTMLElementLang/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Lang { get; set; }
	///<include file='Utils/Docs/HTMLElementTranslate/HTMLElementTranslate.generated.xml' path='docs/HTMLElementTranslate/*'/>
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
	///<include file='Utils/Docs/HTMLElementDraggable/HTMLElementDraggable.generated.xml' path='docs/HTMLElementDraggable/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Draggable { get; set; }
	///<include file='Utils/Docs/HTMLElementSpellcheck/HTMLElementSpellcheck.generated.xml' path='docs/HTMLElementSpellcheck/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Spellcheck { get; set; }
	///<include file='Utils/Docs/HTMLElementAutocapitalize/HTMLElementAutocapitalize.generated.xml' path='docs/HTMLElementAutocapitalize/*'/>
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

///<include file='Utils/Docs/HTMLOrSVGElement/HTMLOrSVGElement.generated.xml' path='docs/HTMLOrSVGElement/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface HTMLOrSVGElement
{
	///<include file='Utils/Docs/HTMLOrSVGElementDataset/HTMLOrSVGElementDataset.generated.xml' path='docs/HTMLOrSVGElementDataset/*'/>
	public string Dataset { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/HTMLOrSVGElementNonce/HTMLOrSVGElementNonce.generated.xml' path='docs/HTMLOrSVGElementNonce/*'/>
	public string Nonce { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/HTMLOrSVGElementAutofocus/HTMLOrSVGElementAutofocus.generated.xml' path='docs/HTMLOrSVGElementAutofocus/*'/>
	public bool Autofocus { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/HTMLOrSVGElementTabIndex/HTMLOrSVGElementTabIndex.generated.xml' path='docs/HTMLOrSVGElementTabIndex/*'/>
	public long TabIndex { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/HTMLOrSVGElementFocus/HTMLOrSVGElementFocus.generated.xml' path='docs/HTMLOrSVGElementFocus/*'/>
	public Undefined Focus(FocusOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLOrSVGElementBlur/HTMLOrSVGElementBlur.generated.xml' path='docs/HTMLOrSVGElementBlur/*'/>
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
	///<include file='Utils/Docs/HTMLHtmlElementHTMLHtmlElement/HTMLHtmlElementHTMLHtmlElement.generated.xml' path='docs/HTMLHtmlElementHTMLHtmlElement/*'/>
	public HTMLHtmlElement() { }
}

///<include file='Utils/Docs/HTMLHeadElement/HTMLHeadElement.generated.xml' path='docs/HTMLHeadElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLHeadElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLHeadElementHTMLHeadElement/HTMLHeadElementHTMLHeadElement.generated.xml' path='docs/HTMLHeadElementHTMLHeadElement/*'/>
	public HTMLHeadElement() { }
}

///<include file='Utils/Docs/HTMLTitleElement/HTMLTitleElement.generated.xml' path='docs/HTMLTitleElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTitleElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLTitleElementHTMLTitleElement/HTMLTitleElementHTMLTitleElement.generated.xml' path='docs/HTMLTitleElementHTMLTitleElement/*'/>
	public HTMLTitleElement() { }
	///<include file='Utils/Docs/HTMLTitleElementText/HTMLTitleElementText.generated.xml' path='docs/HTMLTitleElementText/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Text { get; set; }
}

///<include file='Utils/Docs/HTMLBaseElement/HTMLBaseElement.generated.xml' path='docs/HTMLBaseElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLBaseElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLBaseElementHTMLBaseElement/HTMLBaseElementHTMLBaseElement.generated.xml' path='docs/HTMLBaseElementHTMLBaseElement/*'/>
	public HTMLBaseElement() { }
	///<include file='Utils/Docs/HTMLBaseElementHref/HTMLBaseElementHref.generated.xml' path='docs/HTMLBaseElementHref/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Href { get; set; }
	///<include file='Utils/Docs/HTMLBaseElementTarget/HTMLBaseElementTarget.generated.xml' path='docs/HTMLBaseElementTarget/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Target { get; set; }
}

///<include file='Utils/Docs/HTMLLinkElement/HTMLLinkElement.generated.xml' path='docs/HTMLLinkElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLLinkElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLLinkElementHTMLLinkElement/HTMLLinkElementHTMLLinkElement.generated.xml' path='docs/HTMLLinkElementHTMLLinkElement/*'/>
	public HTMLLinkElement() { }
	///<include file='Utils/Docs/HTMLLinkElementHref/HTMLLinkElementHref.generated.xml' path='docs/HTMLLinkElementHref/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Href { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementCrossOrigin/HTMLLinkElementCrossOrigin.generated.xml' path='docs/HTMLLinkElementCrossOrigin/*'/>
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
	///<include file='Utils/Docs/HTMLLinkElementMedia/HTMLLinkElementMedia.generated.xml' path='docs/HTMLLinkElementMedia/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Media { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementIntegrity/HTMLLinkElementIntegrity.generated.xml' path='docs/HTMLLinkElementIntegrity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Integrity { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementHreflang/HTMLLinkElementHreflang.generated.xml' path='docs/HTMLLinkElementHreflang/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Hreflang { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementType/HTMLLinkElementType.generated.xml' path='docs/HTMLLinkElementType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementSizes/HTMLLinkElementSizes.generated.xml' path='docs/HTMLLinkElementSizes/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList Sizes { get; }
	///<include file='Utils/Docs/HTMLLinkElementImageSrcset/HTMLLinkElementImageSrcset.generated.xml' path='docs/HTMLLinkElementImageSrcset/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ImageSrcset { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementImageSizes/HTMLLinkElementImageSizes.generated.xml' path='docs/HTMLLinkElementImageSizes/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ImageSizes { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementReferrerPolicy/HTMLLinkElementReferrerPolicy.generated.xml' path='docs/HTMLLinkElementReferrerPolicy/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ReferrerPolicy { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementBlocking/HTMLLinkElementBlocking.generated.xml' path='docs/HTMLLinkElementBlocking/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList Blocking { get; }
	///<include file='Utils/Docs/HTMLLinkElementDisabled/HTMLLinkElementDisabled.generated.xml' path='docs/HTMLLinkElementDisabled/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
}


///<include file='Utils/Docs/HTMLMetaElement/HTMLMetaElement.generated.xml' path='docs/HTMLMetaElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLMetaElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLMetaElementHTMLMetaElement/HTMLMetaElementHTMLMetaElement.generated.xml' path='docs/HTMLMetaElementHTMLMetaElement/*'/>
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
	///<include file='Utils/Docs/HTMLStyleElementHTMLStyleElement/HTMLStyleElementHTMLStyleElement.generated.xml' path='docs/HTMLStyleElementHTMLStyleElement/*'/>
	public HTMLStyleElement() { }
	///<include file='Utils/Docs/HTMLStyleElementDisabled/HTMLStyleElementDisabled.generated.xml' path='docs/HTMLStyleElementDisabled/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	///<include file='Utils/Docs/HTMLStyleElementMedia/HTMLStyleElementMedia.generated.xml' path='docs/HTMLStyleElementMedia/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Media { get; set; }
	///<include file='Utils/Docs/HTMLStyleElementBlocking/HTMLStyleElementBlocking.generated.xml' path='docs/HTMLStyleElementBlocking/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList Blocking { get; }
}


///<include file='Utils/Docs/HTMLBodyElement/HTMLBodyElement.generated.xml' path='docs/HTMLBodyElement/*'/>
public partial class HTMLBodyElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLBodyElementHTMLBodyElement/HTMLBodyElementHTMLBodyElement.generated.xml' path='docs/HTMLBodyElementHTMLBodyElement/*'/>
	public HTMLBodyElement() { }
}


///<include file='Utils/Docs/HTMLHeadingElement/HTMLHeadingElement.generated.xml' path='docs/HTMLHeadingElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLHeadingElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLHeadingElementHTMLHeadingElement/HTMLHeadingElementHTMLHeadingElement.generated.xml' path='docs/HTMLHeadingElementHTMLHeadingElement/*'/>
	public HTMLHeadingElement() { }
}

///<include file='Utils/Docs/HTMLParagraphElement/HTMLParagraphElement.generated.xml' path='docs/HTMLParagraphElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLParagraphElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLParagraphElementHTMLParagraphElement/HTMLParagraphElementHTMLParagraphElement.generated.xml' path='docs/HTMLParagraphElementHTMLParagraphElement/*'/>
	public HTMLParagraphElement() { }
}

///<include file='Utils/Docs/HTMLHRElement/HTMLHRElement.generated.xml' path='docs/HTMLHRElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLHRElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLHRElementHTMLHRElement/HTMLHRElementHTMLHRElement.generated.xml' path='docs/HTMLHRElementHTMLHRElement/*'/>
	public HTMLHRElement() { }
}

///<include file='Utils/Docs/HTMLPreElement/HTMLPreElement.generated.xml' path='docs/HTMLPreElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLPreElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLPreElementHTMLPreElement/HTMLPreElementHTMLPreElement.generated.xml' path='docs/HTMLPreElementHTMLPreElement/*'/>
	public HTMLPreElement() { }
}

///<include file='Utils/Docs/HTMLQuoteElement/HTMLQuoteElement.generated.xml' path='docs/HTMLQuoteElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLQuoteElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLQuoteElementHTMLQuoteElement/HTMLQuoteElementHTMLQuoteElement.generated.xml' path='docs/HTMLQuoteElementHTMLQuoteElement/*'/>
	public HTMLQuoteElement() { }
	///<include file='Utils/Docs/HTMLQuoteElementCite/HTMLQuoteElementCite.generated.xml' path='docs/HTMLQuoteElementCite/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Cite { get; set; }
}

///<include file='Utils/Docs/HTMLOListElement/HTMLOListElement.generated.xml' path='docs/HTMLOListElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLOListElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLOListElementHTMLOListElement/HTMLOListElementHTMLOListElement.generated.xml' path='docs/HTMLOListElementHTMLOListElement/*'/>
	public HTMLOListElement() { }
	///<include file='Utils/Docs/HTMLOListElementReversed/HTMLOListElementReversed.generated.xml' path='docs/HTMLOListElementReversed/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Reversed { get; set; }
	///<include file='Utils/Docs/HTMLOListElementStart/HTMLOListElementStart.generated.xml' path='docs/HTMLOListElementStart/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public long Start { get; set; }
	///<include file='Utils/Docs/HTMLOListElementType/HTMLOListElementType.generated.xml' path='docs/HTMLOListElementType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
}

///<include file='Utils/Docs/HTMLUListElement/HTMLUListElement.generated.xml' path='docs/HTMLUListElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLUListElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLUListElementHTMLUListElement/HTMLUListElementHTMLUListElement.generated.xml' path='docs/HTMLUListElementHTMLUListElement/*'/>
	public HTMLUListElement() { }
}

///<include file='Utils/Docs/HTMLMenuElement/HTMLMenuElement.generated.xml' path='docs/HTMLMenuElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLMenuElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLMenuElementHTMLMenuElement/HTMLMenuElementHTMLMenuElement.generated.xml' path='docs/HTMLMenuElementHTMLMenuElement/*'/>
	public HTMLMenuElement() { }
}

///<include file='Utils/Docs/HTMLLIElement/HTMLLIElement.generated.xml' path='docs/HTMLLIElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLLIElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLLIElementHTMLLIElement/HTMLLIElementHTMLLIElement.generated.xml' path='docs/HTMLLIElementHTMLLIElement/*'/>
	public HTMLLIElement() { }
	///<include file='Utils/Docs/HTMLLIElementValue/HTMLLIElementValue.generated.xml' path='docs/HTMLLIElementValue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public long Value { get; set; }
}

///<include file='Utils/Docs/HTMLDListElement/HTMLDListElement.generated.xml' path='docs/HTMLDListElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLDListElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLDListElementHTMLDListElement/HTMLDListElementHTMLDListElement.generated.xml' path='docs/HTMLDListElementHTMLDListElement/*'/>
	public HTMLDListElement() { }
}

///<include file='Utils/Docs/HTMLDivElement/HTMLDivElement.generated.xml' path='docs/HTMLDivElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLDivElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLDivElementHTMLDivElement/HTMLDivElementHTMLDivElement.generated.xml' path='docs/HTMLDivElementHTMLDivElement/*'/>
	public HTMLDivElement() { }
}

///<include file='Utils/Docs/HTMLAnchorElement/HTMLAnchorElement.generated.xml' path='docs/HTMLAnchorElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLAnchorElement : HTMLElement, HTMLHyperlinkElementUtils
{
	///<include file='Utils/Docs/HTMLAnchorElementHTMLAnchorElement/HTMLAnchorElementHTMLAnchorElement.generated.xml' path='docs/HTMLAnchorElementHTMLAnchorElement/*'/>
	public HTMLAnchorElement() { }
	///<include file='Utils/Docs/HTMLAnchorElementTarget/HTMLAnchorElementTarget.generated.xml' path='docs/HTMLAnchorElementTarget/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Target { get; set; }
	///<include file='Utils/Docs/HTMLAnchorElementDownload/HTMLAnchorElementDownload.generated.xml' path='docs/HTMLAnchorElementDownload/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Download { get; set; }
	///<include file='Utils/Docs/HTMLAnchorElementPing/HTMLAnchorElementPing.generated.xml' path='docs/HTMLAnchorElementPing/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Ping { get; set; }
	///<include file='Utils/Docs/HTMLAnchorElementRel/HTMLAnchorElementRel.generated.xml' path='docs/HTMLAnchorElementRel/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Rel { get; set; }
	///<include file='Utils/Docs/HTMLAnchorElementRelList/HTMLAnchorElementRelList.generated.xml' path='docs/HTMLAnchorElementRelList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList RelList { get; }
	///<include file='Utils/Docs/HTMLAnchorElementHreflang/HTMLAnchorElementHreflang.generated.xml' path='docs/HTMLAnchorElementHreflang/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Hreflang { get; set; }
	///<include file='Utils/Docs/HTMLAnchorElementType/HTMLAnchorElementType.generated.xml' path='docs/HTMLAnchorElementType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
	///<include file='Utils/Docs/HTMLAnchorElementText/HTMLAnchorElementText.generated.xml' path='docs/HTMLAnchorElementText/*'/>
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
	///<include file='Utils/Docs/HTMLDataElementHTMLDataElement/HTMLDataElementHTMLDataElement.generated.xml' path='docs/HTMLDataElementHTMLDataElement/*'/>
	public HTMLDataElement() { }
	///<include file='Utils/Docs/HTMLDataElementValue/HTMLDataElementValue.generated.xml' path='docs/HTMLDataElementValue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
}

///<include file='Utils/Docs/HTMLTimeElement/HTMLTimeElement.generated.xml' path='docs/HTMLTimeElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTimeElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLTimeElementHTMLTimeElement/HTMLTimeElementHTMLTimeElement.generated.xml' path='docs/HTMLTimeElementHTMLTimeElement/*'/>
	public HTMLTimeElement() { }
	///<include file='Utils/Docs/HTMLTimeElementDateTime/HTMLTimeElementDateTime.generated.xml' path='docs/HTMLTimeElementDateTime/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string DateTime { get; set; }
}

///<include file='Utils/Docs/HTMLSpanElement/HTMLSpanElement.generated.xml' path='docs/HTMLSpanElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLSpanElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLSpanElementHTMLSpanElement/HTMLSpanElementHTMLSpanElement.generated.xml' path='docs/HTMLSpanElementHTMLSpanElement/*'/>
	public HTMLSpanElement() { }
}

///<include file='Utils/Docs/HTMLBRElement/HTMLBRElement.generated.xml' path='docs/HTMLBRElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLBRElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLBRElementHTMLBRElement/HTMLBRElementHTMLBRElement.generated.xml' path='docs/HTMLBRElementHTMLBRElement/*'/>
	public HTMLBRElement() { }
}

///<include file='Utils/Docs/HTMLHyperlinkElementUtils/HTMLHyperlinkElementUtils.generated.xml' path='docs/HTMLHyperlinkElementUtils/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface HTMLHyperlinkElementUtils
{
	///<include file='Utils/Docs/HTMLHyperlinkElementUtilsHref/HTMLHyperlinkElementUtilsHref.generated.xml' path='docs/HTMLHyperlinkElementUtilsHref/*'/>
	public string Href { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/HTMLHyperlinkElementUtilsOrigin/HTMLHyperlinkElementUtilsOrigin.generated.xml' path='docs/HTMLHyperlinkElementUtilsOrigin/*'/>
	public string Origin { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/HTMLHyperlinkElementUtilsProtocol/HTMLHyperlinkElementUtilsProtocol.generated.xml' path='docs/HTMLHyperlinkElementUtilsProtocol/*'/>
	public string Protocol { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/HTMLHyperlinkElementUtilsUsername/HTMLHyperlinkElementUtilsUsername.generated.xml' path='docs/HTMLHyperlinkElementUtilsUsername/*'/>
	public string Username { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/HTMLHyperlinkElementUtilsPassword/HTMLHyperlinkElementUtilsPassword.generated.xml' path='docs/HTMLHyperlinkElementUtilsPassword/*'/>
	public string Password { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/HTMLHyperlinkElementUtilsHost/HTMLHyperlinkElementUtilsHost.generated.xml' path='docs/HTMLHyperlinkElementUtilsHost/*'/>
	public string Host { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/HTMLHyperlinkElementUtilsHostname/HTMLHyperlinkElementUtilsHostname.generated.xml' path='docs/HTMLHyperlinkElementUtilsHostname/*'/>
	public string Hostname { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/HTMLHyperlinkElementUtilsPort/HTMLHyperlinkElementUtilsPort.generated.xml' path='docs/HTMLHyperlinkElementUtilsPort/*'/>
	public string Port { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/HTMLHyperlinkElementUtilsPathname/HTMLHyperlinkElementUtilsPathname.generated.xml' path='docs/HTMLHyperlinkElementUtilsPathname/*'/>
	public string Pathname { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/HTMLHyperlinkElementUtilsSearch/HTMLHyperlinkElementUtilsSearch.generated.xml' path='docs/HTMLHyperlinkElementUtilsSearch/*'/>
	public string Search { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/HTMLHyperlinkElementUtilsHash/HTMLHyperlinkElementUtilsHash.generated.xml' path='docs/HTMLHyperlinkElementUtilsHash/*'/>
	public string Hash { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/HTMLModElement/HTMLModElement.generated.xml' path='docs/HTMLModElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLModElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLModElementHTMLModElement/HTMLModElementHTMLModElement.generated.xml' path='docs/HTMLModElementHTMLModElement/*'/>
	public HTMLModElement() { }
	///<include file='Utils/Docs/HTMLModElementCite/HTMLModElementCite.generated.xml' path='docs/HTMLModElementCite/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Cite { get; set; }
	///<include file='Utils/Docs/HTMLModElementDateTime/HTMLModElementDateTime.generated.xml' path='docs/HTMLModElementDateTime/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string DateTime { get; set; }
}

///<include file='Utils/Docs/HTMLPictureElement/HTMLPictureElement.generated.xml' path='docs/HTMLPictureElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLPictureElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLPictureElementHTMLPictureElement/HTMLPictureElementHTMLPictureElement.generated.xml' path='docs/HTMLPictureElementHTMLPictureElement/*'/>
	public HTMLPictureElement() { }
}

///<include file='Utils/Docs/HTMLSourceElement/HTMLSourceElement.generated.xml' path='docs/HTMLSourceElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLSourceElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLSourceElementHTMLSourceElement/HTMLSourceElementHTMLSourceElement.generated.xml' path='docs/HTMLSourceElementHTMLSourceElement/*'/>
	public HTMLSourceElement() { }
	///<include file='Utils/Docs/HTMLSourceElementSrc/HTMLSourceElementSrc.generated.xml' path='docs/HTMLSourceElementSrc/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	///<include file='Utils/Docs/HTMLSourceElementType/HTMLSourceElementType.generated.xml' path='docs/HTMLSourceElementType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
	///<include file='Utils/Docs/HTMLSourceElementSrcset/HTMLSourceElementSrcset.generated.xml' path='docs/HTMLSourceElementSrcset/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Srcset { get; set; }
	///<include file='Utils/Docs/HTMLSourceElementSizes/HTMLSourceElementSizes.generated.xml' path='docs/HTMLSourceElementSizes/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Sizes { get; set; }
	///<include file='Utils/Docs/HTMLSourceElementMedia/HTMLSourceElementMedia.generated.xml' path='docs/HTMLSourceElementMedia/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Media { get; set; }
	///<include file='Utils/Docs/HTMLSourceElementWidth/HTMLSourceElementWidth.generated.xml' path='docs/HTMLSourceElementWidth/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Width { get; set; }
	///<include file='Utils/Docs/HTMLSourceElementHeight/HTMLSourceElementHeight.generated.xml' path='docs/HTMLSourceElementHeight/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Height { get; set; }
}

///<include file='Utils/Docs/HTMLImageElement/HTMLImageElement.generated.xml' path='docs/HTMLImageElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLImageElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLImageElementHTMLImageElement/HTMLImageElementHTMLImageElement.generated.xml' path='docs/HTMLImageElementHTMLImageElement/*'/>
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
	///<include file='Utils/Docs/HTMLIFrameElementHTMLIFrameElement/HTMLIFrameElementHTMLIFrameElement.generated.xml' path='docs/HTMLIFrameElementHTMLIFrameElement/*'/>
	public HTMLIFrameElement() { }
	///<include file='Utils/Docs/HTMLIFrameElementSrc/HTMLIFrameElementSrc.generated.xml' path='docs/HTMLIFrameElementSrc/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementSrcdoc/HTMLIFrameElementSrcdoc.generated.xml' path='docs/HTMLIFrameElementSrcdoc/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Srcdoc { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementName/HTMLIFrameElementName.generated.xml' path='docs/HTMLIFrameElementName/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementSandbox/HTMLIFrameElementSandbox.generated.xml' path='docs/HTMLIFrameElementSandbox/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList Sandbox { get; }
	///<include file='Utils/Docs/HTMLIFrameElementAllow/HTMLIFrameElementAllow.generated.xml' path='docs/HTMLIFrameElementAllow/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Allow { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementAllowFullscreen/HTMLIFrameElementAllowFullscreen.generated.xml' path='docs/HTMLIFrameElementAllowFullscreen/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool AllowFullscreen { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementWidth/HTMLIFrameElementWidth.generated.xml' path='docs/HTMLIFrameElementWidth/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Width { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementHeight/HTMLIFrameElementHeight.generated.xml' path='docs/HTMLIFrameElementHeight/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Height { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementReferrerPolicy/HTMLIFrameElementReferrerPolicy.generated.xml' path='docs/HTMLIFrameElementReferrerPolicy/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ReferrerPolicy { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementLoading/HTMLIFrameElementLoading.generated.xml' path='docs/HTMLIFrameElementLoading/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Loading { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementContentDocument/HTMLIFrameElementContentDocument.generated.xml' path='docs/HTMLIFrameElementContentDocument/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Document? ContentDocument { get; }
	///<include file='Utils/Docs/HTMLIFrameElementContentWindow/HTMLIFrameElementContentWindow.generated.xml' path='docs/HTMLIFrameElementContentWindow/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Window? ContentWindow { get; }
	///<include file='Utils/Docs/HTMLIFrameElementGetSVGDocument/HTMLIFrameElementGetSVGDocument.generated.xml' path='docs/HTMLIFrameElementGetSVGDocument/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Document? GetSVGDocument() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLEmbedElement/HTMLEmbedElement.generated.xml' path='docs/HTMLEmbedElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLEmbedElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLEmbedElementHTMLEmbedElement/HTMLEmbedElementHTMLEmbedElement.generated.xml' path='docs/HTMLEmbedElementHTMLEmbedElement/*'/>
	public HTMLEmbedElement() { }
	///<include file='Utils/Docs/HTMLEmbedElementSrc/HTMLEmbedElementSrc.generated.xml' path='docs/HTMLEmbedElementSrc/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	///<include file='Utils/Docs/HTMLEmbedElementType/HTMLEmbedElementType.generated.xml' path='docs/HTMLEmbedElementType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
	///<include file='Utils/Docs/HTMLEmbedElementWidth/HTMLEmbedElementWidth.generated.xml' path='docs/HTMLEmbedElementWidth/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Width { get; set; }
	///<include file='Utils/Docs/HTMLEmbedElementHeight/HTMLEmbedElementHeight.generated.xml' path='docs/HTMLEmbedElementHeight/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Height { get; set; }
	///<include file='Utils/Docs/HTMLEmbedElementGetSVGDocument/HTMLEmbedElementGetSVGDocument.generated.xml' path='docs/HTMLEmbedElementGetSVGDocument/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Document? GetSVGDocument() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLObjectElement/HTMLObjectElement.generated.xml' path='docs/HTMLObjectElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLObjectElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLObjectElementHTMLObjectElement/HTMLObjectElementHTMLObjectElement.generated.xml' path='docs/HTMLObjectElementHTMLObjectElement/*'/>
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
	///<include file='Utils/Docs/HTMLObjectElementGetSVGDocument/HTMLObjectElementGetSVGDocument.generated.xml' path='docs/HTMLObjectElementGetSVGDocument/*'/>
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
	///<include file='Utils/Docs/HTMLObjectElementReportValidity/HTMLObjectElementReportValidity.generated.xml' path='docs/HTMLObjectElementReportValidity/*'/>
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
	///<include file='Utils/Docs/HTMLVideoElementHTMLVideoElement/HTMLVideoElementHTMLVideoElement.generated.xml' path='docs/HTMLVideoElementHTMLVideoElement/*'/>
	public HTMLVideoElement() { }
	///<include file='Utils/Docs/HTMLVideoElementWidth/HTMLVideoElementWidth.generated.xml' path='docs/HTMLVideoElementWidth/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Width { get; set; }
	///<include file='Utils/Docs/HTMLVideoElementHeight/HTMLVideoElementHeight.generated.xml' path='docs/HTMLVideoElementHeight/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Height { get; set; }
	///<include file='Utils/Docs/HTMLVideoElementVideoWidth/HTMLVideoElementVideoWidth.generated.xml' path='docs/HTMLVideoElementVideoWidth/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong VideoWidth { get; }
	///<include file='Utils/Docs/HTMLVideoElementVideoHeight/HTMLVideoElementVideoHeight.generated.xml' path='docs/HTMLVideoElementVideoHeight/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong VideoHeight { get; }
	///<include file='Utils/Docs/HTMLVideoElementPoster/HTMLVideoElementPoster.generated.xml' path='docs/HTMLVideoElementPoster/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Poster { get; set; }
	///<include file='Utils/Docs/HTMLVideoElementPlaysInline/HTMLVideoElementPlaysInline.generated.xml' path='docs/HTMLVideoElementPlaysInline/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool PlaysInline { get; set; }
}

///<include file='Utils/Docs/HTMLAudioElement/HTMLAudioElement.generated.xml' path='docs/HTMLAudioElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLAudioElement : HTMLMediaElement
{
	///<include file='Utils/Docs/HTMLAudioElementHTMLAudioElement/HTMLAudioElementHTMLAudioElement.generated.xml' path='docs/HTMLAudioElementHTMLAudioElement/*'/>
	public HTMLAudioElement() { }
}

///<include file='Utils/Docs/HTMLTrackElement/HTMLTrackElement.generated.xml' path='docs/HTMLTrackElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTrackElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLTrackElementHTMLTrackElement/HTMLTrackElementHTMLTrackElement.generated.xml' path='docs/HTMLTrackElementHTMLTrackElement/*'/>
	public HTMLTrackElement() { }
	///<include file='Utils/Docs/HTMLTrackElementKind/HTMLTrackElementKind.generated.xml' path='docs/HTMLTrackElementKind/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Kind { get; set; }
	///<include file='Utils/Docs/HTMLTrackElementSrc/HTMLTrackElementSrc.generated.xml' path='docs/HTMLTrackElementSrc/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	///<include file='Utils/Docs/HTMLTrackElementSrclang/HTMLTrackElementSrclang.generated.xml' path='docs/HTMLTrackElementSrclang/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Srclang { get; set; }
	///<include file='Utils/Docs/HTMLTrackElementLabel/HTMLTrackElementLabel.generated.xml' path='docs/HTMLTrackElementLabel/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Label { get; set; }
	///<include file='Utils/Docs/HTMLTrackElementDefault/HTMLTrackElementDefault.generated.xml' path='docs/HTMLTrackElementDefault/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Default { get; set; }
	///<include file='Utils/Docs/HTMLTrackElementNONE/HTMLTrackElementNONE.generated.xml' path='docs/HTMLTrackElementNONE/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort NONE = 0;
	///<include file='Utils/Docs/HTMLTrackElementLOADING/HTMLTrackElementLOADING.generated.xml' path='docs/HTMLTrackElementLOADING/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort LOADING = 1;
	///<include file='Utils/Docs/HTMLTrackElementLOADED/HTMLTrackElementLOADED.generated.xml' path='docs/HTMLTrackElementLOADED/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort LOADED = 2;
	///<include file='Utils/Docs/HTMLTrackElementERROR/HTMLTrackElementERROR.generated.xml' path='docs/HTMLTrackElementERROR/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort ERROR = 3;
	///<include file='Utils/Docs/HTMLTrackElementReadyState/HTMLTrackElementReadyState.generated.xml' path='docs/HTMLTrackElementReadyState/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ushort ReadyState { get; }
	///<include file='Utils/Docs/HTMLTrackElementTrack/HTMLTrackElementTrack.generated.xml' path='docs/HTMLTrackElementTrack/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrack Track { get; }
}

///<include file='Utils/Docs/CanPlayTypeResult/CanPlayTypeResult.generated.xml' path='docs/CanPlayTypeResult/*'/>
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
	///<include file='Utils/Docs/HTMLMediaElementNETWORK_EMPTY/HTMLMediaElementNETWORK_EMPTY.generated.xml' path='docs/HTMLMediaElementNETWORK_EMPTY/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort NETWORK_EMPTY = 0;
	///<include file='Utils/Docs/HTMLMediaElementNETWORK_IDLE/HTMLMediaElementNETWORK_IDLE.generated.xml' path='docs/HTMLMediaElementNETWORK_IDLE/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort NETWORK_IDLE = 1;
	///<include file='Utils/Docs/HTMLMediaElementNETWORK_LOADING/HTMLMediaElementNETWORK_LOADING.generated.xml' path='docs/HTMLMediaElementNETWORK_LOADING/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort NETWORK_LOADING = 2;
	///<include file='Utils/Docs/HTMLMediaElementNETWORK_NO_SOURCE/HTMLMediaElementNETWORK_NO_SOURCE.generated.xml' path='docs/HTMLMediaElementNETWORK_NO_SOURCE/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort NETWORK_NO_SOURCE = 3;
	///<include file='Utils/Docs/HTMLMediaElementNetworkState/HTMLMediaElementNetworkState.generated.xml' path='docs/HTMLMediaElementNetworkState/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ushort NetworkState { get; }
	///<include file='Utils/Docs/HTMLMediaElementPreload/HTMLMediaElementPreload.generated.xml' path='docs/HTMLMediaElementPreload/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Preload { get; set; }
	///<include file='Utils/Docs/HTMLMediaElementBufferingThrottled/HTMLMediaElementBufferingThrottled.generated.xml' path='docs/HTMLMediaElementBufferingThrottled/*'/>
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
	///<include file='Utils/Docs/HTMLMediaElementHAVE_NOTHING/HTMLMediaElementHAVE_NOTHING.generated.xml' path='docs/HTMLMediaElementHAVE_NOTHING/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort HAVE_NOTHING = 0;
	///<include file='Utils/Docs/HTMLMediaElementHAVE_METADATA/HTMLMediaElementHAVE_METADATA.generated.xml' path='docs/HTMLMediaElementHAVE_METADATA/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort HAVE_METADATA = 1;
	///<include file='Utils/Docs/HTMLMediaElementHAVE_CURRENT_DATA/HTMLMediaElementHAVE_CURRENT_DATA.generated.xml' path='docs/HTMLMediaElementHAVE_CURRENT_DATA/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort HAVE_CURRENT_DATA = 2;
	///<include file='Utils/Docs/HTMLMediaElementHAVE_FUTURE_DATA/HTMLMediaElementHAVE_FUTURE_DATA.generated.xml' path='docs/HTMLMediaElementHAVE_FUTURE_DATA/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort HAVE_FUTURE_DATA = 3;
	///<include file='Utils/Docs/HTMLMediaElementHAVE_ENOUGH_DATA/HTMLMediaElementHAVE_ENOUGH_DATA.generated.xml' path='docs/HTMLMediaElementHAVE_ENOUGH_DATA/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public const ushort HAVE_ENOUGH_DATA = 4;
	///<include file='Utils/Docs/HTMLMediaElementReadyState/HTMLMediaElementReadyState.generated.xml' path='docs/HTMLMediaElementReadyState/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ushort ReadyState { get; }
	///<include file='Utils/Docs/HTMLMediaElementSeeking/HTMLMediaElementSeeking.generated.xml' path='docs/HTMLMediaElementSeeking/*'/>
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
	///<include file='Utils/Docs/HTMLMediaElementGetStartDate/HTMLMediaElementGetStartDate.generated.xml' path='docs/HTMLMediaElementGetStartDate/*'/>
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
	///<include file='Utils/Docs/HTMLMediaElementPlayed/HTMLMediaElementPlayed.generated.xml' path='docs/HTMLMediaElementPlayed/*'/>
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
	///<include file='Utils/Docs/HTMLMediaElementAddTextTrack/HTMLMediaElementAddTextTrack.generated.xml' path='docs/HTMLMediaElementAddTextTrack/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public TextTrack AddTextTrack(TextTrackKind kind, string label, string language) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/MediaError/MediaError.generated.xml' path='docs/MediaError/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MediaError
{
	///<include file='Utils/Docs/MediaErrorMEDIA_ERR_ABORTED/MediaErrorMEDIA_ERR_ABORTED.generated.xml' path='docs/MediaErrorMEDIA_ERR_ABORTED/*'/>
	public const ushort MEDIA_ERR_ABORTED = 1;
	///<include file='Utils/Docs/MediaErrorMEDIA_ERR_NETWORK/MediaErrorMEDIA_ERR_NETWORK.generated.xml' path='docs/MediaErrorMEDIA_ERR_NETWORK/*'/>
	public const ushort MEDIA_ERR_NETWORK = 2;
	///<include file='Utils/Docs/MediaErrorMEDIA_ERR_DECODE/MediaErrorMEDIA_ERR_DECODE.generated.xml' path='docs/MediaErrorMEDIA_ERR_DECODE/*'/>
	public const ushort MEDIA_ERR_DECODE = 3;
	///<include file='Utils/Docs/MediaErrorMEDIA_ERR_SRC_NOT_SUPPORTED/MediaErrorMEDIA_ERR_SRC_NOT_SUPPORTED.generated.xml' path='docs/MediaErrorMEDIA_ERR_SRC_NOT_SUPPORTED/*'/>
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
	///<include file='Utils/Docs/AudioTrackListOnchange/AudioTrackListOnchange.generated.xml' path='docs/AudioTrackListOnchange/*'/>
	public EventHandler Onchange { get; set; }
	///<include file='Utils/Docs/AudioTrackListOnaddtrack/AudioTrackListOnaddtrack.generated.xml' path='docs/AudioTrackListOnaddtrack/*'/>
	public EventHandler Onaddtrack { get; set; }
	///<include file='Utils/Docs/AudioTrackListOnremovetrack/AudioTrackListOnremovetrack.generated.xml' path='docs/AudioTrackListOnremovetrack/*'/>
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
	///<include file='Utils/Docs/VideoTrackListOnchange/VideoTrackListOnchange.generated.xml' path='docs/VideoTrackListOnchange/*'/>
	public EventHandler Onchange { get; set; }
	///<include file='Utils/Docs/VideoTrackListOnaddtrack/VideoTrackListOnaddtrack.generated.xml' path='docs/VideoTrackListOnaddtrack/*'/>
	public EventHandler Onaddtrack { get; set; }
	///<include file='Utils/Docs/VideoTrackListOnremovetrack/VideoTrackListOnremovetrack.generated.xml' path='docs/VideoTrackListOnremovetrack/*'/>
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
	///<include file='Utils/Docs/TextTrackListOnchange/TextTrackListOnchange.generated.xml' path='docs/TextTrackListOnchange/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onchange { get; set; }
	///<include file='Utils/Docs/TextTrackListOnaddtrack/TextTrackListOnaddtrack.generated.xml' path='docs/TextTrackListOnaddtrack/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onaddtrack { get; set; }
	///<include file='Utils/Docs/TextTrackListOnremovetrack/TextTrackListOnremovetrack.generated.xml' path='docs/TextTrackListOnremovetrack/*'/>
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
	///<include file='Utils/Docs/TextTrackOncuechange/TextTrackOncuechange.generated.xml' path='docs/TextTrackOncuechange/*'/>
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
	///<include file='Utils/Docs/TextTrackCueOnenter/TextTrackCueOnenter.generated.xml' path='docs/TextTrackCueOnenter/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public EventHandler Onenter { get; set; }
	///<include file='Utils/Docs/TextTrackCueOnexit/TextTrackCueOnexit.generated.xml' path='docs/TextTrackCueOnexit/*'/>
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

///<include file='Utils/Docs/TrackEventInit/TrackEventInit.generated.xml' path='docs/TrackEventInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class TrackEventInit : EventInit
{
	///<include file='Utils/Docs/TrackEventInitTrack/TrackEventInitTrack.generated.xml' path='docs/TrackEventInitTrack/*'/>
	public Union22? Track;
}

///<include file='Utils/Docs/HTMLMapElement/HTMLMapElement.generated.xml' path='docs/HTMLMapElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLMapElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLMapElementHTMLMapElement/HTMLMapElementHTMLMapElement.generated.xml' path='docs/HTMLMapElementHTMLMapElement/*'/>
	public HTMLMapElement() { }
	///<include file='Utils/Docs/HTMLMapElementName/HTMLMapElementName.generated.xml' path='docs/HTMLMapElementName/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	///<include file='Utils/Docs/HTMLMapElementAreas/HTMLMapElementAreas.generated.xml' path='docs/HTMLMapElementAreas/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection Areas { get; }
}

///<include file='Utils/Docs/HTMLAreaElement/HTMLAreaElement.generated.xml' path='docs/HTMLAreaElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLAreaElement : HTMLElement, HTMLHyperlinkElementUtils
{
	///<include file='Utils/Docs/HTMLAreaElementHTMLAreaElement/HTMLAreaElementHTMLAreaElement.generated.xml' path='docs/HTMLAreaElementHTMLAreaElement/*'/>
	public HTMLAreaElement() { }
	///<include file='Utils/Docs/HTMLAreaElementAlt/HTMLAreaElementAlt.generated.xml' path='docs/HTMLAreaElementAlt/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Alt { get; set; }
	///<include file='Utils/Docs/HTMLAreaElementCoords/HTMLAreaElementCoords.generated.xml' path='docs/HTMLAreaElementCoords/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Coords { get; set; }
	///<include file='Utils/Docs/HTMLAreaElementShape/HTMLAreaElementShape.generated.xml' path='docs/HTMLAreaElementShape/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Shape { get; set; }
	///<include file='Utils/Docs/HTMLAreaElementTarget/HTMLAreaElementTarget.generated.xml' path='docs/HTMLAreaElementTarget/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Target { get; set; }
	///<include file='Utils/Docs/HTMLAreaElementDownload/HTMLAreaElementDownload.generated.xml' path='docs/HTMLAreaElementDownload/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Download { get; set; }
	///<include file='Utils/Docs/HTMLAreaElementPing/HTMLAreaElementPing.generated.xml' path='docs/HTMLAreaElementPing/*'/>
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
	///<include file='Utils/Docs/HTMLTableElementHTMLTableElement/HTMLTableElementHTMLTableElement.generated.xml' path='docs/HTMLTableElementHTMLTableElement/*'/>
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
	///<include file='Utils/Docs/HTMLTableCaptionElementHTMLTableCaptionElement/HTMLTableCaptionElementHTMLTableCaptionElement.generated.xml' path='docs/HTMLTableCaptionElementHTMLTableCaptionElement/*'/>
	public HTMLTableCaptionElement() { }
}

///<include file='Utils/Docs/HTMLTableColElement/HTMLTableColElement.generated.xml' path='docs/HTMLTableColElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTableColElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLTableColElementHTMLTableColElement/HTMLTableColElementHTMLTableColElement.generated.xml' path='docs/HTMLTableColElementHTMLTableColElement/*'/>
	public HTMLTableColElement() { }
	///<include file='Utils/Docs/HTMLTableColElementSpan/HTMLTableColElementSpan.generated.xml' path='docs/HTMLTableColElementSpan/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Span { get; set; }
}

///<include file='Utils/Docs/HTMLTableSectionElement/HTMLTableSectionElement.generated.xml' path='docs/HTMLTableSectionElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTableSectionElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLTableSectionElementHTMLTableSectionElement/HTMLTableSectionElementHTMLTableSectionElement.generated.xml' path='docs/HTMLTableSectionElementHTMLTableSectionElement/*'/>
	public HTMLTableSectionElement() { }
	///<include file='Utils/Docs/HTMLTableSectionElementRows/HTMLTableSectionElementRows.generated.xml' path='docs/HTMLTableSectionElementRows/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection Rows { get; }
	///<include file='Utils/Docs/HTMLTableSectionElementInsertRow/HTMLTableSectionElementInsertRow.generated.xml' path='docs/HTMLTableSectionElementInsertRow/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableRowElement InsertRow(long index) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTableSectionElementDeleteRow/HTMLTableSectionElementDeleteRow.generated.xml' path='docs/HTMLTableSectionElementDeleteRow/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined DeleteRow(long index) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLTableRowElement/HTMLTableRowElement.generated.xml' path='docs/HTMLTableRowElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTableRowElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLTableRowElementHTMLTableRowElement/HTMLTableRowElementHTMLTableRowElement.generated.xml' path='docs/HTMLTableRowElementHTMLTableRowElement/*'/>
	public HTMLTableRowElement() { }
	///<include file='Utils/Docs/HTMLTableRowElementRowIndex/HTMLTableRowElementRowIndex.generated.xml' path='docs/HTMLTableRowElementRowIndex/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public long RowIndex { get; }
	///<include file='Utils/Docs/HTMLTableRowElementSectionRowIndex/HTMLTableRowElementSectionRowIndex.generated.xml' path='docs/HTMLTableRowElementSectionRowIndex/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public long SectionRowIndex { get; }
	///<include file='Utils/Docs/HTMLTableRowElementCells/HTMLTableRowElementCells.generated.xml' path='docs/HTMLTableRowElementCells/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection Cells { get; }
	///<include file='Utils/Docs/HTMLTableRowElementInsertCell/HTMLTableRowElementInsertCell.generated.xml' path='docs/HTMLTableRowElementInsertCell/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLTableCellElement InsertCell(long index) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTableRowElementDeleteCell/HTMLTableRowElementDeleteCell.generated.xml' path='docs/HTMLTableRowElementDeleteCell/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined DeleteCell(long index) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLTableCellElement/HTMLTableCellElement.generated.xml' path='docs/HTMLTableCellElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTableCellElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLTableCellElementHTMLTableCellElement/HTMLTableCellElementHTMLTableCellElement.generated.xml' path='docs/HTMLTableCellElementHTMLTableCellElement/*'/>
	public HTMLTableCellElement() { }
	///<include file='Utils/Docs/HTMLTableCellElementColSpan/HTMLTableCellElementColSpan.generated.xml' path='docs/HTMLTableCellElementColSpan/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong ColSpan { get; set; }
	///<include file='Utils/Docs/HTMLTableCellElementRowSpan/HTMLTableCellElementRowSpan.generated.xml' path='docs/HTMLTableCellElementRowSpan/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong RowSpan { get; set; }
	///<include file='Utils/Docs/HTMLTableCellElementHeaders/HTMLTableCellElementHeaders.generated.xml' path='docs/HTMLTableCellElementHeaders/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Headers { get; set; }
	///<include file='Utils/Docs/HTMLTableCellElementCellIndex/HTMLTableCellElementCellIndex.generated.xml' path='docs/HTMLTableCellElementCellIndex/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public long CellIndex { get; }
	///<include file='Utils/Docs/HTMLTableCellElementScope/HTMLTableCellElementScope.generated.xml' path='docs/HTMLTableCellElementScope/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Scope { get; set; }
	///<include file='Utils/Docs/HTMLTableCellElementAbbr/HTMLTableCellElementAbbr.generated.xml' path='docs/HTMLTableCellElementAbbr/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Abbr { get; set; }
}

///<include file='Utils/Docs/HTMLFormElement/HTMLFormElement.generated.xml' path='docs/HTMLFormElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLFormElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLFormElementHTMLFormElement/HTMLFormElementHTMLFormElement.generated.xml' path='docs/HTMLFormElementHTMLFormElement/*'/>
	public HTMLFormElement() { }
	///<include file='Utils/Docs/HTMLFormElementAcceptCharset/HTMLFormElementAcceptCharset.generated.xml' path='docs/HTMLFormElementAcceptCharset/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string AcceptCharset { get; set; }
	///<include file='Utils/Docs/HTMLFormElementAction/HTMLFormElementAction.generated.xml' path='docs/HTMLFormElementAction/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Action { get; set; }
	///<include file='Utils/Docs/HTMLFormElementAutocomplete/HTMLFormElementAutocomplete.generated.xml' path='docs/HTMLFormElementAutocomplete/*'/>
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
	///<include file='Utils/Docs/HTMLFormElementNoValidate/HTMLFormElementNoValidate.generated.xml' path='docs/HTMLFormElementNoValidate/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool NoValidate { get; set; }
	///<include file='Utils/Docs/HTMLFormElementTarget/HTMLFormElementTarget.generated.xml' path='docs/HTMLFormElementTarget/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Target { get; set; }
	///<include file='Utils/Docs/HTMLFormElementRel/HTMLFormElementRel.generated.xml' path='docs/HTMLFormElementRel/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Rel { get; set; }
	///<include file='Utils/Docs/HTMLFormElementRelList/HTMLFormElementRelList.generated.xml' path='docs/HTMLFormElementRelList/*'/>
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
	///<include file='Utils/Docs/HTMLFormElementCheckValidity/HTMLFormElementCheckValidity.generated.xml' path='docs/HTMLFormElementCheckValidity/*'/>
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
	///<include file='Utils/Docs/HTMLLabelElementHTMLLabelElement/HTMLLabelElementHTMLLabelElement.generated.xml' path='docs/HTMLLabelElementHTMLLabelElement/*'/>
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
	///<include file='Utils/Docs/HTMLInputElementHTMLInputElement/HTMLInputElementHTMLInputElement.generated.xml' path='docs/HTMLInputElementHTMLInputElement/*'/>
	public HTMLInputElement() { }
	///<include file='Utils/Docs/HTMLInputElementAccept/HTMLInputElementAccept.generated.xml' path='docs/HTMLInputElementAccept/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Accept { get; set; }
	///<include file='Utils/Docs/HTMLInputElementAlt/HTMLInputElementAlt.generated.xml' path='docs/HTMLInputElementAlt/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Alt { get; set; }
	///<include file='Utils/Docs/HTMLInputElementAutocomplete/HTMLInputElementAutocomplete.generated.xml' path='docs/HTMLInputElementAutocomplete/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Autocomplete { get; set; }
	///<include file='Utils/Docs/HTMLInputElementDefaultChecked/HTMLInputElementDefaultChecked.generated.xml' path='docs/HTMLInputElementDefaultChecked/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool DefaultChecked { get; set; }
	///<include file='Utils/Docs/HTMLInputElementChecked/HTMLInputElementChecked.generated.xml' path='docs/HTMLInputElementChecked/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Checked { get; set; }
	///<include file='Utils/Docs/HTMLInputElementDirName/HTMLInputElementDirName.generated.xml' path='docs/HTMLInputElementDirName/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string DirName { get; set; }
	///<include file='Utils/Docs/HTMLInputElementDisabled/HTMLInputElementDisabled.generated.xml' path='docs/HTMLInputElementDisabled/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	///<include file='Utils/Docs/HTMLInputElementForm/HTMLInputElementForm.generated.xml' path='docs/HTMLInputElementForm/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	///<include file='Utils/Docs/HTMLInputElementFiles/HTMLInputElementFiles.generated.xml' path='docs/HTMLInputElementFiles/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Unsupported /*FileList*/? Files { get; set; }
	///<include file='Utils/Docs/HTMLInputElementFormAction/HTMLInputElementFormAction.generated.xml' path='docs/HTMLInputElementFormAction/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string FormAction { get; set; }
	///<include file='Utils/Docs/HTMLInputElementFormEnctype/HTMLInputElementFormEnctype.generated.xml' path='docs/HTMLInputElementFormEnctype/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string FormEnctype { get; set; }
	///<include file='Utils/Docs/HTMLInputElementFormMethod/HTMLInputElementFormMethod.generated.xml' path='docs/HTMLInputElementFormMethod/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string FormMethod { get; set; }
	///<include file='Utils/Docs/HTMLInputElementFormNoValidate/HTMLInputElementFormNoValidate.generated.xml' path='docs/HTMLInputElementFormNoValidate/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool FormNoValidate { get; set; }
	///<include file='Utils/Docs/HTMLInputElementFormTarget/HTMLInputElementFormTarget.generated.xml' path='docs/HTMLInputElementFormTarget/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string FormTarget { get; set; }
	///<include file='Utils/Docs/HTMLInputElementHeight/HTMLInputElementHeight.generated.xml' path='docs/HTMLInputElementHeight/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Height { get; set; }
	///<include file='Utils/Docs/HTMLInputElementIndeterminate/HTMLInputElementIndeterminate.generated.xml' path='docs/HTMLInputElementIndeterminate/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Indeterminate { get; set; }
	///<include file='Utils/Docs/HTMLInputElementList/HTMLInputElementList.generated.xml' path='docs/HTMLInputElementList/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLElement? List { get; }
	///<include file='Utils/Docs/HTMLInputElementMax/HTMLInputElementMax.generated.xml' path='docs/HTMLInputElementMax/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Max { get; set; }
	///<include file='Utils/Docs/HTMLInputElementMaxLength/HTMLInputElementMaxLength.generated.xml' path='docs/HTMLInputElementMaxLength/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public long MaxLength { get; set; }
	///<include file='Utils/Docs/HTMLInputElementMin/HTMLInputElementMin.generated.xml' path='docs/HTMLInputElementMin/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Min { get; set; }
	///<include file='Utils/Docs/HTMLInputElementMinLength/HTMLInputElementMinLength.generated.xml' path='docs/HTMLInputElementMinLength/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public long MinLength { get; set; }
	///<include file='Utils/Docs/HTMLInputElementMultiple/HTMLInputElementMultiple.generated.xml' path='docs/HTMLInputElementMultiple/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Multiple { get; set; }
	///<include file='Utils/Docs/HTMLInputElementName/HTMLInputElementName.generated.xml' path='docs/HTMLInputElementName/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	///<include file='Utils/Docs/HTMLInputElementPattern/HTMLInputElementPattern.generated.xml' path='docs/HTMLInputElementPattern/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Pattern { get; set; }
	///<include file='Utils/Docs/HTMLInputElementPlaceholder/HTMLInputElementPlaceholder.generated.xml' path='docs/HTMLInputElementPlaceholder/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Placeholder { get; set; }
	///<include file='Utils/Docs/HTMLInputElementReadOnly/HTMLInputElementReadOnly.generated.xml' path='docs/HTMLInputElementReadOnly/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReadOnly { get; set; }
	///<include file='Utils/Docs/HTMLInputElementRequired/HTMLInputElementRequired.generated.xml' path='docs/HTMLInputElementRequired/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Required { get; set; }
	///<include file='Utils/Docs/HTMLInputElementSize/HTMLInputElementSize.generated.xml' path='docs/HTMLInputElementSize/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Size { get; set; }
	///<include file='Utils/Docs/HTMLInputElementSrc/HTMLInputElementSrc.generated.xml' path='docs/HTMLInputElementSrc/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	///<include file='Utils/Docs/HTMLInputElementStep/HTMLInputElementStep.generated.xml' path='docs/HTMLInputElementStep/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Step { get; set; }
	///<include file='Utils/Docs/HTMLInputElementType/HTMLInputElementType.generated.xml' path='docs/HTMLInputElementType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
	///<include file='Utils/Docs/HTMLInputElementDefaultValue/HTMLInputElementDefaultValue.generated.xml' path='docs/HTMLInputElementDefaultValue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string DefaultValue { get; set; }
	///<include file='Utils/Docs/HTMLInputElementValue/HTMLInputElementValue.generated.xml' path='docs/HTMLInputElementValue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
	///<include file='Utils/Docs/HTMLInputElementValueAsDate/HTMLInputElementValueAsDate.generated.xml' path='docs/HTMLInputElementValueAsDate/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public object? ValueAsDate { get; set; }
	///<include file='Utils/Docs/HTMLInputElementValueAsNumber/HTMLInputElementValueAsNumber.generated.xml' path='docs/HTMLInputElementValueAsNumber/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double ValueAsNumber { get; set; }
	///<include file='Utils/Docs/HTMLInputElementWidth/HTMLInputElementWidth.generated.xml' path='docs/HTMLInputElementWidth/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Width { get; set; }
	///<include file='Utils/Docs/HTMLInputElementStepUp/HTMLInputElementStepUp.generated.xml' path='docs/HTMLInputElementStepUp/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined StepUp(long n) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLInputElementStepDown/HTMLInputElementStepDown.generated.xml' path='docs/HTMLInputElementStepDown/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined StepDown(long n) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLInputElementWillValidate/HTMLInputElementWillValidate.generated.xml' path='docs/HTMLInputElementWillValidate/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
	///<include file='Utils/Docs/HTMLInputElementValidity/HTMLInputElementValidity.generated.xml' path='docs/HTMLInputElementValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
	///<include file='Utils/Docs/HTMLInputElementValidationMessage/HTMLInputElementValidationMessage.generated.xml' path='docs/HTMLInputElementValidationMessage/*'/>
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
	///<include file='Utils/Docs/HTMLInputElementSelectionStart/HTMLInputElementSelectionStart.generated.xml' path='docs/HTMLInputElementSelectionStart/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong? SelectionStart { get; set; }
	///<include file='Utils/Docs/HTMLInputElementSelectionEnd/HTMLInputElementSelectionEnd.generated.xml' path='docs/HTMLInputElementSelectionEnd/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong? SelectionEnd { get; set; }
	///<include file='Utils/Docs/HTMLInputElementSelectionDirection/HTMLInputElementSelectionDirection.generated.xml' path='docs/HTMLInputElementSelectionDirection/*'/>
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
	///<include file='Utils/Docs/HTMLButtonElementHTMLButtonElement/HTMLButtonElementHTMLButtonElement.generated.xml' path='docs/HTMLButtonElementHTMLButtonElement/*'/>
	public HTMLButtonElement() { }
	///<include file='Utils/Docs/HTMLButtonElementDisabled/HTMLButtonElementDisabled.generated.xml' path='docs/HTMLButtonElementDisabled/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	///<include file='Utils/Docs/HTMLButtonElementForm/HTMLButtonElementForm.generated.xml' path='docs/HTMLButtonElementForm/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	///<include file='Utils/Docs/HTMLButtonElementFormAction/HTMLButtonElementFormAction.generated.xml' path='docs/HTMLButtonElementFormAction/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string FormAction { get; set; }
	///<include file='Utils/Docs/HTMLButtonElementFormEnctype/HTMLButtonElementFormEnctype.generated.xml' path='docs/HTMLButtonElementFormEnctype/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string FormEnctype { get; set; }
	///<include file='Utils/Docs/HTMLButtonElementFormMethod/HTMLButtonElementFormMethod.generated.xml' path='docs/HTMLButtonElementFormMethod/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string FormMethod { get; set; }
	///<include file='Utils/Docs/HTMLButtonElementFormNoValidate/HTMLButtonElementFormNoValidate.generated.xml' path='docs/HTMLButtonElementFormNoValidate/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool FormNoValidate { get; set; }
	///<include file='Utils/Docs/HTMLButtonElementFormTarget/HTMLButtonElementFormTarget.generated.xml' path='docs/HTMLButtonElementFormTarget/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string FormTarget { get; set; }
	///<include file='Utils/Docs/HTMLButtonElementName/HTMLButtonElementName.generated.xml' path='docs/HTMLButtonElementName/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	///<include file='Utils/Docs/HTMLButtonElementType/HTMLButtonElementType.generated.xml' path='docs/HTMLButtonElementType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
	///<include file='Utils/Docs/HTMLButtonElementValue/HTMLButtonElementValue.generated.xml' path='docs/HTMLButtonElementValue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
	///<include file='Utils/Docs/HTMLButtonElementWillValidate/HTMLButtonElementWillValidate.generated.xml' path='docs/HTMLButtonElementWillValidate/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
	///<include file='Utils/Docs/HTMLButtonElementValidity/HTMLButtonElementValidity.generated.xml' path='docs/HTMLButtonElementValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
	///<include file='Utils/Docs/HTMLButtonElementValidationMessage/HTMLButtonElementValidationMessage.generated.xml' path='docs/HTMLButtonElementValidationMessage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
	///<include file='Utils/Docs/HTMLButtonElementCheckValidity/HTMLButtonElementCheckValidity.generated.xml' path='docs/HTMLButtonElementCheckValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLButtonElementReportValidity/HTMLButtonElementReportValidity.generated.xml' path='docs/HTMLButtonElementReportValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLButtonElementSetCustomValidity/HTMLButtonElementSetCustomValidity.generated.xml' path='docs/HTMLButtonElementSetCustomValidity/*'/>
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
	///<include file='Utils/Docs/HTMLSelectElementHTMLSelectElement/HTMLSelectElementHTMLSelectElement.generated.xml' path='docs/HTMLSelectElementHTMLSelectElement/*'/>
	public HTMLSelectElement() { }
	///<include file='Utils/Docs/HTMLSelectElementAutocomplete/HTMLSelectElementAutocomplete.generated.xml' path='docs/HTMLSelectElementAutocomplete/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Autocomplete { get; set; }
	///<include file='Utils/Docs/HTMLSelectElementDisabled/HTMLSelectElementDisabled.generated.xml' path='docs/HTMLSelectElementDisabled/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	///<include file='Utils/Docs/HTMLSelectElementForm/HTMLSelectElementForm.generated.xml' path='docs/HTMLSelectElementForm/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	///<include file='Utils/Docs/HTMLSelectElementMultiple/HTMLSelectElementMultiple.generated.xml' path='docs/HTMLSelectElementMultiple/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Multiple { get; set; }
	///<include file='Utils/Docs/HTMLSelectElementName/HTMLSelectElementName.generated.xml' path='docs/HTMLSelectElementName/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	///<include file='Utils/Docs/HTMLSelectElementRequired/HTMLSelectElementRequired.generated.xml' path='docs/HTMLSelectElementRequired/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Required { get; set; }
	///<include file='Utils/Docs/HTMLSelectElementSize/HTMLSelectElementSize.generated.xml' path='docs/HTMLSelectElementSize/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Size { get; set; }
	///<include file='Utils/Docs/HTMLSelectElementType/HTMLSelectElementType.generated.xml' path='docs/HTMLSelectElementType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; }
	///<include file='Utils/Docs/HTMLSelectElementOptions/HTMLSelectElementOptions.generated.xml' path='docs/HTMLSelectElementOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLOptionsCollection Options { get; }
	///<include file='Utils/Docs/HTMLSelectElementLength/HTMLSelectElementLength.generated.xml' path='docs/HTMLSelectElementLength/*'/>
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
	///<include file='Utils/Docs/HTMLSelectElementValue/HTMLSelectElementValue.generated.xml' path='docs/HTMLSelectElementValue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
	///<include file='Utils/Docs/HTMLSelectElementWillValidate/HTMLSelectElementWillValidate.generated.xml' path='docs/HTMLSelectElementWillValidate/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
	///<include file='Utils/Docs/HTMLSelectElementValidity/HTMLSelectElementValidity.generated.xml' path='docs/HTMLSelectElementValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
	///<include file='Utils/Docs/HTMLSelectElementValidationMessage/HTMLSelectElementValidationMessage.generated.xml' path='docs/HTMLSelectElementValidationMessage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
	///<include file='Utils/Docs/HTMLSelectElementCheckValidity/HTMLSelectElementCheckValidity.generated.xml' path='docs/HTMLSelectElementCheckValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLSelectElementReportValidity/HTMLSelectElementReportValidity.generated.xml' path='docs/HTMLSelectElementReportValidity/*'/>
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
	///<include file='Utils/Docs/HTMLDataListElementHTMLDataListElement/HTMLDataListElementHTMLDataListElement.generated.xml' path='docs/HTMLDataListElementHTMLDataListElement/*'/>
	public HTMLDataListElement() { }
	///<include file='Utils/Docs/HTMLDataListElementOptions/HTMLDataListElementOptions.generated.xml' path='docs/HTMLDataListElementOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection Options { get; }
}

///<include file='Utils/Docs/HTMLOptGroupElement/HTMLOptGroupElement.generated.xml' path='docs/HTMLOptGroupElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLOptGroupElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLOptGroupElementHTMLOptGroupElement/HTMLOptGroupElementHTMLOptGroupElement.generated.xml' path='docs/HTMLOptGroupElementHTMLOptGroupElement/*'/>
	public HTMLOptGroupElement() { }
	///<include file='Utils/Docs/HTMLOptGroupElementDisabled/HTMLOptGroupElementDisabled.generated.xml' path='docs/HTMLOptGroupElementDisabled/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	///<include file='Utils/Docs/HTMLOptGroupElementLabel/HTMLOptGroupElementLabel.generated.xml' path='docs/HTMLOptGroupElementLabel/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Label { get; set; }
}

///<include file='Utils/Docs/HTMLOptionElement/HTMLOptionElement.generated.xml' path='docs/HTMLOptionElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLOptionElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLOptionElementHTMLOptionElement/HTMLOptionElementHTMLOptionElement.generated.xml' path='docs/HTMLOptionElementHTMLOptionElement/*'/>
	public HTMLOptionElement() { }
	///<include file='Utils/Docs/HTMLOptionElementDisabled/HTMLOptionElementDisabled.generated.xml' path='docs/HTMLOptionElementDisabled/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	///<include file='Utils/Docs/HTMLOptionElementForm/HTMLOptionElementForm.generated.xml' path='docs/HTMLOptionElementForm/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	///<include file='Utils/Docs/HTMLOptionElementLabel/HTMLOptionElementLabel.generated.xml' path='docs/HTMLOptionElementLabel/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Label { get; set; }
	///<include file='Utils/Docs/HTMLOptionElementDefaultSelected/HTMLOptionElementDefaultSelected.generated.xml' path='docs/HTMLOptionElementDefaultSelected/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool DefaultSelected { get; set; }
	///<include file='Utils/Docs/HTMLOptionElementSelected/HTMLOptionElementSelected.generated.xml' path='docs/HTMLOptionElementSelected/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Selected { get; set; }
	///<include file='Utils/Docs/HTMLOptionElementValue/HTMLOptionElementValue.generated.xml' path='docs/HTMLOptionElementValue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
	///<include file='Utils/Docs/HTMLOptionElementText/HTMLOptionElementText.generated.xml' path='docs/HTMLOptionElementText/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Text { get; set; }
	///<include file='Utils/Docs/HTMLOptionElementIndex/HTMLOptionElementIndex.generated.xml' path='docs/HTMLOptionElementIndex/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public long Index { get; }
}

///<include file='Utils/Docs/HTMLTextAreaElement/HTMLTextAreaElement.generated.xml' path='docs/HTMLTextAreaElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTextAreaElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLTextAreaElementHTMLTextAreaElement/HTMLTextAreaElementHTMLTextAreaElement.generated.xml' path='docs/HTMLTextAreaElementHTMLTextAreaElement/*'/>
	public HTMLTextAreaElement() { }
	///<include file='Utils/Docs/HTMLTextAreaElementAutocomplete/HTMLTextAreaElementAutocomplete.generated.xml' path='docs/HTMLTextAreaElementAutocomplete/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Autocomplete { get; set; }
	///<include file='Utils/Docs/HTMLTextAreaElementCols/HTMLTextAreaElementCols.generated.xml' path='docs/HTMLTextAreaElementCols/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Cols { get; set; }
	///<include file='Utils/Docs/HTMLTextAreaElementDirName/HTMLTextAreaElementDirName.generated.xml' path='docs/HTMLTextAreaElementDirName/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string DirName { get; set; }
	///<include file='Utils/Docs/HTMLTextAreaElementDisabled/HTMLTextAreaElementDisabled.generated.xml' path='docs/HTMLTextAreaElementDisabled/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	///<include file='Utils/Docs/HTMLTextAreaElementForm/HTMLTextAreaElementForm.generated.xml' path='docs/HTMLTextAreaElementForm/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	///<include file='Utils/Docs/HTMLTextAreaElementMaxLength/HTMLTextAreaElementMaxLength.generated.xml' path='docs/HTMLTextAreaElementMaxLength/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public long MaxLength { get; set; }
	///<include file='Utils/Docs/HTMLTextAreaElementMinLength/HTMLTextAreaElementMinLength.generated.xml' path='docs/HTMLTextAreaElementMinLength/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public long MinLength { get; set; }
	///<include file='Utils/Docs/HTMLTextAreaElementName/HTMLTextAreaElementName.generated.xml' path='docs/HTMLTextAreaElementName/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	///<include file='Utils/Docs/HTMLTextAreaElementPlaceholder/HTMLTextAreaElementPlaceholder.generated.xml' path='docs/HTMLTextAreaElementPlaceholder/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Placeholder { get; set; }
	///<include file='Utils/Docs/HTMLTextAreaElementReadOnly/HTMLTextAreaElementReadOnly.generated.xml' path='docs/HTMLTextAreaElementReadOnly/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReadOnly { get; set; }
	///<include file='Utils/Docs/HTMLTextAreaElementRequired/HTMLTextAreaElementRequired.generated.xml' path='docs/HTMLTextAreaElementRequired/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Required { get; set; }
	///<include file='Utils/Docs/HTMLTextAreaElementRows/HTMLTextAreaElementRows.generated.xml' path='docs/HTMLTextAreaElementRows/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Rows { get; set; }
	///<include file='Utils/Docs/HTMLTextAreaElementWrap/HTMLTextAreaElementWrap.generated.xml' path='docs/HTMLTextAreaElementWrap/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Wrap { get; set; }
	///<include file='Utils/Docs/HTMLTextAreaElementType/HTMLTextAreaElementType.generated.xml' path='docs/HTMLTextAreaElementType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; }
	///<include file='Utils/Docs/HTMLTextAreaElementDefaultValue/HTMLTextAreaElementDefaultValue.generated.xml' path='docs/HTMLTextAreaElementDefaultValue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string DefaultValue { get; set; }
	///<include file='Utils/Docs/HTMLTextAreaElementValue/HTMLTextAreaElementValue.generated.xml' path='docs/HTMLTextAreaElementValue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
	///<include file='Utils/Docs/HTMLTextAreaElementTextLength/HTMLTextAreaElementTextLength.generated.xml' path='docs/HTMLTextAreaElementTextLength/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong TextLength { get; }
	///<include file='Utils/Docs/HTMLTextAreaElementWillValidate/HTMLTextAreaElementWillValidate.generated.xml' path='docs/HTMLTextAreaElementWillValidate/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
	///<include file='Utils/Docs/HTMLTextAreaElementValidity/HTMLTextAreaElementValidity.generated.xml' path='docs/HTMLTextAreaElementValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
	///<include file='Utils/Docs/HTMLTextAreaElementValidationMessage/HTMLTextAreaElementValidationMessage.generated.xml' path='docs/HTMLTextAreaElementValidationMessage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
	///<include file='Utils/Docs/HTMLTextAreaElementCheckValidity/HTMLTextAreaElementCheckValidity.generated.xml' path='docs/HTMLTextAreaElementCheckValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTextAreaElementReportValidity/HTMLTextAreaElementReportValidity.generated.xml' path='docs/HTMLTextAreaElementReportValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTextAreaElementSetCustomValidity/HTMLTextAreaElementSetCustomValidity.generated.xml' path='docs/HTMLTextAreaElementSetCustomValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetCustomValidity(string error) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTextAreaElementLabels/HTMLTextAreaElementLabels.generated.xml' path='docs/HTMLTextAreaElementLabels/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public NodeList Labels { get; }
	///<include file='Utils/Docs/HTMLTextAreaElementSelect/HTMLTextAreaElementSelect.generated.xml' path='docs/HTMLTextAreaElementSelect/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Select() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTextAreaElementSelectionStart/HTMLTextAreaElementSelectionStart.generated.xml' path='docs/HTMLTextAreaElementSelectionStart/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong SelectionStart { get; set; }
	///<include file='Utils/Docs/HTMLTextAreaElementSelectionEnd/HTMLTextAreaElementSelectionEnd.generated.xml' path='docs/HTMLTextAreaElementSelectionEnd/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong SelectionEnd { get; set; }
	///<include file='Utils/Docs/HTMLTextAreaElementSelectionDirection/HTMLTextAreaElementSelectionDirection.generated.xml' path='docs/HTMLTextAreaElementSelectionDirection/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string SelectionDirection { get; set; }
	///<include file='Utils/Docs/HTMLTextAreaElementSetRangeText/HTMLTextAreaElementSetRangeText.generated.xml' path='docs/HTMLTextAreaElementSetRangeText/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetRangeText(string replacement) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTextAreaElementSetRangeText/HTMLTextAreaElementSetRangeText.generated.xml' path='docs/HTMLTextAreaElementSetRangeText/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetRangeText(string replacement, ulong start, ulong end, SelectionMode selectionMode) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLTextAreaElementSetSelectionRange/HTMLTextAreaElementSetSelectionRange.generated.xml' path='docs/HTMLTextAreaElementSetSelectionRange/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetSelectionRange(ulong start, ulong end, string direction) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLOutputElement/HTMLOutputElement.generated.xml' path='docs/HTMLOutputElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLOutputElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLOutputElementHTMLOutputElement/HTMLOutputElementHTMLOutputElement.generated.xml' path='docs/HTMLOutputElementHTMLOutputElement/*'/>
	public HTMLOutputElement() { }
	///<include file='Utils/Docs/HTMLOutputElementHtmlFor/HTMLOutputElementHtmlFor.generated.xml' path='docs/HTMLOutputElementHtmlFor/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList HtmlFor { get; }
	///<include file='Utils/Docs/HTMLOutputElementForm/HTMLOutputElementForm.generated.xml' path='docs/HTMLOutputElementForm/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	///<include file='Utils/Docs/HTMLOutputElementName/HTMLOutputElementName.generated.xml' path='docs/HTMLOutputElementName/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	///<include file='Utils/Docs/HTMLOutputElementType/HTMLOutputElementType.generated.xml' path='docs/HTMLOutputElementType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; }
	///<include file='Utils/Docs/HTMLOutputElementDefaultValue/HTMLOutputElementDefaultValue.generated.xml' path='docs/HTMLOutputElementDefaultValue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string DefaultValue { get; set; }
	///<include file='Utils/Docs/HTMLOutputElementValue/HTMLOutputElementValue.generated.xml' path='docs/HTMLOutputElementValue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
	///<include file='Utils/Docs/HTMLOutputElementWillValidate/HTMLOutputElementWillValidate.generated.xml' path='docs/HTMLOutputElementWillValidate/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
	///<include file='Utils/Docs/HTMLOutputElementValidity/HTMLOutputElementValidity.generated.xml' path='docs/HTMLOutputElementValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
	///<include file='Utils/Docs/HTMLOutputElementValidationMessage/HTMLOutputElementValidationMessage.generated.xml' path='docs/HTMLOutputElementValidationMessage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
	///<include file='Utils/Docs/HTMLOutputElementCheckValidity/HTMLOutputElementCheckValidity.generated.xml' path='docs/HTMLOutputElementCheckValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLOutputElementReportValidity/HTMLOutputElementReportValidity.generated.xml' path='docs/HTMLOutputElementReportValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLOutputElementSetCustomValidity/HTMLOutputElementSetCustomValidity.generated.xml' path='docs/HTMLOutputElementSetCustomValidity/*'/>
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
	///<include file='Utils/Docs/HTMLProgressElementHTMLProgressElement/HTMLProgressElementHTMLProgressElement.generated.xml' path='docs/HTMLProgressElementHTMLProgressElement/*'/>
	public HTMLProgressElement() { }
	///<include file='Utils/Docs/HTMLProgressElementValue/HTMLProgressElementValue.generated.xml' path='docs/HTMLProgressElementValue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double Value { get; set; }
	///<include file='Utils/Docs/HTMLProgressElementMax/HTMLProgressElementMax.generated.xml' path='docs/HTMLProgressElementMax/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double Max { get; set; }
	///<include file='Utils/Docs/HTMLProgressElementPosition/HTMLProgressElementPosition.generated.xml' path='docs/HTMLProgressElementPosition/*'/>
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
	///<include file='Utils/Docs/HTMLMeterElementHTMLMeterElement/HTMLMeterElementHTMLMeterElement.generated.xml' path='docs/HTMLMeterElementHTMLMeterElement/*'/>
	public HTMLMeterElement() { }
	///<include file='Utils/Docs/HTMLMeterElementValue/HTMLMeterElementValue.generated.xml' path='docs/HTMLMeterElementValue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double Value { get; set; }
	///<include file='Utils/Docs/HTMLMeterElementMin/HTMLMeterElementMin.generated.xml' path='docs/HTMLMeterElementMin/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double Min { get; set; }
	///<include file='Utils/Docs/HTMLMeterElementMax/HTMLMeterElementMax.generated.xml' path='docs/HTMLMeterElementMax/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double Max { get; set; }
	///<include file='Utils/Docs/HTMLMeterElementLow/HTMLMeterElementLow.generated.xml' path='docs/HTMLMeterElementLow/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double Low { get; set; }
	///<include file='Utils/Docs/HTMLMeterElementHigh/HTMLMeterElementHigh.generated.xml' path='docs/HTMLMeterElementHigh/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public double High { get; set; }
	///<include file='Utils/Docs/HTMLMeterElementOptimum/HTMLMeterElementOptimum.generated.xml' path='docs/HTMLMeterElementOptimum/*'/>
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
	///<include file='Utils/Docs/HTMLFieldSetElementHTMLFieldSetElement/HTMLFieldSetElementHTMLFieldSetElement.generated.xml' path='docs/HTMLFieldSetElementHTMLFieldSetElement/*'/>
	public HTMLFieldSetElement() { }
	///<include file='Utils/Docs/HTMLFieldSetElementDisabled/HTMLFieldSetElementDisabled.generated.xml' path='docs/HTMLFieldSetElementDisabled/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Disabled { get; set; }
	///<include file='Utils/Docs/HTMLFieldSetElementForm/HTMLFieldSetElementForm.generated.xml' path='docs/HTMLFieldSetElementForm/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
	///<include file='Utils/Docs/HTMLFieldSetElementName/HTMLFieldSetElementName.generated.xml' path='docs/HTMLFieldSetElementName/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	///<include file='Utils/Docs/HTMLFieldSetElementType/HTMLFieldSetElementType.generated.xml' path='docs/HTMLFieldSetElementType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; }
	///<include file='Utils/Docs/HTMLFieldSetElementElements/HTMLFieldSetElementElements.generated.xml' path='docs/HTMLFieldSetElementElements/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLCollection Elements { get; }
	///<include file='Utils/Docs/HTMLFieldSetElementWillValidate/HTMLFieldSetElementWillValidate.generated.xml' path='docs/HTMLFieldSetElementWillValidate/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool WillValidate { get; }
	///<include file='Utils/Docs/HTMLFieldSetElementValidity/HTMLFieldSetElementValidity.generated.xml' path='docs/HTMLFieldSetElementValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ValidityState Validity { get; }
	///<include file='Utils/Docs/HTMLFieldSetElementValidationMessage/HTMLFieldSetElementValidationMessage.generated.xml' path='docs/HTMLFieldSetElementValidationMessage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ValidationMessage { get; }
	///<include file='Utils/Docs/HTMLFieldSetElementCheckValidity/HTMLFieldSetElementCheckValidity.generated.xml' path='docs/HTMLFieldSetElementCheckValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool CheckValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLFieldSetElementReportValidity/HTMLFieldSetElementReportValidity.generated.xml' path='docs/HTMLFieldSetElementReportValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool ReportValidity() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLFieldSetElementSetCustomValidity/HTMLFieldSetElementSetCustomValidity.generated.xml' path='docs/HTMLFieldSetElementSetCustomValidity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined SetCustomValidity(string error) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLLegendElement/HTMLLegendElement.generated.xml' path='docs/HTMLLegendElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLLegendElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLLegendElementHTMLLegendElement/HTMLLegendElementHTMLLegendElement.generated.xml' path='docs/HTMLLegendElementHTMLLegendElement/*'/>
	public HTMLLegendElement() { }
	///<include file='Utils/Docs/HTMLLegendElementForm/HTMLLegendElementForm.generated.xml' path='docs/HTMLLegendElementForm/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public HTMLFormElement? Form { get; }
}

///<include file='Utils/Docs/SelectionMode/SelectionMode.generated.xml' path='docs/SelectionMode/*'/>
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
	///<include file='Utils/Docs/ValidityStateCustomError/ValidityStateCustomError.generated.xml' path='docs/ValidityStateCustomError/*'/>
	public bool CustomError { get; }
	///<include file='Utils/Docs/ValidityStateValid/ValidityStateValid.generated.xml' path='docs/ValidityStateValid/*'/>
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

///<include file='Utils/Docs/SubmitEventInit/SubmitEventInit.generated.xml' path='docs/SubmitEventInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class SubmitEventInit : EventInit
{
	///<include file='Utils/Docs/SubmitEventInitSubmitter/SubmitEventInitSubmitter.generated.xml' path='docs/SubmitEventInitSubmitter/*'/>
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

///<include file='Utils/Docs/FormDataEventInit/FormDataEventInit.generated.xml' path='docs/FormDataEventInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FormDataEventInit : EventInit
{
	///<include file='Utils/Docs/FormDataEventInitFormData/FormDataEventInitFormData.generated.xml' path='docs/FormDataEventInitFormData/*'/>
	public required FormData FormData;
}

///<include file='Utils/Docs/HTMLDetailsElement/HTMLDetailsElement.generated.xml' path='docs/HTMLDetailsElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLDetailsElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLDetailsElementHTMLDetailsElement/HTMLDetailsElementHTMLDetailsElement.generated.xml' path='docs/HTMLDetailsElementHTMLDetailsElement/*'/>
	public HTMLDetailsElement() { }
	///<include file='Utils/Docs/HTMLDetailsElementOpen/HTMLDetailsElementOpen.generated.xml' path='docs/HTMLDetailsElementOpen/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Open { get; set; }
}

///<include file='Utils/Docs/HTMLDialogElement/HTMLDialogElement.generated.xml' path='docs/HTMLDialogElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLDialogElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLDialogElementHTMLDialogElement/HTMLDialogElementHTMLDialogElement.generated.xml' path='docs/HTMLDialogElementHTMLDialogElement/*'/>
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
	///<include file='Utils/Docs/HTMLScriptElementHTMLScriptElement/HTMLScriptElementHTMLScriptElement.generated.xml' path='docs/HTMLScriptElementHTMLScriptElement/*'/>
	public HTMLScriptElement() { }
	///<include file='Utils/Docs/HTMLScriptElementSrc/HTMLScriptElementSrc.generated.xml' path='docs/HTMLScriptElementSrc/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	///<include file='Utils/Docs/HTMLScriptElementType/HTMLScriptElementType.generated.xml' path='docs/HTMLScriptElementType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
	///<include file='Utils/Docs/HTMLScriptElementNoModule/HTMLScriptElementNoModule.generated.xml' path='docs/HTMLScriptElementNoModule/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool NoModule { get; set; }
	///<include file='Utils/Docs/HTMLScriptElementAsync/HTMLScriptElementAsync.generated.xml' path='docs/HTMLScriptElementAsync/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Async { get; set; }
	///<include file='Utils/Docs/HTMLScriptElementDefer/HTMLScriptElementDefer.generated.xml' path='docs/HTMLScriptElementDefer/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Defer { get; set; }
	///<include file='Utils/Docs/HTMLScriptElementCrossOrigin/HTMLScriptElementCrossOrigin.generated.xml' path='docs/HTMLScriptElementCrossOrigin/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string? CrossOrigin { get; set; }
	///<include file='Utils/Docs/HTMLScriptElementText/HTMLScriptElementText.generated.xml' path='docs/HTMLScriptElementText/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Text { get; set; }
	///<include file='Utils/Docs/HTMLScriptElementIntegrity/HTMLScriptElementIntegrity.generated.xml' path='docs/HTMLScriptElementIntegrity/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Integrity { get; set; }
	///<include file='Utils/Docs/HTMLScriptElementReferrerPolicy/HTMLScriptElementReferrerPolicy.generated.xml' path='docs/HTMLScriptElementReferrerPolicy/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ReferrerPolicy { get; set; }
	///<include file='Utils/Docs/HTMLScriptElementBlocking/HTMLScriptElementBlocking.generated.xml' path='docs/HTMLScriptElementBlocking/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public DOMTokenList Blocking { get; }
	///<include file='Utils/Docs/HTMLScriptElementSupports/HTMLScriptElementSupports.generated.xml' path='docs/HTMLScriptElementSupports/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public static bool Supports(string type) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLTemplateElement/HTMLTemplateElement.generated.xml' path='docs/HTMLTemplateElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLTemplateElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLTemplateElementHTMLTemplateElement/HTMLTemplateElementHTMLTemplateElement.generated.xml' path='docs/HTMLTemplateElementHTMLTemplateElement/*'/>
	public HTMLTemplateElement() { }
	///<include file='Utils/Docs/HTMLTemplateElementContent/HTMLTemplateElementContent.generated.xml' path='docs/HTMLTemplateElementContent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public DocumentFragment Content { get; }
}

///<include file='Utils/Docs/HTMLSlotElement/HTMLSlotElement.generated.xml' path='docs/HTMLSlotElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLSlotElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLSlotElementHTMLSlotElement/HTMLSlotElementHTMLSlotElement.generated.xml' path='docs/HTMLSlotElementHTMLSlotElement/*'/>
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

///<include file='Utils/Docs/AssignedNodesOptions/AssignedNodesOptions.generated.xml' path='docs/AssignedNodesOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class AssignedNodesOptions
{
	///<include file='Utils/Docs/AssignedNodesOptionsFlatten/AssignedNodesOptionsFlatten.generated.xml' path='docs/AssignedNodesOptionsFlatten/*'/>
	public bool Flatten;
}


///<include file='Utils/Docs/HTMLCanvasElement/HTMLCanvasElement.generated.xml' path='docs/HTMLCanvasElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLCanvasElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLCanvasElementHTMLCanvasElement/HTMLCanvasElementHTMLCanvasElement.generated.xml' path='docs/HTMLCanvasElementHTMLCanvasElement/*'/>
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

///<include file='Utils/Docs/BlobCallback/BlobCallback.generated.xml' path='docs/BlobCallback/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public struct BlobCallback
{
}



///<include file='Utils/Docs/PredefinedColorSpace/PredefinedColorSpace.generated.xml' path='docs/PredefinedColorSpace/*'/>
public enum PredefinedColorSpace
{
	Srgb,
	DisplayP3,
}

///<include file='Utils/Docs/CanvasFillRule/CanvasFillRule.generated.xml' path='docs/CanvasFillRule/*'/>
public enum CanvasFillRule
{
	Nonzero,
	Evenodd,
}

///<include file='Utils/Docs/CanvasRenderingContext2DSettings/CanvasRenderingContext2DSettings.generated.xml' path='docs/CanvasRenderingContext2DSettings/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CanvasRenderingContext2DSettings
{
	///<include file='Utils/Docs/CanvasRenderingContext2DSettingsAlpha/CanvasRenderingContext2DSettingsAlpha.generated.xml' path='docs/CanvasRenderingContext2DSettingsAlpha/*'/>
	public bool Alpha;
	///<include file='Utils/Docs/CanvasRenderingContext2DSettingsDesynchronized/CanvasRenderingContext2DSettingsDesynchronized.generated.xml' path='docs/CanvasRenderingContext2DSettingsDesynchronized/*'/>
	public bool Desynchronized;
	///<include file='Utils/Docs/CanvasRenderingContext2DSettingsColorSpace/CanvasRenderingContext2DSettingsColorSpace.generated.xml' path='docs/CanvasRenderingContext2DSettingsColorSpace/*'/>
	public PredefinedColorSpace ColorSpace;
	///<include file='Utils/Docs/CanvasRenderingContext2DSettingsWillReadFrequently/CanvasRenderingContext2DSettingsWillReadFrequently.generated.xml' path='docs/CanvasRenderingContext2DSettingsWillReadFrequently/*'/>
	public bool WillReadFrequently;
}

///<include file='Utils/Docs/ImageSmoothingQuality/ImageSmoothingQuality.generated.xml' path='docs/ImageSmoothingQuality/*'/>
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

















///<include file='Utils/Docs/CanvasState/CanvasState.generated.xml' path='docs/CanvasState/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasState
{
	///<include file='Utils/Docs/CanvasStateSave/CanvasStateSave.generated.xml' path='docs/CanvasStateSave/*'/>
	public Undefined Save() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasStateRestore/CanvasStateRestore.generated.xml' path='docs/CanvasStateRestore/*'/>
	public Undefined Restore() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasStateReset/CanvasStateReset.generated.xml' path='docs/CanvasStateReset/*'/>
	public Undefined Reset() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasStateIsContextLost/CanvasStateIsContextLost.generated.xml' path='docs/CanvasStateIsContextLost/*'/>
	public bool IsContextLost() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/CanvasTransform/CanvasTransform.generated.xml' path='docs/CanvasTransform/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasTransform
{
	///<include file='Utils/Docs/CanvasTransformScale/CanvasTransformScale.generated.xml' path='docs/CanvasTransformScale/*'/>
	public Undefined Scale(double x, double y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasTransformRotate/CanvasTransformRotate.generated.xml' path='docs/CanvasTransformRotate/*'/>
	public Undefined Rotate(double angle) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasTransformTranslate/CanvasTransformTranslate.generated.xml' path='docs/CanvasTransformTranslate/*'/>
	public Undefined Translate(double x, double y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasTransformTransform/CanvasTransformTransform.generated.xml' path='docs/CanvasTransformTransform/*'/>
	public Undefined Transform(double a, double b, double c, double d, double e, double f) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasTransformGetTransform/CanvasTransformGetTransform.generated.xml' path='docs/CanvasTransformGetTransform/*'/>
	public Unsupported /*DOMMatrix*/ GetTransform() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasTransformSetTransform/CanvasTransformSetTransform.generated.xml' path='docs/CanvasTransformSetTransform/*'/>
	public Undefined SetTransform(double a, double b, double c, double d, double e, double f) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasTransformSetTransform/CanvasTransformSetTransform.generated.xml' path='docs/CanvasTransformSetTransform/*'/>
	public Undefined SetTransform(Unsupported /*DOMMatrix2DInit*/ transform) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasTransformResetTransform/CanvasTransformResetTransform.generated.xml' path='docs/CanvasTransformResetTransform/*'/>
	public Undefined ResetTransform() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/CanvasCompositing/CanvasCompositing.generated.xml' path='docs/CanvasCompositing/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasCompositing
{
	///<include file='Utils/Docs/CanvasCompositingGlobalAlpha/CanvasCompositingGlobalAlpha.generated.xml' path='docs/CanvasCompositingGlobalAlpha/*'/>
	public double GlobalAlpha { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasCompositingGlobalCompositeOperation/CanvasCompositingGlobalCompositeOperation.generated.xml' path='docs/CanvasCompositingGlobalCompositeOperation/*'/>
	public string GlobalCompositeOperation { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/CanvasImageSmoothing/CanvasImageSmoothing.generated.xml' path='docs/CanvasImageSmoothing/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasImageSmoothing
{
	///<include file='Utils/Docs/CanvasImageSmoothingImageSmoothingEnabled/CanvasImageSmoothingImageSmoothingEnabled.generated.xml' path='docs/CanvasImageSmoothingImageSmoothingEnabled/*'/>
	public bool ImageSmoothingEnabled { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasImageSmoothingImageSmoothingQuality/CanvasImageSmoothingImageSmoothingQuality.generated.xml' path='docs/CanvasImageSmoothingImageSmoothingQuality/*'/>
	public ImageSmoothingQuality ImageSmoothingQuality { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/CanvasFillStrokeStyles/CanvasFillStrokeStyles.generated.xml' path='docs/CanvasFillStrokeStyles/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasFillStrokeStyles
{
	///<include file='Utils/Docs/CanvasFillStrokeStylesStrokeStyle/CanvasFillStrokeStylesStrokeStyle.generated.xml' path='docs/CanvasFillStrokeStylesStrokeStyle/*'/>
	public Union30 StrokeStyle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasFillStrokeStylesFillStyle/CanvasFillStrokeStylesFillStyle.generated.xml' path='docs/CanvasFillStrokeStylesFillStyle/*'/>
	public Union31 FillStyle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasFillStrokeStylesCreateLinearGradient/CanvasFillStrokeStylesCreateLinearGradient.generated.xml' path='docs/CanvasFillStrokeStylesCreateLinearGradient/*'/>
	public CanvasGradient CreateLinearGradient(double x0, double y0, double x1, double y1) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasFillStrokeStylesCreateRadialGradient/CanvasFillStrokeStylesCreateRadialGradient.generated.xml' path='docs/CanvasFillStrokeStylesCreateRadialGradient/*'/>
	public CanvasGradient CreateRadialGradient(double x0, double y0, double r0, double x1, double y1, double r1) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasFillStrokeStylesCreateConicGradient/CanvasFillStrokeStylesCreateConicGradient.generated.xml' path='docs/CanvasFillStrokeStylesCreateConicGradient/*'/>
	public CanvasGradient CreateConicGradient(double startAngle, double x, double y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasFillStrokeStylesCreatePattern/CanvasFillStrokeStylesCreatePattern.generated.xml' path='docs/CanvasFillStrokeStylesCreatePattern/*'/>
	public CanvasPattern? CreatePattern(CanvasImageSource image, string repetition) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/CanvasShadowStyles/CanvasShadowStyles.generated.xml' path='docs/CanvasShadowStyles/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasShadowStyles
{
	///<include file='Utils/Docs/CanvasShadowStylesShadowOffsetX/CanvasShadowStylesShadowOffsetX.generated.xml' path='docs/CanvasShadowStylesShadowOffsetX/*'/>
	public double ShadowOffsetX { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasShadowStylesShadowOffsetY/CanvasShadowStylesShadowOffsetY.generated.xml' path='docs/CanvasShadowStylesShadowOffsetY/*'/>
	public double ShadowOffsetY { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasShadowStylesShadowBlur/CanvasShadowStylesShadowBlur.generated.xml' path='docs/CanvasShadowStylesShadowBlur/*'/>
	public double ShadowBlur { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasShadowStylesShadowColor/CanvasShadowStylesShadowColor.generated.xml' path='docs/CanvasShadowStylesShadowColor/*'/>
	public string ShadowColor { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/CanvasFilters/CanvasFilters.generated.xml' path='docs/CanvasFilters/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasFilters
{
	///<include file='Utils/Docs/CanvasFiltersFilter/CanvasFiltersFilter.generated.xml' path='docs/CanvasFiltersFilter/*'/>
	public Union32 Filter { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}


///<include file='Utils/Docs/CanvasFilter/CanvasFilter.generated.xml' path='docs/CanvasFilter/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class CanvasFilter
{
	///<include file='Utils/Docs/CanvasFilterCanvasFilter/CanvasFilterCanvasFilter.generated.xml' path='docs/CanvasFilterCanvasFilter/*'/>
	public CanvasFilter(Union33 filters) { }
}

///<include file='Utils/Docs/CanvasRect/CanvasRect.generated.xml' path='docs/CanvasRect/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasRect
{
	///<include file='Utils/Docs/CanvasRectClearRect/CanvasRectClearRect.generated.xml' path='docs/CanvasRectClearRect/*'/>
	public Undefined ClearRect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasRectFillRect/CanvasRectFillRect.generated.xml' path='docs/CanvasRectFillRect/*'/>
	public Undefined FillRect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasRectStrokeRect/CanvasRectStrokeRect.generated.xml' path='docs/CanvasRectStrokeRect/*'/>
	public Undefined StrokeRect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/CanvasDrawPath/CanvasDrawPath.generated.xml' path='docs/CanvasDrawPath/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasDrawPath
{
	///<include file='Utils/Docs/CanvasDrawPathBeginPath/CanvasDrawPathBeginPath.generated.xml' path='docs/CanvasDrawPathBeginPath/*'/>
	public Undefined BeginPath() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasDrawPathFill/CanvasDrawPathFill.generated.xml' path='docs/CanvasDrawPathFill/*'/>
	public Undefined Fill(CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasDrawPathFill/CanvasDrawPathFill.generated.xml' path='docs/CanvasDrawPathFill/*'/>
	public Undefined Fill(Path2D path, CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasDrawPathStroke/CanvasDrawPathStroke.generated.xml' path='docs/CanvasDrawPathStroke/*'/>
	public Undefined Stroke() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasDrawPathStroke/CanvasDrawPathStroke.generated.xml' path='docs/CanvasDrawPathStroke/*'/>
	public Undefined Stroke(Path2D path) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasDrawPathClip/CanvasDrawPathClip.generated.xml' path='docs/CanvasDrawPathClip/*'/>
	public Undefined Clip(CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasDrawPathClip/CanvasDrawPathClip.generated.xml' path='docs/CanvasDrawPathClip/*'/>
	public Undefined Clip(Path2D path, CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasDrawPathIsPointInPath/CanvasDrawPathIsPointInPath.generated.xml' path='docs/CanvasDrawPathIsPointInPath/*'/>
	public bool IsPointInPath(double x, double y, CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasDrawPathIsPointInPath/CanvasDrawPathIsPointInPath.generated.xml' path='docs/CanvasDrawPathIsPointInPath/*'/>
	public bool IsPointInPath(Path2D path, double x, double y, CanvasFillRule fillRule) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasDrawPathIsPointInStroke/CanvasDrawPathIsPointInStroke.generated.xml' path='docs/CanvasDrawPathIsPointInStroke/*'/>
	public bool IsPointInStroke(double x, double y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasDrawPathIsPointInStroke/CanvasDrawPathIsPointInStroke.generated.xml' path='docs/CanvasDrawPathIsPointInStroke/*'/>
	public bool IsPointInStroke(Path2D path, double x, double y) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/CanvasUserInterface/CanvasUserInterface.generated.xml' path='docs/CanvasUserInterface/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasUserInterface
{
	///<include file='Utils/Docs/CanvasUserInterfaceDrawFocusIfNeeded/CanvasUserInterfaceDrawFocusIfNeeded.generated.xml' path='docs/CanvasUserInterfaceDrawFocusIfNeeded/*'/>
	public Undefined DrawFocusIfNeeded(Element element) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasUserInterfaceDrawFocusIfNeeded/CanvasUserInterfaceDrawFocusIfNeeded.generated.xml' path='docs/CanvasUserInterfaceDrawFocusIfNeeded/*'/>
	public Undefined DrawFocusIfNeeded(Path2D path, Element element) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasUserInterfaceScrollPathIntoView/CanvasUserInterfaceScrollPathIntoView.generated.xml' path='docs/CanvasUserInterfaceScrollPathIntoView/*'/>
	public Undefined ScrollPathIntoView() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasUserInterfaceScrollPathIntoView/CanvasUserInterfaceScrollPathIntoView.generated.xml' path='docs/CanvasUserInterfaceScrollPathIntoView/*'/>
	public Undefined ScrollPathIntoView(Path2D path) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/CanvasText/CanvasText.generated.xml' path='docs/CanvasText/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasText
{
	///<include file='Utils/Docs/CanvasTextFillText/CanvasTextFillText.generated.xml' path='docs/CanvasTextFillText/*'/>
	public Undefined FillText(string text, double x, double y, double maxWidth) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasTextStrokeText/CanvasTextStrokeText.generated.xml' path='docs/CanvasTextStrokeText/*'/>
	public Undefined StrokeText(string text, double x, double y, double maxWidth) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasTextMeasureText/CanvasTextMeasureText.generated.xml' path='docs/CanvasTextMeasureText/*'/>
	public TextMetrics MeasureText(string text) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/CanvasDrawImage/CanvasDrawImage.generated.xml' path='docs/CanvasDrawImage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasDrawImage
{
	///<include file='Utils/Docs/CanvasDrawImageDrawImage/CanvasDrawImageDrawImage.generated.xml' path='docs/CanvasDrawImageDrawImage/*'/>
	public Undefined DrawImage(CanvasImageSource image, double dx, double dy) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasDrawImageDrawImage/CanvasDrawImageDrawImage.generated.xml' path='docs/CanvasDrawImageDrawImage/*'/>
	public Undefined DrawImage(CanvasImageSource image, double dx, double dy, double dw, double dh) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasDrawImageDrawImage/CanvasDrawImageDrawImage.generated.xml' path='docs/CanvasDrawImageDrawImage/*'/>
	public Undefined DrawImage(CanvasImageSource image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/CanvasImageData/CanvasImageData.generated.xml' path='docs/CanvasImageData/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasImageData
{
	///<include file='Utils/Docs/CanvasImageDataCreateImageData/CanvasImageDataCreateImageData.generated.xml' path='docs/CanvasImageDataCreateImageData/*'/>
	public ImageData CreateImageData(long sw, long sh, ImageDataSettings settings) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasImageDataCreateImageData/CanvasImageDataCreateImageData.generated.xml' path='docs/CanvasImageDataCreateImageData/*'/>
	public ImageData CreateImageData(ImageData imagedata) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasImageDataGetImageData/CanvasImageDataGetImageData.generated.xml' path='docs/CanvasImageDataGetImageData/*'/>
	public ImageData GetImageData(long sx, long sy, long sw, long sh, ImageDataSettings settings) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasImageDataPutImageData/CanvasImageDataPutImageData.generated.xml' path='docs/CanvasImageDataPutImageData/*'/>
	public Undefined PutImageData(ImageData imagedata, long dx, long dy) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasImageDataPutImageData/CanvasImageDataPutImageData.generated.xml' path='docs/CanvasImageDataPutImageData/*'/>
	public Undefined PutImageData(ImageData imagedata, long dx, long dy, long dirtyX, long dirtyY, long dirtyWidth, long dirtyHeight) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/CanvasLineCap/CanvasLineCap.generated.xml' path='docs/CanvasLineCap/*'/>
public enum CanvasLineCap
{
	Butt,
	Round,
	Square,
}

///<include file='Utils/Docs/CanvasLineJoin/CanvasLineJoin.generated.xml' path='docs/CanvasLineJoin/*'/>
public enum CanvasLineJoin
{
	Round,
	Bevel,
	Miter,
}

///<include file='Utils/Docs/CanvasTextAlign/CanvasTextAlign.generated.xml' path='docs/CanvasTextAlign/*'/>
public enum CanvasTextAlign
{
	Start,
	End,
	Left,
	Right,
	Center,
}

///<include file='Utils/Docs/CanvasTextBaseline/CanvasTextBaseline.generated.xml' path='docs/CanvasTextBaseline/*'/>
public enum CanvasTextBaseline
{
	Top,
	Hanging,
	Middle,
	Alphabetic,
	Ideographic,
	Bottom,
}

///<include file='Utils/Docs/CanvasDirection/CanvasDirection.generated.xml' path='docs/CanvasDirection/*'/>
public enum CanvasDirection
{
	Ltr,
	Rtl,
	Inherit,
}

///<include file='Utils/Docs/CanvasFontKerning/CanvasFontKerning.generated.xml' path='docs/CanvasFontKerning/*'/>
public enum CanvasFontKerning
{
	Auto,
	Normal,
	None,
}

///<include file='Utils/Docs/CanvasFontStretch/CanvasFontStretch.generated.xml' path='docs/CanvasFontStretch/*'/>
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

///<include file='Utils/Docs/CanvasFontVariantCaps/CanvasFontVariantCaps.generated.xml' path='docs/CanvasFontVariantCaps/*'/>
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

///<include file='Utils/Docs/CanvasTextRendering/CanvasTextRendering.generated.xml' path='docs/CanvasTextRendering/*'/>
public enum CanvasTextRendering
{
	Auto,
	OptimizeSpeed,
	OptimizeLegibility,
	GeometricPrecision,
}

///<include file='Utils/Docs/CanvasPathDrawingStyles/CanvasPathDrawingStyles.generated.xml' path='docs/CanvasPathDrawingStyles/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasPathDrawingStyles
{
	///<include file='Utils/Docs/CanvasPathDrawingStylesLineWidth/CanvasPathDrawingStylesLineWidth.generated.xml' path='docs/CanvasPathDrawingStylesLineWidth/*'/>
	public double LineWidth { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasPathDrawingStylesLineCap/CanvasPathDrawingStylesLineCap.generated.xml' path='docs/CanvasPathDrawingStylesLineCap/*'/>
	public CanvasLineCap LineCap { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasPathDrawingStylesLineJoin/CanvasPathDrawingStylesLineJoin.generated.xml' path='docs/CanvasPathDrawingStylesLineJoin/*'/>
	public CanvasLineJoin LineJoin { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasPathDrawingStylesMiterLimit/CanvasPathDrawingStylesMiterLimit.generated.xml' path='docs/CanvasPathDrawingStylesMiterLimit/*'/>
	public double MiterLimit { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasPathDrawingStylesSetLineDash/CanvasPathDrawingStylesSetLineDash.generated.xml' path='docs/CanvasPathDrawingStylesSetLineDash/*'/>
	public Undefined SetLineDash(List<double> segments) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasPathDrawingStylesGetLineDash/CanvasPathDrawingStylesGetLineDash.generated.xml' path='docs/CanvasPathDrawingStylesGetLineDash/*'/>
	public List<double> GetLineDash() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasPathDrawingStylesLineDashOffset/CanvasPathDrawingStylesLineDashOffset.generated.xml' path='docs/CanvasPathDrawingStylesLineDashOffset/*'/>
	public double LineDashOffset { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/CanvasTextDrawingStyles/CanvasTextDrawingStyles.generated.xml' path='docs/CanvasTextDrawingStyles/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasTextDrawingStyles
{
	///<include file='Utils/Docs/CanvasTextDrawingStylesFont/CanvasTextDrawingStylesFont.generated.xml' path='docs/CanvasTextDrawingStylesFont/*'/>
	public string Font { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasTextDrawingStylesTextAlign/CanvasTextDrawingStylesTextAlign.generated.xml' path='docs/CanvasTextDrawingStylesTextAlign/*'/>
	public CanvasTextAlign TextAlign { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasTextDrawingStylesTextBaseline/CanvasTextDrawingStylesTextBaseline.generated.xml' path='docs/CanvasTextDrawingStylesTextBaseline/*'/>
	public CanvasTextBaseline TextBaseline { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasTextDrawingStylesDirection/CanvasTextDrawingStylesDirection.generated.xml' path='docs/CanvasTextDrawingStylesDirection/*'/>
	public CanvasDirection Direction { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasTextDrawingStylesLetterSpacing/CanvasTextDrawingStylesLetterSpacing.generated.xml' path='docs/CanvasTextDrawingStylesLetterSpacing/*'/>
	public string LetterSpacing { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasTextDrawingStylesFontKerning/CanvasTextDrawingStylesFontKerning.generated.xml' path='docs/CanvasTextDrawingStylesFontKerning/*'/>
	public CanvasFontKerning FontKerning { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasTextDrawingStylesFontStretch/CanvasTextDrawingStylesFontStretch.generated.xml' path='docs/CanvasTextDrawingStylesFontStretch/*'/>
	public CanvasFontStretch FontStretch { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasTextDrawingStylesFontVariantCaps/CanvasTextDrawingStylesFontVariantCaps.generated.xml' path='docs/CanvasTextDrawingStylesFontVariantCaps/*'/>
	public CanvasFontVariantCaps FontVariantCaps { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasTextDrawingStylesTextRendering/CanvasTextDrawingStylesTextRendering.generated.xml' path='docs/CanvasTextDrawingStylesTextRendering/*'/>
	public CanvasTextRendering TextRendering { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/CanvasTextDrawingStylesWordSpacing/CanvasTextDrawingStylesWordSpacing.generated.xml' path='docs/CanvasTextDrawingStylesWordSpacing/*'/>
	public string WordSpacing { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/CanvasPath/CanvasPath.generated.xml' path='docs/CanvasPath/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface CanvasPath
{
	///<include file='Utils/Docs/CanvasPathClosePath/CanvasPathClosePath.generated.xml' path='docs/CanvasPathClosePath/*'/>
	public Undefined ClosePath() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasPathMoveTo/CanvasPathMoveTo.generated.xml' path='docs/CanvasPathMoveTo/*'/>
	public Undefined MoveTo(double x, double y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasPathLineTo/CanvasPathLineTo.generated.xml' path='docs/CanvasPathLineTo/*'/>
	public Undefined LineTo(double x, double y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasPathQuadraticCurveTo/CanvasPathQuadraticCurveTo.generated.xml' path='docs/CanvasPathQuadraticCurveTo/*'/>
	public Undefined QuadraticCurveTo(double cpx, double cpy, double x, double y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasPathBezierCurveTo/CanvasPathBezierCurveTo.generated.xml' path='docs/CanvasPathBezierCurveTo/*'/>
	public Undefined BezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasPathArcTo/CanvasPathArcTo.generated.xml' path='docs/CanvasPathArcTo/*'/>
	public Undefined ArcTo(double x1, double y1, double x2, double y2, double radius) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasPathRect/CanvasPathRect.generated.xml' path='docs/CanvasPathRect/*'/>
	public Undefined Rect(double x, double y, double w, double h) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasPathRoundRect/CanvasPathRoundRect.generated.xml' path='docs/CanvasPathRoundRect/*'/>
	public Undefined RoundRect(double x, double y, double w, double h, Union34 radii) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasPathArc/CanvasPathArc.generated.xml' path='docs/CanvasPathArc/*'/>
	public Undefined Arc(double x, double y, double radius, double startAngle, double endAngle, bool counterclockwise) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/CanvasPathEllipse/CanvasPathEllipse.generated.xml' path='docs/CanvasPathEllipse/*'/>
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

///<include file='Utils/Docs/ImageDataSettings/ImageDataSettings.generated.xml' path='docs/ImageDataSettings/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageDataSettings
{
	///<include file='Utils/Docs/ImageDataSettingsColorSpace/ImageDataSettingsColorSpace.generated.xml' path='docs/ImageDataSettingsColorSpace/*'/>
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
	///<include file='Utils/Docs/ImageBitmapRenderingContextCanvas/ImageBitmapRenderingContextCanvas.generated.xml' path='docs/ImageBitmapRenderingContextCanvas/*'/>
	public Union37 Canvas { get; }
	///<include file='Utils/Docs/ImageBitmapRenderingContextTransferFromImageBitmap/ImageBitmapRenderingContextTransferFromImageBitmap.generated.xml' path='docs/ImageBitmapRenderingContextTransferFromImageBitmap/*'/>
	public Undefined TransferFromImageBitmap(ImageBitmap? bitmap) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/ImageBitmapRenderingContextSettings/ImageBitmapRenderingContextSettings.generated.xml' path='docs/ImageBitmapRenderingContextSettings/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageBitmapRenderingContextSettings
{
	///<include file='Utils/Docs/ImageBitmapRenderingContextSettingsAlpha/ImageBitmapRenderingContextSettingsAlpha.generated.xml' path='docs/ImageBitmapRenderingContextSettingsAlpha/*'/>
	public bool Alpha;
}


///<include file='Utils/Docs/ImageEncodeOptions/ImageEncodeOptions.generated.xml' path='docs/ImageEncodeOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageEncodeOptions
{
	///<include file='Utils/Docs/ImageEncodeOptionsType/ImageEncodeOptionsType.generated.xml' path='docs/ImageEncodeOptionsType/*'/>
	public string Type;
	///<include file='Utils/Docs/ImageEncodeOptionsQuality/ImageEncodeOptionsQuality.generated.xml' path='docs/ImageEncodeOptionsQuality/*'/>
	public double Quality;
}

///<include file='Utils/Docs/OffscreenRenderingContextId/OffscreenRenderingContextId.generated.xml' path='docs/OffscreenRenderingContextId/*'/>
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
	///<include file='Utils/Docs/OffscreenCanvasOncontextlost/OffscreenCanvasOncontextlost.generated.xml' path='docs/OffscreenCanvasOncontextlost/*'/>
	public EventHandler Oncontextlost { get; set; }
	///<include file='Utils/Docs/OffscreenCanvasOncontextrestored/OffscreenCanvasOncontextrestored.generated.xml' path='docs/OffscreenCanvasOncontextrestored/*'/>
	public EventHandler Oncontextrestored { get; set; }
}

///<include file='Utils/Docs/OffscreenCanvasRenderingContext2D/OffscreenCanvasRenderingContext2D.generated.xml' path='docs/OffscreenCanvasRenderingContext2D/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class OffscreenCanvasRenderingContext2D
{
	///<include file='Utils/Docs/OffscreenCanvasRenderingContext2DCommit/OffscreenCanvasRenderingContext2DCommit.generated.xml' path='docs/OffscreenCanvasRenderingContext2DCommit/*'/>
	public Undefined Commit() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/OffscreenCanvasRenderingContext2DCanvas/OffscreenCanvasRenderingContext2DCanvas.generated.xml' path='docs/OffscreenCanvasRenderingContext2DCanvas/*'/>
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

///<include file='Utils/Docs/CustomElementConstructor/CustomElementConstructor.generated.xml' path='docs/CustomElementConstructor/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public struct CustomElementConstructor
{
}

///<include file='Utils/Docs/ElementDefinitionOptions/ElementDefinitionOptions.generated.xml' path='docs/ElementDefinitionOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ElementDefinitionOptions
{
	///<include file='Utils/Docs/ElementDefinitionOptionsExtends/ElementDefinitionOptionsExtends.generated.xml' path='docs/ElementDefinitionOptionsExtends/*'/>
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


///<include file='Utils/Docs/ValidityStateFlags/ValidityStateFlags.generated.xml' path='docs/ValidityStateFlags/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ValidityStateFlags
{
	///<include file='Utils/Docs/ValidityStateFlagsValueMissing/ValidityStateFlagsValueMissing.generated.xml' path='docs/ValidityStateFlagsValueMissing/*'/>
	public bool ValueMissing;
	///<include file='Utils/Docs/ValidityStateFlagsTypeMismatch/ValidityStateFlagsTypeMismatch.generated.xml' path='docs/ValidityStateFlagsTypeMismatch/*'/>
	public bool TypeMismatch;
	///<include file='Utils/Docs/ValidityStateFlagsPatternMismatch/ValidityStateFlagsPatternMismatch.generated.xml' path='docs/ValidityStateFlagsPatternMismatch/*'/>
	public bool PatternMismatch;
	///<include file='Utils/Docs/ValidityStateFlagsTooLong/ValidityStateFlagsTooLong.generated.xml' path='docs/ValidityStateFlagsTooLong/*'/>
	public bool TooLong;
	///<include file='Utils/Docs/ValidityStateFlagsTooShort/ValidityStateFlagsTooShort.generated.xml' path='docs/ValidityStateFlagsTooShort/*'/>
	public bool TooShort;
	///<include file='Utils/Docs/ValidityStateFlagsRangeUnderflow/ValidityStateFlagsRangeUnderflow.generated.xml' path='docs/ValidityStateFlagsRangeUnderflow/*'/>
	public bool RangeUnderflow;
	///<include file='Utils/Docs/ValidityStateFlagsRangeOverflow/ValidityStateFlagsRangeOverflow.generated.xml' path='docs/ValidityStateFlagsRangeOverflow/*'/>
	public bool RangeOverflow;
	///<include file='Utils/Docs/ValidityStateFlagsStepMismatch/ValidityStateFlagsStepMismatch.generated.xml' path='docs/ValidityStateFlagsStepMismatch/*'/>
	public bool StepMismatch;
	///<include file='Utils/Docs/ValidityStateFlagsBadInput/ValidityStateFlagsBadInput.generated.xml' path='docs/ValidityStateFlagsBadInput/*'/>
	public bool BadInput;
	///<include file='Utils/Docs/ValidityStateFlagsCustomError/ValidityStateFlagsCustomError.generated.xml' path='docs/ValidityStateFlagsCustomError/*'/>
	public bool CustomError;
}

///<include file='Utils/Docs/FocusOptions/FocusOptions.generated.xml' path='docs/FocusOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class FocusOptions
{
	///<include file='Utils/Docs/FocusOptionsPreventScroll/FocusOptionsPreventScroll.generated.xml' path='docs/FocusOptionsPreventScroll/*'/>
	public bool PreventScroll;
	///<include file='Utils/Docs/FocusOptionsFocusVisible/FocusOptionsFocusVisible.generated.xml' path='docs/FocusOptionsFocusVisible/*'/>
	public bool FocusVisible;
}

///<include file='Utils/Docs/ElementContentEditable/ElementContentEditable.generated.xml' path='docs/ElementContentEditable/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface ElementContentEditable
{
	///<include file='Utils/Docs/ElementContentEditableContentEditable/ElementContentEditableContentEditable.generated.xml' path='docs/ElementContentEditableContentEditable/*'/>
	public string ContentEditable { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/ElementContentEditableEnterKeyHint/ElementContentEditableEnterKeyHint.generated.xml' path='docs/ElementContentEditableEnterKeyHint/*'/>
	public string EnterKeyHint { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/ElementContentEditableIsContentEditable/ElementContentEditableIsContentEditable.generated.xml' path='docs/ElementContentEditableIsContentEditable/*'/>
	public bool IsContentEditable { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/ElementContentEditableInputMode/ElementContentEditableInputMode.generated.xml' path='docs/ElementContentEditableInputMode/*'/>
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

///<include file='Utils/Docs/FunctionStringCallback/FunctionStringCallback.generated.xml' path='docs/FunctionStringCallback/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public struct FunctionStringCallback
{
}

///<include file='Utils/Docs/FunctionObjectCallback/FunctionObjectCallback.generated.xml' path='docs/FunctionObjectCallback/*'/>
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

///<include file='Utils/Docs/DragEventInit/DragEventInit.generated.xml' path='docs/DragEventInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class DragEventInit
{
	///<include file='Utils/Docs/DragEventInitDataTransfer/DragEventInitDataTransfer.generated.xml' path='docs/DragEventInitDataTransfer/*'/>
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
	///<include file='Utils/Docs/WindowClientInformation/WindowClientInformation.generated.xml' path='docs/WindowClientInformation/*'/>
	public Navigator ClientInformation { get; }
	///<include file='Utils/Docs/WindowOriginAgentCluster/WindowOriginAgentCluster.generated.xml' path='docs/WindowOriginAgentCluster/*'/>
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



///<include file='Utils/Docs/WindowPostMessageOptions/WindowPostMessageOptions.generated.xml' path='docs/WindowPostMessageOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WindowPostMessageOptions : StructuredSerializeOptions
{
	///<include file='Utils/Docs/WindowPostMessageOptionsTargetOrigin/WindowPostMessageOptionsTargetOrigin.generated.xml' path='docs/WindowPostMessageOptionsTargetOrigin/*'/>
	public string TargetOrigin;
}

///<include file='Utils/Docs/BarProp/BarProp.generated.xml' path='docs/BarProp/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class BarProp
{
	///<include file='Utils/Docs/BarPropVisible/BarPropVisible.generated.xml' path='docs/BarPropVisible/*'/>
	public bool Visible { get; }
}

///<include file='Utils/Docs/ScrollRestoration/ScrollRestoration.generated.xml' path='docs/ScrollRestoration/*'/>
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

///<include file='Utils/Docs/PopStateEventInit/PopStateEventInit.generated.xml' path='docs/PopStateEventInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PopStateEventInit : EventInit
{
	///<include file='Utils/Docs/PopStateEventInitState/PopStateEventInitState.generated.xml' path='docs/PopStateEventInitState/*'/>
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

///<include file='Utils/Docs/HashChangeEventInit/HashChangeEventInit.generated.xml' path='docs/HashChangeEventInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class HashChangeEventInit : EventInit
{
	///<include file='Utils/Docs/HashChangeEventInitOldURL/HashChangeEventInitOldURL.generated.xml' path='docs/HashChangeEventInitOldURL/*'/>
	public string OldURL;
	///<include file='Utils/Docs/HashChangeEventInitNewURL/HashChangeEventInitNewURL.generated.xml' path='docs/HashChangeEventInitNewURL/*'/>
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

///<include file='Utils/Docs/PageTransitionEventInit/PageTransitionEventInit.generated.xml' path='docs/PageTransitionEventInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PageTransitionEventInit : EventInit
{
	///<include file='Utils/Docs/PageTransitionEventInitPersisted/PageTransitionEventInitPersisted.generated.xml' path='docs/PageTransitionEventInitPersisted/*'/>
	public bool Persisted;
}

///<include file='Utils/Docs/BeforeUnloadEvent/BeforeUnloadEvent.generated.xml' path='docs/BeforeUnloadEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class BeforeUnloadEvent : Event
{
	///<include file='Utils/Docs/BeforeUnloadEventReturnValue/BeforeUnloadEventReturnValue.generated.xml' path='docs/BeforeUnloadEventReturnValue/*'/>
	public string ReturnValue { get; set; }
}

///<include file='Utils/Docs/ErrorEvent/ErrorEvent.generated.xml' path='docs/ErrorEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ErrorEvent : Event
{
	///<include file='Utils/Docs/ErrorEventErrorEvent/ErrorEventErrorEvent.generated.xml' path='docs/ErrorEventErrorEvent/*'/>
	public ErrorEvent(string type, ErrorEventInit eventInitDict) { }
	///<include file='Utils/Docs/ErrorEventMessage/ErrorEventMessage.generated.xml' path='docs/ErrorEventMessage/*'/>
	public string Message { get; }
	///<include file='Utils/Docs/ErrorEventFilename/ErrorEventFilename.generated.xml' path='docs/ErrorEventFilename/*'/>
	public string Filename { get; }
	///<include file='Utils/Docs/ErrorEventLineno/ErrorEventLineno.generated.xml' path='docs/ErrorEventLineno/*'/>
	public ulong Lineno { get; }
	///<include file='Utils/Docs/ErrorEventColno/ErrorEventColno.generated.xml' path='docs/ErrorEventColno/*'/>
	public ulong Colno { get; }
	///<include file='Utils/Docs/ErrorEventError/ErrorEventError.generated.xml' path='docs/ErrorEventError/*'/>
	public dynamic Error { get; }
}

///<include file='Utils/Docs/ErrorEventInit/ErrorEventInit.generated.xml' path='docs/ErrorEventInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ErrorEventInit : EventInit
{
	///<include file='Utils/Docs/ErrorEventInitMessage/ErrorEventInitMessage.generated.xml' path='docs/ErrorEventInitMessage/*'/>
	public string Message;
	///<include file='Utils/Docs/ErrorEventInitFilename/ErrorEventInitFilename.generated.xml' path='docs/ErrorEventInitFilename/*'/>
	public string Filename;
	///<include file='Utils/Docs/ErrorEventInitLineno/ErrorEventInitLineno.generated.xml' path='docs/ErrorEventInitLineno/*'/>
	public ulong Lineno;
	///<include file='Utils/Docs/ErrorEventInitColno/ErrorEventInitColno.generated.xml' path='docs/ErrorEventInitColno/*'/>
	public ulong Colno;
	///<include file='Utils/Docs/ErrorEventInitError/ErrorEventInitError.generated.xml' path='docs/ErrorEventInitError/*'/>
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

///<include file='Utils/Docs/PromiseRejectionEventInit/PromiseRejectionEventInit.generated.xml' path='docs/PromiseRejectionEventInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PromiseRejectionEventInit : EventInit
{
	///<include file='Utils/Docs/PromiseRejectionEventInitPromise/PromiseRejectionEventInitPromise.generated.xml' path='docs/PromiseRejectionEventInitPromise/*'/>
	public required Task<dynamic> Promise;
	///<include file='Utils/Docs/PromiseRejectionEventInitReason/PromiseRejectionEventInitReason.generated.xml' path='docs/PromiseRejectionEventInitReason/*'/>
	public dynamic Reason;
}

///<include file='Utils/Docs/EventHandlerNonNull/EventHandlerNonNull.generated.xml' path='docs/EventHandlerNonNull/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public struct EventHandlerNonNull
{
}


///<include file='Utils/Docs/OnErrorEventHandlerNonNull/OnErrorEventHandlerNonNull.generated.xml' path='docs/OnErrorEventHandlerNonNull/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public struct OnErrorEventHandlerNonNull
{
}


///<include file='Utils/Docs/OnBeforeUnloadEventHandlerNonNull/OnBeforeUnloadEventHandlerNonNull.generated.xml' path='docs/OnBeforeUnloadEventHandlerNonNull/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public struct OnBeforeUnloadEventHandlerNonNull
{
}


///<include file='Utils/Docs/GlobalEventHandlers/GlobalEventHandlers.generated.xml' path='docs/GlobalEventHandlers/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface GlobalEventHandlers
{
	///<include file='Utils/Docs/GlobalEventHandlersOnabort/GlobalEventHandlersOnabort.generated.xml' path='docs/GlobalEventHandlersOnabort/*'/>
	public EventHandler Onabort { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnauxclick/GlobalEventHandlersOnauxclick.generated.xml' path='docs/GlobalEventHandlersOnauxclick/*'/>
	public EventHandler Onauxclick { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnbeforeinput/GlobalEventHandlersOnbeforeinput.generated.xml' path='docs/GlobalEventHandlersOnbeforeinput/*'/>
	public EventHandler Onbeforeinput { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnbeforematch/GlobalEventHandlersOnbeforematch.generated.xml' path='docs/GlobalEventHandlersOnbeforematch/*'/>
	public EventHandler Onbeforematch { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnblur/GlobalEventHandlersOnblur.generated.xml' path='docs/GlobalEventHandlersOnblur/*'/>
	public EventHandler Onblur { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOncancel/GlobalEventHandlersOncancel.generated.xml' path='docs/GlobalEventHandlersOncancel/*'/>
	public EventHandler Oncancel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOncanplay/GlobalEventHandlersOncanplay.generated.xml' path='docs/GlobalEventHandlersOncanplay/*'/>
	public EventHandler Oncanplay { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOncanplaythrough/GlobalEventHandlersOncanplaythrough.generated.xml' path='docs/GlobalEventHandlersOncanplaythrough/*'/>
	public EventHandler Oncanplaythrough { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnchange/GlobalEventHandlersOnchange.generated.xml' path='docs/GlobalEventHandlersOnchange/*'/>
	public EventHandler Onchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnclick/GlobalEventHandlersOnclick.generated.xml' path='docs/GlobalEventHandlersOnclick/*'/>
	public EventHandler Onclick { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnclose/GlobalEventHandlersOnclose.generated.xml' path='docs/GlobalEventHandlersOnclose/*'/>
	public EventHandler Onclose { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOncontextlost/GlobalEventHandlersOncontextlost.generated.xml' path='docs/GlobalEventHandlersOncontextlost/*'/>
	public EventHandler Oncontextlost { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOncontextmenu/GlobalEventHandlersOncontextmenu.generated.xml' path='docs/GlobalEventHandlersOncontextmenu/*'/>
	public EventHandler Oncontextmenu { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOncontextrestored/GlobalEventHandlersOncontextrestored.generated.xml' path='docs/GlobalEventHandlersOncontextrestored/*'/>
	public EventHandler Oncontextrestored { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOncuechange/GlobalEventHandlersOncuechange.generated.xml' path='docs/GlobalEventHandlersOncuechange/*'/>
	public EventHandler Oncuechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOndblclick/GlobalEventHandlersOndblclick.generated.xml' path='docs/GlobalEventHandlersOndblclick/*'/>
	public EventHandler Ondblclick { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOndrag/GlobalEventHandlersOndrag.generated.xml' path='docs/GlobalEventHandlersOndrag/*'/>
	public EventHandler Ondrag { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOndragend/GlobalEventHandlersOndragend.generated.xml' path='docs/GlobalEventHandlersOndragend/*'/>
	public EventHandler Ondragend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOndragenter/GlobalEventHandlersOndragenter.generated.xml' path='docs/GlobalEventHandlersOndragenter/*'/>
	public EventHandler Ondragenter { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOndragleave/GlobalEventHandlersOndragleave.generated.xml' path='docs/GlobalEventHandlersOndragleave/*'/>
	public EventHandler Ondragleave { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOndragover/GlobalEventHandlersOndragover.generated.xml' path='docs/GlobalEventHandlersOndragover/*'/>
	public EventHandler Ondragover { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOndragstart/GlobalEventHandlersOndragstart.generated.xml' path='docs/GlobalEventHandlersOndragstart/*'/>
	public EventHandler Ondragstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOndrop/GlobalEventHandlersOndrop.generated.xml' path='docs/GlobalEventHandlersOndrop/*'/>
	public EventHandler Ondrop { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOndurationchange/GlobalEventHandlersOndurationchange.generated.xml' path='docs/GlobalEventHandlersOndurationchange/*'/>
	public EventHandler Ondurationchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnemptied/GlobalEventHandlersOnemptied.generated.xml' path='docs/GlobalEventHandlersOnemptied/*'/>
	public EventHandler Onemptied { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnended/GlobalEventHandlersOnended.generated.xml' path='docs/GlobalEventHandlersOnended/*'/>
	public EventHandler Onended { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnerror/GlobalEventHandlersOnerror.generated.xml' path='docs/GlobalEventHandlersOnerror/*'/>
	public OnErrorEventHandler Onerror { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnfocus/GlobalEventHandlersOnfocus.generated.xml' path='docs/GlobalEventHandlersOnfocus/*'/>
	public EventHandler Onfocus { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnformdata/GlobalEventHandlersOnformdata.generated.xml' path='docs/GlobalEventHandlersOnformdata/*'/>
	public EventHandler Onformdata { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOninput/GlobalEventHandlersOninput.generated.xml' path='docs/GlobalEventHandlersOninput/*'/>
	public EventHandler Oninput { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOninvalid/GlobalEventHandlersOninvalid.generated.xml' path='docs/GlobalEventHandlersOninvalid/*'/>
	public EventHandler Oninvalid { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnkeydown/GlobalEventHandlersOnkeydown.generated.xml' path='docs/GlobalEventHandlersOnkeydown/*'/>
	public EventHandler Onkeydown { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnkeypress/GlobalEventHandlersOnkeypress.generated.xml' path='docs/GlobalEventHandlersOnkeypress/*'/>
	public EventHandler Onkeypress { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnkeyup/GlobalEventHandlersOnkeyup.generated.xml' path='docs/GlobalEventHandlersOnkeyup/*'/>
	public EventHandler Onkeyup { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnload/GlobalEventHandlersOnload.generated.xml' path='docs/GlobalEventHandlersOnload/*'/>
	public EventHandler Onload { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnloadeddata/GlobalEventHandlersOnloadeddata.generated.xml' path='docs/GlobalEventHandlersOnloadeddata/*'/>
	public EventHandler Onloadeddata { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnloadedmetadata/GlobalEventHandlersOnloadedmetadata.generated.xml' path='docs/GlobalEventHandlersOnloadedmetadata/*'/>
	public EventHandler Onloadedmetadata { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnloadstart/GlobalEventHandlersOnloadstart.generated.xml' path='docs/GlobalEventHandlersOnloadstart/*'/>
	public EventHandler Onloadstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnmousedown/GlobalEventHandlersOnmousedown.generated.xml' path='docs/GlobalEventHandlersOnmousedown/*'/>
	public EventHandler Onmousedown { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnmouseenter/GlobalEventHandlersOnmouseenter.generated.xml' path='docs/GlobalEventHandlersOnmouseenter/*'/>
	public EventHandler Onmouseenter { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnmouseleave/GlobalEventHandlersOnmouseleave.generated.xml' path='docs/GlobalEventHandlersOnmouseleave/*'/>
	public EventHandler Onmouseleave { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnmousemove/GlobalEventHandlersOnmousemove.generated.xml' path='docs/GlobalEventHandlersOnmousemove/*'/>
	public EventHandler Onmousemove { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnmouseout/GlobalEventHandlersOnmouseout.generated.xml' path='docs/GlobalEventHandlersOnmouseout/*'/>
	public EventHandler Onmouseout { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnmouseover/GlobalEventHandlersOnmouseover.generated.xml' path='docs/GlobalEventHandlersOnmouseover/*'/>
	public EventHandler Onmouseover { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnmouseup/GlobalEventHandlersOnmouseup.generated.xml' path='docs/GlobalEventHandlersOnmouseup/*'/>
	public EventHandler Onmouseup { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnpause/GlobalEventHandlersOnpause.generated.xml' path='docs/GlobalEventHandlersOnpause/*'/>
	public EventHandler Onpause { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnplay/GlobalEventHandlersOnplay.generated.xml' path='docs/GlobalEventHandlersOnplay/*'/>
	public EventHandler Onplay { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnplaying/GlobalEventHandlersOnplaying.generated.xml' path='docs/GlobalEventHandlersOnplaying/*'/>
	public EventHandler Onplaying { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnprogress/GlobalEventHandlersOnprogress.generated.xml' path='docs/GlobalEventHandlersOnprogress/*'/>
	public EventHandler Onprogress { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnratechange/GlobalEventHandlersOnratechange.generated.xml' path='docs/GlobalEventHandlersOnratechange/*'/>
	public EventHandler Onratechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnreset/GlobalEventHandlersOnreset.generated.xml' path='docs/GlobalEventHandlersOnreset/*'/>
	public EventHandler Onreset { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnresize/GlobalEventHandlersOnresize.generated.xml' path='docs/GlobalEventHandlersOnresize/*'/>
	public EventHandler Onresize { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnscroll/GlobalEventHandlersOnscroll.generated.xml' path='docs/GlobalEventHandlersOnscroll/*'/>
	public EventHandler Onscroll { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnsecuritypolicyviolation/GlobalEventHandlersOnsecuritypolicyviolation.generated.xml' path='docs/GlobalEventHandlersOnsecuritypolicyviolation/*'/>
	public EventHandler Onsecuritypolicyviolation { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnseeked/GlobalEventHandlersOnseeked.generated.xml' path='docs/GlobalEventHandlersOnseeked/*'/>
	public EventHandler Onseeked { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnseeking/GlobalEventHandlersOnseeking.generated.xml' path='docs/GlobalEventHandlersOnseeking/*'/>
	public EventHandler Onseeking { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnselect/GlobalEventHandlersOnselect.generated.xml' path='docs/GlobalEventHandlersOnselect/*'/>
	public EventHandler Onselect { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnslotchange/GlobalEventHandlersOnslotchange.generated.xml' path='docs/GlobalEventHandlersOnslotchange/*'/>
	public EventHandler Onslotchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnstalled/GlobalEventHandlersOnstalled.generated.xml' path='docs/GlobalEventHandlersOnstalled/*'/>
	public EventHandler Onstalled { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnsubmit/GlobalEventHandlersOnsubmit.generated.xml' path='docs/GlobalEventHandlersOnsubmit/*'/>
	public EventHandler Onsubmit { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnsuspend/GlobalEventHandlersOnsuspend.generated.xml' path='docs/GlobalEventHandlersOnsuspend/*'/>
	public EventHandler Onsuspend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOntimeupdate/GlobalEventHandlersOntimeupdate.generated.xml' path='docs/GlobalEventHandlersOntimeupdate/*'/>
	public EventHandler Ontimeupdate { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOntoggle/GlobalEventHandlersOntoggle.generated.xml' path='docs/GlobalEventHandlersOntoggle/*'/>
	public EventHandler Ontoggle { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnvolumechange/GlobalEventHandlersOnvolumechange.generated.xml' path='docs/GlobalEventHandlersOnvolumechange/*'/>
	public EventHandler Onvolumechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnwaiting/GlobalEventHandlersOnwaiting.generated.xml' path='docs/GlobalEventHandlersOnwaiting/*'/>
	public EventHandler Onwaiting { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnwebkitanimationend/GlobalEventHandlersOnwebkitanimationend.generated.xml' path='docs/GlobalEventHandlersOnwebkitanimationend/*'/>
	public EventHandler Onwebkitanimationend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnwebkitanimationiteration/GlobalEventHandlersOnwebkitanimationiteration.generated.xml' path='docs/GlobalEventHandlersOnwebkitanimationiteration/*'/>
	public EventHandler Onwebkitanimationiteration { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnwebkitanimationstart/GlobalEventHandlersOnwebkitanimationstart.generated.xml' path='docs/GlobalEventHandlersOnwebkitanimationstart/*'/>
	public EventHandler Onwebkitanimationstart { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnwebkittransitionend/GlobalEventHandlersOnwebkittransitionend.generated.xml' path='docs/GlobalEventHandlersOnwebkittransitionend/*'/>
	public EventHandler Onwebkittransitionend { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/GlobalEventHandlersOnwheel/GlobalEventHandlersOnwheel.generated.xml' path='docs/GlobalEventHandlersOnwheel/*'/>
	public EventHandler Onwheel { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/WindowEventHandlers/WindowEventHandlers.generated.xml' path='docs/WindowEventHandlers/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface WindowEventHandlers
{
	///<include file='Utils/Docs/WindowEventHandlersOnafterprint/WindowEventHandlersOnafterprint.generated.xml' path='docs/WindowEventHandlersOnafterprint/*'/>
	public EventHandler Onafterprint { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/WindowEventHandlersOnbeforeprint/WindowEventHandlersOnbeforeprint.generated.xml' path='docs/WindowEventHandlersOnbeforeprint/*'/>
	public EventHandler Onbeforeprint { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/WindowEventHandlersOnbeforeunload/WindowEventHandlersOnbeforeunload.generated.xml' path='docs/WindowEventHandlersOnbeforeunload/*'/>
	public OnBeforeUnloadEventHandler Onbeforeunload { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/WindowEventHandlersOnhashchange/WindowEventHandlersOnhashchange.generated.xml' path='docs/WindowEventHandlersOnhashchange/*'/>
	public EventHandler Onhashchange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/WindowEventHandlersOnlanguagechange/WindowEventHandlersOnlanguagechange.generated.xml' path='docs/WindowEventHandlersOnlanguagechange/*'/>
	public EventHandler Onlanguagechange { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/WindowEventHandlersOnmessage/WindowEventHandlersOnmessage.generated.xml' path='docs/WindowEventHandlersOnmessage/*'/>
	public EventHandler Onmessage { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/WindowEventHandlersOnmessageerror/WindowEventHandlersOnmessageerror.generated.xml' path='docs/WindowEventHandlersOnmessageerror/*'/>
	public EventHandler Onmessageerror { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/WindowEventHandlersOnoffline/WindowEventHandlersOnoffline.generated.xml' path='docs/WindowEventHandlersOnoffline/*'/>
	public EventHandler Onoffline { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/WindowEventHandlersOnonline/WindowEventHandlersOnonline.generated.xml' path='docs/WindowEventHandlersOnonline/*'/>
	public EventHandler Ononline { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/WindowEventHandlersOnpagehide/WindowEventHandlersOnpagehide.generated.xml' path='docs/WindowEventHandlersOnpagehide/*'/>
	public EventHandler Onpagehide { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/WindowEventHandlersOnpageshow/WindowEventHandlersOnpageshow.generated.xml' path='docs/WindowEventHandlersOnpageshow/*'/>
	public EventHandler Onpageshow { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/WindowEventHandlersOnpopstate/WindowEventHandlersOnpopstate.generated.xml' path='docs/WindowEventHandlersOnpopstate/*'/>
	public EventHandler Onpopstate { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/WindowEventHandlersOnrejectionhandled/WindowEventHandlersOnrejectionhandled.generated.xml' path='docs/WindowEventHandlersOnrejectionhandled/*'/>
	public EventHandler Onrejectionhandled { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/WindowEventHandlersOnstorage/WindowEventHandlersOnstorage.generated.xml' path='docs/WindowEventHandlersOnstorage/*'/>
	public EventHandler Onstorage { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/WindowEventHandlersOnunhandledrejection/WindowEventHandlersOnunhandledrejection.generated.xml' path='docs/WindowEventHandlersOnunhandledrejection/*'/>
	public EventHandler Onunhandledrejection { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/WindowEventHandlersOnunload/WindowEventHandlersOnunload.generated.xml' path='docs/WindowEventHandlersOnunload/*'/>
	public EventHandler Onunload { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/DocumentAndElementEventHandlers/DocumentAndElementEventHandlers.generated.xml' path='docs/DocumentAndElementEventHandlers/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface DocumentAndElementEventHandlers
{
	///<include file='Utils/Docs/DocumentAndElementEventHandlersOncopy/DocumentAndElementEventHandlersOncopy.generated.xml' path='docs/DocumentAndElementEventHandlersOncopy/*'/>
	public EventHandler Oncopy { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/DocumentAndElementEventHandlersOncut/DocumentAndElementEventHandlersOncut.generated.xml' path='docs/DocumentAndElementEventHandlersOncut/*'/>
	public EventHandler Oncut { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/DocumentAndElementEventHandlersOnpaste/DocumentAndElementEventHandlersOnpaste.generated.xml' path='docs/DocumentAndElementEventHandlersOnpaste/*'/>
	public EventHandler Onpaste { get { throw new System.NotImplementedException(); } set { throw new System.NotImplementedException(); } }
}


///<include file='Utils/Docs/WindowOrWorkerGlobalScope/WindowOrWorkerGlobalScope.generated.xml' path='docs/WindowOrWorkerGlobalScope/*'/>
public partial interface WindowOrWorkerGlobalScope
{
	///<include file='Utils/Docs/WindowOrWorkerGlobalScopeOrigin/WindowOrWorkerGlobalScopeOrigin.generated.xml' path='docs/WindowOrWorkerGlobalScopeOrigin/*'/>
	public string Origin { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/WindowOrWorkerGlobalScopeIsSecureContext/WindowOrWorkerGlobalScopeIsSecureContext.generated.xml' path='docs/WindowOrWorkerGlobalScopeIsSecureContext/*'/>
	public bool IsSecureContext { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/WindowOrWorkerGlobalScopeCrossOriginIsolated/WindowOrWorkerGlobalScopeCrossOriginIsolated.generated.xml' path='docs/WindowOrWorkerGlobalScopeCrossOriginIsolated/*'/>
	public bool CrossOriginIsolated { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/WindowOrWorkerGlobalScopeReportError/WindowOrWorkerGlobalScopeReportError.generated.xml' path='docs/WindowOrWorkerGlobalScopeReportError/*'/>
	public Undefined ReportError(dynamic e) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowOrWorkerGlobalScopeBtoa/WindowOrWorkerGlobalScopeBtoa.generated.xml' path='docs/WindowOrWorkerGlobalScopeBtoa/*'/>
	public string Btoa(string data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowOrWorkerGlobalScopeAtob/WindowOrWorkerGlobalScopeAtob.generated.xml' path='docs/WindowOrWorkerGlobalScopeAtob/*'/>
	public string Atob(string data) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowOrWorkerGlobalScopeSetTimeout/WindowOrWorkerGlobalScopeSetTimeout.generated.xml' path='docs/WindowOrWorkerGlobalScopeSetTimeout/*'/>
	public long SetTimeout(TimerHandler handler, long timeout, params dynamic[] arguments) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowOrWorkerGlobalScopeClearTimeout/WindowOrWorkerGlobalScopeClearTimeout.generated.xml' path='docs/WindowOrWorkerGlobalScopeClearTimeout/*'/>
	public Undefined ClearTimeout(long id) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowOrWorkerGlobalScopeSetInterval/WindowOrWorkerGlobalScopeSetInterval.generated.xml' path='docs/WindowOrWorkerGlobalScopeSetInterval/*'/>
	public long SetInterval(TimerHandler handler, long timeout, params dynamic[] arguments) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowOrWorkerGlobalScopeClearInterval/WindowOrWorkerGlobalScopeClearInterval.generated.xml' path='docs/WindowOrWorkerGlobalScopeClearInterval/*'/>
	public Undefined ClearInterval(long id) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowOrWorkerGlobalScopeQueueMicrotask/WindowOrWorkerGlobalScopeQueueMicrotask.generated.xml' path='docs/WindowOrWorkerGlobalScopeQueueMicrotask/*'/>
	public Undefined QueueMicrotask(VoidFunction callback) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowOrWorkerGlobalScopeCreateImageBitmap/WindowOrWorkerGlobalScopeCreateImageBitmap.generated.xml' path='docs/WindowOrWorkerGlobalScopeCreateImageBitmap/*'/>
	public Task<ImageBitmap> CreateImageBitmap(ImageBitmapSource image, ImageBitmapOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowOrWorkerGlobalScopeCreateImageBitmap/WindowOrWorkerGlobalScopeCreateImageBitmap.generated.xml' path='docs/WindowOrWorkerGlobalScopeCreateImageBitmap/*'/>
	public Task<ImageBitmap> CreateImageBitmap(ImageBitmapSource image, long sx, long sy, long sw, long sh, ImageBitmapOptions options) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/WindowOrWorkerGlobalScopeStructuredClone/WindowOrWorkerGlobalScopeStructuredClone.generated.xml' path='docs/WindowOrWorkerGlobalScopeStructuredClone/*'/>
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

///<include file='Utils/Docs/DOMParserSupportedType/DOMParserSupportedType.generated.xml' path='docs/DOMParserSupportedType/*'/>
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








///<include file='Utils/Docs/NavigatorID/NavigatorID.generated.xml' path='docs/NavigatorID/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorID
{
	///<include file='Utils/Docs/NavigatorIDAppCodeName/NavigatorIDAppCodeName.generated.xml' path='docs/NavigatorIDAppCodeName/*'/>
	public string AppCodeName { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/NavigatorIDAppName/NavigatorIDAppName.generated.xml' path='docs/NavigatorIDAppName/*'/>
	public string AppName { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/NavigatorIDAppVersion/NavigatorIDAppVersion.generated.xml' path='docs/NavigatorIDAppVersion/*'/>
	public string AppVersion { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/NavigatorIDPlatform/NavigatorIDPlatform.generated.xml' path='docs/NavigatorIDPlatform/*'/>
	public string Platform { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/NavigatorIDProduct/NavigatorIDProduct.generated.xml' path='docs/NavigatorIDProduct/*'/>
	public string Product { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/NavigatorIDProductSub/NavigatorIDProductSub.generated.xml' path='docs/NavigatorIDProductSub/*'/>
	public string ProductSub { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/NavigatorIDUserAgent/NavigatorIDUserAgent.generated.xml' path='docs/NavigatorIDUserAgent/*'/>
	public string UserAgent { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/NavigatorIDVendor/NavigatorIDVendor.generated.xml' path='docs/NavigatorIDVendor/*'/>
	public string Vendor { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/NavigatorIDVendorSub/NavigatorIDVendorSub.generated.xml' path='docs/NavigatorIDVendorSub/*'/>
	public string VendorSub { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NavigatorID/NavigatorID.generated.xml' path='docs/NavigatorID/*'/>
public partial interface NavigatorID
{
	///<include file='Utils/Docs/NavigatorIDTaintEnabled/NavigatorIDTaintEnabled.generated.xml' path='docs/NavigatorIDTaintEnabled/*'/>
	public bool TaintEnabled() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NavigatorIDOscpu/NavigatorIDOscpu.generated.xml' path='docs/NavigatorIDOscpu/*'/>
	public string Oscpu { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NavigatorLanguage/NavigatorLanguage.generated.xml' path='docs/NavigatorLanguage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorLanguage
{
	///<include file='Utils/Docs/NavigatorLanguageLanguage/NavigatorLanguageLanguage.generated.xml' path='docs/NavigatorLanguageLanguage/*'/>
	public string Language { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/NavigatorLanguageLanguages/NavigatorLanguageLanguages.generated.xml' path='docs/NavigatorLanguageLanguages/*'/>
	public string[] Languages { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NavigatorOnLine/NavigatorOnLine.generated.xml' path='docs/NavigatorOnLine/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorOnLine
{
	///<include file='Utils/Docs/NavigatorOnLineOnLine/NavigatorOnLineOnLine.generated.xml' path='docs/NavigatorOnLineOnLine/*'/>
	public bool OnLine { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NavigatorContentUtils/NavigatorContentUtils.generated.xml' path='docs/NavigatorContentUtils/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorContentUtils
{
	///<include file='Utils/Docs/NavigatorContentUtilsRegisterProtocolHandler/NavigatorContentUtilsRegisterProtocolHandler.generated.xml' path='docs/NavigatorContentUtilsRegisterProtocolHandler/*'/>
	public Undefined RegisterProtocolHandler(string scheme, string url) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NavigatorContentUtilsUnregisterProtocolHandler/NavigatorContentUtilsUnregisterProtocolHandler.generated.xml' path='docs/NavigatorContentUtilsUnregisterProtocolHandler/*'/>
	public Undefined UnregisterProtocolHandler(string scheme, string url) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/NavigatorCookies/NavigatorCookies.generated.xml' path='docs/NavigatorCookies/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorCookies
{
	///<include file='Utils/Docs/NavigatorCookiesCookieEnabled/NavigatorCookiesCookieEnabled.generated.xml' path='docs/NavigatorCookiesCookieEnabled/*'/>
	public bool CookieEnabled { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/NavigatorPlugins/NavigatorPlugins.generated.xml' path='docs/NavigatorPlugins/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorPlugins
{
	///<include file='Utils/Docs/NavigatorPluginsPlugins/NavigatorPluginsPlugins.generated.xml' path='docs/NavigatorPluginsPlugins/*'/>
	public PluginArray Plugins { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/NavigatorPluginsMimeTypes/NavigatorPluginsMimeTypes.generated.xml' path='docs/NavigatorPluginsMimeTypes/*'/>
	public MimeTypeArray MimeTypes { get { throw new System.NotImplementedException(); } }
	///<include file='Utils/Docs/NavigatorPluginsJavaEnabled/NavigatorPluginsJavaEnabled.generated.xml' path='docs/NavigatorPluginsJavaEnabled/*'/>
	public bool JavaEnabled() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NavigatorPluginsPdfViewerEnabled/NavigatorPluginsPdfViewerEnabled.generated.xml' path='docs/NavigatorPluginsPdfViewerEnabled/*'/>
	public bool PdfViewerEnabled { get { throw new System.NotImplementedException(); } }
}

///<include file='Utils/Docs/PluginArray/PluginArray.generated.xml' path='docs/PluginArray/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class PluginArray
{
	///<include file='Utils/Docs/PluginArrayRefresh/PluginArrayRefresh.generated.xml' path='docs/PluginArrayRefresh/*'/>
	public Undefined Refresh() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/PluginArrayLength/PluginArrayLength.generated.xml' path='docs/PluginArrayLength/*'/>
	public ulong Length { get; }
	
	
}

///<include file='Utils/Docs/MimeTypeArray/MimeTypeArray.generated.xml' path='docs/MimeTypeArray/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MimeTypeArray
{
	///<include file='Utils/Docs/MimeTypeArrayLength/MimeTypeArrayLength.generated.xml' path='docs/MimeTypeArrayLength/*'/>
	public ulong Length { get; }
	
	
}

///<include file='Utils/Docs/Plugin/Plugin.generated.xml' path='docs/Plugin/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Plugin
{
	///<include file='Utils/Docs/PluginName/PluginName.generated.xml' path='docs/PluginName/*'/>
	public string Name { get; }
	///<include file='Utils/Docs/PluginDescription/PluginDescription.generated.xml' path='docs/PluginDescription/*'/>
	public string Description { get; }
	///<include file='Utils/Docs/PluginFilename/PluginFilename.generated.xml' path='docs/PluginFilename/*'/>
	public string Filename { get; }
	///<include file='Utils/Docs/PluginLength/PluginLength.generated.xml' path='docs/PluginLength/*'/>
	public ulong Length { get; }
	
	
}

///<include file='Utils/Docs/MimeType/MimeType.generated.xml' path='docs/MimeType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MimeType
{
	///<include file='Utils/Docs/MimeTypeType/MimeTypeType.generated.xml' path='docs/MimeTypeType/*'/>
	public string Type { get; }
	///<include file='Utils/Docs/MimeTypeDescription/MimeTypeDescription.generated.xml' path='docs/MimeTypeDescription/*'/>
	public string Description { get; }
	///<include file='Utils/Docs/MimeTypeSuffixes/MimeTypeSuffixes.generated.xml' path='docs/MimeTypeSuffixes/*'/>
	public string Suffixes { get; }
	///<include file='Utils/Docs/MimeTypeEnabledPlugin/MimeTypeEnabledPlugin.generated.xml' path='docs/MimeTypeEnabledPlugin/*'/>
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


///<include file='Utils/Docs/ImageOrientation/ImageOrientation.generated.xml' path='docs/ImageOrientation/*'/>
public enum ImageOrientation
{
	None,
	FlipY,
}

///<include file='Utils/Docs/PremultiplyAlpha/PremultiplyAlpha.generated.xml' path='docs/PremultiplyAlpha/*'/>
public enum PremultiplyAlpha
{
	None,
	Premultiply,
	Default,
}

///<include file='Utils/Docs/ColorSpaceConversion/ColorSpaceConversion.generated.xml' path='docs/ColorSpaceConversion/*'/>
public enum ColorSpaceConversion
{
	None,
	Default,
}

///<include file='Utils/Docs/ResizeQuality/ResizeQuality.generated.xml' path='docs/ResizeQuality/*'/>
public enum ResizeQuality
{
	Pixelated,
	Low,
	Medium,
	High,
}

///<include file='Utils/Docs/ImageBitmapOptions/ImageBitmapOptions.generated.xml' path='docs/ImageBitmapOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ImageBitmapOptions
{
	///<include file='Utils/Docs/ImageBitmapOptionsImageOrientation/ImageBitmapOptionsImageOrientation.generated.xml' path='docs/ImageBitmapOptionsImageOrientation/*'/>
	public ImageOrientation ImageOrientation;
	///<include file='Utils/Docs/ImageBitmapOptionsPremultiplyAlpha/ImageBitmapOptionsPremultiplyAlpha.generated.xml' path='docs/ImageBitmapOptionsPremultiplyAlpha/*'/>
	public PremultiplyAlpha PremultiplyAlpha;
	///<include file='Utils/Docs/ImageBitmapOptionsColorSpaceConversion/ImageBitmapOptionsColorSpaceConversion.generated.xml' path='docs/ImageBitmapOptionsColorSpaceConversion/*'/>
	public ColorSpaceConversion ColorSpaceConversion;
	///<include file='Utils/Docs/ImageBitmapOptionsResizeWidth/ImageBitmapOptionsResizeWidth.generated.xml' path='docs/ImageBitmapOptionsResizeWidth/*'/>
	public ulong ResizeWidth;
	///<include file='Utils/Docs/ImageBitmapOptionsResizeHeight/ImageBitmapOptionsResizeHeight.generated.xml' path='docs/ImageBitmapOptionsResizeHeight/*'/>
	public ulong ResizeHeight;
	///<include file='Utils/Docs/ImageBitmapOptionsResizeQuality/ImageBitmapOptionsResizeQuality.generated.xml' path='docs/ImageBitmapOptionsResizeQuality/*'/>
	public ResizeQuality ResizeQuality;
}

///<include file='Utils/Docs/FrameRequestCallback/FrameRequestCallback.generated.xml' path='docs/FrameRequestCallback/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public struct FrameRequestCallback
{
}

///<include file='Utils/Docs/AnimationFrameProvider/AnimationFrameProvider.generated.xml' path='docs/AnimationFrameProvider/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface AnimationFrameProvider
{
	///<include file='Utils/Docs/AnimationFrameProviderRequestAnimationFrame/AnimationFrameProviderRequestAnimationFrame.generated.xml' path='docs/AnimationFrameProviderRequestAnimationFrame/*'/>
	public ulong RequestAnimationFrame(FrameRequestCallback callback) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/AnimationFrameProviderCancelAnimationFrame/AnimationFrameProviderCancelAnimationFrame.generated.xml' path='docs/AnimationFrameProviderCancelAnimationFrame/*'/>
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
	///<include file='Utils/Docs/MessageEventInitMessageEvent/MessageEventInitMessageEvent.generated.xml' path='docs/MessageEventInitMessageEvent/*'/>
	public Undefined InitMessageEvent(string type, bool bubbles, bool cancelable, dynamic data, string origin, string lastEventId, MessageEventSource? source, List<MessagePort> ports) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/MessageEventInit/MessageEventInit.generated.xml' path='docs/MessageEventInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class MessageEventInit : EventInit
{
	///<include file='Utils/Docs/MessageEventInitData/MessageEventInitData.generated.xml' path='docs/MessageEventInitData/*'/>
	public dynamic Data;
	///<include file='Utils/Docs/MessageEventInitOrigin/MessageEventInitOrigin.generated.xml' path='docs/MessageEventInitOrigin/*'/>
	public string Origin;
	///<include file='Utils/Docs/MessageEventInitLastEventId/MessageEventInitLastEventId.generated.xml' path='docs/MessageEventInitLastEventId/*'/>
	public string LastEventId;
	///<include file='Utils/Docs/MessageEventInitSource/MessageEventInitSource.generated.xml' path='docs/MessageEventInitSource/*'/>
	public MessageEventSource? Source;
	///<include file='Utils/Docs/MessageEventInitPorts/MessageEventInitPorts.generated.xml' path='docs/MessageEventInitPorts/*'/>
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
	///<include file='Utils/Docs/EventSourceCONNECTING/EventSourceCONNECTING.generated.xml' path='docs/EventSourceCONNECTING/*'/>
	public const ushort CONNECTING = 0;
	///<include file='Utils/Docs/EventSourceOPEN/EventSourceOPEN.generated.xml' path='docs/EventSourceOPEN/*'/>
	public const ushort OPEN = 1;
	///<include file='Utils/Docs/EventSourceCLOSED/EventSourceCLOSED.generated.xml' path='docs/EventSourceCLOSED/*'/>
	public const ushort CLOSED = 2;
	///<include file='Utils/Docs/EventSourceReadyState/EventSourceReadyState.generated.xml' path='docs/EventSourceReadyState/*'/>
	public ushort ReadyState { get; }
	///<include file='Utils/Docs/EventSourceOnopen/EventSourceOnopen.generated.xml' path='docs/EventSourceOnopen/*'/>
	public EventHandler Onopen { get; set; }
	///<include file='Utils/Docs/EventSourceOnmessage/EventSourceOnmessage.generated.xml' path='docs/EventSourceOnmessage/*'/>
	public EventHandler Onmessage { get; set; }
	///<include file='Utils/Docs/EventSourceOnerror/EventSourceOnerror.generated.xml' path='docs/EventSourceOnerror/*'/>
	public EventHandler Onerror { get; set; }
	///<include file='Utils/Docs/EventSourceClose/EventSourceClose.generated.xml' path='docs/EventSourceClose/*'/>
	public Undefined Close() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/EventSourceInit/EventSourceInit.generated.xml' path='docs/EventSourceInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class EventSourceInit
{
	///<include file='Utils/Docs/EventSourceInitWithCredentials/EventSourceInitWithCredentials.generated.xml' path='docs/EventSourceInitWithCredentials/*'/>
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
	///<include file='Utils/Docs/MessagePortOnmessage/MessagePortOnmessage.generated.xml' path='docs/MessagePortOnmessage/*'/>
	public EventHandler Onmessage { get; set; }
	///<include file='Utils/Docs/MessagePortOnmessageerror/MessagePortOnmessageerror.generated.xml' path='docs/MessagePortOnmessageerror/*'/>
	public EventHandler Onmessageerror { get; set; }
}

///<include file='Utils/Docs/StructuredSerializeOptions/StructuredSerializeOptions.generated.xml' path='docs/StructuredSerializeOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class StructuredSerializeOptions
{
	///<include file='Utils/Docs/StructuredSerializeOptionsTransfer/StructuredSerializeOptionsTransfer.generated.xml' path='docs/StructuredSerializeOptionsTransfer/*'/>
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
	///<include file='Utils/Docs/BroadcastChannelOnmessage/BroadcastChannelOnmessage.generated.xml' path='docs/BroadcastChannelOnmessage/*'/>
	public EventHandler Onmessage { get; set; }
	///<include file='Utils/Docs/BroadcastChannelOnmessageerror/BroadcastChannelOnmessageerror.generated.xml' path='docs/BroadcastChannelOnmessageerror/*'/>
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
	///<include file='Utils/Docs/WorkerGlobalScopeOnerror/WorkerGlobalScopeOnerror.generated.xml' path='docs/WorkerGlobalScopeOnerror/*'/>
	public OnErrorEventHandler Onerror { get; set; }
	///<include file='Utils/Docs/WorkerGlobalScopeOnlanguagechange/WorkerGlobalScopeOnlanguagechange.generated.xml' path='docs/WorkerGlobalScopeOnlanguagechange/*'/>
	public EventHandler Onlanguagechange { get; set; }
	///<include file='Utils/Docs/WorkerGlobalScopeOnoffline/WorkerGlobalScopeOnoffline.generated.xml' path='docs/WorkerGlobalScopeOnoffline/*'/>
	public EventHandler Onoffline { get; set; }
	///<include file='Utils/Docs/WorkerGlobalScopeOnonline/WorkerGlobalScopeOnonline.generated.xml' path='docs/WorkerGlobalScopeOnonline/*'/>
	public EventHandler Ononline { get; set; }
	///<include file='Utils/Docs/WorkerGlobalScopeOnrejectionhandled/WorkerGlobalScopeOnrejectionhandled.generated.xml' path='docs/WorkerGlobalScopeOnrejectionhandled/*'/>
	public EventHandler Onrejectionhandled { get; set; }
	///<include file='Utils/Docs/WorkerGlobalScopeOnunhandledrejection/WorkerGlobalScopeOnunhandledrejection.generated.xml' path='docs/WorkerGlobalScopeOnunhandledrejection/*'/>
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
	///<include file='Utils/Docs/DedicatedWorkerGlobalScopeOnmessage/DedicatedWorkerGlobalScopeOnmessage.generated.xml' path='docs/DedicatedWorkerGlobalScopeOnmessage/*'/>
	public EventHandler Onmessage { get; set; }
	///<include file='Utils/Docs/DedicatedWorkerGlobalScopeOnmessageerror/DedicatedWorkerGlobalScopeOnmessageerror.generated.xml' path='docs/DedicatedWorkerGlobalScopeOnmessageerror/*'/>
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
	///<include file='Utils/Docs/SharedWorkerGlobalScopeOnconnect/SharedWorkerGlobalScopeOnconnect.generated.xml' path='docs/SharedWorkerGlobalScopeOnconnect/*'/>
	public EventHandler Onconnect { get; set; }
}

///<include file='Utils/Docs/AbstractWorker/AbstractWorker.generated.xml' path='docs/AbstractWorker/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface AbstractWorker
{
	///<include file='Utils/Docs/AbstractWorkerOnerror/AbstractWorkerOnerror.generated.xml' path='docs/AbstractWorkerOnerror/*'/>
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
	///<include file='Utils/Docs/WorkerOnmessage/WorkerOnmessage.generated.xml' path='docs/WorkerOnmessage/*'/>
	public EventHandler Onmessage { get; set; }
	///<include file='Utils/Docs/WorkerOnmessageerror/WorkerOnmessageerror.generated.xml' path='docs/WorkerOnmessageerror/*'/>
	public EventHandler Onmessageerror { get; set; }
}

///<include file='Utils/Docs/WorkerOptions/WorkerOptions.generated.xml' path='docs/WorkerOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WorkerOptions
{
	///<include file='Utils/Docs/WorkerOptionsType/WorkerOptionsType.generated.xml' path='docs/WorkerOptionsType/*'/>
	public WorkerType Type;
	///<include file='Utils/Docs/WorkerOptionsCredentials/WorkerOptionsCredentials.generated.xml' path='docs/WorkerOptionsCredentials/*'/>
	public RequestCredentials Credentials;
	///<include file='Utils/Docs/WorkerOptionsName/WorkerOptionsName.generated.xml' path='docs/WorkerOptionsName/*'/>
	public string Name;
}

///<include file='Utils/Docs/WorkerType/WorkerType.generated.xml' path='docs/WorkerType/*'/>
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


///<include file='Utils/Docs/NavigatorConcurrentHardware/NavigatorConcurrentHardware.generated.xml' path='docs/NavigatorConcurrentHardware/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorConcurrentHardware
{
	///<include file='Utils/Docs/NavigatorConcurrentHardwareHardwareConcurrency/NavigatorConcurrentHardwareHardwareConcurrency.generated.xml' path='docs/NavigatorConcurrentHardwareHardwareConcurrency/*'/>
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

///<include file='Utils/Docs/WorkletOptions/WorkletOptions.generated.xml' path='docs/WorkletOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class WorkletOptions
{
	///<include file='Utils/Docs/WorkletOptionsCredentials/WorkletOptionsCredentials.generated.xml' path='docs/WorkletOptionsCredentials/*'/>
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
	///<include file='Utils/Docs/WindowSessionStorageSessionStorage/WindowSessionStorageSessionStorage.generated.xml' path='docs/WindowSessionStorageSessionStorage/*'/>
	public Storage SessionStorage { get { throw new System.NotImplementedException(); } }
}


///<include file='Utils/Docs/WindowLocalStorage/WindowLocalStorage.generated.xml' path='docs/WindowLocalStorage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface WindowLocalStorage
{
	///<include file='Utils/Docs/WindowLocalStorageLocalStorage/WindowLocalStorageLocalStorage.generated.xml' path='docs/WindowLocalStorageLocalStorage/*'/>
	public Storage LocalStorage { get { throw new System.NotImplementedException(); } }
}


///<include file='Utils/Docs/StorageEvent/StorageEvent.generated.xml' path='docs/StorageEvent/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class StorageEvent : Event
{
	///<include file='Utils/Docs/StorageEventStorageEvent/StorageEventStorageEvent.generated.xml' path='docs/StorageEventStorageEvent/*'/>
	public StorageEvent(string type, StorageEventInit eventInitDict) { }
	///<include file='Utils/Docs/StorageEventKey/StorageEventKey.generated.xml' path='docs/StorageEventKey/*'/>
	public string? Key { get; }
	///<include file='Utils/Docs/StorageEventOldValue/StorageEventOldValue.generated.xml' path='docs/StorageEventOldValue/*'/>
	public string? OldValue { get; }
	///<include file='Utils/Docs/StorageEventNewValue/StorageEventNewValue.generated.xml' path='docs/StorageEventNewValue/*'/>
	public string? NewValue { get; }
	///<include file='Utils/Docs/StorageEventUrl/StorageEventUrl.generated.xml' path='docs/StorageEventUrl/*'/>
	public string Url { get; }
	///<include file='Utils/Docs/StorageEventStorageArea/StorageEventStorageArea.generated.xml' path='docs/StorageEventStorageArea/*'/>
	public Storage? StorageArea { get; }
	///<include file='Utils/Docs/StorageEventInitStorageEvent/StorageEventInitStorageEvent.generated.xml' path='docs/StorageEventInitStorageEvent/*'/>
	public Undefined InitStorageEvent(string type, bool bubbles, bool cancelable, string? key, string? oldValue, string? newValue, string url, Storage? storageArea) { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/StorageEventInit/StorageEventInit.generated.xml' path='docs/StorageEventInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class StorageEventInit : EventInit
{
	///<include file='Utils/Docs/StorageEventInitKey/StorageEventInitKey.generated.xml' path='docs/StorageEventInitKey/*'/>
	public string? Key;
	///<include file='Utils/Docs/StorageEventInitOldValue/StorageEventInitOldValue.generated.xml' path='docs/StorageEventInitOldValue/*'/>
	public string? OldValue;
	///<include file='Utils/Docs/StorageEventInitNewValue/StorageEventInitNewValue.generated.xml' path='docs/StorageEventInitNewValue/*'/>
	public string? NewValue;
	///<include file='Utils/Docs/StorageEventInitUrl/StorageEventInitUrl.generated.xml' path='docs/StorageEventInitUrl/*'/>
	public string Url;
	///<include file='Utils/Docs/StorageEventInitStorageArea/StorageEventInitStorageArea.generated.xml' path='docs/StorageEventInitStorageArea/*'/>
	public Storage? StorageArea;
}

///<include file='Utils/Docs/HTMLMarqueeElement/HTMLMarqueeElement.generated.xml' path='docs/HTMLMarqueeElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLMarqueeElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLMarqueeElementHTMLMarqueeElement/HTMLMarqueeElementHTMLMarqueeElement.generated.xml' path='docs/HTMLMarqueeElementHTMLMarqueeElement/*'/>
	public HTMLMarqueeElement() { }
	///<include file='Utils/Docs/HTMLMarqueeElementBehavior/HTMLMarqueeElementBehavior.generated.xml' path='docs/HTMLMarqueeElementBehavior/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Behavior { get; set; }
	///<include file='Utils/Docs/HTMLMarqueeElementBgColor/HTMLMarqueeElementBgColor.generated.xml' path='docs/HTMLMarqueeElementBgColor/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string BgColor { get; set; }
	///<include file='Utils/Docs/HTMLMarqueeElementDirection/HTMLMarqueeElementDirection.generated.xml' path='docs/HTMLMarqueeElementDirection/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Direction { get; set; }
	///<include file='Utils/Docs/HTMLMarqueeElementHeight/HTMLMarqueeElementHeight.generated.xml' path='docs/HTMLMarqueeElementHeight/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Height { get; set; }
	///<include file='Utils/Docs/HTMLMarqueeElementHspace/HTMLMarqueeElementHspace.generated.xml' path='docs/HTMLMarqueeElementHspace/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Hspace { get; set; }
	///<include file='Utils/Docs/HTMLMarqueeElementLoop/HTMLMarqueeElementLoop.generated.xml' path='docs/HTMLMarqueeElementLoop/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public long Loop { get; set; }
	///<include file='Utils/Docs/HTMLMarqueeElementScrollAmount/HTMLMarqueeElementScrollAmount.generated.xml' path='docs/HTMLMarqueeElementScrollAmount/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong ScrollAmount { get; set; }
	///<include file='Utils/Docs/HTMLMarqueeElementScrollDelay/HTMLMarqueeElementScrollDelay.generated.xml' path='docs/HTMLMarqueeElementScrollDelay/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong ScrollDelay { get; set; }
	///<include file='Utils/Docs/HTMLMarqueeElementTrueSpeed/HTMLMarqueeElementTrueSpeed.generated.xml' path='docs/HTMLMarqueeElementTrueSpeed/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool TrueSpeed { get; set; }
	///<include file='Utils/Docs/HTMLMarqueeElementVspace/HTMLMarqueeElementVspace.generated.xml' path='docs/HTMLMarqueeElementVspace/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public ulong Vspace { get; set; }
	///<include file='Utils/Docs/HTMLMarqueeElementWidth/HTMLMarqueeElementWidth.generated.xml' path='docs/HTMLMarqueeElementWidth/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Width { get; set; }
	///<include file='Utils/Docs/HTMLMarqueeElementStart/HTMLMarqueeElementStart.generated.xml' path='docs/HTMLMarqueeElementStart/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Start() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/HTMLMarqueeElementStop/HTMLMarqueeElementStop.generated.xml' path='docs/HTMLMarqueeElementStop/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Undefined Stop() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/HTMLFrameSetElement/HTMLFrameSetElement.generated.xml' path='docs/HTMLFrameSetElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLFrameSetElement : HTMLElement, WindowEventHandlers
{
	///<include file='Utils/Docs/HTMLFrameSetElementHTMLFrameSetElement/HTMLFrameSetElementHTMLFrameSetElement.generated.xml' path='docs/HTMLFrameSetElementHTMLFrameSetElement/*'/>
	public HTMLFrameSetElement() { }
	///<include file='Utils/Docs/HTMLFrameSetElementCols/HTMLFrameSetElementCols.generated.xml' path='docs/HTMLFrameSetElementCols/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Cols { get; set; }
	///<include file='Utils/Docs/HTMLFrameSetElementRows/HTMLFrameSetElementRows.generated.xml' path='docs/HTMLFrameSetElementRows/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Rows { get; set; }
}


///<include file='Utils/Docs/HTMLFrameElement/HTMLFrameElement.generated.xml' path='docs/HTMLFrameElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLFrameElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLFrameElementHTMLFrameElement/HTMLFrameElementHTMLFrameElement.generated.xml' path='docs/HTMLFrameElementHTMLFrameElement/*'/>
	public HTMLFrameElement() { }
	///<include file='Utils/Docs/HTMLFrameElementName/HTMLFrameElementName.generated.xml' path='docs/HTMLFrameElementName/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	///<include file='Utils/Docs/HTMLFrameElementScrolling/HTMLFrameElementScrolling.generated.xml' path='docs/HTMLFrameElementScrolling/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Scrolling { get; set; }
	///<include file='Utils/Docs/HTMLFrameElementSrc/HTMLFrameElementSrc.generated.xml' path='docs/HTMLFrameElementSrc/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Src { get; set; }
	///<include file='Utils/Docs/HTMLFrameElementFrameBorder/HTMLFrameElementFrameBorder.generated.xml' path='docs/HTMLFrameElementFrameBorder/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string FrameBorder { get; set; }
	///<include file='Utils/Docs/HTMLFrameElementLongDesc/HTMLFrameElementLongDesc.generated.xml' path='docs/HTMLFrameElementLongDesc/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string LongDesc { get; set; }
	///<include file='Utils/Docs/HTMLFrameElementNoResize/HTMLFrameElementNoResize.generated.xml' path='docs/HTMLFrameElementNoResize/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool NoResize { get; set; }
	///<include file='Utils/Docs/HTMLFrameElementContentDocument/HTMLFrameElementContentDocument.generated.xml' path='docs/HTMLFrameElementContentDocument/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Document? ContentDocument { get; }
	///<include file='Utils/Docs/HTMLFrameElementContentWindow/HTMLFrameElementContentWindow.generated.xml' path='docs/HTMLFrameElementContentWindow/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public Window? ContentWindow { get; }
	///<include file='Utils/Docs/HTMLFrameElementMarginHeight/HTMLFrameElementMarginHeight.generated.xml' path='docs/HTMLFrameElementMarginHeight/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string MarginHeight { get; set; }
	///<include file='Utils/Docs/HTMLFrameElementMarginWidth/HTMLFrameElementMarginWidth.generated.xml' path='docs/HTMLFrameElementMarginWidth/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string MarginWidth { get; set; }
}

///<include file='Utils/Docs/HTMLAnchorElement/HTMLAnchorElement.generated.xml' path='docs/HTMLAnchorElement/*'/>
public partial class HTMLAnchorElement
{
	///<include file='Utils/Docs/HTMLAnchorElementCoords/HTMLAnchorElementCoords.generated.xml' path='docs/HTMLAnchorElementCoords/*'/>
	public string Coords { get; set; }
	///<include file='Utils/Docs/HTMLAnchorElementCharset/HTMLAnchorElementCharset.generated.xml' path='docs/HTMLAnchorElementCharset/*'/>
	public string Charset { get; set; }
	///<include file='Utils/Docs/HTMLAnchorElementName/HTMLAnchorElementName.generated.xml' path='docs/HTMLAnchorElementName/*'/>
	public string Name { get; set; }
	///<include file='Utils/Docs/HTMLAnchorElementRev/HTMLAnchorElementRev.generated.xml' path='docs/HTMLAnchorElementRev/*'/>
	public string Rev { get; set; }
	///<include file='Utils/Docs/HTMLAnchorElementShape/HTMLAnchorElementShape.generated.xml' path='docs/HTMLAnchorElementShape/*'/>
	public string Shape { get; set; }
}

///<include file='Utils/Docs/HTMLAreaElement/HTMLAreaElement.generated.xml' path='docs/HTMLAreaElement/*'/>
public partial class HTMLAreaElement
{
	///<include file='Utils/Docs/HTMLAreaElementNoHref/HTMLAreaElementNoHref.generated.xml' path='docs/HTMLAreaElementNoHref/*'/>
	public bool NoHref { get; set; }
}

///<include file='Utils/Docs/HTMLBodyElement/HTMLBodyElement.generated.xml' path='docs/HTMLBodyElement/*'/>
public partial class HTMLBodyElement
{
	///<include file='Utils/Docs/HTMLBodyElementText/HTMLBodyElementText.generated.xml' path='docs/HTMLBodyElementText/*'/>
	public string Text { get; set; }
	///<include file='Utils/Docs/HTMLBodyElementLink/HTMLBodyElementLink.generated.xml' path='docs/HTMLBodyElementLink/*'/>
	public string Link { get; set; }
	///<include file='Utils/Docs/HTMLBodyElementVLink/HTMLBodyElementVLink.generated.xml' path='docs/HTMLBodyElementVLink/*'/>
	public string VLink { get; set; }
	///<include file='Utils/Docs/HTMLBodyElementALink/HTMLBodyElementALink.generated.xml' path='docs/HTMLBodyElementALink/*'/>
	public string ALink { get; set; }
	///<include file='Utils/Docs/HTMLBodyElementBgColor/HTMLBodyElementBgColor.generated.xml' path='docs/HTMLBodyElementBgColor/*'/>
	public string BgColor { get; set; }
	///<include file='Utils/Docs/HTMLBodyElementBackground/HTMLBodyElementBackground.generated.xml' path='docs/HTMLBodyElementBackground/*'/>
	public string Background { get; set; }
}

///<include file='Utils/Docs/HTMLBRElement/HTMLBRElement.generated.xml' path='docs/HTMLBRElement/*'/>
public partial class HTMLBRElement
{
	///<include file='Utils/Docs/HTMLBRElementClear/HTMLBRElementClear.generated.xml' path='docs/HTMLBRElementClear/*'/>
	public string Clear { get; set; }
}

///<include file='Utils/Docs/HTMLTableCaptionElement/HTMLTableCaptionElement.generated.xml' path='docs/HTMLTableCaptionElement/*'/>
public partial class HTMLTableCaptionElement
{
	///<include file='Utils/Docs/HTMLTableCaptionElementAlign/HTMLTableCaptionElementAlign.generated.xml' path='docs/HTMLTableCaptionElementAlign/*'/>
	public string Align { get; set; }
}

///<include file='Utils/Docs/HTMLTableColElement/HTMLTableColElement.generated.xml' path='docs/HTMLTableColElement/*'/>
public partial class HTMLTableColElement
{
	///<include file='Utils/Docs/HTMLTableColElementAlign/HTMLTableColElementAlign.generated.xml' path='docs/HTMLTableColElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs/HTMLTableColElementCh/HTMLTableColElementCh.generated.xml' path='docs/HTMLTableColElementCh/*'/>
	public string Ch { get; set; }
	///<include file='Utils/Docs/HTMLTableColElementChOff/HTMLTableColElementChOff.generated.xml' path='docs/HTMLTableColElementChOff/*'/>
	public string ChOff { get; set; }
	///<include file='Utils/Docs/HTMLTableColElementVAlign/HTMLTableColElementVAlign.generated.xml' path='docs/HTMLTableColElementVAlign/*'/>
	public string VAlign { get; set; }
	///<include file='Utils/Docs/HTMLTableColElementWidth/HTMLTableColElementWidth.generated.xml' path='docs/HTMLTableColElementWidth/*'/>
	public string Width { get; set; }
}

///<include file='Utils/Docs/HTMLDirectoryElement/HTMLDirectoryElement.generated.xml' path='docs/HTMLDirectoryElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLDirectoryElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLDirectoryElementHTMLDirectoryElement/HTMLDirectoryElementHTMLDirectoryElement.generated.xml' path='docs/HTMLDirectoryElementHTMLDirectoryElement/*'/>
	public HTMLDirectoryElement() { }
	///<include file='Utils/Docs/HTMLDirectoryElementCompact/HTMLDirectoryElementCompact.generated.xml' path='docs/HTMLDirectoryElementCompact/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public bool Compact { get; set; }
}

///<include file='Utils/Docs/HTMLDivElement/HTMLDivElement.generated.xml' path='docs/HTMLDivElement/*'/>
public partial class HTMLDivElement
{
	///<include file='Utils/Docs/HTMLDivElementAlign/HTMLDivElementAlign.generated.xml' path='docs/HTMLDivElementAlign/*'/>
	public string Align { get; set; }
}

///<include file='Utils/Docs/HTMLDListElement/HTMLDListElement.generated.xml' path='docs/HTMLDListElement/*'/>
public partial class HTMLDListElement
{
	///<include file='Utils/Docs/HTMLDListElementCompact/HTMLDListElementCompact.generated.xml' path='docs/HTMLDListElementCompact/*'/>
	public bool Compact { get; set; }
}

///<include file='Utils/Docs/HTMLEmbedElement/HTMLEmbedElement.generated.xml' path='docs/HTMLEmbedElement/*'/>
public partial class HTMLEmbedElement
{
	///<include file='Utils/Docs/HTMLEmbedElementAlign/HTMLEmbedElementAlign.generated.xml' path='docs/HTMLEmbedElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs/HTMLEmbedElementName/HTMLEmbedElementName.generated.xml' path='docs/HTMLEmbedElementName/*'/>
	public string Name { get; set; }
}

///<include file='Utils/Docs/HTMLFontElement/HTMLFontElement.generated.xml' path='docs/HTMLFontElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLFontElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLFontElementHTMLFontElement/HTMLFontElementHTMLFontElement.generated.xml' path='docs/HTMLFontElementHTMLFontElement/*'/>
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
	///<include file='Utils/Docs/HTMLHeadingElementAlign/HTMLHeadingElementAlign.generated.xml' path='docs/HTMLHeadingElementAlign/*'/>
	public string Align { get; set; }
}

///<include file='Utils/Docs/HTMLHRElement/HTMLHRElement.generated.xml' path='docs/HTMLHRElement/*'/>
public partial class HTMLHRElement
{
	///<include file='Utils/Docs/HTMLHRElementAlign/HTMLHRElementAlign.generated.xml' path='docs/HTMLHRElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs/HTMLHRElementColor/HTMLHRElementColor.generated.xml' path='docs/HTMLHRElementColor/*'/>
	public string Color { get; set; }
	///<include file='Utils/Docs/HTMLHRElementNoShade/HTMLHRElementNoShade.generated.xml' path='docs/HTMLHRElementNoShade/*'/>
	public bool NoShade { get; set; }
	///<include file='Utils/Docs/HTMLHRElementSize/HTMLHRElementSize.generated.xml' path='docs/HTMLHRElementSize/*'/>
	public string Size { get; set; }
	///<include file='Utils/Docs/HTMLHRElementWidth/HTMLHRElementWidth.generated.xml' path='docs/HTMLHRElementWidth/*'/>
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
	///<include file='Utils/Docs/HTMLIFrameElementAlign/HTMLIFrameElementAlign.generated.xml' path='docs/HTMLIFrameElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementScrolling/HTMLIFrameElementScrolling.generated.xml' path='docs/HTMLIFrameElementScrolling/*'/>
	public string Scrolling { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementFrameBorder/HTMLIFrameElementFrameBorder.generated.xml' path='docs/HTMLIFrameElementFrameBorder/*'/>
	public string FrameBorder { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementLongDesc/HTMLIFrameElementLongDesc.generated.xml' path='docs/HTMLIFrameElementLongDesc/*'/>
	public string LongDesc { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementMarginHeight/HTMLIFrameElementMarginHeight.generated.xml' path='docs/HTMLIFrameElementMarginHeight/*'/>
	public string MarginHeight { get; set; }
	///<include file='Utils/Docs/HTMLIFrameElementMarginWidth/HTMLIFrameElementMarginWidth.generated.xml' path='docs/HTMLIFrameElementMarginWidth/*'/>
	public string MarginWidth { get; set; }
}

///<include file='Utils/Docs/HTMLImageElement/HTMLImageElement.generated.xml' path='docs/HTMLImageElement/*'/>
public partial class HTMLImageElement
{
	///<include file='Utils/Docs/HTMLImageElementName/HTMLImageElementName.generated.xml' path='docs/HTMLImageElementName/*'/>
	public string Name { get; set; }
	///<include file='Utils/Docs/HTMLImageElementLowsrc/HTMLImageElementLowsrc.generated.xml' path='docs/HTMLImageElementLowsrc/*'/>
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
	///<include file='Utils/Docs/HTMLInputElementAlign/HTMLInputElementAlign.generated.xml' path='docs/HTMLInputElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs/HTMLInputElementUseMap/HTMLInputElementUseMap.generated.xml' path='docs/HTMLInputElementUseMap/*'/>
	public string UseMap { get; set; }
}

///<include file='Utils/Docs/HTMLLegendElement/HTMLLegendElement.generated.xml' path='docs/HTMLLegendElement/*'/>
public partial class HTMLLegendElement
{
	///<include file='Utils/Docs/HTMLLegendElementAlign/HTMLLegendElementAlign.generated.xml' path='docs/HTMLLegendElementAlign/*'/>
	public string Align { get; set; }
}

///<include file='Utils/Docs/HTMLLIElement/HTMLLIElement.generated.xml' path='docs/HTMLLIElement/*'/>
public partial class HTMLLIElement
{
	///<include file='Utils/Docs/HTMLLIElementType/HTMLLIElementType.generated.xml' path='docs/HTMLLIElementType/*'/>
	public string Type { get; set; }
}

///<include file='Utils/Docs/HTMLLinkElement/HTMLLinkElement.generated.xml' path='docs/HTMLLinkElement/*'/>
public partial class HTMLLinkElement
{
	///<include file='Utils/Docs/HTMLLinkElementCharset/HTMLLinkElementCharset.generated.xml' path='docs/HTMLLinkElementCharset/*'/>
	public string Charset { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementRev/HTMLLinkElementRev.generated.xml' path='docs/HTMLLinkElementRev/*'/>
	public string Rev { get; set; }
	///<include file='Utils/Docs/HTMLLinkElementTarget/HTMLLinkElementTarget.generated.xml' path='docs/HTMLLinkElementTarget/*'/>
	public string Target { get; set; }
}

///<include file='Utils/Docs/HTMLMenuElement/HTMLMenuElement.generated.xml' path='docs/HTMLMenuElement/*'/>
public partial class HTMLMenuElement
{
	///<include file='Utils/Docs/HTMLMenuElementCompact/HTMLMenuElementCompact.generated.xml' path='docs/HTMLMenuElementCompact/*'/>
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
	///<include file='Utils/Docs/HTMLObjectElementAlign/HTMLObjectElementAlign.generated.xml' path='docs/HTMLObjectElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementArchive/HTMLObjectElementArchive.generated.xml' path='docs/HTMLObjectElementArchive/*'/>
	public string Archive { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementCode/HTMLObjectElementCode.generated.xml' path='docs/HTMLObjectElementCode/*'/>
	public string Code { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementDeclare/HTMLObjectElementDeclare.generated.xml' path='docs/HTMLObjectElementDeclare/*'/>
	public bool Declare { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementHspace/HTMLObjectElementHspace.generated.xml' path='docs/HTMLObjectElementHspace/*'/>
	public ulong Hspace { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementStandby/HTMLObjectElementStandby.generated.xml' path='docs/HTMLObjectElementStandby/*'/>
	public string Standby { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementVspace/HTMLObjectElementVspace.generated.xml' path='docs/HTMLObjectElementVspace/*'/>
	public ulong Vspace { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementCodeBase/HTMLObjectElementCodeBase.generated.xml' path='docs/HTMLObjectElementCodeBase/*'/>
	public string CodeBase { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementCodeType/HTMLObjectElementCodeType.generated.xml' path='docs/HTMLObjectElementCodeType/*'/>
	public string CodeType { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementUseMap/HTMLObjectElementUseMap.generated.xml' path='docs/HTMLObjectElementUseMap/*'/>
	public string UseMap { get; set; }
	///<include file='Utils/Docs/HTMLObjectElementBorder/HTMLObjectElementBorder.generated.xml' path='docs/HTMLObjectElementBorder/*'/>
	public string Border { get; set; }
}

///<include file='Utils/Docs/HTMLOListElement/HTMLOListElement.generated.xml' path='docs/HTMLOListElement/*'/>
public partial class HTMLOListElement
{
	///<include file='Utils/Docs/HTMLOListElementCompact/HTMLOListElementCompact.generated.xml' path='docs/HTMLOListElementCompact/*'/>
	public bool Compact { get; set; }
}

///<include file='Utils/Docs/HTMLParagraphElement/HTMLParagraphElement.generated.xml' path='docs/HTMLParagraphElement/*'/>
public partial class HTMLParagraphElement
{
	///<include file='Utils/Docs/HTMLParagraphElementAlign/HTMLParagraphElementAlign.generated.xml' path='docs/HTMLParagraphElementAlign/*'/>
	public string Align { get; set; }
}

///<include file='Utils/Docs/HTMLParamElement/HTMLParamElement.generated.xml' path='docs/HTMLParamElement/*'/>
[To(ToAttribute.Default)]
public partial class HTMLParamElement : HTMLElement
{
	///<include file='Utils/Docs/HTMLParamElementHTMLParamElement/HTMLParamElementHTMLParamElement.generated.xml' path='docs/HTMLParamElementHTMLParamElement/*'/>
	public HTMLParamElement() { }
	///<include file='Utils/Docs/HTMLParamElementName/HTMLParamElementName.generated.xml' path='docs/HTMLParamElementName/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Name { get; set; }
	///<include file='Utils/Docs/HTMLParamElementValue/HTMLParamElementValue.generated.xml' path='docs/HTMLParamElementValue/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Value { get; set; }
	///<include file='Utils/Docs/HTMLParamElementType/HTMLParamElementType.generated.xml' path='docs/HTMLParamElementType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string Type { get; set; }
	///<include file='Utils/Docs/HTMLParamElementValueType/HTMLParamElementValueType.generated.xml' path='docs/HTMLParamElementValueType/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
	public string ValueType { get; set; }
}

///<include file='Utils/Docs/HTMLPreElement/HTMLPreElement.generated.xml' path='docs/HTMLPreElement/*'/>
public partial class HTMLPreElement
{
	///<include file='Utils/Docs/HTMLPreElementWidth/HTMLPreElementWidth.generated.xml' path='docs/HTMLPreElementWidth/*'/>
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
	///<include file='Utils/Docs/HTMLScriptElementCharset/HTMLScriptElementCharset.generated.xml' path='docs/HTMLScriptElementCharset/*'/>
	public string Charset { get; set; }
	///<include file='Utils/Docs/HTMLScriptElementEvent/HTMLScriptElementEvent.generated.xml' path='docs/HTMLScriptElementEvent/*'/>
	public string Event { get; set; }
	///<include file='Utils/Docs/HTMLScriptElementHtmlFor/HTMLScriptElementHtmlFor.generated.xml' path='docs/HTMLScriptElementHtmlFor/*'/>
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
	///<include file='Utils/Docs/HTMLTableSectionElementAlign/HTMLTableSectionElementAlign.generated.xml' path='docs/HTMLTableSectionElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs/HTMLTableSectionElementCh/HTMLTableSectionElementCh.generated.xml' path='docs/HTMLTableSectionElementCh/*'/>
	public string Ch { get; set; }
	///<include file='Utils/Docs/HTMLTableSectionElementChOff/HTMLTableSectionElementChOff.generated.xml' path='docs/HTMLTableSectionElementChOff/*'/>
	public string ChOff { get; set; }
	///<include file='Utils/Docs/HTMLTableSectionElementVAlign/HTMLTableSectionElementVAlign.generated.xml' path='docs/HTMLTableSectionElementVAlign/*'/>
	public string VAlign { get; set; }
}

///<include file='Utils/Docs/HTMLTableCellElement/HTMLTableCellElement.generated.xml' path='docs/HTMLTableCellElement/*'/>
public partial class HTMLTableCellElement
{
	///<include file='Utils/Docs/HTMLTableCellElementAlign/HTMLTableCellElementAlign.generated.xml' path='docs/HTMLTableCellElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs/HTMLTableCellElementAxis/HTMLTableCellElementAxis.generated.xml' path='docs/HTMLTableCellElementAxis/*'/>
	public string Axis { get; set; }
	///<include file='Utils/Docs/HTMLTableCellElementHeight/HTMLTableCellElementHeight.generated.xml' path='docs/HTMLTableCellElementHeight/*'/>
	public string Height { get; set; }
	///<include file='Utils/Docs/HTMLTableCellElementWidth/HTMLTableCellElementWidth.generated.xml' path='docs/HTMLTableCellElementWidth/*'/>
	public string Width { get; set; }
	///<include file='Utils/Docs/HTMLTableCellElementCh/HTMLTableCellElementCh.generated.xml' path='docs/HTMLTableCellElementCh/*'/>
	public string Ch { get; set; }
	///<include file='Utils/Docs/HTMLTableCellElementChOff/HTMLTableCellElementChOff.generated.xml' path='docs/HTMLTableCellElementChOff/*'/>
	public string ChOff { get; set; }
	///<include file='Utils/Docs/HTMLTableCellElementNoWrap/HTMLTableCellElementNoWrap.generated.xml' path='docs/HTMLTableCellElementNoWrap/*'/>
	public bool NoWrap { get; set; }
	///<include file='Utils/Docs/HTMLTableCellElementVAlign/HTMLTableCellElementVAlign.generated.xml' path='docs/HTMLTableCellElementVAlign/*'/>
	public string VAlign { get; set; }
	///<include file='Utils/Docs/HTMLTableCellElementBgColor/HTMLTableCellElementBgColor.generated.xml' path='docs/HTMLTableCellElementBgColor/*'/>
	public string BgColor { get; set; }
}

///<include file='Utils/Docs/HTMLTableRowElement/HTMLTableRowElement.generated.xml' path='docs/HTMLTableRowElement/*'/>
public partial class HTMLTableRowElement
{
	///<include file='Utils/Docs/HTMLTableRowElementAlign/HTMLTableRowElementAlign.generated.xml' path='docs/HTMLTableRowElementAlign/*'/>
	public string Align { get; set; }
	///<include file='Utils/Docs/HTMLTableRowElementCh/HTMLTableRowElementCh.generated.xml' path='docs/HTMLTableRowElementCh/*'/>
	public string Ch { get; set; }
	///<include file='Utils/Docs/HTMLTableRowElementChOff/HTMLTableRowElementChOff.generated.xml' path='docs/HTMLTableRowElementChOff/*'/>
	public string ChOff { get; set; }
	///<include file='Utils/Docs/HTMLTableRowElementVAlign/HTMLTableRowElementVAlign.generated.xml' path='docs/HTMLTableRowElementVAlign/*'/>
	public string VAlign { get; set; }
	///<include file='Utils/Docs/HTMLTableRowElementBgColor/HTMLTableRowElementBgColor.generated.xml' path='docs/HTMLTableRowElementBgColor/*'/>
	public string BgColor { get; set; }
}

///<include file='Utils/Docs/HTMLUListElement/HTMLUListElement.generated.xml' path='docs/HTMLUListElement/*'/>
public partial class HTMLUListElement
{
	///<include file='Utils/Docs/HTMLUListElementCompact/HTMLUListElementCompact.generated.xml' path='docs/HTMLUListElementCompact/*'/>
	public bool Compact { get; set; }
	///<include file='Utils/Docs/HTMLUListElementType/HTMLUListElementType.generated.xml' path='docs/HTMLUListElementType/*'/>
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
	///<include file='Utils/Docs/DocumentCaptureEvents/DocumentCaptureEvents.generated.xml' path='docs/DocumentCaptureEvents/*'/>
	public Undefined CaptureEvents() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/DocumentReleaseEvents/DocumentReleaseEvents.generated.xml' path='docs/DocumentReleaseEvents/*'/>
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

///<include file='Utils/Docs/External/External.generated.xml' path='docs/External/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class External
{
	///<include file='Utils/Docs/ExternalAddSearchProvider/ExternalAddSearchProvider.generated.xml' path='docs/ExternalAddSearchProvider/*'/>
	public Undefined AddSearchProvider() { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/ExternalIsSearchProviderInstalled/ExternalIsSearchProviderInstalled.generated.xml' path='docs/ExternalIsSearchProviderInstalled/*'/>
	public Undefined IsSearchProviderInstalled() { throw new System.NotImplementedException(); }
}

///<include file='Utils/Docs/Notification/Notification.generated.xml' path='docs/Notification/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class Notification : EventTarget
{
	///<include file='Utils/Docs/NotificationNotification/NotificationNotification.generated.xml' path='docs/NotificationNotification/*'/>
	public Notification(string title, NotificationOptions options) { }
	///<include file='Utils/Docs/NotificationPermission/NotificationPermission.generated.xml' path='docs/NotificationPermission/*'/>
	public static NotificationPermission Permission { get; }
	///<include file='Utils/Docs/NotificationRequestPermission/NotificationRequestPermission.generated.xml' path='docs/NotificationRequestPermission/*'/>
	public static Task<NotificationPermission> RequestPermission(NotificationPermissionCallback deprecatedCallback) { throw new System.NotImplementedException(); }
	///<include file='Utils/Docs/NotificationMaxActions/NotificationMaxActions.generated.xml' path='docs/NotificationMaxActions/*'/>
	public static ulong MaxActions { get; }
	///<include file='Utils/Docs/NotificationOnclick/NotificationOnclick.generated.xml' path='docs/NotificationOnclick/*'/>
	public EventHandler Onclick { get; set; }
	///<include file='Utils/Docs/NotificationOnshow/NotificationOnshow.generated.xml' path='docs/NotificationOnshow/*'/>
	public EventHandler Onshow { get; set; }
	///<include file='Utils/Docs/NotificationOnerror/NotificationOnerror.generated.xml' path='docs/NotificationOnerror/*'/>
	public EventHandler Onerror { get; set; }
	///<include file='Utils/Docs/NotificationOnclose/NotificationOnclose.generated.xml' path='docs/NotificationOnclose/*'/>
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

///<include file='Utils/Docs/NotificationOptions/NotificationOptions.generated.xml' path='docs/NotificationOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class NotificationOptions
{
	///<include file='Utils/Docs/NotificationOptionsDir/NotificationOptionsDir.generated.xml' path='docs/NotificationOptionsDir/*'/>
	public NotificationDirection Dir;
	///<include file='Utils/Docs/NotificationOptionsLang/NotificationOptionsLang.generated.xml' path='docs/NotificationOptionsLang/*'/>
	public string Lang;
	///<include file='Utils/Docs/NotificationOptionsBody/NotificationOptionsBody.generated.xml' path='docs/NotificationOptionsBody/*'/>
	public string Body;
	///<include file='Utils/Docs/NotificationOptionsTag/NotificationOptionsTag.generated.xml' path='docs/NotificationOptionsTag/*'/>
	public string Tag;
	///<include file='Utils/Docs/NotificationOptionsImage/NotificationOptionsImage.generated.xml' path='docs/NotificationOptionsImage/*'/>
	public string Image;
	///<include file='Utils/Docs/NotificationOptionsIcon/NotificationOptionsIcon.generated.xml' path='docs/NotificationOptionsIcon/*'/>
	public string Icon;
	///<include file='Utils/Docs/NotificationOptionsBadge/NotificationOptionsBadge.generated.xml' path='docs/NotificationOptionsBadge/*'/>
	public string Badge;
	///<include file='Utils/Docs/NotificationOptionsVibrate/NotificationOptionsVibrate.generated.xml' path='docs/NotificationOptionsVibrate/*'/>
	public Unsupported /*VibratePattern*/ Vibrate;
	///<include file='Utils/Docs/NotificationOptionsTimestamp/NotificationOptionsTimestamp.generated.xml' path='docs/NotificationOptionsTimestamp/*'/>
	public Unsupported /*EpochTimeStamp*/ Timestamp;
	///<include file='Utils/Docs/NotificationOptionsRenotify/NotificationOptionsRenotify.generated.xml' path='docs/NotificationOptionsRenotify/*'/>
	public bool Renotify;
	///<include file='Utils/Docs/NotificationOptionsSilent/NotificationOptionsSilent.generated.xml' path='docs/NotificationOptionsSilent/*'/>
	public bool Silent;
	///<include file='Utils/Docs/NotificationOptionsRequireInteraction/NotificationOptionsRequireInteraction.generated.xml' path='docs/NotificationOptionsRequireInteraction/*'/>
	public bool RequireInteraction;
	///<include file='Utils/Docs/NotificationOptionsData/NotificationOptionsData.generated.xml' path='docs/NotificationOptionsData/*'/>
	public dynamic Data;
	///<include file='Utils/Docs/NotificationOptionsActions/NotificationOptionsActions.generated.xml' path='docs/NotificationOptionsActions/*'/>
	public List<NotificationAction> Actions;
}

///<include file='Utils/Docs/NotificationPermission/NotificationPermission.generated.xml' path='docs/NotificationPermission/*'/>
public enum NotificationPermission
{
	Default,
	Denied,
	Granted,
}

///<include file='Utils/Docs/NotificationDirection/NotificationDirection.generated.xml' path='docs/NotificationDirection/*'/>
public enum NotificationDirection
{
	Auto,
	Ltr,
	Rtl,
}

///<include file='Utils/Docs/NotificationAction/NotificationAction.generated.xml' path='docs/NotificationAction/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class NotificationAction
{
	///<include file='Utils/Docs/NotificationActionAction/NotificationActionAction.generated.xml' path='docs/NotificationActionAction/*'/>
	public required string Action;
	///<include file='Utils/Docs/NotificationActionTitle/NotificationActionTitle.generated.xml' path='docs/NotificationActionTitle/*'/>
	public required string Title;
	///<include file='Utils/Docs/NotificationActionIcon/NotificationActionIcon.generated.xml' path='docs/NotificationActionIcon/*'/>
	public string Icon;
}

///<include file='Utils/Docs/NotificationPermissionCallback/NotificationPermissionCallback.generated.xml' path='docs/NotificationPermissionCallback/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public struct NotificationPermissionCallback
{
}

///<include file='Utils/Docs/GetNotificationOptions/GetNotificationOptions.generated.xml' path='docs/GetNotificationOptions/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class GetNotificationOptions
{
	///<include file='Utils/Docs/GetNotificationOptionsTag/GetNotificationOptionsTag.generated.xml' path='docs/GetNotificationOptionsTag/*'/>
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

///<include file='Utils/Docs/NotificationEventInit/NotificationEventInit.generated.xml' path='docs/NotificationEventInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class NotificationEventInit
{
	///<include file='Utils/Docs/NotificationEventInitNotification/NotificationEventInitNotification.generated.xml' path='docs/NotificationEventInitNotification/*'/>
	public required Notification Notification;
	///<include file='Utils/Docs/NotificationEventInitAction/NotificationEventInitAction.generated.xml' path='docs/NotificationEventInitAction/*'/>
	public string Action;
}

///<include file='Utils/Docs/ServiceWorkerGlobalScope/ServiceWorkerGlobalScope.generated.xml' path='docs/ServiceWorkerGlobalScope/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ServiceWorkerGlobalScope
{
	///<include file='Utils/Docs/ServiceWorkerGlobalScopeOnnotificationclick/ServiceWorkerGlobalScopeOnnotificationclick.generated.xml' path='docs/ServiceWorkerGlobalScopeOnnotificationclick/*'/>
	public EventHandler Onnotificationclick { get; set; }
	///<include file='Utils/Docs/ServiceWorkerGlobalScopeOnnotificationclose/ServiceWorkerGlobalScopeOnnotificationclose.generated.xml' path='docs/ServiceWorkerGlobalScopeOnnotificationclose/*'/>
	public EventHandler Onnotificationclose { get; set; }
}

///<include file='Utils/Docs/NavigatorStorage/NavigatorStorage.generated.xml' path='docs/NavigatorStorage/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial interface NavigatorStorage
{
	///<include file='Utils/Docs/NavigatorStorageStorage/NavigatorStorageStorage.generated.xml' path='docs/NavigatorStorageStorage/*'/>
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

///<include file='Utils/Docs/StorageEstimate/StorageEstimate.generated.xml' path='docs/StorageEstimate/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class StorageEstimate
{
	///<include file='Utils/Docs/StorageEstimateUsage/StorageEstimateUsage.generated.xml' path='docs/StorageEstimateUsage/*'/>
	public ulong Usage;
	///<include file='Utils/Docs/StorageEstimateQuota/StorageEstimateQuota.generated.xml' path='docs/StorageEstimateQuota/*'/>
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
	///<include file='Utils/Docs/DOMExceptionINDEX_SIZE_ERR/DOMExceptionINDEX_SIZE_ERR.generated.xml' path='docs/DOMExceptionINDEX_SIZE_ERR/*'/>
	public const ushort INDEX_SIZE_ERR = 1;
	///<include file='Utils/Docs/DOMExceptionDOMSTRING_SIZE_ERR/DOMExceptionDOMSTRING_SIZE_ERR.generated.xml' path='docs/DOMExceptionDOMSTRING_SIZE_ERR/*'/>
	public const ushort DOMSTRING_SIZE_ERR = 2;
	///<include file='Utils/Docs/DOMExceptionHIERARCHY_REQUEST_ERR/DOMExceptionHIERARCHY_REQUEST_ERR.generated.xml' path='docs/DOMExceptionHIERARCHY_REQUEST_ERR/*'/>
	public const ushort HIERARCHY_REQUEST_ERR = 3;
	///<include file='Utils/Docs/DOMExceptionWRONG_DOCUMENT_ERR/DOMExceptionWRONG_DOCUMENT_ERR.generated.xml' path='docs/DOMExceptionWRONG_DOCUMENT_ERR/*'/>
	public const ushort WRONG_DOCUMENT_ERR = 4;
	///<include file='Utils/Docs/DOMExceptionINVALID_CHARACTER_ERR/DOMExceptionINVALID_CHARACTER_ERR.generated.xml' path='docs/DOMExceptionINVALID_CHARACTER_ERR/*'/>
	public const ushort INVALID_CHARACTER_ERR = 5;
	///<include file='Utils/Docs/DOMExceptionNO_DATA_ALLOWED_ERR/DOMExceptionNO_DATA_ALLOWED_ERR.generated.xml' path='docs/DOMExceptionNO_DATA_ALLOWED_ERR/*'/>
	public const ushort NO_DATA_ALLOWED_ERR = 6;
	///<include file='Utils/Docs/DOMExceptionNO_MODIFICATION_ALLOWED_ERR/DOMExceptionNO_MODIFICATION_ALLOWED_ERR.generated.xml' path='docs/DOMExceptionNO_MODIFICATION_ALLOWED_ERR/*'/>
	public const ushort NO_MODIFICATION_ALLOWED_ERR = 7;
	///<include file='Utils/Docs/DOMExceptionNOT_FOUND_ERR/DOMExceptionNOT_FOUND_ERR.generated.xml' path='docs/DOMExceptionNOT_FOUND_ERR/*'/>
	public const ushort NOT_FOUND_ERR = 8;
	///<include file='Utils/Docs/DOMExceptionNOT_SUPPORTED_ERR/DOMExceptionNOT_SUPPORTED_ERR.generated.xml' path='docs/DOMExceptionNOT_SUPPORTED_ERR/*'/>
	public const ushort NOT_SUPPORTED_ERR = 9;
	///<include file='Utils/Docs/DOMExceptionINUSE_ATTRIBUTE_ERR/DOMExceptionINUSE_ATTRIBUTE_ERR.generated.xml' path='docs/DOMExceptionINUSE_ATTRIBUTE_ERR/*'/>
	public const ushort INUSE_ATTRIBUTE_ERR = 10;
	///<include file='Utils/Docs/DOMExceptionINVALID_STATE_ERR/DOMExceptionINVALID_STATE_ERR.generated.xml' path='docs/DOMExceptionINVALID_STATE_ERR/*'/>
	public const ushort INVALID_STATE_ERR = 11;
	///<include file='Utils/Docs/DOMExceptionSYNTAX_ERR/DOMExceptionSYNTAX_ERR.generated.xml' path='docs/DOMExceptionSYNTAX_ERR/*'/>
	public const ushort SYNTAX_ERR = 12;
	///<include file='Utils/Docs/DOMExceptionINVALID_MODIFICATION_ERR/DOMExceptionINVALID_MODIFICATION_ERR.generated.xml' path='docs/DOMExceptionINVALID_MODIFICATION_ERR/*'/>
	public const ushort INVALID_MODIFICATION_ERR = 13;
	///<include file='Utils/Docs/DOMExceptionNAMESPACE_ERR/DOMExceptionNAMESPACE_ERR.generated.xml' path='docs/DOMExceptionNAMESPACE_ERR/*'/>
	public const ushort NAMESPACE_ERR = 14;
	///<include file='Utils/Docs/DOMExceptionINVALID_ACCESS_ERR/DOMExceptionINVALID_ACCESS_ERR.generated.xml' path='docs/DOMExceptionINVALID_ACCESS_ERR/*'/>
	public const ushort INVALID_ACCESS_ERR = 15;
	///<include file='Utils/Docs/DOMExceptionVALIDATION_ERR/DOMExceptionVALIDATION_ERR.generated.xml' path='docs/DOMExceptionVALIDATION_ERR/*'/>
	public const ushort VALIDATION_ERR = 16;
	///<include file='Utils/Docs/DOMExceptionTYPE_MISMATCH_ERR/DOMExceptionTYPE_MISMATCH_ERR.generated.xml' path='docs/DOMExceptionTYPE_MISMATCH_ERR/*'/>
	public const ushort TYPE_MISMATCH_ERR = 17;
	///<include file='Utils/Docs/DOMExceptionSECURITY_ERR/DOMExceptionSECURITY_ERR.generated.xml' path='docs/DOMExceptionSECURITY_ERR/*'/>
	public const ushort SECURITY_ERR = 18;
	///<include file='Utils/Docs/DOMExceptionNETWORK_ERR/DOMExceptionNETWORK_ERR.generated.xml' path='docs/DOMExceptionNETWORK_ERR/*'/>
	public const ushort NETWORK_ERR = 19;
	///<include file='Utils/Docs/DOMExceptionABORT_ERR/DOMExceptionABORT_ERR.generated.xml' path='docs/DOMExceptionABORT_ERR/*'/>
	public const ushort ABORT_ERR = 20;
	///<include file='Utils/Docs/DOMExceptionURL_MISMATCH_ERR/DOMExceptionURL_MISMATCH_ERR.generated.xml' path='docs/DOMExceptionURL_MISMATCH_ERR/*'/>
	public const ushort URL_MISMATCH_ERR = 21;
	///<include file='Utils/Docs/DOMExceptionQUOTA_EXCEEDED_ERR/DOMExceptionQUOTA_EXCEEDED_ERR.generated.xml' path='docs/DOMExceptionQUOTA_EXCEEDED_ERR/*'/>
	public const ushort QUOTA_EXCEEDED_ERR = 22;
	///<include file='Utils/Docs/DOMExceptionTIMEOUT_ERR/DOMExceptionTIMEOUT_ERR.generated.xml' path='docs/DOMExceptionTIMEOUT_ERR/*'/>
	public const ushort TIMEOUT_ERR = 23;
	///<include file='Utils/Docs/DOMExceptionINVALID_NODE_TYPE_ERR/DOMExceptionINVALID_NODE_TYPE_ERR.generated.xml' path='docs/DOMExceptionINVALID_NODE_TYPE_ERR/*'/>
	public const ushort INVALID_NODE_TYPE_ERR = 24;
	///<include file='Utils/Docs/DOMExceptionDATA_CLONE_ERR/DOMExceptionDATA_CLONE_ERR.generated.xml' path='docs/DOMExceptionDATA_CLONE_ERR/*'/>
	public const ushort DATA_CLONE_ERR = 25;
}

///<include file='Utils/Docs/Function/Function.generated.xml' path='docs/Function/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public struct Function
{
}

///<include file='Utils/Docs/VoidFunction/VoidFunction.generated.xml' path='docs/VoidFunction/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public struct VoidFunction
{
}

///<include file='Utils/Docs/XMLHttpRequestEventTarget/XMLHttpRequestEventTarget.generated.xml' path='docs/XMLHttpRequestEventTarget/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class XMLHttpRequestEventTarget : EventTarget
{
	///<include file='Utils/Docs/XMLHttpRequestEventTargetOnloadstart/XMLHttpRequestEventTargetOnloadstart.generated.xml' path='docs/XMLHttpRequestEventTargetOnloadstart/*'/>
	public EventHandler Onloadstart { get; set; }
	///<include file='Utils/Docs/XMLHttpRequestEventTargetOnprogress/XMLHttpRequestEventTargetOnprogress.generated.xml' path='docs/XMLHttpRequestEventTargetOnprogress/*'/>
	public EventHandler Onprogress { get; set; }
	///<include file='Utils/Docs/XMLHttpRequestEventTargetOnabort/XMLHttpRequestEventTargetOnabort.generated.xml' path='docs/XMLHttpRequestEventTargetOnabort/*'/>
	public EventHandler Onabort { get; set; }
	///<include file='Utils/Docs/XMLHttpRequestEventTargetOnerror/XMLHttpRequestEventTargetOnerror.generated.xml' path='docs/XMLHttpRequestEventTargetOnerror/*'/>
	public EventHandler Onerror { get; set; }
	///<include file='Utils/Docs/XMLHttpRequestEventTargetOnload/XMLHttpRequestEventTargetOnload.generated.xml' path='docs/XMLHttpRequestEventTargetOnload/*'/>
	public EventHandler Onload { get; set; }
	///<include file='Utils/Docs/XMLHttpRequestEventTargetOntimeout/XMLHttpRequestEventTargetOntimeout.generated.xml' path='docs/XMLHttpRequestEventTargetOntimeout/*'/>
	public EventHandler Ontimeout { get; set; }
	///<include file='Utils/Docs/XMLHttpRequestEventTargetOnloadend/XMLHttpRequestEventTargetOnloadend.generated.xml' path='docs/XMLHttpRequestEventTargetOnloadend/*'/>
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
	///<include file='Utils/Docs/XMLHttpRequestOnreadystatechange/XMLHttpRequestOnreadystatechange.generated.xml' path='docs/XMLHttpRequestOnreadystatechange/*'/>
	public EventHandler Onreadystatechange { get; set; }
	///<include file='Utils/Docs/XMLHttpRequestUNSENT/XMLHttpRequestUNSENT.generated.xml' path='docs/XMLHttpRequestUNSENT/*'/>
	public const ushort UNSENT = 0;
	///<include file='Utils/Docs/XMLHttpRequestOPENED/XMLHttpRequestOPENED.generated.xml' path='docs/XMLHttpRequestOPENED/*'/>
	public const ushort OPENED = 1;
	///<include file='Utils/Docs/XMLHttpRequestHEADERS_RECEIVED/XMLHttpRequestHEADERS_RECEIVED.generated.xml' path='docs/XMLHttpRequestHEADERS_RECEIVED/*'/>
	public const ushort HEADERS_RECEIVED = 2;
	///<include file='Utils/Docs/XMLHttpRequestLOADING/XMLHttpRequestLOADING.generated.xml' path='docs/XMLHttpRequestLOADING/*'/>
	public const ushort LOADING = 3;
	///<include file='Utils/Docs/XMLHttpRequestDONE/XMLHttpRequestDONE.generated.xml' path='docs/XMLHttpRequestDONE/*'/>
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

///<include file='Utils/Docs/ProgressEventInit/ProgressEventInit.generated.xml' path='docs/ProgressEventInit/*'/>
[To(ToAttribute.FirstCharToLowerCase)]
public partial class ProgressEventInit : EventInit
{
	///<include file='Utils/Docs/ProgressEventInitLengthComputable/ProgressEventInitLengthComputable.generated.xml' path='docs/ProgressEventInitLengthComputable/*'/>
	public bool LengthComputable;
	///<include file='Utils/Docs/ProgressEventInitLoaded/ProgressEventInitLoaded.generated.xml' path='docs/ProgressEventInitLoaded/*'/>
	public ulong Loaded;
	///<include file='Utils/Docs/ProgressEventInitTotal/ProgressEventInitTotal.generated.xml' path='docs/ProgressEventInitTotal/*'/>
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

