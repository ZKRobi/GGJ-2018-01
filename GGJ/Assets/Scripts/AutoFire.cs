using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFire : MonoBehaviour
{
    public float initialDelay;
    private Gun gun;

    // Use this for initialization
    void Start()
    {
        gun = this.GetComponent<Gun>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > initialDelay)
        {
            gun.Shoot();
        }
    }
}
