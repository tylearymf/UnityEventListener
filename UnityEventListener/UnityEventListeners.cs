using UnityEngine;
using UnityEngine.EventSystems;

public class UnityEventListener : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerEnterHandler,
    IPointerExitHandler, IPointerUpHandler, ISelectHandler, IDragHandler, IDropHandler, IBeginDragHandler,
    IDeselectHandler, ICancelHandler, IEndDragHandler, IInitializePotentialDragHandler,
    IScrollHandler, IMoveHandler, ISubmitHandler, IUpdateSelectedHandler
{
    public delegate void VoidDelegate(ref UGUIData go);

    public object parameter;

    public event VoidDelegate onPointerClick;
    public event VoidDelegate onPointerDown;
    public event VoidDelegate onPointerUp;
    public event VoidDelegate onPointerEnter;
    public event VoidDelegate onPointerExit;
    public event VoidDelegate onSelect;
    public event VoidDelegate onUpdateSelected;
    public event VoidDelegate onBeginDrag;
    public event VoidDelegate onCancel;
    public event VoidDelegate onDeselect;
    public event VoidDelegate onDrag;
    public event VoidDelegate onDrop;
    public event VoidDelegate onEndDrag;
    public event VoidDelegate onInitializePotentialDrag;
    public event VoidDelegate onMove;
    public event VoidDelegate onScroll;
    public event VoidDelegate onSubmit;

    event EventCallBack onPointerClickCallBack;
    event EventCallBack onPointerDownCallBack;
    event EventCallBack onPointerUpCallBack;
    event EventCallBack onPointerEnterCallBack;
    event EventCallBack onPointerExitCallBack;
    event EventCallBack onSelectCallBack;
    event EventCallBack onUpdateSelectedCallBack;
    event EventCallBack onBeginDragCallBack;
    event EventCallBack onCancelCallBack;
    event EventCallBack onDeselectCallBack;
    event EventCallBack onDragCallBack;
    event EventCallBack onDropCallBack;
    event EventCallBack onEndDragCallBack;
    event EventCallBack onInitializePotentialDragCallBack;
    event EventCallBack onMoveCallBack;
    event EventCallBack onScrollCallBack;
    event EventCallBack onSubmitCallBack;

    public event VoidDelegate onPointerRightClick;
    public event VoidDelegate onPointerRightDoubleClick;
    public event VoidDelegate onPointerLeftClick;
    public event VoidDelegate onPointerLeftDoubleClick;

    public delegate void EventCallBack();
    public delegate void EventsCallBack(int count);
    event EventCallBack awakeCallBack;
    event EventCallBack onApplicationPauseCallBack;
    event EventCallBack onApplicationFocusCallBack;
    event EventCallBack onApplicationQuitCallBack;
    event EventCallBack onBecameVisibleCallBack;
    event EventCallBack onBecameInVisibleCallBack;
    event EventCallBack onCollisionEnterCallBack;
    event EventCallBack onCollisionExitCallBack;
    event EventCallBack onCollisionStayCallBack;
    event EventCallBack onDestroyCallBack;
    event EventCallBack onDisableCallBack;
    event EventCallBack onEnableCallBack;
    event EventsCallBack onMouseDownCallBack;
    event EventCallBack onMouseEnterCallBack;
    event EventCallBack onMouseExitCallBack;
    event EventCallBack onMouseOverCallBack;
    event EventCallBack onMouseUpCallBack;
    event EventCallBack onTriggerEnterCallBack;
    event EventCallBack onTriggerExitCallBack;
    event EventCallBack onTriggerStayCallBack;
    event EventCallBack startCallBack;

    const int LeftMouseID = -1;
    const int RightMouseID = -2;
    const int CenterMouseID = -3;
    const int MouseClick = 1;
    const int DoubleMouseClick = 2;

    UGUIData data;
    #region Get

    static public UnityEventListener Get(GameObject go)
    {
        UnityEventListener listener = go.GetComponent<UnityEventListener>();
        if (listener == null) listener = go.AddComponent<UnityEventListener>();
        return listener;
    }

    static public UnityEventListener Get(Transform go)
    {
        UnityEventListener listener = go.GetComponent<UnityEventListener>();
        if (listener == null) listener = go.gameObject.AddComponent<UnityEventListener>();
        return listener;
    }

    #endregion

    #region UGUIEventListener

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        if (onPointerClickCallBack != null)
            onPointerClickCallBack();

        data = new UGUIData(gameObject, eventData, parameter);
        if (onPointerClick != null)
        {
            onPointerClick(ref data);
        }

        if (onPointerRightDoubleClick != null && eventData.pointerId == RightMouseID && eventData.clickCount == MouseClick)
        {
            onPointerRightDoubleClick(ref data);
        }

        if (onPointerLeftClick != null && eventData.pointerId == LeftMouseID && eventData.clickCount == MouseClick)
        {
            onPointerLeftClick(ref data);
        }

        if (onPointerLeftDoubleClick != null && eventData.pointerId == LeftMouseID && eventData.clickCount == DoubleMouseClick)
        {
            onPointerLeftDoubleClick(ref data);
        }

        if (onPointerRightClick != null && eventData.pointerId == RightMouseID && eventData.clickCount == MouseClick)
        {
            onPointerRightClick(ref data);
        }
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        if (onPointerDownCallBack != null)
            onPointerDownCallBack();

        if (onPointerDown != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onPointerDown(ref data);
        }
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        if (onPointerUpCallBack != null)
            onPointerUpCallBack();

        if (onPointerUp != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onPointerUp(ref data);
        }
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        if (onPointerEnterCallBack != null)
            onPointerEnterCallBack();

        if (onPointerEnter != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onPointerEnter(ref data);
        }
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        if (onPointerExitCallBack != null)
            onPointerExitCallBack();

        if (onPointerExit != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onPointerExit(ref data);
        }
    }

    void ISelectHandler.OnSelect(BaseEventData eventData)
    {
        if (onSelectCallBack != null)
            onSelectCallBack();

        if (onSelect != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onSelect(ref data);
        }
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        if (onBeginDragCallBack != null)
            onBeginDragCallBack();

        if (onBeginDrag != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onBeginDrag(ref data);
        }
    }

    void ICancelHandler.OnCancel(BaseEventData eventData)
    {
        if (onCancelCallBack != null)
            onCancelCallBack();

        if (onCancel != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onCancel(ref data);
        }
    }

    void IDeselectHandler.OnDeselect(BaseEventData eventData)
    {
        if (onDeselectCallBack != null)
            onDeselectCallBack();

        if (onDeselect != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onDeselect(ref data);
        }
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        if (onDragCallBack != null)
            onDragCallBack();

        if (onDrag != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onDrag(ref data);
        }
    }

    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        if (onDropCallBack != null)
            onDropCallBack();

        if (onDrag != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onDrag(ref data);
        }
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        if (onEndDragCallBack != null)
            onEndDragCallBack();

        if (onEndDrag != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onEndDrag(ref data);
        }
    }

    void IInitializePotentialDragHandler.OnInitializePotentialDrag(PointerEventData eventData)
    {
        if (onInitializePotentialDragCallBack != null)
            onInitializePotentialDragCallBack();

        if (onInitializePotentialDrag != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onInitializePotentialDrag(ref data);
        }
    }

    void IMoveHandler.OnMove(AxisEventData eventData)
    {
        if (onMoveCallBack != null)
            onMoveCallBack();

        if (onMove != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onMove(ref data);
        }
    }

    void IScrollHandler.OnScroll(PointerEventData eventData)
    {
        if (onScrollCallBack != null)
            onScrollCallBack();

        if (onScroll != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onScroll(ref data);
        }
    }

    void ISubmitHandler.OnSubmit(BaseEventData eventData)
    {
        if (onSubmitCallBack != null)
            onSubmitCallBack();

        if (onSubmit != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onSubmit(ref data);
        }
    }

    void IUpdateSelectedHandler.OnUpdateSelected(BaseEventData eventData)
    {
        if (onUpdateSelectedCallBack != null)
            onUpdateSelectedCallBack();

        if (onUpdateSelected != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onUpdateSelected(ref data);
        }
    }

    public UnityEventListener onPointerClickFuc(EventCallBack callBack)
    {
        if (callBack != null) this.onPointerClickCallBack += callBack;
        return this;
    }

    public UnityEventListener onPointerDownFuc(EventCallBack callBack)
    {
        if (callBack != null) this.onPointerDownCallBack += callBack;
        return this;
    }

    public UnityEventListener onPointerUpFuc(EventCallBack callBack)
    {
        if (callBack != null) this.onPointerUpCallBack += callBack;
        return this;
    }

    public UnityEventListener onPointerEnterFuc(EventCallBack callBack)
    {
        if (callBack != null) this.onPointerEnterCallBack += callBack;
        return this;
    }

    public UnityEventListener onPointerExitFuc(EventCallBack callBack)
    {
        if (callBack != null) this.onPointerExitCallBack += callBack;
        return this;
    }

    public UnityEventListener onSelectFuc(EventCallBack callBack)
    {
        if (callBack != null) this.onSelectCallBack += callBack;
        return this;
    }

    public UnityEventListener onBeginDragFuc(EventCallBack callBack)
    {
        if (callBack != null) this.onBeginDragCallBack += callBack;
        return this;
    }

    public UnityEventListener onCancelFuc(EventCallBack callBack)
    {
        if (callBack != null) this.onCancelCallBack += callBack;
        return this;
    }

    public UnityEventListener onDeselectFuc(EventCallBack callBack)
    {
        if (callBack != null) this.onDeselectCallBack += callBack;
        return this;
    }

    public UnityEventListener onDragFuc(EventCallBack callBack)
    {
        if (callBack != null) this.onDragCallBack += callBack;
        return this;
    }

    public UnityEventListener onDropFuc(EventCallBack callBack)
    {
        if (callBack != null) this.onDropCallBack += callBack;
        return this;
    }

    public UnityEventListener onEndDragFuc(EventCallBack callBack)
    {
        if (callBack != null) this.onEndDragCallBack += callBack;
        return this;
    }

    public UnityEventListener onInitializePotentialDragFuc(EventCallBack callBack)
    {
        if (callBack != null) this.onInitializePotentialDragCallBack += callBack;
        return this;
    }

    public UnityEventListener onMoveFuc(EventCallBack callBack)
    {
        if (callBack != null) this.onMoveCallBack += callBack;
        return this;
    }

    public UnityEventListener onScrollFuc(EventCallBack callBack)
    {
        if (callBack != null) this.onScrollCallBack += callBack;
        return this;
    }

    public UnityEventListener onSubmitFuc(EventCallBack callBack)
    {
        if (callBack != null) this.onSubmitCallBack += callBack;
        return this;
    }

    public UnityEventListener onUpdateSelectedFuc(EventCallBack callBack)
    {
        if (callBack != null) this.onUpdateSelectedCallBack += callBack;
        return this;
    }

    #endregion

    #region UnityEventListener

    void Awake()
    {
        if (awakeCallBack != null) awakeCallBack();
    }

    void OnApplicationPause()
    {
        if (onApplicationPauseCallBack != null) onApplicationPauseCallBack();
    }

    void OnApplicationFocus()
    {
        if (onApplicationFocusCallBack != null) onApplicationFocusCallBack();
    }

    void OnApplicationQuit()
    {
        if (onApplicationQuitCallBack != null) onApplicationQuitCallBack();
    }

    void OnBecameVisible()
    {
        if (onBecameVisibleCallBack != null) onBecameVisibleCallBack();
    }

    void OnBecameInVisible()
    {
        if (onBecameInVisibleCallBack != null) onBecameInVisibleCallBack();
    }

    void OnCollisionEnter()
    {
        if (onCollisionEnterCallBack != null) onCollisionEnterCallBack();
    }

    void OnCollisionExit()
    {
        if (onCollisionExitCallBack != null) onCollisionExitCallBack();
    }

    void OnCollisionStay()
    {
        if (onCollisionStayCallBack != null) onCollisionStayCallBack();
    }

    void OnDestroy()
    {
        if (onDestroyCallBack != null) onDestroyCallBack();
    }

    void OnDisable()
    {
        if (onDisableCallBack != null) onDisableCallBack();
    }

    void OnEnable()
    {
        if (onEnableCallBack != null) onEnableCallBack();
    }

    private int count = 0;
    void OnMouseDown()
    {
        count++;
        if (onMouseDownCallBack != null) onMouseDownCallBack(count);
    }

    void OnMouseEnter()
    {
        if (onMouseEnterCallBack != null) onMouseEnterCallBack();
    }

    void OnMouseExit()
    {
        if (onMouseExitCallBack != null) onMouseExitCallBack();
    }

    void OnMouseOver()
    {
        if (onMouseOverCallBack != null) onMouseOverCallBack();
    }

    void OnMouseUp()
    {
        if (onMouseUpCallBack != null) onMouseUpCallBack();
    }

    void OnTriggerEnter()
    {
        if (onTriggerEnterCallBack != null) onTriggerEnterCallBack();
    }

    void OnTriggerExit()
    {
        if (onTriggerExitCallBack != null) onTriggerExitCallBack();
    }

    void OnTriggerStay()
    {
        if (onTriggerStayCallBack != null) onTriggerStayCallBack();
    }

    void Start()
    {
        if (startCallBack != null) startCallBack();
    }

    public UnityEventListener awake(EventCallBack CallBack)
    {
        if (CallBack != null) this.awakeCallBack += CallBack;
        return this;
    }

    public UnityEventListener onApplicationPause(EventCallBack CallBack)
    {
        if (CallBack != null) this.onApplicationPauseCallBack += CallBack;
        return this;
    }

    public UnityEventListener onApplicationFocus(EventCallBack CallBack)
    {
        if (CallBack != null) this.onApplicationFocusCallBack += CallBack;
        return this;
    }

    public UnityEventListener onApplicationQuit(EventCallBack CallBack)
    {
        if (CallBack != null) this.onApplicationQuitCallBack += CallBack;
        return this;
    }

    public UnityEventListener onBecameVisible(EventCallBack CallBack)
    {
        if (CallBack != null) this.onBecameVisibleCallBack += CallBack;
        return this;
    }

    public UnityEventListener onBecameInVisible(EventCallBack CallBack)
    {
        if (CallBack != null) this.onBecameInVisibleCallBack += CallBack;
        return this;
    }

    public UnityEventListener onCollisionEnter(EventCallBack CallBack)
    {
        if (CallBack != null) this.onCollisionEnterCallBack += CallBack;
        return this;
    }

    public UnityEventListener onCollisionExit(EventCallBack CallBack)
    {
        if (CallBack != null) this.onCollisionExitCallBack += CallBack;
        return this;
    }

    public UnityEventListener onCollisionStay(EventCallBack CallBack)
    {
        if (CallBack != null) this.onCollisionStayCallBack += CallBack;
        return this;
    }

    public UnityEventListener onDestroy(EventCallBack CallBack)
    {
        if (CallBack != null) this.onDestroyCallBack += CallBack;
        return this;
    }

    public UnityEventListener onDisable(EventCallBack CallBack)
    {
        if (CallBack != null) this.onDisableCallBack += CallBack;
        return this;
    }

    public UnityEventListener onEnable(EventCallBack CallBack)
    {
        if (CallBack != null) this.onEnableCallBack += CallBack;
        return this;
    }

    public UnityEventListener onMouseDown(EventsCallBack CallBack)
    {
        if (CallBack != null) this.onMouseDownCallBack += CallBack;
        return this;
    }

    public UnityEventListener onMouseEnter(EventCallBack CallBack)
    {
        if (CallBack != null) this.onMouseEnterCallBack += CallBack;
        return this;
    }

    public UnityEventListener onMouseExit(EventCallBack CallBack)
    {
        if (CallBack != null) this.onMouseExitCallBack += CallBack;
        return this;
    }

    public UnityEventListener onMouseOver(EventCallBack CallBack)
    {
        if (CallBack != null) this.onMouseOverCallBack += CallBack;
        return this;
    }

    public UnityEventListener onMouseUp(EventCallBack CallBack)
    {
        if (CallBack != null) this.onMouseUpCallBack += CallBack;
        return this;
    }

    public UnityEventListener onTriggerEnter(EventCallBack CallBack)
    {
        if (CallBack != null) this.onTriggerEnterCallBack += CallBack;
        return this;
    }

    public UnityEventListener onTriggerExit(EventCallBack CallBack)
    {
        if (CallBack != null) this.onTriggerExitCallBack += CallBack;
        return this;
    }

    public UnityEventListener onTriggerStay(EventCallBack CallBack)
    {
        if (CallBack != null) this.onTriggerStayCallBack += CallBack;
        return this;
    }

    public UnityEventListener start(EventCallBack CallBack)
    {
        if (CallBack != null) this.startCallBack += CallBack;
        return this;
    }

    #endregion
}
