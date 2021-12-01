using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class FireSound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Raccoon>())
        {
            _audioSource.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _audioSource.enabled = false;
    }
}
