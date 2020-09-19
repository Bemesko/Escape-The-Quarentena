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
        if (StoryManager.Instance.BrokeKey)
        {
            if (InventoryManager.Instance.SelectedItem != null && InventoryManager.Instance.SelectedItem.ItemID == _oboe.GetComponent<SelectableItem>().ItemID)
            {
                _afterOboeDialogue.TriggerDialogue();
                GiveOboe();
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

    private void GiveOboe()
    {
        _oboe.SetActive(false);
        InventoryManager.Instance.SelectedItem = null;
        StoryManager.Instance.GaveOboe = true;
        Debug.Log(StoryManager.Instance.GaveOboe);
    }
}