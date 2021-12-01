using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class BasementDoor : MonoBehaviour
{
    [SerializeField] private Transform _transform;

    public Vector2 GetPositionBasement()
    {
        return _transform.position;
    }
}
