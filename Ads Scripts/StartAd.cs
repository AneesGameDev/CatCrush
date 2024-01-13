/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StartApp;
using UnityEngine.UI;

public class StartAd : MonoBehaviour
{
    public Text publicText;
    public InterstitialAd ad;


    public void OnEnable()
    {
        ad = AdSdk.Instance.CreateInterstitial();
        // ad.RaiseAdLoaded += (sender, e) => ;
        ad.RaiseAdVideoCompleted += (sender, e) => {
            Debug.Log("Give the reward here");
            publicText.text = "StartApp Reward is Work User Get Reward................................";
            ad.LoadAd(InterstitialAd.AdType.Rewarded);
        };
    }
    void Start()
    {

        ad.LoadAd(InterstitialAd.AdType.Rewarded);
    }

    public void ShowStartAppAd()
    {

        if (ad.IsReady())
        {
            ad.ShowAd();
        }
        else
        {
            ad.LoadAd(InterstitialAd.AdType.Rewarded);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
*/