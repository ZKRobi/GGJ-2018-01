using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemIdelFloatingAnimation : MonoBehaviour {

    public Transform _item;

    private void FixedUpdate()
    {
        _item.transform.Rotate(0, 10 * (float) Math.Sin(Time.time), 0);

        //_item.transform.Translate(0, 0.220f * (float) Math.Abs(Math.Sin(Time.time)), 0);
    }

}
