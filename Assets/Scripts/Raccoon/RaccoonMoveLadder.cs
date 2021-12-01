using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class RaccoonMoveLadder : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;

    private bool _seenLadder = false;
    private bool _onLadder = false;

    public bool OnLadder => _onLadder;

    public event UnityAction Climbed;
    public event UnityAction GotOff;

    public void Move(Vector2 direction)
    {
        transform.position = transform.position + new Vector3(0, direction.y, 0) * 1 * Time.deltaTime;
    }

    public bool ClimbLadder()
    {
        if (_seenLadder == true && _onLadder == false)
        {
            _onLadder = true;
            _rigidbody2D.gravityScale = 0;
            Climbed?.Invoke();
        }
        else
        {
            _onLadder = false;
            _rigidbody2D.gravityScale = 1;
            GotOff?.Invoke();
        }

        return _onLadder;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<Ladder>())
        {
            _seenLadder = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _seenLadder = false;
    }
}
