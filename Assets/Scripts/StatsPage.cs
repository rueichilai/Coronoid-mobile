using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StatsPage : MonoBehaviour
{

    public Text menutext;

    public Text gamesPLAYED;

    public Text timesDied;


    // Start is called before the first frame update
    void Start()
    {
        menutext.text = PlayerPrefs.GetInt("HighScore").ToString();
        gamesPLAYED.text = PlayerPrefs.GetInt("GamesPlayed").ToString();
        timesDied.text = PlayerPrefs.GetInt("timesdied").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetStats()
    {
        PlayerPrefs.SetInt("timesdied", 0);
        PlayerPrefs.SetInt("GamesPlayed", 0);
        PlayerStats.GamesPlayed = 0;
        PlayerStats.TimesDied = 0;
        PlayerPrefs.DeleteKey("HighScore");
        //PlayerPrefs.SetInt("unlocked", 2);
        PlayerPrefs.SetInt("Skintype", 1);
        //PlayerPrefs.SetInt("updateunlock", 2);
        menutext.text = "0";
        timesDied.text = "0";
        gamesPLAYED.text = "0";

    }
}
