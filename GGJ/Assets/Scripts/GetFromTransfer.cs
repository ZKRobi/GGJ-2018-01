using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFromTransfer : MonoBehaviour
{
    public GameObject[] prefabs;

    // Use this for initialization
    void Start()
    {
        var items = GameGlobals.PopItemTransfer();
        foreach (var item in items)
        {
            Debug.Log("instantiating");
            foreach (var prefab in prefabs)
            {
                if (prefab.name == item.name)
                {
                    var newObj = GameObject.Instantiate(prefab);
                    newObj.GetComponent<ITransferrable>().Initialize(item);
                }
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
