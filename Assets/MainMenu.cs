using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource Music;
    public void QuitGame()
    {
        Debug.Log("Game is Quiting");
        Application.Quit();
    }
    public void StarGame(string Level)
    {
        SceneManager.LoadScene(Level);
    }
    public void SetGameVolume(float Vol)
    {
        Music.volume = Vol;
    }

}
