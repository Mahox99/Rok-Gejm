using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMenuRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        transform.Rotate(0, 2, 1, Space.World);
    }
}
