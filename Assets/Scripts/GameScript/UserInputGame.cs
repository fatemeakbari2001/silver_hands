using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInputGame : MonoBehaviour
{
    //public
    public DataManager soly;

    //private
    private bool isDragging = false;
    private Vector3 startPosition;
    private float distance = 10;
    private Vector3 posTop0 = new Vector3(1.44f, 0f, 1f);
    private Vector3 posTop1 = new Vector3(0f, 0f, 0f);
    bool isdrag;


    private void Start()
    {

    }
    private void Update()
    {

    }
    void OnMouseDown()
    {
        isdrag = gameObject.GetComponent<SelectableGame>().faceUp;
        isDragging = true;
        startPosition = transform.position;
    }

    void OnMouseDrag()
    {
        if (isDragging && isdrag)
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = new Vector3(objectPosition.x, objectPosition.y, 0);

        }
    }

    void OnMouseUp()
    {
        isDragging = false;
        if (isdrag)
        {

            if ((transform.position.y > -1))
            {
                print(gameObject.name);
                GameObject NP1 = Instantiate(gameObject, posTop1, Quaternion.identity);
                NP1.GetComponent<SelectableGame>().faceUp = false;
                NP1.GetComponent<AudioSource>().Play();
                NP1.name = gameObject.name;
                NP1.tag = "player1";

                Destroy(gameObject);
            }
            else
            {
                transform.position = startPosition;
            }
        }


    }




}
