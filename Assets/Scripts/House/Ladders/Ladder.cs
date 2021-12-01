using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ladder : MonoBehaviour
{
    [SerializeField] private UnityEvent _disabledFloor;
    [SerializeField] private UnityEvent _enabledFloor;

    private RaccoonMoveLadder _moveLadde;

    public event UnityAction DisabledFloor
    {
        add => _disabledFloor.AddListener(value);
        remove => _disabledFloor.RemoveListener(value);
    }
    public event UnityAction EnabledFloor
    {
        add => _enabledFloor.AddListener(value);
        remove => _enabledFloor.RemoveListener(value);
    }

    private void EnableLadder()
    {
        _enabledFloor?.Invoke();
        _moveLadde.Climbed -= EnableLadder;
    }

    private void DisableLadder()
    {
        _disabledFloor?.Invoke();
        _moveLadde.GotOff -= DisableLadder;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent<RaccoonMoveLadder>( out RaccoonMoveLadder raccoonMoveLadder))
        {
            _moveLadde = raccoonMoveLadder;
            _moveLadde.Climbed += EnableLadder;
            _moveLadde.GotOff += DisableLadder;
        }
    }
}
