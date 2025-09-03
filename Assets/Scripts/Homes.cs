using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homes : MonoBehaviour
{
    public bool checkDirection = false;
    private int speed = 3;
    private Vector3 direction;
    void Start()
    {
        
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
}
