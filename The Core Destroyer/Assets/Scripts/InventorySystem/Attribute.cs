using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Made by CRY
// This script holds each player's attributes

[System.Serializable]
public class Attribute
{
    [System.NonSerialized] public PlayerStats parent;
    public Stats type;
    public ModifiableInt value;
    
    public void SetParent(PlayerStats _parent)
    {
        parent = _parent;
        value = new ModifiableInt(AttributeModified);
    }

    public void AttributeModified()
    {
        parent.AttributeModified(this);
    }
}
