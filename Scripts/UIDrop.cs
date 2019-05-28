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
