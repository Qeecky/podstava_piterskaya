using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalSkript : MonoBehaviour
{
    public GameObject ball;
    private float goalZR = -1.33f, goalZL = 1.379f, goalLine = 3.51f, goalHigh = 1.22f ;
    private Vector3 pos;
    

   
    void FixedUpdate()
    {
        if (ball.transform.position.z > goalZR && 
            ball.transform.position.z < goalZL && 
            ball.transform.position.x > goalLine &&
            ball.transform.position.y < goalHigh &&
            ball.transform.position.x < goalLine + 0.2f)
        {
            print("gooooooooooooal");
        }
    }
}
