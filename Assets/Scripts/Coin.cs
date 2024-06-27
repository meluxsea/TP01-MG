using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public float turnSpeed = 90f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Obstaclev2>() != null)
        {
            Destroy(gameObject);
            return;
        }



        if(other.gameObject.name != "Player")
        {
            return;
        }


        Destroy(gameObject);

        GameManager.Inst.IncreScore();



        


    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0, turnSpeed * Time.deltaTime);
    }
}
