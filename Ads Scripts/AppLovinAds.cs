/*using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AppLovinAds : MonoBehaviour
{
        public string adUnitId = "b4683c7317558224";
	private int retryAttempt;

	// Start is called before the first frame update
	*//* void Start()
     {
 *//*        MaxSdkCallbacks.OnSdkInitializedEvent += (MaxSdkBase.SdkConfiguration sdkConfiguration) => {

             MaxSdk.CreateBanner(BannerAdUnityID, MaxSdkBase.BannerPosition.BottomCenter);
             MaxSdk.SetBannerBackgroundColor(BannerAdUnityID, Color.black);



             // AppLovin SDK is initialized, start loading ads
         };
 *//*

         MaxSdk.SetSdkKey("GUKF8wKAz0nQQk3VXNApARyGR3G-v5pzzGG5H84aDlPnJy5HbBTx4B0FCccXtt36sxcDupMP7IT6xESQBSKL82");
         //MaxSdk.SetUserId("USER_ID");

         MaxSdk.InitializeSdk();
     }


     public void ShowApplovinBanner()
     {
         MaxSdk.ShowBanner(BannerAdUnityID);
     }


     // Update is called once per frame
     void Update()
     {

     }*//*

	private void Start()
	{
        MaxSdkCallbacks.OnSdkInitializedEvent += (MaxSdkBase.SdkConfiguration sdkConfiguration) => {

            // MaxSdk.CreateBanner(BannerAdUnityID, MaxSdkBase.BannerPosition.BottomCenter);
            //MaxSdk.SetBannerBackgroundColor(BannerAdUnityID, Color.black);

            InitializeRewardedAds();

            // AppLovin SDK is initialized, start loading ads
        };

        MaxSdk.SetSdkKey("GUKF8wKAz0nQQk3VXNApARyGR3G-v5pzzGG5H84aDlPnJy5HbBTx4B0FCccXtt36sxcDupMP7IT6xESQBSKL82");
        MaxSdk.InitializeSdk();
    }

	public void InitializeRewardedAds()
    {
        // Attach callback
        MaxSdkCallbacks.Rewarded.OnAdLoadedEvent += OnRewardedAdLoadedEvent;
        MaxSdkCallbacks.Rewarded.OnAdLoadFailedEvent += OnRewardedAdLoadFailedEvent;
        MaxSdkCallbacks.Rewarded.OnAdDisplayedEvent += OnRewardedAdDisplayedEvent;
        MaxSdkCallbacks.Rewarded.OnAdClickedEvent += OnRewardedAdClickedEvent;
        MaxSdkCallbacks.Rewarded.OnAdRevenuePaidEvent += OnRewardedAdRevenuePaidEvent;
        MaxSdkCallbacks.Rewarded.OnAdHiddenEvent += OnRewardedAdHiddenEvent;
        MaxSdkCallbacks.Rewarded.OnAdDisplayFailedEvent += OnRewardedAdFailedToDisplayEvent;
        MaxSdkCallbacks.Rewarded.OnAdReceivedRewardEvent += OnRewardedAdReceivedRewardEvent;

        // Load the first rewarded ad
        LoadRewardedAd();
    }

    private void LoadRewardedAd()
    {
        MaxSdk.LoadRewardedAd(adUnitId);
    }

    private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad is ready for you to show. MaxSdk.IsRewardedAdReady(adUnitId) now returns 'true'.
      
            MaxSdk.ShowRewardedAd(adUnitId);
        
        // Reset retry attempt
        retryAttempt = 0;
    }

    private void OnRewardedAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
    {
        // Rewarded ad failed to load 
        // AppLovin recommends that you retry with exponentially higher delays, up to a maximum delay (in this case 64 seconds).

        retryAttempt++;
        double retryDelay = Math.Pow(2, Math.Min(6, retryAttempt));

        Invoke("LoadRewardedAd", (float)retryDelay);
    }

    private void OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) { }

    private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad failed to display. AppLovin recommends that you load the next ad.
        LoadRewardedAd();
    }

    private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) { }

    private void OnRewardedAdHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad is hidden. Pre-load the next ad
        LoadRewardedAd();
    }

    private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdk.Reward reward, MaxSdkBase.AdInfo adInfo)
    {
        // The rewarded ad displayed and the user should receive the reward.
    }

    private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Ad revenue paid. Use this callback to track user revenue.
    }

    public void ShowAppLovinReward()
	{
        if (MaxSdk.IsRewardedAdReady(adUnitId))
        {
            MaxSdk.ShowRewardedAd(adUnitId);
		}
		else
		{
            LoadRewardedAd();
            MaxSdk.ShowRewardedAd(adUnitId);
        }
    }

}
*/