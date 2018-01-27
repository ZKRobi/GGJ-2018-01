using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddToTransfer : MonoBehaviour
{

    private bool _transferDone = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!_transferDone && Input.GetKey("enter"))
        {
            Debug.Log("transferring");
            _transferDone = true;

            GameGlobals.AddItemToTransfer(GameObject.Find("TransferredObject").GetComponent<Transferrable>());

            SceneManager.LoadScene("Robi_Dev2");
        }
    }
}
