using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSprite2 : MonoBehaviour
{
    public Sprite cardFace;
    public Sprite cardBack;
    private SpriteRenderer spriteRanderer;
    private Selectbe2 selectable;
    private Data2 solitire;
    // Start is called before the first frame update
    void Start()
    {
        List<string> deck = Data2.GenerateDeck();
        solitire = FindObjectOfType<Data2>();
        int i = 0;
        foreach (string card in deck)
        {
            if (this.name == card)
            {
                cardFace = solitire.cardFace[i];
                break;
            }
            i++;

        }
        spriteRanderer = GetComponent<SpriteRenderer>();
        selectable = GetComponent<Selectbe2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (selectable.faceUp == true)
        {
            spriteRanderer.sprite = cardFace;
        }
        else
        {
            spriteRanderer.sprite = cardBack;
        }

    }
}
