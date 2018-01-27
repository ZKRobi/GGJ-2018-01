/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;
using System;
using System.Collections.Generic;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{

	#region Variables
	public float rotationSpeed = 450;
	public float walkSpeed = 5;
	public float runSpeed = 8;
	public Gun gun;

	private CharacterController controller;

	private Quaternion targetRotation;

	private Camera cam;

	#endregion

	#region Unity Methods
	void Start()
	{
		controller = GetComponent<CharacterController>();
		cam = Camera.main;
	}

	void Update()
	{
		//ControlWASD();
		ControlMouse();

		if (Input.GetMouseButtonDown(0))
		{
			gun.Shoot();
		}
		else if (Input.GetButton("Fire1"))
		{
			gun.ShootContinoues();
		}
	}
	#endregion
	void ControlMouse()
	{
		Vector3 mousePos = Input.mousePosition;
		mousePos = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.transform.position.y - transform.position.y));
		targetRotation = Quaternion.LookRotation(mousePos - new Vector3(transform.position.x, 0, transform.position.z));
		transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y, targetRotation.eulerAngles.y, rotationSpeed * Time.deltaTime);


		Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		Vector3 motion = input;
		motion *= (Mathf.Abs(input.x) == 1 && Mathf.Abs(input.z) == 1) ? .7f : 1;
		motion *= (Input.GetButton("Run")) ? runSpeed : walkSpeed;
		motion += Vector3.up * -8;

		controller.Move(motion * Time.deltaTime);

	}
	void ControlWASD()
	{
		Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		if (input != Vector3.zero)
		{
			targetRotation = Quaternion.LookRotation(input);
			transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y, targetRotation.eulerAngles.y, rotationSpeed * Time.deltaTime);
		}
		Vector3 motion = input;
		motion *= (Mathf.Abs(input.x) == 1 && Mathf.Abs(input.z) == 1) ? .7f : 1;
		motion *= (Input.GetButton("Run")) ? runSpeed : walkSpeed;
		motion += Vector3.up * -8;

		controller.Move(motion * Time.deltaTime);
	}
}
