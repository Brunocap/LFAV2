using UnityEngine;
using System.Collections;

public class UpdateActionCrystalsCommand : Command {

    private Player p;
    private int TotalMana;
    private int AvailableMana;

    public UpdateActionCrystalsCommand(Player p, int TotalMana, int AvailableMana)
    {
        this.p = p;
        this.TotalMana = TotalMana;
        this.AvailableMana = AvailableMana;
    }

    public override void StartCommandExecution()
    {
        p.PArea.ActionBar.TotalCrystals = TotalMana;
        p.PArea.ActionBar.AvailableCrystals = AvailableMana;
        CommandExecutionComplete();
    }
}
