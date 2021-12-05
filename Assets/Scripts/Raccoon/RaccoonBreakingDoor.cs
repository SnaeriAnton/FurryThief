using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RaccoonBreakingDoor : MonoBehaviour
{
    private bool _openBreakingDoor = false;
    private Lock _lock;

    public event UnityAction<bool> Break;

    public void BreakingLockDoor()
    {
        if (_openBreakingDoor == true)
        {
            EnableMovePlayer();
            _lock.ClosePanelBreaking();
        }
    }

    private void BrokingLockDoor(bool lockDoor)
    {
        if (lockDoor == true)
        {
            _openBreakingDoor = lockDoor;
            Break?.Invoke(_openBreakingDoor);
        }
    }

    private void EnableMovePlayer()
    {
        _openBreakingDoor = false;
        Break?.Invoke(_openBreakingDoor);
        _lock.Opened -= EnableMovePlayer;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Lock>(out Lock lockDoor))
        {
            _lock = lockDoor;
            _lock.Opened += EnableMovePlayer;
            BrokingLockDoor(lockDoor.OpenLock);
        }
    }
}
