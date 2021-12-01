using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class TurnScrewMover : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private Lock _lock;

    private int _direction = 1;
    private int _speed = 2;
    private bool _lockBeginning = false;
    private bool _lockEnd = false;
    private Kernel _kernel;
    private InputSistem _input;

    private void Awake()
    {
        _lock.Closed += DisableMove;
        _input = new InputSistem();
        _input.Enable();

        _input.TurnSrew.MoveLeft.performed += ctx => OnMoveLeft();
        _input.TurnSrew.MoveRight.performed += ctx => OnMoveRight();
        _input.TurnSrew.Breaking.performed += ctx => OnBreafingLock();
    }

    private void Update()
    {
        if (_lockEnd == true || _lockBeginning == true)
        {
            _speed = 0;
        }
        Move(_direction, _speed);
    }

    private void OnDisable()
    {
        _lock.Closed -= DisableMove;
    }

    private void DisableMove()
    {
        _input.Disable();
    }

    private void OnMoveRight()
    {
        _lockBeginning = false;
        _direction = 1;
        _speed = 4;
    }

    private void OnMoveLeft()
    {
        _lockEnd = false;
        _direction = -1;
        _speed = 4;
    }

    private void OnBreafingLock()
    {
        if (_kernel != null && _kernel.Unblock == false)
        {
            _kernel.OpenKernel();
        }
    }

    private void Move(int direction, int speed)
    {
        _transform.position += new Vector3(speed * direction * Time.deltaTime, 0);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Kernel>(out Kernel kernel))
        {
            _speed = 0;
            _kernel = kernel;
        }

        if (collision.GetComponent<LockBeginning>())
        {
            _lockBeginning = true;
            _kernel = null;
        }

        if (collision.GetComponent<LockEnd>())
        {
            _lockEnd = true;
            _kernel = null;
        }
    }
}
