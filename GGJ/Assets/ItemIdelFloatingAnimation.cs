using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemIdelFloatingAnimation : MonoBehaviour {

    public Transform _item;

    private void FixedUpdate()
    {
        _item.transform.Rotate(0, 10 * (float) Math.Sin(Time.time), 0);
    }

}
