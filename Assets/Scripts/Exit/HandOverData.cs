using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

[RequireComponent(typeof(DataManeger))]
public class HandOverData : MonoBehaviour, ISceneLoadHandler<InformationPlayer>
{
    [SerializeField] private DataManeger _dataManager;

    public void OnSceneLoaded(InformationPlayer argument)
    {
        _dataManager.HandOverData(argument);
    }
}
