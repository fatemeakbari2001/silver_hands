using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class SaveName : MonoBehaviour
{
    public GameObject nam1, nam2;
      public static string PlayerName1  = "122" ,PlayerName2 ="12";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerName1 = nam1.GetComponent<Text>().text;
        PlayerName2 = nam2.GetComponent<Text>().text;

        
        

    }
    
    
}
