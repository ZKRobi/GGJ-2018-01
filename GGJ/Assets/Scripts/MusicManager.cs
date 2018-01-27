/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;
using UnityEngine.Audio;

public class MusicManager : MonoBehaviour {

	#region Variables

	public AudioClip[] levelMusicChangeArray;
	private AudioSource audioSource;

	#endregion

	#region Unity Methods
	void Awake()
	{
		DontDestroyOnLoad(gameObject);	
	}
	void Start () {
		audioSource = GetComponent<AudioSource>();
		//audioSource.volume = PlayerPrefs.GetMasterVolume();
	}
	
	void Update () {
		
	}
	#endregion

	void OnLevelWasLoaded(int level)
	{
		AudioClip thisLevelMusic = levelMusicChangeArray[level];
		if (thisLevelMusic)
		{
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play();
		}
	}
	public void SetVolume(float volume)
	{
		audioSource.volume = volume;
	}
}
