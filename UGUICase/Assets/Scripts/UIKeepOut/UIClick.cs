using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIClick : MonoBehaviour,IPointerClickHandler
{
    private int _index;


    // Update is called once per frame
    void Update()
    {
        
    }
    void ChangeColor()
    {
        if (_index == 0)
        {
            GetComponent<Image>().color = Color.black;
        }
        else
        {
            GetComponent<Image>().color = Color.white;
        }
        _index = _index == 0 ? 1 : 0;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ChangeColor();
    }
}
