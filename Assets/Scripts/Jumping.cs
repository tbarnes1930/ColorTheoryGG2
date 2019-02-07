using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{


    public Rigidbody rb;

    public float upForce;
    public bool jumpCheck;

    void Start()
    {
        jumpCheck = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MoveUp();
        }

    }

    void MoveUp()
    {
        if (jumpCheck == true)
        {
            rb.AddForce(Vector3.up * upForce);
            //rb.AddForce(transform.up * upForce);
        }

    }

    private void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == "Floor")
        {
            jumpCheck = true;
        }
    }

    private void OnCollisionExit (Collision other)
    {
        if (other.gameObject.tag == "Floor")
        {
            jumpCheck = false;
        }
}

}