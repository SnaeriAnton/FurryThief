using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LadderSwitch : MonoBehaviour
{
    [SerializeField] private UnityEvent _turnedLadder;
    [SerializeField] private UnityEvent _closedLadder;

    private RaccoonOpener _raccoon;
    private bool _isOpen = false;

    public event UnityAction Turned
    {
        add => _turnedLadder.AddListener(value);
        remove => _turnedLadder.RemoveListener(value);
    }

    public event UnityAction Closed
    {
        add => _closedLadder.AddListener(value);
        remove => _closedLadder.RemoveListener(value);
    }

    private void Open()
    {
        if (_isOpen == false)
        {
            _isOpen = true;
            _turnedLadder?.Invoke();
        }
        else
        {
            _isOpen = false;
            _closedLadder?.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<RaccoonOpener>(out RaccoonOpener raccoon))
        {
            _raccoon = raccoon;
            _raccoon.Opened += Open;
        }

        if (collision.TryGetComponent<ComminicationKey>(out ComminicationKey comminicationKey))
        {
            _turnedLadder?.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _raccoon.Opened -= Open;
        _raccoon = null;
    }
}
