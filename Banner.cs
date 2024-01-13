/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Banner : MonoBehaviour
{
    

    public IEnumerator LoadBannerAdd()
    {
        while (!Advertisement.IsReady(BannerId))
            yield return null;

        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
        Advertisement.Banner.Show(BannerId);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}*/
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Banner : MonoBehaviour , IUnityAdsListener, IUnityAdsLoadListener
{/*
    // For the purpose of this example, these buttons are for functionality testing:
    //[SerializeField] Button _loadBannerButton;
    [SerializeField] Button _showBannerButton;
    //[SerializeField] Button _hideBannerButton;

   // [SerializeField] BannerPosition _bannerPosition = BannerPosition.TOP_CENTER;

    [SerializeField] string _androidAdUnitId = "Banner_Android";
    //[SerializeField] string _iOsAdUnitId = "Banner_iOS";
    // string _adUnitId;
    public string gameId = "4422865";
    public bool testmode = false;
    //public string BannerId = "Banner_Android";
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameId, testmode);
        // StartCoroutine(LoadBannerAdd());
        LoadBanner();
    }

    // Implement a method to call when the Load Banner button is clicked:
    public void LoadBanner()
    {
        // Set up options to notify the SDK of load events:
        BannerLoadOptions options = new BannerLoadOptions
        {
            loadCallback = OnBannerLoaded,
            errorCallback = OnBannerError
        };

        // Load the Ad Unit with banner content:
        Advertisement.Banner.Load(_androidAdUnitId, options);
    }

    // Implement code to execute when the loadCallback event triggers:
    void OnBannerLoaded()
    {
        Debug.Log("Banner loaded");
      //  ShowBannerAd();
        // Configure the Show Banner button to call the ShowBannerAd() method when clicked:
        // _showBannerButton.onClick.AddListener(ShowBannerAd);
        // Configure the Hide Banner button to call the HideBannerAd() method when clicked:
        //  _hideBannerButton.onClick.AddListener(HideBannerAd);

        // Enable both buttons:

    }

    // Implement code to execute when the load errorCallback event triggers:
    void OnBannerError(string message)
    {
        Debug.Log($"Banner Error: {message}");
        // Optionally execute additional code, such as attempting to load another ad.
    }

    // Implement a method to call when the Show Banner button is clicked:
    public void ShowBannerAd()
    {
        // Set up options to notify the SDK of show events:

        // Show the loaded Banner Ad Unit:
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_RIGHT);
       
        Advertisement.Banner.Show(_androidAdUnitId);
    }

    // Implement a method to call when the Hide Banner button is clicked:



 
}*/
    public string gameId = "4422865";
    public bool testmode = false;
    [SerializeField] string _androidAdUnitId = "Interstitial_Android";
    [SerializeField] string _iOsAdUnitId = "Interstitial_iOS";
string _adUnitId;

void Awake()
{
        Advertisement.Initialize(gameId, testmode);
        // Get the Ad Unit ID for the current platform:
        _adUnitId = (Application.platform == RuntimePlatform.IPhonePlayer)
        ? _iOsAdUnitId
        : _androidAdUnitId;
}
	private void Start()
	{
        LoadAd();

    }

	// Load content to the Ad Unit:
	public void LoadAd()
{
    // IMPORTANT! Only load content AFTER initialization (in this example, initialization is handled in a different script).
    Debug.Log("Loading Ad: " + _adUnitId);
    Advertisement.Load(_adUnitId, this);
}

// Show the loaded content in the Ad Unit: 
public void ShowAd()
{
		// Note that if the ad content wasn't previously loaded, this method will fail
		if (Advertisement.isInitialized)
		{
            Debug.Log("Showing Ad: " + _adUnitId);
            Advertisement.Show(_adUnitId);
		}
		else
		{
            Debug.Log("Play Game");
		}
   
}

// Implement Load Listener and Show Listener interface methods:  
public void OnUnityAdsAdLoaded(string adUnitId)
{
        
    // Optionally execute code if the Ad Unit successfully loads content.
}

public void OnUnityAdsFailedToLoad(string adUnitId, UnityAdsLoadError error, string message)
{
    Debug.Log($"Error loading Ad Unit: {adUnitId} - {error.ToString()} - {message}");
    // Optionally execite code if the Ad Unit fails to load, such as attempting to try again.
}

public void OnUnityAdsShowFailure(string adUnitId, UnityAdsShowError error, string message)
{
    Debug.Log($"Error showing Ad Unit {adUnitId}: {error.ToString()} - {message}");
    // Optionally execite code if the Ad Unit fails to show, such as loading another ad.
}

public void OnUnityAdsShowStart(string adUnitId) { }
public void OnUnityAdsShowClick(string adUnitId) { }
public void OnUnityAdsShowComplete(string adUnitId, UnityAdsShowCompletionState showCompletionState) { }

	public void OnUnityAdsReady(string placementId)
	{
		throw new System.NotImplementedException();
	}

	public void OnUnityAdsDidError(string message)
	{
		throw new System.NotImplementedException();
	}

	public void OnUnityAdsDidStart(string placementId)
	{
		throw new System.NotImplementedException();
	}

	public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
	{
		throw new System.NotImplementedException();
	}
}