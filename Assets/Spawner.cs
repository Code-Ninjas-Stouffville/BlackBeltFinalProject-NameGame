using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Sockets;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;
public class Spawner : MonoBehaviour
{
    [Header("Spikes Object for controlling the game")]
    public GameObject Spikes;

    [Header("Default Height")]
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObject", 1f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(10, Random.Range(-height, height), 0);
    }

    void InstantiateObject()
    {
        Instantiate(Spikes, transform.position, transform.rotation);
    }
}
