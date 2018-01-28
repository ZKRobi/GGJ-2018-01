using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloortrapTrigger : MonoBehaviour
{

    public TriggeredFloortrap floortrap;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            floortrap.BeginTriggering();
        }
    }
}
