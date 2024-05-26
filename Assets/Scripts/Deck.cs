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
   
    // Start is called before the first frame update
    void Start()
    {
        // InitializeDeck();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitializeDeck()
    {
    }

}
