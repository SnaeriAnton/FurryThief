using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Grandfather))]
public class GrandfatherVision : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private LayerMask _playerMask;
    [SerializeField] private Grandfather _grandfather;

    private float _distance = 5;
    private bool _lookPlayer = false;
    private Vector2 _origin;

    public event UnityAction OnSeekPlayer;
    public event UnityAction<int> OnLosesPlayer;

    private void Update()
    {
        _origin = new Vector2(_transform.position.x, _transform.position.y - 0.5f);
        RaycastHit2D hit = Physics2D.Raycast(_origin, _transform.right, _distance, _playerMask);

        Debug.DrawRay(_origin, _transform.right, Color.red);

        if (hit == true)
        {
            OnSeekPlayer?.Invoke();
            _lookPlayer = true;
        }

        if (hit == false && _lookPlayer)
        {
            _lookPlayer = false;
            OnLosesPlayer?.Invoke(_grandfather.Taraget);
        }
    }
}
