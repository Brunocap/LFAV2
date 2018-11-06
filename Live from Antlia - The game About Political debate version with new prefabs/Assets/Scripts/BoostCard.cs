﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Boost Card", menuName = "Cards/Boosts")]
public class BoostCard : Card {

    public int effect;
    public int boost;
    public string boostType;
}
