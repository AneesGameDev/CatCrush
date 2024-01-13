/*using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using System.Collections;

public class AdsInitializer : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener , IUnityAdsListener
{
    [SerializeField] string _androidGameId= "4422865";
    [SerializeField] string _iOsGameId = "4422864";
    [SerializeField] bool _testMode =false ;
    [SerializeField] bool _enablePerPlacementMode = false ;
    [SerializeField] Button _showAdButton;
    [SerializeField] string _androidAdUnitId = "Rewarded_Android";
    [SerializeField] string _iOsAdUnitId = "Rewarded_iOS";
    [SerializeField] string InstertitialAdUnitId = "Interstitial_Android";
    string _adUnitId;
   // public string BannerId = "Banner_Android";
    private string _gameId;

    void Awake()
    {
        Advertisement.AddListener(this);
        InitializeAds();
        InitializeAddreward();
        

    }

    public void InitializeAds()
    {
        _gameId = (Application.platform == RuntimePlatform.IPhonePlayer)
            ? _iOsGameId
            : _androidGameId;
        Advertisement.Initialize(_gameId, _testMode, _enablePerPlacementMode, this);
    }

	public void InitializeAddreward() {
        _adUnitId = (Application.platform == RuntimePlatform.IPhonePlayer)
           ? _iOsAdUnitId
           : _androidAdUnitId;

        //Disable button until ad is ready to show
        _showAdButton.interactable = true;
    }

	public void OnEnable()
	{
        LoadAd();
        LoadInterstitialAd();
    }
	private void Start()
	{
        
      

    }

  

	// Load content to the Ad Unit:
	public void LoadAd()
    {
        // IMPORTANT! Only load content AFTER initialization (in this example, initialization is handled in a different script).
        Debug.Log("Loading Ad: " + _adUnitId);
        Advertisement.Load(_adUnitId, this);
    }

    // If the ad successfully loads, add a listener to the button and enable it:
    public void OnUnityAdsAdLoaded(string adUnitId)
    {
        Debug.Log("Ad Loaded: " + adUnitId);

        if (adUnitId.Equals(_adUnitId))
        {
            // Configure the button to call the ShowAd() method when clicked:
           // _showAdButton.onClick.AddListener(ShowAd);
            // Enable the button for users to click:
            _showAdButton.interactable = true;
        }
    }

    // Implement a method to execute when the user clicks the button.
    public void ShowAd()
    {
        // Disable the button: 
        _showAdButton.interactable = true;
        // Then show the ad:
        Advertisement.Show(_adUnitId, this);
    }

    // Implement the Show Listener's OnUnityAdsShowComplete callback method to determine if the user gets a reward:
    public void OnUnityAdsShowComplete(string adUnitId, UnityAdsShowCompletionState showCompletionState)
    {
        Debug.Log("Coins Added");
        if (adUnitId.Equals(_adUnitId) && showCompletionState.Equals(UnityAdsShowCompletionState.COMPLETED))
        {
            Debug.Log("Unity Ads Rewarded Ad Completed");
            // Grant a reward.
            Debug.Log("Coins Added");
            // Load another ad:
            Advertisement.Load(_adUnitId, this);
        }
    }

    // Implement Load and Show Listener error callbacks:
    public void OnUnityAdsFailedToLoad(string adUnitId, UnityAdsLoadError error, string message)
    {
        Debug.Log($"Error loading Ad Unit {adUnitId}: {error.ToString()} - {message}");
        // Use the error details to determine whether to try to load another ad.
    }

    public void OnUnityAdsShowFailure(string adUnitId, UnityAdsShowError error, string message)
    {
        Debug.Log($"Error showing Ad Unit {adUnitId}: {error.ToString()} - {message}");
        // Use the error details to determine whether to try to load another ad.
    }

    public void OnUnityAdsShowStart(string adUnitId) { }
    public void OnUnityAdsShowClick(string adUnitId) { }

    void OnDestroy()
    {
        // Clean up the button listeners:
       // _showAdButton.onClick.RemoveAllListeners();
    }



public void OnInitializationComplete()
    {
        Debug.Log("Unity Ads initialization complete.");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
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
		if (showResult == ShowResult.Finished && placementId==_androidAdUnitId) {

		Debug.Log("Coins Added");
            LoadAd();
            //throw new System.NotImplementedException();
        }
		else
		{
            Debug.Log("Adds Not XComplete");
		}
    }

    public void LoadInterstitialAd()
    {
        // IMPORTANT! Only load content AFTER initialization (in this example, initialization is handled in a different script).
        Debug.Log("Loading Ad: " + InstertitialAdUnitId);
        Advertisement.Load(InstertitialAdUnitId, this);
    }

    // Show the loaded content in the Ad Unit: 
    public void ShowInterstitialAd()
    {
        // Note that if the ad content wasn't previously loaded, this method will fail
        Debug.Log("Showing Ad: " + InstertitialAdUnitId);
        Advertisement.Show(InstertitialAdUnitId, this);
    }




}

*/