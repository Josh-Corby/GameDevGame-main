using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum GameState
{
    Start,
    Playing,
    Paused,
    GameOver
}

public class GameManager : Singleton<GameManager>
{
    public GameState gameState;
    public int money;

    void Start()
    {
        gameState = GameState.Playing;
        money = 0;
        _UI.UpdateMoney(money);

    }

    void Update()
    {
        _UI.UpdateHealth(_PH.currentHealth);
    }

    public void ChangeGameState(GameState _gameState)
    {
        gameState = _gameState;
    }

    public void AddScore(int _money)
    {
        money += _money;
        _UI.UpdateMoney(money);
    }

}
