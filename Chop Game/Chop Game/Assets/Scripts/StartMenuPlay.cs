using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuPlay : MonoBehaviour
{

    //int hasShown;

    void Start()
    {
       ////PlayerPrefs.DeleteAll();
       // hasShown = PlayerPrefs.GetInt("hasShown", 0);
    }

    void Update()
    {
        SceneManager.LoadScene("Instructions");

        //Debug.Log(PlayerPrefs.GetInt("hasShown", 0)); 

        //if (hasShown == 0)
        //{
        //    PlayerPrefs.SetInt("hasShown", 1);
        //    //Debug.Log(PlayerPrefs.GetInt("hasShown", 0));
        //    SceneManager.LoadScene("Instructions");


        //}
        //else
        //{
        //    SceneManager.LoadScene("Main");
        //}
    }
}
