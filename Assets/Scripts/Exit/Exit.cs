using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

[RequireComponent(typeof(InformationPlayer))]
public class Exit : MonoBehaviour
{
    [SerializeField] private InformationPlayer _informationPlayer;

    private bool _player = false;
    private bool _inHouse = false;
    private RaccoonExit _raccoonExit;

    private void Start()
    {
        _inHouse = TryGetComponent<HouseLoad>(out HouseLoad houseLoad);
    }

    private void GetOut()
    {
        if (_player == true)
        {
            if (_inHouse == true)
            {
                ShopLevel.Load(_informationPlayer);
            }
            else
            {
                HouseLevel.Load(_informationPlayer);
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
