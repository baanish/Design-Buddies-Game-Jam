using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class veggieScript : MonoBehaviour
{
    public GameObject hand;

    // Update is called once per frame
    void Update()
    {
        // synchronize the y position of the hand and the x position of the veggie with an offset of -7 to make it look like the hand is holding the veggie
        transform.position = new Vector3(hand.transform.position.x - 7, transform.position.y, transform.position.z);
    }
}
