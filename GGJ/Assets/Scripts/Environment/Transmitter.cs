using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transmitter : Interactible
{
    public GameObject UI;

    public override void Interact(GameObject source)
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

    }

    // Update is called once per frame
    void Update()
    {

    }
}
