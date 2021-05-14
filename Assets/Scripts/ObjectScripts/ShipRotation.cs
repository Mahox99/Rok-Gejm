using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipRotation : MonoBehaviour
{
    public GameObject obj;
    public int Speed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.5f, 0, 0, Space.World);  
    }
}
