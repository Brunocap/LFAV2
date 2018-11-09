using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Trap Card", menuName = "Cards/Traps")]
public class TrapCard : Card
{
    public int effect;
<<<<<<< HEAD
    public int turnsleft;
}
=======
    public int turnsleft = 4;

    public void Trigger(TrapCard thisCard)
    {
        if (turnsleft == 0)
        {

        }
    }
}
>>>>>>> c64a30ea75d7fbffc33afa9808c8fea352b615b1
