using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : Interactible
{
    public Transform[] itemHolders;
    Color baseColor;
    Color highlightColor;
    MeshRenderer _meshrenderer;

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
        _meshrenderer = this.GetComponentInChildren<MeshRenderer>();
        baseColor = _meshrenderer.material.color;
        highlightColor = new Color(baseColor.r + 0.1f, baseColor.g + 0.1f, baseColor.b + 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        Highlight();
        if (highlighted)
        {
            _meshrenderer.material.color = highlightColor;
        }
        else
        {
            _meshrenderer.material.color = baseColor;
        }
    }
}
