using UnityEngine.UI;
using UnityEngine;

public class LifeScript : MonoBehaviour
{
    public static int CurrentLife = MainScript.StartLife;
    public Text lifeText;
    private bool mark = true;
    

    void Start()
    {
        lifeText.text = (CurrentLife.ToString());
    }
    void Awake()
    {
        if (mark==true)
        {
            CurrentLife = MainScript.StartLife;
            
        }
    }


    public void Update()
    {
        
        lifeText.text = (CurrentLife.ToString());

        if (CurrentLife >= 9)
            CurrentLife = 9;
        if (CurrentLife <= 0)
            CurrentLife = 0;

    }

    public void lifeup()
    {
        mark = false;
        CurrentLife = CurrentLife + 1;
        
    }
    public void lifedown()
    {
        mark = false;
        CurrentLife = CurrentLife - 1;
    }

}
