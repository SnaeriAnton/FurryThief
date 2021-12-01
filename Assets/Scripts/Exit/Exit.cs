using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

[RequireComponent(typeof(GetInformationPlayer))]
public class Exit : MonoBehaviour
{
    [SerializeField] private GetInformationPlayer _getInformationPlayer;

    private bool _player = false;
    private bool _inHouse = false;
    private RaccoonExit _raccoonExit;

    private void Start()
    {
        _inHouse = TryGetComponent<HouseLoad>(out HouseLoad houseLoad);
    }

    public void LogOff(bool player)
    {
        if (player == true)
        {
            ShopLevel.Load(_getInformationPlayer);
        }
    }

    private void GetOut()
    {
        if (_player == true)
        {
            if (_inHouse == true)
            {
                ShopLevel.Load(_getInformationPlayer);
            }
            else
            {
                HouseLevel.Load(_getInformationPlayer);
            }
        }
        _raccoonExit.CameOut -= GetOut;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<RaccoonExit>(out RaccoonExit raccoonExit))
        {
            _player = true;
            _raccoonExit = raccoonExit;
            _raccoonExit.CameOut += GetOut;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _player = false;
        _raccoonExit = null;
    }
}
