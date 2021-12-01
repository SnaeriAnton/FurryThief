using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider2D))]
public class AidKit : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Sprite _spriteOpen;
    [SerializeField] private BoxCollider2D _boxCollider2D;

    private ItemView[] _items;

    private void Start()
    {
        _items = GetComponentsInChildren<ItemView>();
    }

    public void OpenAidKit()
    {
        _spriteRenderer.sprite = _spriteOpen;
        _spriteRenderer.sortingOrder = 1;
        _boxCollider2D.enabled = false;
        for (int i = 0; i < _items.Length; i++)
        {
            _items[i].EnableBoxCollider();
        }
    }
}
