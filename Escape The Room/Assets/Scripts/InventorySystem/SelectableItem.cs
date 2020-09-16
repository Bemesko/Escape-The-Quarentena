using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableItem : MonoBehaviour, IClickInteract
{
    public bool IsSelected = false;
    public int ItemID;

    public void OnClick()
    {
        SelectInventoryItem();
    }

    public void SelectInventoryItem()
    {
        // checar se ele já não está selecionado
        if (IsSelected)
        {
            IsSelected = false;
            InventoryManager.Instance.SelectedItem = null;
        }
        else
        { // Se item selecionado não é ele
            IsSelected = true;
            InventoryManager.Instance.SelectedItem = this;
        }
    }
}
