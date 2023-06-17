using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class startmanu : MonoBehaviour
{

    public GameObject setting_window, abouteUsWindow, start_window , ErroPnel,sond;

    public void start(int index)
    {
        SceneManager.LoadScene(index);
        sond.GetComponent<AudioSource>().Play();
    }
    public void doExitGame()
    {
        Application.Quit();
        sond.GetComponent<AudioSource>().Play();
    }
    public void AbouteUs()
    {
        abouteUsWindow.SetActive(true);
        sond.GetComponent<AudioSource>().Play();
    }
    public void Settings()
    {
        setting_window.SetActive(true);
        sond.GetComponent<AudioSource>().Play();
    }
    public void exitStart(GameObject exit)
    {
        exit.SetActive(false);
        sond.GetComponent<AudioSource>().Play();
    }

}
