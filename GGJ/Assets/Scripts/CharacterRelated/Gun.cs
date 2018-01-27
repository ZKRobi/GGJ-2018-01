/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Gun : MonoBehaviour {

	#region Variables
	public Transform bulletSpawn;
	public enum GunType{Semi, Burst, Auto};
	public GunType gunType;
    public float roundsPerMin;
    public Transform shellEjectionPoint;
    public Rigidbody shell;
    public Transform shellParentObject;
    private float secondsBetweenShots;
    private float nextPossibleShootTime;
    private LineRenderer tracer;
	#endregion

	#region Unity Methods
	void Start () {
        secondsBetweenShots = 60 / roundsPerMin;
        if (GetComponent < LineRenderer>())
        {
            tracer = GetComponent<LineRenderer>();
        }
	}
	
	void Update () {
		
	}
	#endregion
	
	public void Shoot()
	{
        if (CanShoot())
        {

            Ray ray = new Ray(bulletSpawn.position, bulletSpawn.forward);
            RaycastHit hit;

            float shotDistance = 20f;

            if (Physics.Raycast(ray, out hit, shotDistance))
            {
                shotDistance = hit.distance;
            }
            Debug.Log("Fire!!!");
            Debug.DrawRay(ray.origin, ray.direction * shotDistance, Color.red, 1);

            nextPossibleShootTime = Time.time + secondsBetweenShots;

            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

            if (tracer)
            {
                StartCoroutine("RenderTracer", ray.direction * shotDistance);
            }

            Rigidbody newShell = Instantiate(shell, shellEjectionPoint.position, Quaternion.identity, shellParentObject) as Rigidbody;
            newShell.AddForce(shellEjectionPoint.forward * Random.Range(150f, 200f) + bulletSpawn.forward * Random.Range(-10f,10f));
        }
    }

	public void ShootContinoues()
	{
		if (gunType == GunType.Auto)
		{
			Shoot();
		}
		
	}
    private bool CanShoot()
    {
        bool canShoot = true;

        if (Time.time == nextPossibleShootTime )
        {
            canShoot = false;
        }

        return canShoot;
    }

    IEnumerator RenderTracer(Vector3 hitpoint)
    {
        tracer.enabled = true;
        tracer.SetPosition(0, bulletSpawn.position);
        tracer.SetPosition(1, bulletSpawn.position + hitpoint);
        yield return null;
        tracer.enabled = false;
    }
}
