using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinker : MonoBehaviour
{

    public GameObject flashing_Label;

    public float interval;

    void Start()
    {
        InvokeRepeating("FlashLabel", 0, interval);
    }

    void FlashLabel()
    {
        if (flashing_Label.activeSelf)
            flashing_Label.SetActive(false);
        else
            flashing_Label.SetActive(true);
    }
}