using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    public Transform Target;
    public float TargetX;
    public float CameraY = -10f;

    private Vector3 follow;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TargetX = Target.position.x - 25;
        follow = new Vector3(TargetX + CameraY, 7.5f, 19f);
        transform.position = follow;

    }
}
