using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody player;
    float bounceAmount = 8f;
    public Transform deathParticles;
    public void Die()
    {
        player.AddForce(new Vector3(0f, bounceAmount, 0f), ForceMode.Impulse);
        Instantiate(deathParticles, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
