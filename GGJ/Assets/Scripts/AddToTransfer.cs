using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AddToTransfer : MonoBehaviour
{
    public bool transferring = false;
    public GameObject item;

    private Text _text;

    // Use this for initialization
    void Start()
    {
        _text = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleTransfer()
    {
        transferring = !transferring;
        _text.text = transferring ? "item" : "(item)";
    }

    public void Transfer()
    {
        GameGlobals.AddItemToTransfer(item.GetComponent<ITransferrable>());
    }
}
