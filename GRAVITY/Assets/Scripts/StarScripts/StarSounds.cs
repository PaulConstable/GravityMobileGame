using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSounds : MonoBehaviour {

    public AudioClip MusicClip;
    public AudioSource MusicSource;

	// Use this for initialization
	void Start () {
        MusicSource.clip = MusicClip;
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
