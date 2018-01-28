using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour {
    #region Variables
    public float bulletLifetime;
    public float bulletSpeed;
    #endregion

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
        bulletLifetime -= Time.deltaTime;
        if (bulletLifetime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
