using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransferrableGun : MonoBehaviour, ITransferrable
{
    public float GetTransferCost()
    {
        return 10f;
    }

    public TransferData GetTransferData(int slot)
    {
        return new TransferData()
        {
            name = "Weapon",
            targetSlot = slot
        };
    }

    public void Initialize(TransferData data)
    {

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
