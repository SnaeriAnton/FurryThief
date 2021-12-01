using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))] 
[RequireComponent(typeof(CapsuleCollider2D))] 
[RequireComponent(typeof(Rigidbody2D))] 
public class RaccoonHide : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private CapsuleCollider2D _capsuleCollider2D;
    [SerializeField] private GameObject _handRaccoon;
    [SerializeField] private GameObject _legsRaccoon;
    [SerializeField] private Rigidbody2D _rigidbody2D;

    private bool _raccoonToHidden = false;
    private Hiding _hiding;

    public void Hide()
    {
        if (_hiding != null)
        {
            if (_raccoonToHidden == true)
            {
                _raccoonToHidden = false;
                _hiding.HideRaccoon(false);
                ChangesStateComponents(true);
            }
            else
            {
                _raccoonToHidden = true;
                _hiding.HideRaccoon(true);
                ChangesStateComponents(false);
            }
        }
    }

    private void ChangesStateComponents(bool hidden)
    {
        _spriteRenderer.enabled = hidden;
        _capsuleCollider2D.enabled = hidden;
        _rigidbody2D.simulated = hidden;
        _legsRaccoon.SetActive(hidden);
        _handRaccoon.SetActive(hidden);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Hiding>(out Hiding hiding))
        {
            _hiding = hiding;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (_raccoonToHidden == false)
        {
            _hiding = null;
        }
    }
}
