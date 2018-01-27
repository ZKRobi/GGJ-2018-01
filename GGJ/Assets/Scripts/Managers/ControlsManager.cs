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


public class ControlsManager : MonoBehaviour {

	#region Variables

	public static ControlsManager instance;


	private Dictionary<string, KeyCode> keyBindings = new Dictionary<string, KeyCode>();
	public TextMeshProUGUI up, left, down, right, attack1, attack2, roll;
	private GameObject currentKey;
	KeyCode newKey;

	private Color32 normal = new Color(39, 171,249,255);
	private Color32 selected = new Color(239,116,36,255);

	#endregion

	#region Unity Methods
	void Awake()
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
		void Start() {

		keyBindings.Add("Up", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Up", "W")));
		keyBindings.Add("Left", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Left", "A")));
		keyBindings.Add("Down", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Down", "S")));
		keyBindings.Add("Right", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Right", "D")));
		keyBindings.Add("Attack1", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Attack1", "Mouse0")));
		keyBindings.Add("Attack2", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Attack2", "Mouse2")));
		keyBindings.Add("Roll", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Roll", "Space")));

		up.text = keyBindings["Up"].ToString();
		left.text = keyBindings["Left"].ToString();
		down.text = keyBindings["Down"].ToString();
		right.text = keyBindings["Right"].ToString();
		attack1.text = keyBindings["Attack1"].ToString();
		attack2.text = keyBindings["Attack2"].ToString();
		roll.text = keyBindings["Roll"].ToString();
	}

	void Update() {
		
	}

	void OnGUI()
	{
		if (currentKey != null)
		{
			Event e = Event.current;
			if (e.isKey)
			{
				keyBindings[currentKey.name] = e.keyCode;
				currentKey.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = e.keyCode.ToString();
				currentKey.GetComponent<Image>().color = normal;
				currentKey = null;
			}
		}
	}
	#endregion

	public void ChangeKey(GameObject clicked)
	{
		if (currentKey != null)
		{
			currentKey.GetComponent<Image>().color = normal;
		}
		currentKey = clicked;
		currentKey.GetComponent<Image>().color = selected;
	}

	public void SaveKeyBindings()
	{
		foreach (var key in keyBindings)
		{
			PlayerPrefs.SetString(key.Key, key.Value.ToString());
		}
		PlayerPrefs.Save();
	}

	public void SetBackKeyBindingsToDefault()
	{
		

	}
}
