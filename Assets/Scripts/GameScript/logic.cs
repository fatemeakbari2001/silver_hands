using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class logic : MonoBehaviour
{
    //public
    public GameObject player1, player2;
    public GameObject wonPlayer1, wonPlayer2, mosavi, canvas;
    public GameObject manuWonPlayer1, manuWonPlayer2, mosaviwiner;
    public GameObject hoshdar;

    string nameplayer1, nameplayer2;

    public Text scoreplayer1, scoreplayer2;

    public bool n1, n2;

    //Privaite
    GameObject ply1, ply2;
    int val1, val2;
    int scor1 = 0, score2 = 0;



    private void Start()
    {
        manuWonPlayer1.SetActive(false);
        manuWonPlayer2.SetActive(false);
        mosaviwiner.SetActive(false);

        StartCoroutine(nobat());
    }
    IEnumerator nobat()
    {
        while (true)
        {

            n1 = true;
            n2 = true;

            yield return new WaitForSeconds(2f);
            print("start");
            player1.SetActive(true);
            player2.SetActive(false);


            yield return new WaitForSeconds(1f);


            int i = 0;
            while (n1)
            {
                i++;
                if (GameObject.FindGameObjectWithTag("player1"))
                {
                    print("cardslected");
                    n1 = false;
                    player1.SetActive(false);
                }
                else
                {
                    yield return new WaitForSeconds(1f);

                }

                if (i > 3)
                {
                    print("please select acard");

                    Instantiate(hoshdar, new Vector3(0f, 0f, 0f), Quaternion.identity, canvas.transform);
                    yield return new WaitForSeconds(1f);
                }
            }



            yield return new WaitForSeconds(1f);





            player1.SetActive(false);
            player2.SetActive(true);
            print("finishd");
            yield return new WaitForSeconds(1f);
            int j = 0;
            while (n2)
            {
                j++;

                if (GameObject.FindGameObjectWithTag("player2"))
                {
                    print("cardslected");
                    n2 = false;
                    player2.SetActive(false);
                }
                else
                {
                    yield return new WaitForSeconds(1f);

                }
                if (j > 3)
                {
                    print("please select acard");
                    Instantiate(hoshdar, new Vector3(0f,0f,0f), Quaternion.identity, canvas.transform);
                    //yield return new WaitForSeconds(2f);
                    yield return new WaitForSeconds(1f);
                }

            }
            yield return new WaitForSeconds(1f);

            player1.SetActive(false);
            player2.SetActive(false);
            ply1 = GameObject.FindGameObjectWithTag("player1");
            ply2 = GameObject.FindGameObjectWithTag("player2");
            nameplayer1 = ply1.name;
            nameplayer2 = ply2.name;
            ply1.GetComponent<SelectableGame>().faceUp = true;
            ply2.GetComponent<Selectbe2>().faceUp = true;
            yield return new WaitForSeconds(2f);
            val1 = numbervalu(nameplayer1);
            val2 = numbervalu(nameplayer2);
            print(val1);
            print(val2);
            if (val1 > val2)
            {
                print("player1 won");
                Instantiate(wonPlayer1, wonPlayer1.transform.position, Quaternion.identity, canvas.transform);
                scor1++;
            }
            else if (val2 > val1)
            {
                print("player2 won");
                Instantiate(wonPlayer2, wonPlayer2.transform.position, Quaternion.identity, canvas.transform);
                score2++;
            }
            else
            {
                print("mosavi");
                Instantiate(mosavi, mosavi.transform.position, Quaternion.identity, canvas.transform);
                scor1++;
                score2++;
            }
            scoreplayer1.text = ("pIÃT¶H : " + scor1);
            scoreplayer2.text = ("pIÃT¶H : " + score2);
            Destroy(ply1);
            Destroy(ply2);



            yield return new WaitForSeconds(2f);


            if (scor1 >= 3 && scor1 > score2 && scor1 != score2)
            {
                manuWonPlayer1.SetActive(true);
                break;
            }
            if (score2 >=3 && scor1 < score2 && scor1 != score2)
            {
                manuWonPlayer2.SetActive(true);
                break;
            }
            if (scor1 >=3 && score2 >= 3 && scor1 == score2)
            {
                mosaviwiner.SetActive(true);
                break;
            }


        }

    }

    public int numbervalu(string player)
    {
        int a = 0;

        switch (player)
        {
            case "CA":
                a = 1;
                break;
            case "C2":
                a = 2;
                break;
            case "C3":
                a = 3;
                break;
            case "C4":
                a = 4;
                break;
            case "C5":
                a = 5;
                break;
//D
            case "DA":
                a = 1;
                break;
            case "D2":
                a = 2;
                break;
            case "D3":
                a = 3;
                break;
            case "D4":
                a = 4;
                break;
            case "D5":
                a = 5;
                break;
          //Heart
            case "HA":
                a = 1;
                break;
            case "H2":
                a = 2;
                break;
            case "H3":
                a = 3;
                break;
            case "H4":
                a = 4;
                break;
            case "H5":
                a = 5;
                break;
    
        }
        return a;
    }
}
