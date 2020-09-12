using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Node : MonoBehaviour, IClickInteract
{
    [SerializeField]
    private List<Node> _reachableNodes = new List<Node>();
    [SerializeField]
    public Location RightLocation;
    [SerializeField]
    public Location LeftLocation;
    private Collider2D _collider2D;

    void Start()
    {
        _collider2D = GetComponent<Collider2D>();
    }

    public virtual void OnClick()
    {
        Arrive();
    }

    void Arrive()
    {
        if (RoomManager.Instance.CurrentNode != null)
        {
            RoomManager.Instance.CurrentNode.Leave();
        }

        RoomManager.Instance.CurrentNode = this;

        SetAllChildrenActive(true);


        if (_collider2D != null)
        {
            _collider2D.enabled = false;
        }

        SetReachableColliders(true);
    }

    void Leave()
    {
        SetAllChildrenActive(false);
        SetReachableColliders(false);
    }

    private void SetAllChildrenActive(bool activeState)
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(activeState);
        }
    }

    private void SetReachableColliders(bool isEnabled)
    {
        foreach (Node node in _reachableNodes)
        {
            if (node.GetComponent<Collider2D>() != null)
            {
                node.GetComponent<Collider2D>().enabled = isEnabled;
            }
        }
    }

    public void GoToLocation(Node location)
    {
        location.Arrive();
    }
}