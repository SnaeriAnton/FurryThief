using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockGenerateKernelsCod : MonoBehaviour
{
    private int[] _items = new int[3];
    private bool _notNumber = false;

    public int[] GenerateCod()
    {
        Filling();
        for (int i = 0; i < _items.Length; i++)
        {
            int rand = Random.Range(0, 3);
            for (int j = 0; j < _items.Length; j++)
            {
                if (_items[j] == rand)
                {
                    i--;
                    break;
                }
                _notNumber = true;
            }
            if (_notNumber == true)
            {
                _items[i] = rand;
                _notNumber = false;
            }
        }
        return _items;
    }

    private void Filling()
    {
        for (int i = 0; i < _items.Length; i++)
        {
            _items[i] = 0;
        }
    }
}
