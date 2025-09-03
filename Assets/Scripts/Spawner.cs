using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public GameObject target;
    private int counter = 0;
    private float timerSpawn = 3f;
    private float call = 3;
    void Start()
    {
        InvokeRepeating("Spawn", call, timerSpawn);
    }

    void Spawn()
    {
        Instantiate(prefab, target.transform.position, target.transform.rotation);
        counter++;
        if(counter == 5)
        {
            call = 1.5f;
            timerSpawn -= 0.2f;
            if(timerSpawn <= 0)
            {
                timerSpawn = 0.2f;
            }
            counter = 0;
            CancelInvoke();
            Start();
        }

    }
}
