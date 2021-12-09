using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracker : MonoBehaviour
{
    private Raccoon _raccoon;
    private float _ofset = 1.5f;

    private void Start()
    {
        _raccoon = FindObjectOfType<Raccoon>();
    }

    private void Update()
    {
        transform.position = new Vector3(_raccoon.transform.position.x, _raccoon.transform.position.y + _ofset, transform.position.z);
    }
}
