using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// Written by CRY
// This script lets you create a Equipment item from the editor

[CreateAssetMenu(fileName = "New Equipment Object", menuName = "Inventory System/Items/Equipment")]
public class EquipmentObject : ItemObject
{
    public void OnEnable()
    {
        bool saveExists = false;
        ItemStats[] save = new ItemStats[10];
        if (data.stats != null)
        {
            for (int i = 0; i < 10; i++)
            {
                save[i] = data.stats[i];
            }
            saveExists = true;
        }


        data.stats = new ItemStats[10];
        for (int i = 0; i < 10; i++)
        {
            if (!saveExists)
            {
                ItemStats statsDat = new ItemStats(0);
                statsDat.stat = (Stats)i;
                data.stats[i] = statsDat;
            }
            else
                data.stats[i] = save[i];
        }
    }
}
