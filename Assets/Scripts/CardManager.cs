using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public Card card_0;
    public Card card_1;
    public Card card_2;

    public Card GetCard(int num)
    {
        switch (num)
        {
            case 0:
                return card_0;
            case 1:
                return card_1;
            case 2:
                return card_2;
            default:
                return null;
        }
    }

}
