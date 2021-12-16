using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLight : MonoBehaviour
{
    float x;

    void Start()
    {
        
    }

    void Update()
    {

        if (x + 0.1f < Time.time)
        {
            GetComponent<Light>().intensity = Random.Range(500, 7000);
            x = Time.time;
        }

       


    }
}
