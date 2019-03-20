using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {
    [HideInInspector]
    public Card card;

    public Text descriptionText;
    public Text costText;
    public Text costType;
    public Text effectText;
    public Text effectType;
    public Text nameText;
    public Text damageValueText;
    public Text damageTypeText;
    public Text turnText;


    public Image cardImage;
    public Image CostOrb;
    public Image DamageOrb;
    public Image TurnOrb;

    public void cardSetup(Card thisCard)
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
        effectText.text = card.boost.ToString();
        effectType.text = card.boostType;
        if (effectType.text == "integrity")
        {
            costText.color = new Color(0f, 0f, 200f);
        }
        if (effectType.text == "funds")
        {
            costText.color = new Color(200f, 200f, 0f);
        }
        if (effectType.text == "popularity")
        {
            costText.color = new Color(128f, 0f, 128f); 
        }

        if (card.isAttack)
        {
            damageValueText.text = card.damage.ToString();
            damageTypeText.text = card.damageType.ToString();
            Destroy(TurnOrb.gameObject);
        }
        else if (card.isTrap)
        {
            effectText.text = card.trapEffect.ToString();
            effectType.text = card.effectType.ToString();
            turnText.text = card.turnsleft.ToString();
        }
        else if (card.isBoost)
        {
            effectText.text = card.BoostCardeffect.ToString();
            effectType.text = card.boostType.ToString();
            Destroy(TurnOrb.gameObject);
        }
        else if (card.isInstant)
        {
            Destroy(DamageOrb.gameObject);
            Destroy(TurnOrb.gameObject);
        }
        


        cardImage.sprite = card.art;
    }
}
