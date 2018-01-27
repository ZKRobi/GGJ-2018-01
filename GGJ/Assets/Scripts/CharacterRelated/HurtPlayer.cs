/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;


public class HurtPlayer : MonoBehaviour {

	#region Variables

	public int damageToGive;
	#endregion

	#region Unity Methods
	void Start () {
		
	}
	
	void Update () {
		
	}
	#endregion

	public void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			other.gameObject.GetComponent<PlayerStatManager>().HurtPlayer(damageToGive);
		}	
	}
}
