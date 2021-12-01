using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(GrandfatherSeekrRaccoon))]
[RequireComponent(typeof(Mover))]
public class Grandfather : MonoBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private GrandfatherSeekrRaccoon _enemySeekerPlayer;
    [SerializeField] private Mover _mover;

    private int _target = 1;
    private bool _followPlayerl = false;

    public Vector2 Direction { get; private set; }
    public int Taraget => _target;

    private void OnEnable()
    {
        _enemySeekerPlayer.OnSeekPlayer += MoveToPlayer;
        _enemySeekerPlayer.OnLosesPlayer += LosesPlayer;
    }

    private void OnDisable()
    {
        _enemySeekerPlayer.OnSeekPlayer -= MoveToPlayer;
        _enemySeekerPlayer.OnLosesPlayer -= LosesPlayer;
    }

    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(_target, 0);
        _mover.Move(direction, _speed);
    }

    private int RandomDirection()
    {
        int direction = Random.Range(-1, 2);
        while (direction == 0)
        {
            direction = Random.Range(-1, 2);
        }
        return direction;
    }

    private int RandomDirectionStairs()
    {
        int direction = Random.Range(-1, 2);
        return direction;
    }

    private void MoveToPlayer()
    {
        _speed = 3;
        _followPlayerl = true;
    }

    private void LosesPlayer(int direction)
    {
        _followPlayerl = false;
        _target = direction * -1;
        _speed = 2;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_followPlayerl == false)
        {
            if (collision.GetComponent<RightPoint>())
            {
                _target = -1;
            }

            if (collision.GetComponent<LeftPoint>())
            {
                _target = 1;
            }

            if (collision.GetComponent<Point>())
            {
                _target = RandomDirection();
            }

            if (collision.GetComponent<LadderMovePoint>())
            {
                Direction = new Vector2(0, RandomDirectionStairs());
            }

            if (collision.GetComponent<LadderPoint>())
            {
                Direction = new Vector2(0, 0);
            }
        }
    }
}