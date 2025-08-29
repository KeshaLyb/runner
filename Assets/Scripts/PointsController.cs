using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsController : MonoBehaviour
{
    public TextMeshProUGUI textPoint;
    private int points = 0;
    public GameObject gameOverScreen;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("BarrierPoint"))
        {
            points++;
            textPoint.text = $"Points: {points}";
        }
        else if(other.gameObject.CompareTag("BarrierMinPoint"))
        {
            points--;
            if (points < 0)
            {
                points = 0;
                gameObject.SetActive(false);
            }
            textPoint.text = $"Points: {points}";
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
