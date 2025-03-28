using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Mmovement : MonoBehaviour
{
    [SerializeField] private float speed = 50f;
    Rigidbody m_Rigidbody;
    [SerializeField] private float jumpForce = 20f;
    private bool onGround;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

        void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space) && onGround)
            {
                m_Rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                onGround = false;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("onGround"))
        {
            onGround = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("onGround"))
        {
            onGround = false;
        }
    }
}