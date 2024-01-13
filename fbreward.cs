/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AudienceNetwork;

public class fbreward : MonoBehaviour
{
    private bool isLoaded;
    private RewardedVideoAd rewardedVideoAd;

	private void Start()
	{
        LoadRewardedVideo();

    }
	public void LoadRewardedVideo()
    {
        // Create the rewarded video unit with a placement ID (generate your own on the Facebook app settings).
        // Use different ID for each ad placement in your app.
        this.rewardedVideoAd = new RewardedVideoAd("200863142183116_200888012180629");

        this.rewardedVideoAd.Register(this.gameObject);

        // Set delegates to get notified on changes or when the user interacts with the ad.
        this.rewardedVideoAd.RewardedVideoAdDidLoad = (delegate () {
            Debug.Log("RewardedVideo ad loaded.");
            this.isLoaded = true;
        });
        this.rewardedVideoAd.RewardedVideoAdDidFailWithError = (delegate (string error) {
            Debug.Log("RewardedVideo ad failed to load with error: " + error);
        });
        this.rewardedVideoAd.RewardedVideoAdWillLogImpression = (delegate () {
            Debug.Log("RewardedVideo ad logged impression.");
        });
        this.rewardedVideoAd.RewardedVideoAdDidClick = (delegate () {
            Debug.Log("RewardedVideo ad clicked.");
        });

        this.rewardedVideoAd.RewardedVideoAdDidClose = (delegate () {
            Debug.Log("Rewarded video ad did close.");
            if (this.rewardedVideoAd != null)
            {
                this.rewardedVideoAd.Dispose();
            }
        });

        // Initiate the request to load the ad.
        this.rewardedVideoAd.LoadAd();
    }

    public void ShowRewardedVideo()
    {
        if (this.isLoaded)
        {
            this.rewardedVideoAd.Show();
            this.isLoaded = false;
        }
        else
        {
            Debug.Log("Ad not loaded. Click load to request an ad.");
        }
    }



}*/