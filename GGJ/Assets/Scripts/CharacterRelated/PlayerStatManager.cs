/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;


public class PlayerStatManager : MonoBehaviour {

	#region Variables
	public int startingHealth;
	public int currentHealth;

	//taking damage flash
	public float flashLength;
	private float flashCounter;
	private Renderer rend;
	private Color storedColor;
	#endregion

	#region Getters & Setters

	#endregion

	#region Unity Methods
	void Start() {
		currentHealth = startingHealth;
		rend = GetComponent<Renderer>();
		storedColor = rend.material.GetColor("_Color");
	}

	void Update() {
		if (currentHealth <= 0)
		{
			gameObject.SetActive(false);
		}
		if (flashCounter > 0)
		{
			flashCounter -= Time.deltaTime;
			if (flashCounter <= 0)
			{
				rend.material.SetColor("_Color", storedColor);
			}
		}
	}
	#endregion

	public void HurtPlayer(int damageAmount)
	{
		currentHealth -= damageAmount;
		flashCounter = flashLength;
		rend.material.SetColor("_Color", Color.white);

	}

	
}
