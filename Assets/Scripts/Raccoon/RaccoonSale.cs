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
            _bag.SaleSubjects();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Shop>(out Shop shop))
        {
            _inShop = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _inShop = false;
    }
}
