using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathNoise : MonoBehaviour {

    public AudioSource MusicSource;

	// Use this for initialization
	void Start () {
        MusicSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            MusicSource.Play();
        }
    }

}
