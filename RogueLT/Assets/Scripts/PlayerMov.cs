using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class PlayerStats
{
    public float movementSpeed {  get; set; }

    public void changeMovSpeed(float mov)
    {
        movementSpeed = mov;
        Debug.Log("movement speed was changed");
    }
}



public class PlayerMov : MonoBehaviour

{
    public PlayerStats playerStats;
    [SerializeField] float movspeedp = 5f;

    private Rigidbody2D rb;

    private Vector2 movementDirection;
    // Start is called before the first frame update
    void Start()
    {   
        
        rb = GetComponent<Rigidbody2D>();

        playerStats.movementSpeed = 5f;
        
    }


    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

    }

    private void FixedUpdate()
    {
        PlayerStats stats = new PlayerStats();

        //float mSpeed = stats.MovementSpeed;
        Debug.Log(stats.movementSpeed);
        rb.velocity = movementDirection * stats.movementSpeed;
    }
}
