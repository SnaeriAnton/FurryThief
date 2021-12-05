using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Mover))]
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(DogVision))]
public class Dog : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _transform;
    [SerializeField] private Mover _mover;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private DogVision _dogVision;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private Animator _animator;

    private int _target = 1;

    public Vector2 Direction { get; private set; }
    public int Taraget => _target;

    private void OnEnable()
    {
        _dogVision.SearchTerminated += Disable;
    }

    private void OnDisable()
    {
        _dogVision.SearchTerminated -= Disable;
    }

    private void Start()
    {
        Direction = new Vector2(0, 0);
    }

    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(_target, 0);
        _mover.Move(direction, _speed);
    }

    public void SetPosition(Vector2 position, int target)
    {
        this.enabled = true;
        _transform.position = position;
        _target = target;
        Enable();
    }

    private void Enable()
    {
        _audioSource.enabled = true;
        _dogVision.enabled = true;
        _rigidbody2D.simulated = true;
        _animator.enabled = true;
    }

    private void Disable()
    {
        _audioSource.enabled = false;
        _dogVision.enabled = false;
        _rigidbody2D.simulated = false;
        _animator.enabled = false;
    }
}

