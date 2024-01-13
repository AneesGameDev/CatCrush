using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class SoundInventory : MonoBehaviour
{
	//public static SoundManager instance;
	public AudioSource[] BgSounds;
	//public AudioSource backgroundmusic;
	public static SoundInventory instance;
	public GameObject soundPanel;
	public BGSound BGSound;
	//public ParticleSystem rippleAffect;
	//public bool FirstTime;

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(this.gameObject);
		}
		else
		{
			Destroy(this.gameObject);
		}
	}


	private void Start()
		{
		BGSound = FindObjectOfType<BGSound>();
		BGSound.SceneLoadComplete = true;
		BGSound.LoadingPanel.SetActive(false);
		//BGSound.cameraa.SetActive(false);
	//	PlayerPrefs.SetInt("FirstTime", 0);

			//BGPlay();
			//rippleAffect.GetComponent<ParticleSystem>().Stop();

		}
		public void BGPlay()
		{
		//BgSounds[0].Play();
		//BgSounds[1].Play();
	}
	public void playBgSound(int sound)
	{
		//Choose a random number
		//int clipToPlay = Random.Range(0, MatchNoise.Length);
		//play that clip
		BGSound.ButtonClick();
		BGSound.BGStop();
		
		for (int i=0; i<BgSounds.Length; i++)
		{

			if (BgSounds[i].isPlaying)
			{
				BgSounds[i].Stop();
			}
		}
		BgSounds[sound].Play();
	}

	public void ONSoundPanel()
	{
		if (soundPanel != null)
		{
			soundPanel.SetActive(true);
		}
		
	}
	public void DisableSoundPanel()
	{
		if (soundPanel != null)
		{
			soundPanel.SetActive(false);
		}
	}
	public void Click()
	{
		BGSound.ButtonClick();
	}

}
