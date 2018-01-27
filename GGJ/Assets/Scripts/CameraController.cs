/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;


public class CameraController : MonoBehaviour {

	#region Variables
	public Transform player;

	Vector3 target;
	Vector3 mousePos;
	Vector3 refVel;
	Vector3 shakeOffset;

	//Camera distance from the edge of the Screen
	float cameraDistance = 9.5f;

	float smoothTime = 0.2f;
	float zStart;

	//shake
	float shakeMag;
	float shakeTimeEnd;

	Vector3 shakeVector;

	bool shaking;
	#endregion

	#region Unity Methods
	void Start() {
		target = player.position;
		zStart = transform.position.z;
	}

	void FixedUpdate() {
		mousePos = CaptureMousePos();
		shakeOffset = UpdateShake();
		target = UpdateTargetPos();
		UpdateCameraPosition();
	}
	#endregion

	Vector3 CaptureMousePos()
	{
		Vector2 ret = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		ret *= 2;
		ret -= Vector2.one;
		float max = 0.4f;
		if (Mathf.Abs(ret.x) > max || Mathf.Abs(ret.y) > max)
		{
			ret = ret.normalized;
		}
		return ret;
	}

	Vector3 UpdateTargetPos()
	{
		Vector3 mouseOffset = mousePos * cameraDistance;
		Vector3 ret = player.position + mouseOffset;
		ret += shakeOffset;
		ret.z = zStart;
		return ret;
	}

	void UpdateCameraPosition()
	{
		Vector3 tempPos;
		tempPos = Vector3.SmoothDamp(transform.position, target, ref refVel, smoothTime);
		transform.position = tempPos;
	}

	public void Shake(Vector3 direction, float magnitude, float length)
	{
		shaking = true;
		shakeVector = direction;
		shakeMag = magnitude;
		shakeTimeEnd = Time.time + length;
	}

	Vector3 UpdateShake()
	{
		if (!shaking || Time.time > shakeTimeEnd)
		{
			shaking = false;
			return Vector3.zero;
		}
		Vector3 tempOffset = shakeVector;
		tempOffset *= shakeMag;
		return tempOffset;
	}
}
