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
            item.Stolen -= Win;
        }
    }

    public void Start()
    {
        _items = GetComponentsInChildren<ItemView>();
        
        _countItems = _items.Length;
        foreach (var item in _items)
        {
            item.Stolen += Win;
            if (item.Item.Stolen == true)
            {
                Destroy(item.gameObject);
                _countStolenItems++;
            }
        }

        TurnOnSignaling(_countItems, _countStolenItems);
    }

    private void Win()
    {
        bool isWin = CheakStolenItems();
        if (isWin)
        {
            Won?.Invoke();
        }
    }

    private void TurnOnSignaling(int countItems, int countStoleItems)
    {
        bool noticeTheftOfSubject = CheakNumberStolenItems(countItems, countStoleItems);
        if (noticeTheftOfSubject)
        {
            SignalingTurnOn?.Invoke();
        }
    }

    private bool CheakNumberStolenItems(int countItems, int countStoleItems)
    {
        int halfItems = countItems / 2;
        if (halfItems < countStoleItems)
        {
            return true;
        }
        return false;
    }

    private bool CheakStolenItems()
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
            return true;
        }
        return false;
    }
}
