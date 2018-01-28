using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{

    private bool _ever_moved;
    public Text _time_dispaly;


    // Use this for initialization
    void Start()
    {
        _ever_moved = false;
        _time_dispaly.text = "Move to START";
    }

    // Update is called once per frame
    void Update()
    {
        if (!_ever_moved)
        {
            CheckPlayerMoved();
        }
        else if (GameGlobals.timeRunning)
        {
            GameGlobals.ReduceTime(Time.deltaTime);
            _time_dispaly.text = ((int)GameGlobals.remainingTime) + " seconds remaining";
        }
    }

    private void CheckPlayerMoved()
    {

        if (Input.GetKeyDown("w") ||
            Input.GetKeyDown("a") ||
            Input.GetKeyDown("s") ||
            Input.GetKeyDown("d"))
        {
            _ever_moved = true;
        }
    }
}
