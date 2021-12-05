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

    private void Enable()
    {
        _enabledFloor?.Invoke();
        _moveLadde.Climbed -= Enable;
    }

    private void Disable()
    {
        _disabledFloor?.Invoke();
        _moveLadde.GotOff -= Disable;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent<RaccoonMoveLadder>( out RaccoonMoveLadder raccoonMoveLadder))
        {
            _moveLadde = raccoonMoveLadder;
            _moveLadde.Climbed += Enable;
            _moveLadde.GotOff += Disable;
        }
    }
}
