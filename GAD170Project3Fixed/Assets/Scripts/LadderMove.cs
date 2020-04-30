using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderMove : MonoBehaviour
{
    public Transform LadderDestination;
    public Transform LadderTriggerTeleportDestiantion;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("TeleportTrigger");

            this.transform.position = LadderDestination.position;
            LadderTriggerTeleportDestiantion.position = LadderDestination.position;
        }
    }
}
