/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;
using System.Collections;


public class Pickups : MonoBehaviour
{

	#region Variables
	public GameObject pickupEffect;
	public Transform parentObject;
	public int duration = 4;
	public int multiplier = 2;

	#endregion

	#region Unity Methods
	void Start()
	{

	}

	void Update()
	{

	}
	#endregion

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			StartCoroutine(Pickup(other));
		}
	}
	IEnumerator Pickup(Collider player)
	{
		//Debug.Log("Power up picked up!");
		//Particle
		GameObject explosion = Instantiate(pickupEffect, transform.position, transform.rotation, parentObject) as GameObject;
		ParticleSystem parts = explosion.GetComponent<ParticleSystem>();
		Destroy(explosion, parts.main.duration);
		
		//Effect
		PlayerStatManager playerstat = player.GetComponent<PlayerStatManager>();
		playerstat.currentHealth *= multiplier;

		GetComponent<MeshRenderer>().enabled = false;
		GetComponent<Collider>().enabled = false;
		
		yield return new WaitForSeconds(duration);
		playerstat.currentHealth /= multiplier;

		player.transform.localScale *= multiplier;
		
		//Destroy pickup
		Destroy(gameObject);
	}
}
