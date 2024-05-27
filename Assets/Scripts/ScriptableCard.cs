using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Allows for individual cards to be instantiated
[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class ScriptableCard : ScriptableObject
{
    [field: SerializeField] public string CardName { get; private set; }
    [field: SerializeField, TextArea] public string CardDescription { get; private set; }
    [field: SerializeField] public int Tier { get; private set; }
    [field: SerializeField] public Sprite Image { get; private set; }
    [field: SerializeField] public Type Type { get; private set; }
}

public enum Type
{
    Basic,
    Chipping, 
    Catalyst,
    Command,
    Cannon
}

public enum Tier
{
    Common,
    Uncommon,
    Rare,
    Legendary
}
