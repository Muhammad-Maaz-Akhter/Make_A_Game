using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    float lift = 1.5f;
    float distance = -10f;

    void LateUpdate()
    {
        transform.position = target.position + new Vector3(0f, lift, distance);
        transform.LookAt(target);
    }
}
