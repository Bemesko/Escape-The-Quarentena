using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableLocationItem : MonoBehaviour, IClickInteract
{
    [SerializeField]
    private Location _destination;
    public void OnClick()
    {
        _destination.Arrive();
    }
}
