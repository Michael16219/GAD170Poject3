﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class TriggerBridge : MonoBehaviour
{
    public UnityEvent openBridgeTriggered;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
             openBridgeTriggered.Invoke();
        }
    }
}
