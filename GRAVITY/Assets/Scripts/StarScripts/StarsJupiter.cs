using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsJupiter : MonoBehaviour {

    GameManager gm; // Reference to the GameManager script

    // Use this for initialization
    void Start()
    {
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
            gm.StarsJupiter(); // call the function stars within the GameManager
            Destroy(gameObject); // Destroy
        }
    }
}
