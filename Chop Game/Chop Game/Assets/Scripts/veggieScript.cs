using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class veggieScript : MonoBehaviour
{
    private bool left = true;
    public float speed = 3.0f;

    // Update is called once per frame
    void Update()
    {
        // move the veggie to the left until x = -3 and then move it to the right till x = 15
        if (left)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x <= -3)
            {
                left = false;
            }
        }
        else
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.position.x >= 15)
            {
                left = true;
            }
        }
    }
}
