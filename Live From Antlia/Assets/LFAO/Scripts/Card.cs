using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class Card : ScriptableObject, IComparable<Card>
{

    public string cardName;
    public string description;
    public Sprite art;
    public int cardCost;
    public string costType;
    public bool isTrap;
    public bool ongoing;
    public bool isInstant;
    public bool isBoost;
    public bool isAttack;


    [Header("AttackCard")]
    public int damage;
    public string damageType;

    [Header("TrapCard")]
    public int trapEffect;
    public string effectType;
    public int turnsleft;

    [Header("StressCard")]
    public int Stresseffect;

    [Header("BoostCard")]
    public int BoostCardeffect;
    public int boost;
    public string boostType;

    [Header("Instant")]
    public TargetingOptions Targets;
    public int CompareTo(Card other)
    {
        return this.cardName.CompareTo(other.cardName);
    }

    


}
