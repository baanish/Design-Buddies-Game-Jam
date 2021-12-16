using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeScoring : MonoBehaviour
{

    [SerializeField] GameObject score;

    float myTime;
    Text myText;
    int scoreNumber = 0;

    void Start()
    {
        myText = score.GetComponent<Text>();
    }

    void Update()
    {
        myText.text = scoreNumber.ToString();
    }

    private void OnCollisionEnter(Collision obj)
    {
        if(obj.gameObject.CompareTag("Veggie"))
            if(Time.time > myTime + 0.5f)
            {
                scoreNumber++;
                myTime = Time.time;

            }

    }
}
