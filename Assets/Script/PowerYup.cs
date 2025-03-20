using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PowerYup : MonoBehaviour
{
    public GameObject[] PowerUpItem;

    public float spawnTimer;
    public float minSpawnTime;
    public float maxSpawnTime;
    private float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        spawnDelay = UnityEngine.Random.Range(minSpawnTime, maxSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer = spawnTimer + Time.deltaTime;
        if (spawnTimer> spawnDelay)
        {
            CreatePowerUp();

            spawnDelay = UnityEngine.Random.Range(minSpawnTime, maxSpawnTime);
            spawnTimer = 0;
        }
    }
    void CreatePowerUp()
    {

        Instantiate(PowerUpItem[UnityEngine.Random.Range(0, PowerUpItem.Length)]);
    }
}
    