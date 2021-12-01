using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInformationPlayer : MonoBehaviour
{
    [SerializeField] private ConfigurationLevel _configurationLevel;

    private List<Subject> _raccoonItemInBag;
    private List<Tool> _raccoonToolInPocket;
    private int _score;
    private int _bagCopacity;

    public int Score => _score;
    public int BagCopacity => _bagCopacity;
    public bool RaccoonPlays => _configurationLevel.RaccoonPlays;

    public List<Tool> GetTools()
    {
        return _raccoonToolInPocket;
    }

    public List<Subject> GetItems()
    {
        return _raccoonItemInBag;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<RaccoonBag>(out RaccoonBag bag))
        {
            _raccoonItemInBag = bag.GetItems();
            _bagCopacity = bag.GetMaxItem();
        }

        if (collision.TryGetComponent<RaccoonPocket>(out RaccoonPocket packet))
        {
            _raccoonToolInPocket = packet.GetTools();
        }

        if (collision.TryGetComponent<Raccoon>(out Raccoon score))
        {
            _score = score.Score;
        }
    }
}
