using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaccoonPocket : MonoBehaviour
{
    [SerializeField] private ToolSelection _tamplateTool;
    [SerializeField] private Raccoon _raccoon;

    private List<Tool> _tools = new List<Tool>();
    private List<GameObject> _toolsObjects = new List<GameObject>();
    private List<ToolSelection> _toolsInPocket = new List<ToolSelection>();
    private int _toolNumber = 0;
    private float _stepScrollBar = 1;
    private float _maxValueScrollBar = 1;
    private float _minValueScrollBar = 0;
    private int _nextTool = -1;
    private int _previousTool = 1;

    private GameObject _toolContent;
    private VerticalScrollbar _scrollbar;
    private Scrollbar _verticalScrollBar;

    private int _toolsCount => _toolsInPocket.Count - 1;

    private void Awake()
    {
        FindToolContent();
    }

    public void AddTool(Tool tool)
    {
        _tools.Add(tool);
        AddToolInContainer(tool);
        AddToolInHand(tool);
        CalculationScrollBar();
    }

    public void AddToolInContainer(Tool tool)
    {
        ToolSelection view = Instantiate(_tamplateTool, _toolContent.transform);
        view.Renderer(tool);

        _toolsInPocket.Add(view);
        _toolsInPocket[_toolNumber].SelectTool();
    }

    public void AddToolInOtherContainer()
    {
        FindToolContent();
        _toolsInPocket.Clear();
        foreach (var tool in _tools)
        {
            ToolSelection view = Instantiate(_tamplateTool, _toolContent.transform);
            view.Renderer(tool);
            _toolsInPocket.Add(view);

        }
        if (_tools.Count > 0)
        {
            _toolsInPocket[_toolsInPocket.Count].SelectTool();
        }
        CalculationScrollBar();
    }

    public void SelectNext()
    {
        Select(_nextTool);
    }

    public void SelectPrevious()
    {
        Select(_previousTool);
    }

    private void FindToolContent()
    {
        _toolContent = FindObjectOfType<ContetntTools>().gameObject;
        _scrollbar = FindObjectOfType<VerticalScrollbar>();
        _verticalScrollBar = _scrollbar.GetComponent<Scrollbar>();
    }

    private void Select(int offset)
    {
        if (_toolsInPocket != null)
        {
            _toolsInPocket[_toolNumber].ChangeSelectedTool();
            _toolsObjects[_toolNumber].SetActive(false);
            _toolNumber += (1 * offset);
            _verticalScrollBar.value += (_stepScrollBar * offset);
            if (_toolsCount < _toolNumber)
            {
                SetValue(0, _maxValueScrollBar);
            }
            if (0 > _toolNumber)
            {
                SetValue(_toolsCount, _minValueScrollBar);
            }
            _toolsInPocket[_toolNumber].SelectTool();
            _toolsObjects[_toolNumber].SetActive(true);
        }
    }

    private void SetValue(int toolCount, float valueScrollBar)
    {
        _toolNumber = toolCount;
        _verticalScrollBar.value = valueScrollBar;
    }

    private void CalculationScrollBar()
    {
        if (_toolsCount > 2)
        {
            _stepScrollBar = _maxValueScrollBar / (_toolsInPocket.Count - 1);
        }
    }

    private void AddToolInHand(Tool tool)
    {
        GameObject activetor = Instantiate(tool.ToolObject, _raccoon.Hand.transform);
        _toolsObjects.Add(activetor);

        DisableTool(_toolsObjects);
    }

    private void DisableTool(List<GameObject> tools)
    {
        for (int i = 0; i < tools.Count; i++)
        {
            tools[i].SetActive(false);
        }
        tools[_toolNumber].SetActive(true);
    }

    private void AddTools(List<Tool> tools)
    {
        for (int i = 0; i < tools.Count; i++)
        {
            AddTool(tools[i]);
        }
    }
}
