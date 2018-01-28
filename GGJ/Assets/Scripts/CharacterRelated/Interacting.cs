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

        Debug.DrawRay(this.transform.position, this.transform.forward * interactionDistance, Color.red);

        if (canInteract)
        {
            var other = hitInfo.transform.gameObject.GetComponent<Interactible>();

            if (Input.GetKey(KeyCode.Alpha0))//TODO: input
            {
                other.Interact(this.gameObject);
            }
        }
    }
}
