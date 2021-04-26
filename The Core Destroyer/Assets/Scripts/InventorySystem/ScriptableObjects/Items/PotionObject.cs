using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Written by CRY
// This script lets you create a Potion item from the editor

[CreateAssetMenu(fileName = "New Potion Object", menuName = "Inventory System/Items/Potion")]
public class PotionObject : ItemObject
{
    public int restoreHealthValue;
    public void Awake()
    {
        type = ItemType.Potion;
    }
}
