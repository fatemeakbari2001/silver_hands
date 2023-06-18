using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput2 : MonoBehaviour
{
    //public
    public Data2 soly;

    //private
    bool isdrag;
    private bool isDragging = false;
    private Vector3 startPosition;
    private float distance = 10;
    private Vector3 posTop0 = new Vector3(0f, 0f, 2f);

    void OnMouseDown()
    {
        isdrag = gameObject.GetComponent<Selectbe2>().faceUp;
        isDragging = true;
        startPosition = transform.position;
    }

    void OnMouseDrag()
    {
        if (isDragging && isdrag)
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            // transform.position = objectPosition;
            transform.position = new Vector3(objectPosition.x, objectPosition.y, 0);

        }
    }

    void OnMouseUp()
    {
        isDragging = false;
        if (isdrag)
        {

            if ((transform.position.y < 0))
            {


                GameObject NP2 = Instantiate(gameObject, posTop0, Quaternion.Euler(gameObject.transform.rotation.x, gameObject.transform.rotation.y, gameObject.transform.rotation.z + 60));
                NP2.GetComponent<Selectbe2>().faceUp = false;

                NP2.GetComponent<AudioSource>().Play();
                NP2.name = gameObject.name;
                NP2.tag = "player2";

                print(gameObject.name);
                Destroy(gameObject);
            }
            else
            {
                transform.position = startPosition;
            }
        }


    }



}
