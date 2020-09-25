using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolinha : MonoBehaviour, IClickInteract
{
    private DialogueTrigger _dialogueTrigger;
    [SerializeField]
    private GameObject _interacterItem;

    private void Awake()
    {
        _dialogueTrigger = GetComponent<DialogueTrigger>();
    }
    public void OnClick()
    {
        if (InventoryManager.Instance.SelectedItem != null && InventoryManager.Instance.SelectedItem.ItemID == _interacterItem.GetComponent<SelectableItem>().ItemID)
        {
            _dialogueTrigger.TriggerDialogue();
        }
    }
}
