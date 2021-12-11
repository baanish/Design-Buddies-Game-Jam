using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] GameObject [] foodToSpawn;
    [SerializeField] float timeBetweenFoods;
    [SerializeField] float destoryTime;
    [SerializeField] float force;


    int foodToSpawnIndex;
    GameObject spawnedFood;
    float timeBetweenFoods2;


    void Start()
    {
        timeBetweenFoods2 = timeBetweenFoods;
    }

    void Update()
    {

        SpawnerMethod();

    }

    void SpawnerMethod()
    {
        if (timeBetweenFoods < Time.time)
        {
            foodToSpawnIndex = Random.Range(0, foodToSpawn.Length);

            spawnedFood = Instantiate(foodToSpawn[foodToSpawnIndex], transform.position, transform.rotation);

            spawnedFood.GetComponent<Rigidbody>().AddForce(Vector3.up * force);

            timeBetweenFoods += timeBetweenFoods2;
        }

        Destroy(spawnedFood, destoryTime);
    }
}
