using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementTest : MonoBehaviour
{
    public float Speed, Jump;
    private float Move;


    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(Move * Speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(rb.velocity.x, Jump));
        }
    }
}
