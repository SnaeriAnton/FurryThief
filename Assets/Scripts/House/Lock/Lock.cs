using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lock : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private LockOpener _lockOpener;


    private bool _openLock = false;

    public bool OpenLock => _openLock;

    public event UnityAction Opened;
    public event UnityAction Closed;

    private void OnEnable()
    {
        _lockOpener.BreakingDoor += Close;
    }

    private void OnDisable()
    {
        _lockOpener.BreakingDoor -= Close;
    }

    public void Show(Transform transformDoor)
    {
        gameObject.SetActive(true);
        _openLock = true;
        _transform.position = new Vector2(transformDoor.position.x, transformDoor.position.y + 1);
    }

    private void Close()
    {
        Opened?.Invoke();
        ClosePanelBreaking();
        Closed?.Invoke();
    }

    public void ClosePanelBreaking()
    {
        gameObject.SetActive(false);
        _openLock = false;
    }
}
