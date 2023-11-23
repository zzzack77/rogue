using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Tin : MonoBehaviour
{
    public PlayerMov myplayer;
    

    //[SerializeField] private GameObject _artTooDisable = null;

    private Collider2D m_collider;
    private void Awake()
    {
        m_collider = GetComponent<Collider2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Adds one to the tin amount which will be displayed eventually
            PlayerMov playerMov = other.gameObject.GetComponent<PlayerMov>();
            playerMov.playerStats.tinAmount++;
            Destroy(gameObject);
        }
    }
}
