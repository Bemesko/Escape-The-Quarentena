using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLocationButton : MonoBehaviour
{
    public void GoToRightLocation()
    {
        RoomManager.Instance.CurrentNode.GoToLocation(RoomManager.Instance.CurrentNode.RightLocation);
    }

    public void GoToLeftLocation()
    {
        RoomManager.Instance.CurrentNode.GoToLocation(RoomManager.Instance.CurrentNode.LeftLocation);
    }
}
