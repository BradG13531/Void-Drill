using UnityEngine;

[RequireComponent(typeof(CardUI))] // Attaches a CardUI to every card object
public class Card : MonoBehaviour
{
    [field: SerializeField] public ScriptableCard CardData { get; private set; }

    // Set card data at runtime
    public void SetUp(ScriptableCard data)
    {
        CardData = data;
        GetComponent<CardUI>().SetCardUI();
    }

}