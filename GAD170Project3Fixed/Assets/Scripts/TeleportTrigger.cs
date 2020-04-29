using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    public Transform teleportDestination ;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" )
        {
            Debug.Log("TeleportTrigger");
            
            CharacterController cc = other.GetComponent<CharacterController>();

            cc.enabled = false;
            other.transform.position = teleportDestination.position;
            cc.enabled = true;

        }
    }
}
