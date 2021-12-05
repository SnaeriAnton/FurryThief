using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(RaccoonPocket))]
[RequireComponent(typeof(RaccoonBag))]
[RequireComponent(typeof(Mover))]
[RequireComponent(typeof(RaccoonSale))]
public class Raccoon : MonoBehaviour
{
    [SerializeField] private RaccoonPocket _pocket;
    [SerializeField] private RaccoonBag _bag;
    [SerializeField] private GameObject _hand;
    [SerializeField] private Mover _mover;
    [SerializeField] private RaccoonSale _sale;
    [SerializeField] private float _speed;

    private int _score = 0;
    private bool _seenItem = false;
    private ItemView _itemView;

    public GameObject Hand => _hand;
    public int Score => _score;
    public float Speed => _speed;

    public event UnityAction Caught;
    public event UnityAction<int> ScoreChanged;

    private void Start()
    {
        ScoreChanged?.Invoke(_score);
    }

    public void HandOverScore(int score)
    {
        _score = score;
    }

    public void AddMoney(int score)
    {
        _score += score;
        ScoreChanged?.Invoke(_score);
    }

    public bool BuyItem(Tool tool)
    {
        bool itemBought = false;
        if (tool.Pricae <= _score)
        {
            itemBought = true;
            _score -= tool.Pricae;
            ScoreChanged?.Invoke(_score);
            if (tool.Bag != true)
            {
                _pocket.AddTool(tool);
            }
            else
            {
                _bag.IncreaseBagSize();
            }
        }
        return itemBought;
    }

    public void StealItem()
    {
        if (_seenItem == true)
        {
            Tool tool = _itemView.Item as Tool; 
            if (tool as Tool)
            {
                _itemView.Destroy();
                _pocket.AddTool(tool);
            }
            else
            {
                Subject subject = _itemView.Item as Subject;
                bool added = _bag.AddSubject(subject);
                if (added == true)
                {
                    _itemView.Destroy();
                }
            }
        }
    }

    public void Sell()
    {
        _sale.Sell();
    }

    private void DiePlayer()
    {
        _mover.enabled = false;
        Caught?.Invoke();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            DiePlayer();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.TryGetComponent<ItemView>(out ItemView itemView))
        {
            _seenItem = true;
            _itemView = itemView;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _itemView = null;
        _seenItem = false;
    }
}
