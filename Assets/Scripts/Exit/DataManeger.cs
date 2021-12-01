using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManeger : MonoBehaviour
{
    [SerializeField] private RaccoonBag _bag;
    [SerializeField] private RaccoonPocket _tools;
    [SerializeField] private Raccoon _raccoon;
    [SerializeField] private ConfigurationLevel _configurationLevel;

    public void HandOverDatas(GetInformationPlayer information)
    {
        _raccoon.HandOverScore(information.Score);
        _tools.HandOverTools(information.GetTools());
        _bag.HandOverItems(information.GetItems());
        _bag.HandOverRoomins(information.BagCopacity);
        _configurationLevel.HandOverConfiguration(information.RaccoonPlays);
    }
}
