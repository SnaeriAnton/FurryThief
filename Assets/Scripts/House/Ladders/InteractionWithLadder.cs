using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractionWithLadder : MonoBehaviour
{
    [SerializeField] private UnityEvent _enabledFloor;
    [SerializeField] private UnityEvent _disabledFloor;

    private RaccoonMoveLadder _moveLadde;

    public event UnityAction EnabledFloor
    {
        add => _enabledFloor.AddListener(value);
        remove => _enabledFloor.RemoveListener(value);
    }

    public event UnityAction DisabledFloor
    {
        add => _disabledFloor.AddListener(value);
        remove => _disabledFloor.RemoveListener(value);
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
        if (collision.TryGetComponent<RaccoonMoveLadder>(out RaccoonMoveLadder raccoonMoveLadder))
        {
            if (raccoonMoveLadder.SeenLadder == true)
            {
                _moveLadde = raccoonMoveLadder;
                _moveLadde.Climbed += Enable;
                _moveLadde.GotOff += Disable;
            }
        }

        if (collision.TryGetComponent<RaccoonInput>(out RaccoonInput raccoonInput))
        {
            if (raccoonInput.DirectionOnLadder == 1 || raccoonInput.DirectionOnLadder == -1)
            {
                _enabledFloor?.Invoke();
            }
            if (raccoonInput.DirectionOnLadder == 0)
            {
                _disabledFloor?.Invoke();
            }
        }


        if (collision.TryGetComponent<Grandfather>(out Grandfather enemyMover))
        {
            if (enemyMover.Direction.y == 1 || enemyMover.Direction.y == -1)
            {
                _enabledFloor?.Invoke();
            }
            if (enemyMover.Direction.y == 0)
            {
                _disabledFloor?.Invoke();
            }
        }
    }
}
