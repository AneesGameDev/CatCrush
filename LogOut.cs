using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Networking;

public class LogOut : MonoBehaviour
{
    public gameData GameDataa;
    public GameObject inputreference;
    public Button PutButton;
    public TextMeshProUGUI puttedreference;
    string reference;
   // public Button shareButton;
    private bool isFocus = false;
    private bool isProcessing = false;
    public string Userreference;





    private void Start()
    {




        if (PlayerPrefs.HasKey("puttedreference") && PlayerPrefs.GetString("puttedreference") != "0")
        {
            reference = PlayerPrefs.GetString("fbserverreference");
            inputreference.SetActive(false);
            PutButton.GetComponentInChildren<Text>().text = "putted";
            puttedreference.text = PlayerPrefs.GetString("puttedreference");
            PutButton.GetComponentInChildren<Button>().interactable = false;

        }
        else
        {
            inputreference.SetActive(true);
        }
        //shareButton.onClick.AddListener(ShareText);
        Userreference = PlayerPrefs.GetString("fbserverreference");

        //inputreference.SetActive(false);
    }

    public void ShareText()
    {

#if UNITY_ANDROID

        if (!isProcessing)
        {
            if (PlayerPrefs.HasKey("fbserverreference"))
            {
                StartCoroutine(ShareTextInAnroid(Userreference));
            }
        }
#else
		Debug.Log("No sharing set up for this platform.");

#endif

    }
    public void PutReference()
    {
        if (PlayerPrefs.HasKey("puttedreference") && PlayerPrefs.GetString("puttedreference") == "0")
        {
            Debug.Log("PUT TRefernce Clicked");
            if (inputreference.GetComponentInChildren<InputField>().text != null)
            {
                string userreference = PlayerPrefs.GetString("fbserverreference");
                string inputreferencecode = inputreference.GetComponentInChildren<InputField>().text;
                if (inputreferencecode != userreference)
                {

                    StartCoroutine(referenceput(inputreferencecode, userreference));
                }
                else
                {
                    Debug.Log("You Enter Your Reference COde");
                }

            }
            // 
        }
    }
    public IEnumerator referenceput(string inputreferencecode, string userreference)
    {
        List<IMultipartFormSection> putform = new List<IMultipartFormSection>();
        putform.Add(new MultipartFormDataSection("referencebind", inputreferencecode));
        putform.Add(new MultipartFormDataSection("userreference", userreference));
        Debug.Log("Reference Bind is Not Same" + inputreferencecode + "==" + userreference + inputreferencecode == userreference);
        UnityWebRequest sendreference = UnityWebRequest.Post(CheckAdsRemoved.urlData.ServerLink+"referencebind.php", putform);
        yield return sendreference.SendWebRequest();
        string response = sendreference.downloadHandler.text;
        Debug.Log("Putting Response" + response);
        if (response == "1")
        {
            PlayerPrefs.SetString("puttedreference", inputreferencecode);
            inputreference.SetActive(false);
            puttedreference.text = PlayerPrefs.GetString("puttedreference");
            PutButton.GetComponentInChildren<Text>().text = "putted";
            PutButton.GetComponentInChildren<Button>().interactable = false;
        }
        else
        {
            Debug.Log("Putted Reference is False");
        }


    }
    /*    public IEnumerator setstatuslogout()
        {
            List<IMultipartFormSection> statusform = new List<IMultipartFormSection>();
            statusform.Add(new MultipartFormDataSection("status", "0"));
            statusform.Add(new MultipartFormDataSection("referencecode", PlayerPrefs.GetString("fbserverreference")));
            UnityWebRequest statusGet = UnityWebRequest.Post("http://localhost/CMLogin/status.php", statusform);
           yield return statusGet.SendWebRequest();
            //new WaitUntil(statusGet.isDone);
            if (statusGet.isNetworkError || statusGet.isHttpError)
            {
                Debug.Log("" + statusGet.error);
            }
            else
            {
                string statusresponse = statusGet.downloadHandler.text;
                if(statusresponse == "1")
                {
                    PlayerPrefs.DeleteAll();
                    Debug.Log("Delete All Keys");
                }


            }

        }*/

    public void ShareButton()
    {








    }
    void OnApplicationFocus(bool focus)
    {

        isFocus = focus;
    }
    IEnumerator ShareTextInAnroid(string Userreference)
    {
        var Text = Userreference;
        var shareSubject = "Cat Meat Earning Game";
        var shareMessage = "Hi Friend, Play This Game It is My Promise, \n" +
                           "You Can Earn By Playing this," +
                           "Please Put My Reference Link in Cat Meat Game \n\n" +"<u><b>{( "+ Userreference +" )}</b></u>" + "\n\n" +
                           "https://play.google.com/store/apps/details?id=com.oakmicrosoft.catmeat";
        isProcessing = true;

        if (!Application.isEditor)
        {
            //Create intent for action send
            AndroidJavaClass intentClass =
                new AndroidJavaClass("android.content.Intent");
            AndroidJavaObject intentObject =
                new AndroidJavaObject("android.content.Intent");
            intentObject.Call<AndroidJavaObject>
                ("setAction", intentClass.GetStatic<string>("ACTION_SEND"));

            //put text and subject extra

            intentObject.Call<AndroidJavaObject>("setType", "text/plain");
            intentObject.Call<AndroidJavaObject>
                ("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), shareSubject);
            intentObject.Call<AndroidJavaObject>
                ("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), shareMessage);

            //call createChooser method of activity class
            AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject currentActivity =
                unity.GetStatic<AndroidJavaObject>("currentActivity");
            AndroidJavaObject chooser =
                intentClass.CallStatic<AndroidJavaObject>
                ("createChooser", intentObject, "Share your high score");
            currentActivity.Call("startActivity", chooser);
        }

        yield return new WaitUntil(() => isFocus);
        isProcessing = false;
    }








    public void LogOutClick()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("Delete All Keys");
        Application.Quit();
        //StartCoroutine(setstatuslogout());
        
        /*      GameDataa = FindObjectOfType<gameData>();

                GameDataa.saveData.boardwidth = 8;
                GameDataa.saveData.boardheight = 6;
                GameDataa.saveData.Level = 1;
                GameDataa.saveData.coinss = 0;
                GameDataa.saveData.catsOnBoard = new string[((GameDataa.saveData.boardwidth / 2) * (GameDataa.saveData.boardheight / 2))];
                int k = 0;
                for (int i = 0; i < GameDataa.saveData.boardwidth; i += 2)
                {
                    for (int j = 0; j < GameDataa.saveData.boardheight; j += 2)
                    {
                        GameDataa.saveData.catsOnBoard[k] = "0";
                        k += 1;
                        Debug.Log("Data Set In Array");

                        //  CurrentCharacter = CharacterType.Archer,
                        // UnlockedCharacters = new List<CharacterType>() { CharacterType.Archer }
                    }

                    // Save();
                }*/

    }
    /*        PlayerPrefs.SetInt("fbloginistrueorfalse", 1);
            PlayerPrefs.SetString("fbservername", FbData.Name);
            PlayerPrefs.SetString("fbserverimage", FbData.imgaestring);
            PlayerPrefs.SetString("fbserverreference", FbData.referencecode);*/
}

