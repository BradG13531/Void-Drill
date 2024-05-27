using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Updates the cards UI depending on its data
public class CardUI : MonoBehaviour
{
    // Properties
    private Card _card; 

    [Header("Prefab Elements")] // References from objects in the card prefab
    [SerializeField] private Image cardImage;
    [SerializeField] private Image cardBackground;
    
    [SerializeField] private TextMeshProUGUI cardName;
    [SerializeField] private TextMeshProUGUI type;
    [SerializeField] private TextMeshProUGUI tier;
    [SerializeField] private TextMeshProUGUI description;

    [Header("Sprite Assets")] // References to the sprite folder
    [SerializeField] private Sprite draftCardBackground;
    
    // Methods
    private void Awake()
    {
        _card = GetComponent<Card>(); // Reference to the card object 
        SetCardUI();
    }

    // Lets you see changes in the editor without starting game
    private void OnValidate()
    {
        Awake();
    }

    public void SetCardUI()
    {
        if (_card != null && _card.CardData != null)
        {
            SetCardTexts();
            SetTypeBackground();
            SetCardImage();
        }
    }

    private void SetCardTexts()
    {
        cardName.text = _card.CardData.CardName;
        type.text = _card.CardData.Type.ToString();
        tier.text = _card.CardData.Tier.ToString();
        description.text = _card.CardData.CardDescription;
    }

    private void SetCardEffectTypeText()
    {
        // Might need this in the future
    }

    private void SetTypeBackground()
    {
        switch (_card.CardData.Type)
        {
            // TODO: Update this with card background sprites
            case Type.Basic:
                // Some default basic background that can be assigned to cards without types
                // cardBackground.sprite.GetComponent<Image>().enabled = false;
                break;
            case Type.Chipping:
                cardBackground.sprite = draftCardBackground;
                break;
            case Type.Catalyst:
                cardBackground.sprite = draftCardBackground;
                break;
            case Type.Command:
                cardBackground.sprite = draftCardBackground;
                break;
            case Type.Cannon:
                cardBackground.sprite = draftCardBackground;
                break;
        }
    }

    private void SetCardImage()
    {
        cardImage.sprite = _card.CardData.Image;
    }
}