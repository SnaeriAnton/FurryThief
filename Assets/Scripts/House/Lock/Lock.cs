using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Transform))]
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
        _lockOpener.BreakingDoor += CloseLock;
    }

    private void OnDisable()
    {
        _lockOpener.BreakingDoor -= CloseLock;
    }

    public void ShowLock(Transform transformDoor)
    {
        gameObject.SetActive(true);
        _openLock = true;
        _transform.position = new Vector2(transformDoor.position.x, transformDoor.position.y + 1);
    }

    private void CloseLock()
    {
        Opened?.Invoke();
        CloseLockPanelBreaking();
        Closed?.Invoke();
    }

    public void CloseLockPanelBreaking()
    {
        gameObject.SetActive(false);
        _openLock = false;
    }
}
