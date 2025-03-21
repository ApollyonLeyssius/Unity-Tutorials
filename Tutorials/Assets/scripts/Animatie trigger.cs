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
        if (Input.GetKey(KeyCode.E))
        {
            m_Animator.SetTrigger("Dance");
            Console.WriteLine("Dance");

        }

        if (Input.GetKey(KeyCode.R))
        {
            m_Animator.SetTrigger("Idle");
            Console.WriteLine("Idle");
        }
    }
}
