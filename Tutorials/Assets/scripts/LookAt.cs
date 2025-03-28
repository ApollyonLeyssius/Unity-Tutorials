using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class LookAt : MonoBehaviour
{

    public Transform target;

    private void FixedUpdate()
    {
        transform.LookAt(target);
    }
}
