using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour
{
    public GameObject InventoryItem;

    public void PickItem()
    {
        for (int i = 0; i < InventoryManager.Instance.Slots.Length; i++)
        {
            if (InventoryManager.Instance.IsFull[i] == false)
            {
                Instantiate(InventoryItem, InventoryManager.Instance.Slots[i].transform);
                Destroy(gameObject);
            }
        }
    }
}
