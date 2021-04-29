using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Made by CRY
// This script holds inventory related things, including the player stats

public class PlayerStats : MonoBehaviour
{
    public Attribute[] attributes;

    PlayerMovement playerMovement;

    public GameObject equipmentStatsTexts;

    // For the inventory
    public InventoryObject inventory;
    public InventoryObject equipment;
    public bool noSelection = true;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    void Start()
    {
        for (int i = 0; i < attributes.Length; i++)
        {
            attributes[i].SetParent(this);
        }
        for (int i = 0; i < equipment.GetSlots.Length; i++)
        {
            equipment.GetSlots[i].OnBeforeUpdate += OnBeforeSlotUpdate;
            equipment.GetSlots[i].OnAfterUpdate += OnAfterSlotUpdate;
        }

        inventory.Load();
        equipment.Load();

        //inventory.SpawnItem(0, 1, new Vector3(1, 1, 0));

        //if firstTime
        //if KNIGHT
        attributes[(int)Stats.Strength].value.BaseValue = 7;
        attributes[(int)Stats.Vitality].value.BaseValue = 10;
        attributes[(int)Stats.Dexterity].value.BaseValue = 3;
        attributes[(int)Stats.Speed].value.BaseValue = 5;

    }

    public void OnBeforeSlotUpdate(InventorySlot _slot)
    {
        // On unequipping
        if (_slot.ItemObject == null) return;

        switch (_slot.parent.inventory.type)
        {
            case InterfaceType.Inventory:
                break;
            case InterfaceType.Equipment:
                for (int i = 0; i < _slot.item.stats.Length; i++)
                {
                    for (int j = 0; j < attributes.Length; j++)
                    {
                        if (attributes[j].type == _slot.item.stats[i].stat)
                            attributes[j].value.RemoveModifier(_slot.item.stats[i]);
                    }
                }
                break;
            default:
                break;
        }
    }
    public void OnAfterSlotUpdate(InventorySlot _slot)
    {
        // On equipping
        if (_slot.ItemObject == null) return;
        switch (_slot.parent.inventory.type)
        {
            case InterfaceType.Inventory:
                break;
            case InterfaceType.Equipment:
                for (int i = 0; i < _slot.item.stats.Length; i++)
                {
                    for (int j = 0; j < attributes.Length; j++)
                    {
                        if (attributes[j].type == _slot.item.stats[i].stat)
                            attributes[j].value.AddModifier(_slot.item.stats[i]);
                    }
                }
                break;
            default:
                break;
        }
    }




    #region Inventory Things

    public void OnTriggerEnter2D(Collider2D other)
    {
        // Pick up the item
        var item = other.GetComponent<GroundItem>();
        if (item)
        {
            Item _item = new Item(item.item);
            if (inventory.AddItem(_item, 1))
            {
                // If inventory isn't full, pick up and delete the ground item
                Destroy(other.gameObject);
            }
        }
    }
    private void OnApplicationQuit()
    {
        inventory.Save();
        equipment.Save();
        inventory.Clear();
        equipment.Clear();
    }
    #endregion


    public void AttributeModified(Attribute attribute)
    {
        // Occurs when an attribute value gets modified

        // Update the equipment total stats
        switch (attribute.type)
        {
            case Stats.Strength:
                //equipmentStatsTexts.transform.Find("Strength").GetComponent<TextMeshProUGUI>().text = "Strength: " + attribute.value.ModifiedValue.ToString();
                break;
            case Stats.Vitality:
                //equipmentStatsTexts.transform.Find("Vitality").GetComponent<TextMeshProUGUI>().text = "Vitality: " + attribute.value.ModifiedValue.ToString();
                break;
            case Stats.Dexterity:
                //equipmentStatsTexts.transform.Find("Dexterity").GetComponent<TextMeshProUGUI>().text = "Dexterity: " + attribute.value.ModifiedValue.ToString();
                break;
            case Stats.Speed:
                //equipmentStatsTexts.transform.Find("Speed").GetComponent<TextMeshProUGUI>().text = "Speed: " + attribute.value.ModifiedValue.ToString();
                playerMovement.speed = (attribute.value.ModifiedValue / 100) + 7f;
                break;
            case Stats.Damage:
                equipmentStatsTexts.transform.Find("Damage").GetComponent<TextMeshProUGUI>().text = "Damage: " + attribute.value.ModifiedValue.ToString();
                break;
            case Stats.KnockbackChance:
                break;
            case Stats.StunChance:
                break;
            case Stats.CriticalChance:
                equipmentStatsTexts.transform.Find("CritChance").GetComponent<TextMeshProUGUI>().text = "Crit Chance: " + attribute.value.ModifiedValue.ToString();
                break;
            case Stats.LingeringDamage:
                break;
            case Stats.Defense:
                equipmentStatsTexts.transform.Find("Defense").GetComponent<TextMeshProUGUI>().text = "Defense: " + attribute.value.ModifiedValue.ToString();
                break;
            default:
                break;
        }
    }
}