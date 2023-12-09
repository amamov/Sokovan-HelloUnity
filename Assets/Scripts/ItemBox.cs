using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOveraped = false;
    
    private Renderer myRenderer;

    public Color touchColor;
    private Color originalColor;

    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }
    
    // 충돌을 한 순간
    private void OnTriggerEnter(Collider other)
    {
        // 객체가 other 객체와 충돌했을때...
        if (other.tag == "EndPoint")
        {
            myRenderer.material.color = touchColor;
            isOveraped = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            myRenderer.material.color = originalColor;
            isOveraped = false;
        }
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            myRenderer.material.color = touchColor;
            isOveraped = true;
        }
    }
}
