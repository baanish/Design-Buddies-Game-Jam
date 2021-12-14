using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AubergineMovementScript : MonoBehaviour
{
    public GameObject hand;
    private float xOffset = 0.0f;
    public float nextChop = 0.0f;
    public float chopRate = 0.5f;

    // Update is called once per frame
    void Update()
    {
        hand = GameObject.Find("UpperArm.L");
        // synchronize the y position of the hand and the x position of the veggie with an offset of -7 to make it look like the hand is holding the veggie
        transform.position = new Vector3(hand.transform.position.x - 7 + xOffset, transform.position.y, transform.position.z);
    }
        private void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Knife" && Time.time > nextChop)
        {
            nextChop = Time.time + chopRate;
            //xOffset += 2.6f;
        }
    }
}
