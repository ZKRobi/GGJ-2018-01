/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;


public class CameraFollow : MonoBehaviour {

	#region Variables

	public Transform target;

	public float smoothSpeed = 10f;
	public Vector3 offset;

	#endregion

	#region Unity Methods	
	void FixedUpdate () {

		Vector3 desiredPosition = target.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
		transform.position = smoothedPosition;

		transform.LookAt(target);
	}
	#endregion
	
}
