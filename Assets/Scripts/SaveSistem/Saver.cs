using SaveSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveSystem
{
    public class Saver
    {
        public static Saver Instance { get; private set; }
        private readonly PlayerData playerData;
        public PlayerData GetPlayerData => playerData;
        private readonly BaseController controller;
        public Saver(BaseController baseController) 
        {
            Instance = this;
            playerData = baseController.LoadPlayer();
            controller = baseController;
        }

        public void Save()
        {
            controller.SavePlayer(playerData);
        }
        public PlayerData Load() 
        {
            return controller.LoadPlayer();
        }

        
    }
}
