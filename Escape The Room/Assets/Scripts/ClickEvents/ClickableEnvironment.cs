using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableEnvironment : MonoBehaviour
{
    public bool CanClick = true;
    void Update()
    {
        if (!CanClick) return;
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePosition2D, Vector2.zero);

            if (hit.collider != null && hit.collider.GetComponent<IClickInteract>() != null)
            {
                hit.collider.GetComponent<IClickInteract>().OnClick();
                Debug.Log(gameObject);
            }
        }
    }
}
