using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StartApp;
using UnityEngine.UI;
using System;

public class StartAppAdsScript : MonoBehaviour
{
    public Text publicText;
    public InterstitialAd ad;
    public Board board;
    public bool FailedShow = false;


    public void OnEnable()
    {
 
    }
    void Start()
    {
        board = FindObjectOfType<Board>();
/*        ad = AdSdk.Instance.CreateInterstitial();
        // ad.RaiseAdLoaded += (sender, e) => ;
        ad.RaiseAdVideoCompleted += OnVideoComplete;
        ad.RaiseAdLoaded += OnAdLoaded;
       

        ad.LoadAd(InterstitialAd.AdType.Rewarded);*/
    }

	private void OnAdLoaded(object sender, EventArgs e)
	{
        if (FailedShow)
		{
            FailedShow = false;
            ad.ShowAd();

        }
		throw new NotImplementedException();
	}

	private void OnVideoComplete(object sender, EventArgs e)
	{
    
            board.RewardAdCoins();
            this.gameObject.GetComponent<Cat>().MakeRewardCat();
            ad.LoadAd(InterstitialAd.AdType.Rewarded);
            Debug.Log("Give the reward here");
            publicText.text = "StartApp Reward is Work User Get Reward................................";
            //ad.LoadAd(InterstitialAd.AdType.Rewarded);
        
        throw new NotImplementedException();
	}

	public void ShowStartAppAd()
    {


        // Here Link Of Qureka Is Given



/*        Cat.rewardtimeisOn = true;
        if (ad.IsReady())
        {
            //Cat.rewardtimeisOn = true;
            ad.ShowAd();
        }
        else
        {
            FailedShow = true;
            ad.LoadAd(InterstitialAd.AdType.Rewarded);
           
        }*/
    }

    // Update is called once per frame
    void Update()
    {

    }
}
