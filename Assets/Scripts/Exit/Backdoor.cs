using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backdoor : MonoBehaviour
{
    [SerializeField] private Exit _exit;

    private int _distanceToExit = 2;

    public Vector2 Exit => new Vector2(_exit.transform.position.x + _distanceToExit, _exit.transform.position.y);
}
