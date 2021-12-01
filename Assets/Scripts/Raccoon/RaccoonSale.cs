using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RaccoonBag))]
public class RaccoonSale : MonoBehaviour
{
    [SerializeField] private RaccoonBag _bag;

    private bool _inShop = false;

    public void Sell()
    {
        if (_inShop == true)
        {
            _bag.SaleItem();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Shop>())
        {
            _inShop = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _inShop = false;
    }
}
