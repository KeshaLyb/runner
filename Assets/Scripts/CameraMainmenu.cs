using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMainmenu : MonoBehaviour
{
    private float speed = 0.10f;
    private bool direction = false;
    private float startZ = -35.63f;
    private float endZ = 8.05f;
    void Start()
    {
        
    }

    void Update()
    {
        ChangeDirection();
        MoveCamera();
    }

    private void MoveCamera()
    {
        if (direction == false)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    private void ChangeDirection()
    {
        if (transform.position.z >= endZ)
        {
            direction = true;
        }
        else if (transform.position.z <= startZ)
        {
            direction = false;
        }
    }
}
