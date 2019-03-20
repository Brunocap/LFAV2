using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostCardDisplay : MonoBehaviour {
    [HideInInspector]
    public BoostCard card;

    public Text descriptionText;
    public Text costText;
    public Text costType;
    public Text boostText;
    public Text boostType;
    public Text effect;
    public Text nameText;

    public Image cardImmage;
    public void cardSetup(BoostCard thisCard)
    {
        card = thisCard;
        nameText.text = card.cardName;
        descriptionText.text = card.description;

        costText.text = card.cardCost.ToString();
        costType.text = card.costType;
        if (costType.text == "integrity")
        {
            costText.color = new Color(0f, 0f, 200f);
        }
        if (costType.text == "funds")
        {
            costText.color = new Color(200f, 200f, 0f);
        }
        if (costType.text == "popularity")
        {
            costText.color = new Color(128f, 0f, 128f);
        }

        boostText.text = card.boost.ToString();
        boostType.text = card.boostType;
        if (boostType.text == "integrity")
        {
            costText.color = new Color(0f, 0f, 200f);
        }
        if (boostType.text == "funds")
        {
            costText.color = new Color(200f, 200f, 0f);
        }
        if (boostType.text == "popularity")
        {
            costText.color = new Color(128f, 0f, 128f);
        }
       // effect.text = card.effect.ToString();


        cardImmage.sprite = card.art;
    }

}

