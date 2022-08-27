using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EndDraw1 : MonoBehaviour, IDropHandler
{
    //public MouseDrag md;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag);
        GameObject go = eventData.pointerDrag;
        MouseDrag1 md=go.GetComponent<MouseDrag1>();
        md.DragStop(eventData,gameObject);
    }

}
