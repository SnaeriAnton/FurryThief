using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class RaccoonBag : MonoBehaviour
{
    [SerializeField] private Raccoon _raccoon;
    [SerializeField] private List<Subject> _subjects;

    private int _bagCopacity = 3;
    private int _roominess = 3;
    private bool _addedItem;

    public event UnityAction<int, int> BagChanged;

    private void Start()
    {
        BagChanged?.Invoke(_subjects.Count, _bagCopacity);
    }

    public void HandOverSubjects(List<Subject> subjects)
    {
        _subjects = subjects;
    }

    public void HandOverRoomins(int maxItems)
    {
        _bagCopacity = maxItems;
    }

    public List<Subject> GetSubjects()
    {
        return _subjects;
    }

    public int GetMaxSubjects()
    {
        return _bagCopacity;
    }

    public bool AddSubject(Subject subjects)
    {
        if (_subjects.Count < _bagCopacity)
        {
            _subjects.Add(subjects);
            BagChanged?.Invoke(_subjects.Count, _bagCopacity);
            _addedItem = true;
            return _addedItem;
        }
        _addedItem = false;
        return _addedItem;
    }

    public void SaleSubjects()
    {
        for (int i = 0; i < _subjects.Count; i++)
        {
            _raccoon.AddMoney(_subjects[i].Pricae);   
        }
        _subjects.Clear();
        BagChanged?.Invoke(_subjects.Count, _bagCopacity);
    }

    public void IncreaseBagSize()
    {
        _bagCopacity += _roominess;
        BagChanged?.Invoke(_subjects.Count, _bagCopacity);
    }
}
