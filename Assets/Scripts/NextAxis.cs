using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextAxis : MonoBehaviour
{
    public static float TheXAxis = -134.1f;
    public float InternatAxis;

    void Update()
    {
        InternatAxis = TheXAxis;
    }
}
