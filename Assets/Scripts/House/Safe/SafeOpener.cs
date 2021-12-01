using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SafeOpener : MonoBehaviour
{
    private NumberButton[] _numberButtons;
    private string _codSafe = "3740";
    private string _inputCod = "";

    public event UnityAction Opened;

    private void OnDisable()
    {
        foreach (var nunberButton in _numberButtons)
        {
            nunberButton.Pushed -= OnOpenSafe;
        }
    }

    private void Start()
    {
        _numberButtons = GetComponentsInChildren<NumberButton>();
        foreach (var nunberButton in _numberButtons)
        {
            nunberButton.Pushed += OnOpenSafe;
        }
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            int index;
            bool result = int.TryParse(Input.inputString, out index);
            if (result == true)
            {
                _numberButtons[index].PushButton();
            }
        }
    }

    private void OnOpenSafe(string number)
    {
        _inputCod += number;
        CheakCodSafe(_inputCod);
    }

    private void CheakCodSafe(string cod)
    {
        if (cod.Length == _codSafe.Length)
        {
            if (cod == _codSafe)
            {
                Opened?.Invoke();
            }
            else
            {
                foreach (var nunberButton in _numberButtons)
                {
                    nunberButton.ThrowOffPushedButtons();
                }
                _inputCod = "";
            }
        }
    }

    public void OpenPanel()
    {
        gameObject.SetActive(true);
    }

    public void ClodePanel()
    {
        gameObject.SetActive(false);
    }
}
