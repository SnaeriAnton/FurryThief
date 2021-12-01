using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchAtticLadder : MonoBehaviour
{
    [SerializeField] private UnityEvent _openedDoor;
    [SerializeField] private UnityEvent _closedDoor;

    private RaccoonOpener _raccoon;
    private bool _isOpen = false;

    public event UnityAction OpenedDoorCommunication
    {
        add => _openedDoor.AddListener(value);
        remove => _openedDoor.RemoveListener(value);
    }

    public event UnityAction ClosedDoorCommunication
    {
        add => _closedDoor.AddListener(value);
        remove => _closedDoor.RemoveListener(value);
    }

    private void Open()
    {
        if (_isOpen == false)
        {
            _isOpen = true;
            _openedDoor?.Invoke();
        }
        else
        {
            _isOpen = false;
            _closedDoor?.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<RaccoonOpener>(out RaccoonOpener raccoon))
        {
            _raccoon = raccoon;
            _raccoon.Opened += Open;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _raccoon.Opened -= Open;
    }
}
