using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTriggers : MonoBehaviour
{

    private Vector2 startPosition;
    private float speed = 0.06f;

    // Use this for initialization
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed, transform.position.y);
    }
}