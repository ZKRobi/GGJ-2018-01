﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTransferrable : MonoBehaviour, ITransferrable
{
    public float GetTransferCost()
    {
        return 10f;
    }

    public TransferData GetTransferData(int slot)
    {
        return new TransferData()
        {
            name = "TransferrableObject",
            data = new Dictionary<string, object> { { "posX", 1f } },
            targetSlot = slot
        };
    }

    public void Initialize(TransferData data)
    {
        transform.position = new Vector3((float)data.data["posX"], transform.position.y, transform.position.z);
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
