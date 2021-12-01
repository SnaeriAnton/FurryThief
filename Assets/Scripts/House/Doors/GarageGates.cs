using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class GarageGates : MonoBehaviour
{
    [SerializeField] private Transform _transform;

    private bool _key = false;


    private void Update()
    {
        if (_key == true)
        {
            _transform.rotation = Quaternion.Lerp(_transform.rotation, Quaternion.Euler(0, 0, 90), 1 * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<GarageKey>())
        {
            _key = true;
        }
    }
}
