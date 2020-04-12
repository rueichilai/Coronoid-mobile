using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverWindow : MonoBehaviour
{
   
    public Button RetryButton;

    public GameObject Self;

    public Text roundsText;

    private AdManager admanager;

    void OnEnable(){

        roundsText.text = PlayerStats.Rounds.ToString();
    }
    
    // Start is called before the first frame update
    void Start()
    {
         admanager= GameObject.Find("AdManager").GetComponent<AdManager>();
         Self.SetActive(true);
         RetryButton.onClick.AddListener(DoOnClick);
         
    }

        void DoOnClick()
        {
            
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
            PlayerStats.GamesPlayed++;
            PlayerStats.TimesDied++;
            PlayerStats.Rounds = 0;
            PlayerPrefs.SetInt("GamesPlayed", PlayerStats.GamesPlayed);
            PlayerPrefs.SetInt("timesdied", PlayerStats.TimesDied);

              if((PlayerPrefs.GetInt("GamesPlayed") % 5)== 0){
                admanager.PlayInterstitialAd();
                }
                     
              
            
            

            
        }
public void Menu()
{

    UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    PlayerStats.TimesDied++;
    PlayerPrefs.SetInt("timesdied", PlayerStats.TimesDied);

       if((PlayerPrefs.GetInt("GamesPlayed") % 5) == 0){
                admanager.PlayInterstitialAd();
                }

}
    // Update is called once per frame
    void Update()
    {
        
    }
}
