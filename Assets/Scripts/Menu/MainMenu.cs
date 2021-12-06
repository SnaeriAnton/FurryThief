using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(ConfigurationLevel))]
public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private ConfigurationLevel _configurationLavel;
    [SerializeField] private ItemsResetter _itemReset;
    [SerializeField] private ItemsManager _itemMnager;
    [SerializeField] Button _newGame;
    [SerializeField] Button _continue;
    [SerializeField] Button _play;
    [SerializeField] private TMP_Text _winGame;
    [SerializeField] private TMP_Text _gameOver;
    [SerializeField] private Raccoon _raccoon;

    private InputSistem _menu;
    private bool _pause = false;

    private void Awake()
    {
        if (_itemMnager != null)
            _itemMnager.Won += Win;
        
        _menu = new InputSistem();
        _menu.Enable();
        _menu.Menu.Menu.performed += ctx => OnPause();
    }

    private void OnDisable()
    {
        _menu.Disable();

        if (_itemMnager != null)
            _itemMnager.Won -= Win;
    }

    private void Start()
    {
        _raccoon.Caught += GameOver;
        if (_configurationLavel.RaccoonPlays == true)
        {
            _panel.SetActive(false);
            _play.gameObject.SetActive(false);
            _continue.gameObject.SetActive(true);
            _newGame.gameObject.SetActive(true);
        }
        else
        {
            if (_itemReset != null)
            {
                _itemReset.ResetItems();
            }

            Time.timeScale = 0;
        }
    }

    private void OnPause()
    {
        if (_pause == false)
        {
            _pause = true;
            Time.timeScale = 0;
            _panel.SetActive(true);
        }
        else
        {
            _pause = false;
            Time.timeScale = 1;
            _panel.SetActive(false);
        }
    }

    private void GameOver()
    {
        Time.timeScale = 0;
        _panel.SetActive(true);
        _gameOver.enabled = true;
        _play.gameObject.SetActive(false);
        _continue.gameObject.SetActive(false);
        _newGame.gameObject.SetActive(true);
        _raccoon.Caught -= GameOver;
    }

    private void Play()
    {
        Time.timeScale = 1;
        _panel.SetActive(false);
        _configurationLavel.SetPlayer();
        _play.gameObject.SetActive(false);
        _continue.gameObject.SetActive(true);
        _newGame.gameObject.SetActive(true);
    }

    private void Continue()
    {
        Time.timeScale = 1;
        _panel.SetActive(false);
    }

    private void StartNewGame()
    {
        if (_itemReset != null)
            _itemReset.ResetItems();

        _configurationLavel.ResetConfiguration();
        SceneManager.LoadScene(0);
    }

    private void Exit()
    {
        Application.Quit();
    }

    private void Win()
    {
        Time.timeScale = 0;
        _panel.SetActive(true);
        _winGame.enabled = true;
        _play.gameObject.SetActive(false);
        _continue.gameObject.SetActive(false);
        _newGame.gameObject.SetActive(true);
    }
}
