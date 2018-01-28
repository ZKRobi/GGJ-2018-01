using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacting : MonoBehaviour
{
    public float interactionDistance = 40;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo;
        var canInteract = Physics.Raycast(this.transform.position, this.transform.forward, out hitInfo, interactionDistance, 1 << 10);

        if (canInteract)
        {
            var other = hitInfo.transform.gameObject.GetComponent<Interactible>();

            other.doHighlight = true;

            if (Input.GetKey(KeyCode.Q))//TODO: configurabe
            {
                other.Interact(this.gameObject, 0);
            }
            else if (Input.GetKey(KeyCode.E))//TODO: configurable
            {
                other.Interact(this.gameObject, 1);
            }
        }
    }
}
