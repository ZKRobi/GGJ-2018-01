/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;


public class GameCamera : MonoBehaviour {

	#region Variables
	private Transform target;
	private Vector3 cameraTarget;
	#endregion

	#region Unity Methods
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player").transform;
		
	}
	
	void FixedUpdate () {
		cameraTarget = new Vector3(target.position.x, transform.position.y, target.position.z);
		transform.position = Vector3.Lerp(transform.position, cameraTarget, Time.deltaTime * 20);
	}
	#endregion
	
}
