using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private int speed = 4;
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
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        

        transform.Translate(vertical * Vector3.forward * speed * Time.deltaTime);
        transform.Translate(horizontal * Vector3.right * speed * Time.deltaTime);

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
