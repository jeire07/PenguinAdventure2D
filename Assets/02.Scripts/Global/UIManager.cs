using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public ItemSlot[] ItemSlots;

    public void SetInventory()
    {
        for(int i = 0; i < DataManager.Instance.Inventory.MyItems.Length; i++)
        {
            ItemSlots[i].Init(DataManager.Instance.Inventory.MyItems[i]);

        }
    }
}
