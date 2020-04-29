using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;


public class StairsTrigger : MonoBehaviour
{
    public UnityEvent onButtonPressed;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            onButtonPressed.Invoke();
        }
    }
}
