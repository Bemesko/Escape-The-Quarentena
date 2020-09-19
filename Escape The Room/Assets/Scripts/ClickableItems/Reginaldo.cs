using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reginaldo : MonoBehaviour, IClickInteract
{
    private DialogueTrigger _standardDialogue;
    [SerializeField]
    private DialogueTrigger _beforeOboeDialogue;
    [SerializeField]
    private DialogueTrigger _afterOboeDialogue;
    [SerializeField]
    private GameObject _oboe;

    private void Awake()
    {
        _standardDialogue = GetComponent<DialogueTrigger>();
    }
    public void OnClick()
    {
        if (StoryManager.Instance.brokenKey)
        {
            if (InventoryManager.Instance.SelectedItem != null && InventoryManager.Instance.SelectedItem.ItemID == _oboe.GetComponent<SelectableItem>().ItemID)
            {
                _afterOboeDialogue.TriggerDialogue();
                BreakOboe();
            }
            else
            {
                _beforeOboeDialogue.TriggerDialogue();
            }
        }
        else
        {
            _standardDialogue.TriggerDialogue();
        }
    }

    private void BreakOboe()
    {
        throw new NotImplementedException();
    }
}
