using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject timer;
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject score;
    Text myText;



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
            // SceneManager.LoadScene("Time up", LoadSceneMode.Additive);
            // // set the score in the new scene to the score in the game manager
            // myText = score.GetComponent<Text>();
            // Debug.Log(myText.text);
            // Debug.Log(GameObject.Find("Final Score").GetComponent<Text>().text);
            // GameObject.Find("Final Score").GetComponent<Text>().text = myText.text;
            // SceneManager.UnloadScene("Main");

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