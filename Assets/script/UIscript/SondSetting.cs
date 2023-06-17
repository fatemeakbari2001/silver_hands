using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SondSetting : MonoBehaviour
{
    public GameObject sond;
    public GameObject roleSond;
    public GameObject onOfSond;
 
    float ValuSond = 1;

    // Update is called once per frame
    void Update()
    {
        if (onOfSond.GetComponent<Toggle>().isOn)
        {
            ValuSond = roleSond.GetComponent<Scrollbar>().value;
            sond.GetComponent<AudioSource>().volume = ValuSond;
        }
        else
        {
            sond.SetActive(false);
            roleSond.SetActive(false);
        }
        if (onOfSond.GetComponent<Toggle>().isOn)
        {
            sond.SetActive(true);
            roleSond.SetActive(true);
        }

    }
}
