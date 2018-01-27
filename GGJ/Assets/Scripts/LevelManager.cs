/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	#region Variables

	public float autoLoadNextLevelAfter;
	
	#endregion

	#region Unity Methods
	void Start () {
		if (autoLoadNextLevelAfter <= 0)
		{
			Debug.Log("Level auto load disabled, use a positive number on seconds");
		}
		else
		{
			Invoke("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}
	#endregion

	public void LoadLevel(string name)
	{
		SceneManager.LoadScene(name);
	}
	public void QuitRequst()
	{
		Application.Quit();
	}
	public void LoadNextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
