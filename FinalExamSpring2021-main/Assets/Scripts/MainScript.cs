using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{

    public Slider slider;
    public float time = 30f;
    public Text timeText;
    private int droplife;
    public Dropdown lifes;
    public static int StartLife;
    public Text lifeText;
    public static bool check = false;
    public static bool Mark = false;

    
    void Start()
    {

        timeText.text = ("TIME: " + time.ToString());
    }


    void Update()
    {
        lifeText.text = ("LIVES: " + droplife.ToString());
        timeText.text = ("TIME: " + time.ToString()) + " seconds";
        if (LifeScript.CurrentLife == 0)
        {
            LifeScript.CurrentLife = droplife;
        }

        if (TimerScript.startTime == 0)
        {
            TimerScript.startTime = time;
        }

        if (Mark == true)
        {
            LifeScript.CurrentLife = droplife;
            TimerScript.startTime = time;
            Mark = false;
        }
    }


    public void Play()
    {
        TimerScript.startTime = time;
        if (check == false)
        {
            StartLife = droplife;
        }
        else
        {
            StartLife = droplife;
        }
        SceneManager.LoadScene(1);
    }

    public void Awake()
    {
        slider = GameObject.FindWithTag("timer").GetComponent<Slider>();

    }
    public void OnEnable()
    {
        slider.onValueChanged.AddListener(delegate { sliderCallBack(slider); });
    }
    public void sliderCallBack(Slider slider)
    {
        time = slider.value;
    }

    public void LifeDrop()
    {
        switch (lifes.value)
        {
            default:
                droplife = 1;
                check = true;
                break;
            case 1:
                droplife = 1;
                check = true;
                break;
            case 2:
                droplife = 2;
                check = true;
                break;
            case 3:
                droplife = 3;
                check = true;
                break;
            case 4:
                droplife = 4;
                check = true;
                break;
            case 5:
                droplife = 5;
                check = true;
                break;
            case 6:
                droplife = 6;
                check = true;
                break;
            case 7:
                droplife = 7;
                check = true;
                break;
            case 8:
                droplife = 8;
                check = true;
                break;
            case 9:
                droplife = 9;
                check = true;
                break;
        }
    }

}
