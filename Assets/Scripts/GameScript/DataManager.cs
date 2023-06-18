using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DataManager : MonoBehaviour
{
    public Sprite[] cardFace;
    public GameObject prefabCard;
    public GameObject[] bottomPos;
    public static string[] suits = new string[] { "C", "D" ,"H"};
    public static string[] values = new string[] { "A", "2", "3", "4", "5"};
    public List<string>[] bottoms;
    public List<string>[] tops;
    public List<string> deck;
    public List<int> deckValu;

    private List<string> bottom0 = new List<string>();





    // Start is called before the first frame update
    void Start()
    {
        bottoms = new List<string>[] { bottom0 };

        PlayCard();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayCard()
    {
        deckValu = generate();
        deck = GenerateDeck();
        Shuffle(deck);
        foreach (string card in deck)
        {
            print(card);

        }
        SolitaireSort();
        StartCoroutine(SolitaireDeal());

    }
    public static List<string> GenerateDeck()
    {
        List<string> newDeck = new List<string>();
      
        foreach (string s in suits)
        {

            foreach (string v in values)
            {

                newDeck.Add(s + v);
               
            }

        }

        return newDeck;
    }

    public static List<int> generate()
    {
        List<int> newDeck = new List<int>();
        foreach (string s in suits)
        {
            int j = 1;
            foreach (string v in values)
            {

                newDeck.Add(j);
                j++;
            }

        }

        return newDeck;
    }

    void Shuffle<T>(List<T> list)
    {
        System.Random random = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            int k = random.Next(n);
            n--;
            T temp = list[k];
            list[k] = list[n];
            list[n] = temp;
        }
    }
    IEnumerator SolitaireDeal()
    {

        int j = 0;
        float xOffset = 0f;
        float zOffset = 0.03f;
        for (; j < 6; j++)
        {
            yield return new WaitForSeconds(0.01f);

            GameObject newCard = Instantiate(prefabCard, new Vector3(bottomPos[0].transform.position.x - xOffset, bottomPos[0].transform.position.y, bottomPos[0].transform.position.z - zOffset), Quaternion.identity, bottomPos[0].transform);
            newCard.name = deck[j];
            newCard.GetComponent<SelectableGame>().faceUp = true;
            newCard.GetComponent<SelectableGame>().valu = deckValu[j];
            xOffset -= 0.3f;
            zOffset += 0.03f;


        }





    }
    void SolitaireSort()
    {
        for (int i = 0; i < 1; i++)
        {
            for (int j = i; j < 1; j++)
            {
                bottoms[j].Add(deck.Last<string>());
                deck.RemoveAt(deck.Count - 1);
            }

        }

    }




}