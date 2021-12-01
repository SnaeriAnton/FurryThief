using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogRoom : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _room;

    private bool _fogColor = false;
    private Color _newColor = new Color(0, 0, 0, 0);

    public bool FogColor => _fogColor;

    private void Update()
    {
        ChangeColorFog();
    }

    private void ChangeColorFog()
    {
        if (_fogColor == true)
        {
            _room.color = Color.Lerp(_room.color, _newColor, 3 * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Raccoon>())
        {
            _fogColor = true;
        }
    }
}
