using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public static Vector3 ReachedPoint;
    //public Vector3 StartPoint;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(transform.position.x>ReachedPoint.x)
            {
                ReachedPoint = transform.position;
            }
        }
        //ReachedPoint = StartPoint;
    }



}
