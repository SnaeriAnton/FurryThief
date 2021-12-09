using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigurationLevel : MonoBehaviour
{
    [SerializeField] private PlaceOfAppearance _placeOfAppearance;
    [SerializeField] private ItemsResetter _itemReset;

    private bool _raccoonPlays;
    private Raccoon _raccoon;
    private RaccoonPocket _pocket;
    private RaccoonBag _bag;

    public bool RaccoonPlays => _raccoonPlays;

    public void OnEnable()
    {
        _raccoon = FindObjectOfType<Raccoon>();
        _pocket = FindObjectOfType<RaccoonPocket>();
        _bag = FindObjectOfType<RaccoonBag>();
        _raccoon.transform.position = _placeOfAppearance.transform.position;
        if (_raccoonPlays == true)
        {
            _pocket.AddToolInOtherContainer();
        }
    }

    public void ResetGameSattings()
    {
        if (_itemReset != null)
        {
            _itemReset.ResetItems();
        }
        _raccoonPlays = false;
    }

    public void RestartGame()
    {
        Destroy(_raccoon.gameObject);
    }

    public void HandOver(bool raccoonPlays)
    {
        _raccoonPlays = raccoonPlays;
    }

    public void SetPlayer()
    {
        _raccoonPlays = true;
    }
}
