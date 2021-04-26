using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using System;
using System.Linq;

// Written by CRY
// This script holds the UI of the Inventory

public abstract class UserInterface : MonoBehaviour
{

    #region VARIABLES AND REFERENCES

    // Variables for selecting the item and make it movable
    public PlayerStats player;

    public InventoryObject inventory; // Inventory Asset (Scriptable Object)
    public InventoryObject equipment;

    public InputInventoryUI inputInventory; // InputMaster Asset

    public Action<InputAction.CallbackContext> handler; // Needed for the Input Drop Event

    public Dictionary<GameObject, InventorySlot> slotsOnInterface = new Dictionary<GameObject, InventorySlot>();

    public TextMeshProUGUI[] itemStatsTexts;

    public GameObject temp;

    #endregion

    #region UNITY IN-BUILT FUNCTIONS

    void Awake()
    {
        // Initialize the InputMaster
        inputInventory = new InputInventoryUI();

        // Create UI
        for (int i = 0; i < inventory.GetSlots.Length; i++)
        {
            inventory.GetSlots[i].parent = this;
            inventory.GetSlots[i].OnAfterUpdate += OnSlotUpdate;
        }
        CreateSlots();
    }

    void OnEnable()
    {
        inputInventory.Enable();
    }

    void OnDisable()
    {
        inputInventory.Disable();
    }

    private void OnSlotUpdate(InventorySlot _slot)
    {
        // If the slot contains an item display sprite & amount
        if (_slot.item.Id >= 0)
        {
            _slot.slotDisplay.transform.GetChild(0).GetComponentInChildren<Image>().sprite = _slot.ItemObject.uiDisplay;
            _slot.slotDisplay.transform.GetChild(0).GetComponentInChildren<Image>().color = new Color(1, 1, 1, 1);
            // This means: if item amount is 1 then (?) display nothing, else (:) display the amount 
            _slot.slotDisplay.GetComponentInChildren<TextMeshProUGUI>().text = _slot.amount == 1 ? "" : _slot.amount.ToString("n0");
        }
        else // If it doesn't display nothing
        {
            _slot.slotDisplay.transform.GetChild(0).GetComponentInChildren<Image>().sprite = null;
            _slot.slotDisplay.transform.GetChild(0).GetComponentInChildren<Image>().color = new Color(1, 1, 1, 0);
            _slot.slotDisplay.GetComponentInChildren<TextMeshProUGUI>().text = "";
        }
    }



    #endregion

    #region UI FUNCTIONS

    public abstract void CreateSlots();

    #endregion

    #region USEFUL FUNCTIONS AND EVENTS

    /// <summary>
    /// This is a method to easily add Trigger events
    /// </summary>
    /// <param name="obj">The GameObject where you want to add the event</param>
    /// <param name="type">The EventTriggerType you want to add</param>
    /// <param name="action">The delegate</param>
    protected void AddEvent(GameObject obj, EventTriggerType type, UnityAction<BaseEventData> action)
    {
        EventTrigger trigger = obj.GetComponent<EventTrigger>();
        var eventTrigger = new EventTrigger.Entry();
        eventTrigger.eventID = type;
        eventTrigger.callback.AddListener(action);
        trigger.triggers.Add(eventTrigger);
    }



    /// <summary>
    /// This is the method called when you subscribe to handler's event
    /// </summary>
    /// <param name="ctx"></param>
    /// <param name="obj">The GameObject you want to add the event on</param>
    void Drop(InputAction.CallbackContext ctx, GameObject obj)
    {
        if (slotsOnInterface[obj].item.Id > -1)
            slotsOnInterface[obj].DropItem();
    }

