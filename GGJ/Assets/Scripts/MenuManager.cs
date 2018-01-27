/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
	
	public void PlayGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
	}

	public void QuitGame()
	{
		//Debug.Log("Quit");
		Application.Quit();
	}
}
