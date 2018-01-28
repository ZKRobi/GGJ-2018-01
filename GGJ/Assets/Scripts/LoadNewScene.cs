using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    public GameObject buttonHolder;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TransferItemsAndLoadNewScene(string nextScene)
    {
        foreach (var item in buttonHolder.GetComponentsInChildren<AddToTransfer>())
        {
            if (item.transferring)
            {
                item.Transfer();
            }
        }

        SceneManager.LoadScene(nextScene);
    }
}
