using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Deck : MonoBehaviour
{
    // Enigmatide
    private LinkedList<Card> deck = new LinkedList<Card>();
    [SerializeField] private CardManager cardManager;
    private int deckLength = 3;
   
    // Start is called before the first frame update
    void Start()
    {
        InitializeDeck();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitializeDeck()
    {
        for (int i = 0; i < deckLength; i++)
        {
            deck.AddLast(cardManager.GetCard(i));
            Debug.Log(deck.ElementAt(i).cardName);
            Debug.Log(deck.ElementAt(i).cardID);
        }
    }
}
