using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject timer;
    [SerializeField] GameObject pausePanel;




    Timer myTimer;

    void Start()
    {
        myTimer = timer.GetComponent<Timer>();



    }

    void Update()
    {
        TimeUp();
        Pause();




    }

    void TimeUp()
    {
        if (myTimer.showTime <= 0)
        {

            SceneManager.LoadScene("Time up");

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

    void Pause()
    {
        if(Input.GetKey(KeyCode.Escape))
        {

            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }
    }

    public void Rusume()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }

}