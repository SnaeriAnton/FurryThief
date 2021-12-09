using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(AudioSource))]
public class Kernel : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Color _enable;
    [SerializeField] private Color _disable;
    [SerializeField] private Color _selected;
    [SerializeField] private Color _default;
    [SerializeField] private SpriteRenderer _spriteRendereChoiñe;
    [SerializeField] private AudioSource _audioSource;

    private bool _unblock = false;

    public event UnityAction Unlocked;

    public bool Unblock => _unblock;

    public void Open()
    {
        _unblock = true;
        _spriteRenderer.color = _enable;
        _audioSource.enabled = true;
        Unlocked?.Invoke();
    }

    public void Bloc()
    {
        _unblock = false;
        _spriteRenderer.color = _disable;
        _audioSource.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<TurnScrewMover>(out TurnScrewMover turnScrewMover))
        {
            _spriteRendereChoiñe.color = _selected;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _spriteRendereChoiñe.color = _default;
    }
}
