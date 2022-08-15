using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnHit : MonoBehaviour
{
 
    private void OnCollisionEnter(Collision collision)
    {
        Transform enemy = transform.GetComponentInParent(Enemy);
        enemy.Die();
    }





}
