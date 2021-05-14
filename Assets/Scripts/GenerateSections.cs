using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSections : MonoBehaviour
{
    public GameObject Section1;
    public GameObject Section2;
    public GameObject Section3;
    public GameObject Section4;
    public GameObject Section5;
    public GameObject Section6;
    public GameObject Section7;
    public GameObject Section8;

    public float NewXAxis = NextAxis.TheXAxis;
    public int GenSec;
    public GameObject NewSec;
    public Vector3 NextPosition = new Vector3(NextAxis.TheXAxis, 0.41f, -50.10f);

    void OnTriggerEnter(Collider other)
    {
        NextPosition = new Vector3(NextAxis.TheXAxis, 0.41f, -50.10f);
        GenSec = Random.Range(1, 9);
        NewXAxis = NextAxis.TheXAxis;

        if(GenSec == 1)
        {
            NewSec = Section1;
        }
        else if(GenSec == 2)
        {
            NewSec = Section2;
        }
        else if (GenSec == 3)
        {
            NewSec = Section3;
        }
        else if (GenSec == 4)
        {
            NewSec = Section4;
        }
        else if (GenSec == 5)
        {
            NewSec = Section5;
        }
        else if (GenSec == 6)
        {
            NewSec = Section6;
        }
        else if (GenSec == 7)
        {
            NewSec = Section7;
        }
        else if (GenSec == 8)
        {
            NewSec = Section8;
        }

        Instantiate(NewSec, NextPosition, Quaternion.identity);
        NextAxis.TheXAxis -= 50;
    }
 
}
