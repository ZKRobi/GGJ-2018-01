/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;


public class EvadeJump : MonoBehaviour {

	#region Variables
	public float distance = 5.0f;


	#endregion

	#region Unity Methods
	void Start() {

	}

	void FixedUpdate() {
		if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.LeftShift))
		{
			Blink();
		}
	}
	#endregion

	void Blink()
	{
		RaycastHit hit;
		Vector3 destination = transform.position + transform.forward * distance;

		//check intersecting obstacle
		if (Physics.Linecast(transform.position, destination, out hit))
		{
			destination = transform.position + transform.forward * (hit.distance - 1f);
		}
		//no obstacle found
		if (Physics.Raycast(destination, -Vector3.up, out hit))
		{
			destination = hit.point;
			destination.y = 0.5f; //avoid blink inside the ground 
			transform.position = destination;
		}
	}
}
