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

        menuStarsNeptunetxt.text = StarsNeptuneOG + " / 10";
        menuStarsUranustxt.text = StarsUranusOG + " / 10";
        menuStarsSaturntxt.text = StarsSaturnOG + " / 10";
        menuStarsJupitertxt.text = StarsJupiterOG + " / 10";
        menuStarsMarstxt.text = StarsMarsOG + " / 10";
        menuStarsEarthtxt.text = StarsEarthOG + " / 10";
        menuStarsVenustxt.text = StarsVenusOG + " / 10";
        menuStarsMercurytxt.text = StarsMercuryOG + " / 10";


        if (StarsNeptuneOG == 10)
        {
            NeptuneBadgeUI.SetActive(true);
        }

        if (StarsUranusOG == 10)
        {
            UranusBadgeUI.SetActive(true);
        }

        if (StarsSaturnOG == 10)
        {
            SaturnBadgeUI.SetActive(true);
        }

        if (StarsJupiterOG == 10)
        {
           JupiterBadgeUI.SetActive(true);
        }

        if (StarsMarsOG == 10)
        {
            MarsBadgeUI.SetActive(true);
        }

        if (StarsEarthOG == 10)
        {
            EarthBadgeUI.SetActive(true);
        }

        if (StarsVenusOG == 10)
        {
            VenusBadgeUI.SetActive(true);
        }

        if (StarsMercuryOG == 10)
        {
            MercuryBadgeUI.SetActive(true);
        }
       
    }
	
	// Update is called once per frame
	void Update () {

        starsNeptunetxt.text = "Stars: " + StarsNeptuneIG;
        starsUranustxt.text = "Stars: " + StarsUranusIG;
        starsSaturntxt.text = "Stars: " + StarsSaturnIG;
        starsJupitertxt.text = "Stars: " + StarsJupiterIG;
        starsMarstxt.text = "Stars: " + StarsMarsIG;
        starsEarthtxt.text = "Stars: " + StarsEarthIG;
        starsVenustxt.text = "Stars: " + StarsVenusIG;
        starsMercurytxt.text = "Stars: " + StarsMercuryIG;
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
        }
    }
}
