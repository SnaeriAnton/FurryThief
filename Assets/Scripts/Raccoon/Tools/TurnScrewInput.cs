//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//[RequireComponent(typeof(TurnScrewMover))]
//public class TurnScrewInput : MonoBehaviour
//{
//    [SerializeField] private TurnScrewMover _turnScrewMoveer;

//    private InputSistem _input;

//    private void Awake()
//    {
//        _input = new InputSistem();
        

//        _input.TurnSrew.MoveLeft.performed += ctx => OnMoveLeft();
//        _input.TurnSrew.MoveRight.performed += ctx => OnMoveRight();
//        _input.TurnSrew.Breaking.performed += ctx => OnBreafingLock();
//    }

//    private void Update()
//    {
//        _input.Enable();
//    }
//    private void OnDisable()
//    {
//        _input.Disable();
//    }

//    private void OnBreafingLock()
//    {
//        _turnScrewMoveer.MoveLeft();
//    }

//    private void OnMoveRight()
//    {
//        _turnScrewMoveer.MoveRight();
//    }

//    private void OnMoveLeft()
//    {
//        _turnScrewMoveer.BreafingLock();
//    }

//}
