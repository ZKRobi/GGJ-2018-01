using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacting : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo;
        var canInteract = Physics.BoxCast(this.transform.position, new Vector3(10, 10, 10), this.transform.forward, out hitInfo, Quaternion.identity, 40, 1 << 10);

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
