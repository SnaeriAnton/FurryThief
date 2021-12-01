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
        _itemsManager.SignalingTurnOn += EnableSignaling;
    }

    private void OnDisable()
    {
        _itemsManager.SignalingTurnOn -= EnableSignaling;
    }

    private void EnableSignaling()
    {
        _sensors = GetComponentsInChildren<Sensor>();
        foreach (var sebsor in _sensors)
        {
            sebsor.EnabkeSensor();
        }
    }

    public void DisableSignaling()
    {
        _spriteRenderer.sprite = _spritePanelControl;
        _audioSource.enabled = true;
        foreach (var sebsor in _sensors)
        {
            sebsor.DisableSensor();
        }
    }
}
