using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    [SerializeField]
    private int _slotPosition;

    void Update()
    {
        if (transform.childCount <= 0)
        {
            InventoryManager.Instance.IsFull[_slotPosition] = false;
        }
    }
}
