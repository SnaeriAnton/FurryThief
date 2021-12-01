using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracker : MonoBehaviour
{
    [SerializeField] private Raccoon _raccoon;

    private void Update()
    {
        transform.position = new Vector3(_raccoon.transform.position.x, _raccoon.transform.position.y + 1.5f, transform.position.z);
    }
}
