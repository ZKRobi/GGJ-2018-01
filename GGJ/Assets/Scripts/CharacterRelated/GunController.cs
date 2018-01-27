/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;


public class GunController : MonoBehaviour {

	#region Variables
	public bool isFiring;
	public Transform parentObject;
	public BulletController bullet;
	public float bulletSpeed;
	public float fireRate; //time between shots
	private float shotCounter;
	public Transform firePoint;
	private CameraController cam;
	#endregion

	#region Unity Methods
	void Start () {
		cam = FindObjectOfType<CameraController>();
	}
	
	void Update () {
		if (isFiring)
		{
			shotCounter -= Time.deltaTime;
			if (shotCounter <= 0)
			{
				shotCounter = fireRate;
				BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation, parentObject) as BulletController;
				newBullet.bulletSpeed = bulletSpeed;
				cam.Shake((transform.position - firePoint.position).normalized, 1.5f, 0.05f);	
			}
		}
		else
		{
			shotCounter = 0;
		}
	}
	#endregion
	
}
