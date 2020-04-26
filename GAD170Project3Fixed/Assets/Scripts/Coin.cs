using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float spinSpeed = 100f;
    public UnityEvent coinPickUpRaised;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0f, 0f, Time.deltaTime * this.spinSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        coinPickUpRaised.Invoke();
        Destroy(this.gameObject);
    }
}
