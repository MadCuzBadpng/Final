using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public static int points;
    public Text pointText;

    void Start()
    {
        points = 0;
        pointText.text = (points.ToString());
    }    

    void Update()
    {
        pointText.text = (points.ToString());
        if (points <= 0)
            points = 0;
    }

    public void pointup()
    {
        points = points + 1;
    } 
    public void pointdown()
    {
        points = points - 1;
    }

    public void Next()
    {
        SceneManager.LoadScene(2);
    }
    
}
