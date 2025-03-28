using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Animatietrigger : MonoBehaviour
{
    Animator m_Animator;


    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            m_Animator.SetTrigger("Idle");
            Console.WriteLine("Idle");
        }

        if (Input.GetKey(KeyCode.W))
        {
            m_Animator.SetTrigger("Walk");
            Console.WriteLine("Walk");
        }

        if (Input.GetKey(KeyCode.S))
        {
            m_Animator.SetTrigger("WalkR");
            Console.WriteLine("WalkR");
        }
    }
}