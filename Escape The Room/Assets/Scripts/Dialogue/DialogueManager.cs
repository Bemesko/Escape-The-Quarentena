using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> Sentences;

    void Start()
    {
        Sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log(dialogue.name);

        Sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            Sentences.Enqueue(sentence);
        }


    }
}
