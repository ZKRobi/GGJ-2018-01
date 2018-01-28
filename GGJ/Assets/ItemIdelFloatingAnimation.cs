using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemIdelFloatingAnimation : MonoBehaviour {

    public Transform _item;

    private void FixedUpdate()
    {
        _item.transform.Rotate(0, 10 * (float) Math.Sin(Time.time), 0);
<<<<<<< HEAD
=======
        //_item.transform.Translate(0, 0.220f * (float) Math.Abs(Math.Sin(Time.time)), 0);
>>>>>>> fb6ee26ae4b862c4e1d9e3cb03b750cc031f896a
    }

}
