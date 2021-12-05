using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigurationLevel : MonoBehaviour
{
    private bool _raccoonPlays;

    public bool RaccoonPlays => _raccoonPlays;

    public void HandOver(bool raccoonPlays)
    {
        _raccoonPlays = raccoonPlays;
    }

    public void ResetConfiguration()
    {
        _raccoonPlays = false;
    }

    public void SetPlayer()
    {
        _raccoonPlays = true;
    }
}
