using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DynamicInterface : UserInterface
{
    public GameObject inventoryPrefab; // Prefab for Item Slot

    // Variables for the positioning of the slots
    public float X_START;
    public float Y_START;
    public int X_SPACE_BETWEEN_ITEM;
    public int NUMBER_OF_COLUMN;
    public int Y_SPACE_BETWEEN_ITEMS;

    public override void CreateSlots()
    {
        slotsOnInterface = new Dictionary<GameObject, InventorySlot>();

        // Cycle through all the inventory slots
        for (int i = 0; i < inventory.GetSlots.Length; i++)
        {
            // Instantiate an effective graphic slot
            var obj = Instantiate(inventoryPrefab, Vector2.zero, Quaternion.identity, transform);
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);

            // Add events to each slot (On select, On deselect and On submit)
            AddEvent(obj, EventTriggerType.Select, delegate { OnSelect(obj); });
            AddEvent(obj, EventTriggerType.Deselect, delegate { OnDeselect(obj); });
            AddEvent(obj, EventTriggerType.Submit, delegate { OnClick(obj); });

            // Assign the effective graphic slot to the array of slots
            inventory.GetSlots[i].slotDisplay = obj;

            // Add each slot to the Dictionary so we can access each
            slotsOnInterface.Add(obj, inventory.GetSlots[i]);

            // Make the first slot selected to make keyboard navigation possible
            if (i == 0)
            {
                EventSystem.current.SetSelectedGameObject(null);
                EventSystem.current.SetSelectedGameObject(obj);
            }
        }
    }

    /// <summary>
    /// This is a method that calculates the position of each slot
    /// </summary>
    /// <param name="i">Slot number</param>
    /// <returns>Vector2 position of the slot</returns>
    private Vector2 GetPosition(int i)
    {
        return new Vector2(X_START + (X_SPACE_BETWEEN_ITEM * (i % NUMBER_OF_COLUMN)), Y_START + (-Y_SPACE_BETWEEN_ITEMS * (i / NUMBER_OF_COLUMN)));
    }

}
