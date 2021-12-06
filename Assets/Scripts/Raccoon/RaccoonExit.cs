using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Transform))]
public class RaccoonExit : MonoBehaviour
{
    [SerializeField] private Transform _transfor;

    private bool _exit = false;
    private bool _backdoor = false;
    private Vector2 _positionExit;

    public event UnityAction CameOut;

    public void Exit()
    {
        if (_exit)
        {
            CameOut?.Invoke();
        }
        else if (_backdoor)
        {
            _transfor.position = _positionExit;
        }        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Exit>())
        {
            _exit = true;
        }

        if (collision.TryGetComponent<Backdoor>(out Backdoor backdoor))
        {
            _backdoor = true;
            _positionExit = backdoor.GetPosition();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _exit = false;
        _backdoor = false;
    }
}
