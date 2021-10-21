using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBallDrop : MonoBehaviour
{
    public Transform Player;
    public GameObject deathBall;
    void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player")){
            deathBall.GetComponent<Rigidbody>().useGravity = true;
       }
    }
}



