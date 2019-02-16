using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    Rigidbody2D body;
    float horizontal;
    [SerializeField]float speed;
    [SerializeField] float jumpForce;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontal * speed, body.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            body.velocity = body.velocity + Vector2.up * jumpForce;
        }
    }

    void FixedUpdate()
    {

    }
}
