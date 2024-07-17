using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
/// <summary>
/// Handles drag and drop of cards, as well as their movement when zooned out, etc.
/// </summary>
public class CardMovement : MonoBehaviour
{
    #region Fields and Properties

    private bool isBeingDragged;
    private Canvas cardCanvas; //need to get this at runtime, assigning in inspector won't work
    private RectTransform rectTransform;
    private Card card;

    private readonly string CANVAS_TAG = "CardCanvas";

    #endregion

    #region Methods

    public void Start()
    {
        cardCanvas = GameObject.FindGameObjectWithTag(CANVAS_TAG).GetComponent<Canvas>();
        rectTransform = GetComponent<RectTransform>();
        card = GetComponent<Card>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        isBeingDragged = true;
    }
    public void OnDrag(PointerEventData eventData) 
    {
        rectTransform.anchoredPosition += (eventData.delta / cardCanvas.scaleFactor);   
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isBeingDragged = false;
        Deck.Instance.DiscardCard(card);
    }
}
    #endregion