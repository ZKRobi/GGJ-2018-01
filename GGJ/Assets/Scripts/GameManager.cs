/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;


public class GameManager : MonoBehaviour {

	#region Variables

	public static GameManager instance;

	#endregion

	#region Unity Methods
	private void Awake()
	{
		if (instance == null)
		{
			DontDestroyOnLoad(gameObject);
			instance = this;
		}
		else if (instance != this)
		{
			Destroy(gameObject);
		}
	}

	void Start () {
		
	}

	void Update () {
		
	}
	#endregion
	
}
