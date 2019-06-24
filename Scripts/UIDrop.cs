using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIDrop : MonoBehaviour, IDropHandler, IPointerClickHandler
{
    

    public void OnDrop(PointerEventData eventData)
    {
        EventSystem.current.currentSelectedGameObject.transform.parent = transform;
        var sizey = GetComponent<RectTransform>().rect.size.y;
        int index = (int)((((transform.position.y+(sizey/2)) - Input.mousePosition.y))/35)+1;
        if(index <= 0)
        {
            index = 1;
        }
        EventSystem.current.currentSelectedGameObject.transform.SetSiblingIndex(index);
        
        // rebuilds the layout and its child elements (previously done in UIDrag)
        // the objects that allow drop are the ones who actually need this rebuild and
        // fix bug when dropping even number of elements on a drag vessel
        LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponent<RectTransform>());
    }

    public void OnPointerClick(PointerEventData eventData)
    {

    }

    void Start()
    {

    }

    void Update()
    {

    }

}
