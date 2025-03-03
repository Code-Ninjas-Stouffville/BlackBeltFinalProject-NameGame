using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float shootCooldown;
    public float shootTimer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shootTimer = shootTimer + Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && shootTimer > shootCooldown)
        {
            shootTimer = 0;
            Shoot();
        }

        void Shoot ()
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
