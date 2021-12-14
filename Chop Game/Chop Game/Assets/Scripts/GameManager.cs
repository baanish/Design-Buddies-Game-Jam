using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject timer;
    [SerializeField] GameObject timeUpPanel;


    bool isPauseActive;
    Timer myTimer;

    void Start()
    {
        myTimer = timer.GetComponent<Timer>();

        
    }

    void Update()
    {
        TimeUp();
        

        

    }

    void TimeUp()
    {
        if(myTimer.showTime <= 0)
        {
            Time.timeScale = 0;
            timeUpPanel.SetActive(true);
        }
    }

    public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;

    }

}
