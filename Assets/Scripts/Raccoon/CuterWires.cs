using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuterWires : MonoBehaviour
{
    private SignalingController _signalingController;

    public void CutWires()
    {
        if (_signalingController != null)
        {
            _signalingController.DisableSignaling();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<SignalingController>(out SignalingController signalingController))
        {
            _signalingController = signalingController;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _signalingController = null;
    }
}
