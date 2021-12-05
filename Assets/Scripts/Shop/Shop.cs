using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private List<Tool> _tools;
    [SerializeField] private ToolViewInShop _template;
    [SerializeField] private GameObject _toolContainer;
    [SerializeField] private Raccoon _raccoon;
    [SerializeField] private ShowPanel _panel;

    private List<ToolViewInShop> _toolsInShop = new List<ToolViewInShop>();
    private int _toolNumber = 0;
    private int _toolsCount;
    private InputSistem _input;
    private int _nextTool = -1;
    private int _previousTool = 1;

    delegate bool Sale(Tool tool);
    private Sale _sale;

    private void Start()
    {
        _input = new InputSistem();
        _input.Enable();

        _input.Shop.SelectRight.performed += ctx => OnSelectPrevious();
        _input.Shop.SelectLeft.performed += ctx => OnSelectNext();
        _input.Shop.Sell.performed += ctx => OnSell();
        AddToolInContainer();
        _sale = _raccoon.BuyItem;
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    public void RemoveTool(int number)
    {
        _toolsInShop[number].Destroy();
        _tools.RemoveAt(number);
        _toolsInShop.RemoveAt(number);
        _toolNumber = 0;
        GetToolsOfContainer(_toolNumber);
    }

    private void AddToolInContainer()
    {
        for (int i = 0; i < _tools.Count; i++)
        {
            if (_tools[i].Bought == false)
            {
                AddTool(_tools[i]);
            }
        }
        GetToolsOfContainer(_toolNumber);
    }

    private void GetToolsOfContainer(int number)
    {
        if (_toolsInShop.Count > 0)
        {
            _toolsInShop[number].SelectTool();
        }
        _toolsCount = _toolsInShop.Count - 1;
    }

    private void OnSelectNext()
    {
        Select(_nextTool);
    }

    private void OnSelectPrevious()
    {
        Select(_previousTool);
    }

    private void Select(int offset)
    {
        if (_tools.Count > 1)
        {
            _toolsInShop[_toolNumber].ChangeSelectedTool();
            _toolNumber += (1 * offset);
            if (_toolsCount < _toolNumber)
            {
                _toolNumber = 0;
            }
            if (0 > _toolNumber)
            {
                _toolNumber = _toolsCount;
            }
            _toolsInShop[_toolNumber].SelectTool();
        }
    }

    private void AddTool(Tool tool)
    {
        ToolViewInShop view = Instantiate(_template, _toolContainer.transform);
        view.Renderer(tool);

        _toolsInShop.Add(view);
    }

    private void OnSell()
    {
        SellTool(_toolNumber);
    }

    private void SellTool(int number)
    {
        TrySellItem(number);
    }

    private void TrySellItem(int number)
    {
        if (_panel.RaccoonInShop == true && _panel.PanelOpend == true)
        {
            if (_sale(_tools[number]))
            {
                if (_tools[number].Bag == true)
                {
                    _tools[number].IncaraisePrice();
                    _toolsInShop[number].ChangePriceShow(_tools[number]);
                }
                else
                {
                    _tools[number].Buy();
                    RemoveTool(number);
                }
            }
        }
    }
}
