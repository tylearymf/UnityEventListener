public interface IEventListener
{
    void Awake();
    void OnApplicationPause();
    void OnApplicationFocus();
    void OnApplicationQuit();
    void OnBecameVisible();
    void OnBecameInVisible();
    void OnCollisionEnter();
    void OnCollisionExit();
    void OnCollisionStay();
    void OnDestroy();
    void OnDisable();
    void OnEnable();
    void OnMouseDown();
    void OnMouseEnter();
    void OnMouseExit();
    void OnMouseOver();
    void OnMouseUp();
    void OnTriggerEnter();
    void OnTriggerExit();
    void OnTriggerStay();
    void Start();

    void awake(UnityEventListener.EventCallBack CallBack);
    void onApplicationPause(UnityEventListener.EventCallBack CallBack);
    void onApplicationFocus(UnityEventListener.EventCallBack CallBack);
    void onApplicationQuit(UnityEventListener.EventCallBack CallBack);
    void onBecameVisible(UnityEventListener.EventCallBack CallBack);
    void onBecameInVisible(UnityEventListener.EventCallBack CallBack);
    void onCollisionEnter(UnityEventListener.EventCallBack CallBack);
    void onCollisionExit(UnityEventListener.EventCallBack CallBack);
    void onCollisionStay(UnityEventListener.EventCallBack CallBack);
    void onDestroy(UnityEventListener.EventCallBack CallBack);
    void onDisable(UnityEventListener.EventCallBack CallBack);
    void onEnable(UnityEventListener.EventCallBack CallBack);
    void onMouseDown(UnityEventListener.EventCallBack CallBack);
    void onMouseEnter(UnityEventListener.EventCallBack CallBack);
    void onMouseExit(UnityEventListener.EventCallBack CallBack);
    void onMouseOver(UnityEventListener.EventCallBack CallBack);
    void onMouseUp(UnityEventListener.EventCallBack CallBack);
    void onTriggerEnter(UnityEventListener.EventCallBack CallBack);
    void onTriggerExit(UnityEventListener.EventCallBack CallBack);
    void onTriggerStay(UnityEventListener.EventCallBack CallBack);
    void start(UnityEventListener.EventCallBack CallBack);
}
