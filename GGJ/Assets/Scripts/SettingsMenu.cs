/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;
using UnityEngine.Audio;


public class SettingsMenu : MonoBehaviour {

	#region Variables

	public AudioMixer audioMixer;

	#endregion

	public void SetMusicVolume(float volume)
	{
		Debug.Log(volume);
		audioMixer.SetFloat("musicVolume", volume);
	}

	public void SetSFXVolume(float volume)
	{

	}
}
