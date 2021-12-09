using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tool", menuName = "Item/Tool", order = 51)]
public class Tool : Item
{
    [SerializeField] private bool _bag;
    [SerializeField] private bool _bought;
    [SerializeField] private GameObject _toolObject;

    private int _defaultPrica = 100;

    public bool Bag => _bag;
    public bool Bought => _bought;
    public GameObject ToolObject => _toolObject;

    public void IncaraisePrice()
    {
        _prica *= 3;
    }

    public void Buy()
    {
        _bought = true;
    }

    public override void RestoreStatus()
    {
        base.RestoreStatus();
        _bought = false;
        if (_bag == true)
        {
            _prica = _defaultPrica;
        }
    }
}
