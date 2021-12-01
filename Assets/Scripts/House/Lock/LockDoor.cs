using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CompositeCollider2D))]
[RequireComponent(typeof(AudioSource))]
public class LockDoor : MonoBehaviour
{
    [SerializeField] private Lock _lock;
    [SerializeField] private CompositeCollider2D _compositeCOllider2D;
    [SerializeField] private AudioSource _audioSource;

    private void OnEnable()
    {
        _lock.Opened += OpenDoor;
    }

    private void OnDisable()
    {
        _lock.Opened -= OpenDoor;
    }

    private void ShowPanleLock(Transform transform)
    {
        _lock.ShowLock(transform);
    }

    private void OpenDoor()
    {
        _compositeCOllider2D.isTrigger = true;
        _audioSource.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<TurnScrew>(out TurnScrew turnScrew))
        {
            if (_compositeCOllider2D.isTrigger == false)
            {
                ShowPanleLock(turnScrew.transform);
            }
        }
    }

}
