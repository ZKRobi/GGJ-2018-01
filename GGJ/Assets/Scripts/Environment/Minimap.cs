/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;


public class Minimap : MonoBehaviour {

	#region Variables

	public Transform player;
	#endregion

	#region Unity Methods
	void Start () {
		
	}
	
	void LateUpdate () {
		Vector3 newPosition = player.position;
		newPosition.y = transform.position.y;
		transform.position = newPosition;

		//transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
	}
	#endregion
	
}
