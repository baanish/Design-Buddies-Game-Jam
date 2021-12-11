using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour
{
    private bool left = true;
    public float speed = 3.0f;

    // Update is called once per frame
    void Update()
    {
        // Move the hand to the left till x = 3 and then to the right till x = 21
        if (left)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            if (transform.position.x <= 3)
            {
                left = false;
            }
        }
        else
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            if (transform.position.x >= 21)
            {
                left = true;
            }
        }
    }
}
