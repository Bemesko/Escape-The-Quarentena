using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : Node
{
    [SerializeField]
    private SelectableItem _selectableItem;
    public override void OnClick()
    {
        base.OnClick();
        //Exemplo de uso para um node interagir com o item selecionado
        if (InventoryManager.Instance.SelectedItem == _selectableItem)
        {
            Debug.Log("Localização selecionada com item");
        }
    }

}
