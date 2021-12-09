using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerticalScrollbar : MonoBehaviour
{
    [SerializeField] private Scrollbar _scrollbar;

    public Scrollbar GetScrollbar()
    {
        return _scrollbar;
    }
}
