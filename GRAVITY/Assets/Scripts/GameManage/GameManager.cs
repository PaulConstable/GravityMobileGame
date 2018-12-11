using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour {


    static public int StarsNeptuneIG;
    static public int StarsNeptuneOG;

    static public int StarsUranusIG;
    static public int StarsUranusOG;

    static public int StarsSaturnIG;
    static public int StarsSaturnOG;

    static public int StarsJupiterIG;
    static public int StarsJupiterOG;

    static public int StarsMarsIG;
    static public int StarsMarsOG;

    static public int StarsVenusIG;
    static public int StarsVenusOG;

    static public int StarsMercuryIG;
    static public int StarsMercuryOG;

    static public int StarsEarthIG;
    static public int StarsEarthOG;



    public int TotalStars;

    // text
    public Text starsNeptunetxt;
    public Text menuStarsNeptunetxt;
    

    public Text starsUranustxt;
    public Text menuStarsUranustxt;

    public Text starsSaturntxt;
    public Text menuStarsSaturntxt;

    public Text starsJupitertxt;
    public Text menuStarsJupitertxt;

    public Text starsMarstxt;
    public Text menuStarsMarstxt;

    public Text starsVenustxt;
    public Text menuStarsVenustxt;

    public Text starsMercurytxt;
    public Text menuStarsMercurytxt;

    public Text starsEarthtxt;
    public Text menuStarsEarthtxt;

    // Badges
    [SerializeField] private GameObject NeptuneBadgeUI;
    [SerializeField] private GameObject UranusBadgeUI;
    [SerializeField] private GameObject SaturnBadgeUI;
    [SerializeField] private GameObject JupiterBadgeUI;
    [SerializeField] private GameObject MarsBadgeUI;
    [SerializeField] private GameObject EarthBadgeUI;
    [SerializeField] private GameObject VenusBadgeUI;
    [SerializeField] private GameObject MercuryBadgeUI;

   

    void Start () {

      

        StarsNeptuneIG = 0;
        StarsUranusIG = 0;
        StarsSaturnIG = 0;
        StarsJupiterIG = 0;
        StarsMarsIG = 0;
        StarsEarthIG = 0;
        StarsVenusIG = 0;
        StarsMercuryIG = 0;

        menuStarsNeptunetxt.text = PlayerPrefs.GetInt("OGNeptune").ToString() + " / 10";
        menuStarsUranustxt.text = PlayerPrefs.GetInt("OGUranus").ToString() + " / 10";
        menuStarsSaturntxt.text = PlayerPrefs.GetInt("OGSaturn").ToString() + " / 10";
        menuStarsJupitertxt.text = PlayerPrefs.GetInt("OGJupiter").ToString() + " / 10";
        menuStarsMarstxt.text = PlayerPrefs.GetInt("OGMars").ToString() + " / 10";
        menuStarsEarthtxt.text = PlayerPrefs.GetInt("OGEarth").ToString() + " / 10";
        menuStarsVenustxt.text = PlayerPrefs.GetInt("OGVenus").ToString() + " / 10";
        menuStarsMercurytxt.text = PlayerPrefs.GetInt("OGMercury").ToString() + " / 10";





        if (PlayerPrefs.GetInt("OGNeptune") == 10)
        {
            NeptuneBadgeUI.SetActive(true);
        }

        if (PlayerPrefs.GetInt("OGUranus") == 10)
        {
            UranusBadgeUI.SetActive(true);
        }

        if (PlayerPrefs.GetInt("OGSaturn") == 10)
        {
            SaturnBadgeUI.SetActive(true);
        }

        if (PlayerPrefs.GetInt("OGJupiter") == 10)
        {
           JupiterBadgeUI.SetActive(true);
        }

        if (PlayerPrefs.GetInt("OGMars") == 10)
        {
            MarsBadgeUI.SetActive(true);
        }

        if (PlayerPrefs.GetInt("OGEarth") == 10)
        {
            EarthBadgeUI.SetActive(true);
        }

        if (PlayerPrefs.GetInt("OGVenus") == 10)
        {
            VenusBadgeUI.SetActive(true);
        }

        if (PlayerPrefs.GetInt("OGMercury") == 10)
        {
            MercuryBadgeUI.SetActive(true);
        }
       
    }
	
	// Update is called once per frame
	void Update () {

        starsNeptunetxt.text = "" + StarsNeptuneIG;
        starsUranustxt.text = "" + StarsUranusIG;
        starsSaturntxt.text = "" + StarsSaturnIG;
        starsJupitertxt.text = "" + StarsJupiterIG;
        starsMarstxt.text = "" + StarsMarsIG;
        starsEarthtxt.text = "" + StarsEarthIG;
        starsVenustxt.text = "" + StarsVenusIG;
        starsMercurytxt.text = "" + StarsMercuryIG;
    }


    //Update Stars
    public void StarsNeptune() // when called add 1 to the int
    {
        StarsNeptuneIG = StarsNeptuneIG + 1;
     
    }

    // put og to in
    public void OGNeptune()
    {
        if (StarsNeptuneIG > StarsNeptuneOG)
        {

            TotalStars = (TotalStars - StarsNeptuneOG) + StarsNeptuneIG;
            StarsNeptuneOG = StarsNeptuneIG;
            PlayerPrefs.SetInt("OGNeptune", StarsNeptuneOG);
        }
    }

    // uranus
    public void StarsUranus() // when called add 1 to the int
    {
        StarsUranusIG = StarsUranusIG + 1;
    }

    // put og to in
    public void OGUranus()
    {
        if (StarsUranusIG > StarsUranusOG)
        {
            TotalStars = (TotalStars - StarsUranusOG) + StarsUranusIG;
            StarsUranusOG = StarsUranusIG;
            PlayerPrefs.SetInt("OGUranus", StarsUranusOG);
        }
    }

    // Saturn
    public void StarsSaturn() // when called add 1 to the int
    {
        StarsSaturnIG = StarsSaturnIG + 1;
    }

    // put og to in
    public void OGSaturn()
    {
        if (StarsSaturnIG > StarsSaturnOG)
        {
            TotalStars = (TotalStars - StarsSaturnOG) + StarsSaturnIG;
            StarsSaturnOG = StarsSaturnIG;
            PlayerPrefs.SetInt("OGSaturn", StarsSaturnOG);
        }
    }
    // Jupiter
    public void StarsJupiter() // when called add 1 to the int
    {
        StarsJupiterIG = StarsJupiterIG + 1;
    }

    // put og to in
    public void OGJupiter()
    {
        if (StarsJupiterIG > StarsJupiterOG)
        {
            TotalStars = (TotalStars - StarsJupiterOG) + StarsJupiterIG;
            StarsJupiterOG = StarsJupiterIG;
            PlayerPrefs.SetInt("OGJupiter", StarsJupiterOG);
        }
    }

    // Mars
    public void StarsMars() // when called add 1 to the int
    {
        StarsMarsIG = StarsMarsIG + 1;
    }

    // put og to in
    public void OGMars()
    {
        if (StarsMarsIG > StarsMarsOG)
        {
            TotalStars = (TotalStars - StarsMarsOG) + StarsMarsIG;
            StarsMarsOG = StarsMarsIG;
            PlayerPrefs.SetInt("OGMars", StarsMarsOG);
        }
    }

    // Venus
    public void StarsVenus() // when called add 1 to the int
    {
        StarsVenusIG = StarsVenusIG + 1;
    }

    // put og to in
    public void OGVenus()
    {
        if (StarsVenusIG > StarsVenusOG)
        {
            TotalStars = (TotalStars - StarsVenusOG) + StarsVenusIG;
            StarsVenusOG = StarsVenusIG;
            PlayerPrefs.SetInt("OGVenus", StarsVenusOG);
        }
    }

    // Mercury
    public void StarsMercury() // when called add 1 to the int
    {
        StarsMercuryIG = StarsMercuryIG + 1;
    }

    // put og to in
    public void OGMercury()
    {
        if (StarsMercuryIG > StarsMercuryOG)
        {
            TotalStars = (TotalStars - StarsMercuryOG) + StarsMercuryIG;
            StarsMercuryOG = StarsMercuryIG;
            PlayerPrefs.SetInt("OGMercury", StarsMercuryOG);
        }
    }

    // Earth
    public void StarsEarth() // when called add 1 to the int
    {
        StarsEarthIG = StarsEarthIG + 1;
    }

    // put og to in
    public void OGEarth()
    {
        if (StarsEarthIG > StarsEarthOG)
        {
            TotalStars = (TotalStars - StarsEarthOG) + StarsEarthIG;
            StarsEarthOG = StarsEarthIG;
            PlayerPrefs.SetInt("OGEarth", StarsEarthOG);
        }
    }
}
