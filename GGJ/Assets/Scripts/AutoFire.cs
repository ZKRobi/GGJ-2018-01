using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFire : MonoBehaviour
{

    private Gun gun;

    // Use this for initialization
    void Start()
    {
        gun = this.GetComponent<Gun>();
    }

    // Update is called once per frame
    void Update()
    {
        gun.Shoot();
    }
}
