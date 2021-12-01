using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ToolViewInShop : MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private TMP_Text _price;
    [SerializeField] private Image _imageFarm;
    [SerializeField] private Sprite _defaultSpriteFram;
    [SerializeField] private Sprite _spriteChoiseFram;

    public void Renderer(Item item)
    {
        _icon.sprite = item.Icon;
        _price.text = item.Pricae.ToString();
    }

    public void ChangePriceShow(Item item)
    {
        _price.text = item.Pricae.ToString();
    }

    public void SelectTool()
    {
        _imageFarm.sprite = _spriteChoiseFram;
    }

    public void ChangeSelectedTool()
    {
        _imageFarm.sprite = _defaultSpriteFram;
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
