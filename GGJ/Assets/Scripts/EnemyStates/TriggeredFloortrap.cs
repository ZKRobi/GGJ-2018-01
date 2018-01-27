using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredFloortrap : MonoBehaviour
{

    public bool isTriggering;
    public bool isTriggered;

    public float timeToTrigger = 1f;
    public float resetDelay = 1f;

    private Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("IsActive", isTriggered);
        animator.SetBool("IsPreparing", isTriggering);
    }
}
