using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FirstScreen : MonoBehaviour
{
    public GameObject LoadingPanel;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameScreenClick()
    {
        // string temFBID = PlayerPrefs.GetString("FBID");
        //GetRequest(temFBID);
        //this.gameObject.GetComponent<AudioSource>().Play();
      AsyncOperation loadingOperation = SceneManager.LoadSceneAsync(2);

        LoadingPanel.SetActive(true);
        this.gameObject.GetComponent<Canvas>().enabled = false;


        //SceneManager.LoadScene(2);
    }




}

