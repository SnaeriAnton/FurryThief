using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DogVision : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private LayerMask _playerMask;

    private float _distance = 4;
    private float _timeToSleep = 6;
    private float _timer = 0;

    public event UnityAction SearchTerminated;


    private void OnEnable()
    {
        _timer = 0;
    }

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(_transform.position, _transform.right, _distance, _playerMask);

        Debug.DrawRay(_transform.position, _transform.right, Color.red);


        if (hit == false)
        {
            _timer += Time.deltaTime;
            if (_timeToSleep <= _timer)
            {
                Debug.Log(1);
                SearchTerminated?.Invoke();
            }
        }
        else
        {
            _timer = 0;
        }

    }
}
