using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrapCardDisplay : MonoBehaviour {
    [HideInInspector]
    public TrapCard card;

    public Text descriptionText;
    public Text costText;
    public Text effect;
    public Text nameText;

    public Image cardImmage;

    public void cardSetup(TrapCard thisCard)
    {
        card = thisCard;
        nameText.text = card.cardName;
        descriptionText.text = card.description;

        costText.text = card.cardCost.ToString();
        effect.text = card.effect.ToString();


        cardImmage.sprite = card.art;
    }

}
