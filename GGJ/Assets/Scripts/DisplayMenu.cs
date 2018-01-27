/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class DisplayMenu : MonoBehaviour {

	#region Variables

	Resolution[] resolutions;
	public TMP_Dropdown resolutionDropdown;

	#endregion
	
	#region Unity Methods

	void Start()
	{
		resolutions = Screen.resolutions;
		resolutionDropdown.ClearOptions();

		List<string> options = new List<string>();

		int currentResolutionIndex = 0;
		for (int i = 0; i < resolutions.Length; i++)
		{
			string option = resolutions[i].width + " x " + resolutions[i].height;
			options.Add(option);
			if (resolutions[i].width == Screen.currentResolution.width && 
				resolutions[i].height == Screen.currentResolution.height)
			{
				currentResolutionIndex = i;
			}
		}
		resolutionDropdown.AddOptions(options);
		resolutionDropdown.value = currentResolutionIndex;
		resolutionDropdown.RefreshShownValue();
	}
	#endregion

	public void SetQuality(int _qualityIndex)
	{
		QualitySettings.SetQualityLevel(_qualityIndex);
	}

	public void SetFullscreen(bool isFullscreen)
	{
		Screen.fullScreen = isFullscreen;
	}
	public void SetResolution(int _resolutionIndex)
	{
		Resolution resolution = resolutions[_resolutionIndex];
		Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
	}
}
