using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    private int Player1Score;
    private int Player2Score;
    
    public void Player1Scored()
    {
        Player1Score++;
        Player1Text.GetComponent <TextMeshProUGUI>().text = Player1Score.ToString();

    }    
    
    public void Player2Scored()
    {
        Player2Score++;
        Player2Text.GetComponent <TextMeshProUGUI>().text = Player2Score.ToString();
    }
    // Start is called before the first frame update
   public void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<AIPaddle>().Reset();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player1Score >= 20)
        {
            SceneManager.LoadScene(1);
        }
        else if (Player2Score >= 20)
        {
            
            
                SceneManager.LoadScene(2);
            
        }
    }
}
