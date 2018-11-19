using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketUranus : MonoBehaviour
{

    GameManager gm; // Reference to the GameManager script

    [SerializeField] private GameObject PlayerUranus;

    private bool RocketUp = false;
    // Use this for initialization
    void Start()
    {
        RocketUp = false;
        gm = GameObject.Find("GameManager").GetComponent<GameManager>(); // "grab" the GameManager
    }

    // Update is called once per frame
    void Update()
    {
        if (RocketUp == true)
        {
            PlayerUranus.SetActive(false);
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.2f);
        }
    }


    void OnTriggerEnter2D(Collider2D other) // when collsion with the stars do the following
    {
        if (other.tag == "Player")
        {
            gm.OGUranus();
            RocketUp = true;
            //  SceneManager.LoadScene("Menu");
        }
    }
}