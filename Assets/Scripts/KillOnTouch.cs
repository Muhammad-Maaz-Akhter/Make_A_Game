using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnTouch : MonoBehaviour
{
    public BallHealth res;
    
   
    private void OnCollisionEnter(Collision collision)
    {
        
        res.RestartLevel1();
    }

   


}
