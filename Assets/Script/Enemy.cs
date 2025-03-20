using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D (Collision2D hitInfo)
    {
       
        
        if (hitInfo.gameObject.tag == "Player"|| hitInfo.gameObject.tag == "Bottom")
        {
            GameObject.Find("Player").GetComponent<BirdMovement>().isDeath=true;
            //hitInfo.gameObject.GetComponent<BirdMovement>().isDeath=true;
            //Destroy(gameObject);
        }

    }
}
