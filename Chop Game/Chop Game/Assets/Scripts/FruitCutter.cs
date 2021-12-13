using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitCutter : MonoBehaviour
{

    [SerializeField] GameObject cutFruit;
    [SerializeField] float force;
    [SerializeField] float explosionRadius;
    [SerializeField] int fruitHealth;
    [SerializeField] GameObject healthImage;
    Slider slider;


    GameObject spawnedFood;
    Rigidbody[] spawnedFoodRb;

    float sliderSubstractValue;

    void Start()
    {
        slider = healthImage.GetComponent<Slider>();
        sliderSubstractValue = slider.value / fruitHealth;
    }

    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision obj)
    {

        if (obj.gameObject.tag == "Knife")
        {

            

            if (fruitHealth == 1)
            {
                spawnedFood = Instantiate(cutFruit, transform.position, transform.rotation);
                spawnedFoodRb = spawnedFood.GetComponentsInChildren<Rigidbody>();

                foreach (Rigidbody rb2 in spawnedFoodRb)
                {
                    rb2.AddExplosionForce(force, spawnedFood.transform.position, explosionRadius);
                }

                Destroy(gameObject, 0);
                
            }

            slider.value -= sliderSubstractValue;
            fruitHealth -= 1;

        }

        
    }
}
