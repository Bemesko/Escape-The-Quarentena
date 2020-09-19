using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryManager : MonoBehaviour
{
    public static StoryManager Instance { get; private set; }
    public bool BrokeKey = false;
    public bool GaveOboe = false;

    [SerializeField]
    private DialogueTrigger _endDialogue;
    [SerializeField]
    private Image _blackImage;
    [SerializeField]
    private Canvas _creditsCanvas;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void EndGame()
    {
        _creditsCanvas.gameObject.SetActive(true);
        //Escurecer tela
        FadeToBlack();
        //Mostar diálogo que conta o que aconteceu depois
        _endDialogue.TriggerDialogue();
    }

    private void FadeToBlack()
    {
        Color fixedColor = _blackImage.color;
        fixedColor.a = 1;
        _blackImage.color = fixedColor;
        _blackImage.CrossFadeAlpha(0f, 0f, true);

        _blackImage.CrossFadeAlpha(1, 2.0f, false);
    }
}
