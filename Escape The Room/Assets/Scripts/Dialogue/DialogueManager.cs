using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance { get; private set; }
    private Queue<string> _sentences;
    [SerializeField]
    private TextMeshProUGUI _nameText;
    [SerializeField]
    private TextMeshProUGUI _dialogueText;
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    public DialogueTrigger _startDialogue;

    private void Awake()
    {
        _sentences = new Queue<string>();
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            _startDialogue.TriggerDialogue();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        _animator.SetBool("IsOpen", true);
        _nameText.SetText(dialogue.name);

        _sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            _sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (_sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = _sentences.Dequeue();
        _dialogueText.SetText(sentence);
    }

    void EndDialogue()
    {
        _animator.SetBool("IsOpen", false);
    }
}
