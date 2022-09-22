using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackstabComponent : MonoBehaviour
{
    public Transform target;
        
    void Update()
    {
             
        Transform thisTransform = gameObject.GetComponent<Transform>();
        float directionDot = Vector3.Dot(target.forward, thisTransform.forward);
        
        Vector3 fromThisToTarget = target.position - thisTransform.position;
        Vector3 directionToTarget = fromThisToTarget.normalized;
        float positionDot = Vector3.Dot(directionToTarget, thisTransform.forward);
        
        if(directionDot >= 0.7f //You have to be facing your target's back
          && positionDot >= 0.8f) //You have to be behind your target
        {
            Debug.Log("Can backstab");
        }
        else
        {
            Debug.Log("Cannot backstab");
        }
    }
}
