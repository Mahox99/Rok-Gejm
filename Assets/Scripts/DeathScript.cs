using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject Screen;
    public GameObject Text;
    public GameObject Rocket;
    public GameObject MainAudio;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Highscore;
    public GameObject HighscoreCanva;
    public GameObject joystick;
    public GameObject PauseBtt;
    public bool stoper = true;
    void Start()
    {
        Screen.SetActive(false);
        Button1.SetActive(false);
        Button2.SetActive(false);
        Rocket.SetActive(true);
        Text.SetActive(false);
        joystick.SetActive(true);
        PauseBtt.SetActive(true);
    }
    void Update()
    {    
        if (Vechiclesystem.HP <= 0 && stoper == true)
        {
            NextAxis.TheXAxis = -134.1f;
            Highscore.SetActive(true);
            HighscoreCanva.SetActive(true);
            MainAudio.SetActive(false);
            Screen.SetActive(true);
            Button1.SetActive(true);
            Button2.SetActive(true);
            Rocket.SetActive(false);
            Text.SetActive(true);
            Text.GetComponent<UnityEngine.UI.Text>().text = "You die! \nYour Result: " + Vechiclesystem.TheScore;
            stoper = false;
            joystick.SetActive(false);
            PauseBtt.SetActive(false);
        }
    }
}
