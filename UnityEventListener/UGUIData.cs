using UnityEngine;
using UnityEngine.EventSystems;

    public struct UGUIData
    {
        public GameObject GO
        {
            get { return go; }
        }
        GameObject go;

        public PointerEventData PointerData
        {
            get { return pointerData; }
        }
        PointerEventData pointerData;

        public BaseEventData BaseData
        {
            get { return baseData; }
        }
        BaseEventData baseData;

        object Parameter
        {
            get { return parameter; }
        }
        public object parameter;

        public UGUIData(GameObject go, PointerEventData pointerData, object parameter = null)
        {
            this.go = go;
            this.pointerData = pointerData;
            this.baseData = null;
            this.parameter = parameter;
        }

        public UGUIData(GameObject go, BaseEventData baseData, object parameter = null)
        {
            this.go = go;
            this.pointerData = null;
            this.baseData = baseData;
            this.parameter = parameter;
        }
}
