using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : ScriptableObject
{
    [SerializeField] protected string _name;
    [SerializeField] protected int _prica;
    [SerializeField] protected Sprite _icon;
    [SerializeField] protected bool _stolen;

    public string Name => _name;
    public int Pricae => _prica;
    public Sprite Icon => _icon;
    public bool Stolen => _stolen;
    

    public void Steal()
    {
        _stolen = true;
    }

    public virtual void RestoreStatus()
    {
        _stolen = false;
    }
}
