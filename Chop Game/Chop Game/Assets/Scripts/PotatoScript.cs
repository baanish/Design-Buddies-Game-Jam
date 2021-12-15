using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoScript : MonoBehaviour
{

    [SerializeField] GameObject cutFruit;
    [SerializeField] float force;
    [SerializeField] int fruitHealth;


    GameObject spawnedFood;
    Rigidbody spawnedFoodRb;

    public float nextChop = 0.0f;
    public float chopRate = 0.5f;
    public float xOffset = 0.0f;

    private void OnCollisionEnter(Collision obj)
    {
        Debug.Log("Collision");
        if (obj.gameObject.tag == "Knife" && Time.time > nextChop)
        {
            nextChop = Time.time + chopRate;
            fruitHealth--;
            transform.localScale = new Vector3(20 * fruitHealth, 100, 100);
            spawnedFood = Instantiate(cutFruit, transform.position + new Vector3(-10.4f * fruitHealth/2, 0, 0), transform.rotation);
            //move this object right by 10.4 units
            xOffset += 15.4f;
            Destroy(spawnedFood, 5);
            if (fruitHealth == 0)
            {
                Destroy(gameObject, 0);
            }


            }

    }
}
