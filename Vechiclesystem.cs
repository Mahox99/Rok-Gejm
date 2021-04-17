using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vechiclesystem : MonoBehaviour
{
    public static int TheScore;
    public static int HP = 100;
    public GameObject ScoreDisplay;
    public GameObject HPDisplay;

    void Start()
    {
        HP = 100;
        TheScore = 0;
        InvokeRepeating("AddScore", 1, 0.5f);
    }

    void AddScore()
    {
        TheScore += 5;
        ScoreDisplay.GetComponent<UnityEngine.UI.Text>().text = "Score : " + TheScore;
        
    }
    void Update()
    {
        HPDisplay.GetComponent<UnityEngine.UI.Text>().text = "Hull : " + HP;
    }

}
