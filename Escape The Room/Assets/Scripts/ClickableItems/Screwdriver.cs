using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screwdriver : MonoBehaviour, IClickInteract
{
    private DialogueTrigger _standardDialogue;
    [SerializeField]
    private DialogueTrigger _openToyDialogue;
    [SerializeField]
    private GameObject _toy;
    [SerializeField]
    private GameObject _trueKey;

    private void Awake()
    {
        _standardDialogue = GetComponent<DialogueTrigger>();
    }
    public void OnClick()
    {
        //Quebrar a chave
        if (InventoryManager.Instance.SelectedItem != null && InventoryManager.Instance.SelectedItem.ItemID == _toy.GetComponent<SelectableItem>().ItemID)
        {
            _openToyDialogue.TriggerDialogue();
            OpenToy();
        }
        else
        {
            _standardDialogue.TriggerDialogue();
        }
    }

    private void OpenToy()
    {
        _toy.SetActive(false);
        _trueKey.SetActive(true);
        InventoryManager.Instance.SelectedItem = null;
    }
}
