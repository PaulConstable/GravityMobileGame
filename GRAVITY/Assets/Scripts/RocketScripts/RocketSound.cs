using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketSound : MonoBehaviour {

    public AudioSource MusicSource;

	// Use this for initialization
	void Start () {
        MusicSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            MusicSource.Play();
        }
    }
}
