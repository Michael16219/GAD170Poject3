using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeRotator : MonoBehaviour
{
    public void RotateBridge()
    {
        this.transform.rotation = Quaternion.Euler(270, 0, 0);
    }
}
