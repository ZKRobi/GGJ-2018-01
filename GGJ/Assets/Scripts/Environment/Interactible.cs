using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactible : MonoBehaviour
{
    public bool doHighlight;
    protected bool highlighted;

    protected bool interactionRequested;
    protected GameObject interactionSource;
    protected bool interacting;

    public abstract void Interact(GameObject source, int slot);

    public virtual void StopInteracting() { }

    protected void Highlight()
    {
        Debug.Log(doHighlight);
        if (doHighlight)
        {
            highlighted = true;
        }
        else
        {
            highlighted = false;
        }

        doHighlight = false;
    }
}
