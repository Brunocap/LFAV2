using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StressCardDisplay : MonoBehaviour {
    [HideInInspector]
    public StressCard card;

    public Text descriptionText;
    public Text costText;
    public Text costType;
    public Text effect;
    public Text nameText;

    public Image cardImmage;
    // Use this for initialization
    public void cardSetup(StressCard thisCard)
    {
        card = thisCard;
        nameText.text = card.cardName;
        descriptionText.text = card.description;

        costText.text = card.cardCost.ToString();
        costType.text = card.costType;
        if (costType.text == "Integrity")
        {
            costText.color = new Color(0f, 0f, 200f);
        }
        if (costType.text == "Funds")
        {
            costText.color = new Color(200f, 200f, 0f);
        }
        if (costType.text == "Popularity")
        {
            costText.color = new Color(128f, 0f, 128f);
        }

       // effect.text = card.effect.ToString();


        cardImmage.sprite = card.art;
    }
}
