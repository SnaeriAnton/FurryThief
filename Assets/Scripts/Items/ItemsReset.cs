using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsReset : MonoBehaviour
{
    [SerializeField] private Tool[] _tools;
    private Item[] _items;

    public void ResetItems()
    {
        GetItems();
        foreach (var item in _items)
        {
            item.RestoraionStatus();
            
        }

        foreach (var tool in _tools)
        {
            tool.RestoraionStatus();
            if (tool.Bag == true)
            {
                tool.RestoraionStatus();
            }
        }
    }

    private void GetItems()
    {
        ItemView[] items = GetComponentsInChildren<ItemView>();
        _items = new Item[items.Length];

        for (int i = 0; i < items.Length; i++)
        {
            _items[i] = items[i].Item;
        }
    }
}
