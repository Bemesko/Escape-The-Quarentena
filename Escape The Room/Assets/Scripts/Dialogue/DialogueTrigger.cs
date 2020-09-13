using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue Dialogue;
    private Collider2D _collider2D { get; set; }

    void Awake()
    {
        _collider2D = GetComponent<Collider2D>();
    }

    public void TriggerDialogue()
    {
        _collider2D.enabled = false;
        DialogueManager.Instance.StartDialogue(Dialogue);
    }
}
