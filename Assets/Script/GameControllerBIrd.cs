using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameControllerBIrd : MonoBehaviour
{
    public GameObject gameOverCanvas;

    public GameObject scoreCanvas;

    public GameObject spawner; 
    
       
            
            // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        scoreCanvas.SetActive(true);

        gameOverCanvas.SetActive(false); 

        spawner.SetActive(true);
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        spawner.SetActive(true);
        Time.timeScale = 0;
    }
    public void Reset()
    {
        SceneManager.LoadScene(3);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
