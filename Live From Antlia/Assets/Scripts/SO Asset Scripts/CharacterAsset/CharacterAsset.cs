using UnityEngine;
using System.Collections;

public enum CharClass{ Elf, Monk, Warrior}

public class CharacterAsset : ScriptableObject
{
	public CharClass Class;
	public string ClassName;
	public int MaxIntHealth = 30;
	public int MaxPopHealth = 30;
	public int MaxFundsHealth = 30;
	public string HeroPowerName;
	public Sprite AvatarImage;
    public Sprite HeroPowerIconImage;
    public Sprite AvatarBGImage;
    public Sprite HeroPowerBGImage;
    public Color32 AvatarBGTint;
    public Color32 HeroPowerBGTint;
    public Color32 ClassCardTint;
    public Color32 ClassRibbonsTint;
}
