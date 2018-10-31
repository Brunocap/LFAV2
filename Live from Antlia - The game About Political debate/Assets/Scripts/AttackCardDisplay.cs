using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackCardDisplay : MonoBehaviour {
    [HideInInspector]
    public AttackCard card;

    public Text descriptionText;
    public Text costText;
    public Text damageValueText;
    public Text nameText;

    public Image cardImmage;

    public void cardSetup(AttackCard thisCard)
    {
        card = thisCard;
        nameText.text = card.cardName;
        descriptionText.text = card.description;

        costText.text = card.cardCost.ToString();
        damageValueText.text = card.damage.ToString();


        cardImmage.sprite = card.art;
    }


}
