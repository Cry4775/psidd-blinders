using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Written by CRY
// This script lets you create an Item Database, where you will put all the items (scriptable objects) we created before
// Each ID will be unique and correspond to one and only item

[CreateAssetMenu(fileName = "New Item Database", menuName = "Inventory System/Items/Database")]
public class ItemDatabaseObject : ScriptableObject, ISerializationCallbackReceiver
{
    public ItemObject[] ItemObjects;

    // This let us have a perfectly working database in the editor with each ID corresponding to one item (Player Inventory asset)

    [ContextMenu("Update ID's")]
    public void UpdateID()
    {
        for (int i = 0; i < ItemObjects.Length; i++)
        {
            if (ItemObjects[i].data.Id != i)
                ItemObjects[i].data.Id = i;
        }
    }
    public void OnAfterDeserialize()
    {
        UpdateID();
    }
    public void OnBeforeSerialize() 
    {
    } 
}
