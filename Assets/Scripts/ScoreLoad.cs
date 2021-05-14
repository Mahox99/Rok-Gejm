using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class ScoreLoad : MonoBehaviour
{
    public string filename = "highscore.data";
    public string Score, line;
    public GameObject HighScoreDisplay;
    public static int CompareScore, xxx;

    // Start is called before the first frame update
    void Start()
    {
        //PC:
        //StreamReader sr = new StreamReader(filename);
        //line = sr.ReadLine();
        //while (line != null)
        //{
        //    Score = line;
        //    line = sr.ReadLine();
        //}
        //sr.Close();


        //Android:

        xxx = PlayerPrefs.GetInt("HighScore");   
        HighScoreDisplay.GetComponent<UnityEngine.UI.Text>().text = "Best result: " + xxx;

        //CompareScore = int.Parse(Score);
    }

 
}
