using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScriptGame: MonoBehaviour
{
    public Sprite cardFace;
    public Sprite cardBack;
    private SpriteRenderer spriteRanderer;
    private SelectableGame selectable;
    private DataManager solitire;
    // Start is called before the first frame update
    void Start()
    {
        List<string> deck = DataManager.GenerateDeck();
        solitire = FindObjectOfType<DataManager>();
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
        selectable = GetComponent<SelectableGame>();
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
