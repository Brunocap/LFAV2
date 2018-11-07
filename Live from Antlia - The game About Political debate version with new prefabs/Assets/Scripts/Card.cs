using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : ScriptableObject {

    public string cardName;
    public string description;
    public Sprite art;
    public int cardCost;
    public string costType;
    public bool isTrap;
    public bool ongoing;
    public bool isInstant;
}
