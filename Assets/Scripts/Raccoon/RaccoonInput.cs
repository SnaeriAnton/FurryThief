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
    [SerializeField] private RaccoonHide _hide;
    [SerializeField] private RaccoonOpener _opener;
    [SerializeField] private RaccoonMoveLadder _moveLadder;
    [SerializeField] private RaccoonEnterDoor _enterDoor;
    [SerializeField] private Raccoon _raccoon;
    [SerializeField] private RaccoonBreakingDoor _breakingDoor;
    [SerializeField] private RaccoonExit _exit;
    [SerializeField] private CuterWires _cuterWires;
    [SerializeField] private RaccoonPocket _pocket;
    [SerializeField] private RaccoonAnimation _animation;

    private InputSistem _input;
    private float _direction;
    private float _directionOnLadder;
    private bool _onLadder = false;
    private bool _stoped = false;


    public float DirectionOnLadder => _directionOnLadder;

    private void Awake()
    {
        _breakingDoor.Break += BreakingDoor;
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
        _breakingDoor.Break -= BreakingDoor;
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
            _animation.RunRaccoon(true);
        }
        else
        {
            _animation.RunRaccoon(false);
        }

        if (_onLadder == true)
        {
            _moveLadder.Move(new Vector2(0, _directionOnLadder));
        }
    }

    private void OnHide()
    {
        _hide.Hide();
    }

    private void OnSwitch()
    {
        _opener.PusheSwitc();
    }

    private void OnClimedLadder()
    {
        _onLadder = _moveLadder.Climb();
    }

    private void OnEnterDoor()
    {
        _enterDoor.Descent();
    }

    private void OnOpen()
    {
        _opener.Open();
    }

    private void OnStealItem()
    {
        _raccoon.StealItem();
    }

    private void OnBreakingDoor()
    {
        _breakingDoor.BreakingLockDoor();
        _stoped = false;
    }

    private void BreakingDoor(bool breaking)
    {
        _stoped = breaking;
    }

    private void OnExit()
    {
        _exit.Exit();
    }

    private void OnSelectUp()
    {
        _pocket.SelectNext();
    }

    private void OnSelectDown()
    {
        _pocket.SelectPrevious();
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
