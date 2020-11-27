using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class penaltyShot : MonoBehaviour
{
    
    private Vector3 direction;
    private float acceleration = 5f;
    public Rigidbody ball;
    private bool clicked;
    private Vector3 startPoint;
    private Vector3 endPoint;
    private Vector3 aim;

    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        clicked = true;
        startPoint = Input.mousePosition;
    }

    private void OnMouseUp()
    {
        //endPoint = Input.mousePosition;
        clicked = false;
    }
   
    void FixedUpdate()
    {
        if (Input.GetMouseButtonUp(0))
        {


            if (clicked)
            {
                endPoint = Input.mousePosition;
                aim = (endPoint - startPoint) / 360;
               // print(aim);
                aim.z = 1f;
                ball.AddForce(aim.normalized * acceleration, ForceMode.Impulse);
            }
        }
    }
}
