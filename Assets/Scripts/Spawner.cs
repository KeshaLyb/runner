using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public GameObject target;

    void Start()
    {
        InvokeRepeating("Spawn", 3, 3);
    }

    void Spawn()
    {
        Instantiate(prefab, target.transform.position, target.transform.rotation);
    }

    void Update()
    {
        
    }
}
