using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider2D))]
public class ItemView : MonoBehaviour
{
    [SerializeField] protected Item _item;
    [SerializeField] protected SpriteRenderer _spriteRenderer;
    [SerializeField] protected TMP_Text _templateLable;
    [SerializeField] protected GameObject _textContainer;
    [SerializeField] protected BoxCollider2D _boxCollider2D;

    protected TMP_Text _lable;

    public Item Item => _item;

    public event UnityAction Stolen;

    private void Start()
    {
        _spriteRenderer.sprite = _item.Icon;
        _lable = Instantiate(_templateLable, _textContainer.transform);
        _lable.enabled = false;
        _lable.text = _item.Name;
        _boxCollider2D.size = _spriteRenderer.size;
    }

    private void Update()
    {
        _lable.transform.position = Camera.main.WorldToScreenPoint(new Vector3(transform.position.x, transform.position.y + 0.55f, transform.position.z));
    }

    public void Destroy()
    {
        Steal();
        Stolen?.Invoke();
        Destroy(this.gameObject);
    }

    public void EnableBoxCollider()
    {
        _boxCollider2D.enabled = true;
    }

    private void Steal()
    {
        _item.Steal();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Raccoon>(out Raccoon raccoon) || collision.TryGetComponent<Hook>(out Hook hook))
        {
            _lable.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _lable.enabled = false;
    }
}
