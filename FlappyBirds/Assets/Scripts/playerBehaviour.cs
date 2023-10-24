using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerBehaviour : MonoBehaviour
{

    public Rigidbody2D rb;
    public float jumpForce;
    public int score;
    public GameObject gameLogic;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rb.velocity.y < 5f)
            {
                rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            }
        }

        if (transform.position.y < -5)
        {
            playerDeath();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "point")
        {
            gameLogic.GetComponent<gameLogic>().score++;
            Debug.Log("Score: " + gameLogic.GetComponent<gameLogic>().score);
        }
        if (other.gameObject.tag == "Pipe")
        {
            Debug.Log("Collision");
            playerDeath();
        }
    }

    void playerDeath()
    {
        gameLogic.GetComponent<gameLogic>().playerDeath();
        Destroy(gameObject);
    }
}
