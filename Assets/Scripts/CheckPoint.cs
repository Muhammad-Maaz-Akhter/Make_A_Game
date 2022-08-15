using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public static Vector3 ReachedPoint;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(transform.position.x>ReachedPoint.x)
            {
                ReachedPoint = transform.position;
            }
        }
        
    }



}
