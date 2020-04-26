using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    public Transform teleportDestination ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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
