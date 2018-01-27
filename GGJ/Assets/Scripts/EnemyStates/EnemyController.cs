/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;


public class EnemyController : MonoBehaviour {

	#region Variables

	private Rigidbody myRigidbody;
	public float moveSpeed;
	public PlayerController thePlayer;
	#endregion

	#region Unity Methods
	void Start () {
		myRigidbody = GetComponent<Rigidbody>();
		thePlayer = FindObjectOfType<PlayerController>();
	}
	void FixedUpdate()
	{
		myRigidbody.velocity = (transform.forward * moveSpeed);	
	}
	void Update () {
		transform.LookAt(thePlayer.transform.position);
	}
	#endregion
	
}
