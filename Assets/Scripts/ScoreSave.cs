using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScoreSave : MonoBehaviour
{
    public int Score;
    public int HighScore;
    public string filename = "highscore.data";

    public void Start()
    {
        HighScore = ScoreLoad.CompareScore;
        Score = Vechiclesystem.TheScore;
        if (Score >= HighScore)
        {
            //PC:

            //var OurFile = File.CreateText(filename);
            //OurFile.WriteLine("" + Score);
            //OurFile.Close();


            //Android:            
            PlayerPrefs.SetInt("HighScore", Score);
        }
    }
}
