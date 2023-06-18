using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class returnePlayerName : MonoBehaviour
{
    public Text  inputName1,inputNane2,playerName1, playerName2;
    
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        playerName1.text = inputName1.text;
        playerName2.text = inputNane2.text;
        
    }
}
