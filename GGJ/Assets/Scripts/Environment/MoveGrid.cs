using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGrid : MonoBehaviour {

    public List<GameObject> transportPoints;
    public float gridSpeed;
    private Transform nextGridSpaceInList;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        MovePosition(nextGridSpaceInList);
	}

    private void MovePosition(Transform nextGridSpaceInList)
    {
        

    }
}
