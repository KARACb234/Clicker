using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuWindow : WindowBase
{
    private ScoreManager _scoreManager;
    private ScoreManager GetScoreManager => _scoreManager;

    private void Awake()
    {
        _scoreManager = GetComponent<ScoreManager>();
    }
    public void OnOpenShop()
    {
        WindowManager.Instance.Show<ShopWindow>();
    }
    public void OnOpenSettings()
    {
        WindowManager.Instance.Show<SettingsWindow>();
    }
    public void OnCloseGame()
    {
        Application.Quit();
        Debug.Log("Выход из игры прошёл успешно");
    }
}
