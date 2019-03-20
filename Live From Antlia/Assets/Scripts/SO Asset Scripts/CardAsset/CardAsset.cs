using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum TargetingOptions
{
    NoTarget,
    AllCreatures, 
    EnemyCreatures,
    YourCreatures, 
    AllCharacters, 
    EnemyCharacters,
    YourCharacters
}

public class CardAsset : ScriptableObject 
{
    // this object will hold the info about the most general card
    [Header("General info")]
    public CharacterAsset characterAsset;  // if this is null, it`s a neutral card
    [TextArea(2,3)]
    public string Description;  // Description for spell or character
	public Sprite CardImage;
    public int ActionCost;
    public int IntCost;
    public int PopCost;
    public int FundsCost;
    public bool isTrap;
    public bool ongoing;
    public bool isInstant;
    public bool isBoost;
    public bool isAttack;

    [Header("Creature Info")]
    public int MaxHealth;   // =0 => spell card
    public int Attack;
    public int AttacksForOneTurn = 1;
    public bool Charge;
    public string CreatureScriptName;
    public int specialCreatureAmount;

    [Header("SpellInfo")]
    public string SpellScriptName;
    public int specialSpellAmount;
    public TargetingOptions Targets;
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
    [Header("BoostCard")]
    public int BoostCardeffect;
    public int boost;
    public string boostType;


}
