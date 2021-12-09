using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class Exit : MonoBehaviour
{
    [SerializeField] private ConfigurationLevel _configurationLevel;

    private bool _playerAtExit = false;
    private bool _inHouse = false;
    private RaccoonExit _raccoonExit;

    private void Start()
    {
        _inHouse = TryGetComponent<HouseLoad>(out HouseLoad houseLoad);
    }

    private void GetOut()
    {
        if (_playerAtExit == true)
        {
            if (_inHouse == true)
            {
                ShopLevel.Load(_configurationLevel.RaccoonPlays);
            }
            else
            {
                HouseLevel.Load(_configurationLevel.RaccoonPlays);
            }
        }
        _raccoonExit.CameOut -= GetOut;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<RaccoonExit>(out RaccoonExit raccoonExit))
        {
            _playerAtExit = true;
            _raccoonExit = raccoonExit;
            _raccoonExit.CameOut += GetOut;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _playerAtExit = false;
        _raccoonExit = null;
    }
}
