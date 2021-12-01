using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RaccoonInformation : MonoBehaviour
{
    [SerializeField] private Raccoon _raccon;
    [SerializeField] private RaccoonBag _bag;
    [SerializeField] private TMP_Text _raccoonLableScore;
    [SerializeField] private TMP_Text _itemsInBagLable;
    [SerializeField] private TMP_Text _bagCopacityLable;

    private void OnEnable()
    {
        _raccon.ScoreChanged += ShowScor;
        _bag.BagChanged += ShowBag;
    }

    private void OnDisable()
    {
        _raccon.ScoreChanged -= ShowScor;
        _bag.BagChanged -= ShowBag;
    }

    private void ShowBag(int countItems, int bagCipacity)
    {
        _itemsInBagLable.text = countItems.ToString();
        _bagCopacityLable.text = bagCipacity.ToString();
    }

    private void ShowScor(int score)
    {
        _raccoonLableScore.text = score.ToString();
    }
}
