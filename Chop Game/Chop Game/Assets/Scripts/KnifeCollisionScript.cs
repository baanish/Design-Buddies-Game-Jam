using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeCollisionScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.tag == "Veggie")
        {
            Debug.Log("Veggie has been chopped");            
        }
        if (collision.gameObject.tag == "Hand")
        {
            Debug.Log("Hand has been chopped");
        }
    }
}
