using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : Interactible
{
    public Transform[] itemHolders;

    public override void Interact(GameObject source, int slot)
    {
        GetComponent<Collider>().enabled = false;
        gameObject.transform.SetParent(itemHolders[slot]);
        gameObject.transform.localPosition = Vector3.zero;
        gameObject.transform.localRotation = Quaternion.identity;
        // TODO: wireup shots
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
