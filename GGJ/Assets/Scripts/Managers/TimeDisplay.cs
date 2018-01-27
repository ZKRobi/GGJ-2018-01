using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

    private bool _player_moved;
    private bool _ever_moved;
    public Text _time_dispaly;


    // Use this for initialization
    void Start() {
        GameGlobals._remainingTime = 600.0f;
        _player_moved = false;
        _ever_moved = false;
        _time_dispaly.text = "Move to START";
    }

    // Update is called once per frame
    void Update() {

        if(!_ever_moved)
        {
            CheckPlayerMoved();
        }

        if (_player_moved)
        {
            GameGlobals.ReduceTime(Time.deltaTime);
            _time_dispaly.text = ((int)GameGlobals._remainingTime) + " seconds remaining";
        }
        
	}

    private void CheckPlayerMoved()
    {

        if( Input.GetKeyDown("w") ||
            Input.GetKeyDown("a") ||
            Input.GetKeyDown("s") ||
            Input.GetKeyDown("d"))
        {
            _player_moved = true;
            _ever_moved = true;
        }
    }
}
