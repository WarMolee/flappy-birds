using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameLogic : MonoBehaviour
{
    public int score;

    public GameObject block;
    public Text scoreText;
    public Text gameOverText;
    public Button startButton;

    void Start()
    {
        startButton.onClick.AddListener(restartGame);

        block.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);

        score = 0;
        scoreText.text = "Score: " + score.ToString();
    }

    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void playerDeath()
    {
        block.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        startButton.gameObject.SetActive(true);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

