using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasementDoor : MonoBehaviour
{
    [SerializeField] private Transform _transform;

    public Vector2 GetPosition()
    {
        return _transform.position;
    }
}
