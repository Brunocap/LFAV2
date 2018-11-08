using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Trap Card", menuName = "Cards/Traps")]
public class TrapCard : Card
{
    public int effect;
    public int turnsleft = 4;

    public void Trigger(TrapCard thisCard)
    {
        if (turnsleft == 0)
        {

        }
    }
}