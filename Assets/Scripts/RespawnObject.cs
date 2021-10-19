using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnObject : MonoBehaviour
{
    public Transform Player;
    public Transform Respawn;
    public Transform Trap;
    public Transform RespawnTrap;

    void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player")){
            Player.transform.position = Respawn.transform.position;
            Trap.transform.position = RespawnTrap.transform.position;
            Physics.SyncTransforms();
       }
    }
}