    /// <summary>
    /// This is a method triggered when you select an inventory slot
    /// </summary>
    /// <param name="obj"></param>
    public void OnSelect(GameObject obj)
    {
        // Set the destination slot for the "Drag & Drop" to the slot I'm on currently
        KeyboardData.slotCurrentlySelected = obj;

        for (int i = 0; i < itemStatsTexts.Length; i++)
        {
            itemStatsTexts[i].text = "";
        }

        if (slotsOnInterface[obj].item.Id > -1)
        {
            int j = 0;
            for (int i = 0; i < slotsOnInterface[obj].item.stats.Length; i++)
            {
                if (slotsOnInterface[obj].item.stats[i].value != 0)
                {
                    itemStatsTexts[j].color = new Color(0, 1, 0);
                    itemStatsTexts[j].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString();
                    j++;
                }
            }
        }

        int strengthDelta, vitalityDelta, dexterityDelta, speedDelta, damageDelta, defenseDelta, knockbackDelta, stunDelta, critDelta;

        if (slotsOnInterface[obj].item.Id > -1)
        {
            int z = 0;
            for (int i = 0; i < slotsOnInterface[obj].item.stats.Length; i++)
            {
                for (int j = 0; j < equipment.GetSlots.Length; j++)
                {
                    if (equipment.GetSlots[j].ItemObject != null)
                    {
                        if (equipment.GetSlots[j].ItemObject.type == slotsOnInterface[obj].ItemObject.type)
                        {
                            for (int l = 0; l < equipment.GetSlots[j].item.stats.Length; l++)
                            {
                                if (equipment.GetSlots[j].item.stats[l].stat == slotsOnInterface[obj].item.stats[i].stat)
                                {
                                    if ((equipment.GetSlots[j].item.stats[l].value != 0 && slotsOnInterface[obj].item.stats[i].value != 0) || (equipment.GetSlots[j].item.stats[l].value != 0 && slotsOnInterface[obj].item.stats[i].value == 0))
                                    {
                                        itemStatsTexts[z].color = new Color((float)0.7019608, (float)0.5411765, (float)0.345098, 1);
                                        switch (slotsOnInterface[obj].item.stats[i].stat)
                                        {
                                            case Stats.Strength:
                                                strengthDelta = slotsOnInterface[obj].item.stats[i].value - equipment.GetSlots[j].item.stats[l].value;
                                                if (strengthDelta >= 0)
                                                    itemStatsTexts[z].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString() + " (+" + strengthDelta + ")";
                                                else
                                                    itemStatsTexts[z].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString() + " (" + strengthDelta + ")";
                                                z++;
                                                break;
                                            case Stats.Vitality:
                                                vitalityDelta = slotsOnInterface[obj].item.stats[i].value - equipment.GetSlots[j].item.stats[l].value;
                                                if (vitalityDelta >= 0)
                                                    itemStatsTexts[z].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString() + " (+" + vitalityDelta + ")";
                                                else
                                                    itemStatsTexts[z].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString() + " (" + vitalityDelta + ")";
                                                z++;
                                                break;
                                            case Stats.Dexterity:
                                                dexterityDelta = slotsOnInterface[obj].item.stats[i].value - equipment.GetSlots[j].item.stats[l].value;
                                                if (dexterityDelta >= 0)
                                                    itemStatsTexts[z].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString() + " (+" + dexterityDelta + ")";
                                                else
                                                    itemStatsTexts[z].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString() + " (" + dexterityDelta + ")";
                                                z++;
                                                break;
                                            case Stats.Speed:
                                                speedDelta = slotsOnInterface[obj].item.stats[i].value - equipment.GetSlots[j].item.stats[l].value;
                                                if (speedDelta >= 0)
                                                    itemStatsTexts[z].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString() + " (+" + speedDelta + ")";
                                                else
                                                    itemStatsTexts[z].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString() + " (" + speedDelta + ")";
                                                z++;
                                                break;
                                            case Stats.Damage:
                                                damageDelta = slotsOnInterface[obj].item.stats[i].value - equipment.GetSlots[j].item.stats[l].value;
                                                if (damageDelta >= 0)
                                                    itemStatsTexts[z].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString() + " (+" + damageDelta + ")";
                                                else
                                                    itemStatsTexts[z].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString() + " (" + damageDelta + ")";
                                                z++;
                                                break;
                                            case Stats.KnockbackChance:
                                                knockbackDelta = slotsOnInterface[obj].item.stats[i].value - equipment.GetSlots[j].item.stats[l].value;
                                                if (knockbackDelta >= 0)
                                                    itemStatsTexts[z].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString() + " (+" + knockbackDelta + ")";
                                                else
                                                    itemStatsTexts[z].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString() + " (" + knockbackDelta + ")";
                                                z++;
                                                break;
                                            case Stats.StunChance:
                                                stunDelta = slotsOnInterface[obj].item.stats[i].value - equipment.GetSlots[j].item.stats[l].value;
                                                if (stunDelta >= 0)
                                                    itemStatsTexts[z].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString() + " (+" + stunDelta + ")";
                                                else
                                                    itemStatsTexts[z].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString() + " (" + stunDelta + ")";
                                                z++;
                                                break;
                                            case Stats.CriticalChance:
                                                critDelta = slotsOnInterface[obj].item.stats[i].value - equipment.GetSlots[j].item.stats[l].value;
                                                if (critDelta >= 0)
                                                    itemStatsTexts[z].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString() + " (+" + critDelta + ")";
                                                else
                                                    itemStatsTexts[z].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString() + " (" + critDelta + ")";
                                                z++;
                                                break;
                                            case Stats.LingeringDamage:
                                                break;
                                            case Stats.Defense:
                                                defenseDelta = slotsOnInterface[obj].item.stats[i].value - equipment.GetSlots[j].item.stats[l].value;
                                                if (defenseDelta >= 0)
                                                    itemStatsTexts[z].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString() + " (+" + defenseDelta + ")";
                                                else
                                                    itemStatsTexts[z].text = slotsOnInterface[obj].item.stats[i].stat.ToString() + ": " + slotsOnInterface[obj].item.stats[i].value.ToString() + " (" + defenseDelta + ")";
                                                z++;
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        // Assign handler and subscribe to it (Drop event)
        handler = (InputAction.CallbackContext ctx) => Drop(ctx, obj);
        inputInventory.InventoryUInavigation.Drop.performed += handler;
    }

    /// <summary>
    /// This is a method triggered when you deselect that inventory slot
    /// </summary>
    /// <param name="obj"></param>
    public void OnDeselect(GameObject obj)
    {
        // Set to null the variables we assigned on "OnSelect"
        KeyboardData.slotCurrentlySelected = null;

        // Unsubscribe from handler (Drop event) when you deselect that slot to avoid multiple events
        inputInventory.InventoryUInavigation.Drop.performed -= handler;
    }

    /// <summary>
    /// This is a method triggered when you click/submit an inventory slot
    /// </summary>
    /// <param name="obj"></param>
    public void OnClick(GameObject obj)
    {
        // If you haven't already selected a slot... 
        if (player.noSelection)
        {
            // ...with an item inside, then...
            if (slotsOnInterface[obj].item.Id >= 0)
            {
                // ...store the item you have clicked on, change color of the clicked slot and turn noSelection to false
                obj.transform.GetComponent<Image>().color = new Color(0, 1, 1, 1);
                KeyboardData.itemFirstSelectedData = slotsOnInterface[obj];
                KeyboardData.itemFirstSelected = obj;
                player.noSelection = false;
            }
        }
        else // If you have already selected a slot and you want to move it somewhere...
        {
            if (KeyboardData.slotCurrentlySelected)
            {
                InventorySlot slotCurrentlySelectedData = slotsOnInterface[KeyboardData.slotCurrentlySelected];

                // ... change the color back of the previously clicked slot and move the item into the new slot
                KeyboardData.itemFirstSelected.transform.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                inventory.SwapItems(KeyboardData.itemFirstSelectedData, slotCurrentlySelectedData);
                KeyboardData.itemFirstSelectedData = null;
                slotCurrentlySelectedData = null;
            }

            // Delete the item we stored before and turn noSelection to true again
            KeyboardData.itemFirstSelected = null;
            KeyboardData.slotCurrentlySelected = null;
            player.noSelection = true;
        }
    }
    #endregion

}

public static class KeyboardData
{   // This class stores the infos for the selected item
    public static GameObject itemFirstSelected;
    public static GameObject slotCurrentlySelected;
    public static InventorySlot itemFirstSelectedData;
}