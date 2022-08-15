using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float RotateSpeed=100f;
    public float jump=8f;
    bool IsFalling = false;

    public AudioClip ballHit;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotate = Input.GetAxis("Horizontal") * RotateSpeed;
        rotate *= Time.deltaTime;
        rb.AddRelativeTorque(Vector3.back * rotate);
        
        if (Input.GetKeyDown(KeyCode.W) && IsFalling==true)
        {
            IsFalling = false;
            rb.AddForce(new Vector3(0f, jump, 0f),ForceMode.Impulse);
            
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = ballHit;
            audio.Play();
            IsFalling =true;
        }
       
    }


}
