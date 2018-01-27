/*
* Copyright (c) Nephtar
* Contact: info@petermartai.com
* http://petermartai.com
*/

using UnityEngine;


public class BulletController : MonoBehaviour {

	#region Variables
	public float bulletLifetime;
	public int bulletDamage;
	public float bulletSpeed;
	#endregion

	#region Unity Methods
	void Start () {
		
	}
	
	void Update () {
		transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
		bulletLifetime -= Time.deltaTime;
		if (bulletLifetime <= 0)
		{
			Destroy(gameObject);
		}
	}
	#endregion

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("Enemy"))
		{
			other.gameObject.GetComponent<EnemyHealthManager>().TakingDamage(bulletDamage);
			Destroy(gameObject);
		}
	}

}
