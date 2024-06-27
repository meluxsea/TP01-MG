using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclev2 : MonoBehaviour
{

    PlayerMovement playerMov;
    // Start is called before the first frame update
    void Start()
    {
        playerMov = GameObject.FindObjectOfType<PlayerMovement>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerMov.Die();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
