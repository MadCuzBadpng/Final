using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public static float startTime;

    public Text timeText;

    void Start()
    {
        
        timeText.text = startTime.ToString();
    }


    void Update()
    {
        startTime -= Time.deltaTime;
        timeText.text = Mathf.Round(startTime).ToString();

        if(startTime <= 0)
        {
            startTime = 0;
        }
    }
}
