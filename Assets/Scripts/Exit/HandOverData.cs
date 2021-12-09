using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class HandOverData : MonoBehaviour, ISceneLoadHandler<bool>
{
    [SerializeField] private ConfigurationLevel _configurationLevel;

    public void OnSceneLoaded(bool argument)
    {
        Debug.Log(argument);
        _configurationLevel.HandOver(argument);
    }
}
