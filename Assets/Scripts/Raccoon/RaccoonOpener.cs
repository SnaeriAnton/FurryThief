using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RaccoonOpener : MonoBehaviour
{
    private AidKit _aidKit;
    private Safe _safe;
    private bool _isAidKit = false;
    private bool _isSafe = false;
    private bool _openedSafe = false;

    public event UnityAction Opened;

    public void PusheSwitc()
    {
        Opened?.Invoke();
    }

    public void Open()
    {
        if (_isAidKit)
        {
            _aidKit.Open();
        }

        if (_isSafe)
        {
            if (_openedSafe == false)
            {
                _safe.OpenInputPanel();
                _openedSafe = true;
            }
            else
            {
                _safe.CloseInputPanel();
                _openedSafe = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<AidKit>(out AidKit aidKit))
        {
            _isAidKit = true;
            _aidKit = aidKit;
        }

        if (collision.TryGetComponent<Safe>(out Safe safe))
        {
            _isSafe = true;
            _safe = safe;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _isAidKit = false;
        _isSafe = false;
        _openedSafe = false;

    }
}
