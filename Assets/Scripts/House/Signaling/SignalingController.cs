using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(AudioSource))]
public class SignalingController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Sprite _spritePanelControl;
    [SerializeField] private ItemsManager _itemsManager;
    [SerializeField] private AudioSource _audioSource;

    private Sensor[] _sensors;

    private void OnEnable()
    {
        _itemsManager.SignalingTurnOn += Enable;
    }

    private void OnDisable()
    {
        _itemsManager.SignalingTurnOn -= Enable;
    }

    private void Enable()
    {
        _sensors = GetComponentsInChildren<Sensor>();
        foreach (var sensor in _sensors)
        {
            sensor.Enable();
        }
    }

    public void Disable()
    {
        _spriteRenderer.sprite = _spritePanelControl;
        _audioSource.enabled = true;
        foreach (var sebsor in _sensors)
        {
            sebsor.Disable();
        }
    }
}
