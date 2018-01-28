using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactible : MonoBehaviour
{

    protected bool interactionRequested;
    protected GameObject interactionSource;
    protected bool interacting;

    public abstract void Interact(GameObject source, int slot);

    public virtual void StopInteracting() { }
}
