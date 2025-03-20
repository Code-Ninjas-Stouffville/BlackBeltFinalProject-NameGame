using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;
public class FoxSpawner : MonoBehaviour
{
    public float spawnCooldown;
    float timer;
    public GameObject fox;
    [Header("Fox Object for controlling the game")]
    public GameObject Spikes;          

    [Header("Default Height")]
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
            transform.position = new Vector3(10, Random.Range(-height, height), 0);
            Instantiate(fox, transform.position, transform.rotation);
        }
    }

   



        void InstantiateObject()
    {

    }
}


