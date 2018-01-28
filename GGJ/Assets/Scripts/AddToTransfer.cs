using UnityEngine;
using UnityEngine.UI;

public class AddToTransfer : MonoBehaviour
{
    public bool transferring = false;
    public int slot;
    public GameObject itemSource;

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
        RefreshText();
    }

    public void RefreshText()
    {
        var item = itemSource.GetComponentInChildren<ITransferrable>();
        if (item != null)
        {
            var name = ((MonoBehaviour)item).gameObject.name;
            _text.text = transferring ? name : "(" + name + ")";
        }
    }

    public void Transfer()
    {
        var item = itemSource.GetComponentInChildren<ITransferrable>();
        if (item != null)
        {
            GameGlobals.AddItemToTransfer(item, slot);
        }
    }
}
