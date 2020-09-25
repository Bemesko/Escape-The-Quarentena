using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectableItem : MonoBehaviour, IClickInteract
{
    public bool IsSelected = false;
    public int ItemID;
    private Image _image;

    void Awake()
    {
        _image = GetComponent<Image>();
    }

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
            _image.color = Color.white;
        }
        else
        { // Se item selecionado não é ele
            IsSelected = true;
            InventoryManager.Instance.SelectedItem = this;
            _image.color = Color.red;
        }
    }
}