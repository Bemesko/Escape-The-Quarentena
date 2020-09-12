using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickablePickupItem : MonoBehaviour, IClickInteract
{
    private PickableItem _pickableItem;

    private void Awake()
    {
        _pickableItem = GetComponent<PickableItem>();
    }
    public void OnClick()
    {
        _pickableItem.PickItem();
    }
}
