using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallHealth : MonoBehaviour
{

    int MaxFalldistance = -2;
    private bool isRestart = false;
    
    public AudioClip gameOver;
   

    void Update()
    {
        if (transform.position.y<MaxFalldistance)
        {
            if (isRestart==false)
            {
                RestartLevel1();
            }
            
        }
    }
    IEnumerator Test(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        //SceneManager.LoadScene("Level1");
        transform.position = CheckPoint.ReachedPoint;
        isRestart = false;
    }

    public void RestartLevel1()
    {
        
        AudioSource audio = GetComponent<AudioSource>();
        isRestart = true;
        audio.clip = gameOver;
        audio.Play();
        StartCoroutine("Test", 2f);
        
    }
   

}
