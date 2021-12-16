using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoScript : MonoBehaviour
{

    [SerializeField] GameObject cutFruit;
    [SerializeField] float force;
    [SerializeField] int fruitHealth;
    public GameObject parsnip;
    public GameObject hand;
    public GameObject parsnipHand;


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
                GameObject spawnedCucumber = Instantiate(parsnip, new Vector3(transform.position.x,transform.position.y,transform.position.z - 4), transform.rotation) as GameObject;
                spawnedCucumber.transform.eulerAngles = new Vector3(90,0,0);
                spawnedCucumber.gameObject.GetComponent<ParsnipScript>().nextChop = nextChop;
                hand = GameObject.Find("Player_Arms_Parsnip");
                Transform[] handTransforms = hand.GetComponentsInChildren<Transform>();
                Transform[] cucumberHandTransforms = parsnipHand.GetComponentsInChildren<Transform>();
                // set the transform.rotation from hand to aubergineHand
                for (int i = 0; i < handTransforms.Length; i++)
                {
                    handTransforms[i].transform.rotation = cucumberHandTransforms[i].transform.rotation;
                }
            }


            }

    }
}
