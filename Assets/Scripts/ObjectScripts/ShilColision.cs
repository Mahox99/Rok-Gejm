using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShilColision : MonoBehaviour
{
    public int DamagePoint = 40;
    public AudioSource HitSound;

    private void OnTriggerEnter(Collider other)
    {
        HitSound.Play();
        Vechiclesystem.HP -= DamagePoint;
        this.transform.position = new Vector3(0, 1000, 0);
    }
}
