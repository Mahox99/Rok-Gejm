using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCollection : MonoBehaviour
{
    public int StarScore = 50;
    public AudioSource StarSound;
 
    private void OnTriggerEnter(Collider other)
    {
            StarSound.Play();
            Vechiclesystem.TheScore += StarScore;
            this.transform.position = new Vector3(0, 1000, 0);
    }
}
