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
        Debug.Log("hello");
        //playerStats.movementSpeed = 10f;
        

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
            PlayerMov playerMov =
            other.gameObject.GetComponent<PlayerMov>();
            StartCoroutine(PowerupSequence(playerMov));
        }
        
        
        
    }
    public IEnumerator PowerupSequence(PlayerMov playerMov)
    {
        m_collider.enabled = false;
        Debug.Log("touch");
        
        //_artTooDisable.SetActive(false);
        yield return new WaitForSeconds(2);
        Debug.Log("hello");
        //https://www.youtube.com/watch?v=_cYteEhbz-s
    }
}
