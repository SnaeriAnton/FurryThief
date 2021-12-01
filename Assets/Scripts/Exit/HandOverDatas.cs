using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

[RequireComponent(typeof(DataManeger))]
public class HandOverDatas : MonoBehaviour, ISceneLoadHandler<GetInformationPlayer>
{
    [SerializeField] private DataManeger _dataManager;

    public void OnSceneLoaded(GetInformationPlayer argument)
    {
        _dataManager.HandOverDatas(argument);
    }
}
