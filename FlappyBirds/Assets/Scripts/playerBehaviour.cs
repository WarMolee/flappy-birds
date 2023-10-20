using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerBehaviour : MonoBehaviour
{

    public Rigidbody2D rb;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rb.velocity.y < 5f)
            {
                //rb.AddForce(-transform.up * jumpForce, ForceMode2D.Impulse);
                rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            }
        }

        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pipe")
        {
            Debug.Log("Collision");
            Destroy(gameObject);
        }

    }
}
