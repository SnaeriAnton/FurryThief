using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PaperShower : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Raccoon>())
        {
            _spriteRenderer.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _spriteRenderer.enabled = false; ;
    }
}
