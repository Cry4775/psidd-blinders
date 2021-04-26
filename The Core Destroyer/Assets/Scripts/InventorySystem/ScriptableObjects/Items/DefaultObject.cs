using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Written by CRY
// This script lets you create a Default item from the editor

[CreateAssetMenu(fileName = "New Default Object", menuName = "Inventory System/Items/Default")]
public class DefaultObject : ItemObject
{
    public void Awake ()
    {
        type = ItemType.Default;
    }
}
