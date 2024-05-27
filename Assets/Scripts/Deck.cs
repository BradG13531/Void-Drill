using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

// Enigmatide
public class Deck : MonoBehaviour
{
    // Properties
    public static Deck Instance { get; private set; } // Singleton

    [SerializeField] private CardCollection playerDeck;
    [SerializeField] private Card cardPrefab; // This is used to make copies with different CardData   

    [SerializeField] private Canvas cardCanvas;
    
    // Represents the instantiated cards
    private List<Card> _deckPile;
    private List<Card> _discardPile;
    
    public List<Card> Hand { get; private set; }
    
    
    
    // Methods
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        // Called once at the start of the game
        InstantiateDeck();
    }

    private void InstantiateDeck()
    {
        for (int i = 0; i < playerDeck.CardsInCollection.Count; i++)
        {
            // Instantiates the card prefab as a child of the Card canvas, as UI
            Card card = Instantiate(cardPrefab, cardCanvas.transform);
            card.SetUp(playerDeck.CardsInCollection[i]);
            _deckPile.Add(card); // Cards start in the deck
            card.gameObject.SetActive(false);
        }
        Shuffle();
    }

    private void Shuffle()
    {
        int deckLength = _deckPile.Count();
        for (int i = 0; i < deckLength; i++)
        {
            int randomNum = Random.Range(i, deckLength);
            Card tempCard = _deckPile[randomNum];
            _deckPile[randomNum] = _deckPile[i];
            _deckPile[i] = tempCard;
        }
    }

    public void DrawHand(int amount = 1)
    {
        for (int i = 0; i < amount; i++)
        {
            if (_deckPile.Count <= 0)
            {
                _discardPile = _deckPile;
                _discardPile.Clear();
                Shuffle();
            }
            
            Hand.Add(_deckPile[0]);
            _deckPile[0].gameObject.SetActive(true);
            _deckPile.RemoveAt(0);
        }
    }

    // If needed, this exists here
    public void DiscardCard(Card card)
    {
        if (Hand.Contains(card))
        {
            Hand.Remove(card);
            _discardPile.Add(card);
            card.gameObject.SetActive(false);
        }
    }
}