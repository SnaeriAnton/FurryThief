using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageGates : MonoBehaviour
{
    [SerializeField] private Transform _transform;

    private bool _isKey = false;

    private void Update()
    {
        if (_isKey == true)
        {
            _transform.rotation = Quaternion.Lerp(_transform.rotation, Quaternion.Euler(0, 0, 90), 1 * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<GarageKey>(out GarageKey garageKey))
        {
            _isKey = true;
        }
    }
}
