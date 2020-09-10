using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Node : MonoBehaviour, IClickInteract
{
    [SerializeField]
    private List<Node> _reachableNodes = new List<Node>();
    [SerializeField]
    private GameObject _imagemMostrada;
    private Collider2D _collider2D;

    void Start()
    {
        _collider2D = GetComponent<Collider2D>();
    }

    public void OnClick()
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

        //mostrar a imagem correspondente do nó
        _imagemMostrada.SetActive(true);


        if (_collider2D != null)
        {
            _collider2D.enabled = false;
        }

        SetReachableColliders(true);
    }

    void Leave()
    {
        _imagemMostrada.SetActive(false);
        SetReachableColliders(false);
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
}