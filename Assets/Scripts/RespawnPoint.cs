using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    public Transform Player;
    public Transform Respawn;
    public Transform Trap;
    public Transform RespawnTrap;

    void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player")){
            Player.transform.position = Respawn.transform.position; // set Player position to the Respawn Object Poisiton
            Trap.transform.position = RespawnTrap.transform.position; // In Scene set Death Ball position to the DeathBallRespawn Poisiton
            Physics.SyncTransforms();
       }
    }
}
