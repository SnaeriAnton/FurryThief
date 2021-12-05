using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Mover : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private Transform _transform;

    private Vector2 _normal;
    private Vector2 _direction;

    public void Move(Vector2 direction, float speed)
    {
        _direction = direction;
        Turn(direction.x);
        Vector2 directionAlongSurface = Project(direction.normalized);
        Vector2 offset = directionAlongSurface * (speed * Time.deltaTime);
        _rigidbody2D.MovePosition(_rigidbody2D.position + offset);
    }

    private void Turn(float direction)
    {
        if (direction == -1)
        {
            _transform.rotation = new Quaternion(0, 180, 0, 0);
        }
        if (direction == 1)
        {
            _transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }

    private Vector2 Project(Vector2 forward)
    {
        return forward - Vector2.Dot(forward, _normal) * _normal;
    }
    

    private void OnCollisionStay2D(Collision2D collision)
    {
        _normal = collision.contacts[0].normal;
        if (_normal.y == 0 || _normal.y > -1)
        {
            _normal = new Vector2(0, 0);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (_direction.x == 1)
        {
            _normal = new Vector2(-1, -1);
        }
        if (_direction.x == -1)
        {
            _normal = new Vector2(1, -1);
        }
    }
}
