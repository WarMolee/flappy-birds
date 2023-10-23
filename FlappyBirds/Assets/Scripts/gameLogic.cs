using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameLogic : MonoBehaviour
{
    public int score;
    
    public Text scoreText;
    public Text gameOverText;

    void Start()
    {
        gameOverText.gameObject.SetActive(false);
        score = 0;
        scoreText.text = "Score: " + score.ToString();
    }

    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void playerDeath()
    {
        gameOverText.gameObject.SetActive(true);
        Debug.Log("Game Over");
    }
}

