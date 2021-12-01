using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Transform))]
[RequireComponent(typeof(AudioSource))]
public class DogVision : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private LayerMask _playerMask;
    [SerializeField] private Dog _dog;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private AudioSource _audioSource;

    private float _distance = 4;
    private float _timeToSleep = 6;
    private float _timer = 0;


    private void OnEnable()
    {
        _timer = 0;
    }

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(_transform.position, _transform.right, _distance, _playerMask);

        Debug.DrawRay(_transform.position, _transform.right, Color.red);


        if (hit == false)
        {
            _timer += Time.deltaTime;
            if (_timeToSleep <= _timer)
            {
                _dog.DisableDog();
                //this.enabled = false;
                //_rigidbody2D.simulated = false;
                //_audioSource.enabled = false;
            }
        }
        else
        {
            _timer = 0;
        }

    }
}
