using System;
using System.Collections;
//using System.Diagnostics;
using UnityEngine;
using Random = UnityEngine.Random;
public class BlackholeSpawner : MonoBehaviour
{
    public float spawnCooldown;
    public float timer;
    public GameObject Blackhole;
    
    [Header("Blackhole Object for controlling the game")]
   

    [Header("Default Height")]
    public float ranX;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        timer = spawnCooldown;

        //InvokeRepeating("InstantiateObject", 1f, 4f);
    }

    // Update is called once per frame
    void Update()

    {
        timer = timer - Time.deltaTime;
        if (timer < 0)
        {
            timer = spawnCooldown;
            transform.position = new Vector3(Random.Range(-ranX, ranX), 10, 0);
            Instantiate(Blackhole, transform.position, transform.rotation);
        }
    }





    void InstantiateObject()
    {

    }
}




