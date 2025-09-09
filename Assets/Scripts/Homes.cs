using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homes : MonoBehaviour
{
    public bool checkDirection = false;
    private int speed = 3;
    private Vector3 direction;
    public GameObject oneTeleport;
    public GameObject twoTeleport;
    void Start()
    {
        oneTeleport = GameObject.FindGameObjectWithTag("OneTeleport");
        twoTeleport = GameObject.FindGameObjectWithTag("TwoTeleport");
    }

    void Update()
    {
        if(checkDirection == false)
        {
            direction = Vector3.forward;
        }else
        {
            direction = Vector3.up;
        }
        transform.Translate(direction * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DestroyHomes"))
        {
            if (checkDirection == false)
            {
                gameObject.transform.position = twoTeleport.transform.position;
            }
            else
            {
                gameObject.transform.position = oneTeleport.transform.position;
            }
        }
    }
}
