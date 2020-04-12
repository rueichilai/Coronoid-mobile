using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{

    public AdManager admanager;


    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void Play()
    {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
            PlayerStats.GamesPlayed++;
                   
             
            

            PlayerPrefs.SetInt("GamesPlayed", PlayerStats.GamesPlayed);
    }


    public void Stats()
    {
       

    }


}
