using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class PlayerStats
{
    private float movementSpeed = 5f;
    [SerializeField] private float driftSpeed = 10f;
    [SerializeField] private int health = 100;
    [SerializeField] private int tinAmount = 0;
    [SerializeField] private int boostAmount = 0;
    [SerializeField] private int level = 0;
    

    public float MovementSpeed
    {
        get {
            return movementSpeed; }
        set {
            movementSpeed = value; }
    }
    
    
}



public class PlayerMov : MonoBehaviour

{
    void powerup()
    {
        //change speed
        PlayerStats stats = new PlayerStats();
        stats.MovementSpeed = 10f;

    }
    void unpowerup()
    {
        PlayerStats stats = new PlayerStats();
        stats.MovementSpeed = 5f;
    }

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

    private void FixedUpdate()
    {
        PlayerStats stats = new PlayerStats();
        float mSpeed = stats.MovementSpeed;
        rb.velocity = movementDirection * mSpeed;
    }
}
