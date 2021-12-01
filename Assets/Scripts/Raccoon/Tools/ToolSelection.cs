using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolSelection : MonoBehaviour
{
    [SerializeField] private Image _imageTool;
    [SerializeField] private Image _imageFarm;
    [SerializeField] private Sprite _defaultSpriteFram;
    [SerializeField] private Sprite _spriteChoiseFram;
    
    public void  Renderer(Tool item)
    {
        _imageTool.sprite = item.Icon;
    }

    public void SelectTool()
    {
        _imageFarm.sprite = _spriteChoiseFram;
    }

    public void ChangeSelectedTool()
    {
        _imageFarm.sprite = _defaultSpriteFram;
    }
}
