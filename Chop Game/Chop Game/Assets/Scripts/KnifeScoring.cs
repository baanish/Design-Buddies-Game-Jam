using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeScoring : MonoBehaviour
{

    [SerializeField] GameObject score;
    [SerializeField] AudioClip[] vegetableCutAudio;

    float myTime;
    Text myText;
    int scoreNumber = 0;
    AudioSource myAudio;
    int cutAudioNumber;

    void Start()
    {
        myText = score.GetComponent<Text>();
        myAudio = GetComponent<AudioSource>();
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
                cutAudioNumber = Random.Range(0, vegetableCutAudio.Length);
                myAudio.PlayOneShot(vegetableCutAudio[cutAudioNumber]);
                scoreNumber++;
                myTime = Time.time;

            }

    }
}
