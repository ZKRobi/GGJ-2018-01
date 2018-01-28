using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transmitter : Interactible
{
    public GameObject UI;
    Color baseColor;
    Color highlightColor;
    MeshRenderer _meshrenderer;

    public override void Interact(GameObject source, int slot)
    {
        if (!interactionRequested && !interacting)
        {
            interactionRequested = true;
            interactionSource = source;

            Debug.Log("Interaction starting");

            GameGlobals.timeRunning = false;
            UI.SetActive(true);
        }
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
