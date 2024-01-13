/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TapjoyUnity;
using UnityEngine.UI;

public class tapjoyads : MonoBehaviour
{
    public Text text;
    public Text DisplayResult;
    private bool CreatePlacement = false;
    public TJPlacement p;
    private string AppSdkId = "PurSmlGDQI2Eh2nTPVS7rAECHjCCqJoPMiMbyuCOxYPn333I59irhcK_kDl8";
    Dictionary<string, object> connectFlags = new Dictionary<string, object>();
    private bool First = true;
    private bool Second = true;
    // Start is called before the first frame update
    void Start()
    {

        Tapjoy.OnConnectSuccess += OnConnectSuccess;
        Tapjoy.OnConnectFailure += OnConnectFailure;
        Tapjoy.OnVideoStart += HandleVideoStart;
        Tapjoy.OnVideoComplete += HandleVideoComplete;

        *//*        if (!Tapjoy.IsConnected)
                {
                    Tapjoy.OnConnectSuccess += OnConnectSuccess;
                    Tapjoy.OnConnectFailure += OnConnectFailure;

                    text.text = "TapJoy Connect Called..................................";
                    Debug.Log("TapJoy Connect Called..................................");
                    Tapjoy.Connect(AppSdkId,connectFlags);
                }*//*
        //TJPlacement.OnRequestSuccess += HandlePlacementRequestSuccess;
    }

    // Update is called once per frame
    void Update()
    {
        *//*        if (!CreatePlacement)
                {
                    CreatePlacement = true;
                    if (Tapjoy.IsConnected)
                {

                        p = TJPlacement.CreatePlacement("AppLaunch");
                        p.RequestContent();


                        CreatePlacement = true;

                }
                else
                {
                   // Tapjoy.Connect();
                    text.text = "Tapjoy SDK must be connected before you can request content....................";
                    Debug.LogWarning("Tapjoy SDK must be connected before you can request content....................");

                }
            }*//*
    }
    public void ShowTapJoyAdd()
    {

       
        Tapjoy.Connect(AppSdkId, connectFlags);
        text.text = "TapJoy Connect Called..................................";
        Debug.Log("TapJoy Connect Called..................................");
    }

    *//*        if (p.IsContentReady())
            {
                p.ShowContent();
            }
            else if(First)
            {
                text.text = "TapJoy Content is Not Ready To Display ..............";
                Debug.Log("TapJoy Content is Not Ready To Display ..............");
               // p = TJPlacement.CreatePlacement("TapJoyAd");
                p.RequestContent();
                First = false;
                return;
            }else if (Second)
            {
                p = TJPlacement.CreatePlacement("TapJoyAd");
                Second = false;
                First = true;
                return;
            }
    *//*


    public void OnConnectSuccess()
    {
        Debug.Log("TapJoy Connect Successfully ./.....................................................");
        text.text = "TapJoy Connect Successfully " + Tapjoy.IsConnected + "./.....................................................";
        // p = TJPlacement.CreatePlacement("InsufficientCurrency");

    }
    public void OnConnectFailure()
    {
        Debug.Log("TapJoy Failed To Connect ..............................................");
        text.text = "TapJoy Failed To Connect ..............................................";
        //Tapjoy.Connect(AppSdkId, connectFlags);
    }

    public void HandleVideoStart()
    {

    }
    public void HandleVideoComplete()
    {
        DisplayResult.text = "TapJoy Reward is Work Win 10 Coins";
    }

}
*/