using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredFloortrap : MonoBehaviour
{
    public bool isTriggering;
    public bool isTriggered;

    public float timeToTrigger = 1f;
    public float resetDelay = 1f;

    private float triggerTime;
    private float resetTime;

    private Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isTriggering && !isTriggered && Time.time > triggerTime)
        {
            Trigger();
        }

        if (isTriggered && Time.time > resetTime)
        {
            Reset();
        }
    }

    public void BeginTriggering()
    {
        if (!isTriggering)
        {
            isTriggering = true;
            triggerTime = Time.time + timeToTrigger;
            resetTime = triggerTime + resetDelay;
        }
    }

    public void Trigger()
    {
        isTriggered = true;
        animator.SetBool("IsActive", true);
    }
    public void Reset()
    {
        isTriggered = false;
        isTriggering = false;
        animator.SetBool("IsActive", false);
    }
}
