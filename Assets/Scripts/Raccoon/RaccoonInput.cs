using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Mover))]
[RequireComponent(typeof(RaccoonHide))]
[RequireComponent(typeof(RaccoonOpener))]
[RequireComponent(typeof(RaccoonMoveLadder))]
[RequireComponent(typeof(RaccoonEnterDoor))]
[RequireComponent(typeof(Raccoon))]
[RequireComponent(typeof(RaccoonBreakingDoor))]
[RequireComponent(typeof(RaccoonExit))]
[RequireComponent(typeof(CuterWires))]
[RequireComponent(typeof(RaccoonPocket))]
public class RaccoonInput : MonoBehaviour
{
    [SerializeField] private Mover _mover;
    [SerializeField] private RaccoonHide _raccoonHide;
    [SerializeField] private RaccoonOpener _raccoonOpener;
    [SerializeField] private RaccoonMoveLadder _raccoonMoveLadder;
    [SerializeField] private RaccoonEnterDoor _racoonnEnterDoor;
    [SerializeField] private Raccoon _raccoon;
    [SerializeField] private RaccoonBreakingDoor _raccoonBreakingDoor;
    [SerializeField] private RaccoonExit _raccoonExit;
    [SerializeField] private CuterWires _cuterWires;
    [SerializeField] private RaccoonPocket _raccoonPocket;
    [SerializeField] private RaccoonAnimation _raccoonAnimation;

    private InputSistem _input;
    private float _direction;
    private float _directionOnLadder;
    private bool _onLadder = false;
    private bool _stoped = false;


    public float DirectionOnLadder => _directionOnLadder;

    private void Awake()
    {
        _raccoonBreakingDoor.Break += BreakingDoor;
        _input = new InputSistem();
        _input.Enable();

        _input.Player.Hide.performed += ctx => OnHide();
        _input.Player.Open.performed += ctx => OnSwitch();
        _input.Player.Open.performed += ctx => OnOpen();
        _input.Player.ClimbLadder.performed += ctx => OnClimedLadder();
        _input.Player.Descent.performed += ctx => OnEnterDoor();
        _input.Player.AddItem.performed += ctx => OnStealItem();
        _input.Player.BreakingDoor.performed += ctx => OnBreakingDoor();
        _input.Player.Sell.performed += ctx => OnSale();
        _input.Player.Exit.performed += ctx => OnExit();
        _input.Tool.ChoiñeUp.performed += ctx => OnSelectUp();
        _input.Tool.ChoiñeDown.performed += ctx => OnSelectDown();
        _input.Player.CutWires.performed += ctx => OnCutWires();
    }

    private void OnDisable()
    {
        _input.Disable();
        _raccoonBreakingDoor.Break -= BreakingDoor;
    }

    private void FixedUpdate()
    {
        if (_onLadder == false)
        {
            _direction = _input.Player.Move.ReadValue<float>();
        }

        _directionOnLadder = _input.Player.MoveOnLadder.ReadValue<float>();

        if (_direction != 0 && _stoped == false)
        {
            _mover.Move(new Vector2(_direction, 0), _raccoon.Speed);
            _raccoonAnimation.RunRaccoon(true);
        }
        else
        {
            _raccoonAnimation.RunRaccoon(false);
        }

        if (_onLadder == true)
        {
            _raccoonMoveLadder.Move(new Vector2(0, _directionOnLadder));
        }
    }

    private void OnHide()
    {
        _raccoonHide.Hide();
    }

    private void OnSwitch()
    {
        _raccoonOpener.PusheSwitc();
    }

    private void OnClimedLadder()
    {
        _onLadder = _raccoonMoveLadder.Climb();
    }

    private void OnEnterDoor()
    {
        _racoonnEnterDoor.Descent();
    }

    private void OnOpen()
    {
        _raccoonOpener.Open();
    }

    private void OnStealItem()
    {
        _raccoon.StealItem();
    }

    private void OnBreakingDoor()
    {
        _raccoonBreakingDoor.BreakingLockDoor();
        _stoped = false;
    }

    private void BreakingDoor(bool breaking)
    {
        _stoped = breaking;
    }

    private void OnExit()
    {
        _raccoonExit.Exit();
    }

    private void OnSelectUp()
    {
        _raccoonPocket.SelectNext();
    }

    private void OnSelectDown()
    {
        _raccoonPocket.SelectPrevious();
    }

    private void OnSale()
    {
        _raccoon.Sell();
    }

    private void OnCutWires()
    {
        _cuterWires.CutWires();
    }
}
