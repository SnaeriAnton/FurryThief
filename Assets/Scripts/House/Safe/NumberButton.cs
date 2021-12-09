using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class NumberButton : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private int _nameNumber;
    [SerializeField] private Color _enable;
    [SerializeField] private Color _disable;

    private bool _numberEnable = false;

    public event UnityAction<string> Pushed;

    public bool NumberEnable => _numberEnable;

    public void PushButton()
    {
        _spriteRenderer.color = _enable;
        _numberEnable = true;
        Pushed?.Invoke(_nameNumber.ToString());
    }

    public void ThrowOffPushedButtons()
    {
        _spriteRenderer.color = _disable;
        _numberEnable = false;
    }
}
