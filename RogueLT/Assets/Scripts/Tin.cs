using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tin : MonoBehaviour
{
    public PlayerMov myplayer;
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
        PlayerMov playerMov =
            other.gameObject.GetComponent<PlayerMov>();
        if (playerMov != null) {
            StartCoroutine(PowerupSequence());
        }
    }
    public IEnumerator PowerupSequence()
    {
        yield return new WaitForSeconds(20);
        Debug.Log("hello");
        //https://www.youtube.com/watch?v=_cYteEhbz-s
    }
}
