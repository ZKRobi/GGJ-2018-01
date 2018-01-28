using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour {

    public Collider _finish_zone;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            TimeDisplay._in_finish_zone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            TimeDisplay._in_finish_zone = false;
        }
    }

}
