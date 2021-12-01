using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchCommunicationLadder : MonoBehaviour
{
    [SerializeField] private UnityEvent _openedDoor;

    public event UnityAction OpenedDoorCommunication
    {
        add => _openedDoor.AddListener(value);
        remove => _openedDoor.RemoveListener(value);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent<ComminicationKey>(out ComminicationKey comminicationKey))
        {
            _openedDoor?.Invoke();
        }
    }
}
