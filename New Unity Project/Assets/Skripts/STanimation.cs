using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class STanimation : MonoBehaviour
{

    private NavMeshAgent myAgent;
    private Animator myAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        myAgent = GetComponent <NavMeshAgent>();
        myAnimator = GetComponent <Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
          //  myAnimator.Play("Soccer Penalty Kick");
        //}
        if (Input.GetMouseButtonUp(0))
        {
            myAnimator.enabled = !myAnimator.enabled;
        }
    }
}
