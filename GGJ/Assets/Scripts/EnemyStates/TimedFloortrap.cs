using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedFloortrap : MonoBehaviour
{
    [HideInInspector]
    public bool isActive = false;

    public float onTime = 1;
    public float offTime = 2;

    private float nextToggle = 0;
    private Animator animator;

    // Use this for initialization
    void Start()
    {
        nextToggle = offTime;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextToggle)
        {
            nextToggle += isActive ? offTime : onTime;
            isActive = !isActive;
            
            animator.SetBool("IsActive", isActive);
        }
    }
}
