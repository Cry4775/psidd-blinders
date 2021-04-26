using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// Written by CRY
// This script is for holding the ground Item Object (Equipment, Potion, DefaultObject...)

public class GroundItem : MonoBehaviour, ISerializationCallbackReceiver
{
    public ItemObject item;

    public void OnAfterDeserialize()
    {
    }

    public void OnBeforeSerialize()
    {
#if UNITY_EDITOR
        GetComponentInChildren<SpriteRenderer>().sprite = item.uiDisplay;
        EditorUtility.SetDirty(GetComponentInChildren<SpriteRenderer>());
#endif
    }
}
