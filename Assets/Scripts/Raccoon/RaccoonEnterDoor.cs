using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaccoonEnterDoor : MonoBehaviour
{
    [SerializeField] private Transform _transform;

    private Vector2 _doorPositionBasment;
    private bool _nearBasmenDoor = false;

    public void GetDown()
    {
        if (_nearBasmenDoor)
        {
            _transform.position = _doorPositionBasment;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent<BasementDoor>(out BasementDoor doorPositionBasment))
        {
            _nearBasmenDoor = true;
            _doorPositionBasment = doorPositionBasment.GetPositionDoor();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _nearBasmenDoor = false;
    }
}
