using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This gives us the ability to create new Cards from the Unity editor 
// just by right-clicking, pressing "Create", and choosing "Card"
[CreateAssetMenu(fileName = "New Card", menuName = "Card/Card")]
public class Card : ScriptableObject
{
    public new string name;

    // Not sure if we need this 
    // public int cardID;

    public int tier;

    public Sprite artwork;

    public string description;
}
