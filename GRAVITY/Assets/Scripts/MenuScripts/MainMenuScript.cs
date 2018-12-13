using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MainMenuScript : MonoBehaviour {

    GameManager gm; // Reference to the GameManager script
    public VideoPlayer VideoPlayer; // Drag & Drop the GameObject holding the VideoPlayer component
    public GameObject ResetUI, ResetVideo;
    public string Levelname2;

    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>(); // "grab" the GameManager
    }

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

    public void resetData()
    {
        SceneManager.LoadScene("LogoVideo");
        gm.reset();
    }

    public void playVideo()
    {
        VideoPlayer.Play();
        Invoke("resetUI", 12f);
   
    }
    public void resetUI()
    {
        ResetUI.SetActive(true);
        ResetVideo.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}