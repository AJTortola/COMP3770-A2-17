using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    public Transform Player;
    public Transform Respawn;
    public Transform Object;
    public Transform RespawnObject;

    void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player")){
            Player.transform.position = Respawn.transform.position;
            Object.transform.position = RespawnObject.transform.position;
            Physics.SyncTransforms();
       }
    }
}
