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
            //Quebrar a chave
            if (InventoryManager.Instance.SelectedItem != null && InventoryManager.Instance.SelectedItem.ItemID == _firstKey.GetComponent<SelectableItem>().ItemID)
            {
                _brokeKeyDialogue.TriggerDialogue();
                _firstKey.SetActive(false);
                InventoryManager.Instance.SelectedItem = null;
                Debug.Log(InventoryManager.Instance.SelectedItem);
                StoryManager.Instance.brokenKey = true;
            }
            else
            {//Esquecer a chave
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
