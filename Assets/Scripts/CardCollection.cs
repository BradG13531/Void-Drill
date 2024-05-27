using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A general collection of CardData objects. Used in any instance where multiple cards would be needed,
// a deck, card pack, etc.
public class CardCollection : ScriptableObject
{
    [field: SerializeField] public List<ScriptableCard> CardsInCollection { get; private set; }

    public void RemoveCardFromCollection(ScriptableCard card)
    {
        if (CardsInCollection.Contains(card))
        {
            CardsInCollection.Remove(card);
        }
        else
        {
            Debug.Log("Card does not exist in current card collection.");
        }
    }

    public void AddCardToCollection(ScriptableCard card)
    {
        CardsInCollection.Add(card);
    }
}
