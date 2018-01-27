/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;


public class EnemyHealthManager : MonoBehaviour {

	#region Variables
	public int health;
	private int currentHealth;
	#endregion

	#region Unity Methods
	void Start () {
		currentHealth = health;
	}
	
	void Update () {
		if (currentHealth <= 0)
		{
			Destroy(gameObject);
		}
	}
	#endregion
	public void TakingDamage(int damage)
	{
		currentHealth -= damage;
	}
}
