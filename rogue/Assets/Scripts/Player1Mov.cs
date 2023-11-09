using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Mov : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 1.0f;
    private Rigidbody2D rb;
    private Vector2 movementDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
    void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed;
    }
}
