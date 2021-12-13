using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour
{
    private bool left = true;
    private Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move the hand to the left till x = 11 and then to the right till x = 18
        if (left)
        {
            rb.AddForce(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x <= 11)
            {
                left = false;
            }
        }
        else
        {
            rb.AddForce(Vector3.right * speed * Time.deltaTime);
            if (transform.position.x >= 18)
            {
                left = true;
            }
        }
    }
}
