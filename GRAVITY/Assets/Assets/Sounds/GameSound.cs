using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameSound : MonoBehaviour
{
    private static GameSound instance = null;
    public static GameSound Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}


