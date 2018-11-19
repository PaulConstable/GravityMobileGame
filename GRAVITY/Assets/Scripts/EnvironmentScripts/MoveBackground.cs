 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour {

    private Vector2 startPosition;
    private float speed;

    // Use this for initialization
    void Start()
    {
        startPosition = transform.position;
        speed = 0.04f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed, transform.position.y);


    }
}