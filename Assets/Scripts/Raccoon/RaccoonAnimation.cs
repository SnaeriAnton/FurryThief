using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class RaccoonAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private const string _animatorMove = "Move";

    public void RunRaccoon(bool move)
    {
        MoveRaccoon(move);
    }

    public void IdleRaccoon(bool move)
    {
        MoveRaccoon(move);
    }

    private void MoveRaccoon(bool move)
    {
        _animator.SetBool(_animatorMove, move);
    }
}
