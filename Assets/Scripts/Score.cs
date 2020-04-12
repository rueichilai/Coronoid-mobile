using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{

     int score;
     public Text highScore;

     public Text NEWHIGHSCORE;
    // Start is called before the first frame update
    void Start()
    {   
        NEWHIGHSCORE.enabled = false;
        score = 0;
        PlayerStats.Rounds = 0;
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        
    }

    // Update is called once per frame
    public void ScoreUp()
    {
        score++;
        PlayerStats.Rounds++;
        GetComponent<Text>().text = score.ToString();

        if (PlayerStats.Rounds > PlayerPrefs.GetInt("HighScore", 0)){

         PlayerPrefs.SetInt("HighScore", PlayerStats.Rounds);
        highScore.text = PlayerStats.Rounds.ToString();
        NEWHIGHSCORE.enabled = true;

        }
     
       
    }

}
