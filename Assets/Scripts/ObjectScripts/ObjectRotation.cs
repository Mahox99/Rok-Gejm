using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    public GameObject obj;
    public int Speed = 2;
 

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0.2f, 0.5f, 0, Space.World);

    }
}
