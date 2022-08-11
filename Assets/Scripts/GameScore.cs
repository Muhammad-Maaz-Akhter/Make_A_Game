using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScore : MonoBehaviour
{
    public static int CurrentScore = 0;
    float OffsetX = Screen.width/2;
    float OffsetY = 40;
    float sizeX = 100;
    float sizeY = 22;
    public AudioClip gameMusic;
    
    void Start()
    {
       
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = gameMusic;
        audio.Play();
        DontDestroyOnLoad(audio);
        CurrentScore = 0; 
    }
  
    private void OnGUI()
    {
        
        GUI.Box(new Rect(OffsetX-sizeX/2, OffsetY, sizeX, sizeY), "Score "+ CurrentScore);
    }
}
