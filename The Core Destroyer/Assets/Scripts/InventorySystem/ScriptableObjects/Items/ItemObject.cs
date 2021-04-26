using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Written by CRY
// This script holds the item types and the item infos for the Scriptable Object

public enum ItemType
{
    Potion,
    Weapon,
    ChestArmor,
    Default
}

public enum Stats
{
    Strength,
    Vitality,
    Dexterity,
    Speed,
    Damage,
    KnockbackChance,
    StunChance,
    CriticalChance,
    LingeringDamage,
    Defense,
}

public abstract class ItemObject : ScriptableObject
{
    public Sprite uiDisplay;
    public bool stackable;
    public ItemType type;
    [TextArea(15,20)] public string description;
    public Item data = new Item();
}

[System.Serializable]
public class Item
{
    public string Name;
    public int Id = -1;
    public ItemStats[] stats;
    
    
    public Item ()
    {
        Name = "";
        Id = -1;
    }
    public Item (ItemObject item)
    {
        Name = item.name;
        Id = item.data.Id;
        stats = new ItemStats[item.data.stats.Length];
        for (int i = 0; i < stats.Length; i++)
        {
            stats[i] = new ItemStats(item.data.stats[i].value)
            {
                stat = item.data.stats[i].stat
            };

        }
    }
}

[System.Serializable]
public class ItemStats : IModifiers
{
    public Stats stat;
    public int value;
    public ItemStats (int _value)
    {
        value = _value;
    }

    public void AddValue(ref int baseValue)
    {
        baseValue += value;
    }
}