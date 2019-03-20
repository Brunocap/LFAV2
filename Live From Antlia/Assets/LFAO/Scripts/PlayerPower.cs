using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New player power", menuName = "Player/Player power")]
public class PlayerPower : ScriptableObject
{
    public int damage;
    public string damageType;


}
