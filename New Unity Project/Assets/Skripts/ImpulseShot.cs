using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.EventSystems;

public class ImpulseShot : MonoBehaviour
{
    public  Vector3  direction;
    public float acceleration;
    public Rigidbody rb;
    private Vector3 MousePos;
    private float mouse_Z ;

   
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
             MousePos = Input.mousePosition;
            mouse_Z = MousePos.x;
            print(MousePos.z);
            if (mouse_Z >= 0)
            {
                rb.AddForce(direction.normalized * acceleration, ForceMode.Impulse);
                
            }
        } 
    }  
}
