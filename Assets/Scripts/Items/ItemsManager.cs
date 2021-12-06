using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemsManager : MonoBehaviour
{
    private ItemView[] _items;
    private int _countItems;
    private int _countStolenItems;

    public event UnityAction SignalingTurnOn;
    public event UnityAction Won;

    private void OnDisable()
    {
        foreach (var item in _items)
        {
            item.Stolen -= CheakStolenItems;
        }
    }

    public void Start()
    {
        _items = GetComponentsInChildren<ItemView>();
        
        _countItems = _items.Length;
        foreach (var item in _items)
        {
            item.Stolen += CheakStolenItems;
            if (item.Item.Stolen == true)
            {
                Destroy(item.gameObject);
                _countStolenItems++;
            }
        }
        CheakNumberStolenItems(_countItems, _countStolenItems);
    }

    private void CheakNumberStolenItems(int countItems, int countStoleItems)
    {
        int halfItems = countItems / 2;
        if (halfItems < countStoleItems)
        {
            SignalingTurnOn?.Invoke();
        }
    }

    private void CheakStolenItems()
    {
        int countStoleItem = 0;
        for (int i = 0; i < _items.Length; i++)
        {
            if (_items[i].Item.Stolen == true)
            {
                countStoleItem += 1;
            }
        }
        if (countStoleItem == _countItems)
        {
            Won?.Invoke();
        }
    }
}
