using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{


    public Rigidbody rb;

    public float upForce;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MoveUp();
        }

    }

    void MoveUp()
    {
        rb.AddForce(Vector3.up * upForce);
        //rb.AddForce(transform.up * upForce);
    }
}