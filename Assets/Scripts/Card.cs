using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public string cardName { get; set; }
    public int cardID { get; set; }

    public const int tier = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SetName(string tempName)
    {
        cardName = tempName;
    }

    public override string ToString()
    {
        return name + ", Tier: " + tier;
    }
}
