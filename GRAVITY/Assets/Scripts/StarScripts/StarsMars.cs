using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsMars : MonoBehaviour {

    GameManager gm; // Reference to the GameManager script
    public AudioClip MusicClip;
    public AudioSource MusicSource;


    // Use this for initialization
    void Start()
    {
        MusicSource.clip = MusicClip;
        gm = GameObject.Find("GameManager").GetComponent<GameManager>(); // "grab" the GameManager
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void OnTriggerEnter2D(Collider2D other) // when collsion with the stars do the following
    {
        if (other.tag == "Player")
        {
            gm.StarsMars(); // call the function stars within the GameManager
            MusicSource.Play();
            Destroy(gameObject); // Destroy
        }
    }
}
