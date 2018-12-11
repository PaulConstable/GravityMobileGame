using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MainMenuScript : MonoBehaviour {

    public VideoPlayer VideoPlayer; // Drag & Drop the GameObject holding the VideoPlayer component
    public string Levelname2;
 

    public void SelectLevel(string levelName)
    {
        Levelname2 = levelName;
        VideoPlayer.Play();
        Invoke("MyLoadingFunction", 3f);      
    }

    public void MyLoadingFunction()
    {
        SceneManager.LoadScene(Levelname2);
    }

public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}