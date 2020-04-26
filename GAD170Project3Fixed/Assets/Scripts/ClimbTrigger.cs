using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbTrigger : MonoBehaviour
{
    public bool PlayerClimb = false;
    public float moveSpeed = 5f;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerClimb = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerClimb = false;
        }
    }
}