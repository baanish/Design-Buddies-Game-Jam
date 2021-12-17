using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AubergineScript : MonoBehaviour
{

    [SerializeField] GameObject cutFruit;
    [SerializeField] float force;
    [SerializeField] int fruitHealth;
    public GameObject potato;
    public GameObject hand;
    public GameObject potatoHand;

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
            transform.localScale = new Vector3(100, 20 * fruitHealth, 100);
            spawnedFood = Instantiate(cutFruit, transform.position + new Vector3(-10.4f * fruitHealth/2, 0, 0), transform.rotation);
            //move this object right by 10.4 units
            xOffset += 10.4f;
            Destroy(spawnedFood, 5);
            if (fruitHealth == 0)
            {
                Destroy(gameObject, 0);
                // spawn a an aubergine prefab
                GameObject spawnedPotato = Instantiate(potato, transform.position, transform.rotation) as GameObject;
                spawnedPotato.transform.eulerAngles = new Vector3(90, 0, 0);
                spawnedPotato.gameObject.GetComponent<PotatoScript>().nextChop = nextChop;
                hand = GameObject.Find("Player_Arms_Parsnip");
                Transform[] handTransforms = hand.GetComponentsInChildren<Transform>();
                Transform[] potatoHandTransforms = potatoHand.GetComponentsInChildren<Transform>();
                // set the transform.rotation from hand to potatoHand
                for (int i = 0; i < handTransforms.Length; i++)
                {
                    handTransforms[i].transform.rotation = potatoHandTransforms[i].transform.rotation;
                }
                }


            }

    }
}
