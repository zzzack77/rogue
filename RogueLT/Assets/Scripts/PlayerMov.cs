using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class PlayerStats
{
    public float movementSpeed { get; set; }
    public float tinAmount { get; set; }
    private int health;
    private int driftSpeed;

    //public int Health = { get => health; }
    


}



public class PlayerMov : MonoBehaviour

{
    public PlayerStats playerStats;
    

    private Rigidbody2D rb;

    private Vector2 movementDirection;
    // Start is called before the first frame update
    void Start()
    {
        playerStats = new PlayerStats();

       
        
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

        //float mSpeed = stats.MovementSpeed;
        Debug.Log(playerStats.tinAmount);
        rb.velocity = movementDirection * playerStats.movementSpeed;
    }
}
