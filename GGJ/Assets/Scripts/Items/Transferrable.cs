using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITransferrable
{
    TransferData GetTransferData(int slot);
    float GetTransferCost();
    void Initialize(TransferData data);
}
