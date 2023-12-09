using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // public Transform myTransform;
    
    // Update는 대략 1초에 60번
    void Update()
    {
        // myTransform.Rotate(60, 60, 60);    
        transform.Rotate(60 * Time.deltaTime, 60 * Time.deltaTime, 60 * Time.deltaTime);
        
        // Time.deltaTime : 화면이 한 번 깜박이는 시간 = 한 프레임의 시간
        // 초당 화면을 60번 깜박이면 1/60 
    }
}
