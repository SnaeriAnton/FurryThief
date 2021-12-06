using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CompositeCollider2D))]
public class HallwayDoorLock : MonoBehaviour
{
    [SerializeField] private CompositeCollider2D _compositeCollider2D;
    [SerializeField] private ItemsManager _itemsManager;


    private void OnEnable()
    {
        _itemsManager.SignalingTurnOn += CloseDoor;
    }

    private void OnDisable()
    {
        _itemsManager.SignalingTurnOn -= CloseDoor;
    }

    private void CloseDoor()
    {
        _compositeCollider2D.isTrigger = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<HouseKey>(out HouseKey houseKey))
        {
            _compositeCollider2D.isTrigger = true;
        }
    }    
}
