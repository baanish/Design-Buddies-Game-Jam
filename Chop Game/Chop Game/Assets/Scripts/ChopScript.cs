using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopScript : MonoBehaviour
{
    public GameObject knifeBlade;
    public GameObject knifeHandle;
    public GameObject knifeHand;
    public bool isChopping = false;
    public bool isMovingDown = false;
    public float speed = 30.0f;


    // Update is called once per frame
    void Update()
    {
        // on press space move all the objects down by 20 units and then back up by 20 units
        if (Input.GetKeyDown(KeyCode.Space) && !isChopping)
        {
            isChopping = true;
            isMovingDown = true;
        }
        if (isChopping)
        {
            if (isMovingDown)
            {
                knifeBlade.transform.Translate(Vector3.down * speed * Time.deltaTime);
                knifeHandle.transform.Translate(Vector3.down * speed * Time.deltaTime);
                knifeHand.transform.Translate(Vector3.down * speed * Time.deltaTime);
                if (knifeBlade.transform.position.y < 0)
                {
                    isMovingDown = false;
                }
            }
            else
            {
                knifeBlade.transform.Translate(Vector3.up * speed * Time.deltaTime);
                knifeHandle.transform.Translate(Vector3.up * speed * Time.deltaTime);
                knifeHand.transform.Translate(Vector3.up * speed * Time.deltaTime);
                if (knifeBlade.transform.position.y > 19.99)
                {
                    isChopping = false;
                }
            }
        }
    }
}
