using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    public GameObject platform;
    public PlayerController player;

    private void OnTriggerEnter()
    {
        player.transform.parent = platform.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        player.transform.parent = null;
    }
}
