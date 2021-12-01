using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiding : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteREndererWithRaccoonEye;

    public void HideRaccoon(bool hidded)
    {
        if (hidded == false)
        {
            _spriteREndererWithRaccoonEye.enabled = false;
        }
        else
        {
            _spriteREndererWithRaccoonEye.enabled = true;
        }
    }
}
