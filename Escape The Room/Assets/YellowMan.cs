using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowMan : PickableItem
{
    private DialogueTrigger _dialogueTrigger;

    private void Awake()
    {
        _dialogueTrigger = GetComponent<DialogueTrigger>();
    }
    public override void PickItem()
    {
        if (StoryManager.Instance.givenOboe)
        {
            base.PickItem();
        }
        else
        {
            _dialogueTrigger.TriggerDialogue();
        }
    }
}
