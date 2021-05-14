using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRotation : MonoBehaviour
{
     
    void Update()
    {
        transform.Rotate(0, 0.4f, 0, Space.Self);
    }
}
