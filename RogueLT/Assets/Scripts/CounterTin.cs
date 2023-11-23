using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CounterTin : MonoBehaviour
{
    // Start is called before the first frame update
    public Text counterText;
    [SerializeField]
    public int tinCounter;
    private PlayerMov playerMov;

    void Start()
    {
        playerMov = GetComponent<PlayerMov>();
        playerMov.playerStats.tinAmount = 2;
        Debug.Log(playerMov.playerStats.tinAmount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
