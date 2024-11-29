using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SaveSystem
{
    public class BaseController
    {
        private SaveParametresToJson _saveCurrency;
        private GameManager _gameManager;
        public BaseController(GameManager gameManager)
        {
            _gameManager = gameManager;
            _saveCurrency = new SaveParametresToJson();
        }
        public void SavePlayer(PlayerData playerParametres)
        {
            _saveCurrency.Save(playerParametres);
        }
        public PlayerData LoadPlayer()
        {
            PlayerData playerData = _saveCurrency.Load();
            return playerData;
        }
    }
}