using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    
    public GameObject PauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Save()
    {
        //PlayerPrefs.SetString("Player Name", name.username);
        PlayerPrefs.SetFloat("Time Left", TimerScript.startTime);
        PlayerPrefs.SetInt("Lives Remaining", LifeScript.CurrentLife);
        PlayerPrefs.SetInt("Score", GameScript.points);
    }

    public void Load()
    {
        //Debug.Log("Player Name: " + PlayerPrefs.GetString("Player Name", name.username) + "\n");
        //name.username = PlayerPrefs.GetString("Player Name", name.username);

        Debug.Log("Time Left: " + PlayerPrefs.GetFloat("Time Left", TimerScript.startTime) + "\n");
        TimerScript.startTime = PlayerPrefs.GetFloat("Time Left", TimerScript.startTime);    
        
        Debug.Log("Lives Remaining: " + PlayerPrefs.GetInt("Lives Remaining", LifeScript.CurrentLife) + "\n");
        LifeScript.CurrentLife = PlayerPrefs.GetInt("Lives Remaining", LifeScript.CurrentLife);
        
        Debug.Log("Score: " + PlayerPrefs.GetInt("Score", GameScript.points) + "\n");
        GameScript.points = PlayerPrefs.GetInt("Score", GameScript.points);

    }

    public void Jason()
    {
        Debug.Log("Saved as JSON");
    }

    public void NewGame()
    {
        Time.timeScale = 1f;
        MainScript.Mark = true;
        SceneManager.LoadScene(0);
    }

}
