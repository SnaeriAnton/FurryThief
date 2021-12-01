using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Transform))]
[RequireComponent(typeof(CircleCollider2D))]
public class Sensor : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private GameObject _sensor;
    [SerializeField] private CircleCollider2D _circleCollider2D;
    [SerializeField] private int _distance;
    [SerializeField] private int _direction;
    [SerializeField] private GameObject _dogObject;
    [SerializeField] private AudioSource _audioSource;

    private Dog _dogMover;
    private DogVision _dog;
    private Rigidbody2D _rigidbody2DDog;

    private bool _alarm = false;

    private void OnEnable()
    {
        _dogMover = _dogObject.GetComponent<Dog>();
        _dog = _dogObject.GetComponent<DogVision>();
        _rigidbody2DDog = _dogObject.GetComponent<Rigidbody2D>();
    }

    private  void WorkAlarm()
    {
        _alarm = true;
        //_dogMover.enabled = true;
        //_dog.enabled = true;
        //_rigidbody2DDog.simulated = true;
        _dogMover.SetPosition(new Vector2(_transform.position.x + (5 * _distance), _transform.position.y), _direction);
        //_audioSource.enabled = true;
    }

    public void DisableSensor()
    {
        _sensor.SetActive(false);
        _circleCollider2D.enabled = false;
    }

    public void EnabkeSensor()
    {
        _circleCollider2D.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Raccoon>())
        {
            if (_alarm == false)
            {
                WorkAlarm();
            }
        }

        if (collision.GetComponent<DogVision>())
        {
            _sensor.SetActive(false);
        }
    }
}
