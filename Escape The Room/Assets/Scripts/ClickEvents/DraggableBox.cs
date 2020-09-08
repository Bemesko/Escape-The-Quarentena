using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableBox : MonoBehaviour, IClickInteract
{
    private float _startPositionX;
    private float _startPositionY;
    private bool _isBeingHeld = false;

    private void Update()
    {
        if (_isBeingHeld)
        {
            Vector3 mousePosition;
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            this.gameObject.transform.localPosition = new Vector3(mousePosition.x - _startPositionX, mousePosition.y - _startPositionY);
        }
    }

    private void OnMouseDown()
    {
        Vector3 mousePosition;
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        _startPositionX = mousePosition.x - this.transform.localPosition.x;
        _startPositionY = mousePosition.y - this.transform.localPosition.y;

        _isBeingHeld = true;
    }

    private void OnMouseUp()
    {
        _isBeingHeld = false;
    }

    public void OnClick()
    {
        Debug.Log("bolinha arrastável");
    }
}
