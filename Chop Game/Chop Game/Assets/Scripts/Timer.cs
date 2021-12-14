using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    [SerializeField] Text timer;
     [SerializeField]float myTime;
    public float showTime;

    float currentTime;
    float x  ;

    void Start()
    {

        currentTime = Time.time;
        x = myTime; 


    }

    void Update()
    {
        currentTime = Time.time ;

        myTime -= Time.time;

        showTime = myTime;
        

        timer.text = Mathf.Round(myTime).ToString();
        myTime = x;
    }
}
