using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanel : MonoBehaviour
{
    [SerializeField] private GameObject _itemContant;

    private bool _panelOpened = false;
    private bool _raccoonInShop = false;
    private InputSistem _input;

    public bool RaccoonInShop => _raccoonInShop;
    public bool PanelOpend => _panelOpened;

    private void Awake()
    {
        _input = new InputSistem();
        _input.Enable();

        _input.Shop.Open.performed += ctx => OnOpenPanel();
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    private void OnOpenPanel()
    {
        if (_raccoonInShop)
        {
            Open();
        }
    }

    private void Open()
    {
        if (_panelOpened == false)
        {
            _itemContant.SetActive(true);
            _panelOpened = true;
        }
        else
        {
            _itemContant.SetActive(false);
            _panelOpened = false;
        }
    }

    private void Clos()
    {
        if (_panelOpened)
        {
            Open();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _raccoonInShop = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Raccoon>(out Raccoon raccoon))
        {
            _raccoonInShop = false;
            Clos();

        }
    }
}
