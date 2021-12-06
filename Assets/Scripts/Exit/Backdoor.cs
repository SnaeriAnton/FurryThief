using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backdoor : MonoBehaviour
{
    [SerializeField] private Exit _exit;

    public Vector2 GetPosition()
    {
        Vector2 position = new Vector2(_exit.transform.position.x + 2, _exit.transform.position.y);
        return position;
    }
}
