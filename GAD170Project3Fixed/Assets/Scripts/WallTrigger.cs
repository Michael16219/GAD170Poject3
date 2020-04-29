using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class WallTrigger : MonoBehaviour
{
    public UnityEvent openWallTriggered;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            openWallTriggered.Invoke();
        }
    }
}