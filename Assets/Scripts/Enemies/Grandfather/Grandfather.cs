using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(GrandfatherVision))]
[RequireComponent(typeof(Mover))]
public class Grandfather : MonoBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private GrandfatherVision _enemySeekerPlayer;
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

    private int RandomDirection(int currentDirection)
    {
        int direction = Random.Range(-1, 2);
        direction = Random.Range(-1, 2);
        if (direction == 0)
        {
            direction = currentDirection;
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
            if (collision.TryGetComponent<RightPoint>(out RightPoint rightPoint))
            {
                _target = -1;
            }

            if (collision.TryGetComponent<LeftPoint>(out LeftPoint leftPoint))
            {
                _target = 1;
            }

            if (collision.TryGetComponent<Point>(out Point point))
            {
                _target = RandomDirection(_target);
            }

            if (collision.TryGetComponent<LadderMovePoint>(out LadderMovePoint ladderMovePoint))
            {
                Direction = new Vector2(0, RandomDirectionStairs());
            }

            if (collision.TryGetComponent<LadderPoint>(out LadderPoint ladderPoint))
            {
                Direction = new Vector2(0, 0);
            }
        }
    }
}