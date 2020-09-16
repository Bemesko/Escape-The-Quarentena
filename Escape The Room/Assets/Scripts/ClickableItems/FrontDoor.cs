using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontDoor : MonoBehaviour, IClickInteract
{
    [SerializeField]
    private DialogueTrigger _forgetKeyDialogue;
    [SerializeField]
    private DialogueTrigger _brokeKeyDialogue;
    [SerializeField]
    private GameObject _firstKey;
    [SerializeField]
    private GameObject _trueKey;
    public void OnClick()
    {
        if (!StoryManager.Instance.brokenKey)
        {
            //Exemplo de uso para um node interagir com o item selecionado
            if (InventoryManager.Instance.SelectedItem != null && InventoryManager.Instance.SelectedItem.ItemID == _firstKey.GetComponent<SelectableItem>().ItemID)
            {
                _brokeKeyDialogue.TriggerDialogue();
                StoryManager.Instance.brokenKey = true;
            }
            else
            {
                _forgetKeyDialogue.TriggerDialogue();
            }
        }
        else
        {
            if (InventoryManager.Instance.SelectedItem != null && InventoryManager.Instance.SelectedItem.ItemID == _trueKey.GetComponent<SelectableItem>().ItemID)
            {
                //EndGame()
            }
        }
    }
}
