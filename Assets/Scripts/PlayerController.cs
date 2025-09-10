using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int force = 5;
    private Rigidbody rb;
    private bool onGround;
    public AudioClip audioJump;
    private AudioSource audioSource;
    void Start()
    {
        onGround = true;
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            audioSource.PlayOneShot(audioJump);
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
