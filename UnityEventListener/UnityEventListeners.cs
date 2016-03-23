using UnityEngine;
using UnityEngine.EventSystems;

public class UnityEventListener : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerEnterHandler,
    IPointerExitHandler, IPointerUpHandler, ISelectHandler, IDragHandler, IDropHandler, IBeginDragHandler,
    IDeselectHandler, ICancelHandler, IEndDragHandler, IInitializePotentialDragHandler,
    IScrollHandler, IMoveHandler, ISubmitHandler, IUpdateSelectedHandler
//,IEventListener
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

        if(onPointerRightClick != null && eventData.pointerId == RightMouseID && eventData.clickCount == MouseClick)
        {
            onPointerRightClick(ref data);
        }
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        if (onPointerDown != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onPointerDown(ref data);
        }
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        if (onPointerUp != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onPointerUp(ref data);
        }
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        if (onPointerEnter != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onPointerEnter(ref data);
        }
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        if (onPointerExit != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onPointerExit(ref data);
        }
    }

    void ISelectHandler.OnSelect(BaseEventData eventData)
    {
        if (onSelect != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onSelect(ref data);
        }
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        if (onBeginDrag != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onBeginDrag(ref data);
        }
    }

    void ICancelHandler.OnCancel(BaseEventData eventData)
    {
        if (onCancel != null) onCancel(ref data);
    }

    void IDeselectHandler.OnDeselect(BaseEventData eventData)
    {
        if (onDeselect != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onDeselect(ref data);
        }
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        if (onDrag != null) onDrag(ref data);
    }

    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        if (onDrag != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onDrag(ref data);
        }
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        if (onEndDrag != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onEndDrag(ref data);
        }
    }

    void IInitializePotentialDragHandler.OnInitializePotentialDrag(PointerEventData eventData)
    {
        if (onInitializePotentialDrag != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onInitializePotentialDrag(ref data);
        }
    }

    void IMoveHandler.OnMove(AxisEventData eventData)
    {
        if (onMove != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onMove(ref data);
        }
    }

    void IScrollHandler.OnScroll(PointerEventData eventData)
    {
        if (onScroll != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onScroll(ref data);
        }
    }

    void ISubmitHandler.OnSubmit(BaseEventData eventData)
    {
        if (onSubmit != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onSubmit(ref data);
        }
    }

    void IUpdateSelectedHandler.OnUpdateSelected(BaseEventData eventData)
    {
        if (onUpdateSelected != null)
        {
            data = new UGUIData(gameObject, eventData, parameter);
            onUpdateSelected(ref data);
        }
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

    public void awake(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.awakeCallBack += CallBack;

        //if (CallBack != null) this.awakeCallBack += delegate() 
        //{
        //    try
        //    {
        //        CallBack();
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.LogError(ex);
        //    }
        //};
    }

    public void onApplicationPause(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.onApplicationPauseCallBack += CallBack;
    }

    public void onApplicationFocus(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.onApplicationFocusCallBack += CallBack;
    }

    public void onApplicationQuit(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.onApplicationQuitCallBack += CallBack;
    }

    public void onBecameVisible(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.onBecameVisibleCallBack += CallBack;
    }

    public void onBecameInVisible(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.onBecameInVisibleCallBack += CallBack;
    }

    public void onCollisionEnter(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.onCollisionEnterCallBack += CallBack;
    }

    public void onCollisionExit(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.onCollisionExitCallBack += CallBack;
    }

    public void onCollisionStay(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.onCollisionStayCallBack += CallBack;
    }

    public void onDestroy(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.onDestroyCallBack += CallBack;
    }

    public void onDisable(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.onDisableCallBack += CallBack;
    }

    public void onEnable(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.onEnableCallBack += CallBack;
    }

    public void onMouseDown(UnityEventListener.EventsCallBack CallBack)
    {
        if (CallBack != null) this.onMouseDownCallBack += CallBack;
    }

    public void onMouseEnter(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.onMouseEnterCallBack += CallBack;
    }

    public void onMouseExit(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.onMouseExitCallBack += CallBack;
    }

    public void onMouseOver(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.onMouseOverCallBack += CallBack;
    }

    public void onMouseUp(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.onMouseUpCallBack += CallBack;
    }

    public void onTriggerEnter(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.onTriggerEnterCallBack += CallBack;
    }

    public void onTriggerExit(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.onTriggerExitCallBack += CallBack;
    }

    public void onTriggerStay(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.onTriggerStayCallBack += CallBack;
    }

    public void start(UnityEventListener.EventCallBack CallBack)
    {
        if (CallBack != null) this.startCallBack += CallBack;
    }

    #endregion
}
