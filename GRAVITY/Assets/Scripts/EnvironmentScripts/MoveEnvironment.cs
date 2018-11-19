using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveEnvironment : MonoBehaviour {

    GameManager gm; // Reference to the GameManager script

    private Vector2 startPosition;
    private float speed = 0.06f;

    // Use this for initialization
    void Start()
    {
        startPosition = transform.position;
       
        gm = GameObject.Find("GameManager").GetComponent<GameManager>(); // "grab" the GameManager
    }

    // Update is called once per frame
    void Update()
    {
      
            transform.position = new Vector2(transform.position.x - speed, transform.position.y);
      



        if (transform.position.x <= -15)
        {
            Destroy(gameObject);
        }
    }

  
}
