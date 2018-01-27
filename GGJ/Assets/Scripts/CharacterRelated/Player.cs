/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;


public class Player : MonoBehaviour {

	#region Variables
	public float moveSpeed;
	private Rigidbody myRigidbody;
	private Vector3 moveInput;
	private Vector3 moveVelocity;
	private Camera mainCamera;
	public GunController theGun;

	public bool useController;
	#endregion

	#region Unity Methods
	void Start () {
		myRigidbody = GetComponent<Rigidbody>();
		mainCamera = FindObjectOfType<Camera>();
	}
	
	void Update () {
		moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
		moveVelocity = moveInput * moveSpeed;

		//Rotate with Mouse
		if (!useController)
		{
			Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
			Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
			float rayLength;

			if (groundPlane.Raycast(cameraRay, out rayLength))
			{
				Vector3 pointToLook = cameraRay.GetPoint(rayLength);
				Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);

				transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
			}
			if (Input.GetMouseButtonDown(0))
			{
				theGun.isFiring = true;
			}
			if (Input.GetMouseButtonUp(0))
			{
				theGun.isFiring = false;
			}
		}

		//Rotate with Controller
		if (useController)
		{
			Vector3 playerDirection = Vector3.right * Input.GetAxisRaw("RHorizontal") + Vector3.forward * -Input.GetAxisRaw("RVertical");
			if (playerDirection.sqrMagnitude > 0.0f)
			{
				transform.rotation = Quaternion.LookRotation(playerDirection, Vector3.up);
			}

			if (Input.GetKeyDown(KeyCode.JoystickButton5))
			{
				theGun.isFiring = true;
			}

			if (Input.GetKeyUp(KeyCode.JoystickButton5))
			{
				theGun.isFiring = false;
			}
		}
	}

	void FixedUpdate()
	{
		myRigidbody.velocity = moveVelocity;
	}
	#endregion
	
}
