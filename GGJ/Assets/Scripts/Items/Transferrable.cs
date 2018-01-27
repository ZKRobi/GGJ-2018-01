using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITransferrable
{
    TransferData GetTransferData();
    void Initialize(TransferData data);
}
