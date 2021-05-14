using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleColision : MonoBehaviour
{
    public int DamagePoint = 55;
    public AudioSource HitSound;

 
    private void OnTriggerEnter(Collider other)
    {
        HitSound.Play();
        Vechiclesystem.HP -= DamagePoint;
        this.transform.position = new Vector3(0, 1000, 0);
    }
}

    
