using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject GameOverCanvas; 
    // Start is called before the first frame update
    void Start()
    {
       GameOverCanvas = GameObject.Find("lose"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D (Collision2D hitInfo)
    {
       
        
        if (hitInfo.gameObject.tag == "Player"|| hitInfo.gameObject.tag == "Bottom")
        {
            Time.timeScale = 0;
            GameObject.Find("Player").GetComponent<BirdMovement>().isDeath=true;
            //hitInfo.gameObject.GetComponent<BirdMovement>().isDeath=true;
            //Destroy(gameObject);
        }

    }
}
