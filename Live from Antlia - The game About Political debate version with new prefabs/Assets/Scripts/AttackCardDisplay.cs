using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackCardDisplay : MonoBehaviour {
    [HideInInspector]
    public AttackCard card;

    public Text descriptionText;
    public Text costText;
    public Text costType;
    public Text damageValueText;
    public Text damageTypeText;
    public Text nameText;

    public Image cardImmage;

    public void cardSetup(AttackCard thisCard)
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

        damageValueText.text = card.damage.ToString();
        damageTypeText.text = card.damageType;

        if (damageTypeText.text == "integrity")
        {
            damageValueText.color = new Color(0f, 0f, 200f);
        }
        if (damageTypeText.text == "funds")
        {
            damageValueText.color = new Color(200f, 200f, 0f);
        }
        if (damageTypeText.text == "popularity")
        {
            damageValueText.color = new Color(128f, 0f, 128f);
        }


        cardImmage.sprite = card.art;
    }


}
