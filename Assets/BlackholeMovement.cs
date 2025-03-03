using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackholeMovement : MonoBehaviour
{
    public float velocity = 1; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            Time.timeScale = 0;
        }

        GameObject.Find("Canvas").GetComponent<Restart>().RestartLevel();
    }
}
