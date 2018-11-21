﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMercury : MonoBehaviour {

    GameManager gm; // Reference to the GameManager script

    [SerializeField] private GameObject PlayerMercury;

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
            PlayerMercury.SetActive(false);
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.2f);
        }
    }


    void OnTriggerEnter2D(Collider2D other) // when collsion with the stars do the following
    {
        if (other.tag == "Player")
        {
            gm.OGMercury();
            RocketUp = true;
            //  SceneManager.LoadScene("Menu");
        }
    }
}