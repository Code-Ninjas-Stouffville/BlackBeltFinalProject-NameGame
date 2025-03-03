using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    public bool isDeath=false;
    public GameObject gameOverCanvas;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if(!isDeath){
        float moveHorizontal = Input.GetAxis("Horizontal");
        
        rb.velocity = new Vector2(moveHorizontal * speed,rb.velocity.y);
        }else if(isDeath){
            gameOverCanvas.SetActive(true);
        }
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }

}
