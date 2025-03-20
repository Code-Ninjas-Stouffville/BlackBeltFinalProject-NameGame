
using System.Security.Cryptography;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject ballPrefab;
    public bool IsClone;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    // Start is called before the first frame update
  

    void Start()
    {
        startPosition = transform.position;
        if (IsClone)
        {
            Destroy(gameObject, 10f);
        }
        Launch();
        
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }
    // Update is calledbhbhbbhonce per frame
    void Update()
    {
        
    }

    private void Launch()
    {
        float x = Random.Range(0,2) == 0 ? -1 : 1;
        float y = Random.Range(0,2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PowerUp")
        {
            Instantiate(ballPrefab);
        }

    }

   // This is the time in seconds

  
}
