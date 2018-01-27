using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transferrable : MonoBehaviour
{
    public GameObject prefab;

    public TransferData GetTransferData()
    {
        return new TransferData() { name = "TransferredObject" };
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


}
