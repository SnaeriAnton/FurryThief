using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider2D))]
public class Safe : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Sprite _spriteOpen;
    [SerializeField] private BoxCollider2D _boxCollider2D;
    [SerializeField] private SafeOpener _safeOpener;

    private ItemView[] _items;
    private void OnEnable()
    {
        _safeOpener.Opened += OpenSafe;
    }

    private void OnDisable()
    {
        _safeOpener.Opened -= OpenSafe;
    }

    private void Start()
    {
        _items = GetComponentsInChildren<ItemView>();
    }

    public void OpenInputPanel()
    {
        _safeOpener.OpenPanel();
    }

    public void CloseInputPanel()
    {
        _safeOpener.ClodePanel();
    }

    public void OpenSafe()
    {
        _spriteRenderer.sprite = _spriteOpen;
        _spriteRenderer.sortingOrder = 1;
        _boxCollider2D.enabled = false;
        for (int i = 0; i < _items.Length; i++)
        {
            _items[i].EnableBoxCollider();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        CloseInputPanel();
    }
}
