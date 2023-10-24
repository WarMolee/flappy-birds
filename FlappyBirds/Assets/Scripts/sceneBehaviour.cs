using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneBehaviour : MonoBehaviour
{
    public Text titleText;
    public Button startButton;

    void Start()
    {
        startButton.onClick.AddListener(startGame);
    }


    public void startGame()
    {
        SceneManager.LoadScene("FlappyPlayin");
    }

}

