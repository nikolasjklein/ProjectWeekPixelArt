using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EquipmentType
{
    Armor,
    Weapon,
}

[CreateAssetMenu]
public class EquippableItem : Item
{
    public int DamageBonus;
    public int ArmorBonus;
    [Space]
    public int DamagePercentBonus;
    public int ArmorPercentBonus;
    [Space]
    public EquipmentType EquipmentType;
}
