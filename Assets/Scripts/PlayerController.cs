using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int force = 5;
    private Rigidbody rb;
    private bool onGround;
    void Start()
    {
        onGround = true;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            onGround = false;
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("OnGround"))
        {
            onGround = true;
        }
    }
}
