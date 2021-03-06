﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameGlobals
{
    public static float remainingTime = 600f;
    public static bool timeRunning = true;
    private static List<TransferData> _transferredItemList = new List<TransferData>();


    public static void ReduceTime(float time)
    {
        remainingTime -= time;
    }

    public static void AddItemToTransfer(ITransferrable transferredItem, int slot)
    {
        _transferredItemList.Add(transferredItem.GetTransferData(slot));
        ReduceTime(transferredItem.GetTransferCost()); //TODO: item time cost
    }

    public static List<TransferData> PopItemTransfer()
    {
        var list = _transferredItemList;
        _transferredItemList = new List<TransferData>();
        return list;
    }


}
