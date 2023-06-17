using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PanelControler : MonoBehaviour
{
    public GameObject pause_window;
    public GameObject help_window;
    public GameObject sond;
    // Start is called before the first frame update
    public void help()
    {
        sond.GetComponent<AudioSource>().Play();
        help_window.SetActive(true);

    }
    public void exithelp()
    {
        sond.GetComponent<AudioSource>().Play();
        help_window.SetActive(false);

    }
    public void puase()
    {
        sond.GetComponent<AudioSource>().Play();
        Time.timeScale = 0;
        pause_window.SetActive(true);


    }
    public void resume()
    {
        sond.GetComponent<AudioSource>().Play();
        pause_window.SetActive(false);
        Time.timeScale = 1;

    }
    public void reload(int index)
    {
        sond.GetComponent<AudioSource>().Play();
       
        SceneManager.LoadSceneAsync(index);
        Time.timeScale = 1;

    }
    public void manue(int index)
    {
        sond.GetComponent<AudioSource>().Play();
        SceneManager.LoadSceneAsync(index);
        Time.timeScale = 1;
    }

}
