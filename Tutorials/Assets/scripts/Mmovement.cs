using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Mmovement : MonoBehaviour
{
    [SerializeField] private float speed = 50f;
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;
    private bool onGround;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }   
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.right * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && onGround == true)
            {
            m_Rigidbody.AddForce(transform.up * m_Thrust);
        }
    }

        private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "onGround")
        {
            onGround = true;
        }
    }
}
