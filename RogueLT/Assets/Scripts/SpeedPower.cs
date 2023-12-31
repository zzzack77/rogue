using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class SpeedPower : MonoBehaviour
{
    
    //public PlayerStats playerStats;

    //[SerializeField] private GameObject _artTooDisable = null;

    private Collider2D m_collider;
    private void Awake()
    {
        m_collider = GetComponent<Collider2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("speed up");

        
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("trigger activate");
            PlayerMov playerMov = other.gameObject.GetComponent<PlayerMov>();
            StartCoroutine(PowerupSequence(playerMov));
            
        }
        



    }
    public IEnumerator PowerupSequence(PlayerMov playerMov)
    {
        //increases speed, then after 10 seconds speed is reduced back to original 

        gameObject.transform.localScale = new Vector3(0, 0, 0);
        m_collider.enabled = false;
        playerMov.playerStats.movementSpeed = 10f;

        yield return new WaitForSeconds(10);

        playerMov.playerStats.movementSpeed = 5f;
        Destroy(gameObject);
        
        //https://www.youtube.com/watch?v=_cYteEhbz-s
    }
}
