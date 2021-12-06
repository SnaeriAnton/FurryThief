using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CircleCollider2D))]
public class Sensor : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private GameObject _sensor;
    [SerializeField] private CircleCollider2D _circleCollider2D;
    [SerializeField] private int _distance;
    [SerializeField] private int _direction;
    [SerializeField] private Dog _mover;
    [SerializeField] private AudioSource _audioSource;

    private bool _alarm = false;

    private  void WorkAlarm()
    {
        _alarm = true;
        _mover.SetPosition(new Vector2(_transform.position.x + (5 * _distance), _transform.position.y + 0.3f), _direction);
    }

    public void Disable()
    {
        _sensor.SetActive(false);
        _circleCollider2D.enabled = false;
        _audioSource.enabled = false;
    }

    public void Enabke()
    {
        _circleCollider2D.enabled = true;
        _audioSource.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Raccoon>( out Raccoon raccoon))
        {
            if (_alarm == false)
            {
                WorkAlarm();
            }
        }

        if (collision.TryGetComponent<DogVision>(out DogVision dogVision))
        {
            _sensor.SetActive(false);
        }
    }
}
