using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    public float lifespan;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
        Destroy(gameObject, lifespan);
    }

    void OnCollisionEnter2D (Collision2D hitInfo)
    {
       
        
        if (hitInfo.gameObject.tag == "Enemy")
        {
            
            gameObject.transform.rotation =Quaternion.Euler(new Vector3(gameObject.transform.localScale.x, gameObject.transform.localScale.y, Random.Range(0, 360)));
            rb.velocity = this.transform.up * speed;
            GameObject.Find("Player").GetComponent<ScoreScript>().ScoreNum= GameObject.Find("Player").GetComponent<ScoreScript>().ScoreNum+1;
            Destroy(hitInfo.gameObject);


            //Destroy(gameObject);
        }
        if (hitInfo.gameObject.tag == "Wall")
        {
            //gameObject.transform.rotation =Quaternion.Euler(new Vector3(gameObject.transform.localScale.x, gameObject.transform.localScale.y, Random.Range(0, 360)));
            //rb.velocity = this.transform.up * speed;
            //Destroy(gameObject);
        }
    }

}
