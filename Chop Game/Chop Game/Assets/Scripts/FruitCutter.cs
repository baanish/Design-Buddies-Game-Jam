using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCutter : MonoBehaviour
{

    [SerializeField] GameObject cutFruit;
    [SerializeField] float force;
    [SerializeField] float explosionRadius;
    


    GameObject spawnedFood;
    Rigidbody[] spawnedFoodRb;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision obj)
    {

        if (obj.gameObject.tag == "Knife")
        {

             spawnedFood = Instantiate(cutFruit, transform.position, transform.rotation);
             spawnedFoodRb = spawnedFood.GetComponentsInChildren<Rigidbody>();

            foreach(Rigidbody rb2 in spawnedFoodRb)
            {
                rb2.AddExplosionForce(force,spawnedFood.transform.position,explosionRadius);
            }

            Destroy(gameObject, 0);


        }

        
    }
}
