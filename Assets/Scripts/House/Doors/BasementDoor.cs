using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasementDoor : MonoBehaviour
{
    [SerializeField] private Transform _transformDoor;

    public Vector2 GetPositionDoor()
    {
        return _transformDoor.position;
    }
}
