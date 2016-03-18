using UnityEngine;
using UnityEngine.EventSystems;

public class UnityEventListener : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerEnterHandler,
    IPointerExitHandler, IPointerUpHandler, ISelectHandler, IDragHandler, IDropHandler, IBeginDragHandler,
    IDeselectHandler, ICancelHandler, IEndDragHandler, IInitializePotentialDragHandler,
    IScrollHandler, IMoveHandler, ISubmitHandler, IUpdateSelectedHandler
//,IEventListener
{
    public delegate void VoidDelegate(UGUIData go);

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

    public delegate void EventCallBack();
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
    event EventCallBack onMouseDownCallBack;
    event EventCallBack onMouseEnterCallBack;
    event EventCallBack onMouseExitCallBack;
    event EventCallBack onMouseOverCallBack;
    event EventCallBack onMouseUpCallBack;
    event EventCallBack onTriggerEnterCallBack;
    event EventCallBack onTriggerExitCallBack;
    event EventCallBack onTriggerStayCallBack;
    event EventCallBack startCallBack;

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

    #region Instantiate

    public GameObject instantiate(GameObject go)
    {
        return Instantiate(go) as GameObject;
    }

    public GameObject instantiate(Transform tr)
    {
        return Instantiate(tr) as GameObject;
    }

    public GameObject instantiate(GameObject go, GameObject parent, bool isReset = true)
    {
        GameObject temp = instantiate(go);
        temp.transform.parent = parent.transform;
        if (isReset)
        {
            temp.transform.localScale = Vector3.one;
            temp.transform.localPosition = Vector3.zero;
            temp.transform.localEulerAngles = Vector3.zero; 
        }
        return temp;
    }

    public GameObject instantiate(Transform go, GameObject parent, bool isReset = true)
    {
        GameObject temp = instantiate(go);
        temp.transform.parent = parent.transform;
        if (isReset)
        {
            temp.transform.localScale = Vector3.one;
            temp.transform.localPosition = Vector3.zero;
            temp.transform.localEulerAngles = Vector3.zero;
        }
        return temp;
    }

    public GameObject instantiate(GameObject go, Transform parent, bool isReset = true)
    {
        GameObject temp = instantiate(go);
        temp.transform.parent = parent;
        if (isReset)
        {
            temp.transform.localScale = Vector3.one;
            temp.transform.localPosition = Vector3.zero;
            temp.transform.localEulerAngles = Vector3.zero;
        }
        return temp;
    }

    public GameObject instantiate(Transform go, Transform parent, bool isReset = true)
    {
        GameObject temp = instantiate(go);
        temp.transform.parent = parent;
        if (isReset)
        {
            temp.transform.localScale = Vector3.one;
            temp.transform.localPosition = Vector3.zero;
            temp.transform.localEulerAngles = Vector3.zero;
        }
        return temp;
    }

    public GameObject instantiate(GameObject go, GameObject parent, Vector3 localScale)
    {
        GameObject temp = instantiate(go);
        temp.transform.parent = parent.transform;
        temp.transform.localScale = localScale;
        temp.transform.localPosition = Vector3.zero;
        temp.transform.localEulerAngles = Vector3.zero;
        return temp;
    }

    public GameObject instantiate(GameObject go, GameObject parent, Vector3 localScale, Vector3 localPosition)
    {
        GameObject temp = instantiate(go);
        temp.transform.parent = parent.transform;
        temp.transform.localScale = localScale;
        temp.transform.localPosition = localPosition;
        temp.transform.localEulerAngles = Vector3.zero;
        return temp;
    }

    public GameObject instantiate(GameObject go, GameObject parent, Vector3 localScale, Vector3 localPosition,Vector3 localEulerAngles)
    {
        GameObject temp = instantiate(go);
        temp.transform.parent = parent.transform;
        temp.transform.localScale = localScale;
        temp.transform.localPosition = localPosition;
        temp.transform.localEulerAngles = localEulerAngles;
        return temp;
    }

    public GameObject instantiate(GameObject go, Transform parent, Vector3 localScale)
    {
        GameObject temp = instantiate(go);
        temp.transform.parent = parent;
        temp.transform.localScale = localScale;
        temp.transform.localPosition = Vector3.zero;
        temp.transform.localEulerAngles = Vector3.zero;
        return temp;
    }

    public GameObject instantiate(GameObject go, Transform parent, Vector3 localScale, Vector3 localPosition)
    {
        GameObject temp = instantiate(go);
        temp.transform.parent = parent;
        temp.transform.localScale = localScale;
        temp.transform.localPosition = localPosition;
        temp.transform.localEulerAngles = Vector3.zero;
        return temp;
    }

    public GameObject instantiate(GameObject go, Transform parent, Vector3 localScale, Vector3 localPosition, Vector3 localEulerAngles)
    {
        GameObject temp = instantiate(go);
        temp.transform.parent = parent;
        temp.transform.localScale = localScale;
        temp.transform.localPosition = localPosition;
        temp.transform.localEulerAngles = localEulerAngles;
        return temp;
    }
    #endregion

    #region Position,Scale,Rotation 

    public float X
    {
        set
        {
            Vector3 temp = transform.position;
            temp.x = value;
            transform.position = temp;
        }
    }

    public float Y
    {
        set
        {
            Vector3 temp = transform.position;
            temp.y = value;
            transform.position = temp;
        }
    }

    public float Z
    {
        set
        {
            Vector3 temp = transform.position;
            temp.z = value;
            transform.position = temp;
        }
    }

    public float LocalX
    {
        set
        {
            Vector3 temp = transform.localPosition;
            temp.x = value;
            transform.localPosition = temp;
        }
    }

    public float LocalY
    {
        set
        {
            Vector3 temp = transform.localPosition;
            temp.y = value;
            transform.localPosition = temp;
        }
    }

    public float LocalZ
    {
        set
        {
            Vector3 temp = transform.localPosition;
            temp.z = value;
            transform.localPosition = temp;
        }
    }

    public float ScaleX
    {
        set
        {
            Vector3 temp = transform.localScale;
            temp.x = value;
            transform.localScale = temp;
        }
    }

    public float ScaleY
    {
        set
        {
            Vector3 temp = transform.localScale;
            temp.y = value;
            transform.localScale = temp;
        }
    }

    public float ScaleZ
    {
        set
        {
            Vector3 temp = transform.localScale;
            temp.z = value;
            transform.localScale = temp;
        }
    }

    public float AngleX
    {
        set
        {
            Vector3 temp = transform.localEulerAngles;
            temp.x = value;
            transform.localEulerAngles = temp;
        }
    }

    public float AngleY
    {
        set
        {
            Vector3 temp = transform.localEulerAngles;
            temp.y = value;
            transform.localEulerAngles = temp;
        }
    }

    public float AngleZ
    {
        set
        {
            Vector3 temp = transform.localEulerAngles;
            temp.z = value;
            transform.localEulerAngles = temp;
        }
    }

    #endregion

    #region UGUI事件监听

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        if (onPointerClick != null) onPointerClick(new UGUIData(gameObject, eventData, parameter));
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        if (onPointerDown != null) onPointerDown(new UGUIData(gameObject, eventData, parameter));
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        if (onPointerUp != null) onPointerUp(new UGUIData(gameObject, eventData, parameter));
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        if (onPointerEnter != null) onPointerEnter(new UGUIData(gameObject, eventData, parameter));
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        if (onPointerExit != null) onPointerExit(new UGUIData(gameObject, eventData, parameter));
    }

    void ISelectHandler.OnSelect(BaseEventData eventData)
    {
        if (onSelect != null) onSelect(new UGUIData(gameObject, eventData, parameter));
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        if (onBeginDrag != null) onBeginDrag(new UGUIData(gameObject, eventData, parameter));
    }

    void ICancelHandler.OnCancel(BaseEventData eventData)
    {
        if (onCancel != null) onCancel(new UGUIData(gameObject, eventData, parameter));
    }

    void IDeselectHandler.OnDeselect(BaseEventData eventData)
    {
        if (onDeselect != null) onDeselect(new UGUIData(gameObject, eventData, parameter));
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        if (onDrag != null) onDrag(new UGUIData(gameObject, eventData, parameter));
    }

    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        if (onDrag != null) onDrag(new UGUIData(gameObject, eventData, parameter));
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        if (onEndDrag != null) onEndDrag(new UGUIData(gameObject, eventData, parameter));
    }

    void IInitializePotentialDragHandler.OnInitializePotentialDrag(PointerEventData eventData)
    {
        if (onInitializePotentialDrag != null) onInitializePotentialDrag(new UGUIData(gameObject, eventData, parameter));
    }

    void IMoveHandler.OnMove(AxisEventData eventData)
    {
        if (onMove != null) onMove(new UGUIData(gameObject, eventData, parameter));
    }

    void IScrollHandler.OnScroll(PointerEventData eventData)
    {
        if (onScroll != null) onScroll(new UGUIData(gameObject, eventData, parameter));
    }

    void ISubmitHandler.OnSubmit(BaseEventData eventData)
    {
        if (onSubmit != null) onSubmit(new UGUIData(gameObject, eventData, parameter));
    }

    void IUpdateSelectedHandler.OnUpdateSelected(BaseEventData eventData)
    {
        if (onUpdateSelected != null) onUpdateSelected(new UGUIData(gameObject, eventData, parameter));
    }

    #endregion

    #region Unity事件监听

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

    void OnMouseDown()
    {
        if (onMouseDownCallBack != null) onMouseDownCallBack();
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

    public void onMouseDown(UnityEventListener.EventCallBack CallBack)
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
