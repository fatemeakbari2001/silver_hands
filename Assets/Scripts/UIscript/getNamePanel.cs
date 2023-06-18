using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class getNamePanel : MonoBehaviour
{
    public GameObject getPanl , eror;
    public Text ply1, ply2;
    public GameObject pause_window;
    public GameObject Setting_window;
    public GameObject sond , soundRolCard;
    public GameObject puaseBTN;
    
    // Start is called before the first frame update
    void Start()
    {
        getPanl.SetActive(true);
        Time.timeScale = 0;
        puaseBTN.SetActive(false);
        pause_window.SetActive(false);

    }

    // Start is called before the first frame update
    public void Setting ()
    {
        Setting_window.SetActive(true);
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
    public void OnOK()
    {
        if (ply1.text != "" && ply2.text != "")
        {
            getPanl.SetActive(false);
            Time.timeScale = 1;
            soundRolCard.GetComponent<AudioSource>().Play();
            puaseBTN.SetActive(true);
        }
        else
        {
            eror.SetActive(true);
            Invoke("serfals", 2f);
            // eror.SetActive(false);
        }

        
    }
   public void exitEror(GameObject eror)
    {
        eror.SetActive(false);
    }
    void setfals()
    {
        eror.SetActive(false);
    }
}
