using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchLadderBetweenFloors : MonoBehaviour
{
    [SerializeField] private UnityEvent _turnedLadder;
    [SerializeField] private UnityEvent _disabledLadder;

    public event UnityAction Turned
    {
        add => _turnedLadder.AddListener(value);
        remove => _turnedLadder.RemoveListener(value);
    }

    public event UnityAction Disabled
    {
        add => _disabledLadder.AddListener(value);
        remove => _disabledLadder.RemoveListener(value);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent<RaccoonInput>(out RaccoonInput raccoonInput))
        {
            if (raccoonInput.DirectionOnLadder == 1 || raccoonInput.DirectionOnLadder == -1)
            {
                _turnedLadder?.Invoke();
            }
            if (raccoonInput.DirectionOnLadder == 0)
            {
                _disabledLadder?.Invoke();
            }
        }

        if (collision.TryGetComponent<Grandfather>(out Grandfather enemyMover))
        {
            if (enemyMover.Direction.y == 1 || enemyMover.Direction.y == -1)
            {
                _turnedLadder?.Invoke();
            }
            if (enemyMover.Direction.y == 0)
            {
                _disabledLadder?.Invoke();
            }
        }
    }
}
