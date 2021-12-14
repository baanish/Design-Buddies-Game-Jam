using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CucumberScript : MonoBehaviour
{

    [SerializeField] GameObject cutFruit;
    [SerializeField] float force;
    [SerializeField] int fruitHealth;
    public GameObject aubergine;
    public GameObject hand;
    public GameObject aubergineHand;


    GameObject spawnedFood;
    Rigidbody spawnedFoodRb;

    public float nextChop = 0.0f;
    public float chopRate = 0.5f;
    public float xOffset = 0.0f;

    private void OnCollisionEnter(Collision obj)
    {

        if (obj.gameObject.tag == "Knife" && Time.time > nextChop)
        {
            nextChop = Time.time + chopRate;
            fruitHealth--;
            transform.localScale = new Vector3(100, 20 * fruitHealth, 100);
            spawnedFood = Instantiate(cutFruit, transform.position + new Vector3(-10.4f * fruitHealth/2, 0, 0), transform.rotation);
            spawnedFoodRb = spawnedFood.GetComponentInChildren<Rigidbody>();
            //move this object right by 10.4 units
            xOffset += 10.4f;
            spawnedFoodRb.AddForce(transform.forward * force);
            Destroy(spawnedFood, 5);
            if (fruitHealth == 0)
            {
                Destroy(gameObject, 0);
                // spawn a an aubergine prefab
                GameObject spawnedAubergine = Instantiate(aubergine, transform.position, transform.rotation) as GameObject;
                spawnedAubergine.transform.eulerAngles = new Vector3(spawnedAubergine.transform.eulerAngles.x, spawnedAubergine.transform.eulerAngles.y + 180, spawnedAubergine.transform.eulerAngles.z);
                spawnedAubergine.gameObject.GetComponent<AubergineScript>().nextChop = nextChop;
                Transform[] handTransforms = hand.GetComponentsInChildren<Transform>();
                Transform[] aubergineHandTransforms = aubergineHand.GetComponentsInChildren<Transform>();
                // set the transform.rotation from hand to aubergineHand
                for (int i = 0; i < handTransforms.Length; i++)
                {
                    handTransforms[i].transform.rotation = aubergineHandTransforms[i].transform.rotation;
                }


            }

        }

        
    }
}
