using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebIcon : MonoBehaviour, IClickInteract
{
    [SerializeField]
    private GameObject _activatedItem;
    [SerializeField]
    private DialogueTrigger _dialogue;

    public void OnClick()
    {
        _activatedItem.SetActive(true);
        if (_dialogue)
            _dialogue.TriggerDialogue();
        Destroy(gameObject);
    }
}
