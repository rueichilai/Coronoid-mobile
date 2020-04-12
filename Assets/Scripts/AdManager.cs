using UnityEngine.Advertisements;
using UnityEngine;
using UnityEngine.UI;
public class AdManager : MonoBehaviour, IUnityAdsListener
{
    private string playStoreID = "3544727";
    private string appStoreID = "3544726";

    private string interstitialAd = "video";
    private string rewardedVideoAd = "rewardedVideo";

    public bool isTargetPlayStore;
    public bool isTestAd;

    public GameObject skin1selectbtn;

    public Text skin1selecttxt;

    public Text defaultselecttxt;

    public GameObject skin1adbtn;

    private void Start()
    {
        DontDestroyOnLoad(this);
        Advertisement.AddListener(this);
        InitializeAdvertisement();

    } 

    private void InitializeAdvertisement()
    {
        if (isTargetPlayStore)
        {
            Advertisement.Initialize(playStoreID, isTestAd);
            return;
        }
        Advertisement.Initialize(appStoreID, isTestAd);
    }

    public void PlayInterstitialAd()
    {
        if(!Advertisement.IsReady(interstitialAd)){
            return;
        }
        Advertisement.Show(interstitialAd);
    }

    public void PlayRewardedVideoAd() {
        if(!Advertisement.IsReady(rewardedVideoAd))
        {
            return;
        }
        Advertisement.Show(rewardedVideoAd);

    }

    public void OnUnityAdsReady(string placementId)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidError(string message)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        switch(showResult){

            case ShowResult.Failed:
                break;
            case ShowResult.Skipped:
                break;
            case ShowResult.Finished:
                if(placementId == rewardedVideoAd){
                    if((PlayerPrefs.GetInt("unlocked")== 1)){
                        skin1selectbtn.SetActive(true);
                        skin1selecttxt.text = "selected";
                         defaultselecttxt.text = "select";
                         skin1adbtn.SetActive(false);
                         PlayerPrefs.SetInt("updateunlock", 1);
      }
                }
                break;

        }

    }
}
