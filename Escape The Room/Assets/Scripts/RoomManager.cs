using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public static RoomManager Instance { get; private set; }
    public enum Room { Living, Bathroom }
    public enum RoomAngle { North, East, South, West }
    public Room CurrentRoom;
    public RoomAngle CurrentRoomAngle;

    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
