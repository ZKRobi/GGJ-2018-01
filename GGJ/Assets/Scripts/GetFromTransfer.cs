using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFromTransfer : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform[] slots;

    // Use this for initialization
    void Start()
    {
        var items = GameGlobals.PopItemTransfer();
        foreach (var item in items)
        {
            Debug.Log("instantiating");
            GameObject newObj = null;
            foreach (var prefab in prefabs)
            {
                if (prefab.name == item.name)
                {
                    newObj = GameObject.Instantiate(prefab);
                    newObj.GetComponent<ITransferrable>().Initialize(item);
                }
            }
            if (newObj != null)
            {
                newObj.transform.SetParent(slots[item.targetSlot]);
                newObj.transform.localPosition = Vector3.zero;
                newObj.transform.localRotation = Quaternion.identity;
                newObj.transform.localScale = Vector3.one;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
