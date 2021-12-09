using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RaccoonInformation : MonoBehaviour
{
    [SerializeField] private TMP_Text _raccoonLableScore;
    [SerializeField] private TMP_Text _itemsInBagLable;
    [SerializeField] private TMP_Text _bagCopacityLable;


    private Raccoon _raccon;
    private RaccoonBag _bag;

    private void OnEnable()
    {
        _raccon = FindObjectOfType<Raccoon>(); 
        _bag = FindObjectOfType<RaccoonBag>();  
        _raccon.ScoreChanged += ShowScor;
        _bag.BagChanged += ShowBag;
        _bag.UpdateStatistic();
        _raccon.UpdateStatistic();
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
